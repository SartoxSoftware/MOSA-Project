﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.x86.Transforms.Optimizations.Manual.Rewrite;

public sealed class Mov32ToXor32 : BaseTransform
{
	public Mov32ToXor32() : base(X86.Mov32, TransformType.Manual | TransformType.Optimization)
	{
	}

	public override bool Match(Context context, Transform transform)
	{
		if (!context.Operand1.IsConstantZero)
			return false;

		if (AreAnyStatusFlagsUsed(context, transform.Window))
			return false;

		return true;
	}

	public override void Transform(Context context, Transform transform)
	{
		context.SetInstruction(X86.Xor32, context.Result, context.Result, context.Result);
	}
}
