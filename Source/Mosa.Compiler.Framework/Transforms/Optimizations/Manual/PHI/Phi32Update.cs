﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework.Transforms.Optimizations.Manual.Phi;

public sealed class Phi32Update : BasePhiTransform
{
	public Phi32Update() : base(IR.Phi32, TransformType.Manual | TransformType.Optimization)
	{
	}

	public override bool Match(Context context, Transform transform)
	{
		return context.OperandCount != context.Block.PreviousBlocks.Count;
	}

	public override void Transform(Context context, Transform transform)
	{
		UpdatePhi(context.Node);
	}
}
