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

	// RVA: 0xA1CB94
	public static string EnsureValidIdentifier(string varExpr, bool nested) { }

	// RVA: 0xA1CB9C
	public static string EnsureValidIdentifier(string varExpr, bool nested, bool throwOnEmpty) { }

	// RVA: 0xA1CD30
	public static bool IsValidIdentifier(string varExpr, bool nested) { }

	// RVA: 0xA1CF34
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

	// RVA: 0xA1DED4
	public static bool IsJsonIgnore(object value) { }

	// RVA: 0xA1E0A0
	public static bool IsXmlIgnore(object value) { }

	// RVA: 0xA1E26C
	public void .ctor() { }

}

// Namespace: JsonFx.Json
public class JsonNameAttribute
{
	// Fields
	private string jsonName; // 0x10

	// Methods

	// RVA: 0xA1E274
	public void .ctor(string jsonName) { }

	// RVA: 0xA1E2B8
	public string get_Name() { }

	// RVA: 0xA1E2C0
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

	// RVA: 0xA1E510
	public void .ctor(string input) { }

	// RVA: 0xA1E660
	public void .ctor(string input, JsonReaderSettings settings) { }

	// RVA: 0x316B894
	public T Deserialize(T obj) { }

	// RVA: 0xA1E780
	public object Deserialize(int start, Type type) { }

	// RVA: 0xA1E794
	private object Read(Type expectedType, bool typeIsHint, object obj) { }

	// RVA: 0xA1EA08
	private object ReadObject(Type objectType, object result) { }

	// RVA: 0xA1F334
	private IEnumerable ReadArray(Type arrayType) { }

	// RVA: 0xA21C68
	private string ReadUnquotedKey() { }

	// RVA: 0xA1F7F0
	private object ReadString(Type expectedType) { }

	// RVA: 0xA1FD38
	private object ReadNumber(Type expectedType) { }

	// RVA: 0xA22C98
	public static object Deserialize(string value) { }

	// RVA: 0x316B894
	public static T Deserialize(string value) { }

	// RVA: 0x316B894
	public static T Deserialize(string value, T obj) { }

	// RVA: 0xA22DA0
	public static object Deserialize(string value, Type type) { }

	// RVA: 0xA22D14
	public static object Deserialize(string value, int start, Type type) { }

	// RVA: 0xA1EA00
	private JsonToken Tokenize() { }

	// RVA: 0xA21518
	private JsonToken Tokenize(bool allowUnquotedString) { }

	// RVA: 0xA22E20
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

	// RVA: 0xA22EE0
	public bool get_AllowUnquotedObjectKeys() { }

	// RVA: 0xA22EE8
	public string get_TypeHintName() { }

	// RVA: 0xA21E24
	internal bool IsTypeHintName(string name) { }

	// RVA: 0xA1E5E0
	public void .ctor() { }

}

// Namespace: JsonFx.Json
public class JsonSerializationException
{
	// Methods

	// RVA: 0xA22F00
	public void .ctor(string message) { }

}

// Namespace: JsonFx.Json
public class JsonDeserializationException
{
	// Fields
	private readonly int <Index>k__BackingField; // 0x8C

	// Methods

	// RVA: 0xA20764
	public void .ctor(string message, int index) { }

}

// Namespace: JsonFx.Json
public class JsonTypeCoercionException
{
	// Methods

	// RVA: 0xA22F08
	public void .ctor(string message) { }

	// RVA: 0xA22F10
	public void .ctor(string message, Exception innerException) { }

}

// Namespace: JsonFx.Json
public class JsonSpecifiedPropertyAttribute
{
	// Fields
	private string <SpecifiedProperty>k__BackingField; // 0x10

	// Methods

	// RVA: 0xA22F18
	public string get_SpecifiedProperty() { }

	// RVA: 0xA22F20
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

	// RVA: 0xA23058
	public void .ctor(TextWriter output, JsonWriterSettings settings) { }

	// RVA: 0xA23154
	public void .ctor(StringBuilder output) { }

	// RVA: 0xA232AC
	public void .ctor(StringBuilder output, JsonWriterSettings settings) { }

	// RVA: 0xA23428
	protected int get_Depth() { }

	// RVA: 0xA23430
	private void set_Depth(int value) { }

	// RVA: 0xA23438
	public TextWriter get_TextWriter() { }

	// RVA: 0xA23440
	public static string Serialize(object value) { }

	// RVA: 0xA235E8
	public void Write(object value) { }

	// RVA: 0xA235F8
	protected virtual void Write(object value, bool isProperty) { }

	// RVA: 0xA24548
	public virtual void Write(DateTime value) { }

	// RVA: 0xA246F4
	public virtual void Write(Guid value) { }

	// RVA: 0xA24770
	public virtual void Write(Enum value) { }

	// RVA: 0xA250F4
	public virtual void Write(string value) { }

	// RVA: 0xA25554
	public virtual void Write(bool value) { }

	// RVA: 0xA255DC
	public virtual void Write(Byte value) { }

	// RVA: 0xA25698
	public virtual void Write(SByte value) { }

	// RVA: 0xA25754
	public virtual void Write(Int16 value) { }

	// RVA: 0xA25810
	public virtual void Write(UInt16 value) { }

	// RVA: 0xA258CC
	public virtual void Write(int value) { }

	// RVA: 0xA25988
	public virtual void Write(UInt32 value) { }

	// RVA: 0xA25AEC
	public virtual void Write(Int64 value) { }

	// RVA: 0xA25C50
	public virtual void Write(UInt64 value) { }

	// RVA: 0xA25DB4
	public virtual void Write(float value) { }

	// RVA: 0xA25EC0
	public virtual void Write(Double value) { }

	// RVA: 0xA25FCC
	public virtual void Write(Decimal value) { }

	// RVA: 0xA2616C
	public virtual void Write(Char value) { }

	// RVA: 0xA261A8
	public virtual void Write(TimeSpan value) { }

	// RVA: 0xA2621C
	public virtual void Write(Uri value) { }

	// RVA: 0xA26264
	public virtual void Write(Version value) { }

	// RVA: 0xA262AC
	public virtual void Write(XmlNode value) { }

	// RVA: 0xA262F8
	protected internal virtual void WriteArray(IEnumerable value) { }

	// RVA: 0xA267C4
	protected virtual void WriteArrayItem(object item) { }

	// RVA: 0xA267D4
	protected virtual void WriteObject(IDictionary value) { }

	// RVA: 0xA267E4
	protected virtual void WriteDictionary(IEnumerable value) { }

	// RVA: 0xA26C88
	private void WriteObjectProperty(string key, object value) { }

	// RVA: 0xA26D10
	protected virtual void WriteObjectPropertyName(string name) { }

	// RVA: 0xA26D1C
	protected virtual void WriteObjectPropertyValue(object value) { }

	// RVA: 0xA26D2C
	protected virtual void WriteObject(object value, Type type) { }

	// RVA: 0xA27868
	protected virtual void WriteArrayItemDelim() { }

	// RVA: 0xA27894
	protected virtual void WriteObjectPropertyDelim() { }

	// RVA: 0xA278C0
	protected virtual void WriteLine() { }

	// RVA: 0xA274E4
	private bool IsIgnored(Type objType, MemberInfo member, object obj) { }

	// RVA: 0xA27704
	private bool IsDefaultValue(MemberInfo member, object value) { }

	// RVA: 0xA24DAC
	private static Enum[] GetFlagList(Type enumType, object value) { }

	// RVA: 0xA2796C
	protected virtual bool InvalidIeee754(Decimal value) { }

	// RVA: 0xA27A84
	private void System.IDisposable.Dispose() { }

}

// Namespace: JsonFx.Json
public sealed class WriteDelegate<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
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

	// RVA: 0xA27A98
	public virtual string get_TypeHintName() { }

	// RVA: 0xA27AA0
	public virtual bool get_PrettyPrint() { }

	// RVA: 0xA27AA8
	public virtual void set_PrettyPrint(bool value) { }

	// RVA: 0xA27AB0
	public virtual string get_Tab() { }

	// RVA: 0xA27AB8
	public virtual void set_Tab(string value) { }

	// RVA: 0xA27AC0
	public virtual string get_NewLine() { }

	// RVA: 0xA27AC8
	public virtual void set_NewLine(string value) { }

	// RVA: 0xA27AD0
	public virtual int get_MaxDepth() { }

	// RVA: 0xA27AD8
	public virtual bool get_UseXmlSerializationAttributes() { }

	// RVA: 0xA27AE0
	public virtual JsonFx.Json.WriteDelegate<System.DateTime> get_DateTimeSerializer() { }

	// RVA: 0xA27AE8
	public virtual bool get_SerializeEnumsByUnderlyingValue() { }

	// RVA: 0xA23228
	public void .ctor() { }

}

// Namespace: JsonFx.Json
internal class TypeCoercionUtility
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>> memberMapCache; // 0x10
	private bool <AllowNullValueTypes>k__BackingField; // 0x18

	// Methods

	// RVA: 0xA27AF0
	private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>> get_MemberMapCache() { }

	// RVA: 0xA27B8C
	public bool get_AllowNullValueTypes() { }

	// RVA: 0xA21F30
	internal object ProcessTypeHint(IDictionary result, string typeInfo, Type objectType, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA20798
	internal object InstantiateObject(Type objectType, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA21084
	internal System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo> CreateMemberMap(Type objectType) { }

	// RVA: 0xA21CC4
	internal static Type GetMemberInfo(System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo> memberMap, string memberName, MemberInfo memberInfo) { }

	// RVA: 0xA2207C
	internal void SetMemberValue(object result, Type memberType, MemberInfo memberInfo, object value) { }

	// RVA: 0xA221BC
	internal object CoerceType(Type targetType, object value) { }

	// RVA: 0xA27B94
	private object CoerceType(Type targetType, IDictionary value, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA280A8
	private object CoerceList(Type targetType, Type arrayType, IEnumerable value) { }

	// RVA: 0xA28E50
	private Array CoerceArray(Type elementType, IEnumerable value) { }

	// RVA: 0xA27FE0
	private static bool IsNullable(Type type) { }

	// RVA: 0xA22EF0
	public void .ctor() { }

}


