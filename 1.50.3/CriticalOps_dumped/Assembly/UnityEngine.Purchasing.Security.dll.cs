// Namespace: 
internal class <Module>
{}

// Namespace: LipingShare.LCLib.Asn1Processor
public enum Asn1EndOfIndefiniteLengthNodeType
{
	// Fields
	public int value__; // 0x10
	public const Asn1EndOfIndefiniteLengthNodeType EndOfStream = 0;
	public const Asn1EndOfIndefiniteLengthNodeType EndOfNodeFooter = 1;
	public const Asn1EndOfIndefiniteLengthNodeType NotEnd = 2;
}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Node
{
	// Fields
	private Byte tag; // 0x10
	private Int64 dataOffset; // 0x18
	private Int64 dataLength; // 0x20
	private Int64 lengthFieldBytes; // 0x28
	private Byte[] data; // 0x30
	private ArrayList childNodeList; // 0x38
	private Byte unusedBits; // 0x40
	private Int64 deepness; // 0x48
	private string path; // 0x50
	private Asn1Node parentNode; // 0x58
	private bool requireRecalculatePar; // 0x60
	private bool isIndefiniteLength; // 0x61
	private bool parseEncapsulatedData; // 0x62

	// Methods

	// RVA: 0x16A01D0
	private void .ctor(Asn1Node parentNode, Int64 dataOffset) { }

	// RVA: 0x16A0284
	private void Init() { }

	// RVA: 0x16A0348
	private string GetHexPrintingStr(Asn1Node startNode, string baseLine, string lStr, int lineLen) { }

	// RVA: 0x16A0D34
	private string FormatLineString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x16A08F0
	private string FormatLineHexString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x16A12F0
	public void .ctor() { }

	// RVA: 0x16A1370
	public bool get_IsIndefiniteLength() { }

	// RVA: 0x16A1378
	public Byte get_Tag() { }

	// RVA: 0x16A1380
	public Byte get_MaskedTag() { }

	// RVA: 0x16A138C
	public bool LoadData(Stream xdata) { }

	// RVA: 0x16A1538
	public bool SaveData(Stream xdata) { }

	// RVA: 0x16A18FC
	public void ClearAll() { }

	// RVA: 0x16A1AA8
	public void AddChild(Asn1Node xdata) { }

	// RVA: 0x16A1B24
	private Asn1Node GetLastChild() { }

	// RVA: 0x16A16A0
	public Int64 get_ChildNodeCount() { }

	// RVA: 0x16A1824
	public Asn1Node GetChildNode(int index) { }

	// RVA: 0x16A1BD4
	public string get_TagName() { }

	// RVA: 0x16A2074
	public Asn1Node get_ParentNode() { }

	// RVA: 0x16A207C
	public string GetText(Asn1Node startNode, int lineLen) { }

	// RVA: 0x16A3E48
	public string GetDataStr(bool pureHexMode) { }

	// RVA: 0x16A4298
	public Int64 get_DataLength() { }

	// RVA: 0x16A42A0
	public Byte[] get_Data() { }

	// RVA: 0x16A4428
	public Int64 get_Deepness() { }

	// RVA: 0x16A4430
	protected void set_RequireRecalculatePar(bool value) { }

	// RVA: 0x16A1A48
	protected void RecalculateTreePar() { }

	// RVA: 0x16A4438
	protected static Int64 ResetBranchDataLength(Asn1Node node) { }

	// RVA: 0x16A4654
	protected static void ResetDataLengthFieldWidth(Asn1Node node) { }

	// RVA: 0x16A451C
	protected void ResetChildNodePar(Asn1Node xNode, Int64 subOffset) { }

	// RVA: 0x16A3D2C
	protected string GetListStr(Asn1Node startNode, int lineLen) { }

	// RVA: 0x16A0614
	protected string GetIndentStr(Asn1Node startNode) { }

	// RVA: 0x16A4718
	protected bool GeneralDecode(Stream xdata) { }

	// RVA: 0x16A4A00
	private bool AreTagsOk() { }

	// RVA: 0x16A4BDC
	private bool GeneralDecodeKnownLengthWithChecks(Stream xdata, Int64 start, Int64 nodeMaxLen) { }

	// RVA: 0x16A4C64
	private bool IsGeneralStreamLengthOk(Stream xdata, Int64 start, Int64 nodeMaxLen) { }

	// RVA: 0x16A4CE8
	private bool GeneralDecodeKnownLength(Stream xdata) { }

	// RVA: 0x16A4E40
	private void ReadStreamDataDefiniteLength(Stream xdata, int length) { }

	// RVA: 0x16A4A30
	private bool GeneralDecodeIndefiniteLength(Stream xdata, Int64 nodeMaxLen) { }

	// RVA: 0x16A4EDC
	private bool ReadStreamDataIndefiniteLength(Stream xdata, Int64 nodeMaxLen) { }

	// RVA: 0x16A4FE0
	private Int64 MeasureContentLength(Stream xdata) { }

	// RVA: 0x16A5078
	private void ReadMeasuredLengthDataFromStart(Stream xdata, Int64 startPosition, Int64 length) { }

	// RVA: 0x16A5140
	protected bool ListDecode(Stream xdata) { }

	// RVA: 0x16A5560
	private bool ListDecodeKnownLengthWithChecks(Stream xdata, Int64 start, Int64 childNodeMaxLen) { }

	// RVA: 0x16A557C
	private bool IsListStreamLengthOk(Stream xdata, Int64 childNodeMaxLen) { }

	// RVA: 0x16A5590
	private bool ListDecodeKnownLength(Stream xdata, Int64 start) { }

	// RVA: 0x16A56B4
	private Int64 CalculateListEncodeFieldBytesAndOffset(Stream xdata, Int64 start) { }

	// RVA: 0x16A5704
	private bool HandleBitStringTag(Stream xdata, Int64 offset) { }

	// RVA: 0x16A577C
	private bool ListDecodeKnownLengthInternal(Stream xdata, Int64 offset) { }

	// RVA: 0x16A580C
	private Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(Stream xdata) { }

	// RVA: 0x16A5934
	private bool ListDecodeChildNodesWithKnownLength(Stream secData, Int64 offset) { }

	// RVA: 0x16A59BC
	private bool CreateAndAddChildNode(Stream secData, Int64 offset) { }

	// RVA: 0x16A54BC
	private bool ListDecodeIndefiniteLength(Stream xdata, Int64 start, Int64 childNodeMaxLen) { }

	// RVA: 0x16A5B64
	private bool ListDecodeIndefiniteLengthInternal(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x16A5C64
	private bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x16A5D40
	private Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(Stream xdata) { }

	// RVA: 0x16A5DC0
	private bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x16A1464
	protected bool InternalLoadData(Stream xdata) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Parser
{
	// Fields
	private Byte[] rawData; // 0x10
	private Asn1Node rootNode; // 0x18

	// Methods

	// RVA: 0x16A5F08
	public void .ctor() { }

	// RVA: 0x16A5FD4
	public void LoadData(Stream stream) { }

	// RVA: 0x16A6110
	public Asn1Node get_RootNode() { }

	// RVA: 0x16A6118
	public static string GetNodeTextHeader(int lineLen) { }

	// RVA: 0x16A6370
	public override string ToString() { }

	// RVA: 0x16A63BC
	public static string GetNodeText(Asn1Node node, int lineLen) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Util
{
	// Fields
	private static Char[] hexDigits; // 0x0

	// Methods

	// RVA: 0x16A403C
	public static string FormatString(string inStr, int lineLen, int groupLen) { }

	// RVA: 0x16A11FC
	public static string GenStr(int len, Char xch) { }

	// RVA: 0x16A3CDC
	public static Int64 BytesToLong(Byte[] bytes) { }

	// RVA: 0x16A3BD0
	public static string BytesToString(Byte[] bytes) { }

	// RVA: 0x16A06B8
	public static string ToHexString(Byte[] bytes) { }

	// RVA: 0x16A6414
	public static int BytePrecision(UInt64 value) { }

	// RVA: 0x16A16D0
	public static int DERLengthEncode(Stream xdata, UInt64 length) { }

	// RVA: 0x16A492C
	public static Int64 DerLengthDecode(Stream bt, bool isIndefiniteLength) { }

	// RVA: 0x16A1C5C
	public static string GetTagName(Byte tag) { }

	// RVA: 0x16A644C
	private static void .cctor() { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Oid
{
	// Fields
	private static StringDictionary oidDictionary; // 0x0

	// Methods

	// RVA: 0x16A3B08
	public string GetOidName(string inOidStr) { }

	// RVA: 0x16A64F0
	public string Decode(Byte[] data) { }

	// RVA: 0x16A65A8
	public virtual string Decode(Stream bt) { }

	// RVA: 0x16A3B00
	public void .ctor() { }

	// RVA: 0x16A6830
	protected int DecodeValue(Stream bt, UInt64 v) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class RelativeOid
{
	// Methods

	// RVA: 0x16A3BC8
	public void .ctor() { }

	// RVA: 0x16A6898
	public override string Decode(Stream bt) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class AppleReceiptParser
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,System.Object> _mostRecentReceiptData; // 0x0

	// Methods

	// RVA: 0x16A6AD0
	public AppleReceipt Parse(Byte[] receiptData) { }

	// RVA: 0x16A6AF4
	internal AppleReceipt Parse(Byte[] receiptData, PKCS7 receipt) { }

	// RVA: 0x16A71C4
	private static CultureInfo PushInvariantCultureOnThread() { }

	// RVA: 0x16A77B0
	private static void PopCultureOffThread(CultureInfo originalCulture) { }

	// RVA: 0x16A72A0
	private AppleReceipt ParseReceipt(Asn1Node data) { }

	// RVA: 0x16A77EC
	private Asn1Node GetSetNode(Asn1Node data) { }

	// RVA: 0x16A7854
	private AppleInAppPurchaseReceipt ParseInAppReceipt(Asn1Node inApp) { }

	// RVA: 0x16A7D8C
	private static DateTime TryParseDateTimeNode(Asn1Node node) { }

	// RVA: 0x30D6128
	public static bool ArrayEquals(T[] a, T[] b) { }

	// RVA: 0x16A7E80
	public void .ctor() { }

	// RVA: 0x16A7E88
	private static void .cctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
internal class DistinguishedName
{
	// Fields
	private string <Country>k__BackingField; // 0x10
	private string <Organization>k__BackingField; // 0x18
	private string <OrganizationalUnit>k__BackingField; // 0x20
	private string <Dnq>k__BackingField; // 0x28
	private string <State>k__BackingField; // 0x30
	private string <CommonName>k__BackingField; // 0x38
	private string <SerialNumber>k__BackingField; // 0x40

	// Methods

	// RVA: 0x16A7F24
	public string get_Country() { }

	// RVA: 0x16A7F2C
	public void set_Country(string value) { }

	// RVA: 0x16A7F34
	public string get_Organization() { }

	// RVA: 0x16A7F3C
	public void set_Organization(string value) { }

	// RVA: 0x16A7F44
	public string get_OrganizationalUnit() { }

	// RVA: 0x16A7F4C
	public void set_OrganizationalUnit(string value) { }

	// RVA: 0x16A7F54
	public string get_Dnq() { }

	// RVA: 0x16A7F5C
	public void set_Dnq(string value) { }

	// RVA: 0x16A7F64
	public string get_State() { }

	// RVA: 0x16A7F6C
	public void set_State(string value) { }

	// RVA: 0x16A7F74
	public string get_CommonName() { }

	// RVA: 0x16A7F7C
	public void set_CommonName(string value) { }

	// RVA: 0x16A7F84
	public void set_SerialNumber(string value) { }

	// RVA: 0x16A7F8C
	public void .ctor(Asn1Node n) { }

	// RVA: 0x16A8674
	public bool Equals(DistinguishedName n2) { }

	// RVA: 0x16A871C
	public override string ToString() { }

}

// Namespace: UnityEngine.Purchasing.Security
internal class X509Cert
{
	// Fields
	private string <SerialNumber>k__BackingField; // 0x10
	private DateTime <ValidAfter>k__BackingField; // 0x18
	private DateTime <ValidBefore>k__BackingField; // 0x20
	private RSAKey <PubKey>k__BackingField; // 0x28
	private bool <SelfSigned>k__BackingField; // 0x30
	private DistinguishedName <Subject>k__BackingField; // 0x38
	private DistinguishedName <Issuer>k__BackingField; // 0x40
	private Asn1Node TbsCertificate; // 0x48
	private Asn1Node <Signature>k__BackingField; // 0x50
	public Byte[] rawTBSCertificate; // 0x58

	// Methods

	// RVA: 0x16A88D4
	private void set_SerialNumber(string value) { }

	// RVA: 0x16A88DC
	private void set_ValidAfter(DateTime value) { }

	// RVA: 0x16A88E4
	private void set_ValidBefore(DateTime value) { }

	// RVA: 0x16A88EC
	private void set_PubKey(RSAKey value) { }

	// RVA: 0x16A88F4
	private void set_SelfSigned(bool value) { }

	// RVA: 0x16A88FC
	public DistinguishedName get_Subject() { }

	// RVA: 0x16A8904
	private void set_Subject(DistinguishedName value) { }

	// RVA: 0x16A890C
	public DistinguishedName get_Issuer() { }

	// RVA: 0x16A8914
	private void set_Issuer(DistinguishedName value) { }

	// RVA: 0x16A891C
	private void set_Signature(Asn1Node value) { }

	// RVA: 0x16A8924
	public void .ctor(Asn1Node n) { }

	// RVA: 0x16A8954
	private void ParseNode(Asn1Node root) { }

	// RVA: 0x16A8CBC
	private DateTime ParseTime(Asn1Node n) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidTimeFormat
{
	// Methods

	// RVA: 0x16A8F34
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidX509Data
{
	// Methods

	// RVA: 0x16A85E0
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public enum GooglePurchaseState
{
	// Fields
	public int value__; // 0x10
	public const GooglePurchaseState Purchased = 0;
	public const GooglePurchaseState Cancelled = 1;
	public const GooglePurchaseState Refunded = 2;
	public const GooglePurchaseState Deferred = 4;
}

// Namespace: UnityEngine.Purchasing.Security
internal class PKCS7
{
	// Fields
	private Asn1Node root; // 0x10
	private Asn1Node <data>k__BackingField; // 0x18
	private System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> <sinfos>k__BackingField; // 0x20
	private System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> <certChain>k__BackingField; // 0x28
	private bool validStructure; // 0x30

	// Methods

	// RVA: 0x16A8F3C
	public Asn1Node get_data() { }

	// RVA: 0x16A8F44
	private void set_data(Asn1Node value) { }

	// RVA: 0x16A8F4C
	public System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> get_sinfos() { }

	// RVA: 0x16A8F54
	private void set_sinfos(System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> value) { }

	// RVA: 0x16A8F5C
	public System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> get_certChain() { }

	// RVA: 0x16A8F64
	private void set_certChain(System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> value) { }

	// RVA: 0x16A7264
	public void .ctor(Asn1Node node) { }

	// RVA: 0x16A8F6C
	private void CheckStructure() { }

}

// Namespace: UnityEngine.Purchasing.Security
internal class SignerInfo
{
	// Fields
	private int <Version>k__BackingField; // 0x10
	private string <IssuerSerialNumber>k__BackingField; // 0x18
	private Byte[] <EncryptedDigest>k__BackingField; // 0x20

	// Methods

	// RVA: 0x16A9628
	public int get_Version() { }

	// RVA: 0x16A9630
	private void set_Version(int value) { }

	// RVA: 0x16A9638
	private void set_IssuerSerialNumber(string value) { }

	// RVA: 0x16A9640
	private void set_EncryptedDigest(Byte[] value) { }

	// RVA: 0x16A941C
	public void .ctor(Asn1Node n) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidPKCS7Data
{
	// Methods

	// RVA: 0x16A77E4
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class UnsupportedSignerInfoVersion
{
	// Methods

	// RVA: 0x16A9648
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
internal class RSAKey
{
	// Fields
	private RSACryptoServiceProvider <rsa>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16A9650
	private void set_rsa(RSACryptoServiceProvider value) { }

	// RVA: 0x16A8EF4
	public void .ctor(Asn1Node n) { }

	// RVA: 0x16A9658
	private RSACryptoServiceProvider ParseNode(Asn1Node n) { }

	// RVA: 0x16A98F4
	private string ToXML(string modulus, string exponent) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidRSAData
{
	// Methods

	// RVA: 0x16A9A3C
	public void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=32
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=32 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70; // 0x0

	// Methods

	// RVA: 0x16A85E8
	internal static UInt32 ComputeStringHash(string s) { }

}


