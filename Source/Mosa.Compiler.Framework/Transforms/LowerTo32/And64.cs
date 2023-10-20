﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework.Transforms.LowerTo32;

public sealed class And64 : BaseLower32Transform
{
	public And64() : base(IRInstruction.And64, TransformType.Manual | TransformType.Optimization)
	{
	}

	public override void Transform(Context context, TransformContext transform)
	{
		var result = context.Result;
		var operand1 = context.Operand1;
		var operand2 = context.Operand2;

		var op0Low = transform.VirtualRegisters.Allocate32();
		var op0High = transform.VirtualRegisters.Allocate32();
		var op1Low = transform.VirtualRegisters.Allocate32();
		var op1High = transform.VirtualRegisters.Allocate32();
		var resultLow = transform.VirtualRegisters.Allocate32();
		var resultHigh = transform.VirtualRegisters.Allocate32();

		context.SetInstruction(IRInstruction.GetLow32, op0Low, operand1);
		context.AppendInstruction(IRInstruction.GetHigh32, op0High, operand1);
		context.AppendInstruction(IRInstruction.GetLow32, op1Low, operand2);
		context.AppendInstruction(IRInstruction.GetHigh32, op1High, operand2);

		context.AppendInstruction(IRInstruction.And32, resultLow, op0Low, op1Low);
		context.AppendInstruction(IRInstruction.And32, resultHigh, op0High, op1High);
		context.AppendInstruction(IRInstruction.To64, result, resultLow, resultHigh);
	}
}