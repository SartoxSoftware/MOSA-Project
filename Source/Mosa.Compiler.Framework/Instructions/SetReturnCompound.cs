// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.Instructions;

/// <summary>
/// SetReturnCompound
/// </summary>
public sealed class SetReturnCompound : BaseIRInstruction
{
	public SetReturnCompound()
		: base(1, 0)
	{
	}

	public override bool IsFlowNext => false;

	public override bool IsReturn => true;
}