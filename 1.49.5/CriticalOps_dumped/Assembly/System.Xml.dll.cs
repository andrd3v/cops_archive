// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0x101F0C4
	internal static string GetString(string name, object[] args) { }

	// RVA: 0x101F138
	internal static string GetString(CultureInfo culture, string name, object[] args) { }

	// RVA: 0x101F140
	internal static string Format(string resourceFormat, object p1) { }

}

// Namespace: Microsoft.CSharp
internal class CodeDomProvider
{
	// Methods

	// RVA: 0x101F1B4
	public void .ctor() { }

}

// Namespace: Microsoft.CSharp
internal class CSharpCodeProvider
{
	// Methods

	// RVA: 0x101F1BC
	public void .ctor() { }

}

// Namespace: System
internal class MonoTODOAttribute
{
	// Methods

	// RVA: 0x101F1C4
	public void .ctor() { }

}

// Namespace: System
internal static class LocalAppContextSwitches
{
	// Fields
	public static readonly bool IgnoreEmptyKeySequences; // 0x0
	public static readonly bool DontThrowOnInvalidSurrogatePairs; // 0x1
}

// Namespace: System.Xml
internal static class AsyncHelper
{
	// Fields
	public static readonly Task DoneTask; // 0x0
	public static readonly System.Threading.Tasks.Task<System.Boolean> DoneTaskTrue; // 0x8
	public static readonly System.Threading.Tasks.Task<System.Boolean> DoneTaskFalse; // 0x10
	public static readonly System.Threading.Tasks.Task<System.Int32> DoneTaskZero; // 0x18

	// Methods

	// RVA: 0x101F1CC
	private static void .cctor() { }

}

// Namespace: System.Xml
internal abstract class Base64Encoder
{
	// Fields
	private Byte[] leftOverBytes; // 0x10
	private int leftOverBytesCount; // 0x18
	private Char[] charsLine; // 0x20

	// Methods

	// RVA: 0x101F304
	internal void .ctor() { }

	// RVA: -1
	internal abstract void WriteChars(Char[] chars, int index, int count) { }

	// RVA: 0x101F374
	internal void Encode(Byte[] buffer, int index, int count) { }

	// RVA: 0x101F718
	internal void Flush() { }

}

// Namespace: System.Xml
internal class XmlRawWriterBase64Encoder
{
	// Fields
	private XmlRawWriter rawWriter; // 0x28

	// Methods

	// RVA: 0x101F7C4
	internal void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0x101F848
	internal override void WriteChars(Char[] chars, int index, int count) { }

}

// Namespace: System.Xml
internal class XmlTextWriterBase64Encoder
{
	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0x101F870
	internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0x101F8F4
	internal override void WriteChars(Char[] chars, int index, int count) { }

}

// Namespace: System.Xml
internal class BinHexDecoder
{
	// Fields
	private Byte[] buffer; // 0x10
	private int curIndex; // 0x18
	private int endIndex; // 0x1C
	private bool hasHalfByteCached; // 0x20
	private Byte cachedHalfByte; // 0x21

	// Methods

	// RVA: 0x101F914
	internal override bool get_IsFull() { }

	// RVA: 0x101F924
	internal override int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0x101FD28
	public static Byte[] Decode(Char[] chars, bool allowOddChars) { }

	// RVA: 0x101FA9C
	private static void Decode(Char* pChars, Char* pCharsEndPos, Byte* pBytes, Byte* pBytesEndPos, bool hasHalfByteCached, Byte cachedHalfByte, int charsDecoded, int bytesDecoded) { }

}

// Namespace: System.Xml
internal static class BinHexEncoder
{
	// Methods

	// RVA: 0x101FF14
	internal static void Encode(Byte[] buffer, int index, int count, XmlWriter writer) { }

	// RVA: 0x1020220
	internal static string Encode(Byte[] inArray, int offsetIn, int count) { }

	// RVA: 0x10200E4
	private static int Encode(Byte[] inArray, int offsetIn, int count, Char[] outArray) { }

}

// Namespace: System.Xml
internal enum BinXmlToken
{
	// Fields
	public int value__; // 0x10
	public const BinXmlToken Error = 0;
	public const BinXmlToken NotImpl = 4294967294;
	public const BinXmlToken EOF = 4294967295;
	public const BinXmlToken XmlDecl = 254;
	public const BinXmlToken Encoding = 253;
	public const BinXmlToken DocType = 252;
	public const BinXmlToken System = 251;
	public const BinXmlToken Public = 250;
	public const BinXmlToken Subset = 249;
	public const BinXmlToken Element = 248;
	public const BinXmlToken EndElem = 247;
	public const BinXmlToken Attr = 246;
	public const BinXmlToken EndAttrs = 245;
	public const BinXmlToken PI = 244;
	public const BinXmlToken Comment = 243;
	public const BinXmlToken CData = 242;
	public const BinXmlToken EndCData = 241;
	public const BinXmlToken Name = 240;
	public const BinXmlToken QName = 239;
	public const BinXmlToken XmlText = 237;
	public const BinXmlToken Nest = 236;
	public const BinXmlToken EndNest = 235;
	public const BinXmlToken Extn = 234;
	public const BinXmlToken NmFlush = 233;
	public const BinXmlToken SQL_BIT = 6;
	public const BinXmlToken SQL_TINYINT = 7;
	public const BinXmlToken SQL_SMALLINT = 1;
	public const BinXmlToken SQL_INT = 2;
	public const BinXmlToken SQL_BIGINT = 8;
	public const BinXmlToken SQL_REAL = 3;
	public const BinXmlToken SQL_FLOAT = 4;
	public const BinXmlToken SQL_MONEY = 5;
	public const BinXmlToken SQL_SMALLMONEY = 20;
	public const BinXmlToken SQL_DATETIME = 18;
	public const BinXmlToken SQL_SMALLDATETIME = 19;
	public const BinXmlToken SQL_DECIMAL = 10;
	public const BinXmlToken SQL_NUMERIC = 11;
	public const BinXmlToken SQL_UUID = 9;
	public const BinXmlToken SQL_VARBINARY = 15;
	public const BinXmlToken SQL_BINARY = 12;
	public const BinXmlToken SQL_IMAGE = 23;
	public const BinXmlToken SQL_CHAR = 13;
	public const BinXmlToken SQL_VARCHAR = 16;
	public const BinXmlToken SQL_TEXT = 22;
	public const BinXmlToken SQL_NVARCHAR = 17;
	public const BinXmlToken SQL_NCHAR = 14;
	public const BinXmlToken SQL_NTEXT = 24;
	public const BinXmlToken SQL_UDT = 27;
	public const BinXmlToken XSD_KATMAI_DATE = 127;
	public const BinXmlToken XSD_KATMAI_DATETIME = 126;
	public const BinXmlToken XSD_KATMAI_TIME = 125;
	public const BinXmlToken XSD_KATMAI_DATEOFFSET = 124;
	public const BinXmlToken XSD_KATMAI_DATETIMEOFFSET = 123;
	public const BinXmlToken XSD_KATMAI_TIMEOFFSET = 122;
	public const BinXmlToken XSD_BOOLEAN = 134;
	public const BinXmlToken XSD_TIME = 129;
	public const BinXmlToken XSD_DATETIME = 130;
	public const BinXmlToken XSD_DATE = 131;
	public const BinXmlToken XSD_BINHEX = 132;
	public const BinXmlToken XSD_BASE64 = 133;
	public const BinXmlToken XSD_DECIMAL = 135;
	public const BinXmlToken XSD_BYTE = 136;
	public const BinXmlToken XSD_UNSIGNEDSHORT = 137;
	public const BinXmlToken XSD_UNSIGNEDINT = 138;
	public const BinXmlToken XSD_UNSIGNEDLONG = 139;
	public const BinXmlToken XSD_QNAME = 140;
}

// Namespace: System.Xml
internal struct BinXmlSqlDecimal
{
	// Fields
	internal Byte m_bLen; // 0x10
	internal Byte m_bPrec; // 0x11
	internal Byte m_bScale; // 0x12
	internal Byte m_bSign; // 0x13
	internal UInt32 m_data1; // 0x14
	internal UInt32 m_data2; // 0x18
	internal UInt32 m_data3; // 0x1C
	internal UInt32 m_data4; // 0x20
	private static readonly Byte NUMERIC_MAX_PRECISION; // 0x0
	private static readonly Byte MaxPrecision; // 0x1
	private static readonly Byte MaxScale; // 0x2
	private static readonly int x_cNumeMax; // 0x4
	private static readonly Int64 x_lInt32Base; // 0x8
	private static readonly UInt64 x_ulInt32Base; // 0x10
	private static readonly UInt64 x_ulInt32BaseForMod; // 0x18
	internal static readonly UInt64 x_llMax; // 0x20
	private static readonly Double DUINT_BASE; // 0x28
	private static readonly Double DUINT_BASE2; // 0x30
	private static readonly Double DUINT_BASE3; // 0x38
	private static readonly UInt32[] x_rgulShiftBase; // 0x40
	private static readonly Byte[] rgCLenFromPrec; // 0x48

	// Methods

	// RVA: 0x1020378
	public bool get_IsPositive() { }

	// RVA: 0x1020388
	public void .ctor(Byte[] data, int offset, bool trim) { }

	// RVA: 0x1020638
	private static UInt32 UIntFromByteArray(Byte[] data, int offset) { }

	// RVA: 0x1020894
	private static void MpDiv1(UInt32[] rgulU, int ciulU, UInt32 iulD, UInt32 iulR) { }

	// RVA: 0x10209CC
	private static void MpNormalize(UInt32[] rgulU, int ciulU) { }

	// RVA: 0x1020A20
	private static Char ChFromDigit(UInt32 uiDigit) { }

	// RVA: 0x1020A2C
	public Decimal ToDecimal() { }

	// RVA: 0x10206AC
	private void TrimTrailingZeros() { }

	// RVA: 0x1020B54
	public override string ToString() { }

	// RVA: 0x102106C
	private static void .cctor() { }

}

// Namespace: System.Xml
internal struct BinXmlSqlMoney
{
	// Fields
	private Int64 data; // 0x10

	// Methods

	// RVA: 0x10211B4
	public void .ctor(int v) { }

	// RVA: 0x10211C0
	public void .ctor(Int64 v) { }

	// RVA: 0x10211C8
	public Decimal ToDecimal() { }

	// RVA: 0x102123C
	public override string ToString() { }

}

// Namespace: System.Xml
internal abstract class BinXmlDateTime
{
	// Fields
	internal static int[] KatmaiTimeScaleMultiplicator; // 0x0
	private static readonly Double SQLTicksPerMillisecond; // 0x8
	public static readonly int SQLTicksPerSecond; // 0x10
	public static readonly int SQLTicksPerMinute; // 0x14
	public static readonly int SQLTicksPerHour; // 0x18
	private static readonly int SQLTicksPerDay; // 0x1C

	// Methods

	// RVA: 0x1021358
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x10213C8
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x1021524
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x10215E0
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x1021720
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x1021960
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x1021C14
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x1021D3C
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x1021E74
	private static void BreakDownXsdDateTime(Int64 val, int yr, int mnth, int day, int hr, int min, int sec, int ms) { }

	// RVA: 0x1022040
	private static void BreakDownXsdDate(Int64 val, int yr, int mnth, int day, bool negTimeZone, int hr, int min) { }

	// RVA: 0x10221AC
	private static void BreakDownXsdTime(Int64 val, int hr, int min, int sec, int ms) { }

	// RVA: 0x10222BC
	public static string XsdDateTimeToString(Int64 val) { }

	// RVA: 0x10223D4
	public static string XsdDateToString(Int64 val) { }

	// RVA: 0x10224C4
	public static string XsdTimeToString(Int64 val) { }

	// RVA: 0x102268C
	public static string SqlDateTimeToString(int dateticks, UInt32 timeticks) { }

	// RVA: 0x10227E4
	public static DateTime SqlDateTimeToDateTime(int dateticks, UInt32 timeticks) { }

	// RVA: 0x10228E4
	public static string SqlSmallDateTimeToString(Int16 dateticks, UInt16 timeticks) { }

	// RVA: 0x1022A44
	public static DateTime SqlSmallDateTimeToDateTime(Int16 dateticks, UInt16 timeticks) { }

	// RVA: 0x1022AB8
	public static DateTime XsdKatmaiDateToDateTime(Byte[] data, int offset) { }

	// RVA: 0x1022C18
	public static DateTime XsdKatmaiDateTimeToDateTime(Byte[] data, int offset) { }

	// RVA: 0x1022F48
	public static DateTime XsdKatmaiTimeToDateTime(Byte[] data, int offset) { }

	// RVA: 0x1022FD4
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x1023060
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x10231FC
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x1023288
	public static string XsdKatmaiDateToString(Byte[] data, int offset) { }

	// RVA: 0x10233B0
	public static string XsdKatmaiDateTimeToString(Byte[] data, int offset) { }

	// RVA: 0x1023650
	public static string XsdKatmaiTimeToString(Byte[] data, int offset) { }

	// RVA: 0x10237D4
	public static string XsdKatmaiDateOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x1023960
	public static string XsdKatmaiDateTimeOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x1023C44
	public static string XsdKatmaiTimeOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x1022BA0
	private static Int64 GetKatmaiDateTicks(Byte[] data, int pos) { }

	// RVA: 0x1022D1C
	private static Int64 GetKatmaiTimeTicks(Byte[] data, int pos) { }

	// RVA: 0x10231A4
	private static Int64 GetKatmaiTimeZoneTicks(Byte[] data, int pos) { }

	// RVA: 0x1023538
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x1023B00
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x1023DE0
	private static void .cctor() { }

}

// Namespace: 
private enum ScanState
{
	// Fields
	public int value__; // 0x10
	public const ScanState Doc = 0;
	public const ScanState XmlText = 1;
	public const ScanState Attr = 2;
	public const ScanState AttrVal = 3;
	public const ScanState AttrValPseudoValue = 4;
	public const ScanState Init = 5;
	public const ScanState Error = 6;
	public const ScanState EOF = 7;
	public const ScanState Closed = 8;
}

// Namespace: 
internal struct QName
{
	// Fields
	public string prefix; // 0x10
	public string localname; // 0x18
	public string namespaceUri; // 0x20

	// Methods

	// RVA: 0x102A9BC
	public void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0x10291F4
	public void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0x10245AC
	public void Clear() { }

	// RVA: 0x102A170
	public bool MatchNs(string lname, string nsUri) { }

	// RVA: 0x102A1C0
	public bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0x102A5BC
	public void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0x102ECB8
	public override int GetHashCode() { }

	// RVA: 0x102ED08
	public int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0x102ED60
	public override bool Equals(object other) { }

	// RVA: 0x102BB20
	public override string ToString() { }

	// RVA: 0x102EE1C
	public static bool op_Equality(QName a, QName b) { }

}

// Namespace: 
private struct ElemInfo
{
	// Fields
	public QName name; // 0x10
	public string xmlLang; // 0x28
	public XmlSpace xmlSpace; // 0x30
	public bool xmlspacePreserve; // 0x34
	public NamespaceDecl nsdecls; // 0x38

	// Methods

	// RVA: 0x102D044
	public void Set(QName name, bool xmlspacePreserve) { }

	// RVA: 0x102BDC8
	public NamespaceDecl Clear() { }

}

// Namespace: 
private struct AttrInfo
{
	// Fields
	public QName name; // 0x10
	public string val; // 0x28
	public int contentPos; // 0x30
	public int hashCode; // 0x34
	public int prevHash; // 0x38

	// Methods

	// RVA: 0x102AA0C
	public void Set(QName n, string v) { }

	// RVA: 0x102B08C
	public void Set(QName n, int pos) { }

	// RVA: 0x102BA90
	public void GetLocalnameAndNamespaceUri(string localname, string namespaceUri) { }

	// RVA: 0x102BB94
	public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, string localname, string namespaceUri) { }

	// RVA: 0x102BAD0
	public bool MatchNS(string localname, string namespaceUri) { }

	// RVA: 0x102BC14
	public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

	// RVA: 0x102978C
	public void AdjustPosition(int adj) { }

}

// Namespace: 
private class NamespaceDecl
{
	// Fields
	public string prefix; // 0x10
	public string uri; // 0x18
	public NamespaceDecl scopeLink; // 0x20
	public NamespaceDecl prevLink; // 0x28
	public int scope; // 0x30
	public bool implied; // 0x34

	// Methods

	// RVA: 0x1028BF0
	public void .ctor(string prefix, string nsuri, NamespaceDecl nextInScope, NamespaceDecl prevDecl, int scope, bool implied) { }

}

// Namespace: 
private struct SymbolTables
{
	// Fields
	public string[] symtable; // 0x10
	public int symCount; // 0x18
	public QName[] qnametable; // 0x20
	public int qnameCount; // 0x28

	// Methods

	// RVA: 0x10244C8
	public void Init() { }

}

// Namespace: 
private class NestedBinXml
{
	// Fields
	public SymbolTables symbolTables; // 0x10
	public int docState; // 0x30
	public NestedBinXml next; // 0x38

	// Methods

	// RVA: 0x102D094
	public void .ctor(SymbolTables symbolTables, int docState, NestedBinXml next) { }

}

// Namespace: System.Xml
internal sealed class XmlSqlBinaryReader
{
	// Fields
	internal static readonly Type TypeOfObject; // 0x0
	internal static readonly Type TypeOfString; // 0x8
	private static Type[] TokenTypeMap; // 0x10
	private static Byte[] XsdKatmaiTimeScaleToValueLengthMap; // 0x18
	private static ReadState[] ScanState2ReadState; // 0x20
	private Stream inStrm; // 0x10
	private Byte[] data; // 0x18
	private int pos; // 0x20
	private int mark; // 0x24
	private int end; // 0x28
	private Int64 offset; // 0x30
	private bool eof; // 0x38
	private bool sniffed; // 0x39
	private bool isEmpty; // 0x3A
	private int docState; // 0x3C
	private SymbolTables symbolTables; // 0x40
	private XmlNameTable xnt; // 0x60
	private bool xntFromSettings; // 0x68
	private string xml; // 0x70
	private string xmlns; // 0x78
	private string nsxmlns; // 0x80
	private string baseUri; // 0x88
	private ScanState state; // 0x90
	private XmlNodeType nodetype; // 0x94
	private BinXmlToken token; // 0x98
	private int attrIndex; // 0x9C
	private QName qnameOther; // 0xA0
	private QName qnameElement; // 0xB8
	private XmlNodeType parentNodeType; // 0xD0
	private ElemInfo[] elementStack; // 0xD8
	private int elemDepth; // 0xE0
	private AttrInfo[] attributes; // 0xE8
	private int[] attrHashTbl; // 0xF0
	private int attrCount; // 0xF8
	private int posAfterAttrs; // 0xFC
	private bool xmlspacePreserve; // 0x100
	private int tokLen; // 0x104
	private int tokDataPos; // 0x108
	private bool hasTypedValue; // 0x10C
	private Type valueType; // 0x110
	private string stringValue; // 0x118
	private System.Collections.Generic.Dictionary<System.String,System.Xml.XmlSqlBinaryReader.NamespaceDecl> namespaces; // 0x120
	private NestedBinXml prevNameInfo; // 0x128
	private XmlReader textXmlReader; // 0x130
	private bool closeInput; // 0x138
	private bool checkCharacters; // 0x139
	private bool ignoreWhitespace; // 0x13A
	private bool ignorePIs; // 0x13B
	private bool ignoreComments; // 0x13C
	private DtdProcessing dtdProcessing; // 0x140
	private SecureStringHasher hasher; // 0x148
	private XmlCharType xmlCharType; // 0x150
	private Encoding unicode; // 0x158
	private Byte version; // 0x160

	// Methods

	// RVA: 0x1023EA8
	public void .ctor(Stream stream, Byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0x1025380
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x10254A8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x10254B0
	public override string get_LocalName() { }

	// RVA: 0x10254B8
	public override string get_NamespaceURI() { }

	// RVA: 0x10254C0
	public override string get_Prefix() { }

	// RVA: 0x10254C8
	public override string get_Value() { }

	// RVA: 0x10263E0
	public override int get_Depth() { }

	// RVA: 0x10264BC
	public override string get_BaseURI() { }

	// RVA: 0x10264C4
	public override bool get_IsEmptyElement() { }

	// RVA: 0x10264E8
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1026570
	public override string get_XmlLang() { }

	// RVA: 0x1026638
	public override Type get_ValueType() { }

	// RVA: 0x1026640
	public override int get_AttributeCount() { }

	// RVA: 0x102669C
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0x1026910
	public override string GetAttribute(string name) { }

	// RVA: 0x1026A98
	public override string GetAttribute(int i) { }

	// RVA: 0x1026B38
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1026CDC
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1026D90
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1026E24
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1026EBC
	public override bool MoveToElement() { }

	// RVA: 0x1026FAC
	public override bool get_EOF() { }

	// RVA: 0x1026FBC
	public override bool ReadAttributeValue() { }

	// RVA: 0x10274B4
	public override void Close() { }

	// RVA: 0x1027558
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1027560
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x102763C
	public override void ResolveEntity() { }

	// RVA: 0x102767C
	public override ReadState get_ReadState() { }

	// RVA: 0x1027720
	public override bool Read() { }

	// RVA: 0x10284F4
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1028934
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1028B0C
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0x1024630
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0x1028C8C
	private void AddName() { }

	// RVA: 0x1028E84
	private void AddQName() { }

	// RVA: 0x1029244
	private void NameFlush() { }

	// RVA: 0x10292A0
	private void SkipExtn() { }

	// RVA: 0x102947C
	private int ReadQNameRef() { }

	// RVA: 0x102914C
	private int ReadNameRef() { }

	// RVA: 0x1029524
	private bool FillAllowEOF() { }

	// RVA: 0x10297A0
	private void Fill_(int require) { }

	// RVA: 0x10293EC
	private void Fill(int require) { }

	// RVA: 0x1029894
	private Byte ReadByte() { }

	// RVA: 0x1029944
	private UInt16 ReadUShort() { }

	// RVA: 0x10293B0
	private int ParseMB32() { }

	// RVA: 0x1029A14
	private int ParseMB32_(Byte b) { }

	// RVA: 0x1029ABC
	private int ParseMB32(int pos) { }

	// RVA: 0x1029BC4
	private int ParseMB64() { }

	// RVA: 0x1029C00
	private BinXmlToken PeekToken() { }

	// RVA: 0x1029C7C
	private BinXmlToken ReadToken() { }

	// RVA: 0x1029D00
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0x1029E0C
	private BinXmlToken NextToken1() { }

	// RVA: 0x1029EFC
	private BinXmlToken NextToken() { }

	// RVA: 0x1029F64
	private BinXmlToken PeekNextToken() { }

	// RVA: 0x10271D4
	private BinXmlToken RescanNextToken() { }

	// RVA: 0x1028DB8
	private string ParseText() { }

	// RVA: 0x1029FE4
	private int ScanText(int start) { }

	// RVA: 0x1025628
	private string GetString(int pos, int cch) { }

	// RVA: 0x102A130
	private string GetStringAligned(Byte[] data, int offset, int cch) { }

	// RVA: 0x102627C
	private string GetAttributeText(int i) { }

	// RVA: 0x1026848
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0x1026990
	private int LocateAttribute(string name) { }

	// RVA: 0x1026BF0
	private void PositionOnAttribute(int i) { }

	// RVA: 0x102A20C
	private void GrowElements() { }

	// RVA: 0x102A29C
	private void GrowAttributes() { }

	// RVA: 0x102A334
	private void ClearAttributes() { }

	// RVA: 0x102A344
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0x102A6B8
	private void PopNamespaces(NamespaceDecl firstInScopeChain) { }

	// RVA: 0x102A790
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0x1027910
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0x102AA5C
	private void ScanAttributes() { }

	// RVA: 0x102B4A8
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0x102B640
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0x102595C
	private string XmlDeclValue() { }

	// RVA: 0x1025798
	private string CDATAValue() { }

	// RVA: 0x102BC70
	private void FinishCDATA() { }

	// RVA: 0x102BD5C
	private void FinishEndElement() { }

	// RVA: 0x1027F48
	private bool ReadDoc() { }

	// RVA: 0x102CDF0
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0x102BDF4
	private void ImplReadElement() { }

	// RVA: 0x102C170
	private void ImplReadEndElement() { }

	// RVA: 0x102C254
	private void ImplReadDoctype() { }

	// RVA: 0x102C65C
	private void ImplReadPI() { }

	// RVA: 0x102C6CC
	private void ImplReadComment() { }

	// RVA: 0x102C704
	private void ImplReadCDATA() { }

	// RVA: 0x102C790
	private void ImplReadNest() { }

	// RVA: 0x102C8A8
	private void ImplReadEndNest() { }

	// RVA: 0x102C904
	private void ImplReadXmlText() { }

	// RVA: 0x102D0F0
	private void UpdateFromTextReader() { }

	// RVA: 0x1026BC8
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0x102CFC8
	private void CheckAllowContent() { }

	// RVA: 0x1024750
	private void GenerateTokenTypeMap() { }

	// RVA: 0x10273A8
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0x102739C
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0x102B1CC
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x102D470
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x102D1C8
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0x102D3CC
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0x102D9B4
	private void CheckValueTokenBounds() { }

	// RVA: 0x102D85C
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0x102DA20
	private int XsdKatmaiTimeScaleToValueLength(Byte scale) { }

	// RVA: 0x102DAF4
	private Int64 ValueAsLong() { }

	// RVA: 0x102E474
	private UInt64 ValueAsULong() { }

	// RVA: 0x102E22C
	private Decimal ValueAsDecimal() { }

	// RVA: 0x102E0B4
	private Double ValueAsDouble() { }

	// RVA: 0x102E660
	private string ValueAsDateTimeString() { }

	// RVA: 0x1025B14
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0x102DD84
	private Int16 GetInt16(int pos) { }

	// RVA: 0x102DF1C
	private UInt16 GetUInt16(int pos) { }

	// RVA: 0x102DDD0
	private int GetInt32(int pos) { }

	// RVA: 0x102DF68
	private UInt32 GetUInt32(int pos) { }

	// RVA: 0x102DE48
	private Int64 GetInt64(int pos) { }

	// RVA: 0x102DFE0
	private UInt64 GetUInt64(int pos) { }

	// RVA: 0x102E50C
	private float GetSingle(int offset) { }

	// RVA: 0x102E588
	private Double GetDouble(int offset) { }

	// RVA: 0x1028B50
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0x102981C
	private Exception ThrowXmlException(string res) { }

	// RVA: 0x102B0DC
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0x102B424
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0x102EB04
	private static void .cctor() { }

}

// Namespace: System.Xml
internal class BitStack
{
	// Fields
	private UInt32[] bitStack; // 0x10
	private int stackPos; // 0x18
	private UInt32 curr; // 0x1C

	// Methods

	// RVA: 0x102EE80
	public void .ctor() { }

	// RVA: 0x102EEAC
	public void PushBit(bool bit) { }

	// RVA: 0x102F010
	public bool PopBit() { }

	// RVA: 0x102F0B8
	public bool PeekBit() { }

	// RVA: 0x102EEFC
	private void PushCurr() { }

	// RVA: 0x102F070
	private void PopCurr() { }

}

// Namespace: System.Xml
internal static class Bits
{
	// Fields
	private static readonly UInt32 MASK_0101010101010101; // 0x0
	private static readonly UInt32 MASK_0011001100110011; // 0x4
	private static readonly UInt32 MASK_0000111100001111; // 0x8
	private static readonly UInt32 MASK_0000000011111111; // 0xC
	private static readonly UInt32 MASK_1111111111111111; // 0x10

	// Methods

	// RVA: 0x102F0C4
	public static int Count(UInt32 num) { }

	// RVA: 0x102F16C
	public static int LeastPosition(UInt32 num) { }

	// RVA: 0x102F288
	private static void .cctor() { }

}

// Namespace: System.Xml
internal class ByteStack
{
	// Fields
	private Byte[] stack; // 0x10
	private int growthRate; // 0x18
	private int top; // 0x1C
	private int size; // 0x20

	// Methods

	// RVA: 0x102F2E4
	public void .ctor(int growthRate) { }

	// RVA: 0x102F364
	public void Push(Byte data) { }

	// RVA: 0x102F464
	public Byte Pop() { }

}

// Namespace: System.Xml
internal class CharEntityEncoderFallback
{
	// Fields
	private CharEntityEncoderFallbackBuffer fallbackBuffer; // 0x10
	private int[] textContentMarks; // 0x18
	private int endMarkPos; // 0x20
	private int curMarkPos; // 0x24
	private int startOffset; // 0x28

	// Methods

	// RVA: 0x102F4B4
	internal void .ctor() { }

	// RVA: 0x102F4BC
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x102F648
	public override int get_MaxCharCount() { }

	// RVA: 0x102F650
	internal void set_StartOffset(int value) { }

	// RVA: 0x102F658
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x102F688
	internal bool CanReplaceAt(int index) { }

}

// Namespace: System.Xml
internal class CharEntityEncoderFallbackBuffer
{
	// Fields
	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	// Methods

	// RVA: 0x102F5C0
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x102F714
	public override bool Fallback(Char charUnknown, int index) { }

	// RVA: 0x102F97C
	public override bool Fallback(Char charUnknownHigh, Char charUnknownLow, int index) { }

	// RVA: 0x102FCA8
	public override Char GetNextChar() { }

	// RVA: 0x102FD04
	public override bool MovePrevious() { }

	// RVA: 0x102FD20
	public override int get_Remaining() { }

	// RVA: 0x102FD5C
	public override void Reset() { }

	// RVA: 0x102FC9C
	private int SurrogateCharToUtf32(Char highSurrogate, Char lowSurrogate) { }

}

// Namespace: System.Xml
public enum ConformanceLevel
{
	// Fields
	public int value__; // 0x10
	public const ConformanceLevel Auto = 0;
	public const ConformanceLevel Fragment = 1;
	public const ConformanceLevel Document = 2;
}

// Namespace: System.Xml
public enum DtdProcessing
{
	// Fields
	public int value__; // 0x10
	public const DtdProcessing Prohibit = 0;
	public const DtdProcessing Ignore = 1;
	public const DtdProcessing Parse = 2;
}

// Namespace: System.Xml
public enum EntityHandling
{
	// Fields
	public int value__; // 0x10
	public const EntityHandling ExpandEntities = 1;
	public const EntityHandling ExpandCharEntities = 2;
}

// Namespace: System.Xml
internal class HtmlEncodedRawTextWriter
{
	// Fields
	protected ByteStack elementScope; // 0xC0
	protected ElementProperties currentElementProperties; // 0xC8
	private AttributeProperties currentAttributeProperties; // 0xCC
	private bool endsWithAmpersand; // 0xD0
	private Byte[] uriEscapingBuffer; // 0xD8
	private string mediaType; // 0xE0
	private bool doNotEscapeUriAttributes; // 0xE8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x102FD68
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x102FF9C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x102FFCC
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x102FFD0
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x102FFD4
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1030264
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x103039C
	internal override void StartElementContent() { }

	// RVA: 0x103051C
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x103065C
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x103079C
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1030928
	public override void WriteEndAttribute() { }

	// RVA: 0x1030A6C
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1030BB0
	public override void WriteString(string text) { }

	// RVA: 0x1030D00
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1030D5C
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1030DB8
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1030E14
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x102FD98
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x10303F4
	protected void WriteMetaElement() { }

	// RVA: 0x1030CE8
	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1030CA4
	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10311F8
	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1030EA8
	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10309D4
	private void OutputRestAmps() { }

}

// Namespace: System.Xml
internal class HtmlEncodedRawTextWriterIndent
{
	// Fields
	private int indentLevel; // 0xEC
	private int endBlockPos; // 0xF0
	private string indentChars; // 0xF8
	private bool newLineOnAttributes; // 0x100

	// Methods

	// RVA: 0x103144C
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x10314E8
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1031540
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1031568
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x10317F0
	internal override void StartElementContent() { }

	// RVA: 0x10318A8
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1031998
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1031A4C
	protected override void FlushBuffer() { }

	// RVA: 0x10314A4
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x103179C
	private void WriteIndent() { }

}

// Namespace: System.Xml
internal abstract class HtmlTernaryTree
{
	// Fields
	internal static Byte[] htmlElements; // 0x0
	internal static Byte[] htmlAttributes; // 0x8

	// Methods

	// RVA: 0x1031A7C
	private static void .cctor() { }

}

// Namespace: System.Xml
internal class HtmlUtf8RawTextWriter
{
	// Fields
	protected ByteStack elementScope; // 0x90
	protected ElementProperties currentElementProperties; // 0x98
	private AttributeProperties currentAttributeProperties; // 0x9C
	private bool endsWithAmpersand; // 0xA0
	private Byte[] uriEscapingBuffer; // 0xA8
	private string mediaType; // 0xB0
	private bool doNotEscapeUriAttributes; // 0xB8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x1031B6C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1031DA0
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1031DA4
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1031DA8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1032048
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1032160
	internal override void StartElementContent() { }

	// RVA: 0x10322E4
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x103240C
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1032534
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x10326B0
	public override void WriteEndAttribute() { }

	// RVA: 0x10327F0
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1032914
	public override void WriteString(string text) { }

	// RVA: 0x1032A44
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1032AA0
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1032AFC
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1032B58
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1031B9C
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x10321BC
	protected void WriteMetaElement() { }

	// RVA: 0x1032A2C
	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10329E8
	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1032ED8
	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1032BA0
	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1032728
	private void OutputRestAmps() { }

}

// Namespace: System.Xml
internal class HtmlUtf8RawTextWriterIndent
{
	// Fields
	private int indentLevel; // 0xBC
	private int endBlockPos; // 0xC0
	private string indentChars; // 0xC8
	private bool newLineOnAttributes; // 0xD0

	// Methods

	// RVA: 0x11333B4
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1133444
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1133470
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x113383C
	internal override void StartElementContent() { }

	// RVA: 0x11338FC
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11339F4
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1133AAC
	protected override void FlushBuffer() { }

	// RVA: 0x1133400
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x11337E8
	private void WriteIndent() { }

}

// Namespace: System.Xml
internal interface IDtdInfo
{
	// Methods

	// RVA: -1
	public abstract XmlQualifiedName get_Name() { }

	// RVA: -1
	public abstract string get_InternalDtdSubset() { }

	// RVA: -1
	public abstract bool get_HasDefaultAttributes() { }

	// RVA: -1
	public abstract bool get_HasNonCDataAttributes() { }

	// RVA: -1
	public abstract IDtdAttributeListInfo LookupAttributeList(string prefix, string localName) { }

	// RVA: -1
	public abstract IDtdEntityInfo LookupEntity(string name) { }

}

// Namespace: System.Xml
internal interface IDtdAttributeListInfo
{
	// Methods

	// RVA: -1
	public abstract bool get_HasNonCDataAttributes() { }

	// RVA: -1
	public abstract IDtdAttributeInfo LookupAttribute(string prefix, string localName) { }

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> LookupDefaultAttributes() { }

}

// Namespace: System.Xml
internal interface IDtdAttributeInfo
{
	// Methods

	// RVA: -1
	public abstract string get_Prefix() { }

	// RVA: -1
	public abstract string get_LocalName() { }

	// RVA: -1
	public abstract int get_LineNumber() { }

	// RVA: -1
	public abstract int get_LinePosition() { }

	// RVA: -1
	public abstract bool get_IsNonCDataType() { }

	// RVA: -1
	public abstract bool get_IsDeclaredInExternal() { }

	// RVA: -1
	public abstract bool get_IsXmlAttribute() { }

}

// Namespace: System.Xml
internal interface IDtdDefaultAttributeInfo
{
	// Methods

	// RVA: -1
	public abstract string get_DefaultValueExpanded() { }

	// RVA: -1
	public abstract object get_DefaultValueTyped() { }

	// RVA: -1
	public abstract int get_ValueLineNumber() { }

	// RVA: -1
	public abstract int get_ValueLinePosition() { }

}

// Namespace: System.Xml
internal interface IDtdEntityInfo
{
	// Methods

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: -1
	public abstract bool get_IsExternal() { }

	// RVA: -1
	public abstract bool get_IsDeclaredInExternal() { }

	// RVA: -1
	public abstract bool get_IsUnparsedEntity() { }

	// RVA: -1
	public abstract bool get_IsParameterEntity() { }

	// RVA: -1
	public abstract string get_BaseUriString() { }

	// RVA: -1
	public abstract string get_DeclaredUriString() { }

	// RVA: -1
	public abstract string get_SystemId() { }

	// RVA: -1
	public abstract string get_PublicId() { }

	// RVA: -1
	public abstract string get_Text() { }

	// RVA: -1
	public abstract int get_LineNumber() { }

	// RVA: -1
	public abstract int get_LinePosition() { }

}

// Namespace: System.Xml
internal interface IDtdParser
{
	// Methods

	// RVA: -1
	public abstract IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: -1
	public abstract IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

}

// Namespace: System.Xml
internal interface IDtdParserAdapter
{
	// Methods

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: -1
	public abstract IXmlNamespaceResolver get_NamespaceResolver() { }

	// RVA: -1
	public abstract Uri get_BaseUri() { }

	// RVA: -1
	public abstract Char[] get_ParsingBuffer() { }

	// RVA: -1
	public abstract int get_ParsingBufferLength() { }

	// RVA: -1
	public abstract int get_CurrentPosition() { }

	// RVA: -1
	public abstract void set_CurrentPosition(int value) { }

	// RVA: -1
	public abstract int get_LineNo() { }

	// RVA: -1
	public abstract int get_LineStartPosition() { }

	// RVA: -1
	public abstract bool get_IsEof() { }

	// RVA: -1
	public abstract int get_EntityStackLength() { }

	// RVA: -1
	public abstract bool get_IsEntityEolNormalized() { }

	// RVA: -1
	public abstract int ReadData() { }

	// RVA: -1
	public abstract void OnNewLine(int pos) { }

	// RVA: -1
	public abstract int ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: -1
	public abstract int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: -1
	public abstract void ParsePI(StringBuilder sb) { }

	// RVA: -1
	public abstract void ParseComment(StringBuilder sb) { }

	// RVA: -1
	public abstract bool PushEntity(IDtdEntityInfo entity, int entityId) { }

	// RVA: -1
	public abstract bool PopEntity(IDtdEntityInfo oldEntity, int newEntityId) { }

	// RVA: -1
	public abstract bool PushExternalSubset(string systemId, string publicId) { }

	// RVA: -1
	public abstract void PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: -1
	public abstract void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: -1
	public abstract void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: -1
	public abstract void Throw(Exception e) { }

}

// Namespace: System.Xml
internal interface IDtdParserAdapterWithValidation
{
	// Methods

	// RVA: -1
	public abstract bool get_DtdValidation() { }

	// RVA: -1
	public abstract IValidationEventHandling get_ValidationEventHandling() { }

}

// Namespace: System.Xml
internal interface IDtdParserAdapterV1
{
	// Methods

	// RVA: -1
	public abstract bool get_V1CompatibilityMode() { }

	// RVA: -1
	public abstract bool get_Normalization() { }

	// RVA: -1
	public abstract bool get_Namespaces() { }

}

// Namespace: System.Xml
internal sealed class OnRemoveWriter
{
	// Methods

	// RVA: 0x1133ADC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1133BFC
	public virtual void Invoke(XmlRawWriter writer) { }

}

// Namespace: System.Xml
internal interface IValidationEventHandling
{
	// Methods

	// RVA: -1
	public abstract object get_EventHandler() { }

	// RVA: -1
	public abstract void SendEvent(Exception exception, XmlSeverityType severity) { }

}

// Namespace: System.Xml
internal abstract class IncrementalReadDecoder
{
	// Methods

	// RVA: -1
	internal abstract bool get_IsFull() { }

	// RVA: -1
	internal abstract int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0x1133C10
	protected void .ctor() { }

}

// Namespace: System.Xml
internal class IncrementalReadDummyDecoder
{
	// Methods

	// RVA: 0x1133C18
	internal override bool get_IsFull() { }

	// RVA: 0x1133C20
	internal override int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0x1133C28
	public void .ctor() { }

}

// Namespace: System.Xml
public enum NamespaceHandling
{
	// Fields
	public int value__; // 0x10
	public const NamespaceHandling Default = 0;
	public const NamespaceHandling OmitDuplicates = 1;
}

// Namespace: System.Xml
public enum NewLineHandling
{
	// Fields
	public int value__; // 0x10
	public const NewLineHandling Replace = 0;
	public const NewLineHandling Entitize = 1;
	public const NewLineHandling None = 2;
}

// Namespace: System.Xml
internal class QueryOutputWriter
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private bool inCDataSection; // 0x30
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Int32> lookupCDataElems; // 0x38
	private BitStack bitsCData; // 0x40
	private XmlQualifiedName qnameCData; // 0x48
	private bool outputDocType; // 0x50
	private bool checkWellFormedDoc; // 0x51
	private bool hasDocElem; // 0x52
	private bool inAttr; // 0x53
	private string systemId; // 0x58
	private string publicId; // 0x60
	private int depth; // 0x68

	// Methods

	// RVA: 0x1133C30
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1133FE0
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1134028
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1134050
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1134078
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11340B4
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x113428C
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11342FC
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x113436C
	internal override void StartElementContent() { }

	// RVA: 0x1134394
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11343C0
	public override void WriteEndAttribute() { }

	// RVA: 0x11343EC
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1134414
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x113443C
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1134464
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x113448C
	public override void WriteCData(string text) { }

	// RVA: 0x11344B4
	public override void WriteComment(string text) { }

	// RVA: 0x11344E0
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x113450C
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11345FC
	public override void WriteString(string text) { }

	// RVA: 0x1134698
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1134768
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1134794
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x11347C0
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11347EC
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11348BC
	public override void WriteRaw(string data) { }

	// RVA: 0x1134958
	public override void Close() { }

	// RVA: 0x1134A00
	public override void Flush() { }

	// RVA: 0x11345A8
	private bool StartCDataSection() { }

	// RVA: 0x1134284
	private void EndCDataSection() { }

}

// Namespace: 
private enum State
{
	// Fields
	public int value__; // 0x10
	public const State None = 0;
	public const State InReadContent = 1;
	public const State InReadElementContent = 2;
}

// Namespace: System.Xml
internal class ReadContentAsBinaryHelper
{
	// Fields
	private XmlReader reader; // 0x10
	private State state; // 0x18
	private int valueOffset; // 0x1C
	private bool isEnd; // 0x20

	// Methods

	// RVA: 0x1134A28
	internal void Finish() { }

	// RVA: 0x1134CFC
	internal void Reset() { }

	// RVA: 0x1134B74
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

}

// Namespace: System.Xml
internal enum ElementProperties
{
	// Fields
	public UInt32 value__; // 0x10
	public const ElementProperties DEFAULT = 0;
	public const ElementProperties URI_PARENT = 1;
	public const ElementProperties BOOL_PARENT = 2;
	public const ElementProperties NAME_PARENT = 4;
	public const ElementProperties EMPTY = 8;
	public const ElementProperties NO_ENTITIES = 16;
	public const ElementProperties HEAD = 32;
	public const ElementProperties BLOCK_WS = 64;
	public const ElementProperties HAS_NS = 128;
}

// Namespace: System.Xml
internal enum AttributeProperties
{
	// Fields
	public UInt32 value__; // 0x10
	public const AttributeProperties DEFAULT = 0;
	public const AttributeProperties URI = 1;
	public const AttributeProperties BOOLEAN = 2;
	public const AttributeProperties NAME = 4;
}

// Namespace: System.Xml
internal class TernaryTreeReadOnly
{
	// Fields
	private Byte[] nodeBuffer; // 0x10

	// Methods

	// RVA: 0x1134D08
	public void .ctor(Byte[] nodeBuffer) { }

	// RVA: 0x1133684
	public Byte FindCaseInsensitiveString(string stringToFind) { }

}

// Namespace: System.Xml
public enum ReadState
{
	// Fields
	public int value__; // 0x10
	public const ReadState Initial = 0;
	public const ReadState Interactive = 1;
	public const ReadState Error = 2;
	public const ReadState EndOfFile = 3;
	public const ReadState Closed = 4;
}

// Namespace: 
private sealed class HashCodeOfStringDelegate
{
	// Methods

	// RVA: 0x11350E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x113519C
	public virtual int Invoke(string s, int sLen, Int64 additionalEntropy) { }

}

// Namespace: System.Xml
internal class SecureStringHasher
{
	// Fields
	private static HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x1134D3C
	public void .ctor() { }

	// RVA: 0x1134D6C
	public bool Equals(string x, string y) { }

	// RVA: 0x1134D80
	public int GetHashCode(string key) { }

	// RVA: 0x113506C
	private static int GetHashCodeOfString(string key, int sLen, Int64 additionalEntropy) { }

	// RVA: 0x1134E48
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

}

// Namespace: System.Xml
internal class TextEncodedRawTextWriter
{
	// Methods

	// RVA: 0x11351B0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11352B4
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11355E4
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11355E8
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11355EC
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11355F0
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11355F4
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11355F8
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11355FC
	internal override void StartElementContent() { }

	// RVA: 0x1135600
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x113560C
	public override void WriteEndAttribute() { }

	// RVA: 0x1135614
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1135618
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1135620
	public override void WriteCData(string text) { }

	// RVA: 0x11356E0
	public override void WriteComment(string text) { }

	// RVA: 0x11356E4
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11356E8
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11356EC
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x11356F0
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11356F4
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1135704
	public override void WriteString(string textBlock) { }

	// RVA: 0x1135714
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11357F4
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1135804
	public override void WriteRaw(string data) { }

}

// Namespace: System.Xml
internal class TextUtf8RawTextWriter
{
	// Methods

	// RVA: 0x1135814
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x113581C
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1135820
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1135824
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1135828
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x113582C
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1135830
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1135834
	internal override void StartElementContent() { }

	// RVA: 0x1135838
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1135844
	public override void WriteEndAttribute() { }

	// RVA: 0x113584C
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1135850
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1135858
	public override void WriteCData(string text) { }

	// RVA: 0x1135860
	public override void WriteComment(string text) { }

	// RVA: 0x1135864
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1135868
	public override void WriteEntityRef(string name) { }

	// RVA: 0x113586C
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1135870
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1135874
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1135888
	public override void WriteString(string textBlock) { }

	// RVA: 0x113589C
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11358B0
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11358C4
	public override void WriteRaw(string data) { }

}

// Namespace: System.Xml
internal class ValidatingReaderNodeData
{
	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private string nameWPrefix; // 0x28
	private string rawValue; // 0x30
	private string originalStringValue; // 0x38
	private int depth; // 0x40
	private AttributePSVIInfo attributePSVIInfo; // 0x48
	private XmlNodeType nodeType; // 0x50
	private int lineNo; // 0x54
	private int linePos; // 0x58

	// Methods

	// RVA: 0x11358D8
	public void .ctor() { }

	// RVA: 0x11359E0
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x1135A10
	public string get_LocalName() { }

	// RVA: 0x1135A18
	public void set_LocalName(string value) { }

	// RVA: 0x1135A20
	public string get_Namespace() { }

	// RVA: 0x1135A28
	public void set_Namespace(string value) { }

	// RVA: 0x1135A30
	public string get_Prefix() { }

	// RVA: 0x1135A38
	public void set_Prefix(string value) { }

	// RVA: 0x1135A40
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x1135B04
	public int get_Depth() { }

	// RVA: 0x1135B0C
	public void set_Depth(int value) { }

	// RVA: 0x1135B14
	public string get_RawValue() { }

	// RVA: 0x1135B1C
	public void set_RawValue(string value) { }

	// RVA: 0x1135B24
	public string get_OriginalStringValue() { }

	// RVA: 0x1135B2C
	public XmlNodeType get_NodeType() { }

	// RVA: 0x1135B34
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x1135B3C
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x1135B44
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x1135B4C
	public int get_LineNumber() { }

	// RVA: 0x1135B54
	public int get_LinePosition() { }

	// RVA: 0x1135904
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0x1135B5C
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1135B64
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0x1135C78
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0x1135D2C
	internal void SetItemData(string value) { }

	// RVA: 0x1135D60
	internal void SetItemData(string value, string originalStringValue) { }

}

// Namespace: System.Xml
public enum ValidationType
{
	// Fields
	public int value__; // 0x10
	public const ValidationType None = 0;
	public const ValidationType Auto = 1;
	public const ValidationType DTD = 2;
	public const ValidationType XDR = 3;
	public const ValidationType Schema = 4;
}

// Namespace: System.Xml
public enum WhitespaceHandling
{
	// Fields
	public int value__; // 0x10
	public const WhitespaceHandling All = 0;
	public const WhitespaceHandling Significant = 1;
	public const WhitespaceHandling None = 2;
}

// Namespace: System.Xml
internal class XmlAsyncCheckReader
{
	// Fields
	private readonly XmlReader coreReader; // 0x10
	private Task lastTask; // 0x18

	// Methods

	// RVA: 0x1135D94
	internal XmlReader get_CoreReader() { }

	// RVA: 0x1135D9C
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0x1136254
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1136310
	private void CheckAsync() { }

	// RVA: 0x1136390
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x11365A8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11365DC
	public override string get_Name() { }

	// RVA: 0x1136610
	public override string get_LocalName() { }

	// RVA: 0x1136644
	public override string get_NamespaceURI() { }

	// RVA: 0x1136678
	public override string get_Prefix() { }

	// RVA: 0x11366AC
	public override string get_Value() { }

	// RVA: 0x11366E0
	public override int get_Depth() { }

	// RVA: 0x1136714
	public override string get_BaseURI() { }

	// RVA: 0x113674C
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1136784
	public override bool get_IsDefault() { }

	// RVA: 0x11367BC
	public override Char get_QuoteChar() { }

	// RVA: 0x11367F4
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x113682C
	public override string get_XmlLang() { }

	// RVA: 0x1136864
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x113689C
	public override Type get_ValueType() { }

	// RVA: 0x11368D4
	public override int get_AttributeCount() { }

	// RVA: 0x113690C
	public override string GetAttribute(string name) { }

	// RVA: 0x113694C
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x113699C
	public override string GetAttribute(int i) { }

	// RVA: 0x11369DC
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1136A1C
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1136A5C
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1136A94
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1136ACC
	public override bool MoveToElement() { }

	// RVA: 0x1136B04
	public override bool ReadAttributeValue() { }

	// RVA: 0x1136B3C
	public override bool Read() { }

	// RVA: 0x1136B74
	public override bool get_EOF() { }

	// RVA: 0x1136BAC
	public override void Close() { }

	// RVA: 0x1136BE4
	public override ReadState get_ReadState() { }

	// RVA: 0x1136C1C
	public override void Skip() { }

	// RVA: 0x1136C54
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1136C8C
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1136CCC
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1136D04
	public override void ResolveEntity() { }

	// RVA: 0x1136D3C
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1136D74
	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x1136DCC
	public override string ReadString() { }

	// RVA: 0x1136E04
	public override XmlNodeType MoveToContent() { }

	// RVA: 0x1136E3C
	public override void ReadStartElement() { }

	// RVA: 0x1136E74
	public override string ReadElementString() { }

	// RVA: 0x1136EAC
	public override void ReadEndElement() { }

	// RVA: 0x1136EE4
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0x1136F34
	public override string ReadInnerXml() { }

	// RVA: 0x1136F6C
	public override bool get_HasAttributes() { }

	// RVA: 0x1136FA4
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1136FF4
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x113702C
	internal override IDtdInfo get_DtdInfo() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithNS
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0x1136198
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1137064
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1137118
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11371D0
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfo
{
	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Methods

	// RVA: 0x11360DC
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1137288
	public virtual bool HasLineInfo() { }

	// RVA: 0x113733C
	public virtual int get_LineNumber() { }

	// RVA: 0x11373F4
	public virtual int get_LinePosition() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNS
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0x1136020
	public void .ctor(XmlReader reader) { }

	// RVA: 0x11374AC
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1137560
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1137618
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNSSchema
{
	// Fields
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; // 0x30

	// Methods

	// RVA: 0x1135F64
	public void .ctor(XmlReader reader) { }

	// RVA: 0x11376D0
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1137784
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x113783C
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x11378F4
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x11379AC
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x1137A64
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x1137B1C
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckWriter
{
	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Methods

	// RVA: 0x1137BD4
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x1137C64
	private void CheckAsync() { }

	// RVA: 0x1137CE4
	public override void WriteStartDocument() { }

	// RVA: 0x1137D18
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1137D54
	public override void WriteEndDocument() { }

	// RVA: 0x1137D88
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1137DEC
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1137E40
	public override void WriteEndElement() { }

	// RVA: 0x1137E74
	public override void WriteFullEndElement() { }

	// RVA: 0x1137EA8
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1137EFC
	public override void WriteEndAttribute() { }

	// RVA: 0x1137F34
	public override void WriteCData(string text) { }

	// RVA: 0x1137F74
	public override void WriteComment(string text) { }

	// RVA: 0x1137FB4
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1138004
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1138044
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1138084
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11380C4
	public override void WriteString(string text) { }

	// RVA: 0x1138104
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1138154
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11381AC
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1138204
	public override void WriteRaw(string data) { }

	// RVA: 0x1138244
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x113829C
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x11382F4
	public override WriteState get_WriteState() { }

	// RVA: 0x113832C
	public override void Close() { }

	// RVA: 0x1138364
	public override void Flush() { }

	// RVA: 0x113839C
	public override string LookupPrefix(string ns) { }

	// RVA: 0x11383DC
	public override void WriteValue(string value) { }

	// RVA: 0x113841C
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x113846C
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x11384BC
	protected override void Dispose(bool disposing) { }

}

// Namespace: System.Xml
internal class XmlAutoDetectWriter
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private OnRemoveWriter onRemove; // 0x30
	private XmlWriterSettings writerSettings; // 0x38
	private XmlEventCache eventCache; // 0x40
	private TextWriter textWriter; // 0x48
	private Stream strm; // 0x50

	// Methods

	// RVA: 0x11384EC
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0x113861C
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0x1138650
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0x1138684
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1138708
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1138A10
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1138A74
	public override void WriteEndAttribute() { }

	// RVA: 0x1138A9C
	public override void WriteCData(string text) { }

	// RVA: 0x1138B90
	public override void WriteComment(string text) { }

	// RVA: 0x1138BC4
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1138BF8
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1138C2C
	public override void WriteString(string text) { }

	// RVA: 0x1138CAC
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1138CE8
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1138D24
	public override void WriteRaw(string data) { }

	// RVA: 0x1138DA4
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1138DF4
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1138E44
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1138EA4
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1138F0C
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1138F74
	public override void Close() { }

	// RVA: 0x1138FBC
	public override void Flush() { }

	// RVA: 0x1139004
	public override void WriteValue(string value) { }

	// RVA: 0x1139054
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x11390B0
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1139100
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1139150
	internal override void StartElementContent() { }

	// RVA: 0x1139178
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11391A0
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11391C8
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1139228
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1139250
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x11392A0
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x113878C
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0x11386F8
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0x1138B1C
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0x1138898
	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }

}

// Namespace: System.Xml
internal class XmlEncodedRawTextWriter
{
	// Fields
	private readonly bool useAsync; // 0x28
	protected Byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected int bufBytesUsed; // 0x6C
	protected Char[] bufChars; // 0x70
	protected Encoder encoder; // 0x78
	protected TextWriter writer; // 0x80
	protected bool trackTextContent; // 0x88
	protected bool inTextContent; // 0x89
	private int lastMarkPos; // 0x8C
	private int[] textContentMarks; // 0x90
	private CharEntityEncoderFallback charEntityFallback; // 0x98
	protected NewLineHandling newLineHandling; // 0xA0
	protected bool closeOutput; // 0xA4
	protected bool omitXmlDeclaration; // 0xA5
	protected string newLineChars; // 0xA8
	protected bool checkCharacters; // 0xB0
	protected XmlStandalone standalone; // 0xB4
	protected XmlOutputMethod outputMethod; // 0xB8
	protected bool autoXmlDeclaration; // 0xBC
	protected bool mergeCDataSections; // 0xBD

	// Methods

	// RVA: 0x1139A54
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x11351B4
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11352B8
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1139E80
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x113A1B8
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x113A240
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x113A570
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x113A6B8
	internal override void StartElementContent() { }

	// RVA: 0x113A700
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x113A8F0
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x113AA78
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x113AC18
	public override void WriteEndAttribute() { }

	// RVA: 0x113ACDC
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x113AD34
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x113AD3C
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x113AF64
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x113B028
	public override void WriteCData(string text) { }

	// RVA: 0x113B604
	public override void WriteComment(string text) { }

	// RVA: 0x113BB48
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x113BCE4
	public override void WriteEntityRef(string name) { }

	// RVA: 0x113BE18
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x113C048
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x113C6F4
	public override void WriteString(string text) { }

	// RVA: 0x113C7C0
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x113C978
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1135724
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1135624
	public override void WriteRaw(string data) { }

	// RVA: 0x113CCFC
	public override void Close() { }

	// RVA: 0x113CE2C
	public override void Flush() { }

	// RVA: 0x113CE9C
	protected virtual void FlushBuffer() { }

	// RVA: 0x113D0E0
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x113CD84
	private void FlushEncoder() { }

	// RVA: 0x113C110
	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x113C3F0
	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x113A178
	protected void RawText(string s) { }

	// RVA: 0x113D610
	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x113CA58
	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x113B784
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x113B25C
	protected void WriteCDataSection(string text) { }

	// RVA: 0x113D30C
	private static Char* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	// RVA: 0x113D468
	private Char* InvalidXmlChar(int ch, Char* pDst, bool entitize) { }

	// RVA: 0x113D8B0
	internal void EncodeChar(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	// RVA: 0x113A0FC
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x113D988
	private void GrowTextContentMarks() { }

	// RVA: 0x113D58C
	protected Char* WriteNewLine(Char* pDst) { }

	// RVA: 0x113D248
	protected static Char* LtEntity(Char* pDst) { }

	// RVA: 0x113D260
	protected static Char* GtEntity(Char* pDst) { }

	// RVA: 0x113D224
	protected static Char* AmpEntity(Char* pDst) { }

	// RVA: 0x113D278
	protected static Char* QuoteEntity(Char* pDst) { }

	// RVA: 0x113D2A0
	protected static Char* TabEntity(Char* pDst) { }

	// RVA: 0x113D2E8
	protected static Char* LineFeedEntity(Char* pDst) { }

	// RVA: 0x113D2C4
	protected static Char* CarriageReturnEntity(Char* pDst) { }

	// RVA: 0x113D7F4
	private static Char* CharEntity(Char* pDst, Char ch) { }

	// RVA: 0x113D7C0
	protected static Char* RawStartCData(Char* pDst) { }

	// RVA: 0x113D7A4
	protected static Char* RawEndCData(Char* pDst) { }

	// RVA: 0x1139B60
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

}

// Namespace: System.Xml
internal class XmlEncodedRawTextWriterIndent
{
	// Fields
	protected int indentLevel; // 0xC0
	protected bool newLineOnAttributes; // 0xC4
	protected string indentChars; // 0xC8
	protected bool mixedContent; // 0xD0
	private BitStack mixedContentStack; // 0xD8
	protected ConformanceLevel conformanceLevel; // 0xE0

	// Methods

	// RVA: 0x113DA10
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x113DB5C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x113DB88
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x113DC80
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x113DCF8
	internal override void StartElementContent() { }

	// RVA: 0x113DD80
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x113DD88
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x113DE10
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x113DE98
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x113DEE0
	public override void WriteCData(string text) { }

	// RVA: 0x113DEEC
	public override void WriteComment(string text) { }

	// RVA: 0x113DF44
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x113DF98
	public override void WriteEntityRef(string name) { }

	// RVA: 0x113DFA4
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x113DFB0
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x113DFBC
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x113DFC8
	public override void WriteString(string text) { }

	// RVA: 0x113DFD4
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x113DFE0
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x113DFEC
	public override void WriteRaw(string data) { }

	// RVA: 0x113DFF8
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x113DA3C
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x113DBF4
	private void WriteIndent() { }

}

// Namespace: 
private enum XmlEventType
{
	// Fields
	public int value__; // 0x10
	public const XmlEventType Unknown = 0;
	public const XmlEventType DocType = 1;
	public const XmlEventType StartElem = 2;
	public const XmlEventType StartAttr = 3;
	public const XmlEventType EndAttr = 4;
	public const XmlEventType CData = 5;
	public const XmlEventType Comment = 6;
	public const XmlEventType PI = 7;
	public const XmlEventType Whitespace = 8;
	public const XmlEventType String = 9;
	public const XmlEventType Raw = 10;
	public const XmlEventType EntRef = 11;
	public const XmlEventType CharEnt = 12;
	public const XmlEventType SurrCharEnt = 13;
	public const XmlEventType Base64 = 14;
	public const XmlEventType BinHex = 15;
	public const XmlEventType XmlDecl1 = 16;
	public const XmlEventType XmlDecl2 = 17;
	public const XmlEventType StartContent = 18;
	public const XmlEventType EndElem = 19;
	public const XmlEventType FullEndElem = 20;
	public const XmlEventType Nmsp = 21;
	public const XmlEventType EndBase64 = 22;
	public const XmlEventType Close = 23;
	public const XmlEventType Flush = 24;
	public const XmlEventType Dispose = 25;
}

// Namespace: 
private struct XmlEvent
{
	// Fields
	private XmlEventType eventType; // 0x10
	private string s1; // 0x18
	private string s2; // 0x20
	private string s3; // 0x28
	private object o; // 0x30

	// Methods

	// RVA: 0x113F490
	public void InitEvent(XmlEventType eventType) { }

	// RVA: 0x113F370
	public void InitEvent(XmlEventType eventType, string s1) { }

	// RVA: 0x113F380
	public void InitEvent(XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x113F3BC
	public void InitEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x113F414
	public void InitEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x113F480
	public void InitEvent(XmlEventType eventType, object o) { }

	// RVA: 0x113F498
	public XmlEventType get_EventType() { }

	// RVA: 0x113F4A0
	public string get_String1() { }

	// RVA: 0x113F4A8
	public string get_String2() { }

	// RVA: 0x113F4B0
	public string get_String3() { }

	// RVA: 0x113F4B8
	public object get_Object() { }

}

// Namespace: System.Xml
internal sealed class XmlEventCache
{
	// Fields
	private System.Collections.Generic.List<System.Xml.XmlEventCache.XmlEvent[]> pages; // 0x28
	private XmlEvent[] pageCurr; // 0x30
	private int pageSize; // 0x38
	private bool hasRootNode; // 0x3C
	private StringConcat singleText; // 0x40
	private string baseUri; // 0x78

	// Methods

	// RVA: 0x11385D4
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x11392C8
	public void EndEvents() { }

	// RVA: 0x1139324
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x113E1A8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x113E268
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x113E388
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x113E414
	public override void WriteEndAttribute() { }

	// RVA: 0x113E460
	public override void WriteCData(string text) { }

	// RVA: 0x113E518
	public override void WriteComment(string text) { }

	// RVA: 0x113E570
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x113E660
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x113E6B8
	public override void WriteString(string text) { }

	// RVA: 0x113E734
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x113E770
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x113E7AC
	public override void WriteRaw(string data) { }

	// RVA: 0x113E804
	public override void WriteEntityRef(string name) { }

	// RVA: 0x113E85C
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x113E968
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x113EA2C
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x113EBDC
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x113ECD4
	public override void Close() { }

	// RVA: 0x113ED20
	public override void Flush() { }

	// RVA: 0x113ED6C
	public override void WriteValue(string value) { }

	// RVA: 0x113ED7C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x113EE88
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x113EF34
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x113EF8C
	internal override void StartElementContent() { }

	// RVA: 0x113EFD8
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x113F064
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x113F0F0
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x113F168
	internal override void WriteEndBase64() { }

	// RVA: 0x113E15C
	private void AddEvent(XmlEventType eventType) { }

	// RVA: 0x113E4B8
	private void AddEvent(XmlEventType eventType, string s1) { }

	// RVA: 0x113E5E8
	private void AddEvent(XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x113E2F4
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x113E1C0
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x113E908
	private void AddEvent(XmlEventType eventType, object o) { }

	// RVA: 0x113F1B4
	private int NewEvent() { }

	// RVA: 0x113EB24
	private static Byte[] ToBytes(Byte[] buffer, int index, int count) { }

}

// Namespace: System.Xml
public class XmlParserContext
{
	// Fields
	private XmlNameTable _nt; // 0x10
	private XmlNamespaceManager _nsMgr; // 0x18
	private string _docTypeName; // 0x20
	private string _pubId; // 0x28
	private string _sysId; // 0x30
	private string _internalSubset; // 0x38
	private string _xmlLang; // 0x40
	private XmlSpace _xmlSpace; // 0x48
	private string _baseURI; // 0x50
	private Encoding _encoding; // 0x58

	// Methods

	// RVA: 0x113F4C0
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x113F56C
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x113F59C
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x113F8EC
	public XmlNameTable get_NameTable() { }

	// RVA: 0x113F8F4
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x113F8FC
	public string get_DocTypeName() { }

	// RVA: 0x113F904
	public string get_PublicId() { }

	// RVA: 0x113F90C
	public string get_SystemId() { }

	// RVA: 0x113F914
	public string get_BaseURI() { }

	// RVA: 0x113F91C
	public string get_InternalSubset() { }

	// RVA: 0x113F924
	public string get_XmlLang() { }

	// RVA: 0x113F92C
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x113F934
	public Encoding get_Encoding() { }

	// RVA: 0x113F93C
	internal bool get_HasDtdInfo() { }

}

// Namespace: System.Xml
internal abstract class XmlRawWriter
{
	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Methods

	// RVA: 0x113F9E8
	public override void WriteStartDocument() { }

	// RVA: 0x113FA44
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x113FAA0
	public override void WriteEndDocument() { }

	// RVA: 0x113FAFC
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x113FB00
	public override void WriteEndElement() { }

	// RVA: 0x113FB5C
	public override void WriteFullEndElement() { }

	// RVA: 0x113E0AC
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x113FBB8
	public override string LookupPrefix(string ns) { }

	// RVA: 0x113FC14
	public override WriteState get_WriteState() { }

	// RVA: 0x113FC70
	public override void WriteCData(string text) { }

	// RVA: 0x113FC80
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x113FD18
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x113FDC8
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x113FDD8
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x113FE14
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x113FE50
	public override void WriteRaw(string data) { }

	// RVA: 0x113FE60
	public override void WriteValue(string value) { }

	// RVA: 0x113FE70
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x113FECC
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x113FF28
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x113FF30
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x113FF34
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	// RVA: -1
	internal abstract void StartElementContent() { }

	// RVA: 0x113FF38
	internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: -1
	internal abstract void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x113FF3C
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x113FF4C
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x113FF54
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x113FF94
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0x113FFD4
	internal virtual void WriteEndBase64() { }

	// RVA: 0x113FFF4
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x1133FD8
	protected void .ctor() { }

}

// Namespace: System.Xml
public abstract class XmlReader
{
	// Fields
	private static UInt32 IsTextualNodeBitmap; // 0x0
	private static UInt32 CanReadContentAsBitmap; // 0x4
	private static UInt32 HasValueBitmap; // 0x8

	// Methods

	// RVA: 0x1140004
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x114000C
	public virtual string get_Name() { }

	// RVA: -1
	public abstract string get_LocalName() { }

	// RVA: -1
	public abstract string get_NamespaceURI() { }

	// RVA: -1
	public abstract string get_Prefix() { }

	// RVA: -1
	public abstract string get_Value() { }

	// RVA: -1
	public abstract int get_Depth() { }

	// RVA: -1
	public abstract string get_BaseURI() { }

	// RVA: -1
	public abstract bool get_IsEmptyElement() { }

	// RVA: 0x11400F4
	public virtual bool get_IsDefault() { }

	// RVA: 0x11400FC
	public virtual Char get_QuoteChar() { }

	// RVA: 0x1140104
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x114010C
	public virtual string get_XmlLang() { }

	// RVA: 0x1140158
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11401AC
	public virtual Type get_ValueType() { }

	// RVA: -1
	public abstract int get_AttributeCount() { }

	// RVA: -1
	public abstract string GetAttribute(string name) { }

	// RVA: -1
	public abstract string GetAttribute(string name, string namespaceURI) { }

	// RVA: -1
	public abstract string GetAttribute(int i) { }

	// RVA: -1
	public abstract bool MoveToAttribute(string name) { }

	// RVA: 0x114024C
	public virtual void MoveToAttribute(int i) { }

	// RVA: -1
	public abstract bool MoveToFirstAttribute() { }

	// RVA: -1
	public abstract bool MoveToNextAttribute() { }

	// RVA: -1
	public abstract bool MoveToElement() { }

	// RVA: -1
	public abstract bool ReadAttributeValue() { }

	// RVA: -1
	public abstract bool Read() { }

	// RVA: -1
	public abstract bool get_EOF() { }

	// RVA: 0x1140318
	public virtual void Close() { }

	// RVA: -1
	public abstract ReadState get_ReadState() { }

	// RVA: 0x114031C
	public virtual void Skip() { }

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: -1
	public abstract string LookupNamespace(string prefix) { }

	// RVA: 0x11404E4
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1
	public abstract void ResolveEntity() { }

	// RVA: 0x11404EC
	public virtual bool get_CanReadValueChunk() { }

	// RVA: 0x11404F4
	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x1140550
	public virtual string ReadString() { }

	// RVA: 0x11407F0
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0x1140890
	public virtual void ReadStartElement() { }

	// RVA: 0x1140988
	public virtual string ReadElementString() { }

	// RVA: 0x1140C1C
	public virtual void ReadEndElement() { }

	// RVA: 0x1140D14
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0x1140DA4
	public virtual string ReadInnerXml() { }

	// RVA: 0x1141238
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0x114111C
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0x11410A4
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0x114169C
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0x11417D4
	public virtual bool get_HasAttributes() { }

	// RVA: 0x1136FE0
	public void Dispose() { }

	// RVA: 0x11417FC
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1141850
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1140780
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0x1141858
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0x114040C
	private bool SkipSubtree() { }

	// RVA: 0x11418C8
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x11419D0
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0x11419D8
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1141C38
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1141DF8
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0x1142190
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x1136308
	protected void .ctor() { }

	// RVA: 0x114237C
	private static void .cctor() { }

}

// Namespace: System.Xml
public sealed class XmlReaderSettings
{
	// Fields
	private bool useAsync; // 0x10
	private XmlNameTable nameTable; // 0x18
	private XmlResolver xmlResolver; // 0x20
	private int lineNumberOffset; // 0x28
	private int linePositionOffset; // 0x2C
	private ConformanceLevel conformanceLevel; // 0x30
	private bool checkCharacters; // 0x34
	private Int64 maxCharactersInDocument; // 0x38
	private Int64 maxCharactersFromEntities; // 0x40
	private bool ignoreWhitespace; // 0x48
	private bool ignorePIs; // 0x49
	private bool ignoreComments; // 0x4A
	private DtdProcessing dtdProcessing; // 0x4C
	private ValidationType validationType; // 0x50
	private XmlSchemaValidationFlags validationFlags; // 0x54
	private XmlSchemaSet schemas; // 0x58
	private ValidationEventHandler valEventHandler; // 0x60
	private bool closeInput; // 0x68
	private bool isReadOnly; // 0x69
	private bool <IsXmlResolverSet>k__BackingField; // 0x6A
	private static System.Nullable<System.Boolean> s_enableLegacyXmlSettings; // 0x0

	// Methods

	// RVA: 0x113651C
	public void .ctor() { }

	// RVA: 0x11423E4
	public bool get_Async() { }

	// RVA: 0x1136548
	public void set_Async(bool value) { }

	// RVA: 0x11424A4
	public XmlNameTable get_NameTable() { }

	// RVA: 0x11424AC
	public void set_NameTable(XmlNameTable value) { }

	// RVA: 0x1142514
	internal bool get_IsXmlResolverSet() { }

	// RVA: 0x114251C
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0x1142524
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1142598
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0x11425A0
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x11425E4
	public int get_LineNumberOffset() { }

	// RVA: 0x11425EC
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x114264C
	public int get_LinePositionOffset() { }

	// RVA: 0x1142654
	public void set_LinePositionOffset(int value) { }

	// RVA: 0x11426B4
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x11426BC
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x114276C
	public bool get_CheckCharacters() { }

	// RVA: 0x1142774
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x11427D4
	public Int64 get_MaxCharactersInDocument() { }

	// RVA: 0x11427DC
	public void set_MaxCharactersInDocument(Int64 value) { }

	// RVA: 0x1142888
	public Int64 get_MaxCharactersFromEntities() { }

	// RVA: 0x1142890
	public void set_MaxCharactersFromEntities(Int64 value) { }

	// RVA: 0x114293C
	public bool get_IgnoreWhitespace() { }

	// RVA: 0x1142944
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0x11429A4
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0x11429AC
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0x1142A0C
	public bool get_IgnoreComments() { }

	// RVA: 0x1142A14
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x1142A74
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0x1142A7C
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x1142B2C
	public bool get_CloseInput() { }

	// RVA: 0x1142B34
	public void set_CloseInput(bool value) { }

	// RVA: 0x1142B94
	public ValidationType get_ValidationType() { }

	// RVA: 0x1142B9C
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x1142C4C
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x1142C54
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0x1142D04
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0x1142D8C
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x11364B0
	public XmlReaderSettings Clone() { }

	// RVA: 0x1142DF4
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1141A6C
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x1141CC8
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x1142DFC
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x11423EC
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x11423DC
	private void Initialize() { }

	// RVA: 0x1142E04
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0x1143084
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x1142220
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0x11430DC
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0x1142EFC
	internal static bool EnableLegacyXmlSettings() { }

}

// Namespace: System.Xml
public enum XmlSpace
{
	// Fields
	public int value__; // 0x10
	public const XmlSpace None = 0;
	public const XmlSpace Default = 1;
	public const XmlSpace Preserve = 2;
}

// Namespace: System.Xml
internal class XmlTextEncoder
{
	// Fields
	private TextWriter textWriter; // 0x10
	private bool inAttribute; // 0x18
	private Char quoteChar; // 0x1A
	private StringBuilder attrValue; // 0x20
	private bool cacheAttrValue; // 0x28
	private XmlCharType xmlCharType; // 0x30

	// Methods

	// RVA: 0x1143160
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0x11431B4
	internal void set_QuoteChar(Char value) { }

	// RVA: 0x11431BC
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0x114327C
	internal void EndAttribute() { }

	// RVA: 0x11432C0
	internal string get_AttributeValue() { }

	// RVA: 0x1143338
	internal void WriteSurrogateChar(Char lowChar, Char highChar) { }

	// RVA: 0x11433F8
	internal void Write(Char[] array, int offset, int count) { }

	// RVA: 0x1143A58
	internal void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1143BE0
	internal void Write(string text) { }

	// RVA: 0x1144240
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0x1144430
	internal void WriteRaw(Char[] array, int offset, int count) { }

	// RVA: 0x1144574
	internal void WriteCharEntity(Char ch) { }

	// RVA: 0x114475C
	internal void WriteEntityRef(string name) { }

	// RVA: 0x114418C
	private void WriteStringFragment(string str, int offset, int count, Char[] helperBuffer) { }

	// RVA: 0x1143960
	private void WriteCharEntityImpl(Char ch) { }

	// RVA: 0x11446B8
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0x11439E4
	private void WriteEntityRefImpl(string name) { }

}

// Namespace: System.Xml
public class XmlTextReader
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Methods

	// RVA: 0x1144814
	public void .ctor(Stream input) { }

	// RVA: 0x11448D8
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x11449B4
	public void .ctor(TextReader input) { }

	// RVA: 0x1144A78
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x1144B4C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1144B70
	public override string get_Name() { }

	// RVA: 0x1144B94
	public override string get_LocalName() { }

	// RVA: 0x1144BB8
	public override string get_NamespaceURI() { }

	// RVA: 0x1144BDC
	public override string get_Prefix() { }

	// RVA: 0x1144C00
	public override string get_Value() { }

	// RVA: 0x1144C24
	public override int get_Depth() { }

	// RVA: 0x1144C48
	public override string get_BaseURI() { }

	// RVA: 0x1144C70
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1144C98
	public override bool get_IsDefault() { }

	// RVA: 0x1144CC0
	public override Char get_QuoteChar() { }

	// RVA: 0x1144CE8
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1144D10
	public override string get_XmlLang() { }

	// RVA: 0x1144D38
	public override int get_AttributeCount() { }

	// RVA: 0x1144D60
	public override string GetAttribute(string name) { }

	// RVA: 0x1144D88
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1144DB0
	public override string GetAttribute(int i) { }

	// RVA: 0x1144DD8
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1144E00
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1144E28
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1144E50
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1144E78
	public override bool MoveToElement() { }

	// RVA: 0x1144EA0
	public override bool ReadAttributeValue() { }

	// RVA: 0x1144EC8
	public override bool Read() { }

	// RVA: 0x1144EF0
	public override bool get_EOF() { }

	// RVA: 0x1144F18
	public override void Close() { }

	// RVA: 0x1144F40
	public override ReadState get_ReadState() { }

	// RVA: 0x1144F68
	public override void Skip() { }

	// RVA: 0x1144F90
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1144FB8
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1144FF4
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1144FFC
	public override void ResolveEntity() { }

	// RVA: 0x1145024
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x114502C
	public override string ReadString() { }

	// RVA: 0x1145060
	public bool HasLineInfo() { }

	// RVA: 0x1145068
	public int get_LineNumber() { }

	// RVA: 0x1145088
	public int get_LinePosition() { }

	// RVA: 0x11450A8
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11450C8
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11450F0
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x11417B4
	public bool get_Namespaces() { }

	// RVA: 0x1145110
	public bool get_Normalization() { }

	// RVA: 0x1145130
	public void set_Normalization(bool value) { }

	// RVA: 0x1145150
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1145170
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1145190
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x11451B0
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0x11451B8
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x11451E0
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x1145200
	internal override IDtdInfo get_DtdInfo() { }

}

// Namespace: 
private enum ParsingFunction
{
	// Fields
	public int value__; // 0x10
	public const ParsingFunction ElementContent = 0;
	public const ParsingFunction NoData = 1;
	public const ParsingFunction OpenUrl = 2;
	public const ParsingFunction SwitchToInteractive = 3;
	public const ParsingFunction SwitchToInteractiveXmlDecl = 4;
	public const ParsingFunction DocumentContent = 5;
	public const ParsingFunction MoveToElementContent = 6;
	public const ParsingFunction PopElementContext = 7;
	public const ParsingFunction PopEmptyElementContext = 8;
	public const ParsingFunction ResetAttributesRootLevel = 9;
	public const ParsingFunction Error = 10;
	public const ParsingFunction Eof = 11;
	public const ParsingFunction ReaderClosed = 12;
	public const ParsingFunction EntityReference = 13;
	public const ParsingFunction InIncrementalRead = 14;
	public const ParsingFunction FragmentAttribute = 15;
	public const ParsingFunction ReportEndEntity = 16;
	public const ParsingFunction AfterResolveEntityInContent = 17;
	public const ParsingFunction AfterResolveEmptyEntityInContent = 18;
	public const ParsingFunction XmlDeclarationFragment = 19;
	public const ParsingFunction GoToEof = 20;
	public const ParsingFunction PartialTextValue = 21;
	public const ParsingFunction InReadAttributeValue = 22;
	public const ParsingFunction InReadValueChunk = 23;
	public const ParsingFunction InReadContentAsBinary = 24;
	public const ParsingFunction InReadElementContentAsBinary = 25;
}

// Namespace: 
private enum ParsingMode
{
	// Fields
	public int value__; // 0x10
	public const ParsingMode Full = 0;
	public const ParsingMode SkipNode = 1;
	public const ParsingMode SkipContent = 2;
}

// Namespace: 
private enum EntityType
{
	// Fields
	public int value__; // 0x10
	public const EntityType CharacterDec = 0;
	public const EntityType CharacterHex = 1;
	public const EntityType CharacterNamed = 2;
	public const EntityType Expanded = 3;
	public const EntityType Skipped = 4;
	public const EntityType FakeExpanded = 5;
	public const EntityType Unexpanded = 6;
	public const EntityType ExpandedInAttribute = 7;
}

// Namespace: 
private enum EntityExpandType
{
	// Fields
	public int value__; // 0x10
	public const EntityExpandType All = 0;
	public const EntityExpandType OnlyGeneral = 1;
	public const EntityExpandType OnlyCharacter = 2;
}

// Namespace: 
private enum IncrementalReadState
{
	// Fields
	public int value__; // 0x10
	public const IncrementalReadState Text = 0;
	public const IncrementalReadState StartTag = 1;
	public const IncrementalReadState PI = 2;
	public const IncrementalReadState CDATA = 3;
	public const IncrementalReadState Comment = 4;
	public const IncrementalReadState Attributes = 5;
	public const IncrementalReadState AttributeValue = 6;
	public const IncrementalReadState ReadData = 7;
	public const IncrementalReadState EndElement = 8;
	public const IncrementalReadState End = 9;
	public const IncrementalReadState ReadValueChunk_OnCachedValue = 10;
	public const IncrementalReadState ReadValueChunk_OnPartialValue = 11;
	public const IncrementalReadState ReadContentAsBinary_OnCachedValue = 12;
	public const IncrementalReadState ReadContentAsBinary_OnPartialValue = 13;
	public const IncrementalReadState ReadContentAsBinary_End = 14;
}

// Namespace: 
private class LaterInitParam
{
	// Fields
	public bool useAsync; // 0x10
	public Stream inputStream; // 0x18
	public Byte[] inputBytes; // 0x20
	public int inputByteCount; // 0x28
	public Uri inputbaseUri; // 0x30
	public string inputUriStr; // 0x38
	public XmlResolver inputUriResolver; // 0x40
	public XmlParserContext inputContext; // 0x48
	public TextReader inputTextReader; // 0x50
	public InitInputType initType; // 0x58

	// Methods

	// RVA: 0x1145228
	public void .ctor() { }

}

// Namespace: 
private enum InitInputType
{
	// Fields
	public int value__; // 0x10
	public const InitInputType UriString = 0;
	public const InitInputType Stream = 1;
	public const InitInputType TextReader = 2;
	public const InitInputType Invalid = 3;
}

// Namespace: 
private struct ParsingState
{
	// Fields
	internal Char[] chars; // 0x10
	internal int charPos; // 0x18
	internal int charsUsed; // 0x1C
	internal Encoding encoding; // 0x20
	internal bool appendMode; // 0x28
	internal Stream stream; // 0x30
	internal Decoder decoder; // 0x38
	internal Byte[] bytes; // 0x40
	internal int bytePos; // 0x48
	internal int bytesUsed; // 0x4C
	internal TextReader textReader; // 0x50
	internal int lineNo; // 0x58
	internal int lineStartPos; // 0x5C
	internal string baseUriStr; // 0x60
	internal Uri baseUri; // 0x68
	internal bool isEof; // 0x70
	internal bool isStreamEof; // 0x71
	internal IDtdEntityInfo entity; // 0x78
	internal int entityId; // 0x80
	internal bool eolNormalized; // 0x84
	internal bool entityResolvedManually; // 0x85

	// Methods

	// RVA: 0x1145238
	internal void Clear() { }

	// RVA: 0x114532C
	internal void Close(bool closeInput) { }

	// RVA: 0x1145364
	internal int get_LineNo() { }

	// RVA: 0x114536C
	internal int get_LinePos() { }

}

// Namespace: 
private class XmlContext
{
	// Fields
	internal XmlSpace xmlSpace; // 0x10
	internal string xmlLang; // 0x18
	internal string defaultNamespace; // 0x20
	internal XmlContext previousContext; // 0x28

	// Methods

	// RVA: 0x114537C
	internal void .ctor() { }

	// RVA: 0x1145414
	internal void .ctor(XmlContext previousContext) { }

}

// Namespace: 
private class NoNamespaceManager
{
	// Methods

	// RVA: 0x1145478
	public void .ctor() { }

	// RVA: 0x1145480
	public override string get_DefaultNamespace() { }

	// RVA: 0x11454CC
	public override void PushScope() { }

	// RVA: 0x11454D0
	public override bool PopScope() { }

	// RVA: 0x11454D8
	public override void AddNamespace(string prefix, string uri) { }

	// RVA: 0x11454DC
	public override void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x11454E0
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x11454E8
	public override System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11454F0
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x114553C
	public override string LookupPrefix(string uri) { }

}

// Namespace: 
internal class DtdParserProxy
{
	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Methods

	// RVA: 0x1145544
	internal void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x1145578
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x1145598
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x11455B8
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x11455D8
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x11455F8
	private Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x1145618
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x1145638
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x1145658
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x1145678
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x1145698
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x11456B8
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x11456D8
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x11456F8
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x1145718
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x1145738
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1145758
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1145778
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x1145798
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x11457B8
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, int entityId) { }

	// RVA: 0x11457D8
	private bool System.Xml.IDtdParserAdapter.PopEntity(IDtdEntityInfo oldEntity, int newEntityId) { }

	// RVA: 0x11457F8
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1145818
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1145838
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x1145858
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1145878
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x1145898
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x11458B8
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0x11458D8
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0x11458F8
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x1145918
	private bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }

}

// Namespace: 
private class NodeData
{
	// Fields
	private static NodeData s_None; // 0x0
	internal XmlNodeType type; // 0x10
	internal string localName; // 0x18
	internal string prefix; // 0x20
	internal string ns; // 0x28
	internal string nameWPrefix; // 0x30
	private string value; // 0x38
	private Char[] chars; // 0x40
	private int valueStartPos; // 0x48
	private int valueLength; // 0x4C
	internal LineInfo lineInfo; // 0x50
	internal LineInfo lineInfo2; // 0x58
	internal Char quoteChar; // 0x60
	internal int depth; // 0x64
	private bool isEmptyOrDefault; // 0x68
	internal int entityId; // 0x6C
	internal bool xmlContextPushed; // 0x70
	internal NodeData nextAttrValueChunk; // 0x78
	internal object schemaType; // 0x80
	internal object typedValue; // 0x88

	// Methods

	// RVA: 0x1145938
	internal static NodeData get_None() { }

	// RVA: 0x11459E4
	internal void .ctor() { }

	// RVA: 0x1145AC8
	internal int get_LineNo() { }

	// RVA: 0x1145AD0
	internal int get_LinePos() { }

	// RVA: 0x1145AD8
	internal bool get_IsEmptyElement() { }

	// RVA: 0x1145AFC
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x1145B04
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0x1145B28
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x1145B30
	internal bool get_ValueBuffered() { }

	// RVA: 0x1145B40
	internal string get_StringValue() { }

	// RVA: 0x1145B98
	internal void TrimSpacesInValue() { }

	// RVA: 0x1145A18
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x1145BF4
	internal void ClearName() { }

	// RVA: 0x1145C9C
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1145CA8
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x1145CB4
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x1145CF4
	internal void SetValueNode(XmlNodeType type, Char[] chars, int startPos, int len) { }

	// RVA: 0x1145D50
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x1145DC8
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1145EA0
	internal void SetValue(string value) { }

	// RVA: 0x1145EB0
	internal void SetValue(Char[] chars, int startPos, int len) { }

	// RVA: 0x1145F00
	internal void OnBufferInvalidated() { }

	// RVA: 0x1145F68
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x1145FE4
	internal int CopyTo(int valueOffset, Char[] buffer, int offset, int length) { }

	// RVA: 0x114605C
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1146070
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1146134
	private int System.IComparable.CompareTo(object obj) { }

}

// Namespace: 
private class DtdDefaultAttributeInfoToNodeDataComparer
{
	// Fields
	private static System.Collections.Generic.IComparer<System.Object> s_instance; // 0x0

	// Methods

	// RVA: 0x1146220
	internal static System.Collections.Generic.IComparer<System.Object> get_Instance() { }

	// RVA: 0x114629C
	public int Compare(object x, object y) { }

	// RVA: 0x114661C
	public void .ctor() { }

	// RVA: 0x1146624
	private static void .cctor() { }

}

// Namespace: 
internal sealed class OnDefaultAttributeUseDelegate
{
	// Methods

	// RVA: 0x1146690
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11467B4
	public virtual void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

}

// Namespace: System.Xml
internal class XmlTextReaderImpl
{
	// Fields
	private readonly bool useAsync; // 0x10
	private LaterInitParam laterInitParam; // 0x18
	private XmlCharType xmlCharType; // 0x20
	private ParsingState ps; // 0x28
	private ParsingFunction parsingFunction; // 0xA0
	private ParsingFunction nextParsingFunction; // 0xA4
	private ParsingFunction nextNextParsingFunction; // 0xA8
	private NodeData[] nodes; // 0xB0
	private NodeData curNode; // 0xB8
	private int index; // 0xC0
	private int curAttrIndex; // 0xC4
	private int attrCount; // 0xC8
	private int attrHashtable; // 0xCC
	private int attrDuplWalkCount; // 0xD0
	private bool attrNeedNamespaceLookup; // 0xD4
	private bool fullAttrCleanup; // 0xD5
	private NodeData[] attrDuplSortingArray; // 0xD8
	private XmlNameTable nameTable; // 0xE0
	private bool nameTableFromSettings; // 0xE8
	private XmlResolver xmlResolver; // 0xF0
	private string url; // 0xF8
	private bool normalize; // 0x100
	private bool supportNamespaces; // 0x101
	private WhitespaceHandling whitespaceHandling; // 0x104
	private DtdProcessing dtdProcessing; // 0x108
	private EntityHandling entityHandling; // 0x10C
	private bool ignorePIs; // 0x110
	private bool ignoreComments; // 0x111
	private bool checkCharacters; // 0x112
	private int lineNumberOffset; // 0x114
	private int linePositionOffset; // 0x118
	private bool closeInput; // 0x11C
	private Int64 maxCharactersInDocument; // 0x120
	private Int64 maxCharactersFromEntities; // 0x128
	private bool v1Compat; // 0x130
	private XmlNamespaceManager namespaceManager; // 0x138
	private string lastPrefix; // 0x140
	private XmlContext xmlContext; // 0x148
	private ParsingState[] parsingStatesStack; // 0x150
	private int parsingStatesStackTop; // 0x158
	private string reportedBaseUri; // 0x160
	private Encoding reportedEncoding; // 0x168
	private IDtdInfo dtdInfo; // 0x170
	private XmlNodeType fragmentType; // 0x178
	private XmlParserContext fragmentParserContext; // 0x180
	private bool fragment; // 0x188
	private IncrementalReadDecoder incReadDecoder; // 0x190
	private IncrementalReadState incReadState; // 0x198
	private LineInfo incReadLineInfo; // 0x19C
	private int incReadDepth; // 0x1A4
	private int incReadLeftStartPos; // 0x1A8
	private int incReadLeftEndPos; // 0x1AC
	private int attributeValueBaseEntityId; // 0x1B0
	private bool emptyEntityInAttributeResolved; // 0x1B4
	private IValidationEventHandling validationEventHandling; // 0x1B8
	private OnDefaultAttributeUseDelegate onDefaultAttributeUse; // 0x1C0
	private bool validatingReaderCompatFlag; // 0x1C8
	private bool addDefaultAttributesAndNormalize; // 0x1C9
	private StringBuilder stringBuilder; // 0x1D0
	private bool rootElementParsed; // 0x1D8
	private bool standalone; // 0x1D9
	private int nextEntityId; // 0x1DC
	private ParsingMode parsingMode; // 0x1E0
	private ReadState readState; // 0x1E4
	private IDtdEntityInfo lastEntity; // 0x1E8
	private bool afterResetState; // 0x1F0
	private int documentStartBytePos; // 0x1F4
	private int readValueOffset; // 0x1F8
	private Int64 charactersInDocument; // 0x200
	private Int64 charactersFromEntities; // 0x208
	private System.Collections.Generic.Dictionary<System.Xml.IDtdEntityInfo,System.Xml.IDtdEntityInfo> currentEntities; // 0x210
	private bool disableUndeclaredEntityCheck; // 0x218
	private XmlReader outerReader; // 0x220
	private bool xmlResolverIsSet; // 0x228
	private string Xml; // 0x230
	private string XmlNs; // 0x238
	private System.Threading.Tasks.Task<System.Tuple<System.Int32,System.Int32,System.Int32,System.Boolean>> parseText_dummyTask; // 0x240

	// Methods

	// RVA: 0x103DC60
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0x103E0AC
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0x103E860
	internal void .ctor(Stream input) { }

	// RVA: 0x103E8FC
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x103EAB4
	internal void .ctor(TextReader input) { }

	// RVA: 0x103EC38
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x103EB50
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0x103ECB8
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0x103F18C
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0x103F2E8
	private void FinishInitUriString() { }

	// RVA: 0x103FA28
	internal void .ctor(Stream stream, Byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0x103FD90
	private void FinishInitStream() { }

	// RVA: 0x103FE7C
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0x103FFAC
	private void FinishInitTextReader() { }

	// RVA: 0x104007C
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x1040134
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x10402B4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x10402D4
	public override string get_Name() { }

	// RVA: 0x10402FC
	public override string get_LocalName() { }

	// RVA: 0x104031C
	public override string get_NamespaceURI() { }

	// RVA: 0x104033C
	public override string get_Prefix() { }

	// RVA: 0x104035C
	public override string get_Value() { }

	// RVA: 0x10405C4
	public override int get_Depth() { }

	// RVA: 0x10405E4
	public override string get_BaseURI() { }

	// RVA: 0x10405EC
	public override bool get_IsEmptyElement() { }

	// RVA: 0x104060C
	public override bool get_IsDefault() { }

	// RVA: 0x104062C
	public override Char get_QuoteChar() { }

	// RVA: 0x1040664
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1040684
	public override string get_XmlLang() { }

	// RVA: 0x10406A4
	public override ReadState get_ReadState() { }

	// RVA: 0x10406AC
	public override bool get_EOF() { }

	// RVA: 0x10406BC
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x10406C4
	public override bool get_CanResolveEntity() { }

	// RVA: 0x10406CC
	public override int get_AttributeCount() { }

	// RVA: 0x10406D4
	public override string GetAttribute(string name) { }

	// RVA: 0x1040930
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1040AC4
	public override string GetAttribute(int i) { }

	// RVA: 0x1040B6C
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1040D68
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1040E30
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1040EB4
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1040F60
	public override bool MoveToElement() { }

	// RVA: 0x1041004
	private void FinishInit() { }

	// RVA: 0x1041050
	public override bool Read() { }

	// RVA: 0x104391C
	public override void Close() { }

	// RVA: 0x1043A78
	public override void Skip() { }

	// RVA: 0x1043CA4
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1043CE0
	public override bool ReadAttributeValue() { }

	// RVA: 0x1044520
	public override void ResolveEntity() { }

	// RVA: 0x1044D5C
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0x1044D6C
	internal void MoveOffEntityReference() { }

	// RVA: 0x1044E20
	public override string ReadString() { }

	// RVA: 0x1044E48
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1044E50
	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x1045A88
	public bool HasLineInfo() { }

	// RVA: 0x1045A90
	public int get_LineNumber() { }

	// RVA: 0x1045AB0
	public int get_LinePosition() { }

	// RVA: 0x1045AD0
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1045B20
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1045B30
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1045AF8
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1045B58
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1045B80
	internal bool get_Namespaces() { }

	// RVA: 0x1045B88
	internal void set_Namespaces(bool value) { }

	// RVA: 0x1045DA0
	internal bool get_Normalization() { }

	// RVA: 0x1045DA8
	internal void set_Normalization(bool value) { }

	// RVA: 0x1045ED8
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1045FB8
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1046040
	internal bool get_IsResolverSet() { }

	// RVA: 0x1046048
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10460DC
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0x10460E4
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0x10460EC
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0x104610C
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0x1046114
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0x104611C
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0x1046124
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x104620C
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x1046214
	internal Char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x104621C
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0x1046224
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0x104622C
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0x1046234
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0x1046240
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x1046248
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0x1046250
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x1046278
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0x1046280
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0x1046288
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0x10466EC
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1046804
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x10468FC
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0x1046CC0
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0x104718C
	private bool get_IsResolverNull() { }

	// RVA: 0x10471D8
	private XmlResolver GetTempResolver() { }

	// RVA: 0x1047254
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, int entityId) { }

	// RVA: 0x1047AB8
	internal bool DtdParserProxy_PopEntity(IDtdEntityInfo oldEntity, int newEntityId) { }

	// RVA: 0x1047C14
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x10483C0
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1048658
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0x1048770
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x10488BC
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x104894C
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0x1048A64
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0x1048B7C
	private void Throw(int pos, string res) { }

	// RVA: 0x103FD38
	private void Throw(string res) { }

	// RVA: 0x1048BE0
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0x1048964
	private void Throw(string res, string arg) { }

	// RVA: 0x1048CF0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x1048A7C
	private void Throw(string res, string[] args) { }

	// RVA: 0x1048DE4
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0x1048E78
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0x10486E4
	private void Throw(Exception e) { }

	// RVA: 0x1048F98
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0x1043654
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0x10490A0
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0x1049180
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0x1049274
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	// RVA: 0x1048F84
	private void SetErrorState() { }

	// RVA: 0x1047048
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0x10492E8
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0x1040C4C
	private bool get_InAttributeValueIterator() { }

	// RVA: 0x1040C70
	private void FinishAttributeValueIterator() { }

	// RVA: 0x10460FC
	private bool get_DtdValidation() { }

	// RVA: 0x103EA18
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0x103EA98
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x10495A0
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0x1049604
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x103F6A0
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x103ECAC
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0x10499CC
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0x103EDE8
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0x103EEF8
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0x103F9B8
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0x104201C
	private void OpenUrl() { }

	// RVA: 0x1049D38
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0x1049614
	private Encoding DetectEncoding() { }

	// RVA: 0x1049848
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0x1049EF4
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0x104A128
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0x104A078
	private void UnDecodeChars() { }

	// RVA: 0x104A4AC
	private void SwitchEncodingToUTF8() { }

	// RVA: 0x104628C
	private int ReadData() { }

	// RVA: 0x104A524
	private int GetChars(int maxCharsCount) { }

	// RVA: 0x104A644
	private void InvalidCharRecovery(int bytesCount, int charsCount) { }

	// RVA: 0x1043924
	internal void Close(bool closeInput) { }

	// RVA: 0x104A884
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0x1042260
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0x1041A0C
	private bool ParseDocumentContent() { }

	// RVA: 0x1041634
	private bool ParseElementContent() { }

	// RVA: 0x104C22C
	private void ThrowUnclosedElements() { }

	// RVA: 0x104AE48
	private void ParseElement() { }

	// RVA: 0x104CA60
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0x104BE84
	private void ParseEndElement() { }

	// RVA: 0x104DD14
	private void ThrowTagMismatch(NodeData startTag) { }

	// RVA: 0x104C408
	private void ParseAttributes() { }

	// RVA: 0x104D514
	private void ElementNamespaceLookup() { }

	// RVA: 0x104DC48
	private void AttributeNamespaceLookup() { }

	// RVA: 0x104F13C
	private void AttributeDuplCheck() { }

	// RVA: 0x104EC44
	private void OnDefaultNamespaceDecl(NodeData attr) { }

	// RVA: 0x104EDCC
	private void OnNamespaceDecl(NodeData attr) { }

	// RVA: 0x104EE94
	private void OnXmlReservedAttribute(NodeData attr) { }

	// RVA: 0x104E1A8
	private void ParseAttributeValueSlow(int curPos, Char quoteChar, NodeData attr) { }

	// RVA: 0x104F8D8
	private void AddAttributeChunkToList(NodeData attr, NodeData chunk, NodeData lastChunk) { }

	// RVA: 0x104B718
	private bool ParseText() { }

	// RVA: 0x1045300
	private bool ParseText(int startPos, int endPos, int outOrChars) { }

	// RVA: 0x10403B0
	private void FinishPartialValue() { }

	// RVA: 0x104049C
	private void FinishOtherValueIterator() { }

	// RVA: 0x1043750
	private void SkipPartialTextValue() { }

	// RVA: 0x1043798
	private void FinishReadValueChunk() { }

	// RVA: 0x10437B8
	private void FinishReadContentAsBinary() { }

	// RVA: 0x104381C
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0x104BB68
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0x10431CC
	private void ParseEntityReference() { }

	// RVA: 0x104B398
	private EntityType HandleEntityReference(bool isInAttributeValue, EntityExpandType expandType, int charRefEndPos) { }

	// RVA: 0x1044788
	private EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0x104A49C
	private bool get_InEntity() { }

	// RVA: 0x10493B4
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0x104324C
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0x104FDB0
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0x104AA94
	private bool ParsePI() { }

	// RVA: 0x1046944
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0x104FE34
	private bool ParsePIValue(int outStartPos, int outEndPos) { }

	// RVA: 0x104AA9C
	private bool ParseComment() { }

	// RVA: 0x104AB28
	private void ParseCData() { }

	// RVA: 0x1046EC4
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0x10501F8
	private bool ParseCDataOrComment(XmlNodeType type, int outStartPos, int outEndPos) { }

	// RVA: 0x104AB30
	private bool ParseDoctypeDecl() { }

	// RVA: 0x1050688
	private void ParseDtd() { }

	// RVA: 0x10509EC
	private void SkipDtd() { }

	// RVA: 0x1050D74
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0x1050E24
	private void SkipUntil(Char stopChar, bool recognizeLiterals) { }

	// RVA: 0x1048134
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0x104FB34
	private int ParseCharRefInline(int startPos, int charCount, EntityType entityType) { }

	// RVA: 0x1046714
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, EntityType entityType) { }

	// RVA: 0x1051340
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, int charCount, EntityType entityType) { }

	// RVA: 0x1046880
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x10519D4
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x104A8B4
	private int ParseName() { }

	// RVA: 0x104C3F8
	private int ParseQName(int colonPos) { }

	// RVA: 0x1051D20
	private int ParseQName(bool isQName, int startOffset, int colonPos) { }

	// RVA: 0x1051FA4
	private bool ReadDataInName(int pos) { }

	// RVA: 0x104F944
	private string ParseEntityName() { }

	// RVA: 0x104311C
	private NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1051FF0
	private NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1048800
	private NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0x104DFD8
	private NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0x105214C
	private NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1043164
	private void PopElementContext() { }

	// RVA: 0x1046264
	private void OnNewLine(int pos) { }

	// RVA: 0x10435A8
	private void OnEof() { }

	// RVA: 0x104F584
	private string LookupNamespace(NodeData node) { }

	// RVA: 0x104F6C4
	private void AddNamespace(string prefix, string uri, NodeData attr) { }

	// RVA: 0x104306C
	private void ResetAttributes() { }

	// RVA: 0x10522EC
	private void FullAttributeCleanup() { }

	// RVA: 0x104F634
	private void PushXmlContext() { }

	// RVA: 0x10522A8
	private void PopXmlContext() { }

	// RVA: 0x104FD5C
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0x104FACC
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0x1047DAC
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0x105238C
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0x1047390
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1047748
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1047B30
	private void PopEntity() { }

	// RVA: 0x1052608
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0x105288C
	private void UnregisterEntity() { }

	// RVA: 0x104843C
	private void PushParsingState() { }

	// RVA: 0x104A80C
	private void PopParsingState() { }

	// RVA: 0x10528F4
	private int IncrementalRead() { }

	// RVA: 0x10433D4
	private void FinishIncrementalRead() { }

	// RVA: 0x104345C
	private bool ParseFragmentAttribute() { }

	// RVA: 0x1044000
	private bool ParseAttributeValueChunk() { }

	// RVA: 0x10434F4
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0x104AB10
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x104A8A4
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0x104AE30
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x104A8DC
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0x104AE28
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0x1053268
	private string ParseUnexpectedToken() { }

	// RVA: 0x104DF14
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0x104076C
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0x1040870
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0x104FBA4
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0x1049ACC
	private void ParseDtdFromParserContext() { }

	// RVA: 0x104FC34
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0x103E5F8
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x1053354
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x105335C
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0x10534DC
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0x10534EC
	internal void set_OnDefaultAttributeUse(OnDefaultAttributeUseDelegate value) { }

	// RVA: 0x10534FC
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x10535D4
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0x10535DC
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0x10535FC
	internal XmlResolver GetResolver() { }

	// RVA: 0x1053648
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0x1053668
	internal object get_InternalTypedValue() { }

	// RVA: 0x1053688
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0x10536A8
	internal bool get_StandAlone() { }

	// RVA: 0x10536B0
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x10536B8
	internal bool get_V1Compat() { }

	// RVA: 0x104D57C
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, NodeData[] nameSortedNodeData) { }

	// RVA: 0x1053930
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0x10536C0
	private NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0x1053BB0
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0x103FC2C
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0x1048560
	private void RegisterConsumedCharacters(Int64 characters, bool inEntityReference) { }

	// RVA: 0x1053BB8
	internal static string StripSpaces(string value) { }

	// RVA: 0x1053DD8
	internal static void StripSpaces(Char[] value, int index, int len) { }

	// RVA: 0x1045A74
	internal static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	// RVA: 0x104A51C
	internal static void BlockCopy(Byte[] src, int srcOffset, Byte[] dst, int dstOffset, int count) { }

}

// Namespace: System.Xml
public enum Formatting
{
	// Fields
	public int value__; // 0x10
	public const Formatting None = 0;
	public const Formatting Indented = 1;
}

// Namespace: 
private enum NamespaceState
{
	// Fields
	public int value__; // 0x10
	public const NamespaceState Uninitialized = 0;
	public const NamespaceState NotDeclaredButInScope = 1;
	public const NamespaceState DeclaredButNotWrittenOut = 2;
	public const NamespaceState DeclaredAndWrittenOut = 3;
}

// Namespace: 
private struct TagInfo
{
	// Fields
	internal string name; // 0x10
	internal string prefix; // 0x18
	internal string defaultNs; // 0x20
	internal NamespaceState defaultNsState; // 0x28
	internal XmlSpace xmlSpace; // 0x2C
	internal string xmlLang; // 0x30
	internal int prevNsTop; // 0x38
	internal int prefixCount; // 0x3C
	internal bool mixed; // 0x40

	// Methods

	// RVA: 0x1146998
	internal void Init(int nsTop) { }

}

// Namespace: 
private struct Namespace
{
	// Fields
	internal string prefix; // 0x10
	internal string ns; // 0x18
	internal bool declared; // 0x20
	internal int prevNsIndex; // 0x24

	// Methods

	// RVA: 0x114B878
	internal void Set(string prefix, string ns, bool declared) { }

}

// Namespace: 
private enum SpecialAttr
{
	// Fields
	public int value__; // 0x10
	public const SpecialAttr None = 0;
	public const SpecialAttr XmlSpace = 1;
	public const SpecialAttr XmlLang = 2;
	public const SpecialAttr XmlNs = 3;
}

// Namespace: 
private enum State
{
	// Fields
	public int value__; // 0x10
	public const State Start = 0;
	public const State Prolog = 1;
	public const State PostDTD = 2;
	public const State Element = 3;
	public const State Attribute = 4;
	public const State Content = 5;
	public const State AttrOnly = 6;
	public const State Epilog = 7;
	public const State Error = 8;
	public const State Closed = 9;
}

// Namespace: 
private enum Token
{
	// Fields
	public int value__; // 0x10
	public const Token PI = 0;
	public const Token Doctype = 1;
	public const Token Comment = 2;
	public const Token CData = 3;
	public const Token StartElement = 4;
	public const Token EndElement = 5;
	public const Token LongEndElement = 6;
	public const Token StartAttribute = 7;
	public const Token EndAttribute = 8;
	public const Token Content = 9;
	public const Token Base64 = 10;
	public const Token RawData = 11;
	public const Token Whitespace = 12;
	public const Token Empty = 13;
}

// Namespace: System.Xml
public class XmlTextWriter
{
	// Fields
	private TextWriter textWriter; // 0x18
	private XmlTextEncoder xmlEncoder; // 0x20
	private Encoding encoding; // 0x28
	private Formatting formatting; // 0x30
	private bool indented; // 0x34
	private int indentation; // 0x38
	private Char indentChar; // 0x3C
	private TagInfo[] stack; // 0x40
	private int top; // 0x48
	private State[] stateTable; // 0x50
	private State currentState; // 0x58
	private Token lastToken; // 0x5C
	private XmlTextWriterBase64Encoder base64Encoder; // 0x60
	private Char quoteChar; // 0x68
	private Char curQuoteChar; // 0x6A
	private bool namespaces; // 0x6C
	private SpecialAttr specialAttr; // 0x70
	private string prefixForXmlNs; // 0x78
	private bool flush; // 0x80
	private Namespace[] nsStack; // 0x88
	private int nsTop; // 0x90
	private System.Collections.Generic.Dictionary<System.String,System.Int32> nsHashtable; // 0x98
	private bool useNsHashtable; // 0xA0
	private XmlCharType xmlCharType; // 0xA8
	private static string[] stateName; // 0x0
	private static string[] tokenName; // 0x8
	private static readonly State[] stateTableDefault; // 0x10
	private static readonly State[] stateTableDocument; // 0x18

	// Methods

	// RVA: 0x11467C8
	internal void .ctor() { }

	// RVA: 0x1146A2C
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x1146B3C
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x1146BC8
	public void .ctor(TextWriter w) { }

	// RVA: 0x1146C94
	public Stream get_BaseStream() { }

	// RVA: 0x1146D24
	public void set_Namespaces(bool value) { }

	// RVA: 0x1146D98
	public void set_Formatting(Formatting value) { }

	// RVA: 0x1146DAC
	public void set_QuoteChar(Char value) { }

	// RVA: 0x1146E38
	public override void WriteStartDocument() { }

	// RVA: 0x11471F8
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x114720C
	public override void WriteEndDocument() { }

	// RVA: 0x1147488
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x114816C
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1148D30
	public override void WriteEndElement() { }

	// RVA: 0x1149058
	public override void WriteFullEndElement() { }

	// RVA: 0x1149060
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1149998
	public override void WriteEndAttribute() { }

	// RVA: 0x1149A40
	public override void WriteCData(string text) { }

	// RVA: 0x1149C24
	public override void WriteComment(string text) { }

	// RVA: 0x1149E40
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x114A188
	public override void WriteEntityRef(string name) { }

	// RVA: 0x114A260
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x114A32C
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x114A4B0
	public override void WriteString(string text) { }

	// RVA: 0x114A588
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x114A664
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x114A748
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x114A82C
	public override void WriteRaw(string data) { }

	// RVA: 0x114A8F8
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x114AA64
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x114AB3C
	public override WriteState get_WriteState() { }

	// RVA: 0x114AB60
	public override void Close() { }

	// RVA: 0x114ACE0
	public override void Flush() { }

	// RVA: 0x114AD04
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1146E40
	private void StartDocument(int standalone) { }

	// RVA: 0x1147AF0
	private void AutoComplete(Token token) { }

	// RVA: 0x1147428
	private void AutoCompleteAll() { }

	// RVA: 0x1148D38
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x114AF48
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x114AEF0
	private void WriteEndAttributeQuote() { }

	// RVA: 0x114AE20
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x114895C
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x114B5EC
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x114B8C8
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x114B2D0
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x114987C
	private string GeneratePrefix() { }

	// RVA: 0x114A088
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x114877C
	private int LookupNamespace(string prefix) { }

	// RVA: 0x114973C
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x114887C
	private string FindPrefix(string ns) { }

	// RVA: 0x11478F8
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x114B3CC
	private void HandleSpecialAttribute() { }

	// RVA: 0x1148BDC
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x1148620
	private void PushStack() { }

	// RVA: 0x114B2A0
	private void FlushEncoders() { }

	// RVA: 0x114B9C0
	private static void .cctor() { }

}

// Namespace: System.Xml
internal class XmlUtf8RawTextWriter
{
	// Fields
	private readonly bool useAsync; // 0x28
	protected Byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected NewLineHandling newLineHandling; // 0x6C
	protected bool closeOutput; // 0x70
	protected bool omitXmlDeclaration; // 0x71
	protected string newLineChars; // 0x78
	protected bool checkCharacters; // 0x80
	protected XmlStandalone standalone; // 0x84
	protected XmlOutputMethod outputMethod; // 0x88
	protected bool autoXmlDeclaration; // 0x8C
	protected bool mergeCDataSections; // 0x8D

	// Methods

	// RVA: 0x114BFD8
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x114C404
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x114C578
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x114C7C4
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x114C84C
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x114CB34
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x114CC10
	internal override void StartElementContent() { }

	// RVA: 0x114CC5C
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x114CDEC
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x114CF18
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x114D05C
	public override void WriteEndAttribute() { }

	// RVA: 0x114D0AC
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x114D104
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x114D10C
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x114D260
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x114D2B0
	public override void WriteCData(string text) { }

	// RVA: 0x114D8B8
	public override void WriteComment(string text) { }

	// RVA: 0x114DDE4
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x114DF34
	public override void WriteEntityRef(string name) { }

	// RVA: 0x114E000
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x114E1E8
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x114E850
	public override void WriteString(string text) { }

	// RVA: 0x114E8A8
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x114EA18
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x114EA5C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x114ED64
	public override void WriteRaw(string data) { }

	// RVA: 0x114EDB0
	public override void Close() { }

	// RVA: 0x114EEC0
	public override void Flush() { }

	// RVA: 0x114EF0C
	protected virtual void FlushBuffer() { }

	// RVA: 0x114EEBC
	private void FlushEncoder() { }

	// RVA: 0x114E240
	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x114E528
	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x114C784
	protected void RawText(string s) { }

	// RVA: 0x114F54C
	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x114EAA8
	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x114DA1C
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x114D518
	protected void WriteCDataSection(string text) { }

	// RVA: 0x114F718
	private static bool IsSurrogateByte(Byte b) { }

	// RVA: 0x114F160
	private static Byte* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x114F2F0
	private Byte* InvalidXmlChar(int ch, Byte* pDst, bool entitize) { }

	// RVA: 0x114F7E0
	internal void EncodeChar(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x114F470
	internal static Byte* EncodeMultibyteUTF8(int ch, Byte* pDst) { }

	// RVA: 0x114F8C4
	internal static void CharToUTF8(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x114F4C4
	protected Byte* WriteNewLine(Byte* pDst) { }

	// RVA: 0x114F0D0
	protected static Byte* LtEntity(Byte* pDst) { }

	// RVA: 0x114F0E0
	protected static Byte* GtEntity(Byte* pDst) { }

	// RVA: 0x114F0B4
	protected static Byte* AmpEntity(Byte* pDst) { }

	// RVA: 0x114F0F0
	protected static Byte* QuoteEntity(Byte* pDst) { }

	// RVA: 0x114F10C
	protected static Byte* TabEntity(Byte* pDst) { }

	// RVA: 0x114F144
	protected static Byte* LineFeedEntity(Byte* pDst) { }

	// RVA: 0x114F128
	protected static Byte* CarriageReturnEntity(Byte* pDst) { }

	// RVA: 0x114F728
	private static Byte* CharEntity(Byte* pDst, Char ch) { }

	// RVA: 0x114F6F4
	protected static Byte* RawStartCData(Byte* pDst) { }

	// RVA: 0x114F6DC
	protected static Byte* RawEndCData(Byte* pDst) { }

	// RVA: 0x114C0E4
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

}

// Namespace: System.Xml
internal class XmlUtf8RawTextWriterIndent
{
	// Fields
	protected int indentLevel; // 0x90
	protected bool newLineOnAttributes; // 0x94
	protected string indentChars; // 0x98
	protected bool mixedContent; // 0xA0
	private BitStack mixedContentStack; // 0xA8
	protected ConformanceLevel conformanceLevel; // 0xB0

	// Methods

	// RVA: 0x114F994
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x114FAE0
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x114FBD8
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x114FC50
	internal override void StartElementContent() { }

	// RVA: 0x114FCDC
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x114FCE4
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x114FD6C
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x114FDF4
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x114FE3C
	public override void WriteCData(string text) { }

	// RVA: 0x114FE48
	public override void WriteComment(string text) { }

	// RVA: 0x114FEA0
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x114FEF4
	public override void WriteEntityRef(string name) { }

	// RVA: 0x114FF00
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x114FF0C
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x114FF18
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x114FF78
	public override void WriteString(string text) { }

	// RVA: 0x114FFD8
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1150024
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1150078
	public override void WriteRaw(string data) { }

	// RVA: 0x11500CC
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x114F9C0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x114FB4C
	private void WriteIndent() { }

}

// Namespace: System.Xml
public class XmlValidatingReader
{
	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Methods

	// RVA: 0x11500DC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1150100
	public override string get_LocalName() { }

	// RVA: 0x1150124
	public override string get_NamespaceURI() { }

	// RVA: 0x1150148
	public override string get_Prefix() { }

	// RVA: 0x115016C
	public override string get_Value() { }

	// RVA: 0x1150190
	public override int get_Depth() { }

	// RVA: 0x11501B4
	public override string get_BaseURI() { }

	// RVA: 0x11501DC
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1150204
	public override int get_AttributeCount() { }

	// RVA: 0x115022C
	public override string GetAttribute(string name) { }

	// RVA: 0x1150254
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x115027C
	public override string GetAttribute(int i) { }

	// RVA: 0x11502A4
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11502CC
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x11502F4
	public override bool MoveToNextAttribute() { }

	// RVA: 0x115031C
	public override bool MoveToElement() { }

	// RVA: 0x1150344
	public override bool ReadAttributeValue() { }

	// RVA: 0x115036C
	public override bool Read() { }

	// RVA: 0x1150394
	public override bool get_EOF() { }

	// RVA: 0x11503BC
	public override ReadState get_ReadState() { }

	// RVA: 0x11503E4
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x115040C
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1150448
	public override void ResolveEntity() { }

	// RVA: 0x1150470
	public bool get_Namespaces() { }

}

// Namespace: 
private enum ParsingFunction
{
	// Fields
	public int value__; // 0x10
	public const ParsingFunction Read = 0;
	public const ParsingFunction Init = 1;
	public const ParsingFunction ParseDtdFromContext = 2;
	public const ParsingFunction ResolveEntityInternally = 3;
	public const ParsingFunction InReadBinaryContent = 4;
	public const ParsingFunction ReaderClosed = 5;
	public const ParsingFunction Error = 6;
	public const ParsingFunction None = 7;
}

// Namespace: 
internal class ValidationEventHandling
{
	// Fields
	private XmlValidatingReaderImpl reader; // 0x10
	private ValidationEventHandler eventHandler; // 0x18

	// Methods

	// RVA: 0x1150A98
	internal void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x1152078
	private object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x1152080
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x1150ACC
	internal void AddHandler(ValidationEventHandler handler) { }

}

// Namespace: System.Xml
internal sealed class XmlValidatingReaderImpl
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlTextReaderImpl coreReaderImpl; // 0x18
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x20
	private ValidationType validationType; // 0x28
	private BaseValidator validator; // 0x30
	private XmlSchemaCollection schemaCollection; // 0x38
	private bool processIdentityConstraints; // 0x40
	private ParsingFunction parsingFunction; // 0x44
	private ValidationEventHandling eventHandling; // 0x48
	private XmlParserContext parserContext; // 0x50
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x58
	private XmlReader outerReader; // 0x60
	private static XmlResolver s_tempResolver; // 0x0

	// Methods

	// RVA: 0x11504B8
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x1150CFC
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1150DE8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1150E0C
	public override string get_Name() { }

	// RVA: 0x1150E30
	public override string get_LocalName() { }

	// RVA: 0x1150E54
	public override string get_NamespaceURI() { }

	// RVA: 0x1150E78
	public override string get_Prefix() { }

	// RVA: 0x1150E9C
	public override string get_Value() { }

	// RVA: 0x1150EC0
	public override int get_Depth() { }

	// RVA: 0x1150EE4
	public override string get_BaseURI() { }

	// RVA: 0x1150F0C
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1150F34
	public override bool get_IsDefault() { }

	// RVA: 0x1150F5C
	public override Char get_QuoteChar() { }

	// RVA: 0x1150F84
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1150FAC
	public override string get_XmlLang() { }

	// RVA: 0x1150FD4
	public override ReadState get_ReadState() { }

	// RVA: 0x1151014
	public override bool get_EOF() { }

	// RVA: 0x115103C
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1151064
	public override int get_AttributeCount() { }

	// RVA: 0x115108C
	public override string GetAttribute(string name) { }

	// RVA: 0x11510B4
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x11510DC
	public override string GetAttribute(int i) { }

	// RVA: 0x1151104
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1151144
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1151180
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x11511C0
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1151200
	public override bool MoveToElement() { }

	// RVA: 0x1151240
	public override bool Read() { }

	// RVA: 0x11516CC
	public override void Close() { }

	// RVA: 0x115170C
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1151734
	public override bool ReadAttributeValue() { }

	// RVA: 0x1151794
	public override bool get_CanResolveEntity() { }

	// RVA: 0x115179C
	public override void ResolveEntity() { }

	// RVA: 0x11517D4
	internal void MoveOffEntityReference() { }

	// RVA: 0x1151888
	public override string ReadString() { }

	// RVA: 0x11518B0
	public bool HasLineInfo() { }

	// RVA: 0x11518B8
	public int get_LineNumber() { }

	// RVA: 0x11519C0
	public int get_LinePosition() { }

	// RVA: 0x1151AC8
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1151C30
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1151C40
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1151B7C
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1151CF8
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1151DB0
	internal ValidationType get_ValidationType() { }

	// RVA: 0x1151DB8
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x1150498
	internal bool get_Namespaces() { }

	// RVA: 0x1151484
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1151DC0
	private void ValidateDtd() { }

	// RVA: 0x1151644
	private void ResolveEntityInternally() { }

	// RVA: 0x1150B80
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x115099C
	private XmlResolver GetResolver() { }

	// RVA: 0x115132C
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x1151E40
	internal BaseValidator get_Validator() { }

	// RVA: 0x1151E48
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x1151E50
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1151E78
	internal bool get_StandAlone() { }

	// RVA: 0x1151E98
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x1151EB8
	internal object get_TypedValueObject() { }

	// RVA: 0x1151ED8
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x1151EF8
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x1151F18
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1151F40
	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

}

// Namespace: 
private enum State
{
	// Fields
	public int value__; // 0x10
	public const State Start = 0;
	public const State TopLevel = 1;
	public const State Document = 2;
	public const State Element = 3;
	public const State Content = 4;
	public const State B64Content = 5;
	public const State B64Attribute = 6;
	public const State AfterRootEle = 7;
	public const State Attribute = 8;
	public const State SpecialAttr = 9;
	public const State EndDocument = 10;
	public const State RootLevelAttr = 11;
	public const State RootLevelSpecAttr = 12;
	public const State RootLevelB64Attr = 13;
	public const State AfterRootLevelAttr = 14;
	public const State Closed = 15;
	public const State Error = 16;
	public const State StartContent = 101;
	public const State StartContentEle = 102;
	public const State StartContentB64 = 103;
	public const State StartDoc = 104;
	public const State StartDocEle = 106;
	public const State EndAttrSEle = 107;
	public const State EndAttrEEle = 108;
	public const State EndAttrSCont = 109;
	public const State EndAttrSAttr = 111;
	public const State PostB64Cont = 112;
	public const State PostB64Attr = 113;
	public const State PostB64RootAttr = 114;
	public const State StartFragEle = 115;
	public const State StartFragCont = 116;
	public const State StartFragB64 = 117;
	public const State StartRootLevelAttr = 118;
}

// Namespace: 
private enum Token
{
	// Fields
	public int value__; // 0x10
	public const Token StartDocument = 0;
	public const Token EndDocument = 1;
	public const Token PI = 2;
	public const Token Comment = 3;
	public const Token Dtd = 4;
	public const Token StartElement = 5;
	public const Token EndElement = 6;
	public const Token StartAttribute = 7;
	public const Token EndAttribute = 8;
	public const Token Text = 9;
	public const Token CData = 10;
	public const Token AtomicValue = 11;
	public const Token Base64 = 12;
	public const Token RawData = 13;
	public const Token Whitespace = 14;
}

// Namespace: 
private class NamespaceResolverProxy
{
	// Fields
	private XmlWellFormedWriter wfWriter; // 0x10

	// Methods

	// RVA: 0x115276C
	internal void .ctor(XmlWellFormedWriter wfWriter) { }

	// RVA: 0x1159280
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11592C0
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11592DC
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

// Namespace: 
private struct ElementScope
{
	// Fields
	internal int prevNSTop; // 0x10
	internal string prefix; // 0x18
	internal string localName; // 0x20
	internal string namespaceUri; // 0x28
	internal XmlSpace xmlSpace; // 0x30
	internal string xmlLang; // 0x38

	// Methods

	// RVA: 0x11527EC
	internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x115418C
	internal void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x11544E8
	internal void WriteFullEndElement(XmlRawWriter rawWriter) { }

}

// Namespace: 
private enum NamespaceKind
{
	// Fields
	public int value__; // 0x10
	public const NamespaceKind Written = 0;
	public const NamespaceKind NeedToWrite = 1;
	public const NamespaceKind Implied = 2;
	public const NamespaceKind Special = 3;
}

// Namespace: 
private struct Namespace
{
	// Fields
	internal string prefix; // 0x10
	internal string namespaceUri; // 0x18
	internal NamespaceKind kind; // 0x20
	internal int prevNsIndex; // 0x24

	// Methods

	// RVA: 0x11527A0
	internal void Set(string prefix, string namespaceUri, NamespaceKind kind) { }

	// RVA: 0x11586C0
	internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }

}

// Namespace: 
private struct AttrName
{
	// Fields
	internal string prefix; // 0x10
	internal string namespaceUri; // 0x18
	internal string localName; // 0x20
	internal int prev; // 0x28

	// Methods

	// RVA: 0x1159304
	internal void Set(string prefix, string localName, string namespaceUri) { }

	// RVA: 0x115935C
	internal bool IsDuplicate(string prefix, string localName, string namespaceUri) { }

}

// Namespace: 
private enum SpecialAttribute
{
	// Fields
	public int value__; // 0x10
	public const SpecialAttribute No = 0;
	public const SpecialAttribute DefaultXmlns = 1;
	public const SpecialAttribute PrefixedXmlns = 2;
	public const SpecialAttribute XmlSpace = 3;
	public const SpecialAttribute XmlLang = 4;
}

// Namespace: 
private enum ItemType
{
	// Fields
	public int value__; // 0x10
	public const ItemType EntityRef = 0;
	public const ItemType CharEntity = 1;
	public const ItemType SurrogateCharEntity = 2;
	public const ItemType Whitespace = 3;
	public const ItemType String = 4;
	public const ItemType StringChars = 5;
	public const ItemType Raw = 6;
	public const ItemType RawChars = 7;
	public const ItemType ValueString = 8;
}

// Namespace: 
private class Item
{
	// Fields
	internal ItemType type; // 0x10
	internal object data; // 0x18

	// Methods

	// RVA: 0x115A644
	internal void .ctor() { }

	// RVA: 0x115A64C
	internal void Set(ItemType type, object data) { }

}

// Namespace: 
private class BufferChunk
{
	// Fields
	internal Char[] buffer; // 0x10
	internal int index; // 0x18
	internal int count; // 0x1C

	// Methods

	// RVA: 0x1159BCC
	internal void .ctor(Char[] buffer, int index, int count) { }

}

// Namespace: 
private class AttributeValueCache
{
	// Fields
	private StringBuilder stringValue; // 0x10
	private string singleStringValue; // 0x18
	private Item[] items; // 0x20
	private int firstItem; // 0x28
	private int lastItem; // 0x2C

	// Methods

	// RVA: 0x11593D0
	internal string get_StringValue() { }

	// RVA: 0x1159408
	internal void WriteEntityRef(string name) { }

	// RVA: 0x11597E0
	internal void WriteCharEntity(Char ch) { }

	// RVA: 0x11598AC
	internal void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11599A0
	internal void WriteWhitespace(string ws) { }

	// RVA: 0x1159A28
	internal void WriteString(string text) { }

	// RVA: 0x1159ADC
	internal void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1159C18
	internal void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1159D08
	internal void WriteRaw(string data) { }

	// RVA: 0x1159D90
	internal void WriteValue(string value) { }

	// RVA: 0x1159E18
	internal void Replay(XmlWriter writer) { }

	// RVA: 0x115A144
	internal void Trim() { }

	// RVA: 0x115A5FC
	internal void Clear() { }

	// RVA: 0x11595E4
	private void StartComplexValue() { }

	// RVA: 0x1159638
	private void AddItem(ItemType type, object data) { }

	// RVA: 0x115A65C
	public void .ctor() { }

}

// Namespace: System.Xml
internal class XmlWellFormedWriter
{
	// Fields
	private XmlWriter writer; // 0x18
	private XmlRawWriter rawWriter; // 0x20
	private IXmlNamespaceResolver predefinedNamespaces; // 0x28
	private Namespace[] nsStack; // 0x30
	private int nsTop; // 0x38
	private System.Collections.Generic.Dictionary<System.String,System.Int32> nsHashtable; // 0x40
	private bool useNsHashtable; // 0x48
	private ElementScope[] elemScopeStack; // 0x50
	private int elemTop; // 0x58
	private AttrName[] attrStack; // 0x60
	private int attrCount; // 0x68
	private System.Collections.Generic.Dictionary<System.String,System.Int32> attrHashTable; // 0x70
	private SpecialAttribute specAttr; // 0x78
	private AttributeValueCache attrValueCache; // 0x80
	private string curDeclPrefix; // 0x88
	private State[] stateTable; // 0x90
	private State currentState; // 0x98
	private bool checkCharacters; // 0x9C
	private bool omitDuplNamespaces; // 0x9D
	private bool writeEndDocumentOnClose; // 0x9E
	private ConformanceLevel conformanceLevel; // 0xA0
	private bool dtdWritten; // 0xA4
	private bool xmlDeclFollows; // 0xA5
	private XmlCharType xmlCharType; // 0xA8
	private SecureStringHasher hasher; // 0xB0
	internal static readonly string[] stateName; // 0x0
	internal static readonly string[] tokenName; // 0x8
	private static WriteState[] state2WriteState; // 0x10
	private static readonly State[] StateTableDocument; // 0x18
	private static readonly State[] StateTableAuto; // 0x20

	// Methods

	// RVA: 0x11521A4
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1152858
	public override WriteState get_WriteState() { }

	// RVA: 0x11528F8
	public override void WriteStartDocument() { }

	// RVA: 0x1152ACC
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1152AEC
	public override void WriteEndDocument() { }

	// RVA: 0x1152FBC
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x115349C
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1153F60
	public override void WriteEndElement() { }

	// RVA: 0x11542BC
	public override void WriteFullEndElement() { }

	// RVA: 0x115451C
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1155300
	public override void WriteEndAttribute() { }

	// RVA: 0x115611C
	public override void WriteCData(string text) { }

	// RVA: 0x1156234
	public override void WriteComment(string text) { }

	// RVA: 0x115634C
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1156610
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11567A0
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1156958
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1156B1C
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1156CF0
	public override void WriteString(string text) { }

	// RVA: 0x1156DF4
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1157074
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11572F4
	public override void WriteRaw(string data) { }

	// RVA: 0x11573F8
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1157644
	public override void Close() { }

	// RVA: 0x115784C
	public override void Flush() { }

	// RVA: 0x115790C
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1157BB4
	public override void WriteValue(string value) { }

	// RVA: 0x1157CC8
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1157E0C
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0x1156790
	private bool get_SaveAttrValue() { }

	// RVA: 0x1157830
	private bool get_InBase64() { }

	// RVA: 0x1154D80
	private void SetSpecialAttribute(SpecialAttribute special) { }

	// RVA: 0x1152900
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x1157E14
	private void StartFragment() { }

	// RVA: 0x1153B34
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x1155C14
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x1157F20
	private void AddNamespace(string prefix, string ns, NamespaceKind kind) { }

	// RVA: 0x11581F4
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1157E20
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x11541C0
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x11580E4
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x1152C54
	private void AdvanceState(Token token) { }

	// RVA: 0x11585EC
	private void StartElementContent() { }

	// RVA: 0x11582EC
	private static string GetStateName(State state) { }

	// RVA: 0x11539E8
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x1154F74
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x1154E30
	private string GeneratePrefix() { }

	// RVA: 0x11538DC
	private void CheckNCName(string ncname) { }

	// RVA: 0x1158800
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x1158398
	private void ThrowInvalidStateTransition(Token token, State currentState) { }

	// RVA: 0x1157DFC
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x1155058
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1158940
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x1158A7C
	private static void .cctor() { }

}

// Namespace: System.Xml
public enum WriteState
{
	// Fields
	public int value__; // 0x10
	public const WriteState Start = 0;
	public const WriteState Prolog = 1;
	public const WriteState Element = 2;
	public const WriteState Attribute = 3;
	public const WriteState Content = 4;
	public const WriteState Closed = 5;
	public const WriteState Error = 6;
}

// Namespace: System.Xml
public abstract class XmlWriter
{
	// Fields
	private Char[] writeNodeBuffer; // 0x10

	// Methods

	// RVA: -1
	public abstract void WriteStartDocument() { }

	// RVA: -1
	public abstract void WriteStartDocument(bool standalone) { }

	// RVA: -1
	public abstract void WriteEndDocument() { }

	// RVA: -1
	public abstract void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x115A6DC
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1
	public abstract void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: -1
	public abstract void WriteEndElement() { }

	// RVA: -1
	public abstract void WriteFullEndElement() { }

	// RVA: 0x115A6F4
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x115A754
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x115A7B4
	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	// RVA: -1
	public abstract void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: -1
	public abstract void WriteEndAttribute() { }

	// RVA: -1
	public abstract void WriteCData(string text) { }

	// RVA: -1
	public abstract void WriteComment(string text) { }

	// RVA: -1
	public abstract void WriteProcessingInstruction(string name, string text) { }

	// RVA: -1
	public abstract void WriteEntityRef(string name) { }

	// RVA: -1
	public abstract void WriteCharEntity(Char ch) { }

	// RVA: -1
	public abstract void WriteWhitespace(string ws) { }

	// RVA: -1
	public abstract void WriteString(string text) { }

	// RVA: -1
	public abstract void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: -1
	public abstract void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: -1
	public abstract void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: -1
	public abstract void WriteRaw(string data) { }

	// RVA: -1
	public abstract void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x115A808
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: -1
	public abstract WriteState get_WriteState() { }

	// RVA: 0x115A824
	public virtual void Close() { }

	// RVA: -1
	public abstract void Flush() { }

	// RVA: -1
	public abstract string LookupPrefix(string ns) { }

	// RVA: 0x115A828
	public virtual void WriteValue(string value) { }

	// RVA: 0x115A840
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x115AAE8
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x115AF6C
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x115AFD4
	public void Dispose() { }

	// RVA: 0x115AFE8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x115B03C
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x115B6A0
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x115BAAC
	protected void .ctor() { }

}

// Namespace: System.Xml
public enum XmlOutputMethod
{
	// Fields
	public int value__; // 0x10
	public const XmlOutputMethod Xml = 0;
	public const XmlOutputMethod Html = 1;
	public const XmlOutputMethod Text = 2;
	public const XmlOutputMethod AutoDetect = 3;
}

// Namespace: System.Xml
internal enum TriState
{
	// Fields
	public int value__; // 0x10
	public const TriState Unknown = 4294967295;
	public const TriState False = 0;
	public const TriState True = 1;
}

// Namespace: System.Xml
internal enum XmlStandalone
{
	// Fields
	public int value__; // 0x10
	public const XmlStandalone Omit = 0;
	public const XmlStandalone Yes = 1;
	public const XmlStandalone No = 2;
}

// Namespace: System.Xml
public sealed class XmlWriterSettings
{
	// Fields
	private bool useAsync; // 0x10
	private Encoding encoding; // 0x18
	private bool omitXmlDecl; // 0x20
	private NewLineHandling newLineHandling; // 0x24
	private string newLineChars; // 0x28
	private TriState indent; // 0x30
	private string indentChars; // 0x38
	private bool newLineOnAttributes; // 0x40
	private bool closeOutput; // 0x41
	private NamespaceHandling namespaceHandling; // 0x44
	private ConformanceLevel conformanceLevel; // 0x48
	private bool checkCharacters; // 0x4C
	private bool writeEndDocumentOnClose; // 0x4D
	private XmlOutputMethod outputMethod; // 0x50
	private System.Collections.Generic.List<System.Xml.XmlQualifiedName> cdataSections; // 0x58
	private bool doNotEscapeUriAttributes; // 0x60
	private bool mergeCDataSections; // 0x61
	private string mediaType; // 0x68
	private string docTypeSystem; // 0x70
	private string docTypePublic; // 0x78
	private XmlStandalone standalone; // 0x80
	private bool autoXmlDecl; // 0x84
	private bool isReadOnly; // 0x85

	// Methods

	// RVA: 0x115B0B0
	public void .ctor() { }

	// RVA: 0x115BC20
	public bool get_Async() { }

	// RVA: 0x115BC28
	public Encoding get_Encoding() { }

	// RVA: 0x115BC30
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x115BC38
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x115BD50
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x115BD58
	public string get_NewLineChars() { }

	// RVA: 0x115BD60
	public bool get_Indent() { }

	// RVA: 0x115BD70
	public void set_Indent(bool value) { }

	// RVA: 0x115BDD8
	public string get_IndentChars() { }

	// RVA: 0x115BDE0
	public bool get_NewLineOnAttributes() { }

	// RVA: 0x115BDE8
	public bool get_CloseOutput() { }

	// RVA: 0x115BDF0
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x115BDF8
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x115BEA8
	public bool get_CheckCharacters() { }

	// RVA: 0x115BEB0
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x115BEB8
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x115BF68
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x115BF70
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x115BF78
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x115BF80
	public XmlWriterSettings Clone() { }

	// RVA: 0x115C060
	internal System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0x115C068
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x115C070
	internal bool get_MergeCDataSections() { }

	// RVA: 0x115C078
	internal string get_MediaType() { }

	// RVA: 0x115C080
	internal string get_DocTypeSystem() { }

	// RVA: 0x115C088
	internal string get_DocTypePublic() { }

	// RVA: 0x115C090
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x115C098
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0x115C0A0
	internal TriState get_IndentInternal() { }

	// RVA: 0x115C0A8
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x115B144
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x115B714
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x115C144
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x115BC98
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x115BAB4
	private void Initialize() { }

}

// Namespace: 
private enum CachingReaderState
{
	// Fields
	public int value__; // 0x10
	public const CachingReaderState None = 0;
	public const CachingReaderState Init = 1;
	public const CachingReaderState Record = 2;
	public const CachingReaderState Replay = 3;
	public const CachingReaderState ReaderClosed = 4;
	public const CachingReaderState Error = 5;
}

// Namespace: System.Xml
internal class XsdCachingReader
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlNameTable coreReaderNameTable; // 0x18
	private ValidatingReaderNodeData[] contentEvents; // 0x20
	private ValidatingReaderNodeData[] attributeEvents; // 0x28
	private ValidatingReaderNodeData cachedNode; // 0x30
	private CachingReaderState cacheState; // 0x38
	private int contentIndex; // 0x3C
	private int attributeCount; // 0x40
	private bool returnOriginalStringValues; // 0x44
	private CachingEventHandler cacheHandler; // 0x48
	private int currentAttrIndex; // 0x50
	private int currentContentIndex; // 0x54
	private bool readAhead; // 0x58
	private IXmlLineInfo lineInfo; // 0x60
	private ValidatingReaderNodeData textNode; // 0x68

	// Methods

	// RVA: 0x115C14C
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x115C248
	private void Init() { }

	// RVA: 0x115C6B4
	internal void Reset(XmlReader reader) { }

	// RVA: 0x115C6DC
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x115C700
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x115C720
	public override string get_Name() { }

	// RVA: 0x115C748
	public override string get_LocalName() { }

	// RVA: 0x115C768
	public override string get_NamespaceURI() { }

	// RVA: 0x115C788
	public override string get_Prefix() { }

	// RVA: 0x115C7A8
	public override string get_Value() { }

	// RVA: 0x115C7E0
	public override int get_Depth() { }

	// RVA: 0x115C800
	public override string get_BaseURI() { }

	// RVA: 0x115C828
	public override bool get_IsEmptyElement() { }

	// RVA: 0x115C830
	public override bool get_IsDefault() { }

	// RVA: 0x115C838
	public override Char get_QuoteChar() { }

	// RVA: 0x115C860
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x115C888
	public override string get_XmlLang() { }

	// RVA: 0x115C8B0
	public override int get_AttributeCount() { }

	// RVA: 0x115C8B8
	public override string GetAttribute(string name) { }

	// RVA: 0x115CAC8
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x115CC08
	public override string GetAttribute(int i) { }

	// RVA: 0x115CCA4
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x115CD58
	public override void MoveToAttribute(int i) { }

	// RVA: 0x115CDF4
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x115CE44
	public override bool MoveToNextAttribute() { }

	// RVA: 0x115CEA8
	public override bool MoveToElement() { }

	// RVA: 0x115CF04
	public override bool Read() { }

	// RVA: 0x115D224
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x115D2A0
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x115D3E4
	internal void RecordEndElementNode() { }

	// RVA: 0x115D508
	public override bool get_EOF() { }

	// RVA: 0x115D548
	public override void Close() { }

	// RVA: 0x115D588
	public override ReadState get_ReadState() { }

	// RVA: 0x115D5B0
	public override void Skip() { }

	// RVA: 0x115D6C8
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x115D6D0
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x115D6F8
	public override void ResolveEntity() { }

	// RVA: 0x115D738
	public override bool ReadAttributeValue() { }

	// RVA: 0x115D8B8
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x115D8C0
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x115D8E0
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x115D900
	internal void SetToReplayMode() { }

	// RVA: 0x115D920
	internal XmlReader GetCoreReader() { }

	// RVA: 0x115D928
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x115D214
	private void ClearAttributesInfo() { }

	// RVA: 0x115D930
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x115C3B4
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x115C540
	private void RecordAttributes() { }

	// RVA: 0x115C950
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x115CA1C
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x115D814
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

}

// Namespace: System.Xml
internal sealed class CachingEventHandler
{
	// Methods

	// RVA: 0x115DAB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x115DBD4
	public virtual void Invoke(XsdCachingReader cachingReader) { }

}

// Namespace: System.Xml
internal class AttributePSVIInfo
{
	// Fields
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal object typedAttributeValue; // 0x20
	internal XmlSchemaInfo attributeSchemaInfo; // 0x28

	// Methods

	// RVA: 0x115DBE8
	internal void .ctor() { }

	// RVA: 0x115DC60
	internal void Reset() { }

}

// Namespace: 
private enum ValidatingReaderState
{
	// Fields
	public int value__; // 0x10
	public const ValidatingReaderState None = 0;
	public const ValidatingReaderState Init = 1;
	public const ValidatingReaderState Read = 2;
	public const ValidatingReaderState OnDefaultAttribute = 4294967295;
	public const ValidatingReaderState OnReadAttributeValue = 4294967294;
	public const ValidatingReaderState OnAttribute = 3;
	public const ValidatingReaderState ClearAttributes = 4;
	public const ValidatingReaderState ParseInlineSchema = 5;
	public const ValidatingReaderState ReadAhead = 6;
	public const ValidatingReaderState OnReadBinaryContent = 7;
	public const ValidatingReaderState ReaderClosed = 8;
	public const ValidatingReaderState EOF = 9;
	public const ValidatingReaderState Error = 10;
}

// Namespace: System.Xml
internal class XsdValidatingReader
{
	// Fields
	private XmlReader coreReader; // 0x10
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x18
	private IXmlNamespaceResolver thisNSResolver; // 0x20
	private XmlSchemaValidator validator; // 0x28
	private XmlResolver xmlResolver; // 0x30
	private ValidationEventHandler validationEvent; // 0x38
	private ValidatingReaderState validationState; // 0x40
	private XmlValueGetter valueGetter; // 0x48
	private XmlNamespaceManager nsManager; // 0x50
	private bool manageNamespaces; // 0x58
	private bool processInlineSchema; // 0x59
	private bool replayCache; // 0x5A
	private ValidatingReaderNodeData cachedNode; // 0x60
	private AttributePSVIInfo attributePSVI; // 0x68
	private int attributeCount; // 0x70
	private int coreReaderAttributeCount; // 0x74
	private int currentAttrIndex; // 0x78
	private AttributePSVIInfo[] attributePSVINodes; // 0x80
	private ArrayList defaultAttributes; // 0x88
	private Parser inlineSchemaParser; // 0x90
	private object atomicValue; // 0x98
	private XmlSchemaInfo xmlSchemaInfo; // 0xA0
	private string originalAtomicValueString; // 0xA8
	private XmlNameTable coreReaderNameTable; // 0xB0
	private XsdCachingReader cachingReader; // 0xB8
	private ValidatingReaderNodeData textNode; // 0xC0
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsdSchema; // 0xF0
	private string XsiSchemaLocation; // 0xF8
	private string XsiNoNamespaceSchemaLocation; // 0x100
	private XmlCharType xmlCharType; // 0x108
	private IXmlLineInfo lineInfo; // 0x110
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x118
	private ValidatingReaderState savedState; // 0x120
	private static Type TypeOfString; // 0x0

	// Methods

	// RVA: 0x115DCFC
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x115E504
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x115DF18
	private void Init() { }

	// RVA: 0x115E2E8
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x115E50C
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x115E5E0
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x115E678
	public override string get_Name() { }

	// RVA: 0x115E7A4
	public override string get_LocalName() { }

	// RVA: 0x115E7E4
	public override string get_NamespaceURI() { }

	// RVA: 0x115E824
	public override string get_Prefix() { }

	// RVA: 0x115E864
	public override string get_Value() { }

	// RVA: 0x115E8A4
	public override int get_Depth() { }

	// RVA: 0x115E8E4
	public override string get_BaseURI() { }

	// RVA: 0x115E90C
	public override bool get_IsEmptyElement() { }

	// RVA: 0x115E934
	public override bool get_IsDefault() { }

	// RVA: 0x115E974
	public override Char get_QuoteChar() { }

	// RVA: 0x115E99C
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x115E9C4
	public override string get_XmlLang() { }

	// RVA: 0x115E9EC
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x115E9F0
	public override Type get_ValueType() { }

	// RVA: 0x115EADC
	public override int get_AttributeCount() { }

	// RVA: 0x115EAE4
	public override string GetAttribute(string name) { }

	// RVA: 0x115ECF4
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x115EF64
	public override string GetAttribute(int i) { }

	// RVA: 0x115F058
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x115F368
	public override void MoveToAttribute(int i) { }

	// RVA: 0x115F564
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x115F728
	public override bool MoveToNextAttribute() { }

	// RVA: 0x115F8EC
	public override bool MoveToElement() { }

	// RVA: 0x115F954
	public override bool Read() { }

	// RVA: 0x115FE3C
	public override bool get_EOF() { }

	// RVA: 0x115FE64
	public override void Close() { }

	// RVA: 0x115FEA4
	public override ReadState get_ReadState() { }

	// RVA: 0x115FEE4
	public override void Skip() { }

	// RVA: 0x116004C
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1160054
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x116010C
	public override void ResolveEntity() { }

	// RVA: 0x116014C
	public override bool ReadAttributeValue() { }

	// RVA: 0x1160350
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1160690
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x11606EC
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x11607A4
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x116094C
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x11609BC
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x1160A24
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x1160A7C
	public bool HasLineInfo() { }

	// RVA: 0x1160A84
	public int get_LineNumber() { }

	// RVA: 0x1160B48
	public int get_LinePosition() { }

	// RVA: 0x1160C0C
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1160CE8
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1160DC8
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1160EA8
	private object GetStringValue() { }

	// RVA: 0x115EABC
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x115FB28
	private void ProcessReaderEvent() { }

	// RVA: 0x1160ECC
	private void ProcessElementEvent() { }

	// RVA: 0x1161398
	private void ProcessEndElementEvent() { }

	// RVA: 0x116161C
	private void ValidateAttributes() { }

	// RVA: 0x115FDEC
	private void ClearAttributesInfo() { }

	// RVA: 0x115F150
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x1161B60
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x115EB64
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x115EE14
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x1161990
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x11615D0
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x115FCF4
	private void ProcessInlineSchema() { }

	// RVA: 0x1161C2C
	private void ReadAheadForMemberType() { }

	// RVA: 0x11603EC
	private void GetIsDefault() { }

	// RVA: 0x1160838
	private void GetMemberType() { }

	// RVA: 0x116188C
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x11602AC
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x1161EC8
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x11617E4
	private string GetOriginalAtomicValueStringOfElement() { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNavigator
{
	// Fields
	private XmlDocument document; // 0x10
	private XmlNode source; // 0x18
	private int attributeIndex; // 0x20
	private XmlElement namespaceParent; // 0x28

	// Methods

	// RVA: 0x1161F14
	public void .ctor(XmlDocument document, XmlNode node) { }

	// RVA: 0x1162108
	public void .ctor(DocumentXPathNavigator other) { }

	// RVA: 0x11621CC
	public override XPathNavigator Clone() { }

	// RVA: 0x1162230
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1162278
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x1162364
	public override string get_LocalName() { }

	// RVA: 0x116238C
	public override string get_NamespaceURI() { }

	// RVA: 0x116249C
	public override string get_Name() { }

	// RVA: 0x11625E8
	public override string get_Prefix() { }

	// RVA: 0x11626C8
	public override string get_Value() { }

	// RVA: 0x116277C
	private string get_ValueDocument() { }

	// RVA: 0x1162860
	private string get_ValueText() { }

	// RVA: 0x1162B18
	public override string get_BaseURI() { }

	// RVA: 0x1162B40
	public override string get_XmlLang() { }

	// RVA: 0x1162B68
	public override object get_UnderlyingObject() { }

	// RVA: 0x1162B8C
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1162EC0
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1163040
	public override bool MoveToNextAttribute() { }

	// RVA: 0x116337C
	public override bool MoveToNamespace(string name) { }

	// RVA: 0x11636F0
	public override bool MoveToFirstNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x1163978
	private static bool MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x1163A00
	private static bool MoveToFirstNamespaceGlobal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x1163D08
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x116418C
	private static bool MoveToNextNamespaceLocal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x1163B84
	private static bool MoveToNextNamespaceGlobal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x1164220
	private bool PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, string localName) { }

	// RVA: 0x116431C
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x116437C
	public override bool MoveToNext() { }

	// RVA: 0x1164704
	public override bool MoveToFirstChild() { }

	// RVA: 0x11649C8
	public override bool MoveToParent() { }

	// RVA: 0x1164B58
	public override void MoveToRoot() { }

	// RVA: 0x1164C70
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x1164D24
	public override bool MoveToId(string id) { }

	// RVA: 0x1164D8C
	public override bool MoveToChild(string localName, string namespaceUri) { }

	// RVA: 0x1164F08
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x116507C
	public override bool MoveToFollowing(string localName, string namespaceUri, XPathNavigator end) { }

	// RVA: 0x1165304
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x1165608
	public override bool MoveToNext(string localName, string namespaceUri) { }

	// RVA: 0x11656DC
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x116583C
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x11658E4
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x1165AF8
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1165B20
	private static XmlNode OwnerNode(XmlNode node) { }

	// RVA: 0x1165BD4
	private static int GetDepth(XmlNode node) { }

	// RVA: 0x1165D40
	private XmlNodeOrder Compare(XmlNode node1, XmlNode node2) { }

	// RVA: 0x1165F58
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x11664EC
	private XmlNode System.Xml.IHasXmlNode.GetNode() { }

	// RVA: 0x11664F4
	public override XPathNodeIterator SelectDescendants(string localName, string namespaceURI, bool matchSelf) { }

	// RVA: 0x1166814
	public override XPathNodeIterator SelectDescendants(XPathNodeType nt, bool includeSelf) { }

	// RVA: 0x1161FA4
	internal void ResetPosition(XmlNode node) { }

	// RVA: 0x11632F0
	private static bool ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, int index) { }

	// RVA: 0x1163228
	private static bool CheckAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, int index) { }

	// RVA: 0x11622B0
	private void CalibrateText() { }

	// RVA: 0x11645B8
	private XmlNode ParentNode(XmlNode node) { }

	// RVA: 0x11669B0
	private XmlNode ParentNodeTail(XmlNode parent) { }

	// RVA: 0x116493C
	private XmlNode FirstChild(XmlNode node) { }

	// RVA: 0x1166A04
	private XmlNode FirstChildTail(XmlNode child) { }

	// RVA: 0x1162A20
	private XmlNode NextSibling(XmlNode node) { }

	// RVA: 0x1166A5C
	private XmlNode NextSiblingTail(XmlNode node, XmlNode sibling) { }

	// RVA: 0x1166950
	private XmlNode PreviousText(XmlNode node) { }

	// RVA: 0x1166B20
	private XmlNode PreviousTextTail(XmlNode node, XmlNode text) { }

	// RVA: 0x1165A14
	private static bool IsDescendant(XmlNode top, XmlNode bottom) { }

	// RVA: 0x116463C
	private static bool IsValidChild(XmlNode parent, XmlNode child) { }

	// RVA: 0x1164560
	private XmlNode TextEnd(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_Empty
{
	// Fields
	private XPathNavigator nav; // 0x18

	// Methods

	// RVA: 0x11666CC
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x1166C44
	internal void .ctor(DocumentXPathNodeIterator_Empty other) { }

	// RVA: 0x1166C98
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1166D2C
	public override bool MoveNext() { }

	// RVA: 0x1166D34
	public override XPathNavigator get_Current() { }

	// RVA: 0x1166D3C
	public override int get_CurrentPosition() { }

	// RVA: 0x1166D44
	public override int get_Count() { }

}

// Namespace: System.Xml
internal abstract class DocumentXPathNodeIterator_ElemDescendants
{
	// Fields
	private DocumentXPathNavigator nav; // 0x18
	private int level; // 0x20
	private int position; // 0x24

	// Methods

	// RVA: 0x1166D4C
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x1166E0C
	internal void .ctor(DocumentXPathNodeIterator_ElemDescendants other) { }

	// RVA: -1
	protected abstract bool Match(XmlNode node) { }

	// RVA: 0x1166ED4
	public override XPathNavigator get_Current() { }

	// RVA: 0x1166EDC
	public override int get_CurrentPosition() { }

	// RVA: 0x1166EE4
	protected void SetPosition(int pos) { }

	// RVA: 0x1166EEC
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_AllElemChildren
{
	// Methods

	// RVA: 0x116694C
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x1167074
	internal void .ctor(DocumentXPathNodeIterator_AllElemChildren other) { }

	// RVA: 0x1167078
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11670DC
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_AllElemChildren_AndSelf
{
	// Methods

	// RVA: 0x1166948
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x1167110
	internal void .ctor(DocumentXPathNodeIterator_AllElemChildren_AndSelf other) { }

	// RVA: 0x1167114
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1167178
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren_NoLocalName
{
	// Fields
	private string nsAtom; // 0x28

	// Methods

	// RVA: 0x116674C
	internal void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x116729C
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_NoLocalName other) { }

	// RVA: 0x11672D4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1167350
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName
{
	// Methods

	// RVA: 0x116671C
	internal void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x1167394
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName other) { }

	// RVA: 0x11673CC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1167448
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren
{
	// Fields
	protected string localNameAtom; // 0x28
	protected string nsAtom; // 0x30

	// Methods

	// RVA: 0x11667C8
	internal void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x116756C
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren other) { }

	// RVA: 0x11675B4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1167640
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf
{
	// Methods

	// RVA: 0x116677C
	internal void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x11676B4
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf other) { }

	// RVA: 0x11676FC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1167788
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DomNameTable
{
	// Fields
	private XmlName[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28

	// Methods

	// RVA: 0x11678AC
	public void .ctor(XmlDocument document) { }

	// RVA: 0x116795C
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1167AE0
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1167D6C
	private void Grow() { }

}

// Namespace: System.Xml
internal class XPathNodeList
{
	// Fields
	private System.Collections.Generic.List<System.Xml.XmlNode> list; // 0x10
	private XPathNodeIterator nodeIterator; // 0x18
	private bool done; // 0x20
	private static readonly object[] nullparams; // 0x0

	// Methods

	// RVA: 0x1167EF4
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1167FA4
	public override int get_Count() { }

	// RVA: 0x11680F8
	private XmlNode GetNode(XPathNavigator n) { }

	// RVA: 0x1168014
	internal int ReadUntil(int index) { }

	// RVA: 0x11681F8
	public override XmlNode Item(int index) { }

	// RVA: 0x11682C4
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1168388
	private static void .cctor() { }

}

// Namespace: System.Xml
internal class XmlNodeListEnumerator
{
	// Fields
	private XPathNodeList list; // 0x10
	private int index; // 0x18
	private bool valid; // 0x1C

	// Methods

	// RVA: 0x1168344
	public void .ctor(XPathNodeList list) { }

	// RVA: 0x1168408
	public void Reset() { }

	// RVA: 0x1168414
	public bool MoveNext() { }

	// RVA: 0x1168490
	public object get_Current() { }

}

// Namespace: System.Xml
public class XmlAttribute
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Methods

	// RVA: 0x11684D0
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0x11686F8
	internal int get_LocalNameHash() { }

	// RVA: 0x1168718
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x1168878
	internal XmlName get_XmlName() { }

	// RVA: 0x1168880
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x1168888
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1168954
	public override XmlNode get_ParentNode() { }

	// RVA: 0x116895C
	public override string get_Name() { }

	// RVA: 0x116897C
	public override string get_LocalName() { }

	// RVA: 0x116899C
	public override string get_NamespaceURI() { }

	// RVA: 0x11689BC
	public override string get_Prefix() { }

	// RVA: 0x11689DC
	public override void set_Prefix(string value) { }

	// RVA: 0x1168A88
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1168A90
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1168AB0
	public override string get_Value() { }

	// RVA: 0x1168AC0
	public override void set_Value(string value) { }

	// RVA: 0x1168AD0
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1168AD8
	public override void set_InnerText(string value) { }

	// RVA: 0x1168BA8
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0x1168C68
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x1168EB0
	internal override bool get_IsContainer() { }

	// RVA: 0x1168EB8
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11691AC
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x11691B4
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11691BC
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11691CC
	public virtual bool get_Specified() { }

	// RVA: 0x11691D4
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11692B4
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1169394
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1169468
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x116953C
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x1169610
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0x1169698
	public override void set_InnerXml(string value) { }

	// RVA: 0x1169728
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11697DC
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1169844
	public override string get_BaseURI() { }

	// RVA: 0x11698E0
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x11698E8
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0x116994C
	internal override string get_XmlLang() { }

	// RVA: 0x11699E8
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x1169A28
	internal override string get_XPLocalName() { }

	// RVA: 0x116246C
	internal bool get_IsNamespace() { }

}

// Namespace: System.Xml
public sealed class XmlAttributeCollection
{
	// Methods

	// RVA: 0x1169AD4
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x1162D68
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0x1169ADC
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0x1169C20
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0x1169D88
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0x1169F70
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x116A228
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0x116A57C
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0x116A624
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0x116A6EC
	public void RemoveAll() { }

	// RVA: 0x116A7CC
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x116A86C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x116A874
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x116A878
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x116A880
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0x116AA78
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0x116AB2C
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x116A358
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0x116A424
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x116ACD8
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x116A968
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0x1168CF0
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0x1168DF0
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0x116A17C
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

}

// Namespace: System.Xml
public class XmlCDataSection
{
	// Methods

	// RVA: 0x116B43C
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x116B4AC
	public override string get_Name() { }

	// RVA: 0x116B4D8
	public override string get_LocalName() { }

	// RVA: 0x116B504
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x116B50C
	public override XmlNode get_ParentNode() { }

	// RVA: 0x116B5A8
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x116B608
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x116B650
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x116B654
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x116B65C
	internal override bool get_IsText() { }

	// RVA: 0x116B664
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public abstract class XmlCharacterData
{
	// Fields
	private string data; // 0x20

	// Methods

	// RVA: 0x116B474
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x116B6B4
	public override string get_Value() { }

	// RVA: 0x116B6C4
	public override void set_Value(string value) { }

	// RVA: 0x116B6D4
	public override string get_InnerText() { }

	// RVA: 0x116B6E0
	public override void set_InnerText(string value) { }

	// RVA: 0x116B6EC
	public virtual string get_Data() { }

	// RVA: 0x116B758
	public virtual void set_Data(string value) { }

	// RVA: 0x116B81C
	internal bool CheckOnData(string data) { }

	// RVA: 0x116B85C
	internal bool DecideXPNodeTypeForTextNodes(XmlNode node, XPathNodeType xnt) { }

}

// Namespace: System.Xml
internal sealed class XmlChildEnumerator
{
	// Fields
	internal XmlNode container; // 0x10
	internal XmlNode child; // 0x18
	internal bool isFirst; // 0x20

	// Methods

	// RVA: 0x116B964
	internal void .ctor(XmlNode container) { }

	// RVA: 0x116B9D0
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x116BA78
	internal bool MoveNext() { }

	// RVA: 0x116BB20
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x116BB6C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x116BB70
	internal XmlNode get_Current() { }

}

// Namespace: System.Xml
internal class XmlChildNodes
{
	// Fields
	private XmlNode container; // 0x10

	// Methods

	// RVA: 0x116BBE8
	public void .ctor(XmlNode container) { }

	// RVA: 0x116BC1C
	public override XmlNode Item(int i) { }

	// RVA: 0x116BC8C
	public override int get_Count() { }

	// RVA: 0x116BCE4
	public override IEnumerator GetEnumerator() { }

}

// Namespace: System.Xml
public class XmlComment
{
	// Methods

	// RVA: 0x116BE00
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0x116BE38
	public override string get_Name() { }

	// RVA: 0x116BE64
	public override string get_LocalName() { }

	// RVA: 0x116BE90
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x116BE98
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x116BEF8
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x116BF40
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x116BF44
	internal override XPathNodeType get_XPNodeType() { }

}

// Namespace: System.Xml
public class XmlDeclaration
{
	// Fields
	private string version; // 0x20
	private string encoding; // 0x28
	private string standalone; // 0x30

	// Methods

	// RVA: 0x116BF4C
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x116C3EC
	public string get_Version() { }

	// RVA: 0x116C3F4
	internal void set_Version(string value) { }

	// RVA: 0x116C3FC
	public string get_Encoding() { }

	// RVA: 0x116C200
	public void set_Encoding(string value) { }

	// RVA: 0x116C404
	public string get_Standalone() { }

	// RVA: 0x116C27C
	public void set_Standalone(string value) { }

	// RVA: 0x116C40C
	public override string get_Value() { }

	// RVA: 0x116C41C
	public override void set_Value(string value) { }

	// RVA: 0x116C42C
	public override string get_InnerText() { }

	// RVA: 0x116C5A8
	public override void set_InnerText(string value) { }

	// RVA: 0x116C7E8
	public override string get_Name() { }

	// RVA: 0x116C82C
	public override string get_LocalName() { }

	// RVA: 0x116C838
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x116C840
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x116C888
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x116C8F4
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x116C17C
	private bool IsValidXmlVersion(string ver) { }

}

// Namespace: System.Xml
public class XmlDocument
{
	// Fields
	private XmlImplementation implementation; // 0x18
	private DomNameTable domNameTable; // 0x20
	private XmlLinkedNode lastChild; // 0x28
	private XmlNamedNodeMap entities; // 0x30
	private Hashtable htElementIdMap; // 0x38
	private Hashtable htElementIDAttrDecl; // 0x40
	private SchemaInfo schemaInfo; // 0x48
	private XmlSchemaSet schemas; // 0x50
	private bool reportValidity; // 0x58
	private bool actualLoadingStatus; // 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; // 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; // 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; // 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; // 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; // 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; // 0x88
	internal bool fEntRefNodesPresent; // 0x90
	internal bool fCDataNodesPresent; // 0x91
	private bool preserveWhitespace; // 0x92
	private bool isLoading; // 0x93
	internal string strDocumentName; // 0x98
	internal string strDocumentFragmentName; // 0xA0
	internal string strCommentName; // 0xA8
	internal string strTextName; // 0xB0
	internal string strCDataSectionName; // 0xB8
	internal string strEntityName; // 0xC0
	internal string strID; // 0xC8
	internal string strXmlns; // 0xD0
	internal string strXml; // 0xD8
	internal string strSpace; // 0xE0
	internal string strLang; // 0xE8
	internal string strEmpty; // 0xF0
	internal string strNonSignificantWhitespaceName; // 0xF8
	internal string strSignificantWhitespaceName; // 0x100
	internal string strReservedXmlns; // 0x108
	internal string strReservedXml; // 0x110
	internal string baseURI; // 0x118
	private XmlResolver resolver; // 0x120
	internal bool bSetResolver; // 0x128
	internal object objLock; // 0x130
	private XmlAttribute namespaceXml; // 0x138
	internal static EmptyEnumerator EmptyEnumerator; // 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; // 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; // 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; // 0x18

	// Methods

	// RVA: 0x116C8F8
	public void .ctor() { }

	// RVA: 0x116CE10
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x116C960
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x116CE80
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x116CE88
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0x11685F8
	internal static void CheckName(string name) { }

	// RVA: 0x116CE90
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x116CEAC
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1168758
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x116CEC8
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0x116CFA4
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0x116B0E8
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0x116D084
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0x116B0FC
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0x116B2F4
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0x116D6AC
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x116D81C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x116D824
	public override XmlNode get_ParentNode() { }

	// RVA: 0x116D82C
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0x116D8BC
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x116D97C
	public XmlImplementation get_Implementation() { }

	// RVA: 0x116D984
	public override string get_Name() { }

	// RVA: 0x116D98C
	public override string get_LocalName() { }

	// RVA: 0x1162990
	public XmlElement get_DocumentElement() { }

	// RVA: 0x116D994
	internal override bool get_IsContainer() { }

	// RVA: 0x116D99C
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x116D9A4
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x116D9AC
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x116D9B4
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x116D9BC
	internal bool get_CanReportValidity() { }

	// RVA: 0x116D9C4
	internal bool get_HasSetResolver() { }

	// RVA: 0x116D9CC
	internal XmlResolver GetResolver() { }

	// RVA: 0x116D9D4
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x116DB9C
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x116DCF8
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x116DDB8
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x116DE1C
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x116E034
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x116E1A8
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0x116E2B4
	internal void SetDefaultNamespace(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x116E358
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0x116E3DC
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0x116E458
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x116E4F0
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0x116E558
	public XmlElement CreateElement(string name) { }

	// RVA: 0x116E5F8
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0x116E8A4
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0x116E9D8
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x116EB38
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0x116EBA8
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x116EC28
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x116ECAC
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0x116ED1C
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0x116ED8C
	public override XPathNavigator CreateNavigator() { }

	// RVA: 0x116EDA0
	protected internal virtual XPathNavigator CreateNavigator(XmlNode node) { }

	// RVA: 0x116F158
	internal static bool IsTextNode(XmlNodeType nt) { }

	// RVA: 0x116EF8C
	private XmlNode NormalizeText(XmlNode n) { }

	// RVA: 0x116F170
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0x116F1E0
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0x116F284
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0x116F328
	public virtual XmlElement GetElementById(string elementId) { }

	// RVA: 0x116F6C8
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0x116FCAC
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0x116D76C
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0x1162258
	public XmlNameTable get_NameTable() { }

	// RVA: 0x116FE10
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x116FEA8
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x116FF30
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1170004
	public override bool get_IsReadOnly() { }

	// RVA: 0x117000C
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x11700AC
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0x11700B4
	internal bool get_IsLoading() { }

	// RVA: 0x11700BC
	internal void set_IsLoading(bool value) { }

	// RVA: 0x11700C4
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0x11700CC
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0x11701C0
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0x1170224
	public virtual void Load(XmlReader reader) { }

	// RVA: 0x1170348
	public virtual void LoadXml(string xml) { }

	// RVA: 0x11704C4
	public override void set_InnerText(string value) { }

	// RVA: 0x1170520
	public override void set_InnerXml(string value) { }

	// RVA: 0x1170530
	public virtual void Save(XmlWriter w) { }

	// RVA: 0x1170764
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1170774
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0x1170A3C
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x11690E4
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0x1170B38
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1170B8C
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x116AE30
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x1170BE0
	internal string get_Version() { }

	// RVA: 0x1170C08
	internal string get_Encoding() { }

	// RVA: 0x117073C
	internal string get_Standalone() { }

	// RVA: 0x1170C30
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0x1170D04
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1170EE4
	public override string get_BaseURI() { }

	// RVA: 0x1170EEC
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0x1170EFC
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11711A4
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x11711AC
	internal bool get_HasEntityReferences() { }

	// RVA: 0x1163628
	internal XmlAttribute get_NamespaceXml() { }

	// RVA: 0x11711B4
	private static void .cctor() { }

}

// Namespace: System.Xml
public class XmlDocumentFragment
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Methods

	// RVA: 0x11712D4
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x1171364
	public override string get_Name() { }

	// RVA: 0x1171390
	public override string get_LocalName() { }

	// RVA: 0x11713BC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11713C4
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11713CC
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1171448
	public override void set_InnerXml(string value) { }

	// RVA: 0x1171720
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11717A4
	internal override bool get_IsContainer() { }

	// RVA: 0x11717AC
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x11717B4
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11717BC
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1171838
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11718BC
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1171928
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1171938
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1171C9C
	internal override XPathNodeType get_XPNodeType() { }

}

// Namespace: System.Xml
public class XmlDocumentType
{
	// Fields
	private string name; // 0x20
	private string publicId; // 0x28
	private string systemId; // 0x30
	private string internalSubset; // 0x38
	private bool namespaces; // 0x40
	private XmlNamedNodeMap entities; // 0x48
	private XmlNamedNodeMap notations; // 0x50
	private SchemaInfo schemaInfo; // 0x58

	// Methods

	// RVA: 0x1171CA4
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x1171EAC
	public override string get_Name() { }

	// RVA: 0x1171EB4
	public override string get_LocalName() { }

	// RVA: 0x1171EBC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1171EC4
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1171F0C
	public override bool get_IsReadOnly() { }

	// RVA: 0x1171F14
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x1171FF4
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x11720A0
	public string get_PublicId() { }

	// RVA: 0x11720A8
	public string get_SystemId() { }

	// RVA: 0x11720B0
	public string get_InternalSubset() { }

	// RVA: 0x11720B8
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x11720C0
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11720F0
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11720F4
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x11720FC
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

}

// Namespace: System.Xml
internal class XmlDOMTextWriter
{
	// Methods

	// RVA: 0x1172104
	public void .ctor(TextWriter w) { }

	// RVA: 0x1172170
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1172208
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

}

// Namespace: System.Xml
public class XmlElement
{
	// Fields
	private XmlName name; // 0x20
	private XmlAttributeCollection attributes; // 0x28
	private XmlLinkedNode lastChild; // 0x30

	// Methods

	// RVA: 0x11722A0
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x1172410
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x1172458
	internal XmlName get_XmlName() { }

	// RVA: 0x1172460
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x1172468
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1172AF0
	public override string get_Name() { }

	// RVA: 0x1172D04
	public override string get_LocalName() { }

	// RVA: 0x1172D24
	public override string get_NamespaceURI() { }

	// RVA: 0x1172D44
	public override string get_Prefix() { }

	// RVA: 0x1172D64
	public override void set_Prefix(string value) { }

	// RVA: 0x1172E14
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1172E1C
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1172E24
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1172E44
	internal override bool get_IsContainer() { }

	// RVA: 0x1172E4C
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1172A14
	public bool get_IsEmpty() { }

	// RVA: 0x1172A24
	public void set_IsEmpty(bool value) { }

	// RVA: 0x11730A8
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x11730B8
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11730C0
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11730D8
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x117323C
	public virtual bool get_HasAttributes() { }

	// RVA: 0x1173268
	public virtual string GetAttribute(string name) { }

	// RVA: 0x11732F8
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x11733B4
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x117341C
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x1173538
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x11735D0
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x11736F8
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x1173774
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x117386C
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x1173894
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11739C8
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x1173C28
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0x1173D44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1173DAC
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x1173DF8
	public override void RemoveAll() { }

	// RVA: 0x1173034
	internal void RemoveAllChildren() { }

	// RVA: 0x1173EF0
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1173EF8
	public override void set_InnerXml(string value) { }

	// RVA: 0x11740B0
	public override string get_InnerText() { }

	// RVA: 0x11741CC
	public override void set_InnerText(string value) { }

	// RVA: 0x11742E4
	public override XmlNode get_NextSibling() { }

	// RVA: 0x1174334
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x117433C
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x1174344
	internal override string get_XPLocalName() { }

}

// Namespace: System.Xml
public class XmlEntity
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string notationName; // 0x28
	private string name; // 0x30
	private string unparsedReplacementStr; // 0x38
	private string baseURI; // 0x40
	private XmlLinkedNode lastChild; // 0x48
	private bool childrenFoliating; // 0x50

	// Methods

	// RVA: 0x1174354
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x11744AC
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1174508
	public override bool get_IsReadOnly() { }

	// RVA: 0x1174510
	public override string get_Name() { }

	// RVA: 0x1174518
	public override string get_LocalName() { }

	// RVA: 0x1174520
	public override string get_InnerText() { }

	// RVA: 0x1174524
	public override void set_InnerText(string value) { }

	// RVA: 0x1174580
	internal override bool get_IsContainer() { }

	// RVA: 0x1174588
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1174764
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x117476C
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1174784
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x117478C
	public string get_SystemId() { }

	// RVA: 0x1174794
	public override string get_OuterXml() { }

	// RVA: 0x11747E0
	public override void set_InnerXml(string value) { }

	// RVA: 0x117483C
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1174840
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1174844
	public override string get_BaseURI() { }

	// RVA: 0x117484C
	internal void SetBaseURI(string inBaseURI) { }

}

// Namespace: System.Xml
public class XmlEntityReference
{
	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Methods

	// RVA: 0x1174854
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x1174958
	public override string get_Name() { }

	// RVA: 0x1174960
	public override string get_LocalName() { }

	// RVA: 0x1174968
	public override string get_Value() { }

	// RVA: 0x1174970
	public override void set_Value(string value) { }

	// RVA: 0x11749CC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11749D4
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1174A18
	public override bool get_IsReadOnly() { }

	// RVA: 0x1174A20
	internal override bool get_IsContainer() { }

	// RVA: 0x1174A28
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x1175150
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x1175160
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1175168
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1175170
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1175188
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11751B8
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11754B4
	public override string get_BaseURI() { }

	// RVA: 0x11754E8
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x11755D0
	internal string get_ChildBaseURI() { }

}

// Namespace: System.Xml
public enum XmlNodeChangedAction
{
	// Fields
	public int value__; // 0x10
	public const XmlNodeChangedAction Insert = 0;
	public const XmlNodeChangedAction Remove = 1;
	public const XmlNodeChangedAction Change = 2;
}

// Namespace: System.Xml
public class XmlImplementation
{
	// Fields
	private XmlNameTable nameTable; // 0x10

	// Methods

	// RVA: 0x11756A8
	public void .ctor() { }

	// RVA: 0x1175804
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x1175838
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0x11758A0
	internal XmlNameTable get_NameTable() { }

}

// Namespace: System.Xml
public abstract class XmlLinkedNode
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Methods

	// RVA: 0x1171E0C
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x11758A8
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x1175920
	public override XmlNode get_NextSibling() { }

}

// Namespace: System.Xml
internal class XmlLoader
{
	// Fields
	private XmlDocument doc; // 0x10
	private XmlReader reader; // 0x18
	private bool preserveWhitespace; // 0x20

	// Methods

	// RVA: 0x11714D8
	public void .ctor() { }

	// RVA: 0x117597C
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x1175C08
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x11762D4
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x1175C8C
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x117642C
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x1176F24
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x11770F4
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x1176774
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x1176A7C
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x1176C28
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x117742C
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x1178B38
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x1171E38
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x1178E40
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x1177BF8
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x1179234
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x11714E0
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x1174028
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x117A0F4
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x1179E38
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x117A0FC
	private string EntitizeName(string name) { }

	// RVA: 0x11746B8
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x1174B70
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x1179B48
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x1177938
	internal static void ParseXmlDeclarationValue(string strValue, string version, string encoding, string standalone) { }

	// RVA: 0x1176E10
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }

}

// Namespace: System.Xml
internal class XmlName
{
	// Fields
	private string prefix; // 0x10
	private string localName; // 0x18
	private string ns; // 0x20
	private string name; // 0x28
	private int hashCode; // 0x30
	internal XmlDocument ownerDoc; // 0x38
	internal XmlName next; // 0x40

	// Methods

	// RVA: 0x117A178
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x117A2B8
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x117A7E8
	public string get_LocalName() { }

	// RVA: 0x117A7F0
	public string get_NamespaceURI() { }

	// RVA: 0x117A7F8
	public string get_Prefix() { }

	// RVA: 0x117A800
	public int get_HashCode() { }

	// RVA: 0x117A808
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x1172B0C
	public string get_Name() { }

	// RVA: 0x117A810
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x117A818
	public virtual bool get_IsDefault() { }

	// RVA: 0x117A820
	public virtual bool get_IsNil() { }

	// RVA: 0x117A828
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x117A830
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x117A838
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x117A840
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x117A848
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x117A854
	public static int GetHashCode(string name) { }

}

// Namespace: System.Xml
internal sealed class XmlNameEx
{
	// Fields
	private Byte flags; // 0x48
	private XmlSchemaSimpleType memberType; // 0x50
	private XmlSchemaType schemaType; // 0x58
	private object decl; // 0x60

	// Methods

	// RVA: 0x117A36C
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x117A920
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x117A958
	public override bool get_IsDefault() { }

	// RVA: 0x117A964
	public override bool get_IsNil() { }

	// RVA: 0x117A970
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x117A978
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x117A980
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x117AA08
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x117A8CC
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x117A8E0
	public void SetIsDefault(bool value) { }

	// RVA: 0x117A900
	public void SetIsNil(bool value) { }

	// RVA: 0x117AA90
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }

}

// Namespace: 
private class SingleObjectEnumerator
{
	// Fields
	private object loneValue; // 0x10
	private int position; // 0x18

	// Methods

	// RVA: 0x117BEB4
	public void .ctor(object value) { }

	// RVA: 0x117BEF0
	public object get_Current() { }

	// RVA: 0x117BF48
	public bool MoveNext() { }

	// RVA: 0x117BF60
	public void Reset() { }

}

// Namespace: 
internal struct SmallXmlNodeList
{
	// Fields
	private object field; // 0x10

	// Methods

	// RVA: 0x117B374
	public int get_Count() { }

	// RVA: 0x117AFA0
	public object get_Item(int index) { }

	// RVA: 0x117B6E8
	public void Add(object value) { }

	// RVA: 0x117BA4C
	public void RemoveAt(int index) { }

	// RVA: 0x117BD00
	public void Insert(int index, object value) { }

	// RVA: 0x117B40C
	public IEnumerator GetEnumerator() { }

}

// Namespace: System.Xml
public class XmlNamedNodeMap
{
	// Fields
	internal XmlNode parent; // 0x10
	internal SmallXmlNodeList nodes; // 0x18

	// Methods

	// RVA: 0x1171FC0
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x117ADFC
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x117B08C
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x117B2E4
	public virtual int get_Count() { }

	// RVA: 0x117B404
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x117AEB0
	internal int FindNodeOffset(string name) { }

	// RVA: 0x117B158
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x117B538
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x117B830
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x117B8DC
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x117B28C
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x117BB44
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

}

// Namespace: System.Xml
public abstract class XmlNode
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Methods

	// RVA: 0x117135C
	internal void .ctor() { }

	// RVA: 0x1174424
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x117BF6C
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: 0x117C014
	public XmlNodeList SelectNodes(string xpath) { }

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: 0x117C0C4
	public virtual string get_Value() { }

	// RVA: 0x117C0CC
	public virtual void set_Value(string value) { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x117C1A0
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x117C294
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x117C2FC
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x117C304
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x117C30C
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x117C314
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x117C3D0
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x117C3F8
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x117C408
	internal virtual bool get_IsContainer() { }

	// RVA: 0x117C410
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x117C418
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x117C41C
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x117C488
	internal bool IsConnected() { }

	// RVA: 0x117C4E8
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x117CB60
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x117D148
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x117D568
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x117D5B0
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x117DB04
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x117DCD4
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x117DCDC
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x117DCE4
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x117DCEC
	public virtual bool get_HasChildNodes() { }

	// RVA: -1
	public abstract XmlNode CloneNode(bool deep) { }

	// RVA: 0x117DD14
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x117DDB4
	public virtual string get_NamespaceURI() { }

	// RVA: 0x117DE00
	public virtual string get_Prefix() { }

	// RVA: 0x117DE4C
	public virtual void set_Prefix(string value) { }

	// RVA: -1
	public abstract string get_LocalName() { }

	// RVA: 0x117DE50
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x117DF58
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x117E064
	private object System.ICloneable.Clone() { }

	// RVA: 0x117E078
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1171C34
	public IEnumerator GetEnumerator() { }

	// RVA: 0x117E0E0
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x11740B4
	public virtual string get_InnerText() { }

	// RVA: 0x117E1E8
	public virtual void set_InnerText(string value) { }

	// RVA: 0x117E2CC
	public virtual string get_OuterXml() { }

	// RVA: 0x117E480
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x117E4DC
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x117E558
	public virtual string get_BaseURI() { }

	// RVA: -1
	public abstract void WriteTo(XmlWriter w) { }

	// RVA: -1
	public abstract void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1173E7C
	public virtual void RemoveAll() { }

	// RVA: 0x117E684
	internal XmlDocument get_Document() { }

	// RVA: 0x117E734
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x117E7C0
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x1174B1C
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x117EC2C
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x117EC34
	internal static void SplitName(string name, string prefix, string localName) { }

	// RVA: 0x117ED34
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x117EDA0
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x117EED0
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x117EF24
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x117EF78
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x117F10C
	internal virtual string get_XmlLang() { }

	// RVA: 0x117F214
	internal virtual XPathNodeType get_XPNodeType() { }

	// RVA: 0x117F21C
	internal virtual string get_XPLocalName() { }

	// RVA: 0x117F268
	internal virtual bool get_IsText() { }

	// RVA: 0x117F270
	public virtual XmlNode get_PreviousText() { }

	// RVA: 0x117300C
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x117CB20
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

}

// Namespace: System.Xml
public class XmlNodeChangedEventArgs
{
	// Fields
	private XmlNodeChangedAction action; // 0x10
	private XmlNode node; // 0x18
	private XmlNode oldParent; // 0x20
	private XmlNode newParent; // 0x28
	private string oldValue; // 0x30
	private string newValue; // 0x38

	// Methods

	// RVA: 0x117F278
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x117F360
	public XmlNodeChangedAction get_Action() { }

}

// Namespace: System.Xml
public sealed class XmlNodeChangedEventHandler
{
	// Methods

	// RVA: 0x117F368
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x117F48C
	public virtual void Invoke(object sender, XmlNodeChangedEventArgs e) { }

}

// Namespace: System.Xml
public abstract class XmlNodeList
{
	// Methods

	// RVA: -1
	public abstract XmlNode Item(int index) { }

	// RVA: -1
	public abstract int get_Count() { }

	// RVA: -1
	public abstract IEnumerator GetEnumerator() { }

	// RVA: 0x117F4A0
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0x117F4AC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x117F4B8
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x117F4BC
	protected void .ctor() { }

}

// Namespace: 
internal struct VirtualAttribute
{
	// Fields
	internal string name; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x117F864
	internal void .ctor(string name, string value) { }

}

// Namespace: System.Xml
internal class XmlNodeReaderNavigator
{
	// Fields
	private XmlNode curNode; // 0x10
	private XmlNode elemNode; // 0x18
	private XmlNode logNode; // 0x20
	private int attrIndex; // 0x28
	private int logAttrIndex; // 0x2C
	private XmlNameTable nameTable; // 0x30
	private XmlDocument doc; // 0x38
	private int nAttrInd; // 0x40
	private int nDeclarationAttrCount; // 0x44
	private int nDocTypeAttrCount; // 0x48
	private int nLogLevel; // 0x4C
	private int nLogAttrInd; // 0x50
	private bool bLogOnAttrVal; // 0x54
	private bool bCreatedOnAttribute; // 0x55
	internal VirtualAttribute[] decNodeAttributes; // 0x58
	internal VirtualAttribute[] docTypeNodeAttributes; // 0x60
	private bool bOnAttrVal; // 0x68

	// Methods

	// RVA: 0x117F4C4
	public void .ctor(XmlNode node) { }

	// RVA: 0x117F898
	public XmlNodeType get_NodeType() { }

	// RVA: 0x117F8E8
	public string get_NamespaceURI() { }

	// RVA: 0x117F910
	public string get_Name() { }

	// RVA: 0x117FA3C
	public string get_LocalName() { }

	// RVA: 0x117FB00
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0x117FA1C
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0x117FB08
	public string get_Prefix() { }

	// RVA: 0x117FB30
	public string get_Value() { }

	// RVA: 0x117FFE8
	public string get_BaseURI() { }

	// RVA: 0x1180010
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x1180038
	public string get_XmlLang() { }

	// RVA: 0x1180060
	public bool get_IsEmptyElement() { }

	// RVA: 0x1180118
	public bool get_IsDefault() { }

	// RVA: 0x11801D4
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11801FC
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1180204
	public int get_AttributeCount() { }

	// RVA: 0x11804A8
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0x117FE14
	private void InitDecAttr() { }

	// RVA: 0x118051C
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0x1180600
	public string GetDeclarationAttr(int i) { }

	// RVA: 0x1180658
	public int GetDecAttrInd(string name) { }

	// RVA: 0x1180364
	private void InitDocTypeAttr() { }

	// RVA: 0x1180700
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0x11807B0
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0x1180808
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0x11808B0
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0x11808F8
	public string GetAttribute(string name) { }

	// RVA: 0x1180B74
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x1180BC0
	public string GetAttribute(string name, string ns) { }

	// RVA: 0x1180E5C
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0x11810B8
	public void LogMove(int level) { }

	// RVA: 0x1181100
	public void RollBackMove(int level) { }

	// RVA: 0x1181150
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0x1181184
	public void ResetToAttribute(int level) { }

	// RVA: 0x118126C
	public void ResetMove(int level, XmlNodeType nt) { }

	// RVA: 0x1181460
	public bool MoveToAttribute(string name) { }

	// RVA: 0x118170C
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x11814C4
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0x1181808
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x1181A6C
	public bool MoveToNextAttribute(int level) { }

	// RVA: 0x1181CBC
	public bool MoveToParent() { }

	// RVA: 0x1181D40
	public bool MoveToFirstChild() { }

	// RVA: 0x1181DCC
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0x1181E5C
	public bool MoveToNext() { }

	// RVA: 0x1181EE4
	public bool MoveToElement() { }

	// RVA: 0x1181F8C
	public string LookupNamespace(string prefix) { }

	// RVA: 0x1182294
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0x11823CC
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x11827A0
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1182CA0
	public bool ReadAttributeValue(int level, bool bResolveEntity, XmlNodeType nt) { }

	// RVA: 0x1182F28
	public XmlDocument get_Document() { }

}

// Namespace: System.Xml
public class XmlNodeReader
{
	// Fields
	private XmlNodeReaderNavigator readerNav; // 0x10
	private XmlNodeType nodeType; // 0x18
	private int curDepth; // 0x1C
	private ReadState readState; // 0x20
	private bool fEOF; // 0x24
	private bool bResolveEntity; // 0x25
	private bool bStartFromDocument; // 0x26
	private bool bInReadBinary; // 0x27
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x28

	// Methods

	// RVA: 0x1182F30
	public void .ctor(XmlNode node) { }

	// RVA: 0x1183044
	internal bool IsInReadingStates() { }

	// RVA: 0x1183054
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1183070
	public override string get_Name() { }

	// RVA: 0x11830E4
	public override string get_LocalName() { }

	// RVA: 0x11831EC
	public override string get_NamespaceURI() { }

	// RVA: 0x1183274
	public override string get_Prefix() { }

	// RVA: 0x11832FC
	public override string get_Value() { }

	// RVA: 0x1183370
	public override int get_Depth() { }

	// RVA: 0x1183378
	public override string get_BaseURI() { }

	// RVA: 0x11833A8
	public override bool get_CanResolveEntity() { }

	// RVA: 0x11833B0
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1183478
	public override bool get_IsDefault() { }

	// RVA: 0x11834AC
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x11834F4
	public override string get_XmlLang() { }

	// RVA: 0x118357C
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11835C4
	public override int get_AttributeCount() { }

	// RVA: 0x1183604
	public override string GetAttribute(string name) { }

	// RVA: 0x1183638
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x11836D0
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x1183748
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11838F8
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x1183B20
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1183C74
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1183DDC
	public override bool MoveToElement() { }

	// RVA: 0x1183F8C
	public override bool Read() { }

	// RVA: 0x1183F94
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x1184168
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x1184734
	private void SetEndOfFile() { }

	// RVA: 0x118474C
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x1184580
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x1184558
	private void ReSetReadingMarks() { }

	// RVA: 0x1184874
	public override bool get_EOF() { }

	// RVA: 0x1184898
	public override void Close() { }

	// RVA: 0x11848A4
	public override ReadState get_ReadState() { }

	// RVA: 0x11848AC
	public override void Skip() { }

	// RVA: 0x11848B4
	public override string ReadString() { }

	// RVA: 0x118495C
	public override bool get_HasAttributes() { }

	// RVA: 0x1184984
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x11849A4
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11849E8
	public override void ResolveEntity() { }

	// RVA: 0x1184A70
	public override bool ReadAttributeValue() { }

	// RVA: 0x11838D4
	private void FinishReadBinary() { }

	// RVA: 0x1184AD0
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1184AEC
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1184B08
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1184B7C
	internal override IDtdInfo get_DtdInfo() { }

}

// Namespace: System.Xml
public class XmlNotation
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string name; // 0x28

	// Methods

	// RVA: 0x117919C
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x1184BA4
	public override string get_Name() { }

	// RVA: 0x1184BAC
	public override string get_LocalName() { }

	// RVA: 0x1184BB4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1184BBC
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1184C18
	public override bool get_IsReadOnly() { }

	// RVA: 0x1184C20
	public override string get_OuterXml() { }

	// RVA: 0x1184C6C
	public override void set_InnerXml(string value) { }

	// RVA: 0x1184CC8
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1184CCC
	public override void WriteContentTo(XmlWriter w) { }

}

// Namespace: System.Xml
public class XmlProcessingInstruction
{
	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Methods

	// RVA: 0x1178DD8
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0x1184CD0
	public override string get_Name() { }

	// RVA: 0x1184D3C
	public override string get_LocalName() { }

	// RVA: 0x1184D48
	public override string get_Value() { }

	// RVA: 0x1184D50
	public override void set_Value(string value) { }

	// RVA: 0x1184E14
	public void set_Data(string value) { }

	// RVA: 0x1184ED8
	public override string get_InnerText() { }

	// RVA: 0x1184EE0
	public override void set_InnerText(string value) { }

	// RVA: 0x1184FA4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1184FAC
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1184FF0
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1185020
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1185024
	internal override string get_XPLocalName() { }

	// RVA: 0x1185030
	internal override XPathNodeType get_XPNodeType() { }

}

// Namespace: System.Xml
public class XmlSignificantWhitespace
{
	// Methods

	// RVA: 0x1178C88
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1185038
	public override string get_Name() { }

	// RVA: 0x1185064
	public override string get_LocalName() { }

	// RVA: 0x1185090
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1185098
	public override XmlNode get_ParentNode() { }

	// RVA: 0x118513C
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x118519C
	public override string get_Value() { }

	// RVA: 0x11851AC
	public override void set_Value(string value) { }

	// RVA: 0x118523C
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1185284
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1185288
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x11852BC
	internal override bool get_IsText() { }

	// RVA: 0x11852C4
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public class XmlText
{
	// Methods

	// RVA: 0x1177420
	internal void .ctor(string strData) { }

	// RVA: 0x1177418
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1185314
	public override string get_Name() { }

	// RVA: 0x1185340
	public override string get_LocalName() { }

	// RVA: 0x118536C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1185374
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1185410
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1185470
	public override string get_Value() { }

	// RVA: 0x1185480
	public override void set_Value(string value) { }

	// RVA: 0x1185560
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11855A8
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11855AC
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x11855B4
	internal override bool get_IsText() { }

	// RVA: 0x11855BC
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal class XmlUnspecifiedAttribute
{
	// Fields
	private bool fSpecified; // 0x28

	// Methods

	// RVA: 0x1178E38
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x118560C
	public override bool get_Specified() { }

	// RVA: 0x1185614
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1185748
	public override void set_InnerText(string value) { }

	// RVA: 0x1185774
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11857A0
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11857CC
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x11857F8
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x1185824
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1185838
	internal void SetSpecified(bool f) { }

}

// Namespace: System.Xml
public class XmlWhitespace
{
	// Methods

	// RVA: 0x1178D30
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1185840
	public override string get_Name() { }

	// RVA: 0x118586C
	public override string get_LocalName() { }

	// RVA: 0x1185898
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11858A0
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1185944
	public override string get_Value() { }

	// RVA: 0x1185954
	public override void set_Value(string value) { }

	// RVA: 0x11859E4
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1185A44
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1185A8C
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1185A90
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x1185AC4
	internal override bool get_IsText() { }

	// RVA: 0x1185ACC
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal sealed class EmptyEnumerator
{
	// Methods

	// RVA: 0x1185B1C
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1185B24
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1185B28
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1185B84
	public void .ctor() { }

}

// Namespace: System.Xml
internal class HWStack
{
	// Fields
	private object[] stack; // 0x10
	private int growthRate; // 0x18
	private int used; // 0x1C
	private int size; // 0x20
	private int limit; // 0x24

	// Methods

	// RVA: 0x1185B8C
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x1185C10
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x1185C9C
	internal object Push() { }

	// RVA: 0x1185DE8
	internal object Pop() { }

	// RVA: 0x1185E38
	internal object Peek() { }

	// RVA: 0x1185E84
	internal void AddToTop(object o) { }

	// RVA: 0x1185F10
	internal object get_Item(int index) { }

	// RVA: 0x1185F90
	internal void set_Item(int index, object value) { }

	// RVA: 0x1186048
	internal int get_Length() { }

	// RVA: 0x1186050
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x11860AC
	public object Clone() { }

}

// Namespace: System.Xml
public interface IHasXmlNode
{
	// Methods

	// RVA: -1
	public abstract XmlNode GetNode() { }

}

// Namespace: System.Xml
public interface IXmlLineInfo
{
	// Methods

	// RVA: -1
	public abstract bool HasLineInfo() { }

	// RVA: -1
	public abstract int get_LineNumber() { }

	// RVA: -1
	public abstract int get_LinePosition() { }

}

// Namespace: System.Xml
internal class PositionInfo
{
	// Methods

	// RVA: 0x118619C
	public virtual bool HasLineInfo() { }

	// RVA: 0x11861A4
	public virtual int get_LineNumber() { }

	// RVA: 0x11861AC
	public virtual int get_LinePosition() { }

	// RVA: 0x11861B4
	public static PositionInfo GetPositionInfo(object o) { }

	// RVA: 0x11862C0
	public void .ctor() { }

}

// Namespace: System.Xml
internal class ReaderPositionInfo
{
	// Fields
	private IXmlLineInfo lineInfo; // 0x10

	// Methods

	// RVA: 0x118628C
	public void .ctor(IXmlLineInfo lineInfo) { }

	// RVA: 0x11862C8
	public override bool HasLineInfo() { }

	// RVA: 0x118637C
	public override int get_LineNumber() { }

	// RVA: 0x1186434
	public override int get_LinePosition() { }

}

// Namespace: System.Xml
public interface IXmlNamespaceResolver
{
	// Methods

	// RVA: -1
	public abstract System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: -1
	public abstract string LookupNamespace(string prefix) { }

	// RVA: -1
	public abstract string LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal struct LineInfo
{
	// Fields
	internal int lineNo; // 0x10
	internal int linePos; // 0x14

	// Methods

	// RVA: 0x11864EC
	public void .ctor(int lineNo, int linePos) { }

	// RVA: 0x11864F4
	public void Set(int lineNo, int linePos) { }

}

// Namespace: 
private class Entry
{
	// Fields
	internal string str; // 0x10
	internal int hashCode; // 0x18
	internal Entry next; // 0x20

	// Methods

	// RVA: 0x1186C50
	internal void .ctor(string str, int hashCode, Entry next) { }

}

// Namespace: System.Xml
public class NameTable
{
	// Fields
	private Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0x117577C
	public void .ctor() { }

	// RVA: 0x11864FC
	public override string Add(string key) { }

	// RVA: 0x11867B4
	public override string Add(Char[] key, int start, int len) { }

	// RVA: 0x1186AD0
	public override string Get(string value) { }

	// RVA: 0x1186680
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x1186CA8
	private void Grow() { }

	// RVA: 0x11869F4
	private static bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}

// Namespace: System.Xml
internal static class Ref
{
	// Methods

	// RVA: 0x117A16C
	public static bool Equal(string strA, string strB) { }

}

// Namespace: 
private enum Token
{
	// Fields
	public int value__; // 0x10
	public const Token CDATA = 0;
	public const Token ID = 1;
	public const Token IDREF = 2;
	public const Token IDREFS = 3;
	public const Token ENTITY = 4;
	public const Token ENTITIES = 5;
	public const Token NMTOKEN = 6;
	public const Token NMTOKENS = 7;
	public const Token NOTATION = 8;
	public const Token None = 9;
	public const Token PERef = 10;
	public const Token AttlistDecl = 11;
	public const Token ElementDecl = 12;
	public const Token EntityDecl = 13;
	public const Token NotationDecl = 14;
	public const Token Comment = 15;
	public const Token PI = 16;
	public const Token CondSectionStart = 17;
	public const Token CondSectionEnd = 18;
	public const Token Eof = 19;
	public const Token REQUIRED = 20;
	public const Token IMPLIED = 21;
	public const Token FIXED = 22;
	public const Token QName = 23;
	public const Token Name = 24;
	public const Token Nmtoken = 25;
	public const Token Quote = 26;
	public const Token LeftParen = 27;
	public const Token RightParen = 28;
	public const Token GreaterThan = 29;
	public const Token Or = 30;
	public const Token LeftBracket = 31;
	public const Token RightBracket = 32;
	public const Token PUBLIC = 33;
	public const Token SYSTEM = 34;
	public const Token Literal = 35;
	public const Token DOCTYPE = 36;
	public const Token NData = 37;
	public const Token Percent = 38;
	public const Token Star = 39;
	public const Token QMark = 40;
	public const Token Plus = 41;
	public const Token PCDATA = 42;
	public const Token Comma = 43;
	public const Token ANY = 44;
	public const Token EMPTY = 45;
	public const Token IGNORE = 46;
	public const Token INCLUDE = 47;
}

// Namespace: 
private enum ScanningFunction
{
	// Fields
	public int value__; // 0x10
	public const ScanningFunction SubsetContent = 0;
	public const ScanningFunction Name = 1;
	public const ScanningFunction QName = 2;
	public const ScanningFunction Nmtoken = 3;
	public const ScanningFunction Doctype1 = 4;
	public const ScanningFunction Doctype2 = 5;
	public const ScanningFunction Element1 = 6;
	public const ScanningFunction Element2 = 7;
	public const ScanningFunction Element3 = 8;
	public const ScanningFunction Element4 = 9;
	public const ScanningFunction Element5 = 10;
	public const ScanningFunction Element6 = 11;
	public const ScanningFunction Element7 = 12;
	public const ScanningFunction Attlist1 = 13;
	public const ScanningFunction Attlist2 = 14;
	public const ScanningFunction Attlist3 = 15;
	public const ScanningFunction Attlist4 = 16;
	public const ScanningFunction Attlist5 = 17;
	public const ScanningFunction Attlist6 = 18;
	public const ScanningFunction Attlist7 = 19;
	public const ScanningFunction Entity1 = 20;
	public const ScanningFunction Entity2 = 21;
	public const ScanningFunction Entity3 = 22;
	public const ScanningFunction Notation1 = 23;
	public const ScanningFunction CondSection1 = 24;
	public const ScanningFunction CondSection2 = 25;
	public const ScanningFunction CondSection3 = 26;
	public const ScanningFunction Literal = 27;
	public const ScanningFunction SystemId = 28;
	public const ScanningFunction PublicId1 = 29;
	public const ScanningFunction PublicId2 = 30;
	public const ScanningFunction ClosingTag = 31;
	public const ScanningFunction ParamEntitySpace = 32;
	public const ScanningFunction None = 33;
}

// Namespace: 
private enum LiteralType
{
	// Fields
	public int value__; // 0x10
	public const LiteralType AttributeValue = 0;
	public const LiteralType EntityReplText = 1;
	public const LiteralType SystemOrPublicID = 2;
}

// Namespace: 
private class UndeclaredNotation
{
	// Fields
	internal string name; // 0x10
	internal int lineNo; // 0x18
	internal int linePos; // 0x1C
	internal UndeclaredNotation next; // 0x20

	// Methods

	// RVA: 0x1194160
	internal void .ctor(string name, int lineNo, int linePos) { }

}

// Namespace: 
private class ParseElementOnlyContent_LocalFrame
{
	// Fields
	public int startParenEntityId; // 0x10
	public Token parsingSchema; // 0x14

	// Methods

	// RVA: 0x11941B8
	public void .ctor(int startParentEntityIdParam) { }

}

// Namespace: System.Xml
internal class DtdParser
{
	// Fields
	private IDtdParserAdapter readerAdapter; // 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaInfo schemaInfo; // 0x28
	private XmlCharType xmlCharType; // 0x30
	private string systemId; // 0x38
	private string publicId; // 0x40
	private bool normalize; // 0x48
	private bool validate; // 0x49
	private bool supportNamespaces; // 0x4A
	private bool v1Compat; // 0x4B
	private Char[] chars; // 0x50
	private int charsUsed; // 0x58
	private int curPos; // 0x5C
	private ScanningFunction scanningFunction; // 0x60
	private ScanningFunction nextScaningFunction; // 0x64
	private ScanningFunction savedScanningFunction; // 0x68
	private bool whitespaceSeen; // 0x6C
	private int tokenStartPos; // 0x70
	private int colonPos; // 0x74
	private StringBuilder internalSubsetValueSb; // 0x78
	private int externalEntitiesDepth; // 0x80
	private int currentEntityId; // 0x84
	private bool freeFloatingDtd; // 0x88
	private bool hasFreeFloatingInternalSubset; // 0x89
	private StringBuilder stringBuilder; // 0x90
	private int condSectionDepth; // 0x98
	private LineInfo literalLineInfo; // 0x9C
	private Char literalQuoteChar; // 0xA4
	private string documentBaseUri; // 0xA8
	private string externalDtdBaseUri; // 0xB0
	private System.Collections.Generic.Dictionary<System.String,System.Xml.DtdParser.UndeclaredNotation> undeclaredNotations; // 0xB8
	private int[] condSectionEntityIds; // 0xC0

	// Methods

	// RVA: 0x1186E30
	private void .ctor() { }

	// RVA: 0x1179148
	internal static IDtdParser Create() { }

	// RVA: 0x1186F18
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x1187354
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x1187888
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x1187DC0
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x1187DF0
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x1187E00
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x1187E10
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x1187EE8
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0x1187F18
	private bool get_SupportNamespaces() { }

	// RVA: 0x1187F20
	private bool get_Normalize() { }

	// RVA: 0x11878BC
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x1187F8C
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x1187F28
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x1189C1C
	private void ParseInternalSubset() { }

	// RVA: 0x1189C20
	private void ParseExternalSubset() { }

	// RVA: 0x1189E08
	private void ParseSubset() { }

	// RVA: 0x118A308
	private void ParseAttlistDecl() { }

	// RVA: 0x118C6B8
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x118CF7C
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x118AA28
	private void ParseElementDecl() { }

	// RVA: 0x118DB24
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x118DF5C
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x118D7EC
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x118AE64
	private void ParseEntityDecl() { }

	// RVA: 0x118B2EC
	private void ParseNotationDecl() { }

	// RVA: 0x118D418
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x118B6B4
	private void ParseComment() { }

	// RVA: 0x118B9B0
	private void ParsePI() { }

	// RVA: 0x118BC6C
	private void ParseCondSection() { }

	// RVA: 0x11893F8
	private void ParseExternalId(Token idTokenType, Token declType, string publicId, string systemId) { }

	// RVA: 0x1188630
	private Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x118E9AC
	private Token ScanSubsetContent() { }

	// RVA: 0x118E920
	private Token ScanNameExpected() { }

	// RVA: 0x118E950
	private Token ScanQNameExpected() { }

	// RVA: 0x118E980
	private Token ScanNmtokenExpected() { }

	// RVA: 0x118F234
	private Token ScanDoctype1() { }

	// RVA: 0x118F46C
	private Token ScanDoctype2() { }

	// RVA: 0x11920F0
	private Token ScanClosingTag() { }

	// RVA: 0x118F584
	private Token ScanElement1() { }

	// RVA: 0x118F870
	private Token ScanElement2() { }

	// RVA: 0x118FAA0
	private Token ScanElement3() { }

	// RVA: 0x118FB3C
	private Token ScanElement4() { }

	// RVA: 0x118FC7C
	private Token ScanElement5() { }

	// RVA: 0x118FDF8
	private Token ScanElement6() { }

	// RVA: 0x118FEDC
	private Token ScanElement7() { }

	// RVA: 0x118FF44
	private Token ScanAttlist1() { }

	// RVA: 0x1190014
	private Token ScanAttlist2() { }

	// RVA: 0x1190868
	private Token ScanAttlist3() { }

	// RVA: 0x1190914
	private Token ScanAttlist4() { }

	// RVA: 0x11909F8
	private Token ScanAttlist5() { }

	// RVA: 0x1190ADC
	private Token ScanAttlist6() { }

	// RVA: 0x1190F68
	private Token ScanAttlist7() { }

	// RVA: 0x11927E8
	private Token ScanLiteral(LiteralType literalType) { }

	// RVA: 0x119357C
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x1191030
	private Token ScanNotation1() { }

	// RVA: 0x119121C
	private Token ScanSystemId() { }

	// RVA: 0x1191410
	private Token ScanEntity1() { }

	// RVA: 0x1191498
	private Token ScanEntity2() { }

	// RVA: 0x11916C8
	private Token ScanEntity3() { }

	// RVA: 0x11912D4
	private Token ScanPublicId1() { }

	// RVA: 0x119138C
	private Token ScanPublicId2() { }

	// RVA: 0x11917E0
	private Token ScanCondSection1() { }

	// RVA: 0x1191B60
	private Token ScanCondSection2() { }

	// RVA: 0x1191BFC
	private Token ScanCondSection3() { }

	// RVA: 0x119245C
	private void ScanName() { }

	// RVA: 0x1192464
	private void ScanQName() { }

	// RVA: 0x1193940
	private void ScanQName(bool isQName) { }

	// RVA: 0x1193BD0
	private bool ReadDataInName() { }

	// RVA: 0x119246C
	private void ScanNmtoken() { }

	// RVA: 0x11925E8
	private bool EatPublicKeyword() { }

	// RVA: 0x11926E8
	private bool EatSystemKeyword() { }

	// RVA: 0x1189268
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x118D3FC
	private string GetNameString() { }

	// RVA: 0x118D6F0
	private string GetNmtokenString() { }

	// RVA: 0x118D780
	private string GetValue() { }

	// RVA: 0x118D70C
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x1192188
	private int ReadData() { }

	// RVA: 0x1188484
	private void LoadParsingBuffer() { }

	// RVA: 0x1189C14
	private void SaveParsingBuffer() { }

	// RVA: 0x118C148
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x118E7F8
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x1193E38
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x1192250
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x11936E8
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x118BF30
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x118D208
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x1188330
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x118D1FC
	private bool IsAttributeValueType(Token token) { }

	// RVA: 0x118C364
	private int get_LineNo() { }

	// RVA: 0x118C41C
	private int get_LinePos() { }

	// RVA: 0x11881F8
	private string get_BaseUriStr() { }

	// RVA: 0x11891CC
	private void OnUnexpectedError() { }

	// RVA: 0x118BBF8
	private void Throw(int curPos, string res) { }

	// RVA: 0x118DFE4
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x118E468
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x118C4D0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x1187808
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x118E774
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	// RVA: 0x118C35C
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x118E2F0
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x118E84C
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x1193C18
	internal static string StripSpaces(string value) { }

}

// Namespace: System.Xml
public enum XmlTokenizedType
{
	// Fields
	public int value__; // 0x10
	public const XmlTokenizedType CDATA = 0;
	public const XmlTokenizedType ID = 1;
	public const XmlTokenizedType IDREF = 2;
	public const XmlTokenizedType IDREFS = 3;
	public const XmlTokenizedType ENTITY = 4;
	public const XmlTokenizedType ENTITIES = 5;
	public const XmlTokenizedType NMTOKEN = 6;
	public const XmlTokenizedType NMTOKENS = 7;
	public const XmlTokenizedType NOTATION = 8;
	public const XmlTokenizedType ENUMERATION = 9;
	public const XmlTokenizedType QName = 10;
	public const XmlTokenizedType NCName = 11;
	public const XmlTokenizedType None = 12;
}

// Namespace: System.Xml
internal static class ValidateNames
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0

	// Methods

	// RVA: 0x11941E8
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0x11942BC
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0x11943AC
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0x1194514
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0x11945CC
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0x1194704
	internal static int ParseNCName(string s) { }

	// RVA: 0x119478C
	internal static int ParseQName(string s, int offset, int colonOffset) { }

	// RVA: 0x11948AC
	internal static void ParseQNameThrow(string s, string prefix, string localName) { }

	// RVA: 0x1194A2C
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x1194F28
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x11951EC
	internal static void SplitQName(string name, string prefix, string lname) { }

	// RVA: 0x11955F8
	private static void .cctor() { }

}

// Namespace: System.Xml
internal struct XmlCharType
{
	// Fields
	private static object s_Lock; // 0x0
	private static Byte[] s_CharProperties; // 0x8
	internal Byte[] charProperties; // 0x10

	// Methods

	// RVA: 0x11956C8
	private static object get_StaticLock() { }

	// RVA: 0x119577C
	private static void InitInstance() { }

	// RVA: 0x1195A94
	private static void SetProperties(Byte[] chProps, string ranges, Byte value) { }

	// RVA: 0x1195C20
	private void .ctor(Byte[] charProperties) { }

	// RVA: 0x1194D60
	public static XmlCharType get_Instance() { }

	// RVA: 0x1195C28
	public bool IsWhiteSpace(Char ch) { }

	// RVA: 0x1194D28
	public bool IsNCNameSingleChar(Char ch) { }

	// RVA: 0x1194DE4
	public bool IsStartNCNameSingleChar(Char ch) { }

	// RVA: 0x1195C60
	public bool IsNameSingleChar(Char ch) { }

	// RVA: 0x1195CA0
	public bool IsCharData(Char ch) { }

	// RVA: 0x1195CD8
	public bool IsPubidChar(Char ch) { }

	// RVA: 0x1195D58
	internal bool IsTextChar(Char ch) { }

	// RVA: 0x1195D90
	public bool IsLetter(Char ch) { }

	// RVA: 0x1195DC8
	public bool IsNCNameCharXml4e(Char ch) { }

	// RVA: 0x1195E00
	public bool IsStartNCNameCharXml4e(Char ch) { }

	// RVA: 0x1195E40
	public bool IsNameCharXml4e(Char ch) { }

	// RVA: 0x1195E80
	public static bool IsDigit(Char ch) { }

	// RVA: 0x1195EA4
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0x1195EB4
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0x1195EC4
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0x1195ED4
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0x1195EEC
	internal static void SplitSurrogateChar(int combinedChar, Char lowChar, Char highChar) { }

	// RVA: 0x1195F24
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x1195FC0
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x119604C
	internal int IsOnlyCharData(string str) { }

	// RVA: 0x1196150
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x119620C
	internal int IsPublicId(string str) { }

	// RVA: 0x1195E90
	private static bool InRange(int value, int start, int end) { }

}

// Namespace: System.Xml
internal static class XmlComplianceUtil
{
	// Methods

	// RVA: 0x11962C8
	public static string NonCDataNormalize(string value) { }

	// RVA: 0x11965F4
	public static string CDataNormalize(string value) { }

}

// Namespace: System.Xml
internal enum ExceptionType
{
	// Fields
	public int value__; // 0x10
	public const ExceptionType ArgumentException = 0;
	public const ExceptionType XmlException = 1;
}

// Namespace: System.Xml
public enum XmlDateTimeSerializationMode
{
	// Fields
	public int value__; // 0x10
	public const XmlDateTimeSerializationMode Local = 0;
	public const XmlDateTimeSerializationMode Utc = 1;
	public const XmlDateTimeSerializationMode Unspecified = 2;
	public const XmlDateTimeSerializationMode RoundtripKind = 3;
}

// Namespace: System.Xml
public class XmlConvert
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0
	internal static Char[] crt; // 0x8
	private static readonly int c_EncodedCharLength; // 0x10
	private static Regex c_EncodeCharPattern; // 0x18
	private static Regex c_DecodeCharPattern; // 0x20
	private static string[] s_allDateTimeFormats; // 0x28
	internal static readonly Char[] WhitespaceChars; // 0x30

	// Methods

	// RVA: 0x11967E0
	public static string EncodeName(string name) { }

	// RVA: 0x11972F0
	public static string EncodeLocalName(string name) { }

	// RVA: 0x1197358
	public static string DecodeName(string name) { }

	// RVA: 0x1196848
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0x1197D90
	private static int FromHex(Char digit) { }

	// RVA: 0x1197DB8
	internal static Byte[] FromBinHexString(string s) { }

	// RVA: 0x1197E40
	internal static Byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0x1197EB8
	internal static string ToBinHexString(Byte[] inArray) { }

	// RVA: 0x1197F28
	public static string VerifyName(string name) { }

	// RVA: 0x11981B8
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0x11983E4
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0x1198660
	public static string VerifyNCName(string name) { }

	// RVA: 0x11986E8
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0x1198858
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0x1198978
	public static string VerifyTOKEN(string token) { }

	// RVA: 0x1198AA8
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0x1198BE4
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0x1198DE4
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0x1198ED8
	public static string ToString(bool value) { }

	// RVA: 0x1198F44
	public static string ToString(Char value) { }

	// RVA: 0x1198FB0
	public static string ToString(Decimal value) { }

	// RVA: 0x1199058
	public static string ToString(SByte value) { }

	// RVA: 0x1199090
	public static string ToString(Int16 value) { }

	// RVA: 0x11990C8
	public static string ToString(int value) { }

	// RVA: 0x1199100
	public static string ToString(Int64 value) { }

	// RVA: 0x1199138
	public static string ToString(Byte value) { }

	// RVA: 0x1199170
	public static string ToString(UInt16 value) { }

	// RVA: 0x11991A8
	public static string ToString(UInt32 value) { }

	// RVA: 0x11991E0
	public static string ToString(UInt64 value) { }

	// RVA: 0x1199218
	public static string ToString(float value) { }

	// RVA: 0x1199464
	public static string ToString(Double value) { }

	// RVA: 0x1199610
	public static string ToString(TimeSpan value) { }

	// RVA: 0x1199660
	public static string ToString(DateTime value, string format) { }

	// RVA: 0x119973C
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x1199B9C
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x1199C28
	public static string ToString(Guid value) { }

	// RVA: 0x1199C50
	public static bool ToBoolean(string s) { }

	// RVA: 0x1199F3C
	internal static Exception TryToBoolean(string s, bool result) { }

	// RVA: 0x119A200
	public static Char ToChar(string s) { }

	// RVA: 0x119A2C0
	internal static Exception TryToChar(string s, Char result) { }

	// RVA: 0x119A47C
	public static Decimal ToDecimal(string s) { }

	// RVA: 0x119A4F4
	internal static Exception TryToDecimal(string s, Decimal result) { }

	// RVA: 0x119A68C
	internal static Decimal ToInteger(string s) { }

	// RVA: 0x119A704
	internal static Exception TryToInteger(string s, Decimal result) { }

	// RVA: 0x119A89C
	public static SByte ToSByte(string s) { }

	// RVA: 0x119A8D0
	internal static Exception TryToSByte(string s, SByte result) { }

	// RVA: 0x119AA40
	public static Int16 ToInt16(string s) { }

	// RVA: 0x119AA74
	internal static Exception TryToInt16(string s, Int16 result) { }

	// RVA: 0x119ABE4
	public static int ToInt32(string s) { }

	// RVA: 0x119AC18
	internal static Exception TryToInt32(string s, int result) { }

	// RVA: 0x119AD88
	public static Int64 ToInt64(string s) { }

	// RVA: 0x119ADBC
	internal static Exception TryToInt64(string s, Int64 result) { }

	// RVA: 0x119AF2C
	public static Byte ToByte(string s) { }

	// RVA: 0x119AF60
	internal static Exception TryToByte(string s, Byte result) { }

	// RVA: 0x119B0D0
	public static UInt16 ToUInt16(string s) { }

	// RVA: 0x119B104
	internal static Exception TryToUInt16(string s, UInt16 result) { }

	// RVA: 0x119B274
	public static UInt32 ToUInt32(string s) { }

	// RVA: 0x119B2A8
	internal static Exception TryToUInt32(string s, UInt32 result) { }

	// RVA: 0x119B418
	public static UInt64 ToUInt64(string s) { }

	// RVA: 0x119B44C
	internal static Exception TryToUInt64(string s, UInt64 result) { }

	// RVA: 0x119B5BC
	public static float ToSingle(string s) { }

	// RVA: 0x119B778
	internal static Exception TryToSingle(string s, float result) { }

	// RVA: 0x119BA4C
	public static Double ToDouble(string s) { }

	// RVA: 0x119BBDC
	internal static Exception TryToDouble(string s, Double result) { }

	// RVA: 0x119BEB0
	internal static Double ToXPathDouble(object o) { }

	// RVA: 0x119C1C8
	internal static Double XPathRound(Double value) { }

	// RVA: 0x119C2D0
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0x119C46C
	internal static Exception TryToTimeSpan(string s, TimeSpan result) { }

	// RVA: 0x119C530
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0x119C60C
	private static void CreateAllDateTimeFormats() { }

	// RVA: 0x119CBD0
	public static DateTime ToDateTime(string s) { }

	// RVA: 0x119CCE0
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0x119CDB4
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x119D018
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0x119D0E4
	public static Guid ToGuid(string s) { }

	// RVA: 0x119D114
	internal static Exception TryToGuid(string s, Guid result) { }

	// RVA: 0x1199984
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x1199A90
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x119D2EC
	internal static Uri ToUri(string s) { }

	// RVA: 0x119D524
	internal static Exception TryToUri(string s, Uri result) { }

	// RVA: 0x119D7CC
	internal static bool StrEqual(Char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0x1199EB4
	internal static string TrimString(string value) { }

	// RVA: 0x119D8A8
	internal static string TrimStringStart(string value) { }

	// RVA: 0x119D930
	internal static string TrimStringEnd(string value) { }

	// RVA: 0x119D9B8
	internal static string[] SplitString(string value) { }

	// RVA: 0x11993C8
	internal static bool IsNegativeZero(Double value) { }

	// RVA: 0x119DA44
	private static Int64 DoubleToInt64Bits(Double value) { }

	// RVA: 0x119DA4C
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0x119DC58
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x119E0C4
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x119E214
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0x1198524
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x119E338
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi) { }

	// RVA: 0x119E404
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType) { }

	// RVA: 0x119DD44
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x119E484
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi) { }

	// RVA: 0x119E548
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType) { }

	// RVA: 0x119E5B8
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x119DED4
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0x119E6C0
	internal static Exception CreateInvalidCharException(Char invChar, Char nextChar) { }

	// RVA: 0x119E72C
	internal static Exception CreateInvalidCharException(Char invChar, Char nextChar, ExceptionType exceptionType) { }

	// RVA: 0x1198090
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0x119E824
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0x119E8F0
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Uri uri; // 0x10

	// Methods

	// RVA: 0x119F604
	public void .ctor() { }

	// RVA: 0x119F798
	internal Stream <GetStreamAsync>b__0() { }

}

// Namespace: 
private struct <GetNonFileStreamAsync>d__5
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder; // 0x18
	public Uri uri; // 0x30
	public ICredentials credentials; // 0x38
	public IWebProxy proxy; // 0x40
	public RequestCachePolicy cachePolicy; // 0x48
	public XmlDownloadManager <>4__this; // 0x50
	private WebRequest <req>5__2; // 0x58
	private ConfiguredTaskAwaiter <>u__1; // 0x60

	// Methods

	// RVA: 0x119F824
	private void MoveNext() { }

	// RVA: 0x11A00DC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Xml
internal class XmlDownloadManager
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x119EA74
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x119EB74
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x119F2F4
	internal void Remove(string host) { }

	// RVA: 0x119F484
	internal System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x119F60C
	private System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x119F790
	public void .ctor() { }

}

// Namespace: System.Xml
internal class OpenedHost
{
	// Fields
	internal int nonCachedConnectionsCount; // 0x10

	// Methods

	// RVA: 0x119F0C8
	public void .ctor() { }

}

// Namespace: System.Xml
internal class XmlRegisteredNonCachedStream
{
	// Fields
	protected Stream stream; // 0x28
	private XmlDownloadManager downloadManager; // 0x30
	private string host; // 0x38

	// Methods

	// RVA: 0x119F0D0
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0x11A015C
	protected override void Finalize() { }

	// RVA: 0x11A020C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x11A0358
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x11A0380
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x11A03A8
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x11A03D0
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x11A03F8
	public override void Flush() { }

	// RVA: 0x11A0420
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x11A0448
	public override int ReadByte() { }

	// RVA: 0x11A0470
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x11A0498
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x11A04C0
	public override void WriteByte(Byte value) { }

	// RVA: 0x11A04E8
	public override bool get_CanRead() { }

	// RVA: 0x11A050C
	public override bool get_CanSeek() { }

	// RVA: 0x11A0530
	public override bool get_CanWrite() { }

	// RVA: 0x11A0554
	public override Int64 get_Length() { }

	// RVA: 0x11A0578
	public override Int64 get_Position() { }

	// RVA: 0x11A059C
	public override void set_Position(Int64 value) { }

}

// Namespace: System.Xml
internal class XmlCachedStream
{
	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0x119F178
	internal void .ctor(Uri uri, Stream stream) { }

}

// Namespace: System.Xml
internal class UTF16Decoder
{
	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0x11A05C4
	public void .ctor(bool bigEndian) { }

	// RVA: 0x11A05F8
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x11A0608
	public override int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x11A06F8
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11A0888
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

}

// Namespace: System.Xml
internal class SafeAsciiDecoder
{
	// Methods

	// RVA: 0x11A0A7C
	public void .ctor() { }

	// RVA: 0x11A0A84
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x11A0A8C
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11A0B0C
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

}

// Namespace: System.Xml
internal class Ucs4Encoding
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Methods

	// RVA: 0x11A0BA8
	public override string get_WebName() { }

	// RVA: 0x11A0BB4
	public override Decoder GetDecoder() { }

	// RVA: 0x11A0BBC
	public override int GetByteCount(Char[] chars, int index, int count) { }

	// RVA: 0x11A0C24
	public override Byte[] GetBytes(string s) { }

	// RVA: 0x11A0C2C
	public override int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	// RVA: 0x11A0C34
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x11A0C3C
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x11A0C60
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11A0C84
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x11A0C9C
	public override int get_CodePage() { }

	// RVA: 0x11A0CA4
	public override Encoder GetEncoder() { }

	// RVA: 0x11A0CAC
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0x11A0DC0
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0x11A0ED4
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0x11A0FE8
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0x11A10FC
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding1234
{
	// Methods

	// RVA: 0x11A0E14
	public void .ctor() { }

	// RVA: 0x11A1174
	public override string get_EncodingName() { }

	// RVA: 0x11A11B8
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding4321
{
	// Methods

	// RVA: 0x11A0D00
	public void .ctor() { }

	// RVA: 0x11A12A4
	public override string get_EncodingName() { }

	// RVA: 0x11A12E8
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding2143
{
	// Methods

	// RVA: 0x11A0F28
	public void .ctor() { }

	// RVA: 0x11A13D0
	public override string get_EncodingName() { }

	// RVA: 0x11A1414
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding3412
{
	// Methods

	// RVA: 0x11A103C
	public void .ctor() { }

	// RVA: 0x11A1500
	public override string get_EncodingName() { }

	// RVA: 0x11A1544
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal abstract class Ucs4Decoder
{
	// Fields
	internal Byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0x11A15BC
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: -1
	internal abstract int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11A15D8
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11A17E0
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

	// RVA: 0x11A1B0C
	internal void Ucs4ToUTF16(UInt32 code, Char[] chars, int charIndex) { }

	// RVA: 0x11A1B68
	protected void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder4321
{
	// Methods

	// RVA: 0x11A1BD8
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11A1234
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder1234
{
	// Methods

	// RVA: 0x11A1E90
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11A1104
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder2143
{
	// Methods

	// RVA: 0x11A2148
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11A1360
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder3412
{
	// Methods

	// RVA: 0x11A2400
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11A1490
	public void .ctor() { }

}

// Namespace: System.Xml
[Serializable]
public class XmlException
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private int lineNumber; // 0xA0
	private int linePosition; // 0xA4
	private string sourceUri; // 0xA8
	private string message; // 0xB0

	// Methods

	// RVA: 0x11A26B8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11A2D94
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11A2F08
	public void .ctor() { }

	// RVA: 0x11A2F20
	public void .ctor(string message) { }

	// RVA: 0x11A2F3C
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x11A2F34
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11A2F4C
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1194E94
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x1194C30
	internal void .ctor(string res, string arg) { }

	// RVA: 0x11A3240
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x11A333C
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x11A35A8
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x11A33E4
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x119DFBC
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x11A35B0
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x119E294
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11A36BC
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11A3764
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11A318C
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11A308C
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x11A2B18
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x1194E1C
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x11A380C
	internal static string[] BuildCharExceptionArgs(Char[] data, int length, int invCharIndex) { }

	// RVA: 0x1195368
	internal static string[] BuildCharExceptionArgs(Char invChar, Char nextChar) { }

	// RVA: 0x11A3868
	public int get_LineNumber() { }

	// RVA: 0x11A3870
	public int get_LinePosition() { }

	// RVA: 0x11A3878
	public override string get_Message() { }

	// RVA: 0x11A3890
	internal string get_ResString() { }

}

// Namespace: System.Xml
public abstract class XmlNameTable
{
	// Methods

	// RVA: -1
	public abstract string Get(string array) { }

	// RVA: -1
	public abstract string Add(Char[] array, int offset, int length) { }

	// RVA: -1
	public abstract string Add(string array) { }

	// RVA: 0x11A3898
	protected void .ctor() { }

}

// Namespace: System.Xml
public enum XmlNamespaceScope
{
	// Fields
	public int value__; // 0x10
	public const XmlNamespaceScope All = 0;
	public const XmlNamespaceScope ExcludeXml = 1;
	public const XmlNamespaceScope Local = 2;
}

// Namespace: 
private struct NamespaceDeclaration
{
	// Fields
	public string prefix; // 0x10
	public string uri; // 0x18
	public int scopeId; // 0x20
	public int previousNsIndex; // 0x24

	// Methods

	// RVA: 0x11A3B1C
	public void Set(string prefix, string uri, int scopeId, int previousNsIndex) { }

}

// Namespace: System.Xml
public class XmlNamespaceManager
{
	// Fields
	private NamespaceDeclaration[] nsdecls; // 0x10
	private int lastDecl; // 0x18
	private XmlNameTable nameTable; // 0x20
	private int scopeId; // 0x28
	private System.Collections.Generic.Dictionary<System.String,System.Int32> hashTable; // 0x30
	private bool useHashtable; // 0x38
	private string xml; // 0x40
	private string xmlNs; // 0x48

	// Methods

	// RVA: 0x11A38A0
	internal void .ctor() { }

	// RVA: 0x11A38A8
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x11A3B68
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x11A3B70
	public virtual string get_DefaultNamespace() { }

	// RVA: 0x11A3BFC
	public virtual void PushScope() { }

	// RVA: 0x11A3C0C
	public virtual bool PopScope() { }

	// RVA: 0x11A3D08
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x11A42E0
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x11A442C
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11A45F0
	public virtual System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11A48D8
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x11A4100
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x11A4938
	public virtual string LookupPrefix(string uri) { }

}

// Namespace: System.Xml
public enum XmlNodeOrder
{
	// Fields
	public int value__; // 0x10
	public const XmlNodeOrder Before = 0;
	public const XmlNodeOrder After = 1;
	public const XmlNodeOrder Same = 2;
	public const XmlNodeOrder Unknown = 3;
}

// Namespace: System.Xml
public enum XmlNodeType
{
	// Fields
	public int value__; // 0x10
	public const XmlNodeType None = 0;
	public const XmlNodeType Element = 1;
	public const XmlNodeType Attribute = 2;
	public const XmlNodeType Text = 3;
	public const XmlNodeType CDATA = 4;
	public const XmlNodeType EntityReference = 5;
	public const XmlNodeType Entity = 6;
	public const XmlNodeType ProcessingInstruction = 7;
	public const XmlNodeType Comment = 8;
	public const XmlNodeType Document = 9;
	public const XmlNodeType DocumentType = 10;
	public const XmlNodeType DocumentFragment = 11;
	public const XmlNodeType Notation = 12;
	public const XmlNodeType Whitespace = 13;
	public const XmlNodeType SignificantWhitespace = 14;
	public const XmlNodeType EndElement = 15;
	public const XmlNodeType EndEntity = 16;
	public const XmlNodeType XmlDeclaration = 17;
}

// Namespace: 
private sealed class HashCodeOfStringDelegate
{
	// Methods

	// RVA: 0x11A5400
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11A5A6C
	public virtual int Invoke(string s, int sLen, Int64 additionalEntropy) { }

}

// Namespace: System.Xml
[Serializable]
public class XmlQualifiedName
{
	// Fields
	private static HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private string name; // 0x10
	private string ns; // 0x18
	private int hash; // 0x20
	public static readonly XmlQualifiedName Empty; // 0x8

	// Methods

	// RVA: 0x11A4A28
	public void .ctor() { }

	// RVA: 0x11A4BE8
	public void .ctor(string name) { }

	// RVA: 0x11A4B28
	public void .ctor(string name, string ns) { }

	// RVA: 0x11A4CE8
	public string get_Namespace() { }

	// RVA: 0x11A4CF0
	public string get_Name() { }

	// RVA: 0x11A4CF8
	public override int GetHashCode() { }

	// RVA: 0x11A504C
	public bool get_IsEmpty() { }

	// RVA: 0x11A5090
	public override string ToString() { }

	// RVA: 0x11A5104
	public override bool Equals(object other) { }

	// RVA: 0x11A5314
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x11A523C
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x11A5378
	public static string ToString(string name, string ns) { }

	// RVA: 0x11A4E04
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x11A53F8
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0x11A54BC
	private static int GetHashCodeOfString(string s, int length, Int64 additionalEntropy) { }

	// RVA: 0x11A54DC
	internal void Init(string name, string ns) { }

	// RVA: 0x11A5518
	internal void SetNamespace(string ns) { }

	// RVA: 0x11A5520
	internal void Verify() { }

	// RVA: 0x11A5644
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0x11A56BC
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, string prefix) { }

	// RVA: 0x11A5940
	internal XmlQualifiedName Clone() { }

	// RVA: 0x11A59C4
	private static void .cctor() { }

}

// Namespace: System.Xml
public abstract class XmlResolver
{
	// Methods

	// RVA: -1
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x11A5A80
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x11A5C7C
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0x11A5DF8
	public virtual System.Threading.Tasks.Task<System.Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x11A5E38
	protected void .ctor() { }

}

// Namespace: 
private struct <GetEntityAsync>d__15
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Object> <>t__builder; // 0x18
	public Type ofObjectToReturn; // 0x30
	public Uri absoluteUri; // 0x38
	public XmlUrlResolver <>4__this; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x11A6224
	private void MoveNext() { }

	// RVA: 0x11A6640
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Xml
public class XmlUrlResolver
{
	// Fields
	private static object s_DownloadManager; // 0x0
	private ICredentials _credentials; // 0x10
	private IWebProxy _proxy; // 0x18
	private RequestCachePolicy _cachePolicy; // 0x20

	// Methods

	// RVA: 0x11A5E40
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x11A5F18
	public void .ctor() { }

	// RVA: 0x11A5F20
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x11A60C8
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x11A60CC
	public override System.Threading.Tasks.Task<System.Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

}

// Namespace: System.Xml
internal static class BinaryCompatibility
{
	// Methods

	// RVA: 0x11A66C0
	public static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

}

// Namespace: System.Xml
internal static class Res
{
	// Methods

	// RVA: 0x119808C
	public static string GetString(string name) { }

	// RVA: 0x11955E8
	public static string GetString(string name, object[] args) { }

}

// Namespace: System.Xml.XPath
public interface IXPathNavigable
{
	// Methods

	// RVA: -1
	public abstract XPathNavigator CreateNavigator() { }

}

// Namespace: System.Xml.XPath
public class XPathDocument
{
	// Fields
	private XPathNode[] pageText; // 0x10
	private XPathNode[] pageRoot; // 0x18
	private XPathNode[] pageXmlNmsp; // 0x20
	private int idxText; // 0x28
	private int idxRoot; // 0x2C
	private int idxXmlNmsp; // 0x30
	private XmlNameTable nameTable; // 0x38
	private bool hasLineInfo; // 0x40
	private System.Collections.Generic.Dictionary<MS.Internal.Xml.Cache.XPathNodeRef,MS.Internal.Xml.Cache.XPathNodeRef> mapNmsp; // 0x48
	private System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.Cache.XPathNodeRef> idValueMap; // 0x50

	// Methods

	// RVA: 0x11A66C8
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x11A66D0
	internal bool get_HasLineInfo() { }

	// RVA: 0x11A66D8
	internal int GetCollapsedTextNode(XPathNode[] pageText) { }

	// RVA: 0x11A670C
	internal int GetRootNode(XPathNode[] pageRoot) { }

	// RVA: 0x11A6740
	internal int GetXmlNamespaceNode(XPathNode[] pageXmlNmsp) { }

	// RVA: 0x11A6774
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x11A6894
	internal int LookupIdElement(string id, XPathNode[] pageElem) { }

}

// Namespace: System.Xml.XPath
[Serializable]
public class XPathException
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string message; // 0xA0

	// Methods

	// RVA: 0x11A697C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11A6D8C
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11A6E80
	public void .ctor() { }

	// RVA: 0x11A6EE0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x11A7048
	internal static XPathException Create(string res) { }

	// RVA: 0x11A7164
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0x11A7258
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0x11A7378
	internal static XPathException Create(string res, string arg, Exception innerException) { }

	// RVA: 0x11A70F0
	private void .ctor(string res, string[] args) { }

	// RVA: 0x11A6FD0
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0x11A6C48
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0x11A7478
	public override string get_Message() { }

}

// Namespace: System.Xml.XPath
public enum XPathResultType
{
	// Fields
	public int value__; // 0x10
	public const XPathResultType Number = 0;
	public const XPathResultType String = 1;
	public const XPathResultType Boolean = 2;
	public const XPathResultType NodeSet = 3;
	public const XPathResultType Navigator = 1;
	public const XPathResultType Any = 5;
	public const XPathResultType Error = 6;
}

// Namespace: System.Xml.XPath
public abstract class XPathExpression
{
	// Methods

	// RVA: 0x11A7490
	internal void .ctor() { }

	// RVA: -1
	public abstract void SetContext(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11A7498
	public static XPathExpression Compile(string xpath) { }

	// RVA: 0x11A74A0
	public static XPathExpression Compile(string xpath, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.XPath
public abstract class XPathItem
{
	// Methods

	// RVA: -1
	public abstract XmlSchemaType get_XmlType() { }

	// RVA: -1
	public abstract string get_Value() { }

	// RVA: -1
	public abstract object get_TypedValue() { }

	// RVA: -1
	public abstract Type get_ValueType() { }

	// RVA: -1
	public abstract bool get_ValueAsBoolean() { }

	// RVA: -1
	public abstract DateTime get_ValueAsDateTime() { }

	// RVA: -1
	public abstract Double get_ValueAsDouble() { }

	// RVA: -1
	public abstract int get_ValueAsInt() { }

	// RVA: -1
	public abstract Int64 get_ValueAsLong() { }

	// RVA: 0x11A7590
	public virtual object ValueAs(Type returnType) { }

	// RVA: -1
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11A75A4
	protected void .ctor() { }

}

// Namespace: System.Xml.XPath
public enum XPathNamespaceScope
{
	// Fields
	public int value__; // 0x10
	public const XPathNamespaceScope All = 0;
	public const XPathNamespaceScope ExcludeXml = 1;
	public const XPathNamespaceScope Local = 2;
}

// Namespace: System.Xml.XPath
public abstract class XPathNavigator
{
	// Fields
	internal static readonly XPathNavigatorKeyComparer comparer; // 0x0
	internal static readonly Char[] NodeTypeLetter; // 0x8
	internal static readonly Char[] UniqueIdTbl; // 0x10
	internal static readonly int[] ContentKindMasks; // 0x18

	// Methods

	// RVA: 0x11A75AC
	public override string ToString() { }

	// RVA: 0x11A75B8
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x11A7778
	public override object get_TypedValue() { }

	// RVA: 0x11A7A80
	public override Type get_ValueType() { }

	// RVA: 0x11A7CBC
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x11A7FAC
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x11A82A4
	public override Double get_ValueAsDouble() { }

	// RVA: 0x11A859C
	public override int get_ValueAsInt() { }

	// RVA: 0x11A8894
	public override Int64 get_ValueAsLong() { }

	// RVA: 0x11A8B8C
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11A8E94
	private object System.ICloneable.Clone() { }

	// RVA: 0x11A8EA4
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: 0x11A8EB4
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x11A909C
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0x11A92E0
	public virtual System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: -1
	public abstract XPathNavigator Clone() { }

	// RVA: -1
	public abstract XPathNodeType get_NodeType() { }

	// RVA: -1
	public abstract string get_LocalName() { }

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: -1
	public abstract string get_NamespaceURI() { }

	// RVA: -1
	public abstract string get_Prefix() { }

	// RVA: -1
	public abstract string get_BaseURI() { }

	// RVA: 0x11A9614
	public virtual string get_XmlLang() { }

	// RVA: 0x11A9704
	public virtual object get_UnderlyingObject() { }

	// RVA: 0x11A970C
	public virtual bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: -1
	public abstract bool MoveToFirstAttribute() { }

	// RVA: -1
	public abstract bool MoveToNextAttribute() { }

	// RVA: 0x11A97F0
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: -1
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x11A989C
	public bool MoveToFirstNamespace() { }

	// RVA: 0x11A98B0
	public bool MoveToNextNamespace() { }

	// RVA: -1
	public abstract bool MoveToNext() { }

	// RVA: -1
	public abstract bool MoveToFirstChild() { }

	// RVA: -1
	public abstract bool MoveToParent() { }

	// RVA: 0x11A98C4
	public virtual void MoveToRoot() { }

	// RVA: -1
	public abstract bool MoveTo(XPathNavigator other) { }

	// RVA: -1
	public abstract bool MoveToId(string id) { }

	// RVA: 0x11A98F8
	public virtual bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x11A99F8
	public virtual bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x11A9BF0
	public virtual bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x11A9EDC
	public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x11AA184
	public virtual bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x11AA290
	public virtual bool MoveToNext(XPathNodeType type) { }

	// RVA: -1
	public abstract bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x11AA3F8
	public virtual bool IsDescendant(XPathNavigator nav) { }

	// RVA: 0x11AA498
	public virtual XmlNodeOrder ComparePosition(XPathNavigator nav) { }

	// RVA: 0x11AA99C
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11AA9F0
	public virtual XPathNodeIterator Select(string xpath) { }

	// RVA: 0x11AAA2C
	public virtual XPathNodeIterator Select(XPathExpression expr) { }

	// RVA: 0x11AAAF0
	public virtual object Evaluate(XPathExpression expr) { }

	// RVA: 0x11AAB04
	public virtual object Evaluate(XPathExpression expr, XPathNodeIterator context) { }

	// RVA: 0x11AACEC
	public virtual XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x11AAD74
	public virtual XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x11AAE0C
	public virtual XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x11AAEA4
	public virtual XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x11A9DC8
	internal bool MoveToNonDescendant() { }

	// RVA: 0x11AA7D8
	private static int GetDepth(XPathNavigator nav) { }

	// RVA: 0x11AA820
	private XmlNodeOrder CompareSiblings(XPathNavigator n1, XPathNavigator n2) { }

	// RVA: 0x11A9B50
	internal static int GetContentKindMask(XPathNodeType type) { }

	// RVA: 0x11AAF44
	internal static int GetKindMask(XPathNodeType type) { }

	// RVA: 0x11AAF68
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x11AAF78
	protected void .ctor() { }

	// RVA: 0x11AAF80
	private static void .cctor() { }

}

// Namespace: System.Xml.XPath
internal class XPathNavigatorKeyComparer
{
	// Methods

	// RVA: 0x11AB114
	private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0x11AB200
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x11AB10C
	public void .ctor() { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	private XPathNodeIterator original; // 0x10
	private XPathNodeIterator current; // 0x18
	private bool iterationStarted; // 0x20

	// Methods

	// RVA: 0x11AB4EC
	public void .ctor(XPathNodeIterator original) { }

	// RVA: 0x11AB548
	public virtual object get_Current() { }

	// RVA: 0x11AB68C
	public virtual bool MoveNext() { }

	// RVA: 0x11AB72C
	public virtual void Reset() { }

}

// Namespace: System.Xml.XPath
public abstract class XPathNodeIterator
{
	// Fields
	internal int count; // 0x10

	// Methods

	// RVA: 0x11AB3DC
	private object System.ICloneable.Clone() { }

	// RVA: -1
	public abstract XPathNodeIterator Clone() { }

	// RVA: -1
	public abstract bool MoveNext() { }

	// RVA: -1
	public abstract XPathNavigator get_Current() { }

	// RVA: -1
	public abstract int get_CurrentPosition() { }

	// RVA: 0x11AB3E8
	public virtual int get_Count() { }

	// RVA: 0x11AB460
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11AB538
	protected void .ctor() { }

}

// Namespace: System.Xml.XPath
public enum XPathNodeType
{
	// Fields
	public int value__; // 0x10
	public const XPathNodeType Root = 0;
	public const XPathNodeType Element = 1;
	public const XPathNodeType Attribute = 2;
	public const XPathNodeType Namespace = 3;
	public const XPathNodeType Text = 4;
	public const XPathNodeType SignificantWhitespace = 5;
	public const XPathNodeType Whitespace = 6;
	public const XPathNodeType ProcessingInstruction = 7;
	public const XPathNodeType Comment = 8;
	public const XPathNodeType All = 9;
}

// Namespace: System.Xml.Serialization
public class CodeIdentifier
{
	// Fields
	internal static CodeDomProvider csharp; // 0x0

	// Methods

	// RVA: 0x11AB734
	public static string MakePascal(string identifier) { }

	// RVA: 0x11AB948
	public static string MakeValid(string identifier) { }

	// RVA: 0x11ABBE0
	private static bool IsValidStart(Char c) { }

	// RVA: 0x11ABB60
	private static bool IsValid(Char c) { }

	// RVA: 0x11ABC50
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlSerializerNamespaces
{
	// Fields
	private Hashtable namespaces; // 0x10

	// Methods

	// RVA: 0x11ABCD8
	public void .ctor() { }

	// RVA: 0x11ABCE0
	public void Add(string prefix, string ns) { }

	// RVA: 0x11ABE58
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0x11ABF80
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0x11AC5A0
	public int get_Count() { }

	// RVA: 0x11AC088
	internal ArrayList get_NamespaceList() { }

	// RVA: 0x11ABEF8
	internal Hashtable get_Namespaces() { }

	// RVA: 0x11AC628
	internal void set_Namespaces(Hashtable value) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlAttributeEventHandler
{
	// Methods

	// RVA: 0x11AC630
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11AC754
	public virtual void Invoke(object sender, XmlAttributeEventArgs e) { }

}

// Namespace: System.Xml.Serialization
public class XmlAttributeEventArgs
{
	// Fields
	private object o; // 0x10
	private XmlAttribute attr; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x11AC768
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlElementEventHandler
{
	// Methods

	// RVA: 0x11AC828
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11AC94C
	public virtual void Invoke(object sender, XmlElementEventArgs e) { }

}

// Namespace: System.Xml.Serialization
public class XmlElementEventArgs
{
	// Fields
	private object o; // 0x10
	private XmlElement elem; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x11AC960
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlNodeEventHandler
{
	// Methods

	// RVA: 0x11ACA20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11ACB44
	public virtual void Invoke(object sender, XmlNodeEventArgs e) { }

}

// Namespace: System.Xml.Serialization
public class XmlNodeEventArgs
{
	// Fields
	private object o; // 0x10
	private XmlNode xmlNode; // 0x18
	private int lineNumber; // 0x20
	private int linePosition; // 0x24

	// Methods

	// RVA: 0x11ACB58
	internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

// Namespace: System.Xml.Serialization
public sealed class UnreferencedObjectEventHandler
{
	// Methods

	// RVA: 0x11ACC04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11ACD28
	public virtual void Invoke(object sender, UnreferencedObjectEventArgs e) { }

}

// Namespace: System.Xml.Serialization
public class UnreferencedObjectEventArgs
{
	// Fields
	private object o; // 0x10
	private string id; // 0x18

	// Methods

	// RVA: 0x11ACD3C
	public void .ctor(object o, string id) { }

}

// Namespace: System.Xml.Serialization
public interface IXmlSerializable
{
	// Methods

	// RVA: -1
	public abstract XmlSchema GetSchema() { }

	// RVA: -1
	public abstract void ReadXml(XmlReader reader) { }

	// RVA: -1
	public abstract void WriteXml(XmlWriter writer) { }

}

// Namespace: System.Xml.Serialization
public interface IXmlTextParser
{
	// Methods

	// RVA: -1
	public abstract bool get_Normalized() { }

	// RVA: -1
	public abstract void set_Normalized(bool value) { }

}

// Namespace: System.Xml.Serialization
internal class KeyHelper
{
	// Methods

	// RVA: 0x11ACDD0
	public static void AddField(StringBuilder sb, int n, string val) { }

	// RVA: 0x11ACDD8
	public static void AddField(StringBuilder sb, int n, string val, string def) { }

	// RVA: 0x11ACEC4
	public static void AddField(StringBuilder sb, int n, bool val) { }

	// RVA: 0x11ACF14
	public static void AddField(StringBuilder sb, int n, bool val, bool def) { }

	// RVA: 0x11ACF68
	public static void AddField(StringBuilder sb, int n, int val, int def) { }

	// RVA: 0x11AD02C
	public static void AddField(StringBuilder sb, int n, Type val) { }

}

// Namespace: System.Xml.Serialization
internal class ReflectionHelper
{
	// Fields
	private Hashtable _clrTypes; // 0x10
	private Hashtable _schemaTypes; // 0x18
	private static readonly ParameterModifier[] empty_modifiers; // 0x0

	// Methods

	// RVA: 0x11AD158
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x11AD224
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x11AD310
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x11AD474
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x11AD5EC
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x11AD9BC
	public void .ctor() { }

	// RVA: 0x11ADA58
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
internal enum SchemaTypes
{
	// Fields
	public int value__; // 0x10
	public const SchemaTypes NotSet = 0;
	public const SchemaTypes Primitive = 1;
	public const SchemaTypes Enum = 2;
	public const SchemaTypes Array = 3;
	public const SchemaTypes Class = 4;
	public const SchemaTypes XmlSerializable = 5;
	public const SchemaTypes XmlNode = 6;
	public const SchemaTypes Void = 7;
}

// Namespace: System.Xml.Serialization
internal abstract class SerializationSource
{
	// Fields
	private Type[] includedTypes; // 0x10
	private string namspace; // 0x18
	private bool canBeGenerated; // 0x20

	// Methods

	// RVA: 0x11ADAD8
	public void .ctor(string namspace, Type[] includedTypes) { }

	// RVA: 0x11ADB30
	protected bool BaseEquals(SerializationSource other) { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeSerializationSource
{
	// Fields
	private string attributeOverridesHash; // 0x28
	private Type type; // 0x30
	private string rootHash; // 0x38

	// Methods

	// RVA: 0x11ADC24
	public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0x11ADD70
	public override bool Equals(object o) { }

	// RVA: 0x11ADE58
	public override int GetHashCode() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeConvertorAttribute
{
	// Fields
	private string <Method>k__BackingField; // 0x10

	// Methods

	// RVA: 0x11ADE7C
	public string get_Method() { }

	// RVA: 0x11ADE84
	private void set_Method(string value) { }

	// RVA: 0x11ADE8C
	public void .ctor(string method) { }

}

// Namespace: System.Xml.Serialization
internal class TypeData
{
	// Fields
	private Type type; // 0x10
	private string elementName; // 0x18
	private SchemaTypes sType; // 0x20
	private Type listItemType; // 0x28
	private string typeName; // 0x30
	private string fullTypeName; // 0x38
	private TypeData listItemTypeData; // 0x40
	private TypeData mappedType; // 0x48
	private XmlSchemaPatternFacet facet; // 0x50
	private MethodInfo typeConvertor; // 0x58
	private bool hasPublicConstructor; // 0x60
	private bool nullableOverride; // 0x61
	private static string[] keywords; // 0x0

	// Methods

	// RVA: 0x11ADEC0
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x11ADECC
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x11AE544
	private void LookupTypeConvertor() { }

	// RVA: 0x11AE608
	internal void ConvertForAssignment(object value) { }

	// RVA: 0x11AE700
	public string get_TypeName() { }

	// RVA: 0x11AE708
	public string get_XmlType() { }

	// RVA: 0x11AE710
	public Type get_Type() { }

	// RVA: 0x11AE718
	public string get_FullTypeName() { }

	// RVA: 0x11AE720
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x11AD9AC
	public bool get_IsListType() { }

	// RVA: 0x11AE728
	public bool get_IsComplexType() { }

	// RVA: 0x11AE760
	public bool get_IsValueType() { }

	// RVA: 0x11AE828
	public bool get_IsNullable() { }

	// RVA: 0x11AE9D0
	public void set_IsNullable(bool value) { }

	// RVA: 0x11AE2E4
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x11AE9D8
	public Type get_ListItemType() { }

	// RVA: 0x11AE750
	public bool get_IsXsdType() { }

	// RVA: 0x11AF64C
	public bool get_HasPublicConstructor() { }

	// RVA: 0x11AF3D8
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x11AF51C
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x11AF1AC
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x11AF654
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
internal sealed class TypeMember
{
	// Fields
	private Type type; // 0x10
	private string member; // 0x18

	// Methods

	// RVA: 0x11B0648
	internal void .ctor(Type type, string member) { }

	// RVA: 0x11B0698
	public override int GetHashCode() { }

	// RVA: 0x11B06E8
	public override bool Equals(object obj) { }

	// RVA: 0x11B07D8
	public static bool Equals(TypeMember tm1, TypeMember tm2) { }

	// RVA: 0x11B08C0
	public override string ToString() { }

}

// Namespace: System.Xml.Serialization
internal class TypeTranslator
{
	// Fields
	private static Hashtable nameCache; // 0x0
	private static Hashtable primitiveTypes; // 0x8
	private static Hashtable primitiveArrayTypes; // 0x10
	private static Hashtable nullableTypes; // 0x18

	// Methods

	// RVA: 0x11B0928
	private static void .cctor() { }

	// RVA: 0x11AD944
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x11B2C90
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType) { }

	// RVA: 0x11B386C
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x11B38F4
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x11B3B28
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x11AE430
	public static string GetArrayName(string elemName) { }

	// RVA: 0x11B3C0C
	public static void ParseArrayType(string arrayType, string type, string ns, string dimensions) { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyAttributeAttribute
{
	// Methods

	// RVA: 0x11B3DA8
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyElementAttribute
{
	// Fields
	private string elementName; // 0x10
	private string ns; // 0x18
	private int order; // 0x20

	// Methods

	// RVA: 0x11B3DB0
	public void .ctor() { }

	// RVA: 0x11B3DC0
	public string get_Name() { }

	// RVA: 0x11B3E2C
	public string get_Namespace() { }

	// RVA: 0x11B3E34
	public int get_Order() { }

	// RVA: 0x11B3E3C
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyElementAttributes
{
	// Methods

	// RVA: 0x11B3ED8
	public XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x11B3FF8
	public int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x11B40BC
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11B4198
	internal int get_Order() { }

	// RVA: 0x11B4464
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlArrayAttribute
{
	// Fields
	private string elementName; // 0x10
	private XmlSchemaForm form; // 0x18
	private bool isNullable; // 0x1C
	private string ns; // 0x20
	private int order; // 0x28

	// Methods

	// RVA: 0x11B446C
	public string get_ElementName() { }

	// RVA: 0x11B44D8
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11B44E0
	public bool get_IsNullable() { }

	// RVA: 0x11B44E8
	public string get_Namespace() { }

	// RVA: 0x11B44F0
	public int get_Order() { }

	// RVA: 0x11B44F8
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlArrayItemAttribute
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private bool isNullableSpecified; // 0x31
	private int nestingLevel; // 0x34
	private Type type; // 0x38

	// Methods

	// RVA: 0x11B4624
	public string get_DataType() { }

	// RVA: 0x11B4690
	public string get_ElementName() { }

	// RVA: 0x11B46FC
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11B4704
	public string get_Namespace() { }

	// RVA: 0x11B470C
	public bool get_IsNullable() { }

	// RVA: 0x11B4714
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x11B471C
	public Type get_Type() { }

	// RVA: 0x11B4724
	public int get_NestingLevel() { }

	// RVA: 0x11B472C
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlArrayItemAttributes
{
	// Methods

	// RVA: 0x11B489C
	public XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x11B49BC
	public int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x11B4A80
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11B4B5C
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlAttributeAttribute
{
	// Fields
	private string attributeName; // 0x10
	private string dataType; // 0x18
	private Type type; // 0x20
	private XmlSchemaForm form; // 0x28
	private string ns; // 0x30

	// Methods

	// RVA: 0x11B4B64
	public void .ctor(string attributeName) { }

	// RVA: 0x11B4B98
	public string get_AttributeName() { }

	// RVA: 0x11B4C04
	public string get_DataType() { }

	// RVA: 0x11B4C70
	public void set_DataType(string value) { }

	// RVA: 0x11B4C78
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11B4C80
	public string get_Namespace() { }

	// RVA: 0x11B4C88
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlAttributeOverrides
{
	// Fields
	private Hashtable overrides; // 0x10

	// Methods

	// RVA: 0x11B4DC8
	public void .ctor() { }

	// RVA: 0x11B4E40
	public XmlAttributes get_Item(Type type) { }

	// RVA: 0x11B4EA4
	public XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x11B4F9C
	private TypeMember GetKey(Type type, string member) { }

	// RVA: 0x11B500C
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlAttributes
{
	// Fields
	private XmlAnyAttributeAttribute xmlAnyAttribute; // 0x10
	private XmlAnyElementAttributes xmlAnyElements; // 0x18
	private XmlArrayAttribute xmlArray; // 0x20
	private XmlArrayItemAttributes xmlArrayItems; // 0x28
	private XmlAttributeAttribute xmlAttribute; // 0x30
	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier; // 0x38
	private object xmlDefaultValue; // 0x40
	private XmlElementAttributes xmlElements; // 0x48
	private XmlEnumAttribute xmlEnum; // 0x50
	private bool xmlIgnore; // 0x58
	private bool xmlns; // 0x59
	private XmlRootAttribute xmlRoot; // 0x60
	private XmlTextAttribute xmlText; // 0x68
	private XmlTypeAttribute xmlType; // 0x70

	// Methods

	// RVA: 0x11B5810
	public void .ctor() { }

	// RVA: 0x11B5944
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x11B6398
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x11B63A0
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x11B63A8
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x11B63B0
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x11B63B8
	public XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x11B63C0
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x11B63C8
	public object get_XmlDefaultValue() { }

	// RVA: 0x11B63D0
	public XmlElementAttributes get_XmlElements() { }

	// RVA: 0x11B63D8
	public bool get_XmlIgnore() { }

	// RVA: 0x11B63E0
	public bool get_Xmlns() { }

	// RVA: 0x11B63E8
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x11B63F0
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x11B63F8
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x11B54FC
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11B73E0
	internal System.Nullable<System.Int32> get_Order() { }

	// RVA: 0x11B777C
	internal int get_SortableOrder() { }

}

// Namespace: System.Xml.Serialization
public class XmlChoiceIdentifierAttribute
{
	// Fields
	private string memberName; // 0x10

	// Methods

	// RVA: 0x11B7858
	public string get_MemberName() { }

	// RVA: 0x11B7358
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
internal class XmlCustomFormatter
{
	// Fields
	private static string[] allTimeFormats; // 0x0

	// Methods

	// RVA: 0x11B78C4
	internal static string FromEnum(Int64 value, string[] values, Int64[] ids, string typeName) { }

	// RVA: 0x11B7C34
	internal static string FromXmlName(string name) { }

	// RVA: 0x11B7CBC
	internal static string FromXmlNCName(string ncName) { }

	// RVA: 0x11B64DC
	internal static string ToXmlString(TypeData type, object value) { }

	// RVA: 0x11B7D44
	internal static object FromXmlString(TypeData type, string value) { }

	// RVA: 0x11B88E8
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlElementAttribute
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private Type type; // 0x38
	private int order; // 0x40

	// Methods

	// RVA: 0x11B8E48
	public void .ctor(string elementName) { }

	// RVA: 0x11B8E84
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x11B8EDC
	public string get_DataType() { }

	// RVA: 0x11B8F48
	public string get_ElementName() { }

	// RVA: 0x11B8FB4
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11B8FBC
	public string get_Namespace() { }

	// RVA: 0x11B8FC4
	public bool get_IsNullable() { }

	// RVA: 0x11B8FCC
	public int get_Order() { }

	// RVA: 0x11B8FD4
	public Type get_Type() { }

	// RVA: 0x11B8FDC
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlElementAttributes
{
	// Methods

	// RVA: 0x11B9130
	public XmlElementAttribute get_Item(int index) { }

	// RVA: 0x11B62D4
	public int Add(XmlElementAttribute attribute) { }

	// RVA: 0x11B6400
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11B74B0
	internal int get_Order() { }

	// RVA: 0x11B593C
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlEnumAttribute
{
	// Fields
	private string name; // 0x10

	// Methods

	// RVA: 0x11B9250
	public void .ctor(string name) { }

	// RVA: 0x11B9284
	public string get_Name() { }

	// RVA: 0x11B720C
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlIgnoreAttribute
{
	// Methods

	// RVA: 0x11B928C
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlIncludeAttribute
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0x11B9294
	public Type get_Type() { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlMapping
{
	// Fields
	private ObjectMap map; // 0x10
	private ArrayList relatedMaps; // 0x18
	private SerializationFormat format; // 0x20
	private SerializationSource source; // 0x28
	internal string _elementName; // 0x30
	internal string _namespace; // 0x38
	private string key; // 0x40

	// Methods

	// RVA: 0x11B929C
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x11B92EC
	public string get_ElementName() { }

	// RVA: 0x11B92F4
	public string get_Namespace() { }

	// RVA: 0x11B92FC
	public void SetKey(string key) { }

	// RVA: 0x11B9304
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x11B930C
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x11B9314
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x11B931C
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x11B9324
	internal SerializationFormat get_Format() { }

	// RVA: 0x11B932C
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x11B9334
	internal SerializationSource get_Source() { }

}

// Namespace: System.Xml.Serialization
internal class ObjectMap
{
	// Methods

	// RVA: 0x11B933C
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal enum SerializationFormat
{
	// Fields
	public int value__; // 0x10
	public const SerializationFormat Encoded = 0;
	public const SerializationFormat Literal = 1;
}

// Namespace: System.Xml.Serialization
public class XmlMemberMapping
{}

// Namespace: System.Xml.Serialization
public class XmlMembersMapping
{
	// Fields
	private bool _hasWrapperElement; // 0x48
	private XmlMemberMapping[] _mapping; // 0x50

	// Methods

	// RVA: 0x11B9344
	public int get_Count() { }

	// RVA: 0x11B9364
	internal bool get_HasWrapperElement() { }

}

// Namespace: System.Xml.Serialization
public class XmlNamespaceDeclarationsAttribute
{
	// Methods

	// RVA: 0x11B936C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Xml.Serialization.XmlReflectionImporter.<>c <>9; // 0x0
	public static System.Comparison<System.Xml.Serialization.XmlReflectionMember> <>9__28_0; // 0x8

	// Methods

	// RVA: 0x11C1118
	private static void .cctor() { }

	// RVA: 0x11C1184
	public void .ctor() { }

	// RVA: 0x11C118C
	internal int <ImportClassMapping>b__28_0(XmlReflectionMember m1, XmlReflectionMember m2) { }

}

// Namespace: System.Xml.Serialization
public class XmlReflectionImporter
{
	// Fields
	private string initialDefaultNamespace; // 0x10
	private XmlAttributeOverrides attributeOverrides; // 0x18
	private ArrayList includedTypes; // 0x20
	private ReflectionHelper helper; // 0x28
	private int arrayChoiceCount; // 0x30
	private ArrayList relatedMaps; // 0x38
	private bool allowPrivateTypes; // 0x40
	private static readonly string errSimple; // 0x0
	private static readonly string errSimple2; // 0x8

	// Methods

	// RVA: 0x11B9374
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x11B9510
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x11B971C
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x11B951C
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11B9728
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11BC8CC
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x11BCE5C
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType) { }

	// RVA: 0x11B9BCC
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType) { }

	// RVA: 0x11BEBE0
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x11BCEF8
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11BEEB4
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x11BB04C
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x11BBEE8
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11BC0E4
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11BC1B4
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11BC79C
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11BED60
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x11BD06C
	private System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x11BE060
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x11BF5FC
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x11BEFBC
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x11C0818
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x11BCDA0
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x11C0B68
	public void IncludeType(Type type) { }

	// RVA: 0x11C062C
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x11C1078
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlReflectionMember
{
	// Fields
	private bool isReturnValue; // 0x10
	private string memberName; // 0x18
	private Type memberType; // 0x20
	private XmlAttributes xmlAttributes; // 0x28
	private Type declaringType; // 0x30

	// Methods

	// RVA: 0x11BEF58
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x11C127C
	public bool get_IsReturnValue() { }

	// RVA: 0x11C1284
	public string get_MemberName() { }

	// RVA: 0x11C128C
	public Type get_MemberType() { }

	// RVA: 0x11BDFDC
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x11C1294
	internal Type get_DeclaringType() { }

	// RVA: 0x11C129C
	internal void set_DeclaringType(Type value) { }

}

// Namespace: System.Xml.Serialization
public class XmlRootAttribute
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private bool isNullable; // 0x20
	private string ns; // 0x28

	// Methods

	// RVA: 0x11C12A4
	public void .ctor() { }

	// RVA: 0x11C12B4
	public void .ctor(string elementName) { }

	// RVA: 0x11C12F0
	public string get_DataType() { }

	// RVA: 0x11C135C
	public void set_DataType(string value) { }

	// RVA: 0x11BCDF0
	public string get_ElementName() { }

	// RVA: 0x11C1364
	public void set_ElementName(string value) { }

	// RVA: 0x11C136C
	public bool get_IsNullable() { }

	// RVA: 0x11C1374
	public void set_IsNullable(bool value) { }

	// RVA: 0x11C137C
	public string get_Namespace() { }

	// RVA: 0x11C1384
	public void set_Namespace(string value) { }

	// RVA: 0x11B7294
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSchemaProviderAttribute
{
	// Fields
	private string _methodName; // 0x10
	private bool _isAny; // 0x18

	// Methods

	// RVA: 0x11C138C
	public void .ctor(string methodName) { }

	// RVA: 0x11C13C0
	public string get_MethodName() { }

	// RVA: 0x11C13C8
	public bool get_IsAny() { }

	// RVA: 0x11C13D0
	public void set_IsAny(bool value) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationCollectionFixupCallback
{
	// Methods

	// RVA: 0x11C13D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11C14FC
	public virtual void Invoke(object collection, object collectionItems) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationFixupCallback
{
	// Methods

	// RVA: 0x11C1510
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11C1630
	public virtual void Invoke(object fixup) { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationGeneratedCode
{
	// Methods

	// RVA: 0x11C1644
	protected void .ctor() { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationReadCallback
{
	// Methods

	// RVA: 0x11C164C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11C16EC
	public virtual object Invoke() { }

}

// Namespace: 
private class WriteCallbackInfo
{
	// Fields
	public Type Type; // 0x10
	public string TypeName; // 0x18
	public string TypeNs; // 0x20
	public XmlSerializationReadCallback Callback; // 0x28

	// Methods

	// RVA: 0x11C2090
	public void .ctor() { }

}

// Namespace: 
protected class CollectionFixup
{
	// Fields
	private XmlSerializationCollectionFixupCallback callback; // 0x10
	private object collection; // 0x18
	private object collectionItems; // 0x20
	private string id; // 0x28

	// Methods

	// RVA: 0x11C6580
	internal void .ctor(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

	// RVA: 0x11C65E4
	public XmlSerializationCollectionFixupCallback get_Callback() { }

	// RVA: 0x11C65EC
	public object get_Collection() { }

	// RVA: 0x11C65F4
	internal object get_Id() { }

	// RVA: 0x11C65FC
	public object get_CollectionItems() { }

	// RVA: 0x11C6604
	internal void set_CollectionItems(object value) { }

}

// Namespace: 
protected class Fixup
{
	// Fields
	private object source; // 0x10
	private string[] ids; // 0x18
	private XmlSerializationFixupCallback callback; // 0x20

	// Methods

	// RVA: 0x11C660C
	public void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	// RVA: 0x11C66B0
	public XmlSerializationFixupCallback get_Callback() { }

	// RVA: 0x11C66B8
	public string[] get_Ids() { }

	// RVA: 0x11C66C0
	public object get_Source() { }

}

// Namespace: 
private class CollectionItemFixup
{
	// Fields
	private Array list; // 0x10
	private int index; // 0x18
	private string id; // 0x20

	// Methods

	// RVA: 0x11C4788
	public void .ctor(Array list, int index, string id) { }

	// RVA: 0x11C66C8
	public Array get_Collection() { }

	// RVA: 0x11C66D0
	public int get_Index() { }

	// RVA: 0x11C66D8
	public string get_Id() { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationReader
{
	// Fields
	private XmlDocument document; // 0x10
	private XmlReader reader; // 0x18
	private ArrayList fixups; // 0x20
	private Hashtable collFixups; // 0x28
	private ArrayList collItemFixups; // 0x30
	private Hashtable typesCallbacks; // 0x38
	private ArrayList noIDTargets; // 0x40
	private Hashtable targets; // 0x48
	private Hashtable delayedListFixups; // 0x50
	private XmlSerializer eventSource; // 0x58
	private int delayedFixupId; // 0x60
	private Hashtable referencedObjects; // 0x68
	private int readCount; // 0x70
	private int whileIterationCount; // 0x74
	private string w3SchemaNS; // 0x78
	private string w3InstanceNS; // 0x80
	private string w3InstanceNS2000; // 0x88
	private string w3InstanceNS1999; // 0x90
	private string soapNS; // 0x98
	private string wsdlNS; // 0xA0
	private string nullX; // 0xA8
	private string nil; // 0xB0
	private string typeX; // 0xB8
	private string arrayType; // 0xC0
	private XmlQualifiedName arrayQName; // 0xC8

	// Methods

	// RVA: 0x11C1700
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x11C1ACC
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x11C1B40
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x11C1BB4
	protected void .ctor() { }

	// RVA: 0x11C1BBC
	protected XmlDocument get_Document() { }

	// RVA: 0x11C1C70
	protected XmlReader get_Reader() { }

	// RVA: 0x11C1C78
	protected void AddFixup(CollectionFixup fixup) { }

	// RVA: 0x11C1DBC
	protected void AddFixup(Fixup fixup) { }

	// RVA: 0x11C1E70
	private void AddFixup(CollectionItemFixup fixup) { }

	// RVA: 0x11C1F24
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x11C2098
	protected void AddTarget(string id, object o) { }

	// RVA: 0x11C2238
	private string CurrentTag() { }

	// RVA: 0x11C23C4
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x11C2454
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x11C24F4
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x11C2588
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x11C2730
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x11C27CC
	protected bool GetNullAttr() { }

	// RVA: 0x11C2894
	protected object GetTarget(string id) { }

	// RVA: 0x11C2974
	private bool TargetReady(string id) { }

	// RVA: 0x11C2990
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1
	protected abstract void InitCallbacks() { }

	// RVA: -1
	protected abstract void InitIDs() { }

	// RVA: 0x11C2B90
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x11C2C34
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x11C2DB4
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x11C30F0
	protected void ReadEndElement() { }

	// RVA: 0x11C31B8
	protected bool ReadNull() { }

	// RVA: 0x11C32D4
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x11C330C
	protected string ReadNullableString() { }

	// RVA: 0x11C3364
	protected object ReadReferencedElement() { }

	// RVA: 0x11C36C0
	private WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x11C33BC
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x11C37B8
	private bool ReadList(object resultList) { }

	// RVA: 0x11C47E0
	protected void ReadReferencedElements() { }

	// RVA: 0x11C5718
	protected object ReadReferencingElement(string fixupReference) { }

	// RVA: 0x11C477C
	protected object ReadReferencingElement(string name, string ns, string fixupReference) { }

	// RVA: 0x11C5784
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, string fixupReference) { }

	// RVA: 0x11C5B58
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x11C5D20
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x11C3D40
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x11C5FAC
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x11C60A8
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x11C61C4
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x11C2EB4
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x11C6274
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x11C63D8
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x11C329C
	protected void UnknownNode(object o) { }

	// RVA: 0x11C653C
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x11C5D28
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x11C5680
	protected void UnreferencedObject(string id, object o) { }

}

// Namespace: 
private class FixupCallbackInfo
{
	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private ClassMap _map; // 0x18
	private bool _isValueList; // 0x20

	// Methods

	// RVA: 0x11CB7B8
	public void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

	// RVA: 0x11CC9F4
	public void FixupMembers(object fixup) { }

}

// Namespace: 
private class ReaderCallbackInfo
{
	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x11C6B40
	public void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

	// RVA: 0x11CCA20
	internal object ReadObject() { }

}

// Namespace: System.Xml.Serialization
internal class XmlSerializationReaderInterpreter
{
	// Fields
	private XmlMapping _typeMap; // 0xD0
	private SerializationFormat _format; // 0xD8
	private static readonly XmlQualifiedName AnyType; // 0x0
	private static readonly object[] empty_array; // 0x8

	// Methods

	// RVA: 0x11C66E0
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x11C6728
	protected override void InitCallbacks() { }

	// RVA: 0x11C6B90
	protected override void InitIDs() { }

	// RVA: 0x11C6B94
	public object ReadRoot() { }

	// RVA: 0x11C6D7C
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x11C6ECC
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x11C6CA0
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x11CA0BC
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x11CA99C
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x11CACDC
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x11C7544
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11C7A80
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x11CB4C0
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11CBB70
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x11CBF58
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x11CBF90
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x11CB6A0
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x11CAED4
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x11C7478
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x11CB078
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x11CB8CC
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x11CBFC8
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x11CAD88
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x11CA228
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x11CC10C
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x11CB14C
	private void AddListValue(TypeData listType, object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x11CACD4
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x11C7408
	private object CreateInstance(Type type) { }

	// RVA: 0x11CB814
	private object CreateList(Type listType) { }

	// RVA: 0x11CB710
	private object InitializeList(TypeData listType) { }

	// RVA: 0x11CC4A4
	private void FillList(object list, object items) { }

	// RVA: 0x11CC4B4
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x11CA09C
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11CBAA8
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x11CA670
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11CA760
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11CC350
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x11CA7D0
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11CC900
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationWriteCallback
{
	// Methods

	// RVA: 0x11CCA54
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11CCB74
	public virtual void Invoke(object o) { }

}

// Namespace: 
private class WriteCallbackInfo
{
	// Fields
	public Type Type; // 0x10
	public string TypeName; // 0x18
	public string TypeNs; // 0x20
	public XmlSerializationWriteCallback Callback; // 0x28

	// Methods

	// RVA: 0x11D0720
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationWriter
{
	// Fields
	private ObjectIDGenerator idGenerator; // 0x10
	private int qnameCount; // 0x18
	private bool topLevelElement; // 0x1C
	private ArrayList namespaces; // 0x20
	private XmlWriter writer; // 0x28
	private Queue referencedElements; // 0x30
	private Hashtable callbacks; // 0x38
	private Hashtable serializedObjects; // 0x40

	// Methods

	// RVA: 0x11CCB88
	protected void .ctor() { }

	// RVA: 0x11CCC04
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x11CCD3C
	protected XmlWriter get_Writer() { }

	// RVA: 0x11CCD44
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x11CCE68
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x11CCF08
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x11CCFAC
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x11CD03C
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x11CD218
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x11CD340
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x11CD380
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x11CD13C
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1
	protected abstract void InitCallbacks() { }

	// RVA: 0x11CD4F8
	protected void TopLevelElement() { }

	// RVA: 0x11CD504
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x11CD4CC
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x11CD540
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x11CD5EC
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x11CD8EC
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x11CDBF0
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x11CDBF8
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x11CDF00
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x11CDF08
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x11CDEDC
	protected void WriteEndElement() { }

	// RVA: 0x11CE0E0
	protected void WriteEndElement(object o) { }

	// RVA: 0x11CE12C
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x11CE560
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x11CE648
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x11CE720
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x11CE72C
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x11CD828
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x11CDB28
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x11CE73C
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x11CEE48
	protected void WriteReferencedElements() { }

	// RVA: 0x11CED48
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x11CF068
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x11CF374
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x11CECB0
	private void CheckReferenceQueue() { }

	// RVA: 0x11CF554
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x11CF55C
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x11CF73C
	protected void WriteStartDocument() { }

	// RVA: 0x11CDDAC
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x11CECA0
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x11CF79C
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x11CF794
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x11CF7A8
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x11D00E4
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x11D0430
	protected void WriteValue(string value) { }

	// RVA: 0x11D0464
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x11CDDBC
	protected void WriteXsiType(string name, string ns) { }

}

// Namespace: 
private class CallbackInfo
{
	// Fields
	private XmlSerializationWriterInterpreter _swi; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x11D0B7C
	public void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

	// RVA: 0x11D75C4
	internal void WriteObject(object ob) { }

	// RVA: 0x11D7614
	internal void WriteEnum(object ob) { }

}

// Namespace: System.Xml.Serialization
internal class XmlSerializationWriterInterpreter
{
	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x11D0728
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x11D0770
	protected override void InitCallbacks() { }

	// RVA: 0x11D0BCC
	public void WriteRoot(object ob) { }

	// RVA: 0x11D0DDC
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x11D19F4
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x11D1C38
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11D1E84
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x11D2660
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x11D1BF4
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11D1F2C
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11D2708
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11D328C
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x11D3018
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x11D3A7C
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x11D14FC
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x11D58A0
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x11D5C34
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x11D5EFC
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11D4084
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x11D60F4
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x11D496C
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x11D70E0
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11D7128
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11D3790
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x11D7164
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }

}

// Namespace: 
internal class SerializerData
{
	// Fields
	public MethodInfo ReaderMethod; // 0x10
	public Type WriterType; // 0x18
	public MethodInfo WriterMethod; // 0x20
	public XmlSerializerImplementation Implementation; // 0x28

	// Methods

	// RVA: 0x11D86F8
	public XmlSerializationWriter CreateWriter() { }

}

// Namespace: System.Xml.Serialization
public class XmlSerializer
{
	// Fields
	private static int generationThreshold; // 0x0
	private static bool backgroundGeneration; // 0x4
	private static bool deleteTempFiles; // 0x5
	private static bool generatorFallback; // 0x6
	private bool customSerializer; // 0x10
	private XmlMapping typeMapping; // 0x18
	private SerializerData serializerData; // 0x20
	private static Hashtable serializerTypes; // 0x8
	private UnreferencedObjectEventHandler onUnreferencedObject; // 0x28
	private XmlAttributeEventHandler onUnknownAttribute; // 0x30
	private XmlElementEventHandler onUnknownElement; // 0x38
	private XmlNodeEventHandler onUnknownNode; // 0x40

	// Methods

	// RVA: 0x11D7664
	private static void .cctor() { }

	// RVA: 0x11D7724
	public void .ctor(Type type) { }

	// RVA: 0x11D7738
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11D78E4
	internal XmlMapping get_Mapping() { }

	// RVA: 0x11D78EC
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0x11D7910
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0x11D7934
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0x11D7958
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0x11D797C
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0x11D79BC
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0x11D79FC
	public object Deserialize(TextReader textReader) { }

	// RVA: 0x11D7A94
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0x11D7BBC
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0x11D7EB4
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0x11D80D4
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0x11D84A8
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0x11D8170
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0x11D84B0
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0x11D7B54
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

}

// Namespace: System.Xml.Serialization
public class XmlSerializerFactory
{
	// Fields
	private static Hashtable serializersBySource; // 0x0

	// Methods

	// RVA: 0x11D8804
	public void .ctor() { }

	// RVA: 0x11D880C
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0x11D8AB8
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0x11D8820
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11D8ACC
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializerImplementation
{
	// Methods

	// RVA: 0x11D8B54
	public virtual XmlSerializationWriter get_Writer() { }

}

// Namespace: System.Xml.Serialization
public class XmlTextAttribute
{
	// Fields
	private string dataType; // 0x10
	private Type type; // 0x18

	// Methods

	// RVA: 0x11D8B94
	public void .ctor() { }

	// RVA: 0x11D8B9C
	public string get_DataType() { }

	// RVA: 0x11D8C08
	public Type get_Type() { }

	// RVA: 0x11D8C10
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlTypeAttribute
{
	// Fields
	private bool includeInSchema; // 0x10
	private string ns; // 0x18
	private string typeName; // 0x20

	// Methods

	// RVA: 0x11D8CAC
	public bool get_IncludeInSchema() { }

	// RVA: 0x11D8CB4
	public string get_Namespace() { }

	// RVA: 0x11D8CBC
	public string get_TypeName() { }

	// RVA: 0x11D8D28
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfo
{
	// Fields
	private string _elementName; // 0x10
	private string _namespace; // 0x18
	private XmlSchemaForm _form; // 0x20
	private XmlTypeMapMember _member; // 0x28
	private object _choiceValue; // 0x30
	private bool _isNullable; // 0x38
	private int _nestingLevel; // 0x3C
	private XmlTypeMapping _mappedType; // 0x40
	private TypeData _type; // 0x48
	private bool _wrappedElement; // 0x50
	private int _explicitOrder; // 0x54

	// Methods

	// RVA: 0x11D8DD8
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x11D8EB0
	public TypeData get_TypeData() { }

	// RVA: 0x11D8EB8
	public object get_ChoiceValue() { }

	// RVA: 0x11D8EC0
	public void set_ChoiceValue(object value) { }

	// RVA: 0x11D8EC8
	public string get_ElementName() { }

	// RVA: 0x11D8ED0
	public void set_ElementName(string value) { }

	// RVA: 0x11D8ED8
	public string get_Namespace() { }

	// RVA: 0x11D8EE0
	public void set_Namespace(string value) { }

	// RVA: 0x11D5B88
	public string get_DataTypeNamespace() { }

	// RVA: 0x11D5B54
	public string get_DataTypeName() { }

	// RVA: 0x11D8EE8
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11D8EF0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x11D8EF8
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x11D8F00
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x11D8F08
	public bool get_IsNullable() { }

	// RVA: 0x11D8F10
	public void set_IsNullable(bool value) { }

	// RVA: 0x11D8F18
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x11D8F20
	public void set_NestingLevel(int value) { }

	// RVA: 0x11D8F28
	public bool get_MultiReferenceType() { }

	// RVA: 0x11D8F48
	public bool get_WrappedElement() { }

	// RVA: 0x11D8F50
	public void set_WrappedElement(bool value) { }

	// RVA: 0x11D8F58
	public bool get_IsTextElement() { }

	// RVA: 0x11D8FB0
	public void set_IsTextElement(bool value) { }

	// RVA: 0x11D9084
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0x11D90E4
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x11D91AC
	public int get_ExplicitOrder() { }

	// RVA: 0x11D91B4
	public void set_ExplicitOrder(int value) { }

	// RVA: 0x11D91BC
	public override bool Equals(object other) { }

	// RVA: 0x11D9320
	public override int GetHashCode() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfoList
{
	// Methods

	// RVA: 0x11D9328
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMember
{
	// Fields
	private string _name; // 0x10
	private int _index; // 0x18
	private int _globalIndex; // 0x1C
	private int _specifiedGlobalIndex; // 0x20
	private TypeData _typeData; // 0x28
	private MemberInfo _member; // 0x30
	private MemberInfo _specifiedMember; // 0x38
	private MethodInfo _shouldSerialize; // 0x40
	private object _defaultValue; // 0x48
	private int _flags; // 0x50

	// Methods

	// RVA: 0x11D9330
	public void .ctor() { }

	// RVA: 0x11D93B4
	public string get_Name() { }

	// RVA: 0x11D93BC
	public void set_Name(string value) { }

	// RVA: 0x11D93C4
	public object get_DefaultValue() { }

	// RVA: 0x11D93CC
	public void set_DefaultValue(object value) { }

	// RVA: 0x11D93D4
	public bool IsReadOnly(Type type) { }

	// RVA: 0x11D9758
	public static object GetValue(object ob, string name) { }

	// RVA: 0x11D1D64
	public object GetValue(object ob) { }

	// RVA: 0x11D9884
	public void SetValue(object ob, object value) { }

	// RVA: 0x11D99D4
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0x11D94DC
	private void InitMember(Type type) { }

	// RVA: 0x11D9B08
	public TypeData get_TypeData() { }

	// RVA: 0x11D9B10
	public void set_TypeData(TypeData value) { }

	// RVA: 0x11D9B18
	public int get_Index() { }

	// RVA: 0x11D9B20
	public void set_Index(int value) { }

	// RVA: 0x11D9B28
	public int get_GlobalIndex() { }

	// RVA: 0x11D9B30
	public void set_GlobalIndex(int value) { }

	// RVA: 0x11D5648
	public bool get_IsOptionalValueType() { }

	// RVA: 0x11D9B38
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0x11D9B4C
	public bool get_IsReturnValue() { }

	// RVA: 0x11D9B58
	public void set_IsReturnValue(bool value) { }

	// RVA: 0x11D9B78
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0x11D5654
	public bool GetValueSpecified(object ob) { }

	// RVA: 0x11D9BF4
	public void SetValueSpecified(object ob, bool value) { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAttribute
{
	// Fields
	private string _attributeName; // 0x58
	private string _namespace; // 0x60
	private XmlSchemaForm _form; // 0x68
	private XmlTypeMapping _mappedType; // 0x70

	// Methods

	// RVA: 0x11D9E9C
	public void .ctor() { }

	// RVA: 0x11D9F58
	public string get_AttributeName() { }

	// RVA: 0x11D9F60
	public void set_AttributeName(string value) { }

	// RVA: 0x11D9F68
	public string get_Namespace() { }

	// RVA: 0x11D9F70
	public void set_Namespace(string value) { }

	// RVA: 0x11D9F78
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x11D9F80
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x11D9F88
	public void set_MappedType(XmlTypeMapping value) { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberElement
{
	// Fields
	private XmlTypeMapElementInfoList _elementInfo; // 0x58
	private string _choiceMember; // 0x60
	private bool _isTextCollector; // 0x68
	private TypeData _choiceTypeData; // 0x70

	// Methods

	// RVA: 0x11D9F90
	public void .ctor() { }

	// RVA: 0x11D39F4
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x11DA014
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x11DA01C
	public string get_ChoiceMember() { }

	// RVA: 0x11DA024
	public void set_ChoiceMember(string value) { }

	// RVA: 0x11DA02C
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x11DA034
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0x11D4F88
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0x11DA03C
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x11DA04C
	public bool get_IsXmlTextCollector() { }

	// RVA: 0x11DA054
	public void set_IsXmlTextCollector(bool value) { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberList
{
	// Methods

	// RVA: 0x11DA05C
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberExpandable
{
	// Fields
	private int _flatArrayIndex; // 0x78

	// Methods

	// RVA: 0x11DA0E0
	public int get_FlatArrayIndex() { }

	// RVA: 0x11DA0E8
	public void set_FlatArrayIndex(int value) { }

	// RVA: 0x11DA0F0
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberFlatList
{
	// Fields
	private ListMap _listMap; // 0x80

	// Methods

	// RVA: 0x11DA174
	public ListMap get_ListMap() { }

	// RVA: 0x11DA17C
	public void set_ListMap(ListMap value) { }

	// RVA: 0x11DA184
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyElement
{
	// Methods

	// RVA: 0x11D6D0C
	public bool IsElementDefined(string name, string ns) { }

	// RVA: 0x11DA208
	public bool get_IsDefaultAny() { }

	// RVA: 0x11DA5A0
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyAttribute
{
	// Methods

	// RVA: 0x11DA624
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberNamespaces
{
	// Methods

	// RVA: 0x11DA6A8
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlTypeMapping
{
	// Fields
	private string xmlType; // 0x48
	private string xmlTypeNamespace; // 0x50
	private TypeData type; // 0x58
	private XmlTypeMapping baseMap; // 0x60
	private bool multiReferenceType; // 0x68
	private bool includeInSchema; // 0x69
	private bool isNullable; // 0x6A
	private bool isAny; // 0x6B
	private ArrayList _derivedTypes; // 0x70

	// Methods

	// RVA: 0x11DA72C
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0x11D721C
	public string get_TypeFullName() { }

	// RVA: 0x11DA808
	internal TypeData get_TypeData() { }

	// RVA: 0x11DA810
	internal string get_XmlType() { }

	// RVA: 0x11DA818
	internal void set_XmlType(string value) { }

	// RVA: 0x11D1988
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x11DA820
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0x11DA828
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x11DA838
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x11DA840
	internal bool get_MultiReferenceType() { }

	// RVA: 0x11DA848
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x11DA850
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0x11DA858
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0x11DA860
	internal bool get_IsNullable() { }

	// RVA: 0x11DA868
	internal void set_IsNullable(bool value) { }

	// RVA: 0x11DA870
	internal bool get_IsAny() { }

	// RVA: 0x11DA878
	internal void set_IsAny(bool value) { }

	// RVA: 0x11D17F8
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0x11DA880
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0x11DAC48
	internal void UpdateRoot(XmlQualifiedName qname) { }

}

// Namespace: System.Xml.Serialization
internal class XmlSerializableMapping
{
	// Fields
	private XmlSchema _schema; // 0x78
	private XmlSchemaComplexType _schemaType; // 0x80
	private XmlQualifiedName _schemaTypeName; // 0x88

	// Methods

	// RVA: 0x11DAD10
	internal void .ctor(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

}

// Namespace: System.Xml.Serialization
internal class ClassMap
{
	// Fields
	private Hashtable _elements; // 0x10
	private ArrayList _elementMembers; // 0x18
	private Hashtable _attributeMembers; // 0x20
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; // 0x28
	private ArrayList _flatLists; // 0x30
	private ArrayList _allMembers; // 0x38
	private ArrayList _membersWithDefault; // 0x40
	private ArrayList _listMembers; // 0x48
	private XmlTypeMapMemberAnyElement _defaultAnyElement; // 0x50
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; // 0x58
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; // 0x60
	private XmlTypeMapMember _xmlTextCollector; // 0x68
	private XmlTypeMapMember _returnMember; // 0x70
	private bool _ignoreMemberNamespace; // 0x78
	private bool _canBeSimpleType; // 0x79
	private System.Nullable<System.Boolean> _isOrderDependentMap; // 0x7A

	// Methods

	// RVA: 0x11DB5D8
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x11DC3F8
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x11DC4B0
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x11DC5E4
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x11DC9A0
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x11DC310
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x11DCD28
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x11DD124
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x11DD12C
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x11DD134
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x11D335C
	public ICollection get_AttributeMembers() { }

	// RVA: 0x11DD13C
	public ICollection get_ElementMembers() { }

	// RVA: 0x11DD144
	public ArrayList get_AllMembers() { }

	// RVA: 0x11DD14C
	public ArrayList get_FlatLists() { }

	// RVA: 0x11DD154
	public ArrayList get_ListMembers() { }

	// RVA: 0x11DD15C
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x11DD164
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x11DD16C
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x11DD42C
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x11DD434
	public bool get_HasSimpleContent() { }

	// RVA: 0x11DD4A8
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class ListMap
{
	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Methods

	// RVA: 0x11DD560
	public void set_ChoiceMember(string value) { }

	// RVA: 0x11DD568
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x11DD570
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x11D64D4
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x11DD578
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x11DD884
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x11D622C
	public void GetArrayType(int itemCount, string localName, string ns) { }

	// RVA: 0x11DDBA4
	public override bool Equals(object other) { }

	// RVA: 0x11DDD08
	public override int GetHashCode() { }

	// RVA: 0x11DDD10
	public void .ctor() { }

}

// Namespace: 
public class EnumMapMember
{
	// Fields
	private readonly string _xmlName; // 0x10
	private readonly string _enumName; // 0x18
	private readonly Int64 _value; // 0x20

	// Methods

	// RVA: 0x11DE280
	public void .ctor(string xmlName, string enumName, Int64 value) { }

	// RVA: 0x11DE2DC
	public string get_XmlName() { }

	// RVA: 0x11DE2E4
	public string get_EnumName() { }

	// RVA: 0x11DE2EC
	public Int64 get_Value() { }

}

// Namespace: System.Xml.Serialization
internal class EnumMap
{
	// Fields
	private readonly EnumMapMember[] _members; // 0x10
	private readonly bool _isFlags; // 0x18
	private readonly string[] _enumNames; // 0x20
	private readonly string[] _xmlNames; // 0x28
	private readonly Int64[] _values; // 0x30

	// Methods

	// RVA: 0x11DDD18
	public void .ctor(EnumMapMember[] members, bool isFlags) { }

	// RVA: 0x11DDEC8
	public bool get_IsFlags() { }

	// RVA: 0x11DDED0
	public string[] get_EnumNames() { }

	// RVA: 0x11DDED8
	public string[] get_XmlNames() { }

	// RVA: 0x11DDEE0
	public Int64[] get_Values() { }

	// RVA: 0x11D723C
	public string GetXmlName(string typeName, object enumValue) { }

	// RVA: 0x11DDEE8
	public string GetEnumName(string typeName, string xmlName) { }

}

// Namespace: System.Xml.XmlConfiguration
public sealed class XmlReaderSection
{
	// Methods

	// RVA: 0x11DE2F4
	internal static bool get_ProhibitDefaultUrlResolver() { }

	// RVA: 0x11DE2FC
	internal static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x11DE354
	internal static bool get_CollapseWhiteSpaceIntoEmptyString() { }

}

// Namespace: System.Xml.Xsl
public interface IXsltContextFunction
{
	// Methods

	// RVA: -1
	public abstract XPathResultType get_ReturnType() { }

	// RVA: -1
	public abstract object Invoke(XsltContext xsltContext, object[] args, XPathNavigator docContext) { }

}

// Namespace: System.Xml.Xsl
public interface IXsltContextVariable
{
	// Methods

	// RVA: -1
	public abstract XPathResultType get_VariableType() { }

	// RVA: -1
	public abstract object Evaluate(XsltContext xsltContext) { }

}

// Namespace: System.Xml.Xsl
public abstract class XsltContext
{
	// Methods

	// RVA: 0x11DE35C
	internal void .ctor(bool dummy) { }

	// RVA: -1
	public abstract IXsltContextVariable ResolveVariable(string prefix, string name) { }

	// RVA: -1
	public abstract IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) { }

	// RVA: -1
	public abstract bool get_Whitespace() { }

	// RVA: -1
	public abstract bool PreserveWhitespace(XPathNavigator node) { }

}

// Namespace: System.Xml.Xsl.Runtime
public struct StringConcat
{
	// Fields
	private string s1; // 0x10
	private string s2; // 0x18
	private string s3; // 0x20
	private string s4; // 0x28
	private string delimiter; // 0x30
	private System.Collections.Generic.List<System.String> strList; // 0x38
	private int idxStr; // 0x40

	// Methods

	// RVA: 0x11DE364
	public void Clear() { }

	// RVA: 0x11DE374
	internal int get_Count() { }

	// RVA: 0x11DE37C
	public string GetResult() { }

	// RVA: 0x11DE47C
	internal void ConcatNoDelimiter(string s) { }

}

// Namespace: System.Xml.Schema
internal class AxisElement
{
	// Fields
	internal DoubleLinkAxis curNode; // 0x10
	internal int rootDepth; // 0x18
	internal int curDepth; // 0x1C
	internal bool isMatch; // 0x20

	// Methods

	// RVA: 0x11DE614
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0x11DE61C
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0x11DE668
	internal void SetDepth(int depth) { }

	// RVA: 0x11DE670
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0x11DE7B4
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }

}

// Namespace: System.Xml.Schema
internal class AxisStack
{
	// Fields
	private ArrayList _stack; // 0x10
	private ForwardAxis _subtree; // 0x18
	private ActiveAxis _parent; // 0x20

	// Methods

	// RVA: 0x11DEA8C
	internal ForwardAxis get_Subtree() { }

	// RVA: 0x11DEA94
	internal int get_Length() { }

	// RVA: 0x11DEABC
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0x11DEB94
	internal void Push(int depth) { }

	// RVA: 0x11DEC38
	internal void Pop() { }

	// RVA: 0x11DE9E8
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0x11DEC84
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0x11DEE38
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0x11DEFBC
	internal bool MoveToAttribute(string name, string URN, int depth) { }

}

// Namespace: System.Xml.Schema
internal class ActiveAxis
{
	// Fields
	private int _currentDepth; // 0x10
	private bool _isActive; // 0x14
	private Asttree _axisTree; // 0x18
	private ArrayList _axisStack; // 0x20

	// Methods

	// RVA: 0x11DF1A4
	public int get_CurrentDepth() { }

	// RVA: 0x11DF1AC
	internal void Reactivate() { }

	// RVA: 0x11DF1C0
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0x11DF384
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0x11DF4CC
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0x11DF5E8
	public bool MoveToAttribute(string localname, string URN) { }

}

// Namespace: System.Xml.Schema
internal class DoubleLinkAxis
{
	// Fields
	internal Axis next; // 0x40

	// Methods

	// RVA: 0x11DF6F4
	internal Axis get_Next() { }

	// RVA: 0x11DF6FC
	internal void set_Next(Axis value) { }

	// RVA: 0x11DF704
	internal void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x11DF798
	internal static DoubleLinkAxis ConvertTree(Axis axis) { }

}

// Namespace: System.Xml.Schema
internal class ForwardAxis
{
	// Fields
	private DoubleLinkAxis _topNode; // 0x10
	private DoubleLinkAxis _rootNode; // 0x18
	private bool _isAttribute; // 0x20
	private bool _isDss; // 0x21
	private bool _isSelfAxis; // 0x22

	// Methods

	// RVA: 0x11DF8B8
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x11DF8C0
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0x11DF8C8
	internal bool get_IsAttribute() { }

	// RVA: 0x11DF8D0
	internal bool get_IsDss() { }

	// RVA: 0x11DF8D8
	internal bool get_IsSelfAxis() { }

	// RVA: 0x11DF8E0
	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }

}

// Namespace: System.Xml.Schema
internal class Asttree
{
	// Fields
	private ArrayList _fAxisArray; // 0x10
	private string _xpathexpr; // 0x18
	private bool _isField; // 0x20
	private XmlNamespaceManager _nsmgr; // 0x28

	// Methods

	// RVA: 0x11DFAA4
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0x11DFAAC
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11E0380
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0x11DE9AC
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0x11E03BC
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0x11DFA5C
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0x11DFB18
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11E0404
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

// Namespace: System.Xml.Schema
internal class AutoValidator
{
	// Methods

	// RVA: 0x11E0540
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x11E06D8
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x11E06E0
	public override void Validate() { }

	// RVA: 0x11E0D70
	public override void CompleteValidation() { }

	// RVA: 0x11E0D74
	public override object FindId(string name) { }

	// RVA: 0x11E07D8
	private ValidationType DetectValidationType() { }

}

// Namespace: System.Xml.Schema
internal class BaseProcessor
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private ValidationEventHandler eventHandler; // 0x20
	private XmlSchemaCompilationSettings compilationSettings; // 0x28
	private int errorCount; // 0x30
	private string NsXml; // 0x38

	// Methods

	// RVA: 0x11E0E40
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x11E0EC8
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x11E0FA0
	protected XmlNameTable get_NameTable() { }

	// RVA: 0x11E0FA8
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x11E104C
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x11E1054
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x11E105C
	protected bool get_HasErrors() { }

	// RVA: 0x11E106C
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x11E14D0
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11E1788
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11E162C
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11E19D4
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0x11E18D0
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0x11E1B9C
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0x11E1D14
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0x11E1E54
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x11E1FE4
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x11E206C
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x11E2118
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x11E1AD0
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x11E21B0
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }

}

// Namespace: System.Xml.Schema
internal class BaseValidator
{
	// Fields
	private XmlSchemaCollection schemaCollection; // 0x10
	private IValidationEventHandling eventHandling; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaNames schemaNames; // 0x28
	private PositionInfo positionInfo; // 0x30
	private XmlResolver xmlResolver; // 0x38
	private Uri baseUri; // 0x40
	protected SchemaInfo schemaInfo; // 0x48
	protected XmlValidatingReaderImpl reader; // 0x50
	protected XmlQualifiedName elementName; // 0x58
	protected ValidationState context; // 0x60
	protected StringBuilder textValue; // 0x68
	protected string textString; // 0x70
	protected bool hasSibling; // 0x78
	protected bool checkDatatype; // 0x79

	// Methods

	// RVA: 0x11E2268
	public void .ctor(BaseValidator other) { }

	// RVA: 0x11E05D4
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x11E2324
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x11E232C
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x11E2334
	public XmlNameTable get_NameTable() { }

	// RVA: 0x11E0D7C
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x11E233C
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x11E2344
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x11E234C
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x11E2354
	public Uri get_BaseUri() { }

	// RVA: 0x11E235C
	public void set_BaseUri(Uri value) { }

	// RVA: 0x11E2364
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x11E2448
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0x11E2450
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x11E253C
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x11E2544
	public virtual void Validate() { }

	// RVA: 0x11E2548
	public virtual void CompleteValidation() { }

	// RVA: 0x11E254C
	public virtual object FindId(string name) { }

	// RVA: 0x11E2554
	public void ValidateText() { }

	// RVA: 0x11E2A50
	public void ValidateWhitespace() { }

	// RVA: 0x11E29D8
	private void SaveTextValue(string value) { }

	// RVA: 0x11E2B90
	protected void SendValidationEvent(string code) { }

	// RVA: 0x11E28F0
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x11E2808
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0x11E2BF4
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x11E2CE4
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x11E2DD0
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x11E2BFC
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x11E2EBC
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0x11E3084
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0x11E3288
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

}

// Namespace: System.Xml.Schema
internal sealed class BitSet
{
	// Fields
	private int count; // 0x10
	private UInt32[] bits; // 0x18

	// Methods

	// RVA: 0x11E34C8
	private void .ctor() { }

	// RVA: 0x11E34D0
	public void .ctor(int count) { }

	// RVA: 0x11E3554
	public int get_Count() { }

	// RVA: 0x11E355C
	public bool get_Item(int index) { }

	// RVA: 0x11E360C
	public void Clear() { }

	// RVA: 0x11E3664
	public void Set(int index) { }

	// RVA: 0x11E35B4
	public bool Get(int index) { }

	// RVA: 0x11E3780
	public int NextSet(int startFrom) { }

	// RVA: 0x11E3820
	public void And(BitSet other) { }

	// RVA: 0x11E3950
	public void Or(BitSet other) { }

	// RVA: 0x11E3A00
	public override int GetHashCode() { }

	// RVA: 0x11E3A3C
	public override bool Equals(object obj) { }

	// RVA: 0x11E3BB0
	public BitSet Clone() { }

	// RVA: 0x11E3CB0
	public bool get_IsEmpty() { }

	// RVA: 0x11E3D6C
	public bool Intersects(BitSet other) { }

	// RVA: 0x11E354C
	private int Subscript(int bitIndex) { }

	// RVA: 0x11E36CC
	private void EnsureLength(int nRequiredLength) { }

}

// Namespace: System.Xml.Schema
internal class ChameleonKey
{
	// Fields
	internal string targetNS; // 0x10
	internal Uri chameleonLocation; // 0x18
	internal XmlSchema originalSchema; // 0x20
	private int hashCode; // 0x28

	// Methods

	// RVA: 0x11E3E48
	public void .ctor(string ns, XmlSchema originalSchema) { }

	// RVA: 0x11E3EE0
	public override int GetHashCode() { }

	// RVA: 0x11E3F70
	public override bool Equals(object obj) { }

}

// Namespace: 
public enum ConstraintRole
{
	// Fields
	public int value__; // 0x10
	public const ConstraintRole Unique = 0;
	public const ConstraintRole Key = 1;
	public const ConstraintRole Keyref = 2;
}

// Namespace: System.Xml.Schema
internal class CompiledIdentityConstraint
{
	// Fields
	internal XmlQualifiedName name; // 0x10
	private ConstraintRole role; // 0x18
	private Asttree selector; // 0x20
	private Asttree[] fields; // 0x28
	internal XmlQualifiedName refer; // 0x30
	public static readonly CompiledIdentityConstraint Empty; // 0x0

	// Methods

	// RVA: 0x11E407C
	public ConstraintRole get_Role() { }

	// RVA: 0x11E4084
	public Asttree get_Selector() { }

	// RVA: 0x11E408C
	public Asttree[] get_Fields() { }

	// RVA: 0x11E4094
	private void .ctor() { }

	// RVA: 0x11E4128
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11E46A4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class ConstraintStruct
{
	// Fields
	internal CompiledIdentityConstraint constraint; // 0x10
	internal SelectorActiveAxis axisSelector; // 0x18
	internal ArrayList axisFields; // 0x20
	internal Hashtable qualifiedTable; // 0x28
	internal Hashtable keyrefTable; // 0x30
	private int tableDim; // 0x38

	// Methods

	// RVA: 0x11E4784
	internal int get_TableDim() { }

	// RVA: 0x11E478C
	internal void .ctor(CompiledIdentityConstraint constraint) { }

}

// Namespace: System.Xml.Schema
internal class LocatedActiveAxis
{
	// Fields
	private int column; // 0x28
	internal bool isMatched; // 0x2C
	internal KeySequence Ks; // 0x30

	// Methods

	// RVA: 0x11E49C8
	internal int get_Column() { }

	// RVA: 0x11E49D0
	internal void .ctor(Asttree astfield, KeySequence ks, int column) { }

	// RVA: 0x11E4A18
	internal void Reactivate(KeySequence ks) { }

}

// Namespace: System.Xml.Schema
internal class SelectorActiveAxis
{
	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Methods

	// RVA: 0x11E4A30
	public int get_lastDepth() { }

	// RVA: 0x11E4930
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0x11E4AE4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0x11E4B38
	public int PushKS(int errline, int errcol) { }

	// RVA: 0x11E5014
	public KeySequence PopKS() { }

}

// Namespace: System.Xml.Schema
internal class KSStruct
{
	// Fields
	public int depth; // 0x10
	public KeySequence ks; // 0x18
	public LocatedActiveAxis[] fields; // 0x20

	// Methods

	// RVA: 0x11E4F84
	public void .ctor(KeySequence ks, int dim) { }

}

// Namespace: 
private class DecimalStruct
{
	// Fields
	private bool isDecimal; // 0x10
	private Decimal[] dvalue; // 0x18

	// Methods

	// RVA: 0x11E5B74
	public bool get_IsDecimal() { }

	// RVA: 0x11E5B7C
	public void set_IsDecimal(bool value) { }

	// RVA: 0x11E5B84
	public Decimal[] get_Dvalue() { }

	// RVA: 0x11E56F4
	public void .ctor() { }

	// RVA: 0x11E5680
	public void .ctor(int dim) { }

}

// Namespace: System.Xml.Schema
internal class TypedObject
{
	// Fields
	private DecimalStruct dstruct; // 0x10
	private object ovalue; // 0x18
	private string svalue; // 0x20
	private XmlSchemaDatatype xsdtype; // 0x28
	private int dim; // 0x30
	private bool isList; // 0x34

	// Methods

	// RVA: 0x11E50B8
	public int get_Dim() { }

	// RVA: 0x11E50C0
	public bool get_IsList() { }

	// RVA: 0x11E50C8
	public bool get_IsDecimal() { }

	// RVA: 0x11E50E8
	public Decimal[] get_Dvalue() { }

	// RVA: 0x11E5108
	public object get_Value() { }

	// RVA: 0x11E5110
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0x11E5118
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x11E52B8
	public override string ToString() { }

	// RVA: 0x11E52C0
	public void SetDecimal() { }

	// RVA: 0x11E5764
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0x11E5898
	public bool Equals(TypedObject other) { }

}

// Namespace: System.Xml.Schema
internal class KeySequence
{
	// Fields
	private TypedObject[] ks; // 0x10
	private int dim; // 0x18
	private int hashcode; // 0x1C
	private int posline; // 0x20
	private int poscol; // 0x24

	// Methods

	// RVA: 0x11E4EEC
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x11E5B8C
	public int get_PosLine() { }

	// RVA: 0x11E5B94
	public int get_PosCol() { }

	// RVA: 0x11E5B9C
	public object get_Item(int index) { }

	// RVA: 0x11E5BD0
	public void set_Item(int index, object value) { }

	// RVA: 0x11E5CD0
	internal bool IsQualified() { }

	// RVA: 0x11E5D58
	public override int GetHashCode() { }

	// RVA: 0x11E60C0
	public override bool Equals(object other) { }

	// RVA: 0x11E61BC
	public override string ToString() { }

}

// Namespace: System.Xml.Schema
internal class UpaException
{
	// Fields
	private object particle1; // 0x90
	private object particle2; // 0x98

	// Methods

	// RVA: 0x11E62F4
	public void .ctor(object particle1, object particle2) { }

	// RVA: 0x11E6388
	public object get_Particle1() { }

	// RVA: 0x11E6390
	public object get_Particle2() { }

}

// Namespace: System.Xml.Schema
internal class SymbolsDictionary
{
	// Fields
	private int last; // 0x10
	private Hashtable names; // 0x18
	private Hashtable wildcards; // 0x20
	private ArrayList particles; // 0x28
	private object particleLast; // 0x30
	private bool isUpaEnforced; // 0x38

	// Methods

	// RVA: 0x11E6398
	public void .ctor() { }

	// RVA: 0x11E6450
	public int get_Count() { }

	// RVA: 0x11E645C
	public bool get_IsUpaEnforced() { }

	// RVA: 0x11E6464
	public void set_IsUpaEnforced(bool value) { }

	// RVA: 0x11E646C
	public int AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x11E65AC
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	// RVA: 0x11E694C
	private void AddWildcard(string wildcard, object particle) { }

	// RVA: 0x11E6ADC
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0x11E7260
	public int get_Item(XmlQualifiedName name) { }

	// RVA: 0x11E7364
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x11E7398
	public object GetParticle(int symbol) { }

	// RVA: 0x11E73D8
	public string NameOf(int symbol) { }

}

// Namespace: System.Xml.Schema
internal struct Position
{
	// Fields
	public int symbol; // 0x10
	public object particle; // 0x18

	// Methods

	// RVA: 0x11E7A94
	public void .ctor(int symbol, object particle) { }

}

// Namespace: System.Xml.Schema
internal class Positions
{
	// Fields
	private ArrayList positions; // 0x10

	// Methods

	// RVA: 0x11E7AA4
	public int Add(int symbol, object particle) { }

	// RVA: 0x11E7B58
	public Position get_Item(int pos) { }

	// RVA: 0x11E7BF4
	public int get_Count() { }

	// RVA: 0x11E7C1C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class SyntaxTreeNode
{
	// Methods

	// RVA: -1
	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: -1
	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: -1
	public abstract bool get_IsNullable() { }

	// RVA: 0x11E7C94
	public virtual bool get_IsRangeNode() { }

	// RVA: 0x11E7C9C
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class LeafNode
{
	// Fields
	private int pos; // 0x10

	// Methods

	// RVA: 0x11E7CA4
	public void .ctor(int pos) { }

	// RVA: 0x11E7CD0
	public int get_Pos() { }

	// RVA: 0x11E7CD8
	public void set_Pos(int value) { }

	// RVA: 0x11E7CE0
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11E7CE4
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11E7DA8
	public override bool get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal class NamespaceListNode
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Methods

	// RVA: 0x11E7DB0
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0x11E7E00
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0x11E7E24
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11E8358
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11E8398
	public override bool get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal abstract class InteriorNode
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Methods

	// RVA: 0x11E83D8
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x11E83E0
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x11E83E8
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x11E83F0
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0x11E83F8
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11E8634
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11E86A8
	protected void .ctor() { }

}

// Namespace: 
private struct SequenceConstructPosContext
{
	// Fields
	public SequenceNode this_; // 0x10
	public BitSet firstpos; // 0x18
	public BitSet lastpos; // 0x20
	public BitSet lastposLeft; // 0x28
	public BitSet firstposRight; // 0x30

	// Methods

	// RVA: 0x11E8E00
	public void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

}

// Namespace: System.Xml.Schema
internal sealed class SequenceNode
{
	// Methods

	// RVA: 0x11E86B0
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11E8E70
	public override bool get_IsNullable() { }

	// RVA: 0x11E8FC4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11E8FC8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class ChoiceNode
{
	// Methods

	// RVA: 0x11E8FD0
	private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11E9144
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11E92F4
	public override bool get_IsNullable() { }

	// RVA: 0x11E9388
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11E8350
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class PlusNode
{
	// Methods

	// RVA: 0x11E938C
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11E94F4
	public override bool get_IsNullable() { }

	// RVA: 0x11E9518
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class QmarkNode
{
	// Methods

	// RVA: 0x11E9520
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11E9544
	public override bool get_IsNullable() { }

	// RVA: 0x11E954C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class StarNode
{
	// Methods

	// RVA: 0x11E9554
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11E96BC
	public override bool get_IsNullable() { }

	// RVA: 0x11E96C4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class LeafRangeNode
{
	// Fields
	private Decimal min; // 0x18
	private Decimal max; // 0x28
	private BitSet nextIteration; // 0x38

	// Methods

	// RVA: 0x11E96CC
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0x11E9720
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0x11E9774
	public Decimal get_Max() { }

	// RVA: 0x11E9780
	public Decimal get_Min() { }

	// RVA: 0x11E978C
	public BitSet get_NextIteration() { }

	// RVA: 0x11E9794
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x11E979C
	public override bool get_IsRangeNode() { }

	// RVA: 0x11E97A4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

}

// Namespace: System.Xml.Schema
internal class ContentValidator
{
	// Fields
	private XmlSchemaContentType contentType; // 0x10
	private bool isOpen; // 0x14
	private bool isEmptiable; // 0x15
	public static readonly ContentValidator Empty; // 0x0
	public static readonly ContentValidator TextOnly; // 0x8
	public static readonly ContentValidator Mixed; // 0x10
	public static readonly ContentValidator Any; // 0x18

	// Methods

	// RVA: 0x11E97E4
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x11E9818
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x11E985C
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x11E9864
	public bool get_PreserveWhitespace() { }

	// RVA: 0x11E9878
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x11E9880
	public bool get_IsOpen() { }

	// RVA: 0x11E98A4
	public void set_IsOpen(bool value) { }

	// RVA: 0x11E98AC
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x11E98B0
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11E98E4
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11E98EC
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11E98F4
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x11E98FC
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x11E9978
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x11E9BAC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class ParticleContentValidator
{
	// Fields
	private SymbolsDictionary symbols; // 0x18
	private Positions positions; // 0x20
	private Stack stack; // 0x28
	private SyntaxTreeNode contentNode; // 0x30
	private bool isPartial; // 0x38
	private int minMaxNodesCount; // 0x3C
	private bool enableUpaCheck; // 0x40

	// Methods

	// RVA: 0x11E9CC4
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x11E9D40
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0x11E9DC8
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x11E9E08
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11E9E48
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11E9E88
	public void Start() { }

	// RVA: 0x11E9FB8
	public void OpenGroup() { }

	// RVA: 0x11E9FE4
	public void CloseGroup() { }

	// RVA: 0x11EA170
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x11EA1AC
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x11EA3D4
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0x11EA2D0
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0x11EA480
	public void AddChoice() { }

	// RVA: 0x11EA578
	public void AddSequence() { }

	// RVA: 0x11EA670
	public void AddStar() { }

	// RVA: 0x11EA878
	public void AddPlus() { }

	// RVA: 0x11EA8E0
	public void AddQMark() { }

	// RVA: 0x11EA948
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0x11EA6D8
	private void Closure(InteriorNode node) { }

	// RVA: 0x11EAAB8
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0x11EB250
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, BitSet posWithRangeTerminals) { }

	// RVA: 0x11EBB70
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0x11EB874
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0x11EBDCC
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0x11EC838
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0x11EBE78
	private Int32[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

}

// Namespace: System.Xml.Schema
internal sealed class DfaContentValidator
{
	// Fields
	private Int32[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x11EC784
	internal void .ctor(Int32[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x11ECAF8
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x11ECB60
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11ECCC4
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11ECCE0
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11ECEE0
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

// Namespace: System.Xml.Schema
internal sealed class NfaContentValidator
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private int endMarkerPos; // 0x38

	// Methods

	// RVA: 0x11ED0E4
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x11ED1E0
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x11ED2B8
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11ED470
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11ED4BC
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11ED6B8
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

// Namespace: System.Xml.Schema
internal struct RangePositionInfo
{
	// Fields
	public BitSet curpos; // 0x10
	public Decimal[] rangeCounters; // 0x18
}

// Namespace: System.Xml.Schema
internal sealed class RangeContentValidator
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private BitSet positionsWithRangeTerminals; // 0x28
	private SymbolsDictionary symbols; // 0x30
	private Positions positions; // 0x38
	private int minMaxNodesCount; // 0x40
	private int endMarkerPos; // 0x44

	// Methods

	// RVA: 0x11ED840
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0x11ED950
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x11EDB30
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11EE418
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11EE434
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11EE6DC
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

// Namespace: System.Xml.Schema
internal sealed class AllElementsContentValidator
{
	// Fields
	private Hashtable elements; // 0x18
	private object[] particles; // 0x20
	private BitSet isRequired; // 0x28
	private int countRequired; // 0x30

	// Methods

	// RVA: 0x11EE914
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0x11EEA48
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0x11EEBA8
	public override bool get_IsEmptiable() { }

	// RVA: 0x11EEBC8
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x11EEC6C
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11EEDE0
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11EEE44
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11EF258
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaDatatypeVariety
{
	// Fields
	public int value__; // 0x10
	public const XmlSchemaDatatypeVariety Atomic = 0;
	public const XmlSchemaDatatypeVariety List = 1;
	public const XmlSchemaDatatypeVariety Union = 2;
}

// Namespace: System.Xml.Schema
internal class XsdSimpleValue
{
	// Fields
	private XmlSchemaSimpleType xmlType; // 0x10
	private object typedValue; // 0x18

	// Methods

	// RVA: 0x11EF724
	public void .ctor(XmlSchemaSimpleType st, object value) { }

	// RVA: 0x11EF774
	public XmlSchemaSimpleType get_XmlType() { }

	// RVA: 0x11EF77C
	public object get_TypedValue() { }

}

// Namespace: System.Xml.Schema
internal enum RestrictionFlags
{
	// Fields
	public int value__; // 0x10
	public const RestrictionFlags Length = 1;
	public const RestrictionFlags MinLength = 2;
	public const RestrictionFlags MaxLength = 4;
	public const RestrictionFlags Pattern = 8;
	public const RestrictionFlags Enumeration = 16;
	public const RestrictionFlags WhiteSpace = 32;
	public const RestrictionFlags MaxInclusive = 64;
	public const RestrictionFlags MaxExclusive = 128;
	public const RestrictionFlags MinInclusive = 256;
	public const RestrictionFlags MinExclusive = 512;
	public const RestrictionFlags TotalDigits = 1024;
	public const RestrictionFlags FractionDigits = 2048;
}

// Namespace: System.Xml.Schema
internal enum XmlSchemaWhiteSpace
{
	// Fields
	public int value__; // 0x10
	public const XmlSchemaWhiteSpace Preserve = 0;
	public const XmlSchemaWhiteSpace Replace = 1;
	public const XmlSchemaWhiteSpace Collapse = 2;
}

// Namespace: System.Xml.Schema
internal class RestrictionFacets
{
	// Fields
	internal int Length; // 0x10
	internal int MinLength; // 0x14
	internal int MaxLength; // 0x18
	internal ArrayList Patterns; // 0x20
	internal ArrayList Enumeration; // 0x28
	internal XmlSchemaWhiteSpace WhiteSpace; // 0x30
	internal object MaxInclusive; // 0x38
	internal object MaxExclusive; // 0x40
	internal object MinInclusive; // 0x48
	internal object MinExclusive; // 0x50
	internal int TotalDigits; // 0x58
	internal int FractionDigits; // 0x5C
	internal RestrictionFlags Flags; // 0x60
	internal RestrictionFlags FixedFlags; // 0x64

	// Methods

	// RVA: 0x11EF784
	public void .ctor() { }

}

// Namespace: 
private class SchemaDatatypeMap
{
	// Fields
	private string name; // 0x10
	private DatatypeImplementation type; // 0x18
	private int parentIndex; // 0x20

	// Methods

	// RVA: 0x11F86C8
	internal void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0x11F8718
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x11FB23C
	public static DatatypeImplementation op_Explicit(SchemaDatatypeMap sdm) { }

	// RVA: 0x11FB258
	public string get_Name() { }

	// RVA: 0x11FB260
	public int get_ParentIndex() { }

	// RVA: 0x11FB268
	public int CompareTo(object obj) { }

}

// Namespace: System.Xml.Schema
internal abstract class DatatypeImplementation
{
	// Fields
	private XmlSchemaDatatypeVariety variety; // 0x10
	private RestrictionFacets restriction; // 0x18
	private DatatypeImplementation baseType; // 0x20
	private XmlValueConverter valueConverter; // 0x28
	private XmlSchemaType parentSchemaType; // 0x30
	private static Hashtable builtinTypes; // 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; // 0x8
	private static XmlSchemaSimpleType anySimpleType; // 0x10
	private static XmlSchemaSimpleType anyAtomicType; // 0x18
	private static XmlSchemaSimpleType untypedAtomicType; // 0x20
	private static XmlSchemaSimpleType yearMonthDurationType; // 0x28
	private static XmlSchemaSimpleType dayTimeDurationType; // 0x30
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; // 0x38
	private static XmlSchemaSimpleType tokenTypeV1Compat; // 0x40
	internal static XmlQualifiedName QnAnySimpleType; // 0x48
	internal static XmlQualifiedName QnAnyType; // 0x50
	internal static FacetsChecker stringFacetsChecker; // 0x58
	internal static FacetsChecker miscFacetsChecker; // 0x60
	internal static FacetsChecker numeric2FacetsChecker; // 0x68
	internal static FacetsChecker binaryFacetsChecker; // 0x70
	internal static FacetsChecker dateTimeFacetsChecker; // 0x78
	internal static FacetsChecker durationFacetsChecker; // 0x80
	internal static FacetsChecker listFacetsChecker; // 0x88
	internal static FacetsChecker qnameFacetsChecker; // 0x90
	internal static FacetsChecker unionFacetsChecker; // 0x98
	private static readonly DatatypeImplementation c_anySimpleType; // 0xA0
	private static readonly DatatypeImplementation c_anyURI; // 0xA8
	private static readonly DatatypeImplementation c_base64Binary; // 0xB0
	private static readonly DatatypeImplementation c_boolean; // 0xB8
	private static readonly DatatypeImplementation c_byte; // 0xC0
	private static readonly DatatypeImplementation c_char; // 0xC8
	private static readonly DatatypeImplementation c_date; // 0xD0
	private static readonly DatatypeImplementation c_dateTime; // 0xD8
	private static readonly DatatypeImplementation c_dateTimeNoTz; // 0xE0
	private static readonly DatatypeImplementation c_dateTimeTz; // 0xE8
	private static readonly DatatypeImplementation c_day; // 0xF0
	private static readonly DatatypeImplementation c_decimal; // 0xF8
	private static readonly DatatypeImplementation c_double; // 0x100
	private static readonly DatatypeImplementation c_doubleXdr; // 0x108
	private static readonly DatatypeImplementation c_duration; // 0x110
	private static readonly DatatypeImplementation c_ENTITY; // 0x118
	private static readonly DatatypeImplementation c_ENTITIES; // 0x120
	private static readonly DatatypeImplementation c_ENUMERATION; // 0x128
	private static readonly DatatypeImplementation c_fixed; // 0x130
	private static readonly DatatypeImplementation c_float; // 0x138
	private static readonly DatatypeImplementation c_floatXdr; // 0x140
	private static readonly DatatypeImplementation c_hexBinary; // 0x148
	private static readonly DatatypeImplementation c_ID; // 0x150
	private static readonly DatatypeImplementation c_IDREF; // 0x158
	private static readonly DatatypeImplementation c_IDREFS; // 0x160
	private static readonly DatatypeImplementation c_int; // 0x168
	private static readonly DatatypeImplementation c_integer; // 0x170
	private static readonly DatatypeImplementation c_language; // 0x178
	private static readonly DatatypeImplementation c_long; // 0x180
	private static readonly DatatypeImplementation c_month; // 0x188
	private static readonly DatatypeImplementation c_monthDay; // 0x190
	private static readonly DatatypeImplementation c_Name; // 0x198
	private static readonly DatatypeImplementation c_NCName; // 0x1A0
	private static readonly DatatypeImplementation c_negativeInteger; // 0x1A8
	private static readonly DatatypeImplementation c_NMTOKEN; // 0x1B0
	private static readonly DatatypeImplementation c_NMTOKENS; // 0x1B8
	private static readonly DatatypeImplementation c_nonNegativeInteger; // 0x1C0
	private static readonly DatatypeImplementation c_nonPositiveInteger; // 0x1C8
	private static readonly DatatypeImplementation c_normalizedString; // 0x1D0
	private static readonly DatatypeImplementation c_NOTATION; // 0x1D8
	private static readonly DatatypeImplementation c_positiveInteger; // 0x1E0
	private static readonly DatatypeImplementation c_QName; // 0x1E8
	private static readonly DatatypeImplementation c_QNameXdr; // 0x1F0
	private static readonly DatatypeImplementation c_short; // 0x1F8
	private static readonly DatatypeImplementation c_string; // 0x200
	private static readonly DatatypeImplementation c_time; // 0x208
	private static readonly DatatypeImplementation c_timeNoTz; // 0x210
	private static readonly DatatypeImplementation c_timeTz; // 0x218
	private static readonly DatatypeImplementation c_token; // 0x220
	private static readonly DatatypeImplementation c_unsignedByte; // 0x228
	private static readonly DatatypeImplementation c_unsignedInt; // 0x230
	private static readonly DatatypeImplementation c_unsignedLong; // 0x238
	private static readonly DatatypeImplementation c_unsignedShort; // 0x240
	private static readonly DatatypeImplementation c_uuid; // 0x248
	private static readonly DatatypeImplementation c_year; // 0x250
	private static readonly DatatypeImplementation c_yearMonth; // 0x258
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; // 0x260
	internal static readonly DatatypeImplementation c_tokenV1Compat; // 0x268
	private static readonly DatatypeImplementation c_anyAtomicType; // 0x270
	private static readonly DatatypeImplementation c_dayTimeDuration; // 0x278
	private static readonly DatatypeImplementation c_untypedAtomicType; // 0x280
	private static readonly DatatypeImplementation c_yearMonthDuration; // 0x288
	private static readonly DatatypeImplementation[] c_tokenizedTypes; // 0x290
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; // 0x298
	private static readonly SchemaDatatypeMap[] c_XdrTypes; // 0x2A0
	private static readonly SchemaDatatypeMap[] c_XsdTypes; // 0x2A8

	// Methods

	// RVA: 0x11EF78C
	private static void .cctor() { }

	// RVA: 0x11F906C
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x11F90E8
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x11F9164
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x11F9204
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x11F92A4
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x11F937C
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x11F9454
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x11F953C
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x11F8774
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x11F9790
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x11F9830
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x11F9914
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x11F9B50
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x11F9D8C
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x11F9E08
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x11F9F80
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x11FA0A8
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x11F5F90
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x11FA224
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x11FA3D0
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x11FA3D4
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA6B4
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x11FA6DC
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x11FA7CC
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FA7D4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FA850
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0x11FA8B0
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11FA8B8
	public override Type get_ValueType() { }

	// RVA: 0x11FA958
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x11FA960
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FA968
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x11FA970
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x11FA998
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11FA9C0
	protected DatatypeImplementation get_Base() { }

	// RVA: -1
	internal abstract Type get_ListValueType() { }

	// RVA: -1
	internal abstract RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11FA9C8
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11FA9D0
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11FAC28
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x11FAD90
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, object typedValue) { }

	// RVA: 0x11FABB8
	internal string GetTypeName() { }

	// RVA: 0x11FB1D0
	protected int Compare(Byte[] value1, Byte[] value2) { }

	// RVA: 0x11FB234
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_List
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Methods

	// RVA: 0x11FB2E4
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FA130
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x11FB638
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11FB92C
	public override Type get_ValueType() { }

	// RVA: 0x11FB93C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11FB960
	internal override Type get_ListValueType() { }

	// RVA: 0x11FB988
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FBA04
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FBA28
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11FBA30
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, object typedValue) { }

	// RVA: 0x11FC32C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

}

// Namespace: System.Xml.Schema
internal class Datatype_union
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

	// Methods

	// RVA: 0x11FC848
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FA2F0
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x11FC854
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11FC95C
	public override Type get_ValueType() { }

	// RVA: 0x11FC9D8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FC9E0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FCA5C
	internal override Type get_ListValueType() { }

	// RVA: 0x11FCAD8
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11FCAE0
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x11FA0B4
	internal bool HasAtomicMembers() { }

	// RVA: 0x11FA60C
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x11FCAE8
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11FCD08
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11FD1F4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anySimpleType
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11FD2D0
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FD34C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FD3C8
	public override Type get_ValueType() { }

	// RVA: 0x11FD444
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FD44C
	internal override Type get_ListValueType() { }

	// RVA: 0x11FD4C8
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11FD4D0
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11FD4D8
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11FD4E0
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11FD540
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F4FB0
	public void .ctor() { }

	// RVA: 0x11FD57C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyAtomicType
{
	// Methods

	// RVA: 0x11FD658
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FD6D4
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11FD6DC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F8298
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_untypedAtomicType
{
	// Methods

	// RVA: 0x11FD6E4
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FD760
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11FD768
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F84B0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_string
{
	// Methods

	// RVA: 0x11FD770
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FD77C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11FD784
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FD800
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FD808
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11FD810
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11FD818
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F7540
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_boolean
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11FD924
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FD930
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FD9AC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FD9B4
	public override Type get_ValueType() { }

	// RVA: 0x11FDA30
	internal override Type get_ListValueType() { }

	// RVA: 0x11FDAAC
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11FDAB4
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11FDABC
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11FDB68
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F51F8
	public void .ctor() { }

	// RVA: 0x11FDCB8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_float
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11FDD94
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FDDA0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FDE1C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FDE24
	public override Type get_ValueType() { }

	// RVA: 0x11FDEA0
	internal override Type get_ListValueType() { }

	// RVA: 0x11FDF1C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11FDF24
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11FDF2C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11FDFC8
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F638C
	public void .ctor() { }

	// RVA: 0x11FE150
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_double
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11FE22C
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FE238
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FE2B4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FE2BC
	public override Type get_ValueType() { }

	// RVA: 0x11FE338
	internal override Type get_ListValueType() { }

	// RVA: 0x11FE3B4
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11FE3BC
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11FE3C4
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11FE460
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F5BB8
	public void .ctor() { }

	// RVA: 0x11FE5E8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_decimal
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x11FE6C4
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FE6D0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FE74C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FE754
	public override Type get_ValueType() { }

	// RVA: 0x11FE7D0
	internal override Type get_ListValueType() { }

	// RVA: 0x11FE84C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11FE854
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11FE85C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11FE934
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F5AD8
	public void .ctor() { }

	// RVA: 0x11FEAD4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_duration
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11FECD0
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FECDC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FED58
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FED60
	public override Type get_ValueType() { }

	// RVA: 0x11FEDDC
	internal override Type get_ListValueType() { }

	// RVA: 0x11FEE58
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11FEE60
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11FEE68
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11FEF14
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F5DD0
	public void .ctor() { }

	// RVA: 0x11FF124
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonthDuration
{
	// Methods

	// RVA: 0x11FF200
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11FF414
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F8590
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dayTimeDuration
{
	// Methods

	// RVA: 0x11FF41C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11FF630
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F8378
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeBase
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

	// Methods

	// RVA: 0x11FF638
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FF644
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FF6C0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FF6C8
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x11FF7A0
	public override Type get_ValueType() { }

	// RVA: 0x11FF81C
	internal override Type get_ListValueType() { }

	// RVA: 0x11FF898
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11FF8A0
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11FF8A8
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11FFA28
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11FFDB0
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeNoTimeZone
{
	// Methods

	// RVA: 0x11F5748
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeTimeZone
{
	// Methods

	// RVA: 0x11F5878
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTime
{
	// Methods

	// RVA: 0x11F5618
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeNoTimeZone
{
	// Methods

	// RVA: 0x11F7750
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeTimeZone
{
	// Methods

	// RVA: 0x11F7880
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_time
{
	// Methods

	// RVA: 0x11FFE8C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F7620
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_date
{
	// Methods

	// RVA: 0x11FFE94
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F54E8
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonth
{
	// Methods

	// RVA: 0x11FFE9C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F7FA8
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_year
{
	// Methods

	// RVA: 0x11FFEA4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F7E78
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_monthDay
{
	// Methods

	// RVA: 0x11FFEAC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F6C10
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_day
{
	// Methods

	// RVA: 0x11FFEB4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F59A8
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_month
{
	// Methods

	// RVA: 0x11FFEBC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F6AE0
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_hexBinary
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11FFEC4
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11FFED0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11FFF4C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11FFF54
	public override Type get_ValueType() { }

	// RVA: 0x11FFFD0
	internal override Type get_ListValueType() { }

	// RVA: 0x120004C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1200054
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x120005C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1200170
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F65A4
	public void .ctor() { }

	// RVA: 0x1200364
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_base64Binary
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1200440
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x120044C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x12004C8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12004D0
	public override Type get_ValueType() { }

	// RVA: 0x120054C
	internal override Type get_ListValueType() { }

	// RVA: 0x12005C8
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x12005D0
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x12005D8
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x12006EC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F5118
	public void .ctor() { }

	// RVA: 0x12008DC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyURI
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x12009B8
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x12009C4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1200A40
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1200A48
	public override Type get_ValueType() { }

	// RVA: 0x1200AC4
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1200ACC
	internal override Type get_ListValueType() { }

	// RVA: 0x1200B48
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1200B50
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1200B58
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1200C24
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F5038
	public void .ctor() { }

	// RVA: 0x1201048
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QName
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1201124
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1201130
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x12011AC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12011B4
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x12011BC
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x12011C4
	public override Type get_ValueType() { }

	// RVA: 0x1201240
	internal override Type get_ListValueType() { }

	// RVA: 0x12012BC
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x12012C4
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F72A8
	public void .ctor() { }

	// RVA: 0x1201524
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedString
{
	// Methods

	// RVA: 0x1201600
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1201608
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1201610
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11F7068
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedStringV1Compat
{
	// Methods

	// RVA: 0x1201618
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1201620
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11F80D8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_token
{
	// Methods

	// RVA: 0x1201628
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1201630
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11F79B0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_tokenV1Compat
{
	// Methods

	// RVA: 0x1201638
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F81B8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_language
{
	// Methods

	// RVA: 0x1201640
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F69FC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NMTOKEN
{
	// Methods

	// RVA: 0x1201648
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1201650
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11F6F80
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_Name
{
	// Methods

	// RVA: 0x1201658
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F6D40
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NCName
{
	// Methods

	// RVA: 0x1201660
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1201668
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F6E20
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ID
{
	// Methods

	// RVA: 0x120179C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12017A4
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11F6684
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_IDREF
{
	// Methods

	// RVA: 0x12017AC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12017B4
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11F6764
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENTITY
{
	// Methods

	// RVA: 0x12017BC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12017C4
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11F5EB0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NOTATION
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x12017CC
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x12017D8
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1201854
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x120185C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1201864
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x120186C
	public override Type get_ValueType() { }

	// RVA: 0x12018E8
	internal override Type get_ListValueType() { }

	// RVA: 0x1201964
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x120196C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1201BCC
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x11F7148
	public void .ctor() { }

	// RVA: 0x1201E6C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_integer
{
	// Methods

	// RVA: 0x1201F48
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1201F50
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F68C4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonPositiveInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x12020CC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1202148
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1202150
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11F7064
	public void .ctor() { }

	// RVA: 0x1202158
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_negativeInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x1202280
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x12022FC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F6F00
	public void .ctor() { }

	// RVA: 0x1202304
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_long
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x120242C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x12024A8
	internal override bool get_HasValueFacets() { }

	// RVA: 0x12024B0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12024B8
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1202554
	public override Type get_ValueType() { }

	// RVA: 0x12025D0
	internal override Type get_ListValueType() { }

	// RVA: 0x120264C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F6ADC
	public void .ctor() { }

	// RVA: 0x12027D4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_int
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x1202964
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x12029E0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12029E8
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1202A84
	public override Type get_ValueType() { }

	// RVA: 0x1202B00
	internal override Type get_ListValueType() { }

	// RVA: 0x1202B7C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F6844
	public void .ctor() { }

	// RVA: 0x1202D04
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_short
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x1202E94
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1202F10
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1202F18
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1202FB4
	public override Type get_ValueType() { }

	// RVA: 0x1203030
	internal override Type get_ListValueType() { }

	// RVA: 0x12030AC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F7468
	public void .ctor() { }

	// RVA: 0x1203234
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_byte
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x12033C4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1203440
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1203448
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x12034E4
	public override Type get_ValueType() { }

	// RVA: 0x1203560
	internal override Type get_ListValueType() { }

	// RVA: 0x12035DC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F52D8
	public void .ctor() { }

	// RVA: 0x1203764
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonNegativeInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x12038F4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1203970
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1203978
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11F7060
	public void .ctor() { }

	// RVA: 0x1203980
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedLong
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x1203AA8
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1203B24
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1203B2C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1203BC8
	public override Type get_ValueType() { }

	// RVA: 0x1203C44
	internal override Type get_ListValueType() { }

	// RVA: 0x1203CC0
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F7BE8
	public void .ctor() { }

	// RVA: 0x1203E8C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedInt
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x1204034
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x12040B0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12040B8
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1204154
	public override Type get_ValueType() { }

	// RVA: 0x12041D0
	internal override Type get_ListValueType() { }

	// RVA: 0x120424C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F7B10
	public void .ctor() { }

	// RVA: 0x12043D4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedShort
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x120457C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x12045F8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1204600
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x120469C
	public override Type get_ValueType() { }

	// RVA: 0x1204718
	internal override Type get_ListValueType() { }

	// RVA: 0x1204794
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F7C68
	public void .ctor() { }

	// RVA: 0x120491C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedByte
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x1204AC4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1204B40
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1204B48
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1204BE4
	public override Type get_ValueType() { }

	// RVA: 0x1204C60
	internal override Type get_ListValueType() { }

	// RVA: 0x1204CDC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F7A90
	public void .ctor() { }

	// RVA: 0x1204E64
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_positiveInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x120500C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1205088
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F7228
	public void .ctor() { }

	// RVA: 0x1205090
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_doubleXdr
{
	// Methods

	// RVA: 0x12051B8
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11F5C98
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_floatXdr
{
	// Methods

	// RVA: 0x12053B0
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11F646C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QNameXdr
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x12055A8
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x12055B0
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1205840
	public override Type get_ValueType() { }

	// RVA: 0x12058BC
	internal override Type get_ListValueType() { }

	// RVA: 0x11F7388
	public void .ctor() { }

	// RVA: 0x1205938
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENUMERATION
{
	// Methods

	// RVA: 0x1205A14
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11F6174
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_char
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1205A1C
	public override Type get_ValueType() { }

	// RVA: 0x1205A98
	internal override Type get_ListValueType() { }

	// RVA: 0x1205B14
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1205B1C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1205BC8
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1205DA4
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F5408
	public void .ctor() { }

	// RVA: 0x1205EA4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_fixed
{
	// Methods

	// RVA: 0x1205F80
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x120650C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F6254
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_uuid
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x12066A0
	public override Type get_ValueType() { }

	// RVA: 0x120671C
	internal override Type get_ListValueType() { }

	// RVA: 0x1206798
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x12067A0
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1206840
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1206A1C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F7D98
	public void .ctor() { }

	// RVA: 0x1206B1C
	private static void .cctor() { }

}

// Namespace: 
private class NamespaceManager
{
	// Methods

	// RVA: 0x12093BC
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x12093B4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class DtdValidator
{
	// Fields
	private static NamespaceManager namespaceManager; // 0x0
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private Hashtable IDs; // 0x98
	private IdRefNode idRefListHead; // 0xA0
	private bool processIdentityConstraints; // 0xA8

	// Methods

	// RVA: 0x1206BF8
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x1206CA0
	private void Init() { }

	// RVA: 0x1206F58
	public override void Validate() { }

	// RVA: 0x1207274
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x1207320
	private void ValidatePIComment() { }

	// RVA: 0x1207154
	private void ValidateElement() { }

	// RVA: 0x120776C
	private void ValidateChildElement() { }

	// RVA: 0x12079DC
	private void ValidateStartElement() { }

	// RVA: 0x12083F0
	private void ValidateEndStartElement() { }

	// RVA: 0x12078B0
	private void ProcessElement() { }

	// RVA: 0x12085D4
	public override void CompleteValidation() { }

	// RVA: 0x12075AC
	private void ValidateEndElement() { }

	// RVA: 0x1208814
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1208850
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1207E3C
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1208ADC
	internal void AddID(string name, object node) { }

	// RVA: 0x1208B7C
	public override object FindId(string name) { }

	// RVA: 0x12073F0
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x1208B98
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x12086E8
	private void CheckForwardRefs() { }

	// RVA: 0x1206E10
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x120862C
	private bool Pop() { }

	// RVA: 0x1208C44
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x1208F54
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x120932C
	private static void .cctor() { }

}

// Namespace: 
private struct Map
{
	// Fields
	internal Char match; // 0x10
	internal string replacement; // 0x18

	// Methods

	// RVA: 0x120E0BC
	internal void .ctor(Char m, string r) { }

}

// Namespace: 
private struct FacetsCompiler
{
	// Fields
	private DatatypeImplementation datatype; // 0x10
	private RestrictionFacets derivedRestriction; // 0x18
	private RestrictionFlags baseFlags; // 0x20
	private RestrictionFlags baseFixedFlags; // 0x24
	private RestrictionFlags validRestrictionFlags; // 0x28
	private XmlSchemaDatatype nonNegativeInt; // 0x30
	private XmlSchemaDatatype builtInType; // 0x38
	private XmlTypeCode builtInEnum; // 0x40
	private bool firstPattern; // 0x44
	private StringBuilder regStr; // 0x48
	private XmlSchemaPatternFacet pattern_facet; // 0x50
	private static readonly Map[] c_map; // 0x0

	// Methods

	// RVA: 0x1209B14
	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x1209E58
	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x120A288
	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x120A67C
	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x120AA70
	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x120ACA8
	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x120AEAC
	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x120B858
	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x120BAF8
	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x120B318
	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x120B5B8
	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x120BD98
	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x120C21C
	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x120C5A4
	internal void FinishFacetCompile() { }

	// RVA: 0x120D134
	private void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x120C948
	internal void CompileFacetCombinations() { }

	// RVA: 0x120D84C
	private void CopyFacetsFromBaseType() { }

	// RVA: 0x120CF78
	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x120D5CC
	private static string Preprocess(string pattern) { }

	// RVA: 0x120CE6C
	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x120CEFC
	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x120D0C8
	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x120DD64
	private void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x120DDA4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class FacetsChecker
{
	// Methods

	// RVA: 0x12093C4
	internal virtual Exception CheckLexicalFacets(string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x1209684
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120968C
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1209694
	internal virtual Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120969C
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x12096A4
	internal virtual Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x12096AC
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x12096B4
	internal virtual Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x12096BC
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x12096C4
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x12096CC
	internal virtual Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x12096D4
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x12096DC
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120940C
	internal void CheckWhitespaceFacets(string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x1209514
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x12096E4
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x12096EC
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x120CD28
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x120CE64
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Numeric10FacetsChecker
{
	// Fields
	private static readonly Char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0x11FEC84
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0x120E0CC
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120E148
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120E8BC
	internal override Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120E954
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120E9EC
	internal override Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120EA84
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x120E774
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x120625C
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0x120EB08
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Numeric2FacetsChecker
{
	// Methods

	// RVA: 0x120EBAC
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120EC18
	internal override Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120F08C
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120F09C
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x120EFA8
	private bool MatchEnumeration(Double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x11F4F98
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DurationFacetsChecker
{
	// Methods

	// RVA: 0x120F1C4
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120F2E0
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120F788
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x120F670
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x11F4FA8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DateTimeFacetsChecker
{
	// Methods

	// RVA: 0x120F80C
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120F87C
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120FE24
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x120FC70
	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11F4FA0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class StringFacetsChecker
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Methods

	// RVA: 0x120FE8C
	private static Regex get_LanguagePattern() { }

	// RVA: 0x120FF5C
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120FFC8
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1200DD8
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0x1210508
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x121028C
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x120FFD0
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x11F4F90
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class QNameFacetsChecker
{
	// Methods

	// RVA: 0x1053F08
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x105403C
	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1054398
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1054244
	private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

	// RVA: 0x10544B4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class MiscFacetsChecker
{
	// Methods

	// RVA: 0x10544BC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class BinaryFacetsChecker
{
	// Methods

	// RVA: 0x10544C4
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1054558
	internal override Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1054894
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x105474C
	private bool MatchEnumeration(Byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1054934
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class ListFacetsChecker
{
	// Methods

	// RVA: 0x105493C
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1054BB0
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1054C94
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class UnionFacetsChecker
{
	// Methods

	// RVA: 0x1054C9C
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1054DA8
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1054E8C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public interface IXmlSchemaInfo
{
	// Methods

	// RVA: -1
	public abstract XmlSchemaValidity get_Validity() { }

	// RVA: -1
	public abstract bool get_IsDefault() { }

	// RVA: -1
	public abstract bool get_IsNil() { }

	// RVA: -1
	public abstract XmlSchemaSimpleType get_MemberType() { }

	// RVA: -1
	public abstract XmlSchemaType get_SchemaType() { }

	// RVA: -1
	public abstract XmlSchemaElement get_SchemaElement() { }

	// RVA: -1
	public abstract XmlSchemaAttribute get_SchemaAttribute() { }

}

// Namespace: 
public enum InferenceOption
{
	// Fields
	public int value__; // 0x10
	public const InferenceOption Restricted = 0;
	public const InferenceOption Relaxed = 1;
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaInference
{
	// Fields
	internal static XmlQualifiedName ST_boolean; // 0x0
	internal static XmlQualifiedName ST_byte; // 0x8
	internal static XmlQualifiedName ST_unsignedByte; // 0x10
	internal static XmlQualifiedName ST_short; // 0x18
	internal static XmlQualifiedName ST_unsignedShort; // 0x20
	internal static XmlQualifiedName ST_int; // 0x28
	internal static XmlQualifiedName ST_unsignedInt; // 0x30
	internal static XmlQualifiedName ST_long; // 0x38
	internal static XmlQualifiedName ST_unsignedLong; // 0x40
	internal static XmlQualifiedName ST_integer; // 0x48
	internal static XmlQualifiedName ST_decimal; // 0x50
	internal static XmlQualifiedName ST_float; // 0x58
	internal static XmlQualifiedName ST_double; // 0x60
	internal static XmlQualifiedName ST_duration; // 0x68
	internal static XmlQualifiedName ST_dateTime; // 0x70
	internal static XmlQualifiedName ST_time; // 0x78
	internal static XmlQualifiedName ST_date; // 0x80
	internal static XmlQualifiedName ST_gYearMonth; // 0x88
	internal static XmlQualifiedName ST_string; // 0x90
	internal static XmlQualifiedName ST_anySimpleType; // 0x98
	internal static XmlQualifiedName[] SimpleTypes; // 0xA0
	private XmlSchema rootSchema; // 0x10
	private XmlSchemaSet schemaSet; // 0x18
	private XmlReader xtr; // 0x20
	private NameTable nametable; // 0x28
	private string TargetNamespace; // 0x30
	private XmlNamespaceManager NamespaceManager; // 0x38
	private ArrayList schemaList; // 0x40
	private InferenceOption occurrence; // 0x48
	private InferenceOption typeInference; // 0x4C

	// Methods

	// RVA: 0x1054E94
	public void set_Occurrence(InferenceOption value) { }

	// RVA: 0x1054E9C
	public InferenceOption get_Occurrence() { }

	// RVA: 0x1054EA4
	public void set_TypeInference(InferenceOption value) { }

	// RVA: 0x1054EAC
	public void .ctor() { }

	// RVA: 0x1054FEC
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x1055064
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x105761C
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x105A0A8
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x1055B20
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x1056158
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x105ADEC
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x105A4E4
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x105B3BC
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, int lastUsedSeqItem, bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x105A620
	internal void ProcessAttributes(XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x105B308
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x105AF28
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x105826C
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x105A148
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, XmlSchema parentSchema) { }

	// RVA: 0x105C534
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x1057EB8
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x105C690
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x105AD44
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x105CAFC
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x10585DC
	internal XmlQualifiedName RefineSimpleType(string s, int iTypeFlags) { }

	// RVA: 0x105CCA8
	internal static int InferSimpleType(string s, bool bNeedsRangeCheck) { }

	// RVA: 0x105E10C
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x105C814
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x105974C
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x105C364
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x105E254
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaInferenceException
{
	// Methods

	// RVA: 0x105ED3C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x105ED44
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x105ED4C
	public void .ctor() { }

	// RVA: 0x105CA3C
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1055AE8
	internal void .ctor(string res, int lineNumber, int linePosition) { }

}

// Namespace: 
public enum ListType
{
	// Fields
	public int value__; // 0x10
	public const ListType Any = 0;
	public const ListType Other = 1;
	public const ListType Set = 2;
}

// Namespace: System.Xml.Schema
internal class NamespaceList
{
	// Fields
	private ListType type; // 0x10
	private Hashtable set; // 0x18
	private string targetNamespace; // 0x20

	// Methods

	// RVA: 0x105ED58
	public void .ctor() { }

	// RVA: 0x105ED60
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x105F00C
	public NamespaceList Clone() { }

	// RVA: 0x105F150
	public ListType get_Type() { }

	// RVA: 0x105F158
	public string get_Excluded() { }

	// RVA: 0x105F160
	public ICollection get_Enumerate() { }

	// RVA: 0x105F1D0
	public virtual bool Allows(string ns) { }

	// RVA: 0x105F270
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x105F294
	public override string ToString() { }

	// RVA: 0x105F774
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0x105FB40
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x106009C
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0x1060218
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x1060820
	private void RemoveNamespace(string tns) { }

}

// Namespace: System.Xml.Schema
internal class NamespaceListV1Compat
{
	// Methods

	// RVA: 0x1060884
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x1060888
	public override bool Allows(string ns) { }

}

// Namespace: System.Xml.Schema
internal sealed class Parser
{
	// Fields
	private SchemaType schemaType; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ValidationEventHandler eventHandler; // 0x28
	private XmlNamespaceManager namespaceManager; // 0x30
	private XmlReader reader; // 0x38
	private PositionInfo positionInfo; // 0x40
	private bool isProcessNamespaces; // 0x48
	private int schemaXmlDepth; // 0x4C
	private int markupDepth; // 0x50
	private SchemaBuilder builder; // 0x58
	private XmlSchema schema; // 0x60
	private SchemaInfo xdrSchema; // 0x68
	private XmlResolver xmlResolver; // 0x70
	private XmlDocument dummyDocument; // 0x78
	private bool processMarkup; // 0x80
	private XmlNode parentNode; // 0x88
	private XmlNamespaceManager annotationNSManager; // 0x90
	private string xmlns; // 0x98
	private XmlCharType xmlCharType; // 0xA0

	// Methods

	// RVA: 0x1060904
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1060A0C
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0x1060A70
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0x1061580
	private bool CheckSchemaRoot(SchemaType rootType, string code) { }

	// RVA: 0x10616D8
	public SchemaType FinishParsing() { }

	// RVA: 0x10616E0
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x10616E8
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10616F0
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0x1060EA8
	public bool ParseReaderNode() { }

	// RVA: 0x10616F8
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0x1061940
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0x1061FA4
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0x1061DC0
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x10620D4
	private XmlEntityReference LoadEntityReferenceInAttribute() { }

}

// Namespace: System.Xml.Schema
internal enum Compositor
{
	// Fields
	public int value__; // 0x10
	public const Compositor Root = 0;
	public const Compositor Include = 1;
	public const Compositor Import = 2;
	public const Compositor Redefine = 3;
}

// Namespace: System.Xml.Schema
internal class RedefineEntry
{
	// Fields
	internal XmlSchemaRedefine redefine; // 0x10
	internal XmlSchema schemaToUpdate; // 0x18

	// Methods

	// RVA: 0x10622FC
	public void .ctor(XmlSchemaRedefine external, XmlSchema schema) { }

}

// Namespace: System.Xml.Schema
internal sealed class Preprocessor
{
	// Fields
	private string Xmlns; // 0x40
	private string NsXsi; // 0x48
	private string targetNamespace; // 0x50
	private XmlSchema rootSchema; // 0x58
	private XmlSchema currentSchema; // 0x60
	private XmlSchemaForm elementFormDefault; // 0x68
	private XmlSchemaForm attributeFormDefault; // 0x6C
	private XmlSchemaDerivationMethod blockDefault; // 0x70
	private XmlSchemaDerivationMethod finalDefault; // 0x74
	private Hashtable schemaLocations; // 0x78
	private Hashtable chameleonSchemas; // 0x80
	private Hashtable referenceNamespaces; // 0x88
	private Hashtable processedExternals; // 0x90
	private SortedList lockList; // 0x98
	private XmlReaderSettings readerSettings; // 0xA0
	private XmlSchema rootSchemaForRedefine; // 0xA8
	private ArrayList redefinedList; // 0xB0
	private static XmlSchema builtInSchemaForXmlNS; // 0x0
	private XmlResolver xmlResolver; // 0xB8

	// Methods

	// RVA: 0x106234C
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1062450
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0x1065C0C
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x10662F8
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x106639C
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10663A4
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x10663AC
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x10663B4
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x10663BC
	internal XmlSchema get_RootSchema() { }

	// RVA: 0x10638E0
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0x1062AF4
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0x1065CEC
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0x1066434
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x106666C
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0x1063A64
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0x1066CC8
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0x1064DD0
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0x1069C0C
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0x1069B70
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0x1066BA0
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0x106A3E8
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0x1069D4C
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x1069E08
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x106A2C8
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x1069F64
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x1067F20
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x106ACB8
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x106A9F4
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x10680AC
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1069338
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x106B980
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x106B5A8
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x106BD70
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1068C6C
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1068228
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x10695C4
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1069814
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x106C180
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x106B12C
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x106688C
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x106A720
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x106AEEC
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x10663C4
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x1066408
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0x1062990
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x10667B8
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x10667DC
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x1069AF4
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: 
internal enum Reserve
{
	// Fields
	public int value__; // 0x10
	public const Reserve None = 0;
	public const Reserve XmlSpace = 1;
	public const Reserve XmlLang = 2;
}

// Namespace: System.Xml.Schema
internal sealed class SchemaAttDef
{
	// Fields
	private string defExpanded; // 0x60
	private int lineNum; // 0x68
	private int linePos; // 0x6C
	private int valueLineNum; // 0x70
	private int valueLinePos; // 0x74
	private Reserve reserved; // 0x78
	private bool defaultValueChecked; // 0x7C
	private XmlSchemaAttribute schemaAttribute; // 0x80
	public static readonly SchemaAttDef Empty; // 0x0

	// Methods

	// RVA: 0x106CB5C
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x106CB64
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0x106CB70
	private void .ctor() { }

	// RVA: 0x106CB78
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0x106CB80
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x106CBA0
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x106CBA8
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0x106CBB0
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0x106CC04
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x106CC0C
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0x106CC1C
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x106CCF4
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x106CCFC
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0x106CD04
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x106CD0C
	internal int get_LinePosition() { }

	// RVA: 0x106CD14
	internal void set_LinePosition(int value) { }

	// RVA: 0x106CD1C
	internal int get_LineNumber() { }

	// RVA: 0x106CD24
	internal void set_LineNumber(int value) { }

	// RVA: 0x106CD2C
	internal int get_ValueLinePosition() { }

	// RVA: 0x106CD34
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x106CD3C
	internal int get_ValueLineNumber() { }

	// RVA: 0x106CD44
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0x106CC88
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x106CD4C
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0x106CBE0
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x106CD54
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0x106CD88
	internal Reserve get_Reserved() { }

	// RVA: 0x106CD90
	internal void set_Reserved(Reserve value) { }

	// RVA: 0x106CD98
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x106CDA0
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x106CDA8
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x106CDB0
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0x106D044
	internal SchemaAttDef Clone() { }

	// RVA: 0x106D0AC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class SchemaBuilder
{
	// Methods

	// RVA: -1
	internal abstract bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: -1
	internal abstract void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: -1
	internal abstract bool IsContentParsed() { }

	// RVA: -1
	internal abstract void ProcessMarkup(XmlNode[] markup) { }

	// RVA: -1
	internal abstract void ProcessCData(string value) { }

	// RVA: -1
	internal abstract void StartChildren() { }

	// RVA: -1
	internal abstract void EndChildren() { }

	// RVA: 0x106D118
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionCompiler
{
	// Fields
	private bool compileContentModel; // 0x40
	private XmlSchemaObjectTable examplars; // 0x48
	private Stack complexTypeStack; // 0x50
	private XmlSchema schema; // 0x58

	// Methods

	// RVA: 0x106D120
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0x106D1EC
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0x106D25C
	private void Prepare() { }

	// RVA: 0x106D6E8
	private void Cleanup() { }

	// RVA: 0x1071B9C
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0x106E5F4
	private void Compile() { }

	// RVA: 0x1070574
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x1071B58
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10715B4
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1071604
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x107199C
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10719B8
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x1076FE8
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x107157C
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x10770E4
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10723F0
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0x1076E18
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x1072884
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1073EF8
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x107770C
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1077BFC
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x107316C
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1077D24
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1077FBC
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1078434
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x10788FC
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1076CB0
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x107A274
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0x107725C
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0x107B7D0
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0x107B938
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0x107BED0
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0x107C390
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0x107C894
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0x107B030
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x107CE04
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x107CF2C
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x107CF80
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x107CFCC
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x107D26C
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x107D660
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x107D984
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x107DDEC
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x107EB5C
	private void CalculateSequenceRange(XmlSchemaSequence sequence, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x107E094
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x107E974
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x107EA5C
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x107CD38
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x107E17C
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x107EF88
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x107A3FC
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1072990
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1078CA0
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x107F06C
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x107EFB0
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x10757D0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x10764CC
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x10748AC
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x107A498
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x107F128
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x107F818
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x1076BD8
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x107755C
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x107AF48
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x107ADAC
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

}

// Namespace: 
private enum Compositor
{
	// Fields
	public int value__; // 0x10
	public const Compositor Root = 0;
	public const Compositor Include = 1;
	public const Compositor Import = 2;
}

// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionPreprocessor
{
	// Fields
	private XmlSchema schema; // 0x40
	private string targetNamespace; // 0x48
	private bool buildinIncluded; // 0x50
	private XmlSchemaForm elementFormDefault; // 0x54
	private XmlSchemaForm attributeFormDefault; // 0x58
	private XmlSchemaDerivationMethod blockDefault; // 0x5C
	private XmlSchemaDerivationMethod finalDefault; // 0x60
	private Hashtable schemaLocations; // 0x68
	private Hashtable referenceNamespaces; // 0x70
	private string Xmlns; // 0x78
	private XmlResolver xmlResolver; // 0x80

	// Methods

	// RVA: 0x107FA88
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x107FA90
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0x107FCFC
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x1082FA4
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x107FF34
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0x10831B0
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x1080C30
	private void Preprocess(XmlSchema schema, string targetNamespace, Compositor compositor) { }

	// RVA: 0x10834E4
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0x108662C
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0x1085F94
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x108603C
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x108650C
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x10861A8
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x10846B8
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1086E60
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1086C10
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x1084844
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1085844
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x1087878
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x1087508
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x1087BF8
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1085244
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1084950
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x1085AD0
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1085CB0
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x1087F84
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10871C8
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x10809B8
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x108693C
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1087024
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x10833D0
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x10833F4
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x1082FAC
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x1083078
	private Stream GetSchemaEntity(Uri ruri) { }

}

// Namespace: 
internal enum Use
{
	// Fields
	public int value__; // 0x10
	public const Use Default = 0;
	public const Use Required = 1;
	public const Use Implied = 2;
	public const Use Fixed = 3;
	public const Use RequiredFixed = 4;
}

// Namespace: System.Xml.Schema
internal abstract class SchemaDeclBase
{
	// Fields
	protected XmlQualifiedName name; // 0x10
	protected string prefix; // 0x18
	protected bool isDeclaredInExternal; // 0x20
	protected Use presence; // 0x24
	protected XmlSchemaType schemaType; // 0x28
	protected XmlSchemaDatatype datatype; // 0x30
	protected string defaultValueRaw; // 0x38
	protected object defaultValueTyped; // 0x40
	protected Int64 maxLength; // 0x48
	protected Int64 minLength; // 0x50
	protected System.Collections.Generic.List<System.String> values; // 0x58

	// Methods

	// RVA: 0x10888EC
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x10889A8
	protected void .ctor() { }

	// RVA: 0x1088A24
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x1088A2C
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0x1088A34
	internal string get_Prefix() { }

	// RVA: 0x1088AA0
	internal void set_Prefix(string value) { }

	// RVA: 0x1088AA8
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x1088AB0
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x1088AB8
	internal Use get_Presence() { }

	// RVA: 0x1088AC0
	internal void set_Presence(Use value) { }

	// RVA: 0x1088AC8
	internal Int64 get_MaxLength() { }

	// RVA: 0x1088AD0
	internal void set_MaxLength(Int64 value) { }

	// RVA: 0x1088AD8
	internal Int64 get_MinLength() { }

	// RVA: 0x1088AE0
	internal void set_MinLength(Int64 value) { }

	// RVA: 0x1088AE8
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x1088AF0
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x1088AF8
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x1088B00
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0x1088B08
	internal void AddValue(string value) { }

	// RVA: 0x1088BC0
	internal System.Collections.Generic.List<System.String> get_Values() { }

	// RVA: 0x1088BC8
	internal void set_Values(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x1088BD0
	internal string get_DefaultValueRaw() { }

	// RVA: 0x1088C3C
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x1088C44
	internal object get_DefaultValueTyped() { }

	// RVA: 0x1088C4C
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0x1088C54
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0x1088D1C
	internal bool CheckValue(object pVal) { }

}

// Namespace: System.Xml.Schema
internal sealed class SchemaElementDecl
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> attdefs; // 0x60
	private System.Collections.Generic.List<System.Xml.IDtdDefaultAttributeInfo> defaultAttdefs; // 0x68
	private bool isIdDeclared; // 0x70
	private bool hasNonCDataAttribute; // 0x71
	private bool isAbstract; // 0x72
	private bool isNillable; // 0x73
	private bool hasRequiredAttribute; // 0x74
	private bool isNotationDeclared; // 0x75
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName> prohibitedAttributes; // 0x78
	private ContentValidator contentValidator; // 0x80
	private XmlSchemaAnyAttribute anyAttribute; // 0x88
	private XmlSchemaDerivationMethod block; // 0x90
	private CompiledIdentityConstraint[] constraints; // 0x98
	private XmlSchemaElement schemaElement; // 0xA0
	internal static readonly SchemaElementDecl Empty; // 0x0

	// Methods

	// RVA: 0x1088D74
	internal void .ctor() { }

	// RVA: 0x1088EA4
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0x108902C
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1089120
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0x1089220
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x1089228
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x10892E8
	private System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0x10892F0
	internal bool get_IsIdDeclared() { }

	// RVA: 0x10892F8
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0x1089300
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0x1089308
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0x1089310
	internal SchemaElementDecl Clone() { }

	// RVA: 0x1089378
	internal bool get_IsAbstract() { }

	// RVA: 0x1089380
	internal void set_IsAbstract(bool value) { }

	// RVA: 0x1089388
	internal bool get_IsNillable() { }

	// RVA: 0x1089390
	internal void set_IsNillable(bool value) { }

	// RVA: 0x1089398
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x10893A0
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10893A8
	internal bool get_IsNotationDeclared() { }

	// RVA: 0x10893B0
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0x10893B8
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0x10893C8
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x10893D0
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x10893D8
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x10893E0
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10893E8
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10893F0
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x10893F8
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x1089400
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1089408
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x1089410
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0x108953C
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x10895C0
	internal System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x10895C8
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttDefs() { }

	// RVA: 0x10895D0
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0x10895D8
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0x10899A8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class SchemaEntity
{
	// Fields
	private XmlQualifiedName qname; // 0x10
	private string url; // 0x18
	private string pubid; // 0x20
	private string text; // 0x28
	private XmlQualifiedName ndata; // 0x30
	private int lineNumber; // 0x38
	private int linePosition; // 0x3C
	private bool isParameter; // 0x40
	private bool isExternal; // 0x41
	private bool parsingInProgress; // 0x42
	private bool isDeclaredInExternal; // 0x43
	private string baseURI; // 0x48
	private string declaredURI; // 0x50

	// Methods

	// RVA: 0x1089A10
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0x1089AB4
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0x1089AD4
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0x1089ADC
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x1089AE4
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x1089B0C
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0x1089B14
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0x1089BEC
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x1089CC4
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x1089CCC
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x1089CD4
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x1089CDC
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x1089CE4
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0x1089CEC
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x1089DF8
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x1089E00
	internal string get_Url() { }

	// RVA: 0x1089E08
	internal void set_Url(string value) { }

	// RVA: 0x1089E38
	internal string get_Pubid() { }

	// RVA: 0x1089E40
	internal void set_Pubid(string value) { }

	// RVA: 0x1089E48
	internal bool get_IsExternal() { }

	// RVA: 0x1089E50
	internal void set_IsExternal(bool value) { }

	// RVA: 0x1089E58
	internal bool get_DeclaredInExternal() { }

	// RVA: 0x1089E60
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x1089E68
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x1089E70
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x1089E78
	internal string get_Text() { }

	// RVA: 0x1089E80
	internal void set_Text(string value) { }

	// RVA: 0x1089EAC
	internal int get_Line() { }

	// RVA: 0x1089EB4
	internal void set_Line(int value) { }

	// RVA: 0x1089EBC
	internal int get_Pos() { }

	// RVA: 0x1089EC4
	internal void set_Pos(int value) { }

	// RVA: 0x1089B80
	internal string get_BaseURI() { }

	// RVA: 0x1089ECC
	internal void set_BaseURI(string value) { }

	// RVA: 0x1089ED4
	internal bool get_ParsingInProgress() { }

	// RVA: 0x1089EDC
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0x1089C58
	internal string get_DeclaredURI() { }

	// RVA: 0x1089EE4
	internal void set_DeclaredURI(string value) { }

}

// Namespace: System.Xml.Schema
internal enum AttributeMatchState
{
	// Fields
	public int value__; // 0x10
	public const AttributeMatchState AttributeFound = 0;
	public const AttributeMatchState AnyIdAttributeFound = 1;
	public const AttributeMatchState UndeclaredElementAndAttribute = 2;
	public const AttributeMatchState UndeclaredAttribute = 3;
	public const AttributeMatchState AnyAttributeLax = 4;
	public const AttributeMatchState AnyAttributeSkip = 5;
	public const AttributeMatchState ProhibitedAnyAttribute = 6;
	public const AttributeMatchState ProhibitedAttribute = 7;
	public const AttributeMatchState AttributeNameMismatch = 8;
	public const AttributeMatchState ValidateAttributeInvalidCall = 9;
}

// Namespace: System.Xml.Schema
internal class SchemaInfo
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> elementDecls; // 0x10
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> undeclaredElementDecls; // 0x18
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> generalEntities; // 0x20
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> parameterEntities; // 0x28
	private XmlQualifiedName docTypeName; // 0x30
	private string internalDtdSubset; // 0x38
	private bool hasNonCDataAttributes; // 0x40
	private bool hasDefaultAttributes; // 0x41
	private System.Collections.Generic.Dictionary<System.String,System.Boolean> targetNamespaces; // 0x48
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> attributeDecls; // 0x50
	private int errorCount; // 0x58
	private SchemaType schemaType; // 0x5C
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> elementDeclsByType; // 0x60
	private System.Collections.Generic.Dictionary<System.String,System.Xml.Schema.SchemaNotation> notations; // 0x68

	// Methods

	// RVA: 0x1089EEC
	internal void .ctor() { }

	// RVA: 0x108A0E0
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x108A0E8
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x108A0F0
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x108A0F8
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x108A100
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0x108A108
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_GeneralEntities() { }

	// RVA: 0x108A1A4
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x108A240
	internal SchemaType get_SchemaType() { }

	// RVA: 0x108A248
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x108A250
	internal System.Collections.Generic.Dictionary<System.String,System.Boolean> get_TargetNamespaces() { }

	// RVA: 0x108A258
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x108A260
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0x108A268
	internal System.Collections.Generic.Dictionary<System.String,System.Xml.Schema.SchemaNotation> get_Notations() { }

	// RVA: 0x108A304
	internal int get_ErrorCount() { }

	// RVA: 0x108A30C
	internal void set_ErrorCount(int value) { }

	// RVA: 0x108A314
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0x108A398
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0x108A41C
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0x108A4C0
	internal bool HasSchema(string ns) { }

	// RVA: 0x108A524
	internal bool Contains(string ns) { }

	// RVA: 0x108A588
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0x108A71C
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, AttributeMatchState attributeMatchState) { }

	// RVA: 0x108A990
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, bool skip) { }

	// RVA: 0x108AAA4
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0x108BA84
	internal void Finish() { }

	// RVA: 0x108BDE0
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x108BDE8
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x108BDF0
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x108BEC4
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x108BF94
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x108BF9C
	private string System.Xml.IDtdInfo.get_InternalDtdSubset() { }

}

// Namespace: 
public enum Token
{
	// Fields
	public int value__; // 0x10
	public const Token Empty = 0;
	public const Token SchemaName = 1;
	public const Token SchemaType = 2;
	public const Token SchemaMaxOccurs = 3;
	public const Token SchemaMinOccurs = 4;
	public const Token SchemaInfinite = 5;
	public const Token SchemaModel = 6;
	public const Token SchemaOpen = 7;
	public const Token SchemaClosed = 8;
	public const Token SchemaContent = 9;
	public const Token SchemaMixed = 10;
	public const Token SchemaEmpty = 11;
	public const Token SchemaElementOnly = 12;
	public const Token SchemaTextOnly = 13;
	public const Token SchemaOrder = 14;
	public const Token SchemaSeq = 15;
	public const Token SchemaOne = 16;
	public const Token SchemaMany = 17;
	public const Token SchemaRequired = 18;
	public const Token SchemaYes = 19;
	public const Token SchemaNo = 20;
	public const Token SchemaString = 21;
	public const Token SchemaId = 22;
	public const Token SchemaIdref = 23;
	public const Token SchemaIdrefs = 24;
	public const Token SchemaEntity = 25;
	public const Token SchemaEntities = 26;
	public const Token SchemaNmtoken = 27;
	public const Token SchemaNmtokens = 28;
	public const Token SchemaEnumeration = 29;
	public const Token SchemaDefault = 30;
	public const Token XdrRoot = 31;
	public const Token XdrElementType = 32;
	public const Token XdrElement = 33;
	public const Token XdrGroup = 34;
	public const Token XdrAttributeType = 35;
	public const Token XdrAttribute = 36;
	public const Token XdrDatatype = 37;
	public const Token XdrDescription = 38;
	public const Token XdrExtends = 39;
	public const Token SchemaXdrRootAlias = 40;
	public const Token SchemaDtType = 41;
	public const Token SchemaDtValues = 42;
	public const Token SchemaDtMaxLength = 43;
	public const Token SchemaDtMinLength = 44;
	public const Token SchemaDtMax = 45;
	public const Token SchemaDtMin = 46;
	public const Token SchemaDtMinExclusive = 47;
	public const Token SchemaDtMaxExclusive = 48;
	public const Token SchemaTargetNamespace = 49;
	public const Token SchemaVersion = 50;
	public const Token SchemaFinalDefault = 51;
	public const Token SchemaBlockDefault = 52;
	public const Token SchemaFixed = 53;
	public const Token SchemaAbstract = 54;
	public const Token SchemaBlock = 55;
	public const Token SchemaSubstitutionGroup = 56;
	public const Token SchemaFinal = 57;
	public const Token SchemaNillable = 58;
	public const Token SchemaRef = 59;
	public const Token SchemaBase = 60;
	public const Token SchemaDerivedBy = 61;
	public const Token SchemaNamespace = 62;
	public const Token SchemaProcessContents = 63;
	public const Token SchemaRefer = 64;
	public const Token SchemaPublic = 65;
	public const Token SchemaSystem = 66;
	public const Token SchemaSchemaLocation = 67;
	public const Token SchemaValue = 68;
	public const Token SchemaSource = 69;
	public const Token SchemaAttributeFormDefault = 70;
	public const Token SchemaElementFormDefault = 71;
	public const Token SchemaUse = 72;
	public const Token SchemaForm = 73;
	public const Token XsdSchema = 74;
	public const Token XsdAnnotation = 75;
	public const Token XsdInclude = 76;
	public const Token XsdImport = 77;
	public const Token XsdElement = 78;
	public const Token XsdAttribute = 79;
	public const Token xsdAttributeGroup = 80;
	public const Token XsdAnyAttribute = 81;
	public const Token XsdGroup = 82;
	public const Token XsdAll = 83;
	public const Token XsdChoice = 84;
	public const Token XsdSequence = 85;
	public const Token XsdAny = 86;
	public const Token XsdNotation = 87;
	public const Token XsdSimpleType = 88;
	public const Token XsdComplexType = 89;
	public const Token XsdUnique = 90;
	public const Token XsdKey = 91;
	public const Token XsdKeyref = 92;
	public const Token XsdSelector = 93;
	public const Token XsdField = 94;
	public const Token XsdMinExclusive = 95;
	public const Token XsdMinInclusive = 96;
	public const Token XsdMaxExclusive = 97;
	public const Token XsdMaxInclusive = 98;
	public const Token XsdTotalDigits = 99;
	public const Token XsdFractionDigits = 100;
	public const Token XsdLength = 101;
	public const Token XsdMinLength = 102;
	public const Token XsdMaxLength = 103;
	public const Token XsdEnumeration = 104;
	public const Token XsdPattern = 105;
	public const Token XsdDocumentation = 106;
	public const Token XsdAppInfo = 107;
	public const Token XsdComplexContent = 108;
	public const Token XsdComplexContentExtension = 109;
	public const Token XsdComplexContentRestriction = 110;
	public const Token XsdSimpleContent = 111;
	public const Token XsdSimpleContentExtension = 112;
	public const Token XsdSimpleContentRestriction = 113;
	public const Token XsdSimpleTypeList = 114;
	public const Token XsdSimpleTypeRestriction = 115;
	public const Token XsdSimpleTypeUnion = 116;
	public const Token XsdWhitespace = 117;
	public const Token XsdRedefine = 118;
	public const Token SchemaItemType = 119;
	public const Token SchemaMemberTypes = 120;
	public const Token SchemaXPath = 121;
	public const Token XmlLang = 122;
}

// Namespace: System.Xml.Schema
internal sealed class SchemaNames
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	public string NsDataType; // 0x18
	public string NsDataTypeAlias; // 0x20
	public string NsDataTypeOld; // 0x28
	public string NsXml; // 0x30
	public string NsXmlNs; // 0x38
	public string NsXdr; // 0x40
	public string NsXdrAlias; // 0x48
	public string NsXs; // 0x50
	public string NsXsi; // 0x58
	public string XsiType; // 0x60
	public string XsiNil; // 0x68
	public string XsiSchemaLocation; // 0x70
	public string XsiNoNamespaceSchemaLocation; // 0x78
	public string XsdSchema; // 0x80
	public string XdrSchema; // 0x88
	public XmlQualifiedName QnPCData; // 0x90
	public XmlQualifiedName QnXml; // 0x98
	public XmlQualifiedName QnXmlNs; // 0xA0
	public XmlQualifiedName QnDtDt; // 0xA8
	public XmlQualifiedName QnXmlLang; // 0xB0
	public XmlQualifiedName QnName; // 0xB8
	public XmlQualifiedName QnType; // 0xC0
	public XmlQualifiedName QnMaxOccurs; // 0xC8
	public XmlQualifiedName QnMinOccurs; // 0xD0
	public XmlQualifiedName QnInfinite; // 0xD8
	public XmlQualifiedName QnModel; // 0xE0
	public XmlQualifiedName QnOpen; // 0xE8
	public XmlQualifiedName QnClosed; // 0xF0
	public XmlQualifiedName QnContent; // 0xF8
	public XmlQualifiedName QnMixed; // 0x100
	public XmlQualifiedName QnEmpty; // 0x108
	public XmlQualifiedName QnEltOnly; // 0x110
	public XmlQualifiedName QnTextOnly; // 0x118
	public XmlQualifiedName QnOrder; // 0x120
	public XmlQualifiedName QnSeq; // 0x128
	public XmlQualifiedName QnOne; // 0x130
	public XmlQualifiedName QnMany; // 0x138
	public XmlQualifiedName QnRequired; // 0x140
	public XmlQualifiedName QnYes; // 0x148
	public XmlQualifiedName QnNo; // 0x150
	public XmlQualifiedName QnString; // 0x158
	public XmlQualifiedName QnID; // 0x160
	public XmlQualifiedName QnIDRef; // 0x168
	public XmlQualifiedName QnIDRefs; // 0x170
	public XmlQualifiedName QnEntity; // 0x178
	public XmlQualifiedName QnEntities; // 0x180
	public XmlQualifiedName QnNmToken; // 0x188
	public XmlQualifiedName QnNmTokens; // 0x190
	public XmlQualifiedName QnEnumeration; // 0x198
	public XmlQualifiedName QnDefault; // 0x1A0
	public XmlQualifiedName QnXdrSchema; // 0x1A8
	public XmlQualifiedName QnXdrElementType; // 0x1B0
	public XmlQualifiedName QnXdrElement; // 0x1B8
	public XmlQualifiedName QnXdrGroup; // 0x1C0
	public XmlQualifiedName QnXdrAttributeType; // 0x1C8
	public XmlQualifiedName QnXdrAttribute; // 0x1D0
	public XmlQualifiedName QnXdrDataType; // 0x1D8
	public XmlQualifiedName QnXdrDescription; // 0x1E0
	public XmlQualifiedName QnXdrExtends; // 0x1E8
	public XmlQualifiedName QnXdrAliasSchema; // 0x1F0
	public XmlQualifiedName QnDtType; // 0x1F8
	public XmlQualifiedName QnDtValues; // 0x200
	public XmlQualifiedName QnDtMaxLength; // 0x208
	public XmlQualifiedName QnDtMinLength; // 0x210
	public XmlQualifiedName QnDtMax; // 0x218
	public XmlQualifiedName QnDtMin; // 0x220
	public XmlQualifiedName QnDtMinExclusive; // 0x228
	public XmlQualifiedName QnDtMaxExclusive; // 0x230
	public XmlQualifiedName QnTargetNamespace; // 0x238
	public XmlQualifiedName QnVersion; // 0x240
	public XmlQualifiedName QnFinalDefault; // 0x248
	public XmlQualifiedName QnBlockDefault; // 0x250
	public XmlQualifiedName QnFixed; // 0x258
	public XmlQualifiedName QnAbstract; // 0x260
	public XmlQualifiedName QnBlock; // 0x268
	public XmlQualifiedName QnSubstitutionGroup; // 0x270
	public XmlQualifiedName QnFinal; // 0x278
	public XmlQualifiedName QnNillable; // 0x280
	public XmlQualifiedName QnRef; // 0x288
	public XmlQualifiedName QnBase; // 0x290
	public XmlQualifiedName QnDerivedBy; // 0x298
	public XmlQualifiedName QnNamespace; // 0x2A0
	public XmlQualifiedName QnProcessContents; // 0x2A8
	public XmlQualifiedName QnRefer; // 0x2B0
	public XmlQualifiedName QnPublic; // 0x2B8
	public XmlQualifiedName QnSystem; // 0x2C0
	public XmlQualifiedName QnSchemaLocation; // 0x2C8
	public XmlQualifiedName QnValue; // 0x2D0
	public XmlQualifiedName QnUse; // 0x2D8
	public XmlQualifiedName QnForm; // 0x2E0
	public XmlQualifiedName QnElementFormDefault; // 0x2E8
	public XmlQualifiedName QnAttributeFormDefault; // 0x2F0
	public XmlQualifiedName QnItemType; // 0x2F8
	public XmlQualifiedName QnMemberTypes; // 0x300
	public XmlQualifiedName QnXPath; // 0x308
	public XmlQualifiedName QnXsdSchema; // 0x310
	public XmlQualifiedName QnXsdAnnotation; // 0x318
	public XmlQualifiedName QnXsdInclude; // 0x320
	public XmlQualifiedName QnXsdImport; // 0x328
	public XmlQualifiedName QnXsdElement; // 0x330
	public XmlQualifiedName QnXsdAttribute; // 0x338
	public XmlQualifiedName QnXsdAttributeGroup; // 0x340
	public XmlQualifiedName QnXsdAnyAttribute; // 0x348
	public XmlQualifiedName QnXsdGroup; // 0x350
	public XmlQualifiedName QnXsdAll; // 0x358
	public XmlQualifiedName QnXsdChoice; // 0x360
	public XmlQualifiedName QnXsdSequence; // 0x368
	public XmlQualifiedName QnXsdAny; // 0x370
	public XmlQualifiedName QnXsdNotation; // 0x378
	public XmlQualifiedName QnXsdSimpleType; // 0x380
	public XmlQualifiedName QnXsdComplexType; // 0x388
	public XmlQualifiedName QnXsdUnique; // 0x390
	public XmlQualifiedName QnXsdKey; // 0x398
	public XmlQualifiedName QnXsdKeyRef; // 0x3A0
	public XmlQualifiedName QnXsdSelector; // 0x3A8
	public XmlQualifiedName QnXsdField; // 0x3B0
	public XmlQualifiedName QnXsdMinExclusive; // 0x3B8
	public XmlQualifiedName QnXsdMinInclusive; // 0x3C0
	public XmlQualifiedName QnXsdMaxInclusive; // 0x3C8
	public XmlQualifiedName QnXsdMaxExclusive; // 0x3D0
	public XmlQualifiedName QnXsdTotalDigits; // 0x3D8
	public XmlQualifiedName QnXsdFractionDigits; // 0x3E0
	public XmlQualifiedName QnXsdLength; // 0x3E8
	public XmlQualifiedName QnXsdMinLength; // 0x3F0
	public XmlQualifiedName QnXsdMaxLength; // 0x3F8
	public XmlQualifiedName QnXsdEnumeration; // 0x400
	public XmlQualifiedName QnXsdPattern; // 0x408
	public XmlQualifiedName QnXsdDocumentation; // 0x410
	public XmlQualifiedName QnXsdAppinfo; // 0x418
	public XmlQualifiedName QnSource; // 0x420
	public XmlQualifiedName QnXsdComplexContent; // 0x428
	public XmlQualifiedName QnXsdSimpleContent; // 0x430
	public XmlQualifiedName QnXsdRestriction; // 0x438
	public XmlQualifiedName QnXsdExtension; // 0x440
	public XmlQualifiedName QnXsdUnion; // 0x448
	public XmlQualifiedName QnXsdList; // 0x450
	public XmlQualifiedName QnXsdWhiteSpace; // 0x458
	public XmlQualifiedName QnXsdRedefine; // 0x460
	public XmlQualifiedName QnXsdAnyType; // 0x468
	internal XmlQualifiedName[] TokenToQName; // 0x470

	// Methods

	// RVA: 0x108BFA4
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x108ED9C
	public void CreateTokenToQNameTable() { }

	// RVA: 0x1090CCC
	public SchemaType SchemaTypeFromRoot(string localName, string ns) { }

	// RVA: 0x1090D7C
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1090DCC
	public bool IsXDRRoot(string localName, string ns) { }

}

// Namespace: System.Xml.Schema
internal class SchemaNamespaceManager
{
	// Fields
	private XmlSchemaObject node; // 0x50

	// Methods

	// RVA: 0x1090E1C
	public void .ctor(XmlSchemaObject node) { }

	// RVA: 0x1090E50
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1090FA0
	public override string LookupPrefix(string ns) { }

}

// Namespace: System.Xml.Schema
internal sealed class SchemaNotation
{
	// Fields
	private XmlQualifiedName name; // 0x10
	private string systemLiteral; // 0x18
	private string pubid; // 0x20

	// Methods

	// RVA: 0x10913A8
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x10913DC
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x10913E4
	internal string get_SystemLiteral() { }

	// RVA: 0x10913EC
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x10913F4
	internal string get_Pubid() { }

	// RVA: 0x10913FC
	internal void set_Pubid(string value) { }

}

// Namespace: System.Xml.Schema
internal sealed class Compiler
{
	// Fields
	private string restrictionErrorMsg; // 0x40
	private XmlSchemaObjectTable attributes; // 0x48
	private XmlSchemaObjectTable attributeGroups; // 0x50
	private XmlSchemaObjectTable elements; // 0x58
	private XmlSchemaObjectTable schemaTypes; // 0x60
	private XmlSchemaObjectTable groups; // 0x68
	private XmlSchemaObjectTable notations; // 0x70
	private XmlSchemaObjectTable examplars; // 0x78
	private XmlSchemaObjectTable identityConstraints; // 0x80
	private Stack complexTypeStack; // 0x88
	private Hashtable schemasToCompile; // 0x90
	private Hashtable importedSchemas; // 0x98
	private XmlSchema schemaForSchema; // 0xA0

	// Methods

	// RVA: 0x1091404
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1091654
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0x1094800
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0x1096840
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0x10936C0
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x10969C8
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0x10916F8
	internal bool Compile() { }

	// RVA: 0x10961E0
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1096268
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10962C4
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1096788
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1096030
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x109BF68
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x109621C
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x109C05C
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x109AF40
	private void ProcessSubstitutionGroups() { }

	// RVA: 0x109C208
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x109BDF0
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0x109BEE0
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0x1096ADC
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x109819C
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x109D6DC
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x109DBCC
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x10975A8
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x109DCF4
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x109DF8C
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x109E440
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x109E914
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x109B7A0
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x109CB8C
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10A02EC
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0x109C7CC
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0x10A3104
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0x10A1E80
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0x10A240C
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0x10A26D8
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0x10A2C08
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0x10A10AC
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0x10A1300
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10A34A0
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x10A36E0
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x10A3898
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x10A39A4
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x10A3E6C
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0x10A4F58
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0x10A473C
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x10A4AF0
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x10A5154
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x10A5528
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10A5FF0
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x10A60D8
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x10A33D4
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x10A57CC
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x10A61D8
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10A046C
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1096BE4
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x109ECB0
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x109CC78
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0x10A6378
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0x10A62BC
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x10A6200
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1099C70
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x10A64A4
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0x109A6C4
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x1098B8C
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x10A0508
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x10A6694
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x10A6D68
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x109C9FC
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0x109ADC8
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x109D5DC
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x10A0FD0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x10A0E40
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0x10A3350
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0x10A5610
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }

}

// Namespace: System.Xml.Schema
internal enum SchemaType
{
	// Fields
	public int value__; // 0x10
	public const SchemaType None = 0;
	public const SchemaType DTD = 1;
	public const SchemaType XDR = 2;
	public const SchemaType XSD = 3;
}

// Namespace: System.Xml.Schema
public class ValidationEventArgs
{
	// Fields
	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	// Methods

	// RVA: 0x10A6FD8
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0x10A7058
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x10A70E4
	public XmlSeverityType get_Severity() { }

	// RVA: 0x10A70EC
	public XmlSchemaException get_Exception() { }

}

// Namespace: System.Xml.Schema
public sealed class ValidationEventHandler
{
	// Methods

	// RVA: 0x10A70F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10A7218
	public virtual void Invoke(object sender, ValidationEventArgs e) { }

}

// Namespace: System.Xml.Schema
internal struct StateUnion
{
	// Fields
	public int State; // 0x10
	public int AllElementsRequired; // 0x10
	public int CurPosIndex; // 0x10
	public int NumberOfRunningPos; // 0x10
}

// Namespace: System.Xml.Schema
internal sealed class ValidationState
{
	// Fields
	public bool IsNill; // 0x10
	public bool IsDefault; // 0x11
	public bool NeedValidateChildren; // 0x12
	public bool CheckRequiredAttribute; // 0x13
	public bool ValidationSkipped; // 0x14
	public XmlSchemaContentProcessing ProcessContents; // 0x18
	public XmlSchemaValidity Validity; // 0x1C
	public SchemaElementDecl ElementDecl; // 0x20
	public SchemaElementDecl ElementDeclBeforeXsi; // 0x28
	public string LocalName; // 0x30
	public string Namespace; // 0x38
	public ConstraintStruct[] Constr; // 0x40
	public StateUnion CurrentState; // 0x48
	public bool HasMatched; // 0x4C
	public BitSet[] CurPos; // 0x50
	public BitSet AllElementsSet; // 0x58
	public System.Collections.Generic.List<System.Xml.Schema.RangePositionInfo> RunningPositions; // 0x60
	public bool TooComplex; // 0x68

	// Methods

	// RVA: 0x10A722C
	public void .ctor() { }

}

// Namespace: 
private sealed class DeclBaseInfo
{
	// Fields
	internal XmlQualifiedName _Name; // 0x10
	internal string _Prefix; // 0x18
	internal XmlQualifiedName _TypeName; // 0x20
	internal string _TypePrefix; // 0x28
	internal object _Default; // 0x30
	internal object _Revises; // 0x38
	internal UInt32 _MaxOccurs; // 0x40
	internal UInt32 _MinOccurs; // 0x44
	internal bool _Checking; // 0x48
	internal SchemaElementDecl _ElementDecl; // 0x50
	internal SchemaAttDef _Attdef; // 0x58
	internal DeclBaseInfo _Next; // 0x60

	// Methods

	// RVA: 0x10AC618
	internal void .ctor() { }

	// RVA: 0x10ACB70
	internal void Reset() { }

}

// Namespace: 
private sealed class GroupContent
{
	// Fields
	internal UInt32 _MinVal; // 0x10
	internal UInt32 _MaxVal; // 0x14
	internal bool _HasMaxAttr; // 0x18
	internal bool _HasMinAttr; // 0x19
	internal int _Order; // 0x1C

	// Methods

	// RVA: 0x10B2048
	internal static void Copy(GroupContent from, GroupContent to) { }

	// RVA: 0x10A8B38
	internal static GroupContent Copy(GroupContent other) { }

	// RVA: 0x10A755C
	public void .ctor() { }

}

// Namespace: 
private sealed class ElementContent
{
	// Fields
	internal SchemaElementDecl _ElementDecl; // 0x10
	internal int _ContentAttr; // 0x18
	internal int _OrderAttr; // 0x1C
	internal bool _MasterGroupRequired; // 0x20
	internal bool _ExistTerminal; // 0x21
	internal bool _AllowDataType; // 0x22
	internal bool _HasDataType; // 0x23
	internal bool _HasType; // 0x24
	internal bool _EnumerationRequired; // 0x25
	internal UInt32 _MinVal; // 0x28
	internal UInt32 _MaxVal; // 0x2C
	internal UInt32 _MaxLength; // 0x30
	internal UInt32 _MinLength; // 0x34
	internal Hashtable _AttDefList; // 0x38

	// Methods

	// RVA: 0x10A754C
	public void .ctor() { }

}

// Namespace: 
private sealed class AttributeContent
{
	// Fields
	internal SchemaAttDef _AttDef; // 0x10
	internal XmlQualifiedName _Name; // 0x18
	internal string _Prefix; // 0x20
	internal bool _Required; // 0x28
	internal UInt32 _MinVal; // 0x2C
	internal UInt32 _MaxVal; // 0x30
	internal UInt32 _MaxLength; // 0x34
	internal UInt32 _MinLength; // 0x38
	internal bool _EnumerationRequired; // 0x3C
	internal bool _HasDataType; // 0x3D
	internal bool _Global; // 0x3E
	internal object _Default; // 0x40

	// Methods

	// RVA: 0x10A7554
	public void .ctor() { }

}

// Namespace: 
private sealed class XdrBuildFunction
{
	// Methods

	// RVA: 0x10B1B64
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10B2074
	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }

}

// Namespace: 
private sealed class XdrInitFunction
{
	// Methods

	// RVA: 0x10B1E24
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10B2088
	public virtual void Invoke(XdrBuilder builder, object obj) { }

}

// Namespace: 
private sealed class XdrBeginChildFunction
{
	// Methods

	// RVA: 0x10B1EE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10B209C
	public virtual void Invoke(XdrBuilder builder) { }

}

// Namespace: 
private sealed class XdrEndChildFunction
{
	// Methods

	// RVA: 0x10B1F94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10B20B0
	public virtual void Invoke(XdrBuilder builder) { }

}

// Namespace: 
private sealed class XdrAttributeEntry
{
	// Fields
	internal Token _Attribute; // 0x10
	internal int _SchemaFlags; // 0x14
	internal XmlSchemaDatatype _Datatype; // 0x18
	internal XdrBuildFunction _BuildFunc; // 0x20

	// Methods

	// RVA: 0x10B1C20
	internal void .ctor(Token a, XmlTokenizedType ttype, XdrBuildFunction build) { }

	// RVA: 0x10B1CC8
	internal void .ctor(Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuildFunction build) { }

}

// Namespace: 
private sealed class XdrEntry
{
	// Fields
	internal Token _Name; // 0x10
	internal int[] _NextStates; // 0x18
	internal XdrAttributeEntry[] _Attributes; // 0x20
	internal XdrInitFunction _InitFunc; // 0x28
	internal XdrBeginChildFunction _BeginChildFunc; // 0x30
	internal XdrEndChildFunction _EndChildFunc; // 0x38
	internal bool _AllowText; // 0x40

	// Methods

	// RVA: 0x10B1D74
	internal void .ctor(Token n, int[] states, XdrAttributeEntry[] attributes, XdrInitFunction init, XdrBeginChildFunction begin, XdrEndChildFunction end, bool fText) { }

}

// Namespace: System.Xml.Schema
internal sealed class XdrBuilder
{
	// Fields
	private static readonly int[] S_XDR_Root_Element; // 0x0
	private static readonly int[] S_XDR_Root_SubElements; // 0x8
	private static readonly int[] S_XDR_ElementType_SubElements; // 0x10
	private static readonly int[] S_XDR_AttributeType_SubElements; // 0x18
	private static readonly int[] S_XDR_Group_SubElements; // 0x20
	private static readonly XdrAttributeEntry[] S_XDR_Root_Attributes; // 0x28
	private static readonly XdrAttributeEntry[] S_XDR_ElementType_Attributes; // 0x30
	private static readonly XdrAttributeEntry[] S_XDR_AttributeType_Attributes; // 0x38
	private static readonly XdrAttributeEntry[] S_XDR_Element_Attributes; // 0x40
	private static readonly XdrAttributeEntry[] S_XDR_Attribute_Attributes; // 0x48
	private static readonly XdrAttributeEntry[] S_XDR_Group_Attributes; // 0x50
	private static readonly XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; // 0x58
	private static readonly XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; // 0x60
	private static readonly XdrEntry[] S_SchemaEntries; // 0x68
	private SchemaInfo _SchemaInfo; // 0x10
	private string _TargetNamespace; // 0x18
	private XmlReader _reader; // 0x20
	private PositionInfo positionInfo; // 0x28
	private ParticleContentValidator _contentValidator; // 0x30
	private XdrEntry _CurState; // 0x38
	private XdrEntry _NextState; // 0x40
	private HWStack _StateHistory; // 0x48
	private HWStack _GroupStack; // 0x50
	private string _XdrName; // 0x58
	private string _XdrPrefix; // 0x60
	private ElementContent _ElementDef; // 0x68
	private GroupContent _GroupDef; // 0x70
	private AttributeContent _AttributeDef; // 0x78
	private DeclBaseInfo _UndefinedAttributeTypes; // 0x80
	private DeclBaseInfo _BaseDecl; // 0x88
	private XmlNameTable _NameTable; // 0x90
	private SchemaNames _SchemaNames; // 0x98
	private XmlNamespaceManager _CurNsMgr; // 0xA0
	private string _Text; // 0xA8
	private ValidationEventHandler validationEventHandler; // 0xB0
	private Hashtable _UndeclaredElements; // 0xB8
	private XmlResolver xmlResolver; // 0xC0

	// Methods

	// RVA: 0x10A729C
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x10A7564
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x10A7C5C
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x10A8720
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10A80EC
	private bool LoadSchema(string uri) { }

	// RVA: 0x10A8028
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x10A8868
	internal override bool IsContentParsed() { }

	// RVA: 0x10A8870
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x10A88CC
	internal override void ProcessCData(string value) { }

	// RVA: 0x10A8958
	internal override void StartChildren() { }

	// RVA: 0x10A8994
	internal override void EndChildren() { }

	// RVA: 0x10A7A5C
	private void Push() { }

	// RVA: 0x10A89DC
	private void Pop() { }

	// RVA: 0x10A8A84
	private void PushGroupInfo() { }

	// RVA: 0x10A8BB8
	private void PopGroupInfo() { }

	// RVA: 0x10A8C60
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0x10A8CCC
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10A8D74
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10A8D78
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0x10A8E80
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0x10A9440
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0x10A9570
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10A974C
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10A99B8
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10A9B44
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10A9D48
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10A9FE0
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AA0E0
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AA2D4
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AA4C8
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0x10AA7E0
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0x10AAD68
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0x10AAE78
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AB0D4
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AB29C
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AB2C0
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AB55C
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AB65C
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AB6D8
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AB754
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0x10AB814
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0x10ABD28
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0x10ABDF8
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AC048
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AC22C
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AC420
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0x10AC58C
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0x10AC640
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AC72C
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AC7E0
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10AC804
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0x10ACB50
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0x10ACC74
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0x10ACD70
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10ACEA4
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10ACF34
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10ACFC4
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0x10AD1C4
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x10AD2E0
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0x10AD3F4
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x10AD4A8
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0x10A78A4
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x10A7AB4
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x10A85D0
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0x10A9BF4
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0x10ABF8C
	private void AddOrder() { }

	// RVA: 0x10AB154
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0x10AC0C8
	private static UInt32 ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x10AC2AC
	private static UInt32 ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x10AC55C
	private static void HandleMinMax(ParticleContentValidator pContent, UInt32 cMin, UInt32 cMax) { }

	// RVA: 0x10AA15C
	private static void ParseDtMaxLength(UInt32 cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x10AA350
	private static void ParseDtMinLength(UInt32 cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x10AACAC
	private static void CompareMinMaxLength(UInt32 cMin, UInt32 cMax, XdrBuilder builder) { }

	// RVA: 0x10AD5E0
	private static bool ParseInteger(string str, UInt32 n) { }

	// RVA: 0x10A9354
	private void XDR_CheckAttributeDefault(DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0x10ABCD8
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0x10A97F4
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0x10A9A60
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0x10AB384
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0x10ABBEC
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0x10A801C
	private bool IsGlobal(int flags) { }

	// RVA: 0x10A8728
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x10A9EF4
	private void SendValidationEvent(string code) { }

	// RVA: 0x10A7B78
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x10ADC60
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x10ADEA0
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class XdrValidator
{
	// Fields
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool isProcessContents; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8

	// Methods

	// RVA: 0x10B20C4
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x10B2350
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x10B2150
	private void Init() { }

	// RVA: 0x10B258C
	public override void Validate() { }

	// RVA: 0x10B2924
	private void ValidateElement() { }

	// RVA: 0x10B2CA8
	private void ValidateChildElement() { }

	// RVA: 0x10B2660
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x10B2670
	private void ProcessInlineSchema() { }

	// RVA: 0x10B2DEC
	private void ProcessElement() { }

	// RVA: 0x10B2ACC
	private void ValidateEndElement() { }

	// RVA: 0x10B2EAC
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x10B3220
	private void ValidateStartElement() { }

	// RVA: 0x10B369C
	private void ValidateEndStartElement() { }

	// RVA: 0x10B4444
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x10B4148
	private void LoadSchema(string uri) { }

	// RVA: 0x10B4B10
	private bool get_HasSchema() { }

	// RVA: 0x10B4B38
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x10B4B74
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x10B4E90
	public override void CompleteValidation() { }

	// RVA: 0x10B3A50
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x10AD61C
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x10B4DF0
	internal void AddID(string name, object node) { }

	// RVA: 0x10B5184
	public override object FindId(string name) { }

	// RVA: 0x10B23F4
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x10B4078
	private void Pop() { }

	// RVA: 0x10B4F60
	private void CheckForwardRefs() { }

	// RVA: 0x10B4368
	private XmlQualifiedName QualifiedName(string name, string ns) { }

}

// Namespace: 
private struct Union
{
	// Fields
	public bool boolVal; // 0x10
	public Double dblVal; // 0x10
	public Int64 i64Val; // 0x10
	public int i32Val; // 0x10
	public DateTime dtVal; // 0x10
}

// Namespace: 
private class NamespacePrefixForQName
{
	// Fields
	public string prefix; // 0x10
	public string ns; // 0x18

	// Methods

	// RVA: 0x10B58A0
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x10B66A8
	public string LookupNamespace(string prefix) { }

	// RVA: 0x10B66E8
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x10B6720
	public System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

}

// Namespace: System.Xml.Schema
public sealed class XmlAtomicValue
{
	// Fields
	private XmlSchemaType xmlType; // 0x10
	private object objVal; // 0x18
	private TypeCode clrType; // 0x20
	private Union unionVal; // 0x28
	private NamespacePrefixForQName nsPrefix; // 0x30

	// Methods

	// RVA: 0x10B51A0
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x10B523C
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x10B52D8
	internal void .ctor(XmlSchemaType xmlType, Double value) { }

	// RVA: 0x10B5374
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x10B5410
	internal void .ctor(XmlSchemaType xmlType, Int64 value) { }

	// RVA: 0x10B54AC
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x10B556C
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B58F0
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x10B59B0
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B5C04
	private object System.ICloneable.Clone() { }

	// RVA: 0x10B5C08
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x10B5C10
	public override Type get_ValueType() { }

	// RVA: 0x10B5C3C
	public override object get_TypedValue() { }

	// RVA: 0x10B5E2C
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x10B5F24
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x10B6030
	public override Double get_ValueAsDouble() { }

	// RVA: 0x10B613C
	public override int get_ValueAsInt() { }

	// RVA: 0x10B623C
	public override Int64 get_ValueAsLong() { }

	// RVA: 0x10B6348
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B657C
	public override string get_Value() { }

	// RVA: 0x10B669C
	public override string ToString() { }

	// RVA: 0x10B577C
	private string GetPrefixFromQName(string value) { }

}

// Namespace: System.Xml.Schema
public class XmlSchema
{
	// Fields
	private XmlSchemaForm attributeFormDefault; // 0x34
	private XmlSchemaForm elementFormDefault; // 0x38
	private XmlSchemaDerivationMethod blockDefault; // 0x3C
	private XmlSchemaDerivationMethod finalDefault; // 0x40
	private string targetNs; // 0x48
	private string version; // 0x50
	private XmlSchemaObjectCollection includes; // 0x58
	private XmlSchemaObjectCollection items; // 0x60
	private string id; // 0x68
	private XmlAttribute[] moreAttributes; // 0x70
	private bool isCompiled; // 0x78
	private bool isCompiledBySet; // 0x79
	private bool isPreprocessed; // 0x7A
	private bool isRedefined; // 0x7B
	private int errorCount; // 0x7C
	private XmlSchemaObjectTable attributes; // 0x80
	private XmlSchemaObjectTable attributeGroups; // 0x88
	private XmlSchemaObjectTable elements; // 0x90
	private XmlSchemaObjectTable types; // 0x98
	private XmlSchemaObjectTable groups; // 0xA0
	private XmlSchemaObjectTable notations; // 0xA8
	private XmlSchemaObjectTable identityConstraints; // 0xB0
	private static int globalIdCounter; // 0x0
	private ArrayList importedSchemas; // 0xB8
	private ArrayList importedNamespaces; // 0xC0
	private int schemaId; // 0xC8
	private Uri baseUri; // 0xD0
	private bool isChameleon; // 0xD8
	private Hashtable ids; // 0xE0
	private XmlDocument document; // 0xE8

	// Methods

	// RVA: 0x10B67C8
	public void .ctor() { }

	// RVA: 0x10B69B0
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x10B6B7C
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x10B6D90
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x10B6E40
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0x10B6E48
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x10B6E50
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x10B6E58
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10B6E60
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x10B6E68
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10B6E70
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x10B6E78
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x10B6E80
	public string get_TargetNamespace() { }

	// RVA: 0x10B6E88
	public void set_TargetNamespace(string value) { }

	// RVA: 0x10B6E90
	public string get_Version() { }

	// RVA: 0x10B6E98
	public void set_Version(string value) { }

	// RVA: 0x10B6EA0
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x10B6EA8
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10B6EB0
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x10B6EB8
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x10B6EC0
	internal bool get_IsPreprocessed() { }

	// RVA: 0x10B6EC8
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x10B6ED0
	internal bool get_IsRedefined() { }

	// RVA: 0x10B6ED8
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x10B6EE0
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x10B6F68
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x10B6FF0
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x10B7078
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x10B7100
	public string get_Id() { }

	// RVA: 0x10B7108
	public void set_Id(string value) { }

	// RVA: 0x10B7110
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x10B7118
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x10B7120
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0x10B7128
	internal Uri get_BaseUri() { }

	// RVA: 0x10B7130
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x10B7138
	internal int get_SchemaId() { }

	// RVA: 0x10B71C4
	internal bool get_IsChameleon() { }

	// RVA: 0x10B71CC
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x10B71D4
	internal Hashtable get_Ids() { }

	// RVA: 0x10B71DC
	internal XmlDocument get_Document() { }

	// RVA: 0x10B7264
	internal int get_ErrorCount() { }

	// RVA: 0x10B726C
	internal void set_ErrorCount(int value) { }

	// RVA: 0x10B7274
	internal XmlSchema Clone() { }

	// RVA: 0x10B7430
	internal XmlSchema DeepClone() { }

	// RVA: 0x10B85A8
	internal override string get_IdAttribute() { }

	// RVA: 0x10B85B0
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10B85B8
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x10B85C0
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10B85C8
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x10B8690
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x10B8718
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x10B87A0
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x10B899C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAll
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x10B89EC
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10B89F4
	internal override bool get_IsEmpty() { }

	// RVA: 0x10B8A48
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10B8A50
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotated
{
	// Fields
	private string id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Methods

	// RVA: 0x10B8BAC
	public string get_Id() { }

	// RVA: 0x10B8BB4
	public void set_Id(string value) { }

	// RVA: 0x10B8BBC
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x10B8BC4
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x10B8BCC
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x10B8BD4
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x10B8BDC
	internal override string get_IdAttribute() { }

	// RVA: 0x10B8BE4
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10B8BEC
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10B8BF4
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x10B8BFC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotation
{
	// Fields
	private string id; // 0x38
	private XmlSchemaObjectCollection items; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Methods

	// RVA: 0x10B8C04
	public string get_Id() { }

	// RVA: 0x10B8C0C
	public void set_Id(string value) { }

	// RVA: 0x10B8C14
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10B8C1C
	internal override string get_IdAttribute() { }

	// RVA: 0x10B8C24
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10B8C2C
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10B8C34
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAny
{
	// Fields
	private string ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Methods

	// RVA: 0x10B8CAC
	public string get_Namespace() { }

	// RVA: 0x10B8CB4
	public void set_Namespace(string value) { }

	// RVA: 0x10B8CBC
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x10B8CC4
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x10B8CCC
	internal string get_ResolvedNamespace() { }

	// RVA: 0x10B8D28
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x10B8D3C
	internal override string get_NameString() { }

	// RVA: 0x10B922C
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x10B92B8
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x10B9364
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x10B9390
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAnyAttribute
{
	// Fields
	private string ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Methods

	// RVA: 0x10B9418
	public void set_Namespace(string value) { }

	// RVA: 0x10B9420
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0x10B9428
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x10B9430
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x10B9438
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x10B944C
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x10B94D8
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x10B9584
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x10B95B0
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x10B95D8
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x10B96B8
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x10B96B0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAppInfo
{
	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Methods

	// RVA: 0x10B9790
	public void set_Source(string value) { }

	// RVA: 0x10B9798
	public XmlNode[] get_Markup() { }

	// RVA: 0x10B97A0
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x10B97A8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAttribute
{
	// Fields
	private string defaultValue; // 0x50
	private string fixedValue; // 0x58
	private string name; // 0x60
	private XmlSchemaForm form; // 0x68
	private XmlSchemaUse use; // 0x6C
	private XmlQualifiedName refName; // 0x70
	private XmlQualifiedName typeName; // 0x78
	private XmlQualifiedName qualifiedName; // 0x80
	private XmlSchemaSimpleType type; // 0x88
	private XmlSchemaSimpleType attributeType; // 0x90
	private SchemaAttDef attDef; // 0x98

	// Methods

	// RVA: 0x10B97B0
	public string get_DefaultValue() { }

	// RVA: 0x10B97B8
	public void set_DefaultValue(string value) { }

	// RVA: 0x10B97C0
	public string get_FixedValue() { }

	// RVA: 0x10B97C8
	public void set_FixedValue(string value) { }

	// RVA: 0x10B97D0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x10B97D8
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x10B97E0
	public string get_Name() { }

	// RVA: 0x10B97E8
	public void set_Name(string value) { }

	// RVA: 0x10B97F0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10B97F8
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10B98D0
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x10B98D8
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x10B99B0
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x10B99B8
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x10B99C0
	public XmlSchemaUse get_Use() { }

	// RVA: 0x10B99C8
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x10B99D0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10B99D8
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x10B99E0
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x10B99F8
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10B9A00
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x10B9A08
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x10B9A10
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x10B9A18
	internal override string get_NameAttribute() { }

	// RVA: 0x10B9A20
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10B9A28
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10B9B30
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroup
{
	// Fields
	private string name; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaAttributeGroup redefined; // 0x70
	private XmlSchemaObjectTable attributeUses; // 0x78
	private XmlSchemaAnyAttribute attributeWildcard; // 0x80
	private int selfReferenceCount; // 0x88

	// Methods

	// RVA: 0x10B9BDC
	public string get_Name() { }

	// RVA: 0x10B9BE4
	public void set_Name(string value) { }

	// RVA: 0x10B9BEC
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10B9BF4
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10B9BFC
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10B9C04
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10B9C0C
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x10B9C94
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x10B9C9C
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10B9CA4
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x10B9CAC
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x10B9CB4
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x10B9CBC
	internal int get_SelfReferenceCount() { }

	// RVA: 0x10B9CC4
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x10B9CCC
	internal override string get_NameAttribute() { }

	// RVA: 0x10B9CD4
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10B9CDC
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10B9CE4
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10BA244
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroupRef
{
	// Fields
	private XmlQualifiedName refName; // 0x50

	// Methods

	// RVA: 0x10BA2F8
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10BA300
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10BA3D8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaChoice
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x10BA454
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10BA45C
	internal override bool get_IsEmpty() { }

	// RVA: 0x10BA464
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10BA46C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCollection
{
	// Fields
	private Hashtable collection; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ReaderWriterLock wLock; // 0x28
	private int timeout; // 0x30
	private bool isThreadSafe; // 0x34
	private ValidationEventHandler validationEventHandler; // 0x38
	private XmlResolver xmlResolver; // 0x40

	// Methods

	// RVA: 0x10BA540
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x10BA690
	public int get_Count() { }

	// RVA: 0x10BA6B8
	public XmlNameTable get_NameTable() { }

	// RVA: 0x10BA6C0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10BA6C8
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x10BA784
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x10BA868
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x10BA8FC
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x10BACCC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x10BACD4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x10BACD8
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x10B4A54
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x10BAD00
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x10B2EA4
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x10BADC0
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x10BAF48
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x10BB0AC
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x10BB0B4
	internal void set_EventHandler(ValidationEventHandler value) { }

}

// Namespace: System.Xml.Schema
internal sealed class XmlSchemaCollectionNode
{
	// Fields
	private string namespaceUri; // 0x10
	private SchemaInfo schemaInfo; // 0x18
	private XmlSchema schema; // 0x20

	// Methods

	// RVA: 0x10BB0BC
	internal void set_NamespaceURI(string value) { }

	// RVA: 0x10BB0C4
	internal SchemaInfo get_SchemaInfo() { }

	// RVA: 0x10BB0CC
	internal void set_SchemaInfo(SchemaInfo value) { }

	// RVA: 0x10BB0D4
	internal XmlSchema get_Schema() { }

	// RVA: 0x10BB0DC
	internal void set_Schema(XmlSchema value) { }

	// RVA: 0x10BAF40
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCollectionEnumerator
{
	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x10BA818
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x10BB0E4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x10BB19C
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x10BAC18
	public bool MoveNext() { }

	// RVA: 0x10BB250
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x10BAB24
	public XmlSchema get_Current() { }

	// RVA: 0x10BB254
	internal XmlSchemaCollectionNode get_CurrentNode() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCompilationSettings
{
	// Fields
	private bool enableUpaCheck; // 0x10

	// Methods

	// RVA: 0x10BB33C
	public void .ctor() { }

	// RVA: 0x10BB368
	public bool get_EnableUpaCheck() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContent
{
	// Fields
	private XmlSchemaContent content; // 0x50
	private bool isMixed; // 0x58
	private bool hasMixedAttribute; // 0x59

	// Methods

	// RVA: 0x10BB370
	public bool get_IsMixed() { }

	// RVA: 0x10BB378
	public void set_IsMixed(bool value) { }

	// RVA: 0x10BB388
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x10BB390
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x10BB398
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x10BB3A0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentExtension
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Methods

	// RVA: 0x10BB3B0
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10BB3B8
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10BB490
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x10BB498
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x10BB4A0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10BB4A8
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10BB4B0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10BB4B8
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10BB4C0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentRestriction
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Methods

	// RVA: 0x10BB57C
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10BB584
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10BB65C
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x10BB664
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x10BB66C
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10BB674
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10BB67C
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10BB684
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10BB68C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexType
{
	// Fields
	private XmlSchemaDerivationMethod block; // 0x94
	private XmlSchemaContentModel contentModel; // 0x98
	private XmlSchemaParticle particle; // 0xA0
	private XmlSchemaObjectCollection attributes; // 0xA8
	private XmlSchemaAnyAttribute anyAttribute; // 0xB0
	private XmlSchemaParticle contentTypeParticle; // 0xB8
	private XmlSchemaDerivationMethod blockResolved; // 0xC0
	private XmlSchemaObjectTable localElements; // 0xC8
	private XmlSchemaObjectTable attributeUses; // 0xD0
	private XmlSchemaAnyAttribute attributeWildcard; // 0xD8
	private static XmlSchemaComplexType anyTypeLax; // 0x0
	private static XmlSchemaComplexType anyTypeSkip; // 0x8
	private static XmlSchemaComplexType untypedAnyType; // 0x10
	private Byte pvFlags; // 0xE0

	// Methods

	// RVA: 0x10BB740
	private static void .cctor() { }

	// RVA: 0x10BBA30
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x10BBF9C
	public void .ctor() { }

	// RVA: 0x10BC0B0
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x10BC12C
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x10BC020
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x10BC1A8
	public bool get_IsAbstract() { }

	// RVA: 0x10BC1B4
	public void set_IsAbstract(bool value) { }

	// RVA: 0x10BC1D4
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x10BC1DC
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10BC1E4
	public override bool get_IsMixed() { }

	// RVA: 0x10BC1F0
	public override void set_IsMixed(bool value) { }

	// RVA: 0x10BC210
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x10BC218
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x10BC220
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x10BC228
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x10BC230
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10BC2B8
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10BC2C0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10BC2C8
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x10BC2D0
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0x10BC2D8
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x10BC2E0
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x10BC368
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x10BC370
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x10BC3F8
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x10BC400
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10BC408
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10BC410
	internal void set_HasWildCard(bool value) { }

	// RVA: 0x10BC424
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10BC42C
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x10BC994
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10B78E8
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10BCEE8
	private void ClearCompiledState() { }

	// RVA: 0x10B9F80
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x10BD020
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x10BCC24
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x10BD29C
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x10BC99C
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x10B9E14
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContent
{
	// Methods

	// RVA: 0x10BB574
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContentModel
{
	// Methods

	// RVA: -1
	public abstract XmlSchemaContent get_Content() { }

	// RVA: -1
	public abstract void set_Content(XmlSchemaContent value) { }

	// RVA: 0x10BB3A8
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaContentProcessing
{
	// Fields
	public int value__; // 0x10
	public const XmlSchemaContentProcessing None = 0;
	public const XmlSchemaContentProcessing Skip = 1;
	public const XmlSchemaContentProcessing Lax = 2;
	public const XmlSchemaContentProcessing Strict = 3;
}

// Namespace: System.Xml.Schema
public enum XmlSchemaContentType
{
	// Fields
	public int value__; // 0x10
	public const XmlSchemaContentType TextOnly = 0;
	public const XmlSchemaContentType Empty = 1;
	public const XmlSchemaContentType ElementOnly = 2;
	public const XmlSchemaContentType Mixed = 3;
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaDatatype
{
	// Methods

	// RVA: -1
	public abstract Type get_ValueType() { }

	// RVA: -1
	public abstract XmlTokenizedType get_TokenizedType() { }

	// RVA: -1
	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x10BD2C8
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x10BD2D0
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: 0x10BD2D8
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: -1
	internal abstract bool get_HasLexicalFacets() { }

	// RVA: -1
	internal abstract bool get_HasValueFacets() { }

	// RVA: -1
	internal abstract XmlValueConverter get_ValueConverter() { }

	// RVA: -1
	internal abstract RestrictionFacets get_Restriction() { }

	// RVA: -1
	internal abstract int Compare(object value1, object value2) { }

	// RVA: -1
	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: -1
	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: -1
	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, object typedValue) { }

	// RVA: -1
	internal abstract FacetsChecker get_FacetsChecker() { }

	// RVA: -1
	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: -1
	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: -1
	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: -1
	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: -1
	internal abstract bool IsEqual(object o1, object o2) { }

	// RVA: -1
	internal abstract bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x10BD2E0
	internal string get_TypeCodeString() { }

	// RVA: 0x10BD418
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x10BDB84
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x10ABB64
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x10BE294
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x10A9F58
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x10BE31C
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x10A76E0
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x10BE388
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaDerivationMethod
{
	// Fields
	public int value__; // 0x10
	public const XmlSchemaDerivationMethod Empty = 0;
	public const XmlSchemaDerivationMethod Substitution = 1;
	public const XmlSchemaDerivationMethod Extension = 2;
	public const XmlSchemaDerivationMethod Restriction = 4;
	public const XmlSchemaDerivationMethod List = 8;
	public const XmlSchemaDerivationMethod Union = 16;
	public const XmlSchemaDerivationMethod All = 255;
	public const XmlSchemaDerivationMethod None = 256;
}

// Namespace: System.Xml.Schema
public class XmlSchemaDocumentation
{
	// Fields
	private string source; // 0x38
	private string language; // 0x40
	private XmlNode[] markup; // 0x48
	private static XmlSchemaSimpleType languageType; // 0x0

	// Methods

	// RVA: 0x10BE390
	public void set_Source(string value) { }

	// RVA: 0x10BE398
	public void set_Language(string value) { }

	// RVA: 0x10BE4B0
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x10BE4B8
	public void .ctor() { }

	// RVA: 0x10BE4C0
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaElement
{
	// Fields
	private bool isAbstract; // 0x74
	private bool hasAbstractAttribute; // 0x75
	private bool isNillable; // 0x76
	private bool hasNillableAttribute; // 0x77
	private bool isLocalTypeDerivationChecked; // 0x78
	private XmlSchemaDerivationMethod block; // 0x7C
	private XmlSchemaDerivationMethod final; // 0x80
	private XmlSchemaForm form; // 0x84
	private string defaultValue; // 0x88
	private string fixedValue; // 0x90
	private string name; // 0x98
	private XmlQualifiedName refName; // 0xA0
	private XmlQualifiedName substitutionGroup; // 0xA8
	private XmlQualifiedName typeName; // 0xB0
	private XmlSchemaType type; // 0xB8
	private XmlQualifiedName qualifiedName; // 0xC0
	private XmlSchemaType elementType; // 0xC8
	private XmlSchemaDerivationMethod blockResolved; // 0xD0
	private XmlSchemaDerivationMethod finalResolved; // 0xD4
	private XmlSchemaObjectCollection constraints; // 0xD8
	private SchemaElementDecl elementDecl; // 0xE0

	// Methods

	// RVA: 0x10BE5B0
	public bool get_IsAbstract() { }

	// RVA: 0x10BE5B8
	public void set_IsAbstract(bool value) { }

	// RVA: 0x10BE5C8
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x10BE5D0
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10BE5D8
	public string get_DefaultValue() { }

	// RVA: 0x10BE5E0
	public void set_DefaultValue(string value) { }

	// RVA: 0x10BE5E8
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x10BE5F0
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10BE5F8
	public string get_FixedValue() { }

	// RVA: 0x10BE600
	public void set_FixedValue(string value) { }

	// RVA: 0x10BE608
	public XmlSchemaForm get_Form() { }

	// RVA: 0x10BE610
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x10BE618
	public string get_Name() { }

	// RVA: 0x10BE620
	public void set_Name(string value) { }

	// RVA: 0x10BE628
	public bool get_IsNillable() { }

	// RVA: 0x10BE630
	public void set_IsNillable(bool value) { }

	// RVA: 0x10BE640
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x10BE648
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x10BE650
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10BE658
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10BE730
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x10BE738
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x10BE810
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x10BE818
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x10BE8F0
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x10BE8F8
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10BE900
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0x10BE988
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10BE990
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x10BE998
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x10BE9A0
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x10BE9A8
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10BE9B0
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x10BE9B8
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10BE9C0
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10BE9C8
	internal bool get_HasConstraints() { }

	// RVA: 0x10BE9F0
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x10BE9F8
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x10BEA00
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x10BEA08
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x10BEA10
	internal override string get_NameAttribute() { }

	// RVA: 0x10BEA18
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10BEA20
	internal override string get_NameString() { }

	// RVA: 0x10BEA44
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10B808C
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10BEA4C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaException
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string sourceUri; // 0xA0
	private int lineNumber; // 0xA8
	private int linePosition; // 0xAC
	private XmlSchemaObject sourceSchemaObject; // 0xB0
	private string message; // 0xB8

	// Methods

	// RVA: 0x10BEB54
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10BF02C
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10BF1A0
	public void .ctor() { }

	// RVA: 0x10BF1B4
	public void .ctor(string message) { }

	// RVA: 0x10BF310
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x10BF1C4
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x10BF3D8
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x10B5088
	internal void .ctor(string res, string arg) { }

	// RVA: 0x10ADD90
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10BF470
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10ADBB4
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10BF518
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x10BF5E0
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x10BF524
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x10BF31C
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x10BEF60
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x10BF684
	internal string get_GetRes() { }

	// RVA: 0x10BF68C
	internal string[] get_Args() { }

	// RVA: 0x10BF694
	public string get_SourceUri() { }

	// RVA: 0x10BF69C
	public int get_LineNumber() { }

	// RVA: 0x10BF6A4
	public int get_LinePosition() { }

	// RVA: 0x10BF6AC
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x10B4408
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10BF6B4
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x10BF6BC
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x10BF704
	public override string get_Message() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaExternal
{
	// Fields
	private string location; // 0x38
	private Uri baseUri; // 0x40
	private XmlSchema schema; // 0x48
	private string id; // 0x50
	private XmlAttribute[] moreAttributes; // 0x58
	private Compositor compositor; // 0x60

	// Methods

	// RVA: 0x10BF71C
	public string get_SchemaLocation() { }

	// RVA: 0x10BF724
	public void set_SchemaLocation(string value) { }

	// RVA: 0x10BF72C
	public XmlSchema get_Schema() { }

	// RVA: 0x10BF734
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x10BF73C
	public string get_Id() { }

	// RVA: 0x10BF744
	public void set_Id(string value) { }

	// RVA: 0x10BF74C
	internal Uri get_BaseUri() { }

	// RVA: 0x10BF754
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x10BF75C
	internal override string get_IdAttribute() { }

	// RVA: 0x10BF764
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10BF76C
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10BF774
	internal Compositor get_Compositor() { }

	// RVA: 0x10BF77C
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x10BF784
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal enum FacetType
{
	// Fields
	public int value__; // 0x10
	public const FacetType None = 0;
	public const FacetType Length = 1;
	public const FacetType MinLength = 2;
	public const FacetType MaxLength = 3;
	public const FacetType Pattern = 4;
	public const FacetType Whitespace = 5;
	public const FacetType Enumeration = 6;
	public const FacetType MinExclusive = 7;
	public const FacetType MinInclusive = 8;
	public const FacetType MaxExclusive = 9;
	public const FacetType MaxInclusive = 10;
	public const FacetType TotalDigits = 11;
	public const FacetType FractionDigits = 12;
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaFacet
{
	// Fields
	private string value; // 0x50
	private bool isFixed; // 0x58
	private FacetType facetType; // 0x5C

	// Methods

	// RVA: 0x10BF78C
	public string get_Value() { }

	// RVA: 0x10BF794
	public void set_Value(string value) { }

	// RVA: 0x10BF79C
	public virtual bool get_IsFixed() { }

	// RVA: 0x10BF7A4
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x10BF860
	internal FacetType get_FacetType() { }

	// RVA: 0x10BF868
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x10BF870
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaNumericFacet
{
	// Methods

	// RVA: 0x10BF878
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaLengthFacet
{
	// Methods

	// RVA: 0x10BF880
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinLengthFacet
{
	// Methods

	// RVA: 0x10BF8AC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxLengthFacet
{
	// Methods

	// RVA: 0x10BF8D8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaPatternFacet
{
	// Methods

	// RVA: 0x10BF904
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaEnumerationFacet
{
	// Methods

	// RVA: 0x10BF930
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinExclusiveFacet
{
	// Methods

	// RVA: 0x10BF95C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinInclusiveFacet
{
	// Methods

	// RVA: 0x10BF988
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxExclusiveFacet
{
	// Methods

	// RVA: 0x10BF9B4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxInclusiveFacet
{
	// Methods

	// RVA: 0x10BF9E0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaTotalDigitsFacet
{
	// Methods

	// RVA: 0x10BFA0C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaFractionDigitsFacet
{
	// Methods

	// RVA: 0x10BFA38
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaWhiteSpaceFacet
{
	// Methods

	// RVA: 0x10BFA64
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaForm
{
	// Fields
	public int value__; // 0x10
	public const XmlSchemaForm None = 0;
	public const XmlSchemaForm Qualified = 1;
	public const XmlSchemaForm Unqualified = 2;
}

// Namespace: System.Xml.Schema
public class XmlSchemaGroup
{
	// Fields
	private string name; // 0x50
	private XmlSchemaGroupBase particle; // 0x58
	private XmlSchemaParticle canonicalParticle; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaGroup redefined; // 0x70
	private int selfReferenceCount; // 0x78

	// Methods

	// RVA: 0x10BFA90
	public string get_Name() { }

	// RVA: 0x10BFA98
	public void set_Name(string value) { }

	// RVA: 0x10BFAA0
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x10BFAA8
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x10BFAB0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10BFAB8
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x10BFAC0
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x10BFAC8
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x10BFAD0
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x10BFAD8
	internal int get_SelfReferenceCount() { }

	// RVA: 0x10BFAE0
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x10BFAE8
	internal override string get_NameAttribute() { }

	// RVA: 0x10BFAF0
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10BFAF8
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10BFB00
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10B82C8
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10BFB08
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaGroupBase
{
	// Methods

	// RVA: -1
	public abstract XmlSchemaObjectCollection get_Items() { }

	// RVA: -1
	internal abstract void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10B8B24
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaGroupRef
{
	// Fields
	private XmlQualifiedName refName; // 0x78
	private XmlSchemaGroupBase particle; // 0x80
	private XmlSchemaGroup refined; // 0x88

	// Methods

	// RVA: 0x10BFB84
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10BD1C4
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10BFB8C
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x10BFB94
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x10BFB9C
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x10BFBA4
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x10BFBAC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaIdentityConstraint
{
	// Fields
	private string name; // 0x50
	private XmlSchemaXPath selector; // 0x58
	private XmlSchemaObjectCollection fields; // 0x60
	private XmlQualifiedName qualifiedName; // 0x68
	private CompiledIdentityConstraint compiledConstraint; // 0x70

	// Methods

	// RVA: 0x10BFC64
	public string get_Name() { }

	// RVA: 0x10BFC6C
	public void set_Name(string value) { }

	// RVA: 0x10BFC74
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x10BFC7C
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x10BFC84
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x10BFC8C
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10BFC94
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10BFC9C
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x10BFCA4
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x10BFCAC
	internal override string get_NameAttribute() { }

	// RVA: 0x10BFCB4
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10BFCBC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaXPath
{
	// Fields
	private string xpath; // 0x50

	// Methods

	// RVA: 0x10BFD70
	public string get_XPath() { }

	// RVA: 0x10BFD78
	public void set_XPath(string value) { }

	// RVA: 0x10BFD80
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaUnique
{
	// Methods

	// RVA: 0x10BFD88
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaKey
{
	// Methods

	// RVA: 0x10BFD8C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaKeyref
{
	// Fields
	private XmlQualifiedName refer; // 0x78

	// Methods

	// RVA: 0x10BFD90
	public XmlQualifiedName get_Refer() { }

	// RVA: 0x10BFD98
	public void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x10BFE70
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaImport
{
	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Methods

	// RVA: 0x10BFEE8
	public void .ctor() { }

	// RVA: 0x10BFF14
	public string get_Namespace() { }

	// RVA: 0x10BFF1C
	public void set_Namespace(string value) { }

	// RVA: 0x10BFF24
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaInclude
{
	// Fields
	private XmlSchemaAnnotation annotation; // 0x68

	// Methods

	// RVA: 0x10BFF2C
	public void .ctor() { }

	// RVA: 0x10BFF58
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaInfo
{
	// Fields
	private bool isDefault; // 0x10
	private bool isNil; // 0x11
	private XmlSchemaElement schemaElement; // 0x18
	private XmlSchemaAttribute schemaAttribute; // 0x20
	private XmlSchemaType schemaType; // 0x28
	private XmlSchemaSimpleType memberType; // 0x30
	private XmlSchemaValidity validity; // 0x38
	private XmlSchemaContentType contentType; // 0x3C

	// Methods

	// RVA: 0x10BFF60
	public void .ctor() { }

	// RVA: 0x10C003C
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x10C00B0
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0x10C00B8
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x10C00C0
	public bool get_IsDefault() { }

	// RVA: 0x10C00C8
	public void set_IsDefault(bool value) { }

	// RVA: 0x10C00D0
	public bool get_IsNil() { }

	// RVA: 0x10C00D8
	public void set_IsNil(bool value) { }

	// RVA: 0x10C00E0
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x10C00E8
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x10C00F0
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x10C00F8
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10C0148
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x10C0150
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x10C0194
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x10C019C
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x10C01E0
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x10C01E8
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x10C0204
	internal bool get_HasDefaultValue() { }

	// RVA: 0x10C0240
	internal bool get_IsUnionType() { }

	// RVA: 0x10BFFD4
	internal void Clear() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaNotation
{
	// Fields
	private string name; // 0x50
	private string publicId; // 0x58
	private string systemId; // 0x60
	private XmlQualifiedName qname; // 0x68

	// Methods

	// RVA: 0x10C0280
	public string get_Name() { }

	// RVA: 0x10C0288
	public void set_Name(string value) { }

	// RVA: 0x10C0290
	public string get_Public() { }

	// RVA: 0x10C0298
	public void set_Public(string value) { }

	// RVA: 0x10C02A0
	public string get_System() { }

	// RVA: 0x10C02A8
	public void set_System(string value) { }

	// RVA: 0x10C02B0
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10C02B8
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10C02C0
	internal override string get_NameAttribute() { }

	// RVA: 0x10C02C8
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10C02D0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaObject
{
	// Fields
	private int lineNum; // 0x10
	private int linePos; // 0x14
	private string sourceUri; // 0x18
	private XmlSerializerNamespaces namespaces; // 0x20
	private XmlSchemaObject parent; // 0x28
	private bool isProcessing; // 0x30

	// Methods

	// RVA: 0x10C034C
	public int get_LineNumber() { }

	// RVA: 0x10C0354
	public void set_LineNumber(int value) { }

	// RVA: 0x10C035C
	public int get_LinePosition() { }

	// RVA: 0x10C0364
	public void set_LinePosition(int value) { }

	// RVA: 0x10C036C
	public string get_SourceUri() { }

	// RVA: 0x10C0374
	public void set_SourceUri(string value) { }

	// RVA: 0x10C037C
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x10C0384
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x10B73A8
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x10C038C
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x10C0394
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x10C0398
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x10C039C
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x10C03A0
	internal virtual string get_IdAttribute() { }

	// RVA: 0x10C03A8
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x10C03AC
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10C03B0
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x10C03B4
	internal virtual string get_NameAttribute() { }

	// RVA: 0x10C03BC
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x10C03C0
	internal bool get_IsProcessing() { }

	// RVA: 0x10C03C8
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x10C03D0
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x10B69A8
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectCollection
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Methods

	// RVA: 0x10B69A0
	public void .ctor() { }

	// RVA: 0x10C0454
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x10C0574
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x10C0640
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x10B84E4
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x10C06C0
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x10C078C
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x10C0850
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x10C086C
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x10C08CC
	protected override void OnClear() { }

	// RVA: 0x10C08E8
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x10BCF94
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x10C0904
	private void Add(XmlSchemaObjectCollection collToAdd) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x10C0934
	internal void .ctor(IEnumerator enumerator) { }

	// RVA: 0x10C0968
	public bool MoveNext() { }

	// RVA: 0x10C0A1C
	public XmlSchemaObject get_Current() { }

	// RVA: 0x10C0B20
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x10C0BD8
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x10C0C8C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
internal enum EnumeratorType
{
	// Fields
	public int value__; // 0x10
	public const EnumeratorType Keys = 0;
	public const EnumeratorType Values = 1;
	public const EnumeratorType DictionaryEntry = 2;
}

// Namespace: 
internal struct XmlSchemaObjectEntry
{
	// Fields
	internal XmlQualifiedName qname; // 0x10
	internal XmlSchemaObject xso; // 0x18

	// Methods

	// RVA: 0x10C0EF8
	public void .ctor(XmlQualifiedName name, XmlSchemaObject value) { }

}

// Namespace: 
internal class ValuesCollection
{
	// Fields
	private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private int size; // 0x18

	// Methods

	// RVA: 0x10C1710
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x10C1860
	public int get_Count() { }

	// RVA: 0x10C1868
	public object get_SyncRoot() { }

	// RVA: 0x10C1920
	public bool get_IsSynchronized() { }

	// RVA: 0x10C19D8
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x10C1B28
	public IEnumerator GetEnumerator() { }

}

// Namespace: 
internal class XSOEnumerator
{
	// Fields
	private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private EnumeratorType enumType; // 0x18
	protected int currentIndex; // 0x1C
	protected int size; // 0x20
	protected XmlQualifiedName currentKey; // 0x28
	protected XmlSchemaObject currentValue; // 0x30

	// Methods

	// RVA: 0x10C1BB4
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

	// RVA: 0x10C1C08
	public object get_Current() { }

	// RVA: 0x10C1DE8
	public bool MoveNext() { }

	// RVA: 0x10C1ED8
	public void Reset() { }

}

// Namespace: 
internal class XSODictionaryEnumerator
{
	// Methods

	// RVA: 0x10C180C
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

	// RVA: 0x10C1F14
	public DictionaryEntry get_Entry() { }

	// RVA: 0x10C2064
	public object get_Key() { }

	// RVA: 0x10C2198
	public object get_Value() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectTable
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaObject> table; // 0x10
	private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Methods

	// RVA: 0x10C0D44
	internal void .ctor() { }

	// RVA: 0x10C0E24
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x10C0F2C
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x10C1188
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x10C1320
	internal void Clear() { }

	// RVA: 0x10C13E4
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x10C10D8
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x10C152C
	public int get_Count() { }

	// RVA: 0x10C1580
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x10C15E4
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x10C1668
	public ICollection get_Values() { }

	// RVA: 0x10C1758
	public IDictionaryEnumerator GetEnumerator() { }

}

// Namespace: 
private enum Occurs
{
	// Fields
	public int value__; // 0x10
	public const Occurs None = 0;
	public const Occurs Min = 1;
	public const Occurs Max = 2;
}

// Namespace: 
private class EmptyParticle
{
	// Methods

	// RVA: 0x10C3024
	internal override bool get_IsEmpty() { }

	// RVA: 0x10C2F3C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaParticle
{
	// Fields
	private Decimal minOccurs; // 0x50
	private Decimal maxOccurs; // 0x60
	private Occurs flags; // 0x70
	internal static readonly XmlSchemaParticle Empty; // 0x0

	// Methods

	// RVA: 0x10C22CC
	public string get_MinOccursString() { }

	// RVA: 0x10C2368
	public void set_MinOccursString(string value) { }

	// RVA: 0x10C24D0
	public string get_MaxOccursString() { }

	// RVA: 0x10C261C
	public void set_MaxOccursString(string value) { }

	// RVA: 0x10C2848
	public Decimal get_MinOccurs() { }

	// RVA: 0x10C2854
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0x10C298C
	public Decimal get_MaxOccurs() { }

	// RVA: 0x10C2998
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x10C2B10
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x10C2B88
	internal virtual string get_NameString() { }

	// RVA: 0x10C2BD4
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x10C2D7C
	protected void .ctor() { }

	// RVA: 0x10C2DFC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaRedefine
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x68
	private XmlSchemaObjectTable attributeGroups; // 0x70
	private XmlSchemaObjectTable types; // 0x78
	private XmlSchemaObjectTable groups; // 0x80

	// Methods

	// RVA: 0x10C302C
	public void .ctor() { }

	// RVA: 0x10C3124
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10C312C
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x10C3134
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x10C313C
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x10C3144
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSequence
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x10C3164
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10C316C
	internal override bool get_IsEmpty() { }

	// RVA: 0x10C321C
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10C3224
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSet
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private SortedList schemas; // 0x20
	private ValidationEventHandler internalEventHandler; // 0x28
	private ValidationEventHandler eventHandler; // 0x30
	private bool isCompiled; // 0x38
	private Hashtable schemaLocations; // 0x40
	private Hashtable chameleonSchemas; // 0x48
	private Hashtable targetNamespaces; // 0x50
	private bool compileAll; // 0x58
	private SchemaInfo cachedCompiledInfo; // 0x60
	private XmlReaderSettings readerSettings; // 0x68
	private XmlSchema schemaForSchema; // 0x70
	private XmlSchemaCompilationSettings compilationSettings; // 0x78
	internal XmlSchemaObjectTable elements; // 0x80
	internal XmlSchemaObjectTable attributes; // 0x88
	internal XmlSchemaObjectTable schemaTypes; // 0x90
	internal XmlSchemaObjectTable substitutionGroups; // 0x98
	private XmlSchemaObjectTable typeExtensions; // 0xA0
	private object internalSyncObject; // 0xA8

	// Methods

	// RVA: 0x10C329C
	internal object get_InternalSyncObject() { }

	// RVA: 0x10C3324
	public void .ctor() { }

	// RVA: 0x10C338C
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x10C3690
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10C37B8
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10C3894
	public bool get_IsCompiled() { }

	// RVA: 0x10C389C
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10C38BC
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x10C38C4
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x10C38CC
	public int get_Count() { }

	// RVA: 0x10C38F4
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x10C3978
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x10C39FC
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x10C3A80
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x10C3B04
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x10C3B0C
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x10C3B90
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x10C6558
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x10C67B4
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x10C7844
	public bool Contains(string targetNamespace) { }

	// RVA: 0x10C78D8
	public void Compile() { }

	// RVA: 0x10C80A4
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x10C9EA4
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x10CA020
	public ICollection Schemas() { }

	// RVA: 0x10C9BBC
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x10C64E8
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x10CA514
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x10C626C
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x10CA048
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x10CAE88
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x10CB3B8
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x10C742C
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x10C7EA4
	private void ClearTables() { }

	// RVA: 0x10C9D78
	internal bool PreprocessSchema(XmlSchema schema, string targetNamespace) { }

	// RVA: 0x10CAC78
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x10C45C0
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x10CBE10
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x10CBE18
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x10CBE20
	internal XmlResolver GetResolver() { }

	// RVA: 0x10CBE40
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x10CBBE4
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x10CA8E8
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, XmlSchema schema) { }

	// RVA: 0x10CBE48
	internal bool GetSchemaByUri(Uri schemaUri, XmlSchema schema) { }

	// RVA: 0x10C7314
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x10CBFE0
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x10C958C
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x10C89E4
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x10CB838
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x10CBCA4
	private void VerifyTables() { }

	// RVA: 0x10CBFE8
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x10C7380
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContent
{
	// Fields
	private XmlSchemaContent content; // 0x50

	// Methods

	// RVA: 0x10CC038
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x10CC040
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x10CC048
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentExtension
{
	// Fields
	private XmlSchemaObjectCollection attributes; // 0x50
	private XmlSchemaAnyAttribute anyAttribute; // 0x58
	private XmlQualifiedName baseTypeName; // 0x60

	// Methods

	// RVA: 0x10CC050
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10CC058
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10CC130
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10CC138
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10CC140
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10CC148
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10CC150
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentRestriction
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60
	private XmlSchemaObjectCollection attributes; // 0x68
	private XmlSchemaAnyAttribute anyAttribute; // 0x70

	// Methods

	// RVA: 0x10CC204
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10CC20C
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10CC2E4
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x10CC2EC
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x10CC2F4
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x10CC2FC
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10CC304
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10CC30C
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10CC314
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10CC31C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleType
{
	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Methods

	// RVA: 0x10CC3F4
	public void .ctor() { }

	// RVA: 0x10CC50C
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x10CC514
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0x10CC51C
	internal override XmlSchemaObject Clone() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaSimpleTypeContent
{
	// Methods

	// RVA: 0x10CC62C
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeList
{
	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Methods

	// RVA: 0x10CC634
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0x10CC63C
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x10CC714
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x10CC71C
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x10CC724
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x10CC72C
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x10CC734
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10CC7F8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeRestriction
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60

	// Methods

	// RVA: 0x10CC874
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10CC87C
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10CC954
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x10CC95C
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x10CC964
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x10CC96C
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10CCA30
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeUnion
{
	// Fields
	private XmlSchemaObjectCollection baseTypes; // 0x50
	private XmlQualifiedName[] memberTypes; // 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; // 0x60

	// Methods

	// RVA: 0x10CCAE4
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x10CCAEC
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x10CCAF4
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x10CCAFC
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x10CCB04
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0x10CCB0C
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10CCCD0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroup
{
	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Methods

	// RVA: 0x10CCD48
	internal ArrayList get_Members() { }

	// RVA: 0x10CCD50
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x10CCD58
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0x10CCD60
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroupV1Compat
{
	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Methods

	// RVA: 0x10CCE14
	internal XmlSchemaChoice get_Choice() { }

	// RVA: 0x10CCE1C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaType
{
	// Fields
	private string name; // 0x50
	private XmlSchemaDerivationMethod final; // 0x58
	private XmlSchemaDerivationMethod derivedBy; // 0x5C
	private XmlSchemaType baseSchemaType; // 0x60
	private XmlSchemaDatatype datatype; // 0x68
	private XmlSchemaDerivationMethod finalResolved; // 0x70
	private SchemaElementDecl elementDecl; // 0x78
	private XmlQualifiedName qname; // 0x80
	private XmlSchemaType redefined; // 0x88
	private XmlSchemaContentType contentType; // 0x90

	// Methods

	// RVA: 0x10CCE90
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x10CCFAC
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0x10CD034
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x10CD334
	public string get_Name() { }

	// RVA: 0x10CD33C
	public void set_Name(string value) { }

	// RVA: 0x10CD344
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x10CD34C
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10CBDEC
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10CD354
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x10CD35C
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x10CD364
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x10CD36C
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x10CD374
	public virtual bool get_IsMixed() { }

	// RVA: 0x10CD37C
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0x10CD380
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0x10CD478
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0x10CD508
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0x10CD510
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10CD540
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10CD548
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x10CD550
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10CD558
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0x10CD560
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x10CD584
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x10CD5B4
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x10CD5BC
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0x10CD5C4
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0x10CD5CC
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x10CD844
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x10CD950
	internal override string get_NameAttribute() { }

	// RVA: 0x10CD958
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10CC480
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaUse
{
	// Fields
	public int value__; // 0x10
	public const XmlSchemaUse None = 0;
	public const XmlSchemaUse Optional = 1;
	public const XmlSchemaUse Prohibited = 2;
	public const XmlSchemaUse Required = 3;
}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaValidationException
{
	// Methods

	// RVA: 0x10CD960
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10CD968
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10CD970
	public void .ctor() { }

	// RVA: 0x10CD97C
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10CDA50
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10CDA84
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Schema
public sealed class XmlValueGetter
{
	// Methods

	// RVA: 0x10CDAA8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10CDB48
	public virtual object Invoke() { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaValidationFlags
{
	// Fields
	public int value__; // 0x10
	public const XmlSchemaValidationFlags None = 0;
	public const XmlSchemaValidationFlags ProcessInlineSchema = 1;
	public const XmlSchemaValidationFlags ProcessSchemaLocation = 2;
	public const XmlSchemaValidationFlags ReportValidationWarnings = 4;
	public const XmlSchemaValidationFlags ProcessIdentityConstraints = 8;
	public const XmlSchemaValidationFlags AllowXmlAttributes = 16;
}

// Namespace: System.Xml.Schema
internal enum ValidatorState
{
	// Fields
	public int value__; // 0x10
	public const ValidatorState None = 0;
	public const ValidatorState Start = 1;
	public const ValidatorState TopLevelAttribute = 2;
	public const ValidatorState TopLevelTextOrWS = 3;
	public const ValidatorState Element = 4;
	public const ValidatorState Attribute = 5;
	public const ValidatorState EndOfAttributes = 6;
	public const ValidatorState Text = 7;
	public const ValidatorState Whitespace = 8;
	public const ValidatorState EndElement = 9;
	public const ValidatorState SkipToEndElement = 10;
	public const ValidatorState Finish = 11;
}

// Namespace: System.Xml.Schema
internal class IdRefNode
{
	// Fields
	internal string Id; // 0x10
	internal int LineNo; // 0x18
	internal int LinePos; // 0x1C
	internal IdRefNode Next; // 0x20

	// Methods

	// RVA: 0x10CDB5C
	internal void .ctor(IdRefNode next, string id, int lineNo, int linePos) { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaValidator
{
	// Fields
	private XmlSchemaSet schemaSet; // 0x10
	private XmlSchemaValidationFlags validationFlags; // 0x18
	private int startIDConstraint; // 0x1C
	private bool isRoot; // 0x20
	private bool rootHasSchema; // 0x21
	private bool attrValid; // 0x22
	private bool checkEntity; // 0x23
	private SchemaInfo compiledSchemaInfo; // 0x28
	private IDtdInfo dtdSchemaInfo; // 0x30
	private Hashtable validatedNamespaces; // 0x38
	private HWStack validationStack; // 0x40
	private ValidationState context; // 0x48
	private ValidatorState currentState; // 0x50
	private Hashtable attPresence; // 0x58
	private SchemaAttDef wildID; // 0x60
	private Hashtable IDs; // 0x68
	private IdRefNode idRefListHead; // 0x70
	private XmlQualifiedName contextQName; // 0x78
	private string NsXs; // 0x80
	private string NsXsi; // 0x88
	private string NsXmlNs; // 0x90
	private string NsXml; // 0x98
	private XmlSchemaObject partialValidationType; // 0xA0
	private StringBuilder textValue; // 0xA8
	private ValidationEventHandler eventHandler; // 0xB0
	private object validationEventSender; // 0xB8
	private XmlNameTable nameTable; // 0xC0
	private IXmlLineInfo positionInfo; // 0xC8
	private IXmlLineInfo dummyPositionInfo; // 0xD0
	private XmlResolver xmlResolver; // 0xD8
	private Uri sourceUri; // 0xE0
	private string sourceUriString; // 0xE8
	private IXmlNamespaceResolver nsResolver; // 0xF0
	private XmlSchemaContentProcessing processContents; // 0xF8
	private string xsiTypeString; // 0x100
	private string xsiNilString; // 0x108
	private string xsiSchemaLocationString; // 0x110
	private string xsiNoNamespaceSchemaLocationString; // 0x118
	private static readonly XmlSchemaDatatype dtQName; // 0x0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private static XmlSchemaParticle[] EmptyParticleArray; // 0x18
	private static XmlSchemaAttribute[] EmptyAttributeArray; // 0x20
	private XmlCharType xmlCharType; // 0x120
	internal static Boolean[,] ValidStates; // 0x28
	private static string[] MethodNames; // 0x30

	// Methods

	// RVA: 0x10CDBC0
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0x10CDDF4
	private void Init() { }

	// RVA: 0x10CE328
	private void Reset() { }

	// RVA: 0x10CE4B4
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10CE4BC
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0x10CE4D4
	public void set_SourceUri(Uri value) { }

	// RVA: 0x10CE524
	public void set_ValidationEventSender(object value) { }

	// RVA: 0x10CE52C
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10CE5E0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10CE694
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0x10CEEA4
	public void Initialize() { }

	// RVA: 0x10CEFE8
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0x10CF2A0
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x10D1008
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10D106C
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10D2588
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10D28F0
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0x10D2954
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x10D3330
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0x10D3394
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x10D3608
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10D3B1C
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10D3EA4
	public void EndValidation() { }

	// RVA: 0x10D4120
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x10D4D08
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x10D4D10
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x10D4D18
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0x10D4D54
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0x10D4D84
	private bool get_StrictlyAssessed() { }

	// RVA: 0x10D4DD0
	private bool get_HasSchema() { }

	// RVA: 0x10D4E24
	internal string GetConcatenatedValue() { }

	// RVA: 0x10D3610
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0x10D00AC
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x10CF928
	private object ValidateElementContext(XmlQualifiedName elementName, bool invalidElementInContext) { }

	// RVA: 0x10D6C50
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0x10D4E48
	private object ValidateAtomicValue(string stringValue, XmlSchemaSimpleType memberType) { }

	// RVA: 0x10D5134
	private object ValidateAtomicValue(object parsedValue, XmlSchemaSimpleType memberType) { }

	// RVA: 0x10D7CD0
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0x10D2DA8
	private void SaveTextValue(object value) { }

	// RVA: 0x10CE1B8
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x10D3D30
	private void Pop() { }

	// RVA: 0x10CFE24
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0x10D03FC
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, bool declFound) { }

	// RVA: 0x10D0B28
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0x10D0D50
	private void CheckElementProperties() { }

	// RVA: 0x10D0E58
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x10D1C34
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0x10D85F8
	private void AddXmlNamespaceSchema() { }

	// RVA: 0x10D5500
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0x10D6738
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x10CE3D4
	internal void RecompileSchemaSet() { }

	// RVA: 0x10D88B4
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0x10D1EBC
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0x10D7A00
	private object CheckElementValue(string stringValue) { }

	// RVA: 0x10D2120
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0x10D8BAC
	private object FindId(string name) { }

	// RVA: 0x10D3F94
	private void CheckForwardRefs() { }

	// RVA: 0x10D22B0
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x10D7DA0
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0x10D8EA4
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0x10CE4A4
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0x10CF694
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0x10CF8D0
	private void ClearPSVI() { }

	// RVA: 0x10D2670
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0x10D0EC4
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0x10D482C
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0x10D7DAC
	private void AddIdentityConstraints() { }

	// RVA: 0x10D820C
	private void ElementIdentityConstraints() { }

	// RVA: 0x10D22D0
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0x10D5B50
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0x10D70B8
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x10D5608
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x10D2F4C
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0x10D94A4
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0x10D8F7C
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0x10D962C
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0x10D2D24
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0x10D6E30
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0x10D2DF0
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0x10D8BC8
	private void ProcessEntity(string name) { }

	// RVA: 0x10D7D3C
	private void SendValidationEvent(string code) { }

	// RVA: 0x10D1D18
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x10D1A28
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0x10D6EAC
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0x10D86D0
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0x10CECF4
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0x10D8EB0
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0x10D6B98
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x10CEAB4
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x10D8D68
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x10D8EB8
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x10D9870
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
public enum XmlSchemaValidity
{
	// Fields
	public int value__; // 0x10
	public const XmlSchemaValidity NotKnown = 0;
	public const XmlSchemaValidity Valid = 1;
	public const XmlSchemaValidity Invalid = 2;
}

// Namespace: System.Xml.Schema
public enum XmlSeverityType
{
	// Fields
	public int value__; // 0x10
	public const XmlSeverityType Error = 0;
	public const XmlSeverityType Warning = 1;
}

// Namespace: System.Xml.Schema
public enum XmlTypeCode
{
	// Fields
	public int value__; // 0x10
	public const XmlTypeCode None = 0;
	public const XmlTypeCode Item = 1;
	public const XmlTypeCode Node = 2;
	public const XmlTypeCode Document = 3;
	public const XmlTypeCode Element = 4;
	public const XmlTypeCode Attribute = 5;
	public const XmlTypeCode Namespace = 6;
	public const XmlTypeCode ProcessingInstruction = 7;
	public const XmlTypeCode Comment = 8;
	public const XmlTypeCode Text = 9;
	public const XmlTypeCode AnyAtomicType = 10;
	public const XmlTypeCode UntypedAtomic = 11;
	public const XmlTypeCode String = 12;
	public const XmlTypeCode Boolean = 13;
	public const XmlTypeCode Decimal = 14;
	public const XmlTypeCode Float = 15;
	public const XmlTypeCode Double = 16;
	public const XmlTypeCode Duration = 17;
	public const XmlTypeCode DateTime = 18;
	public const XmlTypeCode Time = 19;
	public const XmlTypeCode Date = 20;
	public const XmlTypeCode GYearMonth = 21;
	public const XmlTypeCode GYear = 22;
	public const XmlTypeCode GMonthDay = 23;
	public const XmlTypeCode GDay = 24;
	public const XmlTypeCode GMonth = 25;
	public const XmlTypeCode HexBinary = 26;
	public const XmlTypeCode Base64Binary = 27;
	public const XmlTypeCode AnyUri = 28;
	public const XmlTypeCode QName = 29;
	public const XmlTypeCode Notation = 30;
	public const XmlTypeCode NormalizedString = 31;
	public const XmlTypeCode Token = 32;
	public const XmlTypeCode Language = 33;
	public const XmlTypeCode NmToken = 34;
	public const XmlTypeCode Name = 35;
	public const XmlTypeCode NCName = 36;
	public const XmlTypeCode Id = 37;
	public const XmlTypeCode Idref = 38;
	public const XmlTypeCode Entity = 39;
	public const XmlTypeCode Integer = 40;
	public const XmlTypeCode NonPositiveInteger = 41;
	public const XmlTypeCode NegativeInteger = 42;
	public const XmlTypeCode Long = 43;
	public const XmlTypeCode Int = 44;
	public const XmlTypeCode Short = 45;
	public const XmlTypeCode Byte = 46;
	public const XmlTypeCode NonNegativeInteger = 47;
	public const XmlTypeCode UnsignedLong = 48;
	public const XmlTypeCode UnsignedInt = 49;
	public const XmlTypeCode UnsignedShort = 50;
	public const XmlTypeCode UnsignedByte = 51;
	public const XmlTypeCode PositiveInteger = 52;
	public const XmlTypeCode YearMonthDuration = 53;
	public const XmlTypeCode DayTimeDuration = 54;
}

// Namespace: System.Xml.Schema
internal abstract class XmlValueConverter
{
	// Methods

	// RVA: -1
	public abstract bool ToBoolean(Int64 value) { }

	// RVA: -1
	public abstract bool ToBoolean(int value) { }

	// RVA: -1
	public abstract bool ToBoolean(Double value) { }

	// RVA: -1
	public abstract bool ToBoolean(DateTime value) { }

	// RVA: -1
	public abstract bool ToBoolean(string value) { }

	// RVA: -1
	public abstract bool ToBoolean(object value) { }

	// RVA: -1
	public abstract int ToInt32(bool value) { }

	// RVA: -1
	public abstract int ToInt32(Int64 value) { }

	// RVA: -1
	public abstract int ToInt32(Double value) { }

	// RVA: -1
	public abstract int ToInt32(DateTime value) { }

	// RVA: -1
	public abstract int ToInt32(string value) { }

	// RVA: -1
	public abstract int ToInt32(object value) { }

	// RVA: -1
	public abstract Int64 ToInt64(bool value) { }

	// RVA: -1
	public abstract Int64 ToInt64(int value) { }

	// RVA: -1
	public abstract Int64 ToInt64(Double value) { }

	// RVA: -1
	public abstract Int64 ToInt64(DateTime value) { }

	// RVA: -1
	public abstract Int64 ToInt64(string value) { }

	// RVA: -1
	public abstract Int64 ToInt64(object value) { }

	// RVA: -1
	public abstract Decimal ToDecimal(string value) { }

	// RVA: -1
	public abstract Decimal ToDecimal(object value) { }

	// RVA: -1
	public abstract Double ToDouble(bool value) { }

	// RVA: -1
	public abstract Double ToDouble(int value) { }

	// RVA: -1
	public abstract Double ToDouble(Int64 value) { }

	// RVA: -1
	public abstract Double ToDouble(DateTime value) { }

	// RVA: -1
	public abstract Double ToDouble(string value) { }

	// RVA: -1
	public abstract Double ToDouble(object value) { }

	// RVA: -1
	public abstract float ToSingle(Double value) { }

	// RVA: -1
	public abstract float ToSingle(string value) { }

	// RVA: -1
	public abstract float ToSingle(object value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(bool value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(int value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(Int64 value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(Double value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(string value) { }

	// RVA: -1
	public abstract DateTime ToDateTime(object value) { }

	// RVA: -1
	public abstract DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: -1
	public abstract DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: -1
	public abstract DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: -1
	public abstract string ToString(bool value) { }

	// RVA: -1
	public abstract string ToString(int value) { }

	// RVA: -1
	public abstract string ToString(Int64 value) { }

	// RVA: -1
	public abstract string ToString(Decimal value) { }

	// RVA: -1
	public abstract string ToString(float value) { }

	// RVA: -1
	public abstract string ToString(Double value) { }

	// RVA: -1
	public abstract string ToString(DateTime value) { }

	// RVA: -1
	public abstract string ToString(DateTimeOffset value) { }

	// RVA: -1
	public abstract string ToString(object value) { }

	// RVA: -1
	public abstract string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: -1
	public abstract object ChangeType(bool value, Type destinationType) { }

	// RVA: -1
	public abstract object ChangeType(int value, Type destinationType) { }

	// RVA: -1
	public abstract object ChangeType(Int64 value, Type destinationType) { }

	// RVA: -1
	public abstract object ChangeType(Decimal value, Type destinationType) { }

	// RVA: -1
	public abstract object ChangeType(Double value, Type destinationType) { }

	// RVA: -1
	public abstract object ChangeType(DateTime value, Type destinationType) { }

	// RVA: -1
	public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: -1
	public abstract object ChangeType(object value, Type destinationType) { }

	// RVA: -1
	public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10D9CF0
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class XmlBaseConverter
{
	// Fields
	private XmlSchemaType schemaType; // 0x10
	private XmlTypeCode typeCode; // 0x18
	private Type clrTypeDefault; // 0x20
	protected static readonly Type ICollectionType; // 0x0
	protected static readonly Type IEnumerableType; // 0x8
	protected static readonly Type IListType; // 0x10
	protected static readonly Type ObjectArrayType; // 0x18
	protected static readonly Type StringArrayType; // 0x20
	protected static readonly Type XmlAtomicValueArrayType; // 0x28
	protected static readonly Type DecimalType; // 0x30
	protected static readonly Type Int32Type; // 0x38
	protected static readonly Type Int64Type; // 0x40
	protected static readonly Type StringType; // 0x48
	protected static readonly Type XmlAtomicValueType; // 0x50
	protected static readonly Type ObjectType; // 0x58
	protected static readonly Type ByteType; // 0x60
	protected static readonly Type Int16Type; // 0x68
	protected static readonly Type SByteType; // 0x70
	protected static readonly Type UInt16Type; // 0x78
	protected static readonly Type UInt32Type; // 0x80
	protected static readonly Type UInt64Type; // 0x88
	protected static readonly Type XPathItemType; // 0x90
	protected static readonly Type DoubleType; // 0x98
	protected static readonly Type SingleType; // 0xA0
	protected static readonly Type DateTimeType; // 0xA8
	protected static readonly Type DateTimeOffsetType; // 0xB0
	protected static readonly Type BooleanType; // 0xB8
	protected static readonly Type ByteArrayType; // 0xC0
	protected static readonly Type XmlQualifiedNameType; // 0xC8
	protected static readonly Type UriType; // 0xD0
	protected static readonly Type TimeSpanType; // 0xD8
	protected static readonly Type XPathNavigatorType; // 0xE0

	// Methods

	// RVA: 0x10D9CF8
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10D9F0C
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x10D9FFC
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x10DA078
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x10DA0D8
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x10DA1D8
	public override bool ToBoolean(Double value) { }

	// RVA: 0x10DA2D8
	public override bool ToBoolean(int value) { }

	// RVA: 0x10DA3D8
	public override bool ToBoolean(Int64 value) { }

	// RVA: 0x10DA4D8
	public override bool ToBoolean(string value) { }

	// RVA: 0x10DA5A0
	public override bool ToBoolean(object value) { }

	// RVA: 0x10DA668
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x10DA768
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x10DA86C
	public override DateTime ToDateTime(Double value) { }

	// RVA: 0x10DA96C
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x10DAA6C
	public override DateTime ToDateTime(Int64 value) { }

	// RVA: 0x10DAB6C
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x10DAC34
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x10DACFC
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x10DAE00
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x10DAECC
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10DAF98
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x10DB064
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x10DB130
	public override Double ToDouble(bool value) { }

	// RVA: 0x10DB230
	public override Double ToDouble(DateTime value) { }

	// RVA: 0x10DB330
	public override Double ToDouble(int value) { }

	// RVA: 0x10DB430
	public override Double ToDouble(Int64 value) { }

	// RVA: 0x10DB530
	public override Double ToDouble(string value) { }

	// RVA: 0x10DB5F8
	public override Double ToDouble(object value) { }

	// RVA: 0x10DB6C0
	public override int ToInt32(bool value) { }

	// RVA: 0x10DB7C0
	public override int ToInt32(DateTime value) { }

	// RVA: 0x10DB8C0
	public override int ToInt32(Double value) { }

	// RVA: 0x10DB9C0
	public override int ToInt32(Int64 value) { }

	// RVA: 0x10DBAC0
	public override int ToInt32(string value) { }

	// RVA: 0x10DBB88
	public override int ToInt32(object value) { }

	// RVA: 0x10DBC50
	public override Int64 ToInt64(bool value) { }

	// RVA: 0x10DBD50
	public override Int64 ToInt64(DateTime value) { }

	// RVA: 0x10DBE50
	public override Int64 ToInt64(Double value) { }

	// RVA: 0x10DBF50
	public override Int64 ToInt64(int value) { }

	// RVA: 0x10DC050
	public override Int64 ToInt64(string value) { }

	// RVA: 0x10DC118
	public override Int64 ToInt64(object value) { }

	// RVA: 0x10DC1E0
	public override float ToSingle(Double value) { }

	// RVA: 0x10DC2E0
	public override float ToSingle(string value) { }

	// RVA: 0x10DC3A8
	public override float ToSingle(object value) { }

	// RVA: 0x10DC470
	public override string ToString(bool value) { }

	// RVA: 0x10DC55C
	public override string ToString(DateTime value) { }

	// RVA: 0x10DC648
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x10DC738
	public override string ToString(Decimal value) { }

	// RVA: 0x10DC854
	public override string ToString(Double value) { }

	// RVA: 0x10DC940
	public override string ToString(int value) { }

	// RVA: 0x10DCA2C
	public override string ToString(Int64 value) { }

	// RVA: 0x10DCB18
	public override string ToString(float value) { }

	// RVA: 0x10DCC04
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DCCC4
	public override string ToString(object value) { }

	// RVA: 0x10DCCD8
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10DCD6C
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10DCE00
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10DCEC4
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10DCF58
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10DCFEC
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10DD080
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DD090
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x10DD0A4
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x10DD0AC
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x10DD0B4
	protected string get_XmlTypeName() { }

	// RVA: 0x10DD320
	protected Type get_DefaultClrType() { }

	// RVA: 0x10DD328
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x10DD404
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x10DD1EC
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x10DD6A8
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DD704
	protected static Byte[] StringToBase64Binary(string value) { }

	// RVA: 0x10DD7B4
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x10DD83C
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x10DD8C4
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x10DD91C
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x10DD974
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x10DD9FC
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x10DDA84
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x10DDB0C
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x10DDB94
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x10DDC1C
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x10DDCA4
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x10DDD2C
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x10DDDB4
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x10DDE3C
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x10DDEC4
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x10DDF4C
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x10DDFD4
	protected static Byte[] StringToHexBinary(string value) { }

	// RVA: 0x10DE118
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DE3F8
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x10DE480
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x10DE508
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x10DE560
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x10DE578
	protected static string Base64BinaryToString(Byte[] value) { }

	// RVA: 0x10DE600
	protected static string DateToString(DateTime value) { }

	// RVA: 0x10DE690
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x10DE720
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x10DE778
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x10DE7D0
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x10DE860
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x10DE8F0
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x10DE980
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x10DEA10
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x10DEAA0
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10DEB38
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10DEBD0
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10DEC68
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10DED00
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10DED98
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10DEE30
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10DEEC8
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DF100
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x10DF190
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10DF228
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x10DF280
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x10DF2E8
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x10DF4D0
	protected static Int64 DecimalToInt64(Decimal value) { }

	// RVA: 0x10DF6B8
	protected static UInt64 DecimalToUInt64(Decimal value) { }

	// RVA: 0x10DF894
	protected static Byte Int32ToByte(int value) { }

	// RVA: 0x10DF980
	protected static Int16 Int32ToInt16(int value) { }

	// RVA: 0x10DFA6C
	protected static SByte Int32ToSByte(int value) { }

	// RVA: 0x10DFB58
	protected static UInt16 Int32ToUInt16(int value) { }

	// RVA: 0x10DFC44
	protected static int Int64ToInt32(Int64 value) { }

	// RVA: 0x10DFD2C
	protected static UInt32 Int64ToUInt32(Int64 value) { }

	// RVA: 0x10DFE14
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x10DFE9C
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x10DFF24
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric10Converter
{
	// Methods

	// RVA: 0x10E059C
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10E0608
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10E06AC
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x10E07BC
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x10E11B0
	public override int ToInt32(Int64 value) { }

	// RVA: 0x10E1238
	public override int ToInt32(string value) { }

	// RVA: 0x10E136C
	public override int ToInt32(object value) { }

	// RVA: 0x10E17FC
	public override Int64 ToInt64(int value) { }

	// RVA: 0x10E1804
	public override Int64 ToInt64(string value) { }

	// RVA: 0x10E1938
	public override Int64 ToInt64(object value) { }

	// RVA: 0x10E1DC8
	public override string ToString(Decimal value) { }

	// RVA: 0x10E1EA4
	public override string ToString(int value) { }

	// RVA: 0x10E1F2C
	public override string ToString(Int64 value) { }

	// RVA: 0x10E1FB4
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E2480
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10E2F50
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10E34CC
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10E3A4C
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E3FA8
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E0C80
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E2A08
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric2Converter
{
	// Methods

	// RVA: 0x10E52DC
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10E5348
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10E53EC
	public override Double ToDouble(string value) { }

	// RVA: 0x10E54EC
	public override Double ToDouble(object value) { }

	// RVA: 0x10E58D4
	public override float ToSingle(Double value) { }

	// RVA: 0x10E58DC
	public override float ToSingle(string value) { }

	// RVA: 0x10E59DC
	public override float ToSingle(object value) { }

	// RVA: 0x10E5DB0
	public override string ToString(Double value) { }

	// RVA: 0x10E5EAC
	public override string ToString(float value) { }

	// RVA: 0x10E5F60
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E634C
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10E67CC
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E6C5C
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlDateTimeConverter
{
	// Methods

	// RVA: 0x10E7574
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10E75E0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10E7684
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x10E76F0
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x10E79DC
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x10E7DD0
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x10E7DFC
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x10E80E8
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10E8518
	public override string ToString(DateTime value) { }

	// RVA: 0x10E87B8
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x10E89BC
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E8DA8
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10E9230
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E96B8
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlBooleanConverter
{
	// Methods

	// RVA: 0x10E9FF4
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10EA060
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10EA104
	public override bool ToBoolean(string value) { }

	// RVA: 0x10EA1C0
	public override bool ToBoolean(object value) { }

	// RVA: 0x10EA510
	public override string ToString(bool value) { }

	// RVA: 0x10EA598
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EA8D4
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10EACD8
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EB0DC
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlMiscConverter
{
	// Methods

	// RVA: 0x10EB820
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10EB88C
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10EB930
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EC0B0
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EC898
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EBF40
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EC6EC
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlStringConverter
{
	// Methods

	// RVA: 0x10ED94C
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10ED9B8
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10EDA5C
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EDCB8
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EDFEC
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlUntypedConverter
{
	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0x10EE550
	protected void .ctor() { }

	// RVA: 0x10EE6C0
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0x10EE84C
	public override bool ToBoolean(string value) { }

	// RVA: 0x10EE908
	public override bool ToBoolean(object value) { }

	// RVA: 0x10EEC78
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x10EED34
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x10EEF0C
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x10EEFC8
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10EF1AC
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x10EF268
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x10EF474
	public override Double ToDouble(string value) { }

	// RVA: 0x10EF530
	public override Double ToDouble(object value) { }

	// RVA: 0x10EF730
	public override int ToInt32(string value) { }

	// RVA: 0x10EF7EC
	public override int ToInt32(object value) { }

	// RVA: 0x10EF9EC
	public override Int64 ToInt64(string value) { }

	// RVA: 0x10EFAA8
	public override Int64 ToInt64(object value) { }

	// RVA: 0x10EFCA8
	public override float ToSingle(string value) { }

	// RVA: 0x10EFD64
	public override float ToSingle(object value) { }

	// RVA: 0x10EFF64
	public override string ToString(bool value) { }

	// RVA: 0x10EFFEC
	public override string ToString(DateTime value) { }

	// RVA: 0x10F0074
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x10F00E0
	public override string ToString(Decimal value) { }

	// RVA: 0x10F014C
	public override string ToString(Double value) { }

	// RVA: 0x10F01D4
	public override string ToString(int value) { }

	// RVA: 0x10F025C
	public override string ToString(Int64 value) { }

	// RVA: 0x10F02E4
	public override string ToString(float value) { }

	// RVA: 0x10F036C
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F1254
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10F1690
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10F18DC
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10F1B94
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10F1E00
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10F2060
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10F22C0
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F3240
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EEB08
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F14B4
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F4FF0
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F532C
	private bool SupportsType(Type clrType) { }

	// RVA: 0x10F6AFC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyConverter
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x10F6BC0
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x10F6C2C
	public override bool ToBoolean(object value) { }

	// RVA: 0x10F6F80
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x10F7164
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10F734C
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x10F7534
	public override Double ToDouble(object value) { }

	// RVA: 0x10F7718
	public override int ToInt32(object value) { }

	// RVA: 0x10F78FC
	public override Int64 ToInt64(object value) { }

	// RVA: 0x10F7AE0
	public override float ToSingle(object value) { }

	// RVA: 0x10F7CC8
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10F80DC
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10F8344
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10F8600
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10F8870
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10F8AD8
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10F8D40
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F8F98
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F6E10
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F7F30
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10FAA3C
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x10FAAD0
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyListConverter
{
	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x10FABE8
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x10FACE0
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10FAF90
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlListConverter
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x10FAC64
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x10EE7C0
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x10EE654
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10FB180
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x10FB400
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F5B14
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10FB50C
	private bool IsListType(Type type) { }

	// RVA: 0x30B1E68
	private T[] ToArray(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10FBE40
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10FBD90
	private System.Collections.Generic.List<System.String> StringAsList(string value) { }

	// RVA: 0x10FB9FC
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10FB750
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

}

// Namespace: System.Xml.Schema
internal class XmlUnionConverter
{
	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0x10FC454
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10FC6D8
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10FC73C
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: 
private enum State
{
	// Fields
	public int value__; // 0x10
	public const State Root = 0;
	public const State Schema = 1;
	public const State Annotation = 2;
	public const State Include = 3;
	public const State Import = 4;
	public const State Element = 5;
	public const State Attribute = 6;
	public const State AttributeGroup = 7;
	public const State AttributeGroupRef = 8;
	public const State AnyAttribute = 9;
	public const State Group = 10;
	public const State GroupRef = 11;
	public const State All = 12;
	public const State Choice = 13;
	public const State Sequence = 14;
	public const State Any = 15;
	public const State Notation = 16;
	public const State SimpleType = 17;
	public const State ComplexType = 18;
	public const State ComplexContent = 19;
	public const State ComplexContentRestriction = 20;
	public const State ComplexContentExtension = 21;
	public const State SimpleContent = 22;
	public const State SimpleContentExtension = 23;
	public const State SimpleContentRestriction = 24;
	public const State SimpleTypeUnion = 25;
	public const State SimpleTypeList = 26;
	public const State SimpleTypeRestriction = 27;
	public const State Unique = 28;
	public const State Key = 29;
	public const State KeyRef = 30;
	public const State Selector = 31;
	public const State Field = 32;
	public const State MinExclusive = 33;
	public const State MinInclusive = 34;
	public const State MaxExclusive = 35;
	public const State MaxInclusive = 36;
	public const State TotalDigits = 37;
	public const State FractionDigits = 38;
	public const State Length = 39;
	public const State MinLength = 40;
	public const State MaxLength = 41;
	public const State Enumeration = 42;
	public const State Pattern = 43;
	public const State WhiteSpace = 44;
	public const State AppInfo = 45;
	public const State Documentation = 46;
	public const State Redefine = 47;
}

// Namespace: 
private sealed class XsdBuildFunction
{
	// Methods

	// RVA: 0x11095FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11096B8
	public virtual void Invoke(XsdBuilder builder, string value) { }

}

// Namespace: 
private sealed class XsdInitFunction
{
	// Methods

	// RVA: 0x11096CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1109788
	public virtual void Invoke(XsdBuilder builder, string value) { }

}

// Namespace: 
private sealed class XsdEndChildFunction
{
	// Methods

	// RVA: 0x110979C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1109850
	public virtual void Invoke(XsdBuilder builder) { }

}

// Namespace: 
private sealed class XsdAttributeEntry
{
	// Fields
	public Token Attribute; // 0x10
	public XsdBuildFunction BuildFunc; // 0x18

	// Methods

	// RVA: 0x1109864
	public void .ctor(Token a, XsdBuildFunction build) { }

}

// Namespace: 
private sealed class XsdEntry
{
	// Fields
	public Token Name; // 0x10
	public State CurrentState; // 0x14
	public State[] NextStates; // 0x18
	public XsdAttributeEntry[] Attributes; // 0x20
	public XsdInitFunction InitFunc; // 0x28
	public XsdEndChildFunction EndChildFunc; // 0x30
	public bool ParseContent; // 0x38

	// Methods

	// RVA: 0x11098A8
	public void .ctor(Token n, State state, State[] nextStates, XsdAttributeEntry[] attributes, XsdInitFunction init, XsdEndChildFunction end, bool parseContent) { }

}

// Namespace: 
private class BuilderNamespaceManager
{
	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x1109948
	public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x1109998
	public override string LookupNamespace(string prefix) { }

}

// Namespace: System.Xml.Schema
internal sealed class XsdBuilder
{
	// Fields
	private static readonly State[] SchemaElement; // 0x0
	private static readonly State[] SchemaSubelements; // 0x8
	private static readonly State[] AttributeSubelements; // 0x10
	private static readonly State[] ElementSubelements; // 0x18
	private static readonly State[] ComplexTypeSubelements; // 0x20
	private static readonly State[] SimpleContentSubelements; // 0x28
	private static readonly State[] SimpleContentExtensionSubelements; // 0x30
	private static readonly State[] SimpleContentRestrictionSubelements; // 0x38
	private static readonly State[] ComplexContentSubelements; // 0x40
	private static readonly State[] ComplexContentExtensionSubelements; // 0x48
	private static readonly State[] ComplexContentRestrictionSubelements; // 0x50
	private static readonly State[] SimpleTypeSubelements; // 0x58
	private static readonly State[] SimpleTypeRestrictionSubelements; // 0x60
	private static readonly State[] SimpleTypeListSubelements; // 0x68
	private static readonly State[] SimpleTypeUnionSubelements; // 0x70
	private static readonly State[] RedefineSubelements; // 0x78
	private static readonly State[] AttributeGroupSubelements; // 0x80
	private static readonly State[] GroupSubelements; // 0x88
	private static readonly State[] AllSubelements; // 0x90
	private static readonly State[] ChoiceSequenceSubelements; // 0x98
	private static readonly State[] IdentityConstraintSubelements; // 0xA0
	private static readonly State[] AnnotationSubelements; // 0xA8
	private static readonly State[] AnnotatedSubelements; // 0xB0
	private static readonly XsdAttributeEntry[] SchemaAttributes; // 0xB8
	private static readonly XsdAttributeEntry[] AttributeAttributes; // 0xC0
	private static readonly XsdAttributeEntry[] ElementAttributes; // 0xC8
	private static readonly XsdAttributeEntry[] ComplexTypeAttributes; // 0xD0
	private static readonly XsdAttributeEntry[] SimpleContentAttributes; // 0xD8
	private static readonly XsdAttributeEntry[] SimpleContentExtensionAttributes; // 0xE0
	private static readonly XsdAttributeEntry[] SimpleContentRestrictionAttributes; // 0xE8
	private static readonly XsdAttributeEntry[] ComplexContentAttributes; // 0xF0
	private static readonly XsdAttributeEntry[] ComplexContentExtensionAttributes; // 0xF8
	private static readonly XsdAttributeEntry[] ComplexContentRestrictionAttributes; // 0x100
	private static readonly XsdAttributeEntry[] SimpleTypeAttributes; // 0x108
	private static readonly XsdAttributeEntry[] SimpleTypeRestrictionAttributes; // 0x110
	private static readonly XsdAttributeEntry[] SimpleTypeUnionAttributes; // 0x118
	private static readonly XsdAttributeEntry[] SimpleTypeListAttributes; // 0x120
	private static readonly XsdAttributeEntry[] AttributeGroupAttributes; // 0x128
	private static readonly XsdAttributeEntry[] AttributeGroupRefAttributes; // 0x130
	private static readonly XsdAttributeEntry[] GroupAttributes; // 0x138
	private static readonly XsdAttributeEntry[] GroupRefAttributes; // 0x140
	private static readonly XsdAttributeEntry[] ParticleAttributes; // 0x148
	private static readonly XsdAttributeEntry[] AnyAttributes; // 0x150
	private static readonly XsdAttributeEntry[] IdentityConstraintAttributes; // 0x158
	private static readonly XsdAttributeEntry[] SelectorAttributes; // 0x160
	private static readonly XsdAttributeEntry[] FieldAttributes; // 0x168
	private static readonly XsdAttributeEntry[] NotationAttributes; // 0x170
	private static readonly XsdAttributeEntry[] IncludeAttributes; // 0x178
	private static readonly XsdAttributeEntry[] ImportAttributes; // 0x180
	private static readonly XsdAttributeEntry[] FacetAttributes; // 0x188
	private static readonly XsdAttributeEntry[] AnyAttributeAttributes; // 0x190
	private static readonly XsdAttributeEntry[] DocumentationAttributes; // 0x198
	private static readonly XsdAttributeEntry[] AppinfoAttributes; // 0x1A0
	private static readonly XsdAttributeEntry[] RedefineAttributes; // 0x1A8
	private static readonly XsdAttributeEntry[] AnnotationAttributes; // 0x1B0
	private static readonly XsdEntry[] SchemaEntries; // 0x1B8
	private static readonly int[] DerivationMethodValues; // 0x1C0
	private static readonly string[] DerivationMethodStrings; // 0x1C8
	private static readonly string[] FormStringValues; // 0x1D0
	private static readonly string[] UseStringValues; // 0x1D8
	private static readonly string[] ProcessContentsStringValues; // 0x1E0
	private XmlReader reader; // 0x10
	private PositionInfo positionInfo; // 0x18
	private XsdEntry currentEntry; // 0x20
	private XsdEntry nextEntry; // 0x28
	private bool hasChild; // 0x30
	private HWStack stateHistory; // 0x38
	private Stack containerStack; // 0x40
	private XmlNameTable nameTable; // 0x48
	private SchemaNames schemaNames; // 0x50
	private XmlNamespaceManager namespaceManager; // 0x58
	private bool canIncludeImport; // 0x60
	private XmlSchema schema; // 0x68
	private XmlSchemaObject xso; // 0x70
	private XmlSchemaElement element; // 0x78
	private XmlSchemaAny anyElement; // 0x80
	private XmlSchemaAttribute attribute; // 0x88
	private XmlSchemaAnyAttribute anyAttribute; // 0x90
	private XmlSchemaComplexType complexType; // 0x98
	private XmlSchemaSimpleType simpleType; // 0xA0
	private XmlSchemaComplexContent complexContent; // 0xA8
	private XmlSchemaComplexContentExtension complexContentExtension; // 0xB0
	private XmlSchemaComplexContentRestriction complexContentRestriction; // 0xB8
	private XmlSchemaSimpleContent simpleContent; // 0xC0
	private XmlSchemaSimpleContentExtension simpleContentExtension; // 0xC8
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; // 0xD0
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; // 0xD8
	private XmlSchemaSimpleTypeList simpleTypeList; // 0xE0
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; // 0xE8
	private XmlSchemaGroup group; // 0xF0
	private XmlSchemaGroupRef groupRef; // 0xF8
	private XmlSchemaAll all; // 0x100
	private XmlSchemaChoice choice; // 0x108
	private XmlSchemaSequence sequence; // 0x110
	private XmlSchemaParticle particle; // 0x118
	private XmlSchemaAttributeGroup attributeGroup; // 0x120
	private XmlSchemaAttributeGroupRef attributeGroupRef; // 0x128
	private XmlSchemaNotation notation; // 0x130
	private XmlSchemaIdentityConstraint identityConstraint; // 0x138
	private XmlSchemaXPath xpath; // 0x140
	private XmlSchemaInclude include; // 0x148
	private XmlSchemaImport import; // 0x150
	private XmlSchemaAnnotation annotation; // 0x158
	private XmlSchemaAppInfo appInfo; // 0x160
	private XmlSchemaDocumentation documentation; // 0x168
	private XmlSchemaFacet facet; // 0x170
	private XmlNode[] markup; // 0x178
	private XmlSchemaRedefine redefine; // 0x180
	private ValidationEventHandler validationEventHandler; // 0x188
	private ArrayList unhandledAttributes; // 0x190
	private Hashtable namespaces; // 0x198

	// Methods

	// RVA: 0x10FCBFC
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x10FCE5C
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x10FD63C
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x10FDB98
	internal override bool IsContentParsed() { }

	// RVA: 0x10FDBB8
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x10FDBC8
	internal override void ProcessCData(string value) { }

	// RVA: 0x10FDC24
	internal override void StartChildren() { }

	// RVA: 0x10FDDD8
	internal override void EndChildren() { }

	// RVA: 0x10FD118
	private void Push() { }

	// RVA: 0x10FDE20
	private void Pop() { }

	// RVA: 0x10FF0A0
	private Token get_CurrentElement() { }

	// RVA: 0x10FF0C0
	private Token get_ParentElement() { }

	// RVA: 0x10FF13C
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0x10FDF14
	private XmlSchemaObject GetContainer(State state) { }

	// RVA: 0x10FE0CC
	private void SetContainer(State state, object container) { }

	// RVA: 0x10FF1D0
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0x10FF1F8
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10FF38C
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10FF438
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0x10FF45C
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0x10FF480
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10FF778
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10FF7EC
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0x10FF814
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0x10FF8E4
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x10FF908
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0x10FF9D8
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x10FF9FC
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x10FFA20
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0x10FFAF0
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x10FFB14
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0x10FFB34
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x10FFF00
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0x10FFF24
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x10FFF48
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0x10FFFF4
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0x11000A0
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x11002A4
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0x11002C8
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0x1100344
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0x11004B8
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x110065C
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0x11006D0
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0x11006F4
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0x11007A0
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0x110081C
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1100890
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x11008B4
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x11009A0
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1100A8C
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1100AB0
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0x1100B2C
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1100BA8
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0x1100C24
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0x1100FC4
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1100FE8
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x110105C
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0x110112C
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0x110132C
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0x11013FC
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0x1101478
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1101548
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x11015C4
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0x11017B0
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x110182C
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0x11018A0
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1101914
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x1101998
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x11019BC
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0x1101AD0
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x1101B4C
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x1101C44
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1101CC0
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1101D64
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1101DE0
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0x1101EF4
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x1101FEC
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1102068
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1102160
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x11021DC
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1102314
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1102338
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x11023C8
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1102444
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x110275C
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1102780
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x110282C
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1102968
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x110298C
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x1102E0C
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1102E2C
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1102E4C
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1102EC8
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0x1102F68
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0x1103008
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0x11030A8
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0x110314C
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1103170
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x110321C
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0x11032C4
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0x11032E8
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0x110330C
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0x1103330
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0x110369C
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1103720
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0x1103744
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0x110389C
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0x11038C0
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0x11039E4
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0x1103AC0
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x1103AE4
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0x1103BC0
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x1103BE4
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0x1103DCC
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0x1103EA0
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0x1103F20
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0x1103F4C
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0x1104020
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0x110409C
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0x11041E4
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0x10FFC64
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0x1102A30
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10FCFA4
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x10FD528
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x11009C0
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x11008D4
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x1100534
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0x10FF2A4
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0x110011C
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0x10FF4F4
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x1103F1C
	private static string ParseUriReference(string s) { }

	// RVA: 0x1104210
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0x10FD554
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x10FDAAC
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1104384
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1101324
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x10FD3E8
	private void RecordPosition() { }

	// RVA: 0x1104464
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal enum XsdDateTimeFlags
{
	// Fields
	public int value__; // 0x10
	public const XsdDateTimeFlags DateTime = 1;
	public const XsdDateTimeFlags Time = 2;
	public const XsdDateTimeFlags Date = 4;
	public const XsdDateTimeFlags GYearMonth = 8;
	public const XsdDateTimeFlags GYear = 16;
	public const XsdDateTimeFlags GMonthDay = 32;
	public const XsdDateTimeFlags GDay = 64;
	public const XsdDateTimeFlags GMonth = 128;
	public const XsdDateTimeFlags XdrDateTimeNoTz = 256;
	public const XsdDateTimeFlags XdrDateTime = 512;
	public const XsdDateTimeFlags XdrTimeNoTz = 1024;
	public const XsdDateTimeFlags AllXsd = 255;
}

// Namespace: 
private enum DateTimeTypeCode
{
	// Fields
	public int value__; // 0x10
	public const DateTimeTypeCode DateTime = 0;
	public const DateTimeTypeCode Time = 1;
	public const DateTimeTypeCode Date = 2;
	public const DateTimeTypeCode GYearMonth = 3;
	public const DateTimeTypeCode GYear = 4;
	public const DateTimeTypeCode GMonthDay = 5;
	public const DateTimeTypeCode GDay = 6;
	public const DateTimeTypeCode GMonth = 7;
	public const DateTimeTypeCode XdrDateTime = 8;
}

// Namespace: 
private enum XsdDateTimeKind
{
	// Fields
	public int value__; // 0x10
	public const XsdDateTimeKind Unspecified = 0;
	public const XsdDateTimeKind Zulu = 1;
	public const XsdDateTimeKind LocalWestOfZulu = 2;
	public const XsdDateTimeKind LocalEastOfZulu = 3;
}

// Namespace: 
private struct Parser
{
	// Fields
	public DateTimeTypeCode typeCode; // 0x10
	public int year; // 0x14
	public int month; // 0x18
	public int day; // 0x1C
	public int hour; // 0x20
	public int minute; // 0x24
	public int second; // 0x28
	public int fraction; // 0x2C
	public XsdDateTimeKind kind; // 0x30
	public int zoneHour; // 0x34
	public int zoneMinute; // 0x38
	private string text; // 0x40
	private int length; // 0x48
	private static int[] Power10; // 0x0

	// Methods

	// RVA: 0x1109C68
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x110DE44
	private bool ParseDate(int start) { }

	// RVA: 0x110E218
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x110E610
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x110E894
	private bool ParseTime(int start) { }

	// RVA: 0x110E300
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x110E6C8
	private bool Parse4Dig(int start, int num) { }

	// RVA: 0x110E7E4
	private bool Parse2Dig(int start, int num) { }

	// RVA: 0x110E1C4
	private bool ParseChar(int start, Char ch) { }

	// RVA: 0x110DE38
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x110EDA8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal struct XsdDateTime
{
	// Fields
	private DateTime dt; // 0x10
	private UInt32 extra; // 0x18
	private static readonly int Lzyyyy; // 0x0
	private static readonly int Lzyyyy_; // 0x4
	private static readonly int Lzyyyy_MM; // 0x8
	private static readonly int Lzyyyy_MM_; // 0xC
	private static readonly int Lzyyyy_MM_dd; // 0x10
	private static readonly int Lzyyyy_MM_ddT; // 0x14
	private static readonly int LzHH; // 0x18
	private static readonly int LzHH_; // 0x1C
	private static readonly int LzHH_mm; // 0x20
	private static readonly int LzHH_mm_; // 0x24
	private static readonly int LzHH_mm_ss; // 0x28
	private static readonly int Lz_; // 0x2C
	private static readonly int Lz_zz; // 0x30
	private static readonly int Lz_zz_; // 0x34
	private static readonly int Lz_zz_zz; // 0x38
	private static readonly int Lz__; // 0x3C
	private static readonly int Lz__mm; // 0x40
	private static readonly int Lz__mm_; // 0x44
	private static readonly int Lz__mm__; // 0x48
	private static readonly int Lz__mm_dd; // 0x4C
	private static readonly int Lz___; // 0x50
	private static readonly int Lz___dd; // 0x54
	private static readonly XmlTypeCode[] typeCodes; // 0x58

	// Methods

	// RVA: 0x11099FC
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x110B01C
	private void .ctor(Parser parser) { }

	// RVA: 0x110AF54
	private void InitiateXsdDateTime(Parser parser) { }

	// RVA: 0x110B17C
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, XsdDateTime result) { }

	// RVA: 0x110B278
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x110B464
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x110B4E0
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x110B674
	private DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x110B67C
	private XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x110B684
	public int get_Year() { }

	// RVA: 0x110B70C
	public int get_Month() { }

	// RVA: 0x110B794
	public int get_Day() { }

	// RVA: 0x110B81C
	public int get_Hour() { }

	// RVA: 0x110B8A4
	public int get_Minute() { }

	// RVA: 0x110B92C
	public int get_Second() { }

	// RVA: 0x110B9B4
	public int get_Fraction() { }

	// RVA: 0x110BAD4
	public int get_ZoneHour() { }

	// RVA: 0x110BADC
	public int get_ZoneMinute() { }

	// RVA: 0x110BAE4
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x110C1E8
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x110C6C8
	public override string ToString() { }

	// RVA: 0x110CFD0
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x110D354
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x110D84C
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x110D774
	private void IntToCharArray(Char[] text, int start, int value, int digits) { }

	// RVA: 0x110D7E0
	private void ShortToCharArray(Char[] text, int start, int value) { }

	// RVA: 0x110DA78
	private static void .cctor() { }

}

// Namespace: 
private enum Parts
{
	// Fields
	public int value__; // 0x10
	public const Parts HasNone = 0;
	public const Parts HasYears = 1;
	public const Parts HasMonths = 2;
	public const Parts HasDays = 4;
	public const Parts HasHours = 8;
	public const Parts HasMinutes = 16;
	public const Parts HasSeconds = 32;
}

// Namespace: 
public enum DurationType
{
	// Fields
	public int value__; // 0x10
	public const DurationType Duration = 0;
	public const DurationType YearMonthDuration = 1;
	public const DurationType DayTimeDuration = 2;
}

// Namespace: System.Xml.Schema
internal struct XsdDuration
{
	// Fields
	private int years; // 0x10
	private int months; // 0x14
	private int days; // 0x18
	private int hours; // 0x1C
	private int minutes; // 0x20
	private int seconds; // 0x24
	private UInt32 nanoseconds; // 0x28

	// Methods

	// RVA: 0x110EE4C
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x110EFB4
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x110F0E4
	public void .ctor(TimeSpan timeSpan, DurationType durationType) { }

	// RVA: 0x110F2EC
	public void .ctor(string s) { }

	// RVA: 0x110F368
	public void .ctor(string s, DurationType durationType) { }

	// RVA: 0x110FB24
	public bool get_IsNegative() { }

	// RVA: 0x110FB30
	public int get_Years() { }

	// RVA: 0x110FB38
	public int get_Months() { }

	// RVA: 0x110FB40
	public int get_Days() { }

	// RVA: 0x110FB48
	public int get_Hours() { }

	// RVA: 0x110FB50
	public int get_Minutes() { }

	// RVA: 0x110FB58
	public int get_Seconds() { }

	// RVA: 0x110FB18
	public int get_Nanoseconds() { }

	// RVA: 0x110FB60
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x110FBB8
	public TimeSpan ToTimeSpan(DurationType durationType) { }

	// RVA: 0x1110124
	internal Exception TryToTimeSpan(TimeSpan result) { }

	// RVA: 0x110FC0C
	internal Exception TryToTimeSpan(DurationType durationType, TimeSpan result) { }

	// RVA: 0x1110130
	public override string ToString() { }

	// RVA: 0x1110138
	internal string ToString(DurationType durationType) { }

	// RVA: 0x1110570
	internal static Exception TryParse(string s, XsdDuration result) { }

	// RVA: 0x110F3E8
	internal static Exception TryParse(string s, DurationType durationType, XsdDuration result) { }

	// RVA: 0x111057C
	private static string TryParseDigits(string s, int offset, bool eatDigits, int result, int numDigits) { }

}

// Namespace: System.Xml.Schema
internal sealed class XsdValidator
{
	// Fields
	private int startIDConstraint; // 0x7C
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlNamespaceManager nsManager; // 0x90
	private bool bManageNamespaces; // 0x98
	private Hashtable IDs; // 0xA0
	private IdRefNode idRefListHead; // 0xA8
	private Parser inlineSchemaParser; // 0xB0
	private XmlSchemaContentProcessing processContents; // 0xB8
	private static readonly XmlSchemaDatatype dtCDATA; // 0x0
	private static readonly XmlSchemaDatatype dtQName; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private string NsXmlNs; // 0xC0
	private string NsXs; // 0xC8
	private string NsXsi; // 0xD0
	private string XsiType; // 0xD8
	private string XsiNil; // 0xE0
	private string XsiSchemaLocation; // 0xE8
	private string XsiNoNamespaceSchemaLocation; // 0xF0
	private string XsdSchema; // 0xF8

	// Methods

	// RVA: 0x1110724
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1110B48
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1110754
	private void Init() { }

	// RVA: 0x1110CD0
	public override void Validate() { }

	// RVA: 0x11113D0
	public override void CompleteValidation() { }

	// RVA: 0x1110DA4
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1110DB4
	private void ProcessInlineSchema() { }

	// RVA: 0x1111064
	private void ValidateElement() { }

	// RVA: 0x1111500
	private object ValidateChildElement() { }

	// RVA: 0x1111738
	private void ProcessElement(object particle) { }

	// RVA: 0x1111B94
	private void ProcessXsiAttributes(XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x11111F0
	private void ValidateEndElement() { }

	// RVA: 0x1111A94
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x111239C
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x1112814
	private void ValidateStartElement() { }

	// RVA: 0x1112F54
	private void ValidateEndStartElement() { }

	// RVA: 0x1114B4C
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x11133DC
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x1112790
	private bool get_HasSchema() { }

	// RVA: 0x11150C8
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1115104
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x11135A0
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1115380
	internal void AddID(string name, object node) { }

	// RVA: 0x1115420
	public override object FindId(string name) { }

	// RVA: 0x11116EC
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1110B78
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x11146F8
	private void Pop() { }

	// RVA: 0x11113D4
	private void CheckForwardRefs() { }

	// RVA: 0x11127B8
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x1113A8C
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x111543C
	private void AddIdentityConstraints() { }

	// RVA: 0x1115848
	private void ElementIdentityConstraints() { }

	// RVA: 0x111487C
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x11147F0
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x1113A9C
	private void EndElementIdentityConstraints() { }

	// RVA: 0x1115B98
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AbsoluteQuery
{
	// Methods

	// RVA: 0x1115C58
	public void .ctor() { }

	// RVA: 0x1115CA8
	private void .ctor(AbsoluteQuery other) { }

	// RVA: 0x1115D20
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1115DA0
	public override XPathNodeIterator Clone() { }

}

// Namespace: 
public enum AstType
{
	// Fields
	public int value__; // 0x10
	public const AstType Axis = 0;
	public const AstType Operator = 1;
	public const AstType Filter = 2;
	public const AstType ConstantOperand = 3;
	public const AstType Function = 4;
	public const AstType Group = 5;
	public const AstType Root = 6;
	public const AstType Variable = 7;
	public const AstType Error = 8;
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class AstNode
{
	// Methods

	// RVA: -1
	public abstract AstType get_Type() { }

	// RVA: -1
	public abstract XPathResultType get_ReturnType() { }

	// RVA: 0x1115E20
	protected void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AttributeQuery
{
	// Fields
	private bool _onAttribute; // 0x54

	// Methods

	// RVA: 0x1115E28
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1115F14
	private void .ctor(AttributeQuery other) { }

	// RVA: 0x1115FE8
	public override void Reset() { }

	// RVA: 0x1116074
	public override XPathNavigator Advance() { }

	// RVA: 0x111616C
	public override XPathNodeIterator Clone() { }

}

// Namespace: 
public enum AxisType
{
	// Fields
	public int value__; // 0x10
	public const AxisType Ancestor = 0;
	public const AxisType AncestorOrSelf = 1;
	public const AxisType Attribute = 2;
	public const AxisType Child = 3;
	public const AxisType Descendant = 4;
	public const AxisType DescendantOrSelf = 5;
	public const AxisType Following = 6;
	public const AxisType FollowingSibling = 7;
	public const AxisType Namespace = 8;
	public const AxisType Parent = 9;
	public const AxisType Preceding = 10;
	public const AxisType PrecedingSibling = 11;
	public const AxisType Self = 12;
	public const AxisType None = 13;
}

// Namespace: MS.Internal.Xml.XPath
internal class Axis
{
	// Fields
	private AxisType _axisType; // 0x10
	private AstNode _input; // 0x18
	private string _prefix; // 0x20
	private string _name; // 0x28
	private XPathNodeType _nodeType; // 0x30
	protected bool abbrAxis; // 0x34
	private string _urn; // 0x38

	// Methods

	// RVA: 0x11161E0
	public void .ctor(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x11162AC
	public void .ctor(AxisType axisType, AstNode input) { }

	// RVA: 0x111639C
	public override AstType get_Type() { }

	// RVA: 0x11163A4
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x11163AC
	public AstNode get_Input() { }

	// RVA: 0x11163B4
	public void set_Input(AstNode value) { }

	// RVA: 0x11163BC
	public string get_Prefix() { }

	// RVA: 0x11163C4
	public string get_Name() { }

	// RVA: 0x11163CC
	public XPathNodeType get_NodeType() { }

	// RVA: 0x11163D4
	public AxisType get_TypeOfAxis() { }

	// RVA: 0x11163DC
	public bool get_AbbrAxis() { }

	// RVA: 0x11163E4
	public string get_Urn() { }

	// RVA: 0x11163EC
	public void set_Urn(string value) { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class BaseAxisQuery
{
	// Fields
	internal Query qyInput; // 0x18
	private bool _nameTest; // 0x20
	private string _name; // 0x28
	private string _prefix; // 0x30
	private string _nsUri; // 0x38
	private XPathNodeType _typeTest; // 0x40
	protected XPathNavigator currentNode; // 0x48
	protected int position; // 0x50

	// Methods

	// RVA: 0x11163F4
	protected void .ctor(Query qyInput) { }

	// RVA: 0x1115E2C
	protected void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1115F48
	protected void .ctor(BaseAxisQuery other) { }

	// RVA: 0x1116030
	public override void Reset() { }

	// RVA: 0x11164A4
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x111650C
	protected string get_Name() { }

	// RVA: 0x1116514
	protected string get_Namespace() { }

	// RVA: 0x111651C
	protected bool get_NameTest() { }

	// RVA: 0x1116524
	protected XPathNodeType get_TypeTest() { }

	// RVA: 0x111652C
	public override int get_CurrentPosition() { }

	// RVA: 0x1116534
	public override XPathNavigator get_Current() { }

	// RVA: 0x111653C
	public virtual bool matches(XPathNavigator e) { }

	// RVA: 0x1116668
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11166C4
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class BooleanExpr
{
	// Fields
	private Query _opnd1; // 0x18
	private Query _opnd2; // 0x20
	private bool _isOr; // 0x28

	// Methods

	// RVA: 0x11166CC
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x1116858
	private void .ctor(BooleanExpr other) { }

	// RVA: 0x11168C8
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x111691C
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11169F8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1116AA8
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class BooleanFunctions
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _funcType; // 0x20

	// Methods

	// RVA: 0x1116810
	public void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0x1116AB0
	private void .ctor(BooleanFunctions other) { }

	// RVA: 0x1116B04
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1116B20
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1117020
	internal static bool toBoolean(Double number) { }

	// RVA: 0x1117040
	internal static bool toBoolean(string str) { }

	// RVA: 0x1116D14
	internal bool toBoolean(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1117064
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1116EB8
	private bool Not(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1116F58
	private bool Lang(XPathNodeIterator nodeIterator) { }

	// RVA: 0x111706C
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheAxisQuery
{
	// Fields
	protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer; // 0x58

	// Methods

	// RVA: 0x1117100
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x11171C0
	protected void .ctor(CacheAxisQuery other) { }

	// RVA: 0x1117274
	public override void Reset() { }

	// RVA: 0x111727C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1117370
	public override XPathNavigator Advance() { }

	// RVA: 0x1117410
	public override XPathNavigator get_Current() { }

	// RVA: 0x1117498
	public override int get_CurrentPosition() { }

	// RVA: 0x11174A0
	public override int get_Count() { }

	// RVA: 0x11174EC
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class CacheChildrenQuery
{
	// Fields
	private XPathNavigator _nextInput; // 0x60
	private MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator> _elementStk; // 0x68
	private MS.Internal.Xml.XPath.ClonableStack<System.Int32> _positionStk; // 0x70
	private bool _needInput; // 0x78

	// Methods

	// RVA: 0x11174F4
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x1117704
	private void .ctor(CacheChildrenQuery other) { }

	// RVA: 0x1117888
	public override void Reset() { }

	// RVA: 0x1117A5C
	public override XPathNavigator Advance() { }

	// RVA: 0x1117CE8
	private bool DecideNextNode() { }

	// RVA: 0x1117C68
	private XPathNavigator GetNextInput() { }

	// RVA: 0x1117E80
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheOutputQuery
{
	// Fields
	internal Query input; // 0x18
	protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer; // 0x20

	// Methods

	// RVA: 0x1117EE4
	public void .ctor(Query input) { }

	// RVA: 0x1117F94
	protected void .ctor(CacheOutputQuery other) { }

	// RVA: 0x1118068
	public override void Reset() { }

	// RVA: 0x1118070
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1118098
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x111815C
	public override XPathNavigator Advance() { }

	// RVA: 0x11181FC
	public override XPathNavigator get_Current() { }

	// RVA: 0x1118284
	public override XPathResultType get_StaticType() { }

	// RVA: 0x111828C
	public override int get_CurrentPosition() { }

	// RVA: 0x1118294
	public override int get_Count() { }

	// RVA: 0x11182E0
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ChildrenQuery
{
	// Fields
	private XPathNodeIterator _iterator; // 0x58

	// Methods

	// RVA: 0x111765C
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x11177E0
	protected void .ctor(ChildrenQuery other) { }

	// RVA: 0x11179C0
	public override void Reset() { }

	// RVA: 0x11182E8
	public override XPathNavigator Advance() { }

	// RVA: 0x11184B0
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ClonableStack<T0>
{
	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2CB8
	private void .ctor(System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0x316B894
	public void Push(T value) { }

	// RVA: 0x316B894
	public T Pop() { }

	// RVA: 0x316B894
	public T Peek() { }

	// RVA: 0x30B1CD4
	public MS.Internal.Xml.XPath.ClonableStack<T> Clone() { }

}

// Namespace: 
private class UndefinedXsltContext
{
	// Fields
	private IXmlNamespaceResolver _nsResolver; // 0x50

	// Methods

	// RVA: 0x1118700
	public void .ctor(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1118738
	public override string get_DefaultNamespace() { }

	// RVA: 0x1118784
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11188C4
	public override IXsltContextVariable ResolveVariable(string prefix, string name) { }

	// RVA: 0x1118900
	public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) { }

	// RVA: 0x111893C
	public override bool get_Whitespace() { }

	// RVA: 0x1118944
	public override bool PreserveWhitespace(XPathNavigator node) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class CompiledXpathExpr
{
	// Fields
	private Query _query; // 0x10
	private string _expr; // 0x18
	private bool _needContext; // 0x20

	// Methods

	// RVA: 0x1118514
	internal void .ctor(Query query, string expression, bool needContext) { }

	// RVA: 0x1118570
	internal Query get_QueryTree() { }

	// RVA: 0x11185C4
	public override void SetContext(IXmlNamespaceResolver nsResolver) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ContextQuery
{
	// Fields
	protected XPathNavigator contextNode; // 0x18

	// Methods

	// RVA: 0x1115C80
	public void .ctor() { }

	// RVA: 0x1115CE4
	protected void .ctor(ContextQuery other) { }

	// RVA: 0x111894C
	public override void Reset() { }

	// RVA: 0x1118954
	public override XPathNavigator get_Current() { }

	// RVA: 0x111895C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x11189AC
	public override XPathNavigator Advance() { }

	// RVA: 0x11189CC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1118A4C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1118A54
	public override int get_CurrentPosition() { }

	// RVA: 0x1118A5C
	public override int get_Count() { }

	// RVA: 0x1118A64
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class DescendantBaseQuery
{
	// Fields
	protected bool matchSelf; // 0x54
	protected bool abbrAxis; // 0x55

	// Methods

	// RVA: 0x1118A6C
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x1118AA4
	public void .ctor(DescendantBaseQuery other) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class DescendantQuery
{
	// Fields
	private XPathNodeIterator _nodeIterator; // 0x58

	// Methods

	// RVA: 0x1118AD8
	internal void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x1118B10
	public void .ctor(DescendantQuery other) { }

	// RVA: 0x1118B5C
	public override void Reset() { }

	// RVA: 0x1118BAC
	public override XPathNavigator Advance() { }

	// RVA: 0x1118D5C
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DescendantOverDescendantQuery
{
	// Fields
	private int _level; // 0x58

	// Methods

	// RVA: 0x1118DEC
	public void .ctor(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis) { }

	// RVA: 0x1118E30
	private void .ctor(DescendantOverDescendantQuery other) { }

	// RVA: 0x1118E6C
	public override void Reset() { }

	// RVA: 0x1118EB4
	public override XPathNavigator Advance() { }

	// RVA: 0x1119024
	private bool MoveToFirstChild() { }

	// RVA: 0x111906C
	private bool MoveUpUntilNext() { }

	// RVA: 0x11190D8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DocumentOrderQuery
{
	// Methods

	// RVA: 0x1119154
	public void .ctor(Query qyParent) { }

	// RVA: 0x1119158
	private void .ctor(DocumentOrderQuery other) { }

	// RVA: 0x111915C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x11191B8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class EmptyQuery
{
	// Methods

	// RVA: 0x111921C
	public override XPathNavigator Advance() { }

	// RVA: 0x1119224
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1119228
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x111922C
	public override int get_CurrentPosition() { }

	// RVA: 0x1119234
	public override int get_Count() { }

	// RVA: 0x111923C
	public override QueryProps get_Properties() { }

	// RVA: 0x1119244
	public override XPathResultType get_StaticType() { }

	// RVA: 0x111924C
	public override void Reset() { }

	// RVA: 0x1119250
	public override XPathNavigator get_Current() { }

	// RVA: 0x1119258
	public void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ExtensionQuery
{
	// Fields
	protected string prefix; // 0x18
	protected string name; // 0x20
	protected XsltContext xsltContext; // 0x28
	private ResetableIterator _queryIterator; // 0x30

	// Methods

	// RVA: 0x1119260
	public void .ctor(string prefix, string name) { }

	// RVA: 0x11192B0
	protected void .ctor(ExtensionQuery other) { }

	// RVA: 0x11193D8
	public override void Reset() { }

	// RVA: 0x11193F0
	public override XPathNavigator get_Current() { }

	// RVA: 0x111947C
	public override XPathNavigator Advance() { }

	// RVA: 0x1119504
	public override int get_CurrentPosition() { }

	// RVA: 0x111951C
	protected object ProcessResult(object value) { }

	// RVA: 0x1119988
	protected string get_QName() { }

	// RVA: 0x11199FC
	public override int get_Count() { }

	// RVA: 0x1119A18
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Filter
{
	// Fields
	private AstNode _input; // 0x10
	private AstNode _condition; // 0x18

	// Methods

	// RVA: 0x1119A20
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x1119A70
	public override AstType get_Type() { }

	// RVA: 0x1119A78
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1119A80
	public AstNode get_Input() { }

	// RVA: 0x1119A88
	public AstNode get_Condition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FilterQuery
{
	// Fields
	private Query _cond; // 0x58
	private bool _noPosition; // 0x60

	// Methods

	// RVA: 0x1119A90
	public void .ctor(Query qyParent, Query cond, bool noPosition) { }

	// RVA: 0x1119AD4
	private void .ctor(FilterQuery other) { }

	// RVA: 0x1119B24
	public override void Reset() { }

	// RVA: 0x1119B7C
	public Query get_Condition() { }

	// RVA: 0x1119B84
	public override void SetXsltContext(XsltContext input) { }

	// RVA: 0x1119CB8
	public override XPathNavigator Advance() { }

	// RVA: 0x1119D44
	internal bool EvaluatePredicate() { }

	// RVA: 0x1119F18
	public override QueryProps get_Properties() { }

	// RVA: 0x1119F4C
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FollSiblingQuery
{
	// Fields
	private MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator> _elementStk; // 0x58
	private System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> _parentStk; // 0x60
	private XPathNavigator _nextInput; // 0x68

	// Methods

	// RVA: 0x1119FDC
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x111A0E8
	private void .ctor(FollSiblingQuery other) { }

	// RVA: 0x111A1E0
	public override void Reset() { }

	// RVA: 0x111A30C
	private bool Visited(XPathNavigator nav) { }

	// RVA: 0x111A424
	private XPathNavigator FetchInput() { }

	// RVA: 0x111A490
	public override XPathNavigator Advance() { }

	// RVA: 0x111A720
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FollowingQuery
{
	// Fields
	private XPathNavigator _input; // 0x58
	private XPathNodeIterator _iterator; // 0x60

	// Methods

	// RVA: 0x111A784
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x111A788
	private void .ctor(FollowingQuery other) { }

	// RVA: 0x111A7E8
	public override void Reset() { }

	// RVA: 0x111A838
	public override XPathNavigator Advance() { }

	// RVA: 0x111AAC0
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ForwardPositionQuery
{
	// Methods

	// RVA: 0x111AB64
	public void .ctor(Query input) { }

	// RVA: 0x111AB68
	protected void .ctor(ForwardPositionQuery other) { }

	// RVA: 0x111AB6C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x111AC1C
	public override XPathNodeIterator Clone() { }

}

// Namespace: 
public enum FunctionType
{
	// Fields
	public int value__; // 0x10
	public const FunctionType FuncLast = 0;
	public const FunctionType FuncPosition = 1;
	public const FunctionType FuncCount = 2;
	public const FunctionType FuncID = 3;
	public const FunctionType FuncLocalName = 4;
	public const FunctionType FuncNameSpaceUri = 5;
	public const FunctionType FuncName = 6;
	public const FunctionType FuncString = 7;
	public const FunctionType FuncBoolean = 8;
	public const FunctionType FuncNumber = 9;
	public const FunctionType FuncTrue = 10;
	public const FunctionType FuncFalse = 11;
	public const FunctionType FuncNot = 12;
	public const FunctionType FuncConcat = 13;
	public const FunctionType FuncStartsWith = 14;
	public const FunctionType FuncContains = 15;
	public const FunctionType FuncSubstringBefore = 16;
	public const FunctionType FuncSubstringAfter = 17;
	public const FunctionType FuncSubstring = 18;
	public const FunctionType FuncStringLength = 19;
	public const FunctionType FuncNormalize = 20;
	public const FunctionType FuncTranslate = 21;
	public const FunctionType FuncLang = 22;
	public const FunctionType FuncSum = 23;
	public const FunctionType FuncFloor = 24;
	public const FunctionType FuncCeiling = 25;
	public const FunctionType FuncRound = 26;
	public const FunctionType FuncUserDefined = 27;
}

// Namespace: MS.Internal.Xml.XPath
internal class Function
{
	// Fields
	private FunctionType _functionType; // 0x10
	private System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> _argumentList; // 0x18
	private string _name; // 0x20
	private string _prefix; // 0x28
	internal static XPathResultType[] ReturnTypes; // 0x0

	// Methods

	// RVA: 0x111AC80
	public void .ctor(FunctionType ftype, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }

	// RVA: 0x111AD24
	public void .ctor(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }

	// RVA: 0x111ADF8
	public void .ctor(FunctionType ftype, AstNode arg) { }

	// RVA: 0x111AEC4
	public override AstType get_Type() { }

	// RVA: 0x111AECC
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x111AF70
	public FunctionType get_TypeOfFunction() { }

	// RVA: 0x111AF78
	public System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> get_ArgumentList() { }

	// RVA: 0x111AF80
	public string get_Prefix() { }

	// RVA: 0x111AF88
	public string get_Name() { }

	// RVA: 0x111AF90
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FunctionQuery
{
	// Fields
	private System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> _args; // 0x38
	private IXsltContextFunction _function; // 0x40

	// Methods

	// RVA: 0x111B034
	public void .ctor(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> args) { }

	// RVA: 0x111B098
	private void .ctor(FunctionQuery other) { }

	// RVA: 0x111B2B4
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x111B834
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x111BDB4
	public override XPathResultType get_StaticType() { }

	// RVA: 0x111BE74
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Group
{
	// Fields
	private AstNode _groupNode; // 0x10

	// Methods

	// RVA: 0x111BED8
	public void .ctor(AstNode groupNode) { }

	// RVA: 0x111BF0C
	public override AstType get_Type() { }

	// RVA: 0x111BF14
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x111BF1C
	public AstNode get_GroupNode() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class GroupQuery
{
	// Methods

	// RVA: 0x111BF24
	public void .ctor(Query qy) { }

	// RVA: 0x111BF28
	private void .ctor(GroupQuery other) { }

	// RVA: 0x111BF2C
	public override XPathNavigator Advance() { }

	// RVA: 0x111BF8C
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x111BFB4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x111C018
	public override XPathResultType get_StaticType() { }

	// RVA: 0x111C040
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class IDQuery
{
	// Methods

	// RVA: 0x111C048
	public void .ctor(Query arg) { }

	// RVA: 0x111C04C
	private void .ctor(IDQuery other) { }

	// RVA: 0x111C050
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x111C2A4
	private void ProcessIds(XPathNavigator contextNode, string val) { }

	// RVA: 0x111C3AC
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class IteratorFilter
{
	// Fields
	private XPathNodeIterator _innerIterator; // 0x18
	private string _name; // 0x20
	private int _position; // 0x28

	// Methods

	// RVA: 0x1118460
	internal void .ctor(XPathNodeIterator innerIterator, string name) { }

	// RVA: 0x111C410
	private void .ctor(IteratorFilter it) { }

	// RVA: 0x111C47C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x111C524
	public override XPathNavigator get_Current() { }

	// RVA: 0x111C548
	public override int get_CurrentPosition() { }

	// RVA: 0x111C550
	public override bool MoveNext() { }

}

// Namespace: 
private sealed class cmpXslt
{
	// Methods

	// RVA: 0x1121004
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11210A8
	public virtual bool Invoke(Op op, object val1, object val2) { }

}

// Namespace: 
private struct NodeSet
{
	// Fields
	private Query _opnd; // 0x10
	private XPathNavigator _current; // 0x18

	// Methods

	// RVA: 0x111CBC8
	public void .ctor(object opnd) { }

	// RVA: 0x111CC9C
	public bool MoveNext() { }

	// RVA: 0x111CD14
	public void Reset() { }

	// RVA: 0x111CCF0
	public string get_Value() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class LogicalExpr
{
	// Fields
	private Op _op; // 0x14
	private Query _opnd1; // 0x18
	private Query _opnd2; // 0x20
	private static readonly cmpXslt[][] s_CompXsltE; // 0x0
	private static readonly cmpXslt[][] s_CompXsltO; // 0x8

	// Methods

	// RVA: 0x111C5D4
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x111C62C
	private void .ctor(LogicalExpr other) { }

	// RVA: 0x111C698
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x111C6EC
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x111CA48
	private static bool cmpQueryQueryE(Op op, object val1, object val2) { }

	// RVA: 0x111CD38
	private static bool cmpQueryQueryO(Op op, object val1, object val2) { }

	// RVA: 0x111D0BC
	private static bool cmpQueryNumber(Op op, object val1, object val2) { }

	// RVA: 0x111D2A8
	private static bool cmpQueryStringE(Op op, object val1, object val2) { }

	// RVA: 0x111D41C
	private static bool cmpQueryStringO(Op op, object val1, object val2) { }

	// RVA: 0x111D698
	private static bool cmpRtfQueryE(Op op, object val1, object val2) { }

	// RVA: 0x111D8D0
	private static bool cmpRtfQueryO(Op op, object val1, object val2) { }

	// RVA: 0x111DB40
	private static bool cmpQueryBoolE(Op op, object val1, object val2) { }

	// RVA: 0x111DC68
	private static bool cmpQueryBoolO(Op op, object val1, object val2) { }

	// RVA: 0x111DC54
	private static bool cmpBoolBoolE(Op op, bool n1, bool n2) { }

	// RVA: 0x111DE4C
	private static bool cmpBoolBoolE(Op op, object val1, object val2) { }

	// RVA: 0x111DF44
	private static bool cmpBoolBoolO(Op op, object val1, object val2) { }

	// RVA: 0x111E0E8
	private static bool cmpBoolNumberE(Op op, object val1, object val2) { }

	// RVA: 0x111E210
	private static bool cmpBoolNumberO(Op op, object val1, object val2) { }

	// RVA: 0x111E3B8
	private static bool cmpBoolStringE(Op op, object val1, object val2) { }

	// RVA: 0x111E4B4
	private static bool cmpRtfBoolE(Op op, object val1, object val2) { }

	// RVA: 0x111E61C
	private static bool cmpBoolStringO(Op op, object val1, object val2) { }

	// RVA: 0x111E7F8
	private static bool cmpRtfBoolO(Op op, object val1, object val2) { }

	// RVA: 0x111D048
	private static bool cmpNumberNumber(Op op, Double n1, Double n2) { }

	// RVA: 0x111D63C
	private static bool cmpNumberNumberO(Op op, Double n1, Double n2) { }

	// RVA: 0x111EA60
	private static bool cmpNumberNumber(Op op, object val1, object val2) { }

	// RVA: 0x111EC10
	private static bool cmpStringNumber(Op op, object val1, object val2) { }

	// RVA: 0x111EE08
	private static bool cmpRtfNumber(Op op, object val1, object val2) { }

	// RVA: 0x111D3E4
	private static bool cmpStringStringE(Op op, string n1, string n2) { }

	// RVA: 0x111F074
	private static bool cmpStringStringE(Op op, object val1, object val2) { }

	// RVA: 0x111F144
	private static bool cmpRtfStringE(Op op, object val1, object val2) { }

	// RVA: 0x111F284
	private static bool cmpRtfRtfE(Op op, object val1, object val2) { }

	// RVA: 0x111F400
	private static bool cmpStringStringO(Op op, object val1, object val2) { }

	// RVA: 0x111F61C
	private static bool cmpRtfStringO(Op op, object val1, object val2) { }

	// RVA: 0x111F8C0
	private static bool cmpRtfRtfO(Op op, object val1, object val2) { }

	// RVA: 0x111FB58
	public override XPathNodeIterator Clone() { }

	// RVA: 0x111D848
	private static string Rtf(object o) { }

	// RVA: 0x111FC08
	public override XPathResultType get_StaticType() { }

	// RVA: 0x111FC10
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class MergeFilterQuery
{
	// Fields
	private Query _child; // 0x28

	// Methods

	// RVA: 0x11210BC
	public void .ctor(Query input, Query child) { }

	// RVA: 0x11210EC
	private void .ctor(MergeFilterQuery other) { }

	// RVA: 0x1121130
	public override void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x1121184
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1121218
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NamespaceQuery
{
	// Fields
	private bool _onNamespace; // 0x54

	// Methods

	// RVA: 0x11212A0
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x11212A4
	private void .ctor(NamespaceQuery other) { }

	// RVA: 0x11212D8
	public override void Reset() { }

	// RVA: 0x1121320
	public override XPathNavigator Advance() { }

	// RVA: 0x1121408
	public override bool matches(XPathNavigator e) { }

	// RVA: 0x112149C
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NodeFunctions
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _funcType; // 0x20
	private XsltContext _xsltContext; // 0x28

	// Methods

	// RVA: 0x1121510
	public void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0x1121554
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x11215CC
	private XPathNavigator EvaluateArg(XPathNodeIterator context) { }

	// RVA: 0x1121638
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1121944
	public override XPathResultType get_StaticType() { }

	// RVA: 0x11219E8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NumberFunctions
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _ftype; // 0x20

	// Methods

	// RVA: 0x1121A84
	public void .ctor(FunctionType ftype, Query arg) { }

	// RVA: 0x1121ACC
	private void .ctor(NumberFunctions other) { }

	// RVA: 0x1121B20
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x111DE38
	internal static Double Number(bool arg) { }

	// RVA: 0x111CFC0
	internal static Double Number(string arg) { }

	// RVA: 0x1121B3C
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1121C80
	private Double Number(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1121F14
	private Double Sum(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1122004
	private Double Floor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11220CC
	private Double Ceiling(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1122194
	private Double Round(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1122228
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1122230
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NumericExpr
{
	// Fields
	private Op _op; // 0x14
	private Query _opnd1; // 0x18
	private Query _opnd2; // 0x20

	// Methods

	// RVA: 0x11222C4
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x11223EC
	private void .ctor(NumericExpr other) { }

	// RVA: 0x1122458
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x11224AC
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11225FC
	private static Double GetValue(Op op, Double n1, Double n2) { }

	// RVA: 0x112265C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1122664
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Operand
{
	// Fields
	private XPathResultType _type; // 0x10
	private object _val; // 0x18

	// Methods

	// RVA: 0x1122714
	public void .ctor(string val) { }

	// RVA: 0x1122750
	public void .ctor(Double val) { }

	// RVA: 0x11227E0
	public override AstType get_Type() { }

	// RVA: 0x11227E8
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x11227F0
	public object get_OperandValue() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class OperandQuery
{
	// Fields
	internal object val; // 0x18

	// Methods

	// RVA: 0x11227F8
	public void .ctor(object val) { }

	// RVA: 0x112282C
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1122834
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1122840
	public override XPathNodeIterator Clone() { }

}

// Namespace: 
public enum Op
{
	// Fields
	public int value__; // 0x10
	public const Op INVALID = 0;
	public const Op OR = 1;
	public const Op AND = 2;
	public const Op EQ = 3;
	public const Op NE = 4;
	public const Op LT = 5;
	public const Op LE = 6;
	public const Op GT = 7;
	public const Op GE = 8;
	public const Op PLUS = 9;
	public const Op MINUS = 10;
	public const Op MUL = 11;
	public const Op DIV = 12;
	public const Op MOD = 13;
	public const Op UNION = 14;
}

// Namespace: MS.Internal.Xml.XPath
internal class Operator
{
	// Fields
	private static Op[] s_invertOp; // 0x0
	private Op _opType; // 0x10
	private AstNode _opnd1; // 0x18
	private AstNode _opnd2; // 0x20

	// Methods

	// RVA: 0x111C9A8
	public static Op InvertOperator(Op op) { }

	// RVA: 0x1122844
	public void .ctor(Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x112289C
	public override AstType get_Type() { }

	// RVA: 0x11228A4
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x11228C4
	public Op get_OperatorType() { }

	// RVA: 0x11228CC
	public AstNode get_Operand1() { }

	// RVA: 0x11228D4
	public AstNode get_Operand2() { }

	// RVA: 0x11228DC
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ParentQuery
{
	// Methods

	// RVA: 0x1122980
	public void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1122A40
	private void .ctor(ParentQuery other) { }

	// RVA: 0x1122A44
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1122AEC
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class PreSiblingQuery
{
	// Methods

	// RVA: 0x1122B50
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1122C10
	protected void .ctor(PreSiblingQuery other) { }

	// RVA: 0x1122C14
	private static bool NotVisited(XPathNavigator nav, System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> parentStk) { }

	// RVA: 0x1122D40
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1123018
	public override XPathNodeIterator Clone() { }

	// RVA: 0x112307C
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class PrecedingQuery
{
	// Fields
	private XPathNodeIterator _workIterator; // 0x58
	private MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator> _ancestorStk; // 0x60

	// Methods

	// RVA: 0x1123084
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x112313C
	private void .ctor(PrecedingQuery other) { }

	// RVA: 0x11231D8
	public override void Reset() { }

	// RVA: 0x11232AC
	public override XPathNavigator Advance() { }

	// RVA: 0x1123570
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11235D4
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal enum QueryProps
{
	// Fields
	public int value__; // 0x10
	public const QueryProps None = 0;
	public const QueryProps Position = 1;
	public const QueryProps Count = 2;
	public const QueryProps Cached = 4;
	public const QueryProps Reverse = 8;
	public const QueryProps Merge = 16;
}

// Namespace: MS.Internal.Xml.XPath
internal abstract class Query
{
	// Methods

	// RVA: 0x11235F0
	public void .ctor() { }

	// RVA: 0x1123648
	protected void .ctor(Query other) { }

	// RVA: 0x11236B8
	public override bool MoveNext() { }

	// RVA: 0x11236E0
	public override int get_Count() { }

	// RVA: 0x11237C8
	public virtual void SetXsltContext(XsltContext context) { }

	// RVA: -1
	public abstract object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: -1
	public abstract XPathNavigator Advance() { }

	// RVA: -1
	public abstract XPathResultType get_StaticType() { }

	// RVA: 0x11237CC
	public virtual QueryProps get_Properties() { }

	// RVA: 0x11237D4
	public static Query Clone(Query input) { }

	// RVA: 0x1123870
	protected static XPathNodeIterator Clone(XPathNodeIterator input) { }

	// RVA: 0x1123884
	protected static XPathNavigator Clone(XPathNavigator input) { }

	// RVA: 0x112389C
	public static bool Insert(System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> buffer, XPathNavigator nav) { }

	// RVA: 0x1123B70
	private static int GetMedian(int l, int r) { }

	// RVA: 0x1123A4C
	public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r) { }

	// RVA: 0x1123B7C
	protected XPathResultType GetXPathType(object value) { }

}

// Namespace: 
private enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags None = 0;
	public const Flags SmartDesc = 1;
	public const Flags PosFilter = 2;
	public const Flags Filter = 4;
}

// Namespace: 
private enum Props
{
	// Fields
	public int value__; // 0x10
	public const Props None = 0;
	public const Props PosFilter = 1;
	public const Props HasPosition = 2;
	public const Props HasLast = 4;
	public const Props NonFlat = 8;
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class QueryBuilder
{
	// Fields
	private string _query; // 0x10
	private bool _allowVar; // 0x18
	private bool _allowKey; // 0x19
	private bool _allowCurrent; // 0x1A
	private bool _needContext; // 0x1B
	private BaseAxisQuery _firstInput; // 0x20
	private int _parseDepth; // 0x28

	// Methods

	// RVA: 0x1123C98
	private void Reset() { }

	// RVA: 0x1123CA4
	private Query ProcessAxis(Axis root, Flags flags, Props props) { }

	// RVA: 0x1124804
	private static bool CanBeNumber(Query q) { }

	// RVA: 0x112486C
	private Query ProcessFilter(Filter root, Flags flags, Props props) { }

	// RVA: 0x1124D80
	private Query ProcessOperator(Operator root, Props props) { }

	// RVA: 0x1125000
	private Query ProcessVariable(Variable root) { }

	// RVA: 0x11250D8
	private Query ProcessFunction(Function root, Props props) { }

	// RVA: 0x11255E4
	private System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> ProcessArguments(System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> args, Props props) { }

	// RVA: 0x1124410
	private Query ProcessNode(AstNode root, Flags flags, Props props) { }

	// RVA: 0x11257A8
	private Query Build(AstNode root, string query) { }

	// RVA: 0x11257FC
	internal Query Build(string query, bool allowVar, bool allowKey) { }

	// RVA: 0x1125A08
	internal Query Build(string query, bool needContext) { }

	// RVA: 0x1125AD0
	public void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ResetableIterator
{
	// Methods

	// RVA: 0x112361C
	public void .ctor() { }

	// RVA: 0x1123680
	protected void .ctor(ResetableIterator other) { }

	// RVA: 0x1125AD8
	protected void ResetCount() { }

	// RVA: -1
	public abstract void Reset() { }

	// RVA: -1
	public abstract override int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ReversePositionQuery
{
	// Methods

	// RVA: 0x1124D78
	public void .ctor(Query input) { }

	// RVA: 0x1125AE4
	private void .ctor(ReversePositionQuery other) { }

	// RVA: 0x1125AEC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1125B54
	public override int get_CurrentPosition() { }

	// RVA: 0x1125BAC
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Root
{
	// Methods

	// RVA: 0x1125BC8
	public void .ctor() { }

	// RVA: 0x1125BD0
	public override AstType get_Type() { }

	// RVA: 0x1125BD8
	public override XPathResultType get_ReturnType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class StringFunctions
{
	// Fields
	private FunctionType _funcType; // 0x14
	private System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> _argList; // 0x18
	private static readonly CompareInfo s_compareInfo; // 0x0

	// Methods

	// RVA: 0x1125760
	public void .ctor(FunctionType funcType, System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> argList) { }

	// RVA: 0x1125C0C
	private void .ctor(StringFunctions other) { }

	// RVA: 0x1125EB8
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1126044
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1127D28
	internal static string toString(Double num) { }

	// RVA: 0x1127D90
	internal static string toString(bool b) { }

	// RVA: 0x1126254
	private string toString(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1127DFC
	public override XPathResultType get_StaticType() { }

	// RVA: 0x11266C8
	private string Concat(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11268BC
	private bool StartsWith(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1126AA0
	private bool Contains(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1126C90
	private string SubstringBefore(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1126ED4
	private string SubstringAfter(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1127114
	private string Substring(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1127564
	private Double StringLength(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1127718
	private string Normalize(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11279C0
	private string Translate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1127E24
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1127E88
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class UnionExpr
{
	// Fields
	internal Query qy1; // 0x18
	internal Query qy2; // 0x20
	private bool _advance1; // 0x28
	private bool _advance2; // 0x29
	private XPathNavigator _currentNode; // 0x30
	private XPathNavigator _nextNode; // 0x38

	// Methods

	// RVA: 0x1124F9C
	public void .ctor(Query query1, Query query2) { }

	// RVA: 0x1127F38
	private void .ctor(UnionExpr other) { }

	// RVA: 0x112811C
	public override void Reset() { }

	// RVA: 0x1128178
	public override void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x11281CC
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1128248
	private XPathNavigator ProcessSamePosition(XPathNavigator result) { }

	// RVA: 0x1128280
	private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x11282C8
	private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x112830C
	public override XPathNavigator Advance() { }

	// RVA: 0x11284BC
	public override XPathResultType get_StaticType() { }

	// RVA: 0x11284C4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1128528
	public override XPathNavigator get_Current() { }

	// RVA: 0x1128530
	public override int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ValueQuery
{
	// Methods

	// RVA: 0x1125BE0
	public void .ctor() { }

	// RVA: 0x1125E80
	protected void .ctor(ValueQuery other) { }

	// RVA: 0x1128570
	public sealed override void Reset() { }

	// RVA: 0x1128574
	public sealed override XPathNavigator get_Current() { }

	// RVA: 0x11285B0
	public sealed override int get_CurrentPosition() { }

	// RVA: 0x11285EC
	public sealed override int get_Count() { }

	// RVA: 0x1128628
	public sealed override XPathNavigator Advance() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Variable
{
	// Fields
	private string _localname; // 0x10
	private string _prefix; // 0x18

	// Methods

	// RVA: 0x1128664
	public void .ctor(string name, string prefix) { }

	// RVA: 0x11286B4
	public override AstType get_Type() { }

	// RVA: 0x11286BC
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x11286C4
	public string get_Localname() { }

	// RVA: 0x11286CC
	public string get_Prefix() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class VariableQuery
{
	// Fields
	private IXsltContextVariable _variable; // 0x38

	// Methods

	// RVA: 0x11250C4
	public void .ctor(string name, string prefix) { }

	// RVA: 0x11286D4
	private void .ctor(VariableQuery other) { }

	// RVA: 0x1128710
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x11287E4
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11288E0
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1128A50
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathAncestorQuery
{
	// Fields
	private bool _matchSelf; // 0x60

	// Methods

	// RVA: 0x11247D0
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf) { }

	// RVA: 0x1128AD0
	private void .ctor(XPathAncestorQuery other) { }

	// RVA: 0x1128B08
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1128C34
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1128CAC
	public override int get_CurrentPosition() { }

	// RVA: 0x1128D04
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathArrayIterator
{
	// Fields
	protected IList list; // 0x18
	protected int index; // 0x20

	// Methods

	// RVA: 0x1128D20
	public void .ctor(XPathArrayIterator it) { }

	// RVA: 0x1128D70
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1128EDC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1128F68
	public override XPathNavigator get_Current() { }

	// RVA: 0x11290E8
	public override int get_CurrentPosition() { }

	// RVA: 0x11290F0
	public override int get_Count() { }

	// RVA: 0x11291A8
	public override bool MoveNext() { }

	// RVA: 0x1129290
	public override void Reset() { }

	// RVA: 0x1129298
	public override IEnumerator GetEnumerator() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class XPathAxisIterator
{
	// Fields
	internal XPathNavigator nav; // 0x18
	internal XPathNodeType type; // 0x20
	internal string name; // 0x28
	internal string uri; // 0x30
	internal int position; // 0x38
	internal bool matchSelf; // 0x3C
	internal bool first; // 0x3D

	// Methods

	// RVA: 0x112934C
	public void .ctor(XPathNavigator nav, bool matchSelf) { }

	// RVA: 0x112939C
	public void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x11293F4
	public void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x11294E4
	public void .ctor(XPathAxisIterator it) { }

	// RVA: 0x112957C
	public override XPathNavigator get_Current() { }

	// RVA: 0x1129584
	public override int get_CurrentPosition() { }

	// RVA: 0x112958C
	protected virtual bool get_Matches() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathChildIterator
{
	// Methods

	// RVA: 0x11296EC
	public void .ctor(XPathNavigator nav, XPathNodeType type) { }

	// RVA: 0x1129740
	public void .ctor(XPathNavigator nav, string name, string namespaceURI) { }

	// RVA: 0x1129748
	public void .ctor(XPathChildIterator it) { }

	// RVA: 0x112974C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11297B0
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathDescendantIterator
{
	// Fields
	private int _level; // 0x40

	// Methods

	// RVA: 0x1129858
	public void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x11298B0
	public void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x11298B4
	public void .ctor(XPathDescendantIterator it) { }

	// RVA: 0x11298E8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x112995C
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathEmptyIterator
{
	// Fields
	public static XPathEmptyIterator Instance; // 0x0

	// Methods

	// RVA: 0x1129A5C
	private void .ctor() { }

	// RVA: 0x1129A88
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1129A8C
	public override XPathNavigator get_Current() { }

	// RVA: 0x1129A94
	public override int get_CurrentPosition() { }

	// RVA: 0x1129A9C
	public override int get_Count() { }

	// RVA: 0x1129AA4
	public override bool MoveNext() { }

	// RVA: 0x1129AAC
	public override void Reset() { }

	// RVA: 0x1129AB0
	private static void .cctor() { }

}

// Namespace: 
private class ParamInfo
{
	// Fields
	private FunctionType _ftype; // 0x10
	private int _minargs; // 0x14
	private int _maxargs; // 0x18
	private XPathResultType[] _argTypes; // 0x20

	// Methods

	// RVA: 0x112DC44
	public FunctionType get_FType() { }

	// RVA: 0x112DC4C
	public int get_Minargs() { }

	// RVA: 0x112DC54
	public int get_Maxargs() { }

	// RVA: 0x112DC5C
	public XPathResultType[] get_ArgTypes() { }

	// RVA: 0x112D5E8
	internal void .ctor(FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathParser
{
	// Fields
	private XPathScanner _scanner; // 0x10
	private int _parseDepth; // 0x18
	private static readonly XPathResultType[] s_temparray1; // 0x0
	private static readonly XPathResultType[] s_temparray2; // 0x8
	private static readonly XPathResultType[] s_temparray3; // 0x10
	private static readonly XPathResultType[] s_temparray4; // 0x18
	private static readonly XPathResultType[] s_temparray5; // 0x20
	private static readonly XPathResultType[] s_temparray6; // 0x28
	private static readonly XPathResultType[] s_temparray7; // 0x30
	private static readonly XPathResultType[] s_temparray8; // 0x38
	private static readonly XPathResultType[] s_temparray9; // 0x40
	private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.XPathParser.ParamInfo> s_functionTable; // 0x48
	private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.Axis.AxisType> s_AxesTable; // 0x50

	// Methods

	// RVA: 0x1129B24
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x11258C0
	public static AstNode ParseXPathExpression(string xpathExpression) { }

	// RVA: 0x1129C60
	private AstNode ParseExpression(AstNode qyInput) { }

	// RVA: 0x1129CD0
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x1129DE0
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x1129F5C
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x112A248
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x112A3F4
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x112A4D8
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x112A664
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x112A748
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x112AAD0
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x112A890
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x112AC88
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x112B384
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x112AF40
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x112AE60
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x112B540
	private static bool IsStep(LexKind lexKind) { }

	// RVA: 0x112B580
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x112B938
	private AstNode ParseNodeTest(AstNode qyInput, AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x112ABD0
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x112B0AC
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x112BD1C
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x112BCAC
	private void CheckToken(LexKind t) { }

	// RVA: 0x112B4D8
	private void PassToken(LexKind t) { }

	// RVA: 0x1129F40
	private void NextLex() { }

	// RVA: 0x1129EF0
	private bool TestOp(string op) { }

	// RVA: 0x112AA6C
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x112CA04
	private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.XPathParser.ParamInfo> CreateFunctionTable() { }

	// RVA: 0x112D640
	private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable() { }

	// RVA: 0x112B828
	private AxisType GetAxis() { }

	// RVA: 0x112D960
	private static void .cctor() { }

}

// Namespace: 
public enum LexKind
{
	// Fields
	public int value__; // 0x10
	public const LexKind Comma = 44;
	public const LexKind Slash = 47;
	public const LexKind At = 64;
	public const LexKind Dot = 46;
	public const LexKind LParens = 40;
	public const LexKind RParens = 41;
	public const LexKind LBracket = 91;
	public const LexKind RBracket = 93;
	public const LexKind Star = 42;
	public const LexKind Plus = 43;
	public const LexKind Minus = 45;
	public const LexKind Eq = 61;
	public const LexKind Lt = 60;
	public const LexKind Gt = 62;
	public const LexKind Bang = 33;
	public const LexKind Dollar = 36;
	public const LexKind Apos = 39;
	public const LexKind Quote = 34;
	public const LexKind Union = 124;
	public const LexKind Ne = 78;
	public const LexKind Le = 76;
	public const LexKind Ge = 71;
	public const LexKind And = 65;
	public const LexKind Or = 79;
	public const LexKind DotDot = 68;
	public const LexKind SlashSlash = 83;
	public const LexKind Name = 110;
	public const LexKind String = 115;
	public const LexKind Number = 100;
	public const LexKind Axe = 97;
	public const LexKind Eof = 69;
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathScanner
{
	// Fields
	private string _xpathExpr; // 0x10
	private int _xpathExprIndex; // 0x18
	private LexKind _kind; // 0x1C
	private Char _currentChar; // 0x20
	private string _name; // 0x28
	private string _prefix; // 0x30
	private string _stringValue; // 0x38
	private Double _numberValue; // 0x40
	private bool _canBeFunction; // 0x48
	private XmlCharType _xmlCharType; // 0x50

	// Methods

	// RVA: 0x1129B58
	public void .ctor(string xpathExpr) { }

	// RVA: 0x112DCD0
	public string get_SourceText() { }

	// RVA: 0x112DCD8
	private Char get_CurrentChar() { }

	// RVA: 0x112DC64
	private bool NextChar() { }

	// RVA: 0x112DCE0
	public LexKind get_Kind() { }

	// RVA: 0x112DCE8
	public string get_Name() { }

	// RVA: 0x112DCF0
	public string get_Prefix() { }

	// RVA: 0x112DCF8
	public string get_StringValue() { }

	// RVA: 0x112DD00
	public Double get_NumberValue() { }

	// RVA: 0x112DD08
	public bool get_CanBeFunction() { }

	// RVA: 0x112DD10
	private void SkipSpace() { }

	// RVA: 0x112C2F0
	public bool NextLex() { }

	// RVA: 0x112DFE0
	private Double ScanNumber() { }

	// RVA: 0x112DD98
	private Double ScanFraction() { }

	// RVA: 0x112DEA4
	private string ScanString() { }

	// RVA: 0x112E1A8
	private string ScanName() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathSelectionIterator
{
	// Fields
	private XPathNavigator _nav; // 0x18
	private Query _query; // 0x20
	private int _position; // 0x28

	// Methods

	// RVA: 0x112E268
	internal void .ctor(XPathNavigator nav, Query query) { }

	// RVA: 0x112E2DC
	protected void .ctor(XPathSelectionIterator it) { }

	// RVA: 0x112E400
	public override void Reset() { }

	// RVA: 0x112E424
	public override bool MoveNext() { }

	// RVA: 0x112E4BC
	public override int get_Count() { }

	// RVA: 0x112E4E0
	public override XPathNavigator get_Current() { }

	// RVA: 0x112E4E8
	public override int get_CurrentPosition() { }

	// RVA: 0x112E4F0
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathSelfQuery
{
	// Methods

	// RVA: 0x11247FC
	public void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x112E554
	private void .ctor(XPathSelfQuery other) { }

	// RVA: 0x112E55C
	public override XPathNavigator Advance() { }

	// RVA: 0x112E5F4
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathSingletonIterator
{
	// Fields
	private XPathNavigator _nav; // 0x18
	private int _position; // 0x20

	// Methods

	// RVA: 0x112E65C
	public void .ctor(XPathNavigator nav) { }

	// RVA: 0x112E698
	public void .ctor(XPathNavigator nav, bool moved) { }

	// RVA: 0x112E6F0
	public void .ctor(XPathSingletonIterator it) { }

	// RVA: 0x112E758
	public override XPathNodeIterator Clone() { }

	// RVA: 0x112E7FC
	public override XPathNavigator get_Current() { }

	// RVA: 0x112E804
	public override int get_CurrentPosition() { }

	// RVA: 0x112E80C
	public override int get_Count() { }

	// RVA: 0x112E814
	public override bool MoveNext() { }

	// RVA: 0x112E83C
	public override void Reset() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathDocumentBaseIterator
{
	// Fields
	protected XPathDocumentNavigator ctxt; // 0x18
	protected int pos; // 0x20

	// Methods

	// RVA: 0x112E844
	protected void .ctor(XPathDocumentNavigator ctxt) { }

	// RVA: 0x112E97C
	protected void .ctor(XPathDocumentBaseIterator iter) { }

	// RVA: 0x112EA10
	public override XPathNavigator get_Current() { }

	// RVA: 0x112EA18
	public override int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentElementChildIterator
{
	// Fields
	private string _localName; // 0x28
	private string _namespaceUri; // 0x30

	// Methods

	// RVA: 0x112EA20
	public void .ctor(XPathDocumentNavigator parent, string name, string namespaceURI) { }

	// RVA: 0x112EB48
	public void .ctor(XPathDocumentElementChildIterator iter) { }

	// RVA: 0x112EBF8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x112EC5C
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentKindChildIterator
{
	// Fields
	private XPathNodeType _typ; // 0x24

	// Methods

	// RVA: 0x112ECEC
	public void .ctor(XPathDocumentNavigator parent, XPathNodeType typ) { }

	// RVA: 0x112ED7C
	public void .ctor(XPathDocumentKindChildIterator iter) { }

	// RVA: 0x112EE10
	public override XPathNodeIterator Clone() { }

	// RVA: 0x112EF00
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentElementDescendantIterator
{
	// Fields
	private XPathDocumentNavigator _end; // 0x28
	private string _localName; // 0x30
	private string _namespaceUri; // 0x38
	private bool _matchSelf; // 0x40

	// Methods

	// RVA: 0x112EF90
	public void .ctor(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x112F150
	public void .ctor(XPathDocumentElementDescendantIterator iter) { }

	// RVA: 0x112F21C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x112F280
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentKindDescendantIterator
{
	// Fields
	private XPathDocumentNavigator _end; // 0x28
	private XPathNodeType _typ; // 0x30
	private bool _matchSelf; // 0x34

	// Methods

	// RVA: 0x112F3F0
	public void .ctor(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf) { }

	// RVA: 0x112F51C
	public void .ctor(XPathDocumentKindDescendantIterator iter) { }

	// RVA: 0x112F5D0
	public override XPathNodeIterator Clone() { }

	// RVA: 0x112F634
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathDocumentNavigator
{
	// Fields
	private XPathNode[] _pageCurrent; // 0x10
	private XPathNode[] _pageParent; // 0x18
	private int _idxCurrent; // 0x20
	private int _idxParent; // 0x24
	private string _atomizedLocalName; // 0x28

	// Methods

	// RVA: 0x112F7D8
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x112E8C0
	public void .ctor(XPathDocumentNavigator nav) { }

	// RVA: 0x112F884
	public override string get_Value() { }

	// RVA: 0x112FDEC
	public override XPathNavigator Clone() { }

	// RVA: 0x112FEC8
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x112FF10
	public override string get_LocalName() { }

	// RVA: 0x112FF70
	public override string get_NamespaceURI() { }

	// RVA: 0x112FFD0
	public override string get_Name() { }

	// RVA: 0x11300E8
	public override string get_Prefix() { }

	// RVA: 0x1130148
	public override string get_BaseURI() { }

	// RVA: 0x11302C8
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1130330
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1130458
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1130538
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1130794
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x1130B94
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x1130DBC
	public override bool MoveToNext() { }

	// RVA: 0x1130E8C
	public override bool MoveToFirstChild() { }

	// RVA: 0x1131064
	public override bool MoveToParent() { }

	// RVA: 0x11311EC
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x1131298
	public override bool MoveToId(string id) { }

	// RVA: 0x1131344
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x11313FC
	public override void MoveToRoot() { }

	// RVA: 0x11314A4
	public override bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x113169C
	public override bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x1131880
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x1131AE0
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x1131C7C
	public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x1132260
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x1132728
	public override XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x11327EC
	public override XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x113288C
	public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x1132908
	public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x11329C0
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x1132C24
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x1132AEC
	private int GetPrimaryLocation() { }

	// RVA: 0x1132B68
	private int GetSecondaryLocation() { }

	// RVA: 0x1132DA4
	public override object get_UnderlyingObject() { }

	// RVA: 0x1132DB4
	public bool HasLineInfo() { }

	// RVA: 0x1132DFC
	public int get_LineNumber() { }

	// RVA: 0x1132EC0
	public int get_LinePosition() { }

	// RVA: 0x1132FE4
	public int GetPositionHashCode() { }

	// RVA: 0x112F2F4
	public bool IsElementMatch(string localName, string namespaceURI) { }

	// RVA: 0x112F738
	public bool IsKindMatch(XPathNodeType typ) { }

	// RVA: 0x1131DFC
	private int GetFollowingEnd(XPathDocumentNavigator end, bool useParentOfVirtual, XPathNode[] pageEnd) { }

}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNode
{
	// Fields
	private XPathNodeInfoAtom _info; // 0x10
	private UInt16 _idxSibling; // 0x18
	private UInt16 _idxParent; // 0x1A
	private UInt16 _idxSimilar; // 0x1C
	private UInt16 _posOffset; // 0x1E
	private UInt32 _props; // 0x20
	private string _value; // 0x28

	// Methods

	// RVA: 0x112FF04
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1130128
	public string get_Prefix() { }

	// RVA: 0x112FF50
	public string get_LocalName() { }

	// RVA: 0x113006C
	public string get_Name() { }

	// RVA: 0x112FFB0
	public string get_NamespaceUri() { }

	// RVA: 0x1130310
	public XPathDocument get_Document() { }

	// RVA: 0x1130268
	public string get_BaseUri() { }

	// RVA: 0x1132E94
	public int get_LineNumber() { }

	// RVA: 0x1132FBC
	public int get_LinePosition() { }

	// RVA: 0x1132F8C
	public int get_CollapsedLinePosition() { }

	// RVA: 0x1133040
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x113147C
	public int GetRoot(XPathNode[] pageNode) { }

	// RVA: 0x1130288
	public int GetParent(XPathNode[] pageNode) { }

	// RVA: 0x1130B54
	public int GetSibling(XPathNode[] pageNode) { }

	// RVA: 0x1133060
	public int GetSimilarElement(XPathNode[] pageNode) { }

	// RVA: 0x11330A0
	public bool NameMatch(string localName, string namespaceName) { }

	// RVA: 0x1132FF0
	public bool ElementMatch(string localName, string namespaceName) { }

	// RVA: 0x1130AC8
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x11330E0
	public bool get_HasSibling() { }

	// RVA: 0x1130F4C
	public bool get_HasCollapsedText() { }

	// RVA: 0x11330F0
	public bool get_HasAttribute() { }

	// RVA: 0x11330FC
	public bool get_HasContentChild() { }

	// RVA: 0x1133108
	public bool get_HasElementChild() { }

	// RVA: 0x1133114
	public bool get_IsAttrNmsp() { }

	// RVA: 0x1133128
	public bool get_IsText() { }

	// RVA: 0x11331B8
	public bool get_HasNamespaceDecls() { }

	// RVA: 0x11331C4
	public string get_Value() { }

}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNodeRef
{
	// Fields
	private XPathNode[] _page; // 0x10
	private int _idx; // 0x18

	// Methods

	// RVA: 0x11331CC
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0x11331F8
	public XPathNode[] get_Page() { }

	// RVA: 0x1133200
	public int get_Index() { }

	// RVA: 0x1133208
	public override int GetHashCode() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathNodeHelper
{
	// Methods

	// RVA: 0x113091C
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x1130998
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x11303D4
	public static bool GetFirstAttribute(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1130468
	public static bool GetNextAttribute(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1130F58
	public static bool GetContentChild(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1130DCC
	public static bool GetContentSibling(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1131154
	public static bool GetParent(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1132D68
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x113153C
	public static bool GetElementChild(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x1131734
	public static bool GetElementSibling(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x1131968
	public static bool GetContentChild(XPathNode[] pageNode, int idxNode, XPathNodeType typ) { }

	// RVA: 0x1131AF4
	public static bool GetContentSibling(XPathNode[] pageNode, int idxNode, XPathNodeType typ) { }

	// RVA: 0x1130614
	public static bool GetAttribute(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x1131EE0
	public static bool GetElementFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName) { }

	// RVA: 0x113258C
	public static bool GetContentFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ) { }

	// RVA: 0x112FBA4
	public static bool GetTextFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x112FAB0
	public static bool GetNonDescendant(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x113324C
	private static void GetChild(XPathNode[] pageNode, int idxNode) { }

}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodePageInfo
{
	// Fields
	private int _pageNum; // 0x10
	private int _nodeCount; // 0x14
	private XPathNode[] _pageNext; // 0x18

	// Methods

	// RVA: 0x11332B8
	public int get_PageNumber() { }

	// RVA: 0x11332C0
	public int get_NodeCount() { }

	// RVA: 0x11332C8
	public XPathNode[] get_NextPage() { }

}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodeInfoAtom
{
	// Fields
	private string _localName; // 0x10
	private string _namespaceUri; // 0x18
	private string _prefix; // 0x20
	private string _baseUri; // 0x28
	private XPathNode[] _pageParent; // 0x30
	private XPathNode[] _pageSibling; // 0x38
	private XPathNode[] _pageSimilar; // 0x40
	private XPathDocument _doc; // 0x48
	private int _lineNumBase; // 0x50
	private int _linePosBase; // 0x54
	private XPathNodePageInfo _pageInfo; // 0x58

	// Methods

	// RVA: 0x11332D0
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x11332D8
	public string get_LocalName() { }

	// RVA: 0x11332E0
	public string get_NamespaceUri() { }

	// RVA: 0x11332E8
	public string get_Prefix() { }

	// RVA: 0x11332F0
	public string get_BaseUri() { }

	// RVA: 0x11332F8
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x1133300
	public XPathNode[] get_SimilarElementPage() { }

	// RVA: 0x1133308
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x1133310
	public XPathDocument get_Document() { }

	// RVA: 0x1133318
	public int get_LineNumberBase() { }

	// RVA: 0x1133320
	public int get_LinePositionBase() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=6
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=12
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
private struct __StaticArrayInitTypeSize=32
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=36
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=38
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=40
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=44
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=56
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=64
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=68
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=112
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=144
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=416
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=664
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=960
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=1212
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=68 0C682AB2EF0F1E326972C95528BBDE965F5D2DA9232E7A946F6E8A978A2871B5; // 0x0
	internal static readonly __StaticArrayInitTypeSize=12 11047585FE102FBB5CADB42446612A578D88C6EF5ED076BB7AC360C4F9E4373D; // 0x44
	internal static readonly __StaticArrayInitTypeSize=960 21AFB7EF8B4B88C006C54601484BC15AE5A8DBD2C0DD8C6622109208F8511B82; // 0x50
	internal static readonly __StaticArrayInitTypeSize=40 24F70FC64555D9B7646AD4C0EEB8DF5286779F0E39C15ACA61305BC4A5E40BE6; // 0x410
	internal static readonly __StaticArrayInitTypeSize=144 28045F5AB2D9A9593F1D95B0FCB77E7F5F5435DD654BAFEF68972344B51C71BD; // 0x438
	internal static readonly __StaticArrayInitTypeSize=112 28057B619BAF672A05E1585ED28F174E67FE946D81BDAA0691F07AB772057B02; // 0x4C8
	internal static readonly __StaticArrayInitTypeSize=1212 2809A17B374DF1926EA539548F5B3750AA8ADB2BD59F5066AD6F9D439A231122; // 0x538
	internal static readonly __StaticArrayInitTypeSize=20 2AE470BFECE0EB971895252403237B3B989F74AD83E2B858E9CEA0482E776123; // 0x9F4
	internal static readonly __StaticArrayInitTypeSize=40 2BA62518D59E3AF30E09E458218C4A05E5DFA2949B8B8F9B5E68CC793DBFA882; // 0xA08
	internal static readonly __StaticArrayInitTypeSize=36 2D902EC9D8EA71E1193C1C8315B1553D5154744F651BD366F1E1F437F6594A94; // 0xA30
	internal static readonly __StaticArrayInitTypeSize=12 3B3045573362001FA1CDA1F381A331DB2A88DD59FDD9C497404D59995AA377EA; // 0xA54
	internal static readonly __StaticArrayInitTypeSize=24 3EB9B3AB77D567D5CEBF38C4C91CDF79845F0691D47A516CE6981BF091025179; // 0xA60
	internal static readonly __StaticArrayInitTypeSize=28 499E4F5C84E20C7347E10100E0EC90C1945EA21C7C80809E4F7F474179B39DF6; // 0xA78
	internal static readonly __StaticArrayInitTypeSize=38 540CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D; // 0xA94
	internal static readonly __StaticArrayInitTypeSize=68 58E18897FE5FF048E82310FB4F57ADB2D53AEE59CB49B1E7094439808A1EF3F6; // 0xABA
	internal static readonly __StaticArrayInitTypeSize=12 5B7F03A977BE72EBD5C1702238238AEB01DFFB019B05EFAAC147EF886732EDC7; // 0xAFE
	internal static readonly __StaticArrayInitTypeSize=32 652CA39E9310E001C2C4AF271610032A5638C58598F727066CCF4E666D424CD4; // 0xB0A
	internal static readonly __StaticArrayInitTypeSize=36 6536D9B2447DFCF9BA37F9E5A7FAB08CB5552C5AD5B20E019AEC4872283A542A; // 0xB2A
	internal static readonly __StaticArrayInitTypeSize=960 77186ED8B389D5640B5AFAC4A22526ABA2422DCBE2986D0032E3B035D175758D; // 0xB4E
	internal static readonly Int64 8A36CBC1D17EC6E1CCFE7D67F79FA9C8B2D7A41B04DD58A76970CEDC8189210D; // 0xF10
	internal static readonly __StaticArrayInitTypeSize=36 8D4DC488705859D6A837A660BDBA9E88D1BD229BC39DB97734072D04BD513ECD; // 0xF18
	internal static readonly __StaticArrayInitTypeSize=32 92E9BC30656BF079FC6B0A200B019FF46941857D786F4C391470394CFDC95F0B; // 0xF3C
	internal static readonly __StaticArrayInitTypeSize=32 9DA6B2C4638D1DC7611B7F458BBFE7FD49FE1B36B67239B00B8A051F4E49558F; // 0xF5C
	internal static readonly __StaticArrayInitTypeSize=64 AD6E77E234021D825C77689D82D414CDA3ABAE1ACC346D4BA2D6B1876CFC5FBC; // 0xF7C
	internal static readonly __StaticArrayInitTypeSize=20 B21FC5E8DB69C99CDEFB2C460E7C26D2D29A5ADC302365C59766D13688236919; // 0xFBC
	internal static readonly __StaticArrayInitTypeSize=44 B6E5AC1B0927F4259775820D36453E7BD957F110874896C133234263D312D88E; // 0xFD0
	internal static readonly __StaticArrayInitTypeSize=16 C332DD23F2CF4DE6107A93045ACACD787E2D9EB18B213298B98F23357F4FEA41; // 0xFFC
	internal static readonly __StaticArrayInitTypeSize=12 C3B2BED2599F3C79640DE44BA4EC7AEBB4856DBF74059DF382CF1D3026D272DA; // 0x100C
	internal static readonly __StaticArrayInitTypeSize=416 D1D9AF18AFC4E3074AF5E4C44B81B73889D033D7AF6DFEB387BBCC76B36FE8B9; // 0x1018
	internal static readonly __StaticArrayInitTypeSize=24 DA285BBFE8FD0AA22C7CB92A1E911A4206CEDB14132FE3B6EE4DB32A42CAA41D; // 0x11B8
	internal static readonly Int64 DACC0E6568D9B10337A1A693F10D42C3175E80C378154406C6FBFA989F919F51; // 0x11D0
	internal static readonly __StaticArrayInitTypeSize=56 DB047CC748613CCCB120DE7385E37D542A79C3BF8F0E64FE6DAD349B4D26E5D7; // 0x11D8
	internal static readonly __StaticArrayInitTypeSize=416 DB7DD2341DB9D4574E432AAAFF03FB0A3E8FF2F645A337077EDF0C6FE902E660; // 0x1210
	internal static readonly __StaticArrayInitTypeSize=6 DBBF94CCF4250B303976041627BB8FC302CE57D55373C469F41F97318412037D; // 0x13B0
	internal static readonly __StaticArrayInitTypeSize=664 DD4E9C7C140CABCA5A25F4DA1F6F5BAC5D74E4568F954BF728471E711A35163E; // 0x13B6
	internal static readonly __StaticArrayInitTypeSize=16 EC3DA4AD81BE65581D24158F5E1FCDA45D908C27EC29FDFA744995062C501501; // 0x164E
	internal static readonly __StaticArrayInitTypeSize=24 EE2DCBE09BA7FF21BF36DD7FC218E094C9B3EF228148D28D21D77A0FE51553C6; // 0x165E
	internal static readonly __StaticArrayInitTypeSize=16 F1A5C5E949D525C31B086947AF16513F4999646B513457629847081D039048ED; // 0x1676
	internal static readonly __StaticArrayInitTypeSize=20 FFF813C50ED1BEC943E2CA58860CC34E0A14A5C0E858B97C7670A384005CC064; // 0x1686

	// Methods

	// RVA: 0x1133328
	internal static UInt32 ComputeStringHash(string s) { }

}


