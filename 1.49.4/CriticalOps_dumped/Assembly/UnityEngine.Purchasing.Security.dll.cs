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

	// RVA: 0x166DDDC
	private void .ctor(Asn1Node parentNode, Int64 dataOffset) { }

	// RVA: 0x166DE90
	private void Init() { }

	// RVA: 0x166DF54
	private string GetHexPrintingStr(Asn1Node startNode, string baseLine, string lStr, int lineLen) { }

	// RVA: 0x166E940
	private string FormatLineString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x166E4FC
	private string FormatLineHexString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x166EEFC
	public void .ctor() { }

	// RVA: 0x166EF7C
	public bool get_IsIndefiniteLength() { }

	// RVA: 0x166EF84
	public Byte get_Tag() { }

	// RVA: 0x166EF8C
	public Byte get_MaskedTag() { }

	// RVA: 0x166EF98
	public bool LoadData(Stream xdata) { }

	// RVA: 0x166F144
	public bool SaveData(Stream xdata) { }

	// RVA: 0x166F508
	public void ClearAll() { }

	// RVA: 0x166F6B4
	public void AddChild(Asn1Node xdata) { }

	// RVA: 0x166F730
	private Asn1Node GetLastChild() { }

	// RVA: 0x166F2AC
	public Int64 get_ChildNodeCount() { }

	// RVA: 0x166F430
	public Asn1Node GetChildNode(int index) { }

	// RVA: 0x166F7E0
	public string get_TagName() { }

	// RVA: 0x166FC80
	public Asn1Node get_ParentNode() { }

	// RVA: 0x166FC88
	public string GetText(Asn1Node startNode, int lineLen) { }

	// RVA: 0x1671A54
	public string GetDataStr(bool pureHexMode) { }

	// RVA: 0x1671EA4
	public Int64 get_DataLength() { }

	// RVA: 0x1671EAC
	public Byte[] get_Data() { }

	// RVA: 0x1672034
	public Int64 get_Deepness() { }

	// RVA: 0x167203C
	protected void set_RequireRecalculatePar(bool value) { }

	// RVA: 0x166F654
	protected void RecalculateTreePar() { }

	// RVA: 0x1672044
	protected static Int64 ResetBranchDataLength(Asn1Node node) { }

	// RVA: 0x1672260
	protected static void ResetDataLengthFieldWidth(Asn1Node node) { }

	// RVA: 0x1672128
	protected void ResetChildNodePar(Asn1Node xNode, Int64 subOffset) { }

	// RVA: 0x1671938
	protected string GetListStr(Asn1Node startNode, int lineLen) { }

	// RVA: 0x166E220
	protected string GetIndentStr(Asn1Node startNode) { }

	// RVA: 0x1672324
	protected bool GeneralDecode(Stream xdata) { }

	// RVA: 0x167260C
	private bool AreTagsOk() { }

	// RVA: 0x16727E8
	private bool GeneralDecodeKnownLengthWithChecks(Stream xdata, Int64 start, Int64 nodeMaxLen) { }

	// RVA: 0x1672870
	private bool IsGeneralStreamLengthOk(Stream xdata, Int64 start, Int64 nodeMaxLen) { }

	// RVA: 0x16728F4
	private bool GeneralDecodeKnownLength(Stream xdata) { }

	// RVA: 0x1672A4C
	private void ReadStreamDataDefiniteLength(Stream xdata, int length) { }

	// RVA: 0x167263C
	private bool GeneralDecodeIndefiniteLength(Stream xdata, Int64 nodeMaxLen) { }

	// RVA: 0x1672AE8
	private bool ReadStreamDataIndefiniteLength(Stream xdata, Int64 nodeMaxLen) { }

	// RVA: 0x1672BEC
	private Int64 MeasureContentLength(Stream xdata) { }

	// RVA: 0x1672C84
	private void ReadMeasuredLengthDataFromStart(Stream xdata, Int64 startPosition, Int64 length) { }

	// RVA: 0x1672D4C
	protected bool ListDecode(Stream xdata) { }

	// RVA: 0x167316C
	private bool ListDecodeKnownLengthWithChecks(Stream xdata, Int64 start, Int64 childNodeMaxLen) { }

	// RVA: 0x1673188
	private bool IsListStreamLengthOk(Stream xdata, Int64 childNodeMaxLen) { }

	// RVA: 0x167319C
	private bool ListDecodeKnownLength(Stream xdata, Int64 start) { }

	// RVA: 0x16732C0
	private Int64 CalculateListEncodeFieldBytesAndOffset(Stream xdata, Int64 start) { }

	// RVA: 0x1673310
	private bool HandleBitStringTag(Stream xdata, Int64 offset) { }

	// RVA: 0x1673388
	private bool ListDecodeKnownLengthInternal(Stream xdata, Int64 offset) { }

	// RVA: 0x1673418
	private Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(Stream xdata) { }

	// RVA: 0x1673540
	private bool ListDecodeChildNodesWithKnownLength(Stream secData, Int64 offset) { }

	// RVA: 0x16735C8
	private bool CreateAndAddChildNode(Stream secData, Int64 offset) { }

	// RVA: 0x16730C8
	private bool ListDecodeIndefiniteLength(Stream xdata, Int64 start, Int64 childNodeMaxLen) { }

	// RVA: 0x1673770
	private bool ListDecodeIndefiniteLengthInternal(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x1673870
	private bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x167394C
	private Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(Stream xdata) { }

	// RVA: 0x16739CC
	private bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x166F070
	protected bool InternalLoadData(Stream xdata) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Parser
{
	// Fields
	private Byte[] rawData; // 0x10
	private Asn1Node rootNode; // 0x18

	// Methods

	// RVA: 0x1673B14
	public void .ctor() { }

	// RVA: 0x1673BE0
	public void LoadData(Stream stream) { }

	// RVA: 0x1673D1C
	public Asn1Node get_RootNode() { }

	// RVA: 0x1673D24
	public static string GetNodeTextHeader(int lineLen) { }

	// RVA: 0x1673F7C
	public override string ToString() { }

	// RVA: 0x1673FC8
	public static string GetNodeText(Asn1Node node, int lineLen) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Util
{
	// Fields
	private static Char[] hexDigits; // 0x0

	// Methods

	// RVA: 0x1671C48
	public static string FormatString(string inStr, int lineLen, int groupLen) { }

	// RVA: 0x166EE08
	public static string GenStr(int len, Char xch) { }

	// RVA: 0x16718E8
	public static Int64 BytesToLong(Byte[] bytes) { }

	// RVA: 0x16717DC
	public static string BytesToString(Byte[] bytes) { }

	// RVA: 0x166E2C4
	public static string ToHexString(Byte[] bytes) { }

	// RVA: 0x1674020
	public static int BytePrecision(UInt64 value) { }

	// RVA: 0x166F2DC
	public static int DERLengthEncode(Stream xdata, UInt64 length) { }

	// RVA: 0x1672538
	public static Int64 DerLengthDecode(Stream bt, bool isIndefiniteLength) { }

	// RVA: 0x166F868
	public static string GetTagName(Byte tag) { }

	// RVA: 0x1674058
	private static void .cctor() { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Oid
{
	// Fields
	private static StringDictionary oidDictionary; // 0x0

	// Methods

	// RVA: 0x1671714
	public string GetOidName(string inOidStr) { }

	// RVA: 0x16740FC
	public string Decode(Byte[] data) { }

	// RVA: 0x16741B4
	public virtual string Decode(Stream bt) { }

	// RVA: 0x167170C
	public void .ctor() { }

	// RVA: 0x167443C
	protected int DecodeValue(Stream bt, UInt64 v) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class RelativeOid
{
	// Methods

	// RVA: 0x16717D4
	public void .ctor() { }

	// RVA: 0x16744A4
	public override string Decode(Stream bt) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class AppleReceiptParser
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,System.Object> _mostRecentReceiptData; // 0x0

	// Methods

	// RVA: 0x16746DC
	public AppleReceipt Parse(Byte[] receiptData) { }

	// RVA: 0x1674700
	internal AppleReceipt Parse(Byte[] receiptData, PKCS7 receipt) { }

	// RVA: 0x1674DD0
	private static CultureInfo PushInvariantCultureOnThread() { }

	// RVA: 0x16753BC
	private static void PopCultureOffThread(CultureInfo originalCulture) { }

	// RVA: 0x1674EAC
	private AppleReceipt ParseReceipt(Asn1Node data) { }

	// RVA: 0x16753F8
	private Asn1Node GetSetNode(Asn1Node data) { }

	// RVA: 0x1675460
	private AppleInAppPurchaseReceipt ParseInAppReceipt(Asn1Node inApp) { }

	// RVA: 0x1675998
	private static DateTime TryParseDateTimeNode(Asn1Node node) { }

	// RVA: 0x30A3C14
	public static bool ArrayEquals(T[] a, T[] b) { }

	// RVA: 0x1675A8C
	public void .ctor() { }

	// RVA: 0x1675A94
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

	// RVA: 0x1675B30
	public string get_Country() { }

	// RVA: 0x1675B38
	public void set_Country(string value) { }

	// RVA: 0x1675B40
	public string get_Organization() { }

	// RVA: 0x1675B48
	public void set_Organization(string value) { }

	// RVA: 0x1675B50
	public string get_OrganizationalUnit() { }

	// RVA: 0x1675B58
	public void set_OrganizationalUnit(string value) { }

	// RVA: 0x1675B60
	public string get_Dnq() { }

	// RVA: 0x1675B68
	public void set_Dnq(string value) { }

	// RVA: 0x1675B70
	public string get_State() { }

	// RVA: 0x1675B78
	public void set_State(string value) { }

	// RVA: 0x1675B80
	public string get_CommonName() { }

	// RVA: 0x1675B88
	public void set_CommonName(string value) { }

	// RVA: 0x1675B90
	public void set_SerialNumber(string value) { }

	// RVA: 0x1675B98
	public void .ctor(Asn1Node n) { }

	// RVA: 0x1676280
	public bool Equals(DistinguishedName n2) { }

	// RVA: 0x1676328
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

	// RVA: 0x16764E0
	private void set_SerialNumber(string value) { }

	// RVA: 0x16764E8
	private void set_ValidAfter(DateTime value) { }

	// RVA: 0x16764F0
	private void set_ValidBefore(DateTime value) { }

	// RVA: 0x16764F8
	private void set_PubKey(RSAKey value) { }

	// RVA: 0x1676500
	private void set_SelfSigned(bool value) { }

	// RVA: 0x1676508
	public DistinguishedName get_Subject() { }

	// RVA: 0x1676510
	private void set_Subject(DistinguishedName value) { }

	// RVA: 0x1676518
	public DistinguishedName get_Issuer() { }

	// RVA: 0x1676520
	private void set_Issuer(DistinguishedName value) { }

	// RVA: 0x1676528
	private void set_Signature(Asn1Node value) { }

	// RVA: 0x1676530
	public void .ctor(Asn1Node n) { }

	// RVA: 0x1676560
	private void ParseNode(Asn1Node root) { }

	// RVA: 0x16768C8
	private DateTime ParseTime(Asn1Node n) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidTimeFormat
{
	// Methods

	// RVA: 0x1676B40
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidX509Data
{
	// Methods

	// RVA: 0x16761EC
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

	// RVA: 0x1676B48
	public Asn1Node get_data() { }

	// RVA: 0x1676B50
	private void set_data(Asn1Node value) { }

	// RVA: 0x1676B58
	public System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> get_sinfos() { }

	// RVA: 0x1676B60
	private void set_sinfos(System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> value) { }

	// RVA: 0x1676B68
	public System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> get_certChain() { }

	// RVA: 0x1676B70
	private void set_certChain(System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> value) { }

	// RVA: 0x1674E70
	public void .ctor(Asn1Node node) { }

	// RVA: 0x1676B78
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

	// RVA: 0x1677234
	public int get_Version() { }

	// RVA: 0x167723C
	private void set_Version(int value) { }

	// RVA: 0x1677244
	private void set_IssuerSerialNumber(string value) { }

	// RVA: 0x167724C
	private void set_EncryptedDigest(Byte[] value) { }

	// RVA: 0x1677028
	public void .ctor(Asn1Node n) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidPKCS7Data
{
	// Methods

	// RVA: 0x16753F0
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class UnsupportedSignerInfoVersion
{
	// Methods

	// RVA: 0x1677254
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
internal class RSAKey
{
	// Fields
	private RSACryptoServiceProvider <rsa>k__BackingField; // 0x10

	// Methods

	// RVA: 0x167725C
	private void set_rsa(RSACryptoServiceProvider value) { }

	// RVA: 0x1676B00
	public void .ctor(Asn1Node n) { }

	// RVA: 0x1677264
	private RSACryptoServiceProvider ParseNode(Asn1Node n) { }

	// RVA: 0x1677500
	private string ToXML(string modulus, string exponent) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidRSAData
{
	// Methods

	// RVA: 0x1677648
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

	// RVA: 0x16761F4
	internal static UInt32 ComputeStringHash(string s) { }

}


