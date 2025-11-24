// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Properties
public enum VisitExceptionKind
{
	// Fields
	public int value__; // 0x10
	public const VisitExceptionKind None = 0;
	public const VisitExceptionKind Internal = 1;
	public const VisitExceptionKind Visitor = 2;
	public const VisitExceptionKind All = 3;
}

// Namespace: Unity.Properties
public struct VisitParameters
{
	// Fields
	private VisitExceptionKind <IgnoreExceptions>k__BackingField; // 0x10

	// Methods

	// RVA: 0x172EB14
	public VisitExceptionKind get_IgnoreExceptions() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.PropertyContainer.GetPropertyVisitor.<>c <>9; // 0x0

	// Methods

	// RVA: 0x172ED9C
	private static void .cctor() { }

	// RVA: 0x172EE08
	public void .ctor() { }

	// RVA: 0x172EE10
	internal GetPropertyVisitor <.cctor>b__5_0() { }

	// RVA: 0x172EE68
	internal void <.cctor>b__5_1(GetPropertyVisitor v) { }

}

// Namespace: 
private class GetPropertyVisitor
{
	// Fields
	public static readonly UnityEngine.Pool.ObjectPool<Unity.Properties.PropertyContainer.GetPropertyVisitor> Pool; // 0x0
	public IProperty Property; // 0xB8

	// Methods

	// RVA: 0x172EB1C
	public override void Reset() { }

	// RVA: 0x3526BA8
	protected override void VisitPath(Unity.Properties.Property<TContainer,TValue> property, TContainer container, TValue value) { }

	// RVA: 0x172EBEC
	public void .ctor() { }

	// RVA: 0x172EBFC
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.PropertyContainer.GetValueVisitor.<>c<TSrcValue> <>9; // 0x0

	// Methods

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x3525804
	internal Unity.Properties.PropertyContainer.GetValueVisitor<TSrcValue> <.cctor>b__5_0() { }

	// RVA: 0x35267E8
	internal void <.cctor>b__5_1(Unity.Properties.PropertyContainer.GetValueVisitor<TSrcValue> v) { }

}

// Namespace: 
private class GetValueVisitor<T0>
{
	// Fields
	public static readonly UnityEngine.Pool.ObjectPool<Unity.Properties.PropertyContainer.GetValueVisitor<TSrcValue>> Pool; // 0x0
	public TSrcValue Value; // 0x0

	// Methods

	// RVA: 0x35263A0
	public override void Reset() { }

	// RVA: 0x3526BA8
	protected override void VisitPath(Unity.Properties.Property<TContainer,TValue> property, TContainer container, TValue value) { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: Unity.Properties
public static class PropertyContainer
{
	// Methods

	// RVA: 0x26AD93C
	public static void Accept(IPropertyBagVisitor visitor, TContainer container, VisitParameters parameters) { }

	// RVA: 0x26AD93C
	public static bool TryAccept(IPropertyBagVisitor visitor, TContainer container, VisitParameters parameters) { }

	// RVA: 0x26AD93C
	public static bool TryAccept(IPropertyBagVisitor visitor, TContainer container, VisitReturnCode returnCode, VisitParameters parameters) { }

	// RVA: 0x3527DAC
	public static bool TryGetProperty(TContainer container, PropertyPath path, IProperty property) { }

	// RVA: -1
	public static bool TryGetProperty(TContainer container, PropertyPath path, IProperty property, VisitReturnCode returnCode) { }

	// RVA: 0x3527DAC
	public static bool TryGetValue(TContainer container, string name, TValue value) { }

	// RVA: -1
	public static bool TryGetValue(TContainer container, PropertyPath path, TValue value, VisitReturnCode returnCode) { }

}

// Namespace: Unity.Properties
public enum VisitReturnCode
{
	// Fields
	public int value__; // 0x10
	public const VisitReturnCode Ok = 0;
	public const VisitReturnCode NullContainer = 1;
	public const VisitReturnCode InvalidContainerType = 2;
	public const VisitReturnCode MissingPropertyBag = 3;
	public const VisitReturnCode InvalidPath = 4;
	public const VisitReturnCode InvalidCast = 5;
	public const VisitReturnCode AccessViolation = 6;
}

// Namespace: Unity.Properties
public class CreatePropertyAttribute
{
	// Fields
	private bool <ReadOnly>k__BackingField; // 0x10

	// Methods

	// RVA: 0x172EE90
	public bool get_ReadOnly() { }

	// RVA: 0x172EE98
	public void set_ReadOnly(bool value) { }

	// RVA: 0x172EEA0
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class DontCreatePropertyAttribute
{
	// Methods

	// RVA: 0x172EEAC
	public void .ctor() { }

}

// Namespace: Unity.Properties
public enum TypeGenerationOptions
{
	// Fields
	public int value__; // 0x10
	public const TypeGenerationOptions None = 0;
	public const TypeGenerationOptions ValueType = 2;
	public const TypeGenerationOptions ReferenceType = 4;
	public const TypeGenerationOptions Default = 6;
}

// Namespace: Unity.Properties
public class GeneratePropertyBagsForTypesQualifiedWithAttribute
{
	// Fields
	private readonly Type <Type>k__BackingField; // 0x10
	private readonly TypeGenerationOptions <Options>k__BackingField; // 0x18

	// Methods

	// RVA: 0x172EEB4
	public void .ctor(Type type, TypeGenerationOptions options) { }

}

// Namespace: Unity.Properties
[Serializable]
public class MissingPropertyBagException
{
	// Fields
	private readonly Type <Type>k__BackingField; // 0x90

	// Methods

	// RVA: 0x172EFA8
	public void .ctor(Type type) { }

	// RVA: 0x172F0AC
	private static string GetMessageForType(Type type) { }

}

// Namespace: Unity.Properties
public struct AttributesScope
{
	// Fields
	private readonly IAttributes m_Target; // 0x10
	private readonly System.Collections.Generic.List<System.Attribute> m_Previous; // 0x18

	// Methods

	// RVA: 0x172F138
	public void .ctor(IProperty target, IProperty source) { }

	// RVA: 0x172F344
	internal void .ctor(IAttributes target, System.Collections.Generic.List<System.Attribute> attributes) { }

	// RVA: 0x172F474
	public void Dispose() { }

}

// Namespace: Unity.Properties
public sealed class PropertyGetter<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: Unity.Properties
public sealed class PropertySetter<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(TContainer container, TValue value) { }

}

// Namespace: Unity.Properties
public class DelegateProperty<T0, T1>
{
	// Fields
	private readonly Unity.Properties.PropertyGetter<TContainer,TValue> m_Getter; // 0x0
	private readonly Unity.Properties.PropertySetter<TContainer,TValue> m_Setter; // 0x0
	private readonly string <Name>k__BackingField; // 0x0

	// Methods

	// RVA: 0x3525804
	public override string get_Name() { }

	// RVA: 0x35251DC
	public override bool get_IsReadOnly() { }

	// RVA: 0x3526BA8
	public void .ctor(string name, Unity.Properties.PropertyGetter<TContainer,TValue> getter, Unity.Properties.PropertySetter<TContainer,TValue> setter) { }

	// RVA: 0x26AD93C
	public override TValue GetValue(TContainer container) { }

	// RVA: 0x26AD93C
	public override void SetValue(TContainer container, TValue value) { }

}

// Namespace: Unity.Properties
public interface IListElementProperty
{
	// Methods

	// RVA: -1
	public abstract int get_Index() { }

}

// Namespace: Unity.Properties
public interface ISetElementProperty
{
	// Methods

	// RVA: -1
	public abstract object get_ObjectKey() { }

}

// Namespace: Unity.Properties
public interface IDictionaryElementProperty
{
	// Methods

	// RVA: -1
	public abstract object get_ObjectKey() { }

}

// Namespace: Unity.Properties
public interface IProperty
{
	// Methods

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: -1
	public abstract Type DeclaredValueType() { }

}

// Namespace: Unity.Properties
public interface IProperty<T0>
{}

// Namespace: Unity.Properties
public abstract class Property<T0, T1>
{
	// Fields
	private System.Collections.Generic.List<System.Attribute> m_Attributes; // 0x0

	// Methods

	// RVA: 0x3525804
	private System.Collections.Generic.List<System.Attribute> Unity.Properties.Internal.IAttributes.get_Attributes() { }

	// RVA: 0x35267E8
	private void Unity.Properties.Internal.IAttributes.set_Attributes(System.Collections.Generic.List<System.Attribute> value) { }

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: -1
	public abstract bool get_IsReadOnly() { }

	// RVA: 0x3525804
	public Type DeclaredValueType() { }

	// RVA: 0x35269D4
	public void Accept(IPropertyVisitor visitor, TContainer container) { }

	// RVA: -1
	public abstract TValue GetValue(TContainer container) { }

	// RVA: -1
	public abstract void SetValue(TContainer container, TValue value) { }

	// RVA: 0x35267E8
	protected void AddAttribute(Attribute attribute) { }

	// RVA: 0x35267E8
	protected void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

	// RVA: 0x35267E8
	private void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }

	// RVA: 0x35267E8
	private void Unity.Properties.Internal.IAttributes.AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

	// RVA: 0x35251DC
	public bool HasAttribute() { }

	// RVA: 0x26AD93C
	public TAttribute GetAttribute() { }

	// RVA: -1
	private AttributesScope Unity.Properties.Internal.IAttributes.CreateAttributesScope(IAttributes attributes) { }

	// RVA: 0x35263A0
	protected void .ctor() { }

}

// Namespace: Unity.Properties
public enum PropertyPathPartKind
{
	// Fields
	public int value__; // 0x10
	public const PropertyPathPartKind Name = 0;
	public const PropertyPathPartKind Index = 1;
	public const PropertyPathPartKind Key = 2;
}

// Namespace: Unity.Properties
public struct PropertyPathPart
{
	// Fields
	private readonly PropertyPathPartKind m_Kind; // 0x10
	private readonly string m_Name; // 0x18
	private readonly int m_Index; // 0x20
	private readonly object m_Key; // 0x28

	// Methods

	// RVA: 0x172F540
	public bool get_IsName() { }

	// RVA: 0x172F550
	public bool get_IsIndex() { }

	// RVA: 0x172F560
	public PropertyPathPartKind get_Kind() { }

	// RVA: 0x172F568
	public string get_Name() { }

	// RVA: 0x172F5C0
	public int get_Index() { }

	// RVA: 0x172F61C
	public object get_Key() { }

	// RVA: 0x172F678
	public void .ctor(string name) { }

	// RVA: 0x172F6B4
	public void .ctor(int index) { }

	// RVA: 0x172F708
	public void .ctor(object key) { }

	// RVA: 0x172F760
	private void CheckKind(PropertyPathPartKind type) { }

	// RVA: 0x172F7B8
	public override string ToString() { }

	// RVA: 0x172F8EC
	public bool Equals(PropertyPathPart other) { }

	// RVA: 0x172F95C
	public override bool Equals(object obj) { }

	// RVA: 0x172FA20
	public override int GetHashCode() { }

}

// Namespace: 
private struct <>c__DisplayClass36_0
{
	// Fields
	public int index; // 0x10
	public int length; // 0x14
	public string path; // 0x18
	public int state; // 0x20
}

// Namespace: Unity.Properties
public struct PropertyPath
{
	// Fields
	internal const int k_InlineCount = 4;
	private readonly PropertyPathPart m_Part0; // 0x10
	private readonly PropertyPathPart m_Part1; // 0x30
	private readonly PropertyPathPart m_Part2; // 0x50
	private readonly PropertyPathPart m_Part3; // 0x70
	private readonly PropertyPathPart[] m_AdditionalParts; // 0x90
	private readonly int <Length>k__BackingField; // 0x98

	// Methods

	// RVA: 0x172FAF0
	public int get_Length() { }

	// RVA: 0x172FAF8
	public bool get_IsEmpty() { }

	// RVA: 0x172FB08
	public PropertyPathPart get_Item(int index) { }

	// RVA: 0x172FC44
	public void .ctor(string path) { }

	// RVA: 0x1730ECC
	private void .ctor(PropertyPathPart part) { }

	// RVA: 0x1730F24
	private void .ctor(PropertyPathPart part0, PropertyPathPart part1) { }

	// RVA: 0x1730F90
	private void .ctor(PropertyPathPart part0, PropertyPathPart part1, PropertyPathPart part2) { }

	// RVA: 0x1731018
	private void .ctor(PropertyPathPart part0, PropertyPathPart part1, PropertyPathPart part2, PropertyPathPart part3) { }

	// RVA: 0x17310B0
	internal void .ctor(System.Collections.Generic.List<Unity.Properties.PropertyPathPart> parts) { }

	// RVA: 0x17312F0
	public static PropertyPath FromIndex(int index) { }

	// RVA: 0x17313B8
	public static PropertyPath Combine(PropertyPath path, PropertyPath pathToAppend) { }

	// RVA: 0x173195C
	public static PropertyPath AppendPart(PropertyPath path, PropertyPathPart part) { }

	// RVA: 0x1731D68
	public static PropertyPath AppendIndex(PropertyPath path, int index) { }

	// RVA: 0x1731E2C
	public static PropertyPath AppendProperty(PropertyPath path, IProperty property) { }

	// RVA: 0x173216C
	public static PropertyPath Pop(PropertyPath path) { }

	// RVA: 0x17321CC
	public static PropertyPath SubPath(PropertyPath path, int startIndex, int length) { }

	// RVA: 0x17327B4
	public override string ToString() { }

	// RVA: 0x1732944
	private static void AppendToBuilder(PropertyPathPart part, StringBuilder builder) { }

	// RVA: 0x173189C
	private static void GetParts(PropertyPath path, System.Collections.Generic.List<Unity.Properties.PropertyPathPart> parts) { }

	// RVA: 0x172FD5C
	private static PropertyPath ConstructFromPath(string path) { }

	// RVA: 0x1732BD4
	public static bool op_Equality(PropertyPath lhs, PropertyPath rhs) { }

	// RVA: 0x1732D08
	public static bool op_Inequality(PropertyPath lhs, PropertyPath rhs) { }

	// RVA: 0x1732C1C
	public bool Equals(PropertyPath other) { }

	// RVA: 0x1732D88
	public override bool Equals(object obj) { }

	// RVA: 0x1732E48
	public override int GetHashCode() { }

	// RVA: 0x1732A10
	internal static void <ConstructFromPath>g__TrimStart|36_0(Unity.Properties.PropertyPath.<>c__DisplayClass36_0& ) { }

	// RVA: 0x1732A68
	internal static void <ConstructFromPath>g__ReadNext|36_1(Unity.Properties.PropertyPath.<>c__DisplayClass36_0& ) { }

}

// Namespace: Unity.Properties
internal interface IMemberInfo
{
	// Methods

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: -1
	public abstract bool get_IsReadOnly() { }

	// RVA: -1
	public abstract Type get_ValueType() { }

	// RVA: -1
	public abstract object GetValue(object obj) { }

	// RVA: -1
	public abstract void SetValue(object obj, object value) { }

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: Unity.Properties
internal struct FieldMember
{
	// Fields
	internal readonly FieldInfo m_FieldInfo; // 0x10
	private readonly string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1732F40
	public void .ctor(FieldInfo fieldInfo) { }

	// RVA: 0x1733070
	public string get_Name() { }

	// RVA: 0x1733078
	public bool get_IsReadOnly() { }

	// RVA: 0x1733098
	public Type get_ValueType() { }

	// RVA: 0x17330C0
	public object GetValue(object obj) { }

	// RVA: 0x17330E8
	public void SetValue(object obj, object value) { }

	// RVA: 0x1733108
	public System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: Unity.Properties
internal struct PropertyMember
{
	// Fields
	internal readonly PropertyInfo m_PropertyInfo; // 0x10
	private readonly string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1733114
	public string get_Name() { }

	// RVA: 0x173311C
	public bool get_IsReadOnly() { }

	// RVA: 0x173314C
	public Type get_ValueType() { }

	// RVA: 0x1733174
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x17331AC
	public object GetValue(object obj) { }

	// RVA: 0x17331CC
	public void SetValue(object obj, object value) { }

	// RVA: 0x17331EC
	public System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: 
private sealed class GetStructValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: 
private sealed class SetStructValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(TContainer container, TValue value) { }

}

// Namespace: 
private sealed class GetClassValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: 
private sealed class SetClassValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(TContainer container, TValue value) { }

}

// Namespace: Unity.Properties
public class ReflectedMemberProperty<T0, T1>
{
	// Fields
	private readonly IMemberInfo m_Info; // 0x0
	private readonly bool m_IsStructContainerType; // 0x0
	private GetStructValueAction m_GetStructValueAction; // 0x0
	private SetStructValueAction m_SetStructValueAction; // 0x0
	private GetClassValueAction m_GetClassValueAction; // 0x0
	private SetClassValueAction m_SetClassValueAction; // 0x0
	private readonly string <Name>k__BackingField; // 0x0
	private readonly bool <IsReadOnly>k__BackingField; // 0x0

	// Methods

	// RVA: 0x3525804
	public override string get_Name() { }

	// RVA: 0x35251DC
	public override bool get_IsReadOnly() { }

	// RVA: 0x35269D4
	internal void .ctor(IMemberInfo info, string name) { }

	// RVA: 0x26AD93C
	public override TValue GetValue(TContainer container) { }

	// RVA: 0x26AD93C
	public override void SetValue(TContainer container, TValue value) { }

}

// Namespace: Unity.Properties
public sealed class ArrayPropertyBag<T0>
{
	// Methods

	// RVA: 0x35254D0
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: -1
	protected override TElement[] InstantiateWithCount(int count) { }

	// RVA: 0x3525804
	protected override TElement[] Instantiate() { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: Unity.Properties
public abstract class ContainerPropertyBag<T0>
{
	// Fields
	private readonly System.Collections.Generic.List<Unity.Properties.IProperty<TContainer>> m_PropertiesList; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.String,Unity.Properties.IProperty<TContainer>> m_PropertiesHash; // 0x0

	// Methods

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35267E8
	protected void AddProperty(Unity.Properties.Property<TContainer,TValue> property) { }

	// RVA: 0x26AD93C
	public override Unity.Properties.PropertyCollection<TContainer> GetProperties() { }

	// RVA: 0x26AD93C
	public override Unity.Properties.PropertyCollection<TContainer> GetProperties(TContainer container) { }

	// RVA: -1
	public bool TryGetProperty(TContainer container, string name, Unity.Properties.IProperty<TContainer>& property) { }

	// RVA: 0x35263A0
	protected void .ctor() { }

}

// Namespace: Unity.Properties
public class DictionaryPropertyBag<T0, T1>
{
	// Methods

	// RVA: 0x35254D0
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x3525804
	protected override System.Collections.Generic.Dictionary<TKey,TValue> Instantiate() { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class HashSetPropertyBag<T0>
{
	// Methods

	// RVA: 0x35254D0
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x3525804
	protected override System.Collections.Generic.HashSet<TElement> Instantiate() { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: Unity.Properties
internal struct IndexedCollectionPropertyBagEnumerable<T0>
{
	// Fields
	private readonly Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl; // 0x0
	private readonly TContainer m_Container; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public void .ctor(Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container) { }

	// RVA: 0x26AD93C
	public Unity.Properties.IndexedCollectionPropertyBagEnumerator<TContainer> GetEnumerator() { }

}

// Namespace: Unity.Properties
internal struct IndexedCollectionPropertyBagEnumerator<T0>
{
	// Fields
	private readonly Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl; // 0x0
	private readonly IndexedCollectionSharedPropertyState m_Previous; // 0x0
	private TContainer m_Container; // 0x0
	private int m_Position; // 0x0

	// Methods

	// RVA: 0x26AD93C
	internal void .ctor(Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container) { }

	// RVA: 0x3525804
	public Unity.Properties.IProperty<TContainer> get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x35263A0
	public void Reset() { }

	// RVA: 0x35263A0
	public void Dispose() { }

}

// Namespace: Unity.Properties
internal interface IIndexedCollectionPropertyBagEnumerator<T0>
{
	// Methods

	// RVA: -1
	public abstract int GetCount(TContainer container) { }

	// RVA: -1
	public abstract Unity.Properties.IProperty<TContainer> GetSharedProperty() { }

	// RVA: -1
	public abstract IndexedCollectionSharedPropertyState GetSharedPropertyState() { }

	// RVA: -1
	public abstract void SetSharedPropertyState(IndexedCollectionSharedPropertyState state) { }

}

// Namespace: Unity.Properties
internal struct IndexedCollectionSharedPropertyState
{
	// Fields
	public int Index; // 0x10
	public bool IsReadOnly; // 0x14
}

// Namespace: 
private class ListElementProperty
{
	// Fields
	internal int m_Index; // 0x0
	internal bool m_IsReadOnly; // 0x0

	// Methods

	// RVA: 0x35254D0
	public int get_Index() { }

	// RVA: 0x3525804
	public override string get_Name() { }

	// RVA: 0x35251DC
	public override bool get_IsReadOnly() { }

	// RVA: 0x26AD93C
	public override TElement GetValue(TList container) { }

	// RVA: 0x26AD93C
	public override void SetValue(TList container, TElement value) { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class IndexedCollectionPropertyBag<T0, T1>
{
	// Fields
	private readonly ListElementProperty m_Property; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public override Unity.Properties.PropertyCollection<TList> GetProperties() { }

	// RVA: 0x26AD93C
	public override Unity.Properties.PropertyCollection<TList> GetProperties(TList container) { }

	// RVA: -1
	public bool TryGetProperty(TList container, int index, Unity.Properties.IProperty<TList>& property) { }

	// RVA: 0x35269D4
	private void Unity.Properties.ICollectionPropertyBagAccept<TList>.Accept(ICollectionPropertyBagVisitor visitor, TList container) { }

	// RVA: 0x35269D4
	private void Unity.Properties.IListPropertyBagAccept<TList>.Accept(IListPropertyBagVisitor visitor, TList list) { }

	// RVA: 0x3526C14
	private void Unity.Properties.IListPropertyAccept<TList>.Accept(IListPropertyVisitor visitor, Unity.Properties.Property<TContainer,TList> property, TContainer container, TList list) { }

	// RVA: 0x26AD93C
	private TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }

	// RVA: 0x26AD93C
	protected virtual TList InstantiateWithCount(int count) { }

	// RVA: 0x3525600
	private int Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetCount(TList container) { }

	// RVA: 0x3525804
	private Unity.Properties.IProperty<TList> Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty() { }

	// RVA: -1
	private IndexedCollectionSharedPropertyState Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedPropertyState() { }

	// RVA: -1
	private void Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.SetSharedPropertyState(IndexedCollectionSharedPropertyState state) { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: Unity.Properties
public interface IIndexedProperties<T0>
{
	// Methods

	// RVA: -1
	public abstract bool TryGetProperty(TContainer container, int index, Unity.Properties.IProperty<TContainer>& property) { }

}

// Namespace: Unity.Properties
public interface INamedProperties<T0>
{
	// Methods

	// RVA: -1
	public abstract bool TryGetProperty(TContainer container, string name, Unity.Properties.IProperty<TContainer>& property) { }

}

// Namespace: Unity.Properties
public interface IKeyedProperties<T0, T1>
{
	// Methods

	// RVA: -1
	public abstract bool TryGetProperty(TContainer container, TKey key, Unity.Properties.IProperty<TContainer>& property) { }

}

// Namespace: Unity.Properties
public interface IPropertyBag
{
	// Methods

	// RVA: -1
	public abstract void Accept(ITypeVisitor visitor) { }

	// RVA: -1
	public abstract void Accept(IPropertyBagVisitor visitor, object container) { }

}

// Namespace: Unity.Properties
public interface IPropertyBag<T0>
{
	// Methods

	// RVA: -1
	public abstract Unity.Properties.PropertyCollection<TContainer> GetProperties() { }

	// RVA: -1
	public abstract Unity.Properties.PropertyCollection<TContainer> GetProperties(TContainer container) { }

	// RVA: -1
	public abstract void Accept(IPropertyBagVisitor visitor, TContainer container) { }

}

// Namespace: Unity.Properties
public interface ICollectionPropertyBag<T0, T1>
{}

// Namespace: Unity.Properties
public interface IListPropertyBag<T0, T1>
{}

// Namespace: Unity.Properties
public interface ISetPropertyBag<T0, T1>
{}

// Namespace: Unity.Properties
public interface IDictionaryPropertyBag<T0, T1, T2>
{}

// Namespace: 
private class KeyValuePairProperty
{
	// Fields
	private TKey <Key>k__BackingField; // 0x0

	// Methods

	// RVA: 0x3525804
	public override string get_Name() { }

	// RVA: 0x35251DC
	public override bool get_IsReadOnly() { }

	// RVA: 0x26AD93C
	public override System.Collections.Generic.KeyValuePair<TKey,TValue> GetValue(TDictionary container) { }

	// RVA: 0x26AD93C
	public override void SetValue(TDictionary container, System.Collections.Generic.KeyValuePair<TKey,TValue> value) { }

	// RVA: 0x26AD93C
	public TKey get_Key() { }

	// RVA: 0x26AD93C
	internal void set_Key(TKey value) { }

	// RVA: 0x3525804
	public object get_ObjectKey() { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	private readonly TDictionary m_Dictionary; // 0x0
	private readonly KeyValuePairProperty m_Property; // 0x0
	private readonly TKey m_Previous; // 0x0
	private readonly System.Collections.Generic.List<TKey> m_Keys; // 0x0
	private int m_Position; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public void .ctor(TDictionary dictionary, KeyValuePairProperty property) { }

	// RVA: 0x3525804
	public Unity.Properties.IProperty<TDictionary> get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x35263A0
	public void Reset() { }

	// RVA: 0x35263A0
	public void Dispose() { }

}

// Namespace: 
private struct Enumerable
{
	// Fields
	private readonly TDictionary m_Dictionary; // 0x0
	private readonly KeyValuePairProperty m_Property; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public void .ctor(TDictionary dictionary, KeyValuePairProperty property) { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TDictionary>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TDictionary>>.GetEnumerator() { }

}

// Namespace: Unity.Properties
public class KeyValueCollectionPropertyBag<T0, T1, T2>
{
	// Fields
	private readonly KeyValuePairProperty m_KeyValuePairProperty; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public override Unity.Properties.PropertyCollection<TDictionary> GetProperties() { }

	// RVA: 0x26AD93C
	public override Unity.Properties.PropertyCollection<TDictionary> GetProperties(TDictionary container) { }

	// RVA: 0x35269D4
	private void Unity.Properties.ICollectionPropertyBagAccept<TDictionary>.Accept(ICollectionPropertyBagVisitor visitor, TDictionary container) { }

	// RVA: 0x35269D4
	private void Unity.Properties.IDictionaryPropertyBagAccept<TDictionary>.Accept(IDictionaryPropertyBagVisitor visitor, TDictionary container) { }

	// RVA: -1
	private bool Unity.Properties.IKeyedProperties<TDictionary,System.Object>.TryGetProperty(TDictionary container, object key, Unity.Properties.IProperty<TDictionary>& property) { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.KeyValuePairPropertyBag.<>c<TKey,TValue> <>9; // 0x0

	// Methods

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal TKey <.cctor>b__7_0(System.Collections.Generic.KeyValuePair<TKey,TValue>& container) { }

	// RVA: 0x26AD93C
	internal TValue <.cctor>b__7_1(System.Collections.Generic.KeyValuePair<TKey,TValue>& container) { }

}

// Namespace: 
private sealed class <GetPropertiesEnumerable>d__4
{
	// Fields
	private int <>1__state; // 0x0
	private Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>> <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0

	// Methods

	// RVA: 0x3526518
	public void .ctor(int <>1__state) { }

	// RVA: 0x35263A0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35251DC
	private bool MoveNext() { }

	// RVA: 0x3525804
	private Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>>.get_Current() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>>.GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: Unity.Properties
public class KeyValuePairPropertyBag<T0, T1>
{
	// Fields
	private static readonly Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>,TKey> s_KeyProperty; // 0x0
	private static readonly Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>,TValue> s_ValueProperty; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public override Unity.Properties.PropertyCollection<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetProperties() { }

	// RVA: 0x26AD93C
	public override Unity.Properties.PropertyCollection<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetProperties(System.Collections.Generic.KeyValuePair<TKey,TValue>& container) { }

	// RVA: 0x35293B4
	private static System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>> GetPropertiesEnumerable() { }

	// RVA: -1
	public bool TryGetProperty(System.Collections.Generic.KeyValuePair<TKey,TValue>& container, string name, Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>& property) { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: Unity.Properties
public class ListPropertyBag<T0>
{
	// Methods

	// RVA: 0x35254D0
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: -1
	protected override System.Collections.Generic.List<TElement> InstantiateWithCount(int count) { }

	// RVA: 0x3525804
	protected override System.Collections.Generic.List<TElement> Instantiate() { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: Unity.Properties
public static class PropertyBag
{
	// Methods

	// RVA: 0x352D47C
	public static void AcceptWithSpecializedVisitor(Unity.Properties.IPropertyBag<TContainer> properties, IPropertyBagVisitor visitor, TContainer container) { }

	// RVA: 0x352BD5C
	public static void Register(Unity.Properties.PropertyBag<TContainer> propertyBag) { }

	// RVA: 0x352AE04
	public static void RegisterList() { }

	// RVA: 0x352AE04
	public static void RegisterList() { }

	// RVA: 0x17331F8
	public static IPropertyBag GetPropertyBag(Type type) { }

	// RVA: 0x35293B4
	public static Unity.Properties.IPropertyBag<TContainer> GetPropertyBag() { }

	// RVA: 0x3527C54
	public static bool TryGetPropertyBagForValue(TValue value, IPropertyBag propertyBag) { }

}

// Namespace: Unity.Properties
public abstract class PropertyBag<T0>
{
	// Fields
	private readonly InstantiationKind <InstantiationKind>k__BackingField; // 0x0

	// Methods

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	private void Unity.Properties.Internal.IPropertyBagRegister.Register() { }

	// RVA: 0x35267E8
	public void Accept(ITypeVisitor visitor) { }

	// RVA: 0x35269D4
	private void Unity.Properties.IPropertyBag.Accept(IPropertyBagVisitor visitor, object container) { }

	// RVA: 0x35269D4
	private void Unity.Properties.IPropertyBag<TContainer>.Accept(IPropertyBagVisitor visitor, TContainer container) { }

	// RVA: 0x26AD93C
	private Unity.Properties.PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties() { }

	// RVA: 0x26AD93C
	private Unity.Properties.PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties(TContainer container) { }

	// RVA: 0x35254D0
	private InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }

	// RVA: 0x26AD93C
	private TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }

	// RVA: -1
	public abstract Unity.Properties.PropertyCollection<TContainer> GetProperties() { }

	// RVA: -1
	public abstract Unity.Properties.PropertyCollection<TContainer> GetProperties(TContainer container) { }

	// RVA: 0x35254D0
	protected virtual InstantiationKind get_InstantiationKind() { }

	// RVA: 0x26AD93C
	protected virtual TContainer Instantiate() { }

	// RVA: 0x35263A0
	protected void .ctor() { }

}

// Namespace: 
private enum EnumeratorType
{
	// Fields
	public int value__; // 0x0
	public const EnumeratorType Empty = 0;
	public const EnumeratorType Enumerable = 1;
	public const EnumeratorType List = 2;
	public const EnumeratorType IndexedCollectionPropertyBag = 3;
}

// Namespace: 
public struct Enumerator
{
	// Fields
	private readonly EnumeratorType m_Type; // 0x0
	private System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TContainer>> m_Enumerator; // 0x0
	private Enumerator m_Properties; // 0x0
	private Unity.Properties.IndexedCollectionPropertyBagEnumerator<TContainer> m_IndexedCollectionPropertyBag; // 0x0
	private Unity.Properties.IProperty<TContainer> <Current>k__BackingField; // 0x0

	// Methods

	// RVA: 0x3525804
	public Unity.Properties.IProperty<TContainer> get_Current() { }

	// RVA: 0x35267E8
	private void set_Current(Unity.Properties.IProperty<TContainer> value) { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35267E8
	internal void .ctor(System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TContainer>> enumerator) { }

	// RVA: 0x26AD93C
	internal void .ctor(Enumerator properties) { }

	// RVA: 0x26AD93C
	internal void .ctor(Unity.Properties.IndexedCollectionPropertyBagEnumerator<TContainer> enumerator) { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x35263A0
	public void Reset() { }

	// RVA: 0x35263A0
	public void Dispose() { }

}

// Namespace: Unity.Properties
public struct PropertyCollection<T0>
{
	// Fields
	private readonly EnumeratorType m_Type; // 0x0
	private readonly System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>> m_Enumerable; // 0x0
	private readonly System.Collections.Generic.List<Unity.Properties.IProperty<TContainer>> m_Properties; // 0x0
	private readonly Unity.Properties.IndexedCollectionPropertyBagEnumerable<TContainer> m_IndexedCollectionPropertyBag; // 0x0
	private static readonly Unity.Properties.PropertyCollection<TContainer> <Empty>k__BackingField; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public static Unity.Properties.PropertyCollection<TContainer> get_Empty() { }

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>> enumerable) { }

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.List<Unity.Properties.IProperty<TContainer>> properties) { }

	// RVA: 0x26AD93C
	internal void .ctor(Unity.Properties.IndexedCollectionPropertyBagEnumerable<TContainer> enumerable) { }

	// RVA: 0x26AD93C
	public Enumerator GetEnumerator() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TContainer>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: 
private class SetElementProperty
{
	// Fields
	internal TElement m_Value; // 0x0

	// Methods

	// RVA: 0x3525804
	public override string get_Name() { }

	// RVA: 0x35251DC
	public override bool get_IsReadOnly() { }

	// RVA: 0x26AD93C
	public override TElement GetValue(TSet container) { }

	// RVA: 0x26AD93C
	public override void SetValue(TSet container, TElement value) { }

	// RVA: 0x3525804
	public object get_ObjectKey() { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: 
private sealed class <GetPropertiesEnumerable>d__4
{
	// Fields
	private int <>1__state; // 0x0
	private Unity.Properties.IProperty<TSet> <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private TSet container; // 0x0
	public TSet <>3__container; // 0x0
	public Unity.Properties.SetPropertyBagBase<TSet,TElement> <>4__this; // 0x0
	private System.Collections.Generic.IEnumerator<TElement> <>s__1; // 0x0
	private TElement <element>5__2; // 0x0

	// Methods

	// RVA: 0x3526518
	public void .ctor(int <>1__state) { }

	// RVA: 0x35263A0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35251DC
	private bool MoveNext() { }

	// RVA: 0x35263A0
	private void <>m__Finally1() { }

	// RVA: 0x3525804
	private Unity.Properties.IProperty<TSet> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TSet>>.get_Current() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TSet>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TSet>>.GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: Unity.Properties
public class SetPropertyBagBase<T0, T1>
{
	// Fields
	private readonly SetElementProperty m_Property; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public override Unity.Properties.PropertyCollection<TSet> GetProperties() { }

	// RVA: 0x26AD93C
	public override Unity.Properties.PropertyCollection<TSet> GetProperties(TSet container) { }

	// RVA: 0x26AD93C
	private System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TSet>> GetPropertiesEnumerable(TSet container) { }

	// RVA: 0x35269D4
	private void Unity.Properties.ICollectionPropertyBagAccept<TSet>.Accept(ICollectionPropertyBagVisitor visitor, TSet container) { }

	// RVA: 0x35269D4
	private void Unity.Properties.ISetPropertyBagAccept<TSet>.Accept(ISetPropertyBagVisitor visitor, TSet container) { }

	// RVA: -1
	public bool TryGetProperty(TSet container, object key, Unity.Properties.IProperty<TSet>& property) { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: Unity.Properties
public abstract class ConcreteTypeVisitor
{
	// Methods

	// RVA: -1
	protected abstract void VisitContainer(TContainer container) { }

	// RVA: 0x35269D4
	private void Unity.Properties.IPropertyBagVisitor.Visit(Unity.Properties.IPropertyBag<TContainer> properties, TContainer container) { }

	// RVA: 0x17334C4
	protected void .ctor() { }

}

// Namespace: Unity.Properties
public interface ICollectionPropertyBagAccept<T0>
{
	// Methods

	// RVA: -1
	public abstract void Accept(ICollectionPropertyBagVisitor visitor, TContainer container) { }

}

// Namespace: Unity.Properties
public interface IListPropertyBagAccept<T0>
{
	// Methods

	// RVA: -1
	public abstract void Accept(IListPropertyBagVisitor visitor, TContainer container) { }

}

// Namespace: Unity.Properties
public interface ISetPropertyBagAccept<T0>
{
	// Methods

	// RVA: -1
	public abstract void Accept(ISetPropertyBagVisitor visitor, TContainer container) { }

}

// Namespace: Unity.Properties
public interface IDictionaryPropertyBagAccept<T0>
{
	// Methods

	// RVA: -1
	public abstract void Accept(IDictionaryPropertyBagVisitor visitor, TContainer container) { }

}

// Namespace: Unity.Properties
public interface IPropertyAccept<T0>
{
	// Methods

	// RVA: -1
	public abstract void Accept(IPropertyVisitor visitor, TContainer container) { }

}

// Namespace: Unity.Properties
public interface IListPropertyAccept<T0>
{
	// Methods

	// RVA: -1
	public abstract void Accept(IListPropertyVisitor visitor, Unity.Properties.Property<TContainer,TList> property, TContainer container, TList list) { }

}

// Namespace: Unity.Properties
public interface ITypeVisitor
{
	// Methods

	// RVA: -1
	public abstract void Visit() { }

}

// Namespace: Unity.Properties
public interface IPropertyBagVisitor
{
	// Methods

	// RVA: -1
	public abstract void Visit(Unity.Properties.IPropertyBag<TContainer> properties, TContainer container) { }

}

// Namespace: Unity.Properties
public interface ICollectionPropertyBagVisitor
{
	// Methods

	// RVA: -1
	public abstract void Visit(Unity.Properties.ICollectionPropertyBag<TCollection,TElement> properties, TCollection container) { }

}

// Namespace: Unity.Properties
public interface IListPropertyBagVisitor
{
	// Methods

	// RVA: -1
	public abstract void Visit(Unity.Properties.IListPropertyBag<TList,TElement> properties, TList container) { }

}

// Namespace: Unity.Properties
public interface ISetPropertyBagVisitor
{
	// Methods

	// RVA: -1
	public abstract void Visit(Unity.Properties.ISetPropertyBag<TSet,TValue> properties, TSet container) { }

}

// Namespace: Unity.Properties
public interface IDictionaryPropertyBagVisitor
{
	// Methods

	// RVA: -1
	public abstract void Visit(Unity.Properties.IDictionaryPropertyBag<TDictionary,TKey,TValue> properties, TDictionary container) { }

}

// Namespace: Unity.Properties
public interface IPropertyVisitor
{
	// Methods

	// RVA: -1
	public abstract void Visit(Unity.Properties.Property<TContainer,TValue> property, TContainer container) { }

}

// Namespace: Unity.Properties
public interface IListPropertyVisitor
{
	// Methods

	// RVA: -1
	public abstract void Visit(Unity.Properties.Property<TContainer,TList> property, TContainer container, TList list) { }

}

// Namespace: 
private struct PropertyScope
{
	// Fields
	private readonly PathVisitor m_Visitor; // 0x10
	private readonly IProperty m_Property; // 0x18

	// Methods

	// RVA: 0x1733568
	public void .ctor(PathVisitor visitor, IProperty property) { }

	// RVA: 0x17335BC
	public void Dispose() { }

}

// Namespace: Unity.Properties
public abstract class PathVisitor
{
	// Fields
	private int m_PathIndex; // 0x10
	private PropertyPath <Path>k__BackingField; // 0x18
	private IProperty <Property>k__BackingField; // 0xA8
	private bool <ReadonlyVisit>k__BackingField; // 0xB0
	private VisitReturnCode <ReturnCode>k__BackingField; // 0xB4

	// Methods

	// RVA: 0x17334CC
	public PropertyPath get_Path() { }

	// RVA: 0x1733508
	public void set_Path(PropertyPath value) { }

	// RVA: 0x172EB90
	public virtual void Reset() { }

	// RVA: 0x1733538
	private IProperty get_Property() { }

	// RVA: 0x1733540
	private void set_Property(IProperty value) { }

	// RVA: 0x1733548
	public bool get_ReadonlyVisit() { }

	// RVA: 0x1733550
	public void set_ReadonlyVisit(bool value) { }

	// RVA: 0x1733558
	public VisitReturnCode get_ReturnCode() { }

	// RVA: 0x1733560
	protected void set_ReturnCode(VisitReturnCode value) { }

	// RVA: 0x35269D4
	private void Unity.Properties.IPropertyBagVisitor.Visit(Unity.Properties.IPropertyBag<TContainer> properties, TContainer container) { }

	// RVA: 0x35269D4
	private void Unity.Properties.IPropertyVisitor.Visit(Unity.Properties.Property<TContainer,TValue> property, TContainer container) { }

	// RVA: 0x3526BA8
	protected virtual void VisitPath(Unity.Properties.Property<TContainer,TValue> property, TContainer container, TValue value) { }

	// RVA: 0x172EBF4
	protected void .ctor() { }

}

// Namespace: 
private class ConverterKeyComparer
{
	// Methods

	// RVA: 0x1733A88
	public bool Equals(ConverterKey x, ConverterKey y) { }

	// RVA: 0x1733B30
	public int GetHashCode(ConverterKey obj) { }

	// RVA: 0x1733A80
	public void .ctor() { }

}

// Namespace: 
private struct ConverterKey
{
	// Fields
	public readonly Type SourceType; // 0x10
	public readonly Type DestinationType; // 0x18

	// Methods

	// RVA: 0x17337B0
	public void .ctor(Type source, Type destination) { }

}

// Namespace: Unity.Properties
internal struct ConversionRegistry
{
	// Fields
	private static readonly ConverterKeyComparer Comparer; // 0x0
	private readonly System.Collections.Generic.Dictionary<Unity.Properties.ConversionRegistry.ConverterKey,System.Delegate> m_Converters; // 0x10

	// Methods

	// RVA: 0x17335E4
	private void .ctor(System.Collections.Generic.Dictionary<Unity.Properties.ConversionRegistry.ConverterKey,System.Delegate> storage) { }

	// RVA: 0x17335EC
	public static ConversionRegistry Create() { }

	// RVA: 0x17336AC
	public void Register(Type source, Type destination, Delegate converter) { }

	// RVA: 0x17337E4
	public Delegate GetConverter(Type source, Type destination) { }

	// RVA: 0x173389C
	public bool TryGetConverter(Type source, Type destination, Delegate converter) { }

	// RVA: 0x17339CC
	public bool Equals(ConversionRegistry x, ConversionRegistry y) { }

	// RVA: 0x17339D8
	public int GetHashCode(ConversionRegistry obj) { }

	// RVA: 0x17339F8
	private static void .cctor() { }

}

// Namespace: Unity.Properties
public sealed class TypeConverter<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual TDestination Invoke(TSource value) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.TypeConversion.PrimitiveConverters.<>c <>9; // 0x0
	public static Unity.Properties.TypeConverter<System.String,System.Guid> <>9__0_0; // 0x8
	public static Unity.Properties.TypeConverter<System.SByte,System.Char> <>9__1_0; // 0x10
	public static Unity.Properties.TypeConverter<System.SByte,System.Boolean> <>9__1_1; // 0x18
	public static Unity.Properties.TypeConverter<System.SByte,System.Int16> <>9__1_2; // 0x20
	public static Unity.Properties.TypeConverter<System.SByte,System.Int32> <>9__1_3; // 0x28
	public static Unity.Properties.TypeConverter<System.SByte,System.Int64> <>9__1_4; // 0x30
	public static Unity.Properties.TypeConverter<System.SByte,System.Byte> <>9__1_5; // 0x38
	public static Unity.Properties.TypeConverter<System.SByte,System.UInt16> <>9__1_6; // 0x40
	public static Unity.Properties.TypeConverter<System.SByte,System.UInt32> <>9__1_7; // 0x48
	public static Unity.Properties.TypeConverter<System.SByte,System.UInt64> <>9__1_8; // 0x50
	public static Unity.Properties.TypeConverter<System.SByte,System.Single> <>9__1_9; // 0x58
	public static Unity.Properties.TypeConverter<System.SByte,System.Double> <>9__1_10; // 0x60
	public static Unity.Properties.TypeConverter<System.SByte,System.Object> <>9__1_11; // 0x68
	public static Unity.Properties.TypeConverter<System.Int16,System.SByte> <>9__2_0; // 0x70
	public static Unity.Properties.TypeConverter<System.Int16,System.Char> <>9__2_1; // 0x78
	public static Unity.Properties.TypeConverter<System.Int16,System.Boolean> <>9__2_2; // 0x80
	public static Unity.Properties.TypeConverter<System.Int16,System.Int32> <>9__2_3; // 0x88
	public static Unity.Properties.TypeConverter<System.Int16,System.Int64> <>9__2_4; // 0x90
	public static Unity.Properties.TypeConverter<System.Int16,System.Byte> <>9__2_5; // 0x98
	public static Unity.Properties.TypeConverter<System.Int16,System.UInt16> <>9__2_6; // 0xA0
	public static Unity.Properties.TypeConverter<System.Int16,System.UInt32> <>9__2_7; // 0xA8
	public static Unity.Properties.TypeConverter<System.Int16,System.UInt64> <>9__2_8; // 0xB0
	public static Unity.Properties.TypeConverter<System.Int16,System.Single> <>9__2_9; // 0xB8
	public static Unity.Properties.TypeConverter<System.Int16,System.Double> <>9__2_10; // 0xC0
	public static Unity.Properties.TypeConverter<System.Int16,System.Object> <>9__2_11; // 0xC8
	public static Unity.Properties.TypeConverter<System.Int32,System.SByte> <>9__3_0; // 0xD0
	public static Unity.Properties.TypeConverter<System.Int32,System.Char> <>9__3_1; // 0xD8
	public static Unity.Properties.TypeConverter<System.Int32,System.Boolean> <>9__3_2; // 0xE0
	public static Unity.Properties.TypeConverter<System.Int32,System.Int16> <>9__3_3; // 0xE8
	public static Unity.Properties.TypeConverter<System.Int32,System.Int64> <>9__3_4; // 0xF0
	public static Unity.Properties.TypeConverter<System.Int32,System.Byte> <>9__3_5; // 0xF8
	public static Unity.Properties.TypeConverter<System.Int32,System.UInt16> <>9__3_6; // 0x100
	public static Unity.Properties.TypeConverter<System.Int32,System.UInt32> <>9__3_7; // 0x108
	public static Unity.Properties.TypeConverter<System.Int32,System.UInt64> <>9__3_8; // 0x110
	public static Unity.Properties.TypeConverter<System.Int32,System.Single> <>9__3_9; // 0x118
	public static Unity.Properties.TypeConverter<System.Int32,System.Double> <>9__3_10; // 0x120
	public static Unity.Properties.TypeConverter<System.Int32,System.Object> <>9__3_11; // 0x128
	public static Unity.Properties.TypeConverter<System.Int64,System.SByte> <>9__4_0; // 0x130
	public static Unity.Properties.TypeConverter<System.Int64,System.Char> <>9__4_1; // 0x138
	public static Unity.Properties.TypeConverter<System.Int64,System.Boolean> <>9__4_2; // 0x140
	public static Unity.Properties.TypeConverter<System.Int64,System.Int16> <>9__4_3; // 0x148
	public static Unity.Properties.TypeConverter<System.Int64,System.Int32> <>9__4_4; // 0x150
	public static Unity.Properties.TypeConverter<System.Int64,System.Byte> <>9__4_5; // 0x158
	public static Unity.Properties.TypeConverter<System.Int64,System.UInt16> <>9__4_6; // 0x160
	public static Unity.Properties.TypeConverter<System.Int64,System.UInt32> <>9__4_7; // 0x168
	public static Unity.Properties.TypeConverter<System.Int64,System.UInt64> <>9__4_8; // 0x170
	public static Unity.Properties.TypeConverter<System.Int64,System.Single> <>9__4_9; // 0x178
	public static Unity.Properties.TypeConverter<System.Int64,System.Double> <>9__4_10; // 0x180
	public static Unity.Properties.TypeConverter<System.Int64,System.Object> <>9__4_11; // 0x188
	public static Unity.Properties.TypeConverter<System.Byte,System.SByte> <>9__5_0; // 0x190
	public static Unity.Properties.TypeConverter<System.Byte,System.Char> <>9__5_1; // 0x198
	public static Unity.Properties.TypeConverter<System.Byte,System.Boolean> <>9__5_2; // 0x1A0
	public static Unity.Properties.TypeConverter<System.Byte,System.Int16> <>9__5_3; // 0x1A8
	public static Unity.Properties.TypeConverter<System.Byte,System.Int32> <>9__5_4; // 0x1B0
	public static Unity.Properties.TypeConverter<System.Byte,System.Int64> <>9__5_5; // 0x1B8
	public static Unity.Properties.TypeConverter<System.Byte,System.UInt16> <>9__5_6; // 0x1C0
	public static Unity.Properties.TypeConverter<System.Byte,System.UInt32> <>9__5_7; // 0x1C8
	public static Unity.Properties.TypeConverter<System.Byte,System.UInt64> <>9__5_8; // 0x1D0
	public static Unity.Properties.TypeConverter<System.Byte,System.Single> <>9__5_9; // 0x1D8
	public static Unity.Properties.TypeConverter<System.Byte,System.Double> <>9__5_10; // 0x1E0
	public static Unity.Properties.TypeConverter<System.Byte,System.Object> <>9__5_11; // 0x1E8
	public static Unity.Properties.TypeConverter<System.UInt16,System.SByte> <>9__6_0; // 0x1F0
	public static Unity.Properties.TypeConverter<System.UInt16,System.Char> <>9__6_1; // 0x1F8
	public static Unity.Properties.TypeConverter<System.UInt16,System.Boolean> <>9__6_2; // 0x200
	public static Unity.Properties.TypeConverter<System.UInt16,System.Int16> <>9__6_3; // 0x208
	public static Unity.Properties.TypeConverter<System.UInt16,System.Int32> <>9__6_4; // 0x210
	public static Unity.Properties.TypeConverter<System.UInt16,System.Int64> <>9__6_5; // 0x218
	public static Unity.Properties.TypeConverter<System.UInt16,System.Byte> <>9__6_6; // 0x220
	public static Unity.Properties.TypeConverter<System.UInt16,System.UInt32> <>9__6_7; // 0x228
	public static Unity.Properties.TypeConverter<System.UInt16,System.UInt64> <>9__6_8; // 0x230
	public static Unity.Properties.TypeConverter<System.UInt16,System.Single> <>9__6_9; // 0x238
	public static Unity.Properties.TypeConverter<System.UInt16,System.Double> <>9__6_10; // 0x240
	public static Unity.Properties.TypeConverter<System.UInt16,System.Object> <>9__6_11; // 0x248
	public static Unity.Properties.TypeConverter<System.UInt32,System.SByte> <>9__7_0; // 0x250
	public static Unity.Properties.TypeConverter<System.UInt32,System.Char> <>9__7_1; // 0x258
	public static Unity.Properties.TypeConverter<System.UInt32,System.Boolean> <>9__7_2; // 0x260
	public static Unity.Properties.TypeConverter<System.UInt32,System.Int16> <>9__7_3; // 0x268
	public static Unity.Properties.TypeConverter<System.UInt32,System.Int32> <>9__7_4; // 0x270
	public static Unity.Properties.TypeConverter<System.UInt32,System.Int64> <>9__7_5; // 0x278
	public static Unity.Properties.TypeConverter<System.UInt32,System.Byte> <>9__7_6; // 0x280
	public static Unity.Properties.TypeConverter<System.UInt32,System.UInt16> <>9__7_7; // 0x288
	public static Unity.Properties.TypeConverter<System.UInt32,System.UInt64> <>9__7_8; // 0x290
	public static Unity.Properties.TypeConverter<System.UInt32,System.Single> <>9__7_9; // 0x298
	public static Unity.Properties.TypeConverter<System.UInt32,System.Double> <>9__7_10; // 0x2A0
	public static Unity.Properties.TypeConverter<System.UInt32,System.Object> <>9__7_11; // 0x2A8
	public static Unity.Properties.TypeConverter<System.UInt64,System.SByte> <>9__8_0; // 0x2B0
	public static Unity.Properties.TypeConverter<System.UInt64,System.Char> <>9__8_1; // 0x2B8
	public static Unity.Properties.TypeConverter<System.UInt64,System.Boolean> <>9__8_2; // 0x2C0
	public static Unity.Properties.TypeConverter<System.UInt64,System.Int16> <>9__8_3; // 0x2C8
	public static Unity.Properties.TypeConverter<System.UInt64,System.Int32> <>9__8_4; // 0x2D0
	public static Unity.Properties.TypeConverter<System.UInt64,System.Int64> <>9__8_5; // 0x2D8
	public static Unity.Properties.TypeConverter<System.UInt64,System.Byte> <>9__8_6; // 0x2E0
	public static Unity.Properties.TypeConverter<System.UInt64,System.UInt16> <>9__8_7; // 0x2E8
	public static Unity.Properties.TypeConverter<System.UInt64,System.UInt32> <>9__8_8; // 0x2F0
	public static Unity.Properties.TypeConverter<System.UInt64,System.Single> <>9__8_9; // 0x2F8
	public static Unity.Properties.TypeConverter<System.UInt64,System.Double> <>9__8_10; // 0x300
	public static Unity.Properties.TypeConverter<System.UInt64,System.Object> <>9__8_11; // 0x308
	public static Unity.Properties.TypeConverter<System.Single,System.SByte> <>9__9_0; // 0x310
	public static Unity.Properties.TypeConverter<System.Single,System.Char> <>9__9_1; // 0x318
	public static Unity.Properties.TypeConverter<System.Single,System.Boolean> <>9__9_2; // 0x320
	public static Unity.Properties.TypeConverter<System.Single,System.Int16> <>9__9_3; // 0x328
	public static Unity.Properties.TypeConverter<System.Single,System.Int32> <>9__9_4; // 0x330
	public static Unity.Properties.TypeConverter<System.Single,System.Int64> <>9__9_5; // 0x338
	public static Unity.Properties.TypeConverter<System.Single,System.Byte> <>9__9_6; // 0x340
	public static Unity.Properties.TypeConverter<System.Single,System.UInt16> <>9__9_7; // 0x348
	public static Unity.Properties.TypeConverter<System.Single,System.UInt32> <>9__9_8; // 0x350
	public static Unity.Properties.TypeConverter<System.Single,System.UInt64> <>9__9_9; // 0x358
	public static Unity.Properties.TypeConverter<System.Single,System.Double> <>9__9_10; // 0x360
	public static Unity.Properties.TypeConverter<System.Single,System.Object> <>9__9_11; // 0x368
	public static Unity.Properties.TypeConverter<System.Double,System.SByte> <>9__10_0; // 0x370
	public static Unity.Properties.TypeConverter<System.Double,System.Char> <>9__10_1; // 0x378
	public static Unity.Properties.TypeConverter<System.Double,System.Boolean> <>9__10_2; // 0x380
	public static Unity.Properties.TypeConverter<System.Double,System.Int16> <>9__10_3; // 0x388
	public static Unity.Properties.TypeConverter<System.Double,System.Int32> <>9__10_4; // 0x390
	public static Unity.Properties.TypeConverter<System.Double,System.Int64> <>9__10_5; // 0x398
	public static Unity.Properties.TypeConverter<System.Double,System.Byte> <>9__10_6; // 0x3A0
	public static Unity.Properties.TypeConverter<System.Double,System.UInt16> <>9__10_7; // 0x3A8
	public static Unity.Properties.TypeConverter<System.Double,System.UInt32> <>9__10_8; // 0x3B0
	public static Unity.Properties.TypeConverter<System.Double,System.UInt64> <>9__10_9; // 0x3B8
	public static Unity.Properties.TypeConverter<System.Double,System.Single> <>9__10_10; // 0x3C0
	public static Unity.Properties.TypeConverter<System.Double,System.Object> <>9__10_11; // 0x3C8
	public static Unity.Properties.TypeConverter<System.Boolean,System.Char> <>9__11_0; // 0x3D0
	public static Unity.Properties.TypeConverter<System.Boolean,System.SByte> <>9__11_1; // 0x3D8
	public static Unity.Properties.TypeConverter<System.Boolean,System.Int16> <>9__11_2; // 0x3E0
	public static Unity.Properties.TypeConverter<System.Boolean,System.Int32> <>9__11_3; // 0x3E8
	public static Unity.Properties.TypeConverter<System.Boolean,System.Int64> <>9__11_4; // 0x3F0
	public static Unity.Properties.TypeConverter<System.Boolean,System.Byte> <>9__11_5; // 0x3F8
	public static Unity.Properties.TypeConverter<System.Boolean,System.UInt16> <>9__11_6; // 0x400
	public static Unity.Properties.TypeConverter<System.Boolean,System.UInt32> <>9__11_7; // 0x408
	public static Unity.Properties.TypeConverter<System.Boolean,System.UInt64> <>9__11_8; // 0x410
	public static Unity.Properties.TypeConverter<System.Boolean,System.Single> <>9__11_9; // 0x418
	public static Unity.Properties.TypeConverter<System.Boolean,System.Double> <>9__11_10; // 0x420
	public static Unity.Properties.TypeConverter<System.Boolean,System.Object> <>9__11_11; // 0x428
	public static Unity.Properties.TypeConverter<System.String,System.Char> <>9__12_0; // 0x430
	public static Unity.Properties.TypeConverter<System.Char,System.Boolean> <>9__12_1; // 0x438
	public static Unity.Properties.TypeConverter<System.Char,System.SByte> <>9__12_2; // 0x440
	public static Unity.Properties.TypeConverter<System.Char,System.Int16> <>9__12_3; // 0x448
	public static Unity.Properties.TypeConverter<System.Char,System.Int32> <>9__12_4; // 0x450
	public static Unity.Properties.TypeConverter<System.Char,System.Int64> <>9__12_5; // 0x458
	public static Unity.Properties.TypeConverter<System.Char,System.Byte> <>9__12_6; // 0x460
	public static Unity.Properties.TypeConverter<System.Char,System.UInt16> <>9__12_7; // 0x468
	public static Unity.Properties.TypeConverter<System.Char,System.UInt32> <>9__12_8; // 0x470
	public static Unity.Properties.TypeConverter<System.Char,System.UInt64> <>9__12_9; // 0x478
	public static Unity.Properties.TypeConverter<System.Char,System.Single> <>9__12_10; // 0x480
	public static Unity.Properties.TypeConverter<System.Char,System.Double> <>9__12_11; // 0x488
	public static Unity.Properties.TypeConverter<System.Char,System.Object> <>9__12_12; // 0x490
	public static Unity.Properties.TypeConverter<System.Char,System.String> <>9__12_13; // 0x498
	public static Unity.Properties.TypeConverter<System.String,System.Char> <>9__13_0; // 0x4A0
	public static Unity.Properties.TypeConverter<System.Char,System.String> <>9__13_1; // 0x4A8
	public static Unity.Properties.TypeConverter<System.String,System.Boolean> <>9__13_2; // 0x4B0
	public static Unity.Properties.TypeConverter<System.Boolean,System.String> <>9__13_3; // 0x4B8
	public static Unity.Properties.TypeConverter<System.String,System.SByte> <>9__13_4; // 0x4C0
	public static Unity.Properties.TypeConverter<System.SByte,System.String> <>9__13_5; // 0x4C8
	public static Unity.Properties.TypeConverter<System.String,System.Int16> <>9__13_6; // 0x4D0
	public static Unity.Properties.TypeConverter<System.Int16,System.String> <>9__13_7; // 0x4D8
	public static Unity.Properties.TypeConverter<System.String,System.Int32> <>9__13_8; // 0x4E0
	public static Unity.Properties.TypeConverter<System.Int32,System.String> <>9__13_9; // 0x4E8
	public static Unity.Properties.TypeConverter<System.String,System.Int64> <>9__13_10; // 0x4F0
	public static Unity.Properties.TypeConverter<System.Int64,System.String> <>9__13_11; // 0x4F8
	public static Unity.Properties.TypeConverter<System.String,System.Byte> <>9__13_12; // 0x500
	public static Unity.Properties.TypeConverter<System.Byte,System.String> <>9__13_13; // 0x508
	public static Unity.Properties.TypeConverter<System.String,System.UInt16> <>9__13_14; // 0x510
	public static Unity.Properties.TypeConverter<System.UInt16,System.String> <>9__13_15; // 0x518
	public static Unity.Properties.TypeConverter<System.String,System.UInt32> <>9__13_16; // 0x520
	public static Unity.Properties.TypeConverter<System.UInt32,System.String> <>9__13_17; // 0x528
	public static Unity.Properties.TypeConverter<System.String,System.UInt64> <>9__13_18; // 0x530
	public static Unity.Properties.TypeConverter<System.UInt64,System.String> <>9__13_19; // 0x538
	public static Unity.Properties.TypeConverter<System.String,System.Single> <>9__13_20; // 0x540
	public static Unity.Properties.TypeConverter<System.Single,System.String> <>9__13_21; // 0x548
	public static Unity.Properties.TypeConverter<System.String,System.Double> <>9__13_22; // 0x550
	public static Unity.Properties.TypeConverter<System.Double,System.String> <>9__13_23; // 0x558
	public static Unity.Properties.TypeConverter<System.Object,System.Char> <>9__14_0; // 0x560
	public static Unity.Properties.TypeConverter<System.Object,System.Boolean> <>9__14_1; // 0x568
	public static Unity.Properties.TypeConverter<System.Object,System.SByte> <>9__14_2; // 0x570
	public static Unity.Properties.TypeConverter<System.Object,System.Int16> <>9__14_3; // 0x578
	public static Unity.Properties.TypeConverter<System.Object,System.Int32> <>9__14_4; // 0x580
	public static Unity.Properties.TypeConverter<System.Object,System.Int64> <>9__14_5; // 0x588
	public static Unity.Properties.TypeConverter<System.Object,System.Byte> <>9__14_6; // 0x590
	public static Unity.Properties.TypeConverter<System.Object,System.UInt16> <>9__14_7; // 0x598
	public static Unity.Properties.TypeConverter<System.Object,System.UInt32> <>9__14_8; // 0x5A0
	public static Unity.Properties.TypeConverter<System.Object,System.UInt64> <>9__14_9; // 0x5A8
	public static Unity.Properties.TypeConverter<System.Object,System.Single> <>9__14_10; // 0x5B0
	public static Unity.Properties.TypeConverter<System.Object,System.Double> <>9__14_11; // 0x5B8

	// Methods

	// RVA: 0x1742CDC
	private static void .cctor() { }

	// RVA: 0x1742D48
	public void .ctor() { }

	// RVA: 0x1742D50
	internal Guid <Register>b__0_0(string g) { }

	// RVA: 0x1742D80
	internal Char <RegisterInt8Converters>b__1_0(SByte v) { }

	// RVA: 0x1742D8C
	internal bool <RegisterInt8Converters>b__1_1(SByte v) { }

	// RVA: 0x1742D9C
	internal Int16 <RegisterInt8Converters>b__1_2(SByte v) { }

	// RVA: 0x1742DA4
	internal int <RegisterInt8Converters>b__1_3(SByte v) { }

	// RVA: 0x1742DAC
	internal Int64 <RegisterInt8Converters>b__1_4(SByte v) { }

	// RVA: 0x1742DB4
	internal Byte <RegisterInt8Converters>b__1_5(SByte v) { }

	// RVA: 0x1742DBC
	internal UInt16 <RegisterInt8Converters>b__1_6(SByte v) { }

	// RVA: 0x1742DC8
	internal UInt32 <RegisterInt8Converters>b__1_7(SByte v) { }

	// RVA: 0x1742DD0
	internal UInt64 <RegisterInt8Converters>b__1_8(SByte v) { }

	// RVA: 0x1742DD8
	internal float <RegisterInt8Converters>b__1_9(SByte v) { }

	// RVA: 0x1742DEC
	internal Double <RegisterInt8Converters>b__1_10(SByte v) { }

	// RVA: 0x1742DF8
	internal object <RegisterInt8Converters>b__1_11(SByte v) { }

	// RVA: 0x1742E2C
	internal SByte <RegisterInt16Converters>b__2_0(Int16 v) { }

	// RVA: 0x1742E34
	internal Char <RegisterInt16Converters>b__2_1(Int16 v) { }

	// RVA: 0x1742E3C
	internal bool <RegisterInt16Converters>b__2_2(Int16 v) { }

	// RVA: 0x1742E4C
	internal int <RegisterInt16Converters>b__2_3(Int16 v) { }

	// RVA: 0x1742E54
	internal Int64 <RegisterInt16Converters>b__2_4(Int16 v) { }

	// RVA: 0x1742E5C
	internal Byte <RegisterInt16Converters>b__2_5(Int16 v) { }

	// RVA: 0x1742E64
	internal UInt16 <RegisterInt16Converters>b__2_6(Int16 v) { }

	// RVA: 0x1742E6C
	internal UInt32 <RegisterInt16Converters>b__2_7(Int16 v) { }

	// RVA: 0x1742E74
	internal UInt64 <RegisterInt16Converters>b__2_8(Int16 v) { }

	// RVA: 0x1742E7C
	internal float <RegisterInt16Converters>b__2_9(Int16 v) { }

	// RVA: 0x1742E8C
	internal Double <RegisterInt16Converters>b__2_10(Int16 v) { }

	// RVA: 0x1742EA0
	internal object <RegisterInt16Converters>b__2_11(Int16 v) { }

	// RVA: 0x1742ED4
	internal SByte <RegisterInt32Converters>b__3_0(int v) { }

	// RVA: 0x1742EDC
	internal Char <RegisterInt32Converters>b__3_1(int v) { }

	// RVA: 0x1742EE4
	internal bool <RegisterInt32Converters>b__3_2(int v) { }

	// RVA: 0x1742EF4
	internal Int16 <RegisterInt32Converters>b__3_3(int v) { }

	// RVA: 0x1742EFC
	internal Int64 <RegisterInt32Converters>b__3_4(int v) { }

	// RVA: 0x1742F04
	internal Byte <RegisterInt32Converters>b__3_5(int v) { }

	// RVA: 0x1742F0C
	internal UInt16 <RegisterInt32Converters>b__3_6(int v) { }

	// RVA: 0x1742F14
	internal UInt32 <RegisterInt32Converters>b__3_7(int v) { }

	// RVA: 0x1742F1C
	internal UInt64 <RegisterInt32Converters>b__3_8(int v) { }

	// RVA: 0x1742F24
	internal float <RegisterInt32Converters>b__3_9(int v) { }

	// RVA: 0x1742F30
	internal Double <RegisterInt32Converters>b__3_10(int v) { }

	// RVA: 0x1742F40
	internal object <RegisterInt32Converters>b__3_11(int v) { }

	// RVA: 0x1742F74
	internal SByte <RegisterInt64Converters>b__4_0(Int64 v) { }

	// RVA: 0x1742F7C
	internal Char <RegisterInt64Converters>b__4_1(Int64 v) { }

	// RVA: 0x1742F84
	internal bool <RegisterInt64Converters>b__4_2(Int64 v) { }

	// RVA: 0x1742F94
	internal Int16 <RegisterInt64Converters>b__4_3(Int64 v) { }

	// RVA: 0x1742F9C
	internal int <RegisterInt64Converters>b__4_4(Int64 v) { }

	// RVA: 0x1742FA4
	internal Byte <RegisterInt64Converters>b__4_5(Int64 v) { }

	// RVA: 0x1742FAC
	internal UInt16 <RegisterInt64Converters>b__4_6(Int64 v) { }

	// RVA: 0x1742FB4
	internal UInt32 <RegisterInt64Converters>b__4_7(Int64 v) { }

	// RVA: 0x1742FBC
	internal UInt64 <RegisterInt64Converters>b__4_8(Int64 v) { }

	// RVA: 0x1742FC4
	internal float <RegisterInt64Converters>b__4_9(Int64 v) { }

	// RVA: 0x1742FD0
	internal Double <RegisterInt64Converters>b__4_10(Int64 v) { }

	// RVA: 0x1742FDC
	internal object <RegisterInt64Converters>b__4_11(Int64 v) { }

	// RVA: 0x1743010
	internal SByte <RegisterUInt8Converters>b__5_0(Byte v) { }

	// RVA: 0x1743018
	internal Char <RegisterUInt8Converters>b__5_1(Byte v) { }

	// RVA: 0x1743020
	internal bool <RegisterUInt8Converters>b__5_2(Byte v) { }

	// RVA: 0x1743030
	internal Int16 <RegisterUInt8Converters>b__5_3(Byte v) { }

	// RVA: 0x1743038
	internal int <RegisterUInt8Converters>b__5_4(Byte v) { }

	// RVA: 0x1743040
	internal Int64 <RegisterUInt8Converters>b__5_5(Byte v) { }

	// RVA: 0x1743048
	internal UInt16 <RegisterUInt8Converters>b__5_6(Byte v) { }

	// RVA: 0x1743050
	internal UInt32 <RegisterUInt8Converters>b__5_7(Byte v) { }

	// RVA: 0x1743058
	internal UInt64 <RegisterUInt8Converters>b__5_8(Byte v) { }

	// RVA: 0x1743060
	internal float <RegisterUInt8Converters>b__5_9(Byte v) { }

	// RVA: 0x174306C
	internal Double <RegisterUInt8Converters>b__5_10(Byte v) { }

	// RVA: 0x1743078
	internal object <RegisterUInt8Converters>b__5_11(Byte v) { }

	// RVA: 0x17430AC
	internal SByte <RegisterUInt16Converters>b__6_0(UInt16 v) { }

	// RVA: 0x17430B4
	internal Char <RegisterUInt16Converters>b__6_1(UInt16 v) { }

	// RVA: 0x17430BC
	internal bool <RegisterUInt16Converters>b__6_2(UInt16 v) { }

	// RVA: 0x17430CC
	internal Int16 <RegisterUInt16Converters>b__6_3(UInt16 v) { }

	// RVA: 0x17430D4
	internal int <RegisterUInt16Converters>b__6_4(UInt16 v) { }

	// RVA: 0x17430DC
	internal Int64 <RegisterUInt16Converters>b__6_5(UInt16 v) { }

	// RVA: 0x17430E4
	internal Byte <RegisterUInt16Converters>b__6_6(UInt16 v) { }

	// RVA: 0x17430EC
	internal UInt32 <RegisterUInt16Converters>b__6_7(UInt16 v) { }

	// RVA: 0x17430F4
	internal UInt64 <RegisterUInt16Converters>b__6_8(UInt16 v) { }

	// RVA: 0x17430FC
	internal float <RegisterUInt16Converters>b__6_9(UInt16 v) { }

	// RVA: 0x1743108
	internal Double <RegisterUInt16Converters>b__6_10(UInt16 v) { }

	// RVA: 0x1743114
	internal object <RegisterUInt16Converters>b__6_11(UInt16 v) { }

	// RVA: 0x1743148
	internal SByte <RegisterUInt32Converters>b__7_0(UInt32 v) { }

	// RVA: 0x1743150
	internal Char <RegisterUInt32Converters>b__7_1(UInt32 v) { }

	// RVA: 0x1743158
	internal bool <RegisterUInt32Converters>b__7_2(UInt32 v) { }

	// RVA: 0x1743168
	internal Int16 <RegisterUInt32Converters>b__7_3(UInt32 v) { }

	// RVA: 0x1743170
	internal int <RegisterUInt32Converters>b__7_4(UInt32 v) { }

	// RVA: 0x1743178
	internal Int64 <RegisterUInt32Converters>b__7_5(UInt32 v) { }

	// RVA: 0x1743180
	internal Byte <RegisterUInt32Converters>b__7_6(UInt32 v) { }

	// RVA: 0x1743188
	internal UInt16 <RegisterUInt32Converters>b__7_7(UInt32 v) { }

	// RVA: 0x1743190
	internal UInt64 <RegisterUInt32Converters>b__7_8(UInt32 v) { }

	// RVA: 0x1743198
	internal float <RegisterUInt32Converters>b__7_9(UInt32 v) { }

	// RVA: 0x17431A4
	internal Double <RegisterUInt32Converters>b__7_10(UInt32 v) { }

	// RVA: 0x17431B0
	internal object <RegisterUInt32Converters>b__7_11(UInt32 v) { }

	// RVA: 0x17431E4
	internal SByte <RegisterUInt64Converters>b__8_0(UInt64 v) { }

	// RVA: 0x17431EC
	internal Char <RegisterUInt64Converters>b__8_1(UInt64 v) { }

	// RVA: 0x17431F4
	internal bool <RegisterUInt64Converters>b__8_2(UInt64 v) { }

	// RVA: 0x1743204
	internal Int16 <RegisterUInt64Converters>b__8_3(UInt64 v) { }

	// RVA: 0x174320C
	internal int <RegisterUInt64Converters>b__8_4(UInt64 v) { }

	// RVA: 0x1743214
	internal Int64 <RegisterUInt64Converters>b__8_5(UInt64 v) { }

	// RVA: 0x174321C
	internal Byte <RegisterUInt64Converters>b__8_6(UInt64 v) { }

	// RVA: 0x1743224
	internal UInt16 <RegisterUInt64Converters>b__8_7(UInt64 v) { }

	// RVA: 0x174322C
	internal UInt32 <RegisterUInt64Converters>b__8_8(UInt64 v) { }

	// RVA: 0x1743234
	internal float <RegisterUInt64Converters>b__8_9(UInt64 v) { }

	// RVA: 0x1743244
	internal Double <RegisterUInt64Converters>b__8_10(UInt64 v) { }

	// RVA: 0x1743250
	internal object <RegisterUInt64Converters>b__8_11(UInt64 v) { }

	// RVA: 0x1743284
	internal SByte <RegisterFloat32Converters>b__9_0(float v) { }

	// RVA: 0x17432A0
	internal Char <RegisterFloat32Converters>b__9_1(float v) { }

	// RVA: 0x17432B8
	internal bool <RegisterFloat32Converters>b__9_2(float v) { }

	// RVA: 0x1743334
	internal Int16 <RegisterFloat32Converters>b__9_3(float v) { }

	// RVA: 0x1743350
	internal int <RegisterFloat32Converters>b__9_4(float v) { }

	// RVA: 0x1743370
	internal Int64 <RegisterFloat32Converters>b__9_5(float v) { }

	// RVA: 0x1743390
	internal Byte <RegisterFloat32Converters>b__9_6(float v) { }

	// RVA: 0x17433A8
	internal UInt16 <RegisterFloat32Converters>b__9_7(float v) { }

	// RVA: 0x17433C0
	internal UInt32 <RegisterFloat32Converters>b__9_8(float v) { }

	// RVA: 0x17433D8
	internal UInt64 <RegisterFloat32Converters>b__9_9(float v) { }

	// RVA: 0x17433F0
	internal Double <RegisterFloat32Converters>b__9_10(float v) { }

	// RVA: 0x17433FC
	internal object <RegisterFloat32Converters>b__9_11(float v) { }

	// RVA: 0x1743430
	internal SByte <RegisterFloat64Converters>b__10_0(Double v) { }

	// RVA: 0x174344C
	internal Char <RegisterFloat64Converters>b__10_1(Double v) { }

	// RVA: 0x1743464
	internal bool <RegisterFloat64Converters>b__10_2(Double v) { }

	// RVA: 0x17434E0
	internal Int16 <RegisterFloat64Converters>b__10_3(Double v) { }

	// RVA: 0x17434FC
	internal int <RegisterFloat64Converters>b__10_4(Double v) { }

	// RVA: 0x174351C
	internal Int64 <RegisterFloat64Converters>b__10_5(Double v) { }

	// RVA: 0x174353C
	internal Byte <RegisterFloat64Converters>b__10_6(Double v) { }

	// RVA: 0x1743554
	internal UInt16 <RegisterFloat64Converters>b__10_7(Double v) { }

	// RVA: 0x174356C
	internal UInt32 <RegisterFloat64Converters>b__10_8(Double v) { }

	// RVA: 0x1743584
	internal UInt64 <RegisterFloat64Converters>b__10_9(Double v) { }

	// RVA: 0x174359C
	internal float <RegisterFloat64Converters>b__10_10(Double v) { }

	// RVA: 0x17435A8
	internal object <RegisterFloat64Converters>b__10_11(Double v) { }

	// RVA: 0x17435DC
	internal Char <RegisterBooleanConverters>b__11_0(bool v) { }

	// RVA: 0x17435EC
	internal SByte <RegisterBooleanConverters>b__11_1(bool v) { }

	// RVA: 0x17435FC
	internal Int16 <RegisterBooleanConverters>b__11_2(bool v) { }

	// RVA: 0x174360C
	internal int <RegisterBooleanConverters>b__11_3(bool v) { }

	// RVA: 0x174361C
	internal Int64 <RegisterBooleanConverters>b__11_4(bool v) { }

	// RVA: 0x174362C
	internal Byte <RegisterBooleanConverters>b__11_5(bool v) { }

	// RVA: 0x174363C
	internal UInt16 <RegisterBooleanConverters>b__11_6(bool v) { }

	// RVA: 0x174364C
	internal UInt32 <RegisterBooleanConverters>b__11_7(bool v) { }

	// RVA: 0x174365C
	internal UInt64 <RegisterBooleanConverters>b__11_8(bool v) { }

	// RVA: 0x174366C
	internal float <RegisterBooleanConverters>b__11_9(bool v) { }

	// RVA: 0x1743684
	internal Double <RegisterBooleanConverters>b__11_10(bool v) { }

	// RVA: 0x174369C
	internal object <RegisterBooleanConverters>b__11_11(bool v) { }

	// RVA: 0x17436D8
	internal Char <RegisterCharConverters>b__12_0(string v) { }

	// RVA: 0x1743758
	internal bool <RegisterCharConverters>b__12_1(Char v) { }

	// RVA: 0x1743768
	internal SByte <RegisterCharConverters>b__12_2(Char v) { }

	// RVA: 0x1743770
	internal Int16 <RegisterCharConverters>b__12_3(Char v) { }

	// RVA: 0x1743778
	internal int <RegisterCharConverters>b__12_4(Char v) { }

	// RVA: 0x1743780
	internal Int64 <RegisterCharConverters>b__12_5(Char v) { }

	// RVA: 0x1743788
	internal Byte <RegisterCharConverters>b__12_6(Char v) { }

	// RVA: 0x1743790
	internal UInt16 <RegisterCharConverters>b__12_7(Char v) { }

	// RVA: 0x1743798
	internal UInt32 <RegisterCharConverters>b__12_8(Char v) { }

	// RVA: 0x17437A0
	internal UInt64 <RegisterCharConverters>b__12_9(Char v) { }

	// RVA: 0x17437A8
	internal float <RegisterCharConverters>b__12_10(Char v) { }

	// RVA: 0x17437B4
	internal Double <RegisterCharConverters>b__12_11(Char v) { }

	// RVA: 0x17437C0
	internal object <RegisterCharConverters>b__12_12(Char v) { }

	// RVA: 0x17437F4
	internal string <RegisterCharConverters>b__12_13(Char v) { }

	// RVA: 0x1743844
	internal Char <RegisterStringConverters>b__13_0(string v) { }

	// RVA: 0x1743894
	internal string <RegisterStringConverters>b__13_1(Char v) { }

	// RVA: 0x17438E4
	internal bool <RegisterStringConverters>b__13_2(string v) { }

	// RVA: 0x17439D8
	internal string <RegisterStringConverters>b__13_3(bool v) { }

	// RVA: 0x1743A28
	internal SByte <RegisterStringConverters>b__13_4(string v) { }

	// RVA: 0x1743B10
	internal string <RegisterStringConverters>b__13_5(SByte v) { }

	// RVA: 0x1743B1C
	internal Int16 <RegisterStringConverters>b__13_6(string v) { }

	// RVA: 0x1743C04
	internal string <RegisterStringConverters>b__13_7(Int16 v) { }

	// RVA: 0x1743C10
	internal int <RegisterStringConverters>b__13_8(string v) { }

	// RVA: 0x1743CD8
	internal string <RegisterStringConverters>b__13_9(int v) { }

	// RVA: 0x1743CE4
	internal Int64 <RegisterStringConverters>b__13_10(string v) { }

	// RVA: 0x1743DB0
	internal string <RegisterStringConverters>b__13_11(Int64 v) { }

	// RVA: 0x1743DBC
	internal Byte <RegisterStringConverters>b__13_12(string v) { }

	// RVA: 0x1743E84
	internal string <RegisterStringConverters>b__13_13(Byte v) { }

	// RVA: 0x1743E90
	internal UInt16 <RegisterStringConverters>b__13_14(string v) { }

	// RVA: 0x1743F58
	internal string <RegisterStringConverters>b__13_15(UInt16 v) { }

	// RVA: 0x1743F64
	internal UInt32 <RegisterStringConverters>b__13_16(string v) { }

	// RVA: 0x174402C
	internal string <RegisterStringConverters>b__13_17(UInt32 v) { }

	// RVA: 0x1744038
	internal UInt64 <RegisterStringConverters>b__13_18(string v) { }

	// RVA: 0x1744104
	internal string <RegisterStringConverters>b__13_19(UInt64 v) { }

	// RVA: 0x1744110
	internal float <RegisterStringConverters>b__13_20(string v) { }

	// RVA: 0x17441DC
	internal string <RegisterStringConverters>b__13_21(float v) { }

	// RVA: 0x174424C
	internal Double <RegisterStringConverters>b__13_22(string v) { }

	// RVA: 0x174427C
	internal string <RegisterStringConverters>b__13_23(Double v) { }

	// RVA: 0x17442EC
	internal Char <RegisterObjectConverters>b__14_0(object v) { }

	// RVA: 0x1744330
	internal bool <RegisterObjectConverters>b__14_1(object v) { }

	// RVA: 0x174437C
	internal SByte <RegisterObjectConverters>b__14_2(object v) { }

	// RVA: 0x17443C8
	internal Int16 <RegisterObjectConverters>b__14_3(object v) { }

	// RVA: 0x1744414
	internal int <RegisterObjectConverters>b__14_4(object v) { }

	// RVA: 0x1744458
	internal Int64 <RegisterObjectConverters>b__14_5(object v) { }

	// RVA: 0x174449C
	internal Byte <RegisterObjectConverters>b__14_6(object v) { }

	// RVA: 0x17444E0
	internal UInt16 <RegisterObjectConverters>b__14_7(object v) { }

	// RVA: 0x1744524
	internal UInt32 <RegisterObjectConverters>b__14_8(object v) { }

	// RVA: 0x1744568
	internal UInt64 <RegisterObjectConverters>b__14_9(object v) { }

	// RVA: 0x17445AC
	internal float <RegisterObjectConverters>b__14_10(object v) { }

	// RVA: 0x17445F0
	internal Double <RegisterObjectConverters>b__14_11(object v) { }

}

// Namespace: 
private static class PrimitiveConverters
{
	// Methods

	// RVA: 0x1733CB4
	public static void Register() { }

	// RVA: 0x1733EE4
	private static void RegisterInt8Converters() { }

	// RVA: 0x1734E74
	private static void RegisterInt16Converters() { }

	// RVA: 0x1735E04
	private static void RegisterInt32Converters() { }

	// RVA: 0x1736DAC
	private static void RegisterInt64Converters() { }

	// RVA: 0x1737D6C
	private static void RegisterUInt8Converters() { }

	// RVA: 0x1738D2C
	private static void RegisterUInt16Converters() { }

	// RVA: 0x1739CEC
	private static void RegisterUInt32Converters() { }

	// RVA: 0x173ACAC
	private static void RegisterUInt64Converters() { }

	// RVA: 0x173BC6C
	private static void RegisterFloat32Converters() { }

	// RVA: 0x173CC2C
	private static void RegisterFloat64Converters() { }

	// RVA: 0x173DBEC
	private static void RegisterBooleanConverters() { }

	// RVA: 0x173EBAC
	private static void RegisterCharConverters() { }

	// RVA: 0x173FDFC
	private static void RegisterStringConverters() { }

	// RVA: 0x1741D1C
	private static void RegisterObjectConverters() { }

}

// Namespace: Unity.Properties
public static class TypeConversion
{
	// Fields
	private static readonly ConversionRegistry s_GlobalConverters; // 0x0

	// Methods

	// RVA: 0x1733C30
	private static void .cctor() { }

	// RVA: 0x352BD5C
	public static void Register(Unity.Properties.TypeConverter<TSource,TDestination> converter) { }

	// RVA: 0x26AD93C
	public static TDestination Convert(TSource value) { }

	// RVA: 0x3527C54
	public static bool TryConvert(TSource source, TDestination destination) { }

	// RVA: 0x26AD93C
	private static bool TryConvertToUnityEngineObject(TSource source, TDestination destination) { }

	// RVA: 0x1733E98
	private static bool IsNumericType(Type t) { }

}

// Namespace: Unity.Properties
public static class TypeTraits
{
	// Methods

	// RVA: 0x1744634
	public static bool IsContainer(Type type) { }

}

// Namespace: Unity.Properties
public static class TypeTraits<T0>
{
	// Fields
	private static readonly bool <IsValueType>k__BackingField; // 0x0
	private static readonly bool <IsPrimitive>k__BackingField; // 0x0
	private static readonly bool <IsInterface>k__BackingField; // 0x0
	private static readonly bool <IsAbstract>k__BackingField; // 0x0
	private static readonly bool <IsArray>k__BackingField; // 0x0
	private static readonly bool <IsMultidimensionalArray>k__BackingField; // 0x0
	private static readonly bool <IsEnum>k__BackingField; // 0x0
	private static readonly bool <IsEnumFlags>k__BackingField; // 0x0
	private static readonly bool <IsNullable>k__BackingField; // 0x0
	private static readonly bool <IsObject>k__BackingField; // 0x0
	private static readonly bool <IsString>k__BackingField; // 0x0
	private static readonly bool <IsContainer>k__BackingField; // 0x0
	private static readonly bool <CanBeNull>k__BackingField; // 0x0
	private static readonly bool <IsPrimitiveOrString>k__BackingField; // 0x0
	private static readonly bool <IsAbstractOrInterface>k__BackingField; // 0x0
	private static readonly bool <IsUnityObject>k__BackingField; // 0x0
	private static readonly bool <IsLazyLoadReference>k__BackingField; // 0x0

	// Methods

	// RVA: -1
	public static bool get_IsValueType() { }

	// RVA: -1
	public static bool get_IsPrimitive() { }

	// RVA: -1
	public static bool get_IsInterface() { }

	// RVA: -1
	public static bool get_IsAbstract() { }

	// RVA: -1
	public static bool get_IsArray() { }

	// RVA: -1
	public static bool get_IsEnum() { }

	// RVA: -1
	public static bool get_IsNullable() { }

	// RVA: -1
	public static bool get_IsObject() { }

	// RVA: -1
	public static bool get_IsString() { }

	// RVA: -1
	public static bool get_IsContainer() { }

	// RVA: -1
	public static bool get_CanBeNull() { }

	// RVA: -1
	public static bool get_IsAbstractOrInterface() { }

	// RVA: -1
	public static bool get_IsUnityObject() { }

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: Unity.Properties
public enum InstantiationKind
{
	// Fields
	public int value__; // 0x10
	public const InstantiationKind Activator = 0;
	public const InstantiationKind PropertyBagOverride = 1;
	public const InstantiationKind NotInstantiatable = 2;
}

// Namespace: Unity.Properties
internal interface IConstructor
{
	// Methods

	// RVA: -1
	public abstract InstantiationKind get_InstantiationKind() { }

}

// Namespace: Unity.Properties
internal interface IConstructor<T0>
{
	// Methods

	// RVA: -1
	public abstract T Instantiate() { }

}

// Namespace: Unity.Properties
internal interface IConstructorWithCount<T0>
{
	// Methods

	// RVA: -1
	public abstract T InstantiateWithCount(int count) { }

}

// Namespace: 
private interface ITypeConstructor
{
	// Methods

	// RVA: -1
	public abstract bool get_CanBeInstantiated() { }

	// RVA: -1
	public abstract object Instantiate() { }

}

// Namespace: 
private interface ITypeConstructor<T0>
{
	// Methods

	// RVA: -1
	public abstract T Instantiate() { }

	// RVA: -1
	public abstract void SetExplicitConstructor(System.Func<T> constructor) { }

}

// Namespace: 
private class TypeConstructor<T0>
{
	// Fields
	private System.Func<T> m_ExplicitConstructor; // 0x0
	private System.Func<T> m_ImplicitConstructor; // 0x0
	private Unity.Properties.IConstructor<T> m_OverrideConstructor; // 0x0

	// Methods

	// RVA: 0x35251DC
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35263A0
	private void SetImplicitConstructor() { }

	// RVA: 0x26AD93C
	private static T CreateValueTypeInstance() { }

	// RVA: 0x26AD93C
	private static T CreateScriptableObjectInstance() { }

	// RVA: 0x26AD93C
	private static T CreateClassInstance() { }

	// RVA: 0x35267E8
	public void SetExplicitConstructor(System.Func<T> constructor) { }

	// RVA: 0x26AD93C
	private T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }

	// RVA: 0x3525804
	private object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }

}

// Namespace: 
private class NonConstructable
{
	// Methods

	// RVA: 0x1745E3C
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x1745E44
	public object Instantiate() { }

	// RVA: 0x1745984
	public void .ctor() { }

}

// Namespace: 
private struct Cache<T0>
{
	// Fields
	public static Unity.Properties.TypeUtility.ITypeConstructor<T> TypeConstructor; // 0x0
}

// Namespace: 
private class TypeConstructorVisitor
{
	// Fields
	public ITypeConstructor TypeConstructor; // 0x10

	// Methods

	// RVA: 0x35263A0
	public void Visit() { }

	// RVA: 0x174597C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.TypeUtility.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1745E98
	private static void .cctor() { }

	// RVA: 0x1745F04
	public void .ctor() { }

	// RVA: 0x1745F0C
	internal StringBuilder <.cctor>b__11_0() { }

	// RVA: 0x1745F64
	internal void <.cctor>b__11_1(StringBuilder sb) { }

	// RVA: 0x1745F80
	internal string <.cctor>b__11_2() { }

}

// Namespace: Unity.Properties
public static class TypeUtility
{
	// Fields
	private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,Unity.Properties.TypeUtility.ITypeConstructor> s_TypeConstructors; // 0x0
	private static readonly MethodInfo s_CreateTypeConstructor; // 0x8
	private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.String> s_CachedResolvedName; // 0x10
	private static readonly UnityEngine.Pool.ObjectPool<System.Text.StringBuilder> s_Builders; // 0x18
	private static readonly object syncedPoolObject; // 0x20

	// Methods

	// RVA: 0x1744780
	private static void .cctor() { }

	// RVA: 0x1744BB0
	public static string GetTypeDisplayName(Type type) { }

	// RVA: 0x1744CF0
	private static string GetTypeDisplayName(Type type, System.Collections.Generic.IReadOnlyList<System.Type> args, int argIndex) { }

	// RVA: 0x17455BC
	public static Type GetRootType(Type type) { }

	// RVA: 0x17456AC
	private static ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: 0x35293B4
	private static Unity.Properties.TypeUtility.ITypeConstructor<T> CreateTypeConstructor() { }

	// RVA: 0x174598C
	private static ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: 0x35293B4
	private static Unity.Properties.TypeUtility.ITypeConstructor<T> GetTypeConstructor() { }

	// RVA: 0x1745A7C
	public static bool CanBeInstantiated(Type type) { }

	// RVA: -1
	public static bool CanBeInstantiated() { }

	// RVA: 0x352BD5C
	public static void SetExplicitInstantiationMethod(System.Func<T> constructor) { }

	// RVA: 0x26AD93C
	public static T Instantiate() { }

	// RVA: 0x35279B0
	public static bool TryInstantiate(T instance) { }

	// RVA: 0x26AD93C
	public static T Instantiate(Type derivedType) { }

	// RVA: 0x3527C54
	public static bool TryInstantiate(Type derivedType, T value) { }

	// RVA: 0x26AD93C
	public static TArray InstantiateArray(int count) { }

	// RVA: -1
	public static bool TryInstantiateArray(int count, TArray instance) { }

	// RVA: 0x26AD93C
	public static TArray InstantiateArray(Type derivedType, int count) { }

	// RVA: 0x1745B80
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: 0x352BD5C
	private static void CheckCanBeInstantiated(Unity.Properties.TypeUtility.ITypeConstructor<T> constructor) { }

	// RVA: 0x1745CF4
	private static void CheckCanBeInstantiated(ITypeConstructor constructor, Type type) { }

}

// Namespace: Unity.Properties.Internal
internal interface IAttributes
{
	// Methods

	// RVA: -1
	public abstract System.Collections.Generic.List<System.Attribute> get_Attributes() { }

	// RVA: -1
	public abstract void set_Attributes(System.Collections.Generic.List<System.Attribute> value) { }

	// RVA: -1
	public abstract void AddAttribute(Attribute attribute) { }

	// RVA: -1
	public abstract void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

	// RVA: -1
	public abstract AttributesScope CreateAttributesScope(IAttributes attributes) { }

}

// Namespace: Unity.Properties.Internal
internal static class PropertiesInitialization
{
	// Methods

	// RVA: 0x1745F98
	public static void InitializeProperties() { }

}

// Namespace: 
private class RProperty
{
	// Methods

	// RVA: 0x17477A4
	public override string get_Name() { }

	// RVA: 0x17477E8
	public override bool get_IsReadOnly() { }

	// RVA: 0x17477F0
	public override float GetValue(Color container) { }

	// RVA: 0x17477F8
	public override void SetValue(Color container, float value) { }

	// RVA: 0x1747654
	public void .ctor() { }

}

// Namespace: 
private class GProperty
{
	// Methods

	// RVA: 0x1747800
	public override string get_Name() { }

	// RVA: 0x1747844
	public override bool get_IsReadOnly() { }

	// RVA: 0x174784C
	public override float GetValue(Color container) { }

	// RVA: 0x1747854
	public override void SetValue(Color container, float value) { }

	// RVA: 0x17476A8
	public void .ctor() { }

}

// Namespace: 
private class BProperty
{
	// Methods

	// RVA: 0x174785C
	public override string get_Name() { }

	// RVA: 0x17478A0
	public override bool get_IsReadOnly() { }

	// RVA: 0x17478A8
	public override float GetValue(Color container) { }

	// RVA: 0x17478B0
	public override void SetValue(Color container, float value) { }

	// RVA: 0x17476FC
	public void .ctor() { }

}

// Namespace: 
private class AProperty
{
	// Methods

	// RVA: 0x17478B8
	public override string get_Name() { }

	// RVA: 0x17478FC
	public override bool get_IsReadOnly() { }

	// RVA: 0x1747904
	public override float GetValue(Color container) { }

	// RVA: 0x174790C
	public override void SetValue(Color container, float value) { }

	// RVA: 0x1747750
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class ColorPropertyBag
{
	// Methods

	// RVA: 0x1746408
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x17479BC
	public override string get_Name() { }

	// RVA: 0x1747A00
	public override bool get_IsReadOnly() { }

	// RVA: 0x1747A08
	public override float GetValue(Vector2 container) { }

	// RVA: 0x1747A10
	public override void SetValue(Vector2 container, float value) { }

	// RVA: 0x1747914
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1747A18
	public override string get_Name() { }

	// RVA: 0x1747A5C
	public override bool get_IsReadOnly() { }

	// RVA: 0x1747A64
	public override float GetValue(Vector2 container) { }

	// RVA: 0x1747A6C
	public override void SetValue(Vector2 container, float value) { }

	// RVA: 0x1747968
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector2PropertyBag
{
	// Methods

	// RVA: 0x1746614
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1747B70
	public override string get_Name() { }

	// RVA: 0x1747BB4
	public override bool get_IsReadOnly() { }

	// RVA: 0x1747BBC
	public override float GetValue(Vector3 container) { }

	// RVA: 0x1747BC4
	public override void SetValue(Vector3 container, float value) { }

	// RVA: 0x1747A74
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1747BCC
	public override string get_Name() { }

	// RVA: 0x1747C10
	public override bool get_IsReadOnly() { }

	// RVA: 0x1747C18
	public override float GetValue(Vector3 container) { }

	// RVA: 0x1747C20
	public override void SetValue(Vector3 container, float value) { }

	// RVA: 0x1747AC8
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x1747C28
	public override string get_Name() { }

	// RVA: 0x1747C6C
	public override bool get_IsReadOnly() { }

	// RVA: 0x1747C74
	public override float GetValue(Vector3 container) { }

	// RVA: 0x1747C7C
	public override void SetValue(Vector3 container, float value) { }

	// RVA: 0x1747B1C
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector3PropertyBag
{
	// Methods

	// RVA: 0x1746768
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1747DD4
	public override string get_Name() { }

	// RVA: 0x1747E18
	public override bool get_IsReadOnly() { }

	// RVA: 0x1747E20
	public override float GetValue(Vector4 container) { }

	// RVA: 0x1747E28
	public override void SetValue(Vector4 container, float value) { }

	// RVA: 0x1747C84
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1747E30
	public override string get_Name() { }

	// RVA: 0x1747E74
	public override bool get_IsReadOnly() { }

	// RVA: 0x1747E7C
	public override float GetValue(Vector4 container) { }

	// RVA: 0x1747E84
	public override void SetValue(Vector4 container, float value) { }

	// RVA: 0x1747CD8
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x1747E8C
	public override string get_Name() { }

	// RVA: 0x1747ED0
	public override bool get_IsReadOnly() { }

	// RVA: 0x1747ED8
	public override float GetValue(Vector4 container) { }

	// RVA: 0x1747EE0
	public override void SetValue(Vector4 container, float value) { }

	// RVA: 0x1747D2C
	public void .ctor() { }

}

// Namespace: 
private class WProperty
{
	// Methods

	// RVA: 0x1747EE8
	public override string get_Name() { }

	// RVA: 0x1747F2C
	public override bool get_IsReadOnly() { }

	// RVA: 0x1747F34
	public override float GetValue(Vector4 container) { }

	// RVA: 0x1747F3C
	public override void SetValue(Vector4 container, float value) { }

	// RVA: 0x1747D80
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector4PropertyBag
{
	// Methods

	// RVA: 0x1746918
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1747FEC
	public override string get_Name() { }

	// RVA: 0x1748030
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748038
	public override int GetValue(Vector2Int container) { }

	// RVA: 0x1748040
	public override void SetValue(Vector2Int container, int value) { }

	// RVA: 0x1747F44
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1748048
	public override string get_Name() { }

	// RVA: 0x174808C
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748094
	public override int GetValue(Vector2Int container) { }

	// RVA: 0x174809C
	public override void SetValue(Vector2Int container, int value) { }

	// RVA: 0x1747F98
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector2IntPropertyBag
{
	// Methods

	// RVA: 0x1746B24
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x17481A0
	public override string get_Name() { }

	// RVA: 0x17481E4
	public override bool get_IsReadOnly() { }

	// RVA: 0x17481EC
	public override int GetValue(Vector3Int container) { }

	// RVA: 0x17481F4
	public override void SetValue(Vector3Int container, int value) { }

	// RVA: 0x17480A4
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x17481FC
	public override string get_Name() { }

	// RVA: 0x1748240
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748248
	public override int GetValue(Vector3Int container) { }

	// RVA: 0x1748250
	public override void SetValue(Vector3Int container, int value) { }

	// RVA: 0x17480F8
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x1748258
	public override string get_Name() { }

	// RVA: 0x174829C
	public override bool get_IsReadOnly() { }

	// RVA: 0x17482A4
	public override int GetValue(Vector3Int container) { }

	// RVA: 0x17482AC
	public override void SetValue(Vector3Int container, int value) { }

	// RVA: 0x174814C
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector3IntPropertyBag
{
	// Methods

	// RVA: 0x1746C78
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1748404
	public override string get_Name() { }

	// RVA: 0x1748448
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748450
	public override float GetValue(Rect container) { }

	// RVA: 0x1748458
	public override void SetValue(Rect container, float value) { }

	// RVA: 0x17482B4
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1748460
	public override string get_Name() { }

	// RVA: 0x17484A4
	public override bool get_IsReadOnly() { }

	// RVA: 0x17484AC
	public override float GetValue(Rect container) { }

	// RVA: 0x17484B4
	public override void SetValue(Rect container, float value) { }

	// RVA: 0x1748308
	public void .ctor() { }

}

// Namespace: 
private class WidthProperty
{
	// Methods

	// RVA: 0x17484BC
	public override string get_Name() { }

	// RVA: 0x1748500
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748508
	public override float GetValue(Rect container) { }

	// RVA: 0x1748510
	public override void SetValue(Rect container, float value) { }

	// RVA: 0x174835C
	public void .ctor() { }

}

// Namespace: 
private class HeightProperty
{
	// Methods

	// RVA: 0x1748518
	public override string get_Name() { }

	// RVA: 0x174855C
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748564
	public override float GetValue(Rect container) { }

	// RVA: 0x174856C
	public override void SetValue(Rect container, float value) { }

	// RVA: 0x17483B0
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class RectPropertyBag
{
	// Methods

	// RVA: 0x1746E28
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x17486C4
	public override string get_Name() { }

	// RVA: 0x1748708
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748710
	public override int GetValue(RectInt container) { }

	// RVA: 0x1748718
	public override void SetValue(RectInt container, int value) { }

	// RVA: 0x1748574
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1748720
	public override string get_Name() { }

	// RVA: 0x1748764
	public override bool get_IsReadOnly() { }

	// RVA: 0x174876C
	public override int GetValue(RectInt container) { }

	// RVA: 0x1748774
	public override void SetValue(RectInt container, int value) { }

	// RVA: 0x17485C8
	public void .ctor() { }

}

// Namespace: 
private class WidthProperty
{
	// Methods

	// RVA: 0x174877C
	public override string get_Name() { }

	// RVA: 0x17487C0
	public override bool get_IsReadOnly() { }

	// RVA: 0x17487C8
	public override int GetValue(RectInt container) { }

	// RVA: 0x17487D0
	public override void SetValue(RectInt container, int value) { }

	// RVA: 0x174861C
	public void .ctor() { }

}

// Namespace: 
private class HeightProperty
{
	// Methods

	// RVA: 0x17487D8
	public override string get_Name() { }

	// RVA: 0x174881C
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748824
	public override int GetValue(RectInt container) { }

	// RVA: 0x174882C
	public override void SetValue(RectInt container, int value) { }

	// RVA: 0x1748670
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class RectIntPropertyBag
{
	// Methods

	// RVA: 0x1747034
	public void .ctor() { }

}

// Namespace: 
private class CenterProperty
{
	// Methods

	// RVA: 0x17488DC
	public override string get_Name() { }

	// RVA: 0x1748920
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748928
	public override Vector3 GetValue(Bounds container) { }

	// RVA: 0x1748934
	public override void SetValue(Bounds container, Vector3 value) { }

	// RVA: 0x1748834
	public void .ctor() { }

}

// Namespace: 
private class ExtentsProperty
{
	// Methods

	// RVA: 0x1748940
	public override string get_Name() { }

	// RVA: 0x1748984
	public override bool get_IsReadOnly() { }

	// RVA: 0x174898C
	public override Vector3 GetValue(Bounds container) { }

	// RVA: 0x1748998
	public override void SetValue(Bounds container, Vector3 value) { }

	// RVA: 0x1748888
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class BoundsPropertyBag
{
	// Methods

	// RVA: 0x1747240
	public void .ctor() { }

}

// Namespace: 
private class PositionProperty
{
	// Methods

	// RVA: 0x1748A4C
	public override string get_Name() { }

	// RVA: 0x1748A90
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748A98
	public override Vector3Int GetValue(BoundsInt container) { }

	// RVA: 0x1748AA4
	public override void SetValue(BoundsInt container, Vector3Int value) { }

	// RVA: 0x17489A4
	public void .ctor() { }

}

// Namespace: 
private class SizeProperty
{
	// Methods

	// RVA: 0x1748AB0
	public override string get_Name() { }

	// RVA: 0x1748AF4
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748AFC
	public override Vector3Int GetValue(BoundsInt container) { }

	// RVA: 0x1748B08
	public override void SetValue(BoundsInt container, Vector3Int value) { }

	// RVA: 0x17489F8
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class BoundsIntPropertyBag
{
	// Methods

	// RVA: 0x1747394
	public void .ctor() { }

}

// Namespace: 
private class MajorProperty
{
	// Methods

	// RVA: 0x1748B14
	public void .ctor() { }

	// RVA: 0x1748DC4
	public override string get_Name() { }

	// RVA: 0x1748E08
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748E10
	public override int GetValue(Version container) { }

	// RVA: 0x1748E30
	public override void SetValue(Version container, int value) { }

}

// Namespace: 
private class MinorProperty
{
	// Methods

	// RVA: 0x1748BC0
	public void .ctor() { }

	// RVA: 0x1748E34
	public override string get_Name() { }

	// RVA: 0x1748E78
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748E80
	public override int GetValue(Version container) { }

	// RVA: 0x1748EA0
	public override void SetValue(Version container, int value) { }

}

// Namespace: 
private class BuildProperty
{
	// Methods

	// RVA: 0x1748C6C
	public void .ctor() { }

	// RVA: 0x1748EA4
	public override string get_Name() { }

	// RVA: 0x1748EE8
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748EF0
	public override int GetValue(Version container) { }

	// RVA: 0x1748F10
	public override void SetValue(Version container, int value) { }

}

// Namespace: 
private class RevisionProperty
{
	// Methods

	// RVA: 0x1748D18
	public void .ctor() { }

	// RVA: 0x1748F14
	public override string get_Name() { }

	// RVA: 0x1748F58
	public override bool get_IsReadOnly() { }

	// RVA: 0x1748F60
	public override int GetValue(Version container) { }

	// RVA: 0x1748F80
	public override void SetValue(Version container, int value) { }

}

// Namespace: Unity.Properties.Internal
internal class SystemVersionPropertyBag
{
	// Methods

	// RVA: 0x17474E8
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal interface IPropertyBagRegister
{
	// Methods

	// RVA: -1
	public abstract void Register() { }

}

// Namespace: 
internal struct TypedStore<T0>
{
	// Fields
	public static Unity.Properties.IPropertyBag<TContainer> PropertyBag; // 0x0
}

// Namespace: Unity.Properties.Internal
internal static class PropertyBagStore
{
	// Fields
	private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,Unity.Properties.IPropertyBag> s_PropertyBags; // 0x0
	private static readonly System.Collections.Generic.List<System.Type> s_RegisteredTypes; // 0x8
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; // 0x10

	// Methods

	// RVA: 0x1748F84
	private static ReflectedPropertyBagProvider get_ReflectedPropertyBagProvider() { }

	// RVA: 0x174637C
	internal static void CreatePropertyBagProvider() { }

	// RVA: 0x352BD5C
	internal static void AddPropertyBag(Unity.Properties.IPropertyBag<TContainer> propertyBag) { }

	// RVA: 0x35293B4
	internal static Unity.Properties.IPropertyBag<TContainer> GetPropertyBag() { }

	// RVA: 0x1733278
	internal static IPropertyBag GetPropertyBag(Type type) { }

	// RVA: 0x3527C54
	internal static bool TryGetPropertyBagForValue(TValue value, IPropertyBag propertyBag) { }

	// RVA: 0x17495BC
	private static void .cctor() { }

}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagAttribute
{
	// Methods

	// RVA: 0x17496C4
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBag<T0>
{
	// Methods

	// RVA: 0x35267E8
	internal void AddProperty(Unity.Properties.Property<TContainer,TValue> property) { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.Internal.ReflectedPropertyBagProvider.<>c <>9; // 0x0
	public static System.Func<System.Reflection.MethodInfo,System.Boolean> <>9__10_0; // 0x8
	public static System.Func<System.Reflection.MemberInfo,System.Int32> <>9__22_0; // 0x10

	// Methods

	// RVA: 0x17499D0
	private static void .cctor() { }

	// RVA: 0x1749A3C
	public void .ctor() { }

	// RVA: 0x1749A44
	internal bool <.ctor>b__10_0(MethodInfo x) { }

	// RVA: 0x1749ACC
	internal int <GetPropertyMembers>b__22_0(MemberInfo x) { }

}

// Namespace: 
private sealed class <GetPropertyMembers>d__22
{
	// Fields
	private int <>1__state; // 0x10
	private MemberInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private Type type; // 0x28
	public Type <>3__type; // 0x30
	private System.Linq.IOrderedEnumerable<System.Reflection.MemberInfo> <members>5__1; // 0x38
	private System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> <>s__2; // 0x40
	private MemberInfo <member>5__3; // 0x48
	private bool <hasDontCreatePropertyAttribute>5__4; // 0x50
	private bool <hasCreatePropertyAttribute>5__5; // 0x51
	private bool <hasNonSerializedAttribute>5__6; // 0x52
	private bool <hasSerializedFieldAttribute>5__7; // 0x53
	private bool <hasSerializeReferenceAttribute>5__8; // 0x54
	private FieldInfo <field>5__9; // 0x58

	// Methods

	// RVA: 0x1749754
	public void .ctor(int <>1__state) { }

	// RVA: 0x1749AF8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1749BD0
	private bool MoveNext() { }

	// RVA: 0x174A5C0
	private void <>m__Finally1() { }

	// RVA: 0x174A684
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	// RVA: 0x174A68C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x174A6CC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x174A6D4
	private System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	// RVA: 0x174A77C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagProvider
{
	// Fields
	private readonly MethodInfo m_CreatePropertyMethod; // 0x10
	private readonly MethodInfo m_CreatePropertyBagMethod; // 0x18
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod; // 0x20
	private readonly MethodInfo m_CreateSetPropertyBagMethod; // 0x28
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; // 0x30
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod; // 0x38
	private readonly MethodInfo m_CreateArrayPropertyBagMethod; // 0x40
	private readonly MethodInfo m_CreateListPropertyBagMethod; // 0x48
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod; // 0x50
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod; // 0x58

	// Methods

	// RVA: 0x1749058
	public void .ctor() { }

	// RVA: 0x174947C
	public IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: 0x3525804
	public Unity.Properties.IPropertyBag<TContainer> CreatePropertyBag() { }

	// RVA: 0x35269D4
	private void CreateProperty(IMemberInfo member, Unity.Properties.Internal.ReflectedPropertyBag<TContainer> propertyBag) { }

	// RVA: 0x3525804
	private Unity.Properties.IPropertyBag<TList> CreateIndexedCollectionPropertyBag() { }

	// RVA: 0x3525804
	private Unity.Properties.IPropertyBag<TSet> CreateSetPropertyBag() { }

	// RVA: 0x3525804
	private Unity.Properties.IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag() { }

	// RVA: 0x3525804
	private Unity.Properties.IPropertyBag<System.Collections.Generic.KeyValuePair<TKey,TValue>> CreateKeyValuePairPropertyBag() { }

	// RVA: 0x3525804
	private Unity.Properties.IPropertyBag<TElement[]> CreateArrayPropertyBag() { }

	// RVA: 0x3525804
	private Unity.Properties.IPropertyBag<System.Collections.Generic.List<TElement>> CreateListPropertyBag() { }

	// RVA: 0x3525804
	private Unity.Properties.IPropertyBag<System.Collections.Generic.HashSet<TElement>> CreateHashSetPropertyBag() { }

	// RVA: 0x3525804
	private Unity.Properties.IPropertyBag<System.Collections.Generic.Dictionary<TKey,TValue>> CreateDictionaryPropertyBag() { }

	// RVA: 0x17496CC
	private static System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetPropertyMembers(Type type) { }

	// RVA: 0x174978C
	private static bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x17498D4
	private static bool IsValidPropertyType(Type type) { }

}

// Namespace: Unity.Properties.Internal
internal static class ReflectionUtilities
{
	// Methods

	// RVA: 0x1732F78
	public static string SanitizeMemberName(MemberInfo info) { }

}


