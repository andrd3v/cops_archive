// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x16C37D8
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class IsUnmanagedAttribute
{
	// Methods

	// RVA: 0x16C37E0
	public void .ctor() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private readonly HierarchyFlattenedNodeChildren m_Enumerable; // 0x10
	private readonly HierarchyFlattened m_HierarchyFlattened; // 0x28
	private readonly HierarchyNode m_Node; // 0x30
	private int m_CurrentIndex; // 0x38
	private int m_ChildrenIndex; // 0x3C
	private int m_ChildrenCount; // 0x40

	// Methods

	// RVA: 0x16C3C44
	internal void .ctor(HierarchyFlattenedNodeChildren enumerable, HierarchyNode node) { }

	// RVA: 0x16C3D24
	public HierarchyNode get_Current() { }

	// RVA: 0x16C3F0C
	public bool MoveNext() { }

}

// Namespace: Unity.Hierarchy
public struct HierarchyFlattenedNodeChildren
{
	// Fields
	private readonly HierarchyFlattened m_HierarchyFlattened; // 0x10
	private readonly HierarchyNode m_Node; // 0x18
	private readonly int m_Version; // 0x20
	private readonly int m_Count; // 0x24

	// Methods

	// RVA: 0x16C37E8
	internal void .ctor(HierarchyFlattened hierarchyFlattened, HierarchyNode node) { }

	// RVA: 0x16C3BD4
	public Enumerator GetEnumerator() { }

	// RVA: 0x16C3CA8
	private void ThrowIfVersionChanged() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private readonly HierarchyNodeChildren m_Enumerable; // 0x10
	private int m_Index; // 0x28

	// Methods

	// RVA: 0x16C4494
	internal void .ctor(HierarchyNodeChildren enumerable) { }

	// RVA: 0x16C4558
	public HierarchyNode get_Current() { }

	// RVA: 0x16C45F0
	public bool MoveNext() { }

}

// Namespace: Unity.Hierarchy
public struct HierarchyNodeChildren
{
	// Fields
	private readonly Hierarchy m_Hierarchy; // 0x10
	private readonly HierarchyNode* m_Ptr; // 0x18
	private readonly int m_Version; // 0x20
	private readonly int m_Count; // 0x24

	// Methods

	// RVA: 0x16C4268
	internal void .ctor(Hierarchy hierarchy, IntPtr nodeChildrenPtr) { }

	// RVA: 0x16C4454
	public Enumerator GetEnumerator() { }

	// RVA: 0x16C44D0
	private void ThrowIfVersionChanged() { }

}

// Namespace: 
public struct <Reserved>e__FixedBuffer
{
	// Fields
	public int FixedElementField; // 0x10
}

// Namespace: Unity.Hierarchy
internal struct HierarchyNodeChildrenAlloc
{
	// Fields
	public HierarchyNode* Ptr; // 0x10
	public int Size; // 0x18
	public int Capacity; // 0x1C
	public int RemovedCount; // 0x20
	public Unity.Hierarchy.HierarchyNodeChildrenAlloc.<Reserved>e__FixedBuffer Reserved; // 0x24
}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16C5D0C
	public static IntPtr ConvertToNative(HierarchyNodeTypeHandlerBase handler) { }

}

// Namespace: 
private struct ConstructorScope
{
	// Fields
	private static IntPtr m_Ptr; // 0xFFFFFFFF
	private static Hierarchy m_Hierarchy; // 0xFFFFFFFF
	private static HierarchyCommandList m_CommandList; // 0xFFFFFFFF

	// Methods

	// RVA: 0x16C5D28
	private static void set_Ptr(IntPtr value) { }

	// RVA: 0x16C5D80
	private static void set_Hierarchy(Hierarchy value) { }

	// RVA: 0x16C5DE8
	private static void set_CommandList(HierarchyCommandList value) { }

	// RVA: 0x16C5168
	public void .ctor(IntPtr nativePtr, Hierarchy hierarchy, HierarchyCommandList cmdList) { }

	// RVA: 0x16C5E50
	public void Dispose() { }

}

// Namespace: Unity.Hierarchy
public abstract class HierarchyNodeTypeHandlerBase
{
	// Fields
	internal readonly IntPtr m_Ptr; // 0x10
	private readonly Hierarchy m_Hierarchy; // 0x18
	private readonly HierarchyCommandList m_CommandList; // 0x20
	private static readonly System.Collections.Generic.Dictionary<System.Type,System.Int32> s_NodeTypes; // 0x0

	// Methods

	// RVA: 0x16C4608
	protected virtual void Initialize() { }

	// RVA: 0x16C460C
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16C4610
	public virtual string GetNodeTypeName() { }

	// RVA: 0x16C47D0
	public virtual HierarchyNodeFlags GetDefaultNodeFlags(HierarchyNode node, HierarchyNodeFlags defaultFlags) { }

	// RVA: 0x16C48F8
	protected virtual void SearchBegin(HierarchySearchQueryDescriptor query) { }

	// RVA: 0x16C4A34
	protected virtual bool SearchMatch(HierarchyNode node) { }

	// RVA: 0x16C4B70
	protected virtual void SearchEnd() { }

	// RVA: 0x16C4C88
	internal static HierarchyNodeTypeHandlerBase FromIntPtr(IntPtr handlePtr) { }

	// RVA: 0x16C4D84
	internal void Internal_SearchBegin(HierarchySearchQueryDescriptor query) { }

	// RVA: 0x16C4D90
	private static IntPtr CreateNodeTypeHandlerFromType(IntPtr nativePtr, Type handlerType, IntPtr hierarchyPtr, IntPtr cmdListPtr) { }

	// RVA: 0x16C5244
	private static bool TryGetStaticNodeType(Type handlerType, int nodeType) { }

	// RVA: 0x16C5410
	private static void InvokeInitialize(IntPtr handlePtr) { }

	// RVA: 0x16C55A4
	private static void InvokeDispose(IntPtr handlePtr) { }

	// RVA: 0x16C5688
	private static string InvokeGetNodeTypeName(IntPtr handlePtr) { }

	// RVA: 0x16C571C
	private static HierarchyNodeFlags InvokeGetDefaultNodeFlags(IntPtr handlePtr, HierarchyNode node, HierarchyNodeFlags defaultFlags) { }

	// RVA: 0x16C57C8
	private static bool InvokeChangesPending(IntPtr handlePtr) { }

	// RVA: 0x16C585C
	private static bool InvokeIntegrateChanges(IntPtr handlePtr, IntPtr cmdListPtr) { }

	// RVA: 0x16C58F0
	private static bool InvokeSearchMatch(IntPtr handlePtr, HierarchyNode node) { }

	// RVA: 0x16C598C
	private static void InvokeSearchEnd(IntPtr handlePtr) { }

	// RVA: 0x16C5A20
	protected virtual bool ChangesPending() { }

	// RVA: 0x16C5B38
	protected virtual bool IntegrateChanges(HierarchyCommandList cmdList) { }

	// RVA: 0x16C5C70
	private static void .cctor() { }

	// RVA: 0x16C4768
	private static void GetNodeTypeName_Injected(IntPtr _unity_self, ManagedSpanWrapper ret) { }

	// RVA: 0x16C48A0
	private static HierarchyNodeFlags GetDefaultNodeFlags_Injected(IntPtr _unity_self, HierarchyNode node, HierarchyNodeFlags defaultFlags) { }

	// RVA: 0x16C49CC
	private static void SearchBegin_Injected(IntPtr _unity_self, HierarchySearchQueryDescriptor query) { }

	// RVA: 0x16C4B08
	private static bool SearchMatch_Injected(IntPtr _unity_self, HierarchyNode node) { }

	// RVA: 0x16C4C38
	private static void SearchEnd_Injected(IntPtr _unity_self) { }

	// RVA: 0x16C5AE8
	private static bool ChangesPending_Injected(IntPtr _unity_self) { }

	// RVA: 0x16C5C08
	private static bool IntegrateChanges_Injected(IntPtr _unity_self, IntPtr cmdList) { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private readonly System.Buffers.IMemoryOwner<System.IntPtr> m_Handlers; // 0x10
	private readonly int m_Count; // 0x18
	private int m_Index; // 0x1C

	// Methods

	// RVA: 0x16C5F4C
	internal void .ctor(Hierarchy hierarchy) { }

	// RVA: 0x16C6348
	public void Dispose() { }

	// RVA: 0x16C63FC
	public HierarchyNodeTypeHandlerBase get_Current() { }

	// RVA: 0x16C6634
	public bool MoveNext() { }

}

// Namespace: Unity.Hierarchy
public struct HierarchyNodeTypeHandlerBaseEnumerable
{
	// Fields
	private readonly Hierarchy m_Hierarchy; // 0x10

	// Methods

	// RVA: 0x16C5F18
	internal void .ctor(Hierarchy hierarchy) { }

	// RVA: 0x16C5F20
	public Enumerator GetEnumerator() { }

}

// Namespace: Unity.Hierarchy
public struct HierarchyPropertyUnmanaged<T0>
{
	// Fields
	private readonly Hierarchy m_Hierarchy; // 0x0
	internal readonly HierarchyPropertyId m_Property; // 0x0

	// Methods

	// RVA: 0x35269D4
	internal void .ctor(Hierarchy hierarchy, HierarchyPropertyId property) { }

	// RVA: 0x26AD93C
	public void SetValue(HierarchyNode node, T value) { }

	// RVA: 0x26AD93C
	public T GetValue(HierarchyNode node) { }

	// RVA: 0x26AD93C
	public bool Equals(Unity.Hierarchy.HierarchyPropertyUnmanaged<T> other) { }

	// RVA: 0x3525804
	public override string ToString() { }

	// RVA: 0x35252FC
	public override bool Equals(object obj) { }

	// RVA: 0x35254D0
	public override int GetHashCode() { }

	// RVA: 0x26AD93C
	private T Unity.Hierarchy.IHierarchyProperty<T>.GetValue(HierarchyNode node) { }

	// RVA: 0x26AD93C
	private void Unity.Hierarchy.IHierarchyProperty<T>.SetValue(HierarchyNode node, T value) { }

}

// Namespace: Unity.Hierarchy
internal interface IHierarchySearchQueryParser
{}

// Namespace: Unity.Hierarchy
internal class DefaultHierarchySearchQueryParser
{
	// Fields
	private static readonly Regex s_Filter; // 0x0

	// Methods

	// RVA: 0x16C664C
	public void .ctor() { }

	// RVA: 0x16C6654
	private static void .cctor() { }

}

// Namespace: 
internal sealed class Predicate
{
	// Methods

	// RVA: 0x16C686C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16C6928
	public virtual bool Invoke(HierarchyNode node, HierarchyNodeFlags flags) { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private readonly HierarchyFlattened m_HierarchyFlattened; // 0x10
	private readonly Predicate m_Predicate; // 0x18
	private readonly HierarchyNodeFlags m_Flags; // 0x20
	private readonly HierarchyFlattenedNode* m_NodesPtr; // 0x28
	private readonly int m_NodesCount; // 0x30
	private readonly int m_Version; // 0x34
	private int m_Index; // 0x38

	// Methods

	// RVA: 0x16C67F0
	internal void .ctor(HierarchyViewNodesEnumerable enumerable) { }

	// RVA: 0x16C6948
	public HierarchyNode get_Current() { }

	// RVA: 0x16C69D4
	public bool MoveNext() { }

	// RVA: 0x16C6B7C
	private void ThrowIfVersionChanged() { }

}

// Namespace: Unity.Hierarchy
public struct HierarchyViewNodesEnumerable
{
	// Fields
	private readonly HierarchyViewModel m_HierarchyViewModel; // 0x10
	private readonly Predicate m_Predicate; // 0x18
	private readonly HierarchyNodeFlags m_Flags; // 0x20

	// Methods

	// RVA: 0x16C66F8
	internal void .ctor(HierarchyViewModel viewModel, HierarchyNodeFlags flags, Predicate predicate) { }

	// RVA: 0x16C67B0
	public Enumerator GetEnumerator() { }

}

// Namespace: Unity.Hierarchy
public interface IHierarchyProperty<T0>
{
	// Methods

	// RVA: -1
	public abstract T GetValue(HierarchyNode node) { }

	// RVA: -1
	public abstract void SetValue(HierarchyNode node, T value) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16C8198
	public static IntPtr ConvertToNative(Hierarchy hierarchy) { }

}

// Namespace: Unity.Hierarchy
public sealed class Hierarchy
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private readonly IntPtr m_RootPtr; // 0x18
	private readonly IntPtr m_VersionPtr; // 0x20
	private readonly bool m_IsOwner; // 0x28

	// Methods

	// RVA: 0x16C6BF8
	public bool get_IsCreated() { }

	// RVA: 0x16C6C08
	public HierarchyNode get_Root() { }

	// RVA: 0x16C6C14
	public bool get_UpdateNeeded() { }

	// RVA: 0x16C6CD4
	internal int get_Version() { }

	// RVA: 0x16C6CF4
	public void .ctor() { }

	// RVA: 0x16C6DE4
	private void .ctor(IntPtr nativePtr, IntPtr rootPtr, IntPtr versionPtr) { }

	// RVA: 0x16C6E28
	protected override void Finalize() { }

	// RVA: 0x16C6F5C
	public void Dispose() { }

	// RVA: 0x16C6EFC
	private void Dispose(bool disposing) { }

	// RVA: 0x16C7064
	public HierarchyNodeTypeHandlerBaseEnumerable EnumerateNodeTypeHandlersBase() { }

	// RVA: 0x16C7090
	public bool Exists(HierarchyNode node) { }

	// RVA: 0x16C7180
	public HierarchyNode Add(HierarchyNode parent) { }

	// RVA: 0x16C7298
	public bool SetParent(HierarchyNode node, HierarchyNode parent) { }

	// RVA: 0x16C736C
	public HierarchyNode GetParent(HierarchyNode node) { }

	// RVA: 0x16C7450
	public HierarchyNode[] GetChildren(HierarchyNode node) { }

	// RVA: 0x16C760C
	public HierarchyNodeChildren EnumerateChildren(HierarchyNode node) { }

	// RVA: 0x16C7734
	public int GetChildrenCount(HierarchyNode node) { }

	// RVA: 0x16C7824
	public void SetSortIndex(HierarchyNode node, int sortIndex) { }

	// RVA: 0x16C78F8
	public void SortChildren(HierarchyNode node, bool recurse) { }

	// RVA: 0x26AD93C
	public Unity.Hierarchy.HierarchyPropertyUnmanaged<T> GetOrCreatePropertyUnmanaged(string name, HierarchyPropertyStorageType type) { }

	// RVA: 0x16C79CC
	public void Update() { }

	// RVA: 0x16C7A8C
	internal static Hierarchy FromIntPtr(IntPtr handlePtr) { }

	// RVA: 0x16C6D8C
	private static IntPtr Create(IntPtr handlePtr, IntPtr rootPtr, IntPtr versionPtr) { }

	// RVA: 0x16C7014
	private static void Destroy(IntPtr nativePtr) { }

	// RVA: 0x16C61F8
	internal int GetNodeTypeHandlersBaseCount() { }

	// RVA: 0x16C6268
	internal int GetNodeTypeHandlersBaseSpan(System.Span<System.IntPtr> outHandlers) { }

	// RVA: 0x16C720C
	private HierarchyNode AddNode(HierarchyNode parent) { }

	// RVA: 0x16C76AC
	private IntPtr EnumerateChildrenPtr(HierarchyNode node) { }

	// RVA: 0x16C7CE4
	private HierarchyPropertyId GetOrCreateProperty(string name, HierarchyPropertyDescriptor descriptor) { }

	// RVA: 0x16C7F14
	internal void SetPropertyRaw(HierarchyPropertyId property, HierarchyNode node, Void* ptr, int size) { }

	// RVA: 0x16C8018
	internal Void* GetPropertyRaw(HierarchyPropertyId property, HierarchyNode node, int size) { }

	// RVA: 0x16C810C
	private static IntPtr CreateHierarchy(IntPtr nativePtr, IntPtr rootPtr, IntPtr versionPtr) { }

	// RVA: 0x16C6C84
	private static bool get_UpdateNeeded_Injected(IntPtr _unity_self) { }

	// RVA: 0x16C7118
	private static bool Exists_Injected(IntPtr _unity_self, HierarchyNode node) { }

	// RVA: 0x16C7314
	private static bool SetParent_Injected(IntPtr _unity_self, HierarchyNode node, HierarchyNode parent) { }

	// RVA: 0x16C73F8
	private static void GetParent_Injected(IntPtr _unity_self, HierarchyNode node, HierarchyNode ret) { }

	// RVA: 0x16C75B4
	private static void GetChildren_Injected(IntPtr _unity_self, HierarchyNode node, BlittableArrayWrapper ret) { }

	// RVA: 0x16C77BC
	private static int GetChildrenCount_Injected(IntPtr _unity_self, HierarchyNode node) { }

	// RVA: 0x16C78A0
	private static void SetSortIndex_Injected(IntPtr _unity_self, HierarchyNode node, int sortIndex) { }

	// RVA: 0x16C7974
	private static void SortChildren_Injected(IntPtr _unity_self, HierarchyNode node, bool recurse) { }

	// RVA: 0x16C7A3C
	private static void Update_Injected(IntPtr _unity_self) { }

	// RVA: 0x16C7B6C
	private static int GetNodeTypeHandlersBaseCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x16C7BBC
	private static int GetNodeTypeHandlersBaseSpan_Injected(IntPtr _unity_self, ManagedSpanWrapper outHandlers) { }

	// RVA: 0x16C7C24
	private static void AddNode_Injected(IntPtr _unity_self, HierarchyNode parent, HierarchyNode ret) { }

	// RVA: 0x16C7C7C
	private static IntPtr EnumerateChildrenPtr_Injected(IntPtr _unity_self, HierarchyNode node) { }

	// RVA: 0x16C7EAC
	private static void GetOrCreateProperty_Injected(IntPtr _unity_self, ManagedSpanWrapper name, HierarchyPropertyDescriptor descriptor, HierarchyPropertyId ret) { }

	// RVA: 0x16C7FA8
	private static void SetPropertyRaw_Injected(IntPtr _unity_self, HierarchyPropertyId property, HierarchyNode node, Void* ptr, int size) { }

	// RVA: 0x16C80A4
	private static Void* GetPropertyRaw_Injected(IntPtr _unity_self, HierarchyPropertyId property, HierarchyNode node, int size) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16C8578
	public static IntPtr ConvertToNative(HierarchyCommandList cmdList) { }

}

// Namespace: Unity.Hierarchy
public sealed class HierarchyCommandList
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private readonly bool m_IsOwner; // 0x18

	// Methods

	// RVA: 0x16C81B4
	private void .ctor(IntPtr nativePtr) { }

	// RVA: 0x16C81E4
	protected override void Finalize() { }

	// RVA: 0x16C8318
	public void Dispose() { }

	// RVA: 0x16C82B8
	private void Dispose(bool disposing) { }

	// RVA: 0x16C8420
	internal static HierarchyCommandList FromIntPtr(IntPtr handlePtr) { }

	// RVA: 0x16C83D0
	private static void Destroy(IntPtr nativePtr) { }

	// RVA: 0x16C8500
	private static IntPtr CreateCommandList(IntPtr nativePtr) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16C9100
	public static IntPtr ConvertToNative(HierarchyFlattened hierarchyFlattened) { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private readonly HierarchyFlattened m_HierarchyFlattened; // 0x10
	private readonly HierarchyFlattenedNode* m_NodesPtr; // 0x18
	private readonly int m_NodesCount; // 0x20
	private readonly int m_Version; // 0x24
	private int m_Index; // 0x28

	// Methods

	// RVA: 0x16C8D78
	internal void .ctor(HierarchyFlattened hierarchyFlattened) { }

	// RVA: 0x16C911C
	public HierarchyFlattenedNode get_Current() { }

	// RVA: 0x16C91A8
	public bool MoveNext() { }

}

// Namespace: Unity.Hierarchy
public sealed class HierarchyFlattened
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private readonly Hierarchy m_Hierarchy; // 0x18
	private IntPtr m_NodesPtr; // 0x20
	private int m_NodesCount; // 0x28
	private int m_Version; // 0x2C
	private readonly bool m_IsOwner; // 0x30

	// Methods

	// RVA: 0x16C8594
	public bool get_IsCreated() { }

	// RVA: 0x16C85A4
	public int get_Count() { }

	// RVA: 0x16C85AC
	public bool get_UpdateNeeded() { }

	// RVA: 0x16C866C
	public Hierarchy get_Hierarchy() { }

	// RVA: 0x16C693C
	internal HierarchyFlattenedNode* get_NodesPtr() { }

	// RVA: 0x16C8674
	internal int get_Version() { }

	// RVA: 0x16C867C
	public void .ctor(Hierarchy hierarchy) { }

	// RVA: 0x16C87E0
	private void .ctor(IntPtr nativePtr, Hierarchy hierarchy, IntPtr nodesPtr, int nodesCount, int version) { }

	// RVA: 0x16C8848
	protected override void Finalize() { }

	// RVA: 0x16C897C
	public void Dispose() { }

	// RVA: 0x16C891C
	private void Dispose(bool disposing) { }

	// RVA: 0x16C8A84
	public HierarchyFlattenedNode get_Item(int index) { }

	// RVA: 0x16C4184
	public int IndexOf(HierarchyNode node) { }

	// RVA: 0x16C3AC4
	public bool Contains(HierarchyNode node) { }

	// RVA: 0x16C8BDC
	public HierarchyFlattenedNodeChildren EnumerateChildren(HierarchyNode node) { }

	// RVA: 0x16C3B4C
	public int GetChildrenCount(HierarchyNode node) { }

	// RVA: 0x16C8C5C
	public void Update() { }

	// RVA: 0x16C8D1C
	public Enumerator GetEnumerator() { }

	// RVA: 0x16C8DC8
	internal static HierarchyFlattened FromIntPtr(IntPtr handlePtr) { }

	// RVA: 0x16C8758
	private static IntPtr Create(IntPtr handlePtr, Hierarchy hierarchy, IntPtr nodesPtr, int nodesCount, int version) { }

	// RVA: 0x16C8A34
	private static void Destroy(IntPtr nativePtr) { }

	// RVA: 0x16C8F18
	private static IntPtr CreateHierarchyFlattened(IntPtr nativePtr, IntPtr hierarchyPtr, IntPtr nodesPtr, int nodesCount, int version) { }

	// RVA: 0x16C8FD8
	private static void UpdateHierarchyFlattened(IntPtr handlePtr, IntPtr nodesPtr, int nodesCount, int version) { }

	// RVA: 0x16C861C
	private static bool get_UpdateNeeded_Injected(IntPtr _unity_self) { }

	// RVA: 0x16C8B0C
	private static int IndexOf_Injected(IntPtr _unity_self, HierarchyNode node) { }

	// RVA: 0x16C8B74
	private static bool Contains_Injected(IntPtr _unity_self, HierarchyNode node) { }

	// RVA: 0x16C8BF4
	private static int GetChildrenCount_Injected(IntPtr _unity_self, HierarchyNode node) { }

	// RVA: 0x16C8CCC
	private static void Update_Injected(IntPtr _unity_self) { }

	// RVA: 0x16C8EA8
	private static IntPtr Create_Injected(IntPtr handlePtr, IntPtr hierarchy, IntPtr nodesPtr, int nodesCount, int version) { }

}

// Namespace: Unity.Hierarchy
public struct HierarchyFlattenedNode
{
	// Fields
	private static readonly HierarchyFlattenedNode s_Null; // 0x0
	private readonly HierarchyNode m_Node; // 0x10
	private readonly HierarchyNodeType m_Type; // 0x18
	private readonly int m_ParentOffset; // 0x1C
	private readonly int m_NextSiblingOffset; // 0x20
	private readonly int m_ChildrenCount; // 0x24
	private readonly int m_Depth; // 0x28

	// Methods

	// RVA: 0x16C420C
	public static HierarchyFlattenedNode get_Null() { }

	// RVA: 0x16C91C4
	public HierarchyNode get_Node() { }

	// RVA: 0x16C91CC
	public int get_NextSiblingOffset() { }

	// RVA: 0x16C91D4
	public int get_ChildrenCount() { }

	// RVA: 0x16C4254
	public static bool op_Equality(HierarchyFlattenedNode lhs, HierarchyFlattenedNode rhs) { }

	// RVA: 0x16C91DC
	public bool Equals(HierarchyFlattenedNode other) { }

	// RVA: 0x16C91F0
	public override string ToString() { }

	// RVA: 0x16C932C
	public override bool Equals(object obj) { }

	// RVA: 0x16C93BC
	public override int GetHashCode() { }

	// RVA: 0x16C94DC
	internal static HierarchyNode GetNodeByRef(HierarchyFlattenedNode hierarchyFlattenedNode) { }

}

// Namespace: Unity.Hierarchy
public struct HierarchyNode
{
	// Fields
	private static readonly HierarchyNode s_Null; // 0x0
	private readonly int m_Id; // 0x10
	private readonly int m_Version; // 0x14

	// Methods

	// RVA: 0x16C3A50
	public static HierarchyNode get_Null() { }

	// RVA: 0x16C94E0
	public int get_Id() { }

	// RVA: 0x16C94E8
	public int get_Version() { }

	// RVA: 0x16C94F0
	public void .ctor() { }

	// RVA: 0x16C3A98
	public static bool op_Equality(HierarchyNode lhs, HierarchyNode rhs) { }

	// RVA: 0x16C4428
	public static bool op_Inequality(HierarchyNode lhs, HierarchyNode rhs) { }

	// RVA: 0x16C94F8
	public bool Equals(HierarchyNode other) { }

	// RVA: 0x16C9520
	public override string ToString() { }

	// RVA: 0x16C9678
	public override bool Equals(object obj) { }

	// RVA: 0x16C944C
	public override int GetHashCode() { }

}

// Namespace: Unity.Hierarchy
public enum HierarchyNodeFlags
{
	// Fields
	public UInt32 value__; // 0x10
	public const HierarchyNodeFlags None = 0;
	public const HierarchyNodeFlags Expanded = 1;
	public const HierarchyNodeFlags Selected = 2;
	public const HierarchyNodeFlags Cut = 4;
	public const HierarchyNodeFlags Hidden = 8;
}

// Namespace: Unity.Hierarchy
public struct HierarchyNodeType
{
	// Fields
	private static readonly HierarchyNodeType s_Null; // 0x0
	private readonly int m_Id; // 0x10

	// Methods

	// RVA: 0x16C9718
	public static HierarchyNodeType get_Null() { }

	// RVA: 0x16C9760
	public int get_Id() { }

	// RVA: 0x16C9768
	public static bool op_Equality(HierarchyNodeType lhs, HierarchyNodeType rhs) { }

	// RVA: 0x16C977C
	public bool Equals(HierarchyNodeType other) { }

	// RVA: 0x16C978C
	public override string ToString() { }

	// RVA: 0x16C988C
	public override bool Equals(object obj) { }

	// RVA: 0x16C991C
	public override int GetHashCode() { }

}

// Namespace: Unity.Hierarchy
public struct HierarchyPropertyDescriptor
{
	// Fields
	private int m_Size; // 0x10
	private HierarchyPropertyStorageType m_Type; // 0x14

	// Methods

	// RVA: 0x16C9948
	public void set_Size(int value) { }

	// RVA: 0x16C9950
	public void set_Type(HierarchyPropertyStorageType value) { }

}

// Namespace: Unity.Hierarchy
internal struct HierarchyPropertyId
{
	// Fields
	private static readonly HierarchyPropertyId s_Null; // 0x0
	private readonly int m_Id; // 0x10

	// Methods

	// RVA: 0x16C9958
	public static HierarchyPropertyId get_Null() { }

	// RVA: 0x16C99A0
	public int get_Id() { }

	// RVA: 0x16C99A8
	public void .ctor() { }

	// RVA: 0x16C99B0
	public static bool op_Equality(HierarchyPropertyId lhs, HierarchyPropertyId rhs) { }

	// RVA: 0x16C99C4
	public bool Equals(HierarchyPropertyId other) { }

	// RVA: 0x16C99D4
	public override string ToString() { }

	// RVA: 0x16C9AD4
	public override bool Equals(object obj) { }

	// RVA: 0x16C9B64
	public override int GetHashCode() { }

}

// Namespace: Unity.Hierarchy
public enum HierarchyPropertyStorageType
{
	// Fields
	public int value__; // 0x10
	public const HierarchyPropertyStorageType Sparse = 0;
	public const HierarchyPropertyStorageType Dense = 1;
	public const HierarchyPropertyStorageType Blob = 2;
	public const HierarchyPropertyStorageType Default = 1;
}

// Namespace: Unity.Hierarchy
public enum HierarchySearchFilterOperator
{
	// Fields
	public int value__; // 0x10
	public const HierarchySearchFilterOperator Equal = 0;
	public const HierarchySearchFilterOperator Contains = 1;
	public const HierarchySearchFilterOperator Greater = 2;
	public const HierarchySearchFilterOperator GreaterOrEqual = 3;
	public const HierarchySearchFilterOperator Lesser = 4;
	public const HierarchySearchFilterOperator LesserOrEqual = 5;
	public const HierarchySearchFilterOperator NotEqual = 6;
	public const HierarchySearchFilterOperator Not = 7;
}

// Namespace: Unity.Hierarchy
[Serializable]
public struct HierarchySearchFilter
{
	// Fields
	private static readonly Char[] s_WhiteSpaces; // 0x0
	private static readonly HierarchySearchFilter s_Invalid; // 0x8
	private string <Name>k__BackingField; // 0x10
	private string <Value>k__BackingField; // 0x18
	private float <NumValue>k__BackingField; // 0x20
	private HierarchySearchFilterOperator <Op>k__BackingField; // 0x24

	// Methods

	// RVA: 0x16C9B90
	public static HierarchySearchFilter get_Invalid() { }

	// RVA: 0x16C9C0C
	public bool get_IsValid() { }

	// RVA: 0x16C9C78
	public string get_Name() { }

	// RVA: 0x16C9C80
	public string get_Value() { }

	// RVA: 0x16C9C88
	public float get_NumValue() { }

	// RVA: 0x16C9C90
	public HierarchySearchFilterOperator get_Op() { }

	// RVA: 0x16C9C98
	public static string ToString(HierarchySearchFilterOperator op) { }

	// RVA: 0x16C9DB8
	public override string ToString() { }

	// RVA: 0x16C9EE8
	internal static string QuoteStringIfNeeded(string s) { }

	// RVA: 0x16C9FBC
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Hierarchy.HierarchySearchQueryDescriptor.<>c <>9; // 0x0
	public static System.Func<Unity.Hierarchy.HierarchySearchFilter,System.Boolean> <>9__33_0; // 0x8
	public static System.Func<Unity.Hierarchy.HierarchySearchFilter,System.Boolean> <>9__33_1; // 0x10

	// Methods

	// RVA: 0x16CAABC
	private static void .cctor() { }

	// RVA: 0x16CAB28
	public void .ctor() { }

	// RVA: 0x16CAB30
	internal bool <.ctor>b__33_0(HierarchySearchFilter f) { }

	// RVA: 0x16CAC18
	internal bool <.ctor>b__33_1(HierarchySearchFilter f) { }

}

// Namespace: Unity.Hierarchy
[Serializable]
public sealed class HierarchySearchQueryDescriptor
{
	// Fields
	private static readonly System.Collections.Generic.HashSet<System.String> s_SystemFilters; // 0x0
	private static readonly HierarchySearchQueryDescriptor s_Empty; // 0x8
	private static readonly HierarchySearchQueryDescriptor s_InvalidQuery; // 0x10
	private HierarchySearchFilter[] <SystemFilters>k__BackingField; // 0x10
	private HierarchySearchFilter[] <Filters>k__BackingField; // 0x18
	private string[] <TextValues>k__BackingField; // 0x20
	private bool <Strict>k__BackingField; // 0x28
	private bool <Invalid>k__BackingField; // 0x29

	// Methods

	// RVA: 0x16CA060
	public HierarchySearchFilter[] get_SystemFilters() { }

	// RVA: 0x16CA068
	public void set_SystemFilters(HierarchySearchFilter[] value) { }

	// RVA: 0x16CA070
	public HierarchySearchFilter[] get_Filters() { }

	// RVA: 0x16CA078
	public void set_Filters(HierarchySearchFilter[] value) { }

	// RVA: 0x16CA080
	public string[] get_TextValues() { }

	// RVA: 0x16CA088
	public void set_TextValues(string[] value) { }

	// RVA: 0x16CA090
	public void set_Strict(bool value) { }

	// RVA: 0x16CA098
	public void set_Invalid(bool value) { }

	// RVA: 0x16CA0A0
	public void .ctor(HierarchySearchFilter[] filters, string[] textValues) { }

	// RVA: 0x16CA560
	public override string ToString() { }

	// RVA: 0x16CA720
	internal string BuildFilterQuery() { }

	// RVA: 0x16CA78C
	internal string BuildSystemFilterQuery() { }

	// RVA: 0x16CA7F8
	internal string BuildTextQuery() { }

	// RVA: 0x16CA564
	internal string BuildQuery() { }

	// RVA: 0x35294CC
	private static T[] Where(System.Collections.Generic.IEnumerable<T> src, System.Func<T,System.Boolean> pred) { }

	// RVA: 0x16CA928
	private static void .cctor() { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16CC520
	public static IntPtr ConvertToNative(HierarchyViewModel viewModel) { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private readonly HierarchyViewModel m_ViewModel; // 0x10
	private readonly HierarchyFlattened m_HierarchyFlattened; // 0x18
	private readonly Int32* m_NodesPtr; // 0x20
	private readonly int m_NodesCount; // 0x28
	private readonly int m_Version; // 0x2C
	private int m_Index; // 0x30

	// Methods

	// RVA: 0x16CBDFC
	internal void .ctor(HierarchyViewModel hierarchyViewModel) { }

	// RVA: 0x16CC53C
	public HierarchyNode get_Current() { }

	// RVA: 0x16CC734
	public bool MoveNext() { }

}

// Namespace: Unity.Hierarchy
public sealed class HierarchyViewModel
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private readonly Hierarchy m_Hierarchy; // 0x18
	private readonly HierarchyFlattened m_HierarchyFlattened; // 0x20
	private IntPtr m_NodesPtr; // 0x28
	private int m_NodesCount; // 0x30
	private int m_Version; // 0x34
	private readonly bool m_IsOwner; // 0x38
	private IHierarchySearchQueryParser <QueryParser>k__BackingField; // 0x40

	// Methods

	// RVA: 0x16CACF8
	public bool get_IsCreated() { }

	// RVA: 0x16CAD08
	public int get_Count() { }

	// RVA: 0x16CAD10
	public bool get_UpdateNeeded() { }

	// RVA: 0x16CADD0
	public HierarchyFlattened get_HierarchyFlattened() { }

	// RVA: 0x16CADD8
	internal int get_Version() { }

	// RVA: 0x16CADE0
	internal void set_QueryParser(IHierarchySearchQueryParser value) { }

	// RVA: 0x16CADE8
	internal HierarchySearchQueryDescriptor get_Query() { }

	// RVA: 0x16CAEA8
	public void .ctor(HierarchyFlattened hierarchyFlattened, HierarchyNodeFlags defaultFlags) { }

	// RVA: 0x16CB08C
	private void .ctor(IntPtr nativePtr, HierarchyFlattened hierarchyFlattened, IntPtr nodesPtr, int nodesCount, int version) { }

	// RVA: 0x16CB160
	protected override void Finalize() { }

	// RVA: 0x16CB294
	public void Dispose() { }

	// RVA: 0x16CB234
	private void Dispose(bool disposing) { }

	// RVA: 0x16CB39C
	public HierarchyNode get_Item(int index) { }

	// RVA: 0x16CB494
	public int IndexOf(HierarchyNode node) { }

	// RVA: 0x16CB584
	public bool Contains(HierarchyNode node) { }

	// RVA: 0x16CB674
	public int GetChildrenCount(HierarchyNode node) { }

	// RVA: 0x16CB764
	public void SetFlags(HierarchyNodeFlags flags) { }

	// RVA: 0x16CB874
	public void SetFlags(HierarchyNode node, HierarchyNodeFlags flags, bool recurse) { }

	// RVA: 0x16CB98C
	public bool HasAllFlags(HierarchyNode node, HierarchyNodeFlags flags) { }

	// RVA: 0x16CBA84
	public void ClearFlags(HierarchyNode node, HierarchyNodeFlags flags, bool recurse) { }

	// RVA: 0x16CBB9C
	public HierarchyViewNodesEnumerable EnumerateNodesWithAllFlags(HierarchyNodeFlags flags) { }

	// RVA: 0x16CBCC8
	public void Update() { }

	// RVA: 0x16CBD88
	public Enumerator GetEnumerator() { }

	// RVA: 0x16CBE5C
	internal static HierarchyViewModel FromIntPtr(IntPtr handlePtr) { }

	// RVA: 0x16CAFF4
	private static IntPtr Create(IntPtr handlePtr, HierarchyFlattened hierarchyFlattened, HierarchyNodeFlags defaultFlags, IntPtr nodesPtr, int nodesCount, int version) { }

	// RVA: 0x16CB34C
	private static void Destroy(IntPtr nativePtr) { }

	// RVA: 0x16CB7EC
	private void SetFlagsAll(HierarchyNodeFlags flags) { }

	// RVA: 0x16CB900
	private void SetFlagsNode(HierarchyNode node, HierarchyNodeFlags flags, bool recurse) { }

	// RVA: 0x16CBA08
	private bool HasAllFlagsNode(HierarchyNode node, HierarchyNodeFlags flags) { }

	// RVA: 0x16CBB10
	private void ClearFlagsNode(HierarchyNode node, HierarchyNodeFlags flags, bool recurse) { }

	// RVA: 0x16CC14C
	private static IntPtr CreateHierarchyViewModel(IntPtr nativePtr, IntPtr flattenedPtr, IntPtr nodesPtr, int nodesCount, int version) { }

	// RVA: 0x16CC1FC
	private static void UpdateHierarchyViewModel(IntPtr handlePtr, IntPtr nodesPtr, int nodesCount, int version) { }

	// RVA: 0x16CC324
	private static void SearchBegin(IntPtr handlePtr) { }

	// RVA: 0x16CAD80
	private static bool get_UpdateNeeded_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CAE58
	private static HierarchySearchQueryDescriptor get_Query_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CB51C
	private static int IndexOf_Injected(IntPtr _unity_self, HierarchyNode node) { }

	// RVA: 0x16CB60C
	private static bool Contains_Injected(IntPtr _unity_self, HierarchyNode node) { }

	// RVA: 0x16CB6FC
	private static int GetChildrenCount_Injected(IntPtr _unity_self, HierarchyNode node) { }

	// RVA: 0x16CBD38
	private static void Update_Injected(IntPtr _unity_self) { }

	// RVA: 0x16CBF3C
	private static IntPtr Create_Injected(IntPtr handlePtr, IntPtr hierarchyFlattened, HierarchyNodeFlags defaultFlags, IntPtr nodesPtr, int nodesCount, int version) { }

	// RVA: 0x16CBFBC
	private static void SetFlagsAll_Injected(IntPtr _unity_self, HierarchyNodeFlags flags) { }

	// RVA: 0x16CC024
	private static void SetFlagsNode_Injected(IntPtr _unity_self, HierarchyNode node, HierarchyNodeFlags flags, bool recurse) { }

	// RVA: 0x16CC08C
	private static bool HasAllFlagsNode_Injected(IntPtr _unity_self, HierarchyNode node, HierarchyNodeFlags flags) { }

	// RVA: 0x16CC0E4
	private static void ClearFlagsNode_Injected(IntPtr _unity_self, HierarchyNode node, HierarchyNodeFlags flags, bool recurse) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=6
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=6 E09F1B9774E7BD16FF4AA0F427CA8BA3FE2FCD832454BB60E741311C9CBB2F43; // 0x0
}


