// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.ARM32.Transforms.BaseIR;

/// <summary>
/// StoreManagedPointer
/// </summary>
public sealed class StoreManagedPointer : BaseIRTransform
{
	public StoreManagedPointer() : base(IR.StoreManagedPointer, TransformType.Manual | TransformType.Transform)
	{
	}

	public override void Transform(Context context, Transform transform)
	{
		TransformStore(transform, context, ARM32.Str32, context.Operand1, context.Operand2, context.Operand3);
	}
}
