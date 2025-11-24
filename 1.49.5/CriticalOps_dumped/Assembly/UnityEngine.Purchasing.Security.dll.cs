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

	// RVA: 0x167D04C
	private void .ctor(Asn1Node parentNode, Int64 dataOffset) { }

	// RVA: 0x167D100
	private void Init() { }

	// RVA: 0x167D1C4
	private string GetHexPrintingStr(Asn1Node startNode, string baseLine, string lStr, int lineLen) { }

	// RVA: 0x167DBB0
	private string FormatLineString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x167D76C
	private string FormatLineHexString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x167E16C
	public void .ctor() { }

	// RVA: 0x167E1EC
	public bool get_IsIndefiniteLength() { }

	// RVA: 0x167E1F4
	public Byte get_Tag() { }

	// RVA: 0x167E1FC
	public Byte get_MaskedTag() { }

	// RVA: 0x167E208
	public bool LoadData(Stream xdata) { }

	// RVA: 0x167E3B4
	public bool SaveData(Stream xdata) { }

	// RVA: 0x167E778
	public void ClearAll() { }

	// RVA: 0x167E924
	public void AddChild(Asn1Node xdata) { }

	// RVA: 0x167E9A0
	private Asn1Node GetLastChild() { }

	// RVA: 0x167E51C
	public Int64 get_ChildNodeCount() { }

	// RVA: 0x167E6A0
	public Asn1Node GetChildNode(int index) { }

	// RVA: 0x167EA50
	public string get_TagName() { }

	// RVA: 0x167EEF0
	public Asn1Node get_ParentNode() { }

	// RVA: 0x167EEF8
	public string GetText(Asn1Node startNode, int lineLen) { }

	// RVA: 0x1680CC4
	public string GetDataStr(bool pureHexMode) { }

	// RVA: 0x1681114
	public Int64 get_DataLength() { }

	// RVA: 0x168111C
	public Byte[] get_Data() { }

	// RVA: 0x16812A4
	public Int64 get_Deepness() { }

	// RVA: 0x16812AC
	protected void set_RequireRecalculatePar(bool value) { }

	// RVA: 0x167E8C4
	protected void RecalculateTreePar() { }

	// RVA: 0x16812B4
	protected static Int64 ResetBranchDataLength(Asn1Node node) { }

	// RVA: 0x16814D0
	protected static void ResetDataLengthFieldWidth(Asn1Node node) { }

	// RVA: 0x1681398
	protected void ResetChildNodePar(Asn1Node xNode, Int64 subOffset) { }

	// RVA: 0x1680BA8
	protected string GetListStr(Asn1Node startNode, int lineLen) { }

	// RVA: 0x167D490
	protected string GetIndentStr(Asn1Node startNode) { }

	// RVA: 0x1681594
	protected bool GeneralDecode(Stream xdata) { }

	// RVA: 0x168187C
	private bool AreTagsOk() { }

	// RVA: 0x1681A58
	private bool GeneralDecodeKnownLengthWithChecks(Stream xdata, Int64 start, Int64 nodeMaxLen) { }

	// RVA: 0x1681AE0
	private bool IsGeneralStreamLengthOk(Stream xdata, Int64 start, Int64 nodeMaxLen) { }

	// RVA: 0x1681B64
	private bool GeneralDecodeKnownLength(Stream xdata) { }

	// RVA: 0x1681CBC
	private void ReadStreamDataDefiniteLength(Stream xdata, int length) { }

	// RVA: 0x16818AC
	private bool GeneralDecodeIndefiniteLength(Stream xdata, Int64 nodeMaxLen) { }

	// RVA: 0x1681D58
	private bool ReadStreamDataIndefiniteLength(Stream xdata, Int64 nodeMaxLen) { }

	// RVA: 0x1681E5C
	private Int64 MeasureContentLength(Stream xdata) { }

	// RVA: 0x1681EF4
	private void ReadMeasuredLengthDataFromStart(Stream xdata, Int64 startPosition, Int64 length) { }

	// RVA: 0x1681FBC
	protected bool ListDecode(Stream xdata) { }

	// RVA: 0x16823DC
	private bool ListDecodeKnownLengthWithChecks(Stream xdata, Int64 start, Int64 childNodeMaxLen) { }

	// RVA: 0x16823F8
	private bool IsListStreamLengthOk(Stream xdata, Int64 childNodeMaxLen) { }

	// RVA: 0x168240C
	private bool ListDecodeKnownLength(Stream xdata, Int64 start) { }

	// RVA: 0x1682530
	private Int64 CalculateListEncodeFieldBytesAndOffset(Stream xdata, Int64 start) { }

	// RVA: 0x1682580
	private bool HandleBitStringTag(Stream xdata, Int64 offset) { }

	// RVA: 0x16825F8
	private bool ListDecodeKnownLengthInternal(Stream xdata, Int64 offset) { }

	// RVA: 0x1682688
	private Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(Stream xdata) { }

	// RVA: 0x16827B0
	private bool ListDecodeChildNodesWithKnownLength(Stream secData, Int64 offset) { }

	// RVA: 0x1682838
	private bool CreateAndAddChildNode(Stream secData, Int64 offset) { }

	// RVA: 0x1682338
	private bool ListDecodeIndefiniteLength(Stream xdata, Int64 start, Int64 childNodeMaxLen) { }

	// RVA: 0x16829E0
	private bool ListDecodeIndefiniteLengthInternal(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x1682AE0
	private bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x1682BBC
	private Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(Stream xdata) { }

	// RVA: 0x1682C3C
	private bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x167E2E0
	protected bool InternalLoadData(Stream xdata) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Parser
{
	// Fields
	private Byte[] rawData; // 0x10
	private Asn1Node rootNode; // 0x18

	// Methods

	// RVA: 0x1682D84
	public void .ctor() { }

	// RVA: 0x1682E50
	public void LoadData(Stream stream) { }

	// RVA: 0x1682F8C
	public Asn1Node get_RootNode() { }

	// RVA: 0x1682F94
	public static string GetNodeTextHeader(int lineLen) { }

	// RVA: 0x16831EC
	public override string ToString() { }

	// RVA: 0x1683238
	public static string GetNodeText(Asn1Node node, int lineLen) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Util
{
	// Fields
	private static Char[] hexDigits; // 0x0

	// Methods

	// RVA: 0x1680EB8
	public static string FormatString(string inStr, int lineLen, int groupLen) { }

	// RVA: 0x167E078
	public static string GenStr(int len, Char xch) { }

	// RVA: 0x1680B58
	public static Int64 BytesToLong(Byte[] bytes) { }

	// RVA: 0x1680A4C
	public static string BytesToString(Byte[] bytes) { }

	// RVA: 0x167D534
	public static string ToHexString(Byte[] bytes) { }

	// RVA: 0x1683290
	public static int BytePrecision(UInt64 value) { }

	// RVA: 0x167E54C
	public static int DERLengthEncode(Stream xdata, UInt64 length) { }

	// RVA: 0x16817A8
	public static Int64 DerLengthDecode(Stream bt, bool isIndefiniteLength) { }

	// RVA: 0x167EAD8
	public static string GetTagName(Byte tag) { }

	// RVA: 0x16832C8
	private static void .cctor() { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Oid
{
	// Fields
	private static StringDictionary oidDictionary; // 0x0

	// Methods

	// RVA: 0x1680984
	public string GetOidName(string inOidStr) { }

	// RVA: 0x168336C
	public string Decode(Byte[] data) { }

	// RVA: 0x1683424
	public virtual string Decode(Stream bt) { }

	// RVA: 0x168097C
	public void .ctor() { }

	// RVA: 0x16836AC
	protected int DecodeValue(Stream bt, UInt64 v) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class RelativeOid
{
	// Methods

	// RVA: 0x1680A44
	public void .ctor() { }

	// RVA: 0x1683714
	public override string Decode(Stream bt) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class AppleReceiptParser
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,System.Object> _mostRecentReceiptData; // 0x0

	// Methods

	// RVA: 0x168394C
	public AppleReceipt Parse(Byte[] receiptData) { }

	// RVA: 0x1683970
	internal AppleReceipt Parse(Byte[] receiptData, PKCS7 receipt) { }

	// RVA: 0x1684040
	private static CultureInfo PushInvariantCultureOnThread() { }

	// RVA: 0x168462C
	private static void PopCultureOffThread(CultureInfo originalCulture) { }

	// RVA: 0x168411C
	private AppleReceipt ParseReceipt(Asn1Node data) { }

	// RVA: 0x1684668
	private Asn1Node GetSetNode(Asn1Node data) { }

	// RVA: 0x16846D0
	private AppleInAppPurchaseReceipt ParseInAppReceipt(Asn1Node inApp) { }

	// RVA: 0x1684C08
	private static DateTime TryParseDateTimeNode(Asn1Node node) { }

	// RVA: 0x30B410C
	public static bool ArrayEquals(T[] a, T[] b) { }

	// RVA: 0x1684CFC
	public void .ctor() { }

	// RVA: 0x1684D04
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

	// RVA: 0x1684DA0
	public string get_Country() { }

	// RVA: 0x1684DA8
	public void set_Country(string value) { }

	// RVA: 0x1684DB0
	public string get_Organization() { }

	// RVA: 0x1684DB8
	public void set_Organization(string value) { }

	// RVA: 0x1684DC0
	public string get_OrganizationalUnit() { }

	// RVA: 0x1684DC8
	public void set_OrganizationalUnit(string value) { }

	// RVA: 0x1684DD0
	public string get_Dnq() { }

	// RVA: 0x1684DD8
	public void set_Dnq(string value) { }

	// RVA: 0x1684DE0
	public string get_State() { }

	// RVA: 0x1684DE8
	public void set_State(string value) { }

	// RVA: 0x1684DF0
	public string get_CommonName() { }

	// RVA: 0x1684DF8
	public void set_CommonName(string value) { }

	// RVA: 0x1684E00
	public void set_SerialNumber(string value) { }

	// RVA: 0x1684E08
	public void .ctor(Asn1Node n) { }

	// RVA: 0x16854F0
	public bool Equals(DistinguishedName n2) { }

	// RVA: 0x1685598
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

	// RVA: 0x1685750
	private void set_SerialNumber(string value) { }

	// RVA: 0x1685758
	private void set_ValidAfter(DateTime value) { }

	// RVA: 0x1685760
	private void set_ValidBefore(DateTime value) { }

	// RVA: 0x1685768
	private void set_PubKey(RSAKey value) { }

	// RVA: 0x1685770
	private void set_SelfSigned(bool value) { }

	// RVA: 0x1685778
	public DistinguishedName get_Subject() { }

	// RVA: 0x1685780
	private void set_Subject(DistinguishedName value) { }

	// RVA: 0x1685788
	public DistinguishedName get_Issuer() { }

	// RVA: 0x1685790
	private void set_Issuer(DistinguishedName value) { }

	// RVA: 0x1685798
	private void set_Signature(Asn1Node value) { }

	// RVA: 0x16857A0
	public void .ctor(Asn1Node n) { }

	// RVA: 0x16857D0
	private void ParseNode(Asn1Node root) { }

	// RVA: 0x1685B38
	private DateTime ParseTime(Asn1Node n) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidTimeFormat
{
	// Methods

	// RVA: 0x1685DB0
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidX509Data
{
	// Methods

	// RVA: 0x168545C
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

	// RVA: 0x1685DB8
	public Asn1Node get_data() { }

	// RVA: 0x1685DC0
	private void set_data(Asn1Node value) { }

	// RVA: 0x1685DC8
	public System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> get_sinfos() { }

	// RVA: 0x1685DD0
	private void set_sinfos(System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> value) { }

	// RVA: 0x1685DD8
	public System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> get_certChain() { }

	// RVA: 0x1685DE0
	private void set_certChain(System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> value) { }

	// RVA: 0x16840E0
	public void .ctor(Asn1Node node) { }

	// RVA: 0x1685DE8
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

	// RVA: 0x16864A4
	public int get_Version() { }

	// RVA: 0x16864AC
	private void set_Version(int value) { }

	// RVA: 0x16864B4
	private void set_IssuerSerialNumber(string value) { }

	// RVA: 0x16864BC
	private void set_EncryptedDigest(Byte[] value) { }

	// RVA: 0x1686298
	public void .ctor(Asn1Node n) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidPKCS7Data
{
	// Methods

	// RVA: 0x1684660
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class UnsupportedSignerInfoVersion
{
	// Methods

	// RVA: 0x16864C4
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
internal class RSAKey
{
	// Fields
	private RSACryptoServiceProvider <rsa>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16864CC
	private void set_rsa(RSACryptoServiceProvider value) { }

	// RVA: 0x1685D70
	public void .ctor(Asn1Node n) { }

	// RVA: 0x16864D4
	private RSACryptoServiceProvider ParseNode(Asn1Node n) { }

	// RVA: 0x1686770
	private string ToXML(string modulus, string exponent) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidRSAData
{
	// Methods

	// RVA: 0x16868B8
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

	// RVA: 0x1685464
	internal static UInt32 ComputeStringHash(string s) { }

}


