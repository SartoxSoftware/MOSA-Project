// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.Instructions;

/// <summary>
/// UnstableRegionEnd
/// </summary>
public sealed class UnstableRegionEnd : BaseIRInstruction
{
	public UnstableRegionEnd()
		: base(0, 0)
	{
	}

	public override bool IgnoreDuringCodeGeneration => true;
}
