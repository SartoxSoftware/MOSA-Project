﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.x86.Intrinsic;

/// <summary>
/// Intrinsic Methods
/// </summary>
internal static partial class IntrinsicMethods
{
	[IntrinsicMethod("Mosa.Compiler.x86.Intrinsic::SetCR3")]
	private static void SetCR3(Context context, Transform transform)
	{
		Operand operand1 = context.Operand1;

		Operand eax = transform.PhysicalRegisters.Allocate32(CPURegister.EAX);
		Operand cr = transform.PhysicalRegisters.Allocate32(CPURegister.CR3);

		context.SetInstruction(X86.Mov32, eax, operand1);
		context.AppendInstruction(X86.MovCRStore32, null, cr, eax);
	}
}
