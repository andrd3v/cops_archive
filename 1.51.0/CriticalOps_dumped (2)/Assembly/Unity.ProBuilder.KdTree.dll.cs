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

	// RVA: 0x3525804
	public T[] get_MinPoint() { }

	// RVA: 0x35267E8
	public void set_MinPoint(T[] value) { }

	// RVA: 0x3525804
	public T[] get_MaxPoint() { }

	// RVA: 0x35267E8
	public void set_MaxPoint(T[] value) { }

	// RVA: 0x26AD93C
	public static UnityEngine.ProBuilder.KdTree.HyperRect<T> Infinite(int dimensions, UnityEngine.ProBuilder.KdTree.ITypeMath<T> math) { }

	// RVA: 0x3525998
	public T[] GetClosestPoint(T[] toPoint, UnityEngine.ProBuilder.KdTree.ITypeMath<T> math) { }

	// RVA: 0x26AD93C
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

	// RVA: 0x153CFE4
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass33_0
{
	// Fields
	public System.Collections.Generic.Stack<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>> left; // 0x0
	public System.Collections.Generic.Stack<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>> right; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35267E8
	internal void <GetEnumerator>b__0(UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> node) { }

	// RVA: 0x35267E8
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

	// RVA: 0x3526518
	public void .ctor(int <>1__state) { }

	// RVA: 0x35263A0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35251DC
	private bool MoveNext() { }

	// RVA: 0x3525804
	private UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>>.get_Current() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x3525804
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

	// RVA: 0x3526680
	public void .ctor(int dimensions, UnityEngine.ProBuilder.KdTree.ITypeMath<TKey> typeMath) { }

	// RVA: 0x26AD93C
	public void .ctor(int dimensions, UnityEngine.ProBuilder.KdTree.ITypeMath<TKey> typeMath, AddDuplicateBehavior addDuplicateBehavior) { }

	// RVA: 0x35254D0
	public AddDuplicateBehavior get_AddDuplicateBehavior() { }

	// RVA: 0x3526518
	private void set_AddDuplicateBehavior(AddDuplicateBehavior value) { }

	// RVA: 0x26AD93C
	public bool Add(TKey[] point, TValue value) { }

	// RVA: 0x26AD93C
	private void AddNearestNeighbours(UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> node, TKey[] target, UnityEngine.ProBuilder.KdTree.HyperRect<TKey> rect, int depth, UnityEngine.ProBuilder.KdTree.NearestNeighbourList<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>,TKey> nearestNeighbours, TKey maxSearchRadiusSquared) { }

	// RVA: 0x26AD93C
	public UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>[] RadialSearch(TKey[] center, TKey radius, int count) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x3526518
	private void set_Count(int value) { }

	// RVA: 0x3526A40
	private void AddNodeToStringBuilder(UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> node, StringBuilder sb, int depth) { }

	// RVA: 0x3525804
	public override string ToString() { }

	// RVA: 0x3525804
	public System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x3525804
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	public void .ctor(TKey[] point, TValue value) { }

	// RVA: -1
	internal UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> get_Item(int compare) { }

	// RVA: 0x3526680
	internal void set_Item(int compare, UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue> value) { }

	// RVA: 0x26AD93C
	public void AddDuplicate(TValue value) { }

	// RVA: 0x3525804
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

	// RVA: 0x3526680
	public void .ctor(int maxCapacity, UnityEngine.ProBuilder.KdTree.ITypeMath<TDistance> distanceMath) { }

	// RVA: 0x35254D0
	public int get_MaxCapacity() { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x26AD93C
	public bool Add(TItem item, TDistance distance) { }

	// RVA: 0x26AD93C
	public TDistance GetFurtherestDistance() { }

	// RVA: 0x26AD93C
	public TItem RemoveFurtherest() { }

	// RVA: 0x35251DC
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

	// RVA: 0x3526680
	public void .ctor(int capacity, UnityEngine.ProBuilder.KdTree.ITypeMath<TPriority> priorityMath) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x35263A0
	private void ExpandCapacity() { }

	// RVA: 0x26AD93C
	public void Enqueue(TItem item, TPriority priority) { }

	// RVA: 0x26AD93C
	public TItem Dequeue() { }

	// RVA: 0x3526588
	private void ReorderItem(int index, int direction) { }

	// RVA: 0x26AD93C
	public TPriority GetHighestPriority() { }

}

// Namespace: UnityEngine.ProBuilder.KdTree.Math
[Serializable]
internal class FloatMath
{
	// Methods

	// RVA: 0x153D060
	public override int Compare(float a, float b) { }

	// RVA: 0x153D08C
	public override bool AreEqual(float a, float b) { }

	// RVA: 0x153D098
	public override float get_MinValue() { }

	// RVA: 0x153D0A4
	public override float get_Zero() { }

	// RVA: 0x153D0AC
	public override float get_NegativeInfinity() { }

	// RVA: 0x153D0B8
	public override float get_PositiveInfinity() { }

	// RVA: 0x153D0C4
	public override float Add(float a, float b) { }

	// RVA: 0x153D0CC
	public override float Subtract(float a, float b) { }

	// RVA: 0x153D0D4
	public override float Multiply(float a, float b) { }

	// RVA: 0x153D0DC
	public override float DistanceSquaredBetweenPoints(float[] a, float[] b) { }

	// RVA: 0x153D1E4
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

	// RVA: 0x35263A0
	protected void .ctor() { }

}


