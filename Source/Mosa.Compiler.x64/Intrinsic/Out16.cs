﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.x64.Intrinsic;

/// <summary>
/// Intrinsic Methods
/// </summary>
internal static partial class IntrinsicMethods
{
	[IntrinsicMethod("Mosa.Compiler.x64.Intrinsic::Out16")]
	private static void Out16(Context context, Transform transform)
	{
		context.SetInstruction(X64.Out16, null, context.Operand1, context.Operand2);
	}
}
