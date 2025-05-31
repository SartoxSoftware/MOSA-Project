using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Internal;

namespace System.Threading;

public static class Interlocked
{
	public static int Add(ref int location1, int value) => Impl.Interlocked.ExchangeAdd(ref location1, value) + value;

	public static long Add(ref long location1, long value) => throw new NotImplementedException();

	[CLSCompliant(false)]
	public static uint Add(ref uint location1, uint value) => throw new NotImplementedException();

	[CLSCompliant(false)]
	public static ulong Add(ref ulong location1, ulong value) => throw new NotImplementedException();

	public static int And(ref int location1, int value) => throw new NotImplementedException();

	public static long And(ref long location1, long value) => throw new NotImplementedException();

	[CLSCompliant(false)]
	public static uint And(ref uint location1, uint value) => throw new NotImplementedException();

	[CLSCompliant(false)]
	public static ulong And(ref ulong location1, ulong value) => throw new NotImplementedException();

	public static double CompareExchange(ref double location1, double value, double comparand)
		=> Impl.Interlocked.CompareExchange(ref location1, value, comparand);

	public static int CompareExchange(ref int location1, int value, int comparand)
		=> Impl.Interlocked.CompareExchange(ref location1, value, comparand);

	public static long CompareExchange(ref long location1, long value, long comparand)
		=> Impl.Interlocked.CompareExchange(ref location1, value, comparand);

	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand)
		=> Impl.Interlocked.CompareExchange(ref location1, value, comparand);

	[CLSCompliant(false)]
	public static UIntPtr CompareExchange(ref UIntPtr location1, UIntPtr value, UIntPtr comparand)
		=> throw new NotImplementedException();

	[return: NotNullIfNotNull("location1")]
	public static object? CompareExchange(ref object? location1, object? value, object? comparand)
		=> Impl.Interlocked.CompareExchange(ref location1, value, comparand);

	public static float CompareExchange(ref float location1, float value, float comparand)
		=> Impl.Interlocked.CompareExchange(ref location1, value, comparand);

	[CLSCompliant(false)]
	public static uint CompareExchange(ref uint location1, uint value, uint comparand)
		=> throw new NotImplementedException();

	[CLSCompliant(false)]
	public static ulong CompareExchange(ref ulong location1, ulong value, ulong comparand)
		=> throw new NotImplementedException();

	[return: NotNullIfNotNull("location1")]
	public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class?
		=> throw new NotImplementedException();

	public static int Decrement(ref int location) => Add(ref location, -1);

	public static long Decrement(ref long location) => Add(ref location, -1);

	[CLSCompliant(false)]
	public static uint Decrement(ref uint location) => throw new NotImplementedException();

	[CLSCompliant(false)]
	public static ulong Decrement(ref ulong location) => throw new NotImplementedException();

	public static double Exchange(ref double location1, double value) => Impl.Interlocked.Exchange(ref location1, value);

	public static int Exchange(ref int location1, int value) => Impl.Interlocked.Exchange(ref location1, value);

	public static long Exchange(ref long location1, long value) => Impl.Interlocked.Exchange(ref location1, value);

	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) => Impl.Interlocked.Exchange(ref location1, value);

	[CLSCompliant(false)]
	public static UIntPtr Exchange(ref UIntPtr location1, UIntPtr value) => throw new NotImplementedException();

	[return: NotNullIfNotNull("location1")]
	public static object? Exchange([NotNullIfNotNull("value")] ref object? location1, object? value)
		=> Impl.Interlocked.Exchange(ref location1, value);

	public static float Exchange(ref float location1, float value) => Impl.Interlocked.Exchange(ref location1, value);

	[CLSCompliant(false)]
	public static uint Exchange(ref uint location1, uint value) => throw new NotImplementedException();

	[CLSCompliant(false)]
	public static ulong Exchange(ref ulong location1, ulong value) => throw new NotImplementedException();

	[return: NotNullIfNotNull("location1")]
	public static T Exchange<T>([NotNullIfNotNull("value")] ref T location1, T value) where T : class?
		=> throw new NotImplementedException();

	public static int Increment(ref int location) => Add(ref location, 1);

	public static long Increment(ref long location) => Add(ref location, 1);

	[CLSCompliant(false)]
	public static uint Increment(ref uint location) => throw new NotImplementedException();

	[CLSCompliant(false)]
	public static ulong Increment(ref ulong location) => throw new NotImplementedException();

	public static void MemoryBarrier() => throw new NotImplementedException();

	public static void MemoryBarrierProcessWide() => throw new NotImplementedException();

	public static int Or(ref int location1, int value) => throw new NotImplementedException();

	public static long Or(ref long location1, long value) => throw new NotImplementedException();

	[CLSCompliant(false)]
	public static uint Or(ref uint location1, uint value) => throw new NotImplementedException();

	[CLSCompliant(false)]
	public static ulong Or(ref ulong location1, ulong value) => throw new NotImplementedException();

	public static long Read([In] ref long location) => CompareExchange(ref location, 0, 0);

	[CLSCompliant(false)]
	public static ulong Read([In] ref ulong location) => throw new NotImplementedException();
}
