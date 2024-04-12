// Copyright (c) MOSA Project. Licensed under the New BSD License.

using System.Diagnostics.CodeAnalysis;
using Mosa.Kernel.BareMetal;
using Mosa.Runtime;
using Mosa.Runtime.x86;

namespace Mosa.UnitTests.BareMetal.x86;

public static class UnitTestEngine
{
	private const uint MaxParameters = 8; // Max 32-bit parameter count

	private static ushort comPort;

	public static void Setup(ushort port)
	{
		comPort = port;

		Serial.Setup(port);
	}

	[DoesNotReturn]
	public static void EnterTestReadyLoop()
	{
		SendResponse(0, 0); // Ready signal

		var stackPointer = new Pointer(Native.AllocateStackSpace(MaxParameters * 4));

		for (;;)
		{
			var unitTestId = (uint)RetrieveInt32();
			var serializedMessageSize = RetrieveByte();
			var methodAddress = (uint)RetrieveInt32();
			var methodReturnResultType = RetrieveInt32();
			var methodParameterCount = RetrieveInt32();

			for (var i = 0; i < methodParameterCount; i++)
			{
				var value = RetrieveInt32();
				stackPointer.Store32(i * 4, value);
			}

			var testResult = 0UL;
			switch (methodReturnResultType)
			{
				case 0: Native.FrameCall(methodAddress); break;
				case 1: testResult = Native.FrameCallRetU4(methodAddress); break;
				case 2: testResult = Native.FrameCallRetU8(methodAddress); break;
				case 3: testResult = Native.FrameCallRetR8(methodAddress); break;
			}

			SendResponse(unitTestId, testResult);
		}
	}

	private static int RetrieveInt32()
	{
		int value = RetrieveByte();
		value += RetrieveByte() << 8;
		value += RetrieveByte() << 16;
		value += RetrieveByte() << 24;

		return value;
	}

	private static void SendResponse(uint id, ulong data)
	{
		SendUInt32(id);
		SendUInt64(data);
	}

	private static void SendUInt64(ulong i)
	{
		SendUInt32((uint)(i & 0xFFFFFFFF));
		SendUInt32((uint)((i >> 32) & 0xFFFFFFFF));
	}

	private static void SendUInt32(uint i) => SendInt32((int)i);

	private static void SendInt32(int i)
	{
		SendByte((byte)(i & 0xFF));
		SendByte((byte)((i >> 8) & 0xFF));
		SendByte((byte)((i >> 16) & 0xFF));
		SendByte((byte)((i >> 24) & 0xFF));
	}

	private static byte RetrieveByte() => Serial.Read(comPort);

	private static void SendByte(byte b) => Serial.Write(comPort, b);
}
