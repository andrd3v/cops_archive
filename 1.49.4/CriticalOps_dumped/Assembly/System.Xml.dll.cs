// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0x100FD94
	internal static string GetString(string name, object[] args) { }

	// RVA: 0x100FE08
	internal static string GetString(CultureInfo culture, string name, object[] args) { }

	// RVA: 0x100FE10
	internal static string Format(string resourceFormat, object p1) { }

}

// Namespace: Microsoft.CSharp
internal class CodeDomProvider
{
	// Methods

	// RVA: 0x100FE84
	public void .ctor() { }

}

// Namespace: Microsoft.CSharp
internal class CSharpCodeProvider
{
	// Methods

	// RVA: 0x100FE8C
	public void .ctor() { }

}

// Namespace: System
internal class MonoTODOAttribute
{
	// Methods

	// RVA: 0x100FE94
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

	// RVA: 0x100FE9C
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

	// RVA: 0x100FFD4
	internal void .ctor() { }

	// RVA: -1
	internal abstract void WriteChars(Char[] chars, int index, int count) { }

	// RVA: 0x1010044
	internal void Encode(Byte[] buffer, int index, int count) { }

	// RVA: 0x10103E8
	internal void Flush() { }

}

// Namespace: System.Xml
internal class XmlRawWriterBase64Encoder
{
	// Fields
	private XmlRawWriter rawWriter; // 0x28

	// Methods

	// RVA: 0x1010494
	internal void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0x1010518
	internal override void WriteChars(Char[] chars, int index, int count) { }

}

// Namespace: System.Xml
internal class XmlTextWriterBase64Encoder
{
	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0x1010540
	internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0x10105C4
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

	// RVA: 0x10105E4
	internal override bool get_IsFull() { }

	// RVA: 0x10105F4
	internal override int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0x10109F8
	public static Byte[] Decode(Char[] chars, bool allowOddChars) { }

	// RVA: 0x101076C
	private static void Decode(Char* pChars, Char* pCharsEndPos, Byte* pBytes, Byte* pBytesEndPos, bool hasHalfByteCached, Byte cachedHalfByte, int charsDecoded, int bytesDecoded) { }

}

// Namespace: System.Xml
internal static class BinHexEncoder
{
	// Methods

	// RVA: 0x1010BE4
	internal static void Encode(Byte[] buffer, int index, int count, XmlWriter writer) { }

	// RVA: 0x1010EF0
	internal static string Encode(Byte[] inArray, int offsetIn, int count) { }

	// RVA: 0x1010DB4
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

	// RVA: 0x1011048
	public bool get_IsPositive() { }

	// RVA: 0x1011058
	public void .ctor(Byte[] data, int offset, bool trim) { }

	// RVA: 0x1011308
	private static UInt32 UIntFromByteArray(Byte[] data, int offset) { }

	// RVA: 0x1011564
	private static void MpDiv1(UInt32[] rgulU, int ciulU, UInt32 iulD, UInt32 iulR) { }

	// RVA: 0x101169C
	private static void MpNormalize(UInt32[] rgulU, int ciulU) { }

	// RVA: 0x10116F0
	private static Char ChFromDigit(UInt32 uiDigit) { }

	// RVA: 0x10116FC
	public Decimal ToDecimal() { }

	// RVA: 0x101137C
	private void TrimTrailingZeros() { }

	// RVA: 0x1011824
	public override string ToString() { }

	// RVA: 0x1011D3C
	private static void .cctor() { }

}

// Namespace: System.Xml
internal struct BinXmlSqlMoney
{
	// Fields
	private Int64 data; // 0x10

	// Methods

	// RVA: 0x1011E84
	public void .ctor(int v) { }

	// RVA: 0x1011E90
	public void .ctor(Int64 v) { }

	// RVA: 0x1011E98
	public Decimal ToDecimal() { }

	// RVA: 0x1011F0C
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

	// RVA: 0x1012028
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x1012098
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x10121F4
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x10122B0
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x10123F0
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x1012630
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x10128E4
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x1012A0C
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x1012B44
	private static void BreakDownXsdDateTime(Int64 val, int yr, int mnth, int day, int hr, int min, int sec, int ms) { }

	// RVA: 0x1012D10
	private static void BreakDownXsdDate(Int64 val, int yr, int mnth, int day, bool negTimeZone, int hr, int min) { }

	// RVA: 0x1012E7C
	private static void BreakDownXsdTime(Int64 val, int hr, int min, int sec, int ms) { }

	// RVA: 0x1012F8C
	public static string XsdDateTimeToString(Int64 val) { }

	// RVA: 0x10130A4
	public static string XsdDateToString(Int64 val) { }

	// RVA: 0x1013194
	public static string XsdTimeToString(Int64 val) { }

	// RVA: 0x101335C
	public static string SqlDateTimeToString(int dateticks, UInt32 timeticks) { }

	// RVA: 0x10134B4
	public static DateTime SqlDateTimeToDateTime(int dateticks, UInt32 timeticks) { }

	// RVA: 0x10135B4
	public static string SqlSmallDateTimeToString(Int16 dateticks, UInt16 timeticks) { }

	// RVA: 0x1013714
	public static DateTime SqlSmallDateTimeToDateTime(Int16 dateticks, UInt16 timeticks) { }

	// RVA: 0x1013788
	public static DateTime XsdKatmaiDateToDateTime(Byte[] data, int offset) { }

	// RVA: 0x10138E8
	public static DateTime XsdKatmaiDateTimeToDateTime(Byte[] data, int offset) { }

	// RVA: 0x1013C18
	public static DateTime XsdKatmaiTimeToDateTime(Byte[] data, int offset) { }

	// RVA: 0x1013CA4
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x1013D30
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x1013ECC
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x1013F58
	public static string XsdKatmaiDateToString(Byte[] data, int offset) { }

	// RVA: 0x1014080
	public static string XsdKatmaiDateTimeToString(Byte[] data, int offset) { }

	// RVA: 0x1014320
	public static string XsdKatmaiTimeToString(Byte[] data, int offset) { }

	// RVA: 0x10144A4
	public static string XsdKatmaiDateOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x1014630
	public static string XsdKatmaiDateTimeOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x1014914
	public static string XsdKatmaiTimeOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x1013870
	private static Int64 GetKatmaiDateTicks(Byte[] data, int pos) { }

	// RVA: 0x10139EC
	private static Int64 GetKatmaiTimeTicks(Byte[] data, int pos) { }

	// RVA: 0x1013E74
	private static Int64 GetKatmaiTimeZoneTicks(Byte[] data, int pos) { }

	// RVA: 0x1014208
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x10147D0
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x1014AB0
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

	// RVA: 0x101B68C
	public void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0x1019EC4
	public void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0x101527C
	public void Clear() { }

	// RVA: 0x101AE40
	public bool MatchNs(string lname, string nsUri) { }

	// RVA: 0x101AE90
	public bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0x101B28C
	public void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0x101F988
	public override int GetHashCode() { }

	// RVA: 0x101F9D8
	public int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0x101FA30
	public override bool Equals(object other) { }

	// RVA: 0x101C7F0
	public override string ToString() { }

	// RVA: 0x101FAEC
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

	// RVA: 0x101DD14
	public void Set(QName name, bool xmlspacePreserve) { }

	// RVA: 0x101CA98
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

	// RVA: 0x101B6DC
	public void Set(QName n, string v) { }

	// RVA: 0x101BD5C
	public void Set(QName n, int pos) { }

	// RVA: 0x101C760
	public void GetLocalnameAndNamespaceUri(string localname, string namespaceUri) { }

	// RVA: 0x101C864
	public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, string localname, string namespaceUri) { }

	// RVA: 0x101C7A0
	public bool MatchNS(string localname, string namespaceUri) { }

	// RVA: 0x101C8E4
	public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

	// RVA: 0x101A45C
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

	// RVA: 0x10198C0
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

	// RVA: 0x1015198
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

	// RVA: 0x101DD64
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

	// RVA: 0x1014B78
	public void .ctor(Stream stream, Byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0x1016050
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1016178
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1016180
	public override string get_LocalName() { }

	// RVA: 0x1016188
	public override string get_NamespaceURI() { }

	// RVA: 0x1016190
	public override string get_Prefix() { }

	// RVA: 0x1016198
	public override string get_Value() { }

	// RVA: 0x10170B0
	public override int get_Depth() { }

	// RVA: 0x101718C
	public override string get_BaseURI() { }

	// RVA: 0x1017194
	public override bool get_IsEmptyElement() { }

	// RVA: 0x10171B8
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1017240
	public override string get_XmlLang() { }

	// RVA: 0x1017308
	public override Type get_ValueType() { }

	// RVA: 0x1017310
	public override int get_AttributeCount() { }

	// RVA: 0x101736C
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0x10175E0
	public override string GetAttribute(string name) { }

	// RVA: 0x1017768
	public override string GetAttribute(int i) { }

	// RVA: 0x1017808
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x10179AC
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1017A60
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1017AF4
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1017B8C
	public override bool MoveToElement() { }

	// RVA: 0x1017C7C
	public override bool get_EOF() { }

	// RVA: 0x1017C8C
	public override bool ReadAttributeValue() { }

	// RVA: 0x1018184
	public override void Close() { }

	// RVA: 0x1018228
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1018230
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x101830C
	public override void ResolveEntity() { }

	// RVA: 0x101834C
	public override ReadState get_ReadState() { }

	// RVA: 0x10183F0
	public override bool Read() { }

	// RVA: 0x10191C4
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1019604
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x10197DC
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0x1015300
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0x101995C
	private void AddName() { }

	// RVA: 0x1019B54
	private void AddQName() { }

	// RVA: 0x1019F14
	private void NameFlush() { }

	// RVA: 0x1019F70
	private void SkipExtn() { }

	// RVA: 0x101A14C
	private int ReadQNameRef() { }

	// RVA: 0x1019E1C
	private int ReadNameRef() { }

	// RVA: 0x101A1F4
	private bool FillAllowEOF() { }

	// RVA: 0x101A470
	private void Fill_(int require) { }

	// RVA: 0x101A0BC
	private void Fill(int require) { }

	// RVA: 0x101A564
	private Byte ReadByte() { }

	// RVA: 0x101A614
	private UInt16 ReadUShort() { }

	// RVA: 0x101A080
	private int ParseMB32() { }

	// RVA: 0x101A6E4
	private int ParseMB32_(Byte b) { }

	// RVA: 0x101A78C
	private int ParseMB32(int pos) { }

	// RVA: 0x101A894
	private int ParseMB64() { }

	// RVA: 0x101A8D0
	private BinXmlToken PeekToken() { }

	// RVA: 0x101A94C
	private BinXmlToken ReadToken() { }

	// RVA: 0x101A9D0
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0x101AADC
	private BinXmlToken NextToken1() { }

	// RVA: 0x101ABCC
	private BinXmlToken NextToken() { }

	// RVA: 0x101AC34
	private BinXmlToken PeekNextToken() { }

	// RVA: 0x1017EA4
	private BinXmlToken RescanNextToken() { }

	// RVA: 0x1019A88
	private string ParseText() { }

	// RVA: 0x101ACB4
	private int ScanText(int start) { }

	// RVA: 0x10162F8
	private string GetString(int pos, int cch) { }

	// RVA: 0x101AE00
	private string GetStringAligned(Byte[] data, int offset, int cch) { }

	// RVA: 0x1016F4C
	private string GetAttributeText(int i) { }

	// RVA: 0x1017518
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0x1017660
	private int LocateAttribute(string name) { }

	// RVA: 0x10178C0
	private void PositionOnAttribute(int i) { }

	// RVA: 0x101AEDC
	private void GrowElements() { }

	// RVA: 0x101AF6C
	private void GrowAttributes() { }

	// RVA: 0x101B004
	private void ClearAttributes() { }

	// RVA: 0x101B014
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0x101B388
	private void PopNamespaces(NamespaceDecl firstInScopeChain) { }

	// RVA: 0x101B460
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0x10185E0
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0x101B72C
	private void ScanAttributes() { }

	// RVA: 0x101C178
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0x101C310
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0x101662C
	private string XmlDeclValue() { }

	// RVA: 0x1016468
	private string CDATAValue() { }

	// RVA: 0x101C940
	private void FinishCDATA() { }

	// RVA: 0x101CA2C
	private void FinishEndElement() { }

	// RVA: 0x1018C18
	private bool ReadDoc() { }

	// RVA: 0x101DAC0
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0x101CAC4
	private void ImplReadElement() { }

	// RVA: 0x101CE40
	private void ImplReadEndElement() { }

	// RVA: 0x101CF24
	private void ImplReadDoctype() { }

	// RVA: 0x101D32C
	private void ImplReadPI() { }

	// RVA: 0x101D39C
	private void ImplReadComment() { }

	// RVA: 0x101D3D4
	private void ImplReadCDATA() { }

	// RVA: 0x101D460
	private void ImplReadNest() { }

	// RVA: 0x101D578
	private void ImplReadEndNest() { }

	// RVA: 0x101D5D4
	private void ImplReadXmlText() { }

	// RVA: 0x101DDC0
	private void UpdateFromTextReader() { }

	// RVA: 0x1017898
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0x101DC98
	private void CheckAllowContent() { }

	// RVA: 0x1015420
	private void GenerateTokenTypeMap() { }

	// RVA: 0x1018078
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0x101806C
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0x101BE9C
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x101E140
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x101DE98
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0x101E09C
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0x101E684
	private void CheckValueTokenBounds() { }

	// RVA: 0x101E52C
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0x101E6F0
	private int XsdKatmaiTimeScaleToValueLength(Byte scale) { }

	// RVA: 0x101E7C4
	private Int64 ValueAsLong() { }

	// RVA: 0x101F144
	private UInt64 ValueAsULong() { }

	// RVA: 0x101EEFC
	private Decimal ValueAsDecimal() { }

	// RVA: 0x101ED84
	private Double ValueAsDouble() { }

	// RVA: 0x101F330
	private string ValueAsDateTimeString() { }

	// RVA: 0x10167E4
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0x101EA54
	private Int16 GetInt16(int pos) { }

	// RVA: 0x101EBEC
	private UInt16 GetUInt16(int pos) { }

	// RVA: 0x101EAA0
	private int GetInt32(int pos) { }

	// RVA: 0x101EC38
	private UInt32 GetUInt32(int pos) { }

	// RVA: 0x101EB18
	private Int64 GetInt64(int pos) { }

	// RVA: 0x101ECB0
	private UInt64 GetUInt64(int pos) { }

	// RVA: 0x101F1DC
	private float GetSingle(int offset) { }

	// RVA: 0x101F258
	private Double GetDouble(int offset) { }

	// RVA: 0x1019820
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0x101A4EC
	private Exception ThrowXmlException(string res) { }

	// RVA: 0x101BDAC
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0x101C0F4
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0x101F7D4
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

	// RVA: 0x101FB50
	public void .ctor() { }

	// RVA: 0x101FB7C
	public void PushBit(bool bit) { }

	// RVA: 0x101FCE0
	public bool PopBit() { }

	// RVA: 0x101FD88
	public bool PeekBit() { }

	// RVA: 0x101FBCC
	private void PushCurr() { }

	// RVA: 0x101FD40
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

	// RVA: 0x101FD94
	public static int Count(UInt32 num) { }

	// RVA: 0x101FE3C
	public static int LeastPosition(UInt32 num) { }

	// RVA: 0x101FF58
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

	// RVA: 0x101FFB4
	public void .ctor(int growthRate) { }

	// RVA: 0x1020034
	public void Push(Byte data) { }

	// RVA: 0x1020134
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

	// RVA: 0x1020184
	internal void .ctor() { }

	// RVA: 0x102018C
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x1020318
	public override int get_MaxCharCount() { }

	// RVA: 0x1020320
	internal void set_StartOffset(int value) { }

	// RVA: 0x1020328
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x1020358
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

	// RVA: 0x1020290
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x10203E4
	public override bool Fallback(Char charUnknown, int index) { }

	// RVA: 0x102064C
	public override bool Fallback(Char charUnknownHigh, Char charUnknownLow, int index) { }

	// RVA: 0x1020978
	public override Char GetNextChar() { }

	// RVA: 0x10209D4
	public override bool MovePrevious() { }

	// RVA: 0x10209F0
	public override int get_Remaining() { }

	// RVA: 0x1020A2C
	public override void Reset() { }

	// RVA: 0x102096C
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

	// RVA: 0x1020A38
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1020C6C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1020C9C
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1020CA0
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1020CA4
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1020F34
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x102106C
	internal override void StartElementContent() { }

	// RVA: 0x10211EC
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x102132C
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x102146C
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x10215F8
	public override void WriteEndAttribute() { }

	// RVA: 0x102173C
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1021880
	public override void WriteString(string text) { }

	// RVA: 0x10219D0
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1021A2C
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1021A88
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1021AE4
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1020A68
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x10210C4
	protected void WriteMetaElement() { }

	// RVA: 0x10219B8
	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1021974
	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1021EC8
	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1021B78
	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10216A4
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

	// RVA: 0x102211C
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x10221B8
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1022210
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1022238
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x10224C0
	internal override void StartElementContent() { }

	// RVA: 0x1022578
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1022668
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x102271C
	protected override void FlushBuffer() { }

	// RVA: 0x1022174
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x102246C
	private void WriteIndent() { }

}

// Namespace: System.Xml
internal abstract class HtmlTernaryTree
{
	// Fields
	internal static Byte[] htmlElements; // 0x0
	internal static Byte[] htmlAttributes; // 0x8

	// Methods

	// RVA: 0x102274C
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

	// RVA: 0x102283C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1022A70
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1022A74
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1022A78
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1022D18
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1022E30
	internal override void StartElementContent() { }

	// RVA: 0x1022FB4
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x10230DC
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1023204
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1023380
	public override void WriteEndAttribute() { }

	// RVA: 0x10234C0
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x10235E4
	public override void WriteString(string text) { }

	// RVA: 0x1023714
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1023770
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x10237CC
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1023828
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x102286C
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1022E8C
	protected void WriteMetaElement() { }

	// RVA: 0x10236FC
	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10236B8
	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1023BA8
	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1023870
	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10233F8
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

	// RVA: 0x1124084
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1124114
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1124140
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x112450C
	internal override void StartElementContent() { }

	// RVA: 0x11245CC
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11246C4
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x112477C
	protected override void FlushBuffer() { }

	// RVA: 0x11240D0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x11244B8
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

	// RVA: 0x11247AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11248CC
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

	// RVA: 0x11248E0
	protected void .ctor() { }

}

// Namespace: System.Xml
internal class IncrementalReadDummyDecoder
{
	// Methods

	// RVA: 0x11248E8
	internal override bool get_IsFull() { }

	// RVA: 0x11248F0
	internal override int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0x11248F8
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

	// RVA: 0x1124900
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1124CB0
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1124CF8
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1124D20
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1124D48
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1124D84
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1124F5C
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1124FCC
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x112503C
	internal override void StartElementContent() { }

	// RVA: 0x1125064
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1125090
	public override void WriteEndAttribute() { }

	// RVA: 0x11250BC
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x11250E4
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x112510C
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1125134
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x112515C
	public override void WriteCData(string text) { }

	// RVA: 0x1125184
	public override void WriteComment(string text) { }

	// RVA: 0x11251B0
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11251DC
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11252CC
	public override void WriteString(string text) { }

	// RVA: 0x1125368
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1125438
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1125464
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1125490
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11254BC
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x112558C
	public override void WriteRaw(string data) { }

	// RVA: 0x1125628
	public override void Close() { }

	// RVA: 0x11256D0
	public override void Flush() { }

	// RVA: 0x1125278
	private bool StartCDataSection() { }

	// RVA: 0x1124F54
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

	// RVA: 0x11256F8
	internal void Finish() { }

	// RVA: 0x11259CC
	internal void Reset() { }

	// RVA: 0x1125844
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

	// RVA: 0x11259D8
	public void .ctor(Byte[] nodeBuffer) { }

	// RVA: 0x1124354
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

	// RVA: 0x1125DB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1125E6C
	public virtual int Invoke(string s, int sLen, Int64 additionalEntropy) { }

}

// Namespace: System.Xml
internal class SecureStringHasher
{
	// Fields
	private static HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x1125A0C
	public void .ctor() { }

	// RVA: 0x1125A3C
	public bool Equals(string x, string y) { }

	// RVA: 0x1125A50
	public int GetHashCode(string key) { }

	// RVA: 0x1125D3C
	private static int GetHashCodeOfString(string key, int sLen, Int64 additionalEntropy) { }

	// RVA: 0x1125B18
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

}

// Namespace: System.Xml
internal class TextEncodedRawTextWriter
{
	// Methods

	// RVA: 0x1125E80
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1125F84
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11262B4
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11262B8
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11262BC
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11262C0
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11262C4
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11262C8
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11262CC
	internal override void StartElementContent() { }

	// RVA: 0x11262D0
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11262DC
	public override void WriteEndAttribute() { }

	// RVA: 0x11262E4
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x11262E8
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x11262F0
	public override void WriteCData(string text) { }

	// RVA: 0x11263B0
	public override void WriteComment(string text) { }

	// RVA: 0x11263B4
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11263B8
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11263BC
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x11263C0
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11263C4
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11263D4
	public override void WriteString(string textBlock) { }

	// RVA: 0x11263E4
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11264C4
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11264D4
	public override void WriteRaw(string data) { }

}

// Namespace: System.Xml
internal class TextUtf8RawTextWriter
{
	// Methods

	// RVA: 0x11264E4
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11264EC
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11264F0
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11264F4
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11264F8
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11264FC
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1126500
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1126504
	internal override void StartElementContent() { }

	// RVA: 0x1126508
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1126514
	public override void WriteEndAttribute() { }

	// RVA: 0x112651C
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1126520
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1126528
	public override void WriteCData(string text) { }

	// RVA: 0x1126530
	public override void WriteComment(string text) { }

	// RVA: 0x1126534
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1126538
	public override void WriteEntityRef(string name) { }

	// RVA: 0x112653C
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1126540
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1126544
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1126558
	public override void WriteString(string textBlock) { }

	// RVA: 0x112656C
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1126580
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1126594
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

	// RVA: 0x11265A8
	public void .ctor() { }

	// RVA: 0x11266B0
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x11266E0
	public string get_LocalName() { }

	// RVA: 0x11266E8
	public void set_LocalName(string value) { }

	// RVA: 0x11266F0
	public string get_Namespace() { }

	// RVA: 0x11266F8
	public void set_Namespace(string value) { }

	// RVA: 0x1126700
	public string get_Prefix() { }

	// RVA: 0x1126708
	public void set_Prefix(string value) { }

	// RVA: 0x1126710
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x11267D4
	public int get_Depth() { }

	// RVA: 0x11267DC
	public void set_Depth(int value) { }

	// RVA: 0x11267E4
	public string get_RawValue() { }

	// RVA: 0x11267EC
	public void set_RawValue(string value) { }

	// RVA: 0x11267F4
	public string get_OriginalStringValue() { }

	// RVA: 0x11267FC
	public XmlNodeType get_NodeType() { }

	// RVA: 0x1126804
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x112680C
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x1126814
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x112681C
	public int get_LineNumber() { }

	// RVA: 0x1126824
	public int get_LinePosition() { }

	// RVA: 0x11265D4
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0x112682C
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1126834
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0x1126948
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0x11269FC
	internal void SetItemData(string value) { }

	// RVA: 0x1126A30
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

	// RVA: 0x1126A64
	internal XmlReader get_CoreReader() { }

	// RVA: 0x1126A6C
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0x1126F24
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1126FE0
	private void CheckAsync() { }

	// RVA: 0x1127060
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1127278
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11272AC
	public override string get_Name() { }

	// RVA: 0x11272E0
	public override string get_LocalName() { }

	// RVA: 0x1127314
	public override string get_NamespaceURI() { }

	// RVA: 0x1127348
	public override string get_Prefix() { }

	// RVA: 0x112737C
	public override string get_Value() { }

	// RVA: 0x11273B0
	public override int get_Depth() { }

	// RVA: 0x11273E4
	public override string get_BaseURI() { }

	// RVA: 0x112741C
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1127454
	public override bool get_IsDefault() { }

	// RVA: 0x112748C
	public override Char get_QuoteChar() { }

	// RVA: 0x11274C4
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x11274FC
	public override string get_XmlLang() { }

	// RVA: 0x1127534
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x112756C
	public override Type get_ValueType() { }

	// RVA: 0x11275A4
	public override int get_AttributeCount() { }

	// RVA: 0x11275DC
	public override string GetAttribute(string name) { }

	// RVA: 0x112761C
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x112766C
	public override string GetAttribute(int i) { }

	// RVA: 0x11276AC
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11276EC
	public override void MoveToAttribute(int i) { }

	// RVA: 0x112772C
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1127764
	public override bool MoveToNextAttribute() { }

	// RVA: 0x112779C
	public override bool MoveToElement() { }

	// RVA: 0x11277D4
	public override bool ReadAttributeValue() { }

	// RVA: 0x112780C
	public override bool Read() { }

	// RVA: 0x1127844
	public override bool get_EOF() { }

	// RVA: 0x112787C
	public override void Close() { }

	// RVA: 0x11278B4
	public override ReadState get_ReadState() { }

	// RVA: 0x11278EC
	public override void Skip() { }

	// RVA: 0x1127924
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x112795C
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x112799C
	public override bool get_CanResolveEntity() { }

	// RVA: 0x11279D4
	public override void ResolveEntity() { }

	// RVA: 0x1127A0C
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1127A44
	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x1127A9C
	public override string ReadString() { }

	// RVA: 0x1127AD4
	public override XmlNodeType MoveToContent() { }

	// RVA: 0x1127B0C
	public override void ReadStartElement() { }

	// RVA: 0x1127B44
	public override string ReadElementString() { }

	// RVA: 0x1127B7C
	public override void ReadEndElement() { }

	// RVA: 0x1127BB4
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0x1127C04
	public override string ReadInnerXml() { }

	// RVA: 0x1127C3C
	public override bool get_HasAttributes() { }

	// RVA: 0x1127C74
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1127CC4
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1127CFC
	internal override IDtdInfo get_DtdInfo() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithNS
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0x1126E68
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1127D34
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1127DE8
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1127EA0
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfo
{
	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Methods

	// RVA: 0x1126DAC
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1127F58
	public virtual bool HasLineInfo() { }

	// RVA: 0x112800C
	public virtual int get_LineNumber() { }

	// RVA: 0x11280C4
	public virtual int get_LinePosition() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNS
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0x1126CF0
	public void .ctor(XmlReader reader) { }

	// RVA: 0x112817C
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1128230
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11282E8
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNSSchema
{
	// Fields
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; // 0x30

	// Methods

	// RVA: 0x1126C34
	public void .ctor(XmlReader reader) { }

	// RVA: 0x11283A0
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1128454
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x112850C
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x11285C4
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x112867C
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x1128734
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x11287EC
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckWriter
{
	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Methods

	// RVA: 0x11288A4
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x1128934
	private void CheckAsync() { }

	// RVA: 0x11289B4
	public override void WriteStartDocument() { }

	// RVA: 0x11289E8
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1128A24
	public override void WriteEndDocument() { }

	// RVA: 0x1128A58
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1128ABC
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1128B10
	public override void WriteEndElement() { }

	// RVA: 0x1128B44
	public override void WriteFullEndElement() { }

	// RVA: 0x1128B78
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1128BCC
	public override void WriteEndAttribute() { }

	// RVA: 0x1128C04
	public override void WriteCData(string text) { }

	// RVA: 0x1128C44
	public override void WriteComment(string text) { }

	// RVA: 0x1128C84
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1128CD4
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1128D14
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1128D54
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1128D94
	public override void WriteString(string text) { }

	// RVA: 0x1128DD4
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1128E24
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1128E7C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1128ED4
	public override void WriteRaw(string data) { }

	// RVA: 0x1128F14
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1128F6C
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1128FC4
	public override WriteState get_WriteState() { }

	// RVA: 0x1128FFC
	public override void Close() { }

	// RVA: 0x1129034
	public override void Flush() { }

	// RVA: 0x112906C
	public override string LookupPrefix(string ns) { }

	// RVA: 0x11290AC
	public override void WriteValue(string value) { }

	// RVA: 0x11290EC
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x112913C
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x112918C
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

	// RVA: 0x11291BC
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0x11292EC
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0x1129320
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0x1129354
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11293D8
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11296E0
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1129744
	public override void WriteEndAttribute() { }

	// RVA: 0x112976C
	public override void WriteCData(string text) { }

	// RVA: 0x1129860
	public override void WriteComment(string text) { }

	// RVA: 0x1129894
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11298C8
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11298FC
	public override void WriteString(string text) { }

	// RVA: 0x112997C
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11299B8
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11299F4
	public override void WriteRaw(string data) { }

	// RVA: 0x1129A74
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1129AC4
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1129B14
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1129B74
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1129BDC
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1129C44
	public override void Close() { }

	// RVA: 0x1129C8C
	public override void Flush() { }

	// RVA: 0x1129CD4
	public override void WriteValue(string value) { }

	// RVA: 0x1129D24
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1129D80
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1129DD0
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1129E20
	internal override void StartElementContent() { }

	// RVA: 0x1129E48
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1129E70
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1129E98
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1129EF8
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1129F20
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1129F70
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x112945C
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0x11293C8
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0x11297EC
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0x1129568
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

	// RVA: 0x112A724
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x1125E84
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1125F88
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x112AB50
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x112AE88
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x112AF10
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x112B240
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x112B388
	internal override void StartElementContent() { }

	// RVA: 0x112B3D0
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x112B5C0
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x112B748
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x112B8E8
	public override void WriteEndAttribute() { }

	// RVA: 0x112B9AC
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x112BA04
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x112BA0C
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x112BC34
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x112BCF8
	public override void WriteCData(string text) { }

	// RVA: 0x112C2D4
	public override void WriteComment(string text) { }

	// RVA: 0x112C818
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x112C9B4
	public override void WriteEntityRef(string name) { }

	// RVA: 0x112CAE8
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x112CD18
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x112D3C4
	public override void WriteString(string text) { }

	// RVA: 0x112D490
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x112D648
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11263F4
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11262F4
	public override void WriteRaw(string data) { }

	// RVA: 0x112D9CC
	public override void Close() { }

	// RVA: 0x112DAFC
	public override void Flush() { }

	// RVA: 0x112DB6C
	protected virtual void FlushBuffer() { }

	// RVA: 0x112DDB0
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x112DA54
	private void FlushEncoder() { }

	// RVA: 0x112CDE0
	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x112D0C0
	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x112AE48
	protected void RawText(string s) { }

	// RVA: 0x112E2E0
	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x112D728
	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x112C454
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x112BF2C
	protected void WriteCDataSection(string text) { }

	// RVA: 0x112DFDC
	private static Char* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	// RVA: 0x112E138
	private Char* InvalidXmlChar(int ch, Char* pDst, bool entitize) { }

	// RVA: 0x112E580
	internal void EncodeChar(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	// RVA: 0x112ADCC
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x112E658
	private void GrowTextContentMarks() { }

	// RVA: 0x112E25C
	protected Char* WriteNewLine(Char* pDst) { }

	// RVA: 0x112DF18
	protected static Char* LtEntity(Char* pDst) { }

	// RVA: 0x112DF30
	protected static Char* GtEntity(Char* pDst) { }

	// RVA: 0x112DEF4
	protected static Char* AmpEntity(Char* pDst) { }

	// RVA: 0x112DF48
	protected static Char* QuoteEntity(Char* pDst) { }

	// RVA: 0x112DF70
	protected static Char* TabEntity(Char* pDst) { }

	// RVA: 0x112DFB8
	protected static Char* LineFeedEntity(Char* pDst) { }

	// RVA: 0x112DF94
	protected static Char* CarriageReturnEntity(Char* pDst) { }

	// RVA: 0x112E4C4
	private static Char* CharEntity(Char* pDst, Char ch) { }

	// RVA: 0x112E490
	protected static Char* RawStartCData(Char* pDst) { }

	// RVA: 0x112E474
	protected static Char* RawEndCData(Char* pDst) { }

	// RVA: 0x112A830
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

	// RVA: 0x112E6E0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x112E82C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x112E858
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x112E950
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x112E9C8
	internal override void StartElementContent() { }

	// RVA: 0x112EA50
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x112EA58
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x112EAE0
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x112EB68
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x112EBB0
	public override void WriteCData(string text) { }

	// RVA: 0x112EBBC
	public override void WriteComment(string text) { }

	// RVA: 0x112EC14
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x112EC68
	public override void WriteEntityRef(string name) { }

	// RVA: 0x112EC74
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x112EC80
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x112EC8C
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x112EC98
	public override void WriteString(string text) { }

	// RVA: 0x112ECA4
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x112ECB0
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x112ECBC
	public override void WriteRaw(string data) { }

	// RVA: 0x112ECC8
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x112E70C
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x112E8C4
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

	// RVA: 0x1130160
	public void InitEvent(XmlEventType eventType) { }

	// RVA: 0x1130040
	public void InitEvent(XmlEventType eventType, string s1) { }

	// RVA: 0x1130050
	public void InitEvent(XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x113008C
	public void InitEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x11300E4
	public void InitEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1130150
	public void InitEvent(XmlEventType eventType, object o) { }

	// RVA: 0x1130168
	public XmlEventType get_EventType() { }

	// RVA: 0x1130170
	public string get_String1() { }

	// RVA: 0x1130178
	public string get_String2() { }

	// RVA: 0x1130180
	public string get_String3() { }

	// RVA: 0x1130188
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

	// RVA: 0x11292A4
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x1129F98
	public void EndEvents() { }

	// RVA: 0x1129FF4
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x112EE78
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x112EF38
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x112F058
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x112F0E4
	public override void WriteEndAttribute() { }

	// RVA: 0x112F130
	public override void WriteCData(string text) { }

	// RVA: 0x112F1E8
	public override void WriteComment(string text) { }

	// RVA: 0x112F240
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x112F330
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x112F388
	public override void WriteString(string text) { }

	// RVA: 0x112F404
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x112F440
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x112F47C
	public override void WriteRaw(string data) { }

	// RVA: 0x112F4D4
	public override void WriteEntityRef(string name) { }

	// RVA: 0x112F52C
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x112F638
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x112F6FC
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x112F8AC
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x112F9A4
	public override void Close() { }

	// RVA: 0x112F9F0
	public override void Flush() { }

	// RVA: 0x112FA3C
	public override void WriteValue(string value) { }

	// RVA: 0x112FA4C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x112FB58
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x112FC04
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x112FC5C
	internal override void StartElementContent() { }

	// RVA: 0x112FCA8
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x112FD34
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x112FDC0
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x112FE38
	internal override void WriteEndBase64() { }

	// RVA: 0x112EE2C
	private void AddEvent(XmlEventType eventType) { }

	// RVA: 0x112F188
	private void AddEvent(XmlEventType eventType, string s1) { }

	// RVA: 0x112F2B8
	private void AddEvent(XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x112EFC4
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x112EE90
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x112F5D8
	private void AddEvent(XmlEventType eventType, object o) { }

	// RVA: 0x112FE84
	private int NewEvent() { }

	// RVA: 0x112F7F4
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

	// RVA: 0x1130190
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x113023C
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x113026C
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x11305BC
	public XmlNameTable get_NameTable() { }

	// RVA: 0x11305C4
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x11305CC
	public string get_DocTypeName() { }

	// RVA: 0x11305D4
	public string get_PublicId() { }

	// RVA: 0x11305DC
	public string get_SystemId() { }

	// RVA: 0x11305E4
	public string get_BaseURI() { }

	// RVA: 0x11305EC
	public string get_InternalSubset() { }

	// RVA: 0x11305F4
	public string get_XmlLang() { }

	// RVA: 0x11305FC
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x1130604
	public Encoding get_Encoding() { }

	// RVA: 0x113060C
	internal bool get_HasDtdInfo() { }

}

// Namespace: System.Xml
internal abstract class XmlRawWriter
{
	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Methods

	// RVA: 0x11306B8
	public override void WriteStartDocument() { }

	// RVA: 0x1130714
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1130770
	public override void WriteEndDocument() { }

	// RVA: 0x11307CC
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11307D0
	public override void WriteEndElement() { }

	// RVA: 0x113082C
	public override void WriteFullEndElement() { }

	// RVA: 0x112ED7C
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1130888
	public override string LookupPrefix(string ns) { }

	// RVA: 0x11308E4
	public override WriteState get_WriteState() { }

	// RVA: 0x1130940
	public override void WriteCData(string text) { }

	// RVA: 0x1130950
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x11309E8
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1130A98
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1130AA8
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1130AE4
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1130B20
	public override void WriteRaw(string data) { }

	// RVA: 0x1130B30
	public override void WriteValue(string value) { }

	// RVA: 0x1130B40
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1130B9C
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1130BF8
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1130C00
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1130C04
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	// RVA: -1
	internal abstract void StartElementContent() { }

	// RVA: 0x1130C08
	internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: -1
	internal abstract void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1130C0C
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1130C1C
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1130C24
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1130C64
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1130CA4
	internal virtual void WriteEndBase64() { }

	// RVA: 0x1130CC4
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x1124CA8
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

	// RVA: 0x1130CD4
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x1130CDC
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

	// RVA: 0x1130DC4
	public virtual bool get_IsDefault() { }

	// RVA: 0x1130DCC
	public virtual Char get_QuoteChar() { }

	// RVA: 0x1130DD4
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x1130DDC
	public virtual string get_XmlLang() { }

	// RVA: 0x1130E28
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1130E7C
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

	// RVA: 0x1130F1C
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

	// RVA: 0x1130FE8
	public virtual void Close() { }

	// RVA: -1
	public abstract ReadState get_ReadState() { }

	// RVA: 0x1130FEC
	public virtual void Skip() { }

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: -1
	public abstract string LookupNamespace(string prefix) { }

	// RVA: 0x11311B4
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1
	public abstract void ResolveEntity() { }

	// RVA: 0x11311BC
	public virtual bool get_CanReadValueChunk() { }

	// RVA: 0x11311C4
	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x1131220
	public virtual string ReadString() { }

	// RVA: 0x11314C0
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0x1131560
	public virtual void ReadStartElement() { }

	// RVA: 0x1131658
	public virtual string ReadElementString() { }

	// RVA: 0x11318EC
	public virtual void ReadEndElement() { }

	// RVA: 0x11319E4
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0x1131A74
	public virtual string ReadInnerXml() { }

	// RVA: 0x1131F08
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0x1131DEC
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0x1131D74
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0x113236C
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0x11324A4
	public virtual bool get_HasAttributes() { }

	// RVA: 0x1127CB0
	public void Dispose() { }

	// RVA: 0x11324CC
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1132520
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1131450
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0x1132528
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0x11310DC
	private bool SkipSubtree() { }

	// RVA: 0x1132598
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x11326A0
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0x11326A8
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1132908
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1132AC8
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0x1132E60
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x1126FD8
	protected void .ctor() { }

	// RVA: 0x113304C
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

	// RVA: 0x11271EC
	public void .ctor() { }

	// RVA: 0x11330B4
	public bool get_Async() { }

	// RVA: 0x1127218
	public void set_Async(bool value) { }

	// RVA: 0x1133174
	public XmlNameTable get_NameTable() { }

	// RVA: 0x113317C
	public void set_NameTable(XmlNameTable value) { }

	// RVA: 0x11331E4
	internal bool get_IsXmlResolverSet() { }

	// RVA: 0x11331EC
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0x11331F4
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1133268
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0x1133270
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x11332B4
	public int get_LineNumberOffset() { }

	// RVA: 0x11332BC
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x113331C
	public int get_LinePositionOffset() { }

	// RVA: 0x1133324
	public void set_LinePositionOffset(int value) { }

	// RVA: 0x1133384
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x113338C
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x113343C
	public bool get_CheckCharacters() { }

	// RVA: 0x1133444
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x11334A4
	public Int64 get_MaxCharactersInDocument() { }

	// RVA: 0x11334AC
	public void set_MaxCharactersInDocument(Int64 value) { }

	// RVA: 0x1133558
	public Int64 get_MaxCharactersFromEntities() { }

	// RVA: 0x1133560
	public void set_MaxCharactersFromEntities(Int64 value) { }

	// RVA: 0x113360C
	public bool get_IgnoreWhitespace() { }

	// RVA: 0x1133614
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0x1133674
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0x113367C
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0x11336DC
	public bool get_IgnoreComments() { }

	// RVA: 0x11336E4
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x1133744
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0x113374C
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x11337FC
	public bool get_CloseInput() { }

	// RVA: 0x1133804
	public void set_CloseInput(bool value) { }

	// RVA: 0x1133864
	public ValidationType get_ValidationType() { }

	// RVA: 0x113386C
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x113391C
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x1133924
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0x11339D4
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0x1133A5C
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x1127180
	public XmlReaderSettings Clone() { }

	// RVA: 0x1133AC4
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x113273C
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x1132998
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x1133ACC
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x11330BC
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x11330AC
	private void Initialize() { }

	// RVA: 0x1133AD4
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0x1133D54
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x1132EF0
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0x1133DAC
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0x1133BCC
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

	// RVA: 0x1133E30
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0x1133E84
	internal void set_QuoteChar(Char value) { }

	// RVA: 0x1133E8C
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0x1133F4C
	internal void EndAttribute() { }

	// RVA: 0x1133F90
	internal string get_AttributeValue() { }

	// RVA: 0x1134008
	internal void WriteSurrogateChar(Char lowChar, Char highChar) { }

	// RVA: 0x11340C8
	internal void Write(Char[] array, int offset, int count) { }

	// RVA: 0x1134728
	internal void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11348B0
	internal void Write(string text) { }

	// RVA: 0x1134F10
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0x1135100
	internal void WriteRaw(Char[] array, int offset, int count) { }

	// RVA: 0x1135244
	internal void WriteCharEntity(Char ch) { }

	// RVA: 0x113542C
	internal void WriteEntityRef(string name) { }

	// RVA: 0x1134E5C
	private void WriteStringFragment(string str, int offset, int count, Char[] helperBuffer) { }

	// RVA: 0x1134630
	private void WriteCharEntityImpl(Char ch) { }

	// RVA: 0x1135388
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0x11346B4
	private void WriteEntityRefImpl(string name) { }

}

// Namespace: System.Xml
public class XmlTextReader
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Methods

	// RVA: 0x11354E4
	public void .ctor(Stream input) { }

	// RVA: 0x11355A8
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1135684
	public void .ctor(TextReader input) { }

	// RVA: 0x1135748
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x113581C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1135840
	public override string get_Name() { }

	// RVA: 0x1135864
	public override string get_LocalName() { }

	// RVA: 0x1135888
	public override string get_NamespaceURI() { }

	// RVA: 0x11358AC
	public override string get_Prefix() { }

	// RVA: 0x11358D0
	public override string get_Value() { }

	// RVA: 0x11358F4
	public override int get_Depth() { }

	// RVA: 0x1135918
	public override string get_BaseURI() { }

	// RVA: 0x1135940
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1135968
	public override bool get_IsDefault() { }

	// RVA: 0x1135990
	public override Char get_QuoteChar() { }

	// RVA: 0x11359B8
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x11359E0
	public override string get_XmlLang() { }

	// RVA: 0x1135A08
	public override int get_AttributeCount() { }

	// RVA: 0x1135A30
	public override string GetAttribute(string name) { }

	// RVA: 0x1135A58
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1135A80
	public override string GetAttribute(int i) { }

	// RVA: 0x1135AA8
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1135AD0
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1135AF8
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1135B20
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1135B48
	public override bool MoveToElement() { }

	// RVA: 0x1135B70
	public override bool ReadAttributeValue() { }

	// RVA: 0x1135B98
	public override bool Read() { }

	// RVA: 0x1135BC0
	public override bool get_EOF() { }

	// RVA: 0x1135BE8
	public override void Close() { }

	// RVA: 0x1135C10
	public override ReadState get_ReadState() { }

	// RVA: 0x1135C38
	public override void Skip() { }

	// RVA: 0x1135C60
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1135C88
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1135CC4
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1135CCC
	public override void ResolveEntity() { }

	// RVA: 0x1135CF4
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1135CFC
	public override string ReadString() { }

	// RVA: 0x1135D30
	public bool HasLineInfo() { }

	// RVA: 0x1135D38
	public int get_LineNumber() { }

	// RVA: 0x1135D58
	public int get_LinePosition() { }

	// RVA: 0x1135D78
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1135D98
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1135DC0
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1132484
	public bool get_Namespaces() { }

	// RVA: 0x1135DE0
	public bool get_Normalization() { }

	// RVA: 0x1135E00
	public void set_Normalization(bool value) { }

	// RVA: 0x1135E20
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1135E40
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1135E60
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1135E80
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0x1135E88
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1135EB0
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x1135ED0
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

	// RVA: 0x1135EF8
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

	// RVA: 0x1135F08
	internal void Clear() { }

	// RVA: 0x1135FFC
	internal void Close(bool closeInput) { }

	// RVA: 0x1136034
	internal int get_LineNo() { }

	// RVA: 0x113603C
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

	// RVA: 0x113604C
	internal void .ctor() { }

	// RVA: 0x11360E4
	internal void .ctor(XmlContext previousContext) { }

}

// Namespace: 
private class NoNamespaceManager
{
	// Methods

	// RVA: 0x1136148
	public void .ctor() { }

	// RVA: 0x1136150
	public override string get_DefaultNamespace() { }

	// RVA: 0x113619C
	public override void PushScope() { }

	// RVA: 0x11361A0
	public override bool PopScope() { }

	// RVA: 0x11361A8
	public override void AddNamespace(string prefix, string uri) { }

	// RVA: 0x11361AC
	public override void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x11361B0
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x11361B8
	public override System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11361C0
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x113620C
	public override string LookupPrefix(string uri) { }

}

// Namespace: 
internal class DtdParserProxy
{
	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Methods

	// RVA: 0x1136214
	internal void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x1136248
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x1136268
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x1136288
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x11362A8
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x11362C8
	private Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x11362E8
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x1136308
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x1136328
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x1136348
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x1136368
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x1136388
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x11363A8
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x11363C8
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x11363E8
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x1136408
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1136428
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1136448
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x1136468
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x1136488
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, int entityId) { }

	// RVA: 0x11364A8
	private bool System.Xml.IDtdParserAdapter.PopEntity(IDtdEntityInfo oldEntity, int newEntityId) { }

	// RVA: 0x11364C8
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x11364E8
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1136508
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x1136528
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1136548
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x1136568
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x1136588
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0x11365A8
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0x11365C8
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x11365E8
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

	// RVA: 0x1136608
	internal static NodeData get_None() { }

	// RVA: 0x11366B4
	internal void .ctor() { }

	// RVA: 0x1136798
	internal int get_LineNo() { }

	// RVA: 0x11367A0
	internal int get_LinePos() { }

	// RVA: 0x11367A8
	internal bool get_IsEmptyElement() { }

	// RVA: 0x11367CC
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x11367D4
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0x11367F8
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x1136800
	internal bool get_ValueBuffered() { }

	// RVA: 0x1136810
	internal string get_StringValue() { }

	// RVA: 0x1136868
	internal void TrimSpacesInValue() { }

	// RVA: 0x11366E8
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x11368C4
	internal void ClearName() { }

	// RVA: 0x113696C
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1136978
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x1136984
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x11369C4
	internal void SetValueNode(XmlNodeType type, Char[] chars, int startPos, int len) { }

	// RVA: 0x1136A20
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x1136A98
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1136B70
	internal void SetValue(string value) { }

	// RVA: 0x1136B80
	internal void SetValue(Char[] chars, int startPos, int len) { }

	// RVA: 0x1136BD0
	internal void OnBufferInvalidated() { }

	// RVA: 0x1136C38
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x1136CB4
	internal int CopyTo(int valueOffset, Char[] buffer, int offset, int length) { }

	// RVA: 0x1136D2C
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1136D40
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1136E04
	private int System.IComparable.CompareTo(object obj) { }

}

// Namespace: 
private class DtdDefaultAttributeInfoToNodeDataComparer
{
	// Fields
	private static System.Collections.Generic.IComparer<System.Object> s_instance; // 0x0

	// Methods

	// RVA: 0x1136EF0
	internal static System.Collections.Generic.IComparer<System.Object> get_Instance() { }

	// RVA: 0x1136F6C
	public int Compare(object x, object y) { }

	// RVA: 0x11372EC
	public void .ctor() { }

	// RVA: 0x11372F4
	private static void .cctor() { }

}

// Namespace: 
internal sealed class OnDefaultAttributeUseDelegate
{
	// Methods

	// RVA: 0x1137360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1137484
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

	// RVA: 0x102E930
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0x102ED7C
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0x102F530
	internal void .ctor(Stream input) { }

	// RVA: 0x102F5CC
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x102F784
	internal void .ctor(TextReader input) { }

	// RVA: 0x102F908
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x102F820
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0x102F988
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0x102FE5C
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0x102FFB8
	private void FinishInitUriString() { }

	// RVA: 0x10306F8
	internal void .ctor(Stream stream, Byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0x1030A60
	private void FinishInitStream() { }

	// RVA: 0x1030B4C
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0x1030C7C
	private void FinishInitTextReader() { }

	// RVA: 0x1030D4C
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x1030E04
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1030F84
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1030FA4
	public override string get_Name() { }

	// RVA: 0x1030FCC
	public override string get_LocalName() { }

	// RVA: 0x1030FEC
	public override string get_NamespaceURI() { }

	// RVA: 0x103100C
	public override string get_Prefix() { }

	// RVA: 0x103102C
	public override string get_Value() { }

	// RVA: 0x1031294
	public override int get_Depth() { }

	// RVA: 0x10312B4
	public override string get_BaseURI() { }

	// RVA: 0x10312BC
	public override bool get_IsEmptyElement() { }

	// RVA: 0x10312DC
	public override bool get_IsDefault() { }

	// RVA: 0x10312FC
	public override Char get_QuoteChar() { }

	// RVA: 0x1031334
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1031354
	public override string get_XmlLang() { }

	// RVA: 0x1031374
	public override ReadState get_ReadState() { }

	// RVA: 0x103137C
	public override bool get_EOF() { }

	// RVA: 0x103138C
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1031394
	public override bool get_CanResolveEntity() { }

	// RVA: 0x103139C
	public override int get_AttributeCount() { }

	// RVA: 0x10313A4
	public override string GetAttribute(string name) { }

	// RVA: 0x1031600
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1031794
	public override string GetAttribute(int i) { }

	// RVA: 0x103183C
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1031A38
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1031B00
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1031B84
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1031C30
	public override bool MoveToElement() { }

	// RVA: 0x1031CD4
	private void FinishInit() { }

	// RVA: 0x1031D20
	public override bool Read() { }

	// RVA: 0x10345EC
	public override void Close() { }

	// RVA: 0x1034748
	public override void Skip() { }

	// RVA: 0x1034974
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x10349B0
	public override bool ReadAttributeValue() { }

	// RVA: 0x10351F0
	public override void ResolveEntity() { }

	// RVA: 0x1035A2C
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0x1035A3C
	internal void MoveOffEntityReference() { }

	// RVA: 0x1035AF0
	public override string ReadString() { }

	// RVA: 0x1035B18
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1035B20
	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x1036758
	public bool HasLineInfo() { }

	// RVA: 0x1036760
	public int get_LineNumber() { }

	// RVA: 0x1036780
	public int get_LinePosition() { }

	// RVA: 0x10367A0
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x10367F0
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1036800
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x10367C8
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1036828
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1036850
	internal bool get_Namespaces() { }

	// RVA: 0x1036858
	internal void set_Namespaces(bool value) { }

	// RVA: 0x1036A70
	internal bool get_Normalization() { }

	// RVA: 0x1036A78
	internal void set_Normalization(bool value) { }

	// RVA: 0x1036BA8
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1036C88
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1036D10
	internal bool get_IsResolverSet() { }

	// RVA: 0x1036D18
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1036DAC
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0x1036DB4
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0x1036DBC
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0x1036DDC
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0x1036DE4
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0x1036DEC
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0x1036DF4
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x1036EDC
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x1036EE4
	internal Char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x1036EEC
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0x1036EF4
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0x1036EFC
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0x1036F04
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0x1036F10
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x1036F18
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0x1036F20
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x1036F48
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0x1036F50
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0x1036F58
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0x10373BC
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x10374D4
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x10375CC
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0x1037990
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0x1037E5C
	private bool get_IsResolverNull() { }

	// RVA: 0x1037EA8
	private XmlResolver GetTempResolver() { }

	// RVA: 0x1037F24
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, int entityId) { }

	// RVA: 0x1038788
	internal bool DtdParserProxy_PopEntity(IDtdEntityInfo oldEntity, int newEntityId) { }

	// RVA: 0x10388E4
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1039090
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1039328
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0x1039440
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x103958C
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x103961C
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0x1039734
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0x103984C
	private void Throw(int pos, string res) { }

	// RVA: 0x1030A08
	private void Throw(string res) { }

	// RVA: 0x10398B0
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0x1039634
	private void Throw(string res, string arg) { }

	// RVA: 0x10399C0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x103974C
	private void Throw(string res, string[] args) { }

	// RVA: 0x1039AB4
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0x1039B48
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0x10393B4
	private void Throw(Exception e) { }

	// RVA: 0x1039C68
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0x1034324
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0x1039D70
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0x1039E50
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0x1039F44
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	// RVA: 0x1039C54
	private void SetErrorState() { }

	// RVA: 0x1037D18
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0x1039FB8
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0x103191C
	private bool get_InAttributeValueIterator() { }

	// RVA: 0x1031940
	private void FinishAttributeValueIterator() { }

	// RVA: 0x1036DCC
	private bool get_DtdValidation() { }

	// RVA: 0x102F6E8
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0x102F768
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x103A270
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0x103A2D4
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1030370
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x102F97C
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0x103A69C
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0x102FAB8
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0x102FBC8
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0x1030688
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0x1032CEC
	private void OpenUrl() { }

	// RVA: 0x103AA08
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0x103A2E4
	private Encoding DetectEncoding() { }

	// RVA: 0x103A518
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0x103ABC4
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0x103ADF8
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0x103AD48
	private void UnDecodeChars() { }

	// RVA: 0x103B17C
	private void SwitchEncodingToUTF8() { }

	// RVA: 0x1036F5C
	private int ReadData() { }

	// RVA: 0x103B1F4
	private int GetChars(int maxCharsCount) { }

	// RVA: 0x103B314
	private void InvalidCharRecovery(int bytesCount, int charsCount) { }

	// RVA: 0x10345F4
	internal void Close(bool closeInput) { }

	// RVA: 0x103B554
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0x1032F30
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0x10326DC
	private bool ParseDocumentContent() { }

	// RVA: 0x1032304
	private bool ParseElementContent() { }

	// RVA: 0x103CEFC
	private void ThrowUnclosedElements() { }

	// RVA: 0x103BB18
	private void ParseElement() { }

	// RVA: 0x103D730
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0x103CB54
	private void ParseEndElement() { }

	// RVA: 0x103E9E4
	private void ThrowTagMismatch(NodeData startTag) { }

	// RVA: 0x103D0D8
	private void ParseAttributes() { }

	// RVA: 0x103E1E4
	private void ElementNamespaceLookup() { }

	// RVA: 0x103E918
	private void AttributeNamespaceLookup() { }

	// RVA: 0x103FE0C
	private void AttributeDuplCheck() { }

	// RVA: 0x103F914
	private void OnDefaultNamespaceDecl(NodeData attr) { }

	// RVA: 0x103FA9C
	private void OnNamespaceDecl(NodeData attr) { }

	// RVA: 0x103FB64
	private void OnXmlReservedAttribute(NodeData attr) { }

	// RVA: 0x103EE78
	private void ParseAttributeValueSlow(int curPos, Char quoteChar, NodeData attr) { }

	// RVA: 0x10405A8
	private void AddAttributeChunkToList(NodeData attr, NodeData chunk, NodeData lastChunk) { }

	// RVA: 0x103C3E8
	private bool ParseText() { }

	// RVA: 0x1035FD0
	private bool ParseText(int startPos, int endPos, int outOrChars) { }

	// RVA: 0x1031080
	private void FinishPartialValue() { }

	// RVA: 0x103116C
	private void FinishOtherValueIterator() { }

	// RVA: 0x1034420
	private void SkipPartialTextValue() { }

	// RVA: 0x1034468
	private void FinishReadValueChunk() { }

	// RVA: 0x1034488
	private void FinishReadContentAsBinary() { }

	// RVA: 0x10344EC
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0x103C838
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0x1033E9C
	private void ParseEntityReference() { }

	// RVA: 0x103C068
	private EntityType HandleEntityReference(bool isInAttributeValue, EntityExpandType expandType, int charRefEndPos) { }

	// RVA: 0x1035458
	private EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0x103B16C
	private bool get_InEntity() { }

	// RVA: 0x103A084
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0x1033F1C
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0x1040A80
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0x103B764
	private bool ParsePI() { }

	// RVA: 0x1037614
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0x1040B04
	private bool ParsePIValue(int outStartPos, int outEndPos) { }

	// RVA: 0x103B76C
	private bool ParseComment() { }

	// RVA: 0x103B7F8
	private void ParseCData() { }

	// RVA: 0x1037B94
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0x1040EC8
	private bool ParseCDataOrComment(XmlNodeType type, int outStartPos, int outEndPos) { }

	// RVA: 0x103B800
	private bool ParseDoctypeDecl() { }

	// RVA: 0x1041358
	private void ParseDtd() { }

	// RVA: 0x10416BC
	private void SkipDtd() { }

	// RVA: 0x1041A44
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0x1041AF4
	private void SkipUntil(Char stopChar, bool recognizeLiterals) { }

	// RVA: 0x1038E04
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0x1040804
	private int ParseCharRefInline(int startPos, int charCount, EntityType entityType) { }

	// RVA: 0x10373E4
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, EntityType entityType) { }

	// RVA: 0x1042010
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, int charCount, EntityType entityType) { }

	// RVA: 0x1037550
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x10426A4
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x103B584
	private int ParseName() { }

	// RVA: 0x103D0C8
	private int ParseQName(int colonPos) { }

	// RVA: 0x10429F0
	private int ParseQName(bool isQName, int startOffset, int colonPos) { }

	// RVA: 0x1042C74
	private bool ReadDataInName(int pos) { }

	// RVA: 0x1040614
	private string ParseEntityName() { }

	// RVA: 0x1033DEC
	private NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1042CC0
	private NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x10394D0
	private NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0x103ECA8
	private NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0x1042E1C
	private NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1033E34
	private void PopElementContext() { }

	// RVA: 0x1036F34
	private void OnNewLine(int pos) { }

	// RVA: 0x1034278
	private void OnEof() { }

	// RVA: 0x1040254
	private string LookupNamespace(NodeData node) { }

	// RVA: 0x1040394
	private void AddNamespace(string prefix, string uri, NodeData attr) { }

	// RVA: 0x1033D3C
	private void ResetAttributes() { }

	// RVA: 0x1042FBC
	private void FullAttributeCleanup() { }

	// RVA: 0x1040304
	private void PushXmlContext() { }

	// RVA: 0x1042F78
	private void PopXmlContext() { }

	// RVA: 0x1040A2C
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0x104079C
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0x1038A7C
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0x104305C
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0x1038060
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1038418
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1038800
	private void PopEntity() { }

	// RVA: 0x10432D8
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0x104355C
	private void UnregisterEntity() { }

	// RVA: 0x103910C
	private void PushParsingState() { }

	// RVA: 0x103B4DC
	private void PopParsingState() { }

	// RVA: 0x10435C4
	private int IncrementalRead() { }

	// RVA: 0x10340A4
	private void FinishIncrementalRead() { }

	// RVA: 0x103412C
	private bool ParseFragmentAttribute() { }

	// RVA: 0x1034CD0
	private bool ParseAttributeValueChunk() { }

	// RVA: 0x10341C4
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0x103B7E0
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x103B574
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0x103BB00
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x103B5AC
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0x103BAF8
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0x1043F38
	private string ParseUnexpectedToken() { }

	// RVA: 0x103EBE4
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0x103143C
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0x1031540
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0x1040874
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0x103A79C
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1040904
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0x102F2C8
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x1044024
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x104402C
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0x10441AC
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0x10441BC
	internal void set_OnDefaultAttributeUse(OnDefaultAttributeUseDelegate value) { }

	// RVA: 0x10441CC
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x10442A4
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0x10442AC
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0x10442CC
	internal XmlResolver GetResolver() { }

	// RVA: 0x1044318
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0x1044338
	internal object get_InternalTypedValue() { }

	// RVA: 0x1044358
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0x1044378
	internal bool get_StandAlone() { }

	// RVA: 0x1044380
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1044388
	internal bool get_V1Compat() { }

	// RVA: 0x103E24C
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, NodeData[] nameSortedNodeData) { }

	// RVA: 0x1044600
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0x1044390
	private NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0x1044880
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0x10308FC
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0x1039230
	private void RegisterConsumedCharacters(Int64 characters, bool inEntityReference) { }

	// RVA: 0x1044888
	internal static string StripSpaces(string value) { }

	// RVA: 0x1044AA8
	internal static void StripSpaces(Char[] value, int index, int len) { }

	// RVA: 0x1036744
	internal static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	// RVA: 0x103B1EC
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

	// RVA: 0x1137668
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

	// RVA: 0x113C548
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

	// RVA: 0x1137498
	internal void .ctor() { }

	// RVA: 0x11376FC
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x113780C
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x1137898
	public void .ctor(TextWriter w) { }

	// RVA: 0x1137964
	public Stream get_BaseStream() { }

	// RVA: 0x11379F4
	public void set_Namespaces(bool value) { }

	// RVA: 0x1137A68
	public void set_Formatting(Formatting value) { }

	// RVA: 0x1137A7C
	public void set_QuoteChar(Char value) { }

	// RVA: 0x1137B08
	public override void WriteStartDocument() { }

	// RVA: 0x1137EC8
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1137EDC
	public override void WriteEndDocument() { }

	// RVA: 0x1138158
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1138E3C
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1139A00
	public override void WriteEndElement() { }

	// RVA: 0x1139D28
	public override void WriteFullEndElement() { }

	// RVA: 0x1139D30
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x113A668
	public override void WriteEndAttribute() { }

	// RVA: 0x113A710
	public override void WriteCData(string text) { }

	// RVA: 0x113A8F4
	public override void WriteComment(string text) { }

	// RVA: 0x113AB10
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x113AE58
	public override void WriteEntityRef(string name) { }

	// RVA: 0x113AF30
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x113AFFC
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x113B180
	public override void WriteString(string text) { }

	// RVA: 0x113B258
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x113B334
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x113B418
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x113B4FC
	public override void WriteRaw(string data) { }

	// RVA: 0x113B5C8
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x113B734
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x113B80C
	public override WriteState get_WriteState() { }

	// RVA: 0x113B830
	public override void Close() { }

	// RVA: 0x113B9B0
	public override void Flush() { }

	// RVA: 0x113B9D4
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1137B10
	private void StartDocument(int standalone) { }

	// RVA: 0x11387C0
	private void AutoComplete(Token token) { }

	// RVA: 0x11380F8
	private void AutoCompleteAll() { }

	// RVA: 0x1139A08
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x113BC18
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x113BBC0
	private void WriteEndAttributeQuote() { }

	// RVA: 0x113BAF0
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x113962C
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x113C2BC
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x113C598
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x113BFA0
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x113A54C
	private string GeneratePrefix() { }

	// RVA: 0x113AD58
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x113944C
	private int LookupNamespace(string prefix) { }

	// RVA: 0x113A40C
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x113954C
	private string FindPrefix(string ns) { }

	// RVA: 0x11385C8
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x113C09C
	private void HandleSpecialAttribute() { }

	// RVA: 0x11398AC
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x11392F0
	private void PushStack() { }

	// RVA: 0x113BF70
	private void FlushEncoders() { }

	// RVA: 0x113C690
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

	// RVA: 0x113CCA8
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x113D0D4
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x113D248
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x113D494
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x113D51C
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x113D804
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x113D8E0
	internal override void StartElementContent() { }

	// RVA: 0x113D92C
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x113DABC
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x113DBE8
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x113DD2C
	public override void WriteEndAttribute() { }

	// RVA: 0x113DD7C
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x113DDD4
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x113DDDC
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x113DF30
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x113DF80
	public override void WriteCData(string text) { }

	// RVA: 0x113E588
	public override void WriteComment(string text) { }

	// RVA: 0x113EAB4
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x113EC04
	public override void WriteEntityRef(string name) { }

	// RVA: 0x113ECD0
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x113EEB8
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x113F520
	public override void WriteString(string text) { }

	// RVA: 0x113F578
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x113F6E8
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x113F72C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x113FA34
	public override void WriteRaw(string data) { }

	// RVA: 0x113FA80
	public override void Close() { }

	// RVA: 0x113FB90
	public override void Flush() { }

	// RVA: 0x113FBDC
	protected virtual void FlushBuffer() { }

	// RVA: 0x113FB8C
	private void FlushEncoder() { }

	// RVA: 0x113EF10
	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x113F1F8
	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x113D454
	protected void RawText(string s) { }

	// RVA: 0x114021C
	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x113F778
	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x113E6EC
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x113E1E8
	protected void WriteCDataSection(string text) { }

	// RVA: 0x11403E8
	private static bool IsSurrogateByte(Byte b) { }

	// RVA: 0x113FE30
	private static Byte* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x113FFC0
	private Byte* InvalidXmlChar(int ch, Byte* pDst, bool entitize) { }

	// RVA: 0x11404B0
	internal void EncodeChar(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x1140140
	internal static Byte* EncodeMultibyteUTF8(int ch, Byte* pDst) { }

	// RVA: 0x1140594
	internal static void CharToUTF8(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x1140194
	protected Byte* WriteNewLine(Byte* pDst) { }

	// RVA: 0x113FDA0
	protected static Byte* LtEntity(Byte* pDst) { }

	// RVA: 0x113FDB0
	protected static Byte* GtEntity(Byte* pDst) { }

	// RVA: 0x113FD84
	protected static Byte* AmpEntity(Byte* pDst) { }

	// RVA: 0x113FDC0
	protected static Byte* QuoteEntity(Byte* pDst) { }

	// RVA: 0x113FDDC
	protected static Byte* TabEntity(Byte* pDst) { }

	// RVA: 0x113FE14
	protected static Byte* LineFeedEntity(Byte* pDst) { }

	// RVA: 0x113FDF8
	protected static Byte* CarriageReturnEntity(Byte* pDst) { }

	// RVA: 0x11403F8
	private static Byte* CharEntity(Byte* pDst, Char ch) { }

	// RVA: 0x11403C4
	protected static Byte* RawStartCData(Byte* pDst) { }

	// RVA: 0x11403AC
	protected static Byte* RawEndCData(Byte* pDst) { }

	// RVA: 0x113CDB4
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

	// RVA: 0x1140664
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11407B0
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11408A8
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1140920
	internal override void StartElementContent() { }

	// RVA: 0x11409AC
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x11409B4
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1140A3C
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1140AC4
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1140B0C
	public override void WriteCData(string text) { }

	// RVA: 0x1140B18
	public override void WriteComment(string text) { }

	// RVA: 0x1140B70
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1140BC4
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1140BD0
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1140BDC
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1140BE8
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1140C48
	public override void WriteString(string text) { }

	// RVA: 0x1140CA8
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1140CF4
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1140D48
	public override void WriteRaw(string data) { }

	// RVA: 0x1140D9C
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1140690
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x114081C
	private void WriteIndent() { }

}

// Namespace: System.Xml
public class XmlValidatingReader
{
	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Methods

	// RVA: 0x1140DAC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1140DD0
	public override string get_LocalName() { }

	// RVA: 0x1140DF4
	public override string get_NamespaceURI() { }

	// RVA: 0x1140E18
	public override string get_Prefix() { }

	// RVA: 0x1140E3C
	public override string get_Value() { }

	// RVA: 0x1140E60
	public override int get_Depth() { }

	// RVA: 0x1140E84
	public override string get_BaseURI() { }

	// RVA: 0x1140EAC
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1140ED4
	public override int get_AttributeCount() { }

	// RVA: 0x1140EFC
	public override string GetAttribute(string name) { }

	// RVA: 0x1140F24
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1140F4C
	public override string GetAttribute(int i) { }

	// RVA: 0x1140F74
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1140F9C
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1140FC4
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1140FEC
	public override bool MoveToElement() { }

	// RVA: 0x1141014
	public override bool ReadAttributeValue() { }

	// RVA: 0x114103C
	public override bool Read() { }

	// RVA: 0x1141064
	public override bool get_EOF() { }

	// RVA: 0x114108C
	public override ReadState get_ReadState() { }

	// RVA: 0x11410B4
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x11410DC
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1141118
	public override void ResolveEntity() { }

	// RVA: 0x1141140
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

	// RVA: 0x1141768
	internal void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x1142D48
	private object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x1142D50
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x114179C
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

	// RVA: 0x1141188
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x11419CC
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1141AB8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1141ADC
	public override string get_Name() { }

	// RVA: 0x1141B00
	public override string get_LocalName() { }

	// RVA: 0x1141B24
	public override string get_NamespaceURI() { }

	// RVA: 0x1141B48
	public override string get_Prefix() { }

	// RVA: 0x1141B6C
	public override string get_Value() { }

	// RVA: 0x1141B90
	public override int get_Depth() { }

	// RVA: 0x1141BB4
	public override string get_BaseURI() { }

	// RVA: 0x1141BDC
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1141C04
	public override bool get_IsDefault() { }

	// RVA: 0x1141C2C
	public override Char get_QuoteChar() { }

	// RVA: 0x1141C54
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1141C7C
	public override string get_XmlLang() { }

	// RVA: 0x1141CA4
	public override ReadState get_ReadState() { }

	// RVA: 0x1141CE4
	public override bool get_EOF() { }

	// RVA: 0x1141D0C
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1141D34
	public override int get_AttributeCount() { }

	// RVA: 0x1141D5C
	public override string GetAttribute(string name) { }

	// RVA: 0x1141D84
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1141DAC
	public override string GetAttribute(int i) { }

	// RVA: 0x1141DD4
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1141E14
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1141E50
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1141E90
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1141ED0
	public override bool MoveToElement() { }

	// RVA: 0x1141F10
	public override bool Read() { }

	// RVA: 0x114239C
	public override void Close() { }

	// RVA: 0x11423DC
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1142404
	public override bool ReadAttributeValue() { }

	// RVA: 0x1142464
	public override bool get_CanResolveEntity() { }

	// RVA: 0x114246C
	public override void ResolveEntity() { }

	// RVA: 0x11424A4
	internal void MoveOffEntityReference() { }

	// RVA: 0x1142558
	public override string ReadString() { }

	// RVA: 0x1142580
	public bool HasLineInfo() { }

	// RVA: 0x1142588
	public int get_LineNumber() { }

	// RVA: 0x1142690
	public int get_LinePosition() { }

	// RVA: 0x1142798
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1142900
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1142910
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x114284C
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11429C8
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1142A80
	internal ValidationType get_ValidationType() { }

	// RVA: 0x1142A88
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x1141168
	internal bool get_Namespaces() { }

	// RVA: 0x1142154
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1142A90
	private void ValidateDtd() { }

	// RVA: 0x1142314
	private void ResolveEntityInternally() { }

	// RVA: 0x1141850
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x114166C
	private XmlResolver GetResolver() { }

	// RVA: 0x1141FFC
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x1142B10
	internal BaseValidator get_Validator() { }

	// RVA: 0x1142B18
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x1142B20
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1142B48
	internal bool get_StandAlone() { }

	// RVA: 0x1142B68
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x1142B88
	internal object get_TypedValueObject() { }

	// RVA: 0x1142BA8
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x1142BC8
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x1142BE8
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1142C10
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

	// RVA: 0x114343C
	internal void .ctor(XmlWellFormedWriter wfWriter) { }

	// RVA: 0x1149F50
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1149F90
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1149FAC
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

	// RVA: 0x11434BC
	internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x1144E5C
	internal void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x11451B8
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

	// RVA: 0x1143470
	internal void Set(string prefix, string namespaceUri, NamespaceKind kind) { }

	// RVA: 0x1149390
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

	// RVA: 0x1149FD4
	internal void Set(string prefix, string localName, string namespaceUri) { }

	// RVA: 0x114A02C
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

	// RVA: 0x114B314
	internal void .ctor() { }

	// RVA: 0x114B31C
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

	// RVA: 0x114A89C
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

	// RVA: 0x114A0A0
	internal string get_StringValue() { }

	// RVA: 0x114A0D8
	internal void WriteEntityRef(string name) { }

	// RVA: 0x114A4B0
	internal void WriteCharEntity(Char ch) { }

	// RVA: 0x114A57C
	internal void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x114A670
	internal void WriteWhitespace(string ws) { }

	// RVA: 0x114A6F8
	internal void WriteString(string text) { }

	// RVA: 0x114A7AC
	internal void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x114A8E8
	internal void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x114A9D8
	internal void WriteRaw(string data) { }

	// RVA: 0x114AA60
	internal void WriteValue(string value) { }

	// RVA: 0x114AAE8
	internal void Replay(XmlWriter writer) { }

	// RVA: 0x114AE14
	internal void Trim() { }

	// RVA: 0x114B2CC
	internal void Clear() { }

	// RVA: 0x114A2B4
	private void StartComplexValue() { }

	// RVA: 0x114A308
	private void AddItem(ItemType type, object data) { }

	// RVA: 0x114B32C
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

	// RVA: 0x1142E74
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1143528
	public override WriteState get_WriteState() { }

	// RVA: 0x11435C8
	public override void WriteStartDocument() { }

	// RVA: 0x114379C
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x11437BC
	public override void WriteEndDocument() { }

	// RVA: 0x1143C8C
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x114416C
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1144C30
	public override void WriteEndElement() { }

	// RVA: 0x1144F8C
	public override void WriteFullEndElement() { }

	// RVA: 0x11451EC
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1145FD0
	public override void WriteEndAttribute() { }

	// RVA: 0x1146DEC
	public override void WriteCData(string text) { }

	// RVA: 0x1146F04
	public override void WriteComment(string text) { }

	// RVA: 0x114701C
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11472E0
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1147470
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1147628
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11477EC
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11479C0
	public override void WriteString(string text) { }

	// RVA: 0x1147AC4
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1147D44
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1147FC4
	public override void WriteRaw(string data) { }

	// RVA: 0x11480C8
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1148314
	public override void Close() { }

	// RVA: 0x114851C
	public override void Flush() { }

	// RVA: 0x11485DC
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1148884
	public override void WriteValue(string value) { }

	// RVA: 0x1148998
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1148ADC
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0x1147460
	private bool get_SaveAttrValue() { }

	// RVA: 0x1148500
	private bool get_InBase64() { }

	// RVA: 0x1145A50
	private void SetSpecialAttribute(SpecialAttribute special) { }

	// RVA: 0x11435D0
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x1148AE4
	private void StartFragment() { }

	// RVA: 0x1144804
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x11468E4
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x1148BF0
	private void AddNamespace(string prefix, string ns, NamespaceKind kind) { }

	// RVA: 0x1148EC4
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1148AF0
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x1144E90
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1148DB4
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x1143924
	private void AdvanceState(Token token) { }

	// RVA: 0x11492BC
	private void StartElementContent() { }

	// RVA: 0x1148FBC
	private static string GetStateName(State state) { }

	// RVA: 0x11446B8
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x1145C44
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x1145B00
	private string GeneratePrefix() { }

	// RVA: 0x11445AC
	private void CheckNCName(string ncname) { }

	// RVA: 0x11494D0
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x1149068
	private void ThrowInvalidStateTransition(Token token, State currentState) { }

	// RVA: 0x1148ACC
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x1145D28
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1149610
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x114974C
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

	// RVA: 0x114B3AC
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1
	public abstract void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: -1
	public abstract void WriteEndElement() { }

	// RVA: -1
	public abstract void WriteFullEndElement() { }

	// RVA: 0x114B3C4
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x114B424
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x114B484
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

	// RVA: 0x114B4D8
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: -1
	public abstract WriteState get_WriteState() { }

	// RVA: 0x114B4F4
	public virtual void Close() { }

	// RVA: -1
	public abstract void Flush() { }

	// RVA: -1
	public abstract string LookupPrefix(string ns) { }

	// RVA: 0x114B4F8
	public virtual void WriteValue(string value) { }

	// RVA: 0x114B510
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x114B7B8
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x114BC3C
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x114BCA4
	public void Dispose() { }

	// RVA: 0x114BCB8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x114BD0C
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x114C370
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x114C77C
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

	// RVA: 0x114BD80
	public void .ctor() { }

	// RVA: 0x114C8F0
	public bool get_Async() { }

	// RVA: 0x114C8F8
	public Encoding get_Encoding() { }

	// RVA: 0x114C900
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x114C908
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x114CA20
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x114CA28
	public string get_NewLineChars() { }

	// RVA: 0x114CA30
	public bool get_Indent() { }

	// RVA: 0x114CA40
	public void set_Indent(bool value) { }

	// RVA: 0x114CAA8
	public string get_IndentChars() { }

	// RVA: 0x114CAB0
	public bool get_NewLineOnAttributes() { }

	// RVA: 0x114CAB8
	public bool get_CloseOutput() { }

	// RVA: 0x114CAC0
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x114CAC8
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x114CB78
	public bool get_CheckCharacters() { }

	// RVA: 0x114CB80
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x114CB88
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x114CC38
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x114CC40
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x114CC48
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x114CC50
	public XmlWriterSettings Clone() { }

	// RVA: 0x114CD30
	internal System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0x114CD38
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x114CD40
	internal bool get_MergeCDataSections() { }

	// RVA: 0x114CD48
	internal string get_MediaType() { }

	// RVA: 0x114CD50
	internal string get_DocTypeSystem() { }

	// RVA: 0x114CD58
	internal string get_DocTypePublic() { }

	// RVA: 0x114CD60
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x114CD68
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0x114CD70
	internal TriState get_IndentInternal() { }

	// RVA: 0x114CD78
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x114BE14
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x114C3E4
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x114CE14
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x114C968
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x114C784
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

	// RVA: 0x114CE1C
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x114CF18
	private void Init() { }

	// RVA: 0x114D384
	internal void Reset(XmlReader reader) { }

	// RVA: 0x114D3AC
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x114D3D0
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x114D3F0
	public override string get_Name() { }

	// RVA: 0x114D418
	public override string get_LocalName() { }

	// RVA: 0x114D438
	public override string get_NamespaceURI() { }

	// RVA: 0x114D458
	public override string get_Prefix() { }

	// RVA: 0x114D478
	public override string get_Value() { }

	// RVA: 0x114D4B0
	public override int get_Depth() { }

	// RVA: 0x114D4D0
	public override string get_BaseURI() { }

	// RVA: 0x114D4F8
	public override bool get_IsEmptyElement() { }

	// RVA: 0x114D500
	public override bool get_IsDefault() { }

	// RVA: 0x114D508
	public override Char get_QuoteChar() { }

	// RVA: 0x114D530
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x114D558
	public override string get_XmlLang() { }

	// RVA: 0x114D580
	public override int get_AttributeCount() { }

	// RVA: 0x114D588
	public override string GetAttribute(string name) { }

	// RVA: 0x114D798
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x114D8D8
	public override string GetAttribute(int i) { }

	// RVA: 0x114D974
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x114DA28
	public override void MoveToAttribute(int i) { }

	// RVA: 0x114DAC4
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x114DB14
	public override bool MoveToNextAttribute() { }

	// RVA: 0x114DB78
	public override bool MoveToElement() { }

	// RVA: 0x114DBD4
	public override bool Read() { }

	// RVA: 0x114DEF4
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x114DF70
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x114E0B4
	internal void RecordEndElementNode() { }

	// RVA: 0x114E1D8
	public override bool get_EOF() { }

	// RVA: 0x114E218
	public override void Close() { }

	// RVA: 0x114E258
	public override ReadState get_ReadState() { }

	// RVA: 0x114E280
	public override void Skip() { }

	// RVA: 0x114E398
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x114E3A0
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x114E3C8
	public override void ResolveEntity() { }

	// RVA: 0x114E408
	public override bool ReadAttributeValue() { }

	// RVA: 0x114E588
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x114E590
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x114E5B0
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x114E5D0
	internal void SetToReplayMode() { }

	// RVA: 0x114E5F0
	internal XmlReader GetCoreReader() { }

	// RVA: 0x114E5F8
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x114DEE4
	private void ClearAttributesInfo() { }

	// RVA: 0x114E600
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x114D084
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x114D210
	private void RecordAttributes() { }

	// RVA: 0x114D620
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x114D6EC
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x114E4E4
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

}

// Namespace: System.Xml
internal sealed class CachingEventHandler
{
	// Methods

	// RVA: 0x114E784
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x114E8A4
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

	// RVA: 0x114E8B8
	internal void .ctor() { }

	// RVA: 0x114E930
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

	// RVA: 0x114E9CC
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x114F1D4
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x114EBE8
	private void Init() { }

	// RVA: 0x114EFB8
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x114F1DC
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x114F2B0
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x114F348
	public override string get_Name() { }

	// RVA: 0x114F474
	public override string get_LocalName() { }

	// RVA: 0x114F4B4
	public override string get_NamespaceURI() { }

	// RVA: 0x114F4F4
	public override string get_Prefix() { }

	// RVA: 0x114F534
	public override string get_Value() { }

	// RVA: 0x114F574
	public override int get_Depth() { }

	// RVA: 0x114F5B4
	public override string get_BaseURI() { }

	// RVA: 0x114F5DC
	public override bool get_IsEmptyElement() { }

	// RVA: 0x114F604
	public override bool get_IsDefault() { }

	// RVA: 0x114F644
	public override Char get_QuoteChar() { }

	// RVA: 0x114F66C
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x114F694
	public override string get_XmlLang() { }

	// RVA: 0x114F6BC
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x114F6C0
	public override Type get_ValueType() { }

	// RVA: 0x114F7AC
	public override int get_AttributeCount() { }

	// RVA: 0x114F7B4
	public override string GetAttribute(string name) { }

	// RVA: 0x114F9C4
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x114FC34
	public override string GetAttribute(int i) { }

	// RVA: 0x114FD28
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1150038
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1150234
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x11503F8
	public override bool MoveToNextAttribute() { }

	// RVA: 0x11505BC
	public override bool MoveToElement() { }

	// RVA: 0x1150624
	public override bool Read() { }

	// RVA: 0x1150B0C
	public override bool get_EOF() { }

	// RVA: 0x1150B34
	public override void Close() { }

	// RVA: 0x1150B74
	public override ReadState get_ReadState() { }

	// RVA: 0x1150BB4
	public override void Skip() { }

	// RVA: 0x1150D1C
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1150D24
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1150DDC
	public override void ResolveEntity() { }

	// RVA: 0x1150E1C
	public override bool ReadAttributeValue() { }

	// RVA: 0x1151020
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1151360
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x11513BC
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1151474
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x115161C
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x115168C
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x11516F4
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x115174C
	public bool HasLineInfo() { }

	// RVA: 0x1151754
	public int get_LineNumber() { }

	// RVA: 0x1151818
	public int get_LinePosition() { }

	// RVA: 0x11518DC
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11519B8
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1151A98
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1151B78
	private object GetStringValue() { }

	// RVA: 0x114F78C
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x11507F8
	private void ProcessReaderEvent() { }

	// RVA: 0x1151B9C
	private void ProcessElementEvent() { }

	// RVA: 0x1152068
	private void ProcessEndElementEvent() { }

	// RVA: 0x11522EC
	private void ValidateAttributes() { }

	// RVA: 0x1150ABC
	private void ClearAttributesInfo() { }

	// RVA: 0x114FE20
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x1152830
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x114F834
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x114FAE4
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x1152660
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x11522A0
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x11509C4
	private void ProcessInlineSchema() { }

	// RVA: 0x11528FC
	private void ReadAheadForMemberType() { }

	// RVA: 0x11510BC
	private void GetIsDefault() { }

	// RVA: 0x1151508
	private void GetMemberType() { }

	// RVA: 0x115255C
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x1150F7C
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x1152B98
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x11524B4
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

	// RVA: 0x1152BE4
	public void .ctor(XmlDocument document, XmlNode node) { }

	// RVA: 0x1152DD8
	public void .ctor(DocumentXPathNavigator other) { }

	// RVA: 0x1152E9C
	public override XPathNavigator Clone() { }

	// RVA: 0x1152F00
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1152F48
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x1153034
	public override string get_LocalName() { }

	// RVA: 0x115305C
	public override string get_NamespaceURI() { }

	// RVA: 0x115316C
	public override string get_Name() { }

	// RVA: 0x11532B8
	public override string get_Prefix() { }

	// RVA: 0x1153398
	public override string get_Value() { }

	// RVA: 0x115344C
	private string get_ValueDocument() { }

	// RVA: 0x1153530
	private string get_ValueText() { }

	// RVA: 0x11537E8
	public override string get_BaseURI() { }

	// RVA: 0x1153810
	public override string get_XmlLang() { }

	// RVA: 0x1153838
	public override object get_UnderlyingObject() { }

	// RVA: 0x115385C
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1153B90
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1153D10
	public override bool MoveToNextAttribute() { }

	// RVA: 0x115404C
	public override bool MoveToNamespace(string name) { }

	// RVA: 0x11543C0
	public override bool MoveToFirstNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x1154648
	private static bool MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x11546D0
	private static bool MoveToFirstNamespaceGlobal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x11549D8
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x1154E5C
	private static bool MoveToNextNamespaceLocal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x1154854
	private static bool MoveToNextNamespaceGlobal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x1154EF0
	private bool PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, string localName) { }

	// RVA: 0x1154FEC
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x115504C
	public override bool MoveToNext() { }

	// RVA: 0x11553D4
	public override bool MoveToFirstChild() { }

	// RVA: 0x1155698
	public override bool MoveToParent() { }

	// RVA: 0x1155828
	public override void MoveToRoot() { }

	// RVA: 0x1155940
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x11559F4
	public override bool MoveToId(string id) { }

	// RVA: 0x1155A5C
	public override bool MoveToChild(string localName, string namespaceUri) { }

	// RVA: 0x1155BD8
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x1155D4C
	public override bool MoveToFollowing(string localName, string namespaceUri, XPathNavigator end) { }

	// RVA: 0x1155FD4
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x11562D8
	public override bool MoveToNext(string localName, string namespaceUri) { }

	// RVA: 0x11563AC
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x115650C
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x11565B4
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x11567C8
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11567F0
	private static XmlNode OwnerNode(XmlNode node) { }

	// RVA: 0x11568A4
	private static int GetDepth(XmlNode node) { }

	// RVA: 0x1156A10
	private XmlNodeOrder Compare(XmlNode node1, XmlNode node2) { }

	// RVA: 0x1156C28
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x11571BC
	private XmlNode System.Xml.IHasXmlNode.GetNode() { }

	// RVA: 0x11571C4
	public override XPathNodeIterator SelectDescendants(string localName, string namespaceURI, bool matchSelf) { }

	// RVA: 0x11574E4
	public override XPathNodeIterator SelectDescendants(XPathNodeType nt, bool includeSelf) { }

	// RVA: 0x1152C74
	internal void ResetPosition(XmlNode node) { }

	// RVA: 0x1153FC0
	private static bool ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, int index) { }

	// RVA: 0x1153EF8
	private static bool CheckAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, int index) { }

	// RVA: 0x1152F80
	private void CalibrateText() { }

	// RVA: 0x1155288
	private XmlNode ParentNode(XmlNode node) { }

	// RVA: 0x1157680
	private XmlNode ParentNodeTail(XmlNode parent) { }

	// RVA: 0x115560C
	private XmlNode FirstChild(XmlNode node) { }

	// RVA: 0x11576D4
	private XmlNode FirstChildTail(XmlNode child) { }

	// RVA: 0x11536F0
	private XmlNode NextSibling(XmlNode node) { }

	// RVA: 0x115772C
	private XmlNode NextSiblingTail(XmlNode node, XmlNode sibling) { }

	// RVA: 0x1157620
	private XmlNode PreviousText(XmlNode node) { }

	// RVA: 0x11577F0
	private XmlNode PreviousTextTail(XmlNode node, XmlNode text) { }

	// RVA: 0x11566E4
	private static bool IsDescendant(XmlNode top, XmlNode bottom) { }

	// RVA: 0x115530C
	private static bool IsValidChild(XmlNode parent, XmlNode child) { }

	// RVA: 0x1155230
	private XmlNode TextEnd(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_Empty
{
	// Fields
	private XPathNavigator nav; // 0x18

	// Methods

	// RVA: 0x115739C
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x1157914
	internal void .ctor(DocumentXPathNodeIterator_Empty other) { }

	// RVA: 0x1157968
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11579FC
	public override bool MoveNext() { }

	// RVA: 0x1157A04
	public override XPathNavigator get_Current() { }

	// RVA: 0x1157A0C
	public override int get_CurrentPosition() { }

	// RVA: 0x1157A14
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

	// RVA: 0x1157A1C
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x1157ADC
	internal void .ctor(DocumentXPathNodeIterator_ElemDescendants other) { }

	// RVA: -1
	protected abstract bool Match(XmlNode node) { }

	// RVA: 0x1157BA4
	public override XPathNavigator get_Current() { }

	// RVA: 0x1157BAC
	public override int get_CurrentPosition() { }

	// RVA: 0x1157BB4
	protected void SetPosition(int pos) { }

	// RVA: 0x1157BBC
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_AllElemChildren
{
	// Methods

	// RVA: 0x115761C
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x1157D44
	internal void .ctor(DocumentXPathNodeIterator_AllElemChildren other) { }

	// RVA: 0x1157D48
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1157DAC
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_AllElemChildren_AndSelf
{
	// Methods

	// RVA: 0x1157618
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x1157DE0
	internal void .ctor(DocumentXPathNodeIterator_AllElemChildren_AndSelf other) { }

	// RVA: 0x1157DE4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1157E48
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren_NoLocalName
{
	// Fields
	private string nsAtom; // 0x28

	// Methods

	// RVA: 0x115741C
	internal void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x1157F6C
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_NoLocalName other) { }

	// RVA: 0x1157FA4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1158020
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName
{
	// Methods

	// RVA: 0x11573EC
	internal void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x1158064
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName other) { }

	// RVA: 0x115809C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1158118
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren
{
	// Fields
	protected string localNameAtom; // 0x28
	protected string nsAtom; // 0x30

	// Methods

	// RVA: 0x1157498
	internal void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x115823C
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren other) { }

	// RVA: 0x1158284
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1158310
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf
{
	// Methods

	// RVA: 0x115744C
	internal void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x1158384
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf other) { }

	// RVA: 0x11583CC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1158458
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

	// RVA: 0x115857C
	public void .ctor(XmlDocument document) { }

	// RVA: 0x115862C
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11587B0
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1158A3C
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

	// RVA: 0x1158BC4
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1158C74
	public override int get_Count() { }

	// RVA: 0x1158DC8
	private XmlNode GetNode(XPathNavigator n) { }

	// RVA: 0x1158CE4
	internal int ReadUntil(int index) { }

	// RVA: 0x1158EC8
	public override XmlNode Item(int index) { }

	// RVA: 0x1158F94
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1159058
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

	// RVA: 0x1159014
	public void .ctor(XPathNodeList list) { }

	// RVA: 0x11590D8
	public void Reset() { }

	// RVA: 0x11590E4
	public bool MoveNext() { }

	// RVA: 0x1159160
	public object get_Current() { }

}

// Namespace: System.Xml
public class XmlAttribute
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Methods

	// RVA: 0x11591A0
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0x11593C8
	internal int get_LocalNameHash() { }

	// RVA: 0x11593E8
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x1159548
	internal XmlName get_XmlName() { }

	// RVA: 0x1159550
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x1159558
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1159624
	public override XmlNode get_ParentNode() { }

	// RVA: 0x115962C
	public override string get_Name() { }

	// RVA: 0x115964C
	public override string get_LocalName() { }

	// RVA: 0x115966C
	public override string get_NamespaceURI() { }

	// RVA: 0x115968C
	public override string get_Prefix() { }

	// RVA: 0x11596AC
	public override void set_Prefix(string value) { }

	// RVA: 0x1159758
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1159760
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1159780
	public override string get_Value() { }

	// RVA: 0x1159790
	public override void set_Value(string value) { }

	// RVA: 0x11597A0
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11597A8
	public override void set_InnerText(string value) { }

	// RVA: 0x1159878
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0x1159938
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x1159B80
	internal override bool get_IsContainer() { }

	// RVA: 0x1159B88
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1159E7C
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1159E84
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1159E8C
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1159E9C
	public virtual bool get_Specified() { }

	// RVA: 0x1159EA4
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1159F84
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x115A064
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x115A138
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x115A20C
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x115A2E0
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0x115A368
	public override void set_InnerXml(string value) { }

	// RVA: 0x115A3F8
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x115A4AC
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x115A514
	public override string get_BaseURI() { }

	// RVA: 0x115A5B0
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x115A5B8
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0x115A61C
	internal override string get_XmlLang() { }

	// RVA: 0x115A6B8
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x115A6F8
	internal override string get_XPLocalName() { }

	// RVA: 0x115313C
	internal bool get_IsNamespace() { }

}

// Namespace: System.Xml
public sealed class XmlAttributeCollection
{
	// Methods

	// RVA: 0x115A7A4
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x1153A38
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0x115A7AC
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0x115A8F0
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0x115AA58
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0x115AC40
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x115AEF8
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0x115B24C
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0x115B2F4
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0x115B3BC
	public void RemoveAll() { }

	// RVA: 0x115B49C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x115B53C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x115B544
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x115B548
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x115B550
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0x115B748
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0x115B7FC
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x115B028
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0x115B0F4
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x115B9A8
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x115B638
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0x11599C0
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0x1159AC0
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0x115AE4C
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

}

// Namespace: System.Xml
public class XmlCDataSection
{
	// Methods

	// RVA: 0x115C10C
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x115C17C
	public override string get_Name() { }

	// RVA: 0x115C1A8
	public override string get_LocalName() { }

	// RVA: 0x115C1D4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x115C1DC
	public override XmlNode get_ParentNode() { }

	// RVA: 0x115C278
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x115C2D8
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x115C320
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x115C324
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x115C32C
	internal override bool get_IsText() { }

	// RVA: 0x115C334
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public abstract class XmlCharacterData
{
	// Fields
	private string data; // 0x20

	// Methods

	// RVA: 0x115C144
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x115C384
	public override string get_Value() { }

	// RVA: 0x115C394
	public override void set_Value(string value) { }

	// RVA: 0x115C3A4
	public override string get_InnerText() { }

	// RVA: 0x115C3B0
	public override void set_InnerText(string value) { }

	// RVA: 0x115C3BC
	public virtual string get_Data() { }

	// RVA: 0x115C428
	public virtual void set_Data(string value) { }

	// RVA: 0x115C4EC
	internal bool CheckOnData(string data) { }

	// RVA: 0x115C52C
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

	// RVA: 0x115C634
	internal void .ctor(XmlNode container) { }

	// RVA: 0x115C6A0
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x115C748
	internal bool MoveNext() { }

	// RVA: 0x115C7F0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x115C83C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x115C840
	internal XmlNode get_Current() { }

}

// Namespace: System.Xml
internal class XmlChildNodes
{
	// Fields
	private XmlNode container; // 0x10

	// Methods

	// RVA: 0x115C8B8
	public void .ctor(XmlNode container) { }

	// RVA: 0x115C8EC
	public override XmlNode Item(int i) { }

	// RVA: 0x115C95C
	public override int get_Count() { }

	// RVA: 0x115C9B4
	public override IEnumerator GetEnumerator() { }

}

// Namespace: System.Xml
public class XmlComment
{
	// Methods

	// RVA: 0x115CAD0
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0x115CB08
	public override string get_Name() { }

	// RVA: 0x115CB34
	public override string get_LocalName() { }

	// RVA: 0x115CB60
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x115CB68
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x115CBC8
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x115CC10
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x115CC14
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

	// RVA: 0x115CC1C
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x115D0BC
	public string get_Version() { }

	// RVA: 0x115D0C4
	internal void set_Version(string value) { }

	// RVA: 0x115D0CC
	public string get_Encoding() { }

	// RVA: 0x115CED0
	public void set_Encoding(string value) { }

	// RVA: 0x115D0D4
	public string get_Standalone() { }

	// RVA: 0x115CF4C
	public void set_Standalone(string value) { }

	// RVA: 0x115D0DC
	public override string get_Value() { }

	// RVA: 0x115D0EC
	public override void set_Value(string value) { }

	// RVA: 0x115D0FC
	public override string get_InnerText() { }

	// RVA: 0x115D278
	public override void set_InnerText(string value) { }

	// RVA: 0x115D4B8
	public override string get_Name() { }

	// RVA: 0x115D4FC
	public override string get_LocalName() { }

	// RVA: 0x115D508
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x115D510
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x115D558
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x115D5C4
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x115CE4C
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

	// RVA: 0x115D5C8
	public void .ctor() { }

	// RVA: 0x115DAE0
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x115D630
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x115DB50
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x115DB58
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0x11592C8
	internal static void CheckName(string name) { }

	// RVA: 0x115DB60
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x115DB7C
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1159428
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x115DB98
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0x115DC74
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0x115BDB8
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0x115DD54
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0x115BDCC
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0x115BFC4
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0x115E37C
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x115E4EC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x115E4F4
	public override XmlNode get_ParentNode() { }

	// RVA: 0x115E4FC
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0x115E58C
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x115E64C
	public XmlImplementation get_Implementation() { }

	// RVA: 0x115E654
	public override string get_Name() { }

	// RVA: 0x115E65C
	public override string get_LocalName() { }

	// RVA: 0x1153660
	public XmlElement get_DocumentElement() { }

	// RVA: 0x115E664
	internal override bool get_IsContainer() { }

	// RVA: 0x115E66C
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x115E674
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x115E67C
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x115E684
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x115E68C
	internal bool get_CanReportValidity() { }

	// RVA: 0x115E694
	internal bool get_HasSetResolver() { }

	// RVA: 0x115E69C
	internal XmlResolver GetResolver() { }

	// RVA: 0x115E6A4
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x115E86C
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x115E9C8
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x115EA88
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x115EAEC
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x115ED04
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x115EE78
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0x115EF84
	internal void SetDefaultNamespace(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x115F028
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0x115F0AC
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0x115F128
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x115F1C0
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0x115F228
	public XmlElement CreateElement(string name) { }

	// RVA: 0x115F2C8
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0x115F574
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0x115F6A8
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x115F808
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0x115F878
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x115F8F8
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x115F97C
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0x115F9EC
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0x115FA5C
	public override XPathNavigator CreateNavigator() { }

	// RVA: 0x115FA70
	protected internal virtual XPathNavigator CreateNavigator(XmlNode node) { }

	// RVA: 0x115FE28
	internal static bool IsTextNode(XmlNodeType nt) { }

	// RVA: 0x115FC5C
	private XmlNode NormalizeText(XmlNode n) { }

	// RVA: 0x115FE40
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0x115FEB0
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0x115FF54
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0x115FFF8
	public virtual XmlElement GetElementById(string elementId) { }

	// RVA: 0x1160398
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0x116097C
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0x115E43C
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0x1152F28
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1160AE0
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1160B78
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1160C00
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1160CD4
	public override bool get_IsReadOnly() { }

	// RVA: 0x1160CDC
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x1160D7C
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0x1160D84
	internal bool get_IsLoading() { }

	// RVA: 0x1160D8C
	internal void set_IsLoading(bool value) { }

	// RVA: 0x1160D94
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0x1160D9C
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0x1160E90
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0x1160EF4
	public virtual void Load(XmlReader reader) { }

	// RVA: 0x1161018
	public virtual void LoadXml(string xml) { }

	// RVA: 0x1161194
	public override void set_InnerText(string value) { }

	// RVA: 0x11611F0
	public override void set_InnerXml(string value) { }

	// RVA: 0x1161200
	public virtual void Save(XmlWriter w) { }

	// RVA: 0x1161434
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1161444
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0x116170C
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1159DB4
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0x1161808
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x116185C
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x115BB00
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x11618B0
	internal string get_Version() { }

	// RVA: 0x11618D8
	internal string get_Encoding() { }

	// RVA: 0x116140C
	internal string get_Standalone() { }

	// RVA: 0x1161900
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0x11619D4
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1161BB4
	public override string get_BaseURI() { }

	// RVA: 0x1161BBC
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0x1161BCC
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1161E74
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x1161E7C
	internal bool get_HasEntityReferences() { }

	// RVA: 0x11542F8
	internal XmlAttribute get_NamespaceXml() { }

	// RVA: 0x1161E84
	private static void .cctor() { }

}

// Namespace: System.Xml
public class XmlDocumentFragment
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Methods

	// RVA: 0x1161FA4
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x1162034
	public override string get_Name() { }

	// RVA: 0x1162060
	public override string get_LocalName() { }

	// RVA: 0x116208C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1162094
	public override XmlNode get_ParentNode() { }

	// RVA: 0x116209C
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1162118
	public override void set_InnerXml(string value) { }

	// RVA: 0x11623F0
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1162474
	internal override bool get_IsContainer() { }

	// RVA: 0x116247C
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1162484
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x116248C
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1162508
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x116258C
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11625F8
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1162608
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x116296C
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

	// RVA: 0x1162974
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x1162B7C
	public override string get_Name() { }

	// RVA: 0x1162B84
	public override string get_LocalName() { }

	// RVA: 0x1162B8C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1162B94
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1162BDC
	public override bool get_IsReadOnly() { }

	// RVA: 0x1162BE4
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x1162CC4
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x1162D70
	public string get_PublicId() { }

	// RVA: 0x1162D78
	public string get_SystemId() { }

	// RVA: 0x1162D80
	public string get_InternalSubset() { }

	// RVA: 0x1162D88
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x1162D90
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1162DC0
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1162DC4
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x1162DCC
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

}

// Namespace: System.Xml
internal class XmlDOMTextWriter
{
	// Methods

	// RVA: 0x1162DD4
	public void .ctor(TextWriter w) { }

	// RVA: 0x1162E40
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1162ED8
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

	// RVA: 0x1162F70
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x11630E0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x1163128
	internal XmlName get_XmlName() { }

	// RVA: 0x1163130
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x1163138
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11637C0
	public override string get_Name() { }

	// RVA: 0x11639D4
	public override string get_LocalName() { }

	// RVA: 0x11639F4
	public override string get_NamespaceURI() { }

	// RVA: 0x1163A14
	public override string get_Prefix() { }

	// RVA: 0x1163A34
	public override void set_Prefix(string value) { }

	// RVA: 0x1163AE4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1163AEC
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1163AF4
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1163B14
	internal override bool get_IsContainer() { }

	// RVA: 0x1163B1C
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11636E4
	public bool get_IsEmpty() { }

	// RVA: 0x11636F4
	public void set_IsEmpty(bool value) { }

	// RVA: 0x1163D78
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1163D88
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1163D90
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1163DA8
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x1163F0C
	public virtual bool get_HasAttributes() { }

	// RVA: 0x1163F38
	public virtual string GetAttribute(string name) { }

	// RVA: 0x1163FC8
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x1164084
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x11640EC
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x1164208
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x11642A0
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x11643C8
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x1164444
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x116453C
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x1164564
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1164698
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x11648F8
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0x1164A14
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1164A7C
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x1164AC8
	public override void RemoveAll() { }

	// RVA: 0x1163D04
	internal void RemoveAllChildren() { }

	// RVA: 0x1164BC0
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1164BC8
	public override void set_InnerXml(string value) { }

	// RVA: 0x1164D80
	public override string get_InnerText() { }

	// RVA: 0x1164E9C
	public override void set_InnerText(string value) { }

	// RVA: 0x1164FB4
	public override XmlNode get_NextSibling() { }

	// RVA: 0x1165004
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x116500C
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x1165014
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

	// RVA: 0x1165024
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x116517C
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11651D8
	public override bool get_IsReadOnly() { }

	// RVA: 0x11651E0
	public override string get_Name() { }

	// RVA: 0x11651E8
	public override string get_LocalName() { }

	// RVA: 0x11651F0
	public override string get_InnerText() { }

	// RVA: 0x11651F4
	public override void set_InnerText(string value) { }

	// RVA: 0x1165250
	internal override bool get_IsContainer() { }

	// RVA: 0x1165258
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1165434
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x116543C
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1165454
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x116545C
	public string get_SystemId() { }

	// RVA: 0x1165464
	public override string get_OuterXml() { }

	// RVA: 0x11654B0
	public override void set_InnerXml(string value) { }

	// RVA: 0x116550C
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1165510
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1165514
	public override string get_BaseURI() { }

	// RVA: 0x116551C
	internal void SetBaseURI(string inBaseURI) { }

}

// Namespace: System.Xml
public class XmlEntityReference
{
	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Methods

	// RVA: 0x1165524
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x1165628
	public override string get_Name() { }

	// RVA: 0x1165630
	public override string get_LocalName() { }

	// RVA: 0x1165638
	public override string get_Value() { }

	// RVA: 0x1165640
	public override void set_Value(string value) { }

	// RVA: 0x116569C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11656A4
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11656E8
	public override bool get_IsReadOnly() { }

	// RVA: 0x11656F0
	internal override bool get_IsContainer() { }

	// RVA: 0x11656F8
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x1165E20
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x1165E30
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1165E38
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1165E40
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1165E58
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1165E88
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1166184
	public override string get_BaseURI() { }

	// RVA: 0x11661B8
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x11662A0
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

	// RVA: 0x1166378
	public void .ctor() { }

	// RVA: 0x11664D4
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x1166508
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0x1166570
	internal XmlNameTable get_NameTable() { }

}

// Namespace: System.Xml
public abstract class XmlLinkedNode
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Methods

	// RVA: 0x1162ADC
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x1166578
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x11665F0
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

	// RVA: 0x11621A8
	public void .ctor() { }

	// RVA: 0x116664C
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x11668D8
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x1166FA4
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x116695C
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x11670FC
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x1167BF4
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x1167DC4
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x1167444
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x116774C
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x11678F8
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x11680FC
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x1169808
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x1162B08
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x1169B10
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x11688C8
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x1169F04
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x11621B0
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x1164CF8
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x116ADC4
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x116AB08
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x116ADCC
	private string EntitizeName(string name) { }

	// RVA: 0x1165388
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x1165840
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x116A818
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x1168608
	internal static void ParseXmlDeclarationValue(string strValue, string version, string encoding, string standalone) { }

	// RVA: 0x1167AE0
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

	// RVA: 0x116AE48
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x116AF88
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x116B4B8
	public string get_LocalName() { }

	// RVA: 0x116B4C0
	public string get_NamespaceURI() { }

	// RVA: 0x116B4C8
	public string get_Prefix() { }

	// RVA: 0x116B4D0
	public int get_HashCode() { }

	// RVA: 0x116B4D8
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x11637DC
	public string get_Name() { }

	// RVA: 0x116B4E0
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x116B4E8
	public virtual bool get_IsDefault() { }

	// RVA: 0x116B4F0
	public virtual bool get_IsNil() { }

	// RVA: 0x116B4F8
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x116B500
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x116B508
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x116B510
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x116B518
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x116B524
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

	// RVA: 0x116B03C
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x116B5F0
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x116B628
	public override bool get_IsDefault() { }

	// RVA: 0x116B634
	public override bool get_IsNil() { }

	// RVA: 0x116B640
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x116B648
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x116B650
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x116B6D8
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x116B59C
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x116B5B0
	public void SetIsDefault(bool value) { }

	// RVA: 0x116B5D0
	public void SetIsNil(bool value) { }

	// RVA: 0x116B760
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }

}

// Namespace: 
private class SingleObjectEnumerator
{
	// Fields
	private object loneValue; // 0x10
	private int position; // 0x18

	// Methods

	// RVA: 0x116CB84
	public void .ctor(object value) { }

	// RVA: 0x116CBC0
	public object get_Current() { }

	// RVA: 0x116CC18
	public bool MoveNext() { }

	// RVA: 0x116CC30
	public void Reset() { }

}

// Namespace: 
internal struct SmallXmlNodeList
{
	// Fields
	private object field; // 0x10

	// Methods

	// RVA: 0x116C044
	public int get_Count() { }

	// RVA: 0x116BC70
	public object get_Item(int index) { }

	// RVA: 0x116C3B8
	public void Add(object value) { }

	// RVA: 0x116C71C
	public void RemoveAt(int index) { }

	// RVA: 0x116C9D0
	public void Insert(int index, object value) { }

	// RVA: 0x116C0DC
	public IEnumerator GetEnumerator() { }

}

// Namespace: System.Xml
public class XmlNamedNodeMap
{
	// Fields
	internal XmlNode parent; // 0x10
	internal SmallXmlNodeList nodes; // 0x18

	// Methods

	// RVA: 0x1162C90
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x116BACC
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x116BD5C
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x116BFB4
	public virtual int get_Count() { }

	// RVA: 0x116C0D4
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x116BB80
	internal int FindNodeOffset(string name) { }

	// RVA: 0x116BE28
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x116C208
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x116C500
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x116C5AC
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x116BF5C
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x116C814
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

}

// Namespace: System.Xml
public abstract class XmlNode
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Methods

	// RVA: 0x116202C
	internal void .ctor() { }

	// RVA: 0x11650F4
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x116CC3C
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: 0x116CCE4
	public XmlNodeList SelectNodes(string xpath) { }

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: 0x116CD94
	public virtual string get_Value() { }

	// RVA: 0x116CD9C
	public virtual void set_Value(string value) { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x116CE70
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x116CF64
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x116CFCC
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x116CFD4
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x116CFDC
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x116CFE4
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x116D0A0
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x116D0C8
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x116D0D8
	internal virtual bool get_IsContainer() { }

	// RVA: 0x116D0E0
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x116D0E8
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x116D0EC
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x116D158
	internal bool IsConnected() { }

	// RVA: 0x116D1B8
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x116D830
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x116DE18
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x116E238
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x116E280
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x116E7D4
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x116E9A4
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x116E9AC
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x116E9B4
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x116E9BC
	public virtual bool get_HasChildNodes() { }

	// RVA: -1
	public abstract XmlNode CloneNode(bool deep) { }

	// RVA: 0x116E9E4
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x116EA84
	public virtual string get_NamespaceURI() { }

	// RVA: 0x116EAD0
	public virtual string get_Prefix() { }

	// RVA: 0x116EB1C
	public virtual void set_Prefix(string value) { }

	// RVA: -1
	public abstract string get_LocalName() { }

	// RVA: 0x116EB20
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x116EC28
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x116ED34
	private object System.ICloneable.Clone() { }

	// RVA: 0x116ED48
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1162904
	public IEnumerator GetEnumerator() { }

	// RVA: 0x116EDB0
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x1164D84
	public virtual string get_InnerText() { }

	// RVA: 0x116EEB8
	public virtual void set_InnerText(string value) { }

	// RVA: 0x116EF9C
	public virtual string get_OuterXml() { }

	// RVA: 0x116F150
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x116F1AC
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x116F228
	public virtual string get_BaseURI() { }

	// RVA: -1
	public abstract void WriteTo(XmlWriter w) { }

	// RVA: -1
	public abstract void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1164B4C
	public virtual void RemoveAll() { }

	// RVA: 0x116F354
	internal XmlDocument get_Document() { }

	// RVA: 0x116F404
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x116F490
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x11657EC
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x116F8FC
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x116F904
	internal static void SplitName(string name, string prefix, string localName) { }

	// RVA: 0x116FA04
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x116FA70
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x116FBA0
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x116FBF4
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x116FC48
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x116FDDC
	internal virtual string get_XmlLang() { }

	// RVA: 0x116FEE4
	internal virtual XPathNodeType get_XPNodeType() { }

	// RVA: 0x116FEEC
	internal virtual string get_XPLocalName() { }

	// RVA: 0x116FF38
	internal virtual bool get_IsText() { }

	// RVA: 0x116FF40
	public virtual XmlNode get_PreviousText() { }

	// RVA: 0x1163CDC
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x116D7F0
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

	// RVA: 0x116FF48
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1170030
	public XmlNodeChangedAction get_Action() { }

}

// Namespace: System.Xml
public sealed class XmlNodeChangedEventHandler
{
	// Methods

	// RVA: 0x1170038
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x117015C
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

	// RVA: 0x1170170
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0x117017C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1170188
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x117018C
	protected void .ctor() { }

}

// Namespace: 
internal struct VirtualAttribute
{
	// Fields
	internal string name; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x1170534
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

	// RVA: 0x1170194
	public void .ctor(XmlNode node) { }

	// RVA: 0x1170568
	public XmlNodeType get_NodeType() { }

	// RVA: 0x11705B8
	public string get_NamespaceURI() { }

	// RVA: 0x11705E0
	public string get_Name() { }

	// RVA: 0x117070C
	public string get_LocalName() { }

	// RVA: 0x11707D0
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0x11706EC
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0x11707D8
	public string get_Prefix() { }

	// RVA: 0x1170800
	public string get_Value() { }

	// RVA: 0x1170CB8
	public string get_BaseURI() { }

	// RVA: 0x1170CE0
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x1170D08
	public string get_XmlLang() { }

	// RVA: 0x1170D30
	public bool get_IsEmptyElement() { }

	// RVA: 0x1170DE8
	public bool get_IsDefault() { }

	// RVA: 0x1170EA4
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1170ECC
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1170ED4
	public int get_AttributeCount() { }

	// RVA: 0x1171178
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0x1170AE4
	private void InitDecAttr() { }

	// RVA: 0x11711EC
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0x11712D0
	public string GetDeclarationAttr(int i) { }

	// RVA: 0x1171328
	public int GetDecAttrInd(string name) { }

	// RVA: 0x1171034
	private void InitDocTypeAttr() { }

	// RVA: 0x11713D0
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0x1171480
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0x11714D8
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0x1171580
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0x11715C8
	public string GetAttribute(string name) { }

	// RVA: 0x1171844
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x1171890
	public string GetAttribute(string name, string ns) { }

	// RVA: 0x1171B2C
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0x1171D88
	public void LogMove(int level) { }

	// RVA: 0x1171DD0
	public void RollBackMove(int level) { }

	// RVA: 0x1171E20
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0x1171E54
	public void ResetToAttribute(int level) { }

	// RVA: 0x1171F3C
	public void ResetMove(int level, XmlNodeType nt) { }

	// RVA: 0x1172130
	public bool MoveToAttribute(string name) { }

	// RVA: 0x11723DC
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x1172194
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0x11724D8
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x117273C
	public bool MoveToNextAttribute(int level) { }

	// RVA: 0x117298C
	public bool MoveToParent() { }

	// RVA: 0x1172A10
	public bool MoveToFirstChild() { }

	// RVA: 0x1172A9C
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0x1172B2C
	public bool MoveToNext() { }

	// RVA: 0x1172BB4
	public bool MoveToElement() { }

	// RVA: 0x1172C5C
	public string LookupNamespace(string prefix) { }

	// RVA: 0x1172F64
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0x117309C
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1173470
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1173970
	public bool ReadAttributeValue(int level, bool bResolveEntity, XmlNodeType nt) { }

	// RVA: 0x1173BF8
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

	// RVA: 0x1173C00
	public void .ctor(XmlNode node) { }

	// RVA: 0x1173D14
	internal bool IsInReadingStates() { }

	// RVA: 0x1173D24
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1173D40
	public override string get_Name() { }

	// RVA: 0x1173DB4
	public override string get_LocalName() { }

	// RVA: 0x1173EBC
	public override string get_NamespaceURI() { }

	// RVA: 0x1173F44
	public override string get_Prefix() { }

	// RVA: 0x1173FCC
	public override string get_Value() { }

	// RVA: 0x1174040
	public override int get_Depth() { }

	// RVA: 0x1174048
	public override string get_BaseURI() { }

	// RVA: 0x1174078
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1174080
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1174148
	public override bool get_IsDefault() { }

	// RVA: 0x117417C
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x11741C4
	public override string get_XmlLang() { }

	// RVA: 0x117424C
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1174294
	public override int get_AttributeCount() { }

	// RVA: 0x11742D4
	public override string GetAttribute(string name) { }

	// RVA: 0x1174308
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x11743A0
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x1174418
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11745C8
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x11747F0
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1174944
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1174AAC
	public override bool MoveToElement() { }

	// RVA: 0x1174C5C
	public override bool Read() { }

	// RVA: 0x1174C64
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x1174E38
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x1175404
	private void SetEndOfFile() { }

	// RVA: 0x117541C
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x1175250
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x1175228
	private void ReSetReadingMarks() { }

	// RVA: 0x1175544
	public override bool get_EOF() { }

	// RVA: 0x1175568
	public override void Close() { }

	// RVA: 0x1175574
	public override ReadState get_ReadState() { }

	// RVA: 0x117557C
	public override void Skip() { }

	// RVA: 0x1175584
	public override string ReadString() { }

	// RVA: 0x117562C
	public override bool get_HasAttributes() { }

	// RVA: 0x1175654
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1175674
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11756B8
	public override void ResolveEntity() { }

	// RVA: 0x1175740
	public override bool ReadAttributeValue() { }

	// RVA: 0x11745A4
	private void FinishReadBinary() { }

	// RVA: 0x11757A0
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11757BC
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x11757D8
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x117584C
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

	// RVA: 0x1169E6C
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x1175874
	public override string get_Name() { }

	// RVA: 0x117587C
	public override string get_LocalName() { }

	// RVA: 0x1175884
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x117588C
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11758E8
	public override bool get_IsReadOnly() { }

	// RVA: 0x11758F0
	public override string get_OuterXml() { }

	// RVA: 0x117593C
	public override void set_InnerXml(string value) { }

	// RVA: 0x1175998
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x117599C
	public override void WriteContentTo(XmlWriter w) { }

}

// Namespace: System.Xml
public class XmlProcessingInstruction
{
	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Methods

	// RVA: 0x1169AA8
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0x11759A0
	public override string get_Name() { }

	// RVA: 0x1175A0C
	public override string get_LocalName() { }

	// RVA: 0x1175A18
	public override string get_Value() { }

	// RVA: 0x1175A20
	public override void set_Value(string value) { }

	// RVA: 0x1175AE4
	public void set_Data(string value) { }

	// RVA: 0x1175BA8
	public override string get_InnerText() { }

	// RVA: 0x1175BB0
	public override void set_InnerText(string value) { }

	// RVA: 0x1175C74
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1175C7C
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1175CC0
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1175CF0
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1175CF4
	internal override string get_XPLocalName() { }

	// RVA: 0x1175D00
	internal override XPathNodeType get_XPNodeType() { }

}

// Namespace: System.Xml
public class XmlSignificantWhitespace
{
	// Methods

	// RVA: 0x1169958
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1175D08
	public override string get_Name() { }

	// RVA: 0x1175D34
	public override string get_LocalName() { }

	// RVA: 0x1175D60
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1175D68
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1175E0C
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1175E6C
	public override string get_Value() { }

	// RVA: 0x1175E7C
	public override void set_Value(string value) { }

	// RVA: 0x1175F0C
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1175F54
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1175F58
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x1175F8C
	internal override bool get_IsText() { }

	// RVA: 0x1175F94
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public class XmlText
{
	// Methods

	// RVA: 0x11680F0
	internal void .ctor(string strData) { }

	// RVA: 0x11680E8
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1175FE4
	public override string get_Name() { }

	// RVA: 0x1176010
	public override string get_LocalName() { }

	// RVA: 0x117603C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1176044
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11760E0
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1176140
	public override string get_Value() { }

	// RVA: 0x1176150
	public override void set_Value(string value) { }

	// RVA: 0x1176230
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1176278
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x117627C
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x1176284
	internal override bool get_IsText() { }

	// RVA: 0x117628C
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal class XmlUnspecifiedAttribute
{
	// Fields
	private bool fSpecified; // 0x28

	// Methods

	// RVA: 0x1169B08
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x11762DC
	public override bool get_Specified() { }

	// RVA: 0x11762E4
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1176418
	public override void set_InnerText(string value) { }

	// RVA: 0x1176444
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1176470
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x117649C
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x11764C8
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x11764F4
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1176508
	internal void SetSpecified(bool f) { }

}

// Namespace: System.Xml
public class XmlWhitespace
{
	// Methods

	// RVA: 0x1169A00
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1176510
	public override string get_Name() { }

	// RVA: 0x117653C
	public override string get_LocalName() { }

	// RVA: 0x1176568
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1176570
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1176614
	public override string get_Value() { }

	// RVA: 0x1176624
	public override void set_Value(string value) { }

	// RVA: 0x11766B4
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1176714
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x117675C
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1176760
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x1176794
	internal override bool get_IsText() { }

	// RVA: 0x117679C
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal sealed class EmptyEnumerator
{
	// Methods

	// RVA: 0x11767EC
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x11767F4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x11767F8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1176854
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

	// RVA: 0x117685C
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x11768E0
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x117696C
	internal object Push() { }

	// RVA: 0x1176AB8
	internal object Pop() { }

	// RVA: 0x1176B08
	internal object Peek() { }

	// RVA: 0x1176B54
	internal void AddToTop(object o) { }

	// RVA: 0x1176BE0
	internal object get_Item(int index) { }

	// RVA: 0x1176C60
	internal void set_Item(int index, object value) { }

	// RVA: 0x1176D18
	internal int get_Length() { }

	// RVA: 0x1176D20
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x1176D7C
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

	// RVA: 0x1176E6C
	public virtual bool HasLineInfo() { }

	// RVA: 0x1176E74
	public virtual int get_LineNumber() { }

	// RVA: 0x1176E7C
	public virtual int get_LinePosition() { }

	// RVA: 0x1176E84
	public static PositionInfo GetPositionInfo(object o) { }

	// RVA: 0x1176F90
	public void .ctor() { }

}

// Namespace: System.Xml
internal class ReaderPositionInfo
{
	// Fields
	private IXmlLineInfo lineInfo; // 0x10

	// Methods

	// RVA: 0x1176F5C
	public void .ctor(IXmlLineInfo lineInfo) { }

	// RVA: 0x1176F98
	public override bool HasLineInfo() { }

	// RVA: 0x117704C
	public override int get_LineNumber() { }

	// RVA: 0x1177104
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

	// RVA: 0x11771BC
	public void .ctor(int lineNo, int linePos) { }

	// RVA: 0x11771C4
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

	// RVA: 0x1177920
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

	// RVA: 0x116644C
	public void .ctor() { }

	// RVA: 0x11771CC
	public override string Add(string key) { }

	// RVA: 0x1177484
	public override string Add(Char[] key, int start, int len) { }

	// RVA: 0x11777A0
	public override string Get(string value) { }

	// RVA: 0x1177350
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x1177978
	private void Grow() { }

	// RVA: 0x11776C4
	private static bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}

// Namespace: System.Xml
internal static class Ref
{
	// Methods

	// RVA: 0x116AE3C
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

	// RVA: 0x1184E30
	internal void .ctor(string name, int lineNo, int linePos) { }

}

// Namespace: 
private class ParseElementOnlyContent_LocalFrame
{
	// Fields
	public int startParenEntityId; // 0x10
	public Token parsingSchema; // 0x14

	// Methods

	// RVA: 0x1184E88
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

	// RVA: 0x1177B00
	private void .ctor() { }

	// RVA: 0x1169E18
	internal static IDtdParser Create() { }

	// RVA: 0x1177BE8
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x1178024
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x1178558
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x1178A90
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x1178AC0
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x1178AD0
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x1178AE0
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x1178BB8
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0x1178BE8
	private bool get_SupportNamespaces() { }

	// RVA: 0x1178BF0
	private bool get_Normalize() { }

	// RVA: 0x117858C
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x1178C5C
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x1178BF8
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x117A8EC
	private void ParseInternalSubset() { }

	// RVA: 0x117A8F0
	private void ParseExternalSubset() { }

	// RVA: 0x117AAD8
	private void ParseSubset() { }

	// RVA: 0x117AFD8
	private void ParseAttlistDecl() { }

	// RVA: 0x117D388
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x117DC4C
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x117B6F8
	private void ParseElementDecl() { }

	// RVA: 0x117E7F4
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x117EC2C
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x117E4BC
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x117BB34
	private void ParseEntityDecl() { }

	// RVA: 0x117BFBC
	private void ParseNotationDecl() { }

	// RVA: 0x117E0E8
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x117C384
	private void ParseComment() { }

	// RVA: 0x117C680
	private void ParsePI() { }

	// RVA: 0x117C93C
	private void ParseCondSection() { }

	// RVA: 0x117A0C8
	private void ParseExternalId(Token idTokenType, Token declType, string publicId, string systemId) { }

	// RVA: 0x1179300
	private Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x117F67C
	private Token ScanSubsetContent() { }

	// RVA: 0x117F5F0
	private Token ScanNameExpected() { }

	// RVA: 0x117F620
	private Token ScanQNameExpected() { }

	// RVA: 0x117F650
	private Token ScanNmtokenExpected() { }

	// RVA: 0x117FF04
	private Token ScanDoctype1() { }

	// RVA: 0x118013C
	private Token ScanDoctype2() { }

	// RVA: 0x1182DC0
	private Token ScanClosingTag() { }

	// RVA: 0x1180254
	private Token ScanElement1() { }

	// RVA: 0x1180540
	private Token ScanElement2() { }

	// RVA: 0x1180770
	private Token ScanElement3() { }

	// RVA: 0x118080C
	private Token ScanElement4() { }

	// RVA: 0x118094C
	private Token ScanElement5() { }

	// RVA: 0x1180AC8
	private Token ScanElement6() { }

	// RVA: 0x1180BAC
	private Token ScanElement7() { }

	// RVA: 0x1180C14
	private Token ScanAttlist1() { }

	// RVA: 0x1180CE4
	private Token ScanAttlist2() { }

	// RVA: 0x1181538
	private Token ScanAttlist3() { }

	// RVA: 0x11815E4
	private Token ScanAttlist4() { }

	// RVA: 0x11816C8
	private Token ScanAttlist5() { }

	// RVA: 0x11817AC
	private Token ScanAttlist6() { }

	// RVA: 0x1181C38
	private Token ScanAttlist7() { }

	// RVA: 0x11834B8
	private Token ScanLiteral(LiteralType literalType) { }

	// RVA: 0x118424C
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x1181D00
	private Token ScanNotation1() { }

	// RVA: 0x1181EEC
	private Token ScanSystemId() { }

	// RVA: 0x11820E0
	private Token ScanEntity1() { }

	// RVA: 0x1182168
	private Token ScanEntity2() { }

	// RVA: 0x1182398
	private Token ScanEntity3() { }

	// RVA: 0x1181FA4
	private Token ScanPublicId1() { }

	// RVA: 0x118205C
	private Token ScanPublicId2() { }

	// RVA: 0x11824B0
	private Token ScanCondSection1() { }

	// RVA: 0x1182830
	private Token ScanCondSection2() { }

	// RVA: 0x11828CC
	private Token ScanCondSection3() { }

	// RVA: 0x118312C
	private void ScanName() { }

	// RVA: 0x1183134
	private void ScanQName() { }

	// RVA: 0x1184610
	private void ScanQName(bool isQName) { }

	// RVA: 0x11848A0
	private bool ReadDataInName() { }

	// RVA: 0x118313C
	private void ScanNmtoken() { }

	// RVA: 0x11832B8
	private bool EatPublicKeyword() { }

	// RVA: 0x11833B8
	private bool EatSystemKeyword() { }

	// RVA: 0x1179F38
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x117E0CC
	private string GetNameString() { }

	// RVA: 0x117E3C0
	private string GetNmtokenString() { }

	// RVA: 0x117E450
	private string GetValue() { }

	// RVA: 0x117E3DC
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x1182E58
	private int ReadData() { }

	// RVA: 0x1179154
	private void LoadParsingBuffer() { }

	// RVA: 0x117A8E4
	private void SaveParsingBuffer() { }

	// RVA: 0x117CE18
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x117F4C8
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x1184B08
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x1182F20
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x11843B8
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x117CC00
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x117DED8
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x1179000
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x117DECC
	private bool IsAttributeValueType(Token token) { }

	// RVA: 0x117D034
	private int get_LineNo() { }

	// RVA: 0x117D0EC
	private int get_LinePos() { }

	// RVA: 0x1178EC8
	private string get_BaseUriStr() { }

	// RVA: 0x1179E9C
	private void OnUnexpectedError() { }

	// RVA: 0x117C8C8
	private void Throw(int curPos, string res) { }

	// RVA: 0x117ECB4
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x117F138
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x117D1A0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x11784D8
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x117F444
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	// RVA: 0x117D02C
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x117EFC0
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x117F51C
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x11848E8
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

	// RVA: 0x1184EB8
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0x1184F8C
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0x118507C
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0x11851E4
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0x118529C
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0x11853D4
	internal static int ParseNCName(string s) { }

	// RVA: 0x118545C
	internal static int ParseQName(string s, int offset, int colonOffset) { }

	// RVA: 0x118557C
	internal static void ParseQNameThrow(string s, string prefix, string localName) { }

	// RVA: 0x11856FC
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x1185BF8
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x1185EBC
	internal static void SplitQName(string name, string prefix, string lname) { }

	// RVA: 0x11862C8
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

	// RVA: 0x1186398
	private static object get_StaticLock() { }

	// RVA: 0x118644C
	private static void InitInstance() { }

	// RVA: 0x1186764
	private static void SetProperties(Byte[] chProps, string ranges, Byte value) { }

	// RVA: 0x11868F0
	private void .ctor(Byte[] charProperties) { }

	// RVA: 0x1185A30
	public static XmlCharType get_Instance() { }

	// RVA: 0x11868F8
	public bool IsWhiteSpace(Char ch) { }

	// RVA: 0x11859F8
	public bool IsNCNameSingleChar(Char ch) { }

	// RVA: 0x1185AB4
	public bool IsStartNCNameSingleChar(Char ch) { }

	// RVA: 0x1186930
	public bool IsNameSingleChar(Char ch) { }

	// RVA: 0x1186970
	public bool IsCharData(Char ch) { }

	// RVA: 0x11869A8
	public bool IsPubidChar(Char ch) { }

	// RVA: 0x1186A28
	internal bool IsTextChar(Char ch) { }

	// RVA: 0x1186A60
	public bool IsLetter(Char ch) { }

	// RVA: 0x1186A98
	public bool IsNCNameCharXml4e(Char ch) { }

	// RVA: 0x1186AD0
	public bool IsStartNCNameCharXml4e(Char ch) { }

	// RVA: 0x1186B10
	public bool IsNameCharXml4e(Char ch) { }

	// RVA: 0x1186B50
	public static bool IsDigit(Char ch) { }

	// RVA: 0x1186B74
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0x1186B84
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0x1186B94
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0x1186BA4
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0x1186BBC
	internal static void SplitSurrogateChar(int combinedChar, Char lowChar, Char highChar) { }

	// RVA: 0x1186BF4
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x1186C90
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x1186D1C
	internal int IsOnlyCharData(string str) { }

	// RVA: 0x1186E20
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x1186EDC
	internal int IsPublicId(string str) { }

	// RVA: 0x1186B60
	private static bool InRange(int value, int start, int end) { }

}

// Namespace: System.Xml
internal static class XmlComplianceUtil
{
	// Methods

	// RVA: 0x1186F98
	public static string NonCDataNormalize(string value) { }

	// RVA: 0x11872C4
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

	// RVA: 0x11874B0
	public static string EncodeName(string name) { }

	// RVA: 0x1187FC0
	public static string EncodeLocalName(string name) { }

	// RVA: 0x1188028
	public static string DecodeName(string name) { }

	// RVA: 0x1187518
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0x1188A60
	private static int FromHex(Char digit) { }

	// RVA: 0x1188A88
	internal static Byte[] FromBinHexString(string s) { }

	// RVA: 0x1188B10
	internal static Byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0x1188B88
	internal static string ToBinHexString(Byte[] inArray) { }

	// RVA: 0x1188BF8
	public static string VerifyName(string name) { }

	// RVA: 0x1188E88
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0x11890B4
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0x1189330
	public static string VerifyNCName(string name) { }

	// RVA: 0x11893B8
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0x1189528
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0x1189648
	public static string VerifyTOKEN(string token) { }

	// RVA: 0x1189778
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0x11898B4
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0x1189AB4
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0x1189BA8
	public static string ToString(bool value) { }

	// RVA: 0x1189C14
	public static string ToString(Char value) { }

	// RVA: 0x1189C80
	public static string ToString(Decimal value) { }

	// RVA: 0x1189D28
	public static string ToString(SByte value) { }

	// RVA: 0x1189D60
	public static string ToString(Int16 value) { }

	// RVA: 0x1189D98
	public static string ToString(int value) { }

	// RVA: 0x1189DD0
	public static string ToString(Int64 value) { }

	// RVA: 0x1189E08
	public static string ToString(Byte value) { }

	// RVA: 0x1189E40
	public static string ToString(UInt16 value) { }

	// RVA: 0x1189E78
	public static string ToString(UInt32 value) { }

	// RVA: 0x1189EB0
	public static string ToString(UInt64 value) { }

	// RVA: 0x1189EE8
	public static string ToString(float value) { }

	// RVA: 0x118A134
	public static string ToString(Double value) { }

	// RVA: 0x118A2E0
	public static string ToString(TimeSpan value) { }

	// RVA: 0x118A330
	public static string ToString(DateTime value, string format) { }

	// RVA: 0x118A40C
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x118A86C
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x118A8F8
	public static string ToString(Guid value) { }

	// RVA: 0x118A920
	public static bool ToBoolean(string s) { }

	// RVA: 0x118AC0C
	internal static Exception TryToBoolean(string s, bool result) { }

	// RVA: 0x118AED0
	public static Char ToChar(string s) { }

	// RVA: 0x118AF90
	internal static Exception TryToChar(string s, Char result) { }

	// RVA: 0x118B14C
	public static Decimal ToDecimal(string s) { }

	// RVA: 0x118B1C4
	internal static Exception TryToDecimal(string s, Decimal result) { }

	// RVA: 0x118B35C
	internal static Decimal ToInteger(string s) { }

	// RVA: 0x118B3D4
	internal static Exception TryToInteger(string s, Decimal result) { }

	// RVA: 0x118B56C
	public static SByte ToSByte(string s) { }

	// RVA: 0x118B5A0
	internal static Exception TryToSByte(string s, SByte result) { }

	// RVA: 0x118B710
	public static Int16 ToInt16(string s) { }

	// RVA: 0x118B744
	internal static Exception TryToInt16(string s, Int16 result) { }

	// RVA: 0x118B8B4
	public static int ToInt32(string s) { }

	// RVA: 0x118B8E8
	internal static Exception TryToInt32(string s, int result) { }

	// RVA: 0x118BA58
	public static Int64 ToInt64(string s) { }

	// RVA: 0x118BA8C
	internal static Exception TryToInt64(string s, Int64 result) { }

	// RVA: 0x118BBFC
	public static Byte ToByte(string s) { }

	// RVA: 0x118BC30
	internal static Exception TryToByte(string s, Byte result) { }

	// RVA: 0x118BDA0
	public static UInt16 ToUInt16(string s) { }

	// RVA: 0x118BDD4
	internal static Exception TryToUInt16(string s, UInt16 result) { }

	// RVA: 0x118BF44
	public static UInt32 ToUInt32(string s) { }

	// RVA: 0x118BF78
	internal static Exception TryToUInt32(string s, UInt32 result) { }

	// RVA: 0x118C0E8
	public static UInt64 ToUInt64(string s) { }

	// RVA: 0x118C11C
	internal static Exception TryToUInt64(string s, UInt64 result) { }

	// RVA: 0x118C28C
	public static float ToSingle(string s) { }

	// RVA: 0x118C448
	internal static Exception TryToSingle(string s, float result) { }

	// RVA: 0x118C71C
	public static Double ToDouble(string s) { }

	// RVA: 0x118C8AC
	internal static Exception TryToDouble(string s, Double result) { }

	// RVA: 0x118CB80
	internal static Double ToXPathDouble(object o) { }

	// RVA: 0x118CE98
	internal static Double XPathRound(Double value) { }

	// RVA: 0x118CFA0
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0x118D13C
	internal static Exception TryToTimeSpan(string s, TimeSpan result) { }

	// RVA: 0x118D200
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0x118D2DC
	private static void CreateAllDateTimeFormats() { }

	// RVA: 0x118D8A0
	public static DateTime ToDateTime(string s) { }

	// RVA: 0x118D9B0
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0x118DA84
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x118DCE8
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0x118DDB4
	public static Guid ToGuid(string s) { }

	// RVA: 0x118DDE4
	internal static Exception TryToGuid(string s, Guid result) { }

	// RVA: 0x118A654
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x118A760
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x118DFBC
	internal static Uri ToUri(string s) { }

	// RVA: 0x118E1F4
	internal static Exception TryToUri(string s, Uri result) { }

	// RVA: 0x118E49C
	internal static bool StrEqual(Char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0x118AB84
	internal static string TrimString(string value) { }

	// RVA: 0x118E578
	internal static string TrimStringStart(string value) { }

	// RVA: 0x118E600
	internal static string TrimStringEnd(string value) { }

	// RVA: 0x118E688
	internal static string[] SplitString(string value) { }

	// RVA: 0x118A098
	internal static bool IsNegativeZero(Double value) { }

	// RVA: 0x118E714
	private static Int64 DoubleToInt64Bits(Double value) { }

	// RVA: 0x118E71C
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0x118E928
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x118ED94
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x118EEE4
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0x11891F4
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x118F008
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi) { }

	// RVA: 0x118F0D4
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType) { }

	// RVA: 0x118EA14
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x118F154
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi) { }

	// RVA: 0x118F218
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType) { }

	// RVA: 0x118F288
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x118EBA4
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0x118F390
	internal static Exception CreateInvalidCharException(Char invChar, Char nextChar) { }

	// RVA: 0x118F3FC
	internal static Exception CreateInvalidCharException(Char invChar, Char nextChar, ExceptionType exceptionType) { }

	// RVA: 0x1188D60
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0x118F4F4
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0x118F5C0
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Uri uri; // 0x10

	// Methods

	// RVA: 0x11902D4
	public void .ctor() { }

	// RVA: 0x1190468
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

	// RVA: 0x11904F4
	private void MoveNext() { }

	// RVA: 0x1190DAC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Xml
internal class XmlDownloadManager
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x118F744
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x118F844
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x118FFC4
	internal void Remove(string host) { }

	// RVA: 0x1190154
	internal System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11902DC
	private System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x1190460
	public void .ctor() { }

}

// Namespace: System.Xml
internal class OpenedHost
{
	// Fields
	internal int nonCachedConnectionsCount; // 0x10

	// Methods

	// RVA: 0x118FD98
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

	// RVA: 0x118FDA0
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0x1190E2C
	protected override void Finalize() { }

	// RVA: 0x1190EDC
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1191028
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1191050
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1191078
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x11910A0
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x11910C8
	public override void Flush() { }

	// RVA: 0x11910F0
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1191118
	public override int ReadByte() { }

	// RVA: 0x1191140
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1191168
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1191190
	public override void WriteByte(Byte value) { }

	// RVA: 0x11911B8
	public override bool get_CanRead() { }

	// RVA: 0x11911DC
	public override bool get_CanSeek() { }

	// RVA: 0x1191200
	public override bool get_CanWrite() { }

	// RVA: 0x1191224
	public override Int64 get_Length() { }

	// RVA: 0x1191248
	public override Int64 get_Position() { }

	// RVA: 0x119126C
	public override void set_Position(Int64 value) { }

}

// Namespace: System.Xml
internal class XmlCachedStream
{
	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0x118FE48
	internal void .ctor(Uri uri, Stream stream) { }

}

// Namespace: System.Xml
internal class UTF16Decoder
{
	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0x1191294
	public void .ctor(bool bigEndian) { }

	// RVA: 0x11912C8
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x11912D8
	public override int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x11913C8
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x1191558
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

}

// Namespace: System.Xml
internal class SafeAsciiDecoder
{
	// Methods

	// RVA: 0x119174C
	public void .ctor() { }

	// RVA: 0x1191754
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x119175C
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11917DC
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

}

// Namespace: System.Xml
internal class Ucs4Encoding
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Methods

	// RVA: 0x1191878
	public override string get_WebName() { }

	// RVA: 0x1191884
	public override Decoder GetDecoder() { }

	// RVA: 0x119188C
	public override int GetByteCount(Char[] chars, int index, int count) { }

	// RVA: 0x11918F4
	public override Byte[] GetBytes(string s) { }

	// RVA: 0x11918FC
	public override int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	// RVA: 0x1191904
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x119190C
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x1191930
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x1191954
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x119196C
	public override int get_CodePage() { }

	// RVA: 0x1191974
	public override Encoder GetEncoder() { }

	// RVA: 0x119197C
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0x1191A90
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0x1191BA4
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0x1191CB8
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0x1191DCC
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding1234
{
	// Methods

	// RVA: 0x1191AE4
	public void .ctor() { }

	// RVA: 0x1191E44
	public override string get_EncodingName() { }

	// RVA: 0x1191E88
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding4321
{
	// Methods

	// RVA: 0x11919D0
	public void .ctor() { }

	// RVA: 0x1191F74
	public override string get_EncodingName() { }

	// RVA: 0x1191FB8
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding2143
{
	// Methods

	// RVA: 0x1191BF8
	public void .ctor() { }

	// RVA: 0x11920A0
	public override string get_EncodingName() { }

	// RVA: 0x11920E4
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding3412
{
	// Methods

	// RVA: 0x1191D0C
	public void .ctor() { }

	// RVA: 0x11921D0
	public override string get_EncodingName() { }

	// RVA: 0x1192214
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal abstract class Ucs4Decoder
{
	// Fields
	internal Byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0x119228C
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: -1
	internal abstract int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11922A8
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11924B0
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

	// RVA: 0x11927DC
	internal void Ucs4ToUTF16(UInt32 code, Char[] chars, int charIndex) { }

	// RVA: 0x1192838
	protected void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder4321
{
	// Methods

	// RVA: 0x11928A8
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x1191F04
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder1234
{
	// Methods

	// RVA: 0x1192B60
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x1191DD4
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder2143
{
	// Methods

	// RVA: 0x1192E18
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x1192030
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder3412
{
	// Methods

	// RVA: 0x11930D0
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x1192160
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

	// RVA: 0x1193388
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1193A64
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1193BD8
	public void .ctor() { }

	// RVA: 0x1193BF0
	public void .ctor(string message) { }

	// RVA: 0x1193C0C
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1193C04
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1193C1C
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1185B64
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x1185900
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1193F10
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x119400C
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x1194278
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x11940B4
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x118EC8C
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x1194280
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x118EF64
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x119438C
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1194434
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1193E5C
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1193D5C
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x11937E8
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x1185AEC
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x11944DC
	internal static string[] BuildCharExceptionArgs(Char[] data, int length, int invCharIndex) { }

	// RVA: 0x1186038
	internal static string[] BuildCharExceptionArgs(Char invChar, Char nextChar) { }

	// RVA: 0x1194538
	public int get_LineNumber() { }

	// RVA: 0x1194540
	public int get_LinePosition() { }

	// RVA: 0x1194548
	public override string get_Message() { }

	// RVA: 0x1194560
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

	// RVA: 0x1194568
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

	// RVA: 0x11947EC
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

	// RVA: 0x1194570
	internal void .ctor() { }

	// RVA: 0x1194578
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1194838
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x1194840
	public virtual string get_DefaultNamespace() { }

	// RVA: 0x11948CC
	public virtual void PushScope() { }

	// RVA: 0x11948DC
	public virtual bool PopScope() { }

	// RVA: 0x11949D8
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x1194FB0
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x11950FC
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11952C0
	public virtual System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11955A8
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x1194DD0
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x1195608
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

	// RVA: 0x11960D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x119673C
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

	// RVA: 0x11956F8
	public void .ctor() { }

	// RVA: 0x11958B8
	public void .ctor(string name) { }

	// RVA: 0x11957F8
	public void .ctor(string name, string ns) { }

	// RVA: 0x11959B8
	public string get_Namespace() { }

	// RVA: 0x11959C0
	public string get_Name() { }

	// RVA: 0x11959C8
	public override int GetHashCode() { }

	// RVA: 0x1195D1C
	public bool get_IsEmpty() { }

	// RVA: 0x1195D60
	public override string ToString() { }

	// RVA: 0x1195DD4
	public override bool Equals(object other) { }

	// RVA: 0x1195FE4
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x1195F0C
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x1196048
	public static string ToString(string name, string ns) { }

	// RVA: 0x1195AD4
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x11960C8
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0x119618C
	private static int GetHashCodeOfString(string s, int length, Int64 additionalEntropy) { }

	// RVA: 0x11961AC
	internal void Init(string name, string ns) { }

	// RVA: 0x11961E8
	internal void SetNamespace(string ns) { }

	// RVA: 0x11961F0
	internal void Verify() { }

	// RVA: 0x1196314
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0x119638C
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, string prefix) { }

	// RVA: 0x1196610
	internal XmlQualifiedName Clone() { }

	// RVA: 0x1196694
	private static void .cctor() { }

}

// Namespace: System.Xml
public abstract class XmlResolver
{
	// Methods

	// RVA: -1
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x1196750
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x119694C
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0x1196AC8
	public virtual System.Threading.Tasks.Task<System.Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x1196B08
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

	// RVA: 0x1196EF4
	private void MoveNext() { }

	// RVA: 0x1197310
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

	// RVA: 0x1196B10
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x1196BE8
	public void .ctor() { }

	// RVA: 0x1196BF0
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x1196D98
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x1196D9C
	public override System.Threading.Tasks.Task<System.Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

}

// Namespace: System.Xml
internal static class BinaryCompatibility
{
	// Methods

	// RVA: 0x1197390
	public static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

}

// Namespace: System.Xml
internal static class Res
{
	// Methods

	// RVA: 0x1188D5C
	public static string GetString(string name) { }

	// RVA: 0x11862B8
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

	// RVA: 0x1197398
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x11973A0
	internal bool get_HasLineInfo() { }

	// RVA: 0x11973A8
	internal int GetCollapsedTextNode(XPathNode[] pageText) { }

	// RVA: 0x11973DC
	internal int GetRootNode(XPathNode[] pageRoot) { }

	// RVA: 0x1197410
	internal int GetXmlNamespaceNode(XPathNode[] pageXmlNmsp) { }

	// RVA: 0x1197444
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x1197564
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

	// RVA: 0x119764C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1197A5C
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1197B50
	public void .ctor() { }

	// RVA: 0x1197BB0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1197D18
	internal static XPathException Create(string res) { }

	// RVA: 0x1197E34
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0x1197F28
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0x1198048
	internal static XPathException Create(string res, string arg, Exception innerException) { }

	// RVA: 0x1197DC0
	private void .ctor(string res, string[] args) { }

	// RVA: 0x1197CA0
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0x1197918
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0x1198148
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

	// RVA: 0x1198160
	internal void .ctor() { }

	// RVA: -1
	public abstract void SetContext(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1198168
	public static XPathExpression Compile(string xpath) { }

	// RVA: 0x1198170
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

	// RVA: 0x1198260
	public virtual object ValueAs(Type returnType) { }

	// RVA: -1
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1198274
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

	// RVA: 0x119827C
	public override string ToString() { }

	// RVA: 0x1198288
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x1198448
	public override object get_TypedValue() { }

	// RVA: 0x1198750
	public override Type get_ValueType() { }

	// RVA: 0x119898C
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x1198C7C
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x1198F74
	public override Double get_ValueAsDouble() { }

	// RVA: 0x119926C
	public override int get_ValueAsInt() { }

	// RVA: 0x1199564
	public override Int64 get_ValueAsLong() { }

	// RVA: 0x119985C
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1199B64
	private object System.ICloneable.Clone() { }

	// RVA: 0x1199B74
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: 0x1199B84
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x1199D6C
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0x1199FB0
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

	// RVA: 0x119A2E4
	public virtual string get_XmlLang() { }

	// RVA: 0x119A3D4
	public virtual object get_UnderlyingObject() { }

	// RVA: 0x119A3DC
	public virtual bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: -1
	public abstract bool MoveToFirstAttribute() { }

	// RVA: -1
	public abstract bool MoveToNextAttribute() { }

	// RVA: 0x119A4C0
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: -1
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x119A56C
	public bool MoveToFirstNamespace() { }

	// RVA: 0x119A580
	public bool MoveToNextNamespace() { }

	// RVA: -1
	public abstract bool MoveToNext() { }

	// RVA: -1
	public abstract bool MoveToFirstChild() { }

	// RVA: -1
	public abstract bool MoveToParent() { }

	// RVA: 0x119A594
	public virtual void MoveToRoot() { }

	// RVA: -1
	public abstract bool MoveTo(XPathNavigator other) { }

	// RVA: -1
	public abstract bool MoveToId(string id) { }

	// RVA: 0x119A5C8
	public virtual bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x119A6C8
	public virtual bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x119A8C0
	public virtual bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x119ABAC
	public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x119AE54
	public virtual bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x119AF60
	public virtual bool MoveToNext(XPathNodeType type) { }

	// RVA: -1
	public abstract bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x119B0C8
	public virtual bool IsDescendant(XPathNavigator nav) { }

	// RVA: 0x119B168
	public virtual XmlNodeOrder ComparePosition(XPathNavigator nav) { }

	// RVA: 0x119B66C
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x119B6C0
	public virtual XPathNodeIterator Select(string xpath) { }

	// RVA: 0x119B6FC
	public virtual XPathNodeIterator Select(XPathExpression expr) { }

	// RVA: 0x119B7C0
	public virtual object Evaluate(XPathExpression expr) { }

	// RVA: 0x119B7D4
	public virtual object Evaluate(XPathExpression expr, XPathNodeIterator context) { }

	// RVA: 0x119B9BC
	public virtual XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x119BA44
	public virtual XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x119BADC
	public virtual XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x119BB74
	public virtual XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x119AA98
	internal bool MoveToNonDescendant() { }

	// RVA: 0x119B4A8
	private static int GetDepth(XPathNavigator nav) { }

	// RVA: 0x119B4F0
	private XmlNodeOrder CompareSiblings(XPathNavigator n1, XPathNavigator n2) { }

	// RVA: 0x119A820
	internal static int GetContentKindMask(XPathNodeType type) { }

	// RVA: 0x119BC14
	internal static int GetKindMask(XPathNodeType type) { }

	// RVA: 0x119BC38
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x119BC48
	protected void .ctor() { }

	// RVA: 0x119BC50
	private static void .cctor() { }

}

// Namespace: System.Xml.XPath
internal class XPathNavigatorKeyComparer
{
	// Methods

	// RVA: 0x119BDE4
	private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0x119BED0
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x119BDDC
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

	// RVA: 0x119C1BC
	public void .ctor(XPathNodeIterator original) { }

	// RVA: 0x119C218
	public virtual object get_Current() { }

	// RVA: 0x119C35C
	public virtual bool MoveNext() { }

	// RVA: 0x119C3FC
	public virtual void Reset() { }

}

// Namespace: System.Xml.XPath
public abstract class XPathNodeIterator
{
	// Fields
	internal int count; // 0x10

	// Methods

	// RVA: 0x119C0AC
	private object System.ICloneable.Clone() { }

	// RVA: -1
	public abstract XPathNodeIterator Clone() { }

	// RVA: -1
	public abstract bool MoveNext() { }

	// RVA: -1
	public abstract XPathNavigator get_Current() { }

	// RVA: -1
	public abstract int get_CurrentPosition() { }

	// RVA: 0x119C0B8
	public virtual int get_Count() { }

	// RVA: 0x119C130
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x119C208
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

	// RVA: 0x119C404
	public static string MakePascal(string identifier) { }

	// RVA: 0x119C618
	public static string MakeValid(string identifier) { }

	// RVA: 0x119C8B0
	private static bool IsValidStart(Char c) { }

	// RVA: 0x119C830
	private static bool IsValid(Char c) { }

	// RVA: 0x119C920
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlSerializerNamespaces
{
	// Fields
	private Hashtable namespaces; // 0x10

	// Methods

	// RVA: 0x119C9A8
	public void .ctor() { }

	// RVA: 0x119C9B0
	public void Add(string prefix, string ns) { }

	// RVA: 0x119CB28
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0x119CC50
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0x119D270
	public int get_Count() { }

	// RVA: 0x119CD58
	internal ArrayList get_NamespaceList() { }

	// RVA: 0x119CBC8
	internal Hashtable get_Namespaces() { }

	// RVA: 0x119D2F8
	internal void set_Namespaces(Hashtable value) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlAttributeEventHandler
{
	// Methods

	// RVA: 0x119D300
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x119D424
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

	// RVA: 0x119D438
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlElementEventHandler
{
	// Methods

	// RVA: 0x119D4F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x119D61C
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

	// RVA: 0x119D630
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlNodeEventHandler
{
	// Methods

	// RVA: 0x119D6F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x119D814
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

	// RVA: 0x119D828
	internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

// Namespace: System.Xml.Serialization
public sealed class UnreferencedObjectEventHandler
{
	// Methods

	// RVA: 0x119D8D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x119D9F8
	public virtual void Invoke(object sender, UnreferencedObjectEventArgs e) { }

}

// Namespace: System.Xml.Serialization
public class UnreferencedObjectEventArgs
{
	// Fields
	private object o; // 0x10
	private string id; // 0x18

	// Methods

	// RVA: 0x119DA0C
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

	// RVA: 0x119DAA0
	public static void AddField(StringBuilder sb, int n, string val) { }

	// RVA: 0x119DAA8
	public static void AddField(StringBuilder sb, int n, string val, string def) { }

	// RVA: 0x119DB94
	public static void AddField(StringBuilder sb, int n, bool val) { }

	// RVA: 0x119DBE4
	public static void AddField(StringBuilder sb, int n, bool val, bool def) { }

	// RVA: 0x119DC38
	public static void AddField(StringBuilder sb, int n, int val, int def) { }

	// RVA: 0x119DCFC
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

	// RVA: 0x119DE28
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x119DEF4
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x119DFE0
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x119E144
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x119E2BC
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x119E68C
	public void .ctor() { }

	// RVA: 0x119E728
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

	// RVA: 0x119E7A8
	public void .ctor(string namspace, Type[] includedTypes) { }

	// RVA: 0x119E800
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

	// RVA: 0x119E8F4
	public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0x119EA40
	public override bool Equals(object o) { }

	// RVA: 0x119EB28
	public override int GetHashCode() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeConvertorAttribute
{
	// Fields
	private string <Method>k__BackingField; // 0x10

	// Methods

	// RVA: 0x119EB4C
	public string get_Method() { }

	// RVA: 0x119EB54
	private void set_Method(string value) { }

	// RVA: 0x119EB5C
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

	// RVA: 0x119EB90
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x119EB9C
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x119F214
	private void LookupTypeConvertor() { }

	// RVA: 0x119F2D8
	internal void ConvertForAssignment(object value) { }

	// RVA: 0x119F3D0
	public string get_TypeName() { }

	// RVA: 0x119F3D8
	public string get_XmlType() { }

	// RVA: 0x119F3E0
	public Type get_Type() { }

	// RVA: 0x119F3E8
	public string get_FullTypeName() { }

	// RVA: 0x119F3F0
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x119E67C
	public bool get_IsListType() { }

	// RVA: 0x119F3F8
	public bool get_IsComplexType() { }

	// RVA: 0x119F430
	public bool get_IsValueType() { }

	// RVA: 0x119F4F8
	public bool get_IsNullable() { }

	// RVA: 0x119F6A0
	public void set_IsNullable(bool value) { }

	// RVA: 0x119EFB4
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x119F6A8
	public Type get_ListItemType() { }

	// RVA: 0x119F420
	public bool get_IsXsdType() { }

	// RVA: 0x11A031C
	public bool get_HasPublicConstructor() { }

	// RVA: 0x11A00A8
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x11A01EC
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x119FE7C
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x11A0324
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
internal sealed class TypeMember
{
	// Fields
	private Type type; // 0x10
	private string member; // 0x18

	// Methods

	// RVA: 0x11A1318
	internal void .ctor(Type type, string member) { }

	// RVA: 0x11A1368
	public override int GetHashCode() { }

	// RVA: 0x11A13B8
	public override bool Equals(object obj) { }

	// RVA: 0x11A14A8
	public static bool Equals(TypeMember tm1, TypeMember tm2) { }

	// RVA: 0x11A1590
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

	// RVA: 0x11A15F8
	private static void .cctor() { }

	// RVA: 0x119E614
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x11A3960
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType) { }

	// RVA: 0x11A453C
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x11A45C4
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x11A47F8
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x119F100
	public static string GetArrayName(string elemName) { }

	// RVA: 0x11A48DC
	public static void ParseArrayType(string arrayType, string type, string ns, string dimensions) { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyAttributeAttribute
{
	// Methods

	// RVA: 0x11A4A78
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

	// RVA: 0x11A4A80
	public void .ctor() { }

	// RVA: 0x11A4A90
	public string get_Name() { }

	// RVA: 0x11A4AFC
	public string get_Namespace() { }

	// RVA: 0x11A4B04
	public int get_Order() { }

	// RVA: 0x11A4B0C
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyElementAttributes
{
	// Methods

	// RVA: 0x11A4BA8
	public XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x11A4CC8
	public int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x11A4D8C
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11A4E68
	internal int get_Order() { }

	// RVA: 0x11A5134
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

	// RVA: 0x11A513C
	public string get_ElementName() { }

	// RVA: 0x11A51A8
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11A51B0
	public bool get_IsNullable() { }

	// RVA: 0x11A51B8
	public string get_Namespace() { }

	// RVA: 0x11A51C0
	public int get_Order() { }

	// RVA: 0x11A51C8
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

	// RVA: 0x11A52F4
	public string get_DataType() { }

	// RVA: 0x11A5360
	public string get_ElementName() { }

	// RVA: 0x11A53CC
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11A53D4
	public string get_Namespace() { }

	// RVA: 0x11A53DC
	public bool get_IsNullable() { }

	// RVA: 0x11A53E4
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x11A53EC
	public Type get_Type() { }

	// RVA: 0x11A53F4
	public int get_NestingLevel() { }

	// RVA: 0x11A53FC
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlArrayItemAttributes
{
	// Methods

	// RVA: 0x11A556C
	public XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x11A568C
	public int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x11A5750
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11A582C
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

	// RVA: 0x11A5834
	public void .ctor(string attributeName) { }

	// RVA: 0x11A5868
	public string get_AttributeName() { }

	// RVA: 0x11A58D4
	public string get_DataType() { }

	// RVA: 0x11A5940
	public void set_DataType(string value) { }

	// RVA: 0x11A5948
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11A5950
	public string get_Namespace() { }

	// RVA: 0x11A5958
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlAttributeOverrides
{
	// Fields
	private Hashtable overrides; // 0x10

	// Methods

	// RVA: 0x11A5A98
	public void .ctor() { }

	// RVA: 0x11A5B10
	public XmlAttributes get_Item(Type type) { }

	// RVA: 0x11A5B74
	public XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x11A5C6C
	private TypeMember GetKey(Type type, string member) { }

	// RVA: 0x11A5CDC
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

	// RVA: 0x11A64E0
	public void .ctor() { }

	// RVA: 0x11A6614
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x11A7068
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x11A7070
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x11A7078
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x11A7080
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x11A7088
	public XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x11A7090
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x11A7098
	public object get_XmlDefaultValue() { }

	// RVA: 0x11A70A0
	public XmlElementAttributes get_XmlElements() { }

	// RVA: 0x11A70A8
	public bool get_XmlIgnore() { }

	// RVA: 0x11A70B0
	public bool get_Xmlns() { }

	// RVA: 0x11A70B8
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x11A70C0
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x11A70C8
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x11A61CC
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11A80B0
	internal System.Nullable<System.Int32> get_Order() { }

	// RVA: 0x11A844C
	internal int get_SortableOrder() { }

}

// Namespace: System.Xml.Serialization
public class XmlChoiceIdentifierAttribute
{
	// Fields
	private string memberName; // 0x10

	// Methods

	// RVA: 0x11A8528
	public string get_MemberName() { }

	// RVA: 0x11A8028
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
internal class XmlCustomFormatter
{
	// Fields
	private static string[] allTimeFormats; // 0x0

	// Methods

	// RVA: 0x11A8594
	internal static string FromEnum(Int64 value, string[] values, Int64[] ids, string typeName) { }

	// RVA: 0x11A8904
	internal static string FromXmlName(string name) { }

	// RVA: 0x11A898C
	internal static string FromXmlNCName(string ncName) { }

	// RVA: 0x11A71AC
	internal static string ToXmlString(TypeData type, object value) { }

	// RVA: 0x11A8A14
	internal static object FromXmlString(TypeData type, string value) { }

	// RVA: 0x11A95B8
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

	// RVA: 0x11A9B18
	public void .ctor(string elementName) { }

	// RVA: 0x11A9B54
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x11A9BAC
	public string get_DataType() { }

	// RVA: 0x11A9C18
	public string get_ElementName() { }

	// RVA: 0x11A9C84
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11A9C8C
	public string get_Namespace() { }

	// RVA: 0x11A9C94
	public bool get_IsNullable() { }

	// RVA: 0x11A9C9C
	public int get_Order() { }

	// RVA: 0x11A9CA4
	public Type get_Type() { }

	// RVA: 0x11A9CAC
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlElementAttributes
{
	// Methods

	// RVA: 0x11A9E00
	public XmlElementAttribute get_Item(int index) { }

	// RVA: 0x11A6FA4
	public int Add(XmlElementAttribute attribute) { }

	// RVA: 0x11A70D0
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x11A8180
	internal int get_Order() { }

	// RVA: 0x11A660C
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlEnumAttribute
{
	// Fields
	private string name; // 0x10

	// Methods

	// RVA: 0x11A9F20
	public void .ctor(string name) { }

	// RVA: 0x11A9F54
	public string get_Name() { }

	// RVA: 0x11A7EDC
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlIgnoreAttribute
{
	// Methods

	// RVA: 0x11A9F5C
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlIncludeAttribute
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0x11A9F64
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

	// RVA: 0x11A9F6C
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x11A9FBC
	public string get_ElementName() { }

	// RVA: 0x11A9FC4
	public string get_Namespace() { }

	// RVA: 0x11A9FCC
	public void SetKey(string key) { }

	// RVA: 0x11A9FD4
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x11A9FDC
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x11A9FE4
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x11A9FEC
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x11A9FF4
	internal SerializationFormat get_Format() { }

	// RVA: 0x11A9FFC
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x11AA004
	internal SerializationSource get_Source() { }

}

// Namespace: System.Xml.Serialization
internal class ObjectMap
{
	// Methods

	// RVA: 0x11AA00C
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

	// RVA: 0x11AA014
	public int get_Count() { }

	// RVA: 0x11AA034
	internal bool get_HasWrapperElement() { }

}

// Namespace: System.Xml.Serialization
public class XmlNamespaceDeclarationsAttribute
{
	// Methods

	// RVA: 0x11AA03C
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

	// RVA: 0x11B1DE8
	private static void .cctor() { }

	// RVA: 0x11B1E54
	public void .ctor() { }

	// RVA: 0x11B1E5C
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

	// RVA: 0x11AA044
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x11AA1E0
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x11AA3EC
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x11AA1EC
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11AA3F8
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11AD59C
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x11ADB2C
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType) { }

	// RVA: 0x11AA89C
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType) { }

	// RVA: 0x11AF8B0
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x11ADBC8
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11AFB84
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x11ABD1C
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x11ACBB8
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11ACDB4
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11ACE84
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11AD46C
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11AFA30
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x11ADD3C
	private System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x11AED30
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x11B02CC
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x11AFC8C
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x11B14E8
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x11ADA70
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x11B1838
	public void IncludeType(Type type) { }

	// RVA: 0x11B12FC
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x11B1D48
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

	// RVA: 0x11AFC28
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x11B1F4C
	public bool get_IsReturnValue() { }

	// RVA: 0x11B1F54
	public string get_MemberName() { }

	// RVA: 0x11B1F5C
	public Type get_MemberType() { }

	// RVA: 0x11AECAC
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x11B1F64
	internal Type get_DeclaringType() { }

	// RVA: 0x11B1F6C
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

	// RVA: 0x11B1F74
	public void .ctor() { }

	// RVA: 0x11B1F84
	public void .ctor(string elementName) { }

	// RVA: 0x11B1FC0
	public string get_DataType() { }

	// RVA: 0x11B202C
	public void set_DataType(string value) { }

	// RVA: 0x11ADAC0
	public string get_ElementName() { }

	// RVA: 0x11B2034
	public void set_ElementName(string value) { }

	// RVA: 0x11B203C
	public bool get_IsNullable() { }

	// RVA: 0x11B2044
	public void set_IsNullable(bool value) { }

	// RVA: 0x11B204C
	public string get_Namespace() { }

	// RVA: 0x11B2054
	public void set_Namespace(string value) { }

	// RVA: 0x11A7F64
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSchemaProviderAttribute
{
	// Fields
	private string _methodName; // 0x10
	private bool _isAny; // 0x18

	// Methods

	// RVA: 0x11B205C
	public void .ctor(string methodName) { }

	// RVA: 0x11B2090
	public string get_MethodName() { }

	// RVA: 0x11B2098
	public bool get_IsAny() { }

	// RVA: 0x11B20A0
	public void set_IsAny(bool value) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationCollectionFixupCallback
{
	// Methods

	// RVA: 0x11B20A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11B21CC
	public virtual void Invoke(object collection, object collectionItems) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationFixupCallback
{
	// Methods

	// RVA: 0x11B21E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11B2300
	public virtual void Invoke(object fixup) { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationGeneratedCode
{
	// Methods

	// RVA: 0x11B2314
	protected void .ctor() { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationReadCallback
{
	// Methods

	// RVA: 0x11B231C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11B23BC
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

	// RVA: 0x11B2D60
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

	// RVA: 0x11B7250
	internal void .ctor(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

	// RVA: 0x11B72B4
	public XmlSerializationCollectionFixupCallback get_Callback() { }

	// RVA: 0x11B72BC
	public object get_Collection() { }

	// RVA: 0x11B72C4
	internal object get_Id() { }

	// RVA: 0x11B72CC
	public object get_CollectionItems() { }

	// RVA: 0x11B72D4
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

	// RVA: 0x11B72DC
	public void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	// RVA: 0x11B7380
	public XmlSerializationFixupCallback get_Callback() { }

	// RVA: 0x11B7388
	public string[] get_Ids() { }

	// RVA: 0x11B7390
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

	// RVA: 0x11B5458
	public void .ctor(Array list, int index, string id) { }

	// RVA: 0x11B7398
	public Array get_Collection() { }

	// RVA: 0x11B73A0
	public int get_Index() { }

	// RVA: 0x11B73A8
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

	// RVA: 0x11B23D0
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x11B279C
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x11B2810
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x11B2884
	protected void .ctor() { }

	// RVA: 0x11B288C
	protected XmlDocument get_Document() { }

	// RVA: 0x11B2940
	protected XmlReader get_Reader() { }

	// RVA: 0x11B2948
	protected void AddFixup(CollectionFixup fixup) { }

	// RVA: 0x11B2A8C
	protected void AddFixup(Fixup fixup) { }

	// RVA: 0x11B2B40
	private void AddFixup(CollectionItemFixup fixup) { }

	// RVA: 0x11B2BF4
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x11B2D68
	protected void AddTarget(string id, object o) { }

	// RVA: 0x11B2F08
	private string CurrentTag() { }

	// RVA: 0x11B3094
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x11B3124
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x11B31C4
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x11B3258
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x11B3400
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x11B349C
	protected bool GetNullAttr() { }

	// RVA: 0x11B3564
	protected object GetTarget(string id) { }

	// RVA: 0x11B3644
	private bool TargetReady(string id) { }

	// RVA: 0x11B3660
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1
	protected abstract void InitCallbacks() { }

	// RVA: -1
	protected abstract void InitIDs() { }

	// RVA: 0x11B3860
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x11B3904
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x11B3A84
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x11B3DC0
	protected void ReadEndElement() { }

	// RVA: 0x11B3E88
	protected bool ReadNull() { }

	// RVA: 0x11B3FA4
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x11B3FDC
	protected string ReadNullableString() { }

	// RVA: 0x11B4034
	protected object ReadReferencedElement() { }

	// RVA: 0x11B4390
	private WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x11B408C
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x11B4488
	private bool ReadList(object resultList) { }

	// RVA: 0x11B54B0
	protected void ReadReferencedElements() { }

	// RVA: 0x11B63E8
	protected object ReadReferencingElement(string fixupReference) { }

	// RVA: 0x11B544C
	protected object ReadReferencingElement(string name, string ns, string fixupReference) { }

	// RVA: 0x11B6454
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, string fixupReference) { }

	// RVA: 0x11B6828
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x11B69F0
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x11B4A10
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x11B6C7C
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x11B6D78
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x11B6E94
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x11B3B84
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x11B6F44
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x11B70A8
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x11B3F6C
	protected void UnknownNode(object o) { }

	// RVA: 0x11B720C
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x11B69F8
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x11B6350
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

	// RVA: 0x11BC488
	public void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

	// RVA: 0x11BD6C4
	public void FixupMembers(object fixup) { }

}

// Namespace: 
private class ReaderCallbackInfo
{
	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x11B7810
	public void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

	// RVA: 0x11BD6F0
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

	// RVA: 0x11B73B0
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x11B73F8
	protected override void InitCallbacks() { }

	// RVA: 0x11B7860
	protected override void InitIDs() { }

	// RVA: 0x11B7864
	public object ReadRoot() { }

	// RVA: 0x11B7A4C
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x11B7B9C
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x11B7970
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x11BAD8C
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x11BB66C
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x11BB9AC
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x11B8214
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11B8750
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x11BC190
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11BC840
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x11BCC28
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x11BCC60
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x11BC370
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x11BBBA4
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x11B8148
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x11BBD48
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x11BC59C
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x11BCC98
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x11BBA58
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x11BAEF8
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x11BCDDC
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x11BBE1C
	private void AddListValue(TypeData listType, object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x11BB9A4
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x11B80D8
	private object CreateInstance(Type type) { }

	// RVA: 0x11BC4E4
	private object CreateList(Type listType) { }

	// RVA: 0x11BC3E0
	private object InitializeList(TypeData listType) { }

	// RVA: 0x11BD174
	private void FillList(object list, object items) { }

	// RVA: 0x11BD184
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x11BAD6C
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11BC778
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x11BB340
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11BB430
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11BD020
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x11BB4A0
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11BD5D0
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationWriteCallback
{
	// Methods

	// RVA: 0x11BD724
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11BD844
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

	// RVA: 0x11C13F0
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

	// RVA: 0x11BD858
	protected void .ctor() { }

	// RVA: 0x11BD8D4
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x11BDA0C
	protected XmlWriter get_Writer() { }

	// RVA: 0x11BDA14
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x11BDB38
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x11BDBD8
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x11BDC7C
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x11BDD0C
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x11BDEE8
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x11BE010
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x11BE050
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x11BDE0C
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1
	protected abstract void InitCallbacks() { }

	// RVA: 0x11BE1C8
	protected void TopLevelElement() { }

	// RVA: 0x11BE1D4
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x11BE19C
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x11BE210
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x11BE2BC
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x11BE5BC
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x11BE8C0
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x11BE8C8
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x11BEBD0
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x11BEBD8
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x11BEBAC
	protected void WriteEndElement() { }

	// RVA: 0x11BEDB0
	protected void WriteEndElement(object o) { }

	// RVA: 0x11BEDFC
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x11BF230
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x11BF318
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x11BF3F0
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x11BF3FC
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x11BE4F8
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x11BE7F8
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x11BF40C
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x11BFB18
	protected void WriteReferencedElements() { }

	// RVA: 0x11BFA18
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x11BFD38
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x11C0044
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x11BF980
	private void CheckReferenceQueue() { }

	// RVA: 0x11C0224
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x11C022C
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x11C040C
	protected void WriteStartDocument() { }

	// RVA: 0x11BEA7C
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x11BF970
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x11C046C
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x11C0464
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x11C0478
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x11C0DB4
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x11C1100
	protected void WriteValue(string value) { }

	// RVA: 0x11C1134
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x11BEA8C
	protected void WriteXsiType(string name, string ns) { }

}

// Namespace: 
private class CallbackInfo
{
	// Fields
	private XmlSerializationWriterInterpreter _swi; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x11C184C
	public void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

	// RVA: 0x11C8294
	internal void WriteObject(object ob) { }

	// RVA: 0x11C82E4
	internal void WriteEnum(object ob) { }

}

// Namespace: System.Xml.Serialization
internal class XmlSerializationWriterInterpreter
{
	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x11C13F8
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x11C1440
	protected override void InitCallbacks() { }

	// RVA: 0x11C189C
	public void WriteRoot(object ob) { }

	// RVA: 0x11C1AAC
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x11C26C4
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x11C2908
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11C2B54
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x11C3330
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x11C28C4
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11C2BFC
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11C33D8
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x11C3F5C
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x11C3CE8
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x11C474C
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x11C21CC
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x11C6570
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x11C6904
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x11C6BCC
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11C4D54
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x11C6DC4
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x11C563C
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x11C7DB0
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11C7DF8
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11C4460
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x11C7E34
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

	// RVA: 0x11C93C8
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

	// RVA: 0x11C8334
	private static void .cctor() { }

	// RVA: 0x11C83F4
	public void .ctor(Type type) { }

	// RVA: 0x11C8408
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11C85B4
	internal XmlMapping get_Mapping() { }

	// RVA: 0x11C85BC
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0x11C85E0
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0x11C8604
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0x11C8628
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0x11C864C
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0x11C868C
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0x11C86CC
	public object Deserialize(TextReader textReader) { }

	// RVA: 0x11C8764
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0x11C888C
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0x11C8B84
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0x11C8DA4
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0x11C9178
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0x11C8E40
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0x11C9180
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0x11C8824
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

}

// Namespace: System.Xml.Serialization
public class XmlSerializerFactory
{
	// Fields
	private static Hashtable serializersBySource; // 0x0

	// Methods

	// RVA: 0x11C94D4
	public void .ctor() { }

	// RVA: 0x11C94DC
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0x11C9788
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0x11C94F0
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11C979C
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializerImplementation
{
	// Methods

	// RVA: 0x11C9824
	public virtual XmlSerializationWriter get_Writer() { }

}

// Namespace: System.Xml.Serialization
public class XmlTextAttribute
{
	// Fields
	private string dataType; // 0x10
	private Type type; // 0x18

	// Methods

	// RVA: 0x11C9864
	public void .ctor() { }

	// RVA: 0x11C986C
	public string get_DataType() { }

	// RVA: 0x11C98D8
	public Type get_Type() { }

	// RVA: 0x11C98E0
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

	// RVA: 0x11C997C
	public bool get_IncludeInSchema() { }

	// RVA: 0x11C9984
	public string get_Namespace() { }

	// RVA: 0x11C998C
	public string get_TypeName() { }

	// RVA: 0x11C99F8
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

	// RVA: 0x11C9AA8
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x11C9B80
	public TypeData get_TypeData() { }

	// RVA: 0x11C9B88
	public object get_ChoiceValue() { }

	// RVA: 0x11C9B90
	public void set_ChoiceValue(object value) { }

	// RVA: 0x11C9B98
	public string get_ElementName() { }

	// RVA: 0x11C9BA0
	public void set_ElementName(string value) { }

	// RVA: 0x11C9BA8
	public string get_Namespace() { }

	// RVA: 0x11C9BB0
	public void set_Namespace(string value) { }

	// RVA: 0x11C6858
	public string get_DataTypeNamespace() { }

	// RVA: 0x11C6824
	public string get_DataTypeName() { }

	// RVA: 0x11C9BB8
	public XmlSchemaForm get_Form() { }

	// RVA: 0x11C9BC0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x11C9BC8
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x11C9BD0
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x11C9BD8
	public bool get_IsNullable() { }

	// RVA: 0x11C9BE0
	public void set_IsNullable(bool value) { }

	// RVA: 0x11C9BE8
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x11C9BF0
	public void set_NestingLevel(int value) { }

	// RVA: 0x11C9BF8
	public bool get_MultiReferenceType() { }

	// RVA: 0x11C9C18
	public bool get_WrappedElement() { }

	// RVA: 0x11C9C20
	public void set_WrappedElement(bool value) { }

	// RVA: 0x11C9C28
	public bool get_IsTextElement() { }

	// RVA: 0x11C9C80
	public void set_IsTextElement(bool value) { }

	// RVA: 0x11C9D54
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0x11C9DB4
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x11C9E7C
	public int get_ExplicitOrder() { }

	// RVA: 0x11C9E84
	public void set_ExplicitOrder(int value) { }

	// RVA: 0x11C9E8C
	public override bool Equals(object other) { }

	// RVA: 0x11C9FF0
	public override int GetHashCode() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfoList
{
	// Methods

	// RVA: 0x11C9FF8
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

	// RVA: 0x11CA000
	public void .ctor() { }

	// RVA: 0x11CA084
	public string get_Name() { }

	// RVA: 0x11CA08C
	public void set_Name(string value) { }

	// RVA: 0x11CA094
	public object get_DefaultValue() { }

	// RVA: 0x11CA09C
	public void set_DefaultValue(object value) { }

	// RVA: 0x11CA0A4
	public bool IsReadOnly(Type type) { }

	// RVA: 0x11CA428
	public static object GetValue(object ob, string name) { }

	// RVA: 0x11C2A34
	public object GetValue(object ob) { }

	// RVA: 0x11CA554
	public void SetValue(object ob, object value) { }

	// RVA: 0x11CA6A4
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0x11CA1AC
	private void InitMember(Type type) { }

	// RVA: 0x11CA7D8
	public TypeData get_TypeData() { }

	// RVA: 0x11CA7E0
	public void set_TypeData(TypeData value) { }

	// RVA: 0x11CA7E8
	public int get_Index() { }

	// RVA: 0x11CA7F0
	public void set_Index(int value) { }

	// RVA: 0x11CA7F8
	public int get_GlobalIndex() { }

	// RVA: 0x11CA800
	public void set_GlobalIndex(int value) { }

	// RVA: 0x11C6318
	public bool get_IsOptionalValueType() { }

	// RVA: 0x11CA808
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0x11CA81C
	public bool get_IsReturnValue() { }

	// RVA: 0x11CA828
	public void set_IsReturnValue(bool value) { }

	// RVA: 0x11CA848
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0x11C6324
	public bool GetValueSpecified(object ob) { }

	// RVA: 0x11CA8C4
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

	// RVA: 0x11CAB6C
	public void .ctor() { }

	// RVA: 0x11CAC28
	public string get_AttributeName() { }

	// RVA: 0x11CAC30
	public void set_AttributeName(string value) { }

	// RVA: 0x11CAC38
	public string get_Namespace() { }

	// RVA: 0x11CAC40
	public void set_Namespace(string value) { }

	// RVA: 0x11CAC48
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x11CAC50
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x11CAC58
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

	// RVA: 0x11CAC60
	public void .ctor() { }

	// RVA: 0x11C46C4
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x11CACE4
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x11CACEC
	public string get_ChoiceMember() { }

	// RVA: 0x11CACF4
	public void set_ChoiceMember(string value) { }

	// RVA: 0x11CACFC
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x11CAD04
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0x11C5C58
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0x11CAD0C
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x11CAD1C
	public bool get_IsXmlTextCollector() { }

	// RVA: 0x11CAD24
	public void set_IsXmlTextCollector(bool value) { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberList
{
	// Methods

	// RVA: 0x11CAD2C
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberExpandable
{
	// Fields
	private int _flatArrayIndex; // 0x78

	// Methods

	// RVA: 0x11CADB0
	public int get_FlatArrayIndex() { }

	// RVA: 0x11CADB8
	public void set_FlatArrayIndex(int value) { }

	// RVA: 0x11CADC0
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberFlatList
{
	// Fields
	private ListMap _listMap; // 0x80

	// Methods

	// RVA: 0x11CAE44
	public ListMap get_ListMap() { }

	// RVA: 0x11CAE4C
	public void set_ListMap(ListMap value) { }

	// RVA: 0x11CAE54
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyElement
{
	// Methods

	// RVA: 0x11C79DC
	public bool IsElementDefined(string name, string ns) { }

	// RVA: 0x11CAED8
	public bool get_IsDefaultAny() { }

	// RVA: 0x11CB270
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyAttribute
{
	// Methods

	// RVA: 0x11CB2F4
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberNamespaces
{
	// Methods

	// RVA: 0x11CB378
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

	// RVA: 0x11CB3FC
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0x11C7EEC
	public string get_TypeFullName() { }

	// RVA: 0x11CB4D8
	internal TypeData get_TypeData() { }

	// RVA: 0x11CB4E0
	internal string get_XmlType() { }

	// RVA: 0x11CB4E8
	internal void set_XmlType(string value) { }

	// RVA: 0x11C2658
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x11CB4F0
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0x11CB4F8
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x11CB508
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x11CB510
	internal bool get_MultiReferenceType() { }

	// RVA: 0x11CB518
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x11CB520
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0x11CB528
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0x11CB530
	internal bool get_IsNullable() { }

	// RVA: 0x11CB538
	internal void set_IsNullable(bool value) { }

	// RVA: 0x11CB540
	internal bool get_IsAny() { }

	// RVA: 0x11CB548
	internal void set_IsAny(bool value) { }

	// RVA: 0x11C24C8
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0x11CB550
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0x11CB918
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

	// RVA: 0x11CB9E0
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

	// RVA: 0x11CC2A8
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x11CD0C8
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x11CD180
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x11CD2B4
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x11CD670
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x11CCFE0
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x11CD9F8
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x11CDDF4
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x11CDDFC
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x11CDE04
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x11C402C
	public ICollection get_AttributeMembers() { }

	// RVA: 0x11CDE0C
	public ICollection get_ElementMembers() { }

	// RVA: 0x11CDE14
	public ArrayList get_AllMembers() { }

	// RVA: 0x11CDE1C
	public ArrayList get_FlatLists() { }

	// RVA: 0x11CDE24
	public ArrayList get_ListMembers() { }

	// RVA: 0x11CDE2C
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x11CDE34
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x11CDE3C
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x11CE0FC
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x11CE104
	public bool get_HasSimpleContent() { }

	// RVA: 0x11CE178
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class ListMap
{
	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Methods

	// RVA: 0x11CE230
	public void set_ChoiceMember(string value) { }

	// RVA: 0x11CE238
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x11CE240
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x11C71A4
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x11CE248
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x11CE554
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x11C6EFC
	public void GetArrayType(int itemCount, string localName, string ns) { }

	// RVA: 0x11CE874
	public override bool Equals(object other) { }

	// RVA: 0x11CE9D8
	public override int GetHashCode() { }

	// RVA: 0x11CE9E0
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

	// RVA: 0x11CEF50
	public void .ctor(string xmlName, string enumName, Int64 value) { }

	// RVA: 0x11CEFAC
	public string get_XmlName() { }

	// RVA: 0x11CEFB4
	public string get_EnumName() { }

	// RVA: 0x11CEFBC
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

	// RVA: 0x11CE9E8
	public void .ctor(EnumMapMember[] members, bool isFlags) { }

	// RVA: 0x11CEB98
	public bool get_IsFlags() { }

	// RVA: 0x11CEBA0
	public string[] get_EnumNames() { }

	// RVA: 0x11CEBA8
	public string[] get_XmlNames() { }

	// RVA: 0x11CEBB0
	public Int64[] get_Values() { }

	// RVA: 0x11C7F0C
	public string GetXmlName(string typeName, object enumValue) { }

	// RVA: 0x11CEBB8
	public string GetEnumName(string typeName, string xmlName) { }

}

// Namespace: System.Xml.XmlConfiguration
public sealed class XmlReaderSection
{
	// Methods

	// RVA: 0x11CEFC4
	internal static bool get_ProhibitDefaultUrlResolver() { }

	// RVA: 0x11CEFCC
	internal static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x11CF024
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

	// RVA: 0x11CF02C
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

	// RVA: 0x11CF034
	public void Clear() { }

	// RVA: 0x11CF044
	internal int get_Count() { }

	// RVA: 0x11CF04C
	public string GetResult() { }

	// RVA: 0x11CF14C
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

	// RVA: 0x11CF2E4
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0x11CF2EC
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0x11CF338
	internal void SetDepth(int depth) { }

	// RVA: 0x11CF340
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0x11CF484
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

	// RVA: 0x11CF75C
	internal ForwardAxis get_Subtree() { }

	// RVA: 0x11CF764
	internal int get_Length() { }

	// RVA: 0x11CF78C
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0x11CF864
	internal void Push(int depth) { }

	// RVA: 0x11CF908
	internal void Pop() { }

	// RVA: 0x11CF6B8
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0x11CF954
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0x11CFB08
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0x11CFC8C
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

	// RVA: 0x11CFE74
	public int get_CurrentDepth() { }

	// RVA: 0x11CFE7C
	internal void Reactivate() { }

	// RVA: 0x11CFE90
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0x11D0054
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0x11D019C
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0x11D02B8
	public bool MoveToAttribute(string localname, string URN) { }

}

// Namespace: System.Xml.Schema
internal class DoubleLinkAxis
{
	// Fields
	internal Axis next; // 0x40

	// Methods

	// RVA: 0x11D03C4
	internal Axis get_Next() { }

	// RVA: 0x11D03CC
	internal void set_Next(Axis value) { }

	// RVA: 0x11D03D4
	internal void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x11D0468
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

	// RVA: 0x11D0588
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x11D0590
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0x11D0598
	internal bool get_IsAttribute() { }

	// RVA: 0x11D05A0
	internal bool get_IsDss() { }

	// RVA: 0x11D05A8
	internal bool get_IsSelfAxis() { }

	// RVA: 0x11D05B0
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

	// RVA: 0x11D0774
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0x11D077C
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11D1050
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0x11CF67C
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0x11D108C
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0x11D072C
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0x11D07E8
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11D10D4
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

// Namespace: System.Xml.Schema
internal class AutoValidator
{
	// Methods

	// RVA: 0x11D1210
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x11D13A8
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x11D13B0
	public override void Validate() { }

	// RVA: 0x11D1A40
	public override void CompleteValidation() { }

	// RVA: 0x11D1A44
	public override object FindId(string name) { }

	// RVA: 0x11D14A8
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

	// RVA: 0x11D1B10
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x11D1B98
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x11D1C70
	protected XmlNameTable get_NameTable() { }

	// RVA: 0x11D1C78
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x11D1D1C
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x11D1D24
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x11D1D2C
	protected bool get_HasErrors() { }

	// RVA: 0x11D1D3C
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x11D21A0
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11D2458
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11D22FC
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11D26A4
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0x11D25A0
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0x11D286C
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0x11D29E4
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0x11D2B24
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x11D2CB4
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x11D2D3C
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x11D2DE8
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x11D27A0
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x11D2E80
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

	// RVA: 0x11D2F38
	public void .ctor(BaseValidator other) { }

	// RVA: 0x11D12A4
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x11D2FF4
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x11D2FFC
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x11D3004
	public XmlNameTable get_NameTable() { }

	// RVA: 0x11D1A4C
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x11D300C
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x11D3014
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x11D301C
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x11D3024
	public Uri get_BaseUri() { }

	// RVA: 0x11D302C
	public void set_BaseUri(Uri value) { }

	// RVA: 0x11D3034
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x11D3118
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0x11D3120
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x11D320C
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x11D3214
	public virtual void Validate() { }

	// RVA: 0x11D3218
	public virtual void CompleteValidation() { }

	// RVA: 0x11D321C
	public virtual object FindId(string name) { }

	// RVA: 0x11D3224
	public void ValidateText() { }

	// RVA: 0x11D3720
	public void ValidateWhitespace() { }

	// RVA: 0x11D36A8
	private void SaveTextValue(string value) { }

	// RVA: 0x11D3860
	protected void SendValidationEvent(string code) { }

	// RVA: 0x11D35C0
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x11D34D8
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0x11D38C4
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x11D39B4
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x11D3AA0
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x11D38CC
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x11D3B8C
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0x11D3D54
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0x11D3F58
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

}

// Namespace: System.Xml.Schema
internal sealed class BitSet
{
	// Fields
	private int count; // 0x10
	private UInt32[] bits; // 0x18

	// Methods

	// RVA: 0x11D4198
	private void .ctor() { }

	// RVA: 0x11D41A0
	public void .ctor(int count) { }

	// RVA: 0x11D4224
	public int get_Count() { }

	// RVA: 0x11D422C
	public bool get_Item(int index) { }

	// RVA: 0x11D42DC
	public void Clear() { }

	// RVA: 0x11D4334
	public void Set(int index) { }

	// RVA: 0x11D4284
	public bool Get(int index) { }

	// RVA: 0x11D4450
	public int NextSet(int startFrom) { }

	// RVA: 0x11D44F0
	public void And(BitSet other) { }

	// RVA: 0x11D4620
	public void Or(BitSet other) { }

	// RVA: 0x11D46D0
	public override int GetHashCode() { }

	// RVA: 0x11D470C
	public override bool Equals(object obj) { }

	// RVA: 0x11D4880
	public BitSet Clone() { }

	// RVA: 0x11D4980
	public bool get_IsEmpty() { }

	// RVA: 0x11D4A3C
	public bool Intersects(BitSet other) { }

	// RVA: 0x11D421C
	private int Subscript(int bitIndex) { }

	// RVA: 0x11D439C
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

	// RVA: 0x11D4B18
	public void .ctor(string ns, XmlSchema originalSchema) { }

	// RVA: 0x11D4BB0
	public override int GetHashCode() { }

	// RVA: 0x11D4C40
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

	// RVA: 0x11D4D4C
	public ConstraintRole get_Role() { }

	// RVA: 0x11D4D54
	public Asttree get_Selector() { }

	// RVA: 0x11D4D5C
	public Asttree[] get_Fields() { }

	// RVA: 0x11D4D64
	private void .ctor() { }

	// RVA: 0x11D4DF8
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11D5374
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

	// RVA: 0x11D5454
	internal int get_TableDim() { }

	// RVA: 0x11D545C
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

	// RVA: 0x11D5698
	internal int get_Column() { }

	// RVA: 0x11D56A0
	internal void .ctor(Asttree astfield, KeySequence ks, int column) { }

	// RVA: 0x11D56E8
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

	// RVA: 0x11D5700
	public int get_lastDepth() { }

	// RVA: 0x11D5600
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0x11D57B4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0x11D5808
	public int PushKS(int errline, int errcol) { }

	// RVA: 0x11D5CE4
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

	// RVA: 0x11D5C54
	public void .ctor(KeySequence ks, int dim) { }

}

// Namespace: 
private class DecimalStruct
{
	// Fields
	private bool isDecimal; // 0x10
	private Decimal[] dvalue; // 0x18

	// Methods

	// RVA: 0x11D6844
	public bool get_IsDecimal() { }

	// RVA: 0x11D684C
	public void set_IsDecimal(bool value) { }

	// RVA: 0x11D6854
	public Decimal[] get_Dvalue() { }

	// RVA: 0x11D63C4
	public void .ctor() { }

	// RVA: 0x11D6350
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

	// RVA: 0x11D5D88
	public int get_Dim() { }

	// RVA: 0x11D5D90
	public bool get_IsList() { }

	// RVA: 0x11D5D98
	public bool get_IsDecimal() { }

	// RVA: 0x11D5DB8
	public Decimal[] get_Dvalue() { }

	// RVA: 0x11D5DD8
	public object get_Value() { }

	// RVA: 0x11D5DE0
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0x11D5DE8
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x11D5F88
	public override string ToString() { }

	// RVA: 0x11D5F90
	public void SetDecimal() { }

	// RVA: 0x11D6434
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0x11D6568
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

	// RVA: 0x11D5BBC
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x11D685C
	public int get_PosLine() { }

	// RVA: 0x11D6864
	public int get_PosCol() { }

	// RVA: 0x11D686C
	public object get_Item(int index) { }

	// RVA: 0x11D68A0
	public void set_Item(int index, object value) { }

	// RVA: 0x11D69A0
	internal bool IsQualified() { }

	// RVA: 0x11D6A28
	public override int GetHashCode() { }

	// RVA: 0x11D6D90
	public override bool Equals(object other) { }

	// RVA: 0x11D6E8C
	public override string ToString() { }

}

// Namespace: System.Xml.Schema
internal class UpaException
{
	// Fields
	private object particle1; // 0x90
	private object particle2; // 0x98

	// Methods

	// RVA: 0x11D6FC4
	public void .ctor(object particle1, object particle2) { }

	// RVA: 0x11D7058
	public object get_Particle1() { }

	// RVA: 0x11D7060
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

	// RVA: 0x11D7068
	public void .ctor() { }

	// RVA: 0x11D7120
	public int get_Count() { }

	// RVA: 0x11D712C
	public bool get_IsUpaEnforced() { }

	// RVA: 0x11D7134
	public void set_IsUpaEnforced(bool value) { }

	// RVA: 0x11D713C
	public int AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x11D727C
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	// RVA: 0x11D761C
	private void AddWildcard(string wildcard, object particle) { }

	// RVA: 0x11D77AC
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0x11D7F30
	public int get_Item(XmlQualifiedName name) { }

	// RVA: 0x11D8034
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x11D8068
	public object GetParticle(int symbol) { }

	// RVA: 0x11D80A8
	public string NameOf(int symbol) { }

}

// Namespace: System.Xml.Schema
internal struct Position
{
	// Fields
	public int symbol; // 0x10
	public object particle; // 0x18

	// Methods

	// RVA: 0x11D8764
	public void .ctor(int symbol, object particle) { }

}

// Namespace: System.Xml.Schema
internal class Positions
{
	// Fields
	private ArrayList positions; // 0x10

	// Methods

	// RVA: 0x11D8774
	public int Add(int symbol, object particle) { }

	// RVA: 0x11D8828
	public Position get_Item(int pos) { }

	// RVA: 0x11D88C4
	public int get_Count() { }

	// RVA: 0x11D88EC
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

	// RVA: 0x11D8964
	public virtual bool get_IsRangeNode() { }

	// RVA: 0x11D896C
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class LeafNode
{
	// Fields
	private int pos; // 0x10

	// Methods

	// RVA: 0x11D8974
	public void .ctor(int pos) { }

	// RVA: 0x11D89A0
	public int get_Pos() { }

	// RVA: 0x11D89A8
	public void set_Pos(int value) { }

	// RVA: 0x11D89B0
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11D89B4
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11D8A78
	public override bool get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal class NamespaceListNode
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Methods

	// RVA: 0x11D8A80
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0x11D8AD0
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0x11D8AF4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11D9028
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11D9068
	public override bool get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal abstract class InteriorNode
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Methods

	// RVA: 0x11D90A8
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x11D90B0
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x11D90B8
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x11D90C0
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0x11D90C8
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11D9304
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11D9378
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

	// RVA: 0x11D9AD0
	public void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

}

// Namespace: System.Xml.Schema
internal sealed class SequenceNode
{
	// Methods

	// RVA: 0x11D9380
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11D9B40
	public override bool get_IsNullable() { }

	// RVA: 0x11D9C94
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11D9C98
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class ChoiceNode
{
	// Methods

	// RVA: 0x11D9CA0
	private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11D9E14
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11D9FC4
	public override bool get_IsNullable() { }

	// RVA: 0x11DA058
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11D9020
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class PlusNode
{
	// Methods

	// RVA: 0x11DA05C
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11DA1C4
	public override bool get_IsNullable() { }

	// RVA: 0x11DA1E8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class QmarkNode
{
	// Methods

	// RVA: 0x11DA1F0
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11DA214
	public override bool get_IsNullable() { }

	// RVA: 0x11DA21C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class StarNode
{
	// Methods

	// RVA: 0x11DA224
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11DA38C
	public override bool get_IsNullable() { }

	// RVA: 0x11DA394
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

	// RVA: 0x11DA39C
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0x11DA3F0
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0x11DA444
	public Decimal get_Max() { }

	// RVA: 0x11DA450
	public Decimal get_Min() { }

	// RVA: 0x11DA45C
	public BitSet get_NextIteration() { }

	// RVA: 0x11DA464
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x11DA46C
	public override bool get_IsRangeNode() { }

	// RVA: 0x11DA474
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

	// RVA: 0x11DA4B4
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x11DA4E8
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x11DA52C
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x11DA534
	public bool get_PreserveWhitespace() { }

	// RVA: 0x11DA548
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x11DA550
	public bool get_IsOpen() { }

	// RVA: 0x11DA574
	public void set_IsOpen(bool value) { }

	// RVA: 0x11DA57C
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x11DA580
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11DA5B4
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11DA5BC
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11DA5C4
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x11DA5CC
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x11DA648
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x11DA87C
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

	// RVA: 0x11DA994
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x11DAA10
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0x11DAA98
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x11DAAD8
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11DAB18
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11DAB58
	public void Start() { }

	// RVA: 0x11DAC88
	public void OpenGroup() { }

	// RVA: 0x11DACB4
	public void CloseGroup() { }

	// RVA: 0x11DAE40
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x11DAE7C
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x11DB0A4
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0x11DAFA0
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0x11DB150
	public void AddChoice() { }

	// RVA: 0x11DB248
	public void AddSequence() { }

	// RVA: 0x11DB340
	public void AddStar() { }

	// RVA: 0x11DB548
	public void AddPlus() { }

	// RVA: 0x11DB5B0
	public void AddQMark() { }

	// RVA: 0x11DB618
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0x11DB3A8
	private void Closure(InteriorNode node) { }

	// RVA: 0x11DB788
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0x11DBF20
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, BitSet posWithRangeTerminals) { }

	// RVA: 0x11DC840
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0x11DC544
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0x11DCA9C
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0x11DD508
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0x11DCB48
	private Int32[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

}

// Namespace: System.Xml.Schema
internal sealed class DfaContentValidator
{
	// Fields
	private Int32[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x11DD454
	internal void .ctor(Int32[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x11DD7C8
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x11DD830
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11DD994
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11DD9B0
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11DDBB0
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

	// RVA: 0x11DDDB4
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x11DDEB0
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x11DDF88
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11DE140
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11DE18C
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11DE388
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

	// RVA: 0x11DE510
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0x11DE620
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x11DE800
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11DF0E8
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11DF104
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11DF3AC
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

	// RVA: 0x11DF5E4
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0x11DF718
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0x11DF878
	public override bool get_IsEmptiable() { }

	// RVA: 0x11DF898
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x11DF93C
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x11DFAB0
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11DFB14
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11DFF28
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

	// RVA: 0x11E03F4
	public void .ctor(XmlSchemaSimpleType st, object value) { }

	// RVA: 0x11E0444
	public XmlSchemaSimpleType get_XmlType() { }

	// RVA: 0x11E044C
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

	// RVA: 0x11E0454
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

	// RVA: 0x11E9398
	internal void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0x11E93E8
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x11EBF0C
	public static DatatypeImplementation op_Explicit(SchemaDatatypeMap sdm) { }

	// RVA: 0x11EBF28
	public string get_Name() { }

	// RVA: 0x11EBF30
	public int get_ParentIndex() { }

	// RVA: 0x11EBF38
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

	// RVA: 0x11E045C
	private static void .cctor() { }

	// RVA: 0x11E9D3C
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x11E9DB8
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x11E9E34
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x11E9ED4
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x11E9F74
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x11EA04C
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x11EA124
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x11EA20C
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x11E9444
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x11EA460
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x11EA500
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x11EA5E4
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x11EA820
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x11EAA5C
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x11EAAD8
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x11EAC50
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x11EAD78
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x11E6C60
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x11EAEF4
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x11EB0A0
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x11EB0A4
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x11EB384
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x11EB3AC
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x11EB49C
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EB4A4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11EB520
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0x11EB580
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11EB588
	public override Type get_ValueType() { }

	// RVA: 0x11EB628
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x11EB630
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11EB638
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x11EB640
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x11EB668
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11EB690
	protected DatatypeImplementation get_Base() { }

	// RVA: -1
	internal abstract Type get_ListValueType() { }

	// RVA: -1
	internal abstract RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11EB698
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11EB6A0
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11EB8F8
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x11EBA60
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, object typedValue) { }

	// RVA: 0x11EB888
	internal string GetTypeName() { }

	// RVA: 0x11EBEA0
	protected int Compare(Byte[] value1, Byte[] value2) { }

	// RVA: 0x11EBF04
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_List
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Methods

	// RVA: 0x11EBFB4
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EAE00
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x11EC308
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11EC5FC
	public override Type get_ValueType() { }

	// RVA: 0x11EC60C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11EC630
	internal override Type get_ListValueType() { }

	// RVA: 0x11EC658
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11EC6D4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11EC6F8
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11EC700
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, object typedValue) { }

	// RVA: 0x11ECFFC
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

	// RVA: 0x11ED518
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EAFC0
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x11ED524
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11ED62C
	public override Type get_ValueType() { }

	// RVA: 0x11ED6A8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11ED6B0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11ED72C
	internal override Type get_ListValueType() { }

	// RVA: 0x11ED7A8
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11ED7B0
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x11EAD84
	internal bool HasAtomicMembers() { }

	// RVA: 0x11EB2DC
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x11ED7B8
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11ED9D8
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11EDEC4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anySimpleType
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11EDFA0
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EE01C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11EE098
	public override Type get_ValueType() { }

	// RVA: 0x11EE114
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11EE11C
	internal override Type get_ListValueType() { }

	// RVA: 0x11EE198
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11EE1A0
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11EE1A8
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11EE1B0
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11EE210
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E5C80
	public void .ctor() { }

	// RVA: 0x11EE24C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyAtomicType
{
	// Methods

	// RVA: 0x11EE328
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EE3A4
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11EE3AC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E8F68
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_untypedAtomicType
{
	// Methods

	// RVA: 0x11EE3B4
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EE430
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11EE438
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E9180
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_string
{
	// Methods

	// RVA: 0x11EE440
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EE44C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11EE454
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11EE4D0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11EE4D8
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11EE4E0
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11EE4E8
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E8210
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_boolean
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11EE5F4
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EE600
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11EE67C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11EE684
	public override Type get_ValueType() { }

	// RVA: 0x11EE700
	internal override Type get_ListValueType() { }

	// RVA: 0x11EE77C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11EE784
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11EE78C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11EE838
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E5EC8
	public void .ctor() { }

	// RVA: 0x11EE988
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_float
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11EEA64
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EEA70
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11EEAEC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11EEAF4
	public override Type get_ValueType() { }

	// RVA: 0x11EEB70
	internal override Type get_ListValueType() { }

	// RVA: 0x11EEBEC
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11EEBF4
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11EEBFC
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11EEC98
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E705C
	public void .ctor() { }

	// RVA: 0x11EEE20
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_double
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11EEEFC
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EEF08
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11EEF84
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11EEF8C
	public override Type get_ValueType() { }

	// RVA: 0x11EF008
	internal override Type get_ListValueType() { }

	// RVA: 0x11EF084
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11EF08C
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11EF094
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11EF130
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E6888
	public void .ctor() { }

	// RVA: 0x11EF2B8
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

	// RVA: 0x11EF394
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EF3A0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11EF41C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11EF424
	public override Type get_ValueType() { }

	// RVA: 0x11EF4A0
	internal override Type get_ListValueType() { }

	// RVA: 0x11EF51C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11EF524
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11EF52C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11EF604
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E67A8
	public void .ctor() { }

	// RVA: 0x11EF7A4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_duration
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11EF9A0
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11EF9AC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11EFA28
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11EFA30
	public override Type get_ValueType() { }

	// RVA: 0x11EFAAC
	internal override Type get_ListValueType() { }

	// RVA: 0x11EFB28
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11EFB30
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11EFB38
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11EFBE4
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E6AA0
	public void .ctor() { }

	// RVA: 0x11EFDF4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonthDuration
{
	// Methods

	// RVA: 0x11EFED0
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F00E4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E9260
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dayTimeDuration
{
	// Methods

	// RVA: 0x11F00EC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F0300
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E9048
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

	// RVA: 0x11F0308
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11F0314
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F0390
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F0398
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x11F0470
	public override Type get_ValueType() { }

	// RVA: 0x11F04EC
	internal override Type get_ListValueType() { }

	// RVA: 0x11F0568
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11F0570
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11F0578
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F06F8
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F0A80
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeNoTimeZone
{
	// Methods

	// RVA: 0x11E6418
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeTimeZone
{
	// Methods

	// RVA: 0x11E6548
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTime
{
	// Methods

	// RVA: 0x11E62E8
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeNoTimeZone
{
	// Methods

	// RVA: 0x11E8420
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeTimeZone
{
	// Methods

	// RVA: 0x11E8550
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_time
{
	// Methods

	// RVA: 0x11F0B5C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E82F0
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_date
{
	// Methods

	// RVA: 0x11F0B64
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E61B8
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonth
{
	// Methods

	// RVA: 0x11F0B6C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E8C78
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_year
{
	// Methods

	// RVA: 0x11F0B74
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E8B48
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_monthDay
{
	// Methods

	// RVA: 0x11F0B7C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E78E0
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_day
{
	// Methods

	// RVA: 0x11F0B84
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E6678
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_month
{
	// Methods

	// RVA: 0x11F0B8C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E77B0
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_hexBinary
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11F0B94
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11F0BA0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F0C1C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F0C24
	public override Type get_ValueType() { }

	// RVA: 0x11F0CA0
	internal override Type get_ListValueType() { }

	// RVA: 0x11F0D1C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11F0D24
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11F0D2C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F0E40
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E7274
	public void .ctor() { }

	// RVA: 0x11F1034
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_base64Binary
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11F1110
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11F111C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F1198
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F11A0
	public override Type get_ValueType() { }

	// RVA: 0x11F121C
	internal override Type get_ListValueType() { }

	// RVA: 0x11F1298
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11F12A0
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11F12A8
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F13BC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E5DE8
	public void .ctor() { }

	// RVA: 0x11F15AC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyURI
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11F1688
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11F1694
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F1710
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F1718
	public override Type get_ValueType() { }

	// RVA: 0x11F1794
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11F179C
	internal override Type get_ListValueType() { }

	// RVA: 0x11F1818
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11F1820
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11F1828
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F18F4
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E5D08
	public void .ctor() { }

	// RVA: 0x11F1D18
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QName
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11F1DF4
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11F1E00
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F1E7C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F1E84
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11F1E8C
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11F1E94
	public override Type get_ValueType() { }

	// RVA: 0x11F1F10
	internal override Type get_ListValueType() { }

	// RVA: 0x11F1F8C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11F1F94
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E7F78
	public void .ctor() { }

	// RVA: 0x11F21F4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedString
{
	// Methods

	// RVA: 0x11F22D0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F22D8
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11F22E0
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11E7D38
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedStringV1Compat
{
	// Methods

	// RVA: 0x11F22E8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F22F0
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11E8DA8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_token
{
	// Methods

	// RVA: 0x11F22F8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F2300
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11E8680
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_tokenV1Compat
{
	// Methods

	// RVA: 0x11F2308
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E8E88
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_language
{
	// Methods

	// RVA: 0x11F2310
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E76CC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NMTOKEN
{
	// Methods

	// RVA: 0x11F2318
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F2320
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11E7C50
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_Name
{
	// Methods

	// RVA: 0x11F2328
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E7A10
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NCName
{
	// Methods

	// RVA: 0x11F2330
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F2338
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E7AF0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ID
{
	// Methods

	// RVA: 0x11F246C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F2474
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11E7354
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_IDREF
{
	// Methods

	// RVA: 0x11F247C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F2484
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11E7434
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENTITY
{
	// Methods

	// RVA: 0x11F248C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F2494
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11E6B80
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NOTATION
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11F249C
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11F24A8
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F2524
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F252C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11F2534
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11F253C
	public override Type get_ValueType() { }

	// RVA: 0x11F25B8
	internal override Type get_ListValueType() { }

	// RVA: 0x11F2634
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11F263C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11F289C
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x11E7E18
	public void .ctor() { }

	// RVA: 0x11F2B3C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_integer
{
	// Methods

	// RVA: 0x11F2C18
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F2C20
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E7594
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonPositiveInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x11F2D9C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F2E18
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F2E20
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11E7D34
	public void .ctor() { }

	// RVA: 0x11F2E28
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_negativeInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x11F2F50
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F2FCC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E7BD0
	public void .ctor() { }

	// RVA: 0x11F2FD4
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

	// RVA: 0x11F30FC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F3178
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11F3180
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F3188
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F3224
	public override Type get_ValueType() { }

	// RVA: 0x11F32A0
	internal override Type get_ListValueType() { }

	// RVA: 0x11F331C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E77AC
	public void .ctor() { }

	// RVA: 0x11F34A4
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

	// RVA: 0x11F3634
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F36B0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F36B8
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F3754
	public override Type get_ValueType() { }

	// RVA: 0x11F37D0
	internal override Type get_ListValueType() { }

	// RVA: 0x11F384C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E7514
	public void .ctor() { }

	// RVA: 0x11F39D4
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

	// RVA: 0x11F3B64
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F3BE0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F3BE8
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F3C84
	public override Type get_ValueType() { }

	// RVA: 0x11F3D00
	internal override Type get_ListValueType() { }

	// RVA: 0x11F3D7C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E8138
	public void .ctor() { }

	// RVA: 0x11F3F04
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

	// RVA: 0x11F4094
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F4110
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F4118
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F41B4
	public override Type get_ValueType() { }

	// RVA: 0x11F4230
	internal override Type get_ListValueType() { }

	// RVA: 0x11F42AC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E5FA8
	public void .ctor() { }

	// RVA: 0x11F4434
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonNegativeInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x11F45C4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F4640
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F4648
	internal override bool get_HasValueFacets() { }

	// RVA: 0x11E7D30
	public void .ctor() { }

	// RVA: 0x11F4650
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

	// RVA: 0x11F4778
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F47F4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F47FC
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F4898
	public override Type get_ValueType() { }

	// RVA: 0x11F4914
	internal override Type get_ListValueType() { }

	// RVA: 0x11F4990
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E88B8
	public void .ctor() { }

	// RVA: 0x11F4B5C
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

	// RVA: 0x11F4D04
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F4D80
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F4D88
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F4E24
	public override Type get_ValueType() { }

	// RVA: 0x11F4EA0
	internal override Type get_ListValueType() { }

	// RVA: 0x11F4F1C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E87E0
	public void .ctor() { }

	// RVA: 0x11F50A4
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

	// RVA: 0x11F524C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F52C8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F52D0
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F536C
	public override Type get_ValueType() { }

	// RVA: 0x11F53E8
	internal override Type get_ListValueType() { }

	// RVA: 0x11F5464
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E8938
	public void .ctor() { }

	// RVA: 0x11F55EC
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

	// RVA: 0x11F5794
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F5810
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11F5818
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F58B4
	public override Type get_ValueType() { }

	// RVA: 0x11F5930
	internal override Type get_ListValueType() { }

	// RVA: 0x11F59AC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E8760
	public void .ctor() { }

	// RVA: 0x11F5B34
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_positiveInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x11F5CDC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11F5D58
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x11E7EF8
	public void .ctor() { }

	// RVA: 0x11F5D60
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_doubleXdr
{
	// Methods

	// RVA: 0x11F5E88
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11E6968
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_floatXdr
{
	// Methods

	// RVA: 0x11F6080
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11E713C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QNameXdr
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11F6278
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11F6280
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11F6510
	public override Type get_ValueType() { }

	// RVA: 0x11F658C
	internal override Type get_ListValueType() { }

	// RVA: 0x11E8058
	public void .ctor() { }

	// RVA: 0x11F6608
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENUMERATION
{
	// Methods

	// RVA: 0x11F66E4
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11E6E44
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_char
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11F66EC
	public override Type get_ValueType() { }

	// RVA: 0x11F6768
	internal override Type get_ListValueType() { }

	// RVA: 0x11F67E4
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11F67EC
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F6898
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11F6A74
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E60D8
	public void .ctor() { }

	// RVA: 0x11F6B74
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_fixed
{
	// Methods

	// RVA: 0x11F6C50
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11F71DC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E6F24
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_uuid
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11F7370
	public override Type get_ValueType() { }

	// RVA: 0x11F73EC
	internal override Type get_ListValueType() { }

	// RVA: 0x11F7468
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11F7470
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x11F7510
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11F76EC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x11E8A68
	public void .ctor() { }

	// RVA: 0x11F77EC
	private static void .cctor() { }

}

// Namespace: 
private class NamespaceManager
{
	// Methods

	// RVA: 0x11FA08C
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11FA084
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

	// RVA: 0x11F78C8
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x11F7970
	private void Init() { }

	// RVA: 0x11F7C28
	public override void Validate() { }

	// RVA: 0x11F7F44
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x11F7FF0
	private void ValidatePIComment() { }

	// RVA: 0x11F7E24
	private void ValidateElement() { }

	// RVA: 0x11F843C
	private void ValidateChildElement() { }

	// RVA: 0x11F86AC
	private void ValidateStartElement() { }

	// RVA: 0x11F90C0
	private void ValidateEndStartElement() { }

	// RVA: 0x11F8580
	private void ProcessElement() { }

	// RVA: 0x11F92A4
	public override void CompleteValidation() { }

	// RVA: 0x11F827C
	private void ValidateEndElement() { }

	// RVA: 0x11F94E4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x11F9520
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x11F8B0C
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x11F97AC
	internal void AddID(string name, object node) { }

	// RVA: 0x11F984C
	public override object FindId(string name) { }

	// RVA: 0x11F80C0
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x11F9868
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x11F93B8
	private void CheckForwardRefs() { }

	// RVA: 0x11F7AE0
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x11F92FC
	private bool Pop() { }

	// RVA: 0x11F9914
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x11F9C24
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x11F9FFC
	private static void .cctor() { }

}

// Namespace: 
private struct Map
{
	// Fields
	internal Char match; // 0x10
	internal string replacement; // 0x18

	// Methods

	// RVA: 0x11FED8C
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

	// RVA: 0x11FA7E4
	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x11FAB28
	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11FAF58
	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11FB34C
	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11FB740
	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x11FB978
	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x11FBB7C
	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11FC528
	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11FC7C8
	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11FBFE8
	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11FC288
	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11FCA68
	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11FCEEC
	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11FD274
	internal void FinishFacetCompile() { }

	// RVA: 0x11FDE04
	private void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x11FD618
	internal void CompileFacetCombinations() { }

	// RVA: 0x11FE51C
	private void CopyFacetsFromBaseType() { }

	// RVA: 0x11FDC48
	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x11FE29C
	private static string Preprocess(string pattern) { }

	// RVA: 0x11FDB3C
	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x11FDBCC
	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x11FDD98
	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x11FEA34
	private void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x11FEA74
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class FacetsChecker
{
	// Methods

	// RVA: 0x11FA094
	internal virtual Exception CheckLexicalFacets(string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA354
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA35C
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA364
	internal virtual Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA36C
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA374
	internal virtual Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA37C
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA384
	internal virtual Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA38C
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA394
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA39C
	internal virtual Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA3A4
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA3AC
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA0DC
	internal void CheckWhitespaceFacets(string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA1E4
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x11FA3B4
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FA3BC
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x11FD9F8
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x11FDB34
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

	// RVA: 0x11EF954
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0x11FED9C
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FEE18
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FF58C
	internal override Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FF624
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FF6BC
	internal override Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FF754
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FF444
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x11F6F2C
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0x11FF7D8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Numeric2FacetsChecker
{
	// Methods

	// RVA: 0x11FF87C
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FF8E8
	internal override Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FFD5C
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FFD6C
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FFC78
	private bool MatchEnumeration(Double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x11E5C68
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DurationFacetsChecker
{
	// Methods

	// RVA: 0x11FFE94
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11FFFB0
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1200458
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1200340
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x11E5C78
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DateTimeFacetsChecker
{
	// Methods

	// RVA: 0x12004DC
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x120054C
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1200AF4
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1200940
	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11E5C70
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class StringFacetsChecker
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Methods

	// RVA: 0x1200B5C
	private static Regex get_LanguagePattern() { }

	// RVA: 0x1200C2C
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1200C98
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11F1AA8
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0x12011D8
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1200F5C
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1200CA0
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x11E5C60
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class QNameFacetsChecker
{
	// Methods

	// RVA: 0x1044BD8
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1044D0C
	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1045068
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1044F14
	private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

	// RVA: 0x1045184
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class MiscFacetsChecker
{
	// Methods

	// RVA: 0x104518C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class BinaryFacetsChecker
{
	// Methods

	// RVA: 0x1045194
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1045228
	internal override Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1045564
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x104541C
	private bool MatchEnumeration(Byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1045604
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class ListFacetsChecker
{
	// Methods

	// RVA: 0x104560C
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1045880
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1045964
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class UnionFacetsChecker
{
	// Methods

	// RVA: 0x104596C
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1045A78
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1045B5C
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

	// RVA: 0x1045B64
	public void set_Occurrence(InferenceOption value) { }

	// RVA: 0x1045B6C
	public InferenceOption get_Occurrence() { }

	// RVA: 0x1045B74
	public void set_TypeInference(InferenceOption value) { }

	// RVA: 0x1045B7C
	public void .ctor() { }

	// RVA: 0x1045CBC
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x1045D34
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x10482EC
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x104AD78
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x10467F0
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x1046E28
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x104BABC
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x104B1B4
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x104C08C
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, int lastUsedSeqItem, bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x104B2F0
	internal void ProcessAttributes(XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x104BFD8
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x104BBF8
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x1048F3C
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x104AE18
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, XmlSchema parentSchema) { }

	// RVA: 0x104D204
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x1048B88
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x104D360
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x104BA14
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x104D7CC
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x10492AC
	internal XmlQualifiedName RefineSimpleType(string s, int iTypeFlags) { }

	// RVA: 0x104D978
	internal static int InferSimpleType(string s, bool bNeedsRangeCheck) { }

	// RVA: 0x104EDDC
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x104D4E4
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x104A41C
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x104D034
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x104EF24
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaInferenceException
{
	// Methods

	// RVA: 0x104FA0C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x104FA14
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x104FA1C
	public void .ctor() { }

	// RVA: 0x104D70C
	internal void .ctor(string res, string arg) { }

	// RVA: 0x10467B8
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

	// RVA: 0x104FA28
	public void .ctor() { }

	// RVA: 0x104FA30
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x104FCDC
	public NamespaceList Clone() { }

	// RVA: 0x104FE20
	public ListType get_Type() { }

	// RVA: 0x104FE28
	public string get_Excluded() { }

	// RVA: 0x104FE30
	public ICollection get_Enumerate() { }

	// RVA: 0x104FEA0
	public virtual bool Allows(string ns) { }

	// RVA: 0x104FF40
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x104FF64
	public override string ToString() { }

	// RVA: 0x1050444
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0x1050810
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x1050D6C
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0x1050EE8
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x10514F0
	private void RemoveNamespace(string tns) { }

}

// Namespace: System.Xml.Schema
internal class NamespaceListV1Compat
{
	// Methods

	// RVA: 0x1051554
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x1051558
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

	// RVA: 0x10515D4
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x10516DC
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0x1051740
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0x1052250
	private bool CheckSchemaRoot(SchemaType rootType, string code) { }

	// RVA: 0x10523A8
	public SchemaType FinishParsing() { }

	// RVA: 0x10523B0
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x10523B8
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10523C0
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0x1051B78
	public bool ParseReaderNode() { }

	// RVA: 0x10523C8
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0x1052610
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0x1052C74
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0x1052A90
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x1052DA4
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

	// RVA: 0x1052FCC
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

	// RVA: 0x105301C
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1053120
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0x10568DC
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x1056FC8
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x105706C
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1057074
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x105707C
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x1057084
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x105708C
	internal XmlSchema get_RootSchema() { }

	// RVA: 0x10545B0
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0x10537C4
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0x10569BC
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0x1057104
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x105733C
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0x1054734
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0x1057998
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0x1055AA0
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0x105A8DC
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0x105A840
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0x1057870
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0x105B0B8
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0x105AA1C
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x105AAD8
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x105AF98
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x105AC34
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x1058BF0
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x105B988
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x105B6C4
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x1058D7C
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x105A008
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x105C650
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x105C278
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x105CA40
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x105993C
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1058EF8
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x105A294
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x105A4E4
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x105CE50
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x105BDFC
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x105755C
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x105B3F0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x105BBBC
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x1057094
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x10570D8
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0x1053660
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x1057488
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x10574AC
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x105A7C4
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

	// RVA: 0x105D82C
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x105D834
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0x105D840
	private void .ctor() { }

	// RVA: 0x105D848
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0x105D850
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x105D870
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x105D878
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0x105D880
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0x105D8D4
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x105D8DC
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0x105D8EC
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x105D9C4
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x105D9CC
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0x105D9D4
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x105D9DC
	internal int get_LinePosition() { }

	// RVA: 0x105D9E4
	internal void set_LinePosition(int value) { }

	// RVA: 0x105D9EC
	internal int get_LineNumber() { }

	// RVA: 0x105D9F4
	internal void set_LineNumber(int value) { }

	// RVA: 0x105D9FC
	internal int get_ValueLinePosition() { }

	// RVA: 0x105DA04
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x105DA0C
	internal int get_ValueLineNumber() { }

	// RVA: 0x105DA14
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0x105D958
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x105DA1C
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0x105D8B0
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x105DA24
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0x105DA58
	internal Reserve get_Reserved() { }

	// RVA: 0x105DA60
	internal void set_Reserved(Reserve value) { }

	// RVA: 0x105DA68
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x105DA70
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x105DA78
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x105DA80
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0x105DD14
	internal SchemaAttDef Clone() { }

	// RVA: 0x105DD7C
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

	// RVA: 0x105DDE8
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

	// RVA: 0x105DDF0
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0x105DEBC
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0x105DF2C
	private void Prepare() { }

	// RVA: 0x105E3B8
	private void Cleanup() { }

	// RVA: 0x106286C
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0x105F2C4
	private void Compile() { }

	// RVA: 0x1061244
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x1062828
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1062284
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10622D4
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x106266C
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1062688
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x1067CB8
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x106224C
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x1067DB4
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10630C0
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0x1067AE8
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x1063554
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1064BC8
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10683DC
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10688CC
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x1063E3C
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10689F4
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1068C8C
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1069104
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x10695CC
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1067980
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x106AF44
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0x1067F2C
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0x106C4A0
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0x106C608
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0x106CBA0
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0x106D060
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0x106D564
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0x106BD00
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x106DAD4
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x106DBFC
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x106DC50
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x106DC9C
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x106DF3C
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x106E330
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x106E654
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x106EABC
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x106F82C
	private void CalculateSequenceRange(XmlSchemaSequence sequence, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x106ED64
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x106F644
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x106F72C
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x106DA08
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x106EE4C
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x106FC58
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x106B0CC
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1063660
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1069970
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x106FD3C
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x106FC80
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x10664A0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x106719C
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x106557C
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x106B168
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x106FDF8
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x10704E8
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x10678A8
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x106822C
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x106BC18
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x106BA7C
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

	// RVA: 0x1070758
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1070760
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0x10709CC
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x1073C74
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1070C04
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0x1073E80
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x1071900
	private void Preprocess(XmlSchema schema, string targetNamespace, Compositor compositor) { }

	// RVA: 0x10741B4
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0x10772FC
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0x1076C64
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x1076D0C
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10771DC
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x1076E78
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x1075388
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1077B30
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10778E0
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x1075514
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1076514
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x1078548
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x10781D8
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x10788C8
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1075F14
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1075620
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x10767A0
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1076980
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x1078C54
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1077E98
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x1071688
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x107760C
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1077CF4
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x10740A0
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x10740C4
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x1073C7C
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x1073D48
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

	// RVA: 0x10795BC
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1079678
	protected void .ctor() { }

	// RVA: 0x10796F4
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x10796FC
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0x1079704
	internal string get_Prefix() { }

	// RVA: 0x1079770
	internal void set_Prefix(string value) { }

	// RVA: 0x1079778
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x1079780
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x1079788
	internal Use get_Presence() { }

	// RVA: 0x1079790
	internal void set_Presence(Use value) { }

	// RVA: 0x1079798
	internal Int64 get_MaxLength() { }

	// RVA: 0x10797A0
	internal void set_MaxLength(Int64 value) { }

	// RVA: 0x10797A8
	internal Int64 get_MinLength() { }

	// RVA: 0x10797B0
	internal void set_MinLength(Int64 value) { }

	// RVA: 0x10797B8
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x10797C0
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10797C8
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x10797D0
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0x10797D8
	internal void AddValue(string value) { }

	// RVA: 0x1079890
	internal System.Collections.Generic.List<System.String> get_Values() { }

	// RVA: 0x1079898
	internal void set_Values(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x10798A0
	internal string get_DefaultValueRaw() { }

	// RVA: 0x107990C
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x1079914
	internal object get_DefaultValueTyped() { }

	// RVA: 0x107991C
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0x1079924
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0x10799EC
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

	// RVA: 0x1079A44
	internal void .ctor() { }

	// RVA: 0x1079B74
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0x1079CFC
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1079DF0
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0x1079EF0
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x1079EF8
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x1079FB8
	private System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0x1079FC0
	internal bool get_IsIdDeclared() { }

	// RVA: 0x1079FC8
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0x1079FD0
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0x1079FD8
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0x1079FE0
	internal SchemaElementDecl Clone() { }

	// RVA: 0x107A048
	internal bool get_IsAbstract() { }

	// RVA: 0x107A050
	internal void set_IsAbstract(bool value) { }

	// RVA: 0x107A058
	internal bool get_IsNillable() { }

	// RVA: 0x107A060
	internal void set_IsNillable(bool value) { }

	// RVA: 0x107A068
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x107A070
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x107A078
	internal bool get_IsNotationDeclared() { }

	// RVA: 0x107A080
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0x107A088
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0x107A098
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x107A0A0
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x107A0A8
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x107A0B0
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x107A0B8
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x107A0C0
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x107A0C8
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x107A0D0
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x107A0D8
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x107A0E0
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0x107A20C
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x107A290
	internal System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x107A298
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttDefs() { }

	// RVA: 0x107A2A0
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0x107A2A8
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0x107A678
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

	// RVA: 0x107A6E0
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0x107A784
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0x107A7A4
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0x107A7AC
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x107A7B4
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x107A7DC
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0x107A7E4
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0x107A8BC
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x107A994
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x107A99C
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x107A9A4
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x107A9AC
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x107A9B4
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0x107A9BC
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x107AAC8
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x107AAD0
	internal string get_Url() { }

	// RVA: 0x107AAD8
	internal void set_Url(string value) { }

	// RVA: 0x107AB08
	internal string get_Pubid() { }

	// RVA: 0x107AB10
	internal void set_Pubid(string value) { }

	// RVA: 0x107AB18
	internal bool get_IsExternal() { }

	// RVA: 0x107AB20
	internal void set_IsExternal(bool value) { }

	// RVA: 0x107AB28
	internal bool get_DeclaredInExternal() { }

	// RVA: 0x107AB30
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x107AB38
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x107AB40
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x107AB48
	internal string get_Text() { }

	// RVA: 0x107AB50
	internal void set_Text(string value) { }

	// RVA: 0x107AB7C
	internal int get_Line() { }

	// RVA: 0x107AB84
	internal void set_Line(int value) { }

	// RVA: 0x107AB8C
	internal int get_Pos() { }

	// RVA: 0x107AB94
	internal void set_Pos(int value) { }

	// RVA: 0x107A850
	internal string get_BaseURI() { }

	// RVA: 0x107AB9C
	internal void set_BaseURI(string value) { }

	// RVA: 0x107ABA4
	internal bool get_ParsingInProgress() { }

	// RVA: 0x107ABAC
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0x107A928
	internal string get_DeclaredURI() { }

	// RVA: 0x107ABB4
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

	// RVA: 0x107ABBC
	internal void .ctor() { }

	// RVA: 0x107ADB0
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x107ADB8
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x107ADC0
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x107ADC8
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x107ADD0
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0x107ADD8
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_GeneralEntities() { }

	// RVA: 0x107AE74
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x107AF10
	internal SchemaType get_SchemaType() { }

	// RVA: 0x107AF18
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x107AF20
	internal System.Collections.Generic.Dictionary<System.String,System.Boolean> get_TargetNamespaces() { }

	// RVA: 0x107AF28
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x107AF30
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0x107AF38
	internal System.Collections.Generic.Dictionary<System.String,System.Xml.Schema.SchemaNotation> get_Notations() { }

	// RVA: 0x107AFD4
	internal int get_ErrorCount() { }

	// RVA: 0x107AFDC
	internal void set_ErrorCount(int value) { }

	// RVA: 0x107AFE4
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0x107B068
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0x107B0EC
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0x107B190
	internal bool HasSchema(string ns) { }

	// RVA: 0x107B1F4
	internal bool Contains(string ns) { }

	// RVA: 0x107B258
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0x107B3EC
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, AttributeMatchState attributeMatchState) { }

	// RVA: 0x107B660
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, bool skip) { }

	// RVA: 0x107B774
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0x107C754
	internal void Finish() { }

	// RVA: 0x107CAB0
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x107CAB8
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x107CAC0
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x107CB94
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x107CC64
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x107CC6C
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

	// RVA: 0x107CC74
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x107FA6C
	public void CreateTokenToQNameTable() { }

	// RVA: 0x108199C
	public SchemaType SchemaTypeFromRoot(string localName, string ns) { }

	// RVA: 0x1081A4C
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1081A9C
	public bool IsXDRRoot(string localName, string ns) { }

}

// Namespace: System.Xml.Schema
internal class SchemaNamespaceManager
{
	// Fields
	private XmlSchemaObject node; // 0x50

	// Methods

	// RVA: 0x1081AEC
	public void .ctor(XmlSchemaObject node) { }

	// RVA: 0x1081B20
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1081C70
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

	// RVA: 0x1082078
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x10820AC
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x10820B4
	internal string get_SystemLiteral() { }

	// RVA: 0x10820BC
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x10820C4
	internal string get_Pubid() { }

	// RVA: 0x10820CC
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

	// RVA: 0x10820D4
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1082324
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0x10854D0
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0x1087510
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0x1084390
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x1087698
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0x10823C8
	internal bool Compile() { }

	// RVA: 0x1086EB0
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1086F38
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1086F94
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1087458
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1086D00
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x108CC38
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1086EEC
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x108CD2C
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x108BC10
	private void ProcessSubstitutionGroups() { }

	// RVA: 0x108CED8
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x108CAC0
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0x108CBB0
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0x10877AC
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1088E6C
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x108E3AC
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x108E89C
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x1088278
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x108E9C4
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x108EC5C
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x108F110
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x108F5E4
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x108C470
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x108D85C
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1090FBC
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0x108D49C
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0x1093DD4
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0x1092B50
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0x10930DC
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0x10933A8
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0x10938D8
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0x1091D7C
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0x1091FD0
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1094170
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x10943B0
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x1094568
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x1094674
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x1094B3C
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0x1095C28
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0x109540C
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x10957C0
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x1095E24
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x10961F8
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1096CC0
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x1096DA8
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x10940A4
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x109649C
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x1096EA8
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x109113C
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x10878B4
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x108F980
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x108D948
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0x1097048
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0x1096F8C
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1096ED0
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x108A940
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x1097174
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0x108B394
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x108985C
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x10911D8
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x1097364
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x1097A38
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x108D6CC
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0x108BA98
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x108E2AC
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x1091CA0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x1091B10
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0x1094020
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0x10962E0
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

	// RVA: 0x1097CA8
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0x1097D28
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x1097DB4
	public XmlSeverityType get_Severity() { }

	// RVA: 0x1097DBC
	public XmlSchemaException get_Exception() { }

}

// Namespace: System.Xml.Schema
public sealed class ValidationEventHandler
{
	// Methods

	// RVA: 0x1097DC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1097EE8
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

	// RVA: 0x1097EFC
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

	// RVA: 0x109D2E8
	internal void .ctor() { }

	// RVA: 0x109D840
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

	// RVA: 0x10A2D18
	internal static void Copy(GroupContent from, GroupContent to) { }

	// RVA: 0x1099808
	internal static GroupContent Copy(GroupContent other) { }

	// RVA: 0x109822C
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

	// RVA: 0x109821C
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

	// RVA: 0x1098224
	public void .ctor() { }

}

// Namespace: 
private sealed class XdrBuildFunction
{
	// Methods

	// RVA: 0x10A2834
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10A2D44
	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }

}

// Namespace: 
private sealed class XdrInitFunction
{
	// Methods

	// RVA: 0x10A2AF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10A2D58
	public virtual void Invoke(XdrBuilder builder, object obj) { }

}

// Namespace: 
private sealed class XdrBeginChildFunction
{
	// Methods

	// RVA: 0x10A2BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10A2D6C
	public virtual void Invoke(XdrBuilder builder) { }

}

// Namespace: 
private sealed class XdrEndChildFunction
{
	// Methods

	// RVA: 0x10A2C64
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10A2D80
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

	// RVA: 0x10A28F0
	internal void .ctor(Token a, XmlTokenizedType ttype, XdrBuildFunction build) { }

	// RVA: 0x10A2998
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

	// RVA: 0x10A2A44
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

	// RVA: 0x1097F6C
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x1098234
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x109892C
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x10993F0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1098DBC
	private bool LoadSchema(string uri) { }

	// RVA: 0x1098CF8
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x1099538
	internal override bool IsContentParsed() { }

	// RVA: 0x1099540
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x109959C
	internal override void ProcessCData(string value) { }

	// RVA: 0x1099628
	internal override void StartChildren() { }

	// RVA: 0x1099664
	internal override void EndChildren() { }

	// RVA: 0x109872C
	private void Push() { }

	// RVA: 0x10996AC
	private void Pop() { }

	// RVA: 0x1099754
	private void PushGroupInfo() { }

	// RVA: 0x1099888
	private void PopGroupInfo() { }

	// RVA: 0x1099930
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0x109999C
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1099A44
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1099A48
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0x1099B50
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0x109A110
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0x109A240
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109A41C
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109A688
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109A814
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109AA18
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109ACB0
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109ADB0
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109AFA4
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109B198
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0x109B4B0
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0x109BA38
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0x109BB48
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109BDA4
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109BF6C
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109BF90
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109C22C
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109C32C
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109C3A8
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109C424
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0x109C4E4
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0x109C9F8
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0x109CAC8
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109CD18
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109CEFC
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109D0F0
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0x109D25C
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0x109D310
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109D3FC
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109D4B0
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109D4D4
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0x109D820
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0x109D944
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0x109DA40
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109DB74
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109DC04
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x109DC94
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0x109DE94
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x109DFB0
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0x109E0C4
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x109E178
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0x1098574
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x1098784
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x10992A0
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0x109A8C4
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0x109CC5C
	private void AddOrder() { }

	// RVA: 0x109BE24
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0x109CD98
	private static UInt32 ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x109CF7C
	private static UInt32 ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x109D22C
	private static void HandleMinMax(ParticleContentValidator pContent, UInt32 cMin, UInt32 cMax) { }

	// RVA: 0x109AE2C
	private static void ParseDtMaxLength(UInt32 cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x109B020
	private static void ParseDtMinLength(UInt32 cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x109B97C
	private static void CompareMinMaxLength(UInt32 cMin, UInt32 cMax, XdrBuilder builder) { }

	// RVA: 0x109E2B0
	private static bool ParseInteger(string str, UInt32 n) { }

	// RVA: 0x109A024
	private void XDR_CheckAttributeDefault(DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0x109C9A8
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0x109A4C4
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0x109A730
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0x109C054
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0x109C8BC
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0x1098CEC
	private bool IsGlobal(int flags) { }

	// RVA: 0x10993F8
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x109ABC4
	private void SendValidationEvent(string code) { }

	// RVA: 0x1098848
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x109E930
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x109EB70
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

	// RVA: 0x10A2D94
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x10A3020
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x10A2E20
	private void Init() { }

	// RVA: 0x10A325C
	public override void Validate() { }

	// RVA: 0x10A35F4
	private void ValidateElement() { }

	// RVA: 0x10A3978
	private void ValidateChildElement() { }

	// RVA: 0x10A3330
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x10A3340
	private void ProcessInlineSchema() { }

	// RVA: 0x10A3ABC
	private void ProcessElement() { }

	// RVA: 0x10A379C
	private void ValidateEndElement() { }

	// RVA: 0x10A3B7C
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x10A3EF0
	private void ValidateStartElement() { }

	// RVA: 0x10A436C
	private void ValidateEndStartElement() { }

	// RVA: 0x10A5114
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x10A4E18
	private void LoadSchema(string uri) { }

	// RVA: 0x10A57E0
	private bool get_HasSchema() { }

	// RVA: 0x10A5808
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x10A5844
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x10A5B60
	public override void CompleteValidation() { }

	// RVA: 0x10A4720
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x109E2EC
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x10A5AC0
	internal void AddID(string name, object node) { }

	// RVA: 0x10A5E54
	public override object FindId(string name) { }

	// RVA: 0x10A30C4
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x10A4D48
	private void Pop() { }

	// RVA: 0x10A5C30
	private void CheckForwardRefs() { }

	// RVA: 0x10A5038
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

	// RVA: 0x10A6570
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x10A7378
	public string LookupNamespace(string prefix) { }

	// RVA: 0x10A73B8
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x10A73F0
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

	// RVA: 0x10A5E70
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x10A5F0C
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x10A5FA8
	internal void .ctor(XmlSchemaType xmlType, Double value) { }

	// RVA: 0x10A6044
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x10A60E0
	internal void .ctor(XmlSchemaType xmlType, Int64 value) { }

	// RVA: 0x10A617C
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x10A623C
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10A65C0
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x10A6680
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10A68D4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10A68D8
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x10A68E0
	public override Type get_ValueType() { }

	// RVA: 0x10A690C
	public override object get_TypedValue() { }

	// RVA: 0x10A6AFC
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x10A6BF4
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x10A6D00
	public override Double get_ValueAsDouble() { }

	// RVA: 0x10A6E0C
	public override int get_ValueAsInt() { }

	// RVA: 0x10A6F0C
	public override Int64 get_ValueAsLong() { }

	// RVA: 0x10A7018
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10A724C
	public override string get_Value() { }

	// RVA: 0x10A736C
	public override string ToString() { }

	// RVA: 0x10A644C
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

	// RVA: 0x10A7498
	public void .ctor() { }

	// RVA: 0x10A7680
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x10A784C
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x10A7A60
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x10A7B10
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0x10A7B18
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x10A7B20
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x10A7B28
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10A7B30
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x10A7B38
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10A7B40
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x10A7B48
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x10A7B50
	public string get_TargetNamespace() { }

	// RVA: 0x10A7B58
	public void set_TargetNamespace(string value) { }

	// RVA: 0x10A7B60
	public string get_Version() { }

	// RVA: 0x10A7B68
	public void set_Version(string value) { }

	// RVA: 0x10A7B70
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x10A7B78
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10A7B80
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x10A7B88
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x10A7B90
	internal bool get_IsPreprocessed() { }

	// RVA: 0x10A7B98
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x10A7BA0
	internal bool get_IsRedefined() { }

	// RVA: 0x10A7BA8
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x10A7BB0
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x10A7C38
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x10A7CC0
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x10A7D48
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x10A7DD0
	public string get_Id() { }

	// RVA: 0x10A7DD8
	public void set_Id(string value) { }

	// RVA: 0x10A7DE0
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x10A7DE8
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x10A7DF0
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0x10A7DF8
	internal Uri get_BaseUri() { }

	// RVA: 0x10A7E00
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x10A7E08
	internal int get_SchemaId() { }

	// RVA: 0x10A7E94
	internal bool get_IsChameleon() { }

	// RVA: 0x10A7E9C
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x10A7EA4
	internal Hashtable get_Ids() { }

	// RVA: 0x10A7EAC
	internal XmlDocument get_Document() { }

	// RVA: 0x10A7F34
	internal int get_ErrorCount() { }

	// RVA: 0x10A7F3C
	internal void set_ErrorCount(int value) { }

	// RVA: 0x10A7F44
	internal XmlSchema Clone() { }

	// RVA: 0x10A8100
	internal XmlSchema DeepClone() { }

	// RVA: 0x10A9278
	internal override string get_IdAttribute() { }

	// RVA: 0x10A9280
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10A9288
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x10A9290
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10A9298
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x10A9360
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x10A93E8
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x10A9470
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x10A966C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAll
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x10A96BC
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10A96C4
	internal override bool get_IsEmpty() { }

	// RVA: 0x10A9718
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10A9720
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

	// RVA: 0x10A987C
	public string get_Id() { }

	// RVA: 0x10A9884
	public void set_Id(string value) { }

	// RVA: 0x10A988C
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x10A9894
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x10A989C
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x10A98A4
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x10A98AC
	internal override string get_IdAttribute() { }

	// RVA: 0x10A98B4
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10A98BC
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10A98C4
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x10A98CC
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

	// RVA: 0x10A98D4
	public string get_Id() { }

	// RVA: 0x10A98DC
	public void set_Id(string value) { }

	// RVA: 0x10A98E4
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10A98EC
	internal override string get_IdAttribute() { }

	// RVA: 0x10A98F4
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10A98FC
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10A9904
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

	// RVA: 0x10A997C
	public string get_Namespace() { }

	// RVA: 0x10A9984
	public void set_Namespace(string value) { }

	// RVA: 0x10A998C
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x10A9994
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x10A999C
	internal string get_ResolvedNamespace() { }

	// RVA: 0x10A99F8
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x10A9A0C
	internal override string get_NameString() { }

	// RVA: 0x10A9EFC
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x10A9F88
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x10AA034
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x10AA060
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

	// RVA: 0x10AA0E8
	public void set_Namespace(string value) { }

	// RVA: 0x10AA0F0
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0x10AA0F8
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x10AA100
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x10AA108
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x10AA11C
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x10AA1A8
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x10AA254
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x10AA280
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x10AA2A8
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x10AA388
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x10AA380
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAppInfo
{
	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Methods

	// RVA: 0x10AA460
	public void set_Source(string value) { }

	// RVA: 0x10AA468
	public XmlNode[] get_Markup() { }

	// RVA: 0x10AA470
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x10AA478
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

	// RVA: 0x10AA480
	public string get_DefaultValue() { }

	// RVA: 0x10AA488
	public void set_DefaultValue(string value) { }

	// RVA: 0x10AA490
	public string get_FixedValue() { }

	// RVA: 0x10AA498
	public void set_FixedValue(string value) { }

	// RVA: 0x10AA4A0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x10AA4A8
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x10AA4B0
	public string get_Name() { }

	// RVA: 0x10AA4B8
	public void set_Name(string value) { }

	// RVA: 0x10AA4C0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10AA4C8
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10AA5A0
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x10AA5A8
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x10AA680
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x10AA688
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x10AA690
	public XmlSchemaUse get_Use() { }

	// RVA: 0x10AA698
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x10AA6A0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10AA6A8
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x10AA6B0
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x10AA6C8
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10AA6D0
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x10AA6D8
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x10AA6E0
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x10AA6E8
	internal override string get_NameAttribute() { }

	// RVA: 0x10AA6F0
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10AA6F8
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10AA800
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

	// RVA: 0x10AA8AC
	public string get_Name() { }

	// RVA: 0x10AA8B4
	public void set_Name(string value) { }

	// RVA: 0x10AA8BC
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10AA8C4
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10AA8CC
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10AA8D4
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10AA8DC
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x10AA964
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x10AA96C
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10AA974
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x10AA97C
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x10AA984
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x10AA98C
	internal int get_SelfReferenceCount() { }

	// RVA: 0x10AA994
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x10AA99C
	internal override string get_NameAttribute() { }

	// RVA: 0x10AA9A4
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10AA9AC
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10AA9B4
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10AAF14
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroupRef
{
	// Fields
	private XmlQualifiedName refName; // 0x50

	// Methods

	// RVA: 0x10AAFC8
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10AAFD0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10AB0A8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaChoice
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x10AB124
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10AB12C
	internal override bool get_IsEmpty() { }

	// RVA: 0x10AB134
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10AB13C
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

	// RVA: 0x10AB210
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x10AB360
	public int get_Count() { }

	// RVA: 0x10AB388
	public XmlNameTable get_NameTable() { }

	// RVA: 0x10AB390
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10AB398
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x10AB454
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x10AB538
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x10AB5CC
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x10AB99C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x10AB9A4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x10AB9A8
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x10A5724
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x10AB9D0
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x10A3B74
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x10ABA90
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x10ABC18
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x10ABD7C
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x10ABD84
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

	// RVA: 0x10ABD8C
	internal void set_NamespaceURI(string value) { }

	// RVA: 0x10ABD94
	internal SchemaInfo get_SchemaInfo() { }

	// RVA: 0x10ABD9C
	internal void set_SchemaInfo(SchemaInfo value) { }

	// RVA: 0x10ABDA4
	internal XmlSchema get_Schema() { }

	// RVA: 0x10ABDAC
	internal void set_Schema(XmlSchema value) { }

	// RVA: 0x10ABC10
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCollectionEnumerator
{
	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x10AB4E8
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x10ABDB4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x10ABE6C
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x10AB8E8
	public bool MoveNext() { }

	// RVA: 0x10ABF20
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x10AB7F4
	public XmlSchema get_Current() { }

	// RVA: 0x10ABF24
	internal XmlSchemaCollectionNode get_CurrentNode() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCompilationSettings
{
	// Fields
	private bool enableUpaCheck; // 0x10

	// Methods

	// RVA: 0x10AC00C
	public void .ctor() { }

	// RVA: 0x10AC038
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

	// RVA: 0x10AC040
	public bool get_IsMixed() { }

	// RVA: 0x10AC048
	public void set_IsMixed(bool value) { }

	// RVA: 0x10AC058
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x10AC060
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x10AC068
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x10AC070
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

	// RVA: 0x10AC080
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10AC088
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10AC160
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x10AC168
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x10AC170
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10AC178
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10AC180
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10AC188
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10AC190
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

	// RVA: 0x10AC24C
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10AC254
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10AC32C
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x10AC334
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x10AC33C
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10AC344
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10AC34C
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10AC354
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10AC35C
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

	// RVA: 0x10AC410
	private static void .cctor() { }

	// RVA: 0x10AC700
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x10ACC6C
	public void .ctor() { }

	// RVA: 0x10ACD80
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x10ACDFC
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x10ACCF0
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x10ACE78
	public bool get_IsAbstract() { }

	// RVA: 0x10ACE84
	public void set_IsAbstract(bool value) { }

	// RVA: 0x10ACEA4
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x10ACEAC
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10ACEB4
	public override bool get_IsMixed() { }

	// RVA: 0x10ACEC0
	public override void set_IsMixed(bool value) { }

	// RVA: 0x10ACEE0
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x10ACEE8
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x10ACEF0
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x10ACEF8
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x10ACF00
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10ACF88
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10ACF90
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10ACF98
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x10ACFA0
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0x10ACFA8
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x10ACFB0
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x10AD038
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x10AD040
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x10AD0C8
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x10AD0D0
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10AD0D8
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10AD0E0
	internal void set_HasWildCard(bool value) { }

	// RVA: 0x10AD0F4
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10AD0FC
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x10AD664
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10A85B8
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10ADBB8
	private void ClearCompiledState() { }

	// RVA: 0x10AAC50
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x10ADCF0
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x10AD8F4
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x10ADF6C
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x10AD66C
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x10AAAE4
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContent
{
	// Methods

	// RVA: 0x10AC244
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

	// RVA: 0x10AC078
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

	// RVA: 0x10ADF98
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x10ADFA0
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: 0x10ADFA8
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

	// RVA: 0x10ADFB0
	internal string get_TypeCodeString() { }

	// RVA: 0x10AE0E8
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x10AE854
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x109C834
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x10AEF64
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x109AC28
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x10AEFEC
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x10983B0
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x10AF058
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

	// RVA: 0x10AF060
	public void set_Source(string value) { }

	// RVA: 0x10AF068
	public void set_Language(string value) { }

	// RVA: 0x10AF180
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x10AF188
	public void .ctor() { }

	// RVA: 0x10AF190
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

	// RVA: 0x10AF280
	public bool get_IsAbstract() { }

	// RVA: 0x10AF288
	public void set_IsAbstract(bool value) { }

	// RVA: 0x10AF298
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x10AF2A0
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10AF2A8
	public string get_DefaultValue() { }

	// RVA: 0x10AF2B0
	public void set_DefaultValue(string value) { }

	// RVA: 0x10AF2B8
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x10AF2C0
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10AF2C8
	public string get_FixedValue() { }

	// RVA: 0x10AF2D0
	public void set_FixedValue(string value) { }

	// RVA: 0x10AF2D8
	public XmlSchemaForm get_Form() { }

	// RVA: 0x10AF2E0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x10AF2E8
	public string get_Name() { }

	// RVA: 0x10AF2F0
	public void set_Name(string value) { }

	// RVA: 0x10AF2F8
	public bool get_IsNillable() { }

	// RVA: 0x10AF300
	public void set_IsNillable(bool value) { }

	// RVA: 0x10AF310
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x10AF318
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x10AF320
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10AF328
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10AF400
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x10AF408
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x10AF4E0
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x10AF4E8
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x10AF5C0
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x10AF5C8
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10AF5D0
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0x10AF658
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10AF660
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x10AF668
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x10AF670
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x10AF678
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10AF680
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x10AF688
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10AF690
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10AF698
	internal bool get_HasConstraints() { }

	// RVA: 0x10AF6C0
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x10AF6C8
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x10AF6D0
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x10AF6D8
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x10AF6E0
	internal override string get_NameAttribute() { }

	// RVA: 0x10AF6E8
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10AF6F0
	internal override string get_NameString() { }

	// RVA: 0x10AF714
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10A8D5C
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10AF71C
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

	// RVA: 0x10AF824
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10AFCFC
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10AFE70
	public void .ctor() { }

	// RVA: 0x10AFE84
	public void .ctor(string message) { }

	// RVA: 0x10AFFE0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x10AFE94
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x10B00A8
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x10A5D58
	internal void .ctor(string res, string arg) { }

	// RVA: 0x109EA60
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10B0140
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x109E884
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10B01E8
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x10B02B0
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x10B01F4
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x10AFFEC
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x10AFC30
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x10B0354
	internal string get_GetRes() { }

	// RVA: 0x10B035C
	internal string[] get_Args() { }

	// RVA: 0x10B0364
	public string get_SourceUri() { }

	// RVA: 0x10B036C
	public int get_LineNumber() { }

	// RVA: 0x10B0374
	public int get_LinePosition() { }

	// RVA: 0x10B037C
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x10A50D8
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10B0384
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x10B038C
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x10B03D4
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

	// RVA: 0x10B03EC
	public string get_SchemaLocation() { }

	// RVA: 0x10B03F4
	public void set_SchemaLocation(string value) { }

	// RVA: 0x10B03FC
	public XmlSchema get_Schema() { }

	// RVA: 0x10B0404
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x10B040C
	public string get_Id() { }

	// RVA: 0x10B0414
	public void set_Id(string value) { }

	// RVA: 0x10B041C
	internal Uri get_BaseUri() { }

	// RVA: 0x10B0424
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x10B042C
	internal override string get_IdAttribute() { }

	// RVA: 0x10B0434
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x10B043C
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10B0444
	internal Compositor get_Compositor() { }

	// RVA: 0x10B044C
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x10B0454
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

	// RVA: 0x10B045C
	public string get_Value() { }

	// RVA: 0x10B0464
	public void set_Value(string value) { }

	// RVA: 0x10B046C
	public virtual bool get_IsFixed() { }

	// RVA: 0x10B0474
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x10B0530
	internal FacetType get_FacetType() { }

	// RVA: 0x10B0538
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x10B0540
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaNumericFacet
{
	// Methods

	// RVA: 0x10B0548
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaLengthFacet
{
	// Methods

	// RVA: 0x10B0550
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinLengthFacet
{
	// Methods

	// RVA: 0x10B057C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxLengthFacet
{
	// Methods

	// RVA: 0x10B05A8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaPatternFacet
{
	// Methods

	// RVA: 0x10B05D4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaEnumerationFacet
{
	// Methods

	// RVA: 0x10B0600
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinExclusiveFacet
{
	// Methods

	// RVA: 0x10B062C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinInclusiveFacet
{
	// Methods

	// RVA: 0x10B0658
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxExclusiveFacet
{
	// Methods

	// RVA: 0x10B0684
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxInclusiveFacet
{
	// Methods

	// RVA: 0x10B06B0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaTotalDigitsFacet
{
	// Methods

	// RVA: 0x10B06DC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaFractionDigitsFacet
{
	// Methods

	// RVA: 0x10B0708
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaWhiteSpaceFacet
{
	// Methods

	// RVA: 0x10B0734
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

	// RVA: 0x10B0760
	public string get_Name() { }

	// RVA: 0x10B0768
	public void set_Name(string value) { }

	// RVA: 0x10B0770
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x10B0778
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x10B0780
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10B0788
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x10B0790
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x10B0798
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x10B07A0
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x10B07A8
	internal int get_SelfReferenceCount() { }

	// RVA: 0x10B07B0
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x10B07B8
	internal override string get_NameAttribute() { }

	// RVA: 0x10B07C0
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10B07C8
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10B07D0
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10A8F98
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10B07D8
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

	// RVA: 0x10A97F4
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

	// RVA: 0x10B0854
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x10ADE94
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x10B085C
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x10B0864
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x10B086C
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x10B0874
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x10B087C
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

	// RVA: 0x10B0934
	public string get_Name() { }

	// RVA: 0x10B093C
	public void set_Name(string value) { }

	// RVA: 0x10B0944
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x10B094C
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x10B0954
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x10B095C
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10B0964
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10B096C
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x10B0974
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x10B097C
	internal override string get_NameAttribute() { }

	// RVA: 0x10B0984
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10B098C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaXPath
{
	// Fields
	private string xpath; // 0x50

	// Methods

	// RVA: 0x10B0A40
	public string get_XPath() { }

	// RVA: 0x10B0A48
	public void set_XPath(string value) { }

	// RVA: 0x10B0A50
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaUnique
{
	// Methods

	// RVA: 0x10B0A58
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaKey
{
	// Methods

	// RVA: 0x10B0A5C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaKeyref
{
	// Fields
	private XmlQualifiedName refer; // 0x78

	// Methods

	// RVA: 0x10B0A60
	public XmlQualifiedName get_Refer() { }

	// RVA: 0x10B0A68
	public void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x10B0B40
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaImport
{
	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Methods

	// RVA: 0x10B0BB8
	public void .ctor() { }

	// RVA: 0x10B0BE4
	public string get_Namespace() { }

	// RVA: 0x10B0BEC
	public void set_Namespace(string value) { }

	// RVA: 0x10B0BF4
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaInclude
{
	// Fields
	private XmlSchemaAnnotation annotation; // 0x68

	// Methods

	// RVA: 0x10B0BFC
	public void .ctor() { }

	// RVA: 0x10B0C28
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

	// RVA: 0x10B0C30
	public void .ctor() { }

	// RVA: 0x10B0D0C
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x10B0D80
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0x10B0D88
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x10B0D90
	public bool get_IsDefault() { }

	// RVA: 0x10B0D98
	public void set_IsDefault(bool value) { }

	// RVA: 0x10B0DA0
	public bool get_IsNil() { }

	// RVA: 0x10B0DA8
	public void set_IsNil(bool value) { }

	// RVA: 0x10B0DB0
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x10B0DB8
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x10B0DC0
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x10B0DC8
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10B0E18
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x10B0E20
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x10B0E64
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x10B0E6C
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x10B0EB0
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x10B0EB8
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x10B0ED4
	internal bool get_HasDefaultValue() { }

	// RVA: 0x10B0F10
	internal bool get_IsUnionType() { }

	// RVA: 0x10B0CA4
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

	// RVA: 0x10B0F50
	public string get_Name() { }

	// RVA: 0x10B0F58
	public void set_Name(string value) { }

	// RVA: 0x10B0F60
	public string get_Public() { }

	// RVA: 0x10B0F68
	public void set_Public(string value) { }

	// RVA: 0x10B0F70
	public string get_System() { }

	// RVA: 0x10B0F78
	public void set_System(string value) { }

	// RVA: 0x10B0F80
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10B0F88
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10B0F90
	internal override string get_NameAttribute() { }

	// RVA: 0x10B0F98
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10B0FA0
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

	// RVA: 0x10B101C
	public int get_LineNumber() { }

	// RVA: 0x10B1024
	public void set_LineNumber(int value) { }

	// RVA: 0x10B102C
	public int get_LinePosition() { }

	// RVA: 0x10B1034
	public void set_LinePosition(int value) { }

	// RVA: 0x10B103C
	public string get_SourceUri() { }

	// RVA: 0x10B1044
	public void set_SourceUri(string value) { }

	// RVA: 0x10B104C
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x10B1054
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x10A8078
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x10B105C
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x10B1064
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x10B1068
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x10B106C
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x10B1070
	internal virtual string get_IdAttribute() { }

	// RVA: 0x10B1078
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x10B107C
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10B1080
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x10B1084
	internal virtual string get_NameAttribute() { }

	// RVA: 0x10B108C
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x10B1090
	internal bool get_IsProcessing() { }

	// RVA: 0x10B1098
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x10B10A0
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x10A7678
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectCollection
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Methods

	// RVA: 0x10A7670
	public void .ctor() { }

	// RVA: 0x10B1124
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x10B1244
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x10B1310
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x10A91B4
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x10B1390
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x10B145C
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x10B1520
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x10B153C
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x10B159C
	protected override void OnClear() { }

	// RVA: 0x10B15B8
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x10ADC64
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x10B15D4
	private void Add(XmlSchemaObjectCollection collToAdd) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x10B1604
	internal void .ctor(IEnumerator enumerator) { }

	// RVA: 0x10B1638
	public bool MoveNext() { }

	// RVA: 0x10B16EC
	public XmlSchemaObject get_Current() { }

	// RVA: 0x10B17F0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x10B18A8
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x10B195C
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

	// RVA: 0x10B1BC8
	public void .ctor(XmlQualifiedName name, XmlSchemaObject value) { }

}

// Namespace: 
internal class ValuesCollection
{
	// Fields
	private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private int size; // 0x18

	// Methods

	// RVA: 0x10B23E0
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x10B2530
	public int get_Count() { }

	// RVA: 0x10B2538
	public object get_SyncRoot() { }

	// RVA: 0x10B25F0
	public bool get_IsSynchronized() { }

	// RVA: 0x10B26A8
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x10B27F8
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

	// RVA: 0x10B2884
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

	// RVA: 0x10B28D8
	public object get_Current() { }

	// RVA: 0x10B2AB8
	public bool MoveNext() { }

	// RVA: 0x10B2BA8
	public void Reset() { }

}

// Namespace: 
internal class XSODictionaryEnumerator
{
	// Methods

	// RVA: 0x10B24DC
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

	// RVA: 0x10B2BE4
	public DictionaryEntry get_Entry() { }

	// RVA: 0x10B2D34
	public object get_Key() { }

	// RVA: 0x10B2E68
	public object get_Value() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectTable
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaObject> table; // 0x10
	private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Methods

	// RVA: 0x10B1A14
	internal void .ctor() { }

	// RVA: 0x10B1AF4
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x10B1BFC
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x10B1E58
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x10B1FF0
	internal void Clear() { }

	// RVA: 0x10B20B4
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x10B1DA8
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x10B21FC
	public int get_Count() { }

	// RVA: 0x10B2250
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x10B22B4
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x10B2338
	public ICollection get_Values() { }

	// RVA: 0x10B2428
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

	// RVA: 0x10B3CF4
	internal override bool get_IsEmpty() { }

	// RVA: 0x10B3C0C
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

	// RVA: 0x10B2F9C
	public string get_MinOccursString() { }

	// RVA: 0x10B3038
	public void set_MinOccursString(string value) { }

	// RVA: 0x10B31A0
	public string get_MaxOccursString() { }

	// RVA: 0x10B32EC
	public void set_MaxOccursString(string value) { }

	// RVA: 0x10B3518
	public Decimal get_MinOccurs() { }

	// RVA: 0x10B3524
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0x10B365C
	public Decimal get_MaxOccurs() { }

	// RVA: 0x10B3668
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x10B37E0
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x10B3858
	internal virtual string get_NameString() { }

	// RVA: 0x10B38A4
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x10B3A4C
	protected void .ctor() { }

	// RVA: 0x10B3ACC
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

	// RVA: 0x10B3CFC
	public void .ctor() { }

	// RVA: 0x10B3DF4
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10B3DFC
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x10B3E04
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x10B3E0C
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x10B3E14
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSequence
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x10B3E34
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10B3E3C
	internal override bool get_IsEmpty() { }

	// RVA: 0x10B3EEC
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10B3EF4
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

	// RVA: 0x10B3F6C
	internal object get_InternalSyncObject() { }

	// RVA: 0x10B3FF4
	public void .ctor() { }

	// RVA: 0x10B405C
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x10B4360
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10B4488
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10B4564
	public bool get_IsCompiled() { }

	// RVA: 0x10B456C
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10B458C
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x10B4594
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x10B459C
	public int get_Count() { }

	// RVA: 0x10B45C4
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x10B4648
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x10B46CC
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x10B4750
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x10B47D4
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x10B47DC
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x10B4860
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x10B7228
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x10B7484
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x10B8514
	public bool Contains(string targetNamespace) { }

	// RVA: 0x10B85A8
	public void Compile() { }

	// RVA: 0x10B8D74
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x10BAB74
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x10BACF0
	public ICollection Schemas() { }

	// RVA: 0x10BA88C
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x10B71B8
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x10BB1E4
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x10B6F3C
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x10BAD18
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x10BBB58
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x10BC088
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x10B80FC
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x10B8B74
	private void ClearTables() { }

	// RVA: 0x10BAA48
	internal bool PreprocessSchema(XmlSchema schema, string targetNamespace) { }

	// RVA: 0x10BB948
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x10B5290
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x10BCAE0
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x10BCAE8
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x10BCAF0
	internal XmlResolver GetResolver() { }

	// RVA: 0x10BCB10
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x10BC8B4
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x10BB5B8
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, XmlSchema schema) { }

	// RVA: 0x10BCB18
	internal bool GetSchemaByUri(Uri schemaUri, XmlSchema schema) { }

	// RVA: 0x10B7FE4
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x10BCCB0
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x10BA25C
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x10B96B4
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x10BC508
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x10BC974
	private void VerifyTables() { }

	// RVA: 0x10BCCB8
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x10B8050
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContent
{
	// Fields
	private XmlSchemaContent content; // 0x50

	// Methods

	// RVA: 0x10BCD08
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x10BCD10
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x10BCD18
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

	// RVA: 0x10BCD20
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10BCD28
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10BCE00
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10BCE08
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10BCE10
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10BCE18
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10BCE20
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

	// RVA: 0x10BCED4
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10BCEDC
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10BCFB4
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x10BCFBC
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x10BCFC4
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x10BCFCC
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10BCFD4
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10BCFDC
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10BCFE4
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10BCFEC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleType
{
	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Methods

	// RVA: 0x10BD0C4
	public void .ctor() { }

	// RVA: 0x10BD1DC
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x10BD1E4
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0x10BD1EC
	internal override XmlSchemaObject Clone() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaSimpleTypeContent
{
	// Methods

	// RVA: 0x10BD2FC
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

	// RVA: 0x10BD304
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0x10BD30C
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x10BD3E4
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x10BD3EC
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x10BD3F4
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x10BD3FC
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x10BD404
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10BD4C8
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

	// RVA: 0x10BD544
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10BD54C
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10BD624
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x10BD62C
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x10BD634
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x10BD63C
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10BD700
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

	// RVA: 0x10BD7B4
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x10BD7BC
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x10BD7C4
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x10BD7CC
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x10BD7D4
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0x10BD7DC
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x10BD9A0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroup
{
	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Methods

	// RVA: 0x10BDA18
	internal ArrayList get_Members() { }

	// RVA: 0x10BDA20
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x10BDA28
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0x10BDA30
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroupV1Compat
{
	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Methods

	// RVA: 0x10BDAE4
	internal XmlSchemaChoice get_Choice() { }

	// RVA: 0x10BDAEC
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

	// RVA: 0x10BDB60
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x10BDC7C
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0x10BDD04
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x10BE004
	public string get_Name() { }

	// RVA: 0x10BE00C
	public void set_Name(string value) { }

	// RVA: 0x10BE014
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x10BE01C
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10BCABC
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10BE024
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x10BE02C
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x10BE034
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x10BE03C
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x10BE044
	public virtual bool get_IsMixed() { }

	// RVA: 0x10BE04C
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0x10BE050
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0x10BE148
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0x10BE1D8
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0x10BE1E0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10BE210
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10BE218
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x10BE220
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10BE228
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0x10BE230
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x10BE254
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x10BE284
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x10BE28C
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0x10BE294
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0x10BE29C
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x10BE514
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x10BE620
	internal override string get_NameAttribute() { }

	// RVA: 0x10BE628
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x10BD150
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

	// RVA: 0x10BE630
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10BE638
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10BE640
	public void .ctor() { }

	// RVA: 0x10BE64C
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10BE720
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10BE754
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Schema
public sealed class XmlValueGetter
{
	// Methods

	// RVA: 0x10BE778
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10BE818
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

	// RVA: 0x10BE82C
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

	// RVA: 0x10BE890
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0x10BEAC4
	private void Init() { }

	// RVA: 0x10BEFF8
	private void Reset() { }

	// RVA: 0x10BF184
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10BF18C
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0x10BF1A4
	public void set_SourceUri(Uri value) { }

	// RVA: 0x10BF1F4
	public void set_ValidationEventSender(object value) { }

	// RVA: 0x10BF1FC
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10BF2B0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x10BF364
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0x10BFB74
	public void Initialize() { }

	// RVA: 0x10BFCB8
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0x10BFF70
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x10C1CD8
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10C1D3C
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10C3258
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10C35C0
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0x10C3624
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x10C4000
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0x10C4064
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x10C42D8
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10C47EC
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x10C4B74
	public void EndValidation() { }

	// RVA: 0x10C4DF0
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x10C59D8
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x10C59E0
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x10C59E8
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0x10C5A24
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0x10C5A54
	private bool get_StrictlyAssessed() { }

	// RVA: 0x10C5AA0
	private bool get_HasSchema() { }

	// RVA: 0x10C5AF4
	internal string GetConcatenatedValue() { }

	// RVA: 0x10C42E0
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0x10C0D7C
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x10C05F8
	private object ValidateElementContext(XmlQualifiedName elementName, bool invalidElementInContext) { }

	// RVA: 0x10C7920
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0x10C5B18
	private object ValidateAtomicValue(string stringValue, XmlSchemaSimpleType memberType) { }

	// RVA: 0x10C5E04
	private object ValidateAtomicValue(object parsedValue, XmlSchemaSimpleType memberType) { }

	// RVA: 0x10C89A0
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0x10C3A78
	private void SaveTextValue(object value) { }

	// RVA: 0x10BEE88
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x10C4A00
	private void Pop() { }

	// RVA: 0x10C0AF4
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0x10C10CC
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, bool declFound) { }

	// RVA: 0x10C17F8
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0x10C1A20
	private void CheckElementProperties() { }

	// RVA: 0x10C1B28
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x10C2904
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0x10C92C8
	private void AddXmlNamespaceSchema() { }

	// RVA: 0x10C61D0
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0x10C7408
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x10BF0A4
	internal void RecompileSchemaSet() { }

	// RVA: 0x10C9584
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0x10C2B8C
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0x10C86D0
	private object CheckElementValue(string stringValue) { }

	// RVA: 0x10C2DF0
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0x10C987C
	private object FindId(string name) { }

	// RVA: 0x10C4C64
	private void CheckForwardRefs() { }

	// RVA: 0x10C2F80
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x10C8A70
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0x10C9B74
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0x10BF174
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0x10C0364
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0x10C05A0
	private void ClearPSVI() { }

	// RVA: 0x10C3340
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0x10C1B94
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0x10C54FC
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0x10C8A7C
	private void AddIdentityConstraints() { }

	// RVA: 0x10C8EDC
	private void ElementIdentityConstraints() { }

	// RVA: 0x10C2FA0
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0x10C6820
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0x10C7D88
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x10C62D8
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x10C3C1C
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0x10CA174
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0x10C9C4C
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0x10CA2FC
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0x10C39F4
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0x10C7B00
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0x10C3AC0
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0x10C9898
	private void ProcessEntity(string name) { }

	// RVA: 0x10C8A0C
	private void SendValidationEvent(string code) { }

	// RVA: 0x10C29E8
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x10C26F8
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0x10C7B7C
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0x10C93A0
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0x10BF9C4
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0x10C9B80
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0x10C7868
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x10BF784
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x10C9A38
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x10C9B88
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x10CA540
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

	// RVA: 0x10CA9C0
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

	// RVA: 0x10CA9C8
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10CABDC
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x10CACCC
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x10CAD48
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x10CADA8
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x10CAEA8
	public override bool ToBoolean(Double value) { }

	// RVA: 0x10CAFA8
	public override bool ToBoolean(int value) { }

	// RVA: 0x10CB0A8
	public override bool ToBoolean(Int64 value) { }

	// RVA: 0x10CB1A8
	public override bool ToBoolean(string value) { }

	// RVA: 0x10CB270
	public override bool ToBoolean(object value) { }

	// RVA: 0x10CB338
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x10CB438
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x10CB53C
	public override DateTime ToDateTime(Double value) { }

	// RVA: 0x10CB63C
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x10CB73C
	public override DateTime ToDateTime(Int64 value) { }

	// RVA: 0x10CB83C
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x10CB904
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x10CB9CC
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x10CBAD0
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x10CBB9C
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10CBC68
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x10CBD34
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x10CBE00
	public override Double ToDouble(bool value) { }

	// RVA: 0x10CBF00
	public override Double ToDouble(DateTime value) { }

	// RVA: 0x10CC000
	public override Double ToDouble(int value) { }

	// RVA: 0x10CC100
	public override Double ToDouble(Int64 value) { }

	// RVA: 0x10CC200
	public override Double ToDouble(string value) { }

	// RVA: 0x10CC2C8
	public override Double ToDouble(object value) { }

	// RVA: 0x10CC390
	public override int ToInt32(bool value) { }

	// RVA: 0x10CC490
	public override int ToInt32(DateTime value) { }

	// RVA: 0x10CC590
	public override int ToInt32(Double value) { }

	// RVA: 0x10CC690
	public override int ToInt32(Int64 value) { }

	// RVA: 0x10CC790
	public override int ToInt32(string value) { }

	// RVA: 0x10CC858
	public override int ToInt32(object value) { }

	// RVA: 0x10CC920
	public override Int64 ToInt64(bool value) { }

	// RVA: 0x10CCA20
	public override Int64 ToInt64(DateTime value) { }

	// RVA: 0x10CCB20
	public override Int64 ToInt64(Double value) { }

	// RVA: 0x10CCC20
	public override Int64 ToInt64(int value) { }

	// RVA: 0x10CCD20
	public override Int64 ToInt64(string value) { }

	// RVA: 0x10CCDE8
	public override Int64 ToInt64(object value) { }

	// RVA: 0x10CCEB0
	public override float ToSingle(Double value) { }

	// RVA: 0x10CCFB0
	public override float ToSingle(string value) { }

	// RVA: 0x10CD078
	public override float ToSingle(object value) { }

	// RVA: 0x10CD140
	public override string ToString(bool value) { }

	// RVA: 0x10CD22C
	public override string ToString(DateTime value) { }

	// RVA: 0x10CD318
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x10CD408
	public override string ToString(Decimal value) { }

	// RVA: 0x10CD524
	public override string ToString(Double value) { }

	// RVA: 0x10CD610
	public override string ToString(int value) { }

	// RVA: 0x10CD6FC
	public override string ToString(Int64 value) { }

	// RVA: 0x10CD7E8
	public override string ToString(float value) { }

	// RVA: 0x10CD8D4
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10CD994
	public override string ToString(object value) { }

	// RVA: 0x10CD9A8
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10CDA3C
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10CDAD0
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10CDB94
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10CDC28
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10CDCBC
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10CDD50
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10CDD60
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x10CDD74
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x10CDD7C
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x10CDD84
	protected string get_XmlTypeName() { }

	// RVA: 0x10CDFF0
	protected Type get_DefaultClrType() { }

	// RVA: 0x10CDFF8
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x10CE0D4
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x10CDEBC
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x10CE378
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10CE3D4
	protected static Byte[] StringToBase64Binary(string value) { }

	// RVA: 0x10CE484
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x10CE50C
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x10CE594
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x10CE5EC
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x10CE644
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x10CE6CC
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x10CE754
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x10CE7DC
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x10CE864
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x10CE8EC
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x10CE974
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x10CE9FC
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x10CEA84
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x10CEB0C
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x10CEB94
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x10CEC1C
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x10CECA4
	protected static Byte[] StringToHexBinary(string value) { }

	// RVA: 0x10CEDE8
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10CF0C8
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x10CF150
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x10CF1D8
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x10CF230
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x10CF248
	protected static string Base64BinaryToString(Byte[] value) { }

	// RVA: 0x10CF2D0
	protected static string DateToString(DateTime value) { }

	// RVA: 0x10CF360
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x10CF3F0
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x10CF448
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x10CF4A0
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x10CF530
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x10CF5C0
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x10CF650
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x10CF6E0
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x10CF770
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10CF808
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10CF8A0
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10CF938
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10CF9D0
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10CFA68
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10CFB00
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10CFB98
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10CFDD0
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x10CFE60
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10CFEF8
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x10CFF50
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x10CFFB8
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x10D01A0
	protected static Int64 DecimalToInt64(Decimal value) { }

	// RVA: 0x10D0388
	protected static UInt64 DecimalToUInt64(Decimal value) { }

	// RVA: 0x10D0564
	protected static Byte Int32ToByte(int value) { }

	// RVA: 0x10D0650
	protected static Int16 Int32ToInt16(int value) { }

	// RVA: 0x10D073C
	protected static SByte Int32ToSByte(int value) { }

	// RVA: 0x10D0828
	protected static UInt16 Int32ToUInt16(int value) { }

	// RVA: 0x10D0914
	protected static int Int64ToInt32(Int64 value) { }

	// RVA: 0x10D09FC
	protected static UInt32 Int64ToUInt32(Int64 value) { }

	// RVA: 0x10D0AE4
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x10D0B6C
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x10D0BF4
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric10Converter
{
	// Methods

	// RVA: 0x10D126C
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10D12D8
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10D137C
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x10D148C
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x10D1E80
	public override int ToInt32(Int64 value) { }

	// RVA: 0x10D1F08
	public override int ToInt32(string value) { }

	// RVA: 0x10D203C
	public override int ToInt32(object value) { }

	// RVA: 0x10D24CC
	public override Int64 ToInt64(int value) { }

	// RVA: 0x10D24D4
	public override Int64 ToInt64(string value) { }

	// RVA: 0x10D2608
	public override Int64 ToInt64(object value) { }

	// RVA: 0x10D2A98
	public override string ToString(Decimal value) { }

	// RVA: 0x10D2B74
	public override string ToString(int value) { }

	// RVA: 0x10D2BFC
	public override string ToString(Int64 value) { }

	// RVA: 0x10D2C84
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10D3150
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10D3C20
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10D419C
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10D471C
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10D4C78
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10D1950
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10D36D8
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric2Converter
{
	// Methods

	// RVA: 0x10D5FAC
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10D6018
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10D60BC
	public override Double ToDouble(string value) { }

	// RVA: 0x10D61BC
	public override Double ToDouble(object value) { }

	// RVA: 0x10D65A4
	public override float ToSingle(Double value) { }

	// RVA: 0x10D65AC
	public override float ToSingle(string value) { }

	// RVA: 0x10D66AC
	public override float ToSingle(object value) { }

	// RVA: 0x10D6A80
	public override string ToString(Double value) { }

	// RVA: 0x10D6B7C
	public override string ToString(float value) { }

	// RVA: 0x10D6C30
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10D701C
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10D749C
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10D792C
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlDateTimeConverter
{
	// Methods

	// RVA: 0x10D8244
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10D82B0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10D8354
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x10D83C0
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x10D86AC
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x10D8AA0
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x10D8ACC
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x10D8DB8
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10D91E8
	public override string ToString(DateTime value) { }

	// RVA: 0x10D9488
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x10D968C
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10D9A78
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10D9F00
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DA388
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlBooleanConverter
{
	// Methods

	// RVA: 0x10DACC4
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10DAD30
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10DADD4
	public override bool ToBoolean(string value) { }

	// RVA: 0x10DAE90
	public override bool ToBoolean(object value) { }

	// RVA: 0x10DB1E0
	public override string ToString(bool value) { }

	// RVA: 0x10DB268
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DB5A4
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10DB9A8
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DBDAC
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlMiscConverter
{
	// Methods

	// RVA: 0x10DC4F0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10DC55C
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10DC600
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DCD80
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DD568
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DCC10
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DD3BC
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlStringConverter
{
	// Methods

	// RVA: 0x10DE61C
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10DE688
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10DE72C
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DE988
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DECBC
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

	// RVA: 0x10DF220
	protected void .ctor() { }

	// RVA: 0x10DF390
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0x10DF51C
	public override bool ToBoolean(string value) { }

	// RVA: 0x10DF5D8
	public override bool ToBoolean(object value) { }

	// RVA: 0x10DF948
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x10DFA04
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x10DFBDC
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x10DFC98
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10DFE7C
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x10DFF38
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x10E0144
	public override Double ToDouble(string value) { }

	// RVA: 0x10E0200
	public override Double ToDouble(object value) { }

	// RVA: 0x10E0400
	public override int ToInt32(string value) { }

	// RVA: 0x10E04BC
	public override int ToInt32(object value) { }

	// RVA: 0x10E06BC
	public override Int64 ToInt64(string value) { }

	// RVA: 0x10E0778
	public override Int64 ToInt64(object value) { }

	// RVA: 0x10E0978
	public override float ToSingle(string value) { }

	// RVA: 0x10E0A34
	public override float ToSingle(object value) { }

	// RVA: 0x10E0C34
	public override string ToString(bool value) { }

	// RVA: 0x10E0CBC
	public override string ToString(DateTime value) { }

	// RVA: 0x10E0D44
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x10E0DB0
	public override string ToString(Decimal value) { }

	// RVA: 0x10E0E1C
	public override string ToString(Double value) { }

	// RVA: 0x10E0EA4
	public override string ToString(int value) { }

	// RVA: 0x10E0F2C
	public override string ToString(Int64 value) { }

	// RVA: 0x10E0FB4
	public override string ToString(float value) { }

	// RVA: 0x10E103C
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E1F24
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10E2360
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10E25AC
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10E2864
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10E2AD0
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10E2D30
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10E2F90
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E3F10
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10DF7D8
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E2184
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E5CC0
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E5FFC
	private bool SupportsType(Type clrType) { }

	// RVA: 0x10E77CC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyConverter
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x10E7890
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x10E78FC
	public override bool ToBoolean(object value) { }

	// RVA: 0x10E7C50
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x10E7E34
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10E801C
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x10E8204
	public override Double ToDouble(object value) { }

	// RVA: 0x10E83E8
	public override int ToInt32(object value) { }

	// RVA: 0x10E85CC
	public override Int64 ToInt64(object value) { }

	// RVA: 0x10E87B0
	public override float ToSingle(object value) { }

	// RVA: 0x10E8998
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10E8DAC
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10E9014
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10E92D0
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10E9540
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10E97A8
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10E9A10
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E9C68
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E7AE0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E8C00
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EB70C
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x10EB7A0
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyListConverter
{
	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x10EB8B8
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x10EB9B0
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EBC60
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlListConverter
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x10EB934
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x10DF490
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x10DF324
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10EBE50
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x10EC0D0
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E67E4
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EC1DC
	private bool IsListType(Type type) { }

	// RVA: 0x30A1970
	private T[] ToArray(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10ECB10
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10ECA60
	private System.Collections.Generic.List<System.String> StringAsList(string value) { }

	// RVA: 0x10EC6CC
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10EC420
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

	// RVA: 0x10ED124
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10ED3A8
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10ED40C
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

	// RVA: 0x10FA2CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10FA388
	public virtual void Invoke(XsdBuilder builder, string value) { }

}

// Namespace: 
private sealed class XsdInitFunction
{
	// Methods

	// RVA: 0x10FA39C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10FA458
	public virtual void Invoke(XsdBuilder builder, string value) { }

}

// Namespace: 
private sealed class XsdEndChildFunction
{
	// Methods

	// RVA: 0x10FA46C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10FA520
	public virtual void Invoke(XsdBuilder builder) { }

}

// Namespace: 
private sealed class XsdAttributeEntry
{
	// Fields
	public Token Attribute; // 0x10
	public XsdBuildFunction BuildFunc; // 0x18

	// Methods

	// RVA: 0x10FA534
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

	// RVA: 0x10FA578
	public void .ctor(Token n, State state, State[] nextStates, XsdAttributeEntry[] attributes, XsdInitFunction init, XsdEndChildFunction end, bool parseContent) { }

}

// Namespace: 
private class BuilderNamespaceManager
{
	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x10FA618
	public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x10FA668
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

	// RVA: 0x10ED8CC
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x10EDB2C
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x10EE30C
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x10EE868
	internal override bool IsContentParsed() { }

	// RVA: 0x10EE888
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x10EE898
	internal override void ProcessCData(string value) { }

	// RVA: 0x10EE8F4
	internal override void StartChildren() { }

	// RVA: 0x10EEAA8
	internal override void EndChildren() { }

	// RVA: 0x10EDDE8
	private void Push() { }

	// RVA: 0x10EEAF0
	private void Pop() { }

	// RVA: 0x10EFD70
	private Token get_CurrentElement() { }

	// RVA: 0x10EFD90
	private Token get_ParentElement() { }

	// RVA: 0x10EFE0C
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0x10EEBE4
	private XmlSchemaObject GetContainer(State state) { }

	// RVA: 0x10EED9C
	private void SetContainer(State state, object container) { }

	// RVA: 0x10EFEA0
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0x10EFEC8
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10F005C
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10F0108
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0x10F012C
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0x10F0150
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10F0448
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10F04BC
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0x10F04E4
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0x10F05B4
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x10F05D8
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0x10F06A8
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x10F06CC
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x10F06F0
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0x10F07C0
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x10F07E4
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0x10F0804
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x10F0BD0
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0x10F0BF4
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x10F0C18
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0x10F0CC4
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0x10F0D70
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x10F0F74
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10F0F98
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0x10F1014
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0x10F1188
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x10F132C
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0x10F13A0
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0x10F13C4
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0x10F1470
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0x10F14EC
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0x10F1560
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x10F1584
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x10F1670
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x10F175C
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10F1780
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0x10F17FC
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x10F1878
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0x10F18F4
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0x10F1C94
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10F1CB8
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x10F1D2C
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0x10F1DFC
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0x10F1FFC
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0x10F20CC
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0x10F2148
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x10F2218
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x10F2294
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0x10F2480
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x10F24FC
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0x10F2570
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x10F25E4
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x10F2668
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10F268C
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0x10F27A0
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x10F281C
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x10F2914
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x10F2990
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x10F2A34
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x10F2AB0
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0x10F2BC4
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x10F2CBC
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x10F2D38
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x10F2E30
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x10F2EAC
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0x10F2FE4
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10F3008
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x10F3098
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x10F3114
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x10F342C
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x10F3450
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x10F34FC
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0x10F3638
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10F365C
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x10F3ADC
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x10F3AFC
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x10F3B1C
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x10F3B98
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0x10F3C38
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0x10F3CD8
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0x10F3D78
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0x10F3E1C
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x10F3E40
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x10F3EEC
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0x10F3F94
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10F3FB8
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0x10F3FDC
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0x10F4000
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0x10F436C
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x10F43F0
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0x10F4414
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0x10F456C
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10F4590
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0x10F46B4
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0x10F4790
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x10F47B4
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0x10F4890
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x10F48B4
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0x10F4A9C
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0x10F4B70
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0x10F4BF0
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0x10F4C1C
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0x10F4CF0
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0x10F4D6C
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0x10F4EB4
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0x10F0934
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0x10F3700
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10EDC74
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x10EE1F8
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x10F1690
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x10F15A4
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x10F1204
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0x10EFF74
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0x10F0DEC
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0x10F01C4
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x10F4BEC
	private static string ParseUriReference(string s) { }

	// RVA: 0x10F4EE0
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0x10EE224
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x10EE77C
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x10F5054
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x10F1FF4
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x10EE0B8
	private void RecordPosition() { }

	// RVA: 0x10F5134
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

	// RVA: 0x10FA938
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x10FEB14
	private bool ParseDate(int start) { }

	// RVA: 0x10FEEE8
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x10FF2E0
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x10FF564
	private bool ParseTime(int start) { }

	// RVA: 0x10FEFD0
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x10FF398
	private bool Parse4Dig(int start, int num) { }

	// RVA: 0x10FF4B4
	private bool Parse2Dig(int start, int num) { }

	// RVA: 0x10FEE94
	private bool ParseChar(int start, Char ch) { }

	// RVA: 0x10FEB08
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x10FFA78
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

	// RVA: 0x10FA6CC
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x10FBCEC
	private void .ctor(Parser parser) { }

	// RVA: 0x10FBC24
	private void InitiateXsdDateTime(Parser parser) { }

	// RVA: 0x10FBE4C
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, XsdDateTime result) { }

	// RVA: 0x10FBF48
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x10FC134
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x10FC1B0
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x10FC344
	private DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x10FC34C
	private XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x10FC354
	public int get_Year() { }

	// RVA: 0x10FC3DC
	public int get_Month() { }

	// RVA: 0x10FC464
	public int get_Day() { }

	// RVA: 0x10FC4EC
	public int get_Hour() { }

	// RVA: 0x10FC574
	public int get_Minute() { }

	// RVA: 0x10FC5FC
	public int get_Second() { }

	// RVA: 0x10FC684
	public int get_Fraction() { }

	// RVA: 0x10FC7A4
	public int get_ZoneHour() { }

	// RVA: 0x10FC7AC
	public int get_ZoneMinute() { }

	// RVA: 0x10FC7B4
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x10FCEB8
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x10FD398
	public override string ToString() { }

	// RVA: 0x10FDCA0
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x10FE024
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x10FE51C
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x10FE444
	private void IntToCharArray(Char[] text, int start, int value, int digits) { }

	// RVA: 0x10FE4B0
	private void ShortToCharArray(Char[] text, int start, int value) { }

	// RVA: 0x10FE748
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

	// RVA: 0x10FFB1C
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x10FFC84
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x10FFDB4
	public void .ctor(TimeSpan timeSpan, DurationType durationType) { }

	// RVA: 0x10FFFBC
	public void .ctor(string s) { }

	// RVA: 0x1100038
	public void .ctor(string s, DurationType durationType) { }

	// RVA: 0x11007F4
	public bool get_IsNegative() { }

	// RVA: 0x1100800
	public int get_Years() { }

	// RVA: 0x1100808
	public int get_Months() { }

	// RVA: 0x1100810
	public int get_Days() { }

	// RVA: 0x1100818
	public int get_Hours() { }

	// RVA: 0x1100820
	public int get_Minutes() { }

	// RVA: 0x1100828
	public int get_Seconds() { }

	// RVA: 0x11007E8
	public int get_Nanoseconds() { }

	// RVA: 0x1100830
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x1100888
	public TimeSpan ToTimeSpan(DurationType durationType) { }

	// RVA: 0x1100DF4
	internal Exception TryToTimeSpan(TimeSpan result) { }

	// RVA: 0x11008DC
	internal Exception TryToTimeSpan(DurationType durationType, TimeSpan result) { }

	// RVA: 0x1100E00
	public override string ToString() { }

	// RVA: 0x1100E08
	internal string ToString(DurationType durationType) { }

	// RVA: 0x1101240
	internal static Exception TryParse(string s, XsdDuration result) { }

	// RVA: 0x11000B8
	internal static Exception TryParse(string s, DurationType durationType, XsdDuration result) { }

	// RVA: 0x110124C
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

	// RVA: 0x11013F4
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1101818
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1101424
	private void Init() { }

	// RVA: 0x11019A0
	public override void Validate() { }

	// RVA: 0x11020A0
	public override void CompleteValidation() { }

	// RVA: 0x1101A74
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1101A84
	private void ProcessInlineSchema() { }

	// RVA: 0x1101D34
	private void ValidateElement() { }

	// RVA: 0x11021D0
	private object ValidateChildElement() { }

	// RVA: 0x1102408
	private void ProcessElement(object particle) { }

	// RVA: 0x1102864
	private void ProcessXsiAttributes(XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x1101EC0
	private void ValidateEndElement() { }

	// RVA: 0x1102764
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x110306C
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x11034E4
	private void ValidateStartElement() { }

	// RVA: 0x1103C24
	private void ValidateEndStartElement() { }

	// RVA: 0x110581C
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x11040AC
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x1103460
	private bool get_HasSchema() { }

	// RVA: 0x1105D98
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1105DD4
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1104270
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1106050
	internal void AddID(string name, object node) { }

	// RVA: 0x11060F0
	public override object FindId(string name) { }

	// RVA: 0x11023BC
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1101848
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x11053C8
	private void Pop() { }

	// RVA: 0x11020A4
	private void CheckForwardRefs() { }

	// RVA: 0x1103488
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x110475C
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x110610C
	private void AddIdentityConstraints() { }

	// RVA: 0x1106518
	private void ElementIdentityConstraints() { }

	// RVA: 0x110554C
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x11054C0
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x110476C
	private void EndElementIdentityConstraints() { }

	// RVA: 0x1106868
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AbsoluteQuery
{
	// Methods

	// RVA: 0x1106928
	public void .ctor() { }

	// RVA: 0x1106978
	private void .ctor(AbsoluteQuery other) { }

	// RVA: 0x11069F0
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1106A70
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

	// RVA: 0x1106AF0
	protected void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AttributeQuery
{
	// Fields
	private bool _onAttribute; // 0x54

	// Methods

	// RVA: 0x1106AF8
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1106BE4
	private void .ctor(AttributeQuery other) { }

	// RVA: 0x1106CB8
	public override void Reset() { }

	// RVA: 0x1106D44
	public override XPathNavigator Advance() { }

	// RVA: 0x1106E3C
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

	// RVA: 0x1106EB0
	public void .ctor(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x1106F7C
	public void .ctor(AxisType axisType, AstNode input) { }

	// RVA: 0x110706C
	public override AstType get_Type() { }

	// RVA: 0x1107074
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x110707C
	public AstNode get_Input() { }

	// RVA: 0x1107084
	public void set_Input(AstNode value) { }

	// RVA: 0x110708C
	public string get_Prefix() { }

	// RVA: 0x1107094
	public string get_Name() { }

	// RVA: 0x110709C
	public XPathNodeType get_NodeType() { }

	// RVA: 0x11070A4
	public AxisType get_TypeOfAxis() { }

	// RVA: 0x11070AC
	public bool get_AbbrAxis() { }

	// RVA: 0x11070B4
	public string get_Urn() { }

	// RVA: 0x11070BC
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

	// RVA: 0x11070C4
	protected void .ctor(Query qyInput) { }

	// RVA: 0x1106AFC
	protected void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1106C18
	protected void .ctor(BaseAxisQuery other) { }

	// RVA: 0x1106D00
	public override void Reset() { }

	// RVA: 0x1107174
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x11071DC
	protected string get_Name() { }

	// RVA: 0x11071E4
	protected string get_Namespace() { }

	// RVA: 0x11071EC
	protected bool get_NameTest() { }

	// RVA: 0x11071F4
	protected XPathNodeType get_TypeTest() { }

	// RVA: 0x11071FC
	public override int get_CurrentPosition() { }

	// RVA: 0x1107204
	public override XPathNavigator get_Current() { }

	// RVA: 0x110720C
	public virtual bool matches(XPathNavigator e) { }

	// RVA: 0x1107338
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1107394
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

	// RVA: 0x110739C
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x1107528
	private void .ctor(BooleanExpr other) { }

	// RVA: 0x1107598
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x11075EC
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11076C8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1107778
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class BooleanFunctions
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _funcType; // 0x20

	// Methods

	// RVA: 0x11074E0
	public void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0x1107780
	private void .ctor(BooleanFunctions other) { }

	// RVA: 0x11077D4
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x11077F0
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1107CF0
	internal static bool toBoolean(Double number) { }

	// RVA: 0x1107D10
	internal static bool toBoolean(string str) { }

	// RVA: 0x11079E4
	internal bool toBoolean(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1107D34
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1107B88
	private bool Not(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1107C28
	private bool Lang(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1107D3C
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheAxisQuery
{
	// Fields
	protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer; // 0x58

	// Methods

	// RVA: 0x1107DD0
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1107E90
	protected void .ctor(CacheAxisQuery other) { }

	// RVA: 0x1107F44
	public override void Reset() { }

	// RVA: 0x1107F4C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1108040
	public override XPathNavigator Advance() { }

	// RVA: 0x11080E0
	public override XPathNavigator get_Current() { }

	// RVA: 0x1108168
	public override int get_CurrentPosition() { }

	// RVA: 0x1108170
	public override int get_Count() { }

	// RVA: 0x11081BC
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

	// RVA: 0x11081C4
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x11083D4
	private void .ctor(CacheChildrenQuery other) { }

	// RVA: 0x1108558
	public override void Reset() { }

	// RVA: 0x110872C
	public override XPathNavigator Advance() { }

	// RVA: 0x11089B8
	private bool DecideNextNode() { }

	// RVA: 0x1108938
	private XPathNavigator GetNextInput() { }

	// RVA: 0x1108B50
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheOutputQuery
{
	// Fields
	internal Query input; // 0x18
	protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer; // 0x20

	// Methods

	// RVA: 0x1108BB4
	public void .ctor(Query input) { }

	// RVA: 0x1108C64
	protected void .ctor(CacheOutputQuery other) { }

	// RVA: 0x1108D38
	public override void Reset() { }

	// RVA: 0x1108D40
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1108D68
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1108E2C
	public override XPathNavigator Advance() { }

	// RVA: 0x1108ECC
	public override XPathNavigator get_Current() { }

	// RVA: 0x1108F54
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1108F5C
	public override int get_CurrentPosition() { }

	// RVA: 0x1108F64
	public override int get_Count() { }

	// RVA: 0x1108FB0
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ChildrenQuery
{
	// Fields
	private XPathNodeIterator _iterator; // 0x58

	// Methods

	// RVA: 0x110832C
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x11084B0
	protected void .ctor(ChildrenQuery other) { }

	// RVA: 0x1108690
	public override void Reset() { }

	// RVA: 0x1108FB8
	public override XPathNavigator Advance() { }

	// RVA: 0x1109180
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ClonableStack<T0>
{
	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A27C0
	private void .ctor(System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0x315B3A8
	public void Push(T value) { }

	// RVA: 0x315B3A8
	public T Pop() { }

	// RVA: 0x315B3A8
	public T Peek() { }

	// RVA: 0x30A17DC
	public MS.Internal.Xml.XPath.ClonableStack<T> Clone() { }

}

// Namespace: 
private class UndefinedXsltContext
{
	// Fields
	private IXmlNamespaceResolver _nsResolver; // 0x50

	// Methods

	// RVA: 0x11093D0
	public void .ctor(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1109408
	public override string get_DefaultNamespace() { }

	// RVA: 0x1109454
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1109594
	public override IXsltContextVariable ResolveVariable(string prefix, string name) { }

	// RVA: 0x11095D0
	public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) { }

	// RVA: 0x110960C
	public override bool get_Whitespace() { }

	// RVA: 0x1109614
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

	// RVA: 0x11091E4
	internal void .ctor(Query query, string expression, bool needContext) { }

	// RVA: 0x1109240
	internal Query get_QueryTree() { }

	// RVA: 0x1109294
	public override void SetContext(IXmlNamespaceResolver nsResolver) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ContextQuery
{
	// Fields
	protected XPathNavigator contextNode; // 0x18

	// Methods

	// RVA: 0x1106950
	public void .ctor() { }

	// RVA: 0x11069B4
	protected void .ctor(ContextQuery other) { }

	// RVA: 0x110961C
	public override void Reset() { }

	// RVA: 0x1109624
	public override XPathNavigator get_Current() { }

	// RVA: 0x110962C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x110967C
	public override XPathNavigator Advance() { }

	// RVA: 0x110969C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x110971C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1109724
	public override int get_CurrentPosition() { }

	// RVA: 0x110972C
	public override int get_Count() { }

	// RVA: 0x1109734
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class DescendantBaseQuery
{
	// Fields
	protected bool matchSelf; // 0x54
	protected bool abbrAxis; // 0x55

	// Methods

	// RVA: 0x110973C
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x1109774
	public void .ctor(DescendantBaseQuery other) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class DescendantQuery
{
	// Fields
	private XPathNodeIterator _nodeIterator; // 0x58

	// Methods

	// RVA: 0x11097A8
	internal void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x11097E0
	public void .ctor(DescendantQuery other) { }

	// RVA: 0x110982C
	public override void Reset() { }

	// RVA: 0x110987C
	public override XPathNavigator Advance() { }

	// RVA: 0x1109A2C
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DescendantOverDescendantQuery
{
	// Fields
	private int _level; // 0x58

	// Methods

	// RVA: 0x1109ABC
	public void .ctor(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis) { }

	// RVA: 0x1109B00
	private void .ctor(DescendantOverDescendantQuery other) { }

	// RVA: 0x1109B3C
	public override void Reset() { }

	// RVA: 0x1109B84
	public override XPathNavigator Advance() { }

	// RVA: 0x1109CF4
	private bool MoveToFirstChild() { }

	// RVA: 0x1109D3C
	private bool MoveUpUntilNext() { }

	// RVA: 0x1109DA8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DocumentOrderQuery
{
	// Methods

	// RVA: 0x1109E24
	public void .ctor(Query qyParent) { }

	// RVA: 0x1109E28
	private void .ctor(DocumentOrderQuery other) { }

	// RVA: 0x1109E2C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1109E88
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class EmptyQuery
{
	// Methods

	// RVA: 0x1109EEC
	public override XPathNavigator Advance() { }

	// RVA: 0x1109EF4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1109EF8
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1109EFC
	public override int get_CurrentPosition() { }

	// RVA: 0x1109F04
	public override int get_Count() { }

	// RVA: 0x1109F0C
	public override QueryProps get_Properties() { }

	// RVA: 0x1109F14
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1109F1C
	public override void Reset() { }

	// RVA: 0x1109F20
	public override XPathNavigator get_Current() { }

	// RVA: 0x1109F28
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

	// RVA: 0x1109F30
	public void .ctor(string prefix, string name) { }

	// RVA: 0x1109F80
	protected void .ctor(ExtensionQuery other) { }

	// RVA: 0x110A0A8
	public override void Reset() { }

	// RVA: 0x110A0C0
	public override XPathNavigator get_Current() { }

	// RVA: 0x110A14C
	public override XPathNavigator Advance() { }

	// RVA: 0x110A1D4
	public override int get_CurrentPosition() { }

	// RVA: 0x110A1EC
	protected object ProcessResult(object value) { }

	// RVA: 0x110A658
	protected string get_QName() { }

	// RVA: 0x110A6CC
	public override int get_Count() { }

	// RVA: 0x110A6E8
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Filter
{
	// Fields
	private AstNode _input; // 0x10
	private AstNode _condition; // 0x18

	// Methods

	// RVA: 0x110A6F0
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x110A740
	public override AstType get_Type() { }

	// RVA: 0x110A748
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x110A750
	public AstNode get_Input() { }

	// RVA: 0x110A758
	public AstNode get_Condition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FilterQuery
{
	// Fields
	private Query _cond; // 0x58
	private bool _noPosition; // 0x60

	// Methods

	// RVA: 0x110A760
	public void .ctor(Query qyParent, Query cond, bool noPosition) { }

	// RVA: 0x110A7A4
	private void .ctor(FilterQuery other) { }

	// RVA: 0x110A7F4
	public override void Reset() { }

	// RVA: 0x110A84C
	public Query get_Condition() { }

	// RVA: 0x110A854
	public override void SetXsltContext(XsltContext input) { }

	// RVA: 0x110A988
	public override XPathNavigator Advance() { }

	// RVA: 0x110AA14
	internal bool EvaluatePredicate() { }

	// RVA: 0x110ABE8
	public override QueryProps get_Properties() { }

	// RVA: 0x110AC1C
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

	// RVA: 0x110ACAC
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x110ADB8
	private void .ctor(FollSiblingQuery other) { }

	// RVA: 0x110AEB0
	public override void Reset() { }

	// RVA: 0x110AFDC
	private bool Visited(XPathNavigator nav) { }

	// RVA: 0x110B0F4
	private XPathNavigator FetchInput() { }

	// RVA: 0x110B160
	public override XPathNavigator Advance() { }

	// RVA: 0x110B3F0
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FollowingQuery
{
	// Fields
	private XPathNavigator _input; // 0x58
	private XPathNodeIterator _iterator; // 0x60

	// Methods

	// RVA: 0x110B454
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x110B458
	private void .ctor(FollowingQuery other) { }

	// RVA: 0x110B4B8
	public override void Reset() { }

	// RVA: 0x110B508
	public override XPathNavigator Advance() { }

	// RVA: 0x110B790
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ForwardPositionQuery
{
	// Methods

	// RVA: 0x110B834
	public void .ctor(Query input) { }

	// RVA: 0x110B838
	protected void .ctor(ForwardPositionQuery other) { }

	// RVA: 0x110B83C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x110B8EC
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

	// RVA: 0x110B950
	public void .ctor(FunctionType ftype, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }

	// RVA: 0x110B9F4
	public void .ctor(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }

	// RVA: 0x110BAC8
	public void .ctor(FunctionType ftype, AstNode arg) { }

	// RVA: 0x110BB94
	public override AstType get_Type() { }

	// RVA: 0x110BB9C
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x110BC40
	public FunctionType get_TypeOfFunction() { }

	// RVA: 0x110BC48
	public System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> get_ArgumentList() { }

	// RVA: 0x110BC50
	public string get_Prefix() { }

	// RVA: 0x110BC58
	public string get_Name() { }

	// RVA: 0x110BC60
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FunctionQuery
{
	// Fields
	private System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> _args; // 0x38
	private IXsltContextFunction _function; // 0x40

	// Methods

	// RVA: 0x110BD04
	public void .ctor(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> args) { }

	// RVA: 0x110BD68
	private void .ctor(FunctionQuery other) { }

	// RVA: 0x110BF84
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x110C504
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x110CA84
	public override XPathResultType get_StaticType() { }

	// RVA: 0x110CB44
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Group
{
	// Fields
	private AstNode _groupNode; // 0x10

	// Methods

	// RVA: 0x110CBA8
	public void .ctor(AstNode groupNode) { }

	// RVA: 0x110CBDC
	public override AstType get_Type() { }

	// RVA: 0x110CBE4
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x110CBEC
	public AstNode get_GroupNode() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class GroupQuery
{
	// Methods

	// RVA: 0x110CBF4
	public void .ctor(Query qy) { }

	// RVA: 0x110CBF8
	private void .ctor(GroupQuery other) { }

	// RVA: 0x110CBFC
	public override XPathNavigator Advance() { }

	// RVA: 0x110CC5C
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x110CC84
	public override XPathNodeIterator Clone() { }

	// RVA: 0x110CCE8
	public override XPathResultType get_StaticType() { }

	// RVA: 0x110CD10
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class IDQuery
{
	// Methods

	// RVA: 0x110CD18
	public void .ctor(Query arg) { }

	// RVA: 0x110CD1C
	private void .ctor(IDQuery other) { }

	// RVA: 0x110CD20
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x110CF74
	private void ProcessIds(XPathNavigator contextNode, string val) { }

	// RVA: 0x110D07C
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

	// RVA: 0x1109130
	internal void .ctor(XPathNodeIterator innerIterator, string name) { }

	// RVA: 0x110D0E0
	private void .ctor(IteratorFilter it) { }

	// RVA: 0x110D14C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x110D1F4
	public override XPathNavigator get_Current() { }

	// RVA: 0x110D218
	public override int get_CurrentPosition() { }

	// RVA: 0x110D220
	public override bool MoveNext() { }

}

// Namespace: 
private sealed class cmpXslt
{
	// Methods

	// RVA: 0x1111CD4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1111D78
	public virtual bool Invoke(Op op, object val1, object val2) { }

}

// Namespace: 
private struct NodeSet
{
	// Fields
	private Query _opnd; // 0x10
	private XPathNavigator _current; // 0x18

	// Methods

	// RVA: 0x110D898
	public void .ctor(object opnd) { }

	// RVA: 0x110D96C
	public bool MoveNext() { }

	// RVA: 0x110D9E4
	public void Reset() { }

	// RVA: 0x110D9C0
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

	// RVA: 0x110D2A4
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x110D2FC
	private void .ctor(LogicalExpr other) { }

	// RVA: 0x110D368
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x110D3BC
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x110D718
	private static bool cmpQueryQueryE(Op op, object val1, object val2) { }

	// RVA: 0x110DA08
	private static bool cmpQueryQueryO(Op op, object val1, object val2) { }

	// RVA: 0x110DD8C
	private static bool cmpQueryNumber(Op op, object val1, object val2) { }

	// RVA: 0x110DF78
	private static bool cmpQueryStringE(Op op, object val1, object val2) { }

	// RVA: 0x110E0EC
	private static bool cmpQueryStringO(Op op, object val1, object val2) { }

	// RVA: 0x110E368
	private static bool cmpRtfQueryE(Op op, object val1, object val2) { }

	// RVA: 0x110E5A0
	private static bool cmpRtfQueryO(Op op, object val1, object val2) { }

	// RVA: 0x110E810
	private static bool cmpQueryBoolE(Op op, object val1, object val2) { }

	// RVA: 0x110E938
	private static bool cmpQueryBoolO(Op op, object val1, object val2) { }

	// RVA: 0x110E924
	private static bool cmpBoolBoolE(Op op, bool n1, bool n2) { }

	// RVA: 0x110EB1C
	private static bool cmpBoolBoolE(Op op, object val1, object val2) { }

	// RVA: 0x110EC14
	private static bool cmpBoolBoolO(Op op, object val1, object val2) { }

	// RVA: 0x110EDB8
	private static bool cmpBoolNumberE(Op op, object val1, object val2) { }

	// RVA: 0x110EEE0
	private static bool cmpBoolNumberO(Op op, object val1, object val2) { }

	// RVA: 0x110F088
	private static bool cmpBoolStringE(Op op, object val1, object val2) { }

	// RVA: 0x110F184
	private static bool cmpRtfBoolE(Op op, object val1, object val2) { }

	// RVA: 0x110F2EC
	private static bool cmpBoolStringO(Op op, object val1, object val2) { }

	// RVA: 0x110F4C8
	private static bool cmpRtfBoolO(Op op, object val1, object val2) { }

	// RVA: 0x110DD18
	private static bool cmpNumberNumber(Op op, Double n1, Double n2) { }

	// RVA: 0x110E30C
	private static bool cmpNumberNumberO(Op op, Double n1, Double n2) { }

	// RVA: 0x110F730
	private static bool cmpNumberNumber(Op op, object val1, object val2) { }

	// RVA: 0x110F8E0
	private static bool cmpStringNumber(Op op, object val1, object val2) { }

	// RVA: 0x110FAD8
	private static bool cmpRtfNumber(Op op, object val1, object val2) { }

	// RVA: 0x110E0B4
	private static bool cmpStringStringE(Op op, string n1, string n2) { }

	// RVA: 0x110FD44
	private static bool cmpStringStringE(Op op, object val1, object val2) { }

	// RVA: 0x110FE14
	private static bool cmpRtfStringE(Op op, object val1, object val2) { }

	// RVA: 0x110FF54
	private static bool cmpRtfRtfE(Op op, object val1, object val2) { }

	// RVA: 0x11100D0
	private static bool cmpStringStringO(Op op, object val1, object val2) { }

	// RVA: 0x11102EC
	private static bool cmpRtfStringO(Op op, object val1, object val2) { }

	// RVA: 0x1110590
	private static bool cmpRtfRtfO(Op op, object val1, object val2) { }

	// RVA: 0x1110828
	public override XPathNodeIterator Clone() { }

	// RVA: 0x110E518
	private static string Rtf(object o) { }

	// RVA: 0x11108D8
	public override XPathResultType get_StaticType() { }

	// RVA: 0x11108E0
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class MergeFilterQuery
{
	// Fields
	private Query _child; // 0x28

	// Methods

	// RVA: 0x1111D8C
	public void .ctor(Query input, Query child) { }

	// RVA: 0x1111DBC
	private void .ctor(MergeFilterQuery other) { }

	// RVA: 0x1111E00
	public override void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x1111E54
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1111EE8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NamespaceQuery
{
	// Fields
	private bool _onNamespace; // 0x54

	// Methods

	// RVA: 0x1111F70
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1111F74
	private void .ctor(NamespaceQuery other) { }

	// RVA: 0x1111FA8
	public override void Reset() { }

	// RVA: 0x1111FF0
	public override XPathNavigator Advance() { }

	// RVA: 0x11120D8
	public override bool matches(XPathNavigator e) { }

	// RVA: 0x111216C
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

	// RVA: 0x11121E0
	public void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0x1112224
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x111229C
	private XPathNavigator EvaluateArg(XPathNodeIterator context) { }

	// RVA: 0x1112308
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1112614
	public override XPathResultType get_StaticType() { }

	// RVA: 0x11126B8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NumberFunctions
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _ftype; // 0x20

	// Methods

	// RVA: 0x1112754
	public void .ctor(FunctionType ftype, Query arg) { }

	// RVA: 0x111279C
	private void .ctor(NumberFunctions other) { }

	// RVA: 0x11127F0
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x110EB08
	internal static Double Number(bool arg) { }

	// RVA: 0x110DC90
	internal static Double Number(string arg) { }

	// RVA: 0x111280C
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1112950
	private Double Number(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1112BE4
	private Double Sum(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1112CD4
	private Double Floor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1112D9C
	private Double Ceiling(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1112E64
	private Double Round(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1112EF8
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1112F00
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

	// RVA: 0x1112F94
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x11130BC
	private void .ctor(NumericExpr other) { }

	// RVA: 0x1113128
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x111317C
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11132CC
	private static Double GetValue(Op op, Double n1, Double n2) { }

	// RVA: 0x111332C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1113334
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Operand
{
	// Fields
	private XPathResultType _type; // 0x10
	private object _val; // 0x18

	// Methods

	// RVA: 0x11133E4
	public void .ctor(string val) { }

	// RVA: 0x1113420
	public void .ctor(Double val) { }

	// RVA: 0x11134B0
	public override AstType get_Type() { }

	// RVA: 0x11134B8
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x11134C0
	public object get_OperandValue() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class OperandQuery
{
	// Fields
	internal object val; // 0x18

	// Methods

	// RVA: 0x11134C8
	public void .ctor(object val) { }

	// RVA: 0x11134FC
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1113504
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1113510
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

	// RVA: 0x110D678
	public static Op InvertOperator(Op op) { }

	// RVA: 0x1113514
	public void .ctor(Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x111356C
	public override AstType get_Type() { }

	// RVA: 0x1113574
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1113594
	public Op get_OperatorType() { }

	// RVA: 0x111359C
	public AstNode get_Operand1() { }

	// RVA: 0x11135A4
	public AstNode get_Operand2() { }

	// RVA: 0x11135AC
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ParentQuery
{
	// Methods

	// RVA: 0x1113650
	public void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1113710
	private void .ctor(ParentQuery other) { }

	// RVA: 0x1113714
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x11137BC
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class PreSiblingQuery
{
	// Methods

	// RVA: 0x1113820
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x11138E0
	protected void .ctor(PreSiblingQuery other) { }

	// RVA: 0x11138E4
	private static bool NotVisited(XPathNavigator nav, System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> parentStk) { }

	// RVA: 0x1113A10
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1113CE8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1113D4C
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class PrecedingQuery
{
	// Fields
	private XPathNodeIterator _workIterator; // 0x58
	private MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator> _ancestorStk; // 0x60

	// Methods

	// RVA: 0x1113D54
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1113E0C
	private void .ctor(PrecedingQuery other) { }

	// RVA: 0x1113EA8
	public override void Reset() { }

	// RVA: 0x1113F7C
	public override XPathNavigator Advance() { }

	// RVA: 0x1114240
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11142A4
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

	// RVA: 0x11142C0
	public void .ctor() { }

	// RVA: 0x1114318
	protected void .ctor(Query other) { }

	// RVA: 0x1114388
	public override bool MoveNext() { }

	// RVA: 0x11143B0
	public override int get_Count() { }

	// RVA: 0x1114498
	public virtual void SetXsltContext(XsltContext context) { }

	// RVA: -1
	public abstract object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: -1
	public abstract XPathNavigator Advance() { }

	// RVA: -1
	public abstract XPathResultType get_StaticType() { }

	// RVA: 0x111449C
	public virtual QueryProps get_Properties() { }

	// RVA: 0x11144A4
	public static Query Clone(Query input) { }

	// RVA: 0x1114540
	protected static XPathNodeIterator Clone(XPathNodeIterator input) { }

	// RVA: 0x1114554
	protected static XPathNavigator Clone(XPathNavigator input) { }

	// RVA: 0x111456C
	public static bool Insert(System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> buffer, XPathNavigator nav) { }

	// RVA: 0x1114840
	private static int GetMedian(int l, int r) { }

	// RVA: 0x111471C
	public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r) { }

	// RVA: 0x111484C
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

	// RVA: 0x1114968
	private void Reset() { }

	// RVA: 0x1114974
	private Query ProcessAxis(Axis root, Flags flags, Props props) { }

	// RVA: 0x11154D4
	private static bool CanBeNumber(Query q) { }

	// RVA: 0x111553C
	private Query ProcessFilter(Filter root, Flags flags, Props props) { }

	// RVA: 0x1115A50
	private Query ProcessOperator(Operator root, Props props) { }

	// RVA: 0x1115CD0
	private Query ProcessVariable(Variable root) { }

	// RVA: 0x1115DA8
	private Query ProcessFunction(Function root, Props props) { }

	// RVA: 0x11162B4
	private System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> ProcessArguments(System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> args, Props props) { }

	// RVA: 0x11150E0
	private Query ProcessNode(AstNode root, Flags flags, Props props) { }

	// RVA: 0x1116478
	private Query Build(AstNode root, string query) { }

	// RVA: 0x11164CC
	internal Query Build(string query, bool allowVar, bool allowKey) { }

	// RVA: 0x11166D8
	internal Query Build(string query, bool needContext) { }

	// RVA: 0x11167A0
	public void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ResetableIterator
{
	// Methods

	// RVA: 0x11142EC
	public void .ctor() { }

	// RVA: 0x1114350
	protected void .ctor(ResetableIterator other) { }

	// RVA: 0x11167A8
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

	// RVA: 0x1115A48
	public void .ctor(Query input) { }

	// RVA: 0x11167B4
	private void .ctor(ReversePositionQuery other) { }

	// RVA: 0x11167BC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1116824
	public override int get_CurrentPosition() { }

	// RVA: 0x111687C
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Root
{
	// Methods

	// RVA: 0x1116898
	public void .ctor() { }

	// RVA: 0x11168A0
	public override AstType get_Type() { }

	// RVA: 0x11168A8
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

	// RVA: 0x1116430
	public void .ctor(FunctionType funcType, System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> argList) { }

	// RVA: 0x11168DC
	private void .ctor(StringFunctions other) { }

	// RVA: 0x1116B88
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1116D14
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11189F8
	internal static string toString(Double num) { }

	// RVA: 0x1118A60
	internal static string toString(bool b) { }

	// RVA: 0x1116F24
	private string toString(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1118ACC
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1117398
	private string Concat(XPathNodeIterator nodeIterator) { }

	// RVA: 0x111758C
	private bool StartsWith(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1117770
	private bool Contains(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1117960
	private string SubstringBefore(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1117BA4
	private string SubstringAfter(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1117DE4
	private string Substring(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1118234
	private Double StringLength(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11183E8
	private string Normalize(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1118690
	private string Translate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1118AF4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1118B58
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

	// RVA: 0x1115C6C
	public void .ctor(Query query1, Query query2) { }

	// RVA: 0x1118C08
	private void .ctor(UnionExpr other) { }

	// RVA: 0x1118DEC
	public override void Reset() { }

	// RVA: 0x1118E48
	public override void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x1118E9C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1118F18
	private XPathNavigator ProcessSamePosition(XPathNavigator result) { }

	// RVA: 0x1118F50
	private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x1118F98
	private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x1118FDC
	public override XPathNavigator Advance() { }

	// RVA: 0x111918C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1119194
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11191F8
	public override XPathNavigator get_Current() { }

	// RVA: 0x1119200
	public override int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ValueQuery
{
	// Methods

	// RVA: 0x11168B0
	public void .ctor() { }

	// RVA: 0x1116B50
	protected void .ctor(ValueQuery other) { }

	// RVA: 0x1119240
	public sealed override void Reset() { }

	// RVA: 0x1119244
	public sealed override XPathNavigator get_Current() { }

	// RVA: 0x1119280
	public sealed override int get_CurrentPosition() { }

	// RVA: 0x11192BC
	public sealed override int get_Count() { }

	// RVA: 0x11192F8
	public sealed override XPathNavigator Advance() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Variable
{
	// Fields
	private string _localname; // 0x10
	private string _prefix; // 0x18

	// Methods

	// RVA: 0x1119334
	public void .ctor(string name, string prefix) { }

	// RVA: 0x1119384
	public override AstType get_Type() { }

	// RVA: 0x111938C
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1119394
	public string get_Localname() { }

	// RVA: 0x111939C
	public string get_Prefix() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class VariableQuery
{
	// Fields
	private IXsltContextVariable _variable; // 0x38

	// Methods

	// RVA: 0x1115D94
	public void .ctor(string name, string prefix) { }

	// RVA: 0x11193A4
	private void .ctor(VariableQuery other) { }

	// RVA: 0x11193E0
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x11194B4
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11195B0
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1119720
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathAncestorQuery
{
	// Fields
	private bool _matchSelf; // 0x60

	// Methods

	// RVA: 0x11154A0
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf) { }

	// RVA: 0x11197A0
	private void .ctor(XPathAncestorQuery other) { }

	// RVA: 0x11197D8
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1119904
	public override XPathNodeIterator Clone() { }

	// RVA: 0x111997C
	public override int get_CurrentPosition() { }

	// RVA: 0x11199D4
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathArrayIterator
{
	// Fields
	protected IList list; // 0x18
	protected int index; // 0x20

	// Methods

	// RVA: 0x11199F0
	public void .ctor(XPathArrayIterator it) { }

	// RVA: 0x1119A40
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1119BAC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1119C38
	public override XPathNavigator get_Current() { }

	// RVA: 0x1119DB8
	public override int get_CurrentPosition() { }

	// RVA: 0x1119DC0
	public override int get_Count() { }

	// RVA: 0x1119E78
	public override bool MoveNext() { }

	// RVA: 0x1119F60
	public override void Reset() { }

	// RVA: 0x1119F68
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

	// RVA: 0x111A01C
	public void .ctor(XPathNavigator nav, bool matchSelf) { }

	// RVA: 0x111A06C
	public void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x111A0C4
	public void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x111A1B4
	public void .ctor(XPathAxisIterator it) { }

	// RVA: 0x111A24C
	public override XPathNavigator get_Current() { }

	// RVA: 0x111A254
	public override int get_CurrentPosition() { }

	// RVA: 0x111A25C
	protected virtual bool get_Matches() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathChildIterator
{
	// Methods

	// RVA: 0x111A3BC
	public void .ctor(XPathNavigator nav, XPathNodeType type) { }

	// RVA: 0x111A410
	public void .ctor(XPathNavigator nav, string name, string namespaceURI) { }

	// RVA: 0x111A418
	public void .ctor(XPathChildIterator it) { }

	// RVA: 0x111A41C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x111A480
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathDescendantIterator
{
	// Fields
	private int _level; // 0x40

	// Methods

	// RVA: 0x111A528
	public void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x111A580
	public void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x111A584
	public void .ctor(XPathDescendantIterator it) { }

	// RVA: 0x111A5B8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x111A62C
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathEmptyIterator
{
	// Fields
	public static XPathEmptyIterator Instance; // 0x0

	// Methods

	// RVA: 0x111A72C
	private void .ctor() { }

	// RVA: 0x111A758
	public override XPathNodeIterator Clone() { }

	// RVA: 0x111A75C
	public override XPathNavigator get_Current() { }

	// RVA: 0x111A764
	public override int get_CurrentPosition() { }

	// RVA: 0x111A76C
	public override int get_Count() { }

	// RVA: 0x111A774
	public override bool MoveNext() { }

	// RVA: 0x111A77C
	public override void Reset() { }

	// RVA: 0x111A780
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

	// RVA: 0x111E914
	public FunctionType get_FType() { }

	// RVA: 0x111E91C
	public int get_Minargs() { }

	// RVA: 0x111E924
	public int get_Maxargs() { }

	// RVA: 0x111E92C
	public XPathResultType[] get_ArgTypes() { }

	// RVA: 0x111E2B8
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

	// RVA: 0x111A7F4
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x1116590
	public static AstNode ParseXPathExpression(string xpathExpression) { }

	// RVA: 0x111A930
	private AstNode ParseExpression(AstNode qyInput) { }

	// RVA: 0x111A9A0
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x111AAB0
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x111AC2C
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x111AF18
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x111B0C4
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x111B1A8
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x111B334
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x111B418
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x111B7A0
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x111B560
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x111B958
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x111C054
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x111BC10
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x111BB30
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x111C210
	private static bool IsStep(LexKind lexKind) { }

	// RVA: 0x111C250
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x111C608
	private AstNode ParseNodeTest(AstNode qyInput, AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x111B8A0
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x111BD7C
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x111C9EC
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x111C97C
	private void CheckToken(LexKind t) { }

	// RVA: 0x111C1A8
	private void PassToken(LexKind t) { }

	// RVA: 0x111AC10
	private void NextLex() { }

	// RVA: 0x111ABC0
	private bool TestOp(string op) { }

	// RVA: 0x111B73C
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x111D6D4
	private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.XPathParser.ParamInfo> CreateFunctionTable() { }

	// RVA: 0x111E310
	private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable() { }

	// RVA: 0x111C4F8
	private AxisType GetAxis() { }

	// RVA: 0x111E630
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

	// RVA: 0x111A828
	public void .ctor(string xpathExpr) { }

	// RVA: 0x111E9A0
	public string get_SourceText() { }

	// RVA: 0x111E9A8
	private Char get_CurrentChar() { }

	// RVA: 0x111E934
	private bool NextChar() { }

	// RVA: 0x111E9B0
	public LexKind get_Kind() { }

	// RVA: 0x111E9B8
	public string get_Name() { }

	// RVA: 0x111E9C0
	public string get_Prefix() { }

	// RVA: 0x111E9C8
	public string get_StringValue() { }

	// RVA: 0x111E9D0
	public Double get_NumberValue() { }

	// RVA: 0x111E9D8
	public bool get_CanBeFunction() { }

	// RVA: 0x111E9E0
	private void SkipSpace() { }

	// RVA: 0x111CFC0
	public bool NextLex() { }

	// RVA: 0x111ECB0
	private Double ScanNumber() { }

	// RVA: 0x111EA68
	private Double ScanFraction() { }

	// RVA: 0x111EB74
	private string ScanString() { }

	// RVA: 0x111EE78
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

	// RVA: 0x111EF38
	internal void .ctor(XPathNavigator nav, Query query) { }

	// RVA: 0x111EFAC
	protected void .ctor(XPathSelectionIterator it) { }

	// RVA: 0x111F0D0
	public override void Reset() { }

	// RVA: 0x111F0F4
	public override bool MoveNext() { }

	// RVA: 0x111F18C
	public override int get_Count() { }

	// RVA: 0x111F1B0
	public override XPathNavigator get_Current() { }

	// RVA: 0x111F1B8
	public override int get_CurrentPosition() { }

	// RVA: 0x111F1C0
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathSelfQuery
{
	// Methods

	// RVA: 0x11154CC
	public void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x111F224
	private void .ctor(XPathSelfQuery other) { }

	// RVA: 0x111F22C
	public override XPathNavigator Advance() { }

	// RVA: 0x111F2C4
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathSingletonIterator
{
	// Fields
	private XPathNavigator _nav; // 0x18
	private int _position; // 0x20

	// Methods

	// RVA: 0x111F32C
	public void .ctor(XPathNavigator nav) { }

	// RVA: 0x111F368
	public void .ctor(XPathNavigator nav, bool moved) { }

	// RVA: 0x111F3C0
	public void .ctor(XPathSingletonIterator it) { }

	// RVA: 0x111F428
	public override XPathNodeIterator Clone() { }

	// RVA: 0x111F4CC
	public override XPathNavigator get_Current() { }

	// RVA: 0x111F4D4
	public override int get_CurrentPosition() { }

	// RVA: 0x111F4DC
	public override int get_Count() { }

	// RVA: 0x111F4E4
	public override bool MoveNext() { }

	// RVA: 0x111F50C
	public override void Reset() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathDocumentBaseIterator
{
	// Fields
	protected XPathDocumentNavigator ctxt; // 0x18
	protected int pos; // 0x20

	// Methods

	// RVA: 0x111F514
	protected void .ctor(XPathDocumentNavigator ctxt) { }

	// RVA: 0x111F64C
	protected void .ctor(XPathDocumentBaseIterator iter) { }

	// RVA: 0x111F6E0
	public override XPathNavigator get_Current() { }

	// RVA: 0x111F6E8
	public override int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentElementChildIterator
{
	// Fields
	private string _localName; // 0x28
	private string _namespaceUri; // 0x30

	// Methods

	// RVA: 0x111F6F0
	public void .ctor(XPathDocumentNavigator parent, string name, string namespaceURI) { }

	// RVA: 0x111F818
	public void .ctor(XPathDocumentElementChildIterator iter) { }

	// RVA: 0x111F8C8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x111F92C
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentKindChildIterator
{
	// Fields
	private XPathNodeType _typ; // 0x24

	// Methods

	// RVA: 0x111F9BC
	public void .ctor(XPathDocumentNavigator parent, XPathNodeType typ) { }

	// RVA: 0x111FA4C
	public void .ctor(XPathDocumentKindChildIterator iter) { }

	// RVA: 0x111FAE0
	public override XPathNodeIterator Clone() { }

	// RVA: 0x111FBD0
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

	// RVA: 0x111FC60
	public void .ctor(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x111FE20
	public void .ctor(XPathDocumentElementDescendantIterator iter) { }

	// RVA: 0x111FEEC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x111FF50
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

	// RVA: 0x11200C0
	public void .ctor(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf) { }

	// RVA: 0x11201EC
	public void .ctor(XPathDocumentKindDescendantIterator iter) { }

	// RVA: 0x11202A0
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1120304
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

	// RVA: 0x11204A8
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x111F590
	public void .ctor(XPathDocumentNavigator nav) { }

	// RVA: 0x1120554
	public override string get_Value() { }

	// RVA: 0x1120ABC
	public override XPathNavigator Clone() { }

	// RVA: 0x1120B98
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x1120BE0
	public override string get_LocalName() { }

	// RVA: 0x1120C40
	public override string get_NamespaceURI() { }

	// RVA: 0x1120CA0
	public override string get_Name() { }

	// RVA: 0x1120DB8
	public override string get_Prefix() { }

	// RVA: 0x1120E18
	public override string get_BaseURI() { }

	// RVA: 0x1120F98
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1121000
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1121128
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1121208
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1121464
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x1121864
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x1121A8C
	public override bool MoveToNext() { }

	// RVA: 0x1121B5C
	public override bool MoveToFirstChild() { }

	// RVA: 0x1121D34
	public override bool MoveToParent() { }

	// RVA: 0x1121EBC
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x1121F68
	public override bool MoveToId(string id) { }

	// RVA: 0x1122014
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x11220CC
	public override void MoveToRoot() { }

	// RVA: 0x1122174
	public override bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x112236C
	public override bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x1122550
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x11227B0
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x112294C
	public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x1122F30
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x11233F8
	public override XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x11234BC
	public override XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x112355C
	public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x11235D8
	public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x1123690
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x11238F4
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x11237BC
	private int GetPrimaryLocation() { }

	// RVA: 0x1123838
	private int GetSecondaryLocation() { }

	// RVA: 0x1123A74
	public override object get_UnderlyingObject() { }

	// RVA: 0x1123A84
	public bool HasLineInfo() { }

	// RVA: 0x1123ACC
	public int get_LineNumber() { }

	// RVA: 0x1123B90
	public int get_LinePosition() { }

	// RVA: 0x1123CB4
	public int GetPositionHashCode() { }

	// RVA: 0x111FFC4
	public bool IsElementMatch(string localName, string namespaceURI) { }

	// RVA: 0x1120408
	public bool IsKindMatch(XPathNodeType typ) { }

	// RVA: 0x1122ACC
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

	// RVA: 0x1120BD4
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1120DF8
	public string get_Prefix() { }

	// RVA: 0x1120C20
	public string get_LocalName() { }

	// RVA: 0x1120D3C
	public string get_Name() { }

	// RVA: 0x1120C80
	public string get_NamespaceUri() { }

	// RVA: 0x1120FE0
	public XPathDocument get_Document() { }

	// RVA: 0x1120F38
	public string get_BaseUri() { }

	// RVA: 0x1123B64
	public int get_LineNumber() { }

	// RVA: 0x1123C8C
	public int get_LinePosition() { }

	// RVA: 0x1123C5C
	public int get_CollapsedLinePosition() { }

	// RVA: 0x1123D10
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x112214C
	public int GetRoot(XPathNode[] pageNode) { }

	// RVA: 0x1120F58
	public int GetParent(XPathNode[] pageNode) { }

	// RVA: 0x1121824
	public int GetSibling(XPathNode[] pageNode) { }

	// RVA: 0x1123D30
	public int GetSimilarElement(XPathNode[] pageNode) { }

	// RVA: 0x1123D70
	public bool NameMatch(string localName, string namespaceName) { }

	// RVA: 0x1123CC0
	public bool ElementMatch(string localName, string namespaceName) { }

	// RVA: 0x1121798
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x1123DB0
	public bool get_HasSibling() { }

	// RVA: 0x1121C1C
	public bool get_HasCollapsedText() { }

	// RVA: 0x1123DC0
	public bool get_HasAttribute() { }

	// RVA: 0x1123DCC
	public bool get_HasContentChild() { }

	// RVA: 0x1123DD8
	public bool get_HasElementChild() { }

	// RVA: 0x1123DE4
	public bool get_IsAttrNmsp() { }

	// RVA: 0x1123DF8
	public bool get_IsText() { }

	// RVA: 0x1123E88
	public bool get_HasNamespaceDecls() { }

	// RVA: 0x1123E94
	public string get_Value() { }

}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNodeRef
{
	// Fields
	private XPathNode[] _page; // 0x10
	private int _idx; // 0x18

	// Methods

	// RVA: 0x1123E9C
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0x1123EC8
	public XPathNode[] get_Page() { }

	// RVA: 0x1123ED0
	public int get_Index() { }

	// RVA: 0x1123ED8
	public override int GetHashCode() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathNodeHelper
{
	// Methods

	// RVA: 0x11215EC
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x1121668
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x11210A4
	public static bool GetFirstAttribute(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1121138
	public static bool GetNextAttribute(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1121C28
	public static bool GetContentChild(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1121A9C
	public static bool GetContentSibling(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1121E24
	public static bool GetParent(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1123A38
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x112220C
	public static bool GetElementChild(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x1122404
	public static bool GetElementSibling(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x1122638
	public static bool GetContentChild(XPathNode[] pageNode, int idxNode, XPathNodeType typ) { }

	// RVA: 0x11227C4
	public static bool GetContentSibling(XPathNode[] pageNode, int idxNode, XPathNodeType typ) { }

	// RVA: 0x11212E4
	public static bool GetAttribute(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x1122BB0
	public static bool GetElementFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName) { }

	// RVA: 0x112325C
	public static bool GetContentFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ) { }

	// RVA: 0x1120874
	public static bool GetTextFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x1120780
	public static bool GetNonDescendant(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1123F1C
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

	// RVA: 0x1123F88
	public int get_PageNumber() { }

	// RVA: 0x1123F90
	public int get_NodeCount() { }

	// RVA: 0x1123F98
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

	// RVA: 0x1123FA0
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x1123FA8
	public string get_LocalName() { }

	// RVA: 0x1123FB0
	public string get_NamespaceUri() { }

	// RVA: 0x1123FB8
	public string get_Prefix() { }

	// RVA: 0x1123FC0
	public string get_BaseUri() { }

	// RVA: 0x1123FC8
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x1123FD0
	public XPathNode[] get_SimilarElementPage() { }

	// RVA: 0x1123FD8
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x1123FE0
	public XPathDocument get_Document() { }

	// RVA: 0x1123FE8
	public int get_LineNumberBase() { }

	// RVA: 0x1123FF0
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

	// RVA: 0x1123FF8
	internal static UInt32 ComputeStringHash(string s) { }

}


