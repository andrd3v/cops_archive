// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.ProBuilder.KdTree
internal struct HyperRect<T0>
{
	// Fields
	private T[] minPoint; // 0x0
	private T[] maxPoint; // 0x0

	// Methods

	// RVA: 0x30D3CF0
	public T[] get_MinPoint() { }

	// RVA: 0x30D4CD4
	public void set_MinPoint(T[] value) { }

	// RVA: 0x30D3CF0
	public T[] get_MaxPoint() { }

	// RVA: 0x30D4CD4
	public void set_MaxPoint(T[] value) { }

	// RVA: 0x318DB98
	public static UnityEngine.ProBuilder.KdTree.HyperRect<T> Infinite(int dimensions, UnityEngine.ProBuilder.KdTree.ITypeMath<T> math) { }

	// RVA: 0x30D3E84
	public T[] GetClosestPoint(T[] toPoint, UnityEngine.ProBuilder.KdTree.ITypeMath<T> math) { }

	// RVA: 0x318DB98
	public UnityEngine.ProBuilder.KdTree.HyperRect<T> Clone() { }

}

// Namespace: UnityEngine.ProBuilder.KdTree
internal enum AddDuplicateBehavior
{
	// Fields
	public int value__; // 0x10
	public const AddDuplicateBehavior Skip = 0;
	public const AddDuplicateBehavior Error = 1;
	public const AddDuplicateBehavior Update = 2;
	public const AddDuplicateBehavior Collect = 3;
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal class DuplicateNodeError
{
	// Methods

	// RVA: 0x14FA000
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0
{
	// Fields
	public System.Collections.Generic.Stack<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>> left; // 0x0
	public System.Collections.Generic.Stack<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>> right; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D4CD4
	internal void <GetEnumerator>b__0(UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> node) { }

	// RVA: 0x30D4CD4
	internal void <GetEnumerator>b__1(UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> node) { }

}

// Namespace: 
private sealed class <GetEnumerator>d__33
{
	// Fields
	private int <>1__state; // 0x0
	private UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> <>2__current; // 0x0
	public UnityEngine.ProBuilder.KdTree.KdTree<TKey,TValue> <>4__this; // 0x0
	private UnityEngine.ProBuilder.KdTree.KdTree.<>c__DisplayClass33_0<TKey,TValue> <>8__1; // 0x0
	private System.Action<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>> <addLeft>5__2; // 0x0
	private System.Action<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>> <addRight>5__3; // 0x0

	// Methods

	// RVA: 0x30D4A04
	public void .ctor(int <>1__state) { }

	// RVA: 0x30D488C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30D3738
	private bool MoveNext() { }

	// RVA: 0x30D3CF0
	private UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>>.get_Current() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.ProBuilder.KdTree
[Serializable]
internal class KdTree<T0, T1>
{
	// Fields
	private int dimensions; // 0x0
	private UnityEngine.ProBuilder.KdTree.ITypeMath<TKey> typeMath; // 0x0
	private UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> root; // 0x0
	private AddDuplicateBehavior <AddDuplicateBehavior>k__BackingField; // 0x0
	private int <Count>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30D4B6C
	public void .ctor(int dimensions, UnityEngine.ProBuilder.KdTree.ITypeMath<TKey> typeMath) { }

	// RVA: 0x318DB98
	public void .ctor(int dimensions, UnityEngine.ProBuilder.KdTree.ITypeMath<TKey> typeMath, AddDuplicateBehavior addDuplicateBehavior) { }

	// RVA: 0x30D39B8
	public AddDuplicateBehavior get_AddDuplicateBehavior() { }

	// RVA: 0x30D4A04
	private void set_AddDuplicateBehavior(AddDuplicateBehavior value) { }

	// RVA: 0x318DB98
	public bool Add(TKey[] point, TValue value) { }

	// RVA: 0x318DB98
	private void AddNearestNeighbours(UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> node, TKey[] target, UnityEngine.ProBuilder.KdTree.HyperRect<TKey> rect, int depth, UnityEngine.ProBuilder.KdTree.NearestNeighbourList<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>,TKey> nearestNeighbours, TKey maxSearchRadiusSquared) { }

	// RVA: 0x318DB98
	public UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>[] RadialSearch(TKey[] center, TKey radius, int count) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D4A04
	private void set_Count(int value) { }

	// RVA: 0x30D4FA0
	private void AddNodeToStringBuilder(UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> node, StringBuilder sb, int depth) { }

	// RVA: 0x30D3CF0
	public override string ToString() { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.ProBuilder.KdTree
[Serializable]
internal class KdTreeNode<T0, T1>
{
	// Fields
	public TKey[] Point; // 0x0
	public TValue Value; // 0x0
	public System.Collections.Generic.List<TValue> Duplicates; // 0x0
	internal UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> LeftChild; // 0x0
	internal UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> RightChild; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	public void .ctor(TKey[] point, TValue value) { }

	// RVA: -1
	internal UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> get_Item(int compare) { }

	// RVA: 0x30D4B6C
	internal void set_Item(int compare, UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> value) { }

	// RVA: 0x318DB98
	public void AddDuplicate(TValue value) { }

	// RVA: 0x30D3CF0
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder.KdTree
internal interface ITypeMath<T0>
{
	// Methods

	// RVA: -1
	public abstract int Compare(T a, T b) { }

	// RVA: -1
	public abstract T get_MinValue() { }

	// RVA: -1
	public abstract bool AreEqual(T[] a, T[] b) { }

	// RVA: -1
	public abstract T Multiply(T a, T b) { }

	// RVA: -1
	public abstract T get_NegativeInfinity() { }

	// RVA: -1
	public abstract T get_PositiveInfinity() { }

	// RVA: -1
	public abstract T DistanceSquaredBetweenPoints(T[] a, T[] b) { }

}

// Namespace: UnityEngine.ProBuilder.KdTree
internal class NearestNeighbourList<T0, T1>
{
	// Fields
	private UnityEngine.ProBuilder.KdTree.PriorityQueue<TItem,TDistance> queue; // 0x0
	private UnityEngine.ProBuilder.KdTree.ITypeMath<TDistance> distanceMath; // 0x0
	private int maxCapacity; // 0x0

	// Methods

	// RVA: 0x30D4B6C
	public void .ctor(int maxCapacity, UnityEngine.ProBuilder.KdTree.ITypeMath<TDistance> distanceMath) { }

	// RVA: 0x30D39B8
	public int get_MaxCapacity() { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x318DB98
	public bool Add(TItem item, TDistance distance) { }

	// RVA: 0x318DB98
	public TDistance GetFurtherestDistance() { }

	// RVA: 0x318DB98
	public TItem RemoveFurtherest() { }

	// RVA: 0x30D3738
	public bool get_IsCapacityReached() { }

}

// Namespace: UnityEngine.ProBuilder.KdTree
internal struct ItemPriority<T0, T1>
{
	// Fields
	public TItem Item; // 0x0
	public TPriority Priority; // 0x0
}

// Namespace: UnityEngine.ProBuilder.KdTree
internal class PriorityQueue<T0, T1>
{
	// Fields
	private UnityEngine.ProBuilder.KdTree.ITypeMath<TPriority> priorityMath; // 0x0
	private UnityEngine.ProBuilder.KdTree.ItemPriority<TItem,TPriority>[] queue; // 0x0
	private int capacity; // 0x0
	private int count; // 0x0

	// Methods

	// RVA: 0x30D4B6C
	public void .ctor(int capacity, UnityEngine.ProBuilder.KdTree.ITypeMath<TPriority> priorityMath) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D488C
	private void ExpandCapacity() { }

	// RVA: 0x318DB98
	public void Enqueue(TItem item, TPriority priority) { }

	// RVA: 0x318DB98
	public TItem Dequeue() { }

	// RVA: 0x30D4A74
	private void ReorderItem(int index, int direction) { }

	// RVA: 0x318DB98
	public TPriority GetHighestPriority() { }

}

// Namespace: UnityEngine.ProBuilder.KdTree.Math
[Serializable]
internal class FloatMath
{
	// Methods

	// RVA: 0x14FA07C
	public override int Compare(float a, float b) { }

	// RVA: 0x14FA0A8
	public override bool AreEqual(float a, float b) { }

	// RVA: 0x14FA0B4
	public override float get_MinValue() { }

	// RVA: 0x14FA0C0
	public override float get_Zero() { }

	// RVA: 0x14FA0C8
	public override float get_NegativeInfinity() { }

	// RVA: 0x14FA0D4
	public override float get_PositiveInfinity() { }

	// RVA: 0x14FA0E0
	public override float Add(float a, float b) { }

	// RVA: 0x14FA0E8
	public override float Subtract(float a, float b) { }

	// RVA: 0x14FA0F0
	public override float Multiply(float a, float b) { }

	// RVA: 0x14FA0F8
	public override float DistanceSquaredBetweenPoints(float[] a, float[] b) { }

	// RVA: 0x14FA200
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.KdTree.Math
[Serializable]
internal abstract class TypeMath<T0>
{
	// Methods

	// RVA: -1
	public abstract int Compare(T a, T b) { }

	// RVA: -1
	public abstract bool AreEqual(T a, T b) { }

	// RVA: -1
	public virtual bool AreEqual(T[] a, T[] b) { }

	// RVA: -1
	public abstract T get_MinValue() { }

	// RVA: -1
	public abstract T get_Zero() { }

	// RVA: -1
	public abstract T get_NegativeInfinity() { }

	// RVA: -1
	public abstract T get_PositiveInfinity() { }

	// RVA: -1
	public abstract T Add(T a, T b) { }

	// RVA: -1
	public abstract T Subtract(T a, T b) { }

	// RVA: -1
	public abstract T Multiply(T a, T b) { }

	// RVA: -1
	public abstract T DistanceSquaredBetweenPoints(T[] a, T[] b) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}


