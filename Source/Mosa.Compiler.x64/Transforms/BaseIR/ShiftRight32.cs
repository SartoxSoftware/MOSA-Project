// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.x64.Transforms.BaseIR;

/// <summary>
/// ShiftRight32
/// </summary>
public sealed class ShiftRight32 : BaseIRTransform
{
	public ShiftRight32() : base(IR.ShiftRight32, TransformType.Manual | TransformType.Transform)
	{
	}

	public override void Transform(Context context, Transform transform)
	{
		context.ReplaceInstruction(X64.Shr32);
	}
}
