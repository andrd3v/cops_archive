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
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal TValue Invoke(ref TContainer container) { }

}

// Namespace: Unity.Properties
public sealed class PropertySetter<T0, T1> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(ref TContainer container, TValue value) { }

}

// Namespace: Unity.Properties
public class DelegateProperty<T0, T1> 
{
	// Fields
	private readonly Unity.Properties.PropertyGetter<TContainer,TValue> m_Getter; // 0x0
	private readonly Unity.Properties.PropertySetter<TContainer,TValue> m_Setter; // 0x0
	private readonly string <Name>k__BackingField; // 0x0

	// Methods

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x2FE49A8
	void .ctor(string name, Unity.Properties.PropertyGetter<TContainer,TValue> getter, Unity.Properties.PropertySetter<TContainer,TValue> setter) { }

}

// Namespace: Unity.Properties
public interface IProperty 
{
	// Methods

	// RVA: 0x2FE360C
	Type DeclaredValueType() { }

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

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x2FE360C
	Type DeclaredValueType() { }

	// RVA: 0x2FE4574
	void AddAttribute(Attribute attribute) { }

	// RVA: 0x2FE4574
	void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

	// RVA: 0x2FE4574
	void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }

	// RVA: 0x2FE4574
	void Unity.Properties.Internal.IAttributes.AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

	// RVA: 0x2FE3054
	bool HasAttribute() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: Unity.Properties
internal interface IMemberInfo 
{
	// Methods

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x2FE3054
	bool get_IsReadOnly() { }

	// RVA: 0x2FE360C
	Type get_ValueType() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: Unity.Properties
internal struct FieldMember 
{
	// Fields
	internal readonly FieldInfo m_FieldInfo; // 0x10
	private readonly string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x157A570
	void .ctor(FieldInfo fieldInfo) { }

	// RVA: 0x157A6A0
	string get_Name() { }

	// RVA: 0x157A6A8
	bool get_IsReadOnly() { }

	// RVA: 0x157A6C8
	Type get_ValueType() { }

	// RVA: 0x157A6F0
	System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: Unity.Properties
internal struct PropertyMember 
{
	// Fields
	internal readonly PropertyInfo m_PropertyInfo; // 0x10
	private readonly string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x157A6FC
	string get_Name() { }

	// RVA: 0x157A704
	bool get_IsReadOnly() { }

	// RVA: 0x157A734
	Type get_ValueType() { }

	// RVA: 0x157A75C
	void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x157A794
	System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: 
private sealed class GetStructValueAction 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal TValue Invoke(ref TContainer container) { }

}

// Namespace: 
private sealed class SetStructValueAction 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(ref TContainer container, TValue value) { }

}

// Namespace: 
private sealed class GetClassValueAction 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal TValue Invoke(TContainer container) { }

}

// Namespace: 
private sealed class SetClassValueAction 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(TContainer container, TValue value) { }

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

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x2FE47D4
	void .ctor(IMemberInfo info, string name) { }

}

// Namespace: Unity.Properties
public sealed class ArrayPropertyBag<T0> 
{
	// Methods

	// RVA: 0x2FE32D4
	InstantiationKind get_InstantiationKind() { }

	// RVA: -1
	TElement[] InstantiateWithCount(int count) { }

	// RVA: 0x2FE360C
	TElement[] Instantiate() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: Unity.Properties
public abstract class ContainerPropertyBag<T0> 
{
	// Fields
	private readonly System.Collections.Generic.List<Unity.Properties.IProperty<TContainer>> m_PropertiesList; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.String,Unity.Properties.IProperty<TContainer>> m_PropertiesHash; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE4574
	void AddProperty(Unity.Properties.Property<TContainer,TValue> property) { }

	// RVA: -1
	bool TryGetProperty(ref TContainer container, string name, out Unity.Properties.IProperty<TContainer>& property) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: Unity.Properties
public class DictionaryPropertyBag<T0, T1> 
{
	// Methods

	// RVA: 0x2FE32D4
	InstantiationKind get_InstantiationKind() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.Dictionary<TKey,TValue> Instantiate() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: Unity.Properties
public class HashSetPropertyBag<T0> 
{
	// Methods

	// RVA: 0x2FE32D4
	InstantiationKind get_InstantiationKind() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.HashSet<TElement> Instantiate() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private class ListElementProperty 
{
	// Fields
	internal int m_Index; // 0x0

	// Methods

	// RVA: 0x2FE32D4
	int get_Index() { }

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: Unity.Properties
public class IndexedCollectionPropertyBag<T0, T1> 
{
	// Fields
	private readonly ListElementProperty m_Property; // 0x0

	// Methods

	// RVA: 0x309AF8C
	TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }

	// RVA: 0x309AF8C
	TList InstantiateWithCount(int count) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: Unity.Properties
public interface IPropertyBag 
{
	// Methods

	// RVA: 0x2FE4574
	void Accept(ITypeVisitor visitor) { }

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

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x309AF8C
	TKey get_Key() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: Unity.Properties
public class KeyValueCollectionPropertyBag<T0, T1, T2> 
{
	// Fields
	private readonly KeyValuePairProperty m_KeyValuePairProperty; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Unity.Properties.KeyValuePairPropertyBag.<>c<TKey,TValue> <>9; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	TKey <.cctor>b__7_0(ref System.Collections.Generic.KeyValuePair<TKey,TValue>& container) { }

	// RVA: 0x309AF8C
	TValue <.cctor>b__7_1(ref System.Collections.Generic.KeyValuePair<TKey,TValue>& container) { }

}

// Namespace: Unity.Properties
public class KeyValuePairPropertyBag<T0, T1> 
{
	// Fields
	private static readonly Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>,TKey> s_KeyProperty; // 0x0
	private static readonly Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>,TValue> s_ValueProperty; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: Unity.Properties
public class ListPropertyBag<T0> 
{
	// Methods

	// RVA: 0x2FE32D4
	InstantiationKind get_InstantiationKind() { }

	// RVA: -1
	System.Collections.Generic.List<TElement> InstantiateWithCount(int count) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.List<TElement> Instantiate() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: Unity.Properties
public static class PropertyBag 
{
	// Methods

	// RVA: 0x2FE9A04
	void Register(Unity.Properties.PropertyBag<TContainer> propertyBag) { }

}

// Namespace: Unity.Properties
public abstract class PropertyBag<T0> 
{
	// Fields
	private readonly InstantiationKind <InstantiationKind>k__BackingField; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void Unity.Properties.Internal.IPropertyBagRegister.Register() { }

	// RVA: 0x2FE4574
	void Accept(ITypeVisitor visitor) { }

	// RVA: 0x2FE32D4
	InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }

	// RVA: 0x309AF8C
	TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }

	// RVA: 0x2FE32D4
	InstantiationKind get_InstantiationKind() { }

	// RVA: 0x309AF8C
	TContainer Instantiate() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private class SetElementProperty 
{
	// Fields
	internal TElement m_Value; // 0x0

	// Methods

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: Unity.Properties
public class SetPropertyBagBase<T0, T1> 
{
	// Fields
	private readonly SetElementProperty m_Property; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: Unity.Properties
public interface ITypeVisitor 
{
	// Methods

	// RVA: 0x2FE41A8
	void Visit() { }

}

// Namespace: Unity.Properties
public static class TypeTraits 
{
	// Methods

	// RVA: 0x157A7A0
	bool IsContainer(Type type) { }

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
	bool get_IsValueType() { }

	// RVA: -1
	bool get_IsPrimitive() { }

	// RVA: -1
	bool get_IsInterface() { }

	// RVA: -1
	bool get_IsAbstract() { }

	// RVA: -1
	bool get_IsArray() { }

	// RVA: -1
	bool get_IsEnum() { }

	// RVA: -1
	bool get_IsNullable() { }

	// RVA: -1
	bool get_IsObject() { }

	// RVA: -1
	bool get_IsString() { }

	// RVA: -1
	bool get_IsContainer() { }

	// RVA: -1
	bool get_CanBeNull() { }

	// RVA: -1
	bool get_IsAbstractOrInterface() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

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

	// RVA: 0x2FE32D4
	InstantiationKind get_InstantiationKind() { }

}

// Namespace: Unity.Properties
internal interface IConstructor<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	T Instantiate() { }

}

// Namespace: Unity.Properties
internal interface IConstructorWithCount<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	T InstantiateWithCount(int count) { }

}

// Namespace: 
private interface ITypeConstructor 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_CanBeInstantiated() { }

	// RVA: 0x2FE360C
	object Instantiate() { }

}

// Namespace: 
private interface ITypeConstructor<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	T Instantiate() { }

	// RVA: 0x2FE4574
	void SetExplicitConstructor(System.Func<T> constructor) { }

}

// Namespace: 
private class TypeConstructor<T0> 
{
	// Fields
	private System.Func<T> m_ExplicitConstructor; // 0x0
	private System.Func<T> m_ImplicitConstructor; // 0x0
	private Unity.Properties.IConstructor<T> m_OverrideConstructor; // 0x0

	// Methods

	// RVA: 0x2FE3054
	bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE41A8
	void SetImplicitConstructor() { }

	// RVA: 0x309AF8C
	T CreateValueTypeInstance() { }

	// RVA: 0x309AF8C
	T CreateScriptableObjectInstance() { }

	// RVA: 0x309AF8C
	T CreateClassInstance() { }

	// RVA: 0x2FE4574
	void SetExplicitConstructor(System.Func<T> constructor) { }

	// RVA: 0x309AF8C
	T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }

	// RVA: 0x2FE360C
	object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }

}

// Namespace: 
private class NonConstructable 
{
	// Methods

	// RVA: 0x157C3A4
	bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x157C3AC
	object Instantiate() { }

	// RVA: 0x157BEEC
	void .ctor() { }

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

	// RVA: 0x2FE41A8
	void Visit() { }

	// RVA: 0x157BEE4
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Unity.Properties.TypeUtility.<>c <>9; // 0x0

	// Methods

	// RVA: 0x157C400
	void .cctor() { }

	// RVA: 0x157C46C
	void .ctor() { }

	// RVA: 0x157C474
	StringBuilder <.cctor>b__11_0() { }

	// RVA: 0x157C4CC
	void <.cctor>b__11_1(StringBuilder sb) { }

	// RVA: 0x157C4E8
	string <.cctor>b__11_2() { }

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

	// RVA: 0x157A93C
	void .cctor() { }

	// RVA: 0x157AD78
	string GetTypeDisplayName(Type type) { }

	// RVA: 0x157AEB8
	string GetTypeDisplayName(Type type, System.Collections.Generic.IReadOnlyList<System.Type> args, ref int argIndex) { }

	// RVA: 0x157B850
	Type GetRootType(Type type) { }

	// RVA: 0x157B984
	ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: 0x2FE704C
	Unity.Properties.TypeUtility.ITypeConstructor<T> CreateTypeConstructor() { }

	// RVA: 0x157BEF4
	ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: 0x2FE704C
	Unity.Properties.TypeUtility.ITypeConstructor<T> GetTypeConstructor() { }

	// RVA: 0x157BFE4
	bool CanBeInstantiated(Type type) { }

	// RVA: -1
	bool CanBeInstantiated() { }

	// RVA: 0x2FE9A04
	void SetExplicitInstantiationMethod(System.Func<T> constructor) { }

	// RVA: 0x309AF8C
	T Instantiate() { }

	// RVA: 0x2FE5724
	bool TryInstantiate(out T instance) { }

	// RVA: 0x309AF8C
	T Instantiate(Type derivedType) { }

	// RVA: 0x2FE59C8
	bool TryInstantiate(Type derivedType, out T value) { }

	// RVA: 0x309AF8C
	TArray InstantiateArray(int count) { }

	// RVA: -1
	bool TryInstantiateArray(int count, out TArray instance) { }

	// RVA: 0x309AF8C
	TArray InstantiateArray(Type derivedType, int count) { }

	// RVA: 0x157C0E8
	void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: 0x2FE9A04
	void CheckCanBeInstantiated(Unity.Properties.TypeUtility.ITypeConstructor<T> constructor) { }

	// RVA: 0x157C25C
	void CheckCanBeInstantiated(ITypeConstructor constructor, Type type) { }

}

// Namespace: Unity.Properties.Internal
internal interface IAttributes 
{
	// Methods

	// RVA: 0x2FE4574
	void AddAttribute(Attribute attribute) { }

	// RVA: 0x2FE4574
	void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

}

// Namespace: Unity.Properties.Internal
internal static class DefaultPropertyBagInitializer 
{
	// Methods

	// RVA: 0x157C534
	void Initialize() { }

}

// Namespace: 
private class RProperty 
{
	// Methods

	// RVA: 0x157DC04
	string get_Name() { }

	// RVA: 0x157DAB4
	void .ctor() { }

}

// Namespace: 
private class GProperty 
{
	// Methods

	// RVA: 0x157DC48
	string get_Name() { }

	// RVA: 0x157DB08
	void .ctor() { }

}

// Namespace: 
private class BProperty 
{
	// Methods

	// RVA: 0x157DC8C
	string get_Name() { }

	// RVA: 0x157DB5C
	void .ctor() { }

}

// Namespace: 
private class AProperty 
{
	// Methods

	// RVA: 0x157DCD0
	string get_Name() { }

	// RVA: 0x157DBB0
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class ColorPropertyBag 
{
	// Methods

	// RVA: 0x157C868
	void .ctor() { }

}

// Namespace: 
private class XProperty 
{
	// Methods

	// RVA: 0x157DDBC
	string get_Name() { }

	// RVA: 0x157DD14
	void .ctor() { }

}

// Namespace: 
private class YProperty 
{
	// Methods

	// RVA: 0x157DE00
	string get_Name() { }

	// RVA: 0x157DD68
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector2PropertyBag 
{
	// Methods

	// RVA: 0x157CA74
	void .ctor() { }

}

// Namespace: 
private class XProperty 
{
	// Methods

	// RVA: 0x157DF40
	string get_Name() { }

	// RVA: 0x157DE44
	void .ctor() { }

}

// Namespace: 
private class YProperty 
{
	// Methods

	// RVA: 0x157DF84
	string get_Name() { }

	// RVA: 0x157DE98
	void .ctor() { }

}

// Namespace: 
private class ZProperty 
{
	// Methods

	// RVA: 0x157DFC8
	string get_Name() { }

	// RVA: 0x157DEEC
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector3PropertyBag 
{
	// Methods

	// RVA: 0x157CBC8
	void .ctor() { }

}

// Namespace: 
private class XProperty 
{
	// Methods

	// RVA: 0x157E15C
	string get_Name() { }

	// RVA: 0x157E00C
	void .ctor() { }

}

// Namespace: 
private class YProperty 
{
	// Methods

	// RVA: 0x157E1A0
	string get_Name() { }

	// RVA: 0x157E060
	void .ctor() { }

}

// Namespace: 
private class ZProperty 
{
	// Methods

	// RVA: 0x157E1E4
	string get_Name() { }

	// RVA: 0x157E0B4
	void .ctor() { }

}

// Namespace: 
private class WProperty 
{
	// Methods

	// RVA: 0x157E228
	string get_Name() { }

	// RVA: 0x157E108
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector4PropertyBag 
{
	// Methods

	// RVA: 0x157CD78
	void .ctor() { }

}

// Namespace: 
private class XProperty 
{
	// Methods

	// RVA: 0x157E314
	string get_Name() { }

	// RVA: 0x157E26C
	void .ctor() { }

}

// Namespace: 
private class YProperty 
{
	// Methods

	// RVA: 0x157E358
	string get_Name() { }

	// RVA: 0x157E2C0
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector2IntPropertyBag 
{
	// Methods

	// RVA: 0x157CF84
	void .ctor() { }

}

// Namespace: 
private class XProperty 
{
	// Methods

	// RVA: 0x157E498
	string get_Name() { }

	// RVA: 0x157E39C
	void .ctor() { }

}

// Namespace: 
private class YProperty 
{
	// Methods

	// RVA: 0x157E4DC
	string get_Name() { }

	// RVA: 0x157E3F0
	void .ctor() { }

}

// Namespace: 
private class ZProperty 
{
	// Methods

	// RVA: 0x157E520
	string get_Name() { }

	// RVA: 0x157E444
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector3IntPropertyBag 
{
	// Methods

	// RVA: 0x157D0D8
	void .ctor() { }

}

// Namespace: 
private class XProperty 
{
	// Methods

	// RVA: 0x157E6B4
	string get_Name() { }

	// RVA: 0x157E564
	void .ctor() { }

}

// Namespace: 
private class YProperty 
{
	// Methods

	// RVA: 0x157E6F8
	string get_Name() { }

	// RVA: 0x157E5B8
	void .ctor() { }

}

// Namespace: 
private class WidthProperty 
{
	// Methods

	// RVA: 0x157E73C
	string get_Name() { }

	// RVA: 0x157E60C
	void .ctor() { }

}

// Namespace: 
private class HeightProperty 
{
	// Methods

	// RVA: 0x157E780
	string get_Name() { }

	// RVA: 0x157E660
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class RectPropertyBag 
{
	// Methods

	// RVA: 0x157D288
	void .ctor() { }

}

// Namespace: 
private class XProperty 
{
	// Methods

	// RVA: 0x157E914
	string get_Name() { }

	// RVA: 0x157E7C4
	void .ctor() { }

}

// Namespace: 
private class YProperty 
{
	// Methods

	// RVA: 0x157E958
	string get_Name() { }

	// RVA: 0x157E818
	void .ctor() { }

}

// Namespace: 
private class WidthProperty 
{
	// Methods

	// RVA: 0x157E99C
	string get_Name() { }

	// RVA: 0x157E86C
	void .ctor() { }

}

// Namespace: 
private class HeightProperty 
{
	// Methods

	// RVA: 0x157E9E0
	string get_Name() { }

	// RVA: 0x157E8C0
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class RectIntPropertyBag 
{
	// Methods

	// RVA: 0x157D494
	void .ctor() { }

}

// Namespace: 
private class CenterProperty 
{
	// Methods

	// RVA: 0x157EACC
	string get_Name() { }

	// RVA: 0x157EA24
	void .ctor() { }

}

// Namespace: 
private class ExtentsProperty 
{
	// Methods

	// RVA: 0x157EB10
	string get_Name() { }

	// RVA: 0x157EA78
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class BoundsPropertyBag 
{
	// Methods

	// RVA: 0x157D6A0
	void .ctor() { }

}

// Namespace: 
private class PositionProperty 
{
	// Methods

	// RVA: 0x157EBFC
	string get_Name() { }

	// RVA: 0x157EB54
	void .ctor() { }

}

// Namespace: 
private class SizeProperty 
{
	// Methods

	// RVA: 0x157EC40
	string get_Name() { }

	// RVA: 0x157EBA8
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class BoundsIntPropertyBag 
{
	// Methods

	// RVA: 0x157D7F4
	void .ctor() { }

}

// Namespace: 
private class MajorProperty 
{
	// Methods

	// RVA: 0x157EC84
	void .ctor() { }

	// RVA: 0x157EF34
	string get_Name() { }

}

// Namespace: 
private class MinorProperty 
{
	// Methods

	// RVA: 0x157ED30
	void .ctor() { }

	// RVA: 0x157EF78
	string get_Name() { }

}

// Namespace: 
private class BuildProperty 
{
	// Methods

	// RVA: 0x157EDDC
	void .ctor() { }

	// RVA: 0x157EFBC
	string get_Name() { }

}

// Namespace: 
private class RevisionProperty 
{
	// Methods

	// RVA: 0x157EE88
	void .ctor() { }

	// RVA: 0x157F000
	string get_Name() { }

}

// Namespace: Unity.Properties.Internal
internal class SystemVersionPropertyBag 
{
	// Methods

	// RVA: 0x157D948
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal interface IPropertyBagRegister 
{
	// Methods

	// RVA: 0x2FE41A8
	void Register() { }

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

	// RVA: 0x157F044
	void .cctor() { }

	// RVA: 0x2FE9A04
	void AddPropertyBag(Unity.Properties.IPropertyBag<TContainer> propertyBag) { }

	// RVA: 0x2FE704C
	Unity.Properties.IPropertyBag<TContainer> GetPropertyBag() { }

	// RVA: 0x157BC54
	IPropertyBag GetPropertyBag(Type type) { }

}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagAttribute 
{
	// Methods

	// RVA: 0x157F700
	void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBag<T0> 
{
	// Methods

	// RVA: 0x2FE4574
	void AddProperty(Unity.Properties.Property<TContainer,TValue> property) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Unity.Properties.Internal.ReflectedPropertyBagProvider.<>c <>9; // 0x0
	public static System.Func<System.Reflection.MethodInfo,System.Boolean> <>9__10_0; // 0x8
	public static System.Func<System.Reflection.MemberInfo,System.Int32> <>9__22_0; // 0x10

	// Methods

	// RVA: 0x157FA0C
	void .cctor() { }

	// RVA: 0x157FA78
	void .ctor() { }

	// RVA: 0x157FA80
	bool <.ctor>b__10_0(MethodInfo x) { }

	// RVA: 0x157FB08
	int <GetPropertyMembers>b__22_0(MemberInfo x) { }

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

	// RVA: 0x157F790
	void .ctor(int <>1__state) { }

	// RVA: 0x157FB34
	void System.IDisposable.Dispose() { }

	// RVA: 0x157FC1C
	bool MoveNext() { }

	// RVA: 0x15805DC
	void <>m__Finally1() { }

	// RVA: 0x15806A0
	MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	// RVA: 0x15806A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x15806E8
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x15806F0
	System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	// RVA: 0x1580798
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x157F190
	void .ctor() { }

	// RVA: 0x157F5C0
	IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: 0x2FE360C
	Unity.Properties.IPropertyBag<TContainer> CreatePropertyBag() { }

	// RVA: 0x2FE47D4
	void CreateProperty(IMemberInfo member, Unity.Properties.Internal.ReflectedPropertyBag<TContainer> propertyBag) { }

	// RVA: 0x2FE360C
	Unity.Properties.IPropertyBag<TList> CreateIndexedCollectionPropertyBag() { }

	// RVA: 0x2FE360C
	Unity.Properties.IPropertyBag<TSet> CreateSetPropertyBag() { }

	// RVA: 0x2FE360C
	Unity.Properties.IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag() { }

	// RVA: 0x2FE360C
	Unity.Properties.IPropertyBag<System.Collections.Generic.KeyValuePair<TKey,TValue>> CreateKeyValuePairPropertyBag() { }

	// RVA: 0x2FE360C
	Unity.Properties.IPropertyBag<TElement[]> CreateArrayPropertyBag() { }

	// RVA: 0x2FE360C
	Unity.Properties.IPropertyBag<System.Collections.Generic.List<TElement>> CreateListPropertyBag() { }

	// RVA: 0x2FE360C
	Unity.Properties.IPropertyBag<System.Collections.Generic.HashSet<TElement>> CreateHashSetPropertyBag() { }

	// RVA: 0x2FE360C
	Unity.Properties.IPropertyBag<System.Collections.Generic.Dictionary<TKey,TValue>> CreateDictionaryPropertyBag() { }

	// RVA: 0x157F708
	System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetPropertyMembers(Type type) { }

	// RVA: 0x157F7C8
	bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x157F910
	bool IsValidPropertyType(Type type) { }

}

// Namespace: Unity.Properties.Internal
internal static class ReflectionUtilities 
{
	// Methods

	// RVA: 0x157A5A8
	string SanitizeMemberName(MemberInfo info) { }

}


