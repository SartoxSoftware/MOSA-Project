﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace System.Collections.Generic;

/// <summary>
/// Represents a strongly-typed, read-only collection of elements.
/// </summary>
/// <typeparam name="T">The type of the elements.</typeparam>
public interface IReadOnlyCollection<out T> : IEnumerable<T>
{
	/// <summary>
	/// Gets the number of elements in the collection.
	/// </summary>
	int Count { get; }
}
