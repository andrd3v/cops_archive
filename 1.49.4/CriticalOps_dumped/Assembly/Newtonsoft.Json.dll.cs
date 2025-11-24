// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0xD721BC
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class IsReadOnlyAttribute
{
	// Methods

	// RVA: 0xD721C4
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xD721CC
	public void .ctor(Byte ) { }

	// RVA: 0xD72258
	public void .ctor(Byte[] ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0xD7228C
	public void .ctor(Byte ) { }

}

// Namespace: System.Diagnostics.CodeAnalysis
internal sealed class NotNullAttribute
{
	// Methods

	// RVA: 0xD722B8
	public void .ctor() { }

}

// Namespace: System.Diagnostics.CodeAnalysis
internal sealed class NotNullWhenAttribute
{
	// Fields
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD722C0
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

	// RVA: 0xD729FC
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

	// RVA: 0xD722EC
	private static void .cctor() { }

	// RVA: 0xD72340
	public void .ctor() { }

	// RVA: 0xD723C4
	public override string Get(Char[] key, int start, int length) { }

	// RVA: 0xD726F0
	public string Add(string key) { }

	// RVA: 0xD728C4
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0xD72A54
	private void Grow() { }

	// RVA: 0xD72614
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

	// RVA: 0xD72BE0
	public Type get_ItemConverterType() { }

	// RVA: 0xD72BE8
	public object[] get_ItemConverterParameters() { }

	// RVA: 0xD72BF0
	public Type get_NamingStrategyType() { }

	// RVA: 0xD72BF8
	public object[] get_NamingStrategyParameters() { }

	// RVA: 0xD72C00
	internal NamingStrategy get_NamingStrategyInstance() { }

	// RVA: 0xD72C08
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

	// RVA: 0xD72C10
	public static System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings() { }

	// RVA: 0xD72C8C
	public static string ToString(bool value) { }

	// RVA: 0xD72D28
	public static string ToString(Char value) { }

	// RVA: 0xD72EF0
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD73168
	private static string EnsureFloatFormat(Double value, string text, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD73290
	internal static string ToString(Double value, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD730A0
	private static string EnsureDecimalPlace(Double value, string text) { }

	// RVA: 0xD73438
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0xD734B0
	public static string ToString(Decimal value) { }

	// RVA: 0xD72DD0
	public static string ToString(string value) { }

	// RVA: 0xD73640
	public static string ToString(string value, Char delimiter) { }

	// RVA: 0xD736AC
	public static string ToString(string value, Char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xD73790
	public static string SerializeObject(object value) { }

	// RVA: 0xD73860
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xD73928
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	// RVA: 0x315B3A8
	public static T DeserializeObject(string value) { }

	// RVA: 0x315B3A8
	public static T DeserializeObject(string value, JsonSerializerSettings settings) { }

	// RVA: 0xD73E20
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xD742A0
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

	// RVA: 0xD74414
	public virtual bool get_CanRead() { }

	// RVA: 0xD7441C
	public virtual bool get_CanWrite() { }

	// RVA: 0xD74424
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonConverterAttribute
{
	// Fields
	private readonly Type _converterType; // 0x10
	private readonly object[] <ConverterParameters>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD7442C
	public Type get_ConverterType() { }

	// RVA: 0xD74434
	public object[] get_ConverterParameters() { }

}

// Namespace: Newtonsoft.Json
public class JsonConverterCollection
{
	// Methods

	// RVA: 0xD7443C
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

	// RVA: 0xD74490
	public void .ctor() { }

	// RVA: 0xD74518
	public void .ctor(string message) { }

	// RVA: 0xD74584
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xD74600
	public void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: Newtonsoft.Json
public class JsonExtensionDataAttribute
{
	// Fields
	private bool <WriteData>k__BackingField; // 0x10
	private bool <ReadData>k__BackingField; // 0x11

	// Methods

	// RVA: 0xD74684
	public bool get_WriteData() { }

	// RVA: 0xD7468C
	public bool get_ReadData() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonIgnoreAttribute
{
	// Methods

	// RVA: 0xD74694
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json
public abstract class JsonNameTable
{
	// Methods

	// RVA: -1
	public abstract string Get(Char[] key, int start, int length) { }

	// RVA: 0xD723BC
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

	// RVA: 0xD7469C
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

	// RVA: 0xD746A4
	public void .ctor(JsonContainerType type) { }

	// RVA: 0xD7473C
	internal int CalculateLength() { }

	// RVA: 0xD747E4
	internal void WriteTo(StringBuilder sb, StringWriter writer, Char[] buffer) { }

	// RVA: 0xD7472C
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0xD74A30
	internal static string BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition) { }

	// RVA: 0xD74F18
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0xD75250
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

	// RVA: 0xD752F4
	public Type get_ItemConverterType() { }

	// RVA: 0xD752FC
	public object[] get_ItemConverterParameters() { }

	// RVA: 0xD75304
	public Type get_NamingStrategyType() { }

	// RVA: 0xD7530C
	public object[] get_NamingStrategyParameters() { }

	// RVA: 0xD75314
	public string get_PropertyName() { }

	// RVA: 0xD7531C
	public void set_PropertyName(string value) { }

	// RVA: 0xD75324
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

	// RVA: 0xD7532C
	protected State get_CurrentState() { }

	// RVA: 0xD75334
	public bool get_CloseInput() { }

	// RVA: 0xD7533C
	public void set_CloseInput(bool value) { }

	// RVA: 0xD75344
	public bool get_SupportMultipleContent() { }

	// RVA: 0xD7534C
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0xD75354
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xD7535C
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xD753C8
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0xD753D0
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0xD7543C
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0xD75444
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0xD754B0
	public string get_DateFormatString() { }

	// RVA: 0xD754B8
	public void set_DateFormatString(string value) { }

	// RVA: 0xD754C0
	public System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xD754C8
	public void set_MaxDepth(System.Nullable<System.Int32> value) { }

	// RVA: 0xD7565C
	public virtual JsonToken get_TokenType() { }

	// RVA: 0xD75664
	public virtual object get_Value() { }

	// RVA: 0xD7566C
	public virtual Type get_ValueType() { }

	// RVA: 0xD75680
	public virtual int get_Depth() { }

	// RVA: 0xD756FC
	public virtual string get_Path() { }

	// RVA: 0xD7582C
	public CultureInfo get_Culture() { }

	// RVA: 0xD758A8
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xD758B0
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0xD75970
	protected void .ctor() { }

	// RVA: 0xD75A14
	private void Push(JsonContainerType value) { }

	// RVA: 0xD75ECC
	private JsonContainerType Pop() { }

	// RVA: 0xD760F4
	private JsonContainerType Peek() { }

	// RVA: -1
	public abstract bool Read() { }

	// RVA: 0xD760FC
	public virtual System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xD76870
	internal System.Nullable<System.Int32> ReadInt32String(string s) { }

	// RVA: 0xD76AF0
	public virtual string ReadAsString() { }

	// RVA: 0xD76EBC
	public virtual Byte[] ReadAsBytes() { }

	// RVA: 0xD77610
	internal Byte[] ReadArrayIntoByteArray() { }

	// RVA: 0xD7778C
	private bool ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<System.Byte> buffer) { }

	// RVA: 0xD77978
	public virtual System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xD77CE8
	internal System.Nullable<System.Double> ReadDoubleString(string s) { }

	// RVA: 0xD77F68
	public virtual System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xD78330
	internal System.Nullable<System.Boolean> ReadBooleanString(string s) { }

	// RVA: 0xD78550
	public virtual System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xD78A10
	internal System.Nullable<System.Decimal> ReadDecimalString(string s) { }

	// RVA: 0xD78D2C
	public virtual System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xD7906C
	internal System.Nullable<System.DateTime> ReadDateTimeString(string s) { }

	// RVA: 0xD79418
	public virtual System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xD79750
	internal System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0xD775C0
	internal void ReaderReadAndAssert() { }

	// RVA: 0xD79AC8
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0xD773A0
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0xD79B88
	public void Skip() { }

	// RVA: 0xD77780
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0xD79C24
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0xD76670
	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0xD79D4C
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0xD75E30
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0xD79C2C
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0xD79E70
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0xD79D94
	private void SetFinished() { }

	// RVA: 0xD79DC0
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0xD79F90
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD7A024
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD7A048
	public virtual void Close() { }

	// RVA: 0xD7A060
	internal void ReadAndAssert() { }

	// RVA: 0xD7A144
	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	// RVA: 0xD7A19C
	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	// RVA: 0xD7A4C4
	internal bool ReadAndMoveToContent() { }

	// RVA: 0xD7A530
	internal bool MoveToContent() { }

	// RVA: 0xD76554
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

	// RVA: 0xD7A58C
	public void .ctor() { }

	// RVA: 0xD7A614
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD7A698
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0xD75E48
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0xD765E0
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xD7A740
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonRequiredAttribute
{
	// Methods

	// RVA: 0xD7A9A4
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

	// RVA: 0xD7A9AC
	public void .ctor() { }

	// RVA: 0xD7AA34
	public void .ctor(string message) { }

	// RVA: 0xD7AAA0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xD7AB1C
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD7ABA0
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0xD7A0C0
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0xD7AC48
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xD7ACD8
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

	// RVA: 0xD7AF3C
	public virtual void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xD7AFF0
	public virtual void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xD7B0A4
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xD7B120
	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0xD7B19C
	public virtual ITraceWriter get_TraceWriter() { }

	// RVA: 0xD7B1A4
	public virtual void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0xD7B1AC
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xD7B1B4
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xD7B220
	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0xD7B28C
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xD7B2F8
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xD7B364
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xD7B3D0
	public virtual NullValueHandling get_NullValueHandling() { }

	// RVA: 0xD7B3D8
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xD7B444
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0xD7B4B0
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xD7B51C
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0xD7B588
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xD7B590
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xD7B5FC
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0xD7B6BC
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0xD7B6C4
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xD7B7A8
	public virtual StreamingContext get_Context() { }

	// RVA: 0xD7B7B4
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0xD7B7C0
	public virtual Formatting get_Formatting() { }

	// RVA: 0xD7B898
	public virtual System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xD7B8A0
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0xD7B978
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xD74080
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0xD7B9F0
	public void .ctor() { }

	// RVA: 0xD7BB5C
	public static JsonSerializer Create() { }

	// RVA: 0xD7BBB0
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0xD7CD60
	public static JsonSerializer CreateDefault() { }

	// RVA: 0xD738F0
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0xD7BC20
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	// RVA: 0xD7D88C
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xD7D89C
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0x315B3A8
	public T Deserialize(JsonReader reader) { }

	// RVA: 0xD74290
	public object Deserialize(JsonReader reader, Type objectType) { }

	// RVA: 0xD7EC30
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xD7DB20
	internal void SetupReader(JsonReader reader, CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>& previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling>& previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling>& previousFloatParseHandling, System.Nullable<System.Int32>& previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xD7E710
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<System.Int32> previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xD73E10
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xD7EEBC
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0xD7E67C
	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	// RVA: 0xD7EED0
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xD8046C
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0xD804F4
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0xD804FC
	internal static JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, Type objectType) { }

	// RVA: 0xD80698
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

	// RVA: 0xD7D210
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0xD7D2E8
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0xD7D3C0
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xD7D498
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0xD7D570
	public DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0xD806BC
	public System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters() { }

	// RVA: 0xD7D138
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0xD7CEB0
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0xD7CF88
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xD7D060
	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0xD7D648
	public ConstructorHandling get_ConstructorHandling() { }

	// RVA: 0xD806C4
	public IContractResolver get_ContractResolver() { }

	// RVA: 0xD806CC
	public IEqualityComparer get_EqualityComparer() { }

	// RVA: 0xD806D4
	public System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider() { }

	// RVA: 0xD806DC
	public ITraceWriter get_TraceWriter() { }

	// RVA: 0xD806E4
	public ISerializationBinder get_SerializationBinder() { }

	// RVA: 0xD806EC
	public System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error() { }

	// RVA: 0xD7D720
	public StreamingContext get_Context() { }

	// RVA: 0xD806F4
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

	// RVA: 0xD74100
	public void .ctor(TextReader reader) { }

	// RVA: 0xD80784
	public JsonNameTable get_PropertyNameTable() { }

	// RVA: 0xD8078C
	public void set_PropertyNameTable(JsonNameTable value) { }

	// RVA: 0xD80794
	private void EnsureBufferNotEmpty() { }

	// RVA: 0xD807F8
	private void SetNewLine(bool hasNextChar) { }

	// RVA: 0xD8086C
	private void OnNewLine(int pos) { }

	// RVA: 0xD8087C
	private void ParseString(Char quote, ReadType readType) { }

	// RVA: 0xD81068
	private void ParseReadString(Char quote, ReadType readType) { }

	// RVA: 0xD81580
	private static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	// RVA: 0xD808D0
	private void ShiftBufferIfNeeded() { }

	// RVA: 0xD81594
	private int ReadData(bool append) { }

	// RVA: 0xD8163C
	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	// RVA: 0xD8159C
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0xD81800
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0xD81898
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0xD81918
	public override bool Read() { }

	// RVA: 0xD82D7C
	public override System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xD83388
	public override System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xD83ABC
	public override string ReadAsString() { }

	// RVA: 0xD83B24
	public override Byte[] ReadAsBytes() { }

	// RVA: 0xD83448
	private object ReadStringValue(ReadType readType) { }

	// RVA: 0xD846F4
	private object FinishReadQuotedStringValue(ReadType readType) { }

	// RVA: 0xD8434C
	private JsonReaderException CreateUnexpectedCharacterException(Char c) { }

	// RVA: 0xD84D50
	public override System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xD842DC
	private void ProcessValueComma() { }

	// RVA: 0xD82E3C
	private object ReadNumberValue(ReadType readType) { }

	// RVA: 0xD853F4
	private object FinishReadQuotedNumber(ReadType readType) { }

	// RVA: 0xD85580
	public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xD85650
	public override System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xD85720
	public override System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xD841D8
	private void HandleNull() { }

	// RVA: 0xD84558
	private void ReadFinished() { }

	// RVA: 0xD84168
	private bool ReadNullChar() { }

	// RVA: 0xD81BE0
	private void EnsureBuffer() { }

	// RVA: 0xD809AC
	private void ReadStringIntoBuffer(Char quote) { }

	// RVA: 0xD85A10
	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	// RVA: 0xD859BC
	private void WriteCharToBuffer(Char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0xD85AF8
	private Char ConvertUnicode(bool enoughChars) { }

	// RVA: 0xD85918
	private Char ParseUnicode() { }

	// RVA: 0xD85C58
	private void ReadNumberIntoBuffer() { }

	// RVA: 0xD85CE8
	private bool ReadNumberCharIntoBuffer(Char currentChar, int charPos) { }

	// RVA: 0xD85E80
	private void ClearRecentString() { }

	// RVA: 0xD82500
	private bool ParsePostValue(bool ignoreComments) { }

	// RVA: 0xD82314
	private bool ParseObject() { }

	// RVA: 0xD85E8C
	private bool ParseProperty() { }

	// RVA: 0xD861B4
	private bool ValidIdentifierChar(Char value) { }

	// RVA: 0xD8622C
	private void ParseUnquotedProperty() { }

	// RVA: 0xD86320
	private bool ReadUnquotedPropertyReportIfDone(Char currentChar, int initialPosition) { }

	// RVA: 0xD81C50
	private bool ParseValue() { }

	// RVA: 0xD8453C
	private void ProcessLineFeed() { }

	// RVA: 0xD84478
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0xD82860
	private void EatWhitespace() { }

	// RVA: 0xD86824
	private void ParseConstructor() { }

	// RVA: 0xD849D8
	private void ParseNumber(ReadType readType) { }

	// RVA: 0xD86CA0
	private void ParseReadNumber(ReadType readType, Char firstChar, int initialPosition) { }

	// RVA: 0xD87FD8
	private JsonReaderException ThrowReaderError(string message, Exception ex) { }

	// RVA: 0xD880D4
	private static object BigIntegerParse(string number, CultureInfo culture) { }

	// RVA: 0xD8297C
	private void ParseComment(bool setToken) { }

	// RVA: 0xD8815C
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0xD881D4
	private bool MatchValue(string value) { }

	// RVA: 0xD88294
	private bool MatchValue(bool enoughChars, string value) { }

	// RVA: 0xD84AAC
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0xD88374
	private bool IsSeparator(Char c) { }

	// RVA: 0xD86524
	private void ParseTrue() { }

	// RVA: 0xD857E0
	private void ParseNull() { }

	// RVA: 0xD86B6C
	private void ParseUndefined() { }

	// RVA: 0xD866A4
	private void ParseFalse() { }

	// RVA: 0xD84958
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0xD8854C
	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	// RVA: 0xD84C50
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0xD887A8
	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	// RVA: 0xD84CD0
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0xD88A04
	private object ParseNumberNaN(ReadType readType, bool matched) { }

	// RVA: 0xD88C60
	public override void Close() { }

	// RVA: 0xD88CE4
	public bool HasLineInfo() { }

	// RVA: 0xD88CEC
	public int get_LineNumber() { }

	// RVA: 0xD88D48
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

	// RVA: 0xD88D54
	private Base64Encoder get_Base64Encoder() { }

	// RVA: 0xD88DF8
	public Char get_QuoteChar() { }

	// RVA: 0xD73BD4
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0xD88EB8
	public override void Close() { }

	// RVA: 0xD89028
	private void CloseBufferAndWriter() { }

	// RVA: 0xD89090
	public override void WriteStartObject() { }

	// RVA: 0xD89138
	public override void WriteStartArray() { }

	// RVA: 0xD8919C
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xD8926C
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xD8938C
	public override void WritePropertyName(string name) { }

	// RVA: 0xD89504
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xD895E0
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0xD88E38
	private void UpdateCharEscapeFlags() { }

	// RVA: 0xD89660
	protected override void WriteIndent() { }

	// RVA: 0xD89828
	private int SetIndentChars() { }

	// RVA: 0xD8993C
	protected override void WriteValueDelimiter() { }

	// RVA: 0xD89968
	protected override void WriteIndentSpace() { }

	// RVA: 0xD89994
	private void WriteValueInternal(string value, JsonToken token) { }

	// RVA: 0xD899BC
	public override void WriteValue(object value) { }

	// RVA: 0xD89C54
	public override void WriteNull() { }

	// RVA: 0xD89CEC
	public override void WriteUndefined() { }

	// RVA: 0xD89D84
	public override void WriteRaw(string json) { }

	// RVA: 0xD89DB0
	public override void WriteValue(string value) { }

	// RVA: 0xD89418
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0xD89EC4
	public override void WriteValue(int value) { }

	// RVA: 0xD89FB4
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xD8A0A4
	public override void WriteValue(Int64 value) { }

	// RVA: 0xD8A0EC
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xD8A20C
	public override void WriteValue(float value) { }

	// RVA: 0xD8A2CC
	public override void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xD8A4A8
	public override void WriteValue(Double value) { }

	// RVA: 0xD8A568
	public override void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xD8A744
	public override void WriteValue(bool value) { }

	// RVA: 0xD8A850
	public override void WriteValue(Int16 value) { }

	// RVA: 0xD8A898
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xD8A8E0
	public override void WriteValue(Char value) { }

	// RVA: 0xD8AA14
	public override void WriteValue(Byte value) { }

	// RVA: 0xD8AA5C
	public override void WriteValue(SByte value) { }

	// RVA: 0xD8AAA4
	public override void WriteValue(Decimal value) { }

	// RVA: 0xD8AB50
	public override void WriteValue(DateTime value) { }

	// RVA: 0xD8AD60
	private int WriteValueToBuffer(DateTime value) { }

	// RVA: 0xD8AEA4
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xD8B038
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xD8B214
	private int WriteValueToBuffer(DateTimeOffset value) { }

	// RVA: 0xD8B3B8
	public override void WriteValue(Guid value) { }

	// RVA: 0xD8B4CC
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xD8B610
	public override void WriteValue(Uri value) { }

	// RVA: 0xD8B704
	public override void WriteComment(string text) { }

	// RVA: 0xD89E74
	private void EnsureWriteBuffer() { }

	// RVA: 0xD89FFC
	private void WriteIntegerValue(Int64 value) { }

	// RVA: 0xD8A190
	private void WriteIntegerValue(UInt64 value, bool negative) { }

	// RVA: 0xD8B7D0
	private int WriteNumberToBuffer(UInt64 value, bool negative) { }

	// RVA: 0xD89F0C
	private void WriteIntegerValue(int value) { }

	// RVA: 0xD8B9CC
	private void WriteIntegerValue(UInt32 value, bool negative) { }

	// RVA: 0xD8B8E0
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

	// RVA: 0xD8BA48
	internal static State[][] BuildStateArray() { }

	// RVA: 0xD8BC34
	private static void .cctor() { }

	// RVA: 0xD8BF5C
	public bool get_CloseOutput() { }

	// RVA: 0xD8BF64
	public void set_CloseOutput(bool value) { }

	// RVA: 0xD8BF6C
	public bool get_AutoCompleteOnClose() { }

	// RVA: 0xD8BF74
	public void set_AutoCompleteOnClose(bool value) { }

	// RVA: 0xD897D4
	protected internal int get_Top() { }

	// RVA: 0xD8BF84
	public WriteState get_WriteState() { }

	// RVA: 0xD8C038
	internal string get_ContainerPath() { }

	// RVA: 0xD8C0E8
	public string get_Path() { }

	// RVA: 0xD8C218
	public Formatting get_Formatting() { }

	// RVA: 0xD73DA4
	public void set_Formatting(Formatting value) { }

	// RVA: 0xD8C220
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0xD80238
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0xD8C228
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xD802A4
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xD8C230
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0xD8037C
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0xD8C238
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0xD8C23C
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0xD80310
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0xD8C244
	public string get_DateFormatString() { }

	// RVA: 0xD8C24C
	public void set_DateFormatString(string value) { }

	// RVA: 0xD803F0
	public CultureInfo get_Culture() { }

	// RVA: 0xD8C254
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xD88E00
	protected void .ctor() { }

	// RVA: 0xD8C25C
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0xD8C274
	private void Push(JsonContainerType value) { }

	// RVA: 0xD8C40C
	private JsonContainerType Pop() { }

	// RVA: 0xD8BF7C
	private JsonContainerType Peek() { }

	// RVA: 0xD88F98
	public virtual void Close() { }

	// RVA: 0xD8C58C
	public virtual void WriteStartObject() { }

	// RVA: 0xD8C5D0
	public virtual void WriteEndObject() { }

	// RVA: 0xD8C5DC
	public virtual void WriteStartArray() { }

	// RVA: 0xD8C620
	public virtual void WriteEndArray() { }

	// RVA: 0xD8C628
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0xD8C66C
	public virtual void WriteEndConstructor() { }

	// RVA: 0xD8C674
	public virtual void WritePropertyName(string name) { }

	// RVA: 0xD8C6A0
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0xD8C6B0
	public virtual void WriteEnd() { }

	// RVA: 0xD8C7C8
	public void WriteToken(JsonReader reader) { }

	// RVA: 0xD8C848
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	// RVA: 0xD8C8D4
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0xD8D0D0
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0xD8D4A8
	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	// RVA: 0xD8D348
	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	// RVA: 0xD8D570
	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	// RVA: 0xD8D3B4
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0xD8C6B8
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0xD8C504
	private void AutoCompleteAll() { }

	// RVA: 0xD8D5D8
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0xD8D678
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0xD8D744
	private int CalculateLevelsToComplete(JsonContainerType type) { }

	// RVA: 0xD8D8B0
	private void UpdateCurrentState() { }

	// RVA: 0xD8D968
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0xD8D96C
	protected virtual void WriteIndent() { }

	// RVA: 0xD8D970
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0xD8D974
	protected virtual void WriteIndentSpace() { }

	// RVA: 0xD8D978
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0xD8DBA8
	public virtual void WriteNull() { }

	// RVA: 0xD8DBC4
	public virtual void WriteUndefined() { }

	// RVA: 0xD8DBE0
	public virtual void WriteRaw(string json) { }

	// RVA: 0xD8DBE4
	public virtual void WriteRawValue(string json) { }

	// RVA: 0xD8DC38
	public virtual void WriteValue(string value) { }

	// RVA: 0xD8DC54
	public virtual void WriteValue(int value) { }

	// RVA: 0xD8DC70
	public virtual void WriteValue(UInt32 value) { }

	// RVA: 0xD8DC8C
	public virtual void WriteValue(Int64 value) { }

	// RVA: 0xD8DCA8
	public virtual void WriteValue(UInt64 value) { }

	// RVA: 0xD8DCC4
	public virtual void WriteValue(float value) { }

	// RVA: 0xD8DCE0
	public virtual void WriteValue(Double value) { }

	// RVA: 0xD8DCFC
	public virtual void WriteValue(bool value) { }

	// RVA: 0xD8DD18
	public virtual void WriteValue(Int16 value) { }

	// RVA: 0xD8DD34
	public virtual void WriteValue(UInt16 value) { }

	// RVA: 0xD8DD50
	public virtual void WriteValue(Char value) { }

	// RVA: 0xD8DD6C
	public virtual void WriteValue(Byte value) { }

	// RVA: 0xD8DD88
	public virtual void WriteValue(SByte value) { }

	// RVA: 0xD8DDA4
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0xD8DDC0
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0xD8DDDC
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0xD8DDF8
	public virtual void WriteValue(Guid value) { }

	// RVA: 0xD8DE14
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0xD8DE30
	public virtual void WriteValue(System.Nullable<System.Int32> value) { }

	// RVA: 0xD8DF8C
	public virtual void WriteValue(System.Nullable<System.UInt32> value) { }

	// RVA: 0xD8E0E8
	public virtual void WriteValue(System.Nullable<System.Int64> value) { }

	// RVA: 0xD8E244
	public virtual void WriteValue(System.Nullable<System.UInt64> value) { }

	// RVA: 0xD8E3A0
	public virtual void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xD8E4FC
	public virtual void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xD8E658
	public virtual void WriteValue(System.Nullable<System.Boolean> value) { }

	// RVA: 0xD8E7B4
	public virtual void WriteValue(System.Nullable<System.Int16> value) { }

	// RVA: 0xD8E910
	public virtual void WriteValue(System.Nullable<System.UInt16> value) { }

	// RVA: 0xD8EA6C
	public virtual void WriteValue(System.Nullable<System.Char> value) { }

	// RVA: 0xD8EBC8
	public virtual void WriteValue(System.Nullable<System.Byte> value) { }

	// RVA: 0xD8ED24
	public virtual void WriteValue(System.Nullable<System.SByte> value) { }

	// RVA: 0xD8EE80
	public virtual void WriteValue(System.Nullable<System.Decimal> value) { }

	// RVA: 0xD8F018
	public virtual void WriteValue(System.Nullable<System.DateTime> value) { }

	// RVA: 0xD8F174
	public virtual void WriteValue(System.Nullable<System.DateTimeOffset> value) { }

	// RVA: 0xD8F2C8
	public virtual void WriteValue(System.Nullable<System.Guid> value) { }

	// RVA: 0xD8F41C
	public virtual void WriteValue(System.Nullable<System.TimeSpan> value) { }

	// RVA: 0xD8F578
	public virtual void WriteValue(Byte[] value) { }

	// RVA: 0xD8F5A8
	public virtual void WriteValue(Uri value) { }

	// RVA: 0xD89B18
	public virtual void WriteValue(object value) { }

	// RVA: 0xD907B4
	public virtual void WriteComment(string text) { }

	// RVA: 0xD907BC
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD90850
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD8F748
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xD90870
	private static void ResolveConvertibleValue(IConvertible convertible, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xD8F678
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0xD90A48
	protected void SetWriteState(JsonToken token, object value) { }

	// RVA: 0xD8C5D8
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0xD893EC
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0xD89DAC
	internal void InternalWriteRaw() { }

	// RVA: 0xD890F4
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0xD89B00
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0xD8B7C8
	internal void InternalWriteComment() { }

}

// Namespace: Newtonsoft.Json
[Serializable]
public class JsonWriterException
{
	// Fields
	private readonly string <Path>k__BackingField; // 0x90

	// Methods

	// RVA: 0xD90CD4
	public void .ctor() { }

	// RVA: 0xD90CDC
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD90CE4
	public void .ctor(string message, string path, Exception innerException) { }

	// RVA: 0xD90D1C
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0xD90D54
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

	// RVA: 0xD90E1C
	public void .ctor(TextWriter writer) { }

	// RVA: 0xD90F44
	private void ValidateEncode(Byte[] buffer, int index, int count) { }

	// RVA: 0xD91028
	public void Encode(Byte[] buffer, int index, int count) { }

	// RVA: 0xD9136C
	private void StoreLeftOverBytes(Byte[] buffer, int index, int count) { }

	// RVA: 0xD91280
	private bool FulfillFromLeftover(Byte[] buffer, int index, int count) { }

	// RVA: 0xD91488
	public void Flush() { }

	// RVA: 0xD91344
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

	// RVA: 0x30A2C60
	public void .ctor(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }

	// RVA: 0x315B3A8
	public void Set(TFirst first, TSecond second) { }

	// RVA: 0x315B3A8
	public bool TryGetByFirst(TFirst first, TSecond second) { }

	// RVA: 0x315B3A8
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

	// RVA: 0xD91540
	internal static object Get(bool value) { }

	// RVA: 0xD915DC
	internal static object Get(int value) { }

	// RVA: 0xD91948
	internal static object Get(Int64 value) { }

	// RVA: 0xD91BE8
	internal static object Get(Decimal value) { }

	// RVA: 0xD91CE0
	internal static object Get(Double value) { }

	// RVA: 0xD91E48
	private static void .cctor() { }

}

// Namespace: 
private static class EmptyArrayContainer<T0>
{
	// Fields
	public static readonly T[] Empty; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class CollectionUtils
{
	// Methods

	// RVA: 0x30A3970
	public static bool IsNullOrEmpty(System.Collections.Generic.ICollection<T> collection) { }

	// RVA: 0x30A8E44
	public static void AddRange(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0xD92368
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0xD9267C
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0xD927A0
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	// RVA: 0x30A4874
	public static int IndexOf(System.Collections.Generic.IEnumerable<T> collection, System.Func<T,System.Boolean> predicate) { }

	// RVA: 0x315B3A8
	public static bool Contains(System.Collections.Generic.List<T> list, T value, IEqualityComparer comparer) { }

	// RVA: 0x315B3A8
	public static int IndexOfReference(System.Collections.Generic.List<T> list, T item) { }

	// RVA: 0x30A7C50
	public static void FastReverse(System.Collections.Generic.List<T> list) { }

	// RVA: 0xD92B14
	private static System.Collections.Generic.IList<System.Int32> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0xD92E78
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0xD9315C
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0xD93308
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

	// RVA: 0x30A5298
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

	// RVA: 0x315B3A8
	public virtual void Add(T item) { }

	// RVA: 0x30A2378
	public virtual void Clear() { }

	// RVA: 0x315B3A8
	public virtual bool Contains(T item) { }

	// RVA: 0x30A2828
	public virtual void CopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x30A14A4
	public virtual int get_Count() { }

	// RVA: 0x30A1224
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x315B3A8
	public virtual bool Remove(T item) { }

	// RVA: 0x30A17DC
	public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30A15D4
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x30A1344
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x30A15D4
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x30A24F0
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x30A2658
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x30A1224
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x30A27C0
	private void System.Collections.IList.Remove(object value) { }

	// RVA: -1
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x30A2658
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x30A2828
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x30A1224
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30A17DC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30A7C50
	private static void VerifyValueType(object value) { }

	// RVA: 0x30A3970
	private static bool IsCompatibleObject(object value) { }

	// RVA: 0x30A17DC
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

	// RVA: 0xD93540
	public Type get_Type() { }

	// RVA: 0xD93548
	public PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0xD93550
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

	// RVA: 0xD9400C
	public void .ctor() { }

	// RVA: 0xD984A8
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

	// RVA: 0xD93598
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0xD93608
	public static PrimitiveTypeCode GetTypeCode(Type t, bool isEnum) { }

	// RVA: 0xD93AE4
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0xD93BFC
	public static bool IsConvertible(Type t) { }

	// RVA: 0xD93CB4
	public static TimeSpan ParseTimeSpan(string input) { }

	// RVA: 0xD93D7C
	private static System.Func<System.Object,System.Object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type> t) { }

	// RVA: 0xD94014
	internal static BigInteger ToBigInteger(object value) { }

	// RVA: 0xD94500
	public static object FromBigInteger(BigInteger i, Type targetType) { }

	// RVA: 0xD94A38
	public static object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0xD959B4
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, object value) { }

	// RVA: 0xD94CF0
	private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, object value) { }

	// RVA: 0xD95F50
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0xD95CD8
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0xD95BF4
	public static bool VersionTryParse(string input, Version result) { }

	// RVA: 0xD95B08
	public static bool IsInteger(object value) { }

	// RVA: 0xD96120
	public static ParseResult Int32TryParse(Char[] chars, int start, int length, int value) { }

	// RVA: 0xD962D8
	public static ParseResult Int64TryParse(Char[] chars, int start, int length, Int64 value) { }

	// RVA: 0xD96468
	public static ParseResult DecimalTryParse(Char[] chars, int start, int length, Decimal value) { }

	// RVA: 0xD96F8C
	public static bool TryConvertGuid(string s, Guid g) { }

	// RVA: 0xD96FEC
	public static bool TryHexTextToInt(Char[] text, int start, int end, int value) { }

	// RVA: 0xD970C8
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

	// RVA: 0xD98580
	private static void .cctor() { }

	// RVA: 0xD98810
	public bool Parse(Char[] text, int startIndex, int length) { }

	// RVA: 0xD98A10
	private bool ParseDate(int start) { }

	// RVA: 0xD98D10
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0xD98F88
	private bool ParseTime(int start) { }

	// RVA: 0xD99594
	private bool ParseZone(int start) { }

	// RVA: 0xD98DD4
	private bool Parse4Digit(int start, int num) { }

	// RVA: 0xD98ED8
	private bool Parse2Digit(int start, int num) { }

	// RVA: 0xD98CBC
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

	// RVA: 0xD998DC
	private static void .cctor() { }

	// RVA: 0xD999E0
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0xD99A6C
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0xD99BEC
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0xD99D88
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xD99EA0
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0xD99FB4
	private static Int64 ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0xD9A130
	private static Int64 ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0xD9A2F8
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0xD9A44C
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0xD9A4D4
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0xD9A3C4
	private static Int64 UniversalTicksToJavaScriptTicks(Int64 universalTicks) { }

	// RVA: 0xD9A61C
	internal static DateTime ConvertJavaScriptTicksToDateTime(Int64 javaScriptTicks) { }

	// RVA: 0xD9A6AC
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, DateTime dt) { }

	// RVA: 0xD9ACFC
	internal static bool TryParseDateTimeOffsetIso(StringReference text, DateTimeOffset dt) { }

	// RVA: 0xD9ABF8
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0xD9AFD8
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xD9B70C
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xD9BA2C
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xD9BF74
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xD9C2E0
	private static bool TryParseMicrosoftDate(StringReference text, Int64 ticks, TimeSpan offset, DateTimeKind kind) { }

	// RVA: 0xD9B424
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, DateTime dt) { }

	// RVA: 0xD9B61C
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xD9BCE0
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, DateTimeOffset dt) { }

	// RVA: 0xD9BEB4
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xD9C580
	private static bool TryReadOffset(StringReference offsetText, int startIndex, TimeSpan offset) { }

	// RVA: 0xD9C724
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0xD9C8B4
	internal static int WriteDateTimeString(Char[] chars, int start, DateTime value, System.Nullable<System.TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0xD9D1CC
	internal static int WriteDefaultIsoDate(Char[] chars, int start, DateTime dt) { }

	// RVA: 0xD9D9E8
	private static void CopyIntToCharArray(Char[] chars, int start, int value, int digits) { }

	// RVA: 0xD9CF00
	internal static int WriteDateTimeOffset(Char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0xD9DA54
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0xD9D78C
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

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }

	// RVA: -1
	public DictionaryEntry get_Entry() { }

	// RVA: 0x30A17DC
	public object get_Key() { }

	// RVA: 0x30A17DC
	public object get_Value() { }

	// RVA: 0x30A17DC
	public object get_Current() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
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

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A17DC
	internal System.Collections.Generic.IDictionary<TKey,TValue> get_GenericDictionary() { }

	// RVA: 0x315B3A8
	public void Add(TKey key, TValue value) { }

	// RVA: 0x315B3A8
	public bool ContainsKey(TKey key) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.ICollection<TKey> get_Keys() { }

	// RVA: 0x315B3A8
	public bool Remove(TKey key) { }

	// RVA: 0x315B3A8
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.ICollection<TValue> get_Values() { }

	// RVA: 0x315B3A8
	public TValue get_Item(TKey key) { }

	// RVA: 0x315B3A8
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x315B3A8
	public void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x315B3A8
	public bool Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30A2828
	public void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A1224
	public bool get_IsReadOnly() { }

	// RVA: 0x315B3A8
	public bool Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30A2A20
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x30A188C
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x30A2A20
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x30A17DC
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x30A1344
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x30A1224
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x30A17DC
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x30A27C0
	public void Remove(object key) { }

	// RVA: 0x30A17DC
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x30A2828
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30A1224
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30A17DC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30A17DC
	public object get_UnderlyingDictionary() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class DynamicProxy<T0>
{
	// Methods

	// RVA: 0x315B3A8
	public virtual System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(T instance) { }

	// RVA: 0x315B3A8
	public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, object result) { }

	// RVA: 0x315B3A8
	public virtual bool TryConvert(T instance, ConvertBinder binder, object result) { }

	// RVA: 0x315B3A8
	public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, object result) { }

	// RVA: 0x315B3A8
	public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes) { }

	// RVA: 0x315B3A8
	public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder) { }

	// RVA: 0x315B3A8
	public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, object result) { }

	// RVA: 0x315B3A8
	public virtual bool TryGetMember(T instance, GetMemberBinder binder, object result) { }

	// RVA: 0x315B3A8
	public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, object result) { }

	// RVA: 0x315B3A8
	public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, object result) { }

	// RVA: 0x315B3A8
	public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value) { }

	// RVA: 0x315B3A8
	public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value) { }

	// RVA: 0x315B3A8
	public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, object result) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
private sealed class Fallback
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x30A188C
	public virtual DynamicMetaObject Invoke(DynamicMetaObject errorSuggestion) { }

}

// Namespace: 
private sealed class GetBinderAdapter
{
	// Methods

	// RVA: 0x30A27C0
	internal void .ctor(InvokeMemberBinder binder) { }

	// RVA: 0x30A1970
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

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
	internal DynamicMetaObject <BindBinaryOperation>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public UnaryOperationBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
	internal DynamicMetaObject <BindDeleteIndex>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public GetMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
	internal DynamicMetaObject <BindSetMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public DeleteMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
	internal DynamicMetaObject <BindDeleteMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public ConvertBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
	internal DynamicMetaObject <BindInvokeMember>b__0(DynamicMetaObject e) { }

	// RVA: 0x30A188C
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
	internal DynamicMetaObject <BindInvoke>b__0(DynamicMetaObject e) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class DynamicProxyMetaObject<T0>
{
	// Fields
	private readonly Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy; // 0x0

	// Methods

	// RVA: 0x315B3A8
	internal void .ctor(Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy) { }

	// RVA: 0x30A1344
	private bool IsOverridden(string method) { }

	// RVA: 0x30A188C
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x30A1970
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x30A188C
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x30A188C
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }

	// RVA: 0x30A1970
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x30A1970
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x30A1970
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x30A1970
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	// RVA: 0x30A188C
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	// RVA: 0x30A1970
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x30A19E0
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: 0x30A1970
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x30A5298
	private static Expression[] get_NoArgs() { }

	// RVA: 0x30A52D0
	private static System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(DynamicMetaObject[] args) { }

	// RVA: 0x30A52D0
	private static Expression[] GetArgArray(DynamicMetaObject[] args) { }

	// RVA: 0x30A53B0
	private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value) { }

	// RVA: 0x30A52D0
	private static ConstantExpression Constant(DynamicMetaObjectBinder binder) { }

	// RVA: 0x30A1AC4
	private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Fallback fallback, Fallback fallbackInvoke) { }

	// RVA: 0x30A1AC4
	private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, DynamicMetaObject fallbackResult, Fallback fallbackInvoke) { }

	// RVA: 0x30A1A54
	private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Fallback fallback) { }

	// RVA: 0x30A1A54
	private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Fallback fallback) { }

	// RVA: 0x30A17DC
	private BindingRestrictions GetRestrictions() { }

	// RVA: 0x30A17DC
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

	// RVA: 0xD9DD74
	private static void Init() { }

	// RVA: 0xD9DF70
	private static object CreateSharpArgumentInfoArray(int[] values) { }

	// RVA: 0xD9E280
	private static void CreateMemberCalls() { }

	// RVA: 0xD9E7B8
	public static CallSiteBinder GetMember(string name, Type context) { }

	// RVA: 0xD9E9D0
	public static CallSiteBinder SetMember(string name, Type context) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class DynamicUtils
{
	// Methods

	// RVA: 0xD9DC50
	public static System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowGetBinderMember
{
	// Fields
	private readonly GetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0xD9EBE8
	public void .ctor(GetMemberBinder innerBinder) { }

	// RVA: 0xD9EC2C
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowSetBinderMember
{
	// Fields
	private readonly SetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0xD9EDC4
	public void .ctor(SetMemberBinder innerBinder) { }

	// RVA: 0xD9EE08
	public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowExpressionVisitor
{
	// Fields
	internal static readonly object ErrorResult; // 0x0

	// Methods

	// RVA: 0xD9EF60
	protected override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0xD9EDBC
	public void .ctor() { }

	// RVA: 0xD9F058
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

	// RVA: 0xD9F0E0
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

	// RVA: 0xDA0B9C
	private static void .cctor() { }

	// RVA: 0xDA0C08
	public void .ctor() { }

	// RVA: 0xDA0C10
	internal string <InitializeValuesAndNames>b__3_0(EnumMemberAttribute a) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class EnumUtils
{
	// Fields
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum; // 0x0
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x8

	// Methods

	// RVA: 0xD9F154
	private static EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy> key) { }

	// RVA: 0xD9FA8C
	public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, string name) { }

	// RVA: 0xD9FC48
	private static string InternalFlagsFormat(EnumInfo entry, UInt64 result) { }

	// RVA: 0xD9FEBC
	public static EnumInfo GetEnumValuesAndNames(Type enumType) { }

	// RVA: 0xD9F6E4
	private static UInt64 ToUInt64(object value) { }

	// RVA: 0xD9FF94
	public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	// RVA: 0xDA094C
	private static System.Nullable<System.Int32> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0xDA084C
	private static System.Nullable<System.Int32> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0xDA0A64
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class FSharpFunction
{
	// Fields
	private readonly object _instance; // 0x10
	private readonly Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _invoker; // 0x18

	// Methods

	// RVA: 0xDA0C2C
	public void .ctor(object instance, Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoker) { }

	// RVA: 0xDA0C7C
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

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal System.Tuple<TKey,TValue> <BuildMapCreator>b__55_1(System.Collections.Generic.KeyValuePair<TKey,TValue> kv) { }

}

// Namespace: 
private sealed class <>c__DisplayClass52_0
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoke; // 0x18

	// Methods

	// RVA: 0xDA1804
	public void .ctor() { }

	// RVA: 0xDA1B80
	internal object <CreateFSharpFuncCall>b__0(object target, object[] args) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0<T0, T1>
{
	// Fields
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> ctorDelegate; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A188C
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

	// RVA: 0xDA0CC0
	private void .ctor(Assembly fsharpCoreAssembly) { }

	// RVA: 0xDA1548
	public static FSharpUtils get_Instance() { }

	// RVA: 0xDA15C4
	private void set_FSharpCoreAssembly(Assembly value) { }

	// RVA: 0xDA15CC
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_IsUnion() { }

	// RVA: 0xDA15D4
	private void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDA15DC
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCases() { }

	// RVA: 0xDA15E4
	private void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDA15EC
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionTagReader() { }

	// RVA: 0xDA15F4
	private void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDA15FC
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionReader() { }

	// RVA: 0xDA1604
	private void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDA160C
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionConstructor() { }

	// RVA: 0xDA1614
	private void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDA161C
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoDeclaringType() { }

	// RVA: 0xDA1624
	private void set_GetUnionCaseInfoDeclaringType(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDA162C
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoName() { }

	// RVA: 0xDA1634
	private void set_GetUnionCaseInfoName(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDA163C
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoTag() { }

	// RVA: 0xDA1644
	private void set_GetUnionCaseInfoTag(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDA164C
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCaseInfoFields() { }

	// RVA: 0xDA1654
	private void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDA165C
	public static void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	// RVA: 0xDA1298
	private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	// RVA: 0xDA1310
	private static Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> CreateFSharpFuncCall(Type type, string methodName) { }

	// RVA: 0xDA180C
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateSeq(Type t) { }

	// RVA: 0xDA1914
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateMap(Type keyType, Type valueType) { }

	// RVA: 0x30A17DC
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> BuildMapCreator() { }

	// RVA: 0xDA1AF8
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

	// RVA: 0xDA2E54
	public void .ctor(string contractTypeName, string createdTypeName, string builderTypeName) { }

	// RVA: 0xDA2EB8
	public string get_ContractTypeName() { }

	// RVA: 0xDA2EC0
	public void set_ContractTypeName(string value) { }

	// RVA: 0xDA2EC8
	public string get_CreatedTypeName() { }

	// RVA: 0xDA2ED0
	public void set_CreatedTypeName(string value) { }

	// RVA: 0xDA2ED8
	public string get_BuilderTypeName() { }

	// RVA: 0xDA2EE0
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

	// RVA: 0xDA2EE8
	private static void .cctor() { }

	// RVA: 0xDA2F54
	public void .ctor() { }

	// RVA: 0xDA2F5C
	internal bool <TryBuildImmutableForArrayContract>b__24_1(MethodInfo m) { }

	// RVA: 0xDA2FEC
	internal bool <TryBuildImmutableForDictionaryContract>b__25_1(MethodInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass24_0
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0xDA2140
	public void .ctor() { }

	// RVA: 0xDA3154
	internal bool <TryBuildImmutableForArrayContract>b__0(ImmutableCollectionTypeInfo d) { }

}

// Namespace: 
private sealed class <>c__DisplayClass25_0
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0xDA26B8
	public void .ctor() { }

	// RVA: 0xDA317C
	internal bool <TryBuildImmutableForDictionaryContract>b__0(ImmutableCollectionTypeInfo d) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ImmutableCollectionsUtils
{
	// Fields
	private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x0
	private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x8

	// Methods

	// RVA: 0xDA1C44
	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, Type createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }

	// RVA: 0xDA216C
	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, Type createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }

	// RVA: 0xDA26C0
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class BufferUtils
{
	// Methods

	// RVA: 0xDA31A4
	public static Char[] RentBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int minSize) { }

	// RVA: 0xDA327C
	public static void ReturnBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] buffer) { }

	// RVA: 0xDA333C
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

	// RVA: 0xDA347C
	private static void .cctor() { }

	// RVA: 0xDA3EF8
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, Char quoteChar) { }

	// RVA: 0xDA3FE4
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	// RVA: 0xDA4090
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, Char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] writeBuffer) { }

	// RVA: 0xDA4990
	public static string ToEscapedJavaScriptString(string value, Char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xDA47B0
	private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xDA4CEC
	public static bool TryGetDateFromConstructorJson(JsonReader reader, DateTime dateTime, string errorMessage) { }

	// RVA: 0xDA5230
	private static bool TryGetDateConstructorValue(JsonReader reader, System.Nullable<System.Int64>& integer, string errorMessage) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class JsonTokenUtils
{
	// Methods

	// RVA: 0xDA5408
	internal static bool IsEndToken(JsonToken token) { }

	// RVA: 0xDA5418
	internal static bool IsStartToken(JsonToken token) { }

	// RVA: 0xDA5428
	internal static bool IsPrimitiveToken(JsonToken token) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public ConstructorInfo c; // 0x10
	public MethodBase method; // 0x18

	// Methods

	// RVA: 0xDA5680
	public void .ctor() { }

	// RVA: 0xDA5704
	internal object <CreateParameterizedConstructor>b__0(object[] a) { }

	// RVA: 0xDA5724
	internal object <CreateParameterizedConstructor>b__1(object[] a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0<T0>
{
	// Fields
	public ConstructorInfo c; // 0x0
	public MethodBase method; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal object <CreateMethodCall>b__0(T o, object[] a) { }

	// RVA: 0x315B3A8
	internal object <CreateMethodCall>b__1(T o, object[] a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0<T0>
{
	// Fields
	public Type type; // 0x0
	public ConstructorInfo constructorInfo; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal T <CreateDefaultConstructor>b__0() { }

	// RVA: 0x315B3A8
	internal T <CreateDefaultConstructor>b__1() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0<T0>
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal object <CreateGet>b__0(T o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0<T0>
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal object <CreateGet>b__0(T o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0<T0>
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal void <CreateSet>b__0(T o, object v) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0<T0>
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal void <CreateSet>b__0(T o, object v) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class LateBoundReflectionDelegateFactory
{
	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x0

	// Methods

	// RVA: 0xDA5440
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0xDA54BC
	public override Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: 0x30A188C
	public override Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(MethodBase method) { }

	// RVA: 0x30A188C
	public override System.Func<T> CreateDefaultConstructor(Type type) { }

	// RVA: 0x30A188C
	public override System.Func<T,System.Object> CreateGet(PropertyInfo propertyInfo) { }

	// RVA: 0x30A188C
	public override System.Func<T,System.Object> CreateGet(FieldInfo fieldInfo) { }

	// RVA: 0x30A188C
	public override System.Action<T,System.Object> CreateSet(FieldInfo fieldInfo) { }

	// RVA: 0x30A188C
	public override System.Action<T,System.Object> CreateSet(PropertyInfo propertyInfo) { }

	// RVA: 0xDA5688
	public void .ctor() { }

	// RVA: 0xDA5698
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class MathUtils
{
	// Methods

	// RVA: 0xDA574C
	public static int IntLength(UInt64 i) { }

	// RVA: 0xDA5914
	public static Char IntToHex(int n) { }

	// RVA: 0xDA5930
	public static bool ApproxEquals(Double d1, Double d2) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class MethodCall<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual TResult Invoke(T target, object[] args) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class MiscellaneousUtils
{
	// Methods

	// RVA: 0xDA59E4
	public static bool ValueEquals(object objA, object objB) { }

	// RVA: 0xD99AF4
	public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	// RVA: 0xDA5DEC
	public static string ToString(object value) { }

	// RVA: 0xDA5EA0
	public static int ByteArrayCompare(Byte[] a1, Byte[] a2) { }

	// RVA: 0xDA5F68
	public static string GetPrefix(string qualifiedName) { }

	// RVA: 0xDA6060
	public static string GetLocalName(string qualifiedName) { }

	// RVA: 0xDA5F94
	public static void GetQualifiedNameParts(string qualifiedName, string prefix, string localName) { }

	// RVA: 0xDA60A4
	internal static RegexOptions GetRegexOptions(string optionsText) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal abstract class ReflectionDelegateFactory
{
	// Methods

	// RVA: 0x30A188C
	public System.Func<T,System.Object> CreateGet(MemberInfo memberInfo) { }

	// RVA: 0x30A188C
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

	// RVA: 0xDA5690
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

	// RVA: 0xDA6158
	public Type get_MemberType() { }

	// RVA: 0xDA6160
	public void set_MemberType(Type value) { }

	// RVA: 0xDA6168
	public System.Func<System.Object,System.Object> get_Getter() { }

	// RVA: 0xDA6170
	public void set_Getter(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDA6178
	public System.Action<System.Object,System.Object> get_Setter() { }

	// RVA: 0xDA6180
	public void set_Setter(System.Action<System.Object,System.Object> value) { }

	// RVA: 0xDA6188
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public System.Func<System.Object> ctor; // 0x10

	// Methods

	// RVA: 0xDA6EF0
	public void .ctor() { }

	// RVA: 0xDA74BC
	internal object <Create>b__0(object[] args) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_1
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10

	// Methods

	// RVA: 0xDA7218
	public void .ctor() { }

	// RVA: 0xDA74F8
	internal object <Create>b__1(object target) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_2
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10

	// Methods

	// RVA: 0xDA7220
	public void .ctor() { }

	// RVA: 0xDA7610
	internal void <Create>b__2(object target, object arg) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ReflectionObject
{
	// Fields
	private readonly Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <Creator>k__BackingField; // 0x10
	private readonly System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDA6190
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_Creator() { }

	// RVA: 0xDA6198
	public System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> get_Members() { }

	// RVA: 0xDA61A0
	private void .ctor(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator) { }

	// RVA: 0xDA6248
	public object GetValue(object target, string member) { }

	// RVA: 0xDA6348
	public void SetValue(object target, string member, object value) { }

	// RVA: 0xDA6444
	public Type GetType(string member) { }

	// RVA: 0xDA6514
	public static ReflectionObject Create(Type t, string[] memberNames) { }

	// RVA: 0xDA6520
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

	// RVA: 0xDABF0C
	private static void .cctor() { }

	// RVA: 0xDABF78
	public void .ctor() { }

	// RVA: 0xDABF80
	internal bool <GetDefaultConstructor>b__11_0(ConstructorInfo c) { }

	// RVA: 0xDABFEC
	internal string <GetFieldsAndProperties>b__31_0(MemberInfo m) { }

	// RVA: 0xDAC014
	internal Type <GetMemberInfoFromType>b__39_0(ParameterInfo p) { }

	// RVA: 0xDAC03C
	internal bool <GetChildPrivateFields>b__41_0(FieldInfo f) { }

}

// Namespace: 
private sealed class <>c__DisplayClass31_0
{
	// Fields
	public MemberInfo memberInfo; // 0x10

	// Methods

	// RVA: 0xDAA7C4
	public void .ctor() { }

	// RVA: 0xDAC058
	internal bool <GetFieldsAndProperties>b__1(MemberInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass44_0
{
	// Fields
	public PropertyInfo subTypeProperty; // 0x10

	// Methods

	// RVA: 0xDABAE8
	public void .ctor() { }

	// RVA: 0xDAC0F8
	internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	// RVA: 0xDAC154
	internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass44_1
{
	// Fields
	public Type subTypePropertyDeclaringType; // 0x10
	public Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xDABAF0
	public void .ctor() { }

	// RVA: 0xDAC240
	internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_0
{
	// Fields
	public string method; // 0x10
	public Type methodDeclaringType; // 0x18

	// Methods

	// RVA: 0xDABC14
	public void .ctor() { }

	// RVA: 0xDAC378
	internal bool <IsMethodOverridden>b__0(MethodInfo info) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ReflectionUtils
{
	// Fields
	public static readonly Type[] EmptyTypes; // 0x0

	// Methods

	// RVA: 0xDA76F0
	private static void .cctor() { }

	// RVA: 0xDA7774
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	// RVA: 0xDA78A0
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0xDA7994
	public static bool IsPublic(PropertyInfo property) { }

	// RVA: 0xD96110
	public static Type GetObjectType(object v) { }

	// RVA: 0xDA7A40
	public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder) { }

	// RVA: 0xDA7B64
	private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder) { }

	// RVA: 0xDA7CAC
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0xDA6DD8
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0xDA7FA4
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0xDA7E40
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0xD95BFC
	public static bool IsNullable(Type t) { }

	// RVA: 0xD939D0
	public static bool IsNullableType(Type t) { }

	// RVA: 0xDA802C
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0xDA80C8
	public static Type EnsureNotByRefType(Type t) { }

	// RVA: 0xDA8128
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0xD92600
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0xDA81DC
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, Type implementingType) { }

	// RVA: 0xDA84B8
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0xDA8534
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, Type implementingType) { }

	// RVA: 0xDA86C4
	private static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, Type implementingType) { }

	// RVA: 0xDA8834
	public static Type GetCollectionItemType(Type type) { }

	// RVA: 0xDA8ABC
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, Type keyType, Type valueType) { }

	// RVA: 0xDA7228
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0xDA8D4C
	public static bool IsByRefLikeType(Type type) { }

	// RVA: 0xDA9354
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0xDA9400
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0xDA9740
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0xDA6F18
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0xDA7080
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0xDA9970
	public static System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0xDAA7CC
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: 0x315B3A8
	public static T GetAttribute(object attributeProvider) { }

	// RVA: 0x315B3A8
	public static T GetAttribute(object attributeProvider, bool inherit) { }

	// RVA: -1
	public static T[] GetAttributes(object attributeProvider, bool inherit) { }

	// RVA: 0xDA8E5C
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0xDAA9C8
	public static Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) { }

	// RVA: 0xDAAC84
	private static System.Nullable<System.Int32> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0xDAAF30
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0xDAA2F0
	public static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0xDAB1C0
	private static void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, Type type, BindingFlags bindingAttr) { }

	// RVA: 0xDAA43C
	public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0xDAB3C0
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0xDAB3D0
	private static void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr) { }

	// RVA: 0xDABAF8
	public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method) { }

	// RVA: 0xDABC1C
	public static object GetDefaultValue(Type type) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StringBuffer
{
	// Fields
	private Char[] _buffer; // 0x10
	private int _position; // 0x18

	// Methods

	// RVA: 0xDAC4A8
	public int get_Position() { }

	// RVA: 0xDAC4B0
	public void set_Position(int value) { }

	// RVA: 0xDAC4B8
	public bool get_IsEmpty() { }

	// RVA: 0xDAC4C8
	public void .ctor(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int initalSize) { }

	// RVA: 0xDAC504
	private void .ctor(Char[] buffer) { }

	// RVA: 0xDAC52C
	public void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char value) { }

	// RVA: 0xDAC6A4
	public void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] buffer, int startIndex, int count) { }

	// RVA: 0xDAC728
	public void Clear(Newtonsoft.Json.IArrayPool<System.Char> bufferPool) { }

	// RVA: 0xDAC5A8
	private void EnsureSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int appendLength) { }

	// RVA: 0xDAC7F8
	public override string ToString() { }

	// RVA: 0xDAC810
	public string ToString(int start, int length) { }

	// RVA: 0xDAC828
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

	// RVA: 0xD9B22C
	public Char get_Item(int i) { }

	// RVA: 0xDAC830
	public Char[] get_Chars() { }

	// RVA: 0xDAC838
	public int get_StartIndex() { }

	// RVA: 0xDAC840
	public int get_Length() { }

	// RVA: 0xD9B9F4
	public void .ctor(Char[] chars, int startIndex, int length) { }

	// RVA: 0xD9B608
	public override string ToString() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class StringReferenceExtensions
{
	// Methods

	// RVA: 0xD9C4E4
	public static int IndexOf(StringReference s, Char c, int startIndex, int length) { }

	// RVA: 0xD9B260
	public static bool StartsWith(StringReference s, string text) { }

	// RVA: 0xD9B340
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }

	// RVA: 0x315B3A8
	internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class StringUtils
{
	// Methods

	// RVA: 0xD9B600
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0xD94440
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	// RVA: 0xD958BC
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	// RVA: 0xDAC8EC
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	// RVA: 0xDACA24
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	// RVA: 0xDAC848
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0xDA4C24
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0xDA48D8
	public static void ToCharAsUnicode(Char c, Char[] buffer) { }

	// RVA: 0x315B3A8
	public static TSource ForgivingCaseSensitiveFind(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.String> valueSelector, string testValue) { }

	// RVA: 0xDACB94
	public static string ToCamelCase(string s) { }

	// RVA: 0xDAD060
	private static Char ToLower(Char c) { }

	// RVA: 0xDAD128
	public static string ToSnakeCase(string s) { }

	// RVA: 0xDAD450
	public static string ToKebabCase(string s) { }

	// RVA: 0xDAD130
	private static string ToSeparatedCase(string s, Char separator) { }

	// RVA: 0xDAD458
	public static bool IsHighSurrogate(Char c) { }

	// RVA: 0xDAD4E0
	public static bool IsLowSurrogate(Char c) { }

	// RVA: 0xDA608C
	public static int IndexOf(string s, Char c) { }

	// RVA: 0xDAD568
	public static bool StartsWith(string source, Char value) { }

	// RVA: 0xDAD5BC
	public static bool EndsWith(string source, Char value) { }

	// RVA: 0xDAAD6C
	public static string Trim(string s, int start, int length) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StructMultiKey<T0, T1>
{
	// Fields
	public readonly T1 Value1; // 0x0
	public readonly T2 Value2; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public void .ctor(T1 v1, T2 v2) { }

	// RVA: 0x30A14A4
	public override int GetHashCode() { }

	// RVA: 0x30A1344
	public override bool Equals(object obj) { }

	// RVA: 0x315B3A8
	public bool Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1,T2> other) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ThreadSafeStore<T0, T1>
{
	// Fields
	private readonly System.Collections.Concurrent.ConcurrentDictionary<TKey,TValue> _concurrentStore; // 0x0
	private readonly System.Func<TKey,TValue> _creator; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(System.Func<TKey,TValue> creator) { }

	// RVA: 0x315B3A8
	public TValue Get(TKey key) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class TypeExtensions
{
	// Methods

	// RVA: 0xDA6EF8
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	// RVA: 0xDAD60C
	public static bool ContainsGenericParameters(Type type) { }

	// RVA: 0xD95EFC
	public static bool IsInterface(Type type) { }

	// RVA: 0xDA211C
	public static bool IsGenericType(Type type) { }

	// RVA: 0xD95F14
	public static bool IsGenericTypeDefinition(Type type) { }

	// RVA: 0xDA8810
	public static Type BaseType(Type type) { }

	// RVA: 0xDA2148
	public static Assembly Assembly(Type type) { }

	// RVA: 0xD939AC
	public static bool IsEnum(Type type) { }

	// RVA: 0xDA86AC
	public static bool IsClass(Type type) { }

	// RVA: 0xDAD630
	public static bool IsSealed(Type type) { }

	// RVA: 0xD95F38
	public static bool IsAbstract(Type type) { }

	// RVA: 0xDAD648
	public static bool IsVisible(Type type) { }

	// RVA: 0xDA7E28
	public static bool IsValueType(Type type) { }

	// RVA: 0xDAD660
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, Type match) { }

	// RVA: 0xDAD814
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	// RVA: 0xDAD838
	public static bool ImplementInterface(Type type, Type interfaceType) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ValidationUtils
{
	// Methods

	// RVA: 0xD90EF4
	public static void ArgumentNotNull(object value, string parameterName) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal static class CachedAttributeGetter<T0>
{
	// Fields
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Object,T> TypeAttributeCache; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public static T GetAttribute(object type) { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class CamelCaseNamingStrategy
{
	// Methods

	// RVA: 0xDADC24
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xDADC60
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xDA0B94
	public void .ctor() { }

	// RVA: 0xDADCA4
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

	// RVA: 0x30A24F0
	public void .ctor(int <>1__state) { }

	// RVA: 0x30A2378
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30A1224
	private bool MoveNext() { }

	// RVA: 0x30A2378
	private void <>m__Finally1() { }

	// RVA: -1
	private System.Collections.Generic.KeyValuePair<System.Object,System.Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
internal class EnumerableDictionaryWrapper<T0, T1>
{
	// Fields
	private readonly System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> _e; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> GetEnumerator() { }

	// RVA: 0x30A17DC
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

	// RVA: 0xDB5FA4
	private static void .cctor() { }

	// RVA: 0xDB6010
	public void .ctor() { }

	// RVA: 0xDB6018
	internal bool <GetSerializableMembers>b__40_0(MemberInfo m) { }

	// RVA: 0xDB60D0
	internal bool <GetSerializableMembers>b__40_1(MemberInfo m) { }

	// RVA: 0xDB6140
	internal System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(Type baseType) { }

	// RVA: 0xDB6224
	internal bool <GetExtensionDataMemberForType>b__44_1(MemberInfo m) { }

	// RVA: 0xDB6618
	internal bool <GetAttributeConstructor>b__47_0(ConstructorInfo c) { }

	// RVA: 0xDB66D4
	internal int <CreateProperties>b__75_0(JsonProperty p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass42_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xDB6808
	public void .ctor() { }

	// RVA: 0xDB6810
	internal string <CreateObjectContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_0
{
	// Fields
	public System.Func<System.Object,System.Object> getExtensionDataDictionary; // 0x10
	public MemberInfo member; // 0x18

	// Methods

	// RVA: 0xDB6834
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

	// RVA: 0xDB683C
	public void .ctor() { }

	// RVA: 0xDB6844
	internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_2
{
	// Fields
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> createEnumerableWrapper; // 0x10
	public Newtonsoft.Json.Serialization.DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xDB6A74
	public void .ctor() { }

	// RVA: 0xDB6A7C
	internal System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> <SetExtensionDataDelegates>b__1(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass62_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xDB6BC4
	public void .ctor() { }

	// RVA: 0xDB6BCC
	internal string <CreateDictionaryContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass67_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xDB6BF0
	public void .ctor() { }

	// RVA: 0xDB6BF8
	internal string <CreateDynamicContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass80_0
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> shouldSerializeCall; // 0x10

	// Methods

	// RVA: 0xDB6C1C
	public void .ctor() { }

	// RVA: 0xDB6C24
	internal bool <CreateShouldSerializeTest>b__0(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass81_0
{
	// Fields
	public System.Func<System.Object,System.Object> specifiedPropertyGet; // 0x10

	// Methods

	// RVA: 0xDB6D7C
	public void .ctor() { }

	// RVA: 0xDB6D84
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

	// RVA: 0xDADCAC
	internal static IContractResolver get_Instance() { }

	// RVA: 0xDADD28
	public BindingFlags get_DefaultMembersSearchFlags() { }

	// RVA: 0xDADD30
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	// RVA: 0xDADD38
	public bool get_SerializeCompilerGeneratedMembers() { }

	// RVA: 0xDADD40
	public bool get_IgnoreSerializableInterface() { }

	// RVA: 0xDADD48
	public bool get_IgnoreSerializableAttribute() { }

	// RVA: 0xDADD50
	public void set_IgnoreSerializableAttribute(bool value) { }

	// RVA: 0xDADD58
	public bool get_IgnoreIsSpecifiedMembers() { }

	// RVA: 0xDADD60
	public bool get_IgnoreShouldSerializeMembers() { }

	// RVA: 0xDADD68
	public NamingStrategy get_NamingStrategy() { }

	// RVA: 0xDADD70
	public void .ctor() { }

	// RVA: 0xDADE84
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0xDADF50
	private static bool FilterMembers(MemberInfo member) { }

	// RVA: 0xDAE0CC
	protected virtual System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0xDAECA8
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0xDAEDBC
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0xDB0C4C
	private static void ThrowUnableToSerializeError(object o, StreamingContext context) { }

	// RVA: 0xDB0070
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0xDB0294
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0xDAF718
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0xDAFCD8
	private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	// RVA: 0xDAFC88
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0xDB0F84
	protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0xDB0ECC
	private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	// RVA: 0xDB1180
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0xDB1DBC
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0xDB1E44
	private System.Func<System.Object> GetDefaultCreator(Type createdType) { }

	// RVA: 0xDAF42C
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0xDB1F08
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0xDB2054
	private void GetCallbackMethodsForType(Type type, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback>& onError) { }

	// RVA: 0xDB317C
	private static bool IsConcurrentOrObservableCollection(Type t) { }

	// RVA: 0xDB2A18
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0xDB2918
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0xDB0CE4
	private System.Collections.Generic.List<System.Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0xDB3310
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0xDB38E0
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0xDB3C48
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0xDB3CC0
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0xDB3D38
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0xDB3FB0
	protected virtual JsonDynamicContract CreateDynamicContract(Type objectType) { }

	// RVA: 0xDB41EC
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0xDB4264
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0xDB4808
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0xDB4A44
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0xDB48D8
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0xDB2B18
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, Type prevAttributeType) { }

	// RVA: 0xDB4BF8
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0xDB4D04
	protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0xDB51D4
	internal virtual DefaultJsonNameTable GetNameTable() { }

	// RVA: 0xDB51DC
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0xDB5244
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0xDB1610
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, bool allowNonPublicAccess) { }

	// RVA: 0xDB546C
	private System.Predicate<System.Object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0xDB56D0
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0xDB5A08
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0xDB5A28
	protected virtual string ResolveExtensionDataName(string extensionDataName) { }

	// RVA: 0xDB5A44
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0xDB5A70
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0xDB5A80
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultNamingStrategy
{
	// Methods

	// RVA: 0xDB6E2C
	protected override string ResolvePropertyName(string name) { }

	// RVA: 0xDB6E34
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class DefaultReferenceResolver
{
	// Fields
	private int _referenceCount; // 0x10

	// Methods

	// RVA: 0xDB6E3C
	private Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> GetMappings(object context) { }

	// RVA: 0xDB7074
	public object ResolveReference(object context, string reference) { }

	// RVA: 0xDB70F4
	public string GetReference(object context, object value) { }

	// RVA: 0xDB71F4
	public void AddReference(object context, string reference, object value) { }

	// RVA: 0xDB7264
	public bool IsReferenced(object context, object value) { }

	// RVA: 0xDB72E0
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultSerializationBinder
{
	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String>,System.Type> _typeCache; // 0x10

	// Methods

	// RVA: 0xDB72E8
	public void .ctor() { }

	// RVA: 0xDB73C4
	private Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }

	// RVA: 0xDB77EC
	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	// RVA: 0xDB7A90
	private Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }

	// RVA: 0xDB7B10
	public override Type BindToType(string assemblyName, string typeName) { }

	// RVA: 0xDB7BE4
	public override void BindToName(Type serializedType, string assemblyName, string typeName) { }

	// RVA: 0xDB7C6C
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

	// RVA: 0xDB7CD4
	internal void .ctor(object originalObject, object member, string path, Exception error) { }

	// RVA: 0xDB7D54
	internal bool get_Traced() { }

	// RVA: 0xDB7D5C
	internal void set_Traced(bool value) { }

	// RVA: 0xDB7D64
	public Exception get_Error() { }

	// RVA: 0xDB7D6C
	public bool get_Handled() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class ErrorEventArgs
{
	// Fields
	private readonly object <CurrentObject>k__BackingField; // 0x10
	private readonly ErrorContext <ErrorContext>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDB7D74
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

	// RVA: 0xDB7E08
	public Type get_CollectionItemType() { }

	// RVA: 0xDB7E10
	public bool get_IsMultidimensionalArray() { }

	// RVA: 0xDB7E18
	internal bool get_IsArray() { }

	// RVA: 0xDB7E20
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0xDB7E28
	internal bool get_CanDeserialize() { }

	// RVA: 0xDB7E30
	private void set_CanDeserialize(bool value) { }

	// RVA: 0xDB7E38
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xDB7F3C
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xDB7F44
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDB7F74
	public bool get_HasParameterizedCreator() { }

	// RVA: 0xDB7F7C
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0xDB7F84
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0xDB8020
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDB93B4
	internal IWrappedCollection CreateWrapper(object list) { }

	// RVA: 0xDB97EC
	internal IList CreateTemporaryCollection() { }

	// RVA: 0xDB91D0
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

	// RVA: 0xDB9A98
	internal JsonContract get_ItemContract() { }

	// RVA: 0xDB9AA0
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0xDB9B0C
	internal JsonContract get_FinalItemContract() { }

	// RVA: 0xDB9B14
	public JsonConverter get_ItemConverter() { }

	// RVA: 0xDB9B1C
	public void set_ItemConverter(JsonConverter value) { }

	// RVA: 0xDB9B24
	public System.Nullable<System.Boolean> get_ItemIsReference() { }

	// RVA: 0xDB9B2C
	public void set_ItemIsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDB9B34
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	// RVA: 0xDB9B3C
	public void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xDB9B44
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }

	// RVA: 0xDB9B4C
	public void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xDB8FD4
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

	// RVA: 0xDB9CE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDB9E04
	public virtual void Invoke(object o, StreamingContext context) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationErrorCallback
{
	// Methods

	// RVA: 0xDB9E18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDB9F3C
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataSetter
{
	// Methods

	// RVA: 0xDB9F50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDBA074
	public virtual void Invoke(object o, string key, object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataGetter
{
	// Methods

	// RVA: 0xDBA088
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDBA1A8
	public virtual System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> Invoke(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass57_0
{
	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0xDBAFB0
	public void .ctor() { }

	// RVA: 0xDBB07C
	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

}

// Namespace: 
private sealed class <>c__DisplayClass58_0
{
	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0xDBB074
	public void .ctor() { }

	// RVA: 0xDBB188
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

	// RVA: 0xDBA1BC
	public Type get_UnderlyingType() { }

	// RVA: 0xDBA1C4
	public Type get_CreatedType() { }

	// RVA: 0xDB9110
	public void set_CreatedType(Type value) { }

	// RVA: 0xDBA1CC
	public System.Nullable<System.Boolean> get_IsReference() { }

	// RVA: 0xDBA1D4
	public void set_IsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDBA1DC
	public JsonConverter get_Converter() { }

	// RVA: 0xDBA1E4
	public void set_Converter(JsonConverter value) { }

	// RVA: 0xDBA1EC
	public JsonConverter get_InternalConverter() { }

	// RVA: 0xDBA1F4
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0xDBA1FC
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0xDBA298
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0xDBA334
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0xDBA3D0
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0xDBA46C
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks() { }

	// RVA: 0xDBA508
	public System.Func<System.Object> get_DefaultCreator() { }

	// RVA: 0xDBA510
	public void set_DefaultCreator(System.Func<System.Object> value) { }

	// RVA: 0xDBA518
	public bool get_DefaultCreatorNonPublic() { }

	// RVA: 0xDBA520
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0xDB9B54
	internal void .ctor(Type underlyingType) { }

	// RVA: 0xDBA528
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0xDBA71C
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0xDBA910
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0xDBAB04
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0xDBACF8
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0xDBAEF4
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0xDBAFB8
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

	// RVA: 0xDBB2CC
	public System.Func<System.String,System.String> get_DictionaryKeyResolver() { }

	// RVA: 0xDBB2D4
	public void set_DictionaryKeyResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xDBB2DC
	public Type get_DictionaryKeyType() { }

	// RVA: 0xDBB2E4
	public Type get_DictionaryValueType() { }

	// RVA: 0xDBB2EC
	internal JsonContract get_KeyContract() { }

	// RVA: 0xDBB2F4
	internal void set_KeyContract(JsonContract value) { }

	// RVA: 0xDBB2FC
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0xDBB304
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xDBB408
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xDBB410
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDBB420
	public bool get_HasParameterizedCreator() { }

	// RVA: 0xDBB428
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0xDBB430
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0xDBB4CC
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDBC068
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	// RVA: 0xDBC340
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

	// RVA: 0xDBC624
	public JsonPropertyCollection get_Properties() { }

	// RVA: 0xDBC62C
	public System.Func<System.String,System.String> get_PropertyNameResolver() { }

	// RVA: 0xDBC634
	public void set_PropertyNameResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xDBC63C
	private static System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>> CreateCallSiteGetter(string name) { }

	// RVA: 0xDBC768
	private static System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>> CreateCallSiteSetter(string name) { }

	// RVA: 0xDBC894
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDBCC18
	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }

	// RVA: 0xDBCD38
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

	// RVA: 0xDBCE48
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x315B3A8
	private T GetTokenValue(object value) { }

	// RVA: 0xDBCF1C
	public object Convert(object value, Type type) { }

	// RVA: 0xDBD220
	public bool ToBoolean(object value) { }

	// RVA: 0xDBD290
	public int ToInt32(object value) { }

	// RVA: 0xDBD300
	public Int64 ToInt64(object value) { }

	// RVA: 0xDBD370
	public float ToSingle(object value) { }

	// RVA: 0xDBD3E0
	public string ToString(object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonISerializableContract
{
	// Fields
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <ISerializableCreator>k__BackingField; // 0xC0

	// Methods

	// RVA: 0xDBD450
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ISerializableCreator() { }

	// RVA: 0xDBD458
	public void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDBD460
	public void .ctor(Type underlyingType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonLinqContract
{
	// Methods

	// RVA: 0xDBD488
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

	// RVA: 0xDBD4B0
	public MemberSerialization get_MemberSerialization() { }

	// RVA: 0xDBD4B8
	public void set_MemberSerialization(MemberSerialization value) { }

	// RVA: 0xDBD4C0
	public System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling() { }

	// RVA: 0xDBD4C8
	public void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value) { }

	// RVA: 0xDBD4D0
	public System.Nullable<Newtonsoft.Json.Required> get_ItemRequired() { }

	// RVA: 0xDBD4D8
	public void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value) { }

	// RVA: 0xDBD4E0
	public System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling() { }

	// RVA: 0xDBD4E8
	public void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }

	// RVA: 0xDBD4F0
	public JsonPropertyCollection get_Properties() { }

	// RVA: 0xDBD4F8
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0xDBD594
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xDBD59C
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDBD5AC
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xDBD5B4
	internal void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDBD5C4
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	// RVA: 0xDBD5CC
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	// RVA: 0xDBD5D4
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	// RVA: 0xDBD5DC
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0xDBD5E4
	public void set_ExtensionDataValueType(Type value) { }

	// RVA: 0xDBD6E4
	public System.Func<System.String,System.String> get_ExtensionDataNameResolver() { }

	// RVA: 0xDBD6EC
	public void set_ExtensionDataNameResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xDBD6F4
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	// RVA: 0xDBDEBC
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDBDF44
	internal object GetUninitializedObject() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonPrimitiveContract
{
	// Fields
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x8C
	private static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.ReadType> ReadTypeMap; // 0x0

	// Methods

	// RVA: 0xDBE084
	internal PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0xDBE08C
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0xDBE094
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDBE194
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

	// RVA: 0xDBE55C
	internal JsonContract get_PropertyContract() { }

	// RVA: 0xDBE564
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0xDBE56C
	public string get_PropertyName() { }

	// RVA: 0xDBE574
	public void set_PropertyName(string value) { }

	// RVA: 0xDBE60C
	public Type get_DeclaringType() { }

	// RVA: 0xDBE614
	public void set_DeclaringType(Type value) { }

	// RVA: 0xDBE61C
	public System.Nullable<System.Int32> get_Order() { }

	// RVA: 0xDBE624
	public void set_Order(System.Nullable<System.Int32> value) { }

	// RVA: 0xDBE62C
	public string get_UnderlyingName() { }

	// RVA: 0xDBE634
	public void set_UnderlyingName(string value) { }

	// RVA: 0xDBE63C
	public IValueProvider get_ValueProvider() { }

	// RVA: 0xDBE644
	public void set_ValueProvider(IValueProvider value) { }

	// RVA: 0xDBE64C
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0xDBE654
	public Type get_PropertyType() { }

	// RVA: 0xDBE65C
	public void set_PropertyType(Type value) { }

	// RVA: 0xDBE730
	public JsonConverter get_Converter() { }

	// RVA: 0xDBE738
	public void set_Converter(JsonConverter value) { }

	// RVA: 0xDBE740
	public bool get_Ignored() { }

	// RVA: 0xDBE748
	public void set_Ignored(bool value) { }

	// RVA: 0xDBE750
	public bool get_Readable() { }

	// RVA: 0xDBE758
	public void set_Readable(bool value) { }

	// RVA: 0xDBE760
	public bool get_Writable() { }

	// RVA: 0xDBE768
	public void set_Writable(bool value) { }

	// RVA: 0xDBE770
	public bool get_HasMemberAttribute() { }

	// RVA: 0xDBE778
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0xDBE780
	public object get_DefaultValue() { }

	// RVA: 0xDBE798
	public void set_DefaultValue(object value) { }

	// RVA: 0xDBE7A8
	internal object GetResolvedDefaultValue() { }

	// RVA: 0xDBDDE4
	public Required get_Required() { }

	// RVA: 0xDBE888
	public System.Nullable<System.Boolean> get_IsReference() { }

	// RVA: 0xDBE890
	public void set_IsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDBE898
	public System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling() { }

	// RVA: 0xDBE8A0
	public void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }

	// RVA: 0xDBE8A8
	public System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling() { }

	// RVA: 0xDBE8B0
	public void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value) { }

	// RVA: 0xDBE8B8
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	// RVA: 0xDBE8C0
	public void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xDBE8C8
	public System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling() { }

	// RVA: 0xDBE8D0
	public void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value) { }

	// RVA: 0xDBE8D8
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling() { }

	// RVA: 0xDBE8E0
	public void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xDBE8E8
	public System.Predicate<System.Object> get_ShouldSerialize() { }

	// RVA: 0xDBE8F0
	public void set_ShouldSerialize(System.Predicate<System.Object> value) { }

	// RVA: 0xDBE8F8
	public System.Predicate<System.Object> get_ShouldDeserialize() { }

	// RVA: 0xDBE900
	public System.Predicate<System.Object> get_GetIsSpecified() { }

	// RVA: 0xDBE908
	public void set_GetIsSpecified(System.Predicate<System.Object> value) { }

	// RVA: 0xDBE910
	public System.Action<System.Object,System.Object> get_SetIsSpecified() { }

	// RVA: 0xDBE918
	public void set_SetIsSpecified(System.Action<System.Object,System.Object> value) { }

	// RVA: 0xDBE920
	public override string ToString() { }

	// RVA: 0xDBE98C
	public JsonConverter get_ItemConverter() { }

	// RVA: 0xDBE994
	public void set_ItemConverter(JsonConverter value) { }

	// RVA: 0xDBE99C
	public System.Nullable<System.Boolean> get_ItemIsReference() { }

	// RVA: 0xDBE9A4
	public void set_ItemIsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDBE9AC
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }

	// RVA: 0xDBE9B4
	public void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xDBE9BC
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	// RVA: 0xDBE9C4
	public void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xDBE9CC
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0xDBEA24
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonPropertyCollection
{
	// Fields
	private readonly Type _type; // 0x30
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list; // 0x38

	// Methods

	// RVA: 0xDBCA5C
	public void .ctor(Type type) { }

	// RVA: 0xDBEA2C
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0xDBEA48
	public void AddProperty(JsonProperty property) { }

	// RVA: 0xDBED28
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0xDBEEC4
	private bool TryGetProperty(string key, JsonProperty item) { }

	// RVA: 0xDBEDC8
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

}

// Namespace: 
private class ReferenceEqualsEqualityComparer
{
	// Methods

	// RVA: 0xDBF87C
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	// RVA: 0xDBF888
	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	// RVA: 0xDBF050
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

	// RVA: 0xDBEFB0
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0xDB6F4C
	internal Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> get_DefaultReferenceMappings() { }

	// RVA: 0xDBF058
	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0xDBF29C
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0xDBF3CC
	protected void ClearErrorContext() { }

	// RVA: 0xDBF43C
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

	// RVA: 0xDCD3BC
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

	// RVA: 0xDCE038
	private static void .cctor() { }

	// RVA: 0xDCE0A4
	public void .ctor() { }

	// RVA: 0xDCE0AC
	internal string <CreateObjectUsingCreatorWithParameters>b__38_0(JsonProperty p) { }

	// RVA: 0xDCE0C8
	internal string <CreateObjectUsingCreatorWithParameters>b__38_2(JsonProperty p) { }

	// RVA: 0xDCE0E4
	internal JsonProperty <PopulateObject>b__42_0(JsonProperty m) { }

	// RVA: 0xDCE0EC
	internal PropertyPresence <PopulateObject>b__42_1(JsonProperty m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass38_0
{
	// Fields
	public JsonProperty property; // 0x10

	// Methods

	// RVA: 0xDCD3B4
	public void .ctor() { }

	// RVA: 0xDCE0F4
	internal bool <CreateObjectUsingCreatorWithParameters>b__1(CreatorPropertyContext p) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class JsonSerializerInternalReader
{
	// Methods

	// RVA: 0xDBF894
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0xDBF898
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xDC23D8
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0xDC2488
	private JsonContract GetContract(Type type) { }

	// RVA: 0xDC2544
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0xDC33CC
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0xDC346C
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0xDC386C
	private JToken CreateJObject(JsonReader reader) { }

	// RVA: 0xDC2E64
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0xDC54EC
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0xDC5640
	internal string GetExpectedDescription(JsonContract contract) { }

	// RVA: 0xDC2944
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDC3CF4
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0xDC56FC
	private bool ReadMetadataPropertiesToken(JTokenReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, object newValue, string id) { }

	// RVA: 0xDC5E64
	private bool ReadMetadataProperties(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, object newValue, string id) { }

	// RVA: 0xDC7B94
	private void ResolveTypeName(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0xDC8434
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	// RVA: 0xDC46F8
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	// RVA: 0xDC645C
	private bool HasNoDefinedType(JsonContract contract) { }

	// RVA: 0xDC4ED8
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0xDC90D0
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	// RVA: 0xDC95D0
	private bool CalculatePropertyDetails(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, bool useExistingValue, object currentValue, JsonContract propertyContract, bool gottenCurrentValue, bool ignoredValue) { }

	// RVA: 0xDC9DAC
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0xDC9DA0
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xDC9C68
	private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	// RVA: 0xDC85B8
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, bool createdFromNonDefaultCreator) { }

	// RVA: 0xDC6840
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, bool createdFromNonDefaultCreator) { }

	// RVA: 0xDCA18C
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0xDCA3C8
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0xDC0494
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xDC8900
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xDCA604
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0xDBFDEC
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xDC7438
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0xDBD040
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0xDC6B2C
	private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	// RVA: 0xDCA79C
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator, string id) { }

	// RVA: 0xDC29D4
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0xDCC974
	private System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0xDC655C
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, bool createdFromNonDefaultCreator) { }

	// RVA: 0xDC116C
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0xDCDCAC
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0xDC3BC8
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0xDCDAA0
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0xDCD9D4
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0xDCD3F0
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0xDCDF20
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0xDC3300
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

	// RVA: 0xDCE11C
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0xDCE1B4
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xDCF138
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0xDCE48C
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0xDCF1D8
	private JsonContract GetContract(object value) { }

	// RVA: 0xDCF2A8
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDCE9A4
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDD29D4
	private System.Nullable<System.Boolean> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDCE49C
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDD2B20
	private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0xDD2C28
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDCE714
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0xDD30D0
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0xDD32CC
	internal static bool TryConvertToString(object value, Type type, string s) { }

	// RVA: 0xDD13C4
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0xDD3418
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0xDD3634
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0xDD0090
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDD3A40
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, JsonContract memberContract, object memberValue) { }

	// RVA: 0xDD3850
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDD4938
	private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	// RVA: 0xDD4A70
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0xDCF8A4
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0xDD2C1C
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xDD2B14
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0xDD4CC8
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0xDCFB30
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDD0B48
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDD11D8
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDD5084
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0xDD4CD4
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDD257C
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDD1D1C
	private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDD541C
	private bool ShouldWriteDynamicProperty(object memberValue) { }

	// RVA: 0xDCF420
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDD1454
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDD3EF8
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, bool escape) { }

	// RVA: 0xDCF068
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0xDD4458
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0xDD46C8
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

	// RVA: 0xDD54EC
	public override void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDD5510
	public override void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDD5534
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xDD5558
	public override ITraceWriter get_TraceWriter() { }

	// RVA: 0xDD557C
	public override void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0xDD55A0
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xDD55C4
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0xDD55EC
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0xDD5614
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0xDD563C
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xDD5664
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xDD568C
	public override NullValueHandling get_NullValueHandling() { }

	// RVA: 0xDD56B4
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xDD56DC
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xDD5704
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xDD572C
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xDD5754
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xDD5778
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xDD57A0
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xDD57C8
	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0xDD57EC
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0xDD5814
	public override void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0xDD5838
	public override StreamingContext get_Context() { }

	// RVA: 0xDD5860
	public override void set_Context(StreamingContext value) { }

	// RVA: 0xDD5888
	public override Formatting get_Formatting() { }

	// RVA: 0xDD58B0
	public override System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xDD58D8
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0xDD5900
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xDD5928
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0xDD5944
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0xDD59D4
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	// RVA: 0xDD5A64
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xDD5AA0
	internal override void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0xDD5AD8
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonStringContract
{
	// Methods

	// RVA: 0xDD5B10
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

	// RVA: 0xDD734C
	private static void .cctor() { }

	// RVA: 0xDD73B8
	public void .ctor() { }

	// RVA: 0xDD73C0
	internal Type <GetCreator>b__22_1(object param) { }

}

// Namespace: 
private sealed class <>c__DisplayClass22_0
{
	// Fields
	public Type type; // 0x10
	public System.Func<System.Object> defaultConstructor; // 0x18

	// Methods

	// RVA: 0xDD6AE0
	public void .ctor() { }

	// RVA: 0xDD7424
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

	// RVA: 0x315B3A8
	public static T GetCachedAttribute(object attributeProvider) { }

	// RVA: 0xDD5B88
	public static bool CanTypeDescriptorConvertString(Type type, TypeConverter typeConverter) { }

	// RVA: 0xDD5D88
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0xDD5E94
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0xDD6190
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0xDD63D8
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0xDD6554
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] args) { }

	// RVA: 0xDD667C
	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[] args) { }

	// RVA: 0xDD67A4
	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	// RVA: 0xDD688C
	private static System.Func<System.Object[],System.Object> GetCreator(Type type) { }

	// RVA: 0xDD6BAC
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0xDD6C64
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: 0x315B3A8
	private static T GetAttribute(Type type) { }

	// RVA: 0x315B3A8
	private static T GetAttribute(MemberInfo memberInfo) { }

	// RVA: 0xDD6F08
	public static bool IsNonSerializable(object provider) { }

	// RVA: 0xDD6350
	public static bool IsSerializable(object provider) { }

	// RVA: 0x315B3A8
	public static T GetAttribute(object provider) { }

	// RVA: 0xDD6F90
	public static bool get_FullyTrusted() { }

	// RVA: 0xDD6AE8
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0xDD71C0
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class KebabCaseNamingStrategy
{
	// Methods

	// RVA: 0xDD7934
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xDD7978
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xDD79BC
	public void .ctor() { }

	// RVA: 0xDD79C4
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

	// RVA: 0xDD79D0
	public bool get_ProcessDictionaryKeys() { }

	// RVA: 0xDD79D8
	public void set_ProcessDictionaryKeys(bool value) { }

	// RVA: 0xDD79E0
	public bool get_ProcessExtensionDataNames() { }

	// RVA: 0xDD79E8
	public void set_ProcessExtensionDataNames(bool value) { }

	// RVA: 0xDD79F0
	public bool get_OverrideSpecifiedNames() { }

	// RVA: 0xDD79F8
	public void set_OverrideSpecifiedNames(bool value) { }

	// RVA: 0xDD7A00
	public virtual string GetPropertyName(string name, bool hasSpecifiedName) { }

	// RVA: 0xDD7A20
	public virtual string GetExtensionDataName(string name) { }

	// RVA: 0xDD7A3C
	public virtual string GetDictionaryKey(string key) { }

	// RVA: -1
	protected abstract string ResolvePropertyName(string name) { }

	// RVA: 0xDD7A58
	public override int GetHashCode() { }

	// RVA: 0xDD7B40
	public override bool Equals(object obj) { }

	// RVA: 0xDD7BDC
	protected bool Equals(NamingStrategy other) { }

	// RVA: 0xDD7970
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ObjectConstructor<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x30A188C
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

	// RVA: 0xDD7D18
	public void .ctor(object attributeProvider) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class ReflectionValueProvider
{
	// Fields
	private readonly MemberInfo _memberInfo; // 0x10

	// Methods

	// RVA: 0xDD7D90
	public void .ctor(MemberInfo memberInfo) { }

	// RVA: 0xDD7E08
	public void SetValue(object target, object value) { }

	// RVA: 0xDD7FB4
	public object GetValue(object target) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class SnakeCaseNamingStrategy
{
	// Methods

	// RVA: 0xDD8274
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xDD82B0
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xDD82F4
	public void .ctor() { }

	// RVA: 0xDD82FC
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

	// RVA: 0xDD8308
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0xDD8478
	public string GetDeserializedJsonMessage() { }

	// RVA: 0xDD849C
	public override bool Read() { }

	// RVA: 0xDD853C
	public override System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xDD85A0
	public override string ReadAsString() { }

	// RVA: 0xDD8604
	public override Byte[] ReadAsBytes() { }

	// RVA: 0xDD866C
	public override System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xDD8718
	public override System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xDD8790
	public override System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xDD87F8
	public override System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xDD8870
	public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xDD8500
	public void WriteCurrentToken() { }

	// RVA: 0xDD88F0
	public override int get_Depth() { }

	// RVA: 0xDD8914
	public override string get_Path() { }

	// RVA: 0xDD8938
	public override JsonToken get_TokenType() { }

	// RVA: 0xDD895C
	public override object get_Value() { }

	// RVA: 0xDD8980
	public override Type get_ValueType() { }

	// RVA: 0xDD89A4
	public override void Close() { }

	// RVA: 0xDD89CC
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xDD8AA4
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xDD8B80
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

	// RVA: 0xDD8C5C
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0xDD8E68
	public string GetSerializedJsonMessage() { }

	// RVA: 0xDD8E8C
	public override void WriteValue(Decimal value) { }

	// RVA: 0xDD8F04
	public override void WriteValue(System.Nullable<System.Decimal> value) { }

	// RVA: 0xDD90C8
	public override void WriteValue(bool value) { }

	// RVA: 0xDD912C
	public override void WriteValue(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDD92BC
	public override void WriteValue(Byte value) { }

	// RVA: 0xDD9320
	public override void WriteValue(System.Nullable<System.Byte> value) { }

	// RVA: 0xDD94B0
	public override void WriteValue(Char value) { }

	// RVA: 0xDD9514
	public override void WriteValue(System.Nullable<System.Char> value) { }

	// RVA: 0xDD96A4
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xDD971C
	public override void WriteValue(DateTime value) { }

	// RVA: 0xDD9780
	public override void WriteValue(System.Nullable<System.DateTime> value) { }

	// RVA: 0xDD9918
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xDD9990
	public override void WriteValue(System.Nullable<System.DateTimeOffset> value) { }

	// RVA: 0xDD9B38
	public override void WriteValue(Double value) { }

	// RVA: 0xDD9BA4
	public override void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xDD9D3C
	public override void WriteUndefined() { }

	// RVA: 0xDD9D94
	public override void WriteNull() { }

	// RVA: 0xDD9DEC
	public override void WriteValue(float value) { }

	// RVA: 0xDD9E58
	public override void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xDD9FE4
	public override void WriteValue(Guid value) { }

	// RVA: 0xDDA05C
	public override void WriteValue(System.Nullable<System.Guid> value) { }

	// RVA: 0xDDA204
	public override void WriteValue(int value) { }

	// RVA: 0xDDA268
	public override void WriteValue(System.Nullable<System.Int32> value) { }

	// RVA: 0xDDA3F4
	public override void WriteValue(Int64 value) { }

	// RVA: 0xDDA458
	public override void WriteValue(System.Nullable<System.Int64> value) { }

	// RVA: 0xDDA5F0
	public override void WriteValue(object value) { }

	// RVA: 0xDDA708
	public override void WriteValue(SByte value) { }

	// RVA: 0xDDA76C
	public override void WriteValue(System.Nullable<System.SByte> value) { }

	// RVA: 0xDDA8FC
	public override void WriteValue(Int16 value) { }

	// RVA: 0xDDA960
	public override void WriteValue(System.Nullable<System.Int16> value) { }

	// RVA: 0xDDAAF0
	public override void WriteValue(string value) { }

	// RVA: 0xDDAB54
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xDDABB8
	public override void WriteValue(System.Nullable<System.TimeSpan> value) { }

	// RVA: 0xDDAD50
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xDDADB4
	public override void WriteValue(System.Nullable<System.UInt32> value) { }

	// RVA: 0xDDAF40
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xDDAFA4
	public override void WriteValue(System.Nullable<System.UInt64> value) { }

	// RVA: 0xDDB13C
	public override void WriteValue(Uri value) { }

	// RVA: 0xDDB224
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xDDB288
	public override void WriteValue(System.Nullable<System.UInt16> value) { }

	// RVA: 0xDDB418
	public override void WriteComment(string text) { }

	// RVA: 0xDDB47C
	public override void WriteStartArray() { }

	// RVA: 0xDDB4CC
	public override void WriteEndArray() { }

	// RVA: 0xDDB51C
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xDDB578
	public override void WriteEndConstructor() { }

	// RVA: 0xDDB5C8
	public override void WritePropertyName(string name) { }

	// RVA: 0xDDB62C
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xDDB6A0
	public override void WriteStartObject() { }

	// RVA: 0xDDB6F0
	public override void WriteEndObject() { }

	// RVA: 0xDDB740
	public override void WriteRawValue(string json) { }

	// RVA: 0xDDB7A4
	public override void WriteRaw(string json) { }

	// RVA: 0xDDB808
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

	// RVA: 0xDDB858
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDDB860
	public override JTokenType get_Type() { }

	// RVA: 0xDDB868
	public void .ctor() { }

	// RVA: 0xDDB9D8
	internal void .ctor(JArray other, JsonCloneSettings settings) { }

	// RVA: 0xDDBE20
	public void .ctor(object content) { }

	// RVA: 0xDDBF08
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDDBFE0
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xDDC4E8
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDDC5D4
	public JToken get_Item(int index) { }

	// RVA: 0xDDC5E4
	public void set_Item(int index, JToken value) { }

	// RVA: 0xDDC5F4
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xDDC668
	public int IndexOf(JToken item) { }

	// RVA: 0xDDC678
	public void Insert(int index, JToken item) { }

	// RVA: 0xDDC690
	public void RemoveAt(int index) { }

	// RVA: 0xDDC6A0
	public System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }

	// RVA: 0xDDC73C
	public void Add(JToken item) { }

	// RVA: 0xDDC74C
	public void Clear() { }

	// RVA: 0xDDC75C
	public bool Contains(JToken item) { }

	// RVA: 0xDDC76C
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xDDC77C
	public bool get_IsReadOnly() { }

	// RVA: 0xDDC784
	public bool Remove(JToken item) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JConstructor
{
	// Fields
	private string _name; // 0x58
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values; // 0x60

	// Methods

	// RVA: 0xDDC794
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDDC79C
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xDDC810
	public string get_Name() { }

	// RVA: 0xDDC818
	public override JTokenType get_Type() { }

	// RVA: 0xDDC820
	internal void .ctor(JConstructor other, JsonCloneSettings settings) { }

	// RVA: 0xDDC8D8
	public void .ctor(string name) { }

	// RVA: 0xDDCA84
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDDCAF0
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDDCBE8
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

	// RVA: 0xDDCDE0
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xDDCE94
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: -1
	protected abstract System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDDB950
	internal void .ctor() { }

	// RVA: 0xDDBA78
	internal void .ctor(JContainer other, JsonCloneSettings settings) { }

	// RVA: 0xDDD384
	internal void CheckReentrancy() { }

	// RVA: 0xDDD430
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0xDDD454
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xDDD4E4
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	// RVA: 0xDDD574
	public override bool get_HasValues() { }

	// RVA: 0xDDD638
	public override JToken get_First() { }

	// RVA: 0xDDD79C
	public override JToken get_Last() { }

	// RVA: 0xDDD900
	public override Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }

	// RVA: 0xDDD980
	internal bool IsMultiContent(object content) { }

	// RVA: 0xDDDA7C
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: -1
	internal abstract int IndexOfItem(JToken item) { }

	// RVA: 0xDDDC54
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDDE0BC
	internal virtual void RemoveItemAt(int index) { }

	// RVA: 0xDDE5C0
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0xDDE628
	internal virtual JToken GetItem(int index) { }

	// RVA: 0xDDE6F0
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0xDDEE10
	internal virtual void ClearItems() { }

	// RVA: 0xDDF254
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	// RVA: 0xDDF2BC
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0xDDF2E4
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0xDDED48
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0xDDF878
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xDDF998
	public virtual void Add(object content) { }

	// RVA: 0xDDFA74
	internal bool TryAdd(object content) { }

	// RVA: 0xDDFB50
	internal void AddAndSkipParentCheck(JToken token) { }

	// RVA: 0xDDD004
	internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDDFC2C
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0xDDFDE8
	public void RemoveAll() { }

	// RVA: 0xDDC388
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0xDDFDF8
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	// RVA: 0xDE05DC
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	// RVA: 0xDE0B58
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xDE0BA4
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xDE0D54
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0xDE0D64
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0xDE0D7C
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0xDE0D8C
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0xDE0D9C
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0xDE0DAC
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0xDE0DBC
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0xDE0DCC
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0xDE0DDC
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xDE0DEC
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0xDE0DF4
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	// RVA: 0xDE0E04
	private JToken EnsureValue(object value) { }

	// RVA: 0xDE0EC4
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xDE0FA4
	private void System.Collections.IList.Clear() { }

	// RVA: 0xDE0FB4
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xDE0FEC
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xDE1024
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xDE1078
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xDE1080
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xDE1088
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xDE10C0
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xDE10D0
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xDE10E0
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xDE112C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xDDF7B0
	public int get_Count() { }

	// RVA: 0xDE113C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xDE1144
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xDE11D0
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xDE11D4
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xDE13A0
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xDE13A8
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xDE13B0
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xDE13B8
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xDE13F8
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xDE1438
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xDE1440
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xDE1444
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xDE1484
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xDE148C
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xDE1494
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xDE149C
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xDE14A4
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

}

// Namespace: Newtonsoft.Json.Linq
public struct JEnumerable<T0>
{
	// Fields
	public static readonly Newtonsoft.Json.Linq.JEnumerable<T> Empty; // 0x0
	private readonly System.Collections.Generic.IEnumerable<T> _enumerable; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IEnumerable<T> enumerable) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x315B3A8
	public bool Equals(Newtonsoft.Json.Linq.JEnumerable<T> other) { }

	// RVA: 0x30A1344
	public override bool Equals(object obj) { }

	// RVA: 0x30A14A4
	public override int GetHashCode() { }

	// RVA: 0x30A6D04
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

	// RVA: 0xDE465C
	private static void .cctor() { }

	// RVA: 0xDE46C8
	public void .ctor() { }

	// RVA: 0xDE46D0
	internal string <GetDynamicMemberNames>b__2_0(JProperty p) { }

}

// Namespace: 
private class JObjectDynamicProxy
{
	// Methods

	// RVA: 0xDE4310
	public override bool TryGetMember(JObject instance, GetMemberBinder binder, object result) { }

	// RVA: 0xDE43C0
	public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value) { }

	// RVA: 0xDE4500
	public override System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(JObject instance) { }

	// RVA: 0xDE42BC
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

	// RVA: 0xDE3850
	public void .ctor(int <>1__state) { }

	// RVA: 0xDE46EC
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDE47C0
	private bool MoveNext() { }

	// RVA: 0xDE4B54
	private void <>m__Finally1() { }

	// RVA: 0xDE4C18
	private System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	// RVA: 0xDE4C24
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xDE4C64
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

	// RVA: 0xDE14AC
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDE14B4
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xDE1558
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xDE15FC
	public void add_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0xDE16A0
	public void remove_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0xDE034C
	public void .ctor() { }

	// RVA: 0xDE17E0
	public void .ctor(JObject other) { }

	// RVA: 0xDE18DC
	internal void .ctor(JObject other, JsonCloneSettings settings) { }

	// RVA: 0xDE19DC
	public void .ctor(object[] content) { }

	// RVA: 0xDE19E0
	public void .ctor(object content) { }

	// RVA: 0xDE1B28
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xDE1CA8
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDE1D34
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xDE203C
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0xDE2184
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0xDE21AC
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDE2218
	public override JTokenType get_Type() { }

	// RVA: 0xDE2220
	public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties() { }

	// RVA: 0xDE0818
	public JProperty Property(string name, StringComparison comparison) { }

	// RVA: 0xDE2274
	public JToken get_Item(string propertyName) { }

	// RVA: 0xDE22F8
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0xDE254C
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xDE271C
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDE24C4
	public void Add(string propertyName, JToken value) { }

	// RVA: 0xDE29D8
	public bool ContainsKey(string propertyName) { }

	// RVA: 0xDE2B04
	private System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0xDE2BC0
	public bool Remove(string propertyName) { }

	// RVA: 0xDE2CCC
	public bool TryGetValue(string propertyName, JToken value) { }

	// RVA: 0xDE2D24
	private System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0xDE2D64
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xDE2F20
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0xDE2F30
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xDE30C0
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>[] array, int arrayIndex) { }

	// RVA: 0xDE35EC
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0xDE35F4
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xDE37D8
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>> GetEnumerator() { }

	// RVA: 0xDE387C
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0xDE3910
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0xDE39A4
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xDE3A4C
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xDE3F48
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xDE3FC4
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xDE3FCC
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xDE3FD4
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xDE402C
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xDE4034
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xDE403C
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xDE4044
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xDE40C0
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xDE413C
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xDE41D0
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

	// RVA: 0xDE56D0
	public void .ctor(int <>1__state) { }

	// RVA: 0xDE5958
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDE595C
	private bool MoveNext() { }

	// RVA: 0xDE59D8
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	// RVA: 0xDE59E0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xDE5A20
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private class JPropertyList
{
	// Fields
	internal JToken _token; // 0x10

	// Methods

	// RVA: 0xDE5658
	public System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }

	// RVA: 0xDE56FC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xDE5774
	public void Add(JToken item) { }

	// RVA: 0xDE577C
	public void Clear() { }

	// RVA: 0xDE5788
	public bool Contains(JToken item) { }

	// RVA: 0xDE5798
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xDE581C
	public bool Remove(JToken item) { }

	// RVA: 0xDE586C
	public int get_Count() { }

	// RVA: 0xDE587C
	public bool get_IsReadOnly() { }

	// RVA: 0xDE5144
	public int IndexOf(JToken item) { }

	// RVA: 0xDE5884
	public void Insert(int index, JToken item) { }

	// RVA: 0xDE5898
	public void RemoveAt(int index) { }

	// RVA: 0xDE58AC
	public JToken get_Item(int index) { }

	// RVA: 0xDE5900
	public void set_Item(int index, JToken value) { }

	// RVA: 0xDE4D80
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JProperty
{
	// Fields
	private readonly JPropertyList _content; // 0x58
	private readonly string _name; // 0x60

	// Methods

	// RVA: 0xDE4CCC
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDE4CD4
	public string get_Name() { }

	// RVA: 0xDE032C
	public JToken get_Value() { }

	// RVA: 0xDE2440
	public void set_Value(JToken value) { }

	// RVA: 0xDE4CDC
	internal void .ctor(JProperty other, JsonCloneSettings settings) { }

	// RVA: 0xDE4D88
	internal override JToken GetItem(int index) { }

	// RVA: 0xDE4DE8
	internal override void SetItem(int index, JToken item) { }

	// RVA: 0xDE4FAC
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0xDE505C
	internal override void RemoveItemAt(int index) { }

	// RVA: 0xDE510C
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xDE5154
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDE5284
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0xDE52AC
	internal override void ClearItems() { }

	// RVA: 0xDE535C
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDE53C8
	public override JTokenType get_Type() { }

	// RVA: 0xDE09F4
	internal void .ctor(string name) { }

	// RVA: 0xDE281C
	public void .ctor(string name, object content) { }

	// RVA: 0xDE53D0
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDE5460
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JPropertyDescriptor
{
	// Methods

	// RVA: 0xDE3F3C
	public void .ctor(string name) { }

	// RVA: 0xDE5A28
	public override bool CanResetValue(object component) { }

	// RVA: 0xDE5A30
	public override object GetValue(object component) { }

	// RVA: 0xDE5B48
	public override void ResetValue(object component) { }

	// RVA: 0xDE5B4C
	public override void SetValue(object component, object value) { }

	// RVA: 0xDE5CE4
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xDE5CEC
	public override Type get_ComponentType() { }

	// RVA: 0xDE5D8C
	public override bool get_IsReadOnly() { }

	// RVA: 0xDE5D94
	public override Type get_PropertyType() { }

	// RVA: 0xDE5E34
	protected override int get_NameHashCode() { }

}

// Namespace: Newtonsoft.Json.Linq
internal class JPropertyKeyedCollection
{
	// Fields
	private static readonly System.Collections.Generic.IEqualityComparer<System.String> Comparer; // 0x0
	private System.Collections.Generic.Dictionary<System.String,Newtonsoft.Json.Linq.JToken> _dictionary; // 0x18

	// Methods

	// RVA: 0xDE1744
	public void .ctor() { }

	// RVA: 0xDE5E3C
	private void AddKey(string key, JToken item) { }

	// RVA: 0xDE5F7C
	protected override void ClearItems() { }

	// RVA: 0xDE2A48
	public bool Contains(string key) { }

	// RVA: 0xDE5EB0
	private void EnsureDictionary() { }

	// RVA: 0xDE6004
	private string GetKeyForItem(JToken item) { }

	// RVA: 0xDE6088
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0xDE61B8
	protected override void RemoveItem(int index) { }

	// RVA: 0xDE6340
	private void RemoveKey(string key) { }

	// RVA: 0xDE63B0
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0xDE1FB0
	public bool TryGetValue(string key, JToken value) { }

	// RVA: 0xDE2B64
	public System.Collections.Generic.ICollection<System.String> get_Keys() { }

	// RVA: 0xDE1BF8
	public int IndexOfReference(JToken t) { }

	// RVA: 0xDE66F8
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JRaw
{
	// Methods

	// RVA: 0xDE67DC
	internal void .ctor(JRaw other, JsonCloneSettings settings) { }

	// RVA: 0xDE6904
	public void .ctor(object rawJson) { }

	// RVA: 0xDE6A14
	public static JRaw Create(JsonReader reader) { }

	// RVA: 0xDE6D60
	internal override JToken CloneToken(JsonCloneSettings settings) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JsonCloneSettings
{
	// Fields
	internal static readonly JsonCloneSettings SkipCopyAnnotations; // 0x0
	private bool <CopyAnnotations>k__BackingField; // 0x10

	// Methods

	// RVA: 0xDE6DCC
	public void .ctor() { }

	// RVA: 0xDE6DF8
	public bool get_CopyAnnotations() { }

	// RVA: 0xDE6E00
	public void set_CopyAnnotations(bool value) { }

	// RVA: 0xDE6E08
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

	// RVA: 0xDE6E78
	public CommentHandling get_CommentHandling() { }

	// RVA: 0xDE6E80
	public LineInfoHandling get_LineInfoHandling() { }

	// RVA: 0xDE6E88
	public DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }

}

// Namespace: 
private class LineInfoAnnotation
{
	// Fields
	internal readonly int LineNumber; // 0x10
	internal readonly int LinePosition; // 0x14

	// Methods

	// RVA: 0xDEF6D4
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

	// RVA: 0xDE6E90
	public JContainer get_Parent() { }

	// RVA: 0xDE6E98
	internal void set_Parent(JContainer value) { }

	// RVA: 0xDDDC3C
	public JToken get_Root() { }

	// RVA: -1
	internal abstract JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: -1
	public abstract JTokenType get_Type() { }

	// RVA: -1
	public abstract bool get_HasValues() { }

	// RVA: 0xDE6EA0
	public JToken get_Next() { }

	// RVA: 0xDE6EA8
	internal void set_Next(JToken value) { }

	// RVA: 0xDE6EB0
	public JToken get_Previous() { }

	// RVA: 0xDE6EB8
	internal void set_Previous(JToken value) { }

	// RVA: 0xDE6EC0
	public string get_Path() { }

	// RVA: 0xDDCF48
	internal void .ctor() { }

	// RVA: 0xDE71D0
	public virtual JToken get_First() { }

	// RVA: 0xDE7264
	public virtual JToken get_Last() { }

	// RVA: 0xDE72F8
	public virtual Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }

	// RVA: 0xDE2C54
	public void Remove() { }

	// RVA: 0xDE0ADC
	public void Replace(JToken value) { }

	// RVA: -1
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDE7374
	public override string ToString() { }

	// RVA: 0xDE745C
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0xDE7680
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0xDE77B8
	private static string GetType(JToken token) { }

	// RVA: 0xDE78B4
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0xDE7994
	public static bool op_Explicit(JToken value) { }

	// RVA: 0xDE7C3C
	public static DateTimeOffset op_Explicit(JToken value) { }

	// RVA: 0xDE7F10
	public static System.Nullable<System.Boolean> op_Explicit(JToken value) { }

	// RVA: 0xDE81FC
	public static Int64 op_Explicit(JToken value) { }

	// RVA: 0xDE8484
	public static System.Nullable<System.DateTime> op_Explicit(JToken value) { }

	// RVA: 0xDE8748
	public static System.Nullable<System.DateTimeOffset> op_Explicit(JToken value) { }

	// RVA: 0xDE8A88
	public static System.Nullable<System.Decimal> op_Explicit(JToken value) { }

	// RVA: 0xDE8D78
	public static System.Nullable<System.Double> op_Explicit(JToken value) { }

	// RVA: 0xDE9020
	public static System.Nullable<System.Char> op_Explicit(JToken value) { }

	// RVA: 0xDE92E4
	public static int op_Explicit(JToken value) { }

	// RVA: 0xDE956C
	public static Int16 op_Explicit(JToken value) { }

	// RVA: 0xDE97F4
	public static UInt16 op_Explicit(JToken value) { }

	// RVA: 0xDE9A7C
	public static Char op_Explicit(JToken value) { }

	// RVA: 0xDE9D04
	public static Byte op_Explicit(JToken value) { }

	// RVA: 0xDE9F8C
	public static SByte op_Explicit(JToken value) { }

	// RVA: 0xDEA214
	public static System.Nullable<System.Int32> op_Explicit(JToken value) { }

	// RVA: 0xDEA4BC
	public static System.Nullable<System.Int16> op_Explicit(JToken value) { }

	// RVA: 0xDEA780
	public static System.Nullable<System.UInt16> op_Explicit(JToken value) { }

	// RVA: 0xDEAA44
	public static System.Nullable<System.Byte> op_Explicit(JToken value) { }

	// RVA: 0xDEAD08
	public static System.Nullable<System.SByte> op_Explicit(JToken value) { }

	// RVA: 0xDEAFCC
	public static DateTime op_Explicit(JToken value) { }

	// RVA: 0xDEB254
	public static System.Nullable<System.Int64> op_Explicit(JToken value) { }

	// RVA: 0xDEB4FC
	public static System.Nullable<System.Single> op_Explicit(JToken value) { }

	// RVA: 0xDEB7A4
	public static Decimal op_Explicit(JToken value) { }

	// RVA: 0xDEBA2C
	public static System.Nullable<System.UInt32> op_Explicit(JToken value) { }

	// RVA: 0xDEBCD4
	public static System.Nullable<System.UInt64> op_Explicit(JToken value) { }

	// RVA: 0xDEBF7C
	public static Double op_Explicit(JToken value) { }

	// RVA: 0xDEC204
	public static float op_Explicit(JToken value) { }

	// RVA: 0xDEC48C
	public static string op_Explicit(JToken value) { }

	// RVA: 0xDEC7BC
	public static UInt32 op_Explicit(JToken value) { }

	// RVA: 0xDECA44
	public static UInt64 op_Explicit(JToken value) { }

	// RVA: 0xDECCCC
	public static Guid op_Explicit(JToken value) { }

	// RVA: 0xDECF5C
	public static System.Nullable<System.Guid> op_Explicit(JToken value) { }

	// RVA: 0xDED270
	public static TimeSpan op_Explicit(JToken value) { }

	// RVA: 0xDED4F0
	public static System.Nullable<System.TimeSpan> op_Explicit(JToken value) { }

	// RVA: 0xDED7AC
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0xDEDA28
	private static BigInteger ToBigInteger(JToken value) { }

	// RVA: 0xDEDBF4
	private static System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(JToken value) { }

	// RVA: 0xDEDE48
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xDEDEFC
	private System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: 0xDEDF98
	public JsonReader CreateReader() { }

	// RVA: 0xDEE0C0
	public object ToObject(Type objectType) { }

	// RVA: 0xDEEF58
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0xDEF1D4
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0xDEF25C
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xDDC18C
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0xDEF658
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0xDEF970
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xDEF9D0
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xDEFA30
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xDEFA90
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0xDEFB64
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0xDEFB74
	private object System.ICloneable.Clone() { }

	// RVA: 0xDEFB84
	public JToken DeepClone() { }

	// RVA: 0xDEF70C
	public void AddAnnotation(object annotation) { }

	// RVA: 0x315B3A8
	public T Annotation() { }

	// RVA: 0xDDCF50
	internal void CopyAnnotations(JToken target, JToken source) { }

	// RVA: 0xDEFB94
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

	// RVA: 0xDEFEA0
	public JToken get_CurrentToken() { }

	// RVA: 0xDEE048
	public void .ctor(JToken token) { }

	// RVA: 0xDEFEA8
	public override bool Read() { }

	// RVA: 0xDF00B4
	private bool ReadOver(JToken t) { }

	// RVA: 0xDF08D4
	private bool ReadToEnd() { }

	// RVA: 0xDF0A88
	private System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0xDF0020
	private bool ReadInto(JContainer c) { }

	// RVA: 0xDF0910
	private bool SetEnd(JContainer c) { }

	// RVA: 0xDF01A0
	private void SetToken(JToken token) { }

	// RVA: 0xDF0BF8
	private string SafeToString(object value) { }

	// RVA: 0xDF0C18
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xDF0CE0
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xDF0DAC
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xDF0E78
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

	// RVA: 0xDF0F98
	public JToken get_Token() { }

	// RVA: 0xDF0FB4
	public void .ctor() { }

	// RVA: 0xDF103C
	public override void Close() { }

	// RVA: 0xDF1044
	public override void WriteStartObject() { }

	// RVA: 0xDF10F0
	private void AddParent(JContainer container) { }

	// RVA: 0xDF115C
	private void RemoveParent() { }

	// RVA: 0xDF11DC
	public override void WriteStartArray() { }

	// RVA: 0xDF1288
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xDF1340
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xDF1344
	public override void WritePropertyName(string name) { }

	// RVA: 0xDF144C
	private void AddRawValue(object value, JTokenType type, JsonToken token) { }

	// RVA: 0xDF1514
	internal void AddJValue(JValue value, JsonToken token) { }

	// RVA: 0xDF15E0
	public override void WriteValue(object value) { }

	// RVA: 0xDF1680
	public override void WriteNull() { }

	// RVA: 0xDF16B0
	public override void WriteUndefined() { }

	// RVA: 0xDF16E0
	public override void WriteRaw(string json) { }

	// RVA: 0xDF17B8
	public override void WriteComment(string text) { }

	// RVA: 0xDF1888
	public override void WriteValue(string value) { }

	// RVA: 0xDF19E4
	public override void WriteValue(int value) { }

	// RVA: 0xDF1A70
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xDF1AFC
	public override void WriteValue(Int64 value) { }

	// RVA: 0xDF1C44
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xDF1D88
	public override void WriteValue(float value) { }

	// RVA: 0xDF1EDC
	public override void WriteValue(Double value) { }

	// RVA: 0xDF2034
	public override void WriteValue(bool value) { }

	// RVA: 0xDF217C
	public override void WriteValue(Int16 value) { }

	// RVA: 0xDF2208
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xDF2294
	public override void WriteValue(Char value) { }

	// RVA: 0xDF23E4
	public override void WriteValue(Byte value) { }

	// RVA: 0xDF2470
	public override void WriteValue(SByte value) { }

	// RVA: 0xDF24FC
	public override void WriteValue(Decimal value) { }

	// RVA: 0xDF2668
	public override void WriteValue(DateTime value) { }

	// RVA: 0xDF27F0
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xDF2954
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xDF2A2C
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xDF2B70
	public override void WriteValue(Guid value) { }

	// RVA: 0xDF2CD4
	public override void WriteValue(Uri value) { }

	// RVA: 0xDF2E54
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

}

// Namespace: 
private class JValueDynamicProxy
{
	// Methods

	// RVA: 0xDF6748
	public override bool TryConvert(JValue instance, ConvertBinder binder, object result) { }

	// RVA: 0xDF6934
	public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, object result) { }

	// RVA: 0xDF5E34
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JValue
{
	// Fields
	private JTokenType _valueType; // 0x30
	private object _value; // 0x38

	// Methods

	// RVA: 0xDE6988
	internal void .ctor(object value, JTokenType type) { }

	// RVA: 0xDE67E0
	internal void .ctor(JValue other, JsonCloneSettings settings) { }

	// RVA: 0xDF1B78
	public void .ctor(Int64 value) { }

	// RVA: 0xDF258C
	public void .ctor(Decimal value) { }

	// RVA: 0xDF1CC0
	public void .ctor(UInt64 value) { }

	// RVA: 0xDF1F60
	public void .ctor(Double value) { }

	// RVA: 0xDF1E0C
	public void .ctor(float value) { }

	// RVA: 0xDF2728
	public void .ctor(DateTime value) { }

	// RVA: 0xDF2880
	public void .ctor(DateTimeOffset value) { }

	// RVA: 0xDF20B0
	public void .ctor(bool value) { }

	// RVA: 0xDF1960
	public void .ctor(string value) { }

	// RVA: 0xDF2C00
	public void .ctor(Guid value) { }

	// RVA: 0xDF2D50
	public void .ctor(Uri value) { }

	// RVA: 0xDF2AA8
	public void .ctor(TimeSpan value) { }

	// RVA: 0xDDFD54
	public void .ctor(object value) { }

	// RVA: 0xDF35FC
	public override bool get_HasValues() { }

	// RVA: 0xDF3604
	private static int CompareBigInteger(BigInteger i1, object i2) { }

	// RVA: 0xDF3980
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	// RVA: 0xDF43F4
	private static int CompareFloat(object objA, object objB) { }

	// RVA: 0xDF4538
	private static bool Operation(ExpressionType operation, object objA, object objB, object result) { }

	// RVA: 0xDF4E48
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDE0470
	public static JValue CreateComment(string value) { }

	// RVA: 0xDDDB88
	public static JValue CreateNull() { }

	// RVA: 0xDE0528
	public static JValue CreateUndefined() { }

	// RVA: 0xDF3158
	private static JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, object value) { }

	// RVA: 0xDF4EB4
	private static JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current) { }

	// RVA: 0xDF507C
	public override JTokenType get_Type() { }

	// RVA: 0xDF5084
	public object get_Value() { }

	// RVA: 0xDF508C
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDF59E0
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0xDF5A48
	public bool Equals(JValue other) { }

	// RVA: 0xDF5AB0
	public override bool Equals(object obj) { }

	// RVA: 0xDF5B8C
	public override int GetHashCode() { }

	// RVA: 0xDF5BA4
	public override string ToString() { }

	// RVA: 0xDF5C10
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0xDF5C1C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xDF5D48
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0xDF5E88
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xDF5F44
	public int CompareTo(JValue obj) { }

	// RVA: 0xDF5F74
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0xDF6044
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xDF60C4
	private Char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xDF6144
	private SByte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xDF61C4
	private Byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xDF6244
	private Int16 System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xDF62C4
	private UInt16 System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xDF6344
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xDF63C4
	private UInt32 System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xDF6444
	private Int64 System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xDF64C4
	private UInt64 System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xDF6544
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xDF65C4
	private Double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xDF6644
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xDF66C4
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xDF6744
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

	// RVA: 0xDF6CC0
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDF6D24
	private Byte[] GetByteArray(object value) { }

	// RVA: 0xDF6F24
	private static void EnsureReflectionObject(Type t) { }

	// RVA: 0xDF70E0
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDF751C
	private Byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0xDF7850
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xDF7978
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class BsonObjectIdConverter
{
	// Methods

	// RVA: 0xDF7980
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDF7A84
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDF7C10
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xDF7C9C
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public abstract class CustomCreationConverter<T0>
{
	// Methods

	// RVA: 0x30A2BF4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30A1A54
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: -1
	public abstract T Create(Type objectType) { }

	// RVA: 0x30A1344
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x30A1224
	public override bool get_CanWrite() { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class DataSetConverter
{
	// Methods

	// RVA: 0xDF7CA4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDF8148
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDF84AC
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xDF8564
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class DataTableConverter
{
	// Methods

	// RVA: 0xDF856C
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDF8D04
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDF8FFC
	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	// RVA: 0xDF9530
	private static Type GetColumnDataType(JsonReader reader) { }

	// RVA: 0xDF9728
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xDF97E0
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public abstract class DateTimeConverterBase
{
	// Methods

	// RVA: 0xDF97E8
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xDF9960
	protected void .ctor() { }

}

// Namespace: 
internal class Union
{
	// Fields
	public readonly FSharpFunction TagReader; // 0x10
	public readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases; // 0x18

	// Methods

	// RVA: 0xDFA500
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

	// RVA: 0xDFA550
	public void .ctor(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public int tag; // 0x10

	// Methods

	// RVA: 0xDFAAD8
	public void .ctor() { }

	// RVA: 0xDFB688
	internal bool <WriteJson>b__0(UnionCase c) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public string caseName; // 0x10
	public System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase,System.Boolean> <>9__0; // 0x18

	// Methods

	// RVA: 0xDFB1C0
	public void .ctor() { }

	// RVA: 0xDFB6B0
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

	// RVA: 0xDF9968
	private static Type CreateUnionTypeLookup(Type t) { }

	// RVA: 0xDF9BEC
	private static Union CreateUnion(Type t) { }

	// RVA: 0xDFA5D8
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDFAAE0
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDFB1C8
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xDFB4EC
	public void .ctor() { }

	// RVA: 0xDFB4F4
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

	// RVA: 0xDFB6D8
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDFBB9C
	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	// RVA: 0xDFBC8C
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDFBA78
	private static void EnsureReflectionObject(Type objectType) { }

	// RVA: 0xDFBF8C
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xDFBFE8
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class ExpandoObjectConverter
{
	// Methods

	// RVA: 0xDFBFF0
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDFBFF4
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDFBFF8
	private object ReadValue(JsonReader reader) { }

	// RVA: 0xDFC3BC
	private object ReadList(JsonReader reader) { }

	// RVA: 0xDFC168
	private object ReadObject(JsonReader reader) { }

	// RVA: 0xDFC59C
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xDFC628
	public override bool get_CanWrite() { }

	// RVA: 0xDFC630
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

	// RVA: 0xDFC638
	public DateTimeStyles get_DateTimeStyles() { }

	// RVA: 0xDFC640
	public void set_DateTimeStyles(DateTimeStyles value) { }

	// RVA: 0xDFC648
	public string get_DateTimeFormat() { }

	// RVA: 0xDFC6B4
	public void set_DateTimeFormat(string value) { }

	// RVA: 0xDFC6F8
	public CultureInfo get_Culture() { }

	// RVA: 0xDFC774
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xDFC77C
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDFCA9C
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDFD17C
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class JavaScriptDateTimeConverter
{
	// Methods

	// RVA: 0xDFD18C
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDFD378
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDFD6E4
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

	// RVA: 0xDFD6EC
	private static ReflectionObject InitializeReflectionObject(Type t) { }

	// RVA: 0xDFD96C
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDFDBF8
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDFE0F0
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xDFE240
	public void .ctor() { }

	// RVA: 0xDFE248
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class RegexConverter
{
	// Fields
	private const string PatternName = "Pattern";
	private const string OptionsName = "Options";

	// Methods

	// RVA: 0xDFE334
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDFE784
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0xDFE450
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0xDFE5BC
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0xDFE844
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDFEBFC
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0xDFE8F4
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0xDFED5C
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xDFEDD8
	private bool IsRegex(Type objectType) { }

	// RVA: 0xDFEE64
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class StringEnumConverter
{
	// Fields
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x10
	private bool <AllowIntegerValues>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDFEE6C
	public bool get_CamelCaseText() { }

	// RVA: 0xDFEEF4
	public void set_CamelCaseText(bool value) { }

	// RVA: 0xDFEFDC
	public NamingStrategy get_NamingStrategy() { }

	// RVA: 0xDFEFE4
	public void set_NamingStrategy(NamingStrategy value) { }

	// RVA: 0xDFEFEC
	public bool get_AllowIntegerValues() { }

	// RVA: 0xDFEFF4
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0xDFEFFC
	public void .ctor() { }

	// RVA: 0xDFF00C
	public void .ctor(bool camelCaseText) { }

	// RVA: 0xDFF0A4
	public void .ctor(NamingStrategy namingStrategy, bool allowIntegerValues) { }

	// RVA: 0xDFF0F4
	public void .ctor(Type namingStrategyType) { }

	// RVA: 0xDFF1B0
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters) { }

	// RVA: 0xDFF270
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) { }

	// RVA: 0xDFF344
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDFF554
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xDFFA24
	public override bool CanConvert(Type objectType) { }

}

// Namespace: Newtonsoft.Json.Converters
public class UnixDateTimeConverter
{
	// Fields
	internal static readonly DateTime UnixEpoch; // 0x0
	private bool <AllowPreEpoch>k__BackingField; // 0x10

	// Methods

	// RVA: 0xDFFAD4
	public bool get_AllowPreEpoch() { }

	// RVA: 0xDFFADC
	public void set_AllowPreEpoch(bool value) { }

	// RVA: 0xDFFAE4
	public void .ctor() { }

	// RVA: 0xDFFB0C
	public void .ctor(bool allowPreEpoch) { }

	// RVA: 0xDFFB38
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xDFFDA4
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE00204
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class VersionConverter
{
	// Methods

	// RVA: 0xE00284
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE0037C
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE00628
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE006B4
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDocumentWrapper
{
	// Fields
	private readonly XmlDocument _document; // 0x28

	// Methods

	// RVA: 0xE006BC
	public void .ctor(XmlDocument document) { }

	// RVA: 0xE00734
	public IXmlNode CreateComment(string data) { }

	// RVA: 0xE007D0
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xE0086C
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xE00908
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xE009A4
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xE00A40
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE00B48
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE00C54
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE00CF8
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xE00DE0
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xE00E8C
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xE00F64
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xE01028
	public IXmlElement get_DocumentElement() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlElementWrapper
{
	// Fields
	private readonly XmlElement _element; // 0x28

	// Methods

	// RVA: 0xE00D9C
	public void .ctor(XmlElement element) { }

	// RVA: 0xE010E4
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xE011D8
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xE01200
	public bool get_IsEmpty() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDeclarationWrapper
{
	// Fields
	private readonly XmlDeclaration _declaration; // 0x28

	// Methods

	// RVA: 0xE00B04
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0xE01220
	public string get_Version() { }

	// RVA: 0xE01240
	public string get_Encoding() { }

	// RVA: 0xE01260
	public string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDocumentTypeWrapper
{
	// Fields
	private readonly XmlDocumentType _documentType; // 0x28

	// Methods

	// RVA: 0xE00C10
	public void .ctor(XmlDocumentType documentType) { }

	// RVA: 0xE01280
	public string get_Name() { }

	// RVA: 0xE012A4
	public string get_System() { }

	// RVA: 0xE012C4
	public string get_Public() { }

	// RVA: 0xE012E4
	public string get_InternalSubset() { }

	// RVA: 0xE01304
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

	// RVA: 0xE00700
	public void .ctor(XmlNode node) { }

	// RVA: 0xE01348
	public object get_WrappedNode() { }

	// RVA: 0xE01350
	public XmlNodeType get_NodeType() { }

	// RVA: 0xE01374
	public virtual string get_LocalName() { }

	// RVA: 0xE0139C
	public System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE01778
	internal static IXmlNode WrapNode(XmlNode node) { }

	// RVA: 0xE01910
	public System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE01D60
	private bool get_HasAttributes() { }

	// RVA: 0xE01E14
	public IXmlNode get_ParentNode() { }

	// RVA: 0xE01ECC
	public string get_Value() { }

	// RVA: 0xE00F40
	public void set_Value(string value) { }

	// RVA: 0xE01EF0
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE01FBC
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

	// RVA: 0xE01FE4
	internal XDeclaration get_Declaration() { }

	// RVA: 0xE01FEC
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0xE02064
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE0206C
	public string get_Version() { }

	// RVA: 0xE0208C
	public string get_Encoding() { }

	// RVA: 0xE020AC
	public string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDocumentTypeWrapper
{
	// Fields
	private readonly XDocumentType _documentType; // 0x18

	// Methods

	// RVA: 0xE020CC
	public void .ctor(XDocumentType documentType) { }

	// RVA: 0xE02110
	public string get_Name() { }

	// RVA: 0xE02130
	public string get_System() { }

	// RVA: 0xE02150
	public string get_Public() { }

	// RVA: 0xE02170
	public string get_InternalSubset() { }

	// RVA: 0xE02190
	public override string get_LocalName() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDocumentWrapper
{
	// Methods

	// RVA: 0xE021D4
	private XDocument get_Document() { }

	// RVA: 0xE02250
	public void .ctor(XDocument document) { }

	// RVA: 0xE022B8
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE0293C
	protected override bool get_HasChildNodes() { }

	// RVA: 0xE02AD0
	public IXmlNode CreateComment(string text) { }

	// RVA: 0xE02B70
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xE02C10
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xE02CB0
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xE02D50
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xE02DF0
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE02EB8
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE02F90
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE03074
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xE03158
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xE03220
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xE03314
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xE033E4
	public IXmlElement get_DocumentElement() { }

	// RVA: 0xE03554
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XTextWrapper
{
	// Methods

	// RVA: 0xE037CC
	private XText get_Text() { }

	// RVA: 0xE03848
	public void .ctor(XText text) { }

	// RVA: 0xE0387C
	public override string get_Value() { }

	// RVA: 0xE03900
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XCommentWrapper
{
	// Methods

	// RVA: 0xE03D14
	private XComment get_Text() { }

	// RVA: 0xE03D90
	public void .ctor(XComment text) { }

	// RVA: 0xE03DC4
	public override string get_Value() { }

	// RVA: 0xE03E48
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XProcessingInstructionWrapper
{
	// Methods

	// RVA: 0xE03F44
	private XProcessingInstruction get_ProcessingInstruction() { }

	// RVA: 0xE03040
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0xE03FC0
	public override string get_LocalName() { }

	// RVA: 0xE04044
	public override string get_Value() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XContainerWrapper
{
	// Fields
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes; // 0x18

	// Methods

	// RVA: 0xE040C8
	private XContainer get_Container() { }

	// RVA: 0xE02284
	public void .ctor(XContainer container) { }

	// RVA: 0xE02534
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE02A40
	protected virtual bool get_HasChildNodes() { }

	// RVA: 0xE04144
	public override IXmlNode get_ParentNode() { }

	// RVA: 0xE039FC
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0xE03668
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XObjectWrapper
{
	// Fields
	private readonly XObject _xmlObject; // 0x10

	// Methods

	// RVA: 0xE02030
	public void .ctor(XObject xmlObject) { }

	// RVA: 0xE04240
	public object get_WrappedNode() { }

	// RVA: 0xE04248
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0xE04260
	public virtual string get_LocalName() { }

	// RVA: 0xE04268
	public virtual System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE042E4
	public virtual System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE04360
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0xE04368
	public virtual string get_Value() { }

	// RVA: 0xE04370
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE043B0
	public virtual string get_NamespaceUri() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XAttributeWrapper
{
	// Methods

	// RVA: 0xE043B8
	private XAttribute get_Attribute() { }

	// RVA: 0xE032E0
	public void .ctor(XAttribute attribute) { }

	// RVA: 0xE04434
	public override string get_Value() { }

	// RVA: 0xE044B8
	public override string get_LocalName() { }

	// RVA: 0xE04544
	public override string get_NamespaceUri() { }

	// RVA: 0xE045D0
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XElementWrapper
{
	// Fields
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes; // 0x20

	// Methods

	// RVA: 0xE046CC
	private XElement get_Element() { }

	// RVA: 0xE03124
	public void .ctor(XElement element) { }

	// RVA: 0xE04748
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xE04850
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE04DF0
	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	// RVA: 0xE053E0
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE05418
	public override string get_Value() { }

	// RVA: 0xE0549C
	public override string get_LocalName() { }

	// RVA: 0xE05528
	public override string get_NamespaceUri() { }

	// RVA: 0xE0532C
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xE055B4
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

	// RVA: 0xE05638
	public string get_DeserializeRootElementName() { }

	// RVA: 0xE05640
	public void set_DeserializeRootElementName(string value) { }

	// RVA: 0xE05648
	public bool get_WriteArrayAttribute() { }

	// RVA: 0xE05650
	public void set_WriteArrayAttribute(bool value) { }

	// RVA: 0xE05658
	public bool get_OmitRootObject() { }

	// RVA: 0xE05660
	public void set_OmitRootObject(bool value) { }

	// RVA: 0xE05668
	public bool get_EncodeSpecialCharacters() { }

	// RVA: 0xE05670
	public void set_EncodeSpecialCharacters(bool value) { }

	// RVA: 0xE05678
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE057C4
	private IXmlNode WrapXml(object value) { }

	// RVA: 0xE058E0
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE07938
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE07CF0
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE081C8
	private bool IsArray(IXmlNode node) { }

	// RVA: 0xE085D4
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xE09214
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, string elementNames) { }

	// RVA: 0xE09398
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	// RVA: 0xE060A8
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xE0946C
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0xE09B18
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0B01C
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0xE0A40C
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0xE0D420
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, System.Collections.Generic.Dictionary<System.String,System.String> attributeNameValues) { }

	// RVA: 0xE0D094
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0xE0B608
	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0xE0C574
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0xE0DF88
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0xE0C9A8
	private bool ShouldReadInto(JsonReader reader) { }

	// RVA: 0xE0C9EC
	private System.Collections.Generic.Dictionary<System.String,System.String> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0xE0BCEC
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0xE0C19C
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0xE0DD70
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0xE0A7B0
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0xE0E2DC
	private bool IsNamespaceAttribute(string attributeName, string prefix) { }

	// RVA: 0xE097A8
	private bool ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c) { }

	// RVA: 0xE0E3D0
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xE0E488
	private bool IsXObject(Type valueType) { }

	// RVA: 0xE0E540
	private bool IsXmlNode(Type valueType) { }

	// RVA: 0xE0E5F8
	public void .ctor() { }

	// RVA: 0xE0E600
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Bson
public class BsonObjectId
{
	// Fields
	private readonly Byte[] <Value>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE0E69C
	public Byte[] get_Value() { }

	// RVA: 0xE0E6A4
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

	// RVA: 0xE0E78C
	public void set_Parent(BsonToken value) { }

	// RVA: 0xE0E794
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonObject
{
	// Fields
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children; // 0x18

	// Methods

	// RVA: 0xE0E79C
	public void Add(string name, BsonToken token) { }

	// RVA: 0xE0E908
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonArray
{
	// Fields
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children; // 0x18

	// Methods

	// RVA: 0xE0E910
	public void Add(BsonToken token) { }

	// RVA: 0xE0E988
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonValue
{
	// Fields
	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	// Methods

	// RVA: 0xE0E990
	public void .ctor(object value, BsonType type) { }

	// RVA: 0xE0E9D8
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonString
{
	// Fields
	private readonly bool <IncludeLength>k__BackingField; // 0x21

	// Methods

	// RVA: 0xE0E8B8
	public void .ctor(object value, bool includeLength) { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonRegex
{
	// Fields
	private BsonString <Pattern>k__BackingField; // 0x18
	private BsonString <Options>k__BackingField; // 0x20

	// Methods

	// RVA: 0xE0E9E0
	public void set_Pattern(BsonString value) { }

	// RVA: 0xE0E9E8
	public void set_Options(BsonString value) { }

	// RVA: 0xE0E9F0
	public void .ctor(string pattern, string options) { }

	// RVA: 0xE0EAC8
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonProperty
{
	// Fields
	private BsonString <Name>k__BackingField; // 0x10
	private BsonToken <Value>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE0EAD0
	public void set_Name(BsonString value) { }

	// RVA: 0xE0EAD8
	public void set_Value(BsonToken value) { }

	// RVA: 0xE0E8B0
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

	// RVA: 0xE0EAE0
	private void AddValue(object value, BsonType type) { }

	// RVA: 0xE0EB6C
	internal void AddToken(BsonToken token) { }

	// RVA: 0xE0EDBC
	public void WriteObjectId(Byte[] value) { }

	// RVA: 0xDFE790
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


