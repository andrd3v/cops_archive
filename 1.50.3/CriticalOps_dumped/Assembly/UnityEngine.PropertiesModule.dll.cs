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

	// RVA: 0x318DB98
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: Unity.Properties
public sealed class PropertySetter<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D3CF0
	public override string get_Name() { }

	// RVA: 0x30D5108
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

	// RVA: 0x30D3CF0
	public Type DeclaredValueType() { }

	// RVA: 0x30D4CD4
	protected void AddAttribute(Attribute attribute) { }

	// RVA: 0x30D4CD4
	protected void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

	// RVA: 0x30D4CD4
	private void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }

	// RVA: 0x30D4CD4
	private void Unity.Properties.Internal.IAttributes.AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

	// RVA: 0x30D3738
	public bool HasAttribute() { }

	// RVA: 0x30D488C
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

	// RVA: 0x1691948
	public void .ctor(FieldInfo fieldInfo) { }

	// RVA: 0x1691A78
	public string get_Name() { }

	// RVA: 0x1691A80
	public bool get_IsReadOnly() { }

	// RVA: 0x1691AA0
	public Type get_ValueType() { }

	// RVA: 0x1691AC8
	public System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: Unity.Properties
internal struct PropertyMember
{
	// Fields
	internal readonly PropertyInfo m_PropertyInfo; // 0x10
	private readonly string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1691AD4
	public string get_Name() { }

	// RVA: 0x1691ADC
	public bool get_IsReadOnly() { }

	// RVA: 0x1691B0C
	public Type get_ValueType() { }

	// RVA: 0x1691B34
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x1691B6C
	public System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: 
private sealed class GetStructValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: 
private sealed class SetStructValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(TContainer container, TValue value) { }

}

// Namespace: 
private sealed class GetClassValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: 
private sealed class SetClassValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D3CF0
	public override string get_Name() { }

	// RVA: 0x30D4F34
	internal void .ctor(IMemberInfo info, string name) { }

}

// Namespace: Unity.Properties
public sealed class ArrayPropertyBag<T0>
{
	// Methods

	// RVA: 0x30D39B8
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: -1
	protected override TElement[] InstantiateWithCount(int count) { }

	// RVA: 0x30D3CF0
	protected override TElement[] Instantiate() { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: Unity.Properties
public abstract class ContainerPropertyBag<T0>
{
	// Fields
	private readonly System.Collections.Generic.List<Unity.Properties.IProperty<TContainer>> m_PropertiesList; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.String,Unity.Properties.IProperty<TContainer>> m_PropertiesHash; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D4CD4
	protected void AddProperty(Unity.Properties.Property<TContainer,TValue> property) { }

	// RVA: -1
	public bool TryGetProperty(TContainer container, string name, Unity.Properties.IProperty<TContainer>& property) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: Unity.Properties
public class DictionaryPropertyBag<T0, T1>
{
	// Methods

	// RVA: 0x30D39B8
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x30D3CF0
	protected override System.Collections.Generic.Dictionary<TKey,TValue> Instantiate() { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class HashSetPropertyBag<T0>
{
	// Methods

	// RVA: 0x30D39B8
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x30D3CF0
	protected override System.Collections.Generic.HashSet<TElement> Instantiate() { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: 
private class ListElementProperty
{
	// Fields
	internal int m_Index; // 0x0

	// Methods

	// RVA: 0x30D39B8
	public int get_Index() { }

	// RVA: 0x30D3CF0
	public override string get_Name() { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class IndexedCollectionPropertyBag<T0, T1>
{
	// Fields
	private readonly ListElementProperty m_Property; // 0x0

	// Methods

	// RVA: 0x318DB98
	private TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }

	// RVA: 0x318DB98
	protected virtual TList InstantiateWithCount(int count) { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D3CF0
	public override string get_Name() { }

	// RVA: 0x318DB98
	public TKey get_Key() { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class KeyValueCollectionPropertyBag<T0, T1, T2>
{
	// Fields
	private readonly KeyValuePairProperty m_KeyValuePairProperty; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.KeyValuePairPropertyBag.<>c<TKey,TValue> <>9; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal TKey <.cctor>b__7_0(System.Collections.Generic.KeyValuePair<TKey,TValue>& container) { }

	// RVA: 0x318DB98
	internal TValue <.cctor>b__7_1(System.Collections.Generic.KeyValuePair<TKey,TValue>& container) { }

}

// Namespace: Unity.Properties
public class KeyValuePairPropertyBag<T0, T1>
{
	// Fields
	private static readonly Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>,TKey> s_KeyProperty; // 0x0
	private static readonly Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>,TValue> s_ValueProperty; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: Unity.Properties
public class ListPropertyBag<T0>
{
	// Methods

	// RVA: 0x30D39B8
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: -1
	protected override System.Collections.Generic.List<TElement> InstantiateWithCount(int count) { }

	// RVA: 0x30D3CF0
	protected override System.Collections.Generic.List<TElement> Instantiate() { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: Unity.Properties
public static class PropertyBag
{
	// Methods

	// RVA: 0x30DA164
	public static void Register(Unity.Properties.PropertyBag<TContainer> propertyBag) { }

}

// Namespace: Unity.Properties
public abstract class PropertyBag<T0>
{
	// Fields
	private readonly InstantiationKind <InstantiationKind>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	private void Unity.Properties.Internal.IPropertyBagRegister.Register() { }

	// RVA: 0x30D4CD4
	public void Accept(ITypeVisitor visitor) { }

	// RVA: 0x30D39B8
	private InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }

	// RVA: 0x318DB98
	private TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }

	// RVA: 0x30D39B8
	protected virtual InstantiationKind get_InstantiationKind() { }

	// RVA: 0x318DB98
	protected virtual TContainer Instantiate() { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: 
private class SetElementProperty
{
	// Fields
	internal TElement m_Value; // 0x0

	// Methods

	// RVA: 0x30D3CF0
	public override string get_Name() { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class SetPropertyBagBase<T0, T1>
{
	// Fields
	private readonly SetElementProperty m_Property; // 0x0

	// Methods

	// RVA: 0x30D488C
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

	// RVA: 0x1691B78
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

	// RVA: 0x30D9218
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

	// RVA: 0x30D3738
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D488C
	private void SetImplicitConstructor() { }

	// RVA: 0x318DB98
	private static T CreateValueTypeInstance() { }

	// RVA: 0x318DB98
	private static T CreateScriptableObjectInstance() { }

	// RVA: 0x318DB98
	private static T CreateClassInstance() { }

	// RVA: 0x30D4CD4
	public void SetExplicitConstructor(System.Func<T> constructor) { }

	// RVA: 0x318DB98
	private T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }

	// RVA: 0x30D3CF0
	private object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }

}

// Namespace: 
private class NonConstructable
{
	// Methods

	// RVA: 0x169377C
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x1693784
	public object Instantiate() { }

	// RVA: 0x16932C4
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

	// RVA: 0x30D488C
	public void Visit() { }

	// RVA: 0x16932BC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.TypeUtility.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16937D8
	private static void .cctor() { }

	// RVA: 0x1693844
	public void .ctor() { }

	// RVA: 0x169384C
	internal StringBuilder <.cctor>b__11_0() { }

	// RVA: 0x16938A4
	internal void <.cctor>b__11_1(StringBuilder sb) { }

	// RVA: 0x16938C0
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

	// RVA: 0x1691D14
	private static void .cctor() { }

	// RVA: 0x1692150
	public static string GetTypeDisplayName(Type type) { }

	// RVA: 0x1692290
	private static string GetTypeDisplayName(Type type, System.Collections.Generic.IReadOnlyList<System.Type> args, int argIndex) { }

	// RVA: 0x1692C28
	public static Type GetRootType(Type type) { }

	// RVA: 0x1692D5C
	private static ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: 0x30D77AC
	private static Unity.Properties.TypeUtility.ITypeConstructor<T> CreateTypeConstructor() { }

	// RVA: 0x16932CC
	private static ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: 0x30D77AC
	private static Unity.Properties.TypeUtility.ITypeConstructor<T> GetTypeConstructor() { }

	// RVA: 0x16933BC
	public static bool CanBeInstantiated(Type type) { }

	// RVA: -1
	public static bool CanBeInstantiated() { }

	// RVA: 0x30DA164
	public static void SetExplicitInstantiationMethod(System.Func<T> constructor) { }

	// RVA: 0x318DB98
	public static T Instantiate() { }

	// RVA: 0x30D5E84
	public static bool TryInstantiate(T instance) { }

	// RVA: 0x318DB98
	public static T Instantiate(Type derivedType) { }

	// RVA: 0x30D6128
	public static bool TryInstantiate(Type derivedType, T value) { }

	// RVA: 0x318DB98
	public static TArray InstantiateArray(int count) { }

	// RVA: -1
	public static bool TryInstantiateArray(int count, TArray instance) { }

	// RVA: 0x318DB98
	public static TArray InstantiateArray(Type derivedType, int count) { }

	// RVA: 0x16934C0
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: 0x30DA164
	private static void CheckCanBeInstantiated(Unity.Properties.TypeUtility.ITypeConstructor<T> constructor) { }

	// RVA: 0x1693634
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

	// RVA: 0x169390C
	internal static void Initialize() { }

}

// Namespace: 
private class RProperty
{
	// Methods

	// RVA: 0x1694FDC
	public override string get_Name() { }

	// RVA: 0x1694E8C
	public void .ctor() { }

}

// Namespace: 
private class GProperty
{
	// Methods

	// RVA: 0x1695020
	public override string get_Name() { }

	// RVA: 0x1694EE0
	public void .ctor() { }

}

// Namespace: 
private class BProperty
{
	// Methods

	// RVA: 0x1695064
	public override string get_Name() { }

	// RVA: 0x1694F34
	public void .ctor() { }

}

// Namespace: 
private class AProperty
{
	// Methods

	// RVA: 0x16950A8
	public override string get_Name() { }

	// RVA: 0x1694F88
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class ColorPropertyBag
{
	// Methods

	// RVA: 0x1693C40
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1695194
	public override string get_Name() { }

	// RVA: 0x16950EC
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x16951D8
	public override string get_Name() { }

	// RVA: 0x1695140
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector2PropertyBag
{
	// Methods

	// RVA: 0x1693E4C
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1695318
	public override string get_Name() { }

	// RVA: 0x169521C
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x169535C
	public override string get_Name() { }

	// RVA: 0x1695270
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x16953A0
	public override string get_Name() { }

	// RVA: 0x16952C4
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector3PropertyBag
{
	// Methods

	// RVA: 0x1693FA0
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1695534
	public override string get_Name() { }

	// RVA: 0x16953E4
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1695578
	public override string get_Name() { }

	// RVA: 0x1695438
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x16955BC
	public override string get_Name() { }

	// RVA: 0x169548C
	public void .ctor() { }

}

// Namespace: 
private class WProperty
{
	// Methods

	// RVA: 0x1695600
	public override string get_Name() { }

	// RVA: 0x16954E0
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector4PropertyBag
{
	// Methods

	// RVA: 0x1694150
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x16956EC
	public override string get_Name() { }

	// RVA: 0x1695644
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1695730
	public override string get_Name() { }

	// RVA: 0x1695698
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector2IntPropertyBag
{
	// Methods

	// RVA: 0x169435C
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1695870
	public override string get_Name() { }

	// RVA: 0x1695774
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x16958B4
	public override string get_Name() { }

	// RVA: 0x16957C8
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x16958F8
	public override string get_Name() { }

	// RVA: 0x169581C
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector3IntPropertyBag
{
	// Methods

	// RVA: 0x16944B0
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1695A8C
	public override string get_Name() { }

	// RVA: 0x169593C
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1695AD0
	public override string get_Name() { }

	// RVA: 0x1695990
	public void .ctor() { }

}

// Namespace: 
private class WidthProperty
{
	// Methods

	// RVA: 0x1695B14
	public override string get_Name() { }

	// RVA: 0x16959E4
	public void .ctor() { }

}

// Namespace: 
private class HeightProperty
{
	// Methods

	// RVA: 0x1695B58
	public override string get_Name() { }

	// RVA: 0x1695A38
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class RectPropertyBag
{
	// Methods

	// RVA: 0x1694660
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1695CEC
	public override string get_Name() { }

	// RVA: 0x1695B9C
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1695D30
	public override string get_Name() { }

	// RVA: 0x1695BF0
	public void .ctor() { }

}

// Namespace: 
private class WidthProperty
{
	// Methods

	// RVA: 0x1695D74
	public override string get_Name() { }

	// RVA: 0x1695C44
	public void .ctor() { }

}

// Namespace: 
private class HeightProperty
{
	// Methods

	// RVA: 0x1695DB8
	public override string get_Name() { }

	// RVA: 0x1695C98
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class RectIntPropertyBag
{
	// Methods

	// RVA: 0x169486C
	public void .ctor() { }

}

// Namespace: 
private class CenterProperty
{
	// Methods

	// RVA: 0x1695EA4
	public override string get_Name() { }

	// RVA: 0x1695DFC
	public void .ctor() { }

}

// Namespace: 
private class ExtentsProperty
{
	// Methods

	// RVA: 0x1695EE8
	public override string get_Name() { }

	// RVA: 0x1695E50
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class BoundsPropertyBag
{
	// Methods

	// RVA: 0x1694A78
	public void .ctor() { }

}

// Namespace: 
private class PositionProperty
{
	// Methods

	// RVA: 0x1695FD4
	public override string get_Name() { }

	// RVA: 0x1695F2C
	public void .ctor() { }

}

// Namespace: 
private class SizeProperty
{
	// Methods

	// RVA: 0x1696018
	public override string get_Name() { }

	// RVA: 0x1695F80
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class BoundsIntPropertyBag
{
	// Methods

	// RVA: 0x1694BCC
	public void .ctor() { }

}

// Namespace: 
private class MajorProperty
{
	// Methods

	// RVA: 0x169605C
	public void .ctor() { }

	// RVA: 0x169630C
	public override string get_Name() { }

}

// Namespace: 
private class MinorProperty
{
	// Methods

	// RVA: 0x1696108
	public void .ctor() { }

	// RVA: 0x1696350
	public override string get_Name() { }

}

// Namespace: 
private class BuildProperty
{
	// Methods

	// RVA: 0x16961B4
	public void .ctor() { }

	// RVA: 0x1696394
	public override string get_Name() { }

}

// Namespace: 
private class RevisionProperty
{
	// Methods

	// RVA: 0x1696260
	public void .ctor() { }

	// RVA: 0x16963D8
	public override string get_Name() { }

}

// Namespace: Unity.Properties.Internal
internal class SystemVersionPropertyBag
{
	// Methods

	// RVA: 0x1694D20
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

	// RVA: 0x169641C
	private static void .cctor() { }

	// RVA: 0x30DA164
	internal static void AddPropertyBag(Unity.Properties.IPropertyBag<TContainer> propertyBag) { }

	// RVA: 0x30D77AC
	internal static Unity.Properties.IPropertyBag<TContainer> GetPropertyBag() { }

	// RVA: 0x169302C
	internal static IPropertyBag GetPropertyBag(Type type) { }

}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagAttribute
{
	// Methods

	// RVA: 0x1696AD8
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBag<T0>
{
	// Methods

	// RVA: 0x30D4CD4
	internal void AddProperty(Unity.Properties.Property<TContainer,TValue> property) { }

	// RVA: 0x30D488C
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

	// RVA: 0x1696DE4
	private static void .cctor() { }

	// RVA: 0x1696E50
	public void .ctor() { }

	// RVA: 0x1696E58
	internal bool <.ctor>b__10_0(MethodInfo x) { }

	// RVA: 0x1696EE0
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

	// RVA: 0x1696B68
	public void .ctor(int <>1__state) { }

	// RVA: 0x1696F0C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1696FF4
	private bool MoveNext() { }

	// RVA: 0x16979B4
	private void <>m__Finally1() { }

	// RVA: 0x1697A78
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	// RVA: 0x1697A80
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1697AC0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1697AC8
	private System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	// RVA: 0x1697B70
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

	// RVA: 0x1696568
	public void .ctor() { }

	// RVA: 0x1696998
	public IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: 0x30D3CF0
	public Unity.Properties.IPropertyBag<TContainer> CreatePropertyBag() { }

	// RVA: 0x30D4F34
	private void CreateProperty(IMemberInfo member, Unity.Properties.Internal.ReflectedPropertyBag<TContainer> propertyBag) { }

	// RVA: 0x30D3CF0
	private Unity.Properties.IPropertyBag<TList> CreateIndexedCollectionPropertyBag() { }

	// RVA: 0x30D3CF0
	private Unity.Properties.IPropertyBag<TSet> CreateSetPropertyBag() { }

	// RVA: 0x30D3CF0
	private Unity.Properties.IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag() { }

	// RVA: 0x30D3CF0
	private Unity.Properties.IPropertyBag<System.Collections.Generic.KeyValuePair<TKey,TValue>> CreateKeyValuePairPropertyBag() { }

	// RVA: 0x30D3CF0
	private Unity.Properties.IPropertyBag<TElement[]> CreateArrayPropertyBag() { }

	// RVA: 0x30D3CF0
	private Unity.Properties.IPropertyBag<System.Collections.Generic.List<TElement>> CreateListPropertyBag() { }

	// RVA: 0x30D3CF0
	private Unity.Properties.IPropertyBag<System.Collections.Generic.HashSet<TElement>> CreateHashSetPropertyBag() { }

	// RVA: 0x30D3CF0
	private Unity.Properties.IPropertyBag<System.Collections.Generic.Dictionary<TKey,TValue>> CreateDictionaryPropertyBag() { }

	// RVA: 0x1696AE0
	private static System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetPropertyMembers(Type type) { }

	// RVA: 0x1696BA0
	private static bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x1696CE8
	private static bool IsValidPropertyType(Type type) { }

}

// Namespace: Unity.Properties.Internal
internal static class ReflectionUtilities
{
	// Methods

	// RVA: 0x1691980
	public static string SanitizeMemberName(MemberInfo info) { }

}


