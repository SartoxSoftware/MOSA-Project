using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Text;

public sealed class StringBuilder : ISerializable
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterpolatedStringHandler]
	public struct AppendInterpolatedStringHandler
	{
		private object _dummy;

		private int _dummyPrimitive;

		public AppendInterpolatedStringHandler(int literalLength, int formattedCount, StringBuilder stringBuilder)
		{
			throw null;
		}

		public AppendInterpolatedStringHandler(int literalLength, int formattedCount, StringBuilder stringBuilder, IFormatProvider? provider)
		{
			throw null;
		}

		public void AppendFormatted(object? value, int alignment = 0, string? format = null)
		{
		}

		public void AppendFormatted(ReadOnlySpan<char> value)
		{
		}

		public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, string? format = null)
		{
		}

		public void AppendFormatted(string? value)
		{
		}

		public void AppendFormatted(string? value, int alignment = 0, string? format = null)
		{
		}

		public void AppendFormatted<T>(T value)
		{
		}

		public void AppendFormatted<T>(T value, int alignment)
		{
		}

		public void AppendFormatted<T>(T value, int alignment, string? format)
		{
		}

		public void AppendFormatted<T>(T value, string? format)
		{
		}

		public void AppendLiteral(string value)
		{
		}
	}

	public struct ChunkEnumerator
	{
		private object _dummy;

		private int _dummyPrimitive;

		public ReadOnlyMemory<char> Current
		{
			get
			{
				throw null;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ChunkEnumerator GetEnumerator()
		{
			throw null;
		}

		public bool MoveNext()
		{
			throw null;
		}
	}

	public int Capacity
	{
		get => capacity;
		set
		{
			if (value < Length || value > MaxCapacity)
				Internal.Exceptions.Generic.ParameterOutOfRange(nameof(value));

			EnsureCapacity(value);
			capacity = value;
		}
	}

	[IndexerName("Chars")]
	public char this[int index]
	{
		get
		{
			if (index < 0 || index >= Length)
				Internal.Exceptions.Generic.IndexOutOfRange();

			return characters[index];
		}
		set
		{
			if (index < 0 || index >= Length)
				Internal.Exceptions.Generic.ParameterOutOfRange(nameof(index));

			characters[index] = value;
		}
	}

	public int Length
	{
		get => length;
		set
		{
			if (value < 0 || value > MaxCapacity)
				Internal.Exceptions.Generic.ParameterOutOfRange(nameof(value));

			if (value > Capacity)
			{
				Capacity = value;
			}
			else if (value > length)
			{
				for (var i = length; i < value; i++)
					this[i] = '\0';
			}

			length = value;
		}
	}

	public int MaxCapacity { get; }

	private char[] characters;
	private int capacity, length;

	public StringBuilder()
	{
		characters = new char[byte.MaxValue];
		capacity = characters.Length;
		MaxCapacity = int.MaxValue;
	}

	public StringBuilder(int capacity)
	{
		if (capacity < 0)
			Internal.Exceptions.Generic.ParameterOutOfRange(nameof(capacity));

		characters = new char[capacity];
		this.capacity = capacity;
		MaxCapacity = int.MaxValue;
	}

	public StringBuilder(int capacity, int maxCapacity)
	{
		if (capacity < 0 || capacity > maxCapacity)
			Internal.Exceptions.Generic.ParameterOutOfRange(nameof(capacity));

		if (maxCapacity < 1)
			Internal.Exceptions.Generic.ParameterOutOfRange(nameof(capacity));

		characters = new char[capacity];
		this.capacity = capacity;
		MaxCapacity = maxCapacity;
	}

	public StringBuilder(string? value)
	{
	}

	public StringBuilder(string? value, int capacity)
	{
	}

	public StringBuilder(string? value, int startIndex, int length, int capacity)
	{
	}

	public StringBuilder Append(bool value)
	{
		throw null;
	}

	public StringBuilder Append(byte value)
	{
		throw null;
	}

	public StringBuilder Append(char value)
	{
		EnsureCapacity(Length + 1);

		characters[Length++] = value;
		return this;
	}

	[CLSCompliant(false)]
	public unsafe StringBuilder Append(char* value, int valueCount)
	{
		throw null;
	}

	public StringBuilder Append(char value, int repeatCount)
	{
		if (repeatCount < 0)
			Internal.Exceptions.Generic.ParameterOutOfRange(nameof(repeatCount));

		for (var i = 0; i < repeatCount; i++)
			Append(value);

		return this;
	}

	public StringBuilder Append(char[]? value)
	{
		throw null;
	}

	public StringBuilder Append(char[]? value, int startIndex, int charCount)
	{
		throw null;
	}

	public StringBuilder Append(decimal value)
	{
		throw null;
	}

	public StringBuilder Append(double value)
	{
		throw null;
	}

	public StringBuilder Append(IFormatProvider? provider, [InterpolatedStringHandlerArgument(new string[] { "", "provider" })] ref AppendInterpolatedStringHandler handler)
	{
		throw null;
	}

	public StringBuilder Append(short value)
	{
		throw null;
	}

	public StringBuilder Append(int value)
	{
		throw null;
	}

	public StringBuilder Append(long value)
	{
		throw null;
	}

	public StringBuilder Append(object? value)
	{
		throw null;
	}

	public StringBuilder Append(ReadOnlyMemory<char> value)
	{
		throw null;
	}

	public StringBuilder Append(ReadOnlySpan<char> value)
	{
		throw null;
	}

	[CLSCompliant(false)]
	public StringBuilder Append(sbyte value)
	{
		throw null;
	}

	public StringBuilder Append(float value)
	{
		throw null;
	}

	public StringBuilder Append(string? value)
	{
		if (value is null)
			return this;

		foreach (var character in value)
			Append(character);

		return this;
	}

	public StringBuilder Append(string? value, int startIndex, int count)
	{
		throw null;
	}

	public StringBuilder Append(StringBuilder? value)
	{
		throw null;
	}

	public StringBuilder Append(StringBuilder? value, int startIndex, int count)
	{
		throw null;
	}

	public StringBuilder Append([InterpolatedStringHandlerArgument("")] ref AppendInterpolatedStringHandler handler)
	{
		throw null;
	}

	[CLSCompliant(false)]
	public StringBuilder Append(ushort value)
	{
		throw null;
	}

	[CLSCompliant(false)]
	public StringBuilder Append(uint value)
	{
		throw null;
	}

	[CLSCompliant(false)]
	public StringBuilder Append(ulong value)
	{
		throw null;
	}

	public StringBuilder AppendFormat(IFormatProvider? provider, [StringSyntax("CompositeFormat")] string format, object? arg0)
	{
		throw null;
	}

	public StringBuilder AppendFormat(IFormatProvider? provider, [StringSyntax("CompositeFormat")] string format, object? arg0, object? arg1)
	{
		throw null;
	}

	public StringBuilder AppendFormat(IFormatProvider? provider, [StringSyntax("CompositeFormat")] string format, object? arg0, object? arg1, object? arg2)
	{
		throw null;
	}

	public StringBuilder AppendFormat(IFormatProvider? provider, [StringSyntax("CompositeFormat")] string format, params object?[] args)
	{
		throw null;
	}

	public StringBuilder AppendFormat([StringSyntax("CompositeFormat")] string format, object? arg0)
	{
		throw null;
	}

	public StringBuilder AppendFormat([StringSyntax("CompositeFormat")] string format, object? arg0, object? arg1)
	{
		throw null;
	}

	public StringBuilder AppendFormat([StringSyntax("CompositeFormat")] string format, object? arg0, object? arg1, object? arg2)
	{
		throw null;
	}

	public StringBuilder AppendFormat([StringSyntax("CompositeFormat")] string format, params object?[] args)
	{
		throw null;
	}

	public StringBuilder AppendFormat<TArg0>(IFormatProvider? provider, CompositeFormat format, TArg0 arg0)
	{
		throw null;
	}

	public StringBuilder AppendFormat<TArg0, TArg1>(IFormatProvider? provider, CompositeFormat format, TArg0 arg0, TArg1 arg1)
	{
		throw null;
	}

	public StringBuilder AppendFormat<TArg0, TArg1, TArg2>(IFormatProvider? provider, CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2)
	{
		throw null;
	}

	public StringBuilder AppendFormat(IFormatProvider? provider, CompositeFormat format, params object?[] args)
	{
		throw null;
	}

	public StringBuilder AppendFormat(IFormatProvider? provider, CompositeFormat format, ReadOnlySpan<object?> args)
	{
		throw null;
	}

	public StringBuilder AppendJoin(char separator, params object?[] values)
	{
		throw null;
	}

	public StringBuilder AppendJoin(char separator, params string?[] values)
	{
		throw null;
	}

	public StringBuilder AppendJoin(string? separator, params object?[] values)
	{
		throw null;
	}

	public StringBuilder AppendJoin(string? separator, params string?[] values)
	{
		throw null;
	}

	public StringBuilder AppendJoin<T>(char separator, IEnumerable<T> values)
	{
		throw null;
	}

	public StringBuilder AppendJoin<T>(string? separator, IEnumerable<T> values)
	{
		throw null;
	}

	public StringBuilder AppendLine()
	{
		throw null;
	}

	public StringBuilder AppendLine(IFormatProvider? provider, [InterpolatedStringHandlerArgument(new string[] { "", "provider" })] ref AppendInterpolatedStringHandler handler)
	{
		throw null;
	}

	public StringBuilder AppendLine(string? value)
	{
		Append(value);
		Append(Environment.NewLine);
		return this;
	}

	public StringBuilder AppendLine([InterpolatedStringHandlerArgument("")] ref AppendInterpolatedStringHandler handler)
	{
		throw null;
	}

	public StringBuilder Clear()
	{
		throw null;
	}

	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
	{
	}

	public void CopyTo(int sourceIndex, Span<char> destination, int count)
	{
	}

	public int EnsureCapacity(int capacity)
	{
		if (capacity < 0 || capacity > MaxCapacity)
			Internal.Exceptions.Generic.ParameterOutOfRange(nameof(capacity));

		if (capacity <= Capacity)
			return capacity;

		var nextCapacity = capacity + Internal.Impl.StringBuilder.NextCapacityAddSize;
		var newCharacters = new char[nextCapacity];

		Array.Copy(characters, 0, newCharacters, 0, length);
		characters = newCharacters;

		return nextCapacity;
	}

	public bool Equals(ReadOnlySpan<char> span)
	{
		throw null;
	}

	public bool Equals([NotNullWhen(true)] StringBuilder? sb)
	{
		throw null;
	}

	public ChunkEnumerator GetChunks()
	{
		throw null;
	}

	public StringBuilder Insert(int index, bool value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, byte value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, char value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, char[]? value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, char[]? value, int startIndex, int charCount)
	{
		throw null;
	}

	public StringBuilder Insert(int index, decimal value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, double value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, short value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, int value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, long value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, object? value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, ReadOnlySpan<char> value)
	{
		throw null;
	}

	[CLSCompliant(false)]
	public StringBuilder Insert(int index, sbyte value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, float value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, string? value)
	{
		throw null;
	}

	public StringBuilder Insert(int index, string? value, int count)
	{
		throw null;
	}

	[CLSCompliant(false)]
	public StringBuilder Insert(int index, ushort value)
	{
		throw null;
	}

	[CLSCompliant(false)]
	public StringBuilder Insert(int index, uint value)
	{
		throw null;
	}

	[CLSCompliant(false)]
	public StringBuilder Insert(int index, ulong value)
	{
		throw null;
	}

	public StringBuilder Remove(int startIndex, int length)
	{
		throw null;
	}

	public StringBuilder Replace(char oldChar, char newChar)
	{
		throw null;
	}

	public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
	{
		throw null;
	}

	public StringBuilder Replace(string oldValue, string? newValue)
	{
		throw null;
	}

	public StringBuilder Replace(string oldValue, string? newValue, int startIndex, int count)
	{
		throw null;
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public override string ToString() => new(characters, 0, Length);

	public string ToString(int startIndex, int length)
	{
		throw null;
	}
}
