﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework.Transforms.Optimizations.Manual.BitValue;

public sealed class BranchObject : BaseTransform
{
	public BranchObject() : base(IR.BranchObject, TransformType.Manual | TransformType.Optimization, 100)
	{
	}

	public override bool Match(Context context, Transform transform)
	{
		if (context.Block.NextBlocks.Count == 1)
			return false;

		var value = EvaluateCompare(context.Operand1, context.Operand2, context.ConditionCode);

		if (!value.HasValue)
			return false;

		return true;
	}

	public override void Transform(Context context, Transform transform)
	{
		var target = context.BranchTarget1;
		var block = context.Block;

		var value = EvaluateCompare(context.Operand1, context.Operand2, context.ConditionCode);

		if (!value.Value)
		{
			context.SetNop();

			Framework.Transform.UpdatePhiBlock(target);
		}
		else
		{
			var phiBlock = GetOtherBranchTarget(block, target);

			context.SetInstruction(IR.Jmp, target);

			RemoveRemainingInstructionInBlock(context);

			Framework.Transform.UpdatePhiBlock(phiBlock);
		}
	}
}
