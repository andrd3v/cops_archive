// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0xDDC81C
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class IsReadOnlyAttribute
{
	// Methods

	// RVA: 0xDDC824
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xDDC82C
	public void .ctor(Byte ) { }

	// RVA: 0xDDC8B8
	public void .ctor(Byte[] ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0xDDC8EC
	public void .ctor(Byte ) { }

}

// Namespace: System.Diagnostics.CodeAnalysis
internal sealed class NotNullAttribute
{
	// Methods

	// RVA: 0xDDC918
	public void .ctor() { }

}

// Namespace: System.Diagnostics.CodeAnalysis
internal sealed class NotNullWhenAttribute
{
	// Fields
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0xDDC920
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

	// RVA: 0xDDD044
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

	// RVA: 0xDDC94C
	private static void .cctor() { }

	// RVA: 0xDDC9A0
	public void .ctor() { }

	// RVA: 0xDDCA24
	public override string Get(Char[] key, int start, int length) { }

	// RVA: 0xDDCD44
	public string Add(string key) { }

	// RVA: 0xDDCF0C
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0xDDD09C
	private void Grow() { }

	// RVA: 0xDDCC68
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

	// RVA: 0xDDD228
	public Type get_ItemConverterType() { }

	// RVA: 0xDDD230
	public object[] get_ItemConverterParameters() { }

	// RVA: 0xDDD238
	public Type get_NamingStrategyType() { }

	// RVA: 0xDDD240
	public object[] get_NamingStrategyParameters() { }

	// RVA: 0xDDD248
	internal NamingStrategy get_NamingStrategyInstance() { }

	// RVA: 0xDDD250
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

	// RVA: 0xDDD258
	public static System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings() { }

	// RVA: 0xDDD2D4
	public static string ToString(bool value) { }

	// RVA: 0xDDD370
	public static string ToString(Char value) { }

	// RVA: 0xDDD520
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xDDD798
	private static string EnsureFloatFormat(Double value, string text, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xDDD8B4
	internal static string ToString(Double value, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xDDD6D0
	private static string EnsureDecimalPlace(Double value, string text) { }

	// RVA: 0xDDDA5C
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0xDDDAD4
	public static string ToString(Decimal value) { }

	// RVA: 0xDDD400
	public static string ToString(string value) { }

	// RVA: 0xDDDC64
	public static string ToString(string value, Char delimiter) { }

	// RVA: 0xDDDCD0
	public static string ToString(string value, Char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xDDDDB4
	public static string SerializeObject(object value) { }

	// RVA: 0xDDDE84
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xDDDF4C
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	// RVA: 0x26AD93C
	public static T DeserializeObject(string value) { }

	// RVA: 0x26AD93C
	public static T DeserializeObject(string value, JsonSerializerSettings settings) { }

	// RVA: 0xDDE438
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xDDE8A4
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

	// RVA: 0xDDEA18
	public virtual bool get_CanRead() { }

	// RVA: 0xDDEA20
	public virtual bool get_CanWrite() { }

	// RVA: 0xDDEA28
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonConverterAttribute
{
	// Fields
	private readonly Type _converterType; // 0x10
	private readonly object[] <ConverterParameters>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDDEA30
	public Type get_ConverterType() { }

	// RVA: 0xDDEA38
	public object[] get_ConverterParameters() { }

}

// Namespace: Newtonsoft.Json
public class JsonConverterCollection
{
	// Methods

	// RVA: 0xDDEA40
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

	// RVA: 0xDDEA94
	public void .ctor() { }

	// RVA: 0xDDEB1C
	public void .ctor(string message) { }

	// RVA: 0xDDEB88
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xDDEC04
	public void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: Newtonsoft.Json
public class JsonExtensionDataAttribute
{
	// Fields
	private bool <WriteData>k__BackingField; // 0x10
	private bool <ReadData>k__BackingField; // 0x11

	// Methods

	// RVA: 0xDDEC88
	public bool get_WriteData() { }

	// RVA: 0xDDEC90
	public bool get_ReadData() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonIgnoreAttribute
{
	// Methods

	// RVA: 0xDDEC98
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json
public abstract class JsonNameTable
{
	// Methods

	// RVA: -1
	public abstract string Get(Char[] key, int start, int length) { }

	// RVA: 0xDDCA1C
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

	// RVA: 0xDDECA0
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

	// RVA: 0xDDECA8
	public void .ctor(JsonContainerType type) { }

	// RVA: 0xDDED40
	internal int CalculateLength() { }

	// RVA: 0xDDEDE8
	internal void WriteTo(StringBuilder sb, StringWriter writer, Char[] buffer) { }

	// RVA: 0xDDED30
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0xDDF034
	internal static string BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition) { }

	// RVA: 0xDDF51C
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0xDDF848
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

	// RVA: 0xDDF8EC
	public Type get_ItemConverterType() { }

	// RVA: 0xDDF8F4
	public object[] get_ItemConverterParameters() { }

	// RVA: 0xDDF8FC
	public Type get_NamingStrategyType() { }

	// RVA: 0xDDF904
	public object[] get_NamingStrategyParameters() { }

	// RVA: 0xDDF90C
	public string get_PropertyName() { }

	// RVA: 0xDDF914
	public void set_PropertyName(string value) { }

	// RVA: 0xDDF91C
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

	// RVA: 0xDDF924
	protected State get_CurrentState() { }

	// RVA: 0xDDF92C
	public bool get_CloseInput() { }

	// RVA: 0xDDF934
	public void set_CloseInput(bool value) { }

	// RVA: 0xDDF93C
	public bool get_SupportMultipleContent() { }

	// RVA: 0xDDF944
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0xDDF94C
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xDDF954
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xDDF9C0
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0xDDF9C8
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0xDDFA34
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0xDDFA3C
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0xDDFAA8
	public string get_DateFormatString() { }

	// RVA: 0xDDFAB0
	public void set_DateFormatString(string value) { }

	// RVA: 0xDDFAB8
	public System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xDDFAC0
	public void set_MaxDepth(System.Nullable<System.Int32> value) { }

	// RVA: 0xDDFC54
	public virtual JsonToken get_TokenType() { }

	// RVA: 0xDDFC5C
	public virtual object get_Value() { }

	// RVA: 0xDDFC64
	public virtual Type get_ValueType() { }

	// RVA: 0xDDFC78
	public virtual int get_Depth() { }

	// RVA: 0xDDFCF4
	public virtual string get_Path() { }

	// RVA: 0xDDFE18
	public CultureInfo get_Culture() { }

	// RVA: 0xDDFE94
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xDDFE9C
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0xDDFF5C
	protected void .ctor() { }

	// RVA: 0xDE0000
	private void Push(JsonContainerType value) { }

	// RVA: 0xDE04B8
	private JsonContainerType Pop() { }

	// RVA: 0xDE06E0
	private JsonContainerType Peek() { }

	// RVA: -1
	public abstract bool Read() { }

	// RVA: 0xDE06E8
	public virtual System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xDE0DAC
	internal System.Nullable<System.Int32> ReadInt32String(string s) { }

	// RVA: 0xDE0FBC
	public virtual string ReadAsString() { }

	// RVA: 0xDE131C
	public virtual Byte[] ReadAsBytes() { }

	// RVA: 0xDE1A14
	internal Byte[] ReadArrayIntoByteArray() { }

	// RVA: 0xDE1B58
	private bool ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<System.Byte> buffer) { }

	// RVA: 0xDE1D44
	public virtual System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xDE2058
	internal System.Nullable<System.Double> ReadDoubleString(string s) { }

	// RVA: 0xDE2288
	public virtual System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xDE25F4
	internal System.Nullable<System.Boolean> ReadBooleanString(string s) { }

	// RVA: 0xDE27C4
	public virtual System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xDE2C34
	internal System.Nullable<System.Decimal> ReadDecimalString(string s) { }

	// RVA: 0xDE2F0C
	public virtual System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xDE31FC
	internal System.Nullable<System.DateTime> ReadDateTimeString(string s) { }

	// RVA: 0xDE354C
	public virtual System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xDE3834
	internal System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0xDE19C4
	internal void ReaderReadAndAssert() { }

	// RVA: 0xDE3B50
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0xDE17A4
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0xDE3C10
	public void Skip() { }

	// RVA: 0xDE1B4C
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0xDE3CAC
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0xDE0BE0
	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0xDE3DD4
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0xDE041C
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0xDE3CB4
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0xDE3EF8
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0xDE3E1C
	private void SetFinished() { }

	// RVA: 0xDE3E48
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0xDE4018
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDE40AC
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xDE40D0
	public virtual void Close() { }

	// RVA: 0xDE40E8
	internal void ReadAndAssert() { }

	// RVA: 0xDE41CC
	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	// RVA: 0xDE4224
	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	// RVA: 0xDE4544
	internal bool ReadAndMoveToContent() { }

	// RVA: 0xDE45B0
	internal bool MoveToContent() { }

	// RVA: 0xDE0AE4
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

	// RVA: 0xDE460C
	public void .ctor() { }

	// RVA: 0xDE4694
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xDE4718
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0xDE0434
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0xDE0B50
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xDE47C0
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonRequiredAttribute
{
	// Methods

	// RVA: 0xDE4A24
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

	// RVA: 0xDE4A2C
	public void .ctor() { }

	// RVA: 0xDE4AB4
	public void .ctor(string message) { }

	// RVA: 0xDE4B20
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xDE4B9C
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xDE4C20
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0xDE4148
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0xDE4CC8
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xDE4D58
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

	// RVA: 0xDE4FBC
	public virtual void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDE5070
	public virtual void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDE5124
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xDE51A0
	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0xDE521C
	public virtual ITraceWriter get_TraceWriter() { }

	// RVA: 0xDE5224
	public virtual void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0xDE522C
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xDE5234
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xDE52A0
	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0xDE530C
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xDE5378
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xDE53E4
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xDE5450
	public virtual NullValueHandling get_NullValueHandling() { }

	// RVA: 0xDE5458
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xDE54C4
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0xDE5530
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xDE559C
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0xDE5608
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xDE5610
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xDE567C
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0xDE573C
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0xDE5744
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xDE5828
	public virtual StreamingContext get_Context() { }

	// RVA: 0xDE5834
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0xDE5840
	public virtual Formatting get_Formatting() { }

	// RVA: 0xDE5918
	public virtual System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xDE5920
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0xDE59F8
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xDDE698
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0xDE5A70
	public void .ctor() { }

	// RVA: 0xDE5BDC
	public static JsonSerializer Create() { }

	// RVA: 0xDE5C30
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0xDE6DE0
	public static JsonSerializer CreateDefault() { }

	// RVA: 0xDDDF14
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0xDE5CA0
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	// RVA: 0xDE790C
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xDE791C
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0x26AD93C
	public T Deserialize(JsonReader reader) { }

	// RVA: 0xDDE894
	public object Deserialize(JsonReader reader, Type objectType) { }

	// RVA: 0xDE8CB0
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xDE7BA0
	internal void SetupReader(JsonReader reader, CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>& previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling>& previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling>& previousFloatParseHandling, System.Nullable<System.Int32>& previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xDE8790
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<System.Int32> previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xDDE428
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xDE8F3C
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0xDE86FC
	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	// RVA: 0xDE8F50
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xDEA4EC
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0xDEA574
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0xDEA57C
	internal static JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, Type objectType) { }

	// RVA: 0xDEA718
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

	// RVA: 0xDE7290
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0xDE7368
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0xDE7440
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xDE7518
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0xDE75F0
	public DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0xDEA73C
	public System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters() { }

	// RVA: 0xDE71B8
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0xDE6F30
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0xDE7008
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xDE70E0
	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0xDE76C8
	public ConstructorHandling get_ConstructorHandling() { }

	// RVA: 0xDEA744
	public IContractResolver get_ContractResolver() { }

	// RVA: 0xDEA74C
	public IEqualityComparer get_EqualityComparer() { }

	// RVA: 0xDEA754
	public System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider() { }

	// RVA: 0xDEA75C
	public ITraceWriter get_TraceWriter() { }

	// RVA: 0xDEA764
	public ISerializationBinder get_SerializationBinder() { }

	// RVA: 0xDEA76C
	public System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error() { }

	// RVA: 0xDE77A0
	public StreamingContext get_Context() { }

	// RVA: 0xDEA774
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

	// RVA: 0xDDE718
	public void .ctor(TextReader reader) { }

	// RVA: 0xDEA804
	public JsonNameTable get_PropertyNameTable() { }

	// RVA: 0xDEA80C
	public void set_PropertyNameTable(JsonNameTable value) { }

	// RVA: 0xDEA814
	private void EnsureBufferNotEmpty() { }

	// RVA: 0xDEA878
	private void SetNewLine(bool hasNextChar) { }

	// RVA: 0xDEA8EC
	private void OnNewLine(int pos) { }

	// RVA: 0xDEA8FC
	private void ParseString(Char quote, ReadType readType) { }

	// RVA: 0xDEB0E8
	private void ParseReadString(Char quote, ReadType readType) { }

	// RVA: 0xDEB5A4
	private static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	// RVA: 0xDEA950
	private void ShiftBufferIfNeeded() { }

	// RVA: 0xDEB5B8
	private int ReadData(bool append) { }

	// RVA: 0xDEB660
	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	// RVA: 0xDEB5C0
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0xDEB824
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0xDEB8BC
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0xDEB93C
	public override bool Read() { }

	// RVA: 0xDECB90
	public override System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xDED140
	public override System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xDED80C
	public override string ReadAsString() { }

	// RVA: 0xDED844
	public override Byte[] ReadAsBytes() { }

	// RVA: 0xDED200
	private object ReadStringValue(ReadType readType) { }

	// RVA: 0xDEE340
	private object FinishReadQuotedStringValue(ReadType readType) { }

	// RVA: 0xDEDFCC
	private JsonReaderException CreateUnexpectedCharacterException(Char c) { }

	// RVA: 0xDEE990
	public override System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xDEDF5C
	private void ProcessValueComma() { }

	// RVA: 0xDECC50
	private object ReadNumberValue(ReadType readType) { }

	// RVA: 0xDEEFDC
	private object FinishReadQuotedNumber(ReadType readType) { }

	// RVA: 0xDEF168
	public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xDEF238
	public override System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xDEF308
	public override System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xDEDE58
	private void HandleNull() { }

	// RVA: 0xDEE1C4
	private void ReadFinished() { }

	// RVA: 0xDEDDE8
	private bool ReadNullChar() { }

	// RVA: 0xDEBBE4
	private void EnsureBuffer() { }

	// RVA: 0xDEAA2C
	private void ReadStringIntoBuffer(Char quote) { }

	// RVA: 0xDEF5D8
	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	// RVA: 0xDEF584
	private void WriteCharToBuffer(Char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0xDEF6C0
	private Char ConvertUnicode(bool enoughChars) { }

	// RVA: 0xDEF4E0
	private Char ParseUnicode() { }

	// RVA: 0xDEF820
	private void ReadNumberIntoBuffer() { }

	// RVA: 0xDEF8B0
	private bool ReadNumberCharIntoBuffer(Char currentChar, int charPos) { }

	// RVA: 0xDEFA20
	private void ClearRecentString() { }

	// RVA: 0xDEC404
	private bool ParsePostValue(bool ignoreComments) { }

	// RVA: 0xDEC258
	private bool ParseObject() { }

	// RVA: 0xDEFA2C
	private bool ParseProperty() { }

	// RVA: 0xDEFCF0
	private bool ValidIdentifierChar(Char value) { }

	// RVA: 0xDEFD40
	private void ParseUnquotedProperty() { }

	// RVA: 0xDEFE34
	private bool ReadUnquotedPropertyReportIfDone(Char currentChar, int initialPosition) { }

	// RVA: 0xDEBC54
	private bool ParseValue() { }

	// RVA: 0xDEE1A8
	private void ProcessLineFeed() { }

	// RVA: 0xDEE0E4
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0xDEC6DC
	private void EatWhitespace() { }

	// RVA: 0xDF024C
	private void ParseConstructor() { }

	// RVA: 0xDEE618
	private void ParseNumber(ReadType readType) { }

	// RVA: 0xDF067C
	private void ParseReadNumber(ReadType readType, Char firstChar, int initialPosition) { }

	// RVA: 0xDF19A8
	private JsonReaderException ThrowReaderError(string message, Exception ex) { }

	// RVA: 0xDF1A84
	private static object BigIntegerParse(string number, CultureInfo culture) { }

	// RVA: 0xDEC7D8
	private void ParseComment(bool setToken) { }

	// RVA: 0xDF1B0C
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0xDF1B58
	private bool MatchValue(string value) { }

	// RVA: 0xDF1C18
	private bool MatchValue(bool enoughChars, string value) { }

	// RVA: 0xDEE6EC
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0xDF1CF8
	private bool IsSeparator(Char c) { }

	// RVA: 0xDEFFC4
	private void ParseTrue() { }

	// RVA: 0xDEF3C8
	private void ParseNull() { }

	// RVA: 0xDF0568
	private void ParseUndefined() { }

	// RVA: 0xDF0108
	private void ParseFalse() { }

	// RVA: 0xDEE598
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0xDF1EB0
	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	// RVA: 0xDEE890
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0xDF2088
	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	// RVA: 0xDEE910
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0xDF2260
	private object ParseNumberNaN(ReadType readType, bool matched) { }

	// RVA: 0xDF2438
	public override void Close() { }

	// RVA: 0xDF24BC
	public bool HasLineInfo() { }

	// RVA: 0xDF24C4
	public int get_LineNumber() { }

	// RVA: 0xDF2520
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

	// RVA: 0xDF252C
	private Base64Encoder get_Base64Encoder() { }

	// RVA: 0xDF25D0
	public Char get_QuoteChar() { }

	// RVA: 0xDDE1F8
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0xDF2690
	public override void Close() { }

	// RVA: 0xDF2800
	private void CloseBufferAndWriter() { }

	// RVA: 0xDF2868
	public override void WriteStartObject() { }

	// RVA: 0xDF2910
	public override void WriteStartArray() { }

	// RVA: 0xDF2974
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xDF2A44
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xDF2B64
	public override void WritePropertyName(string name) { }

	// RVA: 0xDF2CDC
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xDF2DB8
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0xDF2610
	private void UpdateCharEscapeFlags() { }

	// RVA: 0xDF2E38
	protected override void WriteIndent() { }

	// RVA: 0xDF3000
	private int SetIndentChars() { }

	// RVA: 0xDF3114
	protected override void WriteValueDelimiter() { }

	// RVA: 0xDF3140
	protected override void WriteIndentSpace() { }

	// RVA: 0xDF316C
	private void WriteValueInternal(string value, JsonToken token) { }

	// RVA: 0xDF3194
	public override void WriteValue(object value) { }

	// RVA: 0xDF342C
	public override void WriteNull() { }

	// RVA: 0xDF34C4
	public override void WriteUndefined() { }

	// RVA: 0xDF355C
	public override void WriteRaw(string json) { }

	// RVA: 0xDF3588
	public override void WriteValue(string value) { }

	// RVA: 0xDF2BF0
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0xDF369C
	public override void WriteValue(int value) { }

	// RVA: 0xDF378C
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xDF387C
	public override void WriteValue(Int64 value) { }

	// RVA: 0xDF38C4
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xDF39E4
	public override void WriteValue(float value) { }

	// RVA: 0xDF3AA4
	public override void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xDF3C80
	public override void WriteValue(Double value) { }

	// RVA: 0xDF3D40
	public override void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xDF3F1C
	public override void WriteValue(bool value) { }

	// RVA: 0xDF4028
	public override void WriteValue(Int16 value) { }

	// RVA: 0xDF4070
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xDF40B8
	public override void WriteValue(Char value) { }

	// RVA: 0xDF41D8
	public override void WriteValue(Byte value) { }

	// RVA: 0xDF4220
	public override void WriteValue(SByte value) { }

	// RVA: 0xDF4268
	public override void WriteValue(Decimal value) { }

	// RVA: 0xDF4314
	public override void WriteValue(DateTime value) { }

	// RVA: 0xDF4524
	private int WriteValueToBuffer(DateTime value) { }

	// RVA: 0xDF4668
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xDF47FC
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xDF49D8
	private int WriteValueToBuffer(DateTimeOffset value) { }

	// RVA: 0xDF4B7C
	public override void WriteValue(Guid value) { }

	// RVA: 0xDF4C90
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xDF4DD4
	public override void WriteValue(Uri value) { }

	// RVA: 0xDF4EC8
	public override void WriteComment(string text) { }

	// RVA: 0xDF364C
	private void EnsureWriteBuffer() { }

	// RVA: 0xDF37D4
	private void WriteIntegerValue(Int64 value) { }

	// RVA: 0xDF3968
	private void WriteIntegerValue(UInt64 value, bool negative) { }

	// RVA: 0xDF4F94
	private int WriteNumberToBuffer(UInt64 value, bool negative) { }

	// RVA: 0xDF36E4
	private void WriteIntegerValue(int value) { }

	// RVA: 0xDF5190
	private void WriteIntegerValue(UInt32 value, bool negative) { }

	// RVA: 0xDF50A4
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

	// RVA: 0xDF520C
	internal static State[][] BuildStateArray() { }

	// RVA: 0xDF53EC
	private static void .cctor() { }

	// RVA: 0xDF5714
	public bool get_CloseOutput() { }

	// RVA: 0xDF571C
	public void set_CloseOutput(bool value) { }

	// RVA: 0xDF5724
	public bool get_AutoCompleteOnClose() { }

	// RVA: 0xDF572C
	public void set_AutoCompleteOnClose(bool value) { }

	// RVA: 0xDF2FAC
	protected internal int get_Top() { }

	// RVA: 0xDF573C
	public WriteState get_WriteState() { }

	// RVA: 0xDF57F0
	internal string get_ContainerPath() { }

	// RVA: 0xDF5894
	public string get_Path() { }

	// RVA: 0xDF59B8
	public Formatting get_Formatting() { }

	// RVA: 0xDDE3BC
	public void set_Formatting(Formatting value) { }

	// RVA: 0xDF59C0
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0xDEA2B8
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0xDF59C8
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xDEA324
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xDF59D0
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0xDEA3FC
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0xDF59D8
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0xDF59DC
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0xDEA390
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0xDF59E4
	public string get_DateFormatString() { }

	// RVA: 0xDF59EC
	public void set_DateFormatString(string value) { }

	// RVA: 0xDEA470
	public CultureInfo get_Culture() { }

	// RVA: 0xDF59F4
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xDF25D8
	protected void .ctor() { }

	// RVA: 0xDF59FC
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0xDF5A14
	private void Push(JsonContainerType value) { }

	// RVA: 0xDF5BAC
	private JsonContainerType Pop() { }

	// RVA: 0xDF5734
	private JsonContainerType Peek() { }

	// RVA: 0xDF2770
	public virtual void Close() { }

	// RVA: 0xDF5D2C
	public virtual void WriteStartObject() { }

	// RVA: 0xDF5D70
	public virtual void WriteEndObject() { }

	// RVA: 0xDF5D7C
	public virtual void WriteStartArray() { }

	// RVA: 0xDF5DC0
	public virtual void WriteEndArray() { }

	// RVA: 0xDF5DC8
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0xDF5E0C
	public virtual void WriteEndConstructor() { }

	// RVA: 0xDF5E14
	public virtual void WritePropertyName(string name) { }

	// RVA: 0xDF5E40
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0xDF5E50
	public virtual void WriteEnd() { }

	// RVA: 0xDF5F68
	public void WriteToken(JsonReader reader) { }

	// RVA: 0xDF5FE8
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	// RVA: 0xDF6074
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0xDF6850
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0xDF6C28
	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	// RVA: 0xDF6AC8
	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	// RVA: 0xDF6CF0
	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	// RVA: 0xDF6B34
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0xDF5E58
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0xDF5CA4
	private void AutoCompleteAll() { }

	// RVA: 0xDF6D58
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0xDF6DF8
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0xDF6EC4
	private int CalculateLevelsToComplete(JsonContainerType type) { }

	// RVA: 0xDF701C
	private void UpdateCurrentState() { }

	// RVA: 0xDF70D4
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0xDF70D8
	protected virtual void WriteIndent() { }

	// RVA: 0xDF70DC
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0xDF70E0
	protected virtual void WriteIndentSpace() { }

	// RVA: 0xDF70E4
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0xDF7314
	public virtual void WriteNull() { }

	// RVA: 0xDF7330
	public virtual void WriteUndefined() { }

	// RVA: 0xDF734C
	public virtual void WriteRaw(string json) { }

	// RVA: 0xDF7350
	public virtual void WriteRawValue(string json) { }

	// RVA: 0xDF73A4
	public virtual void WriteValue(string value) { }

	// RVA: 0xDF73C0
	public virtual void WriteValue(int value) { }

	// RVA: 0xDF73DC
	public virtual void WriteValue(UInt32 value) { }

	// RVA: 0xDF73F8
	public virtual void WriteValue(Int64 value) { }

	// RVA: 0xDF7414
	public virtual void WriteValue(UInt64 value) { }

	// RVA: 0xDF7430
	public virtual void WriteValue(float value) { }

	// RVA: 0xDF744C
	public virtual void WriteValue(Double value) { }

	// RVA: 0xDF7468
	public virtual void WriteValue(bool value) { }

	// RVA: 0xDF7484
	public virtual void WriteValue(Int16 value) { }

	// RVA: 0xDF74A0
	public virtual void WriteValue(UInt16 value) { }

	// RVA: 0xDF74BC
	public virtual void WriteValue(Char value) { }

	// RVA: 0xDF74D8
	public virtual void WriteValue(Byte value) { }

	// RVA: 0xDF74F4
	public virtual void WriteValue(SByte value) { }

	// RVA: 0xDF7510
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0xDF752C
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0xDF7548
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0xDF7564
	public virtual void WriteValue(Guid value) { }

	// RVA: 0xDF7580
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0xDF759C
	public virtual void WriteValue(System.Nullable<System.Int32> value) { }

	// RVA: 0xDF76F8
	public virtual void WriteValue(System.Nullable<System.UInt32> value) { }

	// RVA: 0xDF7854
	public virtual void WriteValue(System.Nullable<System.Int64> value) { }

	// RVA: 0xDF79B0
	public virtual void WriteValue(System.Nullable<System.UInt64> value) { }

	// RVA: 0xDF7B0C
	public virtual void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xDF7C68
	public virtual void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xDF7DC4
	public virtual void WriteValue(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDF7F20
	public virtual void WriteValue(System.Nullable<System.Int16> value) { }

	// RVA: 0xDF807C
	public virtual void WriteValue(System.Nullable<System.UInt16> value) { }

	// RVA: 0xDF81D8
	public virtual void WriteValue(System.Nullable<System.Char> value) { }

	// RVA: 0xDF8334
	public virtual void WriteValue(System.Nullable<System.Byte> value) { }

	// RVA: 0xDF8490
	public virtual void WriteValue(System.Nullable<System.SByte> value) { }

	// RVA: 0xDF85EC
	public virtual void WriteValue(System.Nullable<System.Decimal> value) { }

	// RVA: 0xDF8784
	public virtual void WriteValue(System.Nullable<System.DateTime> value) { }

	// RVA: 0xDF88E0
	public virtual void WriteValue(System.Nullable<System.DateTimeOffset> value) { }

	// RVA: 0xDF8A34
	public virtual void WriteValue(System.Nullable<System.Guid> value) { }

	// RVA: 0xDF8B88
	public virtual void WriteValue(System.Nullable<System.TimeSpan> value) { }

	// RVA: 0xDF8CE4
	public virtual void WriteValue(Byte[] value) { }

	// RVA: 0xDF8D14
	public virtual void WriteValue(Uri value) { }

	// RVA: 0xDF32F0
	public virtual void WriteValue(object value) { }

	// RVA: 0xDF9E84
	public virtual void WriteComment(string text) { }

	// RVA: 0xDF9E8C
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDF9F20
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xDF8EB4
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xDF9F40
	private static void ResolveConvertibleValue(IConvertible convertible, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xDF8DE4
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0xDFA0FC
	protected void SetWriteState(JsonToken token, object value) { }

	// RVA: 0xDF5D78
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0xDF2BC4
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0xDF3584
	internal void InternalWriteRaw() { }

	// RVA: 0xDF28CC
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0xDF32D8
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0xDF4F8C
	internal void InternalWriteComment() { }

}

// Namespace: Newtonsoft.Json
[Serializable]
public class JsonWriterException
{
	// Fields
	private readonly string <Path>k__BackingField; // 0x90

	// Methods

	// RVA: 0xDFA330
	public void .ctor() { }

	// RVA: 0xDFA338
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xDFA340
	public void .ctor(string message, string path, Exception innerException) { }

	// RVA: 0xDFA378
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0xDFA3B0
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

	// RVA: 0xDFA478
	public void .ctor(TextWriter writer) { }

	// RVA: 0xDFA5A0
	private void ValidateEncode(Byte[] buffer, int index, int count) { }

	// RVA: 0xDFA684
	public void Encode(Byte[] buffer, int index, int count) { }

	// RVA: 0xDFA9C8
	private void StoreLeftOverBytes(Byte[] buffer, int index, int count) { }

	// RVA: 0xDFA8DC
	private bool FulfillFromLeftover(Byte[] buffer, int index, int count) { }

	// RVA: 0xDFAAE4
	public void Flush() { }

	// RVA: 0xDFA9A0
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

	// RVA: 0x3526C14
	public void .ctor(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }

	// RVA: 0x26AD93C
	public void Set(TFirst first, TSecond second) { }

	// RVA: 0x26AD93C
	public bool TryGetByFirst(TFirst first, TSecond second) { }

	// RVA: 0x26AD93C
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

	// RVA: 0xDFAB9C
	internal static object Get(bool value) { }

	// RVA: 0xDFAC38
	internal static object Get(int value) { }

	// RVA: 0xDFAF98
	internal static object Get(Int64 value) { }

	// RVA: 0xDFB22C
	internal static object Get(Decimal value) { }

	// RVA: 0xDFB324
	internal static object Get(Double value) { }

	// RVA: 0xDFB480
	private static void .cctor() { }

}

// Namespace: 
private static class EmptyArrayContainer<T0>
{
	// Fields
	public static readonly T[] Empty; // 0x0

	// Methods

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class CollectionUtils
{
	// Methods

	// RVA: 0x35279B0
	public static bool IsNullOrEmpty(System.Collections.Generic.ICollection<T> collection) { }

	// RVA: 0x352CF50
	public static void AddRange(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0xDFB950
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0xDFBC58
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0xDFBD68
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	// RVA: 0x352899C
	public static int IndexOf(System.Collections.Generic.IEnumerable<T> collection, System.Func<T,System.Boolean> predicate) { }

	// RVA: 0x26AD93C
	public static bool Contains(System.Collections.Generic.List<T> list, T value, IEqualityComparer comparer) { }

	// RVA: 0x26AD93C
	public static int IndexOfReference(System.Collections.Generic.List<T> list, T item) { }

	// RVA: 0x352BD5C
	public static void FastReverse(System.Collections.Generic.List<T> list) { }

	// RVA: 0xDFC0D0
	private static System.Collections.Generic.IList<System.Int32> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0xDFC434
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0xDFC718
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0xDFC8C4
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

	// RVA: 0x35293B4
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

	// RVA: 0x26AD93C
	public virtual void Add(T item) { }

	// RVA: 0x35263A0
	public virtual void Clear() { }

	// RVA: 0x26AD93C
	public virtual bool Contains(T item) { }

	// RVA: 0x3526850
	public virtual void CopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x35254D0
	public virtual int get_Count() { }

	// RVA: 0x35251DC
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x26AD93C
	public virtual bool Remove(T item) { }

	// RVA: 0x3525804
	public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3525600
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x35252FC
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x3525600
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x3526518
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x3526680
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x35251DC
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x35267E8
	private void System.Collections.IList.Remove(object value) { }

	// RVA: -1
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x3526680
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x3526850
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x35251DC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3525804
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x352BD5C
	private static void VerifyValueType(object value) { }

	// RVA: 0x35279B0
	private static bool IsCompatibleObject(object value) { }

	// RVA: 0x3525804
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

	// RVA: 0xDFCAFC
	public Type get_Type() { }

	// RVA: 0xDFCB04
	public PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0xDFCB0C
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

	// RVA: 0xDFD598
	public void .ctor() { }

	// RVA: 0xE01758
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

	// RVA: 0xDFCB54
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0xDFCBC4
	public static PrimitiveTypeCode GetTypeCode(Type t, bool isEnum) { }

	// RVA: 0xDFD074
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0xDFD18C
	public static bool IsConvertible(Type t) { }

	// RVA: 0xDFD240
	public static TimeSpan ParseTimeSpan(string input) { }

	// RVA: 0xDFD308
	private static System.Func<System.Object,System.Object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type> t) { }

	// RVA: 0xDFD5A0
	internal static BigInteger ToBigInteger(object value) { }

	// RVA: 0xDFDA08
	public static object FromBigInteger(BigInteger i, Type targetType) { }

	// RVA: 0xDFDE90
	public static object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0xDFED8C
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, object value) { }

	// RVA: 0xDFE148
	private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, object value) { }

	// RVA: 0xDFF328
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0xDFF0B0
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0xDFEFCC
	public static bool VersionTryParse(string input, Version result) { }

	// RVA: 0xDFEEE0
	public static bool IsInteger(object value) { }

	// RVA: 0xDFF4F4
	public static ParseResult Int32TryParse(Char[] chars, int start, int length, int value) { }

	// RVA: 0xDFF6AC
	public static ParseResult Int64TryParse(Char[] chars, int start, int length, Int64 value) { }

	// RVA: 0xDFF83C
	public static ParseResult DecimalTryParse(Char[] chars, int start, int length, Decimal value) { }

	// RVA: 0xE00360
	public static bool TryConvertGuid(string s, Guid g) { }

	// RVA: 0xE003C0
	public static bool TryHexTextToInt(Char[] text, int start, int end, int value) { }

	// RVA: 0xE0049C
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

	// RVA: 0xE01830
	private static void .cctor() { }

	// RVA: 0xE01AC0
	public bool Parse(Char[] text, int startIndex, int length) { }

	// RVA: 0xE01CC0
	private bool ParseDate(int start) { }

	// RVA: 0xE01FC0
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0xE02238
	private bool ParseTime(int start) { }

	// RVA: 0xE02844
	private bool ParseZone(int start) { }

	// RVA: 0xE02084
	private bool Parse4Digit(int start, int num) { }

	// RVA: 0xE02188
	private bool Parse2Digit(int start, int num) { }

	// RVA: 0xE01F6C
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

	// RVA: 0xE02B8C
	private static void .cctor() { }

	// RVA: 0xE02C90
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0xE02D1C
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0xE02E9C
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0xE03038
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xE03150
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0xE03264
	private static Int64 ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0xE033E0
	private static Int64 ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0xE035A8
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0xE036FC
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0xE03784
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0xE03674
	private static Int64 UniversalTicksToJavaScriptTicks(Int64 universalTicks) { }

	// RVA: 0xE038CC
	internal static DateTime ConvertJavaScriptTicksToDateTime(Int64 javaScriptTicks) { }

	// RVA: 0xE0395C
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, DateTime dt) { }

	// RVA: 0xE03FAC
	internal static bool TryParseDateTimeOffsetIso(StringReference text, DateTimeOffset dt) { }

	// RVA: 0xE03EA8
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0xE04288
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xE049B0
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xE04CC4
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xE05200
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xE05560
	private static bool TryParseMicrosoftDate(StringReference text, Int64 ticks, TimeSpan offset, DateTimeKind kind) { }

	// RVA: 0xE046C8
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, DateTime dt) { }

	// RVA: 0xE048C0
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xE04F6C
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, DateTimeOffset dt) { }

	// RVA: 0xE05140
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xE05800
	private static bool TryReadOffset(StringReference offsetText, int startIndex, TimeSpan offset) { }

	// RVA: 0xE059A4
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0xE05B34
	internal static int WriteDateTimeString(Char[] chars, int start, DateTime value, System.Nullable<System.TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0xE0644C
	internal static int WriteDefaultIsoDate(Char[] chars, int start, DateTime dt) { }

	// RVA: 0xE06C68
	private static void CopyIntToCharArray(Char[] chars, int start, int value, int digits) { }

	// RVA: 0xE06180
	internal static int WriteDateTimeOffset(Char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0xE06CD4
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0xE06A0C
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

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }

	// RVA: -1
	public DictionaryEntry get_Entry() { }

	// RVA: 0x3525804
	public object get_Key() { }

	// RVA: 0x3525804
	public object get_Value() { }

	// RVA: 0x3525804
	public object get_Current() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x35263A0
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

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
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

	// RVA: 0x3525804
	internal System.Collections.Generic.IDictionary<TKey,TValue> get_GenericDictionary() { }

	// RVA: 0x26AD93C
	public void Add(TKey key, TValue value) { }

	// RVA: 0x26AD93C
	public bool ContainsKey(TKey key) { }

	// RVA: 0x3525804
	public System.Collections.Generic.ICollection<TKey> get_Keys() { }

	// RVA: 0x26AD93C
	public bool Remove(TKey key) { }

	// RVA: 0x26AD93C
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x3525804
	public System.Collections.Generic.ICollection<TValue> get_Values() { }

	// RVA: 0x26AD93C
	public TValue get_Item(TKey key) { }

	// RVA: 0x26AD93C
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x26AD93C
	public void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x35263A0
	public void Clear() { }

	// RVA: 0x26AD93C
	public bool Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x3526850
	public void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x35251DC
	public bool get_IsReadOnly() { }

	// RVA: 0x26AD93C
	public bool Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x3525804
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x35269D4
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x35258B4
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x35269D4
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x3525804
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x35252FC
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x35251DC
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x3525804
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x35267E8
	public void Remove(object key) { }

	// RVA: 0x3525804
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x3526850
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x35251DC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3525804
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x3525804
	public object get_UnderlyingDictionary() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class DynamicProxy<T0>
{
	// Methods

	// RVA: 0x26AD93C
	public virtual System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(T instance) { }

	// RVA: 0x26AD93C
	public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, object result) { }

	// RVA: 0x26AD93C
	public virtual bool TryConvert(T instance, ConvertBinder binder, object result) { }

	// RVA: 0x26AD93C
	public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, object result) { }

	// RVA: 0x26AD93C
	public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes) { }

	// RVA: 0x26AD93C
	public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder) { }

	// RVA: 0x26AD93C
	public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, object result) { }

	// RVA: 0x26AD93C
	public virtual bool TryGetMember(T instance, GetMemberBinder binder, object result) { }

	// RVA: 0x26AD93C
	public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, object result) { }

	// RVA: 0x26AD93C
	public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, object result) { }

	// RVA: 0x26AD93C
	public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value) { }

	// RVA: 0x26AD93C
	public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value) { }

	// RVA: 0x26AD93C
	public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, object result) { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: 
private sealed class Fallback
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35258B4
	public virtual DynamicMetaObject Invoke(DynamicMetaObject errorSuggestion) { }

}

// Namespace: 
private sealed class GetBinderAdapter
{
	// Methods

	// RVA: 0x35267E8
	internal void .ctor(InvokeMemberBinder binder) { }

	// RVA: 0x3525998
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

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
	internal DynamicMetaObject <BindBinaryOperation>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public UnaryOperationBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
	internal DynamicMetaObject <BindDeleteIndex>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public GetMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
	internal DynamicMetaObject <BindSetMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public DeleteMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
	internal DynamicMetaObject <BindDeleteMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public ConvertBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
	internal DynamicMetaObject <BindInvokeMember>b__0(DynamicMetaObject e) { }

	// RVA: 0x35258B4
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
	internal DynamicMetaObject <BindInvoke>b__0(DynamicMetaObject e) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class DynamicProxyMetaObject<T0>
{
	// Fields
	private readonly Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy; // 0x0

	// Methods

	// RVA: 0x26AD93C
	internal void .ctor(Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy) { }

	// RVA: 0x35252FC
	private bool IsOverridden(string method) { }

	// RVA: 0x35258B4
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x3525998
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x35258B4
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x35258B4
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }

	// RVA: 0x3525998
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x3525998
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x3525998
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x3525998
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	// RVA: 0x35258B4
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	// RVA: 0x3525998
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x3525A08
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: 0x3525998
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x35293B4
	private static Expression[] get_NoArgs() { }

	// RVA: 0x35293EC
	private static System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(DynamicMetaObject[] args) { }

	// RVA: 0x35293EC
	private static Expression[] GetArgArray(DynamicMetaObject[] args) { }

	// RVA: 0x35294CC
	private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value) { }

	// RVA: 0x35293EC
	private static ConstantExpression Constant(DynamicMetaObjectBinder binder) { }

	// RVA: 0x3525AEC
	private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Fallback fallback, Fallback fallbackInvoke) { }

	// RVA: 0x3525AEC
	private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, DynamicMetaObject fallbackResult, Fallback fallbackInvoke) { }

	// RVA: 0x3525A7C
	private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Fallback fallback) { }

	// RVA: 0x3525A7C
	private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Fallback fallback) { }

	// RVA: 0x3525804
	private BindingRestrictions GetRestrictions() { }

	// RVA: 0x3525804
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

	// RVA: 0xE06FF4
	private static void Init() { }

	// RVA: 0xE071E4
	private static object CreateSharpArgumentInfoArray(int[] values) { }

	// RVA: 0xE074B8
	private static void CreateMemberCalls() { }

	// RVA: 0xE079CC
	public static CallSiteBinder GetMember(string name, Type context) { }

	// RVA: 0xE07BD8
	public static CallSiteBinder SetMember(string name, Type context) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class DynamicUtils
{
	// Methods

	// RVA: 0xE06ED0
	public static System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowGetBinderMember
{
	// Fields
	private readonly GetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0xE07DE4
	public void .ctor(GetMemberBinder innerBinder) { }

	// RVA: 0xE07E28
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowSetBinderMember
{
	// Fields
	private readonly SetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0xE07FC0
	public void .ctor(SetMemberBinder innerBinder) { }

	// RVA: 0xE08004
	public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowExpressionVisitor
{
	// Fields
	internal static readonly object ErrorResult; // 0x0

	// Methods

	// RVA: 0xE0815C
	protected override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0xE07FB8
	public void .ctor() { }

	// RVA: 0xE08254
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

	// RVA: 0xE082DC
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

	// RVA: 0xE09D30
	private static void .cctor() { }

	// RVA: 0xE09D9C
	public void .ctor() { }

	// RVA: 0xE09DA4
	internal string <InitializeValuesAndNames>b__3_0(EnumMemberAttribute a) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class EnumUtils
{
	// Fields
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum; // 0x0
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x8

	// Methods

	// RVA: 0xE08350
	private static EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy> key) { }

	// RVA: 0xE08C1C
	public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, string name) { }

	// RVA: 0xE08DD8
	private static string InternalFlagsFormat(EnumInfo entry, UInt64 result) { }

	// RVA: 0xE0904C
	public static EnumInfo GetEnumValuesAndNames(Type enumType) { }

	// RVA: 0xE088E4
	private static UInt64 ToUInt64(object value) { }

	// RVA: 0xE09124
	public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	// RVA: 0xE09AE0
	private static System.Nullable<System.Int32> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0xE099E0
	private static System.Nullable<System.Int32> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0xE09BF8
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class FSharpFunction
{
	// Fields
	private readonly object _instance; // 0x10
	private readonly Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _invoker; // 0x18

	// Methods

	// RVA: 0xE09DC0
	public void .ctor(object instance, Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoker) { }

	// RVA: 0xE09E10
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

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal System.Tuple<TKey,TValue> <BuildMapCreator>b__55_1(System.Collections.Generic.KeyValuePair<TKey,TValue> kv) { }

}

// Namespace: 
private sealed class <>c__DisplayClass52_0
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoke; // 0x18

	// Methods

	// RVA: 0xE0A998
	public void .ctor() { }

	// RVA: 0xE0AD10
	internal object <CreateFSharpFuncCall>b__0(object target, object[] args) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0<T0, T1>
{
	// Fields
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> ctorDelegate; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35258B4
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

	// RVA: 0xE09E54
	private void .ctor(Assembly fsharpCoreAssembly) { }

	// RVA: 0xE0A6DC
	public static FSharpUtils get_Instance() { }

	// RVA: 0xE0A758
	private void set_FSharpCoreAssembly(Assembly value) { }

	// RVA: 0xE0A760
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_IsUnion() { }

	// RVA: 0xE0A768
	private void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xE0A770
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCases() { }

	// RVA: 0xE0A778
	private void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xE0A780
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionTagReader() { }

	// RVA: 0xE0A788
	private void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xE0A790
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionReader() { }

	// RVA: 0xE0A798
	private void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xE0A7A0
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionConstructor() { }

	// RVA: 0xE0A7A8
	private void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xE0A7B0
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoDeclaringType() { }

	// RVA: 0xE0A7B8
	private void set_GetUnionCaseInfoDeclaringType(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xE0A7C0
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoName() { }

	// RVA: 0xE0A7C8
	private void set_GetUnionCaseInfoName(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xE0A7D0
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoTag() { }

	// RVA: 0xE0A7D8
	private void set_GetUnionCaseInfoTag(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xE0A7E0
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCaseInfoFields() { }

	// RVA: 0xE0A7E8
	private void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xE0A7F0
	public static void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	// RVA: 0xE0A42C
	private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	// RVA: 0xE0A4A4
	private static Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> CreateFSharpFuncCall(Type type, string methodName) { }

	// RVA: 0xE0A9A0
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateSeq(Type t) { }

	// RVA: 0xE0AAA8
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateMap(Type keyType, Type valueType) { }

	// RVA: 0x3525804
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> BuildMapCreator() { }

	// RVA: 0xE0AC88
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

	// RVA: 0xE0BFCC
	public void .ctor(string contractTypeName, string createdTypeName, string builderTypeName) { }

	// RVA: 0xE0C030
	public string get_ContractTypeName() { }

	// RVA: 0xE0C038
	public void set_ContractTypeName(string value) { }

	// RVA: 0xE0C040
	public string get_CreatedTypeName() { }

	// RVA: 0xE0C048
	public void set_CreatedTypeName(string value) { }

	// RVA: 0xE0C050
	public string get_BuilderTypeName() { }

	// RVA: 0xE0C058
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

	// RVA: 0xE0C060
	private static void .cctor() { }

	// RVA: 0xE0C0CC
	public void .ctor() { }

	// RVA: 0xE0C0D4
	internal bool <TryBuildImmutableForArrayContract>b__24_1(MethodInfo m) { }

	// RVA: 0xE0C164
	internal bool <TryBuildImmutableForDictionaryContract>b__25_1(MethodInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass24_0
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0xE0B2C4
	public void .ctor() { }

	// RVA: 0xE0C2C0
	internal bool <TryBuildImmutableForArrayContract>b__0(ImmutableCollectionTypeInfo d) { }

}

// Namespace: 
private sealed class <>c__DisplayClass25_0
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0xE0B830
	public void .ctor() { }

	// RVA: 0xE0C2E8
	internal bool <TryBuildImmutableForDictionaryContract>b__0(ImmutableCollectionTypeInfo d) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ImmutableCollectionsUtils
{
	// Fields
	private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x0
	private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x8

	// Methods

	// RVA: 0xE0ADD4
	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, Type createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }

	// RVA: 0xE0B2F0
	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, Type createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }

	// RVA: 0xE0B838
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class BufferUtils
{
	// Methods

	// RVA: 0xE0C310
	public static Char[] RentBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int minSize) { }

	// RVA: 0xE0C3E8
	public static void ReturnBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] buffer) { }

	// RVA: 0xE0C4A8
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

	// RVA: 0xE0C5E8
	private static void .cctor() { }

	// RVA: 0xE0D064
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, Char quoteChar) { }

	// RVA: 0xE0D150
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	// RVA: 0xE0D1FC
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, Char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] writeBuffer) { }

	// RVA: 0xE0DAFC
	public static string ToEscapedJavaScriptString(string value, Char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xE0D91C
	private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xE0DE58
	public static bool TryGetDateFromConstructorJson(JsonReader reader, DateTime dateTime, string errorMessage) { }

	// RVA: 0xE0E39C
	private static bool TryGetDateConstructorValue(JsonReader reader, System.Nullable<System.Int64>& integer, string errorMessage) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class JsonTokenUtils
{
	// Methods

	// RVA: 0xE0E568
	internal static bool IsEndToken(JsonToken token) { }

	// RVA: 0xE0E578
	internal static bool IsStartToken(JsonToken token) { }

	// RVA: 0xE0E588
	internal static bool IsPrimitiveToken(JsonToken token) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public ConstructorInfo c; // 0x10
	public MethodBase method; // 0x18

	// Methods

	// RVA: 0xE0E7E0
	public void .ctor() { }

	// RVA: 0xE0E864
	internal object <CreateParameterizedConstructor>b__0(object[] a) { }

	// RVA: 0xE0E884
	internal object <CreateParameterizedConstructor>b__1(object[] a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0<T0>
{
	// Fields
	public ConstructorInfo c; // 0x0
	public MethodBase method; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal object <CreateMethodCall>b__0(T o, object[] a) { }

	// RVA: 0x26AD93C
	internal object <CreateMethodCall>b__1(T o, object[] a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0<T0>
{
	// Fields
	public Type type; // 0x0
	public ConstructorInfo constructorInfo; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal T <CreateDefaultConstructor>b__0() { }

	// RVA: 0x26AD93C
	internal T <CreateDefaultConstructor>b__1() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0<T0>
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal object <CreateGet>b__0(T o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0<T0>
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal object <CreateGet>b__0(T o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0<T0>
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal void <CreateSet>b__0(T o, object v) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0<T0>
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal void <CreateSet>b__0(T o, object v) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class LateBoundReflectionDelegateFactory
{
	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x0

	// Methods

	// RVA: 0xE0E5A0
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0xE0E61C
	public override Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: 0x35258B4
	public override Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(MethodBase method) { }

	// RVA: 0x35258B4
	public override System.Func<T> CreateDefaultConstructor(Type type) { }

	// RVA: 0x35258B4
	public override System.Func<T,System.Object> CreateGet(PropertyInfo propertyInfo) { }

	// RVA: 0x35258B4
	public override System.Func<T,System.Object> CreateGet(FieldInfo fieldInfo) { }

	// RVA: 0x35258B4
	public override System.Action<T,System.Object> CreateSet(FieldInfo fieldInfo) { }

	// RVA: 0x35258B4
	public override System.Action<T,System.Object> CreateSet(PropertyInfo propertyInfo) { }

	// RVA: 0xE0E7E8
	public void .ctor() { }

	// RVA: 0xE0E7F8
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class MathUtils
{
	// Methods

	// RVA: 0xE0E8AC
	public static int IntLength(UInt64 i) { }

	// RVA: 0xE0EA74
	public static Char IntToHex(int n) { }

	// RVA: 0xE0EA90
	public static bool ApproxEquals(Double d1, Double d2) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class MethodCall<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual TResult Invoke(T target, object[] args) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class MiscellaneousUtils
{
	// Methods

	// RVA: 0xE0EB44
	public static bool ValueEquals(object objA, object objB) { }

	// RVA: 0xE02DA4
	public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	// RVA: 0xE0EF20
	public static string ToString(object value) { }

	// RVA: 0xE0EFC8
	public static int ByteArrayCompare(Byte[] a1, Byte[] a2) { }

	// RVA: 0xE0F090
	public static string GetPrefix(string qualifiedName) { }

	// RVA: 0xE0F188
	public static string GetLocalName(string qualifiedName) { }

	// RVA: 0xE0F0BC
	public static void GetQualifiedNameParts(string qualifiedName, string prefix, string localName) { }

	// RVA: 0xE0F1CC
	internal static RegexOptions GetRegexOptions(string optionsText) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal abstract class ReflectionDelegateFactory
{
	// Methods

	// RVA: 0x35258B4
	public System.Func<T,System.Object> CreateGet(MemberInfo memberInfo) { }

	// RVA: 0x35258B4
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

	// RVA: 0xE0E7F0
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

	// RVA: 0xE0F280
	public Type get_MemberType() { }

	// RVA: 0xE0F288
	public void set_MemberType(Type value) { }

	// RVA: 0xE0F290
	public System.Func<System.Object,System.Object> get_Getter() { }

	// RVA: 0xE0F298
	public void set_Getter(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xE0F2A0
	public System.Action<System.Object,System.Object> get_Setter() { }

	// RVA: 0xE0F2A8
	public void set_Setter(System.Action<System.Object,System.Object> value) { }

	// RVA: 0xE0F2B0
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public System.Func<System.Object> ctor; // 0x10

	// Methods

	// RVA: 0xE0FFEC
	public void .ctor() { }

	// RVA: 0xE105B8
	internal object <Create>b__0(object[] args) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_1
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10

	// Methods

	// RVA: 0xE10314
	public void .ctor() { }

	// RVA: 0xE105F4
	internal object <Create>b__1(object target) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_2
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10

	// Methods

	// RVA: 0xE1031C
	public void .ctor() { }

	// RVA: 0xE1070C
	internal void <Create>b__2(object target, object arg) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ReflectionObject
{
	// Fields
	private readonly Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <Creator>k__BackingField; // 0x10
	private readonly System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE0F2B8
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_Creator() { }

	// RVA: 0xE0F2C0
	public System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> get_Members() { }

	// RVA: 0xE0F2C8
	private void .ctor(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator) { }

	// RVA: 0xE0F370
	public object GetValue(object target, string member) { }

	// RVA: 0xE0F470
	public void SetValue(object target, string member, object value) { }

	// RVA: 0xE0F56C
	public Type GetType(string member) { }

	// RVA: 0xE0F63C
	public static ReflectionObject Create(Type t, string[] memberNames) { }

	// RVA: 0xE0F648
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

	// RVA: 0xE14F20
	private static void .cctor() { }

	// RVA: 0xE14F8C
	public void .ctor() { }

	// RVA: 0xE14F94
	internal bool <GetDefaultConstructor>b__11_0(ConstructorInfo c) { }

	// RVA: 0xE15000
	internal string <GetFieldsAndProperties>b__31_0(MemberInfo m) { }

	// RVA: 0xE15028
	internal Type <GetMemberInfoFromType>b__39_0(ParameterInfo p) { }

	// RVA: 0xE15050
	internal bool <GetChildPrivateFields>b__41_0(FieldInfo f) { }

}

// Namespace: 
private sealed class <>c__DisplayClass31_0
{
	// Fields
	public MemberInfo memberInfo; // 0x10

	// Methods

	// RVA: 0xE13848
	public void .ctor() { }

	// RVA: 0xE1506C
	internal bool <GetFieldsAndProperties>b__1(MemberInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass44_0
{
	// Fields
	public PropertyInfo subTypeProperty; // 0x10

	// Methods

	// RVA: 0xE14B24
	public void .ctor() { }

	// RVA: 0xE150FC
	internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	// RVA: 0xE15158
	internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass44_1
{
	// Fields
	public Type subTypePropertyDeclaringType; // 0x10
	public Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xE14B2C
	public void .ctor() { }

	// RVA: 0xE15224
	internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_0
{
	// Fields
	public string method; // 0x10
	public Type methodDeclaringType; // 0x18

	// Methods

	// RVA: 0xE14C50
	public void .ctor() { }

	// RVA: 0xE1535C
	internal bool <IsMethodOverridden>b__0(MethodInfo info) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ReflectionUtils
{
	// Fields
	public static readonly Type[] EmptyTypes; // 0x0

	// Methods

	// RVA: 0xE107EC
	private static void .cctor() { }

	// RVA: 0xE10864
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	// RVA: 0xE10990
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0xE10A84
	public static bool IsPublic(PropertyInfo property) { }

	// RVA: 0xDFF4E4
	public static Type GetObjectType(object v) { }

	// RVA: 0xE10B30
	public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder) { }

	// RVA: 0xE10C54
	private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder) { }

	// RVA: 0xE10D9C
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0xE0FED4
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0xE11094
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0xE10F30
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0xDFEFD4
	public static bool IsNullable(Type t) { }

	// RVA: 0xDFCF6C
	public static bool IsNullableType(Type t) { }

	// RVA: 0xE1111C
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0xE111B8
	public static Type EnsureNotByRefType(Type t) { }

	// RVA: 0xE11218
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0xDFBBDC
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0xE112B4
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, Type implementingType) { }

	// RVA: 0xE1158C
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0xE11608
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, Type implementingType) { }

	// RVA: 0xE11798
	private static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, Type implementingType) { }

	// RVA: 0xE118E8
	public static Type GetCollectionItemType(Type type) { }

	// RVA: 0xE11B64
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, Type keyType, Type valueType) { }

	// RVA: 0xE10324
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0xE11DE8
	public static bool IsByRefLikeType(Type type) { }

	// RVA: 0xE123E4
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0xE12490
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0xE127D0
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0xE10014
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0xE1017C
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0xE12A00
	public static System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0xE13850
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: 0x26AD93C
	public static T GetAttribute(object attributeProvider) { }

	// RVA: 0x26AD93C
	public static T GetAttribute(object attributeProvider, bool inherit) { }

	// RVA: -1
	public static T[] GetAttributes(object attributeProvider, bool inherit) { }

	// RVA: 0xE11EF8
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0xE13A40
	public static Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) { }

	// RVA: 0xE13CFC
	private static System.Nullable<System.Int32> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0xE13F84
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0xE13380
	public static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0xE14214
	private static void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, Type type, BindingFlags bindingAttr) { }

	// RVA: 0xE134CC
	public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0xE14408
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0xE14418
	private static void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr) { }

	// RVA: 0xE14B34
	public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method) { }

	// RVA: 0xE14C58
	public static object GetDefaultValue(Type type) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StringBuffer
{
	// Fields
	private Char[] _buffer; // 0x10
	private int _position; // 0x18

	// Methods

	// RVA: 0xE1546C
	public int get_Position() { }

	// RVA: 0xE15474
	public void set_Position(int value) { }

	// RVA: 0xE1547C
	public bool get_IsEmpty() { }

	// RVA: 0xE1548C
	public void .ctor(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int initalSize) { }

	// RVA: 0xE154C8
	private void .ctor(Char[] buffer) { }

	// RVA: 0xE154F0
	public void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char value) { }

	// RVA: 0xE15668
	public void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] buffer, int startIndex, int count) { }

	// RVA: 0xE156EC
	public void Clear(Newtonsoft.Json.IArrayPool<System.Char> bufferPool) { }

	// RVA: 0xE1556C
	private void EnsureSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int appendLength) { }

	// RVA: 0xE157BC
	public override string ToString() { }

	// RVA: 0xE157D4
	public string ToString(int start, int length) { }

	// RVA: 0xE157EC
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

	// RVA: 0xE044D0
	public Char get_Item(int i) { }

	// RVA: 0xE157F4
	public Char[] get_Chars() { }

	// RVA: 0xE157FC
	public int get_StartIndex() { }

	// RVA: 0xE15804
	public int get_Length() { }

	// RVA: 0xE04C8C
	public void .ctor(Char[] chars, int startIndex, int length) { }

	// RVA: 0xE048AC
	public override string ToString() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class StringReferenceExtensions
{
	// Methods

	// RVA: 0xE05764
	public static int IndexOf(StringReference s, Char c, int startIndex, int length) { }

	// RVA: 0xE04504
	public static bool StartsWith(StringReference s, string text) { }

	// RVA: 0xE045E4
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }

	// RVA: 0x26AD93C
	internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class StringUtils
{
	// Methods

	// RVA: 0xE048A4
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0xDFD948
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	// RVA: 0xDFEC94
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	// RVA: 0xE158B0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	// RVA: 0xE159E8
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	// RVA: 0xE1580C
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0xE0DD90
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0xE0DA44
	public static void ToCharAsUnicode(Char c, Char[] buffer) { }

	// RVA: 0x26AD93C
	public static TSource ForgivingCaseSensitiveFind(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.String> valueSelector, string testValue) { }

	// RVA: 0xE15B58
	public static string ToCamelCase(string s) { }

	// RVA: 0xE15FD8
	private static Char ToLower(Char c) { }

	// RVA: 0xE16064
	public static string ToSnakeCase(string s) { }

	// RVA: 0xE16380
	public static string ToKebabCase(string s) { }

	// RVA: 0xE1606C
	private static string ToSeparatedCase(string s, Char separator) { }

	// RVA: 0xE16388
	public static bool IsHighSurrogate(Char c) { }

	// RVA: 0xE163D8
	public static bool IsLowSurrogate(Char c) { }

	// RVA: 0xE0F1B4
	public static int IndexOf(string s, Char c) { }

	// RVA: 0xE16428
	public static bool StartsWith(string source, Char value) { }

	// RVA: 0xE1647C
	public static bool EndsWith(string source, Char value) { }

	// RVA: 0xE13DE4
	public static string Trim(string s, int start, int length) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StructMultiKey<T0, T1>
{
	// Fields
	public readonly T1 Value1; // 0x0
	public readonly T2 Value2; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public void .ctor(T1 v1, T2 v2) { }

	// RVA: 0x35254D0
	public override int GetHashCode() { }

	// RVA: 0x35252FC
	public override bool Equals(object obj) { }

	// RVA: 0x26AD93C
	public bool Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1,T2> other) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ThreadSafeStore<T0, T1>
{
	// Fields
	private readonly System.Collections.Concurrent.ConcurrentDictionary<TKey,TValue> _concurrentStore; // 0x0
	private readonly System.Func<TKey,TValue> _creator; // 0x0

	// Methods

	// RVA: 0x35267E8
	public void .ctor(System.Func<TKey,TValue> creator) { }

	// RVA: 0x26AD93C
	public TValue Get(TKey key) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class TypeExtensions
{
	// Methods

	// RVA: 0xE0FFF4
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	// RVA: 0xE164CC
	public static bool ContainsGenericParameters(Type type) { }

	// RVA: 0xDFF2D4
	public static bool IsInterface(Type type) { }

	// RVA: 0xE0B2A0
	public static bool IsGenericType(Type type) { }

	// RVA: 0xDFF2EC
	public static bool IsGenericTypeDefinition(Type type) { }

	// RVA: 0xE118C4
	public static Type BaseType(Type type) { }

	// RVA: 0xE0B2CC
	public static Assembly Assembly(Type type) { }

	// RVA: 0xDFCF48
	public static bool IsEnum(Type type) { }

	// RVA: 0xE11780
	public static bool IsClass(Type type) { }

	// RVA: 0xE164F0
	public static bool IsSealed(Type type) { }

	// RVA: 0xDFF310
	public static bool IsAbstract(Type type) { }

	// RVA: 0xE16508
	public static bool IsVisible(Type type) { }

	// RVA: 0xE10F18
	public static bool IsValueType(Type type) { }

	// RVA: 0xE16520
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, Type match) { }

	// RVA: 0xE1669C
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	// RVA: 0xE166C0
	public static bool ImplementInterface(Type type, Type interfaceType) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ValidationUtils
{
	// Methods

	// RVA: 0xDFA550
	public static void ArgumentNotNull(object value, string parameterName) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal static class CachedAttributeGetter<T0>
{
	// Fields
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Object,T> TypeAttributeCache; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public static T GetAttribute(object type) { }

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class CamelCaseNamingStrategy
{
	// Methods

	// RVA: 0xE16AA0
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xE16ADC
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xE09D28
	public void .ctor() { }

	// RVA: 0xE16B20
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

	// RVA: 0x3526518
	public void .ctor(int <>1__state) { }

	// RVA: 0x35263A0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35251DC
	private bool MoveNext() { }

	// RVA: 0x35263A0
	private void <>m__Finally1() { }

	// RVA: -1
	private System.Collections.Generic.KeyValuePair<System.Object,System.Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
internal class EnumerableDictionaryWrapper<T0, T1>
{
	// Fields
	private readonly System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> _e; // 0x0

	// Methods

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }

	// RVA: 0x3525804
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> GetEnumerator() { }

	// RVA: 0x3525804
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

	// RVA: 0xE1ECA0
	private static void .cctor() { }

	// RVA: 0xE1ED0C
	public void .ctor() { }

	// RVA: 0xE1ED14
	internal bool <GetSerializableMembers>b__40_0(MemberInfo m) { }

	// RVA: 0xE1EDCC
	internal bool <GetSerializableMembers>b__40_1(MemberInfo m) { }

	// RVA: 0xE1EE3C
	internal System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(Type baseType) { }

	// RVA: 0xE1EF20
	internal bool <GetExtensionDataMemberForType>b__44_1(MemberInfo m) { }

	// RVA: 0xE1F2F8
	internal bool <GetAttributeConstructor>b__47_0(ConstructorInfo c) { }

	// RVA: 0xE1F3B0
	internal int <CreateProperties>b__75_0(JsonProperty p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass42_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xE1F4E4
	public void .ctor() { }

	// RVA: 0xE1F4EC
	internal string <CreateObjectContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_0
{
	// Fields
	public System.Func<System.Object,System.Object> getExtensionDataDictionary; // 0x10
	public MemberInfo member; // 0x18

	// Methods

	// RVA: 0xE1F510
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

	// RVA: 0xE1F518
	public void .ctor() { }

	// RVA: 0xE1F520
	internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_2
{
	// Fields
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> createEnumerableWrapper; // 0x10
	public Newtonsoft.Json.Serialization.DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xE1F750
	public void .ctor() { }

	// RVA: 0xE1F758
	internal System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> <SetExtensionDataDelegates>b__1(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass62_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xE1F8A0
	public void .ctor() { }

	// RVA: 0xE1F8A8
	internal string <CreateDictionaryContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass67_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xE1F8CC
	public void .ctor() { }

	// RVA: 0xE1F8D4
	internal string <CreateDynamicContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass80_0
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> shouldSerializeCall; // 0x10

	// Methods

	// RVA: 0xE1F8F8
	public void .ctor() { }

	// RVA: 0xE1F900
	internal bool <CreateShouldSerializeTest>b__0(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass81_0
{
	// Fields
	public System.Func<System.Object,System.Object> specifiedPropertyGet; // 0x10

	// Methods

	// RVA: 0xE1FA4C
	public void .ctor() { }

	// RVA: 0xE1FA54
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

	// RVA: 0xE16B28
	internal static IContractResolver get_Instance() { }

	// RVA: 0xE16BA4
	public BindingFlags get_DefaultMembersSearchFlags() { }

	// RVA: 0xE16BAC
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	// RVA: 0xE16BB4
	public bool get_SerializeCompilerGeneratedMembers() { }

	// RVA: 0xE16BBC
	public bool get_IgnoreSerializableInterface() { }

	// RVA: 0xE16BC4
	public bool get_IgnoreSerializableAttribute() { }

	// RVA: 0xE16BCC
	public void set_IgnoreSerializableAttribute(bool value) { }

	// RVA: 0xE16BD4
	public bool get_IgnoreIsSpecifiedMembers() { }

	// RVA: 0xE16BDC
	public bool get_IgnoreShouldSerializeMembers() { }

	// RVA: 0xE16BE4
	public NamingStrategy get_NamingStrategy() { }

	// RVA: 0xE16BEC
	public void .ctor() { }

	// RVA: 0xE16D00
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0xE16DCC
	private static bool FilterMembers(MemberInfo member) { }

	// RVA: 0xE16F48
	protected virtual System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0xE17B18
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0xE17C2C
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0xE19A38
	private static void ThrowUnableToSerializeError(object o, StreamingContext context) { }

	// RVA: 0xE18E88
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0xE190AC
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0xE1857C
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0xE18B2C
	private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	// RVA: 0xE18ADC
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0xE19D1C
	protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0xE19C8C
	private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	// RVA: 0xE19EF8
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0xE1AB48
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0xE1ABD0
	private System.Func<System.Object> GetDefaultCreator(Type createdType) { }

	// RVA: 0xE18290
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0xE1AC94
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0xE1ADE0
	private void GetCallbackMethodsForType(Type type, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback>& onError) { }

	// RVA: 0xE1BED8
	private static bool IsConcurrentOrObservableCollection(Type t) { }

	// RVA: 0xE1B7A0
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0xE1B6A0
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0xE19AD0
	private System.Collections.Generic.List<System.Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0xE1C06C
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0xE1C64C
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0xE1C9A8
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0xE1CA20
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0xE1CA98
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0xE1CD04
	protected virtual JsonDynamicContract CreateDynamicContract(Type objectType) { }

	// RVA: 0xE1CF50
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0xE1CFC8
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0xE1D560
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0xE1D77C
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0xE1D630
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0xE1B8A0
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, Type prevAttributeType) { }

	// RVA: 0xE1D92C
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0xE1DA38
	protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0xE1DF08
	internal virtual DefaultJsonNameTable GetNameTable() { }

	// RVA: 0xE1DF10
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0xE1DF78
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0xE1A388
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, bool allowNonPublicAccess) { }

	// RVA: 0xE1E1A0
	private System.Predicate<System.Object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0xE1E3E8
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0xE1E704
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0xE1E724
	protected virtual string ResolveExtensionDataName(string extensionDataName) { }

	// RVA: 0xE1E740
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0xE1E76C
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0xE1E77C
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultNamingStrategy
{
	// Methods

	// RVA: 0xE1FAC0
	protected override string ResolvePropertyName(string name) { }

	// RVA: 0xE1FAC8
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class DefaultReferenceResolver
{
	// Fields
	private int _referenceCount; // 0x10

	// Methods

	// RVA: 0xE1FAD0
	private Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> GetMappings(object context) { }

	// RVA: 0xE1FD08
	public object ResolveReference(object context, string reference) { }

	// RVA: 0xE1FD88
	public string GetReference(object context, object value) { }

	// RVA: 0xE1FE88
	public void AddReference(object context, string reference, object value) { }

	// RVA: 0xE1FEF8
	public bool IsReferenced(object context, object value) { }

	// RVA: 0xE1FF74
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultSerializationBinder
{
	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String>,System.Type> _typeCache; // 0x10

	// Methods

	// RVA: 0xE1FF7C
	public void .ctor() { }

	// RVA: 0xE20058
	private Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }

	// RVA: 0xE20470
	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	// RVA: 0xE20708
	private Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }

	// RVA: 0xE20788
	public override Type BindToType(string assemblyName, string typeName) { }

	// RVA: 0xE2085C
	public override void BindToName(Type serializedType, string assemblyName, string typeName) { }

	// RVA: 0xE208E4
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

	// RVA: 0xE2094C
	internal void .ctor(object originalObject, object member, string path, Exception error) { }

	// RVA: 0xE209CC
	internal bool get_Traced() { }

	// RVA: 0xE209D4
	internal void set_Traced(bool value) { }

	// RVA: 0xE209DC
	public Exception get_Error() { }

	// RVA: 0xE209E4
	public bool get_Handled() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class ErrorEventArgs
{
	// Fields
	private readonly object <CurrentObject>k__BackingField; // 0x10
	private readonly ErrorContext <ErrorContext>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE209EC
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

	// RVA: 0xE20A80
	public Type get_CollectionItemType() { }

	// RVA: 0xE20A88
	public bool get_IsMultidimensionalArray() { }

	// RVA: 0xE20A90
	internal bool get_IsArray() { }

	// RVA: 0xE20A98
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0xE20AA0
	internal bool get_CanDeserialize() { }

	// RVA: 0xE20AA8
	private void set_CanDeserialize(bool value) { }

	// RVA: 0xE20AB0
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xE20BB4
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xE20BBC
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xE20BEC
	public bool get_HasParameterizedCreator() { }

	// RVA: 0xE20BF4
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0xE20BFC
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0xE20C98
	public void .ctor(Type underlyingType) { }

	// RVA: 0xE22014
	internal IWrappedCollection CreateWrapper(object list) { }

	// RVA: 0xE22440
	internal IList CreateTemporaryCollection() { }

	// RVA: 0xE21E30
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

	// RVA: 0xE226D8
	internal JsonContract get_ItemContract() { }

	// RVA: 0xE226E0
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0xE2274C
	internal JsonContract get_FinalItemContract() { }

	// RVA: 0xE22754
	public JsonConverter get_ItemConverter() { }

	// RVA: 0xE2275C
	public void set_ItemConverter(JsonConverter value) { }

	// RVA: 0xE22764
	public System.Nullable<System.Boolean> get_ItemIsReference() { }

	// RVA: 0xE2276C
	public void set_ItemIsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xE22774
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	// RVA: 0xE2277C
	public void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xE22784
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }

	// RVA: 0xE2278C
	public void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xE21C40
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

	// RVA: 0xE22920
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xE22A44
	public virtual void Invoke(object o, StreamingContext context) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationErrorCallback
{
	// Methods

	// RVA: 0xE22A58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xE22B7C
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataSetter
{
	// Methods

	// RVA: 0xE22B90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xE22CB4
	public virtual void Invoke(object o, string key, object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataGetter
{
	// Methods

	// RVA: 0xE22CC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xE22DE8
	public virtual System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> Invoke(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass57_0
{
	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0xE23BF0
	public void .ctor() { }

	// RVA: 0xE23CBC
	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

}

// Namespace: 
private sealed class <>c__DisplayClass58_0
{
	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0xE23CB4
	public void .ctor() { }

	// RVA: 0xE23DC8
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

	// RVA: 0xE22DFC
	public Type get_UnderlyingType() { }

	// RVA: 0xE22E04
	public Type get_CreatedType() { }

	// RVA: 0xE21D70
	public void set_CreatedType(Type value) { }

	// RVA: 0xE22E0C
	public System.Nullable<System.Boolean> get_IsReference() { }

	// RVA: 0xE22E14
	public void set_IsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xE22E1C
	public JsonConverter get_Converter() { }

	// RVA: 0xE22E24
	public void set_Converter(JsonConverter value) { }

	// RVA: 0xE22E2C
	public JsonConverter get_InternalConverter() { }

	// RVA: 0xE22E34
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0xE22E3C
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0xE22ED8
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0xE22F74
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0xE23010
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0xE230AC
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks() { }

	// RVA: 0xE23148
	public System.Func<System.Object> get_DefaultCreator() { }

	// RVA: 0xE23150
	public void set_DefaultCreator(System.Func<System.Object> value) { }

	// RVA: 0xE23158
	public bool get_DefaultCreatorNonPublic() { }

	// RVA: 0xE23160
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0xE22794
	internal void .ctor(Type underlyingType) { }

	// RVA: 0xE23168
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0xE2335C
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0xE23550
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0xE23744
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0xE23938
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0xE23B34
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0xE23BF8
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

	// RVA: 0xE23F0C
	public System.Func<System.String,System.String> get_DictionaryKeyResolver() { }

	// RVA: 0xE23F14
	public void set_DictionaryKeyResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xE23F1C
	public Type get_DictionaryKeyType() { }

	// RVA: 0xE23F24
	public Type get_DictionaryValueType() { }

	// RVA: 0xE23F2C
	internal JsonContract get_KeyContract() { }

	// RVA: 0xE23F34
	internal void set_KeyContract(JsonContract value) { }

	// RVA: 0xE23F3C
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0xE23F44
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xE24048
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xE24050
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xE24060
	public bool get_HasParameterizedCreator() { }

	// RVA: 0xE24068
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0xE24070
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0xE2410C
	public void .ctor(Type underlyingType) { }

	// RVA: 0xE24C9C
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	// RVA: 0xE24F68
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

	// RVA: 0xE2522C
	public JsonPropertyCollection get_Properties() { }

	// RVA: 0xE25234
	public System.Func<System.String,System.String> get_PropertyNameResolver() { }

	// RVA: 0xE2523C
	public void set_PropertyNameResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xE25244
	private static System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>> CreateCallSiteGetter(string name) { }

	// RVA: 0xE25364
	private static System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>> CreateCallSiteSetter(string name) { }

	// RVA: 0xE25484
	public void .ctor(Type underlyingType) { }

	// RVA: 0xE25808
	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }

	// RVA: 0xE25928
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

	// RVA: 0xE25A38
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x26AD93C
	private T GetTokenValue(object value) { }

	// RVA: 0xE25B0C
	public object Convert(object value, Type type) { }

	// RVA: 0xE25DE4
	public bool ToBoolean(object value) { }

	// RVA: 0xE25E54
	public int ToInt32(object value) { }

	// RVA: 0xE25EC4
	public Int64 ToInt64(object value) { }

	// RVA: 0xE25F34
	public float ToSingle(object value) { }

	// RVA: 0xE25FA4
	public string ToString(object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonISerializableContract
{
	// Fields
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <ISerializableCreator>k__BackingField; // 0xC0

	// Methods

	// RVA: 0xE26014
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ISerializableCreator() { }

	// RVA: 0xE2601C
	public void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xE26024
	public void .ctor(Type underlyingType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonLinqContract
{
	// Methods

	// RVA: 0xE2604C
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

	// RVA: 0xE26074
	public MemberSerialization get_MemberSerialization() { }

	// RVA: 0xE2607C
	public void set_MemberSerialization(MemberSerialization value) { }

	// RVA: 0xE26084
	public System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling() { }

	// RVA: 0xE2608C
	public void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value) { }

	// RVA: 0xE26094
	public System.Nullable<Newtonsoft.Json.Required> get_ItemRequired() { }

	// RVA: 0xE2609C
	public void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value) { }

	// RVA: 0xE260A4
	public System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling() { }

	// RVA: 0xE260AC
	public void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }

	// RVA: 0xE260B4
	public JsonPropertyCollection get_Properties() { }

	// RVA: 0xE260BC
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0xE26158
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xE26160
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xE26170
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xE26178
	internal void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xE26188
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	// RVA: 0xE26190
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	// RVA: 0xE26198
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	// RVA: 0xE261A0
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0xE261A8
	public void set_ExtensionDataValueType(Type value) { }

	// RVA: 0xE2629C
	public System.Func<System.String,System.String> get_ExtensionDataNameResolver() { }

	// RVA: 0xE262A4
	public void set_ExtensionDataNameResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xE262AC
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	// RVA: 0xE26A74
	public void .ctor(Type underlyingType) { }

	// RVA: 0xE26AFC
	internal object GetUninitializedObject() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonPrimitiveContract
{
	// Fields
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x8C
	private static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.ReadType> ReadTypeMap; // 0x0

	// Methods

	// RVA: 0xE26C3C
	internal PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0xE26C44
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0xE26C4C
	public void .ctor(Type underlyingType) { }

	// RVA: 0xE26D4C
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

	// RVA: 0xE27080
	internal JsonContract get_PropertyContract() { }

	// RVA: 0xE27088
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0xE27090
	public string get_PropertyName() { }

	// RVA: 0xE27098
	public void set_PropertyName(string value) { }

	// RVA: 0xE27130
	public Type get_DeclaringType() { }

	// RVA: 0xE27138
	public void set_DeclaringType(Type value) { }

	// RVA: 0xE27140
	public System.Nullable<System.Int32> get_Order() { }

	// RVA: 0xE27148
	public void set_Order(System.Nullable<System.Int32> value) { }

	// RVA: 0xE27150
	public string get_UnderlyingName() { }

	// RVA: 0xE27158
	public void set_UnderlyingName(string value) { }

	// RVA: 0xE27160
	public IValueProvider get_ValueProvider() { }

	// RVA: 0xE27168
	public void set_ValueProvider(IValueProvider value) { }

	// RVA: 0xE27170
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0xE27178
	public Type get_PropertyType() { }

	// RVA: 0xE27180
	public void set_PropertyType(Type value) { }

	// RVA: 0xE27214
	public JsonConverter get_Converter() { }

	// RVA: 0xE2721C
	public void set_Converter(JsonConverter value) { }

	// RVA: 0xE27224
	public bool get_Ignored() { }

	// RVA: 0xE2722C
	public void set_Ignored(bool value) { }

	// RVA: 0xE27234
	public bool get_Readable() { }

	// RVA: 0xE2723C
	public void set_Readable(bool value) { }

	// RVA: 0xE27244
	public bool get_Writable() { }

	// RVA: 0xE2724C
	public void set_Writable(bool value) { }

	// RVA: 0xE27254
	public bool get_HasMemberAttribute() { }

	// RVA: 0xE2725C
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0xE27264
	public object get_DefaultValue() { }

	// RVA: 0xE2727C
	public void set_DefaultValue(object value) { }

	// RVA: 0xE2728C
	internal object GetResolvedDefaultValue() { }

	// RVA: 0xE2699C
	public Required get_Required() { }

	// RVA: 0xE27358
	public System.Nullable<System.Boolean> get_IsReference() { }

	// RVA: 0xE27360
	public void set_IsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xE27368
	public System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling() { }

	// RVA: 0xE27370
	public void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }

	// RVA: 0xE27378
	public System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling() { }

	// RVA: 0xE27380
	public void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value) { }

	// RVA: 0xE27388
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	// RVA: 0xE27390
	public void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xE27398
	public System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling() { }

	// RVA: 0xE273A0
	public void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value) { }

	// RVA: 0xE273A8
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling() { }

	// RVA: 0xE273B0
	public void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xE273B8
	public System.Predicate<System.Object> get_ShouldSerialize() { }

	// RVA: 0xE273C0
	public void set_ShouldSerialize(System.Predicate<System.Object> value) { }

	// RVA: 0xE273C8
	public System.Predicate<System.Object> get_ShouldDeserialize() { }

	// RVA: 0xE273D0
	public System.Predicate<System.Object> get_GetIsSpecified() { }

	// RVA: 0xE273D8
	public void set_GetIsSpecified(System.Predicate<System.Object> value) { }

	// RVA: 0xE273E0
	public System.Action<System.Object,System.Object> get_SetIsSpecified() { }

	// RVA: 0xE273E8
	public void set_SetIsSpecified(System.Action<System.Object,System.Object> value) { }

	// RVA: 0xE273F0
	public override string ToString() { }

	// RVA: 0xE27414
	public JsonConverter get_ItemConverter() { }

	// RVA: 0xE2741C
	public void set_ItemConverter(JsonConverter value) { }

	// RVA: 0xE27424
	public System.Nullable<System.Boolean> get_ItemIsReference() { }

	// RVA: 0xE2742C
	public void set_ItemIsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xE27434
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }

	// RVA: 0xE2743C
	public void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xE27444
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	// RVA: 0xE2744C
	public void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xE27454
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0xE274AC
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonPropertyCollection
{
	// Fields
	private readonly Type _type; // 0x30
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list; // 0x38

	// Methods

	// RVA: 0xE2564C
	public void .ctor(Type type) { }

	// RVA: 0xE274B4
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0xE274D0
	public void AddProperty(JsonProperty property) { }

	// RVA: 0xE277A4
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0xE27940
	private bool TryGetProperty(string key, JsonProperty item) { }

	// RVA: 0xE27844
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

}

// Namespace: 
private class ReferenceEqualsEqualityComparer
{
	// Methods

	// RVA: 0xE282EC
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	// RVA: 0xE282F8
	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	// RVA: 0xE27ACC
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

	// RVA: 0xE27A2C
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0xE1FBE0
	internal Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> get_DefaultReferenceMappings() { }

	// RVA: 0xE27AD4
	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0xE27D18
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0xE27E48
	protected void ClearErrorContext() { }

	// RVA: 0xE27EB8
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

	// RVA: 0xE35C74
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

	// RVA: 0xE368D8
	private static void .cctor() { }

	// RVA: 0xE36944
	public void .ctor() { }

	// RVA: 0xE3694C
	internal string <CreateObjectUsingCreatorWithParameters>b__38_0(JsonProperty p) { }

	// RVA: 0xE36968
	internal string <CreateObjectUsingCreatorWithParameters>b__38_2(JsonProperty p) { }

	// RVA: 0xE36984
	internal JsonProperty <PopulateObject>b__42_0(JsonProperty m) { }

	// RVA: 0xE3698C
	internal PropertyPresence <PopulateObject>b__42_1(JsonProperty m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass38_0
{
	// Fields
	public JsonProperty property; // 0x10

	// Methods

	// RVA: 0xE35C6C
	public void .ctor() { }

	// RVA: 0xE36994
	internal bool <CreateObjectUsingCreatorWithParameters>b__1(CreatorPropertyContext p) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class JsonSerializerInternalReader
{
	// Methods

	// RVA: 0xE28304
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0xE28308
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xE2AEE8
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0xE2AF60
	private JsonContract GetContract(Type type) { }

	// RVA: 0xE2B01C
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0xE2BE58
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0xE2BEF8
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0xE2C2EC
	private JToken CreateJObject(JsonReader reader) { }

	// RVA: 0xE2B910
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0xE2DF20
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0xE2E030
	internal string GetExpectedDescription(JsonContract contract) { }

	// RVA: 0xE2B3F0
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xE2C768
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0xE2E0EC
	private bool ReadMetadataPropertiesToken(JTokenReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, object newValue, string id) { }

	// RVA: 0xE2E848
	private bool ReadMetadataProperties(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, object newValue, string id) { }

	// RVA: 0xE30518
	private void ResolveTypeName(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0xE30DAC
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	// RVA: 0xE2D160
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	// RVA: 0xE2EE40
	private bool HasNoDefinedType(JsonContract contract) { }

	// RVA: 0xE2D940
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0xE31A1C
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	// RVA: 0xE31F10
	private bool CalculatePropertyDetails(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, bool useExistingValue, object currentValue, JsonContract propertyContract, bool gottenCurrentValue, bool ignoredValue) { }

	// RVA: 0xE326CC
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0xE326C0
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xE32588
	private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	// RVA: 0xE30F30
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, bool createdFromNonDefaultCreator) { }

	// RVA: 0xE2F208
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, bool createdFromNonDefaultCreator) { }

	// RVA: 0xE32AAC
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0xE32CE8
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0xE28ED0
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xE31278
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xE32F24
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0xE2885C
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xE2FDBC
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0xE25C30
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0xE2F4F4
	private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	// RVA: 0xE330BC
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator, string id) { }

	// RVA: 0xE2B480
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0xE35270
	private System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0xE2EF24
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, bool createdFromNonDefaultCreator) { }

	// RVA: 0xE29B48
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0xE36564
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0xE2C63C
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0xE36358
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0xE3628C
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0xE35CA8
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0xE367CC
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0xE2BD8C
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

	// RVA: 0xE369BC
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0xE36A54
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xE379CC
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0xE36D2C
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0xE37A6C
	private JsonContract GetContract(object value) { }

	// RVA: 0xE37B3C
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xE37244
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xE3B23C
	private System.Nullable<System.Boolean> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xE36D3C
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xE3B388
	private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0xE3B490
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xE36FB4
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0xE3B938
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0xE3BB34
	internal static bool TryConvertToString(object value, Type type, string s) { }

	// RVA: 0xE39C4C
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0xE3BC74
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0xE3BE90
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0xE38918
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xE3C29C
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, JsonContract memberContract, object memberValue) { }

	// RVA: 0xE3C0AC
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xE3D164
	private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	// RVA: 0xE3D29C
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0xE3812C
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0xE3B484
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xE3B37C
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0xE3D4F4
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0xE383B8
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xE393D0
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xE39A60
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xE3D894
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0xE3D500
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xE3ADE4
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xE3A584
	private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xE3DC2C
	private bool ShouldWriteDynamicProperty(object memberValue) { }

	// RVA: 0xE37CB4
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xE39CDC
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xE3C754
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, bool escape) { }

	// RVA: 0xE378FC
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0xE3CC9C
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0xE3CF00
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

	// RVA: 0xE3DCFC
	public override void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xE3DD20
	public override void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xE3DD44
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xE3DD68
	public override ITraceWriter get_TraceWriter() { }

	// RVA: 0xE3DD8C
	public override void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0xE3DDB0
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xE3DDD4
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0xE3DDFC
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0xE3DE24
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0xE3DE4C
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xE3DE74
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xE3DE9C
	public override NullValueHandling get_NullValueHandling() { }

	// RVA: 0xE3DEC4
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xE3DEEC
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xE3DF14
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xE3DF3C
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xE3DF64
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xE3DF88
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xE3DFB0
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xE3DFD8
	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0xE3DFFC
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0xE3E024
	public override void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0xE3E048
	public override StreamingContext get_Context() { }

	// RVA: 0xE3E070
	public override void set_Context(StreamingContext value) { }

	// RVA: 0xE3E098
	public override Formatting get_Formatting() { }

	// RVA: 0xE3E0C0
	public override System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xE3E0E8
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0xE3E110
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xE3E138
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0xE3E154
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0xE3E1E4
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	// RVA: 0xE3E274
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xE3E2B0
	internal override void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0xE3E2E8
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonStringContract
{
	// Methods

	// RVA: 0xE3E320
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

	// RVA: 0xE3FB18
	private static void .cctor() { }

	// RVA: 0xE3FB84
	public void .ctor() { }

	// RVA: 0xE3FB8C
	internal Type <GetCreator>b__22_1(object param) { }

}

// Namespace: 
private sealed class <>c__DisplayClass22_0
{
	// Fields
	public Type type; // 0x10
	public System.Func<System.Object> defaultConstructor; // 0x18

	// Methods

	// RVA: 0xE3F2B8
	public void .ctor() { }

	// RVA: 0xE3FBF0
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

	// RVA: 0x26AD93C
	public static T GetCachedAttribute(object attributeProvider) { }

	// RVA: 0xE3E398
	public static bool CanTypeDescriptorConvertString(Type type, TypeConverter typeConverter) { }

	// RVA: 0xE3E57C
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0xE3E684
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0xE3E974
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0xE3EBBC
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0xE3ED38
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] args) { }

	// RVA: 0xE3EE60
	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[] args) { }

	// RVA: 0xE3EF88
	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	// RVA: 0xE3F064
	private static System.Func<System.Object[],System.Object> GetCreator(Type type) { }

	// RVA: 0xE3F384
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0xE3F43C
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: 0x26AD93C
	private static T GetAttribute(Type type) { }

	// RVA: 0x26AD93C
	private static T GetAttribute(MemberInfo memberInfo) { }

	// RVA: 0xE3F6D4
	public static bool IsNonSerializable(object provider) { }

	// RVA: 0xE3EB34
	public static bool IsSerializable(object provider) { }

	// RVA: 0x26AD93C
	public static T GetAttribute(object provider) { }

	// RVA: 0xE3F75C
	public static bool get_FullyTrusted() { }

	// RVA: 0xE3F2C0
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0xE3F98C
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class KebabCaseNamingStrategy
{
	// Methods

	// RVA: 0xE40100
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xE40144
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xE40188
	public void .ctor() { }

	// RVA: 0xE40190
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

	// RVA: 0xE4019C
	public bool get_ProcessDictionaryKeys() { }

	// RVA: 0xE401A4
	public void set_ProcessDictionaryKeys(bool value) { }

	// RVA: 0xE401AC
	public bool get_ProcessExtensionDataNames() { }

	// RVA: 0xE401B4
	public void set_ProcessExtensionDataNames(bool value) { }

	// RVA: 0xE401BC
	public bool get_OverrideSpecifiedNames() { }

	// RVA: 0xE401C4
	public void set_OverrideSpecifiedNames(bool value) { }

	// RVA: 0xE401CC
	public virtual string GetPropertyName(string name, bool hasSpecifiedName) { }

	// RVA: 0xE401EC
	public virtual string GetExtensionDataName(string name) { }

	// RVA: 0xE40208
	public virtual string GetDictionaryKey(string key) { }

	// RVA: -1
	protected abstract string ResolvePropertyName(string name) { }

	// RVA: 0xE40224
	public override int GetHashCode() { }

	// RVA: 0xE402E8
	public override bool Equals(object obj) { }

	// RVA: 0xE40450
	protected bool Equals(NamingStrategy other) { }

	// RVA: 0xE4013C
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ObjectConstructor<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35258B4
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

	// RVA: 0xE40574
	public void .ctor(object attributeProvider) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class ReflectionValueProvider
{
	// Fields
	private readonly MemberInfo _memberInfo; // 0x10

	// Methods

	// RVA: 0xE405EC
	public void .ctor(MemberInfo memberInfo) { }

	// RVA: 0xE40664
	public void SetValue(object target, object value) { }

	// RVA: 0xE40810
	public object GetValue(object target) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class SnakeCaseNamingStrategy
{
	// Methods

	// RVA: 0xE40AD0
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xE40B0C
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xE40B50
	public void .ctor() { }

	// RVA: 0xE40B58
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

	// RVA: 0xE40B64
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0xE40CD4
	public string GetDeserializedJsonMessage() { }

	// RVA: 0xE40CF8
	public override bool Read() { }

	// RVA: 0xE40D98
	public override System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xE40DFC
	public override string ReadAsString() { }

	// RVA: 0xE40E60
	public override Byte[] ReadAsBytes() { }

	// RVA: 0xE40EC8
	public override System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xE40F74
	public override System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xE40FEC
	public override System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xE41054
	public override System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xE410CC
	public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xE40D5C
	public void WriteCurrentToken() { }

	// RVA: 0xE4114C
	public override int get_Depth() { }

	// RVA: 0xE41170
	public override string get_Path() { }

	// RVA: 0xE41194
	public override JsonToken get_TokenType() { }

	// RVA: 0xE411B8
	public override object get_Value() { }

	// RVA: 0xE411DC
	public override Type get_ValueType() { }

	// RVA: 0xE41200
	public override void Close() { }

	// RVA: 0xE41228
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE41300
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE413DC
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

	// RVA: 0xE414B8
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0xE416C4
	public string GetSerializedJsonMessage() { }

	// RVA: 0xE416E8
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE41760
	public override void WriteValue(System.Nullable<System.Decimal> value) { }

	// RVA: 0xE41924
	public override void WriteValue(bool value) { }

	// RVA: 0xE41988
	public override void WriteValue(System.Nullable<System.Boolean> value) { }

	// RVA: 0xE41B18
	public override void WriteValue(Byte value) { }

	// RVA: 0xE41B7C
	public override void WriteValue(System.Nullable<System.Byte> value) { }

	// RVA: 0xE41D0C
	public override void WriteValue(Char value) { }

	// RVA: 0xE41D70
	public override void WriteValue(System.Nullable<System.Char> value) { }

	// RVA: 0xE41F00
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xE41F78
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE41FDC
	public override void WriteValue(System.Nullable<System.DateTime> value) { }

	// RVA: 0xE42174
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE421EC
	public override void WriteValue(System.Nullable<System.DateTimeOffset> value) { }

	// RVA: 0xE42394
	public override void WriteValue(Double value) { }

	// RVA: 0xE42400
	public override void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xE42598
	public override void WriteUndefined() { }

	// RVA: 0xE425F0
	public override void WriteNull() { }

	// RVA: 0xE42648
	public override void WriteValue(float value) { }

	// RVA: 0xE426B4
	public override void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xE42840
	public override void WriteValue(Guid value) { }

	// RVA: 0xE428B8
	public override void WriteValue(System.Nullable<System.Guid> value) { }

	// RVA: 0xE42A60
	public override void WriteValue(int value) { }

	// RVA: 0xE42AC4
	public override void WriteValue(System.Nullable<System.Int32> value) { }

	// RVA: 0xE42C50
	public override void WriteValue(Int64 value) { }

	// RVA: 0xE42CB4
	public override void WriteValue(System.Nullable<System.Int64> value) { }

	// RVA: 0xE42E4C
	public override void WriteValue(object value) { }

	// RVA: 0xE42F64
	public override void WriteValue(SByte value) { }

	// RVA: 0xE42FC8
	public override void WriteValue(System.Nullable<System.SByte> value) { }

	// RVA: 0xE43158
	public override void WriteValue(Int16 value) { }

	// RVA: 0xE431BC
	public override void WriteValue(System.Nullable<System.Int16> value) { }

	// RVA: 0xE4334C
	public override void WriteValue(string value) { }

	// RVA: 0xE433B0
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE43414
	public override void WriteValue(System.Nullable<System.TimeSpan> value) { }

	// RVA: 0xE435AC
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xE43610
	public override void WriteValue(System.Nullable<System.UInt32> value) { }

	// RVA: 0xE4379C
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xE43800
	public override void WriteValue(System.Nullable<System.UInt64> value) { }

	// RVA: 0xE43998
	public override void WriteValue(Uri value) { }

	// RVA: 0xE43A80
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xE43AE4
	public override void WriteValue(System.Nullable<System.UInt16> value) { }

	// RVA: 0xE43C74
	public override void WriteComment(string text) { }

	// RVA: 0xE43CD8
	public override void WriteStartArray() { }

	// RVA: 0xE43D28
	public override void WriteEndArray() { }

	// RVA: 0xE43D78
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE43DD4
	public override void WriteEndConstructor() { }

	// RVA: 0xE43E24
	public override void WritePropertyName(string name) { }

	// RVA: 0xE43E88
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xE43EFC
	public override void WriteStartObject() { }

	// RVA: 0xE43F4C
	public override void WriteEndObject() { }

	// RVA: 0xE43F9C
	public override void WriteRawValue(string json) { }

	// RVA: 0xE44000
	public override void WriteRaw(string json) { }

	// RVA: 0xE44064
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

	// RVA: 0xE440B4
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xE440BC
	public override JTokenType get_Type() { }

	// RVA: 0xE440C4
	public void .ctor() { }

	// RVA: 0xE44234
	internal void .ctor(JArray other, JsonCloneSettings settings) { }

	// RVA: 0xE4467C
	public void .ctor(object content) { }

	// RVA: 0xE44764
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xE4483C
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE44D44
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE44E30
	public JToken get_Item(int index) { }

	// RVA: 0xE44E40
	public void set_Item(int index, JToken value) { }

	// RVA: 0xE44E50
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE44EC4
	public int IndexOf(JToken item) { }

	// RVA: 0xE44ED4
	public void Insert(int index, JToken item) { }

	// RVA: 0xE44EEC
	public void RemoveAt(int index) { }

	// RVA: 0xE44EFC
	public System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }

	// RVA: 0xE44F98
	public void Add(JToken item) { }

	// RVA: 0xE44FA8
	public void Clear() { }

	// RVA: 0xE44FB8
	public bool Contains(JToken item) { }

	// RVA: 0xE44FC8
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xE44FD8
	public bool get_IsReadOnly() { }

	// RVA: 0xE44FE0
	public bool Remove(JToken item) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JConstructor
{
	// Fields
	private string _name; // 0x58
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values; // 0x60

	// Methods

	// RVA: 0xE44FF0
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xE44FF8
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE4506C
	public string get_Name() { }

	// RVA: 0xE45074
	public override JTokenType get_Type() { }

	// RVA: 0xE4507C
	internal void .ctor(JConstructor other, JsonCloneSettings settings) { }

	// RVA: 0xE45134
	public void .ctor(string name) { }

	// RVA: 0xE452E0
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xE4534C
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE45444
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

	// RVA: 0xE45630
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xE456E4
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: -1
	protected abstract System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xE441AC
	internal void .ctor() { }

	// RVA: 0xE442D4
	internal void .ctor(JContainer other, JsonCloneSettings settings) { }

	// RVA: 0xE45BD4
	internal void CheckReentrancy() { }

	// RVA: 0xE45C80
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0xE45CA4
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xE45D34
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	// RVA: 0xE45DC4
	public override bool get_HasValues() { }

	// RVA: 0xE45E88
	public override JToken get_First() { }

	// RVA: 0xE45FEC
	public override JToken get_Last() { }

	// RVA: 0xE46150
	public override Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }

	// RVA: 0xE461D0
	internal bool IsMultiContent(object content) { }

	// RVA: 0xE462C0
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: -1
	internal abstract int IndexOfItem(JToken item) { }

	// RVA: 0xE46498
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xE46900
	internal virtual void RemoveItemAt(int index) { }

	// RVA: 0xE46E04
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0xE46E6C
	internal virtual JToken GetItem(int index) { }

	// RVA: 0xE46F34
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0xE47654
	internal virtual void ClearItems() { }

	// RVA: 0xE47A98
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	// RVA: 0xE47B00
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0xE47B28
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0xE4758C
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0xE480BC
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE481DC
	public virtual void Add(object content) { }

	// RVA: 0xE482B8
	internal bool TryAdd(object content) { }

	// RVA: 0xE48394
	internal void AddAndSkipParentCheck(JToken token) { }

	// RVA: 0xE45854
	internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xE48470
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0xE4862C
	public void RemoveAll() { }

	// RVA: 0xE44BE4
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0xE4863C
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	// RVA: 0xE48E20
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	// RVA: 0xE4939C
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xE493B4
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xE49564
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0xE49574
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0xE4958C
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0xE4959C
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0xE495AC
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0xE495BC
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0xE495CC
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0xE495DC
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0xE495EC
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xE495FC
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0xE49604
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	// RVA: 0xE49614
	private JToken EnsureValue(object value) { }

	// RVA: 0xE496D4
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xE497B4
	private void System.Collections.IList.Clear() { }

	// RVA: 0xE497C4
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xE497FC
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xE49834
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xE49888
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xE49890
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xE49898
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xE498D0
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xE498E0
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xE498F0
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xE4993C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xE47FF4
	public int get_Count() { }

	// RVA: 0xE4994C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xE49954
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xE499E0
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xE499E4
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xE49BB0
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xE49BB8
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xE49BC0
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xE49BC8
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xE49C08
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xE49C48
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xE49C50
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xE49C54
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xE49C94
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xE49C9C
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xE49CA4
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xE49CAC
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xE49CB4
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

}

// Namespace: Newtonsoft.Json.Linq
public struct JEnumerable<T0>
{
	// Fields
	public static readonly Newtonsoft.Json.Linq.JEnumerable<T> Empty; // 0x0
	private readonly System.Collections.Generic.IEnumerable<T> _enumerable; // 0x0

	// Methods

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.IEnumerable<T> enumerable) { }

	// RVA: 0x3525804
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26AD93C
	public bool Equals(Newtonsoft.Json.Linq.JEnumerable<T> other) { }

	// RVA: 0x35252FC
	public override bool Equals(object obj) { }

	// RVA: 0x35254D0
	public override int GetHashCode() { }

	// RVA: 0x352AE04
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

	// RVA: 0xE4CE6C
	private static void .cctor() { }

	// RVA: 0xE4CED8
	public void .ctor() { }

	// RVA: 0xE4CEE0
	internal string <GetDynamicMemberNames>b__2_0(JProperty p) { }

}

// Namespace: 
private class JObjectDynamicProxy
{
	// Methods

	// RVA: 0xE4CB20
	public override bool TryGetMember(JObject instance, GetMemberBinder binder, object result) { }

	// RVA: 0xE4CBD0
	public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value) { }

	// RVA: 0xE4CD10
	public override System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(JObject instance) { }

	// RVA: 0xE4CACC
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

	// RVA: 0xE4C060
	public void .ctor(int <>1__state) { }

	// RVA: 0xE4CEFC
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE4CFD0
	private bool MoveNext() { }

	// RVA: 0xE4D364
	private void <>m__Finally1() { }

	// RVA: 0xE4D428
	private System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	// RVA: 0xE4D434
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xE4D474
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

	// RVA: 0xE49CBC
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xE49CC4
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xE49D68
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xE49E0C
	public void add_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0xE49EB0
	public void remove_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0xE48B90
	public void .ctor() { }

	// RVA: 0xE49FF0
	public void .ctor(JObject other) { }

	// RVA: 0xE4A0EC
	internal void .ctor(JObject other, JsonCloneSettings settings) { }

	// RVA: 0xE4A1EC
	public void .ctor(object[] content) { }

	// RVA: 0xE4A1F0
	public void .ctor(object content) { }

	// RVA: 0xE4A338
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE4A4B8
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xE4A544
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xE4A84C
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0xE4A994
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0xE4A9BC
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xE4AA28
	public override JTokenType get_Type() { }

	// RVA: 0xE4AA30
	public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties() { }

	// RVA: 0xE4905C
	public JProperty Property(string name, StringComparison comparison) { }

	// RVA: 0xE4AA84
	public JToken get_Item(string propertyName) { }

	// RVA: 0xE4AB08
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0xE4AD5C
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE4AF2C
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE4ACD4
	public void Add(string propertyName, JToken value) { }

	// RVA: 0xE4B1E8
	public bool ContainsKey(string propertyName) { }

	// RVA: 0xE4B314
	private System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0xE4B3D0
	public bool Remove(string propertyName) { }

	// RVA: 0xE4B4DC
	public bool TryGetValue(string propertyName, JToken value) { }

	// RVA: 0xE4B534
	private System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0xE4B574
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xE4B730
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0xE4B740
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xE4B8D0
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>[] array, int arrayIndex) { }

	// RVA: 0xE4BDFC
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0xE4BE04
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xE4BFE8
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>> GetEnumerator() { }

	// RVA: 0xE4C08C
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0xE4C120
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0xE4C1B4
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xE4C25C
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xE4C758
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xE4C7D4
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xE4C7DC
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xE4C7E4
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xE4C83C
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xE4C844
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xE4C84C
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xE4C854
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xE4C8D0
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xE4C94C
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xE4C9E0
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

	// RVA: 0xE4DED4
	public void .ctor(int <>1__state) { }

	// RVA: 0xE4E15C
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE4E160
	private bool MoveNext() { }

	// RVA: 0xE4E1DC
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	// RVA: 0xE4E1E4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xE4E224
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private class JPropertyList
{
	// Fields
	internal JToken _token; // 0x10

	// Methods

	// RVA: 0xE4DE5C
	public System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }

	// RVA: 0xE4DF00
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xE4DF78
	public void Add(JToken item) { }

	// RVA: 0xE4DF80
	public void Clear() { }

	// RVA: 0xE4DF8C
	public bool Contains(JToken item) { }

	// RVA: 0xE4DF9C
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xE4E020
	public bool Remove(JToken item) { }

	// RVA: 0xE4E070
	public int get_Count() { }

	// RVA: 0xE4E080
	public bool get_IsReadOnly() { }

	// RVA: 0xE4D954
	public int IndexOf(JToken item) { }

	// RVA: 0xE4E088
	public void Insert(int index, JToken item) { }

	// RVA: 0xE4E09C
	public void RemoveAt(int index) { }

	// RVA: 0xE4E0B0
	public JToken get_Item(int index) { }

	// RVA: 0xE4E104
	public void set_Item(int index, JToken value) { }

	// RVA: 0xE4D590
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JProperty
{
	// Fields
	private readonly JPropertyList _content; // 0x58
	private readonly string _name; // 0x60

	// Methods

	// RVA: 0xE4D4DC
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xE4D4E4
	public string get_Name() { }

	// RVA: 0xE48B70
	public JToken get_Value() { }

	// RVA: 0xE4AC50
	public void set_Value(JToken value) { }

	// RVA: 0xE4D4EC
	internal void .ctor(JProperty other, JsonCloneSettings settings) { }

	// RVA: 0xE4D598
	internal override JToken GetItem(int index) { }

	// RVA: 0xE4D5F8
	internal override void SetItem(int index, JToken item) { }

	// RVA: 0xE4D7BC
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0xE4D86C
	internal override void RemoveItemAt(int index) { }

	// RVA: 0xE4D91C
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xE4D964
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xE4DA94
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0xE4DABC
	internal override void ClearItems() { }

	// RVA: 0xE4DB6C
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xE4DBD8
	public override JTokenType get_Type() { }

	// RVA: 0xE49238
	internal void .ctor(string name) { }

	// RVA: 0xE4B02C
	public void .ctor(string name, object content) { }

	// RVA: 0xE4DBE0
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE4DC70
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JPropertyDescriptor
{
	// Methods

	// RVA: 0xE4C74C
	public void .ctor(string name) { }

	// RVA: 0xE4E22C
	public override bool CanResetValue(object component) { }

	// RVA: 0xE4E234
	public override object GetValue(object component) { }

	// RVA: 0xE4E34C
	public override void ResetValue(object component) { }

	// RVA: 0xE4E350
	public override void SetValue(object component, object value) { }

	// RVA: 0xE4E4E8
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xE4E4F0
	public override Type get_ComponentType() { }

	// RVA: 0xE4E580
	public override bool get_IsReadOnly() { }

	// RVA: 0xE4E588
	public override Type get_PropertyType() { }

	// RVA: 0xE4E5D8
	protected override int get_NameHashCode() { }

}

// Namespace: Newtonsoft.Json.Linq
internal class JPropertyKeyedCollection
{
	// Fields
	private static readonly System.Collections.Generic.IEqualityComparer<System.String> Comparer; // 0x0
	private System.Collections.Generic.Dictionary<System.String,Newtonsoft.Json.Linq.JToken> _dictionary; // 0x18

	// Methods

	// RVA: 0xE49F54
	public void .ctor() { }

	// RVA: 0xE4E5E0
	private void AddKey(string key, JToken item) { }

	// RVA: 0xE4E720
	protected override void ClearItems() { }

	// RVA: 0xE4B258
	public bool Contains(string key) { }

	// RVA: 0xE4E654
	private void EnsureDictionary() { }

	// RVA: 0xE4E7A8
	private string GetKeyForItem(JToken item) { }

	// RVA: 0xE4E82C
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0xE4E95C
	protected override void RemoveItem(int index) { }

	// RVA: 0xE4EAE4
	private void RemoveKey(string key) { }

	// RVA: 0xE4EB54
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0xE4A7C0
	public bool TryGetValue(string key, JToken value) { }

	// RVA: 0xE4B374
	public System.Collections.Generic.ICollection<System.String> get_Keys() { }

	// RVA: 0xE4A408
	public int IndexOfReference(JToken t) { }

	// RVA: 0xE4EE9C
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JRaw
{
	// Methods

	// RVA: 0xE4EF80
	internal void .ctor(JRaw other, JsonCloneSettings settings) { }

	// RVA: 0xE4F0A8
	public void .ctor(object rawJson) { }

	// RVA: 0xE4F1B8
	public static JRaw Create(JsonReader reader) { }

	// RVA: 0xE4F504
	internal override JToken CloneToken(JsonCloneSettings settings) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JsonCloneSettings
{
	// Fields
	internal static readonly JsonCloneSettings SkipCopyAnnotations; // 0x0
	private bool <CopyAnnotations>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE4F570
	public void .ctor() { }

	// RVA: 0xE4F59C
	public bool get_CopyAnnotations() { }

	// RVA: 0xE4F5A4
	public void set_CopyAnnotations(bool value) { }

	// RVA: 0xE4F5AC
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

	// RVA: 0xE4F61C
	public CommentHandling get_CommentHandling() { }

	// RVA: 0xE4F624
	public LineInfoHandling get_LineInfoHandling() { }

	// RVA: 0xE4F62C
	public DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }

}

// Namespace: 
private class LineInfoAnnotation
{
	// Fields
	internal readonly int LineNumber; // 0x10
	internal readonly int LinePosition; // 0x14

	// Methods

	// RVA: 0xE57DB8
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

	// RVA: 0xE4F634
	public JContainer get_Parent() { }

	// RVA: 0xE4F63C
	internal void set_Parent(JContainer value) { }

	// RVA: 0xE46480
	public JToken get_Root() { }

	// RVA: -1
	internal abstract JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: -1
	public abstract JTokenType get_Type() { }

	// RVA: -1
	public abstract bool get_HasValues() { }

	// RVA: 0xE4F644
	public JToken get_Next() { }

	// RVA: 0xE4F64C
	internal void set_Next(JToken value) { }

	// RVA: 0xE4F654
	public JToken get_Previous() { }

	// RVA: 0xE4F65C
	internal void set_Previous(JToken value) { }

	// RVA: 0xE4F664
	public string get_Path() { }

	// RVA: 0xE45798
	internal void .ctor() { }

	// RVA: 0xE4F968
	public virtual JToken get_First() { }

	// RVA: 0xE4F9FC
	public virtual JToken get_Last() { }

	// RVA: 0xE4FA90
	public virtual Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }

	// RVA: 0xE4B464
	public void Remove() { }

	// RVA: 0xE49320
	public void Replace(JToken value) { }

	// RVA: -1
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE4FB0C
	public override string ToString() { }

	// RVA: 0xE4FBF4
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0xE4FE18
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0xE4FF50
	private static string GetType(JToken token) { }

	// RVA: 0xE5004C
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0xE5012C
	public static bool op_Explicit(JToken value) { }

	// RVA: 0xE503D4
	public static DateTimeOffset op_Explicit(JToken value) { }

	// RVA: 0xE5069C
	public static System.Nullable<System.Boolean> op_Explicit(JToken value) { }

	// RVA: 0xE50988
	public static Int64 op_Explicit(JToken value) { }

	// RVA: 0xE50C10
	public static System.Nullable<System.DateTime> op_Explicit(JToken value) { }

	// RVA: 0xE50ED4
	public static System.Nullable<System.DateTimeOffset> op_Explicit(JToken value) { }

	// RVA: 0xE51208
	public static System.Nullable<System.Decimal> op_Explicit(JToken value) { }

	// RVA: 0xE514F8
	public static System.Nullable<System.Double> op_Explicit(JToken value) { }

	// RVA: 0xE517A0
	public static System.Nullable<System.Char> op_Explicit(JToken value) { }

	// RVA: 0xE51A64
	public static int op_Explicit(JToken value) { }

	// RVA: 0xE51CEC
	public static Int16 op_Explicit(JToken value) { }

	// RVA: 0xE51F74
	public static UInt16 op_Explicit(JToken value) { }

	// RVA: 0xE521FC
	public static Char op_Explicit(JToken value) { }

	// RVA: 0xE52484
	public static Byte op_Explicit(JToken value) { }

	// RVA: 0xE5270C
	public static SByte op_Explicit(JToken value) { }

	// RVA: 0xE52994
	public static System.Nullable<System.Int32> op_Explicit(JToken value) { }

	// RVA: 0xE52C3C
	public static System.Nullable<System.Int16> op_Explicit(JToken value) { }

	// RVA: 0xE52F00
	public static System.Nullable<System.UInt16> op_Explicit(JToken value) { }

	// RVA: 0xE531C4
	public static System.Nullable<System.Byte> op_Explicit(JToken value) { }

	// RVA: 0xE53488
	public static System.Nullable<System.SByte> op_Explicit(JToken value) { }

	// RVA: 0xE5374C
	public static DateTime op_Explicit(JToken value) { }

	// RVA: 0xE539D4
	public static System.Nullable<System.Int64> op_Explicit(JToken value) { }

	// RVA: 0xE53C7C
	public static System.Nullable<System.Single> op_Explicit(JToken value) { }

	// RVA: 0xE53F24
	public static Decimal op_Explicit(JToken value) { }

	// RVA: 0xE541AC
	public static System.Nullable<System.UInt32> op_Explicit(JToken value) { }

	// RVA: 0xE54454
	public static System.Nullable<System.UInt64> op_Explicit(JToken value) { }

	// RVA: 0xE546FC
	public static Double op_Explicit(JToken value) { }

	// RVA: 0xE54984
	public static float op_Explicit(JToken value) { }

	// RVA: 0xE54C0C
	public static string op_Explicit(JToken value) { }

	// RVA: 0xE54F3C
	public static UInt32 op_Explicit(JToken value) { }

	// RVA: 0xE551C4
	public static UInt64 op_Explicit(JToken value) { }

	// RVA: 0xE5544C
	public static Guid op_Explicit(JToken value) { }

	// RVA: 0xE556DC
	public static System.Nullable<System.Guid> op_Explicit(JToken value) { }

	// RVA: 0xE559F0
	public static TimeSpan op_Explicit(JToken value) { }

	// RVA: 0xE55C70
	public static System.Nullable<System.TimeSpan> op_Explicit(JToken value) { }

	// RVA: 0xE55F2C
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0xE561A8
	private static BigInteger ToBigInteger(JToken value) { }

	// RVA: 0xE56374
	private static System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(JToken value) { }

	// RVA: 0xE565C8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xE5667C
	private System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: 0xE56718
	public JsonReader CreateReader() { }

	// RVA: 0xE56840
	public object ToObject(Type objectType) { }

	// RVA: 0xE5763C
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0xE578B8
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0xE57940
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xE449E8
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0xE57D3C
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0xE58054
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE580B4
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE58114
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE58174
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0xE58248
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0xE58258
	private object System.ICloneable.Clone() { }

	// RVA: 0xE58268
	public JToken DeepClone() { }

	// RVA: 0xE57DF0
	public void AddAnnotation(object annotation) { }

	// RVA: 0x26AD93C
	public T Annotation() { }

	// RVA: 0xE457A0
	internal void CopyAnnotations(JToken target, JToken source) { }

	// RVA: 0xE58278
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

	// RVA: 0xE58584
	public JToken get_CurrentToken() { }

	// RVA: 0xE567C8
	public void .ctor(JToken token) { }

	// RVA: 0xE5858C
	public override bool Read() { }

	// RVA: 0xE58798
	private bool ReadOver(JToken t) { }

	// RVA: 0xE58FB8
	private bool ReadToEnd() { }

	// RVA: 0xE5916C
	private System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0xE58704
	private bool ReadInto(JContainer c) { }

	// RVA: 0xE58FF4
	private bool SetEnd(JContainer c) { }

	// RVA: 0xE58884
	private void SetToken(JToken token) { }

	// RVA: 0xE592DC
	private string SafeToString(object value) { }

	// RVA: 0xE592FC
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE593C4
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE59490
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE5955C
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

	// RVA: 0xE5967C
	public JToken get_Token() { }

	// RVA: 0xE59698
	public void .ctor() { }

	// RVA: 0xE59720
	public override void Close() { }

	// RVA: 0xE59728
	public override void WriteStartObject() { }

	// RVA: 0xE597D4
	private void AddParent(JContainer container) { }

	// RVA: 0xE59840
	private void RemoveParent() { }

	// RVA: 0xE598C0
	public override void WriteStartArray() { }

	// RVA: 0xE5996C
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE59A24
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xE59A28
	public override void WritePropertyName(string name) { }

	// RVA: 0xE59B30
	private void AddRawValue(object value, JTokenType type, JsonToken token) { }

	// RVA: 0xE59BF8
	internal void AddJValue(JValue value, JsonToken token) { }

	// RVA: 0xE59CC4
	public override void WriteValue(object value) { }

	// RVA: 0xE59D64
	public override void WriteNull() { }

	// RVA: 0xE59D94
	public override void WriteUndefined() { }

	// RVA: 0xE59DC4
	public override void WriteRaw(string json) { }

	// RVA: 0xE59E9C
	public override void WriteComment(string text) { }

	// RVA: 0xE59F6C
	public override void WriteValue(string value) { }

	// RVA: 0xE5A0C8
	public override void WriteValue(int value) { }

	// RVA: 0xE5A124
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xE5A180
	public override void WriteValue(Int64 value) { }

	// RVA: 0xE5A2C8
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xE5A46C
	public override void WriteValue(float value) { }

	// RVA: 0xE5A618
	public override void WriteValue(Double value) { }

	// RVA: 0xE5A770
	public override void WriteValue(bool value) { }

	// RVA: 0xE5A8B8
	public override void WriteValue(Int16 value) { }

	// RVA: 0xE5A914
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xE5A970
	public override void WriteValue(Char value) { }

	// RVA: 0xE5AAB4
	public override void WriteValue(Byte value) { }

	// RVA: 0xE5AB10
	public override void WriteValue(SByte value) { }

	// RVA: 0xE5AB6C
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE5ACD8
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE5AE60
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE5AFC4
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xE5B09C
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE5B1E0
	public override void WriteValue(Guid value) { }

	// RVA: 0xE5B344
	public override void WriteValue(Uri value) { }

	// RVA: 0xE5B4C4
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

}

// Namespace: 
private class JValueDynamicProxy
{
	// Methods

	// RVA: 0xE5EA8C
	public override bool TryConvert(JValue instance, ConvertBinder binder, object result) { }

	// RVA: 0xE5EC6C
	public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, object result) { }

	// RVA: 0xE5E178
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JValue
{
	// Fields
	private JTokenType _valueType; // 0x30
	private object _value; // 0x38

	// Methods

	// RVA: 0xE4F12C
	internal void .ctor(object value, JTokenType type) { }

	// RVA: 0xE4EF84
	internal void .ctor(JValue other, JsonCloneSettings settings) { }

	// RVA: 0xE5A1FC
	public void .ctor(Int64 value) { }

	// RVA: 0xE5ABFC
	public void .ctor(Decimal value) { }

	// RVA: 0xE5A3C8
	public void .ctor(UInt64 value) { }

	// RVA: 0xE5A69C
	public void .ctor(Double value) { }

	// RVA: 0xE5A574
	public void .ctor(float value) { }

	// RVA: 0xE5AD98
	public void .ctor(DateTime value) { }

	// RVA: 0xE5AEF0
	public void .ctor(DateTimeOffset value) { }

	// RVA: 0xE5A7EC
	public void .ctor(bool value) { }

	// RVA: 0xE5A044
	public void .ctor(string value) { }

	// RVA: 0xE5B270
	public void .ctor(Guid value) { }

	// RVA: 0xE5B3C0
	public void .ctor(Uri value) { }

	// RVA: 0xE5B118
	public void .ctor(TimeSpan value) { }

	// RVA: 0xE48598
	public void .ctor(object value) { }

	// RVA: 0xE5BB58
	public override bool get_HasValues() { }

	// RVA: 0xE5BB60
	private static int CompareBigInteger(BigInteger i1, object i2) { }

	// RVA: 0xE5BEB8
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	// RVA: 0xE5C8EC
	private static int CompareFloat(object objA, object objB) { }

	// RVA: 0xE5CA30
	private static bool Operation(ExpressionType operation, object objA, object objB, object result) { }

	// RVA: 0xE5D22C
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xE48CB4
	public static JValue CreateComment(string value) { }

	// RVA: 0xE463CC
	public static JValue CreateNull() { }

	// RVA: 0xE48D6C
	public static JValue CreateUndefined() { }

	// RVA: 0xE5B7C8
	private static JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, object value) { }

	// RVA: 0xE5D298
	private static JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current) { }

	// RVA: 0xE5D460
	public override JTokenType get_Type() { }

	// RVA: 0xE5D468
	public object get_Value() { }

	// RVA: 0xE5D470
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE5DD70
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0xE5DDD8
	public bool Equals(JValue other) { }

	// RVA: 0xE5DE40
	public override bool Equals(object obj) { }

	// RVA: 0xE5DF1C
	public override int GetHashCode() { }

	// RVA: 0xE5DF34
	public override string ToString() { }

	// RVA: 0xE5DF60
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0xE5DF6C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xE5E08C
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0xE5E1CC
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xE5E288
	public int CompareTo(JValue obj) { }

	// RVA: 0xE5E2B8
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0xE5E388
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xE5E408
	private Char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xE5E488
	private SByte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xE5E508
	private Byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xE5E588
	private Int16 System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xE5E608
	private UInt16 System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xE5E688
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xE5E708
	private UInt32 System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xE5E788
	private Int64 System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xE5E808
	private UInt64 System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xE5E888
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xE5E908
	private Double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xE5E988
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xE5EA08
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xE5EA88
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

	// RVA: 0xE5EFEC
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE5F050
	private Byte[] GetByteArray(object value) { }

	// RVA: 0xE5F250
	private static void EnsureReflectionObject(Type t) { }

	// RVA: 0xE5F400
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE5F830
	private Byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0xE5FB64
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE5FC80
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class BsonObjectIdConverter
{
	// Methods

	// RVA: 0xE5FC88
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE5FD8C
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE5FF18
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE5FF98
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public abstract class CustomCreationConverter<T0>
{
	// Methods

	// RVA: 0x3526BA8
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x3525A7C
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: -1
	public abstract T Create(Type objectType) { }

	// RVA: 0x35252FC
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x35251DC
	public override bool get_CanWrite() { }

	// RVA: 0x35263A0
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class DataSetConverter
{
	// Methods

	// RVA: 0xE5FFA0
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE60444
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE60780
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xE60834
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class DataTableConverter
{
	// Methods

	// RVA: 0xE6083C
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE60FD4
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE612AC
	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	// RVA: 0xE617C0
	private static Type GetColumnDataType(JsonReader reader) { }

	// RVA: 0xE6199C
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xE61A50
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public abstract class DateTimeConverterBase
{
	// Methods

	// RVA: 0xE61A58
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE61BC4
	protected void .ctor() { }

}

// Namespace: 
internal class Union
{
	// Fields
	public readonly FSharpFunction TagReader; // 0x10
	public readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases; // 0x18

	// Methods

	// RVA: 0xE62740
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

	// RVA: 0xE62790
	public void .ctor(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public int tag; // 0x10

	// Methods

	// RVA: 0xE62D0C
	public void .ctor() { }

	// RVA: 0xE63898
	internal bool <WriteJson>b__0(UnionCase c) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public string caseName; // 0x10
	public System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase,System.Boolean> <>9__0; // 0x18

	// Methods

	// RVA: 0xE633F4
	public void .ctor() { }

	// RVA: 0xE638C0
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

	// RVA: 0xE61BCC
	private static Type CreateUnionTypeLookup(Type t) { }

	// RVA: 0xE61E44
	private static Union CreateUnion(Type t) { }

	// RVA: 0xE62818
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE62D14
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE633FC
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE636FC
	public void .ctor() { }

	// RVA: 0xE63704
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

	// RVA: 0xE638E8
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE63D98
	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	// RVA: 0xE63E88
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE63C74
	private static void EnsureReflectionObject(Type objectType) { }

	// RVA: 0xE64174
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE641D0
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class ExpandoObjectConverter
{
	// Methods

	// RVA: 0xE641D8
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE641DC
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE641E0
	private object ReadValue(JsonReader reader) { }

	// RVA: 0xE645A4
	private object ReadList(JsonReader reader) { }

	// RVA: 0xE64350
	private object ReadObject(JsonReader reader) { }

	// RVA: 0xE64784
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE64804
	public override bool get_CanWrite() { }

	// RVA: 0xE6480C
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

	// RVA: 0xE64814
	public DateTimeStyles get_DateTimeStyles() { }

	// RVA: 0xE6481C
	public void set_DateTimeStyles(DateTimeStyles value) { }

	// RVA: 0xE64824
	public string get_DateTimeFormat() { }

	// RVA: 0xE64848
	public void set_DateTimeFormat(string value) { }

	// RVA: 0xE6488C
	public CultureInfo get_Culture() { }

	// RVA: 0xE64908
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xE64910
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE64C30
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE65304
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class JavaScriptDateTimeConverter
{
	// Methods

	// RVA: 0xE65314
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE65500
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE65860
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

	// RVA: 0xE65868
	private static ReflectionObject InitializeReflectionObject(Type t) { }

	// RVA: 0xE65AE8
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE65D74
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE6626C
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE663B0
	public void .ctor() { }

	// RVA: 0xE663B8
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class RegexConverter
{
	// Fields
	private const string PatternName = "Pattern";
	private const string OptionsName = "Options";

	// Methods

	// RVA: 0xE664A4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE668F4
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0xE665C0
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0xE6672C
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0xE669B4
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE66D60
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0xE66A64
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0xE66EB4
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE66F30
	private bool IsRegex(Type objectType) { }

	// RVA: 0xE66FB0
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class StringEnumConverter
{
	// Fields
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x10
	private bool <AllowIntegerValues>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE66FB8
	public bool get_CamelCaseText() { }

	// RVA: 0xE67040
	public void set_CamelCaseText(bool value) { }

	// RVA: 0xE67128
	public NamingStrategy get_NamingStrategy() { }

	// RVA: 0xE67130
	public void set_NamingStrategy(NamingStrategy value) { }

	// RVA: 0xE67138
	public bool get_AllowIntegerValues() { }

	// RVA: 0xE67140
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0xE67148
	public void .ctor() { }

	// RVA: 0xE67158
	public void .ctor(bool camelCaseText) { }

	// RVA: 0xE671F0
	public void .ctor(NamingStrategy namingStrategy, bool allowIntegerValues) { }

	// RVA: 0xE67240
	public void .ctor(Type namingStrategyType) { }

	// RVA: 0xE672FC
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters) { }

	// RVA: 0xE673BC
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) { }

	// RVA: 0xE67490
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE67694
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE67B64
	public override bool CanConvert(Type objectType) { }

}

// Namespace: Newtonsoft.Json.Converters
public class UnixDateTimeConverter
{
	// Fields
	internal static readonly DateTime UnixEpoch; // 0x0
	private bool <AllowPreEpoch>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE67C14
	public bool get_AllowPreEpoch() { }

	// RVA: 0xE67C1C
	public void set_AllowPreEpoch(bool value) { }

	// RVA: 0xE67C24
	public void .ctor() { }

	// RVA: 0xE67C4C
	public void .ctor(bool allowPreEpoch) { }

	// RVA: 0xE67C78
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE67EE4
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE6831C
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class VersionConverter
{
	// Methods

	// RVA: 0xE6839C
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE68494
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE68734
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE687B4
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDocumentWrapper
{
	// Fields
	private readonly XmlDocument _document; // 0x28

	// Methods

	// RVA: 0xE687BC
	public void .ctor(XmlDocument document) { }

	// RVA: 0xE68834
	public IXmlNode CreateComment(string data) { }

	// RVA: 0xE688D0
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xE6896C
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xE68A08
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xE68AA4
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xE68B40
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE68C48
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE68D54
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE68DF8
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xE68EE0
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xE68F8C
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xE69064
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xE69128
	public IXmlElement get_DocumentElement() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlElementWrapper
{
	// Fields
	private readonly XmlElement _element; // 0x28

	// Methods

	// RVA: 0xE68E9C
	public void .ctor(XmlElement element) { }

	// RVA: 0xE691E4
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xE692D8
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xE69300
	public bool get_IsEmpty() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDeclarationWrapper
{
	// Fields
	private readonly XmlDeclaration _declaration; // 0x28

	// Methods

	// RVA: 0xE68C04
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0xE69320
	public string get_Version() { }

	// RVA: 0xE69340
	public string get_Encoding() { }

	// RVA: 0xE69360
	public string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDocumentTypeWrapper
{
	// Fields
	private readonly XmlDocumentType _documentType; // 0x28

	// Methods

	// RVA: 0xE68D10
	public void .ctor(XmlDocumentType documentType) { }

	// RVA: 0xE69380
	public string get_Name() { }

	// RVA: 0xE693A4
	public string get_System() { }

	// RVA: 0xE693C4
	public string get_Public() { }

	// RVA: 0xE693E4
	public string get_InternalSubset() { }

	// RVA: 0xE69404
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

	// RVA: 0xE68800
	public void .ctor(XmlNode node) { }

	// RVA: 0xE69448
	public object get_WrappedNode() { }

	// RVA: 0xE69450
	public XmlNodeType get_NodeType() { }

	// RVA: 0xE69474
	public virtual string get_LocalName() { }

	// RVA: 0xE6949C
	public System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE69878
	internal static IXmlNode WrapNode(XmlNode node) { }

	// RVA: 0xE69A10
	public System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE69E60
	private bool get_HasAttributes() { }

	// RVA: 0xE69F14
	public IXmlNode get_ParentNode() { }

	// RVA: 0xE69FCC
	public string get_Value() { }

	// RVA: 0xE69040
	public void set_Value(string value) { }

	// RVA: 0xE69FF0
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE6A0BC
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

	// RVA: 0xE6A0E4
	internal XDeclaration get_Declaration() { }

	// RVA: 0xE6A0EC
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0xE6A164
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE6A16C
	public string get_Version() { }

	// RVA: 0xE6A18C
	public string get_Encoding() { }

	// RVA: 0xE6A1AC
	public string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDocumentTypeWrapper
{
	// Fields
	private readonly XDocumentType _documentType; // 0x18

	// Methods

	// RVA: 0xE6A1CC
	public void .ctor(XDocumentType documentType) { }

	// RVA: 0xE6A210
	public string get_Name() { }

	// RVA: 0xE6A230
	public string get_System() { }

	// RVA: 0xE6A250
	public string get_Public() { }

	// RVA: 0xE6A270
	public string get_InternalSubset() { }

	// RVA: 0xE6A290
	public override string get_LocalName() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDocumentWrapper
{
	// Methods

	// RVA: 0xE6A2D4
	private XDocument get_Document() { }

	// RVA: 0xE6A350
	public void .ctor(XDocument document) { }

	// RVA: 0xE6A3B8
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE6AA3C
	protected override bool get_HasChildNodes() { }

	// RVA: 0xE6ABD0
	public IXmlNode CreateComment(string text) { }

	// RVA: 0xE6AC70
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xE6AD10
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xE6ADB0
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xE6AE50
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xE6AEF0
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE6AFB8
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE6B090
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE6B174
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xE6B258
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xE6B320
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xE6B414
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xE6B4E4
	public IXmlElement get_DocumentElement() { }

	// RVA: 0xE6B654
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XTextWrapper
{
	// Methods

	// RVA: 0xE6B8CC
	private XText get_Text() { }

	// RVA: 0xE6B948
	public void .ctor(XText text) { }

	// RVA: 0xE6B97C
	public override string get_Value() { }

	// RVA: 0xE6BA00
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XCommentWrapper
{
	// Methods

	// RVA: 0xE6BE14
	private XComment get_Text() { }

	// RVA: 0xE6BE90
	public void .ctor(XComment text) { }

	// RVA: 0xE6BEC4
	public override string get_Value() { }

	// RVA: 0xE6BF48
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XProcessingInstructionWrapper
{
	// Methods

	// RVA: 0xE6C044
	private XProcessingInstruction get_ProcessingInstruction() { }

	// RVA: 0xE6B140
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0xE6C0C0
	public override string get_LocalName() { }

	// RVA: 0xE6C144
	public override string get_Value() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XContainerWrapper
{
	// Fields
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes; // 0x18

	// Methods

	// RVA: 0xE6C1C8
	private XContainer get_Container() { }

	// RVA: 0xE6A384
	public void .ctor(XContainer container) { }

	// RVA: 0xE6A634
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE6AB40
	protected virtual bool get_HasChildNodes() { }

	// RVA: 0xE6C244
	public override IXmlNode get_ParentNode() { }

	// RVA: 0xE6BAFC
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0xE6B768
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XObjectWrapper
{
	// Fields
	private readonly XObject _xmlObject; // 0x10

	// Methods

	// RVA: 0xE6A130
	public void .ctor(XObject xmlObject) { }

	// RVA: 0xE6C340
	public object get_WrappedNode() { }

	// RVA: 0xE6C348
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0xE6C360
	public virtual string get_LocalName() { }

	// RVA: 0xE6C368
	public virtual System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE6C3E4
	public virtual System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE6C460
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0xE6C468
	public virtual string get_Value() { }

	// RVA: 0xE6C470
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE6C4B0
	public virtual string get_NamespaceUri() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XAttributeWrapper
{
	// Methods

	// RVA: 0xE6C4B8
	private XAttribute get_Attribute() { }

	// RVA: 0xE6B3E0
	public void .ctor(XAttribute attribute) { }

	// RVA: 0xE6C534
	public override string get_Value() { }

	// RVA: 0xE6C5B8
	public override string get_LocalName() { }

	// RVA: 0xE6C644
	public override string get_NamespaceUri() { }

	// RVA: 0xE6C6D0
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XElementWrapper
{
	// Fields
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes; // 0x20

	// Methods

	// RVA: 0xE6C7CC
	private XElement get_Element() { }

	// RVA: 0xE6B224
	public void .ctor(XElement element) { }

	// RVA: 0xE6C848
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xE6C950
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE6CEF0
	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	// RVA: 0xE6D4E0
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE6D518
	public override string get_Value() { }

	// RVA: 0xE6D59C
	public override string get_LocalName() { }

	// RVA: 0xE6D628
	public override string get_NamespaceUri() { }

	// RVA: 0xE6D42C
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xE6D6B4
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

	// RVA: 0xE6D738
	public string get_DeserializeRootElementName() { }

	// RVA: 0xE6D740
	public void set_DeserializeRootElementName(string value) { }

	// RVA: 0xE6D748
	public bool get_WriteArrayAttribute() { }

	// RVA: 0xE6D750
	public void set_WriteArrayAttribute(bool value) { }

	// RVA: 0xE6D758
	public bool get_OmitRootObject() { }

	// RVA: 0xE6D760
	public void set_OmitRootObject(bool value) { }

	// RVA: 0xE6D768
	public bool get_EncodeSpecialCharacters() { }

	// RVA: 0xE6D770
	public void set_EncodeSpecialCharacters(bool value) { }

	// RVA: 0xE6D778
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE6D8C4
	private IXmlNode WrapXml(object value) { }

	// RVA: 0xE6D9E0
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE6FA2C
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE6FDE4
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE702BC
	private bool IsArray(IXmlNode node) { }

	// RVA: 0xE706C8
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xE71308
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, string elementNames) { }

	// RVA: 0xE7148C
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	// RVA: 0xE6E1A8
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xE71560
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0xE71C0C
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE730F8
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0xE724F4
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0xE754F0
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, System.Collections.Generic.Dictionary<System.String,System.String> attributeNameValues) { }

	// RVA: 0xE75164
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0xE736E4
	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0xE74644
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0xE7604C
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0xE74A78
	private bool ShouldReadInto(JsonReader reader) { }

	// RVA: 0xE74ABC
	private System.Collections.Generic.Dictionary<System.String,System.String> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0xE73DBC
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0xE7426C
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0xE75E34
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0xE72898
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0xE763A0
	private bool IsNamespaceAttribute(string attributeName, string prefix) { }

	// RVA: 0xE7189C
	private bool ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c) { }

	// RVA: 0xE76488
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xE76540
	private bool IsXObject(Type valueType) { }

	// RVA: 0xE765F4
	private bool IsXmlNode(Type valueType) { }

	// RVA: 0xE766A8
	public void .ctor() { }

	// RVA: 0xE766B0
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Bson
public class BsonObjectId
{
	// Fields
	private readonly Byte[] <Value>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE7674C
	public Byte[] get_Value() { }

	// RVA: 0xE76754
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

	// RVA: 0xE7683C
	public void set_Parent(BsonToken value) { }

	// RVA: 0xE76844
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonObject
{
	// Fields
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children; // 0x18

	// Methods

	// RVA: 0xE7684C
	public void Add(string name, BsonToken token) { }

	// RVA: 0xE769B8
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonArray
{
	// Fields
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children; // 0x18

	// Methods

	// RVA: 0xE769C0
	public void Add(BsonToken token) { }

	// RVA: 0xE76A38
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonValue
{
	// Fields
	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	// Methods

	// RVA: 0xE76A40
	public void .ctor(object value, BsonType type) { }

	// RVA: 0xE76A88
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonString
{
	// Fields
	private readonly bool <IncludeLength>k__BackingField; // 0x21

	// Methods

	// RVA: 0xE76968
	public void .ctor(object value, bool includeLength) { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonRegex
{
	// Fields
	private BsonString <Pattern>k__BackingField; // 0x18
	private BsonString <Options>k__BackingField; // 0x20

	// Methods

	// RVA: 0xE76A90
	public void set_Pattern(BsonString value) { }

	// RVA: 0xE76A98
	public void set_Options(BsonString value) { }

	// RVA: 0xE76AA0
	public void .ctor(string pattern, string options) { }

	// RVA: 0xE76B78
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonProperty
{
	// Fields
	private BsonString <Name>k__BackingField; // 0x10
	private BsonToken <Value>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE76B80
	public void set_Name(BsonString value) { }

	// RVA: 0xE76B88
	public void set_Value(BsonToken value) { }

	// RVA: 0xE76960
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

	// RVA: 0xE76B90
	private void AddValue(object value, BsonType type) { }

	// RVA: 0xE76C1C
	internal void AddToken(BsonToken token) { }

	// RVA: 0xE76E6C
	public void WriteObjectId(Byte[] value) { }

	// RVA: 0xE66900
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


