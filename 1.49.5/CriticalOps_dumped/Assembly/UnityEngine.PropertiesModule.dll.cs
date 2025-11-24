// Namespace: 
internal class <Module>
{}

// Namespace: Unity.Properties
public class CreatePropertyAttribute
{}

// Namespace: Unity.Properties
public class DontCreatePropertyAttribute
{}

// Namespace: Unity.Properties
public sealed class PropertyGetter<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: Unity.Properties
public sealed class PropertySetter<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
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

	// RVA: 0x30B1CD4
	public override string get_Name() { }

	// RVA: 0x30B30EC
	public void .ctor(string name, Unity.Properties.PropertyGetter<TContainer,TValue> getter, Unity.Properties.PropertySetter<TContainer,TValue> setter) { }

}

// Namespace: Unity.Properties
public interface IProperty
{
	// Methods

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

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: 0x30B1CD4
	public Type DeclaredValueType() { }

	// RVA: 0x30B2CB8
	protected void AddAttribute(Attribute attribute) { }

	// RVA: 0x30B2CB8
	protected void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

	// RVA: 0x30B2CB8
	private void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }

	// RVA: 0x30B2CB8
	private void Unity.Properties.Internal.IAttributes.AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

	// RVA: 0x30B171C
	public bool HasAttribute() { }

	// RVA: 0x30B2870
	protected void .ctor() { }

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
	public abstract System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: Unity.Properties
internal struct FieldMember
{
	// Fields
	internal readonly FieldInfo m_FieldInfo; // 0x10
	private readonly string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x166E7C4
	public void .ctor(FieldInfo fieldInfo) { }

	// RVA: 0x166E8F4
	public string get_Name() { }

	// RVA: 0x166E8FC
	public bool get_IsReadOnly() { }

	// RVA: 0x166E91C
	public Type get_ValueType() { }

	// RVA: 0x166E944
	public System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: Unity.Properties
internal struct PropertyMember
{
	// Fields
	internal readonly PropertyInfo m_PropertyInfo; // 0x10
	private readonly string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x166E950
	public string get_Name() { }

	// RVA: 0x166E958
	public bool get_IsReadOnly() { }

	// RVA: 0x166E988
	public Type get_ValueType() { }

	// RVA: 0x166E9B0
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x166E9E8
	public System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: 
private sealed class GetStructValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: 
private sealed class SetStructValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(TContainer container, TValue value) { }

}

// Namespace: 
private sealed class GetClassValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: 
private sealed class SetClassValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
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

	// RVA: 0x30B1CD4
	public override string get_Name() { }

	// RVA: 0x30B2F18
	internal void .ctor(IMemberInfo info, string name) { }

}

// Namespace: Unity.Properties
public sealed class ArrayPropertyBag<T0>
{
	// Methods

	// RVA: 0x30B199C
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: -1
	protected override TElement[] InstantiateWithCount(int count) { }

	// RVA: 0x30B1CD4
	protected override TElement[] Instantiate() { }

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: Unity.Properties
public abstract class ContainerPropertyBag<T0>
{
	// Fields
	private readonly System.Collections.Generic.List<Unity.Properties.IProperty<TContainer>> m_PropertiesList; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.String,Unity.Properties.IProperty<TContainer>> m_PropertiesHash; // 0x0

	// Methods

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2CB8
	protected void AddProperty(Unity.Properties.Property<TContainer,TValue> property) { }

	// RVA: -1
	public bool TryGetProperty(TContainer container, string name, Unity.Properties.IProperty<TContainer>& property) { }

	// RVA: 0x30B2870
	protected void .ctor() { }

}

// Namespace: Unity.Properties
public class DictionaryPropertyBag<T0, T1>
{
	// Methods

	// RVA: 0x30B199C
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x30B1CD4
	protected override System.Collections.Generic.Dictionary<TKey,TValue> Instantiate() { }

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class HashSetPropertyBag<T0>
{
	// Methods

	// RVA: 0x30B199C
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x30B1CD4
	protected override System.Collections.Generic.HashSet<TElement> Instantiate() { }

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: 
private class ListElementProperty
{
	// Fields
	internal int m_Index; // 0x0

	// Methods

	// RVA: 0x30B199C
	public int get_Index() { }

	// RVA: 0x30B1CD4
	public override string get_Name() { }

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class IndexedCollectionPropertyBag<T0, T1>
{
	// Fields
	private readonly ListElementProperty m_Property; // 0x0

	// Methods

	// RVA: 0x316B894
	private TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }

	// RVA: 0x316B894
	protected virtual TList InstantiateWithCount(int count) { }

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: Unity.Properties
public interface IPropertyBag
{
	// Methods

	// RVA: -1
	public abstract void Accept(ITypeVisitor visitor) { }

}

// Namespace: Unity.Properties
public interface IPropertyBag<T0>
{}

// Namespace: 
private class KeyValuePairProperty
{
	// Fields
	private TKey <Key>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30B1CD4
	public override string get_Name() { }

	// RVA: 0x316B894
	public TKey get_Key() { }

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class KeyValueCollectionPropertyBag<T0, T1, T2>
{
	// Fields
	private readonly KeyValuePairProperty m_KeyValuePairProperty; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.KeyValuePairPropertyBag.<>c<TKey,TValue> <>9; // 0x0

	// Methods

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal TKey <.cctor>b__7_0(System.Collections.Generic.KeyValuePair<TKey,TValue>& container) { }

	// RVA: 0x316B894
	internal TValue <.cctor>b__7_1(System.Collections.Generic.KeyValuePair<TKey,TValue>& container) { }

}

// Namespace: Unity.Properties
public class KeyValuePairPropertyBag<T0, T1>
{
	// Fields
	private static readonly Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>,TKey> s_KeyProperty; // 0x0
	private static readonly Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>,TValue> s_ValueProperty; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B71FC
	private static void .cctor() { }

}

// Namespace: Unity.Properties
public class ListPropertyBag<T0>
{
	// Methods

	// RVA: 0x30B199C
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: -1
	protected override System.Collections.Generic.List<TElement> InstantiateWithCount(int count) { }

	// RVA: 0x30B1CD4
	protected override System.Collections.Generic.List<TElement> Instantiate() { }

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: Unity.Properties
public static class PropertyBag
{
	// Methods

	// RVA: 0x30B8148
	public static void Register(Unity.Properties.PropertyBag<TContainer> propertyBag) { }

}

// Namespace: Unity.Properties
public abstract class PropertyBag<T0>
{
	// Fields
	private readonly InstantiationKind <InstantiationKind>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	private void Unity.Properties.Internal.IPropertyBagRegister.Register() { }

	// RVA: 0x30B2CB8
	public void Accept(ITypeVisitor visitor) { }

	// RVA: 0x30B199C
	private InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }

	// RVA: 0x316B894
	private TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }

	// RVA: 0x30B199C
	protected virtual InstantiationKind get_InstantiationKind() { }

	// RVA: 0x316B894
	protected virtual TContainer Instantiate() { }

	// RVA: 0x30B2870
	protected void .ctor() { }

}

// Namespace: 
private class SetElementProperty
{
	// Fields
	internal TElement m_Value; // 0x0

	// Methods

	// RVA: 0x30B1CD4
	public override string get_Name() { }

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class SetPropertyBagBase<T0, T1>
{
	// Fields
	private readonly SetElementProperty m_Property; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: Unity.Properties
public interface ITypeVisitor
{
	// Methods

	// RVA: -1
	public abstract void Visit() { }

}

// Namespace: Unity.Properties
public static class TypeTraits
{
	// Methods

	// RVA: 0x166E9F4
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

	// RVA: 0x30B71FC
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

	// RVA: 0x30B171C
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2870
	private void SetImplicitConstructor() { }

	// RVA: 0x316B894
	private static T CreateValueTypeInstance() { }

	// RVA: 0x316B894
	private static T CreateScriptableObjectInstance() { }

	// RVA: 0x316B894
	private static T CreateClassInstance() { }

	// RVA: 0x30B2CB8
	public void SetExplicitConstructor(System.Func<T> constructor) { }

	// RVA: 0x316B894
	private T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }

	// RVA: 0x30B1CD4
	private object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }

}

// Namespace: 
private class NonConstructable
{
	// Methods

	// RVA: 0x16705F8
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x1670600
	public object Instantiate() { }

	// RVA: 0x1670140
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

	// RVA: 0x30B2870
	public void Visit() { }

	// RVA: 0x1670138
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.TypeUtility.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1670654
	private static void .cctor() { }

	// RVA: 0x16706C0
	public void .ctor() { }

	// RVA: 0x16706C8
	internal StringBuilder <.cctor>b__11_0() { }

	// RVA: 0x1670720
	internal void <.cctor>b__11_1(StringBuilder sb) { }

	// RVA: 0x167073C
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

	// RVA: 0x166EB90
	private static void .cctor() { }

	// RVA: 0x166EFCC
	public static string GetTypeDisplayName(Type type) { }

	// RVA: 0x166F10C
	private static string GetTypeDisplayName(Type type, System.Collections.Generic.IReadOnlyList<System.Type> args, int argIndex) { }

	// RVA: 0x166FAA4
	public static Type GetRootType(Type type) { }

	// RVA: 0x166FBD8
	private static ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: 0x30B5790
	private static Unity.Properties.TypeUtility.ITypeConstructor<T> CreateTypeConstructor() { }

	// RVA: 0x1670148
	private static ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: 0x30B5790
	private static Unity.Properties.TypeUtility.ITypeConstructor<T> GetTypeConstructor() { }

	// RVA: 0x1670238
	public static bool CanBeInstantiated(Type type) { }

	// RVA: -1
	public static bool CanBeInstantiated() { }

	// RVA: 0x30B8148
	public static void SetExplicitInstantiationMethod(System.Func<T> constructor) { }

	// RVA: 0x316B894
	public static T Instantiate() { }

	// RVA: 0x30B3E68
	public static bool TryInstantiate(T instance) { }

	// RVA: 0x316B894
	public static T Instantiate(Type derivedType) { }

	// RVA: 0x30B410C
	public static bool TryInstantiate(Type derivedType, T value) { }

	// RVA: 0x316B894
	public static TArray InstantiateArray(int count) { }

	// RVA: -1
	public static bool TryInstantiateArray(int count, TArray instance) { }

	// RVA: 0x316B894
	public static TArray InstantiateArray(Type derivedType, int count) { }

	// RVA: 0x167033C
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: 0x30B8148
	private static void CheckCanBeInstantiated(Unity.Properties.TypeUtility.ITypeConstructor<T> constructor) { }

	// RVA: 0x16704B0
	private static void CheckCanBeInstantiated(ITypeConstructor constructor, Type type) { }

}

// Namespace: Unity.Properties.Internal
internal interface IAttributes
{
	// Methods

	// RVA: -1
	public abstract void AddAttribute(Attribute attribute) { }

	// RVA: -1
	public abstract void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

}

// Namespace: Unity.Properties.Internal
internal static class DefaultPropertyBagInitializer
{
	// Methods

	// RVA: 0x1670788
	internal static void Initialize() { }

}

// Namespace: 
private class RProperty
{
	// Methods

	// RVA: 0x1671E58
	public override string get_Name() { }

	// RVA: 0x1671D08
	public void .ctor() { }

}

// Namespace: 
private class GProperty
{
	// Methods

	// RVA: 0x1671E9C
	public override string get_Name() { }

	// RVA: 0x1671D5C
	public void .ctor() { }

}

// Namespace: 
private class BProperty
{
	// Methods

	// RVA: 0x1671EE0
	public override string get_Name() { }

	// RVA: 0x1671DB0
	public void .ctor() { }

}

// Namespace: 
private class AProperty
{
	// Methods

	// RVA: 0x1671F24
	public override string get_Name() { }

	// RVA: 0x1671E04
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class ColorPropertyBag
{
	// Methods

	// RVA: 0x1670ABC
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1672010
	public override string get_Name() { }

	// RVA: 0x1671F68
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1672054
	public override string get_Name() { }

	// RVA: 0x1671FBC
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector2PropertyBag
{
	// Methods

	// RVA: 0x1670CC8
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1672194
	public override string get_Name() { }

	// RVA: 0x1672098
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x16721D8
	public override string get_Name() { }

	// RVA: 0x16720EC
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x167221C
	public override string get_Name() { }

	// RVA: 0x1672140
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector3PropertyBag
{
	// Methods

	// RVA: 0x1670E1C
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x16723B0
	public override string get_Name() { }

	// RVA: 0x1672260
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x16723F4
	public override string get_Name() { }

	// RVA: 0x16722B4
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x1672438
	public override string get_Name() { }

	// RVA: 0x1672308
	public void .ctor() { }

}

// Namespace: 
private class WProperty
{
	// Methods

	// RVA: 0x167247C
	public override string get_Name() { }

	// RVA: 0x167235C
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector4PropertyBag
{
	// Methods

	// RVA: 0x1670FCC
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1672568
	public override string get_Name() { }

	// RVA: 0x16724C0
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x16725AC
	public override string get_Name() { }

	// RVA: 0x1672514
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector2IntPropertyBag
{
	// Methods

	// RVA: 0x16711D8
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x16726EC
	public override string get_Name() { }

	// RVA: 0x16725F0
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1672730
	public override string get_Name() { }

	// RVA: 0x1672644
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x1672774
	public override string get_Name() { }

	// RVA: 0x1672698
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector3IntPropertyBag
{
	// Methods

	// RVA: 0x167132C
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1672908
	public override string get_Name() { }

	// RVA: 0x16727B8
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x167294C
	public override string get_Name() { }

	// RVA: 0x167280C
	public void .ctor() { }

}

// Namespace: 
private class WidthProperty
{
	// Methods

	// RVA: 0x1672990
	public override string get_Name() { }

	// RVA: 0x1672860
	public void .ctor() { }

}

// Namespace: 
private class HeightProperty
{
	// Methods

	// RVA: 0x16729D4
	public override string get_Name() { }

	// RVA: 0x16728B4
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class RectPropertyBag
{
	// Methods

	// RVA: 0x16714DC
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1672B68
	public override string get_Name() { }

	// RVA: 0x1672A18
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1672BAC
	public override string get_Name() { }

	// RVA: 0x1672A6C
	public void .ctor() { }

}

// Namespace: 
private class WidthProperty
{
	// Methods

	// RVA: 0x1672BF0
	public override string get_Name() { }

	// RVA: 0x1672AC0
	public void .ctor() { }

}

// Namespace: 
private class HeightProperty
{
	// Methods

	// RVA: 0x1672C34
	public override string get_Name() { }

	// RVA: 0x1672B14
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class RectIntPropertyBag
{
	// Methods

	// RVA: 0x16716E8
	public void .ctor() { }

}

// Namespace: 
private class CenterProperty
{
	// Methods

	// RVA: 0x1672D20
	public override string get_Name() { }

	// RVA: 0x1672C78
	public void .ctor() { }

}

// Namespace: 
private class ExtentsProperty
{
	// Methods

	// RVA: 0x1672D64
	public override string get_Name() { }

	// RVA: 0x1672CCC
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class BoundsPropertyBag
{
	// Methods

	// RVA: 0x16718F4
	public void .ctor() { }

}

// Namespace: 
private class PositionProperty
{
	// Methods

	// RVA: 0x1672E50
	public override string get_Name() { }

	// RVA: 0x1672DA8
	public void .ctor() { }

}

// Namespace: 
private class SizeProperty
{
	// Methods

	// RVA: 0x1672E94
	public override string get_Name() { }

	// RVA: 0x1672DFC
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class BoundsIntPropertyBag
{
	// Methods

	// RVA: 0x1671A48
	public void .ctor() { }

}

// Namespace: 
private class MajorProperty
{
	// Methods

	// RVA: 0x1672ED8
	public void .ctor() { }

	// RVA: 0x1673188
	public override string get_Name() { }

}

// Namespace: 
private class MinorProperty
{
	// Methods

	// RVA: 0x1672F84
	public void .ctor() { }

	// RVA: 0x16731CC
	public override string get_Name() { }

}

// Namespace: 
private class BuildProperty
{
	// Methods

	// RVA: 0x1673030
	public void .ctor() { }

	// RVA: 0x1673210
	public override string get_Name() { }

}

// Namespace: 
private class RevisionProperty
{
	// Methods

	// RVA: 0x16730DC
	public void .ctor() { }

	// RVA: 0x1673254
	public override string get_Name() { }

}

// Namespace: Unity.Properties.Internal
internal class SystemVersionPropertyBag
{
	// Methods

	// RVA: 0x1671B9C
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
	private static System.Action<System.Type,Unity.Properties.IPropertyBag> NewTypeRegistered; // 0x10
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; // 0x18

	// Methods

	// RVA: 0x1673298
	private static void .cctor() { }

	// RVA: 0x30B8148
	internal static void AddPropertyBag(Unity.Properties.IPropertyBag<TContainer> propertyBag) { }

	// RVA: 0x30B5790
	internal static Unity.Properties.IPropertyBag<TContainer> GetPropertyBag() { }

	// RVA: 0x166FEA8
	internal static IPropertyBag GetPropertyBag(Type type) { }

}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagAttribute
{
	// Methods

	// RVA: 0x1673954
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBag<T0>
{
	// Methods

	// RVA: 0x30B2CB8
	internal void AddProperty(Unity.Properties.Property<TContainer,TValue> property) { }

	// RVA: 0x30B2870
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

	// RVA: 0x1673C60
	private static void .cctor() { }

	// RVA: 0x1673CCC
	public void .ctor() { }

	// RVA: 0x1673CD4
	internal bool <.ctor>b__10_0(MethodInfo x) { }

	// RVA: 0x1673D5C
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
	private FieldInfo <field>5__8; // 0x58

	// Methods

	// RVA: 0x16739E4
	public void .ctor(int <>1__state) { }

	// RVA: 0x1673D88
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1673E70
	private bool MoveNext() { }

	// RVA: 0x1674830
	private void <>m__Finally1() { }

	// RVA: 0x16748F4
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	// RVA: 0x16748FC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x167493C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1674944
	private System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	// RVA: 0x16749EC
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

	// RVA: 0x16733E4
	public void .ctor() { }

	// RVA: 0x1673814
	public IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: 0x30B1CD4
	public Unity.Properties.IPropertyBag<TContainer> CreatePropertyBag() { }

	// RVA: 0x30B2F18
	private void CreateProperty(IMemberInfo member, Unity.Properties.Internal.ReflectedPropertyBag<TContainer> propertyBag) { }

	// RVA: 0x30B1CD4
	private Unity.Properties.IPropertyBag<TList> CreateIndexedCollectionPropertyBag() { }

	// RVA: 0x30B1CD4
	private Unity.Properties.IPropertyBag<TSet> CreateSetPropertyBag() { }

	// RVA: 0x30B1CD4
	private Unity.Properties.IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag() { }

	// RVA: 0x30B1CD4
	private Unity.Properties.IPropertyBag<System.Collections.Generic.KeyValuePair<TKey,TValue>> CreateKeyValuePairPropertyBag() { }

	// RVA: 0x30B1CD4
	private Unity.Properties.IPropertyBag<TElement[]> CreateArrayPropertyBag() { }

	// RVA: 0x30B1CD4
	private Unity.Properties.IPropertyBag<System.Collections.Generic.List<TElement>> CreateListPropertyBag() { }

	// RVA: 0x30B1CD4
	private Unity.Properties.IPropertyBag<System.Collections.Generic.HashSet<TElement>> CreateHashSetPropertyBag() { }

	// RVA: 0x30B1CD4
	private Unity.Properties.IPropertyBag<System.Collections.Generic.Dictionary<TKey,TValue>> CreateDictionaryPropertyBag() { }

	// RVA: 0x167395C
	private static System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetPropertyMembers(Type type) { }

	// RVA: 0x1673A1C
	private static bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x1673B64
	private static bool IsValidPropertyType(Type type) { }

}

// Namespace: Unity.Properties.Internal
internal static class ReflectionUtilities
{
	// Methods

	// RVA: 0x166E7FC
	public static string SanitizeMemberName(MemberInfo info) { }

}


