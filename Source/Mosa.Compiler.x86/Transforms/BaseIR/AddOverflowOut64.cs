// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.x86.Transforms.BaseIR;

/// <summary>
/// AddOverflowOut64
/// </summary>
public sealed class AddOverflowOut64 : BaseIRTransform
{
	public AddOverflowOut64() : base(IR.AddOverflowOut64, TransformType.Manual | TransformType.Transform)
	{
	}

	public override void Transform(Context context, Transform transform)
	{
		var result2 = context.Result2;

		transform.SplitOperand(context.Result, out var resultLow, out var resultHigh);
		transform.SplitOperand(context.Operand1, out var op1L, out var op1H);
		transform.SplitOperand(context.Operand2, out var op2L, out var op2H);

		var v1 = transform.VirtualRegisters.Allocate32();

		context.SetInstruction(X86.Add32, resultLow, op1L, op2L);
		context.AppendInstruction(X86.Adc32, resultHigh, op1H, op2H);
		context.AppendInstruction(X86.Setcc, ConditionCode.Overflow, v1);
		context.AppendInstruction(X86.Movzx8To32, result2, v1);
	}
}
