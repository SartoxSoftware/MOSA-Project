// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.ARM32.Transforms.BaseIR;

/// <summary>
/// And64
/// </summary>
public sealed class And64 : BaseIRTransform
{
	public And64() : base(IR.And64, TransformType.Manual | TransformType.Transform)
	{
	}

	public override void Transform(Context context, Transform transform)
	{
		transform.SplitOperand(context.Result, out var resultLow, out var resultHigh);
		transform.SplitOperand(context.Operand1, out var op1L, out var op1H);
		transform.SplitOperand(context.Operand2, out var op2L, out var op2H);

		op1L = MoveConstantToRegister(transform, context, op1L);
		op1H = MoveConstantToRegister(transform, context, op1H);
		op2L = MoveConstantToRegisterOrImmediate(transform, context, op2L);
		op2H = MoveConstantToRegisterOrImmediate(transform, context, op2H);

		context.SetInstruction(ARM32.And, resultLow, op1L, op2L);
		context.AppendInstruction(ARM32.And, resultHigh, op1H, op2H);
	}
}
