﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework.Platform;

public abstract class BaseOpcodeEncoder
{
	public abstract void WriteTo(Stream writer);
}
