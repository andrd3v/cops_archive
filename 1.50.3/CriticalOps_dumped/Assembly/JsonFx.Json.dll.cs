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

	// RVA: 0xA35BF8
	public static string EnsureValidIdentifier(string varExpr, bool nested) { }

	// RVA: 0xA35C00
	public static string EnsureValidIdentifier(string varExpr, bool nested, bool throwOnEmpty) { }

	// RVA: 0xA35D94
	public static bool IsValidIdentifier(string varExpr, bool nested) { }

	// RVA: 0xA35F98
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

	// RVA: 0xA36F38
	public static bool IsJsonIgnore(object value) { }

	// RVA: 0xA37104
	public static bool IsXmlIgnore(object value) { }

	// RVA: 0xA372D0
	public void .ctor() { }

}

// Namespace: JsonFx.Json
public class JsonNameAttribute
{
	// Fields
	private string jsonName; // 0x10

	// Methods

	// RVA: 0xA372D8
	public void .ctor(string jsonName) { }

	// RVA: 0xA3731C
	public string get_Name() { }

	// RVA: 0xA37324
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

	// RVA: 0xA37574
	public void .ctor(string input) { }

	// RVA: 0xA376C4
	public void .ctor(string input, JsonReaderSettings settings) { }

	// RVA: 0x318DB98
	public T Deserialize(T obj) { }

	// RVA: 0xA377E4
	public object Deserialize(int start, Type type) { }

	// RVA: 0xA377F8
	private object Read(Type expectedType, bool typeIsHint, object obj) { }

	// RVA: 0xA37A6C
	private object ReadObject(Type objectType, object result) { }

	// RVA: 0xA38398
	private IEnumerable ReadArray(Type arrayType) { }

	// RVA: 0xA3ACCC
	private string ReadUnquotedKey() { }

	// RVA: 0xA38854
	private object ReadString(Type expectedType) { }

	// RVA: 0xA38D9C
	private object ReadNumber(Type expectedType) { }

	// RVA: 0xA3BCFC
	public static object Deserialize(string value) { }

	// RVA: 0x318DB98
	public static T Deserialize(string value) { }

	// RVA: 0x318DB98
	public static T Deserialize(string value, T obj) { }

	// RVA: 0xA3BE04
	public static object Deserialize(string value, Type type) { }

	// RVA: 0xA3BD78
	public static object Deserialize(string value, int start, Type type) { }

	// RVA: 0xA37A64
	private JsonToken Tokenize() { }

	// RVA: 0xA3A57C
	private JsonToken Tokenize(bool allowUnquotedString) { }

	// RVA: 0xA3BE84
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

	// RVA: 0xA3BF44
	public bool get_AllowUnquotedObjectKeys() { }

	// RVA: 0xA3BF4C
	public string get_TypeHintName() { }

	// RVA: 0xA3AE88
	internal bool IsTypeHintName(string name) { }

	// RVA: 0xA37644
	public void .ctor() { }

}

// Namespace: JsonFx.Json
public class JsonSerializationException
{
	// Methods

	// RVA: 0xA3BF64
	public void .ctor(string message) { }

}

// Namespace: JsonFx.Json
public class JsonDeserializationException
{
	// Fields
	private readonly int <Index>k__BackingField; // 0x8C

	// Methods

	// RVA: 0xA397C8
	public void .ctor(string message, int index) { }

}

// Namespace: JsonFx.Json
public class JsonTypeCoercionException
{
	// Methods

	// RVA: 0xA3BF6C
	public void .ctor(string message) { }

	// RVA: 0xA3BF74
	public void .ctor(string message, Exception innerException) { }

}

// Namespace: JsonFx.Json
public class JsonSpecifiedPropertyAttribute
{
	// Fields
	private string <SpecifiedProperty>k__BackingField; // 0x10

	// Methods

	// RVA: 0xA3BF7C
	public string get_SpecifiedProperty() { }

	// RVA: 0xA3BF84
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

	// RVA: 0xA3C0BC
	public void .ctor(TextWriter output, JsonWriterSettings settings) { }

	// RVA: 0xA3C1B8
	public void .ctor(StringBuilder output) { }

	// RVA: 0xA3C310
	public void .ctor(StringBuilder output, JsonWriterSettings settings) { }

	// RVA: 0xA3C48C
	protected int get_Depth() { }

	// RVA: 0xA3C494
	private void set_Depth(int value) { }

	// RVA: 0xA3C49C
	public TextWriter get_TextWriter() { }

	// RVA: 0xA3C4A4
	public static string Serialize(object value) { }

	// RVA: 0xA3C64C
	public void Write(object value) { }

	// RVA: 0xA3C65C
	protected virtual void Write(object value, bool isProperty) { }

	// RVA: 0xA3D5AC
	public virtual void Write(DateTime value) { }

	// RVA: 0xA3D758
	public virtual void Write(Guid value) { }

	// RVA: 0xA3D7D4
	public virtual void Write(Enum value) { }

	// RVA: 0xA3E158
	public virtual void Write(string value) { }

	// RVA: 0xA3E5B8
	public virtual void Write(bool value) { }

	// RVA: 0xA3E640
	public virtual void Write(Byte value) { }

	// RVA: 0xA3E6FC
	public virtual void Write(SByte value) { }

	// RVA: 0xA3E7B8
	public virtual void Write(Int16 value) { }

	// RVA: 0xA3E874
	public virtual void Write(UInt16 value) { }

	// RVA: 0xA3E930
	public virtual void Write(int value) { }

	// RVA: 0xA3E9EC
	public virtual void Write(UInt32 value) { }

	// RVA: 0xA3EB50
	public virtual void Write(Int64 value) { }

	// RVA: 0xA3ECB4
	public virtual void Write(UInt64 value) { }

	// RVA: 0xA3EE18
	public virtual void Write(float value) { }

	// RVA: 0xA3EF24
	public virtual void Write(Double value) { }

	// RVA: 0xA3F030
	public virtual void Write(Decimal value) { }

	// RVA: 0xA3F1D0
	public virtual void Write(Char value) { }

	// RVA: 0xA3F20C
	public virtual void Write(TimeSpan value) { }

	// RVA: 0xA3F280
	public virtual void Write(Uri value) { }

	// RVA: 0xA3F2C8
	public virtual void Write(Version value) { }

	// RVA: 0xA3F310
	public virtual void Write(XmlNode value) { }

	// RVA: 0xA3F35C
	protected internal virtual void WriteArray(IEnumerable value) { }

	// RVA: 0xA3F828
	protected virtual void WriteArrayItem(object item) { }

	// RVA: 0xA3F838
	protected virtual void WriteObject(IDictionary value) { }

	// RVA: 0xA3F848
	protected virtual void WriteDictionary(IEnumerable value) { }

	// RVA: 0xA3FCEC
	private void WriteObjectProperty(string key, object value) { }

	// RVA: 0xA3FD74
	protected virtual void WriteObjectPropertyName(string name) { }

	// RVA: 0xA3FD80
	protected virtual void WriteObjectPropertyValue(object value) { }

	// RVA: 0xA3FD90
	protected virtual void WriteObject(object value, Type type) { }

	// RVA: 0xA408CC
	protected virtual void WriteArrayItemDelim() { }

	// RVA: 0xA408F8
	protected virtual void WriteObjectPropertyDelim() { }

	// RVA: 0xA40924
	protected virtual void WriteLine() { }

	// RVA: 0xA40548
	private bool IsIgnored(Type objType, MemberInfo member, object obj) { }

	// RVA: 0xA40768
	private bool IsDefaultValue(MemberInfo member, object value) { }

	// RVA: 0xA3DE10
	private static Enum[] GetFlagList(Type enumType, object value) { }

	// RVA: 0xA409D0
	protected virtual bool InvalidIeee754(Decimal value) { }

	// RVA: 0xA40AE8
	private void System.IDisposable.Dispose() { }

}

// Namespace: JsonFx.Json
public sealed class WriteDelegate<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
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

	// RVA: 0xA40AFC
	public virtual string get_TypeHintName() { }

	// RVA: 0xA40B04
	public virtual bool get_PrettyPrint() { }

	// RVA: 0xA40B0C
	public virtual void set_PrettyPrint(bool value) { }

	// RVA: 0xA40B14
	public virtual string get_Tab() { }

	// RVA: 0xA40B1C
	public virtual void set_Tab(string value) { }

	// RVA: 0xA40B24
	public virtual string get_NewLine() { }

	// RVA: 0xA40B2C
	public virtual void set_NewLine(string value) { }

	// RVA: 0xA40B34
	public virtual int get_MaxDepth() { }

	// RVA: 0xA40B3C
	public virtual bool get_UseXmlSerializationAttributes() { }

	// RVA: 0xA40B44
	public virtual JsonFx.Json.WriteDelegate<System.DateTime> get_DateTimeSerializer() { }

	// RVA: 0xA40B4C
	public virtual bool get_SerializeEnumsByUnderlyingValue() { }

	// RVA: 0xA3C28C
	public void .ctor() { }

}

// Namespace: JsonFx.Json
internal class TypeCoercionUtility
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>> memberMapCache; // 0x10
	private bool <AllowNullValueTypes>k__BackingField; // 0x18

	// Methods

	// RVA: 0xA40B54
	private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>> get_MemberMapCache() { }

	// RVA: 0xA40BF0
	public bool get_AllowNullValueTypes() { }

	// RVA: 0xA3AF94
	internal object ProcessTypeHint(IDictionary result, string typeInfo, Type objectType, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA397FC
	internal object InstantiateObject(Type objectType, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA3A0E8
	internal System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo> CreateMemberMap(Type objectType) { }

	// RVA: 0xA3AD28
	internal static Type GetMemberInfo(System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo> memberMap, string memberName, MemberInfo memberInfo) { }

	// RVA: 0xA3B0E0
	internal void SetMemberValue(object result, Type memberType, MemberInfo memberInfo, object value) { }

	// RVA: 0xA3B220
	internal object CoerceType(Type targetType, object value) { }

	// RVA: 0xA40BF8
	private object CoerceType(Type targetType, IDictionary value, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA4110C
	private object CoerceList(Type targetType, Type arrayType, IEnumerable value) { }

	// RVA: 0xA41EB4
	private Array CoerceArray(Type elementType, IEnumerable value) { }

	// RVA: 0xA41044
	private static bool IsNullable(Type type) { }

	// RVA: 0xA3BF54
	public void .ctor() { }

}


