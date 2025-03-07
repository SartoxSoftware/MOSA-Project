﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

// ==++==
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--==
/*============================================================
**
** Class:  ObsoleteAttribute
**
**
** Purpose: Attribute for functions, etc that will be removed.
**
**
===========================================================*/

namespace System;

// This attribute is attached to members that are not to be used any longer.
// Message is some human readable explanation of what to use
// Error indicates if the compiler should treat usage of such a method as an
//   error. (this would be used if the actual implementation of the obsolete
//   method's implementation had changed).
//
[Serializable]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum |
                AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Delegate
	, Inherited = false)]

//[System.Runtime.InteropServices.ComVisible(true)]
public sealed class ObsoleteAttribute : Attribute
{
	private readonly String _message;
	private readonly bool _error;

	public ObsoleteAttribute()
	{
		_message = null;
		_error = false;
	}

	public ObsoleteAttribute(String message)
	{
		_message = message;
		_error = false;
	}

	public ObsoleteAttribute(String message, bool error)
	{
		_message = message;
		_error = error;
	}

	public String Message
	{
		get { return _message; }
	}

	public bool IsError
	{
		get { return _error; }
	}
}
