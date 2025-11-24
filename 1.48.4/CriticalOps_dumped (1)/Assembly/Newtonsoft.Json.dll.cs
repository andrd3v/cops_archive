// Namespace: 
internal class <Module> 
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute 
{
	// Methods

	// RVA: 0xD4ACD8
	void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class IsReadOnlyAttribute 
{
	// Methods

	// RVA: 0xD4ACE0
	void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute 
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xD4ACE8
	void .ctor(Byte ) { }

	// RVA: 0xD4AD74
	void .ctor(Byte[] ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute 
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0xD4ADA8
	void .ctor(Byte ) { }

}

// Namespace: System.Diagnostics.CodeAnalysis
internal sealed class NotNullAttribute 
{
	// Methods

	// RVA: 0xD4ADD4
	void .ctor() { }

}

// Namespace: System.Diagnostics.CodeAnalysis
internal sealed class NotNullWhenAttribute 
{
	// Fields
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD4ADDC
	void .ctor(bool returnValue) { }

}

// Namespace: Newtonsoft.Json
public enum ConstructorHandling 
{
	// Fields
	public int value__; // 0x10
	public const ConstructorHandling Default = 0;
	public const ConstructorHandling AllowNonPublicDefaultConstructor = 1;
}

// Namespace: Newtonsoft.Json
public enum DateFormatHandling 
{
	// Fields
	public int value__; // 0x10
	public const DateFormatHandling IsoDateFormat = 0;
	public const DateFormatHandling MicrosoftDateFormat = 1;
}

// Namespace: Newtonsoft.Json
public enum DateParseHandling 
{
	// Fields
	public int value__; // 0x10
	public const DateParseHandling None = 0;
	public const DateParseHandling DateTime = 1;
	public const DateParseHandling DateTimeOffset = 2;
}

// Namespace: Newtonsoft.Json
public enum DateTimeZoneHandling 
{
	// Fields
	public int value__; // 0x10
	public const DateTimeZoneHandling Local = 0;
	public const DateTimeZoneHandling Utc = 1;
	public const DateTimeZoneHandling Unspecified = 2;
	public const DateTimeZoneHandling RoundtripKind = 3;
}

// Namespace: 
private class Entry 
{
	// Fields
	internal readonly string Value; // 0x10
	internal readonly int HashCode; // 0x18
	internal Entry Next; // 0x20

	// Methods

	// RVA: 0xD4B518
	void .ctor(string value, int hashCode, Entry next) { }

}

// Namespace: Newtonsoft.Json
public class DefaultJsonNameTable 
{
	// Fields
	private static readonly int HashCodeRandomizer; // 0x0
	private int _count; // 0x10
	private Entry[] _entries; // 0x18
	private int _mask; // 0x20

	// Methods

	// RVA: 0xD4AE08
	void .cctor() { }

	// RVA: 0xD4AE5C
	void .ctor() { }

	// RVA: 0xD4AEE0
	string Get(Char[] key, int start, int length) { }

	// RVA: 0xD4B20C
	string Add(string key) { }

	// RVA: 0xD4B3E0
	string AddEntry(string str, int hashCode) { }

	// RVA: 0xD4B570
	void Grow() { }

	// RVA: 0xD4B130
	bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}

// Namespace: Newtonsoft.Json
public enum DefaultValueHandling 
{
	// Fields
	public int value__; // 0x10
	public const DefaultValueHandling Include = 0;
	public const DefaultValueHandling Ignore = 1;
	public const DefaultValueHandling Populate = 2;
	public const DefaultValueHandling IgnoreAndPopulate = 3;
}

// Namespace: Newtonsoft.Json
public enum FloatFormatHandling 
{
	// Fields
	public int value__; // 0x10
	public const FloatFormatHandling String = 0;
	public const FloatFormatHandling Symbol = 1;
	public const FloatFormatHandling DefaultValue = 2;
}

// Namespace: Newtonsoft.Json
public enum FloatParseHandling 
{
	// Fields
	public int value__; // 0x10
	public const FloatParseHandling Double = 0;
	public const FloatParseHandling Decimal = 1;
}

// Namespace: Newtonsoft.Json
public enum Formatting 
{
	// Fields
	public int value__; // 0x10
	public const Formatting None = 0;
	public const Formatting Indented = 1;
}

// Namespace: Newtonsoft.Json
public interface IArrayPool<T0> 
{
	// Methods

	// RVA: -1
	T[] Rent(int minimumLength) { }

	// RVA: 0x2FE4574
	void Return(T[] array) { }

}

// Namespace: Newtonsoft.Json
public interface IJsonLineInfo 
{
	// Methods

	// RVA: 0x2FE3054
	bool HasLineInfo() { }

	// RVA: 0x2FE32D4
	int get_LineNumber() { }

	// RVA: 0x2FE32D4
	int get_LinePosition() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonArrayAttribute 
{}

// Namespace: Newtonsoft.Json
public sealed class JsonConstructorAttribute 
{}

// Namespace: Newtonsoft.Json
public abstract class JsonContainerAttribute 
{
	// Fields
	private Type <ItemConverterType>k__BackingField; // 0x10
	private object[] <ItemConverterParameters>k__BackingField; // 0x18
	private NamingStrategy <NamingStrategyInstance>k__BackingField; // 0x20
	internal System.Nullable<System.Boolean> _isReference; // 0x28
	internal System.Nullable<System.Boolean> _itemIsReference; // 0x2A
	internal System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x2C
	internal System.Nullable<Newtonsoft.Json.TypeNameHandling> _itemTypeNameHandling; // 0x34
	private Type _namingStrategyType; // 0x40
	private object[] _namingStrategyParameters; // 0x48

	// Methods

	// RVA: 0xD4B6FC
	Type get_ItemConverterType() { }

	// RVA: 0xD4B704
	object[] get_ItemConverterParameters() { }

	// RVA: 0xD4B70C
	Type get_NamingStrategyType() { }

	// RVA: 0xD4B714
	object[] get_NamingStrategyParameters() { }

	// RVA: 0xD4B71C
	NamingStrategy get_NamingStrategyInstance() { }

	// RVA: 0xD4B724
	void set_NamingStrategyInstance(NamingStrategy value) { }

}

// Namespace: Newtonsoft.Json
public static class JsonConvert 
{
	// Fields
	private static System.Func<Newtonsoft.Json.JsonSerializerSettings> <DefaultSettings>k__BackingField; // 0x0
	public static readonly string True; // 0x8
	public static readonly string False; // 0x10
	public static readonly string Null; // 0x18
	public static readonly string Undefined; // 0x20
	public static readonly string PositiveInfinity; // 0x28
	public static readonly string NegativeInfinity; // 0x30
	public static readonly string NaN; // 0x38

	// Methods

	// RVA: 0xD4B72C
	System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings() { }

	// RVA: 0xD4B7A8
	string ToString(bool value) { }

	// RVA: 0xD4B844
	string ToString(Char value) { }

	// RVA: 0xD4BA0C
	string ToString(float value, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD4BC84
	string EnsureFloatFormat(Double value, string text, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD4BDAC
	string ToString(Double value, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD4BBBC
	string EnsureDecimalPlace(Double value, string text) { }

	// RVA: 0xD4BF54
	string EnsureDecimalPlace(string text) { }

	// RVA: 0xD4BFCC
	string ToString(Decimal value) { }

	// RVA: 0xD4B8EC
	string ToString(string value) { }

	// RVA: 0xD4C15C
	string ToString(string value, Char delimiter) { }

	// RVA: 0xD4C1C8
	string ToString(string value, Char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xD4C2AC
	string SerializeObject(object value) { }

	// RVA: 0xD4C37C
	string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xD4C444
	string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	// RVA: 0x309AF8C
	T DeserializeObject(string value) { }

	// RVA: 0x309AF8C
	T DeserializeObject(string value, JsonSerializerSettings settings) { }

	// RVA: 0xD4C93C
	object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xD4CDBC
	void .cctor() { }

}

// Namespace: Newtonsoft.Json
public abstract class JsonConverter 
{
	// Methods

	// RVA: 0x2FE49A8
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x2FE3884
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x2FE3174
	bool CanConvert(Type objectType) { }

	// RVA: 0xD4CF30
	bool get_CanRead() { }

	// RVA: 0xD4CF38
	bool get_CanWrite() { }

	// RVA: 0xD4CF40
	void .ctor() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonConverterAttribute 
{
	// Fields
	private readonly Type _converterType; // 0x10
	private readonly object[] <ConverterParameters>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD4CF48
	Type get_ConverterType() { }

	// RVA: 0xD4CF50
	object[] get_ConverterParameters() { }

}

// Namespace: Newtonsoft.Json
public class JsonConverterCollection 
{
	// Methods

	// RVA: 0xD4CF58
	void .ctor() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonDictionaryAttribute 
{}

// Namespace: Newtonsoft.Json
public class JsonException 
{
	// Methods

	// RVA: 0xD4CFAC
	void .ctor() { }

	// RVA: 0xD4D034
	void .ctor(string message) { }

	// RVA: 0xD4D0A0
	void .ctor(string message, Exception innerException) { }

	// RVA: 0xD4D11C
	void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: Newtonsoft.Json
public class JsonExtensionDataAttribute 
{
	// Fields
	private bool <WriteData>k__BackingField; // 0x10
	private bool <ReadData>k__BackingField; // 0x11

	// Methods

	// RVA: 0xD4D1A0
	bool get_WriteData() { }

	// RVA: 0xD4D1A8
	bool get_ReadData() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonIgnoreAttribute 
{
	// Methods

	// RVA: 0xD4D1B0
	void .ctor() { }

}

// Namespace: Newtonsoft.Json
public abstract class JsonNameTable 
{
	// Methods

	// RVA: -1
	string Get(Char[] key, int start, int length) { }

	// RVA: 0xD4AED8
	void .ctor() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonObjectAttribute 
{
	// Fields
	private MemberSerialization _memberSerialization; // 0x50
	internal System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling; // 0x54
	internal System.Nullable<Newtonsoft.Json.Required> _itemRequired; // 0x5C
	internal System.Nullable<Newtonsoft.Json.NullValueHandling> _itemNullValueHandling; // 0x64

	// Methods

	// RVA: 0xD4D1B8
	MemberSerialization get_MemberSerialization() { }

}

// Namespace: Newtonsoft.Json
internal enum JsonContainerType 
{
	// Fields
	public int value__; // 0x10
	public const JsonContainerType None = 0;
	public const JsonContainerType Object = 1;
	public const JsonContainerType Array = 2;
	public const JsonContainerType Constructor = 3;
}

// Namespace: Newtonsoft.Json
internal struct JsonPosition 
{
	// Fields
	private static readonly Char[] SpecialCharacters; // 0x0
	internal JsonContainerType Type; // 0x10
	internal int Position; // 0x14
	internal string PropertyName; // 0x18
	internal bool HasIndex; // 0x20

	// Methods

	// RVA: 0xD4D1C0
	void .ctor(JsonContainerType type) { }

	// RVA: 0xD4D258
	int CalculateLength() { }

	// RVA: 0xD4D300
	void WriteTo(StringBuilder sb, ref StringWriter writer, ref Char[] buffer) { }

	// RVA: 0xD4D248
	bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0xD4D54C
	string BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition) { }

	// RVA: 0xD4DA34
	string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0xD4DD6C
	void .cctor() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonPropertyAttribute 
{
	// Fields
	internal System.Nullable<Newtonsoft.Json.NullValueHandling> _nullValueHandling; // 0x10
	internal System.Nullable<Newtonsoft.Json.DefaultValueHandling> _defaultValueHandling; // 0x18
	internal System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _referenceLoopHandling; // 0x20
	internal System.Nullable<Newtonsoft.Json.ObjectCreationHandling> _objectCreationHandling; // 0x28
	internal System.Nullable<Newtonsoft.Json.TypeNameHandling> _typeNameHandling; // 0x30
	internal System.Nullable<System.Boolean> _isReference; // 0x38
	internal System.Nullable<System.Int32> _order; // 0x3C
	internal System.Nullable<Newtonsoft.Json.Required> _required; // 0x44
	internal System.Nullable<System.Boolean> _itemIsReference; // 0x4C
	internal System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x50
	internal System.Nullable<Newtonsoft.Json.TypeNameHandling> _itemTypeNameHandling; // 0x58
	private Type <ItemConverterType>k__BackingField; // 0x60
	private object[] <ItemConverterParameters>k__BackingField; // 0x68
	private Type <NamingStrategyType>k__BackingField; // 0x70
	private object[] <NamingStrategyParameters>k__BackingField; // 0x78
	private string <PropertyName>k__BackingField; // 0x80

	// Methods

	// RVA: 0xD4DE10
	Type get_ItemConverterType() { }

	// RVA: 0xD4DE18
	object[] get_ItemConverterParameters() { }

	// RVA: 0xD4DE20
	Type get_NamingStrategyType() { }

	// RVA: 0xD4DE28
	object[] get_NamingStrategyParameters() { }

	// RVA: 0xD4DE30
	string get_PropertyName() { }

	// RVA: 0xD4DE38
	void set_PropertyName(string value) { }

	// RVA: 0xD4DE40
	void .ctor() { }

}

// Namespace: 
protected internal enum State 
{
	// Fields
	public int value__; // 0x10
	public const State Start = 0;
	public const State Complete = 1;
	public const State Property = 2;
	public const State ObjectStart = 3;
	public const State Object = 4;
	public const State ArrayStart = 5;
	public const State Array = 6;
	public const State Closed = 7;
	public const State PostValue = 8;
	public const State ConstructorStart = 9;
	public const State Constructor = 10;
	public const State Error = 11;
	public const State Finished = 12;
}

// Namespace: Newtonsoft.Json
public abstract class JsonReader 
{
	// Fields
	private JsonToken _tokenType; // 0x10
	private object _value; // 0x18
	internal Char _quoteChar; // 0x20
	internal State _currentState; // 0x24
	private JsonPosition _currentPosition; // 0x28
	private CultureInfo _culture; // 0x40
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
	private System.Nullable<System.Int32> _maxDepth; // 0x4C
	private bool _hasExceededMaxDepth; // 0x54
	internal DateParseHandling _dateParseHandling; // 0x58
	internal FloatParseHandling _floatParseHandling; // 0x5C
	private string _dateFormatString; // 0x60
	private System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> _stack; // 0x68
	private bool <CloseInput>k__BackingField; // 0x70
	private bool <SupportMultipleContent>k__BackingField; // 0x71

	// Methods

	// RVA: 0xD4DE48
	State get_CurrentState() { }

	// RVA: 0xD4DE50
	bool get_CloseInput() { }

	// RVA: 0xD4DE58
	void set_CloseInput(bool value) { }

	// RVA: 0xD4DE60
	bool get_SupportMultipleContent() { }

	// RVA: 0xD4DE68
	void set_SupportMultipleContent(bool value) { }

	// RVA: 0xD4DE70
	DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xD4DE78
	void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xD4DEE4
	DateParseHandling get_DateParseHandling() { }

	// RVA: 0xD4DEEC
	void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0xD4DF58
	FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0xD4DF60
	void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0xD4DFCC
	string get_DateFormatString() { }

	// RVA: 0xD4DFD4
	void set_DateFormatString(string value) { }

	// RVA: 0xD4DFDC
	System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xD4DFE4
	void set_MaxDepth(System.Nullable<System.Int32> value) { }

	// RVA: 0xD4E178
	JsonToken get_TokenType() { }

	// RVA: 0xD4E180
	object get_Value() { }

	// RVA: 0xD4E188
	Type get_ValueType() { }

	// RVA: 0xD4E19C
	int get_Depth() { }

	// RVA: 0xD4E218
	string get_Path() { }

	// RVA: 0xD4E348
	CultureInfo get_Culture() { }

	// RVA: 0xD4E3C4
	void set_Culture(CultureInfo value) { }

	// RVA: 0xD4E3CC
	JsonPosition GetPosition(int depth) { }

	// RVA: 0xD4E48C
	void .ctor() { }

	// RVA: 0xD4E530
	void Push(JsonContainerType value) { }

	// RVA: 0xD4E9E8
	JsonContainerType Pop() { }

	// RVA: 0xD4EC10
	JsonContainerType Peek() { }

	// RVA: 0x2FE3054
	bool Read() { }

	// RVA: 0xD4EC18
	System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xD4F38C
	System.Nullable<System.Int32> ReadInt32String(string s) { }

	// RVA: 0xD4F60C
	string ReadAsString() { }

	// RVA: 0xD4F9D8
	Byte[] ReadAsBytes() { }

	// RVA: 0xD5012C
	Byte[] ReadArrayIntoByteArray() { }

	// RVA: 0xD502A8
	bool ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<System.Byte> buffer) { }

	// RVA: 0xD50494
	System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xD50804
	System.Nullable<System.Double> ReadDoubleString(string s) { }

	// RVA: 0xD50A84
	System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xD50E4C
	System.Nullable<System.Boolean> ReadBooleanString(string s) { }

	// RVA: 0xD5106C
	System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xD5152C
	System.Nullable<System.Decimal> ReadDecimalString(string s) { }

	// RVA: 0xD51848
	System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xD51B88
	System.Nullable<System.DateTime> ReadDateTimeString(string s) { }

	// RVA: 0xD51F34
	System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xD5226C
	System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0xD500DC
	void ReaderReadAndAssert() { }

	// RVA: 0xD525E4
	JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0xD4FEBC
	void ReadIntoWrappedTypeObject() { }

	// RVA: 0xD526A4
	void Skip() { }

	// RVA: 0xD5029C
	void SetToken(JsonToken newToken) { }

	// RVA: 0xD52740
	void SetToken(JsonToken newToken, object value) { }

	// RVA: 0xD4F18C
	void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0xD52868
	void SetPostValueState(bool updateIndex) { }

	// RVA: 0xD4E94C
	void UpdateScopeWithFinishedValue() { }

	// RVA: 0xD52748
	void ValidateEnd(JsonToken endToken) { }

	// RVA: 0xD5298C
	void SetStateBasedOnCurrent() { }

	// RVA: 0xD528B0
	void SetFinished() { }

	// RVA: 0xD528DC
	JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0xD52AAC
	void System.IDisposable.Dispose() { }

	// RVA: 0xD52B40
	void Dispose(bool disposing) { }

	// RVA: 0xD52B64
	void Close() { }

	// RVA: 0xD52B7C
	void ReadAndAssert() { }

	// RVA: 0xD52C60
	void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	// RVA: 0xD52CB8
	bool ReadForType(JsonContract contract, bool hasConverter) { }

	// RVA: 0xD52FE0
	bool ReadAndMoveToContent() { }

	// RVA: 0xD5304C
	bool MoveToContent() { }

	// RVA: 0xD4F070
	JsonToken GetContentToken() { }

}

// Namespace: Newtonsoft.Json
public class JsonReaderException 
{
	// Fields
	private readonly int <LineNumber>k__BackingField; // 0x8C
	private readonly int <LinePosition>k__BackingField; // 0x90
	private readonly string <Path>k__BackingField; // 0x98

	// Methods

	// RVA: 0xD530A8
	void .ctor() { }

	// RVA: 0xD53130
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD531B4
	void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0xD4E964
	JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0xD4F0FC
	JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xD5325C
	JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonRequiredAttribute 
{
	// Methods

	// RVA: 0xD534C0
	void .ctor() { }

}

// Namespace: Newtonsoft.Json
public class JsonSerializationException 
{
	// Fields
	private readonly int <LineNumber>k__BackingField; // 0x8C
	private readonly int <LinePosition>k__BackingField; // 0x90
	private readonly string <Path>k__BackingField; // 0x98

	// Methods

	// RVA: 0xD534C8
	void .ctor() { }

	// RVA: 0xD53550
	void .ctor(string message) { }

	// RVA: 0xD535BC
	void .ctor(string message, Exception innerException) { }

	// RVA: 0xD53638
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD536BC
	void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0xD52BDC
	JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0xD53764
	JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xD537F4
	JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

// Namespace: Newtonsoft.Json
public class JsonSerializer 
{
	// Fields
	internal TypeNameHandling _typeNameHandling; // 0x10
	internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; // 0x14
	internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
	internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
	internal MissingMemberHandling _missingMemberHandling; // 0x20
	internal ObjectCreationHandling _objectCreationHandling; // 0x24
	internal NullValueHandling _nullValueHandling; // 0x28
	internal DefaultValueHandling _defaultValueHandling; // 0x2C
	internal ConstructorHandling _constructorHandling; // 0x30
	internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
	internal JsonConverterCollection _converters; // 0x38
	internal IContractResolver _contractResolver; // 0x40
	internal ITraceWriter _traceWriter; // 0x48
	internal IEqualityComparer _equalityComparer; // 0x50
	internal ISerializationBinder _serializationBinder; // 0x58
	internal StreamingContext _context; // 0x60
	private IReferenceResolver _referenceResolver; // 0x70
	private System.Nullable<Newtonsoft.Json.Formatting> _formatting; // 0x78
	private System.Nullable<Newtonsoft.Json.DateFormatHandling> _dateFormatHandling; // 0x80
	private System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> _dateTimeZoneHandling; // 0x88
	private System.Nullable<Newtonsoft.Json.DateParseHandling> _dateParseHandling; // 0x90
	private System.Nullable<Newtonsoft.Json.FloatFormatHandling> _floatFormatHandling; // 0x98
	private System.Nullable<Newtonsoft.Json.FloatParseHandling> _floatParseHandling; // 0xA0
	private System.Nullable<Newtonsoft.Json.StringEscapeHandling> _stringEscapeHandling; // 0xA8
	private CultureInfo _culture; // 0xB0
	private System.Nullable<System.Int32> _maxDepth; // 0xB8
	private bool _maxDepthSet; // 0xC0
	private System.Nullable<System.Boolean> _checkAdditionalContent; // 0xC1
	private string _dateFormatString; // 0xC8
	private bool _dateFormatStringSet; // 0xD0
	private System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error; // 0xD8

	// Methods

	// RVA: 0xD53A58
	void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xD53B0C
	void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xD53BC0
	void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xD53C3C
	void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0xD53CB8
	ITraceWriter get_TraceWriter() { }

	// RVA: 0xD53CC0
	void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0xD53CC8
	void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xD53CD0
	void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xD53D3C
	void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0xD53DA8
	void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xD53E14
	void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xD53E80
	void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xD53EEC
	NullValueHandling get_NullValueHandling() { }

	// RVA: 0xD53EF4
	void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xD53F60
	void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0xD53FCC
	void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xD54038
	void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0xD540A4
	MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xD540AC
	void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xD54118
	JsonConverterCollection get_Converters() { }

	// RVA: 0xD541D8
	IContractResolver get_ContractResolver() { }

	// RVA: 0xD541E0
	void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xD542C4
	StreamingContext get_Context() { }

	// RVA: 0xD542D0
	void set_Context(StreamingContext value) { }

	// RVA: 0xD542DC
	Formatting get_Formatting() { }

	// RVA: 0xD543B4
	System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xD543BC
	bool get_CheckAdditionalContent() { }

	// RVA: 0xD54494
	void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xD4CB9C
	bool IsCheckAdditionalContentSet() { }

	// RVA: 0xD5450C
	void .ctor() { }

	// RVA: 0xD54678
	JsonSerializer Create() { }

	// RVA: 0xD546CC
	JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0xD5587C
	JsonSerializer CreateDefault() { }

	// RVA: 0xD4C40C
	JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0xD5473C
	void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	// RVA: 0xD563A8
	void Populate(JsonReader reader, object target) { }

	// RVA: 0xD563B8
	void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0x309AF8C
	T Deserialize(JsonReader reader) { }

	// RVA: 0xD4CDAC
	object Deserialize(JsonReader reader, Type objectType) { }

	// RVA: 0xD5774C
	object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xD5663C
	void SetupReader(JsonReader reader, out CultureInfo previousCulture, out System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>& previousDateTimeZoneHandling, out System.Nullable<Newtonsoft.Json.DateParseHandling>& previousDateParseHandling, out System.Nullable<Newtonsoft.Json.FloatParseHandling>& previousFloatParseHandling, out System.Nullable<System.Int32>& previousMaxDepth, out string previousDateFormatString) { }

	// RVA: 0xD5722C
	void ResetReader(JsonReader reader, CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<System.Int32> previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xD4C92C
	void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xD579D8
	void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0xD57198
	TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	// RVA: 0xD579EC
	void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xD58F88
	IReferenceResolver GetReferenceResolver() { }

	// RVA: 0xD59010
	JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0xD59018
	JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, Type objectType) { }

	// RVA: 0xD591B4
	void OnError(ErrorEventArgs e) { }

}

// Namespace: Newtonsoft.Json
public class JsonSerializerSettings 
{
	// Fields
	internal static readonly StreamingContext DefaultContext; // 0x0
	internal static readonly CultureInfo DefaultCulture; // 0x10
	internal System.Nullable<Newtonsoft.Json.Formatting> _formatting; // 0x10
	internal System.Nullable<Newtonsoft.Json.DateFormatHandling> _dateFormatHandling; // 0x18
	internal System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> _dateTimeZoneHandling; // 0x20
	internal System.Nullable<Newtonsoft.Json.DateParseHandling> _dateParseHandling; // 0x28
	internal System.Nullable<Newtonsoft.Json.FloatFormatHandling> _floatFormatHandling; // 0x30
	internal System.Nullable<Newtonsoft.Json.FloatParseHandling> _floatParseHandling; // 0x38
	internal System.Nullable<Newtonsoft.Json.StringEscapeHandling> _stringEscapeHandling; // 0x40
	internal CultureInfo _culture; // 0x48
	internal System.Nullable<System.Boolean> _checkAdditionalContent; // 0x50
	internal System.Nullable<System.Int32> _maxDepth; // 0x54
	internal bool _maxDepthSet; // 0x5C
	internal string _dateFormatString; // 0x60
	internal bool _dateFormatStringSet; // 0x68
	internal System.Nullable<Newtonsoft.Json.TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling; // 0x6C
	internal System.Nullable<Newtonsoft.Json.DefaultValueHandling> _defaultValueHandling; // 0x74
	internal System.Nullable<Newtonsoft.Json.PreserveReferencesHandling> _preserveReferencesHandling; // 0x7C
	internal System.Nullable<Newtonsoft.Json.NullValueHandling> _nullValueHandling; // 0x84
	internal System.Nullable<Newtonsoft.Json.ObjectCreationHandling> _objectCreationHandling; // 0x8C
	internal System.Nullable<Newtonsoft.Json.MissingMemberHandling> _missingMemberHandling; // 0x94
	internal System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> _referenceLoopHandling; // 0x9C
	internal System.Nullable<System.Runtime.Serialization.StreamingContext> _context; // 0xA8
	internal System.Nullable<Newtonsoft.Json.ConstructorHandling> _constructorHandling; // 0xC0
	internal System.Nullable<Newtonsoft.Json.TypeNameHandling> _typeNameHandling; // 0xC8
	internal System.Nullable<Newtonsoft.Json.MetadataPropertyHandling> _metadataPropertyHandling; // 0xD0
	private System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> <Converters>k__BackingField; // 0xD8
	private IContractResolver <ContractResolver>k__BackingField; // 0xE0
	private IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
	private System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
	private ITraceWriter <TraceWriter>k__BackingField; // 0xF8
	private ISerializationBinder <SerializationBinder>k__BackingField; // 0x100
	private System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> <Error>k__BackingField; // 0x108

	// Methods

	// RVA: 0xD55D2C
	ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0xD55E04
	MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0xD55EDC
	ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xD55FB4
	NullValueHandling get_NullValueHandling() { }

	// RVA: 0xD5608C
	DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0xD591D8
	System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters() { }

	// RVA: 0xD55C54
	PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0xD559CC
	TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0xD55AA4
	MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xD55B7C
	TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0xD56164
	ConstructorHandling get_ConstructorHandling() { }

	// RVA: 0xD591E0
	IContractResolver get_ContractResolver() { }

	// RVA: 0xD591E8
	IEqualityComparer get_EqualityComparer() { }

	// RVA: 0xD591F0
	System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider() { }

	// RVA: 0xD591F8
	ITraceWriter get_TraceWriter() { }

	// RVA: 0xD59200
	ISerializationBinder get_SerializationBinder() { }

	// RVA: 0xD59208
	System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error() { }

	// RVA: 0xD5623C
	StreamingContext get_Context() { }

	// RVA: 0xD59210
	void .cctor() { }

}

// Namespace: Newtonsoft.Json
public class JsonTextReader 
{
	// Fields
	private readonly bool _safeAsync; // 0x72
	private readonly TextReader _reader; // 0x78
	private Char[] _chars; // 0x80
	private int _charsUsed; // 0x88
	private int _charPos; // 0x8C
	private int _lineStartPos; // 0x90
	private int _lineNumber; // 0x94
	private bool _isEndOfFile; // 0x98
	private StringBuffer _stringBuffer; // 0xA0
	private StringReference _stringReference; // 0xB0
	private Newtonsoft.Json.IArrayPool<System.Char> _arrayPool; // 0xC0
	private JsonNameTable <PropertyNameTable>k__BackingField; // 0xC8

	// Methods

	// RVA: 0xD4CC1C
	void .ctor(TextReader reader) { }

	// RVA: 0xD592A0
	JsonNameTable get_PropertyNameTable() { }

	// RVA: 0xD592A8
	void set_PropertyNameTable(JsonNameTable value) { }

	// RVA: 0xD592B0
	void EnsureBufferNotEmpty() { }

	// RVA: 0xD59314
	void SetNewLine(bool hasNextChar) { }

	// RVA: 0xD59388
	void OnNewLine(int pos) { }

	// RVA: 0xD59398
	void ParseString(Char quote, ReadType readType) { }

	// RVA: 0xD59B84
	void ParseReadString(Char quote, ReadType readType) { }

	// RVA: 0xD5A09C
	void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	// RVA: 0xD593EC
	void ShiftBufferIfNeeded() { }

	// RVA: 0xD5A0B0
	int ReadData(bool append) { }

	// RVA: 0xD5A158
	void PrepareBufferForReadData(bool append, int charsRequired) { }

	// RVA: 0xD5A0B8
	int ReadData(bool append, int charsRequired) { }

	// RVA: 0xD5A31C
	bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0xD5A3B4
	bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0xD5A434
	bool Read() { }

	// RVA: 0xD5B898
	System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xD5BEA4
	System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xD5C5D8
	string ReadAsString() { }

	// RVA: 0xD5C640
	Byte[] ReadAsBytes() { }

	// RVA: 0xD5BF64
	object ReadStringValue(ReadType readType) { }

	// RVA: 0xD5D210
	object FinishReadQuotedStringValue(ReadType readType) { }

	// RVA: 0xD5CE68
	JsonReaderException CreateUnexpectedCharacterException(Char c) { }

	// RVA: 0xD5D86C
	System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xD5CDF8
	void ProcessValueComma() { }

	// RVA: 0xD5B958
	object ReadNumberValue(ReadType readType) { }

	// RVA: 0xD5DF10
	object FinishReadQuotedNumber(ReadType readType) { }

	// RVA: 0xD5E09C
	System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xD5E16C
	System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xD5E23C
	System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xD5CCF4
	void HandleNull() { }

	// RVA: 0xD5D074
	void ReadFinished() { }

	// RVA: 0xD5CC84
	bool ReadNullChar() { }

	// RVA: 0xD5A6FC
	void EnsureBuffer() { }

	// RVA: 0xD594C8
	void ReadStringIntoBuffer(Char quote) { }

	// RVA: 0xD5E52C
	void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	// RVA: 0xD5E4D8
	void WriteCharToBuffer(Char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0xD5E614
	Char ConvertUnicode(bool enoughChars) { }

	// RVA: 0xD5E434
	Char ParseUnicode() { }

	// RVA: 0xD5E774
	void ReadNumberIntoBuffer() { }

	// RVA: 0xD5E804
	bool ReadNumberCharIntoBuffer(Char currentChar, int charPos) { }

	// RVA: 0xD5E99C
	void ClearRecentString() { }

	// RVA: 0xD5B01C
	bool ParsePostValue(bool ignoreComments) { }

	// RVA: 0xD5AE30
	bool ParseObject() { }

	// RVA: 0xD5E9A8
	bool ParseProperty() { }

	// RVA: 0xD5ECD0
	bool ValidIdentifierChar(Char value) { }

	// RVA: 0xD5ED48
	void ParseUnquotedProperty() { }

	// RVA: 0xD5EE3C
	bool ReadUnquotedPropertyReportIfDone(Char currentChar, int initialPosition) { }

	// RVA: 0xD5A76C
	bool ParseValue() { }

	// RVA: 0xD5D058
	void ProcessLineFeed() { }

	// RVA: 0xD5CF94
	void ProcessCarriageReturn(bool append) { }

	// RVA: 0xD5B37C
	void EatWhitespace() { }

	// RVA: 0xD5F340
	void ParseConstructor() { }

	// RVA: 0xD5D4F4
	void ParseNumber(ReadType readType) { }

	// RVA: 0xD5F7BC
	void ParseReadNumber(ReadType readType, Char firstChar, int initialPosition) { }

	// RVA: 0xD60AF4
	JsonReaderException ThrowReaderError(string message, Exception ex) { }

	// RVA: 0xD60BF0
	object BigIntegerParse(string number, CultureInfo culture) { }

	// RVA: 0xD5B498
	void ParseComment(bool setToken) { }

	// RVA: 0xD60C78
	void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0xD60CF0
	bool MatchValue(string value) { }

	// RVA: 0xD60DB0
	bool MatchValue(bool enoughChars, string value) { }

	// RVA: 0xD5D5C8
	bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0xD60E90
	bool IsSeparator(Char c) { }

	// RVA: 0xD5F040
	void ParseTrue() { }

	// RVA: 0xD5E2FC
	void ParseNull() { }

	// RVA: 0xD5F688
	void ParseUndefined() { }

	// RVA: 0xD5F1C0
	void ParseFalse() { }

	// RVA: 0xD5D474
	object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0xD61068
	object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	// RVA: 0xD5D76C
	object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0xD612C4
	object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	// RVA: 0xD5D7EC
	object ParseNumberNaN(ReadType readType) { }

	// RVA: 0xD61520
	object ParseNumberNaN(ReadType readType, bool matched) { }

	// RVA: 0xD6177C
	void Close() { }

	// RVA: 0xD61800
	bool HasLineInfo() { }

	// RVA: 0xD61808
	int get_LineNumber() { }

	// RVA: 0xD61864
	int get_LinePosition() { }

}

// Namespace: Newtonsoft.Json
internal enum ReadType 
{
	// Fields
	public int value__; // 0x10
	public const ReadType Read = 0;
	public const ReadType ReadAsInt32 = 1;
	public const ReadType ReadAsInt64 = 2;
	public const ReadType ReadAsBytes = 3;
	public const ReadType ReadAsString = 4;
	public const ReadType ReadAsDecimal = 5;
	public const ReadType ReadAsDateTime = 6;
	public const ReadType ReadAsDateTimeOffset = 7;
	public const ReadType ReadAsDouble = 8;
	public const ReadType ReadAsBoolean = 9;
}

// Namespace: Newtonsoft.Json
public class JsonTextWriter 
{
	// Fields
	private readonly bool _safeAsync; // 0x60
	private readonly TextWriter _writer; // 0x68
	private Base64Encoder _base64Encoder; // 0x70
	private Char _indentChar; // 0x78
	private int _indentation; // 0x7C
	private Char _quoteChar; // 0x80
	private bool _quoteName; // 0x82
	private bool[] _charEscapeFlags; // 0x88
	private Char[] _writeBuffer; // 0x90
	private Newtonsoft.Json.IArrayPool<System.Char> _arrayPool; // 0x98
	private Char[] _indentChars; // 0xA0

	// Methods

	// RVA: 0xD61870
	Base64Encoder get_Base64Encoder() { }

	// RVA: 0xD61914
	Char get_QuoteChar() { }

	// RVA: 0xD4C6F0
	void .ctor(TextWriter textWriter) { }

	// RVA: 0xD619D4
	void Close() { }

	// RVA: 0xD61B44
	void CloseBufferAndWriter() { }

	// RVA: 0xD61BAC
	void WriteStartObject() { }

	// RVA: 0xD61C54
	void WriteStartArray() { }

	// RVA: 0xD61CB8
	void WriteStartConstructor(string name) { }

	// RVA: 0xD61D88
	void WriteEnd(JsonToken token) { }

	// RVA: 0xD61EA8
	void WritePropertyName(string name) { }

	// RVA: 0xD62020
	void WritePropertyName(string name, bool escape) { }

	// RVA: 0xD620FC
	void OnStringEscapeHandlingChanged() { }

	// RVA: 0xD61954
	void UpdateCharEscapeFlags() { }

	// RVA: 0xD6217C
	void WriteIndent() { }

	// RVA: 0xD62344
	int SetIndentChars() { }

	// RVA: 0xD62458
	void WriteValueDelimiter() { }

	// RVA: 0xD62484
	void WriteIndentSpace() { }

	// RVA: 0xD624B0
	void WriteValueInternal(string value, JsonToken token) { }

	// RVA: 0xD624D8
	void WriteValue(object value) { }

	// RVA: 0xD62770
	void WriteNull() { }

	// RVA: 0xD62808
	void WriteUndefined() { }

	// RVA: 0xD628A0
	void WriteRaw(string json) { }

	// RVA: 0xD628CC
	void WriteValue(string value) { }

	// RVA: 0xD61F34
	void WriteEscapedString(string value, bool quote) { }

	// RVA: 0xD629E0
	void WriteValue(int value) { }

	// RVA: 0xD62AD0
	void WriteValue(UInt32 value) { }

	// RVA: 0xD62BC0
	void WriteValue(Int64 value) { }

	// RVA: 0xD62C08
	void WriteValue(UInt64 value) { }

	// RVA: 0xD62D28
	void WriteValue(float value) { }

	// RVA: 0xD62DE8
	void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xD62FC4
	void WriteValue(Double value) { }

	// RVA: 0xD63084
	void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xD63260
	void WriteValue(bool value) { }

	// RVA: 0xD6336C
	void WriteValue(Int16 value) { }

	// RVA: 0xD633B4
	void WriteValue(UInt16 value) { }

	// RVA: 0xD633FC
	void WriteValue(Char value) { }

	// RVA: 0xD63530
	void WriteValue(Byte value) { }

	// RVA: 0xD63578
	void WriteValue(SByte value) { }

	// RVA: 0xD635C0
	void WriteValue(Decimal value) { }

	// RVA: 0xD6366C
	void WriteValue(DateTime value) { }

	// RVA: 0xD6387C
	int WriteValueToBuffer(DateTime value) { }

	// RVA: 0xD639C0
	void WriteValue(Byte[] value) { }

	// RVA: 0xD63B54
	void WriteValue(DateTimeOffset value) { }

	// RVA: 0xD63D30
	int WriteValueToBuffer(DateTimeOffset value) { }

	// RVA: 0xD63ED4
	void WriteValue(Guid value) { }

	// RVA: 0xD63FE8
	void WriteValue(TimeSpan value) { }

	// RVA: 0xD6412C
	void WriteValue(Uri value) { }

	// RVA: 0xD64220
	void WriteComment(string text) { }

	// RVA: 0xD62990
	void EnsureWriteBuffer() { }

	// RVA: 0xD62B18
	void WriteIntegerValue(Int64 value) { }

	// RVA: 0xD62CAC
	void WriteIntegerValue(UInt64 value, bool negative) { }

	// RVA: 0xD642EC
	int WriteNumberToBuffer(UInt64 value, bool negative) { }

	// RVA: 0xD62A28
	void WriteIntegerValue(int value) { }

	// RVA: 0xD644E8
	void WriteIntegerValue(UInt32 value, bool negative) { }

	// RVA: 0xD643FC
	int WriteNumberToBuffer(UInt32 value, bool negative) { }

}

// Namespace: Newtonsoft.Json
public enum JsonToken 
{
	// Fields
	public int value__; // 0x10
	public const JsonToken None = 0;
	public const JsonToken StartObject = 1;
	public const JsonToken StartArray = 2;
	public const JsonToken StartConstructor = 3;
	public const JsonToken PropertyName = 4;
	public const JsonToken Comment = 5;
	public const JsonToken Raw = 6;
	public const JsonToken Integer = 7;
	public const JsonToken Float = 8;
	public const JsonToken String = 9;
	public const JsonToken Boolean = 10;
	public const JsonToken Null = 11;
	public const JsonToken Undefined = 12;
	public const JsonToken EndObject = 13;
	public const JsonToken EndArray = 14;
	public const JsonToken EndConstructor = 15;
	public const JsonToken Date = 16;
	public const JsonToken Bytes = 17;
}

// Namespace: 
internal enum State 
{
	// Fields
	public int value__; // 0x10
	public const State Start = 0;
	public const State Property = 1;
	public const State ObjectStart = 2;
	public const State Object = 3;
	public const State ArrayStart = 4;
	public const State Array = 5;
	public const State ConstructorStart = 6;
	public const State Constructor = 7;
	public const State Closed = 8;
	public const State Error = 9;
}

// Namespace: Newtonsoft.Json
public abstract class JsonWriter 
{
	// Fields
	private static readonly State[][] StateArray; // 0x0
	internal static readonly State[][] StateArrayTemplate; // 0x8
	private System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> _stack; // 0x10
	private JsonPosition _currentPosition; // 0x18
	private State _currentState; // 0x30
	private Formatting _formatting; // 0x34
	private bool <CloseOutput>k__BackingField; // 0x38
	private bool <AutoCompleteOnClose>k__BackingField; // 0x39
	private DateFormatHandling _dateFormatHandling; // 0x3C
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
	private StringEscapeHandling _stringEscapeHandling; // 0x44
	private FloatFormatHandling _floatFormatHandling; // 0x48
	private string _dateFormatString; // 0x50
	private CultureInfo _culture; // 0x58

	// Methods

	// RVA: 0xD64564
	State[][] BuildStateArray() { }

	// RVA: 0xD64750
	void .cctor() { }

	// RVA: 0xD64A78
	bool get_CloseOutput() { }

	// RVA: 0xD64A80
	void set_CloseOutput(bool value) { }

	// RVA: 0xD64A88
	bool get_AutoCompleteOnClose() { }

	// RVA: 0xD64A90
	void set_AutoCompleteOnClose(bool value) { }

	// RVA: 0xD622F0
	int get_Top() { }

	// RVA: 0xD64AA0
	WriteState get_WriteState() { }

	// RVA: 0xD64B54
	string get_ContainerPath() { }

	// RVA: 0xD64C04
	string get_Path() { }

	// RVA: 0xD64D34
	Formatting get_Formatting() { }

	// RVA: 0xD4C8C0
	void set_Formatting(Formatting value) { }

	// RVA: 0xD64D3C
	DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0xD58D54
	void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0xD64D44
	DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xD58DC0
	void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xD64D4C
	StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0xD58E98
	void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0xD64D54
	void OnStringEscapeHandlingChanged() { }

	// RVA: 0xD64D58
	FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0xD58E2C
	void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0xD64D60
	string get_DateFormatString() { }

	// RVA: 0xD64D68
	void set_DateFormatString(string value) { }

	// RVA: 0xD58F0C
	CultureInfo get_Culture() { }

	// RVA: 0xD64D70
	void set_Culture(CultureInfo value) { }

	// RVA: 0xD6191C
	void .ctor() { }

	// RVA: 0xD64D78
	void UpdateScopeWithFinishedValue() { }

	// RVA: 0xD64D90
	void Push(JsonContainerType value) { }

	// RVA: 0xD64F28
	JsonContainerType Pop() { }

	// RVA: 0xD64A98
	JsonContainerType Peek() { }

	// RVA: 0xD61AB4
	void Close() { }

	// RVA: 0xD650A8
	void WriteStartObject() { }

	// RVA: 0xD650EC
	void WriteEndObject() { }

	// RVA: 0xD650F8
	void WriteStartArray() { }

	// RVA: 0xD6513C
	void WriteEndArray() { }

	// RVA: 0xD65144
	void WriteStartConstructor(string name) { }

	// RVA: 0xD65188
	void WriteEndConstructor() { }

	// RVA: 0xD65190
	void WritePropertyName(string name) { }

	// RVA: 0xD651BC
	void WritePropertyName(string name, bool escape) { }

	// RVA: 0xD651CC
	void WriteEnd() { }

	// RVA: 0xD652E4
	void WriteToken(JsonReader reader) { }

	// RVA: 0xD65364
	void WriteToken(JsonReader reader, bool writeChildren) { }

	// RVA: 0xD653F0
	void WriteToken(JsonToken token, object value) { }

	// RVA: 0xD65BEC
	void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0xD65FC4
	bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	// RVA: 0xD65E64
	int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	// RVA: 0xD6608C
	int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	// RVA: 0xD65ED0
	void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0xD651D4
	void WriteEnd(JsonContainerType type) { }

	// RVA: 0xD65020
	void AutoCompleteAll() { }

	// RVA: 0xD660F4
	JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0xD66194
	void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0xD66260
	int CalculateLevelsToComplete(JsonContainerType type) { }

	// RVA: 0xD663CC
	void UpdateCurrentState() { }

	// RVA: 0xD66484
	void WriteEnd(JsonToken token) { }

	// RVA: 0xD66488
	void WriteIndent() { }

	// RVA: 0xD6648C
	void WriteValueDelimiter() { }

	// RVA: 0xD66490
	void WriteIndentSpace() { }

	// RVA: 0xD66494
	void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0xD666C4
	void WriteNull() { }

	// RVA: 0xD666E0
	void WriteUndefined() { }

	// RVA: 0xD666FC
	void WriteRaw(string json) { }

	// RVA: 0xD66700
	void WriteRawValue(string json) { }

	// RVA: 0xD66754
	void WriteValue(string value) { }

	// RVA: 0xD66770
	void WriteValue(int value) { }

	// RVA: 0xD6678C
	void WriteValue(UInt32 value) { }

	// RVA: 0xD667A8
	void WriteValue(Int64 value) { }

	// RVA: 0xD667C4
	void WriteValue(UInt64 value) { }

	// RVA: 0xD667E0
	void WriteValue(float value) { }

	// RVA: 0xD667FC
	void WriteValue(Double value) { }

	// RVA: 0xD66818
	void WriteValue(bool value) { }

	// RVA: 0xD66834
	void WriteValue(Int16 value) { }

	// RVA: 0xD66850
	void WriteValue(UInt16 value) { }

	// RVA: 0xD6686C
	void WriteValue(Char value) { }

	// RVA: 0xD66888
	void WriteValue(Byte value) { }

	// RVA: 0xD668A4
	void WriteValue(SByte value) { }

	// RVA: 0xD668C0
	void WriteValue(Decimal value) { }

	// RVA: 0xD668DC
	void WriteValue(DateTime value) { }

	// RVA: 0xD668F8
	void WriteValue(DateTimeOffset value) { }

	// RVA: 0xD66914
	void WriteValue(Guid value) { }

	// RVA: 0xD66930
	void WriteValue(TimeSpan value) { }

	// RVA: 0xD6694C
	void WriteValue(System.Nullable<System.Int32> value) { }

	// RVA: 0xD66AA8
	void WriteValue(System.Nullable<System.UInt32> value) { }

	// RVA: 0xD66C04
	void WriteValue(System.Nullable<System.Int64> value) { }

	// RVA: 0xD66D60
	void WriteValue(System.Nullable<System.UInt64> value) { }

	// RVA: 0xD66EBC
	void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xD67018
	void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xD67174
	void WriteValue(System.Nullable<System.Boolean> value) { }

	// RVA: 0xD672D0
	void WriteValue(System.Nullable<System.Int16> value) { }

	// RVA: 0xD6742C
	void WriteValue(System.Nullable<System.UInt16> value) { }

	// RVA: 0xD67588
	void WriteValue(System.Nullable<System.Char> value) { }

	// RVA: 0xD676E4
	void WriteValue(System.Nullable<System.Byte> value) { }

	// RVA: 0xD67840
	void WriteValue(System.Nullable<System.SByte> value) { }

	// RVA: 0xD6799C
	void WriteValue(System.Nullable<System.Decimal> value) { }

	// RVA: 0xD67B34
	void WriteValue(System.Nullable<System.DateTime> value) { }

	// RVA: 0xD67C90
	void WriteValue(System.Nullable<System.DateTimeOffset> value) { }

	// RVA: 0xD67DE4
	void WriteValue(System.Nullable<System.Guid> value) { }

	// RVA: 0xD67F38
	void WriteValue(System.Nullable<System.TimeSpan> value) { }

	// RVA: 0xD68094
	void WriteValue(Byte[] value) { }

	// RVA: 0xD680C4
	void WriteValue(Uri value) { }

	// RVA: 0xD62634
	void WriteValue(object value) { }

	// RVA: 0xD692D0
	void WriteComment(string text) { }

	// RVA: 0xD692D8
	void System.IDisposable.Dispose() { }

	// RVA: 0xD6936C
	void Dispose(bool disposing) { }

	// RVA: 0xD68264
	void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xD6938C
	void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value) { }

	// RVA: 0xD68194
	JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0xD69564
	void SetWriteState(JsonToken token, object value) { }

	// RVA: 0xD650F4
	void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0xD61F08
	void InternalWritePropertyName(string name) { }

	// RVA: 0xD628C8
	void InternalWriteRaw() { }

	// RVA: 0xD61C10
	void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0xD6261C
	void InternalWriteValue(JsonToken token) { }

	// RVA: 0xD642E4
	void InternalWriteComment() { }

}

// Namespace: Newtonsoft.Json
public class JsonWriterException 
{
	// Fields
	private readonly string <Path>k__BackingField; // 0x90

	// Methods

	// RVA: 0xD697F0
	void .ctor() { }

	// RVA: 0xD697F8
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD69800
	void .ctor(string message, string path, Exception innerException) { }

	// RVA: 0xD69838
	JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0xD69870
	JsonWriterException Create(string path, string message, Exception ex) { }

}

// Namespace: Newtonsoft.Json
public enum MemberSerialization 
{
	// Fields
	public int value__; // 0x10
	public const MemberSerialization OptOut = 0;
	public const MemberSerialization OptIn = 1;
	public const MemberSerialization Fields = 2;
}

// Namespace: Newtonsoft.Json
public enum MetadataPropertyHandling 
{
	// Fields
	public int value__; // 0x10
	public const MetadataPropertyHandling Default = 0;
	public const MetadataPropertyHandling ReadAhead = 1;
	public const MetadataPropertyHandling Ignore = 2;
}

// Namespace: Newtonsoft.Json
public enum MissingMemberHandling 
{
	// Fields
	public int value__; // 0x10
	public const MissingMemberHandling Ignore = 0;
	public const MissingMemberHandling Error = 1;
}

// Namespace: Newtonsoft.Json
public enum NullValueHandling 
{
	// Fields
	public int value__; // 0x10
	public const NullValueHandling Include = 0;
	public const NullValueHandling Ignore = 1;
}

// Namespace: Newtonsoft.Json
public enum ObjectCreationHandling 
{
	// Fields
	public int value__; // 0x10
	public const ObjectCreationHandling Auto = 0;
	public const ObjectCreationHandling Reuse = 1;
	public const ObjectCreationHandling Replace = 2;
}

// Namespace: Newtonsoft.Json
public enum PreserveReferencesHandling 
{
	// Fields
	public int value__; // 0x10
	public const PreserveReferencesHandling None = 0;
	public const PreserveReferencesHandling Objects = 1;
	public const PreserveReferencesHandling Arrays = 2;
	public const PreserveReferencesHandling All = 3;
}

// Namespace: Newtonsoft.Json
public enum ReferenceLoopHandling 
{
	// Fields
	public int value__; // 0x10
	public const ReferenceLoopHandling Error = 0;
	public const ReferenceLoopHandling Ignore = 1;
	public const ReferenceLoopHandling Serialize = 2;
}

// Namespace: Newtonsoft.Json
public enum Required 
{
	// Fields
	public int value__; // 0x10
	public const Required Default = 0;
	public const Required AllowNull = 1;
	public const Required Always = 2;
	public const Required DisallowNull = 3;
}

// Namespace: Newtonsoft.Json
public enum StringEscapeHandling 
{
	// Fields
	public int value__; // 0x10
	public const StringEscapeHandling Default = 0;
	public const StringEscapeHandling EscapeNonAscii = 1;
	public const StringEscapeHandling EscapeHtml = 2;
}

// Namespace: Newtonsoft.Json
public enum TypeNameAssemblyFormatHandling 
{
	// Fields
	public int value__; // 0x10
	public const TypeNameAssemblyFormatHandling Simple = 0;
	public const TypeNameAssemblyFormatHandling Full = 1;
}

// Namespace: Newtonsoft.Json
public enum TypeNameHandling 
{
	// Fields
	public int value__; // 0x10
	public const TypeNameHandling None = 0;
	public const TypeNameHandling Objects = 1;
	public const TypeNameHandling Arrays = 2;
	public const TypeNameHandling All = 3;
	public const TypeNameHandling Auto = 4;
}

// Namespace: Newtonsoft.Json
public enum WriteState 
{
	// Fields
	public int value__; // 0x10
	public const WriteState Error = 0;
	public const WriteState Closed = 1;
	public const WriteState Object = 2;
	public const WriteState Array = 3;
	public const WriteState Constructor = 4;
	public const WriteState Property = 5;
	public const WriteState Start = 6;
}

// Namespace: Newtonsoft.Json.Utilities
internal class Base64Encoder 
{
	// Fields
	private readonly Char[] _charsLine; // 0x10
	private readonly TextWriter _writer; // 0x18
	private Byte[] _leftOverBytes; // 0x20
	private int _leftOverBytesCount; // 0x28

	// Methods

	// RVA: 0xD69938
	void .ctor(TextWriter writer) { }

	// RVA: 0xD69A60
	void ValidateEncode(Byte[] buffer, int index, int count) { }

	// RVA: 0xD69B44
	void Encode(Byte[] buffer, int index, int count) { }

	// RVA: 0xD69E88
	void StoreLeftOverBytes(Byte[] buffer, int index, ref int count) { }

	// RVA: 0xD69D9C
	bool FulfillFromLeftover(Byte[] buffer, int index, ref int count) { }

	// RVA: 0xD69FA4
	void Flush() { }

	// RVA: 0xD69E60
	void WriteChars(Char[] chars, int index, int count) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class BidirectionalDictionary<T0, T1> 
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<TFirst,TSecond> _firstToSecond; // 0x0
	private readonly System.Collections.Generic.IDictionary<TSecond,TFirst> _secondToFirst; // 0x0
	private readonly string _duplicateFirstErrorMessage; // 0x0
	private readonly string _duplicateSecondErrorMessage; // 0x0

	// Methods

	// RVA: 0x2FE4A14
	void .ctor(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }

	// RVA: 0x309AF8C
	void Set(TFirst first, TSecond second) { }

	// RVA: 0x309AF8C
	bool TryGetByFirst(TFirst first, out TSecond second) { }

	// RVA: 0x309AF8C
	bool TryGetBySecond(TSecond second, out TFirst first) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class BoxedPrimitives 
{
	// Fields
	internal static readonly object BooleanTrue; // 0x0
	internal static readonly object BooleanFalse; // 0x8
	internal static readonly object Int32_M1; // 0x10
	internal static readonly object Int32_0; // 0x18
	internal static readonly object Int32_1; // 0x20
	internal static readonly object Int32_2; // 0x28
	internal static readonly object Int32_3; // 0x30
	internal static readonly object Int32_4; // 0x38
	internal static readonly object Int32_5; // 0x40
	internal static readonly object Int32_6; // 0x48
	internal static readonly object Int32_7; // 0x50
	internal static readonly object Int32_8; // 0x58
	internal static readonly object Int64_M1; // 0x60
	internal static readonly object Int64_0; // 0x68
	internal static readonly object Int64_1; // 0x70
	internal static readonly object Int64_2; // 0x78
	internal static readonly object Int64_3; // 0x80
	internal static readonly object Int64_4; // 0x88
	internal static readonly object Int64_5; // 0x90
	internal static readonly object Int64_6; // 0x98
	internal static readonly object Int64_7; // 0xA0
	internal static readonly object Int64_8; // 0xA8
	private static readonly object DecimalZero; // 0xB0
	internal static readonly object DoubleNaN; // 0xB8
	internal static readonly object DoublePositiveInfinity; // 0xC0
	internal static readonly object DoubleNegativeInfinity; // 0xC8
	internal static readonly object DoubleZero; // 0xD0

	// Methods

	// RVA: 0xD6A05C
	object Get(bool value) { }

	// RVA: 0xD6A0F8
	object Get(int value) { }

	// RVA: 0xD6A464
	object Get(Int64 value) { }

	// RVA: 0xD6A704
	object Get(Decimal value) { }

	// RVA: 0xD6A7FC
	object Get(Double value) { }

	// RVA: 0xD6A964
	void .cctor() { }

}

// Namespace: 
private static class EmptyArrayContainer<T0> 
{
	// Fields
	public static readonly T[] Empty; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class CollectionUtils 
{
	// Methods

	// RVA: 0x2FE5724
	bool IsNullOrEmpty(System.Collections.Generic.ICollection<T> collection) { }

	// RVA: 0x2FEAB7C
	void AddRange(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0xD6AE84
	bool IsDictionaryType(Type type) { }

	// RVA: 0xD6B198
	ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0xD6B2BC
	ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	// RVA: 0x2FE6628
	int IndexOf(System.Collections.Generic.IEnumerable<T> collection, System.Func<T,System.Boolean> predicate) { }

	// RVA: 0x309AF8C
	bool Contains(System.Collections.Generic.List<T> list, T value, IEqualityComparer comparer) { }

	// RVA: 0x309AF8C
	int IndexOfReference(System.Collections.Generic.List<T> list, T item) { }

	// RVA: 0x2FE9A04
	void FastReverse(System.Collections.Generic.List<T> list) { }

	// RVA: 0xD6B630
	System.Collections.Generic.IList<System.Int32> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0xD6B994
	void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0xD6BC78
	object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0xD6BE24
	Array ToMultidimensionalArray(IList values, Type type, int rank) { }

	// RVA: 0x2FE704C
	T[] ArrayEmpty() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedCollection 
{
	// Methods

	// RVA: 0x2FE360C
	object get_UnderlyingCollection() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class CollectionWrapper<T0> 
{
	// Fields
	private readonly IList _list; // 0x0
	private readonly System.Collections.Generic.ICollection<T> _genericCollection; // 0x0
	private object _syncRoot; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void Add(T item) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	bool Contains(T item) { }

	// RVA: 0x2FE45DC
	void CopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE3054
	bool get_IsReadOnly() { }

	// RVA: 0x309AF8C
	bool Remove(T item) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FE3404
	int System.Collections.IList.Add(object value) { }

	// RVA: 0x2FE3174
	bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x2FE3404
	int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x2FE42A4
	void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x2FE440C
	void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x2FE3054
	bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x2FE4574
	void System.Collections.IList.Remove(object value) { }

	// RVA: -1
	object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x2FE440C
	void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x2FE45DC
	void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2FE3054
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FE360C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2FE9A04
	void VerifyValueType(object value) { }

	// RVA: 0x2FE5724
	bool IsCompatibleObject(object value) { }

	// RVA: 0x2FE360C
	object get_UnderlyingCollection() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal enum PrimitiveTypeCode 
{
	// Fields
	public int value__; // 0x10
	public const PrimitiveTypeCode Empty = 0;
	public const PrimitiveTypeCode Object = 1;
	public const PrimitiveTypeCode Char = 2;
	public const PrimitiveTypeCode CharNullable = 3;
	public const PrimitiveTypeCode Boolean = 4;
	public const PrimitiveTypeCode BooleanNullable = 5;
	public const PrimitiveTypeCode SByte = 6;
	public const PrimitiveTypeCode SByteNullable = 7;
	public const PrimitiveTypeCode Int16 = 8;
	public const PrimitiveTypeCode Int16Nullable = 9;
	public const PrimitiveTypeCode UInt16 = 10;
	public const PrimitiveTypeCode UInt16Nullable = 11;
	public const PrimitiveTypeCode Int32 = 12;
	public const PrimitiveTypeCode Int32Nullable = 13;
	public const PrimitiveTypeCode Byte = 14;
	public const PrimitiveTypeCode ByteNullable = 15;
	public const PrimitiveTypeCode UInt32 = 16;
	public const PrimitiveTypeCode UInt32Nullable = 17;
	public const PrimitiveTypeCode Int64 = 18;
	public const PrimitiveTypeCode Int64Nullable = 19;
	public const PrimitiveTypeCode UInt64 = 20;
	public const PrimitiveTypeCode UInt64Nullable = 21;
	public const PrimitiveTypeCode Single = 22;
	public const PrimitiveTypeCode SingleNullable = 23;
	public const PrimitiveTypeCode Double = 24;
	public const PrimitiveTypeCode DoubleNullable = 25;
	public const PrimitiveTypeCode DateTime = 26;
	public const PrimitiveTypeCode DateTimeNullable = 27;
	public const PrimitiveTypeCode DateTimeOffset = 28;
	public const PrimitiveTypeCode DateTimeOffsetNullable = 29;
	public const PrimitiveTypeCode Decimal = 30;
	public const PrimitiveTypeCode DecimalNullable = 31;
	public const PrimitiveTypeCode Guid = 32;
	public const PrimitiveTypeCode GuidNullable = 33;
	public const PrimitiveTypeCode TimeSpan = 34;
	public const PrimitiveTypeCode TimeSpanNullable = 35;
	public const PrimitiveTypeCode BigInteger = 36;
	public const PrimitiveTypeCode BigIntegerNullable = 37;
	public const PrimitiveTypeCode Uri = 38;
	public const PrimitiveTypeCode String = 39;
	public const PrimitiveTypeCode Bytes = 40;
	public const PrimitiveTypeCode DBNull = 41;
}

// Namespace: Newtonsoft.Json.Utilities
internal class TypeInformation 
{
	// Fields
	private readonly Type <Type>k__BackingField; // 0x10
	private readonly PrimitiveTypeCode <TypeCode>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD6C05C
	Type get_Type() { }

	// RVA: 0xD6C064
	PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0xD6C06C
	void .ctor(Type type, PrimitiveTypeCode typeCode) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal enum ParseResult 
{
	// Fields
	public int value__; // 0x10
	public const ParseResult None = 0;
	public const ParseResult Success = 1;
	public const ParseResult Overflow = 2;
	public const ParseResult Invalid = 3;
}

// Namespace: 
internal enum ConvertResult 
{
	// Fields
	public int value__; // 0x10
	public const ConvertResult Success = 0;
	public const ConvertResult CannotConvertNull = 1;
	public const ConvertResult NotInstantiableType = 2;
	public const ConvertResult NoValidConversion = 3;
}

// Namespace: 
private sealed class <>c__DisplayClass8_0 
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10

	// Methods

	// RVA: 0xD6CB28
	void .ctor() { }

	// RVA: 0xD70FC4
	object <CreateCastConverter>b__0(object o) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ConvertUtils 
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.Utilities.PrimitiveTypeCode> TypeCodeMap; // 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x8
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type>,System.Func<System.Object,System.Object>> CastConverters; // 0x10

	// Methods

	// RVA: 0xD6C0B4
	PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0xD6C124
	PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	// RVA: 0xD6C600
	TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0xD6C718
	bool IsConvertible(Type t) { }

	// RVA: 0xD6C7D0
	TimeSpan ParseTimeSpan(string input) { }

	// RVA: 0xD6C898
	System.Func<System.Object,System.Object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type> t) { }

	// RVA: 0xD6CB30
	BigInteger ToBigInteger(object value) { }

	// RVA: 0xD6D01C
	object FromBigInteger(BigInteger i, Type targetType) { }

	// RVA: 0xD6D554
	object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0xD6E4D0
	bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0xD6D80C
	ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0xD6EA6C
	object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0xD6E7F4
	object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0xD6E710
	bool VersionTryParse(string input, out Version result) { }

	// RVA: 0xD6E624
	bool IsInteger(object value) { }

	// RVA: 0xD6EC3C
	ParseResult Int32TryParse(Char[] chars, int start, int length, out int value) { }

	// RVA: 0xD6EDF4
	ParseResult Int64TryParse(Char[] chars, int start, int length, out Int64 value) { }

	// RVA: 0xD6EF84
	ParseResult DecimalTryParse(Char[] chars, int start, int length, out Decimal value) { }

	// RVA: 0xD6FAA8
	bool TryConvertGuid(string s, out Guid g) { }

	// RVA: 0xD6FB08
	bool TryHexTextToInt(Char[] text, int start, int end, out int value) { }

	// RVA: 0xD6FBE4
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal enum ParserTimeZone 
{
	// Fields
	public int value__; // 0x10
	public const ParserTimeZone Unspecified = 0;
	public const ParserTimeZone Utc = 1;
	public const ParserTimeZone LocalWestOfUtc = 2;
	public const ParserTimeZone LocalEastOfUtc = 3;
}

// Namespace: Newtonsoft.Json.Utilities
internal struct DateTimeParser 
{
	// Fields
	public int Year; // 0x10
	public int Month; // 0x14
	public int Day; // 0x18
	public int Hour; // 0x1C
	public int Minute; // 0x20
	public int Second; // 0x24
	public int Fraction; // 0x28
	public int ZoneHour; // 0x2C
	public int ZoneMinute; // 0x30
	public ParserTimeZone Zone; // 0x34
	private Char[] _text; // 0x38
	private int _end; // 0x40
	private static readonly int[] Power10; // 0x0
	private static readonly int Lzyyyy; // 0x8
	private static readonly int Lzyyyy_; // 0xC
	private static readonly int Lzyyyy_MM; // 0x10
	private static readonly int Lzyyyy_MM_; // 0x14
	private static readonly int Lzyyyy_MM_dd; // 0x18
	private static readonly int Lzyyyy_MM_ddT; // 0x1C
	private static readonly int LzHH; // 0x20
	private static readonly int LzHH_; // 0x24
	private static readonly int LzHH_mm; // 0x28
	private static readonly int LzHH_mm_; // 0x2C
	private static readonly int LzHH_mm_ss; // 0x30
	private static readonly int Lz_; // 0x34
	private static readonly int Lz_zz; // 0x38

	// Methods

	// RVA: 0xD7109C
	void .cctor() { }

	// RVA: 0xD7132C
	bool Parse(Char[] text, int startIndex, int length) { }

	// RVA: 0xD7152C
	bool ParseDate(int start) { }

	// RVA: 0xD7182C
	bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0xD71AA4
	bool ParseTime(ref int start) { }

	// RVA: 0xD720B0
	bool ParseZone(int start) { }

	// RVA: 0xD718F0
	bool Parse4Digit(int start, out int num) { }

	// RVA: 0xD719F4
	bool Parse2Digit(int start, out int num) { }

	// RVA: 0xD717D8
	bool ParseChar(int start, Char ch) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class DateTimeUtils 
{
	// Fields
	internal static readonly Int64 InitialJavaScriptDateTicks; // 0x0
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10

	// Methods

	// RVA: 0xD723F8
	void .cctor() { }

	// RVA: 0xD724FC
	TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0xD72588
	XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0xD72708
	DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0xD728A4
	DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xD729BC
	DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0xD72AD0
	Int64 ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0xD72C4C
	Int64 ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0xD72E14
	Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0xD72F68
	Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0xD72FF0
	Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0xD72EE0
	Int64 UniversalTicksToJavaScriptTicks(Int64 universalTicks) { }

	// RVA: 0xD73138
	DateTime ConvertJavaScriptTicksToDateTime(Int64 javaScriptTicks) { }

	// RVA: 0xD731C8
	bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0xD73818
	bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0xD73714
	DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0xD73AF4
	bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0xD74228
	bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0xD74548
	bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0xD74A90
	bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0xD74DFC
	bool TryParseMicrosoftDate(StringReference text, out Int64 ticks, out TimeSpan offset, out DateTimeKind kind) { }

	// RVA: 0xD73F40
	bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0xD74138
	bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0xD747FC
	bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0xD749D0
	bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0xD7509C
	bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	// RVA: 0xD75240
	void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0xD753D0
	int WriteDateTimeString(Char[] chars, int start, DateTime value, System.Nullable<System.TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0xD75CE8
	int WriteDefaultIsoDate(Char[] chars, int start, DateTime dt) { }

	// RVA: 0xD76504
	void CopyIntToCharArray(Char[] chars, int start, int value, int digits) { }

	// RVA: 0xD75A1C
	int WriteDateTimeOffset(Char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0xD76570
	void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0xD762A8
	void GetDateValues(DateTime td, out int year, out int month, out int day) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedDictionary 
{
	// Methods

	// RVA: 0x2FE360C
	object get_UnderlyingDictionary() { }

}

// Namespace: 
private struct DictionaryEnumerator<T0, T1> 
{
	// Fields
	private readonly System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> _e; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }

	// RVA: -1
	DictionaryEntry get_Entry() { }

	// RVA: 0x2FE360C
	object get_Key() { }

	// RVA: 0x2FE360C
	object get_Value() { }

	// RVA: 0x2FE360C
	object get_Current() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Reset() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.DictionaryWrapper.<>c<TKey,TValue> <>9; // 0x0
	public static System.Func<System.Collections.DictionaryEntry,System.Collections.Generic.KeyValuePair<TKey,TValue>> <>9__29_0; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	System.Collections.Generic.KeyValuePair<TKey,TValue> <GetEnumerator>b__29_0(DictionaryEntry de) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class DictionaryWrapper<T0, T1> 
{
	// Fields
	private readonly IDictionary _dictionary; // 0x0
	private readonly System.Collections.Generic.IDictionary<TKey,TValue> _genericDictionary; // 0x0
	private readonly System.Collections.Generic.IReadOnlyDictionary<TKey,TValue> _readOnlyDictionary; // 0x0
	private object _syncRoot; // 0x0

	// Methods

	// RVA: 0x2FE360C
	System.Collections.Generic.IDictionary<TKey,TValue> get_GenericDictionary() { }

	// RVA: 0x309AF8C
	void Add(TKey key, TValue value) { }

	// RVA: 0x309AF8C
	bool ContainsKey(TKey key) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.ICollection<TKey> get_Keys() { }

	// RVA: 0x309AF8C
	bool Remove(TKey key) { }

	// RVA: 0x309AF8C
	bool TryGetValue(TKey key, out TValue value) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.ICollection<TValue> get_Values() { }

	// RVA: 0x309AF8C
	TValue get_Item(TKey key) { }

	// RVA: 0x309AF8C
	void set_Item(TKey key, TValue value) { }

	// RVA: 0x309AF8C
	void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	bool Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x2FE45DC
	void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE3054
	bool get_IsReadOnly() { }

	// RVA: 0x309AF8C
	bool Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FE47D4
	void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x2FE36BC
	object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x2FE47D4
	void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x2FE360C
	IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x2FE3174
	bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x2FE3054
	bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x2FE360C
	ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x2FE4574
	void Remove(object key) { }

	// RVA: 0x2FE360C
	ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x2FE45DC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2FE3054
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FE360C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2FE360C
	object get_UnderlyingDictionary() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class DynamicProxy<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(T instance) { }

	// RVA: 0x309AF8C
	bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, out object result) { }

	// RVA: 0x309AF8C
	bool TryConvert(T instance, ConvertBinder binder, out object result) { }

	// RVA: 0x309AF8C
	bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, out object result) { }

	// RVA: 0x309AF8C
	bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes) { }

	// RVA: 0x309AF8C
	bool TryDeleteMember(T instance, DeleteMemberBinder binder) { }

	// RVA: 0x309AF8C
	bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, out object result) { }

	// RVA: 0x309AF8C
	bool TryGetMember(T instance, GetMemberBinder binder, out object result) { }

	// RVA: 0x309AF8C
	bool TryInvoke(T instance, InvokeBinder binder, object[] args, out object result) { }

	// RVA: 0x309AF8C
	bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, out object result) { }

	// RVA: 0x309AF8C
	bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value) { }

	// RVA: 0x309AF8C
	bool TrySetMember(T instance, SetMemberBinder binder, object value) { }

	// RVA: 0x309AF8C
	bool TryUnaryOperation(T instance, UnaryOperationBinder binder, out object result) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class Fallback 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x2FE36BC
	internal DynamicMetaObject Invoke(DynamicMetaObject errorSuggestion) { }

}

// Namespace: 
private sealed class GetBinderAdapter 
{
	// Methods

	// RVA: 0x2FE4574
	void .ctor(InvokeMemberBinder binder) { }

	// RVA: 0x2FE37A0
	DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.DynamicProxyMetaObject.<>c<T> <>9; // 0x0
	public static System.Func<System.Dynamic.DynamicMetaObject,System.Linq.Expressions.Expression> <>9__18_0; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	Expression <GetArgs>b__18_0(DynamicMetaObject arg) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0 
{
	// Fields
	public BinaryOperationBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject arg; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindBinaryOperation>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0 
{
	// Fields
	public UnaryOperationBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindUnaryOperation>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass12_0 
{
	// Fields
	public GetIndexBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject[] indexes; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindGetIndex>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0 
{
	// Fields
	public SetIndexBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject[] indexes; // 0x0
	public DynamicMetaObject value; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindSetIndex>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_0 
{
	// Fields
	public DeleteIndexBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject[] indexes; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindDeleteIndex>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0 
{
	// Fields
	public GetMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindGetMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public SetMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject value; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindSetMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public DeleteMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindDeleteMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public ConvertBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindConvert>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public InvokeMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindInvokeMember>b__0(DynamicMetaObject e) { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindInvokeMember>b__1(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0 
{
	// Fields
	public CreateInstanceBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindCreateInstance>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0 
{
	// Fields
	public InvokeBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	DynamicMetaObject <BindInvoke>b__0(DynamicMetaObject e) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class DynamicProxyMetaObject<T0> 
{
	// Fields
	private readonly Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void .ctor(Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy) { }

	// RVA: 0x2FE3174
	bool IsOverridden(string method) { }

	// RVA: 0x2FE36BC
	DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x2FE37A0
	DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x2FE36BC
	DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x2FE36BC
	DynamicMetaObject BindConvert(ConvertBinder binder) { }

	// RVA: 0x2FE37A0
	DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x2FE37A0
	DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x2FE37A0
	DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x2FE37A0
	DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	// RVA: 0x2FE36BC
	DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	// RVA: 0x2FE37A0
	DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x2FE3810
	DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: 0x2FE37A0
	DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x2FE704C
	Expression[] get_NoArgs() { }

	// RVA: 0x2FE7084
	System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(DynamicMetaObject[] args) { }

	// RVA: 0x2FE7084
	Expression[] GetArgArray(DynamicMetaObject[] args) { }

	// RVA: 0x2FE7164
	Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value) { }

	// RVA: 0x2FE7084
	ConstantExpression Constant(DynamicMetaObjectBinder binder) { }

	// RVA: 0x2FE38F4
	DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Fallback fallback, Fallback fallbackInvoke) { }

	// RVA: 0x2FE38F4
	DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, DynamicMetaObject fallbackResult, Fallback fallbackInvoke) { }

	// RVA: 0x2FE3884
	DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Fallback fallback) { }

	// RVA: 0x2FE3884
	DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Fallback fallback) { }

	// RVA: 0x2FE360C
	BindingRestrictions GetRestrictions() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames() { }

}

// Namespace: 
internal static class BinderWrapper 
{
	// Fields
	private static object _getCSharpArgumentInfoArray; // 0x0
	private static object _setCSharpArgumentInfoArray; // 0x8
	private static Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _getMemberCall; // 0x10
	private static Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _setMemberCall; // 0x18
	private static bool _init; // 0x20

	// Methods

	// RVA: 0xD76890
	void Init() { }

	// RVA: 0xD76A8C
	object CreateSharpArgumentInfoArray(int[] values) { }

	// RVA: 0xD76D9C
	void CreateMemberCalls() { }

	// RVA: 0xD772D4
	CallSiteBinder GetMember(string name, Type context) { }

	// RVA: 0xD774EC
	CallSiteBinder SetMember(string name, Type context) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class DynamicUtils 
{
	// Methods

	// RVA: 0xD7676C
	System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowGetBinderMember 
{
	// Fields
	private readonly GetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0xD77704
	void .ctor(GetMemberBinder innerBinder) { }

	// RVA: 0xD77748
	DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowSetBinderMember 
{
	// Fields
	private readonly SetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0xD778E0
	void .ctor(SetMemberBinder innerBinder) { }

	// RVA: 0xD77924
	DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowExpressionVisitor 
{
	// Fields
	internal static readonly object ErrorResult; // 0x0

	// Methods

	// RVA: 0xD77A7C
	Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0xD778D8
	void .ctor() { }

	// RVA: 0xD77B74
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class EnumInfo 
{
	// Fields
	public readonly bool IsFlags; // 0x10
	public readonly UInt64[] Values; // 0x18
	public readonly string[] Names; // 0x20
	public readonly string[] ResolvedNames; // 0x28

	// Methods

	// RVA: 0xD77BFC
	void .ctor(bool isFlags, UInt64[] values, string[] names, string[] resolvedNames) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.EnumUtils.<>c <>9; // 0x0
	public static System.Func<System.Runtime.Serialization.EnumMemberAttribute,System.String> <>9__3_0; // 0x8

	// Methods

	// RVA: 0xD796B8
	void .cctor() { }

	// RVA: 0xD79724
	void .ctor() { }

	// RVA: 0xD7972C
	string <InitializeValuesAndNames>b__3_0(EnumMemberAttribute a) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class EnumUtils 
{
	// Fields
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum; // 0x0
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x8

	// Methods

	// RVA: 0xD77C70
	EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy> key) { }

	// RVA: 0xD785A8
	bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, out string name) { }

	// RVA: 0xD78764
	string InternalFlagsFormat(EnumInfo entry, UInt64 result) { }

	// RVA: 0xD789D8
	EnumInfo GetEnumValuesAndNames(Type enumType) { }

	// RVA: 0xD78200
	UInt64 ToUInt64(object value) { }

	// RVA: 0xD78AB0
	object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	// RVA: 0xD79468
	System.Nullable<System.Int32> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0xD79368
	System.Nullable<System.Int32> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0xD79580
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class FSharpFunction 
{
	// Fields
	private readonly object _instance; // 0x10
	private readonly Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _invoker; // 0x18

	// Methods

	// RVA: 0xD79748
	void .ctor(object instance, Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoker) { }

	// RVA: 0xD79798
	object Invoke(object[] args) { }

}

// Namespace: 
private sealed class <>c__55<T0, T1> 
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.FSharpUtils.<>c__55<TKey,TValue> <>9; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,System.Tuple<TKey,TValue>> <>9__55_1; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	System.Tuple<TKey,TValue> <BuildMapCreator>b__55_1(System.Collections.Generic.KeyValuePair<TKey,TValue> kv) { }

}

// Namespace: 
private sealed class <>c__DisplayClass52_0 
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoke; // 0x18

	// Methods

	// RVA: 0xD7A320
	void .ctor() { }

	// RVA: 0xD7A69C
	object <CreateFSharpFuncCall>b__0(object target, object[] args) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0<T0, T1> 
{
	// Fields
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> ctorDelegate; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE36BC
	object <BuildMapCreator>b__0(object[] args) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class FSharpUtils 
{
	// Fields
	private static readonly object Lock; // 0x0
	private static FSharpUtils _instance; // 0x8
	private MethodInfo _ofSeq; // 0x10
	private Type _mapType; // 0x18
	private Assembly <FSharpCoreAssembly>k__BackingField; // 0x20
	private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <IsUnion>k__BackingField; // 0x28
	private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <GetUnionCases>k__BackingField; // 0x30
	private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <PreComputeUnionTagReader>k__BackingField; // 0x38
	private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <PreComputeUnionReader>k__BackingField; // 0x40
	private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <PreComputeUnionConstructor>k__BackingField; // 0x48
	private System.Func<System.Object,System.Object> <GetUnionCaseInfoDeclaringType>k__BackingField; // 0x50
	private System.Func<System.Object,System.Object> <GetUnionCaseInfoName>k__BackingField; // 0x58
	private System.Func<System.Object,System.Object> <GetUnionCaseInfoTag>k__BackingField; // 0x60
	private Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> <GetUnionCaseInfoFields>k__BackingField; // 0x68

	// Methods

	// RVA: 0xD797DC
	void .ctor(Assembly fsharpCoreAssembly) { }

	// RVA: 0xD7A064
	FSharpUtils get_Instance() { }

	// RVA: 0xD7A0E0
	void set_FSharpCoreAssembly(Assembly value) { }

	// RVA: 0xD7A0E8
	Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_IsUnion() { }

	// RVA: 0xD7A0F0
	void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xD7A0F8
	Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCases() { }

	// RVA: 0xD7A100
	void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xD7A108
	Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionTagReader() { }

	// RVA: 0xD7A110
	void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xD7A118
	Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionReader() { }

	// RVA: 0xD7A120
	void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xD7A128
	Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionConstructor() { }

	// RVA: 0xD7A130
	void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xD7A138
	System.Func<System.Object,System.Object> get_GetUnionCaseInfoDeclaringType() { }

	// RVA: 0xD7A140
	void set_GetUnionCaseInfoDeclaringType(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xD7A148
	System.Func<System.Object,System.Object> get_GetUnionCaseInfoName() { }

	// RVA: 0xD7A150
	void set_GetUnionCaseInfoName(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xD7A158
	System.Func<System.Object,System.Object> get_GetUnionCaseInfoTag() { }

	// RVA: 0xD7A160
	void set_GetUnionCaseInfoTag(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xD7A168
	Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCaseInfoFields() { }

	// RVA: 0xD7A170
	void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xD7A178
	void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	// RVA: 0xD79DB4
	MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	// RVA: 0xD79E2C
	Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> CreateFSharpFuncCall(Type type, string methodName) { }

	// RVA: 0xD7A328
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateSeq(Type t) { }

	// RVA: 0xD7A430
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateMap(Type keyType, Type valueType) { }

	// RVA: 0x2FE360C
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> BuildMapCreator() { }

	// RVA: 0xD7A614
	void .cctor() { }

}

// Namespace: 
internal class ImmutableCollectionTypeInfo 
{
	// Fields
	private string <ContractTypeName>k__BackingField; // 0x10
	private string <CreatedTypeName>k__BackingField; // 0x18
	private string <BuilderTypeName>k__BackingField; // 0x20

	// Methods

	// RVA: 0xD7B970
	void .ctor(string contractTypeName, string createdTypeName, string builderTypeName) { }

	// RVA: 0xD7B9D4
	string get_ContractTypeName() { }

	// RVA: 0xD7B9DC
	void set_ContractTypeName(string value) { }

	// RVA: 0xD7B9E4
	string get_CreatedTypeName() { }

	// RVA: 0xD7B9EC
	void set_CreatedTypeName(string value) { }

	// RVA: 0xD7B9F4
	string get_BuilderTypeName() { }

	// RVA: 0xD7B9FC
	void set_BuilderTypeName(string value) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.<>c <>9; // 0x0
	public static System.Func<System.Reflection.MethodInfo,System.Boolean> <>9__24_1; // 0x8
	public static System.Func<System.Reflection.MethodInfo,System.Boolean> <>9__25_1; // 0x10

	// Methods

	// RVA: 0xD7BA04
	void .cctor() { }

	// RVA: 0xD7BA70
	void .ctor() { }

	// RVA: 0xD7BA78
	bool <TryBuildImmutableForArrayContract>b__24_1(MethodInfo m) { }

	// RVA: 0xD7BB08
	bool <TryBuildImmutableForDictionaryContract>b__25_1(MethodInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass24_0 
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0xD7AC5C
	void .ctor() { }

	// RVA: 0xD7BC70
	bool <TryBuildImmutableForArrayContract>b__0(ImmutableCollectionTypeInfo d) { }

}

// Namespace: 
private sealed class <>c__DisplayClass25_0 
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0xD7B1D4
	void .ctor() { }

	// RVA: 0xD7BC98
	bool <TryBuildImmutableForDictionaryContract>b__0(ImmutableCollectionTypeInfo d) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ImmutableCollectionsUtils 
{
	// Fields
	private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x0
	private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x8

	// Methods

	// RVA: 0xD7A760
	bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }

	// RVA: 0xD7AC88
	bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }

	// RVA: 0xD7B1DC
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class BufferUtils 
{
	// Methods

	// RVA: 0xD7BCC0
	Char[] RentBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int minSize) { }

	// RVA: 0xD7BD98
	void ReturnBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] buffer) { }

	// RVA: 0xD7BE58
	Char[] EnsureBufferSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int size, Char[] buffer) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class JavaScriptUtils 
{
	// Fields
	internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x0
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x8
	internal static readonly bool[] HtmlCharEscapeFlags; // 0x10

	// Methods

	// RVA: 0xD7BF98
	void .cctor() { }

	// RVA: 0xD7CA14
	bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, Char quoteChar) { }

	// RVA: 0xD7CB00
	bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	// RVA: 0xD7CBAC
	void WriteEscapedJavaScriptString(TextWriter writer, string s, Char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<System.Char> bufferPool, ref Char[] writeBuffer) { }

	// RVA: 0xD7D4AC
	string ToEscapedJavaScriptString(string value, Char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xD7D2CC
	int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xD7D808
	bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage) { }

	// RVA: 0xD7DD4C
	bool TryGetDateConstructorValue(JsonReader reader, out System.Nullable<System.Int64>& integer, out string errorMessage) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class JsonTokenUtils 
{
	// Methods

	// RVA: 0xD7DF24
	bool IsEndToken(JsonToken token) { }

	// RVA: 0xD7DF34
	bool IsStartToken(JsonToken token) { }

	// RVA: 0xD7DF44
	bool IsPrimitiveToken(JsonToken token) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0 
{
	// Fields
	public ConstructorInfo c; // 0x10
	public MethodBase method; // 0x18

	// Methods

	// RVA: 0xD7E19C
	void .ctor() { }

	// RVA: 0xD7E220
	object <CreateParameterizedConstructor>b__0(object[] a) { }

	// RVA: 0xD7E240
	object <CreateParameterizedConstructor>b__1(object[] a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0<T0> 
{
	// Fields
	public ConstructorInfo c; // 0x0
	public MethodBase method; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	object <CreateMethodCall>b__0(T o, object[] a) { }

	// RVA: 0x309AF8C
	object <CreateMethodCall>b__1(T o, object[] a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0<T0> 
{
	// Fields
	public Type type; // 0x0
	public ConstructorInfo constructorInfo; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	T <CreateDefaultConstructor>b__0() { }

	// RVA: 0x309AF8C
	T <CreateDefaultConstructor>b__1() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0<T0> 
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	object <CreateGet>b__0(T o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0<T0> 
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	object <CreateGet>b__0(T o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0<T0> 
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	void <CreateSet>b__0(T o, object v) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0<T0> 
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	void <CreateSet>b__0(T o, object v) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class LateBoundReflectionDelegateFactory 
{
	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x0

	// Methods

	// RVA: 0xD7DF5C
	ReflectionDelegateFactory get_Instance() { }

	// RVA: 0xD7DFD8
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: 0x2FE36BC
	Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(MethodBase method) { }

	// RVA: 0x2FE36BC
	System.Func<T> CreateDefaultConstructor(Type type) { }

	// RVA: 0x2FE36BC
	System.Func<T,System.Object> CreateGet(PropertyInfo propertyInfo) { }

	// RVA: 0x2FE36BC
	System.Func<T,System.Object> CreateGet(FieldInfo fieldInfo) { }

	// RVA: 0x2FE36BC
	System.Action<T,System.Object> CreateSet(FieldInfo fieldInfo) { }

	// RVA: 0x2FE36BC
	System.Action<T,System.Object> CreateSet(PropertyInfo propertyInfo) { }

	// RVA: 0xD7E1A4
	void .ctor() { }

	// RVA: 0xD7E1B4
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class MathUtils 
{
	// Methods

	// RVA: 0xD7E268
	int IntLength(UInt64 i) { }

	// RVA: 0xD7E430
	Char IntToHex(int n) { }

	// RVA: 0xD7E44C
	bool ApproxEquals(Double d1, Double d2) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class MethodCall<T0, T1> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal TResult Invoke(T target, object[] args) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class MiscellaneousUtils 
{
	// Methods

	// RVA: 0xD7E500
	bool ValueEquals(object objA, object objB) { }

	// RVA: 0xD72610
	ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	// RVA: 0xD7E908
	string ToString(object value) { }

	// RVA: 0xD7E9BC
	int ByteArrayCompare(Byte[] a1, Byte[] a2) { }

	// RVA: 0xD7EA84
	string GetPrefix(string qualifiedName) { }

	// RVA: 0xD7EB7C
	string GetLocalName(string qualifiedName) { }

	// RVA: 0xD7EAB0
	void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName) { }

	// RVA: 0xD7EBC0
	RegexOptions GetRegexOptions(string optionsText) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal abstract class ReflectionDelegateFactory 
{
	// Methods

	// RVA: 0x2FE36BC
	System.Func<T,System.Object> CreateGet(MemberInfo memberInfo) { }

	// RVA: 0x2FE36BC
	System.Action<T,System.Object> CreateSet(MemberInfo memberInfo) { }

	// RVA: 0x2FE36BC
	Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(MethodBase method) { }

	// RVA: 0x2FE36BC
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: 0x2FE36BC
	System.Func<T> CreateDefaultConstructor(Type type) { }

	// RVA: 0x2FE36BC
	System.Func<T,System.Object> CreateGet(PropertyInfo propertyInfo) { }

	// RVA: 0x2FE36BC
	System.Func<T,System.Object> CreateGet(FieldInfo fieldInfo) { }

	// RVA: 0x2FE36BC
	System.Action<T,System.Object> CreateSet(FieldInfo fieldInfo) { }

	// RVA: 0x2FE36BC
	System.Action<T,System.Object> CreateSet(PropertyInfo propertyInfo) { }

	// RVA: 0xD7E1AC
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ReflectionMember 
{
	// Fields
	private Type <MemberType>k__BackingField; // 0x10
	private System.Func<System.Object,System.Object> <Getter>k__BackingField; // 0x18
	private System.Action<System.Object,System.Object> <Setter>k__BackingField; // 0x20

	// Methods

	// RVA: 0xD7EC74
	Type get_MemberType() { }

	// RVA: 0xD7EC7C
	void set_MemberType(Type value) { }

	// RVA: 0xD7EC84
	System.Func<System.Object,System.Object> get_Getter() { }

	// RVA: 0xD7EC8C
	void set_Getter(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xD7EC94
	System.Action<System.Object,System.Object> get_Setter() { }

	// RVA: 0xD7EC9C
	void set_Setter(System.Action<System.Object,System.Object> value) { }

	// RVA: 0xD7ECA4
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0 
{
	// Fields
	public System.Func<System.Object> ctor; // 0x10

	// Methods

	// RVA: 0xD7FA0C
	void .ctor() { }

	// RVA: 0xD7FFD8
	object <Create>b__0(object[] args) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_1 
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10

	// Methods

	// RVA: 0xD7FD34
	void .ctor() { }

	// RVA: 0xD80014
	object <Create>b__1(object target) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_2 
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10

	// Methods

	// RVA: 0xD7FD3C
	void .ctor() { }

	// RVA: 0xD8012C
	void <Create>b__2(object target, object arg) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ReflectionObject 
{
	// Fields
	private readonly Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <Creator>k__BackingField; // 0x10
	private readonly System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD7ECAC
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_Creator() { }

	// RVA: 0xD7ECB4
	System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> get_Members() { }

	// RVA: 0xD7ECBC
	void .ctor(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator) { }

	// RVA: 0xD7ED64
	object GetValue(object target, string member) { }

	// RVA: 0xD7EE64
	void SetValue(object target, string member, object value) { }

	// RVA: 0xD7EF60
	Type GetType(string member) { }

	// RVA: 0xD7F030
	ReflectionObject Create(Type t, string[] memberNames) { }

	// RVA: 0xD7F03C
	ReflectionObject Create(Type t, MethodBase creator, string[] memberNames) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.ReflectionUtils.<>c <>9; // 0x0
	public static System.Func<System.Reflection.ConstructorInfo,System.Boolean> <>9__11_0; // 0x8
	public static System.Func<System.Reflection.MemberInfo,System.String> <>9__31_0; // 0x10
	public static System.Func<System.Reflection.ParameterInfo,System.Type> <>9__39_0; // 0x18
	public static System.Func<System.Reflection.FieldInfo,System.Boolean> <>9__41_0; // 0x20

	// Methods

	// RVA: 0xD84A28
	void .cctor() { }

	// RVA: 0xD84A94
	void .ctor() { }

	// RVA: 0xD84A9C
	bool <GetDefaultConstructor>b__11_0(ConstructorInfo c) { }

	// RVA: 0xD84B08
	string <GetFieldsAndProperties>b__31_0(MemberInfo m) { }

	// RVA: 0xD84B30
	Type <GetMemberInfoFromType>b__39_0(ParameterInfo p) { }

	// RVA: 0xD84B58
	bool <GetChildPrivateFields>b__41_0(FieldInfo f) { }

}

// Namespace: 
private sealed class <>c__DisplayClass31_0 
{
	// Fields
	public MemberInfo memberInfo; // 0x10

	// Methods

	// RVA: 0xD832E0
	void .ctor() { }

	// RVA: 0xD84B74
	bool <GetFieldsAndProperties>b__1(MemberInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass44_0 
{
	// Fields
	public PropertyInfo subTypeProperty; // 0x10

	// Methods

	// RVA: 0xD84604
	void .ctor() { }

	// RVA: 0xD84C14
	bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	// RVA: 0xD84C70
	bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass44_1 
{
	// Fields
	public Type subTypePropertyDeclaringType; // 0x10
	public Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xD8460C
	void .ctor() { }

	// RVA: 0xD84D5C
	bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_0 
{
	// Fields
	public string method; // 0x10
	public Type methodDeclaringType; // 0x18

	// Methods

	// RVA: 0xD84730
	void .ctor() { }

	// RVA: 0xD84E94
	bool <IsMethodOverridden>b__0(MethodInfo info) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ReflectionUtils 
{
	// Fields
	public static readonly Type[] EmptyTypes; // 0x0

	// Methods

	// RVA: 0xD8020C
	void .cctor() { }

	// RVA: 0xD80290
	bool IsVirtual(PropertyInfo propertyInfo) { }

	// RVA: 0xD803BC
	MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0xD804B0
	bool IsPublic(PropertyInfo property) { }

	// RVA: 0xD6EC2C
	Type GetObjectType(object v) { }

	// RVA: 0xD8055C
	string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder) { }

	// RVA: 0xD80680
	string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder) { }

	// RVA: 0xD807C8
	string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0xD7F8F4
	bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0xD80AC0
	ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0xD8095C
	ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0xD6E718
	bool IsNullable(Type t) { }

	// RVA: 0xD6C4EC
	bool IsNullableType(Type t) { }

	// RVA: 0xD80B48
	Type EnsureNotNullableType(Type t) { }

	// RVA: 0xD80BE4
	Type EnsureNotByRefType(Type t) { }

	// RVA: 0xD80C44
	bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0xD6B11C
	bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0xD80CF8
	bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	// RVA: 0xD80FD4
	bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0xD81050
	bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0xD811E0
	bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0xD81350
	Type GetCollectionItemType(Type type) { }

	// RVA: 0xD815D8
	void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	// RVA: 0xD7FD44
	Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0xD81868
	bool IsByRefLikeType(Type type) { }

	// RVA: 0xD81E70
	bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0xD81F1C
	object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0xD8225C
	void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0xD7FA34
	bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0xD7FB9C
	bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0xD8248C
	System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0xD832E8
	bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: 0x309AF8C
	T GetAttribute(object attributeProvider) { }

	// RVA: 0x309AF8C
	T GetAttribute(object attributeProvider, bool inherit) { }

	// RVA: -1
	T[] GetAttributes(object attributeProvider, bool inherit) { }

	// RVA: 0xD81978
	Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0xD834E4
	Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) { }

	// RVA: 0xD837A0
	System.Nullable<System.Int32> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0xD83A4C
	MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0xD82E0C
	System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0xD83CDC
	void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, Type type, BindingFlags bindingAttr) { }

	// RVA: 0xD82F58
	System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0xD83EDC
	BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0xD83EEC
	void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr) { }

	// RVA: 0xD84614
	bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method) { }

	// RVA: 0xD84738
	object GetDefaultValue(Type type) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StringBuffer 
{
	// Fields
	private Char[] _buffer; // 0x10
	private int _position; // 0x18

	// Methods

	// RVA: 0xD84FC4
	int get_Position() { }

	// RVA: 0xD84FCC
	void set_Position(int value) { }

	// RVA: 0xD84FD4
	bool get_IsEmpty() { }

	// RVA: 0xD84FE4
	void .ctor(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int initalSize) { }

	// RVA: 0xD85020
	void .ctor(Char[] buffer) { }

	// RVA: 0xD85048
	void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char value) { }

	// RVA: 0xD851C0
	void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] buffer, int startIndex, int count) { }

	// RVA: 0xD85244
	void Clear(Newtonsoft.Json.IArrayPool<System.Char> bufferPool) { }

	// RVA: 0xD850C4
	void EnsureSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int appendLength) { }

	// RVA: 0xD85314
	string ToString() { }

	// RVA: 0xD8532C
	string ToString(int start, int length) { }

	// RVA: 0xD85344
	Char[] get_InternalBuffer() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StringReference 
{
	// Fields
	private readonly Char[] _chars; // 0x10
	private readonly int _startIndex; // 0x18
	private readonly int _length; // 0x1C

	// Methods

	// RVA: 0xD73D48
	Char get_Item(int i) { }

	// RVA: 0xD8534C
	Char[] get_Chars() { }

	// RVA: 0xD85354
	int get_StartIndex() { }

	// RVA: 0xD8535C
	int get_Length() { }

	// RVA: 0xD74510
	void .ctor(Char[] chars, int startIndex, int length) { }

	// RVA: 0xD74124
	string ToString() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class StringReferenceExtensions 
{
	// Methods

	// RVA: 0xD75000
	int IndexOf(StringReference s, Char c, int startIndex, int length) { }

	// RVA: 0xD73D7C
	bool StartsWith(StringReference s, string text) { }

	// RVA: 0xD73E5C
	bool EndsWith(StringReference s, string text) { }

}

// Namespace: 
private enum SeparatedCaseState 
{
	// Fields
	public int value__; // 0x10
	public const SeparatedCaseState Start = 0;
	public const SeparatedCaseState Lower = 1;
	public const SeparatedCaseState Upper = 2;
	public const SeparatedCaseState NewWord = 3;
}

// Namespace: 
private sealed class <>c__DisplayClass14_0<T0> 
{
	// Fields
	public System.Func<TSource,System.String> valueSelector; // 0x0
	public string testValue; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }

	// RVA: 0x309AF8C
	bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class StringUtils 
{
	// Methods

	// RVA: 0xD7411C
	bool IsNullOrEmpty(string value) { }

	// RVA: 0xD6CF5C
	string FormatWith(string format, IFormatProvider provider, object arg0) { }

	// RVA: 0xD6E3D8
	string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	// RVA: 0xD85408
	string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	// RVA: 0xD85540
	string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	// RVA: 0xD85364
	string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0xD7D740
	StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0xD7D3F4
	void ToCharAsUnicode(Char c, Char[] buffer) { }

	// RVA: 0x309AF8C
	TSource ForgivingCaseSensitiveFind(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.String> valueSelector, string testValue) { }

	// RVA: 0xD856B0
	string ToCamelCase(string s) { }

	// RVA: 0xD85B7C
	Char ToLower(Char c) { }

	// RVA: 0xD85C44
	string ToSnakeCase(string s) { }

	// RVA: 0xD85F6C
	string ToKebabCase(string s) { }

	// RVA: 0xD85C4C
	string ToSeparatedCase(string s, Char separator) { }

	// RVA: 0xD85F74
	bool IsHighSurrogate(Char c) { }

	// RVA: 0xD85FFC
	bool IsLowSurrogate(Char c) { }

	// RVA: 0xD7EBA8
	int IndexOf(string s, Char c) { }

	// RVA: 0xD86084
	bool StartsWith(string source, Char value) { }

	// RVA: 0xD860D8
	bool EndsWith(string source, Char value) { }

	// RVA: 0xD83888
	string Trim(string s, int start, int length) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StructMultiKey<T0, T1> 
{
	// Fields
	public readonly T1 Value1; // 0x0
	public readonly T2 Value2; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void .ctor(T1 v1, T2 v2) { }

	// RVA: 0x2FE32D4
	int GetHashCode() { }

	// RVA: 0x2FE3174
	bool Equals(object obj) { }

	// RVA: 0x309AF8C
	bool Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1,T2> other) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ThreadSafeStore<T0, T1> 
{
	// Fields
	private readonly System.Collections.Concurrent.ConcurrentDictionary<TKey,TValue> _concurrentStore; // 0x0
	private readonly System.Func<TKey,TValue> _creator; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Func<TKey,TValue> creator) { }

	// RVA: 0x309AF8C
	TValue Get(TKey key) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class TypeExtensions 
{
	// Methods

	// RVA: 0xD7FA14
	MemberTypes MemberType(MemberInfo memberInfo) { }

	// RVA: 0xD86128
	bool ContainsGenericParameters(Type type) { }

	// RVA: 0xD6EA18
	bool IsInterface(Type type) { }

	// RVA: 0xD7AC38
	bool IsGenericType(Type type) { }

	// RVA: 0xD6EA30
	bool IsGenericTypeDefinition(Type type) { }

	// RVA: 0xD8132C
	Type BaseType(Type type) { }

	// RVA: 0xD7AC64
	Assembly Assembly(Type type) { }

	// RVA: 0xD6C4C8
	bool IsEnum(Type type) { }

	// RVA: 0xD811C8
	bool IsClass(Type type) { }

	// RVA: 0xD8614C
	bool IsSealed(Type type) { }

	// RVA: 0xD6EA54
	bool IsAbstract(Type type) { }

	// RVA: 0xD86164
	bool IsVisible(Type type) { }

	// RVA: 0xD80944
	bool IsValueType(Type type) { }

	// RVA: 0xD8617C
	bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match) { }

	// RVA: 0xD86330
	bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	// RVA: 0xD86354
	bool ImplementInterface(Type type, Type interfaceType) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ValidationUtils 
{
	// Methods

	// RVA: 0xD69A10
	void ArgumentNotNull(object value, string parameterName) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal static class CachedAttributeGetter<T0> 
{
	// Fields
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Object,T> TypeAttributeCache; // 0x0

	// Methods

	// RVA: 0x309AF8C
	T GetAttribute(object type) { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class CamelCaseNamingStrategy 
{
	// Methods

	// RVA: 0xD86740
	void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xD8677C
	void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xD796B0
	void .ctor() { }

	// RVA: 0xD867C0
	string ResolvePropertyName(string name) { }

}

// Namespace: 
private sealed class <GetEnumerator>d__2 
{
	// Fields
	private int <>1__state; // 0x0
	private System.Collections.Generic.KeyValuePair<System.Object,System.Object> <>2__current; // 0x0
	public Newtonsoft.Json.Serialization.DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey,TEnumeratorValue> <>4__this; // 0x0
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> <>7__wrap1; // 0x0

	// Methods

	// RVA: 0x2FE42A4
	void .ctor(int <>1__state) { }

	// RVA: 0x2FE41A8
	void System.IDisposable.Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void <>m__Finally1() { }

	// RVA: -1
	System.Collections.Generic.KeyValuePair<System.Object,System.Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
internal class EnumerableDictionaryWrapper<T0, T1> 
{
	// Fields
	private readonly System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> _e; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Newtonsoft.Json.Serialization.DefaultContractResolver.<>c <>9; // 0x0
	public static System.Func<System.Reflection.MemberInfo,System.Boolean> <>9__40_0; // 0x8
	public static System.Func<System.Reflection.MemberInfo,System.Boolean> <>9__40_1; // 0x10
	public static System.Func<System.Type,System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>> <>9__44_0; // 0x18
	public static System.Func<System.Reflection.MemberInfo,System.Boolean> <>9__44_1; // 0x20
	public static System.Func<System.Reflection.ConstructorInfo,System.Boolean> <>9__47_0; // 0x28
	public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,System.Int32> <>9__75_0; // 0x30

	// Methods

	// RVA: 0xD8EAC0
	void .cctor() { }

	// RVA: 0xD8EB2C
	void .ctor() { }

	// RVA: 0xD8EB34
	bool <GetSerializableMembers>b__40_0(MemberInfo m) { }

	// RVA: 0xD8EBEC
	bool <GetSerializableMembers>b__40_1(MemberInfo m) { }

	// RVA: 0xD8EC5C
	System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(Type baseType) { }

	// RVA: 0xD8ED40
	bool <GetExtensionDataMemberForType>b__44_1(MemberInfo m) { }

	// RVA: 0xD8F134
	bool <GetAttributeConstructor>b__47_0(ConstructorInfo c) { }

	// RVA: 0xD8F1F0
	int <CreateProperties>b__75_0(JsonProperty p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass42_0 
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xD8F324
	void .ctor() { }

	// RVA: 0xD8F32C
	string <CreateObjectContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_0 
{
	// Fields
	public System.Func<System.Object,System.Object> getExtensionDataDictionary; // 0x10
	public MemberInfo member; // 0x18

	// Methods

	// RVA: 0xD8F350
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_1 
{
	// Fields
	public System.Action<System.Object,System.Object> setExtensionDataDictionary; // 0x10
	public System.Func<System.Object> createExtensionDataDictionary; // 0x18
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> setExtensionDataDictionaryValue; // 0x20
	public Newtonsoft.Json.Serialization.DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals1; // 0x28

	// Methods

	// RVA: 0xD8F358
	void .ctor() { }

	// RVA: 0xD8F360
	void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_2 
{
	// Fields
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> createEnumerableWrapper; // 0x10
	public Newtonsoft.Json.Serialization.DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xD8F590
	void .ctor() { }

	// RVA: 0xD8F598
	System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> <SetExtensionDataDelegates>b__1(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass62_0 
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xD8F6E0
	void .ctor() { }

	// RVA: 0xD8F6E8
	string <CreateDictionaryContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass67_0 
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xD8F70C
	void .ctor() { }

	// RVA: 0xD8F714
	string <CreateDynamicContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass80_0 
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> shouldSerializeCall; // 0x10

	// Methods

	// RVA: 0xD8F738
	void .ctor() { }

	// RVA: 0xD8F740
	bool <CreateShouldSerializeTest>b__0(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass81_0 
{
	// Fields
	public System.Func<System.Object,System.Object> specifiedPropertyGet; // 0x10

	// Methods

	// RVA: 0xD8F898
	void .ctor() { }

	// RVA: 0xD8F8A0
	bool <SetIsSpecifiedActions>b__0(object o) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultContractResolver 
{
	// Fields
	private static readonly IContractResolver _instance; // 0x0
	private static readonly string[] BlacklistedTypeNames; // 0x8
	private static readonly JsonConverter[] BuiltInConverters; // 0x10
	private readonly DefaultJsonNameTable _nameTable; // 0x10
	private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Serialization.JsonContract> _contractCache; // 0x18
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField; // 0x20
	private bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x24
	private bool <IgnoreSerializableInterface>k__BackingField; // 0x25
	private bool <IgnoreSerializableAttribute>k__BackingField; // 0x26
	private bool <IgnoreIsSpecifiedMembers>k__BackingField; // 0x27
	private bool <IgnoreShouldSerializeMembers>k__BackingField; // 0x28
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x30

	// Methods

	// RVA: 0xD867C8
	IContractResolver get_Instance() { }

	// RVA: 0xD86844
	BindingFlags get_DefaultMembersSearchFlags() { }

	// RVA: 0xD8684C
	void set_DefaultMembersSearchFlags(BindingFlags value) { }

	// RVA: 0xD86854
	bool get_SerializeCompilerGeneratedMembers() { }

	// RVA: 0xD8685C
	bool get_IgnoreSerializableInterface() { }

	// RVA: 0xD86864
	bool get_IgnoreSerializableAttribute() { }

	// RVA: 0xD8686C
	void set_IgnoreSerializableAttribute(bool value) { }

	// RVA: 0xD86874
	bool get_IgnoreIsSpecifiedMembers() { }

	// RVA: 0xD8687C
	bool get_IgnoreShouldSerializeMembers() { }

	// RVA: 0xD86884
	NamingStrategy get_NamingStrategy() { }

	// RVA: 0xD8688C
	void .ctor() { }

	// RVA: 0xD869A0
	JsonContract ResolveContract(Type type) { }

	// RVA: 0xD86A6C
	bool FilterMembers(MemberInfo member) { }

	// RVA: 0xD86BE8
	System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0xD877C4
	bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0xD878D8
	JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0xD89768
	void ThrowUnableToSerializeError(object o, StreamingContext context) { }

	// RVA: 0xD88B8C
	MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0xD88DB0
	void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0xD88234
	ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0xD887F4
	ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	// RVA: 0xD887A4
	ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0xD89AA0
	System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0xD899E8
	JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	// RVA: 0xD89C9C
	JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0xD8A8D8
	JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0xD8A960
	System.Func<System.Object> GetDefaultCreator(Type createdType) { }

	// RVA: 0xD87F48
	void InitializeContract(JsonContract contract) { }

	// RVA: 0xD8AA24
	void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0xD8AB70
	void GetCallbackMethodsForType(Type type, out System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerializing, out System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerialized, out System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserializing, out System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserialized, out System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback>& onError) { }

	// RVA: 0xD8BC98
	bool IsConcurrentOrObservableCollection(Type t) { }

	// RVA: 0xD8B534
	bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0xD8B434
	bool ShouldSkipSerializing(Type t) { }

	// RVA: 0xD89800
	System.Collections.Generic.List<System.Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0xD8BE2C
	JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0xD8C3FC
	JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0xD8C764
	JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0xD8C7DC
	JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0xD8C854
	JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0xD8CACC
	JsonDynamicContract CreateDynamicContract(Type objectType) { }

	// RVA: 0xD8CD08
	JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0xD8CD80
	JsonContract CreateContract(Type objectType) { }

	// RVA: 0xD8D324
	bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0xD8D560
	bool IsIConvertible(Type t) { }

	// RVA: 0xD8D3F4
	bool CanConvertToString(Type type) { }

	// RVA: 0xD8B634
	bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	// RVA: 0xD8D714
	string GetClrTypeFullName(Type type) { }

	// RVA: 0xD8D820
	System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0xD8DCF0
	DefaultJsonNameTable GetNameTable() { }

	// RVA: 0xD8DCF8
	IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0xD8DD60
	JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0xD8A12C
	void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	// RVA: 0xD8DF88
	System.Predicate<System.Object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0xD8E1EC
	void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0xD8E524
	string ResolvePropertyName(string propertyName) { }

	// RVA: 0xD8E544
	string ResolveExtensionDataName(string extensionDataName) { }

	// RVA: 0xD8E560
	string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0xD8E58C
	string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0xD8E59C
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultNamingStrategy 
{
	// Methods

	// RVA: 0xD8F948
	string ResolvePropertyName(string name) { }

	// RVA: 0xD8F950
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class DefaultReferenceResolver 
{
	// Fields
	private int _referenceCount; // 0x10

	// Methods

	// RVA: 0xD8F958
	Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> GetMappings(object context) { }

	// RVA: 0xD8FB90
	object ResolveReference(object context, string reference) { }

	// RVA: 0xD8FC10
	string GetReference(object context, object value) { }

	// RVA: 0xD8FD10
	void AddReference(object context, string reference, object value) { }

	// RVA: 0xD8FD80
	bool IsReferenced(object context, object value) { }

	// RVA: 0xD8FDFC
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultSerializationBinder 
{
	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String>,System.Type> _typeCache; // 0x10

	// Methods

	// RVA: 0xD8FE04
	void .ctor() { }

	// RVA: 0xD8FEE0
	Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }

	// RVA: 0xD90308
	Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	// RVA: 0xD905AC
	Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }

	// RVA: 0xD9062C
	Type BindToType(string assemblyName, string typeName) { }

	// RVA: 0xD90700
	void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: 0xD90788
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class ErrorContext 
{
	// Fields
	private bool <Traced>k__BackingField; // 0x10
	private readonly Exception <Error>k__BackingField; // 0x18
	private readonly object <OriginalObject>k__BackingField; // 0x20
	private readonly object <Member>k__BackingField; // 0x28
	private readonly string <Path>k__BackingField; // 0x30
	private bool <Handled>k__BackingField; // 0x38

	// Methods

	// RVA: 0xD907F0
	void .ctor(object originalObject, object member, string path, Exception error) { }

	// RVA: 0xD90870
	bool get_Traced() { }

	// RVA: 0xD90878
	void set_Traced(bool value) { }

	// RVA: 0xD90880
	Exception get_Error() { }

	// RVA: 0xD90888
	bool get_Handled() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class ErrorEventArgs 
{
	// Fields
	private readonly object <CurrentObject>k__BackingField; // 0x10
	private readonly ErrorContext <ErrorContext>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD90890
	void .ctor(object currentObject, ErrorContext errorContext) { }

}

// Namespace: Newtonsoft.Json.Serialization
public interface IAttributeProvider 
{}

// Namespace: Newtonsoft.Json.Serialization
public interface IContractResolver 
{
	// Methods

	// RVA: 0x2FE36BC
	JsonContract ResolveContract(Type type) { }

}

// Namespace: Newtonsoft.Json.Serialization
public interface IReferenceResolver 
{
	// Methods

	// RVA: 0x2FE37A0
	object ResolveReference(object context, string reference) { }

	// RVA: 0x2FE37A0
	string GetReference(object context, object value) { }

	// RVA: -1
	bool IsReferenced(object context, object value) { }

	// RVA: 0x2FE49A8
	void AddReference(object context, string reference, object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public interface ISerializationBinder 
{
	// Methods

	// RVA: 0x2FE37A0
	Type BindToType(string assemblyName, string typeName) { }

	// RVA: 0x2FE49A8
	void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

}

// Namespace: Newtonsoft.Json.Serialization
public interface ITraceWriter 
{
	// Methods

	// RVA: 0x2FE32D4
	TraceLevel get_LevelFilter() { }

	// RVA: -1
	void Trace(TraceLevel level, string message, Exception ex) { }

}

// Namespace: Newtonsoft.Json.Serialization
public interface IValueProvider 
{
	// Methods

	// RVA: 0x2FE47D4
	void SetValue(object target, object value) { }

	// RVA: 0x2FE36BC
	object GetValue(object target) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonArrayContract 
{
	// Fields
	private readonly Type <CollectionItemType>k__BackingField; // 0xC0
	private readonly bool <IsMultidimensionalArray>k__BackingField; // 0xC8
	private readonly Type _genericCollectionDefinitionType; // 0xD0
	private Type _genericWrapperType; // 0xD8
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _genericWrapperCreator; // 0xE0
	private System.Func<System.Object> _genericTemporaryCollectionCreator; // 0xE8
	private readonly bool <IsArray>k__BackingField; // 0xF0
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0xF1
	private bool <CanDeserialize>k__BackingField; // 0xF2
	private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _parameterizedCreator; // 0x100
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _overrideCreator; // 0x108
	private bool <HasParameterizedCreator>k__BackingField; // 0x110

	// Methods

	// RVA: 0xD90924
	Type get_CollectionItemType() { }

	// RVA: 0xD9092C
	bool get_IsMultidimensionalArray() { }

	// RVA: 0xD90934
	bool get_IsArray() { }

	// RVA: 0xD9093C
	bool get_ShouldCreateWrapper() { }

	// RVA: 0xD90944
	bool get_CanDeserialize() { }

	// RVA: 0xD9094C
	void set_CanDeserialize(bool value) { }

	// RVA: 0xD90954
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xD90A58
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xD90A60
	void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xD90A90
	bool get_HasParameterizedCreator() { }

	// RVA: 0xD90A98
	void set_HasParameterizedCreator(bool value) { }

	// RVA: 0xD90AA0
	bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0xD90B3C
	void .ctor(Type underlyingType) { }

	// RVA: 0xD91ED0
	IWrappedCollection CreateWrapper(object list) { }

	// RVA: 0xD92308
	IList CreateTemporaryCollection() { }

	// RVA: 0xD91CEC
	void StoreFSharpListCreatorIfNecessary(Type underlyingType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonContainerContract 
{
	// Fields
	private JsonContract _itemContract; // 0x90
	private JsonContract _finalItemContract; // 0x98
	private JsonConverter <ItemConverter>k__BackingField; // 0xA0
	private System.Nullable<System.Boolean> <ItemIsReference>k__BackingField; // 0xA8
	private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xAC
	private System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xB4

	// Methods

	// RVA: 0xD925B4
	JsonContract get_ItemContract() { }

	// RVA: 0xD925BC
	void set_ItemContract(JsonContract value) { }

	// RVA: 0xD92628
	JsonContract get_FinalItemContract() { }

	// RVA: 0xD92630
	JsonConverter get_ItemConverter() { }

	// RVA: 0xD92638
	void set_ItemConverter(JsonConverter value) { }

	// RVA: 0xD92640
	System.Nullable<System.Boolean> get_ItemIsReference() { }

	// RVA: 0xD92648
	void set_ItemIsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xD92650
	System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	// RVA: 0xD92658
	void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xD92660
	System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }

	// RVA: 0xD92668
	void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xD91AF0
	void .ctor(Type underlyingType) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal enum JsonContractType 
{
	// Fields
	public int value__; // 0x10
	public const JsonContractType None = 0;
	public const JsonContractType Object = 1;
	public const JsonContractType Array = 2;
	public const JsonContractType Primitive = 3;
	public const JsonContractType String = 4;
	public const JsonContractType Dictionary = 5;
	public const JsonContractType Dynamic = 6;
	public const JsonContractType Serializable = 7;
	public const JsonContractType Linq = 8;
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationCallback 
{
	// Methods

	// RVA: 0xD927FC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xD92920
	internal void Invoke(object o, StreamingContext context) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationErrorCallback 
{
	// Methods

	// RVA: 0xD92934
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xD92A58
	internal void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataSetter 
{
	// Methods

	// RVA: 0xD92A6C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xD92B90
	internal void Invoke(object o, string key, object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataGetter 
{
	// Methods

	// RVA: 0xD92BA4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xD92CC4
	internal System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> Invoke(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass57_0 
{
	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0xD93ACC
	void .ctor() { }

	// RVA: 0xD93B98
	void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

}

// Namespace: 
private sealed class <>c__DisplayClass58_0 
{
	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0xD93B90
	void .ctor() { }

	// RVA: 0xD93CA4
	void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext) { }

}

// Namespace: Newtonsoft.Json.Serialization
public abstract class JsonContract 
{
	// Fields
	internal bool IsNullable; // 0x10
	internal bool IsConvertable; // 0x11
	internal bool IsEnum; // 0x12
	internal Type NonNullableUnderlyingType; // 0x18
	internal ReadType InternalReadType; // 0x20
	internal JsonContractType ContractType; // 0x24
	internal bool IsReadOnlyOrFixedSize; // 0x28
	internal bool IsSealed; // 0x29
	internal bool IsInstantiable; // 0x2A
	private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializedCallbacks; // 0x30
	private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializingCallbacks; // 0x38
	private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onSerializedCallbacks; // 0x40
	private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback> _onSerializingCallbacks; // 0x48
	private System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback> _onErrorCallbacks; // 0x50
	private Type _createdType; // 0x58
	private readonly Type <UnderlyingType>k__BackingField; // 0x60
	private System.Nullable<System.Boolean> <IsReference>k__BackingField; // 0x68
	private JsonConverter <Converter>k__BackingField; // 0x70
	private JsonConverter <InternalConverter>k__BackingField; // 0x78
	private System.Func<System.Object> <DefaultCreator>k__BackingField; // 0x80
	private bool <DefaultCreatorNonPublic>k__BackingField; // 0x88

	// Methods

	// RVA: 0xD92CD8
	Type get_UnderlyingType() { }

	// RVA: 0xD92CE0
	Type get_CreatedType() { }

	// RVA: 0xD91C2C
	void set_CreatedType(Type value) { }

	// RVA: 0xD92CE8
	System.Nullable<System.Boolean> get_IsReference() { }

	// RVA: 0xD92CF0
	void set_IsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xD92CF8
	JsonConverter get_Converter() { }

	// RVA: 0xD92D00
	void set_Converter(JsonConverter value) { }

	// RVA: 0xD92D08
	JsonConverter get_InternalConverter() { }

	// RVA: 0xD92D10
	void set_InternalConverter(JsonConverter value) { }

	// RVA: 0xD92D18
	System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0xD92DB4
	System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0xD92E50
	System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0xD92EEC
	System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0xD92F88
	System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks() { }

	// RVA: 0xD93024
	System.Func<System.Object> get_DefaultCreator() { }

	// RVA: 0xD9302C
	void set_DefaultCreator(System.Func<System.Object> value) { }

	// RVA: 0xD93034
	bool get_DefaultCreatorNonPublic() { }

	// RVA: 0xD9303C
	void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0xD92670
	void .ctor(Type underlyingType) { }

	// RVA: 0xD93044
	void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0xD93238
	void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0xD9342C
	void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0xD93620
	void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0xD93814
	void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0xD93A10
	SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0xD93AD4
	SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonDictionaryContract 
{
	// Fields
	private System.Func<System.String,System.String> <DictionaryKeyResolver>k__BackingField; // 0xC0
	private readonly Type <DictionaryKeyType>k__BackingField; // 0xC8
	private readonly Type <DictionaryValueType>k__BackingField; // 0xD0
	private JsonContract <KeyContract>k__BackingField; // 0xD8
	private readonly Type _genericCollectionDefinitionType; // 0xE0
	private Type _genericWrapperType; // 0xE8
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _genericWrapperCreator; // 0xF0
	private System.Func<System.Object> _genericTemporaryDictionaryCreator; // 0xF8
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0x100
	private readonly ConstructorInfo _parameterizedConstructor; // 0x108
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _overrideCreator; // 0x110
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _parameterizedCreator; // 0x118
	private bool <HasParameterizedCreator>k__BackingField; // 0x120

	// Methods

	// RVA: 0xD93DE8
	System.Func<System.String,System.String> get_DictionaryKeyResolver() { }

	// RVA: 0xD93DF0
	void set_DictionaryKeyResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xD93DF8
	Type get_DictionaryKeyType() { }

	// RVA: 0xD93E00
	Type get_DictionaryValueType() { }

	// RVA: 0xD93E08
	JsonContract get_KeyContract() { }

	// RVA: 0xD93E10
	void set_KeyContract(JsonContract value) { }

	// RVA: 0xD93E18
	bool get_ShouldCreateWrapper() { }

	// RVA: 0xD93E20
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xD93F24
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xD93F2C
	void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xD93F3C
	bool get_HasParameterizedCreator() { }

	// RVA: 0xD93F44
	void set_HasParameterizedCreator(bool value) { }

	// RVA: 0xD93F4C
	bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0xD93FE8
	void .ctor(Type underlyingType) { }

	// RVA: 0xD94B84
	IWrappedDictionary CreateWrapper(object dictionary) { }

	// RVA: 0xD94E5C
	IDictionary CreateTemporaryDictionary() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonDynamicContract 
{
	// Fields
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xC0
	private System.Func<System.String,System.String> <PropertyNameResolver>k__BackingField; // 0xC8
	private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.String,System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>>> _callSiteGetters; // 0xD0
	private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.String,System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>>> _callSiteSetters; // 0xD8

	// Methods

	// RVA: 0xD95140
	JsonPropertyCollection get_Properties() { }

	// RVA: 0xD95148
	System.Func<System.String,System.String> get_PropertyNameResolver() { }

	// RVA: 0xD95150
	void set_PropertyNameResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xD95158
	System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>> CreateCallSiteGetter(string name) { }

	// RVA: 0xD95284
	System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>> CreateCallSiteSetter(string name) { }

	// RVA: 0xD953B0
	void .ctor(Type underlyingType) { }

	// RVA: 0xD95734
	bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object value) { }

	// RVA: 0xD95854
	bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class JsonFormatterConverter 
{
	// Fields
	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	private readonly JsonProperty _member; // 0x20

	// Methods

	// RVA: 0xD95964
	void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x309AF8C
	T GetTokenValue(object value) { }

	// RVA: 0xD95A38
	object Convert(object value, Type type) { }

	// RVA: 0xD95D3C
	bool ToBoolean(object value) { }

	// RVA: 0xD95DAC
	int ToInt32(object value) { }

	// RVA: 0xD95E1C
	Int64 ToInt64(object value) { }

	// RVA: 0xD95E8C
	float ToSingle(object value) { }

	// RVA: 0xD95EFC
	string ToString(object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonISerializableContract 
{
	// Fields
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <ISerializableCreator>k__BackingField; // 0xC0

	// Methods

	// RVA: 0xD95F6C
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ISerializableCreator() { }

	// RVA: 0xD95F74
	void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xD95F7C
	void .ctor(Type underlyingType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonLinqContract 
{
	// Methods

	// RVA: 0xD95FA4
	void .ctor(Type underlyingType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonObjectContract 
{
	// Fields
	private MemberSerialization <MemberSerialization>k__BackingField; // 0xBC
	private System.Nullable<Newtonsoft.Json.MissingMemberHandling> <MissingMemberHandling>k__BackingField; // 0xC0
	private System.Nullable<Newtonsoft.Json.Required> <ItemRequired>k__BackingField; // 0xC8
	private System.Nullable<Newtonsoft.Json.NullValueHandling> <ItemNullValueHandling>k__BackingField; // 0xD0
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xD8
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; // 0xE0
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; // 0xE8
	private System.Func<System.String,System.String> <ExtensionDataNameResolver>k__BackingField; // 0xF0
	internal bool ExtensionDataIsJToken; // 0xF8
	private System.Nullable<System.Boolean> _hasRequiredOrDefaultValueProperties; // 0xF9
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _overrideCreator; // 0x100
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> _parameterizedCreator; // 0x108
	private JsonPropertyCollection _creatorParameters; // 0x110
	private Type _extensionDataValueType; // 0x118

	// Methods

	// RVA: 0xD95FCC
	MemberSerialization get_MemberSerialization() { }

	// RVA: 0xD95FD4
	void set_MemberSerialization(MemberSerialization value) { }

	// RVA: 0xD95FDC
	System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling() { }

	// RVA: 0xD95FE4
	void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value) { }

	// RVA: 0xD95FEC
	System.Nullable<Newtonsoft.Json.Required> get_ItemRequired() { }

	// RVA: 0xD95FF4
	void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value) { }

	// RVA: 0xD95FFC
	System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling() { }

	// RVA: 0xD96004
	void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }

	// RVA: 0xD9600C
	JsonPropertyCollection get_Properties() { }

	// RVA: 0xD96014
	JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0xD960B0
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xD960B8
	void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xD960C8
	Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xD960D0
	void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xD960E0
	ExtensionDataSetter get_ExtensionDataSetter() { }

	// RVA: 0xD960E8
	void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	// RVA: 0xD960F0
	ExtensionDataGetter get_ExtensionDataGetter() { }

	// RVA: 0xD960F8
	void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0xD96100
	void set_ExtensionDataValueType(Type value) { }

	// RVA: 0xD96200
	System.Func<System.String,System.String> get_ExtensionDataNameResolver() { }

	// RVA: 0xD96208
	void set_ExtensionDataNameResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xD96210
	bool get_HasRequiredOrDefaultValueProperties() { }

	// RVA: 0xD969D8
	void .ctor(Type underlyingType) { }

	// RVA: 0xD96A60
	object GetUninitializedObject() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonPrimitiveContract 
{
	// Fields
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x8C
	private static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.ReadType> ReadTypeMap; // 0x0

	// Methods

	// RVA: 0xD96BA0
	PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0xD96BA8
	void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0xD96BB0
	void .ctor(Type underlyingType) { }

	// RVA: 0xD96CB0
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonProperty 
{
	// Fields
	internal System.Nullable<Newtonsoft.Json.Required> _required; // 0x10
	internal bool _hasExplicitDefaultValue; // 0x18
	private object _defaultValue; // 0x20
	private bool _hasGeneratedDefaultValue; // 0x28
	private string _propertyName; // 0x30
	internal bool _skipPropertyNameEscape; // 0x38
	private Type _propertyType; // 0x40
	private JsonContract <PropertyContract>k__BackingField; // 0x48
	private Type <DeclaringType>k__BackingField; // 0x50
	private System.Nullable<System.Int32> <Order>k__BackingField; // 0x58
	private string <UnderlyingName>k__BackingField; // 0x60
	private IValueProvider <ValueProvider>k__BackingField; // 0x68
	private IAttributeProvider <AttributeProvider>k__BackingField; // 0x70
	private JsonConverter <Converter>k__BackingField; // 0x78
	private bool <Ignored>k__BackingField; // 0x80
	private bool <Readable>k__BackingField; // 0x81
	private bool <Writable>k__BackingField; // 0x82
	private bool <HasMemberAttribute>k__BackingField; // 0x83
	private System.Nullable<System.Boolean> <IsReference>k__BackingField; // 0x84
	private System.Nullable<Newtonsoft.Json.NullValueHandling> <NullValueHandling>k__BackingField; // 0x88
	private System.Nullable<Newtonsoft.Json.DefaultValueHandling> <DefaultValueHandling>k__BackingField; // 0x90
	private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; // 0x98
	private System.Nullable<Newtonsoft.Json.ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; // 0xA0
	private System.Nullable<Newtonsoft.Json.TypeNameHandling> <TypeNameHandling>k__BackingField; // 0xA8
	private System.Predicate<System.Object> <ShouldSerialize>k__BackingField; // 0xB0
	private System.Predicate<System.Object> <ShouldDeserialize>k__BackingField; // 0xB8
	private System.Predicate<System.Object> <GetIsSpecified>k__BackingField; // 0xC0
	private System.Action<System.Object,System.Object> <SetIsSpecified>k__BackingField; // 0xC8
	private JsonConverter <ItemConverter>k__BackingField; // 0xD0
	private System.Nullable<System.Boolean> <ItemIsReference>k__BackingField; // 0xD8
	private System.Nullable<Newtonsoft.Json.TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xDC
	private System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xE4

	// Methods

	// RVA: 0xD97078
	JsonContract get_PropertyContract() { }

	// RVA: 0xD97080
	void set_PropertyContract(JsonContract value) { }

	// RVA: 0xD97088
	string get_PropertyName() { }

	// RVA: 0xD97090
	void set_PropertyName(string value) { }

	// RVA: 0xD97128
	Type get_DeclaringType() { }

	// RVA: 0xD97130
	void set_DeclaringType(Type value) { }

	// RVA: 0xD97138
	System.Nullable<System.Int32> get_Order() { }

	// RVA: 0xD97140
	void set_Order(System.Nullable<System.Int32> value) { }

	// RVA: 0xD97148
	string get_UnderlyingName() { }

	// RVA: 0xD97150
	void set_UnderlyingName(string value) { }

	// RVA: 0xD97158
	IValueProvider get_ValueProvider() { }

	// RVA: 0xD97160
	void set_ValueProvider(IValueProvider value) { }

	// RVA: 0xD97168
	void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0xD97170
	Type get_PropertyType() { }

	// RVA: 0xD97178
	void set_PropertyType(Type value) { }

	// RVA: 0xD9724C
	JsonConverter get_Converter() { }

	// RVA: 0xD97254
	void set_Converter(JsonConverter value) { }

	// RVA: 0xD9725C
	bool get_Ignored() { }

	// RVA: 0xD97264
	void set_Ignored(bool value) { }

	// RVA: 0xD9726C
	bool get_Readable() { }

	// RVA: 0xD97274
	void set_Readable(bool value) { }

	// RVA: 0xD9727C
	bool get_Writable() { }

	// RVA: 0xD97284
	void set_Writable(bool value) { }

	// RVA: 0xD9728C
	bool get_HasMemberAttribute() { }

	// RVA: 0xD97294
	void set_HasMemberAttribute(bool value) { }

	// RVA: 0xD9729C
	object get_DefaultValue() { }

	// RVA: 0xD972B4
	void set_DefaultValue(object value) { }

	// RVA: 0xD972C4
	object GetResolvedDefaultValue() { }

	// RVA: 0xD96900
	Required get_Required() { }

	// RVA: 0xD973A4
	System.Nullable<System.Boolean> get_IsReference() { }

	// RVA: 0xD973AC
	void set_IsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xD973B4
	System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling() { }

	// RVA: 0xD973BC
	void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }

	// RVA: 0xD973C4
	System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling() { }

	// RVA: 0xD973CC
	void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value) { }

	// RVA: 0xD973D4
	System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	// RVA: 0xD973DC
	void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xD973E4
	System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling() { }

	// RVA: 0xD973EC
	void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value) { }

	// RVA: 0xD973F4
	System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling() { }

	// RVA: 0xD973FC
	void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xD97404
	System.Predicate<System.Object> get_ShouldSerialize() { }

	// RVA: 0xD9740C
	void set_ShouldSerialize(System.Predicate<System.Object> value) { }

	// RVA: 0xD97414
	System.Predicate<System.Object> get_ShouldDeserialize() { }

	// RVA: 0xD9741C
	System.Predicate<System.Object> get_GetIsSpecified() { }

	// RVA: 0xD97424
	void set_GetIsSpecified(System.Predicate<System.Object> value) { }

	// RVA: 0xD9742C
	System.Action<System.Object,System.Object> get_SetIsSpecified() { }

	// RVA: 0xD97434
	void set_SetIsSpecified(System.Action<System.Object,System.Object> value) { }

	// RVA: 0xD9743C
	string ToString() { }

	// RVA: 0xD974A8
	JsonConverter get_ItemConverter() { }

	// RVA: 0xD974B0
	void set_ItemConverter(JsonConverter value) { }

	// RVA: 0xD974B8
	System.Nullable<System.Boolean> get_ItemIsReference() { }

	// RVA: 0xD974C0
	void set_ItemIsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xD974C8
	System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }

	// RVA: 0xD974D0
	void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xD974D8
	System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	// RVA: 0xD974E0
	void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xD974E8
	void WritePropertyName(JsonWriter writer) { }

	// RVA: 0xD97540
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonPropertyCollection 
{
	// Fields
	private readonly Type _type; // 0x30
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list; // 0x38

	// Methods

	// RVA: 0xD95578
	void .ctor(Type type) { }

	// RVA: 0xD97548
	string GetKeyForItem(JsonProperty item) { }

	// RVA: 0xD97564
	void AddProperty(JsonProperty property) { }

	// RVA: 0xD97844
	JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0xD979E0
	bool TryGetProperty(string key, out JsonProperty item) { }

	// RVA: 0xD978E4
	JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

}

// Namespace: 
private class ReferenceEqualsEqualityComparer 
{
	// Methods

	// RVA: 0xD98398
	bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	// RVA: 0xD983A4
	int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	// RVA: 0xD97B6C
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
internal abstract class JsonSerializerInternalBase 
{
	// Fields
	private ErrorContext _currentErrorContext; // 0x10
	private Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> _mappings; // 0x18
	internal readonly JsonSerializer Serializer; // 0x20
	internal readonly ITraceWriter TraceWriter; // 0x28
	protected JsonSerializerProxy InternalSerializer; // 0x30

	// Methods

	// RVA: 0xD97ACC
	void .ctor(JsonSerializer serializer) { }

	// RVA: 0xD8FA68
	Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> get_DefaultReferenceMappings() { }

	// RVA: 0xD97B74
	NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0xD97DB8
	ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0xD97EE8
	void ClearErrorContext() { }

	// RVA: 0xD97F58
	bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

}

// Namespace: 
internal enum PropertyPresence 
{
	// Fields
	public int value__; // 0x10
	public const PropertyPresence None = 0;
	public const PropertyPresence Null = 1;
	public const PropertyPresence Value = 2;
}

// Namespace: 
internal class CreatorPropertyContext 
{
	// Fields
	public readonly string Name; // 0x10
	public JsonProperty Property; // 0x18
	public JsonProperty ConstructorProperty; // 0x20
	public System.Nullable<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> Presence; // 0x28
	public object Value; // 0x30
	public bool Used; // 0x38

	// Methods

	// RVA: 0xDA5ED8
	void .ctor(string name) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader.<>c <>9; // 0x0
	public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,System.String> <>9__38_0; // 0x8
	public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,System.String> <>9__38_2; // 0x10
	public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonProperty> <>9__42_0; // 0x18
	public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> <>9__42_1; // 0x20

	// Methods

	// RVA: 0xDA6B54
	void .cctor() { }

	// RVA: 0xDA6BC0
	void .ctor() { }

	// RVA: 0xDA6BC8
	string <CreateObjectUsingCreatorWithParameters>b__38_0(JsonProperty p) { }

	// RVA: 0xDA6BE4
	string <CreateObjectUsingCreatorWithParameters>b__38_2(JsonProperty p) { }

	// RVA: 0xDA6C00
	JsonProperty <PopulateObject>b__42_0(JsonProperty m) { }

	// RVA: 0xDA6C08
	PropertyPresence <PopulateObject>b__42_1(JsonProperty m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass38_0 
{
	// Fields
	public JsonProperty property; // 0x10

	// Methods

	// RVA: 0xDA5ED0
	void .ctor() { }

	// RVA: 0xDA6C10
	bool <CreateObjectUsingCreatorWithParameters>b__1(CreatorPropertyContext p) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class JsonSerializerInternalReader 
{
	// Methods

	// RVA: 0xD983B0
	void .ctor(JsonSerializer serializer) { }

	// RVA: 0xD983B4
	void Populate(JsonReader reader, object target) { }

	// RVA: 0xD9AEF4
	JsonContract GetContractSafe(Type type) { }

	// RVA: 0xD9AFA4
	JsonContract GetContract(Type type) { }

	// RVA: 0xD9B060
	object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0xD9BEE8
	JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0xD9BF88
	JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0xD9C388
	JToken CreateJObject(JsonReader reader) { }

	// RVA: 0xD9B980
	object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0xD9E008
	bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0xD9E15C
	string GetExpectedDescription(JsonContract contract) { }

	// RVA: 0xD9B460
	JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xD9C810
	object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0xD9E218
	bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	// RVA: 0xD9E980
	bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	// RVA: 0xDA06B0
	void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0xDA0F50
	JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	// RVA: 0xD9D214
	object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	// RVA: 0xD9EF78
	bool HasNoDefinedType(JsonContract contract) { }

	// RVA: 0xD9D9F4
	object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0xDA1BEC
	bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	// RVA: 0xDA20EC
	bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue) { }

	// RVA: 0xDA28C8
	void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0xDA28BC
	bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xDA2784
	bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	// RVA: 0xDA10D4
	IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0xD9F35C
	IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0xDA2CA8
	void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0xDA2EE4
	void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0xD98FB0
	object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xDA141C
	object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xDA3120
	void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0xD98908
	object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xD9FF54
	object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0xD95B5C
	object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0xD9F648
	object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	// RVA: 0xDA32B8
	object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator, string id) { }

	// RVA: 0xD9B4F0
	object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0xDA5490
	System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0xD9F078
	object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	// RVA: 0xD99C88
	object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0xDA67C8
	bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0xD9C6E4
	bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0xDA65BC
	void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0xDA64F0
	object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0xDA5F0C
	void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0xDA6A3C
	void SetPropertyPresence(JsonReader reader, JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0xD9BE1C
	void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class JsonSerializerInternalWriter 
{
	// Fields
	private Type _rootType; // 0x38
	private int _rootLevel; // 0x40
	private readonly System.Collections.Generic.List<System.Object> _serializeStack; // 0x48

	// Methods

	// RVA: 0xDA6C38
	void .ctor(JsonSerializer serializer) { }

	// RVA: 0xDA6CD0
	void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xDA7C54
	JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0xDA6FA8
	JsonContract GetContractSafe(object value) { }

	// RVA: 0xDA7CF4
	JsonContract GetContract(object value) { }

	// RVA: 0xDA7DC4
	void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDA74C0
	void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDAB4F0
	System.Nullable<System.Boolean> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDA6FB8
	bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDAB63C
	bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0xDAB744
	bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDA7230
	void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0xDABBEC
	string GetReference(JsonWriter writer, object value) { }

	// RVA: 0xDABDE8
	bool TryConvertToString(object value, Type type, out string s) { }

	// RVA: 0xDA9EE0
	void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0xDABF34
	void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0xDAC150
	void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0xDA8BAC
	void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDAC55C
	bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	// RVA: 0xDAC36C
	void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDAD454
	bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	// RVA: 0xDAD58C
	void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0xDA83C0
	void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0xDAB738
	bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xDAB630
	bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0xDAD7E4
	bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0xDA864C
	void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDA9664
	void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDA9CF4
	void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDADBA0
	void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0xDAD7F0
	bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDAB098
	void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDAA838
	void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDADF38
	bool ShouldWriteDynamicProperty(object memberValue) { }

	// RVA: 0xDA7F3C
	bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDA9F70
	void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDACA14
	string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	// RVA: 0xDA7B84
	void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0xDACF74
	bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0xDAD1E4
	bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class JsonSerializerProxy 
{
	// Fields
	private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
	private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
	internal readonly JsonSerializer _serializer; // 0xF0

	// Methods

	// RVA: 0xDAE008
	void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDAE02C
	void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDAE050
	void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xDAE074
	ITraceWriter get_TraceWriter() { }

	// RVA: 0xDAE098
	void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0xDAE0BC
	void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xDAE0E0
	JsonConverterCollection get_Converters() { }

	// RVA: 0xDAE108
	void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0xDAE130
	IContractResolver get_ContractResolver() { }

	// RVA: 0xDAE158
	void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xDAE180
	void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xDAE1A8
	NullValueHandling get_NullValueHandling() { }

	// RVA: 0xDAE1D0
	void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xDAE1F8
	void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xDAE220
	void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xDAE248
	void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xDAE270
	void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xDAE294
	MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xDAE2BC
	void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xDAE2E4
	void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0xDAE308
	void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0xDAE330
	void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0xDAE354
	StreamingContext get_Context() { }

	// RVA: 0xDAE37C
	void set_Context(StreamingContext value) { }

	// RVA: 0xDAE3A4
	Formatting get_Formatting() { }

	// RVA: 0xDAE3CC
	System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xDAE3F4
	bool get_CheckAdditionalContent() { }

	// RVA: 0xDAE41C
	void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xDAE444
	JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0xDAE460
	void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0xDAE4F0
	void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	// RVA: 0xDAE580
	object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xDAE5BC
	void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0xDAE5F4
	void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonStringContract 
{
	// Methods

	// RVA: 0xDAE62C
	void .ctor(Type underlyingType) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Newtonsoft.Json.Serialization.JsonTypeReflector.<>c <>9; // 0x0
	public static System.Func<System.Object,System.Type> <>9__22_1; // 0x8

	// Methods

	// RVA: 0xDAFE68
	void .cctor() { }

	// RVA: 0xDAFED4
	void .ctor() { }

	// RVA: 0xDAFEDC
	Type <GetCreator>b__22_1(object param) { }

}

// Namespace: 
private sealed class <>c__DisplayClass22_0 
{
	// Fields
	public Type type; // 0x10
	public System.Func<System.Object> defaultConstructor; // 0x18

	// Methods

	// RVA: 0xDAF5FC
	void .ctor() { }

	// RVA: 0xDAFF40
	object <GetCreator>b__0(object[] parameters) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal static class JsonTypeReflector 
{
	// Fields
	private static System.Nullable<System.Boolean> _fullyTrusted; // 0x0
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Func<System.Object[],System.Object>> CreatorCache; // 0x8
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Type> AssociatedMetadataTypesCache; // 0x10
	private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18

	// Methods

	// RVA: 0x309AF8C
	T GetCachedAttribute(object attributeProvider) { }

	// RVA: 0xDAE6A4
	bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter) { }

	// RVA: 0xDAE8A4
	DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0xDAE9B0
	DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0xDAECAC
	MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0xDAEEF4
	JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0xDAF070
	JsonConverter CreateJsonConverterInstance(Type converterType, object[] args) { }

	// RVA: 0xDAF198
	NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[] args) { }

	// RVA: 0xDAF2C0
	NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	// RVA: 0xDAF3A8
	System.Func<System.Object[],System.Object> GetCreator(Type type) { }

	// RVA: 0xDAF6C8
	Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0xDAF780
	Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: 0x309AF8C
	T GetAttribute(Type type) { }

	// RVA: 0x309AF8C
	T GetAttribute(MemberInfo memberInfo) { }

	// RVA: 0xDAFA24
	bool IsNonSerializable(object provider) { }

	// RVA: 0xDAEE6C
	bool IsSerializable(object provider) { }

	// RVA: 0x309AF8C
	T GetAttribute(object provider) { }

	// RVA: 0xDAFAAC
	bool get_FullyTrusted() { }

	// RVA: 0xDAF604
	ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0xDAFCDC
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class KebabCaseNamingStrategy 
{
	// Methods

	// RVA: 0xDB0450
	void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xDB0494
	void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xDB04D8
	void .ctor() { }

	// RVA: 0xDB04E0
	string ResolvePropertyName(string name) { }

}

// Namespace: Newtonsoft.Json.Serialization
public abstract class NamingStrategy 
{
	// Fields
	private bool <ProcessDictionaryKeys>k__BackingField; // 0x10
	private bool <ProcessExtensionDataNames>k__BackingField; // 0x11
	private bool <OverrideSpecifiedNames>k__BackingField; // 0x12

	// Methods

	// RVA: 0xDB04EC
	bool get_ProcessDictionaryKeys() { }

	// RVA: 0xDB04F4
	void set_ProcessDictionaryKeys(bool value) { }

	// RVA: 0xDB04FC
	bool get_ProcessExtensionDataNames() { }

	// RVA: 0xDB0504
	void set_ProcessExtensionDataNames(bool value) { }

	// RVA: 0xDB050C
	bool get_OverrideSpecifiedNames() { }

	// RVA: 0xDB0514
	void set_OverrideSpecifiedNames(bool value) { }

	// RVA: 0xDB051C
	string GetPropertyName(string name, bool hasSpecifiedName) { }

	// RVA: 0xDB053C
	string GetExtensionDataName(string name) { }

	// RVA: 0xDB0558
	string GetDictionaryKey(string key) { }

	// RVA: 0x2FE36BC
	string ResolvePropertyName(string name) { }

	// RVA: 0xDB0574
	int GetHashCode() { }

	// RVA: 0xDB065C
	bool Equals(object obj) { }

	// RVA: 0xDB06F8
	bool Equals(NamingStrategy other) { }

	// RVA: 0xDB048C
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ObjectConstructor<T0> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x2FE36BC
	internal object Invoke(object[] args) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class OnErrorAttribute 
{}

// Namespace: Newtonsoft.Json.Serialization
public class ReflectionAttributeProvider 
{
	// Fields
	private readonly object _attributeProvider; // 0x10

	// Methods

	// RVA: 0xDB0834
	void .ctor(object attributeProvider) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class ReflectionValueProvider 
{
	// Fields
	private readonly MemberInfo _memberInfo; // 0x10

	// Methods

	// RVA: 0xDB08AC
	void .ctor(MemberInfo memberInfo) { }

	// RVA: 0xDB0924
	void SetValue(object target, object value) { }

	// RVA: 0xDB0AD0
	object GetValue(object target) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class SnakeCaseNamingStrategy 
{
	// Methods

	// RVA: 0xDB0D90
	void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xDB0DCC
	void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xDB0E10
	void .ctor() { }

	// RVA: 0xDB0E18
	string ResolvePropertyName(string name) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class TraceJsonReader 
{
	// Fields
	private readonly JsonReader _innerReader; // 0x78
	private readonly JsonTextWriter _textWriter; // 0x80
	private readonly StringWriter _sw; // 0x88

	// Methods

	// RVA: 0xDB0E24
	void .ctor(JsonReader innerReader) { }

	// RVA: 0xDB0F94
	string GetDeserializedJsonMessage() { }

	// RVA: 0xDB0FB8
	bool Read() { }

	// RVA: 0xDB1058
	System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xDB10BC
	string ReadAsString() { }

	// RVA: 0xDB1120
	Byte[] ReadAsBytes() { }

	// RVA: 0xDB1188
	System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xDB1234
	System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xDB12AC
	System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xDB1314
	System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xDB138C
	System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xDB101C
	void WriteCurrentToken() { }

	// RVA: 0xDB140C
	int get_Depth() { }

	// RVA: 0xDB1430
	string get_Path() { }

	// RVA: 0xDB1454
	JsonToken get_TokenType() { }

	// RVA: 0xDB1478
	object get_Value() { }

	// RVA: 0xDB149C
	Type get_ValueType() { }

	// RVA: 0xDB14C0
	void Close() { }

	// RVA: 0xDB14E8
	bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xDB15C0
	int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xDB169C
	int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class TraceJsonWriter 
{
	// Fields
	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70

	// Methods

	// RVA: 0xDB1778
	void .ctor(JsonWriter innerWriter) { }

	// RVA: 0xDB1984
	string GetSerializedJsonMessage() { }

	// RVA: 0xDB19A8
	void WriteValue(Decimal value) { }

	// RVA: 0xDB1A20
	void WriteValue(System.Nullable<System.Decimal> value) { }

	// RVA: 0xDB1BE4
	void WriteValue(bool value) { }

	// RVA: 0xDB1C48
	void WriteValue(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDB1DD8
	void WriteValue(Byte value) { }

	// RVA: 0xDB1E3C
	void WriteValue(System.Nullable<System.Byte> value) { }

	// RVA: 0xDB1FCC
	void WriteValue(Char value) { }

	// RVA: 0xDB2030
	void WriteValue(System.Nullable<System.Char> value) { }

	// RVA: 0xDB21C0
	void WriteValue(Byte[] value) { }

	// RVA: 0xDB2238
	void WriteValue(DateTime value) { }

	// RVA: 0xDB229C
	void WriteValue(System.Nullable<System.DateTime> value) { }

	// RVA: 0xDB2434
	void WriteValue(DateTimeOffset value) { }

	// RVA: 0xDB24AC
	void WriteValue(System.Nullable<System.DateTimeOffset> value) { }

	// RVA: 0xDB2654
	void WriteValue(Double value) { }

	// RVA: 0xDB26C0
	void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xDB2858
	void WriteUndefined() { }

	// RVA: 0xDB28B0
	void WriteNull() { }

	// RVA: 0xDB2908
	void WriteValue(float value) { }

	// RVA: 0xDB2974
	void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xDB2B00
	void WriteValue(Guid value) { }

	// RVA: 0xDB2B78
	void WriteValue(System.Nullable<System.Guid> value) { }

	// RVA: 0xDB2D20
	void WriteValue(int value) { }

	// RVA: 0xDB2D84
	void WriteValue(System.Nullable<System.Int32> value) { }

	// RVA: 0xDB2F10
	void WriteValue(Int64 value) { }

	// RVA: 0xDB2F74
	void WriteValue(System.Nullable<System.Int64> value) { }

	// RVA: 0xDB310C
	void WriteValue(object value) { }

	// RVA: 0xDB3224
	void WriteValue(SByte value) { }

	// RVA: 0xDB3288
	void WriteValue(System.Nullable<System.SByte> value) { }

	// RVA: 0xDB3418
	void WriteValue(Int16 value) { }

	// RVA: 0xDB347C
	void WriteValue(System.Nullable<System.Int16> value) { }

	// RVA: 0xDB360C
	void WriteValue(string value) { }

	// RVA: 0xDB3670
	void WriteValue(TimeSpan value) { }

	// RVA: 0xDB36D4
	void WriteValue(System.Nullable<System.TimeSpan> value) { }

	// RVA: 0xDB386C
	void WriteValue(UInt32 value) { }

	// RVA: 0xDB38D0
	void WriteValue(System.Nullable<System.UInt32> value) { }

	// RVA: 0xDB3A5C
	void WriteValue(UInt64 value) { }

	// RVA: 0xDB3AC0
	void WriteValue(System.Nullable<System.UInt64> value) { }

	// RVA: 0xDB3C58
	void WriteValue(Uri value) { }

	// RVA: 0xDB3D40
	void WriteValue(UInt16 value) { }

	// RVA: 0xDB3DA4
	void WriteValue(System.Nullable<System.UInt16> value) { }

	// RVA: 0xDB3F34
	void WriteComment(string text) { }

	// RVA: 0xDB3F98
	void WriteStartArray() { }

	// RVA: 0xDB3FE8
	void WriteEndArray() { }

	// RVA: 0xDB4038
	void WriteStartConstructor(string name) { }

	// RVA: 0xDB4094
	void WriteEndConstructor() { }

	// RVA: 0xDB40E4
	void WritePropertyName(string name) { }

	// RVA: 0xDB4148
	void WritePropertyName(string name, bool escape) { }

	// RVA: 0xDB41BC
	void WriteStartObject() { }

	// RVA: 0xDB420C
	void WriteEndObject() { }

	// RVA: 0xDB425C
	void WriteRawValue(string json) { }

	// RVA: 0xDB42C0
	void WriteRaw(string json) { }

	// RVA: 0xDB4324
	void Close() { }

}

// Namespace: Newtonsoft.Json.Linq
public enum CommentHandling 
{
	// Fields
	public int value__; // 0x10
	public const CommentHandling Ignore = 0;
	public const CommentHandling Load = 1;
}

// Namespace: Newtonsoft.Json.Linq
public enum DuplicatePropertyNameHandling 
{
	// Fields
	public int value__; // 0x10
	public const DuplicatePropertyNameHandling Replace = 0;
	public const DuplicatePropertyNameHandling Ignore = 1;
	public const DuplicatePropertyNameHandling Error = 2;
}

// Namespace: Newtonsoft.Json.Linq
public class JArray 
{
	// Fields
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values; // 0x58

	// Methods

	// RVA: 0xDB4374
	System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDB437C
	JTokenType get_Type() { }

	// RVA: 0xDB4384
	void .ctor() { }

	// RVA: 0xDB44F4
	void .ctor(JArray other, JsonCloneSettings settings) { }

	// RVA: 0xDB493C
	void .ctor(object content) { }

	// RVA: 0xDB4A24
	JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDB4AFC
	JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xDB5004
	void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDB50F0
	JToken get_Item(int index) { }

	// RVA: 0xDB5100
	void set_Item(int index, JToken value) { }

	// RVA: 0xDB5110
	int IndexOfItem(JToken item) { }

	// RVA: 0xDB5184
	int IndexOf(JToken item) { }

	// RVA: 0xDB5194
	void Insert(int index, JToken item) { }

	// RVA: 0xDB51AC
	void RemoveAt(int index) { }

	// RVA: 0xDB51BC
	System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }

	// RVA: 0xDB5258
	void Add(JToken item) { }

	// RVA: 0xDB5268
	void Clear() { }

	// RVA: 0xDB5278
	bool Contains(JToken item) { }

	// RVA: 0xDB5288
	void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xDB5298
	bool get_IsReadOnly() { }

	// RVA: 0xDB52A0
	bool Remove(JToken item) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JConstructor 
{
	// Fields
	private string _name; // 0x58
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values; // 0x60

	// Methods

	// RVA: 0xDB52B0
	System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDB52B8
	int IndexOfItem(JToken item) { }

	// RVA: 0xDB532C
	string get_Name() { }

	// RVA: 0xDB5334
	JTokenType get_Type() { }

	// RVA: 0xDB533C
	void .ctor(JConstructor other, JsonCloneSettings settings) { }

	// RVA: 0xDB53F4
	void .ctor(string name) { }

	// RVA: 0xDB55A0
	JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDB560C
	void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDB5704
	JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }

}

// Namespace: Newtonsoft.Json.Linq
public abstract class JContainer 
{
	// Fields
	internal ListChangedEventHandler _listChanged; // 0x30
	internal AddingNewEventHandler _addingNew; // 0x38
	internal NotifyCollectionChangedEventHandler _collectionChanged; // 0x40
	private object _syncRoot; // 0x48
	private bool _busy; // 0x50

	// Methods

	// RVA: 0xDB58FC
	void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xDB59B0
	void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDB446C
	void .ctor() { }

	// RVA: 0xDB4594
	void .ctor(JContainer other, JsonCloneSettings settings) { }

	// RVA: 0xDB5EA0
	void CheckReentrancy() { }

	// RVA: 0xDB5F4C
	void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0xDB5F70
	void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xDB6000
	void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	// RVA: 0xDB6090
	bool get_HasValues() { }

	// RVA: 0xDB6154
	JToken get_First() { }

	// RVA: 0xDB62B8
	JToken get_Last() { }

	// RVA: 0xDB641C
	Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }

	// RVA: 0xDB649C
	bool IsMultiContent(object content) { }

	// RVA: 0xDB6598
	JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x2FE3404
	int IndexOfItem(JToken item) { }

	// RVA: 0xDB6770
	bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDB6BD8
	void RemoveItemAt(int index) { }

	// RVA: 0xDB70DC
	bool RemoveItem(JToken item) { }

	// RVA: 0xDB7144
	JToken GetItem(int index) { }

	// RVA: 0xDB720C
	void SetItem(int index, JToken item) { }

	// RVA: 0xDB792C
	void ClearItems() { }

	// RVA: 0xDB7D70
	void ReplaceItem(JToken existing, JToken replacement) { }

	// RVA: 0xDB7DD8
	bool ContainsItem(JToken item) { }

	// RVA: 0xDB7E00
	void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0xDB7864
	bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0xDB8394
	void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xDB84B4
	void Add(object content) { }

	// RVA: 0xDB8590
	bool TryAdd(object content) { }

	// RVA: 0xDB866C
	void AddAndSkipParentCheck(JToken token) { }

	// RVA: 0xDB5B20
	bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDB8748
	JToken CreateFromContent(object content) { }

	// RVA: 0xDB8904
	void RemoveAll() { }

	// RVA: 0xDB4EA4
	void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0xDB8914
	void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	// RVA: 0xDB90F8
	JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	// RVA: 0xDB9674
	string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xDB96C0
	PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xDB9870
	int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0xDB9880
	void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0xDB9898
	void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0xDB98A8
	JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0xDB98B8
	void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0xDB98C8
	void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0xDB98D8
	void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0xDB98E8
	bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0xDB98F8
	void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xDB9908
	bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0xDB9910
	bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	// RVA: 0xDB9920
	JToken EnsureValue(object value) { }

	// RVA: 0xDB99E0
	int System.Collections.IList.Add(object value) { }

	// RVA: 0xDB9AC0
	void System.Collections.IList.Clear() { }

	// RVA: 0xDB9AD0
	bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xDB9B08
	int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xDB9B40
	void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xDB9B94
	bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xDB9B9C
	bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xDB9BA4
	void System.Collections.IList.Remove(object value) { }

	// RVA: 0xDB9BDC
	void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xDB9BEC
	object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xDB9BFC
	void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xDB9C48
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xDB82CC
	int get_Count() { }

	// RVA: 0xDB9C58
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xDB9C60
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xDB9CEC
	void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xDB9CF0
	object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xDB9EBC
	bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xDB9EC4
	bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xDB9ECC
	bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xDB9ED4
	void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xDB9F14
	int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xDB9F54
	bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xDB9F5C
	void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xDB9F60
	void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xDB9FA0
	ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xDB9FA8
	PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xDB9FB0
	bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xDB9FB8
	bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xDB9FC0
	bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

}

// Namespace: Newtonsoft.Json.Linq
public struct JEnumerable<T0> 
{
	// Fields
	public static readonly Newtonsoft.Json.Linq.JEnumerable<T> Empty; // 0x0
	private readonly System.Collections.Generic.IEnumerable<T> _enumerable; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IEnumerable<T> enumerable) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x309AF8C
	bool Equals(Newtonsoft.Json.Linq.JEnumerable<T> other) { }

	// RVA: 0x2FE3174
	bool Equals(object obj) { }

	// RVA: 0x2FE32D4
	int GetHashCode() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly Newtonsoft.Json.Linq.JObject.JObjectDynamicProxy.<>c <>9; // 0x0
	public static System.Func<Newtonsoft.Json.Linq.JProperty,System.String> <>9__2_0; // 0x8

	// Methods

	// RVA: 0xDBD178
	void .cctor() { }

	// RVA: 0xDBD1E4
	void .ctor() { }

	// RVA: 0xDBD1EC
	string <GetDynamicMemberNames>b__2_0(JProperty p) { }

}

// Namespace: 
private class JObjectDynamicProxy 
{
	// Methods

	// RVA: 0xDBCE2C
	bool TryGetMember(JObject instance, GetMemberBinder binder, out object result) { }

	// RVA: 0xDBCEDC
	bool TrySetMember(JObject instance, SetMemberBinder binder, object value) { }

	// RVA: 0xDBD01C
	System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(JObject instance) { }

	// RVA: 0xDBCDD8
	void .ctor() { }

}

// Namespace: 
private sealed class <GetEnumerator>d__64 
{
	// Fields
	private int <>1__state; // 0x10
	private System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> <>2__current; // 0x18
	public JObject <>4__this; // 0x28
	private System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> <>7__wrap1; // 0x30

	// Methods

	// RVA: 0xDBC36C
	void .ctor(int <>1__state) { }

	// RVA: 0xDBD208
	void System.IDisposable.Dispose() { }

	// RVA: 0xDBD2DC
	bool MoveNext() { }

	// RVA: 0xDBD670
	void <>m__Finally1() { }

	// RVA: 0xDBD734
	System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	// RVA: 0xDBD740
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xDBD780
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JObject 
{
	// Fields
	private readonly JPropertyKeyedCollection _properties; // 0x58
	private PropertyChangedEventHandler PropertyChanged; // 0x60
	private PropertyChangingEventHandler PropertyChanging; // 0x68

	// Methods

	// RVA: 0xDB9FC8
	System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDB9FD0
	void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xDBA074
	void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xDBA118
	void add_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0xDBA1BC
	void remove_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0xDB8E68
	void .ctor() { }

	// RVA: 0xDBA2FC
	void .ctor(JObject other) { }

	// RVA: 0xDBA3F8
	void .ctor(JObject other, JsonCloneSettings settings) { }

	// RVA: 0xDBA4F8
	void .ctor(object[] content) { }

	// RVA: 0xDBA4FC
	void .ctor(object content) { }

	// RVA: 0xDBA644
	int IndexOfItem(JToken item) { }

	// RVA: 0xDBA7C4
	bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDBA850
	void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xDBAB58
	void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0xDBACA0
	void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0xDBACC8
	JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDBAD34
	JTokenType get_Type() { }

	// RVA: 0xDBAD3C
	System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties() { }

	// RVA: 0xDB9334
	JProperty Property(string name, StringComparison comparison) { }

	// RVA: 0xDBAD90
	JToken get_Item(string propertyName) { }

	// RVA: 0xDBAE14
	void set_Item(string propertyName, JToken value) { }

	// RVA: 0xDBB068
	JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xDBB238
	void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDBAFE0
	void Add(string propertyName, JToken value) { }

	// RVA: 0xDBB4F4
	bool ContainsKey(string propertyName) { }

	// RVA: 0xDBB620
	System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0xDBB6DC
	bool Remove(string propertyName) { }

	// RVA: 0xDBB7E8
	bool TryGetValue(string propertyName, out JToken value) { }

	// RVA: 0xDBB840
	System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0xDBB880
	void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xDBBA3C
	void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0xDBBA4C
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xDBBBDC
	void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>[] array, int arrayIndex) { }

	// RVA: 0xDBC108
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0xDBC110
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xDBC2F4
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>> GetEnumerator() { }

	// RVA: 0xDBC398
	void OnPropertyChanged(string propertyName) { }

	// RVA: 0xDBC42C
	void OnPropertyChanging(string propertyName) { }

	// RVA: 0xDBC4C0
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xDBC568
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xDBCA64
	AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xDBCAE0
	string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xDBCAE8
	string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xDBCAF0
	TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xDBCB48
	EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xDBCB50
	PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xDBCB58
	object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xDBCB60
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xDBCBDC
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xDBCC58
	object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xDBCCEC
	DynamicMetaObject GetMetaObject(Expression parameter) { }

}

// Namespace: 
private sealed class <GetEnumerator>d__1 
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	public JPropertyList <>4__this; // 0x20

	// Methods

	// RVA: 0xDBE1EC
	void .ctor(int <>1__state) { }

	// RVA: 0xDBE474
	void System.IDisposable.Dispose() { }

	// RVA: 0xDBE478
	bool MoveNext() { }

	// RVA: 0xDBE4F4
	JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	// RVA: 0xDBE4FC
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xDBE53C
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private class JPropertyList 
{
	// Fields
	internal JToken _token; // 0x10

	// Methods

	// RVA: 0xDBE174
	System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }

	// RVA: 0xDBE218
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xDBE290
	void Add(JToken item) { }

	// RVA: 0xDBE298
	void Clear() { }

	// RVA: 0xDBE2A4
	bool Contains(JToken item) { }

	// RVA: 0xDBE2B4
	void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xDBE338
	bool Remove(JToken item) { }

	// RVA: 0xDBE388
	int get_Count() { }

	// RVA: 0xDBE398
	bool get_IsReadOnly() { }

	// RVA: 0xDBDC60
	int IndexOf(JToken item) { }

	// RVA: 0xDBE3A0
	void Insert(int index, JToken item) { }

	// RVA: 0xDBE3B4
	void RemoveAt(int index) { }

	// RVA: 0xDBE3C8
	JToken get_Item(int index) { }

	// RVA: 0xDBE41C
	void set_Item(int index, JToken value) { }

	// RVA: 0xDBD89C
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JProperty 
{
	// Fields
	private readonly JPropertyList _content; // 0x58
	private readonly string _name; // 0x60

	// Methods

	// RVA: 0xDBD7E8
	System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDBD7F0
	string get_Name() { }

	// RVA: 0xDB8E48
	JToken get_Value() { }

	// RVA: 0xDBAF5C
	void set_Value(JToken value) { }

	// RVA: 0xDBD7F8
	void .ctor(JProperty other, JsonCloneSettings settings) { }

	// RVA: 0xDBD8A4
	JToken GetItem(int index) { }

	// RVA: 0xDBD904
	void SetItem(int index, JToken item) { }

	// RVA: 0xDBDAC8
	bool RemoveItem(JToken item) { }

	// RVA: 0xDBDB78
	void RemoveItemAt(int index) { }

	// RVA: 0xDBDC28
	int IndexOfItem(JToken item) { }

	// RVA: 0xDBDC70
	bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDBDDA0
	bool ContainsItem(JToken item) { }

	// RVA: 0xDBDDC8
	void ClearItems() { }

	// RVA: 0xDBDE78
	JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDBDEE4
	JTokenType get_Type() { }

	// RVA: 0xDB9510
	void .ctor(string name) { }

	// RVA: 0xDBB338
	void .ctor(string name, object content) { }

	// RVA: 0xDBDEEC
	void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDBDF7C
	JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JPropertyDescriptor 
{
	// Methods

	// RVA: 0xDBCA58
	void .ctor(string name) { }

	// RVA: 0xDBE544
	bool CanResetValue(object component) { }

	// RVA: 0xDBE54C
	object GetValue(object component) { }

	// RVA: 0xDBE664
	void ResetValue(object component) { }

	// RVA: 0xDBE668
	void SetValue(object component, object value) { }

	// RVA: 0xDBE800
	bool ShouldSerializeValue(object component) { }

	// RVA: 0xDBE808
	Type get_ComponentType() { }

	// RVA: 0xDBE8A8
	bool get_IsReadOnly() { }

	// RVA: 0xDBE8B0
	Type get_PropertyType() { }

	// RVA: 0xDBE950
	int get_NameHashCode() { }

}

// Namespace: Newtonsoft.Json.Linq
internal class JPropertyKeyedCollection 
{
	// Fields
	private static readonly System.Collections.Generic.IEqualityComparer<System.String> Comparer; // 0x0
	private System.Collections.Generic.Dictionary<System.String,Newtonsoft.Json.Linq.JToken> _dictionary; // 0x18

	// Methods

	// RVA: 0xDBA260
	void .ctor() { }

	// RVA: 0xDBE958
	void AddKey(string key, JToken item) { }

	// RVA: 0xDBEA98
	void ClearItems() { }

	// RVA: 0xDBB564
	bool Contains(string key) { }

	// RVA: 0xDBE9CC
	void EnsureDictionary() { }

	// RVA: 0xDBEB20
	string GetKeyForItem(JToken item) { }

	// RVA: 0xDBEBA4
	void InsertItem(int index, JToken item) { }

	// RVA: 0xDBECD4
	void RemoveItem(int index) { }

	// RVA: 0xDBEE5C
	void RemoveKey(string key) { }

	// RVA: 0xDBEECC
	void SetItem(int index, JToken item) { }

	// RVA: 0xDBAACC
	bool TryGetValue(string key, out JToken value) { }

	// RVA: 0xDBB680
	System.Collections.Generic.ICollection<System.String> get_Keys() { }

	// RVA: 0xDBA714
	int IndexOfReference(JToken t) { }

	// RVA: 0xDBF214
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JRaw 
{
	// Methods

	// RVA: 0xDBF2F8
	void .ctor(JRaw other, JsonCloneSettings settings) { }

	// RVA: 0xDBF420
	void .ctor(object rawJson) { }

	// RVA: 0xDBF530
	JRaw Create(JsonReader reader) { }

	// RVA: 0xDBF87C
	JToken CloneToken(JsonCloneSettings settings) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JsonCloneSettings 
{
	// Fields
	internal static readonly JsonCloneSettings SkipCopyAnnotations; // 0x0
	private bool <CopyAnnotations>k__BackingField; // 0x10

	// Methods

	// RVA: 0xDBF8E8
	void .ctor() { }

	// RVA: 0xDBF914
	bool get_CopyAnnotations() { }

	// RVA: 0xDBF91C
	void set_CopyAnnotations(bool value) { }

	// RVA: 0xDBF924
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JsonLoadSettings 
{
	// Fields
	private CommentHandling _commentHandling; // 0x10
	private LineInfoHandling _lineInfoHandling; // 0x14
	private DuplicatePropertyNameHandling _duplicatePropertyNameHandling; // 0x18

	// Methods

	// RVA: 0xDBF994
	CommentHandling get_CommentHandling() { }

	// RVA: 0xDBF99C
	LineInfoHandling get_LineInfoHandling() { }

	// RVA: 0xDBF9A4
	DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }

}

// Namespace: 
private class LineInfoAnnotation 
{
	// Fields
	internal readonly int LineNumber; // 0x10
	internal readonly int LinePosition; // 0x14

	// Methods

	// RVA: 0xDC81F0
	void .ctor(int lineNumber, int linePosition) { }

}

// Namespace: Newtonsoft.Json.Linq
public abstract class JToken 
{
	// Fields
	private JContainer _parent; // 0x10
	private JToken _previous; // 0x18
	private JToken _next; // 0x20
	private object _annotations; // 0x28
	private static readonly JTokenType[] BooleanTypes; // 0x0
	private static readonly JTokenType[] NumberTypes; // 0x8
	private static readonly JTokenType[] BigIntegerTypes; // 0x10
	private static readonly JTokenType[] StringTypes; // 0x18
	private static readonly JTokenType[] GuidTypes; // 0x20
	private static readonly JTokenType[] TimeSpanTypes; // 0x28
	private static readonly JTokenType[] UriTypes; // 0x30
	private static readonly JTokenType[] CharTypes; // 0x38
	private static readonly JTokenType[] DateTimeTypes; // 0x40
	private static readonly JTokenType[] BytesTypes; // 0x48

	// Methods

	// RVA: 0xDBF9AC
	JContainer get_Parent() { }

	// RVA: 0xDBF9B4
	void set_Parent(JContainer value) { }

	// RVA: 0xDB6758
	JToken get_Root() { }

	// RVA: 0x2FE36BC
	JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x2FE32D4
	JTokenType get_Type() { }

	// RVA: 0x2FE3054
	bool get_HasValues() { }

	// RVA: 0xDBF9BC
	JToken get_Next() { }

	// RVA: 0xDBF9C4
	void set_Next(JToken value) { }

	// RVA: 0xDBF9CC
	JToken get_Previous() { }

	// RVA: 0xDBF9D4
	void set_Previous(JToken value) { }

	// RVA: 0xDBF9DC
	string get_Path() { }

	// RVA: 0xDB5A64
	void .ctor() { }

	// RVA: 0xDBFCEC
	JToken get_First() { }

	// RVA: 0xDBFD80
	JToken get_Last() { }

	// RVA: 0xDBFE14
	Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }

	// RVA: 0xDBB770
	void Remove() { }

	// RVA: 0xDB95F8
	void Replace(JToken value) { }

	// RVA: 0x2FE47D4
	void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDBFE90
	string ToString() { }

	// RVA: 0xDBFF78
	string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0xDC019C
	JValue EnsureValue(JToken value) { }

	// RVA: 0xDC02D4
	string GetType(JToken token) { }

	// RVA: 0xDC03D0
	bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0xDC04B0
	bool op_Explicit(JToken value) { }

	// RVA: 0xDC0758
	DateTimeOffset op_Explicit(JToken value) { }

	// RVA: 0xDC0A2C
	System.Nullable<System.Boolean> op_Explicit(JToken value) { }

	// RVA: 0xDC0D18
	Int64 op_Explicit(JToken value) { }

	// RVA: 0xDC0FA0
	System.Nullable<System.DateTime> op_Explicit(JToken value) { }

	// RVA: 0xDC1264
	System.Nullable<System.DateTimeOffset> op_Explicit(JToken value) { }

	// RVA: 0xDC15A4
	System.Nullable<System.Decimal> op_Explicit(JToken value) { }

	// RVA: 0xDC1894
	System.Nullable<System.Double> op_Explicit(JToken value) { }

	// RVA: 0xDC1B3C
	System.Nullable<System.Char> op_Explicit(JToken value) { }

	// RVA: 0xDC1E00
	int op_Explicit(JToken value) { }

	// RVA: 0xDC2088
	Int16 op_Explicit(JToken value) { }

	// RVA: 0xDC2310
	UInt16 op_Explicit(JToken value) { }

	// RVA: 0xDC2598
	Char op_Explicit(JToken value) { }

	// RVA: 0xDC2820
	Byte op_Explicit(JToken value) { }

	// RVA: 0xDC2AA8
	SByte op_Explicit(JToken value) { }

	// RVA: 0xDC2D30
	System.Nullable<System.Int32> op_Explicit(JToken value) { }

	// RVA: 0xDC2FD8
	System.Nullable<System.Int16> op_Explicit(JToken value) { }

	// RVA: 0xDC329C
	System.Nullable<System.UInt16> op_Explicit(JToken value) { }

	// RVA: 0xDC3560
	System.Nullable<System.Byte> op_Explicit(JToken value) { }

	// RVA: 0xDC3824
	System.Nullable<System.SByte> op_Explicit(JToken value) { }

	// RVA: 0xDC3AE8
	DateTime op_Explicit(JToken value) { }

	// RVA: 0xDC3D70
	System.Nullable<System.Int64> op_Explicit(JToken value) { }

	// RVA: 0xDC4018
	System.Nullable<System.Single> op_Explicit(JToken value) { }

	// RVA: 0xDC42C0
	Decimal op_Explicit(JToken value) { }

	// RVA: 0xDC4548
	System.Nullable<System.UInt32> op_Explicit(JToken value) { }

	// RVA: 0xDC47F0
	System.Nullable<System.UInt64> op_Explicit(JToken value) { }

	// RVA: 0xDC4A98
	Double op_Explicit(JToken value) { }

	// RVA: 0xDC4D20
	float op_Explicit(JToken value) { }

	// RVA: 0xDC4FA8
	string op_Explicit(JToken value) { }

	// RVA: 0xDC52D8
	UInt32 op_Explicit(JToken value) { }

	// RVA: 0xDC5560
	UInt64 op_Explicit(JToken value) { }

	// RVA: 0xDC57E8
	Guid op_Explicit(JToken value) { }

	// RVA: 0xDC5A78
	System.Nullable<System.Guid> op_Explicit(JToken value) { }

	// RVA: 0xDC5D8C
	TimeSpan op_Explicit(JToken value) { }

	// RVA: 0xDC600C
	System.Nullable<System.TimeSpan> op_Explicit(JToken value) { }

	// RVA: 0xDC62C8
	Uri op_Explicit(JToken value) { }

	// RVA: 0xDC6544
	BigInteger ToBigInteger(JToken value) { }

	// RVA: 0xDC6710
	System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(JToken value) { }

	// RVA: 0xDC6964
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xDC6A18
	System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: 0xDC6AB4
	JsonReader CreateReader() { }

	// RVA: 0xDC6BDC
	object ToObject(Type objectType) { }

	// RVA: 0xDC7A74
	object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0xDC7CF0
	JToken ReadFrom(JsonReader reader) { }

	// RVA: 0xDC7D78
	JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xDB4CA8
	void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0xDC8174
	void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0xDC848C
	bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xDC84EC
	int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xDC854C
	int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xDC85AC
	DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0xDC8680
	DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0xDC8690
	object System.ICloneable.Clone() { }

	// RVA: 0xDC86A0
	JToken DeepClone() { }

	// RVA: 0xDC8228
	void AddAnnotation(object annotation) { }

	// RVA: 0x309AF8C
	T Annotation() { }

	// RVA: 0xDB5A6C
	void CopyAnnotations(JToken target, JToken source) { }

	// RVA: 0xDC86B0
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JTokenReader 
{
	// Fields
	private readonly JToken _root; // 0x78
	private string _initialPath; // 0x80
	private JToken _parent; // 0x88
	private JToken _current; // 0x90

	// Methods

	// RVA: 0xDC89BC
	JToken get_CurrentToken() { }

	// RVA: 0xDC6B64
	void .ctor(JToken token) { }

	// RVA: 0xDC89C4
	bool Read() { }

	// RVA: 0xDC8BD0
	bool ReadOver(JToken t) { }

	// RVA: 0xDC93F0
	bool ReadToEnd() { }

	// RVA: 0xDC95A4
	System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0xDC8B3C
	bool ReadInto(JContainer c) { }

	// RVA: 0xDC942C
	bool SetEnd(JContainer c) { }

	// RVA: 0xDC8CBC
	void SetToken(JToken token) { }

	// RVA: 0xDC9714
	string SafeToString(object value) { }

	// RVA: 0xDC9734
	bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xDC97FC
	int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xDC98C8
	int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xDC9994
	string get_Path() { }

}

// Namespace: Newtonsoft.Json.Linq
public enum JTokenType 
{
	// Fields
	public int value__; // 0x10
	public const JTokenType None = 0;
	public const JTokenType Object = 1;
	public const JTokenType Array = 2;
	public const JTokenType Constructor = 3;
	public const JTokenType Property = 4;
	public const JTokenType Comment = 5;
	public const JTokenType Integer = 6;
	public const JTokenType Float = 7;
	public const JTokenType String = 8;
	public const JTokenType Boolean = 9;
	public const JTokenType Null = 10;
	public const JTokenType Undefined = 11;
	public const JTokenType Date = 12;
	public const JTokenType Raw = 13;
	public const JTokenType Bytes = 14;
	public const JTokenType Guid = 15;
	public const JTokenType Uri = 16;
	public const JTokenType TimeSpan = 17;
}

// Namespace: Newtonsoft.Json.Linq
public class JTokenWriter 
{
	// Fields
	private JContainer _token; // 0x60
	private JContainer _parent; // 0x68
	private JValue _value; // 0x70
	private JToken _current; // 0x78

	// Methods

	// RVA: 0xDC9AB4
	JToken get_Token() { }

	// RVA: 0xDC9AD0
	void .ctor() { }

	// RVA: 0xDC9B58
	void Close() { }

	// RVA: 0xDC9B60
	void WriteStartObject() { }

	// RVA: 0xDC9C0C
	void AddParent(JContainer container) { }

	// RVA: 0xDC9C78
	void RemoveParent() { }

	// RVA: 0xDC9CF8
	void WriteStartArray() { }

	// RVA: 0xDC9DA4
	void WriteStartConstructor(string name) { }

	// RVA: 0xDC9E5C
	void WriteEnd(JsonToken token) { }

	// RVA: 0xDC9E60
	void WritePropertyName(string name) { }

	// RVA: 0xDC9F68
	void AddRawValue(object value, JTokenType type, JsonToken token) { }

	// RVA: 0xDCA030
	void AddJValue(JValue value, JsonToken token) { }

	// RVA: 0xDCA0FC
	void WriteValue(object value) { }

	// RVA: 0xDCA19C
	void WriteNull() { }

	// RVA: 0xDCA1CC
	void WriteUndefined() { }

	// RVA: 0xDCA1FC
	void WriteRaw(string json) { }

	// RVA: 0xDCA2D4
	void WriteComment(string text) { }

	// RVA: 0xDCA3A4
	void WriteValue(string value) { }

	// RVA: 0xDCA500
	void WriteValue(int value) { }

	// RVA: 0xDCA58C
	void WriteValue(UInt32 value) { }

	// RVA: 0xDCA618
	void WriteValue(Int64 value) { }

	// RVA: 0xDCA760
	void WriteValue(UInt64 value) { }

	// RVA: 0xDCA8A4
	void WriteValue(float value) { }

	// RVA: 0xDCA9F8
	void WriteValue(Double value) { }

	// RVA: 0xDCAB50
	void WriteValue(bool value) { }

	// RVA: 0xDCAC98
	void WriteValue(Int16 value) { }

	// RVA: 0xDCAD24
	void WriteValue(UInt16 value) { }

	// RVA: 0xDCADB0
	void WriteValue(Char value) { }

	// RVA: 0xDCAF00
	void WriteValue(Byte value) { }

	// RVA: 0xDCAF8C
	void WriteValue(SByte value) { }

	// RVA: 0xDCB018
	void WriteValue(Decimal value) { }

	// RVA: 0xDCB184
	void WriteValue(DateTime value) { }

	// RVA: 0xDCB30C
	void WriteValue(DateTimeOffset value) { }

	// RVA: 0xDCB470
	void WriteValue(Byte[] value) { }

	// RVA: 0xDCB548
	void WriteValue(TimeSpan value) { }

	// RVA: 0xDCB68C
	void WriteValue(Guid value) { }

	// RVA: 0xDCB7F0
	void WriteValue(Uri value) { }

	// RVA: 0xDCB970
	void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

}

// Namespace: 
private class JValueDynamicProxy 
{
	// Methods

	// RVA: 0xDCF264
	bool TryConvert(JValue instance, ConvertBinder binder, out object result) { }

	// RVA: 0xDCF450
	bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, out object result) { }

	// RVA: 0xDCE950
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JValue 
{
	// Fields
	private JTokenType _valueType; // 0x30
	private object _value; // 0x38

	// Methods

	// RVA: 0xDBF4A4
	void .ctor(object value, JTokenType type) { }

	// RVA: 0xDBF2FC
	void .ctor(JValue other, JsonCloneSettings settings) { }

	// RVA: 0xDCA694
	void .ctor(Int64 value) { }

	// RVA: 0xDCB0A8
	void .ctor(Decimal value) { }

	// RVA: 0xDCA7DC
	void .ctor(UInt64 value) { }

	// RVA: 0xDCAA7C
	void .ctor(Double value) { }

	// RVA: 0xDCA928
	void .ctor(float value) { }

	// RVA: 0xDCB244
	void .ctor(DateTime value) { }

	// RVA: 0xDCB39C
	void .ctor(DateTimeOffset value) { }

	// RVA: 0xDCABCC
	void .ctor(bool value) { }

	// RVA: 0xDCA47C
	void .ctor(string value) { }

	// RVA: 0xDCB71C
	void .ctor(Guid value) { }

	// RVA: 0xDCB86C
	void .ctor(Uri value) { }

	// RVA: 0xDCB5C4
	void .ctor(TimeSpan value) { }

	// RVA: 0xDB8870
	void .ctor(object value) { }

	// RVA: 0xDCC118
	bool get_HasValues() { }

	// RVA: 0xDCC120
	int CompareBigInteger(BigInteger i1, object i2) { }

	// RVA: 0xDCC49C
	int Compare(JTokenType valueType, object objA, object objB) { }

	// RVA: 0xDCCF10
	int CompareFloat(object objA, object objB) { }

	// RVA: 0xDCD054
	bool Operation(ExpressionType operation, object objA, object objB, out object result) { }

	// RVA: 0xDCD964
	JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDB8F8C
	JValue CreateComment(string value) { }

	// RVA: 0xDB66A4
	JValue CreateNull() { }

	// RVA: 0xDB9044
	JValue CreateUndefined() { }

	// RVA: 0xDCBC74
	JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, object value) { }

	// RVA: 0xDCD9D0
	JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current) { }

	// RVA: 0xDCDB98
	JTokenType get_Type() { }

	// RVA: 0xDCDBA0
	object get_Value() { }

	// RVA: 0xDCDBA8
	void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDCE4FC
	bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0xDCE564
	bool Equals(JValue other) { }

	// RVA: 0xDCE5CC
	bool Equals(object obj) { }

	// RVA: 0xDCE6A8
	int GetHashCode() { }

	// RVA: 0xDCE6C0
	string ToString() { }

	// RVA: 0xDCE72C
	string ToString(IFormatProvider formatProvider) { }

	// RVA: 0xDCE738
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xDCE864
	DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0xDCE9A4
	int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xDCEA60
	int CompareTo(JValue obj) { }

	// RVA: 0xDCEA90
	TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0xDCEB60
	bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xDCEBE0
	Char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xDCEC60
	SByte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xDCECE0
	Byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xDCED60
	Int16 System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xDCEDE0
	UInt16 System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xDCEE60
	int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xDCEEE0
	UInt32 System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xDCEF60
	Int64 System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xDCEFE0
	UInt64 System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xDCF060
	float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xDCF0E0
	Double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xDCF160
	Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xDCF1E0
	DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xDCF260
	object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }

}

// Namespace: Newtonsoft.Json.Linq
public enum LineInfoHandling 
{
	// Fields
	public int value__; // 0x10
	public const LineInfoHandling Ignore = 0;
	public const LineInfoHandling Load = 1;
}

// Namespace: Newtonsoft.Json.Converters
public class BinaryConverter 
{
	// Fields
	private const string BinaryTypeName = 5714615984;
	private const string BinaryToArrayName = 5736094384;
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0xDCF7DC
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDCF840
	Byte[] GetByteArray(object value) { }

	// RVA: 0xDCFA40
	void EnsureReflectionObject(Type t) { }

	// RVA: 0xDCFBFC
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD0038
	Byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0xDD036C
	bool CanConvert(Type objectType) { }

	// RVA: 0xDD0494
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class BsonObjectIdConverter 
{
	// Methods

	// RVA: 0xDD049C
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD05A0
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD072C
	bool CanConvert(Type objectType) { }

	// RVA: 0xDD07B8
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public abstract class CustomCreationConverter<T0> 
{
	// Methods

	// RVA: 0x2FE49A8
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x2FE3884
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x309AF8C
	T Create(Type objectType) { }

	// RVA: 0x2FE3174
	bool CanConvert(Type objectType) { }

	// RVA: 0x2FE3054
	bool get_CanWrite() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class DataSetConverter 
{
	// Methods

	// RVA: 0xDD07C0
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD0C64
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD0FC8
	bool CanConvert(Type valueType) { }

	// RVA: 0xDD1080
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class DataTableConverter 
{
	// Methods

	// RVA: 0xDD1088
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD1820
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD1B18
	void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	// RVA: 0xDD204C
	Type GetColumnDataType(JsonReader reader) { }

	// RVA: 0xDD2244
	bool CanConvert(Type valueType) { }

	// RVA: 0xDD22FC
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public abstract class DateTimeConverterBase 
{
	// Methods

	// RVA: 0xDD2304
	bool CanConvert(Type objectType) { }

	// RVA: 0xDD247C
	void .ctor() { }

}

// Namespace: 
internal class Union 
{
	// Fields
	public readonly FSharpFunction TagReader; // 0x10
	public readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases; // 0x18

	// Methods

	// RVA: 0xDD301C
	void .ctor(FSharpFunction tagReader, System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases) { }

}

// Namespace: 
internal class UnionCase 
{
	// Fields
	public readonly int Tag; // 0x10
	public readonly string Name; // 0x18
	public readonly PropertyInfo[] Fields; // 0x20
	public readonly FSharpFunction FieldReader; // 0x28
	public readonly FSharpFunction Constructor; // 0x30

	// Methods

	// RVA: 0xDD306C
	void .ctor(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0 
{
	// Fields
	public int tag; // 0x10

	// Methods

	// RVA: 0xDD35F4
	void .ctor() { }

	// RVA: 0xDD41A4
	bool <WriteJson>b__0(UnionCase c) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0 
{
	// Fields
	public string caseName; // 0x10
	public System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase,System.Boolean> <>9__0; // 0x18

	// Methods

	// RVA: 0xDD3CDC
	void .ctor() { }

	// RVA: 0xDD41CC
	bool <ReadJson>b__0(UnionCase c) { }

}

// Namespace: Newtonsoft.Json.Converters
public class DiscriminatedUnionConverter 
{
	// Fields
	private const string CasePropertyName = 5736094240;
	private const string FieldsPropertyName = 5736094192;
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union> UnionCache; // 0x0
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Type> UnionTypeLookupCache; // 0x8

	// Methods

	// RVA: 0xDD2484
	Type CreateUnionTypeLookup(Type t) { }

	// RVA: 0xDD2708
	Union CreateUnion(Type t) { }

	// RVA: 0xDD30F4
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD35FC
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD3CE4
	bool CanConvert(Type objectType) { }

	// RVA: 0xDD4008
	void .ctor() { }

	// RVA: 0xDD4010
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class EntityKeyMemberConverter 
{
	// Fields
	private const string EntityKeyMemberFullTypeName = 5715971840;
	private const string KeyPropertyName = 5736094000;
	private const string TypePropertyName = 5736093952;
	private const string ValuePropertyName = 5736093904;
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0xDD41F4
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD46B8
	void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	// RVA: 0xDD47A8
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD4594
	void EnsureReflectionObject(Type objectType) { }

	// RVA: 0xDD4AA8
	bool CanConvert(Type objectType) { }

	// RVA: 0xDD4B04
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class ExpandoObjectConverter 
{
	// Methods

	// RVA: 0xDD4B0C
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD4B10
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD4B14
	object ReadValue(JsonReader reader) { }

	// RVA: 0xDD4ED8
	object ReadList(JsonReader reader) { }

	// RVA: 0xDD4C84
	object ReadObject(JsonReader reader) { }

	// RVA: 0xDD50B8
	bool CanConvert(Type objectType) { }

	// RVA: 0xDD5144
	bool get_CanWrite() { }

	// RVA: 0xDD514C
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class IsoDateTimeConverter 
{
	// Fields
	private const string DefaultDateTimeFormat = 5735918880;
	private DateTimeStyles _dateTimeStyles; // 0x10
	private string _dateTimeFormat; // 0x18
	private CultureInfo _culture; // 0x20

	// Methods

	// RVA: 0xDD5154
	DateTimeStyles get_DateTimeStyles() { }

	// RVA: 0xDD515C
	void set_DateTimeStyles(DateTimeStyles value) { }

	// RVA: 0xDD5164
	string get_DateTimeFormat() { }

	// RVA: 0xDD51D0
	void set_DateTimeFormat(string value) { }

	// RVA: 0xDD5214
	CultureInfo get_Culture() { }

	// RVA: 0xDD5290
	void set_Culture(CultureInfo value) { }

	// RVA: 0xDD5298
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD55B8
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD5C98
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class JavaScriptDateTimeConverter 
{
	// Methods

	// RVA: 0xDD5CA8
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD5E94
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD6200
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class KeyValuePairConverter 
{
	// Fields
	private const string KeyName = 5736093760;
	private const string ValueName = 5736093712;
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType; // 0x0

	// Methods

	// RVA: 0xDD6208
	ReflectionObject InitializeReflectionObject(Type t) { }

	// RVA: 0xDD6488
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD6714
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD6C0C
	bool CanConvert(Type objectType) { }

	// RVA: 0xDD6D5C
	void .ctor() { }

	// RVA: 0xDD6D64
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class RegexConverter 
{
	// Fields
	private const string PatternName = 5736093568;
	private const string OptionsName = 5736093520;

	// Methods

	// RVA: 0xDD6E50
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD72A0
	bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0xDD6F6C
	void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0xDD70D8
	void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0xDD7360
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD7718
	object ReadRegexString(JsonReader reader) { }

	// RVA: 0xDD7410
	Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0xDD7878
	bool CanConvert(Type objectType) { }

	// RVA: 0xDD78F4
	bool IsRegex(Type objectType) { }

	// RVA: 0xDD7980
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class StringEnumConverter 
{
	// Fields
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x10
	private bool <AllowIntegerValues>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDD7988
	bool get_CamelCaseText() { }

	// RVA: 0xDD7A10
	void set_CamelCaseText(bool value) { }

	// RVA: 0xDD7AF8
	NamingStrategy get_NamingStrategy() { }

	// RVA: 0xDD7B00
	void set_NamingStrategy(NamingStrategy value) { }

	// RVA: 0xDD7B08
	bool get_AllowIntegerValues() { }

	// RVA: 0xDD7B10
	void set_AllowIntegerValues(bool value) { }

	// RVA: 0xDD7B18
	void .ctor() { }

	// RVA: 0xDD7B28
	void .ctor(bool camelCaseText) { }

	// RVA: 0xDD7BC0
	void .ctor(NamingStrategy namingStrategy, bool allowIntegerValues) { }

	// RVA: 0xDD7C10
	void .ctor(Type namingStrategyType) { }

	// RVA: 0xDD7CCC
	void .ctor(Type namingStrategyType, object[] namingStrategyParameters) { }

	// RVA: 0xDD7D8C
	void .ctor(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) { }

	// RVA: 0xDD7E60
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD8070
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD8540
	bool CanConvert(Type objectType) { }

}

// Namespace: Newtonsoft.Json.Converters
public class UnixDateTimeConverter 
{
	// Fields
	internal static readonly DateTime UnixEpoch; // 0x0
	private bool <AllowPreEpoch>k__BackingField; // 0x10

	// Methods

	// RVA: 0xDD85F0
	bool get_AllowPreEpoch() { }

	// RVA: 0xDD85F8
	void set_AllowPreEpoch(bool value) { }

	// RVA: 0xDD8600
	void .ctor() { }

	// RVA: 0xDD8628
	void .ctor(bool allowPreEpoch) { }

	// RVA: 0xDD8654
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD88C0
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD8D20
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class VersionConverter 
{
	// Methods

	// RVA: 0xDD8DA0
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDD8E98
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDD9144
	bool CanConvert(Type objectType) { }

	// RVA: 0xDD91D0
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDocumentWrapper 
{
	// Fields
	private readonly XmlDocument _document; // 0x28

	// Methods

	// RVA: 0xDD91D8
	void .ctor(XmlDocument document) { }

	// RVA: 0xDD9250
	IXmlNode CreateComment(string data) { }

	// RVA: 0xDD92EC
	IXmlNode CreateTextNode(string text) { }

	// RVA: 0xDD9388
	IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xDD9424
	IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xDD94C0
	IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xDD955C
	IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xDD9664
	IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xDD9770
	IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xDD9814
	IXmlElement CreateElement(string elementName) { }

	// RVA: 0xDD98FC
	IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xDD99A8
	IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xDD9A80
	IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xDD9B44
	IXmlElement get_DocumentElement() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlElementWrapper 
{
	// Fields
	private readonly XmlElement _element; // 0x28

	// Methods

	// RVA: 0xDD98B8
	void .ctor(XmlElement element) { }

	// RVA: 0xDD9C00
	void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xDD9CF4
	string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xDD9D1C
	bool get_IsEmpty() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDeclarationWrapper 
{
	// Fields
	private readonly XmlDeclaration _declaration; // 0x28

	// Methods

	// RVA: 0xDD9620
	void .ctor(XmlDeclaration declaration) { }

	// RVA: 0xDD9D3C
	string get_Version() { }

	// RVA: 0xDD9D5C
	string get_Encoding() { }

	// RVA: 0xDD9D7C
	string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDocumentTypeWrapper 
{
	// Fields
	private readonly XmlDocumentType _documentType; // 0x28

	// Methods

	// RVA: 0xDD972C
	void .ctor(XmlDocumentType documentType) { }

	// RVA: 0xDD9D9C
	string get_Name() { }

	// RVA: 0xDD9DC0
	string get_System() { }

	// RVA: 0xDD9DE0
	string get_Public() { }

	// RVA: 0xDD9E00
	string get_InternalSubset() { }

	// RVA: 0xDD9E20
	string get_LocalName() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlNodeWrapper 
{
	// Fields
	private readonly XmlNode _node; // 0x10
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes; // 0x18
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes; // 0x20

	// Methods

	// RVA: 0xDD921C
	void .ctor(XmlNode node) { }

	// RVA: 0xDD9E64
	object get_WrappedNode() { }

	// RVA: 0xDD9E6C
	XmlNodeType get_NodeType() { }

	// RVA: 0xDD9E90
	string get_LocalName() { }

	// RVA: 0xDD9EB8
	System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xDDA294
	IXmlNode WrapNode(XmlNode node) { }

	// RVA: 0xDDA42C
	System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xDDA87C
	bool get_HasAttributes() { }

	// RVA: 0xDDA930
	IXmlNode get_ParentNode() { }

	// RVA: 0xDDA9E8
	string get_Value() { }

	// RVA: 0xDD9A5C
	void set_Value(string value) { }

	// RVA: 0xDDAA0C
	IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xDDAAD8
	string get_NamespaceUri() { }

}

// Namespace: Newtonsoft.Json.Converters
internal interface IXmlDocument 
{
	// Methods

	// RVA: 0x2FE36BC
	IXmlNode CreateComment(string text) { }

	// RVA: 0x2FE36BC
	IXmlNode CreateTextNode(string text) { }

	// RVA: 0x2FE36BC
	IXmlNode CreateCDataSection(string data) { }

	// RVA: 0x2FE36BC
	IXmlNode CreateWhitespace(string text) { }

	// RVA: 0x2FE36BC
	IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0x2FE3810
	IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x2FE3884
	IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x2FE37A0
	IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x2FE36BC
	IXmlElement CreateElement(string elementName) { }

	// RVA: 0x2FE37A0
	IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0x2FE37A0
	IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0x2FE3810
	IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0x2FE360C
	IXmlElement get_DocumentElement() { }

}

// Namespace: Newtonsoft.Json.Converters
internal interface IXmlDeclaration 
{
	// Methods

	// RVA: 0x2FE360C
	string get_Version() { }

	// RVA: 0x2FE360C
	string get_Encoding() { }

	// RVA: 0x2FE360C
	string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal interface IXmlDocumentType 
{
	// Methods

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x2FE360C
	string get_System() { }

	// RVA: 0x2FE360C
	string get_Public() { }

	// RVA: 0x2FE360C
	string get_InternalSubset() { }

}

// Namespace: Newtonsoft.Json.Converters
internal interface IXmlElement 
{
	// Methods

	// RVA: 0x2FE4574
	void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0x2FE36BC
	string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0x2FE3054
	bool get_IsEmpty() { }

}

// Namespace: Newtonsoft.Json.Converters
internal interface IXmlNode 
{
	// Methods

	// RVA: 0x2FE32D4
	XmlNodeType get_NodeType() { }

	// RVA: 0x2FE360C
	string get_LocalName() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0x2FE360C
	IXmlNode get_ParentNode() { }

	// RVA: 0x2FE360C
	string get_Value() { }

	// RVA: 0x2FE36BC
	IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x2FE360C
	string get_NamespaceUri() { }

	// RVA: 0x2FE360C
	object get_WrappedNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDeclarationWrapper 
{
	// Fields
	private readonly XDeclaration <Declaration>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDDAB00
	XDeclaration get_Declaration() { }

	// RVA: 0xDDAB08
	void .ctor(XDeclaration declaration) { }

	// RVA: 0xDDAB80
	XmlNodeType get_NodeType() { }

	// RVA: 0xDDAB88
	string get_Version() { }

	// RVA: 0xDDABA8
	string get_Encoding() { }

	// RVA: 0xDDABC8
	string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDocumentTypeWrapper 
{
	// Fields
	private readonly XDocumentType _documentType; // 0x18

	// Methods

	// RVA: 0xDDABE8
	void .ctor(XDocumentType documentType) { }

	// RVA: 0xDDAC2C
	string get_Name() { }

	// RVA: 0xDDAC4C
	string get_System() { }

	// RVA: 0xDDAC6C
	string get_Public() { }

	// RVA: 0xDDAC8C
	string get_InternalSubset() { }

	// RVA: 0xDDACAC
	string get_LocalName() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDocumentWrapper 
{
	// Methods

	// RVA: 0xDDACF0
	XDocument get_Document() { }

	// RVA: 0xDDAD6C
	void .ctor(XDocument document) { }

	// RVA: 0xDDADD4
	System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xDDB458
	bool get_HasChildNodes() { }

	// RVA: 0xDDB5EC
	IXmlNode CreateComment(string text) { }

	// RVA: 0xDDB68C
	IXmlNode CreateTextNode(string text) { }

	// RVA: 0xDDB72C
	IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xDDB7CC
	IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xDDB86C
	IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xDDB90C
	IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xDDB9D4
	IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xDDBAAC
	IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xDDBB90
	IXmlElement CreateElement(string elementName) { }

	// RVA: 0xDDBC74
	IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xDDBD3C
	IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xDDBE30
	IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xDDBF00
	IXmlElement get_DocumentElement() { }

	// RVA: 0xDDC070
	IXmlNode AppendChild(IXmlNode newChild) { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XTextWrapper 
{
	// Methods

	// RVA: 0xDDC2E8
	XText get_Text() { }

	// RVA: 0xDDC364
	void .ctor(XText text) { }

	// RVA: 0xDDC398
	string get_Value() { }

	// RVA: 0xDDC41C
	IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XCommentWrapper 
{
	// Methods

	// RVA: 0xDDC830
	XComment get_Text() { }

	// RVA: 0xDDC8AC
	void .ctor(XComment text) { }

	// RVA: 0xDDC8E0
	string get_Value() { }

	// RVA: 0xDDC964
	IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XProcessingInstructionWrapper 
{
	// Methods

	// RVA: 0xDDCA60
	XProcessingInstruction get_ProcessingInstruction() { }

	// RVA: 0xDDBB5C
	void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0xDDCADC
	string get_LocalName() { }

	// RVA: 0xDDCB60
	string get_Value() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XContainerWrapper 
{
	// Fields
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes; // 0x18

	// Methods

	// RVA: 0xDDCBE4
	XContainer get_Container() { }

	// RVA: 0xDDADA0
	void .ctor(XContainer container) { }

	// RVA: 0xDDB050
	System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xDDB55C
	bool get_HasChildNodes() { }

	// RVA: 0xDDCC60
	IXmlNode get_ParentNode() { }

	// RVA: 0xDDC518
	IXmlNode WrapNode(XObject node) { }

	// RVA: 0xDDC184
	IXmlNode AppendChild(IXmlNode newChild) { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XObjectWrapper 
{
	// Fields
	private readonly XObject _xmlObject; // 0x10

	// Methods

	// RVA: 0xDDAB4C
	void .ctor(XObject xmlObject) { }

	// RVA: 0xDDCD5C
	object get_WrappedNode() { }

	// RVA: 0xDDCD64
	XmlNodeType get_NodeType() { }

	// RVA: 0xDDCD7C
	string get_LocalName() { }

	// RVA: 0xDDCD84
	System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xDDCE00
	System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xDDCE7C
	IXmlNode get_ParentNode() { }

	// RVA: 0xDDCE84
	string get_Value() { }

	// RVA: 0xDDCE8C
	IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xDDCECC
	string get_NamespaceUri() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XAttributeWrapper 
{
	// Methods

	// RVA: 0xDDCED4
	XAttribute get_Attribute() { }

	// RVA: 0xDDBDFC
	void .ctor(XAttribute attribute) { }

	// RVA: 0xDDCF50
	string get_Value() { }

	// RVA: 0xDDCFD4
	string get_LocalName() { }

	// RVA: 0xDDD060
	string get_NamespaceUri() { }

	// RVA: 0xDDD0EC
	IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XElementWrapper 
{
	// Fields
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes; // 0x20

	// Methods

	// RVA: 0xDDD1E8
	XElement get_Element() { }

	// RVA: 0xDDBC40
	void .ctor(XElement element) { }

	// RVA: 0xDDD264
	void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xDDD36C
	System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xDDD90C
	bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	// RVA: 0xDDDEFC
	IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xDDDF34
	string get_Value() { }

	// RVA: 0xDDDFB8
	string get_LocalName() { }

	// RVA: 0xDDE044
	string get_NamespaceUri() { }

	// RVA: 0xDDDE48
	string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xDDE0D0
	bool get_IsEmpty() { }

}

// Namespace: Newtonsoft.Json.Converters
public class XmlNodeConverter 
{
	// Fields
	internal static readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> EmptyChildNodes; // 0x0
	private const string TextName = 5736093328;
	private const string CommentName = 5736093280;
	private const string CDataName = 5736246848;
	private const string WhitespaceName = 5736246784;
	private const string SignificantWhitespaceName = 5714615664;
	private const string DeclarationName = 5736093232;
	private const string JsonNamespaceUri = 5735918656;
	private string <DeserializeRootElementName>k__BackingField; // 0x10
	private bool <WriteArrayAttribute>k__BackingField; // 0x18
	private bool <OmitRootObject>k__BackingField; // 0x19
	private bool <EncodeSpecialCharacters>k__BackingField; // 0x1A

	// Methods

	// RVA: 0xDDE154
	string get_DeserializeRootElementName() { }

	// RVA: 0xDDE15C
	void set_DeserializeRootElementName(string value) { }

	// RVA: 0xDDE164
	bool get_WriteArrayAttribute() { }

	// RVA: 0xDDE16C
	void set_WriteArrayAttribute(bool value) { }

	// RVA: 0xDDE174
	bool get_OmitRootObject() { }

	// RVA: 0xDDE17C
	void set_OmitRootObject(bool value) { }

	// RVA: 0xDDE184
	bool get_EncodeSpecialCharacters() { }

	// RVA: 0xDDE18C
	void set_EncodeSpecialCharacters(bool value) { }

	// RVA: 0xDDE194
	void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDDE2E0
	IXmlNode WrapXml(object value) { }

	// RVA: 0xDDE3FC
	void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xDE0454
	string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xDE080C
	string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xDE0CE4
	bool IsArray(IXmlNode node) { }

	// RVA: 0xDE10F0
	void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xDE1D30
	void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, string elementNames) { }

	// RVA: 0xDE1EB4
	void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	// RVA: 0xDDEBC4
	void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xDE1F88
	bool AllSameName(IXmlNode node) { }

	// RVA: 0xDE2634
	object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDE3B38
	void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0xDE2F28
	void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0xDE5F3C
	void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, System.Collections.Generic.Dictionary<System.String,System.String> attributeNameValues) { }

	// RVA: 0xDE5BB0
	void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0xDE4124
	string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0xDE5090
	void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0xDE6AA4
	void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0xDE54C4
	bool ShouldReadInto(JsonReader reader) { }

	// RVA: 0xDE5508
	System.Collections.Generic.Dictionary<System.String,System.String> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0xDE4808
	void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0xDE4CB8
	void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0xDE688C
	IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0xDE32CC
	void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0xDE6DF8
	bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	// RVA: 0xDE22C4
	bool ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c) { }

	// RVA: 0xDE6EEC
	bool CanConvert(Type valueType) { }

	// RVA: 0xDE6FA4
	bool IsXObject(Type valueType) { }

	// RVA: 0xDE705C
	bool IsXmlNode(Type valueType) { }

	// RVA: 0xDE7114
	void .ctor() { }

	// RVA: 0xDE711C
	void .cctor() { }

}

// Namespace: Newtonsoft.Json.Bson
public class BsonObjectId 
{
	// Fields
	private readonly Byte[] <Value>k__BackingField; // 0x10

	// Methods

	// RVA: 0xDE71B8
	Byte[] get_Value() { }

	// RVA: 0xDE71C0
	void .ctor(Byte[] value) { }

}

// Namespace: Newtonsoft.Json.Bson
internal abstract class BsonToken 
{
	// Fields
	private BsonToken <Parent>k__BackingField; // 0x10

	// Methods

	// RVA: -1
	BsonType get_Type() { }

	// RVA: 0xDE72A8
	void set_Parent(BsonToken value) { }

	// RVA: 0xDE72B0
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonObject 
{
	// Fields
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children; // 0x18

	// Methods

	// RVA: 0xDE72B8
	void Add(string name, BsonToken token) { }

	// RVA: 0xDE7424
	BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonArray 
{
	// Fields
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children; // 0x18

	// Methods

	// RVA: 0xDE742C
	void Add(BsonToken token) { }

	// RVA: 0xDE74A4
	BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonValue 
{
	// Fields
	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	// Methods

	// RVA: 0xDE74AC
	void .ctor(object value, BsonType type) { }

	// RVA: 0xDE74F4
	BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonString 
{
	// Fields
	private readonly bool <IncludeLength>k__BackingField; // 0x21

	// Methods

	// RVA: 0xDE73D4
	void .ctor(object value, bool includeLength) { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonRegex 
{
	// Fields
	private BsonString <Pattern>k__BackingField; // 0x18
	private BsonString <Options>k__BackingField; // 0x20

	// Methods

	// RVA: 0xDE74FC
	void set_Pattern(BsonString value) { }

	// RVA: 0xDE7504
	void set_Options(BsonString value) { }

	// RVA: 0xDE750C
	void .ctor(string pattern, string options) { }

	// RVA: 0xDE75E4
	BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonProperty 
{
	// Fields
	private BsonString <Name>k__BackingField; // 0x10
	private BsonToken <Value>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDE75EC
	void set_Name(BsonString value) { }

	// RVA: 0xDE75F4
	void set_Value(BsonToken value) { }

	// RVA: 0xDE73CC
	void .ctor() { }

}

// Namespace: Newtonsoft.Json.Bson
internal enum BsonType 
{
	// Fields
	public SByte value__; // 0x10
	public const BsonType Number = 1;
	public const BsonType String = 2;
	public const BsonType Object = 3;
	public const BsonType Array = 4;
	public const BsonType Binary = 5;
	public const BsonType Undefined = 6;
	public const BsonType Oid = 7;
	public const BsonType Boolean = 8;
	public const BsonType Date = 9;
	public const BsonType Null = 10;
	public const BsonType Regex = 11;
	public const BsonType Reference = 12;
	public const BsonType Code = 13;
	public const BsonType Symbol = 14;
	public const BsonType CodeWScope = 15;
	public const BsonType Integer = 16;
	public const BsonType TimeStamp = 17;
	public const BsonType Long = 18;
	public const BsonType MinKey = 255;
	public const BsonType MaxKey = 127;
}

// Namespace: Newtonsoft.Json.Bson
public class BsonWriter 
{
	// Fields
	private BsonToken _root; // 0x60
	private BsonToken _parent; // 0x68
	private string _propertyName; // 0x70

	// Methods

	// RVA: 0xDE75FC
	void AddValue(object value, BsonType type) { }

	// RVA: 0xDE7688
	void AddToken(BsonToken token) { }

	// RVA: 0xDE78D8
	void WriteObjectId(Byte[] value) { }

	// RVA: 0xDD72AC
	void WriteRegex(string pattern, string options) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=10 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=16 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=20 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=24 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=28 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=36 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=40 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=44 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=52 
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails> 
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=44 0698228BF899CAEAB9A53E5E6C7099E846C44F56432050D234DDF03AD772F139; // 0x0
	internal static readonly __StaticArrayInitTypeSize=10 19AE20A57B073E3E8DD45C6F6A4E9AB1076EA3EBFFF28E4AEB58B411472CF994; // 0x2C
	internal static readonly __StaticArrayInitTypeSize=40 223D6CA32241C349E421A0164F2341E20CC5B65D5A04AA021CFF71D623895570; // 0x36
	internal static readonly __StaticArrayInitTypeSize=20 33350F5DA385CE1B8749AEC68BA060CD54EE981968522B5EDF62178537A1FEEE; // 0x5E
	internal static readonly __StaticArrayInitTypeSize=40 38809B9974198671140931F729415F3FD75DF68A6398E3486AE3B58554329A63; // 0x72
	internal static readonly __StaticArrayInitTypeSize=28 499E4F5C84E20C7347E10100E0EC90C1945EA21C7C80809E4F7F474179B39DF6; // 0x9A
	internal static readonly __StaticArrayInitTypeSize=16 4EDE3546F1189E450DF4D4A2739BE90BEB3B1708B3B9F406B02E0773A92A10FF; // 0xB6
	internal static readonly __StaticArrayInitTypeSize=52 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA; // 0xC6
	internal static readonly __StaticArrayInitTypeSize=28 5ADB7CA81690556AB2A3201A849839FA3562604BB469382C7D6D78AB426283E2; // 0xFA
	internal static readonly __StaticArrayInitTypeSize=24 5DDF815AC046E7D4603FA586D1BDE42118AD4FE9875D64F716BC7D2740EE52C9; // 0x116
	internal static readonly __StaticArrayInitTypeSize=16 605A3F93AE7A97E00C156F977E942027EA532E263A5B440A4219984F803FDD04; // 0x12E
	internal static readonly __StaticArrayInitTypeSize=36 7367A65185E4F747AA29364AB199D01646A010A62129A6BA2E35E929D7294D62; // 0x13E
	internal static readonly __StaticArrayInitTypeSize=40 7439A4C9E30AC42BCC55AD1A2B617E29E7129B6DDAC79C886944B17819262CC1; // 0x162
	internal static readonly __StaticArrayInitTypeSize=40 990F3F1286CC3928725497B2745CFF7BC7C9803B4EB8271611540BA6BF6654B5; // 0x18A
	internal static readonly __StaticArrayInitTypeSize=16 A8636D08B42D058EFC34703DD37B6468FCE56138DF242B862C3F1CA138CB3B89; // 0x1B2
	internal static readonly __StaticArrayInitTypeSize=20 B1D1BCD1D06B4A563944BE3C67D51F63DF23702E5BE760D7897C6AD1F51C6122; // 0x1C2
	internal static readonly __StaticArrayInitTypeSize=20 CAA07D7573596B3356BD202533F0EAFDD05309981F270193A99E300D57587326; // 0x1D6
	internal static readonly __StaticArrayInitTypeSize=40 D4B3B8EBA0589FC38724A0D318B46104B07BC528744109ED69ED71604B7EEC1A; // 0x1EA
	internal static readonly __StaticArrayInitTypeSize=40 F6EDC1733B068F457C63E03BB041B9AB6BFAD5CD7673D3E0841968D3FBCB12C7; // 0x212
	internal static readonly __StaticArrayInitTypeSize=52 FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315; // 0x23A
	internal static readonly __StaticArrayInitTypeSize=40 FCA56C548368F7065472C8C8EE4D63921B4F16BB51181EC202A0C252D5209E6A; // 0x26E
}


