// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.Instructions;

/// <summary>
/// StoreParamCompound
/// </summary>
public sealed class StoreParamCompound : BaseIRInstruction
{
	public StoreParamCompound()
		: base(2, 0)
	{
	}

	public override bool IsMemoryWrite => true;

	public override bool IsParameterStore => true;
}
