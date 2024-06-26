// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.x86.Transforms.Optimizations.Manual.Size;

public sealed class Add32By2ToInc32 : BaseTransform
{
	public Add32By2ToInc32() : base(X86.Add32, TransformType.Manual | TransformType.Optimization)
	{
	}

	public override bool Match(Context context, Transform transform)
	{
		if (!transform.IsLowerCodeSize)
			return false;

		if (!context.Operand2.IsResolvedConstant)
			return false;

		if (context.Operand2.ConstantUnsigned64 != 2)
			return false;

		if (context.Operand1.Register == CPURegister.ESP)
			return false;

		if (!AreSame(context.Operand1, context.Result))
			return false;

		if (AreAnyStatusFlagsUsed(context, transform.Window))
			return false;

		return true;
	}

	public override void Transform(Context context, Transform transform)
	{
		var result = context.Result;

		context.SetInstruction(X86.Inc32, result, result);
		context.AppendInstruction(X86.Inc32, result, result);
	}
}
