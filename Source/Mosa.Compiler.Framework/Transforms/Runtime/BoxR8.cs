// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework.Transforms.Runtime;

/// <summary>
/// BoxR8
/// </summary>
public sealed class BoxR8 : BaseRuntimeTransform
{
	public BoxR8() : base(IR.BoxR8, TransformType.Manual | TransformType.Transform)
	{
	}

	public override void Transform(Context context, Transform transform)
	{
		SetVMCall(transform, context, "BoxR8", context.Result, context.GetOperands());
	}
}
