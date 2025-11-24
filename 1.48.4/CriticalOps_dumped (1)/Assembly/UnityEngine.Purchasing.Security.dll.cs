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

	// RVA: 0x1588DF8
	void .ctor(Asn1Node parentNode, Int64 dataOffset) { }

	// RVA: 0x1588EAC
	void Init() { }

	// RVA: 0x1588F70
	string GetHexPrintingStr(Asn1Node startNode, string baseLine, string lStr, int lineLen) { }

	// RVA: 0x158995C
	string FormatLineString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x1589518
	string FormatLineHexString(string lStr, int indent, int lineLen, string msg) { }

	// RVA: 0x1589F18
	void .ctor() { }

	// RVA: 0x1589F98
	bool get_IsIndefiniteLength() { }

	// RVA: 0x1589FA0
	Byte get_Tag() { }

	// RVA: 0x1589FA8
	Byte get_MaskedTag() { }

	// RVA: 0x1589FB4
	bool LoadData(Stream xdata) { }

	// RVA: 0x158A160
	bool SaveData(Stream xdata) { }

	// RVA: 0x158A524
	void ClearAll() { }

	// RVA: 0x158A6D0
	void AddChild(Asn1Node xdata) { }

	// RVA: 0x158A74C
	Asn1Node GetLastChild() { }

	// RVA: 0x158A2C8
	Int64 get_ChildNodeCount() { }

	// RVA: 0x158A44C
	Asn1Node GetChildNode(int index) { }

	// RVA: 0x158A7FC
	string get_TagName() { }

	// RVA: 0x158AC9C
	Asn1Node get_ParentNode() { }

	// RVA: 0x158ACA4
	string GetText(Asn1Node startNode, int lineLen) { }

	// RVA: 0x158CA70
	string GetDataStr(bool pureHexMode) { }

	// RVA: 0x158CEC0
	Int64 get_DataLength() { }

	// RVA: 0x158CEC8
	Byte[] get_Data() { }

	// RVA: 0x158D050
	Int64 get_Deepness() { }

	// RVA: 0x158D058
	void set_RequireRecalculatePar(bool value) { }

	// RVA: 0x158A670
	void RecalculateTreePar() { }

	// RVA: 0x158D060
	Int64 ResetBranchDataLength(Asn1Node node) { }

	// RVA: 0x158D27C
	void ResetDataLengthFieldWidth(Asn1Node node) { }

	// RVA: 0x158D144
	void ResetChildNodePar(Asn1Node xNode, Int64 subOffset) { }

	// RVA: 0x158C954
	string GetListStr(Asn1Node startNode, int lineLen) { }

	// RVA: 0x158923C
	string GetIndentStr(Asn1Node startNode) { }

	// RVA: 0x158D340
	bool GeneralDecode(Stream xdata) { }

	// RVA: 0x158D628
	bool AreTagsOk() { }

	// RVA: 0x158D804
	bool GeneralDecodeKnownLengthWithChecks(Stream xdata, Int64 start, Int64 nodeMaxLen) { }

	// RVA: 0x158D88C
	bool IsGeneralStreamLengthOk(Stream xdata, Int64 start, Int64 nodeMaxLen) { }

	// RVA: 0x158D910
	bool GeneralDecodeKnownLength(Stream xdata) { }

	// RVA: 0x158DA68
	void ReadStreamDataDefiniteLength(Stream xdata, int length) { }

	// RVA: 0x158D658
	bool GeneralDecodeIndefiniteLength(Stream xdata, Int64 nodeMaxLen) { }

	// RVA: 0x158DB04
	bool ReadStreamDataIndefiniteLength(Stream xdata, Int64 nodeMaxLen) { }

	// RVA: 0x158DC08
	Int64 MeasureContentLength(Stream xdata) { }

	// RVA: 0x158DCA0
	void ReadMeasuredLengthDataFromStart(Stream xdata, Int64 startPosition, Int64 length) { }

	// RVA: 0x158DD68
	bool ListDecode(Stream xdata) { }

	// RVA: 0x158E188
	bool ListDecodeKnownLengthWithChecks(Stream xdata, Int64 start, Int64 childNodeMaxLen) { }

	// RVA: 0x158E1A4
	bool IsListStreamLengthOk(Stream xdata, Int64 childNodeMaxLen) { }

	// RVA: 0x158E1B8
	bool ListDecodeKnownLength(Stream xdata, Int64 start) { }

	// RVA: 0x158E2DC
	Int64 CalculateListEncodeFieldBytesAndOffset(Stream xdata, Int64 start) { }

	// RVA: 0x158E32C
	bool HandleBitStringTag(Stream xdata, ref Int64 offset) { }

	// RVA: 0x158E3A4
	bool ListDecodeKnownLengthInternal(Stream xdata, Int64 offset) { }

	// RVA: 0x158E434
	Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(Stream xdata) { }

	// RVA: 0x158E55C
	bool ListDecodeChildNodesWithKnownLength(Stream secData, Int64 offset) { }

	// RVA: 0x158E5E4
	bool CreateAndAddChildNode(Stream secData, ref Int64 offset) { }

	// RVA: 0x158E0E4
	bool ListDecodeIndefiniteLength(Stream xdata, Int64 start, Int64 childNodeMaxLen) { }

	// RVA: 0x158E78C
	bool ListDecodeIndefiniteLengthInternal(Stream xdata, Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x158E88C
	bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(Stream xdata, ref Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x158E968
	Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(Stream xdata) { }

	// RVA: 0x158E9E8
	bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(Stream xdata, ref Int64 offset, Int64 childNodeMaxLen) { }

	// RVA: 0x158A08C
	bool InternalLoadData(Stream xdata) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Parser 
{
	// Fields
	private Byte[] rawData; // 0x10
	private Asn1Node rootNode; // 0x18

	// Methods

	// RVA: 0x158EB30
	void .ctor() { }

	// RVA: 0x158EBFC
	void LoadData(Stream stream) { }

	// RVA: 0x158ED38
	Asn1Node get_RootNode() { }

	// RVA: 0x158ED40
	string GetNodeTextHeader(int lineLen) { }

	// RVA: 0x158EF98
	string ToString() { }

	// RVA: 0x158EFE4
	string GetNodeText(Asn1Node node, int lineLen) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Asn1Util 
{
	// Fields
	private static Char[] hexDigits; // 0x0

	// Methods

	// RVA: 0x158CC64
	string FormatString(string inStr, int lineLen, int groupLen) { }

	// RVA: 0x1589E24
	string GenStr(int len, Char xch) { }

	// RVA: 0x158C904
	Int64 BytesToLong(Byte[] bytes) { }

	// RVA: 0x158C7F8
	string BytesToString(Byte[] bytes) { }

	// RVA: 0x15892E0
	string ToHexString(Byte[] bytes) { }

	// RVA: 0x158F03C
	int BytePrecision(UInt64 value) { }

	// RVA: 0x158A2F8
	int DERLengthEncode(Stream xdata, UInt64 length) { }

	// RVA: 0x158D554
	Int64 DerLengthDecode(Stream bt, ref bool isIndefiniteLength) { }

	// RVA: 0x158A884
	string GetTagName(Byte tag) { }

	// RVA: 0x158F074
	void .cctor() { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class Oid 
{
	// Fields
	private static StringDictionary oidDictionary; // 0x0

	// Methods

	// RVA: 0x158C730
	string GetOidName(string inOidStr) { }

	// RVA: 0x158F118
	string Decode(Byte[] data) { }

	// RVA: 0x158F1D0
	string Decode(Stream bt) { }

	// RVA: 0x158C728
	void .ctor() { }

	// RVA: 0x158F458
	int DecodeValue(Stream bt, ref UInt64 v) { }

}

// Namespace: LipingShare.LCLib.Asn1Processor
internal class RelativeOid 
{
	// Methods

	// RVA: 0x158C7F0
	void .ctor() { }

	// RVA: 0x158F4C0
	string Decode(Stream bt) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class AppleReceiptParser 
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,System.Object> _mostRecentReceiptData; // 0x0

	// Methods

	// RVA: 0x158F6F8
	AppleReceipt Parse(Byte[] receiptData) { }

	// RVA: 0x158F71C
	AppleReceipt Parse(Byte[] receiptData, out PKCS7 receipt) { }

	// RVA: 0x158FDEC
	CultureInfo PushInvariantCultureOnThread() { }

	// RVA: 0x15903D8
	void PopCultureOffThread(CultureInfo originalCulture) { }

	// RVA: 0x158FEC8
	AppleReceipt ParseReceipt(Asn1Node data) { }

	// RVA: 0x1590414
	Asn1Node GetSetNode(Asn1Node data) { }

	// RVA: 0x159047C
	AppleInAppPurchaseReceipt ParseInAppReceipt(Asn1Node inApp) { }

	// RVA: 0x15909B4
	DateTime TryParseDateTimeNode(Asn1Node node) { }

	// RVA: 0x2FE59C8
	bool ArrayEquals(T[] a, T[] b) { }

	// RVA: 0x1590AA8
	void .ctor() { }

	// RVA: 0x1590AB0
	void .cctor() { }

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

	// RVA: 0x1590B4C
	string get_Country() { }

	// RVA: 0x1590B54
	void set_Country(string value) { }

	// RVA: 0x1590B5C
	string get_Organization() { }

	// RVA: 0x1590B64
	void set_Organization(string value) { }

	// RVA: 0x1590B6C
	string get_OrganizationalUnit() { }

	// RVA: 0x1590B74
	void set_OrganizationalUnit(string value) { }

	// RVA: 0x1590B7C
	string get_Dnq() { }

	// RVA: 0x1590B84
	void set_Dnq(string value) { }

	// RVA: 0x1590B8C
	string get_State() { }

	// RVA: 0x1590B94
	void set_State(string value) { }

	// RVA: 0x1590B9C
	string get_CommonName() { }

	// RVA: 0x1590BA4
	void set_CommonName(string value) { }

	// RVA: 0x1590BAC
	void set_SerialNumber(string value) { }

	// RVA: 0x1590BB4
	void .ctor(Asn1Node n) { }

	// RVA: 0x159129C
	bool Equals(DistinguishedName n2) { }

	// RVA: 0x1591344
	string ToString() { }

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

	// RVA: 0x15914FC
	void set_SerialNumber(string value) { }

	// RVA: 0x1591504
	void set_ValidAfter(DateTime value) { }

	// RVA: 0x159150C
	void set_ValidBefore(DateTime value) { }

	// RVA: 0x1591514
	void set_PubKey(RSAKey value) { }

	// RVA: 0x159151C
	void set_SelfSigned(bool value) { }

	// RVA: 0x1591524
	DistinguishedName get_Subject() { }

	// RVA: 0x159152C
	void set_Subject(DistinguishedName value) { }

	// RVA: 0x1591534
	DistinguishedName get_Issuer() { }

	// RVA: 0x159153C
	void set_Issuer(DistinguishedName value) { }

	// RVA: 0x1591544
	void set_Signature(Asn1Node value) { }

	// RVA: 0x159154C
	void .ctor(Asn1Node n) { }

	// RVA: 0x159157C
	void ParseNode(Asn1Node root) { }

	// RVA: 0x15918E4
	DateTime ParseTime(Asn1Node n) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidTimeFormat 
{
	// Methods

	// RVA: 0x1591B5C
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidX509Data 
{
	// Methods

	// RVA: 0x1591208
	void .ctor() { }

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

	// RVA: 0x1591B64
	Asn1Node get_data() { }

	// RVA: 0x1591B6C
	void set_data(Asn1Node value) { }

	// RVA: 0x1591B74
	System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> get_sinfos() { }

	// RVA: 0x1591B7C
	void set_sinfos(System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> value) { }

	// RVA: 0x1591B84
	System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> get_certChain() { }

	// RVA: 0x1591B8C
	void set_certChain(System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> value) { }

	// RVA: 0x158FE8C
	void .ctor(Asn1Node node) { }

	// RVA: 0x1591B94
	void CheckStructure() { }

}

// Namespace: UnityEngine.Purchasing.Security
internal class SignerInfo 
{
	// Fields
	private int <Version>k__BackingField; // 0x10
	private string <IssuerSerialNumber>k__BackingField; // 0x18
	private Byte[] <EncryptedDigest>k__BackingField; // 0x20

	// Methods

	// RVA: 0x1592250
	int get_Version() { }

	// RVA: 0x1592258
	void set_Version(int value) { }

	// RVA: 0x1592260
	void set_IssuerSerialNumber(string value) { }

	// RVA: 0x1592268
	void set_EncryptedDigest(Byte[] value) { }

	// RVA: 0x1592044
	void .ctor(Asn1Node n) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidPKCS7Data 
{
	// Methods

	// RVA: 0x159040C
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class UnsupportedSignerInfoVersion 
{
	// Methods

	// RVA: 0x1592270
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
internal class RSAKey 
{
	// Fields
	private RSACryptoServiceProvider <rsa>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1592278
	void set_rsa(RSACryptoServiceProvider value) { }

	// RVA: 0x1591B1C
	void .ctor(Asn1Node n) { }

	// RVA: 0x1592280
	RSACryptoServiceProvider ParseNode(Asn1Node n) { }

	// RVA: 0x159251C
	string ToXML(string modulus, string exponent) { }

}

// Namespace: UnityEngine.Purchasing.Security
public class InvalidRSAData 
{
	// Methods

	// RVA: 0x1592664
	void .ctor() { }

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

	// RVA: 0x1591210
	UInt32 ComputeStringHash(string s) { }

}


