// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.Instructions;

/// <summary>
/// Unbox
/// </summary>
public sealed class Unbox : BaseIRInstruction
{
	public Unbox()
		: base(2, 1)
	{
	}

	public override bool IsMemoryWrite => true;

	public override bool IsMemoryRead => true;
}
