// Namespace: 
internal class <Module>
{}

// Namespace: JsonFx
public class JsonEnumAsStringAttribute
{}

// Namespace: JsonFx
public class JsonEnumAsUnderlyingValueAttribute
{}

// Namespace: JsonFx.Json
public class EcmaScriptIdentifier
{
	// Methods

	// RVA: 0xA7ED04
	public static string EnsureValidIdentifier(string varExpr, bool nested) { }

	// RVA: 0xA7ED0C
	public static string EnsureValidIdentifier(string varExpr, bool nested, bool throwOnEmpty) { }

	// RVA: 0xA7EE94
	public static bool IsValidIdentifier(string varExpr, bool nested) { }

	// RVA: 0xA7F074
	private static bool IsReservedWord(string varExpr) { }

}

// Namespace: JsonFx.Json
public interface IJsonSerializable
{
	// Methods

	// RVA: -1
	public abstract void WriteJson(JsonWriter writer) { }

}

// Namespace: JsonFx.Json
public sealed class JsonIgnoreAttribute
{
	// Methods

	// RVA: 0xA80014
	public static bool IsJsonIgnore(object value) { }

	// RVA: 0xA801C0
	public static bool IsXmlIgnore(object value) { }

	// RVA: 0xA8036C
	public void .ctor() { }

}

// Namespace: JsonFx.Json
public class JsonNameAttribute
{
	// Fields
	private string jsonName; // 0x10

	// Methods

	// RVA: 0xA80374
	public void .ctor(string jsonName) { }

	// RVA: 0xA803B8
	public string get_Name() { }

	// RVA: 0xA803C0
	public static string GetJsonName(object value) { }

}

// Namespace: JsonFx.Json
public class JsonReader
{
	// Fields
	private readonly JsonReaderSettings Settings; // 0x10
	private readonly string Source; // 0x18
	private readonly int SourceLength; // 0x20
	private int index; // 0x24

	// Methods

	// RVA: 0xA805F0
	public void .ctor(string input) { }

	// RVA: 0xA80740
	public void .ctor(string input, JsonReaderSettings settings) { }

	// RVA: 0x26AD93C
	public T Deserialize(T obj) { }

	// RVA: 0xA80860
	public object Deserialize(int start, Type type) { }

	// RVA: 0xA80874
	private object Read(Type expectedType, bool typeIsHint, object obj) { }

	// RVA: 0xA80A90
	private object ReadObject(Type objectType, object result) { }

	// RVA: 0xA81374
	private IEnumerable ReadArray(Type arrayType) { }

	// RVA: 0xA83BF8
	private string ReadUnquotedKey() { }

	// RVA: 0xA81814
	private object ReadString(Type expectedType) { }

	// RVA: 0xA81D34
	private object ReadNumber(Type expectedType) { }

	// RVA: 0xA84B94
	public static object Deserialize(string value) { }

	// RVA: 0x26AD93C
	public static T Deserialize(string value) { }

	// RVA: 0x26AD93C
	public static T Deserialize(string value, T obj) { }

	// RVA: 0xA84C9C
	public static object Deserialize(string value, Type type) { }

	// RVA: 0xA84C10
	public static object Deserialize(string value, int start, Type type) { }

	// RVA: 0xA80A88
	private JsonToken Tokenize() { }

	// RVA: 0xA834B4
	private JsonToken Tokenize(bool allowUnquotedString) { }

	// RVA: 0xA84D1C
	private bool MatchLiteral(string literal) { }

}

// Namespace: JsonFx.Json
public class JsonReaderSettings
{
	// Fields
	internal readonly TypeCoercionUtility Coercion; // 0x10
	private bool <AllowUnquotedObjectKeys>k__BackingField; // 0x18
	private string <TypeHintName>k__BackingField; // 0x20

	// Methods

	// RVA: 0xA84DDC
	public bool get_AllowUnquotedObjectKeys() { }

	// RVA: 0xA84DE4
	public string get_TypeHintName() { }

	// RVA: 0xA83DB4
	internal bool IsTypeHintName(string name) { }

	// RVA: 0xA806C0
	public void .ctor() { }

}

// Namespace: JsonFx.Json
public class JsonSerializationException
{
	// Methods

	// RVA: 0xA84DFC
	public void .ctor(string message) { }

}

// Namespace: JsonFx.Json
public class JsonDeserializationException
{
	// Fields
	private readonly int <Index>k__BackingField; // 0x8C

	// Methods

	// RVA: 0xA8270C
	public void .ctor(string message, int index) { }

}

// Namespace: JsonFx.Json
public class JsonTypeCoercionException
{
	// Methods

	// RVA: 0xA84E04
	public void .ctor(string message) { }

	// RVA: 0xA84E0C
	public void .ctor(string message, Exception innerException) { }

}

// Namespace: JsonFx.Json
public class JsonSpecifiedPropertyAttribute
{
	// Fields
	private string <SpecifiedProperty>k__BackingField; // 0x10

	// Methods

	// RVA: 0xA84E14
	public string get_SpecifiedProperty() { }

	// RVA: 0xA84E1C
	public static string GetJsonSpecifiedProperty(MemberInfo memberInfo) { }

}

// Namespace: JsonFx.Json
internal enum JsonToken
{
	// Fields
	public int value__; // 0x10
	public const JsonToken End = 0;
	public const JsonToken Undefined = 1;
	public const JsonToken Null = 2;
	public const JsonToken False = 3;
	public const JsonToken True = 4;
	public const JsonToken NaN = 5;
	public const JsonToken PositiveInfinity = 6;
	public const JsonToken NegativeInfinity = 7;
	public const JsonToken Number = 8;
	public const JsonToken String = 9;
	public const JsonToken ArrayStart = 10;
	public const JsonToken ArrayEnd = 11;
	public const JsonToken ObjectStart = 12;
	public const JsonToken ObjectEnd = 13;
	public const JsonToken NameDelim = 14;
	public const JsonToken ValueDelim = 15;
	public const JsonToken UnquotedName = 16;
}

// Namespace: JsonFx.Json
public class JsonWriter
{
	// Fields
	private JsonWriterSettings settings; // 0x10
	private int <Depth>k__BackingField; // 0x18
	private readonly TextWriter <TextWriter>k__BackingField; // 0x20

	// Methods

	// RVA: 0xA84F48
	public void .ctor(TextWriter output, JsonWriterSettings settings) { }

	// RVA: 0xA85044
	public void .ctor(StringBuilder output) { }

	// RVA: 0xA8519C
	public void .ctor(StringBuilder output, JsonWriterSettings settings) { }

	// RVA: 0xA85318
	protected int get_Depth() { }

	// RVA: 0xA85320
	private void set_Depth(int value) { }

	// RVA: 0xA85328
	public TextWriter get_TextWriter() { }

	// RVA: 0xA85330
	public static string Serialize(object value) { }

	// RVA: 0xA854D8
	public void Write(object value) { }

	// RVA: 0xA854E8
	protected virtual void Write(object value, bool isProperty) { }

	// RVA: 0xA862F4
	public virtual void Write(DateTime value) { }

	// RVA: 0xA864A0
	public virtual void Write(Guid value) { }

	// RVA: 0xA8651C
	public virtual void Write(Enum value) { }

	// RVA: 0xA86E78
	public virtual void Write(string value) { }

	// RVA: 0xA872CC
	public virtual void Write(bool value) { }

	// RVA: 0xA87354
	public virtual void Write(Byte value) { }

	// RVA: 0xA87410
	public virtual void Write(SByte value) { }

	// RVA: 0xA874CC
	public virtual void Write(Int16 value) { }

	// RVA: 0xA87588
	public virtual void Write(UInt16 value) { }

	// RVA: 0xA87644
	public virtual void Write(int value) { }

	// RVA: 0xA87700
	public virtual void Write(UInt32 value) { }

	// RVA: 0xA87864
	public virtual void Write(Int64 value) { }

	// RVA: 0xA879C8
	public virtual void Write(UInt64 value) { }

	// RVA: 0xA87B2C
	public virtual void Write(float value) { }

	// RVA: 0xA87C38
	public virtual void Write(Double value) { }

	// RVA: 0xA87D44
	public virtual void Write(Decimal value) { }

	// RVA: 0xA87EE4
	public virtual void Write(Char value) { }

	// RVA: 0xA87F20
	public virtual void Write(TimeSpan value) { }

	// RVA: 0xA87F94
	public virtual void Write(Uri value) { }

	// RVA: 0xA87FDC
	public virtual void Write(Version value) { }

	// RVA: 0xA88024
	public virtual void Write(XmlNode value) { }

	// RVA: 0xA88070
	protected internal virtual void WriteArray(IEnumerable value) { }

	// RVA: 0xA8853C
	protected virtual void WriteArrayItem(object item) { }

	// RVA: 0xA8854C
	protected virtual void WriteObject(IDictionary value) { }

	// RVA: 0xA8855C
	protected virtual void WriteDictionary(IEnumerable value) { }

	// RVA: 0xA88A00
	private void WriteObjectProperty(string key, object value) { }

	// RVA: 0xA88A88
	protected virtual void WriteObjectPropertyName(string name) { }

	// RVA: 0xA88A94
	protected virtual void WriteObjectPropertyValue(object value) { }

	// RVA: 0xA88AA4
	protected virtual void WriteObject(object value, Type type) { }

	// RVA: 0xA895B4
	protected virtual void WriteArrayItemDelim() { }

	// RVA: 0xA895E0
	protected virtual void WriteObjectPropertyDelim() { }

	// RVA: 0xA8960C
	protected virtual void WriteLine() { }

	// RVA: 0xA8925C
	private bool IsIgnored(Type objType, MemberInfo member, object obj) { }

	// RVA: 0xA89470
	private bool IsDefaultValue(MemberInfo member, object value) { }

	// RVA: 0xA86B3C
	private static Enum[] GetFlagList(Type enumType, object value) { }

	// RVA: 0xA896B8
	protected virtual bool InvalidIeee754(Decimal value) { }

	// RVA: 0xA897D0
	private void System.IDisposable.Dispose() { }

}

// Namespace: JsonFx.Json
public sealed class WriteDelegate<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(JsonWriter writer, T value) { }

}

// Namespace: JsonFx.Json
public class JsonWriterSettings
{
	// Fields
	private int maxDepth; // 0x10
	private string <TypeHintName>k__BackingField; // 0x18
	private bool <PrettyPrint>k__BackingField; // 0x20
	private string <Tab>k__BackingField; // 0x28
	private string <NewLine>k__BackingField; // 0x30
	private bool <UseXmlSerializationAttributes>k__BackingField; // 0x38
	private JsonFx.Json.WriteDelegate<System.DateTime> <DateTimeSerializer>k__BackingField; // 0x40
	private bool <SerializeEnumsByUnderlyingValue>k__BackingField; // 0x48

	// Methods

	// RVA: 0xA897E4
	public virtual string get_TypeHintName() { }

	// RVA: 0xA897EC
	public virtual bool get_PrettyPrint() { }

	// RVA: 0xA897F4
	public virtual void set_PrettyPrint(bool value) { }

	// RVA: 0xA897FC
	public virtual string get_Tab() { }

	// RVA: 0xA89804
	public virtual void set_Tab(string value) { }

	// RVA: 0xA8980C
	public virtual string get_NewLine() { }

	// RVA: 0xA89814
	public virtual void set_NewLine(string value) { }

	// RVA: 0xA8981C
	public virtual int get_MaxDepth() { }

	// RVA: 0xA89824
	public virtual bool get_UseXmlSerializationAttributes() { }

	// RVA: 0xA8982C
	public virtual JsonFx.Json.WriteDelegate<System.DateTime> get_DateTimeSerializer() { }

	// RVA: 0xA89834
	public virtual bool get_SerializeEnumsByUnderlyingValue() { }

	// RVA: 0xA85118
	public void .ctor() { }

}

// Namespace: JsonFx.Json
internal class TypeCoercionUtility
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>> memberMapCache; // 0x10
	private bool <AllowNullValueTypes>k__BackingField; // 0x18

	// Methods

	// RVA: 0xA8983C
	private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>> get_MemberMapCache() { }

	// RVA: 0xA898D8
	public bool get_AllowNullValueTypes() { }

	// RVA: 0xA83EC0
	internal object ProcessTypeHint(IDictionary result, string typeInfo, Type objectType, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA82740
	internal object InstantiateObject(Type objectType, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA83020
	internal System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo> CreateMemberMap(Type objectType) { }

	// RVA: 0xA83C54
	internal static Type GetMemberInfo(System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo> memberMap, string memberName, MemberInfo memberInfo) { }

	// RVA: 0xA84000
	internal void SetMemberValue(object result, Type memberType, MemberInfo memberInfo, object value) { }

	// RVA: 0xA84140
	internal object CoerceType(Type targetType, object value) { }

	// RVA: 0xA898E0
	private object CoerceType(Type targetType, IDictionary value, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA89DDC
	private object CoerceList(Type targetType, Type arrayType, IEnumerable value) { }

	// RVA: 0xA8AB68
	private Array CoerceArray(Type elementType, IEnumerable value) { }

	// RVA: 0xA89D20
	private static bool IsNullable(Type type) { }

	// RVA: 0xA84DEC
	public void .ctor() { }

}


