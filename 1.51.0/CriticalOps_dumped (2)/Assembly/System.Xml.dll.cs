// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0x1071C28
	internal static string GetString(string name, object[] args) { }

	// RVA: 0x1071C9C
	internal static string GetString(CultureInfo culture, string name, object[] args) { }

	// RVA: 0x1071CA4
	internal static string Format(string resourceFormat, object p1) { }

}

// Namespace: Microsoft.CSharp
internal class CodeDomProvider
{
	// Methods

	// RVA: 0x1071D18
	public void .ctor() { }

}

// Namespace: Microsoft.CSharp
internal class CSharpCodeProvider
{
	// Methods

	// RVA: 0x1071D20
	public void .ctor() { }

}

// Namespace: System
internal class MonoTODOAttribute
{
	// Methods

	// RVA: 0x1071D28
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

	// RVA: 0x1071D30
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

	// RVA: 0x1071E68
	internal void .ctor() { }

	// RVA: -1
	internal abstract void WriteChars(Char[] chars, int index, int count) { }

	// RVA: 0x1071ED8
	internal void Encode(Byte[] buffer, int index, int count) { }

	// RVA: 0x107227C
	internal void Flush() { }

}

// Namespace: System.Xml
internal class XmlRawWriterBase64Encoder
{
	// Fields
	private XmlRawWriter rawWriter; // 0x28

	// Methods

	// RVA: 0x1072328
	internal void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0x10723AC
	internal override void WriteChars(Char[] chars, int index, int count) { }

}

// Namespace: System.Xml
internal class XmlTextWriterBase64Encoder
{
	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0x10723D4
	internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0x1072458
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

	// RVA: 0x1072478
	internal override bool get_IsFull() { }

	// RVA: 0x1072488
	internal override int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0x107288C
	public static Byte[] Decode(Char[] chars, bool allowOddChars) { }

	// RVA: 0x1072600
	private static void Decode(Char* pChars, Char* pCharsEndPos, Byte* pBytes, Byte* pBytesEndPos, bool hasHalfByteCached, Byte cachedHalfByte, int charsDecoded, int bytesDecoded) { }

}

// Namespace: System.Xml
internal static class BinHexEncoder
{
	// Methods

	// RVA: 0x1072A78
	internal static void Encode(Byte[] buffer, int index, int count, XmlWriter writer) { }

	// RVA: 0x1072D84
	internal static string Encode(Byte[] inArray, int offsetIn, int count) { }

	// RVA: 0x1072C48
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

	// RVA: 0x1072EDC
	public bool get_IsPositive() { }

	// RVA: 0x1072EEC
	public void .ctor(Byte[] data, int offset, bool trim) { }

	// RVA: 0x107319C
	private static UInt32 UIntFromByteArray(Byte[] data, int offset) { }

	// RVA: 0x10733F8
	private static void MpDiv1(UInt32[] rgulU, int ciulU, UInt32 iulD, UInt32 iulR) { }

	// RVA: 0x1073530
	private static void MpNormalize(UInt32[] rgulU, int ciulU) { }

	// RVA: 0x1073584
	private static Char ChFromDigit(UInt32 uiDigit) { }

	// RVA: 0x1073590
	public Decimal ToDecimal() { }

	// RVA: 0x1073210
	private void TrimTrailingZeros() { }

	// RVA: 0x10736B8
	public override string ToString() { }

	// RVA: 0x1073BD0
	private static void .cctor() { }

}

// Namespace: System.Xml
internal struct BinXmlSqlMoney
{
	// Fields
	private Int64 data; // 0x10

	// Methods

	// RVA: 0x1073D18
	public void .ctor(int v) { }

	// RVA: 0x1073D24
	public void .ctor(Int64 v) { }

	// RVA: 0x1073D2C
	public Decimal ToDecimal() { }

	// RVA: 0x1073DA0
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

	// RVA: 0x1073EBC
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x1073F2C
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x1074088
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x1074144
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x1074284
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x10744C4
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x1074778
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x10748A0
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x10749D8
	private static void BreakDownXsdDateTime(Int64 val, int yr, int mnth, int day, int hr, int min, int sec, int ms) { }

	// RVA: 0x1074BA4
	private static void BreakDownXsdDate(Int64 val, int yr, int mnth, int day, bool negTimeZone, int hr, int min) { }

	// RVA: 0x1074D10
	private static void BreakDownXsdTime(Int64 val, int hr, int min, int sec, int ms) { }

	// RVA: 0x1074E20
	public static string XsdDateTimeToString(Int64 val) { }

	// RVA: 0x1074F38
	public static string XsdDateToString(Int64 val) { }

	// RVA: 0x1075028
	public static string XsdTimeToString(Int64 val) { }

	// RVA: 0x10751F0
	public static string SqlDateTimeToString(int dateticks, UInt32 timeticks) { }

	// RVA: 0x1075348
	public static DateTime SqlDateTimeToDateTime(int dateticks, UInt32 timeticks) { }

	// RVA: 0x1075448
	public static string SqlSmallDateTimeToString(Int16 dateticks, UInt16 timeticks) { }

	// RVA: 0x10755A8
	public static DateTime SqlSmallDateTimeToDateTime(Int16 dateticks, UInt16 timeticks) { }

	// RVA: 0x107561C
	public static DateTime XsdKatmaiDateToDateTime(Byte[] data, int offset) { }

	// RVA: 0x107577C
	public static DateTime XsdKatmaiDateTimeToDateTime(Byte[] data, int offset) { }

	// RVA: 0x1075AAC
	public static DateTime XsdKatmaiTimeToDateTime(Byte[] data, int offset) { }

	// RVA: 0x1075B38
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x1075BC4
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x1075D60
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(Byte[] data, int offset) { }

	// RVA: 0x1075DEC
	public static string XsdKatmaiDateToString(Byte[] data, int offset) { }

	// RVA: 0x1075F14
	public static string XsdKatmaiDateTimeToString(Byte[] data, int offset) { }

	// RVA: 0x10761B4
	public static string XsdKatmaiTimeToString(Byte[] data, int offset) { }

	// RVA: 0x1076338
	public static string XsdKatmaiDateOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x10764C4
	public static string XsdKatmaiDateTimeOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x10767A8
	public static string XsdKatmaiTimeOffsetToString(Byte[] data, int offset) { }

	// RVA: 0x1075704
	private static Int64 GetKatmaiDateTicks(Byte[] data, int pos) { }

	// RVA: 0x1075880
	private static Int64 GetKatmaiTimeTicks(Byte[] data, int pos) { }

	// RVA: 0x1075D08
	private static Int64 GetKatmaiTimeZoneTicks(Byte[] data, int pos) { }

	// RVA: 0x107609C
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x1076664
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x1076944
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

	// RVA: 0x107D294
	public void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0x107BAEC
	public void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0x1077088
	public void Clear() { }

	// RVA: 0x107CA68
	public bool MatchNs(string lname, string nsUri) { }

	// RVA: 0x107CAB8
	public bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0x107CEB4
	public void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0x1081548
	public override int GetHashCode() { }

	// RVA: 0x1081598
	public int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0x10815F0
	public override bool Equals(object other) { }

	// RVA: 0x107E3EC
	public override string ToString() { }

	// RVA: 0x10816AC
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

	// RVA: 0x107F904
	public void Set(QName name, bool xmlspacePreserve) { }

	// RVA: 0x107E694
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

	// RVA: 0x107D2E4
	public void Set(QName n, string v) { }

	// RVA: 0x107D958
	public void Set(QName n, int pos) { }

	// RVA: 0x107E35C
	public void GetLocalnameAndNamespaceUri(string localname, string namespaceUri) { }

	// RVA: 0x107E460
	public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, string localname, string namespaceUri) { }

	// RVA: 0x107E39C
	public bool MatchNS(string localname, string namespaceUri) { }

	// RVA: 0x107E4E0
	public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

	// RVA: 0x107C084
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

	// RVA: 0x107B4F4
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

	// RVA: 0x1076FB0
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

	// RVA: 0x107F954
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

	// RVA: 0x1076A0C
	public void .ctor(Stream stream, Byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0x1077D74
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1077E9C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1077EA4
	public override string get_LocalName() { }

	// RVA: 0x1077EAC
	public override string get_NamespaceURI() { }

	// RVA: 0x1077EB4
	public override string get_Prefix() { }

	// RVA: 0x1077EBC
	public override string get_Value() { }

	// RVA: 0x1078DA4
	public override int get_Depth() { }

	// RVA: 0x1078E80
	public override string get_BaseURI() { }

	// RVA: 0x1078E88
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1078EAC
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1078F34
	public override string get_XmlLang() { }

	// RVA: 0x1078FCC
	public override Type get_ValueType() { }

	// RVA: 0x1078FD4
	public override int get_AttributeCount() { }

	// RVA: 0x1079030
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0x1079284
	public override string GetAttribute(string name) { }

	// RVA: 0x107940C
	public override string GetAttribute(int i) { }

	// RVA: 0x10794AC
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1079650
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1079704
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1079798
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1079830
	public override bool MoveToElement() { }

	// RVA: 0x1079920
	public override bool get_EOF() { }

	// RVA: 0x1079930
	public override bool ReadAttributeValue() { }

	// RVA: 0x1079DE4
	public override void Close() { }

	// RVA: 0x1079E88
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1079E90
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1079F6C
	public override void ResolveEntity() { }

	// RVA: 0x1079FAC
	public override ReadState get_ReadState() { }

	// RVA: 0x107A050
	public override bool Read() { }

	// RVA: 0x107ADF8
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x107B238
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x107B410
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0x10770E0
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0x107B590
	private void AddName() { }

	// RVA: 0x107B788
	private void AddQName() { }

	// RVA: 0x107BB3C
	private void NameFlush() { }

	// RVA: 0x107BB98
	private void SkipExtn() { }

	// RVA: 0x107BD74
	private int ReadQNameRef() { }

	// RVA: 0x107BA44
	private int ReadNameRef() { }

	// RVA: 0x107BE1C
	private bool FillAllowEOF() { }

	// RVA: 0x107C098
	private void Fill_(int require) { }

	// RVA: 0x107BCE4
	private void Fill(int require) { }

	// RVA: 0x107C18C
	private Byte ReadByte() { }

	// RVA: 0x107C23C
	private UInt16 ReadUShort() { }

	// RVA: 0x107BCA8
	private int ParseMB32() { }

	// RVA: 0x107C30C
	private int ParseMB32_(Byte b) { }

	// RVA: 0x107C3B4
	private int ParseMB32(int pos) { }

	// RVA: 0x107C4BC
	private int ParseMB64() { }

	// RVA: 0x107C4F8
	private BinXmlToken PeekToken() { }

	// RVA: 0x107C574
	private BinXmlToken ReadToken() { }

	// RVA: 0x107C5F8
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0x107C704
	private BinXmlToken NextToken1() { }

	// RVA: 0x107C7F4
	private BinXmlToken NextToken() { }

	// RVA: 0x107C85C
	private BinXmlToken PeekNextToken() { }

	// RVA: 0x1079B10
	private BinXmlToken RescanNextToken() { }

	// RVA: 0x107B6BC
	private string ParseText() { }

	// RVA: 0x107C8DC
	private int ScanText(int start) { }

	// RVA: 0x1077FFC
	private string GetString(int pos, int cch) { }

	// RVA: 0x107CA28
	private string GetStringAligned(Byte[] data, int offset, int cch) { }

	// RVA: 0x1078C40
	private string GetAttributeText(int i) { }

	// RVA: 0x10791BC
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0x1079304
	private int LocateAttribute(string name) { }

	// RVA: 0x1079564
	private void PositionOnAttribute(int i) { }

	// RVA: 0x107CB04
	private void GrowElements() { }

	// RVA: 0x107CB94
	private void GrowAttributes() { }

	// RVA: 0x107CC2C
	private void ClearAttributes() { }

	// RVA: 0x107CC3C
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0x107CFB0
	private void PopNamespaces(NamespaceDecl firstInScopeChain) { }

	// RVA: 0x107D088
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0x107A240
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0x107D334
	private void ScanAttributes() { }

	// RVA: 0x107DD74
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0x107DF0C
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0x1078324
	private string XmlDeclValue() { }

	// RVA: 0x1078160
	private string CDATAValue() { }

	// RVA: 0x107E53C
	private void FinishCDATA() { }

	// RVA: 0x107E628
	private void FinishEndElement() { }

	// RVA: 0x107A86C
	private bool ReadDoc() { }

	// RVA: 0x107F6B0
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0x107E6C0
	private void ImplReadElement() { }

	// RVA: 0x107EA3C
	private void ImplReadEndElement() { }

	// RVA: 0x107EB20
	private void ImplReadDoctype() { }

	// RVA: 0x107EF1C
	private void ImplReadPI() { }

	// RVA: 0x107EF8C
	private void ImplReadComment() { }

	// RVA: 0x107EFC4
	private void ImplReadCDATA() { }

	// RVA: 0x107F050
	private void ImplReadNest() { }

	// RVA: 0x107F168
	private void ImplReadEndNest() { }

	// RVA: 0x107F1C4
	private void ImplReadXmlText() { }

	// RVA: 0x107F9B0
	private void UpdateFromTextReader() { }

	// RVA: 0x107953C
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0x107F888
	private void CheckAllowContent() { }

	// RVA: 0x1077200
	private void GenerateTokenTypeMap() { }

	// RVA: 0x1079CE4
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0x1079CD8
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0x107DA98
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x107FD30
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x107FA88
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0x107FC8C
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0x1080274
	private void CheckValueTokenBounds() { }

	// RVA: 0x108011C
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0x10802E0
	private int XsdKatmaiTimeScaleToValueLength(Byte scale) { }

	// RVA: 0x10803B4
	private Int64 ValueAsLong() { }

	// RVA: 0x1080D34
	private UInt64 ValueAsULong() { }

	// RVA: 0x1080AEC
	private Decimal ValueAsDecimal() { }

	// RVA: 0x1080974
	private Double ValueAsDouble() { }

	// RVA: 0x1080F20
	private string ValueAsDateTimeString() { }

	// RVA: 0x10784DC
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0x1080644
	private Int16 GetInt16(int pos) { }

	// RVA: 0x10807DC
	private UInt16 GetUInt16(int pos) { }

	// RVA: 0x1080690
	private int GetInt32(int pos) { }

	// RVA: 0x1080828
	private UInt32 GetUInt32(int pos) { }

	// RVA: 0x1080708
	private Int64 GetInt64(int pos) { }

	// RVA: 0x10808A0
	private UInt64 GetUInt64(int pos) { }

	// RVA: 0x1080DCC
	private float GetSingle(int offset) { }

	// RVA: 0x1080E48
	private Double GetDouble(int offset) { }

	// RVA: 0x107B454
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0x107C114
	private Exception ThrowXmlException(string res) { }

	// RVA: 0x107D9A8
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0x107DCF0
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0x10813C4
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

	// RVA: 0x1081710
	public void .ctor() { }

	// RVA: 0x108173C
	public void PushBit(bool bit) { }

	// RVA: 0x10818A0
	public bool PopBit() { }

	// RVA: 0x1081948
	public bool PeekBit() { }

	// RVA: 0x108178C
	private void PushCurr() { }

	// RVA: 0x1081900
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

	// RVA: 0x1081954
	public static int Count(UInt32 num) { }

	// RVA: 0x10819FC
	public static int LeastPosition(UInt32 num) { }

	// RVA: 0x1081B18
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

	// RVA: 0x1081B74
	public void .ctor(int growthRate) { }

	// RVA: 0x1081BF4
	public void Push(Byte data) { }

	// RVA: 0x1081CF4
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

	// RVA: 0x1081D44
	internal void .ctor() { }

	// RVA: 0x1081D4C
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x1081E7C
	public override int get_MaxCharCount() { }

	// RVA: 0x1081E84
	internal void set_StartOffset(int value) { }

	// RVA: 0x1081E8C
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x1081EBC
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

	// RVA: 0x1081E20
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x1081F48
	public override bool Fallback(Char charUnknown, int index) { }

	// RVA: 0x10821A4
	public override bool Fallback(Char charUnknownHigh, Char charUnknownLow, int index) { }

	// RVA: 0x10824B8
	public override Char GetNextChar() { }

	// RVA: 0x1082514
	public override bool MovePrevious() { }

	// RVA: 0x1082530
	public override int get_Remaining() { }

	// RVA: 0x108256C
	public override void Reset() { }

	// RVA: 0x10824AC
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

	// RVA: 0x1082578
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x10827AC
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x10827DC
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x10827E0
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x10827E4
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1082A74
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1082BAC
	internal override void StartElementContent() { }

	// RVA: 0x1082D2C
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1082E6C
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1082FAC
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1083138
	public override void WriteEndAttribute() { }

	// RVA: 0x108327C
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x10833C0
	public override void WriteString(string text) { }

	// RVA: 0x1083510
	public override void WriteEntityRef(string name) { }

	// RVA: 0x108356C
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x10835C8
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1083624
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x10825A8
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1082C04
	protected void WriteMetaElement() { }

	// RVA: 0x10834F8
	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10834B4
	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1083A08
	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10836B8
	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10831E4
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

	// RVA: 0x1083C5C
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1083CF8
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1083D50
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1083D78
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1084000
	internal override void StartElementContent() { }

	// RVA: 0x10840B8
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x10841A8
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x108425C
	protected override void FlushBuffer() { }

	// RVA: 0x1083CB4
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1083FAC
	private void WriteIndent() { }

}

// Namespace: System.Xml
internal abstract class HtmlTernaryTree
{
	// Fields
	internal static Byte[] htmlElements; // 0x0
	internal static Byte[] htmlAttributes; // 0x8

	// Methods

	// RVA: 0x108428C
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

	// RVA: 0x108437C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x10845B0
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x10845B4
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x10845B8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1084858
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1084970
	internal override void StartElementContent() { }

	// RVA: 0x1084AF4
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1084C1C
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1084D44
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1084EC0
	public override void WriteEndAttribute() { }

	// RVA: 0x1085000
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1085124
	public override void WriteString(string text) { }

	// RVA: 0x1085254
	public override void WriteEntityRef(string name) { }

	// RVA: 0x10852B0
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x108530C
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1085368
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x10843AC
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x10849CC
	protected void WriteMetaElement() { }

	// RVA: 0x108523C
	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10851F8
	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10856E8
	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x10853B0
	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1084F38
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

	// RVA: 0x1182430
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x11824C0
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11824EC
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11828B8
	internal override void StartElementContent() { }

	// RVA: 0x1182978
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1182A70
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1182B28
	protected override void FlushBuffer() { }

	// RVA: 0x118247C
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1182864
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

	// RVA: 0x1182B58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1182C78
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

	// RVA: 0x1182C8C
	protected void .ctor() { }

}

// Namespace: System.Xml
internal class IncrementalReadDummyDecoder
{
	// Methods

	// RVA: 0x1182C94
	internal override bool get_IsFull() { }

	// RVA: 0x1182C9C
	internal override int Decode(Char[] chars, int startPos, int len) { }

	// RVA: 0x1182CA4
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

	// RVA: 0x1182CAC
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x118305C
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x11830A4
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11830CC
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11830F4
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1183130
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1183308
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1183378
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11833E8
	internal override void StartElementContent() { }

	// RVA: 0x1183410
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x118343C
	public override void WriteEndAttribute() { }

	// RVA: 0x1183468
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1183490
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x11834B8
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x11834E0
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1183508
	public override void WriteCData(string text) { }

	// RVA: 0x1183530
	public override void WriteComment(string text) { }

	// RVA: 0x118355C
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1183588
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1183678
	public override void WriteString(string text) { }

	// RVA: 0x1183714
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11837E4
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1183810
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x118383C
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1183868
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1183938
	public override void WriteRaw(string data) { }

	// RVA: 0x11839D4
	public override void Close() { }

	// RVA: 0x1183A7C
	public override void Flush() { }

	// RVA: 0x1183624
	private bool StartCDataSection() { }

	// RVA: 0x1183300
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

	// RVA: 0x1183AA4
	internal void Finish() { }

	// RVA: 0x1183D78
	internal void Reset() { }

	// RVA: 0x1183BF0
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

	// RVA: 0x1183D84
	public void .ctor(Byte[] nodeBuffer) { }

	// RVA: 0x1182700
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

	// RVA: 0x1184120
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11841DC
	public virtual int Invoke(string s, int sLen, Int64 additionalEntropy) { }

}

// Namespace: System.Xml
internal class SecureStringHasher
{
	// Fields
	private static HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x1183DB8
	public void .ctor() { }

	// RVA: 0x1183DE8
	public bool Equals(string x, string y) { }

	// RVA: 0x1183DFC
	public int GetHashCode(string key) { }

	// RVA: 0x11840AC
	private static int GetHashCodeOfString(string key, int sLen, Int64 additionalEntropy) { }

	// RVA: 0x1183EC4
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

}

// Namespace: System.Xml
internal class TextEncodedRawTextWriter
{
	// Methods

	// RVA: 0x11841F0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11842F4
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1184624
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1184628
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x118462C
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1184630
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1184634
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1184638
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x118463C
	internal override void StartElementContent() { }

	// RVA: 0x1184640
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x118464C
	public override void WriteEndAttribute() { }

	// RVA: 0x1184654
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1184658
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1184660
	public override void WriteCData(string text) { }

	// RVA: 0x1184720
	public override void WriteComment(string text) { }

	// RVA: 0x1184724
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1184728
	public override void WriteEntityRef(string name) { }

	// RVA: 0x118472C
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1184730
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1184734
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1184744
	public override void WriteString(string textBlock) { }

	// RVA: 0x1184754
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1184834
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1184844
	public override void WriteRaw(string data) { }

}

// Namespace: System.Xml
internal class TextUtf8RawTextWriter
{
	// Methods

	// RVA: 0x1184854
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x118485C
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1184860
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1184864
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1184868
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x118486C
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1184870
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1184874
	internal override void StartElementContent() { }

	// RVA: 0x1184878
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1184884
	public override void WriteEndAttribute() { }

	// RVA: 0x118488C
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1184890
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1184898
	public override void WriteCData(string text) { }

	// RVA: 0x11848A0
	public override void WriteComment(string text) { }

	// RVA: 0x11848A4
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11848A8
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11848AC
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x11848B0
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11848B4
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11848C8
	public override void WriteString(string textBlock) { }

	// RVA: 0x11848DC
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11848F0
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1184904
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

	// RVA: 0x1184918
	public void .ctor() { }

	// RVA: 0x11849F0
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x1184A20
	public string get_LocalName() { }

	// RVA: 0x1184A28
	public void set_LocalName(string value) { }

	// RVA: 0x1184A30
	public string get_Namespace() { }

	// RVA: 0x1184A38
	public void set_Namespace(string value) { }

	// RVA: 0x1184A40
	public string get_Prefix() { }

	// RVA: 0x1184A48
	public void set_Prefix(string value) { }

	// RVA: 0x1184A50
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x1184B14
	public int get_Depth() { }

	// RVA: 0x1184B1C
	public void set_Depth(int value) { }

	// RVA: 0x1184B24
	public string get_RawValue() { }

	// RVA: 0x1184B2C
	public void set_RawValue(string value) { }

	// RVA: 0x1184B34
	public string get_OriginalStringValue() { }

	// RVA: 0x1184B3C
	public XmlNodeType get_NodeType() { }

	// RVA: 0x1184B44
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x1184B4C
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x1184B54
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x1184B5C
	public int get_LineNumber() { }

	// RVA: 0x1184B64
	public int get_LinePosition() { }

	// RVA: 0x1184944
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0x1184B6C
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1184B74
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0x1184C88
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0x1184D00
	internal void SetItemData(string value) { }

	// RVA: 0x1184D34
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

	// RVA: 0x1184D68
	internal XmlReader get_CoreReader() { }

	// RVA: 0x1184D70
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0x1185228
	public void .ctor(XmlReader reader) { }

	// RVA: 0x11852E4
	private void CheckAsync() { }

	// RVA: 0x1185364
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x118557C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11855B0
	public override string get_Name() { }

	// RVA: 0x11855E4
	public override string get_LocalName() { }

	// RVA: 0x1185618
	public override string get_NamespaceURI() { }

	// RVA: 0x118564C
	public override string get_Prefix() { }

	// RVA: 0x1185680
	public override string get_Value() { }

	// RVA: 0x11856B4
	public override int get_Depth() { }

	// RVA: 0x11856E8
	public override string get_BaseURI() { }

	// RVA: 0x1185720
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1185758
	public override bool get_IsDefault() { }

	// RVA: 0x1185790
	public override Char get_QuoteChar() { }

	// RVA: 0x11857C8
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1185800
	public override string get_XmlLang() { }

	// RVA: 0x1185838
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1185870
	public override Type get_ValueType() { }

	// RVA: 0x11858A8
	public override int get_AttributeCount() { }

	// RVA: 0x11858E0
	public override string GetAttribute(string name) { }

	// RVA: 0x1185920
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1185970
	public override string GetAttribute(int i) { }

	// RVA: 0x11859B0
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11859F0
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1185A30
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1185A68
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1185AA0
	public override bool MoveToElement() { }

	// RVA: 0x1185AD8
	public override bool ReadAttributeValue() { }

	// RVA: 0x1185B10
	public override bool Read() { }

	// RVA: 0x1185B48
	public override bool get_EOF() { }

	// RVA: 0x1185B80
	public override void Close() { }

	// RVA: 0x1185BB8
	public override ReadState get_ReadState() { }

	// RVA: 0x1185BF0
	public override void Skip() { }

	// RVA: 0x1185C28
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1185C60
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1185CA0
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1185CD8
	public override void ResolveEntity() { }

	// RVA: 0x1185D10
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1185D48
	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x1185DA0
	public override string ReadString() { }

	// RVA: 0x1185DD8
	public override XmlNodeType MoveToContent() { }

	// RVA: 0x1185E10
	public override void ReadStartElement() { }

	// RVA: 0x1185E48
	public override string ReadElementString() { }

	// RVA: 0x1185E80
	public override void ReadEndElement() { }

	// RVA: 0x1185EB8
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0x1185F08
	public override string ReadInnerXml() { }

	// RVA: 0x1185F40
	public override bool get_HasAttributes() { }

	// RVA: 0x1185F78
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1185FC8
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1186000
	internal override IDtdInfo get_DtdInfo() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithNS
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0x118516C
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1186038
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11860EC
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11861A4
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfo
{
	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Methods

	// RVA: 0x11850B0
	public void .ctor(XmlReader reader) { }

	// RVA: 0x118625C
	public virtual bool HasLineInfo() { }

	// RVA: 0x1186310
	public virtual int get_LineNumber() { }

	// RVA: 0x11863C8
	public virtual int get_LinePosition() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNS
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0x1184FF4
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1186480
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1186534
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11865EC
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNSSchema
{
	// Fields
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; // 0x30

	// Methods

	// RVA: 0x1184F38
	public void .ctor(XmlReader reader) { }

	// RVA: 0x11866A4
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1186758
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1186810
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x11868C8
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x1186980
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x1186A38
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x1186AF0
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

}

// Namespace: System.Xml
internal class XmlAsyncCheckWriter
{
	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Methods

	// RVA: 0x1186BA8
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x1186C38
	private void CheckAsync() { }

	// RVA: 0x1186CB8
	public override void WriteStartDocument() { }

	// RVA: 0x1186CEC
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1186D28
	public override void WriteEndDocument() { }

	// RVA: 0x1186D5C
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1186DC0
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1186E14
	public override void WriteEndElement() { }

	// RVA: 0x1186E48
	public override void WriteFullEndElement() { }

	// RVA: 0x1186E7C
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1186ED0
	public override void WriteEndAttribute() { }

	// RVA: 0x1186F08
	public override void WriteCData(string text) { }

	// RVA: 0x1186F48
	public override void WriteComment(string text) { }

	// RVA: 0x1186F88
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1186FD8
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1187018
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1187058
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1187098
	public override void WriteString(string text) { }

	// RVA: 0x11870D8
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1187128
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1187180
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11871D8
	public override void WriteRaw(string data) { }

	// RVA: 0x1187218
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1187270
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x11872C8
	public override WriteState get_WriteState() { }

	// RVA: 0x1187300
	public override void Close() { }

	// RVA: 0x1187338
	public override void Flush() { }

	// RVA: 0x1187370
	public override string LookupPrefix(string ns) { }

	// RVA: 0x11873B0
	public override void WriteValue(string value) { }

	// RVA: 0x11873F0
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1187440
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1187490
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

	// RVA: 0x11874C0
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0x11875E4
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0x1187618
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0x118764C
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11876D0
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11879D8
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1187A3C
	public override void WriteEndAttribute() { }

	// RVA: 0x1187A64
	public override void WriteCData(string text) { }

	// RVA: 0x1187B58
	public override void WriteComment(string text) { }

	// RVA: 0x1187B8C
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1187BC0
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1187BF4
	public override void WriteString(string text) { }

	// RVA: 0x1187C74
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1187CB0
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1187CEC
	public override void WriteRaw(string data) { }

	// RVA: 0x1187D6C
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1187DBC
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x1187E0C
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1187E6C
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x1187ED4
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1187F3C
	public override void Close() { }

	// RVA: 0x1187F84
	public override void Flush() { }

	// RVA: 0x1187FCC
	public override void WriteValue(string value) { }

	// RVA: 0x118801C
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1188078
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x11880C8
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1188118
	internal override void StartElementContent() { }

	// RVA: 0x1188140
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1188168
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1188190
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x11881F0
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1188218
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1188268
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1187754
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0x11876C0
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0x1187AE4
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0x1187860
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

	// RVA: 0x1188A04
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x11841F4
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11842F8
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1188E30
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1189168
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x11891F0
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1189520
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1189668
	internal override void StartElementContent() { }

	// RVA: 0x11896B0
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x11898A0
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1189A28
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1189BC8
	public override void WriteEndAttribute() { }

	// RVA: 0x1189C8C
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x1189CE4
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1189CEC
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1189F14
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1189FD8
	public override void WriteCData(string text) { }

	// RVA: 0x118A5D0
	public override void WriteComment(string text) { }

	// RVA: 0x118AB14
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x118ACB0
	public override void WriteEntityRef(string name) { }

	// RVA: 0x118ADE4
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x118B014
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x118B6F4
	public override void WriteString(string text) { }

	// RVA: 0x118B7C0
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x118B978
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1184764
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1184664
	public override void WriteRaw(string data) { }

	// RVA: 0x118BCFC
	public override void Close() { }

	// RVA: 0x118BE2C
	public override void Flush() { }

	// RVA: 0x118BE9C
	protected virtual void FlushBuffer() { }

	// RVA: 0x118C0E0
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x118BD84
	private void FlushEncoder() { }

	// RVA: 0x118B0DC
	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x118B3D4
	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x1189128
	protected void RawText(string s) { }

	// RVA: 0x118C610
	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x118BA58
	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x118A750
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x118A20C
	protected void WriteCDataSection(string text) { }

	// RVA: 0x118C30C
	private static Char* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	// RVA: 0x118C468
	private Char* InvalidXmlChar(int ch, Char* pDst, bool entitize) { }

	// RVA: 0x118C8BC
	internal void EncodeChar(Char* pSrc, Char* pSrcEnd, Char* pDst) { }

	// RVA: 0x11890AC
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x118C994
	private void GrowTextContentMarks() { }

	// RVA: 0x118C58C
	protected Char* WriteNewLine(Char* pDst) { }

	// RVA: 0x118C248
	protected static Char* LtEntity(Char* pDst) { }

	// RVA: 0x118C260
	protected static Char* GtEntity(Char* pDst) { }

	// RVA: 0x118C224
	protected static Char* AmpEntity(Char* pDst) { }

	// RVA: 0x118C278
	protected static Char* QuoteEntity(Char* pDst) { }

	// RVA: 0x118C2A0
	protected static Char* TabEntity(Char* pDst) { }

	// RVA: 0x118C2E8
	protected static Char* LineFeedEntity(Char* pDst) { }

	// RVA: 0x118C2C4
	protected static Char* CarriageReturnEntity(Char* pDst) { }

	// RVA: 0x118C7F4
	private static Char* CharEntity(Char* pDst, Char ch) { }

	// RVA: 0x118C7C0
	protected static Char* RawStartCData(Char* pDst) { }

	// RVA: 0x118C7A4
	protected static Char* RawEndCData(Char* pDst) { }

	// RVA: 0x1188B10
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

	// RVA: 0x118CA1C
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x118CB68
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x118CB94
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x118CC8C
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x118CD04
	internal override void StartElementContent() { }

	// RVA: 0x118CD8C
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x118CD94
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x118CE1C
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x118CEA4
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x118CEEC
	public override void WriteCData(string text) { }

	// RVA: 0x118CEF8
	public override void WriteComment(string text) { }

	// RVA: 0x118CF50
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x118CFA4
	public override void WriteEntityRef(string name) { }

	// RVA: 0x118CFB0
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x118CFBC
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x118CFC8
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x118CFD4
	public override void WriteString(string text) { }

	// RVA: 0x118CFE0
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x118CFEC
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x118CFF8
	public override void WriteRaw(string data) { }

	// RVA: 0x118D004
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x118CA48
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x118CC00
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

	// RVA: 0x118E470
	public void InitEvent(XmlEventType eventType) { }

	// RVA: 0x118E350
	public void InitEvent(XmlEventType eventType, string s1) { }

	// RVA: 0x118E360
	public void InitEvent(XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x118E39C
	public void InitEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x118E3F4
	public void InitEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x118E460
	public void InitEvent(XmlEventType eventType, object o) { }

	// RVA: 0x118E478
	public XmlEventType get_EventType() { }

	// RVA: 0x118E480
	public string get_String1() { }

	// RVA: 0x118E488
	public string get_String2() { }

	// RVA: 0x118E490
	public string get_String3() { }

	// RVA: 0x118E498
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

	// RVA: 0x118759C
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x1188290
	public void EndEvents() { }

	// RVA: 0x11882EC
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x118D1B4
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x118D274
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x118D394
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x118D420
	public override void WriteEndAttribute() { }

	// RVA: 0x118D46C
	public override void WriteCData(string text) { }

	// RVA: 0x118D524
	public override void WriteComment(string text) { }

	// RVA: 0x118D57C
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x118D66C
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x118D6C4
	public override void WriteString(string text) { }

	// RVA: 0x118D740
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x118D77C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x118D7B8
	public override void WriteRaw(string data) { }

	// RVA: 0x118D810
	public override void WriteEntityRef(string name) { }

	// RVA: 0x118D868
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x118D948
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x118DA0C
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x118DBBC
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x118DCB4
	public override void Close() { }

	// RVA: 0x118DD00
	public override void Flush() { }

	// RVA: 0x118DD4C
	public override void WriteValue(string value) { }

	// RVA: 0x118DD5C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x118DE68
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x118DF14
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x118DF6C
	internal override void StartElementContent() { }

	// RVA: 0x118DFB8
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x118E044
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x118E0D0
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x118E148
	internal override void WriteEndBase64() { }

	// RVA: 0x118D168
	private void AddEvent(XmlEventType eventType) { }

	// RVA: 0x118D4C4
	private void AddEvent(XmlEventType eventType, string s1) { }

	// RVA: 0x118D5F4
	private void AddEvent(XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x118D300
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x118D1CC
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x118D8E8
	private void AddEvent(XmlEventType eventType, object o) { }

	// RVA: 0x118E194
	private int NewEvent() { }

	// RVA: 0x118DB04
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

	// RVA: 0x118E4A0
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x118E4EC
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x118E51C
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x118E840
	public XmlNameTable get_NameTable() { }

	// RVA: 0x118E848
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x118E850
	public string get_DocTypeName() { }

	// RVA: 0x118E858
	public string get_PublicId() { }

	// RVA: 0x118E860
	public string get_SystemId() { }

	// RVA: 0x118E868
	public string get_BaseURI() { }

	// RVA: 0x118E870
	public string get_InternalSubset() { }

	// RVA: 0x118E878
	public string get_XmlLang() { }

	// RVA: 0x118E880
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x118E888
	public Encoding get_Encoding() { }

	// RVA: 0x118E890
	internal bool get_HasDtdInfo() { }

}

// Namespace: System.Xml
internal abstract class XmlRawWriter
{
	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Methods

	// RVA: 0x118E910
	public override void WriteStartDocument() { }

	// RVA: 0x118E96C
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x118E9C8
	public override void WriteEndDocument() { }

	// RVA: 0x118EA24
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x118EA28
	public override void WriteEndElement() { }

	// RVA: 0x118EA84
	public override void WriteFullEndElement() { }

	// RVA: 0x118D0B8
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x118EAE0
	public override string LookupPrefix(string ns) { }

	// RVA: 0x118EB3C
	public override WriteState get_WriteState() { }

	// RVA: 0x118EB98
	public override void WriteCData(string text) { }

	// RVA: 0x118EBA8
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x118EC40
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x118ECF0
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x118ED00
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x118ED3C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x118ED78
	public override void WriteRaw(string data) { }

	// RVA: 0x118ED88
	public override void WriteValue(string value) { }

	// RVA: 0x118ED98
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x118EDF4
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x118EE50
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x118EE58
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x118EE5C
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	// RVA: -1
	internal abstract void StartElementContent() { }

	// RVA: 0x118EE60
	internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: -1
	internal abstract void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x118EE64
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x118EE74
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x118EE7C
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x118EEBC
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0x118EEFC
	internal virtual void WriteEndBase64() { }

	// RVA: 0x118EF1C
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x1183054
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

	// RVA: 0x118EF2C
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x118EF34
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

	// RVA: 0x118F01C
	public virtual bool get_IsDefault() { }

	// RVA: 0x118F024
	public virtual Char get_QuoteChar() { }

	// RVA: 0x118F02C
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x118F034
	public virtual string get_XmlLang() { }

	// RVA: 0x118F04C
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x118F0A0
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

	// RVA: 0x118F0F0
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

	// RVA: 0x118F1BC
	public virtual void Close() { }

	// RVA: -1
	public abstract ReadState get_ReadState() { }

	// RVA: 0x118F1C0
	public virtual void Skip() { }

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: -1
	public abstract string LookupNamespace(string prefix) { }

	// RVA: 0x118F388
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1
	public abstract void ResolveEntity() { }

	// RVA: 0x118F390
	public virtual bool get_CanReadValueChunk() { }

	// RVA: 0x118F398
	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x118F3F4
	public virtual string ReadString() { }

	// RVA: 0x118F690
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0x118F730
	public virtual void ReadStartElement() { }

	// RVA: 0x118F828
	public virtual string ReadElementString() { }

	// RVA: 0x118FA98
	public virtual void ReadEndElement() { }

	// RVA: 0x118FB90
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0x118FC20
	public virtual string ReadInnerXml() { }

	// RVA: 0x11900A8
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0x118FF8C
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0x118FF14
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0x119050C
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0x1190644
	public virtual bool get_HasAttributes() { }

	// RVA: 0x1185FB4
	public void Dispose() { }

	// RVA: 0x119066C
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x11906C0
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x118F620
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0x11906C8
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0x118F2B0
	private bool SkipSubtree() { }

	// RVA: 0x1190738
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x1190840
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0x1190848
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1190A9C
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1190C50
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0x1190FD8
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x11852DC
	protected void .ctor() { }

	// RVA: 0x11911C4
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

	// RVA: 0x11854F0
	public void .ctor() { }

	// RVA: 0x119122C
	public bool get_Async() { }

	// RVA: 0x118551C
	public void set_Async(bool value) { }

	// RVA: 0x11912EC
	public XmlNameTable get_NameTable() { }

	// RVA: 0x11912F4
	public void set_NameTable(XmlNameTable value) { }

	// RVA: 0x119135C
	internal bool get_IsXmlResolverSet() { }

	// RVA: 0x1191364
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0x119136C
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x11913E0
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0x11913E8
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x119142C
	public int get_LineNumberOffset() { }

	// RVA: 0x1191434
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x1191494
	public int get_LinePositionOffset() { }

	// RVA: 0x119149C
	public void set_LinePositionOffset(int value) { }

	// RVA: 0x11914FC
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x1191504
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x11915B4
	public bool get_CheckCharacters() { }

	// RVA: 0x11915BC
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x119161C
	public Int64 get_MaxCharactersInDocument() { }

	// RVA: 0x1191624
	public void set_MaxCharactersInDocument(Int64 value) { }

	// RVA: 0x11916D0
	public Int64 get_MaxCharactersFromEntities() { }

	// RVA: 0x11916D8
	public void set_MaxCharactersFromEntities(Int64 value) { }

	// RVA: 0x1191784
	public bool get_IgnoreWhitespace() { }

	// RVA: 0x119178C
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0x11917EC
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0x11917F4
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0x1191854
	public bool get_IgnoreComments() { }

	// RVA: 0x119185C
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x11918BC
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0x11918C4
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x1191974
	public bool get_CloseInput() { }

	// RVA: 0x119197C
	public void set_CloseInput(bool value) { }

	// RVA: 0x11919DC
	public ValidationType get_ValidationType() { }

	// RVA: 0x11919E4
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x1191A94
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x1191A9C
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0x1191B4C
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0x1191BD4
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x1185484
	public XmlReaderSettings Clone() { }

	// RVA: 0x1191C3C
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x11908DC
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x1190B2C
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x1191C44
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x1191234
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x1191224
	private void Initialize() { }

	// RVA: 0x1191C4C
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0x1191ECC
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x1191068
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0x1191F24
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0x1191D44
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

	// RVA: 0x1191FA8
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0x1191FFC
	internal void set_QuoteChar(Char value) { }

	// RVA: 0x1192004
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0x11920C4
	internal void EndAttribute() { }

	// RVA: 0x1192108
	internal string get_AttributeValue() { }

	// RVA: 0x1192150
	internal void WriteSurrogateChar(Char lowChar, Char highChar) { }

	// RVA: 0x1192210
	internal void Write(Char[] array, int offset, int count) { }

	// RVA: 0x1192870
	internal void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11929F8
	internal void Write(string text) { }

	// RVA: 0x1193058
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0x1193248
	internal void WriteRaw(Char[] array, int offset, int count) { }

	// RVA: 0x119338C
	internal void WriteCharEntity(Char ch) { }

	// RVA: 0x1193574
	internal void WriteEntityRef(string name) { }

	// RVA: 0x1192FA4
	private void WriteStringFragment(string str, int offset, int count, Char[] helperBuffer) { }

	// RVA: 0x1192778
	private void WriteCharEntityImpl(Char ch) { }

	// RVA: 0x11934D0
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0x11927FC
	private void WriteEntityRefImpl(string name) { }

}

// Namespace: System.Xml
public class XmlTextReader
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Methods

	// RVA: 0x119362C
	public void .ctor(Stream input) { }

	// RVA: 0x11936F0
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x11937CC
	public void .ctor(TextReader input) { }

	// RVA: 0x1193890
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x1193964
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1193988
	public override string get_Name() { }

	// RVA: 0x11939AC
	public override string get_LocalName() { }

	// RVA: 0x11939D0
	public override string get_NamespaceURI() { }

	// RVA: 0x11939F4
	public override string get_Prefix() { }

	// RVA: 0x1193A18
	public override string get_Value() { }

	// RVA: 0x1193A3C
	public override int get_Depth() { }

	// RVA: 0x1193A60
	public override string get_BaseURI() { }

	// RVA: 0x1193A88
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1193AB0
	public override bool get_IsDefault() { }

	// RVA: 0x1193AD8
	public override Char get_QuoteChar() { }

	// RVA: 0x1193B00
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1193B28
	public override string get_XmlLang() { }

	// RVA: 0x1193B50
	public override int get_AttributeCount() { }

	// RVA: 0x1193B78
	public override string GetAttribute(string name) { }

	// RVA: 0x1193BA0
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1193BC8
	public override string GetAttribute(int i) { }

	// RVA: 0x1193BF0
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1193C18
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1193C40
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1193C68
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1193C90
	public override bool MoveToElement() { }

	// RVA: 0x1193CB8
	public override bool ReadAttributeValue() { }

	// RVA: 0x1193CE0
	public override bool Read() { }

	// RVA: 0x1193D08
	public override bool get_EOF() { }

	// RVA: 0x1193D30
	public override void Close() { }

	// RVA: 0x1193D58
	public override ReadState get_ReadState() { }

	// RVA: 0x1193D80
	public override void Skip() { }

	// RVA: 0x1193DA8
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1193DD0
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1193E0C
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1193E14
	public override void ResolveEntity() { }

	// RVA: 0x1193E3C
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1193E44
	public override string ReadString() { }

	// RVA: 0x1193E78
	public bool HasLineInfo() { }

	// RVA: 0x1193E80
	public int get_LineNumber() { }

	// RVA: 0x1193EA0
	public int get_LinePosition() { }

	// RVA: 0x1193EC0
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1193EE0
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1193F08
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1190624
	public bool get_Namespaces() { }

	// RVA: 0x1193F28
	public bool get_Normalization() { }

	// RVA: 0x1193F48
	public void set_Normalization(bool value) { }

	// RVA: 0x1193F68
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1193F88
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1193FA8
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1193FC8
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0x1193FD0
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1193FF8
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x1194018
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

	// RVA: 0x1194040
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

	// RVA: 0x1194050
	internal void Clear() { }

	// RVA: 0x1194118
	internal void Close(bool closeInput) { }

	// RVA: 0x1194150
	internal int get_LineNo() { }

	// RVA: 0x1194158
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

	// RVA: 0x1194168
	internal void .ctor() { }

	// RVA: 0x11941D4
	internal void .ctor(XmlContext previousContext) { }

}

// Namespace: 
private class NoNamespaceManager
{
	// Methods

	// RVA: 0x1194238
	public void .ctor() { }

	// RVA: 0x1194240
	public override string get_DefaultNamespace() { }

	// RVA: 0x1194258
	public override void PushScope() { }

	// RVA: 0x119425C
	public override bool PopScope() { }

	// RVA: 0x1194264
	public override void AddNamespace(string prefix, string uri) { }

	// RVA: 0x1194268
	public override void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x119426C
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1194274
	public override System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x119427C
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1194294
	public override string LookupPrefix(string uri) { }

}

// Namespace: 
internal class DtdParserProxy
{
	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Methods

	// RVA: 0x119429C
	internal void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x11942D0
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x11942F0
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x1194310
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x1194330
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x1194350
	private Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x1194370
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x1194390
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x11943B0
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x11943D0
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x11943F0
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x1194410
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x1194430
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x1194450
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x1194470
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x1194490
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x11944B0
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x11944D0
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x11944F0
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x1194510
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, int entityId) { }

	// RVA: 0x1194530
	private bool System.Xml.IDtdParserAdapter.PopEntity(IDtdEntityInfo oldEntity, int newEntityId) { }

	// RVA: 0x1194550
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1194570
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1194590
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x11945B0
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x11945D0
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x11945F0
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x1194610
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0x1194630
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0x1194650
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x1194670
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

	// RVA: 0x1194690
	internal static NodeData get_None() { }

	// RVA: 0x119473C
	internal void .ctor() { }

	// RVA: 0x1194854
	internal int get_LineNo() { }

	// RVA: 0x119485C
	internal int get_LinePos() { }

	// RVA: 0x1194864
	internal bool get_IsEmptyElement() { }

	// RVA: 0x1194888
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x1194890
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0x11948B4
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x11948BC
	internal bool get_ValueBuffered() { }

	// RVA: 0x11948CC
	internal string get_StringValue() { }

	// RVA: 0x1194924
	internal void TrimSpacesInValue() { }

	// RVA: 0x1194770
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x1194980
	internal void ClearName() { }

	// RVA: 0x11949FC
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1194A08
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x1194A14
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x1194ABC
	internal void SetValueNode(XmlNodeType type, Char[] chars, int startPos, int len) { }

	// RVA: 0x1194B80
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x1194C24
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1194CC0
	internal void SetValue(string value) { }

	// RVA: 0x1194CD0
	internal void SetValue(Char[] chars, int startPos, int len) { }

	// RVA: 0x1194D20
	internal void OnBufferInvalidated() { }

	// RVA: 0x1194D88
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x1194E04
	internal int CopyTo(int valueOffset, Char[] buffer, int offset, int length) { }

	// RVA: 0x1194E7C
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1194E90
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1194F54
	private int System.IComparable.CompareTo(object obj) { }

}

// Namespace: 
private class DtdDefaultAttributeInfoToNodeDataComparer
{
	// Fields
	private static System.Collections.Generic.IComparer<System.Object> s_instance; // 0x0

	// Methods

	// RVA: 0x1195040
	internal static System.Collections.Generic.IComparer<System.Object> get_Instance() { }

	// RVA: 0x11950BC
	public int Compare(object x, object y) { }

	// RVA: 0x119543C
	public void .ctor() { }

	// RVA: 0x1195444
	private static void .cctor() { }

}

// Namespace: 
internal sealed class OnDefaultAttributeUseDelegate
{
	// Methods

	// RVA: 0x11954B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11955D4
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

	// RVA: 0x10902D4
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0x1090714
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0x1090EA8
	internal void .ctor(Stream input) { }

	// RVA: 0x1090F30
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1091074
	internal void .ctor(TextReader input) { }

	// RVA: 0x10911D8
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x10910FC
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0x1091204
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0x10916C0
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0x1091810
	private void FinishInitUriString() { }

	// RVA: 0x1091F28
	internal void .ctor(Stream stream, Byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0x1092234
	private void FinishInitStream() { }

	// RVA: 0x1092320
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0x1092450
	private void FinishInitTextReader() { }

	// RVA: 0x1092520
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x10925A8
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1092728
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1092748
	public override string get_Name() { }

	// RVA: 0x1092770
	public override string get_LocalName() { }

	// RVA: 0x1092790
	public override string get_NamespaceURI() { }

	// RVA: 0x10927B0
	public override string get_Prefix() { }

	// RVA: 0x10927D0
	public override string get_Value() { }

	// RVA: 0x1092A18
	public override int get_Depth() { }

	// RVA: 0x1092A38
	public override string get_BaseURI() { }

	// RVA: 0x1092A40
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1092A60
	public override bool get_IsDefault() { }

	// RVA: 0x1092A80
	public override Char get_QuoteChar() { }

	// RVA: 0x1092AB8
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1092AD8
	public override string get_XmlLang() { }

	// RVA: 0x1092AF8
	public override ReadState get_ReadState() { }

	// RVA: 0x1092B00
	public override bool get_EOF() { }

	// RVA: 0x1092B10
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1092B18
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1092B20
	public override int get_AttributeCount() { }

	// RVA: 0x1092B28
	public override string GetAttribute(string name) { }

	// RVA: 0x1092D84
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1092EF8
	public override string GetAttribute(int i) { }

	// RVA: 0x1092FA0
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x109319C
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1093264
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x10932E8
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1093394
	public override bool MoveToElement() { }

	// RVA: 0x1093438
	private void FinishInit() { }

	// RVA: 0x1093484
	public override bool Read() { }

	// RVA: 0x1095B84
	public override void Close() { }

	// RVA: 0x1095CC0
	public override void Skip() { }

	// RVA: 0x1095EEC
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1095F28
	public override bool ReadAttributeValue() { }

	// RVA: 0x109675C
	public override void ResolveEntity() { }

	// RVA: 0x1096F8C
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0x1096F9C
	internal void MoveOffEntityReference() { }

	// RVA: 0x1097050
	public override string ReadString() { }

	// RVA: 0x1097078
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1097080
	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	// RVA: 0x1097C34
	public bool HasLineInfo() { }

	// RVA: 0x1097C3C
	public int get_LineNumber() { }

	// RVA: 0x1097C5C
	public int get_LinePosition() { }

	// RVA: 0x1097C7C
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1097CCC
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1097CDC
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1097CA4
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1097D04
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1097D2C
	internal bool get_Namespaces() { }

	// RVA: 0x1097D34
	internal void set_Namespaces(bool value) { }

	// RVA: 0x1097F40
	internal bool get_Normalization() { }

	// RVA: 0x1097F48
	internal void set_Normalization(bool value) { }

	// RVA: 0x1098078
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1098158
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x10981E0
	internal bool get_IsResolverSet() { }

	// RVA: 0x10981E8
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x109827C
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0x1098284
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0x109828C
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0x10982AC
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0x10982B4
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0x10982BC
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0x10982C4
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x10983AC
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x10983B4
	internal Char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x10983BC
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0x10983C4
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0x10983CC
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0x10983D4
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0x10983E0
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x10983E8
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0x10983F0
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x1098418
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0x1098420
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0x1098428
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0x109888C
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1098A10
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1098B08
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0x1098ECC
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0x1099398
	private bool get_IsResolverNull() { }

	// RVA: 0x10993E4
	private XmlResolver GetTempResolver() { }

	// RVA: 0x1099460
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, int entityId) { }

	// RVA: 0x1099CAC
	internal bool DtdParserProxy_PopEntity(IDtdEntityInfo oldEntity, int newEntityId) { }

	// RVA: 0x1099E08
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x109A584
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x109A81C
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0x109A934
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x109AA80
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x109AB10
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0x109AC28
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0x109AD40
	private void Throw(int pos, string res) { }

	// RVA: 0x1092214
	private void Throw(string res) { }

	// RVA: 0x109AD6C
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0x109AB28
	private void Throw(string res, string arg) { }

	// RVA: 0x109AE70
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x109AC40
	private void Throw(string res, string[] args) { }

	// RVA: 0x109AF64
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0x109AFF8
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0x109A8A8
	private void Throw(Exception e) { }

	// RVA: 0x109B118
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0x10958C8
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0x109B220
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0x109B300
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0x109B3F4
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	// RVA: 0x109B104
	private void SetErrorState() { }

	// RVA: 0x1099254
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0x109B468
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0x1093080
	private bool get_InAttributeValueIterator() { }

	// RVA: 0x10930A4
	private void FinishAttributeValueIterator() { }

	// RVA: 0x109829C
	private bool get_DtdValidation() { }

	// RVA: 0x109102C
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0x1091058
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x109B6B0
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0x109B714
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1091BA0
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x10911F8
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0x109BADC
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0x1091328
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0x1091438
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0x1091EB8
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0x109434C
	private void OpenUrl() { }

	// RVA: 0x109BE48
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0x109B724
	private Encoding DetectEncoding() { }

	// RVA: 0x109B958
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0x109BFE0
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0x109C214
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0x109C164
	private void UnDecodeChars() { }

	// RVA: 0x109C598
	private void SwitchEncodingToUTF8() { }

	// RVA: 0x109842C
	private int ReadData() { }

	// RVA: 0x109C610
	private int GetChars(int maxCharsCount) { }

	// RVA: 0x109C730
	private void InvalidCharRecovery(int bytesCount, int charsCount) { }

	// RVA: 0x1095B8C
	internal void Close(bool closeInput) { }

	// RVA: 0x109C94C
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0x1094590
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0x1093E10
	private bool ParseDocumentContent() { }

	// RVA: 0x1093A5C
	private bool ParseElementContent() { }

	// RVA: 0x109E2E4
	private void ThrowUnclosedElements() { }

	// RVA: 0x109CEE8
	private void ParseElement() { }

	// RVA: 0x109EB68
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0x109DF3C
	private void ParseEndElement() { }

	// RVA: 0x109FE1C
	private void ThrowTagMismatch(NodeData startTag) { }

	// RVA: 0x109E498
	private void ParseAttributes() { }

	// RVA: 0x109F61C
	private void ElementNamespaceLookup() { }

	// RVA: 0x109FD50
	private void AttributeNamespaceLookup() { }

	// RVA: 0x10A117C
	private void AttributeDuplCheck() { }

	// RVA: 0x10A0C90
	private void OnDefaultNamespaceDecl(NodeData attr) { }

	// RVA: 0x10A0E0C
	private void OnNamespaceDecl(NodeData attr) { }

	// RVA: 0x10A0ED4
	private void OnXmlReservedAttribute(NodeData attr) { }

	// RVA: 0x10A0258
	private void ParseAttributeValueSlow(int curPos, Char quoteChar, NodeData attr) { }

	// RVA: 0x10A1918
	private void AddAttributeChunkToList(NodeData attr, NodeData chunk, NodeData lastChunk) { }

	// RVA: 0x109D7F4
	private bool ParseText() { }

	// RVA: 0x109750C
	private bool ParseText(int startPos, int endPos, int outOrChars) { }

	// RVA: 0x1092824
	private void FinishPartialValue() { }

	// RVA: 0x1092910
	private void FinishOtherValueIterator() { }

	// RVA: 0x10959B8
	private void SkipPartialTextValue() { }

	// RVA: 0x1095A00
	private void FinishReadValueChunk() { }

	// RVA: 0x1095A20
	private void FinishReadContentAsBinary() { }

	// RVA: 0x1095A84
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0x109DC44
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0x1095440
	private void ParseEntityReference() { }

	// RVA: 0x109D438
	private EntityType HandleEntityReference(bool isInAttributeValue, EntityExpandType expandType, int charRefEndPos) { }

	// RVA: 0x10969C4
	private EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0x109C588
	private bool get_InEntity() { }

	// RVA: 0x109B534
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0x10954C0
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0x10A1DC0
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0x109CB38
	private bool ParsePI() { }

	// RVA: 0x1098B50
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0x10A1E44
	private bool ParsePIValue(int outStartPos, int outEndPos) { }

	// RVA: 0x109CB40
	private bool ParseComment() { }

	// RVA: 0x109CBCC
	private void ParseCData() { }

	// RVA: 0x10990D0
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0x10A2208
	private bool ParseCDataOrComment(XmlNodeType type, int outStartPos, int outEndPos) { }

	// RVA: 0x109CBD4
	private bool ParseDoctypeDecl() { }

	// RVA: 0x10A2674
	private void ParseDtd() { }

	// RVA: 0x10A29CC
	private void SkipDtd() { }

	// RVA: 0x10A2D68
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0x10A2E18
	private void SkipUntil(Char stopChar, bool recognizeLiterals) { }

	// RVA: 0x109A31C
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0x10A1B44
	private int ParseCharRefInline(int startPos, int charCount, EntityType entityType) { }

	// RVA: 0x1098944
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, EntityType entityType) { }

	// RVA: 0x10A32C4
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, int charCount, EntityType entityType) { }

	// RVA: 0x1098A8C
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x10A3930
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x109C97C
	private int ParseName() { }

	// RVA: 0x109E488
	private int ParseQName(int colonPos) { }

	// RVA: 0x10A3C7C
	private int ParseQName(bool isQName, int startOffset, int colonPos) { }

	// RVA: 0x10A3F00
	private bool ReadDataInName(int pos) { }

	// RVA: 0x10A1984
	private string ParseEntityName() { }

	// RVA: 0x1095390
	private NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x10A3F4C
	private NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x109A9C4
	private NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0x10A0094
	private NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0x10A40A8
	private NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x10953D8
	private void PopElementContext() { }

	// RVA: 0x1098404
	private void OnNewLine(int pos) { }

	// RVA: 0x109581C
	private void OnEof() { }

	// RVA: 0x10A15C4
	private string LookupNamespace(NodeData node) { }

	// RVA: 0x10A1704
	private void AddNamespace(string prefix, string uri, NodeData attr) { }

	// RVA: 0x10952E0
	private void ResetAttributes() { }

	// RVA: 0x10A4248
	private void FullAttributeCleanup() { }

	// RVA: 0x10A1674
	private void PushXmlContext() { }

	// RVA: 0x10A4204
	private void PopXmlContext() { }

	// RVA: 0x10A1D6C
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0x10A1ADC
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0x1099FA0
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0x10A42E8
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0x109959C
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1099948
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1099D24
	private void PopEntity() { }

	// RVA: 0x10A4530
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0x10A47B4
	private void UnregisterEntity() { }

	// RVA: 0x109A600
	private void PushParsingState() { }

	// RVA: 0x109C8D4
	private void PopParsingState() { }

	// RVA: 0x10A481C
	private int IncrementalRead() { }

	// RVA: 0x1095648
	private void FinishIncrementalRead() { }

	// RVA: 0x10956D0
	private bool ParseFragmentAttribute() { }

	// RVA: 0x1096248
	private bool ParseAttributeValueChunk() { }

	// RVA: 0x1095768
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0x109CBB4
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x109C96C
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0x109CED0
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x109C9A4
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0x109CEC8
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0x10A5190
	private string ParseUnexpectedToken() { }

	// RVA: 0x109FFF8
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0x1092BC0
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0x1092CC4
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0x10A1BB4
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0x109BBDC
	private void ParseDtdFromParserContext() { }

	// RVA: 0x10A1C44
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0x1090C4C
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x10A527C
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x10A5284
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0x10A5404
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0x10A5414
	internal void set_OnDefaultAttributeUse(OnDefaultAttributeUseDelegate value) { }

	// RVA: 0x10A5424
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x10A54FC
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0x10A5504
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0x10A5524
	internal XmlResolver GetResolver() { }

	// RVA: 0x10A5570
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0x10A5590
	internal object get_InternalTypedValue() { }

	// RVA: 0x10A55B0
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0x10A55D0
	internal bool get_StandAlone() { }

	// RVA: 0x10A55D8
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x10A55E0
	internal bool get_V1Compat() { }

	// RVA: 0x109F684
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, NodeData[] nameSortedNodeData) { }

	// RVA: 0x10A5858
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0x10A55E8
	private NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0x10A5AB8
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0x1092108
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0x109A724
	private void RegisterConsumedCharacters(Int64 characters, bool inEntityReference) { }

	// RVA: 0x10A5AC0
	internal static string StripSpaces(string value) { }

	// RVA: 0x10A5CD4
	internal static void StripSpaces(Char[] value, int index, int len) { }

	// RVA: 0x1097C20
	internal static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	// RVA: 0x109C608
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

	// RVA: 0x119578C
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

	// RVA: 0x119A5A4
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

	// RVA: 0x11955E8
	internal void .ctor() { }

	// RVA: 0x11957F4
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x1195904
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x1195990
	public void .ctor(TextWriter w) { }

	// RVA: 0x1195A5C
	public Stream get_BaseStream() { }

	// RVA: 0x1195AEC
	public void set_Namespaces(bool value) { }

	// RVA: 0x1195B60
	public void set_Formatting(Formatting value) { }

	// RVA: 0x1195B74
	public void set_QuoteChar(Char value) { }

	// RVA: 0x1195C00
	public override void WriteStartDocument() { }

	// RVA: 0x1195FAC
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1195FC0
	public override void WriteEndDocument() { }

	// RVA: 0x119623C
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1196F1C
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1197AB8
	public override void WriteEndElement() { }

	// RVA: 0x1197DE0
	public override void WriteFullEndElement() { }

	// RVA: 0x1197DE8
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1198714
	public override void WriteEndAttribute() { }

	// RVA: 0x11987BC
	public override void WriteCData(string text) { }

	// RVA: 0x11989A0
	public override void WriteComment(string text) { }

	// RVA: 0x1198BBC
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1198F04
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1198FDC
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x11990A8
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x119920C
	public override void WriteString(string text) { }

	// RVA: 0x11992E4
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11993C0
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11994A4
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x1199588
	public override void WriteRaw(string data) { }

	// RVA: 0x1199654
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x11997C0
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1199898
	public override WriteState get_WriteState() { }

	// RVA: 0x11998BC
	public override void Close() { }

	// RVA: 0x1199A3C
	public override void Flush() { }

	// RVA: 0x1199A60
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1195C08
	private void StartDocument(int standalone) { }

	// RVA: 0x11968A0
	private void AutoComplete(Token token) { }

	// RVA: 0x11961DC
	private void AutoCompleteAll() { }

	// RVA: 0x1197AC0
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x1199C74
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x1199C1C
	private void WriteEndAttributeQuote() { }

	// RVA: 0x1199B4C
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x11976E4
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x119A318
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x119A5F4
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1199FFC
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x11985F8
	private string GeneratePrefix() { }

	// RVA: 0x1198E04
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1197504
	private int LookupNamespace(string prefix) { }

	// RVA: 0x11984B8
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x1197604
	private string FindPrefix(string ns) { }

	// RVA: 0x11966A8
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x119A0F8
	private void HandleSpecialAttribute() { }

	// RVA: 0x1197964
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x11973D0
	private void PushStack() { }

	// RVA: 0x1199FCC
	private void FlushEncoders() { }

	// RVA: 0x119A6EC
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

	// RVA: 0x119AD04
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x119B130
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x119B2A4
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x119B4F0
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x119B578
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x119B860
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x119B93C
	internal override void StartElementContent() { }

	// RVA: 0x119B988
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x119BB18
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x119BC44
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x119BD88
	public override void WriteEndAttribute() { }

	// RVA: 0x119BDD8
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x119BE30
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x119BE38
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x119BF8C
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x119BFDC
	public override void WriteCData(string text) { }

	// RVA: 0x119C608
	public override void WriteComment(string text) { }

	// RVA: 0x119CB34
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x119CC84
	public override void WriteEntityRef(string name) { }

	// RVA: 0x119CD50
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x119CF38
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x119D5FC
	public override void WriteString(string text) { }

	// RVA: 0x119D654
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x119D7C4
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x119D808
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x119DB10
	public override void WriteRaw(string data) { }

	// RVA: 0x119DB5C
	public override void Close() { }

	// RVA: 0x119DC6C
	public override void Flush() { }

	// RVA: 0x119DCB8
	protected virtual void FlushBuffer() { }

	// RVA: 0x119DC68
	private void FlushEncoder() { }

	// RVA: 0x119CF90
	protected void WriteAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x119D29C
	protected void WriteElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	// RVA: 0x119B4B0
	protected void RawText(string s) { }

	// RVA: 0x119E2F8
	protected void RawText(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x119D854
	protected void WriteRawWithCharChecking(Char* pSrcBegin, Char* pSrcEnd) { }

	// RVA: 0x119C76C
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x119C244
	protected void WriteCDataSection(string text) { }

	// RVA: 0x119E4C4
	private static bool IsSurrogateByte(Byte b) { }

	// RVA: 0x119DF0C
	private static Byte* EncodeSurrogate(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x119E09C
	private Byte* InvalidXmlChar(int ch, Byte* pDst, bool entitize) { }

	// RVA: 0x119E598
	internal void EncodeChar(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x119E21C
	internal static Byte* EncodeMultibyteUTF8(int ch, Byte* pDst) { }

	// RVA: 0x119E67C
	internal static void CharToUTF8(Char* pSrc, Char* pSrcEnd, Byte* pDst) { }

	// RVA: 0x119E270
	protected Byte* WriteNewLine(Byte* pDst) { }

	// RVA: 0x119DE7C
	protected static Byte* LtEntity(Byte* pDst) { }

	// RVA: 0x119DE8C
	protected static Byte* GtEntity(Byte* pDst) { }

	// RVA: 0x119DE60
	protected static Byte* AmpEntity(Byte* pDst) { }

	// RVA: 0x119DE9C
	protected static Byte* QuoteEntity(Byte* pDst) { }

	// RVA: 0x119DEB8
	protected static Byte* TabEntity(Byte* pDst) { }

	// RVA: 0x119DEF0
	protected static Byte* LineFeedEntity(Byte* pDst) { }

	// RVA: 0x119DED4
	protected static Byte* CarriageReturnEntity(Byte* pDst) { }

	// RVA: 0x119E4D4
	private static Byte* CharEntity(Byte* pDst, Char ch) { }

	// RVA: 0x119E4A0
	protected static Byte* RawStartCData(Byte* pDst) { }

	// RVA: 0x119E488
	protected static Byte* RawEndCData(Byte* pDst) { }

	// RVA: 0x119AE10
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

	// RVA: 0x119E74C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x119E898
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x119E990
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x119EA08
	internal override void StartElementContent() { }

	// RVA: 0x119EA94
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x119EA9C
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x119EB24
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x119EBAC
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x119EBF4
	public override void WriteCData(string text) { }

	// RVA: 0x119EC00
	public override void WriteComment(string text) { }

	// RVA: 0x119EC58
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x119ECAC
	public override void WriteEntityRef(string name) { }

	// RVA: 0x119ECB8
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x119ECC4
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x119ECD0
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x119ED30
	public override void WriteString(string text) { }

	// RVA: 0x119ED90
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x119EDDC
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x119EE30
	public override void WriteRaw(string data) { }

	// RVA: 0x119EE84
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x119E778
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x119E904
	private void WriteIndent() { }

}

// Namespace: System.Xml
public class XmlValidatingReader
{
	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Methods

	// RVA: 0x119EE94
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x119EEB8
	public override string get_LocalName() { }

	// RVA: 0x119EEDC
	public override string get_NamespaceURI() { }

	// RVA: 0x119EF00
	public override string get_Prefix() { }

	// RVA: 0x119EF24
	public override string get_Value() { }

	// RVA: 0x119EF48
	public override int get_Depth() { }

	// RVA: 0x119EF6C
	public override string get_BaseURI() { }

	// RVA: 0x119EF94
	public override bool get_IsEmptyElement() { }

	// RVA: 0x119EFBC
	public override int get_AttributeCount() { }

	// RVA: 0x119EFE4
	public override string GetAttribute(string name) { }

	// RVA: 0x119F00C
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x119F034
	public override string GetAttribute(int i) { }

	// RVA: 0x119F05C
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x119F084
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x119F0AC
	public override bool MoveToNextAttribute() { }

	// RVA: 0x119F0D4
	public override bool MoveToElement() { }

	// RVA: 0x119F0FC
	public override bool ReadAttributeValue() { }

	// RVA: 0x119F124
	public override bool Read() { }

	// RVA: 0x119F14C
	public override bool get_EOF() { }

	// RVA: 0x119F174
	public override ReadState get_ReadState() { }

	// RVA: 0x119F19C
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x119F1C4
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x119F200
	public override void ResolveEntity() { }

	// RVA: 0x119F228
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

	// RVA: 0x119F850
	internal void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x11A0E30
	private object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x11A0E38
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x119F884
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

	// RVA: 0x119F270
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x119FAB4
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x119FBA0
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x119FBC4
	public override string get_Name() { }

	// RVA: 0x119FBE8
	public override string get_LocalName() { }

	// RVA: 0x119FC0C
	public override string get_NamespaceURI() { }

	// RVA: 0x119FC30
	public override string get_Prefix() { }

	// RVA: 0x119FC54
	public override string get_Value() { }

	// RVA: 0x119FC78
	public override int get_Depth() { }

	// RVA: 0x119FC9C
	public override string get_BaseURI() { }

	// RVA: 0x119FCC4
	public override bool get_IsEmptyElement() { }

	// RVA: 0x119FCEC
	public override bool get_IsDefault() { }

	// RVA: 0x119FD14
	public override Char get_QuoteChar() { }

	// RVA: 0x119FD3C
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x119FD64
	public override string get_XmlLang() { }

	// RVA: 0x119FD8C
	public override ReadState get_ReadState() { }

	// RVA: 0x119FDCC
	public override bool get_EOF() { }

	// RVA: 0x119FDF4
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x119FE1C
	public override int get_AttributeCount() { }

	// RVA: 0x119FE44
	public override string GetAttribute(string name) { }

	// RVA: 0x119FE6C
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x119FE94
	public override string GetAttribute(int i) { }

	// RVA: 0x119FEBC
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x119FEFC
	public override void MoveToAttribute(int i) { }

	// RVA: 0x119FF38
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x119FF78
	public override bool MoveToNextAttribute() { }

	// RVA: 0x119FFB8
	public override bool MoveToElement() { }

	// RVA: 0x119FFF8
	public override bool Read() { }

	// RVA: 0x11A0484
	public override void Close() { }

	// RVA: 0x11A04C4
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11A04EC
	public override bool ReadAttributeValue() { }

	// RVA: 0x11A054C
	public override bool get_CanResolveEntity() { }

	// RVA: 0x11A0554
	public override void ResolveEntity() { }

	// RVA: 0x11A058C
	internal void MoveOffEntityReference() { }

	// RVA: 0x11A0640
	public override string ReadString() { }

	// RVA: 0x11A0668
	public bool HasLineInfo() { }

	// RVA: 0x11A0670
	public int get_LineNumber() { }

	// RVA: 0x11A0778
	public int get_LinePosition() { }

	// RVA: 0x11A0880
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11A09E8
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11A09F8
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x11A0934
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11A0AB0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x11A0B68
	internal ValidationType get_ValidationType() { }

	// RVA: 0x11A0B70
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x119F250
	internal bool get_Namespaces() { }

	// RVA: 0x11A023C
	private void ParseDtdFromParserContext() { }

	// RVA: 0x11A0B78
	private void ValidateDtd() { }

	// RVA: 0x11A03FC
	private void ResolveEntityInternally() { }

	// RVA: 0x119F938
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x119F754
	private XmlResolver GetResolver() { }

	// RVA: 0x11A00E4
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x11A0BF8
	internal BaseValidator get_Validator() { }

	// RVA: 0x11A0C00
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x11A0C08
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x11A0C30
	internal bool get_StandAlone() { }

	// RVA: 0x11A0C50
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x11A0C70
	internal object get_TypedValueObject() { }

	// RVA: 0x11A0C90
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x11A0CB0
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x11A0CD0
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x11A0CF8
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

	// RVA: 0x11A1510
	internal void .ctor(XmlWellFormedWriter wfWriter) { }

	// RVA: 0x11A7F38
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11A7F78
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11A7F94
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

	// RVA: 0x11A1590
	internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x11A2F20
	internal void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x11A3278
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

	// RVA: 0x11A1544
	internal void Set(string prefix, string namespaceUri, NamespaceKind kind) { }

	// RVA: 0x11A7384
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

	// RVA: 0x11A7FBC
	internal void Set(string prefix, string localName, string namespaceUri) { }

	// RVA: 0x11A8014
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

	// RVA: 0x11A92B0
	internal void .ctor() { }

	// RVA: 0x11A92B8
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

	// RVA: 0x11A8864
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

	// RVA: 0x11A8088
	internal string get_StringValue() { }

	// RVA: 0x11A80C0
	internal void WriteEntityRef(string name) { }

	// RVA: 0x11A8498
	internal void WriteCharEntity(Char ch) { }

	// RVA: 0x11A8544
	internal void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11A8638
	internal void WriteWhitespace(string ws) { }

	// RVA: 0x11A86C0
	internal void WriteString(string text) { }

	// RVA: 0x11A8774
	internal void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11A88B0
	internal void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11A89A0
	internal void WriteRaw(string data) { }

	// RVA: 0x11A8A28
	internal void WriteValue(string value) { }

	// RVA: 0x11A8AB0
	internal void Replay(XmlWriter writer) { }

	// RVA: 0x11A8DBC
	internal void Trim() { }

	// RVA: 0x11A9268
	internal void Clear() { }

	// RVA: 0x11A829C
	private void StartComplexValue() { }

	// RVA: 0x11A82F0
	private void AddItem(ItemType type, object data) { }

	// RVA: 0x11A92C8
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

	// RVA: 0x11A0F5C
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x11A15FC
	public override WriteState get_WriteState() { }

	// RVA: 0x11A169C
	public override void WriteStartDocument() { }

	// RVA: 0x11A1870
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x11A1890
	public override void WriteEndDocument() { }

	// RVA: 0x11A1D60
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x11A2240
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11A2CF8
	public override void WriteEndElement() { }

	// RVA: 0x11A3050
	public override void WriteFullEndElement() { }

	// RVA: 0x11A32AC
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x11A40A4
	public override void WriteEndAttribute() { }

	// RVA: 0x11A4EB4
	public override void WriteCData(string text) { }

	// RVA: 0x11A4FA4
	public override void WriteComment(string text) { }

	// RVA: 0x11A5094
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x11A534C
	public override void WriteEntityRef(string name) { }

	// RVA: 0x11A54DC
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x11A566C
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x11A5800
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x11A59B4
	public override void WriteString(string text) { }

	// RVA: 0x11A5AB8
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x11A5D38
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x11A5FB8
	public override void WriteRaw(string data) { }

	// RVA: 0x11A60BC
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x11A6308
	public override void Close() { }

	// RVA: 0x11A6510
	public override void Flush() { }

	// RVA: 0x11A65D0
	public override string LookupPrefix(string ns) { }

	// RVA: 0x11A6878
	public override void WriteValue(string value) { }

	// RVA: 0x11A698C
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x11A6AD0
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0x11A54CC
	private bool get_SaveAttrValue() { }

	// RVA: 0x11A64F4
	private bool get_InBase64() { }

	// RVA: 0x11A3B24
	private void SetSpecialAttribute(SpecialAttribute special) { }

	// RVA: 0x11A16A4
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x11A6AD8
	private void StartFragment() { }

	// RVA: 0x11A28CC
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x11A49AC
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x11A6BE4
	private void AddNamespace(string prefix, string ns, NamespaceKind kind) { }

	// RVA: 0x11A6EB8
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x11A6AE4
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x11A2F54
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x11A6DA8
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x11A19F8
	private void AdvanceState(Token token) { }

	// RVA: 0x11A72B0
	private void StartElementContent() { }

	// RVA: 0x11A6FB0
	private static string GetStateName(State state) { }

	// RVA: 0x11A2780
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x11A3D18
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x11A3BD4
	private string GeneratePrefix() { }

	// RVA: 0x11A2674
	private void CheckNCName(string ncname) { }

	// RVA: 0x11A74B8
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x11A705C
	private void ThrowInvalidStateTransition(Token token, State currentState) { }

	// RVA: 0x11A6AC0
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x11A3DFC
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x11A75F8
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x11A7734
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

	// RVA: 0x11A9348
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1
	public abstract void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: -1
	public abstract void WriteEndElement() { }

	// RVA: -1
	public abstract void WriteFullEndElement() { }

	// RVA: 0x11A9360
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x11A93C0
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x11A9420
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

	// RVA: 0x11A9474
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: -1
	public abstract WriteState get_WriteState() { }

	// RVA: 0x11A9490
	public virtual void Close() { }

	// RVA: -1
	public abstract void Flush() { }

	// RVA: -1
	public abstract string LookupPrefix(string ns) { }

	// RVA: 0x11A9494
	public virtual void WriteValue(string value) { }

	// RVA: 0x11A94AC
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x11A9754
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x11A9BD8
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x11A9C40
	public void Dispose() { }

	// RVA: 0x11A9C54
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x11A9CA8
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x11AA30C
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x11AA718
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

	// RVA: 0x11A9D1C
	public void .ctor() { }

	// RVA: 0x11AA88C
	public bool get_Async() { }

	// RVA: 0x11AA894
	public Encoding get_Encoding() { }

	// RVA: 0x11AA89C
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x11AA8A4
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x11AA9BC
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x11AA9C4
	public string get_NewLineChars() { }

	// RVA: 0x11AA9CC
	public bool get_Indent() { }

	// RVA: 0x11AA9DC
	public void set_Indent(bool value) { }

	// RVA: 0x11AAA44
	public string get_IndentChars() { }

	// RVA: 0x11AAA4C
	public bool get_NewLineOnAttributes() { }

	// RVA: 0x11AAA54
	public bool get_CloseOutput() { }

	// RVA: 0x11AAA5C
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x11AAA64
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x11AAB14
	public bool get_CheckCharacters() { }

	// RVA: 0x11AAB1C
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x11AAB24
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x11AABD4
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x11AABDC
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x11AABE4
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x11AABEC
	public XmlWriterSettings Clone() { }

	// RVA: 0x11AACCC
	internal System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0x11AACD4
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x11AACDC
	internal bool get_MergeCDataSections() { }

	// RVA: 0x11AACE4
	internal string get_MediaType() { }

	// RVA: 0x11AACEC
	internal string get_DocTypeSystem() { }

	// RVA: 0x11AACF4
	internal string get_DocTypePublic() { }

	// RVA: 0x11AACFC
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x11AAD04
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0x11AAD0C
	internal TriState get_IndentInternal() { }

	// RVA: 0x11AAD14
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x11A9DB0
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x11AA380
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x11AADB0
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x11AA904
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x11AA720
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

	// RVA: 0x11AADB8
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x11AAEB4
	private void Init() { }

	// RVA: 0x11AB320
	internal void Reset(XmlReader reader) { }

	// RVA: 0x11AB348
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x11AB36C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11AB38C
	public override string get_Name() { }

	// RVA: 0x11AB3B4
	public override string get_LocalName() { }

	// RVA: 0x11AB3D4
	public override string get_NamespaceURI() { }

	// RVA: 0x11AB3F4
	public override string get_Prefix() { }

	// RVA: 0x11AB414
	public override string get_Value() { }

	// RVA: 0x11AB44C
	public override int get_Depth() { }

	// RVA: 0x11AB46C
	public override string get_BaseURI() { }

	// RVA: 0x11AB494
	public override bool get_IsEmptyElement() { }

	// RVA: 0x11AB49C
	public override bool get_IsDefault() { }

	// RVA: 0x11AB4A4
	public override Char get_QuoteChar() { }

	// RVA: 0x11AB4CC
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x11AB4F4
	public override string get_XmlLang() { }

	// RVA: 0x11AB51C
	public override int get_AttributeCount() { }

	// RVA: 0x11AB524
	public override string GetAttribute(string name) { }

	// RVA: 0x11AB734
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x11AB854
	public override string GetAttribute(int i) { }

	// RVA: 0x11AB8F0
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11AB9A4
	public override void MoveToAttribute(int i) { }

	// RVA: 0x11ABA40
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x11ABA90
	public override bool MoveToNextAttribute() { }

	// RVA: 0x11ABAF4
	public override bool MoveToElement() { }

	// RVA: 0x11ABB50
	public override bool Read() { }

	// RVA: 0x11ABE70
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x11ABEEC
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x11AC030
	internal void RecordEndElementNode() { }

	// RVA: 0x11AC154
	public override bool get_EOF() { }

	// RVA: 0x11AC194
	public override void Close() { }

	// RVA: 0x11AC1D4
	public override ReadState get_ReadState() { }

	// RVA: 0x11AC1FC
	public override void Skip() { }

	// RVA: 0x11AC314
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x11AC31C
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11AC344
	public override void ResolveEntity() { }

	// RVA: 0x11AC384
	public override bool ReadAttributeValue() { }

	// RVA: 0x11AC504
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x11AC50C
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x11AC52C
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x11AC54C
	internal void SetToReplayMode() { }

	// RVA: 0x11AC56C
	internal XmlReader GetCoreReader() { }

	// RVA: 0x11AC574
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x11ABE60
	private void ClearAttributesInfo() { }

	// RVA: 0x11AC57C
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x11AB020
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x11AB1AC
	private void RecordAttributes() { }

	// RVA: 0x11AB5BC
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x11AB688
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x11AC460
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

}

// Namespace: System.Xml
internal sealed class CachingEventHandler
{
	// Methods

	// RVA: 0x11AC700
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11AC820
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

	// RVA: 0x11AC834
	internal void .ctor() { }

	// RVA: 0x11AC8AC
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

	// RVA: 0x11AC91C
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x11AD100
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x11ACB38
	private void Init() { }

	// RVA: 0x11ACEE4
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x11AD108
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x11AD1DC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11AD274
	public override string get_Name() { }

	// RVA: 0x11AD3A0
	public override string get_LocalName() { }

	// RVA: 0x11AD3E0
	public override string get_NamespaceURI() { }

	// RVA: 0x11AD420
	public override string get_Prefix() { }

	// RVA: 0x11AD460
	public override string get_Value() { }

	// RVA: 0x11AD4A0
	public override int get_Depth() { }

	// RVA: 0x11AD4E0
	public override string get_BaseURI() { }

	// RVA: 0x11AD508
	public override bool get_IsEmptyElement() { }

	// RVA: 0x11AD530
	public override bool get_IsDefault() { }

	// RVA: 0x11AD570
	public override Char get_QuoteChar() { }

	// RVA: 0x11AD598
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x11AD5C0
	public override string get_XmlLang() { }

	// RVA: 0x11AD5E8
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11AD5EC
	public override Type get_ValueType() { }

	// RVA: 0x11AD6D8
	public override int get_AttributeCount() { }

	// RVA: 0x11AD6E0
	public override string GetAttribute(string name) { }

	// RVA: 0x11AD8E4
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x11ADB2C
	public override string GetAttribute(int i) { }

	// RVA: 0x11ADC20
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11ADF24
	public override void MoveToAttribute(int i) { }

	// RVA: 0x11AE120
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x11AE2E4
	public override bool MoveToNextAttribute() { }

	// RVA: 0x11AE4A8
	public override bool MoveToElement() { }

	// RVA: 0x11AE510
	public override bool Read() { }

	// RVA: 0x11AE9F8
	public override bool get_EOF() { }

	// RVA: 0x11AEA20
	public override void Close() { }

	// RVA: 0x11AEA60
	public override ReadState get_ReadState() { }

	// RVA: 0x11AEAA0
	public override void Skip() { }

	// RVA: 0x11AEC08
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x11AEC10
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11AECC8
	public override void ResolveEntity() { }

	// RVA: 0x11AED08
	public override bool ReadAttributeValue() { }

	// RVA: 0x11AEF0C
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x11AF24C
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x11AF2A8
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x11AF360
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x11AF508
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x11AF578
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x11AF5E0
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x11AF638
	public bool HasLineInfo() { }

	// RVA: 0x11AF640
	public int get_LineNumber() { }

	// RVA: 0x11AF704
	public int get_LinePosition() { }

	// RVA: 0x11AF7C8
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11AF8A4
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11AF984
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x11AFA64
	private object GetStringValue() { }

	// RVA: 0x11AD6B8
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x11AE6E4
	private void ProcessReaderEvent() { }

	// RVA: 0x11AFA88
	private void ProcessElementEvent() { }

	// RVA: 0x11AFF48
	private void ProcessEndElementEvent() { }

	// RVA: 0x11B01AC
	private void ValidateAttributes() { }

	// RVA: 0x11AE9A8
	private void ClearAttributesInfo() { }

	// RVA: 0x11ADD18
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x11B070C
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x11AD760
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x11AD9DC
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x11B04E8
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x11B0160
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x11AE8B0
	private void ProcessInlineSchema() { }

	// RVA: 0x11B07D8
	private void ReadAheadForMemberType() { }

	// RVA: 0x11AEFA8
	private void GetIsDefault() { }

	// RVA: 0x11AF3F4
	private void GetMemberType() { }

	// RVA: 0x11B03E4
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x11AEE68
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x11B0A54
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x11B0374
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

	// RVA: 0x11B0AA0
	public void .ctor(XmlDocument document, XmlNode node) { }

	// RVA: 0x11B0C94
	public void .ctor(DocumentXPathNavigator other) { }

	// RVA: 0x11B0D58
	public override XPathNavigator Clone() { }

	// RVA: 0x11B0DBC
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x11B0E04
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x11B0EF0
	public override string get_LocalName() { }

	// RVA: 0x11B0F18
	public override string get_NamespaceURI() { }

	// RVA: 0x11B101C
	public override string get_Name() { }

	// RVA: 0x11B115C
	public override string get_Prefix() { }

	// RVA: 0x11B1230
	public override string get_Value() { }

	// RVA: 0x11B1370
	private string get_ValueDocument() { }

	// RVA: 0x11B1430
	private string get_ValueText() { }

	// RVA: 0x11B16E8
	public override string get_BaseURI() { }

	// RVA: 0x11B1710
	public override string get_XmlLang() { }

	// RVA: 0x11B1738
	public override object get_UnderlyingObject() { }

	// RVA: 0x11B175C
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x11B1A90
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x11B1C10
	public override bool MoveToNextAttribute() { }

	// RVA: 0x11B1F4C
	public override bool MoveToNamespace(string name) { }

	// RVA: 0x11B22C0
	public override bool MoveToFirstNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x11B2548
	private static bool MoveToFirstNamespaceLocal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x11B25D0
	private static bool MoveToFirstNamespaceGlobal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x11B28D8
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x11B2D5C
	private static bool MoveToNextNamespaceLocal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x11B2754
	private static bool MoveToNextNamespaceGlobal(XmlAttributeCollection attributes, int index) { }

	// RVA: 0x11B2DF0
	private bool PathHasDuplicateNamespace(XmlElement top, XmlElement bottom, string localName) { }

	// RVA: 0x11B2EEC
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11B2F4C
	public override bool MoveToNext() { }

	// RVA: 0x11B32D4
	public override bool MoveToFirstChild() { }

	// RVA: 0x11B3598
	public override bool MoveToParent() { }

	// RVA: 0x11B3728
	public override void MoveToRoot() { }

	// RVA: 0x11B3840
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x11B38F4
	public override bool MoveToId(string id) { }

	// RVA: 0x11B395C
	public override bool MoveToChild(string localName, string namespaceUri) { }

	// RVA: 0x11B3AD8
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x11B3C4C
	public override bool MoveToFollowing(string localName, string namespaceUri, XPathNavigator end) { }

	// RVA: 0x11B3ED4
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x11B41D8
	public override bool MoveToNext(string localName, string namespaceUri) { }

	// RVA: 0x11B42AC
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x11B440C
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x11B44B4
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x11B46C8
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11B46F0
	private static XmlNode OwnerNode(XmlNode node) { }

	// RVA: 0x11B47A4
	private static int GetDepth(XmlNode node) { }

	// RVA: 0x11B4910
	private XmlNodeOrder Compare(XmlNode node1, XmlNode node2) { }

	// RVA: 0x11B4B28
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x11B50BC
	private XmlNode System.Xml.IHasXmlNode.GetNode() { }

	// RVA: 0x11B50C4
	public override XPathNodeIterator SelectDescendants(string localName, string namespaceURI, bool matchSelf) { }

	// RVA: 0x11B53E4
	public override XPathNodeIterator SelectDescendants(XPathNodeType nt, bool includeSelf) { }

	// RVA: 0x11B0B30
	internal void ResetPosition(XmlNode node) { }

	// RVA: 0x11B1EC0
	private static bool ResetAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, int index) { }

	// RVA: 0x11B1DF8
	private static bool CheckAttributePosition(XmlAttribute attribute, XmlAttributeCollection attributes, int index) { }

	// RVA: 0x11B0E3C
	private void CalibrateText() { }

	// RVA: 0x11B3188
	private XmlNode ParentNode(XmlNode node) { }

	// RVA: 0x11B5580
	private XmlNode ParentNodeTail(XmlNode parent) { }

	// RVA: 0x11B350C
	private XmlNode FirstChild(XmlNode node) { }

	// RVA: 0x11B55D4
	private XmlNode FirstChildTail(XmlNode child) { }

	// RVA: 0x11B15F0
	private XmlNode NextSibling(XmlNode node) { }

	// RVA: 0x11B562C
	private XmlNode NextSiblingTail(XmlNode node, XmlNode sibling) { }

	// RVA: 0x11B5520
	private XmlNode PreviousText(XmlNode node) { }

	// RVA: 0x11B56F0
	private XmlNode PreviousTextTail(XmlNode node, XmlNode text) { }

	// RVA: 0x11B45E4
	private static bool IsDescendant(XmlNode top, XmlNode bottom) { }

	// RVA: 0x11B320C
	private static bool IsValidChild(XmlNode parent, XmlNode child) { }

	// RVA: 0x11B3130
	private XmlNode TextEnd(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_Empty
{
	// Fields
	private XPathNavigator nav; // 0x18

	// Methods

	// RVA: 0x11B529C
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x11B5814
	internal void .ctor(DocumentXPathNodeIterator_Empty other) { }

	// RVA: 0x11B5868
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11B58FC
	public override bool MoveNext() { }

	// RVA: 0x11B5904
	public override XPathNavigator get_Current() { }

	// RVA: 0x11B590C
	public override int get_CurrentPosition() { }

	// RVA: 0x11B5914
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

	// RVA: 0x11B591C
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x11B59DC
	internal void .ctor(DocumentXPathNodeIterator_ElemDescendants other) { }

	// RVA: -1
	protected abstract bool Match(XmlNode node) { }

	// RVA: 0x11B5AA4
	public override XPathNavigator get_Current() { }

	// RVA: 0x11B5AAC
	public override int get_CurrentPosition() { }

	// RVA: 0x11B5AB4
	protected void SetPosition(int pos) { }

	// RVA: 0x11B5ABC
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_AllElemChildren
{
	// Methods

	// RVA: 0x11B551C
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x11B5C44
	internal void .ctor(DocumentXPathNodeIterator_AllElemChildren other) { }

	// RVA: 0x11B5C48
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11B5CAC
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_AllElemChildren_AndSelf
{
	// Methods

	// RVA: 0x11B5518
	internal void .ctor(DocumentXPathNavigator nav) { }

	// RVA: 0x11B5CE0
	internal void .ctor(DocumentXPathNodeIterator_AllElemChildren_AndSelf other) { }

	// RVA: 0x11B5CE4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11B5D48
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren_NoLocalName
{
	// Fields
	private string nsAtom; // 0x28

	// Methods

	// RVA: 0x11B531C
	internal void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x11B5E6C
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_NoLocalName other) { }

	// RVA: 0x11B5EA4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11B5F20
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName
{
	// Methods

	// RVA: 0x11B52EC
	internal void .ctor(DocumentXPathNavigator nav, string nsAtom) { }

	// RVA: 0x11B5F64
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName other) { }

	// RVA: 0x11B5F9C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11B6018
	public override bool MoveNext() { }

}

// Namespace: System.Xml
internal class DocumentXPathNodeIterator_ElemChildren
{
	// Fields
	protected string localNameAtom; // 0x28
	protected string nsAtom; // 0x30

	// Methods

	// RVA: 0x11B5398
	internal void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x11B613C
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren other) { }

	// RVA: 0x11B6184
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11B6210
	protected override bool Match(XmlNode node) { }

}

// Namespace: System.Xml
internal sealed class DocumentXPathNodeIterator_ElemChildren_AndSelf
{
	// Methods

	// RVA: 0x11B534C
	internal void .ctor(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	// RVA: 0x11B6284
	internal void .ctor(DocumentXPathNodeIterator_ElemChildren_AndSelf other) { }

	// RVA: 0x11B62CC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11B6358
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

	// RVA: 0x11B647C
	public void .ctor(XmlDocument document) { }

	// RVA: 0x11B652C
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11B668C
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11B68F4
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

	// RVA: 0x11B6A7C
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11B6B2C
	public override int get_Count() { }

	// RVA: 0x11B6C80
	private XmlNode GetNode(XPathNavigator n) { }

	// RVA: 0x11B6B9C
	internal int ReadUntil(int index) { }

	// RVA: 0x11B6D80
	public override XmlNode Item(int index) { }

	// RVA: 0x11B6E4C
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x11B6F10
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

	// RVA: 0x11B6ECC
	public void .ctor(XPathNodeList list) { }

	// RVA: 0x11B6F90
	public void Reset() { }

	// RVA: 0x11B6F9C
	public bool MoveNext() { }

	// RVA: 0x11B7018
	public object get_Current() { }

}

// Namespace: System.Xml
public class XmlAttribute
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Methods

	// RVA: 0x11B7058
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0x11B7280
	internal int get_LocalNameHash() { }

	// RVA: 0x11B72A0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x11B7400
	internal XmlName get_XmlName() { }

	// RVA: 0x11B7408
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x11B7410
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11B74DC
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11B74E4
	public override string get_Name() { }

	// RVA: 0x11B7504
	public override string get_LocalName() { }

	// RVA: 0x11B7524
	public override string get_NamespaceURI() { }

	// RVA: 0x11B7544
	public override string get_Prefix() { }

	// RVA: 0x11B7564
	public override void set_Prefix(string value) { }

	// RVA: 0x11B7610
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11B7618
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x11B7638
	public override string get_Value() { }

	// RVA: 0x11B7648
	public override void set_Value(string value) { }

	// RVA: 0x11B7658
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11B7660
	public override void set_InnerText(string value) { }

	// RVA: 0x11B7730
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0x11B77F0
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x11B7A38
	internal override bool get_IsContainer() { }

	// RVA: 0x11B7A40
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11B7D34
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x11B7D3C
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11B7D44
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11B7D54
	public virtual bool get_Specified() { }

	// RVA: 0x11B7D5C
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11B7E3C
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11B7F1C
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x11B7FF0
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x11B80C4
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x11B8198
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0x11B8220
	public override void set_InnerXml(string value) { }

	// RVA: 0x11B82B0
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11B8364
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11B83CC
	public override string get_BaseURI() { }

	// RVA: 0x11B8444
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x11B844C
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0x11B84B0
	internal override string get_XmlLang() { }

	// RVA: 0x11B8528
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x11B8568
	internal override string get_XPLocalName() { }

	// RVA: 0x11B0FEC
	internal bool get_IsNamespace() { }

}

// Namespace: System.Xml
public sealed class XmlAttributeCollection
{
	// Methods

	// RVA: 0x11B8608
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x11B1938
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0x11B8610
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0x11B8754
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0x11B88BC
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0x11B8AA4
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x11B8D5C
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0x11B90B0
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0x11B9158
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0x11B9220
	public void RemoveAll() { }

	// RVA: 0x11B9300
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x11B93A0
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x11B93A8
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x11B93AC
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x11B93B4
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0x11B95AC
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0x11B9660
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x11B8E8C
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0x11B8F58
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x11B980C
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x11B949C
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0x11B7878
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0x11B7978
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0x11B8CB0
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

}

// Namespace: System.Xml
public class XmlCDataSection
{
	// Methods

	// RVA: 0x11B9F70
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x11B9FE0
	public override string get_Name() { }

	// RVA: 0x11BA00C
	public override string get_LocalName() { }

	// RVA: 0x11BA038
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11BA040
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11BA0DC
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11BA13C
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11BA184
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11BA188
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x11BA190
	internal override bool get_IsText() { }

	// RVA: 0x11BA198
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public abstract class XmlCharacterData
{
	// Fields
	private string data; // 0x20

	// Methods

	// RVA: 0x11B9FA8
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x11BA1E8
	public override string get_Value() { }

	// RVA: 0x11BA1F8
	public override void set_Value(string value) { }

	// RVA: 0x11BA208
	public override string get_InnerText() { }

	// RVA: 0x11BA214
	public override void set_InnerText(string value) { }

	// RVA: 0x11BA220
	public virtual string get_Data() { }

	// RVA: 0x11BA244
	public virtual void set_Data(string value) { }

	// RVA: 0x11BA308
	internal bool CheckOnData(string data) { }

	// RVA: 0x11BA348
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

	// RVA: 0x11BA450
	internal void .ctor(XmlNode container) { }

	// RVA: 0x11BA4BC
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x11BA564
	internal bool MoveNext() { }

	// RVA: 0x11BA60C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x11BA658
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x11BA65C
	internal XmlNode get_Current() { }

}

// Namespace: System.Xml
internal class XmlChildNodes
{
	// Fields
	private XmlNode container; // 0x10

	// Methods

	// RVA: 0x11BA6D4
	public void .ctor(XmlNode container) { }

	// RVA: 0x11BA708
	public override XmlNode Item(int i) { }

	// RVA: 0x11BA778
	public override int get_Count() { }

	// RVA: 0x11BA7D0
	public override IEnumerator GetEnumerator() { }

}

// Namespace: System.Xml
public class XmlComment
{
	// Methods

	// RVA: 0x11BA8EC
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0x11BA924
	public override string get_Name() { }

	// RVA: 0x11BA950
	public override string get_LocalName() { }

	// RVA: 0x11BA97C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11BA984
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11BA9E4
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11BAA2C
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11BAA30
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

	// RVA: 0x11BAA38
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x11BAE5C
	public string get_Version() { }

	// RVA: 0x11BAE64
	internal void set_Version(string value) { }

	// RVA: 0x11BAE6C
	public string get_Encoding() { }

	// RVA: 0x11BACC4
	public void set_Encoding(string value) { }

	// RVA: 0x11BAE74
	public string get_Standalone() { }

	// RVA: 0x11BACF8
	public void set_Standalone(string value) { }

	// RVA: 0x11BAE7C
	public override string get_Value() { }

	// RVA: 0x11BAE8C
	public override void set_Value(string value) { }

	// RVA: 0x11BAE9C
	public override string get_InnerText() { }

	// RVA: 0x11BB018
	public override void set_InnerText(string value) { }

	// RVA: 0x11BB234
	public override string get_Name() { }

	// RVA: 0x11BB278
	public override string get_LocalName() { }

	// RVA: 0x11BB284
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11BB28C
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11BB2D4
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11BB340
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11BAC40
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

	// RVA: 0x11BB344
	public void .ctor() { }

	// RVA: 0x11BB850
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x11BB3AC
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x11BB8C0
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x11BB8C8
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0x11B7180
	internal static void CheckName(string name) { }

	// RVA: 0x11BB8D0
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11BB8EC
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11B72E0
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11BB908
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0x11BB9E4
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0x11B9C1C
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0x11BBAB8
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0x11B9C30
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0x11B9E28
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0x11BC0E0
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11BC250
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11BC258
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11BC260
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0x11BC2F0
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x11BC3B0
	public XmlImplementation get_Implementation() { }

	// RVA: 0x11BC3B8
	public override string get_Name() { }

	// RVA: 0x11BC3C0
	public override string get_LocalName() { }

	// RVA: 0x11B1560
	public XmlElement get_DocumentElement() { }

	// RVA: 0x11BC3C8
	internal override bool get_IsContainer() { }

	// RVA: 0x11BC3D0
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x11BC3D8
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11BC3E0
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x11BC3E8
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x11BC3F0
	internal bool get_CanReportValidity() { }

	// RVA: 0x11BC3F8
	internal bool get_HasSetResolver() { }

	// RVA: 0x11BC400
	internal XmlResolver GetResolver() { }

	// RVA: 0x11BC408
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x11BC5D0
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11BC72C
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x11BC7EC
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x11BC850
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11BCA68
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11BCBDC
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0x11BCCC8
	internal void SetDefaultNamespace(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x11BCD6C
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0x11BCDF0
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0x11BCE6C
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x11BCF04
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0x11BCF6C
	public XmlElement CreateElement(string name) { }

	// RVA: 0x11BCFE4
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0x11BD284
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0x11BD3B8
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x11BD518
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0x11BD588
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x11BD608
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x11BD68C
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0x11BD6FC
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0x11BD76C
	public override XPathNavigator CreateNavigator() { }

	// RVA: 0x11BD780
	protected internal virtual XPathNavigator CreateNavigator(XmlNode node) { }

	// RVA: 0x11BDB38
	internal static bool IsTextNode(XmlNodeType nt) { }

	// RVA: 0x11BD96C
	private XmlNode NormalizeText(XmlNode n) { }

	// RVA: 0x11BDB50
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0x11BDBC0
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0x11BDC34
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0x11BDCA8
	public virtual XmlElement GetElementById(string elementId) { }

	// RVA: 0x11BE048
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0x11BE62C
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0x11BC1A0
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0x11B0DE4
	public XmlNameTable get_NameTable() { }

	// RVA: 0x11BE790
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x11BE828
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x11BE8B0
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x11BE984
	public override bool get_IsReadOnly() { }

	// RVA: 0x11BE98C
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x11BEA2C
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0x11BEA34
	internal bool get_IsLoading() { }

	// RVA: 0x11BEA3C
	internal void set_IsLoading(bool value) { }

	// RVA: 0x11BEA44
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0x11BEA4C
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0x11BEB40
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0x11BEBA4
	public virtual void Load(XmlReader reader) { }

	// RVA: 0x11BECC8
	public virtual void LoadXml(string xml) { }

	// RVA: 0x11BEE44
	public override void set_InnerText(string value) { }

	// RVA: 0x11BEEA0
	public override void set_InnerXml(string value) { }

	// RVA: 0x11BEEB0
	public virtual void Save(XmlWriter w) { }

	// RVA: 0x11BF0E4
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11BF0F4
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0x11BF3BC
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x11B7C6C
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0x11BF4B8
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11BF50C
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11B9964
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x11BF560
	internal string get_Version() { }

	// RVA: 0x11BF588
	internal string get_Encoding() { }

	// RVA: 0x11BF0BC
	internal string get_Standalone() { }

	// RVA: 0x11BF5B0
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0x11BF684
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11BF864
	public override string get_BaseURI() { }

	// RVA: 0x11BF86C
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0x11BF87C
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11BFB24
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x11BFB2C
	internal bool get_HasEntityReferences() { }

	// RVA: 0x11B21F8
	internal XmlAttribute get_NamespaceXml() { }

	// RVA: 0x11BFB34
	private static void .cctor() { }

}

// Namespace: System.Xml
public class XmlDocumentFragment
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Methods

	// RVA: 0x11BFC54
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x11BFCE4
	public override string get_Name() { }

	// RVA: 0x11BFD10
	public override string get_LocalName() { }

	// RVA: 0x11BFD3C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11BFD44
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11BFD4C
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x11BFDC8
	public override void set_InnerXml(string value) { }

	// RVA: 0x11C00A0
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11C0124
	internal override bool get_IsContainer() { }

	// RVA: 0x11C012C
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x11C0134
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11C013C
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11C01B8
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11C023C
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11C02A8
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11C02B8
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11C061C
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

	// RVA: 0x11C0624
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x11C082C
	public override string get_Name() { }

	// RVA: 0x11C0834
	public override string get_LocalName() { }

	// RVA: 0x11C083C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11C0844
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11C088C
	public override bool get_IsReadOnly() { }

	// RVA: 0x11C0894
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x11C0974
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x11C0A20
	public string get_PublicId() { }

	// RVA: 0x11C0A28
	public string get_SystemId() { }

	// RVA: 0x11C0A30
	public string get_InternalSubset() { }

	// RVA: 0x11C0A38
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x11C0A40
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11C0A70
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11C0A74
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x11C0A7C
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

}

// Namespace: System.Xml
internal class XmlDOMTextWriter
{
	// Methods

	// RVA: 0x11C0A84
	public void .ctor(TextWriter w) { }

	// RVA: 0x11C0AF0
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x11C0B88
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

	// RVA: 0x11C0C20
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x11C0D90
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x11C0DD8
	internal XmlName get_XmlName() { }

	// RVA: 0x11C0DE0
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x11C0DE8
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11C1470
	public override string get_Name() { }

	// RVA: 0x11C1684
	public override string get_LocalName() { }

	// RVA: 0x11C16A4
	public override string get_NamespaceURI() { }

	// RVA: 0x11C16C4
	public override string get_Prefix() { }

	// RVA: 0x11C16E4
	public override void set_Prefix(string value) { }

	// RVA: 0x11C1794
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11C179C
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11C17A4
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x11C17C4
	internal override bool get_IsContainer() { }

	// RVA: 0x11C17CC
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11C1394
	public bool get_IsEmpty() { }

	// RVA: 0x11C13A4
	public void set_IsEmpty(bool value) { }

	// RVA: 0x11C1A28
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x11C1A38
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11C1A40
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11C1A58
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x11C1BBC
	public virtual bool get_HasAttributes() { }

	// RVA: 0x11C1BE8
	public virtual string GetAttribute(string name) { }

	// RVA: 0x11C1C30
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x11C1CEC
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x11C1D54
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x11C1E70
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x11C1EB8
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x11C1FA8
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x11C2024
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x11C20F0
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x11C2118
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11C2230
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x11C2484
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0x11C25A0
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11C2608
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x11C2654
	public override void RemoveAll() { }

	// RVA: 0x11C19B4
	internal void RemoveAllChildren() { }

	// RVA: 0x11C274C
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11C2754
	public override void set_InnerXml(string value) { }

	// RVA: 0x11C290C
	public override string get_InnerText() { }

	// RVA: 0x11C2A1C
	public override void set_InnerText(string value) { }

	// RVA: 0x11C2B34
	public override XmlNode get_NextSibling() { }

	// RVA: 0x11C2B84
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x11C2B8C
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x11C2B94
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

	// RVA: 0x11C2BA4
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x11C2CFC
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11C2D58
	public override bool get_IsReadOnly() { }

	// RVA: 0x11C2D60
	public override string get_Name() { }

	// RVA: 0x11C2D68
	public override string get_LocalName() { }

	// RVA: 0x11C2D70
	public override string get_InnerText() { }

	// RVA: 0x11C2D74
	public override void set_InnerText(string value) { }

	// RVA: 0x11C2DD0
	internal override bool get_IsContainer() { }

	// RVA: 0x11C2DD8
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x11C2FB4
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11C2FBC
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11C2FD4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11C2FDC
	public string get_SystemId() { }

	// RVA: 0x11C2FE4
	public override string get_OuterXml() { }

	// RVA: 0x11C2FFC
	public override void set_InnerXml(string value) { }

	// RVA: 0x11C3058
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11C305C
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11C3060
	public override string get_BaseURI() { }

	// RVA: 0x11C3068
	internal void SetBaseURI(string inBaseURI) { }

}

// Namespace: System.Xml
public class XmlEntityReference
{
	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Methods

	// RVA: 0x11C3070
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x11C3174
	public override string get_Name() { }

	// RVA: 0x11C317C
	public override string get_LocalName() { }

	// RVA: 0x11C3184
	public override string get_Value() { }

	// RVA: 0x11C318C
	public override void set_Value(string value) { }

	// RVA: 0x11C31E8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11C31F0
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11C3234
	public override bool get_IsReadOnly() { }

	// RVA: 0x11C323C
	internal override bool get_IsContainer() { }

	// RVA: 0x11C3244
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x11C396C
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x11C397C
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x11C3984
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11C398C
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11C39A4
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11C39D4
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11C3CD0
	public override string get_BaseURI() { }

	// RVA: 0x11C3D04
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x11C3DEC
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

	// RVA: 0x11C3EA0
	public void .ctor() { }

	// RVA: 0x11C3FFC
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x11C4030
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0x11C4098
	internal XmlNameTable get_NameTable() { }

}

// Namespace: System.Xml
public abstract class XmlLinkedNode
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Methods

	// RVA: 0x11C078C
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x11C40A0
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x11C4118
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

	// RVA: 0x11BFE58
	public void .ctor() { }

	// RVA: 0x11C4174
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x11C43EC
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x11C4AB8
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x11C4470
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x11C4C10
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x11C56DC
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x11C58AC
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x11C4F38
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x11C5234
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x11C53E0
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x11C5BD8
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x11C72D8
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x11C07B8
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x11C75E0
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x11C63A4
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x11C7A38
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x11BFE60
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x11C2884
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x11C88BC
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x11C8600
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x11C88C4
	private string EntitizeName(string name) { }

	// RVA: 0x11C2F08
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x11C338C
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x11C8340
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x11C60E4
	internal static void ParseXmlDeclarationValue(string strValue, string version, string encoding, string standalone) { }

	// RVA: 0x11C55C8
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

	// RVA: 0x11C8940
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11C8A80
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x11C8FB0
	public string get_LocalName() { }

	// RVA: 0x11C8FB8
	public string get_NamespaceURI() { }

	// RVA: 0x11C8FC0
	public string get_Prefix() { }

	// RVA: 0x11C8FC8
	public int get_HashCode() { }

	// RVA: 0x11C8FD0
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x11C148C
	public string get_Name() { }

	// RVA: 0x11C8FD8
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x11C8FE0
	public virtual bool get_IsDefault() { }

	// RVA: 0x11C8FE8
	public virtual bool get_IsNil() { }

	// RVA: 0x11C8FF0
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x11C8FF8
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x11C9000
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x11C9008
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x11C9010
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11C901C
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

	// RVA: 0x11C8B34
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x11C90E8
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x11C9120
	public override bool get_IsDefault() { }

	// RVA: 0x11C912C
	public override bool get_IsNil() { }

	// RVA: 0x11C9138
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x11C9140
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x11C9148
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x11C91D0
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x11C9094
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x11C90A8
	public void SetIsDefault(bool value) { }

	// RVA: 0x11C90C8
	public void SetIsNil(bool value) { }

	// RVA: 0x11C9258
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }

}

// Namespace: 
private class SingleObjectEnumerator
{
	// Fields
	private object loneValue; // 0x10
	private int position; // 0x18

	// Methods

	// RVA: 0x11CA67C
	public void .ctor(object value) { }

	// RVA: 0x11CA6B8
	public object get_Current() { }

	// RVA: 0x11CA710
	public bool MoveNext() { }

	// RVA: 0x11CA728
	public void Reset() { }

}

// Namespace: 
internal struct SmallXmlNodeList
{
	// Fields
	private object field; // 0x10

	// Methods

	// RVA: 0x11C9B3C
	public int get_Count() { }

	// RVA: 0x11C9768
	public object get_Item(int index) { }

	// RVA: 0x11C9EB0
	public void Add(object value) { }

	// RVA: 0x11CA214
	public void RemoveAt(int index) { }

	// RVA: 0x11CA4C8
	public void Insert(int index, object value) { }

	// RVA: 0x11C9BD4
	public IEnumerator GetEnumerator() { }

}

// Namespace: System.Xml
public class XmlNamedNodeMap
{
	// Fields
	internal XmlNode parent; // 0x10
	internal SmallXmlNodeList nodes; // 0x18

	// Methods

	// RVA: 0x11C0940
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x11C95C4
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x11C9854
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x11C9AAC
	public virtual int get_Count() { }

	// RVA: 0x11C9BCC
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11C9678
	internal int FindNodeOffset(string name) { }

	// RVA: 0x11C9920
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x11C9D00
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x11C9FF8
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x11CA0A4
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x11C9A54
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x11CA30C
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

}

// Namespace: System.Xml
public abstract class XmlNode
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Methods

	// RVA: 0x11BFCDC
	internal void .ctor() { }

	// RVA: 0x11C2C74
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x11CA734
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: 0x11CA7DC
	public XmlNodeList SelectNodes(string xpath) { }

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: 0x11CA88C
	public virtual string get_Value() { }

	// RVA: 0x11CA894
	public virtual void set_Value(string value) { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x11CA968
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x11CAA5C
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x11CAAC4
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x11CAACC
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x11CAAD4
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x11CAADC
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x11CAB98
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x11CABC0
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x11CABD0
	internal virtual bool get_IsContainer() { }

	// RVA: 0x11CABD8
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x11CABE0
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x11CABE4
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x11CAC50
	internal bool IsConnected() { }

	// RVA: 0x11CACB0
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11CB328
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11CB910
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x11CBD30
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x11CBD78
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x11CC2CC
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x11CC49C
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x11CC4A4
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11CC4AC
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11CC4B4
	public virtual bool get_HasChildNodes() { }

	// RVA: -1
	public abstract XmlNode CloneNode(bool deep) { }

	// RVA: 0x11CC4DC
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x11CC57C
	public virtual string get_NamespaceURI() { }

	// RVA: 0x11CC594
	public virtual string get_Prefix() { }

	// RVA: 0x11CC5AC
	public virtual void set_Prefix(string value) { }

	// RVA: -1
	public abstract string get_LocalName() { }

	// RVA: 0x11CC5B0
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x11CC6B8
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x11CC7C4
	private object System.ICloneable.Clone() { }

	// RVA: 0x11CC7D8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x11C05B4
	public IEnumerator GetEnumerator() { }

	// RVA: 0x11CC840
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x11C2910
	public virtual string get_InnerText() { }

	// RVA: 0x11CC948
	public virtual void set_InnerText(string value) { }

	// RVA: 0x11CCA2C
	public virtual string get_OuterXml() { }

	// RVA: 0x11CCBE0
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x11CCC3C
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11CCCB8
	public virtual string get_BaseURI() { }

	// RVA: -1
	public abstract void WriteTo(XmlWriter w) { }

	// RVA: -1
	public abstract void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11C26D8
	public virtual void RemoveAll() { }

	// RVA: 0x11CCDD8
	internal XmlDocument get_Document() { }

	// RVA: 0x11CCE88
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x11CCEBC
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x11C3338
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x11CD31C
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x11CD324
	internal static void SplitName(string name, string prefix, string localName) { }

	// RVA: 0x11CD400
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x11CD46C
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x11CD59C
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11CD5F0
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x11CD644
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x11CD7D8
	internal virtual string get_XmlLang() { }

	// RVA: 0x11CD8D4
	internal virtual XPathNodeType get_XPNodeType() { }

	// RVA: 0x11CD8DC
	internal virtual string get_XPLocalName() { }

	// RVA: 0x11CD8F4
	internal virtual bool get_IsText() { }

	// RVA: 0x11CD8FC
	public virtual XmlNode get_PreviousText() { }

	// RVA: 0x11C198C
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x11CB2E8
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

	// RVA: 0x11CD904
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x11CD9EC
	public XmlNodeChangedAction get_Action() { }

}

// Namespace: System.Xml
public sealed class XmlNodeChangedEventHandler
{
	// Methods

	// RVA: 0x11CD9F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11CDB18
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

	// RVA: 0x11CDB2C
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0x11CDB38
	private void System.IDisposable.Dispose() { }

	// RVA: 0x11CDB44
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x11CDB48
	protected void .ctor() { }

}

// Namespace: 
internal struct VirtualAttribute
{
	// Fields
	internal string name; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x11CDEF0
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

	// RVA: 0x11CDB50
	public void .ctor(XmlNode node) { }

	// RVA: 0x11CDF24
	public XmlNodeType get_NodeType() { }

	// RVA: 0x11CDF74
	public string get_NamespaceURI() { }

	// RVA: 0x11CDF9C
	public string get_Name() { }

	// RVA: 0x11CE0A8
	public string get_LocalName() { }

	// RVA: 0x11CE14C
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0x11CE088
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0x11CE154
	public string get_Prefix() { }

	// RVA: 0x11CE17C
	public string get_Value() { }

	// RVA: 0x11CE628
	public string get_BaseURI() { }

	// RVA: 0x11CE650
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x11CE678
	public string get_XmlLang() { }

	// RVA: 0x11CE6A0
	public bool get_IsEmptyElement() { }

	// RVA: 0x11CE758
	public bool get_IsDefault() { }

	// RVA: 0x11CE814
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11CE83C
	public XmlNameTable get_NameTable() { }

	// RVA: 0x11CE844
	public int get_AttributeCount() { }

	// RVA: 0x11CEAE8
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0x11CE454
	private void InitDecAttr() { }

	// RVA: 0x11CEB5C
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0x11CEC40
	public string GetDeclarationAttr(int i) { }

	// RVA: 0x11CEC98
	public int GetDecAttrInd(string name) { }

	// RVA: 0x11CE9A4
	private void InitDocTypeAttr() { }

	// RVA: 0x11CED40
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0x11CEDF0
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0x11CEE48
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0x11CEEF0
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0x11CEF38
	public string GetAttribute(string name) { }

	// RVA: 0x11CF1B4
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x11CF200
	public string GetAttribute(string name, string ns) { }

	// RVA: 0x11CF49C
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0x11CF6F8
	public void LogMove(int level) { }

	// RVA: 0x11CF740
	public void RollBackMove(int level) { }

	// RVA: 0x11CF790
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0x11CF7C4
	public void ResetToAttribute(int level) { }

	// RVA: 0x11CF8AC
	public void ResetMove(int level, XmlNodeType nt) { }

	// RVA: 0x11CFAA0
	public bool MoveToAttribute(string name) { }

	// RVA: 0x11CFD00
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x11CFAB8
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0x11CFDFC
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x11D0060
	public bool MoveToNextAttribute(int level) { }

	// RVA: 0x11D02B0
	public bool MoveToParent() { }

	// RVA: 0x11D0334
	public bool MoveToFirstChild() { }

	// RVA: 0x11D03C0
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0x11D0450
	public bool MoveToNext() { }

	// RVA: 0x11D04D8
	public bool MoveToElement() { }

	// RVA: 0x11D0580
	public string LookupNamespace(string prefix) { }

	// RVA: 0x11D087C
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0x11D09A8
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x11D0D70
	internal System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11D1264
	public bool ReadAttributeValue(int level, bool bResolveEntity, XmlNodeType nt) { }

	// RVA: 0x11D14EC
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

	// RVA: 0x11D14F4
	public void .ctor(XmlNode node) { }

	// RVA: 0x11D1608
	internal bool IsInReadingStates() { }

	// RVA: 0x11D1618
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11D1634
	public override string get_Name() { }

	// RVA: 0x11D1678
	public override string get_LocalName() { }

	// RVA: 0x11D172C
	public override string get_NamespaceURI() { }

	// RVA: 0x11D1784
	public override string get_Prefix() { }

	// RVA: 0x11D17DC
	public override string get_Value() { }

	// RVA: 0x11D1820
	public override int get_Depth() { }

	// RVA: 0x11D1828
	public override string get_BaseURI() { }

	// RVA: 0x11D1858
	public override bool get_CanResolveEntity() { }

	// RVA: 0x11D1860
	public override bool get_IsEmptyElement() { }

	// RVA: 0x11D1928
	public override bool get_IsDefault() { }

	// RVA: 0x11D195C
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x11D19A4
	public override string get_XmlLang() { }

	// RVA: 0x11D19FC
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11D1A44
	public override int get_AttributeCount() { }

	// RVA: 0x11D1A84
	public override string GetAttribute(string name) { }

	// RVA: 0x11D1AB8
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x11D1B04
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x11D1B7C
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x11D1CF4
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x11D1F1C
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x11D2070
	public override bool MoveToNextAttribute() { }

	// RVA: 0x11D21D8
	public override bool MoveToElement() { }

	// RVA: 0x11D2388
	public override bool Read() { }

	// RVA: 0x11D2390
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x11D2564
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x11D2B30
	private void SetEndOfFile() { }

	// RVA: 0x11D2B48
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x11D297C
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x11D2954
	private void ReSetReadingMarks() { }

	// RVA: 0x11D2C70
	public override bool get_EOF() { }

	// RVA: 0x11D2C94
	public override void Close() { }

	// RVA: 0x11D2CA0
	public override ReadState get_ReadState() { }

	// RVA: 0x11D2CA8
	public override void Skip() { }

	// RVA: 0x11D2CB0
	public override string ReadString() { }

	// RVA: 0x11D2D58
	public override bool get_HasAttributes() { }

	// RVA: 0x11D2D80
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x11D2DA0
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x11D2DE4
	public override void ResolveEntity() { }

	// RVA: 0x11D2E6C
	public override bool ReadAttributeValue() { }

	// RVA: 0x11D1CD0
	private void FinishReadBinary() { }

	// RVA: 0x11D2ECC
	private System.Collections.Generic.IDictionary<System.String,System.String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11D2EE8
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x11D2F04
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x11D2F78
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

	// RVA: 0x11C79A0
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x11D2FA0
	public override string get_Name() { }

	// RVA: 0x11D2FA8
	public override string get_LocalName() { }

	// RVA: 0x11D2FB0
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11D2FB8
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11D3014
	public override bool get_IsReadOnly() { }

	// RVA: 0x11D301C
	public override string get_OuterXml() { }

	// RVA: 0x11D3034
	public override void set_InnerXml(string value) { }

	// RVA: 0x11D3090
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11D3094
	public override void WriteContentTo(XmlWriter w) { }

}

// Namespace: System.Xml
public class XmlProcessingInstruction
{
	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Methods

	// RVA: 0x11C7578
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0x11D3098
	public override string get_Name() { }

	// RVA: 0x11D30BC
	public override string get_LocalName() { }

	// RVA: 0x11D30C8
	public override string get_Value() { }

	// RVA: 0x11D30D0
	public override void set_Value(string value) { }

	// RVA: 0x11D3194
	public void set_Data(string value) { }

	// RVA: 0x11D3258
	public override string get_InnerText() { }

	// RVA: 0x11D3260
	public override void set_InnerText(string value) { }

	// RVA: 0x11D3324
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11D332C
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11D3370
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11D33A0
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11D33A4
	internal override string get_XPLocalName() { }

	// RVA: 0x11D33B0
	internal override XPathNodeType get_XPNodeType() { }

}

// Namespace: System.Xml
public class XmlSignificantWhitespace
{
	// Methods

	// RVA: 0x11C7428
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x11D33B8
	public override string get_Name() { }

	// RVA: 0x11D33E4
	public override string get_LocalName() { }

	// RVA: 0x11D3410
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11D3418
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11D34BC
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11D351C
	public override string get_Value() { }

	// RVA: 0x11D352C
	public override void set_Value(string value) { }

	// RVA: 0x11D35BC
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11D3604
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11D3608
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x11D363C
	internal override bool get_IsText() { }

	// RVA: 0x11D3644
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
public class XmlText
{
	// Methods

	// RVA: 0x11C5BCC
	internal void .ctor(string strData) { }

	// RVA: 0x11C5BC4
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x11D3694
	public override string get_Name() { }

	// RVA: 0x11D36C0
	public override string get_LocalName() { }

	// RVA: 0x11D36EC
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11D36F4
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11D3790
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11D37F0
	public override string get_Value() { }

	// RVA: 0x11D3800
	public override void set_Value(string value) { }

	// RVA: 0x11D38E0
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11D3928
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11D392C
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x11D3934
	internal override bool get_IsText() { }

	// RVA: 0x11D393C
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal class XmlUnspecifiedAttribute
{
	// Fields
	private bool fSpecified; // 0x28

	// Methods

	// RVA: 0x11C75D8
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x11D398C
	public override bool get_Specified() { }

	// RVA: 0x11D3994
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11D3AC8
	public override void set_InnerText(string value) { }

	// RVA: 0x11D3AF4
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11D3B20
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x11D3B4C
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x11D3B78
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x11D3BA4
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11D3BB8
	internal void SetSpecified(bool f) { }

}

// Namespace: System.Xml
public class XmlWhitespace
{
	// Methods

	// RVA: 0x11C74D0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x11D3BC0
	public override string get_Name() { }

	// RVA: 0x11D3BEC
	public override string get_LocalName() { }

	// RVA: 0x11D3C18
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x11D3C20
	public override XmlNode get_ParentNode() { }

	// RVA: 0x11D3CC4
	public override string get_Value() { }

	// RVA: 0x11D3CD4
	public override void set_Value(string value) { }

	// RVA: 0x11D3D64
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x11D3DC4
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x11D3E0C
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x11D3E10
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x11D3E44
	internal override bool get_IsText() { }

	// RVA: 0x11D3E4C
	public override XmlNode get_PreviousText() { }

}

// Namespace: System.Xml
internal sealed class EmptyEnumerator
{
	// Methods

	// RVA: 0x11D3E9C
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x11D3EA4
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x11D3EA8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x11D3F04
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

	// RVA: 0x11D3F0C
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x11D3F90
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x11D401C
	internal object Push() { }

	// RVA: 0x11D4168
	internal object Pop() { }

	// RVA: 0x11D41B8
	internal object Peek() { }

	// RVA: 0x11D4204
	internal void AddToTop(object o) { }

	// RVA: 0x11D4290
	internal object get_Item(int index) { }

	// RVA: 0x11D4310
	internal void set_Item(int index, object value) { }

	// RVA: 0x11D43C8
	internal int get_Length() { }

	// RVA: 0x11D43D0
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x11D442C
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

	// RVA: 0x11D451C
	public virtual bool HasLineInfo() { }

	// RVA: 0x11D4524
	public virtual int get_LineNumber() { }

	// RVA: 0x11D452C
	public virtual int get_LinePosition() { }

	// RVA: 0x11D4534
	public static PositionInfo GetPositionInfo(object o) { }

	// RVA: 0x11D4640
	public void .ctor() { }

}

// Namespace: System.Xml
internal class ReaderPositionInfo
{
	// Fields
	private IXmlLineInfo lineInfo; // 0x10

	// Methods

	// RVA: 0x11D460C
	public void .ctor(IXmlLineInfo lineInfo) { }

	// RVA: 0x11D4648
	public override bool HasLineInfo() { }

	// RVA: 0x11D46FC
	public override int get_LineNumber() { }

	// RVA: 0x11D47B4
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

	// RVA: 0x11D486C
	public void .ctor(int lineNo, int linePos) { }

	// RVA: 0x11D4874
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

	// RVA: 0x11D4F6C
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

	// RVA: 0x11C3F74
	public void .ctor() { }

	// RVA: 0x11D487C
	public override string Add(string key) { }

	// RVA: 0x11D4B14
	public override string Add(Char[] key, int start, int len) { }

	// RVA: 0x11D4E0C
	public override string Get(string value) { }

	// RVA: 0x11D49E0
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x11D4FC4
	private void Grow() { }

	// RVA: 0x11D4D30
	private static bool TextEquals(string str1, Char[] str2, int str2Start, int str2Length) { }

}

// Namespace: System.Xml
internal static class Ref
{
	// Methods

	// RVA: 0x11C8934
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

	// RVA: 0x11E1AB0
	internal void .ctor(string name, int lineNo, int linePos) { }

}

// Namespace: 
private class ParseElementOnlyContent_LocalFrame
{
	// Fields
	public int startParenEntityId; // 0x10
	public Token parsingSchema; // 0x14

	// Methods

	// RVA: 0x11E1B08
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

	// RVA: 0x11D514C
	private void .ctor() { }

	// RVA: 0x11C78A8
	internal static IDtdParser Create() { }

	// RVA: 0x11D520C
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x11D5648
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x11D5B7C
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x11D60A8
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x11D60D8
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x11D60E8
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x11D60F8
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x11D61D0
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0x11D6200
	private bool get_SupportNamespaces() { }

	// RVA: 0x11D6208
	private bool get_Normalize() { }

	// RVA: 0x11D5BB0
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x11D6274
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x11D6210
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x11D7EAC
	private void ParseInternalSubset() { }

	// RVA: 0x11D7EB0
	private void ParseExternalSubset() { }

	// RVA: 0x11D8098
	private void ParseSubset() { }

	// RVA: 0x11D84B0
	private void ParseAttlistDecl() { }

	// RVA: 0x11DA6B8
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x11DAF54
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x11D8B9C
	private void ParseElementDecl() { }

	// RVA: 0x11DBA7C
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x11DBE38
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x11DB790
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x11D8FA4
	private void ParseEntityDecl() { }

	// RVA: 0x11D93F8
	private void ParseNotationDecl() { }

	// RVA: 0x11DB3BC
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x11D973C
	private void ParseComment() { }

	// RVA: 0x11D9A38
	private void ParsePI() { }

	// RVA: 0x11D9C98
	private void ParseCondSection() { }

	// RVA: 0x11D7688
	private void ParseExternalId(Token idTokenType, Token declType, string publicId, string systemId) { }

	// RVA: 0x11D68B0
	private Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x11DC888
	private Token ScanSubsetContent() { }

	// RVA: 0x11DC7FC
	private Token ScanNameExpected() { }

	// RVA: 0x11DC82C
	private Token ScanQNameExpected() { }

	// RVA: 0x11DC85C
	private Token ScanNmtokenExpected() { }

	// RVA: 0x11DD0B0
	private Token ScanDoctype1() { }

	// RVA: 0x11DD240
	private Token ScanDoctype2() { }

	// RVA: 0x11DFA8C
	private Token ScanClosingTag() { }

	// RVA: 0x11DD310
	private Token ScanElement1() { }

	// RVA: 0x11DD5E0
	private Token ScanElement2() { }

	// RVA: 0x11DD7C4
	private Token ScanElement3() { }

	// RVA: 0x11DD860
	private Token ScanElement4() { }

	// RVA: 0x11DD960
	private Token ScanElement5() { }

	// RVA: 0x11DDA84
	private Token ScanElement6() { }

	// RVA: 0x11DDB68
	private Token ScanElement7() { }

	// RVA: 0x11DDBD0
	private Token ScanAttlist1() { }

	// RVA: 0x11DDCA0
	private Token ScanAttlist2() { }

	// RVA: 0x11DE46C
	private Token ScanAttlist3() { }

	// RVA: 0x11DE518
	private Token ScanAttlist4() { }

	// RVA: 0x11DE5FC
	private Token ScanAttlist5() { }

	// RVA: 0x11DE6E0
	private Token ScanAttlist6() { }

	// RVA: 0x11DEADC
	private Token ScanAttlist7() { }

	// RVA: 0x11E0184
	private Token ScanLiteral(LiteralType literalType) { }

	// RVA: 0x11E0EE8
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x11DEBA4
	private Token ScanNotation1() { }

	// RVA: 0x11DECF8
	private Token ScanSystemId() { }

	// RVA: 0x11DEEEC
	private Token ScanEntity1() { }

	// RVA: 0x11DEF74
	private Token ScanEntity2() { }

	// RVA: 0x11DF104
	private Token ScanEntity3() { }

	// RVA: 0x11DEDB0
	private Token ScanPublicId1() { }

	// RVA: 0x11DEE68
	private Token ScanPublicId2() { }

	// RVA: 0x11DF21C
	private Token ScanCondSection1() { }

	// RVA: 0x11DF514
	private Token ScanCondSection2() { }

	// RVA: 0x11DF5B0
	private Token ScanCondSection3() { }

	// RVA: 0x11DFDF8
	private void ScanName() { }

	// RVA: 0x11DFE00
	private void ScanQName() { }

	// RVA: 0x11E12AC
	private void ScanQName(bool isQName) { }

	// RVA: 0x11E153C
	private bool ReadDataInName() { }

	// RVA: 0x11DFE08
	private void ScanNmtoken() { }

	// RVA: 0x11DFF84
	private bool EatPublicKeyword() { }

	// RVA: 0x11E0084
	private bool EatSystemKeyword() { }

	// RVA: 0x11D74F8
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x11DB3A0
	private string GetNameString() { }

	// RVA: 0x11DB694
	private string GetNmtokenString() { }

	// RVA: 0x11DB724
	private string GetValue() { }

	// RVA: 0x11DB6B0
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x11DFB24
	private int ReadData() { }

	// RVA: 0x11D6704
	private void LoadParsingBuffer() { }

	// RVA: 0x11D7EA4
	private void SaveParsingBuffer() { }

	// RVA: 0x11DA148
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x11DC6D4
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x11E1798
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x11DFBEC
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x11E1054
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x11D9F30
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x11DB1AC
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x11D65B0
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x11DB1A0
	private bool IsAttributeValueType(Token token) { }

	// RVA: 0x11DA364
	private int get_LineNo() { }

	// RVA: 0x11DA41C
	private int get_LinePos() { }

	// RVA: 0x11D6484
	private string get_BaseUriStr() { }

	// RVA: 0x11D748C
	private void OnUnexpectedError() { }

	// RVA: 0x11D9C80
	private void Throw(int curPos, string res) { }

	// RVA: 0x11DBEC0
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x11DC344
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x11DA4D0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x11D5AFC
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x11DC650
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	// RVA: 0x11DA35C
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x11DC1CC
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x11DC728
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x11E1584
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

	// RVA: 0x11E1B38
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0x11E1C0C
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0x11E1CFC
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0x11E1E64
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0x11E1F1C
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0x11E2054
	internal static int ParseNCName(string s) { }

	// RVA: 0x11E20DC
	internal static int ParseQName(string s, int offset, int colonOffset) { }

	// RVA: 0x11E21FC
	internal static void ParseQNameThrow(string s, string prefix, string localName) { }

	// RVA: 0x11E237C
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x11E2878
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x11E2B30
	internal static void SplitQName(string name, string prefix, string lname) { }

	// RVA: 0x11E2F00
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

	// RVA: 0x11E2FD0
	private static object get_StaticLock() { }

	// RVA: 0x11E3084
	private static void InitInstance() { }

	// RVA: 0x11E339C
	private static void SetProperties(Byte[] chProps, string ranges, Byte value) { }

	// RVA: 0x11E3528
	private void .ctor(Byte[] charProperties) { }

	// RVA: 0x11E26B0
	public static XmlCharType get_Instance() { }

	// RVA: 0x11E3530
	public bool IsWhiteSpace(Char ch) { }

	// RVA: 0x11E2678
	public bool IsNCNameSingleChar(Char ch) { }

	// RVA: 0x11E2734
	public bool IsStartNCNameSingleChar(Char ch) { }

	// RVA: 0x11E3568
	public bool IsNameSingleChar(Char ch) { }

	// RVA: 0x11E35A8
	public bool IsCharData(Char ch) { }

	// RVA: 0x11E35E0
	public bool IsPubidChar(Char ch) { }

	// RVA: 0x11E3660
	internal bool IsTextChar(Char ch) { }

	// RVA: 0x11E3698
	public bool IsLetter(Char ch) { }

	// RVA: 0x11E36D0
	public bool IsNCNameCharXml4e(Char ch) { }

	// RVA: 0x11E3708
	public bool IsStartNCNameCharXml4e(Char ch) { }

	// RVA: 0x11E3748
	public bool IsNameCharXml4e(Char ch) { }

	// RVA: 0x11E3788
	public static bool IsDigit(Char ch) { }

	// RVA: 0x11E37AC
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0x11E37BC
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0x11E37CC
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0x11E37DC
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0x11E37F4
	internal static void SplitSurrogateChar(int combinedChar, Char lowChar, Char highChar) { }

	// RVA: 0x11E382C
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x11E38C8
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x11E3954
	internal int IsOnlyCharData(string str) { }

	// RVA: 0x11E3A58
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x11E3B14
	internal int IsPublicId(string str) { }

	// RVA: 0x11E3798
	private static bool InRange(int value, int start, int end) { }

}

// Namespace: System.Xml
internal static class XmlComplianceUtil
{
	// Methods

	// RVA: 0x11E3BD0
	public static string NonCDataNormalize(string value) { }

	// RVA: 0x11E3EF0
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

	// RVA: 0x11E40D0
	public static string EncodeName(string name) { }

	// RVA: 0x11E4BE0
	public static string EncodeLocalName(string name) { }

	// RVA: 0x11E4C48
	public static string DecodeName(string name) { }

	// RVA: 0x11E4138
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0x11E5680
	private static int FromHex(Char digit) { }

	// RVA: 0x11E56A8
	internal static Byte[] FromBinHexString(string s) { }

	// RVA: 0x11E5730
	internal static Byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0x11E57A8
	internal static string ToBinHexString(Byte[] inArray) { }

	// RVA: 0x11E5818
	public static string VerifyName(string name) { }

	// RVA: 0x11E5AA8
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0x11E5CC8
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0x11E5F44
	public static string VerifyNCName(string name) { }

	// RVA: 0x11E5FCC
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0x11E613C
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0x11E625C
	public static string VerifyTOKEN(string token) { }

	// RVA: 0x11E638C
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0x11E64C8
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0x11E66BC
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0x11E67B0
	public static string ToString(bool value) { }

	// RVA: 0x11E681C
	public static string ToString(Char value) { }

	// RVA: 0x11E6860
	public static string ToString(Decimal value) { }

	// RVA: 0x11E6908
	public static string ToString(SByte value) { }

	// RVA: 0x11E6940
	public static string ToString(Int16 value) { }

	// RVA: 0x11E6978
	public static string ToString(int value) { }

	// RVA: 0x11E69B0
	public static string ToString(Int64 value) { }

	// RVA: 0x11E69E8
	public static string ToString(Byte value) { }

	// RVA: 0x11E6A20
	public static string ToString(UInt16 value) { }

	// RVA: 0x11E6A58
	public static string ToString(UInt32 value) { }

	// RVA: 0x11E6A90
	public static string ToString(UInt64 value) { }

	// RVA: 0x11E6AC8
	public static string ToString(float value) { }

	// RVA: 0x11E6D14
	public static string ToString(Double value) { }

	// RVA: 0x11E6EC0
	public static string ToString(TimeSpan value) { }

	// RVA: 0x11E6F10
	public static string ToString(DateTime value, string format) { }

	// RVA: 0x11E6FEC
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x11E744C
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x11E74D8
	public static string ToString(Guid value) { }

	// RVA: 0x11E7500
	public static bool ToBoolean(string s) { }

	// RVA: 0x11E77EC
	internal static Exception TryToBoolean(string s, bool result) { }

	// RVA: 0x11E7AB0
	public static Char ToChar(string s) { }

	// RVA: 0x11E7B70
	internal static Exception TryToChar(string s, Char result) { }

	// RVA: 0x11E7D28
	public static Decimal ToDecimal(string s) { }

	// RVA: 0x11E7DA0
	internal static Exception TryToDecimal(string s, Decimal result) { }

	// RVA: 0x11E7F38
	internal static Decimal ToInteger(string s) { }

	// RVA: 0x11E7FB0
	internal static Exception TryToInteger(string s, Decimal result) { }

	// RVA: 0x11E8148
	public static SByte ToSByte(string s) { }

	// RVA: 0x11E817C
	internal static Exception TryToSByte(string s, SByte result) { }

	// RVA: 0x11E82EC
	public static Int16 ToInt16(string s) { }

	// RVA: 0x11E8320
	internal static Exception TryToInt16(string s, Int16 result) { }

	// RVA: 0x11E8490
	public static int ToInt32(string s) { }

	// RVA: 0x11E84C4
	internal static Exception TryToInt32(string s, int result) { }

	// RVA: 0x11E8634
	public static Int64 ToInt64(string s) { }

	// RVA: 0x11E8668
	internal static Exception TryToInt64(string s, Int64 result) { }

	// RVA: 0x11E87D8
	public static Byte ToByte(string s) { }

	// RVA: 0x11E880C
	internal static Exception TryToByte(string s, Byte result) { }

	// RVA: 0x11E897C
	public static UInt16 ToUInt16(string s) { }

	// RVA: 0x11E89B0
	internal static Exception TryToUInt16(string s, UInt16 result) { }

	// RVA: 0x11E8B20
	public static UInt32 ToUInt32(string s) { }

	// RVA: 0x11E8B54
	internal static Exception TryToUInt32(string s, UInt32 result) { }

	// RVA: 0x11E8CC4
	public static UInt64 ToUInt64(string s) { }

	// RVA: 0x11E8CF8
	internal static Exception TryToUInt64(string s, UInt64 result) { }

	// RVA: 0x11E8E68
	public static float ToSingle(string s) { }

	// RVA: 0x11E9024
	internal static Exception TryToSingle(string s, float result) { }

	// RVA: 0x11E92F8
	public static Double ToDouble(string s) { }

	// RVA: 0x11E9488
	internal static Exception TryToDouble(string s, Double result) { }

	// RVA: 0x11E975C
	internal static Double ToXPathDouble(object o) { }

	// RVA: 0x11E9A40
	internal static Double XPathRound(Double value) { }

	// RVA: 0x11E9B48
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0x11E9CE4
	internal static Exception TryToTimeSpan(string s, TimeSpan result) { }

	// RVA: 0x11E9DA8
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0x11E9E84
	private static void CreateAllDateTimeFormats() { }

	// RVA: 0x11EA448
	public static DateTime ToDateTime(string s) { }

	// RVA: 0x11EA558
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0x11EA62C
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x11EA890
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0x11EA95C
	public static Guid ToGuid(string s) { }

	// RVA: 0x11EA98C
	internal static Exception TryToGuid(string s, Guid result) { }

	// RVA: 0x11E7234
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x11E7340
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x11EAB64
	internal static Uri ToUri(string s) { }

	// RVA: 0x11EAD9C
	internal static Exception TryToUri(string s, Uri result) { }

	// RVA: 0x11EB044
	internal static bool StrEqual(Char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0x11E7764
	internal static string TrimString(string value) { }

	// RVA: 0x11EB120
	internal static string TrimStringStart(string value) { }

	// RVA: 0x11EB1A8
	internal static string TrimStringEnd(string value) { }

	// RVA: 0x11EB230
	internal static string[] SplitString(string value) { }

	// RVA: 0x11E6C78
	internal static bool IsNegativeZero(Double value) { }

	// RVA: 0x11EB2BC
	private static Int64 DoubleToInt64Bits(Double value) { }

	// RVA: 0x11EB2C4
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0x11EB4D0
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x11EB930
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x11EBA80
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0x11E5E08
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x11EBBA4
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi) { }

	// RVA: 0x11EBC70
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType) { }

	// RVA: 0x11EB5B0
	internal static Exception CreateInvalidSurrogatePairException(Char low, Char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x11EBCF0
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi) { }

	// RVA: 0x11EBDB4
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType) { }

	// RVA: 0x11EBE24
	internal static Exception CreateInvalidHighSurrogateCharException(Char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x11EB740
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0x11EBF2C
	internal static Exception CreateInvalidCharException(Char invChar, Char nextChar) { }

	// RVA: 0x11EBF98
	internal static Exception CreateInvalidCharException(Char invChar, Char nextChar, ExceptionType exceptionType) { }

	// RVA: 0x11E5980
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0x11EC090
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0x11EC15C
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Uri uri; // 0x10

	// Methods

	// RVA: 0x11ECE70
	public void .ctor() { }

	// RVA: 0x11ED004
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

	// RVA: 0x11ED090
	private void MoveNext() { }

	// RVA: 0x11ED948
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Xml
internal class XmlDownloadManager
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x11EC2E0
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11EC3E0
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11ECB60
	internal void Remove(string host) { }

	// RVA: 0x11ECCF0
	internal System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11ECE78
	private System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x11ECFFC
	public void .ctor() { }

}

// Namespace: System.Xml
internal class OpenedHost
{
	// Fields
	internal int nonCachedConnectionsCount; // 0x10

	// Methods

	// RVA: 0x11EC934
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

	// RVA: 0x11EC93C
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0x11ED9C8
	protected override void Finalize() { }

	// RVA: 0x11EDA78
	protected override void Dispose(bool disposing) { }

	// RVA: 0x11EDBC4
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x11EDBEC
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x11EDC14
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x11EDC3C
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x11EDC64
	public override void Flush() { }

	// RVA: 0x11EDC8C
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x11EDCB4
	public override int ReadByte() { }

	// RVA: 0x11EDCDC
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x11EDD04
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x11EDD2C
	public override void WriteByte(Byte value) { }

	// RVA: 0x11EDD54
	public override bool get_CanRead() { }

	// RVA: 0x11EDD78
	public override bool get_CanSeek() { }

	// RVA: 0x11EDD9C
	public override bool get_CanWrite() { }

	// RVA: 0x11EDDC0
	public override Int64 get_Length() { }

	// RVA: 0x11EDDE4
	public override Int64 get_Position() { }

	// RVA: 0x11EDE08
	public override void set_Position(Int64 value) { }

}

// Namespace: System.Xml
internal class XmlCachedStream
{
	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0x11EC9E4
	internal void .ctor(Uri uri, Stream stream) { }

}

// Namespace: System.Xml
internal class UTF16Decoder
{
	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0x11EDE30
	public void .ctor(bool bigEndian) { }

	// RVA: 0x11EDE64
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x11EDE74
	public override int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x11EDF64
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11EE0F4
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

}

// Namespace: System.Xml
internal class SafeAsciiDecoder
{
	// Methods

	// RVA: 0x11EE2E8
	public void .ctor() { }

	// RVA: 0x11EE2F0
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x11EE2F8
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11EE378
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

}

// Namespace: System.Xml
internal class Ucs4Encoding
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Methods

	// RVA: 0x11EE414
	public override string get_WebName() { }

	// RVA: 0x11EE420
	public override Decoder GetDecoder() { }

	// RVA: 0x11EE428
	public override int GetByteCount(Char[] chars, int index, int count) { }

	// RVA: 0x11EE490
	public override int GetByteCount(Char[] chars) { }

	// RVA: 0x11EE4B0
	public override Byte[] GetBytes(string s) { }

	// RVA: 0x11EE4B8
	public override int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	// RVA: 0x11EE4C0
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x11EE4C8
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: 0x11EE4EC
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11EE510
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x11EE528
	public override int get_CodePage() { }

	// RVA: 0x11EE530
	public override Encoder GetEncoder() { }

	// RVA: 0x11EE538
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0x11EE64C
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0x11EE760
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0x11EE874
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0x11EE988
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding1234
{
	// Methods

	// RVA: 0x11EE6A0
	public void .ctor() { }

	// RVA: 0x11EEA00
	public override string get_EncodingName() { }

	// RVA: 0x11EEA44
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding4321
{
	// Methods

	// RVA: 0x11EE58C
	public void .ctor() { }

	// RVA: 0x11EEB30
	public override string get_EncodingName() { }

	// RVA: 0x11EEB74
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding2143
{
	// Methods

	// RVA: 0x11EE7B4
	public void .ctor() { }

	// RVA: 0x11EEC5C
	public override string get_EncodingName() { }

	// RVA: 0x11EECA0
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal class Ucs4Encoding3412
{
	// Methods

	// RVA: 0x11EE8C8
	public void .ctor() { }

	// RVA: 0x11EED8C
	public override string get_EncodingName() { }

	// RVA: 0x11EEDD0
	public override Byte[] GetPreamble() { }

}

// Namespace: System.Xml
internal abstract class Ucs4Decoder
{
	// Fields
	internal Byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0x11EEE48
	public override int GetCharCount(Byte[] bytes, int index, int count) { }

	// RVA: -1
	internal abstract int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11EEE64
	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11EF06C
	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, int bytesUsed, int charsUsed, bool completed) { }

	// RVA: 0x11EF398
	internal void Ucs4ToUTF16(UInt32 code, Char[] chars, int charIndex) { }

	// RVA: 0x11EF3F4
	protected void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder4321
{
	// Methods

	// RVA: 0x11EF464
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11EEAC0
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder1234
{
	// Methods

	// RVA: 0x11EF71C
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11EE990
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder2143
{
	// Methods

	// RVA: 0x11EF9D4
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11EEBEC
	public void .ctor() { }

}

// Namespace: System.Xml
internal class Ucs4Decoder3412
{
	// Methods

	// RVA: 0x11EFC8C
	internal override int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	// RVA: 0x11EED1C
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

	// RVA: 0x11EFF44
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11F05D0
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11F0744
	public void .ctor() { }

	// RVA: 0x11F075C
	public void .ctor(string message) { }

	// RVA: 0x11F0778
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x11F0770
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11F0788
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11E27E4
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x11E2580
	internal void .ctor(string res, string arg) { }

	// RVA: 0x11F0A7C
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x11F0B78
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x11F0DE4
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x11F0C20
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x11EB828
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x11F0DEC
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11EBB00
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11F0EF8
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11F0FA0
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11F09C8
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x11F08C8
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x11F0354
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x11E276C
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x11F1048
	internal static string[] BuildCharExceptionArgs(Char[] data, int length, int invCharIndex) { }

	// RVA: 0x11E2C88
	internal static string[] BuildCharExceptionArgs(Char invChar, Char nextChar) { }

	// RVA: 0x11F10A4
	public int get_LineNumber() { }

	// RVA: 0x11F10AC
	public int get_LinePosition() { }

	// RVA: 0x11F10B4
	public override string get_Message() { }

	// RVA: 0x11F10CC
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

	// RVA: 0x11F10D4
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

	// RVA: 0x11F134C
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

	// RVA: 0x11F10DC
	internal void .ctor() { }

	// RVA: 0x11F10E4
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x11F1398
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x11F13A0
	public virtual string get_DefaultNamespace() { }

	// RVA: 0x11F13F8
	public virtual void PushScope() { }

	// RVA: 0x11F1408
	public virtual bool PopScope() { }

	// RVA: 0x11F1504
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x11F1ADC
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x11F1C28
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11F1DEC
	public virtual System.Collections.Generic.IDictionary<System.String,System.String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x11F20D4
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x11F18FC
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x11F2134
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

	// RVA: 0x11F2AA4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11F311C
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

	// RVA: 0x11F2224
	public void .ctor() { }

	// RVA: 0x11F2340
	public void .ctor(string name) { }

	// RVA: 0x11F22B8
	public void .ctor(string name, string ns) { }

	// RVA: 0x11F23C8
	public string get_Namespace() { }

	// RVA: 0x11F23D0
	public string get_Name() { }

	// RVA: 0x11F23D8
	public override int GetHashCode() { }

	// RVA: 0x11F26F0
	public bool get_IsEmpty() { }

	// RVA: 0x11F2734
	public override string ToString() { }

	// RVA: 0x11F27A8
	public override bool Equals(object other) { }

	// RVA: 0x11F29B8
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x11F28E0
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x11F2A1C
	public static string ToString(string name, string ns) { }

	// RVA: 0x11F24E4
	private static HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x11F2A9C
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0x11F2B60
	private static int GetHashCodeOfString(string s, int length, Int64 additionalEntropy) { }

	// RVA: 0x11F2B80
	internal void Init(string name, string ns) { }

	// RVA: 0x11F2BBC
	internal void SetNamespace(string ns) { }

	// RVA: 0x11F2BC4
	internal void Verify() { }

	// RVA: 0x11F2CE8
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0x11F2D60
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, string prefix) { }

	// RVA: 0x11F2FA0
	internal XmlQualifiedName Clone() { }

	// RVA: 0x11F3024
	private static void .cctor() { }

}

// Namespace: System.Xml
public abstract class XmlResolver
{
	// Methods

	// RVA: -1
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x11F3130
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x11F332C
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0x11F349C
	public virtual System.Threading.Tasks.Task<System.Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x11F34DC
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

	// RVA: 0x11F38AC
	private void MoveNext() { }

	// RVA: 0x11F3C9C
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

	// RVA: 0x11F34E4
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x11F35BC
	public void .ctor() { }

	// RVA: 0x11F35C4
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x11F3750
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x11F3754
	public override System.Threading.Tasks.Task<System.Object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

}

// Namespace: System.Xml
internal static class BinaryCompatibility
{
	// Methods

	// RVA: 0x11F3D1C
	public static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

}

// Namespace: System.Xml
internal static class Res
{
	// Methods

	// RVA: 0x11E597C
	public static string GetString(string name) { }

	// RVA: 0x11E2EF0
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

	// RVA: 0x11F3D24
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x11F3D2C
	internal bool get_HasLineInfo() { }

	// RVA: 0x11F3D34
	internal int GetCollapsedTextNode(XPathNode[] pageText) { }

	// RVA: 0x11F3D68
	internal int GetRootNode(XPathNode[] pageRoot) { }

	// RVA: 0x11F3D9C
	internal int GetXmlNamespaceNode(XPathNode[] pageXmlNmsp) { }

	// RVA: 0x11F3DD0
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x11F3EF0
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

	// RVA: 0x11F3FD8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11F43B0
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x11F44A4
	public void .ctor() { }

	// RVA: 0x11F44C0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x11F4628
	internal static XPathException Create(string res) { }

	// RVA: 0x11F4744
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0x11F4838
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0x11F4958
	internal static XPathException Create(string res, string arg, Exception innerException) { }

	// RVA: 0x11F46D0
	private void .ctor(string res, string[] args) { }

	// RVA: 0x11F45B0
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0x11F426C
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0x11F4A58
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

	// RVA: 0x11F4A70
	internal void .ctor() { }

	// RVA: -1
	public abstract void SetContext(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11F4A78
	public static XPathExpression Compile(string xpath) { }

	// RVA: 0x11F4A80
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

	// RVA: 0x11F4B70
	public virtual object ValueAs(Type returnType) { }

	// RVA: -1
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11F4B84
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

	// RVA: 0x11F4B8C
	public override string ToString() { }

	// RVA: 0x11F4B98
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x11F4D58
	public override object get_TypedValue() { }

	// RVA: 0x11F5060
	public override Type get_ValueType() { }

	// RVA: 0x11F5280
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x11F5570
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x11F5868
	public override Double get_ValueAsDouble() { }

	// RVA: 0x11F5B60
	public override int get_ValueAsInt() { }

	// RVA: 0x11F5E58
	public override Int64 get_ValueAsLong() { }

	// RVA: 0x11F6150
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11F6458
	private object System.ICloneable.Clone() { }

	// RVA: 0x11F6468
	public virtual XPathNavigator CreateNavigator() { }

	// RVA: -1
	public abstract XmlNameTable get_NameTable() { }

	// RVA: 0x11F6478
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x11F6654
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0x11F688C
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

	// RVA: 0x11F6BC0
	public virtual string get_XmlLang() { }

	// RVA: 0x11F6CA4
	public virtual object get_UnderlyingObject() { }

	// RVA: 0x11F6CAC
	public virtual bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: -1
	public abstract bool MoveToFirstAttribute() { }

	// RVA: -1
	public abstract bool MoveToNextAttribute() { }

	// RVA: 0x11F6D90
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: -1
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x11F6E3C
	public bool MoveToFirstNamespace() { }

	// RVA: 0x11F6E50
	public bool MoveToNextNamespace() { }

	// RVA: -1
	public abstract bool MoveToNext() { }

	// RVA: -1
	public abstract bool MoveToFirstChild() { }

	// RVA: -1
	public abstract bool MoveToParent() { }

	// RVA: 0x11F6E64
	public virtual void MoveToRoot() { }

	// RVA: -1
	public abstract bool MoveTo(XPathNavigator other) { }

	// RVA: -1
	public abstract bool MoveToId(string id) { }

	// RVA: 0x11F6E98
	public virtual bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x11F6F98
	public virtual bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x11F7190
	public virtual bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x11F747C
	public virtual bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x11F7724
	public virtual bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x11F7830
	public virtual bool MoveToNext(XPathNodeType type) { }

	// RVA: -1
	public abstract bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x11F7998
	public virtual bool IsDescendant(XPathNavigator nav) { }

	// RVA: 0x11F7A38
	public virtual XmlNodeOrder ComparePosition(XPathNavigator nav) { }

	// RVA: 0x11F7F3C
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x11F7F90
	public virtual XPathNodeIterator Select(string xpath) { }

	// RVA: 0x11F7FCC
	public virtual XPathNodeIterator Select(XPathExpression expr) { }

	// RVA: 0x11F8090
	public virtual object Evaluate(XPathExpression expr) { }

	// RVA: 0x11F80A4
	public virtual object Evaluate(XPathExpression expr, XPathNodeIterator context) { }

	// RVA: 0x11F828C
	public virtual XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x11F8314
	public virtual XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x11F83AC
	public virtual XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x11F8444
	public virtual XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x11F7368
	internal bool MoveToNonDescendant() { }

	// RVA: 0x11F7D78
	private static int GetDepth(XPathNavigator nav) { }

	// RVA: 0x11F7DC0
	private XmlNodeOrder CompareSiblings(XPathNavigator n1, XPathNavigator n2) { }

	// RVA: 0x11F70F0
	internal static int GetContentKindMask(XPathNodeType type) { }

	// RVA: 0x11F84E4
	internal static int GetKindMask(XPathNodeType type) { }

	// RVA: 0x11F8508
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x11F8518
	protected void .ctor() { }

	// RVA: 0x11F8520
	private static void .cctor() { }

}

// Namespace: System.Xml.XPath
internal class XPathNavigatorKeyComparer
{
	// Methods

	// RVA: 0x11F86B4
	private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0x11F87A0
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x11F86AC
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

	// RVA: 0x11F8A8C
	public void .ctor(XPathNodeIterator original) { }

	// RVA: 0x11F8AE8
	public virtual object get_Current() { }

	// RVA: 0x11F8C24
	public virtual bool MoveNext() { }

	// RVA: 0x11F8CC4
	public virtual void Reset() { }

}

// Namespace: System.Xml.XPath
public abstract class XPathNodeIterator
{
	// Fields
	internal int count; // 0x10

	// Methods

	// RVA: 0x11F897C
	private object System.ICloneable.Clone() { }

	// RVA: -1
	public abstract XPathNodeIterator Clone() { }

	// RVA: -1
	public abstract bool MoveNext() { }

	// RVA: -1
	public abstract XPathNavigator get_Current() { }

	// RVA: -1
	public abstract int get_CurrentPosition() { }

	// RVA: 0x11F8988
	public virtual int get_Count() { }

	// RVA: 0x11F8A00
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x11F8AD8
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

	// RVA: 0x11F8CCC
	public static string MakePascal(string identifier) { }

	// RVA: 0x11F8ED4
	public static string MakeValid(string identifier) { }

	// RVA: 0x11F914C
	private static bool IsValidStart(Char c) { }

	// RVA: 0x11F90F4
	private static bool IsValid(Char c) { }

	// RVA: 0x11F9194
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlSerializerNamespaces
{
	// Fields
	private Hashtable namespaces; // 0x10

	// Methods

	// RVA: 0x11F921C
	public void .ctor() { }

	// RVA: 0x11F9224
	public void Add(string prefix, string ns) { }

	// RVA: 0x11F939C
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0x11F94C4
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0x11F9AA4
	public int get_Count() { }

	// RVA: 0x11F95C0
	internal ArrayList get_NamespaceList() { }

	// RVA: 0x11F943C
	internal Hashtable get_Namespaces() { }

	// RVA: 0x11F9B2C
	internal void set_Namespaces(Hashtable value) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlAttributeEventHandler
{
	// Methods

	// RVA: 0x11F9B34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11F9C58
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

	// RVA: 0x11F9C6C
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlElementEventHandler
{
	// Methods

	// RVA: 0x11F9D2C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11F9E50
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

	// RVA: 0x11F9E64
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlNodeEventHandler
{
	// Methods

	// RVA: 0x11F9F24
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11FA048
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

	// RVA: 0x11FA05C
	internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

// Namespace: System.Xml.Serialization
public sealed class UnreferencedObjectEventHandler
{
	// Methods

	// RVA: 0x11FA108
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11FA22C
	public virtual void Invoke(object sender, UnreferencedObjectEventArgs e) { }

}

// Namespace: System.Xml.Serialization
public class UnreferencedObjectEventArgs
{
	// Fields
	private object o; // 0x10
	private string id; // 0x18

	// Methods

	// RVA: 0x11FA240
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

	// RVA: 0x11FA2D4
	public static void AddField(StringBuilder sb, int n, string val) { }

	// RVA: 0x11FA2DC
	public static void AddField(StringBuilder sb, int n, string val, string def) { }

	// RVA: 0x11FA3C8
	public static void AddField(StringBuilder sb, int n, bool val) { }

	// RVA: 0x11FA418
	public static void AddField(StringBuilder sb, int n, bool val, bool def) { }

	// RVA: 0x11FA46C
	public static void AddField(StringBuilder sb, int n, int val, int def) { }

	// RVA: 0x11FA530
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

	// RVA: 0x11FA658
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x11FA724
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x11FA810
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x11FA94C
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x11FAA9C
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x11FAE60
	public void .ctor() { }

	// RVA: 0x11FAEFC
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

	// RVA: 0x11FAF7C
	public void .ctor(string namspace, Type[] includedTypes) { }

	// RVA: 0x11FAFD4
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

	// RVA: 0x11FB0C8
	public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0x11FB214
	public override bool Equals(object o) { }

	// RVA: 0x11FB2FC
	public override int GetHashCode() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeConvertorAttribute
{
	// Fields
	private string <Method>k__BackingField; // 0x10

	// Methods

	// RVA: 0x11FB320
	public string get_Method() { }

	// RVA: 0x11FB328
	private void set_Method(string value) { }

	// RVA: 0x11FB330
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

	// RVA: 0x11FB364
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x11FB370
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x11FB9BC
	private void LookupTypeConvertor() { }

	// RVA: 0x11FBA80
	internal void ConvertForAssignment(object value) { }

	// RVA: 0x11FBB78
	public string get_TypeName() { }

	// RVA: 0x11FBB80
	public string get_XmlType() { }

	// RVA: 0x11FBB88
	public Type get_Type() { }

	// RVA: 0x11FBB90
	public string get_FullTypeName() { }

	// RVA: 0x11FBB98
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x11FAE50
	public bool get_IsListType() { }

	// RVA: 0x11FBBA0
	public bool get_IsComplexType() { }

	// RVA: 0x11FBBD8
	public bool get_IsValueType() { }

	// RVA: 0x11FBC64
	public bool get_IsNullable() { }

	// RVA: 0x11FBDC8
	public void set_IsNullable(bool value) { }

	// RVA: 0x11FB77C
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x11FBDD0
	public Type get_ListItemType() { }

	// RVA: 0x11FBBC8
	public bool get_IsXsdType() { }

	// RVA: 0x11FC9E8
	public bool get_HasPublicConstructor() { }

	// RVA: 0x11FC7B0
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x11FC8B8
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x11FC590
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x11FC9F0
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
internal sealed class TypeMember
{
	// Fields
	private Type type; // 0x10
	private string member; // 0x18

	// Methods

	// RVA: 0x11FD9E4
	internal void .ctor(Type type, string member) { }

	// RVA: 0x11FDA34
	public override int GetHashCode() { }

	// RVA: 0x11FDA84
	public override bool Equals(object obj) { }

	// RVA: 0x11FDB54
	public static bool Equals(TypeMember tm1, TypeMember tm2) { }

	// RVA: 0x11FDC10
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

	// RVA: 0x11FDC78
	private static void .cctor() { }

	// RVA: 0x11FADE8
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x11FFF7C
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType) { }

	// RVA: 0x1200B40
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x1200BC8
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x1200DFC
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x11FB8BC
	public static string GetArrayName(string elemName) { }

	// RVA: 0x1200EE0
	public static void ParseArrayType(string arrayType, string type, string ns, string dimensions) { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyAttributeAttribute
{
	// Methods

	// RVA: 0x120107C
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

	// RVA: 0x1201084
	public void .ctor() { }

	// RVA: 0x1201094
	public string get_Name() { }

	// RVA: 0x12010B8
	public string get_Namespace() { }

	// RVA: 0x12010C0
	public int get_Order() { }

	// RVA: 0x12010C8
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlAnyElementAttributes
{
	// Methods

	// RVA: 0x1201164
	public XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x1201284
	public int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x1201348
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1201424
	internal int get_Order() { }

	// RVA: 0x12016F0
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

	// RVA: 0x12016F8
	public string get_ElementName() { }

	// RVA: 0x120171C
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1201724
	public bool get_IsNullable() { }

	// RVA: 0x120172C
	public string get_Namespace() { }

	// RVA: 0x1201734
	public int get_Order() { }

	// RVA: 0x120173C
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

	// RVA: 0x1201868
	public string get_DataType() { }

	// RVA: 0x120188C
	public string get_ElementName() { }

	// RVA: 0x12018B0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x12018B8
	public string get_Namespace() { }

	// RVA: 0x12018C0
	public bool get_IsNullable() { }

	// RVA: 0x12018C8
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x12018D0
	public Type get_Type() { }

	// RVA: 0x12018D8
	public int get_NestingLevel() { }

	// RVA: 0x12018E0
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlArrayItemAttributes
{
	// Methods

	// RVA: 0x1201A50
	public XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x1201B70
	public int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x1201C34
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1201D10
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

	// RVA: 0x1201D18
	public void .ctor(string attributeName) { }

	// RVA: 0x1201D4C
	public string get_AttributeName() { }

	// RVA: 0x1201D70
	public string get_DataType() { }

	// RVA: 0x1201D94
	public void set_DataType(string value) { }

	// RVA: 0x1201D9C
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1201DA4
	public string get_Namespace() { }

	// RVA: 0x1201DAC
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlAttributeOverrides
{
	// Fields
	private Hashtable overrides; // 0x10

	// Methods

	// RVA: 0x1201EEC
	public void .ctor() { }

	// RVA: 0x1201F64
	public XmlAttributes get_Item(Type type) { }

	// RVA: 0x1201F7C
	public XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x1202074
	private TypeMember GetKey(Type type, string member) { }

	// RVA: 0x12020E4
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

	// RVA: 0x12028E8
	public void .ctor() { }

	// RVA: 0x1202A1C
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x1203470
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x1203478
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x1203480
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x1203488
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x1203490
	public XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x1203498
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x12034A0
	public object get_XmlDefaultValue() { }

	// RVA: 0x12034A8
	public XmlElementAttributes get_XmlElements() { }

	// RVA: 0x12034B0
	public bool get_XmlIgnore() { }

	// RVA: 0x12034B8
	public bool get_Xmlns() { }

	// RVA: 0x12034C0
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x12034C8
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x12034D0
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x12025D4
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x120441C
	internal System.Nullable<System.Int32> get_Order() { }

	// RVA: 0x12047B8
	internal int get_SortableOrder() { }

}

// Namespace: System.Xml.Serialization
public class XmlChoiceIdentifierAttribute
{
	// Fields
	private string memberName; // 0x10

	// Methods

	// RVA: 0x1204894
	public string get_MemberName() { }

	// RVA: 0x1204394
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
internal class XmlCustomFormatter
{
	// Fields
	private static string[] allTimeFormats; // 0x0

	// Methods

	// RVA: 0x12048B8
	internal static string FromEnum(Int64 value, string[] values, Int64[] ids, string typeName) { }

	// RVA: 0x1204C28
	internal static string FromXmlName(string name) { }

	// RVA: 0x1204CB0
	internal static string FromXmlNCName(string ncName) { }

	// RVA: 0x12035B4
	internal static string ToXmlString(TypeData type, object value) { }

	// RVA: 0x1204D38
	internal static object FromXmlString(TypeData type, string value) { }

	// RVA: 0x1205870
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

	// RVA: 0x1205DD0
	public void .ctor(string elementName) { }

	// RVA: 0x1205E0C
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x1205E64
	public string get_DataType() { }

	// RVA: 0x1205E88
	public string get_ElementName() { }

	// RVA: 0x1205EAC
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1205EB4
	public string get_Namespace() { }

	// RVA: 0x1205EBC
	public bool get_IsNullable() { }

	// RVA: 0x1205EC4
	public int get_Order() { }

	// RVA: 0x1205ECC
	public Type get_Type() { }

	// RVA: 0x1205ED4
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlElementAttributes
{
	// Methods

	// RVA: 0x1206028
	public XmlElementAttribute get_Item(int index) { }

	// RVA: 0x12033AC
	public int Add(XmlElementAttribute attribute) { }

	// RVA: 0x12034D8
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x12044EC
	internal int get_Order() { }

	// RVA: 0x1202A14
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlEnumAttribute
{
	// Fields
	private string name; // 0x10

	// Methods

	// RVA: 0x1206148
	public void .ctor(string name) { }

	// RVA: 0x120617C
	public string get_Name() { }

	// RVA: 0x1204248
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public class XmlIgnoreAttribute
{
	// Methods

	// RVA: 0x1206184
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
public class XmlIncludeAttribute
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0x120618C
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

	// RVA: 0x1206194
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x12061E4
	public string get_ElementName() { }

	// RVA: 0x12061EC
	public string get_Namespace() { }

	// RVA: 0x12061F4
	public void SetKey(string key) { }

	// RVA: 0x12061FC
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x1206204
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x120620C
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x1206214
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x120621C
	internal SerializationFormat get_Format() { }

	// RVA: 0x1206224
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x120622C
	internal SerializationSource get_Source() { }

}

// Namespace: System.Xml.Serialization
internal class ObjectMap
{
	// Methods

	// RVA: 0x1206234
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

	// RVA: 0x120623C
	public int get_Count() { }

	// RVA: 0x120625C
	internal bool get_HasWrapperElement() { }

}

// Namespace: System.Xml.Serialization
public class XmlNamespaceDeclarationsAttribute
{
	// Methods

	// RVA: 0x1206264
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

	// RVA: 0x120DB54
	private static void .cctor() { }

	// RVA: 0x120DBC0
	public void .ctor() { }

	// RVA: 0x120DBC8
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

	// RVA: 0x120626C
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x12063FC
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x12065F4
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x1206408
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1206600
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1209694
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x1209B78
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType) { }

	// RVA: 0x1206A70
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType) { }

	// RVA: 0x120B7CC
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x1209C14
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x120BA2C
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x1207EC4
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x1208D28
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1208EE4
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1208FB4
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1209564
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x120B8DC
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x1209D54
	private System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x120AD28
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x120C164
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x120BB34
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x120D280
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x1209B04
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x120D5C4
	public void IncludeType(Type type) { }

	// RVA: 0x120D0A0
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x120DAB4
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

	// RVA: 0x120BAD0
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x120DCB8
	public bool get_IsReturnValue() { }

	// RVA: 0x120DCC0
	public string get_MemberName() { }

	// RVA: 0x120DCC8
	public Type get_MemberType() { }

	// RVA: 0x120ACA4
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x120DCD0
	internal Type get_DeclaringType() { }

	// RVA: 0x120DCD8
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

	// RVA: 0x120DCE0
	public void .ctor() { }

	// RVA: 0x120DCF0
	public void .ctor(string elementName) { }

	// RVA: 0x120DD2C
	public string get_DataType() { }

	// RVA: 0x120DD50
	public void set_DataType(string value) { }

	// RVA: 0x1209B54
	public string get_ElementName() { }

	// RVA: 0x120DD58
	public void set_ElementName(string value) { }

	// RVA: 0x120DD60
	public bool get_IsNullable() { }

	// RVA: 0x120DD68
	public void set_IsNullable(bool value) { }

	// RVA: 0x120DD70
	public string get_Namespace() { }

	// RVA: 0x120DD78
	public void set_Namespace(string value) { }

	// RVA: 0x12042D0
	internal void AddKeyHash(StringBuilder sb) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSchemaProviderAttribute
{
	// Fields
	private string _methodName; // 0x10
	private bool _isAny; // 0x18

	// Methods

	// RVA: 0x120DD80
	public void .ctor(string methodName) { }

	// RVA: 0x120DDB4
	public string get_MethodName() { }

	// RVA: 0x120DDBC
	public bool get_IsAny() { }

	// RVA: 0x120DDC4
	public void set_IsAny(bool value) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationCollectionFixupCallback
{
	// Methods

	// RVA: 0x120DDCC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x120DEF0
	public virtual void Invoke(object collection, object collectionItems) { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationFixupCallback
{
	// Methods

	// RVA: 0x120DF04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x120E024
	public virtual void Invoke(object fixup) { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationGeneratedCode
{
	// Methods

	// RVA: 0x120E038
	protected void .ctor() { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationReadCallback
{
	// Methods

	// RVA: 0x120E040
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x120E0E0
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

	// RVA: 0x120EA84
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

	// RVA: 0x1212F14
	internal void .ctor(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

	// RVA: 0x1212F78
	public XmlSerializationCollectionFixupCallback get_Callback() { }

	// RVA: 0x1212F80
	public object get_Collection() { }

	// RVA: 0x1212F88
	internal object get_Id() { }

	// RVA: 0x1212F90
	public object get_CollectionItems() { }

	// RVA: 0x1212F98
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

	// RVA: 0x1212FA0
	public void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	// RVA: 0x1213044
	public XmlSerializationFixupCallback get_Callback() { }

	// RVA: 0x121304C
	public string[] get_Ids() { }

	// RVA: 0x1213054
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

	// RVA: 0x121112C
	public void .ctor(Array list, int index, string id) { }

	// RVA: 0x121305C
	public Array get_Collection() { }

	// RVA: 0x1213064
	public int get_Index() { }

	// RVA: 0x121306C
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

	// RVA: 0x120E0F4
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x120E4C0
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x120E534
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x120E5A8
	protected void .ctor() { }

	// RVA: 0x120E5B0
	protected XmlDocument get_Document() { }

	// RVA: 0x120E664
	protected XmlReader get_Reader() { }

	// RVA: 0x120E66C
	protected void AddFixup(CollectionFixup fixup) { }

	// RVA: 0x120E7B0
	protected void AddFixup(Fixup fixup) { }

	// RVA: 0x120E864
	private void AddFixup(CollectionItemFixup fixup) { }

	// RVA: 0x120E918
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x120EA8C
	protected void AddTarget(string id, object o) { }

	// RVA: 0x120EC2C
	private string CurrentTag() { }

	// RVA: 0x120EDB8
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x120EE48
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x120EEE8
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x120EF7C
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x120F124
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x120F1C0
	protected bool GetNullAttr() { }

	// RVA: 0x120F288
	protected object GetTarget(string id) { }

	// RVA: 0x120F368
	private bool TargetReady(string id) { }

	// RVA: 0x120F384
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1
	protected abstract void InitCallbacks() { }

	// RVA: -1
	protected abstract void InitIDs() { }

	// RVA: 0x120F578
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x120F61C
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x120F79C
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x120FAAC
	protected void ReadEndElement() { }

	// RVA: 0x120FB74
	protected bool ReadNull() { }

	// RVA: 0x120FC90
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x120FCC8
	protected string ReadNullableString() { }

	// RVA: 0x120FD20
	protected object ReadReferencedElement() { }

	// RVA: 0x121007C
	private WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x120FD78
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x1210174
	private bool ReadList(object resultList) { }

	// RVA: 0x1211184
	protected void ReadReferencedElements() { }

	// RVA: 0x12120B8
	protected object ReadReferencingElement(string fixupReference) { }

	// RVA: 0x1211120
	protected object ReadReferencingElement(string name, string ns, string fixupReference) { }

	// RVA: 0x1212124
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, string fixupReference) { }

	// RVA: 0x12124EC
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x12126B4
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x12106F0
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x1212940
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x1212A3C
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x1212B58
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x120F87C
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x1212C08
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x1212D6C
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x120FC58
	protected void UnknownNode(object o) { }

	// RVA: 0x1212ED0
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x12126BC
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x1212020
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

	// RVA: 0x12180C0
	public void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

	// RVA: 0x12192CC
	public void FixupMembers(object fixup) { }

}

// Namespace: 
private class ReaderCallbackInfo
{
	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x12134D4
	public void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

	// RVA: 0x12192F8
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

	// RVA: 0x1213074
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x12130BC
	protected override void InitCallbacks() { }

	// RVA: 0x1213524
	protected override void InitIDs() { }

	// RVA: 0x1213528
	public object ReadRoot() { }

	// RVA: 0x1213710
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x1213860
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x1213634
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x1216A08
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x12172DC
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x12175FC
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x1213EB8
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x12143E8
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x1217DC8
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x121846C
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x1218854
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x121888C
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x1217FA8
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x12177E8
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x1213E0C
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x121798C
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x12181D4
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x12188C4
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x12176A8
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x1216B74
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x12189FC
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x1217A60
	private void AddListValue(TypeData listType, object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x12175F4
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x1213D9C
	private object CreateInstance(Type type) { }

	// RVA: 0x121811C
	private object CreateList(Type listType) { }

	// RVA: 0x1218018
	private object InitializeList(TypeData listType) { }

	// RVA: 0x1218D7C
	private void FillList(object list, object items) { }

	// RVA: 0x1218D8C
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x12169E8
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x12183B0
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x1216FB0
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x12170A0
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1218C34
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x1217110
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x12191D8
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationWriteCallback
{
	// Methods

	// RVA: 0x121932C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x121944C
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

	// RVA: 0x121D09C
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

	// RVA: 0x1219460
	protected void .ctor() { }

	// RVA: 0x12194DC
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x1219614
	protected XmlWriter get_Writer() { }

	// RVA: 0x121961C
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x1219740
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x12197E0
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x1219884
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x1219914
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x1219B4C
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x1219C68
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x1219CA8
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x1219A88
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1
	protected abstract void InitCallbacks() { }

	// RVA: 0x1219E14
	protected void TopLevelElement() { }

	// RVA: 0x1219E20
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x1219DE8
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x1219E5C
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x1219F08
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x121A1D4
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x121A4A4
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x121A4AC
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x121A7F4
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x121A7FC
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x121A7D0
	protected void WriteEndElement() { }

	// RVA: 0x121A9D4
	protected void WriteEndElement(object o) { }

	// RVA: 0x121AA20
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x121AE48
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x121AF30
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x121B008
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x121B014
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x121A110
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x121A3DC
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x121B024
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x121B6E8
	protected void WriteReferencedElements() { }

	// RVA: 0x121B624
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x121B908
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x121BC7C
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x121B58C
	private void CheckReferenceQueue() { }

	// RVA: 0x121BE5C
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x121BE64
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x121C044
	protected void WriteStartDocument() { }

	// RVA: 0x121A660
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x121B57C
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x121C0A4
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x121C09C
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x121C0B0
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x121C9E0
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x121CD2C
	protected void WriteValue(string value) { }

	// RVA: 0x121CD60
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x121A670
	protected void WriteXsiType(string name, string ns) { }

}

// Namespace: 
private class CallbackInfo
{
	// Fields
	private XmlSerializationWriterInterpreter _swi; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x121D4F8
	public void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

	// RVA: 0x1223D14
	internal void WriteObject(object ob) { }

	// RVA: 0x1223D64
	internal void WriteEnum(object ob) { }

}

// Namespace: System.Xml.Serialization
internal class XmlSerializationWriterInterpreter
{
	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x121D0A4
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x121D0EC
	protected override void InitCallbacks() { }

	// RVA: 0x121D548
	public void WriteRoot(object ob) { }

	// RVA: 0x121D758
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x121E2C0
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x121E504
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x121E750
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x121EF2C
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x121E4C0
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x121E7F8
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x121EFD4
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x121FB40
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x121F8D8
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x1220324
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x121DE44
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x12220C4
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x1222424
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x12226E0
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x12208EC
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x12228CC
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x12211BC
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x1223844
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x122388C
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1220044
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x12238C8
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

	// RVA: 0x1224E10
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

	// RVA: 0x1223DB4
	private static void .cctor() { }

	// RVA: 0x1223E74
	public void .ctor(Type type) { }

	// RVA: 0x1223E88
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1223FFC
	internal XmlMapping get_Mapping() { }

	// RVA: 0x1224004
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0x1224028
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0x122404C
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0x1224070
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0x1224094
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0x12240D4
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0x1224114
	public object Deserialize(TextReader textReader) { }

	// RVA: 0x12241AC
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0x12242D4
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0x12245CC
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0x12247EC
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0x1224BC0
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0x1224888
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0x1224BC8
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0x122426C
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

}

// Namespace: System.Xml.Serialization
public class XmlSerializerFactory
{
	// Fields
	private static Hashtable serializersBySource; // 0x0

	// Methods

	// RVA: 0x1224F0C
	public void .ctor() { }

	// RVA: 0x1224F14
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0x12251C0
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0x1224F28
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x12251D4
	private static void .cctor() { }

}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializerImplementation
{
	// Methods

	// RVA: 0x122525C
	public virtual XmlSerializationWriter get_Writer() { }

}

// Namespace: System.Xml.Serialization
public class XmlTextAttribute
{
	// Fields
	private string dataType; // 0x10
	private Type type; // 0x18

	// Methods

	// RVA: 0x122529C
	public void .ctor() { }

	// RVA: 0x12252A4
	public string get_DataType() { }

	// RVA: 0x12252C8
	public Type get_Type() { }

	// RVA: 0x12252D0
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

	// RVA: 0x122536C
	public bool get_IncludeInSchema() { }

	// RVA: 0x1225374
	public string get_Namespace() { }

	// RVA: 0x122537C
	public string get_TypeName() { }

	// RVA: 0x12253A0
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

	// RVA: 0x1225450
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x1225528
	public TypeData get_TypeData() { }

	// RVA: 0x1225530
	public object get_ChoiceValue() { }

	// RVA: 0x1225538
	public void set_ChoiceValue(object value) { }

	// RVA: 0x1225540
	public string get_ElementName() { }

	// RVA: 0x1225548
	public void set_ElementName(string value) { }

	// RVA: 0x1225550
	public string get_Namespace() { }

	// RVA: 0x1225558
	public void set_Namespace(string value) { }

	// RVA: 0x12223A0
	public string get_DataTypeNamespace() { }

	// RVA: 0x122236C
	public string get_DataTypeName() { }

	// RVA: 0x1225560
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1225568
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x1225570
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x1225578
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x1225580
	public bool get_IsNullable() { }

	// RVA: 0x1225588
	public void set_IsNullable(bool value) { }

	// RVA: 0x1225590
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x1225598
	public void set_NestingLevel(int value) { }

	// RVA: 0x12255A0
	public bool get_MultiReferenceType() { }

	// RVA: 0x12255C0
	public bool get_WrappedElement() { }

	// RVA: 0x12255C8
	public void set_WrappedElement(bool value) { }

	// RVA: 0x12255D0
	public bool get_IsTextElement() { }

	// RVA: 0x1225628
	public void set_IsTextElement(bool value) { }

	// RVA: 0x12256F0
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0x1225710
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x12257A8
	public int get_ExplicitOrder() { }

	// RVA: 0x12257B0
	public void set_ExplicitOrder(int value) { }

	// RVA: 0x12257B8
	public override bool Equals(object other) { }

	// RVA: 0x122591C
	public override int GetHashCode() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfoList
{
	// Methods

	// RVA: 0x1225924
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

	// RVA: 0x122592C
	public void .ctor() { }

	// RVA: 0x12259B0
	public string get_Name() { }

	// RVA: 0x12259B8
	public void set_Name(string value) { }

	// RVA: 0x12259C0
	public object get_DefaultValue() { }

	// RVA: 0x12259C8
	public void set_DefaultValue(object value) { }

	// RVA: 0x12259D0
	public bool IsReadOnly(Type type) { }

	// RVA: 0x1225D38
	public static object GetValue(object ob, string name) { }

	// RVA: 0x121E630
	public object GetValue(object ob) { }

	// RVA: 0x1225E64
	public void SetValue(object ob, object value) { }

	// RVA: 0x1225FB4
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0x1225AD8
	private void InitMember(Type type) { }

	// RVA: 0x12260E8
	public TypeData get_TypeData() { }

	// RVA: 0x12260F0
	public void set_TypeData(TypeData value) { }

	// RVA: 0x12260F8
	public int get_Index() { }

	// RVA: 0x1226100
	public void set_Index(int value) { }

	// RVA: 0x1226108
	public int get_GlobalIndex() { }

	// RVA: 0x1226110
	public void set_GlobalIndex(int value) { }

	// RVA: 0x1221E78
	public bool get_IsOptionalValueType() { }

	// RVA: 0x1226118
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0x122612C
	public bool get_IsReturnValue() { }

	// RVA: 0x1226138
	public void set_IsReturnValue(bool value) { }

	// RVA: 0x1226158
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0x1221E84
	public bool GetValueSpecified(object ob) { }

	// RVA: 0x12261D4
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

	// RVA: 0x1226480
	public void .ctor() { }

	// RVA: 0x122653C
	public string get_AttributeName() { }

	// RVA: 0x1226544
	public void set_AttributeName(string value) { }

	// RVA: 0x122654C
	public string get_Namespace() { }

	// RVA: 0x1226554
	public void set_Namespace(string value) { }

	// RVA: 0x122655C
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x1226564
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x122656C
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

	// RVA: 0x1226574
	public void .ctor() { }

	// RVA: 0x122029C
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x12265F8
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x1226600
	public string get_ChoiceMember() { }

	// RVA: 0x1226608
	public void set_ChoiceMember(string value) { }

	// RVA: 0x1226610
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x1226618
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0x12217B8
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0x1226620
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x1226630
	public bool get_IsXmlTextCollector() { }

	// RVA: 0x1226638
	public void set_IsXmlTextCollector(bool value) { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberList
{
	// Methods

	// RVA: 0x1226640
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberExpandable
{
	// Fields
	private int _flatArrayIndex; // 0x78

	// Methods

	// RVA: 0x12266C4
	public int get_FlatArrayIndex() { }

	// RVA: 0x12266CC
	public void set_FlatArrayIndex(int value) { }

	// RVA: 0x12266D4
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberFlatList
{
	// Fields
	private ListMap _listMap; // 0x80

	// Methods

	// RVA: 0x1226758
	public ListMap get_ListMap() { }

	// RVA: 0x1226760
	public void set_ListMap(ListMap value) { }

	// RVA: 0x1226768
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyElement
{
	// Methods

	// RVA: 0x1223494
	public bool IsElementDefined(string name, string ns) { }

	// RVA: 0x12267EC
	public bool get_IsDefaultAny() { }

	// RVA: 0x1226B58
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyAttribute
{
	// Methods

	// RVA: 0x1226BDC
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberNamespaces
{
	// Methods

	// RVA: 0x1226C60
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

	// RVA: 0x1226CE4
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0x1223980
	public string get_TypeFullName() { }

	// RVA: 0x1226DC0
	internal TypeData get_TypeData() { }

	// RVA: 0x1226DC8
	internal string get_XmlType() { }

	// RVA: 0x1226DD0
	internal void set_XmlType(string value) { }

	// RVA: 0x121E29C
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x1226DD8
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0x1226DE0
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x1226DF0
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x1226DF8
	internal bool get_MultiReferenceType() { }

	// RVA: 0x1226E00
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x1226E08
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0x1226E10
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0x1226E18
	internal bool get_IsNullable() { }

	// RVA: 0x1226E20
	internal void set_IsNullable(bool value) { }

	// RVA: 0x1226E28
	internal bool get_IsAny() { }

	// RVA: 0x1226E30
	internal void set_IsAny(bool value) { }

	// RVA: 0x121E118
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0x1226E38
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0x12271B0
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

	// RVA: 0x1227278
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

	// RVA: 0x1227B34
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x1228948
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x1228A00
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x1228B34
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x1228EF0
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x1228860
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x1229278
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x1229674
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x122967C
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x1229684
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x121FC10
	public ICollection get_AttributeMembers() { }

	// RVA: 0x122968C
	public ICollection get_ElementMembers() { }

	// RVA: 0x1229694
	public ArrayList get_AllMembers() { }

	// RVA: 0x122969C
	public ArrayList get_FlatLists() { }

	// RVA: 0x12296A4
	public ArrayList get_ListMembers() { }

	// RVA: 0x12296AC
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x12296B4
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x12296BC
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x122997C
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x1229984
	public bool get_HasSimpleContent() { }

	// RVA: 0x12299F8
	public void .ctor() { }

}

// Namespace: System.Xml.Serialization
internal class ListMap
{
	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Methods

	// RVA: 0x1229AB0
	public void set_ChoiceMember(string value) { }

	// RVA: 0x1229AB8
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x1229AC0
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x1222C74
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x1229AC8
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x1229DD4
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x12229EC
	public void GetArrayType(int itemCount, string localName, string ns) { }

	// RVA: 0x122A0F4
	public override bool Equals(object other) { }

	// RVA: 0x122A258
	public override int GetHashCode() { }

	// RVA: 0x122A260
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

	// RVA: 0x122A7C4
	public void .ctor(string xmlName, string enumName, Int64 value) { }

	// RVA: 0x122A820
	public string get_XmlName() { }

	// RVA: 0x122A828
	public string get_EnumName() { }

	// RVA: 0x122A830
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

	// RVA: 0x122A268
	public void .ctor(EnumMapMember[] members, bool isFlags) { }

	// RVA: 0x122A418
	public bool get_IsFlags() { }

	// RVA: 0x122A420
	public string[] get_EnumNames() { }

	// RVA: 0x122A428
	public string[] get_XmlNames() { }

	// RVA: 0x122A430
	public Int64[] get_Values() { }

	// RVA: 0x12239A0
	public string GetXmlName(string typeName, object enumValue) { }

	// RVA: 0x122A438
	public string GetEnumName(string typeName, string xmlName) { }

}

// Namespace: System.Xml.XmlConfiguration
public sealed class XmlReaderSection
{
	// Methods

	// RVA: 0x122A838
	internal static bool get_ProhibitDefaultUrlResolver() { }

	// RVA: 0x122A840
	internal static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x122A898
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

	// RVA: 0x122A8A0
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

	// RVA: 0x122A8A8
	public void Clear() { }

	// RVA: 0x122A8B8
	internal int get_Count() { }

	// RVA: 0x122A8C0
	public string GetResult() { }

	// RVA: 0x122A9B4
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

	// RVA: 0x122AB4C
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0x122AB54
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0x122ABA0
	internal void SetDepth(int depth) { }

	// RVA: 0x122ABA8
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0x122ACEC
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

	// RVA: 0x122AFC4
	internal ForwardAxis get_Subtree() { }

	// RVA: 0x122AFCC
	internal int get_Length() { }

	// RVA: 0x122AFF4
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0x122B0CC
	internal void Push(int depth) { }

	// RVA: 0x122B170
	internal void Pop() { }

	// RVA: 0x122AF20
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0x122B1BC
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0x122B370
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0x122B4F4
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

	// RVA: 0x122B6DC
	public int get_CurrentDepth() { }

	// RVA: 0x122B6E4
	internal void Reactivate() { }

	// RVA: 0x122B6F8
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0x122B8BC
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0x122BA04
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0x122BB20
	public bool MoveToAttribute(string localname, string URN) { }

}

// Namespace: System.Xml.Schema
internal class DoubleLinkAxis
{
	// Fields
	internal Axis next; // 0x40

	// Methods

	// RVA: 0x122BC2C
	internal Axis get_Next() { }

	// RVA: 0x122BC34
	internal void set_Next(Axis value) { }

	// RVA: 0x122BC3C
	internal void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x122BCD0
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

	// RVA: 0x122BDF0
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x122BDF8
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0x122BE00
	internal bool get_IsAttribute() { }

	// RVA: 0x122BE08
	internal bool get_IsDss() { }

	// RVA: 0x122BE10
	internal bool get_IsSelfAxis() { }

	// RVA: 0x122BE18
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

	// RVA: 0x122BFDC
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0x122BFE4
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x122C8BC
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0x122AEE4
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0x122C8F8
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0x122BF94
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0x122C050
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x122C940
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

// Namespace: System.Xml.Schema
internal class AutoValidator
{
	// Methods

	// RVA: 0x122CA7C
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x122CC14
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x122CC1C
	public override void Validate() { }

	// RVA: 0x122D2AC
	public override void CompleteValidation() { }

	// RVA: 0x122D2B0
	public override object FindId(string name) { }

	// RVA: 0x122CD14
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

	// RVA: 0x122D37C
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x122D404
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x122D4DC
	protected XmlNameTable get_NameTable() { }

	// RVA: 0x122D4E4
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x122D588
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x122D590
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x122D598
	protected bool get_HasErrors() { }

	// RVA: 0x122D5A8
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x122DA0C
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x122DCC4
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x122DB68
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x122DF10
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0x122DE0C
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0x122E0D8
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0x122E250
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0x122E390
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x122E520
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x122E5A8
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x122E654
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x122E00C
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x122E6EC
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

	// RVA: 0x122E7A4
	public void .ctor(BaseValidator other) { }

	// RVA: 0x122CB10
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x122E860
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x122E868
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x122E870
	public XmlNameTable get_NameTable() { }

	// RVA: 0x122D2B8
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x122E878
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x122E880
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x122E888
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x122E890
	public Uri get_BaseUri() { }

	// RVA: 0x122E898
	public void set_BaseUri(Uri value) { }

	// RVA: 0x122E8A0
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x122E984
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0x122E98C
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x122EA78
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x122EA80
	public virtual void Validate() { }

	// RVA: 0x122EA84
	public virtual void CompleteValidation() { }

	// RVA: 0x122EA88
	public virtual object FindId(string name) { }

	// RVA: 0x122EA90
	public void ValidateText() { }

	// RVA: 0x122EF80
	public void ValidateWhitespace() { }

	// RVA: 0x122EF08
	private void SaveTextValue(string value) { }

	// RVA: 0x122F0B4
	protected void SendValidationEvent(string code) { }

	// RVA: 0x122EE20
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x122ED38
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0x122F0CC
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x122F1BC
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x122F2A8
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x122F0D4
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x122F394
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0x122F55C
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0x122F760
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

}

// Namespace: System.Xml.Schema
internal sealed class BitSet
{
	// Fields
	private int count; // 0x10
	private UInt32[] bits; // 0x18

	// Methods

	// RVA: 0x122F9A0
	private void .ctor() { }

	// RVA: 0x122F9A8
	public void .ctor(int count) { }

	// RVA: 0x122FA2C
	public int get_Count() { }

	// RVA: 0x122FA34
	public bool get_Item(int index) { }

	// RVA: 0x122FAE4
	public void Clear() { }

	// RVA: 0x122FB3C
	public void Set(int index) { }

	// RVA: 0x122FA8C
	public bool Get(int index) { }

	// RVA: 0x122FC58
	public int NextSet(int startFrom) { }

	// RVA: 0x122FCF8
	public void And(BitSet other) { }

	// RVA: 0x122FE28
	public void Or(BitSet other) { }

	// RVA: 0x122FED8
	public override int GetHashCode() { }

	// RVA: 0x122FF14
	public override bool Equals(object obj) { }

	// RVA: 0x123008C
	public BitSet Clone() { }

	// RVA: 0x123018C
	public bool get_IsEmpty() { }

	// RVA: 0x1230248
	public bool Intersects(BitSet other) { }

	// RVA: 0x122FA24
	private int Subscript(int bitIndex) { }

	// RVA: 0x122FBA4
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

	// RVA: 0x1230324
	public void .ctor(string ns, XmlSchema originalSchema) { }

	// RVA: 0x12303BC
	public override int GetHashCode() { }

	// RVA: 0x123044C
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

	// RVA: 0x1230558
	public ConstraintRole get_Role() { }

	// RVA: 0x1230560
	public Asttree get_Selector() { }

	// RVA: 0x1230568
	public Asttree[] get_Fields() { }

	// RVA: 0x1230570
	private void .ctor() { }

	// RVA: 0x1230604
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0x1230B80
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

	// RVA: 0x1230C60
	internal int get_TableDim() { }

	// RVA: 0x1230C68
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

	// RVA: 0x1230EA4
	internal int get_Column() { }

	// RVA: 0x1230EAC
	internal void .ctor(Asttree astfield, KeySequence ks, int column) { }

	// RVA: 0x1230EF4
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

	// RVA: 0x1230F0C
	public int get_lastDepth() { }

	// RVA: 0x1230E0C
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0x1230FC0
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0x1231014
	public int PushKS(int errline, int errcol) { }

	// RVA: 0x12314F0
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

	// RVA: 0x1231460
	public void .ctor(KeySequence ks, int dim) { }

}

// Namespace: 
private class DecimalStruct
{
	// Fields
	private bool isDecimal; // 0x10
	private Decimal[] dvalue; // 0x18

	// Methods

	// RVA: 0x123202C
	public bool get_IsDecimal() { }

	// RVA: 0x1232034
	public void set_IsDecimal(bool value) { }

	// RVA: 0x123203C
	public Decimal[] get_Dvalue() { }

	// RVA: 0x1231BB8
	public void .ctor() { }

	// RVA: 0x1231B44
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

	// RVA: 0x1231594
	public int get_Dim() { }

	// RVA: 0x123159C
	public bool get_IsList() { }

	// RVA: 0x12315A4
	public bool get_IsDecimal() { }

	// RVA: 0x12315C4
	public Decimal[] get_Dvalue() { }

	// RVA: 0x12315E4
	public object get_Value() { }

	// RVA: 0x12315EC
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0x12315F4
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x1231788
	public override string ToString() { }

	// RVA: 0x1231790
	public void SetDecimal() { }

	// RVA: 0x1231C28
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0x1231D5C
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

	// RVA: 0x12313C8
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x1232044
	public int get_PosLine() { }

	// RVA: 0x123204C
	public int get_PosCol() { }

	// RVA: 0x1232054
	public object get_Item(int index) { }

	// RVA: 0x1232088
	public void set_Item(int index, object value) { }

	// RVA: 0x1232188
	internal bool IsQualified() { }

	// RVA: 0x1232210
	public override int GetHashCode() { }

	// RVA: 0x123256C
	public override bool Equals(object other) { }

	// RVA: 0x1232668
	public override string ToString() { }

}

// Namespace: System.Xml.Schema
internal class UpaException
{
	// Fields
	private object particle1; // 0x90
	private object particle2; // 0x98

	// Methods

	// RVA: 0x12327A0
	public void .ctor(object particle1, object particle2) { }

	// RVA: 0x1232834
	public object get_Particle1() { }

	// RVA: 0x123283C
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

	// RVA: 0x1232844
	public void .ctor() { }

	// RVA: 0x12328FC
	public int get_Count() { }

	// RVA: 0x1232908
	public bool get_IsUpaEnforced() { }

	// RVA: 0x1232910
	public void set_IsUpaEnforced(bool value) { }

	// RVA: 0x1232918
	public int AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x1232A48
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	// RVA: 0x1232DDC
	private void AddWildcard(string wildcard, object particle) { }

	// RVA: 0x1232F60
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0x12336CC
	public int get_Item(XmlQualifiedName name) { }

	// RVA: 0x12337A4
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x12337D8
	public object GetParticle(int symbol) { }

	// RVA: 0x1233818
	public string NameOf(int symbol) { }

}

// Namespace: System.Xml.Schema
internal struct Position
{
	// Fields
	public int symbol; // 0x10
	public object particle; // 0x18

	// Methods

	// RVA: 0x1233EB4
	public void .ctor(int symbol, object particle) { }

}

// Namespace: System.Xml.Schema
internal class Positions
{
	// Fields
	private ArrayList positions; // 0x10

	// Methods

	// RVA: 0x1233EC4
	public int Add(int symbol, object particle) { }

	// RVA: 0x1233F78
	public Position get_Item(int pos) { }

	// RVA: 0x1234014
	public int get_Count() { }

	// RVA: 0x123403C
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

	// RVA: 0x12340B4
	public virtual bool get_IsRangeNode() { }

	// RVA: 0x12340BC
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class LeafNode
{
	// Fields
	private int pos; // 0x10

	// Methods

	// RVA: 0x12340C4
	public void .ctor(int pos) { }

	// RVA: 0x12340F0
	public int get_Pos() { }

	// RVA: 0x12340F8
	public void set_Pos(int value) { }

	// RVA: 0x1234100
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1234104
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x12341C8
	public override bool get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal class NamespaceListNode
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Methods

	// RVA: 0x12341D0
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0x1234220
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0x1234244
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x123476C
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x12347AC
	public override bool get_IsNullable() { }

}

// Namespace: System.Xml.Schema
internal abstract class InteriorNode
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Methods

	// RVA: 0x12347EC
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x12347F4
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x12347FC
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x1234804
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0x123480C
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1234A48
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1234ABC
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

	// RVA: 0x1235214
	public void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

}

// Namespace: System.Xml.Schema
internal sealed class SequenceNode
{
	// Methods

	// RVA: 0x1234AC4
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1235284
	public override bool get_IsNullable() { }

	// RVA: 0x12353D8
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x12353DC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class ChoiceNode
{
	// Methods

	// RVA: 0x12353E4
	private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1235558
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1235708
	public override bool get_IsNullable() { }

	// RVA: 0x123579C
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1234764
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class PlusNode
{
	// Methods

	// RVA: 0x12357A0
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1235908
	public override bool get_IsNullable() { }

	// RVA: 0x123592C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class QmarkNode
{
	// Methods

	// RVA: 0x1235934
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1235958
	public override bool get_IsNullable() { }

	// RVA: 0x1235960
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal sealed class StarNode
{
	// Methods

	// RVA: 0x1235968
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1235AD0
	public override bool get_IsNullable() { }

	// RVA: 0x1235AD8
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

	// RVA: 0x1235AE0
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0x1235B34
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0x1235B88
	public Decimal get_Max() { }

	// RVA: 0x1235B94
	public Decimal get_Min() { }

	// RVA: 0x1235BA0
	public BitSet get_NextIteration() { }

	// RVA: 0x1235BA8
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x1235BB0
	public override bool get_IsRangeNode() { }

	// RVA: 0x1235BB8
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

	// RVA: 0x1235BF8
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x1235C2C
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1235C70
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1235C78
	public bool get_PreserveWhitespace() { }

	// RVA: 0x1235C8C
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x1235C94
	public bool get_IsOpen() { }

	// RVA: 0x1235CB8
	public void set_IsOpen(bool value) { }

	// RVA: 0x1235CC0
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x1235CC4
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x1235CF8
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1235D00
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1235D08
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x1235D10
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x1235D8C
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x1235FC0
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

	// RVA: 0x12360D8
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x1236154
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0x12361DC
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x123621C
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x123625C
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x123629C
	public void Start() { }

	// RVA: 0x12363CC
	public void OpenGroup() { }

	// RVA: 0x12363F8
	public void CloseGroup() { }

	// RVA: 0x1236584
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x12365C0
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x12367E8
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0x12366E4
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0x1236894
	public void AddChoice() { }

	// RVA: 0x123698C
	public void AddSequence() { }

	// RVA: 0x1236A84
	public void AddStar() { }

	// RVA: 0x1236C8C
	public void AddPlus() { }

	// RVA: 0x1236CF4
	public void AddQMark() { }

	// RVA: 0x1236D5C
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0x1236AEC
	private void Closure(InteriorNode node) { }

	// RVA: 0x1236ECC
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0x1237664
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, BitSet posWithRangeTerminals) { }

	// RVA: 0x1237F84
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0x1237C88
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0x12381E0
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0x1238C34
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0x123828C
	private Int32[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

}

// Namespace: System.Xml.Schema
internal sealed class DfaContentValidator
{
	// Fields
	private Int32[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x1238B80
	internal void .ctor(Int32[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1238EF4
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1238F5C
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x12390C0
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x12390DC
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x12392DC
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

	// RVA: 0x12394E0
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x12395DC
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x12396B4
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x123986C
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x12398B8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1239AB4
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

	// RVA: 0x1239C3C
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0x1239D4C
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1239F2C
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x123A814
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x123A830
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x123AAD8
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

	// RVA: 0x123AD10
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0x123AE44
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0x123AF80
	public override bool get_IsEmptiable() { }

	// RVA: 0x123AFA0
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x123B044
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, int errorCode) { }

	// RVA: 0x123B180
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x123B1E4
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x123B5EC
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

	// RVA: 0x123BAAC
	public void .ctor(XmlSchemaSimpleType st, object value) { }

	// RVA: 0x123BAFC
	public XmlSchemaSimpleType get_XmlType() { }

	// RVA: 0x123BB04
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

	// RVA: 0x123BB0C
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

	// RVA: 0x1244A50
	internal void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0x1244AA0
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x1247528
	public static DatatypeImplementation op_Explicit(SchemaDatatypeMap sdm) { }

	// RVA: 0x1247544
	public string get_Name() { }

	// RVA: 0x124754C
	public int get_ParentIndex() { }

	// RVA: 0x1247554
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

	// RVA: 0x123BB14
	private static void .cctor() { }

	// RVA: 0x12453F4
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x1245470
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x12454EC
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x124558C
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x124562C
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x1245704
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x12457DC
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x12458C4
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x1244AFC
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x1245B18
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1245BB8
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x1245C9C
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x1245ED8
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x1246114
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x1246190
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1246308
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x1246430
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x1242318
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x12465AC
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x1246758
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x124675C
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x1246A30
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x1246A58
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x1246B48
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1246B50
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1246BCC
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0x1246C2C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1246C34
	public override Type get_ValueType() { }

	// RVA: 0x1246C84
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x1246C8C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1246C94
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x1246C9C
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x1246CC4
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1246CEC
	protected DatatypeImplementation get_Base() { }

	// RVA: -1
	internal abstract Type get_ListValueType() { }

	// RVA: -1
	internal abstract RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1246CF4
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1246CFC
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1246F54
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x12470BC
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, object typedValue) { }

	// RVA: 0x1246EE4
	internal string GetTypeName() { }

	// RVA: 0x12474BC
	protected int Compare(Byte[] value1, Byte[] value2) { }

	// RVA: 0x1247520
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_List
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Methods

	// RVA: 0x1247598
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x12464B8
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x12478EC
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1247BD4
	public override Type get_ValueType() { }

	// RVA: 0x1247BE4
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1247C08
	internal override Type get_ListValueType() { }

	// RVA: 0x1247C30
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1247CAC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1247CD0
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1247CD8
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, object typedValue) { }

	// RVA: 0x124852C
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

	// RVA: 0x1248A30
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1246678
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x1248A3C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1248B44
	public override Type get_ValueType() { }

	// RVA: 0x1248BC0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1248BC8
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1248C44
	internal override Type get_ListValueType() { }

	// RVA: 0x1248CC0
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1248CC8
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x124643C
	internal bool HasAtomicMembers() { }

	// RVA: 0x1246988
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x1248CD0
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1248EF0
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12493A8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anySimpleType
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1249464
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x12494E0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124955C
	public override Type get_ValueType() { }

	// RVA: 0x12495D8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12495E0
	internal override Type get_ListValueType() { }

	// RVA: 0x124965C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1249664
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124966C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1249674
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x12496D4
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1241338
	public void .ctor() { }

	// RVA: 0x1249710
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyAtomicType
{
	// Methods

	// RVA: 0x12497CC
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1249848
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1249850
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1244620
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_untypedAtomicType
{
	// Methods

	// RVA: 0x1249858
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x12498D4
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x12498DC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1244838
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_string
{
	// Methods

	// RVA: 0x12498E4
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x12498F0
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x12498F8
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1249974
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124997C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1249984
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124998C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12438C8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_boolean
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1249A98
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1249AA4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1249B20
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1249B28
	public override Type get_ValueType() { }

	// RVA: 0x1249BA4
	internal override Type get_ListValueType() { }

	// RVA: 0x1249C20
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1249C28
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1249C30
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1249CB8
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1241580
	public void .ctor() { }

	// RVA: 0x1249DFC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_float
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1249EB8
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1249EC4
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1249F40
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1249F48
	public override Type get_ValueType() { }

	// RVA: 0x1249FC4
	internal override Type get_ListValueType() { }

	// RVA: 0x124A040
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x124A048
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124A050
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124A0C8
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1242714
	public void .ctor() { }

	// RVA: 0x124A244
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_double
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x124A300
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x124A30C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124A388
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124A390
	public override Type get_ValueType() { }

	// RVA: 0x124A40C
	internal override Type get_ListValueType() { }

	// RVA: 0x124A488
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x124A490
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124A498
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124A510
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1241F40
	public void .ctor() { }

	// RVA: 0x124A68C
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

	// RVA: 0x124A748
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x124A754
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124A7D0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124A7D8
	public override Type get_ValueType() { }

	// RVA: 0x124A854
	internal override Type get_ListValueType() { }

	// RVA: 0x124A8D0
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x124A8D8
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124A8E0
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124A9B8
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1241E60
	public void .ctor() { }

	// RVA: 0x124AB58
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_duration
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x124AD48
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x124AD54
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124ADD0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124ADD8
	public override Type get_ValueType() { }

	// RVA: 0x124AE54
	internal override Type get_ListValueType() { }

	// RVA: 0x124AED0
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x124AED8
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124AEE0
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124AF8C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1242158
	public void .ctor() { }

	// RVA: 0x124B190
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonthDuration
{
	// Methods

	// RVA: 0x124B260
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x124B468
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1244918
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dayTimeDuration
{
	// Methods

	// RVA: 0x124B470
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x124B678
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1244700
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

	// RVA: 0x124B680
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x124B68C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124B708
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124B710
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x124B7E8
	public override Type get_ValueType() { }

	// RVA: 0x124B864
	internal override Type get_ListValueType() { }

	// RVA: 0x124B8E0
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x124B8E8
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124B8F0
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124BA70
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x124BDF8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeNoTimeZone
{
	// Methods

	// RVA: 0x1241AD0
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeTimeZone
{
	// Methods

	// RVA: 0x1241C00
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_dateTime
{
	// Methods

	// RVA: 0x12419A0
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeNoTimeZone
{
	// Methods

	// RVA: 0x1243AD8
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_timeTimeZone
{
	// Methods

	// RVA: 0x1243C08
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_time
{
	// Methods

	// RVA: 0x124BEC8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12439A8
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_date
{
	// Methods

	// RVA: 0x124BED0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1241870
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonth
{
	// Methods

	// RVA: 0x124BED8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1244330
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_year
{
	// Methods

	// RVA: 0x124BEE0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1244200
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_monthDay
{
	// Methods

	// RVA: 0x124BEE8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1242F98
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_day
{
	// Methods

	// RVA: 0x124BEF0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1241D30
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_month
{
	// Methods

	// RVA: 0x124BEF8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1242E68
	internal void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_hexBinary
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x124BF00
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x124BF0C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124BF88
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124BF90
	public override Type get_ValueType() { }

	// RVA: 0x124C00C
	internal override Type get_ListValueType() { }

	// RVA: 0x124C088
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x124C090
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124C098
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124C1AC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x124292C
	public void .ctor() { }

	// RVA: 0x124C3A0
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_base64Binary
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x124C470
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x124C47C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124C4F8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124C500
	public override Type get_ValueType() { }

	// RVA: 0x124C57C
	internal override Type get_ListValueType() { }

	// RVA: 0x124C5F8
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x124C600
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124C608
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124C71C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12414A0
	public void .ctor() { }

	// RVA: 0x124C90C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_anyURI
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x124C9DC
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x124C9E8
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124CA64
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124CA6C
	public override Type get_ValueType() { }

	// RVA: 0x124CAE8
	internal override bool get_HasValueFacets() { }

	// RVA: 0x124CAF0
	internal override Type get_ListValueType() { }

	// RVA: 0x124CB6C
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x124CB74
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124CB7C
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124CC48
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12413C0
	public void .ctor() { }

	// RVA: 0x124D060
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QName
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x124D130
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x124D13C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124D1B8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124D1C0
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x124D1C8
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124D1D0
	public override Type get_ValueType() { }

	// RVA: 0x124D24C
	internal override Type get_ListValueType() { }

	// RVA: 0x124D2C8
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x124D2D0
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1243630
	public void .ctor() { }

	// RVA: 0x124D524
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedString
{
	// Methods

	// RVA: 0x124D5F4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124D5FC
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x124D604
	internal override bool get_HasValueFacets() { }

	// RVA: 0x12433F0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedStringV1Compat
{
	// Methods

	// RVA: 0x124D60C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124D614
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1244460
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_token
{
	// Methods

	// RVA: 0x124D61C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124D624
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1243D38
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_tokenV1Compat
{
	// Methods

	// RVA: 0x124D62C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1244540
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_language
{
	// Methods

	// RVA: 0x124D634
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1242D84
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NMTOKEN
{
	// Methods

	// RVA: 0x124D63C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124D644
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1243308
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_Name
{
	// Methods

	// RVA: 0x124D64C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12430C8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NCName
{
	// Methods

	// RVA: 0x124D654
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124D65C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12431A8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ID
{
	// Methods

	// RVA: 0x124D790
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124D798
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1242A0C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_IDREF
{
	// Methods

	// RVA: 0x124D7A0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124D7A8
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1242AEC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENTITY
{
	// Methods

	// RVA: 0x124D7B0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124D7B8
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1242238
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_NOTATION
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x124D7C0
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x124D7CC
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124D848
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124D850
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x124D858
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x124D860
	public override Type get_ValueType() { }

	// RVA: 0x124D8DC
	internal override Type get_ListValueType() { }

	// RVA: 0x124D958
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x124D960
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x124DBB4
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x12434D0
	public void .ctor() { }

	// RVA: 0x124DE54
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_integer
{
	// Methods

	// RVA: 0x124DF24
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124DF2C
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1242C4C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonPositiveInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x124E0A8
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124E124
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124E12C
	internal override bool get_HasValueFacets() { }

	// RVA: 0x12433EC
	public void .ctor() { }

	// RVA: 0x124E134
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_negativeInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x124E25C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124E2D8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1243288
	public void .ctor() { }

	// RVA: 0x124E2E0
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

	// RVA: 0x124E408
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124E484
	internal override bool get_HasValueFacets() { }

	// RVA: 0x124E48C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124E494
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124E50C
	public override Type get_ValueType() { }

	// RVA: 0x124E588
	internal override Type get_ListValueType() { }

	// RVA: 0x124E604
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1242E64
	public void .ctor() { }

	// RVA: 0x124E780
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

	// RVA: 0x124E8F0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124E96C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124E974
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124E9EC
	public override Type get_ValueType() { }

	// RVA: 0x124EA68
	internal override Type get_ListValueType() { }

	// RVA: 0x124EAE4
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1242BCC
	public void .ctor() { }

	// RVA: 0x124EC60
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

	// RVA: 0x124EDD0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124EE4C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124EE54
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124EECC
	public override Type get_ValueType() { }

	// RVA: 0x124EF48
	internal override Type get_ListValueType() { }

	// RVA: 0x124EFC4
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12437F0
	public void .ctor() { }

	// RVA: 0x124F140
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

	// RVA: 0x124F2B0
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124F32C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124F334
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124F3AC
	public override Type get_ValueType() { }

	// RVA: 0x124F428
	internal override Type get_ListValueType() { }

	// RVA: 0x124F4A4
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1241660
	public void .ctor() { }

	// RVA: 0x124F620
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_nonNegativeInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x124F790
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124F80C
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124F814
	internal override bool get_HasValueFacets() { }

	// RVA: 0x12433E8
	public void .ctor() { }

	// RVA: 0x124F81C
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

	// RVA: 0x124F944
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124F9C0
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124F9C8
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124FA40
	public override Type get_ValueType() { }

	// RVA: 0x124FABC
	internal override Type get_ListValueType() { }

	// RVA: 0x124FB38
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1243F70
	public void .ctor() { }

	// RVA: 0x124FCF8
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

	// RVA: 0x124FE84
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x124FF00
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x124FF08
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x124FF80
	public override Type get_ValueType() { }

	// RVA: 0x124FFFC
	internal override Type get_ListValueType() { }

	// RVA: 0x1250078
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1243E98
	public void .ctor() { }

	// RVA: 0x12501F4
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

	// RVA: 0x1250380
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x12503FC
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1250404
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x125047C
	public override Type get_ValueType() { }

	// RVA: 0x12504F8
	internal override Type get_ListValueType() { }

	// RVA: 0x1250574
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1243FF0
	public void .ctor() { }

	// RVA: 0x12506F0
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

	// RVA: 0x125087C
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x12508F8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1250900
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1250978
	public override Type get_ValueType() { }

	// RVA: 0x12509F4
	internal override Type get_ListValueType() { }

	// RVA: 0x1250A70
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1243E18
	public void .ctor() { }

	// RVA: 0x1250BEC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_positiveInteger
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Methods

	// RVA: 0x1250D78
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1250DF4
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x12435B0
	public void .ctor() { }

	// RVA: 0x1250DFC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_doubleXdr
{
	// Methods

	// RVA: 0x1250F24
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1242020
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_floatXdr
{
	// Methods

	// RVA: 0x1251110
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x12427F4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_QNameXdr
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x12512FC
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1251304
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1251594
	public override Type get_ValueType() { }

	// RVA: 0x1251610
	internal override Type get_ListValueType() { }

	// RVA: 0x1243710
	public void .ctor() { }

	// RVA: 0x125168C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_ENUMERATION
{
	// Methods

	// RVA: 0x125175C
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x12424FC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_char
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1251764
	public override Type get_ValueType() { }

	// RVA: 0x12517E0
	internal override Type get_ListValueType() { }

	// RVA: 0x125185C
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1251864
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x12518EC
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1251ABC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1241790
	public void .ctor() { }

	// RVA: 0x1251BB0
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_fixed
{
	// Methods

	// RVA: 0x1251C6C
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x12521EC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x12425DC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class Datatype_uuid
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Methods

	// RVA: 0x1252380
	public override Type get_ValueType() { }

	// RVA: 0x12523FC
	internal override Type get_ListValueType() { }

	// RVA: 0x1252478
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1252480
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1252520
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x12526FC
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, object typedValue) { }

	// RVA: 0x1244120
	public void .ctor() { }

	// RVA: 0x12527FC
	private static void .cctor() { }

}

// Namespace: 
private class NamespaceManager
{
	// Methods

	// RVA: 0x125504C
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1255044
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

	// RVA: 0x12528CC
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x1252974
	private void Init() { }

	// RVA: 0x1252C2C
	public override void Validate() { }

	// RVA: 0x1252F48
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x1252FF4
	private void ValidatePIComment() { }

	// RVA: 0x1252E28
	private void ValidateElement() { }

	// RVA: 0x1253434
	private void ValidateChildElement() { }

	// RVA: 0x12536A4
	private void ValidateStartElement() { }

	// RVA: 0x12540AC
	private void ValidateEndStartElement() { }

	// RVA: 0x1253578
	private void ProcessElement() { }

	// RVA: 0x1254270
	public override void CompleteValidation() { }

	// RVA: 0x1253280
	private void ValidateEndElement() { }

	// RVA: 0x12544B0
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x12544EC
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1253B04
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1254778
	internal void AddID(string name, object node) { }

	// RVA: 0x1254818
	public override object FindId(string name) { }

	// RVA: 0x12530C4
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x1254834
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x1254384
	private void CheckForwardRefs() { }

	// RVA: 0x1252AE4
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x12542C8
	private bool Pop() { }

	// RVA: 0x12548E0
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x1254BF0
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x1254FBC
	private static void .cctor() { }

}

// Namespace: 
private struct Map
{
	// Fields
	internal Char match; // 0x10
	internal string replacement; // 0x18

	// Methods

	// RVA: 0x1259D10
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

	// RVA: 0x1255798
	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x1255ADC
	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1255F00
	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x12562E8
	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x12566D0
	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x1256908
	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x1256B0C
	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x12574B8
	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1257758
	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1256F78
	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1257218
	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x12579F8
	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1257E70
	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x12581F8
	internal void FinishFacetCompile() { }

	// RVA: 0x1258D88
	private void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x125859C
	internal void CompileFacetCombinations() { }

	// RVA: 0x12594A0
	private void CopyFacetsFromBaseType() { }

	// RVA: 0x1258BCC
	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x1259220
	private static string Preprocess(string pattern) { }

	// RVA: 0x1258AC0
	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1258B50
	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1258D1C
	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x12599B8
	private void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x12599F8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal abstract class FacetsChecker
{
	// Methods

	// RVA: 0x1255054
	internal virtual Exception CheckLexicalFacets(string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255308
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255310
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255318
	internal virtual Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255320
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255328
	internal virtual Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255330
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255338
	internal virtual Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255340
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255348
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255350
	internal virtual Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255358
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255360
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125509C
	internal void CheckWhitespaceFacets(string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x12551A4
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x1255368
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1255370
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x125897C
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x1258AB8
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

	// RVA: 0x124ACFC
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0x1259D20
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1259D9C
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125A504
	internal override Exception CheckValueFacets(Int64 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125A59C
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125A634
	internal override Exception CheckValueFacets(Int16 value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125A6CC
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x125A3BC
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x1251F48
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0x125A750
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class Numeric2FacetsChecker
{
	// Methods

	// RVA: 0x125A7F4
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125A860
	internal override Exception CheckValueFacets(Double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125ACC8
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125ACD8
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x125ABE4
	private bool MatchEnumeration(Double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x1241320
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DurationFacetsChecker
{
	// Methods

	// RVA: 0x125AE00
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125AF10
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125B3AC
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x125B294
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x1241330
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class DateTimeFacetsChecker
{
	// Methods

	// RVA: 0x125B430
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125B4A0
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125BA3C
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x125B888
	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1241328
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class StringFacetsChecker
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Methods

	// RVA: 0x125BAA4
	private static Regex get_LanguagePattern() { }

	// RVA: 0x125BB74
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x125BBE0
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x124CDFC
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0x125C108
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x125BE98
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x125BBE8
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x1241318
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class QNameFacetsChecker
{
	// Methods

	// RVA: 0x10A5E04
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A5F2C
	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A627C
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A6128
	private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

	// RVA: 0x10A6384
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class MiscFacetsChecker
{
	// Methods

	// RVA: 0x10A638C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class BinaryFacetsChecker
{
	// Methods

	// RVA: 0x10A6394
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A6428
	internal override Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A6758
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A6610
	private bool MatchEnumeration(Byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A67F8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class ListFacetsChecker
{
	// Methods

	// RVA: 0x10A6800
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A6A30
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A6B14
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class UnionFacetsChecker
{
	// Methods

	// RVA: 0x10A6B1C
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A6C1C
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x10A6D00
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

	// RVA: 0x10A6D08
	public void set_Occurrence(InferenceOption value) { }

	// RVA: 0x10A6D10
	public InferenceOption get_Occurrence() { }

	// RVA: 0x10A6D18
	public void set_TypeInference(InferenceOption value) { }

	// RVA: 0x10A6D20
	public void .ctor() { }

	// RVA: 0x10A6E60
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x10A6ED8
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x10A9460
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x10ABEEC
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x10A7988
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x10A7FB4
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x10ACC30
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x10AC328
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x10AD200
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, int lastUsedSeqItem, bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x10AC464
	internal void ProcessAttributes(XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x10AD14C
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x10ACD6C
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x10AA0B0
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x10ABF8C
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, XmlSchema parentSchema) { }

	// RVA: 0x10AE36C
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x10A9CFC
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x10AE4C8
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x10ACB88
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x10AE934
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x10AA420
	internal XmlQualifiedName RefineSimpleType(string s, int iTypeFlags) { }

	// RVA: 0x10AEAE0
	internal static int InferSimpleType(string s, bool bNeedsRangeCheck) { }

	// RVA: 0x10AFF44
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x10AE64C
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x10AB590
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x10AE19C
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x10B008C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaInferenceException
{
	// Methods

	// RVA: 0x10B0B74
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10B0B7C
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10B0B84
	public void .ctor() { }

	// RVA: 0x10AE874
	internal void .ctor(string res, string arg) { }

	// RVA: 0x10A7950
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

	// RVA: 0x10B0B90
	public void .ctor() { }

	// RVA: 0x10B0B98
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x10B0E38
	public NamespaceList Clone() { }

	// RVA: 0x10B0F7C
	public ListType get_Type() { }

	// RVA: 0x10B0F84
	public string get_Excluded() { }

	// RVA: 0x10B0F8C
	public ICollection get_Enumerate() { }

	// RVA: 0x10B0FFC
	public virtual bool Allows(string ns) { }

	// RVA: 0x10B109C
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x10B10C0
	public override string ToString() { }

	// RVA: 0x10B1594
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0x10B1954
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x10B1EA4
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0x10B2014
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x10B2610
	private void RemoveNamespace(string tns) { }

}

// Namespace: System.Xml.Schema
internal class NamespaceListV1Compat
{
	// Methods

	// RVA: 0x10B2674
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x10B2678
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

	// RVA: 0x10B26F4
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x10B27FC
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0x10B2860
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0x10B3364
	private bool CheckSchemaRoot(SchemaType rootType, string code) { }

	// RVA: 0x10B34BC
	public SchemaType FinishParsing() { }

	// RVA: 0x10B34C4
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x10B34CC
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10B34D4
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0x10B2C98
	public bool ParseReaderNode() { }

	// RVA: 0x10B34DC
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0x10B3724
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0x10B3D68
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0x10B3B84
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x10B3E8C
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

	// RVA: 0x10B4094
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

	// RVA: 0x10B40E4
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x10B41E8
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0x10B7968
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x10B8054
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x10B80F8
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10B8100
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x10B8108
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x10B8110
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x10B8118
	internal XmlSchema get_RootSchema() { }

	// RVA: 0x10B5660
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0x10B488C
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0x10B7A48
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0x10B8190
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x10B83BC
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0x10B57D8
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0x10B8A18
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0x10B6B38
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0x10BB95C
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0x10BB8C0
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0x10B88F0
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0x10BC138
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0x10BBA9C
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x10BBB58
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10BC018
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x10BBCB4
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x10B9C70
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10BC9FC
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10BC738
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x10B9DFC
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10BB088
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x10BD6C4
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x10BD2EC
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x10BDAB4
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x10BA9BC
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x10B9F78
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x10BB314
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x10BB564
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x10BDEC4
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10BCE70
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x10B85DC
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x10BC470
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x10BCC30
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x10B8120
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x10B8164
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0x10B4728
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x10B8508
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x10B852C
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x10BB844
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

	// RVA: 0x10BE8A0
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x10BE8A8
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0x10BE8B4
	private void .ctor() { }

	// RVA: 0x10BE8BC
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0x10BE8C4
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x10BE8E4
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x10BE8EC
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0x10BE8F4
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0x10BE948
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x10BE950
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0x10BE960
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x10BE9A8
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x10BE9B0
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0x10BE9B8
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x10BE9C0
	internal int get_LinePosition() { }

	// RVA: 0x10BE9C8
	internal void set_LinePosition(int value) { }

	// RVA: 0x10BE9D0
	internal int get_LineNumber() { }

	// RVA: 0x10BE9D8
	internal void set_LineNumber(int value) { }

	// RVA: 0x10BE9E0
	internal int get_ValueLinePosition() { }

	// RVA: 0x10BE9E8
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x10BE9F0
	internal int get_ValueLineNumber() { }

	// RVA: 0x10BE9F8
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0x10BE984
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x10BEA00
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0x10BE924
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x10BEA08
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0x10BEA3C
	internal Reserve get_Reserved() { }

	// RVA: 0x10BEA44
	internal void set_Reserved(Reserve value) { }

	// RVA: 0x10BEA4C
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x10BEA54
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x10BEA5C
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x10BEA64
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0x10BECEC
	internal SchemaAttDef Clone() { }

	// RVA: 0x10BED54
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

	// RVA: 0x10BEDC0
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

	// RVA: 0x10BEDC8
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0x10BEE94
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0x10BEF04
	private void Prepare() { }

	// RVA: 0x10BF390
	private void Cleanup() { }

	// RVA: 0x10C3844
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0x10C029C
	private void Compile() { }

	// RVA: 0x10C221C
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x10C3800
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10C325C
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10C32AC
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10C3644
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10C3660
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x10C8C90
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x10C3224
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x10C8D8C
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10C4098
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0x10C8AC0
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x10C452C
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x10C5BA0
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10C93B4
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10C9898
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x10C4E14
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10C99C0
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x10C9C58
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x10CA0D0
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x10CA598
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x10C8958
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x10CBF10
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0x10C8F04
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0x10CD46C
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0x10CD5D4
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0x10CDB6C
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0x10CE02C
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0x10CE530
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0x10CCCCC
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10CEAA0
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x10CEBC8
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x10CEC1C
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x10CEC68
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x10CEF08
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x10CF2FC
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x10CF620
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x10CFA88
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x10D07F8
	private void CalculateSequenceRange(XmlSchemaSequence sequence, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x10CFD30
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10D0610
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x10D06F8
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x10CE9D4
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x10CFE18
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x10D0C24
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10CC098
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x10C4638
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10CA93C
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x10D0D08
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x10D0C4C
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x10C7478
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x10C8174
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x10C6554
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x10CC134
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x10D0DC4
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x10D14B4
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x10C8880
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x10C9204
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x10CCBE4
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x10CCA48
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

	// RVA: 0x10D1724
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x10D172C
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0x10D1998
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x10D4C28
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10D1BD0
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0x10D4E34
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x10D28C0
	private void Preprocess(XmlSchema schema, string targetNamespace, Compositor compositor) { }

	// RVA: 0x10D515C
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0x10D82A4
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0x10D7C0C
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x10D7CB4
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10D8184
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x10D7E20
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x10D6330
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10D8ACC
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10D887C
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x10D64BC
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10D74BC
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x10D94E4
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x10D9174
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x10D9864
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x10D6EBC
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x10D65C8
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x10D7748
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x10D7928
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x10D9BF0
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10D8E34
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x10D2648
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x10D85B4
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x10D8C90
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x10D5048
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x10D506C
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x10D4C30
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x10D4CFC
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

	// RVA: 0x10DA558
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x10DA614
	protected void .ctor() { }

	// RVA: 0x10DA690
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x10DA698
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0x10DA6A0
	internal string get_Prefix() { }

	// RVA: 0x10DA6C4
	internal void set_Prefix(string value) { }

	// RVA: 0x10DA6CC
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x10DA6D4
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x10DA6DC
	internal Use get_Presence() { }

	// RVA: 0x10DA6E4
	internal void set_Presence(Use value) { }

	// RVA: 0x10DA6EC
	internal Int64 get_MaxLength() { }

	// RVA: 0x10DA6F4
	internal void set_MaxLength(Int64 value) { }

	// RVA: 0x10DA6FC
	internal Int64 get_MinLength() { }

	// RVA: 0x10DA704
	internal void set_MinLength(Int64 value) { }

	// RVA: 0x10DA70C
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x10DA714
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x10DA71C
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x10DA724
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0x10DA72C
	internal void AddValue(string value) { }

	// RVA: 0x10DA7E4
	internal System.Collections.Generic.List<System.String> get_Values() { }

	// RVA: 0x10DA7EC
	internal void set_Values(System.Collections.Generic.List<System.String> value) { }

	// RVA: 0x10DA7F4
	internal string get_DefaultValueRaw() { }

	// RVA: 0x10DA818
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x10DA820
	internal object get_DefaultValueTyped() { }

	// RVA: 0x10DA828
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0x10DA830
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0x10DA8F8
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

	// RVA: 0x10DA950
	internal void .ctor() { }

	// RVA: 0x10DAA80
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0x10DAC08
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x10DACFC
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0x10DADFC
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x10DAE04
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x10DAEC4
	private System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0x10DAECC
	internal bool get_IsIdDeclared() { }

	// RVA: 0x10DAED4
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0x10DAEDC
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0x10DAEE4
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0x10DAEEC
	internal SchemaElementDecl Clone() { }

	// RVA: 0x10DAF54
	internal bool get_IsAbstract() { }

	// RVA: 0x10DAF5C
	internal void set_IsAbstract(bool value) { }

	// RVA: 0x10DAF64
	internal bool get_IsNillable() { }

	// RVA: 0x10DAF6C
	internal void set_IsNillable(bool value) { }

	// RVA: 0x10DAF74
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x10DAF7C
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x10DAF84
	internal bool get_IsNotationDeclared() { }

	// RVA: 0x10DAF8C
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0x10DAF94
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0x10DAFA4
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x10DAFAC
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x10DAFB4
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x10DAFBC
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x10DAFC4
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x10DAFCC
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x10DAFD4
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x10DAFDC
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x10DAFE4
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x10DAFEC
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0x10DB118
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x10DB19C
	internal System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x10DB1A4
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttDefs() { }

	// RVA: 0x10DB1AC
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0x10DB1B4
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0x10DB580
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

	// RVA: 0x10DB5E8
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0x10DB68C
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0x10DB6AC
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0x10DB6B4
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x10DB6BC
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x10DB6E4
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0x10DB6EC
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0x10DB734
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x10DB77C
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x10DB784
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x10DB78C
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x10DB794
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x10DB79C
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0x10DB7A4
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x10DB8B0
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x10DB8B8
	internal string get_Url() { }

	// RVA: 0x10DB8C0
	internal void set_Url(string value) { }

	// RVA: 0x10DB8F0
	internal string get_Pubid() { }

	// RVA: 0x10DB8F8
	internal void set_Pubid(string value) { }

	// RVA: 0x10DB900
	internal bool get_IsExternal() { }

	// RVA: 0x10DB908
	internal void set_IsExternal(bool value) { }

	// RVA: 0x10DB910
	internal bool get_DeclaredInExternal() { }

	// RVA: 0x10DB918
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x10DB920
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x10DB928
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x10DB930
	internal string get_Text() { }

	// RVA: 0x10DB938
	internal void set_Text(string value) { }

	// RVA: 0x10DB964
	internal int get_Line() { }

	// RVA: 0x10DB96C
	internal void set_Line(int value) { }

	// RVA: 0x10DB974
	internal int get_Pos() { }

	// RVA: 0x10DB97C
	internal void set_Pos(int value) { }

	// RVA: 0x10DB710
	internal string get_BaseURI() { }

	// RVA: 0x10DB984
	internal void set_BaseURI(string value) { }

	// RVA: 0x10DB98C
	internal bool get_ParsingInProgress() { }

	// RVA: 0x10DB994
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0x10DB758
	internal string get_DeclaredURI() { }

	// RVA: 0x10DB99C
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

	// RVA: 0x10DB9A4
	internal void .ctor() { }

	// RVA: 0x10DBB8C
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x10DBB94
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x10DBB9C
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x10DBBA4
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x10DBBAC
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0x10DBBB4
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_GeneralEntities() { }

	// RVA: 0x10DBC50
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x10DBCEC
	internal SchemaType get_SchemaType() { }

	// RVA: 0x10DBCF4
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x10DBCFC
	internal System.Collections.Generic.Dictionary<System.String,System.Boolean> get_TargetNamespaces() { }

	// RVA: 0x10DBD04
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x10DBD0C
	internal System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0x10DBD14
	internal System.Collections.Generic.Dictionary<System.String,System.Xml.Schema.SchemaNotation> get_Notations() { }

	// RVA: 0x10DBDB0
	internal int get_ErrorCount() { }

	// RVA: 0x10DBDB8
	internal void set_ErrorCount(int value) { }

	// RVA: 0x10DBDC0
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0x10DBE44
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0x10DBEC8
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0x10DBF6C
	internal bool HasSchema(string ns) { }

	// RVA: 0x10DBFD0
	internal bool Contains(string ns) { }

	// RVA: 0x10DC034
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0x10DC1C8
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, AttributeMatchState attributeMatchState) { }

	// RVA: 0x10DC43C
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, bool skip) { }

	// RVA: 0x10DC550
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0x10DD524
	internal void Finish() { }

	// RVA: 0x10DD880
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x10DD888
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x10DD890
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x10DD964
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x10DDA34
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x10DDA3C
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

	// RVA: 0x10DDA44
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x10E083C
	public void CreateTokenToQNameTable() { }

	// RVA: 0x10E276C
	public SchemaType SchemaTypeFromRoot(string localName, string ns) { }

	// RVA: 0x10E281C
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x10E286C
	public bool IsXDRRoot(string localName, string ns) { }

}

// Namespace: System.Xml.Schema
internal class SchemaNamespaceManager
{
	// Fields
	private XmlSchemaObject node; // 0x50

	// Methods

	// RVA: 0x10E28BC
	public void .ctor(XmlSchemaObject node) { }

	// RVA: 0x10E28F0
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x10E2A34
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

	// RVA: 0x10E2E30
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x10E2E64
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x10E2E6C
	internal string get_SystemLiteral() { }

	// RVA: 0x10E2E74
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x10E2E7C
	internal string get_Pubid() { }

	// RVA: 0x10E2E84
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

	// RVA: 0x10E2E8C
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x10E30DC
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0x10E627C
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0x10E82BC
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0x10E5148
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x10E8444
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0x10E3180
	internal bool Compile() { }

	// RVA: 0x10E7C5C
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x10E7CE4
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10E7D40
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10E8204
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10E7AAC
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x10ED99C
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x10E7C98
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x10EDA90
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10EC974
	private void ProcessSubstitutionGroups() { }

	// RVA: 0x10EDC3C
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x10ED824
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0x10ED914
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0x10E8558
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x10E9C18
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10EF110
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x10EF5F4
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x10E9024
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10EF71C
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x10EF9B4
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x10EFE68
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x10F033C
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x10ED1D4
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x10EE5C0
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10F1D14
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0x10EE200
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0x10F4B2C
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0x10F38A8
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0x10F3E34
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0x10F4100
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0x10F4630
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0x10F2AD4
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0x10F2D28
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10F4EC8
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x10F5108
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x10F52C0
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x10F53CC
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x10F5894
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0x10F6980
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0x10F6164
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x10F6518
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x10F6B7C
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x10F6F50
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x10F7A18
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x10F7B00
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x10F4DFC
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x10F71F4
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, Decimal minOccurs, Decimal maxOccurs) { }

	// RVA: 0x10F7C00
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x10F1E94
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x10E8660
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x10F06D8
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x10EE6AC
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0x10F7DA0
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0x10F7CE4
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x10F7C28
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x10EB6A4
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x10F7ECC
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0x10EC0F8
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x10EA608
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x10F1F30
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x10F8098
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x10F876C
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x10EE430
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0x10EC7FC
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x10EF010
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x10F29F8
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x10F2868
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0x10F4D78
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0x10F7038
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

	// RVA: 0x10F89DC
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0x10F8A5C
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x10F8AE8
	public XmlSeverityType get_Severity() { }

	// RVA: 0x10F8AF0
	public XmlSchemaException get_Exception() { }

}

// Namespace: System.Xml.Schema
public sealed class ValidationEventHandler
{
	// Methods

	// RVA: 0x10F8AF8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x10F8C1C
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

	// RVA: 0x10F8C30
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

	// RVA: 0x10FDCC0
	internal void .ctor() { }

	// RVA: 0x10FE1F4
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

	// RVA: 0x1103550
	internal static void Copy(GroupContent from, GroupContent to) { }

	// RVA: 0x10FA530
	internal static GroupContent Copy(GroupContent other) { }

	// RVA: 0x10F8F60
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

	// RVA: 0x10F8F50
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

	// RVA: 0x10F8F58
	public void .ctor() { }

}

// Namespace: 
private sealed class XdrBuildFunction
{
	// Methods

	// RVA: 0x110306C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x110357C
	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }

}

// Namespace: 
private sealed class XdrInitFunction
{
	// Methods

	// RVA: 0x110332C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1103590
	public virtual void Invoke(XdrBuilder builder, object obj) { }

}

// Namespace: 
private sealed class XdrBeginChildFunction
{
	// Methods

	// RVA: 0x11033E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11035A4
	public virtual void Invoke(XdrBuilder builder) { }

}

// Namespace: 
private sealed class XdrEndChildFunction
{
	// Methods

	// RVA: 0x110349C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x11035B8
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

	// RVA: 0x1103128
	internal void .ctor(Token a, XmlTokenizedType ttype, XdrBuildFunction build) { }

	// RVA: 0x11031D0
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

	// RVA: 0x110327C
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

	// RVA: 0x10F8CA0
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x10F8F68
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x10F9660
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x10FA118
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x10F9AE4
	private bool LoadSchema(string uri) { }

	// RVA: 0x10F9A20
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x10FA260
	internal override bool IsContentParsed() { }

	// RVA: 0x10FA268
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x10FA2C4
	internal override void ProcessCData(string value) { }

	// RVA: 0x10FA350
	internal override void StartChildren() { }

	// RVA: 0x10FA38C
	internal override void EndChildren() { }

	// RVA: 0x10F9460
	private void Push() { }

	// RVA: 0x10FA3D4
	private void Pop() { }

	// RVA: 0x10FA47C
	private void PushGroupInfo() { }

	// RVA: 0x10FA5B0
	private void PopGroupInfo() { }

	// RVA: 0x10FA658
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0x10FA6C4
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FA740
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FA744
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0x10FA840
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0x10FADE0
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0x10FAF10
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FB0EC
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FB358
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FB4E4
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FB6E8
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FB904
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FBA04
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FBBBC
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FBD74
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0x10FC08C
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0x10FC570
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0x10FC680
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FC8DC
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FCA78
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FCA9C
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FCD38
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FCE38
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FCEB4
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FCF30
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0x10FCFC0
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0x10FD480
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0x10FD524
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FD774
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FD928
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FDAEC
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0x10FDC34
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0x10FDCE8
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FDDD4
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FDE88
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FDEAC
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0x10FE1D4
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0x10FE2F8
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0x10FE3C8
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FE4D8
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FE568
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x10FE5F8
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0x10FE7B0
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x10FE878
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0x10FE968
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x10FE9EC
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0x10F92A8
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x10F94B8
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x10F9FC8
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0x10FB594
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0x10FD6B8
	private void AddOrder() { }

	// RVA: 0x10FC95C
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0x10FD7F4
	private static UInt32 ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x10FD9A8
	private static UInt32 ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x10FDC04
	private static void HandleMinMax(ParticleContentValidator pContent, UInt32 cMin, UInt32 cMax) { }

	// RVA: 0x10FBA80
	private static void ParseDtMaxLength(UInt32 cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x10FBC38
	private static void ParseDtMinLength(UInt32 cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x10FC4D8
	private static void CompareMinMaxLength(UInt32 cMin, UInt32 cMax, XdrBuilder builder) { }

	// RVA: 0x10FEAF4
	private static bool ParseInteger(string str, UInt32 n) { }

	// RVA: 0x10FAD14
	private void XDR_CheckAttributeDefault(DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0x10FD430
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0x10FB194
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0x10FB400
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0x10FCB60
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0x10FD344
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0x10F9A14
	private bool IsGlobal(int flags) { }

	// RVA: 0x10FA120
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x10FB864
	private void SendValidationEvent(string code) { }

	// RVA: 0x10F957C
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x10FF168
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x10FF3A8
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

	// RVA: 0x11035CC
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1103858
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1103658
	private void Init() { }

	// RVA: 0x1103A94
	public override void Validate() { }

	// RVA: 0x1103E2C
	private void ValidateElement() { }

	// RVA: 0x11041A4
	private void ValidateChildElement() { }

	// RVA: 0x1103B68
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1103B78
	private void ProcessInlineSchema() { }

	// RVA: 0x11042E8
	private void ProcessElement() { }

	// RVA: 0x1103FD4
	private void ValidateEndElement() { }

	// RVA: 0x11043A8
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x1104710
	private void ValidateStartElement() { }

	// RVA: 0x1104B8C
	private void ValidateEndStartElement() { }

	// RVA: 0x1105910
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x1105620
	private void LoadSchema(string uri) { }

	// RVA: 0x1105FD0
	private bool get_HasSchema() { }

	// RVA: 0x1105FF8
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1106034
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1106350
	public override void CompleteValidation() { }

	// RVA: 0x1104F34
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x10FEB30
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x11062B0
	internal void AddID(string name, object node) { }

	// RVA: 0x1106638
	public override object FindId(string name) { }

	// RVA: 0x11038FC
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1105550
	private void Pop() { }

	// RVA: 0x1106414
	private void CheckForwardRefs() { }

	// RVA: 0x1105834
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

	// RVA: 0x1106D48
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x1107B44
	public string LookupNamespace(string prefix) { }

	// RVA: 0x1107B84
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x1107BBC
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

	// RVA: 0x1106654
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x11066F0
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x110678C
	internal void .ctor(XmlSchemaType xmlType, Double value) { }

	// RVA: 0x1106828
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x11068C4
	internal void .ctor(XmlSchemaType xmlType, Int64 value) { }

	// RVA: 0x1106960
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x1106A20
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1106D98
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x1106E58
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11070AC
	private object System.ICloneable.Clone() { }

	// RVA: 0x11070B0
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x11070B8
	public override Type get_ValueType() { }

	// RVA: 0x11070E4
	public override object get_TypedValue() { }

	// RVA: 0x11072D4
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x11073CC
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x11074D8
	public override Double get_ValueAsDouble() { }

	// RVA: 0x11075E4
	public override int get_ValueAsInt() { }

	// RVA: 0x11076E4
	public override Int64 get_ValueAsLong() { }

	// RVA: 0x11077F0
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1107A18
	public override string get_Value() { }

	// RVA: 0x1107B38
	public override string ToString() { }

	// RVA: 0x1106C30
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

	// RVA: 0x1107C64
	public void .ctor() { }

	// RVA: 0x1107E4C
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x1108018
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x110822C
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x11082DC
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0x11082E4
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x11082EC
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x11082F4
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x11082FC
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x1108304
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x110830C
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x1108314
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x110831C
	public string get_TargetNamespace() { }

	// RVA: 0x1108324
	public void set_TargetNamespace(string value) { }

	// RVA: 0x110832C
	public string get_Version() { }

	// RVA: 0x1108334
	public void set_Version(string value) { }

	// RVA: 0x110833C
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x1108344
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x110834C
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x1108354
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x110835C
	internal bool get_IsPreprocessed() { }

	// RVA: 0x1108364
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x110836C
	internal bool get_IsRedefined() { }

	// RVA: 0x1108374
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x110837C
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x1108404
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x110848C
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x1108514
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x110859C
	public string get_Id() { }

	// RVA: 0x11085A4
	public void set_Id(string value) { }

	// RVA: 0x11085AC
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x11085B4
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x11085BC
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0x11085C4
	internal Uri get_BaseUri() { }

	// RVA: 0x11085CC
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x11085D4
	internal int get_SchemaId() { }

	// RVA: 0x1108660
	internal bool get_IsChameleon() { }

	// RVA: 0x1108668
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x1108670
	internal Hashtable get_Ids() { }

	// RVA: 0x1108678
	internal XmlDocument get_Document() { }

	// RVA: 0x1108700
	internal int get_ErrorCount() { }

	// RVA: 0x1108708
	internal void set_ErrorCount(int value) { }

	// RVA: 0x1108710
	internal XmlSchema Clone() { }

	// RVA: 0x11088CC
	internal XmlSchema DeepClone() { }

	// RVA: 0x1109A44
	internal override string get_IdAttribute() { }

	// RVA: 0x1109A4C
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x1109A54
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x1109A5C
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1109A64
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x1109B2C
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x1109BB4
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x1109C3C
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x1109E38
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAll
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x1109E88
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1109E90
	internal override bool get_IsEmpty() { }

	// RVA: 0x1109EE4
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1109EEC
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

	// RVA: 0x110A048
	public string get_Id() { }

	// RVA: 0x110A050
	public void set_Id(string value) { }

	// RVA: 0x110A058
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x110A060
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x110A068
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x110A070
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x110A078
	internal override string get_IdAttribute() { }

	// RVA: 0x110A080
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x110A088
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x110A090
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x110A098
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

	// RVA: 0x110A0A0
	public string get_Id() { }

	// RVA: 0x110A0A8
	public void set_Id(string value) { }

	// RVA: 0x110A0B0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x110A0B8
	internal override string get_IdAttribute() { }

	// RVA: 0x110A0C0
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x110A0C8
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x110A0D0
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

	// RVA: 0x110A148
	public string get_Namespace() { }

	// RVA: 0x110A150
	public void set_Namespace(string value) { }

	// RVA: 0x110A158
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x110A160
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x110A168
	internal string get_ResolvedNamespace() { }

	// RVA: 0x110A1C4
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x110A1D8
	internal override string get_NameString() { }

	// RVA: 0x110A6BC
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x110A748
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x110A7F4
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x110A820
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

	// RVA: 0x110A8A8
	public void set_Namespace(string value) { }

	// RVA: 0x110A8B0
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0x110A8B8
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x110A8C0
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x110A8C8
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x110A8DC
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x110A968
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x110AA14
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x110AA40
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x110AA68
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x110AB48
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x110AB40
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAppInfo
{
	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Methods

	// RVA: 0x110AC20
	public void set_Source(string value) { }

	// RVA: 0x110AC28
	public XmlNode[] get_Markup() { }

	// RVA: 0x110AC30
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x110AC38
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

	// RVA: 0x110AC40
	public string get_DefaultValue() { }

	// RVA: 0x110AC48
	public void set_DefaultValue(string value) { }

	// RVA: 0x110AC50
	public string get_FixedValue() { }

	// RVA: 0x110AC58
	public void set_FixedValue(string value) { }

	// RVA: 0x110AC60
	public XmlSchemaForm get_Form() { }

	// RVA: 0x110AC68
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x110AC70
	public string get_Name() { }

	// RVA: 0x110AC78
	public void set_Name(string value) { }

	// RVA: 0x110AC80
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x110AC88
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x110AD60
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x110AD68
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x110AE40
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x110AE48
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x110AE50
	public XmlSchemaUse get_Use() { }

	// RVA: 0x110AE58
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x110AE60
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x110AE68
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x110AE70
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x110AE88
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x110AE90
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x110AE98
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x110AEA0
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x110AEA8
	internal override string get_NameAttribute() { }

	// RVA: 0x110AEB0
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x110AEB8
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x110AFC0
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

	// RVA: 0x110B06C
	public string get_Name() { }

	// RVA: 0x110B074
	public void set_Name(string value) { }

	// RVA: 0x110B07C
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x110B084
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x110B08C
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x110B094
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x110B09C
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x110B124
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x110B12C
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x110B134
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x110B13C
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x110B144
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x110B14C
	internal int get_SelfReferenceCount() { }

	// RVA: 0x110B154
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x110B15C
	internal override string get_NameAttribute() { }

	// RVA: 0x110B164
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x110B16C
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x110B174
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x110B6D4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroupRef
{
	// Fields
	private XmlQualifiedName refName; // 0x50

	// Methods

	// RVA: 0x110B788
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x110B790
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x110B868
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaChoice
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x110B8E4
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x110B8EC
	internal override bool get_IsEmpty() { }

	// RVA: 0x110B8F4
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x110B8FC
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

	// RVA: 0x110B9D0
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x110BB20
	public int get_Count() { }

	// RVA: 0x110BB48
	public XmlNameTable get_NameTable() { }

	// RVA: 0x110BB50
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x110BB58
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x110BC08
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x110BCEC
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x110BD80
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x110C150
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x110C158
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x110C15C
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1105F20
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x110C184
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x11043A0
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x110C244
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x110C3C0
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x110C524
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x110C52C
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

	// RVA: 0x110C534
	internal void set_NamespaceURI(string value) { }

	// RVA: 0x110C53C
	internal SchemaInfo get_SchemaInfo() { }

	// RVA: 0x110C544
	internal void set_SchemaInfo(SchemaInfo value) { }

	// RVA: 0x110C54C
	internal XmlSchema get_Schema() { }

	// RVA: 0x110C554
	internal void set_Schema(XmlSchema value) { }

	// RVA: 0x110C3B8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCollectionEnumerator
{
	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x110BC9C
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x110C55C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x110C614
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x110C09C
	public bool MoveNext() { }

	// RVA: 0x110C6C8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x110BFA8
	public XmlSchema get_Current() { }

	// RVA: 0x110C6CC
	internal XmlSchemaCollectionNode get_CurrentNode() { }

}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCompilationSettings
{
	// Fields
	private bool enableUpaCheck; // 0x10

	// Methods

	// RVA: 0x110C7B4
	public void .ctor() { }

	// RVA: 0x110C7E0
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

	// RVA: 0x110C7E8
	public bool get_IsMixed() { }

	// RVA: 0x110C7F0
	public void set_IsMixed(bool value) { }

	// RVA: 0x110C800
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x110C808
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x110C810
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x110C818
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

	// RVA: 0x110C828
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x110C830
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x110C908
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x110C910
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x110C918
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x110C920
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x110C928
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x110C930
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x110C938
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

	// RVA: 0x110C9F4
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x110C9FC
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x110CAD4
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x110CADC
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x110CAE4
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x110CAEC
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x110CAF4
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x110CAFC
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x110CB04
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

	// RVA: 0x110CBB8
	private static void .cctor() { }

	// RVA: 0x110CEA8
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x110D414
	public void .ctor() { }

	// RVA: 0x110D528
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x110D5A4
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x110D498
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x110D620
	public bool get_IsAbstract() { }

	// RVA: 0x110D62C
	public void set_IsAbstract(bool value) { }

	// RVA: 0x110D64C
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x110D654
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x110D65C
	public override bool get_IsMixed() { }

	// RVA: 0x110D668
	public override void set_IsMixed(bool value) { }

	// RVA: 0x110D688
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x110D690
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x110D698
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x110D6A0
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x110D6A8
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x110D730
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x110D738
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x110D740
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x110D748
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0x110D750
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x110D758
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x110D7E0
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x110D7E8
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x110D870
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x110D878
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x110D880
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x110D888
	internal void set_HasWildCard(bool value) { }

	// RVA: 0x110D89C
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x110D8A4
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x110DE0C
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1108D84
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x110E360
	private void ClearCompiledState() { }

	// RVA: 0x110B410
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x110E498
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x110E09C
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x110E714
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x110DE14
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x110B2A4
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContent
{
	// Methods

	// RVA: 0x110C9EC
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

	// RVA: 0x110C820
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

	// RVA: 0x110E740
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x110E748
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: 0x110E750
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

	// RVA: 0x110E758
	internal string get_TypeCodeString() { }

	// RVA: 0x110E884
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x110EFF0
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x10FD2BC
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x110F6D0
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x10FB87C
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x110F758
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x10F90E4
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x110F7C4
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

	// RVA: 0x110F7CC
	public void set_Source(string value) { }

	// RVA: 0x110F7D4
	public void set_Language(string value) { }

	// RVA: 0x110F8E0
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x110F8E8
	public void .ctor() { }

	// RVA: 0x110F8F0
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

	// RVA: 0x110F9E0
	public bool get_IsAbstract() { }

	// RVA: 0x110F9E8
	public void set_IsAbstract(bool value) { }

	// RVA: 0x110F9F8
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x110FA00
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x110FA08
	public string get_DefaultValue() { }

	// RVA: 0x110FA10
	public void set_DefaultValue(string value) { }

	// RVA: 0x110FA18
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x110FA20
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x110FA28
	public string get_FixedValue() { }

	// RVA: 0x110FA30
	public void set_FixedValue(string value) { }

	// RVA: 0x110FA38
	public XmlSchemaForm get_Form() { }

	// RVA: 0x110FA40
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x110FA48
	public string get_Name() { }

	// RVA: 0x110FA50
	public void set_Name(string value) { }

	// RVA: 0x110FA58
	public bool get_IsNillable() { }

	// RVA: 0x110FA60
	public void set_IsNillable(bool value) { }

	// RVA: 0x110FA70
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x110FA78
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x110FA80
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x110FA88
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x110FB60
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x110FB68
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x110FC40
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x110FC48
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x110FD20
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x110FD28
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x110FD30
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0x110FDB8
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x110FDC0
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x110FDC8
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x110FDD0
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x110FDD8
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x110FDE0
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x110FDE8
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x110FDF0
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x110FDF8
	internal bool get_HasConstraints() { }

	// RVA: 0x110FE20
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x110FE28
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x110FE30
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x110FE38
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x110FE40
	internal override string get_NameAttribute() { }

	// RVA: 0x110FE48
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x110FE50
	internal override string get_NameString() { }

	// RVA: 0x110FE74
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1109528
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x110FE7C
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

	// RVA: 0x110FF84
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1110408
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x111057C
	public void .ctor() { }

	// RVA: 0x1110590
	public void .ctor(string message) { }

	// RVA: 0x11106EC
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x11105A0
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x11107B4
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x110653C
	internal void .ctor(string res, string arg) { }

	// RVA: 0x10FF298
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x111084C
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x10FF0BC
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x11108F4
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x11109BC
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x1110900
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x11106F8
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x111033C
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x1110A60
	internal string get_GetRes() { }

	// RVA: 0x1110A68
	internal string[] get_Args() { }

	// RVA: 0x1110A70
	public string get_SourceUri() { }

	// RVA: 0x1110A78
	public int get_LineNumber() { }

	// RVA: 0x1110A80
	public int get_LinePosition() { }

	// RVA: 0x1110A88
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x11058D4
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1110A90
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x1110A98
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x1110AE0
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

	// RVA: 0x1110AF8
	public string get_SchemaLocation() { }

	// RVA: 0x1110B00
	public void set_SchemaLocation(string value) { }

	// RVA: 0x1110B08
	public XmlSchema get_Schema() { }

	// RVA: 0x1110B10
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x1110B18
	public string get_Id() { }

	// RVA: 0x1110B20
	public void set_Id(string value) { }

	// RVA: 0x1110B28
	internal Uri get_BaseUri() { }

	// RVA: 0x1110B30
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x1110B38
	internal override string get_IdAttribute() { }

	// RVA: 0x1110B40
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x1110B48
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1110B50
	internal Compositor get_Compositor() { }

	// RVA: 0x1110B58
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x1110B60
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

	// RVA: 0x1110B68
	public string get_Value() { }

	// RVA: 0x1110B70
	public void set_Value(string value) { }

	// RVA: 0x1110B78
	public virtual bool get_IsFixed() { }

	// RVA: 0x1110B80
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x1110C3C
	internal FacetType get_FacetType() { }

	// RVA: 0x1110C44
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x1110C4C
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaNumericFacet
{
	// Methods

	// RVA: 0x1110C54
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaLengthFacet
{
	// Methods

	// RVA: 0x1110C5C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinLengthFacet
{
	// Methods

	// RVA: 0x1110C88
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxLengthFacet
{
	// Methods

	// RVA: 0x1110CB4
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaPatternFacet
{
	// Methods

	// RVA: 0x1110CE0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaEnumerationFacet
{
	// Methods

	// RVA: 0x1110D0C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinExclusiveFacet
{
	// Methods

	// RVA: 0x1110D38
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMinInclusiveFacet
{
	// Methods

	// RVA: 0x1110D64
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxExclusiveFacet
{
	// Methods

	// RVA: 0x1110D90
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxInclusiveFacet
{
	// Methods

	// RVA: 0x1110DBC
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaTotalDigitsFacet
{
	// Methods

	// RVA: 0x1110DE8
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaFractionDigitsFacet
{
	// Methods

	// RVA: 0x1110E14
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaWhiteSpaceFacet
{
	// Methods

	// RVA: 0x1110E40
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

	// RVA: 0x1110E6C
	public string get_Name() { }

	// RVA: 0x1110E74
	public void set_Name(string value) { }

	// RVA: 0x1110E7C
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x1110E84
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x1110E8C
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1110E94
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x1110E9C
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x1110EA4
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x1110EAC
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1110EB4
	internal int get_SelfReferenceCount() { }

	// RVA: 0x1110EBC
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x1110EC4
	internal override string get_NameAttribute() { }

	// RVA: 0x1110ECC
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1110ED4
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1110EDC
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1109764
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1110EE4
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

	// RVA: 0x1109FC0
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

	// RVA: 0x1110F60
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x110E63C
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1110F68
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x1110F70
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x1110F78
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x1110F80
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1110F88
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

	// RVA: 0x1111040
	public string get_Name() { }

	// RVA: 0x1111048
	public void set_Name(string value) { }

	// RVA: 0x1111050
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x1111058
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x1111060
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x1111068
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1111070
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1111078
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x1111080
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x1111088
	internal override string get_NameAttribute() { }

	// RVA: 0x1111090
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1111098
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaXPath
{
	// Fields
	private string xpath; // 0x50

	// Methods

	// RVA: 0x111114C
	public string get_XPath() { }

	// RVA: 0x1111154
	public void set_XPath(string value) { }

	// RVA: 0x111115C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaUnique
{
	// Methods

	// RVA: 0x1111164
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaKey
{
	// Methods

	// RVA: 0x1111168
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaKeyref
{
	// Fields
	private XmlQualifiedName refer; // 0x78

	// Methods

	// RVA: 0x111116C
	public XmlQualifiedName get_Refer() { }

	// RVA: 0x1111174
	public void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x111124C
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaImport
{
	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Methods

	// RVA: 0x11112C4
	public void .ctor() { }

	// RVA: 0x11112F0
	public string get_Namespace() { }

	// RVA: 0x11112F8
	public void set_Namespace(string value) { }

	// RVA: 0x1111300
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaInclude
{
	// Fields
	private XmlSchemaAnnotation annotation; // 0x68

	// Methods

	// RVA: 0x1111308
	public void .ctor() { }

	// RVA: 0x1111334
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

	// RVA: 0x111133C
	public void .ctor() { }

	// RVA: 0x1111418
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x111148C
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0x1111494
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x111149C
	public bool get_IsDefault() { }

	// RVA: 0x11114A4
	public void set_IsDefault(bool value) { }

	// RVA: 0x11114AC
	public bool get_IsNil() { }

	// RVA: 0x11114B4
	public void set_IsNil(bool value) { }

	// RVA: 0x11114BC
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x11114C4
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x11114CC
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x11114D4
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x1111524
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x111152C
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x1111570
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1111578
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x11115BC
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x11115C4
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x11115E0
	internal bool get_HasDefaultValue() { }

	// RVA: 0x111161C
	internal bool get_IsUnionType() { }

	// RVA: 0x11113B0
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

	// RVA: 0x111165C
	public string get_Name() { }

	// RVA: 0x1111664
	public void set_Name(string value) { }

	// RVA: 0x111166C
	public string get_Public() { }

	// RVA: 0x1111674
	public void set_Public(string value) { }

	// RVA: 0x111167C
	public string get_System() { }

	// RVA: 0x1111684
	public void set_System(string value) { }

	// RVA: 0x111168C
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1111694
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x111169C
	internal override string get_NameAttribute() { }

	// RVA: 0x11116A4
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x11116AC
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

	// RVA: 0x1111728
	public int get_LineNumber() { }

	// RVA: 0x1111730
	public void set_LineNumber(int value) { }

	// RVA: 0x1111738
	public int get_LinePosition() { }

	// RVA: 0x1111740
	public void set_LinePosition(int value) { }

	// RVA: 0x1111748
	public string get_SourceUri() { }

	// RVA: 0x1111750
	public void set_SourceUri(string value) { }

	// RVA: 0x1111758
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x1111760
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x1108844
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x1111768
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x1111770
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x1111774
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x1111778
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x111177C
	internal virtual string get_IdAttribute() { }

	// RVA: 0x1111784
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x1111788
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x111178C
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x1111790
	internal virtual string get_NameAttribute() { }

	// RVA: 0x1111798
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x111179C
	internal bool get_IsProcessing() { }

	// RVA: 0x11117A4
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x11117AC
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x1107E44
	protected void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectCollection
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Methods

	// RVA: 0x1107E3C
	public void .ctor() { }

	// RVA: 0x1111830
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x1111950
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x1111A1C
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x1109980
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x1111A9C
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x1111B68
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x1111C2C
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x1111C48
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x1111CA8
	protected override void OnClear() { }

	// RVA: 0x1111CC4
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x110E40C
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x1111CE0
	private void Add(XmlSchemaObjectCollection collToAdd) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x1111D10
	internal void .ctor(IEnumerator enumerator) { }

	// RVA: 0x1111D44
	public bool MoveNext() { }

	// RVA: 0x1111DF8
	public XmlSchemaObject get_Current() { }

	// RVA: 0x1111EFC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1111FB4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1112068
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

	// RVA: 0x11122D4
	public void .ctor(XmlQualifiedName name, XmlSchemaObject value) { }

}

// Namespace: 
internal class ValuesCollection
{
	// Fields
	private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private int size; // 0x18

	// Methods

	// RVA: 0x1112AEC
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x1112C3C
	public int get_Count() { }

	// RVA: 0x1112C44
	public object get_SyncRoot() { }

	// RVA: 0x1112CFC
	public bool get_IsSynchronized() { }

	// RVA: 0x1112DB4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1112F04
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

	// RVA: 0x1112F90
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

	// RVA: 0x1112FE4
	public object get_Current() { }

	// RVA: 0x11131BC
	public bool MoveNext() { }

	// RVA: 0x11132AC
	public void Reset() { }

}

// Namespace: 
internal class XSODictionaryEnumerator
{
	// Methods

	// RVA: 0x1112BE8
	internal void .ctor(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType) { }

	// RVA: 0x11132E8
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1113430
	public object get_Key() { }

	// RVA: 0x111355C
	public object get_Value() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectTable
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName,System.Xml.Schema.XmlSchemaObject> table; // 0x10
	private System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Methods

	// RVA: 0x1112120
	internal void .ctor() { }

	// RVA: 0x1112200
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1112308
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1112564
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x11126FC
	internal void Clear() { }

	// RVA: 0x11127C0
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x11124B4
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x1112908
	public int get_Count() { }

	// RVA: 0x111295C
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x11129C0
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x1112A44
	public ICollection get_Values() { }

	// RVA: 0x1112B34
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

	// RVA: 0x11143A0
	internal override bool get_IsEmpty() { }

	// RVA: 0x11142B8
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

	// RVA: 0x1113688
	public string get_MinOccursString() { }

	// RVA: 0x1113724
	public void set_MinOccursString(string value) { }

	// RVA: 0x111388C
	public string get_MaxOccursString() { }

	// RVA: 0x11139D8
	public void set_MaxOccursString(string value) { }

	// RVA: 0x1113C04
	public Decimal get_MinOccurs() { }

	// RVA: 0x1113C10
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0x1113D48
	public Decimal get_MaxOccurs() { }

	// RVA: 0x1113D54
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x1113ECC
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x1113F44
	internal virtual string get_NameString() { }

	// RVA: 0x1113F5C
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x11140F8
	protected void .ctor() { }

	// RVA: 0x1114178
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

	// RVA: 0x11143A8
	public void .ctor() { }

	// RVA: 0x11144A0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x11144A8
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x11144B0
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x11144B8
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x11144C0
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSequence
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Methods

	// RVA: 0x11144E0
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x11144E8
	internal override bool get_IsEmpty() { }

	// RVA: 0x1114598
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x11145A0
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

	// RVA: 0x1114618
	internal object get_InternalSyncObject() { }

	// RVA: 0x11146A0
	public void .ctor() { }

	// RVA: 0x1114708
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1114A0C
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1114B34
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1114C10
	public bool get_IsCompiled() { }

	// RVA: 0x1114C18
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1114C38
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x1114C40
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x1114C48
	public int get_Count() { }

	// RVA: 0x1114C70
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x1114CF4
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x1114D78
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x1114DFC
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x1114E80
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x1114E88
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x1114F0C
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x11178B4
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x1117AF0
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x1118AE4
	public bool Contains(string targetNamespace) { }

	// RVA: 0x1118B30
	public void Compile() { }

	// RVA: 0x11192F0
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x111B11C
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x111B298
	public ICollection Schemas() { }

	// RVA: 0x111ADA0
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x1117844
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x111B6E8
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x11175D4
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x111B2C0
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x111C038
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x111C568
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x1118704
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x11190F0
	private void ClearTables() { }

	// RVA: 0x111AFF0
	internal bool PreprocessSchema(XmlSchema schema, string targetNamespace) { }

	// RVA: 0x111BE28
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x1115910
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x111CFB4
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x111CFBC
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x111CFC4
	internal XmlResolver GetResolver() { }

	// RVA: 0x111CFE4
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x111CD88
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x111BAB0
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, XmlSchema schema) { }

	// RVA: 0x111CFEC
	internal bool GetSchemaByUri(Uri schemaUri, XmlSchema schema) { }

	// RVA: 0x111861C
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x111D184
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x111A770
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x1119BC8
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x111C9E8
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x111CE48
	private void VerifyTables() { }

	// RVA: 0x111D18C
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x1118658
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContent
{
	// Fields
	private XmlSchemaContent content; // 0x50

	// Methods

	// RVA: 0x111D1DC
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x111D1E4
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x111D1EC
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

	// RVA: 0x111D1F4
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x111D1FC
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x111D2D4
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x111D2DC
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x111D2E4
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x111D2EC
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x111D2F4
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

	// RVA: 0x111D3A8
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x111D3B0
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x111D488
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x111D490
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x111D498
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x111D4A0
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x111D4A8
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x111D4B0
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x111D4B8
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x111D4C0
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleType
{
	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Methods

	// RVA: 0x111D598
	public void .ctor() { }

	// RVA: 0x111D6B0
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x111D6B8
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0x111D6C0
	internal override XmlSchemaObject Clone() { }

}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaSimpleTypeContent
{
	// Methods

	// RVA: 0x111D7D0
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

	// RVA: 0x111D7D8
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0x111D7E0
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x111D8B8
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x111D8C0
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x111D8C8
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x111D8D0
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x111D8D8
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x111D99C
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

	// RVA: 0x111DA18
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x111DA20
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x111DAF8
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x111DB00
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x111DB08
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x111DB10
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x111DBD4
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

	// RVA: 0x111DC88
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x111DC90
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x111DC98
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x111DCA0
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x111DCA8
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0x111DCB0
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x111DE74
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroup
{
	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Methods

	// RVA: 0x111DEEC
	internal ArrayList get_Members() { }

	// RVA: 0x111DEF4
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x111DEFC
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0x111DF04
	public void .ctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroupV1Compat
{
	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Methods

	// RVA: 0x111DFB8
	internal XmlSchemaChoice get_Choice() { }

	// RVA: 0x111DFC0
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

	// RVA: 0x111E034
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x111E150
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0x111E1D8
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x111E4D8
	public string get_Name() { }

	// RVA: 0x111E4E0
	public void set_Name(string value) { }

	// RVA: 0x111E4E8
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x111E4F0
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x111CF90
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x111E4F8
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x111E500
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x111E508
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x111E510
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x111E518
	public virtual bool get_IsMixed() { }

	// RVA: 0x111E520
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0x111E524
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0x111E61C
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0x111E6AC
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0x111E6B4
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x111E6E4
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x111E6EC
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x111E6F4
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x111E6FC
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0x111E704
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x111E728
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x111E758
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x111E760
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0x111E768
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0x111E770
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x111E9E8
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x111EAF4
	internal override string get_NameAttribute() { }

	// RVA: 0x111EAFC
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x111D624
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

	// RVA: 0x111EB04
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x111EB0C
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x111EB14
	public void .ctor() { }

	// RVA: 0x111EB20
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x111EBF4
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x111EC28
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Schema
public sealed class XmlValueGetter
{
	// Methods

	// RVA: 0x111EC4C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x111ECEC
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

	// RVA: 0x111ED00
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

	// RVA: 0x111ED64
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0x111EF98
	private void Init() { }

	// RVA: 0x111F4CC
	private void Reset() { }

	// RVA: 0x111F658
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x111F660
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0x111F678
	public void set_SourceUri(Uri value) { }

	// RVA: 0x111F6C8
	public void set_ValidationEventSender(object value) { }

	// RVA: 0x111F6D0
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x111F784
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x111F838
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0x112003C
	public void Initialize() { }

	// RVA: 0x1120180
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0x1120438
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x112213C
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x11221A0
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1123698
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1123A00
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0x1123A64
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x1124434
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0x1124498
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x1124700
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1124C08
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1124F90
	public void EndValidation() { }

	// RVA: 0x112520C
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x1125DE8
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x1125DF0
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x1125DF8
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0x1125E34
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0x1125E64
	private bool get_StrictlyAssessed() { }

	// RVA: 0x1125EB0
	private bool get_HasSchema() { }

	// RVA: 0x1125F04
	internal string GetConcatenatedValue() { }

	// RVA: 0x1124708
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0x1121238
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x1120AC0
	private object ValidateElementContext(XmlQualifiedName elementName, bool invalidElementInContext) { }

	// RVA: 0x1127D24
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0x1125F28
	private object ValidateAtomicValue(string stringValue, XmlSchemaSimpleType memberType) { }

	// RVA: 0x1126214
	private object ValidateAtomicValue(object parsedValue, XmlSchemaSimpleType memberType) { }

	// RVA: 0x1128DA4
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0x1123EAC
	private void SaveTextValue(object value) { }

	// RVA: 0x111F35C
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1124E1C
	private void Pop() { }

	// RVA: 0x1120FBC
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0x1121584
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, bool declFound) { }

	// RVA: 0x1121C5C
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0x1121E84
	private void CheckElementProperties() { }

	// RVA: 0x1121F8C
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x1122D5C
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0x1129680
	private void AddXmlNamespaceSchema() { }

	// RVA: 0x11265D4
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0x112780C
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x111F578
	internal void RecompileSchemaSet() { }

	// RVA: 0x112993C
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0x1122FE4
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0x1128AD4
	private object CheckElementValue(string stringValue) { }

	// RVA: 0x112323C
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0x1129C34
	private object FindId(string name) { }

	// RVA: 0x1125080
	private void CheckForwardRefs() { }

	// RVA: 0x11233C0
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x1128E28
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0x1129F2C
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0x111F648
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0x112082C
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0x1120A68
	private void ClearPSVI() { }

	// RVA: 0x1123780
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0x1121FF8
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0x112590C
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0x1128E34
	private void AddIdentityConstraints() { }

	// RVA: 0x1129294
	private void ElementIdentityConstraints() { }

	// RVA: 0x11233E0
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0x1126C24
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0x112818C
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x11266DC
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x1124050
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0x112A52C
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0x112A004
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0x112A6B4
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0x1123E28
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0x1127F04
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0x1123EF4
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0x1129C50
	private void ProcessEntity(string name) { }

	// RVA: 0x1128E10
	private void SendValidationEvent(string code) { }

	// RVA: 0x1122E40
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x1122B50
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0x1127F80
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0x1129758
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0x111FE8C
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0x1129F38
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0x1127C6C
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x111FC4C
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x1129DF0
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x1129F40
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x112A8F8
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

	// RVA: 0x112AD78
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

	// RVA: 0x112AD80
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x112AF94
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x112B084
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x112B100
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x112B160
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x112B254
	public override bool ToBoolean(Double value) { }

	// RVA: 0x112B334
	public override bool ToBoolean(int value) { }

	// RVA: 0x112B40C
	public override bool ToBoolean(Int64 value) { }

	// RVA: 0x112B4E4
	public override bool ToBoolean(string value) { }

	// RVA: 0x112B5A0
	public override bool ToBoolean(object value) { }

	// RVA: 0x112B65C
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x112B748
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x112B84C
	public override DateTime ToDateTime(Double value) { }

	// RVA: 0x112B940
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x112BA2C
	public override DateTime ToDateTime(Int64 value) { }

	// RVA: 0x112BB18
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x112BBE0
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x112BCA8
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x112BDAC
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x112BE78
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x112BF44
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x112C010
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x112C0DC
	public override Double ToDouble(bool value) { }

	// RVA: 0x112C1B4
	public override Double ToDouble(DateTime value) { }

	// RVA: 0x112C2A8
	public override Double ToDouble(int value) { }

	// RVA: 0x112C380
	public override Double ToDouble(Int64 value) { }

	// RVA: 0x112C458
	public override Double ToDouble(string value) { }

	// RVA: 0x112C514
	public override Double ToDouble(object value) { }

	// RVA: 0x112C5D0
	public override int ToInt32(bool value) { }

	// RVA: 0x112C6A8
	public override int ToInt32(DateTime value) { }

	// RVA: 0x112C79C
	public override int ToInt32(Double value) { }

	// RVA: 0x112C87C
	public override int ToInt32(Int64 value) { }

	// RVA: 0x112C954
	public override int ToInt32(string value) { }

	// RVA: 0x112CA10
	public override int ToInt32(object value) { }

	// RVA: 0x112CACC
	public override Int64 ToInt64(bool value) { }

	// RVA: 0x112CBA4
	public override Int64 ToInt64(DateTime value) { }

	// RVA: 0x112CC98
	public override Int64 ToInt64(Double value) { }

	// RVA: 0x112CD78
	public override Int64 ToInt64(int value) { }

	// RVA: 0x112CE50
	public override Int64 ToInt64(string value) { }

	// RVA: 0x112CF0C
	public override Int64 ToInt64(object value) { }

	// RVA: 0x112CFC8
	public override float ToSingle(Double value) { }

	// RVA: 0x112D0A8
	public override float ToSingle(string value) { }

	// RVA: 0x112D164
	public override float ToSingle(object value) { }

	// RVA: 0x112D220
	public override string ToString(bool value) { }

	// RVA: 0x112D2E4
	public override string ToString(DateTime value) { }

	// RVA: 0x112D3C4
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x112D4A8
	public override string ToString(Decimal value) { }

	// RVA: 0x112D5B8
	public override string ToString(Double value) { }

	// RVA: 0x112D684
	public override string ToString(int value) { }

	// RVA: 0x112D748
	public override string ToString(Int64 value) { }

	// RVA: 0x112D80C
	public override string ToString(float value) { }

	// RVA: 0x112D8D8
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x112D98C
	public override string ToString(object value) { }

	// RVA: 0x112D9A0
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x112DA00
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x112DA94
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x112DB58
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x112DBB8
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x112DC18
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x112DC78
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x112DC88
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x112DC9C
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x112DCA4
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x112DCAC
	protected string get_XmlTypeName() { }

	// RVA: 0x112DF18
	protected Type get_DefaultClrType() { }

	// RVA: 0x112DF20
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x112DFD0
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x112DDE4
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x112E260
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x112E2BC
	protected static Byte[] StringToBase64Binary(string value) { }

	// RVA: 0x112E36C
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x112E3F4
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x112E47C
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x112E4D4
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x112E52C
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x112E5B4
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x112E63C
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x112E6C4
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x112E74C
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x112E7D4
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x112E85C
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x112E8E4
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x112E96C
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x112E9F4
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x112EA7C
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x112EB04
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x112EB8C
	protected static Byte[] StringToHexBinary(string value) { }

	// RVA: 0x112ECD0
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x112EFB0
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x112F038
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x112F0C0
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x112F118
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x112F130
	protected static string Base64BinaryToString(Byte[] value) { }

	// RVA: 0x112F1B8
	protected static string DateToString(DateTime value) { }

	// RVA: 0x112F248
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x112F2D8
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x112F330
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x112F388
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x112F418
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x112F4A8
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x112F538
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x112F5C8
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x112F658
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x112F6F0
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x112F788
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x112F820
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x112F8B8
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x112F950
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x112F9E8
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x112FA80
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x112FCB8
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x112FD48
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x112FDE0
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x112FE38
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x112FEA0
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x1130088
	protected static Int64 DecimalToInt64(Decimal value) { }

	// RVA: 0x1130270
	protected static UInt64 DecimalToUInt64(Decimal value) { }

	// RVA: 0x113044C
	protected static Byte Int32ToByte(int value) { }

	// RVA: 0x1130538
	protected static Int16 Int32ToInt16(int value) { }

	// RVA: 0x1130624
	protected static SByte Int32ToSByte(int value) { }

	// RVA: 0x1130710
	protected static UInt16 Int32ToUInt16(int value) { }

	// RVA: 0x11307FC
	protected static int Int64ToInt32(Int64 value) { }

	// RVA: 0x11308E4
	protected static UInt32 Int64ToUInt32(Int64 value) { }

	// RVA: 0x11309CC
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x1130A54
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x1130ADC
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric10Converter
{
	// Methods

	// RVA: 0x1131070
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x11310DC
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1131180
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1131290
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1131B90
	public override int ToInt32(Int64 value) { }

	// RVA: 0x1131C18
	public override int ToInt32(string value) { }

	// RVA: 0x1131D4C
	public override int ToInt32(object value) { }

	// RVA: 0x1132174
	public override Int64 ToInt64(int value) { }

	// RVA: 0x113217C
	public override Int64 ToInt64(string value) { }

	// RVA: 0x11322B0
	public override Int64 ToInt64(object value) { }

	// RVA: 0x11326D8
	public override string ToString(Decimal value) { }

	// RVA: 0x11327B4
	public override string ToString(int value) { }

	// RVA: 0x113283C
	public override string ToString(Int64 value) { }

	// RVA: 0x11328C4
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1132D34
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1133748
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1133C94
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x11341E4
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1134714
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11316F8
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1133298
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlNumeric2Converter
{
	// Methods

	// RVA: 0x1135968
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x11359D4
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1135A78
	public override Double ToDouble(string value) { }

	// RVA: 0x1135B78
	public override Double ToDouble(object value) { }

	// RVA: 0x1135EFC
	public override float ToSingle(Double value) { }

	// RVA: 0x1135F04
	public override float ToSingle(string value) { }

	// RVA: 0x1136004
	public override float ToSingle(object value) { }

	// RVA: 0x1136374
	public override string ToString(Double value) { }

	// RVA: 0x1136470
	public override string ToString(float value) { }

	// RVA: 0x1136524
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11368B4
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x1136D04
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1137160
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlDateTimeConverter
{
	// Methods

	// RVA: 0x1137A20
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1137A8C
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1137B30
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1137B9C
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1137E88
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1138248
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1138274
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1138560
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x113895C
	public override string ToString(DateTime value) { }

	// RVA: 0x1138BFC
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1138E00
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11391B8
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x113963C
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1139AB8
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlBooleanConverter
{
	// Methods

	// RVA: 0x113A3D4
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x113A440
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x113A4E4
	public override bool ToBoolean(string value) { }

	// RVA: 0x113A5A0
	public override bool ToBoolean(object value) { }

	// RVA: 0x113A8A0
	public override string ToString(bool value) { }

	// RVA: 0x113A928
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x113AC1C
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x113B000
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x113B3E4
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlMiscConverter
{
	// Methods

	// RVA: 0x113BAEC
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x113BB58
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x113BBFC
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x113C31C
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x113CAB8
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x113C1D8
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x113C94C
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

// Namespace: System.Xml.Schema
internal class XmlStringConverter
{
	// Methods

	// RVA: 0x113DB14
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x113DB80
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x113DC24
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x113DE4C
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x113E174
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

	// RVA: 0x113E6B8
	protected void .ctor() { }

	// RVA: 0x113E828
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0x113E9B4
	public override bool ToBoolean(string value) { }

	// RVA: 0x113EA70
	public override bool ToBoolean(object value) { }

	// RVA: 0x113ED6C
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x113EE28
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x113EFC8
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x113F084
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x113F230
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x113F2EC
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x113F4C4
	public override Double ToDouble(string value) { }

	// RVA: 0x113F580
	public override Double ToDouble(object value) { }

	// RVA: 0x113F738
	public override int ToInt32(string value) { }

	// RVA: 0x113F7F4
	public override int ToInt32(object value) { }

	// RVA: 0x113F9AC
	public override Int64 ToInt64(string value) { }

	// RVA: 0x113FA68
	public override Int64 ToInt64(object value) { }

	// RVA: 0x113FC20
	public override float ToSingle(string value) { }

	// RVA: 0x113FCDC
	public override float ToSingle(object value) { }

	// RVA: 0x113FE94
	public override string ToString(bool value) { }

	// RVA: 0x113FF1C
	public override string ToString(DateTime value) { }

	// RVA: 0x113FFA4
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1140010
	public override string ToString(Decimal value) { }

	// RVA: 0x114007C
	public override string ToString(Double value) { }

	// RVA: 0x1140104
	public override string ToString(int value) { }

	// RVA: 0x114018C
	public override string ToString(Int64 value) { }

	// RVA: 0x1140214
	public override string ToString(float value) { }

	// RVA: 0x114029C
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1141074
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1141460
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x11416A8
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x114195C
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x1141BB0
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1141DF8
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x1142040
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1142F04
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x113EC28
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11412BC
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1144B54
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1144E84
	private bool SupportsType(Type clrType) { }

	// RVA: 0x11465E8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyConverter
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x11466AC
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1146718
	public override bool ToBoolean(object value) { }

	// RVA: 0x1146A0C
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1146BD0
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1146D94
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1146F58
	public override Double ToDouble(object value) { }

	// RVA: 0x1147108
	public override int ToInt32(object value) { }

	// RVA: 0x11472B8
	public override Int64 ToInt64(object value) { }

	// RVA: 0x1147468
	public override float ToSingle(object value) { }

	// RVA: 0x1147618
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x11479D4
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1147C38
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1147EF0
	public override object ChangeType(Double value, Type destinationType) { }

	// RVA: 0x1148148
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1148398
	public override object ChangeType(Int64 value, Type destinationType) { }

	// RVA: 0x11485E8
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1148834
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x11468C8
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1147868
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x114A244
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x114A2D8
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlAnyListConverter
{
	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x114A3F0
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x114A4E8
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x114A78C
	private static void .cctor() { }

}

// Namespace: System.Xml.Schema
internal class XmlListConverter
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x114A46C
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x113E928
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x113E7BC
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x114A97C
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x114ABFC
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1145638
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x114ACE0
	private bool IsListType(Type type) { }

	// RVA: 0x3525998
	private T[] ToArray(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x114B5CC
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x114B51C
	private System.Collections.Generic.List<System.String> StringAsList(string value) { }

	// RVA: 0x114B188
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x114AEF0
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

	// RVA: 0x114BBE0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x114BE64
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x114BEC8
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

	// RVA: 0x1158D50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1158E0C
	public virtual void Invoke(XsdBuilder builder, string value) { }

}

// Namespace: 
private sealed class XsdInitFunction
{
	// Methods

	// RVA: 0x1158E20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1158EDC
	public virtual void Invoke(XsdBuilder builder, string value) { }

}

// Namespace: 
private sealed class XsdEndChildFunction
{
	// Methods

	// RVA: 0x1158EF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1158FA4
	public virtual void Invoke(XsdBuilder builder) { }

}

// Namespace: 
private sealed class XsdAttributeEntry
{
	// Fields
	public Token Attribute; // 0x10
	public XsdBuildFunction BuildFunc; // 0x18

	// Methods

	// RVA: 0x1158FB8
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

	// RVA: 0x1158FFC
	public void .ctor(Token n, State state, State[] nextStates, XsdAttributeEntry[] attributes, XsdInitFunction init, XsdEndChildFunction end, bool parseContent) { }

}

// Namespace: 
private class BuilderNamespaceManager
{
	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x115909C
	public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x11590EC
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

	// RVA: 0x114C368
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x114C5C8
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x114CDA8
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x114D2F8
	internal override bool IsContentParsed() { }

	// RVA: 0x114D318
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x114D328
	internal override void ProcessCData(string value) { }

	// RVA: 0x114D384
	internal override void StartChildren() { }

	// RVA: 0x114D52C
	internal override void EndChildren() { }

	// RVA: 0x114C884
	private void Push() { }

	// RVA: 0x114D574
	private void Pop() { }

	// RVA: 0x114E7F4
	private Token get_CurrentElement() { }

	// RVA: 0x114E814
	private Token get_ParentElement() { }

	// RVA: 0x114E890
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0x114D668
	private XmlSchemaObject GetContainer(State state) { }

	// RVA: 0x114D820
	private void SetContainer(State state, object container) { }

	// RVA: 0x114E924
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0x114E94C
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x114EAE0
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x114EB8C
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0x114EBB0
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0x114EBD4
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0x114EECC
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0x114EF40
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0x114EF68
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0x114F038
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x114F05C
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0x114F12C
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x114F150
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x114F174
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0x114F244
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x114F268
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0x114F288
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x114F654
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0x114F678
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x114F69C
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0x114F748
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0x114F7F4
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x114F9F8
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0x114FA1C
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0x114FA98
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0x114FC0C
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x114FDB0
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0x114FE24
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0x114FE48
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0x114FEF4
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0x114FF70
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0x114FFE4
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1150008
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x11500F4
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x11501E0
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1150204
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0x1150280
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x11502FC
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0x1150378
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0x1150718
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x115073C
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x11507B0
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0x1150880
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0x1150A80
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0x1150B50
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0x1150BCC
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1150C9C
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1150D18
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0x1150F04
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x1150F80
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0x1150FF4
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1151068
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x11510EC
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1151110
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0x1151224
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x11512A0
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x1151398
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1151414
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x11514B8
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1151534
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0x1151648
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x1151740
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x11517BC
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x11518B4
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1151930
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1151A68
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1151A8C
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x1151B1C
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1151B98
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x1151EB0
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1151ED4
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x1151F80
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0x11520BC
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x11520E0
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x1152560
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1152580
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x11525A0
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x115261C
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0x11526BC
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0x115275C
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0x11527FC
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0x11528A0
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x11528C4
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x1152970
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0x1152A18
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1152A3C
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0x1152A60
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0x1152A84
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0x1152DF0
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1152E74
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0x1152E98
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0x1152FF0
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1153014
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0x1153138
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0x1153214
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x1153238
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0x1153314
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x1153338
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0x1153520
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0x11535F4
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0x1153674
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0x11536A0
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0x1153774
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0x11537F0
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0x1153938
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0x114F3B8
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0x1152184
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0x114C710
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x114CC94
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x1150114
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x1150028
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x114FC88
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0x114E9F8
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0x114F870
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0x114EC48
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x1153670
	private static string ParseUriReference(string s) { }

	// RVA: 0x1153964
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0x114CCC0
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x114D20C
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1153AD8
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1150A78
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x114CB54
	private void RecordPosition() { }

	// RVA: 0x1153BB8
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

	// RVA: 0x11593BC
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x115D58C
	private bool ParseDate(int start) { }

	// RVA: 0x115D960
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x115DD4C
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x115DFD0
	private bool ParseTime(int start) { }

	// RVA: 0x115DA48
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x115DE04
	private bool Parse4Dig(int start, int num) { }

	// RVA: 0x115DF20
	private bool Parse2Dig(int start, int num) { }

	// RVA: 0x115D90C
	private bool ParseChar(int start, Char ch) { }

	// RVA: 0x115D580
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x115E4E4
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

	// RVA: 0x1159150
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x115A764
	private void .ctor(Parser parser) { }

	// RVA: 0x115A69C
	private void InitiateXsdDateTime(Parser parser) { }

	// RVA: 0x115A8C4
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, XsdDateTime result) { }

	// RVA: 0x115A9C0
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x115ABAC
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x115AC28
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x115ADBC
	private DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x115ADC4
	private XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x115ADCC
	public int get_Year() { }

	// RVA: 0x115AE54
	public int get_Month() { }

	// RVA: 0x115AEDC
	public int get_Day() { }

	// RVA: 0x115AF64
	public int get_Hour() { }

	// RVA: 0x115AFEC
	public int get_Minute() { }

	// RVA: 0x115B074
	public int get_Second() { }

	// RVA: 0x115B0FC
	public int get_Fraction() { }

	// RVA: 0x115B21C
	public int get_ZoneHour() { }

	// RVA: 0x115B224
	public int get_ZoneMinute() { }

	// RVA: 0x115B22C
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x115B930
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x115BE10
	public override string ToString() { }

	// RVA: 0x115C718
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x115CA9C
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x115CF94
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x115CEBC
	private void IntToCharArray(Char[] text, int start, int value, int digits) { }

	// RVA: 0x115CF28
	private void ShortToCharArray(Char[] text, int start, int value) { }

	// RVA: 0x115D1C0
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

	// RVA: 0x115E588
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x115E6F0
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x115E820
	public void .ctor(TimeSpan timeSpan, DurationType durationType) { }

	// RVA: 0x115EA28
	public void .ctor(string s) { }

	// RVA: 0x115EAA4
	public void .ctor(string s, DurationType durationType) { }

	// RVA: 0x115F260
	public bool get_IsNegative() { }

	// RVA: 0x115F26C
	public int get_Years() { }

	// RVA: 0x115F274
	public int get_Months() { }

	// RVA: 0x115F27C
	public int get_Days() { }

	// RVA: 0x115F284
	public int get_Hours() { }

	// RVA: 0x115F28C
	public int get_Minutes() { }

	// RVA: 0x115F294
	public int get_Seconds() { }

	// RVA: 0x115F254
	public int get_Nanoseconds() { }

	// RVA: 0x115F29C
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x115F2F4
	public TimeSpan ToTimeSpan(DurationType durationType) { }

	// RVA: 0x115F860
	internal Exception TryToTimeSpan(TimeSpan result) { }

	// RVA: 0x115F348
	internal Exception TryToTimeSpan(DurationType durationType, TimeSpan result) { }

	// RVA: 0x115F86C
	public override string ToString() { }

	// RVA: 0x115F874
	internal string ToString(DurationType durationType) { }

	// RVA: 0x115FCAC
	internal static Exception TryParse(string s, XsdDuration result) { }

	// RVA: 0x115EB24
	internal static Exception TryParse(string s, DurationType durationType, XsdDuration result) { }

	// RVA: 0x115FCB8
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

	// RVA: 0x115FE60
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1160284
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x115FE90
	private void Init() { }

	// RVA: 0x116040C
	public override void Validate() { }

	// RVA: 0x1160B00
	public override void CompleteValidation() { }

	// RVA: 0x11604E0
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x11604F0
	private void ProcessInlineSchema() { }

	// RVA: 0x1160794
	private void ValidateElement() { }

	// RVA: 0x1160C30
	private object ValidateChildElement() { }

	// RVA: 0x1160E68
	private void ProcessElement(object particle) { }

	// RVA: 0x11612C4
	private void ProcessXsiAttributes(XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x1160920
	private void ValidateEndElement() { }

	// RVA: 0x11611C4
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x1161AC0
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x1161F38
	private void ValidateStartElement() { }

	// RVA: 0x1162678
	private void ValidateEndStartElement() { }

	// RVA: 0x1164258
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x1162AF4
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x1161EB4
	private bool get_HasSchema() { }

	// RVA: 0x11647D4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1164810
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1162CB8
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1164A8C
	internal void AddID(string name, object node) { }

	// RVA: 0x1164B2C
	public override object FindId(string name) { }

	// RVA: 0x1160E1C
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x11602B4
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1163E04
	private void Pop() { }

	// RVA: 0x1160B04
	private void CheckForwardRefs() { }

	// RVA: 0x1161EDC
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x1163198
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x1164B48
	private void AddIdentityConstraints() { }

	// RVA: 0x1164F54
	private void ElementIdentityConstraints() { }

	// RVA: 0x1163F88
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x1163EFC
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x11631A8
	private void EndElementIdentityConstraints() { }

	// RVA: 0x11652A4
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AbsoluteQuery
{
	// Methods

	// RVA: 0x1165364
	public void .ctor() { }

	// RVA: 0x11653B4
	private void .ctor(AbsoluteQuery other) { }

	// RVA: 0x116542C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x11654AC
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

	// RVA: 0x116552C
	protected void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class AttributeQuery
{
	// Fields
	private bool _onAttribute; // 0x54

	// Methods

	// RVA: 0x1165534
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x11655FC
	private void .ctor(AttributeQuery other) { }

	// RVA: 0x11656D0
	public override void Reset() { }

	// RVA: 0x116575C
	public override XPathNavigator Advance() { }

	// RVA: 0x1165854
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

	// RVA: 0x11658C8
	public void .ctor(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x1165968
	public void .ctor(AxisType axisType, AstNode input) { }

	// RVA: 0x1165A04
	public override AstType get_Type() { }

	// RVA: 0x1165A0C
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1165A14
	public AstNode get_Input() { }

	// RVA: 0x1165A1C
	public void set_Input(AstNode value) { }

	// RVA: 0x1165A24
	public string get_Prefix() { }

	// RVA: 0x1165A2C
	public string get_Name() { }

	// RVA: 0x1165A34
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1165A3C
	public AxisType get_TypeOfAxis() { }

	// RVA: 0x1165A44
	public bool get_AbbrAxis() { }

	// RVA: 0x1165A4C
	public string get_Urn() { }

	// RVA: 0x1165A54
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

	// RVA: 0x1165A5C
	protected void .ctor(Query qyInput) { }

	// RVA: 0x1165538
	protected void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1165630
	protected void .ctor(BaseAxisQuery other) { }

	// RVA: 0x1165718
	public override void Reset() { }

	// RVA: 0x1165AE8
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1165B50
	protected string get_Name() { }

	// RVA: 0x1165B58
	protected string get_Namespace() { }

	// RVA: 0x1165B60
	protected bool get_NameTest() { }

	// RVA: 0x1165B68
	protected XPathNodeType get_TypeTest() { }

	// RVA: 0x1165B70
	public override int get_CurrentPosition() { }

	// RVA: 0x1165B78
	public override XPathNavigator get_Current() { }

	// RVA: 0x1165B80
	public virtual bool matches(XPathNavigator e) { }

	// RVA: 0x1165CAC
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1165D08
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

	// RVA: 0x1165D10
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x1165E9C
	private void .ctor(BooleanExpr other) { }

	// RVA: 0x1165F0C
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1165F60
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1166018
	public override XPathNodeIterator Clone() { }

	// RVA: 0x11660C8
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class BooleanFunctions
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _funcType; // 0x20

	// Methods

	// RVA: 0x1165E54
	public void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0x11660D0
	private void .ctor(BooleanFunctions other) { }

	// RVA: 0x1166124
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1166140
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1166558
	internal static bool toBoolean(Double number) { }

	// RVA: 0x1166578
	internal static bool toBoolean(string str) { }

	// RVA: 0x11662BC
	internal bool toBoolean(XPathNodeIterator nodeIterator) { }

	// RVA: 0x116659C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x116642C
	private bool Not(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1166490
	private bool Lang(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11665A4
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheAxisQuery
{
	// Fields
	protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer; // 0x58

	// Methods

	// RVA: 0x1166638
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x11666F8
	protected void .ctor(CacheAxisQuery other) { }

	// RVA: 0x11667AC
	public override void Reset() { }

	// RVA: 0x11667B4
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x11668A8
	public override XPathNavigator Advance() { }

	// RVA: 0x1166948
	public override XPathNavigator get_Current() { }

	// RVA: 0x11669D0
	public override int get_CurrentPosition() { }

	// RVA: 0x11669D8
	public override int get_Count() { }

	// RVA: 0x1166A24
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

	// RVA: 0x1166A2C
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x1166C3C
	private void .ctor(CacheChildrenQuery other) { }

	// RVA: 0x1166DC0
	public override void Reset() { }

	// RVA: 0x1166F94
	public override XPathNavigator Advance() { }

	// RVA: 0x1167220
	private bool DecideNextNode() { }

	// RVA: 0x11671A0
	private XPathNavigator GetNextInput() { }

	// RVA: 0x11673B8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class CacheOutputQuery
{
	// Fields
	internal Query input; // 0x18
	protected System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> outputBuffer; // 0x20

	// Methods

	// RVA: 0x116741C
	public void .ctor(Query input) { }

	// RVA: 0x11674CC
	protected void .ctor(CacheOutputQuery other) { }

	// RVA: 0x11675A0
	public override void Reset() { }

	// RVA: 0x11675A8
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x11675D0
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1167694
	public override XPathNavigator Advance() { }

	// RVA: 0x1167734
	public override XPathNavigator get_Current() { }

	// RVA: 0x11677BC
	public override XPathResultType get_StaticType() { }

	// RVA: 0x11677C4
	public override int get_CurrentPosition() { }

	// RVA: 0x11677CC
	public override int get_Count() { }

	// RVA: 0x1167818
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ChildrenQuery
{
	// Fields
	private XPathNodeIterator _iterator; // 0x58

	// Methods

	// RVA: 0x1166B94
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x1166D18
	protected void .ctor(ChildrenQuery other) { }

	// RVA: 0x1166EF8
	public override void Reset() { }

	// RVA: 0x1167820
	public override XPathNavigator Advance() { }

	// RVA: 0x11679E8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ClonableStack<T0>
{
	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35267E8
	private void .ctor(System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0x26AD93C
	public void Push(T value) { }

	// RVA: 0x26AD93C
	public T Pop() { }

	// RVA: 0x26AD93C
	public T Peek() { }

	// RVA: 0x3525804
	public MS.Internal.Xml.XPath.ClonableStack<T> Clone() { }

}

// Namespace: 
private class UndefinedXsltContext
{
	// Fields
	private IXmlNamespaceResolver _nsResolver; // 0x50

	// Methods

	// RVA: 0x1167C38
	public void .ctor(IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1167C70
	public override string get_DefaultNamespace() { }

	// RVA: 0x1167C88
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1167DBC
	public override IXsltContextVariable ResolveVariable(string prefix, string name) { }

	// RVA: 0x1167DF8
	public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) { }

	// RVA: 0x1167E34
	public override bool get_Whitespace() { }

	// RVA: 0x1167E3C
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

	// RVA: 0x1167A4C
	internal void .ctor(Query query, string expression, bool needContext) { }

	// RVA: 0x1167AA8
	internal Query get_QueryTree() { }

	// RVA: 0x1167AFC
	public override void SetContext(IXmlNamespaceResolver nsResolver) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ContextQuery
{
	// Fields
	protected XPathNavigator contextNode; // 0x18

	// Methods

	// RVA: 0x116538C
	public void .ctor() { }

	// RVA: 0x11653F0
	protected void .ctor(ContextQuery other) { }

	// RVA: 0x1167E44
	public override void Reset() { }

	// RVA: 0x1167E4C
	public override XPathNavigator get_Current() { }

	// RVA: 0x1167E54
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1167EA4
	public override XPathNavigator Advance() { }

	// RVA: 0x1167EC4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1167F44
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1167F4C
	public override int get_CurrentPosition() { }

	// RVA: 0x1167F54
	public override int get_Count() { }

	// RVA: 0x1167F5C
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class DescendantBaseQuery
{
	// Fields
	protected bool matchSelf; // 0x54
	protected bool abbrAxis; // 0x55

	// Methods

	// RVA: 0x1167F64
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x1167F9C
	public void .ctor(DescendantBaseQuery other) { }

}

// Namespace: MS.Internal.Xml.XPath
internal class DescendantQuery
{
	// Fields
	private XPathNodeIterator _nodeIterator; // 0x58

	// Methods

	// RVA: 0x1167FD0
	internal void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) { }

	// RVA: 0x1168008
	public void .ctor(DescendantQuery other) { }

	// RVA: 0x1168054
	public override void Reset() { }

	// RVA: 0x11680A4
	public override XPathNavigator Advance() { }

	// RVA: 0x1168254
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DescendantOverDescendantQuery
{
	// Fields
	private int _level; // 0x58

	// Methods

	// RVA: 0x11682E4
	public void .ctor(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis) { }

	// RVA: 0x1168328
	private void .ctor(DescendantOverDescendantQuery other) { }

	// RVA: 0x1168364
	public override void Reset() { }

	// RVA: 0x11683AC
	public override XPathNavigator Advance() { }

	// RVA: 0x116851C
	private bool MoveToFirstChild() { }

	// RVA: 0x1168564
	private bool MoveUpUntilNext() { }

	// RVA: 0x11685D0
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class DocumentOrderQuery
{
	// Methods

	// RVA: 0x116864C
	public void .ctor(Query qyParent) { }

	// RVA: 0x1168650
	private void .ctor(DocumentOrderQuery other) { }

	// RVA: 0x1168654
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x11686B0
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class EmptyQuery
{
	// Methods

	// RVA: 0x1168714
	public override XPathNavigator Advance() { }

	// RVA: 0x116871C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1168720
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1168724
	public override int get_CurrentPosition() { }

	// RVA: 0x116872C
	public override int get_Count() { }

	// RVA: 0x1168734
	public override QueryProps get_Properties() { }

	// RVA: 0x116873C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1168744
	public override void Reset() { }

	// RVA: 0x1168748
	public override XPathNavigator get_Current() { }

	// RVA: 0x1168750
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

	// RVA: 0x1168758
	public void .ctor(string prefix, string name) { }

	// RVA: 0x11687A8
	protected void .ctor(ExtensionQuery other) { }

	// RVA: 0x11688D0
	public override void Reset() { }

	// RVA: 0x11688E8
	public override XPathNavigator get_Current() { }

	// RVA: 0x1168974
	public override XPathNavigator Advance() { }

	// RVA: 0x11689FC
	public override int get_CurrentPosition() { }

	// RVA: 0x1168A14
	protected object ProcessResult(object value) { }

	// RVA: 0x1168DC0
	protected string get_QName() { }

	// RVA: 0x1168E34
	public override int get_Count() { }

	// RVA: 0x1168E50
	public override XPathResultType get_StaticType() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Filter
{
	// Fields
	private AstNode _input; // 0x10
	private AstNode _condition; // 0x18

	// Methods

	// RVA: 0x1168E58
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x1168EA8
	public override AstType get_Type() { }

	// RVA: 0x1168EB0
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1168EB8
	public AstNode get_Input() { }

	// RVA: 0x1168EC0
	public AstNode get_Condition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FilterQuery
{
	// Fields
	private Query _cond; // 0x58
	private bool _noPosition; // 0x60

	// Methods

	// RVA: 0x1168EC8
	public void .ctor(Query qyParent, Query cond, bool noPosition) { }

	// RVA: 0x1168F7C
	private void .ctor(FilterQuery other) { }

	// RVA: 0x1168FCC
	public override void Reset() { }

	// RVA: 0x1169024
	public Query get_Condition() { }

	// RVA: 0x116902C
	public override void SetXsltContext(XsltContext input) { }

	// RVA: 0x1169160
	public override XPathNavigator Advance() { }

	// RVA: 0x11691EC
	internal bool EvaluatePredicate() { }

	// RVA: 0x116938C
	public override QueryProps get_Properties() { }

	// RVA: 0x11693C0
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

	// RVA: 0x1169450
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType type) { }

	// RVA: 0x116955C
	private void .ctor(FollSiblingQuery other) { }

	// RVA: 0x1169654
	public override void Reset() { }

	// RVA: 0x1169780
	private bool Visited(XPathNavigator nav) { }

	// RVA: 0x1169898
	private XPathNavigator FetchInput() { }

	// RVA: 0x1169904
	public override XPathNavigator Advance() { }

	// RVA: 0x1169B94
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FollowingQuery
{
	// Fields
	private XPathNavigator _input; // 0x58
	private XPathNodeIterator _iterator; // 0x60

	// Methods

	// RVA: 0x1169BF8
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1169BFC
	private void .ctor(FollowingQuery other) { }

	// RVA: 0x1169C5C
	public override void Reset() { }

	// RVA: 0x1169CAC
	public override XPathNavigator Advance() { }

	// RVA: 0x1169F34
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class ForwardPositionQuery
{
	// Methods

	// RVA: 0x1169FD8
	public void .ctor(Query input) { }

	// RVA: 0x1169FDC
	protected void .ctor(ForwardPositionQuery other) { }

	// RVA: 0x1169FE0
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x116A090
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

	// RVA: 0x116A0F4
	public void .ctor(FunctionType ftype, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }

	// RVA: 0x116A198
	public void .ctor(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList) { }

	// RVA: 0x116A26C
	public void .ctor(FunctionType ftype, AstNode arg) { }

	// RVA: 0x116A338
	public override AstType get_Type() { }

	// RVA: 0x116A340
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x116A3E4
	public FunctionType get_TypeOfFunction() { }

	// RVA: 0x116A3EC
	public System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> get_ArgumentList() { }

	// RVA: 0x116A3F4
	public string get_Prefix() { }

	// RVA: 0x116A3FC
	public string get_Name() { }

	// RVA: 0x116A404
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class FunctionQuery
{
	// Fields
	private System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> _args; // 0x38
	private IXsltContextFunction _function; // 0x40

	// Methods

	// RVA: 0x116A4A8
	public void .ctor(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> args) { }

	// RVA: 0x116A50C
	private void .ctor(FunctionQuery other) { }

	// RVA: 0x116A728
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x116ACA8
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x116B228
	public override XPathResultType get_StaticType() { }

	// RVA: 0x116B2E8
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Group
{
	// Fields
	private AstNode _groupNode; // 0x10

	// Methods

	// RVA: 0x116B34C
	public void .ctor(AstNode groupNode) { }

	// RVA: 0x116B380
	public override AstType get_Type() { }

	// RVA: 0x116B388
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x116B390
	public AstNode get_GroupNode() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class GroupQuery
{
	// Methods

	// RVA: 0x116B398
	public void .ctor(Query qy) { }

	// RVA: 0x116B424
	private void .ctor(GroupQuery other) { }

	// RVA: 0x116B428
	public override XPathNavigator Advance() { }

	// RVA: 0x116B488
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x116B4B0
	public override XPathNodeIterator Clone() { }

	// RVA: 0x116B514
	public override XPathResultType get_StaticType() { }

	// RVA: 0x116B53C
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class IDQuery
{
	// Methods

	// RVA: 0x116B544
	public void .ctor(Query arg) { }

	// RVA: 0x116B548
	private void .ctor(IDQuery other) { }

	// RVA: 0x116B54C
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x116B77C
	private void ProcessIds(XPathNavigator contextNode, string val) { }

	// RVA: 0x116B884
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

	// RVA: 0x1167998
	internal void .ctor(XPathNodeIterator innerIterator, string name) { }

	// RVA: 0x116B8E8
	private void .ctor(IteratorFilter it) { }

	// RVA: 0x116B954
	public override XPathNodeIterator Clone() { }

	// RVA: 0x116B9FC
	public override XPathNavigator get_Current() { }

	// RVA: 0x116BA20
	public override int get_CurrentPosition() { }

	// RVA: 0x116BA28
	public override bool MoveNext() { }

}

// Namespace: 
private sealed class cmpXslt
{
	// Methods

	// RVA: 0x1170374
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1170418
	public virtual bool Invoke(Op op, object val1, object val2) { }

}

// Namespace: 
private struct NodeSet
{
	// Fields
	private Query _opnd; // 0x10
	private XPathNavigator _current; // 0x18

	// Methods

	// RVA: 0x116C094
	public void .ctor(object opnd) { }

	// RVA: 0x116C168
	public bool MoveNext() { }

	// RVA: 0x116C1E0
	public void Reset() { }

	// RVA: 0x116C1BC
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

	// RVA: 0x116BAAC
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x116BB04
	private void .ctor(LogicalExpr other) { }

	// RVA: 0x116BB70
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x116BBC4
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x116BF14
	private static bool cmpQueryQueryE(Op op, object val1, object val2) { }

	// RVA: 0x116C204
	private static bool cmpQueryQueryO(Op op, object val1, object val2) { }

	// RVA: 0x116C588
	private static bool cmpQueryNumber(Op op, object val1, object val2) { }

	// RVA: 0x116C768
	private static bool cmpQueryStringE(Op op, object val1, object val2) { }

	// RVA: 0x116C8D0
	private static bool cmpQueryStringO(Op op, object val1, object val2) { }

	// RVA: 0x116CB40
	private static bool cmpRtfQueryE(Op op, object val1, object val2) { }

	// RVA: 0x116CD78
	private static bool cmpRtfQueryO(Op op, object val1, object val2) { }

	// RVA: 0x116CFE8
	private static bool cmpQueryBoolE(Op op, object val1, object val2) { }

	// RVA: 0x116D104
	private static bool cmpQueryBoolO(Op op, object val1, object val2) { }

	// RVA: 0x116D0F0
	private static bool cmpBoolBoolE(Op op, bool n1, bool n2) { }

	// RVA: 0x116D2DC
	private static bool cmpBoolBoolE(Op op, object val1, object val2) { }

	// RVA: 0x116D3C8
	private static bool cmpBoolBoolO(Op op, object val1, object val2) { }

	// RVA: 0x116D560
	private static bool cmpBoolNumberE(Op op, object val1, object val2) { }

	// RVA: 0x116D668
	private static bool cmpBoolNumberO(Op op, object val1, object val2) { }

	// RVA: 0x116D7F0
	private static bool cmpBoolStringE(Op op, object val1, object val2) { }

	// RVA: 0x116D8CC
	private static bool cmpRtfBoolE(Op op, object val1, object val2) { }

	// RVA: 0x116DA28
	private static bool cmpBoolStringO(Op op, object val1, object val2) { }

	// RVA: 0x116DBE4
	private static bool cmpRtfBoolO(Op op, object val1, object val2) { }

	// RVA: 0x116C514
	private static bool cmpNumberNumber(Op op, Double n1, Double n2) { }

	// RVA: 0x116CAE4
	private static bool cmpNumberNumberO(Op op, Double n1, Double n2) { }

	// RVA: 0x116DE40
	private static bool cmpNumberNumber(Op op, object val1, object val2) { }

	// RVA: 0x116DFE4
	private static bool cmpStringNumber(Op op, object val1, object val2) { }

	// RVA: 0x116E1BC
	private static bool cmpRtfNumber(Op op, object val1, object val2) { }

	// RVA: 0x116C898
	private static bool cmpStringStringE(Op op, string n1, string n2) { }

	// RVA: 0x116E41C
	private static bool cmpStringStringE(Op op, object val1, object val2) { }

	// RVA: 0x116E4D8
	private static bool cmpRtfStringE(Op op, object val1, object val2) { }

	// RVA: 0x116E60C
	private static bool cmpRtfRtfE(Op op, object val1, object val2) { }

	// RVA: 0x116E788
	private static bool cmpStringStringO(Op op, object val1, object val2) { }

	// RVA: 0x116E998
	private static bool cmpRtfStringO(Op op, object val1, object val2) { }

	// RVA: 0x116EC30
	private static bool cmpRtfRtfO(Op op, object val1, object val2) { }

	// RVA: 0x116EEC8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x116CCF0
	private static string Rtf(object o) { }

	// RVA: 0x116EF78
	public override XPathResultType get_StaticType() { }

	// RVA: 0x116EF80
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class MergeFilterQuery
{
	// Fields
	private Query _child; // 0x28

	// Methods

	// RVA: 0x117042C
	public void .ctor(Query input, Query child) { }

	// RVA: 0x117045C
	private void .ctor(MergeFilterQuery other) { }

	// RVA: 0x11704A0
	public override void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x11704F4
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1170588
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NamespaceQuery
{
	// Fields
	private bool _onNamespace; // 0x54

	// Methods

	// RVA: 0x1170610
	public void .ctor(Query qyParent, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1170614
	private void .ctor(NamespaceQuery other) { }

	// RVA: 0x1170648
	public override void Reset() { }

	// RVA: 0x1170690
	public override XPathNavigator Advance() { }

	// RVA: 0x1170778
	public override bool matches(XPathNavigator e) { }

	// RVA: 0x117080C
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

	// RVA: 0x1170880
	public void .ctor(FunctionType funcType, Query arg) { }

	// RVA: 0x11708C4
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x117093C
	private XPathNavigator EvaluateArg(XPathNodeIterator context) { }

	// RVA: 0x11709A8
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1170C84
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1170D28
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class NumberFunctions
{
	// Fields
	private Query _arg; // 0x18
	private FunctionType _ftype; // 0x20

	// Methods

	// RVA: 0x1170DC4
	public void .ctor(FunctionType ftype, Query arg) { }

	// RVA: 0x1170E0C
	private void .ctor(NumberFunctions other) { }

	// RVA: 0x1170E60
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x116D2C8
	internal static Double Number(bool arg) { }

	// RVA: 0x116C48C
	internal static Double Number(string arg) { }

	// RVA: 0x1170E7C
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1170FA0
	private Double Number(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1171210
	private Double Sum(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1171300
	private Double Floor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11713BC
	private Double Ceiling(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1171478
	private Double Round(XPathNodeIterator nodeIterator) { }

	// RVA: 0x117150C
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1171514
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

	// RVA: 0x11715A8
	public void .ctor(Op op, Query opnd1, Query opnd2) { }

	// RVA: 0x11716D0
	private void .ctor(NumericExpr other) { }

	// RVA: 0x117173C
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x1171790
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11718D4
	private static Double GetValue(Op op, Double n1, Double n2) { }

	// RVA: 0x1171934
	public override XPathResultType get_StaticType() { }

	// RVA: 0x117193C
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Operand
{
	// Fields
	private XPathResultType _type; // 0x10
	private object _val; // 0x18

	// Methods

	// RVA: 0x11719EC
	public void .ctor(string val) { }

	// RVA: 0x1171A28
	public void .ctor(Double val) { }

	// RVA: 0x1171A8C
	public override AstType get_Type() { }

	// RVA: 0x1171A94
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1171A9C
	public object get_OperandValue() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class OperandQuery
{
	// Fields
	internal object val; // 0x18

	// Methods

	// RVA: 0x1171AA4
	public void .ctor(object val) { }

	// RVA: 0x1171AD8
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1171AE0
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1171AEC
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

	// RVA: 0x116BE74
	public static Op InvertOperator(Op op) { }

	// RVA: 0x1171AF0
	public void .ctor(Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x1171B48
	public override AstType get_Type() { }

	// RVA: 0x1171B50
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1171B70
	public Op get_OperatorType() { }

	// RVA: 0x1171B78
	public AstNode get_Operand1() { }

	// RVA: 0x1171B80
	public AstNode get_Operand2() { }

	// RVA: 0x1171B88
	private static void .cctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class ParentQuery
{
	// Methods

	// RVA: 0x1171C2C
	public void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x1171CEC
	private void .ctor(ParentQuery other) { }

	// RVA: 0x1171CF0
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1171D98
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class PreSiblingQuery
{
	// Methods

	// RVA: 0x1171DFC
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x1171EBC
	protected void .ctor(PreSiblingQuery other) { }

	// RVA: 0x1171EC0
	private static bool NotVisited(XPathNavigator nav, System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> parentStk) { }

	// RVA: 0x1171FEC
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x11722C4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1172328
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class PrecedingQuery
{
	// Fields
	private XPathNodeIterator _workIterator; // 0x58
	private MS.Internal.Xml.XPath.ClonableStack<System.Xml.XPath.XPathNavigator> _ancestorStk; // 0x60

	// Methods

	// RVA: 0x1172330
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest) { }

	// RVA: 0x11723E8
	private void .ctor(PrecedingQuery other) { }

	// RVA: 0x1172484
	public override void Reset() { }

	// RVA: 0x1172558
	public override XPathNavigator Advance() { }

	// RVA: 0x117281C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1172880
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

	// RVA: 0x117289C
	public void .ctor() { }

	// RVA: 0x11728F4
	protected void .ctor(Query other) { }

	// RVA: 0x1172964
	public override bool MoveNext() { }

	// RVA: 0x117298C
	public override int get_Count() { }

	// RVA: 0x1172A74
	public virtual void SetXsltContext(XsltContext context) { }

	// RVA: -1
	public abstract object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: -1
	public abstract XPathNavigator Advance() { }

	// RVA: -1
	public abstract XPathResultType get_StaticType() { }

	// RVA: 0x1172A78
	public virtual QueryProps get_Properties() { }

	// RVA: 0x1172A80
	public static Query Clone(Query input) { }

	// RVA: 0x1172B1C
	protected static XPathNodeIterator Clone(XPathNodeIterator input) { }

	// RVA: 0x1172B30
	protected static XPathNavigator Clone(XPathNavigator input) { }

	// RVA: 0x1172B48
	public static bool Insert(System.Collections.Generic.List<System.Xml.XPath.XPathNavigator> buffer, XPathNavigator nav) { }

	// RVA: 0x1172E1C
	private static int GetMedian(int l, int r) { }

	// RVA: 0x1172CF8
	public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r) { }

	// RVA: 0x1172E28
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

	// RVA: 0x1172F10
	private void Reset() { }

	// RVA: 0x1172F1C
	private Query ProcessAxis(Axis root, Flags flags, Props props) { }

	// RVA: 0x1173A7C
	private static bool CanBeNumber(Query q) { }

	// RVA: 0x1173AE4
	private Query ProcessFilter(Filter root, Flags flags, Props props) { }

	// RVA: 0x1173FF8
	private Query ProcessOperator(Operator root, Props props) { }

	// RVA: 0x1174278
	private Query ProcessVariable(Variable root) { }

	// RVA: 0x1174350
	private Query ProcessFunction(Function root, Props props) { }

	// RVA: 0x117485C
	private System.Collections.Generic.List<MS.Internal.Xml.XPath.Query> ProcessArguments(System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> args, Props props) { }

	// RVA: 0x1173688
	private Query ProcessNode(AstNode root, Flags flags, Props props) { }

	// RVA: 0x1174A20
	private Query Build(AstNode root, string query) { }

	// RVA: 0x1174A74
	internal Query Build(string query, bool allowVar, bool allowKey) { }

	// RVA: 0x1174C80
	internal Query Build(string query, bool needContext) { }

	// RVA: 0x1174D48
	public void .ctor() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ResetableIterator
{
	// Methods

	// RVA: 0x11728C8
	public void .ctor() { }

	// RVA: 0x117292C
	protected void .ctor(ResetableIterator other) { }

	// RVA: 0x1174D50
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

	// RVA: 0x1173FF0
	public void .ctor(Query input) { }

	// RVA: 0x1174D5C
	private void .ctor(ReversePositionQuery other) { }

	// RVA: 0x1174D64
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1174DCC
	public override int get_CurrentPosition() { }

	// RVA: 0x1174E24
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Root
{
	// Methods

	// RVA: 0x1174E40
	public void .ctor() { }

	// RVA: 0x1174E48
	public override AstType get_Type() { }

	// RVA: 0x1174E50
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

	// RVA: 0x11749D8
	public void .ctor(FunctionType funcType, System.Collections.Generic.IList<MS.Internal.Xml.XPath.Query> argList) { }

	// RVA: 0x1174E84
	private void .ctor(StringFunctions other) { }

	// RVA: 0x1175130
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x11752BC
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1176E2C
	internal static string toString(Double num) { }

	// RVA: 0x1176E94
	internal static string toString(bool b) { }

	// RVA: 0x11753DC
	private string toString(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1176F00
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1175800
	private string Concat(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11759F4
	private bool StartsWith(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1175BD8
	private bool Contains(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1175DC8
	private string SubstringBefore(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1176000
	private string SubstringAfter(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1176234
	private string Substring(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1176668
	private Double StringLength(XPathNodeIterator nodeIterator) { }

	// RVA: 0x117681C
	private string Normalize(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1176AC4
	private string Translate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1176F28
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1176F8C
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

	// RVA: 0x1174214
	public void .ctor(Query query1, Query query2) { }

	// RVA: 0x117703C
	private void .ctor(UnionExpr other) { }

	// RVA: 0x1177220
	public override void Reset() { }

	// RVA: 0x117727C
	public override void SetXsltContext(XsltContext xsltContext) { }

	// RVA: 0x11772D0
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x117734C
	private XPathNavigator ProcessSamePosition(XPathNavigator result) { }

	// RVA: 0x1177384
	private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x11773CC
	private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2) { }

	// RVA: 0x1177410
	public override XPathNavigator Advance() { }

	// RVA: 0x11775C0
	public override XPathResultType get_StaticType() { }

	// RVA: 0x11775C8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x117762C
	public override XPathNavigator get_Current() { }

	// RVA: 0x1177634
	public override int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.XPath
internal abstract class ValueQuery
{
	// Methods

	// RVA: 0x1174E58
	public void .ctor() { }

	// RVA: 0x11750F8
	protected void .ctor(ValueQuery other) { }

	// RVA: 0x1177674
	public sealed override void Reset() { }

	// RVA: 0x1177678
	public sealed override XPathNavigator get_Current() { }

	// RVA: 0x11776B4
	public sealed override int get_CurrentPosition() { }

	// RVA: 0x11776F0
	public sealed override int get_Count() { }

	// RVA: 0x117772C
	public sealed override XPathNavigator Advance() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class Variable
{
	// Fields
	private string _localname; // 0x10
	private string _prefix; // 0x18

	// Methods

	// RVA: 0x1177768
	public void .ctor(string name, string prefix) { }

	// RVA: 0x11777B8
	public override AstType get_Type() { }

	// RVA: 0x11777C0
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x11777C8
	public string get_Localname() { }

	// RVA: 0x11777D0
	public string get_Prefix() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class VariableQuery
{
	// Fields
	private IXsltContextVariable _variable; // 0x38

	// Methods

	// RVA: 0x117433C
	public void .ctor(string name, string prefix) { }

	// RVA: 0x11777D8
	private void .ctor(VariableQuery other) { }

	// RVA: 0x1177814
	public override void SetXsltContext(XsltContext context) { }

	// RVA: 0x11778E8
	public override object Evaluate(XPathNodeIterator nodeIterator) { }

	// RVA: 0x11779E4
	public override XPathResultType get_StaticType() { }

	// RVA: 0x1177B20
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathAncestorQuery
{
	// Fields
	private bool _matchSelf; // 0x60

	// Methods

	// RVA: 0x1173A48
	public void .ctor(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf) { }

	// RVA: 0x1177BA0
	private void .ctor(XPathAncestorQuery other) { }

	// RVA: 0x1177BD8
	public override object Evaluate(XPathNodeIterator context) { }

	// RVA: 0x1177D04
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1177D7C
	public override int get_CurrentPosition() { }

	// RVA: 0x1177DD4
	public override QueryProps get_Properties() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathArrayIterator
{
	// Fields
	protected IList list; // 0x18
	protected int index; // 0x20

	// Methods

	// RVA: 0x1177DF0
	public void .ctor(XPathArrayIterator it) { }

	// RVA: 0x1177E40
	public void .ctor(XPathNodeIterator nodeIterator) { }

	// RVA: 0x1177FAC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1178038
	public override XPathNavigator get_Current() { }

	// RVA: 0x11781B8
	public override int get_CurrentPosition() { }

	// RVA: 0x11781C0
	public override int get_Count() { }

	// RVA: 0x1178278
	public override bool MoveNext() { }

	// RVA: 0x1178360
	public override void Reset() { }

	// RVA: 0x1178368
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

	// RVA: 0x117841C
	public void .ctor(XPathNavigator nav, bool matchSelf) { }

	// RVA: 0x117846C
	public void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x11784C4
	public void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x11785B4
	public void .ctor(XPathAxisIterator it) { }

	// RVA: 0x117864C
	public override XPathNavigator get_Current() { }

	// RVA: 0x1178654
	public override int get_CurrentPosition() { }

	// RVA: 0x117865C
	protected virtual bool get_Matches() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathChildIterator
{
	// Methods

	// RVA: 0x11787BC
	public void .ctor(XPathNavigator nav, XPathNodeType type) { }

	// RVA: 0x1178810
	public void .ctor(XPathNavigator nav, string name, string namespaceURI) { }

	// RVA: 0x1178818
	public void .ctor(XPathChildIterator it) { }

	// RVA: 0x117881C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1178880
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathDescendantIterator
{
	// Fields
	private int _level; // 0x40

	// Methods

	// RVA: 0x1178928
	public void .ctor(XPathNavigator nav, XPathNodeType type, bool matchSelf) { }

	// RVA: 0x1178980
	public void .ctor(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x1178984
	public void .ctor(XPathDescendantIterator it) { }

	// RVA: 0x11789B8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1178A2C
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathEmptyIterator
{
	// Fields
	public static XPathEmptyIterator Instance; // 0x0

	// Methods

	// RVA: 0x1178B2C
	private void .ctor() { }

	// RVA: 0x1178B58
	public override XPathNodeIterator Clone() { }

	// RVA: 0x1178B5C
	public override XPathNavigator get_Current() { }

	// RVA: 0x1178B64
	public override int get_CurrentPosition() { }

	// RVA: 0x1178B6C
	public override int get_Count() { }

	// RVA: 0x1178B74
	public override bool MoveNext() { }

	// RVA: 0x1178B7C
	public override void Reset() { }

	// RVA: 0x1178B80
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

	// RVA: 0x117CCF0
	public FunctionType get_FType() { }

	// RVA: 0x117CCF8
	public int get_Minargs() { }

	// RVA: 0x117CD00
	public int get_Maxargs() { }

	// RVA: 0x117CD08
	public XPathResultType[] get_ArgTypes() { }

	// RVA: 0x117C694
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

	// RVA: 0x1178BF4
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x1174B38
	public static AstNode ParseXPathExpression(string xpathExpression) { }

	// RVA: 0x1178D30
	private AstNode ParseExpression(AstNode qyInput) { }

	// RVA: 0x1178DA0
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x1178EB0
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x117902C
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x1179318
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x11794C4
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x11795A8
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x1179734
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x1179818
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x1179BA0
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x1179960
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x1179D58
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x117A454
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x117A010
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x1179F30
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x117A610
	private static bool IsStep(LexKind lexKind) { }

	// RVA: 0x117A650
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x117AA08
	private AstNode ParseNodeTest(AstNode qyInput, AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x1179CA0
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x117A17C
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x117ADE0
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x117AD70
	private void CheckToken(LexKind t) { }

	// RVA: 0x117A5A8
	private void PassToken(LexKind t) { }

	// RVA: 0x1179010
	private void NextLex() { }

	// RVA: 0x1178FC0
	private bool TestOp(string op) { }

	// RVA: 0x1179B3C
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x117BAB0
	private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.XPathParser.ParamInfo> CreateFunctionTable() { }

	// RVA: 0x117C6EC
	private static System.Collections.Generic.Dictionary<System.String,MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable() { }

	// RVA: 0x117A8F8
	private AxisType GetAxis() { }

	// RVA: 0x117CA0C
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

	// RVA: 0x1178C28
	public void .ctor(string xpathExpr) { }

	// RVA: 0x117CD7C
	public string get_SourceText() { }

	// RVA: 0x117CD84
	private Char get_CurrentChar() { }

	// RVA: 0x117CD10
	private bool NextChar() { }

	// RVA: 0x117CD8C
	public LexKind get_Kind() { }

	// RVA: 0x117CD94
	public string get_Name() { }

	// RVA: 0x117CD9C
	public string get_Prefix() { }

	// RVA: 0x117CDA4
	public string get_StringValue() { }

	// RVA: 0x117CDAC
	public Double get_NumberValue() { }

	// RVA: 0x117CDB4
	public bool get_CanBeFunction() { }

	// RVA: 0x117CDBC
	private void SkipSpace() { }

	// RVA: 0x117B3B4
	public bool NextLex() { }

	// RVA: 0x117D08C
	private Double ScanNumber() { }

	// RVA: 0x117CE44
	private Double ScanFraction() { }

	// RVA: 0x117CF50
	private string ScanString() { }

	// RVA: 0x117D254
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

	// RVA: 0x117D314
	internal void .ctor(XPathNavigator nav, Query query) { }

	// RVA: 0x117D388
	protected void .ctor(XPathSelectionIterator it) { }

	// RVA: 0x117D4AC
	public override void Reset() { }

	// RVA: 0x117D4D0
	public override bool MoveNext() { }

	// RVA: 0x117D568
	public override int get_Count() { }

	// RVA: 0x117D58C
	public override XPathNavigator get_Current() { }

	// RVA: 0x117D594
	public override int get_CurrentPosition() { }

	// RVA: 0x117D59C
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathSelfQuery
{
	// Methods

	// RVA: 0x1173A74
	public void .ctor(Query qyInput, string Name, string Prefix, XPathNodeType Type) { }

	// RVA: 0x117D600
	private void .ctor(XPathSelfQuery other) { }

	// RVA: 0x117D608
	public override XPathNavigator Advance() { }

	// RVA: 0x117D6A0
	public override XPathNodeIterator Clone() { }

}

// Namespace: MS.Internal.Xml.XPath
internal class XPathSingletonIterator
{
	// Fields
	private XPathNavigator _nav; // 0x18
	private int _position; // 0x20

	// Methods

	// RVA: 0x117D708
	public void .ctor(XPathNavigator nav) { }

	// RVA: 0x117D744
	public void .ctor(XPathNavigator nav, bool moved) { }

	// RVA: 0x117D79C
	public void .ctor(XPathSingletonIterator it) { }

	// RVA: 0x117D804
	public override XPathNodeIterator Clone() { }

	// RVA: 0x117D8A8
	public override XPathNavigator get_Current() { }

	// RVA: 0x117D8B0
	public override int get_CurrentPosition() { }

	// RVA: 0x117D8B8
	public override int get_Count() { }

	// RVA: 0x117D8C0
	public override bool MoveNext() { }

	// RVA: 0x117D8E8
	public override void Reset() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathDocumentBaseIterator
{
	// Fields
	protected XPathDocumentNavigator ctxt; // 0x18
	protected int pos; // 0x20

	// Methods

	// RVA: 0x117D8F0
	protected void .ctor(XPathDocumentNavigator ctxt) { }

	// RVA: 0x117DA28
	protected void .ctor(XPathDocumentBaseIterator iter) { }

	// RVA: 0x117DABC
	public override XPathNavigator get_Current() { }

	// RVA: 0x117DAC4
	public override int get_CurrentPosition() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentElementChildIterator
{
	// Fields
	private string _localName; // 0x28
	private string _namespaceUri; // 0x30

	// Methods

	// RVA: 0x117DACC
	public void .ctor(XPathDocumentNavigator parent, string name, string namespaceURI) { }

	// RVA: 0x117DBF4
	public void .ctor(XPathDocumentElementChildIterator iter) { }

	// RVA: 0x117DCA4
	public override XPathNodeIterator Clone() { }

	// RVA: 0x117DD08
	public override bool MoveNext() { }

}

// Namespace: MS.Internal.Xml.Cache
internal class XPathDocumentKindChildIterator
{
	// Fields
	private XPathNodeType _typ; // 0x24

	// Methods

	// RVA: 0x117DD98
	public void .ctor(XPathDocumentNavigator parent, XPathNodeType typ) { }

	// RVA: 0x117DE28
	public void .ctor(XPathDocumentKindChildIterator iter) { }

	// RVA: 0x117DEBC
	public override XPathNodeIterator Clone() { }

	// RVA: 0x117DFAC
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

	// RVA: 0x117E03C
	public void .ctor(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x117E1FC
	public void .ctor(XPathDocumentElementDescendantIterator iter) { }

	// RVA: 0x117E2C8
	public override XPathNodeIterator Clone() { }

	// RVA: 0x117E32C
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

	// RVA: 0x117E49C
	public void .ctor(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf) { }

	// RVA: 0x117E5C8
	public void .ctor(XPathDocumentKindDescendantIterator iter) { }

	// RVA: 0x117E67C
	public override XPathNodeIterator Clone() { }

	// RVA: 0x117E6E0
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

	// RVA: 0x117E884
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x117D96C
	public void .ctor(XPathDocumentNavigator nav) { }

	// RVA: 0x117E930
	public override string get_Value() { }

	// RVA: 0x117EE8C
	public override XPathNavigator Clone() { }

	// RVA: 0x117EF68
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x117EFB0
	public override string get_LocalName() { }

	// RVA: 0x117F010
	public override string get_NamespaceURI() { }

	// RVA: 0x117F070
	public override string get_Name() { }

	// RVA: 0x117F188
	public override string get_Prefix() { }

	// RVA: 0x117F1E8
	public override string get_BaseURI() { }

	// RVA: 0x117F344
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x117F3AC
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x117F4D4
	public override bool MoveToNextAttribute() { }

	// RVA: 0x117F5B4
	public override bool MoveToAttribute(string localName, string namespaceURI) { }

	// RVA: 0x117F810
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x117FC10
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x117FE38
	public override bool MoveToNext() { }

	// RVA: 0x117FF08
	public override bool MoveToFirstChild() { }

	// RVA: 0x11800E0
	public override bool MoveToParent() { }

	// RVA: 0x1180268
	public override bool MoveTo(XPathNavigator other) { }

	// RVA: 0x1180314
	public override bool MoveToId(string id) { }

	// RVA: 0x11803C0
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x1180478
	public override void MoveToRoot() { }

	// RVA: 0x1180520
	public override bool MoveToChild(string localName, string namespaceURI) { }

	// RVA: 0x1180718
	public override bool MoveToNext(string localName, string namespaceURI) { }

	// RVA: 0x11808FC
	public override bool MoveToChild(XPathNodeType type) { }

	// RVA: 0x1180B5C
	public override bool MoveToNext(XPathNodeType type) { }

	// RVA: 0x1180CF8
	public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) { }

	// RVA: 0x11812DC
	public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) { }

	// RVA: 0x11817A4
	public override XPathNodeIterator SelectChildren(XPathNodeType type) { }

	// RVA: 0x1181868
	public override XPathNodeIterator SelectChildren(string name, string namespaceURI) { }

	// RVA: 0x1181908
	public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) { }

	// RVA: 0x1181984
	public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) { }

	// RVA: 0x1181A3C
	public override XmlNodeOrder ComparePosition(XPathNavigator other) { }

	// RVA: 0x1181CA0
	public override bool IsDescendant(XPathNavigator other) { }

	// RVA: 0x1181B68
	private int GetPrimaryLocation() { }

	// RVA: 0x1181BE4
	private int GetSecondaryLocation() { }

	// RVA: 0x1181E20
	public override object get_UnderlyingObject() { }

	// RVA: 0x1181E30
	public bool HasLineInfo() { }

	// RVA: 0x1181E78
	public int get_LineNumber() { }

	// RVA: 0x1181F3C
	public int get_LinePosition() { }

	// RVA: 0x1182060
	public int GetPositionHashCode() { }

	// RVA: 0x117E3A0
	public bool IsElementMatch(string localName, string namespaceURI) { }

	// RVA: 0x117E7E4
	public bool IsKindMatch(XPathNodeType typ) { }

	// RVA: 0x1180E78
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

	// RVA: 0x117EFA4
	public XPathNodeType get_NodeType() { }

	// RVA: 0x117F1C8
	public string get_Prefix() { }

	// RVA: 0x117EFF0
	public string get_LocalName() { }

	// RVA: 0x117F10C
	public string get_Name() { }

	// RVA: 0x117F050
	public string get_NamespaceUri() { }

	// RVA: 0x117F38C
	public XPathDocument get_Document() { }

	// RVA: 0x117F2E4
	public string get_BaseUri() { }

	// RVA: 0x1181F10
	public int get_LineNumber() { }

	// RVA: 0x1182038
	public int get_LinePosition() { }

	// RVA: 0x1182008
	public int get_CollapsedLinePosition() { }

	// RVA: 0x11820BC
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x11804F8
	public int GetRoot(XPathNode[] pageNode) { }

	// RVA: 0x117F304
	public int GetParent(XPathNode[] pageNode) { }

	// RVA: 0x117FBD0
	public int GetSibling(XPathNode[] pageNode) { }

	// RVA: 0x11820DC
	public int GetSimilarElement(XPathNode[] pageNode) { }

	// RVA: 0x118211C
	public bool NameMatch(string localName, string namespaceName) { }

	// RVA: 0x118206C
	public bool ElementMatch(string localName, string namespaceName) { }

	// RVA: 0x117FB44
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x118215C
	public bool get_HasSibling() { }

	// RVA: 0x117FFC8
	public bool get_HasCollapsedText() { }

	// RVA: 0x118216C
	public bool get_HasAttribute() { }

	// RVA: 0x1182178
	public bool get_HasContentChild() { }

	// RVA: 0x1182184
	public bool get_HasElementChild() { }

	// RVA: 0x1182190
	public bool get_IsAttrNmsp() { }

	// RVA: 0x11821A4
	public bool get_IsText() { }

	// RVA: 0x1182234
	public bool get_HasNamespaceDecls() { }

	// RVA: 0x1182240
	public string get_Value() { }

}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNodeRef
{
	// Fields
	private XPathNode[] _page; // 0x10
	private int _idx; // 0x18

	// Methods

	// RVA: 0x1182248
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0x1182274
	public XPathNode[] get_Page() { }

	// RVA: 0x118227C
	public int get_Index() { }

	// RVA: 0x1182284
	public override int GetHashCode() { }

}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathNodeHelper
{
	// Methods

	// RVA: 0x117F998
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x117FA14
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, XPathNode[] pageNmsp) { }

	// RVA: 0x117F450
	public static bool GetFirstAttribute(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x117F4E4
	public static bool GetNextAttribute(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x117FFD4
	public static bool GetContentChild(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x117FE48
	public static bool GetContentSibling(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x11801D0
	public static bool GetParent(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1181DE4
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x11805B8
	public static bool GetElementChild(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x11807B0
	public static bool GetElementSibling(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x11809E4
	public static bool GetContentChild(XPathNode[] pageNode, int idxNode, XPathNodeType typ) { }

	// RVA: 0x1180B70
	public static bool GetContentSibling(XPathNode[] pageNode, int idxNode, XPathNodeType typ) { }

	// RVA: 0x117F690
	public static bool GetAttribute(XPathNode[] pageNode, int idxNode, string localName, string namespaceName) { }

	// RVA: 0x1180F5C
	public static bool GetElementFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName) { }

	// RVA: 0x1181608
	public static bool GetContentFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ) { }

	// RVA: 0x117EC44
	public static bool GetTextFollowing(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x117EB50
	public static bool GetNonDescendant(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x11822C8
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

	// RVA: 0x1182334
	public int get_PageNumber() { }

	// RVA: 0x118233C
	public int get_NodeCount() { }

	// RVA: 0x1182344
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

	// RVA: 0x118234C
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x1182354
	public string get_LocalName() { }

	// RVA: 0x118235C
	public string get_NamespaceUri() { }

	// RVA: 0x1182364
	public string get_Prefix() { }

	// RVA: 0x118236C
	public string get_BaseUri() { }

	// RVA: 0x1182374
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x118237C
	public XPathNode[] get_SimilarElementPage() { }

	// RVA: 0x1182384
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x118238C
	public XPathDocument get_Document() { }

	// RVA: 0x1182394
	public int get_LineNumberBase() { }

	// RVA: 0x118239C
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

	// RVA: 0x11823A4
	internal static UInt32 ComputeStringHash(string s) { }

}


