// Namespace: 
internal class <Module> 
{}

// Namespace: JsonFx.Json
public class EcmaScriptIdentifier 
{
	// Methods

	// RVA: 0x9E5038
	string EnsureValidIdentifier(string varExpr, bool nested) { }

	// RVA: 0x9E5040
	string EnsureValidIdentifier(string varExpr, bool nested, bool throwOnEmpty) { }

	// RVA: 0x9E51D4
	bool IsValidIdentifier(string varExpr, bool nested) { }

	// RVA: 0x9E540C
	bool IsReservedWord(string varExpr) { }

}

// Namespace: JsonFx.Json
public interface IJsonSerializable 
{
	// Methods

	// RVA: 0x2FE4574
	void WriteJson(JsonWriter writer) { }

}

// Namespace: JsonFx.Json
public sealed class JsonIgnoreAttribute 
{
	// Methods

	// RVA: 0x9E68F0
	bool IsJsonIgnore(object value) { }

	// RVA: 0x9E6ABC
	bool IsXmlIgnore(object value) { }

	// RVA: 0x9E6C88
	void .ctor() { }

}

// Namespace: JsonFx.Json
public class JsonNameAttribute 
{
	// Fields
	private string jsonName; // 0x10

	// Methods

	// RVA: 0x9E6C90
	void .ctor(string jsonName) { }

	// RVA: 0x9E6CD4
	string get_Name() { }

	// RVA: 0x9E6CDC
	string GetJsonName(object value) { }

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

	// RVA: 0x9E6F2C
	void .ctor(string input) { }

	// RVA: 0x9E707C
	void .ctor(string input, JsonReaderSettings settings) { }

	// RVA: 0x309AF8C
	T Deserialize(T obj) { }

	// RVA: 0x9E719C
	object Deserialize(int start, Type type) { }

	// RVA: 0x9E71B0
	object Read(Type expectedType, bool typeIsHint, object obj) { }

	// RVA: 0x9E74EC
	object ReadObject(Type objectType, object result) { }

	// RVA: 0x9E7E78
	IEnumerable ReadArray(Type arrayType) { }

	// RVA: 0x9EA61C
	string ReadUnquotedKey() { }

	// RVA: 0x9E8334
	object ReadString(Type expectedType) { }

	// RVA: 0x9E8814
	object ReadNumber(Type expectedType) { }

	// RVA: 0x9EB720
	object Deserialize(string value) { }

	// RVA: 0x309AF8C
	T Deserialize(string value) { }

	// RVA: 0x309AF8C
	T Deserialize(string value, T obj) { }

	// RVA: 0x9EB828
	object Deserialize(string value, Type type) { }

	// RVA: 0x9EB79C
	object Deserialize(string value, int start, Type type) { }

	// RVA: 0x9E74E4
	JsonToken Tokenize() { }

	// RVA: 0x9E9ECC
	JsonToken Tokenize(bool allowUnquotedString) { }

	// RVA: 0x9EB8A8
	bool MatchLiteral(string literal) { }

}

// Namespace: JsonFx.Json
public class JsonReaderSettings 
{
	// Fields
	internal readonly TypeCoercionUtility Coercion; // 0x10
	private bool allowUnquotedObjectKeys; // 0x18
	private string typeHintName; // 0x20

	// Methods

	// RVA: 0x9EB968
	bool get_AllowUnquotedObjectKeys() { }

	// RVA: 0x9EA7F8
	bool IsTypeHintName(string name) { }

	// RVA: 0x9E6FFC
	void .ctor() { }

}

// Namespace: JsonFx.Json
public class JsonSerializationException 
{
	// Methods

	// RVA: 0x9EB980
	void .ctor(string message) { }

}

// Namespace: JsonFx.Json
public class JsonDeserializationException 
{
	// Fields
	private int index; // 0x8C

	// Methods

	// RVA: 0x9E9118
	void .ctor(string message, int index) { }

}

// Namespace: JsonFx.Json
public class JsonTypeCoercionException 
{
	// Methods

	// RVA: 0x9EB988
	void .ctor(string message) { }

	// RVA: 0x9EB990
	void .ctor(string message, Exception innerException) { }

}

// Namespace: JsonFx.Json
public class JsonSpecifiedPropertyAttribute 
{
	// Fields
	private string specifiedProperty; // 0x10

	// Methods

	// RVA: 0x9EB998
	string get_SpecifiedProperty() { }

	// RVA: 0x9EB9A0
	string GetJsonSpecifiedProperty(MemberInfo memberInfo) { }

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
	private readonly TextWriter Writer; // 0x10
	private JsonWriterSettings settings; // 0x18
	private int depth; // 0x20

	// Methods

	// RVA: 0x9EBAD8
	void .ctor(TextWriter output, JsonWriterSettings settings) { }

	// RVA: 0x9EBBD4
	void .ctor(StringBuilder output) { }

	// RVA: 0x9EBD2C
	void .ctor(StringBuilder output, JsonWriterSettings settings) { }

	// RVA: 0x9EBEA8
	string Serialize(object value) { }

	// RVA: 0x9EC050
	void Write(object value) { }

	// RVA: 0x9EC060
	void Write(object value, bool isProperty) { }

	// RVA: 0x9ECFE0
	void Write(DateTime value) { }

	// RVA: 0x9ED18C
	void Write(Guid value) { }

	// RVA: 0x9ED208
	void Write(Enum value) { }

	// RVA: 0x9ED7E4
	void Write(string value) { }

	// RVA: 0x9EDBB0
	void Write(bool value) { }

	// RVA: 0x9EDC38
	void Write(Byte value) { }

	// RVA: 0x9EDCF4
	void Write(SByte value) { }

	// RVA: 0x9EDDB0
	void Write(Int16 value) { }

	// RVA: 0x9EDE6C
	void Write(UInt16 value) { }

	// RVA: 0x9EDF28
	void Write(int value) { }

	// RVA: 0x9EDFE4
	void Write(UInt32 value) { }

	// RVA: 0x9EE148
	void Write(Int64 value) { }

	// RVA: 0x9EE2AC
	void Write(UInt64 value) { }

	// RVA: 0x9EE410
	void Write(float value) { }

	// RVA: 0x9EE51C
	void Write(Double value) { }

	// RVA: 0x9EE628
	void Write(Decimal value) { }

	// RVA: 0x9EE7C8
	void Write(Char value) { }

	// RVA: 0x9EE804
	void Write(TimeSpan value) { }

	// RVA: 0x9EE878
	void Write(Uri value) { }

	// RVA: 0x9EE8C0
	void Write(Version value) { }

	// RVA: 0x9EE908
	void Write(XmlNode value) { }

	// RVA: 0x9EE954
	void WriteArray(IEnumerable value) { }

	// RVA: 0x9EEE20
	void WriteArrayItem(object item) { }

	// RVA: 0x9EEE30
	void WriteObject(IDictionary value) { }

	// RVA: 0x9EEE40
	void WriteDictionary(IEnumerable value) { }

	// RVA: 0x9EF2E4
	void WriteObjectProperty(string key, object value) { }

	// RVA: 0x9EF36C
	void WriteObjectPropertyName(string name) { }

	// RVA: 0x9EF378
	void WriteObjectPropertyValue(object value) { }

	// RVA: 0x9EF388
	void WriteObject(object value, Type type) { }

	// RVA: 0x9EFEC4
	void WriteArrayItemDelim() { }

	// RVA: 0x9EFEF0
	void WriteObjectPropertyDelim() { }

	// RVA: 0x9EFF1C
	void WriteLine() { }

	// RVA: 0x9EFB40
	bool IsIgnored(Type objType, MemberInfo member, object obj) { }

	// RVA: 0x9EFD60
	bool IsDefaultValue(MemberInfo member, object value) { }

	// RVA: 0x9ED49C
	Enum[] GetFlagList(Type enumType, object value) { }

	// RVA: 0x9EFFC8
	bool InvalidIeee754(Decimal value) { }

	// RVA: 0x9F00E0
	void System.IDisposable.Dispose() { }

}

// Namespace: JsonFx.Json
public sealed class WriteDelegate<T0> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(JsonWriter writer, T value) { }

}

// Namespace: JsonFx.Json
public class JsonWriterSettings 
{
	// Fields
	private JsonFx.Json.WriteDelegate<System.DateTime> dateTimeSerializer; // 0x10
	private int maxDepth; // 0x18
	private string newLine; // 0x20
	private bool prettyPrint; // 0x28
	private string tab; // 0x30
	private string typeHintName; // 0x38
	private bool useXmlSerializationAttributes; // 0x40

	// Methods

	// RVA: 0x9F00F4
	string get_TypeHintName() { }

	// RVA: 0x9F00FC
	bool get_PrettyPrint() { }

	// RVA: 0x9F0104
	void set_PrettyPrint(bool value) { }

	// RVA: 0x9F010C
	string get_Tab() { }

	// RVA: 0x9F0114
	void set_Tab(string value) { }

	// RVA: 0x9F011C
	string get_NewLine() { }

	// RVA: 0x9F0124
	void set_NewLine(string value) { }

	// RVA: 0x9F012C
	int get_MaxDepth() { }

	// RVA: 0x9F0134
	bool get_UseXmlSerializationAttributes() { }

	// RVA: 0x9F013C
	JsonFx.Json.WriteDelegate<System.DateTime> get_DateTimeSerializer() { }

	// RVA: 0x9EBCA8
	void .ctor() { }

}

// Namespace: JsonFx.Json
internal class TypeCoercionUtility 
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>> memberMapCache; // 0x10
	private bool allowNullValueTypes; // 0x18

	// Methods

	// RVA: 0x9F0144
	System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>> get_MemberMapCache() { }

	// RVA: 0x9EA904
	object ProcessTypeHint(IDictionary result, string typeInfo, out Type objectType, out System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0x9E914C
	object InstantiateObject(Type objectType, out System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0x9E9A38
	System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo> CreateMemberMap(Type objectType) { }

	// RVA: 0x9EA678
	Type GetMemberInfo(System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo> memberMap, string memberName, out MemberInfo memberInfo) { }

	// RVA: 0x9EAA50
	void SetMemberValue(object result, Type memberType, MemberInfo memberInfo, object value) { }

	// RVA: 0x9EABEC
	object CoerceType(Type targetType, object value) { }

	// RVA: 0x9F01E0
	object CoerceType(Type targetType, IDictionary value, out System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0x9F06F4
	object CoerceList(Type targetType, Type arrayType, IEnumerable value) { }

	// RVA: 0x9F1484
	Array CoerceArray(Type elementType, IEnumerable value) { }

	// RVA: 0x9F062C
	bool IsNullable(Type type) { }

	// RVA: 0x9EB970
	void .ctor() { }

}

// Namespace: 
internal sealed class <PrivateImplementationDetails> 
{
	// Methods

	// RVA: 0x9E6864
	UInt32 ComputeStringHash(string s) { }

}


