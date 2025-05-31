// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace System.Runtime.CompilerServices;

/// <summary>
/// Reserved by the compiler for tracking metadata.
/// </summary>
[AttributeUsage(AttributeTargets.All, Inherited = false)]
internal sealed class IsReadOnlyAttribute : Attribute;