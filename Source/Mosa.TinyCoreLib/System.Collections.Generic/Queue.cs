using System.Diagnostics.CodeAnalysis;

namespace System.Collections.Generic;

public class Queue<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ICollection
{
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private T _currentElement;

		private object _dummy;

		private int _dummyPrimitive;

		public T Current
		{
			get
			{
				throw null;
			}
		}

		object? IEnumerator.Current
		{
			get
			{
				throw null;
			}
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			throw null;
		}

		void IEnumerator.Reset()
		{
		}
	}

	public int Count
	{
		get
		{
			throw null;
		}
	}

	bool ICollection.IsSynchronized
	{
		get
		{
			throw null;
		}
	}

	object ICollection.SyncRoot
	{
		get
		{
			throw null;
		}
	}

	public Queue()
	{
	}

	public Queue(IEnumerable<T> collection)
	{
	}

	public Queue(int capacity)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(T item)
	{
		throw null;
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	public T Dequeue()
	{
		throw null;
	}

	public void Enqueue(T item)
	{
	}

	public Enumerator GetEnumerator()
	{
		throw null;
	}

	public T Peek()
	{
		throw null;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		throw null;
	}

	void ICollection.CopyTo(Array array, int index)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	public T[] ToArray()
	{
		throw null;
	}

	public void TrimExcess()
	{
	}

	public int EnsureCapacity(int capacity)
	{
		throw null;
	}

	public bool TryDequeue([MaybeNullWhen(false)] out T result)
	{
		throw null;
	}

	public bool TryPeek([MaybeNullWhen(false)] out T result)
	{
		throw null;
	}
}