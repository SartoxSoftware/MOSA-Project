﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.x64.Intrinsic;

/// <summary>
/// Intrinsic Methods
/// </summary>
internal static partial class IntrinsicMethods
{
	[IntrinsicMethod("Mosa.Compiler.x64.Intrinsic::SetSegments")]
	private static void SetSegments(Context context, Transform transform)
	{
		var operand1 = context.Operand1;
		var operand2 = context.Operand2;
		var operand3 = context.Operand3;
		var operand4 = context.Operand4;
		var operand5 = context.Operand5;

		var ds = transform.PhysicalRegisters.Allocate64(CPURegister.DS);
		var es = transform.PhysicalRegisters.Allocate64(CPURegister.ES);
		var fs = transform.PhysicalRegisters.Allocate64(CPURegister.FS);
		var gs = transform.PhysicalRegisters.Allocate64(CPURegister.GS);
		var ss = transform.PhysicalRegisters.Allocate64(CPURegister.SS);

		context.SetInstruction(X64.MovStoreSeg64, ds, operand1);
		context.AppendInstruction(X64.MovStoreSeg64, es, operand2);
		context.AppendInstruction(X64.MovStoreSeg64, fs, operand3);
		context.AppendInstruction(X64.MovStoreSeg64, gs, operand4);
		context.AppendInstruction(X64.MovStoreSeg64, ss, operand5);
	}
}
