// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.Instructions;

/// <summary>
/// TryEnd
/// </summary>
public sealed class TryEnd : BaseIRInstruction
{
	public TryEnd()
		: base(0, 0)
	{
	}

	public override bool IgnoreDuringCodeGeneration => true;

	public override bool IgnoreInstructionBasicBlockTargets => true;
}