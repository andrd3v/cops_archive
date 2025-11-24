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

	// RVA: 0x315B3A8
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: Unity.Properties
public sealed class PropertySetter<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A17DC
	public override string get_Name() { }

	// RVA: 0x30A2BF4
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

	// RVA: 0x30A17DC
	public Type DeclaredValueType() { }

	// RVA: 0x30A27C0
	protected void AddAttribute(Attribute attribute) { }

	// RVA: 0x30A27C0
	protected void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

	// RVA: 0x30A27C0
	private void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }

	// RVA: 0x30A27C0
	private void Unity.Properties.Internal.IAttributes.AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes) { }

	// RVA: 0x30A1224
	public bool HasAttribute() { }

	// RVA: 0x30A2378
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

	// RVA: 0x165F554
	public void .ctor(FieldInfo fieldInfo) { }

	// RVA: 0x165F684
	public string get_Name() { }

	// RVA: 0x165F68C
	public bool get_IsReadOnly() { }

	// RVA: 0x165F6AC
	public Type get_ValueType() { }

	// RVA: 0x165F6D4
	public System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: Unity.Properties
internal struct PropertyMember
{
	// Fields
	internal readonly PropertyInfo m_PropertyInfo; // 0x10
	private readonly string <Name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x165F6E0
	public string get_Name() { }

	// RVA: 0x165F6E8
	public bool get_IsReadOnly() { }

	// RVA: 0x165F718
	public Type get_ValueType() { }

	// RVA: 0x165F740
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x165F778
	public System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes() { }

}

// Namespace: 
private sealed class GetStructValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: 
private sealed class SetStructValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(TContainer container, TValue value) { }

}

// Namespace: 
private sealed class GetClassValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual TValue Invoke(TContainer container) { }

}

// Namespace: 
private sealed class SetClassValueAction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A17DC
	public override string get_Name() { }

	// RVA: 0x30A2A20
	internal void .ctor(IMemberInfo info, string name) { }

}

// Namespace: Unity.Properties
public sealed class ArrayPropertyBag<T0>
{
	// Methods

	// RVA: 0x30A14A4
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: -1
	protected override TElement[] InstantiateWithCount(int count) { }

	// RVA: 0x30A17DC
	protected override TElement[] Instantiate() { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: Unity.Properties
public abstract class ContainerPropertyBag<T0>
{
	// Fields
	private readonly System.Collections.Generic.List<Unity.Properties.IProperty<TContainer>> m_PropertiesList; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.String,Unity.Properties.IProperty<TContainer>> m_PropertiesHash; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A27C0
	protected void AddProperty(Unity.Properties.Property<TContainer,TValue> property) { }

	// RVA: -1
	public bool TryGetProperty(TContainer container, string name, Unity.Properties.IProperty<TContainer>& property) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: Unity.Properties
public class DictionaryPropertyBag<T0, T1>
{
	// Methods

	// RVA: 0x30A14A4
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x30A17DC
	protected override System.Collections.Generic.Dictionary<TKey,TValue> Instantiate() { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class HashSetPropertyBag<T0>
{
	// Methods

	// RVA: 0x30A14A4
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: 0x30A17DC
	protected override System.Collections.Generic.HashSet<TElement> Instantiate() { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
private class ListElementProperty
{
	// Fields
	internal int m_Index; // 0x0

	// Methods

	// RVA: 0x30A14A4
	public int get_Index() { }

	// RVA: 0x30A17DC
	public override string get_Name() { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class IndexedCollectionPropertyBag<T0, T1>
{
	// Fields
	private readonly ListElementProperty m_Property; // 0x0

	// Methods

	// RVA: 0x315B3A8
	private TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }

	// RVA: 0x315B3A8
	protected virtual TList InstantiateWithCount(int count) { }

	// RVA: 0x30A2378
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

	// RVA: 0x30A17DC
	public override string get_Name() { }

	// RVA: 0x315B3A8
	public TKey get_Key() { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class KeyValueCollectionPropertyBag<T0, T1, T2>
{
	// Fields
	private readonly KeyValuePairProperty m_KeyValuePairProperty; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.KeyValuePairPropertyBag.<>c<TKey,TValue> <>9; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal TKey <.cctor>b__7_0(System.Collections.Generic.KeyValuePair<TKey,TValue>& container) { }

	// RVA: 0x315B3A8
	internal TValue <.cctor>b__7_1(System.Collections.Generic.KeyValuePair<TKey,TValue>& container) { }

}

// Namespace: Unity.Properties
public class KeyValuePairPropertyBag<T0, T1>
{
	// Fields
	private static readonly Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>,TKey> s_KeyProperty; // 0x0
	private static readonly Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>,TValue> s_ValueProperty; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: Unity.Properties
public class ListPropertyBag<T0>
{
	// Methods

	// RVA: 0x30A14A4
	protected override InstantiationKind get_InstantiationKind() { }

	// RVA: -1
	protected override System.Collections.Generic.List<TElement> InstantiateWithCount(int count) { }

	// RVA: 0x30A17DC
	protected override System.Collections.Generic.List<TElement> Instantiate() { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: Unity.Properties
public static class PropertyBag
{
	// Methods

	// RVA: 0x30A7C50
	public static void Register(Unity.Properties.PropertyBag<TContainer> propertyBag) { }

}

// Namespace: Unity.Properties
public abstract class PropertyBag<T0>
{
	// Fields
	private readonly InstantiationKind <InstantiationKind>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	private void Unity.Properties.Internal.IPropertyBagRegister.Register() { }

	// RVA: 0x30A27C0
	public void Accept(ITypeVisitor visitor) { }

	// RVA: 0x30A14A4
	private InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }

	// RVA: 0x315B3A8
	private TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }

	// RVA: 0x30A14A4
	protected virtual InstantiationKind get_InstantiationKind() { }

	// RVA: 0x315B3A8
	protected virtual TContainer Instantiate() { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
private class SetElementProperty
{
	// Fields
	internal TElement m_Value; // 0x0

	// Methods

	// RVA: 0x30A17DC
	public override string get_Name() { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: Unity.Properties
public class SetPropertyBagBase<T0, T1>
{
	// Fields
	private readonly SetElementProperty m_Property; // 0x0

	// Methods

	// RVA: 0x30A2378
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

	// RVA: 0x165F784
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

	// RVA: 0x30A6D04
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

	// RVA: 0x30A1224
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A2378
	private void SetImplicitConstructor() { }

	// RVA: 0x315B3A8
	private static T CreateValueTypeInstance() { }

	// RVA: 0x315B3A8
	private static T CreateScriptableObjectInstance() { }

	// RVA: 0x315B3A8
	private static T CreateClassInstance() { }

	// RVA: 0x30A27C0
	public void SetExplicitConstructor(System.Func<T> constructor) { }

	// RVA: 0x315B3A8
	private T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }

	// RVA: 0x30A17DC
	private object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }

}

// Namespace: 
private class NonConstructable
{
	// Methods

	// RVA: 0x1661388
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x1661390
	public object Instantiate() { }

	// RVA: 0x1660ED0
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

	// RVA: 0x30A2378
	public void Visit() { }

	// RVA: 0x1660EC8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Unity.Properties.TypeUtility.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16613E4
	private static void .cctor() { }

	// RVA: 0x1661450
	public void .ctor() { }

	// RVA: 0x1661458
	internal StringBuilder <.cctor>b__11_0() { }

	// RVA: 0x16614B0
	internal void <.cctor>b__11_1(StringBuilder sb) { }

	// RVA: 0x16614CC
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

	// RVA: 0x165F920
	private static void .cctor() { }

	// RVA: 0x165FD5C
	public static string GetTypeDisplayName(Type type) { }

	// RVA: 0x165FE9C
	private static string GetTypeDisplayName(Type type, System.Collections.Generic.IReadOnlyList<System.Type> args, int argIndex) { }

	// RVA: 0x1660834
	public static Type GetRootType(Type type) { }

	// RVA: 0x1660968
	private static ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: 0x30A5298
	private static Unity.Properties.TypeUtility.ITypeConstructor<T> CreateTypeConstructor() { }

	// RVA: 0x1660ED8
	private static ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: 0x30A5298
	private static Unity.Properties.TypeUtility.ITypeConstructor<T> GetTypeConstructor() { }

	// RVA: 0x1660FC8
	public static bool CanBeInstantiated(Type type) { }

	// RVA: -1
	public static bool CanBeInstantiated() { }

	// RVA: 0x30A7C50
	public static void SetExplicitInstantiationMethod(System.Func<T> constructor) { }

	// RVA: 0x315B3A8
	public static T Instantiate() { }

	// RVA: 0x30A3970
	public static bool TryInstantiate(T instance) { }

	// RVA: 0x315B3A8
	public static T Instantiate(Type derivedType) { }

	// RVA: 0x30A3C14
	public static bool TryInstantiate(Type derivedType, T value) { }

	// RVA: 0x315B3A8
	public static TArray InstantiateArray(int count) { }

	// RVA: -1
	public static bool TryInstantiateArray(int count, TArray instance) { }

	// RVA: 0x315B3A8
	public static TArray InstantiateArray(Type derivedType, int count) { }

	// RVA: 0x16610CC
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: 0x30A7C50
	private static void CheckCanBeInstantiated(Unity.Properties.TypeUtility.ITypeConstructor<T> constructor) { }

	// RVA: 0x1661240
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

	// RVA: 0x1661518
	internal static void Initialize() { }

}

// Namespace: 
private class RProperty
{
	// Methods

	// RVA: 0x1662BE8
	public override string get_Name() { }

	// RVA: 0x1662A98
	public void .ctor() { }

}

// Namespace: 
private class GProperty
{
	// Methods

	// RVA: 0x1662C2C
	public override string get_Name() { }

	// RVA: 0x1662AEC
	public void .ctor() { }

}

// Namespace: 
private class BProperty
{
	// Methods

	// RVA: 0x1662C70
	public override string get_Name() { }

	// RVA: 0x1662B40
	public void .ctor() { }

}

// Namespace: 
private class AProperty
{
	// Methods

	// RVA: 0x1662CB4
	public override string get_Name() { }

	// RVA: 0x1662B94
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class ColorPropertyBag
{
	// Methods

	// RVA: 0x166184C
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1662DA0
	public override string get_Name() { }

	// RVA: 0x1662CF8
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1662DE4
	public override string get_Name() { }

	// RVA: 0x1662D4C
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector2PropertyBag
{
	// Methods

	// RVA: 0x1661A58
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1662F24
	public override string get_Name() { }

	// RVA: 0x1662E28
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1662F68
	public override string get_Name() { }

	// RVA: 0x1662E7C
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x1662FAC
	public override string get_Name() { }

	// RVA: 0x1662ED0
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector3PropertyBag
{
	// Methods

	// RVA: 0x1661BAC
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1663140
	public override string get_Name() { }

	// RVA: 0x1662FF0
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x1663184
	public override string get_Name() { }

	// RVA: 0x1663044
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x16631C8
	public override string get_Name() { }

	// RVA: 0x1663098
	public void .ctor() { }

}

// Namespace: 
private class WProperty
{
	// Methods

	// RVA: 0x166320C
	public override string get_Name() { }

	// RVA: 0x16630EC
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector4PropertyBag
{
	// Methods

	// RVA: 0x1661D5C
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x16632F8
	public override string get_Name() { }

	// RVA: 0x1663250
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x166333C
	public override string get_Name() { }

	// RVA: 0x16632A4
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector2IntPropertyBag
{
	// Methods

	// RVA: 0x1661F68
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x166347C
	public override string get_Name() { }

	// RVA: 0x1663380
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x16634C0
	public override string get_Name() { }

	// RVA: 0x16633D4
	public void .ctor() { }

}

// Namespace: 
private class ZProperty
{
	// Methods

	// RVA: 0x1663504
	public override string get_Name() { }

	// RVA: 0x1663428
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class Vector3IntPropertyBag
{
	// Methods

	// RVA: 0x16620BC
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x1663698
	public override string get_Name() { }

	// RVA: 0x1663548
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x16636DC
	public override string get_Name() { }

	// RVA: 0x166359C
	public void .ctor() { }

}

// Namespace: 
private class WidthProperty
{
	// Methods

	// RVA: 0x1663720
	public override string get_Name() { }

	// RVA: 0x16635F0
	public void .ctor() { }

}

// Namespace: 
private class HeightProperty
{
	// Methods

	// RVA: 0x1663764
	public override string get_Name() { }

	// RVA: 0x1663644
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class RectPropertyBag
{
	// Methods

	// RVA: 0x166226C
	public void .ctor() { }

}

// Namespace: 
private class XProperty
{
	// Methods

	// RVA: 0x16638F8
	public override string get_Name() { }

	// RVA: 0x16637A8
	public void .ctor() { }

}

// Namespace: 
private class YProperty
{
	// Methods

	// RVA: 0x166393C
	public override string get_Name() { }

	// RVA: 0x16637FC
	public void .ctor() { }

}

// Namespace: 
private class WidthProperty
{
	// Methods

	// RVA: 0x1663980
	public override string get_Name() { }

	// RVA: 0x1663850
	public void .ctor() { }

}

// Namespace: 
private class HeightProperty
{
	// Methods

	// RVA: 0x16639C4
	public override string get_Name() { }

	// RVA: 0x16638A4
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class RectIntPropertyBag
{
	// Methods

	// RVA: 0x1662478
	public void .ctor() { }

}

// Namespace: 
private class CenterProperty
{
	// Methods

	// RVA: 0x1663AB0
	public override string get_Name() { }

	// RVA: 0x1663A08
	public void .ctor() { }

}

// Namespace: 
private class ExtentsProperty
{
	// Methods

	// RVA: 0x1663AF4
	public override string get_Name() { }

	// RVA: 0x1663A5C
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class BoundsPropertyBag
{
	// Methods

	// RVA: 0x1662684
	public void .ctor() { }

}

// Namespace: 
private class PositionProperty
{
	// Methods

	// RVA: 0x1663BE0
	public override string get_Name() { }

	// RVA: 0x1663B38
	public void .ctor() { }

}

// Namespace: 
private class SizeProperty
{
	// Methods

	// RVA: 0x1663C24
	public override string get_Name() { }

	// RVA: 0x1663B8C
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class BoundsIntPropertyBag
{
	// Methods

	// RVA: 0x16627D8
	public void .ctor() { }

}

// Namespace: 
private class MajorProperty
{
	// Methods

	// RVA: 0x1663C68
	public void .ctor() { }

	// RVA: 0x1663F18
	public override string get_Name() { }

}

// Namespace: 
private class MinorProperty
{
	// Methods

	// RVA: 0x1663D14
	public void .ctor() { }

	// RVA: 0x1663F5C
	public override string get_Name() { }

}

// Namespace: 
private class BuildProperty
{
	// Methods

	// RVA: 0x1663DC0
	public void .ctor() { }

	// RVA: 0x1663FA0
	public override string get_Name() { }

}

// Namespace: 
private class RevisionProperty
{
	// Methods

	// RVA: 0x1663E6C
	public void .ctor() { }

	// RVA: 0x1663FE4
	public override string get_Name() { }

}

// Namespace: Unity.Properties.Internal
internal class SystemVersionPropertyBag
{
	// Methods

	// RVA: 0x166292C
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

	// RVA: 0x1664028
	private static void .cctor() { }

	// RVA: 0x30A7C50
	internal static void AddPropertyBag(Unity.Properties.IPropertyBag<TContainer> propertyBag) { }

	// RVA: 0x30A5298
	internal static Unity.Properties.IPropertyBag<TContainer> GetPropertyBag() { }

	// RVA: 0x1660C38
	internal static IPropertyBag GetPropertyBag(Type type) { }

}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagAttribute
{
	// Methods

	// RVA: 0x16646E4
	public void .ctor() { }

}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBag<T0>
{
	// Methods

	// RVA: 0x30A27C0
	internal void AddProperty(Unity.Properties.Property<TContainer,TValue> property) { }

	// RVA: 0x30A2378
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

	// RVA: 0x16649F0
	private static void .cctor() { }

	// RVA: 0x1664A5C
	public void .ctor() { }

	// RVA: 0x1664A64
	internal bool <.ctor>b__10_0(MethodInfo x) { }

	// RVA: 0x1664AEC
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

	// RVA: 0x1664774
	public void .ctor(int <>1__state) { }

	// RVA: 0x1664B18
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1664C00
	private bool MoveNext() { }

	// RVA: 0x16655C0
	private void <>m__Finally1() { }

	// RVA: 0x1665684
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	// RVA: 0x166568C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x16656CC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x16656D4
	private System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	// RVA: 0x166577C
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

	// RVA: 0x1664174
	public void .ctor() { }

	// RVA: 0x16645A4
	public IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: 0x30A17DC
	public Unity.Properties.IPropertyBag<TContainer> CreatePropertyBag() { }

	// RVA: 0x30A2A20
	private void CreateProperty(IMemberInfo member, Unity.Properties.Internal.ReflectedPropertyBag<TContainer> propertyBag) { }

	// RVA: 0x30A17DC
	private Unity.Properties.IPropertyBag<TList> CreateIndexedCollectionPropertyBag() { }

	// RVA: 0x30A17DC
	private Unity.Properties.IPropertyBag<TSet> CreateSetPropertyBag() { }

	// RVA: 0x30A17DC
	private Unity.Properties.IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag() { }

	// RVA: 0x30A17DC
	private Unity.Properties.IPropertyBag<System.Collections.Generic.KeyValuePair<TKey,TValue>> CreateKeyValuePairPropertyBag() { }

	// RVA: 0x30A17DC
	private Unity.Properties.IPropertyBag<TElement[]> CreateArrayPropertyBag() { }

	// RVA: 0x30A17DC
	private Unity.Properties.IPropertyBag<System.Collections.Generic.List<TElement>> CreateListPropertyBag() { }

	// RVA: 0x30A17DC
	private Unity.Properties.IPropertyBag<System.Collections.Generic.HashSet<TElement>> CreateHashSetPropertyBag() { }

	// RVA: 0x30A17DC
	private Unity.Properties.IPropertyBag<System.Collections.Generic.Dictionary<TKey,TValue>> CreateDictionaryPropertyBag() { }

	// RVA: 0x16646EC
	private static System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetPropertyMembers(Type type) { }

	// RVA: 0x16647AC
	private static bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x16648F4
	private static bool IsValidPropertyType(Type type) { }

}

// Namespace: Unity.Properties.Internal
internal static class ReflectionUtilities
{
	// Methods

	// RVA: 0x165F58C
	public static string SanitizeMemberName(MemberInfo info) { }

}


