// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Compiler.x86.Transforms.BaseIR;

/// <summary>
/// RemSigned32
/// </summary>
public sealed class RemSigned32 : BaseIRTransform
{
	public RemSigned32() : base(IR.RemSigned32, TransformType.Manual | TransformType.Transform)
	{
	}

	public override void Transform(Context context, Transform transform)
	{
		var result = context.Result;
		var operand1 = context.Operand1;
		var operand2 = context.Operand2;

		var v1 = transform.VirtualRegisters.Allocate32();
		var v2 = transform.VirtualRegisters.Allocate32();

		context.SetInstruction(X86.Cdq32, v1, operand1);
		context.AppendInstruction2(X86.IDiv32, v2, result, operand1, v1, operand2);
	}
}
