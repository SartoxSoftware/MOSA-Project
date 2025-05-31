// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace System.Runtime.CompilerServices;

/// <summary>
/// Reserved by the compiler for tracking metadata.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, Inherited = false)]
public sealed class NullableAttribute : Attribute
{
	public readonly byte[] NullableFlags;

	// TODO: Verify the collection expression works
	public NullableAttribute(byte value) => NullableFlags = [value];

	public NullableAttribute(byte[] value) => NullableFlags = value;
}