// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0xD814EC
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class IsReadOnlyAttribute
{
	// Methods

	// RVA: 0xD814F4
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xD814FC
	public void .ctor(Byte ) { }

	// RVA: 0xD81588
	public void .ctor(Byte[] ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0xD815BC
	public void .ctor(Byte ) { }

}

// Namespace: System.Diagnostics.CodeAnalysis
internal sealed class NotNullAttribute
{
	// Methods

	// RVA: 0xD815E8
	public void .ctor() { }

}

// Namespace: System.Diagnostics.CodeAnalysis
internal sealed class NotNullWhenAttribute
{
	// Fields
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD815F0
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

	// RVA: 0xD81D2C
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

	// RVA: 0xD8161C
	private static void .cctor() { }

	// RVA: 0xD81670
	public void .ctor() { }

	// RVA: 0xD816F4
	public override string Get(Char[] key, int start, int length) { }

	// RVA: 0xD81A20
	public string Add(string key) { }

	// RVA: 0xD81BF4
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0xD81D84
	private void Grow() { }

	// RVA: 0xD81944
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

	// RVA: 0xD81F10
	public Type get_ItemConverterType() { }

	// RVA: 0xD81F18
	public object[] get_ItemConverterParameters() { }

	// RVA: 0xD81F20
	public Type get_NamingStrategyType() { }

	// RVA: 0xD81F28
	public object[] get_NamingStrategyParameters() { }

	// RVA: 0xD81F30
	internal NamingStrategy get_NamingStrategyInstance() { }

	// RVA: 0xD81F38
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

	// RVA: 0xD81F40
	public static System.Func<Newtonsoft.Json.JsonSerializerSettings> get_DefaultSettings() { }

	// RVA: 0xD81FBC
	public static string ToString(bool value) { }

	// RVA: 0xD82058
	public static string ToString(Char value) { }

	// RVA: 0xD82220
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD82498
	private static string EnsureFloatFormat(Double value, string text, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD825C0
	internal static string ToString(Double value, FloatFormatHandling floatFormatHandling, Char quoteChar, bool nullable) { }

	// RVA: 0xD823D0
	private static string EnsureDecimalPlace(Double value, string text) { }

	// RVA: 0xD82768
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0xD827E0
	public static string ToString(Decimal value) { }

	// RVA: 0xD82100
	public static string ToString(string value) { }

	// RVA: 0xD82970
	public static string ToString(string value, Char delimiter) { }

	// RVA: 0xD829DC
	public static string ToString(string value, Char delimiter, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xD82AC0
	public static string SerializeObject(object value) { }

	// RVA: 0xD82B90
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xD82C58
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	// RVA: 0x316B894
	public static T DeserializeObject(string value) { }

	// RVA: 0x316B894
	public static T DeserializeObject(string value, JsonSerializerSettings settings) { }

	// RVA: 0xD83150
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0xD835D0
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

	// RVA: 0xD83744
	public virtual bool get_CanRead() { }

	// RVA: 0xD8374C
	public virtual bool get_CanWrite() { }

	// RVA: 0xD83754
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonConverterAttribute
{
	// Fields
	private readonly Type _converterType; // 0x10
	private readonly object[] <ConverterParameters>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD8375C
	public Type get_ConverterType() { }

	// RVA: 0xD83764
	public object[] get_ConverterParameters() { }

}

// Namespace: Newtonsoft.Json
public class JsonConverterCollection
{
	// Methods

	// RVA: 0xD8376C
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

	// RVA: 0xD837C0
	public void .ctor() { }

	// RVA: 0xD83848
	public void .ctor(string message) { }

	// RVA: 0xD838B4
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xD83930
	public void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: Newtonsoft.Json
public class JsonExtensionDataAttribute
{
	// Fields
	private bool <WriteData>k__BackingField; // 0x10
	private bool <ReadData>k__BackingField; // 0x11

	// Methods

	// RVA: 0xD839B4
	public bool get_WriteData() { }

	// RVA: 0xD839BC
	public bool get_ReadData() { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonIgnoreAttribute
{
	// Methods

	// RVA: 0xD839C4
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json
public abstract class JsonNameTable
{
	// Methods

	// RVA: -1
	public abstract string Get(Char[] key, int start, int length) { }

	// RVA: 0xD816EC
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

	// RVA: 0xD839CC
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

	// RVA: 0xD839D4
	public void .ctor(JsonContainerType type) { }

	// RVA: 0xD83A6C
	internal int CalculateLength() { }

	// RVA: 0xD83B14
	internal void WriteTo(StringBuilder sb, StringWriter writer, Char[] buffer) { }

	// RVA: 0xD83A5C
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0xD83D60
	internal static string BuildPath(System.Collections.Generic.List<Newtonsoft.Json.JsonPosition> positions, System.Nullable<Newtonsoft.Json.JsonPosition> currentPosition) { }

	// RVA: 0xD84248
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0xD84580
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

	// RVA: 0xD84624
	public Type get_ItemConverterType() { }

	// RVA: 0xD8462C
	public object[] get_ItemConverterParameters() { }

	// RVA: 0xD84634
	public Type get_NamingStrategyType() { }

	// RVA: 0xD8463C
	public object[] get_NamingStrategyParameters() { }

	// RVA: 0xD84644
	public string get_PropertyName() { }

	// RVA: 0xD8464C
	public void set_PropertyName(string value) { }

	// RVA: 0xD84654
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

	// RVA: 0xD8465C
	protected State get_CurrentState() { }

	// RVA: 0xD84664
	public bool get_CloseInput() { }

	// RVA: 0xD8466C
	public void set_CloseInput(bool value) { }

	// RVA: 0xD84674
	public bool get_SupportMultipleContent() { }

	// RVA: 0xD8467C
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0xD84684
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xD8468C
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xD846F8
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0xD84700
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0xD8476C
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0xD84774
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0xD847E0
	public string get_DateFormatString() { }

	// RVA: 0xD847E8
	public void set_DateFormatString(string value) { }

	// RVA: 0xD847F0
	public System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xD847F8
	public void set_MaxDepth(System.Nullable<System.Int32> value) { }

	// RVA: 0xD8498C
	public virtual JsonToken get_TokenType() { }

	// RVA: 0xD84994
	public virtual object get_Value() { }

	// RVA: 0xD8499C
	public virtual Type get_ValueType() { }

	// RVA: 0xD849B0
	public virtual int get_Depth() { }

	// RVA: 0xD84A2C
	public virtual string get_Path() { }

	// RVA: 0xD84B5C
	public CultureInfo get_Culture() { }

	// RVA: 0xD84BD8
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xD84BE0
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0xD84CA0
	protected void .ctor() { }

	// RVA: 0xD84D44
	private void Push(JsonContainerType value) { }

	// RVA: 0xD851FC
	private JsonContainerType Pop() { }

	// RVA: 0xD85424
	private JsonContainerType Peek() { }

	// RVA: -1
	public abstract bool Read() { }

	// RVA: 0xD8542C
	public virtual System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xD85BA0
	internal System.Nullable<System.Int32> ReadInt32String(string s) { }

	// RVA: 0xD85E20
	public virtual string ReadAsString() { }

	// RVA: 0xD861EC
	public virtual Byte[] ReadAsBytes() { }

	// RVA: 0xD86940
	internal Byte[] ReadArrayIntoByteArray() { }

	// RVA: 0xD86ABC
	private bool ReadArrayElementIntoByteArrayReportDone(System.Collections.Generic.List<System.Byte> buffer) { }

	// RVA: 0xD86CA8
	public virtual System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xD87018
	internal System.Nullable<System.Double> ReadDoubleString(string s) { }

	// RVA: 0xD87298
	public virtual System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xD87660
	internal System.Nullable<System.Boolean> ReadBooleanString(string s) { }

	// RVA: 0xD87880
	public virtual System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xD87D40
	internal System.Nullable<System.Decimal> ReadDecimalString(string s) { }

	// RVA: 0xD8805C
	public virtual System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xD8839C
	internal System.Nullable<System.DateTime> ReadDateTimeString(string s) { }

	// RVA: 0xD88748
	public virtual System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xD88A80
	internal System.Nullable<System.DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0xD868F0
	internal void ReaderReadAndAssert() { }

	// RVA: 0xD88DF8
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0xD866D0
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0xD88EB8
	public void Skip() { }

	// RVA: 0xD86AB0
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0xD88F54
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0xD859A0
	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0xD8907C
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0xD85160
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0xD88F5C
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0xD891A0
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0xD890C4
	private void SetFinished() { }

	// RVA: 0xD890F0
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0xD892C0
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD89354
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD89378
	public virtual void Close() { }

	// RVA: 0xD89390
	internal void ReadAndAssert() { }

	// RVA: 0xD89474
	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	// RVA: 0xD894CC
	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	// RVA: 0xD897F4
	internal bool ReadAndMoveToContent() { }

	// RVA: 0xD89860
	internal bool MoveToContent() { }

	// RVA: 0xD85884
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

	// RVA: 0xD898BC
	public void .ctor() { }

	// RVA: 0xD89944
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD899C8
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0xD85178
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0xD85910
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xD89A70
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

// Namespace: Newtonsoft.Json
public sealed class JsonRequiredAttribute
{
	// Methods

	// RVA: 0xD89CD4
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

	// RVA: 0xD89CDC
	public void .ctor() { }

	// RVA: 0xD89D64
	public void .ctor(string message) { }

	// RVA: 0xD89DD0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0xD89E4C
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xD89ED0
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0xD893F0
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0xD89F78
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0xD8A008
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

	// RVA: 0xD8A26C
	public virtual void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xD8A320
	public virtual void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xD8A3D4
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xD8A450
	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0xD8A4CC
	public virtual ITraceWriter get_TraceWriter() { }

	// RVA: 0xD8A4D4
	public virtual void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0xD8A4DC
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xD8A4E4
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xD8A550
	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0xD8A5BC
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xD8A628
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xD8A694
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xD8A700
	public virtual NullValueHandling get_NullValueHandling() { }

	// RVA: 0xD8A708
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xD8A774
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0xD8A7E0
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xD8A84C
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0xD8A8B8
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xD8A8C0
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xD8A92C
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0xD8A9EC
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0xD8A9F4
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xD8AAD8
	public virtual StreamingContext get_Context() { }

	// RVA: 0xD8AAE4
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0xD8AAF0
	public virtual Formatting get_Formatting() { }

	// RVA: 0xD8ABC8
	public virtual System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xD8ABD0
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0xD8ACA8
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xD833B0
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0xD8AD20
	public void .ctor() { }

	// RVA: 0xD8AE8C
	public static JsonSerializer Create() { }

	// RVA: 0xD8AEE0
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0xD8C090
	public static JsonSerializer CreateDefault() { }

	// RVA: 0xD82C20
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0xD8AF50
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	// RVA: 0xD8CBBC
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xD8CBCC
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0x316B894
	public T Deserialize(JsonReader reader) { }

	// RVA: 0xD835C0
	public object Deserialize(JsonReader reader, Type objectType) { }

	// RVA: 0xD8DF60
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xD8CE50
	internal void SetupReader(JsonReader reader, CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling>& previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling>& previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling>& previousFloatParseHandling, System.Nullable<System.Int32>& previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xD8DA40
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, System.Nullable<Newtonsoft.Json.DateTimeZoneHandling> previousDateTimeZoneHandling, System.Nullable<Newtonsoft.Json.DateParseHandling> previousDateParseHandling, System.Nullable<Newtonsoft.Json.FloatParseHandling> previousFloatParseHandling, System.Nullable<System.Int32> previousMaxDepth, string previousDateFormatString) { }

	// RVA: 0xD83140
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xD8E1EC
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0xD8D9AC
	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	// RVA: 0xD8E200
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xD8F79C
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0xD8F824
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0xD8F82C
	internal static JsonConverter GetMatchingConverter(System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> converters, Type objectType) { }

	// RVA: 0xD8F9C8
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

	// RVA: 0xD8C540
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0xD8C618
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0xD8C6F0
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0xD8C7C8
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0xD8C8A0
	public DefaultValueHandling get_DefaultValueHandling() { }

	// RVA: 0xD8F9EC
	public System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> get_Converters() { }

	// RVA: 0xD8C468
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0xD8C1E0
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0xD8C2B8
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xD8C390
	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0xD8C978
	public ConstructorHandling get_ConstructorHandling() { }

	// RVA: 0xD8F9F4
	public IContractResolver get_ContractResolver() { }

	// RVA: 0xD8F9FC
	public IEqualityComparer get_EqualityComparer() { }

	// RVA: 0xD8FA04
	public System.Func<Newtonsoft.Json.Serialization.IReferenceResolver> get_ReferenceResolverProvider() { }

	// RVA: 0xD8FA0C
	public ITraceWriter get_TraceWriter() { }

	// RVA: 0xD8FA14
	public ISerializationBinder get_SerializationBinder() { }

	// RVA: 0xD8FA1C
	public System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> get_Error() { }

	// RVA: 0xD8CA50
	public StreamingContext get_Context() { }

	// RVA: 0xD8FA24
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

	// RVA: 0xD83430
	public void .ctor(TextReader reader) { }

	// RVA: 0xD8FAB4
	public JsonNameTable get_PropertyNameTable() { }

	// RVA: 0xD8FABC
	public void set_PropertyNameTable(JsonNameTable value) { }

	// RVA: 0xD8FAC4
	private void EnsureBufferNotEmpty() { }

	// RVA: 0xD8FB28
	private void SetNewLine(bool hasNextChar) { }

	// RVA: 0xD8FB9C
	private void OnNewLine(int pos) { }

	// RVA: 0xD8FBAC
	private void ParseString(Char quote, ReadType readType) { }

	// RVA: 0xD90398
	private void ParseReadString(Char quote, ReadType readType) { }

	// RVA: 0xD908B0
	private static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	// RVA: 0xD8FC00
	private void ShiftBufferIfNeeded() { }

	// RVA: 0xD908C4
	private int ReadData(bool append) { }

	// RVA: 0xD9096C
	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	// RVA: 0xD908CC
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0xD90B30
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0xD90BC8
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0xD90C48
	public override bool Read() { }

	// RVA: 0xD920AC
	public override System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xD926B8
	public override System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xD92DEC
	public override string ReadAsString() { }

	// RVA: 0xD92E54
	public override Byte[] ReadAsBytes() { }

	// RVA: 0xD92778
	private object ReadStringValue(ReadType readType) { }

	// RVA: 0xD93A24
	private object FinishReadQuotedStringValue(ReadType readType) { }

	// RVA: 0xD9367C
	private JsonReaderException CreateUnexpectedCharacterException(Char c) { }

	// RVA: 0xD94080
	public override System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xD9360C
	private void ProcessValueComma() { }

	// RVA: 0xD9216C
	private object ReadNumberValue(ReadType readType) { }

	// RVA: 0xD94724
	private object FinishReadQuotedNumber(ReadType readType) { }

	// RVA: 0xD948B0
	public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xD94980
	public override System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xD94A50
	public override System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xD93508
	private void HandleNull() { }

	// RVA: 0xD93888
	private void ReadFinished() { }

	// RVA: 0xD93498
	private bool ReadNullChar() { }

	// RVA: 0xD90F10
	private void EnsureBuffer() { }

	// RVA: 0xD8FCDC
	private void ReadStringIntoBuffer(Char quote) { }

	// RVA: 0xD94D40
	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	// RVA: 0xD94CEC
	private void WriteCharToBuffer(Char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0xD94E28
	private Char ConvertUnicode(bool enoughChars) { }

	// RVA: 0xD94C48
	private Char ParseUnicode() { }

	// RVA: 0xD94F88
	private void ReadNumberIntoBuffer() { }

	// RVA: 0xD95018
	private bool ReadNumberCharIntoBuffer(Char currentChar, int charPos) { }

	// RVA: 0xD951B0
	private void ClearRecentString() { }

	// RVA: 0xD91830
	private bool ParsePostValue(bool ignoreComments) { }

	// RVA: 0xD91644
	private bool ParseObject() { }

	// RVA: 0xD951BC
	private bool ParseProperty() { }

	// RVA: 0xD954E4
	private bool ValidIdentifierChar(Char value) { }

	// RVA: 0xD9555C
	private void ParseUnquotedProperty() { }

	// RVA: 0xD95650
	private bool ReadUnquotedPropertyReportIfDone(Char currentChar, int initialPosition) { }

	// RVA: 0xD90F80
	private bool ParseValue() { }

	// RVA: 0xD9386C
	private void ProcessLineFeed() { }

	// RVA: 0xD937A8
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0xD91B90
	private void EatWhitespace() { }

	// RVA: 0xD95B54
	private void ParseConstructor() { }

	// RVA: 0xD93D08
	private void ParseNumber(ReadType readType) { }

	// RVA: 0xD95FD0
	private void ParseReadNumber(ReadType readType, Char firstChar, int initialPosition) { }

	// RVA: 0xD97308
	private JsonReaderException ThrowReaderError(string message, Exception ex) { }

	// RVA: 0xD97404
	private static object BigIntegerParse(string number, CultureInfo culture) { }

	// RVA: 0xD91CAC
	private void ParseComment(bool setToken) { }

	// RVA: 0xD9748C
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0xD97504
	private bool MatchValue(string value) { }

	// RVA: 0xD975C4
	private bool MatchValue(bool enoughChars, string value) { }

	// RVA: 0xD93DDC
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0xD976A4
	private bool IsSeparator(Char c) { }

	// RVA: 0xD95854
	private void ParseTrue() { }

	// RVA: 0xD94B10
	private void ParseNull() { }

	// RVA: 0xD95E9C
	private void ParseUndefined() { }

	// RVA: 0xD959D4
	private void ParseFalse() { }

	// RVA: 0xD93C88
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0xD9787C
	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	// RVA: 0xD93F80
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0xD97AD8
	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	// RVA: 0xD94000
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0xD97D34
	private object ParseNumberNaN(ReadType readType, bool matched) { }

	// RVA: 0xD97F90
	public override void Close() { }

	// RVA: 0xD98014
	public bool HasLineInfo() { }

	// RVA: 0xD9801C
	public int get_LineNumber() { }

	// RVA: 0xD98078
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

	// RVA: 0xD98084
	private Base64Encoder get_Base64Encoder() { }

	// RVA: 0xD98128
	public Char get_QuoteChar() { }

	// RVA: 0xD82F04
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0xD981E8
	public override void Close() { }

	// RVA: 0xD98358
	private void CloseBufferAndWriter() { }

	// RVA: 0xD983C0
	public override void WriteStartObject() { }

	// RVA: 0xD98468
	public override void WriteStartArray() { }

	// RVA: 0xD984CC
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xD9859C
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xD986BC
	public override void WritePropertyName(string name) { }

	// RVA: 0xD98834
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xD98910
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0xD98168
	private void UpdateCharEscapeFlags() { }

	// RVA: 0xD98990
	protected override void WriteIndent() { }

	// RVA: 0xD98B58
	private int SetIndentChars() { }

	// RVA: 0xD98C6C
	protected override void WriteValueDelimiter() { }

	// RVA: 0xD98C98
	protected override void WriteIndentSpace() { }

	// RVA: 0xD98CC4
	private void WriteValueInternal(string value, JsonToken token) { }

	// RVA: 0xD98CEC
	public override void WriteValue(object value) { }

	// RVA: 0xD98F84
	public override void WriteNull() { }

	// RVA: 0xD9901C
	public override void WriteUndefined() { }

	// RVA: 0xD990B4
	public override void WriteRaw(string json) { }

	// RVA: 0xD990E0
	public override void WriteValue(string value) { }

	// RVA: 0xD98748
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0xD991F4
	public override void WriteValue(int value) { }

	// RVA: 0xD992E4
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xD993D4
	public override void WriteValue(Int64 value) { }

	// RVA: 0xD9941C
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xD9953C
	public override void WriteValue(float value) { }

	// RVA: 0xD995FC
	public override void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xD997D8
	public override void WriteValue(Double value) { }

	// RVA: 0xD99898
	public override void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xD99A74
	public override void WriteValue(bool value) { }

	// RVA: 0xD99B80
	public override void WriteValue(Int16 value) { }

	// RVA: 0xD99BC8
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xD99C10
	public override void WriteValue(Char value) { }

	// RVA: 0xD99D44
	public override void WriteValue(Byte value) { }

	// RVA: 0xD99D8C
	public override void WriteValue(SByte value) { }

	// RVA: 0xD99DD4
	public override void WriteValue(Decimal value) { }

	// RVA: 0xD99E80
	public override void WriteValue(DateTime value) { }

	// RVA: 0xD9A090
	private int WriteValueToBuffer(DateTime value) { }

	// RVA: 0xD9A1D4
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xD9A368
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xD9A544
	private int WriteValueToBuffer(DateTimeOffset value) { }

	// RVA: 0xD9A6E8
	public override void WriteValue(Guid value) { }

	// RVA: 0xD9A7FC
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xD9A940
	public override void WriteValue(Uri value) { }

	// RVA: 0xD9AA34
	public override void WriteComment(string text) { }

	// RVA: 0xD991A4
	private void EnsureWriteBuffer() { }

	// RVA: 0xD9932C
	private void WriteIntegerValue(Int64 value) { }

	// RVA: 0xD994C0
	private void WriteIntegerValue(UInt64 value, bool negative) { }

	// RVA: 0xD9AB00
	private int WriteNumberToBuffer(UInt64 value, bool negative) { }

	// RVA: 0xD9923C
	private void WriteIntegerValue(int value) { }

	// RVA: 0xD9ACFC
	private void WriteIntegerValue(UInt32 value, bool negative) { }

	// RVA: 0xD9AC10
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

	// RVA: 0xD9AD78
	internal static State[][] BuildStateArray() { }

	// RVA: 0xD9AF64
	private static void .cctor() { }

	// RVA: 0xD9B28C
	public bool get_CloseOutput() { }

	// RVA: 0xD9B294
	public void set_CloseOutput(bool value) { }

	// RVA: 0xD9B29C
	public bool get_AutoCompleteOnClose() { }

	// RVA: 0xD9B2A4
	public void set_AutoCompleteOnClose(bool value) { }

	// RVA: 0xD98B04
	protected internal int get_Top() { }

	// RVA: 0xD9B2B4
	public WriteState get_WriteState() { }

	// RVA: 0xD9B368
	internal string get_ContainerPath() { }

	// RVA: 0xD9B418
	public string get_Path() { }

	// RVA: 0xD9B548
	public Formatting get_Formatting() { }

	// RVA: 0xD830D4
	public void set_Formatting(Formatting value) { }

	// RVA: 0xD9B550
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0xD8F568
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0xD9B558
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0xD8F5D4
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0xD9B560
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0xD8F6AC
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0xD9B568
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0xD9B56C
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0xD8F640
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	// RVA: 0xD9B574
	public string get_DateFormatString() { }

	// RVA: 0xD9B57C
	public void set_DateFormatString(string value) { }

	// RVA: 0xD8F720
	public CultureInfo get_Culture() { }

	// RVA: 0xD9B584
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xD98130
	protected void .ctor() { }

	// RVA: 0xD9B58C
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0xD9B5A4
	private void Push(JsonContainerType value) { }

	// RVA: 0xD9B73C
	private JsonContainerType Pop() { }

	// RVA: 0xD9B2AC
	private JsonContainerType Peek() { }

	// RVA: 0xD982C8
	public virtual void Close() { }

	// RVA: 0xD9B8BC
	public virtual void WriteStartObject() { }

	// RVA: 0xD9B900
	public virtual void WriteEndObject() { }

	// RVA: 0xD9B90C
	public virtual void WriteStartArray() { }

	// RVA: 0xD9B950
	public virtual void WriteEndArray() { }

	// RVA: 0xD9B958
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0xD9B99C
	public virtual void WriteEndConstructor() { }

	// RVA: 0xD9B9A4
	public virtual void WritePropertyName(string name) { }

	// RVA: 0xD9B9D0
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0xD9B9E0
	public virtual void WriteEnd() { }

	// RVA: 0xD9BAF8
	public void WriteToken(JsonReader reader) { }

	// RVA: 0xD9BB78
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	// RVA: 0xD9BC04
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0xD9C400
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0xD9C7D8
	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	// RVA: 0xD9C678
	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	// RVA: 0xD9C8A0
	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	// RVA: 0xD9C6E4
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0xD9B9E8
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0xD9B834
	private void AutoCompleteAll() { }

	// RVA: 0xD9C908
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0xD9C9A8
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0xD9CA74
	private int CalculateLevelsToComplete(JsonContainerType type) { }

	// RVA: 0xD9CBE0
	private void UpdateCurrentState() { }

	// RVA: 0xD9CC98
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0xD9CC9C
	protected virtual void WriteIndent() { }

	// RVA: 0xD9CCA0
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0xD9CCA4
	protected virtual void WriteIndentSpace() { }

	// RVA: 0xD9CCA8
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0xD9CED8
	public virtual void WriteNull() { }

	// RVA: 0xD9CEF4
	public virtual void WriteUndefined() { }

	// RVA: 0xD9CF10
	public virtual void WriteRaw(string json) { }

	// RVA: 0xD9CF14
	public virtual void WriteRawValue(string json) { }

	// RVA: 0xD9CF68
	public virtual void WriteValue(string value) { }

	// RVA: 0xD9CF84
	public virtual void WriteValue(int value) { }

	// RVA: 0xD9CFA0
	public virtual void WriteValue(UInt32 value) { }

	// RVA: 0xD9CFBC
	public virtual void WriteValue(Int64 value) { }

	// RVA: 0xD9CFD8
	public virtual void WriteValue(UInt64 value) { }

	// RVA: 0xD9CFF4
	public virtual void WriteValue(float value) { }

	// RVA: 0xD9D010
	public virtual void WriteValue(Double value) { }

	// RVA: 0xD9D02C
	public virtual void WriteValue(bool value) { }

	// RVA: 0xD9D048
	public virtual void WriteValue(Int16 value) { }

	// RVA: 0xD9D064
	public virtual void WriteValue(UInt16 value) { }

	// RVA: 0xD9D080
	public virtual void WriteValue(Char value) { }

	// RVA: 0xD9D09C
	public virtual void WriteValue(Byte value) { }

	// RVA: 0xD9D0B8
	public virtual void WriteValue(SByte value) { }

	// RVA: 0xD9D0D4
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0xD9D0F0
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0xD9D10C
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0xD9D128
	public virtual void WriteValue(Guid value) { }

	// RVA: 0xD9D144
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0xD9D160
	public virtual void WriteValue(System.Nullable<System.Int32> value) { }

	// RVA: 0xD9D2BC
	public virtual void WriteValue(System.Nullable<System.UInt32> value) { }

	// RVA: 0xD9D418
	public virtual void WriteValue(System.Nullable<System.Int64> value) { }

	// RVA: 0xD9D574
	public virtual void WriteValue(System.Nullable<System.UInt64> value) { }

	// RVA: 0xD9D6D0
	public virtual void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xD9D82C
	public virtual void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xD9D988
	public virtual void WriteValue(System.Nullable<System.Boolean> value) { }

	// RVA: 0xD9DAE4
	public virtual void WriteValue(System.Nullable<System.Int16> value) { }

	// RVA: 0xD9DC40
	public virtual void WriteValue(System.Nullable<System.UInt16> value) { }

	// RVA: 0xD9DD9C
	public virtual void WriteValue(System.Nullable<System.Char> value) { }

	// RVA: 0xD9DEF8
	public virtual void WriteValue(System.Nullable<System.Byte> value) { }

	// RVA: 0xD9E054
	public virtual void WriteValue(System.Nullable<System.SByte> value) { }

	// RVA: 0xD9E1B0
	public virtual void WriteValue(System.Nullable<System.Decimal> value) { }

	// RVA: 0xD9E348
	public virtual void WriteValue(System.Nullable<System.DateTime> value) { }

	// RVA: 0xD9E4A4
	public virtual void WriteValue(System.Nullable<System.DateTimeOffset> value) { }

	// RVA: 0xD9E5F8
	public virtual void WriteValue(System.Nullable<System.Guid> value) { }

	// RVA: 0xD9E74C
	public virtual void WriteValue(System.Nullable<System.TimeSpan> value) { }

	// RVA: 0xD9E8A8
	public virtual void WriteValue(Byte[] value) { }

	// RVA: 0xD9E8D8
	public virtual void WriteValue(Uri value) { }

	// RVA: 0xD98E48
	public virtual void WriteValue(object value) { }

	// RVA: 0xD9FAE4
	public virtual void WriteComment(string text) { }

	// RVA: 0xD9FAEC
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD9FB80
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD9EA78
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xD9FBA0
	private static void ResolveConvertibleValue(IConvertible convertible, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0xD9E9A8
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0xD9FD78
	protected void SetWriteState(JsonToken token, object value) { }

	// RVA: 0xD9B908
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0xD9871C
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0xD990DC
	internal void InternalWriteRaw() { }

	// RVA: 0xD98424
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0xD98E30
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0xD9AAF8
	internal void InternalWriteComment() { }

}

// Namespace: Newtonsoft.Json
[Serializable]
public class JsonWriterException
{
	// Fields
	private readonly string <Path>k__BackingField; // 0x90

	// Methods

	// RVA: 0xDA0004
	public void .ctor() { }

	// RVA: 0xDA000C
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xDA0014
	public void .ctor(string message, string path, Exception innerException) { }

	// RVA: 0xDA004C
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0xDA0084
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

	// RVA: 0xDA014C
	public void .ctor(TextWriter writer) { }

	// RVA: 0xDA0274
	private void ValidateEncode(Byte[] buffer, int index, int count) { }

	// RVA: 0xDA0358
	public void Encode(Byte[] buffer, int index, int count) { }

	// RVA: 0xDA069C
	private void StoreLeftOverBytes(Byte[] buffer, int index, int count) { }

	// RVA: 0xDA05B0
	private bool FulfillFromLeftover(Byte[] buffer, int index, int count) { }

	// RVA: 0xDA07B8
	public void Flush() { }

	// RVA: 0xDA0674
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

	// RVA: 0x30B3158
	public void .ctor(System.Collections.Generic.IEqualityComparer<TFirst> firstEqualityComparer, System.Collections.Generic.IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }

	// RVA: 0x316B894
	public void Set(TFirst first, TSecond second) { }

	// RVA: 0x316B894
	public bool TryGetByFirst(TFirst first, TSecond second) { }

	// RVA: 0x316B894
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

	// RVA: 0xDA0870
	internal static object Get(bool value) { }

	// RVA: 0xDA090C
	internal static object Get(int value) { }

	// RVA: 0xDA0C78
	internal static object Get(Int64 value) { }

	// RVA: 0xDA0F18
	internal static object Get(Decimal value) { }

	// RVA: 0xDA1010
	internal static object Get(Double value) { }

	// RVA: 0xDA1178
	private static void .cctor() { }

}

// Namespace: 
private static class EmptyArrayContainer<T0>
{
	// Fields
	public static readonly T[] Empty; // 0x0

	// Methods

	// RVA: 0x30B71FC
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class CollectionUtils
{
	// Methods

	// RVA: 0x30B3E68
	public static bool IsNullOrEmpty(System.Collections.Generic.ICollection<T> collection) { }

	// RVA: 0x30B933C
	public static void AddRange(System.Collections.Generic.IList<T> initial, System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0xDA1698
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0xDA19AC
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0xDA1AD0
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	// RVA: 0x30B4D6C
	public static int IndexOf(System.Collections.Generic.IEnumerable<T> collection, System.Func<T,System.Boolean> predicate) { }

	// RVA: 0x316B894
	public static bool Contains(System.Collections.Generic.List<T> list, T value, IEqualityComparer comparer) { }

	// RVA: 0x316B894
	public static int IndexOfReference(System.Collections.Generic.List<T> list, T item) { }

	// RVA: 0x30B8148
	public static void FastReverse(System.Collections.Generic.List<T> list) { }

	// RVA: 0xDA1E44
	private static System.Collections.Generic.IList<System.Int32> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0xDA21A8
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0xDA248C
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0xDA2638
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

	// RVA: 0x30B5790
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

	// RVA: 0x316B894
	public virtual void Add(T item) { }

	// RVA: 0x30B2870
	public virtual void Clear() { }

	// RVA: 0x316B894
	public virtual bool Contains(T item) { }

	// RVA: 0x30B2D20
	public virtual void CopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x30B199C
	public virtual int get_Count() { }

	// RVA: 0x30B171C
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x316B894
	public virtual bool Remove(T item) { }

	// RVA: 0x30B1CD4
	public virtual System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30B1ACC
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x30B183C
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x30B1ACC
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x30B29E8
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x30B2B50
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x30B171C
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x30B2CB8
	private void System.Collections.IList.Remove(object value) { }

	// RVA: -1
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x30B2B50
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x30B2D20
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x30B171C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30B1CD4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30B8148
	private static void VerifyValueType(object value) { }

	// RVA: 0x30B3E68
	private static bool IsCompatibleObject(object value) { }

	// RVA: 0x30B1CD4
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

	// RVA: 0xDA2870
	public Type get_Type() { }

	// RVA: 0xDA2878
	public PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0xDA2880
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

	// RVA: 0xDA333C
	public void .ctor() { }

	// RVA: 0xDA77D8
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

	// RVA: 0xDA28C8
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0xDA2938
	public static PrimitiveTypeCode GetTypeCode(Type t, bool isEnum) { }

	// RVA: 0xDA2E14
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0xDA2F2C
	public static bool IsConvertible(Type t) { }

	// RVA: 0xDA2FE4
	public static TimeSpan ParseTimeSpan(string input) { }

	// RVA: 0xDA30AC
	private static System.Func<System.Object,System.Object> CreateCastConverter(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,System.Type> t) { }

	// RVA: 0xDA3344
	internal static BigInteger ToBigInteger(object value) { }

	// RVA: 0xDA3830
	public static object FromBigInteger(BigInteger i, Type targetType) { }

	// RVA: 0xDA3D68
	public static object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0xDA4CE4
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, object value) { }

	// RVA: 0xDA4020
	private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, object value) { }

	// RVA: 0xDA5280
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0xDA5008
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0xDA4F24
	public static bool VersionTryParse(string input, Version result) { }

	// RVA: 0xDA4E38
	public static bool IsInteger(object value) { }

	// RVA: 0xDA5450
	public static ParseResult Int32TryParse(Char[] chars, int start, int length, int value) { }

	// RVA: 0xDA5608
	public static ParseResult Int64TryParse(Char[] chars, int start, int length, Int64 value) { }

	// RVA: 0xDA5798
	public static ParseResult DecimalTryParse(Char[] chars, int start, int length, Decimal value) { }

	// RVA: 0xDA62BC
	public static bool TryConvertGuid(string s, Guid g) { }

	// RVA: 0xDA631C
	public static bool TryHexTextToInt(Char[] text, int start, int end, int value) { }

	// RVA: 0xDA63F8
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

	// RVA: 0xDA78B0
	private static void .cctor() { }

	// RVA: 0xDA7B40
	public bool Parse(Char[] text, int startIndex, int length) { }

	// RVA: 0xDA7D40
	private bool ParseDate(int start) { }

	// RVA: 0xDA8040
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0xDA82B8
	private bool ParseTime(int start) { }

	// RVA: 0xDA88C4
	private bool ParseZone(int start) { }

	// RVA: 0xDA8104
	private bool Parse4Digit(int start, int num) { }

	// RVA: 0xDA8208
	private bool Parse2Digit(int start, int num) { }

	// RVA: 0xDA7FEC
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

	// RVA: 0xDA8C0C
	private static void .cctor() { }

	// RVA: 0xDA8D10
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0xDA8D9C
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0xDA8F1C
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0xDA90B8
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0xDA91D0
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0xDA92E4
	private static Int64 ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0xDA9460
	private static Int64 ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0xDA9628
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0xDA977C
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0xDA9804
	internal static Int64 ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0xDA96F4
	private static Int64 UniversalTicksToJavaScriptTicks(Int64 universalTicks) { }

	// RVA: 0xDA994C
	internal static DateTime ConvertJavaScriptTicksToDateTime(Int64 javaScriptTicks) { }

	// RVA: 0xDA99DC
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, DateTime dt) { }

	// RVA: 0xDAA02C
	internal static bool TryParseDateTimeOffsetIso(StringReference text, DateTimeOffset dt) { }

	// RVA: 0xDA9F28
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0xDAA308
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xDAAA3C
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xDAAD5C
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xDAB2A4
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xDAB610
	private static bool TryParseMicrosoftDate(StringReference text, Int64 ticks, TimeSpan offset, DateTimeKind kind) { }

	// RVA: 0xDAA754
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, DateTime dt) { }

	// RVA: 0xDAA94C
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, DateTime dt) { }

	// RVA: 0xDAB010
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, DateTimeOffset dt) { }

	// RVA: 0xDAB1E4
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, DateTimeOffset dt) { }

	// RVA: 0xDAB8B0
	private static bool TryReadOffset(StringReference offsetText, int startIndex, TimeSpan offset) { }

	// RVA: 0xDABA54
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0xDABBE4
	internal static int WriteDateTimeString(Char[] chars, int start, DateTime value, System.Nullable<System.TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0xDAC4FC
	internal static int WriteDefaultIsoDate(Char[] chars, int start, DateTime dt) { }

	// RVA: 0xDACD18
	private static void CopyIntToCharArray(Char[] chars, int start, int value, int digits) { }

	// RVA: 0xDAC230
	internal static int WriteDateTimeOffset(Char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0xDACD84
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0xDACABC
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

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }

	// RVA: -1
	public DictionaryEntry get_Entry() { }

	// RVA: 0x30B1CD4
	public object get_Key() { }

	// RVA: 0x30B1CD4
	public object get_Value() { }

	// RVA: 0x30B1CD4
	public object get_Current() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
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

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
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

	// RVA: 0x30B1CD4
	internal System.Collections.Generic.IDictionary<TKey,TValue> get_GenericDictionary() { }

	// RVA: 0x316B894
	public void Add(TKey key, TValue value) { }

	// RVA: 0x316B894
	public bool ContainsKey(TKey key) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.ICollection<TKey> get_Keys() { }

	// RVA: 0x316B894
	public bool Remove(TKey key) { }

	// RVA: 0x316B894
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.ICollection<TValue> get_Values() { }

	// RVA: 0x316B894
	public TValue get_Item(TKey key) { }

	// RVA: 0x316B894
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x316B894
	public void Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x316B894
	public bool Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30B2D20
	public void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B171C
	public bool get_IsReadOnly() { }

	// RVA: 0x316B894
	public bool Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30B2F18
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x30B1D84
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x30B2F18
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x30B1CD4
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x30B183C
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x30B171C
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x30B1CD4
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x30B2CB8
	public void Remove(object key) { }

	// RVA: 0x30B1CD4
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x30B2D20
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30B171C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30B1CD4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30B1CD4
	public object get_UnderlyingDictionary() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class DynamicProxy<T0>
{
	// Methods

	// RVA: 0x316B894
	public virtual System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(T instance) { }

	// RVA: 0x316B894
	public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, object result) { }

	// RVA: 0x316B894
	public virtual bool TryConvert(T instance, ConvertBinder binder, object result) { }

	// RVA: 0x316B894
	public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, object result) { }

	// RVA: 0x316B894
	public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes) { }

	// RVA: 0x316B894
	public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder) { }

	// RVA: 0x316B894
	public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, object result) { }

	// RVA: 0x316B894
	public virtual bool TryGetMember(T instance, GetMemberBinder binder, object result) { }

	// RVA: 0x316B894
	public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, object result) { }

	// RVA: 0x316B894
	public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, object result) { }

	// RVA: 0x316B894
	public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value) { }

	// RVA: 0x316B894
	public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value) { }

	// RVA: 0x316B894
	public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, object result) { }

	// RVA: 0x30B2870
	public void .ctor() { }

}

// Namespace: 
private sealed class Fallback
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x30B1D84
	public virtual DynamicMetaObject Invoke(DynamicMetaObject errorSuggestion) { }

}

// Namespace: 
private sealed class GetBinderAdapter
{
	// Methods

	// RVA: 0x30B2CB8
	internal void .ctor(InvokeMemberBinder binder) { }

	// RVA: 0x30B1E68
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

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
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

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
	internal DynamicMetaObject <BindBinaryOperation>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public UnaryOperationBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
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

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
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

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
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

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
	internal DynamicMetaObject <BindDeleteIndex>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public GetMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
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

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
	internal DynamicMetaObject <BindSetMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public DeleteMemberBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
	internal DynamicMetaObject <BindDeleteMember>b__0(DynamicMetaObject e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public ConvertBinder binder; // 0x0
	public Newtonsoft.Json.Utilities.DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
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

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
	internal DynamicMetaObject <BindInvokeMember>b__0(DynamicMetaObject e) { }

	// RVA: 0x30B1D84
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

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
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

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
	internal DynamicMetaObject <BindInvoke>b__0(DynamicMetaObject e) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class DynamicProxyMetaObject<T0>
{
	// Fields
	private readonly Newtonsoft.Json.Utilities.DynamicProxy<T> _proxy; // 0x0

	// Methods

	// RVA: 0x316B894
	internal void .ctor(Expression expression, T value, Newtonsoft.Json.Utilities.DynamicProxy<T> proxy) { }

	// RVA: 0x30B183C
	private bool IsOverridden(string method) { }

	// RVA: 0x30B1D84
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x30B1E68
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x30B1D84
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x30B1D84
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }

	// RVA: 0x30B1E68
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x30B1E68
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x30B1E68
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x30B1E68
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	// RVA: 0x30B1D84
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	// RVA: 0x30B1E68
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x30B1ED8
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: 0x30B1E68
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x30B5790
	private static Expression[] get_NoArgs() { }

	// RVA: 0x30B57C8
	private static System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> GetArgs(DynamicMetaObject[] args) { }

	// RVA: 0x30B57C8
	private static Expression[] GetArgArray(DynamicMetaObject[] args) { }

	// RVA: 0x30B58A8
	private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value) { }

	// RVA: 0x30B57C8
	private static ConstantExpression Constant(DynamicMetaObjectBinder binder) { }

	// RVA: 0x30B1FBC
	private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Fallback fallback, Fallback fallbackInvoke) { }

	// RVA: 0x30B1FBC
	private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, DynamicMetaObject fallbackResult, Fallback fallbackInvoke) { }

	// RVA: 0x30B1F4C
	private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> args, Fallback fallback) { }

	// RVA: 0x30B1F4C
	private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Fallback fallback) { }

	// RVA: 0x30B1CD4
	private BindingRestrictions GetRestrictions() { }

	// RVA: 0x30B1CD4
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

	// RVA: 0xDAD0A4
	private static void Init() { }

	// RVA: 0xDAD2A0
	private static object CreateSharpArgumentInfoArray(int[] values) { }

	// RVA: 0xDAD5B0
	private static void CreateMemberCalls() { }

	// RVA: 0xDADAE8
	public static CallSiteBinder GetMember(string name, Type context) { }

	// RVA: 0xDADD00
	public static CallSiteBinder SetMember(string name, Type context) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class DynamicUtils
{
	// Methods

	// RVA: 0xDACF80
	public static System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowGetBinderMember
{
	// Fields
	private readonly GetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0xDADF18
	public void .ctor(GetMemberBinder innerBinder) { }

	// RVA: 0xDADF5C
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowSetBinderMember
{
	// Fields
	private readonly SetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0xDAE0F4
	public void .ctor(SetMemberBinder innerBinder) { }

	// RVA: 0xDAE138
	public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class NoThrowExpressionVisitor
{
	// Fields
	internal static readonly object ErrorResult; // 0x0

	// Methods

	// RVA: 0xDAE290
	protected override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0xDAE0EC
	public void .ctor() { }

	// RVA: 0xDAE388
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

	// RVA: 0xDAE410
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

	// RVA: 0xDAFECC
	private static void .cctor() { }

	// RVA: 0xDAFF38
	public void .ctor() { }

	// RVA: 0xDAFF40
	internal string <InitializeValuesAndNames>b__3_0(EnumMemberAttribute a) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class EnumUtils
{
	// Fields
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum; // 0x0
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x8

	// Methods

	// RVA: 0xDAE484
	private static EnumInfo InitializeValuesAndNames(Newtonsoft.Json.Utilities.StructMultiKey<System.Type,Newtonsoft.Json.Serialization.NamingStrategy> key) { }

	// RVA: 0xDAEDBC
	public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, string name) { }

	// RVA: 0xDAEF78
	private static string InternalFlagsFormat(EnumInfo entry, UInt64 result) { }

	// RVA: 0xDAF1EC
	public static EnumInfo GetEnumValuesAndNames(Type enumType) { }

	// RVA: 0xDAEA14
	private static UInt64 ToUInt64(object value) { }

	// RVA: 0xDAF2C4
	public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	// RVA: 0xDAFC7C
	private static System.Nullable<System.Int32> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0xDAFB7C
	private static System.Nullable<System.Int32> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0xDAFD94
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class FSharpFunction
{
	// Fields
	private readonly object _instance; // 0x10
	private readonly Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> _invoker; // 0x18

	// Methods

	// RVA: 0xDAFF5C
	public void .ctor(object instance, Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoker) { }

	// RVA: 0xDAFFAC
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

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal System.Tuple<TKey,TValue> <BuildMapCreator>b__55_1(System.Collections.Generic.KeyValuePair<TKey,TValue> kv) { }

}

// Namespace: 
private sealed class <>c__DisplayClass52_0
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> invoke; // 0x18

	// Methods

	// RVA: 0xDB0B34
	public void .ctor() { }

	// RVA: 0xDB0EB0
	internal object <CreateFSharpFuncCall>b__0(object target, object[] args) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0<T0, T1>
{
	// Fields
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> ctorDelegate; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1D84
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

	// RVA: 0xDAFFF0
	private void .ctor(Assembly fsharpCoreAssembly) { }

	// RVA: 0xDB0878
	public static FSharpUtils get_Instance() { }

	// RVA: 0xDB08F4
	private void set_FSharpCoreAssembly(Assembly value) { }

	// RVA: 0xDB08FC
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_IsUnion() { }

	// RVA: 0xDB0904
	private void set_IsUnion(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDB090C
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCases() { }

	// RVA: 0xDB0914
	private void set_GetUnionCases(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDB091C
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionTagReader() { }

	// RVA: 0xDB0924
	private void set_PreComputeUnionTagReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDB092C
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionReader() { }

	// RVA: 0xDB0934
	private void set_PreComputeUnionReader(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDB093C
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_PreComputeUnionConstructor() { }

	// RVA: 0xDB0944
	private void set_PreComputeUnionConstructor(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDB094C
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoDeclaringType() { }

	// RVA: 0xDB0954
	private void set_GetUnionCaseInfoDeclaringType(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDB095C
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoName() { }

	// RVA: 0xDB0964
	private void set_GetUnionCaseInfoName(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDB096C
	public System.Func<System.Object,System.Object> get_GetUnionCaseInfoTag() { }

	// RVA: 0xDB0974
	private void set_GetUnionCaseInfoTag(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDB097C
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> get_GetUnionCaseInfoFields() { }

	// RVA: 0xDB0984
	private void set_GetUnionCaseInfoFields(Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> value) { }

	// RVA: 0xDB098C
	public static void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	// RVA: 0xDB05C8
	private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	// RVA: 0xDB0640
	private static Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> CreateFSharpFuncCall(Type type, string methodName) { }

	// RVA: 0xDB0B3C
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateSeq(Type t) { }

	// RVA: 0xDB0C44
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateMap(Type keyType, Type valueType) { }

	// RVA: 0x30B1CD4
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> BuildMapCreator() { }

	// RVA: 0xDB0E28
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

	// RVA: 0xDB2184
	public void .ctor(string contractTypeName, string createdTypeName, string builderTypeName) { }

	// RVA: 0xDB21E8
	public string get_ContractTypeName() { }

	// RVA: 0xDB21F0
	public void set_ContractTypeName(string value) { }

	// RVA: 0xDB21F8
	public string get_CreatedTypeName() { }

	// RVA: 0xDB2200
	public void set_CreatedTypeName(string value) { }

	// RVA: 0xDB2208
	public string get_BuilderTypeName() { }

	// RVA: 0xDB2210
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

	// RVA: 0xDB2218
	private static void .cctor() { }

	// RVA: 0xDB2284
	public void .ctor() { }

	// RVA: 0xDB228C
	internal bool <TryBuildImmutableForArrayContract>b__24_1(MethodInfo m) { }

	// RVA: 0xDB231C
	internal bool <TryBuildImmutableForDictionaryContract>b__25_1(MethodInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass24_0
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0xDB1470
	public void .ctor() { }

	// RVA: 0xDB2484
	internal bool <TryBuildImmutableForArrayContract>b__0(ImmutableCollectionTypeInfo d) { }

}

// Namespace: 
private sealed class <>c__DisplayClass25_0
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0xDB19E8
	public void .ctor() { }

	// RVA: 0xDB24AC
	internal bool <TryBuildImmutableForDictionaryContract>b__0(ImmutableCollectionTypeInfo d) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ImmutableCollectionsUtils
{
	// Fields
	private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x0
	private static readonly System.Collections.Generic.IList<Newtonsoft.Json.Utilities.ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x8

	// Methods

	// RVA: 0xDB0F74
	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, Type createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }

	// RVA: 0xDB149C
	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, Type createdType, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object>& parameterizedCreator) { }

	// RVA: 0xDB19F0
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class BufferUtils
{
	// Methods

	// RVA: 0xDB24D4
	public static Char[] RentBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int minSize) { }

	// RVA: 0xDB25AC
	public static void ReturnBuffer(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] buffer) { }

	// RVA: 0xDB266C
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

	// RVA: 0xDB27AC
	private static void .cctor() { }

	// RVA: 0xDB3228
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, Char quoteChar) { }

	// RVA: 0xDB3314
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	// RVA: 0xDB33C0
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, Char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] writeBuffer) { }

	// RVA: 0xDB3CC0
	public static string ToEscapedJavaScriptString(string value, Char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xDB3AE0
	private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0xDB401C
	public static bool TryGetDateFromConstructorJson(JsonReader reader, DateTime dateTime, string errorMessage) { }

	// RVA: 0xDB4560
	private static bool TryGetDateConstructorValue(JsonReader reader, System.Nullable<System.Int64>& integer, string errorMessage) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class JsonTokenUtils
{
	// Methods

	// RVA: 0xDB4738
	internal static bool IsEndToken(JsonToken token) { }

	// RVA: 0xDB4748
	internal static bool IsStartToken(JsonToken token) { }

	// RVA: 0xDB4758
	internal static bool IsPrimitiveToken(JsonToken token) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public ConstructorInfo c; // 0x10
	public MethodBase method; // 0x18

	// Methods

	// RVA: 0xDB49B0
	public void .ctor() { }

	// RVA: 0xDB4A34
	internal object <CreateParameterizedConstructor>b__0(object[] a) { }

	// RVA: 0xDB4A54
	internal object <CreateParameterizedConstructor>b__1(object[] a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0<T0>
{
	// Fields
	public ConstructorInfo c; // 0x0
	public MethodBase method; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal object <CreateMethodCall>b__0(T o, object[] a) { }

	// RVA: 0x316B894
	internal object <CreateMethodCall>b__1(T o, object[] a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0<T0>
{
	// Fields
	public Type type; // 0x0
	public ConstructorInfo constructorInfo; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal T <CreateDefaultConstructor>b__0() { }

	// RVA: 0x316B894
	internal T <CreateDefaultConstructor>b__1() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0<T0>
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal object <CreateGet>b__0(T o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0<T0>
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal object <CreateGet>b__0(T o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0<T0>
{
	// Fields
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal void <CreateSet>b__0(T o, object v) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0<T0>
{
	// Fields
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal void <CreateSet>b__0(T o, object v) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class LateBoundReflectionDelegateFactory
{
	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x0

	// Methods

	// RVA: 0xDB4770
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0xDB47EC
	public override Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: 0x30B1D84
	public override Newtonsoft.Json.Utilities.MethodCall<T,System.Object> CreateMethodCall(MethodBase method) { }

	// RVA: 0x30B1D84
	public override System.Func<T> CreateDefaultConstructor(Type type) { }

	// RVA: 0x30B1D84
	public override System.Func<T,System.Object> CreateGet(PropertyInfo propertyInfo) { }

	// RVA: 0x30B1D84
	public override System.Func<T,System.Object> CreateGet(FieldInfo fieldInfo) { }

	// RVA: 0x30B1D84
	public override System.Action<T,System.Object> CreateSet(FieldInfo fieldInfo) { }

	// RVA: 0x30B1D84
	public override System.Action<T,System.Object> CreateSet(PropertyInfo propertyInfo) { }

	// RVA: 0xDB49B8
	public void .ctor() { }

	// RVA: 0xDB49C8
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class MathUtils
{
	// Methods

	// RVA: 0xDB4A7C
	public static int IntLength(UInt64 i) { }

	// RVA: 0xDB4C44
	public static Char IntToHex(int n) { }

	// RVA: 0xDB4C60
	public static bool ApproxEquals(Double d1, Double d2) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class MethodCall<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual TResult Invoke(T target, object[] args) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class MiscellaneousUtils
{
	// Methods

	// RVA: 0xDB4D14
	public static bool ValueEquals(object objA, object objB) { }

	// RVA: 0xDA8E24
	public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	// RVA: 0xDB511C
	public static string ToString(object value) { }

	// RVA: 0xDB51D0
	public static int ByteArrayCompare(Byte[] a1, Byte[] a2) { }

	// RVA: 0xDB5298
	public static string GetPrefix(string qualifiedName) { }

	// RVA: 0xDB5390
	public static string GetLocalName(string qualifiedName) { }

	// RVA: 0xDB52C4
	public static void GetQualifiedNameParts(string qualifiedName, string prefix, string localName) { }

	// RVA: 0xDB53D4
	internal static RegexOptions GetRegexOptions(string optionsText) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal abstract class ReflectionDelegateFactory
{
	// Methods

	// RVA: 0x30B1D84
	public System.Func<T,System.Object> CreateGet(MemberInfo memberInfo) { }

	// RVA: 0x30B1D84
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

	// RVA: 0xDB49C0
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

	// RVA: 0xDB5488
	public Type get_MemberType() { }

	// RVA: 0xDB5490
	public void set_MemberType(Type value) { }

	// RVA: 0xDB5498
	public System.Func<System.Object,System.Object> get_Getter() { }

	// RVA: 0xDB54A0
	public void set_Getter(System.Func<System.Object,System.Object> value) { }

	// RVA: 0xDB54A8
	public System.Action<System.Object,System.Object> get_Setter() { }

	// RVA: 0xDB54B0
	public void set_Setter(System.Action<System.Object,System.Object> value) { }

	// RVA: 0xDB54B8
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public System.Func<System.Object> ctor; // 0x10

	// Methods

	// RVA: 0xDB6220
	public void .ctor() { }

	// RVA: 0xDB67EC
	internal object <Create>b__0(object[] args) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_1
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10

	// Methods

	// RVA: 0xDB6548
	public void .ctor() { }

	// RVA: 0xDB6828
	internal object <Create>b__1(object target) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_2
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> call; // 0x10

	// Methods

	// RVA: 0xDB6550
	public void .ctor() { }

	// RVA: 0xDB6940
	internal void <Create>b__2(object target, object arg) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ReflectionObject
{
	// Fields
	private readonly Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <Creator>k__BackingField; // 0x10
	private readonly System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> <Members>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDB54C0
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_Creator() { }

	// RVA: 0xDB54C8
	public System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Utilities.ReflectionMember> get_Members() { }

	// RVA: 0xDB54D0
	private void .ctor(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator) { }

	// RVA: 0xDB5578
	public object GetValue(object target, string member) { }

	// RVA: 0xDB5678
	public void SetValue(object target, string member, object value) { }

	// RVA: 0xDB5774
	public Type GetType(string member) { }

	// RVA: 0xDB5844
	public static ReflectionObject Create(Type t, string[] memberNames) { }

	// RVA: 0xDB5850
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

	// RVA: 0xDBB23C
	private static void .cctor() { }

	// RVA: 0xDBB2A8
	public void .ctor() { }

	// RVA: 0xDBB2B0
	internal bool <GetDefaultConstructor>b__11_0(ConstructorInfo c) { }

	// RVA: 0xDBB31C
	internal string <GetFieldsAndProperties>b__31_0(MemberInfo m) { }

	// RVA: 0xDBB344
	internal Type <GetMemberInfoFromType>b__39_0(ParameterInfo p) { }

	// RVA: 0xDBB36C
	internal bool <GetChildPrivateFields>b__41_0(FieldInfo f) { }

}

// Namespace: 
private sealed class <>c__DisplayClass31_0
{
	// Fields
	public MemberInfo memberInfo; // 0x10

	// Methods

	// RVA: 0xDB9AF4
	public void .ctor() { }

	// RVA: 0xDBB388
	internal bool <GetFieldsAndProperties>b__1(MemberInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass44_0
{
	// Fields
	public PropertyInfo subTypeProperty; // 0x10

	// Methods

	// RVA: 0xDBAE18
	public void .ctor() { }

	// RVA: 0xDBB428
	internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	// RVA: 0xDBB484
	internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass44_1
{
	// Fields
	public Type subTypePropertyDeclaringType; // 0x10
	public Newtonsoft.Json.Utilities.ReflectionUtils.<>c__DisplayClass44_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xDBAE20
	public void .ctor() { }

	// RVA: 0xDBB570
	internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_0
{
	// Fields
	public string method; // 0x10
	public Type methodDeclaringType; // 0x18

	// Methods

	// RVA: 0xDBAF44
	public void .ctor() { }

	// RVA: 0xDBB6A8
	internal bool <IsMethodOverridden>b__0(MethodInfo info) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ReflectionUtils
{
	// Fields
	public static readonly Type[] EmptyTypes; // 0x0

	// Methods

	// RVA: 0xDB6A20
	private static void .cctor() { }

	// RVA: 0xDB6AA4
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	// RVA: 0xDB6BD0
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0xDB6CC4
	public static bool IsPublic(PropertyInfo property) { }

	// RVA: 0xDA5440
	public static Type GetObjectType(object v) { }

	// RVA: 0xDB6D70
	public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder) { }

	// RVA: 0xDB6E94
	private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder) { }

	// RVA: 0xDB6FDC
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0xDB6108
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0xDB72D4
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0xDB7170
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0xDA4F2C
	public static bool IsNullable(Type t) { }

	// RVA: 0xDA2D00
	public static bool IsNullableType(Type t) { }

	// RVA: 0xDB735C
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0xDB73F8
	public static Type EnsureNotByRefType(Type t) { }

	// RVA: 0xDB7458
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0xDA1930
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0xDB750C
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, Type implementingType) { }

	// RVA: 0xDB77E8
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0xDB7864
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, Type implementingType) { }

	// RVA: 0xDB79F4
	private static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, Type implementingType) { }

	// RVA: 0xDB7B64
	public static Type GetCollectionItemType(Type type) { }

	// RVA: 0xDB7DEC
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, Type keyType, Type valueType) { }

	// RVA: 0xDB6558
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0xDB807C
	public static bool IsByRefLikeType(Type type) { }

	// RVA: 0xDB8684
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0xDB8730
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0xDB8A70
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0xDB6248
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0xDB63B0
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0xDB8CA0
	public static System.Collections.Generic.List<System.Reflection.MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0xDB9AFC
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: 0x316B894
	public static T GetAttribute(object attributeProvider) { }

	// RVA: 0x316B894
	public static T GetAttribute(object attributeProvider, bool inherit) { }

	// RVA: -1
	public static T[] GetAttributes(object attributeProvider, bool inherit) { }

	// RVA: 0xDB818C
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0xDB9CF8
	public static Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) { }

	// RVA: 0xDB9FB4
	private static System.Nullable<System.Int32> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0xDBA260
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0xDB9620
	public static System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0xDBA4F0
	private static void GetChildPrivateFields(System.Collections.Generic.IList<System.Reflection.MemberInfo> initialFields, Type type, BindingFlags bindingAttr) { }

	// RVA: 0xDB976C
	public static System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0xDBA6F0
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0xDBA700
	private static void GetChildPrivateProperties(System.Collections.Generic.IList<System.Reflection.PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr) { }

	// RVA: 0xDBAE28
	public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method) { }

	// RVA: 0xDBAF4C
	public static object GetDefaultValue(Type type) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StringBuffer
{
	// Fields
	private Char[] _buffer; // 0x10
	private int _position; // 0x18

	// Methods

	// RVA: 0xDBB7D8
	public int get_Position() { }

	// RVA: 0xDBB7E0
	public void set_Position(int value) { }

	// RVA: 0xDBB7E8
	public bool get_IsEmpty() { }

	// RVA: 0xDBB7F8
	public void .ctor(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int initalSize) { }

	// RVA: 0xDBB834
	private void .ctor(Char[] buffer) { }

	// RVA: 0xDBB85C
	public void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char value) { }

	// RVA: 0xDBB9D4
	public void Append(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, Char[] buffer, int startIndex, int count) { }

	// RVA: 0xDBBA58
	public void Clear(Newtonsoft.Json.IArrayPool<System.Char> bufferPool) { }

	// RVA: 0xDBB8D8
	private void EnsureSize(Newtonsoft.Json.IArrayPool<System.Char> bufferPool, int appendLength) { }

	// RVA: 0xDBBB28
	public override string ToString() { }

	// RVA: 0xDBBB40
	public string ToString(int start, int length) { }

	// RVA: 0xDBBB58
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

	// RVA: 0xDAA55C
	public Char get_Item(int i) { }

	// RVA: 0xDBBB60
	public Char[] get_Chars() { }

	// RVA: 0xDBBB68
	public int get_StartIndex() { }

	// RVA: 0xDBBB70
	public int get_Length() { }

	// RVA: 0xDAAD24
	public void .ctor(Char[] chars, int startIndex, int length) { }

	// RVA: 0xDAA938
	public override string ToString() { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class StringReferenceExtensions
{
	// Methods

	// RVA: 0xDAB814
	public static int IndexOf(StringReference s, Char c, int startIndex, int length) { }

	// RVA: 0xDAA590
	public static bool StartsWith(StringReference s, string text) { }

	// RVA: 0xDAA670
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

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }

	// RVA: 0x316B894
	internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class StringUtils
{
	// Methods

	// RVA: 0xDAA930
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0xDA3770
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	// RVA: 0xDA4BEC
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	// RVA: 0xDBBC1C
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	// RVA: 0xDBBD54
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	// RVA: 0xDBBB78
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0xDB3F54
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0xDB3C08
	public static void ToCharAsUnicode(Char c, Char[] buffer) { }

	// RVA: 0x316B894
	public static TSource ForgivingCaseSensitiveFind(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,System.String> valueSelector, string testValue) { }

	// RVA: 0xDBBEC4
	public static string ToCamelCase(string s) { }

	// RVA: 0xDBC390
	private static Char ToLower(Char c) { }

	// RVA: 0xDBC458
	public static string ToSnakeCase(string s) { }

	// RVA: 0xDBC780
	public static string ToKebabCase(string s) { }

	// RVA: 0xDBC460
	private static string ToSeparatedCase(string s, Char separator) { }

	// RVA: 0xDBC788
	public static bool IsHighSurrogate(Char c) { }

	// RVA: 0xDBC810
	public static bool IsLowSurrogate(Char c) { }

	// RVA: 0xDB53BC
	public static int IndexOf(string s, Char c) { }

	// RVA: 0xDBC898
	public static bool StartsWith(string source, Char value) { }

	// RVA: 0xDBC8EC
	public static bool EndsWith(string source, Char value) { }

	// RVA: 0xDBA09C
	public static string Trim(string s, int start, int length) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal struct StructMultiKey<T0, T1>
{
	// Fields
	public readonly T1 Value1; // 0x0
	public readonly T2 Value2; // 0x0

	// Methods

	// RVA: 0x316B894
	public void .ctor(T1 v1, T2 v2) { }

	// RVA: 0x30B199C
	public override int GetHashCode() { }

	// RVA: 0x30B183C
	public override bool Equals(object obj) { }

	// RVA: 0x316B894
	public bool Equals(Newtonsoft.Json.Utilities.StructMultiKey<T1,T2> other) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal class ThreadSafeStore<T0, T1>
{
	// Fields
	private readonly System.Collections.Concurrent.ConcurrentDictionary<TKey,TValue> _concurrentStore; // 0x0
	private readonly System.Func<TKey,TValue> _creator; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(System.Func<TKey,TValue> creator) { }

	// RVA: 0x316B894
	public TValue Get(TKey key) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class TypeExtensions
{
	// Methods

	// RVA: 0xDB6228
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	// RVA: 0xDBC93C
	public static bool ContainsGenericParameters(Type type) { }

	// RVA: 0xDA522C
	public static bool IsInterface(Type type) { }

	// RVA: 0xDB144C
	public static bool IsGenericType(Type type) { }

	// RVA: 0xDA5244
	public static bool IsGenericTypeDefinition(Type type) { }

	// RVA: 0xDB7B40
	public static Type BaseType(Type type) { }

	// RVA: 0xDB1478
	public static Assembly Assembly(Type type) { }

	// RVA: 0xDA2CDC
	public static bool IsEnum(Type type) { }

	// RVA: 0xDB79DC
	public static bool IsClass(Type type) { }

	// RVA: 0xDBC960
	public static bool IsSealed(Type type) { }

	// RVA: 0xDA5268
	public static bool IsAbstract(Type type) { }

	// RVA: 0xDBC978
	public static bool IsVisible(Type type) { }

	// RVA: 0xDB7158
	public static bool IsValueType(Type type) { }

	// RVA: 0xDBC990
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, Type match) { }

	// RVA: 0xDBCB44
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	// RVA: 0xDBCB68
	public static bool ImplementInterface(Type type, Type interfaceType) { }

}

// Namespace: Newtonsoft.Json.Utilities
internal static class ValidationUtils
{
	// Methods

	// RVA: 0xDA0224
	public static void ArgumentNotNull(object value, string parameterName) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal static class CachedAttributeGetter<T0>
{
	// Fields
	private static readonly Newtonsoft.Json.Utilities.ThreadSafeStore<System.Object,T> TypeAttributeCache; // 0x0

	// Methods

	// RVA: 0x316B894
	public static T GetAttribute(object type) { }

	// RVA: 0x30B71FC
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class CamelCaseNamingStrategy
{
	// Methods

	// RVA: 0xDBCF54
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xDBCF90
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xDAFEC4
	public void .ctor() { }

	// RVA: 0xDBCFD4
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

	// RVA: 0x30B29E8
	public void .ctor(int <>1__state) { }

	// RVA: 0x30B2870
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30B171C
	private bool MoveNext() { }

	// RVA: 0x30B2870
	private void <>m__Finally1() { }

	// RVA: -1
	private System.Collections.Generic.KeyValuePair<System.Object,System.Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
internal class EnumerableDictionaryWrapper<T0, T1>
{
	// Fields
	private readonly System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> _e; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TEnumeratorKey,TEnumeratorValue>> e) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> GetEnumerator() { }

	// RVA: 0x30B1CD4
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

	// RVA: 0xDC52D4
	private static void .cctor() { }

	// RVA: 0xDC5340
	public void .ctor() { }

	// RVA: 0xDC5348
	internal bool <GetSerializableMembers>b__40_0(MemberInfo m) { }

	// RVA: 0xDC5400
	internal bool <GetSerializableMembers>b__40_1(MemberInfo m) { }

	// RVA: 0xDC5470
	internal System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> <GetExtensionDataMemberForType>b__44_0(Type baseType) { }

	// RVA: 0xDC5554
	internal bool <GetExtensionDataMemberForType>b__44_1(MemberInfo m) { }

	// RVA: 0xDC5948
	internal bool <GetAttributeConstructor>b__47_0(ConstructorInfo c) { }

	// RVA: 0xDC5A04
	internal int <CreateProperties>b__75_0(JsonProperty p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass42_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xDC5B38
	public void .ctor() { }

	// RVA: 0xDC5B40
	internal string <CreateObjectContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_0
{
	// Fields
	public System.Func<System.Object,System.Object> getExtensionDataDictionary; // 0x10
	public MemberInfo member; // 0x18

	// Methods

	// RVA: 0xDC5B64
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

	// RVA: 0xDC5B6C
	public void .ctor() { }

	// RVA: 0xDC5B74
	internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass45_2
{
	// Fields
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> createEnumerableWrapper; // 0x10
	public Newtonsoft.Json.Serialization.DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xDC5DA4
	public void .ctor() { }

	// RVA: 0xDC5DAC
	internal System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> <SetExtensionDataDelegates>b__1(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass62_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xDC5EF4
	public void .ctor() { }

	// RVA: 0xDC5EFC
	internal string <CreateDictionaryContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass67_0
{
	// Fields
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0xDC5F20
	public void .ctor() { }

	// RVA: 0xDC5F28
	internal string <CreateDynamicContract>b__0(string s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass80_0
{
	// Fields
	public Newtonsoft.Json.Utilities.MethodCall<System.Object,System.Object> shouldSerializeCall; // 0x10

	// Methods

	// RVA: 0xDC5F4C
	public void .ctor() { }

	// RVA: 0xDC5F54
	internal bool <CreateShouldSerializeTest>b__0(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass81_0
{
	// Fields
	public System.Func<System.Object,System.Object> specifiedPropertyGet; // 0x10

	// Methods

	// RVA: 0xDC60AC
	public void .ctor() { }

	// RVA: 0xDC60B4
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

	// RVA: 0xDBCFDC
	internal static IContractResolver get_Instance() { }

	// RVA: 0xDBD058
	public BindingFlags get_DefaultMembersSearchFlags() { }

	// RVA: 0xDBD060
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	// RVA: 0xDBD068
	public bool get_SerializeCompilerGeneratedMembers() { }

	// RVA: 0xDBD070
	public bool get_IgnoreSerializableInterface() { }

	// RVA: 0xDBD078
	public bool get_IgnoreSerializableAttribute() { }

	// RVA: 0xDBD080
	public void set_IgnoreSerializableAttribute(bool value) { }

	// RVA: 0xDBD088
	public bool get_IgnoreIsSpecifiedMembers() { }

	// RVA: 0xDBD090
	public bool get_IgnoreShouldSerializeMembers() { }

	// RVA: 0xDBD098
	public NamingStrategy get_NamingStrategy() { }

	// RVA: 0xDBD0A0
	public void .ctor() { }

	// RVA: 0xDBD1B4
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0xDBD280
	private static bool FilterMembers(MemberInfo member) { }

	// RVA: 0xDBD3FC
	protected virtual System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0xDBDFD8
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0xDBE0EC
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0xDBFF7C
	private static void ThrowUnableToSerializeError(object o, StreamingContext context) { }

	// RVA: 0xDBF3A0
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0xDBF5C4
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0xDBEA48
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0xDBF008
	private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	// RVA: 0xDBEFB8
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0xDC02B4
	protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0xDC01FC
	private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	// RVA: 0xDC04B0
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0xDC10EC
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0xDC1174
	private System.Func<System.Object> GetDefaultCreator(Type createdType) { }

	// RVA: 0xDBE75C
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0xDC1238
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0xDC1384
	private void GetCallbackMethodsForType(Type type, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onSerialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserializing, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationCallback>& onDeserialized, System.Collections.Generic.List<Newtonsoft.Json.Serialization.SerializationErrorCallback>& onError) { }

	// RVA: 0xDC24AC
	private static bool IsConcurrentOrObservableCollection(Type t) { }

	// RVA: 0xDC1D48
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0xDC1C48
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0xDC0014
	private System.Collections.Generic.List<System.Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0xDC2640
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0xDC2C10
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0xDC2F78
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0xDC2FF0
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0xDC3068
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0xDC32E0
	protected virtual JsonDynamicContract CreateDynamicContract(Type objectType) { }

	// RVA: 0xDC351C
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0xDC3594
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0xDC3B38
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0xDC3D74
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0xDC3C08
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0xDC1E48
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, Type prevAttributeType) { }

	// RVA: 0xDC3F28
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0xDC4034
	protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0xDC4504
	internal virtual DefaultJsonNameTable GetNameTable() { }

	// RVA: 0xDC450C
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0xDC4574
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0xDC0940
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, bool allowNonPublicAccess) { }

	// RVA: 0xDC479C
	private System.Predicate<System.Object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0xDC4A00
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0xDC4D38
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0xDC4D58
	protected virtual string ResolveExtensionDataName(string extensionDataName) { }

	// RVA: 0xDC4D74
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0xDC4DA0
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0xDC4DB0
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultNamingStrategy
{
	// Methods

	// RVA: 0xDC615C
	protected override string ResolvePropertyName(string name) { }

	// RVA: 0xDC6164
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class DefaultReferenceResolver
{
	// Fields
	private int _referenceCount; // 0x10

	// Methods

	// RVA: 0xDC616C
	private Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> GetMappings(object context) { }

	// RVA: 0xDC63A4
	public object ResolveReference(object context, string reference) { }

	// RVA: 0xDC6424
	public string GetReference(object context, object value) { }

	// RVA: 0xDC6524
	public void AddReference(object context, string reference, object value) { }

	// RVA: 0xDC6594
	public bool IsReferenced(object context, object value) { }

	// RVA: 0xDC6610
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultSerializationBinder
{
	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	private readonly Newtonsoft.Json.Utilities.ThreadSafeStore<Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String>,System.Type> _typeCache; // 0x10

	// Methods

	// RVA: 0xDC6618
	public void .ctor() { }

	// RVA: 0xDC66F4
	private Type GetTypeFromTypeNameKey(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }

	// RVA: 0xDC6B1C
	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	// RVA: 0xDC6DC0
	private Type GetTypeByName(Newtonsoft.Json.Utilities.StructMultiKey<System.String,System.String> typeNameKey) { }

	// RVA: 0xDC6E40
	public override Type BindToType(string assemblyName, string typeName) { }

	// RVA: 0xDC6F14
	public override void BindToName(Type serializedType, string assemblyName, string typeName) { }

	// RVA: 0xDC6F9C
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

	// RVA: 0xDC7004
	internal void .ctor(object originalObject, object member, string path, Exception error) { }

	// RVA: 0xDC7084
	internal bool get_Traced() { }

	// RVA: 0xDC708C
	internal void set_Traced(bool value) { }

	// RVA: 0xDC7094
	public Exception get_Error() { }

	// RVA: 0xDC709C
	public bool get_Handled() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class ErrorEventArgs
{
	// Fields
	private readonly object <CurrentObject>k__BackingField; // 0x10
	private readonly ErrorContext <ErrorContext>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDC70A4
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

	// RVA: 0xDC7138
	public Type get_CollectionItemType() { }

	// RVA: 0xDC7140
	public bool get_IsMultidimensionalArray() { }

	// RVA: 0xDC7148
	internal bool get_IsArray() { }

	// RVA: 0xDC7150
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0xDC7158
	internal bool get_CanDeserialize() { }

	// RVA: 0xDC7160
	private void set_CanDeserialize(bool value) { }

	// RVA: 0xDC7168
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xDC726C
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xDC7274
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDC72A4
	public bool get_HasParameterizedCreator() { }

	// RVA: 0xDC72AC
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0xDC72B4
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0xDC7350
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDC86E4
	internal IWrappedCollection CreateWrapper(object list) { }

	// RVA: 0xDC8B1C
	internal IList CreateTemporaryCollection() { }

	// RVA: 0xDC8500
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

	// RVA: 0xDC8DC8
	internal JsonContract get_ItemContract() { }

	// RVA: 0xDC8DD0
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0xDC8E3C
	internal JsonContract get_FinalItemContract() { }

	// RVA: 0xDC8E44
	public JsonConverter get_ItemConverter() { }

	// RVA: 0xDC8E4C
	public void set_ItemConverter(JsonConverter value) { }

	// RVA: 0xDC8E54
	public System.Nullable<System.Boolean> get_ItemIsReference() { }

	// RVA: 0xDC8E5C
	public void set_ItemIsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDC8E64
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	// RVA: 0xDC8E6C
	public void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xDC8E74
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }

	// RVA: 0xDC8E7C
	public void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xDC8304
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

	// RVA: 0xDC9010
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDC9134
	public virtual void Invoke(object o, StreamingContext context) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationErrorCallback
{
	// Methods

	// RVA: 0xDC9148
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDC926C
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataSetter
{
	// Methods

	// RVA: 0xDC9280
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDC93A4
	public virtual void Invoke(object o, string key, object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataGetter
{
	// Methods

	// RVA: 0xDC93B8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDC94D8
	public virtual System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Object,System.Object>> Invoke(object o) { }

}

// Namespace: 
private sealed class <>c__DisplayClass57_0
{
	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0xDCA2E0
	public void .ctor() { }

	// RVA: 0xDCA3AC
	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

}

// Namespace: 
private sealed class <>c__DisplayClass58_0
{
	// Fields
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0xDCA3A4
	public void .ctor() { }

	// RVA: 0xDCA4B8
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

	// RVA: 0xDC94EC
	public Type get_UnderlyingType() { }

	// RVA: 0xDC94F4
	public Type get_CreatedType() { }

	// RVA: 0xDC8440
	public void set_CreatedType(Type value) { }

	// RVA: 0xDC94FC
	public System.Nullable<System.Boolean> get_IsReference() { }

	// RVA: 0xDC9504
	public void set_IsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDC950C
	public JsonConverter get_Converter() { }

	// RVA: 0xDC9514
	public void set_Converter(JsonConverter value) { }

	// RVA: 0xDC951C
	public JsonConverter get_InternalConverter() { }

	// RVA: 0xDC9524
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0xDC952C
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0xDC95C8
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0xDC9664
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0xDC9700
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0xDC979C
	public System.Collections.Generic.IList<Newtonsoft.Json.Serialization.SerializationErrorCallback> get_OnErrorCallbacks() { }

	// RVA: 0xDC9838
	public System.Func<System.Object> get_DefaultCreator() { }

	// RVA: 0xDC9840
	public void set_DefaultCreator(System.Func<System.Object> value) { }

	// RVA: 0xDC9848
	public bool get_DefaultCreatorNonPublic() { }

	// RVA: 0xDC9850
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0xDC8E84
	internal void .ctor(Type underlyingType) { }

	// RVA: 0xDC9858
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0xDC9A4C
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0xDC9C40
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0xDC9E34
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0xDCA028
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0xDCA224
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0xDCA2E8
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

	// RVA: 0xDCA5FC
	public System.Func<System.String,System.String> get_DictionaryKeyResolver() { }

	// RVA: 0xDCA604
	public void set_DictionaryKeyResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xDCA60C
	public Type get_DictionaryKeyType() { }

	// RVA: 0xDCA614
	public Type get_DictionaryValueType() { }

	// RVA: 0xDCA61C
	internal JsonContract get_KeyContract() { }

	// RVA: 0xDCA624
	internal void set_KeyContract(JsonContract value) { }

	// RVA: 0xDCA62C
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0xDCA634
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xDCA738
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xDCA740
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDCA750
	public bool get_HasParameterizedCreator() { }

	// RVA: 0xDCA758
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0xDCA760
	internal bool get_HasParameterizedCreatorInternal() { }

	// RVA: 0xDCA7FC
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDCB398
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	// RVA: 0xDCB670
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

	// RVA: 0xDCB954
	public JsonPropertyCollection get_Properties() { }

	// RVA: 0xDCB95C
	public System.Func<System.String,System.String> get_PropertyNameResolver() { }

	// RVA: 0xDCB964
	public void set_PropertyNameResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xDCB96C
	private static System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>> CreateCallSiteGetter(string name) { }

	// RVA: 0xDCBA98
	private static System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object,System.Object>> CreateCallSiteSetter(string name) { }

	// RVA: 0xDCBBC4
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDCBF48
	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }

	// RVA: 0xDCC068
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

	// RVA: 0xDCC178
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x316B894
	private T GetTokenValue(object value) { }

	// RVA: 0xDCC24C
	public object Convert(object value, Type type) { }

	// RVA: 0xDCC550
	public bool ToBoolean(object value) { }

	// RVA: 0xDCC5C0
	public int ToInt32(object value) { }

	// RVA: 0xDCC630
	public Int64 ToInt64(object value) { }

	// RVA: 0xDCC6A0
	public float ToSingle(object value) { }

	// RVA: 0xDCC710
	public string ToString(object value) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonISerializableContract
{
	// Fields
	private Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> <ISerializableCreator>k__BackingField; // 0xC0

	// Methods

	// RVA: 0xDCC780
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ISerializableCreator() { }

	// RVA: 0xDCC788
	public void set_ISerializableCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDCC790
	public void .ctor(Type underlyingType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonLinqContract
{
	// Methods

	// RVA: 0xDCC7B8
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

	// RVA: 0xDCC7E0
	public MemberSerialization get_MemberSerialization() { }

	// RVA: 0xDCC7E8
	public void set_MemberSerialization(MemberSerialization value) { }

	// RVA: 0xDCC7F0
	public System.Nullable<Newtonsoft.Json.MissingMemberHandling> get_MissingMemberHandling() { }

	// RVA: 0xDCC7F8
	public void set_MissingMemberHandling(System.Nullable<Newtonsoft.Json.MissingMemberHandling> value) { }

	// RVA: 0xDCC800
	public System.Nullable<Newtonsoft.Json.Required> get_ItemRequired() { }

	// RVA: 0xDCC808
	public void set_ItemRequired(System.Nullable<Newtonsoft.Json.Required> value) { }

	// RVA: 0xDCC810
	public System.Nullable<Newtonsoft.Json.NullValueHandling> get_ItemNullValueHandling() { }

	// RVA: 0xDCC818
	public void set_ItemNullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }

	// RVA: 0xDCC820
	public JsonPropertyCollection get_Properties() { }

	// RVA: 0xDCC828
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0xDCC8C4
	public Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_OverrideCreator() { }

	// RVA: 0xDCC8CC
	public void set_OverrideCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDCC8DC
	internal Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> get_ParameterizedCreator() { }

	// RVA: 0xDCC8E4
	internal void set_ParameterizedCreator(Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> value) { }

	// RVA: 0xDCC8F4
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	// RVA: 0xDCC8FC
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	// RVA: 0xDCC904
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	// RVA: 0xDCC90C
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0xDCC914
	public void set_ExtensionDataValueType(Type value) { }

	// RVA: 0xDCCA14
	public System.Func<System.String,System.String> get_ExtensionDataNameResolver() { }

	// RVA: 0xDCCA1C
	public void set_ExtensionDataNameResolver(System.Func<System.String,System.String> value) { }

	// RVA: 0xDCCA24
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	// RVA: 0xDCD1EC
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDCD274
	internal object GetUninitializedObject() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonPrimitiveContract
{
	// Fields
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x8C
	private static readonly System.Collections.Generic.Dictionary<System.Type,Newtonsoft.Json.ReadType> ReadTypeMap; // 0x0

	// Methods

	// RVA: 0xDCD3B4
	internal PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0xDCD3BC
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0xDCD3C4
	public void .ctor(Type underlyingType) { }

	// RVA: 0xDCD4C4
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

	// RVA: 0xDCD88C
	internal JsonContract get_PropertyContract() { }

	// RVA: 0xDCD894
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0xDCD89C
	public string get_PropertyName() { }

	// RVA: 0xDCD8A4
	public void set_PropertyName(string value) { }

	// RVA: 0xDCD93C
	public Type get_DeclaringType() { }

	// RVA: 0xDCD944
	public void set_DeclaringType(Type value) { }

	// RVA: 0xDCD94C
	public System.Nullable<System.Int32> get_Order() { }

	// RVA: 0xDCD954
	public void set_Order(System.Nullable<System.Int32> value) { }

	// RVA: 0xDCD95C
	public string get_UnderlyingName() { }

	// RVA: 0xDCD964
	public void set_UnderlyingName(string value) { }

	// RVA: 0xDCD96C
	public IValueProvider get_ValueProvider() { }

	// RVA: 0xDCD974
	public void set_ValueProvider(IValueProvider value) { }

	// RVA: 0xDCD97C
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0xDCD984
	public Type get_PropertyType() { }

	// RVA: 0xDCD98C
	public void set_PropertyType(Type value) { }

	// RVA: 0xDCDA60
	public JsonConverter get_Converter() { }

	// RVA: 0xDCDA68
	public void set_Converter(JsonConverter value) { }

	// RVA: 0xDCDA70
	public bool get_Ignored() { }

	// RVA: 0xDCDA78
	public void set_Ignored(bool value) { }

	// RVA: 0xDCDA80
	public bool get_Readable() { }

	// RVA: 0xDCDA88
	public void set_Readable(bool value) { }

	// RVA: 0xDCDA90
	public bool get_Writable() { }

	// RVA: 0xDCDA98
	public void set_Writable(bool value) { }

	// RVA: 0xDCDAA0
	public bool get_HasMemberAttribute() { }

	// RVA: 0xDCDAA8
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0xDCDAB0
	public object get_DefaultValue() { }

	// RVA: 0xDCDAC8
	public void set_DefaultValue(object value) { }

	// RVA: 0xDCDAD8
	internal object GetResolvedDefaultValue() { }

	// RVA: 0xDCD114
	public Required get_Required() { }

	// RVA: 0xDCDBB8
	public System.Nullable<System.Boolean> get_IsReference() { }

	// RVA: 0xDCDBC0
	public void set_IsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDCDBC8
	public System.Nullable<Newtonsoft.Json.NullValueHandling> get_NullValueHandling() { }

	// RVA: 0xDCDBD0
	public void set_NullValueHandling(System.Nullable<Newtonsoft.Json.NullValueHandling> value) { }

	// RVA: 0xDCDBD8
	public System.Nullable<Newtonsoft.Json.DefaultValueHandling> get_DefaultValueHandling() { }

	// RVA: 0xDCDBE0
	public void set_DefaultValueHandling(System.Nullable<Newtonsoft.Json.DefaultValueHandling> value) { }

	// RVA: 0xDCDBE8
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	// RVA: 0xDCDBF0
	public void set_ReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xDCDBF8
	public System.Nullable<Newtonsoft.Json.ObjectCreationHandling> get_ObjectCreationHandling() { }

	// RVA: 0xDCDC00
	public void set_ObjectCreationHandling(System.Nullable<Newtonsoft.Json.ObjectCreationHandling> value) { }

	// RVA: 0xDCDC08
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_TypeNameHandling() { }

	// RVA: 0xDCDC10
	public void set_TypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xDCDC18
	public System.Predicate<System.Object> get_ShouldSerialize() { }

	// RVA: 0xDCDC20
	public void set_ShouldSerialize(System.Predicate<System.Object> value) { }

	// RVA: 0xDCDC28
	public System.Predicate<System.Object> get_ShouldDeserialize() { }

	// RVA: 0xDCDC30
	public System.Predicate<System.Object> get_GetIsSpecified() { }

	// RVA: 0xDCDC38
	public void set_GetIsSpecified(System.Predicate<System.Object> value) { }

	// RVA: 0xDCDC40
	public System.Action<System.Object,System.Object> get_SetIsSpecified() { }

	// RVA: 0xDCDC48
	public void set_SetIsSpecified(System.Action<System.Object,System.Object> value) { }

	// RVA: 0xDCDC50
	public override string ToString() { }

	// RVA: 0xDCDCBC
	public JsonConverter get_ItemConverter() { }

	// RVA: 0xDCDCC4
	public void set_ItemConverter(JsonConverter value) { }

	// RVA: 0xDCDCCC
	public System.Nullable<System.Boolean> get_ItemIsReference() { }

	// RVA: 0xDCDCD4
	public void set_ItemIsReference(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDCDCDC
	public System.Nullable<Newtonsoft.Json.TypeNameHandling> get_ItemTypeNameHandling() { }

	// RVA: 0xDCDCE4
	public void set_ItemTypeNameHandling(System.Nullable<Newtonsoft.Json.TypeNameHandling> value) { }

	// RVA: 0xDCDCEC
	public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	// RVA: 0xDCDCF4
	public void set_ItemReferenceLoopHandling(System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> value) { }

	// RVA: 0xDCDCFC
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0xDCDD54
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonPropertyCollection
{
	// Fields
	private readonly Type _type; // 0x30
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonProperty> _list; // 0x38

	// Methods

	// RVA: 0xDCBD8C
	public void .ctor(Type type) { }

	// RVA: 0xDCDD5C
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0xDCDD78
	public void AddProperty(JsonProperty property) { }

	// RVA: 0xDCE058
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0xDCE1F4
	private bool TryGetProperty(string key, JsonProperty item) { }

	// RVA: 0xDCE0F8
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

}

// Namespace: 
private class ReferenceEqualsEqualityComparer
{
	// Methods

	// RVA: 0xDCEBAC
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	// RVA: 0xDCEBB8
	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	// RVA: 0xDCE380
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

	// RVA: 0xDCE2E0
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0xDC627C
	internal Newtonsoft.Json.Utilities.BidirectionalDictionary<System.String,System.Object> get_DefaultReferenceMappings() { }

	// RVA: 0xDCE388
	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0xDCE5CC
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0xDCE6FC
	protected void ClearErrorContext() { }

	// RVA: 0xDCE76C
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

	// RVA: 0xDDC6EC
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

	// RVA: 0xDDD368
	private static void .cctor() { }

	// RVA: 0xDDD3D4
	public void .ctor() { }

	// RVA: 0xDDD3DC
	internal string <CreateObjectUsingCreatorWithParameters>b__38_0(JsonProperty p) { }

	// RVA: 0xDDD3F8
	internal string <CreateObjectUsingCreatorWithParameters>b__38_2(JsonProperty p) { }

	// RVA: 0xDDD414
	internal JsonProperty <PopulateObject>b__42_0(JsonProperty m) { }

	// RVA: 0xDDD41C
	internal PropertyPresence <PopulateObject>b__42_1(JsonProperty m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass38_0
{
	// Fields
	public JsonProperty property; // 0x10

	// Methods

	// RVA: 0xDDC6E4
	public void .ctor() { }

	// RVA: 0xDDD424
	internal bool <CreateObjectUsingCreatorWithParameters>b__1(CreatorPropertyContext p) { }

}

// Namespace: Newtonsoft.Json.Serialization
internal class JsonSerializerInternalReader
{
	// Methods

	// RVA: 0xDCEBC4
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0xDCEBC8
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0xDD1708
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0xDD17B8
	private JsonContract GetContract(Type type) { }

	// RVA: 0xDD1874
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0xDD26FC
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0xDD279C
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0xDD2B9C
	private JToken CreateJObject(JsonReader reader) { }

	// RVA: 0xDD2194
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0xDD481C
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0xDD4970
	internal string GetExpectedDescription(JsonContract contract) { }

	// RVA: 0xDD1C74
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDD3024
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	// RVA: 0xDD4A2C
	private bool ReadMetadataPropertiesToken(JTokenReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, object newValue, string id) { }

	// RVA: 0xDD5194
	private bool ReadMetadataProperties(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, object newValue, string id) { }

	// RVA: 0xDD6EC4
	private void ResolveTypeName(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0xDD7764
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	// RVA: 0xDD3A28
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	// RVA: 0xDD578C
	private bool HasNoDefinedType(JsonContract contract) { }

	// RVA: 0xDD4208
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0xDD8400
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	// RVA: 0xDD8900
	private bool CalculatePropertyDetails(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, bool useExistingValue, object currentValue, JsonContract propertyContract, bool gottenCurrentValue, bool ignoredValue) { }

	// RVA: 0xDD90DC
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0xDD90D0
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xDD8F98
	private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	// RVA: 0xDD78E8
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, bool createdFromNonDefaultCreator) { }

	// RVA: 0xDD5B70
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, bool createdFromNonDefaultCreator) { }

	// RVA: 0xDD94BC
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0xDD96F8
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0xDCF7C4
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xDD7C30
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xDD9934
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0xDCF11C
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0xDD6768
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0xDCC370
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0xDD5E5C
	private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	// RVA: 0xDD9ACC
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, Newtonsoft.Json.Serialization.ObjectConstructor<System.Object> creator, string id) { }

	// RVA: 0xDD1D04
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0xDDBCA4
	private System.Collections.Generic.List<Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0xDD588C
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, bool createdFromNonDefaultCreator) { }

	// RVA: 0xDD049C
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0xDDCFDC
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0xDD2EF8
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0xDDCDD0
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0xDDCD04
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0xDDC720
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0xDDD250
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, System.Collections.Generic.Dictionary<Newtonsoft.Json.Serialization.JsonProperty,Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0xDD2630
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

	// RVA: 0xDDD44C
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0xDDD4E4
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0xDDE468
	private JsonSerializerProxy GetInternalSerializer() { }

	// RVA: 0xDDD7BC
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0xDDE508
	private JsonContract GetContract(object value) { }

	// RVA: 0xDDE5D8
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDDDCD4
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDE1D04
	private System.Nullable<System.Boolean> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDDD7CC
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDE1E50
	private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0xDE1F58
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDDDA44
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0xDE2400
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0xDE25FC
	internal static bool TryConvertToString(object value, Type type, string s) { }

	// RVA: 0xDE06F4
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0xDE2748
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0xDE2964
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0xDDF3C0
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDE2D70
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, JsonContract memberContract, object memberValue) { }

	// RVA: 0xDE2B80
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDE3C68
	private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	// RVA: 0xDE3DA0
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0xDDEBD4
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0xDE1F4C
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0xDE1E44
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0xDE3FF8
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0xDDEE60
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDDFE78
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDE0508
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDE43B4
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0xDE4004
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDE18AC
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDE104C
	private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDE474C
	private bool ShouldWriteDynamicProperty(object memberValue) { }

	// RVA: 0xDDE750
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0xDE0784
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0xDE3228
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, bool escape) { }

	// RVA: 0xDDE398
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0xDE3788
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0xDE39F8
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

	// RVA: 0xDE481C
	public override void add_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDE4840
	public override void remove_Error(System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> value) { }

	// RVA: 0xDE4864
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0xDE4888
	public override ITraceWriter get_TraceWriter() { }

	// RVA: 0xDE48AC
	public override void set_TraceWriter(ITraceWriter value) { }

	// RVA: 0xDE48D0
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0xDE48F4
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0xDE491C
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0xDE4944
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0xDE496C
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0xDE4994
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0xDE49BC
	public override NullValueHandling get_NullValueHandling() { }

	// RVA: 0xDE49E4
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0xDE4A0C
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0xDE4A34
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0xDE4A5C
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0xDE4A84
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0xDE4AA8
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0xDE4AD0
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0xDE4AF8
	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0xDE4B1C
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0xDE4B44
	public override void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0xDE4B68
	public override StreamingContext get_Context() { }

	// RVA: 0xDE4B90
	public override void set_Context(StreamingContext value) { }

	// RVA: 0xDE4BB8
	public override Formatting get_Formatting() { }

	// RVA: 0xDE4BE0
	public override System.Nullable<System.Int32> get_MaxDepth() { }

	// RVA: 0xDE4C08
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0xDE4C30
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0xDE4C58
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0xDE4C74
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0xDE4D04
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	// RVA: 0xDE4D94
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0xDE4DD0
	internal override void PopulateInternal(JsonReader reader, object target) { }

	// RVA: 0xDE4E08
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class JsonStringContract
{
	// Methods

	// RVA: 0xDE4E40
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

	// RVA: 0xDE667C
	private static void .cctor() { }

	// RVA: 0xDE66E8
	public void .ctor() { }

	// RVA: 0xDE66F0
	internal Type <GetCreator>b__22_1(object param) { }

}

// Namespace: 
private sealed class <>c__DisplayClass22_0
{
	// Fields
	public Type type; // 0x10
	public System.Func<System.Object> defaultConstructor; // 0x18

	// Methods

	// RVA: 0xDE5E10
	public void .ctor() { }

	// RVA: 0xDE6754
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

	// RVA: 0x316B894
	public static T GetCachedAttribute(object attributeProvider) { }

	// RVA: 0xDE4EB8
	public static bool CanTypeDescriptorConvertString(Type type, TypeConverter typeConverter) { }

	// RVA: 0xDE50B8
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0xDE51C4
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0xDE54C0
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0xDE5708
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0xDE5884
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] args) { }

	// RVA: 0xDE59AC
	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[] args) { }

	// RVA: 0xDE5AD4
	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	// RVA: 0xDE5BBC
	private static System.Func<System.Object[],System.Object> GetCreator(Type type) { }

	// RVA: 0xDE5EDC
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0xDE5F94
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: 0x316B894
	private static T GetAttribute(Type type) { }

	// RVA: 0x316B894
	private static T GetAttribute(MemberInfo memberInfo) { }

	// RVA: 0xDE6238
	public static bool IsNonSerializable(object provider) { }

	// RVA: 0xDE5680
	public static bool IsSerializable(object provider) { }

	// RVA: 0x316B894
	public static T GetAttribute(object provider) { }

	// RVA: 0xDE62C0
	public static bool get_FullyTrusted() { }

	// RVA: 0xDE5E18
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0xDE64F0
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public class KebabCaseNamingStrategy
{
	// Methods

	// RVA: 0xDE6C64
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xDE6CA8
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xDE6CEC
	public void .ctor() { }

	// RVA: 0xDE6CF4
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

	// RVA: 0xDE6D00
	public bool get_ProcessDictionaryKeys() { }

	// RVA: 0xDE6D08
	public void set_ProcessDictionaryKeys(bool value) { }

	// RVA: 0xDE6D10
	public bool get_ProcessExtensionDataNames() { }

	// RVA: 0xDE6D18
	public void set_ProcessExtensionDataNames(bool value) { }

	// RVA: 0xDE6D20
	public bool get_OverrideSpecifiedNames() { }

	// RVA: 0xDE6D28
	public void set_OverrideSpecifiedNames(bool value) { }

	// RVA: 0xDE6D30
	public virtual string GetPropertyName(string name, bool hasSpecifiedName) { }

	// RVA: 0xDE6D50
	public virtual string GetExtensionDataName(string name) { }

	// RVA: 0xDE6D6C
	public virtual string GetDictionaryKey(string key) { }

	// RVA: -1
	protected abstract string ResolvePropertyName(string name) { }

	// RVA: 0xDE6D88
	public override int GetHashCode() { }

	// RVA: 0xDE6E70
	public override bool Equals(object obj) { }

	// RVA: 0xDE6F0C
	protected bool Equals(NamingStrategy other) { }

	// RVA: 0xDE6CA0
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ObjectConstructor<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x30B1D84
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

	// RVA: 0xDE7048
	public void .ctor(object attributeProvider) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class ReflectionValueProvider
{
	// Fields
	private readonly MemberInfo _memberInfo; // 0x10

	// Methods

	// RVA: 0xDE70C0
	public void .ctor(MemberInfo memberInfo) { }

	// RVA: 0xDE7138
	public void SetValue(object target, object value) { }

	// RVA: 0xDE72E4
	public object GetValue(object target) { }

}

// Namespace: Newtonsoft.Json.Serialization
public class SnakeCaseNamingStrategy
{
	// Methods

	// RVA: 0xDE75A4
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0xDE75E0
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0xDE7624
	public void .ctor() { }

	// RVA: 0xDE762C
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

	// RVA: 0xDE7638
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0xDE77A8
	public string GetDeserializedJsonMessage() { }

	// RVA: 0xDE77CC
	public override bool Read() { }

	// RVA: 0xDE786C
	public override System.Nullable<System.Int32> ReadAsInt32() { }

	// RVA: 0xDE78D0
	public override string ReadAsString() { }

	// RVA: 0xDE7934
	public override Byte[] ReadAsBytes() { }

	// RVA: 0xDE799C
	public override System.Nullable<System.Decimal> ReadAsDecimal() { }

	// RVA: 0xDE7A48
	public override System.Nullable<System.Double> ReadAsDouble() { }

	// RVA: 0xDE7AC0
	public override System.Nullable<System.Boolean> ReadAsBoolean() { }

	// RVA: 0xDE7B28
	public override System.Nullable<System.DateTime> ReadAsDateTime() { }

	// RVA: 0xDE7BA0
	public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0xDE7830
	public void WriteCurrentToken() { }

	// RVA: 0xDE7C20
	public override int get_Depth() { }

	// RVA: 0xDE7C44
	public override string get_Path() { }

	// RVA: 0xDE7C68
	public override JsonToken get_TokenType() { }

	// RVA: 0xDE7C8C
	public override object get_Value() { }

	// RVA: 0xDE7CB0
	public override Type get_ValueType() { }

	// RVA: 0xDE7CD4
	public override void Close() { }

	// RVA: 0xDE7CFC
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xDE7DD4
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xDE7EB0
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

	// RVA: 0xDE7F8C
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0xDE8198
	public string GetSerializedJsonMessage() { }

	// RVA: 0xDE81BC
	public override void WriteValue(Decimal value) { }

	// RVA: 0xDE8234
	public override void WriteValue(System.Nullable<System.Decimal> value) { }

	// RVA: 0xDE83F8
	public override void WriteValue(bool value) { }

	// RVA: 0xDE845C
	public override void WriteValue(System.Nullable<System.Boolean> value) { }

	// RVA: 0xDE85EC
	public override void WriteValue(Byte value) { }

	// RVA: 0xDE8650
	public override void WriteValue(System.Nullable<System.Byte> value) { }

	// RVA: 0xDE87E0
	public override void WriteValue(Char value) { }

	// RVA: 0xDE8844
	public override void WriteValue(System.Nullable<System.Char> value) { }

	// RVA: 0xDE89D4
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xDE8A4C
	public override void WriteValue(DateTime value) { }

	// RVA: 0xDE8AB0
	public override void WriteValue(System.Nullable<System.DateTime> value) { }

	// RVA: 0xDE8C48
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xDE8CC0
	public override void WriteValue(System.Nullable<System.DateTimeOffset> value) { }

	// RVA: 0xDE8E68
	public override void WriteValue(Double value) { }

	// RVA: 0xDE8ED4
	public override void WriteValue(System.Nullable<System.Double> value) { }

	// RVA: 0xDE906C
	public override void WriteUndefined() { }

	// RVA: 0xDE90C4
	public override void WriteNull() { }

	// RVA: 0xDE911C
	public override void WriteValue(float value) { }

	// RVA: 0xDE9188
	public override void WriteValue(System.Nullable<System.Single> value) { }

	// RVA: 0xDE9314
	public override void WriteValue(Guid value) { }

	// RVA: 0xDE938C
	public override void WriteValue(System.Nullable<System.Guid> value) { }

	// RVA: 0xDE9534
	public override void WriteValue(int value) { }

	// RVA: 0xDE9598
	public override void WriteValue(System.Nullable<System.Int32> value) { }

	// RVA: 0xDE9724
	public override void WriteValue(Int64 value) { }

	// RVA: 0xDE9788
	public override void WriteValue(System.Nullable<System.Int64> value) { }

	// RVA: 0xDE9920
	public override void WriteValue(object value) { }

	// RVA: 0xDE9A38
	public override void WriteValue(SByte value) { }

	// RVA: 0xDE9A9C
	public override void WriteValue(System.Nullable<System.SByte> value) { }

	// RVA: 0xDE9C2C
	public override void WriteValue(Int16 value) { }

	// RVA: 0xDE9C90
	public override void WriteValue(System.Nullable<System.Int16> value) { }

	// RVA: 0xDE9E20
	public override void WriteValue(string value) { }

	// RVA: 0xDE9E84
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xDE9EE8
	public override void WriteValue(System.Nullable<System.TimeSpan> value) { }

	// RVA: 0xDEA080
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xDEA0E4
	public override void WriteValue(System.Nullable<System.UInt32> value) { }

	// RVA: 0xDEA270
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xDEA2D4
	public override void WriteValue(System.Nullable<System.UInt64> value) { }

	// RVA: 0xDEA46C
	public override void WriteValue(Uri value) { }

	// RVA: 0xDEA554
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xDEA5B8
	public override void WriteValue(System.Nullable<System.UInt16> value) { }

	// RVA: 0xDEA748
	public override void WriteComment(string text) { }

	// RVA: 0xDEA7AC
	public override void WriteStartArray() { }

	// RVA: 0xDEA7FC
	public override void WriteEndArray() { }

	// RVA: 0xDEA84C
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xDEA8A8
	public override void WriteEndConstructor() { }

	// RVA: 0xDEA8F8
	public override void WritePropertyName(string name) { }

	// RVA: 0xDEA95C
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0xDEA9D0
	public override void WriteStartObject() { }

	// RVA: 0xDEAA20
	public override void WriteEndObject() { }

	// RVA: 0xDEAA70
	public override void WriteRawValue(string json) { }

	// RVA: 0xDEAAD4
	public override void WriteRaw(string json) { }

	// RVA: 0xDEAB38
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

	// RVA: 0xDEAB88
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDEAB90
	public override JTokenType get_Type() { }

	// RVA: 0xDEAB98
	public void .ctor() { }

	// RVA: 0xDEAD08
	internal void .ctor(JArray other, JsonCloneSettings settings) { }

	// RVA: 0xDEB150
	public void .ctor(object content) { }

	// RVA: 0xDEB238
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDEB310
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xDEB818
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDEB904
	public JToken get_Item(int index) { }

	// RVA: 0xDEB914
	public void set_Item(int index, JToken value) { }

	// RVA: 0xDEB924
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xDEB998
	public int IndexOf(JToken item) { }

	// RVA: 0xDEB9A8
	public void Insert(int index, JToken item) { }

	// RVA: 0xDEB9C0
	public void RemoveAt(int index) { }

	// RVA: 0xDEB9D0
	public System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }

	// RVA: 0xDEBA6C
	public void Add(JToken item) { }

	// RVA: 0xDEBA7C
	public void Clear() { }

	// RVA: 0xDEBA8C
	public bool Contains(JToken item) { }

	// RVA: 0xDEBA9C
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xDEBAAC
	public bool get_IsReadOnly() { }

	// RVA: 0xDEBAB4
	public bool Remove(JToken item) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JConstructor
{
	// Fields
	private string _name; // 0x58
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Linq.JToken> _values; // 0x60

	// Methods

	// RVA: 0xDEBAC4
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDEBACC
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xDEBB40
	public string get_Name() { }

	// RVA: 0xDEBB48
	public override JTokenType get_Type() { }

	// RVA: 0xDEBB50
	internal void .ctor(JConstructor other, JsonCloneSettings settings) { }

	// RVA: 0xDEBC08
	public void .ctor(string name) { }

	// RVA: 0xDEBDB4
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDEBE20
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDEBF18
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

	// RVA: 0xDEC110
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xDEC1C4
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: -1
	protected abstract System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDEAC80
	internal void .ctor() { }

	// RVA: 0xDEADA8
	internal void .ctor(JContainer other, JsonCloneSettings settings) { }

	// RVA: 0xDEC6B4
	internal void CheckReentrancy() { }

	// RVA: 0xDEC760
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0xDEC784
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xDEC814
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	// RVA: 0xDEC8A4
	public override bool get_HasValues() { }

	// RVA: 0xDEC968
	public override JToken get_First() { }

	// RVA: 0xDECACC
	public override JToken get_Last() { }

	// RVA: 0xDECC30
	public override Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }

	// RVA: 0xDECCB0
	internal bool IsMultiContent(object content) { }

	// RVA: 0xDECDAC
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: -1
	internal abstract int IndexOfItem(JToken item) { }

	// RVA: 0xDECF84
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDED3EC
	internal virtual void RemoveItemAt(int index) { }

	// RVA: 0xDED8F0
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0xDED958
	internal virtual JToken GetItem(int index) { }

	// RVA: 0xDEDA20
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0xDEE140
	internal virtual void ClearItems() { }

	// RVA: 0xDEE584
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	// RVA: 0xDEE5EC
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0xDEE614
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0xDEE078
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0xDEEBA8
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xDEECC8
	public virtual void Add(object content) { }

	// RVA: 0xDEEDA4
	internal bool TryAdd(object content) { }

	// RVA: 0xDEEE80
	internal void AddAndSkipParentCheck(JToken token) { }

	// RVA: 0xDEC334
	internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDEEF5C
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0xDEF118
	public void RemoveAll() { }

	// RVA: 0xDEB6B8
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0xDEF128
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	// RVA: 0xDEF90C
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	// RVA: 0xDEFE88
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xDEFED4
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xDF0084
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0xDF0094
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0xDF00AC
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0xDF00BC
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0xDF00CC
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0xDF00DC
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0xDF00EC
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0xDF00FC
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0xDF010C
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xDF011C
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0xDF0124
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	// RVA: 0xDF0134
	private JToken EnsureValue(object value) { }

	// RVA: 0xDF01F4
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xDF02D4
	private void System.Collections.IList.Clear() { }

	// RVA: 0xDF02E4
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xDF031C
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xDF0354
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xDF03A8
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xDF03B0
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xDF03B8
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xDF03F0
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xDF0400
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xDF0410
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xDF045C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xDEEAE0
	public int get_Count() { }

	// RVA: 0xDF046C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xDF0474
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xDF0500
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xDF0504
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xDF06D0
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xDF06D8
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xDF06E0
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xDF06E8
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xDF0728
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xDF0768
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xDF0770
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xDF0774
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xDF07B4
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xDF07BC
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xDF07C4
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xDF07CC
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xDF07D4
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

}

// Namespace: Newtonsoft.Json.Linq
public struct JEnumerable<T0>
{
	// Fields
	public static readonly Newtonsoft.Json.Linq.JEnumerable<T> Empty; // 0x0
	private readonly System.Collections.Generic.IEnumerable<T> _enumerable; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.IEnumerable<T> enumerable) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x316B894
	public bool Equals(Newtonsoft.Json.Linq.JEnumerable<T> other) { }

	// RVA: 0x30B183C
	public override bool Equals(object obj) { }

	// RVA: 0x30B199C
	public override int GetHashCode() { }

	// RVA: 0x30B71FC
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

	// RVA: 0xDF398C
	private static void .cctor() { }

	// RVA: 0xDF39F8
	public void .ctor() { }

	// RVA: 0xDF3A00
	internal string <GetDynamicMemberNames>b__2_0(JProperty p) { }

}

// Namespace: 
private class JObjectDynamicProxy
{
	// Methods

	// RVA: 0xDF3640
	public override bool TryGetMember(JObject instance, GetMemberBinder binder, object result) { }

	// RVA: 0xDF36F0
	public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value) { }

	// RVA: 0xDF3830
	public override System.Collections.Generic.IEnumerable<System.String> GetDynamicMemberNames(JObject instance) { }

	// RVA: 0xDF35EC
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

	// RVA: 0xDF2B80
	public void .ctor(int <>1__state) { }

	// RVA: 0xDF3A1C
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDF3AF0
	private bool MoveNext() { }

	// RVA: 0xDF3E84
	private void <>m__Finally1() { }

	// RVA: 0xDF3F48
	private System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	// RVA: 0xDF3F54
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xDF3F94
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

	// RVA: 0xDF07DC
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDF07E4
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xDF0888
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xDF092C
	public void add_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0xDF09D0
	public void remove_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: 0xDEF67C
	public void .ctor() { }

	// RVA: 0xDF0B10
	public void .ctor(JObject other) { }

	// RVA: 0xDF0C0C
	internal void .ctor(JObject other, JsonCloneSettings settings) { }

	// RVA: 0xDF0D0C
	public void .ctor(object[] content) { }

	// RVA: 0xDF0D10
	public void .ctor(object content) { }

	// RVA: 0xDF0E58
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xDF0FD8
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDF1064
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0xDF136C
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0xDF14B4
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0xDF14DC
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDF1548
	public override JTokenType get_Type() { }

	// RVA: 0xDF1550
	public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties() { }

	// RVA: 0xDEFB48
	public JProperty Property(string name, StringComparison comparison) { }

	// RVA: 0xDF15A4
	public JToken get_Item(string propertyName) { }

	// RVA: 0xDF1628
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0xDF187C
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xDF1A4C
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDF17F4
	public void Add(string propertyName, JToken value) { }

	// RVA: 0xDF1D08
	public bool ContainsKey(string propertyName) { }

	// RVA: 0xDF1E34
	private System.Collections.Generic.ICollection<System.String> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	// RVA: 0xDF1EF0
	public bool Remove(string propertyName) { }

	// RVA: 0xDF1FFC
	public bool TryGetValue(string propertyName, JToken value) { }

	// RVA: 0xDF2054
	private System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0xDF2094
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xDF2250
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0xDF2260
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xDF23F0
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>[] array, int arrayIndex) { }

	// RVA: 0xDF291C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0xDF2924
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken> item) { }

	// RVA: 0xDF2B08
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>> GetEnumerator() { }

	// RVA: 0xDF2BAC
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0xDF2C40
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0xDF2CD4
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xDF2D7C
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xDF3278
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xDF32F4
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xDF32FC
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xDF3304
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xDF335C
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xDF3364
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xDF336C
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xDF3374
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xDF33F0
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xDF346C
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xDF3500
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

	// RVA: 0xDF4A00
	public void .ctor(int <>1__state) { }

	// RVA: 0xDF4C88
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDF4C8C
	private bool MoveNext() { }

	// RVA: 0xDF4D08
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	// RVA: 0xDF4D10
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xDF4D50
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
private class JPropertyList
{
	// Fields
	internal JToken _token; // 0x10

	// Methods

	// RVA: 0xDF4988
	public System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> GetEnumerator() { }

	// RVA: 0xDF4A2C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xDF4AA4
	public void Add(JToken item) { }

	// RVA: 0xDF4AAC
	public void Clear() { }

	// RVA: 0xDF4AB8
	public bool Contains(JToken item) { }

	// RVA: 0xDF4AC8
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0xDF4B4C
	public bool Remove(JToken item) { }

	// RVA: 0xDF4B9C
	public int get_Count() { }

	// RVA: 0xDF4BAC
	public bool get_IsReadOnly() { }

	// RVA: 0xDF4474
	public int IndexOf(JToken item) { }

	// RVA: 0xDF4BB4
	public void Insert(int index, JToken item) { }

	// RVA: 0xDF4BC8
	public void RemoveAt(int index) { }

	// RVA: 0xDF4BDC
	public JToken get_Item(int index) { }

	// RVA: 0xDF4C30
	public void set_Item(int index, JToken value) { }

	// RVA: 0xDF40B0
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JProperty
{
	// Fields
	private readonly JPropertyList _content; // 0x58
	private readonly string _name; // 0x60

	// Methods

	// RVA: 0xDF3FFC
	protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> get_ChildrenTokens() { }

	// RVA: 0xDF4004
	public string get_Name() { }

	// RVA: 0xDEF65C
	public JToken get_Value() { }

	// RVA: 0xDF1770
	public void set_Value(JToken value) { }

	// RVA: 0xDF400C
	internal void .ctor(JProperty other, JsonCloneSettings settings) { }

	// RVA: 0xDF40B8
	internal override JToken GetItem(int index) { }

	// RVA: 0xDF4118
	internal override void SetItem(int index, JToken item) { }

	// RVA: 0xDF42DC
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0xDF438C
	internal override void RemoveItemAt(int index) { }

	// RVA: 0xDF443C
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0xDF4484
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0xDF45B4
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0xDF45DC
	internal override void ClearItems() { }

	// RVA: 0xDF468C
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDF46F8
	public override JTokenType get_Type() { }

	// RVA: 0xDEFD24
	internal void .ctor(string name) { }

	// RVA: 0xDF1B4C
	public void .ctor(string name, object content) { }

	// RVA: 0xDF4700
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDF4790
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JPropertyDescriptor
{
	// Methods

	// RVA: 0xDF326C
	public void .ctor(string name) { }

	// RVA: 0xDF4D58
	public override bool CanResetValue(object component) { }

	// RVA: 0xDF4D60
	public override object GetValue(object component) { }

	// RVA: 0xDF4E78
	public override void ResetValue(object component) { }

	// RVA: 0xDF4E7C
	public override void SetValue(object component, object value) { }

	// RVA: 0xDF5014
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xDF501C
	public override Type get_ComponentType() { }

	// RVA: 0xDF50BC
	public override bool get_IsReadOnly() { }

	// RVA: 0xDF50C4
	public override Type get_PropertyType() { }

	// RVA: 0xDF5164
	protected override int get_NameHashCode() { }

}

// Namespace: Newtonsoft.Json.Linq
internal class JPropertyKeyedCollection
{
	// Fields
	private static readonly System.Collections.Generic.IEqualityComparer<System.String> Comparer; // 0x0
	private System.Collections.Generic.Dictionary<System.String,Newtonsoft.Json.Linq.JToken> _dictionary; // 0x18

	// Methods

	// RVA: 0xDF0A74
	public void .ctor() { }

	// RVA: 0xDF516C
	private void AddKey(string key, JToken item) { }

	// RVA: 0xDF52AC
	protected override void ClearItems() { }

	// RVA: 0xDF1D78
	public bool Contains(string key) { }

	// RVA: 0xDF51E0
	private void EnsureDictionary() { }

	// RVA: 0xDF5334
	private string GetKeyForItem(JToken item) { }

	// RVA: 0xDF53B8
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0xDF54E8
	protected override void RemoveItem(int index) { }

	// RVA: 0xDF5670
	private void RemoveKey(string key) { }

	// RVA: 0xDF56E0
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0xDF12E0
	public bool TryGetValue(string key, JToken value) { }

	// RVA: 0xDF1E94
	public System.Collections.Generic.ICollection<System.String> get_Keys() { }

	// RVA: 0xDF0F28
	public int IndexOfReference(JToken t) { }

	// RVA: 0xDF5A28
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JRaw
{
	// Methods

	// RVA: 0xDF5B0C
	internal void .ctor(JRaw other, JsonCloneSettings settings) { }

	// RVA: 0xDF5C34
	public void .ctor(object rawJson) { }

	// RVA: 0xDF5D44
	public static JRaw Create(JsonReader reader) { }

	// RVA: 0xDF6090
	internal override JToken CloneToken(JsonCloneSettings settings) { }

}

// Namespace: Newtonsoft.Json.Linq
public class JsonCloneSettings
{
	// Fields
	internal static readonly JsonCloneSettings SkipCopyAnnotations; // 0x0
	private bool <CopyAnnotations>k__BackingField; // 0x10

	// Methods

	// RVA: 0xDF60FC
	public void .ctor() { }

	// RVA: 0xDF6128
	public bool get_CopyAnnotations() { }

	// RVA: 0xDF6130
	public void set_CopyAnnotations(bool value) { }

	// RVA: 0xDF6138
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

	// RVA: 0xDF61A8
	public CommentHandling get_CommentHandling() { }

	// RVA: 0xDF61B0
	public LineInfoHandling get_LineInfoHandling() { }

	// RVA: 0xDF61B8
	public DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }

}

// Namespace: 
private class LineInfoAnnotation
{
	// Fields
	internal readonly int LineNumber; // 0x10
	internal readonly int LinePosition; // 0x14

	// Methods

	// RVA: 0xDFEA04
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

	// RVA: 0xDF61C0
	public JContainer get_Parent() { }

	// RVA: 0xDF61C8
	internal void set_Parent(JContainer value) { }

	// RVA: 0xDECF6C
	public JToken get_Root() { }

	// RVA: -1
	internal abstract JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: -1
	public abstract JTokenType get_Type() { }

	// RVA: -1
	public abstract bool get_HasValues() { }

	// RVA: 0xDF61D0
	public JToken get_Next() { }

	// RVA: 0xDF61D8
	internal void set_Next(JToken value) { }

	// RVA: 0xDF61E0
	public JToken get_Previous() { }

	// RVA: 0xDF61E8
	internal void set_Previous(JToken value) { }

	// RVA: 0xDF61F0
	public string get_Path() { }

	// RVA: 0xDEC278
	internal void .ctor() { }

	// RVA: 0xDF6500
	public virtual JToken get_First() { }

	// RVA: 0xDF6594
	public virtual JToken get_Last() { }

	// RVA: 0xDF6628
	public virtual Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { }

	// RVA: 0xDF1F84
	public void Remove() { }

	// RVA: 0xDEFE0C
	public void Replace(JToken value) { }

	// RVA: -1
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xDF66A4
	public override string ToString() { }

	// RVA: 0xDF678C
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0xDF69B0
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0xDF6AE8
	private static string GetType(JToken token) { }

	// RVA: 0xDF6BE4
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0xDF6CC4
	public static bool op_Explicit(JToken value) { }

	// RVA: 0xDF6F6C
	public static DateTimeOffset op_Explicit(JToken value) { }

	// RVA: 0xDF7240
	public static System.Nullable<System.Boolean> op_Explicit(JToken value) { }

	// RVA: 0xDF752C
	public static Int64 op_Explicit(JToken value) { }

	// RVA: 0xDF77B4
	public static System.Nullable<System.DateTime> op_Explicit(JToken value) { }

	// RVA: 0xDF7A78
	public static System.Nullable<System.DateTimeOffset> op_Explicit(JToken value) { }

	// RVA: 0xDF7DB8
	public static System.Nullable<System.Decimal> op_Explicit(JToken value) { }

	// RVA: 0xDF80A8
	public static System.Nullable<System.Double> op_Explicit(JToken value) { }

	// RVA: 0xDF8350
	public static System.Nullable<System.Char> op_Explicit(JToken value) { }

	// RVA: 0xDF8614
	public static int op_Explicit(JToken value) { }

	// RVA: 0xDF889C
	public static Int16 op_Explicit(JToken value) { }

	// RVA: 0xDF8B24
	public static UInt16 op_Explicit(JToken value) { }

	// RVA: 0xDF8DAC
	public static Char op_Explicit(JToken value) { }

	// RVA: 0xDF9034
	public static Byte op_Explicit(JToken value) { }

	// RVA: 0xDF92BC
	public static SByte op_Explicit(JToken value) { }

	// RVA: 0xDF9544
	public static System.Nullable<System.Int32> op_Explicit(JToken value) { }

	// RVA: 0xDF97EC
	public static System.Nullable<System.Int16> op_Explicit(JToken value) { }

	// RVA: 0xDF9AB0
	public static System.Nullable<System.UInt16> op_Explicit(JToken value) { }

	// RVA: 0xDF9D74
	public static System.Nullable<System.Byte> op_Explicit(JToken value) { }

	// RVA: 0xDFA038
	public static System.Nullable<System.SByte> op_Explicit(JToken value) { }

	// RVA: 0xDFA2FC
	public static DateTime op_Explicit(JToken value) { }

	// RVA: 0xDFA584
	public static System.Nullable<System.Int64> op_Explicit(JToken value) { }

	// RVA: 0xDFA82C
	public static System.Nullable<System.Single> op_Explicit(JToken value) { }

	// RVA: 0xDFAAD4
	public static Decimal op_Explicit(JToken value) { }

	// RVA: 0xDFAD5C
	public static System.Nullable<System.UInt32> op_Explicit(JToken value) { }

	// RVA: 0xDFB004
	public static System.Nullable<System.UInt64> op_Explicit(JToken value) { }

	// RVA: 0xDFB2AC
	public static Double op_Explicit(JToken value) { }

	// RVA: 0xDFB534
	public static float op_Explicit(JToken value) { }

	// RVA: 0xDFB7BC
	public static string op_Explicit(JToken value) { }

	// RVA: 0xDFBAEC
	public static UInt32 op_Explicit(JToken value) { }

	// RVA: 0xDFBD74
	public static UInt64 op_Explicit(JToken value) { }

	// RVA: 0xDFBFFC
	public static Guid op_Explicit(JToken value) { }

	// RVA: 0xDFC28C
	public static System.Nullable<System.Guid> op_Explicit(JToken value) { }

	// RVA: 0xDFC5A0
	public static TimeSpan op_Explicit(JToken value) { }

	// RVA: 0xDFC820
	public static System.Nullable<System.TimeSpan> op_Explicit(JToken value) { }

	// RVA: 0xDFCADC
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0xDFCD58
	private static BigInteger ToBigInteger(JToken value) { }

	// RVA: 0xDFCF24
	private static System.Nullable<System.Numerics.BigInteger> ToBigIntegerNullable(JToken value) { }

	// RVA: 0xDFD178
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xDFD22C
	private System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: 0xDFD2C8
	public JsonReader CreateReader() { }

	// RVA: 0xDFD3F0
	public object ToObject(Type objectType) { }

	// RVA: 0xDFE288
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0xDFE504
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0xDFE58C
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0xDEB4BC
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0xDFE988
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0xDFECA0
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xDFED00
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xDFED60
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xDFEDC0
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0xDFEE94
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0xDFEEA4
	private object System.ICloneable.Clone() { }

	// RVA: 0xDFEEB4
	public JToken DeepClone() { }

	// RVA: 0xDFEA3C
	public void AddAnnotation(object annotation) { }

	// RVA: 0x316B894
	public T Annotation() { }

	// RVA: 0xDEC280
	internal void CopyAnnotations(JToken target, JToken source) { }

	// RVA: 0xDFEEC4
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

	// RVA: 0xDFF1D0
	public JToken get_CurrentToken() { }

	// RVA: 0xDFD378
	public void .ctor(JToken token) { }

	// RVA: 0xDFF1D8
	public override bool Read() { }

	// RVA: 0xDFF3E4
	private bool ReadOver(JToken t) { }

	// RVA: 0xDFFC04
	private bool ReadToEnd() { }

	// RVA: 0xDFFDB8
	private System.Nullable<Newtonsoft.Json.JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0xDFF350
	private bool ReadInto(JContainer c) { }

	// RVA: 0xDFFC40
	private bool SetEnd(JContainer c) { }

	// RVA: 0xDFF4D0
	private void SetToken(JToken token) { }

	// RVA: 0xDFFF28
	private string SafeToString(object value) { }

	// RVA: 0xDFFF48
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0xE00010
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0xE000DC
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0xE001A8
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

	// RVA: 0xE002C8
	public JToken get_Token() { }

	// RVA: 0xE002E4
	public void .ctor() { }

	// RVA: 0xE0036C
	public override void Close() { }

	// RVA: 0xE00374
	public override void WriteStartObject() { }

	// RVA: 0xE00420
	private void AddParent(JContainer container) { }

	// RVA: 0xE0048C
	private void RemoveParent() { }

	// RVA: 0xE0050C
	public override void WriteStartArray() { }

	// RVA: 0xE005B8
	public override void WriteStartConstructor(string name) { }

	// RVA: 0xE00670
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0xE00674
	public override void WritePropertyName(string name) { }

	// RVA: 0xE0077C
	private void AddRawValue(object value, JTokenType type, JsonToken token) { }

	// RVA: 0xE00844
	internal void AddJValue(JValue value, JsonToken token) { }

	// RVA: 0xE00910
	public override void WriteValue(object value) { }

	// RVA: 0xE009B0
	public override void WriteNull() { }

	// RVA: 0xE009E0
	public override void WriteUndefined() { }

	// RVA: 0xE00A10
	public override void WriteRaw(string json) { }

	// RVA: 0xE00AE8
	public override void WriteComment(string text) { }

	// RVA: 0xE00BB8
	public override void WriteValue(string value) { }

	// RVA: 0xE00D14
	public override void WriteValue(int value) { }

	// RVA: 0xE00DA0
	public override void WriteValue(UInt32 value) { }

	// RVA: 0xE00E2C
	public override void WriteValue(Int64 value) { }

	// RVA: 0xE00F74
	public override void WriteValue(UInt64 value) { }

	// RVA: 0xE010B8
	public override void WriteValue(float value) { }

	// RVA: 0xE0120C
	public override void WriteValue(Double value) { }

	// RVA: 0xE01364
	public override void WriteValue(bool value) { }

	// RVA: 0xE014AC
	public override void WriteValue(Int16 value) { }

	// RVA: 0xE01538
	public override void WriteValue(UInt16 value) { }

	// RVA: 0xE015C4
	public override void WriteValue(Char value) { }

	// RVA: 0xE01714
	public override void WriteValue(Byte value) { }

	// RVA: 0xE017A0
	public override void WriteValue(SByte value) { }

	// RVA: 0xE0182C
	public override void WriteValue(Decimal value) { }

	// RVA: 0xE01998
	public override void WriteValue(DateTime value) { }

	// RVA: 0xE01B20
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0xE01C84
	public override void WriteValue(Byte[] value) { }

	// RVA: 0xE01D5C
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0xE01EA0
	public override void WriteValue(Guid value) { }

	// RVA: 0xE02004
	public override void WriteValue(Uri value) { }

	// RVA: 0xE02184
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

}

// Namespace: 
private class JValueDynamicProxy
{
	// Methods

	// RVA: 0xE05A78
	public override bool TryConvert(JValue instance, ConvertBinder binder, object result) { }

	// RVA: 0xE05C64
	public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, object result) { }

	// RVA: 0xE05164
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Linq
public class JValue
{
	// Fields
	private JTokenType _valueType; // 0x30
	private object _value; // 0x38

	// Methods

	// RVA: 0xDF5CB8
	internal void .ctor(object value, JTokenType type) { }

	// RVA: 0xDF5B10
	internal void .ctor(JValue other, JsonCloneSettings settings) { }

	// RVA: 0xE00EA8
	public void .ctor(Int64 value) { }

	// RVA: 0xE018BC
	public void .ctor(Decimal value) { }

	// RVA: 0xE00FF0
	public void .ctor(UInt64 value) { }

	// RVA: 0xE01290
	public void .ctor(Double value) { }

	// RVA: 0xE0113C
	public void .ctor(float value) { }

	// RVA: 0xE01A58
	public void .ctor(DateTime value) { }

	// RVA: 0xE01BB0
	public void .ctor(DateTimeOffset value) { }

	// RVA: 0xE013E0
	public void .ctor(bool value) { }

	// RVA: 0xE00C90
	public void .ctor(string value) { }

	// RVA: 0xE01F30
	public void .ctor(Guid value) { }

	// RVA: 0xE02080
	public void .ctor(Uri value) { }

	// RVA: 0xE01DD8
	public void .ctor(TimeSpan value) { }

	// RVA: 0xDEF084
	public void .ctor(object value) { }

	// RVA: 0xE0292C
	public override bool get_HasValues() { }

	// RVA: 0xE02934
	private static int CompareBigInteger(BigInteger i1, object i2) { }

	// RVA: 0xE02CB0
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	// RVA: 0xE03724
	private static int CompareFloat(object objA, object objB) { }

	// RVA: 0xE03868
	private static bool Operation(ExpressionType operation, object objA, object objB, object result) { }

	// RVA: 0xE04178
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0xDEF7A0
	public static JValue CreateComment(string value) { }

	// RVA: 0xDECEB8
	public static JValue CreateNull() { }

	// RVA: 0xDEF858
	public static JValue CreateUndefined() { }

	// RVA: 0xE02488
	private static JTokenType GetValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current, object value) { }

	// RVA: 0xE041E4
	private static JTokenType GetStringValueType(System.Nullable<Newtonsoft.Json.Linq.JTokenType> current) { }

	// RVA: 0xE043AC
	public override JTokenType get_Type() { }

	// RVA: 0xE043B4
	public object get_Value() { }

	// RVA: 0xE043BC
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0xE04D10
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0xE04D78
	public bool Equals(JValue other) { }

	// RVA: 0xE04DE0
	public override bool Equals(object obj) { }

	// RVA: 0xE04EBC
	public override int GetHashCode() { }

	// RVA: 0xE04ED4
	public override string ToString() { }

	// RVA: 0xE04F40
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0xE04F4C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xE05078
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0xE051B8
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xE05274
	public int CompareTo(JValue obj) { }

	// RVA: 0xE052A4
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0xE05374
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0xE053F4
	private Char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0xE05474
	private SByte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0xE054F4
	private Byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0xE05574
	private Int16 System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0xE055F4
	private UInt16 System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0xE05674
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0xE056F4
	private UInt32 System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0xE05774
	private Int64 System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0xE057F4
	private UInt64 System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0xE05874
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0xE058F4
	private Double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0xE05974
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0xE059F4
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0xE05A74
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

	// RVA: 0xE05FF0
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE06054
	private Byte[] GetByteArray(object value) { }

	// RVA: 0xE06254
	private static void EnsureReflectionObject(Type t) { }

	// RVA: 0xE06410
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0684C
	private Byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0xE06B80
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE06CA8
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class BsonObjectIdConverter
{
	// Methods

	// RVA: 0xE06CB0
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE06DB4
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE06F40
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE06FCC
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public abstract class CustomCreationConverter<T0>
{
	// Methods

	// RVA: 0x30B30EC
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30B1F4C
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: -1
	public abstract T Create(Type objectType) { }

	// RVA: 0x30B183C
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x30B171C
	public override bool get_CanWrite() { }

	// RVA: 0x30B2870
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class DataSetConverter
{
	// Methods

	// RVA: 0xE06FD4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE07478
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE077DC
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xE07894
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class DataTableConverter
{
	// Methods

	// RVA: 0xE0789C
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE08034
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0832C
	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	// RVA: 0xE08860
	private static Type GetColumnDataType(JsonReader reader) { }

	// RVA: 0xE08A58
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xE08B10
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public abstract class DateTimeConverterBase
{
	// Methods

	// RVA: 0xE08B18
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE08C90
	protected void .ctor() { }

}

// Namespace: 
internal class Union
{
	// Fields
	public readonly FSharpFunction TagReader; // 0x10
	public readonly System.Collections.Generic.List<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases; // 0x18

	// Methods

	// RVA: 0xE09830
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

	// RVA: 0xE09880
	public void .ctor(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public int tag; // 0x10

	// Methods

	// RVA: 0xE09E08
	public void .ctor() { }

	// RVA: 0xE0A9B8
	internal bool <WriteJson>b__0(UnionCase c) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public string caseName; // 0x10
	public System.Func<Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase,System.Boolean> <>9__0; // 0x18

	// Methods

	// RVA: 0xE0A4F0
	public void .ctor() { }

	// RVA: 0xE0A9E0
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

	// RVA: 0xE08C98
	private static Type CreateUnionTypeLookup(Type t) { }

	// RVA: 0xE08F1C
	private static Union CreateUnion(Type t) { }

	// RVA: 0xE09908
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE09E10
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0A4F8
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE0A81C
	public void .ctor() { }

	// RVA: 0xE0A824
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

	// RVA: 0xE0AA08
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE0AECC
	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	// RVA: 0xE0AFBC
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0ADA8
	private static void EnsureReflectionObject(Type objectType) { }

	// RVA: 0xE0B2BC
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE0B318
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class ExpandoObjectConverter
{
	// Methods

	// RVA: 0xE0B320
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE0B324
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0B328
	private object ReadValue(JsonReader reader) { }

	// RVA: 0xE0B6EC
	private object ReadList(JsonReader reader) { }

	// RVA: 0xE0B498
	private object ReadObject(JsonReader reader) { }

	// RVA: 0xE0B8CC
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE0B958
	public override bool get_CanWrite() { }

	// RVA: 0xE0B960
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

	// RVA: 0xE0B968
	public DateTimeStyles get_DateTimeStyles() { }

	// RVA: 0xE0B970
	public void set_DateTimeStyles(DateTimeStyles value) { }

	// RVA: 0xE0B978
	public string get_DateTimeFormat() { }

	// RVA: 0xE0B9E4
	public void set_DateTimeFormat(string value) { }

	// RVA: 0xE0BA28
	public CultureInfo get_Culture() { }

	// RVA: 0xE0BAA4
	public void set_Culture(CultureInfo value) { }

	// RVA: 0xE0BAAC
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE0BDCC
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0C4AC
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class JavaScriptDateTimeConverter
{
	// Methods

	// RVA: 0xE0C4BC
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE0C6A8
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0CA14
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

	// RVA: 0xE0CA1C
	private static ReflectionObject InitializeReflectionObject(Type t) { }

	// RVA: 0xE0CC9C
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE0CF28
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0D420
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE0D570
	public void .ctor() { }

	// RVA: 0xE0D578
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class RegexConverter
{
	// Fields
	private const string PatternName = "Pattern";
	private const string OptionsName = "Options";

	// Methods

	// RVA: 0xE0D664
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE0DAB4
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0xE0D780
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0xE0D8EC
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0xE0DB74
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0DF2C
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0xE0DC24
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0xE0E08C
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE0E108
	private bool IsRegex(Type objectType) { }

	// RVA: 0xE0E194
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class StringEnumConverter
{
	// Fields
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x10
	private bool <AllowIntegerValues>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE0E19C
	public bool get_CamelCaseText() { }

	// RVA: 0xE0E224
	public void set_CamelCaseText(bool value) { }

	// RVA: 0xE0E30C
	public NamingStrategy get_NamingStrategy() { }

	// RVA: 0xE0E314
	public void set_NamingStrategy(NamingStrategy value) { }

	// RVA: 0xE0E31C
	public bool get_AllowIntegerValues() { }

	// RVA: 0xE0E324
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0xE0E32C
	public void .ctor() { }

	// RVA: 0xE0E33C
	public void .ctor(bool camelCaseText) { }

	// RVA: 0xE0E3D4
	public void .ctor(NamingStrategy namingStrategy, bool allowIntegerValues) { }

	// RVA: 0xE0E424
	public void .ctor(Type namingStrategyType) { }

	// RVA: 0xE0E4E0
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters) { }

	// RVA: 0xE0E5A0
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) { }

	// RVA: 0xE0E674
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE0E884
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0ED54
	public override bool CanConvert(Type objectType) { }

}

// Namespace: Newtonsoft.Json.Converters
public class UnixDateTimeConverter
{
	// Fields
	internal static readonly DateTime UnixEpoch; // 0x0
	private bool <AllowPreEpoch>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE0EE04
	public bool get_AllowPreEpoch() { }

	// RVA: 0xE0EE0C
	public void set_AllowPreEpoch(bool value) { }

	// RVA: 0xE0EE14
	public void .ctor() { }

	// RVA: 0xE0EE3C
	public void .ctor(bool allowPreEpoch) { }

	// RVA: 0xE0EE68
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE0F0D4
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0F534
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Converters
public class VersionConverter
{
	// Methods

	// RVA: 0xE0F5B4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE0F6AC
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE0F958
	public override bool CanConvert(Type objectType) { }

	// RVA: 0xE0F9E4
	public void .ctor() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDocumentWrapper
{
	// Fields
	private readonly XmlDocument _document; // 0x28

	// Methods

	// RVA: 0xE0F9EC
	public void .ctor(XmlDocument document) { }

	// RVA: 0xE0FA64
	public IXmlNode CreateComment(string data) { }

	// RVA: 0xE0FB00
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xE0FB9C
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xE0FC38
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xE0FCD4
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xE0FD70
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE0FE78
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE0FF84
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE10028
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xE10110
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xE101BC
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xE10294
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xE10358
	public IXmlElement get_DocumentElement() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlElementWrapper
{
	// Fields
	private readonly XmlElement _element; // 0x28

	// Methods

	// RVA: 0xE100CC
	public void .ctor(XmlElement element) { }

	// RVA: 0xE10414
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xE10508
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xE10530
	public bool get_IsEmpty() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDeclarationWrapper
{
	// Fields
	private readonly XmlDeclaration _declaration; // 0x28

	// Methods

	// RVA: 0xE0FE34
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0xE10550
	public string get_Version() { }

	// RVA: 0xE10570
	public string get_Encoding() { }

	// RVA: 0xE10590
	public string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XmlDocumentTypeWrapper
{
	// Fields
	private readonly XmlDocumentType _documentType; // 0x28

	// Methods

	// RVA: 0xE0FF40
	public void .ctor(XmlDocumentType documentType) { }

	// RVA: 0xE105B0
	public string get_Name() { }

	// RVA: 0xE105D4
	public string get_System() { }

	// RVA: 0xE105F4
	public string get_Public() { }

	// RVA: 0xE10614
	public string get_InternalSubset() { }

	// RVA: 0xE10634
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

	// RVA: 0xE0FA30
	public void .ctor(XmlNode node) { }

	// RVA: 0xE10678
	public object get_WrappedNode() { }

	// RVA: 0xE10680
	public XmlNodeType get_NodeType() { }

	// RVA: 0xE106A4
	public virtual string get_LocalName() { }

	// RVA: 0xE106CC
	public System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE10AA8
	internal static IXmlNode WrapNode(XmlNode node) { }

	// RVA: 0xE10C40
	public System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE11090
	private bool get_HasAttributes() { }

	// RVA: 0xE11144
	public IXmlNode get_ParentNode() { }

	// RVA: 0xE111FC
	public string get_Value() { }

	// RVA: 0xE10270
	public void set_Value(string value) { }

	// RVA: 0xE11220
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE112EC
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

	// RVA: 0xE11314
	internal XDeclaration get_Declaration() { }

	// RVA: 0xE1131C
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0xE11394
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xE1139C
	public string get_Version() { }

	// RVA: 0xE113BC
	public string get_Encoding() { }

	// RVA: 0xE113DC
	public string get_Standalone() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDocumentTypeWrapper
{
	// Fields
	private readonly XDocumentType _documentType; // 0x18

	// Methods

	// RVA: 0xE113FC
	public void .ctor(XDocumentType documentType) { }

	// RVA: 0xE11440
	public string get_Name() { }

	// RVA: 0xE11460
	public string get_System() { }

	// RVA: 0xE11480
	public string get_Public() { }

	// RVA: 0xE114A0
	public string get_InternalSubset() { }

	// RVA: 0xE114C0
	public override string get_LocalName() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XDocumentWrapper
{
	// Methods

	// RVA: 0xE11504
	private XDocument get_Document() { }

	// RVA: 0xE11580
	public void .ctor(XDocument document) { }

	// RVA: 0xE115E8
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE11C6C
	protected override bool get_HasChildNodes() { }

	// RVA: 0xE11E00
	public IXmlNode CreateComment(string text) { }

	// RVA: 0xE11EA0
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0xE11F40
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0xE11FE0
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0xE12080
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0xE12120
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0xE121E8
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0xE122C0
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0xE123A4
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0xE12488
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0xE12550
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0xE12644
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	// RVA: 0xE12714
	public IXmlElement get_DocumentElement() { }

	// RVA: 0xE12884
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XTextWrapper
{
	// Methods

	// RVA: 0xE12AFC
	private XText get_Text() { }

	// RVA: 0xE12B78
	public void .ctor(XText text) { }

	// RVA: 0xE12BAC
	public override string get_Value() { }

	// RVA: 0xE12C30
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XCommentWrapper
{
	// Methods

	// RVA: 0xE13044
	private XComment get_Text() { }

	// RVA: 0xE130C0
	public void .ctor(XComment text) { }

	// RVA: 0xE130F4
	public override string get_Value() { }

	// RVA: 0xE13178
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XProcessingInstructionWrapper
{
	// Methods

	// RVA: 0xE13274
	private XProcessingInstruction get_ProcessingInstruction() { }

	// RVA: 0xE12370
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0xE132F0
	public override string get_LocalName() { }

	// RVA: 0xE13374
	public override string get_Value() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XContainerWrapper
{
	// Fields
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _childNodes; // 0x18

	// Methods

	// RVA: 0xE133F8
	private XContainer get_Container() { }

	// RVA: 0xE115B4
	public void .ctor(XContainer container) { }

	// RVA: 0xE11864
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE11D70
	protected virtual bool get_HasChildNodes() { }

	// RVA: 0xE13474
	public override IXmlNode get_ParentNode() { }

	// RVA: 0xE12D2C
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0xE12998
	public override IXmlNode AppendChild(IXmlNode newChild) { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XObjectWrapper
{
	// Fields
	private readonly XObject _xmlObject; // 0x10

	// Methods

	// RVA: 0xE11360
	public void .ctor(XObject xmlObject) { }

	// RVA: 0xE13570
	public object get_WrappedNode() { }

	// RVA: 0xE13578
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0xE13590
	public virtual string get_LocalName() { }

	// RVA: 0xE13598
	public virtual System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_ChildNodes() { }

	// RVA: 0xE13614
	public virtual System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE13690
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0xE13698
	public virtual string get_Value() { }

	// RVA: 0xE136A0
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE136E0
	public virtual string get_NamespaceUri() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XAttributeWrapper
{
	// Methods

	// RVA: 0xE136E8
	private XAttribute get_Attribute() { }

	// RVA: 0xE12610
	public void .ctor(XAttribute attribute) { }

	// RVA: 0xE13764
	public override string get_Value() { }

	// RVA: 0xE137E8
	public override string get_LocalName() { }

	// RVA: 0xE13874
	public override string get_NamespaceUri() { }

	// RVA: 0xE13900
	public override IXmlNode get_ParentNode() { }

}

// Namespace: Newtonsoft.Json.Converters
internal class XElementWrapper
{
	// Fields
	private System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> _attributes; // 0x20

	// Methods

	// RVA: 0xE139FC
	private XElement get_Element() { }

	// RVA: 0xE12454
	public void .ctor(XElement element) { }

	// RVA: 0xE13A78
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0xE13B80
	public override System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> get_Attributes() { }

	// RVA: 0xE14120
	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	// RVA: 0xE14710
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0xE14748
	public override string get_Value() { }

	// RVA: 0xE147CC
	public override string get_LocalName() { }

	// RVA: 0xE14858
	public override string get_NamespaceUri() { }

	// RVA: 0xE1465C
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0xE148E4
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

	// RVA: 0xE14968
	public string get_DeserializeRootElementName() { }

	// RVA: 0xE14970
	public void set_DeserializeRootElementName(string value) { }

	// RVA: 0xE14978
	public bool get_WriteArrayAttribute() { }

	// RVA: 0xE14980
	public void set_WriteArrayAttribute(bool value) { }

	// RVA: 0xE14988
	public bool get_OmitRootObject() { }

	// RVA: 0xE14990
	public void set_OmitRootObject(bool value) { }

	// RVA: 0xE14998
	public bool get_EncodeSpecialCharacters() { }

	// RVA: 0xE149A0
	public void set_EncodeSpecialCharacters(bool value) { }

	// RVA: 0xE149A8
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xE14AF4
	private IXmlNode WrapXml(object value) { }

	// RVA: 0xE14C10
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE16C68
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE17020
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0xE174F8
	private bool IsArray(IXmlNode node) { }

	// RVA: 0xE17904
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xE18544
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> groupedNodes, string elementNames) { }

	// RVA: 0xE186C8
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	// RVA: 0xE153D8
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0xE1879C
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0xE18E48
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xE1A34C
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0xE1973C
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0xE1C750
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, System.Collections.Generic.Dictionary<System.String,System.String> attributeNameValues) { }

	// RVA: 0xE1C3C4
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0xE1A938
	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0xE1B8A4
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0xE1D2B8
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0xE1BCD8
	private bool ShouldReadInto(JsonReader reader) { }

	// RVA: 0xE1BD1C
	private System.Collections.Generic.Dictionary<System.String,System.String> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0xE1B01C
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0xE1B4CC
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0xE1D0A0
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0xE19AE0
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0xE1D60C
	private bool IsNamespaceAttribute(string attributeName, string prefix) { }

	// RVA: 0xE18AD8
	private bool ValueAttributes(System.Collections.Generic.List<Newtonsoft.Json.Converters.IXmlNode> c) { }

	// RVA: 0xE1D700
	public override bool CanConvert(Type valueType) { }

	// RVA: 0xE1D7B8
	private bool IsXObject(Type valueType) { }

	// RVA: 0xE1D870
	private bool IsXmlNode(Type valueType) { }

	// RVA: 0xE1D928
	public void .ctor() { }

	// RVA: 0xE1D930
	private static void .cctor() { }

}

// Namespace: Newtonsoft.Json.Bson
public class BsonObjectId
{
	// Fields
	private readonly Byte[] <Value>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE1D9CC
	public Byte[] get_Value() { }

	// RVA: 0xE1D9D4
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

	// RVA: 0xE1DABC
	public void set_Parent(BsonToken value) { }

	// RVA: 0xE1DAC4
	protected void .ctor() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonObject
{
	// Fields
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonProperty> _children; // 0x18

	// Methods

	// RVA: 0xE1DACC
	public void Add(string name, BsonToken token) { }

	// RVA: 0xE1DC38
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonArray
{
	// Fields
	private readonly System.Collections.Generic.List<Newtonsoft.Json.Bson.BsonToken> _children; // 0x18

	// Methods

	// RVA: 0xE1DC40
	public void Add(BsonToken token) { }

	// RVA: 0xE1DCB8
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonValue
{
	// Fields
	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	// Methods

	// RVA: 0xE1DCC0
	public void .ctor(object value, BsonType type) { }

	// RVA: 0xE1DD08
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonString
{
	// Fields
	private readonly bool <IncludeLength>k__BackingField; // 0x21

	// Methods

	// RVA: 0xE1DBE8
	public void .ctor(object value, bool includeLength) { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonRegex
{
	// Fields
	private BsonString <Pattern>k__BackingField; // 0x18
	private BsonString <Options>k__BackingField; // 0x20

	// Methods

	// RVA: 0xE1DD10
	public void set_Pattern(BsonString value) { }

	// RVA: 0xE1DD18
	public void set_Options(BsonString value) { }

	// RVA: 0xE1DD20
	public void .ctor(string pattern, string options) { }

	// RVA: 0xE1DDF8
	public override BsonType get_Type() { }

}

// Namespace: Newtonsoft.Json.Bson
internal class BsonProperty
{
	// Fields
	private BsonString <Name>k__BackingField; // 0x10
	private BsonToken <Value>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE1DE00
	public void set_Name(BsonString value) { }

	// RVA: 0xE1DE08
	public void set_Value(BsonToken value) { }

	// RVA: 0xE1DBE0
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

	// RVA: 0xE1DE10
	private void AddValue(object value, BsonType type) { }

	// RVA: 0xE1DE9C
	internal void AddToken(BsonToken token) { }

	// RVA: 0xE1E0EC
	public void WriteObjectId(Byte[] value) { }

	// RVA: 0xE0DAC0
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


