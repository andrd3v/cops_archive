// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0xD9AA10
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class IsReadOnlyAttribute
{
	// Methods

	// RVA: 0xD9AA18
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xD9AA20
	public void .ctor(Byte ) { }

	// RVA: 0xD9AAAC
	public void .ctor(Byte[] ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0xD9AAE0
	public void .ctor(Byte ) { }

}

// Namespace: System.Diagnostics.CodeAnalysis
internal sealed class NotNullAttribute
{
	// Methods

	// RVA: 0xD9AB0C
	public void .ctor() { }

}

// Namespace: System.Diagnostics.CodeAnalysis
internal sealed class NotNullWhenAttribute
{
	// Fields
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD9AB14
	public void .ctor(bool returnValue) { }

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

	// RVA: 0xD9B250
	internal void .ctor(string value, int hashCode, Entry next) { }

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

	// RVA: 0xD9AB40
	private static void .cctor() { }

	// RVA: 0xD9AB94
	public void .ctor() { }

	// RVA: 0xD9AC18
	public override string Get(Char[] key, int start, int length) { }

	// RVA: 0xD9AF44
	public string Add(string key) { }

	// RVA: 0xD9B118
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0xD9B2A8
	private void Grow() { }

	// RVA: 0xD9AE68
	private static bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

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
	public abstract T[] Rent(int minimumLength) { }

	// RVA: -1
	public abstract void Return(T[] array) { }

}

// Namespace: Newtonsoft.Json
public interface IJsonLineInfo
{
	// Methods

	// RVA: -1
	public abstract bool HasLineInfo() { }

	// RVA: -1
	public abstract int get_LineNumber() { }

	// RVA: -1
	public abstract int get_LinePosition() { }

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

	// RVA: 0xD9B434
	public Type get_ItemConverterType() { }

	// RVA: 0xD9B43C
	public object[] get_ItemConverterParameters() { }

	// RVA: 0xD9B444
	public Type get_NamingStrategyType() { }

	// RVA: 0xD9B44C
	public object[] get_NamingStrategyParameters() { }

	// RVA: 0xD9B454
	internal NamingStrategy get_NamingStrategyInstance() { }

	// RVA: 0xD9B45C
	internal void set_NamingStrategyInstance(NamingStrategy value) { }

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

	// RVA: 0xD9B464
	public static System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings() { }

	// RVA: 0xD9B4E0
	public static string ToString(bool value) { }

	// RVA: 0xD9B57C
	public static string ToString(Char value) { }

	// RVA: 0xD9B744
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD9B9BC
	private static string EnsureFloatFormat(Double value, string text, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD9BAE4
	internal static string ToString(Double value, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD9B8F4
	private static string EnsureDecimalPlace(Double value, string text) { }

	// RVA: 0xD9BC8C
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0xD9BD04
	public static string ToString(Decimal value) { }

	// RVA: 0xD9B624
	public static string ToString(string value) { }

	// RVA: 0xD9BE94
	public static string ToString(string value, Char delimiter) { }

	// RVA: 0xD9BF00
	public static string ToString(string value, Char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xD9BFE4
	public static string SerializeObject(object value) { }

	// RVA: 0xD9C0B4
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xD9C17C
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	// RVA: 0x318DB98
	public static T DeserializeObject(string value) { }

	// RVA: 0x318DB98
	public static T DeserializeObject(string value, JsonSerializerSettings settings) { }

	// RVA: 0xD9C674
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xD9CAF4
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json
public abstract class JsonConverter
{
	// Methods

	// RVA: -1
	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: -1
	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: -1
	public abstract bool CanConvert(Type objectType) { }

	// RVA: 0xD9CC68
	public virtual bool get_CanRead() { }

	// RVA: 0xD9CC70
	public virtual bool get_CanWrite() { }

	// RVA: 0xD9CC78
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonConverterAttribute
{
	// Fields
	private readonly Type _converterType; // 0x10
	private readonly object[] <ConverterParameters>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD9CC80
	public Type get_ConverterType() { }

	// RVA: 0xD9CC88
	public object[] get_ConverterParameters() { }

}

// Namespace: Newtonsoft.Json
public class JsonConverterCollection
{
	// Methods

	// RVA: 0xD9CC90
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonDictionaryAttribute
{}

// Namespace: Newtonsoft.Json
[Serializable]
public class JsonException
{
	// Methods

	// RVA: 0xD9CCE4
	public void .ctor() { }

	// RVA: 0xD9CD6C
	public void .ctor(string message) { }

	// RVA: 0xD9CDD8
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xD9CE54
	public void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: Newtonsoft.Json
public class JsonExtensionDataAttribute
{
	// Fields
	private bool <WriteData>k__BackingField; // 0x10
	private bool <ReadData>k__BackingField; // 0x11

	// Methods

	// RVA: 0xD9CED8
	public bool get_WriteData() { }

	// RVA: 0xD9CEE0
	public bool get_ReadData() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonIgnoreAttribute
{
	// Methods

	// RVA: 0xD9CEE8
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json
public abstract class JsonNameTable
{
	// Methods

	// RVA: -1
	public abstract string Get(Char[] key, int start, int length) { }

	// RVA: 0xD9AC10
	protected void .ctor() { }

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

	// RVA: 0xD9CEF0
	public MemberSerialization get_MemberSerialization() { }

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

	// RVA: 0xD9CEF8
	public void .ctor(JsonContainerType type) { }

	// RVA: 0xD9CF90
	internal int CalculateLength() { }

	// RVA: 0xD9D038
	internal void WriteTo(StringBuilder sb, StringWriter writer, Char[] buffer) { }

	// RVA: 0xD9CF80
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0xD9D284
	internal static string BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition) { }

	// RVA: 0xD9D76C
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0xD9DAA4
	private static void .cctor() { }

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

	// RVA: 0xD9DB48
	public Type get_ItemConverterType() { }

	// RVA: 0xD9DB50
	public object[] get_ItemConverterParameters() { }

	// RVA: 0xD9DB58
	public Type get_NamingStrategyType() { }

	// RVA: 0xD9DB60
	public object[] get_NamingStrategyParameters() { }

	// RVA: 0xD9DB68
	public string get_PropertyName() { }

	// RVA: 0xD9DB70
	public void set_PropertyName(string value) { }

	// RVA: 0xD9DB78
	public void .ctor() { }

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

	// RVA: 0xD9DB80
	protected State get_CurrentState() { }

	// RVA: 0xD9DB88
	public bool get_CloseInput() { }

	// RVA: 0xD9DB90
	public void set_CloseInput(bool value) { }

	// RVA: 0xD9DB98
	public bool get_SupportMultipleContent() { }

	// RVA: 0xD9DBA0
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0xD9DBA8
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xD9DBB0
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xD9DC1C
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0xD9DC24
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0xD9DC90
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0xD9DC98
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0xD9DD04
	public string get_DateFormatString() { }

	// RVA: 0xD9DD0C
	public void set_DateFormatString(string value) { }

	// RVA: 0xD9DD14
	public System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xD9DD1C
	public void set_MaxDepth(System.Nullable<System.Int32> value) { }

	// RVA: 0xD9DEB0
	public virtual JsonToken get_TokenType() { }

	// RVA: 0xD9DEB8
	public virtual object get_Value() { }

	// RVA: 0xD9DEC0
	public virtual Type get_ValueType() { }

	// RVA: 0xD9DED4
	public virtual int get_Depth() { }

	// RVA: 0xD9DF50
	public virtual string get_Path() { }

	// RVA: 0xD9E080
	public CultureInfo get_Culture() { }

	// RVA: 0xD9E0FC
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xD9E104
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0xD9E1C4
	protected void .ctor() { }

	// RVA: 0xD9E268
	private void Push(JsonContainerType value) { }

	// RVA: 0xD9E720
	private JsonContainerType Pop() { }

	// RVA: 0xD9E948
	private JsonContainerType Peek() { }

	// RVA: -1
	public abstract bool Read() { }

	// RVA: 0xD9E950
	public virtual System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xD9F0C4
	internal System.Nullable<System.Int32> ReadInt32String(string s) { }

	// RVA: 0xD9F344
	public virtual string ReadAsString() { }

	// RVA: 0xD9F710
	public virtual Byte[] ReadAsBytes() { }

	// RVA: 0xD9FE64
	internal Byte[] ReadArrayIntoByteArray() { }

	// RVA: 0xD9FFE0
	private bool ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<System.Byte> buffer) { }

	// RVA: 0xDA01CC
	public virtual System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xDA053C
	internal System.Nullable<System.Double> ReadDoubleString(string s) { }

	// RVA: 0xDA07BC
	public virtual System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xDA0B84
	internal System.Nullable<System.Boolean> ReadBooleanString(string s) { }

	// RVA: 0xDA0DA4
	public virtual System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xDA1264
	internal System.Nullable<System.Decimal> ReadDecimalString(string s) { }

	// RVA: 0xDA1580
	public virtual System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xDA18C0
	internal System.Nullable<System.DateTime> ReadDateTimeString(string s) { }

	// RVA: 0xDA1C6C
	public virtual System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xDA1FA4
	internal System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0xD9FE14
	internal void ReaderReadAndAssert() { }

	// RVA: 0xDA231C
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0xD9FBF4
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0xDA23DC
	public void Skip() { }

	// RVA: 0xD9FFD4
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0xDA2478
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0xD9EEC4
	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0xDA25A0
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0xD9E684
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0xDA2480
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0xDA26C4
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0xDA25E8
	private void SetFinished() { }

	// RVA: 0xDA2614
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0xDA27E4
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDA2878
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xDA289C
	public virtual void Close() { }

	// RVA: 0xDA28B4
	internal void ReadAndAssert() { }

	// RVA: 0xDA2998
	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	// RVA: 0xDA29F0
	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	// RVA: 0xDA2D18
	internal bool ReadAndMoveToContent() { }

	// RVA: 0xDA2D84
	internal bool MoveToContent() { }

	// RVA: 0xD9EDA8
	private JsonToken GetContentToken() { }

}

// Namespace: Newtonsoft.Json
[Serializable]
public class JsonReaderException
{
	// Fields
	private readonly int <LineNumber>k__BackingField; // 0x8C
	private readonly int <LinePosition>k__BackingField; // 0x90
	private readonly string <Path>k__BackingField; // 0x98

	// Methods

	// RVA: 0xDA2DE0
	public void .ctor() { }

	// RVA: 0xDA2E68
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xDA2EEC
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0xD9E69C
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0xD9EE34
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xDA2F94
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonRequiredAttribute
{
	// Methods

	// RVA: 0xDA31F8
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json
[Serializable]
public class JsonSerializationException
{
	// Fields
	private readonly int <LineNumber>k__BackingField; // 0x8C
	private readonly int <LinePosition>k__BackingField; // 0x90
	private readonly string <Path>k__BackingField; // 0x98

	// Methods

	// RVA: 0xDA3200
	public void .ctor() { }

	// RVA: 0xDA3288
	public void .ctor(string message) { }

	// RVA: 0xDA32F4
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xDA3370
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xDA33F4
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0xDA2914
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0xDA349C
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xDA352C
	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

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

	// RVA: 0xDA3790
	public virtual void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDA3844
	public virtual void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDA38F8
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xDA3974
	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0xDA39F0
	public virtual ITraceWriter get_TraceWriter() { }

	// RVA: 0xDA39F8
	public virtual void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0xDA3A00
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xDA3A08
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xDA3A74
	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0xDA3AE0
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xDA3B4C
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xDA3BB8
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xDA3C24
	public virtual NullValueHandling get_NullValueHandling() { }

	// RVA: 0xDA3C2C
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xDA3C98
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0xDA3D04
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xDA3D70
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0xDA3DDC
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xDA3DE4
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xDA3E50
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0xDA3F10
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0xDA3F18
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xDA3FFC
	public virtual StreamingContext get_Context() { }

	// RVA: 0xDA4008
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0xDA4014
	public virtual Formatting get_Formatting() { }

	// RVA: 0xDA40EC
	public virtual System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xDA40F4
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0xDA41CC
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xD9C8D4
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0xDA4244
	public void .ctor() { }

	// RVA: 0xDA43B0
	public static JsonSerializer Create() { }

	// RVA: 0xDA4404
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0xDA55B4
	public static JsonSerializer CreateDefault() { }

	// RVA: 0xD9C144
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0xDA4474
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	// RVA: 0xDA60E0
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xDA60F0
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0x318DB98
	public T Deserialize(JsonReader reader) { }

	// RVA: 0xD9CAE4
	public object Deserialize(JsonReader reader, Type objectType) { }

	// RVA: 0xDA7484
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xDA6374
	internal void SetupReader(JsonReader reader, CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>& previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling>& previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling>& previousFloatParseHandling, System.Nullable<System.Int32>& previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xDA6F64
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<System.Int32> previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xD9C664
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xDA7710
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0xDA6ED0
	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	// RVA: 0xDA7724
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xDA8CC0
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0xDA8D48
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0xDA8D50
	internal static JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, Type objectType) { }

	// RVA: 0xDA8EEC
	internal void OnError(ErrorEventArgs e) { }

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

	// RVA: 0xDA5A64
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0xDA5B3C
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0xDA5C14
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xDA5CEC
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0xDA5DC4
	public DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0xDA8F10
	public System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters() { }

	// RVA: 0xDA598C
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0xDA5704
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0xDA57DC
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xDA58B4
	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0xDA5E9C
	public ConstructorHandling get_ConstructorHandling() { }

	// RVA: 0xDA8F18
	public IContractResolver get_ContractResolver() { }

	// RVA: 0xDA8F20
	public IEqualityComparer get_EqualityComparer() { }

	// RVA: 0xDA8F28
	public System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider() { }

	// RVA: 0xDA8F30
	public ITraceWriter get_TraceWriter() { }

	// RVA: 0xDA8F38
	public ISerializationBinder get_SerializationBinder() { }

	// RVA: 0xDA8F40
	public System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error() { }

	// RVA: 0xDA5F74
	public StreamingContext get_Context() { }

	// RVA: 0xDA8F48
	private static void .cctor() { }

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

	// RVA: 0xD9C954
	public void .ctor(TextReader reader) { }

	// RVA: 0xDA8FD8
	public JsonNameTable get_PropertyNameTable() { }

	// RVA: 0xDA8FE0
	public void set_PropertyNameTable(JsonNameTable value) { }

	// RVA: 0xDA8FE8
	private void EnsureBufferNotEmpty() { }

	// RVA: 0xDA904C
	private void SetNewLine(bool hasNextChar) { }

	// RVA: 0xDA90C0
	private void OnNewLine(int pos) { }

	// RVA: 0xDA90D0
	private void ParseString(Char quote, ReadType readType) { }

	// RVA: 0xDA98BC
	private void ParseReadString(Char quote, ReadType readType) { }

	// RVA: 0xDA9DD4
	private static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	// RVA: 0xDA9124
	private void ShiftBufferIfNeeded() { }

	// RVA: 0xDA9DE8
	private int ReadData(bool append) { }

	// RVA: 0xDA9E90
	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	// RVA: 0xDA9DF0
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0xDAA054
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0xDAA0EC
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0xDAA16C
	public override bool Read() { }

	// RVA: 0xDAB5D0
	public override System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xDABBDC
	public override System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xDAC310
	public override string ReadAsString() { }

	// RVA: 0xDAC378
	public override Byte[] ReadAsBytes() { }

	// RVA: 0xDABC9C
	private object ReadStringValue(ReadType readType) { }

	// RVA: 0xDACF48
	private object FinishReadQuotedStringValue(ReadType readType) { }

	// RVA: 0xDACBA0
	private JsonReaderException CreateUnexpectedCharacterException(Char c) { }

	// RVA: 0xDAD5A4
	public override System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xDACB30
	private void ProcessValueComma() { }

	// RVA: 0xDAB690
	private object ReadNumberValue(ReadType readType) { }

	// RVA: 0xDADC48
	private object FinishReadQuotedNumber(ReadType readType) { }

	// RVA: 0xDADDD4
	public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xDADEA4
	public override System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xDADF74
	public override System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xDACA2C
	private void HandleNull() { }

	// RVA: 0xDACDAC
	private void ReadFinished() { }

	// RVA: 0xDAC9BC
	private bool ReadNullChar() { }

	// RVA: 0xDAA434
	private void EnsureBuffer() { }

	// RVA: 0xDA9200
	private void ReadStringIntoBuffer(Char quote) { }

	// RVA: 0xDAE264
	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	// RVA: 0xDAE210
	private void WriteCharToBuffer(Char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0xDAE34C
	private Char ConvertUnicode(bool enoughChars) { }

	// RVA: 0xDAE16C
	private Char ParseUnicode() { }

	// RVA: 0xDAE4AC
	private void ReadNumberIntoBuffer() { }

	// RVA: 0xDAE53C
	private bool ReadNumberCharIntoBuffer(Char currentChar, int charPos) { }

	// RVA: 0xDAE6D4
	private void ClearRecentString() { }

	// RVA: 0xDAAD54
	private bool ParsePostValue(bool ignoreComments) { }

	// RVA: 0xDAAB68
	private bool ParseObject() { }

	// RVA: 0xDAE6E0
	private bool ParseProperty() { }

	// RVA: 0xDAEA08
	private bool ValidIdentifierChar(Char value) { }

	// RVA: 0xDAEA80
	private void ParseUnquotedProperty() { }

	// RVA: 0xDAEB74
	private bool ReadUnquotedPropertyReportIfDone(Char currentChar, int initialPosition) { }

	// RVA: 0xDAA4A4
	private bool ParseValue() { }

	// RVA: 0xDACD90
	private void ProcessLineFeed() { }

	// RVA: 0xDACCCC
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0xDAB0B4
	private void EatWhitespace() { }

	// RVA: 0xDAF078
	private void ParseConstructor() { }

	// RVA: 0xDAD22C
	private void ParseNumber(ReadType readType) { }

	// RVA: 0xDAF4F4
	private void ParseReadNumber(ReadType readType, Char firstChar, int initialPosition) { }

	// RVA: 0xDB082C
	private JsonReaderException ThrowReaderError(string message, Exception ex) { }

	// RVA: 0xDB0928
	private static object BigIntegerParse(string number, CultureInfo culture) { }

	// RVA: 0xDAB1D0
	private void ParseComment(bool setToken) { }

	// RVA: 0xDB09B0
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0xDB0A28
	private bool MatchValue(string value) { }

	// RVA: 0xDB0AE8
	private bool MatchValue(bool enoughChars, string value) { }

	// RVA: 0xDAD300
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0xDB0BC8
	private bool IsSeparator(Char c) { }

	// RVA: 0xDAED78
	private void ParseTrue() { }

	// RVA: 0xDAE034
	private void ParseNull() { }

	// RVA: 0xDAF3C0
	private void ParseUndefined() { }

	// RVA: 0xDAEEF8
	private void ParseFalse() { }

	// RVA: 0xDAD1AC
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0xDB0DA0
	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	// RVA: 0xDAD4A4
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0xDB0FFC
	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	// RVA: 0xDAD524
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0xDB1258
	private object ParseNumberNaN(ReadType readType, bool matched) { }

	// RVA: 0xDB14B4
	public override void Close() { }

	// RVA: 0xDB1538
	public bool HasLineInfo() { }

	// RVA: 0xDB1540
	public int get_LineNumber() { }

	// RVA: 0xDB159C
	public int get_LinePosition() { }

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

	// RVA: 0xDB15A8
	private Base64Encoder get_Base64Encoder() { }

	// RVA: 0xDB164C
	public Char get_QuoteChar() { }

	// RVA: 0xD9C428
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0xDB170C
	public override void Close() { }

	// RVA: 0xDB187C
	private void CloseBufferAndWriter() { }

	// RVA: 0xDB18E4
	public override void WriteStartObject() { }

	// RVA: 0xDB198C
	public override void WriteStartArray() { }

	// RVA: 0xDB19F0
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xDB1AC0
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xDB1BE0
	public override void WritePropertyName(string name) { }

	// RVA: 0xDB1D58
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xDB1E34
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0xDB168C
	private void UpdateCharEscapeFlags() { }

	// RVA: 0xDB1EB4
	protected override void WriteIndent() { }

	// RVA: 0xDB207C
	private int SetIndentChars() { }

	// RVA: 0xDB2190
	protected override void WriteValueDelimiter() { }

	// RVA: 0xDB21BC
	protected override void WriteIndentSpace() { }

	// RVA: 0xDB21E8
	private void WriteValueInternal(string value, JsonToken token) { }

	// RVA: 0xDB2210
	public override void WriteValue(object value) { }

	// RVA: 0xDB24A8
	public override void WriteNull() { }

	// RVA: 0xDB2540
	public override void WriteUndefined() { }

	// RVA: 0xDB25D8
	public override void WriteRaw(string json) { }

	// RVA: 0xDB2604
	public override void WriteValue(string value) { }

	// RVA: 0xDB1C6C
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0xDB2718
	public override void WriteValue(int value) { }

	// RVA: 0xDB2808
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xDB28F8
	public override void WriteValue(Int64 value) { }

	// RVA: 0xDB2940
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xDB2A60
	public override void WriteValue(float value) { }

	// RVA: 0xDB2B20
	public override void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xDB2CFC
	public override void WriteValue(Double value) { }

	// RVA: 0xDB2DBC
	public override void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xDB2F98
	public override void WriteValue(bool value) { }

	// RVA: 0xDB30A4
	public override void WriteValue(Int16 value) { }

	// RVA: 0xDB30EC
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xDB3134
	public override void WriteValue(Char value) { }

	// RVA: 0xDB3268
	public override void WriteValue(Byte value) { }

	// RVA: 0xDB32B0
	public override void WriteValue(SByte value) { }

	// RVA: 0xDB32F8
	public override void WriteValue(Decimal value) { }

	// RVA: 0xDB33A4
	public override void WriteValue(DateTime value) { }

	// RVA: 0xDB35B4
	private int WriteValueToBuffer(DateTime value) { }

	// RVA: 0xDB36F8
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xDB388C
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xDB3A68
	private int WriteValueToBuffer(DateTimeOffset value) { }

	// RVA: 0xDB3C0C
	public override void WriteValue(Guid value) { }

	// RVA: 0xDB3D20
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xDB3E64
	public override void WriteValue(Uri value) { }

	// RVA: 0xDB3F58
	public override void WriteComment(string text) { }

	// RVA: 0xDB26C8
	private void EnsureWriteBuffer() { }

	// RVA: 0xDB2850
	private void WriteIntegerValue(Int64 value) { }

	// RVA: 0xDB29E4
	private void WriteIntegerValue(UInt64 value, bool negative) { }

	// RVA: 0xDB4024
	private int WriteNumberToBuffer(UInt64 value, bool negative) { }

	// RVA: 0xDB2760
	private void WriteIntegerValue(int value) { }

	// RVA: 0xDB4220
	private void WriteIntegerValue(UInt32 value, bool negative) { }

	// RVA: 0xDB4134
	private int WriteNumberToBuffer(UInt32 value, bool negative) { }

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

	// RVA: 0xDB429C
	internal static State[][] BuildStateArray() { }

	// RVA: 0xDB4488
	private static void .cctor() { }

	// RVA: 0xDB47B0
	public bool get_CloseOutput() { }

	// RVA: 0xDB47B8
	public void set_CloseOutput(bool value) { }

	// RVA: 0xDB47C0
	public bool get_AutoCompleteOnClose() { }

	// RVA: 0xDB47C8
	public void set_AutoCompleteOnClose(bool value) { }

	// RVA: 0xDB2028
	protected internal int get_Top() { }

	// RVA: 0xDB47D8
	public WriteState get_WriteState() { }

	// RVA: 0xDB488C
	internal string get_ContainerPath() { }

	// RVA: 0xDB493C
	public string get_Path() { }

	// RVA: 0xDB4A6C
	public Formatting get_Formatting() { }

	// RVA: 0xD9C5F8
	public void set_Formatting(Formatting value) { }

	// RVA: 0xDB4A74
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0xDA8A8C
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0xDB4A7C
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xDA8AF8
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xDB4A84
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0xDA8BD0
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0xDB4A8C
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0xDB4A90
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0xDA8B64
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0xDB4A98
	public string get_DateFormatString() { }

	// RVA: 0xDB4AA0
	public void set_DateFormatString(string value) { }

	// RVA: 0xDA8C44
	public CultureInfo get_Culture() { }

	// RVA: 0xDB4AA8
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xDB1654
	protected void .ctor() { }

	// RVA: 0xDB4AB0
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0xDB4AC8
	private void Push(JsonContainerType value) { }

	// RVA: 0xDB4C60
	private JsonContainerType Pop() { }

	// RVA: 0xDB47D0
	private JsonContainerType Peek() { }

	// RVA: 0xDB17EC
	public virtual void Close() { }

	// RVA: 0xDB4DE0
	public virtual void WriteStartObject() { }

	// RVA: 0xDB4E24
	public virtual void WriteEndObject() { }

	// RVA: 0xDB4E30
	public virtual void WriteStartArray() { }

	// RVA: 0xDB4E74
	public virtual void WriteEndArray() { }

	// RVA: 0xDB4E7C
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0xDB4EC0
	public virtual void WriteEndConstructor() { }

	// RVA: 0xDB4EC8
	public virtual void WritePropertyName(string name) { }

	// RVA: 0xDB4EF4
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0xDB4F04
	public virtual void WriteEnd() { }

	// RVA: 0xDB501C
	public void WriteToken(JsonReader reader) { }

	// RVA: 0xDB509C
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	// RVA: 0xDB5128
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0xDB5924
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0xDB5CFC
	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	// RVA: 0xDB5B9C
	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	// RVA: 0xDB5DC4
	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	// RVA: 0xDB5C08
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0xDB4F0C
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0xDB4D58
	private void AutoCompleteAll() { }

	// RVA: 0xDB5E2C
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0xDB5ECC
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0xDB5F98
	private int CalculateLevelsToComplete(JsonContainerType type) { }

	// RVA: 0xDB6104
	private void UpdateCurrentState() { }

	// RVA: 0xDB61BC
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0xDB61C0
	protected virtual void WriteIndent() { }

	// RVA: 0xDB61C4
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0xDB61C8
	protected virtual void WriteIndentSpace() { }

	// RVA: 0xDB61CC
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0xDB63FC
	public virtual void WriteNull() { }

	// RVA: 0xDB6418
	public virtual void WriteUndefined() { }

	// RVA: 0xDB6434
	public virtual void WriteRaw(string json) { }

	// RVA: 0xDB6438
	public virtual void WriteRawValue(string json) { }

	// RVA: 0xDB648C
	public virtual void WriteValue(string value) { }

	// RVA: 0xDB64A8
	public virtual void WriteValue(int value) { }

	// RVA: 0xDB64C4
	public virtual void WriteValue(UInt32 value) { }

	// RVA: 0xDB64E0
	public virtual void WriteValue(Int64 value) { }

	// RVA: 0xDB64FC
	public virtual void WriteValue(UInt64 value) { }

	// RVA: 0xDB6518
	public virtual void WriteValue(float value) { }

	// RVA: 0xDB6534
	public virtual void WriteValue(Double value) { }

	// RVA: 0xDB6550
	public virtual void WriteValue(bool value) { }

	// RVA: 0xDB656C
	public virtual void WriteValue(Int16 value) { }

	// RVA: 0xDB6588
	public virtual void WriteValue(UInt16 value) { }

	// RVA: 0xDB65A4
	public virtual void WriteValue(Char value) { }

	// RVA: 0xDB65C0
	public virtual void WriteValue(Byte value) { }

	// RVA: 0xDB65DC
	public virtual void WriteValue(SByte value) { }

	// RVA: 0xDB65F8
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0xDB6614
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0xDB6630
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0xDB664C
	public virtual void WriteValue(Guid value) { }

	// RVA: 0xDB6668
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0xDB6684
	public virtual void WriteValue(System.Nullable<System.Int32> value) { }

	// RVA: 0xDB67E0
	public virtual void WriteValue(System.Nullable<System.UInt32> value) { }

	// RVA: 0xDB693C
	public virtual void WriteValue(System.Nullable<System.Int64> value) { }

	// RVA: 0xDB6A98
	public virtual void WriteValue(System.Nullable<System.UInt64> value) { }

	// RVA: 0xDB6BF4
	public virtual void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xDB6D50
	public virtual void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xDB6EAC
	public virtual void WriteValue(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDB7008
	public virtual void WriteValue(System.Nullable<System.Int16> value) { }

	// RVA: 0xDB7164
	public virtual void WriteValue(System.Nullable<System.UInt16> value) { }

	// RVA: 0xDB72C0
	public virtual void WriteValue(System.Nullable<System.Char> value) { }

	// RVA: 0xDB741C
	public virtual void WriteValue(System.Nullable<System.Byte> value) { }

	// RVA: 0xDB7578
	public virtual void WriteValue(System.Nullable<System.SByte> value) { }

	// RVA: 0xDB76D4
	public virtual void WriteValue(System.Nullable<System.Decimal> value) { }

	// RVA: 0xDB786C
	public virtual void WriteValue(System.Nullable<System.DateTime> value) { }

	// RVA: 0xDB79C8
	public virtual void WriteValue(System.Nullable<System.DateTimeOffset> value) { }

	// RVA: 0xDB7B1C
	public virtual void WriteValue(System.Nullable<System.Guid> value) { }

	// RVA: 0xDB7C70
	public virtual void WriteValue(System.Nullable<System.TimeSpan> value) { }

	// RVA: 0xDB7DCC
	public virtual void WriteValue(Byte[] value) { }

	// RVA: 0xDB7DFC
	public virtual void WriteValue(Uri value) { }

	// RVA: 0xDB236C
	public virtual void WriteValue(object value) { }

	// RVA: 0xDB9008
	public virtual void WriteComment(string text) { }

	// RVA: 0xDB9010
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDB90A4
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xDB7F9C
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xDB90C4
	private static void ResolveConvertibleValue(IConvertible convertible, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xDB7ECC
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0xDB929C
	protected void SetWriteState(JsonToken token, object value) { }

	// RVA: 0xDB4E2C
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0xDB1C40
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0xDB2600
	internal void InternalWriteRaw() { }

	// RVA: 0xDB1948
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0xDB2354
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0xDB401C
	internal void InternalWriteComment() { }

}

// Namespace: Newtonsoft.Json
[Serializable]
public class JsonWriterException
{
	// Fields
	private readonly string <Path>k__BackingField; // 0x90

	// Methods

	// RVA: 0xDB9528
	public void .ctor() { }

	// RVA: 0xDB9530
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xDB9538
	public void .ctor(string message, string path, Exception innerException) { }

	// RVA: 0xDB9570
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0xDB95A8
	internal static JsonWriterException Create(string path, string message, Exception ex) { }

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

	// RVA: 0xDB9670
	public void .ctor(TextWriter writer) { }

	// RVA: 0xDB9798
	private void ValidateEncode(Byte[] buffer, int index, int count) { }

	// RVA: 0xDB987C
	public void Encode(Byte[] buffer, int index, int count) { }

	// RVA: 0xDB9BC0
	private void StoreLeftOverBytes(Byte[] buffer, int index, int count) { }

	// RVA: 0xDB9AD4
	private bool FulfillFromLeftover(Byte[] buffer, int index, int count) { }

	// RVA: 0xDB9CDC
	public void Flush() { }

	// RVA: 0xDB9B98
	private void WriteChars(Char[] chars, int index, int count) { }

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

	// RVA: 0x30D5174
	public void .ctor(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }

	// RVA: 0x318DB98
	public void Set(TFirst first, TSecond second) { }

	// RVA: 0x318DB98
	public bool TryGetByFirst(TFirst first, TSecond second) { }

	// RVA: 0x318DB98
	public bool TryGetBySecond(TSecond second, TFirst first) { }

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

	// RVA: 0xDB9D94
	internal static object Get(bool value) { }

	// RVA: 0xDB9E30
	internal static object Get(int value) { }

	// RVA: 0xDBA19C
	internal static object Get(Int64 value) { }

	// RVA: 0xDBA43C
	internal static object Get(Decimal value) { }

	// RVA: 0xDBA534
	internal static object Get(Double value) { }

	// RVA: 0xDBA69C
	private static void .cctor() { }

}

// Namespace: 
private static class EmptyArrayContainer<T0>
{
	// Fields
	public static readonly T[] Empty; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class CollectionUtils
{
	// Methods

	// RVA: 0x30D5E84
	public static bool IsNullOrEmpty(System.Collections.Generic.ICollection<T> collection) { }

	// RVA: 0x30DB358
	public static void AddRange(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0xDBABBC
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0xDBAED0
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0xDBAFF4
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	// RVA: 0x30D6D88
	public static int IndexOf(System.Collections.Generic.IEnumerable<T> collection, System.Func<T,System.Boolean> predicate) { }

	// RVA: 0x318DB98
	public static bool Contains(System.Collections.Generic.List<T> list, T value, IEqualityComparer comparer) { }

	// RVA: 0x318DB98
	public static int IndexOfReference(System.Collections.Generic.List<T> list, T item) { }

	// RVA: 0x30DA164
	public static void FastReverse(System.Collections.Generic.List<T> list) { }

	// RVA: 0xDBB368
	private static System.Collections.Generic.IList<System.Int32> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0xDBB6CC
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0xDBB9B0
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0xDBBB5C
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

	// RVA: 0x30D77AC
	public static T[] ArrayEmpty() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedCollection
{
	// Methods

	// RVA: -1
	public abstract object get_UnderlyingCollection() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class CollectionWrapper<T0>
{
	// Fields
	private readonly IList _list; // 0x0
	private readonly System.Collections.Generic.ICollection<T> _genericCollection; // 0x0
	private object _syncRoot; // 0x0

	// Methods

	// RVA: 0x318DB98
	public virtual void Add(T item) { }

	// RVA: 0x30D488C
	public virtual void Clear() { }

	// RVA: 0x318DB98
	public virtual bool Contains(T item) { }

	// RVA: 0x30D4D3C
	public virtual void CopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x30D39B8
	public virtual int get_Count() { }

	// RVA: 0x30D3738
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x318DB98
	public virtual bool Remove(T item) { }

	// RVA: 0x30D3CF0
	public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30D3AE8
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x30D3858
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x30D3AE8
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x30D4A04
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x30D4B6C
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x30D3738
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x30D4CD4
	private void System.Collections.IList.Remove(object value) { }

	// RVA: -1
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x30D4B6C
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x30D4D3C
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x30D3738
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30D3CF0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30DA164
	private static void VerifyValueType(object value) { }

	// RVA: 0x30D5E84
	private static bool IsCompatibleObject(object value) { }

	// RVA: 0x30D3CF0
	public object get_UnderlyingCollection() { }

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

	// RVA: 0xDBBD94
	public Type get_Type() { }

	// RVA: 0xDBBD9C
	public PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0xDBBDA4
	public void .ctor(Type type, PrimitiveTypeCode typeCode) { }

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

	// RVA: 0xDBC860
	public void .ctor() { }

	// RVA: 0xDC0CFC
	internal object <CreateCastConverter>b__0(object o) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ConvertUtils
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.Utilities.PrimitiveTypeCode> TypeCodeMap; // 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x8
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type>,System.Func<System.Object,System.Object>> CastConverters; // 0x10

	// Methods

	// RVA: 0xDBBDEC
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0xDBBE5C
	public static PrimitiveTypeCode GetTypeCode(Type t, bool isEnum) { }

	// RVA: 0xDBC338
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0xDBC450
	public static bool IsConvertible(Type t) { }

	// RVA: 0xDBC508
	public static TimeSpan ParseTimeSpan(string input) { }

	// RVA: 0xDBC5D0
	private static System.Func<System.Object,System.Object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type> t) { }

	// RVA: 0xDBC868
	internal static BigInteger ToBigInteger(object value) { }

	// RVA: 0xDBCD54
	public static object FromBigInteger(BigInteger i, Type targetType) { }

	// RVA: 0xDBD28C
	public static object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0xDBE208
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, object value) { }

	// RVA: 0xDBD544
	private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, object value) { }

	// RVA: 0xDBE7A4
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0xDBE52C
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0xDBE448
	public static bool VersionTryParse(string input, Version result) { }

	// RVA: 0xDBE35C
	public static bool IsInteger(object value) { }

	// RVA: 0xDBE974
	public static ParseResult Int32TryParse(Char[] chars, int start, int length, int value) { }

	// RVA: 0xDBEB2C
	public static ParseResult Int64TryParse(Char[] chars, int start, int length, Int64 value) { }

	// RVA: 0xDBECBC
	public static ParseResult DecimalTryParse(Char[] chars, int start, int length, Decimal value) { }

	// RVA: 0xDBF7E0
	public static bool TryConvertGuid(string s, Guid g) { }

	// RVA: 0xDBF840
	public static bool TryHexTextToInt(Char[] text, int start, int end, int value) { }

	// RVA: 0xDBF91C
	private static void .cctor() { }

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

	// RVA: 0xDC0DD4
	private static void .cctor() { }

	// RVA: 0xDC1064
	public bool Parse(Char[] text, int startIndex, int length) { }

	// RVA: 0xDC1264
	private bool ParseDate(int start) { }

	// RVA: 0xDC1564
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0xDC17DC
	private bool ParseTime(int start) { }

	// RVA: 0xDC1DE8
	private bool ParseZone(int start) { }

	// RVA: 0xDC1628
	private bool Parse4Digit(int start, int num) { }

	// RVA: 0xDC172C
	private bool Parse2Digit(int start, int num) { }

	// RVA: 0xDC1510
	private bool ParseChar(int start, Char ch) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class DateTimeUtils
{
	// Fields
	internal static readonly Int64 InitialJavaScriptDateTicks; // 0x0
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10

	// Methods

	// RVA: 0xDC2130
	private static void .cctor() { }

	// RVA: 0xDC2234
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0xDC22C0
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0xDC2440
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0xDC25DC
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xDC26F4
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0xDC2808
	private static Int64 ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0xDC2984
	private static Int64 ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0xDC2B4C
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0xDC2CA0
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0xDC2D28
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0xDC2C18
	private static Int64 UniversalTicksToJavaScriptTicks(Int64 universalTicks) { }

	// RVA: 0xDC2E70
	internal static DateTime ConvertJavaScriptTicksToDateTime(Int64 javaScriptTicks) { }

	// RVA: 0xDC2F00
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, DateTime dt) { }

	// RVA: 0xDC3550
	internal static bool TryParseDateTimeOffsetIso(StringReference text, DateTimeOffset dt) { }

	// RVA: 0xDC344C
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0xDC382C
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xDC3F60
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xDC4280
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xDC47C8
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xDC4B34
	private static bool TryParseMicrosoftDate(StringReference text, Int64 ticks, TimeSpan offset, DateTimeKind kind) { }

	// RVA: 0xDC3C78
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, DateTime dt) { }

	// RVA: 0xDC3E70
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xDC4534
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, DateTimeOffset dt) { }

	// RVA: 0xDC4708
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xDC4DD4
	private static bool TryReadOffset(StringReference offsetText, int startIndex, TimeSpan offset) { }

	// RVA: 0xDC4F78
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0xDC5108
	internal static int WriteDateTimeString(Char[] chars, int start, DateTime value, System.Nullable<System.TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0xDC5A20
	internal static int WriteDefaultIsoDate(Char[] chars, int start, DateTime dt) { }

	// RVA: 0xDC623C
	private static void CopyIntToCharArray(Char[] chars, int start, int value, int digits) { }

	// RVA: 0xDC5754
	internal static int WriteDateTimeOffset(Char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0xDC62A8
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0xDC5FE0
	private static void GetDateValues(DateTime td, int year, int month, int day) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedDictionary
{
	// Methods

	// RVA: -1
	public abstract object get_UnderlyingDictionary() { }

}

// Namespace: 
private struct DictionaryEnumerator<T0, T1>
{
	// Fields
	private readonly System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> _e; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }

	// RVA: -1
	public DictionaryEntry get_Entry() { }

	// RVA: 0x30D3CF0
	public object get_Key() { }

	// RVA: 0x30D3CF0
	public object get_Value() { }

	// RVA: 0x30D3CF0
	public object get_Current() { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x30D488C
	public void Reset() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.DictionaryWrapper.<>c<TKey,TValue> <>9; // 0x0
	public static System.Func<System.Collections.DictionaryEntry,System.Collections.Generic.KeyValuePair<TKey,TValue>> <>9__29_0; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal System.Collections.Generic.KeyValuePair<TKey,TValue> <GetEnumerator>b__29_0(DictionaryEntry de) { }

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

	// RVA: 0x30D3CF0
	internal System.Collections.Generic.IDictionary<TKey,TValue> get_GenericDictionary() { }

	// RVA: 0x318DB98
	public void Add(TKey key, TValue value) { }

	// RVA: 0x318DB98
	public bool ContainsKey(TKey key) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.ICollection<TKey> get_Keys() { }

	// RVA: 0x318DB98
	public bool Remove(TKey key) { }

	// RVA: 0x318DB98
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.ICollection<TValue> get_Values() { }

	// RVA: 0x318DB98
	public TValue get_Item(TKey key) { }

	// RVA: 0x318DB98
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x318DB98
	public void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x318DB98
	public bool Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30D4D3C
	public void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D3738
	public bool get_IsReadOnly() { }

	// RVA: 0x318DB98
	public bool Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30D4F34
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x30D3DA0
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x30D4F34
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x30D3CF0
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x30D3858
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x30D3738
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x30D3CF0
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x30D4CD4
	public void Remove(object key) { }

	// RVA: 0x30D3CF0
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x30D4D3C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30D3738
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30D3CF0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30D3CF0
	public object get_UnderlyingDictionary() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class DynamicProxy<T0>
{
	// Methods

	// RVA: 0x318DB98
	public virtual System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(T instance) { }

	// RVA: 0x318DB98
	public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, object result) { }

	// RVA: 0x318DB98
	public virtual bool TryConvert(T instance, ConvertBinder binder, object result) { }

	// RVA: 0x318DB98
	public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, object result) { }

	// RVA: 0x318DB98
	public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes) { }

	// RVA: 0x318DB98
	public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder) { }

	// RVA: 0x318DB98
	public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, object result) { }

	// RVA: 0x318DB98
	public virtual bool TryGetMember(T instance, GetMemberBinder binder, object result) { }

	// RVA: 0x318DB98
	public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, object result) { }

	// RVA: 0x318DB98
	public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, object result) { }

	// RVA: 0x318DB98
	public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value) { }

	// RVA: 0x318DB98
	public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value) { }

	// RVA: 0x318DB98
	public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, object result) { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: 
private sealed class Fallback
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x30D3DA0
	public virtual DynamicMetaObject Invoke(DynamicMetaObject errorSuggestion) { }

}

// Namespace: 
private sealed class GetBinderAdapter
{
	// Methods

	// RVA: 0x30D4CD4
	internal void .ctor(InvokeMemberBinder binder) { }

	// RVA: 0x30D3E84
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.DynamicProxyMetaObject.<>c<T> <>9; // 0x0
	public static System.Func<System.Dynamic.DynamicMetaObject,System.Linq.Expressions.Expression> <>9__18_0; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal Expression <GetArgs>b__18_0(DynamicMetaObject arg) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public BinaryOperationBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject arg; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindBinaryOperation>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public UnaryOperationBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindUnaryOperation>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass12_0
{
	// Fields
	public GetIndexBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject[] indexes; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindGetIndex>b__0(DynamicMetaObject e) { }

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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindSetIndex>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_0
{
	// Fields
	public DeleteIndexBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject[] indexes; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindDeleteIndex>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public GetMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindGetMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public SetMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject value; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindSetMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public DeleteMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindDeleteMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public ConvertBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindConvert>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public InvokeMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindInvokeMember>b__0(DynamicMetaObject e) { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindInvokeMember>b__1(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public CreateInstanceBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindCreateInstance>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public InvokeBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal DynamicMetaObject <BindInvoke>b__0(DynamicMetaObject e) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class DynamicProxyMetaObject<T0>
{
	// Fields
	private readonly Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy; // 0x0

	// Methods

	// RVA: 0x318DB98
	internal void .ctor(Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy) { }

	// RVA: 0x30D3858
	private bool IsOverridden(string method) { }

	// RVA: 0x30D3DA0
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x30D3E84
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x30D3DA0
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x30D3DA0
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }

	// RVA: 0x30D3E84
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x30D3E84
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x30D3E84
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x30D3E84
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	// RVA: 0x30D3DA0
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	// RVA: 0x30D3E84
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x30D3EF4
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: 0x30D3E84
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x30D77AC
	private static Expression[] get_NoArgs() { }

	// RVA: 0x30D77E4
	private static System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(DynamicMetaObject[] args) { }

	// RVA: 0x30D77E4
	private static Expression[] GetArgArray(DynamicMetaObject[] args) { }

	// RVA: 0x30D78C4
	private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value) { }

	// RVA: 0x30D77E4
	private static ConstantExpression Constant(DynamicMetaObjectBinder binder) { }

	// RVA: 0x30D3FD8
	private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Fallback fallback, Fallback fallbackInvoke) { }

	// RVA: 0x30D3FD8
	private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, DynamicMetaObject fallbackResult, Fallback fallbackInvoke) { }

	// RVA: 0x30D3F68
	private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Fallback fallback) { }

	// RVA: 0x30D3F68
	private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Fallback fallback) { }

	// RVA: 0x30D3CF0
	private BindingRestrictions GetRestrictions() { }

	// RVA: 0x30D3CF0
	public override System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames() { }

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

	// RVA: 0xDC65C8
	private static void Init() { }

	// RVA: 0xDC67C4
	private static object CreateSharpArgumentInfoArray(int[] values) { }

	// RVA: 0xDC6AD4
	private static void CreateMemberCalls() { }

	// RVA: 0xDC700C
	public static CallSiteBinder GetMember(string name, Type context) { }

	// RVA: 0xDC7224
	public static CallSiteBinder SetMember(string name, Type context) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class DynamicUtils
{
	// Methods

	// RVA: 0xDC64A4
	public static System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowGetBinderMember
{
	// Fields
	private readonly GetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0xDC743C
	public void .ctor(GetMemberBinder innerBinder) { }

	// RVA: 0xDC7480
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowSetBinderMember
{
	// Fields
	private readonly SetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0xDC7618
	public void .ctor(SetMemberBinder innerBinder) { }

	// RVA: 0xDC765C
	public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowExpressionVisitor
{
	// Fields
	internal static readonly object ErrorResult; // 0x0

	// Methods

	// RVA: 0xDC77B4
	protected override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0xDC7610
	public void .ctor() { }

	// RVA: 0xDC78AC
	private static void .cctor() { }

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

	// RVA: 0xDC7934
	public void .ctor(bool isFlags, UInt64[] values, string[] names, string[] resolvedNames) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.EnumUtils.<>c <>9; // 0x0
	public static System.Func<System.Runtime.Serialization.EnumMemberAttribute,System.String> <>9__3_0; // 0x8

	// Methods

	// RVA: 0xDC93F0
	private static void .cctor() { }

	// RVA: 0xDC945C
	public void .ctor() { }

	// RVA: 0xDC9464
	internal string <InitializeValuesAndNames>b__3_0(EnumMemberAttribute a) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class EnumUtils
{
	// Fields
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum; // 0x0
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x8

	// Methods

	// RVA: 0xDC79A8
	private static EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy> key) { }

	// RVA: 0xDC82E0
	public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, string name) { }

	// RVA: 0xDC849C
	private static string InternalFlagsFormat(EnumInfo entry, UInt64 result) { }

	// RVA: 0xDC8710
	public static EnumInfo GetEnumValuesAndNames(Type enumType) { }

	// RVA: 0xDC7F38
	private static UInt64 ToUInt64(object value) { }

	// RVA: 0xDC87E8
	public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	// RVA: 0xDC91A0
	private static System.Nullable<System.Int32> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0xDC90A0
	private static System.Nullable<System.Int32> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0xDC92B8
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class FSharpFunction
{
	// Fields
	private readonly object _instance; // 0x10
	private readonly Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _invoker; // 0x18

	// Methods

	// RVA: 0xDC9480
	public void .ctor(object instance, Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoker) { }

	// RVA: 0xDC94D0
	public object Invoke(object[] args) { }

}

// Namespace: 
[Serializable]
private sealed class <>c__55<T0, T1>
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.FSharpUtils.<>c__55<TKey,TValue> <>9; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<TKey,TValue>,System.Tuple<TKey,TValue>> <>9__55_1; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal System.Tuple<TKey,TValue> <BuildMapCreator>b__55_1(System.Collections.Generic.KeyValuePair<TKey,TValue> kv) { }

}

// Namespace: 
private sealed class <>c__DisplayClass52_0
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoke; // 0x18

	// Methods

	// RVA: 0xDCA058
	public void .ctor() { }

	// RVA: 0xDCA3D4
	internal object <CreateFSharpFuncCall>b__0(object target, object[] args) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0<T0, T1>
{
	// Fields
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> ctorDelegate; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3DA0
	internal object <BuildMapCreator>b__0(object[] args) { }

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

	// RVA: 0xDC9514
	private void .ctor(Assembly fsharpCoreAssembly) { }

	// RVA: 0xDC9D9C
	public static FSharpUtils get_Instance() { }

	// RVA: 0xDC9E18
	private void set_FSharpCoreAssembly(Assembly value) { }

	// RVA: 0xDC9E20
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_IsUnion() { }

	// RVA: 0xDC9E28
	private void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDC9E30
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCases() { }

	// RVA: 0xDC9E38
	private void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDC9E40
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionTagReader() { }

	// RVA: 0xDC9E48
	private void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDC9E50
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionReader() { }

	// RVA: 0xDC9E58
	private void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDC9E60
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionConstructor() { }

	// RVA: 0xDC9E68
	private void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDC9E70
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoDeclaringType() { }

	// RVA: 0xDC9E78
	private void set_GetUnionCaseInfoDeclaringType(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDC9E80
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoName() { }

	// RVA: 0xDC9E88
	private void set_GetUnionCaseInfoName(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDC9E90
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoTag() { }

	// RVA: 0xDC9E98
	private void set_GetUnionCaseInfoTag(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDC9EA0
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCaseInfoFields() { }

	// RVA: 0xDC9EA8
	private void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDC9EB0
	public static void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	// RVA: 0xDC9AEC
	private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	// RVA: 0xDC9B64
	private static Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> CreateFSharpFuncCall(Type type, string methodName) { }

	// RVA: 0xDCA060
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateSeq(Type t) { }

	// RVA: 0xDCA168
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateMap(Type keyType, Type valueType) { }

	// RVA: 0x30D3CF0
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> BuildMapCreator() { }

	// RVA: 0xDCA34C
	private static void .cctor() { }

}

// Namespace: 
internal class ImmutableCollectionTypeInfo
{
	// Fields
	private string <ContractTypeName>k__BackingField; // 0x10
	private string <CreatedTypeName>k__BackingField; // 0x18
	private string <BuilderTypeName>k__BackingField; // 0x20

	// Methods

	// RVA: 0xDCB6A8
	public void .ctor(string contractTypeName, string createdTypeName, string builderTypeName) { }

	// RVA: 0xDCB70C
	public string get_ContractTypeName() { }

	// RVA: 0xDCB714
	public void set_ContractTypeName(string value) { }

	// RVA: 0xDCB71C
	public string get_CreatedTypeName() { }

	// RVA: 0xDCB724
	public void set_CreatedTypeName(string value) { }

	// RVA: 0xDCB72C
	public string get_BuilderTypeName() { }

	// RVA: 0xDCB734
	public void set_BuilderTypeName(string value) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.<>c <>9; // 0x0
	public static System.Func<System.Reflection.MethodInfo,System.Boolean> <>9__24_1; // 0x8
	public static System.Func<System.Reflection.MethodInfo,System.Boolean> <>9__25_1; // 0x10

	// Methods

	// RVA: 0xDCB73C
	private static void .cctor() { }

	// RVA: 0xDCB7A8
	public void .ctor() { }

	// RVA: 0xDCB7B0
	internal bool <TryBuildImmutableForArrayContract>b__24_1(MethodInfo m) { }

	// RVA: 0xDCB840
	internal bool <TryBuildImmutableForDictionaryContract>b__25_1(MethodInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass24_0
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0xDCA994
	public void .ctor() { }

	// RVA: 0xDCB9A8
	internal bool <TryBuildImmutableForArrayContract>b__0(ImmutableCollectionTypeInfo d) { }

}

// Namespace: 
private sealed class <>c__DisplayClass25_0
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0xDCAF0C
	public void .ctor() { }

	// RVA: 0xDCB9D0
	internal bool <TryBuildImmutableForDictionaryContract>b__0(ImmutableCollectionTypeInfo d) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ImmutableCollectionsUtils
{
	// Fields
	private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x0
	private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x8

	// Methods

	// RVA: 0xDCA498
	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, Type createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }

	// RVA: 0xDCA9C0
	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, Type createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }

	// RVA: 0xDCAF14
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class BufferUtils
{
	// Methods

	// RVA: 0xDCB9F8
	public static Char[] RentBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int minSize) { }

	// RVA: 0xDCBAD0
	public static void ReturnBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] buffer) { }

	// RVA: 0xDCBB90
	public static Char[] EnsureBufferSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int size, Char[] buffer) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class JavaScriptUtils
{
	// Fields
	internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x0
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x8
	internal static readonly bool[] HtmlCharEscapeFlags; // 0x10

	// Methods

	// RVA: 0xDCBCD0
	private static void .cctor() { }

	// RVA: 0xDCC74C
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, Char quoteChar) { }

	// RVA: 0xDCC838
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	// RVA: 0xDCC8E4
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, Char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] writeBuffer) { }

	// RVA: 0xDCD1E4
	public static string ToEscapedJavaScriptString(string value, Char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xDCD004
	private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xDCD540
	public static bool TryGetDateFromConstructorJson(JsonReader reader, DateTime dateTime, string errorMessage) { }

	// RVA: 0xDCDA84
	private static bool TryGetDateConstructorValue(JsonReader reader, System.Nullable<System.Int64>& integer, string errorMessage) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class JsonTokenUtils
{
	// Methods

	// RVA: 0xDCDC5C
	internal static bool IsEndToken(JsonToken token) { }

	// RVA: 0xDCDC6C
	internal static bool IsStartToken(JsonToken token) { }

	// RVA: 0xDCDC7C
	internal static bool IsPrimitiveToken(JsonToken token) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public ConstructorInfo c; // 0x10
	public MethodBase method; // 0x18

	// Methods

	// RVA: 0xDCDED4
	public void .ctor() { }

	// RVA: 0xDCDF58
	internal object <CreateParameterizedConstructor>b__0(object[] a) { }

	// RVA: 0xDCDF78
	internal object <CreateParameterizedConstructor>b__1(object[] a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0<T0>
{
	// Fields
	public ConstructorInfo c; // 0x0
	public MethodBase method; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal object <CreateMethodCall>b__0(T o, object[] a) { }

	// RVA: 0x318DB98
	internal object <CreateMethodCall>b__1(T o, object[] a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0<T0>
{
	// Fields
	public Type type; // 0x0
	public ConstructorInfo constructorInfo; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal T <CreateDefaultConstructor>b__0() { }

	// RVA: 0x318DB98
	internal T <CreateDefaultConstructor>b__1() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0<T0>
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal object <CreateGet>b__0(T o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0<T0>
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal object <CreateGet>b__0(T o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0<T0>
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal void <CreateSet>b__0(T o, object v) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0<T0>
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal void <CreateSet>b__0(T o, object v) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class LateBoundReflectionDelegateFactory
{
	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x0

	// Methods

	// RVA: 0xDCDC94
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0xDCDD10
	public override Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: 0x30D3DA0
	public override Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(MethodBase method) { }

	// RVA: 0x30D3DA0
	public override System.Func<T> CreateDefaultConstructor(Type type) { }

	// RVA: 0x30D3DA0
	public override System.Func<T,System.Object> CreateGet(PropertyInfo propertyInfo) { }

	// RVA: 0x30D3DA0
	public override System.Func<T,System.Object> CreateGet(FieldInfo fieldInfo) { }

	// RVA: 0x30D3DA0
	public override System.Action<T,System.Object> CreateSet(FieldInfo fieldInfo) { }

	// RVA: 0x30D3DA0
	public override System.Action<T,System.Object> CreateSet(PropertyInfo propertyInfo) { }

	// RVA: 0xDCDEDC
	public void .ctor() { }

	// RVA: 0xDCDEEC
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class MathUtils
{
	// Methods

	// RVA: 0xDCDFA0
	public static int IntLength(UInt64 i) { }

	// RVA: 0xDCE168
	public static Char IntToHex(int n) { }

	// RVA: 0xDCE184
	public static bool ApproxEquals(Double d1, Double d2) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class MethodCall<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual TResult Invoke(T target, object[] args) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class MiscellaneousUtils
{
	// Methods

	// RVA: 0xDCE238
	public static bool ValueEquals(object objA, object objB) { }

	// RVA: 0xDC2348
	public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	// RVA: 0xDCE640
	public static string ToString(object value) { }

	// RVA: 0xDCE6F4
	public static int ByteArrayCompare(Byte[] a1, Byte[] a2) { }

	// RVA: 0xDCE7BC
	public static string GetPrefix(string qualifiedName) { }

	// RVA: 0xDCE8B4
	public static string GetLocalName(string qualifiedName) { }

	// RVA: 0xDCE7E8
	public static void GetQualifiedNameParts(string qualifiedName, string prefix, string localName) { }

	// RVA: 0xDCE8F8
	internal static RegexOptions GetRegexOptions(string optionsText) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal abstract class ReflectionDelegateFactory
{
	// Methods

	// RVA: 0x30D3DA0
	public System.Func<T,System.Object> CreateGet(MemberInfo memberInfo) { }

	// RVA: 0x30D3DA0
	public System.Action<T,System.Object> CreateSet(MemberInfo memberInfo) { }

	// RVA: -1
	public abstract Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(MethodBase method) { }

	// RVA: -1
	public abstract Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: -1
	public abstract System.Func<T> CreateDefaultConstructor(Type type) { }

	// RVA: -1
	public abstract System.Func<T,System.Object> CreateGet(PropertyInfo propertyInfo) { }

	// RVA: -1
	public abstract System.Func<T,System.Object> CreateGet(FieldInfo fieldInfo) { }

	// RVA: -1
	public abstract System.Action<T,System.Object> CreateSet(FieldInfo fieldInfo) { }

	// RVA: -1
	public abstract System.Action<T,System.Object> CreateSet(PropertyInfo propertyInfo) { }

	// RVA: 0xDCDEE4
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ReflectionMember
{
	// Fields
	private Type <MemberType>k__BackingField; // 0x10
	private System.Func<System.Object,System.Object> <Getter>k__BackingField; // 0x18
	private System.Action<System.Object,System.Object> <Setter>k__BackingField; // 0x20

	// Methods

	// RVA: 0xDCE9AC
	public Type get_MemberType() { }

	// RVA: 0xDCE9B4
	public void set_MemberType(Type value) { }

	// RVA: 0xDCE9BC
	public System.Func<System.Object,System.Object> get_Getter() { }

	// RVA: 0xDCE9C4
	public void set_Getter(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDCE9CC
	public System.Action<System.Object,System.Object> get_Setter() { }

	// RVA: 0xDCE9D4
	public void set_Setter(System.Action<System.Object,System.Object> value) { }

	// RVA: 0xDCE9DC
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public System.Func<System.Object> ctor; // 0x10

	// Methods

	// RVA: 0xDCF744
	public void .ctor() { }

	// RVA: 0xDCFD10
	internal object <Create>b__0(object[] args) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_1
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10

	// Methods

	// RVA: 0xDCFA6C
	public void .ctor() { }

	// RVA: 0xDCFD4C
	internal object <Create>b__1(object target) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_2
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10

	// Methods

	// RVA: 0xDCFA74
	public void .ctor() { }

	// RVA: 0xDCFE64
	internal void <Create>b__2(object target, object arg) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ReflectionObject
{
	// Fields
	private readonly Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <Creator>k__BackingField; // 0x10
	private readonly System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDCE9E4
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_Creator() { }

	// RVA: 0xDCE9EC
	public System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> get_Members() { }

	// RVA: 0xDCE9F4
	private void .ctor(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator) { }

	// RVA: 0xDCEA9C
	public object GetValue(object target, string member) { }

	// RVA: 0xDCEB9C
	public void SetValue(object target, string member, object value) { }

	// RVA: 0xDCEC98
	public Type GetType(string member) { }

	// RVA: 0xDCED68
	public static ReflectionObject Create(Type t, string[] memberNames) { }

	// RVA: 0xDCED74
	public static ReflectionObject Create(Type t, MethodBase creator, string[] memberNames) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Newtonsoft.Json.Utilities.ReflectionUtils.<>c <>9; // 0x0
	public static System.Func<System.Reflection.ConstructorInfo,System.Boolean> <>9__11_0; // 0x8
	public static System.Func<System.Reflection.MemberInfo,System.String> <>9__31_0; // 0x10
	public static System.Func<System.Reflection.ParameterInfo,System.Type> <>9__39_0; // 0x18
	public static System.Func<System.Reflection.FieldInfo,System.Boolean> <>9__41_0; // 0x20

	// Methods

	// RVA: 0xDD4760
	private static void .cctor() { }

	// RVA: 0xDD47CC
	public void .ctor() { }

	// RVA: 0xDD47D4
	internal bool <GetDefaultConstructor>b__11_0(ConstructorInfo c) { }

	// RVA: 0xDD4840
	internal string <GetFieldsAndProperties>b__31_0(MemberInfo m) { }

	// RVA: 0xDD4868
	internal Type <GetMemberInfoFromType>b__39_0(ParameterInfo p) { }

	// RVA: 0xDD4890
	internal bool <GetChildPrivateFields>b__41_0(FieldInfo f) { }

}

// Namespace: 
private sealed class <>c__DisplayClass31_0
{
	// Fields
	public MemberInfo memberInfo; // 0x10

	// Methods

	// RVA: 0xDD3018
	public void .ctor() { }

	// RVA: 0xDD48AC
	internal bool <GetFieldsAndProperties>b__1(MemberInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass44_0
{
	// Fields
	public PropertyInfo subTypeProperty; // 0x10

	// Methods

	// RVA: 0xDD433C
	public void .ctor() { }

	// RVA: 0xDD494C
	internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	// RVA: 0xDD49A8
	internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass44_1
{
	// Fields
	public Type subTypePropertyDeclaringType; // 0x10
	public Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xDD4344
	public void .ctor() { }

	// RVA: 0xDD4A94
	internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_0
{
	// Fields
	public string method; // 0x10
	public Type methodDeclaringType; // 0x18

	// Methods

	// RVA: 0xDD4468
	public void .ctor() { }

	// RVA: 0xDD4BCC
	internal bool <IsMethodOverridden>b__0(MethodInfo info) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ReflectionUtils
{
	// Fields
	public static readonly Type[] EmptyTypes; // 0x0

	// Methods

	// RVA: 0xDCFF44
	private static void .cctor() { }

	// RVA: 0xDCFFC8
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	// RVA: 0xDD00F4
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0xDD01E8
	public static bool IsPublic(PropertyInfo property) { }

	// RVA: 0xDBE964
	public static Type GetObjectType(object v) { }

	// RVA: 0xDD0294
	public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder) { }

	// RVA: 0xDD03B8
	private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder) { }

	// RVA: 0xDD0500
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0xDCF62C
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0xDD07F8
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0xDD0694
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0xDBE450
	public static bool IsNullable(Type t) { }

	// RVA: 0xDBC224
	public static bool IsNullableType(Type t) { }

	// RVA: 0xDD0880
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0xDD091C
	public static Type EnsureNotByRefType(Type t) { }

	// RVA: 0xDD097C
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0xDBAE54
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0xDD0A30
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, Type implementingType) { }

	// RVA: 0xDD0D0C
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0xDD0D88
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, Type implementingType) { }

	// RVA: 0xDD0F18
	private static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, Type implementingType) { }

	// RVA: 0xDD1088
	public static Type GetCollectionItemType(Type type) { }

	// RVA: 0xDD1310
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, Type keyType, Type valueType) { }

	// RVA: 0xDCFA7C
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0xDD15A0
	public static bool IsByRefLikeType(Type type) { }

	// RVA: 0xDD1BA8
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0xDD1C54
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0xDD1F94
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0xDCF76C
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0xDCF8D4
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0xDD21C4
	public static System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0xDD3020
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: 0x318DB98
	public static T GetAttribute(object attributeProvider) { }

	// RVA: 0x318DB98
	public static T GetAttribute(object attributeProvider, bool inherit) { }

	// RVA: -1
	public static T[] GetAttributes(object attributeProvider, bool inherit) { }

	// RVA: 0xDD16B0
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0xDD321C
	public static Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) { }

	// RVA: 0xDD34D8
	private static System.Nullable<System.Int32> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0xDD3784
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0xDD2B44
	public static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0xDD3A14
	private static void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, Type type, BindingFlags bindingAttr) { }

	// RVA: 0xDD2C90
	public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0xDD3C14
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0xDD3C24
	private static void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr) { }

	// RVA: 0xDD434C
	public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method) { }

	// RVA: 0xDD4470
	public static object GetDefaultValue(Type type) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StringBuffer
{
	// Fields
	private Char[] _buffer; // 0x10
	private int _position; // 0x18

	// Methods

	// RVA: 0xDD4CFC
	public int get_Position() { }

	// RVA: 0xDD4D04
	public void set_Position(int value) { }

	// RVA: 0xDD4D0C
	public bool get_IsEmpty() { }

	// RVA: 0xDD4D1C
	public void .ctor(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int initalSize) { }

	// RVA: 0xDD4D58
	private void .ctor(Char[] buffer) { }

	// RVA: 0xDD4D80
	public void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char value) { }

	// RVA: 0xDD4EF8
	public void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] buffer, int startIndex, int count) { }

	// RVA: 0xDD4F7C
	public void Clear(Newtonsoft.Json.IArrayPool<System.Char> bufferPool) { }

	// RVA: 0xDD4DFC
	private void EnsureSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int appendLength) { }

	// RVA: 0xDD504C
	public override string ToString() { }

	// RVA: 0xDD5064
	public string ToString(int start, int length) { }

	// RVA: 0xDD507C
	public Char[] get_InternalBuffer() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StringReference
{
	// Fields
	private readonly Char[] _chars; // 0x10
	private readonly int _startIndex; // 0x18
	private readonly int _length; // 0x1C

	// Methods

	// RVA: 0xDC3A80
	public Char get_Item(int i) { }

	// RVA: 0xDD5084
	public Char[] get_Chars() { }

	// RVA: 0xDD508C
	public int get_StartIndex() { }

	// RVA: 0xDD5094
	public int get_Length() { }

	// RVA: 0xDC4248
	public void .ctor(Char[] chars, int startIndex, int length) { }

	// RVA: 0xDC3E5C
	public override string ToString() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class StringReferenceExtensions
{
	// Methods

	// RVA: 0xDC4D38
	public static int IndexOf(StringReference s, Char c, int startIndex, int length) { }

	// RVA: 0xDC3AB4
	public static bool StartsWith(StringReference s, string text) { }

	// RVA: 0xDC3B94
	public static bool EndsWith(StringReference s, string text) { }

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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }

	// RVA: 0x318DB98
	internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class StringUtils
{
	// Methods

	// RVA: 0xDC3E54
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0xDBCC94
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	// RVA: 0xDBE110
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	// RVA: 0xDD5140
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	// RVA: 0xDD5278
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	// RVA: 0xDD509C
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0xDCD478
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0xDCD12C
	public static void ToCharAsUnicode(Char c, Char[] buffer) { }

	// RVA: 0x318DB98
	public static TSource ForgivingCaseSensitiveFind(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.String> valueSelector, string testValue) { }

	// RVA: 0xDD53E8
	public static string ToCamelCase(string s) { }

	// RVA: 0xDD58B4
	private static Char ToLower(Char c) { }

	// RVA: 0xDD597C
	public static string ToSnakeCase(string s) { }

	// RVA: 0xDD5CA4
	public static string ToKebabCase(string s) { }

	// RVA: 0xDD5984
	private static string ToSeparatedCase(string s, Char separator) { }

	// RVA: 0xDD5CAC
	public static bool IsHighSurrogate(Char c) { }

	// RVA: 0xDD5D34
	public static bool IsLowSurrogate(Char c) { }

	// RVA: 0xDCE8E0
	public static int IndexOf(string s, Char c) { }

	// RVA: 0xDD5DBC
	public static bool StartsWith(string source, Char value) { }

	// RVA: 0xDD5E10
	public static bool EndsWith(string source, Char value) { }

	// RVA: 0xDD35C0
	public static string Trim(string s, int start, int length) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StructMultiKey<T0, T1>
{
	// Fields
	public readonly T1 Value1; // 0x0
	public readonly T2 Value2; // 0x0

	// Methods

	// RVA: 0x318DB98
	public void .ctor(T1 v1, T2 v2) { }

	// RVA: 0x30D39B8
	public override int GetHashCode() { }

	// RVA: 0x30D3858
	public override bool Equals(object obj) { }

	// RVA: 0x318DB98
	public bool Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1,T2> other) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ThreadSafeStore<T0, T1>
{
	// Fields
	private readonly System.Collections.Concurrent.ConcurrentDictionary<TKey,TValue> _concurrentStore; // 0x0
	private readonly System.Func<TKey,TValue> _creator; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void .ctor(System.Func<TKey,TValue> creator) { }

	// RVA: 0x318DB98
	public TValue Get(TKey key) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class TypeExtensions
{
	// Methods

	// RVA: 0xDCF74C
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	// RVA: 0xDD5E60
	public static bool ContainsGenericParameters(Type type) { }

	// RVA: 0xDBE750
	public static bool IsInterface(Type type) { }

	// RVA: 0xDCA970
	public static bool IsGenericType(Type type) { }

	// RVA: 0xDBE768
	public static bool IsGenericTypeDefinition(Type type) { }

	// RVA: 0xDD1064
	public static Type BaseType(Type type) { }

	// RVA: 0xDCA99C
	public static Assembly Assembly(Type type) { }

	// RVA: 0xDBC200
	public static bool IsEnum(Type type) { }

	// RVA: 0xDD0F00
	public static bool IsClass(Type type) { }

	// RVA: 0xDD5E84
	public static bool IsSealed(Type type) { }

	// RVA: 0xDBE78C
	public static bool IsAbstract(Type type) { }

	// RVA: 0xDD5E9C
	public static bool IsVisible(Type type) { }

	// RVA: 0xDD067C
	public static bool IsValueType(Type type) { }

	// RVA: 0xDD5EB4
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, Type match) { }

	// RVA: 0xDD6068
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	// RVA: 0xDD608C
	public static bool ImplementInterface(Type type, Type interfaceType) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ValidationUtils
{
	// Methods

	// RVA: 0xDB9748
	public static void ArgumentNotNull(object value, string parameterName) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal static class CachedAttributeGetter<T0>
{
	// Fields
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Object,T> TypeAttributeCache; // 0x0

	// Methods

	// RVA: 0x318DB98
	public static T GetAttribute(object type) { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class CamelCaseNamingStrategy
{
	// Methods

	// RVA: 0xDD6478
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xDD64B4
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xDC93E8
	public void .ctor() { }

	// RVA: 0xDD64F8
	protected override string ResolvePropertyName(string name) { }

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

	// RVA: 0x30D4A04
	public void .ctor(int <>1__state) { }

	// RVA: 0x30D488C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30D3738
	private bool MoveNext() { }

	// RVA: 0x30D488C
	private void <>m__Finally1() { }

	// RVA: -1
	private System.Collections.Generic.KeyValuePair<System.Object,System.Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
internal class EnumerableDictionaryWrapper<T0, T1>
{
	// Fields
	private readonly System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> _e; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
[Serializable]
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

	// RVA: 0xDDE7F8
	private static void .cctor() { }

	// RVA: 0xDDE864
	public void .ctor() { }

	// RVA: 0xDDE86C
	internal bool <GetSerializableMembers>b__40_0(MemberInfo m) { }

	// RVA: 0xDDE924
	internal bool <GetSerializableMembers>b__40_1(MemberInfo m) { }

	// RVA: 0xDDE994
	internal System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(Type baseType) { }

	// RVA: 0xDDEA78
	internal bool <GetExtensionDataMemberForType>b__44_1(MemberInfo m) { }

	// RVA: 0xDDEE6C
	internal bool <GetAttributeConstructor>b__47_0(ConstructorInfo c) { }

	// RVA: 0xDDEF28
	internal int <CreateProperties>b__75_0(JsonProperty p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass42_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xDDF05C
	public void .ctor() { }

	// RVA: 0xDDF064
	internal string <CreateObjectContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_0
{
	// Fields
	public System.Func<System.Object,System.Object> getExtensionDataDictionary; // 0x10
	public MemberInfo member; // 0x18

	// Methods

	// RVA: 0xDDF088
	public void .ctor() { }

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

	// RVA: 0xDDF090
	public void .ctor() { }

	// RVA: 0xDDF098
	internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_2
{
	// Fields
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> createEnumerableWrapper; // 0x10
	public Newtonsoft.Json.Serialization.DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xDDF2C8
	public void .ctor() { }

	// RVA: 0xDDF2D0
	internal System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> <SetExtensionDataDelegates>b__1(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass62_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xDDF418
	public void .ctor() { }

	// RVA: 0xDDF420
	internal string <CreateDictionaryContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass67_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xDDF444
	public void .ctor() { }

	// RVA: 0xDDF44C
	internal string <CreateDynamicContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass80_0
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> shouldSerializeCall; // 0x10

	// Methods

	// RVA: 0xDDF470
	public void .ctor() { }

	// RVA: 0xDDF478
	internal bool <CreateShouldSerializeTest>b__0(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass81_0
{
	// Fields
	public System.Func<System.Object,System.Object> specifiedPropertyGet; // 0x10

	// Methods

	// RVA: 0xDDF5D0
	public void .ctor() { }

	// RVA: 0xDDF5D8
	internal bool <SetIsSpecifiedActions>b__0(object o) { }

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

	// RVA: 0xDD6500
	internal static IContractResolver get_Instance() { }

	// RVA: 0xDD657C
	public BindingFlags get_DefaultMembersSearchFlags() { }

	// RVA: 0xDD6584
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	// RVA: 0xDD658C
	public bool get_SerializeCompilerGeneratedMembers() { }

	// RVA: 0xDD6594
	public bool get_IgnoreSerializableInterface() { }

	// RVA: 0xDD659C
	public bool get_IgnoreSerializableAttribute() { }

	// RVA: 0xDD65A4
	public void set_IgnoreSerializableAttribute(bool value) { }

	// RVA: 0xDD65AC
	public bool get_IgnoreIsSpecifiedMembers() { }

	// RVA: 0xDD65B4
	public bool get_IgnoreShouldSerializeMembers() { }

	// RVA: 0xDD65BC
	public NamingStrategy get_NamingStrategy() { }

	// RVA: 0xDD65C4
	public void .ctor() { }

	// RVA: 0xDD66D8
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0xDD67A4
	private static bool FilterMembers(MemberInfo member) { }

	// RVA: 0xDD6920
	protected virtual System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0xDD74FC
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0xDD7610
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0xDD94A0
	private static void ThrowUnableToSerializeError(object o, StreamingContext context) { }

	// RVA: 0xDD88C4
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0xDD8AE8
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0xDD7F6C
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0xDD852C
	private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	// RVA: 0xDD84DC
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0xDD97D8
	protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0xDD9720
	private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	// RVA: 0xDD99D4
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0xDDA610
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0xDDA698
	private System.Func<System.Object> GetDefaultCreator(Type createdType) { }

	// RVA: 0xDD7C80
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0xDDA75C
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0xDDA8A8
	private void GetCallbackMethodsForType(Type type, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback>& onError) { }

	// RVA: 0xDDB9D0
	private static bool IsConcurrentOrObservableCollection(Type t) { }

	// RVA: 0xDDB26C
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0xDDB16C
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0xDD9538
	private System.Collections.Generic.List<System.Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0xDDBB64
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0xDDC134
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0xDDC49C
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0xDDC514
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0xDDC58C
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0xDDC804
	protected virtual JsonDynamicContract CreateDynamicContract(Type objectType) { }

	// RVA: 0xDDCA40
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0xDDCAB8
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0xDDD05C
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0xDDD298
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0xDDD12C
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0xDDB36C
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, Type prevAttributeType) { }

	// RVA: 0xDDD44C
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0xDDD558
	protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0xDDDA28
	internal virtual DefaultJsonNameTable GetNameTable() { }

	// RVA: 0xDDDA30
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0xDDDA98
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0xDD9E64
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, bool allowNonPublicAccess) { }

	// RVA: 0xDDDCC0
	private System.Predicate<System.Object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0xDDDF24
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0xDDE25C
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0xDDE27C
	protected virtual string ResolveExtensionDataName(string extensionDataName) { }

	// RVA: 0xDDE298
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0xDDE2C4
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0xDDE2D4
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultNamingStrategy
{
	// Methods

	// RVA: 0xDDF680
	protected override string ResolvePropertyName(string name) { }

	// RVA: 0xDDF688
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class DefaultReferenceResolver
{
	// Fields
	private int _referenceCount; // 0x10

	// Methods

	// RVA: 0xDDF690
	private Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> GetMappings(object context) { }

	// RVA: 0xDDF8C8
	public object ResolveReference(object context, string reference) { }

	// RVA: 0xDDF948
	public string GetReference(object context, object value) { }

	// RVA: 0xDDFA48
	public void AddReference(object context, string reference, object value) { }

	// RVA: 0xDDFAB8
	public bool IsReferenced(object context, object value) { }

	// RVA: 0xDDFB34
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultSerializationBinder
{
	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String>,System.Type> _typeCache; // 0x10

	// Methods

	// RVA: 0xDDFB3C
	public void .ctor() { }

	// RVA: 0xDDFC18
	private Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }

	// RVA: 0xDE0040
	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	// RVA: 0xDE02E4
	private Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }

	// RVA: 0xDE0364
	public override Type BindToType(string assemblyName, string typeName) { }

	// RVA: 0xDE0438
	public override void BindToName(Type serializedType, string assemblyName, string typeName) { }

	// RVA: 0xDE04C0
	private static void .cctor() { }

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

	// RVA: 0xDE0528
	internal void .ctor(object originalObject, object member, string path, Exception error) { }

	// RVA: 0xDE05A8
	internal bool get_Traced() { }

	// RVA: 0xDE05B0
	internal void set_Traced(bool value) { }

	// RVA: 0xDE05B8
	public Exception get_Error() { }

	// RVA: 0xDE05C0
	public bool get_Handled() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class ErrorEventArgs
{
	// Fields
	private readonly object <CurrentObject>k__BackingField; // 0x10
	private readonly ErrorContext <ErrorContext>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDE05C8
	public void .ctor(object currentObject, ErrorContext errorContext) { }

}

// Namespace: Newtonsoft.Json.Serialization
public interface IAttributeProvider
{}

// Namespace: Newtonsoft.Json.Serialization
public interface IContractResolver
{
	// Methods

	// RVA: -1
	public abstract JsonContract ResolveContract(Type type) { }

}

// Namespace: Newtonsoft.Json.Serialization
public interface IReferenceResolver
{
	// Methods

	// RVA: -1
	public abstract object ResolveReference(object context, string reference) { }

	// RVA: -1
	public abstract string GetReference(object context, object value) { }

	// RVA: -1
	public abstract bool IsReferenced(object context, object value) { }

	// RVA: -1
	public abstract void AddReference(object context, string reference, object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public interface ISerializationBinder
{
	// Methods

	// RVA: -1
	public abstract Type BindToType(string assemblyName, string typeName) { }

	// RVA: -1
	public abstract void BindToName(Type serializedType, string assemblyName, string typeName) { }

}

// Namespace: Newtonsoft.Json.Serialization
public interface ITraceWriter
{
	// Methods

	// RVA: -1
	public abstract TraceLevel get_LevelFilter() { }

	// RVA: -1
	public abstract void Trace(TraceLevel level, string message, Exception ex) { }

}

// Namespace: Newtonsoft.Json.Serialization
public interface IValueProvider
{
	// Methods

	// RVA: -1
	public abstract void SetValue(object target, object value) { }

	// RVA: -1
	public abstract object GetValue(object target) { }

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

	// RVA: 0xDE065C
	public Type get_CollectionItemType() { }

	// RVA: 0xDE0664
	public bool get_IsMultidimensionalArray() { }

	// RVA: 0xDE066C
	internal bool get_IsArray() { }

	// RVA: 0xDE0674
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0xDE067C
	internal bool get_CanDeserialize() { }

	// RVA: 0xDE0684
	private void set_CanDeserialize(bool value) { }

	// RVA: 0xDE068C
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xDE0790
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xDE0798
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDE07C8
	public bool get_HasParameterizedCreator() { }

	// RVA: 0xDE07D0
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0xDE07D8
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0xDE0874
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDE1C08
	internal IWrappedCollection CreateWrapper(object list) { }

	// RVA: 0xDE2040
	internal IList CreateTemporaryCollection() { }

	// RVA: 0xDE1A24
	private void StoreFSharpListCreatorIfNecessary(Type underlyingType) { }

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

	// RVA: 0xDE22EC
	internal JsonContract get_ItemContract() { }

	// RVA: 0xDE22F4
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0xDE2360
	internal JsonContract get_FinalItemContract() { }

	// RVA: 0xDE2368
	public JsonConverter get_ItemConverter() { }

	// RVA: 0xDE2370
	public void set_ItemConverter(JsonConverter value) { }

	// RVA: 0xDE2378
	public System.Nullable<System.Boolean> get_ItemIsReference() { }

	// RVA: 0xDE2380
	public void set_ItemIsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDE2388
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	// RVA: 0xDE2390
	public void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xDE2398
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }

	// RVA: 0xDE23A0
	public void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xDE1828
	internal void .ctor(Type underlyingType) { }

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

	// RVA: 0xDE2534
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDE2658
	public virtual void Invoke(object o, StreamingContext context) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationErrorCallback
{
	// Methods

	// RVA: 0xDE266C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDE2790
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataSetter
{
	// Methods

	// RVA: 0xDE27A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDE28C8
	public virtual void Invoke(object o, string key, object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataGetter
{
	// Methods

	// RVA: 0xDE28DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDE29FC
	public virtual System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> Invoke(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass57_0
{
	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0xDE3804
	public void .ctor() { }

	// RVA: 0xDE38D0
	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

}

// Namespace: 
private sealed class <>c__DisplayClass58_0
{
	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0xDE38C8
	public void .ctor() { }

	// RVA: 0xDE39DC
	internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext) { }

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

	// RVA: 0xDE2A10
	public Type get_UnderlyingType() { }

	// RVA: 0xDE2A18
	public Type get_CreatedType() { }

	// RVA: 0xDE1964
	public void set_CreatedType(Type value) { }

	// RVA: 0xDE2A20
	public System.Nullable<System.Boolean> get_IsReference() { }

	// RVA: 0xDE2A28
	public void set_IsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDE2A30
	public JsonConverter get_Converter() { }

	// RVA: 0xDE2A38
	public void set_Converter(JsonConverter value) { }

	// RVA: 0xDE2A40
	public JsonConverter get_InternalConverter() { }

	// RVA: 0xDE2A48
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0xDE2A50
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0xDE2AEC
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0xDE2B88
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0xDE2C24
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0xDE2CC0
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks() { }

	// RVA: 0xDE2D5C
	public System.Func<System.Object> get_DefaultCreator() { }

	// RVA: 0xDE2D64
	public void set_DefaultCreator(System.Func<System.Object> value) { }

	// RVA: 0xDE2D6C
	public bool get_DefaultCreatorNonPublic() { }

	// RVA: 0xDE2D74
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0xDE23A8
	internal void .ctor(Type underlyingType) { }

	// RVA: 0xDE2D7C
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0xDE2F70
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0xDE3164
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0xDE3358
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0xDE354C
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0xDE3748
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0xDE380C
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }

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

	// RVA: 0xDE3B20
	public System.Func<System.String,System.String> get_DictionaryKeyResolver() { }

	// RVA: 0xDE3B28
	public void set_DictionaryKeyResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xDE3B30
	public Type get_DictionaryKeyType() { }

	// RVA: 0xDE3B38
	public Type get_DictionaryValueType() { }

	// RVA: 0xDE3B40
	internal JsonContract get_KeyContract() { }

	// RVA: 0xDE3B48
	internal void set_KeyContract(JsonContract value) { }

	// RVA: 0xDE3B50
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0xDE3B58
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xDE3C5C
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xDE3C64
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDE3C74
	public bool get_HasParameterizedCreator() { }

	// RVA: 0xDE3C7C
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0xDE3C84
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0xDE3D20
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDE48BC
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	// RVA: 0xDE4B94
	internal IDictionary CreateTemporaryDictionary() { }

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

	// RVA: 0xDE4E78
	public JsonPropertyCollection get_Properties() { }

	// RVA: 0xDE4E80
	public System.Func<System.String,System.String> get_PropertyNameResolver() { }

	// RVA: 0xDE4E88
	public void set_PropertyNameResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xDE4E90
	private static System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>> CreateCallSiteGetter(string name) { }

	// RVA: 0xDE4FBC
	private static System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>> CreateCallSiteSetter(string name) { }

	// RVA: 0xDE50E8
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDE546C
	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }

	// RVA: 0xDE558C
	internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class JsonFormatterConverter
{
	// Fields
	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	private readonly JsonProperty _member; // 0x20

	// Methods

	// RVA: 0xDE569C
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x318DB98
	private T GetTokenValue(object value) { }

	// RVA: 0xDE5770
	public object Convert(object value, Type type) { }

	// RVA: 0xDE5A74
	public bool ToBoolean(object value) { }

	// RVA: 0xDE5AE4
	public int ToInt32(object value) { }

	// RVA: 0xDE5B54
	public Int64 ToInt64(object value) { }

	// RVA: 0xDE5BC4
	public float ToSingle(object value) { }

	// RVA: 0xDE5C34
	public string ToString(object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonISerializableContract
{
	// Fields
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <ISerializableCreator>k__BackingField; // 0xC0

	// Methods

	// RVA: 0xDE5CA4
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ISerializableCreator() { }

	// RVA: 0xDE5CAC
	public void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDE5CB4
	public void .ctor(Type underlyingType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonLinqContract
{
	// Methods

	// RVA: 0xDE5CDC
	public void .ctor(Type underlyingType) { }

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

	// RVA: 0xDE5D04
	public MemberSerialization get_MemberSerialization() { }

	// RVA: 0xDE5D0C
	public void set_MemberSerialization(MemberSerialization value) { }

	// RVA: 0xDE5D14
	public System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling() { }

	// RVA: 0xDE5D1C
	public void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value) { }

	// RVA: 0xDE5D24
	public System.Nullable<Newtonsoft.Json.Required> get_ItemRequired() { }

	// RVA: 0xDE5D2C
	public void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value) { }

	// RVA: 0xDE5D34
	public System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling() { }

	// RVA: 0xDE5D3C
	public void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }

	// RVA: 0xDE5D44
	public JsonPropertyCollection get_Properties() { }

	// RVA: 0xDE5D4C
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0xDE5DE8
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xDE5DF0
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDE5E00
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xDE5E08
	internal void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDE5E18
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	// RVA: 0xDE5E20
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	// RVA: 0xDE5E28
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	// RVA: 0xDE5E30
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0xDE5E38
	public void set_ExtensionDataValueType(Type value) { }

	// RVA: 0xDE5F38
	public System.Func<System.String,System.String> get_ExtensionDataNameResolver() { }

	// RVA: 0xDE5F40
	public void set_ExtensionDataNameResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xDE5F48
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	// RVA: 0xDE6710
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDE6798
	internal object GetUninitializedObject() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonPrimitiveContract
{
	// Fields
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x8C
	private static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.ReadType> ReadTypeMap; // 0x0

	// Methods

	// RVA: 0xDE68D8
	internal PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0xDE68E0
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0xDE68E8
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDE69E8
	private static void .cctor() { }

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

	// RVA: 0xDE6DB0
	internal JsonContract get_PropertyContract() { }

	// RVA: 0xDE6DB8
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0xDE6DC0
	public string get_PropertyName() { }

	// RVA: 0xDE6DC8
	public void set_PropertyName(string value) { }

	// RVA: 0xDE6E60
	public Type get_DeclaringType() { }

	// RVA: 0xDE6E68
	public void set_DeclaringType(Type value) { }

	// RVA: 0xDE6E70
	public System.Nullable<System.Int32> get_Order() { }

	// RVA: 0xDE6E78
	public void set_Order(System.Nullable<System.Int32> value) { }

	// RVA: 0xDE6E80
	public string get_UnderlyingName() { }

	// RVA: 0xDE6E88
	public void set_UnderlyingName(string value) { }

	// RVA: 0xDE6E90
	public IValueProvider get_ValueProvider() { }

	// RVA: 0xDE6E98
	public void set_ValueProvider(IValueProvider value) { }

	// RVA: 0xDE6EA0
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0xDE6EA8
	public Type get_PropertyType() { }

	// RVA: 0xDE6EB0
	public void set_PropertyType(Type value) { }

	// RVA: 0xDE6F84
	public JsonConverter get_Converter() { }

	// RVA: 0xDE6F8C
	public void set_Converter(JsonConverter value) { }

	// RVA: 0xDE6F94
	public bool get_Ignored() { }

	// RVA: 0xDE6F9C
	public void set_Ignored(bool value) { }

	// RVA: 0xDE6FA4
	public bool get_Readable() { }

	// RVA: 0xDE6FAC
	public void set_Readable(bool value) { }

	// RVA: 0xDE6FB4
	public bool get_Writable() { }

	// RVA: 0xDE6FBC
	public void set_Writable(bool value) { }

	// RVA: 0xDE6FC4
	public bool get_HasMemberAttribute() { }

	// RVA: 0xDE6FCC
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0xDE6FD4
	public object get_DefaultValue() { }

	// RVA: 0xDE6FEC
	public void set_DefaultValue(object value) { }

	// RVA: 0xDE6FFC
	internal object GetResolvedDefaultValue() { }

	// RVA: 0xDE6638
	public Required get_Required() { }

	// RVA: 0xDE70DC
	public System.Nullable<System.Boolean> get_IsReference() { }

	// RVA: 0xDE70E4
	public void set_IsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDE70EC
	public System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling() { }

	// RVA: 0xDE70F4
	public void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }

	// RVA: 0xDE70FC
	public System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling() { }

	// RVA: 0xDE7104
	public void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value) { }

	// RVA: 0xDE710C
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	// RVA: 0xDE7114
	public void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xDE711C
	public System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling() { }

	// RVA: 0xDE7124
	public void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value) { }

	// RVA: 0xDE712C
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling() { }

	// RVA: 0xDE7134
	public void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xDE713C
	public System.Predicate<System.Object> get_ShouldSerialize() { }

	// RVA: 0xDE7144
	public void set_ShouldSerialize(System.Predicate<System.Object> value) { }

	// RVA: 0xDE714C
	public System.Predicate<System.Object> get_ShouldDeserialize() { }

	// RVA: 0xDE7154
	public System.Predicate<System.Object> get_GetIsSpecified() { }

	// RVA: 0xDE715C
	public void set_GetIsSpecified(System.Predicate<System.Object> value) { }

	// RVA: 0xDE7164
	public System.Action<System.Object,System.Object> get_SetIsSpecified() { }

	// RVA: 0xDE716C
	public void set_SetIsSpecified(System.Action<System.Object,System.Object> value) { }

	// RVA: 0xDE7174
	public override string ToString() { }

	// RVA: 0xDE71E0
	public JsonConverter get_ItemConverter() { }

	// RVA: 0xDE71E8
	public void set_ItemConverter(JsonConverter value) { }

	// RVA: 0xDE71F0
	public System.Nullable<System.Boolean> get_ItemIsReference() { }

	// RVA: 0xDE71F8
	public void set_ItemIsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDE7200
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }

	// RVA: 0xDE7208
	public void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xDE7210
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	// RVA: 0xDE7218
	public void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xDE7220
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0xDE7278
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonPropertyCollection
{
	// Fields
	private readonly Type _type; // 0x30
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list; // 0x38

	// Methods

	// RVA: 0xDE52B0
	public void .ctor(Type type) { }

	// RVA: 0xDE7280
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0xDE729C
	public void AddProperty(JsonProperty property) { }

	// RVA: 0xDE757C
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0xDE7718
	private bool TryGetProperty(string key, JsonProperty item) { }

	// RVA: 0xDE761C
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

}

// Namespace: 
private class ReferenceEqualsEqualityComparer
{
	// Methods

	// RVA: 0xDE80D0
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	// RVA: 0xDE80DC
	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	// RVA: 0xDE78A4
	public void .ctor() { }

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

	// RVA: 0xDE7804
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0xDDF7A0
	internal Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> get_DefaultReferenceMappings() { }

	// RVA: 0xDE78AC
	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0xDE7AF0
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0xDE7C20
	protected void ClearErrorContext() { }

	// RVA: 0xDE7C90
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

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

	// RVA: 0xDF5C10
	public void .ctor(string name) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Newtonsoft.Json.Serialization.JsonSerializerInternalReader.<>c <>9; // 0x0
	public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,System.String> <>9__38_0; // 0x8
	public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,System.String> <>9__38_2; // 0x10
	public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonProperty> <>9__42_0; // 0x18
	public static System.Func<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> <>9__42_1; // 0x20

	// Methods

	// RVA: 0xDF688C
	private static void .cctor() { }

	// RVA: 0xDF68F8
	public void .ctor() { }

	// RVA: 0xDF6900
	internal string <CreateObjectUsingCreatorWithParameters>b__38_0(JsonProperty p) { }

	// RVA: 0xDF691C
	internal string <CreateObjectUsingCreatorWithParameters>b__38_2(JsonProperty p) { }

	// RVA: 0xDF6938
	internal JsonProperty <PopulateObject>b__42_0(JsonProperty m) { }

	// RVA: 0xDF6940
	internal PropertyPresence <PopulateObject>b__42_1(JsonProperty m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass38_0
{
	// Fields
	public JsonProperty property; // 0x10

	// Methods

	// RVA: 0xDF5C08
	public void .ctor() { }

	// RVA: 0xDF6948
	internal bool <CreateObjectUsingCreatorWithParameters>b__1(CreatorPropertyContext p) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class JsonSerializerInternalReader
{
	// Methods

	// RVA: 0xDE80E8
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0xDE80EC
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xDEAC2C
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0xDEACDC
	private JsonContract GetContract(Type type) { }

	// RVA: 0xDEAD98
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0xDEBC20
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0xDEBCC0
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0xDEC0C0
	private JToken CreateJObject(JsonReader reader) { }

	// RVA: 0xDEB6B8
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0xDEDD40
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0xDEDE94
	internal string GetExpectedDescription(JsonContract contract) { }

	// RVA: 0xDEB198
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDEC548
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0xDEDF50
	private bool ReadMetadataPropertiesToken(JTokenReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, object newValue, string id) { }

	// RVA: 0xDEE6B8
	private bool ReadMetadataProperties(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, object newValue, string id) { }

	// RVA: 0xDF03E8
	private void ResolveTypeName(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0xDF0C88
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	// RVA: 0xDECF4C
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	// RVA: 0xDEECB0
	private bool HasNoDefinedType(JsonContract contract) { }

	// RVA: 0xDED72C
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0xDF1924
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	// RVA: 0xDF1E24
	private bool CalculatePropertyDetails(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, bool useExistingValue, object currentValue, JsonContract propertyContract, bool gottenCurrentValue, bool ignoredValue) { }

	// RVA: 0xDF2600
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0xDF25F4
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xDF24BC
	private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	// RVA: 0xDF0E0C
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, bool createdFromNonDefaultCreator) { }

	// RVA: 0xDEF094
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, bool createdFromNonDefaultCreator) { }

	// RVA: 0xDF29E0
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0xDF2C1C
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0xDE8CE8
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xDF1154
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xDF2E58
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0xDE8640
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xDEFC8C
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0xDE5894
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0xDEF380
	private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	// RVA: 0xDF2FF0
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator, string id) { }

	// RVA: 0xDEB228
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0xDF51C8
	private System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0xDEEDB0
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, bool createdFromNonDefaultCreator) { }

	// RVA: 0xDE99C0
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0xDF6500
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0xDEC41C
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0xDF62F4
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0xDF6228
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0xDF5C44
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0xDF6774
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0xDEBB54
	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class JsonSerializerInternalWriter
{
	// Fields
	private Type _rootType; // 0x38
	private int _rootLevel; // 0x40
	private readonly System.Collections.Generic.List<System.Object> _serializeStack; // 0x48

	// Methods

	// RVA: 0xDF6970
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0xDF6A08
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xDF798C
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0xDF6CE0
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0xDF7A2C
	private JsonContract GetContract(object value) { }

	// RVA: 0xDF7AFC
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDF71F8
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDFB228
	private System.Nullable<System.Boolean> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDF6CF0
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDFB374
	private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0xDFB47C
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDF6F68
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0xDFB924
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0xDFBB20
	internal static bool TryConvertToString(object value, Type type, string s) { }

	// RVA: 0xDF9C18
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0xDFBC6C
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0xDFBE88
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0xDF88E4
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDFC294
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, JsonContract memberContract, object memberValue) { }

	// RVA: 0xDFC0A4
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDFD18C
	private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	// RVA: 0xDFD2C4
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0xDF80F8
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0xDFB470
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xDFB368
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0xDFD51C
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0xDF8384
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDF939C
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDF9A2C
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDFD8D8
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0xDFD528
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDFADD0
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDFA570
	private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDFDC70
	private bool ShouldWriteDynamicProperty(object memberValue) { }

	// RVA: 0xDF7C74
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDF9CA8
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDFC74C
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, bool escape) { }

	// RVA: 0xDF78BC
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0xDFCCAC
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0xDFCF1C
	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class JsonSerializerProxy
{
	// Fields
	private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
	private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
	internal readonly JsonSerializer _serializer; // 0xF0

	// Methods

	// RVA: 0xDFDD40
	public override void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDFDD64
	public override void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDFDD88
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xDFDDAC
	public override ITraceWriter get_TraceWriter() { }

	// RVA: 0xDFDDD0
	public override void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0xDFDDF4
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xDFDE18
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0xDFDE40
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0xDFDE68
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0xDFDE90
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xDFDEB8
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xDFDEE0
	public override NullValueHandling get_NullValueHandling() { }

	// RVA: 0xDFDF08
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xDFDF30
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xDFDF58
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xDFDF80
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xDFDFA8
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xDFDFCC
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xDFDFF4
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xDFE01C
	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0xDFE040
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0xDFE068
	public override void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0xDFE08C
	public override StreamingContext get_Context() { }

	// RVA: 0xDFE0B4
	public override void set_Context(StreamingContext value) { }

	// RVA: 0xDFE0DC
	public override Formatting get_Formatting() { }

	// RVA: 0xDFE104
	public override System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xDFE12C
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0xDFE154
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xDFE17C
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0xDFE198
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0xDFE228
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	// RVA: 0xDFE2B8
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xDFE2F4
	internal override void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0xDFE32C
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonStringContract
{
	// Methods

	// RVA: 0xDFE364
	public void .ctor(Type underlyingType) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Newtonsoft.Json.Serialization.JsonTypeReflector.<>c <>9; // 0x0
	public static System.Func<System.Object,System.Type> <>9__22_1; // 0x8

	// Methods

	// RVA: 0xDFFBA0
	private static void .cctor() { }

	// RVA: 0xDFFC0C
	public void .ctor() { }

	// RVA: 0xDFFC14
	internal Type <GetCreator>b__22_1(object param) { }

}

// Namespace: 
private sealed class <>c__DisplayClass22_0
{
	// Fields
	public Type type; // 0x10
	public System.Func<System.Object> defaultConstructor; // 0x18

	// Methods

	// RVA: 0xDFF334
	public void .ctor() { }

	// RVA: 0xDFFC78
	internal object <GetCreator>b__0(object[] parameters) { }

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

	// RVA: 0x318DB98
	public static T GetCachedAttribute(object attributeProvider) { }

	// RVA: 0xDFE3DC
	public static bool CanTypeDescriptorConvertString(Type type, TypeConverter typeConverter) { }

	// RVA: 0xDFE5DC
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0xDFE6E8
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0xDFE9E4
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0xDFEC2C
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0xDFEDA8
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] args) { }

	// RVA: 0xDFEED0
	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[] args) { }

	// RVA: 0xDFEFF8
	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	// RVA: 0xDFF0E0
	private static System.Func<System.Object[],System.Object> GetCreator(Type type) { }

	// RVA: 0xDFF400
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0xDFF4B8
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: 0x318DB98
	private static T GetAttribute(Type type) { }

	// RVA: 0x318DB98
	private static T GetAttribute(MemberInfo memberInfo) { }

	// RVA: 0xDFF75C
	public static bool IsNonSerializable(object provider) { }

	// RVA: 0xDFEBA4
	public static bool IsSerializable(object provider) { }

	// RVA: 0x318DB98
	public static T GetAttribute(object provider) { }

	// RVA: 0xDFF7E4
	public static bool get_FullyTrusted() { }

	// RVA: 0xDFF33C
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0xDFFA14
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class KebabCaseNamingStrategy
{
	// Methods

	// RVA: 0xE00188
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xE001CC
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xE00210
	public void .ctor() { }

	// RVA: 0xE00218
	protected override string ResolvePropertyName(string name) { }

}

// Namespace: Newtonsoft.Json.Serialization
public abstract class NamingStrategy
{
	// Fields
	private bool <ProcessDictionaryKeys>k__BackingField; // 0x10
	private bool <ProcessExtensionDataNames>k__BackingField; // 0x11
	private bool <OverrideSpecifiedNames>k__BackingField; // 0x12

	// Methods

	// RVA: 0xE00224
	public bool get_ProcessDictionaryKeys() { }

	// RVA: 0xE0022C
	public void set_ProcessDictionaryKeys(bool value) { }

	// RVA: 0xE00234
	public bool get_ProcessExtensionDataNames() { }

	// RVA: 0xE0023C
	public void set_ProcessExtensionDataNames(bool value) { }

	// RVA: 0xE00244
	public bool get_OverrideSpecifiedNames() { }

	// RVA: 0xE0024C
	public void set_OverrideSpecifiedNames(bool value) { }

	// RVA: 0xE00254
	public virtual string GetPropertyName(string name, bool hasSpecifiedName) { }

	// RVA: 0xE00274
	public virtual string GetExtensionDataName(string name) { }

	// RVA: 0xE00290
	public virtual string GetDictionaryKey(string key) { }

	// RVA: -1
	protected abstract string ResolvePropertyName(string name) { }

	// RVA: 0xE002AC
	public override int GetHashCode() { }

	// RVA: 0xE00394
	public override bool Equals(object obj) { }

	// RVA: 0xE00430
	protected bool Equals(NamingStrategy other) { }

	// RVA: 0xE001C4
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ObjectConstructor<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x30D3DA0
	public virtual object Invoke(object[] args) { }

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

	// RVA: 0xE0056C
	public void .ctor(object attributeProvider) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class ReflectionValueProvider
{
	// Fields
	private readonly MemberInfo _memberInfo; // 0x10

	// Methods

	// RVA: 0xE005E4
	public void .ctor(MemberInfo memberInfo) { }

	// RVA: 0xE0065C
	public void SetValue(object target, object value) { }

	// RVA: 0xE00808
	public object GetValue(object target) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class SnakeCaseNamingStrategy
{
	// Methods

	// RVA: 0xE00AC8
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xE00B04
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xE00B48
	public void .ctor() { }

	// RVA: 0xE00B50
	protected override string ResolvePropertyName(string name) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class TraceJsonReader
{
	// Fields
	private readonly JsonReader _innerReader; // 0x78
	private readonly JsonTextWriter _textWriter; // 0x80
	private readonly StringWriter _sw; // 0x88

	// Methods

	// RVA: 0xE00B5C
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0xE00CCC
	public string GetDeserializedJsonMessage() { }

	// RVA: 0xE00CF0
	public override bool Read() { }

	// RVA: 0xE00D90
	public override System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xE00DF4
	public override string ReadAsString() { }

	// RVA: 0xE00E58
	public override Byte[] ReadAsBytes() { }

	// RVA: 0xE00EC0
	public override System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xE00F6C
	public override System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xE00FE4
	public override System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xE0104C
	public override System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xE010C4
	public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xE00D54
	public void WriteCurrentToken() { }

	// RVA: 0xE01144
	public override int get_Depth() { }

	// RVA: 0xE01168
	public override string get_Path() { }

	// RVA: 0xE0118C
	public override JsonToken get_TokenType() { }

	// RVA: 0xE011B0
	public override object get_Value() { }

	// RVA: 0xE011D4
	public override Type get_ValueType() { }

	// RVA: 0xE011F8
	public override void Close() { }

	// RVA: 0xE01220
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE012F8
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE013D4
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class TraceJsonWriter
{
	// Fields
	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70

	// Methods

	// RVA: 0xE014B0
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0xE016BC
	public string GetSerializedJsonMessage() { }

	// RVA: 0xE016E0
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE01758
	public override void WriteValue(System.Nullable<System.Decimal> value) { }

	// RVA: 0xE0191C
	public override void WriteValue(bool value) { }

	// RVA: 0xE01980
	public override void WriteValue(System.Nullable<System.Boolean> value) { }

	// RVA: 0xE01B10
	public override void WriteValue(Byte value) { }

	// RVA: 0xE01B74
	public override void WriteValue(System.Nullable<System.Byte> value) { }

	// RVA: 0xE01D04
	public override void WriteValue(Char value) { }

	// RVA: 0xE01D68
	public override void WriteValue(System.Nullable<System.Char> value) { }

	// RVA: 0xE01EF8
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xE01F70
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE01FD4
	public override void WriteValue(System.Nullable<System.DateTime> value) { }

	// RVA: 0xE0216C
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE021E4
	public override void WriteValue(System.Nullable<System.DateTimeOffset> value) { }

	// RVA: 0xE0238C
	public override void WriteValue(Double value) { }

	// RVA: 0xE023F8
	public override void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xE02590
	public override void WriteUndefined() { }

	// RVA: 0xE025E8
	public override void WriteNull() { }

	// RVA: 0xE02640
	public override void WriteValue(float value) { }

	// RVA: 0xE026AC
	public override void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xE02838
	public override void WriteValue(Guid value) { }

	// RVA: 0xE028B0
	public override void WriteValue(System.Nullable<System.Guid> value) { }

	// RVA: 0xE02A58
	public override void WriteValue(int value) { }

	// RVA: 0xE02ABC
	public override void WriteValue(System.Nullable<System.Int32> value) { }

	// RVA: 0xE02C48
	public override void WriteValue(Int64 value) { }

	// RVA: 0xE02CAC
	public override void WriteValue(System.Nullable<System.Int64> value) { }

	// RVA: 0xE02E44
	public override void WriteValue(object value) { }

	// RVA: 0xE02F5C
	public override void WriteValue(SByte value) { }

	// RVA: 0xE02FC0
	public override void WriteValue(System.Nullable<System.SByte> value) { }

	// RVA: 0xE03150
	public override void WriteValue(Int16 value) { }

	// RVA: 0xE031B4
	public override void WriteValue(System.Nullable<System.Int16> value) { }

	// RVA: 0xE03344
	public override void WriteValue(string value) { }

	// RVA: 0xE033A8
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE0340C
	public override void WriteValue(System.Nullable<System.TimeSpan> value) { }

	// RVA: 0xE035A4
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xE03608
	public override void WriteValue(System.Nullable<System.UInt32> value) { }

	// RVA: 0xE03794
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xE037F8
	public override void WriteValue(System.Nullable<System.UInt64> value) { }

	// RVA: 0xE03990
	public override void WriteValue(Uri value) { }

	// RVA: 0xE03A78
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xE03ADC
	public override void WriteValue(System.Nullable<System.UInt16> value) { }

	// RVA: 0xE03C6C
	public override void WriteComment(string text) { }

	// RVA: 0xE03CD0
	public override void WriteStartArray() { }

	// RVA: 0xE03D20
	public override void WriteEndArray() { }

	// RVA: 0xE03D70
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE03DCC
	public override void WriteEndConstructor() { }

	// RVA: 0xE03E1C
	public override void WritePropertyName(string name) { }

	// RVA: 0xE03E80
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xE03EF4
	public override void WriteStartObject() { }

	// RVA: 0xE03F44
	public override void WriteEndObject() { }

	// RVA: 0xE03F94
	public override void WriteRawValue(string json) { }

	// RVA: 0xE03FF8
	public override void WriteRaw(string json) { }

	// RVA: 0xE0405C
	public override void Close() { }

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

	// RVA: 0xE040AC
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xE040B4
	public override JTokenType get_Type() { }

	// RVA: 0xE040BC
	public void .ctor() { }

	// RVA: 0xE0422C
	internal void .ctor(JArray other, JsonCloneSettings settings) { }

	// RVA: 0xE04674
	public void .ctor(object content) { }

	// RVA: 0xE0475C
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xE04834
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE04D3C
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE04E28
	public JToken get_Item(int index) { }

	// RVA: 0xE04E38
	public void set_Item(int index, JToken value) { }

	// RVA: 0xE04E48
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE04EBC
	public int IndexOf(JToken item) { }

	// RVA: 0xE04ECC
	public void Insert(int index, JToken item) { }

	// RVA: 0xE04EE4
	public void RemoveAt(int index) { }

	// RVA: 0xE04EF4
	public System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }

	// RVA: 0xE04F90
	public void Add(JToken item) { }

	// RVA: 0xE04FA0
	public void Clear() { }

	// RVA: 0xE04FB0
	public bool Contains(JToken item) { }

	// RVA: 0xE04FC0
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xE04FD0
	public bool get_IsReadOnly() { }

	// RVA: 0xE04FD8
	public bool Remove(JToken item) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JConstructor
{
	// Fields
	private string _name; // 0x58
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values; // 0x60

	// Methods

	// RVA: 0xE04FE8
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xE04FF0
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE05064
	public string get_Name() { }

	// RVA: 0xE0506C
	public override JTokenType get_Type() { }

	// RVA: 0xE05074
	internal void .ctor(JConstructor other, JsonCloneSettings settings) { }

	// RVA: 0xE0512C
	public void .ctor(string name) { }

	// RVA: 0xE052D8
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xE05344
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE0543C
	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }

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

	// RVA: 0xE05634
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xE056E8
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: -1
	protected abstract System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xE041A4
	internal void .ctor() { }

	// RVA: 0xE042CC
	internal void .ctor(JContainer other, JsonCloneSettings settings) { }

	// RVA: 0xE05BD8
	internal void CheckReentrancy() { }

	// RVA: 0xE05C84
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0xE05CA8
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xE05D38
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	// RVA: 0xE05DC8
	public override bool get_HasValues() { }

	// RVA: 0xE05E8C
	public override JToken get_First() { }

	// RVA: 0xE05FF0
	public override JToken get_Last() { }

	// RVA: 0xE06154
	public override Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }

	// RVA: 0xE061D4
	internal bool IsMultiContent(object content) { }

	// RVA: 0xE062D0
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: -1
	internal abstract int IndexOfItem(JToken item) { }

	// RVA: 0xE064A8
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xE06910
	internal virtual void RemoveItemAt(int index) { }

	// RVA: 0xE06E14
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0xE06E7C
	internal virtual JToken GetItem(int index) { }

	// RVA: 0xE06F44
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0xE07664
	internal virtual void ClearItems() { }

	// RVA: 0xE07AA8
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	// RVA: 0xE07B10
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0xE07B38
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0xE0759C
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0xE080CC
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE081EC
	public virtual void Add(object content) { }

	// RVA: 0xE082C8
	internal bool TryAdd(object content) { }

	// RVA: 0xE083A4
	internal void AddAndSkipParentCheck(JToken token) { }

	// RVA: 0xE05858
	internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xE08480
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0xE0863C
	public void RemoveAll() { }

	// RVA: 0xE04BDC
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0xE0864C
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	// RVA: 0xE08E30
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	// RVA: 0xE093AC
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xE093F8
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xE095A8
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0xE095B8
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0xE095D0
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0xE095E0
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0xE095F0
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0xE09600
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0xE09610
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0xE09620
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0xE09630
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xE09640
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0xE09648
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	// RVA: 0xE09658
	private JToken EnsureValue(object value) { }

	// RVA: 0xE09718
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xE097F8
	private void System.Collections.IList.Clear() { }

	// RVA: 0xE09808
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xE09840
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xE09878
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xE098CC
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xE098D4
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xE098DC
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xE09914
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xE09924
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xE09934
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xE09980
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xE08004
	public int get_Count() { }

	// RVA: 0xE09990
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xE09998
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xE09A24
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xE09A28
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xE09BF4
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xE09BFC
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xE09C04
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xE09C0C
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xE09C4C
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xE09C8C
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xE09C94
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xE09C98
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xE09CD8
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xE09CE0
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xE09CE8
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xE09CF0
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xE09CF8
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

}

// Namespace: Newtonsoft.Json.Linq
public struct JEnumerable<T0>
{
	// Fields
	public static readonly Newtonsoft.Json.Linq.JEnumerable<T> Empty; // 0x0
	private readonly System.Collections.Generic.IEnumerable<T> _enumerable; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IEnumerable<T> enumerable) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x318DB98
	public bool Equals(Newtonsoft.Json.Linq.JEnumerable<T> other) { }

	// RVA: 0x30D3858
	public override bool Equals(object obj) { }

	// RVA: 0x30D39B8
	public override int GetHashCode() { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Newtonsoft.Json.Linq.JObject.JObjectDynamicProxy.<>c <>9; // 0x0
	public static System.Func<Newtonsoft.Json.Linq.JProperty,System.String> <>9__2_0; // 0x8

	// Methods

	// RVA: 0xE0CEB0
	private static void .cctor() { }

	// RVA: 0xE0CF1C
	public void .ctor() { }

	// RVA: 0xE0CF24
	internal string <GetDynamicMemberNames>b__2_0(JProperty p) { }

}

// Namespace: 
private class JObjectDynamicProxy
{
	// Methods

	// RVA: 0xE0CB64
	public override bool TryGetMember(JObject instance, GetMemberBinder binder, object result) { }

	// RVA: 0xE0CC14
	public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value) { }

	// RVA: 0xE0CD54
	public override System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(JObject instance) { }

	// RVA: 0xE0CB10
	public void .ctor() { }

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

	// RVA: 0xE0C0A4
	public void .ctor(int <>1__state) { }

	// RVA: 0xE0CF40
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE0D014
	private bool MoveNext() { }

	// RVA: 0xE0D3A8
	private void <>m__Finally1() { }

	// RVA: 0xE0D46C
	private System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	// RVA: 0xE0D478
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xE0D4B8
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JObject
{
	// Fields
	private readonly JPropertyKeyedCollection _properties; // 0x58
	private PropertyChangedEventHandler PropertyChanged; // 0x60
	private PropertyChangingEventHandler PropertyChanging; // 0x68

	// Methods

	// RVA: 0xE09D00
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xE09D08
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xE09DAC
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xE09E50
	public void add_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0xE09EF4
	public void remove_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0xE08BA0
	public void .ctor() { }

	// RVA: 0xE0A034
	public void .ctor(JObject other) { }

	// RVA: 0xE0A130
	internal void .ctor(JObject other, JsonCloneSettings settings) { }

	// RVA: 0xE0A230
	public void .ctor(object[] content) { }

	// RVA: 0xE0A234
	public void .ctor(object content) { }

	// RVA: 0xE0A37C
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE0A4FC
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xE0A588
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE0A890
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0xE0A9D8
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0xE0AA00
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xE0AA6C
	public override JTokenType get_Type() { }

	// RVA: 0xE0AA74
	public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties() { }

	// RVA: 0xE0906C
	public JProperty Property(string name, StringComparison comparison) { }

	// RVA: 0xE0AAC8
	public JToken get_Item(string propertyName) { }

	// RVA: 0xE0AB4C
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0xE0ADA0
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE0AF70
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE0AD18
	public void Add(string propertyName, JToken value) { }

	// RVA: 0xE0B22C
	public bool ContainsKey(string propertyName) { }

	// RVA: 0xE0B358
	private System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0xE0B414
	public bool Remove(string propertyName) { }

	// RVA: 0xE0B520
	public bool TryGetValue(string propertyName, JToken value) { }

	// RVA: 0xE0B578
	private System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0xE0B5B8
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xE0B774
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0xE0B784
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xE0B914
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>[] array, int arrayIndex) { }

	// RVA: 0xE0BE40
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0xE0BE48
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xE0C02C
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>> GetEnumerator() { }

	// RVA: 0xE0C0D0
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0xE0C164
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0xE0C1F8
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xE0C2A0
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xE0C79C
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xE0C818
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xE0C820
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xE0C828
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xE0C880
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xE0C888
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xE0C890
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xE0C898
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xE0C914
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xE0C990
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xE0CA24
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

}

// Namespace: 
private sealed class <GetEnumerator>d__1
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	public JPropertyList <>4__this; // 0x20

	// Methods

	// RVA: 0xE0DF24
	public void .ctor(int <>1__state) { }

	// RVA: 0xE0E1AC
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE0E1B0
	private bool MoveNext() { }

	// RVA: 0xE0E22C
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	// RVA: 0xE0E234
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xE0E274
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private class JPropertyList
{
	// Fields
	internal JToken _token; // 0x10

	// Methods

	// RVA: 0xE0DEAC
	public System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }

	// RVA: 0xE0DF50
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xE0DFC8
	public void Add(JToken item) { }

	// RVA: 0xE0DFD0
	public void Clear() { }

	// RVA: 0xE0DFDC
	public bool Contains(JToken item) { }

	// RVA: 0xE0DFEC
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xE0E070
	public bool Remove(JToken item) { }

	// RVA: 0xE0E0C0
	public int get_Count() { }

	// RVA: 0xE0E0D0
	public bool get_IsReadOnly() { }

	// RVA: 0xE0D998
	public int IndexOf(JToken item) { }

	// RVA: 0xE0E0D8
	public void Insert(int index, JToken item) { }

	// RVA: 0xE0E0EC
	public void RemoveAt(int index) { }

	// RVA: 0xE0E100
	public JToken get_Item(int index) { }

	// RVA: 0xE0E154
	public void set_Item(int index, JToken value) { }

	// RVA: 0xE0D5D4
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JProperty
{
	// Fields
	private readonly JPropertyList _content; // 0x58
	private readonly string _name; // 0x60

	// Methods

	// RVA: 0xE0D520
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xE0D528
	public string get_Name() { }

	// RVA: 0xE08B80
	public JToken get_Value() { }

	// RVA: 0xE0AC94
	public void set_Value(JToken value) { }

	// RVA: 0xE0D530
	internal void .ctor(JProperty other, JsonCloneSettings settings) { }

	// RVA: 0xE0D5DC
	internal override JToken GetItem(int index) { }

	// RVA: 0xE0D63C
	internal override void SetItem(int index, JToken item) { }

	// RVA: 0xE0D800
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0xE0D8B0
	internal override void RemoveItemAt(int index) { }

	// RVA: 0xE0D960
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE0D9A8
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xE0DAD8
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0xE0DB00
	internal override void ClearItems() { }

	// RVA: 0xE0DBB0
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xE0DC1C
	public override JTokenType get_Type() { }

	// RVA: 0xE09248
	internal void .ctor(string name) { }

	// RVA: 0xE0B070
	public void .ctor(string name, object content) { }

	// RVA: 0xE0DC24
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE0DCB4
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JPropertyDescriptor
{
	// Methods

	// RVA: 0xE0C790
	public void .ctor(string name) { }

	// RVA: 0xE0E27C
	public override bool CanResetValue(object component) { }

	// RVA: 0xE0E284
	public override object GetValue(object component) { }

	// RVA: 0xE0E39C
	public override void ResetValue(object component) { }

	// RVA: 0xE0E3A0
	public override void SetValue(object component, object value) { }

	// RVA: 0xE0E538
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xE0E540
	public override Type get_ComponentType() { }

	// RVA: 0xE0E5E0
	public override bool get_IsReadOnly() { }

	// RVA: 0xE0E5E8
	public override Type get_PropertyType() { }

	// RVA: 0xE0E688
	protected override int get_NameHashCode() { }

}

// Namespace: Newtonsoft.Json.Linq
internal class JPropertyKeyedCollection
{
	// Fields
	private static readonly System.Collections.Generic.IEqualityComparer<System.String> Comparer; // 0x0
	private System.Collections.Generic.Dictionary<System.String,Newtonsoft.Json.Linq.JToken> _dictionary; // 0x18

	// Methods

	// RVA: 0xE09F98
	public void .ctor() { }

	// RVA: 0xE0E690
	private void AddKey(string key, JToken item) { }

	// RVA: 0xE0E7D0
	protected override void ClearItems() { }

	// RVA: 0xE0B29C
	public bool Contains(string key) { }

	// RVA: 0xE0E704
	private void EnsureDictionary() { }

	// RVA: 0xE0E858
	private string GetKeyForItem(JToken item) { }

	// RVA: 0xE0E8DC
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0xE0EA0C
	protected override void RemoveItem(int index) { }

	// RVA: 0xE0EB94
	private void RemoveKey(string key) { }

	// RVA: 0xE0EC04
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0xE0A804
	public bool TryGetValue(string key, JToken value) { }

	// RVA: 0xE0B3B8
	public System.Collections.Generic.ICollection<System.String> get_Keys() { }

	// RVA: 0xE0A44C
	public int IndexOfReference(JToken t) { }

	// RVA: 0xE0EF4C
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JRaw
{
	// Methods

	// RVA: 0xE0F030
	internal void .ctor(JRaw other, JsonCloneSettings settings) { }

	// RVA: 0xE0F158
	public void .ctor(object rawJson) { }

	// RVA: 0xE0F268
	public static JRaw Create(JsonReader reader) { }

	// RVA: 0xE0F5B4
	internal override JToken CloneToken(JsonCloneSettings settings) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JsonCloneSettings
{
	// Fields
	internal static readonly JsonCloneSettings SkipCopyAnnotations; // 0x0
	private bool <CopyAnnotations>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE0F620
	public void .ctor() { }

	// RVA: 0xE0F64C
	public bool get_CopyAnnotations() { }

	// RVA: 0xE0F654
	public void set_CopyAnnotations(bool value) { }

	// RVA: 0xE0F65C
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JsonLoadSettings
{
	// Fields
	private CommentHandling _commentHandling; // 0x10
	private LineInfoHandling _lineInfoHandling; // 0x14
	private DuplicatePropertyNameHandling _duplicatePropertyNameHandling; // 0x18

	// Methods

	// RVA: 0xE0F6CC
	public CommentHandling get_CommentHandling() { }

	// RVA: 0xE0F6D4
	public LineInfoHandling get_LineInfoHandling() { }

	// RVA: 0xE0F6DC
	public DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }

}

// Namespace: 
private class LineInfoAnnotation
{
	// Fields
	internal readonly int LineNumber; // 0x10
	internal readonly int LinePosition; // 0x14

	// Methods

	// RVA: 0xE17F28
	public void .ctor(int lineNumber, int linePosition) { }

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

	// RVA: 0xE0F6E4
	public JContainer get_Parent() { }

	// RVA: 0xE0F6EC
	internal void set_Parent(JContainer value) { }

	// RVA: 0xE06490
	public JToken get_Root() { }

	// RVA: -1
	internal abstract JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: -1
	public abstract JTokenType get_Type() { }

	// RVA: -1
	public abstract bool get_HasValues() { }

	// RVA: 0xE0F6F4
	public JToken get_Next() { }

	// RVA: 0xE0F6FC
	internal void set_Next(JToken value) { }

	// RVA: 0xE0F704
	public JToken get_Previous() { }

	// RVA: 0xE0F70C
	internal void set_Previous(JToken value) { }

	// RVA: 0xE0F714
	public string get_Path() { }

	// RVA: 0xE0579C
	internal void .ctor() { }

	// RVA: 0xE0FA24
	public virtual JToken get_First() { }

	// RVA: 0xE0FAB8
	public virtual JToken get_Last() { }

	// RVA: 0xE0FB4C
	public virtual Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }

	// RVA: 0xE0B4A8
	public void Remove() { }

	// RVA: 0xE09330
	public void Replace(JToken value) { }

	// RVA: -1
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE0FBC8
	public override string ToString() { }

	// RVA: 0xE0FCB0
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0xE0FED4
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0xE1000C
	private static string GetType(JToken token) { }

	// RVA: 0xE10108
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0xE101E8
	public static bool op_Explicit(JToken value) { }

	// RVA: 0xE10490
	public static DateTimeOffset op_Explicit(JToken value) { }

	// RVA: 0xE10764
	public static System.Nullable<System.Boolean> op_Explicit(JToken value) { }

	// RVA: 0xE10A50
	public static Int64 op_Explicit(JToken value) { }

	// RVA: 0xE10CD8
	public static System.Nullable<System.DateTime> op_Explicit(JToken value) { }

	// RVA: 0xE10F9C
	public static System.Nullable<System.DateTimeOffset> op_Explicit(JToken value) { }

	// RVA: 0xE112DC
	public static System.Nullable<System.Decimal> op_Explicit(JToken value) { }

	// RVA: 0xE115CC
	public static System.Nullable<System.Double> op_Explicit(JToken value) { }

	// RVA: 0xE11874
	public static System.Nullable<System.Char> op_Explicit(JToken value) { }

	// RVA: 0xE11B38
	public static int op_Explicit(JToken value) { }

	// RVA: 0xE11DC0
	public static Int16 op_Explicit(JToken value) { }

	// RVA: 0xE12048
	public static UInt16 op_Explicit(JToken value) { }

	// RVA: 0xE122D0
	public static Char op_Explicit(JToken value) { }

	// RVA: 0xE12558
	public static Byte op_Explicit(JToken value) { }

	// RVA: 0xE127E0
	public static SByte op_Explicit(JToken value) { }

	// RVA: 0xE12A68
	public static System.Nullable<System.Int32> op_Explicit(JToken value) { }

	// RVA: 0xE12D10
	public static System.Nullable<System.Int16> op_Explicit(JToken value) { }

	// RVA: 0xE12FD4
	public static System.Nullable<System.UInt16> op_Explicit(JToken value) { }

	// RVA: 0xE13298
	public static System.Nullable<System.Byte> op_Explicit(JToken value) { }

	// RVA: 0xE1355C
	public static System.Nullable<System.SByte> op_Explicit(JToken value) { }

	// RVA: 0xE13820
	public static DateTime op_Explicit(JToken value) { }

	// RVA: 0xE13AA8
	public static System.Nullable<System.Int64> op_Explicit(JToken value) { }

	// RVA: 0xE13D50
	public static System.Nullable<System.Single> op_Explicit(JToken value) { }

	// RVA: 0xE13FF8
	public static Decimal op_Explicit(JToken value) { }

	// RVA: 0xE14280
	public static System.Nullable<System.UInt32> op_Explicit(JToken value) { }

	// RVA: 0xE14528
	public static System.Nullable<System.UInt64> op_Explicit(JToken value) { }

	// RVA: 0xE147D0
	public static Double op_Explicit(JToken value) { }

	// RVA: 0xE14A58
	public static float op_Explicit(JToken value) { }

	// RVA: 0xE14CE0
	public static string op_Explicit(JToken value) { }

	// RVA: 0xE15010
	public static UInt32 op_Explicit(JToken value) { }

	// RVA: 0xE15298
	public static UInt64 op_Explicit(JToken value) { }

	// RVA: 0xE15520
	public static Guid op_Explicit(JToken value) { }

	// RVA: 0xE157B0
	public static System.Nullable<System.Guid> op_Explicit(JToken value) { }

	// RVA: 0xE15AC4
	public static TimeSpan op_Explicit(JToken value) { }

	// RVA: 0xE15D44
	public static System.Nullable<System.TimeSpan> op_Explicit(JToken value) { }

	// RVA: 0xE16000
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0xE1627C
	private static BigInteger ToBigInteger(JToken value) { }

	// RVA: 0xE16448
	private static System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(JToken value) { }

	// RVA: 0xE1669C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xE16750
	private System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: 0xE167EC
	public JsonReader CreateReader() { }

	// RVA: 0xE16914
	public object ToObject(Type objectType) { }

	// RVA: 0xE177AC
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0xE17A28
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0xE17AB0
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE049E0
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0xE17EAC
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0xE181C4
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE18224
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE18284
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE182E4
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0xE183B8
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0xE183C8
	private object System.ICloneable.Clone() { }

	// RVA: 0xE183D8
	public JToken DeepClone() { }

	// RVA: 0xE17F60
	public void AddAnnotation(object annotation) { }

	// RVA: 0x318DB98
	public T Annotation() { }

	// RVA: 0xE057A4
	internal void CopyAnnotations(JToken target, JToken source) { }

	// RVA: 0xE183E8
	private static void .cctor() { }

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

	// RVA: 0xE186F4
	public JToken get_CurrentToken() { }

	// RVA: 0xE1689C
	public void .ctor(JToken token) { }

	// RVA: 0xE186FC
	public override bool Read() { }

	// RVA: 0xE18908
	private bool ReadOver(JToken t) { }

	// RVA: 0xE19128
	private bool ReadToEnd() { }

	// RVA: 0xE192DC
	private System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0xE18874
	private bool ReadInto(JContainer c) { }

	// RVA: 0xE19164
	private bool SetEnd(JContainer c) { }

	// RVA: 0xE189F4
	private void SetToken(JToken token) { }

	// RVA: 0xE1944C
	private string SafeToString(object value) { }

	// RVA: 0xE1946C
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE19534
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE19600
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE196CC
	public override string get_Path() { }

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

	// RVA: 0xE197EC
	public JToken get_Token() { }

	// RVA: 0xE19808
	public void .ctor() { }

	// RVA: 0xE19890
	public override void Close() { }

	// RVA: 0xE19898
	public override void WriteStartObject() { }

	// RVA: 0xE19944
	private void AddParent(JContainer container) { }

	// RVA: 0xE199B0
	private void RemoveParent() { }

	// RVA: 0xE19A30
	public override void WriteStartArray() { }

	// RVA: 0xE19ADC
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE19B94
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xE19B98
	public override void WritePropertyName(string name) { }

	// RVA: 0xE19CA0
	private void AddRawValue(object value, JTokenType type, JsonToken token) { }

	// RVA: 0xE19D68
	internal void AddJValue(JValue value, JsonToken token) { }

	// RVA: 0xE19E34
	public override void WriteValue(object value) { }

	// RVA: 0xE19ED4
	public override void WriteNull() { }

	// RVA: 0xE19F04
	public override void WriteUndefined() { }

	// RVA: 0xE19F34
	public override void WriteRaw(string json) { }

	// RVA: 0xE1A00C
	public override void WriteComment(string text) { }

	// RVA: 0xE1A0DC
	public override void WriteValue(string value) { }

	// RVA: 0xE1A238
	public override void WriteValue(int value) { }

	// RVA: 0xE1A2C4
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xE1A350
	public override void WriteValue(Int64 value) { }

	// RVA: 0xE1A498
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xE1A5DC
	public override void WriteValue(float value) { }

	// RVA: 0xE1A730
	public override void WriteValue(Double value) { }

	// RVA: 0xE1A888
	public override void WriteValue(bool value) { }

	// RVA: 0xE1A9D0
	public override void WriteValue(Int16 value) { }

	// RVA: 0xE1AA5C
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xE1AAE8
	public override void WriteValue(Char value) { }

	// RVA: 0xE1AC38
	public override void WriteValue(Byte value) { }

	// RVA: 0xE1ACC4
	public override void WriteValue(SByte value) { }

	// RVA: 0xE1AD50
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE1AEBC
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE1B044
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE1B1A8
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xE1B280
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE1B3C4
	public override void WriteValue(Guid value) { }

	// RVA: 0xE1B528
	public override void WriteValue(Uri value) { }

	// RVA: 0xE1B6A8
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

}

// Namespace: 
private class JValueDynamicProxy
{
	// Methods

	// RVA: 0xE1EF9C
	public override bool TryConvert(JValue instance, ConvertBinder binder, object result) { }

	// RVA: 0xE1F188
	public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, object result) { }

	// RVA: 0xE1E688
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JValue
{
	// Fields
	private JTokenType _valueType; // 0x30
	private object _value; // 0x38

	// Methods

	// RVA: 0xE0F1DC
	internal void .ctor(object value, JTokenType type) { }

	// RVA: 0xE0F034
	internal void .ctor(JValue other, JsonCloneSettings settings) { }

	// RVA: 0xE1A3CC
	public void .ctor(Int64 value) { }

	// RVA: 0xE1ADE0
	public void .ctor(Decimal value) { }

	// RVA: 0xE1A514
	public void .ctor(UInt64 value) { }

	// RVA: 0xE1A7B4
	public void .ctor(Double value) { }

	// RVA: 0xE1A660
	public void .ctor(float value) { }

	// RVA: 0xE1AF7C
	public void .ctor(DateTime value) { }

	// RVA: 0xE1B0D4
	public void .ctor(DateTimeOffset value) { }

	// RVA: 0xE1A904
	public void .ctor(bool value) { }

	// RVA: 0xE1A1B4
	public void .ctor(string value) { }

	// RVA: 0xE1B454
	public void .ctor(Guid value) { }

	// RVA: 0xE1B5A4
	public void .ctor(Uri value) { }

	// RVA: 0xE1B2FC
	public void .ctor(TimeSpan value) { }

	// RVA: 0xE085A8
	public void .ctor(object value) { }

	// RVA: 0xE1BE50
	public override bool get_HasValues() { }

	// RVA: 0xE1BE58
	private static int CompareBigInteger(BigInteger i1, object i2) { }

	// RVA: 0xE1C1D4
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	// RVA: 0xE1CC48
	private static int CompareFloat(object objA, object objB) { }

	// RVA: 0xE1CD8C
	private static bool Operation(ExpressionType operation, object objA, object objB, object result) { }

	// RVA: 0xE1D69C
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xE08CC4
	public static JValue CreateComment(string value) { }

	// RVA: 0xE063DC
	public static JValue CreateNull() { }

	// RVA: 0xE08D7C
	public static JValue CreateUndefined() { }

	// RVA: 0xE1B9AC
	private static JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, object value) { }

	// RVA: 0xE1D708
	private static JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current) { }

	// RVA: 0xE1D8D0
	public override JTokenType get_Type() { }

	// RVA: 0xE1D8D8
	public object get_Value() { }

	// RVA: 0xE1D8E0
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE1E234
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0xE1E29C
	public bool Equals(JValue other) { }

	// RVA: 0xE1E304
	public override bool Equals(object obj) { }

	// RVA: 0xE1E3E0
	public override int GetHashCode() { }

	// RVA: 0xE1E3F8
	public override string ToString() { }

	// RVA: 0xE1E464
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0xE1E470
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xE1E59C
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0xE1E6DC
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xE1E798
	public int CompareTo(JValue obj) { }

	// RVA: 0xE1E7C8
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0xE1E898
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xE1E918
	private Char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xE1E998
	private SByte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xE1EA18
	private Byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xE1EA98
	private Int16 System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xE1EB18
	private UInt16 System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xE1EB98
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xE1EC18
	private UInt32 System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xE1EC98
	private Int64 System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xE1ED18
	private UInt64 System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xE1ED98
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xE1EE18
	private Double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xE1EE98
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xE1EF18
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xE1EF98
	private object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }

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
	private const string BinaryTypeName = "System.Data.Linq.Binary";
	private const string BinaryToArrayName = "ToArray";
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0xE1F514
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE1F578
	private Byte[] GetByteArray(object value) { }

	// RVA: 0xE1F778
	private static void EnsureReflectionObject(Type t) { }

	// RVA: 0xE1F934
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE1FD70
	private Byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0xE200A4
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE201CC
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class BsonObjectIdConverter
{
	// Methods

	// RVA: 0xE201D4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE202D8
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE20464
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE204F0
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public abstract class CustomCreationConverter<T0>
{
	// Methods

	// RVA: 0x30D5108
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30D3F68
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: -1
	public abstract T Create(Type objectType) { }

	// RVA: 0x30D3858
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x30D3738
	public override bool get_CanWrite() { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class DataSetConverter
{
	// Methods

	// RVA: 0xE204F8
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE2099C
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE20D00
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xE20DB8
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class DataTableConverter
{
	// Methods

	// RVA: 0xE20DC0
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE21558
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE21850
	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	// RVA: 0xE21D84
	private static Type GetColumnDataType(JsonReader reader) { }

	// RVA: 0xE21F7C
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xE22034
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public abstract class DateTimeConverterBase
{
	// Methods

	// RVA: 0xE2203C
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE221B4
	protected void .ctor() { }

}

// Namespace: 
internal class Union
{
	// Fields
	public readonly FSharpFunction TagReader; // 0x10
	public readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases; // 0x18

	// Methods

	// RVA: 0xE22D54
	public void .ctor(FSharpFunction tagReader, System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases) { }

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

	// RVA: 0xE22DA4
	public void .ctor(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public int tag; // 0x10

	// Methods

	// RVA: 0xE2332C
	public void .ctor() { }

	// RVA: 0xE23EDC
	internal bool <WriteJson>b__0(UnionCase c) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public string caseName; // 0x10
	public System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase,System.Boolean> <>9__0; // 0x18

	// Methods

	// RVA: 0xE23A14
	public void .ctor() { }

	// RVA: 0xE23F04
	internal bool <ReadJson>b__0(UnionCase c) { }

}

// Namespace: Newtonsoft.Json.Converters
public class DiscriminatedUnionConverter
{
	// Fields
	private const string CasePropertyName = "Case";
	private const string FieldsPropertyName = "Fields";
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union> UnionCache; // 0x0
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,System.Type> UnionTypeLookupCache; // 0x8

	// Methods

	// RVA: 0xE221BC
	private static Type CreateUnionTypeLookup(Type t) { }

	// RVA: 0xE22440
	private static Union CreateUnion(Type t) { }

	// RVA: 0xE22E2C
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE23334
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE23A1C
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE23D40
	public void .ctor() { }

	// RVA: 0xE23D48
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class EntityKeyMemberConverter
{
	// Fields
	private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";
	private const string KeyPropertyName = "Key";
	private const string TypePropertyName = "Type";
	private const string ValuePropertyName = "Value";
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0xE23F2C
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE243F0
	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	// RVA: 0xE244E0
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE242CC
	private static void EnsureReflectionObject(Type objectType) { }

	// RVA: 0xE247E0
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE2483C
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class ExpandoObjectConverter
{
	// Methods

	// RVA: 0xE24844
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE24848
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE2484C
	private object ReadValue(JsonReader reader) { }

	// RVA: 0xE24C10
	private object ReadList(JsonReader reader) { }

	// RVA: 0xE249BC
	private object ReadObject(JsonReader reader) { }

	// RVA: 0xE24DF0
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE24E7C
	public override bool get_CanWrite() { }

	// RVA: 0xE24E84
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class IsoDateTimeConverter
{
	// Fields
	private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
	private DateTimeStyles _dateTimeStyles; // 0x10
	private string _dateTimeFormat; // 0x18
	private CultureInfo _culture; // 0x20

	// Methods

	// RVA: 0xE24E8C
	public DateTimeStyles get_DateTimeStyles() { }

	// RVA: 0xE24E94
	public void set_DateTimeStyles(DateTimeStyles value) { }

	// RVA: 0xE24E9C
	public string get_DateTimeFormat() { }

	// RVA: 0xE24F08
	public void set_DateTimeFormat(string value) { }

	// RVA: 0xE24F4C
	public CultureInfo get_Culture() { }

	// RVA: 0xE24FC8
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xE24FD0
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE252F0
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE259D0
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class JavaScriptDateTimeConverter
{
	// Methods

	// RVA: 0xE259E0
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE25BCC
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE25F38
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class KeyValuePairConverter
{
	// Fields
	private const string KeyName = "Key";
	private const string ValueName = "Value";
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Type,Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType; // 0x0

	// Methods

	// RVA: 0xE25F40
	private static ReflectionObject InitializeReflectionObject(Type t) { }

	// RVA: 0xE261C0
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE2644C
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE26944
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE26A94
	public void .ctor() { }

	// RVA: 0xE26A9C
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class RegexConverter
{
	// Fields
	private const string PatternName = "Pattern";
	private const string OptionsName = "Options";

	// Methods

	// RVA: 0xE26B88
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE26FD8
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0xE26CA4
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0xE26E10
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0xE27098
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE27450
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0xE27148
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0xE275B0
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE2762C
	private bool IsRegex(Type objectType) { }

	// RVA: 0xE276B8
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class StringEnumConverter
{
	// Fields
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x10
	private bool <AllowIntegerValues>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE276C0
	public bool get_CamelCaseText() { }

	// RVA: 0xE27748
	public void set_CamelCaseText(bool value) { }

	// RVA: 0xE27830
	public NamingStrategy get_NamingStrategy() { }

	// RVA: 0xE27838
	public void set_NamingStrategy(NamingStrategy value) { }

	// RVA: 0xE27840
	public bool get_AllowIntegerValues() { }

	// RVA: 0xE27848
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0xE27850
	public void .ctor() { }

	// RVA: 0xE27860
	public void .ctor(bool camelCaseText) { }

	// RVA: 0xE278F8
	public void .ctor(NamingStrategy namingStrategy, bool allowIntegerValues) { }

	// RVA: 0xE27948
	public void .ctor(Type namingStrategyType) { }

	// RVA: 0xE27A04
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters) { }

	// RVA: 0xE27AC4
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) { }

	// RVA: 0xE27B98
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE27DA8
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE28278
	public override bool CanConvert(Type objectType) { }

}

// Namespace: Newtonsoft.Json.Converters
public class UnixDateTimeConverter
{
	// Fields
	internal static readonly DateTime UnixEpoch; // 0x0
	private bool <AllowPreEpoch>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE28328
	public bool get_AllowPreEpoch() { }

	// RVA: 0xE28330
	public void set_AllowPreEpoch(bool value) { }

	// RVA: 0xE28338
	public void .ctor() { }

	// RVA: 0xE28360
	public void .ctor(bool allowPreEpoch) { }

	// RVA: 0xE2838C
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE285F8
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE28A58
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class VersionConverter
{
	// Methods

	// RVA: 0xE28AD8
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE28BD0
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE28E7C
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE28F08
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDocumentWrapper
{
	// Fields
	private readonly XmlDocument _document; // 0x28

	// Methods

	// RVA: 0xE28F10
	public void .ctor(XmlDocument document) { }

	// RVA: 0xE28F88
	public IXmlNode CreateComment(string data) { }

	// RVA: 0xE29024
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xE290C0
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xE2915C
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xE291F8
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xE29294
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE2939C
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE294A8
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE2954C
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xE29634
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xE296E0
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xE297B8
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xE2987C
	public IXmlElement get_DocumentElement() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlElementWrapper
{
	// Fields
	private readonly XmlElement _element; // 0x28

	// Methods

	// RVA: 0xE295F0
	public void .ctor(XmlElement element) { }

	// RVA: 0xE29938
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xE29A2C
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xE29A54
	public bool get_IsEmpty() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDeclarationWrapper
{
	// Fields
	private readonly XmlDeclaration _declaration; // 0x28

	// Methods

	// RVA: 0xE29358
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0xE29A74
	public string get_Version() { }

	// RVA: 0xE29A94
	public string get_Encoding() { }

	// RVA: 0xE29AB4
	public string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDocumentTypeWrapper
{
	// Fields
	private readonly XmlDocumentType _documentType; // 0x28

	// Methods

	// RVA: 0xE29464
	public void .ctor(XmlDocumentType documentType) { }

	// RVA: 0xE29AD4
	public string get_Name() { }

	// RVA: 0xE29AF8
	public string get_System() { }

	// RVA: 0xE29B18
	public string get_Public() { }

	// RVA: 0xE29B38
	public string get_InternalSubset() { }

	// RVA: 0xE29B58
	public override string get_LocalName() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlNodeWrapper
{
	// Fields
	private readonly XmlNode _node; // 0x10
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes; // 0x18
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes; // 0x20

	// Methods

	// RVA: 0xE28F54
	public void .ctor(XmlNode node) { }

	// RVA: 0xE29B9C
	public object get_WrappedNode() { }

	// RVA: 0xE29BA4
	public XmlNodeType get_NodeType() { }

	// RVA: 0xE29BC8
	public virtual string get_LocalName() { }

	// RVA: 0xE29BF0
	public System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE29FCC
	internal static IXmlNode WrapNode(XmlNode node) { }

	// RVA: 0xE2A164
	public System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE2A5B4
	private bool get_HasAttributes() { }

	// RVA: 0xE2A668
	public IXmlNode get_ParentNode() { }

	// RVA: 0xE2A720
	public string get_Value() { }

	// RVA: 0xE29794
	public void set_Value(string value) { }

	// RVA: 0xE2A744
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE2A810
	public string get_NamespaceUri() { }

}

// Namespace: Newtonsoft.Json.Converters
internal interface IXmlDocument
{
	// Methods

	// RVA: -1
	public abstract IXmlNode CreateComment(string text) { }

	// RVA: -1
	public abstract IXmlNode CreateTextNode(string text) { }

	// RVA: -1
	public abstract IXmlNode CreateCDataSection(string data) { }

	// RVA: -1
	public abstract IXmlNode CreateWhitespace(string text) { }

	// RVA: -1
	public abstract IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: -1
	public abstract IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: -1
	public abstract IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: -1
	public abstract IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: -1
	public abstract IXmlElement CreateElement(string elementName) { }

	// RVA: -1
	public abstract IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: -1
	public abstract IXmlNode CreateAttribute(string name, string value) { }

	// RVA: -1
	public abstract IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: -1
	public abstract IXmlElement get_DocumentElement() { }

}

// Namespace: Newtonsoft.Json.Converters
internal interface IXmlDeclaration
{
	// Methods

	// RVA: -1
	public abstract string get_Version() { }

	// RVA: -1
	public abstract string get_Encoding() { }

	// RVA: -1
	public abstract string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal interface IXmlDocumentType
{
	// Methods

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: -1
	public abstract string get_System() { }

	// RVA: -1
	public abstract string get_Public() { }

	// RVA: -1
	public abstract string get_InternalSubset() { }

}

// Namespace: Newtonsoft.Json.Converters
internal interface IXmlElement
{
	// Methods

	// RVA: -1
	public abstract void SetAttributeNode(IXmlNode attribute) { }

	// RVA: -1
	public abstract string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: -1
	public abstract bool get_IsEmpty() { }

}

// Namespace: Newtonsoft.Json.Converters
internal interface IXmlNode
{
	// Methods

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: -1
	public abstract string get_LocalName() { }

	// RVA: -1
	public abstract System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: -1
	public abstract System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: -1
	public abstract IXmlNode get_ParentNode() { }

	// RVA: -1
	public abstract string get_Value() { }

	// RVA: -1
	public abstract IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: -1
	public abstract string get_NamespaceUri() { }

	// RVA: -1
	public abstract object get_WrappedNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDeclarationWrapper
{
	// Fields
	private readonly XDeclaration <Declaration>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE2A838
	internal XDeclaration get_Declaration() { }

	// RVA: 0xE2A840
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0xE2A8B8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE2A8C0
	public string get_Version() { }

	// RVA: 0xE2A8E0
	public string get_Encoding() { }

	// RVA: 0xE2A900
	public string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDocumentTypeWrapper
{
	// Fields
	private readonly XDocumentType _documentType; // 0x18

	// Methods

	// RVA: 0xE2A920
	public void .ctor(XDocumentType documentType) { }

	// RVA: 0xE2A964
	public string get_Name() { }

	// RVA: 0xE2A984
	public string get_System() { }

	// RVA: 0xE2A9A4
	public string get_Public() { }

	// RVA: 0xE2A9C4
	public string get_InternalSubset() { }

	// RVA: 0xE2A9E4
	public override string get_LocalName() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDocumentWrapper
{
	// Methods

	// RVA: 0xE2AA28
	private XDocument get_Document() { }

	// RVA: 0xE2AAA4
	public void .ctor(XDocument document) { }

	// RVA: 0xE2AB0C
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE2B190
	protected override bool get_HasChildNodes() { }

	// RVA: 0xE2B324
	public IXmlNode CreateComment(string text) { }

	// RVA: 0xE2B3C4
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xE2B464
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xE2B504
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xE2B5A4
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xE2B644
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE2B70C
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE2B7E4
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE2B8C8
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xE2B9AC
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xE2BA74
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xE2BB68
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xE2BC38
	public IXmlElement get_DocumentElement() { }

	// RVA: 0xE2BDA8
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XTextWrapper
{
	// Methods

	// RVA: 0xE2C020
	private XText get_Text() { }

	// RVA: 0xE2C09C
	public void .ctor(XText text) { }

	// RVA: 0xE2C0D0
	public override string get_Value() { }

	// RVA: 0xE2C154
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XCommentWrapper
{
	// Methods

	// RVA: 0xE2C568
	private XComment get_Text() { }

	// RVA: 0xE2C5E4
	public void .ctor(XComment text) { }

	// RVA: 0xE2C618
	public override string get_Value() { }

	// RVA: 0xE2C69C
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XProcessingInstructionWrapper
{
	// Methods

	// RVA: 0xE2C798
	private XProcessingInstruction get_ProcessingInstruction() { }

	// RVA: 0xE2B894
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0xE2C814
	public override string get_LocalName() { }

	// RVA: 0xE2C898
	public override string get_Value() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XContainerWrapper
{
	// Fields
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes; // 0x18

	// Methods

	// RVA: 0xE2C91C
	private XContainer get_Container() { }

	// RVA: 0xE2AAD8
	public void .ctor(XContainer container) { }

	// RVA: 0xE2AD88
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE2B294
	protected virtual bool get_HasChildNodes() { }

	// RVA: 0xE2C998
	public override IXmlNode get_ParentNode() { }

	// RVA: 0xE2C250
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0xE2BEBC
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XObjectWrapper
{
	// Fields
	private readonly XObject _xmlObject; // 0x10

	// Methods

	// RVA: 0xE2A884
	public void .ctor(XObject xmlObject) { }

	// RVA: 0xE2CA94
	public object get_WrappedNode() { }

	// RVA: 0xE2CA9C
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0xE2CAB4
	public virtual string get_LocalName() { }

	// RVA: 0xE2CABC
	public virtual System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE2CB38
	public virtual System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE2CBB4
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0xE2CBBC
	public virtual string get_Value() { }

	// RVA: 0xE2CBC4
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE2CC04
	public virtual string get_NamespaceUri() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XAttributeWrapper
{
	// Methods

	// RVA: 0xE2CC0C
	private XAttribute get_Attribute() { }

	// RVA: 0xE2BB34
	public void .ctor(XAttribute attribute) { }

	// RVA: 0xE2CC88
	public override string get_Value() { }

	// RVA: 0xE2CD0C
	public override string get_LocalName() { }

	// RVA: 0xE2CD98
	public override string get_NamespaceUri() { }

	// RVA: 0xE2CE24
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XElementWrapper
{
	// Fields
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes; // 0x20

	// Methods

	// RVA: 0xE2CF20
	private XElement get_Element() { }

	// RVA: 0xE2B978
	public void .ctor(XElement element) { }

	// RVA: 0xE2CF9C
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xE2D0A4
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE2D644
	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	// RVA: 0xE2DC34
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE2DC6C
	public override string get_Value() { }

	// RVA: 0xE2DCF0
	public override string get_LocalName() { }

	// RVA: 0xE2DD7C
	public override string get_NamespaceUri() { }

	// RVA: 0xE2DB80
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xE2DE08
	public bool get_IsEmpty() { }

}

// Namespace: Newtonsoft.Json.Converters
public class XmlNodeConverter
{
	// Fields
	internal static readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> EmptyChildNodes; // 0x0
	private const string TextName = "#text";
	private const string CommentName = "#comment";
	private const string CDataName = "#cdata-section";
	private const string WhitespaceName = "#whitespace";
	private const string SignificantWhitespaceName = "#significant-whitespace";
	private const string DeclarationName = "?xml";
	private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";
	private string <DeserializeRootElementName>k__BackingField; // 0x10
	private bool <WriteArrayAttribute>k__BackingField; // 0x18
	private bool <OmitRootObject>k__BackingField; // 0x19
	private bool <EncodeSpecialCharacters>k__BackingField; // 0x1A

	// Methods

	// RVA: 0xE2DE8C
	public string get_DeserializeRootElementName() { }

	// RVA: 0xE2DE94
	public void set_DeserializeRootElementName(string value) { }

	// RVA: 0xE2DE9C
	public bool get_WriteArrayAttribute() { }

	// RVA: 0xE2DEA4
	public void set_WriteArrayAttribute(bool value) { }

	// RVA: 0xE2DEAC
	public bool get_OmitRootObject() { }

	// RVA: 0xE2DEB4
	public void set_OmitRootObject(bool value) { }

	// RVA: 0xE2DEBC
	public bool get_EncodeSpecialCharacters() { }

	// RVA: 0xE2DEC4
	public void set_EncodeSpecialCharacters(bool value) { }

	// RVA: 0xE2DECC
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE2E018
	private IXmlNode WrapXml(object value) { }

	// RVA: 0xE2E134
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE3018C
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE30544
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE30A1C
	private bool IsArray(IXmlNode node) { }

	// RVA: 0xE30E28
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xE31A68
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, string elementNames) { }

	// RVA: 0xE31BEC
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	// RVA: 0xE2E8FC
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xE31CC0
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0xE3236C
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE33870
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0xE32C60
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0xE35C74
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, System.Collections.Generic.Dictionary<System.String,System.String> attributeNameValues) { }

	// RVA: 0xE358E8
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0xE33E5C
	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0xE34DC8
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0xE367DC
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0xE351FC
	private bool ShouldReadInto(JsonReader reader) { }

	// RVA: 0xE35240
	private System.Collections.Generic.Dictionary<System.String,System.String> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0xE34540
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0xE349F0
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0xE365C4
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0xE33004
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0xE36B30
	private bool IsNamespaceAttribute(string attributeName, string prefix) { }

	// RVA: 0xE31FFC
	private bool ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c) { }

	// RVA: 0xE36C24
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xE36CDC
	private bool IsXObject(Type valueType) { }

	// RVA: 0xE36D94
	private bool IsXmlNode(Type valueType) { }

	// RVA: 0xE36E4C
	public void .ctor() { }

	// RVA: 0xE36E54
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Bson
public class BsonObjectId
{
	// Fields
	private readonly Byte[] <Value>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE36EF0
	public Byte[] get_Value() { }

	// RVA: 0xE36EF8
	public void .ctor(Byte[] value) { }

}

// Namespace: Newtonsoft.Json.Bson
internal abstract class BsonToken
{
	// Fields
	private BsonToken <Parent>k__BackingField; // 0x10

	// Methods

	// RVA: -1
	public abstract BsonType get_Type() { }

	// RVA: 0xE36FE0
	public void set_Parent(BsonToken value) { }

	// RVA: 0xE36FE8
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonObject
{
	// Fields
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children; // 0x18

	// Methods

	// RVA: 0xE36FF0
	public void Add(string name, BsonToken token) { }

	// RVA: 0xE3715C
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonArray
{
	// Fields
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children; // 0x18

	// Methods

	// RVA: 0xE37164
	public void Add(BsonToken token) { }

	// RVA: 0xE371DC
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonValue
{
	// Fields
	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	// Methods

	// RVA: 0xE371E4
	public void .ctor(object value, BsonType type) { }

	// RVA: 0xE3722C
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonString
{
	// Fields
	private readonly bool <IncludeLength>k__BackingField; // 0x21

	// Methods

	// RVA: 0xE3710C
	public void .ctor(object value, bool includeLength) { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonRegex
{
	// Fields
	private BsonString <Pattern>k__BackingField; // 0x18
	private BsonString <Options>k__BackingField; // 0x20

	// Methods

	// RVA: 0xE37234
	public void set_Pattern(BsonString value) { }

	// RVA: 0xE3723C
	public void set_Options(BsonString value) { }

	// RVA: 0xE37244
	public void .ctor(string pattern, string options) { }

	// RVA: 0xE3731C
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonProperty
{
	// Fields
	private BsonString <Name>k__BackingField; // 0x10
	private BsonToken <Value>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE37324
	public void set_Name(BsonString value) { }

	// RVA: 0xE3732C
	public void set_Value(BsonToken value) { }

	// RVA: 0xE37104
	public void .ctor() { }

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

	// RVA: 0xE37334
	private void AddValue(object value, BsonType type) { }

	// RVA: 0xE373C0
	internal void AddToken(BsonToken token) { }

	// RVA: 0xE37610
	public void WriteObjectId(Byte[] value) { }

	// RVA: 0xE26FE4
	public void WriteRegex(string pattern, string options) { }

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


