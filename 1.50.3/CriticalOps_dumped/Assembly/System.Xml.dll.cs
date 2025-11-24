// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0x10385E8
	internal static string GetString(string name, object[] args) { }

	// RVA: 0x103865C
	internal static string GetString(CultureInfo culture, string name, object[] args) { }

	// RVA: 0x1038664
	internal static string Format(string resourceFormat, object p1) { }

}

// Namespace: Microsoft.CSharp
internal class CodeDomProvider
{
	// Methods

	// RVA: 0x10386D8
	public void .ctor() { }

}

// Namespace: Microsoft.CSharp
internal class CSharpCodeProvider
{
	// Methods

	// RVA: 0x10386E0
	public void .ctor() { }

}

// Namespace: System
internal class MonoTODOAttribute
{
	// Methods

	// RVA: 0x10386E8
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

	// RVA: 0x10386F0
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

	// RVA: 0x1038828
	internal void .ctor() { }

	// RVA: -1
	internal abstract void WriteChars(Char[] chars, int index, int count) { }

	// RVA: 0x1038898
	internal void Encode(Byte[] buffer, int index, int count) { }

	// RVA: 0x1038C3C
	internal void Flush() { }

}

// Namespace: System.Xml
internal class XmlRawWriterBase64Encoder
{
	// Fields
	private XmlRawWriter rawWriter; // 0x28

	// Methods

	// RVA: 0x1038CE8
	internal void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0x1038D6C
	internal override void WriteChars(Char[] chars, int index, int count) { }

}

// Namespace: System.Xml
internal class XmlTextWriterBase64Encoder
{
	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0x1038D94
	internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0x1038E18
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

	// RVA: 0x1038E38
	internal override bool get_IsFull() { }

	// RVA: 0x1038E48
	internal override int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0x103924C
	public static Byte[] Decode(Char[] chars, bool allowOddChars) { }

	// RVA: 0x1038FC0
	private static void Decode(Char* pChars, Char* pCharsEndPos, Byte* pBytes, Byte* pBytesEndPos, bool hasHalfByteCached, Byte cachedHalfByte, int charsDecoded, int bytesDecoded) { }

}

// Namespace: System.Xml
internal static class BinHexEncoder
{
	// Methods

	// RVA: 0x1039438
	internal static void Encode(Byte[] buffer, int index, int count, XmlWriter writer) { }

	// RVA: 0x1039744
	internal static string Encode(Byte[] inArray, int offsetIn, int count) { }

	// RVA: 0x1039608
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

	// RVA: 0x103989C
	public bool get_IsPositive() { }

	// RVA: 0x10398AC
	public void .ctor(Byte[] data, int offset, bool trim) { }

	// RVA: 0x1039B5C
	private static UInt32 UIntFromByteArray(Byte[] data, int offset) { }

	// RVA: 0x1039DB8
	private static void MpDiv1(UInt32[] rgulU, int ciulU, UInt32 iulD, UInt32 iulR) { }

	// RVA: 0x1039EF0
	private static void MpNormalize(UInt32[] rgulU, int ciulU) { }

	// RVA: 0x1039F44
	private static Char ChFromDigit(UInt32 uiDigit) { }

	// RVA: 0x1039F50
	public Decimal ToDecimal() { }

	// RVA: 0x1039BD0
	private void TrimTrailingZeros() { }

	// RVA: 0x103A078
	public override string ToString() { }

	// RVA: 0x103A590
	private static void .cctor() { }

}

// Namespace: System.Xml
internal struct BinXmlSqlMoney
{
	// Fields
	private Int64 data; // 0x10

	// Methods

	// RVA: 0x103A6D8
	public void .ctor(int v) { }

	// RVA: 0x103A6E4
	public void .ctor(Int64 v) { }

	// RVA: 0x103A6EC
	public Decimal ToDecimal() { }

	// RVA: 0x103A760
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

	// RVA: 0x103A87C
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x103A8EC
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x103AA48
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x103AB04
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x103AC44
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x103AE84
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x103B138
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x103B260
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x103B398
	private static void BreakDownXsdDateTime(Int64 val, int yr, int mnth, int day, int hr, int min, int sec, int ms) { }

	// RVA: 0x103B564
	private static void BreakDownXsdDate(Int64 val, int yr, int mnth, int day, bool negTimeZone, int hr, int min) { }

	// RVA: 0x103B6D0
	private static void BreakDownXsdTime(Int64 val, int hr, int min, int sec, int ms) { }

	// RVA: 0x103B7E0
	public static string XsdDateTimeToString(Int64 val) { }

	// RVA: 0x103B8F8
	public static string XsdDateToString(Int64 val) { }

	// RVA: 0x103B9E8
	public static string XsdTimeToString(Int64 val) { }

	// RVA: 0x103BBB0
	public static string SqlDateTimeToString(int dateticks, UInt32 timeticks) { }

	// RVA: 0x103BD08
	public static DateTime SqlDateTimeToDateTime(int dateticks, UInt32 timeticks) { }

	// RVA: 0x103BE08
	public static string SqlSmallDateTimeToString(Int16 dateticks, UInt16 timeticks) { }

	// RVA: 0x103BF68
	public static DateTime SqlSmallDateTimeToDateTime(Int16 dateticks, UInt16 timeticks) { }

	// RVA: 0x103BFDC
	public static DateTime XsdKatmaiDateToDateTime(Byte[] data, int offset) { }

	// RVA: 0x103C13C
	public static DateTime XsdKatmaiDateTimeToDateTime(Byte[] data, int offset) { }

	// RVA: 0x103C46C
	public static DateTime XsdKatmaiTimeToDateTime(Byte[] data, int offset) { }

	// RVA: 0x103C4F8
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x103C584
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x103C720
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x103C7AC
	public static string XsdKatmaiDateToString(Byte[] data, int offset) { }

	// RVA: 0x103C8D4
	public static string XsdKatmaiDateTimeToString(Byte[] data, int offset) { }

	// RVA: 0x103CB74
	public static string XsdKatmaiTimeToString(Byte[] data, int offset) { }

	// RVA: 0x103CCF8
	public static string XsdKatmaiDateOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x103CE84
	public static string XsdKatmaiDateTimeOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x103D168
	public static string XsdKatmaiTimeOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x103C0C4
	private static Int64 GetKatmaiDateTicks(Byte[] data, int pos) { }

	// RVA: 0x103C240
	private static Int64 GetKatmaiTimeTicks(Byte[] data, int pos) { }

	// RVA: 0x103C6C8
	private static Int64 GetKatmaiTimeZoneTicks(Byte[] data, int pos) { }

	// RVA: 0x103CA5C
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x103D024
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x103D304
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

	// RVA: 0x1043EE0
	public void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0x1042718
	public void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0x103DAD0
	public void Clear() { }

	// RVA: 0x1043694
	public bool MatchNs(string lname, string nsUri) { }

	// RVA: 0x10436E4
	public bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0x1043AE0
	public void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0x10481DC
	public override int GetHashCode() { }

	// RVA: 0x104822C
	public int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0x1048284
	public override bool Equals(object other) { }

	// RVA: 0x1045044
	public override string ToString() { }

	// RVA: 0x1048340
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

	// RVA: 0x1046568
	public void Set(QName name, bool xmlspacePreserve) { }

	// RVA: 0x10452EC
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

	// RVA: 0x1043F30
	public void Set(QName n, string v) { }

	// RVA: 0x10445B0
	public void Set(QName n, int pos) { }

	// RVA: 0x1044FB4
	public void GetLocalnameAndNamespaceUri(string localname, string namespaceUri) { }

	// RVA: 0x10450B8
	public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, string localname, string namespaceUri) { }

	// RVA: 0x1044FF4
	public bool MatchNS(string localname, string namespaceUri) { }

	// RVA: 0x1045138
	public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

	// RVA: 0x1042CB0
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

	// RVA: 0x1042114
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

	// RVA: 0x103D9EC
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

	// RVA: 0x10465B8
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

	// RVA: 0x103D3CC
	public void .ctor(Stream stream, Byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0x103E8A4
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x103E9CC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x103E9D4
	public override string get_LocalName() { }

	// RVA: 0x103E9DC
	public override string get_NamespaceURI() { }

	// RVA: 0x103E9E4
	public override string get_Prefix() { }

	// RVA: 0x103E9EC
	public override string get_Value() { }

	// RVA: 0x103F904
	public override int get_Depth() { }

	// RVA: 0x103F9E0
	public override string get_BaseURI() { }

	// RVA: 0x103F9E8
	public override bool get_IsEmptyElement() { }

	// RVA: 0x103FA0C
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x103FA94
	public override string get_XmlLang() { }

	// RVA: 0x103FB5C
	public override Type get_ValueType() { }

	// RVA: 0x103FB64
	public override int get_AttributeCount() { }

	// RVA: 0x103FBC0
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0x103FE34
	public override string GetAttribute(string name) { }

	// RVA: 0x103FFBC
	public override string GetAttribute(int i) { }

	// RVA: 0x104005C
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1040200
	public override void MoveToAttribute(int i) { }

	// RVA: 0x10402B4
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1040348
	public override bool MoveToNextAttribute() { }

	// RVA: 0x10403E0
	public override bool MoveToElement() { }

	// RVA: 0x10404D0
	public override bool get_EOF() { }

	// RVA: 0x10404E0
	public override bool ReadAttributeValue() { }

	// RVA: 0x10409D8
	public override void Close() { }

	// RVA: 0x1040A7C
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1040A84
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1040B60
	public override void ResolveEntity() { }

	// RVA: 0x1040BA0
	public override ReadState get_ReadState() { }

	// RVA: 0x1040C44
	public override bool Read() { }

	// RVA: 0x1041A18
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1041E58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1042030
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0x103DB54
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0x10421B0
	private void AddName() { }

	// RVA: 0x10423A8
	private void AddQName() { }

	// RVA: 0x1042768
	private void NameFlush() { }

	// RVA: 0x10427C4
	private void SkipExtn() { }

	// RVA: 0x10429A0
	private int ReadQNameRef() { }

	// RVA: 0x1042670
	private int ReadNameRef() { }

	// RVA: 0x1042A48
	private bool FillAllowEOF() { }

	// RVA: 0x1042CC4
	private void Fill_(int require) { }

	// RVA: 0x1042910
	private void Fill(int require) { }

	// RVA: 0x1042DB8
	private Byte ReadByte() { }

	// RVA: 0x1042E68
	private UInt16 ReadUShort() { }

	// RVA: 0x10428D4
	private int ParseMB32() { }

	// RVA: 0x1042F38
	private int ParseMB32_(Byte b) { }

	// RVA: 0x1042FE0
	private int ParseMB32(int pos) { }

	// RVA: 0x10430E8
	private int ParseMB64() { }

	// RVA: 0x1043124
	private BinXmlToken PeekToken() { }

	// RVA: 0x10431A0
	private BinXmlToken ReadToken() { }

	// RVA: 0x1043224
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0x1043330
	private BinXmlToken NextToken1() { }

	// RVA: 0x1043420
	private BinXmlToken NextToken() { }

	// RVA: 0x1043488
	private BinXmlToken PeekNextToken() { }

	// RVA: 0x10406F8
	private BinXmlToken RescanNextToken() { }

	// RVA: 0x10422DC
	private string ParseText() { }

	// RVA: 0x1043508
	private int ScanText(int start) { }

	// RVA: 0x103EB4C
	private string GetString(int pos, int cch) { }

	// RVA: 0x1043654
	private string GetStringAligned(Byte[] data, int offset, int cch) { }

	// RVA: 0x103F7A0
	private string GetAttributeText(int i) { }

	// RVA: 0x103FD6C
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0x103FEB4
	private int LocateAttribute(string name) { }

	// RVA: 0x1040114
	private void PositionOnAttribute(int i) { }

	// RVA: 0x1043730
	private void GrowElements() { }

	// RVA: 0x10437C0
	private void GrowAttributes() { }

	// RVA: 0x1043858
	private void ClearAttributes() { }

	// RVA: 0x1043868
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0x1043BDC
	private void PopNamespaces(NamespaceDecl firstInScopeChain) { }

	// RVA: 0x1043CB4
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0x1040E34
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0x1043F80
	private void ScanAttributes() { }

	// RVA: 0x10449CC
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0x1044B64
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0x103EE80
	private string XmlDeclValue() { }

	// RVA: 0x103ECBC
	private string CDATAValue() { }

	// RVA: 0x1045194
	private void FinishCDATA() { }

	// RVA: 0x1045280
	private void FinishEndElement() { }

	// RVA: 0x104146C
	private bool ReadDoc() { }

	// RVA: 0x1046314
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0x1045318
	private void ImplReadElement() { }

	// RVA: 0x1045694
	private void ImplReadEndElement() { }

	// RVA: 0x1045778
	private void ImplReadDoctype() { }

	// RVA: 0x1045B80
	private void ImplReadPI() { }

	// RVA: 0x1045BF0
	private void ImplReadComment() { }

	// RVA: 0x1045C28
	private void ImplReadCDATA() { }

	// RVA: 0x1045CB4
	private void ImplReadNest() { }

	// RVA: 0x1045DCC
	private void ImplReadEndNest() { }

	// RVA: 0x1045E28
	private void ImplReadXmlText() { }

	// RVA: 0x1046614
	private void UpdateFromTextReader() { }

	// RVA: 0x10400EC
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0x10464EC
	private void CheckAllowContent() { }

	// RVA: 0x103DC74
	private void GenerateTokenTypeMap() { }

	// RVA: 0x10408CC
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0x10408C0
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0x10446F0
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x1046994
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x10466EC
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0x10468F0
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0x1046ED8
	private void CheckValueTokenBounds() { }

	// RVA: 0x1046D80
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0x1046F44
	private int XsdKatmaiTimeScaleToValueLength(Byte scale) { }

	// RVA: 0x1047018
	private Int64 ValueAsLong() { }

	// RVA: 0x1047998
	private UInt64 ValueAsULong() { }

	// RVA: 0x1047750
	private Decimal ValueAsDecimal() { }

	// RVA: 0x10475D8
	private Double ValueAsDouble() { }

	// RVA: 0x1047B84
	private string ValueAsDateTimeString() { }

	// RVA: 0x103F038
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0x10472A8
	private Int16 GetInt16(int pos) { }

	// RVA: 0x1047440
	private UInt16 GetUInt16(int pos) { }

	// RVA: 0x10472F4
	private int GetInt32(int pos) { }

	// RVA: 0x104748C
	private UInt32 GetUInt32(int pos) { }

	// RVA: 0x104736C
	private Int64 GetInt64(int pos) { }

	// RVA: 0x1047504
	private UInt64 GetUInt64(int pos) { }

	// RVA: 0x1047A30
	private float GetSingle(int offset) { }

	// RVA: 0x1047AAC
	private Double GetDouble(int offset) { }

	// RVA: 0x1042074
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0x1042D40
	private Exception ThrowXmlException(string res) { }

	// RVA: 0x1044600
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0x1044948
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0x1048028
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

	// RVA: 0x10483A4
	public void .ctor() { }

	// RVA: 0x10483D0
	public void PushBit(bool bit) { }

	// RVA: 0x1048534
	public bool PopBit() { }

	// RVA: 0x10485DC
	public bool PeekBit() { }

	// RVA: 0x1048420
	private void PushCurr() { }

	// RVA: 0x1048594
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

	// RVA: 0x10485E8
	public static int Count(UInt32 num) { }

	// RVA: 0x1048690
	public static int LeastPosition(UInt32 num) { }

	// RVA: 0x10487AC
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

	// RVA: 0x1048808
	public void .ctor(int growthRate) { }

	// RVA: 0x1048888
	public void Push(Byte data) { }

	// RVA: 0x1048988
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

	// RVA: 0x10489D8
	internal void .ctor() { }

	// RVA: 0x10489E0
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x1048B6C
	public override int get_MaxCharCount() { }

	// RVA: 0x1048B74
	internal void set_StartOffset(int value) { }

	// RVA: 0x1048B7C
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x1048BAC
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

	// RVA: 0x1048AE4
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x1048C38
	public override bool Fallback(Char charUnknown, int index) { }

	// RVA: 0x1048EA0
	public override bool Fallback(Char charUnknownHigh, Char charUnknownLow, int index) { }

	// RVA: 0x10491CC
	public override Char GetNextChar() { }

	// RVA: 0x1049228
	public override bool MovePrevious() { }

	// RVA: 0x1049244
	public override int get_Remaining() { }

	// RVA: 0x1049280
	public override void Reset() { }

	// RVA: 0x10491C0
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

	// RVA: 0x104928C
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x10494C0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x10494F0
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x10494F4
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x10494F8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1049788
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x10498C0
	internal override void StartElementContent() { }

	// RVA: 0x1049A40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1049B80
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1049CC0
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1049E4C
	public override void WriteEndAttribute() { }

	// RVA: 0x1049F90
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x104A0D4
	public override void WriteString(string text) { }

	// RVA: 0x104A224
	public override void WriteEntityRef(string name) { }

	// RVA: 0x104A280
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x104A2DC
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x104A338
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x10492BC
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1049918
	protected void WriteMetaElement() { }

	// RVA: 0x104A20C
	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x104A1C8
	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x104A71C
	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x104A3CC
	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1049EF8
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

	// RVA: 0x104A970
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x104AA0C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x104AA64
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x104AA8C
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x104AD14
	internal override void StartElementContent() { }

	// RVA: 0x104ADCC
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x104AEBC
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x104AF70
	protected override void FlushBuffer() { }

	// RVA: 0x104A9C8
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x104ACC0
	private void WriteIndent() { }

}

// Namespace: System.Xml
internal abstract class HtmlTernaryTree
{
	// Fields
	internal static Byte[] htmlElements; // 0x0
	internal static Byte[] htmlAttributes; // 0x8

	// Methods

	// RVA: 0x104AFA0
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

	// RVA: 0x104B090
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x104B2C4
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x104B2C8
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x104B2CC
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x104B56C
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x104B684
	internal override void StartElementContent() { }

	// RVA: 0x104B808
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x104B930
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x104BA58
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x104BBD4
	public override void WriteEndAttribute() { }

	// RVA: 0x104BD14
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x104BE38
	public override void WriteString(string text) { }

	// RVA: 0x104BF68
	public override void WriteEntityRef(string name) { }

	// RVA: 0x104BFC4
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x104C020
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x104C07C
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x104B0C0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x104B6E0
	protected void WriteMetaElement() { }

	// RVA: 0x104BF50
	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x104BF0C
	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x104C3FC
	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x104C0C4
	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x104BC4C
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

	// RVA: 0x114C8DC
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x114C96C
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x114C998
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x114CD64
	internal override void StartElementContent() { }

	// RVA: 0x114CE24
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x114CF1C
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x114CFD4
	protected override void FlushBuffer() { }

	// RVA: 0x114C928
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x114CD10
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

	// RVA: 0x114D004
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x114D124
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

	// RVA: 0x114D138
	protected void .ctor() { }

}

// Namespace: System.Xml
internal class IncrementalReadDummyDecoder
{
	// Methods

	// RVA: 0x114D140
	internal override bool get_IsFull() { }

	// RVA: 0x114D148
	internal override int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0x114D150
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

	// RVA: 0x114D158
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x114D508
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x114D550
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x114D578
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x114D5A0
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x114D5DC
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x114D7B4
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x114D824
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x114D894
	internal override void StartElementContent() { }

	// RVA: 0x114D8BC
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x114D8E8
	public override void WriteEndAttribute() { }

	// RVA: 0x114D914
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x114D93C
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x114D964
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x114D98C
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x114D9B4
	public override void WriteCData(string text) { }

	// RVA: 0x114D9DC
	public override void WriteComment(string text) { }

	// RVA: 0x114DA08
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x114DA34
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x114DB24
	public override void WriteString(string text) { }

	// RVA: 0x114DBC0
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x114DC90
	public override void WriteEntityRef(string name) { }

	// RVA: 0x114DCBC
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x114DCE8
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x114DD14
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x114DDE4
	public override void WriteRaw(string data) { }

	// RVA: 0x114DE80
	public override void Close() { }

	// RVA: 0x114DF28
	public override void Flush() { }

	// RVA: 0x114DAD0
	private bool StartCDataSection() { }

	// RVA: 0x114D7AC
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

	// RVA: 0x114DF50
	internal void Finish() { }

	// RVA: 0x114E224
	internal void Reset() { }

	// RVA: 0x114E09C
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

	// RVA: 0x114E230
	public void .ctor(Byte[] nodeBuffer) { }

	// RVA: 0x114CBAC
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

	// RVA: 0x114E608
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x114E6C4
	public virtual int Invoke(string s, int sLen, Int64 additionalEntropy) { }

}

// Namespace: System.Xml
internal class SecureStringHasher
{
	// Fields
	private static HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x114E264
	public void .ctor() { }

	// RVA: 0x114E294
	public bool Equals(string x, string y) { }

	// RVA: 0x114E2A8
	public int GetHashCode(string key) { }

	// RVA: 0x114E594
	private static int GetHashCodeOfString(string key, int sLen, Int64 additionalEntropy) { }

	// RVA: 0x114E370
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

}

// Namespace: System.Xml
internal class TextEncodedRawTextWriter
{
	// Methods

	// RVA: 0x114E6D8
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x114E7DC
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x114EB0C
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x114EB10
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x114EB14
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x114EB18
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x114EB1C
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x114EB20
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x114EB24
	internal override void StartElementContent() { }

	// RVA: 0x114EB28
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x114EB34
	public override void WriteEndAttribute() { }

	// RVA: 0x114EB3C
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x114EB40
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x114EB48
	public override void WriteCData(string text) { }

	// RVA: 0x114EC08
	public override void WriteComment(string text) { }

	// RVA: 0x114EC0C
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x114EC10
	public override void WriteEntityRef(string name) { }

	// RVA: 0x114EC14
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x114EC18
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x114EC1C
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x114EC2C
	public override void WriteString(string textBlock) { }

	// RVA: 0x114EC3C
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x114ED1C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x114ED2C
	public override void WriteRaw(string data) { }

}

// Namespace: System.Xml
internal class TextUtf8RawTextWriter
{
	// Methods

	// RVA: 0x114ED3C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x114ED44
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x114ED48
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x114ED4C
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x114ED50
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x114ED54
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x114ED58
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x114ED5C
	internal override void StartElementContent() { }

	// RVA: 0x114ED60
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x114ED6C
	public override void WriteEndAttribute() { }

	// RVA: 0x114ED74
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x114ED78
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x114ED80
	public override void WriteCData(string text) { }

	// RVA: 0x114ED88
	public override void WriteComment(string text) { }

	// RVA: 0x114ED8C
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x114ED90
	public override void WriteEntityRef(string name) { }

	// RVA: 0x114ED94
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x114ED98
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x114ED9C
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x114EDB0
	public override void WriteString(string textBlock) { }

	// RVA: 0x114EDC4
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x114EDD8
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x114EDEC
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

	// RVA: 0x114EE00
	public void .ctor() { }

	// RVA: 0x114EF08
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x114EF38
	public string get_LocalName() { }

	// RVA: 0x114EF40
	public void set_LocalName(string value) { }

	// RVA: 0x114EF48
	public string get_Namespace() { }

	// RVA: 0x114EF50
	public void set_Namespace(string value) { }

	// RVA: 0x114EF58
	public string get_Prefix() { }

	// RVA: 0x114EF60
	public void set_Prefix(string value) { }

	// RVA: 0x114EF68
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x114F02C
	public int get_Depth() { }

	// RVA: 0x114F034
	public void set_Depth(int value) { }

	// RVA: 0x114F03C
	public string get_RawValue() { }

	// RVA: 0x114F044
	public void set_RawValue(string value) { }

	// RVA: 0x114F04C
	public string get_OriginalStringValue() { }

	// RVA: 0x114F054
	public XmlNodeType get_NodeType() { }

	// RVA: 0x114F05C
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x114F064
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x114F06C
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x114F074
	public int get_LineNumber() { }

	// RVA: 0x114F07C
	public int get_LinePosition() { }

	// RVA: 0x114EE2C
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0x114F084
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x114F08C
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0x114F1A0
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0x114F254
	internal void SetItemData(string value) { }

	// RVA: 0x114F288
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

	// RVA: 0x114F2BC
	internal XmlReader get_CoreReader() { }

	// RVA: 0x114F2C4
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0x114F77C
	public void .ctor(XmlReader reader) { }

	// RVA: 0x114F838
	private void CheckAsync() { }

	// RVA: 0x114F8B8
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x114FAD0
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x114FB04
	public override string get_Name() { }

	// RVA: 0x114FB38
	public override string get_LocalName() { }

	// RVA: 0x114FB6C
	public override string get_NamespaceURI() { }

	// RVA: 0x114FBA0
	public override string get_Prefix() { }

	// RVA: 0x114FBD4
	public override string get_Value() { }

	// RVA: 0x114FC08
	public override int get_Depth() { }

	// RVA: 0x114FC3C
	public override string get_BaseURI() { }

	// RVA: 0x114FC74
	public override bool get_IsEmptyElement() { }

	// RVA: 0x114FCAC
	public override bool get_IsDefault() { }

	// RVA: 0x114FCE4
	public override Char get_QuoteChar() { }

	// RVA: 0x114FD1C
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x114FD54
	public override string get_XmlLang() { }

	// RVA: 0x114FD8C
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x114FDC4
	public override Type get_ValueType() { }

	// RVA: 0x114FDFC
	public override int get_AttributeCount() { }

	// RVA: 0x114FE34
	public override string GetAttribute(string name) { }

	// RVA: 0x114FE74
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x114FEC4
	public override string GetAttribute(int i) { }

	// RVA: 0x114FF04
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x114FF44
	public override void MoveToAttribute(int i) { }

	// RVA: 0x114FF84
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x114FFBC
	public override bool MoveToNextAttribute() { }

	// RVA: 0x114FFF4
	public override bool MoveToElement() { }

	// RVA: 0x115002C
	public override bool ReadAttributeValue() { }

	// RVA: 0x1150064
	public override bool Read() { }

	// RVA: 0x115009C
	public override bool get_EOF() { }

	// RVA: 0x11500D4
	public override void Close() { }

	// RVA: 0x115010C
	public override ReadState get_ReadState() { }

	// RVA: 0x1150144
	public override void Skip() { }

	// RVA: 0x115017C
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x11501B4
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11501F4
	public override bool get_CanResolveEntity() { }

	// RVA: 0x115022C
	public override void ResolveEntity() { }

	// RVA: 0x1150264
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x115029C
	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x11502F4
	public override string ReadString() { }

	// RVA: 0x115032C
	public override XmlNodeType MoveToContent() { }

	// RVA: 0x1150364
	public override void ReadStartElement() { }

	// RVA: 0x115039C
	public override string ReadElementString() { }

	// RVA: 0x11503D4
	public override void ReadEndElement() { }

	// RVA: 0x115040C
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0x115045C
	public override string ReadInnerXml() { }

	// RVA: 0x1150494
	public override bool get_HasAttributes() { }

	// RVA: 0x11504CC
	protected override void Dispose(bool disposing) { }

	// RVA: 0x115051C
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1150554
	internal override IDtdInfo get_DtdInfo() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithNS
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0x114F6C0
	public void .ctor(XmlReader reader) { }

	// RVA: 0x115058C
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1150640
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11506F8
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfo
{
	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Methods

	// RVA: 0x114F604
	public void .ctor(XmlReader reader) { }

	// RVA: 0x11507B0
	public virtual bool HasLineInfo() { }

	// RVA: 0x1150864
	public virtual int get_LineNumber() { }

	// RVA: 0x115091C
	public virtual int get_LinePosition() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNS
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0x114F548
	public void .ctor(XmlReader reader) { }

	// RVA: 0x11509D4
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1150A88
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1150B40
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNSSchema
{
	// Fields
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; // 0x30

	// Methods

	// RVA: 0x114F48C
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1150BF8
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1150CAC
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1150D64
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x1150E1C
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x1150ED4
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x1150F8C
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x1151044
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckWriter
{
	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Methods

	// RVA: 0x11510FC
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x115118C
	private void CheckAsync() { }

	// RVA: 0x115120C
	public override void WriteStartDocument() { }

	// RVA: 0x1151240
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x115127C
	public override void WriteEndDocument() { }

	// RVA: 0x11512B0
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1151314
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1151368
	public override void WriteEndElement() { }

	// RVA: 0x115139C
	public override void WriteFullEndElement() { }

	// RVA: 0x11513D0
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1151424
	public override void WriteEndAttribute() { }

	// RVA: 0x115145C
	public override void WriteCData(string text) { }

	// RVA: 0x115149C
	public override void WriteComment(string text) { }

	// RVA: 0x11514DC
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x115152C
	public override void WriteEntityRef(string name) { }

	// RVA: 0x115156C
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x11515AC
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11515EC
	public override void WriteString(string text) { }

	// RVA: 0x115162C
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x115167C
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11516D4
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x115172C
	public override void WriteRaw(string data) { }

	// RVA: 0x115176C
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x11517C4
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x115181C
	public override WriteState get_WriteState() { }

	// RVA: 0x1151854
	public override void Close() { }

	// RVA: 0x115188C
	public override void Flush() { }

	// RVA: 0x11518C4
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1151904
	public override void WriteValue(string value) { }

	// RVA: 0x1151944
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1151994
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x11519E4
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

	// RVA: 0x1151A14
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0x1151B44
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0x1151B78
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0x1151BAC
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1151C30
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1151F38
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1151F9C
	public override void WriteEndAttribute() { }

	// RVA: 0x1151FC4
	public override void WriteCData(string text) { }

	// RVA: 0x11520B8
	public override void WriteComment(string text) { }

	// RVA: 0x11520EC
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1152120
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1152154
	public override void WriteString(string text) { }

	// RVA: 0x11521D4
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1152210
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x115224C
	public override void WriteRaw(string data) { }

	// RVA: 0x11522CC
	public override void WriteEntityRef(string name) { }

	// RVA: 0x115231C
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x115236C
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11523CC
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1152434
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x115249C
	public override void Close() { }

	// RVA: 0x11524E4
	public override void Flush() { }

	// RVA: 0x115252C
	public override void WriteValue(string value) { }

	// RVA: 0x115257C
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x11525D8
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1152628
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1152678
	internal override void StartElementContent() { }

	// RVA: 0x11526A0
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11526C8
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11526F0
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1152750
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1152778
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x11527C8
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1151CB4
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0x1151C20
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0x1152044
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0x1151DC0
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

	// RVA: 0x1152F7C
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x114E6DC
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x114E7E0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11533A8
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11536E0
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1153768
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1153A98
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1153BE0
	internal override void StartElementContent() { }

	// RVA: 0x1153C28
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1153E18
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1153FA0
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1154140
	public override void WriteEndAttribute() { }

	// RVA: 0x1154204
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x115425C
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1154264
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x115448C
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1154550
	public override void WriteCData(string text) { }

	// RVA: 0x1154B2C
	public override void WriteComment(string text) { }

	// RVA: 0x1155070
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x115520C
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1155340
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1155570
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1155C1C
	public override void WriteString(string text) { }

	// RVA: 0x1155CE8
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1155EA0
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x114EC4C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x114EB4C
	public override void WriteRaw(string data) { }

	// RVA: 0x1156224
	public override void Close() { }

	// RVA: 0x1156354
	public override void Flush() { }

	// RVA: 0x11563C4
	protected virtual void FlushBuffer() { }

	// RVA: 0x1156608
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x11562AC
	private void FlushEncoder() { }

	// RVA: 0x1155638
	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1155918
	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x11536A0
	protected void RawText(string s) { }

	// RVA: 0x1156B38
	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x1155F80
	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x1154CAC
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1154784
	protected void WriteCDataSection(string text) { }

	// RVA: 0x1156834
	private static Char* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	// RVA: 0x1156990
	private Char* InvalidXmlChar(int ch, Char* pDst, bool entitize) { }

	// RVA: 0x1156DD8
	internal void EncodeChar(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	// RVA: 0x1153624
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x1156EB0
	private void GrowTextContentMarks() { }

	// RVA: 0x1156AB4
	protected Char* WriteNewLine(Char* pDst) { }

	// RVA: 0x1156770
	protected static Char* LtEntity(Char* pDst) { }

	// RVA: 0x1156788
	protected static Char* GtEntity(Char* pDst) { }

	// RVA: 0x115674C
	protected static Char* AmpEntity(Char* pDst) { }

	// RVA: 0x11567A0
	protected static Char* QuoteEntity(Char* pDst) { }

	// RVA: 0x11567C8
	protected static Char* TabEntity(Char* pDst) { }

	// RVA: 0x1156810
	protected static Char* LineFeedEntity(Char* pDst) { }

	// RVA: 0x11567EC
	protected static Char* CarriageReturnEntity(Char* pDst) { }

	// RVA: 0x1156D1C
	private static Char* CharEntity(Char* pDst, Char ch) { }

	// RVA: 0x1156CE8
	protected static Char* RawStartCData(Char* pDst) { }

	// RVA: 0x1156CCC
	protected static Char* RawEndCData(Char* pDst) { }

	// RVA: 0x1153088
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

	// RVA: 0x1156F38
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1157084
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11570B0
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11571A8
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1157220
	internal override void StartElementContent() { }

	// RVA: 0x11572A8
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x11572B0
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1157338
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11573C0
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1157408
	public override void WriteCData(string text) { }

	// RVA: 0x1157414
	public override void WriteComment(string text) { }

	// RVA: 0x115746C
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x11574C0
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11574CC
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x11574D8
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11574E4
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11574F0
	public override void WriteString(string text) { }

	// RVA: 0x11574FC
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1157508
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1157514
	public override void WriteRaw(string data) { }

	// RVA: 0x1157520
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1156F64
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x115711C
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

	// RVA: 0x11589B8
	public void InitEvent(XmlEventType eventType) { }

	// RVA: 0x1158898
	public void InitEvent(XmlEventType eventType, string s1) { }

	// RVA: 0x11588A8
	public void InitEvent(XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x11588E4
	public void InitEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x115893C
	public void InitEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x11589A8
	public void InitEvent(XmlEventType eventType, object o) { }

	// RVA: 0x11589C0
	public XmlEventType get_EventType() { }

	// RVA: 0x11589C8
	public string get_String1() { }

	// RVA: 0x11589D0
	public string get_String2() { }

	// RVA: 0x11589D8
	public string get_String3() { }

	// RVA: 0x11589E0
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

	// RVA: 0x1151AFC
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x11527F0
	public void EndEvents() { }

	// RVA: 0x115284C
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x11576D0
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1157790
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11578B0
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x115793C
	public override void WriteEndAttribute() { }

	// RVA: 0x1157988
	public override void WriteCData(string text) { }

	// RVA: 0x1157A40
	public override void WriteComment(string text) { }

	// RVA: 0x1157A98
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1157B88
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1157BE0
	public override void WriteString(string text) { }

	// RVA: 0x1157C5C
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1157C98
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1157CD4
	public override void WriteRaw(string data) { }

	// RVA: 0x1157D2C
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1157D84
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1157E90
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1157F54
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1158104
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x11581FC
	public override void Close() { }

	// RVA: 0x1158248
	public override void Flush() { }

	// RVA: 0x1158294
	public override void WriteValue(string value) { }

	// RVA: 0x11582A4
	protected override void Dispose(bool disposing) { }

	// RVA: 0x11583B0
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x115845C
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11584B4
	internal override void StartElementContent() { }

	// RVA: 0x1158500
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x115858C
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1158618
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1158690
	internal override void WriteEndBase64() { }

	// RVA: 0x1157684
	private void AddEvent(XmlEventType eventType) { }

	// RVA: 0x11579E0
	private void AddEvent(XmlEventType eventType, string s1) { }

	// RVA: 0x1157B10
	private void AddEvent(XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x115781C
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x11576E8
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1157E30
	private void AddEvent(XmlEventType eventType, object o) { }

	// RVA: 0x11586DC
	private int NewEvent() { }

	// RVA: 0x115804C
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

	// RVA: 0x11589E8
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x1158A94
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x1158AC4
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x1158E14
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1158E1C
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1158E24
	public string get_DocTypeName() { }

	// RVA: 0x1158E2C
	public string get_PublicId() { }

	// RVA: 0x1158E34
	public string get_SystemId() { }

	// RVA: 0x1158E3C
	public string get_BaseURI() { }

	// RVA: 0x1158E44
	public string get_InternalSubset() { }

	// RVA: 0x1158E4C
	public string get_XmlLang() { }

	// RVA: 0x1158E54
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x1158E5C
	public Encoding get_Encoding() { }

	// RVA: 0x1158E64
	internal bool get_HasDtdInfo() { }

}

// Namespace: System.Xml
internal abstract class XmlRawWriter
{
	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Methods

	// RVA: 0x1158F10
	public override void WriteStartDocument() { }

	// RVA: 0x1158F6C
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1158FC8
	public override void WriteEndDocument() { }

	// RVA: 0x1159024
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1159028
	public override void WriteEndElement() { }

	// RVA: 0x1159084
	public override void WriteFullEndElement() { }

	// RVA: 0x11575D4
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x11590E0
	public override string LookupPrefix(string ns) { }

	// RVA: 0x115913C
	public override WriteState get_WriteState() { }

	// RVA: 0x1159198
	public override void WriteCData(string text) { }

	// RVA: 0x11591A8
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1159240
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11592F0
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1159300
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x115933C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1159378
	public override void WriteRaw(string data) { }

	// RVA: 0x1159388
	public override void WriteValue(string value) { }

	// RVA: 0x1159398
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x11593F4
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1159450
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1159458
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x115945C
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	// RVA: -1
	internal abstract void StartElementContent() { }

	// RVA: 0x1159460
	internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: -1
	internal abstract void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1159464
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1159474
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x115947C
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x11594BC
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0x11594FC
	internal virtual void WriteEndBase64() { }

	// RVA: 0x115951C
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x114D500
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

	// RVA: 0x115952C
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x1159534
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

	// RVA: 0x115961C
	public virtual bool get_IsDefault() { }

	// RVA: 0x1159624
	public virtual Char get_QuoteChar() { }

	// RVA: 0x115962C
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x1159634
	public virtual string get_XmlLang() { }

	// RVA: 0x1159680
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11596D4
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

	// RVA: 0x1159774
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

	// RVA: 0x1159840
	public virtual void Close() { }

	// RVA: -1
	public abstract ReadState get_ReadState() { }

	// RVA: 0x1159844
	public virtual void Skip() { }

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: -1
	public abstract string LookupNamespace(string prefix) { }

	// RVA: 0x1159A0C
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1
	public abstract void ResolveEntity() { }

	// RVA: 0x1159A14
	public virtual bool get_CanReadValueChunk() { }

	// RVA: 0x1159A1C
	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x1159A78
	public virtual string ReadString() { }

	// RVA: 0x1159D18
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0x1159DB8
	public virtual void ReadStartElement() { }

	// RVA: 0x1159EB0
	public virtual string ReadElementString() { }

	// RVA: 0x115A144
	public virtual void ReadEndElement() { }

	// RVA: 0x115A23C
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0x115A2CC
	public virtual string ReadInnerXml() { }

	// RVA: 0x115A760
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0x115A644
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0x115A5CC
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0x115ABC4
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0x115ACFC
	public virtual bool get_HasAttributes() { }

	// RVA: 0x1150508
	public void Dispose() { }

	// RVA: 0x115AD24
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x115AD78
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1159CA8
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0x115AD80
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0x1159934
	private bool SkipSubtree() { }

	// RVA: 0x115ADF0
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x115AEF8
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0x115AF00
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x115B160
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x115B320
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0x115B6B8
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x114F830
	protected void .ctor() { }

	// RVA: 0x115B8A4
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

	// RVA: 0x114FA44
	public void .ctor() { }

	// RVA: 0x115B90C
	public bool get_Async() { }

	// RVA: 0x114FA70
	public void set_Async(bool value) { }

	// RVA: 0x115B9CC
	public XmlNameTable get_NameTable() { }

	// RVA: 0x115B9D4
	public void set_NameTable(XmlNameTable value) { }

	// RVA: 0x115BA3C
	internal bool get_IsXmlResolverSet() { }

	// RVA: 0x115BA44
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0x115BA4C
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x115BAC0
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0x115BAC8
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x115BB0C
	public int get_LineNumberOffset() { }

	// RVA: 0x115BB14
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x115BB74
	public int get_LinePositionOffset() { }

	// RVA: 0x115BB7C
	public void set_LinePositionOffset(int value) { }

	// RVA: 0x115BBDC
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x115BBE4
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x115BC94
	public bool get_CheckCharacters() { }

	// RVA: 0x115BC9C
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x115BCFC
	public Int64 get_MaxCharactersInDocument() { }

	// RVA: 0x115BD04
	public void set_MaxCharactersInDocument(Int64 value) { }

	// RVA: 0x115BDB0
	public Int64 get_MaxCharactersFromEntities() { }

	// RVA: 0x115BDB8
	public void set_MaxCharactersFromEntities(Int64 value) { }

	// RVA: 0x115BE64
	public bool get_IgnoreWhitespace() { }

	// RVA: 0x115BE6C
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0x115BECC
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0x115BED4
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0x115BF34
	public bool get_IgnoreComments() { }

	// RVA: 0x115BF3C
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x115BF9C
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0x115BFA4
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x115C054
	public bool get_CloseInput() { }

	// RVA: 0x115C05C
	public void set_CloseInput(bool value) { }

	// RVA: 0x115C0BC
	public ValidationType get_ValidationType() { }

	// RVA: 0x115C0C4
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x115C174
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x115C17C
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0x115C22C
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0x115C2B4
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x114F9D8
	public XmlReaderSettings Clone() { }

	// RVA: 0x115C31C
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x115AF94
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x115B1F0
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x115C324
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x115B914
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x115B904
	private void Initialize() { }

	// RVA: 0x115C32C
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0x115C5AC
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x115B748
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0x115C604
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0x115C424
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

	// RVA: 0x115C688
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0x115C6DC
	internal void set_QuoteChar(Char value) { }

	// RVA: 0x115C6E4
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0x115C7A4
	internal void EndAttribute() { }

	// RVA: 0x115C7E8
	internal string get_AttributeValue() { }

	// RVA: 0x115C860
	internal void WriteSurrogateChar(Char lowChar, Char highChar) { }

	// RVA: 0x115C920
	internal void Write(Char[] array, int offset, int count) { }

	// RVA: 0x115CF80
	internal void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x115D108
	internal void Write(string text) { }

	// RVA: 0x115D768
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0x115D958
	internal void WriteRaw(Char[] array, int offset, int count) { }

	// RVA: 0x115DA9C
	internal void WriteCharEntity(Char ch) { }

	// RVA: 0x115DC84
	internal void WriteEntityRef(string name) { }

	// RVA: 0x115D6B4
	private void WriteStringFragment(string str, int offset, int count, Char[] helperBuffer) { }

	// RVA: 0x115CE88
	private void WriteCharEntityImpl(Char ch) { }

	// RVA: 0x115DBE0
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0x115CF0C
	private void WriteEntityRefImpl(string name) { }

}

// Namespace: System.Xml
public class XmlTextReader
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Methods

	// RVA: 0x115DD3C
	public void .ctor(Stream input) { }

	// RVA: 0x115DE00
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x115DEDC
	public void .ctor(TextReader input) { }

	// RVA: 0x115DFA0
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x115E074
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x115E098
	public override string get_Name() { }

	// RVA: 0x115E0BC
	public override string get_LocalName() { }

	// RVA: 0x115E0E0
	public override string get_NamespaceURI() { }

	// RVA: 0x115E104
	public override string get_Prefix() { }

	// RVA: 0x115E128
	public override string get_Value() { }

	// RVA: 0x115E14C
	public override int get_Depth() { }

	// RVA: 0x115E170
	public override string get_BaseURI() { }

	// RVA: 0x115E198
	public override bool get_IsEmptyElement() { }

	// RVA: 0x115E1C0
	public override bool get_IsDefault() { }

	// RVA: 0x115E1E8
	public override Char get_QuoteChar() { }

	// RVA: 0x115E210
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x115E238
	public override string get_XmlLang() { }

	// RVA: 0x115E260
	public override int get_AttributeCount() { }

	// RVA: 0x115E288
	public override string GetAttribute(string name) { }

	// RVA: 0x115E2B0
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x115E2D8
	public override string GetAttribute(int i) { }

	// RVA: 0x115E300
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x115E328
	public override void MoveToAttribute(int i) { }

	// RVA: 0x115E350
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x115E378
	public override bool MoveToNextAttribute() { }

	// RVA: 0x115E3A0
	public override bool MoveToElement() { }

	// RVA: 0x115E3C8
	public override bool ReadAttributeValue() { }

	// RVA: 0x115E3F0
	public override bool Read() { }

	// RVA: 0x115E418
	public override bool get_EOF() { }

	// RVA: 0x115E440
	public override void Close() { }

	// RVA: 0x115E468
	public override ReadState get_ReadState() { }

	// RVA: 0x115E490
	public override void Skip() { }

	// RVA: 0x115E4B8
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x115E4E0
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x115E51C
	public override bool get_CanResolveEntity() { }

	// RVA: 0x115E524
	public override void ResolveEntity() { }

	// RVA: 0x115E54C
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x115E554
	public override string ReadString() { }

	// RVA: 0x115E588
	public bool HasLineInfo() { }

	// RVA: 0x115E590
	public int get_LineNumber() { }

	// RVA: 0x115E5B0
	public int get_LinePosition() { }

	// RVA: 0x115E5D0
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x115E5F0
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x115E618
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x115ACDC
	public bool get_Namespaces() { }

	// RVA: 0x115E638
	public bool get_Normalization() { }

	// RVA: 0x115E658
	public void set_Normalization(bool value) { }

	// RVA: 0x115E678
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x115E698
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x115E6B8
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x115E6D8
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0x115E6E0
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x115E708
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x115E728
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

	// RVA: 0x115E750
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

	// RVA: 0x115E760
	internal void Clear() { }

	// RVA: 0x115E854
	internal void Close(bool closeInput) { }

	// RVA: 0x115E88C
	internal int get_LineNo() { }

	// RVA: 0x115E894
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

	// RVA: 0x115E8A4
	internal void .ctor() { }

	// RVA: 0x115E93C
	internal void .ctor(XmlContext previousContext) { }

}

// Namespace: 
private class NoNamespaceManager
{
	// Methods

	// RVA: 0x115E9A0
	public void .ctor() { }

	// RVA: 0x115E9A8
	public override string get_DefaultNamespace() { }

	// RVA: 0x115E9F4
	public override void PushScope() { }

	// RVA: 0x115E9F8
	public override bool PopScope() { }

	// RVA: 0x115EA00
	public override void AddNamespace(string prefix, string uri) { }

	// RVA: 0x115EA04
	public override void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x115EA08
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x115EA10
	public override System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x115EA18
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x115EA64
	public override string LookupPrefix(string uri) { }

}

// Namespace: 
internal class DtdParserProxy
{
	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Methods

	// RVA: 0x115EA6C
	internal void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x115EAA0
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x115EAC0
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x115EAE0
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x115EB00
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x115EB20
	private Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x115EB40
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x115EB60
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x115EB80
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x115EBA0
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x115EBC0
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x115EBE0
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x115EC00
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x115EC20
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x115EC40
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x115EC60
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x115EC80
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x115ECA0
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x115ECC0
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x115ECE0
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, int entityId) { }

	// RVA: 0x115ED00
	private bool System.Xml.IDtdParserAdapter.PopEntity(IDtdEntityInfo oldEntity, int newEntityId) { }

	// RVA: 0x115ED20
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x115ED40
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x115ED60
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x115ED80
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x115EDA0
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x115EDC0
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x115EDE0
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0x115EE00
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0x115EE20
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x115EE40
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

	// RVA: 0x115EE60
	internal static NodeData get_None() { }

	// RVA: 0x115EF0C
	internal void .ctor() { }

	// RVA: 0x115EFF0
	internal int get_LineNo() { }

	// RVA: 0x115EFF8
	internal int get_LinePos() { }

	// RVA: 0x115F000
	internal bool get_IsEmptyElement() { }

	// RVA: 0x115F024
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x115F02C
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0x115F050
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x115F058
	internal bool get_ValueBuffered() { }

	// RVA: 0x115F068
	internal string get_StringValue() { }

	// RVA: 0x115F0C0
	internal void TrimSpacesInValue() { }

	// RVA: 0x115EF40
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x115F11C
	internal void ClearName() { }

	// RVA: 0x115F1C4
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x115F1D0
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x115F1DC
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x115F21C
	internal void SetValueNode(XmlNodeType type, Char[] chars, int startPos, int len) { }

	// RVA: 0x115F278
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x115F2F0
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x115F3C8
	internal void SetValue(string value) { }

	// RVA: 0x115F3D8
	internal void SetValue(Char[] chars, int startPos, int len) { }

	// RVA: 0x115F428
	internal void OnBufferInvalidated() { }

	// RVA: 0x115F490
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x115F50C
	internal int CopyTo(int valueOffset, Char[] buffer, int offset, int length) { }

	// RVA: 0x115F584
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x115F598
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x115F65C
	private int System.IComparable.CompareTo(object obj) { }

}

// Namespace: 
private class DtdDefaultAttributeInfoToNodeDataComparer
{
	// Fields
	private static System.Collections.Generic.IComparer<System.Object> s_instance; // 0x0

	// Methods

	// RVA: 0x115F748
	internal static System.Collections.Generic.IComparer<System.Object> get_Instance() { }

	// RVA: 0x115F7C4
	public int Compare(object x, object y) { }

	// RVA: 0x115FB44
	public void .ctor() { }

	// RVA: 0x115FB4C
	private static void .cctor() { }

}

// Namespace: 
internal sealed class OnDefaultAttributeUseDelegate
{
	// Methods

	// RVA: 0x115FBB8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x115FCDC
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

	// RVA: 0x1057184
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0x10575D0
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0x1057D84
	internal void .ctor(Stream input) { }

	// RVA: 0x1057E20
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1057FD8
	internal void .ctor(TextReader input) { }

	// RVA: 0x105815C
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x1058074
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0x10581DC
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0x10586B0
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0x105880C
	private void FinishInitUriString() { }

	// RVA: 0x1058F4C
	internal void .ctor(Stream stream, Byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0x10592B4
	private void FinishInitStream() { }

	// RVA: 0x10593A0
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0x10594D0
	private void FinishInitTextReader() { }

	// RVA: 0x10595A0
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x1059658
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x10597D8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x10597F8
	public override string get_Name() { }

	// RVA: 0x1059820
	public override string get_LocalName() { }

	// RVA: 0x1059840
	public override string get_NamespaceURI() { }

	// RVA: 0x1059860
	public override string get_Prefix() { }

	// RVA: 0x1059880
	public override string get_Value() { }

	// RVA: 0x1059AE8
	public override int get_Depth() { }

	// RVA: 0x1059B08
	public override string get_BaseURI() { }

	// RVA: 0x1059B10
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1059B30
	public override bool get_IsDefault() { }

	// RVA: 0x1059B50
	public override Char get_QuoteChar() { }

	// RVA: 0x1059B88
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1059BA8
	public override string get_XmlLang() { }

	// RVA: 0x1059BC8
	public override ReadState get_ReadState() { }

	// RVA: 0x1059BD0
	public override bool get_EOF() { }

	// RVA: 0x1059BE0
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1059BE8
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1059BF0
	public override int get_AttributeCount() { }

	// RVA: 0x1059BF8
	public override string GetAttribute(string name) { }

	// RVA: 0x1059E54
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1059FE8
	public override string GetAttribute(int i) { }

	// RVA: 0x105A090
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x105A28C
	public override void MoveToAttribute(int i) { }

	// RVA: 0x105A354
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x105A3D8
	public override bool MoveToNextAttribute() { }

	// RVA: 0x105A484
	public override bool MoveToElement() { }

	// RVA: 0x105A528
	private void FinishInit() { }

	// RVA: 0x105A574
	public override bool Read() { }

	// RVA: 0x105CE44
	public override void Close() { }

	// RVA: 0x105CFA0
	public override void Skip() { }

	// RVA: 0x105D1CC
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x105D208
	public override bool ReadAttributeValue() { }

	// RVA: 0x105DA48
	public override void ResolveEntity() { }

	// RVA: 0x105E284
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0x105E294
	internal void MoveOffEntityReference() { }

	// RVA: 0x105E348
	public override string ReadString() { }

	// RVA: 0x105E370
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x105E378
	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x105EFB0
	public bool HasLineInfo() { }

	// RVA: 0x105EFB8
	public int get_LineNumber() { }

	// RVA: 0x105EFD8
	public int get_LinePosition() { }

	// RVA: 0x105EFF8
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x105F048
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x105F058
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x105F020
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x105F080
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x105F0A8
	internal bool get_Namespaces() { }

	// RVA: 0x105F0B0
	internal void set_Namespaces(bool value) { }

	// RVA: 0x105F2C8
	internal bool get_Normalization() { }

	// RVA: 0x105F2D0
	internal void set_Normalization(bool value) { }

	// RVA: 0x105F400
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x105F4E0
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x105F568
	internal bool get_IsResolverSet() { }

	// RVA: 0x105F570
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x105F604
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0x105F60C
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0x105F614
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0x105F634
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0x105F63C
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0x105F644
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0x105F64C
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x105F734
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x105F73C
	internal Char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x105F744
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0x105F74C
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0x105F754
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0x105F75C
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0x105F768
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x105F770
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0x105F778
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x105F7A0
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0x105F7A8
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0x105F7B0
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0x105FC14
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x105FD2C
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x105FE24
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0x10601E8
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0x10606B4
	private bool get_IsResolverNull() { }

	// RVA: 0x1060700
	private XmlResolver GetTempResolver() { }

	// RVA: 0x106077C
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, int entityId) { }

	// RVA: 0x1060FE0
	internal bool DtdParserProxy_PopEntity(IDtdEntityInfo oldEntity, int newEntityId) { }

	// RVA: 0x106113C
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x10618E8
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1061B80
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0x1061C98
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1061DE4
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x1061E74
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0x1061F8C
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0x10620A4
	private void Throw(int pos, string res) { }

	// RVA: 0x105925C
	private void Throw(string res) { }

	// RVA: 0x1062108
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0x1061E8C
	private void Throw(string res, string arg) { }

	// RVA: 0x1062218
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x1061FA4
	private void Throw(string res, string[] args) { }

	// RVA: 0x106230C
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0x10623A0
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0x1061C0C
	private void Throw(Exception e) { }

	// RVA: 0x10624C0
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0x105CB7C
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0x10625C8
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0x10626A8
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0x106279C
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	// RVA: 0x10624AC
	private void SetErrorState() { }

	// RVA: 0x1060570
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0x1062810
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0x105A170
	private bool get_InAttributeValueIterator() { }

	// RVA: 0x105A194
	private void FinishAttributeValueIterator() { }

	// RVA: 0x105F624
	private bool get_DtdValidation() { }

	// RVA: 0x1057F3C
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0x1057FBC
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1062AC8
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0x1062B2C
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1058BC4
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x10581D0
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0x1062EF4
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0x105830C
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0x105841C
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0x1058EDC
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0x105B540
	private void OpenUrl() { }

	// RVA: 0x1063260
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0x1062B3C
	private Encoding DetectEncoding() { }

	// RVA: 0x1062D70
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0x106341C
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0x1063650
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0x10635A0
	private void UnDecodeChars() { }

	// RVA: 0x10639D4
	private void SwitchEncodingToUTF8() { }

	// RVA: 0x105F7B4
	private int ReadData() { }

	// RVA: 0x1063A4C
	private int GetChars(int maxCharsCount) { }

	// RVA: 0x1063B6C
	private void InvalidCharRecovery(int bytesCount, int charsCount) { }

	// RVA: 0x105CE4C
	internal void Close(bool closeInput) { }

	// RVA: 0x1063DAC
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0x105B784
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0x105AF30
	private bool ParseDocumentContent() { }

	// RVA: 0x105AB58
	private bool ParseElementContent() { }

	// RVA: 0x1065754
	private void ThrowUnclosedElements() { }

	// RVA: 0x1064370
	private void ParseElement() { }

	// RVA: 0x1065F88
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0x10653AC
	private void ParseEndElement() { }

	// RVA: 0x106723C
	private void ThrowTagMismatch(NodeData startTag) { }

	// RVA: 0x1065930
	private void ParseAttributes() { }

	// RVA: 0x1066A3C
	private void ElementNamespaceLookup() { }

	// RVA: 0x1067170
	private void AttributeNamespaceLookup() { }

	// RVA: 0x1068664
	private void AttributeDuplCheck() { }

	// RVA: 0x106816C
	private void OnDefaultNamespaceDecl(NodeData attr) { }

	// RVA: 0x10682F4
	private void OnNamespaceDecl(NodeData attr) { }

	// RVA: 0x10683BC
	private void OnXmlReservedAttribute(NodeData attr) { }

	// RVA: 0x10676D0
	private void ParseAttributeValueSlow(int curPos, Char quoteChar, NodeData attr) { }

	// RVA: 0x1068E00
	private void AddAttributeChunkToList(NodeData attr, NodeData chunk, NodeData lastChunk) { }

	// RVA: 0x1064C40
	private bool ParseText() { }

	// RVA: 0x105E828
	private bool ParseText(int startPos, int endPos, int outOrChars) { }

	// RVA: 0x10598D4
	private void FinishPartialValue() { }

	// RVA: 0x10599C0
	private void FinishOtherValueIterator() { }

	// RVA: 0x105CC78
	private void SkipPartialTextValue() { }

	// RVA: 0x105CCC0
	private void FinishReadValueChunk() { }

	// RVA: 0x105CCE0
	private void FinishReadContentAsBinary() { }

	// RVA: 0x105CD44
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0x1065090
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0x105C6F4
	private void ParseEntityReference() { }

	// RVA: 0x10648C0
	private EntityType HandleEntityReference(bool isInAttributeValue, EntityExpandType expandType, int charRefEndPos) { }

	// RVA: 0x105DCB0
	private EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0x10639C4
	private bool get_InEntity() { }

	// RVA: 0x10628DC
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0x105C774
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0x10692D8
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0x1063FBC
	private bool ParsePI() { }

	// RVA: 0x105FE6C
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0x106935C
	private bool ParsePIValue(int outStartPos, int outEndPos) { }

	// RVA: 0x1063FC4
	private bool ParseComment() { }

	// RVA: 0x1064050
	private void ParseCData() { }

	// RVA: 0x10603EC
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0x1069720
	private bool ParseCDataOrComment(XmlNodeType type, int outStartPos, int outEndPos) { }

	// RVA: 0x1064058
	private bool ParseDoctypeDecl() { }

	// RVA: 0x1069BB0
	private void ParseDtd() { }

	// RVA: 0x1069F14
	private void SkipDtd() { }

	// RVA: 0x106A29C
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0x106A34C
	private void SkipUntil(Char stopChar, bool recognizeLiterals) { }

	// RVA: 0x106165C
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0x106905C
	private int ParseCharRefInline(int startPos, int charCount, EntityType entityType) { }

	// RVA: 0x105FC3C
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, EntityType entityType) { }

	// RVA: 0x106A868
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, int charCount, EntityType entityType) { }

	// RVA: 0x105FDA8
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x106AEFC
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1063DDC
	private int ParseName() { }

	// RVA: 0x1065920
	private int ParseQName(int colonPos) { }

	// RVA: 0x106B248
	private int ParseQName(bool isQName, int startOffset, int colonPos) { }

	// RVA: 0x106B4CC
	private bool ReadDataInName(int pos) { }

	// RVA: 0x1068E6C
	private string ParseEntityName() { }

	// RVA: 0x105C644
	private NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x106B518
	private NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1061D28
	private NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0x1067500
	private NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0x106B674
	private NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x105C68C
	private void PopElementContext() { }

	// RVA: 0x105F78C
	private void OnNewLine(int pos) { }

	// RVA: 0x105CAD0
	private void OnEof() { }

	// RVA: 0x1068AAC
	private string LookupNamespace(NodeData node) { }

	// RVA: 0x1068BEC
	private void AddNamespace(string prefix, string uri, NodeData attr) { }

	// RVA: 0x105C594
	private void ResetAttributes() { }

	// RVA: 0x106B814
	private void FullAttributeCleanup() { }

	// RVA: 0x1068B5C
	private void PushXmlContext() { }

	// RVA: 0x106B7D0
	private void PopXmlContext() { }

	// RVA: 0x1069284
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0x1068FF4
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0x10612D4
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0x106B8B4
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0x10608B8
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1060C70
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1061058
	private void PopEntity() { }

	// RVA: 0x106BB30
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0x106BDB4
	private void UnregisterEntity() { }

	// RVA: 0x1061964
	private void PushParsingState() { }

	// RVA: 0x1063D34
	private void PopParsingState() { }

	// RVA: 0x106BE1C
	private int IncrementalRead() { }

	// RVA: 0x105C8FC
	private void FinishIncrementalRead() { }

	// RVA: 0x105C984
	private bool ParseFragmentAttribute() { }

	// RVA: 0x105D528
	private bool ParseAttributeValueChunk() { }

	// RVA: 0x105CA1C
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0x1064038
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x1063DCC
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0x1064358
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x1063E04
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0x1064350
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0x106C790
	private string ParseUnexpectedToken() { }

	// RVA: 0x106743C
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0x1059C90
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0x1059D94
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0x10690CC
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0x1062FF4
	private void ParseDtdFromParserContext() { }

	// RVA: 0x106915C
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0x1057B1C
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x106C87C
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x106C884
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0x106CA04
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0x106CA14
	internal void set_OnDefaultAttributeUse(OnDefaultAttributeUseDelegate value) { }

	// RVA: 0x106CA24
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x106CAFC
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0x106CB04
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0x106CB24
	internal XmlResolver GetResolver() { }

	// RVA: 0x106CB70
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0x106CB90
	internal object get_InternalTypedValue() { }

	// RVA: 0x106CBB0
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0x106CBD0
	internal bool get_StandAlone() { }

	// RVA: 0x106CBD8
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x106CBE0
	internal bool get_V1Compat() { }

	// RVA: 0x1066AA4
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, NodeData[] nameSortedNodeData) { }

	// RVA: 0x106CE58
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0x106CBE8
	private NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0x106D0D8
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0x1059150
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0x1061A88
	private void RegisterConsumedCharacters(Int64 characters, bool inEntityReference) { }

	// RVA: 0x106D0E0
	internal static string StripSpaces(string value) { }

	// RVA: 0x106D300
	internal static void StripSpaces(Char[] value, int index, int len) { }

	// RVA: 0x105EF9C
	internal static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	// RVA: 0x1063A44
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

	// RVA: 0x115FEC0
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

	// RVA: 0x1164DA0
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

	// RVA: 0x115FCF0
	internal void .ctor() { }

	// RVA: 0x115FF54
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x1160064
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x11600F0
	public void .ctor(TextWriter w) { }

	// RVA: 0x11601BC
	public Stream get_BaseStream() { }

	// RVA: 0x116024C
	public void set_Namespaces(bool value) { }

	// RVA: 0x11602C0
	public void set_Formatting(Formatting value) { }

	// RVA: 0x11602D4
	public void set_QuoteChar(Char value) { }

	// RVA: 0x1160360
	public override void WriteStartDocument() { }

	// RVA: 0x1160720
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1160734
	public override void WriteEndDocument() { }

	// RVA: 0x11609B0
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1161694
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1162258
	public override void WriteEndElement() { }

	// RVA: 0x1162580
	public override void WriteFullEndElement() { }

	// RVA: 0x1162588
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1162EC0
	public override void WriteEndAttribute() { }

	// RVA: 0x1162F68
	public override void WriteCData(string text) { }

	// RVA: 0x116314C
	public override void WriteComment(string text) { }

	// RVA: 0x1163368
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11636B0
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1163788
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1163854
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11639D8
	public override void WriteString(string text) { }

	// RVA: 0x1163AB0
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1163B8C
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1163C70
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1163D54
	public override void WriteRaw(string data) { }

	// RVA: 0x1163E20
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1163F8C
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1164064
	public override WriteState get_WriteState() { }

	// RVA: 0x1164088
	public override void Close() { }

	// RVA: 0x1164208
	public override void Flush() { }

	// RVA: 0x116422C
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1160368
	private void StartDocument(int standalone) { }

	// RVA: 0x1161018
	private void AutoComplete(Token token) { }

	// RVA: 0x1160950
	private void AutoCompleteAll() { }

	// RVA: 0x1162260
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x1164470
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x1164418
	private void WriteEndAttributeQuote() { }

	// RVA: 0x1164348
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x1161E84
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1164B14
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1164DF0
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x11647F8
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1162DA4
	private string GeneratePrefix() { }

	// RVA: 0x11635B0
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1161CA4
	private int LookupNamespace(string prefix) { }

	// RVA: 0x1162C64
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x1161DA4
	private string FindPrefix(string ns) { }

	// RVA: 0x1160E20
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x11648F4
	private void HandleSpecialAttribute() { }

	// RVA: 0x1162104
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x1161B48
	private void PushStack() { }

	// RVA: 0x11647C8
	private void FlushEncoders() { }

	// RVA: 0x1164EE8
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

	// RVA: 0x1165500
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x116592C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1165AA0
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1165CEC
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1165D74
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x116605C
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1166138
	internal override void StartElementContent() { }

	// RVA: 0x1166184
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1166314
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1166440
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1166584
	public override void WriteEndAttribute() { }

	// RVA: 0x11665D4
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x116662C
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1166634
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1166788
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x11667D8
	public override void WriteCData(string text) { }

	// RVA: 0x1166DE0
	public override void WriteComment(string text) { }

	// RVA: 0x116730C
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x116745C
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1167528
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1167710
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1167D78
	public override void WriteString(string text) { }

	// RVA: 0x1167DD0
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1167F40
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1167F84
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x116828C
	public override void WriteRaw(string data) { }

	// RVA: 0x11682D8
	public override void Close() { }

	// RVA: 0x11683E8
	public override void Flush() { }

	// RVA: 0x1168434
	protected virtual void FlushBuffer() { }

	// RVA: 0x11683E4
	private void FlushEncoder() { }

	// RVA: 0x1167768
	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1167A50
	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1165CAC
	protected void RawText(string s) { }

	// RVA: 0x1168A74
	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x1167FD0
	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x1166F44
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1166A40
	protected void WriteCDataSection(string text) { }

	// RVA: 0x1168C40
	private static bool IsSurrogateByte(Byte b) { }

	// RVA: 0x1168688
	private static Byte* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x1168818
	private Byte* InvalidXmlChar(int ch, Byte* pDst, bool entitize) { }

	// RVA: 0x1168D08
	internal void EncodeChar(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x1168998
	internal static Byte* EncodeMultibyteUTF8(int ch, Byte* pDst) { }

	// RVA: 0x1168DEC
	internal static void CharToUTF8(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x11689EC
	protected Byte* WriteNewLine(Byte* pDst) { }

	// RVA: 0x11685F8
	protected static Byte* LtEntity(Byte* pDst) { }

	// RVA: 0x1168608
	protected static Byte* GtEntity(Byte* pDst) { }

	// RVA: 0x11685DC
	protected static Byte* AmpEntity(Byte* pDst) { }

	// RVA: 0x1168618
	protected static Byte* QuoteEntity(Byte* pDst) { }

	// RVA: 0x1168634
	protected static Byte* TabEntity(Byte* pDst) { }

	// RVA: 0x116866C
	protected static Byte* LineFeedEntity(Byte* pDst) { }

	// RVA: 0x1168650
	protected static Byte* CarriageReturnEntity(Byte* pDst) { }

	// RVA: 0x1168C50
	private static Byte* CharEntity(Byte* pDst, Char ch) { }

	// RVA: 0x1168C1C
	protected static Byte* RawStartCData(Byte* pDst) { }

	// RVA: 0x1168C04
	protected static Byte* RawEndCData(Byte* pDst) { }

	// RVA: 0x116560C
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

	// RVA: 0x1168EBC
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1169008
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1169100
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1169178
	internal override void StartElementContent() { }

	// RVA: 0x1169204
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x116920C
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1169294
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x116931C
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1169364
	public override void WriteCData(string text) { }

	// RVA: 0x1169370
	public override void WriteComment(string text) { }

	// RVA: 0x11693C8
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x116941C
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1169428
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1169434
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1169440
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11694A0
	public override void WriteString(string text) { }

	// RVA: 0x1169500
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x116954C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11695A0
	public override void WriteRaw(string data) { }

	// RVA: 0x11695F4
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1168EE8
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1169074
	private void WriteIndent() { }

}

// Namespace: System.Xml
public class XmlValidatingReader
{
	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Methods

	// RVA: 0x1169604
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1169628
	public override string get_LocalName() { }

	// RVA: 0x116964C
	public override string get_NamespaceURI() { }

	// RVA: 0x1169670
	public override string get_Prefix() { }

	// RVA: 0x1169694
	public override string get_Value() { }

	// RVA: 0x11696B8
	public override int get_Depth() { }

	// RVA: 0x11696DC
	public override string get_BaseURI() { }

	// RVA: 0x1169704
	public override bool get_IsEmptyElement() { }

	// RVA: 0x116972C
	public override int get_AttributeCount() { }

	// RVA: 0x1169754
	public override string GetAttribute(string name) { }

	// RVA: 0x116977C
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x11697A4
	public override string GetAttribute(int i) { }

	// RVA: 0x11697CC
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11697F4
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x116981C
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1169844
	public override bool MoveToElement() { }

	// RVA: 0x116986C
	public override bool ReadAttributeValue() { }

	// RVA: 0x1169894
	public override bool Read() { }

	// RVA: 0x11698BC
	public override bool get_EOF() { }

	// RVA: 0x11698E4
	public override ReadState get_ReadState() { }

	// RVA: 0x116990C
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1169934
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1169970
	public override void ResolveEntity() { }

	// RVA: 0x1169998
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

	// RVA: 0x1169FC0
	internal void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x116B5A0
	private object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x116B5A8
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x1169FF4
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

	// RVA: 0x11699E0
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x116A224
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x116A310
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x116A334
	public override string get_Name() { }

	// RVA: 0x116A358
	public override string get_LocalName() { }

	// RVA: 0x116A37C
	public override string get_NamespaceURI() { }

	// RVA: 0x116A3A0
	public override string get_Prefix() { }

	// RVA: 0x116A3C4
	public override string get_Value() { }

	// RVA: 0x116A3E8
	public override int get_Depth() { }

	// RVA: 0x116A40C
	public override string get_BaseURI() { }

	// RVA: 0x116A434
	public override bool get_IsEmptyElement() { }

	// RVA: 0x116A45C
	public override bool get_IsDefault() { }

	// RVA: 0x116A484
	public override Char get_QuoteChar() { }

	// RVA: 0x116A4AC
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x116A4D4
	public override string get_XmlLang() { }

	// RVA: 0x116A4FC
	public override ReadState get_ReadState() { }

	// RVA: 0x116A53C
	public override bool get_EOF() { }

	// RVA: 0x116A564
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x116A58C
	public override int get_AttributeCount() { }

	// RVA: 0x116A5B4
	public override string GetAttribute(string name) { }

	// RVA: 0x116A5DC
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x116A604
	public override string GetAttribute(int i) { }

	// RVA: 0x116A62C
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x116A66C
	public override void MoveToAttribute(int i) { }

	// RVA: 0x116A6A8
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x116A6E8
	public override bool MoveToNextAttribute() { }

	// RVA: 0x116A728
	public override bool MoveToElement() { }

	// RVA: 0x116A768
	public override bool Read() { }

	// RVA: 0x116ABF4
	public override void Close() { }

	// RVA: 0x116AC34
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x116AC5C
	public override bool ReadAttributeValue() { }

	// RVA: 0x116ACBC
	public override bool get_CanResolveEntity() { }

	// RVA: 0x116ACC4
	public override void ResolveEntity() { }

	// RVA: 0x116ACFC
	internal void MoveOffEntityReference() { }

	// RVA: 0x116ADB0
	public override string ReadString() { }

	// RVA: 0x116ADD8
	public bool HasLineInfo() { }

	// RVA: 0x116ADE0
	public int get_LineNumber() { }

	// RVA: 0x116AEE8
	public int get_LinePosition() { }

	// RVA: 0x116AFF0
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x116B158
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x116B168
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x116B0A4
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x116B220
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x116B2D8
	internal ValidationType get_ValidationType() { }

	// RVA: 0x116B2E0
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x11699C0
	internal bool get_Namespaces() { }

	// RVA: 0x116A9AC
	private void ParseDtdFromParserContext() { }

	// RVA: 0x116B2E8
	private void ValidateDtd() { }

	// RVA: 0x116AB6C
	private void ResolveEntityInternally() { }

	// RVA: 0x116A0A8
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x1169EC4
	private XmlResolver GetResolver() { }

	// RVA: 0x116A854
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x116B368
	internal BaseValidator get_Validator() { }

	// RVA: 0x116B370
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x116B378
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x116B3A0
	internal bool get_StandAlone() { }

	// RVA: 0x116B3C0
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x116B3E0
	internal object get_TypedValueObject() { }

	// RVA: 0x116B400
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x116B420
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x116B440
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x116B468
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

	// RVA: 0x116BC94
	internal void .ctor(XmlWellFormedWriter wfWriter) { }

	// RVA: 0x11727A8
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11727E8
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1172804
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

	// RVA: 0x116BD14
	internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x116D6B4
	internal void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x116DA10
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

	// RVA: 0x116BCC8
	internal void Set(string prefix, string namespaceUri, NamespaceKind kind) { }

	// RVA: 0x1171BE8
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

	// RVA: 0x117282C
	internal void Set(string prefix, string localName, string namespaceUri) { }

	// RVA: 0x1172884
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

	// RVA: 0x1173B6C
	internal void .ctor() { }

	// RVA: 0x1173B74
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

	// RVA: 0x11730F4
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

	// RVA: 0x11728F8
	internal string get_StringValue() { }

	// RVA: 0x1172930
	internal void WriteEntityRef(string name) { }

	// RVA: 0x1172D08
	internal void WriteCharEntity(Char ch) { }

	// RVA: 0x1172DD4
	internal void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1172EC8
	internal void WriteWhitespace(string ws) { }

	// RVA: 0x1172F50
	internal void WriteString(string text) { }

	// RVA: 0x1173004
	internal void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1173140
	internal void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1173230
	internal void WriteRaw(string data) { }

	// RVA: 0x11732B8
	internal void WriteValue(string value) { }

	// RVA: 0x1173340
	internal void Replay(XmlWriter writer) { }

	// RVA: 0x117366C
	internal void Trim() { }

	// RVA: 0x1173B24
	internal void Clear() { }

	// RVA: 0x1172B0C
	private void StartComplexValue() { }

	// RVA: 0x1172B60
	private void AddItem(ItemType type, object data) { }

	// RVA: 0x1173B84
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

	// RVA: 0x116B6CC
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x116BD80
	public override WriteState get_WriteState() { }

	// RVA: 0x116BE20
	public override void WriteStartDocument() { }

	// RVA: 0x116BFF4
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x116C014
	public override void WriteEndDocument() { }

	// RVA: 0x116C4E4
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x116C9C4
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x116D488
	public override void WriteEndElement() { }

	// RVA: 0x116D7E4
	public override void WriteFullEndElement() { }

	// RVA: 0x116DA44
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x116E828
	public override void WriteEndAttribute() { }

	// RVA: 0x116F644
	public override void WriteCData(string text) { }

	// RVA: 0x116F75C
	public override void WriteComment(string text) { }

	// RVA: 0x116F874
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x116FB38
	public override void WriteEntityRef(string name) { }

	// RVA: 0x116FCC8
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x116FE80
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1170044
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1170218
	public override void WriteString(string text) { }

	// RVA: 0x117031C
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x117059C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x117081C
	public override void WriteRaw(string data) { }

	// RVA: 0x1170920
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1170B6C
	public override void Close() { }

	// RVA: 0x1170D74
	public override void Flush() { }

	// RVA: 0x1170E34
	public override string LookupPrefix(string ns) { }

	// RVA: 0x11710DC
	public override void WriteValue(string value) { }

	// RVA: 0x11711F0
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1171334
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0x116FCB8
	private bool get_SaveAttrValue() { }

	// RVA: 0x1170D58
	private bool get_InBase64() { }

	// RVA: 0x116E2A8
	private void SetSpecialAttribute(SpecialAttribute special) { }

	// RVA: 0x116BE28
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x117133C
	private void StartFragment() { }

	// RVA: 0x116D05C
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x116F13C
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x1171448
	private void AddNamespace(string prefix, string ns, NamespaceKind kind) { }

	// RVA: 0x117171C
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1171348
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x116D6E8
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x117160C
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x116C17C
	private void AdvanceState(Token token) { }

	// RVA: 0x1171B14
	private void StartElementContent() { }

	// RVA: 0x1171814
	private static string GetStateName(State state) { }

	// RVA: 0x116CF10
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x116E49C
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x116E358
	private string GeneratePrefix() { }

	// RVA: 0x116CE04
	private void CheckNCName(string ncname) { }

	// RVA: 0x1171D28
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x11718C0
	private void ThrowInvalidStateTransition(Token token, State currentState) { }

	// RVA: 0x1171324
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x116E580
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1171E68
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x1171FA4
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

	// RVA: 0x1173C04
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1
	public abstract void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: -1
	public abstract void WriteEndElement() { }

	// RVA: -1
	public abstract void WriteFullEndElement() { }

	// RVA: 0x1173C1C
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x1173C7C
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x1173CDC
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

	// RVA: 0x1173D30
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: -1
	public abstract WriteState get_WriteState() { }

	// RVA: 0x1173D4C
	public virtual void Close() { }

	// RVA: -1
	public abstract void Flush() { }

	// RVA: -1
	public abstract string LookupPrefix(string ns) { }

	// RVA: 0x1173D50
	public virtual void WriteValue(string value) { }

	// RVA: 0x1173D68
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1174010
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1174494
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x11744FC
	public void Dispose() { }

	// RVA: 0x1174510
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1174564
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x1174BC8
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x1174FD4
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

	// RVA: 0x11745D8
	public void .ctor() { }

	// RVA: 0x1175148
	public bool get_Async() { }

	// RVA: 0x1175150
	public Encoding get_Encoding() { }

	// RVA: 0x1175158
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x1175160
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x1175278
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x1175280
	public string get_NewLineChars() { }

	// RVA: 0x1175288
	public bool get_Indent() { }

	// RVA: 0x1175298
	public void set_Indent(bool value) { }

	// RVA: 0x1175300
	public string get_IndentChars() { }

	// RVA: 0x1175308
	public bool get_NewLineOnAttributes() { }

	// RVA: 0x1175310
	public bool get_CloseOutput() { }

	// RVA: 0x1175318
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x1175320
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x11753D0
	public bool get_CheckCharacters() { }

	// RVA: 0x11753D8
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x11753E0
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x1175490
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x1175498
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x11754A0
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x11754A8
	public XmlWriterSettings Clone() { }

	// RVA: 0x1175588
	internal System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0x1175590
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x1175598
	internal bool get_MergeCDataSections() { }

	// RVA: 0x11755A0
	internal string get_MediaType() { }

	// RVA: 0x11755A8
	internal string get_DocTypeSystem() { }

	// RVA: 0x11755B0
	internal string get_DocTypePublic() { }

	// RVA: 0x11755B8
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x11755C0
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0x11755C8
	internal TriState get_IndentInternal() { }

	// RVA: 0x11755D0
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x117466C
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x1174C3C
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x117566C
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x11751C0
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x1174FDC
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

	// RVA: 0x1175674
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x1175770
	private void Init() { }

	// RVA: 0x1175BDC
	internal void Reset(XmlReader reader) { }

	// RVA: 0x1175C04
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1175C28
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1175C48
	public override string get_Name() { }

	// RVA: 0x1175C70
	public override string get_LocalName() { }

	// RVA: 0x1175C90
	public override string get_NamespaceURI() { }

	// RVA: 0x1175CB0
	public override string get_Prefix() { }

	// RVA: 0x1175CD0
	public override string get_Value() { }

	// RVA: 0x1175D08
	public override int get_Depth() { }

	// RVA: 0x1175D28
	public override string get_BaseURI() { }

	// RVA: 0x1175D50
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1175D58
	public override bool get_IsDefault() { }

	// RVA: 0x1175D60
	public override Char get_QuoteChar() { }

	// RVA: 0x1175D88
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1175DB0
	public override string get_XmlLang() { }

	// RVA: 0x1175DD8
	public override int get_AttributeCount() { }

	// RVA: 0x1175DE0
	public override string GetAttribute(string name) { }

	// RVA: 0x1175FF0
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1176130
	public override string GetAttribute(int i) { }

	// RVA: 0x11761CC
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1176280
	public override void MoveToAttribute(int i) { }

	// RVA: 0x117631C
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x117636C
	public override bool MoveToNextAttribute() { }

	// RVA: 0x11763D0
	public override bool MoveToElement() { }

	// RVA: 0x117642C
	public override bool Read() { }

	// RVA: 0x117674C
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x11767C8
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x117690C
	internal void RecordEndElementNode() { }

	// RVA: 0x1176A30
	public override bool get_EOF() { }

	// RVA: 0x1176A70
	public override void Close() { }

	// RVA: 0x1176AB0
	public override ReadState get_ReadState() { }

	// RVA: 0x1176AD8
	public override void Skip() { }

	// RVA: 0x1176BF0
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1176BF8
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1176C20
	public override void ResolveEntity() { }

	// RVA: 0x1176C60
	public override bool ReadAttributeValue() { }

	// RVA: 0x1176DE0
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x1176DE8
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x1176E08
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x1176E28
	internal void SetToReplayMode() { }

	// RVA: 0x1176E48
	internal XmlReader GetCoreReader() { }

	// RVA: 0x1176E50
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x117673C
	private void ClearAttributesInfo() { }

	// RVA: 0x1176E58
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x11758DC
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x1175A68
	private void RecordAttributes() { }

	// RVA: 0x1175E78
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x1175F44
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x1176D3C
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

}

// Namespace: System.Xml
internal sealed class CachingEventHandler
{
	// Methods

	// RVA: 0x1176FDC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11770FC
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

	// RVA: 0x1177110
	internal void .ctor() { }

	// RVA: 0x1177188
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

	// RVA: 0x1177224
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x1177A2C
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x1177440
	private void Init() { }

	// RVA: 0x1177810
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x1177A34
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1177B08
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1177BA0
	public override string get_Name() { }

	// RVA: 0x1177CCC
	public override string get_LocalName() { }

	// RVA: 0x1177D0C
	public override string get_NamespaceURI() { }

	// RVA: 0x1177D4C
	public override string get_Prefix() { }

	// RVA: 0x1177D8C
	public override string get_Value() { }

	// RVA: 0x1177DCC
	public override int get_Depth() { }

	// RVA: 0x1177E0C
	public override string get_BaseURI() { }

	// RVA: 0x1177E34
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1177E5C
	public override bool get_IsDefault() { }

	// RVA: 0x1177E9C
	public override Char get_QuoteChar() { }

	// RVA: 0x1177EC4
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1177EEC
	public override string get_XmlLang() { }

	// RVA: 0x1177F14
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1177F18
	public override Type get_ValueType() { }

	// RVA: 0x1178004
	public override int get_AttributeCount() { }

	// RVA: 0x117800C
	public override string GetAttribute(string name) { }

	// RVA: 0x117821C
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x117848C
	public override string GetAttribute(int i) { }

	// RVA: 0x1178580
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1178890
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1178A8C
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1178C50
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1178E14
	public override bool MoveToElement() { }

	// RVA: 0x1178E7C
	public override bool Read() { }

	// RVA: 0x1179364
	public override bool get_EOF() { }

	// RVA: 0x117938C
	public override void Close() { }

	// RVA: 0x11793CC
	public override ReadState get_ReadState() { }

	// RVA: 0x117940C
	public override void Skip() { }

	// RVA: 0x1179574
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x117957C
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1179634
	public override void ResolveEntity() { }

	// RVA: 0x1179674
	public override bool ReadAttributeValue() { }

	// RVA: 0x1179878
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1179BB8
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x1179C14
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1179CCC
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x1179E74
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x1179EE4
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x1179F4C
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x1179FA4
	public bool HasLineInfo() { }

	// RVA: 0x1179FAC
	public int get_LineNumber() { }

	// RVA: 0x117A070
	public int get_LinePosition() { }

	// RVA: 0x117A134
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x117A210
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x117A2F0
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x117A3D0
	private object GetStringValue() { }

	// RVA: 0x1177FE4
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x1179050
	private void ProcessReaderEvent() { }

	// RVA: 0x117A3F4
	private void ProcessElementEvent() { }

	// RVA: 0x117A8C0
	private void ProcessEndElementEvent() { }

	// RVA: 0x117AB44
	private void ValidateAttributes() { }

	// RVA: 0x1179314
	private void ClearAttributesInfo() { }

	// RVA: 0x1178678
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x117B088
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x117808C
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x117833C
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x117AEB8
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x117AAF8
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x117921C
	private void ProcessInlineSchema() { }

	// RVA: 0x117B154
	private void ReadAheadForMemberType() { }

	// RVA: 0x1179914
	private void GetIsDefault() { }

	// RVA: 0x1179D60
	private void GetMemberType() { }

	// RVA: 0x117ADB4
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x11797D4
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x117B3F0
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x117AD0C
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

	// RVA: 0x117B43C
	public void .ctor(XmlDocument document, XmlNode node) { }

	// RVA: 0x117B630
	public void .ctor(DocumentXPathNavigator other) { }

	// RVA: 0x117B6F4
	public override XPathNavigator Clone() { }

	// RVA: 0x117B758
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x117B7A0
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x117B88C
	public override string get_LocalName() { }

	// RVA: 0x117B8B4
	public override string get_NamespaceURI() { }

	// RVA: 0x117B9C4
	public override string get_Name() { }

	// RVA: 0x117BB10
	public override string get_Prefix() { }

	// RVA: 0x117BBF0
	public override string get_Value() { }

	// RVA: 0x117BCA4
	private string get_ValueDocument() { }

	// RVA: 0x117BD88
	private string get_ValueText() { }

	// RVA: 0x117C040
	public override string get_BaseURI() { }

	// RVA: 0x117C068
	public override string get_XmlLang() { }

	// RVA: 0x117C090
	public override object get_UnderlyingObject() { }

	// RVA: 0x117C0B4
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x117C3E8
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x117C568
	public override bool MoveToNextAttribute() { }

	// RVA: 0x117C8A4
	public override bool MoveToNamespace(string name) { }

	// RVA: 0x117CC18
	public override bool MoveToFirstNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x117CEA0
	private static bool MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x117CF28
	private static bool MoveToFirstNamespaceGlobal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x117D230
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x117D6B4
	private static bool MoveToNextNamespaceLocal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x117D0AC
	private static bool MoveToNextNamespaceGlobal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x117D748
	private bool PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, string localName) { }

	// RVA: 0x117D844
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x117D8A4
	public override bool MoveToNext() { }

	// RVA: 0x117DC2C
	public override bool MoveToFirstChild() { }

	// RVA: 0x117DEF0
	public override bool MoveToParent() { }

	// RVA: 0x117E080
	public override void MoveToRoot() { }

	// RVA: 0x117E198
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x117E24C
	public override bool MoveToId(string id) { }

	// RVA: 0x117E2B4
	public override bool MoveToChild(string localName, string namespaceUri) { }

	// RVA: 0x117E430
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x117E5A4
	public override bool MoveToFollowing(string localName, string namespaceUri, XPathNavigator end) { }

	// RVA: 0x117E82C
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x117EB30
	public override bool MoveToNext(string localName, string namespaceUri) { }

	// RVA: 0x117EC04
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x117ED64
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x117EE0C
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x117F020
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x117F048
	private static XmlNode OwnerNode(XmlNode node) { }

	// RVA: 0x117F0FC
	private static int GetDepth(XmlNode node) { }

	// RVA: 0x117F268
	private XmlNodeOrder Compare(XmlNode node1, XmlNode node2) { }

	// RVA: 0x117F480
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x117FA14
	private XmlNode System.Xml.IHasXmlNode.GetNode() { }

	// RVA: 0x117FA1C
	public override XPathNodeIterator SelectDescendants(string localName, string namespaceURI, bool matchSelf) { }

	// RVA: 0x117FD3C
	public override XPathNodeIterator SelectDescendants(XPathNodeType nt, bool includeSelf) { }

	// RVA: 0x117B4CC
	internal void ResetPosition(XmlNode node) { }

	// RVA: 0x117C818
	private static bool ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, int index) { }

	// RVA: 0x117C750
	private static bool CheckAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, int index) { }

	// RVA: 0x117B7D8
	private void CalibrateText() { }

	// RVA: 0x117DAE0
	private XmlNode ParentNode(XmlNode node) { }

	// RVA: 0x117FED8
	private XmlNode ParentNodeTail(XmlNode parent) { }

	// RVA: 0x117DE64
	private XmlNode FirstChild(XmlNode node) { }

	// RVA: 0x117FF2C
	private XmlNode FirstChildTail(XmlNode child) { }

	// RVA: 0x117BF48
	private XmlNode NextSibling(XmlNode node) { }

	// RVA: 0x117FF84
	private XmlNode NextSiblingTail(XmlNode node, XmlNode sibling) { }

	// RVA: 0x117FE78
	private XmlNode PreviousText(XmlNode node) { }

	// RVA: 0x1180048
	private XmlNode PreviousTextTail(XmlNode node, XmlNode text) { }

	// RVA: 0x117EF3C
	private static bool IsDescendant(XmlNode top, XmlNode bottom) { }

	// RVA: 0x117DB64
	private static bool IsValidChild(XmlNode parent, XmlNode child) { }

	// RVA: 0x117DA88
	private XmlNode TextEnd(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_Empty
{
	// Fields
	private XPathNavigator nav; // 0x18

	// Methods

	// RVA: 0x117FBF4
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x118016C
	internal void .ctor(DocumentXPathNodeIterator_Empty other) { }

	// RVA: 0x11801C0
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1180254
	public override bool MoveNext() { }

	// RVA: 0x118025C
	public override XPathNavigator get_Current() { }

	// RVA: 0x1180264
	public override int get_CurrentPosition() { }

	// RVA: 0x118026C
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

	// RVA: 0x1180274
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x1180334
	internal void .ctor(DocumentXPathNodeIterator_ElemDescendants other) { }

	// RVA: -1
	protected abstract bool Match(XmlNode node) { }

	// RVA: 0x11803FC
	public override XPathNavigator get_Current() { }

	// RVA: 0x1180404
	public override int get_CurrentPosition() { }

	// RVA: 0x118040C
	protected void SetPosition(int pos) { }

	// RVA: 0x1180414
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_AllElemChildren
{
	// Methods

	// RVA: 0x117FE74
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x118059C
	internal void .ctor(DocumentXPathNodeIterator_AllElemChildren other) { }

	// RVA: 0x11805A0
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1180604
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_AllElemChildren_AndSelf
{
	// Methods

	// RVA: 0x117FE70
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x1180638
	internal void .ctor(DocumentXPathNodeIterator_AllElemChildren_AndSelf other) { }

	// RVA: 0x118063C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11806A0
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren_NoLocalName
{
	// Fields
	private string nsAtom; // 0x28

	// Methods

	// RVA: 0x117FC74
	internal void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x11807C4
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_NoLocalName other) { }

	// RVA: 0x11807FC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1180878
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName
{
	// Methods

	// RVA: 0x117FC44
	internal void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x11808BC
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName other) { }

	// RVA: 0x11808F4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1180970
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren
{
	// Fields
	protected string localNameAtom; // 0x28
	protected string nsAtom; // 0x30

	// Methods

	// RVA: 0x117FCF0
	internal void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x1180A94
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren other) { }

	// RVA: 0x1180ADC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1180B68
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf
{
	// Methods

	// RVA: 0x117FCA4
	internal void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x1180BDC
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf other) { }

	// RVA: 0x1180C24
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1180CB0
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

	// RVA: 0x1180DD4
	public void .ctor(XmlDocument document) { }

	// RVA: 0x1180E84
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1181008
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1181294
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

	// RVA: 0x118141C
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11814CC
	public override int get_Count() { }

	// RVA: 0x1181620
	private XmlNode GetNode(XPathNavigator n) { }

	// RVA: 0x118153C
	internal int ReadUntil(int index) { }

	// RVA: 0x1181720
	public override XmlNode Item(int index) { }

	// RVA: 0x11817EC
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x11818B0
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

	// RVA: 0x118186C
	public void .ctor(XPathNodeList list) { }

	// RVA: 0x1181930
	public void Reset() { }

	// RVA: 0x118193C
	public bool MoveNext() { }

	// RVA: 0x11819B8
	public object get_Current() { }

}

// Namespace: System.Xml
public class XmlAttribute
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Methods

	// RVA: 0x11819F8
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0x1181C20
	internal int get_LocalNameHash() { }

	// RVA: 0x1181C40
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x1181DA0
	internal XmlName get_XmlName() { }

	// RVA: 0x1181DA8
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x1181DB0
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1181E7C
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1181E84
	public override string get_Name() { }

	// RVA: 0x1181EA4
	public override string get_LocalName() { }

	// RVA: 0x1181EC4
	public override string get_NamespaceURI() { }

	// RVA: 0x1181EE4
	public override string get_Prefix() { }

	// RVA: 0x1181F04
	public override void set_Prefix(string value) { }

	// RVA: 0x1181FB0
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1181FB8
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1181FD8
	public override string get_Value() { }

	// RVA: 0x1181FE8
	public override void set_Value(string value) { }

	// RVA: 0x1181FF8
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1182000
	public override void set_InnerText(string value) { }

	// RVA: 0x11820D0
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0x1182190
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x11823D8
	internal override bool get_IsContainer() { }

	// RVA: 0x11823E0
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11826D4
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x11826DC
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11826E4
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11826F4
	public virtual bool get_Specified() { }

	// RVA: 0x11826FC
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11827DC
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11828BC
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1182990
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x1182A64
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x1182B38
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0x1182BC0
	public override void set_InnerXml(string value) { }

	// RVA: 0x1182C50
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1182D04
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1182D6C
	public override string get_BaseURI() { }

	// RVA: 0x1182E08
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x1182E10
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0x1182E74
	internal override string get_XmlLang() { }

	// RVA: 0x1182F10
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x1182F50
	internal override string get_XPLocalName() { }

	// RVA: 0x117B994
	internal bool get_IsNamespace() { }

}

// Namespace: System.Xml
public sealed class XmlAttributeCollection
{
	// Methods

	// RVA: 0x1182FFC
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x117C290
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0x1183004
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0x1183148
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0x11832B0
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0x1183498
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x1183750
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0x1183AA4
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0x1183B4C
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0x1183C14
	public void RemoveAll() { }

	// RVA: 0x1183CF4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1183D94
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1183D9C
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1183DA0
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1183DA8
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0x1183FA0
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0x1184054
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x1183880
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0x118394C
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x1184200
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x1183E90
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0x1182218
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0x1182318
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0x11836A4
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

}

// Namespace: System.Xml
public class XmlCDataSection
{
	// Methods

	// RVA: 0x1184964
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x11849D4
	public override string get_Name() { }

	// RVA: 0x1184A00
	public override string get_LocalName() { }

	// RVA: 0x1184A2C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1184A34
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1184AD0
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1184B30
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1184B78
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1184B7C
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x1184B84
	internal override bool get_IsText() { }

	// RVA: 0x1184B8C
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public abstract class XmlCharacterData
{
	// Fields
	private string data; // 0x20

	// Methods

	// RVA: 0x118499C
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x1184BDC
	public override string get_Value() { }

	// RVA: 0x1184BEC
	public override void set_Value(string value) { }

	// RVA: 0x1184BFC
	public override string get_InnerText() { }

	// RVA: 0x1184C08
	public override void set_InnerText(string value) { }

	// RVA: 0x1184C14
	public virtual string get_Data() { }

	// RVA: 0x1184C80
	public virtual void set_Data(string value) { }

	// RVA: 0x1184D44
	internal bool CheckOnData(string data) { }

	// RVA: 0x1184D84
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

	// RVA: 0x1184E8C
	internal void .ctor(XmlNode container) { }

	// RVA: 0x1184EF8
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1184FA0
	internal bool MoveNext() { }

	// RVA: 0x1185048
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1185094
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1185098
	internal XmlNode get_Current() { }

}

// Namespace: System.Xml
internal class XmlChildNodes
{
	// Fields
	private XmlNode container; // 0x10

	// Methods

	// RVA: 0x1185110
	public void .ctor(XmlNode container) { }

	// RVA: 0x1185144
	public override XmlNode Item(int i) { }

	// RVA: 0x11851B4
	public override int get_Count() { }

	// RVA: 0x118520C
	public override IEnumerator GetEnumerator() { }

}

// Namespace: System.Xml
public class XmlComment
{
	// Methods

	// RVA: 0x1185328
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0x1185360
	public override string get_Name() { }

	// RVA: 0x118538C
	public override string get_LocalName() { }

	// RVA: 0x11853B8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11853C0
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1185420
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1185468
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x118546C
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

	// RVA: 0x1185474
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x1185914
	public string get_Version() { }

	// RVA: 0x118591C
	internal void set_Version(string value) { }

	// RVA: 0x1185924
	public string get_Encoding() { }

	// RVA: 0x1185728
	public void set_Encoding(string value) { }

	// RVA: 0x118592C
	public string get_Standalone() { }

	// RVA: 0x11857A4
	public void set_Standalone(string value) { }

	// RVA: 0x1185934
	public override string get_Value() { }

	// RVA: 0x1185944
	public override void set_Value(string value) { }

	// RVA: 0x1185954
	public override string get_InnerText() { }

	// RVA: 0x1185AD0
	public override void set_InnerText(string value) { }

	// RVA: 0x1185D10
	public override string get_Name() { }

	// RVA: 0x1185D54
	public override string get_LocalName() { }

	// RVA: 0x1185D60
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1185D68
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1185DB0
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1185E1C
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11856A4
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

	// RVA: 0x1185E20
	public void .ctor() { }

	// RVA: 0x1186338
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x1185E88
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x11863A8
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x11863B0
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0x1181B20
	internal static void CheckName(string name) { }

	// RVA: 0x11863B8
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11863D4
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1181C80
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11863F0
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0x11864CC
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0x1184610
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0x11865AC
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0x1184624
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0x118481C
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0x1186BD4
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1186D44
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1186D4C
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1186D54
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0x1186DE4
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x1186EA4
	public XmlImplementation get_Implementation() { }

	// RVA: 0x1186EAC
	public override string get_Name() { }

	// RVA: 0x1186EB4
	public override string get_LocalName() { }

	// RVA: 0x117BEB8
	public XmlElement get_DocumentElement() { }

	// RVA: 0x1186EBC
	internal override bool get_IsContainer() { }

	// RVA: 0x1186EC4
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1186ECC
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1186ED4
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1186EDC
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x1186EE4
	internal bool get_CanReportValidity() { }

	// RVA: 0x1186EEC
	internal bool get_HasSetResolver() { }

	// RVA: 0x1186EF4
	internal XmlResolver GetResolver() { }

	// RVA: 0x1186EFC
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x11870C4
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1187220
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x11872E0
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x1187344
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x118755C
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11876D0
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0x11877DC
	internal void SetDefaultNamespace(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1187880
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0x1187904
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0x1187980
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1187A18
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0x1187A80
	public XmlElement CreateElement(string name) { }

	// RVA: 0x1187B20
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0x1187DCC
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0x1187F00
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x1188060
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0x11880D0
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x1188150
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x11881D4
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0x1188244
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0x11882B4
	public override XPathNavigator CreateNavigator() { }

	// RVA: 0x11882C8
	protected internal virtual XPathNavigator CreateNavigator(XmlNode node) { }

	// RVA: 0x1188680
	internal static bool IsTextNode(XmlNodeType nt) { }

	// RVA: 0x11884B4
	private XmlNode NormalizeText(XmlNode n) { }

	// RVA: 0x1188698
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0x1188708
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0x11887AC
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0x1188850
	public virtual XmlElement GetElementById(string elementId) { }

	// RVA: 0x1188BF0
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0x11891D4
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0x1186C94
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0x117B780
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1189338
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x11893D0
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1189458
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x118952C
	public override bool get_IsReadOnly() { }

	// RVA: 0x1189534
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x11895D4
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0x11895DC
	internal bool get_IsLoading() { }

	// RVA: 0x11895E4
	internal void set_IsLoading(bool value) { }

	// RVA: 0x11895EC
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0x11895F4
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0x11896E8
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0x118974C
	public virtual void Load(XmlReader reader) { }

	// RVA: 0x1189870
	public virtual void LoadXml(string xml) { }

	// RVA: 0x11899EC
	public override void set_InnerText(string value) { }

	// RVA: 0x1189A48
	public override void set_InnerXml(string value) { }

	// RVA: 0x1189A58
	public virtual void Save(XmlWriter w) { }

	// RVA: 0x1189C8C
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1189C9C
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0x1189F64
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x118260C
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0x118A060
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x118A0B4
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1184358
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x118A108
	internal string get_Version() { }

	// RVA: 0x118A130
	internal string get_Encoding() { }

	// RVA: 0x1189C64
	internal string get_Standalone() { }

	// RVA: 0x118A158
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0x118A22C
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x118A40C
	public override string get_BaseURI() { }

	// RVA: 0x118A414
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0x118A424
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x118A6CC
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x118A6D4
	internal bool get_HasEntityReferences() { }

	// RVA: 0x117CB50
	internal XmlAttribute get_NamespaceXml() { }

	// RVA: 0x118A6DC
	private static void .cctor() { }

}

// Namespace: System.Xml
public class XmlDocumentFragment
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Methods

	// RVA: 0x118A7FC
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x118A88C
	public override string get_Name() { }

	// RVA: 0x118A8B8
	public override string get_LocalName() { }

	// RVA: 0x118A8E4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x118A8EC
	public override XmlNode get_ParentNode() { }

	// RVA: 0x118A8F4
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x118A970
	public override void set_InnerXml(string value) { }

	// RVA: 0x118AC48
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x118ACCC
	internal override bool get_IsContainer() { }

	// RVA: 0x118ACD4
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x118ACDC
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x118ACE4
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x118AD60
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x118ADE4
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x118AE50
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x118AE60
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x118B1C4
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

	// RVA: 0x118B1CC
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x118B3D4
	public override string get_Name() { }

	// RVA: 0x118B3DC
	public override string get_LocalName() { }

	// RVA: 0x118B3E4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x118B3EC
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x118B434
	public override bool get_IsReadOnly() { }

	// RVA: 0x118B43C
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x118B51C
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x118B5C8
	public string get_PublicId() { }

	// RVA: 0x118B5D0
	public string get_SystemId() { }

	// RVA: 0x118B5D8
	public string get_InternalSubset() { }

	// RVA: 0x118B5E0
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x118B5E8
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x118B618
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x118B61C
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x118B624
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

}

// Namespace: System.Xml
internal class XmlDOMTextWriter
{
	// Methods

	// RVA: 0x118B62C
	public void .ctor(TextWriter w) { }

	// RVA: 0x118B698
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x118B730
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

	// RVA: 0x118B7C8
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x118B938
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x118B980
	internal XmlName get_XmlName() { }

	// RVA: 0x118B988
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x118B990
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x118C018
	public override string get_Name() { }

	// RVA: 0x118C22C
	public override string get_LocalName() { }

	// RVA: 0x118C24C
	public override string get_NamespaceURI() { }

	// RVA: 0x118C26C
	public override string get_Prefix() { }

	// RVA: 0x118C28C
	public override void set_Prefix(string value) { }

	// RVA: 0x118C33C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x118C344
	public override XmlNode get_ParentNode() { }

	// RVA: 0x118C34C
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x118C36C
	internal override bool get_IsContainer() { }

	// RVA: 0x118C374
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x118BF3C
	public bool get_IsEmpty() { }

	// RVA: 0x118BF4C
	public void set_IsEmpty(bool value) { }

	// RVA: 0x118C5D0
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x118C5E0
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x118C5E8
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x118C600
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x118C764
	public virtual bool get_HasAttributes() { }

	// RVA: 0x118C790
	public virtual string GetAttribute(string name) { }

	// RVA: 0x118C820
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x118C8DC
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x118C944
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x118CA60
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x118CAF8
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x118CC20
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x118CC9C
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x118CD94
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x118CDBC
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x118CEF0
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x118D150
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0x118D26C
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x118D2D4
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x118D320
	public override void RemoveAll() { }

	// RVA: 0x118C55C
	internal void RemoveAllChildren() { }

	// RVA: 0x118D418
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x118D420
	public override void set_InnerXml(string value) { }

	// RVA: 0x118D5D8
	public override string get_InnerText() { }

	// RVA: 0x118D6F4
	public override void set_InnerText(string value) { }

	// RVA: 0x118D80C
	public override XmlNode get_NextSibling() { }

	// RVA: 0x118D85C
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x118D864
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x118D86C
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

	// RVA: 0x118D87C
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x118D9D4
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x118DA30
	public override bool get_IsReadOnly() { }

	// RVA: 0x118DA38
	public override string get_Name() { }

	// RVA: 0x118DA40
	public override string get_LocalName() { }

	// RVA: 0x118DA48
	public override string get_InnerText() { }

	// RVA: 0x118DA4C
	public override void set_InnerText(string value) { }

	// RVA: 0x118DAA8
	internal override bool get_IsContainer() { }

	// RVA: 0x118DAB0
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x118DC8C
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x118DC94
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x118DCAC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x118DCB4
	public string get_SystemId() { }

	// RVA: 0x118DCBC
	public override string get_OuterXml() { }

	// RVA: 0x118DD08
	public override void set_InnerXml(string value) { }

	// RVA: 0x118DD64
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x118DD68
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x118DD6C
	public override string get_BaseURI() { }

	// RVA: 0x118DD74
	internal void SetBaseURI(string inBaseURI) { }

}

// Namespace: System.Xml
public class XmlEntityReference
{
	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Methods

	// RVA: 0x118DD7C
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x118DE80
	public override string get_Name() { }

	// RVA: 0x118DE88
	public override string get_LocalName() { }

	// RVA: 0x118DE90
	public override string get_Value() { }

	// RVA: 0x118DE98
	public override void set_Value(string value) { }

	// RVA: 0x118DEF4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x118DEFC
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x118DF40
	public override bool get_IsReadOnly() { }

	// RVA: 0x118DF48
	internal override bool get_IsContainer() { }

	// RVA: 0x118DF50
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x118E678
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x118E688
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x118E690
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x118E698
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x118E6B0
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x118E6E0
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x118E9DC
	public override string get_BaseURI() { }

	// RVA: 0x118EA10
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x118EAF8
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

	// RVA: 0x118EBD0
	public void .ctor() { }

	// RVA: 0x118ED2C
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x118ED60
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0x118EDC8
	internal XmlNameTable get_NameTable() { }

}

// Namespace: System.Xml
public abstract class XmlLinkedNode
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Methods

	// RVA: 0x118B334
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x118EDD0
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x118EE48
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

	// RVA: 0x118AA00
	public void .ctor() { }

	// RVA: 0x118EEA4
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x118F130
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x118F7FC
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x118F1B4
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x118F954
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x119044C
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x119061C
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x118FC9C
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x118FFA4
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x1190150
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x1190954
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x1192060
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x118B360
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x1192368
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x1191120
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x119275C
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x118AA08
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x118D550
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x119361C
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x1193360
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x1193624
	private string EntitizeName(string name) { }

	// RVA: 0x118DBE0
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x118E098
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x1193070
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x1190E60
	internal static void ParseXmlDeclarationValue(string strValue, string version, string encoding, string standalone) { }

	// RVA: 0x1190338
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

	// RVA: 0x11936A0
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11937E0
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x1193D10
	public string get_LocalName() { }

	// RVA: 0x1193D18
	public string get_NamespaceURI() { }

	// RVA: 0x1193D20
	public string get_Prefix() { }

	// RVA: 0x1193D28
	public int get_HashCode() { }

	// RVA: 0x1193D30
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x118C034
	public string get_Name() { }

	// RVA: 0x1193D38
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x1193D40
	public virtual bool get_IsDefault() { }

	// RVA: 0x1193D48
	public virtual bool get_IsNil() { }

	// RVA: 0x1193D50
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x1193D58
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x1193D60
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1193D68
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1193D70
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1193D7C
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

	// RVA: 0x1193894
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1193E48
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x1193E80
	public override bool get_IsDefault() { }

	// RVA: 0x1193E8C
	public override bool get_IsNil() { }

	// RVA: 0x1193E98
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x1193EA0
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x1193EA8
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1193F30
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1193DF4
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x1193E08
	public void SetIsDefault(bool value) { }

	// RVA: 0x1193E28
	public void SetIsNil(bool value) { }

	// RVA: 0x1193FB8
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }

}

// Namespace: 
private class SingleObjectEnumerator
{
	// Fields
	private object loneValue; // 0x10
	private int position; // 0x18

	// Methods

	// RVA: 0x11953DC
	public void .ctor(object value) { }

	// RVA: 0x1195418
	public object get_Current() { }

	// RVA: 0x1195470
	public bool MoveNext() { }

	// RVA: 0x1195488
	public void Reset() { }

}

// Namespace: 
internal struct SmallXmlNodeList
{
	// Fields
	private object field; // 0x10

	// Methods

	// RVA: 0x119489C
	public int get_Count() { }

	// RVA: 0x11944C8
	public object get_Item(int index) { }

	// RVA: 0x1194C10
	public void Add(object value) { }

	// RVA: 0x1194F74
	public void RemoveAt(int index) { }

	// RVA: 0x1195228
	public void Insert(int index, object value) { }

	// RVA: 0x1194934
	public IEnumerator GetEnumerator() { }

}

// Namespace: System.Xml
public class XmlNamedNodeMap
{
	// Fields
	internal XmlNode parent; // 0x10
	internal SmallXmlNodeList nodes; // 0x18

	// Methods

	// RVA: 0x118B4E8
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x1194324
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x11945B4
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x119480C
	public virtual int get_Count() { }

	// RVA: 0x119492C
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11943D8
	internal int FindNodeOffset(string name) { }

	// RVA: 0x1194680
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x1194A60
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x1194D58
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x1194E04
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x11947B4
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x119506C
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

}

// Namespace: System.Xml
public abstract class XmlNode
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Methods

	// RVA: 0x118A884
	internal void .ctor() { }

	// RVA: 0x118D94C
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x1195494
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: 0x119553C
	public XmlNodeList SelectNodes(string xpath) { }

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: 0x11955EC
	public virtual string get_Value() { }

	// RVA: 0x11955F4
	public virtual void set_Value(string value) { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x11956C8
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x11957BC
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x1195824
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x119582C
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x1195834
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x119583C
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x11958F8
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x1195920
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x1195930
	internal virtual bool get_IsContainer() { }

	// RVA: 0x1195938
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x1195940
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1195944
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x11959B0
	internal bool IsConnected() { }

	// RVA: 0x1195A10
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1196088
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1196670
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1196A90
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x1196AD8
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x119702C
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11971FC
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1197204
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x119720C
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1197214
	public virtual bool get_HasChildNodes() { }

	// RVA: -1
	public abstract XmlNode CloneNode(bool deep) { }

	// RVA: 0x119723C
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x11972DC
	public virtual string get_NamespaceURI() { }

	// RVA: 0x1197328
	public virtual string get_Prefix() { }

	// RVA: 0x1197374
	public virtual void set_Prefix(string value) { }

	// RVA: -1
	public abstract string get_LocalName() { }

	// RVA: 0x1197378
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x1197480
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x119758C
	private object System.ICloneable.Clone() { }

	// RVA: 0x11975A0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x118B15C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1197608
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x118D5DC
	public virtual string get_InnerText() { }

	// RVA: 0x1197710
	public virtual void set_InnerText(string value) { }

	// RVA: 0x11977F4
	public virtual string get_OuterXml() { }

	// RVA: 0x11979A8
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x1197A04
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1197A80
	public virtual string get_BaseURI() { }

	// RVA: -1
	public abstract void WriteTo(XmlWriter w) { }

	// RVA: -1
	public abstract void WriteContentTo(XmlWriter w) { }

	// RVA: 0x118D3A4
	public virtual void RemoveAll() { }

	// RVA: 0x1197BAC
	internal XmlDocument get_Document() { }

	// RVA: 0x1197C5C
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x1197CE8
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x118E044
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x1198154
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x119815C
	internal static void SplitName(string name, string prefix, string localName) { }

	// RVA: 0x119825C
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x11982C8
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x11983F8
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x119844C
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11984A0
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x1198634
	internal virtual string get_XmlLang() { }

	// RVA: 0x119873C
	internal virtual XPathNodeType get_XPNodeType() { }

	// RVA: 0x1198744
	internal virtual string get_XPLocalName() { }

	// RVA: 0x1198790
	internal virtual bool get_IsText() { }

	// RVA: 0x1198798
	public virtual XmlNode get_PreviousText() { }

	// RVA: 0x118C534
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x1196048
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

	// RVA: 0x11987A0
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1198888
	public XmlNodeChangedAction get_Action() { }

}

// Namespace: System.Xml
public sealed class XmlNodeChangedEventHandler
{
	// Methods

	// RVA: 0x1198890
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11989B4
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

	// RVA: 0x11989C8
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0x11989D4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x11989E0
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x11989E4
	protected void .ctor() { }

}

// Namespace: 
internal struct VirtualAttribute
{
	// Fields
	internal string name; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x1198D8C
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

	// RVA: 0x11989EC
	public void .ctor(XmlNode node) { }

	// RVA: 0x1198DC0
	public XmlNodeType get_NodeType() { }

	// RVA: 0x1198E10
	public string get_NamespaceURI() { }

	// RVA: 0x1198E38
	public string get_Name() { }

	// RVA: 0x1198F64
	public string get_LocalName() { }

	// RVA: 0x1199028
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0x1198F44
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0x1199030
	public string get_Prefix() { }

	// RVA: 0x1199058
	public string get_Value() { }

	// RVA: 0x1199510
	public string get_BaseURI() { }

	// RVA: 0x1199538
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x1199560
	public string get_XmlLang() { }

	// RVA: 0x1199588
	public bool get_IsEmptyElement() { }

	// RVA: 0x1199640
	public bool get_IsDefault() { }

	// RVA: 0x11996FC
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1199724
	public XmlNameTable get_NameTable() { }

	// RVA: 0x119972C
	public int get_AttributeCount() { }

	// RVA: 0x11999D0
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0x119933C
	private void InitDecAttr() { }

	// RVA: 0x1199A44
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0x1199B28
	public string GetDeclarationAttr(int i) { }

	// RVA: 0x1199B80
	public int GetDecAttrInd(string name) { }

	// RVA: 0x119988C
	private void InitDocTypeAttr() { }

	// RVA: 0x1199C28
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0x1199CD8
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0x1199D30
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0x1199DD8
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0x1199E20
	public string GetAttribute(string name) { }

	// RVA: 0x119A09C
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x119A0E8
	public string GetAttribute(string name, string ns) { }

	// RVA: 0x119A384
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0x119A5E0
	public void LogMove(int level) { }

	// RVA: 0x119A628
	public void RollBackMove(int level) { }

	// RVA: 0x119A678
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0x119A6AC
	public void ResetToAttribute(int level) { }

	// RVA: 0x119A794
	public void ResetMove(int level, XmlNodeType nt) { }

	// RVA: 0x119A988
	public bool MoveToAttribute(string name) { }

	// RVA: 0x119AC34
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x119A9EC
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0x119AD30
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x119AF94
	public bool MoveToNextAttribute(int level) { }

	// RVA: 0x119B1E4
	public bool MoveToParent() { }

	// RVA: 0x119B268
	public bool MoveToFirstChild() { }

	// RVA: 0x119B2F4
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0x119B384
	public bool MoveToNext() { }

	// RVA: 0x119B40C
	public bool MoveToElement() { }

	// RVA: 0x119B4B4
	public string LookupNamespace(string prefix) { }

	// RVA: 0x119B7BC
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0x119B8F4
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x119BCC8
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x119C1C8
	public bool ReadAttributeValue(int level, bool bResolveEntity, XmlNodeType nt) { }

	// RVA: 0x119C450
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

	// RVA: 0x119C458
	public void .ctor(XmlNode node) { }

	// RVA: 0x119C56C
	internal bool IsInReadingStates() { }

	// RVA: 0x119C57C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x119C598
	public override string get_Name() { }

	// RVA: 0x119C60C
	public override string get_LocalName() { }

	// RVA: 0x119C714
	public override string get_NamespaceURI() { }

	// RVA: 0x119C79C
	public override string get_Prefix() { }

	// RVA: 0x119C824
	public override string get_Value() { }

	// RVA: 0x119C898
	public override int get_Depth() { }

	// RVA: 0x119C8A0
	public override string get_BaseURI() { }

	// RVA: 0x119C8D0
	public override bool get_CanResolveEntity() { }

	// RVA: 0x119C8D8
	public override bool get_IsEmptyElement() { }

	// RVA: 0x119C9A0
	public override bool get_IsDefault() { }

	// RVA: 0x119C9D4
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x119CA1C
	public override string get_XmlLang() { }

	// RVA: 0x119CAA4
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x119CAEC
	public override int get_AttributeCount() { }

	// RVA: 0x119CB2C
	public override string GetAttribute(string name) { }

	// RVA: 0x119CB60
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x119CBF8
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x119CC70
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x119CE20
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x119D048
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x119D19C
	public override bool MoveToNextAttribute() { }

	// RVA: 0x119D304
	public override bool MoveToElement() { }

	// RVA: 0x119D4B4
	public override bool Read() { }

	// RVA: 0x119D4BC
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x119D690
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x119DC5C
	private void SetEndOfFile() { }

	// RVA: 0x119DC74
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x119DAA8
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x119DA80
	private void ReSetReadingMarks() { }

	// RVA: 0x119DD9C
	public override bool get_EOF() { }

	// RVA: 0x119DDC0
	public override void Close() { }

	// RVA: 0x119DDCC
	public override ReadState get_ReadState() { }

	// RVA: 0x119DDD4
	public override void Skip() { }

	// RVA: 0x119DDDC
	public override string ReadString() { }

	// RVA: 0x119DE84
	public override bool get_HasAttributes() { }

	// RVA: 0x119DEAC
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x119DECC
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x119DF10
	public override void ResolveEntity() { }

	// RVA: 0x119DF98
	public override bool ReadAttributeValue() { }

	// RVA: 0x119CDFC
	private void FinishReadBinary() { }

	// RVA: 0x119DFF8
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x119E014
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x119E030
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x119E0A4
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

	// RVA: 0x11926C4
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x119E0CC
	public override string get_Name() { }

	// RVA: 0x119E0D4
	public override string get_LocalName() { }

	// RVA: 0x119E0DC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x119E0E4
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x119E140
	public override bool get_IsReadOnly() { }

	// RVA: 0x119E148
	public override string get_OuterXml() { }

	// RVA: 0x119E194
	public override void set_InnerXml(string value) { }

	// RVA: 0x119E1F0
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x119E1F4
	public override void WriteContentTo(XmlWriter w) { }

}

// Namespace: System.Xml
public class XmlProcessingInstruction
{
	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Methods

	// RVA: 0x1192300
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0x119E1F8
	public override string get_Name() { }

	// RVA: 0x119E264
	public override string get_LocalName() { }

	// RVA: 0x119E270
	public override string get_Value() { }

	// RVA: 0x119E278
	public override void set_Value(string value) { }

	// RVA: 0x119E33C
	public void set_Data(string value) { }

	// RVA: 0x119E400
	public override string get_InnerText() { }

	// RVA: 0x119E408
	public override void set_InnerText(string value) { }

	// RVA: 0x119E4CC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x119E4D4
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x119E518
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x119E548
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x119E54C
	internal override string get_XPLocalName() { }

	// RVA: 0x119E558
	internal override XPathNodeType get_XPNodeType() { }

}

// Namespace: System.Xml
public class XmlSignificantWhitespace
{
	// Methods

	// RVA: 0x11921B0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x119E560
	public override string get_Name() { }

	// RVA: 0x119E58C
	public override string get_LocalName() { }

	// RVA: 0x119E5B8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x119E5C0
	public override XmlNode get_ParentNode() { }

	// RVA: 0x119E664
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x119E6C4
	public override string get_Value() { }

	// RVA: 0x119E6D4
	public override void set_Value(string value) { }

	// RVA: 0x119E764
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x119E7AC
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x119E7B0
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x119E7E4
	internal override bool get_IsText() { }

	// RVA: 0x119E7EC
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public class XmlText
{
	// Methods

	// RVA: 0x1190948
	internal void .ctor(string strData) { }

	// RVA: 0x1190940
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x119E83C
	public override string get_Name() { }

	// RVA: 0x119E868
	public override string get_LocalName() { }

	// RVA: 0x119E894
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x119E89C
	public override XmlNode get_ParentNode() { }

	// RVA: 0x119E938
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x119E998
	public override string get_Value() { }

	// RVA: 0x119E9A8
	public override void set_Value(string value) { }

	// RVA: 0x119EA88
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x119EAD0
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x119EAD4
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x119EADC
	internal override bool get_IsText() { }

	// RVA: 0x119EAE4
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal class XmlUnspecifiedAttribute
{
	// Fields
	private bool fSpecified; // 0x28

	// Methods

	// RVA: 0x1192360
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x119EB34
	public override bool get_Specified() { }

	// RVA: 0x119EB3C
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x119EC70
	public override void set_InnerText(string value) { }

	// RVA: 0x119EC9C
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x119ECC8
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x119ECF4
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x119ED20
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x119ED4C
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x119ED60
	internal void SetSpecified(bool f) { }

}

// Namespace: System.Xml
public class XmlWhitespace
{
	// Methods

	// RVA: 0x1192258
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x119ED68
	public override string get_Name() { }

	// RVA: 0x119ED94
	public override string get_LocalName() { }

	// RVA: 0x119EDC0
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x119EDC8
	public override XmlNode get_ParentNode() { }

	// RVA: 0x119EE6C
	public override string get_Value() { }

	// RVA: 0x119EE7C
	public override void set_Value(string value) { }

	// RVA: 0x119EF0C
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x119EF6C
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x119EFB4
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x119EFB8
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x119EFEC
	internal override bool get_IsText() { }

	// RVA: 0x119EFF4
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal sealed class EmptyEnumerator
{
	// Methods

	// RVA: 0x119F044
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x119F04C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x119F050
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x119F0AC
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

	// RVA: 0x119F0B4
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x119F138
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x119F1C4
	internal object Push() { }

	// RVA: 0x119F310
	internal object Pop() { }

	// RVA: 0x119F360
	internal object Peek() { }

	// RVA: 0x119F3AC
	internal void AddToTop(object o) { }

	// RVA: 0x119F438
	internal object get_Item(int index) { }

	// RVA: 0x119F4B8
	internal void set_Item(int index, object value) { }

	// RVA: 0x119F570
	internal int get_Length() { }

	// RVA: 0x119F578
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x119F5D4
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

	// RVA: 0x119F6C4
	public virtual bool HasLineInfo() { }

	// RVA: 0x119F6CC
	public virtual int get_LineNumber() { }

	// RVA: 0x119F6D4
	public virtual int get_LinePosition() { }

	// RVA: 0x119F6DC
	public static PositionInfo GetPositionInfo(object o) { }

	// RVA: 0x119F7E8
	public void .ctor() { }

}

// Namespace: System.Xml
internal class ReaderPositionInfo
{
	// Fields
	private IXmlLineInfo lineInfo; // 0x10

	// Methods

	// RVA: 0x119F7B4
	public void .ctor(IXmlLineInfo lineInfo) { }

	// RVA: 0x119F7F0
	public override bool HasLineInfo() { }

	// RVA: 0x119F8A4
	public override int get_LineNumber() { }

	// RVA: 0x119F95C
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

	// RVA: 0x119FA14
	public void .ctor(int lineNo, int linePos) { }

	// RVA: 0x119FA1C
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

	// RVA: 0x11A0178
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

	// RVA: 0x118ECA4
	public void .ctor() { }

	// RVA: 0x119FA24
	public override string Add(string key) { }

	// RVA: 0x119FCDC
	public override string Add(Char[] key, int start, int len) { }

	// RVA: 0x119FFF8
	public override string Get(string value) { }

	// RVA: 0x119FBA8
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x11A01D0
	private void Grow() { }

	// RVA: 0x119FF1C
	private static bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}

// Namespace: System.Xml
internal static class Ref
{
	// Methods

	// RVA: 0x1193694
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

	// RVA: 0x11AD688
	internal void .ctor(string name, int lineNo, int linePos) { }

}

// Namespace: 
private class ParseElementOnlyContent_LocalFrame
{
	// Fields
	public int startParenEntityId; // 0x10
	public Token parsingSchema; // 0x14

	// Methods

	// RVA: 0x11AD6E0
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

	// RVA: 0x11A0358
	private void .ctor() { }

	// RVA: 0x1192670
	internal static IDtdParser Create() { }

	// RVA: 0x11A0440
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x11A087C
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x11A0DB0
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x11A12E8
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x11A1318
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x11A1328
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x11A1338
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x11A1410
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0x11A1440
	private bool get_SupportNamespaces() { }

	// RVA: 0x11A1448
	private bool get_Normalize() { }

	// RVA: 0x11A0DE4
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x11A14B4
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x11A1450
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x11A3144
	private void ParseInternalSubset() { }

	// RVA: 0x11A3148
	private void ParseExternalSubset() { }

	// RVA: 0x11A3330
	private void ParseSubset() { }

	// RVA: 0x11A3830
	private void ParseAttlistDecl() { }

	// RVA: 0x11A5BE0
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x11A64A4
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x11A3F50
	private void ParseElementDecl() { }

	// RVA: 0x11A704C
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x11A7484
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x11A6D14
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x11A438C
	private void ParseEntityDecl() { }

	// RVA: 0x11A4814
	private void ParseNotationDecl() { }

	// RVA: 0x11A6940
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x11A4BDC
	private void ParseComment() { }

	// RVA: 0x11A4ED8
	private void ParsePI() { }

	// RVA: 0x11A5194
	private void ParseCondSection() { }

	// RVA: 0x11A2920
	private void ParseExternalId(Token idTokenType, Token declType, string publicId, string systemId) { }

	// RVA: 0x11A1B58
	private Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x11A7ED4
	private Token ScanSubsetContent() { }

	// RVA: 0x11A7E48
	private Token ScanNameExpected() { }

	// RVA: 0x11A7E78
	private Token ScanQNameExpected() { }

	// RVA: 0x11A7EA8
	private Token ScanNmtokenExpected() { }

	// RVA: 0x11A875C
	private Token ScanDoctype1() { }

	// RVA: 0x11A8994
	private Token ScanDoctype2() { }

	// RVA: 0x11AB618
	private Token ScanClosingTag() { }

	// RVA: 0x11A8AAC
	private Token ScanElement1() { }

	// RVA: 0x11A8D98
	private Token ScanElement2() { }

	// RVA: 0x11A8FC8
	private Token ScanElement3() { }

	// RVA: 0x11A9064
	private Token ScanElement4() { }

	// RVA: 0x11A91A4
	private Token ScanElement5() { }

	// RVA: 0x11A9320
	private Token ScanElement6() { }

	// RVA: 0x11A9404
	private Token ScanElement7() { }

	// RVA: 0x11A946C
	private Token ScanAttlist1() { }

	// RVA: 0x11A953C
	private Token ScanAttlist2() { }

	// RVA: 0x11A9D90
	private Token ScanAttlist3() { }

	// RVA: 0x11A9E3C
	private Token ScanAttlist4() { }

	// RVA: 0x11A9F20
	private Token ScanAttlist5() { }

	// RVA: 0x11AA004
	private Token ScanAttlist6() { }

	// RVA: 0x11AA490
	private Token ScanAttlist7() { }

	// RVA: 0x11ABD10
	private Token ScanLiteral(LiteralType literalType) { }

	// RVA: 0x11ACAA4
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x11AA558
	private Token ScanNotation1() { }

	// RVA: 0x11AA744
	private Token ScanSystemId() { }

	// RVA: 0x11AA938
	private Token ScanEntity1() { }

	// RVA: 0x11AA9C0
	private Token ScanEntity2() { }

	// RVA: 0x11AABF0
	private Token ScanEntity3() { }

	// RVA: 0x11AA7FC
	private Token ScanPublicId1() { }

	// RVA: 0x11AA8B4
	private Token ScanPublicId2() { }

	// RVA: 0x11AAD08
	private Token ScanCondSection1() { }

	// RVA: 0x11AB088
	private Token ScanCondSection2() { }

	// RVA: 0x11AB124
	private Token ScanCondSection3() { }

	// RVA: 0x11AB984
	private void ScanName() { }

	// RVA: 0x11AB98C
	private void ScanQName() { }

	// RVA: 0x11ACE68
	private void ScanQName(bool isQName) { }

	// RVA: 0x11AD0F8
	private bool ReadDataInName() { }

	// RVA: 0x11AB994
	private void ScanNmtoken() { }

	// RVA: 0x11ABB10
	private bool EatPublicKeyword() { }

	// RVA: 0x11ABC10
	private bool EatSystemKeyword() { }

	// RVA: 0x11A2790
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x11A6924
	private string GetNameString() { }

	// RVA: 0x11A6C18
	private string GetNmtokenString() { }

	// RVA: 0x11A6CA8
	private string GetValue() { }

	// RVA: 0x11A6C34
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x11AB6B0
	private int ReadData() { }

	// RVA: 0x11A19AC
	private void LoadParsingBuffer() { }

	// RVA: 0x11A313C
	private void SaveParsingBuffer() { }

	// RVA: 0x11A5670
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x11A7D20
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x11AD360
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x11AB778
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x11ACC10
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x11A5458
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x11A6730
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x11A1858
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x11A6724
	private bool IsAttributeValueType(Token token) { }

	// RVA: 0x11A588C
	private int get_LineNo() { }

	// RVA: 0x11A5944
	private int get_LinePos() { }

	// RVA: 0x11A1720
	private string get_BaseUriStr() { }

	// RVA: 0x11A26F4
	private void OnUnexpectedError() { }

	// RVA: 0x11A5120
	private void Throw(int curPos, string res) { }

	// RVA: 0x11A750C
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x11A7990
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x11A59F8
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x11A0D30
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x11A7C9C
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	// RVA: 0x11A5884
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x11A7818
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x11A7D74
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x11AD140
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

	// RVA: 0x11AD710
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0x11AD7E4
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0x11AD8D4
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0x11ADA3C
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0x11ADAF4
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0x11ADC2C
	internal static int ParseNCName(string s) { }

	// RVA: 0x11ADCB4
	internal static int ParseQName(string s, int offset, int colonOffset) { }

	// RVA: 0x11ADDD4
	internal static void ParseQNameThrow(string s, string prefix, string localName) { }

	// RVA: 0x11ADF54
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x11AE450
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x11AE714
	internal static void SplitQName(string name, string prefix, string lname) { }

	// RVA: 0x11AEB20
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

	// RVA: 0x11AEBF0
	private static object get_StaticLock() { }

	// RVA: 0x11AECA4
	private static void InitInstance() { }

	// RVA: 0x11AEFBC
	private static void SetProperties(Byte[] chProps, string ranges, Byte value) { }

	// RVA: 0x11AF148
	private void .ctor(Byte[] charProperties) { }

	// RVA: 0x11AE288
	public static XmlCharType get_Instance() { }

	// RVA: 0x11AF150
	public bool IsWhiteSpace(Char ch) { }

	// RVA: 0x11AE250
	public bool IsNCNameSingleChar(Char ch) { }

	// RVA: 0x11AE30C
	public bool IsStartNCNameSingleChar(Char ch) { }

	// RVA: 0x11AF188
	public bool IsNameSingleChar(Char ch) { }

	// RVA: 0x11AF1C8
	public bool IsCharData(Char ch) { }

	// RVA: 0x11AF200
	public bool IsPubidChar(Char ch) { }

	// RVA: 0x11AF280
	internal bool IsTextChar(Char ch) { }

	// RVA: 0x11AF2B8
	public bool IsLetter(Char ch) { }

	// RVA: 0x11AF2F0
	public bool IsNCNameCharXml4e(Char ch) { }

	// RVA: 0x11AF328
	public bool IsStartNCNameCharXml4e(Char ch) { }

	// RVA: 0x11AF368
	public bool IsNameCharXml4e(Char ch) { }

	// RVA: 0x11AF3A8
	public static bool IsDigit(Char ch) { }

	// RVA: 0x11AF3CC
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0x11AF3DC
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0x11AF3EC
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0x11AF3FC
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0x11AF414
	internal static void SplitSurrogateChar(int combinedChar, Char lowChar, Char highChar) { }

	// RVA: 0x11AF44C
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x11AF4E8
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x11AF574
	internal int IsOnlyCharData(string str) { }

	// RVA: 0x11AF678
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x11AF734
	internal int IsPublicId(string str) { }

	// RVA: 0x11AF3B8
	private static bool InRange(int value, int start, int end) { }

}

// Namespace: System.Xml
internal static class XmlComplianceUtil
{
	// Methods

	// RVA: 0x11AF7F0
	public static string NonCDataNormalize(string value) { }

	// RVA: 0x11AFB1C
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

	// RVA: 0x11AFD08
	public static string EncodeName(string name) { }

	// RVA: 0x11B0818
	public static string EncodeLocalName(string name) { }

	// RVA: 0x11B0880
	public static string DecodeName(string name) { }

	// RVA: 0x11AFD70
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0x11B12B8
	private static int FromHex(Char digit) { }

	// RVA: 0x11B12E0
	internal static Byte[] FromBinHexString(string s) { }

	// RVA: 0x11B1368
	internal static Byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0x11B13E0
	internal static string ToBinHexString(Byte[] inArray) { }

	// RVA: 0x11B1450
	public static string VerifyName(string name) { }

	// RVA: 0x11B16E0
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0x11B190C
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0x11B1B88
	public static string VerifyNCName(string name) { }

	// RVA: 0x11B1C10
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0x11B1D80
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0x11B1EA0
	public static string VerifyTOKEN(string token) { }

	// RVA: 0x11B1FD0
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0x11B210C
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0x11B230C
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0x11B2400
	public static string ToString(bool value) { }

	// RVA: 0x11B246C
	public static string ToString(Char value) { }

	// RVA: 0x11B24D8
	public static string ToString(Decimal value) { }

	// RVA: 0x11B2580
	public static string ToString(SByte value) { }

	// RVA: 0x11B25B8
	public static string ToString(Int16 value) { }

	// RVA: 0x11B25F0
	public static string ToString(int value) { }

	// RVA: 0x11B2628
	public static string ToString(Int64 value) { }

	// RVA: 0x11B2660
	public static string ToString(Byte value) { }

	// RVA: 0x11B2698
	public static string ToString(UInt16 value) { }

	// RVA: 0x11B26D0
	public static string ToString(UInt32 value) { }

	// RVA: 0x11B2708
	public static string ToString(UInt64 value) { }

	// RVA: 0x11B2740
	public static string ToString(float value) { }

	// RVA: 0x11B298C
	public static string ToString(Double value) { }

	// RVA: 0x11B2B38
	public static string ToString(TimeSpan value) { }

	// RVA: 0x11B2B88
	public static string ToString(DateTime value, string format) { }

	// RVA: 0x11B2C64
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x11B30C4
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x11B3150
	public static string ToString(Guid value) { }

	// RVA: 0x11B3178
	public static bool ToBoolean(string s) { }

	// RVA: 0x11B3464
	internal static Exception TryToBoolean(string s, bool result) { }

	// RVA: 0x11B3728
	public static Char ToChar(string s) { }

	// RVA: 0x11B37E8
	internal static Exception TryToChar(string s, Char result) { }

	// RVA: 0x11B39A4
	public static Decimal ToDecimal(string s) { }

	// RVA: 0x11B3A1C
	internal static Exception TryToDecimal(string s, Decimal result) { }

	// RVA: 0x11B3BB4
	internal static Decimal ToInteger(string s) { }

	// RVA: 0x11B3C2C
	internal static Exception TryToInteger(string s, Decimal result) { }

	// RVA: 0x11B3DC4
	public static SByte ToSByte(string s) { }

	// RVA: 0x11B3DF8
	internal static Exception TryToSByte(string s, SByte result) { }

	// RVA: 0x11B3F68
	public static Int16 ToInt16(string s) { }

	// RVA: 0x11B3F9C
	internal static Exception TryToInt16(string s, Int16 result) { }

	// RVA: 0x11B410C
	public static int ToInt32(string s) { }

	// RVA: 0x11B4140
	internal static Exception TryToInt32(string s, int result) { }

	// RVA: 0x11B42B0
	public static Int64 ToInt64(string s) { }

	// RVA: 0x11B42E4
	internal static Exception TryToInt64(string s, Int64 result) { }

	// RVA: 0x11B4454
	public static Byte ToByte(string s) { }

	// RVA: 0x11B4488
	internal static Exception TryToByte(string s, Byte result) { }

	// RVA: 0x11B45F8
	public static UInt16 ToUInt16(string s) { }

	// RVA: 0x11B462C
	internal static Exception TryToUInt16(string s, UInt16 result) { }

	// RVA: 0x11B479C
	public static UInt32 ToUInt32(string s) { }

	// RVA: 0x11B47D0
	internal static Exception TryToUInt32(string s, UInt32 result) { }

	// RVA: 0x11B4940
	public static UInt64 ToUInt64(string s) { }

	// RVA: 0x11B4974
	internal static Exception TryToUInt64(string s, UInt64 result) { }

	// RVA: 0x11B4AE4
	public static float ToSingle(string s) { }

	// RVA: 0x11B4CA0
	internal static Exception TryToSingle(string s, float result) { }

	// RVA: 0x11B4F74
	public static Double ToDouble(string s) { }

	// RVA: 0x11B5104
	internal static Exception TryToDouble(string s, Double result) { }

	// RVA: 0x11B53D8
	internal static Double ToXPathDouble(object o) { }

	// RVA: 0x11B56F0
	internal static Double XPathRound(Double value) { }

	// RVA: 0x11B57F8
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0x11B5994
	internal static Exception TryToTimeSpan(string s, TimeSpan result) { }

	// RVA: 0x11B5A58
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0x11B5B34
	private static void CreateAllDateTimeFormats() { }

	// RVA: 0x11B60F8
	public static DateTime ToDateTime(string s) { }

	// RVA: 0x11B6208
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0x11B62DC
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x11B6540
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0x11B660C
	public static Guid ToGuid(string s) { }

	// RVA: 0x11B663C
	internal static Exception TryToGuid(string s, Guid result) { }

	// RVA: 0x11B2EAC
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x11B2FB8
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x11B6814
	internal static Uri ToUri(string s) { }

	// RVA: 0x11B6A4C
	internal static Exception TryToUri(string s, Uri result) { }

	// RVA: 0x11B6CF4
	internal static bool StrEqual(Char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0x11B33DC
	internal static string TrimString(string value) { }

	// RVA: 0x11B6DD0
	internal static string TrimStringStart(string value) { }

	// RVA: 0x11B6E58
	internal static string TrimStringEnd(string value) { }

	// RVA: 0x11B6EE0
	internal static string[] SplitString(string value) { }

	// RVA: 0x11B28F0
	internal static bool IsNegativeZero(Double value) { }

	// RVA: 0x11B6F6C
	private static Int64 DoubleToInt64Bits(Double value) { }

	// RVA: 0x11B6F74
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0x11B7180
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x11B75EC
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x11B773C
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0x11B1A4C
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x11B7860
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi) { }

	// RVA: 0x11B792C
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType) { }

	// RVA: 0x11B726C
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x11B79AC
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi) { }

	// RVA: 0x11B7A70
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType) { }

	// RVA: 0x11B7AE0
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x11B73FC
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0x11B7BE8
	internal static Exception CreateInvalidCharException(Char invChar, Char nextChar) { }

	// RVA: 0x11B7C54
	internal static Exception CreateInvalidCharException(Char invChar, Char nextChar, ExceptionType exceptionType) { }

	// RVA: 0x11B15B8
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0x11B7D4C
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0x11B7E18
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Uri uri; // 0x10

	// Methods

	// RVA: 0x11B8B2C
	public void .ctor() { }

	// RVA: 0x11B8CC0
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

	// RVA: 0x11B8D4C
	private void MoveNext() { }

	// RVA: 0x11B9604
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Xml
internal class XmlDownloadManager
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x11B7F9C
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11B809C
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11B881C
	internal void Remove(string host) { }

	// RVA: 0x11B89AC
	internal System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11B8B34
	private System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11B8CB8
	public void .ctor() { }

}

// Namespace: System.Xml
internal class OpenedHost
{
	// Fields
	internal int nonCachedConnectionsCount; // 0x10

	// Methods

	// RVA: 0x11B85F0
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

	// RVA: 0x11B85F8
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0x11B9684
	protected override void Finalize() { }

	// RVA: 0x11B9734
	protected override void Dispose(bool disposing) { }

	// RVA: 0x11B9880
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x11B98A8
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x11B98D0
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x11B98F8
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x11B9920
	public override void Flush() { }

	// RVA: 0x11B9948
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x11B9970
	public override int ReadByte() { }

	// RVA: 0x11B9998
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x11B99C0
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x11B99E8
	public override void WriteByte(Byte value) { }

	// RVA: 0x11B9A10
	public override bool get_CanRead() { }

	// RVA: 0x11B9A34
	public override bool get_CanSeek() { }

	// RVA: 0x11B9A58
	public override bool get_CanWrite() { }

	// RVA: 0x11B9A7C
	public override Int64 get_Length() { }

	// RVA: 0x11B9AA0
	public override Int64 get_Position() { }

	// RVA: 0x11B9AC4
	public override void set_Position(Int64 value) { }

}

// Namespace: System.Xml
internal class XmlCachedStream
{
	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0x11B86A0
	internal void .ctor(Uri uri, Stream stream) { }

}

// Namespace: System.Xml
internal class UTF16Decoder
{
	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0x11B9AEC
	public void .ctor(bool bigEndian) { }

	// RVA: 0x11B9B20
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x11B9B30
	public override int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x11B9C20
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11B9DB0
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

}

// Namespace: System.Xml
internal class SafeAsciiDecoder
{
	// Methods

	// RVA: 0x11B9FA4
	public void .ctor() { }

	// RVA: 0x11B9FAC
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x11B9FB4
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11BA034
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

}

// Namespace: System.Xml
internal class Ucs4Encoding
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Methods

	// RVA: 0x11BA0D0
	public override string get_WebName() { }

	// RVA: 0x11BA0DC
	public override Decoder GetDecoder() { }

	// RVA: 0x11BA0E4
	public override int GetByteCount(Char[] chars, int index, int count) { }

	// RVA: 0x11BA14C
	public override int GetByteCount(Char[] chars) { }

	// RVA: 0x11BA16C
	public override Byte[] GetBytes(string s) { }

	// RVA: 0x11BA174
	public override int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	// RVA: 0x11BA17C
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x11BA184
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x11BA1A8
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11BA1CC
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x11BA1E4
	public override int get_CodePage() { }

	// RVA: 0x11BA1EC
	public override Encoder GetEncoder() { }

	// RVA: 0x11BA1F4
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0x11BA308
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0x11BA41C
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0x11BA530
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0x11BA644
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding1234
{
	// Methods

	// RVA: 0x11BA35C
	public void .ctor() { }

	// RVA: 0x11BA6BC
	public override string get_EncodingName() { }

	// RVA: 0x11BA700
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding4321
{
	// Methods

	// RVA: 0x11BA248
	public void .ctor() { }

	// RVA: 0x11BA7EC
	public override string get_EncodingName() { }

	// RVA: 0x11BA830
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding2143
{
	// Methods

	// RVA: 0x11BA470
	public void .ctor() { }

	// RVA: 0x11BA918
	public override string get_EncodingName() { }

	// RVA: 0x11BA95C
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding3412
{
	// Methods

	// RVA: 0x11BA584
	public void .ctor() { }

	// RVA: 0x11BAA48
	public override string get_EncodingName() { }

	// RVA: 0x11BAA8C
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal abstract class Ucs4Decoder
{
	// Fields
	internal Byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0x11BAB04
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: -1
	internal abstract int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11BAB20
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11BAD28
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

	// RVA: 0x11BB054
	internal void Ucs4ToUTF16(UInt32 code, Char[] chars, int charIndex) { }

	// RVA: 0x11BB0B0
	protected void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder4321
{
	// Methods

	// RVA: 0x11BB120
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11BA77C
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder1234
{
	// Methods

	// RVA: 0x11BB3D8
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11BA64C
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder2143
{
	// Methods

	// RVA: 0x11BB690
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11BA8A8
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder3412
{
	// Methods

	// RVA: 0x11BB948
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11BA9D8
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

	// RVA: 0x11BBC00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11BC2DC
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11BC450
	public void .ctor() { }

	// RVA: 0x11BC468
	public void .ctor(string message) { }

	// RVA: 0x11BC484
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x11BC47C
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11BC494
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11AE3BC
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x11AE158
	internal void .ctor(string res, string arg) { }

	// RVA: 0x11BC788
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x11BC884
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x11BCAF0
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x11BC92C
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x11B74E4
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x11BCAF8
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11B77BC
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11BCC04
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11BCCAC
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11BC6D4
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11BC5D4
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x11BC060
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11AE344
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x11BCD54
	internal static string[] BuildCharExceptionArgs(Char[] data, int length, int invCharIndex) { }

	// RVA: 0x11AE890
	internal static string[] BuildCharExceptionArgs(Char invChar, Char nextChar) { }

	// RVA: 0x11BCDB0
	public int get_LineNumber() { }

	// RVA: 0x11BCDB8
	public int get_LinePosition() { }

	// RVA: 0x11BCDC0
	public override string get_Message() { }

	// RVA: 0x11BCDD8
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

	// RVA: 0x11BCDE0
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

	// RVA: 0x11BD064
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

	// RVA: 0x11BCDE8
	internal void .ctor() { }

	// RVA: 0x11BCDF0
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x11BD0B0
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x11BD0B8
	public virtual string get_DefaultNamespace() { }

	// RVA: 0x11BD144
	public virtual void PushScope() { }

	// RVA: 0x11BD154
	public virtual bool PopScope() { }

	// RVA: 0x11BD250
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x11BD828
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x11BD974
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11BDB38
	public virtual System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11BDE20
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x11BD648
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x11BDE80
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

	// RVA: 0x11BE948
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11BEFB4
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

	// RVA: 0x11BDF70
	public void .ctor() { }

	// RVA: 0x11BE130
	public void .ctor(string name) { }

	// RVA: 0x11BE070
	public void .ctor(string name, string ns) { }

	// RVA: 0x11BE230
	public string get_Namespace() { }

	// RVA: 0x11BE238
	public string get_Name() { }

	// RVA: 0x11BE240
	public override int GetHashCode() { }

	// RVA: 0x11BE594
	public bool get_IsEmpty() { }

	// RVA: 0x11BE5D8
	public override string ToString() { }

	// RVA: 0x11BE64C
	public override bool Equals(object other) { }

	// RVA: 0x11BE85C
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x11BE784
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x11BE8C0
	public static string ToString(string name, string ns) { }

	// RVA: 0x11BE34C
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x11BE940
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0x11BEA04
	private static int GetHashCodeOfString(string s, int length, Int64 additionalEntropy) { }

	// RVA: 0x11BEA24
	internal void Init(string name, string ns) { }

	// RVA: 0x11BEA60
	internal void SetNamespace(string ns) { }

	// RVA: 0x11BEA68
	internal void Verify() { }

	// RVA: 0x11BEB8C
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0x11BEC04
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, string prefix) { }

	// RVA: 0x11BEE88
	internal XmlQualifiedName Clone() { }

	// RVA: 0x11BEF0C
	private static void .cctor() { }

}

// Namespace: System.Xml
public abstract class XmlResolver
{
	// Methods

	// RVA: -1
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x11BEFC8
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x11BF1C4
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0x11BF340
	public virtual System.Threading.Tasks.Task<System.Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x11BF380
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

	// RVA: 0x11BF76C
	private void MoveNext() { }

	// RVA: 0x11BFB88
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

	// RVA: 0x11BF388
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x11BF460
	public void .ctor() { }

	// RVA: 0x11BF468
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x11BF610
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x11BF614
	public override System.Threading.Tasks.Task<System.Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

}

// Namespace: System.Xml
internal static class BinaryCompatibility
{
	// Methods

	// RVA: 0x11BFC08
	public static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

}

// Namespace: System.Xml
internal static class Res
{
	// Methods

	// RVA: 0x11B15B4
	public static string GetString(string name) { }

	// RVA: 0x11AEB10
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

	// RVA: 0x11BFC10
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x11BFC18
	internal bool get_HasLineInfo() { }

	// RVA: 0x11BFC20
	internal int GetCollapsedTextNode(XPathNode[] pageText) { }

	// RVA: 0x11BFC54
	internal int GetRootNode(XPathNode[] pageRoot) { }

	// RVA: 0x11BFC88
	internal int GetXmlNamespaceNode(XPathNode[] pageXmlNmsp) { }

	// RVA: 0x11BFCBC
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x11BFDDC
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

	// RVA: 0x11BFEC4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11C02D4
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11C03C8
	public void .ctor() { }

	// RVA: 0x11C0428
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x11C0590
	internal static XPathException Create(string res) { }

	// RVA: 0x11C06AC
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0x11C07A0
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0x11C08C0
	internal static XPathException Create(string res, string arg, Exception innerException) { }

	// RVA: 0x11C0638
	private void .ctor(string res, string[] args) { }

	// RVA: 0x11C0518
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0x11C0190
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0x11C09C0
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

	// RVA: 0x11C09D8
	internal void .ctor() { }

	// RVA: -1
	public abstract void SetContext(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11C09E0
	public static XPathExpression Compile(string xpath) { }

	// RVA: 0x11C09E8
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

	// RVA: 0x11C0AD8
	public virtual object ValueAs(Type returnType) { }

	// RVA: -1
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11C0AEC
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

	// RVA: 0x11C0AF4
	public override string ToString() { }

	// RVA: 0x11C0B00
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x11C0CC0
	public override object get_TypedValue() { }

	// RVA: 0x11C0FC8
	public override Type get_ValueType() { }

	// RVA: 0x11C1204
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x11C14F4
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x11C17EC
	public override Double get_ValueAsDouble() { }

	// RVA: 0x11C1AE4
	public override int get_ValueAsInt() { }

	// RVA: 0x11C1DDC
	public override Int64 get_ValueAsLong() { }

	// RVA: 0x11C20D4
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11C23DC
	private object System.ICloneable.Clone() { }

	// RVA: 0x11C23EC
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: 0x11C23FC
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x11C25E4
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0x11C2828
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

	// RVA: 0x11C2B5C
	public virtual string get_XmlLang() { }

	// RVA: 0x11C2C4C
	public virtual object get_UnderlyingObject() { }

	// RVA: 0x11C2C54
	public virtual bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: -1
	public abstract bool MoveToFirstAttribute() { }

	// RVA: -1
	public abstract bool MoveToNextAttribute() { }

	// RVA: 0x11C2D38
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: -1
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x11C2DE4
	public bool MoveToFirstNamespace() { }

	// RVA: 0x11C2DF8
	public bool MoveToNextNamespace() { }

	// RVA: -1
	public abstract bool MoveToNext() { }

	// RVA: -1
	public abstract bool MoveToFirstChild() { }

	// RVA: -1
	public abstract bool MoveToParent() { }

	// RVA: 0x11C2E0C
	public virtual void MoveToRoot() { }

	// RVA: -1
	public abstract bool MoveTo(XPathNavigator other) { }

	// RVA: -1
	public abstract bool MoveToId(string id) { }

	// RVA: 0x11C2E40
	public virtual bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x11C2F40
	public virtual bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x11C3138
	public virtual bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x11C3424
	public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x11C36CC
	public virtual bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x11C37D8
	public virtual bool MoveToNext(XPathNodeType type) { }

	// RVA: -1
	public abstract bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x11C3940
	public virtual bool IsDescendant(XPathNavigator nav) { }

	// RVA: 0x11C39E0
	public virtual XmlNodeOrder ComparePosition(XPathNavigator nav) { }

	// RVA: 0x11C3EE4
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11C3F38
	public virtual XPathNodeIterator Select(string xpath) { }

	// RVA: 0x11C3F74
	public virtual XPathNodeIterator Select(XPathExpression expr) { }

	// RVA: 0x11C4038
	public virtual object Evaluate(XPathExpression expr) { }

	// RVA: 0x11C404C
	public virtual object Evaluate(XPathExpression expr, XPathNodeIterator context) { }

	// RVA: 0x11C4234
	public virtual XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x11C42BC
	public virtual XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x11C4354
	public virtual XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x11C43EC
	public virtual XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x11C3310
	internal bool MoveToNonDescendant() { }

	// RVA: 0x11C3D20
	private static int GetDepth(XPathNavigator nav) { }

	// RVA: 0x11C3D68
	private XmlNodeOrder CompareSiblings(XPathNavigator n1, XPathNavigator n2) { }

	// RVA: 0x11C3098
	internal static int GetContentKindMask(XPathNodeType type) { }

	// RVA: 0x11C448C
	internal static int GetKindMask(XPathNodeType type) { }

	// RVA: 0x11C44B0
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x11C44C0
	protected void .ctor() { }

	// RVA: 0x11C44C8
	private static void .cctor() { }

}

// Namespace: System.Xml.XPath
internal class XPathNavigatorKeyComparer
{
	// Methods

	// RVA: 0x11C465C
	private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0x11C4748
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x11C4654
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

	// RVA: 0x11C4A34
	public void .ctor(XPathNodeIterator original) { }

	// RVA: 0x11C4A90
	public virtual object get_Current() { }

	// RVA: 0x11C4BD4
	public virtual bool MoveNext() { }

	// RVA: 0x11C4C74
	public virtual void Reset() { }

}

// Namespace: System.Xml.XPath
public abstract class XPathNodeIterator
{
	// Fields
	internal int count; // 0x10

	// Methods

	// RVA: 0x11C4924
	private object System.ICloneable.Clone() { }

	// RVA: -1
	public abstract XPathNodeIterator Clone() { }

	// RVA: -1
	public abstract bool MoveNext() { }

	// RVA: -1
	public abstract XPathNavigator get_Current() { }

	// RVA: -1
	public abstract int get_CurrentPosition() { }

	// RVA: 0x11C4930
	public virtual int get_Count() { }

	// RVA: 0x11C49A8
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11C4A80
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

	// RVA: 0x11C4C7C
	public static string MakePascal(string identifier) { }

	// RVA: 0x11C4E90
	public static string MakeValid(string identifier) { }

	// RVA: 0x11C5128
	private static bool IsValidStart(Char c) { }

	// RVA: 0x11C50A8
	private static bool IsValid(Char c) { }

	// RVA: 0x11C5198
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlSerializerNamespaces
{
	// Fields
	private Hashtable namespaces; // 0x10

	// Methods

	// RVA: 0x11C5220
	public void .ctor() { }

	// RVA: 0x11C5228
	public void Add(string prefix, string ns) { }

	// RVA: 0x11C53A0
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0x11C54C8
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0x11C5AE8
	public int get_Count() { }

	// RVA: 0x11C55D0
	internal ArrayList get_NamespaceList() { }

	// RVA: 0x11C5440
	internal Hashtable get_Namespaces() { }

	// RVA: 0x11C5B70
	internal void set_Namespaces(Hashtable value) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlAttributeEventHandler
{
	// Methods

	// RVA: 0x11C5B78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11C5C9C
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

	// RVA: 0x11C5CB0
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlElementEventHandler
{
	// Methods

	// RVA: 0x11C5D70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11C5E94
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

	// RVA: 0x11C5EA8
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlNodeEventHandler
{
	// Methods

	// RVA: 0x11C5F68
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11C608C
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

	// RVA: 0x11C60A0
	internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

// Namespace: System.Xml.Serialization
public sealed class UnreferencedObjectEventHandler
{
	// Methods

	// RVA: 0x11C614C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11C6270
	public virtual void Invoke(object sender, UnreferencedObjectEventArgs e) { }

}

// Namespace: System.Xml.Serialization
public class UnreferencedObjectEventArgs
{
	// Fields
	private object o; // 0x10
	private string id; // 0x18

	// Methods

	// RVA: 0x11C6284
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

	// RVA: 0x11C6318
	public static void AddField(StringBuilder sb, int n, string val) { }

	// RVA: 0x11C6320
	public static void AddField(StringBuilder sb, int n, string val, string def) { }

	// RVA: 0x11C640C
	public static void AddField(StringBuilder sb, int n, bool val) { }

	// RVA: 0x11C645C
	public static void AddField(StringBuilder sb, int n, bool val, bool def) { }

	// RVA: 0x11C64B0
	public static void AddField(StringBuilder sb, int n, int val, int def) { }

	// RVA: 0x11C6574
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

	// RVA: 0x11C66A0
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x11C676C
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x11C6858
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x11C69BC
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x11C6B34
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x11C6F04
	public void .ctor() { }

	// RVA: 0x11C6FA0
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

	// RVA: 0x11C7020
	public void .ctor(string namspace, Type[] includedTypes) { }

	// RVA: 0x11C7078
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

	// RVA: 0x11C716C
	public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0x11C72B8
	public override bool Equals(object o) { }

	// RVA: 0x11C73A0
	public override int GetHashCode() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeConvertorAttribute
{
	// Fields
	private string <Method>k__BackingField; // 0x10

	// Methods

	// RVA: 0x11C73C4
	public string get_Method() { }

	// RVA: 0x11C73CC
	private void set_Method(string value) { }

	// RVA: 0x11C73D4
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

	// RVA: 0x11C7408
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x11C7414
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x11C7A8C
	private void LookupTypeConvertor() { }

	// RVA: 0x11C7B50
	internal void ConvertForAssignment(object value) { }

	// RVA: 0x11C7C48
	public string get_TypeName() { }

	// RVA: 0x11C7C50
	public string get_XmlType() { }

	// RVA: 0x11C7C58
	public Type get_Type() { }

	// RVA: 0x11C7C60
	public string get_FullTypeName() { }

	// RVA: 0x11C7C68
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x11C6EF4
	public bool get_IsListType() { }

	// RVA: 0x11C7C70
	public bool get_IsComplexType() { }

	// RVA: 0x11C7CA8
	public bool get_IsValueType() { }

	// RVA: 0x11C7D70
	public bool get_IsNullable() { }

	// RVA: 0x11C7F18
	public void set_IsNullable(bool value) { }

	// RVA: 0x11C782C
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x11C7F20
	public Type get_ListItemType() { }

	// RVA: 0x11C7C98
	public bool get_IsXsdType() { }

	// RVA: 0x11C8B94
	public bool get_HasPublicConstructor() { }

	// RVA: 0x11C8920
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x11C8A64
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x11C86F4
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x11C8B9C
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
internal sealed class TypeMember
{
	// Fields
	private Type type; // 0x10
	private string member; // 0x18

	// Methods

	// RVA: 0x11C9B90
	internal void .ctor(Type type, string member) { }

	// RVA: 0x11C9BE0
	public override int GetHashCode() { }

	// RVA: 0x11C9C30
	public override bool Equals(object obj) { }

	// RVA: 0x11C9D20
	public static bool Equals(TypeMember tm1, TypeMember tm2) { }

	// RVA: 0x11C9E08
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

	// RVA: 0x11C9E70
	private static void .cctor() { }

	// RVA: 0x11C6E8C
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x11CC1D8
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType) { }

	// RVA: 0x11CCDB4
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x11CCE3C
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x11CD070
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x11C7978
	public static string GetArrayName(string elemName) { }

	// RVA: 0x11CD154
	public static void ParseArrayType(string arrayType, string type, string ns, string dimensions) { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyAttributeAttribute
{
	// Methods

	// RVA: 0x11CD2F0
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

	// RVA: 0x11CD2F8
	public void .ctor() { }

	// RVA: 0x11CD308
	public string get_Name() { }

	// RVA: 0x11CD374
	public string get_Namespace() { }

	// RVA: 0x11CD37C
	public int get_Order() { }

	// RVA: 0x11CD384
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyElementAttributes
{
	// Methods

	// RVA: 0x11CD420
	public XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x11CD540
	public int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x11CD604
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11CD6E0
	internal int get_Order() { }

	// RVA: 0x11CD9AC
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

	// RVA: 0x11CD9B4
	public string get_ElementName() { }

	// RVA: 0x11CDA20
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11CDA28
	public bool get_IsNullable() { }

	// RVA: 0x11CDA30
	public string get_Namespace() { }

	// RVA: 0x11CDA38
	public int get_Order() { }

	// RVA: 0x11CDA40
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

	// RVA: 0x11CDB6C
	public string get_DataType() { }

	// RVA: 0x11CDBD8
	public string get_ElementName() { }

	// RVA: 0x11CDC44
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11CDC4C
	public string get_Namespace() { }

	// RVA: 0x11CDC54
	public bool get_IsNullable() { }

	// RVA: 0x11CDC5C
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x11CDC64
	public Type get_Type() { }

	// RVA: 0x11CDC6C
	public int get_NestingLevel() { }

	// RVA: 0x11CDC74
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlArrayItemAttributes
{
	// Methods

	// RVA: 0x11CDDE4
	public XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x11CDF04
	public int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x11CDFC8
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11CE0A4
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

	// RVA: 0x11CE0AC
	public void .ctor(string attributeName) { }

	// RVA: 0x11CE0E0
	public string get_AttributeName() { }

	// RVA: 0x11CE14C
	public string get_DataType() { }

	// RVA: 0x11CE1B8
	public void set_DataType(string value) { }

	// RVA: 0x11CE1C0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11CE1C8
	public string get_Namespace() { }

	// RVA: 0x11CE1D0
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlAttributeOverrides
{
	// Fields
	private Hashtable overrides; // 0x10

	// Methods

	// RVA: 0x11CE310
	public void .ctor() { }

	// RVA: 0x11CE388
	public XmlAttributes get_Item(Type type) { }

	// RVA: 0x11CE3EC
	public XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x11CE4E4
	private TypeMember GetKey(Type type, string member) { }

	// RVA: 0x11CE554
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

	// RVA: 0x11CED58
	public void .ctor() { }

	// RVA: 0x11CEE8C
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x11CF8E0
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x11CF8E8
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x11CF8F0
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x11CF8F8
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x11CF900
	public XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x11CF908
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x11CF910
	public object get_XmlDefaultValue() { }

	// RVA: 0x11CF918
	public XmlElementAttributes get_XmlElements() { }

	// RVA: 0x11CF920
	public bool get_XmlIgnore() { }

	// RVA: 0x11CF928
	public bool get_Xmlns() { }

	// RVA: 0x11CF930
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x11CF938
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x11CF940
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x11CEA44
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11D0928
	internal System.Nullable<System.Int32> get_Order() { }

	// RVA: 0x11D0CC4
	internal int get_SortableOrder() { }

}

// Namespace: System.Xml.Serialization
public class XmlChoiceIdentifierAttribute
{
	// Fields
	private string memberName; // 0x10

	// Methods

	// RVA: 0x11D0DA0
	public string get_MemberName() { }

	// RVA: 0x11D08A0
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
internal class XmlCustomFormatter
{
	// Fields
	private static string[] allTimeFormats; // 0x0

	// Methods

	// RVA: 0x11D0E0C
	internal static string FromEnum(Int64 value, string[] values, Int64[] ids, string typeName) { }

	// RVA: 0x11D117C
	internal static string FromXmlName(string name) { }

	// RVA: 0x11D1204
	internal static string FromXmlNCName(string ncName) { }

	// RVA: 0x11CFA24
	internal static string ToXmlString(TypeData type, object value) { }

	// RVA: 0x11D128C
	internal static object FromXmlString(TypeData type, string value) { }

	// RVA: 0x11D1E30
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

	// RVA: 0x11D2390
	public void .ctor(string elementName) { }

	// RVA: 0x11D23CC
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x11D2424
	public string get_DataType() { }

	// RVA: 0x11D2490
	public string get_ElementName() { }

	// RVA: 0x11D24FC
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11D2504
	public string get_Namespace() { }

	// RVA: 0x11D250C
	public bool get_IsNullable() { }

	// RVA: 0x11D2514
	public int get_Order() { }

	// RVA: 0x11D251C
	public Type get_Type() { }

	// RVA: 0x11D2524
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlElementAttributes
{
	// Methods

	// RVA: 0x11D2678
	public XmlElementAttribute get_Item(int index) { }

	// RVA: 0x11CF81C
	public int Add(XmlElementAttribute attribute) { }

	// RVA: 0x11CF948
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11D09F8
	internal int get_Order() { }

	// RVA: 0x11CEE84
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlEnumAttribute
{
	// Fields
	private string name; // 0x10

	// Methods

	// RVA: 0x11D2798
	public void .ctor(string name) { }

	// RVA: 0x11D27CC
	public string get_Name() { }

	// RVA: 0x11D0754
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlIgnoreAttribute
{
	// Methods

	// RVA: 0x11D27D4
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlIncludeAttribute
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0x11D27DC
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

	// RVA: 0x11D27E4
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x11D2834
	public string get_ElementName() { }

	// RVA: 0x11D283C
	public string get_Namespace() { }

	// RVA: 0x11D2844
	public void SetKey(string key) { }

	// RVA: 0x11D284C
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x11D2854
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x11D285C
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x11D2864
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x11D286C
	internal SerializationFormat get_Format() { }

	// RVA: 0x11D2874
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x11D287C
	internal SerializationSource get_Source() { }

}

// Namespace: System.Xml.Serialization
internal class ObjectMap
{
	// Methods

	// RVA: 0x11D2884
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

	// RVA: 0x11D288C
	public int get_Count() { }

	// RVA: 0x11D28AC
	internal bool get_HasWrapperElement() { }

}

// Namespace: System.Xml.Serialization
public class XmlNamespaceDeclarationsAttribute
{
	// Methods

	// RVA: 0x11D28B4
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

	// RVA: 0x11DA660
	private static void .cctor() { }

	// RVA: 0x11DA6CC
	public void .ctor() { }

	// RVA: 0x11DA6D4
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

	// RVA: 0x11D28BC
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x11D2A58
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x11D2C64
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x11D2A64
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11D2C70
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11D5E14
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x11D63A4
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType) { }

	// RVA: 0x11D3114
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType) { }

	// RVA: 0x11D8128
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x11D6440
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11D83FC
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x11D4594
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x11D5430
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11D562C
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11D56FC
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11D5CE4
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11D82A8
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x11D65B4
	private System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x11D75A8
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x11D8B44
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x11D8504
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x11D9D60
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x11D62E8
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x11DA0B0
	public void IncludeType(Type type) { }

	// RVA: 0x11D9B74
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x11DA5C0
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

	// RVA: 0x11D84A0
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x11DA7C4
	public bool get_IsReturnValue() { }

	// RVA: 0x11DA7CC
	public string get_MemberName() { }

	// RVA: 0x11DA7D4
	public Type get_MemberType() { }

	// RVA: 0x11D7524
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x11DA7DC
	internal Type get_DeclaringType() { }

	// RVA: 0x11DA7E4
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

	// RVA: 0x11DA7EC
	public void .ctor() { }

	// RVA: 0x11DA7FC
	public void .ctor(string elementName) { }

	// RVA: 0x11DA838
	public string get_DataType() { }

	// RVA: 0x11DA8A4
	public void set_DataType(string value) { }

	// RVA: 0x11D6338
	public string get_ElementName() { }

	// RVA: 0x11DA8AC
	public void set_ElementName(string value) { }

	// RVA: 0x11DA8B4
	public bool get_IsNullable() { }

	// RVA: 0x11DA8BC
	public void set_IsNullable(bool value) { }

	// RVA: 0x11DA8C4
	public string get_Namespace() { }

	// RVA: 0x11DA8CC
	public void set_Namespace(string value) { }

	// RVA: 0x11D07DC
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSchemaProviderAttribute
{
	// Fields
	private string _methodName; // 0x10
	private bool _isAny; // 0x18

	// Methods

	// RVA: 0x11DA8D4
	public void .ctor(string methodName) { }

	// RVA: 0x11DA908
	public string get_MethodName() { }

	// RVA: 0x11DA910
	public bool get_IsAny() { }

	// RVA: 0x11DA918
	public void set_IsAny(bool value) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationCollectionFixupCallback
{
	// Methods

	// RVA: 0x11DA920
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11DAA44
	public virtual void Invoke(object collection, object collectionItems) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationFixupCallback
{
	// Methods

	// RVA: 0x11DAA58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11DAB78
	public virtual void Invoke(object fixup) { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationGeneratedCode
{
	// Methods

	// RVA: 0x11DAB8C
	protected void .ctor() { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationReadCallback
{
	// Methods

	// RVA: 0x11DAB94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11DAC34
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

	// RVA: 0x11DB5D8
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

	// RVA: 0x11DFAC8
	internal void .ctor(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

	// RVA: 0x11DFB2C
	public XmlSerializationCollectionFixupCallback get_Callback() { }

	// RVA: 0x11DFB34
	public object get_Collection() { }

	// RVA: 0x11DFB3C
	internal object get_Id() { }

	// RVA: 0x11DFB44
	public object get_CollectionItems() { }

	// RVA: 0x11DFB4C
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

	// RVA: 0x11DFB54
	public void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	// RVA: 0x11DFBF8
	public XmlSerializationFixupCallback get_Callback() { }

	// RVA: 0x11DFC00
	public string[] get_Ids() { }

	// RVA: 0x11DFC08
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

	// RVA: 0x11DDCD0
	public void .ctor(Array list, int index, string id) { }

	// RVA: 0x11DFC10
	public Array get_Collection() { }

	// RVA: 0x11DFC18
	public int get_Index() { }

	// RVA: 0x11DFC20
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

	// RVA: 0x11DAC48
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x11DB014
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x11DB088
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x11DB0FC
	protected void .ctor() { }

	// RVA: 0x11DB104
	protected XmlDocument get_Document() { }

	// RVA: 0x11DB1B8
	protected XmlReader get_Reader() { }

	// RVA: 0x11DB1C0
	protected void AddFixup(CollectionFixup fixup) { }

	// RVA: 0x11DB304
	protected void AddFixup(Fixup fixup) { }

	// RVA: 0x11DB3B8
	private void AddFixup(CollectionItemFixup fixup) { }

	// RVA: 0x11DB46C
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x11DB5E0
	protected void AddTarget(string id, object o) { }

	// RVA: 0x11DB780
	private string CurrentTag() { }

	// RVA: 0x11DB90C
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x11DB99C
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x11DBA3C
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x11DBAD0
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x11DBC78
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x11DBD14
	protected bool GetNullAttr() { }

	// RVA: 0x11DBDDC
	protected object GetTarget(string id) { }

	// RVA: 0x11DBEBC
	private bool TargetReady(string id) { }

	// RVA: 0x11DBED8
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1
	protected abstract void InitCallbacks() { }

	// RVA: -1
	protected abstract void InitIDs() { }

	// RVA: 0x11DC0D8
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x11DC17C
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x11DC2FC
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x11DC638
	protected void ReadEndElement() { }

	// RVA: 0x11DC700
	protected bool ReadNull() { }

	// RVA: 0x11DC81C
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x11DC854
	protected string ReadNullableString() { }

	// RVA: 0x11DC8AC
	protected object ReadReferencedElement() { }

	// RVA: 0x11DCC08
	private WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x11DC904
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x11DCD00
	private bool ReadList(object resultList) { }

	// RVA: 0x11DDD28
	protected void ReadReferencedElements() { }

	// RVA: 0x11DEC60
	protected object ReadReferencingElement(string fixupReference) { }

	// RVA: 0x11DDCC4
	protected object ReadReferencingElement(string name, string ns, string fixupReference) { }

	// RVA: 0x11DECCC
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, string fixupReference) { }

	// RVA: 0x11DF0A0
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x11DF268
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x11DD288
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x11DF4F4
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x11DF5F0
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x11DF70C
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x11DC3FC
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x11DF7BC
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x11DF920
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x11DC7E4
	protected void UnknownNode(object o) { }

	// RVA: 0x11DFA84
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x11DF270
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x11DEBC8
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

	// RVA: 0x11E4D00
	public void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

	// RVA: 0x11E5F3C
	public void FixupMembers(object fixup) { }

}

// Namespace: 
private class ReaderCallbackInfo
{
	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x11E0088
	public void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

	// RVA: 0x11E5F68
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

	// RVA: 0x11DFC28
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x11DFC70
	protected override void InitCallbacks() { }

	// RVA: 0x11E00D8
	protected override void InitIDs() { }

	// RVA: 0x11E00DC
	public object ReadRoot() { }

	// RVA: 0x11E02C4
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x11E0414
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x11E01E8
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x11E3604
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x11E3EE4
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x11E4224
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x11E0A8C
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11E0FC8
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x11E4A08
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11E50B8
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x11E54A0
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x11E54D8
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x11E4BE8
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x11E441C
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x11E09C0
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x11E45C0
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x11E4E14
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x11E5510
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x11E42D0
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x11E3770
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x11E5654
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x11E4694
	private void AddListValue(TypeData listType, object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x11E421C
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x11E0950
	private object CreateInstance(Type type) { }

	// RVA: 0x11E4D5C
	private object CreateList(Type listType) { }

	// RVA: 0x11E4C58
	private object InitializeList(TypeData listType) { }

	// RVA: 0x11E59EC
	private void FillList(object list, object items) { }

	// RVA: 0x11E59FC
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x11E35E4
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11E4FF0
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x11E3BB8
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11E3CA8
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11E5898
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x11E3D18
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11E5E48
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationWriteCallback
{
	// Methods

	// RVA: 0x11E5F9C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11E60BC
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

	// RVA: 0x11E9C68
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

	// RVA: 0x11E60D0
	protected void .ctor() { }

	// RVA: 0x11E614C
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x11E6284
	protected XmlWriter get_Writer() { }

	// RVA: 0x11E628C
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x11E63B0
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x11E6450
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x11E64F4
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x11E6584
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x11E6760
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x11E6888
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x11E68C8
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x11E6684
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1
	protected abstract void InitCallbacks() { }

	// RVA: 0x11E6A40
	protected void TopLevelElement() { }

	// RVA: 0x11E6A4C
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x11E6A14
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x11E6A88
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x11E6B34
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x11E6E34
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x11E7138
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x11E7140
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x11E7448
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x11E7450
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x11E7424
	protected void WriteEndElement() { }

	// RVA: 0x11E7628
	protected void WriteEndElement(object o) { }

	// RVA: 0x11E7674
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x11E7AA8
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x11E7B90
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x11E7C68
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x11E7C74
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x11E6D70
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x11E7070
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x11E7C84
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x11E8390
	protected void WriteReferencedElements() { }

	// RVA: 0x11E8290
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x11E85B0
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x11E88BC
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x11E81F8
	private void CheckReferenceQueue() { }

	// RVA: 0x11E8A9C
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x11E8AA4
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x11E8C84
	protected void WriteStartDocument() { }

	// RVA: 0x11E72F4
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x11E81E8
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x11E8CE4
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x11E8CDC
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x11E8CF0
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x11E962C
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x11E9978
	protected void WriteValue(string value) { }

	// RVA: 0x11E99AC
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x11E7304
	protected void WriteXsiType(string name, string ns) { }

}

// Namespace: 
private class CallbackInfo
{
	// Fields
	private XmlSerializationWriterInterpreter _swi; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x11EA0C4
	public void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

	// RVA: 0x11F0B0C
	internal void WriteObject(object ob) { }

	// RVA: 0x11F0B5C
	internal void WriteEnum(object ob) { }

}

// Namespace: System.Xml.Serialization
internal class XmlSerializationWriterInterpreter
{
	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x11E9C70
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x11E9CB8
	protected override void InitCallbacks() { }

	// RVA: 0x11EA114
	public void WriteRoot(object ob) { }

	// RVA: 0x11EA324
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x11EAF3C
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x11EB180
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11EB3CC
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x11EBBA8
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x11EB13C
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11EB474
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11EBC50
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11EC7D4
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x11EC560
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x11ECFC4
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x11EAA44
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x11EEDE8
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x11EF17C
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x11EF444
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11ED5CC
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x11EF63C
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x11EDEB4
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x11F0628
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11F0670
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11ECCD8
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x11F06AC
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

	// RVA: 0x11F1C40
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

	// RVA: 0x11F0BAC
	private static void .cctor() { }

	// RVA: 0x11F0C6C
	public void .ctor(Type type) { }

	// RVA: 0x11F0C80
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11F0E2C
	internal XmlMapping get_Mapping() { }

	// RVA: 0x11F0E34
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0x11F0E58
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0x11F0E7C
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0x11F0EA0
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0x11F0EC4
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0x11F0F04
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0x11F0F44
	public object Deserialize(TextReader textReader) { }

	// RVA: 0x11F0FDC
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0x11F1104
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0x11F13FC
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0x11F161C
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0x11F19F0
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0x11F16B8
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0x11F19F8
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0x11F109C
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

}

// Namespace: System.Xml.Serialization
public class XmlSerializerFactory
{
	// Fields
	private static Hashtable serializersBySource; // 0x0

	// Methods

	// RVA: 0x11F1D4C
	public void .ctor() { }

	// RVA: 0x11F1D54
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0x11F2000
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0x11F1D68
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11F2014
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializerImplementation
{
	// Methods

	// RVA: 0x11F209C
	public virtual XmlSerializationWriter get_Writer() { }

}

// Namespace: System.Xml.Serialization
public class XmlTextAttribute
{
	// Fields
	private string dataType; // 0x10
	private Type type; // 0x18

	// Methods

	// RVA: 0x11F20DC
	public void .ctor() { }

	// RVA: 0x11F20E4
	public string get_DataType() { }

	// RVA: 0x11F2150
	public Type get_Type() { }

	// RVA: 0x11F2158
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

	// RVA: 0x11F21F4
	public bool get_IncludeInSchema() { }

	// RVA: 0x11F21FC
	public string get_Namespace() { }

	// RVA: 0x11F2204
	public string get_TypeName() { }

	// RVA: 0x11F2270
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

	// RVA: 0x11F2320
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x11F23F8
	public TypeData get_TypeData() { }

	// RVA: 0x11F2400
	public object get_ChoiceValue() { }

	// RVA: 0x11F2408
	public void set_ChoiceValue(object value) { }

	// RVA: 0x11F2410
	public string get_ElementName() { }

	// RVA: 0x11F2418
	public void set_ElementName(string value) { }

	// RVA: 0x11F2420
	public string get_Namespace() { }

	// RVA: 0x11F2428
	public void set_Namespace(string value) { }

	// RVA: 0x11EF0D0
	public string get_DataTypeNamespace() { }

	// RVA: 0x11EF09C
	public string get_DataTypeName() { }

	// RVA: 0x11F2430
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11F2438
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x11F2440
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x11F2448
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x11F2450
	public bool get_IsNullable() { }

	// RVA: 0x11F2458
	public void set_IsNullable(bool value) { }

	// RVA: 0x11F2460
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x11F2468
	public void set_NestingLevel(int value) { }

	// RVA: 0x11F2470
	public bool get_MultiReferenceType() { }

	// RVA: 0x11F2490
	public bool get_WrappedElement() { }

	// RVA: 0x11F2498
	public void set_WrappedElement(bool value) { }

	// RVA: 0x11F24A0
	public bool get_IsTextElement() { }

	// RVA: 0x11F24F8
	public void set_IsTextElement(bool value) { }

	// RVA: 0x11F25CC
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0x11F262C
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x11F26F4
	public int get_ExplicitOrder() { }

	// RVA: 0x11F26FC
	public void set_ExplicitOrder(int value) { }

	// RVA: 0x11F2704
	public override bool Equals(object other) { }

	// RVA: 0x11F2868
	public override int GetHashCode() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfoList
{
	// Methods

	// RVA: 0x11F2870
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

	// RVA: 0x11F2878
	public void .ctor() { }

	// RVA: 0x11F28FC
	public string get_Name() { }

	// RVA: 0x11F2904
	public void set_Name(string value) { }

	// RVA: 0x11F290C
	public object get_DefaultValue() { }

	// RVA: 0x11F2914
	public void set_DefaultValue(object value) { }

	// RVA: 0x11F291C
	public bool IsReadOnly(Type type) { }

	// RVA: 0x11F2CA0
	public static object GetValue(object ob, string name) { }

	// RVA: 0x11EB2AC
	public object GetValue(object ob) { }

	// RVA: 0x11F2DCC
	public void SetValue(object ob, object value) { }

	// RVA: 0x11F2F1C
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0x11F2A24
	private void InitMember(Type type) { }

	// RVA: 0x11F3050
	public TypeData get_TypeData() { }

	// RVA: 0x11F3058
	public void set_TypeData(TypeData value) { }

	// RVA: 0x11F3060
	public int get_Index() { }

	// RVA: 0x11F3068
	public void set_Index(int value) { }

	// RVA: 0x11F3070
	public int get_GlobalIndex() { }

	// RVA: 0x11F3078
	public void set_GlobalIndex(int value) { }

	// RVA: 0x11EEB90
	public bool get_IsOptionalValueType() { }

	// RVA: 0x11F3080
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0x11F3094
	public bool get_IsReturnValue() { }

	// RVA: 0x11F30A0
	public void set_IsReturnValue(bool value) { }

	// RVA: 0x11F30C0
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0x11EEB9C
	public bool GetValueSpecified(object ob) { }

	// RVA: 0x11F313C
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

	// RVA: 0x11F33E4
	public void .ctor() { }

	// RVA: 0x11F34A0
	public string get_AttributeName() { }

	// RVA: 0x11F34A8
	public void set_AttributeName(string value) { }

	// RVA: 0x11F34B0
	public string get_Namespace() { }

	// RVA: 0x11F34B8
	public void set_Namespace(string value) { }

	// RVA: 0x11F34C0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x11F34C8
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x11F34D0
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

	// RVA: 0x11F34D8
	public void .ctor() { }

	// RVA: 0x11ECF3C
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x11F355C
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x11F3564
	public string get_ChoiceMember() { }

	// RVA: 0x11F356C
	public void set_ChoiceMember(string value) { }

	// RVA: 0x11F3574
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x11F357C
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0x11EE4D0
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0x11F3584
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x11F3594
	public bool get_IsXmlTextCollector() { }

	// RVA: 0x11F359C
	public void set_IsXmlTextCollector(bool value) { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberList
{
	// Methods

	// RVA: 0x11F35A4
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberExpandable
{
	// Fields
	private int _flatArrayIndex; // 0x78

	// Methods

	// RVA: 0x11F3628
	public int get_FlatArrayIndex() { }

	// RVA: 0x11F3630
	public void set_FlatArrayIndex(int value) { }

	// RVA: 0x11F3638
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberFlatList
{
	// Fields
	private ListMap _listMap; // 0x80

	// Methods

	// RVA: 0x11F36BC
	public ListMap get_ListMap() { }

	// RVA: 0x11F36C4
	public void set_ListMap(ListMap value) { }

	// RVA: 0x11F36CC
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyElement
{
	// Methods

	// RVA: 0x11F0254
	public bool IsElementDefined(string name, string ns) { }

	// RVA: 0x11F3750
	public bool get_IsDefaultAny() { }

	// RVA: 0x11F3AE8
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyAttribute
{
	// Methods

	// RVA: 0x11F3B6C
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberNamespaces
{
	// Methods

	// RVA: 0x11F3BF0
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

	// RVA: 0x11F3C74
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0x11F0764
	public string get_TypeFullName() { }

	// RVA: 0x11F3D50
	internal TypeData get_TypeData() { }

	// RVA: 0x11F3D58
	internal string get_XmlType() { }

	// RVA: 0x11F3D60
	internal void set_XmlType(string value) { }

	// RVA: 0x11EAED0
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x11F3D68
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0x11F3D70
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x11F3D80
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x11F3D88
	internal bool get_MultiReferenceType() { }

	// RVA: 0x11F3D90
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x11F3D98
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0x11F3DA0
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0x11F3DA8
	internal bool get_IsNullable() { }

	// RVA: 0x11F3DB0
	internal void set_IsNullable(bool value) { }

	// RVA: 0x11F3DB8
	internal bool get_IsAny() { }

	// RVA: 0x11F3DC0
	internal void set_IsAny(bool value) { }

	// RVA: 0x11EAD40
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0x11F3DC8
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0x11F4190
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

	// RVA: 0x11F4258
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

	// RVA: 0x11F4B20
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x11F5940
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x11F59F8
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x11F5B2C
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x11F5EE8
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x11F5858
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x11F6270
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x11F666C
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x11F6674
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x11F667C
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x11EC8A4
	public ICollection get_AttributeMembers() { }

	// RVA: 0x11F6684
	public ICollection get_ElementMembers() { }

	// RVA: 0x11F668C
	public ArrayList get_AllMembers() { }

	// RVA: 0x11F6694
	public ArrayList get_FlatLists() { }

	// RVA: 0x11F669C
	public ArrayList get_ListMembers() { }

	// RVA: 0x11F66A4
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x11F66AC
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x11F66B4
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x11F6974
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x11F697C
	public bool get_HasSimpleContent() { }

	// RVA: 0x11F69F0
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class ListMap
{
	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Methods

	// RVA: 0x11F6AA8
	public void set_ChoiceMember(string value) { }

	// RVA: 0x11F6AB0
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x11F6AB8
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x11EFA1C
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x11F6AC0
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x11F6DCC
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x11EF774
	public void GetArrayType(int itemCount, string localName, string ns) { }

	// RVA: 0x11F70EC
	public override bool Equals(object other) { }

	// RVA: 0x11F7250
	public override int GetHashCode() { }

	// RVA: 0x11F7258
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

	// RVA: 0x11F77C8
	public void .ctor(string xmlName, string enumName, Int64 value) { }

	// RVA: 0x11F7824
	public string get_XmlName() { }

	// RVA: 0x11F782C
	public string get_EnumName() { }

	// RVA: 0x11F7834
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

	// RVA: 0x11F7260
	public void .ctor(EnumMapMember[] members, bool isFlags) { }

	// RVA: 0x11F7410
	public bool get_IsFlags() { }

	// RVA: 0x11F7418
	public string[] get_EnumNames() { }

	// RVA: 0x11F7420
	public string[] get_XmlNames() { }

	// RVA: 0x11F7428
	public Int64[] get_Values() { }

	// RVA: 0x11F0784
	public string GetXmlName(string typeName, object enumValue) { }

	// RVA: 0x11F7430
	public string GetEnumName(string typeName, string xmlName) { }

}

// Namespace: System.Xml.XmlConfiguration
public sealed class XmlReaderSection
{
	// Methods

	// RVA: 0x11F783C
	internal static bool get_ProhibitDefaultUrlResolver() { }

	// RVA: 0x11F7844
	internal static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x11F789C
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

	// RVA: 0x11F78A4
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

	// RVA: 0x11F78AC
	public void Clear() { }

	// RVA: 0x11F78BC
	internal int get_Count() { }

	// RVA: 0x11F78C4
	public string GetResult() { }

	// RVA: 0x11F79C4
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

	// RVA: 0x11F7B5C
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0x11F7B64
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0x11F7BB0
	internal void SetDepth(int depth) { }

	// RVA: 0x11F7BB8
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0x11F7CFC
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

	// RVA: 0x11F7FD4
	internal ForwardAxis get_Subtree() { }

	// RVA: 0x11F7FDC
	internal int get_Length() { }

	// RVA: 0x11F8004
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0x11F80DC
	internal void Push(int depth) { }

	// RVA: 0x11F8180
	internal void Pop() { }

	// RVA: 0x11F7F30
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0x11F81CC
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0x11F8380
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0x11F8504
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

	// RVA: 0x11F86EC
	public int get_CurrentDepth() { }

	// RVA: 0x11F86F4
	internal void Reactivate() { }

	// RVA: 0x11F8708
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0x11F88CC
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0x11F8A14
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0x11F8B30
	public bool MoveToAttribute(string localname, string URN) { }

}

// Namespace: System.Xml.Schema
internal class DoubleLinkAxis
{
	// Fields
	internal Axis next; // 0x40

	// Methods

	// RVA: 0x11F8C3C
	internal Axis get_Next() { }

	// RVA: 0x11F8C44
	internal void set_Next(Axis value) { }

	// RVA: 0x11F8C4C
	internal void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x11F8CE0
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

	// RVA: 0x11F8E00
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x11F8E08
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0x11F8E10
	internal bool get_IsAttribute() { }

	// RVA: 0x11F8E18
	internal bool get_IsDss() { }

	// RVA: 0x11F8E20
	internal bool get_IsSelfAxis() { }

	// RVA: 0x11F8E28
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

	// RVA: 0x11F8FEC
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0x11F8FF4
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11F98C8
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0x11F7EF4
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0x11F9904
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0x11F8FA4
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0x11F9060
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11F994C
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

// Namespace: System.Xml.Schema
internal class AutoValidator
{
	// Methods

	// RVA: 0x11F9A88
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x11F9C20
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x11F9C28
	public override void Validate() { }

	// RVA: 0x11FA2B8
	public override void CompleteValidation() { }

	// RVA: 0x11FA2BC
	public override object FindId(string name) { }

	// RVA: 0x11F9D20
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

	// RVA: 0x11FA388
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x11FA410
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x11FA4E8
	protected XmlNameTable get_NameTable() { }

	// RVA: 0x11FA4F0
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x11FA594
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x11FA59C
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x11FA5A4
	protected bool get_HasErrors() { }

	// RVA: 0x11FA5B4
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x11FAA18
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11FACD0
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11FAB74
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11FAF1C
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0x11FAE18
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0x11FB0E4
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0x11FB25C
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0x11FB39C
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x11FB52C
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x11FB5B4
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x11FB660
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x11FB018
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x11FB6F8
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

	// RVA: 0x11FB7B0
	public void .ctor(BaseValidator other) { }

	// RVA: 0x11F9B1C
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x11FB86C
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x11FB874
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x11FB87C
	public XmlNameTable get_NameTable() { }

	// RVA: 0x11FA2C4
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x11FB884
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x11FB88C
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x11FB894
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x11FB89C
	public Uri get_BaseUri() { }

	// RVA: 0x11FB8A4
	public void set_BaseUri(Uri value) { }

	// RVA: 0x11FB8AC
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x11FB990
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0x11FB998
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x11FBA84
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x11FBA8C
	public virtual void Validate() { }

	// RVA: 0x11FBA90
	public virtual void CompleteValidation() { }

	// RVA: 0x11FBA94
	public virtual object FindId(string name) { }

	// RVA: 0x11FBA9C
	public void ValidateText() { }

	// RVA: 0x11FBF98
	public void ValidateWhitespace() { }

	// RVA: 0x11FBF20
	private void SaveTextValue(string value) { }

	// RVA: 0x11FC0D8
	protected void SendValidationEvent(string code) { }

	// RVA: 0x11FBE38
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x11FBD50
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0x11FC13C
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x11FC22C
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x11FC318
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x11FC144
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x11FC404
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0x11FC5CC
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0x11FC7D0
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

}

// Namespace: System.Xml.Schema
internal sealed class BitSet
{
	// Fields
	private int count; // 0x10
	private UInt32[] bits; // 0x18

	// Methods

	// RVA: 0x11FCA10
	private void .ctor() { }

	// RVA: 0x11FCA18
	public void .ctor(int count) { }

	// RVA: 0x11FCA9C
	public int get_Count() { }

	// RVA: 0x11FCAA4
	public bool get_Item(int index) { }

	// RVA: 0x11FCB54
	public void Clear() { }

	// RVA: 0x11FCBAC
	public void Set(int index) { }

	// RVA: 0x11FCAFC
	public bool Get(int index) { }

	// RVA: 0x11FCCC8
	public int NextSet(int startFrom) { }

	// RVA: 0x11FCD68
	public void And(BitSet other) { }

	// RVA: 0x11FCE98
	public void Or(BitSet other) { }

	// RVA: 0x11FCF48
	public override int GetHashCode() { }

	// RVA: 0x11FCF84
	public override bool Equals(object obj) { }

	// RVA: 0x11FD0F8
	public BitSet Clone() { }

	// RVA: 0x11FD1F8
	public bool get_IsEmpty() { }

	// RVA: 0x11FD2B4
	public bool Intersects(BitSet other) { }

	// RVA: 0x11FCA94
	private int Subscript(int bitIndex) { }

	// RVA: 0x11FCC14
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

	// RVA: 0x11FD390
	public void .ctor(string ns, XmlSchema originalSchema) { }

	// RVA: 0x11FD428
	public override int GetHashCode() { }

	// RVA: 0x11FD4B8
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

	// RVA: 0x11FD5C4
	public ConstraintRole get_Role() { }

	// RVA: 0x11FD5CC
	public Asttree get_Selector() { }

	// RVA: 0x11FD5D4
	public Asttree[] get_Fields() { }

	// RVA: 0x11FD5DC
	private void .ctor() { }

	// RVA: 0x11FD670
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11FDBEC
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

	// RVA: 0x11FDCCC
	internal int get_TableDim() { }

	// RVA: 0x11FDCD4
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

	// RVA: 0x11FDF10
	internal int get_Column() { }

	// RVA: 0x11FDF18
	internal void .ctor(Asttree astfield, KeySequence ks, int column) { }

	// RVA: 0x11FDF60
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

	// RVA: 0x11FDF78
	public int get_lastDepth() { }

	// RVA: 0x11FDE78
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0x11FE02C
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0x11FE080
	public int PushKS(int errline, int errcol) { }

	// RVA: 0x11FE55C
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

	// RVA: 0x11FE4CC
	public void .ctor(KeySequence ks, int dim) { }

}

// Namespace: 
private class DecimalStruct
{
	// Fields
	private bool isDecimal; // 0x10
	private Decimal[] dvalue; // 0x18

	// Methods

	// RVA: 0x11FF0BC
	public bool get_IsDecimal() { }

	// RVA: 0x11FF0C4
	public void set_IsDecimal(bool value) { }

	// RVA: 0x11FF0CC
	public Decimal[] get_Dvalue() { }

	// RVA: 0x11FEC3C
	public void .ctor() { }

	// RVA: 0x11FEBC8
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

	// RVA: 0x11FE600
	public int get_Dim() { }

	// RVA: 0x11FE608
	public bool get_IsList() { }

	// RVA: 0x11FE610
	public bool get_IsDecimal() { }

	// RVA: 0x11FE630
	public Decimal[] get_Dvalue() { }

	// RVA: 0x11FE650
	public object get_Value() { }

	// RVA: 0x11FE658
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0x11FE660
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x11FE800
	public override string ToString() { }

	// RVA: 0x11FE808
	public void SetDecimal() { }

	// RVA: 0x11FECAC
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0x11FEDE0
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

	// RVA: 0x11FE434
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x11FF0D4
	public int get_PosLine() { }

	// RVA: 0x11FF0DC
	public int get_PosCol() { }

	// RVA: 0x11FF0E4
	public object get_Item(int index) { }

	// RVA: 0x11FF118
	public void set_Item(int index, object value) { }

	// RVA: 0x11FF218
	internal bool IsQualified() { }

	// RVA: 0x11FF2A0
	public override int GetHashCode() { }

	// RVA: 0x11FF608
	public override bool Equals(object other) { }

	// RVA: 0x11FF704
	public override string ToString() { }

}

// Namespace: System.Xml.Schema
internal class UpaException
{
	// Fields
	private object particle1; // 0x90
	private object particle2; // 0x98

	// Methods

	// RVA: 0x11FF83C
	public void .ctor(object particle1, object particle2) { }

	// RVA: 0x11FF8D0
	public object get_Particle1() { }

	// RVA: 0x11FF8D8
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

	// RVA: 0x11FF8E0
	public void .ctor() { }

	// RVA: 0x11FF998
	public int get_Count() { }

	// RVA: 0x11FF9A4
	public bool get_IsUpaEnforced() { }

	// RVA: 0x11FF9AC
	public void set_IsUpaEnforced(bool value) { }

	// RVA: 0x11FF9B4
	public int AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x11FFAF4
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	// RVA: 0x11FFE94
	private void AddWildcard(string wildcard, object particle) { }

	// RVA: 0x1200024
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0x12007A8
	public int get_Item(XmlQualifiedName name) { }

	// RVA: 0x12008AC
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x12008E0
	public object GetParticle(int symbol) { }

	// RVA: 0x1200920
	public string NameOf(int symbol) { }

}

// Namespace: System.Xml.Schema
internal struct Position
{
	// Fields
	public int symbol; // 0x10
	public object particle; // 0x18

	// Methods

	// RVA: 0x1200FDC
	public void .ctor(int symbol, object particle) { }

}

// Namespace: System.Xml.Schema
internal class Positions
{
	// Fields
	private ArrayList positions; // 0x10

	// Methods

	// RVA: 0x1200FEC
	public int Add(int symbol, object particle) { }

	// RVA: 0x12010A0
	public Position get_Item(int pos) { }

	// RVA: 0x120113C
	public int get_Count() { }

	// RVA: 0x1201164
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

	// RVA: 0x12011DC
	public virtual bool get_IsRangeNode() { }

	// RVA: 0x12011E4
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class LeafNode
{
	// Fields
	private int pos; // 0x10

	// Methods

	// RVA: 0x12011EC
	public void .ctor(int pos) { }

	// RVA: 0x1201218
	public int get_Pos() { }

	// RVA: 0x1201220
	public void set_Pos(int value) { }

	// RVA: 0x1201228
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x120122C
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x12012F0
	public override bool get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal class NamespaceListNode
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Methods

	// RVA: 0x12012F8
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0x1201348
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0x120136C
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x12018A0
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x12018E0
	public override bool get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal abstract class InteriorNode
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Methods

	// RVA: 0x1201920
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x1201928
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x1201930
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x1201938
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0x1201940
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1201B7C
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1201BF0
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

	// RVA: 0x1202348
	public void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

}

// Namespace: System.Xml.Schema
internal sealed class SequenceNode
{
	// Methods

	// RVA: 0x1201BF8
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x12023B8
	public override bool get_IsNullable() { }

	// RVA: 0x120250C
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1202510
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class ChoiceNode
{
	// Methods

	// RVA: 0x1202518
	private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x120268C
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x120283C
	public override bool get_IsNullable() { }

	// RVA: 0x12028D0
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1201898
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class PlusNode
{
	// Methods

	// RVA: 0x12028D4
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1202A3C
	public override bool get_IsNullable() { }

	// RVA: 0x1202A60
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class QmarkNode
{
	// Methods

	// RVA: 0x1202A68
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1202A8C
	public override bool get_IsNullable() { }

	// RVA: 0x1202A94
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class StarNode
{
	// Methods

	// RVA: 0x1202A9C
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1202C04
	public override bool get_IsNullable() { }

	// RVA: 0x1202C0C
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

	// RVA: 0x1202C14
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0x1202C68
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0x1202CBC
	public Decimal get_Max() { }

	// RVA: 0x1202CC8
	public Decimal get_Min() { }

	// RVA: 0x1202CD4
	public BitSet get_NextIteration() { }

	// RVA: 0x1202CDC
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x1202CE4
	public override bool get_IsRangeNode() { }

	// RVA: 0x1202CEC
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

	// RVA: 0x1202D2C
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x1202D60
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1202DA4
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1202DAC
	public bool get_PreserveWhitespace() { }

	// RVA: 0x1202DC0
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x1202DC8
	public bool get_IsOpen() { }

	// RVA: 0x1202DEC
	public void set_IsOpen(bool value) { }

	// RVA: 0x1202DF4
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x1202DF8
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x1202E2C
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1202E34
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1202E3C
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x1202E44
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x1202EC0
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x12030F4
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

	// RVA: 0x120320C
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x1203288
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0x1203310
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1203350
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x1203390
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x12033D0
	public void Start() { }

	// RVA: 0x1203500
	public void OpenGroup() { }

	// RVA: 0x120352C
	public void CloseGroup() { }

	// RVA: 0x12036B8
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x12036F4
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x120391C
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0x1203818
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0x12039C8
	public void AddChoice() { }

	// RVA: 0x1203AC0
	public void AddSequence() { }

	// RVA: 0x1203BB8
	public void AddStar() { }

	// RVA: 0x1203DC0
	public void AddPlus() { }

	// RVA: 0x1203E28
	public void AddQMark() { }

	// RVA: 0x1203E90
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0x1203C20
	private void Closure(InteriorNode node) { }

	// RVA: 0x1204000
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0x1204798
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, BitSet posWithRangeTerminals) { }

	// RVA: 0x12050B8
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0x1204DBC
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0x1205314
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0x1205D80
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0x12053C0
	private Int32[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

}

// Namespace: System.Xml.Schema
internal sealed class DfaContentValidator
{
	// Fields
	private Int32[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x1205CCC
	internal void .ctor(Int32[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1206040
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x12060A8
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x120620C
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1206228
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1206428
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

	// RVA: 0x120662C
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1206728
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1206800
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x12069B8
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1206A04
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1206C00
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

	// RVA: 0x1206D88
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0x1206E98
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1207078
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x1207960
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x120797C
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1207C24
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

	// RVA: 0x1207E5C
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0x1207F90
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0x12080F0
	public override bool get_IsEmptiable() { }

	// RVA: 0x1208110
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x12081B4
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x1208328
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x120838C
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x12087A0
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

	// RVA: 0x1208C6C
	public void .ctor(XmlSchemaSimpleType st, object value) { }

	// RVA: 0x1208CBC
	public XmlSchemaSimpleType get_XmlType() { }

	// RVA: 0x1208CC4
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

	// RVA: 0x1208CCC
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

	// RVA: 0x1211C10
	internal void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0x1211C60
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x1214784
	public static DatatypeImplementation op_Explicit(SchemaDatatypeMap sdm) { }

	// RVA: 0x12147A0
	public string get_Name() { }

	// RVA: 0x12147A8
	public int get_ParentIndex() { }

	// RVA: 0x12147B0
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

	// RVA: 0x1208CD4
	private static void .cctor() { }

	// RVA: 0x12125B4
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x1212630
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x12126AC
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x121274C
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x12127EC
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x12128C4
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x121299C
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x1212A84
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x1211CBC
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x1212CD8
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1212D78
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x1212E5C
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x1213098
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x12132D4
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x1213350
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x12134C8
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x12135F0
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x120F4D8
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x121376C
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x1213918
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x121391C
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x1213BFC
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x1213C24
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x1213D14
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1213D1C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1213D98
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0x1213DF8
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1213E00
	public override Type get_ValueType() { }

	// RVA: 0x1213EA0
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x1213EA8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1213EB0
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x1213EB8
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x1213EE0
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1213F08
	protected DatatypeImplementation get_Base() { }

	// RVA: -1
	internal abstract Type get_ListValueType() { }

	// RVA: -1
	internal abstract RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1213F10
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1213F18
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1214170
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x12142D8
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, object typedValue) { }

	// RVA: 0x1214100
	internal string GetTypeName() { }

	// RVA: 0x1214718
	protected int Compare(Byte[] value1, Byte[] value2) { }

	// RVA: 0x121477C
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_List
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Methods

	// RVA: 0x121482C
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1213678
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x1214B80
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1214E74
	public override Type get_ValueType() { }

	// RVA: 0x1214E84
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1214EA8
	internal override Type get_ListValueType() { }

	// RVA: 0x1214ED0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1214F4C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1214F70
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1214F78
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, object typedValue) { }

	// RVA: 0x1215874
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

	// RVA: 0x1215D90
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1213838
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x1215D9C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1215EA4
	public override Type get_ValueType() { }

	// RVA: 0x1215F20
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1215F28
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1215FA4
	internal override Type get_ListValueType() { }

	// RVA: 0x1216020
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1216028
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x12135FC
	internal bool HasAtomicMembers() { }

	// RVA: 0x1213B54
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x1216030
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1216250
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x121673C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anySimpleType
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1216818
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1216894
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1216910
	public override Type get_ValueType() { }

	// RVA: 0x121698C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1216994
	internal override Type get_ListValueType() { }

	// RVA: 0x1216A10
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1216A18
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1216A20
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1216A28
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1216A88
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120E4F8
	public void .ctor() { }

	// RVA: 0x1216AC4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyAtomicType
{
	// Methods

	// RVA: 0x1216BA0
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1216C1C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1216C24
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12117E0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_untypedAtomicType
{
	// Methods

	// RVA: 0x1216C2C
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1216CA8
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1216CB0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12119F8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_string
{
	// Methods

	// RVA: 0x1216CB8
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1216CC4
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1216CCC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1216D48
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1216D50
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1216D58
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1216D60
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1210A88
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_boolean
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1216E6C
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1216E78
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1216EF4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1216EFC
	public override Type get_ValueType() { }

	// RVA: 0x1216F78
	internal override Type get_ListValueType() { }

	// RVA: 0x1216FF4
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1216FFC
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1217004
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x12170B0
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120E740
	public void .ctor() { }

	// RVA: 0x1217200
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_float
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x12172DC
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x12172E8
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1217364
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121736C
	public override Type get_ValueType() { }

	// RVA: 0x12173E8
	internal override Type get_ListValueType() { }

	// RVA: 0x1217464
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x121746C
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1217474
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1217510
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120F8D4
	public void .ctor() { }

	// RVA: 0x1217698
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_double
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1217774
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1217780
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x12177FC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1217804
	public override Type get_ValueType() { }

	// RVA: 0x1217880
	internal override Type get_ListValueType() { }

	// RVA: 0x12178FC
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1217904
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x121790C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x12179A8
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120F100
	public void .ctor() { }

	// RVA: 0x1217B30
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

	// RVA: 0x1217C0C
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1217C18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1217C94
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1217C9C
	public override Type get_ValueType() { }

	// RVA: 0x1217D18
	internal override Type get_ListValueType() { }

	// RVA: 0x1217D94
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1217D9C
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1217DA4
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1217E7C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120F020
	public void .ctor() { }

	// RVA: 0x121801C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_duration
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1218218
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1218224
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x12182A0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12182A8
	public override Type get_ValueType() { }

	// RVA: 0x1218324
	internal override Type get_ListValueType() { }

	// RVA: 0x12183A0
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x12183A8
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x12183B0
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121845C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120F318
	public void .ctor() { }

	// RVA: 0x121866C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonthDuration
{
	// Methods

	// RVA: 0x1218748
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x121895C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1211AD8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dayTimeDuration
{
	// Methods

	// RVA: 0x1218964
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1218B78
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12118C0
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

	// RVA: 0x1218B80
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1218B8C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1218C08
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1218C10
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x1218CE8
	public override Type get_ValueType() { }

	// RVA: 0x1218D64
	internal override Type get_ListValueType() { }

	// RVA: 0x1218DE0
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1218DE8
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1218DF0
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1218F70
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12192F8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeNoTimeZone
{
	// Methods

	// RVA: 0x120EC90
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeTimeZone
{
	// Methods

	// RVA: 0x120EDC0
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTime
{
	// Methods

	// RVA: 0x120EB60
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeNoTimeZone
{
	// Methods

	// RVA: 0x1210C98
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeTimeZone
{
	// Methods

	// RVA: 0x1210DC8
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_time
{
	// Methods

	// RVA: 0x12193D4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1210B68
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_date
{
	// Methods

	// RVA: 0x12193DC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x120EA30
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonth
{
	// Methods

	// RVA: 0x12193E4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12114F0
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_year
{
	// Methods

	// RVA: 0x12193EC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12113C0
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_monthDay
{
	// Methods

	// RVA: 0x12193F4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1210158
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_day
{
	// Methods

	// RVA: 0x12193FC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x120EEF0
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_month
{
	// Methods

	// RVA: 0x1219404
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1210028
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_hexBinary
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x121940C
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1219418
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1219494
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121949C
	public override Type get_ValueType() { }

	// RVA: 0x1219518
	internal override Type get_ListValueType() { }

	// RVA: 0x1219594
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x121959C
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x12195A4
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x12196B8
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120FAEC
	public void .ctor() { }

	// RVA: 0x12198AC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_base64Binary
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1219988
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1219994
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1219A10
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1219A18
	public override Type get_ValueType() { }

	// RVA: 0x1219A94
	internal override Type get_ListValueType() { }

	// RVA: 0x1219B10
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1219B18
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1219B20
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1219C34
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120E660
	public void .ctor() { }

	// RVA: 0x1219E24
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyURI
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1219F00
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1219F0C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1219F88
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1219F90
	public override Type get_ValueType() { }

	// RVA: 0x121A00C
	internal override bool get_HasValueFacets() { }

	// RVA: 0x121A014
	internal override Type get_ListValueType() { }

	// RVA: 0x121A090
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x121A098
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x121A0A0
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121A16C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120E580
	public void .ctor() { }

	// RVA: 0x121A590
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QName
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x121A66C
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x121A678
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121A6F4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121A6FC
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x121A704
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x121A70C
	public override Type get_ValueType() { }

	// RVA: 0x121A788
	internal override Type get_ListValueType() { }

	// RVA: 0x121A804
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x121A80C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12107F0
	public void .ctor() { }

	// RVA: 0x121AA6C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedString
{
	// Methods

	// RVA: 0x121AB48
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121AB50
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x121AB58
	internal override bool get_HasValueFacets() { }

	// RVA: 0x12105B0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedStringV1Compat
{
	// Methods

	// RVA: 0x121AB60
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121AB68
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1211620
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_token
{
	// Methods

	// RVA: 0x121AB70
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121AB78
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1210EF8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_tokenV1Compat
{
	// Methods

	// RVA: 0x121AB80
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1211700
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_language
{
	// Methods

	// RVA: 0x121AB88
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x120FF44
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NMTOKEN
{
	// Methods

	// RVA: 0x121AB90
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121AB98
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x12104C8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_Name
{
	// Methods

	// RVA: 0x121ABA0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1210288
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NCName
{
	// Methods

	// RVA: 0x121ABA8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121ABB0
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1210368
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ID
{
	// Methods

	// RVA: 0x121ACE4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121ACEC
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x120FBCC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_IDREF
{
	// Methods

	// RVA: 0x121ACF4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121ACFC
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x120FCAC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENTITY
{
	// Methods

	// RVA: 0x121AD04
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121AD0C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x120F3F8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NOTATION
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x121AD14
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x121AD20
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121AD9C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121ADA4
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x121ADAC
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x121ADB4
	public override Type get_ValueType() { }

	// RVA: 0x121AE30
	internal override Type get_ListValueType() { }

	// RVA: 0x121AEAC
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x121AEB4
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x121B114
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x1210690
	public void .ctor() { }

	// RVA: 0x121B3B4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_integer
{
	// Methods

	// RVA: 0x121B490
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121B498
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120FE0C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonPositiveInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x121B614
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121B690
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121B698
	internal override bool get_HasValueFacets() { }

	// RVA: 0x12105AC
	public void .ctor() { }

	// RVA: 0x121B6A0
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_negativeInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x121B7C8
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121B844
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1210448
	public void .ctor() { }

	// RVA: 0x121B84C
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

	// RVA: 0x121B974
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121B9F0
	internal override bool get_HasValueFacets() { }

	// RVA: 0x121B9F8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121BA00
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121BA9C
	public override Type get_ValueType() { }

	// RVA: 0x121BB18
	internal override Type get_ListValueType() { }

	// RVA: 0x121BB94
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1210024
	public void .ctor() { }

	// RVA: 0x121BD1C
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

	// RVA: 0x121BEAC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121BF28
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121BF30
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121BFCC
	public override Type get_ValueType() { }

	// RVA: 0x121C048
	internal override Type get_ListValueType() { }

	// RVA: 0x121C0C4
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120FD8C
	public void .ctor() { }

	// RVA: 0x121C24C
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

	// RVA: 0x121C3DC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121C458
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121C460
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121C4FC
	public override Type get_ValueType() { }

	// RVA: 0x121C578
	internal override Type get_ListValueType() { }

	// RVA: 0x121C5F4
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12109B0
	public void .ctor() { }

	// RVA: 0x121C77C
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

	// RVA: 0x121C90C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121C988
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121C990
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121CA2C
	public override Type get_ValueType() { }

	// RVA: 0x121CAA8
	internal override Type get_ListValueType() { }

	// RVA: 0x121CB24
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120E820
	public void .ctor() { }

	// RVA: 0x121CCAC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonNegativeInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x121CE3C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121CEB8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121CEC0
	internal override bool get_HasValueFacets() { }

	// RVA: 0x12105A8
	public void .ctor() { }

	// RVA: 0x121CEC8
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

	// RVA: 0x121CFF0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121D06C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121D074
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121D110
	public override Type get_ValueType() { }

	// RVA: 0x121D18C
	internal override Type get_ListValueType() { }

	// RVA: 0x121D208
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1211130
	public void .ctor() { }

	// RVA: 0x121D3D4
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

	// RVA: 0x121D57C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121D5F8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121D600
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121D69C
	public override Type get_ValueType() { }

	// RVA: 0x121D718
	internal override Type get_ListValueType() { }

	// RVA: 0x121D794
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1211058
	public void .ctor() { }

	// RVA: 0x121D91C
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

	// RVA: 0x121DAC4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121DB40
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121DB48
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121DBE4
	public override Type get_ValueType() { }

	// RVA: 0x121DC60
	internal override Type get_ListValueType() { }

	// RVA: 0x121DCDC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12111B0
	public void .ctor() { }

	// RVA: 0x121DE64
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

	// RVA: 0x121E00C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121E088
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x121E090
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121E12C
	public override Type get_ValueType() { }

	// RVA: 0x121E1A8
	internal override Type get_ListValueType() { }

	// RVA: 0x121E224
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1210FD8
	public void .ctor() { }

	// RVA: 0x121E3AC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_positiveInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x121E554
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x121E5D0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1210770
	public void .ctor() { }

	// RVA: 0x121E5D8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_doubleXdr
{
	// Methods

	// RVA: 0x121E700
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x120F1E0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_floatXdr
{
	// Methods

	// RVA: 0x121E8F8
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x120F9B4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QNameXdr
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x121EAF0
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x121EAF8
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x121ED88
	public override Type get_ValueType() { }

	// RVA: 0x121EE04
	internal override Type get_ListValueType() { }

	// RVA: 0x12108D0
	public void .ctor() { }

	// RVA: 0x121EE80
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENUMERATION
{
	// Methods

	// RVA: 0x121EF5C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x120F6BC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_char
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x121EF64
	public override Type get_ValueType() { }

	// RVA: 0x121EFE0
	internal override Type get_ListValueType() { }

	// RVA: 0x121F05C
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x121F064
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121F110
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x121F2EC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120E950
	public void .ctor() { }

	// RVA: 0x121F3EC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_fixed
{
	// Methods

	// RVA: 0x121F4C8
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x121FA54
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x120F79C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_uuid
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x121FBE8
	public override Type get_ValueType() { }

	// RVA: 0x121FC64
	internal override Type get_ListValueType() { }

	// RVA: 0x121FCE0
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x121FCE8
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x121FD88
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x121FF64
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12112E0
	public void .ctor() { }

	// RVA: 0x1220064
	private static void .cctor() { }

}

// Namespace: 
private class NamespaceManager
{
	// Methods

	// RVA: 0x1222904
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x12228FC
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

	// RVA: 0x1220140
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x12201E8
	private void Init() { }

	// RVA: 0x12204A0
	public override void Validate() { }

	// RVA: 0x12207BC
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x1220868
	private void ValidatePIComment() { }

	// RVA: 0x122069C
	private void ValidateElement() { }

	// RVA: 0x1220CB4
	private void ValidateChildElement() { }

	// RVA: 0x1220F24
	private void ValidateStartElement() { }

	// RVA: 0x1221938
	private void ValidateEndStartElement() { }

	// RVA: 0x1220DF8
	private void ProcessElement() { }

	// RVA: 0x1221B1C
	public override void CompleteValidation() { }

	// RVA: 0x1220AF4
	private void ValidateEndElement() { }

	// RVA: 0x1221D5C
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1221D98
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1221384
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1222024
	internal void AddID(string name, object node) { }

	// RVA: 0x12220C4
	public override object FindId(string name) { }

	// RVA: 0x1220938
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x12220E0
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x1221C30
	private void CheckForwardRefs() { }

	// RVA: 0x1220358
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1221B74
	private bool Pop() { }

	// RVA: 0x122218C
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x122249C
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x1222874
	private static void .cctor() { }

}

// Namespace: 
private struct Map
{
	// Fields
	internal Char match; // 0x10
	internal string replacement; // 0x18

	// Methods

	// RVA: 0x1227604
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

	// RVA: 0x122305C
	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x12233A0
	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x12237D0
	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1223BC4
	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1223FB8
	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x12241F0
	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x12243F4
	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1224DA0
	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1225040
	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1224860
	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1224B00
	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x12252E0
	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1225764
	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1225AEC
	internal void FinishFacetCompile() { }

	// RVA: 0x122667C
	private void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x1225E90
	internal void CompileFacetCombinations() { }

	// RVA: 0x1226D94
	private void CopyFacetsFromBaseType() { }

	// RVA: 0x12264C0
	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x1226B14
	private static string Preprocess(string pattern) { }

	// RVA: 0x12263B4
	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1226444
	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1226610
	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x12272AC
	private void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x12272EC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class FacetsChecker
{
	// Methods

	// RVA: 0x122290C
	internal virtual Exception CheckLexicalFacets(string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222BCC
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222BD4
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222BDC
	internal virtual Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222BE4
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222BEC
	internal virtual Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222BF4
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222BFC
	internal virtual Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222C04
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222C0C
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222C14
	internal virtual Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222C1C
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222C24
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222954
	internal void CheckWhitespaceFacets(string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222A5C
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x1222C2C
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1222C34
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x1226270
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x12263AC
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

	// RVA: 0x12181CC
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0x1227614
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1227690
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1227E04
	internal override Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1227E9C
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1227F34
	internal override Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1227FCC
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1227CBC
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x121F7A4
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0x1228050
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Numeric2FacetsChecker
{
	// Methods

	// RVA: 0x12280F4
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1228160
	internal override Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x12285D4
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x12285E4
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x12284F0
	private bool MatchEnumeration(Double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x120E4E0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DurationFacetsChecker
{
	// Methods

	// RVA: 0x122870C
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1228828
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1228CD0
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1228BB8
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x120E4F0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DateTimeFacetsChecker
{
	// Methods

	// RVA: 0x1228D54
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1228DC4
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x122936C
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x12291B8
	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x120E4E8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class StringFacetsChecker
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Methods

	// RVA: 0x12293D4
	private static Regex get_LanguagePattern() { }

	// RVA: 0x12294A4
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1229510
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x121A320
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0x1229A50
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x12297D4
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1229518
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x120E4D8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class QNameFacetsChecker
{
	// Methods

	// RVA: 0x106D430
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x106D564
	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x106D8C0
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x106D76C
	private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

	// RVA: 0x106D9DC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class MiscFacetsChecker
{
	// Methods

	// RVA: 0x106D9E4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class BinaryFacetsChecker
{
	// Methods

	// RVA: 0x106D9EC
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x106DA80
	internal override Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x106DDBC
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x106DC74
	private bool MatchEnumeration(Byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x106DE5C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class ListFacetsChecker
{
	// Methods

	// RVA: 0x106DE64
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x106E0D8
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x106E1BC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class UnionFacetsChecker
{
	// Methods

	// RVA: 0x106E1C4
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x106E2D0
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x106E3B4
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

	// RVA: 0x106E3BC
	public void set_Occurrence(InferenceOption value) { }

	// RVA: 0x106E3C4
	public InferenceOption get_Occurrence() { }

	// RVA: 0x106E3CC
	public void set_TypeInference(InferenceOption value) { }

	// RVA: 0x106E3D4
	public void .ctor() { }

	// RVA: 0x106E514
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x106E58C
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x1070B44
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x10735D0
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x106F048
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x106F680
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1074314
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x1073A0C
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x10748E4
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, int lastUsedSeqItem, bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x1073B48
	internal void ProcessAttributes(XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1074830
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x1074450
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x1071794
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x1073670
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, XmlSchema parentSchema) { }

	// RVA: 0x1075A5C
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x10713E0
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x1075BB8
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x107426C
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x1076024
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x1071B04
	internal XmlQualifiedName RefineSimpleType(string s, int iTypeFlags) { }

	// RVA: 0x10761D0
	internal static int InferSimpleType(string s, bool bNeedsRangeCheck) { }

	// RVA: 0x1077634
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x1075D3C
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x1072C74
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x107588C
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x107777C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaInferenceException
{
	// Methods

	// RVA: 0x1078264
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x107826C
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1078274
	public void .ctor() { }

	// RVA: 0x1075F64
	internal void .ctor(string res, string arg) { }

	// RVA: 0x106F010
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

	// RVA: 0x1078280
	public void .ctor() { }

	// RVA: 0x1078288
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x1078534
	public NamespaceList Clone() { }

	// RVA: 0x1078678
	public ListType get_Type() { }

	// RVA: 0x1078680
	public string get_Excluded() { }

	// RVA: 0x1078688
	public ICollection get_Enumerate() { }

	// RVA: 0x10786F8
	public virtual bool Allows(string ns) { }

	// RVA: 0x1078798
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x10787BC
	public override string ToString() { }

	// RVA: 0x1078C9C
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0x1079068
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x10795C4
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0x1079740
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x1079D48
	private void RemoveNamespace(string tns) { }

}

// Namespace: System.Xml.Schema
internal class NamespaceListV1Compat
{
	// Methods

	// RVA: 0x1079DAC
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x1079DB0
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

	// RVA: 0x1079E2C
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1079F34
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0x1079F98
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0x107AAA8
	private bool CheckSchemaRoot(SchemaType rootType, string code) { }

	// RVA: 0x107AC00
	public SchemaType FinishParsing() { }

	// RVA: 0x107AC08
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x107AC10
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x107AC18
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0x107A3D0
	public bool ParseReaderNode() { }

	// RVA: 0x107AC20
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0x107AE68
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0x107B4CC
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0x107B2E8
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x107B5FC
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

	// RVA: 0x107B824
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

	// RVA: 0x107B874
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x107B978
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0x107F134
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x107F820
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x107F8C4
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x107F8CC
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x107F8D4
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x107F8DC
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x107F8E4
	internal XmlSchema get_RootSchema() { }

	// RVA: 0x107CE08
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0x107C01C
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0x107F214
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0x107F95C
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x107FB94
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0x107CF8C
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0x10801F0
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0x107E2F8
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0x1083134
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0x1083098
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0x10800C8
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0x1083910
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0x1083274
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x1083330
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10837F0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x108348C
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x1081448
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10841E0
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1083F1C
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x10815D4
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1082860
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x1084EA8
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x1084AD0
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x1085298
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1082194
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1081750
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x1082AEC
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1082D3C
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x10856A8
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1084654
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x107FDB4
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1083C48
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1084414
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x107F8EC
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x107F930
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0x107BEB8
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x107FCE0
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x107FD04
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x108301C
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

	// RVA: 0x1086084
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x108608C
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0x1086098
	private void .ctor() { }

	// RVA: 0x10860A0
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0x10860A8
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x10860C8
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x10860D0
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0x10860D8
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0x108612C
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x1086134
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0x1086144
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x108621C
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x1086224
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0x108622C
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x1086234
	internal int get_LinePosition() { }

	// RVA: 0x108623C
	internal void set_LinePosition(int value) { }

	// RVA: 0x1086244
	internal int get_LineNumber() { }

	// RVA: 0x108624C
	internal void set_LineNumber(int value) { }

	// RVA: 0x1086254
	internal int get_ValueLinePosition() { }

	// RVA: 0x108625C
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x1086264
	internal int get_ValueLineNumber() { }

	// RVA: 0x108626C
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0x10861B0
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x1086274
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0x1086108
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x108627C
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0x10862B0
	internal Reserve get_Reserved() { }

	// RVA: 0x10862B8
	internal void set_Reserved(Reserve value) { }

	// RVA: 0x10862C0
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x10862C8
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x10862D0
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x10862D8
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0x108656C
	internal SchemaAttDef Clone() { }

	// RVA: 0x10865D4
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

	// RVA: 0x1086640
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

	// RVA: 0x1086648
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0x1086714
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0x1086784
	private void Prepare() { }

	// RVA: 0x1086C10
	private void Cleanup() { }

	// RVA: 0x108B0C4
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0x1087B1C
	private void Compile() { }

	// RVA: 0x1089A9C
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x108B080
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x108AADC
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x108AB2C
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x108AEC4
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x108AEE0
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x1090510
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x108AAA4
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x109060C
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x108B918
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0x1090340
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x108BDAC
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x108D420
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1090C34
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1091124
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x108C694
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x109124C
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x10914E4
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x109195C
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x1091E24
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x10901D8
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x109379C
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0x1090784
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0x1094CF8
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0x1094E60
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0x10953F8
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0x10958B8
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0x1095DBC
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0x1094558
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x109632C
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x1096454
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x10964A8
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x10964F4
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x1096794
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1096B88
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1096EAC
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x1097314
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1098084
	private void CalculateSequenceRange(XmlSchemaSequence sequence, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x10975BC
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1097E9C
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x1097F84
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x1096260
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x10976A4
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x10984B0
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1093924
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x108BEB8
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10921C8
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x1098594
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x10984D8
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x108ECF8
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x108F9F4
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x108DDD4
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x10939C0
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x1098650
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x1098D40
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x1090100
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x1090A84
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x1094470
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x10942D4
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

	// RVA: 0x1098FB0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1098FB8
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0x1099224
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x109C4CC
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x109945C
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0x109C6D8
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x109A158
	private void Preprocess(XmlSchema schema, string targetNamespace, Compositor compositor) { }

	// RVA: 0x109CA0C
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0x109FB54
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0x109F4BC
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x109F564
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x109FA34
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x109F6D0
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x109DBE0
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10A0388
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10A0138
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x109DD6C
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x109ED6C
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x10A0DA0
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x10A0A30
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x10A1120
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x109E76C
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x109DE78
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x109EFF8
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x109F1D8
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x10A14AC
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10A06F0
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x1099EE0
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x109FE64
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x10A054C
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x109C8F8
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x109C91C
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x109C4D4
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x109C5A0
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

	// RVA: 0x10A1E14
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x10A1ED0
	protected void .ctor() { }

	// RVA: 0x10A1F4C
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x10A1F54
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0x10A1F5C
	internal string get_Prefix() { }

	// RVA: 0x10A1FC8
	internal void set_Prefix(string value) { }

	// RVA: 0x10A1FD0
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x10A1FD8
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x10A1FE0
	internal Use get_Presence() { }

	// RVA: 0x10A1FE8
	internal void set_Presence(Use value) { }

	// RVA: 0x10A1FF0
	internal Int64 get_MaxLength() { }

	// RVA: 0x10A1FF8
	internal void set_MaxLength(Int64 value) { }

	// RVA: 0x10A2000
	internal Int64 get_MinLength() { }

	// RVA: 0x10A2008
	internal void set_MinLength(Int64 value) { }

	// RVA: 0x10A2010
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x10A2018
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10A2020
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x10A2028
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0x10A2030
	internal void AddValue(string value) { }

	// RVA: 0x10A20E8
	internal System.Collections.Generic.List<System.String> get_Values() { }

	// RVA: 0x10A20F0
	internal void set_Values(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x10A20F8
	internal string get_DefaultValueRaw() { }

	// RVA: 0x10A2164
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x10A216C
	internal object get_DefaultValueTyped() { }

	// RVA: 0x10A2174
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0x10A217C
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0x10A2244
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

	// RVA: 0x10A229C
	internal void .ctor() { }

	// RVA: 0x10A23CC
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0x10A2554
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x10A2648
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0x10A2748
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x10A2750
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x10A2810
	private System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0x10A2818
	internal bool get_IsIdDeclared() { }

	// RVA: 0x10A2820
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0x10A2828
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0x10A2830
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0x10A2838
	internal SchemaElementDecl Clone() { }

	// RVA: 0x10A28A0
	internal bool get_IsAbstract() { }

	// RVA: 0x10A28A8
	internal void set_IsAbstract(bool value) { }

	// RVA: 0x10A28B0
	internal bool get_IsNillable() { }

	// RVA: 0x10A28B8
	internal void set_IsNillable(bool value) { }

	// RVA: 0x10A28C0
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x10A28C8
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10A28D0
	internal bool get_IsNotationDeclared() { }

	// RVA: 0x10A28D8
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0x10A28E0
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0x10A28F0
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x10A28F8
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x10A2900
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x10A2908
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10A2910
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10A2918
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x10A2920
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x10A2928
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x10A2930
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x10A2938
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0x10A2A64
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x10A2AE8
	internal System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x10A2AF0
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttDefs() { }

	// RVA: 0x10A2AF8
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0x10A2B00
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0x10A2ED0
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

	// RVA: 0x10A2F38
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0x10A2FDC
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0x10A2FFC
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0x10A3004
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x10A300C
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x10A3034
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0x10A303C
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0x10A3114
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x10A31EC
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x10A31F4
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x10A31FC
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x10A3204
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x10A320C
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0x10A3214
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x10A3320
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x10A3328
	internal string get_Url() { }

	// RVA: 0x10A3330
	internal void set_Url(string value) { }

	// RVA: 0x10A3360
	internal string get_Pubid() { }

	// RVA: 0x10A3368
	internal void set_Pubid(string value) { }

	// RVA: 0x10A3370
	internal bool get_IsExternal() { }

	// RVA: 0x10A3378
	internal void set_IsExternal(bool value) { }

	// RVA: 0x10A3380
	internal bool get_DeclaredInExternal() { }

	// RVA: 0x10A3388
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x10A3390
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x10A3398
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x10A33A0
	internal string get_Text() { }

	// RVA: 0x10A33A8
	internal void set_Text(string value) { }

	// RVA: 0x10A33D4
	internal int get_Line() { }

	// RVA: 0x10A33DC
	internal void set_Line(int value) { }

	// RVA: 0x10A33E4
	internal int get_Pos() { }

	// RVA: 0x10A33EC
	internal void set_Pos(int value) { }

	// RVA: 0x10A30A8
	internal string get_BaseURI() { }

	// RVA: 0x10A33F4
	internal void set_BaseURI(string value) { }

	// RVA: 0x10A33FC
	internal bool get_ParsingInProgress() { }

	// RVA: 0x10A3404
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0x10A3180
	internal string get_DeclaredURI() { }

	// RVA: 0x10A340C
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

	// RVA: 0x10A3414
	internal void .ctor() { }

	// RVA: 0x10A3608
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x10A3610
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x10A3618
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x10A3620
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x10A3628
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0x10A3630
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_GeneralEntities() { }

	// RVA: 0x10A36CC
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x10A3768
	internal SchemaType get_SchemaType() { }

	// RVA: 0x10A3770
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x10A3778
	internal System.Collections.Generic.Dictionary<System.String,System.Boolean> get_TargetNamespaces() { }

	// RVA: 0x10A3780
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x10A3788
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0x10A3790
	internal System.Collections.Generic.Dictionary<System.String,System.Xml.Schema.SchemaNotation> get_Notations() { }

	// RVA: 0x10A382C
	internal int get_ErrorCount() { }

	// RVA: 0x10A3834
	internal void set_ErrorCount(int value) { }

	// RVA: 0x10A383C
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0x10A38C0
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0x10A3944
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0x10A39E8
	internal bool HasSchema(string ns) { }

	// RVA: 0x10A3A4C
	internal bool Contains(string ns) { }

	// RVA: 0x10A3AB0
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0x10A3C44
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, AttributeMatchState attributeMatchState) { }

	// RVA: 0x10A3EB8
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, bool skip) { }

	// RVA: 0x10A3FCC
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0x10A4FAC
	internal void Finish() { }

	// RVA: 0x10A5308
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x10A5310
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x10A5318
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x10A53EC
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x10A54BC
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x10A54C4
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

	// RVA: 0x10A54CC
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x10A82C4
	public void CreateTokenToQNameTable() { }

	// RVA: 0x10AA1F4
	public SchemaType SchemaTypeFromRoot(string localName, string ns) { }

	// RVA: 0x10AA2A4
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x10AA2F4
	public bool IsXDRRoot(string localName, string ns) { }

}

// Namespace: System.Xml.Schema
internal class SchemaNamespaceManager
{
	// Fields
	private XmlSchemaObject node; // 0x50

	// Methods

	// RVA: 0x10AA344
	public void .ctor(XmlSchemaObject node) { }

	// RVA: 0x10AA378
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x10AA4C8
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

	// RVA: 0x10AA8D0
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x10AA904
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x10AA90C
	internal string get_SystemLiteral() { }

	// RVA: 0x10AA914
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x10AA91C
	internal string get_Pubid() { }

	// RVA: 0x10AA924
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

	// RVA: 0x10AA92C
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x10AAB7C
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0x10ADD28
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0x10AFD68
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0x10ACBE8
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x10AFEF0
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0x10AAC20
	internal bool Compile() { }

	// RVA: 0x10AF708
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10AF790
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10AF7EC
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10AFCB0
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10AF558
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x10B5490
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x10AF744
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x10B5584
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10B4468
	private void ProcessSubstitutionGroups() { }

	// RVA: 0x10B5730
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x10B5318
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0x10B5408
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0x10B0004
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x10B16C4
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10B6C04
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10B70F4
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x10B0AD0
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10B721C
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x10B74B4
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x10B7968
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x10B7E3C
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x10B4CC8
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x10B60B4
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10B9814
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10B5CF4
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0x10BC62C
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0x10BB3A8
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0x10BB934
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0x10BBC00
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0x10BC130
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0x10BA5D4
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0x10BA828
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10BC9C8
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x10BCC08
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x10BCDC0
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x10BCECC
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x10BD394
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0x10BE480
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0x10BDC64
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x10BE018
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x10BE67C
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x10BEA50
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10BF518
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x10BF600
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x10BC8FC
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x10BECF4
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x10BF700
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10B9994
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x10B010C
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10B81D8
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x10B61A0
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0x10BF8A0
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0x10BF7E4
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x10BF728
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x10B3198
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x10BF9CC
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0x10B3BEC
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x10B20B4
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x10B9A30
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x10BFBBC
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x10C0290
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x10B5F24
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0x10B42F0
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x10B6B04
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x10BA4F8
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x10BA368
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0x10BC878
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0x10BEB38
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

	// RVA: 0x10C0500
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0x10C0580
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x10C060C
	public XmlSeverityType get_Severity() { }

	// RVA: 0x10C0614
	public XmlSchemaException get_Exception() { }

}

// Namespace: System.Xml.Schema
public sealed class ValidationEventHandler
{
	// Methods

	// RVA: 0x10C061C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10C0740
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

	// RVA: 0x10C0754
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

	// RVA: 0x10C5B40
	internal void .ctor() { }

	// RVA: 0x10C6098
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

	// RVA: 0x10CB570
	internal static void Copy(GroupContent from, GroupContent to) { }

	// RVA: 0x10C2060
	internal static GroupContent Copy(GroupContent other) { }

	// RVA: 0x10C0A84
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

	// RVA: 0x10C0A74
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

	// RVA: 0x10C0A7C
	public void .ctor() { }

}

// Namespace: 
private sealed class XdrBuildFunction
{
	// Methods

	// RVA: 0x10CB08C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10CB59C
	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }

}

// Namespace: 
private sealed class XdrInitFunction
{
	// Methods

	// RVA: 0x10CB34C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10CB5B0
	public virtual void Invoke(XdrBuilder builder, object obj) { }

}

// Namespace: 
private sealed class XdrBeginChildFunction
{
	// Methods

	// RVA: 0x10CB408
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10CB5C4
	public virtual void Invoke(XdrBuilder builder) { }

}

// Namespace: 
private sealed class XdrEndChildFunction
{
	// Methods

	// RVA: 0x10CB4BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10CB5D8
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

	// RVA: 0x10CB148
	internal void .ctor(Token a, XmlTokenizedType ttype, XdrBuildFunction build) { }

	// RVA: 0x10CB1F0
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

	// RVA: 0x10CB29C
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

	// RVA: 0x10C07C4
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x10C0A8C
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x10C1184
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x10C1C48
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10C1614
	private bool LoadSchema(string uri) { }

	// RVA: 0x10C1550
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x10C1D90
	internal override bool IsContentParsed() { }

	// RVA: 0x10C1D98
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x10C1DF4
	internal override void ProcessCData(string value) { }

	// RVA: 0x10C1E80
	internal override void StartChildren() { }

	// RVA: 0x10C1EBC
	internal override void EndChildren() { }

	// RVA: 0x10C0F84
	private void Push() { }

	// RVA: 0x10C1F04
	private void Pop() { }

	// RVA: 0x10C1FAC
	private void PushGroupInfo() { }

	// RVA: 0x10C20E0
	private void PopGroupInfo() { }

	// RVA: 0x10C2188
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0x10C21F4
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C229C
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C22A0
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0x10C23A8
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0x10C2968
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0x10C2A98
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C2C74
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C2EE0
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C306C
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C3270
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C3508
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C3608
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C37FC
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C39F0
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0x10C3D08
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0x10C4290
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0x10C43A0
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C45FC
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C47C4
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C47E8
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C4A84
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C4B84
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C4C00
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C4C7C
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0x10C4D3C
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0x10C5250
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0x10C5320
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C5570
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C5754
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C5948
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0x10C5AB4
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0x10C5B68
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C5C54
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C5D08
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C5D2C
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0x10C6078
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0x10C619C
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0x10C6298
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C63CC
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C645C
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10C64EC
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0x10C66EC
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x10C6808
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0x10C691C
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x10C69D0
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0x10C0DCC
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x10C0FDC
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x10C1AF8
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0x10C311C
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0x10C54B4
	private void AddOrder() { }

	// RVA: 0x10C467C
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0x10C55F0
	private static UInt32 ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x10C57D4
	private static UInt32 ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x10C5A84
	private static void HandleMinMax(ParticleContentValidator pContent, UInt32 cMin, UInt32 cMax) { }

	// RVA: 0x10C3684
	private static void ParseDtMaxLength(UInt32 cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x10C3878
	private static void ParseDtMinLength(UInt32 cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x10C41D4
	private static void CompareMinMaxLength(UInt32 cMin, UInt32 cMax, XdrBuilder builder) { }

	// RVA: 0x10C6B08
	private static bool ParseInteger(string str, UInt32 n) { }

	// RVA: 0x10C287C
	private void XDR_CheckAttributeDefault(DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0x10C5200
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0x10C2D1C
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0x10C2F88
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0x10C48AC
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0x10C5114
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0x10C1544
	private bool IsGlobal(int flags) { }

	// RVA: 0x10C1C50
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x10C341C
	private void SendValidationEvent(string code) { }

	// RVA: 0x10C10A0
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x10C7188
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x10C73C8
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

	// RVA: 0x10CB5EC
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x10CB878
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x10CB678
	private void Init() { }

	// RVA: 0x10CBAB4
	public override void Validate() { }

	// RVA: 0x10CBE4C
	private void ValidateElement() { }

	// RVA: 0x10CC1D0
	private void ValidateChildElement() { }

	// RVA: 0x10CBB88
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x10CBB98
	private void ProcessInlineSchema() { }

	// RVA: 0x10CC314
	private void ProcessElement() { }

	// RVA: 0x10CBFF4
	private void ValidateEndElement() { }

	// RVA: 0x10CC3D4
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x10CC748
	private void ValidateStartElement() { }

	// RVA: 0x10CCBC4
	private void ValidateEndStartElement() { }

	// RVA: 0x10CD96C
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x10CD670
	private void LoadSchema(string uri) { }

	// RVA: 0x10CE038
	private bool get_HasSchema() { }

	// RVA: 0x10CE060
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x10CE09C
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x10CE3B8
	public override void CompleteValidation() { }

	// RVA: 0x10CCF78
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x10C6B44
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x10CE318
	internal void AddID(string name, object node) { }

	// RVA: 0x10CE6AC
	public override object FindId(string name) { }

	// RVA: 0x10CB91C
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x10CD5A0
	private void Pop() { }

	// RVA: 0x10CE488
	private void CheckForwardRefs() { }

	// RVA: 0x10CD890
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

	// RVA: 0x10CEDC8
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x10CFBD0
	public string LookupNamespace(string prefix) { }

	// RVA: 0x10CFC10
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x10CFC48
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

	// RVA: 0x10CE6C8
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x10CE764
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x10CE800
	internal void .ctor(XmlSchemaType xmlType, Double value) { }

	// RVA: 0x10CE89C
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x10CE938
	internal void .ctor(XmlSchemaType xmlType, Int64 value) { }

	// RVA: 0x10CE9D4
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x10CEA94
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10CEE18
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x10CEED8
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10CF12C
	private object System.ICloneable.Clone() { }

	// RVA: 0x10CF130
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x10CF138
	public override Type get_ValueType() { }

	// RVA: 0x10CF164
	public override object get_TypedValue() { }

	// RVA: 0x10CF354
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x10CF44C
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x10CF558
	public override Double get_ValueAsDouble() { }

	// RVA: 0x10CF664
	public override int get_ValueAsInt() { }

	// RVA: 0x10CF764
	public override Int64 get_ValueAsLong() { }

	// RVA: 0x10CF870
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10CFAA4
	public override string get_Value() { }

	// RVA: 0x10CFBC4
	public override string ToString() { }

	// RVA: 0x10CECA4
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

	// RVA: 0x10CFCF0
	public void .ctor() { }

	// RVA: 0x10CFED8
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x10D00A4
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x10D02B8
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x10D0368
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0x10D0370
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x10D0378
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x10D0380
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10D0388
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x10D0390
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10D0398
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x10D03A0
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x10D03A8
	public string get_TargetNamespace() { }

	// RVA: 0x10D03B0
	public void set_TargetNamespace(string value) { }

	// RVA: 0x10D03B8
	public string get_Version() { }

	// RVA: 0x10D03C0
	public void set_Version(string value) { }

	// RVA: 0x10D03C8
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x10D03D0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10D03D8
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x10D03E0
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x10D03E8
	internal bool get_IsPreprocessed() { }

	// RVA: 0x10D03F0
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x10D03F8
	internal bool get_IsRedefined() { }

	// RVA: 0x10D0400
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x10D0408
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x10D0490
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x10D0518
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x10D05A0
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x10D0628
	public string get_Id() { }

	// RVA: 0x10D0630
	public void set_Id(string value) { }

	// RVA: 0x10D0638
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x10D0640
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x10D0648
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0x10D0650
	internal Uri get_BaseUri() { }

	// RVA: 0x10D0658
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x10D0660
	internal int get_SchemaId() { }

	// RVA: 0x10D06EC
	internal bool get_IsChameleon() { }

	// RVA: 0x10D06F4
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x10D06FC
	internal Hashtable get_Ids() { }

	// RVA: 0x10D0704
	internal XmlDocument get_Document() { }

	// RVA: 0x10D078C
	internal int get_ErrorCount() { }

	// RVA: 0x10D0794
	internal void set_ErrorCount(int value) { }

	// RVA: 0x10D079C
	internal XmlSchema Clone() { }

	// RVA: 0x10D0958
	internal XmlSchema DeepClone() { }

	// RVA: 0x10D1AD0
	internal override string get_IdAttribute() { }

	// RVA: 0x10D1AD8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10D1AE0
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x10D1AE8
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10D1AF0
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x10D1BB8
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x10D1C40
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x10D1CC8
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x10D1EC4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAll
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x10D1F14
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10D1F1C
	internal override bool get_IsEmpty() { }

	// RVA: 0x10D1F70
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10D1F78
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

	// RVA: 0x10D20D4
	public string get_Id() { }

	// RVA: 0x10D20DC
	public void set_Id(string value) { }

	// RVA: 0x10D20E4
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x10D20EC
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x10D20F4
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x10D20FC
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x10D2104
	internal override string get_IdAttribute() { }

	// RVA: 0x10D210C
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10D2114
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10D211C
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x10D2124
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

	// RVA: 0x10D212C
	public string get_Id() { }

	// RVA: 0x10D2134
	public void set_Id(string value) { }

	// RVA: 0x10D213C
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10D2144
	internal override string get_IdAttribute() { }

	// RVA: 0x10D214C
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10D2154
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10D215C
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

	// RVA: 0x10D21D4
	public string get_Namespace() { }

	// RVA: 0x10D21DC
	public void set_Namespace(string value) { }

	// RVA: 0x10D21E4
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x10D21EC
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x10D21F4
	internal string get_ResolvedNamespace() { }

	// RVA: 0x10D2250
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x10D2264
	internal override string get_NameString() { }

	// RVA: 0x10D2754
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x10D27E0
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x10D288C
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x10D28B8
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

	// RVA: 0x10D2940
	public void set_Namespace(string value) { }

	// RVA: 0x10D2948
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0x10D2950
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x10D2958
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x10D2960
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x10D2974
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x10D2A00
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x10D2AAC
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x10D2AD8
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x10D2B00
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x10D2BE0
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x10D2BD8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAppInfo
{
	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Methods

	// RVA: 0x10D2CB8
	public void set_Source(string value) { }

	// RVA: 0x10D2CC0
	public XmlNode[] get_Markup() { }

	// RVA: 0x10D2CC8
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x10D2CD0
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

	// RVA: 0x10D2CD8
	public string get_DefaultValue() { }

	// RVA: 0x10D2CE0
	public void set_DefaultValue(string value) { }

	// RVA: 0x10D2CE8
	public string get_FixedValue() { }

	// RVA: 0x10D2CF0
	public void set_FixedValue(string value) { }

	// RVA: 0x10D2CF8
	public XmlSchemaForm get_Form() { }

	// RVA: 0x10D2D00
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x10D2D08
	public string get_Name() { }

	// RVA: 0x10D2D10
	public void set_Name(string value) { }

	// RVA: 0x10D2D18
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10D2D20
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10D2DF8
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x10D2E00
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x10D2ED8
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x10D2EE0
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x10D2EE8
	public XmlSchemaUse get_Use() { }

	// RVA: 0x10D2EF0
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x10D2EF8
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10D2F00
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x10D2F08
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x10D2F20
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10D2F28
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x10D2F30
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x10D2F38
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x10D2F40
	internal override string get_NameAttribute() { }

	// RVA: 0x10D2F48
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10D2F50
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10D3058
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

	// RVA: 0x10D3104
	public string get_Name() { }

	// RVA: 0x10D310C
	public void set_Name(string value) { }

	// RVA: 0x10D3114
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10D311C
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10D3124
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10D312C
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10D3134
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x10D31BC
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x10D31C4
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10D31CC
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x10D31D4
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x10D31DC
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x10D31E4
	internal int get_SelfReferenceCount() { }

	// RVA: 0x10D31EC
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x10D31F4
	internal override string get_NameAttribute() { }

	// RVA: 0x10D31FC
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10D3204
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10D320C
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10D376C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroupRef
{
	// Fields
	private XmlQualifiedName refName; // 0x50

	// Methods

	// RVA: 0x10D3820
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10D3828
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10D3900
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaChoice
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x10D397C
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10D3984
	internal override bool get_IsEmpty() { }

	// RVA: 0x10D398C
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10D3994
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

	// RVA: 0x10D3A68
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x10D3BB8
	public int get_Count() { }

	// RVA: 0x10D3BE0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x10D3BE8
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10D3BF0
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x10D3CAC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x10D3D90
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x10D3E24
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x10D41F4
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x10D41FC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x10D4200
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x10CDF7C
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x10D4228
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x10CC3CC
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x10D42E8
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x10D4470
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x10D45D4
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x10D45DC
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

	// RVA: 0x10D45E4
	internal void set_NamespaceURI(string value) { }

	// RVA: 0x10D45EC
	internal SchemaInfo get_SchemaInfo() { }

	// RVA: 0x10D45F4
	internal void set_SchemaInfo(SchemaInfo value) { }

	// RVA: 0x10D45FC
	internal XmlSchema get_Schema() { }

	// RVA: 0x10D4604
	internal void set_Schema(XmlSchema value) { }

	// RVA: 0x10D4468
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCollectionEnumerator
{
	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x10D3D40
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x10D460C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x10D46C4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x10D4140
	public bool MoveNext() { }

	// RVA: 0x10D4778
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x10D404C
	public XmlSchema get_Current() { }

	// RVA: 0x10D477C
	internal XmlSchemaCollectionNode get_CurrentNode() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCompilationSettings
{
	// Fields
	private bool enableUpaCheck; // 0x10

	// Methods

	// RVA: 0x10D4864
	public void .ctor() { }

	// RVA: 0x10D4890
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

	// RVA: 0x10D4898
	public bool get_IsMixed() { }

	// RVA: 0x10D48A0
	public void set_IsMixed(bool value) { }

	// RVA: 0x10D48B0
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x10D48B8
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x10D48C0
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x10D48C8
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

	// RVA: 0x10D48D8
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10D48E0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10D49B8
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x10D49C0
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x10D49C8
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10D49D0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10D49D8
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10D49E0
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10D49E8
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

	// RVA: 0x10D4AA4
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10D4AAC
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10D4B84
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x10D4B8C
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x10D4B94
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10D4B9C
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10D4BA4
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10D4BAC
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10D4BB4
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

	// RVA: 0x10D4C68
	private static void .cctor() { }

	// RVA: 0x10D4F58
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x10D54C4
	public void .ctor() { }

	// RVA: 0x10D55D8
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x10D5654
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x10D5548
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x10D56D0
	public bool get_IsAbstract() { }

	// RVA: 0x10D56DC
	public void set_IsAbstract(bool value) { }

	// RVA: 0x10D56FC
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x10D5704
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10D570C
	public override bool get_IsMixed() { }

	// RVA: 0x10D5718
	public override void set_IsMixed(bool value) { }

	// RVA: 0x10D5738
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x10D5740
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x10D5748
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x10D5750
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x10D5758
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10D57E0
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10D57E8
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10D57F0
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x10D57F8
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0x10D5800
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x10D5808
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x10D5890
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x10D5898
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x10D5920
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x10D5928
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10D5930
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10D5938
	internal void set_HasWildCard(bool value) { }

	// RVA: 0x10D594C
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10D5954
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x10D5EBC
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10D0E10
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10D6410
	private void ClearCompiledState() { }

	// RVA: 0x10D34A8
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x10D6548
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x10D614C
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x10D67C4
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x10D5EC4
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x10D333C
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContent
{
	// Methods

	// RVA: 0x10D4A9C
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

	// RVA: 0x10D48D0
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

	// RVA: 0x10D67F0
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x10D67F8
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: 0x10D6800
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

	// RVA: 0x10D6808
	internal string get_TypeCodeString() { }

	// RVA: 0x10D6940
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x10D70AC
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x10C508C
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x10D77BC
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x10C3480
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x10D7844
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x10C0C08
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x10D78B0
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

	// RVA: 0x10D78B8
	public void set_Source(string value) { }

	// RVA: 0x10D78C0
	public void set_Language(string value) { }

	// RVA: 0x10D79D8
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x10D79E0
	public void .ctor() { }

	// RVA: 0x10D79E8
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

	// RVA: 0x10D7AD8
	public bool get_IsAbstract() { }

	// RVA: 0x10D7AE0
	public void set_IsAbstract(bool value) { }

	// RVA: 0x10D7AF0
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x10D7AF8
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10D7B00
	public string get_DefaultValue() { }

	// RVA: 0x10D7B08
	public void set_DefaultValue(string value) { }

	// RVA: 0x10D7B10
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x10D7B18
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10D7B20
	public string get_FixedValue() { }

	// RVA: 0x10D7B28
	public void set_FixedValue(string value) { }

	// RVA: 0x10D7B30
	public XmlSchemaForm get_Form() { }

	// RVA: 0x10D7B38
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x10D7B40
	public string get_Name() { }

	// RVA: 0x10D7B48
	public void set_Name(string value) { }

	// RVA: 0x10D7B50
	public bool get_IsNillable() { }

	// RVA: 0x10D7B58
	public void set_IsNillable(bool value) { }

	// RVA: 0x10D7B68
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x10D7B70
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x10D7B78
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10D7B80
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10D7C58
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x10D7C60
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x10D7D38
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x10D7D40
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x10D7E18
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x10D7E20
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10D7E28
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0x10D7EB0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10D7EB8
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x10D7EC0
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x10D7EC8
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x10D7ED0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10D7ED8
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x10D7EE0
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10D7EE8
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10D7EF0
	internal bool get_HasConstraints() { }

	// RVA: 0x10D7F18
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x10D7F20
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x10D7F28
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x10D7F30
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x10D7F38
	internal override string get_NameAttribute() { }

	// RVA: 0x10D7F40
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10D7F48
	internal override string get_NameString() { }

	// RVA: 0x10D7F6C
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10D15B4
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10D7F74
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

	// RVA: 0x10D807C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10D8554
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10D86C8
	public void .ctor() { }

	// RVA: 0x10D86DC
	public void .ctor(string message) { }

	// RVA: 0x10D8838
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x10D86EC
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x10D8900
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x10CE5B0
	internal void .ctor(string res, string arg) { }

	// RVA: 0x10C72B8
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10D8998
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10C70DC
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10D8A40
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x10D8B08
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x10D8A4C
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x10D8844
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x10D8488
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x10D8BAC
	internal string get_GetRes() { }

	// RVA: 0x10D8BB4
	internal string[] get_Args() { }

	// RVA: 0x10D8BBC
	public string get_SourceUri() { }

	// RVA: 0x10D8BC4
	public int get_LineNumber() { }

	// RVA: 0x10D8BCC
	public int get_LinePosition() { }

	// RVA: 0x10D8BD4
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x10CD930
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10D8BDC
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x10D8BE4
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x10D8C2C
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

	// RVA: 0x10D8C44
	public string get_SchemaLocation() { }

	// RVA: 0x10D8C4C
	public void set_SchemaLocation(string value) { }

	// RVA: 0x10D8C54
	public XmlSchema get_Schema() { }

	// RVA: 0x10D8C5C
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x10D8C64
	public string get_Id() { }

	// RVA: 0x10D8C6C
	public void set_Id(string value) { }

	// RVA: 0x10D8C74
	internal Uri get_BaseUri() { }

	// RVA: 0x10D8C7C
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x10D8C84
	internal override string get_IdAttribute() { }

	// RVA: 0x10D8C8C
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10D8C94
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10D8C9C
	internal Compositor get_Compositor() { }

	// RVA: 0x10D8CA4
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x10D8CAC
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

	// RVA: 0x10D8CB4
	public string get_Value() { }

	// RVA: 0x10D8CBC
	public void set_Value(string value) { }

	// RVA: 0x10D8CC4
	public virtual bool get_IsFixed() { }

	// RVA: 0x10D8CCC
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x10D8D88
	internal FacetType get_FacetType() { }

	// RVA: 0x10D8D90
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x10D8D98
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaNumericFacet
{
	// Methods

	// RVA: 0x10D8DA0
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaLengthFacet
{
	// Methods

	// RVA: 0x10D8DA8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinLengthFacet
{
	// Methods

	// RVA: 0x10D8DD4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxLengthFacet
{
	// Methods

	// RVA: 0x10D8E00
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaPatternFacet
{
	// Methods

	// RVA: 0x10D8E2C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaEnumerationFacet
{
	// Methods

	// RVA: 0x10D8E58
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinExclusiveFacet
{
	// Methods

	// RVA: 0x10D8E84
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinInclusiveFacet
{
	// Methods

	// RVA: 0x10D8EB0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxExclusiveFacet
{
	// Methods

	// RVA: 0x10D8EDC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxInclusiveFacet
{
	// Methods

	// RVA: 0x10D8F08
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaTotalDigitsFacet
{
	// Methods

	// RVA: 0x10D8F34
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaFractionDigitsFacet
{
	// Methods

	// RVA: 0x10D8F60
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaWhiteSpaceFacet
{
	// Methods

	// RVA: 0x10D8F8C
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

	// RVA: 0x10D8FB8
	public string get_Name() { }

	// RVA: 0x10D8FC0
	public void set_Name(string value) { }

	// RVA: 0x10D8FC8
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x10D8FD0
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x10D8FD8
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10D8FE0
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x10D8FE8
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x10D8FF0
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x10D8FF8
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x10D9000
	internal int get_SelfReferenceCount() { }

	// RVA: 0x10D9008
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x10D9010
	internal override string get_NameAttribute() { }

	// RVA: 0x10D9018
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10D9020
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10D9028
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10D17F0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10D9030
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

	// RVA: 0x10D204C
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

	// RVA: 0x10D90AC
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10D66EC
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10D90B4
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x10D90BC
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x10D90C4
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x10D90CC
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x10D90D4
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

	// RVA: 0x10D918C
	public string get_Name() { }

	// RVA: 0x10D9194
	public void set_Name(string value) { }

	// RVA: 0x10D919C
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x10D91A4
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x10D91AC
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x10D91B4
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10D91BC
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10D91C4
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x10D91CC
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x10D91D4
	internal override string get_NameAttribute() { }

	// RVA: 0x10D91DC
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10D91E4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaXPath
{
	// Fields
	private string xpath; // 0x50

	// Methods

	// RVA: 0x10D9298
	public string get_XPath() { }

	// RVA: 0x10D92A0
	public void set_XPath(string value) { }

	// RVA: 0x10D92A8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaUnique
{
	// Methods

	// RVA: 0x10D92B0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaKey
{
	// Methods

	// RVA: 0x10D92B4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaKeyref
{
	// Fields
	private XmlQualifiedName refer; // 0x78

	// Methods

	// RVA: 0x10D92B8
	public XmlQualifiedName get_Refer() { }

	// RVA: 0x10D92C0
	public void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x10D9398
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaImport
{
	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Methods

	// RVA: 0x10D9410
	public void .ctor() { }

	// RVA: 0x10D943C
	public string get_Namespace() { }

	// RVA: 0x10D9444
	public void set_Namespace(string value) { }

	// RVA: 0x10D944C
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaInclude
{
	// Fields
	private XmlSchemaAnnotation annotation; // 0x68

	// Methods

	// RVA: 0x10D9454
	public void .ctor() { }

	// RVA: 0x10D9480
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

	// RVA: 0x10D9488
	public void .ctor() { }

	// RVA: 0x10D9564
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x10D95D8
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0x10D95E0
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x10D95E8
	public bool get_IsDefault() { }

	// RVA: 0x10D95F0
	public void set_IsDefault(bool value) { }

	// RVA: 0x10D95F8
	public bool get_IsNil() { }

	// RVA: 0x10D9600
	public void set_IsNil(bool value) { }

	// RVA: 0x10D9608
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x10D9610
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x10D9618
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x10D9620
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10D9670
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x10D9678
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x10D96BC
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x10D96C4
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x10D9708
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x10D9710
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x10D972C
	internal bool get_HasDefaultValue() { }

	// RVA: 0x10D9768
	internal bool get_IsUnionType() { }

	// RVA: 0x10D94FC
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

	// RVA: 0x10D97A8
	public string get_Name() { }

	// RVA: 0x10D97B0
	public void set_Name(string value) { }

	// RVA: 0x10D97B8
	public string get_Public() { }

	// RVA: 0x10D97C0
	public void set_Public(string value) { }

	// RVA: 0x10D97C8
	public string get_System() { }

	// RVA: 0x10D97D0
	public void set_System(string value) { }

	// RVA: 0x10D97D8
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10D97E0
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10D97E8
	internal override string get_NameAttribute() { }

	// RVA: 0x10D97F0
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10D97F8
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

	// RVA: 0x10D9874
	public int get_LineNumber() { }

	// RVA: 0x10D987C
	public void set_LineNumber(int value) { }

	// RVA: 0x10D9884
	public int get_LinePosition() { }

	// RVA: 0x10D988C
	public void set_LinePosition(int value) { }

	// RVA: 0x10D9894
	public string get_SourceUri() { }

	// RVA: 0x10D989C
	public void set_SourceUri(string value) { }

	// RVA: 0x10D98A4
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x10D98AC
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x10D08D0
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x10D98B4
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x10D98BC
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x10D98C0
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x10D98C4
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x10D98C8
	internal virtual string get_IdAttribute() { }

	// RVA: 0x10D98D0
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x10D98D4
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10D98D8
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x10D98DC
	internal virtual string get_NameAttribute() { }

	// RVA: 0x10D98E4
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x10D98E8
	internal bool get_IsProcessing() { }

	// RVA: 0x10D98F0
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x10D98F8
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x10CFED0
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectCollection
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Methods

	// RVA: 0x10CFEC8
	public void .ctor() { }

	// RVA: 0x10D997C
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x10D9A9C
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x10D9B68
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x10D1A0C
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x10D9BE8
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x10D9CB4
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x10D9D78
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x10D9D94
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x10D9DF4
	protected override void OnClear() { }

	// RVA: 0x10D9E10
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x10D64BC
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x10D9E2C
	private void Add(XmlSchemaObjectCollection collToAdd) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x10D9E5C
	internal void .ctor(IEnumerator enumerator) { }

	// RVA: 0x10D9E90
	public bool MoveNext() { }

	// RVA: 0x10D9F44
	public XmlSchemaObject get_Current() { }

	// RVA: 0x10DA048
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x10DA100
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x10DA1B4
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

	// RVA: 0x10DA420
	public void .ctor(XmlQualifiedName name, XmlSchemaObject value) { }

}

// Namespace: 
internal class ValuesCollection
{
	// Fields
	private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private int size; // 0x18

	// Methods

	// RVA: 0x10DAC38
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x10DAD88
	public int get_Count() { }

	// RVA: 0x10DAD90
	public object get_SyncRoot() { }

	// RVA: 0x10DAE48
	public bool get_IsSynchronized() { }

	// RVA: 0x10DAF00
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x10DB050
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

	// RVA: 0x10DB0DC
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

	// RVA: 0x10DB130
	public object get_Current() { }

	// RVA: 0x10DB310
	public bool MoveNext() { }

	// RVA: 0x10DB400
	public void Reset() { }

}

// Namespace: 
internal class XSODictionaryEnumerator
{
	// Methods

	// RVA: 0x10DAD34
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

	// RVA: 0x10DB43C
	public DictionaryEntry get_Entry() { }

	// RVA: 0x10DB58C
	public object get_Key() { }

	// RVA: 0x10DB6C0
	public object get_Value() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectTable
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaObject> table; // 0x10
	private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Methods

	// RVA: 0x10DA26C
	internal void .ctor() { }

	// RVA: 0x10DA34C
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x10DA454
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x10DA6B0
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x10DA848
	internal void Clear() { }

	// RVA: 0x10DA90C
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x10DA600
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x10DAA54
	public int get_Count() { }

	// RVA: 0x10DAAA8
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x10DAB0C
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x10DAB90
	public ICollection get_Values() { }

	// RVA: 0x10DAC80
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

	// RVA: 0x10DC54C
	internal override bool get_IsEmpty() { }

	// RVA: 0x10DC464
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

	// RVA: 0x10DB7F4
	public string get_MinOccursString() { }

	// RVA: 0x10DB890
	public void set_MinOccursString(string value) { }

	// RVA: 0x10DB9F8
	public string get_MaxOccursString() { }

	// RVA: 0x10DBB44
	public void set_MaxOccursString(string value) { }

	// RVA: 0x10DBD70
	public Decimal get_MinOccurs() { }

	// RVA: 0x10DBD7C
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0x10DBEB4
	public Decimal get_MaxOccurs() { }

	// RVA: 0x10DBEC0
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x10DC038
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x10DC0B0
	internal virtual string get_NameString() { }

	// RVA: 0x10DC0FC
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x10DC2A4
	protected void .ctor() { }

	// RVA: 0x10DC324
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

	// RVA: 0x10DC554
	public void .ctor() { }

	// RVA: 0x10DC64C
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10DC654
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x10DC65C
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x10DC664
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x10DC66C
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSequence
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x10DC68C
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10DC694
	internal override bool get_IsEmpty() { }

	// RVA: 0x10DC744
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10DC74C
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

	// RVA: 0x10DC7C4
	internal object get_InternalSyncObject() { }

	// RVA: 0x10DC84C
	public void .ctor() { }

	// RVA: 0x10DC8B4
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x10DCBB8
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10DCCE0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10DCDBC
	public bool get_IsCompiled() { }

	// RVA: 0x10DCDC4
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10DCDE4
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x10DCDEC
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x10DCDF4
	public int get_Count() { }

	// RVA: 0x10DCE1C
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x10DCEA0
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x10DCF24
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x10DCFA8
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x10DD02C
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x10DD034
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x10DD0B8
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x10DFA80
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x10DFCDC
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x10E0D6C
	public bool Contains(string targetNamespace) { }

	// RVA: 0x10E0E00
	public void Compile() { }

	// RVA: 0x10E15CC
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x10E33CC
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x10E3548
	public ICollection Schemas() { }

	// RVA: 0x10E30E4
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x10DFA10
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x10E3A3C
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x10DF794
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x10E3570
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x10E43B0
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x10E48E0
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x10E0954
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x10E13CC
	private void ClearTables() { }

	// RVA: 0x10E32A0
	internal bool PreprocessSchema(XmlSchema schema, string targetNamespace) { }

	// RVA: 0x10E41A0
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x10DDAE8
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x10E5338
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x10E5340
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x10E5348
	internal XmlResolver GetResolver() { }

	// RVA: 0x10E5368
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x10E510C
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x10E3E10
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, XmlSchema schema) { }

	// RVA: 0x10E5370
	internal bool GetSchemaByUri(Uri schemaUri, XmlSchema schema) { }

	// RVA: 0x10E083C
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x10E5508
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x10E2AB4
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x10E1F0C
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x10E4D60
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x10E51CC
	private void VerifyTables() { }

	// RVA: 0x10E5510
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x10E08A8
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContent
{
	// Fields
	private XmlSchemaContent content; // 0x50

	// Methods

	// RVA: 0x10E5560
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x10E5568
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x10E5570
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

	// RVA: 0x10E5578
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10E5580
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10E5658
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10E5660
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10E5668
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10E5670
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10E5678
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

	// RVA: 0x10E572C
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10E5734
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10E580C
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x10E5814
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x10E581C
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x10E5824
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10E582C
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10E5834
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10E583C
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10E5844
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleType
{
	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Methods

	// RVA: 0x10E591C
	public void .ctor() { }

	// RVA: 0x10E5A34
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x10E5A3C
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0x10E5A44
	internal override XmlSchemaObject Clone() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaSimpleTypeContent
{
	// Methods

	// RVA: 0x10E5B54
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

	// RVA: 0x10E5B5C
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0x10E5B64
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x10E5C3C
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x10E5C44
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x10E5C4C
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x10E5C54
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x10E5C5C
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10E5D20
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

	// RVA: 0x10E5D9C
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10E5DA4
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10E5E7C
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x10E5E84
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x10E5E8C
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x10E5E94
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10E5F58
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

	// RVA: 0x10E600C
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x10E6014
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x10E601C
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x10E6024
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x10E602C
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0x10E6034
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10E61F8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroup
{
	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Methods

	// RVA: 0x10E6270
	internal ArrayList get_Members() { }

	// RVA: 0x10E6278
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x10E6280
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0x10E6288
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroupV1Compat
{
	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Methods

	// RVA: 0x10E633C
	internal XmlSchemaChoice get_Choice() { }

	// RVA: 0x10E6344
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

	// RVA: 0x10E63B8
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x10E64D4
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0x10E655C
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x10E685C
	public string get_Name() { }

	// RVA: 0x10E6864
	public void set_Name(string value) { }

	// RVA: 0x10E686C
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x10E6874
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10E5314
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10E687C
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x10E6884
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x10E688C
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x10E6894
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x10E689C
	public virtual bool get_IsMixed() { }

	// RVA: 0x10E68A4
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0x10E68A8
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0x10E69A0
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0x10E6A30
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0x10E6A38
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10E6A68
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10E6A70
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x10E6A78
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10E6A80
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0x10E6A88
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x10E6AAC
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x10E6ADC
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x10E6AE4
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0x10E6AEC
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0x10E6AF4
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x10E6D6C
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x10E6E78
	internal override string get_NameAttribute() { }

	// RVA: 0x10E6E80
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10E59A8
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

	// RVA: 0x10E6E88
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10E6E90
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10E6E98
	public void .ctor() { }

	// RVA: 0x10E6EA4
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10E6F78
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10E6FAC
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Schema
public sealed class XmlValueGetter
{
	// Methods

	// RVA: 0x10E6FD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10E7070
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

	// RVA: 0x10E7084
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

	// RVA: 0x10E70E8
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0x10E731C
	private void Init() { }

	// RVA: 0x10E7850
	private void Reset() { }

	// RVA: 0x10E79DC
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10E79E4
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0x10E79FC
	public void set_SourceUri(Uri value) { }

	// RVA: 0x10E7A4C
	public void set_ValidationEventSender(object value) { }

	// RVA: 0x10E7A54
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10E7B08
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10E7BBC
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0x10E83CC
	public void Initialize() { }

	// RVA: 0x10E8510
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0x10E87C8
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x10EA530
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10EA594
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10EBAB0
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10EBE18
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0x10EBE7C
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x10EC858
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0x10EC8BC
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x10ECB30
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10ED044
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10ED3CC
	public void EndValidation() { }

	// RVA: 0x10ED648
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x10EE230
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x10EE238
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x10EE240
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0x10EE27C
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0x10EE2AC
	private bool get_StrictlyAssessed() { }

	// RVA: 0x10EE2F8
	private bool get_HasSchema() { }

	// RVA: 0x10EE34C
	internal string GetConcatenatedValue() { }

	// RVA: 0x10ECB38
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0x10E95D4
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x10E8E50
	private object ValidateElementContext(XmlQualifiedName elementName, bool invalidElementInContext) { }

	// RVA: 0x10F0178
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0x10EE370
	private object ValidateAtomicValue(string stringValue, XmlSchemaSimpleType memberType) { }

	// RVA: 0x10EE65C
	private object ValidateAtomicValue(object parsedValue, XmlSchemaSimpleType memberType) { }

	// RVA: 0x10F11F8
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0x10EC2D0
	private void SaveTextValue(object value) { }

	// RVA: 0x10E76E0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x10ED258
	private void Pop() { }

	// RVA: 0x10E934C
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0x10E9924
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, bool declFound) { }

	// RVA: 0x10EA050
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0x10EA278
	private void CheckElementProperties() { }

	// RVA: 0x10EA380
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x10EB15C
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0x10F1B20
	private void AddXmlNamespaceSchema() { }

	// RVA: 0x10EEA28
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0x10EFC60
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x10E78FC
	internal void RecompileSchemaSet() { }

	// RVA: 0x10F1DDC
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0x10EB3E4
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0x10F0F28
	private object CheckElementValue(string stringValue) { }

	// RVA: 0x10EB648
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0x10F20D4
	private object FindId(string name) { }

	// RVA: 0x10ED4BC
	private void CheckForwardRefs() { }

	// RVA: 0x10EB7D8
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x10F12C8
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0x10F23CC
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0x10E79CC
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0x10E8BBC
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0x10E8DF8
	private void ClearPSVI() { }

	// RVA: 0x10EBB98
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0x10EA3EC
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0x10EDD54
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0x10F12D4
	private void AddIdentityConstraints() { }

	// RVA: 0x10F1734
	private void ElementIdentityConstraints() { }

	// RVA: 0x10EB7F8
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0x10EF078
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0x10F05E0
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x10EEB30
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x10EC474
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0x10F29CC
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0x10F24A4
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0x10F2B54
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0x10EC24C
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0x10F0358
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0x10EC318
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0x10F20F0
	private void ProcessEntity(string name) { }

	// RVA: 0x10F1264
	private void SendValidationEvent(string code) { }

	// RVA: 0x10EB240
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x10EAF50
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0x10F03D4
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0x10F1BF8
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0x10E821C
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0x10F23D8
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0x10F00C0
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x10E7FDC
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x10F2290
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x10F23E0
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x10F2D98
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

	// RVA: 0x10F3218
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

	// RVA: 0x10F3220
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10F3434
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x10F3524
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x10F35A0
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x10F3600
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x10F3700
	public override bool ToBoolean(Double value) { }

	// RVA: 0x10F3800
	public override bool ToBoolean(int value) { }

	// RVA: 0x10F3900
	public override bool ToBoolean(Int64 value) { }

	// RVA: 0x10F3A00
	public override bool ToBoolean(string value) { }

	// RVA: 0x10F3AC8
	public override bool ToBoolean(object value) { }

	// RVA: 0x10F3B90
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x10F3C90
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x10F3D94
	public override DateTime ToDateTime(Double value) { }

	// RVA: 0x10F3E94
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x10F3F94
	public override DateTime ToDateTime(Int64 value) { }

	// RVA: 0x10F4094
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x10F415C
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x10F4224
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x10F4328
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x10F43F4
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10F44C0
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x10F458C
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x10F4658
	public override Double ToDouble(bool value) { }

	// RVA: 0x10F4758
	public override Double ToDouble(DateTime value) { }

	// RVA: 0x10F4858
	public override Double ToDouble(int value) { }

	// RVA: 0x10F4958
	public override Double ToDouble(Int64 value) { }

	// RVA: 0x10F4A58
	public override Double ToDouble(string value) { }

	// RVA: 0x10F4B20
	public override Double ToDouble(object value) { }

	// RVA: 0x10F4BE8
	public override int ToInt32(bool value) { }

	// RVA: 0x10F4CE8
	public override int ToInt32(DateTime value) { }

	// RVA: 0x10F4DE8
	public override int ToInt32(Double value) { }

	// RVA: 0x10F4EE8
	public override int ToInt32(Int64 value) { }

	// RVA: 0x10F4FE8
	public override int ToInt32(string value) { }

	// RVA: 0x10F50B0
	public override int ToInt32(object value) { }

	// RVA: 0x10F5178
	public override Int64 ToInt64(bool value) { }

	// RVA: 0x10F5278
	public override Int64 ToInt64(DateTime value) { }

	// RVA: 0x10F5378
	public override Int64 ToInt64(Double value) { }

	// RVA: 0x10F5478
	public override Int64 ToInt64(int value) { }

	// RVA: 0x10F5578
	public override Int64 ToInt64(string value) { }

	// RVA: 0x10F5640
	public override Int64 ToInt64(object value) { }

	// RVA: 0x10F5708
	public override float ToSingle(Double value) { }

	// RVA: 0x10F5808
	public override float ToSingle(string value) { }

	// RVA: 0x10F58D0
	public override float ToSingle(object value) { }

	// RVA: 0x10F5998
	public override string ToString(bool value) { }

	// RVA: 0x10F5A84
	public override string ToString(DateTime value) { }

	// RVA: 0x10F5B70
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x10F5C60
	public override string ToString(Decimal value) { }

	// RVA: 0x10F5D7C
	public override string ToString(Double value) { }

	// RVA: 0x10F5E68
	public override string ToString(int value) { }

	// RVA: 0x10F5F54
	public override string ToString(Int64 value) { }

	// RVA: 0x10F6040
	public override string ToString(float value) { }

	// RVA: 0x10F612C
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F61EC
	public override string ToString(object value) { }

	// RVA: 0x10F6200
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10F6294
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10F6328
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10F63EC
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10F6480
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10F6514
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10F65A8
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F65B8
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x10F65CC
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x10F65D4
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x10F65DC
	protected string get_XmlTypeName() { }

	// RVA: 0x10F6848
	protected Type get_DefaultClrType() { }

	// RVA: 0x10F6850
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x10F692C
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x10F6714
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x10F6BD0
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F6C2C
	protected static Byte[] StringToBase64Binary(string value) { }

	// RVA: 0x10F6CDC
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x10F6D64
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x10F6DEC
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x10F6E44
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x10F6E9C
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x10F6F24
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x10F6FAC
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x10F7034
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x10F70BC
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x10F7144
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x10F71CC
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x10F7254
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x10F72DC
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x10F7364
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x10F73EC
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x10F7474
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x10F74FC
	protected static Byte[] StringToHexBinary(string value) { }

	// RVA: 0x10F7640
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F7920
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x10F79A8
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x10F7A30
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x10F7A88
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x10F7AA0
	protected static string Base64BinaryToString(Byte[] value) { }

	// RVA: 0x10F7B28
	protected static string DateToString(DateTime value) { }

	// RVA: 0x10F7BB8
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x10F7C48
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x10F7CA0
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x10F7CF8
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x10F7D88
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x10F7E18
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x10F7EA8
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x10F7F38
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x10F7FC8
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10F8060
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10F80F8
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10F8190
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10F8228
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10F82C0
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10F8358
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10F83F0
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10F8628
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x10F86B8
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10F8750
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x10F87A8
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x10F8810
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x10F89F8
	protected static Int64 DecimalToInt64(Decimal value) { }

	// RVA: 0x10F8BE0
	protected static UInt64 DecimalToUInt64(Decimal value) { }

	// RVA: 0x10F8DBC
	protected static Byte Int32ToByte(int value) { }

	// RVA: 0x10F8EA8
	protected static Int16 Int32ToInt16(int value) { }

	// RVA: 0x10F8F94
	protected static SByte Int32ToSByte(int value) { }

	// RVA: 0x10F9080
	protected static UInt16 Int32ToUInt16(int value) { }

	// RVA: 0x10F916C
	protected static int Int64ToInt32(Int64 value) { }

	// RVA: 0x10F9254
	protected static UInt32 Int64ToUInt32(Int64 value) { }

	// RVA: 0x10F933C
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x10F93C4
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x10F944C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric10Converter
{
	// Methods

	// RVA: 0x10F9AC4
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10F9B30
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10F9BD4
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x10F9CE4
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x10FA6D8
	public override int ToInt32(Int64 value) { }

	// RVA: 0x10FA760
	public override int ToInt32(string value) { }

	// RVA: 0x10FA894
	public override int ToInt32(object value) { }

	// RVA: 0x10FAD24
	public override Int64 ToInt64(int value) { }

	// RVA: 0x10FAD2C
	public override Int64 ToInt64(string value) { }

	// RVA: 0x10FAE60
	public override Int64 ToInt64(object value) { }

	// RVA: 0x10FB2F0
	public override string ToString(Decimal value) { }

	// RVA: 0x10FB3CC
	public override string ToString(int value) { }

	// RVA: 0x10FB454
	public override string ToString(Int64 value) { }

	// RVA: 0x10FB4DC
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10FB9A8
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10FC478
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10FC9F4
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10FCF74
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10FD4D0
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10FA1A8
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10FBF30
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric2Converter
{
	// Methods

	// RVA: 0x10FE804
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10FE870
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10FE914
	public override Double ToDouble(string value) { }

	// RVA: 0x10FEA14
	public override Double ToDouble(object value) { }

	// RVA: 0x10FEDFC
	public override float ToSingle(Double value) { }

	// RVA: 0x10FEE04
	public override float ToSingle(string value) { }

	// RVA: 0x10FEF04
	public override float ToSingle(object value) { }

	// RVA: 0x10FF2D8
	public override string ToString(Double value) { }

	// RVA: 0x10FF3D4
	public override string ToString(float value) { }

	// RVA: 0x10FF488
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10FF874
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10FFCF4
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1100184
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlDateTimeConverter
{
	// Methods

	// RVA: 0x1100A9C
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1100B08
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1100BAC
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1100C18
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1100F04
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x11012F8
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1101324
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1101610
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1101A40
	public override string ToString(DateTime value) { }

	// RVA: 0x1101CE0
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1101EE4
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11022D0
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1102758
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1102BE0
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlBooleanConverter
{
	// Methods

	// RVA: 0x110351C
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1103588
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x110362C
	public override bool ToBoolean(string value) { }

	// RVA: 0x11036E8
	public override bool ToBoolean(object value) { }

	// RVA: 0x1103A38
	public override string ToString(bool value) { }

	// RVA: 0x1103AC0
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1103DFC
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1104200
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1104604
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlMiscConverter
{
	// Methods

	// RVA: 0x1104D48
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1104DB4
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1104E58
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11055D8
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1105DC0
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1105468
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1105C14
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlStringConverter
{
	// Methods

	// RVA: 0x1106E74
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1106EE0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1106F84
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11071E0
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1107514
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

	// RVA: 0x1107A78
	protected void .ctor() { }

	// RVA: 0x1107BE8
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0x1107D74
	public override bool ToBoolean(string value) { }

	// RVA: 0x1107E30
	public override bool ToBoolean(object value) { }

	// RVA: 0x11081A0
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x110825C
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1108434
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x11084F0
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x11086D4
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1108790
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x110899C
	public override Double ToDouble(string value) { }

	// RVA: 0x1108A58
	public override Double ToDouble(object value) { }

	// RVA: 0x1108C58
	public override int ToInt32(string value) { }

	// RVA: 0x1108D14
	public override int ToInt32(object value) { }

	// RVA: 0x1108F14
	public override Int64 ToInt64(string value) { }

	// RVA: 0x1108FD0
	public override Int64 ToInt64(object value) { }

	// RVA: 0x11091D0
	public override float ToSingle(string value) { }

	// RVA: 0x110928C
	public override float ToSingle(object value) { }

	// RVA: 0x110948C
	public override string ToString(bool value) { }

	// RVA: 0x1109514
	public override string ToString(DateTime value) { }

	// RVA: 0x110959C
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1109608
	public override string ToString(Decimal value) { }

	// RVA: 0x1109674
	public override string ToString(Double value) { }

	// RVA: 0x11096FC
	public override string ToString(int value) { }

	// RVA: 0x1109784
	public override string ToString(Int64 value) { }

	// RVA: 0x110980C
	public override string ToString(float value) { }

	// RVA: 0x1109894
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x110A77C
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x110ABB8
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x110AE04
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x110B0BC
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x110B328
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x110B588
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x110B7E8
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x110C768
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1108030
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x110A9DC
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x110E518
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x110E854
	private bool SupportsType(Type clrType) { }

	// RVA: 0x1110024
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyConverter
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x11100E8
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1110154
	public override bool ToBoolean(object value) { }

	// RVA: 0x11104A8
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x111068C
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1110874
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1110A5C
	public override Double ToDouble(object value) { }

	// RVA: 0x1110C40
	public override int ToInt32(object value) { }

	// RVA: 0x1110E24
	public override Int64 ToInt64(object value) { }

	// RVA: 0x1111008
	public override float ToSingle(object value) { }

	// RVA: 0x11111F0
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1111604
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x111186C
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1111B28
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x1111D98
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1112000
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x1112268
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11124C0
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1110338
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1111458
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1113F64
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x1113FF8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyListConverter
{
	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x1114110
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x1114208
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11144B8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlListConverter
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x111418C
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x1107CE8
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x1107B7C
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x11146A8
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x1114928
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x110F03C
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1114A34
	private bool IsListType(Type type) { }

	// RVA: 0x30D3E84
	private T[] ToArray(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1115368
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11152B8
	private System.Collections.Generic.List<System.String> StringAsList(string value) { }

	// RVA: 0x1114F24
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1114C78
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

	// RVA: 0x111597C
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1115C00
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1115C64
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

	// RVA: 0x1122B24
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1122BE0
	public virtual void Invoke(XsdBuilder builder, string value) { }

}

// Namespace: 
private sealed class XsdInitFunction
{
	// Methods

	// RVA: 0x1122BF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1122CB0
	public virtual void Invoke(XsdBuilder builder, string value) { }

}

// Namespace: 
private sealed class XsdEndChildFunction
{
	// Methods

	// RVA: 0x1122CC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1122D78
	public virtual void Invoke(XsdBuilder builder) { }

}

// Namespace: 
private sealed class XsdAttributeEntry
{
	// Fields
	public Token Attribute; // 0x10
	public XsdBuildFunction BuildFunc; // 0x18

	// Methods

	// RVA: 0x1122D8C
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

	// RVA: 0x1122DD0
	public void .ctor(Token n, State state, State[] nextStates, XsdAttributeEntry[] attributes, XsdInitFunction init, XsdEndChildFunction end, bool parseContent) { }

}

// Namespace: 
private class BuilderNamespaceManager
{
	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x1122E70
	public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x1122EC0
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

	// RVA: 0x1116124
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x1116384
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x1116B64
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x11170C0
	internal override bool IsContentParsed() { }

	// RVA: 0x11170E0
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x11170F0
	internal override void ProcessCData(string value) { }

	// RVA: 0x111714C
	internal override void StartChildren() { }

	// RVA: 0x1117300
	internal override void EndChildren() { }

	// RVA: 0x1116640
	private void Push() { }

	// RVA: 0x1117348
	private void Pop() { }

	// RVA: 0x11185C8
	private Token get_CurrentElement() { }

	// RVA: 0x11185E8
	private Token get_ParentElement() { }

	// RVA: 0x1118664
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0x111743C
	private XmlSchemaObject GetContainer(State state) { }

	// RVA: 0x11175F4
	private void SetContainer(State state, object container) { }

	// RVA: 0x11186F8
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0x1118720
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x11188B4
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1118960
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0x1118984
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0x11189A8
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1118CA0
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1118D14
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0x1118D3C
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0x1118E0C
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x1118E30
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0x1118F00
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1118F24
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x1118F48
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0x1119018
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x111903C
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0x111905C
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x1119428
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0x111944C
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1119470
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0x111951C
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0x11195C8
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x11197CC
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0x11197F0
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0x111986C
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0x11199E0
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x1119B84
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0x1119BF8
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0x1119C1C
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0x1119CC8
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1119D44
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1119DB8
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1119DDC
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1119EC8
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1119FB4
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1119FD8
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0x111A054
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x111A0D0
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0x111A14C
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0x111A4EC
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x111A510
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x111A584
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0x111A654
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0x111A854
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0x111A924
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0x111A9A0
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x111AA70
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x111AAEC
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0x111ACD8
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x111AD54
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0x111ADC8
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x111AE3C
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x111AEC0
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x111AEE4
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0x111AFF8
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x111B074
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x111B16C
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x111B1E8
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x111B28C
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x111B308
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0x111B41C
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x111B514
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x111B590
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x111B688
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x111B704
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0x111B83C
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x111B860
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x111B8F0
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x111B96C
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x111BC84
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x111BCA8
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x111BD54
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0x111BE90
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x111BEB4
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x111C334
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x111C354
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x111C374
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x111C3F0
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0x111C490
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0x111C530
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0x111C5D0
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0x111C674
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x111C698
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x111C744
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0x111C7EC
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0x111C810
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0x111C834
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0x111C858
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0x111CBC4
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x111CC48
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0x111CC6C
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0x111CDC4
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0x111CDE8
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0x111CF0C
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0x111CFE8
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x111D00C
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0x111D0E8
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x111D10C
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0x111D2F4
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0x111D3C8
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0x111D448
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0x111D474
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0x111D548
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0x111D5C4
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0x111D70C
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0x111918C
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0x111BF58
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0x11164CC
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x1116A50
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x1119EE8
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x1119DFC
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x1119A5C
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0x11187CC
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0x1119644
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0x1118A1C
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x111D444
	private static string ParseUriReference(string s) { }

	// RVA: 0x111D738
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0x1116A7C
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x1116FD4
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x111D8AC
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x111A84C
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1116910
	private void RecordPosition() { }

	// RVA: 0x111D98C
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

	// RVA: 0x1123190
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x112736C
	private bool ParseDate(int start) { }

	// RVA: 0x1127740
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x1127B38
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x1127DBC
	private bool ParseTime(int start) { }

	// RVA: 0x1127828
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x1127BF0
	private bool Parse4Dig(int start, int num) { }

	// RVA: 0x1127D0C
	private bool Parse2Dig(int start, int num) { }

	// RVA: 0x11276EC
	private bool ParseChar(int start, Char ch) { }

	// RVA: 0x1127360
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x11282D0
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

	// RVA: 0x1122F24
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1124544
	private void .ctor(Parser parser) { }

	// RVA: 0x112447C
	private void InitiateXsdDateTime(Parser parser) { }

	// RVA: 0x11246A4
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, XsdDateTime result) { }

	// RVA: 0x11247A0
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x112498C
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x1124A08
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x1124B9C
	private DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x1124BA4
	private XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x1124BAC
	public int get_Year() { }

	// RVA: 0x1124C34
	public int get_Month() { }

	// RVA: 0x1124CBC
	public int get_Day() { }

	// RVA: 0x1124D44
	public int get_Hour() { }

	// RVA: 0x1124DCC
	public int get_Minute() { }

	// RVA: 0x1124E54
	public int get_Second() { }

	// RVA: 0x1124EDC
	public int get_Fraction() { }

	// RVA: 0x1124FFC
	public int get_ZoneHour() { }

	// RVA: 0x1125004
	public int get_ZoneMinute() { }

	// RVA: 0x112500C
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1125710
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1125BF0
	public override string ToString() { }

	// RVA: 0x11264F8
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x112687C
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x1126D74
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x1126C9C
	private void IntToCharArray(Char[] text, int start, int value, int digits) { }

	// RVA: 0x1126D08
	private void ShortToCharArray(Char[] text, int start, int value) { }

	// RVA: 0x1126FA0
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

	// RVA: 0x1128374
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x11284DC
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x112860C
	public void .ctor(TimeSpan timeSpan, DurationType durationType) { }

	// RVA: 0x1128814
	public void .ctor(string s) { }

	// RVA: 0x1128890
	public void .ctor(string s, DurationType durationType) { }

	// RVA: 0x112904C
	public bool get_IsNegative() { }

	// RVA: 0x1129058
	public int get_Years() { }

	// RVA: 0x1129060
	public int get_Months() { }

	// RVA: 0x1129068
	public int get_Days() { }

	// RVA: 0x1129070
	public int get_Hours() { }

	// RVA: 0x1129078
	public int get_Minutes() { }

	// RVA: 0x1129080
	public int get_Seconds() { }

	// RVA: 0x1129040
	public int get_Nanoseconds() { }

	// RVA: 0x1129088
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x11290E0
	public TimeSpan ToTimeSpan(DurationType durationType) { }

	// RVA: 0x112964C
	internal Exception TryToTimeSpan(TimeSpan result) { }

	// RVA: 0x1129134
	internal Exception TryToTimeSpan(DurationType durationType, TimeSpan result) { }

	// RVA: 0x1129658
	public override string ToString() { }

	// RVA: 0x1129660
	internal string ToString(DurationType durationType) { }

	// RVA: 0x1129A98
	internal static Exception TryParse(string s, XsdDuration result) { }

	// RVA: 0x1128910
	internal static Exception TryParse(string s, DurationType durationType, XsdDuration result) { }

	// RVA: 0x1129AA4
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

	// RVA: 0x1129C4C
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x112A070
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1129C7C
	private void Init() { }

	// RVA: 0x112A1F8
	public override void Validate() { }

	// RVA: 0x112A8F8
	public override void CompleteValidation() { }

	// RVA: 0x112A2CC
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x112A2DC
	private void ProcessInlineSchema() { }

	// RVA: 0x112A58C
	private void ValidateElement() { }

	// RVA: 0x112AA28
	private object ValidateChildElement() { }

	// RVA: 0x112AC60
	private void ProcessElement(object particle) { }

	// RVA: 0x112B0BC
	private void ProcessXsiAttributes(XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x112A718
	private void ValidateEndElement() { }

	// RVA: 0x112AFBC
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x112B8C4
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x112BD3C
	private void ValidateStartElement() { }

	// RVA: 0x112C47C
	private void ValidateEndStartElement() { }

	// RVA: 0x112E074
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x112C904
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x112BCB8
	private bool get_HasSchema() { }

	// RVA: 0x112E5F0
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x112E62C
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x112CAC8
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x112E8A8
	internal void AddID(string name, object node) { }

	// RVA: 0x112E948
	public override object FindId(string name) { }

	// RVA: 0x112AC14
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x112A0A0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x112DC20
	private void Pop() { }

	// RVA: 0x112A8FC
	private void CheckForwardRefs() { }

	// RVA: 0x112BCE0
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x112CFB4
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x112E964
	private void AddIdentityConstraints() { }

	// RVA: 0x112ED70
	private void ElementIdentityConstraints() { }

	// RVA: 0x112DDA4
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x112DD18
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x112CFC4
	private void EndElementIdentityConstraints() { }

	// RVA: 0x112F0C0
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AbsoluteQuery
{
	// Methods

	// RVA: 0x112F180
	public void .ctor() { }

	// RVA: 0x112F1D0
	private void .ctor(AbsoluteQuery other) { }

	// RVA: 0x112F248
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x112F2C8
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

	// RVA: 0x112F348
	protected void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AttributeQuery
{
	// Fields
	private bool _onAttribute; // 0x54

	// Methods

	// RVA: 0x112F350
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x112F43C
	private void .ctor(AttributeQuery other) { }

	// RVA: 0x112F510
	public override void Reset() { }

	// RVA: 0x112F59C
	public override XPathNavigator Advance() { }

	// RVA: 0x112F694
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

	// RVA: 0x112F708
	public void .ctor(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x112F7D4
	public void .ctor(AxisType axisType, AstNode input) { }

	// RVA: 0x112F8C4
	public override AstType get_Type() { }

	// RVA: 0x112F8CC
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x112F8D4
	public AstNode get_Input() { }

	// RVA: 0x112F8DC
	public void set_Input(AstNode value) { }

	// RVA: 0x112F8E4
	public string get_Prefix() { }

	// RVA: 0x112F8EC
	public string get_Name() { }

	// RVA: 0x112F8F4
	public XPathNodeType get_NodeType() { }

	// RVA: 0x112F8FC
	public AxisType get_TypeOfAxis() { }

	// RVA: 0x112F904
	public bool get_AbbrAxis() { }

	// RVA: 0x112F90C
	public string get_Urn() { }

	// RVA: 0x112F914
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

	// RVA: 0x112F91C
	protected void .ctor(Query qyInput) { }

	// RVA: 0x112F354
	protected void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x112F470
	protected void .ctor(BaseAxisQuery other) { }

	// RVA: 0x112F558
	public override void Reset() { }

	// RVA: 0x112F9CC
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x112FA34
	protected string get_Name() { }

	// RVA: 0x112FA3C
	protected string get_Namespace() { }

	// RVA: 0x112FA44
	protected bool get_NameTest() { }

	// RVA: 0x112FA4C
	protected XPathNodeType get_TypeTest() { }

	// RVA: 0x112FA54
	public override int get_CurrentPosition() { }

	// RVA: 0x112FA5C
	public override XPathNavigator get_Current() { }

	// RVA: 0x112FA64
	public virtual bool matches(XPathNavigator e) { }

	// RVA: 0x112FB90
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x112FBEC
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

	// RVA: 0x112FBF4
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x112FD80
	private void .ctor(BooleanExpr other) { }

	// RVA: 0x112FDF0
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x112FE44
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x112FF20
	public override XPathNodeIterator Clone() { }

	// RVA: 0x112FFD0
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class BooleanFunctions
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _funcType; // 0x20

	// Methods

	// RVA: 0x112FD38
	public void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0x112FFD8
	private void .ctor(BooleanFunctions other) { }

	// RVA: 0x113002C
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1130048
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1130548
	internal static bool toBoolean(Double number) { }

	// RVA: 0x1130568
	internal static bool toBoolean(string str) { }

	// RVA: 0x113023C
	internal bool toBoolean(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113058C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x11303E0
	private bool Not(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1130480
	private bool Lang(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1130594
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheAxisQuery
{
	// Fields
	protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer; // 0x58

	// Methods

	// RVA: 0x1130628
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x11306E8
	protected void .ctor(CacheAxisQuery other) { }

	// RVA: 0x113079C
	public override void Reset() { }

	// RVA: 0x11307A4
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1130898
	public override XPathNavigator Advance() { }

	// RVA: 0x1130938
	public override XPathNavigator get_Current() { }

	// RVA: 0x11309C0
	public override int get_CurrentPosition() { }

	// RVA: 0x11309C8
	public override int get_Count() { }

	// RVA: 0x1130A14
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

	// RVA: 0x1130A1C
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x1130C2C
	private void .ctor(CacheChildrenQuery other) { }

	// RVA: 0x1130DB0
	public override void Reset() { }

	// RVA: 0x1130F84
	public override XPathNavigator Advance() { }

	// RVA: 0x1131210
	private bool DecideNextNode() { }

	// RVA: 0x1131190
	private XPathNavigator GetNextInput() { }

	// RVA: 0x11313A8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheOutputQuery
{
	// Fields
	internal Query input; // 0x18
	protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer; // 0x20

	// Methods

	// RVA: 0x113140C
	public void .ctor(Query input) { }

	// RVA: 0x11314BC
	protected void .ctor(CacheOutputQuery other) { }

	// RVA: 0x1131590
	public override void Reset() { }

	// RVA: 0x1131598
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x11315C0
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1131684
	public override XPathNavigator Advance() { }

	// RVA: 0x1131724
	public override XPathNavigator get_Current() { }

	// RVA: 0x11317AC
	public override XPathResultType get_StaticType() { }

	// RVA: 0x11317B4
	public override int get_CurrentPosition() { }

	// RVA: 0x11317BC
	public override int get_Count() { }

	// RVA: 0x1131808
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ChildrenQuery
{
	// Fields
	private XPathNodeIterator _iterator; // 0x58

	// Methods

	// RVA: 0x1130B84
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x1130D08
	protected void .ctor(ChildrenQuery other) { }

	// RVA: 0x1130EE8
	public override void Reset() { }

	// RVA: 0x1131810
	public override XPathNavigator Advance() { }

	// RVA: 0x11319D8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ClonableStack<T0>
{
	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D4CD4
	private void .ctor(System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0x318DB98
	public void Push(T value) { }

	// RVA: 0x318DB98
	public T Pop() { }

	// RVA: 0x318DB98
	public T Peek() { }

	// RVA: 0x30D3CF0
	public MS.Internal.Xml.XPath.ClonableStack<T> Clone() { }

}

// Namespace: 
private class UndefinedXsltContext
{
	// Fields
	private IXmlNamespaceResolver _nsResolver; // 0x50

	// Methods

	// RVA: 0x1131C28
	public void .ctor(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1131C60
	public override string get_DefaultNamespace() { }

	// RVA: 0x1131CAC
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1131DEC
	public override IXsltContextVariable ResolveVariable(string prefix, string name) { }

	// RVA: 0x1131E28
	public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) { }

	// RVA: 0x1131E64
	public override bool get_Whitespace() { }

	// RVA: 0x1131E6C
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

	// RVA: 0x1131A3C
	internal void .ctor(Query query, string expression, bool needContext) { }

	// RVA: 0x1131A98
	internal Query get_QueryTree() { }

	// RVA: 0x1131AEC
	public override void SetContext(IXmlNamespaceResolver nsResolver) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ContextQuery
{
	// Fields
	protected XPathNavigator contextNode; // 0x18

	// Methods

	// RVA: 0x112F1A8
	public void .ctor() { }

	// RVA: 0x112F20C
	protected void .ctor(ContextQuery other) { }

	// RVA: 0x1131E74
	public override void Reset() { }

	// RVA: 0x1131E7C
	public override XPathNavigator get_Current() { }

	// RVA: 0x1131E84
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1131ED4
	public override XPathNavigator Advance() { }

	// RVA: 0x1131EF4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1131F74
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1131F7C
	public override int get_CurrentPosition() { }

	// RVA: 0x1131F84
	public override int get_Count() { }

	// RVA: 0x1131F8C
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class DescendantBaseQuery
{
	// Fields
	protected bool matchSelf; // 0x54
	protected bool abbrAxis; // 0x55

	// Methods

	// RVA: 0x1131F94
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x1131FCC
	public void .ctor(DescendantBaseQuery other) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class DescendantQuery
{
	// Fields
	private XPathNodeIterator _nodeIterator; // 0x58

	// Methods

	// RVA: 0x1132000
	internal void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x1132038
	public void .ctor(DescendantQuery other) { }

	// RVA: 0x1132084
	public override void Reset() { }

	// RVA: 0x11320D4
	public override XPathNavigator Advance() { }

	// RVA: 0x1132284
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DescendantOverDescendantQuery
{
	// Fields
	private int _level; // 0x58

	// Methods

	// RVA: 0x1132314
	public void .ctor(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis) { }

	// RVA: 0x1132358
	private void .ctor(DescendantOverDescendantQuery other) { }

	// RVA: 0x1132394
	public override void Reset() { }

	// RVA: 0x11323DC
	public override XPathNavigator Advance() { }

	// RVA: 0x113254C
	private bool MoveToFirstChild() { }

	// RVA: 0x1132594
	private bool MoveUpUntilNext() { }

	// RVA: 0x1132600
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DocumentOrderQuery
{
	// Methods

	// RVA: 0x113267C
	public void .ctor(Query qyParent) { }

	// RVA: 0x1132680
	private void .ctor(DocumentOrderQuery other) { }

	// RVA: 0x1132684
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x11326E0
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class EmptyQuery
{
	// Methods

	// RVA: 0x1132744
	public override XPathNavigator Advance() { }

	// RVA: 0x113274C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1132750
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1132754
	public override int get_CurrentPosition() { }

	// RVA: 0x113275C
	public override int get_Count() { }

	// RVA: 0x1132764
	public override QueryProps get_Properties() { }

	// RVA: 0x113276C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1132774
	public override void Reset() { }

	// RVA: 0x1132778
	public override XPathNavigator get_Current() { }

	// RVA: 0x1132780
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

	// RVA: 0x1132788
	public void .ctor(string prefix, string name) { }

	// RVA: 0x11327D8
	protected void .ctor(ExtensionQuery other) { }

	// RVA: 0x1132900
	public override void Reset() { }

	// RVA: 0x1132918
	public override XPathNavigator get_Current() { }

	// RVA: 0x11329A4
	public override XPathNavigator Advance() { }

	// RVA: 0x1132A2C
	public override int get_CurrentPosition() { }

	// RVA: 0x1132A44
	protected object ProcessResult(object value) { }

	// RVA: 0x1132EB0
	protected string get_QName() { }

	// RVA: 0x1132F24
	public override int get_Count() { }

	// RVA: 0x1132F40
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Filter
{
	// Fields
	private AstNode _input; // 0x10
	private AstNode _condition; // 0x18

	// Methods

	// RVA: 0x1132F48
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x1132F98
	public override AstType get_Type() { }

	// RVA: 0x1132FA0
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1132FA8
	public AstNode get_Input() { }

	// RVA: 0x1132FB0
	public AstNode get_Condition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FilterQuery
{
	// Fields
	private Query _cond; // 0x58
	private bool _noPosition; // 0x60

	// Methods

	// RVA: 0x1132FB8
	public void .ctor(Query qyParent, Query cond, bool noPosition) { }

	// RVA: 0x1132FFC
	private void .ctor(FilterQuery other) { }

	// RVA: 0x113304C
	public override void Reset() { }

	// RVA: 0x11330A4
	public Query get_Condition() { }

	// RVA: 0x11330AC
	public override void SetXsltContext(XsltContext input) { }

	// RVA: 0x11331E0
	public override XPathNavigator Advance() { }

	// RVA: 0x113326C
	internal bool EvaluatePredicate() { }

	// RVA: 0x1133440
	public override QueryProps get_Properties() { }

	// RVA: 0x1133474
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

	// RVA: 0x1133504
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x1133610
	private void .ctor(FollSiblingQuery other) { }

	// RVA: 0x1133708
	public override void Reset() { }

	// RVA: 0x1133834
	private bool Visited(XPathNavigator nav) { }

	// RVA: 0x113394C
	private XPathNavigator FetchInput() { }

	// RVA: 0x11339B8
	public override XPathNavigator Advance() { }

	// RVA: 0x1133C48
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FollowingQuery
{
	// Fields
	private XPathNavigator _input; // 0x58
	private XPathNodeIterator _iterator; // 0x60

	// Methods

	// RVA: 0x1133CAC
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1133CB0
	private void .ctor(FollowingQuery other) { }

	// RVA: 0x1133D10
	public override void Reset() { }

	// RVA: 0x1133D60
	public override XPathNavigator Advance() { }

	// RVA: 0x1133FE8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ForwardPositionQuery
{
	// Methods

	// RVA: 0x113408C
	public void .ctor(Query input) { }

	// RVA: 0x1134090
	protected void .ctor(ForwardPositionQuery other) { }

	// RVA: 0x1134094
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1134144
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

	// RVA: 0x11341A8
	public void .ctor(FunctionType ftype, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }

	// RVA: 0x113424C
	public void .ctor(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }

	// RVA: 0x1134320
	public void .ctor(FunctionType ftype, AstNode arg) { }

	// RVA: 0x11343EC
	public override AstType get_Type() { }

	// RVA: 0x11343F4
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1134498
	public FunctionType get_TypeOfFunction() { }

	// RVA: 0x11344A0
	public System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> get_ArgumentList() { }

	// RVA: 0x11344A8
	public string get_Prefix() { }

	// RVA: 0x11344B0
	public string get_Name() { }

	// RVA: 0x11344B8
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FunctionQuery
{
	// Fields
	private System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> _args; // 0x38
	private IXsltContextFunction _function; // 0x40

	// Methods

	// RVA: 0x113455C
	public void .ctor(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> args) { }

	// RVA: 0x11345C0
	private void .ctor(FunctionQuery other) { }

	// RVA: 0x11347DC
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1134D5C
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11352DC
	public override XPathResultType get_StaticType() { }

	// RVA: 0x113539C
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Group
{
	// Fields
	private AstNode _groupNode; // 0x10

	// Methods

	// RVA: 0x1135400
	public void .ctor(AstNode groupNode) { }

	// RVA: 0x1135434
	public override AstType get_Type() { }

	// RVA: 0x113543C
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1135444
	public AstNode get_GroupNode() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class GroupQuery
{
	// Methods

	// RVA: 0x113544C
	public void .ctor(Query qy) { }

	// RVA: 0x1135450
	private void .ctor(GroupQuery other) { }

	// RVA: 0x1135454
	public override XPathNavigator Advance() { }

	// RVA: 0x11354B4
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11354DC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1135540
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1135568
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class IDQuery
{
	// Methods

	// RVA: 0x1135570
	public void .ctor(Query arg) { }

	// RVA: 0x1135574
	private void .ctor(IDQuery other) { }

	// RVA: 0x1135578
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x11357CC
	private void ProcessIds(XPathNavigator contextNode, string val) { }

	// RVA: 0x11358D4
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

	// RVA: 0x1131988
	internal void .ctor(XPathNodeIterator innerIterator, string name) { }

	// RVA: 0x1135938
	private void .ctor(IteratorFilter it) { }

	// RVA: 0x11359A4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1135A4C
	public override XPathNavigator get_Current() { }

	// RVA: 0x1135A70
	public override int get_CurrentPosition() { }

	// RVA: 0x1135A78
	public override bool MoveNext() { }

}

// Namespace: 
private sealed class cmpXslt
{
	// Methods

	// RVA: 0x113A52C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x113A5D0
	public virtual bool Invoke(Op op, object val1, object val2) { }

}

// Namespace: 
private struct NodeSet
{
	// Fields
	private Query _opnd; // 0x10
	private XPathNavigator _current; // 0x18

	// Methods

	// RVA: 0x11360F0
	public void .ctor(object opnd) { }

	// RVA: 0x11361C4
	public bool MoveNext() { }

	// RVA: 0x113623C
	public void Reset() { }

	// RVA: 0x1136218
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

	// RVA: 0x1135AFC
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x1135B54
	private void .ctor(LogicalExpr other) { }

	// RVA: 0x1135BC0
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1135C14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1135F70
	private static bool cmpQueryQueryE(Op op, object val1, object val2) { }

	// RVA: 0x1136260
	private static bool cmpQueryQueryO(Op op, object val1, object val2) { }

	// RVA: 0x11365E4
	private static bool cmpQueryNumber(Op op, object val1, object val2) { }

	// RVA: 0x11367D0
	private static bool cmpQueryStringE(Op op, object val1, object val2) { }

	// RVA: 0x1136944
	private static bool cmpQueryStringO(Op op, object val1, object val2) { }

	// RVA: 0x1136BC0
	private static bool cmpRtfQueryE(Op op, object val1, object val2) { }

	// RVA: 0x1136DF8
	private static bool cmpRtfQueryO(Op op, object val1, object val2) { }

	// RVA: 0x1137068
	private static bool cmpQueryBoolE(Op op, object val1, object val2) { }

	// RVA: 0x1137190
	private static bool cmpQueryBoolO(Op op, object val1, object val2) { }

	// RVA: 0x113717C
	private static bool cmpBoolBoolE(Op op, bool n1, bool n2) { }

	// RVA: 0x1137374
	private static bool cmpBoolBoolE(Op op, object val1, object val2) { }

	// RVA: 0x113746C
	private static bool cmpBoolBoolO(Op op, object val1, object val2) { }

	// RVA: 0x1137610
	private static bool cmpBoolNumberE(Op op, object val1, object val2) { }

	// RVA: 0x1137738
	private static bool cmpBoolNumberO(Op op, object val1, object val2) { }

	// RVA: 0x11378E0
	private static bool cmpBoolStringE(Op op, object val1, object val2) { }

	// RVA: 0x11379DC
	private static bool cmpRtfBoolE(Op op, object val1, object val2) { }

	// RVA: 0x1137B44
	private static bool cmpBoolStringO(Op op, object val1, object val2) { }

	// RVA: 0x1137D20
	private static bool cmpRtfBoolO(Op op, object val1, object val2) { }

	// RVA: 0x1136570
	private static bool cmpNumberNumber(Op op, Double n1, Double n2) { }

	// RVA: 0x1136B64
	private static bool cmpNumberNumberO(Op op, Double n1, Double n2) { }

	// RVA: 0x1137F88
	private static bool cmpNumberNumber(Op op, object val1, object val2) { }

	// RVA: 0x1138138
	private static bool cmpStringNumber(Op op, object val1, object val2) { }

	// RVA: 0x1138330
	private static bool cmpRtfNumber(Op op, object val1, object val2) { }

	// RVA: 0x113690C
	private static bool cmpStringStringE(Op op, string n1, string n2) { }

	// RVA: 0x113859C
	private static bool cmpStringStringE(Op op, object val1, object val2) { }

	// RVA: 0x113866C
	private static bool cmpRtfStringE(Op op, object val1, object val2) { }

	// RVA: 0x11387AC
	private static bool cmpRtfRtfE(Op op, object val1, object val2) { }

	// RVA: 0x1138928
	private static bool cmpStringStringO(Op op, object val1, object val2) { }

	// RVA: 0x1138B44
	private static bool cmpRtfStringO(Op op, object val1, object val2) { }

	// RVA: 0x1138DE8
	private static bool cmpRtfRtfO(Op op, object val1, object val2) { }

	// RVA: 0x1139080
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1136D70
	private static string Rtf(object o) { }

	// RVA: 0x1139130
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1139138
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class MergeFilterQuery
{
	// Fields
	private Query _child; // 0x28

	// Methods

	// RVA: 0x113A5E4
	public void .ctor(Query input, Query child) { }

	// RVA: 0x113A614
	private void .ctor(MergeFilterQuery other) { }

	// RVA: 0x113A658
	public override void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x113A6AC
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113A740
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NamespaceQuery
{
	// Fields
	private bool _onNamespace; // 0x54

	// Methods

	// RVA: 0x113A7C8
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x113A7CC
	private void .ctor(NamespaceQuery other) { }

	// RVA: 0x113A800
	public override void Reset() { }

	// RVA: 0x113A848
	public override XPathNavigator Advance() { }

	// RVA: 0x113A930
	public override bool matches(XPathNavigator e) { }

	// RVA: 0x113A9C4
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

	// RVA: 0x113AA38
	public void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0x113AA7C
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x113AAF4
	private XPathNavigator EvaluateArg(XPathNodeIterator context) { }

	// RVA: 0x113AB60
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x113AE6C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x113AF10
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NumberFunctions
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _ftype; // 0x20

	// Methods

	// RVA: 0x113AFAC
	public void .ctor(FunctionType ftype, Query arg) { }

	// RVA: 0x113AFF4
	private void .ctor(NumberFunctions other) { }

	// RVA: 0x113B048
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1137360
	internal static Double Number(bool arg) { }

	// RVA: 0x11364E8
	internal static Double Number(string arg) { }

	// RVA: 0x113B064
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113B1A8
	private Double Number(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113B43C
	private Double Sum(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113B52C
	private Double Floor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113B5F4
	private Double Ceiling(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113B6BC
	private Double Round(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113B750
	public override XPathResultType get_StaticType() { }

	// RVA: 0x113B758
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

	// RVA: 0x113B7EC
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x113B914
	private void .ctor(NumericExpr other) { }

	// RVA: 0x113B980
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x113B9D4
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113BB24
	private static Double GetValue(Op op, Double n1, Double n2) { }

	// RVA: 0x113BB84
	public override XPathResultType get_StaticType() { }

	// RVA: 0x113BB8C
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Operand
{
	// Fields
	private XPathResultType _type; // 0x10
	private object _val; // 0x18

	// Methods

	// RVA: 0x113BC3C
	public void .ctor(string val) { }

	// RVA: 0x113BC78
	public void .ctor(Double val) { }

	// RVA: 0x113BD08
	public override AstType get_Type() { }

	// RVA: 0x113BD10
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x113BD18
	public object get_OperandValue() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class OperandQuery
{
	// Fields
	internal object val; // 0x18

	// Methods

	// RVA: 0x113BD20
	public void .ctor(object val) { }

	// RVA: 0x113BD54
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113BD5C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x113BD68
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

	// RVA: 0x1135ED0
	public static Op InvertOperator(Op op) { }

	// RVA: 0x113BD6C
	public void .ctor(Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x113BDC4
	public override AstType get_Type() { }

	// RVA: 0x113BDCC
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x113BDEC
	public Op get_OperatorType() { }

	// RVA: 0x113BDF4
	public AstNode get_Operand1() { }

	// RVA: 0x113BDFC
	public AstNode get_Operand2() { }

	// RVA: 0x113BE04
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ParentQuery
{
	// Methods

	// RVA: 0x113BEA8
	public void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x113BF68
	private void .ctor(ParentQuery other) { }

	// RVA: 0x113BF6C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x113C014
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class PreSiblingQuery
{
	// Methods

	// RVA: 0x113C078
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x113C138
	protected void .ctor(PreSiblingQuery other) { }

	// RVA: 0x113C13C
	private static bool NotVisited(XPathNavigator nav, System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> parentStk) { }

	// RVA: 0x113C268
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x113C540
	public override XPathNodeIterator Clone() { }

	// RVA: 0x113C5A4
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class PrecedingQuery
{
	// Fields
	private XPathNodeIterator _workIterator; // 0x58
	private MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator> _ancestorStk; // 0x60

	// Methods

	// RVA: 0x113C5AC
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x113C664
	private void .ctor(PrecedingQuery other) { }

	// RVA: 0x113C700
	public override void Reset() { }

	// RVA: 0x113C7D4
	public override XPathNavigator Advance() { }

	// RVA: 0x113CA98
	public override XPathNodeIterator Clone() { }

	// RVA: 0x113CAFC
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

	// RVA: 0x113CB18
	public void .ctor() { }

	// RVA: 0x113CB70
	protected void .ctor(Query other) { }

	// RVA: 0x113CBE0
	public override bool MoveNext() { }

	// RVA: 0x113CC08
	public override int get_Count() { }

	// RVA: 0x113CCF0
	public virtual void SetXsltContext(XsltContext context) { }

	// RVA: -1
	public abstract object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: -1
	public abstract XPathNavigator Advance() { }

	// RVA: -1
	public abstract XPathResultType get_StaticType() { }

	// RVA: 0x113CCF4
	public virtual QueryProps get_Properties() { }

	// RVA: 0x113CCFC
	public static Query Clone(Query input) { }

	// RVA: 0x113CD98
	protected static XPathNodeIterator Clone(XPathNodeIterator input) { }

	// RVA: 0x113CDAC
	protected static XPathNavigator Clone(XPathNavigator input) { }

	// RVA: 0x113CDC4
	public static bool Insert(System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> buffer, XPathNavigator nav) { }

	// RVA: 0x113D098
	private static int GetMedian(int l, int r) { }

	// RVA: 0x113CF74
	public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r) { }

	// RVA: 0x113D0A4
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

	// RVA: 0x113D1C0
	private void Reset() { }

	// RVA: 0x113D1CC
	private Query ProcessAxis(Axis root, Flags flags, Props props) { }

	// RVA: 0x113DD2C
	private static bool CanBeNumber(Query q) { }

	// RVA: 0x113DD94
	private Query ProcessFilter(Filter root, Flags flags, Props props) { }

	// RVA: 0x113E2A8
	private Query ProcessOperator(Operator root, Props props) { }

	// RVA: 0x113E528
	private Query ProcessVariable(Variable root) { }

	// RVA: 0x113E600
	private Query ProcessFunction(Function root, Props props) { }

	// RVA: 0x113EB0C
	private System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> ProcessArguments(System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> args, Props props) { }

	// RVA: 0x113D938
	private Query ProcessNode(AstNode root, Flags flags, Props props) { }

	// RVA: 0x113ECD0
	private Query Build(AstNode root, string query) { }

	// RVA: 0x113ED24
	internal Query Build(string query, bool allowVar, bool allowKey) { }

	// RVA: 0x113EF30
	internal Query Build(string query, bool needContext) { }

	// RVA: 0x113EFF8
	public void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ResetableIterator
{
	// Methods

	// RVA: 0x113CB44
	public void .ctor() { }

	// RVA: 0x113CBA8
	protected void .ctor(ResetableIterator other) { }

	// RVA: 0x113F000
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

	// RVA: 0x113E2A0
	public void .ctor(Query input) { }

	// RVA: 0x113F00C
	private void .ctor(ReversePositionQuery other) { }

	// RVA: 0x113F014
	public override XPathNodeIterator Clone() { }

	// RVA: 0x113F07C
	public override int get_CurrentPosition() { }

	// RVA: 0x113F0D4
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Root
{
	// Methods

	// RVA: 0x113F0F0
	public void .ctor() { }

	// RVA: 0x113F0F8
	public override AstType get_Type() { }

	// RVA: 0x113F100
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

	// RVA: 0x113EC88
	public void .ctor(FunctionType funcType, System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> argList) { }

	// RVA: 0x113F134
	private void .ctor(StringFunctions other) { }

	// RVA: 0x113F3E0
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x113F56C
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1141250
	internal static string toString(Double num) { }

	// RVA: 0x11412B8
	internal static string toString(bool b) { }

	// RVA: 0x113F77C
	private string toString(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1141324
	public override XPathResultType get_StaticType() { }

	// RVA: 0x113FBF0
	private string Concat(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113FDE4
	private bool StartsWith(XPathNodeIterator nodeIterator) { }

	// RVA: 0x113FFC8
	private bool Contains(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11401B8
	private string SubstringBefore(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11403FC
	private string SubstringAfter(XPathNodeIterator nodeIterator) { }

	// RVA: 0x114063C
	private string Substring(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1140A8C
	private Double StringLength(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1140C40
	private string Normalize(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1140EE8
	private string Translate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x114134C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11413B0
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

	// RVA: 0x113E4C4
	public void .ctor(Query query1, Query query2) { }

	// RVA: 0x1141460
	private void .ctor(UnionExpr other) { }

	// RVA: 0x1141644
	public override void Reset() { }

	// RVA: 0x11416A0
	public override void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x11416F4
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1141770
	private XPathNavigator ProcessSamePosition(XPathNavigator result) { }

	// RVA: 0x11417A8
	private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x11417F0
	private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x1141834
	public override XPathNavigator Advance() { }

	// RVA: 0x11419E4
	public override XPathResultType get_StaticType() { }

	// RVA: 0x11419EC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1141A50
	public override XPathNavigator get_Current() { }

	// RVA: 0x1141A58
	public override int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ValueQuery
{
	// Methods

	// RVA: 0x113F108
	public void .ctor() { }

	// RVA: 0x113F3A8
	protected void .ctor(ValueQuery other) { }

	// RVA: 0x1141A98
	public sealed override void Reset() { }

	// RVA: 0x1141A9C
	public sealed override XPathNavigator get_Current() { }

	// RVA: 0x1141AD8
	public sealed override int get_CurrentPosition() { }

	// RVA: 0x1141B14
	public sealed override int get_Count() { }

	// RVA: 0x1141B50
	public sealed override XPathNavigator Advance() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Variable
{
	// Fields
	private string _localname; // 0x10
	private string _prefix; // 0x18

	// Methods

	// RVA: 0x1141B8C
	public void .ctor(string name, string prefix) { }

	// RVA: 0x1141BDC
	public override AstType get_Type() { }

	// RVA: 0x1141BE4
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1141BEC
	public string get_Localname() { }

	// RVA: 0x1141BF4
	public string get_Prefix() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class VariableQuery
{
	// Fields
	private IXsltContextVariable _variable; // 0x38

	// Methods

	// RVA: 0x113E5EC
	public void .ctor(string name, string prefix) { }

	// RVA: 0x1141BFC
	private void .ctor(VariableQuery other) { }

	// RVA: 0x1141C38
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1141D0C
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1141E08
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1141F78
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathAncestorQuery
{
	// Fields
	private bool _matchSelf; // 0x60

	// Methods

	// RVA: 0x113DCF8
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf) { }

	// RVA: 0x1141FF8
	private void .ctor(XPathAncestorQuery other) { }

	// RVA: 0x1142030
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x114215C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11421D4
	public override int get_CurrentPosition() { }

	// RVA: 0x114222C
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathArrayIterator
{
	// Fields
	protected IList list; // 0x18
	protected int index; // 0x20

	// Methods

	// RVA: 0x1142248
	public void .ctor(XPathArrayIterator it) { }

	// RVA: 0x1142298
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1142404
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1142490
	public override XPathNavigator get_Current() { }

	// RVA: 0x1142610
	public override int get_CurrentPosition() { }

	// RVA: 0x1142618
	public override int get_Count() { }

	// RVA: 0x11426D0
	public override bool MoveNext() { }

	// RVA: 0x11427B8
	public override void Reset() { }

	// RVA: 0x11427C0
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

	// RVA: 0x1142874
	public void .ctor(XPathNavigator nav, bool matchSelf) { }

	// RVA: 0x11428C4
	public void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x114291C
	public void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x1142A0C
	public void .ctor(XPathAxisIterator it) { }

	// RVA: 0x1142AA4
	public override XPathNavigator get_Current() { }

	// RVA: 0x1142AAC
	public override int get_CurrentPosition() { }

	// RVA: 0x1142AB4
	protected virtual bool get_Matches() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathChildIterator
{
	// Methods

	// RVA: 0x1142C14
	public void .ctor(XPathNavigator nav, XPathNodeType type) { }

	// RVA: 0x1142C68
	public void .ctor(XPathNavigator nav, string name, string namespaceURI) { }

	// RVA: 0x1142C70
	public void .ctor(XPathChildIterator it) { }

	// RVA: 0x1142C74
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1142CD8
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathDescendantIterator
{
	// Fields
	private int _level; // 0x40

	// Methods

	// RVA: 0x1142D80
	public void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x1142DD8
	public void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x1142DDC
	public void .ctor(XPathDescendantIterator it) { }

	// RVA: 0x1142E10
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1142E84
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathEmptyIterator
{
	// Fields
	public static XPathEmptyIterator Instance; // 0x0

	// Methods

	// RVA: 0x1142F84
	private void .ctor() { }

	// RVA: 0x1142FB0
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1142FB4
	public override XPathNavigator get_Current() { }

	// RVA: 0x1142FBC
	public override int get_CurrentPosition() { }

	// RVA: 0x1142FC4
	public override int get_Count() { }

	// RVA: 0x1142FCC
	public override bool MoveNext() { }

	// RVA: 0x1142FD4
	public override void Reset() { }

	// RVA: 0x1142FD8
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

	// RVA: 0x114716C
	public FunctionType get_FType() { }

	// RVA: 0x1147174
	public int get_Minargs() { }

	// RVA: 0x114717C
	public int get_Maxargs() { }

	// RVA: 0x1147184
	public XPathResultType[] get_ArgTypes() { }

	// RVA: 0x1146B10
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

	// RVA: 0x114304C
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x113EDE8
	public static AstNode ParseXPathExpression(string xpathExpression) { }

	// RVA: 0x1143188
	private AstNode ParseExpression(AstNode qyInput) { }

	// RVA: 0x11431F8
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x1143308
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x1143484
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x1143770
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x114391C
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x1143A00
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x1143B8C
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x1143C70
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x1143FF8
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x1143DB8
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x11441B0
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x11448AC
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x1144468
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x1144388
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x1144A68
	private static bool IsStep(LexKind lexKind) { }

	// RVA: 0x1144AA8
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x1144E60
	private AstNode ParseNodeTest(AstNode qyInput, AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x11440F8
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x11445D4
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x1145244
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x11451D4
	private void CheckToken(LexKind t) { }

	// RVA: 0x1144A00
	private void PassToken(LexKind t) { }

	// RVA: 0x1143468
	private void NextLex() { }

	// RVA: 0x1143418
	private bool TestOp(string op) { }

	// RVA: 0x1143F94
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x1145F2C
	private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.XPathParser.ParamInfo> CreateFunctionTable() { }

	// RVA: 0x1146B68
	private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable() { }

	// RVA: 0x1144D50
	private AxisType GetAxis() { }

	// RVA: 0x1146E88
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

	// RVA: 0x1143080
	public void .ctor(string xpathExpr) { }

	// RVA: 0x11471F8
	public string get_SourceText() { }

	// RVA: 0x1147200
	private Char get_CurrentChar() { }

	// RVA: 0x114718C
	private bool NextChar() { }

	// RVA: 0x1147208
	public LexKind get_Kind() { }

	// RVA: 0x1147210
	public string get_Name() { }

	// RVA: 0x1147218
	public string get_Prefix() { }

	// RVA: 0x1147220
	public string get_StringValue() { }

	// RVA: 0x1147228
	public Double get_NumberValue() { }

	// RVA: 0x1147230
	public bool get_CanBeFunction() { }

	// RVA: 0x1147238
	private void SkipSpace() { }

	// RVA: 0x1145818
	public bool NextLex() { }

	// RVA: 0x1147508
	private Double ScanNumber() { }

	// RVA: 0x11472C0
	private Double ScanFraction() { }

	// RVA: 0x11473CC
	private string ScanString() { }

	// RVA: 0x11476D0
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

	// RVA: 0x1147790
	internal void .ctor(XPathNavigator nav, Query query) { }

	// RVA: 0x1147804
	protected void .ctor(XPathSelectionIterator it) { }

	// RVA: 0x1147928
	public override void Reset() { }

	// RVA: 0x114794C
	public override bool MoveNext() { }

	// RVA: 0x11479E4
	public override int get_Count() { }

	// RVA: 0x1147A08
	public override XPathNavigator get_Current() { }

	// RVA: 0x1147A10
	public override int get_CurrentPosition() { }

	// RVA: 0x1147A18
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathSelfQuery
{
	// Methods

	// RVA: 0x113DD24
	public void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1147A7C
	private void .ctor(XPathSelfQuery other) { }

	// RVA: 0x1147A84
	public override XPathNavigator Advance() { }

	// RVA: 0x1147B1C
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathSingletonIterator
{
	// Fields
	private XPathNavigator _nav; // 0x18
	private int _position; // 0x20

	// Methods

	// RVA: 0x1147B84
	public void .ctor(XPathNavigator nav) { }

	// RVA: 0x1147BC0
	public void .ctor(XPathNavigator nav, bool moved) { }

	// RVA: 0x1147C18
	public void .ctor(XPathSingletonIterator it) { }

	// RVA: 0x1147C80
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1147D24
	public override XPathNavigator get_Current() { }

	// RVA: 0x1147D2C
	public override int get_CurrentPosition() { }

	// RVA: 0x1147D34
	public override int get_Count() { }

	// RVA: 0x1147D3C
	public override bool MoveNext() { }

	// RVA: 0x1147D64
	public override void Reset() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathDocumentBaseIterator
{
	// Fields
	protected XPathDocumentNavigator ctxt; // 0x18
	protected int pos; // 0x20

	// Methods

	// RVA: 0x1147D6C
	protected void .ctor(XPathDocumentNavigator ctxt) { }

	// RVA: 0x1147EA4
	protected void .ctor(XPathDocumentBaseIterator iter) { }

	// RVA: 0x1147F38
	public override XPathNavigator get_Current() { }

	// RVA: 0x1147F40
	public override int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentElementChildIterator
{
	// Fields
	private string _localName; // 0x28
	private string _namespaceUri; // 0x30

	// Methods

	// RVA: 0x1147F48
	public void .ctor(XPathDocumentNavigator parent, string name, string namespaceURI) { }

	// RVA: 0x1148070
	public void .ctor(XPathDocumentElementChildIterator iter) { }

	// RVA: 0x1148120
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1148184
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentKindChildIterator
{
	// Fields
	private XPathNodeType _typ; // 0x24

	// Methods

	// RVA: 0x1148214
	public void .ctor(XPathDocumentNavigator parent, XPathNodeType typ) { }

	// RVA: 0x11482A4
	public void .ctor(XPathDocumentKindChildIterator iter) { }

	// RVA: 0x1148338
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1148428
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

	// RVA: 0x11484B8
	public void .ctor(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x1148678
	public void .ctor(XPathDocumentElementDescendantIterator iter) { }

	// RVA: 0x1148744
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11487A8
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

	// RVA: 0x1148918
	public void .ctor(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf) { }

	// RVA: 0x1148A44
	public void .ctor(XPathDocumentKindDescendantIterator iter) { }

	// RVA: 0x1148AF8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1148B5C
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

	// RVA: 0x1148D00
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x1147DE8
	public void .ctor(XPathDocumentNavigator nav) { }

	// RVA: 0x1148DAC
	public override string get_Value() { }

	// RVA: 0x1149314
	public override XPathNavigator Clone() { }

	// RVA: 0x11493F0
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x1149438
	public override string get_LocalName() { }

	// RVA: 0x1149498
	public override string get_NamespaceURI() { }

	// RVA: 0x11494F8
	public override string get_Name() { }

	// RVA: 0x1149610
	public override string get_Prefix() { }

	// RVA: 0x1149670
	public override string get_BaseURI() { }

	// RVA: 0x11497F0
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1149858
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1149980
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1149A60
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1149CBC
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x114A0BC
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x114A2E4
	public override bool MoveToNext() { }

	// RVA: 0x114A3B4
	public override bool MoveToFirstChild() { }

	// RVA: 0x114A58C
	public override bool MoveToParent() { }

	// RVA: 0x114A714
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x114A7C0
	public override bool MoveToId(string id) { }

	// RVA: 0x114A86C
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x114A924
	public override void MoveToRoot() { }

	// RVA: 0x114A9CC
	public override bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x114ABC4
	public override bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x114ADA8
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x114B008
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x114B1A4
	public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x114B788
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x114BC50
	public override XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x114BD14
	public override XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x114BDB4
	public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x114BE30
	public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x114BEE8
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x114C14C
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x114C014
	private int GetPrimaryLocation() { }

	// RVA: 0x114C090
	private int GetSecondaryLocation() { }

	// RVA: 0x114C2CC
	public override object get_UnderlyingObject() { }

	// RVA: 0x114C2DC
	public bool HasLineInfo() { }

	// RVA: 0x114C324
	public int get_LineNumber() { }

	// RVA: 0x114C3E8
	public int get_LinePosition() { }

	// RVA: 0x114C50C
	public int GetPositionHashCode() { }

	// RVA: 0x114881C
	public bool IsElementMatch(string localName, string namespaceURI) { }

	// RVA: 0x1148C60
	public bool IsKindMatch(XPathNodeType typ) { }

	// RVA: 0x114B324
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

	// RVA: 0x114942C
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1149650
	public string get_Prefix() { }

	// RVA: 0x1149478
	public string get_LocalName() { }

	// RVA: 0x1149594
	public string get_Name() { }

	// RVA: 0x11494D8
	public string get_NamespaceUri() { }

	// RVA: 0x1149838
	public XPathDocument get_Document() { }

	// RVA: 0x1149790
	public string get_BaseUri() { }

	// RVA: 0x114C3BC
	public int get_LineNumber() { }

	// RVA: 0x114C4E4
	public int get_LinePosition() { }

	// RVA: 0x114C4B4
	public int get_CollapsedLinePosition() { }

	// RVA: 0x114C568
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x114A9A4
	public int GetRoot(XPathNode[] pageNode) { }

	// RVA: 0x11497B0
	public int GetParent(XPathNode[] pageNode) { }

	// RVA: 0x114A07C
	public int GetSibling(XPathNode[] pageNode) { }

	// RVA: 0x114C588
	public int GetSimilarElement(XPathNode[] pageNode) { }

	// RVA: 0x114C5C8
	public bool NameMatch(string localName, string namespaceName) { }

	// RVA: 0x114C518
	public bool ElementMatch(string localName, string namespaceName) { }

	// RVA: 0x1149FF0
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x114C608
	public bool get_HasSibling() { }

	// RVA: 0x114A474
	public bool get_HasCollapsedText() { }

	// RVA: 0x114C618
	public bool get_HasAttribute() { }

	// RVA: 0x114C624
	public bool get_HasContentChild() { }

	// RVA: 0x114C630
	public bool get_HasElementChild() { }

	// RVA: 0x114C63C
	public bool get_IsAttrNmsp() { }

	// RVA: 0x114C650
	public bool get_IsText() { }

	// RVA: 0x114C6E0
	public bool get_HasNamespaceDecls() { }

	// RVA: 0x114C6EC
	public string get_Value() { }

}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNodeRef
{
	// Fields
	private XPathNode[] _page; // 0x10
	private int _idx; // 0x18

	// Methods

	// RVA: 0x114C6F4
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0x114C720
	public XPathNode[] get_Page() { }

	// RVA: 0x114C728
	public int get_Index() { }

	// RVA: 0x114C730
	public override int GetHashCode() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathNodeHelper
{
	// Methods

	// RVA: 0x1149E44
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x1149EC0
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x11498FC
	public static bool GetFirstAttribute(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1149990
	public static bool GetNextAttribute(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x114A480
	public static bool GetContentChild(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x114A2F4
	public static bool GetContentSibling(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x114A67C
	public static bool GetParent(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x114C290
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x114AA64
	public static bool GetElementChild(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x114AC5C
	public static bool GetElementSibling(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x114AE90
	public static bool GetContentChild(XPathNode[] pageNode, int idxNode, XPathNodeType typ) { }

	// RVA: 0x114B01C
	public static bool GetContentSibling(XPathNode[] pageNode, int idxNode, XPathNodeType typ) { }

	// RVA: 0x1149B3C
	public static bool GetAttribute(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x114B408
	public static bool GetElementFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName) { }

	// RVA: 0x114BAB4
	public static bool GetContentFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ) { }

	// RVA: 0x11490CC
	public static bool GetTextFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x1148FD8
	public static bool GetNonDescendant(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x114C774
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

	// RVA: 0x114C7E0
	public int get_PageNumber() { }

	// RVA: 0x114C7E8
	public int get_NodeCount() { }

	// RVA: 0x114C7F0
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

	// RVA: 0x114C7F8
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x114C800
	public string get_LocalName() { }

	// RVA: 0x114C808
	public string get_NamespaceUri() { }

	// RVA: 0x114C810
	public string get_Prefix() { }

	// RVA: 0x114C818
	public string get_BaseUri() { }

	// RVA: 0x114C820
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x114C828
	public XPathNode[] get_SimilarElementPage() { }

	// RVA: 0x114C830
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x114C838
	public XPathDocument get_Document() { }

	// RVA: 0x114C840
	public int get_LineNumberBase() { }

	// RVA: 0x114C848
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

	// RVA: 0x114C850
	internal static UInt32 ComputeStringHash(string s) { }

}


