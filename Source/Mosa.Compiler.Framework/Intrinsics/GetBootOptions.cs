﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework.Intrinsics;

/// <summary>
/// Intrinsic Methods
/// </summary>
internal static partial class IntrinsicMethods
{
	[IntrinsicMethod("Mosa.Runtime.Intrinsic::GetBootOptions")]
	private static void GetBootOptions(Context context, Transform transform)
	{
		context.SetInstruction(transform.MoveInstruction, context.Result, Operand.CreateLabel(Metadata.BootOptions, transform.Is32BitPlatform));
	}
}
