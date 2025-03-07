// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.Transforms.Optimizations.Auto.Algebraic;

public sealed class Signed32AAMinusBB : BaseTransform
{
	public Signed32AAMinusBB() : base(IR.Sub32, TransformType.Auto | TransformType.Optimization)
	{
	}

	public override bool Match(Context context, Transform transform)
	{
		if (!context.Operand1.IsVirtualRegister)
			return false;

		if (!context.Operand2.IsVirtualRegister)
			return false;

		if (!context.Operand1.IsDefinedOnce)
			return false;

		if (context.Operand1.Definitions[0].Instruction != IR.MulSigned32)
			return false;

		if (!context.Operand2.IsDefinedOnce)
			return false;

		if (context.Operand2.Definitions[0].Instruction != IR.MulSigned32)
			return false;

		if (!AreSame(context.Operand1.Definitions[0].Operand1, context.Operand1.Definitions[0].Operand2))
			return false;

		if (!AreSame(context.Operand2.Definitions[0].Operand1, context.Operand2.Definitions[0].Operand2))
			return false;

		return true;
	}

	public override void Transform(Context context, Transform transform)
	{
		var result = context.Result;

		var t1 = context.Operand1.Definitions[0].Operand1;
		var t2 = context.Operand2.Definitions[0].Operand1;

		var v1 = transform.VirtualRegisters.Allocate32();
		var v2 = transform.VirtualRegisters.Allocate32();

		context.SetInstruction(IR.Add32, v1, t1, t2);
		context.AppendInstruction(IR.Sub32, v2, t1, t2);
		context.AppendInstruction(IR.MulSigned32, result, v2, v1);
	}
}
