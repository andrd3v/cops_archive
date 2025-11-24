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

	// RVA: 0xA0D914
	public static string EnsureValidIdentifier(string varExpr, bool nested) { }

	// RVA: 0xA0D91C
	public static string EnsureValidIdentifier(string varExpr, bool nested, bool throwOnEmpty) { }

	// RVA: 0xA0DAB0
	public static bool IsValidIdentifier(string varExpr, bool nested) { }

	// RVA: 0xA0DCB4
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

	// RVA: 0xA0EC54
	public static bool IsJsonIgnore(object value) { }

	// RVA: 0xA0EE20
	public static bool IsXmlIgnore(object value) { }

	// RVA: 0xA0EFEC
	public void .ctor() { }

}

// Namespace: JsonFx.Json
public class JsonNameAttribute
{
	// Fields
	private string jsonName; // 0x10

	// Methods

	// RVA: 0xA0EFF4
	public void .ctor(string jsonName) { }

	// RVA: 0xA0F038
	public string get_Name() { }

	// RVA: 0xA0F040
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

	// RVA: 0xA0F290
	public void .ctor(string input) { }

	// RVA: 0xA0F3E0
	public void .ctor(string input, JsonReaderSettings settings) { }

	// RVA: 0x315B3A8
	public T Deserialize(T obj) { }

	// RVA: 0xA0F500
	public object Deserialize(int start, Type type) { }

	// RVA: 0xA0F514
	private object Read(Type expectedType, bool typeIsHint, object obj) { }

	// RVA: 0xA0F788
	private object ReadObject(Type objectType, object result) { }

	// RVA: 0xA100B4
	private IEnumerable ReadArray(Type arrayType) { }

	// RVA: 0xA129E8
	private string ReadUnquotedKey() { }

	// RVA: 0xA10570
	private object ReadString(Type expectedType) { }

	// RVA: 0xA10AB8
	private object ReadNumber(Type expectedType) { }

	// RVA: 0xA13A18
	public static object Deserialize(string value) { }

	// RVA: 0x315B3A8
	public static T Deserialize(string value) { }

	// RVA: 0x315B3A8
	public static T Deserialize(string value, T obj) { }

	// RVA: 0xA13B20
	public static object Deserialize(string value, Type type) { }

	// RVA: 0xA13A94
	public static object Deserialize(string value, int start, Type type) { }

	// RVA: 0xA0F780
	private JsonToken Tokenize() { }

	// RVA: 0xA12298
	private JsonToken Tokenize(bool allowUnquotedString) { }

	// RVA: 0xA13BA0
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

	// RVA: 0xA13C60
	public bool get_AllowUnquotedObjectKeys() { }

	// RVA: 0xA13C68
	public string get_TypeHintName() { }

	// RVA: 0xA12BA4
	internal bool IsTypeHintName(string name) { }

	// RVA: 0xA0F360
	public void .ctor() { }

}

// Namespace: JsonFx.Json
public class JsonSerializationException
{
	// Methods

	// RVA: 0xA13C80
	public void .ctor(string message) { }

}

// Namespace: JsonFx.Json
public class JsonDeserializationException
{
	// Fields
	private readonly int <Index>k__BackingField; // 0x8C

	// Methods

	// RVA: 0xA114E4
	public void .ctor(string message, int index) { }

}

// Namespace: JsonFx.Json
public class JsonTypeCoercionException
{
	// Methods

	// RVA: 0xA13C88
	public void .ctor(string message) { }

	// RVA: 0xA13C90
	public void .ctor(string message, Exception innerException) { }

}

// Namespace: JsonFx.Json
public class JsonSpecifiedPropertyAttribute
{
	// Fields
	private string <SpecifiedProperty>k__BackingField; // 0x10

	// Methods

	// RVA: 0xA13C98
	public string get_SpecifiedProperty() { }

	// RVA: 0xA13CA0
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

	// RVA: 0xA13DD8
	public void .ctor(TextWriter output, JsonWriterSettings settings) { }

	// RVA: 0xA13ED4
	public void .ctor(StringBuilder output) { }

	// RVA: 0xA1402C
	public void .ctor(StringBuilder output, JsonWriterSettings settings) { }

	// RVA: 0xA141A8
	protected int get_Depth() { }

	// RVA: 0xA141B0
	private void set_Depth(int value) { }

	// RVA: 0xA141B8
	public TextWriter get_TextWriter() { }

	// RVA: 0xA141C0
	public static string Serialize(object value) { }

	// RVA: 0xA14368
	public void Write(object value) { }

	// RVA: 0xA14378
	protected virtual void Write(object value, bool isProperty) { }

	// RVA: 0xA152C8
	public virtual void Write(DateTime value) { }

	// RVA: 0xA15474
	public virtual void Write(Guid value) { }

	// RVA: 0xA154F0
	public virtual void Write(Enum value) { }

	// RVA: 0xA15E74
	public virtual void Write(string value) { }

	// RVA: 0xA162D4
	public virtual void Write(bool value) { }

	// RVA: 0xA1635C
	public virtual void Write(Byte value) { }

	// RVA: 0xA16418
	public virtual void Write(SByte value) { }

	// RVA: 0xA164D4
	public virtual void Write(Int16 value) { }

	// RVA: 0xA16590
	public virtual void Write(UInt16 value) { }

	// RVA: 0xA1664C
	public virtual void Write(int value) { }

	// RVA: 0xA16708
	public virtual void Write(UInt32 value) { }

	// RVA: 0xA1686C
	public virtual void Write(Int64 value) { }

	// RVA: 0xA169D0
	public virtual void Write(UInt64 value) { }

	// RVA: 0xA16B34
	public virtual void Write(float value) { }

	// RVA: 0xA16C40
	public virtual void Write(Double value) { }

	// RVA: 0xA16D4C
	public virtual void Write(Decimal value) { }

	// RVA: 0xA16EEC
	public virtual void Write(Char value) { }

	// RVA: 0xA16F28
	public virtual void Write(TimeSpan value) { }

	// RVA: 0xA16F9C
	public virtual void Write(Uri value) { }

	// RVA: 0xA16FE4
	public virtual void Write(Version value) { }

	// RVA: 0xA1702C
	public virtual void Write(XmlNode value) { }

	// RVA: 0xA17078
	protected internal virtual void WriteArray(IEnumerable value) { }

	// RVA: 0xA17544
	protected virtual void WriteArrayItem(object item) { }

	// RVA: 0xA17554
	protected virtual void WriteObject(IDictionary value) { }

	// RVA: 0xA17564
	protected virtual void WriteDictionary(IEnumerable value) { }

	// RVA: 0xA17A08
	private void WriteObjectProperty(string key, object value) { }

	// RVA: 0xA17A90
	protected virtual void WriteObjectPropertyName(string name) { }

	// RVA: 0xA17A9C
	protected virtual void WriteObjectPropertyValue(object value) { }

	// RVA: 0xA17AAC
	protected virtual void WriteObject(object value, Type type) { }

	// RVA: 0xA185E8
	protected virtual void WriteArrayItemDelim() { }

	// RVA: 0xA18614
	protected virtual void WriteObjectPropertyDelim() { }

	// RVA: 0xA18640
	protected virtual void WriteLine() { }

	// RVA: 0xA18264
	private bool IsIgnored(Type objType, MemberInfo member, object obj) { }

	// RVA: 0xA18484
	private bool IsDefaultValue(MemberInfo member, object value) { }

	// RVA: 0xA15B2C
	private static Enum[] GetFlagList(Type enumType, object value) { }

	// RVA: 0xA186EC
	protected virtual bool InvalidIeee754(Decimal value) { }

	// RVA: 0xA18804
	private void System.IDisposable.Dispose() { }

}

// Namespace: JsonFx.Json
public sealed class WriteDelegate<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
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

	// RVA: 0xA18818
	public virtual string get_TypeHintName() { }

	// RVA: 0xA18820
	public virtual bool get_PrettyPrint() { }

	// RVA: 0xA18828
	public virtual void set_PrettyPrint(bool value) { }

	// RVA: 0xA18830
	public virtual string get_Tab() { }

	// RVA: 0xA18838
	public virtual void set_Tab(string value) { }

	// RVA: 0xA18840
	public virtual string get_NewLine() { }

	// RVA: 0xA18848
	public virtual void set_NewLine(string value) { }

	// RVA: 0xA18850
	public virtual int get_MaxDepth() { }

	// RVA: 0xA18858
	public virtual bool get_UseXmlSerializationAttributes() { }

	// RVA: 0xA18860
	public virtual JsonFx.Json.WriteDelegate<System.DateTime> get_DateTimeSerializer() { }

	// RVA: 0xA18868
	public virtual bool get_SerializeEnumsByUnderlyingValue() { }

	// RVA: 0xA13FA8
	public void .ctor() { }

}

// Namespace: JsonFx.Json
internal class TypeCoercionUtility
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>> memberMapCache; // 0x10
	private bool <AllowNullValueTypes>k__BackingField; // 0x18

	// Methods

	// RVA: 0xA18870
	private System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>> get_MemberMapCache() { }

	// RVA: 0xA1890C
	public bool get_AllowNullValueTypes() { }

	// RVA: 0xA12CB0
	internal object ProcessTypeHint(IDictionary result, string typeInfo, Type objectType, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA11518
	internal object InstantiateObject(Type objectType, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA11E04
	internal System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo> CreateMemberMap(Type objectType) { }

	// RVA: 0xA12A44
	internal static Type GetMemberInfo(System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo> memberMap, string memberName, MemberInfo memberInfo) { }

	// RVA: 0xA12DFC
	internal void SetMemberValue(object result, Type memberType, MemberInfo memberInfo, object value) { }

	// RVA: 0xA12F3C
	internal object CoerceType(Type targetType, object value) { }

	// RVA: 0xA18914
	private object CoerceType(Type targetType, IDictionary value, System.Collections.Generic.Dictionary<System.String,System.Reflection.MemberInfo>& memberMap) { }

	// RVA: 0xA18E28
	private object CoerceList(Type targetType, Type arrayType, IEnumerable value) { }

	// RVA: 0xA19BD0
	private Array CoerceArray(Type elementType, IEnumerable value) { }

	// RVA: 0xA18D60
	private static bool IsNullable(Type type) { }

	// RVA: 0xA13C70
	public void .ctor() { }

}


