using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace Internal;

/// <summary>
/// Hosts the external and intrinsic methods used by the core library.
/// The API of this class is not final and may change at any time.
/// </summary>
internal static class Impl
{
	public static class Bmi1
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint ResetLowestSetBit(uint value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint TrailingZeroCount(uint value);
	}

	public static class File
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte[] ReadAllBytes(string path);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string[] ReadAllLines(string path);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string ReadAllText(string path);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WriteAllBytes(string path, byte[] bytes);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WriteAllLines(string path, string[] lines);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WriteAllText(string path, string text);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Exists(string path);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Create(string path);
	}

	public static class Lzcnt
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint LeadingZeroCount(uint value);
	}

	public static class Popcnt
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint PopCount(uint value);
	}

    public static class Interlocked
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern int Exchange(ref int location1, int value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern long Exchange(ref long location1, long value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern float Exchange(ref float location1, float value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern double Exchange(ref double location1, double value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern object Exchange(ref object location1, object value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern IntPtr Exchange(ref IntPtr location1, IntPtr value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern int CompareExchange(ref int location1, int value, int comparand);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern long CompareExchange(ref long location1, long value, long comparand);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern float CompareExchange(ref float location1, float value, float comparand);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern double CompareExchange(ref double location1, double value, double comparand);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern object CompareExchange(ref object location1, object value, object comparand);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern int ExchangeAdd(ref int location1, int value);
    }

    public static class Marshal
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern IntPtr GetFunctionPointerForDelegateInternal(Delegate d);
    }

    public static class Monitor
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void Enter(object obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void Exit(object obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void ReliableEnter(object obj, ref bool lockTaken);
    }

    public static class RuntimeHelpers
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void InitializeArray(Array array, RuntimeFieldHandle fldHandle);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern int GetHashCode(object o);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public new static extern bool Equals(object o1, object o2);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern T UnsafeCast<T>(object o) where T : class;

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern IEnumerable<Assembly> GetAssemblies();

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern object CreateInstance(Type type, params object[] args);

        // The body of this function will be replaced by the EE with unsafe code
        // See getILIntrinsicImplementation for how this happens.
        [Intrinsic]
        public static bool EnumEquals<T>(T x, T y) where T : Enum => x.Equals(y);

        [Intrinsic]
        public static bool IsReferenceOrContainsReferences<T>() => throw new InvalidOperationException();
    }

    public static unsafe class Unsafe
    {
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void* AsPointer<T>(ref T value) => throw new PlatformNotSupportedException();

		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int SizeOf<T>() => throw new PlatformNotSupportedException();

		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: NotNullIfNotNull("value")]
		public static T As<T>([AllowNull] object value) where T : class => throw new PlatformNotSupportedException();

		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref TTo As<TFrom, TTo>(ref TFrom source) => throw new PlatformNotSupportedException();

		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreSame<T>([AllowNull] ref T left, [AllowNull] ref T right)
			=> throw new PlatformNotSupportedException();

		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset)
			=> throw new PlatformNotSupportedException();
    }

    public static class Path
    {
	    public const char AltDirectorySeparatorChar = '\\';
	    public const char DirectorySeparatorChar = '/';
    }

    public static class StringBuilder
    {
        public const int NextCapacityAddSize = 100;
    }

    public static class Stream
    {
	    public const int CopyBufferSize = short.MaxValue + 1;
    }

    public static class ConstructorInfo
    {
	    public const string ConstructorName = ".ctor";
	    public const string TypeConstructorName = ".cctor";
    }

    public static class Object
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern Type GetType(object obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern Type MemberwiseClone(object obj);
    }

    public static class Queue
    {
        public const int InitialArraySize = 16;
        public const double NextCapacityMultiplySize = 1.1;
    }

    public static class List
    {
        public const int InitialArraySize = 16;
        public const double NextCapacityMultiplySize = 1.1;
        public const double CapacityTrimThreshold = 0.9;
    }

    public static class MemoryStream
    {
	    public const double NextCapacityMultiplySize = 1.1;
    }

    public static class CollectionBase
    {
	    public const int InitialArraySize = 16;
    }

    public static class Stack
    {
	    public const int InitialArraySize = 16;
    }
}