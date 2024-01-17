// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.Instructions;

/// <summary>
/// MulOverflowOut64
/// </summary>
public sealed class MulOverflowOut64 : BaseIRInstruction
{
	public MulOverflowOut64()
		: base(2, 2)
	{
	}

	public override bool IsCommutative => true;
}