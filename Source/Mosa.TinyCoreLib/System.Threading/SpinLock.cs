using Internal;

namespace System.Threading;

public struct SpinLock
{
	public bool IsHeld => (owner & LOCK_ANONYMOUS_OWNED) != LOCK_UNOWNED;

	public bool IsHeldByCurrentThread => throw new NotImplementedException();

	public bool IsThreadOwnerTrackingEnabled => throw new NotImplementedException();

	private /*volatile*/ int owner;

	private const int LOCK_UNOWNED = 0;
	private const int LOCK_ANONYMOUS_OWNED = 0x1;

	public SpinLock(bool enableThreadOwnerTracking) => owner = LOCK_UNOWNED;

	public void Enter(ref bool lockTaken)
	{
		if (lockTaken)
			return;

		var observedOwner = 0;

		while (Impl.Interlocked.CompareExchange(ref owner, observedOwner | LOCK_ANONYMOUS_OWNED,
			       observedOwner, ref lockTaken) != observedOwner) {}
	}

	public void Exit()
	{
		Interlocked.Decrement(ref owner);
	}

	public void Exit(bool useMemoryBarrier) => throw new NotImplementedException();

	public void TryEnter(ref bool lockTaken) => throw new NotImplementedException();

	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) => throw new NotImplementedException();

	public void TryEnter(TimeSpan timeout, ref bool lockTaken) => throw new NotImplementedException();
}
