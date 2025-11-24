// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class ActionScheduler
{
	// Fields
	internal readonly PlayerLoopSystem SchedulerLoopSystem; // 0x10
	private readonly ITimeProvider m_TimeProvider; // 0x38
	private readonly object m_Lock; // 0x40
	private readonly Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_ScheduledActions; // 0x48
	private readonly System.Collections.Generic.Dictionary<System.Int64,Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_IdScheduledInvocationMap; // 0x50
	private readonly System.Collections.Generic.List<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_ExpiredActions; // 0x58
	private Int64 m_NextId; // 0x60

	// Methods

	// RVA: 0x15B0138
	public void .ctor() { }

	// RVA: 0x15B01A8
	public void .ctor(ITimeProvider timeProvider) { }

	// RVA: 0x15B0454
	internal void ExecuteExpiredActions() { }

	// RVA: 0x15B0B80
	internal static void UpdateCurrentPlayerLoopWith(System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> subSystemList, PlayerLoopSystem currentPlayerLoop) { }

	// RVA: 0x15B0C18
	public void JoinPlayerLoopSystem() { }

}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal abstract class MinimumBinaryHeap
{
	// Methods

	// RVA: 0x15B0DC0
	protected void .ctor() { }

}

// Namespace: 
private struct <>c__DisplayClass21_0
{
	// Fields
	public int smallest; // 0x0
	public int currentIndex; // 0x0
	public Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<T> <>4__this; // 0x0
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class MinimumBinaryHeap<T0>
{
	// Fields
	private readonly object m_Lock; // 0x0
	private readonly System.Collections.Generic.IComparer<T> m_Comparer; // 0x0
	private readonly int m_MinimumCapacity; // 0x0
	private T[] m_HeapArray; // 0x0
	private int <Count>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D4A04
	private void set_Count(int value) { }

	// RVA: 0x318DB98
	public T get_Min() { }

	// RVA: 0x30D4D3C
	public void .ctor(System.Collections.Generic.IComparer<T> comparer, int minimumCapacity) { }

	// RVA: 0x30D4FA0
	internal void .ctor(System.Collections.Generic.ICollection<T> collection, System.Collections.Generic.IComparer<T> comparer, int minimumCapacity) { }

	// RVA: 0x318DB98
	public void Insert(T item) { }

	// RVA: 0x30D488C
	private void IncreaseHeapCapacityWhenFull() { }

	// RVA: 0x318DB98
	public void Remove(T item) { }

	// RVA: 0x318DB98
	private int IndexOf(T item) { }

	// RVA: 0x318DB98
	public T ExtractMin() { }

	// RVA: 0x30D488C
	private void DecreaseHeapCapacityWhenSpare() { }

	// RVA: 0x30D488C
	private void MinHeapify() { }

	// RVA: 0x30DB358
	private static void Swap(T lhs, T rhs) { }

	// RVA: -1
	private static int GetParentIndex(int index) { }

	// RVA: -1
	private static int GetLeftChildIndex(int index) { }

	// RVA: -1
	private static int GetRightChildIndex(int index) { }

	// RVA: 0x30D4CD4
	private void <MinHeapify>g__UpdateSmallestIndex|21_0(Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap.<>c__DisplayClass21_0<T>& ) { }

	// RVA: 0x30D4B6C
	private void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(int candidate, Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap.<>c__DisplayClass21_0<T>& ) { }

}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class ScheduledInvocation
{
	// Fields
	public Action Action; // 0x10
	public DateTime InvocationTime; // 0x18
	public Int64 ActionId; // 0x20
}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class ScheduledInvocationComparer
{
	// Methods

	// RVA: 0x15B0DC8
	public int Compare(ScheduledInvocation x, ScheduledInvocation y) { }

	// RVA: 0x15B044C
	public void .ctor() { }

}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal interface ITimeProvider
{
	// Methods

	// RVA: -1
	public abstract DateTime get_Now() { }

}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class UtcTimeProvider
{
	// Methods

	// RVA: 0x15B0EC0
	public DateTime get_Now() { }

	// RVA: 0x15B01A0
	public void .ctor() { }

}


