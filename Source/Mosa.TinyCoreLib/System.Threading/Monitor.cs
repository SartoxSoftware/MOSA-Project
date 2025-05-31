using System.Runtime.Versioning;
using Internal;

namespace System.Threading;

public static class Monitor
{
	public static long LockContentionCount => throw new NotImplementedException();

	public static void Enter(object obj) => Impl.Monitor.Enter(obj);

	public static void Enter(object obj, ref bool lockTaken)
	{
		ArgumentNullException.ThrowIfNull(obj, nameof(obj));

		if (lockTaken)
			Exceptions.Monitor.ThrowLockTakenException(nameof(lockTaken));

		Impl.Monitor.ReliableEnter(obj, ref lockTaken);

		//Debug.Assert(lockTaken);
	}

	public static void Exit(object obj) => Impl.Monitor.Exit(obj);

	public static bool IsEntered(object obj) => throw new NotImplementedException();

	public static void Pulse(object obj) => throw new NotImplementedException();

	public static void PulseAll(object obj) => throw new NotImplementedException();

	public static bool TryEnter(object obj) => throw new NotImplementedException();

	public static void TryEnter(object obj, ref bool lockTaken) => throw new NotImplementedException();

	public static bool TryEnter(object obj, int millisecondsTimeout) => throw new NotImplementedException();

	public static void TryEnter(object obj, int millisecondsTimeout, ref bool lockTaken)
		=> throw new NotImplementedException();

	public static bool TryEnter(object obj, TimeSpan timeout) => throw new NotImplementedException();

	public static void TryEnter(object obj, TimeSpan timeout, ref bool lockTaken) => throw new NotImplementedException();

	[UnsupportedOSPlatform("browser")]
	public static bool Wait(object obj) => throw new NotImplementedException();

	[UnsupportedOSPlatform("browser")]
	public static bool Wait(object obj, int millisecondsTimeout) => throw new NotImplementedException();

	[UnsupportedOSPlatform("browser")]
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) => throw new NotImplementedException();

	[UnsupportedOSPlatform("browser")]
	public static bool Wait(object obj, TimeSpan timeout) => throw new NotImplementedException();

	[UnsupportedOSPlatform("browser")]
	public static bool Wait(object obj, TimeSpan timeout, bool exitContext) => throw new NotImplementedException();
}
