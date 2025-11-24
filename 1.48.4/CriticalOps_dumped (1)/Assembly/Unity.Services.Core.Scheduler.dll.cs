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

	// RVA: 0x149A8C4
	void .ctor() { }

	// RVA: 0x149A934
	void .ctor(ITimeProvider timeProvider) { }

	// RVA: 0x149ABE0
	void ExecuteExpiredActions() { }

	// RVA: 0x149B30C
	void UpdateCurrentPlayerLoopWith(System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> subSystemList, PlayerLoopSystem currentPlayerLoop) { }

	// RVA: 0x149B3A4
	void JoinPlayerLoopSystem() { }

}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal abstract class MinimumBinaryHeap 
{
	// Methods

	// RVA: 0x149B54C
	void .ctor() { }

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

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE42A4
	void set_Count(int value) { }

	// RVA: 0x309AF8C
	T get_Min() { }

	// RVA: 0x2FE45DC
	void .ctor(System.Collections.Generic.IComparer<T> comparer, int minimumCapacity) { }

	// RVA: 0x2FE4840
	void .ctor(System.Collections.Generic.ICollection<T> collection, System.Collections.Generic.IComparer<T> comparer, int minimumCapacity) { }

	// RVA: 0x309AF8C
	void Insert(T item) { }

	// RVA: 0x2FE41A8
	void IncreaseHeapCapacityWhenFull() { }

	// RVA: 0x309AF8C
	void Remove(T item) { }

	// RVA: 0x309AF8C
	int IndexOf(T item) { }

	// RVA: 0x309AF8C
	T ExtractMin() { }

	// RVA: 0x2FE41A8
	void DecreaseHeapCapacityWhenSpare() { }

	// RVA: 0x2FE41A8
	void MinHeapify() { }

	// RVA: 0x2FEAB7C
	void Swap(ref T lhs, ref T rhs) { }

	// RVA: -1
	int GetParentIndex(int index) { }

	// RVA: -1
	int GetLeftChildIndex(int index) { }

	// RVA: -1
	int GetRightChildIndex(int index) { }

	// RVA: 0x2FE4574
	void <MinHeapify>g__UpdateSmallestIndex|21_0(ref Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap.<>c__DisplayClass21_0<T>& ) { }

	// RVA: 0x2FE440C
	void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(int candidate, ref Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap.<>c__DisplayClass21_0<T>& ) { }

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

	// RVA: 0x149B554
	int Compare(ScheduledInvocation x, ScheduledInvocation y) { }

	// RVA: 0x149ABD8
	void .ctor() { }

}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal interface ITimeProvider 
{
	// Methods

	// RVA: -1
	DateTime get_Now() { }

}

// Namespace: Unity.Services.Core.Scheduler.Internal
internal class UtcTimeProvider 
{
	// Methods

	// RVA: 0x149B64C
	DateTime get_Now() { }

	// RVA: 0x149A92C
	void .ctor() { }

}


