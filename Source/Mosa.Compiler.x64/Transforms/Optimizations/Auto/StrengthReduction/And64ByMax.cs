// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.x64.Transforms.Optimizations.Auto.StrengthReduction;

public sealed class And64ByMax : BaseTransform
{
	public And64ByMax() : base(X64.And64, TransformType.Auto | TransformType.Optimization)
	{
	}

	public override bool Match(Context context, Transform transform)
	{
		if (!context.Operand2.IsResolvedConstant)
			return false;

		if (context.Operand2.ConstantUnsigned64 != 0xFFFFFFFF)
			return false;

		if (AreAnyStatusFlagsUsed(context, transform.Window))
			return false;

		return true;
	}

	public override void Transform(Context context, Transform transform)
	{
		var result = context.Result;

		var e1 = Operand.CreateConstant(To64(0xFFFFFFFF));

		context.SetInstruction(X64.Mov64, result, e1);
	}
}

public sealed class And64ByMax_v1 : BaseTransform
{
	public And64ByMax_v1() : base(X64.And64, TransformType.Auto | TransformType.Optimization)
	{
	}

	public override bool Match(Context context, Transform transform)
	{
		if (!context.Operand1.IsResolvedConstant)
			return false;

		if (context.Operand1.ConstantUnsigned64 != 0xFFFFFFFF)
			return false;

		if (AreAnyStatusFlagsUsed(context, transform.Window))
			return false;

		return true;
	}

	public override void Transform(Context context, Transform transform)
	{
		var result = context.Result;

		var e1 = Operand.CreateConstant(To64(0xFFFFFFFF));

		context.SetInstruction(X64.Mov64, result, e1);
	}
}
