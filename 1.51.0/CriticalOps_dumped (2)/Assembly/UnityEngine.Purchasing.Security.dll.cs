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

	// RVA: 0x1752DAC
	private void .ctor(Asn1Node parentNode, Int64 dataOffset) { }

	// RVA: 0x1752E60
	private void Init() { }

	// RVA: 0x1752F24
	private string GetHexPrintingStr(Asn1Node startNode, string baseLine, string lStr, int lineLen) { }

	// RVA: 0x1753910
	private string FormatLineString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x17534CC
	private string FormatLineHexString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x1753ECC
	public void .ctor() { }

	// RVA: 0x1753F4C
	public bool get_IsIndefiniteLength() { }

	// RVA: 0x1753F54
	public Byte get_Tag() { }

	// RVA: 0x1753F5C
	public Byte get_MaskedTag() { }

	// RVA: 0x1753F68
	public bool LoadData(Stream xdata) { }

	// RVA: 0x1754114
	public bool SaveData(Stream xdata) { }

	// RVA: 0x17544D8
	public void ClearAll() { }

	// RVA: 0x1754684
	public void AddChild(Asn1Node xdata) { }

	// RVA: 0x1754700
	private Asn1Node GetLastChild() { }

	// RVA: 0x175427C
	public Int64 get_ChildNodeCount() { }

	// RVA: 0x1754400
	public Asn1Node GetChildNode(int index) { }

	// RVA: 0x17547B0
	public string get_TagName() { }

	// RVA: 0x1754C50
	public Asn1Node get_ParentNode() { }

	// RVA: 0x1754C58
	public string GetText(Asn1Node startNode, int lineLen) { }

	// RVA: 0x1756BB8
	public string GetDataStr(bool pureHexMode) { }

	// RVA: 0x1757008
	public Int64 get_DataLength() { }

	// RVA: 0x1757010
	public Byte[] get_Data() { }

	// RVA: 0x1757198
	public Int64 get_Deepness() { }

	// RVA: 0x17571A0
	protected void set_RequireRecalculatePar(bool value) { }

	// RVA: 0x1754624
	protected void RecalculateTreePar() { }

	// RVA: 0x17571A8
	protected static Int64 ResetBranchDataLength(Asn1Node node) { }

	// RVA: 0x17573C4
	protected static void ResetDataLengthFieldWidth(Asn1Node node) { }

	// RVA: 0x175728C
	protected void ResetChildNodePar(Asn1Node xNode, Int64 subOffset) { }

	// RVA: 0x1756A9C
	protected string GetListStr(Asn1Node startNode, int lineLen) { }

	// RVA: 0x17531F0
	protected string GetIndentStr(Asn1Node startNode) { }

	// RVA: 0x1757488
	protected bool GeneralDecode(Stream xdata) { }

	// RVA: 0x1757770
	private bool AreTagsOk() { }

	// RVA: 0x175794C
	private bool GeneralDecodeKnownLengthWithChecks(Stream xdata, Int64 start, Int64 nodeMaxLen) { }

	// RVA: 0x17579D4
	private bool IsGeneralStreamLengthOk(Stream xdata, Int64 start, Int64 nodeMaxLen) { }

	// RVA: 0x1757A58
	private bool GeneralDecodeKnownLength(Stream xdata) { }

	// RVA: 0x1757BB0
	private void ReadStreamDataDefiniteLength(Stream xdata, int length) { }

	// RVA: 0x17577A0
	private bool GeneralDecodeIndefiniteLength(Stream xdata, Int64 nodeMaxLen) { }

	// RVA: 0x1757C4C
	private bool ReadStreamDataIndefiniteLength(Stream xdata, Int64 nodeMaxLen) { }

	// RVA: 0x1757D50
	private Int64 MeasureContentLength(Stream xdata) { }

	// RVA: 0x1757DE8
	private void ReadMeasuredLengthDataFromStart(Stream xdata, Int64 startPosition, Int64 length) { }

	// RVA: 0x1757EB0
	protected bool ListDecode(Stream xdata) { }

	// RVA: 0x17582D0
	private bool ListDecodeKnownLengthWithChecks(Stream xdata, Int64 start, Int64 childNodeMaxLen) { }

	// RVA: 0x17582EC
	private bool IsListStreamLengthOk(Stream xdata, Int64 childNodeMaxLen) { }

	// RVA: 0x1758300
	private bool ListDecodeKnownLength(Stream xdata, Int64 start) { }

	// RVA: 0x1758424
	private Int64 CalculateListEncodeFieldBytesAndOffset(Stream xdata, Int64 start) { }

	// RVA: 0x1758474
	private bool HandleBitStringTag(Stream xdata, Int64 offset) { }

	// RVA: 0x17584EC
	private bool ListDecodeKnownLengthInternal(Stream xdata, Int64 offset) { }

	// RVA: 0x175857C
	private Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(Stream xdata) { }

	// RVA: 0x17586A4
	private bool ListDecodeChildNodesWithKnownLength(Stream secData, Int64 offset) { }

	// RVA: 0x175872C
	private bool CreateAndAddChildNode(Stream secData, Int64 offset) { }

	// RVA: 0x175822C
	private bool ListDecodeIndefiniteLength(Stream xdata, Int64 start, Int64 childNodeMaxLen) { }

	// RVA: 0x17588D4
	private bool ListDecodeIndefiniteLengthInternal(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x17589D4
	private bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x1758AB0
	private Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(Stream xdata) { }

	// RVA: 0x1758B30
	private bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x1754040
	protected bool InternalLoadData(Stream xdata) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Parser
{
	// Fields
	private Byte[] rawData; // 0x10
	private Asn1Node rootNode; // 0x18

	// Methods

	// RVA: 0x1758C78
	public void .ctor() { }

	// RVA: 0x1758D44
	public void LoadData(Stream stream) { }

	// RVA: 0x1758E80
	public Asn1Node get_RootNode() { }

	// RVA: 0x1758E88
	public static string GetNodeTextHeader(int lineLen) { }

	// RVA: 0x17590E0
	public override string ToString() { }

	// RVA: 0x175912C
	public static string GetNodeText(Asn1Node node, int lineLen) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Util
{
	// Fields
	private static Char[] hexDigits; // 0x0

	// Methods

	// RVA: 0x1756DAC
	public static string FormatString(string inStr, int lineLen, int groupLen) { }

	// RVA: 0x1753DD8
	public static string GenStr(int len, Char xch) { }

	// RVA: 0x1756A4C
	public static Int64 BytesToLong(Byte[] bytes) { }

	// RVA: 0x1756940
	public static string BytesToString(Byte[] bytes) { }

	// RVA: 0x1753294
	public static string ToHexString(Byte[] bytes) { }

	// RVA: 0x1759184
	public static int BytePrecision(UInt64 value) { }

	// RVA: 0x17542AC
	public static int DERLengthEncode(Stream xdata, UInt64 length) { }

	// RVA: 0x175769C
	public static Int64 DerLengthDecode(Stream bt, bool isIndefiniteLength) { }

	// RVA: 0x1754838
	public static string GetTagName(Byte tag) { }

	// RVA: 0x17591BC
	private static void .cctor() { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Oid
{
	// Fields
	private static StringDictionary oidDictionary; // 0x0

	// Methods

	// RVA: 0x1756878
	public string GetOidName(string inOidStr) { }

	// RVA: 0x1759260
	public string Decode(Byte[] data) { }

	// RVA: 0x1759318
	public virtual string Decode(Stream bt) { }

	// RVA: 0x1756870
	public void .ctor() { }

	// RVA: 0x17595A0
	protected int DecodeValue(Stream bt, UInt64 v) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class RelativeOid
{
	// Methods

	// RVA: 0x1756938
	public void .ctor() { }

	// RVA: 0x1759608
	public override string Decode(Stream bt) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class AppleReceiptParser
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,System.Object> _mostRecentReceiptData; // 0x0

	// Methods

	// RVA: 0x1759840
	public AppleReceipt Parse(Byte[] receiptData) { }

	// RVA: 0x1759864
	internal AppleReceipt Parse(Byte[] receiptData, PKCS7 receipt) { }

	// RVA: 0x1759F34
	private static CultureInfo PushInvariantCultureOnThread() { }

	// RVA: 0x175A520
	private static void PopCultureOffThread(CultureInfo originalCulture) { }

	// RVA: 0x175A010
	private AppleReceipt ParseReceipt(Asn1Node data) { }

	// RVA: 0x175A55C
	private Asn1Node GetSetNode(Asn1Node data) { }

	// RVA: 0x175A5C4
	private AppleInAppPurchaseReceipt ParseInAppReceipt(Asn1Node inApp) { }

	// RVA: 0x175AAFC
	private static DateTime TryParseDateTimeNode(Asn1Node node) { }

	// RVA: 0x3527C54
	public static bool ArrayEquals(T[] a, T[] b) { }

	// RVA: 0x175ABF0
	public void .ctor() { }

	// RVA: 0x175ABF8
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

	// RVA: 0x175AC94
	public string get_Country() { }

	// RVA: 0x175AC9C
	public void set_Country(string value) { }

	// RVA: 0x175ACA4
	public string get_Organization() { }

	// RVA: 0x175ACAC
	public void set_Organization(string value) { }

	// RVA: 0x175ACB4
	public string get_OrganizationalUnit() { }

	// RVA: 0x175ACBC
	public void set_OrganizationalUnit(string value) { }

	// RVA: 0x175ACC4
	public string get_Dnq() { }

	// RVA: 0x175ACCC
	public void set_Dnq(string value) { }

	// RVA: 0x175ACD4
	public string get_State() { }

	// RVA: 0x175ACDC
	public void set_State(string value) { }

	// RVA: 0x175ACE4
	public string get_CommonName() { }

	// RVA: 0x175ACEC
	public void set_CommonName(string value) { }

	// RVA: 0x175ACF4
	public void set_SerialNumber(string value) { }

	// RVA: 0x175ACFC
	public void .ctor(Asn1Node n) { }

	// RVA: 0x175B3E4
	public bool Equals(DistinguishedName n2) { }

	// RVA: 0x175B48C
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

	// RVA: 0x175B644
	private void set_SerialNumber(string value) { }

	// RVA: 0x175B64C
	private void set_ValidAfter(DateTime value) { }

	// RVA: 0x175B654
	private void set_ValidBefore(DateTime value) { }

	// RVA: 0x175B65C
	private void set_PubKey(RSAKey value) { }

	// RVA: 0x175B664
	private void set_SelfSigned(bool value) { }

	// RVA: 0x175B66C
	public DistinguishedName get_Subject() { }

	// RVA: 0x175B674
	private void set_Subject(DistinguishedName value) { }

	// RVA: 0x175B67C
	public DistinguishedName get_Issuer() { }

	// RVA: 0x175B684
	private void set_Issuer(DistinguishedName value) { }

	// RVA: 0x175B68C
	private void set_Signature(Asn1Node value) { }

	// RVA: 0x175B694
	public void .ctor(Asn1Node n) { }

	// RVA: 0x175B6C4
	private void ParseNode(Asn1Node root) { }

	// RVA: 0x175BA2C
	private DateTime ParseTime(Asn1Node n) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidTimeFormat
{
	// Methods

	// RVA: 0x175BCA4
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidX509Data
{
	// Methods

	// RVA: 0x175B350
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

	// RVA: 0x175BCAC
	public Asn1Node get_data() { }

	// RVA: 0x175BCB4
	private void set_data(Asn1Node value) { }

	// RVA: 0x175BCBC
	public System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> get_sinfos() { }

	// RVA: 0x175BCC4
	private void set_sinfos(System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> value) { }

	// RVA: 0x175BCCC
	public System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> get_certChain() { }

	// RVA: 0x175BCD4
	private void set_certChain(System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> value) { }

	// RVA: 0x1759FD4
	public void .ctor(Asn1Node node) { }

	// RVA: 0x175BCDC
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

	// RVA: 0x175C398
	public int get_Version() { }

	// RVA: 0x175C3A0
	private void set_Version(int value) { }

	// RVA: 0x175C3A8
	private void set_IssuerSerialNumber(string value) { }

	// RVA: 0x175C3B0
	private void set_EncryptedDigest(Byte[] value) { }

	// RVA: 0x175C18C
	public void .ctor(Asn1Node n) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidPKCS7Data
{
	// Methods

	// RVA: 0x175A554
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class UnsupportedSignerInfoVersion
{
	// Methods

	// RVA: 0x175C3B8
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
internal class RSAKey
{
	// Fields
	private RSACryptoServiceProvider <rsa>k__BackingField; // 0x10

	// Methods

	// RVA: 0x175C3C0
	private void set_rsa(RSACryptoServiceProvider value) { }

	// RVA: 0x175BC64
	public void .ctor(Asn1Node n) { }

	// RVA: 0x175C3C8
	private RSACryptoServiceProvider ParseNode(Asn1Node n) { }

	// RVA: 0x175C664
	private string ToXML(string modulus, string exponent) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidRSAData
{
	// Methods

	// RVA: 0x175C7AC
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

	// RVA: 0x175B358
	internal static UInt32 ComputeStringHash(string s) { }

}


