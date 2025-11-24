// Namespace: 
internal class <Module> 
{}

// Namespace: 
internal static class SR 
{
	// Methods

	// RVA: 0xFE8868
	string GetString(string name, object[] args) { }

	// RVA: 0xFE88DC
	string GetString(CultureInfo culture, string name, object[] args) { }

	// RVA: 0xFE88E4
	string Format(string resourceFormat, object p1) { }

}

// Namespace: Microsoft.CSharp
internal class CodeDomProvider 
{
	// Methods

	// RVA: 0xFE8958
	void .ctor() { }

}

// Namespace: Microsoft.CSharp
internal class CSharpCodeProvider 
{
	// Methods

	// RVA: 0xFE8960
	void .ctor() { }

}

// Namespace: System
internal class MonoTODOAttribute 
{
	// Methods

	// RVA: 0xFE8968
	void .ctor() { }

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

	// RVA: 0xFE8970
	void .cctor() { }

}

// Namespace: System.Xml
internal abstract class Base64Encoder 
{
	// Fields
	private Byte[] leftOverBytes; // 0x10
	private int leftOverBytesCount; // 0x18
	private Char[] charsLine; // 0x20

	// Methods

	// RVA: 0xFE8AA8
	void .ctor() { }

	// RVA: -1
	void WriteChars(Char[] chars, int index, int count) { }

	// RVA: 0xFE8B18
	void Encode(Byte[] buffer, int index, int count) { }

	// RVA: 0xFE8EBC
	void Flush() { }

}

// Namespace: System.Xml
internal class XmlRawWriterBase64Encoder 
{
	// Fields
	private XmlRawWriter rawWriter; // 0x28

	// Methods

	// RVA: 0xFE8F68
	void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0xFE8FEC
	void WriteChars(Char[] chars, int index, int count) { }

}

// Namespace: System.Xml
internal class XmlTextWriterBase64Encoder 
{
	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0xFE9014
	void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0xFE9098
	void WriteChars(Char[] chars, int index, int count) { }

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

	// RVA: 0xFE90B8
	bool get_IsFull() { }

	// RVA: 0xFE90C8
	int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0xFE94CC
	Byte[] Decode(Char[] chars, bool allowOddChars) { }

	// RVA: 0xFE9240
	void Decode(Char* pChars, Char* pCharsEndPos, Byte* pBytes, Byte* pBytesEndPos, ref bool hasHalfByteCached, ref Byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

}

// Namespace: System.Xml
internal static class BinHexEncoder 
{
	// Methods

	// RVA: 0xFE96B8
	void Encode(Byte[] buffer, int index, int count, XmlWriter writer) { }

	// RVA: 0xFE99C4
	string Encode(Byte[] inArray, int offsetIn, int count) { }

	// RVA: 0xFE9888
	int Encode(Byte[] inArray, int offsetIn, int count, Char[] outArray) { }

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

	// RVA: 0xFE9B1C
	bool get_IsPositive() { }

	// RVA: 0xFE9B2C
	void .ctor(Byte[] data, int offset, bool trim) { }

	// RVA: 0xFE9DDC
	UInt32 UIntFromByteArray(Byte[] data, int offset) { }

	// RVA: 0xFEA038
	void MpDiv1(UInt32[] rgulU, ref int ciulU, UInt32 iulD, out UInt32 iulR) { }

	// RVA: 0xFEA170
	void MpNormalize(UInt32[] rgulU, ref int ciulU) { }

	// RVA: 0xFEA1C4
	Char ChFromDigit(UInt32 uiDigit) { }

	// RVA: 0xFEA1D0
	Decimal ToDecimal() { }

	// RVA: 0xFE9E50
	void TrimTrailingZeros() { }

	// RVA: 0xFEA2F8
	string ToString() { }

	// RVA: 0xFEA810
	void .cctor() { }

}

// Namespace: System.Xml
internal struct BinXmlSqlMoney 
{
	// Fields
	private Int64 data; // 0x10

	// Methods

	// RVA: 0xFEA958
	void .ctor(int v) { }

	// RVA: 0xFEA964
	void .ctor(Int64 v) { }

	// RVA: 0xFEA96C
	Decimal ToDecimal() { }

	// RVA: 0xFEA9E0
	string ToString() { }

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

	// RVA: 0xFEAAFC
	void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0xFEAB6C
	void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0xFEACC8
	void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0xFEAD84
	void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0xFEAEC4
	void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0xFEB104
	void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0xFEB3B8
	void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0xFEB4E0
	void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0xFEB618
	void BreakDownXsdDateTime(Int64 val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0xFEB7E4
	void BreakDownXsdDate(Int64 val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	// RVA: 0xFEB950
	void BreakDownXsdTime(Int64 val, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0xFEBA60
	string XsdDateTimeToString(Int64 val) { }

	// RVA: 0xFEBB78
	string XsdDateToString(Int64 val) { }

	// RVA: 0xFEBC68
	string XsdTimeToString(Int64 val) { }

	// RVA: 0xFEBE30
	string SqlDateTimeToString(int dateticks, UInt32 timeticks) { }

	// RVA: 0xFEBF88
	DateTime SqlDateTimeToDateTime(int dateticks, UInt32 timeticks) { }

	// RVA: 0xFEC088
	string SqlSmallDateTimeToString(Int16 dateticks, UInt16 timeticks) { }

	// RVA: 0xFEC1E8
	DateTime SqlSmallDateTimeToDateTime(Int16 dateticks, UInt16 timeticks) { }

	// RVA: 0xFEC25C
	DateTime XsdKatmaiDateToDateTime(Byte[] data, int offset) { }

	// RVA: 0xFEC3BC
	DateTime XsdKatmaiDateTimeToDateTime(Byte[] data, int offset) { }

	// RVA: 0xFEC6EC
	DateTime XsdKatmaiTimeToDateTime(Byte[] data, int offset) { }

	// RVA: 0xFEC778
	DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0xFEC804
	DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0xFEC9A0
	DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0xFECA2C
	string XsdKatmaiDateToString(Byte[] data, int offset) { }

	// RVA: 0xFECB54
	string XsdKatmaiDateTimeToString(Byte[] data, int offset) { }

	// RVA: 0xFECDF4
	string XsdKatmaiTimeToString(Byte[] data, int offset) { }

	// RVA: 0xFECF78
	string XsdKatmaiDateOffsetToString(Byte[] data, int offset) { }

	// RVA: 0xFED104
	string XsdKatmaiDateTimeOffsetToString(Byte[] data, int offset) { }

	// RVA: 0xFED3E8
	string XsdKatmaiTimeOffsetToString(Byte[] data, int offset) { }

	// RVA: 0xFEC344
	Int64 GetKatmaiDateTicks(Byte[] data, ref int pos) { }

	// RVA: 0xFEC4C0
	Int64 GetKatmaiTimeTicks(Byte[] data, ref int pos) { }

	// RVA: 0xFEC948
	Int64 GetKatmaiTimeZoneTicks(Byte[] data, int pos) { }

	// RVA: 0xFECCDC
	int GetFractions(DateTime dt) { }

	// RVA: 0xFED2A4
	int GetFractions(DateTimeOffset dt) { }

	// RVA: 0xFED584
	void .cctor() { }

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

	// RVA: 0xFF4160
	void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0xFF2998
	void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0xFEDD50
	void Clear() { }

	// RVA: 0xFF3914
	bool MatchNs(string lname, string nsUri) { }

	// RVA: 0xFF3964
	bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0xFF3D60
	void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0xFF845C
	int GetHashCode() { }

	// RVA: 0xFF84AC
	int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0xFF8504
	bool Equals(object other) { }

	// RVA: 0xFF52C4
	string ToString() { }

	// RVA: 0xFF85C0
	bool op_Equality(QName a, QName b) { }

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

	// RVA: 0xFF67E8
	void Set(QName name, bool xmlspacePreserve) { }

	// RVA: 0xFF556C
	NamespaceDecl Clear() { }

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

	// RVA: 0xFF41B0
	void Set(QName n, string v) { }

	// RVA: 0xFF4830
	void Set(QName n, int pos) { }

	// RVA: 0xFF5234
	void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri) { }

	// RVA: 0xFF5338
	int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri) { }

	// RVA: 0xFF5274
	bool MatchNS(string localname, string namespaceUri) { }

	// RVA: 0xFF53B8
	bool MatchHashNS(int hash, string localname, string namespaceUri) { }

	// RVA: 0xFF2F30
	void AdjustPosition(int adj) { }

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

	// RVA: 0xFF2394
	void .ctor(string prefix, string nsuri, NamespaceDecl nextInScope, NamespaceDecl prevDecl, int scope, bool implied) { }

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

	// RVA: 0xFEDC6C
	void Init() { }

}

// Namespace: 
private class NestedBinXml 
{
	// Fields
	public SymbolTables symbolTables; // 0x10
	public int docState; // 0x30
	public NestedBinXml next; // 0x38

	// Methods

	// RVA: 0xFF6838
	void .ctor(SymbolTables symbolTables, int docState, NestedBinXml next) { }

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

	// RVA: 0xFED64C
	void .ctor(Stream stream, Byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0xFEEB24
	XmlReaderSettings get_Settings() { }

	// RVA: 0xFEEC4C
	XmlNodeType get_NodeType() { }

	// RVA: 0xFEEC54
	string get_LocalName() { }

	// RVA: 0xFEEC5C
	string get_NamespaceURI() { }

	// RVA: 0xFEEC64
	string get_Prefix() { }

	// RVA: 0xFEEC6C
	string get_Value() { }

	// RVA: 0xFEFB84
	int get_Depth() { }

	// RVA: 0xFEFC60
	string get_BaseURI() { }

	// RVA: 0xFEFC68
	bool get_IsEmptyElement() { }

	// RVA: 0xFEFC8C
	XmlSpace get_XmlSpace() { }

	// RVA: 0xFEFD14
	string get_XmlLang() { }

	// RVA: 0xFEFDDC
	Type get_ValueType() { }

	// RVA: 0xFEFDE4
	int get_AttributeCount() { }

	// RVA: 0xFEFE40
	string GetAttribute(string name, string ns) { }

	// RVA: 0xFF00B4
	string GetAttribute(string name) { }

	// RVA: 0xFF023C
	string GetAttribute(int i) { }

	// RVA: 0xFF02DC
	bool MoveToAttribute(string name) { }

	// RVA: 0xFF0480
	void MoveToAttribute(int i) { }

	// RVA: 0xFF0534
	bool MoveToFirstAttribute() { }

	// RVA: 0xFF05C8
	bool MoveToNextAttribute() { }

	// RVA: 0xFF0660
	bool MoveToElement() { }

	// RVA: 0xFF0750
	bool get_EOF() { }

	// RVA: 0xFF0760
	bool ReadAttributeValue() { }

	// RVA: 0xFF0C58
	void Close() { }

	// RVA: 0xFF0CFC
	XmlNameTable get_NameTable() { }

	// RVA: 0xFF0D04
	string LookupNamespace(string prefix) { }

	// RVA: 0xFF0DE0
	void ResolveEntity() { }

	// RVA: 0xFF0E20
	ReadState get_ReadState() { }

	// RVA: 0xFF0EC4
	bool Read() { }

	// RVA: 0xFF1C98
	System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0xFF20D8
	string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0xFF22B0
	void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0xFEDDD4
	void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0xFF2430
	void AddName() { }

	// RVA: 0xFF2628
	void AddQName() { }

	// RVA: 0xFF29E8
	void NameFlush() { }

	// RVA: 0xFF2A44
	void SkipExtn() { }

	// RVA: 0xFF2C20
	int ReadQNameRef() { }

	// RVA: 0xFF28F0
	int ReadNameRef() { }

	// RVA: 0xFF2CC8
	bool FillAllowEOF() { }

	// RVA: 0xFF2F44
	void Fill_(int require) { }

	// RVA: 0xFF2B90
	void Fill(int require) { }

	// RVA: 0xFF3038
	Byte ReadByte() { }

	// RVA: 0xFF30E8
	UInt16 ReadUShort() { }

	// RVA: 0xFF2B54
	int ParseMB32() { }

	// RVA: 0xFF31B8
	int ParseMB32_(Byte b) { }

	// RVA: 0xFF3260
	int ParseMB32(int pos) { }

	// RVA: 0xFF3368
	int ParseMB64() { }

	// RVA: 0xFF33A4
	BinXmlToken PeekToken() { }

	// RVA: 0xFF3420
	BinXmlToken ReadToken() { }

	// RVA: 0xFF34A4
	BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0xFF35B0
	BinXmlToken NextToken1() { }

	// RVA: 0xFF36A0
	BinXmlToken NextToken() { }

	// RVA: 0xFF3708
	BinXmlToken PeekNextToken() { }

	// RVA: 0xFF0978
	BinXmlToken RescanNextToken() { }

	// RVA: 0xFF255C
	string ParseText() { }

	// RVA: 0xFF3788
	int ScanText(out int start) { }

	// RVA: 0xFEEDCC
	string GetString(int pos, int cch) { }

	// RVA: 0xFF38D4
	string GetStringAligned(Byte[] data, int offset, int cch) { }

	// RVA: 0xFEFA20
	string GetAttributeText(int i) { }

	// RVA: 0xFEFFEC
	int LocateAttribute(string name, string ns) { }

	// RVA: 0xFF0134
	int LocateAttribute(string name) { }

	// RVA: 0xFF0394
	void PositionOnAttribute(int i) { }

	// RVA: 0xFF39B0
	void GrowElements() { }

	// RVA: 0xFF3A40
	void GrowAttributes() { }

	// RVA: 0xFF3AD8
	void ClearAttributes() { }

	// RVA: 0xFF3AE8
	void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0xFF3E5C
	void PopNamespaces(NamespaceDecl firstInScopeChain) { }

	// RVA: 0xFF3F34
	void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0xFF10B4
	bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0xFF4200
	void ScanAttributes() { }

	// RVA: 0xFF4C4C
	void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0xFF4DE4
	void HashCheckForDuplicateAttributes() { }

	// RVA: 0xFEF100
	string XmlDeclValue() { }

	// RVA: 0xFEEF3C
	string CDATAValue() { }

	// RVA: 0xFF5414
	void FinishCDATA() { }

	// RVA: 0xFF5500
	void FinishEndElement() { }

	// RVA: 0xFF16EC
	bool ReadDoc() { }

	// RVA: 0xFF6594
	void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0xFF5598
	void ImplReadElement() { }

	// RVA: 0xFF5914
	void ImplReadEndElement() { }

	// RVA: 0xFF59F8
	void ImplReadDoctype() { }

	// RVA: 0xFF5E00
	void ImplReadPI() { }

	// RVA: 0xFF5E70
	void ImplReadComment() { }

	// RVA: 0xFF5EA8
	void ImplReadCDATA() { }

	// RVA: 0xFF5F34
	void ImplReadNest() { }

	// RVA: 0xFF604C
	void ImplReadEndNest() { }

	// RVA: 0xFF60A8
	void ImplReadXmlText() { }

	// RVA: 0xFF6894
	void UpdateFromTextReader() { }

	// RVA: 0xFF036C
	bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0xFF676C
	void CheckAllowContent() { }

	// RVA: 0xFEDEF4
	void GenerateTokenTypeMap() { }

	// RVA: 0xFF0B4C
	Type GetValueType(BinXmlToken token) { }

	// RVA: 0xFF0B40
	void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0xFF4970
	XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0xFF6C14
	XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0xFF696C
	XmlNodeType CheckText(bool attr) { }

	// RVA: 0xFF6B70
	XmlNodeType CheckTextIsWS() { }

	// RVA: 0xFF7158
	void CheckValueTokenBounds() { }

	// RVA: 0xFF7000
	int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0xFF71C4
	int XsdKatmaiTimeScaleToValueLength(Byte scale) { }

	// RVA: 0xFF7298
	Int64 ValueAsLong() { }

	// RVA: 0xFF7C18
	UInt64 ValueAsULong() { }

	// RVA: 0xFF79D0
	Decimal ValueAsDecimal() { }

	// RVA: 0xFF7858
	Double ValueAsDouble() { }

	// RVA: 0xFF7E04
	string ValueAsDateTimeString() { }

	// RVA: 0xFEF2B8
	string ValueAsString(BinXmlToken token) { }

	// RVA: 0xFF7528
	Int16 GetInt16(int pos) { }

	// RVA: 0xFF76C0
	UInt16 GetUInt16(int pos) { }

	// RVA: 0xFF7574
	int GetInt32(int pos) { }

	// RVA: 0xFF770C
	UInt32 GetUInt32(int pos) { }

	// RVA: 0xFF75EC
	Int64 GetInt64(int pos) { }

	// RVA: 0xFF7784
	UInt64 GetUInt64(int pos) { }

	// RVA: 0xFF7CB0
	float GetSingle(int offset) { }

	// RVA: 0xFF7D2C
	Double GetDouble(int offset) { }

	// RVA: 0xFF22F4
	Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0xFF2FC0
	Exception ThrowXmlException(string res) { }

	// RVA: 0xFF4880
	Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0xFF4BC8
	Exception ThrowNotSupported(string res) { }

	// RVA: 0xFF82A8
	void .cctor() { }

}

// Namespace: System.Xml
internal class BitStack 
{
	// Fields
	private UInt32[] bitStack; // 0x10
	private int stackPos; // 0x18
	private UInt32 curr; // 0x1C

	// Methods

	// RVA: 0xFF8624
	void .ctor() { }

	// RVA: 0xFF8650
	void PushBit(bool bit) { }

	// RVA: 0xFF87B4
	bool PopBit() { }

	// RVA: 0xFF885C
	bool PeekBit() { }

	// RVA: 0xFF86A0
	void PushCurr() { }

	// RVA: 0xFF8814
	void PopCurr() { }

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

	// RVA: 0xFF8868
	int Count(UInt32 num) { }

	// RVA: 0xFF8910
	int LeastPosition(UInt32 num) { }

	// RVA: 0xFF8A2C
	void .cctor() { }

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

	// RVA: 0xFF8A88
	void .ctor(int growthRate) { }

	// RVA: 0xFF8B08
	void Push(Byte data) { }

	// RVA: 0xFF8C08
	Byte Pop() { }

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

	// RVA: 0xFF8C58
	void .ctor() { }

	// RVA: 0xFF8C60
	EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0xFF8DEC
	int get_MaxCharCount() { }

	// RVA: 0xFF8DF4
	void set_StartOffset(int value) { }

	// RVA: 0xFF8DFC
	void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0xFF8E2C
	bool CanReplaceAt(int index) { }

}

// Namespace: System.Xml
internal class CharEntityEncoderFallbackBuffer 
{
	// Fields
	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	// Methods

	// RVA: 0xFF8D64
	void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0xFF8EB8
	bool Fallback(Char charUnknown, int index) { }

	// RVA: 0xFF9120
	bool Fallback(Char charUnknownHigh, Char charUnknownLow, int index) { }

	// RVA: 0xFF944C
	Char GetNextChar() { }

	// RVA: 0xFF94A8
	bool MovePrevious() { }

	// RVA: 0xFF94C4
	int get_Remaining() { }

	// RVA: 0xFF9500
	void Reset() { }

	// RVA: 0xFF9440
	int SurrogateCharToUtf32(Char highSurrogate, Char lowSurrogate) { }

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

	// RVA: 0xFF950C
	void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0xFF9740
	void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0xFF9770
	void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0xFF9774
	void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0xFF9778
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xFF9A08
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xFF9B40
	void StartElementContent() { }

	// RVA: 0xFF9CC0
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xFF9E00
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xFF9F40
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xFFA0CC
	void WriteEndAttribute() { }

	// RVA: 0xFFA210
	void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0xFFA354
	void WriteString(string text) { }

	// RVA: 0xFFA4A4
	void WriteEntityRef(string name) { }

	// RVA: 0xFFA500
	void WriteCharEntity(Char ch) { }

	// RVA: 0xFFA55C
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0xFFA5B8
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0xFF953C
	void Init(XmlWriterSettings settings) { }

	// RVA: 0xFF9B98
	void WriteMetaElement() { }

	// RVA: 0xFFA48C
	void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0xFFA448
	void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0xFFA99C
	void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0xFFA64C
	void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0xFFA178
	void OutputRestAmps() { }

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

	// RVA: 0xFFABF0
	void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0xFFAC8C
	void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0xFFACE4
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xFFAD0C
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xFFAF94
	void StartElementContent() { }

	// RVA: 0xFFB04C
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xFFB13C
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xFFB1F0
	void FlushBuffer() { }

	// RVA: 0xFFAC48
	void Init(XmlWriterSettings settings) { }

	// RVA: 0xFFAF40
	void WriteIndent() { }

}

// Namespace: System.Xml
internal abstract class HtmlTernaryTree 
{
	// Fields
	internal static Byte[] htmlElements; // 0x0
	internal static Byte[] htmlAttributes; // 0x8

	// Methods

	// RVA: 0xFFB220
	void .cctor() { }

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

	// RVA: 0xFFB310
	void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0xFFB544
	void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0xFFB548
	void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0xFFB54C
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xFFB7EC
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xFFB904
	void StartElementContent() { }

	// RVA: 0xFFBA88
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xFFBBB0
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xFFBCD8
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xFFBE54
	void WriteEndAttribute() { }

	// RVA: 0xFFBF94
	void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0xFFC0B8
	void WriteString(string text) { }

	// RVA: 0xFFC1E8
	void WriteEntityRef(string name) { }

	// RVA: 0xFFC244
	void WriteCharEntity(Char ch) { }

	// RVA: 0xFFC2A0
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0xFFC2FC
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0xFFB340
	void Init(XmlWriterSettings settings) { }

	// RVA: 0xFFB960
	void WriteMetaElement() { }

	// RVA: 0xFFC1D0
	void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0xFFC18C
	void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0xFFC67C
	void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0xFFC344
	void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0xFFBECC
	void OutputRestAmps() { }

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

	// RVA: 0x10FCB58
	void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x10FCBE8
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x10FCC14
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x10FCFE0
	void StartElementContent() { }

	// RVA: 0x10FD0A0
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x10FD198
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x10FD250
	void FlushBuffer() { }

	// RVA: 0x10FCBA4
	void Init(XmlWriterSettings settings) { }

	// RVA: 0x10FCF8C
	void WriteIndent() { }

}

// Namespace: System.Xml
internal interface IDtdInfo 
{
	// Methods

	// RVA: 0x2FE360C
	XmlQualifiedName get_Name() { }

	// RVA: 0x2FE360C
	string get_InternalDtdSubset() { }

	// RVA: 0x2FE3054
	bool get_HasDefaultAttributes() { }

	// RVA: 0x2FE3054
	bool get_HasNonCDataAttributes() { }

	// RVA: 0x2FE37A0
	IDtdAttributeListInfo LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x2FE36BC
	IDtdEntityInfo LookupEntity(string name) { }

}

// Namespace: System.Xml
internal interface IDtdAttributeListInfo 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_HasNonCDataAttributes() { }

	// RVA: 0x2FE37A0
	IDtdAttributeInfo LookupAttribute(string prefix, string localName) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> LookupDefaultAttributes() { }

}

// Namespace: System.Xml
internal interface IDtdAttributeInfo 
{
	// Methods

	// RVA: 0x2FE360C
	string get_Prefix() { }

	// RVA: 0x2FE360C
	string get_LocalName() { }

	// RVA: 0x2FE32D4
	int get_LineNumber() { }

	// RVA: 0x2FE32D4
	int get_LinePosition() { }

	// RVA: 0x2FE3054
	bool get_IsNonCDataType() { }

	// RVA: 0x2FE3054
	bool get_IsDeclaredInExternal() { }

	// RVA: 0x2FE3054
	bool get_IsXmlAttribute() { }

}

// Namespace: System.Xml
internal interface IDtdDefaultAttributeInfo 
{
	// Methods

	// RVA: 0x2FE360C
	string get_DefaultValueExpanded() { }

	// RVA: 0x2FE360C
	object get_DefaultValueTyped() { }

	// RVA: 0x2FE32D4
	int get_ValueLineNumber() { }

	// RVA: 0x2FE32D4
	int get_ValueLinePosition() { }

}

// Namespace: System.Xml
internal interface IDtdEntityInfo 
{
	// Methods

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x2FE3054
	bool get_IsExternal() { }

	// RVA: 0x2FE3054
	bool get_IsDeclaredInExternal() { }

	// RVA: 0x2FE3054
	bool get_IsUnparsedEntity() { }

	// RVA: 0x2FE3054
	bool get_IsParameterEntity() { }

	// RVA: 0x2FE360C
	string get_BaseUriString() { }

	// RVA: 0x2FE360C
	string get_DeclaredUriString() { }

	// RVA: 0x2FE360C
	string get_SystemId() { }

	// RVA: 0x2FE360C
	string get_PublicId() { }

	// RVA: 0x2FE360C
	string get_Text() { }

	// RVA: 0x2FE32D4
	int get_LineNumber() { }

	// RVA: 0x2FE32D4
	int get_LinePosition() { }

}

// Namespace: System.Xml
internal interface IDtdParser 
{
	// Methods

	// RVA: -1
	IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x2FE3968
	IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

}

// Namespace: System.Xml
internal interface IDtdParserAdapter 
{
	// Methods

	// RVA: 0x2FE360C
	XmlNameTable get_NameTable() { }

	// RVA: 0x2FE360C
	IXmlNamespaceResolver get_NamespaceResolver() { }

	// RVA: 0x2FE360C
	Uri get_BaseUri() { }

	// RVA: 0x2FE360C
	Char[] get_ParsingBuffer() { }

	// RVA: 0x2FE32D4
	int get_ParsingBufferLength() { }

	// RVA: 0x2FE32D4
	int get_CurrentPosition() { }

	// RVA: 0x2FE42A4
	void set_CurrentPosition(int value) { }

	// RVA: 0x2FE32D4
	int get_LineNo() { }

	// RVA: 0x2FE32D4
	int get_LineStartPosition() { }

	// RVA: 0x2FE3054
	bool get_IsEof() { }

	// RVA: 0x2FE32D4
	int get_EntityStackLength() { }

	// RVA: 0x2FE3054
	bool get_IsEntityEolNormalized() { }

	// RVA: 0x2FE32D4
	int ReadData() { }

	// RVA: 0x2FE42A4
	void OnNewLine(int pos) { }

	// RVA: 0x2FE3404
	int ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: -1
	int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x2FE4574
	void ParsePI(StringBuilder sb) { }

	// RVA: 0x2FE4574
	void ParseComment(StringBuilder sb) { }

	// RVA: -1
	bool PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: -1
	bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: -1
	bool PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x2FE47D4
	void PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: -1
	void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: -1
	void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x2FE4574
	void Throw(Exception e) { }

}

// Namespace: System.Xml
internal interface IDtdParserAdapterWithValidation 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_DtdValidation() { }

	// RVA: 0x2FE360C
	IValidationEventHandling get_ValidationEventHandling() { }

}

// Namespace: System.Xml
internal interface IDtdParserAdapterV1 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_V1CompatibilityMode() { }

	// RVA: 0x2FE3054
	bool get_Normalization() { }

	// RVA: 0x2FE3054
	bool get_Namespaces() { }

}

// Namespace: System.Xml
internal sealed class OnRemoveWriter 
{
	// Methods

	// RVA: 0x10FD280
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x10FD3A0
	internal void Invoke(XmlRawWriter writer) { }

}

// Namespace: System.Xml
internal interface IValidationEventHandling 
{
	// Methods

	// RVA: 0x2FE360C
	object get_EventHandler() { }

	// RVA: 0x2FE45DC
	void SendEvent(Exception exception, XmlSeverityType severity) { }

}

// Namespace: System.Xml
internal abstract class IncrementalReadDecoder 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_IsFull() { }

	// RVA: -1
	int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0x10FD3B4
	void .ctor() { }

}

// Namespace: System.Xml
internal class IncrementalReadDummyDecoder 
{
	// Methods

	// RVA: 0x10FD3BC
	bool get_IsFull() { }

	// RVA: 0x10FD3C4
	int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0x10FD3CC
	void .ctor() { }

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

	// RVA: 0x10FD3D4
	void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x10FD784
	void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x10FD7CC
	void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x10FD7F4
	void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x10FD81C
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x10FD858
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x10FDA30
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x10FDAA0
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x10FDB10
	void StartElementContent() { }

	// RVA: 0x10FDB38
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x10FDB64
	void WriteEndAttribute() { }

	// RVA: 0x10FDB90
	void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x10FDBB8
	bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x10FDBE0
	void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x10FDC08
	void WriteEndNamespaceDeclaration() { }

	// RVA: 0x10FDC30
	void WriteCData(string text) { }

	// RVA: 0x10FDC58
	void WriteComment(string text) { }

	// RVA: 0x10FDC84
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x10FDCB0
	void WriteWhitespace(string ws) { }

	// RVA: 0x10FDDA0
	void WriteString(string text) { }

	// RVA: 0x10FDE3C
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x10FDF0C
	void WriteEntityRef(string name) { }

	// RVA: 0x10FDF38
	void WriteCharEntity(Char ch) { }

	// RVA: 0x10FDF64
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x10FDF90
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x10FE060
	void WriteRaw(string data) { }

	// RVA: 0x10FE0FC
	void Close() { }

	// RVA: 0x10FE1A4
	void Flush() { }

	// RVA: 0x10FDD4C
	bool StartCDataSection() { }

	// RVA: 0x10FDA28
	void EndCDataSection() { }

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

	// RVA: 0x10FE1CC
	void Finish() { }

	// RVA: 0x10FE4A0
	void Reset() { }

	// RVA: 0x10FE318
	bool MoveToNextContentNode(bool moveIfOnContentNode) { }

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

	// RVA: 0x10FE4AC
	void .ctor(Byte[] nodeBuffer) { }

	// RVA: 0x10FCE28
	Byte FindCaseInsensitiveString(string stringToFind) { }

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

	// RVA: 0x10FE884
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x10FE940
	internal int Invoke(string s, int sLen, Int64 additionalEntropy) { }

}

// Namespace: System.Xml
internal class SecureStringHasher 
{
	// Fields
	private static HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x10FE4E0
	void .ctor() { }

	// RVA: 0x10FE510
	bool Equals(string x, string y) { }

	// RVA: 0x10FE524
	int GetHashCode(string key) { }

	// RVA: 0x10FE810
	int GetHashCodeOfString(string key, int sLen, Int64 additionalEntropy) { }

	// RVA: 0x10FE5EC
	HashCodeOfStringDelegate GetHashCodeDelegate() { }

}

// Namespace: System.Xml
internal class TextEncodedRawTextWriter 
{
	// Methods

	// RVA: 0x10FE954
	void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x10FEA58
	void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x10FED88
	void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x10FED8C
	void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x10FED90
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x10FED94
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x10FED98
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x10FED9C
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x10FEDA0
	void StartElementContent() { }

	// RVA: 0x10FEDA4
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x10FEDB0
	void WriteEndAttribute() { }

	// RVA: 0x10FEDB8
	void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x10FEDBC
	bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x10FEDC4
	void WriteCData(string text) { }

	// RVA: 0x10FEE84
	void WriteComment(string text) { }

	// RVA: 0x10FEE88
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x10FEE8C
	void WriteEntityRef(string name) { }

	// RVA: 0x10FEE90
	void WriteCharEntity(Char ch) { }

	// RVA: 0x10FEE94
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x10FEE98
	void WriteWhitespace(string ws) { }

	// RVA: 0x10FEEA8
	void WriteString(string textBlock) { }

	// RVA: 0x10FEEB8
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x10FEF98
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x10FEFA8
	void WriteRaw(string data) { }

}

// Namespace: System.Xml
internal class TextUtf8RawTextWriter 
{
	// Methods

	// RVA: 0x10FEFB8
	void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x10FEFC0
	void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x10FEFC4
	void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x10FEFC8
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x10FEFCC
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x10FEFD0
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x10FEFD4
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x10FEFD8
	void StartElementContent() { }

	// RVA: 0x10FEFDC
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x10FEFE8
	void WriteEndAttribute() { }

	// RVA: 0x10FEFF0
	void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x10FEFF4
	bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x10FEFFC
	void WriteCData(string text) { }

	// RVA: 0x10FF004
	void WriteComment(string text) { }

	// RVA: 0x10FF008
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x10FF00C
	void WriteEntityRef(string name) { }

	// RVA: 0x10FF010
	void WriteCharEntity(Char ch) { }

	// RVA: 0x10FF014
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x10FF018
	void WriteWhitespace(string ws) { }

	// RVA: 0x10FF02C
	void WriteString(string textBlock) { }

	// RVA: 0x10FF040
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x10FF054
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x10FF068
	void WriteRaw(string data) { }

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

	// RVA: 0x10FF07C
	void .ctor() { }

	// RVA: 0x10FF184
	void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x10FF1B4
	string get_LocalName() { }

	// RVA: 0x10FF1BC
	void set_LocalName(string value) { }

	// RVA: 0x10FF1C4
	string get_Namespace() { }

	// RVA: 0x10FF1CC
	void set_Namespace(string value) { }

	// RVA: 0x10FF1D4
	string get_Prefix() { }

	// RVA: 0x10FF1DC
	void set_Prefix(string value) { }

	// RVA: 0x10FF1E4
	string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x10FF2A8
	int get_Depth() { }

	// RVA: 0x10FF2B0
	void set_Depth(int value) { }

	// RVA: 0x10FF2B8
	string get_RawValue() { }

	// RVA: 0x10FF2C0
	void set_RawValue(string value) { }

	// RVA: 0x10FF2C8
	string get_OriginalStringValue() { }

	// RVA: 0x10FF2D0
	XmlNodeType get_NodeType() { }

	// RVA: 0x10FF2D8
	void set_NodeType(XmlNodeType value) { }

	// RVA: 0x10FF2E0
	AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x10FF2E8
	void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x10FF2F0
	int get_LineNumber() { }

	// RVA: 0x10FF2F8
	int get_LinePosition() { }

	// RVA: 0x10FF0A8
	void Clear(XmlNodeType nodeType) { }

	// RVA: 0x10FF300
	void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x10FF308
	void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0x10FF41C
	void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0x10FF4D0
	void SetItemData(string value) { }

	// RVA: 0x10FF504
	void SetItemData(string value, string originalStringValue) { }

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

	// RVA: 0x10FF538
	XmlReader get_CoreReader() { }

	// RVA: 0x10FF540
	XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0x10FF9F8
	void .ctor(XmlReader reader) { }

	// RVA: 0x10FFAB4
	void CheckAsync() { }

	// RVA: 0x10FFB34
	XmlReaderSettings get_Settings() { }

	// RVA: 0x10FFD4C
	XmlNodeType get_NodeType() { }

	// RVA: 0x10FFD80
	string get_Name() { }

	// RVA: 0x10FFDB4
	string get_LocalName() { }

	// RVA: 0x10FFDE8
	string get_NamespaceURI() { }

	// RVA: 0x10FFE1C
	string get_Prefix() { }

	// RVA: 0x10FFE50
	string get_Value() { }

	// RVA: 0x10FFE84
	int get_Depth() { }

	// RVA: 0x10FFEB8
	string get_BaseURI() { }

	// RVA: 0x10FFEF0
	bool get_IsEmptyElement() { }

	// RVA: 0x10FFF28
	bool get_IsDefault() { }

	// RVA: 0x10FFF60
	Char get_QuoteChar() { }

	// RVA: 0x10FFF98
	XmlSpace get_XmlSpace() { }

	// RVA: 0x10FFFD0
	string get_XmlLang() { }

	// RVA: 0x1100008
	IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1100040
	Type get_ValueType() { }

	// RVA: 0x1100078
	int get_AttributeCount() { }

	// RVA: 0x11000B0
	string GetAttribute(string name) { }

	// RVA: 0x11000F0
	string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1100140
	string GetAttribute(int i) { }

	// RVA: 0x1100180
	bool MoveToAttribute(string name) { }

	// RVA: 0x11001C0
	void MoveToAttribute(int i) { }

	// RVA: 0x1100200
	bool MoveToFirstAttribute() { }

	// RVA: 0x1100238
	bool MoveToNextAttribute() { }

	// RVA: 0x1100270
	bool MoveToElement() { }

	// RVA: 0x11002A8
	bool ReadAttributeValue() { }

	// RVA: 0x11002E0
	bool Read() { }

	// RVA: 0x1100318
	bool get_EOF() { }

	// RVA: 0x1100350
	void Close() { }

	// RVA: 0x1100388
	ReadState get_ReadState() { }

	// RVA: 0x11003C0
	void Skip() { }

	// RVA: 0x11003F8
	XmlNameTable get_NameTable() { }

	// RVA: 0x1100430
	string LookupNamespace(string prefix) { }

	// RVA: 0x1100470
	bool get_CanResolveEntity() { }

	// RVA: 0x11004A8
	void ResolveEntity() { }

	// RVA: 0x11004E0
	bool get_CanReadValueChunk() { }

	// RVA: 0x1100518
	int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x1100570
	string ReadString() { }

	// RVA: 0x11005A8
	XmlNodeType MoveToContent() { }

	// RVA: 0x11005E0
	void ReadStartElement() { }

	// RVA: 0x1100618
	string ReadElementString() { }

	// RVA: 0x1100650
	void ReadEndElement() { }

	// RVA: 0x1100688
	bool IsStartElement(string localname, string ns) { }

	// RVA: 0x11006D8
	string ReadInnerXml() { }

	// RVA: 0x1100710
	bool get_HasAttributes() { }

	// RVA: 0x1100748
	void Dispose(bool disposing) { }

	// RVA: 0x1100798
	XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x11007D0
	IDtdInfo get_DtdInfo() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithNS 
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0x10FF93C
	void .ctor(XmlReader reader) { }

	// RVA: 0x1100808
	System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11008BC
	string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1100974
	string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfo 
{
	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Methods

	// RVA: 0x10FF880
	void .ctor(XmlReader reader) { }

	// RVA: 0x1100A2C
	bool HasLineInfo() { }

	// RVA: 0x1100AE0
	int get_LineNumber() { }

	// RVA: 0x1100B98
	int get_LinePosition() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNS 
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0x10FF7C4
	void .ctor(XmlReader reader) { }

	// RVA: 0x1100C50
	System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1100D04
	string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1100DBC
	string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNSSchema 
{
	// Fields
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; // 0x30

	// Methods

	// RVA: 0x10FF708
	void .ctor(XmlReader reader) { }

	// RVA: 0x1100E74
	XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1100F28
	bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1100FE0
	bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x1101098
	XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x1101150
	XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x1101208
	XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x11012C0
	XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckWriter 
{
	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Methods

	// RVA: 0x1101378
	void .ctor(XmlWriter writer) { }

	// RVA: 0x1101408
	void CheckAsync() { }

	// RVA: 0x1101488
	void WriteStartDocument() { }

	// RVA: 0x11014BC
	void WriteStartDocument(bool standalone) { }

	// RVA: 0x11014F8
	void WriteEndDocument() { }

	// RVA: 0x110152C
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1101590
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11015E4
	void WriteEndElement() { }

	// RVA: 0x1101618
	void WriteFullEndElement() { }

	// RVA: 0x110164C
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11016A0
	void WriteEndAttribute() { }

	// RVA: 0x11016D8
	void WriteCData(string text) { }

	// RVA: 0x1101718
	void WriteComment(string text) { }

	// RVA: 0x1101758
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11017A8
	void WriteEntityRef(string name) { }

	// RVA: 0x11017E8
	void WriteCharEntity(Char ch) { }

	// RVA: 0x1101828
	void WriteWhitespace(string ws) { }

	// RVA: 0x1101868
	void WriteString(string text) { }

	// RVA: 0x11018A8
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11018F8
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1101950
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11019A8
	void WriteRaw(string data) { }

	// RVA: 0x11019E8
	void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1101A40
	void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1101A98
	WriteState get_WriteState() { }

	// RVA: 0x1101AD0
	void Close() { }

	// RVA: 0x1101B08
	void Flush() { }

	// RVA: 0x1101B40
	string LookupPrefix(string ns) { }

	// RVA: 0x1101B80
	void WriteValue(string value) { }

	// RVA: 0x1101BC0
	void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1101C10
	void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1101C60
	void Dispose(bool disposing) { }

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

	// RVA: 0x1101C90
	void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0x1101DC0
	void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0x1101DF4
	void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0x1101E28
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1101EAC
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11021B4
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1102218
	void WriteEndAttribute() { }

	// RVA: 0x1102240
	void WriteCData(string text) { }

	// RVA: 0x1102334
	void WriteComment(string text) { }

	// RVA: 0x1102368
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x110239C
	void WriteWhitespace(string ws) { }

	// RVA: 0x11023D0
	void WriteString(string text) { }

	// RVA: 0x1102450
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x110248C
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11024C8
	void WriteRaw(string data) { }

	// RVA: 0x1102548
	void WriteEntityRef(string name) { }

	// RVA: 0x1102598
	void WriteCharEntity(Char ch) { }

	// RVA: 0x11025E8
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1102648
	void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x11026B0
	void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1102718
	void Close() { }

	// RVA: 0x1102760
	void Flush() { }

	// RVA: 0x11027A8
	void WriteValue(string value) { }

	// RVA: 0x11027F8
	void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1102854
	void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11028A4
	void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11028F4
	void StartElementContent() { }

	// RVA: 0x110291C
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1102944
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x110296C
	void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x11029CC
	bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x11029F4
	void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1102A44
	void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1101F30
	bool IsHtmlTag(string tagName) { }

	// RVA: 0x1101E9C
	void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0x11022C0
	bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0x110203C
	void CreateWrappedWriter(XmlOutputMethod outMethod) { }

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

	// RVA: 0x11031F8
	void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x10FE958
	void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x10FEA5C
	void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1103624
	void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x110395C
	void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11039E4
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1103D14
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1103E5C
	void StartElementContent() { }

	// RVA: 0x1103EA4
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1104094
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x110421C
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11043BC
	void WriteEndAttribute() { }

	// RVA: 0x1104480
	void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x11044D8
	bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x11044E0
	void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1104708
	void WriteEndNamespaceDeclaration() { }

	// RVA: 0x11047CC
	void WriteCData(string text) { }

	// RVA: 0x1104DA8
	void WriteComment(string text) { }

	// RVA: 0x11052EC
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1105488
	void WriteEntityRef(string name) { }

	// RVA: 0x11055BC
	void WriteCharEntity(Char ch) { }

	// RVA: 0x11057EC
	void WriteWhitespace(string ws) { }

	// RVA: 0x1105E98
	void WriteString(string text) { }

	// RVA: 0x1105F64
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x110611C
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x10FEEC8
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x10FEDC8
	void WriteRaw(string data) { }

	// RVA: 0x11064A0
	void Close() { }

	// RVA: 0x11065D0
	void Flush() { }

	// RVA: 0x1106640
	void FlushBuffer() { }

	// RVA: 0x1106884
	void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x1106528
	void FlushEncoder() { }

	// RVA: 0x11058B4
	void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1105B94
	void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x110391C
	void RawText(string s) { }

	// RVA: 0x1106DB4
	void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x11061FC
	void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x1104F28
	void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1104A00
	void WriteCDataSection(string text) { }

	// RVA: 0x1106AB0
	Char* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	// RVA: 0x1106C0C
	Char* InvalidXmlChar(int ch, Char* pDst, bool entitize) { }

	// RVA: 0x1107054
	void EncodeChar(ref Char* pSrc, Char* pSrcEnd, ref Char* pDst) { }

	// RVA: 0x11038A0
	void ChangeTextContentMark(bool value) { }

	// RVA: 0x110712C
	void GrowTextContentMarks() { }

	// RVA: 0x1106D30
	Char* WriteNewLine(Char* pDst) { }

	// RVA: 0x11069EC
	Char* LtEntity(Char* pDst) { }

	// RVA: 0x1106A04
	Char* GtEntity(Char* pDst) { }

	// RVA: 0x11069C8
	Char* AmpEntity(Char* pDst) { }

	// RVA: 0x1106A1C
	Char* QuoteEntity(Char* pDst) { }

	// RVA: 0x1106A44
	Char* TabEntity(Char* pDst) { }

	// RVA: 0x1106A8C
	Char* LineFeedEntity(Char* pDst) { }

	// RVA: 0x1106A68
	Char* CarriageReturnEntity(Char* pDst) { }

	// RVA: 0x1106F98
	Char* CharEntity(Char* pDst, Char ch) { }

	// RVA: 0x1106F64
	Char* RawStartCData(Char* pDst) { }

	// RVA: 0x1106F48
	Char* RawEndCData(Char* pDst) { }

	// RVA: 0x1103304
	void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

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

	// RVA: 0x11071B4
	void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1107300
	void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x110732C
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1107424
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x110749C
	void StartElementContent() { }

	// RVA: 0x1107524
	void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x110752C
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11075B4
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x110763C
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1107684
	void WriteCData(string text) { }

	// RVA: 0x1107690
	void WriteComment(string text) { }

	// RVA: 0x11076E8
	void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x110773C
	void WriteEntityRef(string name) { }

	// RVA: 0x1107748
	void WriteCharEntity(Char ch) { }

	// RVA: 0x1107754
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1107760
	void WriteWhitespace(string ws) { }

	// RVA: 0x110776C
	void WriteString(string text) { }

	// RVA: 0x1107778
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1107784
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1107790
	void WriteRaw(string data) { }

	// RVA: 0x110779C
	void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x11071E0
	void Init(XmlWriterSettings settings) { }

	// RVA: 0x1107398
	void WriteIndent() { }

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

	// RVA: 0x1108C34
	void InitEvent(XmlEventType eventType) { }

	// RVA: 0x1108B14
	void InitEvent(XmlEventType eventType, string s1) { }

	// RVA: 0x1108B24
	void InitEvent(XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x1108B60
	void InitEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x1108BB8
	void InitEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1108C24
	void InitEvent(XmlEventType eventType, object o) { }

	// RVA: 0x1108C3C
	XmlEventType get_EventType() { }

	// RVA: 0x1108C44
	string get_String1() { }

	// RVA: 0x1108C4C
	string get_String2() { }

	// RVA: 0x1108C54
	string get_String3() { }

	// RVA: 0x1108C5C
	object get_Object() { }

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

	// RVA: 0x1101D78
	void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x1102A6C
	void EndEvents() { }

	// RVA: 0x1102AC8
	void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x110794C
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1107A0C
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1107B2C
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1107BB8
	void WriteEndAttribute() { }

	// RVA: 0x1107C04
	void WriteCData(string text) { }

	// RVA: 0x1107CBC
	void WriteComment(string text) { }

	// RVA: 0x1107D14
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1107E04
	void WriteWhitespace(string ws) { }

	// RVA: 0x1107E5C
	void WriteString(string text) { }

	// RVA: 0x1107ED8
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1107F14
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1107F50
	void WriteRaw(string data) { }

	// RVA: 0x1107FA8
	void WriteEntityRef(string name) { }

	// RVA: 0x1108000
	void WriteCharEntity(Char ch) { }

	// RVA: 0x110810C
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11081D0
	void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1108380
	void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1108478
	void Close() { }

	// RVA: 0x11084C4
	void Flush() { }

	// RVA: 0x1108510
	void WriteValue(string value) { }

	// RVA: 0x1108520
	void Dispose(bool disposing) { }

	// RVA: 0x110862C
	void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11086D8
	void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1108730
	void StartElementContent() { }

	// RVA: 0x110877C
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1108808
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1108894
	void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x110890C
	void WriteEndBase64() { }

	// RVA: 0x1107900
	void AddEvent(XmlEventType eventType) { }

	// RVA: 0x1107C5C
	void AddEvent(XmlEventType eventType, string s1) { }

	// RVA: 0x1107D8C
	void AddEvent(XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x1107A98
	void AddEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x1107964
	void AddEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x11080AC
	void AddEvent(XmlEventType eventType, object o) { }

	// RVA: 0x1108958
	int NewEvent() { }

	// RVA: 0x11082C8
	Byte[] ToBytes(Byte[] buffer, int index, int count) { }

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

	// RVA: 0x1108C64
	void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x1108D10
	void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x1108D40
	void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x1109090
	XmlNameTable get_NameTable() { }

	// RVA: 0x1109098
	XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x11090A0
	string get_DocTypeName() { }

	// RVA: 0x11090A8
	string get_PublicId() { }

	// RVA: 0x11090B0
	string get_SystemId() { }

	// RVA: 0x11090B8
	string get_BaseURI() { }

	// RVA: 0x11090C0
	string get_InternalSubset() { }

	// RVA: 0x11090C8
	string get_XmlLang() { }

	// RVA: 0x11090D0
	XmlSpace get_XmlSpace() { }

	// RVA: 0x11090D8
	Encoding get_Encoding() { }

	// RVA: 0x11090E0
	bool get_HasDtdInfo() { }

}

// Namespace: System.Xml
internal abstract class XmlRawWriter 
{
	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Methods

	// RVA: 0x110918C
	void WriteStartDocument() { }

	// RVA: 0x11091E8
	void WriteStartDocument(bool standalone) { }

	// RVA: 0x1109244
	void WriteEndDocument() { }

	// RVA: 0x11092A0
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11092A4
	void WriteEndElement() { }

	// RVA: 0x1109300
	void WriteFullEndElement() { }

	// RVA: 0x1107850
	void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x110935C
	string LookupPrefix(string ns) { }

	// RVA: 0x11093B8
	WriteState get_WriteState() { }

	// RVA: 0x1109414
	void WriteCData(string text) { }

	// RVA: 0x1109424
	void WriteCharEntity(Char ch) { }

	// RVA: 0x11094BC
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x110956C
	void WriteWhitespace(string ws) { }

	// RVA: 0x110957C
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11095B8
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11095F4
	void WriteRaw(string data) { }

	// RVA: 0x1109604
	void WriteValue(string value) { }

	// RVA: 0x1109614
	void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1109670
	void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x11096CC
	void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x11096D4
	void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11096D8
	void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x2FE41A8
	void StartElementContent() { }

	// RVA: 0x11096DC
	void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: 0x2FE49A8
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11096E0
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x2FE47D4
	void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x11096F0
	bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x11096F8
	void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1109738
	void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1109778
	void WriteEndBase64() { }

	// RVA: 0x1109798
	void Close(WriteState currentState) { }

	// RVA: 0x10FD77C
	void .ctor() { }

}

// Namespace: System.Xml
public abstract class XmlReader 
{
	// Fields
	private static UInt32 IsTextualNodeBitmap; // 0x0
	private static UInt32 CanReadContentAsBitmap; // 0x4
	private static UInt32 HasValueBitmap; // 0x8

	// Methods

	// RVA: 0x11097A8
	XmlReaderSettings get_Settings() { }

	// RVA: 0x2FE32D4
	XmlNodeType get_NodeType() { }

	// RVA: 0x11097B0
	string get_Name() { }

	// RVA: 0x2FE360C
	string get_LocalName() { }

	// RVA: 0x2FE360C
	string get_NamespaceURI() { }

	// RVA: 0x2FE360C
	string get_Prefix() { }

	// RVA: 0x2FE360C
	string get_Value() { }

	// RVA: 0x2FE32D4
	int get_Depth() { }

	// RVA: 0x2FE360C
	string get_BaseURI() { }

	// RVA: 0x2FE3054
	bool get_IsEmptyElement() { }

	// RVA: 0x1109898
	bool get_IsDefault() { }

	// RVA: 0x11098A0
	Char get_QuoteChar() { }

	// RVA: 0x11098A8
	XmlSpace get_XmlSpace() { }

	// RVA: 0x11098B0
	string get_XmlLang() { }

	// RVA: 0x11098FC
	IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1109950
	Type get_ValueType() { }

	// RVA: 0x2FE32D4
	int get_AttributeCount() { }

	// RVA: 0x2FE36BC
	string GetAttribute(string name) { }

	// RVA: 0x2FE37A0
	string GetAttribute(string name, string namespaceURI) { }

	// RVA: -1
	string GetAttribute(int i) { }

	// RVA: 0x2FE3174
	bool MoveToAttribute(string name) { }

	// RVA: 0x11099F0
	void MoveToAttribute(int i) { }

	// RVA: 0x2FE3054
	bool MoveToFirstAttribute() { }

	// RVA: 0x2FE3054
	bool MoveToNextAttribute() { }

	// RVA: 0x2FE3054
	bool MoveToElement() { }

	// RVA: 0x2FE3054
	bool ReadAttributeValue() { }

	// RVA: 0x2FE3054
	bool Read() { }

	// RVA: 0x2FE3054
	bool get_EOF() { }

	// RVA: 0x1109ABC
	void Close() { }

	// RVA: 0x2FE32D4
	ReadState get_ReadState() { }

	// RVA: 0x1109AC0
	void Skip() { }

	// RVA: 0x2FE360C
	XmlNameTable get_NameTable() { }

	// RVA: 0x2FE36BC
	string LookupNamespace(string prefix) { }

	// RVA: 0x1109C88
	bool get_CanResolveEntity() { }

	// RVA: 0x2FE41A8
	void ResolveEntity() { }

	// RVA: 0x1109C90
	bool get_CanReadValueChunk() { }

	// RVA: 0x1109C98
	int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x1109CF4
	string ReadString() { }

	// RVA: 0x1109F94
	XmlNodeType MoveToContent() { }

	// RVA: 0x110A034
	void ReadStartElement() { }

	// RVA: 0x110A12C
	string ReadElementString() { }

	// RVA: 0x110A3C0
	void ReadEndElement() { }

	// RVA: 0x110A4B8
	bool IsStartElement(string localname, string ns) { }

	// RVA: 0x110A548
	string ReadInnerXml() { }

	// RVA: 0x110A9DC
	void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0x110A8C0
	void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0x110A848
	XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0x110AE40
	void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0x110AF78
	bool get_HasAttributes() { }

	// RVA: 0x1100784
	void Dispose() { }

	// RVA: 0x110AFA0
	void Dispose(bool disposing) { }

	// RVA: 0x110AFF4
	XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1109F24
	bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0x110AFFC
	bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0x1109BB0
	bool SkipSubtree() { }

	// RVA: 0x110B06C
	bool get_IsDefaultInternal() { }

	// RVA: 0x110B174
	IDtdInfo get_DtdInfo() { }

	// RVA: 0x110B17C
	XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x110B3DC
	XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x110B59C
	XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0x110B934
	int CalcBufferSize(Stream input) { }

	// RVA: 0x10FFAAC
	void .ctor() { }

	// RVA: 0x110BB20
	void .cctor() { }

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

	// RVA: 0x10FFCC0
	void .ctor() { }

	// RVA: 0x110BB88
	bool get_Async() { }

	// RVA: 0x10FFCEC
	void set_Async(bool value) { }

	// RVA: 0x110BC48
	XmlNameTable get_NameTable() { }

	// RVA: 0x110BC50
	void set_NameTable(XmlNameTable value) { }

	// RVA: 0x110BCB8
	bool get_IsXmlResolverSet() { }

	// RVA: 0x110BCC0
	void set_IsXmlResolverSet(bool value) { }

	// RVA: 0x110BCC8
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x110BD3C
	XmlResolver GetXmlResolver() { }

	// RVA: 0x110BD44
	XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x110BD88
	int get_LineNumberOffset() { }

	// RVA: 0x110BD90
	void set_LineNumberOffset(int value) { }

	// RVA: 0x110BDF0
	int get_LinePositionOffset() { }

	// RVA: 0x110BDF8
	void set_LinePositionOffset(int value) { }

	// RVA: 0x110BE58
	ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x110BE60
	void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x110BF10
	bool get_CheckCharacters() { }

	// RVA: 0x110BF18
	void set_CheckCharacters(bool value) { }

	// RVA: 0x110BF78
	Int64 get_MaxCharactersInDocument() { }

	// RVA: 0x110BF80
	void set_MaxCharactersInDocument(Int64 value) { }

	// RVA: 0x110C02C
	Int64 get_MaxCharactersFromEntities() { }

	// RVA: 0x110C034
	void set_MaxCharactersFromEntities(Int64 value) { }

	// RVA: 0x110C0E0
	bool get_IgnoreWhitespace() { }

	// RVA: 0x110C0E8
	void set_IgnoreWhitespace(bool value) { }

	// RVA: 0x110C148
	bool get_IgnoreProcessingInstructions() { }

	// RVA: 0x110C150
	void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0x110C1B0
	bool get_IgnoreComments() { }

	// RVA: 0x110C1B8
	void set_IgnoreComments(bool value) { }

	// RVA: 0x110C218
	DtdProcessing get_DtdProcessing() { }

	// RVA: 0x110C220
	void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x110C2D0
	bool get_CloseInput() { }

	// RVA: 0x110C2D8
	void set_CloseInput(bool value) { }

	// RVA: 0x110C338
	ValidationType get_ValidationType() { }

	// RVA: 0x110C340
	void set_ValidationType(ValidationType value) { }

	// RVA: 0x110C3F0
	XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x110C3F8
	void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0x110C4A8
	XmlSchemaSet get_Schemas() { }

	// RVA: 0x110C530
	void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x10FFC54
	XmlReaderSettings Clone() { }

	// RVA: 0x110C598
	ValidationEventHandler GetEventHandler() { }

	// RVA: 0x110B210
	XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x110B46C
	XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x110C5A0
	void set_ReadOnly(bool value) { }

	// RVA: 0x110BB90
	void CheckReadOnly(string propertyName) { }

	// RVA: 0x110BB80
	void Initialize() { }

	// RVA: 0x110C5A8
	void Initialize(XmlResolver resolver) { }

	// RVA: 0x110C828
	XmlResolver CreateDefaultResolver() { }

	// RVA: 0x110B9C4
	XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0x110C880
	XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0x110C6A0
	bool EnableLegacyXmlSettings() { }

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

	// RVA: 0x110C904
	void .ctor(TextWriter textWriter) { }

	// RVA: 0x110C958
	void set_QuoteChar(Char value) { }

	// RVA: 0x110C960
	void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0x110CA20
	void EndAttribute() { }

	// RVA: 0x110CA64
	string get_AttributeValue() { }

	// RVA: 0x110CADC
	void WriteSurrogateChar(Char lowChar, Char highChar) { }

	// RVA: 0x110CB9C
	void Write(Char[] array, int offset, int count) { }

	// RVA: 0x110D1FC
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x110D384
	void Write(string text) { }

	// RVA: 0x110D9E4
	void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0x110DBD4
	void WriteRaw(Char[] array, int offset, int count) { }

	// RVA: 0x110DD18
	void WriteCharEntity(Char ch) { }

	// RVA: 0x110DF00
	void WriteEntityRef(string name) { }

	// RVA: 0x110D930
	void WriteStringFragment(string str, int offset, int count, Char[] helperBuffer) { }

	// RVA: 0x110D104
	void WriteCharEntityImpl(Char ch) { }

	// RVA: 0x110DE5C
	void WriteCharEntityImpl(string strVal) { }

	// RVA: 0x110D188
	void WriteEntityRefImpl(string name) { }

}

// Namespace: System.Xml
public class XmlTextReader 
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Methods

	// RVA: 0x110DFB8
	void .ctor(Stream input) { }

	// RVA: 0x110E07C
	void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x110E158
	void .ctor(TextReader input) { }

	// RVA: 0x110E21C
	void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x110E2F0
	XmlNodeType get_NodeType() { }

	// RVA: 0x110E314
	string get_Name() { }

	// RVA: 0x110E338
	string get_LocalName() { }

	// RVA: 0x110E35C
	string get_NamespaceURI() { }

	// RVA: 0x110E380
	string get_Prefix() { }

	// RVA: 0x110E3A4
	string get_Value() { }

	// RVA: 0x110E3C8
	int get_Depth() { }

	// RVA: 0x110E3EC
	string get_BaseURI() { }

	// RVA: 0x110E414
	bool get_IsEmptyElement() { }

	// RVA: 0x110E43C
	bool get_IsDefault() { }

	// RVA: 0x110E464
	Char get_QuoteChar() { }

	// RVA: 0x110E48C
	XmlSpace get_XmlSpace() { }

	// RVA: 0x110E4B4
	string get_XmlLang() { }

	// RVA: 0x110E4DC
	int get_AttributeCount() { }

	// RVA: 0x110E504
	string GetAttribute(string name) { }

	// RVA: 0x110E52C
	string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x110E554
	string GetAttribute(int i) { }

	// RVA: 0x110E57C
	bool MoveToAttribute(string name) { }

	// RVA: 0x110E5A4
	void MoveToAttribute(int i) { }

	// RVA: 0x110E5CC
	bool MoveToFirstAttribute() { }

	// RVA: 0x110E5F4
	bool MoveToNextAttribute() { }

	// RVA: 0x110E61C
	bool MoveToElement() { }

	// RVA: 0x110E644
	bool ReadAttributeValue() { }

	// RVA: 0x110E66C
	bool Read() { }

	// RVA: 0x110E694
	bool get_EOF() { }

	// RVA: 0x110E6BC
	void Close() { }

	// RVA: 0x110E6E4
	ReadState get_ReadState() { }

	// RVA: 0x110E70C
	void Skip() { }

	// RVA: 0x110E734
	XmlNameTable get_NameTable() { }

	// RVA: 0x110E75C
	string LookupNamespace(string prefix) { }

	// RVA: 0x110E798
	bool get_CanResolveEntity() { }

	// RVA: 0x110E7A0
	void ResolveEntity() { }

	// RVA: 0x110E7C8
	bool get_CanReadValueChunk() { }

	// RVA: 0x110E7D0
	string ReadString() { }

	// RVA: 0x110E804
	bool HasLineInfo() { }

	// RVA: 0x110E80C
	int get_LineNumber() { }

	// RVA: 0x110E82C
	int get_LinePosition() { }

	// RVA: 0x110E84C
	System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x110E86C
	string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x110E894
	string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x110AF58
	bool get_Namespaces() { }

	// RVA: 0x110E8B4
	bool get_Normalization() { }

	// RVA: 0x110E8D4
	void set_Normalization(bool value) { }

	// RVA: 0x110E8F4
	void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x110E914
	void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x110E934
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x110E954
	XmlTextReaderImpl get_Impl() { }

	// RVA: 0x110E95C
	XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x110E984
	void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x110E9A4
	IDtdInfo get_DtdInfo() { }

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

	// RVA: 0x110E9CC
	void .ctor() { }

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

	// RVA: 0x110E9DC
	void Clear() { }

	// RVA: 0x110EAD0
	void Close(bool closeInput) { }

	// RVA: 0x110EB08
	int get_LineNo() { }

	// RVA: 0x110EB10
	int get_LinePos() { }

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

	// RVA: 0x110EB20
	void .ctor() { }

	// RVA: 0x110EBB8
	void .ctor(XmlContext previousContext) { }

}

// Namespace: 
private class NoNamespaceManager 
{
	// Methods

	// RVA: 0x110EC1C
	void .ctor() { }

	// RVA: 0x110EC24
	string get_DefaultNamespace() { }

	// RVA: 0x110EC70
	void PushScope() { }

	// RVA: 0x110EC74
	bool PopScope() { }

	// RVA: 0x110EC7C
	void AddNamespace(string prefix, string uri) { }

	// RVA: 0x110EC80
	void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x110EC84
	IEnumerator GetEnumerator() { }

	// RVA: 0x110EC8C
	System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x110EC94
	string LookupNamespace(string prefix) { }

	// RVA: 0x110ECE0
	string LookupPrefix(string uri) { }

}

// Namespace: 
internal class DtdParserProxy 
{
	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Methods

	// RVA: 0x110ECE8
	void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x110ED1C
	XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x110ED3C
	IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x110ED5C
	Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x110ED7C
	bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x110ED9C
	Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x110EDBC
	int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x110EDDC
	int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x110EDFC
	void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x110EE1C
	int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x110EE3C
	bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x110EE5C
	void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x110EE7C
	int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x110EE9C
	int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x110EEBC
	int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x110EEDC
	int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x110EEFC
	int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x110EF1C
	void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x110EF3C
	void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x110EF5C
	bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x110EF7C
	bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x110EF9C
	bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x110EFBC
	void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x110EFDC
	void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x110EFFC
	void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x110F01C
	void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x110F03C
	bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x110F05C
	IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0x110F07C
	bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0x110F09C
	bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x110F0BC
	bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }

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

	// RVA: 0x110F0DC
	NodeData get_None() { }

	// RVA: 0x110F188
	void .ctor() { }

	// RVA: 0x110F26C
	int get_LineNo() { }

	// RVA: 0x110F274
	int get_LinePos() { }

	// RVA: 0x110F27C
	bool get_IsEmptyElement() { }

	// RVA: 0x110F2A0
	void set_IsEmptyElement(bool value) { }

	// RVA: 0x110F2A8
	bool get_IsDefaultAttribute() { }

	// RVA: 0x110F2CC
	void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x110F2D4
	bool get_ValueBuffered() { }

	// RVA: 0x110F2E4
	string get_StringValue() { }

	// RVA: 0x110F33C
	void TrimSpacesInValue() { }

	// RVA: 0x110F1BC
	void Clear(XmlNodeType type) { }

	// RVA: 0x110F398
	void ClearName() { }

	// RVA: 0x110F440
	void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x110F44C
	void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x110F458
	void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x110F498
	void SetValueNode(XmlNodeType type, Char[] chars, int startPos, int len) { }

	// RVA: 0x110F4F4
	void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x110F56C
	void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x110F644
	void SetValue(string value) { }

	// RVA: 0x110F654
	void SetValue(Char[] chars, int startPos, int len) { }

	// RVA: 0x110F6A4
	void OnBufferInvalidated() { }

	// RVA: 0x110F70C
	void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x110F788
	int CopyTo(int valueOffset, Char[] buffer, int offset, int length) { }

	// RVA: 0x110F800
	string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x110F814
	string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x110F8D8
	int System.IComparable.CompareTo(object obj) { }

}

// Namespace: 
private class DtdDefaultAttributeInfoToNodeDataComparer 
{
	// Fields
	private static System.Collections.Generic.IComparer<System.Object> s_instance; // 0x0

	// Methods

	// RVA: 0x110F9C4
	System.Collections.Generic.IComparer<System.Object> get_Instance() { }

	// RVA: 0x110FA40
	int Compare(object x, object y) { }

	// RVA: 0x110FDC0
	void .ctor() { }

	// RVA: 0x110FDC8
	void .cctor() { }

}

// Namespace: 
internal sealed class OnDefaultAttributeUseDelegate 
{
	// Methods

	// RVA: 0x110FE34
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x110FF58
	internal void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

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

	// RVA: 0x1007404
	void .ctor(XmlNameTable nt) { }

	// RVA: 0x1007850
	void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0x1008004
	void .ctor(Stream input) { }

	// RVA: 0x10080A0
	void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1008258
	void .ctor(TextReader input) { }

	// RVA: 0x10083DC
	void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x10082F4
	void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0x100845C
	void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0x1008930
	void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0x1008A8C
	void FinishInitUriString() { }

	// RVA: 0x10091CC
	void .ctor(Stream stream, Byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0x1009534
	void FinishInitStream() { }

	// RVA: 0x1009620
	void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0x1009750
	void FinishInitTextReader() { }

	// RVA: 0x1009820
	void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x10098D8
	XmlReaderSettings get_Settings() { }

	// RVA: 0x1009A58
	XmlNodeType get_NodeType() { }

	// RVA: 0x1009A78
	string get_Name() { }

	// RVA: 0x1009AA0
	string get_LocalName() { }

	// RVA: 0x1009AC0
	string get_NamespaceURI() { }

	// RVA: 0x1009AE0
	string get_Prefix() { }

	// RVA: 0x1009B00
	string get_Value() { }

	// RVA: 0x1009D68
	int get_Depth() { }

	// RVA: 0x1009D88
	string get_BaseURI() { }

	// RVA: 0x1009D90
	bool get_IsEmptyElement() { }

	// RVA: 0x1009DB0
	bool get_IsDefault() { }

	// RVA: 0x1009DD0
	Char get_QuoteChar() { }

	// RVA: 0x1009E08
	XmlSpace get_XmlSpace() { }

	// RVA: 0x1009E28
	string get_XmlLang() { }

	// RVA: 0x1009E48
	ReadState get_ReadState() { }

	// RVA: 0x1009E50
	bool get_EOF() { }

	// RVA: 0x1009E60
	XmlNameTable get_NameTable() { }

	// RVA: 0x1009E68
	bool get_CanResolveEntity() { }

	// RVA: 0x1009E70
	int get_AttributeCount() { }

	// RVA: 0x1009E78
	string GetAttribute(string name) { }

	// RVA: 0x100A0D4
	string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x100A268
	string GetAttribute(int i) { }

	// RVA: 0x100A310
	bool MoveToAttribute(string name) { }

	// RVA: 0x100A50C
	void MoveToAttribute(int i) { }

	// RVA: 0x100A5D4
	bool MoveToFirstAttribute() { }

	// RVA: 0x100A658
	bool MoveToNextAttribute() { }

	// RVA: 0x100A704
	bool MoveToElement() { }

	// RVA: 0x100A7A8
	void FinishInit() { }

	// RVA: 0x100A7F4
	bool Read() { }

	// RVA: 0x100D0C0
	void Close() { }

	// RVA: 0x100D21C
	void Skip() { }

	// RVA: 0x100D448
	string LookupNamespace(string prefix) { }

	// RVA: 0x100D484
	bool ReadAttributeValue() { }

	// RVA: 0x100DCC4
	void ResolveEntity() { }

	// RVA: 0x100E500
	void set_OuterReader(XmlReader value) { }

	// RVA: 0x100E510
	void MoveOffEntityReference() { }

	// RVA: 0x100E5C4
	string ReadString() { }

	// RVA: 0x100E5EC
	bool get_CanReadValueChunk() { }

	// RVA: 0x100E5F4
	int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x100F22C
	bool HasLineInfo() { }

	// RVA: 0x100F234
	int get_LineNumber() { }

	// RVA: 0x100F254
	int get_LinePosition() { }

	// RVA: 0x100F274
	System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x100F2C4
	string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x100F2D4
	string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x100F29C
	System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x100F2FC
	string LookupPrefix(string namespaceName) { }

	// RVA: 0x100F324
	bool get_Namespaces() { }

	// RVA: 0x100F32C
	void set_Namespaces(bool value) { }

	// RVA: 0x100F544
	bool get_Normalization() { }

	// RVA: 0x100F54C
	void set_Normalization(bool value) { }

	// RVA: 0x100F67C
	void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x100F75C
	void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x100F7E4
	bool get_IsResolverSet() { }

	// RVA: 0x100F7EC
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x100F880
	XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0x100F888
	IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0x100F890
	bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0x100F8B0
	bool get_DtdParserProxy_Normalization() { }

	// RVA: 0x100F8B8
	bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0x100F8C0
	bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0x100F8C8
	Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x100F9B0
	bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x100F9B8
	Char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x100F9C0
	int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0x100F9C8
	int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0x100F9D0
	void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0x100F9D8
	int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0x100F9E4
	bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x100F9EC
	IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0x100F9F4
	void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x100FA1C
	int get_DtdParserProxy_LineNo() { }

	// RVA: 0x100FA24
	int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0x100FA2C
	int DtdParserProxy_ReadData() { }

	// RVA: 0x100FE90
	int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x100FFA8
	int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x10100A0
	void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0x1010464
	void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0x1010930
	bool get_IsResolverNull() { }

	// RVA: 0x101097C
	XmlResolver GetTempResolver() { }

	// RVA: 0x10109F8
	bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x101125C
	bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x10113B8
	bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1011B64
	void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1011DFC
	void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0x1011F14
	void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1012060
	void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x10120F0
	void Throw(int pos, string res, string arg) { }

	// RVA: 0x1012208
	void Throw(int pos, string res, string[] args) { }

	// RVA: 0x1012320
	void Throw(int pos, string res) { }

	// RVA: 0x10094DC
	void Throw(string res) { }

	// RVA: 0x1012384
	void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0x1012108
	void Throw(string res, string arg) { }

	// RVA: 0x1012494
	void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x1012220
	void Throw(string res, string[] args) { }

	// RVA: 0x1012588
	void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0x101261C
	void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0x1011E88
	void Throw(Exception e) { }

	// RVA: 0x101273C
	void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0x100CDF8
	void ThrowWithoutLineInfo(string res) { }

	// RVA: 0x1012844
	void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0x1012924
	void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0x1012A18
	void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	// RVA: 0x1012728
	void SetErrorState() { }

	// RVA: 0x10107EC
	void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0x1012A8C
	void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0x100A3F0
	bool get_InAttributeValueIterator() { }

	// RVA: 0x100A414
	void FinishAttributeValueIterator() { }

	// RVA: 0x100F8A0
	bool get_DtdValidation() { }

	// RVA: 0x10081BC
	void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0x100823C
	void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1012D44
	void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0x1012DA8
	void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1008E44
	void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x1008450
	void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0x1013170
	void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0x100858C
	void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0x100869C
	void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0x100915C
	void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0x100B7C0
	void OpenUrl() { }

	// RVA: 0x10134DC
	void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0x1012DB8
	Encoding DetectEncoding() { }

	// RVA: 0x1012FEC
	void SetupEncoding(Encoding encoding) { }

	// RVA: 0x1013698
	void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0x10138CC
	Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0x101381C
	void UnDecodeChars() { }

	// RVA: 0x1013C50
	void SwitchEncodingToUTF8() { }

	// RVA: 0x100FA30
	int ReadData() { }

	// RVA: 0x1013CC8
	int GetChars(int maxCharsCount) { }

	// RVA: 0x1013DE8
	void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	// RVA: 0x100D0C8
	void Close(bool closeInput) { }

	// RVA: 0x1014028
	void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0x100BA04
	bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0x100B1B0
	bool ParseDocumentContent() { }

	// RVA: 0x100ADD8
	bool ParseElementContent() { }

	// RVA: 0x10159D0
	void ThrowUnclosedElements() { }

	// RVA: 0x10145EC
	void ParseElement() { }

	// RVA: 0x1016204
	void AddDefaultAttributesAndNormalize() { }

	// RVA: 0x1015628
	void ParseEndElement() { }

	// RVA: 0x10174B8
	void ThrowTagMismatch(NodeData startTag) { }

	// RVA: 0x1015BAC
	void ParseAttributes() { }

	// RVA: 0x1016CB8
	void ElementNamespaceLookup() { }

	// RVA: 0x10173EC
	void AttributeNamespaceLookup() { }

	// RVA: 0x10188E0
	void AttributeDuplCheck() { }

	// RVA: 0x10183E8
	void OnDefaultNamespaceDecl(NodeData attr) { }

	// RVA: 0x1018570
	void OnNamespaceDecl(NodeData attr) { }

	// RVA: 0x1018638
	void OnXmlReservedAttribute(NodeData attr) { }

	// RVA: 0x101794C
	void ParseAttributeValueSlow(int curPos, Char quoteChar, NodeData attr) { }

	// RVA: 0x101907C
	void AddAttributeChunkToList(NodeData attr, NodeData chunk, ref NodeData lastChunk) { }

	// RVA: 0x1014EBC
	bool ParseText() { }

	// RVA: 0x100EAA4
	bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	// RVA: 0x1009B54
	void FinishPartialValue() { }

	// RVA: 0x1009C40
	void FinishOtherValueIterator() { }

	// RVA: 0x100CEF4
	void SkipPartialTextValue() { }

	// RVA: 0x100CF3C
	void FinishReadValueChunk() { }

	// RVA: 0x100CF5C
	void FinishReadContentAsBinary() { }

	// RVA: 0x100CFC0
	void FinishReadElementContentAsBinary() { }

	// RVA: 0x101530C
	bool ParseRootLevelWhitespace() { }

	// RVA: 0x100C970
	void ParseEntityReference() { }

	// RVA: 0x1014B3C
	EntityType HandleEntityReference(bool isInAttributeValue, EntityExpandType expandType, out int charRefEndPos) { }

	// RVA: 0x100DF2C
	EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0x1013C40
	bool get_InEntity() { }

	// RVA: 0x1012B58
	bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0x100C9F0
	void SetupEndEntityNodeInContent() { }

	// RVA: 0x1019554
	void SetupEndEntityNodeInAttribute() { }

	// RVA: 0x1014238
	bool ParsePI() { }

	// RVA: 0x10100E8
	bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0x10195D8
	bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	// RVA: 0x1014240
	bool ParseComment() { }

	// RVA: 0x10142CC
	void ParseCData() { }

	// RVA: 0x1010668
	void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0x101999C
	bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	// RVA: 0x10142D4
	bool ParseDoctypeDecl() { }

	// RVA: 0x1019E2C
	void ParseDtd() { }

	// RVA: 0x101A190
	void SkipDtd() { }

	// RVA: 0x101A518
	void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0x101A5C8
	void SkipUntil(Char stopChar, bool recognizeLiterals) { }

	// RVA: 0x10118D8
	int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0x10192D8
	int ParseCharRefInline(int startPos, out int charCount, out EntityType entityType) { }

	// RVA: 0x100FEB8
	int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out EntityType entityType) { }

	// RVA: 0x101AAE4
	int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out EntityType entityType) { }

	// RVA: 0x1010024
	int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x101B178
	int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1014058
	int ParseName() { }

	// RVA: 0x1015B9C
	int ParseQName(out int colonPos) { }

	// RVA: 0x101B4C4
	int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	// RVA: 0x101B748
	bool ReadDataInName(ref int pos) { }

	// RVA: 0x10190E8
	string ParseEntityName() { }

	// RVA: 0x100C8C0
	NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x101B794
	NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1011FA4
	NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0x101777C
	NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0x101B8F0
	NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x100C908
	void PopElementContext() { }

	// RVA: 0x100FA08
	void OnNewLine(int pos) { }

	// RVA: 0x100CD4C
	void OnEof() { }

	// RVA: 0x1018D28
	string LookupNamespace(NodeData node) { }

	// RVA: 0x1018E68
	void AddNamespace(string prefix, string uri, NodeData attr) { }

	// RVA: 0x100C810
	void ResetAttributes() { }

	// RVA: 0x101BA90
	void FullAttributeCleanup() { }

	// RVA: 0x1018DD8
	void PushXmlContext() { }

	// RVA: 0x101BA4C
	void PopXmlContext() { }

	// RVA: 0x1019500
	XmlNodeType GetWhitespaceType() { }

	// RVA: 0x1019270
	XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0x1011550
	void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0x101BB30
	bool OpenAndPush(Uri uri) { }

	// RVA: 0x1010B34
	bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1010EEC
	void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x10112D4
	void PopEntity() { }

	// RVA: 0x101BDAC
	void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0x101C030
	void UnregisterEntity() { }

	// RVA: 0x1011BE0
	void PushParsingState() { }

	// RVA: 0x1013FB0
	void PopParsingState() { }

	// RVA: 0x101C098
	int IncrementalRead() { }

	// RVA: 0x100CB78
	void FinishIncrementalRead() { }

	// RVA: 0x100CC00
	bool ParseFragmentAttribute() { }

	// RVA: 0x100D7A4
	bool ParseAttributeValueChunk() { }

	// RVA: 0x100CC98
	void ParseXmlDeclarationFragment() { }

	// RVA: 0x10142B4
	void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x1014048
	void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0x10145D4
	void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x1014080
	void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0x10145CC
	string ParseUnexpectedToken(int pos) { }

	// RVA: 0x101CA0C
	string ParseUnexpectedToken() { }

	// RVA: 0x10176B8
	void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0x1009F10
	int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0x100A014
	int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0x1019348
	bool ZeroEndingStream(int pos) { }

	// RVA: 0x1013270
	void ParseDtdFromParserContext() { }

	// RVA: 0x10193D8
	bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0x1007D9C
	void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x101CAF8
	IDtdInfo get_DtdInfo() { }

	// RVA: 0x101CB00
	void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0x101CC80
	void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0x101CC90
	void set_OnDefaultAttributeUse(OnDefaultAttributeUseDelegate value) { }

	// RVA: 0x101CCA0
	void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x101CD78
	XmlNodeType get_FragmentType() { }

	// RVA: 0x101CD80
	void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0x101CDA0
	XmlResolver GetResolver() { }

	// RVA: 0x101CDEC
	void set_InternalSchemaType(object value) { }

	// RVA: 0x101CE0C
	object get_InternalTypedValue() { }

	// RVA: 0x101CE2C
	void set_InternalTypedValue(object value) { }

	// RVA: 0x101CE4C
	bool get_StandAlone() { }

	// RVA: 0x101CE54
	XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x101CE5C
	bool get_V1Compat() { }

	// RVA: 0x1016D20
	bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, NodeData[] nameSortedNodeData) { }

	// RVA: 0x101D0D4
	bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0x101CE64
	NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0x101D354
	void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0x10093D0
	bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0x1011D04
	void RegisterConsumedCharacters(Int64 characters, bool inEntityReference) { }

	// RVA: 0x101D35C
	string StripSpaces(string value) { }

	// RVA: 0x101D57C
	void StripSpaces(Char[] value, int index, ref int len) { }

	// RVA: 0x100F218
	void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	// RVA: 0x1013CC0
	void BlockCopy(Byte[] src, int srcOffset, Byte[] dst, int dstOffset, int count) { }

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

	// RVA: 0x111013C
	void Init(int nsTop) { }

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

	// RVA: 0x111501C
	void Set(string prefix, string ns, bool declared) { }

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

	// RVA: 0x110FF6C
	void .ctor() { }

	// RVA: 0x11101D0
	void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x11102E0
	void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x111036C
	void .ctor(TextWriter w) { }

	// RVA: 0x1110438
	Stream get_BaseStream() { }

	// RVA: 0x11104C8
	void set_Namespaces(bool value) { }

	// RVA: 0x111053C
	void set_Formatting(Formatting value) { }

	// RVA: 0x1110550
	void set_QuoteChar(Char value) { }

	// RVA: 0x11105DC
	void WriteStartDocument() { }

	// RVA: 0x111099C
	void WriteStartDocument(bool standalone) { }

	// RVA: 0x11109B0
	void WriteEndDocument() { }

	// RVA: 0x1110C2C
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1111910
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11124D4
	void WriteEndElement() { }

	// RVA: 0x11127FC
	void WriteFullEndElement() { }

	// RVA: 0x1112804
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x111313C
	void WriteEndAttribute() { }

	// RVA: 0x11131E4
	void WriteCData(string text) { }

	// RVA: 0x11133C8
	void WriteComment(string text) { }

	// RVA: 0x11135E4
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x111392C
	void WriteEntityRef(string name) { }

	// RVA: 0x1113A04
	void WriteCharEntity(Char ch) { }

	// RVA: 0x1113AD0
	void WriteWhitespace(string ws) { }

	// RVA: 0x1113C54
	void WriteString(string text) { }

	// RVA: 0x1113D2C
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1113E08
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1113EEC
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1113FD0
	void WriteRaw(string data) { }

	// RVA: 0x111409C
	void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1114208
	void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x11142E0
	WriteState get_WriteState() { }

	// RVA: 0x1114304
	void Close() { }

	// RVA: 0x1114484
	void Flush() { }

	// RVA: 0x11144A8
	string LookupPrefix(string ns) { }

	// RVA: 0x11105E4
	void StartDocument(int standalone) { }

	// RVA: 0x1111294
	void AutoComplete(Token token) { }

	// RVA: 0x1110BCC
	void AutoCompleteAll() { }

	// RVA: 0x11124DC
	void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x11146EC
	void WriteEndStartTag(bool empty) { }

	// RVA: 0x1114694
	void WriteEndAttributeQuote() { }

	// RVA: 0x11145C4
	void Indent(bool beforeEndElement) { }

	// RVA: 0x1112100
	void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1114D90
	void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x111506C
	void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1114A74
	void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1113020
	string GeneratePrefix() { }

	// RVA: 0x111382C
	void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1111F20
	int LookupNamespace(string prefix) { }

	// RVA: 0x1112EE0
	int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x1112020
	string FindPrefix(string ns) { }

	// RVA: 0x111109C
	void ValidateName(string name, bool isNCName) { }

	// RVA: 0x1114B70
	void HandleSpecialAttribute() { }

	// RVA: 0x1112380
	void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x1111DC4
	void PushStack() { }

	// RVA: 0x1114A44
	void FlushEncoders() { }

	// RVA: 0x1115164
	void .cctor() { }

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

	// RVA: 0x111577C
	void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x1115BA8
	void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1115D1C
	void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1115F68
	void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1115FF0
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11162D8
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11163B4
	void StartElementContent() { }

	// RVA: 0x1116400
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1116590
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11166BC
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1116800
	void WriteEndAttribute() { }

	// RVA: 0x1116850
	void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x11168A8
	bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x11168B0
	void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1116A04
	void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1116A54
	void WriteCData(string text) { }

	// RVA: 0x111705C
	void WriteComment(string text) { }

	// RVA: 0x1117588
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11176D8
	void WriteEntityRef(string name) { }

	// RVA: 0x11177A4
	void WriteCharEntity(Char ch) { }

	// RVA: 0x111798C
	void WriteWhitespace(string ws) { }

	// RVA: 0x1117FF4
	void WriteString(string text) { }

	// RVA: 0x111804C
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11181BC
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1118200
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1118508
	void WriteRaw(string data) { }

	// RVA: 0x1118554
	void Close() { }

	// RVA: 0x1118664
	void Flush() { }

	// RVA: 0x11186B0
	void FlushBuffer() { }

	// RVA: 0x1118660
	void FlushEncoder() { }

	// RVA: 0x11179E4
	void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1117CCC
	void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1115F28
	void RawText(string s) { }

	// RVA: 0x1118CF0
	void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x111824C
	void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x11171C0
	void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1116CBC
	void WriteCDataSection(string text) { }

	// RVA: 0x1118EBC
	bool IsSurrogateByte(Byte b) { }

	// RVA: 0x1118904
	Byte* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x1118A94
	Byte* InvalidXmlChar(int ch, Byte* pDst, bool entitize) { }

	// RVA: 0x1118F84
	void EncodeChar(ref Char* pSrc, Char* pSrcEnd, ref Byte* pDst) { }

	// RVA: 0x1118C14
	Byte* EncodeMultibyteUTF8(int ch, Byte* pDst) { }

	// RVA: 0x1119068
	void CharToUTF8(ref Char* pSrc, Char* pSrcEnd, ref Byte* pDst) { }

	// RVA: 0x1118C68
	Byte* WriteNewLine(Byte* pDst) { }

	// RVA: 0x1118874
	Byte* LtEntity(Byte* pDst) { }

	// RVA: 0x1118884
	Byte* GtEntity(Byte* pDst) { }

	// RVA: 0x1118858
	Byte* AmpEntity(Byte* pDst) { }

	// RVA: 0x1118894
	Byte* QuoteEntity(Byte* pDst) { }

	// RVA: 0x11188B0
	Byte* TabEntity(Byte* pDst) { }

	// RVA: 0x11188E8
	Byte* LineFeedEntity(Byte* pDst) { }

	// RVA: 0x11188CC
	Byte* CarriageReturnEntity(Byte* pDst) { }

	// RVA: 0x1118ECC
	Byte* CharEntity(Byte* pDst, Char ch) { }

	// RVA: 0x1118E98
	Byte* RawStartCData(Byte* pDst) { }

	// RVA: 0x1118E80
	Byte* RawEndCData(Byte* pDst) { }

	// RVA: 0x1115888
	void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }

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

	// RVA: 0x1119138
	void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1119284
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x111937C
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11193F4
	void StartElementContent() { }

	// RVA: 0x1119480
	void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x1119488
	void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1119510
	void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1119598
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x11195E0
	void WriteCData(string text) { }

	// RVA: 0x11195EC
	void WriteComment(string text) { }

	// RVA: 0x1119644
	void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1119698
	void WriteEntityRef(string name) { }

	// RVA: 0x11196A4
	void WriteCharEntity(Char ch) { }

	// RVA: 0x11196B0
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11196BC
	void WriteWhitespace(string ws) { }

	// RVA: 0x111971C
	void WriteString(string text) { }

	// RVA: 0x111977C
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11197C8
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x111981C
	void WriteRaw(string data) { }

	// RVA: 0x1119870
	void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1119164
	void Init(XmlWriterSettings settings) { }

	// RVA: 0x11192F0
	void WriteIndent() { }

}

// Namespace: System.Xml
public class XmlValidatingReader 
{
	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Methods

	// RVA: 0x1119880
	XmlNodeType get_NodeType() { }

	// RVA: 0x11198A4
	string get_LocalName() { }

	// RVA: 0x11198C8
	string get_NamespaceURI() { }

	// RVA: 0x11198EC
	string get_Prefix() { }

	// RVA: 0x1119910
	string get_Value() { }

	// RVA: 0x1119934
	int get_Depth() { }

	// RVA: 0x1119958
	string get_BaseURI() { }

	// RVA: 0x1119980
	bool get_IsEmptyElement() { }

	// RVA: 0x11199A8
	int get_AttributeCount() { }

	// RVA: 0x11199D0
	string GetAttribute(string name) { }

	// RVA: 0x11199F8
	string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1119A20
	string GetAttribute(int i) { }

	// RVA: 0x1119A48
	bool MoveToAttribute(string name) { }

	// RVA: 0x1119A70
	bool MoveToFirstAttribute() { }

	// RVA: 0x1119A98
	bool MoveToNextAttribute() { }

	// RVA: 0x1119AC0
	bool MoveToElement() { }

	// RVA: 0x1119AE8
	bool ReadAttributeValue() { }

	// RVA: 0x1119B10
	bool Read() { }

	// RVA: 0x1119B38
	bool get_EOF() { }

	// RVA: 0x1119B60
	ReadState get_ReadState() { }

	// RVA: 0x1119B88
	XmlNameTable get_NameTable() { }

	// RVA: 0x1119BB0
	string LookupNamespace(string prefix) { }

	// RVA: 0x1119BEC
	void ResolveEntity() { }

	// RVA: 0x1119C14
	bool get_Namespaces() { }

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

	// RVA: 0x111A23C
	void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x111B81C
	object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x111B824
	void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x111A270
	void AddHandler(ValidationEventHandler handler) { }

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

	// RVA: 0x1119C5C
	void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x111A4A0
	XmlReaderSettings get_Settings() { }

	// RVA: 0x111A58C
	XmlNodeType get_NodeType() { }

	// RVA: 0x111A5B0
	string get_Name() { }

	// RVA: 0x111A5D4
	string get_LocalName() { }

	// RVA: 0x111A5F8
	string get_NamespaceURI() { }

	// RVA: 0x111A61C
	string get_Prefix() { }

	// RVA: 0x111A640
	string get_Value() { }

	// RVA: 0x111A664
	int get_Depth() { }

	// RVA: 0x111A688
	string get_BaseURI() { }

	// RVA: 0x111A6B0
	bool get_IsEmptyElement() { }

	// RVA: 0x111A6D8
	bool get_IsDefault() { }

	// RVA: 0x111A700
	Char get_QuoteChar() { }

	// RVA: 0x111A728
	XmlSpace get_XmlSpace() { }

	// RVA: 0x111A750
	string get_XmlLang() { }

	// RVA: 0x111A778
	ReadState get_ReadState() { }

	// RVA: 0x111A7B8
	bool get_EOF() { }

	// RVA: 0x111A7E0
	XmlNameTable get_NameTable() { }

	// RVA: 0x111A808
	int get_AttributeCount() { }

	// RVA: 0x111A830
	string GetAttribute(string name) { }

	// RVA: 0x111A858
	string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x111A880
	string GetAttribute(int i) { }

	// RVA: 0x111A8A8
	bool MoveToAttribute(string name) { }

	// RVA: 0x111A8E8
	void MoveToAttribute(int i) { }

	// RVA: 0x111A924
	bool MoveToFirstAttribute() { }

	// RVA: 0x111A964
	bool MoveToNextAttribute() { }

	// RVA: 0x111A9A4
	bool MoveToElement() { }

	// RVA: 0x111A9E4
	bool Read() { }

	// RVA: 0x111AE70
	void Close() { }

	// RVA: 0x111AEB0
	string LookupNamespace(string prefix) { }

	// RVA: 0x111AED8
	bool ReadAttributeValue() { }

	// RVA: 0x111AF38
	bool get_CanResolveEntity() { }

	// RVA: 0x111AF40
	void ResolveEntity() { }

	// RVA: 0x111AF78
	void MoveOffEntityReference() { }

	// RVA: 0x111B02C
	string ReadString() { }

	// RVA: 0x111B054
	bool HasLineInfo() { }

	// RVA: 0x111B05C
	int get_LineNumber() { }

	// RVA: 0x111B164
	int get_LinePosition() { }

	// RVA: 0x111B26C
	System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x111B3D4
	string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x111B3E4
	string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x111B320
	System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x111B49C
	string LookupPrefix(string namespaceName) { }

	// RVA: 0x111B554
	ValidationType get_ValidationType() { }

	// RVA: 0x111B55C
	XmlSchemaCollection get_Schemas() { }

	// RVA: 0x1119C3C
	bool get_Namespaces() { }

	// RVA: 0x111AC28
	void ParseDtdFromParserContext() { }

	// RVA: 0x111B564
	void ValidateDtd() { }

	// RVA: 0x111ADE8
	void ResolveEntityInternally() { }

	// RVA: 0x111A324
	void SetupValidation(ValidationType valType) { }

	// RVA: 0x111A140
	XmlResolver GetResolver() { }

	// RVA: 0x111AAD0
	void ProcessCoreReaderEvent() { }

	// RVA: 0x111B5E4
	BaseValidator get_Validator() { }

	// RVA: 0x111B5EC
	void set_Validator(BaseValidator value) { }

	// RVA: 0x111B5F4
	XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x111B61C
	bool get_StandAlone() { }

	// RVA: 0x111B63C
	void set_SchemaTypeObject(object value) { }

	// RVA: 0x111B65C
	object get_TypedValueObject() { }

	// RVA: 0x111B67C
	void set_TypedValueObject(object value) { }

	// RVA: 0x111B69C
	bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x111B6BC
	IDtdInfo get_DtdInfo() { }

	// RVA: 0x111B6E4
	void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

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

	// RVA: 0x111BF10
	void .ctor(XmlWellFormedWriter wfWriter) { }

	// RVA: 0x1122A24
	System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1122A64
	string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1122A80
	string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

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

	// RVA: 0x111BF90
	void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x111D930
	void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x111DC8C
	void WriteFullEndElement(XmlRawWriter rawWriter) { }

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

	// RVA: 0x111BF44
	void Set(string prefix, string namespaceUri, NamespaceKind kind) { }

	// RVA: 0x1121E64
	void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }

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

	// RVA: 0x1122AA8
	void Set(string prefix, string localName, string namespaceUri) { }

	// RVA: 0x1122B00
	bool IsDuplicate(string prefix, string localName, string namespaceUri) { }

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

	// RVA: 0x1123DE8
	void .ctor() { }

	// RVA: 0x1123DF0
	void Set(ItemType type, object data) { }

}

// Namespace: 
private class BufferChunk 
{
	// Fields
	internal Char[] buffer; // 0x10
	internal int index; // 0x18
	internal int count; // 0x1C

	// Methods

	// RVA: 0x1123370
	void .ctor(Char[] buffer, int index, int count) { }

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

	// RVA: 0x1122B74
	string get_StringValue() { }

	// RVA: 0x1122BAC
	void WriteEntityRef(string name) { }

	// RVA: 0x1122F84
	void WriteCharEntity(Char ch) { }

	// RVA: 0x1123050
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1123144
	void WriteWhitespace(string ws) { }

	// RVA: 0x11231CC
	void WriteString(string text) { }

	// RVA: 0x1123280
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11233BC
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11234AC
	void WriteRaw(string data) { }

	// RVA: 0x1123534
	void WriteValue(string value) { }

	// RVA: 0x11235BC
	void Replay(XmlWriter writer) { }

	// RVA: 0x11238E8
	void Trim() { }

	// RVA: 0x1123DA0
	void Clear() { }

	// RVA: 0x1122D88
	void StartComplexValue() { }

	// RVA: 0x1122DDC
	void AddItem(ItemType type, object data) { }

	// RVA: 0x1123E00
	void .ctor() { }

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

	// RVA: 0x111B948
	void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x111BFFC
	WriteState get_WriteState() { }

	// RVA: 0x111C09C
	void WriteStartDocument() { }

	// RVA: 0x111C270
	void WriteStartDocument(bool standalone) { }

	// RVA: 0x111C290
	void WriteEndDocument() { }

	// RVA: 0x111C760
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x111CC40
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x111D704
	void WriteEndElement() { }

	// RVA: 0x111DA60
	void WriteFullEndElement() { }

	// RVA: 0x111DCC0
	void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x111EAA4
	void WriteEndAttribute() { }

	// RVA: 0x111F8C0
	void WriteCData(string text) { }

	// RVA: 0x111F9D8
	void WriteComment(string text) { }

	// RVA: 0x111FAF0
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x111FDB4
	void WriteEntityRef(string name) { }

	// RVA: 0x111FF44
	void WriteCharEntity(Char ch) { }

	// RVA: 0x11200FC
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11202C0
	void WriteWhitespace(string ws) { }

	// RVA: 0x1120494
	void WriteString(string text) { }

	// RVA: 0x1120598
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1120818
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1120A98
	void WriteRaw(string data) { }

	// RVA: 0x1120B9C
	void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1120DE8
	void Close() { }

	// RVA: 0x1120FF0
	void Flush() { }

	// RVA: 0x11210B0
	string LookupPrefix(string ns) { }

	// RVA: 0x1121358
	void WriteValue(string value) { }

	// RVA: 0x112146C
	void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x11215B0
	XmlRawWriter get_RawWriter() { }

	// RVA: 0x111FF34
	bool get_SaveAttrValue() { }

	// RVA: 0x1120FD4
	bool get_InBase64() { }

	// RVA: 0x111E524
	void SetSpecialAttribute(SpecialAttribute special) { }

	// RVA: 0x111C0A4
	void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x11215B8
	void StartFragment() { }

	// RVA: 0x111D2D8
	void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x111F3B8
	bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x11216C4
	void AddNamespace(string prefix, string ns, NamespaceKind kind) { }

	// RVA: 0x1121998
	void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x11215C4
	int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x111D964
	void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1121888
	XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x111C3F8
	void AdvanceState(Token token) { }

	// RVA: 0x1121D90
	void StartElementContent() { }

	// RVA: 0x1121A90
	string GetStateName(State state) { }

	// RVA: 0x111D18C
	string LookupNamespace(string prefix) { }

	// RVA: 0x111E718
	string LookupLocalNamespace(string prefix) { }

	// RVA: 0x111E5D4
	string GeneratePrefix() { }

	// RVA: 0x111D080
	void CheckNCName(string ncname) { }

	// RVA: 0x1121FA4
	Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x1121B3C
	void ThrowInvalidStateTransition(Token token, State currentState) { }

	// RVA: 0x11215A0
	bool get_IsClosedOrErrorState() { }

	// RVA: 0x111E7FC
	void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x11220E4
	void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x1122220
	void .cctor() { }

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

	// RVA: 0x2FE41A8
	void WriteStartDocument() { }

	// RVA: 0x2FE4234
	void WriteStartDocument(bool standalone) { }

	// RVA: 0x2FE41A8
	void WriteEndDocument() { }

	// RVA: 0x2FE4A14
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1123E80
	void WriteStartElement(string localName, string ns) { }

	// RVA: 0x2FE49A8
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x2FE41A8
	void WriteEndElement() { }

	// RVA: 0x2FE41A8
	void WriteFullEndElement() { }

	// RVA: 0x1123E98
	void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x1123EF8
	void WriteAttributeString(string localName, string value) { }

	// RVA: 0x1123F58
	void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	// RVA: 0x2FE49A8
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x2FE41A8
	void WriteEndAttribute() { }

	// RVA: 0x2FE4574
	void WriteCData(string text) { }

	// RVA: 0x2FE4574
	void WriteComment(string text) { }

	// RVA: 0x2FE47D4
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x2FE4574
	void WriteEntityRef(string name) { }

	// RVA: -1
	void WriteCharEntity(Char ch) { }

	// RVA: 0x2FE4574
	void WriteWhitespace(string ws) { }

	// RVA: 0x2FE4574
	void WriteString(string text) { }

	// RVA: -1
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: -1
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: -1
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x2FE4574
	void WriteRaw(string data) { }

	// RVA: -1
	void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1123FAC
	void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x2FE32D4
	WriteState get_WriteState() { }

	// RVA: 0x1123FC8
	void Close() { }

	// RVA: 0x2FE41A8
	void Flush() { }

	// RVA: 0x2FE36BC
	string LookupPrefix(string ns) { }

	// RVA: 0x1123FCC
	void WriteValue(string value) { }

	// RVA: 0x1123FE4
	void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x112428C
	void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1124710
	void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x1124778
	void Dispose() { }

	// RVA: 0x112478C
	void Dispose(bool disposing) { }

	// RVA: 0x11247E0
	XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x1124E44
	XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x1125250
	void .ctor() { }

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

	// RVA: 0x1124854
	void .ctor() { }

	// RVA: 0x11253C4
	bool get_Async() { }

	// RVA: 0x11253CC
	Encoding get_Encoding() { }

	// RVA: 0x11253D4
	bool get_OmitXmlDeclaration() { }

	// RVA: 0x11253DC
	void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x11254F4
	NewLineHandling get_NewLineHandling() { }

	// RVA: 0x11254FC
	string get_NewLineChars() { }

	// RVA: 0x1125504
	bool get_Indent() { }

	// RVA: 0x1125514
	void set_Indent(bool value) { }

	// RVA: 0x112557C
	string get_IndentChars() { }

	// RVA: 0x1125584
	bool get_NewLineOnAttributes() { }

	// RVA: 0x112558C
	bool get_CloseOutput() { }

	// RVA: 0x1125594
	ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x112559C
	void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x112564C
	bool get_CheckCharacters() { }

	// RVA: 0x1125654
	NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x112565C
	void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x112570C
	bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x1125714
	XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x112571C
	void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x1125724
	XmlWriterSettings Clone() { }

	// RVA: 0x1125804
	System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0x112580C
	bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x1125814
	bool get_MergeCDataSections() { }

	// RVA: 0x112581C
	string get_MediaType() { }

	// RVA: 0x1125824
	string get_DocTypeSystem() { }

	// RVA: 0x112582C
	string get_DocTypePublic() { }

	// RVA: 0x1125834
	XmlStandalone get_Standalone() { }

	// RVA: 0x112583C
	bool get_AutoXmlDeclaration() { }

	// RVA: 0x1125844
	TriState get_IndentInternal() { }

	// RVA: 0x112584C
	bool get_IsQuerySpecific() { }

	// RVA: 0x11248E8
	XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x1124EB8
	XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x11258E8
	void set_ReadOnly(bool value) { }

	// RVA: 0x112543C
	void CheckReadOnly(string propertyName) { }

	// RVA: 0x1125258
	void Initialize() { }

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

	// RVA: 0x11258F0
	void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x11259EC
	void Init() { }

	// RVA: 0x1125E58
	void Reset(XmlReader reader) { }

	// RVA: 0x1125E80
	XmlReaderSettings get_Settings() { }

	// RVA: 0x1125EA4
	XmlNodeType get_NodeType() { }

	// RVA: 0x1125EC4
	string get_Name() { }

	// RVA: 0x1125EEC
	string get_LocalName() { }

	// RVA: 0x1125F0C
	string get_NamespaceURI() { }

	// RVA: 0x1125F2C
	string get_Prefix() { }

	// RVA: 0x1125F4C
	string get_Value() { }

	// RVA: 0x1125F84
	int get_Depth() { }

	// RVA: 0x1125FA4
	string get_BaseURI() { }

	// RVA: 0x1125FCC
	bool get_IsEmptyElement() { }

	// RVA: 0x1125FD4
	bool get_IsDefault() { }

	// RVA: 0x1125FDC
	Char get_QuoteChar() { }

	// RVA: 0x1126004
	XmlSpace get_XmlSpace() { }

	// RVA: 0x112602C
	string get_XmlLang() { }

	// RVA: 0x1126054
	int get_AttributeCount() { }

	// RVA: 0x112605C
	string GetAttribute(string name) { }

	// RVA: 0x112626C
	string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x11263AC
	string GetAttribute(int i) { }

	// RVA: 0x1126448
	bool MoveToAttribute(string name) { }

	// RVA: 0x11264FC
	void MoveToAttribute(int i) { }

	// RVA: 0x1126598
	bool MoveToFirstAttribute() { }

	// RVA: 0x11265E8
	bool MoveToNextAttribute() { }

	// RVA: 0x112664C
	bool MoveToElement() { }

	// RVA: 0x11266A8
	bool Read() { }

	// RVA: 0x11269C8
	ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x1126A44
	void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x1126B88
	void RecordEndElementNode() { }

	// RVA: 0x1126CAC
	bool get_EOF() { }

	// RVA: 0x1126CEC
	void Close() { }

	// RVA: 0x1126D2C
	ReadState get_ReadState() { }

	// RVA: 0x1126D54
	void Skip() { }

	// RVA: 0x1126E6C
	XmlNameTable get_NameTable() { }

	// RVA: 0x1126E74
	string LookupNamespace(string prefix) { }

	// RVA: 0x1126E9C
	void ResolveEntity() { }

	// RVA: 0x1126EDC
	bool ReadAttributeValue() { }

	// RVA: 0x112705C
	bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x1127064
	int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x1127084
	int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x11270A4
	void SetToReplayMode() { }

	// RVA: 0x11270C4
	XmlReader GetCoreReader() { }

	// RVA: 0x11270CC
	IXmlLineInfo GetLineInfo() { }

	// RVA: 0x11269B8
	void ClearAttributesInfo() { }

	// RVA: 0x11270D4
	ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x1125B58
	ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x1125CE4
	void RecordAttributes() { }

	// RVA: 0x11260F4
	int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x11261C0
	int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x1126FB8
	ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

}

// Namespace: System.Xml
internal sealed class CachingEventHandler 
{
	// Methods

	// RVA: 0x1127258
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1127378
	internal void Invoke(XsdCachingReader cachingReader) { }

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

	// RVA: 0x112738C
	void .ctor() { }

	// RVA: 0x1127404
	void Reset() { }

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

	// RVA: 0x11274A0
	void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x1127CA8
	void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x11276BC
	void Init() { }

	// RVA: 0x1127A8C
	void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x1127CB0
	XmlReaderSettings get_Settings() { }

	// RVA: 0x1127D84
	XmlNodeType get_NodeType() { }

	// RVA: 0x1127E1C
	string get_Name() { }

	// RVA: 0x1127F48
	string get_LocalName() { }

	// RVA: 0x1127F88
	string get_NamespaceURI() { }

	// RVA: 0x1127FC8
	string get_Prefix() { }

	// RVA: 0x1128008
	string get_Value() { }

	// RVA: 0x1128048
	int get_Depth() { }

	// RVA: 0x1128088
	string get_BaseURI() { }

	// RVA: 0x11280B0
	bool get_IsEmptyElement() { }

	// RVA: 0x11280D8
	bool get_IsDefault() { }

	// RVA: 0x1128118
	Char get_QuoteChar() { }

	// RVA: 0x1128140
	XmlSpace get_XmlSpace() { }

	// RVA: 0x1128168
	string get_XmlLang() { }

	// RVA: 0x1128190
	IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1128194
	Type get_ValueType() { }

	// RVA: 0x1128280
	int get_AttributeCount() { }

	// RVA: 0x1128288
	string GetAttribute(string name) { }

	// RVA: 0x1128498
	string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1128708
	string GetAttribute(int i) { }

	// RVA: 0x11287FC
	bool MoveToAttribute(string name) { }

	// RVA: 0x1128B0C
	void MoveToAttribute(int i) { }

	// RVA: 0x1128D08
	bool MoveToFirstAttribute() { }

	// RVA: 0x1128ECC
	bool MoveToNextAttribute() { }

	// RVA: 0x1129090
	bool MoveToElement() { }

	// RVA: 0x11290F8
	bool Read() { }

	// RVA: 0x11295E0
	bool get_EOF() { }

	// RVA: 0x1129608
	void Close() { }

	// RVA: 0x1129648
	ReadState get_ReadState() { }

	// RVA: 0x1129688
	void Skip() { }

	// RVA: 0x11297F0
	XmlNameTable get_NameTable() { }

	// RVA: 0x11297F8
	string LookupNamespace(string prefix) { }

	// RVA: 0x11298B0
	void ResolveEntity() { }

	// RVA: 0x11298F0
	bool ReadAttributeValue() { }

	// RVA: 0x1129AF4
	bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1129E34
	bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x1129E90
	XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1129F48
	XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x112A0F0
	XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x112A160
	XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x112A1C8
	XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x112A220
	bool HasLineInfo() { }

	// RVA: 0x112A228
	int get_LineNumber() { }

	// RVA: 0x112A2EC
	int get_LinePosition() { }

	// RVA: 0x112A3B0
	System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x112A48C
	string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x112A56C
	string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x112A64C
	object GetStringValue() { }

	// RVA: 0x1128260
	XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x11292CC
	void ProcessReaderEvent() { }

	// RVA: 0x112A670
	void ProcessElementEvent() { }

	// RVA: 0x112AB3C
	void ProcessEndElementEvent() { }

	// RVA: 0x112ADC0
	void ValidateAttributes() { }

	// RVA: 0x1129590
	void ClearAttributesInfo() { }

	// RVA: 0x11288F4
	AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x112B304
	AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x1128308
	ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x11285B8
	ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x112B134
	AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x112AD74
	bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1129498
	void ProcessInlineSchema() { }

	// RVA: 0x112B3D0
	void ReadAheadForMemberType() { }

	// RVA: 0x1129B90
	void GetIsDefault() { }

	// RVA: 0x1129FDC
	void GetMemberType() { }

	// RVA: 0x112B030
	XsdCachingReader GetCachingReader() { }

	// RVA: 0x1129A50
	ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x112B66C
	void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x112AF88
	string GetOriginalAtomicValueStringOfElement() { }

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

	// RVA: 0x112B6B8
	void .ctor(XmlDocument document, XmlNode node) { }

	// RVA: 0x112B8AC
	void .ctor(DocumentXPathNavigator other) { }

	// RVA: 0x112B970
	XPathNavigator Clone() { }

	// RVA: 0x112B9D4
	XmlNameTable get_NameTable() { }

	// RVA: 0x112BA1C
	XPathNodeType get_NodeType() { }

	// RVA: 0x112BB08
	string get_LocalName() { }

	// RVA: 0x112BB30
	string get_NamespaceURI() { }

	// RVA: 0x112BC40
	string get_Name() { }

	// RVA: 0x112BD8C
	string get_Prefix() { }

	// RVA: 0x112BE6C
	string get_Value() { }

	// RVA: 0x112BF20
	string get_ValueDocument() { }

	// RVA: 0x112C004
	string get_ValueText() { }

	// RVA: 0x112C2BC
	string get_BaseURI() { }

	// RVA: 0x112C2E4
	string get_XmlLang() { }

	// RVA: 0x112C30C
	object get_UnderlyingObject() { }

	// RVA: 0x112C330
	bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x112C664
	bool MoveToFirstAttribute() { }

	// RVA: 0x112C7E4
	bool MoveToNextAttribute() { }

	// RVA: 0x112CB20
	bool MoveToNamespace(string name) { }

	// RVA: 0x112CE94
	bool MoveToFirstNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x112D11C
	bool MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x112D1A4
	bool MoveToFirstNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x112D4AC
	bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x112D930
	bool MoveToNextNamespaceLocal(XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x112D328
	bool MoveToNextNamespaceGlobal(ref XmlAttributeCollection attributes, ref int index) { }

	// RVA: 0x112D9C4
	bool PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, string localName) { }

	// RVA: 0x112DAC0
	string LookupNamespace(string prefix) { }

	// RVA: 0x112DB20
	bool MoveToNext() { }

	// RVA: 0x112DEA8
	bool MoveToFirstChild() { }

	// RVA: 0x112E16C
	bool MoveToParent() { }

	// RVA: 0x112E2FC
	void MoveToRoot() { }

	// RVA: 0x112E414
	bool MoveTo(XPathNavigator other) { }

	// RVA: 0x112E4C8
	bool MoveToId(string id) { }

	// RVA: 0x112E530
	bool MoveToChild(string localName, string namespaceUri) { }

	// RVA: 0x112E6AC
	bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x112E820
	bool MoveToFollowing(string localName, string namespaceUri, XPathNavigator end) { }

	// RVA: 0x112EAA8
	bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x112EDAC
	bool MoveToNext(string localName, string namespaceUri) { }

	// RVA: 0x112EE80
	bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x112EFE0
	bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x112F088
	bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x112F29C
	IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x112F2C4
	XmlNode OwnerNode(XmlNode node) { }

	// RVA: 0x112F378
	int GetDepth(XmlNode node) { }

	// RVA: 0x112F4E4
	XmlNodeOrder Compare(XmlNode node1, XmlNode node2) { }

	// RVA: 0x112F6FC
	XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x112FC90
	XmlNode System.Xml.IHasXmlNode.GetNode() { }

	// RVA: 0x112FC98
	XPathNodeIterator SelectDescendants(string localName, string namespaceURI, bool matchSelf) { }

	// RVA: 0x112FFB8
	XPathNodeIterator SelectDescendants(XPathNodeType nt, bool includeSelf) { }

	// RVA: 0x112B748
	void ResetPosition(XmlNode node) { }

	// RVA: 0x112CA94
	bool ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, out int index) { }

	// RVA: 0x112C9CC
	bool CheckAttributePosition(XmlAttribute attribute, out XmlAttributeCollection attributes, int index) { }

	// RVA: 0x112BA54
	void CalibrateText() { }

	// RVA: 0x112DD5C
	XmlNode ParentNode(XmlNode node) { }

	// RVA: 0x1130154
	XmlNode ParentNodeTail(XmlNode parent) { }

	// RVA: 0x112E0E0
	XmlNode FirstChild(XmlNode node) { }

	// RVA: 0x11301A8
	XmlNode FirstChildTail(XmlNode child) { }

	// RVA: 0x112C1C4
	XmlNode NextSibling(XmlNode node) { }

	// RVA: 0x1130200
	XmlNode NextSiblingTail(XmlNode node, XmlNode sibling) { }

	// RVA: 0x11300F4
	XmlNode PreviousText(XmlNode node) { }

	// RVA: 0x11302C4
	XmlNode PreviousTextTail(XmlNode node, XmlNode text) { }

	// RVA: 0x112F1B8
	bool IsDescendant(XmlNode top, XmlNode bottom) { }

	// RVA: 0x112DDE0
	bool IsValidChild(XmlNode parent, XmlNode child) { }

	// RVA: 0x112DD04
	XmlNode TextEnd(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_Empty 
{
	// Fields
	private XPathNavigator nav; // 0x18

	// Methods

	// RVA: 0x112FE70
	void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x11303E8
	void .ctor(DocumentXPathNodeIterator_Empty other) { }

	// RVA: 0x113043C
	XPathNodeIterator Clone() { }

	// RVA: 0x11304D0
	bool MoveNext() { }

	// RVA: 0x11304D8
	XPathNavigator get_Current() { }

	// RVA: 0x11304E0
	int get_CurrentPosition() { }

	// RVA: 0x11304E8
	int get_Count() { }

}

// Namespace: System.Xml
internal abstract class DocumentXPathNodeIterator_ElemDescendants 
{
	// Fields
	private DocumentXPathNavigator nav; // 0x18
	private int level; // 0x20
	private int position; // 0x24

	// Methods

	// RVA: 0x11304F0
	void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x11305B0
	void .ctor(DocumentXPathNodeIterator_ElemDescendants other) { }

	// RVA: 0x2FE3174
	bool Match(XmlNode node) { }

	// RVA: 0x1130678
	XPathNavigator get_Current() { }

	// RVA: 0x1130680
	int get_CurrentPosition() { }

	// RVA: 0x1130688
	void SetPosition(int pos) { }

	// RVA: 0x1130690
	bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_AllElemChildren 
{
	// Methods

	// RVA: 0x11300F0
	void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x1130818
	void .ctor(DocumentXPathNodeIterator_AllElemChildren other) { }

	// RVA: 0x113081C
	XPathNodeIterator Clone() { }

	// RVA: 0x1130880
	bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_AllElemChildren_AndSelf 
{
	// Methods

	// RVA: 0x11300EC
	void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x11308B4
	void .ctor(DocumentXPathNodeIterator_AllElemChildren_AndSelf other) { }

	// RVA: 0x11308B8
	XPathNodeIterator Clone() { }

	// RVA: 0x113091C
	bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren_NoLocalName 
{
	// Fields
	private string nsAtom; // 0x28

	// Methods

	// RVA: 0x112FEF0
	void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x1130A40
	void .ctor(DocumentXPathNodeIterator_ElemChildren_NoLocalName other) { }

	// RVA: 0x1130A78
	XPathNodeIterator Clone() { }

	// RVA: 0x1130AF4
	bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName 
{
	// Methods

	// RVA: 0x112FEC0
	void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x1130B38
	void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName other) { }

	// RVA: 0x1130B70
	XPathNodeIterator Clone() { }

	// RVA: 0x1130BEC
	bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren 
{
	// Fields
	protected string localNameAtom; // 0x28
	protected string nsAtom; // 0x30

	// Methods

	// RVA: 0x112FF6C
	void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x1130D10
	void .ctor(DocumentXPathNodeIterator_ElemChildren other) { }

	// RVA: 0x1130D58
	XPathNodeIterator Clone() { }

	// RVA: 0x1130DE4
	bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf 
{
	// Methods

	// RVA: 0x112FF20
	void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x1130E58
	void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf other) { }

	// RVA: 0x1130EA0
	XPathNodeIterator Clone() { }

	// RVA: 0x1130F2C
	bool MoveNext() { }

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

	// RVA: 0x1131050
	void .ctor(XmlDocument document) { }

	// RVA: 0x1131100
	XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1131284
	XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1131510
	void Grow() { }

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

	// RVA: 0x1131698
	void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1131748
	int get_Count() { }

	// RVA: 0x113189C
	XmlNode GetNode(XPathNavigator n) { }

	// RVA: 0x11317B8
	int ReadUntil(int index) { }

	// RVA: 0x113199C
	XmlNode Item(int index) { }

	// RVA: 0x1131A68
	IEnumerator GetEnumerator() { }

	// RVA: 0x1131B2C
	void .cctor() { }

}

// Namespace: System.Xml
internal class XmlNodeListEnumerator 
{
	// Fields
	private XPathNodeList list; // 0x10
	private int index; // 0x18
	private bool valid; // 0x1C

	// Methods

	// RVA: 0x1131AE8
	void .ctor(XPathNodeList list) { }

	// RVA: 0x1131BAC
	void Reset() { }

	// RVA: 0x1131BB8
	bool MoveNext() { }

	// RVA: 0x1131C34
	object get_Current() { }

}

// Namespace: System.Xml
public class XmlAttribute 
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Methods

	// RVA: 0x1131C74
	void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0x1131E9C
	int get_LocalNameHash() { }

	// RVA: 0x1131EBC
	void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x113201C
	XmlName get_XmlName() { }

	// RVA: 0x1132024
	void set_XmlName(XmlName value) { }

	// RVA: 0x113202C
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x11320F8
	XmlNode get_ParentNode() { }

	// RVA: 0x1132100
	string get_Name() { }

	// RVA: 0x1132120
	string get_LocalName() { }

	// RVA: 0x1132140
	string get_NamespaceURI() { }

	// RVA: 0x1132160
	string get_Prefix() { }

	// RVA: 0x1132180
	void set_Prefix(string value) { }

	// RVA: 0x113222C
	XmlNodeType get_NodeType() { }

	// RVA: 0x1132234
	XmlDocument get_OwnerDocument() { }

	// RVA: 0x1132254
	string get_Value() { }

	// RVA: 0x1132264
	void set_Value(string value) { }

	// RVA: 0x1132274
	IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x113227C
	void set_InnerText(string value) { }

	// RVA: 0x113234C
	bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0x113240C
	void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x1132654
	bool get_IsContainer() { }

	// RVA: 0x113265C
	XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1132950
	XmlLinkedNode get_LastNode() { }

	// RVA: 0x1132958
	void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1132960
	bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1132970
	bool get_Specified() { }

	// RVA: 0x1132978
	XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1132A58
	XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1132B38
	XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1132C0C
	XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x1132CE0
	XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x1132DB4
	XmlElement get_OwnerElement() { }

	// RVA: 0x1132E3C
	void set_InnerXml(string value) { }

	// RVA: 0x1132ECC
	void WriteTo(XmlWriter w) { }

	// RVA: 0x1132F80
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1132FE8
	string get_BaseURI() { }

	// RVA: 0x1133084
	void SetParent(XmlNode node) { }

	// RVA: 0x113308C
	XmlSpace get_XmlSpace() { }

	// RVA: 0x11330F0
	string get_XmlLang() { }

	// RVA: 0x113318C
	XPathNodeType get_XPNodeType() { }

	// RVA: 0x11331CC
	string get_XPLocalName() { }

	// RVA: 0x112BC10
	bool get_IsNamespace() { }

}

// Namespace: System.Xml
public sealed class XmlAttributeCollection 
{
	// Methods

	// RVA: 0x1133278
	void .ctor(XmlNode parent) { }

	// RVA: 0x112C50C
	XmlAttribute get_ItemOf(int i) { }

	// RVA: 0x1133280
	XmlAttribute get_ItemOf(string name) { }

	// RVA: 0x11333C4
	XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0x113352C
	int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0x1133714
	XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x11339CC
	XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0x1133D20
	XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0x1133DC8
	XmlAttribute RemoveAt(int i) { }

	// RVA: 0x1133E90
	void RemoveAll() { }

	// RVA: 0x1133F70
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1134010
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1134018
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x113401C
	int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1134024
	XmlNode AddNode(XmlNode node) { }

	// RVA: 0x113421C
	XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0x11342D0
	XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x1133AFC
	void Detach(XmlAttribute attr) { }

	// RVA: 0x1133BC8
	void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x113447C
	void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x113410C
	int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0x1132494
	bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0x1132594
	void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0x1133920
	XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

}

// Namespace: System.Xml
public class XmlCDataSection 
{
	// Methods

	// RVA: 0x1134BE0
	void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x1134C50
	string get_Name() { }

	// RVA: 0x1134C7C
	string get_LocalName() { }

	// RVA: 0x1134CA8
	XmlNodeType get_NodeType() { }

	// RVA: 0x1134CB0
	XmlNode get_ParentNode() { }

	// RVA: 0x1134D4C
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x1134DAC
	void WriteTo(XmlWriter w) { }

	// RVA: 0x1134DF4
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1134DF8
	XPathNodeType get_XPNodeType() { }

	// RVA: 0x1134E00
	bool get_IsText() { }

	// RVA: 0x1134E08
	XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public abstract class XmlCharacterData 
{
	// Fields
	private string data; // 0x20

	// Methods

	// RVA: 0x1134C18
	void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x1134E58
	string get_Value() { }

	// RVA: 0x1134E68
	void set_Value(string value) { }

	// RVA: 0x1134E78
	string get_InnerText() { }

	// RVA: 0x1134E84
	void set_InnerText(string value) { }

	// RVA: 0x1134E90
	string get_Data() { }

	// RVA: 0x1134EFC
	void set_Data(string value) { }

	// RVA: 0x1134FC0
	bool CheckOnData(string data) { }

	// RVA: 0x1135000
	bool DecideXPNodeTypeForTextNodes(XmlNode node, ref XPathNodeType xnt) { }

}

// Namespace: System.Xml
internal sealed class XmlChildEnumerator 
{
	// Fields
	internal XmlNode container; // 0x10
	internal XmlNode child; // 0x18
	internal bool isFirst; // 0x20

	// Methods

	// RVA: 0x1135108
	void .ctor(XmlNode container) { }

	// RVA: 0x1135174
	bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x113521C
	bool MoveNext() { }

	// RVA: 0x11352C4
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1135310
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1135314
	XmlNode get_Current() { }

}

// Namespace: System.Xml
internal class XmlChildNodes 
{
	// Fields
	private XmlNode container; // 0x10

	// Methods

	// RVA: 0x113538C
	void .ctor(XmlNode container) { }

	// RVA: 0x11353C0
	XmlNode Item(int i) { }

	// RVA: 0x1135430
	int get_Count() { }

	// RVA: 0x1135488
	IEnumerator GetEnumerator() { }

}

// Namespace: System.Xml
public class XmlComment 
{
	// Methods

	// RVA: 0x11355A4
	void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0x11355DC
	string get_Name() { }

	// RVA: 0x1135608
	string get_LocalName() { }

	// RVA: 0x1135634
	XmlNodeType get_NodeType() { }

	// RVA: 0x113563C
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x113569C
	void WriteTo(XmlWriter w) { }

	// RVA: 0x11356E4
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11356E8
	XPathNodeType get_XPNodeType() { }

}

// Namespace: System.Xml
public class XmlDeclaration 
{
	// Fields
	private string version; // 0x20
	private string encoding; // 0x28
	private string standalone; // 0x30

	// Methods

	// RVA: 0x11356F0
	void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x1135B90
	string get_Version() { }

	// RVA: 0x1135B98
	void set_Version(string value) { }

	// RVA: 0x1135BA0
	string get_Encoding() { }

	// RVA: 0x11359A4
	void set_Encoding(string value) { }

	// RVA: 0x1135BA8
	string get_Standalone() { }

	// RVA: 0x1135A20
	void set_Standalone(string value) { }

	// RVA: 0x1135BB0
	string get_Value() { }

	// RVA: 0x1135BC0
	void set_Value(string value) { }

	// RVA: 0x1135BD0
	string get_InnerText() { }

	// RVA: 0x1135D4C
	void set_InnerText(string value) { }

	// RVA: 0x1135F8C
	string get_Name() { }

	// RVA: 0x1135FD0
	string get_LocalName() { }

	// RVA: 0x1135FDC
	XmlNodeType get_NodeType() { }

	// RVA: 0x1135FE4
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x113602C
	void WriteTo(XmlWriter w) { }

	// RVA: 0x1136098
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1135920
	bool IsValidXmlVersion(string ver) { }

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

	// RVA: 0x113609C
	void .ctor() { }

	// RVA: 0x11365B4
	void .ctor(XmlNameTable nt) { }

	// RVA: 0x1136104
	void .ctor(XmlImplementation imp) { }

	// RVA: 0x1136624
	SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x113662C
	void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0x1131D9C
	void CheckName(string name) { }

	// RVA: 0x1136634
	XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1136650
	XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1131EFC
	XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x113666C
	bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0x1136748
	XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0x113488C
	XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0x1136828
	WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0x11348A0
	void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0x1134A98
	void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0x1136E50
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x1136FC0
	XmlNodeType get_NodeType() { }

	// RVA: 0x1136FC8
	XmlNode get_ParentNode() { }

	// RVA: 0x1136FD0
	XmlDocumentType get_DocumentType() { }

	// RVA: 0x1137060
	XmlDeclaration get_Declaration() { }

	// RVA: 0x1137120
	XmlImplementation get_Implementation() { }

	// RVA: 0x1137128
	string get_Name() { }

	// RVA: 0x1137130
	string get_LocalName() { }

	// RVA: 0x112C134
	XmlElement get_DocumentElement() { }

	// RVA: 0x1137138
	bool get_IsContainer() { }

	// RVA: 0x1137140
	XmlLinkedNode get_LastNode() { }

	// RVA: 0x1137148
	void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1137150
	XmlDocument get_OwnerDocument() { }

	// RVA: 0x1137158
	void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x1137160
	bool get_CanReportValidity() { }

	// RVA: 0x1137168
	bool get_HasSetResolver() { }

	// RVA: 0x1137170
	XmlResolver GetResolver() { }

	// RVA: 0x1137178
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1137340
	bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x113749C
	bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x113755C
	bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x11375C0
	bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11377D8
	bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x113794C
	XmlAttribute CreateAttribute(string name) { }

	// RVA: 0x1137A58
	void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	// RVA: 0x1137AFC
	XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0x1137B80
	XmlComment CreateComment(string data) { }

	// RVA: 0x1137BFC
	XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1137C94
	XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0x1137CFC
	XmlElement CreateElement(string name) { }

	// RVA: 0x1137D9C
	void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0x1138048
	SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0x113817C
	XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x11382DC
	XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0x113834C
	XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x11383CC
	XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x1138450
	XmlText CreateTextNode(string text) { }

	// RVA: 0x11384C0
	XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0x1138530
	XPathNavigator CreateNavigator() { }

	// RVA: 0x1138544
	XPathNavigator CreateNavigator(XmlNode node) { }

	// RVA: 0x11388FC
	bool IsTextNode(XmlNodeType nt) { }

	// RVA: 0x1138730
	XmlNode NormalizeText(XmlNode n) { }

	// RVA: 0x1138914
	XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0x1138984
	XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0x1138A28
	XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0x1138ACC
	XmlElement GetElementById(string elementId) { }

	// RVA: 0x1138E6C
	XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0x1139450
	void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0x1136F10
	void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0x112B9FC
	XmlNameTable get_NameTable() { }

	// RVA: 0x11395B4
	XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x113964C
	XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x11396D4
	XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x11397A8
	bool get_IsReadOnly() { }

	// RVA: 0x11397B0
	XmlNamedNodeMap get_Entities() { }

	// RVA: 0x1139850
	void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0x1139858
	bool get_IsLoading() { }

	// RVA: 0x1139860
	void set_IsLoading(bool value) { }

	// RVA: 0x1139868
	bool get_ActualLoadingStatus() { }

	// RVA: 0x1139870
	XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0x1139964
	XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0x11399C8
	void Load(XmlReader reader) { }

	// RVA: 0x1139AEC
	void LoadXml(string xml) { }

	// RVA: 0x1139C68
	void set_InnerText(string value) { }

	// RVA: 0x1139CC4
	void set_InnerXml(string value) { }

	// RVA: 0x1139CD4
	void Save(XmlWriter w) { }

	// RVA: 0x1139F08
	void WriteTo(XmlWriter w) { }

	// RVA: 0x1139F18
	void WriteContentTo(XmlWriter xw) { }

	// RVA: 0x113A1E0
	XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1132888
	XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0x113A2DC
	void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x113A330
	void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11345D4
	XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x113A384
	string get_Version() { }

	// RVA: 0x113A3AC
	string get_Encoding() { }

	// RVA: 0x1139EE0
	string get_Standalone() { }

	// RVA: 0x113A3D4
	XmlEntity GetEntityNode(string name) { }

	// RVA: 0x113A4A8
	IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x113A688
	string get_BaseURI() { }

	// RVA: 0x113A690
	void SetBaseURI(string inBaseURI) { }

	// RVA: 0x113A6A0
	XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x113A948
	XPathNodeType get_XPNodeType() { }

	// RVA: 0x113A950
	bool get_HasEntityReferences() { }

	// RVA: 0x112CDCC
	XmlAttribute get_NamespaceXml() { }

	// RVA: 0x113A958
	void .cctor() { }

}

// Namespace: System.Xml
public class XmlDocumentFragment 
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Methods

	// RVA: 0x113AA78
	void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x113AB08
	string get_Name() { }

	// RVA: 0x113AB34
	string get_LocalName() { }

	// RVA: 0x113AB60
	XmlNodeType get_NodeType() { }

	// RVA: 0x113AB68
	XmlNode get_ParentNode() { }

	// RVA: 0x113AB70
	XmlDocument get_OwnerDocument() { }

	// RVA: 0x113ABEC
	void set_InnerXml(string value) { }

	// RVA: 0x113AEC4
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x113AF48
	bool get_IsContainer() { }

	// RVA: 0x113AF50
	XmlLinkedNode get_LastNode() { }

	// RVA: 0x113AF58
	void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x113AF60
	bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x113AFDC
	bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x113B060
	bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x113B0CC
	void WriteTo(XmlWriter w) { }

	// RVA: 0x113B0DC
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x113B440
	XPathNodeType get_XPNodeType() { }

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

	// RVA: 0x113B448
	void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x113B650
	string get_Name() { }

	// RVA: 0x113B658
	string get_LocalName() { }

	// RVA: 0x113B660
	XmlNodeType get_NodeType() { }

	// RVA: 0x113B668
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x113B6B0
	bool get_IsReadOnly() { }

	// RVA: 0x113B6B8
	XmlNamedNodeMap get_Entities() { }

	// RVA: 0x113B798
	XmlNamedNodeMap get_Notations() { }

	// RVA: 0x113B844
	string get_PublicId() { }

	// RVA: 0x113B84C
	string get_SystemId() { }

	// RVA: 0x113B854
	string get_InternalSubset() { }

	// RVA: 0x113B85C
	bool get_ParseWithNamespaces() { }

	// RVA: 0x113B864
	void WriteTo(XmlWriter w) { }

	// RVA: 0x113B894
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x113B898
	SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x113B8A0
	void set_DtdSchemaInfo(SchemaInfo value) { }

}

// Namespace: System.Xml
internal class XmlDOMTextWriter 
{
	// Methods

	// RVA: 0x113B8A8
	void .ctor(TextWriter w) { }

	// RVA: 0x113B914
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x113B9AC
	void WriteStartAttribute(string prefix, string localName, string ns) { }

}

// Namespace: System.Xml
public class XmlElement 
{
	// Fields
	private XmlName name; // 0x20
	private XmlAttributeCollection attributes; // 0x28
	private XmlLinkedNode lastChild; // 0x30

	// Methods

	// RVA: 0x113BA44
	void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x113BBB4
	void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x113BBFC
	XmlName get_XmlName() { }

	// RVA: 0x113BC04
	void set_XmlName(XmlName value) { }

	// RVA: 0x113BC0C
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x113C294
	string get_Name() { }

	// RVA: 0x113C4A8
	string get_LocalName() { }

	// RVA: 0x113C4C8
	string get_NamespaceURI() { }

	// RVA: 0x113C4E8
	string get_Prefix() { }

	// RVA: 0x113C508
	void set_Prefix(string value) { }

	// RVA: 0x113C5B8
	XmlNodeType get_NodeType() { }

	// RVA: 0x113C5C0
	XmlNode get_ParentNode() { }

	// RVA: 0x113C5C8
	XmlDocument get_OwnerDocument() { }

	// RVA: 0x113C5E8
	bool get_IsContainer() { }

	// RVA: 0x113C5F0
	XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x113C1B8
	bool get_IsEmpty() { }

	// RVA: 0x113C1C8
	void set_IsEmpty(bool value) { }

	// RVA: 0x113C84C
	XmlLinkedNode get_LastNode() { }

	// RVA: 0x113C85C
	void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x113C864
	bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x113C87C
	XmlAttributeCollection get_Attributes() { }

	// RVA: 0x113C9E0
	bool get_HasAttributes() { }

	// RVA: 0x113CA0C
	string GetAttribute(string name) { }

	// RVA: 0x113CA9C
	void SetAttribute(string name, string value) { }

	// RVA: 0x113CB58
	XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x113CBC0
	XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x113CCDC
	string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x113CD74
	string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x113CE9C
	XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x113CF18
	XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x113D010
	bool HasAttribute(string name) { }

	// RVA: 0x113D038
	void WriteTo(XmlWriter w) { }

	// RVA: 0x113D16C
	void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x113D3CC
	void WriteStartElement(XmlWriter w) { }

	// RVA: 0x113D4E8
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x113D550
	void RemoveAllAttributes() { }

	// RVA: 0x113D59C
	void RemoveAll() { }

	// RVA: 0x113C7D8
	void RemoveAllChildren() { }

	// RVA: 0x113D694
	IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x113D69C
	void set_InnerXml(string value) { }

	// RVA: 0x113D854
	string get_InnerText() { }

	// RVA: 0x113D970
	void set_InnerText(string value) { }

	// RVA: 0x113DA88
	XmlNode get_NextSibling() { }

	// RVA: 0x113DAD8
	void SetParent(XmlNode node) { }

	// RVA: 0x113DAE0
	XPathNodeType get_XPNodeType() { }

	// RVA: 0x113DAE8
	string get_XPLocalName() { }

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

	// RVA: 0x113DAF8
	void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x113DC50
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x113DCAC
	bool get_IsReadOnly() { }

	// RVA: 0x113DCB4
	string get_Name() { }

	// RVA: 0x113DCBC
	string get_LocalName() { }

	// RVA: 0x113DCC4
	string get_InnerText() { }

	// RVA: 0x113DCC8
	void set_InnerText(string value) { }

	// RVA: 0x113DD24
	bool get_IsContainer() { }

	// RVA: 0x113DD2C
	XmlLinkedNode get_LastNode() { }

	// RVA: 0x113DF08
	void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x113DF10
	bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x113DF28
	XmlNodeType get_NodeType() { }

	// RVA: 0x113DF30
	string get_SystemId() { }

	// RVA: 0x113DF38
	string get_OuterXml() { }

	// RVA: 0x113DF84
	void set_InnerXml(string value) { }

	// RVA: 0x113DFE0
	void WriteTo(XmlWriter w) { }

	// RVA: 0x113DFE4
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x113DFE8
	string get_BaseURI() { }

	// RVA: 0x113DFF0
	void SetBaseURI(string inBaseURI) { }

}

// Namespace: System.Xml
public class XmlEntityReference 
{
	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Methods

	// RVA: 0x113DFF8
	void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x113E0FC
	string get_Name() { }

	// RVA: 0x113E104
	string get_LocalName() { }

	// RVA: 0x113E10C
	string get_Value() { }

	// RVA: 0x113E114
	void set_Value(string value) { }

	// RVA: 0x113E170
	XmlNodeType get_NodeType() { }

	// RVA: 0x113E178
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x113E1BC
	bool get_IsReadOnly() { }

	// RVA: 0x113E1C4
	bool get_IsContainer() { }

	// RVA: 0x113E1CC
	void SetParent(XmlNode node) { }

	// RVA: 0x113E8F4
	void SetParentForLoad(XmlNode node) { }

	// RVA: 0x113E904
	XmlLinkedNode get_LastNode() { }

	// RVA: 0x113E90C
	void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x113E914
	bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x113E92C
	void WriteTo(XmlWriter w) { }

	// RVA: 0x113E95C
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x113EC58
	string get_BaseURI() { }

	// RVA: 0x113EC8C
	string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x113ED74
	string get_ChildBaseURI() { }

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

	// RVA: 0x113EE4C
	void .ctor() { }

	// RVA: 0x113EFA8
	void .ctor(XmlNameTable nt) { }

	// RVA: 0x113EFDC
	XmlDocument CreateDocument() { }

	// RVA: 0x113F044
	XmlNameTable get_NameTable() { }

}

// Namespace: System.Xml
public abstract class XmlLinkedNode 
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Methods

	// RVA: 0x113B5B0
	void .ctor(XmlDocument doc) { }

	// RVA: 0x113F04C
	XmlNode get_PreviousSibling() { }

	// RVA: 0x113F0C4
	XmlNode get_NextSibling() { }

}

// Namespace: System.Xml
internal class XmlLoader 
{
	// Fields
	private XmlDocument doc; // 0x10
	private XmlReader reader; // 0x18
	private bool preserveWhitespace; // 0x20

	// Methods

	// RVA: 0x113AC7C
	void .ctor() { }

	// RVA: 0x113F120
	void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x113F3AC
	void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x113FA78
	XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x113F430
	XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x113FBD0
	XmlAttribute LoadAttributeNode() { }

	// RVA: 0x11406C8
	XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x1140898
	void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x113FF18
	XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x1140220
	XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x11403CC
	XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x1140BD0
	XmlNode LoadNodeDirect() { }

	// RVA: 0x11422DC
	XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x113B5DC
	void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x11425E4
	void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x114139C
	void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x11429D8
	XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x113AC84
	XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x113D7CC
	void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x1143898
	void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x11435DC
	void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x11438A0
	string EntitizeName(string name) { }

	// RVA: 0x113DE5C
	void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x113E314
	void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x11432EC
	XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x11410DC
	void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	// RVA: 0x11405B4
	Exception UnexpectedNodeType(XmlNodeType nodetype) { }

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

	// RVA: 0x114391C
	XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1143A5C
	void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x1143F8C
	string get_LocalName() { }

	// RVA: 0x1143F94
	string get_NamespaceURI() { }

	// RVA: 0x1143F9C
	string get_Prefix() { }

	// RVA: 0x1143FA4
	int get_HashCode() { }

	// RVA: 0x1143FAC
	XmlDocument get_OwnerDocument() { }

	// RVA: 0x113C2B0
	string get_Name() { }

	// RVA: 0x1143FB4
	XmlSchemaValidity get_Validity() { }

	// RVA: 0x1143FBC
	bool get_IsDefault() { }

	// RVA: 0x1143FC4
	bool get_IsNil() { }

	// RVA: 0x1143FCC
	XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x1143FD4
	XmlSchemaType get_SchemaType() { }

	// RVA: 0x1143FDC
	XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1143FE4
	XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1143FEC
	bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1143FF8
	int GetHashCode(string name) { }

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

	// RVA: 0x1143B10
	void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11440C4
	XmlSchemaValidity get_Validity() { }

	// RVA: 0x11440FC
	bool get_IsDefault() { }

	// RVA: 0x1144108
	bool get_IsNil() { }

	// RVA: 0x1144114
	XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x114411C
	XmlSchemaType get_SchemaType() { }

	// RVA: 0x1144124
	XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x11441AC
	XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1144070
	void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x1144084
	void SetIsDefault(bool value) { }

	// RVA: 0x11440A4
	void SetIsNil(bool value) { }

	// RVA: 0x1144234
	bool Equals(IXmlSchemaInfo schemaInfo) { }

}

// Namespace: 
private class SingleObjectEnumerator 
{
	// Fields
	private object loneValue; // 0x10
	private int position; // 0x18

	// Methods

	// RVA: 0x1145658
	void .ctor(object value) { }

	// RVA: 0x1145694
	object get_Current() { }

	// RVA: 0x11456EC
	bool MoveNext() { }

	// RVA: 0x1145704
	void Reset() { }

}

// Namespace: 
internal struct SmallXmlNodeList 
{
	// Fields
	private object field; // 0x10

	// Methods

	// RVA: 0x1144B18
	int get_Count() { }

	// RVA: 0x1144744
	object get_Item(int index) { }

	// RVA: 0x1144E8C
	void Add(object value) { }

	// RVA: 0x11451F0
	void RemoveAt(int index) { }

	// RVA: 0x11454A4
	void Insert(int index, object value) { }

	// RVA: 0x1144BB0
	IEnumerator GetEnumerator() { }

}

// Namespace: System.Xml
public class XmlNamedNodeMap 
{
	// Fields
	internal XmlNode parent; // 0x10
	internal SmallXmlNodeList nodes; // 0x18

	// Methods

	// RVA: 0x113B764
	void .ctor(XmlNode parent) { }

	// RVA: 0x11445A0
	XmlNode GetNamedItem(string name) { }

	// RVA: 0x1144830
	XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x1144A88
	int get_Count() { }

	// RVA: 0x1144BA8
	IEnumerator GetEnumerator() { }

	// RVA: 0x1144654
	int FindNodeOffset(string name) { }

	// RVA: 0x11448FC
	int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x1144CDC
	XmlNode AddNode(XmlNode node) { }

	// RVA: 0x1144FD4
	XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x1145080
	XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x1144A30
	XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x11452E8
	XmlNode InsertNodeAt(int i, XmlNode node) { }

}

// Namespace: System.Xml
public abstract class XmlNode 
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Methods

	// RVA: 0x113AB00
	void .ctor() { }

	// RVA: 0x113DBC8
	void .ctor(XmlDocument doc) { }

	// RVA: 0x1145710
	XPathNavigator CreateNavigator() { }

	// RVA: 0x11457B8
	XmlNodeList SelectNodes(string xpath) { }

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x1145868
	string get_Value() { }

	// RVA: 0x1145870
	void set_Value(string value) { }

	// RVA: 0x2FE32D4
	XmlNodeType get_NodeType() { }

	// RVA: 0x1145944
	XmlNode get_ParentNode() { }

	// RVA: 0x1145A38
	XmlNodeList get_ChildNodes() { }

	// RVA: 0x1145AA0
	XmlNode get_PreviousSibling() { }

	// RVA: 0x1145AA8
	XmlNode get_NextSibling() { }

	// RVA: 0x1145AB0
	XmlAttributeCollection get_Attributes() { }

	// RVA: 0x1145AB8
	XmlDocument get_OwnerDocument() { }

	// RVA: 0x1145B74
	XmlNode get_FirstChild() { }

	// RVA: 0x1145B9C
	XmlNode get_LastChild() { }

	// RVA: 0x1145BAC
	bool get_IsContainer() { }

	// RVA: 0x1145BB4
	XmlLinkedNode get_LastNode() { }

	// RVA: 0x1145BBC
	void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1145BC0
	bool AncestorNode(XmlNode node) { }

	// RVA: 0x1145C2C
	bool IsConnected() { }

	// RVA: 0x1145C8C
	XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1146304
	XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11468EC
	XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1146D0C
	XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x1146D54
	XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x11472A8
	XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1147478
	bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1147480
	bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1147488
	bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1147490
	bool get_HasChildNodes() { }

	// RVA: -1
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x11474B8
	void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x1147558
	string get_NamespaceURI() { }

	// RVA: 0x11475A4
	string get_Prefix() { }

	// RVA: 0x11475F0
	void set_Prefix(string value) { }

	// RVA: 0x2FE360C
	string get_LocalName() { }

	// RVA: 0x11475F4
	bool get_IsReadOnly() { }

	// RVA: 0x11476FC
	bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x1147808
	object System.ICloneable.Clone() { }

	// RVA: 0x114781C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x113B3D8
	IEnumerator GetEnumerator() { }

	// RVA: 0x1147884
	void AppendChildText(StringBuilder builder) { }

	// RVA: 0x113D858
	string get_InnerText() { }

	// RVA: 0x114798C
	void set_InnerText(string value) { }

	// RVA: 0x1147A70
	string get_OuterXml() { }

	// RVA: 0x1147C24
	void set_InnerXml(string value) { }

	// RVA: 0x1147C80
	IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1147CFC
	string get_BaseURI() { }

	// RVA: 0x2FE4574
	void WriteTo(XmlWriter w) { }

	// RVA: 0x2FE4574
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x113D620
	void RemoveAll() { }

	// RVA: 0x1147E28
	XmlDocument get_Document() { }

	// RVA: 0x1147ED8
	string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x1147F64
	string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x113E2C0
	void SetParent(XmlNode node) { }

	// RVA: 0x11483D0
	void SetParentForLoad(XmlNode node) { }

	// RVA: 0x11483D8
	void SplitName(string name, out string prefix, out string localName) { }

	// RVA: 0x11484D8
	XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x1148544
	XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1148674
	void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11486C8
	void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x114871C
	XmlSpace get_XmlSpace() { }

	// RVA: 0x11488B0
	string get_XmlLang() { }

	// RVA: 0x11489B8
	XPathNodeType get_XPNodeType() { }

	// RVA: 0x11489C0
	string get_XPLocalName() { }

	// RVA: 0x1148A0C
	bool get_IsText() { }

	// RVA: 0x1148A14
	XmlNode get_PreviousText() { }

	// RVA: 0x113C7B0
	void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x11462C4
	void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

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

	// RVA: 0x1148A1C
	void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1148B04
	XmlNodeChangedAction get_Action() { }

}

// Namespace: System.Xml
public sealed class XmlNodeChangedEventHandler 
{
	// Methods

	// RVA: 0x1148B0C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1148C30
	internal void Invoke(object sender, XmlNodeChangedEventArgs e) { }

}

// Namespace: System.Xml
public abstract class XmlNodeList 
{
	// Methods

	// RVA: -1
	XmlNode Item(int index) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE360C
	IEnumerator GetEnumerator() { }

	// RVA: 0x1148C44
	XmlNode get_ItemOf(int i) { }

	// RVA: 0x1148C50
	void System.IDisposable.Dispose() { }

	// RVA: 0x1148C5C
	void PrivateDisposeNodeList() { }

	// RVA: 0x1148C60
	void .ctor() { }

}

// Namespace: 
internal struct VirtualAttribute 
{
	// Fields
	internal string name; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x1149008
	void .ctor(string name, string value) { }

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

	// RVA: 0x1148C68
	void .ctor(XmlNode node) { }

	// RVA: 0x114903C
	XmlNodeType get_NodeType() { }

	// RVA: 0x114908C
	string get_NamespaceURI() { }

	// RVA: 0x11490B4
	string get_Name() { }

	// RVA: 0x11491E0
	string get_LocalName() { }

	// RVA: 0x11492A4
	bool get_CreatedOnAttribute() { }

	// RVA: 0x11491C0
	bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0x11492AC
	string get_Prefix() { }

	// RVA: 0x11492D4
	string get_Value() { }

	// RVA: 0x114978C
	string get_BaseURI() { }

	// RVA: 0x11497B4
	XmlSpace get_XmlSpace() { }

	// RVA: 0x11497DC
	string get_XmlLang() { }

	// RVA: 0x1149804
	bool get_IsEmptyElement() { }

	// RVA: 0x11498BC
	bool get_IsDefault() { }

	// RVA: 0x1149978
	IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11499A0
	XmlNameTable get_NameTable() { }

	// RVA: 0x11499A8
	int get_AttributeCount() { }

	// RVA: 0x1149C4C
	void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0x11495B8
	void InitDecAttr() { }

	// RVA: 0x1149CC0
	string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0x1149DA4
	string GetDeclarationAttr(int i) { }

	// RVA: 0x1149DFC
	int GetDecAttrInd(string name) { }

	// RVA: 0x1149B08
	void InitDocTypeAttr() { }

	// RVA: 0x1149EA4
	string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0x1149F54
	string GetDocumentTypeAttr(int i) { }

	// RVA: 0x1149FAC
	int GetDocTypeAttrInd(string name) { }

	// RVA: 0x114A054
	string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0x114A09C
	string GetAttribute(string name) { }

	// RVA: 0x114A318
	string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x114A364
	string GetAttribute(string name, string ns) { }

	// RVA: 0x114A600
	string GetAttribute(int attributeIndex) { }

	// RVA: 0x114A85C
	void LogMove(int level) { }

	// RVA: 0x114A8A4
	void RollBackMove(ref int level) { }

	// RVA: 0x114A8F4
	bool get_IsOnDeclOrDocType() { }

	// RVA: 0x114A928
	void ResetToAttribute(ref int level) { }

	// RVA: 0x114AA10
	void ResetMove(ref int level, ref XmlNodeType nt) { }

	// RVA: 0x114AC04
	bool MoveToAttribute(string name) { }

	// RVA: 0x114AEB0
	bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x114AC68
	bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0x114AFAC
	void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x114B210
	bool MoveToNextAttribute(ref int level) { }

	// RVA: 0x114B460
	bool MoveToParent() { }

	// RVA: 0x114B4E4
	bool MoveToFirstChild() { }

	// RVA: 0x114B570
	bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0x114B600
	bool MoveToNext() { }

	// RVA: 0x114B688
	bool MoveToElement() { }

	// RVA: 0x114B730
	string LookupNamespace(string prefix) { }

	// RVA: 0x114BA38
	string DefaultLookupNamespace(string prefix) { }

	// RVA: 0x114BB70
	string LookupPrefix(string namespaceName) { }

	// RVA: 0x114BF44
	System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x114C444
	bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	// RVA: 0x114C6CC
	XmlDocument get_Document() { }

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

	// RVA: 0x114C6D4
	void .ctor(XmlNode node) { }

	// RVA: 0x114C7E8
	bool IsInReadingStates() { }

	// RVA: 0x114C7F8
	XmlNodeType get_NodeType() { }

	// RVA: 0x114C814
	string get_Name() { }

	// RVA: 0x114C888
	string get_LocalName() { }

	// RVA: 0x114C990
	string get_NamespaceURI() { }

	// RVA: 0x114CA18
	string get_Prefix() { }

	// RVA: 0x114CAA0
	string get_Value() { }

	// RVA: 0x114CB14
	int get_Depth() { }

	// RVA: 0x114CB1C
	string get_BaseURI() { }

	// RVA: 0x114CB4C
	bool get_CanResolveEntity() { }

	// RVA: 0x114CB54
	bool get_IsEmptyElement() { }

	// RVA: 0x114CC1C
	bool get_IsDefault() { }

	// RVA: 0x114CC50
	XmlSpace get_XmlSpace() { }

	// RVA: 0x114CC98
	string get_XmlLang() { }

	// RVA: 0x114CD20
	IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x114CD68
	int get_AttributeCount() { }

	// RVA: 0x114CDA8
	string GetAttribute(string name) { }

	// RVA: 0x114CDDC
	string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x114CE74
	string GetAttribute(int attributeIndex) { }

	// RVA: 0x114CEEC
	bool MoveToAttribute(string name) { }

	// RVA: 0x114D09C
	void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x114D2C4
	bool MoveToFirstAttribute() { }

	// RVA: 0x114D418
	bool MoveToNextAttribute() { }

	// RVA: 0x114D580
	bool MoveToElement() { }

	// RVA: 0x114D730
	bool Read() { }

	// RVA: 0x114D738
	bool Read(bool fSkipChildren) { }

	// RVA: 0x114D90C
	bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x114DED8
	void SetEndOfFile() { }

	// RVA: 0x114DEF0
	bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x114DD24
	bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x114DCFC
	void ReSetReadingMarks() { }

	// RVA: 0x114E018
	bool get_EOF() { }

	// RVA: 0x114E03C
	void Close() { }

	// RVA: 0x114E048
	ReadState get_ReadState() { }

	// RVA: 0x114E050
	void Skip() { }

	// RVA: 0x114E058
	string ReadString() { }

	// RVA: 0x114E100
	bool get_HasAttributes() { }

	// RVA: 0x114E128
	XmlNameTable get_NameTable() { }

	// RVA: 0x114E148
	string LookupNamespace(string prefix) { }

	// RVA: 0x114E18C
	void ResolveEntity() { }

	// RVA: 0x114E214
	bool ReadAttributeValue() { }

	// RVA: 0x114D078
	void FinishReadBinary() { }

	// RVA: 0x114E274
	System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x114E290
	string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x114E2AC
	string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x114E320
	IDtdInfo get_DtdInfo() { }

}

// Namespace: System.Xml
public class XmlNotation 
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string name; // 0x28

	// Methods

	// RVA: 0x1142940
	void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x114E348
	string get_Name() { }

	// RVA: 0x114E350
	string get_LocalName() { }

	// RVA: 0x114E358
	XmlNodeType get_NodeType() { }

	// RVA: 0x114E360
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x114E3BC
	bool get_IsReadOnly() { }

	// RVA: 0x114E3C4
	string get_OuterXml() { }

	// RVA: 0x114E410
	void set_InnerXml(string value) { }

	// RVA: 0x114E46C
	void WriteTo(XmlWriter w) { }

	// RVA: 0x114E470
	void WriteContentTo(XmlWriter w) { }

}

// Namespace: System.Xml
public class XmlProcessingInstruction 
{
	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Methods

	// RVA: 0x114257C
	void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0x114E474
	string get_Name() { }

	// RVA: 0x114E4E0
	string get_LocalName() { }

	// RVA: 0x114E4EC
	string get_Value() { }

	// RVA: 0x114E4F4
	void set_Value(string value) { }

	// RVA: 0x114E5B8
	void set_Data(string value) { }

	// RVA: 0x114E67C
	string get_InnerText() { }

	// RVA: 0x114E684
	void set_InnerText(string value) { }

	// RVA: 0x114E748
	XmlNodeType get_NodeType() { }

	// RVA: 0x114E750
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x114E794
	void WriteTo(XmlWriter w) { }

	// RVA: 0x114E7C4
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x114E7C8
	string get_XPLocalName() { }

	// RVA: 0x114E7D4
	XPathNodeType get_XPNodeType() { }

}

// Namespace: System.Xml
public class XmlSignificantWhitespace 
{
	// Methods

	// RVA: 0x114242C
	void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x114E7DC
	string get_Name() { }

	// RVA: 0x114E808
	string get_LocalName() { }

	// RVA: 0x114E834
	XmlNodeType get_NodeType() { }

	// RVA: 0x114E83C
	XmlNode get_ParentNode() { }

	// RVA: 0x114E8E0
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x114E940
	string get_Value() { }

	// RVA: 0x114E950
	void set_Value(string value) { }

	// RVA: 0x114E9E0
	void WriteTo(XmlWriter w) { }

	// RVA: 0x114EA28
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x114EA2C
	XPathNodeType get_XPNodeType() { }

	// RVA: 0x114EA60
	bool get_IsText() { }

	// RVA: 0x114EA68
	XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public class XmlText 
{
	// Methods

	// RVA: 0x1140BC4
	void .ctor(string strData) { }

	// RVA: 0x1140BBC
	void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x114EAB8
	string get_Name() { }

	// RVA: 0x114EAE4
	string get_LocalName() { }

	// RVA: 0x114EB10
	XmlNodeType get_NodeType() { }

	// RVA: 0x114EB18
	XmlNode get_ParentNode() { }

	// RVA: 0x114EBB4
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x114EC14
	string get_Value() { }

	// RVA: 0x114EC24
	void set_Value(string value) { }

	// RVA: 0x114ED04
	void WriteTo(XmlWriter w) { }

	// RVA: 0x114ED4C
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x114ED50
	XPathNodeType get_XPNodeType() { }

	// RVA: 0x114ED58
	bool get_IsText() { }

	// RVA: 0x114ED60
	XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal class XmlUnspecifiedAttribute 
{
	// Fields
	private bool fSpecified; // 0x28

	// Methods

	// RVA: 0x11425DC
	void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x114EDB0
	bool get_Specified() { }

	// RVA: 0x114EDB8
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x114EEEC
	void set_InnerText(string value) { }

	// RVA: 0x114EF18
	XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x114EF44
	XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x114EF70
	XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x114EF9C
	XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x114EFC8
	void WriteTo(XmlWriter w) { }

	// RVA: 0x114EFDC
	void SetSpecified(bool f) { }

}

// Namespace: System.Xml
public class XmlWhitespace 
{
	// Methods

	// RVA: 0x11424D4
	void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x114EFE4
	string get_Name() { }

	// RVA: 0x114F010
	string get_LocalName() { }

	// RVA: 0x114F03C
	XmlNodeType get_NodeType() { }

	// RVA: 0x114F044
	XmlNode get_ParentNode() { }

	// RVA: 0x114F0E8
	string get_Value() { }

	// RVA: 0x114F0F8
	void set_Value(string value) { }

	// RVA: 0x114F188
	XmlNode CloneNode(bool deep) { }

	// RVA: 0x114F1E8
	void WriteTo(XmlWriter w) { }

	// RVA: 0x114F230
	void WriteContentTo(XmlWriter w) { }

	// RVA: 0x114F234
	XPathNodeType get_XPNodeType() { }

	// RVA: 0x114F268
	bool get_IsText() { }

	// RVA: 0x114F270
	XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal sealed class EmptyEnumerator 
{
	// Methods

	// RVA: 0x114F2C0
	bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x114F2C8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x114F2CC
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x114F328
	void .ctor() { }

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

	// RVA: 0x114F330
	void .ctor(int GrowthRate) { }

	// RVA: 0x114F3B4
	void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x114F440
	object Push() { }

	// RVA: 0x114F58C
	object Pop() { }

	// RVA: 0x114F5DC
	object Peek() { }

	// RVA: 0x114F628
	void AddToTop(object o) { }

	// RVA: 0x114F6B4
	object get_Item(int index) { }

	// RVA: 0x114F734
	void set_Item(int index, object value) { }

	// RVA: 0x114F7EC
	int get_Length() { }

	// RVA: 0x114F7F4
	void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x114F850
	object Clone() { }

}

// Namespace: System.Xml
public interface IHasXmlNode 
{
	// Methods

	// RVA: 0x2FE360C
	XmlNode GetNode() { }

}

// Namespace: System.Xml
public interface IXmlLineInfo 
{
	// Methods

	// RVA: 0x2FE3054
	bool HasLineInfo() { }

	// RVA: 0x2FE32D4
	int get_LineNumber() { }

	// RVA: 0x2FE32D4
	int get_LinePosition() { }

}

// Namespace: System.Xml
internal class PositionInfo 
{
	// Methods

	// RVA: 0x114F940
	bool HasLineInfo() { }

	// RVA: 0x114F948
	int get_LineNumber() { }

	// RVA: 0x114F950
	int get_LinePosition() { }

	// RVA: 0x114F958
	PositionInfo GetPositionInfo(object o) { }

	// RVA: 0x114FA64
	void .ctor() { }

}

// Namespace: System.Xml
internal class ReaderPositionInfo 
{
	// Fields
	private IXmlLineInfo lineInfo; // 0x10

	// Methods

	// RVA: 0x114FA30
	void .ctor(IXmlLineInfo lineInfo) { }

	// RVA: 0x114FA6C
	bool HasLineInfo() { }

	// RVA: 0x114FB20
	int get_LineNumber() { }

	// RVA: 0x114FBD8
	int get_LinePosition() { }

}

// Namespace: System.Xml
public interface IXmlNamespaceResolver 
{
	// Methods

	// RVA: -1
	System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x2FE36BC
	string LookupNamespace(string prefix) { }

	// RVA: 0x2FE36BC
	string LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal struct LineInfo 
{
	// Fields
	internal int lineNo; // 0x10
	internal int linePos; // 0x14

	// Methods

	// RVA: 0x114FC90
	void .ctor(int lineNo, int linePos) { }

	// RVA: 0x114FC98
	void Set(int lineNo, int linePos) { }

}

// Namespace: 
private class Entry 
{
	// Fields
	internal string str; // 0x10
	internal int hashCode; // 0x18
	internal Entry next; // 0x20

	// Methods

	// RVA: 0x11503F4
	void .ctor(string str, int hashCode, Entry next) { }

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

	// RVA: 0x113EF20
	void .ctor() { }

	// RVA: 0x114FCA0
	string Add(string key) { }

	// RVA: 0x114FF58
	string Add(Char[] key, int start, int len) { }

	// RVA: 0x1150274
	string Get(string value) { }

	// RVA: 0x114FE24
	string AddEntry(string str, int hashCode) { }

	// RVA: 0x115044C
	void Grow() { }

	// RVA: 0x1150198
	bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}

// Namespace: System.Xml
internal static class Ref 
{
	// Methods

	// RVA: 0x1143910
	bool Equal(string strA, string strB) { }

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

	// RVA: 0x115D904
	void .ctor(string name, int lineNo, int linePos) { }

}

// Namespace: 
private class ParseElementOnlyContent_LocalFrame 
{
	// Fields
	public int startParenEntityId; // 0x10
	public Token parsingSchema; // 0x14

	// Methods

	// RVA: 0x115D95C
	void .ctor(int startParentEntityIdParam) { }

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

	// RVA: 0x11505D4
	void .ctor() { }

	// RVA: 0x11428EC
	IDtdParser Create() { }

	// RVA: 0x11506BC
	void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x1150AF8
	void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x115102C
	IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x1151564
	IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x1151594
	bool get_ParsingInternalSubset() { }

	// RVA: 0x11515A4
	bool get_IgnoreEntityReferences() { }

	// RVA: 0x11515B4
	bool get_SaveInternalSubsetValue() { }

	// RVA: 0x115168C
	bool get_ParsingTopLevelMarkup() { }

	// RVA: 0x11516BC
	bool get_SupportNamespaces() { }

	// RVA: 0x11516C4
	bool get_Normalize() { }

	// RVA: 0x1151060
	void Parse(bool saveInternalSubset) { }

	// RVA: 0x1151730
	void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x11516CC
	void ParseFreeFloatingDtd() { }

	// RVA: 0x11533C0
	void ParseInternalSubset() { }

	// RVA: 0x11533C4
	void ParseExternalSubset() { }

	// RVA: 0x11535AC
	void ParseSubset() { }

	// RVA: 0x1153AAC
	void ParseAttlistDecl() { }

	// RVA: 0x1155E5C
	void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x1156720
	void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x11541CC
	void ParseElementDecl() { }

	// RVA: 0x11572C8
	void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x1157700
	void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x1156F90
	void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x1154608
	void ParseEntityDecl() { }

	// RVA: 0x1154A90
	void ParseNotationDecl() { }

	// RVA: 0x1156BBC
	void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x1154E58
	void ParseComment() { }

	// RVA: 0x1155154
	void ParsePI() { }

	// RVA: 0x1155410
	void ParseCondSection() { }

	// RVA: 0x1152B9C
	void ParseExternalId(Token idTokenType, Token declType, out string publicId, out string systemId) { }

	// RVA: 0x1151DD4
	Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x1158150
	Token ScanSubsetContent() { }

	// RVA: 0x11580C4
	Token ScanNameExpected() { }

	// RVA: 0x11580F4
	Token ScanQNameExpected() { }

	// RVA: 0x1158124
	Token ScanNmtokenExpected() { }

	// RVA: 0x11589D8
	Token ScanDoctype1() { }

	// RVA: 0x1158C10
	Token ScanDoctype2() { }

	// RVA: 0x115B894
	Token ScanClosingTag() { }

	// RVA: 0x1158D28
	Token ScanElement1() { }

	// RVA: 0x1159014
	Token ScanElement2() { }

	// RVA: 0x1159244
	Token ScanElement3() { }

	// RVA: 0x11592E0
	Token ScanElement4() { }

	// RVA: 0x1159420
	Token ScanElement5() { }

	// RVA: 0x115959C
	Token ScanElement6() { }

	// RVA: 0x1159680
	Token ScanElement7() { }

	// RVA: 0x11596E8
	Token ScanAttlist1() { }

	// RVA: 0x11597B8
	Token ScanAttlist2() { }

	// RVA: 0x115A00C
	Token ScanAttlist3() { }

	// RVA: 0x115A0B8
	Token ScanAttlist4() { }

	// RVA: 0x115A19C
	Token ScanAttlist5() { }

	// RVA: 0x115A280
	Token ScanAttlist6() { }

	// RVA: 0x115A70C
	Token ScanAttlist7() { }

	// RVA: 0x115BF8C
	Token ScanLiteral(LiteralType literalType) { }

	// RVA: 0x115CD20
	XmlQualifiedName ScanEntityName() { }

	// RVA: 0x115A7D4
	Token ScanNotation1() { }

	// RVA: 0x115A9C0
	Token ScanSystemId() { }

	// RVA: 0x115ABB4
	Token ScanEntity1() { }

	// RVA: 0x115AC3C
	Token ScanEntity2() { }

	// RVA: 0x115AE6C
	Token ScanEntity3() { }

	// RVA: 0x115AA78
	Token ScanPublicId1() { }

	// RVA: 0x115AB30
	Token ScanPublicId2() { }

	// RVA: 0x115AF84
	Token ScanCondSection1() { }

	// RVA: 0x115B304
	Token ScanCondSection2() { }

	// RVA: 0x115B3A0
	Token ScanCondSection3() { }

	// RVA: 0x115BC00
	void ScanName() { }

	// RVA: 0x115BC08
	void ScanQName() { }

	// RVA: 0x115D0E4
	void ScanQName(bool isQName) { }

	// RVA: 0x115D374
	bool ReadDataInName() { }

	// RVA: 0x115BC10
	void ScanNmtoken() { }

	// RVA: 0x115BD8C
	bool EatPublicKeyword() { }

	// RVA: 0x115BE8C
	bool EatSystemKeyword() { }

	// RVA: 0x1152A0C
	XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x1156BA0
	string GetNameString() { }

	// RVA: 0x1156E94
	string GetNmtokenString() { }

	// RVA: 0x1156F24
	string GetValue() { }

	// RVA: 0x1156EB0
	string GetValueWithStrippedSpaces() { }

	// RVA: 0x115B92C
	int ReadData() { }

	// RVA: 0x1151C28
	void LoadParsingBuffer() { }

	// RVA: 0x11533B8
	void SaveParsingBuffer() { }

	// RVA: 0x11558EC
	void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x1157F9C
	bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x115D5DC
	bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x115B9F4
	bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x115CE8C
	SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x11556D4
	void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x11569AC
	void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x1151AD4
	void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x11569A0
	bool IsAttributeValueType(Token token) { }

	// RVA: 0x1155B08
	int get_LineNo() { }

	// RVA: 0x1155BC0
	int get_LinePos() { }

	// RVA: 0x115199C
	string get_BaseUriStr() { }

	// RVA: 0x1152970
	void OnUnexpectedError() { }

	// RVA: 0x115539C
	void Throw(int curPos, string res) { }

	// RVA: 0x1157788
	void Throw(int curPos, string res, string arg) { }

	// RVA: 0x1157C0C
	void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x1155C74
	void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x1150FAC
	void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x1157F18
	void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	// RVA: 0x1155B00
	void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x1157A94
	void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x1157FF0
	string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x115D3BC
	string StripSpaces(string value) { }

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

	// RVA: 0x115D98C
	int ParseNmtoken(string s, int offset) { }

	// RVA: 0x115DA60
	int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0x115DB50
	int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0x115DCB8
	bool IsNameNoNamespaces(string s) { }

	// RVA: 0x115DD70
	int ParseNCName(string s, int offset) { }

	// RVA: 0x115DEA8
	int ParseNCName(string s) { }

	// RVA: 0x115DF30
	int ParseQName(string s, int offset, out int colonOffset) { }

	// RVA: 0x115E050
	void ParseQNameThrow(string s, out string prefix, out string localName) { }

	// RVA: 0x115E1D0
	void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x115E6CC
	Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x115E990
	void SplitQName(string name, out string prefix, out string lname) { }

	// RVA: 0x115ED9C
	void .cctor() { }

}

// Namespace: System.Xml
internal struct XmlCharType 
{
	// Fields
	private static object s_Lock; // 0x0
	private static Byte[] s_CharProperties; // 0x8
	internal Byte[] charProperties; // 0x10

	// Methods

	// RVA: 0x115EE6C
	object get_StaticLock() { }

	// RVA: 0x115EF20
	void InitInstance() { }

	// RVA: 0x115F238
	void SetProperties(Byte[] chProps, string ranges, Byte value) { }

	// RVA: 0x115F3C4
	void .ctor(Byte[] charProperties) { }

	// RVA: 0x115E504
	XmlCharType get_Instance() { }

	// RVA: 0x115F3CC
	bool IsWhiteSpace(Char ch) { }

	// RVA: 0x115E4CC
	bool IsNCNameSingleChar(Char ch) { }

	// RVA: 0x115E588
	bool IsStartNCNameSingleChar(Char ch) { }

	// RVA: 0x115F404
	bool IsNameSingleChar(Char ch) { }

	// RVA: 0x115F444
	bool IsCharData(Char ch) { }

	// RVA: 0x115F47C
	bool IsPubidChar(Char ch) { }

	// RVA: 0x115F4FC
	bool IsTextChar(Char ch) { }

	// RVA: 0x115F534
	bool IsLetter(Char ch) { }

	// RVA: 0x115F56C
	bool IsNCNameCharXml4e(Char ch) { }

	// RVA: 0x115F5A4
	bool IsStartNCNameCharXml4e(Char ch) { }

	// RVA: 0x115F5E4
	bool IsNameCharXml4e(Char ch) { }

	// RVA: 0x115F624
	bool IsDigit(Char ch) { }

	// RVA: 0x115F648
	bool IsHighSurrogate(int ch) { }

	// RVA: 0x115F658
	bool IsLowSurrogate(int ch) { }

	// RVA: 0x115F668
	bool IsSurrogate(int ch) { }

	// RVA: 0x115F678
	int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0x115F690
	void SplitSurrogateChar(int combinedChar, out Char lowChar, out Char highChar) { }

	// RVA: 0x115F6C8
	bool IsOnlyWhitespace(string str) { }

	// RVA: 0x115F764
	int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x115F7F0
	int IsOnlyCharData(string str) { }

	// RVA: 0x115F8F4
	bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x115F9B0
	int IsPublicId(string str) { }

	// RVA: 0x115F634
	bool InRange(int value, int start, int end) { }

}

// Namespace: System.Xml
internal static class XmlComplianceUtil 
{
	// Methods

	// RVA: 0x115FA6C
	string NonCDataNormalize(string value) { }

	// RVA: 0x115FD98
	string CDataNormalize(string value) { }

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

	// RVA: 0x115FF84
	string EncodeName(string name) { }

	// RVA: 0x1160A94
	string EncodeLocalName(string name) { }

	// RVA: 0x1160AFC
	string DecodeName(string name) { }

	// RVA: 0x115FFEC
	string EncodeName(string name, bool first, bool local) { }

	// RVA: 0x1161534
	int FromHex(Char digit) { }

	// RVA: 0x116155C
	Byte[] FromBinHexString(string s) { }

	// RVA: 0x11615E4
	Byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0x116165C
	string ToBinHexString(Byte[] inArray) { }

	// RVA: 0x11616CC
	string VerifyName(string name) { }

	// RVA: 0x116195C
	Exception TryVerifyName(string name) { }

	// RVA: 0x1161B88
	string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0x1161E04
	string VerifyNCName(string name) { }

	// RVA: 0x1161E8C
	string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0x1161FFC
	Exception TryVerifyNCName(string name) { }

	// RVA: 0x116211C
	string VerifyTOKEN(string token) { }

	// RVA: 0x116224C
	Exception TryVerifyTOKEN(string token) { }

	// RVA: 0x1162388
	Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0x1162588
	Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0x116267C
	string ToString(bool value) { }

	// RVA: 0x11626E8
	string ToString(Char value) { }

	// RVA: 0x1162754
	string ToString(Decimal value) { }

	// RVA: 0x11627FC
	string ToString(SByte value) { }

	// RVA: 0x1162834
	string ToString(Int16 value) { }

	// RVA: 0x116286C
	string ToString(int value) { }

	// RVA: 0x11628A4
	string ToString(Int64 value) { }

	// RVA: 0x11628DC
	string ToString(Byte value) { }

	// RVA: 0x1162914
	string ToString(UInt16 value) { }

	// RVA: 0x116294C
	string ToString(UInt32 value) { }

	// RVA: 0x1162984
	string ToString(UInt64 value) { }

	// RVA: 0x11629BC
	string ToString(float value) { }

	// RVA: 0x1162C08
	string ToString(Double value) { }

	// RVA: 0x1162DB4
	string ToString(TimeSpan value) { }

	// RVA: 0x1162E04
	string ToString(DateTime value, string format) { }

	// RVA: 0x1162EE0
	string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x1163340
	string ToString(DateTimeOffset value) { }

	// RVA: 0x11633CC
	string ToString(Guid value) { }

	// RVA: 0x11633F4
	bool ToBoolean(string s) { }

	// RVA: 0x11636E0
	Exception TryToBoolean(string s, out bool result) { }

	// RVA: 0x11639A4
	Char ToChar(string s) { }

	// RVA: 0x1163A64
	Exception TryToChar(string s, out Char result) { }

	// RVA: 0x1163C20
	Decimal ToDecimal(string s) { }

	// RVA: 0x1163C98
	Exception TryToDecimal(string s, out Decimal result) { }

	// RVA: 0x1163E30
	Decimal ToInteger(string s) { }

	// RVA: 0x1163EA8
	Exception TryToInteger(string s, out Decimal result) { }

	// RVA: 0x1164040
	SByte ToSByte(string s) { }

	// RVA: 0x1164074
	Exception TryToSByte(string s, out SByte result) { }

	// RVA: 0x11641E4
	Int16 ToInt16(string s) { }

	// RVA: 0x1164218
	Exception TryToInt16(string s, out Int16 result) { }

	// RVA: 0x1164388
	int ToInt32(string s) { }

	// RVA: 0x11643BC
	Exception TryToInt32(string s, out int result) { }

	// RVA: 0x116452C
	Int64 ToInt64(string s) { }

	// RVA: 0x1164560
	Exception TryToInt64(string s, out Int64 result) { }

	// RVA: 0x11646D0
	Byte ToByte(string s) { }

	// RVA: 0x1164704
	Exception TryToByte(string s, out Byte result) { }

	// RVA: 0x1164874
	UInt16 ToUInt16(string s) { }

	// RVA: 0x11648A8
	Exception TryToUInt16(string s, out UInt16 result) { }

	// RVA: 0x1164A18
	UInt32 ToUInt32(string s) { }

	// RVA: 0x1164A4C
	Exception TryToUInt32(string s, out UInt32 result) { }

	// RVA: 0x1164BBC
	UInt64 ToUInt64(string s) { }

	// RVA: 0x1164BF0
	Exception TryToUInt64(string s, out UInt64 result) { }

	// RVA: 0x1164D60
	float ToSingle(string s) { }

	// RVA: 0x1164F1C
	Exception TryToSingle(string s, out float result) { }

	// RVA: 0x11651F0
	Double ToDouble(string s) { }

	// RVA: 0x1165380
	Exception TryToDouble(string s, out Double result) { }

	// RVA: 0x1165654
	Double ToXPathDouble(object o) { }

	// RVA: 0x116596C
	Double XPathRound(Double value) { }

	// RVA: 0x1165A74
	TimeSpan ToTimeSpan(string s) { }

	// RVA: 0x1165C10
	Exception TryToTimeSpan(string s, out TimeSpan result) { }

	// RVA: 0x1165CD4
	string[] get_AllDateTimeFormats() { }

	// RVA: 0x1165DB0
	void CreateAllDateTimeFormats() { }

	// RVA: 0x1166374
	DateTime ToDateTime(string s) { }

	// RVA: 0x1166484
	DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0x1166558
	DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x11667BC
	DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0x1166888
	Guid ToGuid(string s) { }

	// RVA: 0x11668B8
	Exception TryToGuid(string s, out Guid result) { }

	// RVA: 0x1163128
	DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x1163234
	DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x1166A90
	Uri ToUri(string s) { }

	// RVA: 0x1166CC8
	Exception TryToUri(string s, out Uri result) { }

	// RVA: 0x1166F70
	bool StrEqual(Char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0x1163658
	string TrimString(string value) { }

	// RVA: 0x116704C
	string TrimStringStart(string value) { }

	// RVA: 0x11670D4
	string TrimStringEnd(string value) { }

	// RVA: 0x116715C
	string[] SplitString(string value) { }

	// RVA: 0x1162B6C
	bool IsNegativeZero(Double value) { }

	// RVA: 0x11671E8
	Int64 DoubleToInt64Bits(Double value) { }

	// RVA: 0x11671F0
	void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0x11673FC
	Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1167868
	Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x11679B8
	Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0x1161CC8
	Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1167ADC
	Exception CreateInvalidSurrogatePairException(Char low, Char hi) { }

	// RVA: 0x1167BA8
	Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType) { }

	// RVA: 0x11674E8
	Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1167C28
	Exception CreateInvalidHighSurrogateCharException(Char hi) { }

	// RVA: 0x1167CEC
	Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType) { }

	// RVA: 0x1167D5C
	Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1167678
	Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0x1167E64
	Exception CreateInvalidCharException(Char invChar, Char nextChar) { }

	// RVA: 0x1167ED0
	Exception CreateInvalidCharException(Char invChar, Char nextChar, ExceptionType exceptionType) { }

	// RVA: 0x1161834
	Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0x1167FC8
	ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0x1168094
	void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public Uri uri; // 0x10

	// Methods

	// RVA: 0x1168DA8
	void .ctor() { }

	// RVA: 0x1168F3C
	Stream <GetStreamAsync>b__0() { }

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

	// RVA: 0x1168FC8
	void MoveNext() { }

	// RVA: 0x1169880
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Xml
internal class XmlDownloadManager 
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x1168218
	Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x1168318
	Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x1168A98
	void Remove(string host) { }

	// RVA: 0x1168C28
	System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x1168DB0
	System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x1168F34
	void .ctor() { }

}

// Namespace: System.Xml
internal class OpenedHost 
{
	// Fields
	internal int nonCachedConnectionsCount; // 0x10

	// Methods

	// RVA: 0x116886C
	void .ctor() { }

}

// Namespace: System.Xml
internal class XmlRegisteredNonCachedStream 
{
	// Fields
	protected Stream stream; // 0x28
	private XmlDownloadManager downloadManager; // 0x30
	private string host; // 0x38

	// Methods

	// RVA: 0x1168874
	void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0x1169900
	void Finalize() { }

	// RVA: 0x11699B0
	void Dispose(bool disposing) { }

	// RVA: 0x1169AFC
	IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1169B24
	IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1169B4C
	int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1169B74
	void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1169B9C
	void Flush() { }

	// RVA: 0x1169BC4
	int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1169BEC
	int ReadByte() { }

	// RVA: 0x1169C14
	Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1169C3C
	void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1169C64
	void WriteByte(Byte value) { }

	// RVA: 0x1169C8C
	bool get_CanRead() { }

	// RVA: 0x1169CB0
	bool get_CanSeek() { }

	// RVA: 0x1169CD4
	bool get_CanWrite() { }

	// RVA: 0x1169CF8
	Int64 get_Length() { }

	// RVA: 0x1169D1C
	Int64 get_Position() { }

	// RVA: 0x1169D40
	void set_Position(Int64 value) { }

}

// Namespace: System.Xml
internal class XmlCachedStream 
{
	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0x116891C
	void .ctor(Uri uri, Stream stream) { }

}

// Namespace: System.Xml
internal class UTF16Decoder 
{
	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0x1169D68
	void .ctor(bool bigEndian) { }

	// RVA: 0x1169D9C
	int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x1169DAC
	int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x1169E9C
	int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x116A02C
	void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

}

// Namespace: System.Xml
internal class SafeAsciiDecoder 
{
	// Methods

	// RVA: 0x116A220
	void .ctor() { }

	// RVA: 0x116A228
	int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x116A230
	int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x116A2B0
	void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

}

// Namespace: System.Xml
internal class Ucs4Encoding 
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Methods

	// RVA: 0x116A34C
	string get_WebName() { }

	// RVA: 0x116A358
	Decoder GetDecoder() { }

	// RVA: 0x116A360
	int GetByteCount(Char[] chars, int index, int count) { }

	// RVA: 0x116A3C8
	Byte[] GetBytes(string s) { }

	// RVA: 0x116A3D0
	int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	// RVA: 0x116A3D8
	int GetMaxByteCount(int charCount) { }

	// RVA: 0x116A3E0
	int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x116A404
	int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x116A428
	int GetMaxCharCount(int byteCount) { }

	// RVA: 0x116A440
	int get_CodePage() { }

	// RVA: 0x116A448
	Encoder GetEncoder() { }

	// RVA: 0x116A450
	Encoding get_UCS4_Littleendian() { }

	// RVA: 0x116A564
	Encoding get_UCS4_Bigendian() { }

	// RVA: 0x116A678
	Encoding get_UCS4_2143() { }

	// RVA: 0x116A78C
	Encoding get_UCS4_3412() { }

	// RVA: 0x116A8A0
	void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding1234 
{
	// Methods

	// RVA: 0x116A5B8
	void .ctor() { }

	// RVA: 0x116A918
	string get_EncodingName() { }

	// RVA: 0x116A95C
	Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding4321 
{
	// Methods

	// RVA: 0x116A4A4
	void .ctor() { }

	// RVA: 0x116AA48
	string get_EncodingName() { }

	// RVA: 0x116AA8C
	Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding2143 
{
	// Methods

	// RVA: 0x116A6CC
	void .ctor() { }

	// RVA: 0x116AB74
	string get_EncodingName() { }

	// RVA: 0x116ABB8
	Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding3412 
{
	// Methods

	// RVA: 0x116A7E0
	void .ctor() { }

	// RVA: 0x116ACA4
	string get_EncodingName() { }

	// RVA: 0x116ACE8
	Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal abstract class Ucs4Decoder 
{
	// Fields
	internal Byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0x116AD60
	int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: -1
	int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x116AD7C
	int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x116AF84
	void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x116B2B0
	void Ucs4ToUTF16(UInt32 code, Char[] chars, int charIndex) { }

	// RVA: 0x116B30C
	void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder4321 
{
	// Methods

	// RVA: 0x116B37C
	int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x116A9D8
	void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder1234 
{
	// Methods

	// RVA: 0x116B634
	int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x116A8A8
	void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder2143 
{
	// Methods

	// RVA: 0x116B8EC
	int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x116AB04
	void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder3412 
{
	// Methods

	// RVA: 0x116BBA4
	int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x116AC34
	void .ctor() { }

}

// Namespace: System.Xml
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

	// RVA: 0x116BE5C
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x116C538
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x116C6AC
	void .ctor() { }

	// RVA: 0x116C6C4
	void .ctor(string message) { }

	// RVA: 0x116C6E0
	void .ctor(string message, Exception innerException) { }

	// RVA: 0x116C6D8
	void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x116C6F0
	void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x115E638
	void .ctor(string res, string[] args) { }

	// RVA: 0x115E3D4
	void .ctor(string res, string arg) { }

	// RVA: 0x116C9E4
	void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x116CAE0
	void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x116CD4C
	void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x116CB88
	void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x1167760
	void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x116CD54
	void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1167A38
	void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x116CE60
	void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x116CF08
	void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x116C930
	void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x116C830
	string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x116C2BC
	string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x115E5C0
	string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x116CFB0
	string[] BuildCharExceptionArgs(Char[] data, int length, int invCharIndex) { }

	// RVA: 0x115EB0C
	string[] BuildCharExceptionArgs(Char invChar, Char nextChar) { }

	// RVA: 0x116D00C
	int get_LineNumber() { }

	// RVA: 0x116D014
	int get_LinePosition() { }

	// RVA: 0x116D01C
	string get_Message() { }

	// RVA: 0x116D034
	string get_ResString() { }

}

// Namespace: System.Xml
public abstract class XmlNameTable 
{
	// Methods

	// RVA: 0x2FE36BC
	string Get(string array) { }

	// RVA: -1
	string Add(Char[] array, int offset, int length) { }

	// RVA: 0x2FE36BC
	string Add(string array) { }

	// RVA: 0x116D03C
	void .ctor() { }

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

	// RVA: 0x116D2C0
	void Set(string prefix, string uri, int scopeId, int previousNsIndex) { }

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

	// RVA: 0x116D044
	void .ctor() { }

	// RVA: 0x116D04C
	void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x116D30C
	XmlNameTable get_NameTable() { }

	// RVA: 0x116D314
	string get_DefaultNamespace() { }

	// RVA: 0x116D3A0
	void PushScope() { }

	// RVA: 0x116D3B0
	bool PopScope() { }

	// RVA: 0x116D4AC
	void AddNamespace(string prefix, string uri) { }

	// RVA: 0x116DA84
	void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x116DBD0
	IEnumerator GetEnumerator() { }

	// RVA: 0x116DD94
	System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x116E07C
	string LookupNamespace(string prefix) { }

	// RVA: 0x116D8A4
	int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x116E0DC
	string LookupPrefix(string uri) { }

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

	// RVA: 0x116EBA4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x116F210
	internal int Invoke(string s, int sLen, Int64 additionalEntropy) { }

}

// Namespace: System.Xml
public class XmlQualifiedName 
{
	// Fields
	private static HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private string name; // 0x10
	private string ns; // 0x18
	private int hash; // 0x20
	public static readonly XmlQualifiedName Empty; // 0x8

	// Methods

	// RVA: 0x116E1CC
	void .ctor() { }

	// RVA: 0x116E38C
	void .ctor(string name) { }

	// RVA: 0x116E2CC
	void .ctor(string name, string ns) { }

	// RVA: 0x116E48C
	string get_Namespace() { }

	// RVA: 0x116E494
	string get_Name() { }

	// RVA: 0x116E49C
	int GetHashCode() { }

	// RVA: 0x116E7F0
	bool get_IsEmpty() { }

	// RVA: 0x116E834
	string ToString() { }

	// RVA: 0x116E8A8
	bool Equals(object other) { }

	// RVA: 0x116EAB8
	bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x116E9E0
	bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x116EB1C
	string ToString(string name, string ns) { }

	// RVA: 0x116E5A8
	HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x116EB9C
	bool IsRandomizedHashingDisabled() { }

	// RVA: 0x116EC60
	int GetHashCodeOfString(string s, int length, Int64 additionalEntropy) { }

	// RVA: 0x116EC80
	void Init(string name, string ns) { }

	// RVA: 0x116ECBC
	void SetNamespace(string ns) { }

	// RVA: 0x116ECC4
	void Verify() { }

	// RVA: 0x116EDE8
	void Atomize(XmlNameTable nameTable) { }

	// RVA: 0x116EE60
	XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	// RVA: 0x116F0E4
	XmlQualifiedName Clone() { }

	// RVA: 0x116F168
	void .cctor() { }

}

// Namespace: System.Xml
public abstract class XmlResolver 
{
	// Methods

	// RVA: 0x2FE3810
	object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x116F224
	Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x116F420
	bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0x116F59C
	System.Threading.Tasks.Task<System.Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x116F5DC
	void .ctor() { }

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

	// RVA: 0x116F9C8
	void MoveNext() { }

	// RVA: 0x116FDE4
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x116F5E4
	XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x116F6BC
	void .ctor() { }

	// RVA: 0x116F6C4
	object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x116F86C
	Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x116F870
	System.Threading.Tasks.Task<System.Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

}

// Namespace: System.Xml
internal static class BinaryCompatibility 
{
	// Methods

	// RVA: 0x116FE64
	bool get_TargetsAtLeast_Desktop_V4_5_2() { }

}

// Namespace: System.Xml
internal static class Res 
{
	// Methods

	// RVA: 0x1161830
	string GetString(string name) { }

	// RVA: 0x115ED8C
	string GetString(string name, object[] args) { }

}

// Namespace: System.Xml.XPath
public interface IXPathNavigable 
{
	// Methods

	// RVA: 0x2FE360C
	XPathNavigator CreateNavigator() { }

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

	// RVA: 0x116FE6C
	XmlNameTable get_NameTable() { }

	// RVA: 0x116FE74
	bool get_HasLineInfo() { }

	// RVA: 0x116FE7C
	int GetCollapsedTextNode(out XPathNode[] pageText) { }

	// RVA: 0x116FEB0
	int GetRootNode(out XPathNode[] pageRoot) { }

	// RVA: 0x116FEE4
	int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0x116FF18
	int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x1170038
	int LookupIdElement(string id, out XPathNode[] pageElem) { }

}

// Namespace: System.Xml.XPath
public class XPathException 
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string message; // 0xA0

	// Methods

	// RVA: 0x1170120
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1170530
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1170624
	void .ctor() { }

	// RVA: 0x1170684
	void .ctor(string message, Exception innerException) { }

	// RVA: 0x11707EC
	XPathException Create(string res) { }

	// RVA: 0x1170908
	XPathException Create(string res, string arg) { }

	// RVA: 0x11709FC
	XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0x1170B1C
	XPathException Create(string res, string arg, Exception innerException) { }

	// RVA: 0x1170894
	void .ctor(string res, string[] args) { }

	// RVA: 0x1170774
	void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0x11703EC
	string CreateMessage(string res, string[] args) { }

	// RVA: 0x1170C1C
	string get_Message() { }

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

	// RVA: 0x1170C34
	void .ctor() { }

	// RVA: 0x2FE4574
	void SetContext(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1170C3C
	XPathExpression Compile(string xpath) { }

	// RVA: 0x1170C44
	XPathExpression Compile(string xpath, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.XPath
public abstract class XPathItem 
{
	// Methods

	// RVA: 0x2FE360C
	XmlSchemaType get_XmlType() { }

	// RVA: 0x2FE360C
	string get_Value() { }

	// RVA: 0x2FE360C
	object get_TypedValue() { }

	// RVA: 0x2FE360C
	Type get_ValueType() { }

	// RVA: 0x2FE3054
	bool get_ValueAsBoolean() { }

	// RVA: -1
	DateTime get_ValueAsDateTime() { }

	// RVA: -1
	Double get_ValueAsDouble() { }

	// RVA: 0x2FE32D4
	int get_ValueAsInt() { }

	// RVA: 0x2FE34E0
	Int64 get_ValueAsLong() { }

	// RVA: 0x1170D34
	object ValueAs(Type returnType) { }

	// RVA: 0x2FE37A0
	object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1170D48
	void .ctor() { }

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

	// RVA: 0x1170D50
	string ToString() { }

	// RVA: 0x1170D5C
	XmlSchemaType get_XmlType() { }

	// RVA: 0x1170F1C
	object get_TypedValue() { }

	// RVA: 0x1171224
	Type get_ValueType() { }

	// RVA: 0x1171460
	bool get_ValueAsBoolean() { }

	// RVA: 0x1171750
	DateTime get_ValueAsDateTime() { }

	// RVA: 0x1171A48
	Double get_ValueAsDouble() { }

	// RVA: 0x1171D40
	int get_ValueAsInt() { }

	// RVA: 0x1172038
	Int64 get_ValueAsLong() { }

	// RVA: 0x1172330
	object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1172638
	object System.ICloneable.Clone() { }

	// RVA: 0x1172648
	XPathNavigator CreateNavigator() { }

	// RVA: 0x2FE360C
	XmlNameTable get_NameTable() { }

	// RVA: 0x1172658
	string LookupNamespace(string prefix) { }

	// RVA: 0x1172840
	string LookupPrefix(string namespaceURI) { }

	// RVA: 0x1172A84
	System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x2FE360C
	XPathNavigator Clone() { }

	// RVA: 0x2FE32D4
	XPathNodeType get_NodeType() { }

	// RVA: 0x2FE360C
	string get_LocalName() { }

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x2FE360C
	string get_NamespaceURI() { }

	// RVA: 0x2FE360C
	string get_Prefix() { }

	// RVA: 0x2FE360C
	string get_BaseURI() { }

	// RVA: 0x1172DB8
	string get_XmlLang() { }

	// RVA: 0x1172EA8
	object get_UnderlyingObject() { }

	// RVA: 0x1172EB0
	bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x2FE3054
	bool MoveToFirstAttribute() { }

	// RVA: 0x2FE3054
	bool MoveToNextAttribute() { }

	// RVA: 0x1172F94
	bool MoveToNamespace(string name) { }

	// RVA: 0x2FE3088
	bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x2FE3088
	bool MoveToNextNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x1173040
	bool MoveToFirstNamespace() { }

	// RVA: 0x1173054
	bool MoveToNextNamespace() { }

	// RVA: 0x2FE3054
	bool MoveToNext() { }

	// RVA: 0x2FE3054
	bool MoveToFirstChild() { }

	// RVA: 0x2FE3054
	bool MoveToParent() { }

	// RVA: 0x1173068
	void MoveToRoot() { }

	// RVA: 0x2FE3174
	bool MoveTo(XPathNavigator other) { }

	// RVA: 0x2FE3174
	bool MoveToId(string id) { }

	// RVA: 0x117309C
	bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x117319C
	bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x1173394
	bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x1173680
	bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x1173928
	bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x1173A34
	bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x2FE3174
	bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x1173B9C
	bool IsDescendant(XPathNavigator nav) { }

	// RVA: 0x1173C3C
	XmlNodeOrder ComparePosition(XPathNavigator nav) { }

	// RVA: 0x1174140
	IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1174194
	XPathNodeIterator Select(string xpath) { }

	// RVA: 0x11741D0
	XPathNodeIterator Select(XPathExpression expr) { }

	// RVA: 0x1174294
	object Evaluate(XPathExpression expr) { }

	// RVA: 0x11742A8
	object Evaluate(XPathExpression expr, XPathNodeIterator context) { }

	// RVA: 0x1174490
	XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x1174518
	XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x11745B0
	XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x1174648
	XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x117356C
	bool MoveToNonDescendant() { }

	// RVA: 0x1173F7C
	int GetDepth(XPathNavigator nav) { }

	// RVA: 0x1173FC4
	XmlNodeOrder CompareSiblings(XPathNavigator n1, XPathNavigator n2) { }

	// RVA: 0x11732F4
	int GetContentKindMask(XPathNodeType type) { }

	// RVA: 0x11746E8
	int GetKindMask(XPathNodeType type) { }

	// RVA: 0x117470C
	bool IsText(XPathNodeType type) { }

	// RVA: 0x117471C
	void .ctor() { }

	// RVA: 0x1174724
	void .cctor() { }

}

// Namespace: System.Xml.XPath
internal class XPathNavigatorKeyComparer 
{
	// Methods

	// RVA: 0x11748B8
	bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0x11749A4
	int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x11748B0
	void .ctor() { }

}

// Namespace: 
private class Enumerator 
{
	// Fields
	private XPathNodeIterator original; // 0x10
	private XPathNodeIterator current; // 0x18
	private bool iterationStarted; // 0x20

	// Methods

	// RVA: 0x1174C90
	void .ctor(XPathNodeIterator original) { }

	// RVA: 0x1174CEC
	object get_Current() { }

	// RVA: 0x1174E30
	bool MoveNext() { }

	// RVA: 0x1174ED0
	void Reset() { }

}

// Namespace: System.Xml.XPath
public abstract class XPathNodeIterator 
{
	// Fields
	internal int count; // 0x10

	// Methods

	// RVA: 0x1174B80
	object System.ICloneable.Clone() { }

	// RVA: 0x2FE360C
	XPathNodeIterator Clone() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE360C
	XPathNavigator get_Current() { }

	// RVA: 0x2FE32D4
	int get_CurrentPosition() { }

	// RVA: 0x1174B8C
	int get_Count() { }

	// RVA: 0x1174C04
	IEnumerator GetEnumerator() { }

	// RVA: 0x1174CDC
	void .ctor() { }

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

	// RVA: 0x1174ED8
	string MakePascal(string identifier) { }

	// RVA: 0x11750EC
	string MakeValid(string identifier) { }

	// RVA: 0x1175384
	bool IsValidStart(Char c) { }

	// RVA: 0x1175304
	bool IsValid(Char c) { }

	// RVA: 0x11753F4
	void .cctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlSerializerNamespaces 
{
	// Fields
	private Hashtable namespaces; // 0x10

	// Methods

	// RVA: 0x117547C
	void .ctor() { }

	// RVA: 0x1175484
	void Add(string prefix, string ns) { }

	// RVA: 0x11755FC
	void AddInternal(string prefix, string ns) { }

	// RVA: 0x1175724
	XmlQualifiedName[] ToArray() { }

	// RVA: 0x1175D44
	int get_Count() { }

	// RVA: 0x117582C
	ArrayList get_NamespaceList() { }

	// RVA: 0x117569C
	Hashtable get_Namespaces() { }

	// RVA: 0x1175DCC
	void set_Namespaces(Hashtable value) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlAttributeEventHandler 
{
	// Methods

	// RVA: 0x1175DD4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1175EF8
	internal void Invoke(object sender, XmlAttributeEventArgs e) { }

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

	// RVA: 0x1175F0C
	void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlElementEventHandler 
{
	// Methods

	// RVA: 0x1175FCC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x11760F0
	internal void Invoke(object sender, XmlElementEventArgs e) { }

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

	// RVA: 0x1176104
	void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlNodeEventHandler 
{
	// Methods

	// RVA: 0x11761C4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x11762E8
	internal void Invoke(object sender, XmlNodeEventArgs e) { }

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

	// RVA: 0x11762FC
	void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

// Namespace: System.Xml.Serialization
public sealed class UnreferencedObjectEventHandler 
{
	// Methods

	// RVA: 0x11763A8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x11764CC
	internal void Invoke(object sender, UnreferencedObjectEventArgs e) { }

}

// Namespace: System.Xml.Serialization
public class UnreferencedObjectEventArgs 
{
	// Fields
	private object o; // 0x10
	private string id; // 0x18

	// Methods

	// RVA: 0x11764E0
	void .ctor(object o, string id) { }

}

// Namespace: System.Xml.Serialization
public interface IXmlSerializable 
{
	// Methods

	// RVA: 0x2FE360C
	XmlSchema GetSchema() { }

	// RVA: 0x2FE4574
	void ReadXml(XmlReader reader) { }

	// RVA: 0x2FE4574
	void WriteXml(XmlWriter writer) { }

}

// Namespace: System.Xml.Serialization
public interface IXmlTextParser 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_Normalized() { }

	// RVA: 0x2FE4234
	void set_Normalized(bool value) { }

}

// Namespace: System.Xml.Serialization
internal class KeyHelper 
{
	// Methods

	// RVA: 0x1176574
	void AddField(StringBuilder sb, int n, string val) { }

	// RVA: 0x117657C
	void AddField(StringBuilder sb, int n, string val, string def) { }

	// RVA: 0x1176668
	void AddField(StringBuilder sb, int n, bool val) { }

	// RVA: 0x11766B8
	void AddField(StringBuilder sb, int n, bool val, bool def) { }

	// RVA: 0x117670C
	void AddField(StringBuilder sb, int n, int val, int def) { }

	// RVA: 0x11767D0
	void AddField(StringBuilder sb, int n, Type val) { }

}

// Namespace: System.Xml.Serialization
internal class ReflectionHelper 
{
	// Fields
	private Hashtable _clrTypes; // 0x10
	private Hashtable _schemaTypes; // 0x18
	private static readonly ParameterModifier[] empty_modifiers; // 0x0

	// Methods

	// RVA: 0x11768FC
	void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x11769C8
	XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x1176AB4
	void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x1176C18
	XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x1176D90
	void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x1177160
	void .ctor() { }

	// RVA: 0x11771FC
	void .cctor() { }

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

	// RVA: 0x117727C
	void .ctor(string namspace, Type[] includedTypes) { }

	// RVA: 0x11772D4
	bool BaseEquals(SerializationSource other) { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeSerializationSource 
{
	// Fields
	private string attributeOverridesHash; // 0x28
	private Type type; // 0x30
	private string rootHash; // 0x38

	// Methods

	// RVA: 0x11773C8
	void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0x1177514
	bool Equals(object o) { }

	// RVA: 0x11775FC
	int GetHashCode() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeConvertorAttribute 
{
	// Fields
	private string <Method>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1177620
	string get_Method() { }

	// RVA: 0x1177628
	void set_Method(string value) { }

	// RVA: 0x1177630
	void .ctor(string method) { }

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

	// RVA: 0x1177664
	void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x1177670
	void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x1177CE8
	void LookupTypeConvertor() { }

	// RVA: 0x1177DAC
	void ConvertForAssignment(ref object value) { }

	// RVA: 0x1177EA4
	string get_TypeName() { }

	// RVA: 0x1177EAC
	string get_XmlType() { }

	// RVA: 0x1177EB4
	Type get_Type() { }

	// RVA: 0x1177EBC
	string get_FullTypeName() { }

	// RVA: 0x1177EC4
	SchemaTypes get_SchemaType() { }

	// RVA: 0x1177150
	bool get_IsListType() { }

	// RVA: 0x1177ECC
	bool get_IsComplexType() { }

	// RVA: 0x1177F04
	bool get_IsValueType() { }

	// RVA: 0x1177FCC
	bool get_IsNullable() { }

	// RVA: 0x1178174
	void set_IsNullable(bool value) { }

	// RVA: 0x1177A88
	TypeData get_ListItemTypeData() { }

	// RVA: 0x117817C
	Type get_ListItemType() { }

	// RVA: 0x1177EF4
	bool get_IsXsdType() { }

	// RVA: 0x1178DF0
	bool get_HasPublicConstructor() { }

	// RVA: 0x1178B7C
	PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x1178CC0
	InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x1178950
	Type GetGenericListItemType(Type type) { }

	// RVA: 0x1178DF8
	void .cctor() { }

}

// Namespace: System.Xml.Serialization
internal sealed class TypeMember 
{
	// Fields
	private Type type; // 0x10
	private string member; // 0x18

	// Methods

	// RVA: 0x1179DEC
	void .ctor(Type type, string member) { }

	// RVA: 0x1179E3C
	int GetHashCode() { }

	// RVA: 0x1179E8C
	bool Equals(object obj) { }

	// RVA: 0x1179F7C
	bool Equals(TypeMember tm1, TypeMember tm2) { }

	// RVA: 0x117A064
	string ToString() { }

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

	// RVA: 0x117A0CC
	void .cctor() { }

	// RVA: 0x11770E8
	TypeData GetTypeData(Type type) { }

	// RVA: 0x117C434
	TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType) { }

	// RVA: 0x117D010
	TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x117D098
	TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x117D2CC
	TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x1177BD4
	string GetArrayName(string elemName) { }

	// RVA: 0x117D3B0
	void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyAttributeAttribute 
{
	// Methods

	// RVA: 0x117D54C
	void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyElementAttribute 
{
	// Fields
	private string elementName; // 0x10
	private string ns; // 0x18
	private int order; // 0x20

	// Methods

	// RVA: 0x117D554
	void .ctor() { }

	// RVA: 0x117D564
	string get_Name() { }

	// RVA: 0x117D5D0
	string get_Namespace() { }

	// RVA: 0x117D5D8
	int get_Order() { }

	// RVA: 0x117D5E0
	void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyElementAttributes 
{
	// Methods

	// RVA: 0x117D67C
	XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x117D79C
	int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x117D860
	void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x117D93C
	int get_Order() { }

	// RVA: 0x117DC08
	void .ctor() { }

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

	// RVA: 0x117DC10
	string get_ElementName() { }

	// RVA: 0x117DC7C
	XmlSchemaForm get_Form() { }

	// RVA: 0x117DC84
	bool get_IsNullable() { }

	// RVA: 0x117DC8C
	string get_Namespace() { }

	// RVA: 0x117DC94
	int get_Order() { }

	// RVA: 0x117DC9C
	void AddKeyHash(StringBuilder sb) { }

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

	// RVA: 0x117DDC8
	string get_DataType() { }

	// RVA: 0x117DE34
	string get_ElementName() { }

	// RVA: 0x117DEA0
	XmlSchemaForm get_Form() { }

	// RVA: 0x117DEA8
	string get_Namespace() { }

	// RVA: 0x117DEB0
	bool get_IsNullable() { }

	// RVA: 0x117DEB8
	bool get_IsNullableSpecified() { }

	// RVA: 0x117DEC0
	Type get_Type() { }

	// RVA: 0x117DEC8
	int get_NestingLevel() { }

	// RVA: 0x117DED0
	void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlArrayItemAttributes 
{
	// Methods

	// RVA: 0x117E040
	XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x117E160
	int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x117E224
	void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x117E300
	void .ctor() { }

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

	// RVA: 0x117E308
	void .ctor(string attributeName) { }

	// RVA: 0x117E33C
	string get_AttributeName() { }

	// RVA: 0x117E3A8
	string get_DataType() { }

	// RVA: 0x117E414
	void set_DataType(string value) { }

	// RVA: 0x117E41C
	XmlSchemaForm get_Form() { }

	// RVA: 0x117E424
	string get_Namespace() { }

	// RVA: 0x117E42C
	void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlAttributeOverrides 
{
	// Fields
	private Hashtable overrides; // 0x10

	// Methods

	// RVA: 0x117E56C
	void .ctor() { }

	// RVA: 0x117E5E4
	XmlAttributes get_Item(Type type) { }

	// RVA: 0x117E648
	XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x117E740
	TypeMember GetKey(Type type, string member) { }

	// RVA: 0x117E7B0
	void AddKeyHash(StringBuilder sb) { }

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

	// RVA: 0x117EFB4
	void .ctor() { }

	// RVA: 0x117F0E8
	void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x117FB3C
	XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x117FB44
	XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x117FB4C
	XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x117FB54
	XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x117FB5C
	XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x117FB64
	XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x117FB6C
	object get_XmlDefaultValue() { }

	// RVA: 0x117FB74
	XmlElementAttributes get_XmlElements() { }

	// RVA: 0x117FB7C
	bool get_XmlIgnore() { }

	// RVA: 0x117FB84
	bool get_Xmlns() { }

	// RVA: 0x117FB8C
	XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x117FB94
	XmlTextAttribute get_XmlText() { }

	// RVA: 0x117FB9C
	XmlTypeAttribute get_XmlType() { }

	// RVA: 0x117ECA0
	void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1180B84
	System.Nullable<System.Int32> get_Order() { }

	// RVA: 0x1180F20
	int get_SortableOrder() { }

}

// Namespace: System.Xml.Serialization
public class XmlChoiceIdentifierAttribute 
{
	// Fields
	private string memberName; // 0x10

	// Methods

	// RVA: 0x1180FFC
	string get_MemberName() { }

	// RVA: 0x1180AFC
	void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
internal class XmlCustomFormatter 
{
	// Fields
	private static string[] allTimeFormats; // 0x0

	// Methods

	// RVA: 0x1181068
	string FromEnum(Int64 value, string[] values, Int64[] ids, string typeName) { }

	// RVA: 0x11813D8
	string FromXmlName(string name) { }

	// RVA: 0x1181460
	string FromXmlNCName(string ncName) { }

	// RVA: 0x117FC80
	string ToXmlString(TypeData type, object value) { }

	// RVA: 0x11814E8
	object FromXmlString(TypeData type, string value) { }

	// RVA: 0x118208C
	void .cctor() { }

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

	// RVA: 0x11825EC
	void .ctor(string elementName) { }

	// RVA: 0x1182628
	void .ctor(string elementName, Type type) { }

	// RVA: 0x1182680
	string get_DataType() { }

	// RVA: 0x11826EC
	string get_ElementName() { }

	// RVA: 0x1182758
	XmlSchemaForm get_Form() { }

	// RVA: 0x1182760
	string get_Namespace() { }

	// RVA: 0x1182768
	bool get_IsNullable() { }

	// RVA: 0x1182770
	int get_Order() { }

	// RVA: 0x1182778
	Type get_Type() { }

	// RVA: 0x1182780
	void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlElementAttributes 
{
	// Methods

	// RVA: 0x11828D4
	XmlElementAttribute get_Item(int index) { }

	// RVA: 0x117FA78
	int Add(XmlElementAttribute attribute) { }

	// RVA: 0x117FBA4
	void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1180C54
	int get_Order() { }

	// RVA: 0x117F0E0
	void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlEnumAttribute 
{
	// Fields
	private string name; // 0x10

	// Methods

	// RVA: 0x11829F4
	void .ctor(string name) { }

	// RVA: 0x1182A28
	string get_Name() { }

	// RVA: 0x11809B0
	void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlIgnoreAttribute 
{
	// Methods

	// RVA: 0x1182A30
	void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlIncludeAttribute 
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0x1182A38
	Type get_Type() { }

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

	// RVA: 0x1182A40
	void .ctor(string elementName, string ns) { }

	// RVA: 0x1182A90
	string get_ElementName() { }

	// RVA: 0x1182A98
	string get_Namespace() { }

	// RVA: 0x1182AA0
	void SetKey(string key) { }

	// RVA: 0x1182AA8
	ObjectMap get_ObjectMap() { }

	// RVA: 0x1182AB0
	void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x1182AB8
	ArrayList get_RelatedMaps() { }

	// RVA: 0x1182AC0
	void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x1182AC8
	SerializationFormat get_Format() { }

	// RVA: 0x1182AD0
	void set_Format(SerializationFormat value) { }

	// RVA: 0x1182AD8
	SerializationSource get_Source() { }

}

// Namespace: System.Xml.Serialization
internal class ObjectMap 
{
	// Methods

	// RVA: 0x1182AE0
	void .ctor() { }

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

	// RVA: 0x1182AE8
	int get_Count() { }

	// RVA: 0x1182B08
	bool get_HasWrapperElement() { }

}

// Namespace: System.Xml.Serialization
public class XmlNamespaceDeclarationsAttribute 
{
	// Methods

	// RVA: 0x1182B10
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly System.Xml.Serialization.XmlReflectionImporter.<>c <>9; // 0x0
	public static System.Comparison<System.Xml.Serialization.XmlReflectionMember> <>9__28_0; // 0x8

	// Methods

	// RVA: 0x118A8BC
	void .cctor() { }

	// RVA: 0x118A928
	void .ctor() { }

	// RVA: 0x118A930
	int <ImportClassMapping>b__28_0(XmlReflectionMember m1, XmlReflectionMember m2) { }

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

	// RVA: 0x1182B18
	void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x1182CB4
	XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x1182EC0
	XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x1182CC0
	XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1182ECC
	XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1186070
	XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x1186600
	XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType) { }

	// RVA: 0x1183370
	XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType) { }

	// RVA: 0x1188384
	void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x118669C
	string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1188658
	XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x11847F0
	XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x118568C
	XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1185888
	XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1185958
	XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1185F40
	XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1188504
	void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x1186810
	System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x1187804
	XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x1188DA0
	XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x1188760
	XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x1189FBC
	void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x1186544
	bool CanBeNull(TypeData type) { }

	// RVA: 0x118A30C
	void IncludeType(Type type) { }

	// RVA: 0x1189DD0
	object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x118A81C
	void .cctor() { }

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

	// RVA: 0x11886FC
	void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x118AA20
	bool get_IsReturnValue() { }

	// RVA: 0x118AA28
	string get_MemberName() { }

	// RVA: 0x118AA30
	Type get_MemberType() { }

	// RVA: 0x1187780
	XmlAttributes get_XmlAttributes() { }

	// RVA: 0x118AA38
	Type get_DeclaringType() { }

	// RVA: 0x118AA40
	void set_DeclaringType(Type value) { }

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

	// RVA: 0x118AA48
	void .ctor() { }

	// RVA: 0x118AA58
	void .ctor(string elementName) { }

	// RVA: 0x118AA94
	string get_DataType() { }

	// RVA: 0x118AB00
	void set_DataType(string value) { }

	// RVA: 0x1186594
	string get_ElementName() { }

	// RVA: 0x118AB08
	void set_ElementName(string value) { }

	// RVA: 0x118AB10
	bool get_IsNullable() { }

	// RVA: 0x118AB18
	void set_IsNullable(bool value) { }

	// RVA: 0x118AB20
	string get_Namespace() { }

	// RVA: 0x118AB28
	void set_Namespace(string value) { }

	// RVA: 0x1180A38
	void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSchemaProviderAttribute 
{
	// Fields
	private string _methodName; // 0x10
	private bool _isAny; // 0x18

	// Methods

	// RVA: 0x118AB30
	void .ctor(string methodName) { }

	// RVA: 0x118AB64
	string get_MethodName() { }

	// RVA: 0x118AB6C
	bool get_IsAny() { }

	// RVA: 0x118AB74
	void set_IsAny(bool value) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationCollectionFixupCallback 
{
	// Methods

	// RVA: 0x118AB7C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x118ACA0
	internal void Invoke(object collection, object collectionItems) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationFixupCallback 
{
	// Methods

	// RVA: 0x118ACB4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x118ADD4
	internal void Invoke(object fixup) { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationGeneratedCode 
{
	// Methods

	// RVA: 0x118ADE8
	void .ctor() { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationReadCallback 
{
	// Methods

	// RVA: 0x118ADF0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x118AE90
	internal object Invoke() { }

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

	// RVA: 0x118B834
	void .ctor() { }

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

	// RVA: 0x118FD24
	void .ctor(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

	// RVA: 0x118FD88
	XmlSerializationCollectionFixupCallback get_Callback() { }

	// RVA: 0x118FD90
	object get_Collection() { }

	// RVA: 0x118FD98
	object get_Id() { }

	// RVA: 0x118FDA0
	object get_CollectionItems() { }

	// RVA: 0x118FDA8
	void set_CollectionItems(object value) { }

}

// Namespace: 
protected class Fixup 
{
	// Fields
	private object source; // 0x10
	private string[] ids; // 0x18
	private XmlSerializationFixupCallback callback; // 0x20

	// Methods

	// RVA: 0x118FDB0
	void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	// RVA: 0x118FE54
	XmlSerializationFixupCallback get_Callback() { }

	// RVA: 0x118FE5C
	string[] get_Ids() { }

	// RVA: 0x118FE64
	object get_Source() { }

}

// Namespace: 
private class CollectionItemFixup 
{
	// Fields
	private Array list; // 0x10
	private int index; // 0x18
	private string id; // 0x20

	// Methods

	// RVA: 0x118DF2C
	void .ctor(Array list, int index, string id) { }

	// RVA: 0x118FE6C
	Array get_Collection() { }

	// RVA: 0x118FE74
	int get_Index() { }

	// RVA: 0x118FE7C
	string get_Id() { }

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

	// RVA: 0x118AEA4
	void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x118B270
	ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x118B2E4
	Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x118B358
	void .ctor() { }

	// RVA: 0x118B360
	XmlDocument get_Document() { }

	// RVA: 0x118B414
	XmlReader get_Reader() { }

	// RVA: 0x118B41C
	void AddFixup(CollectionFixup fixup) { }

	// RVA: 0x118B560
	void AddFixup(Fixup fixup) { }

	// RVA: 0x118B614
	void AddFixup(CollectionItemFixup fixup) { }

	// RVA: 0x118B6C8
	void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x118B83C
	void AddTarget(string id, object o) { }

	// RVA: 0x118B9DC
	string CurrentTag() { }

	// RVA: 0x118BB68
	Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x118BBF8
	Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x118BC98
	Exception CreateUnknownNodeException() { }

	// RVA: 0x118BD2C
	Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x118BED4
	Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x118BF70
	bool GetNullAttr() { }

	// RVA: 0x118C038
	object GetTarget(string id) { }

	// RVA: 0x118C118
	bool TargetReady(string id) { }

	// RVA: 0x118C134
	XmlQualifiedName GetXsiType() { }

	// RVA: 0x2FE41A8
	void InitCallbacks() { }

	// RVA: 0x2FE41A8
	void InitIDs() { }

	// RVA: 0x118C334
	bool IsXmlnsAttribute(string name) { }

	// RVA: 0x118C3D8
	void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x118C558
	XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x118C894
	void ReadEndElement() { }

	// RVA: 0x118C95C
	bool ReadNull() { }

	// RVA: 0x118CA78
	XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x118CAB0
	string ReadNullableString() { }

	// RVA: 0x118CB08
	object ReadReferencedElement() { }

	// RVA: 0x118CE64
	WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x118CB60
	object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x118CF5C
	bool ReadList(out object resultList) { }

	// RVA: 0x118DF84
	void ReadReferencedElements() { }

	// RVA: 0x118EEBC
	object ReadReferencingElement(out string fixupReference) { }

	// RVA: 0x118DF20
	object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	// RVA: 0x118EF28
	object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	// RVA: 0x118F2FC
	IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x118F4C4
	object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x118D4E4
	object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x118F750
	XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x118F84C
	XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x118F968
	Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x118C658
	XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x118FA18
	void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x118FB7C
	void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x118CA40
	void UnknownNode(object o) { }

	// RVA: 0x118FCE0
	void UnknownNode(object o, string qnames) { }

	// RVA: 0x118F4CC
	void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x118EE24
	void UnreferencedObject(string id, object o) { }

}

// Namespace: 
private class FixupCallbackInfo 
{
	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private ClassMap _map; // 0x18
	private bool _isValueList; // 0x20

	// Methods

	// RVA: 0x1194F5C
	void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

	// RVA: 0x1196198
	void FixupMembers(object fixup) { }

}

// Namespace: 
private class ReaderCallbackInfo 
{
	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x11902E4
	void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

	// RVA: 0x11961C4
	object ReadObject() { }

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

	// RVA: 0x118FE84
	void .ctor(XmlMapping typeMap) { }

	// RVA: 0x118FECC
	void InitCallbacks() { }

	// RVA: 0x1190334
	void InitIDs() { }

	// RVA: 0x1190338
	object ReadRoot() { }

	// RVA: 0x1190520
	object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x1190670
	object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x1190444
	object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x1193860
	object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x1194140
	object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x1194480
	void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x1190CE8
	void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1191224
	void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x1194C64
	void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1195314
	void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x11956FC
	void ProcessUnknownAttribute(object target) { }

	// RVA: 0x1195734
	void ProcessUnknownElement(object target) { }

	// RVA: 0x1194E44
	bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x1194678
	void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x1190C1C
	void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x119481C
	object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x1195070
	object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x119576C
	object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x119452C
	object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x11939CC
	object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x11958B0
	object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x11948F0
	void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x1194478
	object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x1190BAC
	object CreateInstance(Type type) { }

	// RVA: 0x1194FB8
	object CreateList(Type listType) { }

	// RVA: 0x1194EB4
	object InitializeList(TypeData listType) { }

	// RVA: 0x1195C48
	void FillList(object list, object items) { }

	// RVA: 0x1195C58
	void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x1193840
	object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x119524C
	object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x1193E14
	object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1193F04
	object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1195AF4
	object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x1193F74
	object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x11960A4
	void .cctor() { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationWriteCallback 
{
	// Methods

	// RVA: 0x11961F8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1196318
	internal void Invoke(object o) { }

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

	// RVA: 0x1199EC4
	void .ctor() { }

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

	// RVA: 0x119632C
	void .ctor() { }

	// RVA: 0x11963A8
	void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x11964E0
	XmlWriter get_Writer() { }

	// RVA: 0x11964E8
	void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x119660C
	Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x11966AC
	Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x1196750
	Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x11967E0
	string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x11969BC
	string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x1196AE4
	bool AlreadyQueued(object ob) { }

	// RVA: 0x1196B24
	string GetNamespacePrefix(string ns) { }

	// RVA: 0x11968E0
	string GetQualifiedName(string name, string ns) { }

	// RVA: 0x2FE41A8
	void InitCallbacks() { }

	// RVA: 0x1196C9C
	void TopLevelElement() { }

	// RVA: 0x1196CA8
	void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x1196C70
	void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x1196CE4
	void WriteXmlNode(XmlNode node) { }

	// RVA: 0x1196D90
	void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x1197090
	void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x1197394
	void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x119739C
	void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x11976A4
	void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x11976AC
	void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x1197680
	void WriteEndElement() { }

	// RVA: 0x1197884
	void WriteEndElement(object o) { }

	// RVA: 0x11978D0
	void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x1197D04
	void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x1197DEC
	void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x1197EC4
	void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x1197ED0
	void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x1196FCC
	void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x11972CC
	void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x1197EE0
	void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x11985EC
	void WriteReferencedElements() { }

	// RVA: 0x11984EC
	bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x119880C
	void WriteArray(object o, TypeData td) { }

	// RVA: 0x1198B18
	void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x1198454
	void CheckReferenceQueue() { }

	// RVA: 0x1198CF8
	void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x1198D00
	void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x1198EE0
	void WriteStartDocument() { }

	// RVA: 0x1197550
	void WriteStartElement(string name, string ns) { }

	// RVA: 0x1198444
	void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x1198F40
	void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x1198F38
	void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x1198F4C
	void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x1199888
	void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x1199BD4
	void WriteValue(string value) { }

	// RVA: 0x1199C08
	void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x1197560
	void WriteXsiType(string name, string ns) { }

}

// Namespace: 
private class CallbackInfo 
{
	// Fields
	private XmlSerializationWriterInterpreter _swi; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x119A320
	void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

	// RVA: 0x11A0D68
	void WriteObject(object ob) { }

	// RVA: 0x11A0DB8
	void WriteEnum(object ob) { }

}

// Namespace: System.Xml.Serialization
internal class XmlSerializationWriterInterpreter 
{
	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x1199ECC
	void .ctor(XmlMapping typeMap) { }

	// RVA: 0x1199F14
	void InitCallbacks() { }

	// RVA: 0x119A370
	void WriteRoot(object ob) { }

	// RVA: 0x119A580
	void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x119B198
	void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x119B3DC
	void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x119B628
	void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x119BE04
	void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x119B398
	void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x119B6D0
	void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x119BEAC
	void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x119CA30
	object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x119C7BC
	bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x119D220
	void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x119ACA0
	object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x119F044
	void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x119F3D8
	void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x119F6A0
	void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x119D828
	void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x119F898
	int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x119E110
	void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x11A0884
	void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x11A08CC
	void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x119CF34
	string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x11A0908
	string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }

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

	// RVA: 0x11A1E9C
	XmlSerializationWriter CreateWriter() { }

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

	// RVA: 0x11A0E08
	void .cctor() { }

	// RVA: 0x11A0EC8
	void .ctor(Type type) { }

	// RVA: 0x11A0EDC
	void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11A1088
	XmlMapping get_Mapping() { }

	// RVA: 0x11A1090
	void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0x11A10B4
	void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0x11A10D8
	void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0x11A10FC
	void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0x11A1120
	XmlSerializationReader CreateReader() { }

	// RVA: 0x11A1160
	XmlSerializationWriter CreateWriter() { }

	// RVA: 0x11A11A0
	object Deserialize(TextReader textReader) { }

	// RVA: 0x11A1238
	object Deserialize(XmlReader xmlReader) { }

	// RVA: 0x11A1360
	object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0x11A1658
	void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0x11A1878
	void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0x11A1C4C
	void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0x11A1914
	void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0x11A1C54
	XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0x11A12F8
	XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

}

// Namespace: System.Xml.Serialization
public class XmlSerializerFactory 
{
	// Fields
	private static Hashtable serializersBySource; // 0x0

	// Methods

	// RVA: 0x11A1FA8
	void .ctor() { }

	// RVA: 0x11A1FB0
	XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0x11A225C
	XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0x11A1FC4
	XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x11A2270
	void .cctor() { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializerImplementation 
{
	// Methods

	// RVA: 0x11A22F8
	XmlSerializationWriter get_Writer() { }

}

// Namespace: System.Xml.Serialization
public class XmlTextAttribute 
{
	// Fields
	private string dataType; // 0x10
	private Type type; // 0x18

	// Methods

	// RVA: 0x11A2338
	void .ctor() { }

	// RVA: 0x11A2340
	string get_DataType() { }

	// RVA: 0x11A23AC
	Type get_Type() { }

	// RVA: 0x11A23B4
	void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlTypeAttribute 
{
	// Fields
	private bool includeInSchema; // 0x10
	private string ns; // 0x18
	private string typeName; // 0x20

	// Methods

	// RVA: 0x11A2450
	bool get_IncludeInSchema() { }

	// RVA: 0x11A2458
	string get_Namespace() { }

	// RVA: 0x11A2460
	string get_TypeName() { }

	// RVA: 0x11A24CC
	void AddKeyHash(StringBuilder sb) { }

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

	// RVA: 0x11A257C
	void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x11A2654
	TypeData get_TypeData() { }

	// RVA: 0x11A265C
	object get_ChoiceValue() { }

	// RVA: 0x11A2664
	void set_ChoiceValue(object value) { }

	// RVA: 0x11A266C
	string get_ElementName() { }

	// RVA: 0x11A2674
	void set_ElementName(string value) { }

	// RVA: 0x11A267C
	string get_Namespace() { }

	// RVA: 0x11A2684
	void set_Namespace(string value) { }

	// RVA: 0x119F32C
	string get_DataTypeNamespace() { }

	// RVA: 0x119F2F8
	string get_DataTypeName() { }

	// RVA: 0x11A268C
	XmlSchemaForm get_Form() { }

	// RVA: 0x11A2694
	void set_Form(XmlSchemaForm value) { }

	// RVA: 0x11A269C
	XmlTypeMapping get_MappedType() { }

	// RVA: 0x11A26A4
	void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x11A26AC
	bool get_IsNullable() { }

	// RVA: 0x11A26B4
	void set_IsNullable(bool value) { }

	// RVA: 0x11A26BC
	XmlTypeMapMember get_Member() { }

	// RVA: 0x11A26C4
	void set_NestingLevel(int value) { }

	// RVA: 0x11A26CC
	bool get_MultiReferenceType() { }

	// RVA: 0x11A26EC
	bool get_WrappedElement() { }

	// RVA: 0x11A26F4
	void set_WrappedElement(bool value) { }

	// RVA: 0x11A26FC
	bool get_IsTextElement() { }

	// RVA: 0x11A2754
	void set_IsTextElement(bool value) { }

	// RVA: 0x11A2828
	bool get_IsUnnamedAnyElement() { }

	// RVA: 0x11A2888
	void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x11A2950
	int get_ExplicitOrder() { }

	// RVA: 0x11A2958
	void set_ExplicitOrder(int value) { }

	// RVA: 0x11A2960
	bool Equals(object other) { }

	// RVA: 0x11A2AC4
	int GetHashCode() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfoList 
{
	// Methods

	// RVA: 0x11A2ACC
	void .ctor() { }

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

	// RVA: 0x11A2AD4
	void .ctor() { }

	// RVA: 0x11A2B58
	string get_Name() { }

	// RVA: 0x11A2B60
	void set_Name(string value) { }

	// RVA: 0x11A2B68
	object get_DefaultValue() { }

	// RVA: 0x11A2B70
	void set_DefaultValue(object value) { }

	// RVA: 0x11A2B78
	bool IsReadOnly(Type type) { }

	// RVA: 0x11A2EFC
	object GetValue(object ob, string name) { }

	// RVA: 0x119B508
	object GetValue(object ob) { }

	// RVA: 0x11A3028
	void SetValue(object ob, object value) { }

	// RVA: 0x11A3178
	void SetValue(object ob, string name, object value) { }

	// RVA: 0x11A2C80
	void InitMember(Type type) { }

	// RVA: 0x11A32AC
	TypeData get_TypeData() { }

	// RVA: 0x11A32B4
	void set_TypeData(TypeData value) { }

	// RVA: 0x11A32BC
	int get_Index() { }

	// RVA: 0x11A32C4
	void set_Index(int value) { }

	// RVA: 0x11A32CC
	int get_GlobalIndex() { }

	// RVA: 0x11A32D4
	void set_GlobalIndex(int value) { }

	// RVA: 0x119EDEC
	bool get_IsOptionalValueType() { }

	// RVA: 0x11A32DC
	void set_IsOptionalValueType(bool value) { }

	// RVA: 0x11A32F0
	bool get_IsReturnValue() { }

	// RVA: 0x11A32FC
	void set_IsReturnValue(bool value) { }

	// RVA: 0x11A331C
	void CheckOptionalValueType(Type type) { }

	// RVA: 0x119EDF8
	bool GetValueSpecified(object ob) { }

	// RVA: 0x11A3398
	void SetValueSpecified(object ob, bool value) { }

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

	// RVA: 0x11A3640
	void .ctor() { }

	// RVA: 0x11A36FC
	string get_AttributeName() { }

	// RVA: 0x11A3704
	void set_AttributeName(string value) { }

	// RVA: 0x11A370C
	string get_Namespace() { }

	// RVA: 0x11A3714
	void set_Namespace(string value) { }

	// RVA: 0x11A371C
	void set_Form(XmlSchemaForm value) { }

	// RVA: 0x11A3724
	XmlTypeMapping get_MappedType() { }

	// RVA: 0x11A372C
	void set_MappedType(XmlTypeMapping value) { }

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

	// RVA: 0x11A3734
	void .ctor() { }

	// RVA: 0x119D198
	XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x11A37B8
	void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x11A37C0
	string get_ChoiceMember() { }

	// RVA: 0x11A37C8
	void set_ChoiceMember(string value) { }

	// RVA: 0x11A37D0
	TypeData get_ChoiceTypeData() { }

	// RVA: 0x11A37D8
	void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0x119E72C
	XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0x11A37E0
	void SetChoice(object ob, object choice) { }

	// RVA: 0x11A37F0
	bool get_IsXmlTextCollector() { }

	// RVA: 0x11A37F8
	void set_IsXmlTextCollector(bool value) { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberList 
{
	// Methods

	// RVA: 0x11A3800
	void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberExpandable 
{
	// Fields
	private int _flatArrayIndex; // 0x78

	// Methods

	// RVA: 0x11A3884
	int get_FlatArrayIndex() { }

	// RVA: 0x11A388C
	void set_FlatArrayIndex(int value) { }

	// RVA: 0x11A3894
	void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberFlatList 
{
	// Fields
	private ListMap _listMap; // 0x80

	// Methods

	// RVA: 0x11A3918
	ListMap get_ListMap() { }

	// RVA: 0x11A3920
	void set_ListMap(ListMap value) { }

	// RVA: 0x11A3928
	void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyElement 
{
	// Methods

	// RVA: 0x11A04B0
	bool IsElementDefined(string name, string ns) { }

	// RVA: 0x11A39AC
	bool get_IsDefaultAny() { }

	// RVA: 0x11A3D44
	void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyAttribute 
{
	// Methods

	// RVA: 0x11A3DC8
	void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberNamespaces 
{
	// Methods

	// RVA: 0x11A3E4C
	void .ctor() { }

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

	// RVA: 0x11A3ED0
	void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0x11A09C0
	string get_TypeFullName() { }

	// RVA: 0x11A3FAC
	TypeData get_TypeData() { }

	// RVA: 0x11A3FB4
	string get_XmlType() { }

	// RVA: 0x11A3FBC
	void set_XmlType(string value) { }

	// RVA: 0x119B12C
	string get_XmlTypeNamespace() { }

	// RVA: 0x11A3FC4
	void set_XmlTypeNamespace(string value) { }

	// RVA: 0x11A3FCC
	bool get_HasXmlTypeNamespace() { }

	// RVA: 0x11A3FDC
	ArrayList get_DerivedTypes() { }

	// RVA: 0x11A3FE4
	bool get_MultiReferenceType() { }

	// RVA: 0x11A3FEC
	XmlTypeMapping get_BaseMap() { }

	// RVA: 0x11A3FF4
	void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0x11A3FFC
	void set_IncludeInSchema(bool value) { }

	// RVA: 0x11A4004
	bool get_IsNullable() { }

	// RVA: 0x11A400C
	void set_IsNullable(bool value) { }

	// RVA: 0x11A4014
	bool get_IsAny() { }

	// RVA: 0x11A401C
	void set_IsAny(bool value) { }

	// RVA: 0x119AF9C
	XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0x11A4024
	XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0x11A43EC
	void UpdateRoot(XmlQualifiedName qname) { }

}

// Namespace: System.Xml.Serialization
internal class XmlSerializableMapping 
{
	// Fields
	private XmlSchema _schema; // 0x78
	private XmlSchemaComplexType _schemaType; // 0x80
	private XmlQualifiedName _schemaTypeName; // 0x88

	// Methods

	// RVA: 0x11A44B4
	void .ctor(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

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

	// RVA: 0x11A4D7C
	void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x11A5B9C
	void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x11A5C54
	XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x11A5D88
	XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x11A6144
	XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x11A5AB4
	string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x11A64CC
	bool get_IsOrderDependentMap() { }

	// RVA: 0x11A68C8
	XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x11A68D0
	XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x11A68D8
	XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x119CB00
	ICollection get_AttributeMembers() { }

	// RVA: 0x11A68E0
	ICollection get_ElementMembers() { }

	// RVA: 0x11A68E8
	ArrayList get_AllMembers() { }

	// RVA: 0x11A68F0
	ArrayList get_FlatLists() { }

	// RVA: 0x11A68F8
	ArrayList get_ListMembers() { }

	// RVA: 0x11A6900
	XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x11A6908
	XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x11A6910
	XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x11A6BD0
	void SetCanBeSimpleType(bool can) { }

	// RVA: 0x11A6BD8
	bool get_HasSimpleContent() { }

	// RVA: 0x11A6C4C
	void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class ListMap 
{
	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Methods

	// RVA: 0x11A6D04
	void set_ChoiceMember(string value) { }

	// RVA: 0x11A6D0C
	XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x11A6D14
	void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x119FC78
	XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x11A6D1C
	XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x11A7028
	XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x119F9D0
	void GetArrayType(int itemCount, out string localName, out string ns) { }

	// RVA: 0x11A7348
	bool Equals(object other) { }

	// RVA: 0x11A74AC
	int GetHashCode() { }

	// RVA: 0x11A74B4
	void .ctor() { }

}

// Namespace: 
public class EnumMapMember 
{
	// Fields
	private readonly string _xmlName; // 0x10
	private readonly string _enumName; // 0x18
	private readonly Int64 _value; // 0x20

	// Methods

	// RVA: 0x11A7A24
	void .ctor(string xmlName, string enumName, Int64 value) { }

	// RVA: 0x11A7A80
	string get_XmlName() { }

	// RVA: 0x11A7A88
	string get_EnumName() { }

	// RVA: 0x11A7A90
	Int64 get_Value() { }

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

	// RVA: 0x11A74BC
	void .ctor(EnumMapMember[] members, bool isFlags) { }

	// RVA: 0x11A766C
	bool get_IsFlags() { }

	// RVA: 0x11A7674
	string[] get_EnumNames() { }

	// RVA: 0x11A767C
	string[] get_XmlNames() { }

	// RVA: 0x11A7684
	Int64[] get_Values() { }

	// RVA: 0x11A09E0
	string GetXmlName(string typeName, object enumValue) { }

	// RVA: 0x11A768C
	string GetEnumName(string typeName, string xmlName) { }

}

// Namespace: System.Xml.XmlConfiguration
public sealed class XmlReaderSection 
{
	// Methods

	// RVA: 0x11A7A98
	bool get_ProhibitDefaultUrlResolver() { }

	// RVA: 0x11A7AA0
	XmlResolver CreateDefaultResolver() { }

	// RVA: 0x11A7AF8
	bool get_CollapseWhiteSpaceIntoEmptyString() { }

}

// Namespace: System.Xml.Xsl
public interface IXsltContextFunction 
{
	// Methods

	// RVA: 0x2FE32D4
	XPathResultType get_ReturnType() { }

	// RVA: 0x2FE3810
	object Invoke(XsltContext xsltContext, object[] args, XPathNavigator docContext) { }

}

// Namespace: System.Xml.Xsl
public interface IXsltContextVariable 
{
	// Methods

	// RVA: 0x2FE32D4
	XPathResultType get_VariableType() { }

	// RVA: 0x2FE36BC
	object Evaluate(XsltContext xsltContext) { }

}

// Namespace: System.Xml.Xsl
public abstract class XsltContext 
{
	// Methods

	// RVA: 0x11A7B00
	void .ctor(bool dummy) { }

	// RVA: 0x2FE37A0
	IXsltContextVariable ResolveVariable(string prefix, string name) { }

	// RVA: 0x2FE3810
	IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) { }

	// RVA: 0x2FE3054
	bool get_Whitespace() { }

	// RVA: 0x2FE3174
	bool PreserveWhitespace(XPathNavigator node) { }

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

	// RVA: 0x11A7B08
	void Clear() { }

	// RVA: 0x11A7B18
	int get_Count() { }

	// RVA: 0x11A7B20
	string GetResult() { }

	// RVA: 0x11A7C20
	void ConcatNoDelimiter(string s) { }

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

	// RVA: 0x11A7DB8
	DoubleLinkAxis get_CurNode() { }

	// RVA: 0x11A7DC0
	void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0x11A7E0C
	void SetDepth(int depth) { }

	// RVA: 0x11A7E14
	void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0x11A7F58
	bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }

}

// Namespace: System.Xml.Schema
internal class AxisStack 
{
	// Fields
	private ArrayList _stack; // 0x10
	private ForwardAxis _subtree; // 0x18
	private ActiveAxis _parent; // 0x20

	// Methods

	// RVA: 0x11A8230
	ForwardAxis get_Subtree() { }

	// RVA: 0x11A8238
	int get_Length() { }

	// RVA: 0x11A8260
	void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0x11A8338
	void Push(int depth) { }

	// RVA: 0x11A83DC
	void Pop() { }

	// RVA: 0x11A818C
	bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0x11A8428
	void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0x11A85DC
	bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0x11A8760
	bool MoveToAttribute(string name, string URN, int depth) { }

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

	// RVA: 0x11A8948
	int get_CurrentDepth() { }

	// RVA: 0x11A8950
	void Reactivate() { }

	// RVA: 0x11A8964
	void .ctor(Asttree axisTree) { }

	// RVA: 0x11A8B28
	bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0x11A8C70
	bool EndElement(string localname, string URN) { }

	// RVA: 0x11A8D8C
	bool MoveToAttribute(string localname, string URN) { }

}

// Namespace: System.Xml.Schema
internal class DoubleLinkAxis 
{
	// Fields
	internal Axis next; // 0x40

	// Methods

	// RVA: 0x11A8E98
	Axis get_Next() { }

	// RVA: 0x11A8EA0
	void set_Next(Axis value) { }

	// RVA: 0x11A8EA8
	void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x11A8F3C
	DoubleLinkAxis ConvertTree(Axis axis) { }

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

	// RVA: 0x11A905C
	DoubleLinkAxis get_RootNode() { }

	// RVA: 0x11A9064
	DoubleLinkAxis get_TopNode() { }

	// RVA: 0x11A906C
	bool get_IsAttribute() { }

	// RVA: 0x11A9074
	bool get_IsDss() { }

	// RVA: 0x11A907C
	bool get_IsSelfAxis() { }

	// RVA: 0x11A9084
	void .ctor(DoubleLinkAxis axis, bool isdesorself) { }

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

	// RVA: 0x11A9248
	ArrayList get_SubtreeArray() { }

	// RVA: 0x11A9250
	void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11A9B24
	bool IsNameTest(Axis ast) { }

	// RVA: 0x11A8150
	bool IsAttribute(Axis ast) { }

	// RVA: 0x11A9B60
	bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0x11A9200
	bool IsSelf(Axis ast) { }

	// RVA: 0x11A92BC
	void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11A9BA8
	void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

// Namespace: System.Xml.Schema
internal class AutoValidator 
{
	// Methods

	// RVA: 0x11A9CE4
	void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x11A9E7C
	bool get_PreserveWhitespace() { }

	// RVA: 0x11A9E84
	void Validate() { }

	// RVA: 0x11AA514
	void CompleteValidation() { }

	// RVA: 0x11AA518
	object FindId(string name) { }

	// RVA: 0x11A9F7C
	ValidationType DetectValidationType() { }

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

	// RVA: 0x11AA5E4
	void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x11AA66C
	void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x11AA744
	XmlNameTable get_NameTable() { }

	// RVA: 0x11AA74C
	SchemaNames get_SchemaNames() { }

	// RVA: 0x11AA7F0
	ValidationEventHandler get_EventHandler() { }

	// RVA: 0x11AA7F8
	XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x11AA800
	bool get_HasErrors() { }

	// RVA: 0x11AA810
	void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x11AAC74
	bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11AAF2C
	bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11AADD0
	bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x11AB178
	void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0x11AB074
	void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0x11AB340
	void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0x11AB4B8
	void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0x11AB5F8
	void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x11AB788
	void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x11AB810
	void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x11AB8BC
	void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x11AB274
	void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x11AB954
	void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }

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

	// RVA: 0x11ABA0C
	void .ctor(BaseValidator other) { }

	// RVA: 0x11A9D78
	void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x11ABAC8
	XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x11ABAD0
	XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x11ABAD8
	XmlNameTable get_NameTable() { }

	// RVA: 0x11AA520
	SchemaNames get_SchemaNames() { }

	// RVA: 0x11ABAE0
	PositionInfo get_PositionInfo() { }

	// RVA: 0x11ABAE8
	XmlResolver get_XmlResolver() { }

	// RVA: 0x11ABAF0
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x11ABAF8
	Uri get_BaseUri() { }

	// RVA: 0x11ABB00
	void set_BaseUri(Uri value) { }

	// RVA: 0x11ABB08
	ValidationEventHandler get_EventHandler() { }

	// RVA: 0x11ABBEC
	SchemaInfo get_SchemaInfo() { }

	// RVA: 0x11ABBF4
	void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x11ABCE0
	bool get_PreserveWhitespace() { }

	// RVA: 0x11ABCE8
	void Validate() { }

	// RVA: 0x11ABCEC
	void CompleteValidation() { }

	// RVA: 0x11ABCF0
	object FindId(string name) { }

	// RVA: 0x11ABCF8
	void ValidateText() { }

	// RVA: 0x11AC1F4
	void ValidateWhitespace() { }

	// RVA: 0x11AC17C
	void SaveTextValue(string value) { }

	// RVA: 0x11AC334
	void SendValidationEvent(string code) { }

	// RVA: 0x11AC094
	void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x11ABFAC
	void SendValidationEvent(string code, string arg) { }

	// RVA: 0x11AC398
	void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x11AC488
	void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x11AC574
	void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x11AC3A0
	void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x11AC660
	void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0x11AC828
	void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0x11ACA2C
	BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

}

// Namespace: System.Xml.Schema
internal sealed class BitSet 
{
	// Fields
	private int count; // 0x10
	private UInt32[] bits; // 0x18

	// Methods

	// RVA: 0x11ACC6C
	void .ctor() { }

	// RVA: 0x11ACC74
	void .ctor(int count) { }

	// RVA: 0x11ACCF8
	int get_Count() { }

	// RVA: 0x11ACD00
	bool get_Item(int index) { }

	// RVA: 0x11ACDB0
	void Clear() { }

	// RVA: 0x11ACE08
	void Set(int index) { }

	// RVA: 0x11ACD58
	bool Get(int index) { }

	// RVA: 0x11ACF24
	int NextSet(int startFrom) { }

	// RVA: 0x11ACFC4
	void And(BitSet other) { }

	// RVA: 0x11AD0F4
	void Or(BitSet other) { }

	// RVA: 0x11AD1A4
	int GetHashCode() { }

	// RVA: 0x11AD1E0
	bool Equals(object obj) { }

	// RVA: 0x11AD354
	BitSet Clone() { }

	// RVA: 0x11AD454
	bool get_IsEmpty() { }

	// RVA: 0x11AD510
	bool Intersects(BitSet other) { }

	// RVA: 0x11ACCF0
	int Subscript(int bitIndex) { }

	// RVA: 0x11ACE70
	void EnsureLength(int nRequiredLength) { }

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

	// RVA: 0x11AD5EC
	void .ctor(string ns, XmlSchema originalSchema) { }

	// RVA: 0x11AD684
	int GetHashCode() { }

	// RVA: 0x11AD714
	bool Equals(object obj) { }

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

	// RVA: 0x11AD820
	ConstraintRole get_Role() { }

	// RVA: 0x11AD828
	Asttree get_Selector() { }

	// RVA: 0x11AD830
	Asttree[] get_Fields() { }

	// RVA: 0x11AD838
	void .ctor() { }

	// RVA: 0x11AD8CC
	void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0x11ADE48
	void .cctor() { }

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

	// RVA: 0x11ADF28
	int get_TableDim() { }

	// RVA: 0x11ADF30
	void .ctor(CompiledIdentityConstraint constraint) { }

}

// Namespace: System.Xml.Schema
internal class LocatedActiveAxis 
{
	// Fields
	private int column; // 0x28
	internal bool isMatched; // 0x2C
	internal KeySequence Ks; // 0x30

	// Methods

	// RVA: 0x11AE16C
	int get_Column() { }

	// RVA: 0x11AE174
	void .ctor(Asttree astfield, KeySequence ks, int column) { }

	// RVA: 0x11AE1BC
	void Reactivate(KeySequence ks) { }

}

// Namespace: System.Xml.Schema
internal class SelectorActiveAxis 
{
	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Methods

	// RVA: 0x11AE1D4
	int get_lastDepth() { }

	// RVA: 0x11AE0D4
	void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0x11AE288
	bool EndElement(string localname, string URN) { }

	// RVA: 0x11AE2DC
	int PushKS(int errline, int errcol) { }

	// RVA: 0x11AE7B8
	KeySequence PopKS() { }

}

// Namespace: System.Xml.Schema
internal class KSStruct 
{
	// Fields
	public int depth; // 0x10
	public KeySequence ks; // 0x18
	public LocatedActiveAxis[] fields; // 0x20

	// Methods

	// RVA: 0x11AE728
	void .ctor(KeySequence ks, int dim) { }

}

// Namespace: 
private class DecimalStruct 
{
	// Fields
	private bool isDecimal; // 0x10
	private Decimal[] dvalue; // 0x18

	// Methods

	// RVA: 0x11AF318
	bool get_IsDecimal() { }

	// RVA: 0x11AF320
	void set_IsDecimal(bool value) { }

	// RVA: 0x11AF328
	Decimal[] get_Dvalue() { }

	// RVA: 0x11AEE98
	void .ctor() { }

	// RVA: 0x11AEE24
	void .ctor(int dim) { }

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

	// RVA: 0x11AE85C
	int get_Dim() { }

	// RVA: 0x11AE864
	bool get_IsList() { }

	// RVA: 0x11AE86C
	bool get_IsDecimal() { }

	// RVA: 0x11AE88C
	Decimal[] get_Dvalue() { }

	// RVA: 0x11AE8AC
	object get_Value() { }

	// RVA: 0x11AE8B4
	XmlSchemaDatatype get_Type() { }

	// RVA: 0x11AE8BC
	void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x11AEA5C
	string ToString() { }

	// RVA: 0x11AEA64
	void SetDecimal() { }

	// RVA: 0x11AEF08
	bool ListDValueEquals(TypedObject other) { }

	// RVA: 0x11AF03C
	bool Equals(TypedObject other) { }

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

	// RVA: 0x11AE690
	void .ctor(int dim, int line, int col) { }

	// RVA: 0x11AF330
	int get_PosLine() { }

	// RVA: 0x11AF338
	int get_PosCol() { }

	// RVA: 0x11AF340
	object get_Item(int index) { }

	// RVA: 0x11AF374
	void set_Item(int index, object value) { }

	// RVA: 0x11AF474
	bool IsQualified() { }

	// RVA: 0x11AF4FC
	int GetHashCode() { }

	// RVA: 0x11AF864
	bool Equals(object other) { }

	// RVA: 0x11AF960
	string ToString() { }

}

// Namespace: System.Xml.Schema
internal class UpaException 
{
	// Fields
	private object particle1; // 0x90
	private object particle2; // 0x98

	// Methods

	// RVA: 0x11AFA98
	void .ctor(object particle1, object particle2) { }

	// RVA: 0x11AFB2C
	object get_Particle1() { }

	// RVA: 0x11AFB34
	object get_Particle2() { }

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

	// RVA: 0x11AFB3C
	void .ctor() { }

	// RVA: 0x11AFBF4
	int get_Count() { }

	// RVA: 0x11AFC00
	bool get_IsUpaEnforced() { }

	// RVA: 0x11AFC08
	void set_IsUpaEnforced(bool value) { }

	// RVA: 0x11AFC10
	int AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x11AFD50
	void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	// RVA: 0x11B00F0
	void AddWildcard(string wildcard, object particle) { }

	// RVA: 0x11B0280
	ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0x11B0A04
	int get_Item(XmlQualifiedName name) { }

	// RVA: 0x11B0B08
	bool Exists(XmlQualifiedName name) { }

	// RVA: 0x11B0B3C
	object GetParticle(int symbol) { }

	// RVA: 0x11B0B7C
	string NameOf(int symbol) { }

}

// Namespace: System.Xml.Schema
internal struct Position 
{
	// Fields
	public int symbol; // 0x10
	public object particle; // 0x18

	// Methods

	// RVA: 0x11B1238
	void .ctor(int symbol, object particle) { }

}

// Namespace: System.Xml.Schema
internal class Positions 
{
	// Fields
	private ArrayList positions; // 0x10

	// Methods

	// RVA: 0x11B1248
	int Add(int symbol, object particle) { }

	// RVA: 0x11B12FC
	Position get_Item(int pos) { }

	// RVA: 0x11B1398
	int get_Count() { }

	// RVA: 0x11B13C0
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class SyntaxTreeNode 
{
	// Methods

	// RVA: 0x2FE49A8
	void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x2FE49A8
	void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x2FE3054
	bool get_IsNullable() { }

	// RVA: 0x11B1438
	bool get_IsRangeNode() { }

	// RVA: 0x11B1440
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class LeafNode 
{
	// Fields
	private int pos; // 0x10

	// Methods

	// RVA: 0x11B1448
	void .ctor(int pos) { }

	// RVA: 0x11B1474
	int get_Pos() { }

	// RVA: 0x11B147C
	void set_Pos(int value) { }

	// RVA: 0x11B1484
	void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11B1488
	void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11B154C
	bool get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal class NamespaceListNode 
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Methods

	// RVA: 0x11B1554
	void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0x11B15A4
	ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0x11B15C8
	void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11B1AFC
	void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11B1B3C
	bool get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal abstract class InteriorNode 
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Methods

	// RVA: 0x11B1B7C
	SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x11B1B84
	void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x11B1B8C
	SyntaxTreeNode get_RightChild() { }

	// RVA: 0x11B1B94
	void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0x11B1B9C
	void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11B1DD8
	void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11B1E4C
	void .ctor() { }

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

	// RVA: 0x11B25A4
	void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

}

// Namespace: System.Xml.Schema
internal sealed class SequenceNode 
{
	// Methods

	// RVA: 0x11B1E54
	void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11B2614
	bool get_IsNullable() { }

	// RVA: 0x11B2768
	void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11B276C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class ChoiceNode 
{
	// Methods

	// RVA: 0x11B2774
	void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11B28E8
	void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11B2A98
	bool get_IsNullable() { }

	// RVA: 0x11B2B2C
	void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x11B1AF4
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class PlusNode 
{
	// Methods

	// RVA: 0x11B2B30
	void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11B2C98
	bool get_IsNullable() { }

	// RVA: 0x11B2CBC
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class QmarkNode 
{
	// Methods

	// RVA: 0x11B2CC4
	void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11B2CE8
	bool get_IsNullable() { }

	// RVA: 0x11B2CF0
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class StarNode 
{
	// Methods

	// RVA: 0x11B2CF8
	void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x11B2E60
	bool get_IsNullable() { }

	// RVA: 0x11B2E68
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class LeafRangeNode 
{
	// Fields
	private Decimal min; // 0x18
	private Decimal max; // 0x28
	private BitSet nextIteration; // 0x38

	// Methods

	// RVA: 0x11B2E70
	void .ctor(Decimal min, Decimal max) { }

	// RVA: 0x11B2EC4
	void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0x11B2F18
	Decimal get_Max() { }

	// RVA: 0x11B2F24
	Decimal get_Min() { }

	// RVA: 0x11B2F30
	BitSet get_NextIteration() { }

	// RVA: 0x11B2F38
	void set_NextIteration(BitSet value) { }

	// RVA: 0x11B2F40
	bool get_IsRangeNode() { }

	// RVA: 0x11B2F48
	void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

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

	// RVA: 0x11B2F88
	void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x11B2FBC
	void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x11B3000
	XmlSchemaContentType get_ContentType() { }

	// RVA: 0x11B3008
	bool get_PreserveWhitespace() { }

	// RVA: 0x11B301C
	bool get_IsEmptiable() { }

	// RVA: 0x11B3024
	bool get_IsOpen() { }

	// RVA: 0x11B3048
	void set_IsOpen(bool value) { }

	// RVA: 0x11B3050
	void InitValidation(ValidationState context) { }

	// RVA: 0x11B3054
	object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x11B3088
	bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11B3090
	ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11B3098
	ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x11B30A0
	void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x11B311C
	void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x11B3350
	void .cctor() { }

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

	// RVA: 0x11B3468
	void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x11B34E4
	void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0x11B356C
	void InitValidation(ValidationState context) { }

	// RVA: 0x11B35AC
	object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x11B35EC
	bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11B362C
	void Start() { }

	// RVA: 0x11B375C
	void OpenGroup() { }

	// RVA: 0x11B3788
	void CloseGroup() { }

	// RVA: 0x11B3914
	bool Exists(XmlQualifiedName name) { }

	// RVA: 0x11B3950
	void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x11B3B78
	void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0x11B3A74
	void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0x11B3C24
	void AddChoice() { }

	// RVA: 0x11B3D1C
	void AddSequence() { }

	// RVA: 0x11B3E14
	void AddStar() { }

	// RVA: 0x11B401C
	void AddPlus() { }

	// RVA: 0x11B4084
	void AddQMark() { }

	// RVA: 0x11B40EC
	void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0x11B3E7C
	void Closure(InteriorNode node) { }

	// RVA: 0x11B425C
	ContentValidator Finish(bool useDFA) { }

	// RVA: 0x11B49F4
	BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0x11B5314
	void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0x11B5018
	BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0x11B5570
	void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0x11B5FDC
	void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0x11B561C
	Int32[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

}

// Namespace: System.Xml.Schema
internal sealed class DfaContentValidator 
{
	// Fields
	private Int32[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x11B5F28
	void .ctor(Int32[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x11B629C
	void InitValidation(ValidationState context) { }

	// RVA: 0x11B6304
	object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x11B6468
	bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11B6484
	ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11B6684
	ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

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

	// RVA: 0x11B6888
	void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x11B6984
	void InitValidation(ValidationState context) { }

	// RVA: 0x11B6A5C
	object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x11B6C14
	bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11B6C60
	ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11B6E5C
	ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

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

	// RVA: 0x11B6FE4
	void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0x11B70F4
	void InitValidation(ValidationState context) { }

	// RVA: 0x11B72D4
	object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x11B7BBC
	bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11B7BD8
	ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11B7E80
	ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

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

	// RVA: 0x11B80B8
	void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0x11B81EC
	bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0x11B834C
	bool get_IsEmptiable() { }

	// RVA: 0x11B836C
	void InitValidation(ValidationState context) { }

	// RVA: 0x11B8410
	object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x11B8584
	bool CompleteValidation(ValidationState context) { }

	// RVA: 0x11B85E8
	ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x11B89FC
	ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

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

	// RVA: 0x11B8EC8
	void .ctor(XmlSchemaSimpleType st, object value) { }

	// RVA: 0x11B8F18
	XmlSchemaSimpleType get_XmlType() { }

	// RVA: 0x11B8F20
	object get_TypedValue() { }

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

	// RVA: 0x11B8F28
	void .ctor() { }

}

// Namespace: 
private class SchemaDatatypeMap 
{
	// Fields
	private string name; // 0x10
	private DatatypeImplementation type; // 0x18
	private int parentIndex; // 0x20

	// Methods

	// RVA: 0x11C1E6C
	void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0x11C1EBC
	void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x11C49E0
	DatatypeImplementation op_Explicit(SchemaDatatypeMap sdm) { }

	// RVA: 0x11C49FC
	string get_Name() { }

	// RVA: 0x11C4A04
	int get_ParentIndex() { }

	// RVA: 0x11C4A0C
	int CompareTo(object obj) { }

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

	// RVA: 0x11B8F30
	void .cctor() { }

	// RVA: 0x11C2810
	XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x11C288C
	XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x11C2908
	DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x11C29A8
	DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x11C2A48
	DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x11C2B20
	DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x11C2BF8
	XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x11C2CE0
	void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x11C1F18
	void CreateBuiltinTypes() { }

	// RVA: 0x11C2F34
	XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x11C2FD4
	XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x11C30B8
	XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x11C32F4
	XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x11C3530
	XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x11C35AC
	XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x11C3724
	XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x11C384C
	XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x11BF734
	XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x11C39C8
	DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x11C3B74
	void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x11C3B78
	bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x11C3E58
	bool IsEqual(object o1, object o2) { }

	// RVA: 0x11C3E80
	bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x11C3F70
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C3F78
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C3FF4
	XmlValueConverter get_ValueConverter() { }

	// RVA: 0x11C4054
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11C405C
	Type get_ValueType() { }

	// RVA: 0x11C40FC
	XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x11C4104
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C410C
	RestrictionFacets get_Restriction() { }

	// RVA: 0x11C4114
	bool get_HasLexicalFacets() { }

	// RVA: 0x11C413C
	bool get_HasValueFacets() { }

	// RVA: 0x11C4164
	DatatypeImplementation get_Base() { }

	// RVA: 0x2FE360C
	Type get_ListValueType() { }

	// RVA: 0x2FE32D4
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C416C
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C4174
	object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11C43CC
	object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x11C4534
	Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x11C435C
	string GetTypeName() { }

	// RVA: 0x11C4974
	int Compare(Byte[] value1, Byte[] value2) { }

	// RVA: 0x11C49D8
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_List 
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Methods

	// RVA: 0x11C4A88
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C38D4
	void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x11C4DDC
	int Compare(object value1, object value2) { }

	// RVA: 0x11C50D0
	Type get_ValueType() { }

	// RVA: 0x11C50E0
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11C5104
	Type get_ListValueType() { }

	// RVA: 0x11C512C
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C51A8
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C51CC
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C51D4
	Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x11C5AD0
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

// Namespace: System.Xml.Schema
internal class Datatype_union 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

	// Methods

	// RVA: 0x11C5FEC
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C3A94
	void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x11C5FF8
	int Compare(object value1, object value2) { }

	// RVA: 0x11C6100
	Type get_ValueType() { }

	// RVA: 0x11C617C
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C6184
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C6200
	Type get_ListValueType() { }

	// RVA: 0x11C627C
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C6284
	XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x11C3858
	bool HasAtomicMembers() { }

	// RVA: 0x11C3DB0
	bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x11C628C
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C64AC
	Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C6998
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anySimpleType 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11C6A74
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C6AF0
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C6B6C
	Type get_ValueType() { }

	// RVA: 0x11C6BE8
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C6BF0
	Type get_ListValueType() { }

	// RVA: 0x11C6C6C
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11C6C74
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C6C7C
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C6C84
	int Compare(object value1, object value2) { }

	// RVA: 0x11C6CE4
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BE754
	void .ctor() { }

	// RVA: 0x11C6D20
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyAtomicType 
{
	// Methods

	// RVA: 0x11C6DFC
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C6E78
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C6E80
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C1A3C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_untypedAtomicType 
{
	// Methods

	// RVA: 0x11C6E88
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C6F04
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C6F0C
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C1C54
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_string 
{
	// Methods

	// RVA: 0x11C6F14
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C6F20
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C6F28
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C6FA4
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C6FAC
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11C6FB4
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C6FBC
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C0CE4
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_boolean 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11C70C8
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C70D4
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C7150
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C7158
	Type get_ValueType() { }

	// RVA: 0x11C71D4
	Type get_ListValueType() { }

	// RVA: 0x11C7250
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C7258
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C7260
	int Compare(object value1, object value2) { }

	// RVA: 0x11C730C
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BE99C
	void .ctor() { }

	// RVA: 0x11C745C
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_float 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11C7538
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C7544
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C75C0
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C75C8
	Type get_ValueType() { }

	// RVA: 0x11C7644
	Type get_ListValueType() { }

	// RVA: 0x11C76C0
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C76C8
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C76D0
	int Compare(object value1, object value2) { }

	// RVA: 0x11C776C
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BFB30
	void .ctor() { }

	// RVA: 0x11C78F4
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_double 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11C79D0
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C79DC
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C7A58
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C7A60
	Type get_ValueType() { }

	// RVA: 0x11C7ADC
	Type get_ListValueType() { }

	// RVA: 0x11C7B58
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C7B60
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C7B68
	int Compare(object value1, object value2) { }

	// RVA: 0x11C7C04
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BF35C
	void .ctor() { }

	// RVA: 0x11C7D8C
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_decimal 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x11C7E68
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C7E74
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C7EF0
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C7EF8
	Type get_ValueType() { }

	// RVA: 0x11C7F74
	Type get_ListValueType() { }

	// RVA: 0x11C7FF0
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C7FF8
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C8000
	int Compare(object value1, object value2) { }

	// RVA: 0x11C80D8
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BF27C
	void .ctor() { }

	// RVA: 0x11C8278
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_duration 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11C8474
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C8480
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C84FC
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C8504
	Type get_ValueType() { }

	// RVA: 0x11C8580
	Type get_ListValueType() { }

	// RVA: 0x11C85FC
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C8604
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C860C
	int Compare(object value1, object value2) { }

	// RVA: 0x11C86B8
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BF574
	void .ctor() { }

	// RVA: 0x11C88C8
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonthDuration 
{
	// Methods

	// RVA: 0x11C89A4
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C8BB8
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C1D34
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dayTimeDuration 
{
	// Methods

	// RVA: 0x11C8BC0
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C8DD4
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C1B1C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeBase 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

	// Methods

	// RVA: 0x11C8DDC
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C8DE8
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C8E64
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C8E6C
	void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x11C8F44
	Type get_ValueType() { }

	// RVA: 0x11C8FC0
	Type get_ListValueType() { }

	// RVA: 0x11C903C
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C9044
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C904C
	int Compare(object value1, object value2) { }

	// RVA: 0x11C91CC
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C9554
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeNoTimeZone 
{
	// Methods

	// RVA: 0x11BEEEC
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeTimeZone 
{
	// Methods

	// RVA: 0x11BF01C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTime 
{
	// Methods

	// RVA: 0x11BEDBC
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeNoTimeZone 
{
	// Methods

	// RVA: 0x11C0EF4
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeTimeZone 
{
	// Methods

	// RVA: 0x11C1024
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_time 
{
	// Methods

	// RVA: 0x11C9630
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C0DC4
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_date 
{
	// Methods

	// RVA: 0x11C9638
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11BEC8C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonth 
{
	// Methods

	// RVA: 0x11C9640
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C174C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_year 
{
	// Methods

	// RVA: 0x11C9648
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C161C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_monthDay 
{
	// Methods

	// RVA: 0x11C9650
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C03B4
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_day 
{
	// Methods

	// RVA: 0x11C9658
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11BF14C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_month 
{
	// Methods

	// RVA: 0x11C9660
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C0284
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_hexBinary 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11C9668
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C9674
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C96F0
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C96F8
	Type get_ValueType() { }

	// RVA: 0x11C9774
	Type get_ListValueType() { }

	// RVA: 0x11C97F0
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C97F8
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C9800
	int Compare(object value1, object value2) { }

	// RVA: 0x11C9914
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BFD48
	void .ctor() { }

	// RVA: 0x11C9B08
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_base64Binary 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11C9BE4
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11C9BF0
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11C9C6C
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C9C74
	Type get_ValueType() { }

	// RVA: 0x11C9CF0
	Type get_ListValueType() { }

	// RVA: 0x11C9D6C
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C9D74
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11C9D7C
	int Compare(object value1, object value2) { }

	// RVA: 0x11C9E90
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BE8BC
	void .ctor() { }

	// RVA: 0x11CA080
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyURI 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11CA15C
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11CA168
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CA1E4
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CA1EC
	Type get_ValueType() { }

	// RVA: 0x11CA268
	bool get_HasValueFacets() { }

	// RVA: 0x11CA270
	Type get_ListValueType() { }

	// RVA: 0x11CA2EC
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11CA2F4
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11CA2FC
	int Compare(object value1, object value2) { }

	// RVA: 0x11CA3C8
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BE7DC
	void .ctor() { }

	// RVA: 0x11CA7EC
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QName 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11CA8C8
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11CA8D4
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CA950
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CA958
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11CA960
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11CA968
	Type get_ValueType() { }

	// RVA: 0x11CA9E4
	Type get_ListValueType() { }

	// RVA: 0x11CAA60
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11CAA68
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C0A4C
	void .ctor() { }

	// RVA: 0x11CACC8
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedString 
{
	// Methods

	// RVA: 0x11CADA4
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CADAC
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11CADB4
	bool get_HasValueFacets() { }

	// RVA: 0x11C080C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedStringV1Compat 
{
	// Methods

	// RVA: 0x11CADBC
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CADC4
	bool get_HasValueFacets() { }

	// RVA: 0x11C187C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_token 
{
	// Methods

	// RVA: 0x11CADCC
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CADD4
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11C1154
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_tokenV1Compat 
{
	// Methods

	// RVA: 0x11CADDC
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C195C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_language 
{
	// Methods

	// RVA: 0x11CADE4
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C01A0
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NMTOKEN 
{
	// Methods

	// RVA: 0x11CADEC
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CADF4
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11C0724
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_Name 
{
	// Methods

	// RVA: 0x11CADFC
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C04E4
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NCName 
{
	// Methods

	// RVA: 0x11CAE04
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CAE0C
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C05C4
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ID 
{
	// Methods

	// RVA: 0x11CAF40
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CAF48
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11BFE28
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_IDREF 
{
	// Methods

	// RVA: 0x11CAF50
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CAF58
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11BFF08
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENTITY 
{
	// Methods

	// RVA: 0x11CAF60
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CAF68
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11BF654
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NOTATION 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11CAF70
	XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x11CAF7C
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CAFF8
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CB000
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11CB008
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11CB010
	Type get_ValueType() { }

	// RVA: 0x11CB08C
	Type get_ListValueType() { }

	// RVA: 0x11CB108
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11CB110
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11CB370
	void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x11C08EC
	void .ctor() { }

	// RVA: 0x11CB610
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_integer 
{
	// Methods

	// RVA: 0x11CB6EC
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CB6F4
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C0068
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonPositiveInteger 
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x11CB870
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CB8EC
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CB8F4
	bool get_HasValueFacets() { }

	// RVA: 0x11C0808
	void .ctor() { }

	// RVA: 0x11CB8FC
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_negativeInteger 
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x11CBA24
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CBAA0
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C06A4
	void .ctor() { }

	// RVA: 0x11CBAA8
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_long 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x11CBBD0
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CBC4C
	bool get_HasValueFacets() { }

	// RVA: 0x11CBC54
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CBC5C
	int Compare(object value1, object value2) { }

	// RVA: 0x11CBCF8
	Type get_ValueType() { }

	// RVA: 0x11CBD74
	Type get_ListValueType() { }

	// RVA: 0x11CBDF0
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C0280
	void .ctor() { }

	// RVA: 0x11CBF78
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_int 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x11CC108
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CC184
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CC18C
	int Compare(object value1, object value2) { }

	// RVA: 0x11CC228
	Type get_ValueType() { }

	// RVA: 0x11CC2A4
	Type get_ListValueType() { }

	// RVA: 0x11CC320
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BFFE8
	void .ctor() { }

	// RVA: 0x11CC4A8
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_short 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x11CC638
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CC6B4
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CC6BC
	int Compare(object value1, object value2) { }

	// RVA: 0x11CC758
	Type get_ValueType() { }

	// RVA: 0x11CC7D4
	Type get_ListValueType() { }

	// RVA: 0x11CC850
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C0C0C
	void .ctor() { }

	// RVA: 0x11CC9D8
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_byte 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x11CCB68
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CCBE4
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CCBEC
	int Compare(object value1, object value2) { }

	// RVA: 0x11CCC88
	Type get_ValueType() { }

	// RVA: 0x11CCD04
	Type get_ListValueType() { }

	// RVA: 0x11CCD80
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BEA7C
	void .ctor() { }

	// RVA: 0x11CCF08
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonNegativeInteger 
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x11CD098
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CD114
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CD11C
	bool get_HasValueFacets() { }

	// RVA: 0x11C0804
	void .ctor() { }

	// RVA: 0x11CD124
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedLong 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x11CD24C
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CD2C8
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CD2D0
	int Compare(object value1, object value2) { }

	// RVA: 0x11CD36C
	Type get_ValueType() { }

	// RVA: 0x11CD3E8
	Type get_ListValueType() { }

	// RVA: 0x11CD464
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C138C
	void .ctor() { }

	// RVA: 0x11CD630
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedInt 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x11CD7D8
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CD854
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CD85C
	int Compare(object value1, object value2) { }

	// RVA: 0x11CD8F8
	Type get_ValueType() { }

	// RVA: 0x11CD974
	Type get_ListValueType() { }

	// RVA: 0x11CD9F0
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C12B4
	void .ctor() { }

	// RVA: 0x11CDB78
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedShort 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x11CDD20
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CDD9C
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CDDA4
	int Compare(object value1, object value2) { }

	// RVA: 0x11CDE40
	Type get_ValueType() { }

	// RVA: 0x11CDEBC
	Type get_ListValueType() { }

	// RVA: 0x11CDF38
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C140C
	void .ctor() { }

	// RVA: 0x11CE0C0
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedByte 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Methods

	// RVA: 0x11CE268
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CE2E4
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11CE2EC
	int Compare(object value1, object value2) { }

	// RVA: 0x11CE388
	Type get_ValueType() { }

	// RVA: 0x11CE404
	Type get_ListValueType() { }

	// RVA: 0x11CE480
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C1234
	void .ctor() { }

	// RVA: 0x11CE608
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_positiveInteger 
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x11CE7B0
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x11CE82C
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x11C09CC
	void .ctor() { }

	// RVA: 0x11CE834
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_doubleXdr 
{
	// Methods

	// RVA: 0x11CE95C
	object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11BF43C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_floatXdr 
{
	// Methods

	// RVA: 0x11CEB54
	object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11BFC10
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QNameXdr 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11CED4C
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11CED54
	object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11CEFE4
	Type get_ValueType() { }

	// RVA: 0x11CF060
	Type get_ListValueType() { }

	// RVA: 0x11C0B2C
	void .ctor() { }

	// RVA: 0x11CF0DC
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENUMERATION 
{
	// Methods

	// RVA: 0x11CF1B8
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x11BF918
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_char 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11CF1C0
	Type get_ValueType() { }

	// RVA: 0x11CF23C
	Type get_ListValueType() { }

	// RVA: 0x11CF2B8
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11CF2C0
	int Compare(object value1, object value2) { }

	// RVA: 0x11CF36C
	object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11CF548
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BEBAC
	void .ctor() { }

	// RVA: 0x11CF648
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_fixed 
{
	// Methods

	// RVA: 0x11CF724
	object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11CFCB0
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11BF9F8
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_uuid 
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x11CFE44
	Type get_ValueType() { }

	// RVA: 0x11CFEC0
	Type get_ListValueType() { }

	// RVA: 0x11CFF3C
	RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x11CFF44
	int Compare(object value1, object value2) { }

	// RVA: 0x11CFFE4
	object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x11D01C0
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x11C153C
	void .ctor() { }

	// RVA: 0x11D02C0
	void .cctor() { }

}

// Namespace: 
private class NamespaceManager 
{
	// Methods

	// RVA: 0x11D2B60
	string LookupNamespace(string prefix) { }

	// RVA: 0x11D2B58
	void .ctor() { }

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

	// RVA: 0x11D039C
	void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x11D0444
	void Init() { }

	// RVA: 0x11D06FC
	void Validate() { }

	// RVA: 0x11D0A18
	bool MeetsStandAloneConstraint() { }

	// RVA: 0x11D0AC4
	void ValidatePIComment() { }

	// RVA: 0x11D08F8
	void ValidateElement() { }

	// RVA: 0x11D0F10
	void ValidateChildElement() { }

	// RVA: 0x11D1180
	void ValidateStartElement() { }

	// RVA: 0x11D1B94
	void ValidateEndStartElement() { }

	// RVA: 0x11D1054
	void ProcessElement() { }

	// RVA: 0x11D1D78
	void CompleteValidation() { }

	// RVA: 0x11D0D50
	void ValidateEndElement() { }

	// RVA: 0x11D1FB8
	bool get_PreserveWhitespace() { }

	// RVA: 0x11D1FF4
	void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x11D15E0
	void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x11D2280
	void AddID(string name, object node) { }

	// RVA: 0x11D2320
	object FindId(string name) { }

	// RVA: 0x11D0B94
	bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x11D233C
	SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x11D1E8C
	void CheckForwardRefs() { }

	// RVA: 0x11D05B4
	void Push(XmlQualifiedName elementName) { }

	// RVA: 0x11D1DD0
	bool Pop() { }

	// RVA: 0x11D23E8
	void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x11D26F8
	void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x11D2AD0
	void .cctor() { }

}

// Namespace: 
private struct Map 
{
	// Fields
	internal Char match; // 0x10
	internal string replacement; // 0x18

	// Methods

	// RVA: 0x11D7860
	void .ctor(Char m, string r) { }

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

	// RVA: 0x11D32B8
	void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x11D35FC
	void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11D3A2C
	void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11D3E20
	void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11D4214
	void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x11D444C
	void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x11D4650
	void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11D4FFC
	void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11D529C
	void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11D4ABC
	void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11D4D5C
	void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11D553C
	void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11D59C0
	void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x11D5D48
	void FinishFacetCompile() { }

	// RVA: 0x11D68D8
	void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x11D60EC
	void CompileFacetCombinations() { }

	// RVA: 0x11D6FF0
	void CopyFacetsFromBaseType() { }

	// RVA: 0x11D671C
	object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x11D6D70
	string Preprocess(string pattern) { }

	// RVA: 0x11D6610
	void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x11D66A0
	void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x11D686C
	void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x11D7508
	void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x11D7548
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class FacetsChecker 
{
	// Methods

	// RVA: 0x11D2B68
	Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E28
	Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E30
	Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E38
	Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E40
	Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E48
	Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E50
	Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E58
	Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E60
	Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E68
	Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E70
	Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E78
	Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E80
	Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2BB0
	void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2CB8
	Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x11D2E88
	bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D2E90
	RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x11D64CC
	Decimal Power(int x, int y) { }

	// RVA: 0x11D6608
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Numeric10FacetsChecker 
{
	// Fields
	private static readonly Char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0x11C8428
	void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0x11D7870
	Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D78EC
	Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D8060
	Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D80F8
	Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D8190
	Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D8228
	bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D7F18
	bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x11CFA00
	Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0x11D82AC
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Numeric2FacetsChecker 
{
	// Methods

	// RVA: 0x11D8350
	Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D83BC
	Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D8830
	Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D8840
	bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D874C
	bool MatchEnumeration(Double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x11BE73C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DurationFacetsChecker 
{
	// Methods

	// RVA: 0x11D8968
	Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D8A84
	Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D8F2C
	bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D8E14
	bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x11BE74C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DateTimeFacetsChecker 
{
	// Methods

	// RVA: 0x11D8FB0
	Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D9020
	Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D95C8
	bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D9414
	bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11BE744
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class StringFacetsChecker 
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Methods

	// RVA: 0x11D9630
	Regex get_LanguagePattern() { }

	// RVA: 0x11D9700
	Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D976C
	Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x11CA57C
	Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0x11D9CAC
	bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D9A30
	bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x11D9774
	Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x11BE734
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class QNameFacetsChecker 
{
	// Methods

	// RVA: 0x101D6AC
	Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x101D7E0
	Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x101DB3C
	bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x101D9E8
	bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

	// RVA: 0x101DC58
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class MiscFacetsChecker 
{
	// Methods

	// RVA: 0x101DC60
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class BinaryFacetsChecker 
{
	// Methods

	// RVA: 0x101DC68
	Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x101DCFC
	Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x101E038
	bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x101DEF0
	bool MatchEnumeration(Byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x101E0D8
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class ListFacetsChecker 
{
	// Methods

	// RVA: 0x101E0E0
	Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x101E354
	bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x101E438
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class UnionFacetsChecker 
{
	// Methods

	// RVA: 0x101E440
	Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x101E54C
	bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x101E630
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public interface IXmlSchemaInfo 
{
	// Methods

	// RVA: 0x2FE32D4
	XmlSchemaValidity get_Validity() { }

	// RVA: 0x2FE3054
	bool get_IsDefault() { }

	// RVA: 0x2FE3054
	bool get_IsNil() { }

	// RVA: 0x2FE360C
	XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x2FE360C
	XmlSchemaType get_SchemaType() { }

	// RVA: 0x2FE360C
	XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x2FE360C
	XmlSchemaAttribute get_SchemaAttribute() { }

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

	// RVA: 0x101E638
	void set_Occurrence(InferenceOption value) { }

	// RVA: 0x101E640
	InferenceOption get_Occurrence() { }

	// RVA: 0x101E648
	void set_TypeInference(InferenceOption value) { }

	// RVA: 0x101E650
	void .ctor() { }

	// RVA: 0x101E790
	XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x101E808
	XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x1020DC0
	XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x102384C
	XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x101F2C4
	XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x101F8FC
	void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1024590
	XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x1023C88
	XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x1024B60
	XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x1023DC4
	void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1024AAC
	void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x10246CC
	void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x1021A10
	XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x10238EC
	XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	// RVA: 0x1025CD8
	XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x102165C
	XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x1025E34
	XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x10244E8
	void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x10262A0
	void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x1021D80
	XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	// RVA: 0x102644C
	int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	// RVA: 0x10278B0
	int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x1025FB8
	XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x1022EF0
	int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x1025B08
	void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x10279F8
	void .cctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaInferenceException 
{
	// Methods

	// RVA: 0x10284E0
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10284E8
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10284F0
	void .ctor() { }

	// RVA: 0x10261E0
	void .ctor(string res, string arg) { }

	// RVA: 0x101F28C
	void .ctor(string res, int lineNumber, int linePosition) { }

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

	// RVA: 0x10284FC
	void .ctor() { }

	// RVA: 0x1028504
	void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x10287B0
	NamespaceList Clone() { }

	// RVA: 0x10288F4
	ListType get_Type() { }

	// RVA: 0x10288FC
	string get_Excluded() { }

	// RVA: 0x1028904
	ICollection get_Enumerate() { }

	// RVA: 0x1028974
	bool Allows(string ns) { }

	// RVA: 0x1028A14
	bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1028A38
	string ToString() { }

	// RVA: 0x1028F18
	bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0x10292E4
	NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x1029840
	NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0x10299BC
	NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x1029FC4
	void RemoveNamespace(string tns) { }

}

// Namespace: System.Xml.Schema
internal class NamespaceListV1Compat 
{
	// Methods

	// RVA: 0x102A028
	void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x102A02C
	bool Allows(string ns) { }

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

	// RVA: 0x102A0A8
	void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x102A1B0
	SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0x102A214
	void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0x102AD24
	bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	// RVA: 0x102AE7C
	SchemaType FinishParsing() { }

	// RVA: 0x102AE84
	XmlSchema get_XmlSchema() { }

	// RVA: 0x102AE8C
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x102AE94
	SchemaInfo get_XdrSchema() { }

	// RVA: 0x102A64C
	bool ParseReaderNode() { }

	// RVA: 0x102AE9C
	void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0x102B0E4
	XmlElement LoadElementNode(bool root) { }

	// RVA: 0x102B748
	XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0x102B564
	XmlAttribute LoadAttributeNode() { }

	// RVA: 0x102B878
	XmlEntityReference LoadEntityReferenceInAttribute() { }

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

	// RVA: 0x102BAA0
	void .ctor(XmlSchemaRedefine external, XmlSchema schema) { }

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

	// RVA: 0x102BAF0
	void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x102BBF4
	bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0x102F3B0
	void Cleanup(XmlSchema schema) { }

	// RVA: 0x102FA9C
	void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x102FB40
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x102FB48
	void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x102FB50
	void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x102FB58
	void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x102FB60
	XmlSchema get_RootSchema() { }

	// RVA: 0x102D084
	void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0x102C298
	void LoadExternals(XmlSchema schema) { }

	// RVA: 0x102F490
	XmlSchema GetBuildInSchema() { }

	// RVA: 0x102FBD8
	void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x102FE10
	void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0x102D208
	void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0x103046C
	void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0x102E574
	void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0x10333B0
	void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0x1033314
	XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0x1030344
	void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0x1033B8C
	int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0x10334F0
	void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x10335AC
	void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1033A6C
	void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x1033708
	void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x10316C4
	void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x103445C
	void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1034198
	void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x1031850
	void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1032ADC
	void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x1035124
	void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x1034D4C
	void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x1035514
	void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1032410
	void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x10319CC
	void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x1032D68
	void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1032FB8
	void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x1035924
	void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10348D0
	void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x1030030
	void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1033EC4
	void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1034690
	void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x102FB68
	Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x102FBAC
	object GetSchemaEntity(Uri ruri) { }

	// RVA: 0x102C134
	XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x102FF5C
	void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x102FF80
	void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x1033298
	void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }

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

	// RVA: 0x1036300
	void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1036308
	void .ctor(XmlQualifiedName name) { }

	// RVA: 0x1036314
	void .ctor() { }

	// RVA: 0x103631C
	string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0x1036324
	string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x1036344
	int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x103634C
	int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0x1036354
	bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0x10363A8
	bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x10363B0
	bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0x10363C0
	string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x1036498
	object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x10364A0
	int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0x10364A8
	int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x10364B0
	int get_LinePosition() { }

	// RVA: 0x10364B8
	void set_LinePosition(int value) { }

	// RVA: 0x10364C0
	int get_LineNumber() { }

	// RVA: 0x10364C8
	void set_LineNumber(int value) { }

	// RVA: 0x10364D0
	int get_ValueLinePosition() { }

	// RVA: 0x10364D8
	void set_ValueLinePosition(int value) { }

	// RVA: 0x10364E0
	int get_ValueLineNumber() { }

	// RVA: 0x10364E8
	void set_ValueLineNumber(int value) { }

	// RVA: 0x103642C
	string get_DefaultValueExpanded() { }

	// RVA: 0x10364F0
	void set_DefaultValueExpanded(string value) { }

	// RVA: 0x1036384
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x10364F8
	void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0x103652C
	Reserve get_Reserved() { }

	// RVA: 0x1036534
	void set_Reserved(Reserve value) { }

	// RVA: 0x103653C
	bool get_DefaultValueChecked() { }

	// RVA: 0x1036544
	XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x103654C
	void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x1036554
	void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0x10367E8
	SchemaAttDef Clone() { }

	// RVA: 0x1036850
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class SchemaBuilder 
{
	// Methods

	// RVA: -1
	bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x2FE4A14
	void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x2FE3054
	bool IsContentParsed() { }

	// RVA: 0x2FE4574
	void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x2FE4574
	void ProcessCData(string value) { }

	// RVA: 0x2FE41A8
	void StartChildren() { }

	// RVA: 0x2FE41A8
	void EndChildren() { }

	// RVA: 0x10368BC
	void .ctor() { }

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

	// RVA: 0x10368C4
	void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0x1036990
	bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0x1036A00
	void Prepare() { }

	// RVA: 0x1036E8C
	void Cleanup() { }

	// RVA: 0x103B340
	void Cleanup(XmlSchema schema) { }

	// RVA: 0x1037D98
	void Compile() { }

	// RVA: 0x1039D18
	void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x103B2FC
	void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x103AD58
	void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x103ADA8
	void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x103B140
	void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x103B15C
	void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x104078C
	void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x103AD20
	void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x1040888
	void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x103BB94
	void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0x10405BC
	void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x103C028
	void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x103D69C
	void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1040EB0
	XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10413A0
	void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x103C910
	void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10414C8
	void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1041760
	void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1041BD8
	void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x10420A0
	void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1040454
	void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x1043A18
	XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0x1040A00
	XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0x1044F74
	XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0x10450DC
	XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0x1045674
	XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0x1045B34
	XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0x1046038
	XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0x10447D4
	bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10465A8
	bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x10466D0
	bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x1046724
	bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x1046770
	bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x1046A10
	bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1046E04
	bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1047128
	bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x1047590
	bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1048300
	void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1047838
	bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1048118
	bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x1048200
	int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x10464DC
	bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x1047920
	void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x104872C
	void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1043BA0
	XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x103C134
	void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1042444
	void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x1048810
	XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1048754
	XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x103EF74
	void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x103FC70
	void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x103E050
	void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x1043C3C
	ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x10488CC
	void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x1048FBC
	void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x104037C
	void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x1040D00
	XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x10446EC
	XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x1044550
	XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

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

	// RVA: 0x104922C
	void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1049234
	bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0x10494A0
	void Cleanup(XmlSchema schema) { }

	// RVA: 0x104C748
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10496D8
	void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0x104C954
	void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x104A3D4
	void Preprocess(XmlSchema schema, string targetNamespace, Compositor compositor) { }

	// RVA: 0x104CC88
	void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0x104FDD0
	int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0x104F738
	void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x104F7E0
	void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x104FCB0
	void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x104F94C
	void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x104DE5C
	void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1050604
	void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10503B4
	void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x104DFE8
	void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x104EFE8
	void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x105101C
	void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x1050CAC
	void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x105139C
	void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x104E9E8
	void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x104E0F4
	void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x104F274
	void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x104F454
	void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x1051728
	void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x105096C
	void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x104A15C
	void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x10500E0
	void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x10507C8
	void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x104CB74
	void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x104CB98
	void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x104C750
	Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x104C81C
	Stream GetSchemaEntity(Uri ruri) { }

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

	// RVA: 0x1052090
	void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x105214C
	void .ctor() { }

	// RVA: 0x10521C8
	XmlQualifiedName get_Name() { }

	// RVA: 0x10521D0
	void set_Name(XmlQualifiedName value) { }

	// RVA: 0x10521D8
	string get_Prefix() { }

	// RVA: 0x1052244
	void set_Prefix(string value) { }

	// RVA: 0x105224C
	bool get_IsDeclaredInExternal() { }

	// RVA: 0x1052254
	void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x105225C
	Use get_Presence() { }

	// RVA: 0x1052264
	void set_Presence(Use value) { }

	// RVA: 0x105226C
	Int64 get_MaxLength() { }

	// RVA: 0x1052274
	void set_MaxLength(Int64 value) { }

	// RVA: 0x105227C
	Int64 get_MinLength() { }

	// RVA: 0x1052284
	void set_MinLength(Int64 value) { }

	// RVA: 0x105228C
	XmlSchemaType get_SchemaType() { }

	// RVA: 0x1052294
	void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x105229C
	XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x10522A4
	void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0x10522AC
	void AddValue(string value) { }

	// RVA: 0x1052364
	System.Collections.Generic.List<System.String> get_Values() { }

	// RVA: 0x105236C
	void set_Values(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x1052374
	string get_DefaultValueRaw() { }

	// RVA: 0x10523E0
	void set_DefaultValueRaw(string value) { }

	// RVA: 0x10523E8
	object get_DefaultValueTyped() { }

	// RVA: 0x10523F0
	void set_DefaultValueTyped(object value) { }

	// RVA: 0x10523F8
	bool CheckEnumeration(object pVal) { }

	// RVA: 0x10524C0
	bool CheckValue(object pVal) { }

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

	// RVA: 0x1052518
	void .ctor() { }

	// RVA: 0x1052648
	void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0x10527D0
	void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x10528C4
	SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0x10529C4
	bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x10529CC
	IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x1052A8C
	System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0x1052A94
	bool get_IsIdDeclared() { }

	// RVA: 0x1052A9C
	void set_IsIdDeclared(bool value) { }

	// RVA: 0x1052AA4
	bool get_HasNonCDataAttribute() { }

	// RVA: 0x1052AAC
	void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0x1052AB4
	SchemaElementDecl Clone() { }

	// RVA: 0x1052B1C
	bool get_IsAbstract() { }

	// RVA: 0x1052B24
	void set_IsAbstract(bool value) { }

	// RVA: 0x1052B2C
	bool get_IsNillable() { }

	// RVA: 0x1052B34
	void set_IsNillable(bool value) { }

	// RVA: 0x1052B3C
	XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x1052B44
	void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1052B4C
	bool get_IsNotationDeclared() { }

	// RVA: 0x1052B54
	void set_IsNotationDeclared(bool value) { }

	// RVA: 0x1052B5C
	bool get_HasDefaultAttribute() { }

	// RVA: 0x1052B6C
	bool get_HasRequiredAttribute() { }

	// RVA: 0x1052B74
	ContentValidator get_ContentValidator() { }

	// RVA: 0x1052B7C
	void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x1052B84
	XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1052B8C
	void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1052B94
	CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x1052B9C
	void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x1052BA4
	XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1052BAC
	void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x1052BB4
	void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0x1052CE0
	SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x1052D64
	System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x1052D6C
	System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttDefs() { }

	// RVA: 0x1052D74
	System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0x1052D7C
	void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0x105314C
	void .cctor() { }

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

	// RVA: 0x10531B4
	void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0x1053258
	string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0x1053278
	bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0x1053280
	bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x1053288
	bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x10532B0
	bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0x10532B8
	string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0x1053390
	string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x1053468
	string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x1053470
	string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x1053478
	string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x1053480
	int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x1053488
	int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0x1053490
	bool IsPredefinedEntity(string n) { }

	// RVA: 0x105359C
	XmlQualifiedName get_Name() { }

	// RVA: 0x10535A4
	string get_Url() { }

	// RVA: 0x10535AC
	void set_Url(string value) { }

	// RVA: 0x10535DC
	string get_Pubid() { }

	// RVA: 0x10535E4
	void set_Pubid(string value) { }

	// RVA: 0x10535EC
	bool get_IsExternal() { }

	// RVA: 0x10535F4
	void set_IsExternal(bool value) { }

	// RVA: 0x10535FC
	bool get_DeclaredInExternal() { }

	// RVA: 0x1053604
	void set_DeclaredInExternal(bool value) { }

	// RVA: 0x105360C
	XmlQualifiedName get_NData() { }

	// RVA: 0x1053614
	void set_NData(XmlQualifiedName value) { }

	// RVA: 0x105361C
	string get_Text() { }

	// RVA: 0x1053624
	void set_Text(string value) { }

	// RVA: 0x1053650
	int get_Line() { }

	// RVA: 0x1053658
	void set_Line(int value) { }

	// RVA: 0x1053660
	int get_Pos() { }

	// RVA: 0x1053668
	void set_Pos(int value) { }

	// RVA: 0x1053324
	string get_BaseURI() { }

	// RVA: 0x1053670
	void set_BaseURI(string value) { }

	// RVA: 0x1053678
	bool get_ParsingInProgress() { }

	// RVA: 0x1053680
	void set_ParsingInProgress(bool value) { }

	// RVA: 0x10533FC
	string get_DeclaredURI() { }

	// RVA: 0x1053688
	void set_DeclaredURI(string value) { }

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

	// RVA: 0x1053690
	void .ctor() { }

	// RVA: 0x1053884
	XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x105388C
	void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x1053894
	void set_InternalDtdSubset(string value) { }

	// RVA: 0x105389C
	System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x10538A4
	System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0x10538AC
	System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_GeneralEntities() { }

	// RVA: 0x1053948
	System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x10539E4
	SchemaType get_SchemaType() { }

	// RVA: 0x10539EC
	void set_SchemaType(SchemaType value) { }

	// RVA: 0x10539F4
	System.Collections.Generic.Dictionary<System.String,System.Boolean> get_TargetNamespaces() { }

	// RVA: 0x10539FC
	System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x1053A04
	System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0x1053A0C
	System.Collections.Generic.Dictionary<System.String,System.Xml.Schema.SchemaNotation> get_Notations() { }

	// RVA: 0x1053AA8
	int get_ErrorCount() { }

	// RVA: 0x1053AB0
	void set_ErrorCount(int value) { }

	// RVA: 0x1053AB8
	SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0x1053B3C
	SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0x1053BC0
	XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0x1053C64
	bool HasSchema(string ns) { }

	// RVA: 0x1053CC8
	bool Contains(string ns) { }

	// RVA: 0x1053D2C
	SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0x1053EC0
	SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	// RVA: 0x1054134
	SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	// RVA: 0x1054248
	void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0x1055228
	void Finish() { }

	// RVA: 0x1055584
	bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x105558C
	bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x1055594
	IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x1055668
	IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x1055738
	XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x1055740
	string System.Xml.IDtdInfo.get_InternalDtdSubset() { }

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

	// RVA: 0x1055748
	void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1058540
	void CreateTokenToQNameTable() { }

	// RVA: 0x105A470
	SchemaType SchemaTypeFromRoot(string localName, string ns) { }

	// RVA: 0x105A520
	bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x105A570
	bool IsXDRRoot(string localName, string ns) { }

}

// Namespace: System.Xml.Schema
internal class SchemaNamespaceManager 
{
	// Fields
	private XmlSchemaObject node; // 0x50

	// Methods

	// RVA: 0x105A5C0
	void .ctor(XmlSchemaObject node) { }

	// RVA: 0x105A5F4
	string LookupNamespace(string prefix) { }

	// RVA: 0x105A744
	string LookupPrefix(string ns) { }

}

// Namespace: System.Xml.Schema
internal sealed class SchemaNotation 
{
	// Fields
	private XmlQualifiedName name; // 0x10
	private string systemLiteral; // 0x18
	private string pubid; // 0x20

	// Methods

	// RVA: 0x105AB4C
	void .ctor(XmlQualifiedName name) { }

	// RVA: 0x105AB80
	XmlQualifiedName get_Name() { }

	// RVA: 0x105AB88
	string get_SystemLiteral() { }

	// RVA: 0x105AB90
	void set_SystemLiteral(string value) { }

	// RVA: 0x105AB98
	string get_Pubid() { }

	// RVA: 0x105ABA0
	void set_Pubid(string value) { }

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

	// RVA: 0x105ABA8
	void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x105ADF8
	bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0x105DFA4
	void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0x105FFE4
	void UpdateSForSSimpleTypes() { }

	// RVA: 0x105CE64
	void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x106016C
	void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0x105AE9C
	bool Compile() { }

	// RVA: 0x105F984
	void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x105FA0C
	void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x105FA68
	void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x105FF2C
	void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x105F7D4
	void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x106570C
	void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x105F9C0
	void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x1065800
	void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10646E4
	void ProcessSubstitutionGroups() { }

	// RVA: 0x10659AC
	void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x1065594
	void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0x1065684
	void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0x1060280
	void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1061940
	void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1066E80
	XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1067370
	void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x1060D4C
	void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1067498
	void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1067730
	void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1067BE4
	void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x10680B8
	void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1064F44
	void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x1066330
	void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1069A90
	XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1065F70
	XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0x106C8A8
	XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0x106B624
	XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0x106BBB0
	XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0x106BE7C
	XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0x106C3AC
	XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0x106A850
	XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0x106AAA4
	bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x106CC44
	bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x106CE84
	bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x106D03C
	bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x106D148
	bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x106D610
	bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0x106E6FC
	bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0x106DEE0
	bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x106E294
	bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x106E8F8
	bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x106ECCC
	bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x106F794
	bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x106F87C
	int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x106CB78
	bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x106EF70
	void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x106F97C
	void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1069C10
	XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1060388
	void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1068454
	void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x106641C
	void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0x106FB1C
	bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0x106FA60
	XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x106F9A4
	XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1063414
	void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x106FC48
	void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0x1063E68
	void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x1062330
	void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x1069CAC
	ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x106FE38
	bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x107050C
	void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x10661A0
	void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0x106456C
	void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x1066D80
	XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x106A774
	XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x106A5E4
	XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0x106CAF4
	void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0x106EDB4
	bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }

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

	// RVA: 0x107077C
	void .ctor(XmlSchemaException ex) { }

	// RVA: 0x10707FC
	void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x1070888
	XmlSeverityType get_Severity() { }

	// RVA: 0x1070890
	XmlSchemaException get_Exception() { }

}

// Namespace: System.Xml.Schema
public sealed class ValidationEventHandler 
{
	// Methods

	// RVA: 0x1070898
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x10709BC
	internal void Invoke(object sender, ValidationEventArgs e) { }

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

	// RVA: 0x10709D0
	void .ctor() { }

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

	// RVA: 0x1075DBC
	void .ctor() { }

	// RVA: 0x1076314
	void Reset() { }

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

	// RVA: 0x107B7EC
	void Copy(GroupContent from, GroupContent to) { }

	// RVA: 0x10722DC
	GroupContent Copy(GroupContent other) { }

	// RVA: 0x1070D00
	void .ctor() { }

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

	// RVA: 0x1070CF0
	void .ctor() { }

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

	// RVA: 0x1070CF8
	void .ctor() { }

}

// Namespace: 
private sealed class XdrBuildFunction 
{
	// Methods

	// RVA: 0x107B308
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x107B818
	internal void Invoke(XdrBuilder builder, object obj, string prefix) { }

}

// Namespace: 
private sealed class XdrInitFunction 
{
	// Methods

	// RVA: 0x107B5C8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x107B82C
	internal void Invoke(XdrBuilder builder, object obj) { }

}

// Namespace: 
private sealed class XdrBeginChildFunction 
{
	// Methods

	// RVA: 0x107B684
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x107B840
	internal void Invoke(XdrBuilder builder) { }

}

// Namespace: 
private sealed class XdrEndChildFunction 
{
	// Methods

	// RVA: 0x107B738
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x107B854
	internal void Invoke(XdrBuilder builder) { }

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

	// RVA: 0x107B3C4
	void .ctor(Token a, XmlTokenizedType ttype, XdrBuildFunction build) { }

	// RVA: 0x107B46C
	void .ctor(Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuildFunction build) { }

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

	// RVA: 0x107B518
	void .ctor(Token n, int[] states, XdrAttributeEntry[] attributes, XdrInitFunction init, XdrBeginChildFunction begin, XdrEndChildFunction end, bool fText) { }

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

	// RVA: 0x1070A40
	void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x1070D08
	bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x1071400
	void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x1071EC4
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1071890
	bool LoadSchema(string uri) { }

	// RVA: 0x10717CC
	bool IsXdrSchema(string uri) { }

	// RVA: 0x107200C
	bool IsContentParsed() { }

	// RVA: 0x1072014
	void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x1072070
	void ProcessCData(string value) { }

	// RVA: 0x10720FC
	void StartChildren() { }

	// RVA: 0x1072138
	void EndChildren() { }

	// RVA: 0x1071200
	void Push() { }

	// RVA: 0x1072180
	void Pop() { }

	// RVA: 0x1072228
	void PushGroupInfo() { }

	// RVA: 0x107235C
	void PopGroupInfo() { }

	// RVA: 0x1072404
	void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0x1072470
	void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1072518
	void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x107251C
	void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0x1072624
	void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0x1072BE4
	void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0x1072D14
	void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1072EF0
	void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x107315C
	void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10732E8
	void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10734EC
	void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1073784
	void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1073884
	void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1073A78
	void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1073C6C
	void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0x1073F84
	void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0x107450C
	void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0x107461C
	void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1074878
	void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1074A40
	void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1074A64
	void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1074D00
	void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1074E00
	void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1074E7C
	void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1074EF8
	void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0x1074FB8
	void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0x10754CC
	void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0x107559C
	void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10757EC
	void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10759D0
	void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1075BC4
	void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0x1075D30
	void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0x1075DE4
	void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1075ED0
	void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1075F84
	void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1075FA8
	void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0x10762F4
	void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0x1076418
	void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0x1076514
	void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1076648
	void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10766D8
	void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1076768
	void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0x1076968
	void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x1076A84
	void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0x1076B98
	void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x1076C4C
	void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0x1071048
	bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x1071258
	bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x1071D74
	bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0x1073398
	int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0x1075730
	void AddOrder() { }

	// RVA: 0x10748F8
	bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0x107586C
	UInt32 ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x1075A50
	UInt32 ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x1075D00
	void HandleMinMax(ParticleContentValidator pContent, UInt32 cMin, UInt32 cMax) { }

	// RVA: 0x1073900
	void ParseDtMaxLength(ref UInt32 cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x1073AF4
	void ParseDtMinLength(ref UInt32 cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x1074450
	void CompareMinMaxLength(UInt32 cMin, UInt32 cMax, XdrBuilder builder) { }

	// RVA: 0x1076D84
	bool ParseInteger(string str, ref UInt32 n) { }

	// RVA: 0x1072AF8
	void XDR_CheckAttributeDefault(DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0x107547C
	void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0x1072F98
	int GetContent(XmlQualifiedName qname) { }

	// RVA: 0x1073204
	bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0x1074B28
	XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0x1075390
	void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0x10717C0
	bool IsGlobal(int flags) { }

	// RVA: 0x1071ECC
	void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1073698
	void SendValidationEvent(string code) { }

	// RVA: 0x107131C
	void SendValidationEvent(string code, string msg) { }

	// RVA: 0x1077404
	void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1077644
	void .cctor() { }

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

	// RVA: 0x107B868
	void .ctor(BaseValidator validator) { }

	// RVA: 0x107BAF4
	void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x107B8F4
	void Init() { }

	// RVA: 0x107BD30
	void Validate() { }

	// RVA: 0x107C0C8
	void ValidateElement() { }

	// RVA: 0x107C44C
	void ValidateChildElement() { }

	// RVA: 0x107BE04
	bool get_IsInlineSchemaStarted() { }

	// RVA: 0x107BE14
	void ProcessInlineSchema() { }

	// RVA: 0x107C590
	void ProcessElement() { }

	// RVA: 0x107C270
	void ValidateEndElement() { }

	// RVA: 0x107C650
	SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x107C9C4
	void ValidateStartElement() { }

	// RVA: 0x107CE40
	void ValidateEndStartElement() { }

	// RVA: 0x107DBE8
	void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x107D8EC
	void LoadSchema(string uri) { }

	// RVA: 0x107E2B4
	bool get_HasSchema() { }

	// RVA: 0x107E2DC
	bool get_PreserveWhitespace() { }

	// RVA: 0x107E318
	void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x107E634
	void CompleteValidation() { }

	// RVA: 0x107D1F4
	void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1076DC0
	void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x107E594
	void AddID(string name, object node) { }

	// RVA: 0x107E928
	object FindId(string name) { }

	// RVA: 0x107BB98
	void Push(XmlQualifiedName elementName) { }

	// RVA: 0x107D81C
	void Pop() { }

	// RVA: 0x107E704
	void CheckForwardRefs() { }

	// RVA: 0x107DB0C
	XmlQualifiedName QualifiedName(string name, string ns) { }

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

	// RVA: 0x107F044
	void .ctor(string prefix, string ns) { }

	// RVA: 0x107FE4C
	string LookupNamespace(string prefix) { }

	// RVA: 0x107FE8C
	string LookupPrefix(string namespaceName) { }

	// RVA: 0x107FEC4
	System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

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

	// RVA: 0x107E944
	void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x107E9E0
	void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x107EA7C
	void .ctor(XmlSchemaType xmlType, Double value) { }

	// RVA: 0x107EB18
	void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x107EBB4
	void .ctor(XmlSchemaType xmlType, Int64 value) { }

	// RVA: 0x107EC50
	void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x107ED10
	void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x107F094
	void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x107F154
	void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x107F3A8
	object System.ICloneable.Clone() { }

	// RVA: 0x107F3AC
	XmlSchemaType get_XmlType() { }

	// RVA: 0x107F3B4
	Type get_ValueType() { }

	// RVA: 0x107F3E0
	object get_TypedValue() { }

	// RVA: 0x107F5D0
	bool get_ValueAsBoolean() { }

	// RVA: 0x107F6C8
	DateTime get_ValueAsDateTime() { }

	// RVA: 0x107F7D4
	Double get_ValueAsDouble() { }

	// RVA: 0x107F8E0
	int get_ValueAsInt() { }

	// RVA: 0x107F9E0
	Int64 get_ValueAsLong() { }

	// RVA: 0x107FAEC
	object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x107FD20
	string get_Value() { }

	// RVA: 0x107FE40
	string ToString() { }

	// RVA: 0x107EF20
	string GetPrefixFromQName(string value) { }

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

	// RVA: 0x107FF6C
	void .ctor() { }

	// RVA: 0x1080154
	XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x1080320
	bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x1080534
	void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x10805E4
	XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0x10805EC
	void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x10805F4
	XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x10805FC
	void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1080604
	XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x108060C
	void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1080614
	XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x108061C
	void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x1080624
	string get_TargetNamespace() { }

	// RVA: 0x108062C
	void set_TargetNamespace(string value) { }

	// RVA: 0x1080634
	string get_Version() { }

	// RVA: 0x108063C
	void set_Version(string value) { }

	// RVA: 0x1080644
	XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x108064C
	XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1080654
	bool get_IsCompiledBySet() { }

	// RVA: 0x108065C
	void set_IsCompiledBySet(bool value) { }

	// RVA: 0x1080664
	bool get_IsPreprocessed() { }

	// RVA: 0x108066C
	void set_IsPreprocessed(bool value) { }

	// RVA: 0x1080674
	bool get_IsRedefined() { }

	// RVA: 0x108067C
	void set_IsRedefined(bool value) { }

	// RVA: 0x1080684
	XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x108070C
	XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x1080794
	XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x108081C
	XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x10808A4
	string get_Id() { }

	// RVA: 0x10808AC
	void set_Id(string value) { }

	// RVA: 0x10808B4
	XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x10808BC
	XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x10808C4
	XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0x10808CC
	Uri get_BaseUri() { }

	// RVA: 0x10808D4
	void set_BaseUri(Uri value) { }

	// RVA: 0x10808DC
	int get_SchemaId() { }

	// RVA: 0x1080968
	bool get_IsChameleon() { }

	// RVA: 0x1080970
	void set_IsChameleon(bool value) { }

	// RVA: 0x1080978
	Hashtable get_Ids() { }

	// RVA: 0x1080980
	XmlDocument get_Document() { }

	// RVA: 0x1080A08
	int get_ErrorCount() { }

	// RVA: 0x1080A10
	void set_ErrorCount(int value) { }

	// RVA: 0x1080A18
	XmlSchema Clone() { }

	// RVA: 0x1080BD4
	XmlSchema DeepClone() { }

	// RVA: 0x1081D4C
	string get_IdAttribute() { }

	// RVA: 0x1081D54
	void set_IdAttribute(string value) { }

	// RVA: 0x1081D5C
	void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x1081D64
	void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1081D6C
	void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x1081E34
	ArrayList get_ImportedSchemas() { }

	// RVA: 0x1081EBC
	ArrayList get_ImportedNamespaces() { }

	// RVA: 0x1081F44
	void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x1082140
	void .cctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAll 
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x1082190
	XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1082198
	bool get_IsEmpty() { }

	// RVA: 0x10821EC
	void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10821F4
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotated 
{
	// Fields
	private string id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Methods

	// RVA: 0x1082350
	string get_Id() { }

	// RVA: 0x1082358
	void set_Id(string value) { }

	// RVA: 0x1082360
	XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x1082368
	void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x1082370
	XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x1082378
	void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x1082380
	string get_IdAttribute() { }

	// RVA: 0x1082388
	void set_IdAttribute(string value) { }

	// RVA: 0x1082390
	void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1082398
	void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x10823A0
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotation 
{
	// Fields
	private string id; // 0x38
	private XmlSchemaObjectCollection items; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Methods

	// RVA: 0x10823A8
	string get_Id() { }

	// RVA: 0x10823B0
	void set_Id(string value) { }

	// RVA: 0x10823B8
	XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x10823C0
	string get_IdAttribute() { }

	// RVA: 0x10823C8
	void set_IdAttribute(string value) { }

	// RVA: 0x10823D0
	void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x10823D8
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAny 
{
	// Fields
	private string ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Methods

	// RVA: 0x1082450
	string get_Namespace() { }

	// RVA: 0x1082458
	void set_Namespace(string value) { }

	// RVA: 0x1082460
	void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x1082468
	NamespaceList get_NamespaceList() { }

	// RVA: 0x1082470
	string get_ResolvedNamespace() { }

	// RVA: 0x10824CC
	XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x10824E0
	string get_NameString() { }

	// RVA: 0x10829D0
	void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x1082A5C
	void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x1082B08
	bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1082B34
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAnyAttribute 
{
	// Fields
	private string ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Methods

	// RVA: 0x1082BBC
	void set_Namespace(string value) { }

	// RVA: 0x1082BC4
	XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0x1082BCC
	void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x1082BD4
	NamespaceList get_NamespaceList() { }

	// RVA: 0x1082BDC
	XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x1082BF0
	void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x1082C7C
	void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x1082D28
	bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1082D54
	bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x1082D7C
	XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x1082E5C
	XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x1082E54
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAppInfo 
{
	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Methods

	// RVA: 0x1082F34
	void set_Source(string value) { }

	// RVA: 0x1082F3C
	XmlNode[] get_Markup() { }

	// RVA: 0x1082F44
	void set_Markup(XmlNode[] value) { }

	// RVA: 0x1082F4C
	void .ctor() { }

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

	// RVA: 0x1082F54
	string get_DefaultValue() { }

	// RVA: 0x1082F5C
	void set_DefaultValue(string value) { }

	// RVA: 0x1082F64
	string get_FixedValue() { }

	// RVA: 0x1082F6C
	void set_FixedValue(string value) { }

	// RVA: 0x1082F74
	XmlSchemaForm get_Form() { }

	// RVA: 0x1082F7C
	void set_Form(XmlSchemaForm value) { }

	// RVA: 0x1082F84
	string get_Name() { }

	// RVA: 0x1082F8C
	void set_Name(string value) { }

	// RVA: 0x1082F94
	XmlQualifiedName get_RefName() { }

	// RVA: 0x1082F9C
	void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1083074
	XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x108307C
	void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x1083154
	XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x108315C
	void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x1083164
	XmlSchemaUse get_Use() { }

	// RVA: 0x108316C
	void set_Use(XmlSchemaUse value) { }

	// RVA: 0x1083174
	XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x108317C
	XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x1083184
	XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x108319C
	void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10831A4
	void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x10831AC
	SchemaAttDef get_AttDef() { }

	// RVA: 0x10831B4
	void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x10831BC
	string get_NameAttribute() { }

	// RVA: 0x10831C4
	void set_NameAttribute(string value) { }

	// RVA: 0x10831CC
	XmlSchemaObject Clone() { }

	// RVA: 0x10832D4
	void .ctor() { }

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

	// RVA: 0x1083380
	string get_Name() { }

	// RVA: 0x1083388
	void set_Name(string value) { }

	// RVA: 0x1083390
	XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1083398
	XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10833A0
	void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10833A8
	XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x10833B0
	XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x1083438
	XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x1083440
	void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1083448
	XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x1083450
	XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x1083458
	void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x1083460
	int get_SelfReferenceCount() { }

	// RVA: 0x1083468
	void set_SelfReferenceCount(int value) { }

	// RVA: 0x1083470
	string get_NameAttribute() { }

	// RVA: 0x1083478
	void set_NameAttribute(string value) { }

	// RVA: 0x1083480
	void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1083488
	XmlSchemaObject Clone() { }

	// RVA: 0x10839E8
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroupRef 
{
	// Fields
	private XmlQualifiedName refName; // 0x50

	// Methods

	// RVA: 0x1083A9C
	XmlQualifiedName get_RefName() { }

	// RVA: 0x1083AA4
	void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1083B7C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaChoice 
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x1083BF8
	XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1083C00
	bool get_IsEmpty() { }

	// RVA: 0x1083C08
	void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1083C10
	void .ctor() { }

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

	// RVA: 0x1083CE4
	void .ctor(XmlNameTable nametable) { }

	// RVA: 0x1083E34
	int get_Count() { }

	// RVA: 0x1083E5C
	XmlNameTable get_NameTable() { }

	// RVA: 0x1083E64
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1083E6C
	XmlSchema get_Item(string ns) { }

	// RVA: 0x1083F28
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x108400C
	XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x10840A0
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1084470
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1084478
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x108447C
	int System.Collections.ICollection.get_Count() { }

	// RVA: 0x107E1F8
	SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x10844A4
	SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x107C648
	XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x1084564
	XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x10846EC
	void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x1084850
	ValidationEventHandler get_EventHandler() { }

	// RVA: 0x1084858
	void set_EventHandler(ValidationEventHandler value) { }

}

// Namespace: System.Xml.Schema
internal sealed class XmlSchemaCollectionNode 
{
	// Fields
	private string namespaceUri; // 0x10
	private SchemaInfo schemaInfo; // 0x18
	private XmlSchema schema; // 0x20

	// Methods

	// RVA: 0x1084860
	void set_NamespaceURI(string value) { }

	// RVA: 0x1084868
	SchemaInfo get_SchemaInfo() { }

	// RVA: 0x1084870
	void set_SchemaInfo(SchemaInfo value) { }

	// RVA: 0x1084878
	XmlSchema get_Schema() { }

	// RVA: 0x1084880
	void set_Schema(XmlSchema value) { }

	// RVA: 0x10846E4
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCollectionEnumerator 
{
	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x1083FBC
	void .ctor(Hashtable collection) { }

	// RVA: 0x1084888
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1084940
	bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x10843BC
	bool MoveNext() { }

	// RVA: 0x10849F4
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x10842C8
	XmlSchema get_Current() { }

	// RVA: 0x10849F8
	XmlSchemaCollectionNode get_CurrentNode() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCompilationSettings 
{
	// Fields
	private bool enableUpaCheck; // 0x10

	// Methods

	// RVA: 0x1084AE0
	void .ctor() { }

	// RVA: 0x1084B0C
	bool get_EnableUpaCheck() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContent 
{
	// Fields
	private XmlSchemaContent content; // 0x50
	private bool isMixed; // 0x58
	private bool hasMixedAttribute; // 0x59

	// Methods

	// RVA: 0x1084B14
	bool get_IsMixed() { }

	// RVA: 0x1084B1C
	void set_IsMixed(bool value) { }

	// RVA: 0x1084B2C
	XmlSchemaContent get_Content() { }

	// RVA: 0x1084B34
	void set_Content(XmlSchemaContent value) { }

	// RVA: 0x1084B3C
	bool get_HasMixedAttribute() { }

	// RVA: 0x1084B44
	void .ctor() { }

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

	// RVA: 0x1084B54
	XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1084B5C
	void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x1084C34
	XmlSchemaParticle get_Particle() { }

	// RVA: 0x1084C3C
	void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x1084C44
	XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1084C4C
	XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1084C54
	void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1084C5C
	void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1084C64
	void .ctor() { }

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

	// RVA: 0x1084D20
	XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1084D28
	void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x1084E00
	XmlSchemaParticle get_Particle() { }

	// RVA: 0x1084E08
	void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x1084E10
	XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1084E18
	XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1084E20
	void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1084E28
	void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1084E30
	void .ctor() { }

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

	// RVA: 0x1084EE4
	void .cctor() { }

	// RVA: 0x10851D4
	XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x1085740
	void .ctor() { }

	// RVA: 0x1085854
	XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x10858D0
	XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x10857C4
	ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x108594C
	bool get_IsAbstract() { }

	// RVA: 0x1085958
	void set_IsAbstract(bool value) { }

	// RVA: 0x1085978
	XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x1085980
	void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1085988
	bool get_IsMixed() { }

	// RVA: 0x1085994
	void set_IsMixed(bool value) { }

	// RVA: 0x10859B4
	XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x10859BC
	void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x10859C4
	XmlSchemaParticle get_Particle() { }

	// RVA: 0x10859CC
	void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x10859D4
	XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1085A5C
	XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1085A64
	void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1085A6C
	XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1085A74
	XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0x1085A7C
	XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1085A84
	XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x1085B0C
	XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x1085B14
	XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x1085B9C
	void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x1085BA4
	void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1085BAC
	void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1085BB4
	void set_HasWildCard(bool value) { }

	// RVA: 0x1085BC8
	void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1085BD0
	bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x1086138
	XmlSchemaObject Clone() { }

	// RVA: 0x108108C
	XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x108668C
	void ClearCompiledState() { }

	// RVA: 0x1083724
	XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x10867C4
	XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x10863C8
	XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x1086A40
	XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x1086140
	bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x10835B8
	bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContent 
{
	// Methods

	// RVA: 0x1084D18
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContentModel 
{
	// Methods

	// RVA: 0x2FE360C
	XmlSchemaContent get_Content() { }

	// RVA: 0x2FE4574
	void set_Content(XmlSchemaContent value) { }

	// RVA: 0x1084B4C
	void .ctor() { }

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

	// RVA: 0x2FE360C
	Type get_ValueType() { }

	// RVA: 0x2FE32D4
	XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x2FE3810
	object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1086A6C
	XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x1086A74
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x1086A7C
	bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x2FE3054
	bool get_HasLexicalFacets() { }

	// RVA: 0x2FE3054
	bool get_HasValueFacets() { }

	// RVA: 0x2FE360C
	XmlValueConverter get_ValueConverter() { }

	// RVA: 0x2FE360C
	RestrictionFacets get_Restriction() { }

	// RVA: -1
	int Compare(object value1, object value2) { }

	// RVA: -1
	object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x2FE3884
	Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x2FE3884
	Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x2FE360C
	FacetsChecker get_FacetsChecker() { }

	// RVA: 0x2FE32D4
	XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x2FE3810
	XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x2FE36BC
	XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x2FE47D4
	void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: -1
	bool IsEqual(object o1, object o2) { }

	// RVA: 0x2FE3174
	bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x1086A84
	string get_TypeCodeString() { }

	// RVA: 0x1086BBC
	string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x1087328
	string ConcatenatedToString(object value) { }

	// RVA: 0x1075308
	XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x1087A38
	XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x10736FC
	XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x1087AC0
	XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x1070E84
	string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x1087B2C
	void .ctor() { }

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

	// RVA: 0x1087B34
	void set_Source(string value) { }

	// RVA: 0x1087B3C
	void set_Language(string value) { }

	// RVA: 0x1087C54
	void set_Markup(XmlNode[] value) { }

	// RVA: 0x1087C5C
	void .ctor() { }

	// RVA: 0x1087C64
	void .cctor() { }

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

	// RVA: 0x1087D54
	bool get_IsAbstract() { }

	// RVA: 0x1087D5C
	void set_IsAbstract(bool value) { }

	// RVA: 0x1087D6C
	XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x1087D74
	void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1087D7C
	string get_DefaultValue() { }

	// RVA: 0x1087D84
	void set_DefaultValue(string value) { }

	// RVA: 0x1087D8C
	XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x1087D94
	void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1087D9C
	string get_FixedValue() { }

	// RVA: 0x1087DA4
	void set_FixedValue(string value) { }

	// RVA: 0x1087DAC
	XmlSchemaForm get_Form() { }

	// RVA: 0x1087DB4
	void set_Form(XmlSchemaForm value) { }

	// RVA: 0x1087DBC
	string get_Name() { }

	// RVA: 0x1087DC4
	void set_Name(string value) { }

	// RVA: 0x1087DCC
	bool get_IsNillable() { }

	// RVA: 0x1087DD4
	void set_IsNillable(bool value) { }

	// RVA: 0x1087DE4
	bool get_HasNillableAttribute() { }

	// RVA: 0x1087DEC
	bool get_HasAbstractAttribute() { }

	// RVA: 0x1087DF4
	XmlQualifiedName get_RefName() { }

	// RVA: 0x1087DFC
	void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1087ED4
	XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x1087EDC
	void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x1087FB4
	XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x1087FBC
	void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x1088094
	XmlSchemaType get_SchemaType() { }

	// RVA: 0x108809C
	void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10880A4
	XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0x108812C
	XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1088134
	XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x108813C
	XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1088144
	XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x108814C
	void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1088154
	void SetElementType(XmlSchemaType value) { }

	// RVA: 0x108815C
	void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1088164
	void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x108816C
	bool get_HasConstraints() { }

	// RVA: 0x1088194
	bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x108819C
	void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x10881A4
	SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x10881AC
	void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x10881B4
	string get_NameAttribute() { }

	// RVA: 0x10881BC
	void set_NameAttribute(string value) { }

	// RVA: 0x10881C4
	string get_NameString() { }

	// RVA: 0x10881E8
	XmlSchemaObject Clone() { }

	// RVA: 0x1081830
	XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10881F0
	void .ctor() { }

}

// Namespace: System.Xml.Schema
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

	// RVA: 0x10882F8
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10887D0
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1088944
	void .ctor() { }

	// RVA: 0x1088958
	void .ctor(string message) { }

	// RVA: 0x1088AB4
	void .ctor(string message, Exception innerException) { }

	// RVA: 0x1088968
	void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1088B7C
	void .ctor(string res, string[] args) { }

	// RVA: 0x107E82C
	void .ctor(string res, string arg) { }

	// RVA: 0x1077534
	void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1088C14
	void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1077358
	void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1088CBC
	void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x1088D84
	void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x1088CC8
	void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x1088AC0
	void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x1088704
	string CreateMessage(string res, string[] args) { }

	// RVA: 0x1088E28
	string get_GetRes() { }

	// RVA: 0x1088E30
	string[] get_Args() { }

	// RVA: 0x1088E38
	string get_SourceUri() { }

	// RVA: 0x1088E40
	int get_LineNumber() { }

	// RVA: 0x1088E48
	int get_LinePosition() { }

	// RVA: 0x1088E50
	XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x107DBAC
	void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1088E58
	void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x1088E60
	void SetSource(XmlSchemaObject source) { }

	// RVA: 0x1088EA8
	string get_Message() { }

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

	// RVA: 0x1088EC0
	string get_SchemaLocation() { }

	// RVA: 0x1088EC8
	void set_SchemaLocation(string value) { }

	// RVA: 0x1088ED0
	XmlSchema get_Schema() { }

	// RVA: 0x1088ED8
	void set_Schema(XmlSchema value) { }

	// RVA: 0x1088EE0
	string get_Id() { }

	// RVA: 0x1088EE8
	void set_Id(string value) { }

	// RVA: 0x1088EF0
	Uri get_BaseUri() { }

	// RVA: 0x1088EF8
	void set_BaseUri(Uri value) { }

	// RVA: 0x1088F00
	string get_IdAttribute() { }

	// RVA: 0x1088F08
	void set_IdAttribute(string value) { }

	// RVA: 0x1088F10
	void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1088F18
	Compositor get_Compositor() { }

	// RVA: 0x1088F20
	void set_Compositor(Compositor value) { }

	// RVA: 0x1088F28
	void .ctor() { }

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

	// RVA: 0x1088F30
	string get_Value() { }

	// RVA: 0x1088F38
	void set_Value(string value) { }

	// RVA: 0x1088F40
	bool get_IsFixed() { }

	// RVA: 0x1088F48
	void set_IsFixed(bool value) { }

	// RVA: 0x1089004
	FacetType get_FacetType() { }

	// RVA: 0x108900C
	void set_FacetType(FacetType value) { }

	// RVA: 0x1089014
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaNumericFacet 
{
	// Methods

	// RVA: 0x108901C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaLengthFacet 
{
	// Methods

	// RVA: 0x1089024
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinLengthFacet 
{
	// Methods

	// RVA: 0x1089050
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxLengthFacet 
{
	// Methods

	// RVA: 0x108907C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaPatternFacet 
{
	// Methods

	// RVA: 0x10890A8
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaEnumerationFacet 
{
	// Methods

	// RVA: 0x10890D4
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinExclusiveFacet 
{
	// Methods

	// RVA: 0x1089100
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinInclusiveFacet 
{
	// Methods

	// RVA: 0x108912C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxExclusiveFacet 
{
	// Methods

	// RVA: 0x1089158
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxInclusiveFacet 
{
	// Methods

	// RVA: 0x1089184
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaTotalDigitsFacet 
{
	// Methods

	// RVA: 0x10891B0
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaFractionDigitsFacet 
{
	// Methods

	// RVA: 0x10891DC
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaWhiteSpaceFacet 
{
	// Methods

	// RVA: 0x1089208
	void .ctor() { }

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

	// RVA: 0x1089234
	string get_Name() { }

	// RVA: 0x108923C
	void set_Name(string value) { }

	// RVA: 0x1089244
	XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x108924C
	void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x1089254
	XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x108925C
	XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x1089264
	void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x108926C
	XmlSchemaGroup get_Redefined() { }

	// RVA: 0x1089274
	void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x108927C
	int get_SelfReferenceCount() { }

	// RVA: 0x1089284
	void set_SelfReferenceCount(int value) { }

	// RVA: 0x108928C
	string get_NameAttribute() { }

	// RVA: 0x1089294
	void set_NameAttribute(string value) { }

	// RVA: 0x108929C
	void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x10892A4
	XmlSchemaObject Clone() { }

	// RVA: 0x1081A6C
	XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x10892AC
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaGroupBase 
{
	// Methods

	// RVA: 0x2FE360C
	XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x2FE4574
	void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x10822C8
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaGroupRef 
{
	// Fields
	private XmlQualifiedName refName; // 0x78
	private XmlSchemaGroupBase particle; // 0x80
	private XmlSchemaGroup refined; // 0x88

	// Methods

	// RVA: 0x1089328
	XmlQualifiedName get_RefName() { }

	// RVA: 0x1086968
	void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1089330
	XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x1089338
	void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x1089340
	XmlSchemaGroup get_Redefined() { }

	// RVA: 0x1089348
	void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1089350
	void .ctor() { }

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

	// RVA: 0x1089408
	string get_Name() { }

	// RVA: 0x1089410
	void set_Name(string value) { }

	// RVA: 0x1089418
	XmlSchemaXPath get_Selector() { }

	// RVA: 0x1089420
	void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x1089428
	XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x1089430
	XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1089438
	void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1089440
	CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x1089448
	void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x1089450
	string get_NameAttribute() { }

	// RVA: 0x1089458
	void set_NameAttribute(string value) { }

	// RVA: 0x1089460
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaXPath 
{
	// Fields
	private string xpath; // 0x50

	// Methods

	// RVA: 0x1089514
	string get_XPath() { }

	// RVA: 0x108951C
	void set_XPath(string value) { }

	// RVA: 0x1089524
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaUnique 
{
	// Methods

	// RVA: 0x108952C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaKey 
{
	// Methods

	// RVA: 0x1089530
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaKeyref 
{
	// Fields
	private XmlQualifiedName refer; // 0x78

	// Methods

	// RVA: 0x1089534
	XmlQualifiedName get_Refer() { }

	// RVA: 0x108953C
	void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x1089614
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaImport 
{
	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Methods

	// RVA: 0x108968C
	void .ctor() { }

	// RVA: 0x10896B8
	string get_Namespace() { }

	// RVA: 0x10896C0
	void set_Namespace(string value) { }

	// RVA: 0x10896C8
	void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaInclude 
{
	// Fields
	private XmlSchemaAnnotation annotation; // 0x68

	// Methods

	// RVA: 0x10896D0
	void .ctor() { }

	// RVA: 0x10896FC
	void AddAnnotation(XmlSchemaAnnotation annotation) { }

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

	// RVA: 0x1089704
	void .ctor() { }

	// RVA: 0x10897E0
	void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x1089854
	XmlSchemaValidity get_Validity() { }

	// RVA: 0x108985C
	void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x1089864
	bool get_IsDefault() { }

	// RVA: 0x108986C
	void set_IsDefault(bool value) { }

	// RVA: 0x1089874
	bool get_IsNil() { }

	// RVA: 0x108987C
	void set_IsNil(bool value) { }

	// RVA: 0x1089884
	XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x108988C
	void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x1089894
	XmlSchemaType get_SchemaType() { }

	// RVA: 0x108989C
	void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10898EC
	XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x10898F4
	void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x1089938
	XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1089940
	void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x1089984
	XmlSchemaContentType get_ContentType() { }

	// RVA: 0x108998C
	XmlSchemaType get_XmlType() { }

	// RVA: 0x10899A8
	bool get_HasDefaultValue() { }

	// RVA: 0x10899E4
	bool get_IsUnionType() { }

	// RVA: 0x1089778
	void Clear() { }

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

	// RVA: 0x1089A24
	string get_Name() { }

	// RVA: 0x1089A2C
	void set_Name(string value) { }

	// RVA: 0x1089A34
	string get_Public() { }

	// RVA: 0x1089A3C
	void set_Public(string value) { }

	// RVA: 0x1089A44
	string get_System() { }

	// RVA: 0x1089A4C
	void set_System(string value) { }

	// RVA: 0x1089A54
	XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1089A5C
	void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1089A64
	string get_NameAttribute() { }

	// RVA: 0x1089A6C
	void set_NameAttribute(string value) { }

	// RVA: 0x1089A74
	void .ctor() { }

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

	// RVA: 0x1089AF0
	int get_LineNumber() { }

	// RVA: 0x1089AF8
	void set_LineNumber(int value) { }

	// RVA: 0x1089B00
	int get_LinePosition() { }

	// RVA: 0x1089B08
	void set_LinePosition(int value) { }

	// RVA: 0x1089B10
	string get_SourceUri() { }

	// RVA: 0x1089B18
	void set_SourceUri(string value) { }

	// RVA: 0x1089B20
	XmlSchemaObject get_Parent() { }

	// RVA: 0x1089B28
	void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x1080B4C
	XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x1089B30
	void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x1089B38
	void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x1089B3C
	void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x1089B40
	void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x1089B44
	string get_IdAttribute() { }

	// RVA: 0x1089B4C
	void set_IdAttribute(string value) { }

	// RVA: 0x1089B50
	void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1089B54
	void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x1089B58
	string get_NameAttribute() { }

	// RVA: 0x1089B60
	void set_NameAttribute(string value) { }

	// RVA: 0x1089B64
	bool get_IsProcessing() { }

	// RVA: 0x1089B6C
	void set_IsProcessing(bool value) { }

	// RVA: 0x1089B74
	XmlSchemaObject Clone() { }

	// RVA: 0x108014C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectCollection 
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Methods

	// RVA: 0x1080144
	void .ctor() { }

	// RVA: 0x1089BF8
	XmlSchemaObject get_Item(int index) { }

	// RVA: 0x1089D18
	void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x1089DE4
	XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x1081C88
	int Add(XmlSchemaObject item) { }

	// RVA: 0x1089E64
	void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x1089F30
	void Remove(XmlSchemaObject item) { }

	// RVA: 0x1089FF4
	void OnInsert(int index, object item) { }

	// RVA: 0x108A010
	void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x108A070
	void OnClear() { }

	// RVA: 0x108A08C
	void OnRemove(int index, object item) { }

	// RVA: 0x1086738
	XmlSchemaObjectCollection Clone() { }

	// RVA: 0x108A0A8
	void Add(XmlSchemaObjectCollection collToAdd) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectEnumerator 
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x108A0D8
	void .ctor(IEnumerator enumerator) { }

	// RVA: 0x108A10C
	bool MoveNext() { }

	// RVA: 0x108A1C0
	XmlSchemaObject get_Current() { }

	// RVA: 0x108A2C4
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x108A37C
	bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x108A430
	object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x108A69C
	void .ctor(XmlQualifiedName name, XmlSchemaObject value) { }

}

// Namespace: 
internal class ValuesCollection 
{
	// Fields
	private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private int size; // 0x18

	// Methods

	// RVA: 0x108AEB4
	void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x108B004
	int get_Count() { }

	// RVA: 0x108B00C
	object get_SyncRoot() { }

	// RVA: 0x108B0C4
	bool get_IsSynchronized() { }

	// RVA: 0x108B17C
	void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x108B2CC
	IEnumerator GetEnumerator() { }

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

	// RVA: 0x108B358
	void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

	// RVA: 0x108B3AC
	object get_Current() { }

	// RVA: 0x108B58C
	bool MoveNext() { }

	// RVA: 0x108B67C
	void Reset() { }

}

// Namespace: 
internal class XSODictionaryEnumerator 
{
	// Methods

	// RVA: 0x108AFB0
	void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

	// RVA: 0x108B6B8
	DictionaryEntry get_Entry() { }

	// RVA: 0x108B808
	object get_Key() { }

	// RVA: 0x108B93C
	object get_Value() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectTable 
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaObject> table; // 0x10
	private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Methods

	// RVA: 0x108A4E8
	void .ctor() { }

	// RVA: 0x108A5C8
	void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x108A6D0
	void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x108A92C
	void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x108AAC4
	void Clear() { }

	// RVA: 0x108AB88
	void Remove(XmlQualifiedName name) { }

	// RVA: 0x108A87C
	int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x108ACD0
	int get_Count() { }

	// RVA: 0x108AD24
	bool Contains(XmlQualifiedName name) { }

	// RVA: 0x108AD88
	XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x108AE0C
	ICollection get_Values() { }

	// RVA: 0x108AEFC
	IDictionaryEnumerator GetEnumerator() { }

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

	// RVA: 0x108C7C8
	bool get_IsEmpty() { }

	// RVA: 0x108C6E0
	void .ctor() { }

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

	// RVA: 0x108BA70
	string get_MinOccursString() { }

	// RVA: 0x108BB0C
	void set_MinOccursString(string value) { }

	// RVA: 0x108BC74
	string get_MaxOccursString() { }

	// RVA: 0x108BDC0
	void set_MaxOccursString(string value) { }

	// RVA: 0x108BFEC
	Decimal get_MinOccurs() { }

	// RVA: 0x108BFF8
	void set_MinOccurs(Decimal value) { }

	// RVA: 0x108C130
	Decimal get_MaxOccurs() { }

	// RVA: 0x108C13C
	void set_MaxOccurs(Decimal value) { }

	// RVA: 0x108C2B4
	bool get_IsEmpty() { }

	// RVA: 0x108C32C
	string get_NameString() { }

	// RVA: 0x108C378
	XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x108C520
	void .ctor() { }

	// RVA: 0x108C5A0
	void .cctor() { }

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

	// RVA: 0x108C7D0
	void .ctor() { }

	// RVA: 0x108C8C8
	XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x108C8D0
	XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x108C8D8
	XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x108C8E0
	XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x108C8E8
	void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSequence 
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x108C908
	XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x108C910
	bool get_IsEmpty() { }

	// RVA: 0x108C9C0
	void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x108C9C8
	void .ctor() { }

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

	// RVA: 0x108CA40
	object get_InternalSyncObject() { }

	// RVA: 0x108CAC8
	void .ctor() { }

	// RVA: 0x108CB30
	void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x108CE34
	void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x108CF5C
	void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x108D038
	bool get_IsCompiled() { }

	// RVA: 0x108D040
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x108D060
	XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x108D068
	void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x108D070
	int get_Count() { }

	// RVA: 0x108D098
	XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x108D11C
	XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x108D1A0
	XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x108D224
	XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x108D2A8
	Hashtable get_SchemaLocations() { }

	// RVA: 0x108D2B0
	XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x108D334
	void Add(XmlSchemaSet schemas) { }

	// RVA: 0x108FCFC
	XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x108FF58
	bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x1090FE8
	bool Contains(string targetNamespace) { }

	// RVA: 0x109107C
	void Compile() { }

	// RVA: 0x1091848
	XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x1093648
	void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x10937C4
	ICollection Schemas() { }

	// RVA: 0x1093360
	ICollection Schemas(string targetNamespace) { }

	// RVA: 0x108FC8C
	XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x1093CB8
	void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x108FA10
	XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x10937EC
	void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x109462C
	void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x1094B5C
	void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x1090BD0
	XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x1091648
	void ClearTables() { }

	// RVA: 0x109351C
	bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	// RVA: 0x109441C
	XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x108DD64
	void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x10955B4
	SchemaInfo get_CompiledInfo() { }

	// RVA: 0x10955BC
	XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x10955C4
	XmlResolver GetResolver() { }

	// RVA: 0x10955E4
	ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1095388
	SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x109408C
	bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	// RVA: 0x10955EC
	bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	// RVA: 0x1090AB8
	string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x1095784
	SortedList get_SortedSchemas() { }

	// RVA: 0x1092D30
	void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x1092188
	void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x1094FDC
	bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1095448
	void VerifyTables() { }

	// RVA: 0x109578C
	void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x1090B24
	void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContent 
{
	// Fields
	private XmlSchemaContent content; // 0x50

	// Methods

	// RVA: 0x10957DC
	XmlSchemaContent get_Content() { }

	// RVA: 0x10957E4
	void set_Content(XmlSchemaContent value) { }

	// RVA: 0x10957EC
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentExtension 
{
	// Fields
	private XmlSchemaObjectCollection attributes; // 0x50
	private XmlSchemaAnyAttribute anyAttribute; // 0x58
	private XmlQualifiedName baseTypeName; // 0x60

	// Methods

	// RVA: 0x10957F4
	XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10957FC
	void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10958D4
	XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x10958DC
	XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10958E4
	void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10958EC
	void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x10958F4
	void .ctor() { }

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

	// RVA: 0x10959A8
	XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x10959B0
	void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x1095A88
	XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x1095A90
	void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x1095A98
	XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x1095AA0
	XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1095AA8
	XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1095AB0
	void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1095AB8
	void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1095AC0
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleType 
{
	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Methods

	// RVA: 0x1095B98
	void .ctor() { }

	// RVA: 0x1095CB0
	XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x1095CB8
	void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0x1095CC0
	XmlSchemaObject Clone() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaSimpleTypeContent 
{
	// Methods

	// RVA: 0x1095DD0
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeList 
{
	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Methods

	// RVA: 0x1095DD8
	XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0x1095DE0
	void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x1095EB8
	XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x1095EC0
	void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x1095EC8
	XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x1095ED0
	void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x1095ED8
	XmlSchemaObject Clone() { }

	// RVA: 0x1095F9C
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeRestriction 
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60

	// Methods

	// RVA: 0x1096018
	XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1096020
	void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x10960F8
	XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x1096100
	void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x1096108
	XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x1096110
	XmlSchemaObject Clone() { }

	// RVA: 0x10961D4
	void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeUnion 
{
	// Fields
	private XmlSchemaObjectCollection baseTypes; // 0x50
	private XmlQualifiedName[] memberTypes; // 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; // 0x60

	// Methods

	// RVA: 0x1096288
	XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x1096290
	XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x1096298
	void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x10962A0
	XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x10962A8
	void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0x10962B0
	XmlSchemaObject Clone() { }

	// RVA: 0x1096474
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroup 
{
	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Methods

	// RVA: 0x10964EC
	ArrayList get_Members() { }

	// RVA: 0x10964F4
	XmlQualifiedName get_Examplar() { }

	// RVA: 0x10964FC
	void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0x1096504
	void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroupV1Compat 
{
	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Methods

	// RVA: 0x10965B8
	XmlSchemaChoice get_Choice() { }

	// RVA: 0x10965C0
	void .ctor() { }

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

	// RVA: 0x1096634
	XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x1096750
	XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0x10967D8
	XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x1096AD8
	string get_Name() { }

	// RVA: 0x1096AE0
	void set_Name(string value) { }

	// RVA: 0x1096AE8
	XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x1096AF0
	void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1095590
	XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1096AF8
	XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x1096B00
	XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x1096B08
	XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x1096B10
	XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x1096B18
	bool get_IsMixed() { }

	// RVA: 0x1096B20
	void set_IsMixed(bool value) { }

	// RVA: 0x1096B24
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x1096C1C
	XmlValueConverter get_ValueConverter() { }

	// RVA: 0x1096CAC
	XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0x1096CB4
	void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1096CE4
	void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1096CEC
	void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x1096CF4
	void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1096CFC
	void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0x1096D04
	SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x1096D28
	void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x1096D58
	XmlSchemaType get_Redefined() { }

	// RVA: 0x1096D60
	void set_Redefined(XmlSchemaType value) { }

	// RVA: 0x1096D68
	void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0x1096D70
	bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x1096FE8
	bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x10970F4
	string get_NameAttribute() { }

	// RVA: 0x10970FC
	void set_NameAttribute(string value) { }

	// RVA: 0x1095C24
	void .ctor() { }

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
public class XmlSchemaValidationException 
{
	// Methods

	// RVA: 0x1097104
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x109710C
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1097114
	void .ctor() { }

	// RVA: 0x1097120
	void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10971F4
	void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1097228
	void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Schema
public sealed class XmlValueGetter 
{
	// Methods

	// RVA: 0x109724C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x10972EC
	internal object Invoke() { }

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

	// RVA: 0x1097300
	void .ctor(IdRefNode next, string id, int lineNo, int linePos) { }

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

	// RVA: 0x1097364
	void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0x1097598
	void Init() { }

	// RVA: 0x1097ACC
	void Reset() { }

	// RVA: 0x1097C58
	void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1097C60
	void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0x1097C78
	void set_SourceUri(Uri value) { }

	// RVA: 0x1097CC8
	void set_ValidationEventSender(object value) { }

	// RVA: 0x1097CD0
	void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1097D84
	void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1097E38
	void AddSchema(XmlSchema schema) { }

	// RVA: 0x1098648
	void Initialize() { }

	// RVA: 0x109878C
	void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0x1098A44
	void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x109A7AC
	object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x109A810
	object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x109BD2C
	void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x109C094
	void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0x109C0F8
	void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x109CAD4
	void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0x109CB38
	void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x109CDAC
	object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x109D2C0
	void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x109D648
	void EndValidation() { }

	// RVA: 0x109D8C4
	void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x109E4AC
	XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x109E4B4
	XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x109E4BC
	XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0x109E4F8
	void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0x109E528
	bool get_StrictlyAssessed() { }

	// RVA: 0x109E574
	bool get_HasSchema() { }

	// RVA: 0x109E5C8
	string GetConcatenatedValue() { }

	// RVA: 0x109CDB4
	object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0x1099850
	void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x10990CC
	object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	// RVA: 0x10A03F4
	XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0x109E5EC
	object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x109E8D8
	object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x10A1474
	string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0x109C54C
	void SaveTextValue(object value) { }

	// RVA: 0x109795C
	void Push(XmlQualifiedName elementName) { }

	// RVA: 0x109D4D4
	void Pop() { }

	// RVA: 0x10995C8
	SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0x1099BA0
	SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	// RVA: 0x109A2CC
	void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0x109A4F4
	void CheckElementProperties() { }

	// RVA: 0x109A5FC
	void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x109B3D8
	SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0x10A1D9C
	void AddXmlNamespaceSchema() { }

	// RVA: 0x109ECA4
	object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0x109FEDC
	void LoadSchema(string uri, string url) { }

	// RVA: 0x1097B78
	void RecompileSchemaSet() { }

	// RVA: 0x10A2058
	void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0x109B660
	object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0x10A11A4
	object CheckElementValue(string stringValue) { }

	// RVA: 0x109B8C4
	void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0x10A2350
	object FindId(string name) { }

	// RVA: 0x109D738
	void CheckForwardRefs() { }

	// RVA: 0x109BA54
	bool get_HasIdentityConstraints() { }

	// RVA: 0x10A1544
	bool get_ProcessIdentityConstraints() { }

	// RVA: 0x10A2648
	bool get_ReportValidationWarnings() { }

	// RVA: 0x1097C48
	bool get_ProcessSchemaHints() { }

	// RVA: 0x1098E38
	void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0x1099074
	void ClearPSVI() { }

	// RVA: 0x109BE14
	void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0x109A668
	XmlSchemaElement GetSchemaElement() { }

	// RVA: 0x109DFD0
	string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0x10A1550
	void AddIdentityConstraints() { }

	// RVA: 0x10A19B0
	void ElementIdentityConstraints() { }

	// RVA: 0x109BA74
	void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0x109F2F4
	void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A085C
	void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x109EDAC
	void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x109C6F0
	string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0x10A2C48
	string PrintNames(ArrayList expected) { }

	// RVA: 0x10A2720
	void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0x10A2DD0
	void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0x109C4C8
	string QNameString(string localName, string ns) { }

	// RVA: 0x10A05D4
	string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0x109C594
	string BuildElementName(string localName, string ns) { }

	// RVA: 0x10A236C
	void ProcessEntity(string name) { }

	// RVA: 0x10A14E0
	void SendValidationEvent(string code) { }

	// RVA: 0x109B4BC
	void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x109B1CC
	void SendValidationEvent(string code, string arg) { }

	// RVA: 0x10A0650
	void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0x10A1E74
	void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0x1098498
	void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0x10A2654
	void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0x10A033C
	void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1098258
	void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x10A250C
	void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x10A265C
	void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x10A3014
	void .cctor() { }

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
	bool ToBoolean(Int64 value) { }

	// RVA: 0x2FE3088
	bool ToBoolean(int value) { }

	// RVA: -1
	bool ToBoolean(Double value) { }

	// RVA: -1
	bool ToBoolean(DateTime value) { }

	// RVA: 0x2FE3174
	bool ToBoolean(string value) { }

	// RVA: 0x2FE3174
	bool ToBoolean(object value) { }

	// RVA: -1
	int ToInt32(bool value) { }

	// RVA: -1
	int ToInt32(Int64 value) { }

	// RVA: -1
	int ToInt32(Double value) { }

	// RVA: -1
	int ToInt32(DateTime value) { }

	// RVA: 0x2FE3404
	int ToInt32(string value) { }

	// RVA: 0x2FE3404
	int ToInt32(object value) { }

	// RVA: -1
	Int64 ToInt64(bool value) { }

	// RVA: -1
	Int64 ToInt64(int value) { }

	// RVA: -1
	Int64 ToInt64(Double value) { }

	// RVA: -1
	Int64 ToInt64(DateTime value) { }

	// RVA: -1
	Int64 ToInt64(string value) { }

	// RVA: -1
	Int64 ToInt64(object value) { }

	// RVA: -1
	Decimal ToDecimal(string value) { }

	// RVA: -1
	Decimal ToDecimal(object value) { }

	// RVA: -1
	Double ToDouble(bool value) { }

	// RVA: -1
	Double ToDouble(int value) { }

	// RVA: -1
	Double ToDouble(Int64 value) { }

	// RVA: -1
	Double ToDouble(DateTime value) { }

	// RVA: -1
	Double ToDouble(string value) { }

	// RVA: -1
	Double ToDouble(object value) { }

	// RVA: -1
	float ToSingle(Double value) { }

	// RVA: -1
	float ToSingle(string value) { }

	// RVA: -1
	float ToSingle(object value) { }

	// RVA: -1
	DateTime ToDateTime(bool value) { }

	// RVA: -1
	DateTime ToDateTime(int value) { }

	// RVA: -1
	DateTime ToDateTime(Int64 value) { }

	// RVA: -1
	DateTime ToDateTime(Double value) { }

	// RVA: -1
	DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: -1
	DateTime ToDateTime(string value) { }

	// RVA: -1
	DateTime ToDateTime(object value) { }

	// RVA: -1
	DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: -1
	DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: -1
	DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: -1
	string ToString(bool value) { }

	// RVA: -1
	string ToString(int value) { }

	// RVA: -1
	string ToString(Int64 value) { }

	// RVA: -1
	string ToString(Decimal value) { }

	// RVA: -1
	string ToString(float value) { }

	// RVA: -1
	string ToString(Double value) { }

	// RVA: -1
	string ToString(DateTime value) { }

	// RVA: -1
	string ToString(DateTimeOffset value) { }

	// RVA: 0x2FE36BC
	string ToString(object value) { }

	// RVA: 0x2FE37A0
	string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: -1
	object ChangeType(bool value, Type destinationType) { }

	// RVA: -1
	object ChangeType(int value, Type destinationType) { }

	// RVA: -1
	object ChangeType(Int64 value, Type destinationType) { }

	// RVA: -1
	object ChangeType(Decimal value, Type destinationType) { }

	// RVA: -1
	object ChangeType(Double value, Type destinationType) { }

	// RVA: -1
	object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x2FE3810
	object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x2FE37A0
	object ChangeType(object value, Type destinationType) { }

	// RVA: 0x2FE3810
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10A3494
	void .ctor() { }

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

	// RVA: 0x10A349C
	void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10A36B0
	void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x10A37A0
	void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x10A381C
	void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x10A387C
	bool ToBoolean(DateTime value) { }

	// RVA: 0x10A397C
	bool ToBoolean(Double value) { }

	// RVA: 0x10A3A7C
	bool ToBoolean(int value) { }

	// RVA: 0x10A3B7C
	bool ToBoolean(Int64 value) { }

	// RVA: 0x10A3C7C
	bool ToBoolean(string value) { }

	// RVA: 0x10A3D44
	bool ToBoolean(object value) { }

	// RVA: 0x10A3E0C
	DateTime ToDateTime(bool value) { }

	// RVA: 0x10A3F0C
	DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x10A4010
	DateTime ToDateTime(Double value) { }

	// RVA: 0x10A4110
	DateTime ToDateTime(int value) { }

	// RVA: 0x10A4210
	DateTime ToDateTime(Int64 value) { }

	// RVA: 0x10A4310
	DateTime ToDateTime(string value) { }

	// RVA: 0x10A43D8
	DateTime ToDateTime(object value) { }

	// RVA: 0x10A44A0
	DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x10A45A4
	DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x10A4670
	DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10A473C
	Decimal ToDecimal(string value) { }

	// RVA: 0x10A4808
	Decimal ToDecimal(object value) { }

	// RVA: 0x10A48D4
	Double ToDouble(bool value) { }

	// RVA: 0x10A49D4
	Double ToDouble(DateTime value) { }

	// RVA: 0x10A4AD4
	Double ToDouble(int value) { }

	// RVA: 0x10A4BD4
	Double ToDouble(Int64 value) { }

	// RVA: 0x10A4CD4
	Double ToDouble(string value) { }

	// RVA: 0x10A4D9C
	Double ToDouble(object value) { }

	// RVA: 0x10A4E64
	int ToInt32(bool value) { }

	// RVA: 0x10A4F64
	int ToInt32(DateTime value) { }

	// RVA: 0x10A5064
	int ToInt32(Double value) { }

	// RVA: 0x10A5164
	int ToInt32(Int64 value) { }

	// RVA: 0x10A5264
	int ToInt32(string value) { }

	// RVA: 0x10A532C
	int ToInt32(object value) { }

	// RVA: 0x10A53F4
	Int64 ToInt64(bool value) { }

	// RVA: 0x10A54F4
	Int64 ToInt64(DateTime value) { }

	// RVA: 0x10A55F4
	Int64 ToInt64(Double value) { }

	// RVA: 0x10A56F4
	Int64 ToInt64(int value) { }

	// RVA: 0x10A57F4
	Int64 ToInt64(string value) { }

	// RVA: 0x10A58BC
	Int64 ToInt64(object value) { }

	// RVA: 0x10A5984
	float ToSingle(Double value) { }

	// RVA: 0x10A5A84
	float ToSingle(string value) { }

	// RVA: 0x10A5B4C
	float ToSingle(object value) { }

	// RVA: 0x10A5C14
	string ToString(bool value) { }

	// RVA: 0x10A5D00
	string ToString(DateTime value) { }

	// RVA: 0x10A5DEC
	string ToString(DateTimeOffset value) { }

	// RVA: 0x10A5EDC
	string ToString(Decimal value) { }

	// RVA: 0x10A5FF8
	string ToString(Double value) { }

	// RVA: 0x10A60E4
	string ToString(int value) { }

	// RVA: 0x10A61D0
	string ToString(Int64 value) { }

	// RVA: 0x10A62BC
	string ToString(float value) { }

	// RVA: 0x10A63A8
	string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10A6468
	string ToString(object value) { }

	// RVA: 0x10A647C
	object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10A6510
	object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10A65A4
	object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10A6668
	object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10A66FC
	object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10A6790
	object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10A6824
	object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10A6834
	object ChangeType(object value, Type destinationType) { }

	// RVA: 0x10A6848
	XmlSchemaType get_SchemaType() { }

	// RVA: 0x10A6850
	XmlTypeCode get_TypeCode() { }

	// RVA: 0x10A6858
	string get_XmlTypeName() { }

	// RVA: 0x10A6AC4
	Type get_DefaultClrType() { }

	// RVA: 0x10A6ACC
	bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x10A6BA8
	Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x10A6990
	string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x10A6E4C
	object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10A6EA8
	Byte[] StringToBase64Binary(string value) { }

	// RVA: 0x10A6F58
	DateTime StringToDate(string value) { }

	// RVA: 0x10A6FE0
	DateTime StringToDateTime(string value) { }

	// RVA: 0x10A7068
	TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x10A70C0
	TimeSpan StringToDuration(string value) { }

	// RVA: 0x10A7118
	DateTime StringToGDay(string value) { }

	// RVA: 0x10A71A0
	DateTime StringToGMonth(string value) { }

	// RVA: 0x10A7228
	DateTime StringToGMonthDay(string value) { }

	// RVA: 0x10A72B0
	DateTime StringToGYear(string value) { }

	// RVA: 0x10A7338
	DateTime StringToGYearMonth(string value) { }

	// RVA: 0x10A73C0
	DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x10A7448
	DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x10A74D0
	DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x10A7558
	DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x10A75E0
	DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x10A7668
	DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x10A76F0
	DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x10A7778
	Byte[] StringToHexBinary(string value) { }

	// RVA: 0x10A78BC
	XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10A7B9C
	DateTime StringToTime(string value) { }

	// RVA: 0x10A7C24
	DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x10A7CAC
	TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x10A7D04
	string AnyUriToString(Uri value) { }

	// RVA: 0x10A7D1C
	string Base64BinaryToString(Byte[] value) { }

	// RVA: 0x10A7DA4
	string DateToString(DateTime value) { }

	// RVA: 0x10A7E34
	string DateTimeToString(DateTime value) { }

	// RVA: 0x10A7EC4
	string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x10A7F1C
	string DurationToString(TimeSpan value) { }

	// RVA: 0x10A7F74
	string GDayToString(DateTime value) { }

	// RVA: 0x10A8004
	string GMonthToString(DateTime value) { }

	// RVA: 0x10A8094
	string GMonthDayToString(DateTime value) { }

	// RVA: 0x10A8124
	string GYearToString(DateTime value) { }

	// RVA: 0x10A81B4
	string GYearMonthToString(DateTime value) { }

	// RVA: 0x10A8244
	string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10A82DC
	string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10A8374
	string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10A840C
	string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10A84A4
	string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10A853C
	string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10A85D4
	string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10A866C
	string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10A88A4
	string TimeToString(DateTime value) { }

	// RVA: 0x10A8934
	string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x10A89CC
	string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x10A8A24
	DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x10A8A8C
	int DecimalToInt32(Decimal value) { }

	// RVA: 0x10A8C74
	Int64 DecimalToInt64(Decimal value) { }

	// RVA: 0x10A8E5C
	UInt64 DecimalToUInt64(Decimal value) { }

	// RVA: 0x10A9038
	Byte Int32ToByte(int value) { }

	// RVA: 0x10A9124
	Int16 Int32ToInt16(int value) { }

	// RVA: 0x10A9210
	SByte Int32ToSByte(int value) { }

	// RVA: 0x10A92FC
	UInt16 Int32ToUInt16(int value) { }

	// RVA: 0x10A93E8
	int Int64ToInt32(Int64 value) { }

	// RVA: 0x10A94D0
	UInt32 Int64ToUInt32(Int64 value) { }

	// RVA: 0x10A95B8
	DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x10A9640
	DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x10A96C8
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric10Converter 
{
	// Methods

	// RVA: 0x10A9D40
	void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10A9DAC
	XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10A9E50
	Decimal ToDecimal(string value) { }

	// RVA: 0x10A9F60
	Decimal ToDecimal(object value) { }

	// RVA: 0x10AA954
	int ToInt32(Int64 value) { }

	// RVA: 0x10AA9DC
	int ToInt32(string value) { }

	// RVA: 0x10AAB10
	int ToInt32(object value) { }

	// RVA: 0x10AAFA0
	Int64 ToInt64(int value) { }

	// RVA: 0x10AAFA8
	Int64 ToInt64(string value) { }

	// RVA: 0x10AB0DC
	Int64 ToInt64(object value) { }

	// RVA: 0x10AB56C
	string ToString(Decimal value) { }

	// RVA: 0x10AB648
	string ToString(int value) { }

	// RVA: 0x10AB6D0
	string ToString(Int64 value) { }

	// RVA: 0x10AB758
	string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10ABC24
	object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10AC6F4
	object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10ACC70
	object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10AD1F0
	object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10AD74C
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10AA424
	object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10AC1AC
	object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric2Converter 
{
	// Methods

	// RVA: 0x10AEA80
	void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10AEAEC
	XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10AEB90
	Double ToDouble(string value) { }

	// RVA: 0x10AEC90
	Double ToDouble(object value) { }

	// RVA: 0x10AF078
	float ToSingle(Double value) { }

	// RVA: 0x10AF080
	float ToSingle(string value) { }

	// RVA: 0x10AF180
	float ToSingle(object value) { }

	// RVA: 0x10AF554
	string ToString(Double value) { }

	// RVA: 0x10AF650
	string ToString(float value) { }

	// RVA: 0x10AF704
	string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10AFAF0
	object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10AFF70
	object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B0400
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlDateTimeConverter 
{
	// Methods

	// RVA: 0x10B0D18
	void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10B0D84
	XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10B0E28
	DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x10B0E94
	DateTime ToDateTime(string value) { }

	// RVA: 0x10B1180
	DateTime ToDateTime(object value) { }

	// RVA: 0x10B1574
	DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x10B15A0
	DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x10B188C
	DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10B1CBC
	string ToString(DateTime value) { }

	// RVA: 0x10B1F5C
	string ToString(DateTimeOffset value) { }

	// RVA: 0x10B2160
	string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B254C
	object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10B29D4
	object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B2E5C
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlBooleanConverter 
{
	// Methods

	// RVA: 0x10B3798
	void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10B3804
	XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10B38A8
	bool ToBoolean(string value) { }

	// RVA: 0x10B3964
	bool ToBoolean(object value) { }

	// RVA: 0x10B3CB4
	string ToString(bool value) { }

	// RVA: 0x10B3D3C
	string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B4078
	object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10B447C
	object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B4880
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlMiscConverter 
{
	// Methods

	// RVA: 0x10B4FC4
	void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10B5030
	XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10B50D4
	string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B5854
	object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B603C
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B56E4
	object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B5E90
	object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlStringConverter 
{
	// Methods

	// RVA: 0x10B70F0
	void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10B715C
	XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10B7200
	string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B745C
	object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B7790
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlUntypedConverter 
{
	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0x10B7CF4
	void .ctor() { }

	// RVA: 0x10B7E64
	void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0x10B7FF0
	bool ToBoolean(string value) { }

	// RVA: 0x10B80AC
	bool ToBoolean(object value) { }

	// RVA: 0x10B841C
	DateTime ToDateTime(string value) { }

	// RVA: 0x10B84D8
	DateTime ToDateTime(object value) { }

	// RVA: 0x10B86B0
	DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x10B876C
	DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10B8950
	Decimal ToDecimal(string value) { }

	// RVA: 0x10B8A0C
	Decimal ToDecimal(object value) { }

	// RVA: 0x10B8C18
	Double ToDouble(string value) { }

	// RVA: 0x10B8CD4
	Double ToDouble(object value) { }

	// RVA: 0x10B8ED4
	int ToInt32(string value) { }

	// RVA: 0x10B8F90
	int ToInt32(object value) { }

	// RVA: 0x10B9190
	Int64 ToInt64(string value) { }

	// RVA: 0x10B924C
	Int64 ToInt64(object value) { }

	// RVA: 0x10B944C
	float ToSingle(string value) { }

	// RVA: 0x10B9508
	float ToSingle(object value) { }

	// RVA: 0x10B9708
	string ToString(bool value) { }

	// RVA: 0x10B9790
	string ToString(DateTime value) { }

	// RVA: 0x10B9818
	string ToString(DateTimeOffset value) { }

	// RVA: 0x10B9884
	string ToString(Decimal value) { }

	// RVA: 0x10B98F0
	string ToString(Double value) { }

	// RVA: 0x10B9978
	string ToString(int value) { }

	// RVA: 0x10B9A00
	string ToString(Int64 value) { }

	// RVA: 0x10B9A88
	string ToString(float value) { }

	// RVA: 0x10B9B10
	string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10BA9F8
	object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10BAE34
	object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10BB080
	object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10BB338
	object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10BB5A4
	object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10BB804
	object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10BBA64
	object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10BC9E4
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10B82AC
	object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10BAC58
	object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10BE794
	object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10BEAD0
	bool SupportsType(Type clrType) { }

	// RVA: 0x10C02A0
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyConverter 
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x10C0364
	void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x10C03D0
	bool ToBoolean(object value) { }

	// RVA: 0x10C0724
	DateTime ToDateTime(object value) { }

	// RVA: 0x10C0908
	DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x10C0AF0
	Decimal ToDecimal(object value) { }

	// RVA: 0x10C0CD8
	Double ToDouble(object value) { }

	// RVA: 0x10C0EBC
	int ToInt32(object value) { }

	// RVA: 0x10C10A0
	Int64 ToInt64(object value) { }

	// RVA: 0x10C1284
	float ToSingle(object value) { }

	// RVA: 0x10C146C
	object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x10C1880
	object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x10C1AE8
	object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x10C1DA4
	object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x10C2014
	object ChangeType(int value, Type destinationType) { }

	// RVA: 0x10C227C
	object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x10C24E4
	object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10C273C
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10C05B4
	object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10C16D4
	object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10C41E0
	XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x10C4274
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyListConverter 
{
	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x10C438C
	void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x10C4484
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10C4734
	void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlListConverter 
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x10C4408
	void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x10B7F64
	void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x10B7DF8
	void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10C4924
	XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x10C4BA4
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10BF2B8
	object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10C4CB0
	bool IsListType(Type type) { }

	// RVA: 0x2FE37A0
	T[] ToArray(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10C55E4
	IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10C5534
	System.Collections.Generic.List<System.String> StringAsList(string value) { }

	// RVA: 0x10C51A0
	string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10C4EF4
	Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

}

// Namespace: System.Xml.Schema
internal class XmlUnionConverter 
{
	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0x10C5BF8
	void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x10C5E7C
	XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x10C5EE0
	object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

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

	// RVA: 0x10D2DA0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x10D2E5C
	internal void Invoke(XsdBuilder builder, string value) { }

}

// Namespace: 
private sealed class XsdInitFunction 
{
	// Methods

	// RVA: 0x10D2E70
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x10D2F2C
	internal void Invoke(XsdBuilder builder, string value) { }

}

// Namespace: 
private sealed class XsdEndChildFunction 
{
	// Methods

	// RVA: 0x10D2F40
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x10D2FF4
	internal void Invoke(XsdBuilder builder) { }

}

// Namespace: 
private sealed class XsdAttributeEntry 
{
	// Fields
	public Token Attribute; // 0x10
	public XsdBuildFunction BuildFunc; // 0x18

	// Methods

	// RVA: 0x10D3008
	void .ctor(Token a, XsdBuildFunction build) { }

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

	// RVA: 0x10D304C
	void .ctor(Token n, State state, State[] nextStates, XsdAttributeEntry[] attributes, XsdInitFunction init, XsdEndChildFunction end, bool parseContent) { }

}

// Namespace: 
private class BuilderNamespaceManager 
{
	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x10D30EC
	void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x10D313C
	string LookupNamespace(string prefix) { }

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

	// RVA: 0x10C63A0
	void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x10C6600
	bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x10C6DE0
	void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x10C733C
	bool IsContentParsed() { }

	// RVA: 0x10C735C
	void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x10C736C
	void ProcessCData(string value) { }

	// RVA: 0x10C73C8
	void StartChildren() { }

	// RVA: 0x10C757C
	void EndChildren() { }

	// RVA: 0x10C68BC
	void Push() { }

	// RVA: 0x10C75C4
	void Pop() { }

	// RVA: 0x10C8844
	Token get_CurrentElement() { }

	// RVA: 0x10C8864
	Token get_ParentElement() { }

	// RVA: 0x10C88E0
	XmlSchemaObject get_ParentContainer() { }

	// RVA: 0x10C76B8
	XmlSchemaObject GetContainer(State state) { }

	// RVA: 0x10C7870
	void SetContainer(State state, object container) { }

	// RVA: 0x10C8974
	void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0x10C899C
	void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10C8B30
	void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10C8BDC
	void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0x10C8C00
	void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0x10C8C24
	void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10C8F1C
	void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0x10C8F90
	void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0x10C8FB8
	void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0x10C9088
	void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x10C90AC
	void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0x10C917C
	void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x10C91A0
	void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x10C91C4
	void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0x10C9294
	void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x10C92B8
	void EndRedefine(XsdBuilder builder) { }

	// RVA: 0x10C92D8
	void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x10C96A4
	void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0x10C96C8
	void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x10C96EC
	void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0x10C9798
	void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0x10C9844
	void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x10C9A48
	void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10C9A6C
	void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0x10C9AE8
	void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0x10C9C5C
	void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x10C9E00
	void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0x10C9E74
	void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0x10C9E98
	void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0x10C9F44
	void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0x10C9FC0
	void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0x10CA034
	void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x10CA058
	void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x10CA144
	void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x10CA230
	void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10CA254
	void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0x10CA2D0
	void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x10CA34C
	void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0x10CA3C8
	void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0x10CA768
	void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10CA78C
	void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x10CA800
	void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0x10CA8D0
	void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0x10CAAD0
	void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0x10CABA0
	void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0x10CAC1C
	void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x10CACEC
	void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x10CAD68
	void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0x10CAF54
	void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x10CAFD0
	void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0x10CB044
	void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x10CB0B8
	void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x10CB13C
	void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10CB160
	void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0x10CB274
	void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x10CB2F0
	void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x10CB3E8
	void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x10CB464
	void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x10CB508
	void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x10CB584
	void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0x10CB698
	void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x10CB790
	void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x10CB80C
	void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x10CB904
	void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x10CB980
	void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0x10CBAB8
	void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10CBADC
	void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x10CBB6C
	void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x10CBBE8
	void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x10CBF00
	void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x10CBF24
	void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x10CBFD0
	void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0x10CC10C
	void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10CC130
	void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x10CC5B0
	void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x10CC5D0
	void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x10CC5F0
	void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x10CC66C
	void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0x10CC70C
	void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0x10CC7AC
	void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0x10CC84C
	void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0x10CC8F0
	void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x10CC914
	void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x10CC9C0
	void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0x10CCA68
	void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10CCA8C
	void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0x10CCAB0
	void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0x10CCAD4
	void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0x10CCE40
	void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x10CCEC4
	void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0x10CCEE8
	void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0x10CD040
	void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0x10CD064
	void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0x10CD188
	void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0x10CD264
	void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x10CD288
	void InitField(XsdBuilder builder, string value) { }

	// RVA: 0x10CD364
	void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x10CD388
	void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0x10CD570
	void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0x10CD644
	void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0x10CD6C4
	void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0x10CD6F0
	void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0x10CD7C4
	void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0x10CD840
	void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0x10CD988
	void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0x10C9408
	void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0x10CC1D4
	void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10C6748
	bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x10C6CCC
	bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x10CA164
	void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x10CA078
	void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x10C9CD8
	bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0x10C8A48
	int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0x10C98C0
	XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0x10C8C98
	int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x10CD6C0
	string ParseUriReference(string s) { }

	// RVA: 0x10CD9B4
	void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0x10C6CF8
	void SendValidationEvent(string code, string msg) { }

	// RVA: 0x10C7250
	void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x10CDB28
	void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x10CAAC8
	void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x10C6B8C
	void RecordPosition() { }

	// RVA: 0x10CDC08
	void .cctor() { }

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

	// RVA: 0x10D340C
	bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x10D75E8
	bool ParseDate(int start) { }

	// RVA: 0x10D79BC
	bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x10D7DB4
	bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x10D8038
	bool ParseTime(ref int start) { }

	// RVA: 0x10D7AA4
	bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x10D7E6C
	bool Parse4Dig(int start, ref int num) { }

	// RVA: 0x10D7F88
	bool Parse2Dig(int start, ref int num) { }

	// RVA: 0x10D7968
	bool ParseChar(int start, Char ch) { }

	// RVA: 0x10D75DC
	bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x10D854C
	void .cctor() { }

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

	// RVA: 0x10D31A0
	void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x10D47C0
	void .ctor(Parser parser) { }

	// RVA: 0x10D46F8
	void InitiateXsdDateTime(Parser parser) { }

	// RVA: 0x10D4920
	bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0x10D4A1C
	void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x10D4C08
	void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x10D4C84
	void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x10D4E18
	DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x10D4E20
	XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x10D4E28
	int get_Year() { }

	// RVA: 0x10D4EB0
	int get_Month() { }

	// RVA: 0x10D4F38
	int get_Day() { }

	// RVA: 0x10D4FC0
	int get_Hour() { }

	// RVA: 0x10D5048
	int get_Minute() { }

	// RVA: 0x10D50D0
	int get_Second() { }

	// RVA: 0x10D5158
	int get_Fraction() { }

	// RVA: 0x10D5278
	int get_ZoneHour() { }

	// RVA: 0x10D5280
	int get_ZoneMinute() { }

	// RVA: 0x10D5288
	DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x10D598C
	DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x10D5E6C
	string ToString() { }

	// RVA: 0x10D6774
	void PrintDate(StringBuilder sb) { }

	// RVA: 0x10D6AF8
	void PrintTime(StringBuilder sb) { }

	// RVA: 0x10D6FF0
	void PrintZone(StringBuilder sb) { }

	// RVA: 0x10D6F18
	void IntToCharArray(Char[] text, int start, int value, int digits) { }

	// RVA: 0x10D6F84
	void ShortToCharArray(Char[] text, int start, int value) { }

	// RVA: 0x10D721C
	void .cctor() { }

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

	// RVA: 0x10D85F0
	void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x10D8758
	void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x10D8888
	void .ctor(TimeSpan timeSpan, DurationType durationType) { }

	// RVA: 0x10D8A90
	void .ctor(string s) { }

	// RVA: 0x10D8B0C
	void .ctor(string s, DurationType durationType) { }

	// RVA: 0x10D92C8
	bool get_IsNegative() { }

	// RVA: 0x10D92D4
	int get_Years() { }

	// RVA: 0x10D92DC
	int get_Months() { }

	// RVA: 0x10D92E4
	int get_Days() { }

	// RVA: 0x10D92EC
	int get_Hours() { }

	// RVA: 0x10D92F4
	int get_Minutes() { }

	// RVA: 0x10D92FC
	int get_Seconds() { }

	// RVA: 0x10D92BC
	int get_Nanoseconds() { }

	// RVA: 0x10D9304
	TimeSpan ToTimeSpan() { }

	// RVA: 0x10D935C
	TimeSpan ToTimeSpan(DurationType durationType) { }

	// RVA: 0x10D98C8
	Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0x10D93B0
	Exception TryToTimeSpan(DurationType durationType, out TimeSpan result) { }

	// RVA: 0x10D98D4
	string ToString() { }

	// RVA: 0x10D98DC
	string ToString(DurationType durationType) { }

	// RVA: 0x10D9D14
	Exception TryParse(string s, out XsdDuration result) { }

	// RVA: 0x10D8B8C
	Exception TryParse(string s, DurationType durationType, out XsdDuration result) { }

	// RVA: 0x10D9D20
	string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }

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

	// RVA: 0x10D9EC8
	void .ctor(BaseValidator validator) { }

	// RVA: 0x10DA2EC
	void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x10D9EF8
	void Init() { }

	// RVA: 0x10DA474
	void Validate() { }

	// RVA: 0x10DAB74
	void CompleteValidation() { }

	// RVA: 0x10DA548
	bool get_IsInlineSchemaStarted() { }

	// RVA: 0x10DA558
	void ProcessInlineSchema() { }

	// RVA: 0x10DA808
	void ValidateElement() { }

	// RVA: 0x10DACA4
	object ValidateChildElement() { }

	// RVA: 0x10DAEDC
	void ProcessElement(object particle) { }

	// RVA: 0x10DB338
	void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	// RVA: 0x10DA994
	void ValidateEndElement() { }

	// RVA: 0x10DB238
	SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x10DBB40
	SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x10DBFB8
	void ValidateStartElement() { }

	// RVA: 0x10DC6F8
	void ValidateEndStartElement() { }

	// RVA: 0x10DE2F0
	void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x10DCB80
	void LoadSchema(string uri, string url) { }

	// RVA: 0x10DBF34
	bool get_HasSchema() { }

	// RVA: 0x10DE86C
	bool get_PreserveWhitespace() { }

	// RVA: 0x10DE8A8
	void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x10DCD44
	void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x10DEB24
	void AddID(string name, object node) { }

	// RVA: 0x10DEBC4
	object FindId(string name) { }

	// RVA: 0x10DAE90
	bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x10DA31C
	void Push(XmlQualifiedName elementName) { }

	// RVA: 0x10DDE9C
	void Pop() { }

	// RVA: 0x10DAB78
	void CheckForwardRefs() { }

	// RVA: 0x10DBF5C
	void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x10DD230
	bool get_HasIdentityConstraints() { }

	// RVA: 0x10DEBE0
	void AddIdentityConstraints() { }

	// RVA: 0x10DEFEC
	void ElementIdentityConstraints() { }

	// RVA: 0x10DE020
	void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x10DDF94
	object UnWrapUnion(object typedValue) { }

	// RVA: 0x10DD240
	void EndElementIdentityConstraints() { }

	// RVA: 0x10DF33C
	void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AbsoluteQuery 
{
	// Methods

	// RVA: 0x10DF3FC
	void .ctor() { }

	// RVA: 0x10DF44C
	void .ctor(AbsoluteQuery other) { }

	// RVA: 0x10DF4C4
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10DF544
	XPathNodeIterator Clone() { }

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

	// RVA: 0x2FE32D4
	AstType get_Type() { }

	// RVA: 0x2FE32D4
	XPathResultType get_ReturnType() { }

	// RVA: 0x10DF5C4
	void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AttributeQuery 
{
	// Fields
	private bool _onAttribute; // 0x54

	// Methods

	// RVA: 0x10DF5CC
	void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x10DF6B8
	void .ctor(AttributeQuery other) { }

	// RVA: 0x10DF78C
	void Reset() { }

	// RVA: 0x10DF818
	XPathNavigator Advance() { }

	// RVA: 0x10DF910
	XPathNodeIterator Clone() { }

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

	// RVA: 0x10DF984
	void .ctor(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x10DFA50
	void .ctor(AxisType axisType, AstNode input) { }

	// RVA: 0x10DFB40
	AstType get_Type() { }

	// RVA: 0x10DFB48
	XPathResultType get_ReturnType() { }

	// RVA: 0x10DFB50
	AstNode get_Input() { }

	// RVA: 0x10DFB58
	void set_Input(AstNode value) { }

	// RVA: 0x10DFB60
	string get_Prefix() { }

	// RVA: 0x10DFB68
	string get_Name() { }

	// RVA: 0x10DFB70
	XPathNodeType get_NodeType() { }

	// RVA: 0x10DFB78
	AxisType get_TypeOfAxis() { }

	// RVA: 0x10DFB80
	bool get_AbbrAxis() { }

	// RVA: 0x10DFB88
	string get_Urn() { }

	// RVA: 0x10DFB90
	void set_Urn(string value) { }

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

	// RVA: 0x10DFB98
	void .ctor(Query qyInput) { }

	// RVA: 0x10DF5D0
	void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x10DF6EC
	void .ctor(BaseAxisQuery other) { }

	// RVA: 0x10DF7D4
	void Reset() { }

	// RVA: 0x10DFC48
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x10DFCB0
	string get_Name() { }

	// RVA: 0x10DFCB8
	string get_Namespace() { }

	// RVA: 0x10DFCC0
	bool get_NameTest() { }

	// RVA: 0x10DFCC8
	XPathNodeType get_TypeTest() { }

	// RVA: 0x10DFCD0
	int get_CurrentPosition() { }

	// RVA: 0x10DFCD8
	XPathNavigator get_Current() { }

	// RVA: 0x10DFCE0
	bool matches(XPathNavigator e) { }

	// RVA: 0x10DFE0C
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10DFE68
	XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class BooleanExpr 
{
	// Fields
	private Query _opnd1; // 0x18
	private Query _opnd2; // 0x20
	private bool _isOr; // 0x28

	// Methods

	// RVA: 0x10DFE70
	void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x10DFFFC
	void .ctor(BooleanExpr other) { }

	// RVA: 0x10E006C
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x10E00C0
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10E019C
	XPathNodeIterator Clone() { }

	// RVA: 0x10E024C
	XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class BooleanFunctions 
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _funcType; // 0x20

	// Methods

	// RVA: 0x10DFFB4
	void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0x10E0254
	void .ctor(BooleanFunctions other) { }

	// RVA: 0x10E02A8
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x10E02C4
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10E07C4
	bool toBoolean(Double number) { }

	// RVA: 0x10E07E4
	bool toBoolean(string str) { }

	// RVA: 0x10E04B8
	bool toBoolean(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10E0808
	XPathResultType get_StaticType() { }

	// RVA: 0x10E065C
	bool Not(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10E06FC
	bool Lang(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10E0810
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheAxisQuery 
{
	// Fields
	protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer; // 0x58

	// Methods

	// RVA: 0x10E08A4
	void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x10E0964
	void .ctor(CacheAxisQuery other) { }

	// RVA: 0x10E0A18
	void Reset() { }

	// RVA: 0x10E0A20
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10E0B14
	XPathNavigator Advance() { }

	// RVA: 0x10E0BB4
	XPathNavigator get_Current() { }

	// RVA: 0x10E0C3C
	int get_CurrentPosition() { }

	// RVA: 0x10E0C44
	int get_Count() { }

	// RVA: 0x10E0C90
	QueryProps get_Properties() { }

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

	// RVA: 0x10E0C98
	void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x10E0EA8
	void .ctor(CacheChildrenQuery other) { }

	// RVA: 0x10E102C
	void Reset() { }

	// RVA: 0x10E1200
	XPathNavigator Advance() { }

	// RVA: 0x10E148C
	bool DecideNextNode() { }

	// RVA: 0x10E140C
	XPathNavigator GetNextInput() { }

	// RVA: 0x10E1624
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheOutputQuery 
{
	// Fields
	internal Query input; // 0x18
	protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer; // 0x20

	// Methods

	// RVA: 0x10E1688
	void .ctor(Query input) { }

	// RVA: 0x10E1738
	void .ctor(CacheOutputQuery other) { }

	// RVA: 0x10E180C
	void Reset() { }

	// RVA: 0x10E1814
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x10E183C
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10E1900
	XPathNavigator Advance() { }

	// RVA: 0x10E19A0
	XPathNavigator get_Current() { }

	// RVA: 0x10E1A28
	XPathResultType get_StaticType() { }

	// RVA: 0x10E1A30
	int get_CurrentPosition() { }

	// RVA: 0x10E1A38
	int get_Count() { }

	// RVA: 0x10E1A84
	QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ChildrenQuery 
{
	// Fields
	private XPathNodeIterator _iterator; // 0x58

	// Methods

	// RVA: 0x10E0E00
	void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x10E0F84
	void .ctor(ChildrenQuery other) { }

	// RVA: 0x10E1164
	void Reset() { }

	// RVA: 0x10E1A8C
	XPathNavigator Advance() { }

	// RVA: 0x10E1C54
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ClonableStack<T0> 
{
	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0x309AF8C
	void Push(T value) { }

	// RVA: 0x309AF8C
	T Pop() { }

	// RVA: 0x309AF8C
	T Peek() { }

	// RVA: 0x2FE360C
	MS.Internal.Xml.XPath.ClonableStack<T> Clone() { }

}

// Namespace: 
private class UndefinedXsltContext 
{
	// Fields
	private IXmlNamespaceResolver _nsResolver; // 0x50

	// Methods

	// RVA: 0x10E1EA4
	void .ctor(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x10E1EDC
	string get_DefaultNamespace() { }

	// RVA: 0x10E1F28
	string LookupNamespace(string prefix) { }

	// RVA: 0x10E2068
	IXsltContextVariable ResolveVariable(string prefix, string name) { }

	// RVA: 0x10E20A4
	IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) { }

	// RVA: 0x10E20E0
	bool get_Whitespace() { }

	// RVA: 0x10E20E8
	bool PreserveWhitespace(XPathNavigator node) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class CompiledXpathExpr 
{
	// Fields
	private Query _query; // 0x10
	private string _expr; // 0x18
	private bool _needContext; // 0x20

	// Methods

	// RVA: 0x10E1CB8
	void .ctor(Query query, string expression, bool needContext) { }

	// RVA: 0x10E1D14
	Query get_QueryTree() { }

	// RVA: 0x10E1D68
	void SetContext(IXmlNamespaceResolver nsResolver) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ContextQuery 
{
	// Fields
	protected XPathNavigator contextNode; // 0x18

	// Methods

	// RVA: 0x10DF424
	void .ctor() { }

	// RVA: 0x10DF488
	void .ctor(ContextQuery other) { }

	// RVA: 0x10E20F0
	void Reset() { }

	// RVA: 0x10E20F8
	XPathNavigator get_Current() { }

	// RVA: 0x10E2100
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10E2150
	XPathNavigator Advance() { }

	// RVA: 0x10E2170
	XPathNodeIterator Clone() { }

	// RVA: 0x10E21F0
	XPathResultType get_StaticType() { }

	// RVA: 0x10E21F8
	int get_CurrentPosition() { }

	// RVA: 0x10E2200
	int get_Count() { }

	// RVA: 0x10E2208
	QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class DescendantBaseQuery 
{
	// Fields
	protected bool matchSelf; // 0x54
	protected bool abbrAxis; // 0x55

	// Methods

	// RVA: 0x10E2210
	void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x10E2248
	void .ctor(DescendantBaseQuery other) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class DescendantQuery 
{
	// Fields
	private XPathNodeIterator _nodeIterator; // 0x58

	// Methods

	// RVA: 0x10E227C
	void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x10E22B4
	void .ctor(DescendantQuery other) { }

	// RVA: 0x10E2300
	void Reset() { }

	// RVA: 0x10E2350
	XPathNavigator Advance() { }

	// RVA: 0x10E2500
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DescendantOverDescendantQuery 
{
	// Fields
	private int _level; // 0x58

	// Methods

	// RVA: 0x10E2590
	void .ctor(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis) { }

	// RVA: 0x10E25D4
	void .ctor(DescendantOverDescendantQuery other) { }

	// RVA: 0x10E2610
	void Reset() { }

	// RVA: 0x10E2658
	XPathNavigator Advance() { }

	// RVA: 0x10E27C8
	bool MoveToFirstChild() { }

	// RVA: 0x10E2810
	bool MoveUpUntilNext() { }

	// RVA: 0x10E287C
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DocumentOrderQuery 
{
	// Methods

	// RVA: 0x10E28F8
	void .ctor(Query qyParent) { }

	// RVA: 0x10E28FC
	void .ctor(DocumentOrderQuery other) { }

	// RVA: 0x10E2900
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10E295C
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class EmptyQuery 
{
	// Methods

	// RVA: 0x10E29C0
	XPathNavigator Advance() { }

	// RVA: 0x10E29C8
	XPathNodeIterator Clone() { }

	// RVA: 0x10E29CC
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10E29D0
	int get_CurrentPosition() { }

	// RVA: 0x10E29D8
	int get_Count() { }

	// RVA: 0x10E29E0
	QueryProps get_Properties() { }

	// RVA: 0x10E29E8
	XPathResultType get_StaticType() { }

	// RVA: 0x10E29F0
	void Reset() { }

	// RVA: 0x10E29F4
	XPathNavigator get_Current() { }

	// RVA: 0x10E29FC
	void .ctor() { }

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

	// RVA: 0x10E2A04
	void .ctor(string prefix, string name) { }

	// RVA: 0x10E2A54
	void .ctor(ExtensionQuery other) { }

	// RVA: 0x10E2B7C
	void Reset() { }

	// RVA: 0x10E2B94
	XPathNavigator get_Current() { }

	// RVA: 0x10E2C20
	XPathNavigator Advance() { }

	// RVA: 0x10E2CA8
	int get_CurrentPosition() { }

	// RVA: 0x10E2CC0
	object ProcessResult(object value) { }

	// RVA: 0x10E312C
	string get_QName() { }

	// RVA: 0x10E31A0
	int get_Count() { }

	// RVA: 0x10E31BC
	XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Filter 
{
	// Fields
	private AstNode _input; // 0x10
	private AstNode _condition; // 0x18

	// Methods

	// RVA: 0x10E31C4
	void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x10E3214
	AstType get_Type() { }

	// RVA: 0x10E321C
	XPathResultType get_ReturnType() { }

	// RVA: 0x10E3224
	AstNode get_Input() { }

	// RVA: 0x10E322C
	AstNode get_Condition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FilterQuery 
{
	// Fields
	private Query _cond; // 0x58
	private bool _noPosition; // 0x60

	// Methods

	// RVA: 0x10E3234
	void .ctor(Query qyParent, Query cond, bool noPosition) { }

	// RVA: 0x10E3278
	void .ctor(FilterQuery other) { }

	// RVA: 0x10E32C8
	void Reset() { }

	// RVA: 0x10E3320
	Query get_Condition() { }

	// RVA: 0x10E3328
	void SetXsltContext(XsltContext input) { }

	// RVA: 0x10E345C
	XPathNavigator Advance() { }

	// RVA: 0x10E34E8
	bool EvaluatePredicate() { }

	// RVA: 0x10E36BC
	QueryProps get_Properties() { }

	// RVA: 0x10E36F0
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FollSiblingQuery 
{
	// Fields
	private MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator> _elementStk; // 0x58
	private System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> _parentStk; // 0x60
	private XPathNavigator _nextInput; // 0x68

	// Methods

	// RVA: 0x10E3780
	void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x10E388C
	void .ctor(FollSiblingQuery other) { }

	// RVA: 0x10E3984
	void Reset() { }

	// RVA: 0x10E3AB0
	bool Visited(XPathNavigator nav) { }

	// RVA: 0x10E3BC8
	XPathNavigator FetchInput() { }

	// RVA: 0x10E3C34
	XPathNavigator Advance() { }

	// RVA: 0x10E3EC4
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FollowingQuery 
{
	// Fields
	private XPathNavigator _input; // 0x58
	private XPathNodeIterator _iterator; // 0x60

	// Methods

	// RVA: 0x10E3F28
	void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x10E3F2C
	void .ctor(FollowingQuery other) { }

	// RVA: 0x10E3F8C
	void Reset() { }

	// RVA: 0x10E3FDC
	XPathNavigator Advance() { }

	// RVA: 0x10E4264
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ForwardPositionQuery 
{
	// Methods

	// RVA: 0x10E4308
	void .ctor(Query input) { }

	// RVA: 0x10E430C
	void .ctor(ForwardPositionQuery other) { }

	// RVA: 0x10E4310
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10E43C0
	XPathNodeIterator Clone() { }

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

	// RVA: 0x10E4424
	void .ctor(FunctionType ftype, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }

	// RVA: 0x10E44C8
	void .ctor(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }

	// RVA: 0x10E459C
	void .ctor(FunctionType ftype, AstNode arg) { }

	// RVA: 0x10E4668
	AstType get_Type() { }

	// RVA: 0x10E4670
	XPathResultType get_ReturnType() { }

	// RVA: 0x10E4714
	FunctionType get_TypeOfFunction() { }

	// RVA: 0x10E471C
	System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> get_ArgumentList() { }

	// RVA: 0x10E4724
	string get_Prefix() { }

	// RVA: 0x10E472C
	string get_Name() { }

	// RVA: 0x10E4734
	void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FunctionQuery 
{
	// Fields
	private System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> _args; // 0x38
	private IXsltContextFunction _function; // 0x40

	// Methods

	// RVA: 0x10E47D8
	void .ctor(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> args) { }

	// RVA: 0x10E483C
	void .ctor(FunctionQuery other) { }

	// RVA: 0x10E4A58
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x10E4FD8
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10E5558
	XPathResultType get_StaticType() { }

	// RVA: 0x10E5618
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Group 
{
	// Fields
	private AstNode _groupNode; // 0x10

	// Methods

	// RVA: 0x10E567C
	void .ctor(AstNode groupNode) { }

	// RVA: 0x10E56B0
	AstType get_Type() { }

	// RVA: 0x10E56B8
	XPathResultType get_ReturnType() { }

	// RVA: 0x10E56C0
	AstNode get_GroupNode() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class GroupQuery 
{
	// Methods

	// RVA: 0x10E56C8
	void .ctor(Query qy) { }

	// RVA: 0x10E56CC
	void .ctor(GroupQuery other) { }

	// RVA: 0x10E56D0
	XPathNavigator Advance() { }

	// RVA: 0x10E5730
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10E5758
	XPathNodeIterator Clone() { }

	// RVA: 0x10E57BC
	XPathResultType get_StaticType() { }

	// RVA: 0x10E57E4
	QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class IDQuery 
{
	// Methods

	// RVA: 0x10E57EC
	void .ctor(Query arg) { }

	// RVA: 0x10E57F0
	void .ctor(IDQuery other) { }

	// RVA: 0x10E57F4
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10E5A48
	void ProcessIds(XPathNavigator contextNode, string val) { }

	// RVA: 0x10E5B50
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class IteratorFilter 
{
	// Fields
	private XPathNodeIterator _innerIterator; // 0x18
	private string _name; // 0x20
	private int _position; // 0x28

	// Methods

	// RVA: 0x10E1C04
	void .ctor(XPathNodeIterator innerIterator, string name) { }

	// RVA: 0x10E5BB4
	void .ctor(IteratorFilter it) { }

	// RVA: 0x10E5C20
	XPathNodeIterator Clone() { }

	// RVA: 0x10E5CC8
	XPathNavigator get_Current() { }

	// RVA: 0x10E5CEC
	int get_CurrentPosition() { }

	// RVA: 0x10E5CF4
	bool MoveNext() { }

}

// Namespace: 
private sealed class cmpXslt 
{
	// Methods

	// RVA: 0x10EA7A8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x10EA84C
	internal bool Invoke(Op op, object val1, object val2) { }

}

// Namespace: 
private struct NodeSet 
{
	// Fields
	private Query _opnd; // 0x10
	private XPathNavigator _current; // 0x18

	// Methods

	// RVA: 0x10E636C
	void .ctor(object opnd) { }

	// RVA: 0x10E6440
	bool MoveNext() { }

	// RVA: 0x10E64B8
	void Reset() { }

	// RVA: 0x10E6494
	string get_Value() { }

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

	// RVA: 0x10E5D78
	void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x10E5DD0
	void .ctor(LogicalExpr other) { }

	// RVA: 0x10E5E3C
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x10E5E90
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10E61EC
	bool cmpQueryQueryE(Op op, object val1, object val2) { }

	// RVA: 0x10E64DC
	bool cmpQueryQueryO(Op op, object val1, object val2) { }

	// RVA: 0x10E6860
	bool cmpQueryNumber(Op op, object val1, object val2) { }

	// RVA: 0x10E6A4C
	bool cmpQueryStringE(Op op, object val1, object val2) { }

	// RVA: 0x10E6BC0
	bool cmpQueryStringO(Op op, object val1, object val2) { }

	// RVA: 0x10E6E3C
	bool cmpRtfQueryE(Op op, object val1, object val2) { }

	// RVA: 0x10E7074
	bool cmpRtfQueryO(Op op, object val1, object val2) { }

	// RVA: 0x10E72E4
	bool cmpQueryBoolE(Op op, object val1, object val2) { }

	// RVA: 0x10E740C
	bool cmpQueryBoolO(Op op, object val1, object val2) { }

	// RVA: 0x10E73F8
	bool cmpBoolBoolE(Op op, bool n1, bool n2) { }

	// RVA: 0x10E75F0
	bool cmpBoolBoolE(Op op, object val1, object val2) { }

	// RVA: 0x10E76E8
	bool cmpBoolBoolO(Op op, object val1, object val2) { }

	// RVA: 0x10E788C
	bool cmpBoolNumberE(Op op, object val1, object val2) { }

	// RVA: 0x10E79B4
	bool cmpBoolNumberO(Op op, object val1, object val2) { }

	// RVA: 0x10E7B5C
	bool cmpBoolStringE(Op op, object val1, object val2) { }

	// RVA: 0x10E7C58
	bool cmpRtfBoolE(Op op, object val1, object val2) { }

	// RVA: 0x10E7DC0
	bool cmpBoolStringO(Op op, object val1, object val2) { }

	// RVA: 0x10E7F9C
	bool cmpRtfBoolO(Op op, object val1, object val2) { }

	// RVA: 0x10E67EC
	bool cmpNumberNumber(Op op, Double n1, Double n2) { }

	// RVA: 0x10E6DE0
	bool cmpNumberNumberO(Op op, Double n1, Double n2) { }

	// RVA: 0x10E8204
	bool cmpNumberNumber(Op op, object val1, object val2) { }

	// RVA: 0x10E83B4
	bool cmpStringNumber(Op op, object val1, object val2) { }

	// RVA: 0x10E85AC
	bool cmpRtfNumber(Op op, object val1, object val2) { }

	// RVA: 0x10E6B88
	bool cmpStringStringE(Op op, string n1, string n2) { }

	// RVA: 0x10E8818
	bool cmpStringStringE(Op op, object val1, object val2) { }

	// RVA: 0x10E88E8
	bool cmpRtfStringE(Op op, object val1, object val2) { }

	// RVA: 0x10E8A28
	bool cmpRtfRtfE(Op op, object val1, object val2) { }

	// RVA: 0x10E8BA4
	bool cmpStringStringO(Op op, object val1, object val2) { }

	// RVA: 0x10E8DC0
	bool cmpRtfStringO(Op op, object val1, object val2) { }

	// RVA: 0x10E9064
	bool cmpRtfRtfO(Op op, object val1, object val2) { }

	// RVA: 0x10E92FC
	XPathNodeIterator Clone() { }

	// RVA: 0x10E6FEC
	string Rtf(object o) { }

	// RVA: 0x10E93AC
	XPathResultType get_StaticType() { }

	// RVA: 0x10E93B4
	void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class MergeFilterQuery 
{
	// Fields
	private Query _child; // 0x28

	// Methods

	// RVA: 0x10EA860
	void .ctor(Query input, Query child) { }

	// RVA: 0x10EA890
	void .ctor(MergeFilterQuery other) { }

	// RVA: 0x10EA8D4
	void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x10EA928
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10EA9BC
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NamespaceQuery 
{
	// Fields
	private bool _onNamespace; // 0x54

	// Methods

	// RVA: 0x10EAA44
	void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x10EAA48
	void .ctor(NamespaceQuery other) { }

	// RVA: 0x10EAA7C
	void Reset() { }

	// RVA: 0x10EAAC4
	XPathNavigator Advance() { }

	// RVA: 0x10EABAC
	bool matches(XPathNavigator e) { }

	// RVA: 0x10EAC40
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NodeFunctions 
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _funcType; // 0x20
	private XsltContext _xsltContext; // 0x28

	// Methods

	// RVA: 0x10EACB4
	void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0x10EACF8
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x10EAD70
	XPathNavigator EvaluateArg(XPathNodeIterator context) { }

	// RVA: 0x10EADDC
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10EB0E8
	XPathResultType get_StaticType() { }

	// RVA: 0x10EB18C
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NumberFunctions 
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _ftype; // 0x20

	// Methods

	// RVA: 0x10EB228
	void .ctor(FunctionType ftype, Query arg) { }

	// RVA: 0x10EB270
	void .ctor(NumberFunctions other) { }

	// RVA: 0x10EB2C4
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x10E75DC
	Double Number(bool arg) { }

	// RVA: 0x10E6764
	Double Number(string arg) { }

	// RVA: 0x10EB2E0
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10EB424
	Double Number(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10EB6B8
	Double Sum(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10EB7A8
	Double Floor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10EB870
	Double Ceiling(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10EB938
	Double Round(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10EB9CC
	XPathResultType get_StaticType() { }

	// RVA: 0x10EB9D4
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NumericExpr 
{
	// Fields
	private Op _op; // 0x14
	private Query _opnd1; // 0x18
	private Query _opnd2; // 0x20

	// Methods

	// RVA: 0x10EBA68
	void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x10EBB90
	void .ctor(NumericExpr other) { }

	// RVA: 0x10EBBFC
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x10EBC50
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10EBDA0
	Double GetValue(Op op, Double n1, Double n2) { }

	// RVA: 0x10EBE00
	XPathResultType get_StaticType() { }

	// RVA: 0x10EBE08
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Operand 
{
	// Fields
	private XPathResultType _type; // 0x10
	private object _val; // 0x18

	// Methods

	// RVA: 0x10EBEB8
	void .ctor(string val) { }

	// RVA: 0x10EBEF4
	void .ctor(Double val) { }

	// RVA: 0x10EBF84
	AstType get_Type() { }

	// RVA: 0x10EBF8C
	XPathResultType get_ReturnType() { }

	// RVA: 0x10EBF94
	object get_OperandValue() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class OperandQuery 
{
	// Fields
	internal object val; // 0x18

	// Methods

	// RVA: 0x10EBF9C
	void .ctor(object val) { }

	// RVA: 0x10EBFD0
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10EBFD8
	XPathResultType get_StaticType() { }

	// RVA: 0x10EBFE4
	XPathNodeIterator Clone() { }

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

	// RVA: 0x10E614C
	Op InvertOperator(Op op) { }

	// RVA: 0x10EBFE8
	void .ctor(Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x10EC040
	AstType get_Type() { }

	// RVA: 0x10EC048
	XPathResultType get_ReturnType() { }

	// RVA: 0x10EC068
	Op get_OperatorType() { }

	// RVA: 0x10EC070
	AstNode get_Operand1() { }

	// RVA: 0x10EC078
	AstNode get_Operand2() { }

	// RVA: 0x10EC080
	void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ParentQuery 
{
	// Methods

	// RVA: 0x10EC124
	void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x10EC1E4
	void .ctor(ParentQuery other) { }

	// RVA: 0x10EC1E8
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10EC290
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class PreSiblingQuery 
{
	// Methods

	// RVA: 0x10EC2F4
	void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x10EC3B4
	void .ctor(PreSiblingQuery other) { }

	// RVA: 0x10EC3B8
	bool NotVisited(XPathNavigator nav, System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> parentStk) { }

	// RVA: 0x10EC4E4
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10EC7BC
	XPathNodeIterator Clone() { }

	// RVA: 0x10EC820
	QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class PrecedingQuery 
{
	// Fields
	private XPathNodeIterator _workIterator; // 0x58
	private MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator> _ancestorStk; // 0x60

	// Methods

	// RVA: 0x10EC828
	void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x10EC8E0
	void .ctor(PrecedingQuery other) { }

	// RVA: 0x10EC97C
	void Reset() { }

	// RVA: 0x10ECA50
	XPathNavigator Advance() { }

	// RVA: 0x10ECD14
	XPathNodeIterator Clone() { }

	// RVA: 0x10ECD78
	QueryProps get_Properties() { }

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

	// RVA: 0x10ECD94
	void .ctor() { }

	// RVA: 0x10ECDEC
	void .ctor(Query other) { }

	// RVA: 0x10ECE5C
	bool MoveNext() { }

	// RVA: 0x10ECE84
	int get_Count() { }

	// RVA: 0x10ECF6C
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x2FE36BC
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x2FE360C
	XPathNavigator Advance() { }

	// RVA: 0x2FE32D4
	XPathResultType get_StaticType() { }

	// RVA: 0x10ECF70
	QueryProps get_Properties() { }

	// RVA: 0x10ECF78
	Query Clone(Query input) { }

	// RVA: 0x10ED014
	XPathNodeIterator Clone(XPathNodeIterator input) { }

	// RVA: 0x10ED028
	XPathNavigator Clone(XPathNavigator input) { }

	// RVA: 0x10ED040
	bool Insert(System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> buffer, XPathNavigator nav) { }

	// RVA: 0x10ED314
	int GetMedian(int l, int r) { }

	// RVA: 0x10ED1F0
	XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r) { }

	// RVA: 0x10ED320
	XPathResultType GetXPathType(object value) { }

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

	// RVA: 0x10ED43C
	void Reset() { }

	// RVA: 0x10ED448
	Query ProcessAxis(Axis root, Flags flags, out Props props) { }

	// RVA: 0x10EDFA8
	bool CanBeNumber(Query q) { }

	// RVA: 0x10EE010
	Query ProcessFilter(Filter root, Flags flags, out Props props) { }

	// RVA: 0x10EE524
	Query ProcessOperator(Operator root, out Props props) { }

	// RVA: 0x10EE7A4
	Query ProcessVariable(Variable root) { }

	// RVA: 0x10EE87C
	Query ProcessFunction(Function root, out Props props) { }

	// RVA: 0x10EED88
	System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> ProcessArguments(System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> args, out Props props) { }

	// RVA: 0x10EDBB4
	Query ProcessNode(AstNode root, Flags flags, out Props props) { }

	// RVA: 0x10EEF4C
	Query Build(AstNode root, string query) { }

	// RVA: 0x10EEFA0
	Query Build(string query, bool allowVar, bool allowKey) { }

	// RVA: 0x10EF1AC
	Query Build(string query, out bool needContext) { }

	// RVA: 0x10EF274
	void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ResetableIterator 
{
	// Methods

	// RVA: 0x10ECDC0
	void .ctor() { }

	// RVA: 0x10ECE24
	void .ctor(ResetableIterator other) { }

	// RVA: 0x10EF27C
	void ResetCount() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x2FE32D4
	int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ReversePositionQuery 
{
	// Methods

	// RVA: 0x10EE51C
	void .ctor(Query input) { }

	// RVA: 0x10EF288
	void .ctor(ReversePositionQuery other) { }

	// RVA: 0x10EF290
	XPathNodeIterator Clone() { }

	// RVA: 0x10EF2F8
	int get_CurrentPosition() { }

	// RVA: 0x10EF350
	QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Root 
{
	// Methods

	// RVA: 0x10EF36C
	void .ctor() { }

	// RVA: 0x10EF374
	AstType get_Type() { }

	// RVA: 0x10EF37C
	XPathResultType get_ReturnType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class StringFunctions 
{
	// Fields
	private FunctionType _funcType; // 0x14
	private System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> _argList; // 0x18
	private static readonly CompareInfo s_compareInfo; // 0x0

	// Methods

	// RVA: 0x10EEF04
	void .ctor(FunctionType funcType, System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> argList) { }

	// RVA: 0x10EF3B0
	void .ctor(StringFunctions other) { }

	// RVA: 0x10EF65C
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x10EF7E8
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F14CC
	string toString(Double num) { }

	// RVA: 0x10F1534
	string toString(bool b) { }

	// RVA: 0x10EF9F8
	string toString(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F15A0
	XPathResultType get_StaticType() { }

	// RVA: 0x10EFE6C
	string Concat(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F0060
	bool StartsWith(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F0244
	bool Contains(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F0434
	string SubstringBefore(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F0678
	string SubstringAfter(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F08B8
	string Substring(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F0D08
	Double StringLength(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F0EBC
	string Normalize(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F1164
	string Translate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F15C8
	XPathNodeIterator Clone() { }

	// RVA: 0x10F162C
	void .cctor() { }

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

	// RVA: 0x10EE740
	void .ctor(Query query1, Query query2) { }

	// RVA: 0x10F16DC
	void .ctor(UnionExpr other) { }

	// RVA: 0x10F18C0
	void Reset() { }

	// RVA: 0x10F191C
	void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x10F1970
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10F19EC
	XPathNavigator ProcessSamePosition(XPathNavigator result) { }

	// RVA: 0x10F1A24
	XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x10F1A6C
	XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x10F1AB0
	XPathNavigator Advance() { }

	// RVA: 0x10F1C60
	XPathResultType get_StaticType() { }

	// RVA: 0x10F1C68
	XPathNodeIterator Clone() { }

	// RVA: 0x10F1CCC
	XPathNavigator get_Current() { }

	// RVA: 0x10F1CD4
	int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ValueQuery 
{
	// Methods

	// RVA: 0x10EF384
	void .ctor() { }

	// RVA: 0x10EF624
	void .ctor(ValueQuery other) { }

	// RVA: 0x10F1D14
	void Reset() { }

	// RVA: 0x10F1D18
	XPathNavigator get_Current() { }

	// RVA: 0x10F1D54
	int get_CurrentPosition() { }

	// RVA: 0x10F1D90
	int get_Count() { }

	// RVA: 0x10F1DCC
	XPathNavigator Advance() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Variable 
{
	// Fields
	private string _localname; // 0x10
	private string _prefix; // 0x18

	// Methods

	// RVA: 0x10F1E08
	void .ctor(string name, string prefix) { }

	// RVA: 0x10F1E58
	AstType get_Type() { }

	// RVA: 0x10F1E60
	XPathResultType get_ReturnType() { }

	// RVA: 0x10F1E68
	string get_Localname() { }

	// RVA: 0x10F1E70
	string get_Prefix() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class VariableQuery 
{
	// Fields
	private IXsltContextVariable _variable; // 0x38

	// Methods

	// RVA: 0x10EE868
	void .ctor(string name, string prefix) { }

	// RVA: 0x10F1E78
	void .ctor(VariableQuery other) { }

	// RVA: 0x10F1EB4
	void SetXsltContext(XsltContext context) { }

	// RVA: 0x10F1F88
	object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F2084
	XPathResultType get_StaticType() { }

	// RVA: 0x10F21F4
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathAncestorQuery 
{
	// Fields
	private bool _matchSelf; // 0x60

	// Methods

	// RVA: 0x10EDF74
	void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf) { }

	// RVA: 0x10F2274
	void .ctor(XPathAncestorQuery other) { }

	// RVA: 0x10F22AC
	object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x10F23D8
	XPathNodeIterator Clone() { }

	// RVA: 0x10F2450
	int get_CurrentPosition() { }

	// RVA: 0x10F24A8
	QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathArrayIterator 
{
	// Fields
	protected IList list; // 0x18
	protected int index; // 0x20

	// Methods

	// RVA: 0x10F24C4
	void .ctor(XPathArrayIterator it) { }

	// RVA: 0x10F2514
	void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x10F2680
	XPathNodeIterator Clone() { }

	// RVA: 0x10F270C
	XPathNavigator get_Current() { }

	// RVA: 0x10F288C
	int get_CurrentPosition() { }

	// RVA: 0x10F2894
	int get_Count() { }

	// RVA: 0x10F294C
	bool MoveNext() { }

	// RVA: 0x10F2A34
	void Reset() { }

	// RVA: 0x10F2A3C
	IEnumerator GetEnumerator() { }

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

	// RVA: 0x10F2AF0
	void .ctor(XPathNavigator nav, bool matchSelf) { }

	// RVA: 0x10F2B40
	void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x10F2B98
	void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x10F2C88
	void .ctor(XPathAxisIterator it) { }

	// RVA: 0x10F2D20
	XPathNavigator get_Current() { }

	// RVA: 0x10F2D28
	int get_CurrentPosition() { }

	// RVA: 0x10F2D30
	bool get_Matches() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathChildIterator 
{
	// Methods

	// RVA: 0x10F2E90
	void .ctor(XPathNavigator nav, XPathNodeType type) { }

	// RVA: 0x10F2EE4
	void .ctor(XPathNavigator nav, string name, string namespaceURI) { }

	// RVA: 0x10F2EEC
	void .ctor(XPathChildIterator it) { }

	// RVA: 0x10F2EF0
	XPathNodeIterator Clone() { }

	// RVA: 0x10F2F54
	bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathDescendantIterator 
{
	// Fields
	private int _level; // 0x40

	// Methods

	// RVA: 0x10F2FFC
	void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x10F3054
	void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x10F3058
	void .ctor(XPathDescendantIterator it) { }

	// RVA: 0x10F308C
	XPathNodeIterator Clone() { }

	// RVA: 0x10F3100
	bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathEmptyIterator 
{
	// Fields
	public static XPathEmptyIterator Instance; // 0x0

	// Methods

	// RVA: 0x10F3200
	void .ctor() { }

	// RVA: 0x10F322C
	XPathNodeIterator Clone() { }

	// RVA: 0x10F3230
	XPathNavigator get_Current() { }

	// RVA: 0x10F3238
	int get_CurrentPosition() { }

	// RVA: 0x10F3240
	int get_Count() { }

	// RVA: 0x10F3248
	bool MoveNext() { }

	// RVA: 0x10F3250
	void Reset() { }

	// RVA: 0x10F3254
	void .cctor() { }

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

	// RVA: 0x10F73E8
	FunctionType get_FType() { }

	// RVA: 0x10F73F0
	int get_Minargs() { }

	// RVA: 0x10F73F8
	int get_Maxargs() { }

	// RVA: 0x10F7400
	XPathResultType[] get_ArgTypes() { }

	// RVA: 0x10F6D8C
	void .ctor(FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes) { }

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

	// RVA: 0x10F32C8
	void .ctor(XPathScanner scanner) { }

	// RVA: 0x10EF064
	AstNode ParseXPathExpression(string xpathExpression) { }

	// RVA: 0x10F3404
	AstNode ParseExpression(AstNode qyInput) { }

	// RVA: 0x10F3474
	AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x10F3584
	AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x10F3700
	AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x10F39EC
	AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x10F3B98
	AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x10F3C7C
	AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x10F3E08
	AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x10F3EEC
	AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x10F4274
	bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x10F4034
	AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x10F442C
	AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x10F4B28
	AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x10F46E4
	AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x10F4604
	AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x10F4CE4
	bool IsStep(LexKind lexKind) { }

	// RVA: 0x10F4D24
	AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x10F50DC
	AstNode ParseNodeTest(AstNode qyInput, AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x10F4374
	bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x10F4850
	AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x10F54C0
	AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x10F5450
	void CheckToken(LexKind t) { }

	// RVA: 0x10F4C7C
	void PassToken(LexKind t) { }

	// RVA: 0x10F36E4
	void NextLex() { }

	// RVA: 0x10F3694
	bool TestOp(string op) { }

	// RVA: 0x10F4210
	void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x10F61A8
	System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.XPathParser.ParamInfo> CreateFunctionTable() { }

	// RVA: 0x10F6DE4
	System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable() { }

	// RVA: 0x10F4FCC
	AxisType GetAxis() { }

	// RVA: 0x10F7104
	void .cctor() { }

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

	// RVA: 0x10F32FC
	void .ctor(string xpathExpr) { }

	// RVA: 0x10F7474
	string get_SourceText() { }

	// RVA: 0x10F747C
	Char get_CurrentChar() { }

	// RVA: 0x10F7408
	bool NextChar() { }

	// RVA: 0x10F7484
	LexKind get_Kind() { }

	// RVA: 0x10F748C
	string get_Name() { }

	// RVA: 0x10F7494
	string get_Prefix() { }

	// RVA: 0x10F749C
	string get_StringValue() { }

	// RVA: 0x10F74A4
	Double get_NumberValue() { }

	// RVA: 0x10F74AC
	bool get_CanBeFunction() { }

	// RVA: 0x10F74B4
	void SkipSpace() { }

	// RVA: 0x10F5A94
	bool NextLex() { }

	// RVA: 0x10F7784
	Double ScanNumber() { }

	// RVA: 0x10F753C
	Double ScanFraction() { }

	// RVA: 0x10F7648
	string ScanString() { }

	// RVA: 0x10F794C
	string ScanName() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathSelectionIterator 
{
	// Fields
	private XPathNavigator _nav; // 0x18
	private Query _query; // 0x20
	private int _position; // 0x28

	// Methods

	// RVA: 0x10F7A0C
	void .ctor(XPathNavigator nav, Query query) { }

	// RVA: 0x10F7A80
	void .ctor(XPathSelectionIterator it) { }

	// RVA: 0x10F7BA4
	void Reset() { }

	// RVA: 0x10F7BC8
	bool MoveNext() { }

	// RVA: 0x10F7C60
	int get_Count() { }

	// RVA: 0x10F7C84
	XPathNavigator get_Current() { }

	// RVA: 0x10F7C8C
	int get_CurrentPosition() { }

	// RVA: 0x10F7C94
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathSelfQuery 
{
	// Methods

	// RVA: 0x10EDFA0
	void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x10F7CF8
	void .ctor(XPathSelfQuery other) { }

	// RVA: 0x10F7D00
	XPathNavigator Advance() { }

	// RVA: 0x10F7D98
	XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathSingletonIterator 
{
	// Fields
	private XPathNavigator _nav; // 0x18
	private int _position; // 0x20

	// Methods

	// RVA: 0x10F7E00
	void .ctor(XPathNavigator nav) { }

	// RVA: 0x10F7E3C
	void .ctor(XPathNavigator nav, bool moved) { }

	// RVA: 0x10F7E94
	void .ctor(XPathSingletonIterator it) { }

	// RVA: 0x10F7EFC
	XPathNodeIterator Clone() { }

	// RVA: 0x10F7FA0
	XPathNavigator get_Current() { }

	// RVA: 0x10F7FA8
	int get_CurrentPosition() { }

	// RVA: 0x10F7FB0
	int get_Count() { }

	// RVA: 0x10F7FB8
	bool MoveNext() { }

	// RVA: 0x10F7FE0
	void Reset() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathDocumentBaseIterator 
{
	// Fields
	protected XPathDocumentNavigator ctxt; // 0x18
	protected int pos; // 0x20

	// Methods

	// RVA: 0x10F7FE8
	void .ctor(XPathDocumentNavigator ctxt) { }

	// RVA: 0x10F8120
	void .ctor(XPathDocumentBaseIterator iter) { }

	// RVA: 0x10F81B4
	XPathNavigator get_Current() { }

	// RVA: 0x10F81BC
	int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentElementChildIterator 
{
	// Fields
	private string _localName; // 0x28
	private string _namespaceUri; // 0x30

	// Methods

	// RVA: 0x10F81C4
	void .ctor(XPathDocumentNavigator parent, string name, string namespaceURI) { }

	// RVA: 0x10F82EC
	void .ctor(XPathDocumentElementChildIterator iter) { }

	// RVA: 0x10F839C
	XPathNodeIterator Clone() { }

	// RVA: 0x10F8400
	bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentKindChildIterator 
{
	// Fields
	private XPathNodeType _typ; // 0x24

	// Methods

	// RVA: 0x10F8490
	void .ctor(XPathDocumentNavigator parent, XPathNodeType typ) { }

	// RVA: 0x10F8520
	void .ctor(XPathDocumentKindChildIterator iter) { }

	// RVA: 0x10F85B4
	XPathNodeIterator Clone() { }

	// RVA: 0x10F86A4
	bool MoveNext() { }

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

	// RVA: 0x10F8734
	void .ctor(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x10F88F4
	void .ctor(XPathDocumentElementDescendantIterator iter) { }

	// RVA: 0x10F89C0
	XPathNodeIterator Clone() { }

	// RVA: 0x10F8A24
	bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentKindDescendantIterator 
{
	// Fields
	private XPathDocumentNavigator _end; // 0x28
	private XPathNodeType _typ; // 0x30
	private bool _matchSelf; // 0x34

	// Methods

	// RVA: 0x10F8B94
	void .ctor(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf) { }

	// RVA: 0x10F8CC0
	void .ctor(XPathDocumentKindDescendantIterator iter) { }

	// RVA: 0x10F8D74
	XPathNodeIterator Clone() { }

	// RVA: 0x10F8DD8
	bool MoveNext() { }

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

	// RVA: 0x10F8F7C
	void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x10F8064
	void .ctor(XPathDocumentNavigator nav) { }

	// RVA: 0x10F9028
	string get_Value() { }

	// RVA: 0x10F9590
	XPathNavigator Clone() { }

	// RVA: 0x10F966C
	XPathNodeType get_NodeType() { }

	// RVA: 0x10F96B4
	string get_LocalName() { }

	// RVA: 0x10F9714
	string get_NamespaceURI() { }

	// RVA: 0x10F9774
	string get_Name() { }

	// RVA: 0x10F988C
	string get_Prefix() { }

	// RVA: 0x10F98EC
	string get_BaseURI() { }

	// RVA: 0x10F9A6C
	XmlNameTable get_NameTable() { }

	// RVA: 0x10F9AD4
	bool MoveToFirstAttribute() { }

	// RVA: 0x10F9BFC
	bool MoveToNextAttribute() { }

	// RVA: 0x10F9CDC
	bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x10F9F38
	bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x10FA338
	bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x10FA560
	bool MoveToNext() { }

	// RVA: 0x10FA630
	bool MoveToFirstChild() { }

	// RVA: 0x10FA808
	bool MoveToParent() { }

	// RVA: 0x10FA990
	bool MoveTo(XPathNavigator other) { }

	// RVA: 0x10FAA3C
	bool MoveToId(string id) { }

	// RVA: 0x10FAAE8
	bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x10FABA0
	void MoveToRoot() { }

	// RVA: 0x10FAC48
	bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x10FAE40
	bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x10FB024
	bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x10FB284
	bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x10FB420
	bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x10FBA04
	bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x10FBECC
	XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x10FBF90
	XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x10FC030
	XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x10FC0AC
	XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x10FC164
	XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x10FC3C8
	bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x10FC290
	int GetPrimaryLocation() { }

	// RVA: 0x10FC30C
	int GetSecondaryLocation() { }

	// RVA: 0x10FC548
	object get_UnderlyingObject() { }

	// RVA: 0x10FC558
	bool HasLineInfo() { }

	// RVA: 0x10FC5A0
	int get_LineNumber() { }

	// RVA: 0x10FC664
	int get_LinePosition() { }

	// RVA: 0x10FC788
	int GetPositionHashCode() { }

	// RVA: 0x10F8A98
	bool IsElementMatch(string localName, string namespaceURI) { }

	// RVA: 0x10F8EDC
	bool IsKindMatch(XPathNodeType typ) { }

	// RVA: 0x10FB5A0
	int GetFollowingEnd(XPathDocumentNavigator end, bool useParentOfVirtual, out XPathNode[] pageEnd) { }

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

	// RVA: 0x10F96A8
	XPathNodeType get_NodeType() { }

	// RVA: 0x10F98CC
	string get_Prefix() { }

	// RVA: 0x10F96F4
	string get_LocalName() { }

	// RVA: 0x10F9810
	string get_Name() { }

	// RVA: 0x10F9754
	string get_NamespaceUri() { }

	// RVA: 0x10F9AB4
	XPathDocument get_Document() { }

	// RVA: 0x10F9A0C
	string get_BaseUri() { }

	// RVA: 0x10FC638
	int get_LineNumber() { }

	// RVA: 0x10FC760
	int get_LinePosition() { }

	// RVA: 0x10FC730
	int get_CollapsedLinePosition() { }

	// RVA: 0x10FC7E4
	XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x10FAC20
	int GetRoot(out XPathNode[] pageNode) { }

	// RVA: 0x10F9A2C
	int GetParent(out XPathNode[] pageNode) { }

	// RVA: 0x10FA2F8
	int GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0x10FC804
	int GetSimilarElement(out XPathNode[] pageNode) { }

	// RVA: 0x10FC844
	bool NameMatch(string localName, string namespaceName) { }

	// RVA: 0x10FC794
	bool ElementMatch(string localName, string namespaceName) { }

	// RVA: 0x10FA26C
	bool get_IsXmlNamespaceNode() { }

	// RVA: 0x10FC884
	bool get_HasSibling() { }

	// RVA: 0x10FA6F0
	bool get_HasCollapsedText() { }

	// RVA: 0x10FC894
	bool get_HasAttribute() { }

	// RVA: 0x10FC8A0
	bool get_HasContentChild() { }

	// RVA: 0x10FC8AC
	bool get_HasElementChild() { }

	// RVA: 0x10FC8B8
	bool get_IsAttrNmsp() { }

	// RVA: 0x10FC8CC
	bool get_IsText() { }

	// RVA: 0x10FC95C
	bool get_HasNamespaceDecls() { }

	// RVA: 0x10FC968
	string get_Value() { }

}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNodeRef 
{
	// Fields
	private XPathNode[] _page; // 0x10
	private int _idx; // 0x18

	// Methods

	// RVA: 0x10FC970
	void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0x10FC99C
	XPathNode[] get_Page() { }

	// RVA: 0x10FC9A4
	int get_Index() { }

	// RVA: 0x10FC9AC
	int GetHashCode() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathNodeHelper 
{
	// Methods

	// RVA: 0x10FA0C0
	int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x10FA13C
	int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x10F9B78
	bool GetFirstAttribute(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x10F9C0C
	bool GetNextAttribute(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x10FA6FC
	bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x10FA570
	bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x10FA8F8
	bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x10FC50C
	int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x10FACE0
	bool GetElementChild(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	// RVA: 0x10FAED8
	bool GetElementSibling(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	// RVA: 0x10FB10C
	bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) { }

	// RVA: 0x10FB298
	bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) { }

	// RVA: 0x10F9DB8
	bool GetAttribute(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) { }

	// RVA: 0x10FB684
	bool GetElementFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName) { }

	// RVA: 0x10FBD30
	bool GetContentFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ) { }

	// RVA: 0x10F9348
	bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x10F9254
	bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x10FC9F0
	void GetChild(ref XPathNode[] pageNode, ref int idxNode) { }

}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodePageInfo 
{
	// Fields
	private int _pageNum; // 0x10
	private int _nodeCount; // 0x14
	private XPathNode[] _pageNext; // 0x18

	// Methods

	// RVA: 0x10FCA5C
	int get_PageNumber() { }

	// RVA: 0x10FCA64
	int get_NodeCount() { }

	// RVA: 0x10FCA6C
	XPathNode[] get_NextPage() { }

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

	// RVA: 0x10FCA74
	XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x10FCA7C
	string get_LocalName() { }

	// RVA: 0x10FCA84
	string get_NamespaceUri() { }

	// RVA: 0x10FCA8C
	string get_Prefix() { }

	// RVA: 0x10FCA94
	string get_BaseUri() { }

	// RVA: 0x10FCA9C
	XPathNode[] get_SiblingPage() { }

	// RVA: 0x10FCAA4
	XPathNode[] get_SimilarElementPage() { }

	// RVA: 0x10FCAAC
	XPathNode[] get_ParentPage() { }

	// RVA: 0x10FCAB4
	XPathDocument get_Document() { }

	// RVA: 0x10FCABC
	int get_LineNumberBase() { }

	// RVA: 0x10FCAC4
	int get_LinePositionBase() { }

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

	// RVA: 0x10FCACC
	UInt32 ComputeStringHash(string s) { }

}


