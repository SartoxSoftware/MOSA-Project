﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework;

public delegate void IntrinsicMethodDelegate(Context context, Transform transform);

/// <summary>
/// Used for defining targets when using intrinsic replacements
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class IntrinsicMethodAttribute : Attribute
{
	public string Target { get; }

	public IntrinsicMethodAttribute(string target)
	{
		Target = target;
	}
}
