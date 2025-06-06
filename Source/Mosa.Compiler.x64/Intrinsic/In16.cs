﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.x64.Intrinsic;

/// <summary>
/// Intrinsic Methods
/// </summary>
internal static partial class IntrinsicMethods
{
	[IntrinsicMethod("Mosa.Compiler.x64.Intrinsic::In16")]
	private static void In16(Context context, Transform transform)
	{
		var v1 = transform.VirtualRegisters.Allocate64();

		var result = context.Result;

		context.SetInstruction(X64.In16, v1, context.Operand1);
		context.AppendInstruction(X64.Movzx16To64, result, v1);
	}
}
