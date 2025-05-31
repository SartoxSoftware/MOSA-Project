using System.Diagnostics.CodeAnalysis;

namespace System;

public readonly struct Boolean : IComparable, IComparable<bool>, IConvertible, IEquatable<bool>, IParsable<bool>, ISpanParsable<bool>
{
	public static readonly string FalseString = FalseLiteral, TrueString = TrueLiteral;

	private const string FalseLiteral = "False", TrueLiteral = "True";
	private const int FalseValue = 0, TrueValue = 1;

	private readonly bool backingValue;

	public int CompareTo(bool value) => backingValue switch
	{
		false when value => -1,
		true when !value => 1,
		_ => 0
	};

	public int CompareTo(object? obj)
	{
		switch (obj)
		{
			case null: return 1;
			case bool value: return CompareTo(value);
			default:
			{
				Internal.Exceptions.Generic.ThrowIncorrectTypeException(nameof(obj));
				return 1;
			}
		}
	}

	public bool Equals(bool obj) => backingValue == obj.backingValue;

	public override bool Equals([NotNullWhen(true)] object? obj) => obj is bool value && Equals(value);

	public override int GetHashCode() => backingValue ? TrueValue : FalseValue;

	public TypeCode GetTypeCode() => TypeCode.Boolean;

	public static bool Parse(ReadOnlySpan<char> value)
	{
		if (value == TrueLiteral)
			return true;

		if (value == FalseLiteral)
			return false;

		Internal.Exceptions.Generic.Format();
		return false;
	}

	public static bool Parse(string value)
	{
		ArgumentNullException.ThrowIfNull(value);

		switch (value)
		{
			case TrueLiteral: return true;
			case FalseLiteral: return false;
			default:
			{
				Internal.Exceptions.Generic.Format();
				return false;
			}
		}
	}

	bool IConvertible.ToBoolean(IFormatProvider? provider) => backingValue;

	byte IConvertible.ToByte(IFormatProvider? provider) => backingValue ? (byte)1 : (byte)0;

	char IConvertible.ToChar(IFormatProvider? provider)
	{
		Internal.Exceptions.Generic.InvalidCast();
		return '\0';
	}

	DateTime IConvertible.ToDateTime(IFormatProvider? provider)
	{
		Internal.Exceptions.Generic.InvalidCast();
		return DateTime.Now;
	}

	decimal IConvertible.ToDecimal(IFormatProvider? provider) => backingValue ? 1 : 0;

	double IConvertible.ToDouble(IFormatProvider? provider) => backingValue ? 1 : 0;

	short IConvertible.ToInt16(IFormatProvider? provider) => backingValue ? (short)1 : (short)0;

	int IConvertible.ToInt32(IFormatProvider? provider) => backingValue ? 1 : 0;

	long IConvertible.ToInt64(IFormatProvider? provider) => backingValue ? 1 : 0;

	sbyte IConvertible.ToSByte(IFormatProvider? provider) => backingValue ? (sbyte)1 : (sbyte)0;

	float IConvertible.ToSingle(IFormatProvider? provider) => backingValue ? 1 : 0;

	object IConvertible.ToType(Type type, IFormatProvider? provider)
	{
		if (type == typeof(bool))
			return this;

		Internal.Exceptions.Generic.NotSupported();
		return null;
	}

	ushort IConvertible.ToUInt16(IFormatProvider? provider) => backingValue ? (ushort)1 : (ushort)0;

	uint IConvertible.ToUInt32(IFormatProvider? provider) => backingValue ? 1U : 0U;

	ulong IConvertible.ToUInt64(IFormatProvider? provider) => backingValue ? 1UL : 0UL;

	static bool IParsable<bool>.Parse(string s, IFormatProvider? provider) => Parse(s);

	static bool IParsable<bool>.TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, out bool result)
		=> TryParse(s, out result);

	static bool ISpanParsable<bool>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider) => Parse(s);

	static bool ISpanParsable<bool>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out bool result)
		=> TryParse(s, out result);

	public override string ToString() => backingValue ? TrueLiteral : FalseLiteral;

	public string ToString(IFormatProvider? provider) => ToString();

	public bool TryFormat(Span<char> destination, out int charsWritten)
	{
		charsWritten = 0;

		var literal = backingValue ? TrueLiteral : FalseLiteral;

		for (var i = 0; i < literal.Length; i++)
		{
			if (i >= destination.Length)
				return false;

			destination[i] = literal[i];
			charsWritten++;
		}

		return true;
	}

	public static bool TryParse(ReadOnlySpan<char> value, out bool result)
	{
		if (value == TrueLiteral)
		{
			result = true;
			return true;
		}

		if (value == FalseLiteral)
		{
			result = false;
			return true;
		}

		result = false;
		return false;
	}

	public static bool TryParse([NotNullWhen(true)] string? value, out bool result)
	{
		switch (value)
		{
			case TrueLiteral:
			{
				result = true;
				return true;
			}
			case FalseLiteral:
			{
				result = false;
				return true;
			}
			default:
			{
				result = false;
				return false;
			}
		}
	}
}
