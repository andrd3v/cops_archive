// Namespace: 
internal class <Module> 
{}

// Namespace: 
internal sealed class Locale 
{
	// Methods

	// RVA: 0x9F17D0
	string GetText(string msg) { }

	// RVA: 0x9F17D4
	string GetText(string fmt, object[] args) { }

}

// Namespace: Mono.Security
public class ASN1 
{
	// Fields
	private Byte m_nTag; // 0x10
	private Byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Methods

	// RVA: 0x9F17DC
	void .ctor(Byte tag) { }

	// RVA: 0x9F1814
	void .ctor(Byte tag, Byte[] data) { }

	// RVA: 0x9F1858
	void .ctor(Byte[] data) { }

	// RVA: 0x9F1B7C
	int get_Count() { }

	// RVA: 0x9F1B98
	Byte get_Tag() { }

	// RVA: 0x9F1BA0
	int get_Length() { }

	// RVA: 0x9F1BB8
	Byte[] get_Value() { }

	// RVA: 0x9F1C4C
	void set_Value(Byte[] value) { }

	// RVA: 0x9F1D1C
	bool CompareArray(Byte[] array1, Byte[] array2) { }

	// RVA: 0x9F1D90
	bool CompareValue(Byte[] value) { }

	// RVA: 0x9F1E10
	ASN1 Add(ASN1 asn1) { }

	// RVA: 0x9F1EB4
	Byte[] GetBytes() { }

	// RVA: 0x9F19DC
	void Decode(Byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x9F2594
	void DecodeTLV(Byte[] asn1, ref int pos, out Byte tag, out int length, out Byte[] content) { }

	// RVA: 0x9F26C8
	ASN1 get_Item(int index) { }

	// RVA: 0x9F2820
	ASN1 Element(int index, Byte anTag) { }

	// RVA: 0x9F29A8
	string ToString() { }

}

// Namespace: Mono.Security
public static class ASN1Convert 
{
	// Methods

	// RVA: 0x9F2D84
	ASN1 FromInt32(int value) { }

	// RVA: 0x9F2F24
	ASN1 FromOid(string oid) { }

	// RVA: 0x9F3000
	ASN1 FromUnsignedBigInteger(Byte[] big) { }

	// RVA: 0x9F3120
	int ToInt32(ASN1 asn1) { }

	// RVA: 0x9F3300
	string ToOid(ASN1 asn1) { }

	// RVA: 0x9F35F8
	DateTime ToDateTime(ASN1 time) { }

}

// Namespace: Mono.Security
internal sealed class BitConverterLE 
{
	// Methods

	// RVA: 0x9F3C18
	Byte[] GetUIntBytes(Byte* bytes) { }

	// RVA: 0x9F3CBC
	Byte[] GetULongBytes(Byte* bytes) { }

	// RVA: 0x9F2F00
	Byte[] GetBytes(int value) { }

	// RVA: 0x9F3DA0
	Byte[] GetBytes(Int64 value) { }

	// RVA: 0x9F3DC4
	void UShortFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	// RVA: 0x9F3E14
	void UIntFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	// RVA: 0x9F3E9C
	int ToInt32(Byte[] value, int startIndex) { }

	// RVA: 0x9F3ECC
	UInt16 ToUInt16(Byte[] value, int startIndex) { }

	// RVA: 0x9F3F28
	UInt32 ToUInt32(Byte[] value, int startIndex) { }

}

// Namespace: 
public class ContentInfo 
{
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Methods

	// RVA: 0x9F3F58
	void .ctor() { }

	// RVA: 0x9F3FE8
	void .ctor(string oid) { }

	// RVA: 0x9F408C
	void .ctor(Byte[] data) { }

	// RVA: 0x9F40F8
	void .ctor(ASN1 asn1) { }

	// RVA: 0x9F4298
	ASN1 get_ASN1() { }

	// RVA: 0x9F4448
	ASN1 get_Content() { }

	// RVA: 0x9F4450
	void set_Content(ASN1 value) { }

	// RVA: 0x9F4458
	string get_ContentType() { }

	// RVA: 0x9F4460
	void set_ContentType(string value) { }

	// RVA: 0x9F429C
	ASN1 GetASN1() { }

}

// Namespace: 
public class EncryptedData 
{
	// Fields
	private Byte _version; // 0x10
	private ContentInfo _content; // 0x18
	private ContentInfo _encryptionAlgorithm; // 0x20
	private Byte[] _encrypted; // 0x28

	// Methods

	// RVA: 0x9F4468
	void .ctor() { }

	// RVA: 0x9F4490
	void .ctor(ASN1 asn1) { }

	// RVA: 0x9F4854
	ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x9F485C
	Byte[] get_EncryptedContent() { }

}

// Namespace: 
public class SignedData 
{
	// Fields
	private Byte version; // 0x10
	private string hashAlgorithm; // 0x18
	private ContentInfo contentInfo; // 0x20
	private X509CertificateCollection certs; // 0x28
	private ArrayList crls; // 0x30
	private SignerInfo signerInfo; // 0x38
	private bool mda; // 0x40

	// Methods

	// RVA: 0x9F48D4
	void .ctor(ASN1 asn1) { }

	// RVA: 0x9F58FC
	X509CertificateCollection get_Certificates() { }

	// RVA: 0x9F5904
	ContentInfo get_ContentInfo() { }

	// RVA: 0x9F58BC
	void set_HashName(string value) { }

	// RVA: 0x9F590C
	SignerInfo get_SignerInfo() { }

	// RVA: 0x9F56B0
	string OidToName(string oid) { }

}

// Namespace: 
public class SignerInfo 
{
	// Fields
	private Byte version; // 0x10
	private string hashAlgorithm; // 0x18
	private ArrayList authenticatedAttributes; // 0x20
	private ArrayList unauthenticatedAttributes; // 0x28
	private Byte[] signature; // 0x30
	private string issuer; // 0x38
	private Byte[] serial; // 0x40
	private Byte[] ski; // 0x48

	// Methods

	// RVA: 0x9F560C
	void .ctor() { }

	// RVA: 0x9F5098
	void .ctor(ASN1 asn1) { }

	// RVA: 0x9F5B10
	string get_IssuerName() { }

	// RVA: 0x9F5B18
	Byte[] get_SerialNumber() { }

	// RVA: 0x9F5B90
	ArrayList get_AuthenticatedAttributes() { }

	// RVA: 0x9F5B98
	string get_HashName() { }

	// RVA: 0x9F5BA0
	void set_HashName(string value) { }

	// RVA: 0x9F5BA8
	Byte[] get_Signature() { }

	// RVA: 0x9F5C20
	ArrayList get_UnauthenticatedAttributes() { }

	// RVA: 0x9F5C28
	Byte get_Version() { }

}

// Namespace: Mono.Security
public sealed class PKCS7 
{}

// Namespace: Mono.Security.X509
internal class SafeBag 
{
	// Fields
	private string _bagOID; // 0x10
	private ASN1 _asn1; // 0x18

	// Methods

	// RVA: 0x9F5C30
	void .ctor(string bagOID, ASN1 asn1) { }

	// RVA: 0x9F5C80
	string get_BagOID() { }

	// RVA: 0x9F5C88
	ASN1 get_ASN1() { }

}

// Namespace: 
public class DeriveBytes 
{
	// Fields
	private static Byte[] keyDiversifier; // 0x0
	private static Byte[] ivDiversifier; // 0x8
	private static Byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private Byte[] _password; // 0x20
	private Byte[] _salt; // 0x28

	// Methods

	// RVA: 0x9F8F6C
	void .ctor() { }

	// RVA: 0xA00CB0
	void set_HashName(string value) { }

	// RVA: 0xA00CB8
	void set_IterationCount(int value) { }

	// RVA: 0x9F8F74
	void set_Password(Byte[] value) { }

	// RVA: 0x9F905C
	void set_Salt(Byte[] value) { }

	// RVA: 0xA00CC0
	void Adjust(Byte[] a, int aOff, Byte[] b) { }

	// RVA: 0xA00D78
	Byte[] Derive(Byte[] diversifier, int n) { }

	// RVA: 0x9F9138
	Byte[] DeriveKey(int size) { }

	// RVA: 0x9F91AC
	Byte[] DeriveIV(int size) { }

	// RVA: 0x9FC51C
	Byte[] DeriveMAC(int size) { }

	// RVA: 0xA01340
	void .cctor() { }

}

// Namespace: Mono.Security.X509
public class PKCS12 
{
	// Fields
	private Byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Methods

	// RVA: 0x9F5C90
	void .ctor() { }

	// RVA: 0x9F5D98
	void .ctor(Byte[] data) { }

	// RVA: 0x9F6AE8
	void .ctor(Byte[] data, string password) { }

	// RVA: 0x9F6058
	void Decode(Byte[] data) { }

	// RVA: 0x9F7828
	void Finalize() { }

	// RVA: 0x9F5E24
	void set_Password(string value) { }

	// RVA: 0x9F78E0
	int get_IterationCount() { }

	// RVA: 0x9F78E8
	void set_IterationCount(int value) { }

	// RVA: 0x9F78F0
	ArrayList get_Keys() { }

	// RVA: 0x9F82D4
	X509CertificateCollection get_Certificates() { }

	// RVA: 0x9F8874
	RandomNumberGenerator get_RNG() { }

	// RVA: 0x9F6CE4
	bool Compare(Byte[] expected, Byte[] actual) { }

	// RVA: 0x9F88BC
	SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, Byte[] salt, int iterationCount) { }

	// RVA: 0x9F8120
	Byte[] Decrypt(string algorithmOid, Byte[] salt, int iterationCount, Byte[] encryptedData) { }

	// RVA: 0x9F76B0
	Byte[] Decrypt(EncryptedData ed) { }

	// RVA: 0x9F9220
	Byte[] Encrypt(string algorithmOid, Byte[] salt, int iterationCount, Byte[] data) { }

	// RVA: 0x9F9430
	DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x9F9D4C
	void AddPrivateKey(PrivateKeyInfo pki) { }

	// RVA: 0x9F6D58
	void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x9F9FB4
	ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0x9FB2F8
	ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x9F6B2C
	Byte[] MAC(Byte[] password, Byte[] salt, int iterations, Byte[] data) { }

	// RVA: 0x9FC590
	Byte[] GetBytes() { }

	// RVA: 0x9FF354
	ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x9FF34C
	void AddCertificate(X509Certificate cert) { }

	// RVA: 0x9FFAC4
	void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x9FF344
	void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x9FFE8C
	void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0xA005A0
	bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2) { }

	// RVA: 0xA0064C
	void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0xA00AB0
	object Clone() { }

	// RVA: 0xA00BE4
	int get_MaximumPasswordLength() { }

	// RVA: 0xA00C60
	void .cctor() { }

}

// Namespace: Mono.Security.X509
public sealed class X501 
{
	// Fields
	private static Byte[] countryName; // 0x0
	private static Byte[] organizationName; // 0x8
	private static Byte[] organizationalUnitName; // 0x10
	private static Byte[] commonName; // 0x18
	private static Byte[] localityName; // 0x20
	private static Byte[] stateOrProvinceName; // 0x28
	private static Byte[] streetAddress; // 0x30
	private static Byte[] serialNumber; // 0x38
	private static Byte[] domainComponent; // 0x40
	private static Byte[] userid; // 0x48
	private static Byte[] email; // 0x50
	private static Byte[] dnQualifier; // 0x58
	private static Byte[] title; // 0x60
	private static Byte[] surname; // 0x68
	private static Byte[] givenName; // 0x70
	private static Byte[] initial; // 0x78

	// Methods

	// RVA: 0x9F5914
	string ToString(ASN1 seq) { }

	// RVA: 0xA020C4
	string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

	// RVA: 0xA01474
	void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	// RVA: 0xA02388
	AttributeTypeAndValue GetAttributeFromOid(string attributeType) { }

	// RVA: 0xA0369C
	bool IsOid(string oid) { }

	// RVA: 0xA03810
	AttributeTypeAndValue ReadAttribute(string value, ref int pos) { }

	// RVA: 0xA0396C
	bool IsHex(Char c) { }

	// RVA: 0xA03A80
	string ReadHex(string value, ref int pos) { }

	// RVA: 0xA03C30
	int ReadEscaped(StringBuilder sb, string value, int pos) { }

	// RVA: 0xA03DE4
	int ReadQuoted(StringBuilder sb, string value, int pos) { }

	// RVA: 0xA03F88
	string ReadValue(string value, ref int pos) { }

	// RVA: 0xA04220
	ASN1 FromString(string rdn) { }

	// RVA: 0xA04580
	void .cctor() { }

}

// Namespace: 
public class X509CrlEntry 
{
	// Fields
	private Byte[] sn; // 0x10
	private DateTime revocationDate; // 0x18
	private X509ExtensionCollection extensions; // 0x20

	// Methods

	// RVA: 0xA053A4
	void .ctor(ASN1 entry) { }

	// RVA: 0xA05B34
	Byte[] get_SerialNumber() { }

	// RVA: 0xA061F8
	DateTime get_RevocationDate() { }

	// RVA: 0xA06200
	X509ExtensionCollection get_Extensions() { }

}

// Namespace: Mono.Security.X509
public class X509Crl 
{
	// Fields
	private string issuer; // 0x10
	private Byte version; // 0x18
	private DateTime thisUpdate; // 0x20
	private DateTime nextUpdate; // 0x28
	private ArrayList entries; // 0x30
	private string signatureOID; // 0x38
	private Byte[] signature; // 0x40
	private X509ExtensionCollection extensions; // 0x48
	private Byte[] encoded; // 0x50
	private Byte[] hash_value; // 0x58

	// Methods

	// RVA: 0xA04A38
	void .ctor(Byte[] crl) { }

	// RVA: 0xA04B58
	void Parse(Byte[] crl) { }

	// RVA: 0xA05650
	X509ExtensionCollection get_Extensions() { }

	// RVA: 0xA05658
	Byte[] get_Hash() { }

	// RVA: 0xA0584C
	string get_IssuerName() { }

	// RVA: 0xA05854
	DateTime get_NextUpdate() { }

	// RVA: 0xA0585C
	bool Compare(Byte[] array1, Byte[] array2) { }

	// RVA: 0xA058C4
	X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0xA0594C
	X509CrlEntry GetCrlEntry(Byte[] serialNumber) { }

	// RVA: 0xA05BB0
	bool VerifySignature(DSA dsa) { }

	// RVA: 0xA05F88
	bool VerifySignature(RSA rsa) { }

	// RVA: 0xA06068
	bool VerifySignature(AsymmetricAlgorithm aa) { }

}

// Namespace: Mono.Security.X509
public class X509Certificate 
{
	// Fields
	private ASN1 decoder; // 0x10
	private Byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private Byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private Byte[] m_publickey; // 0x60
	private Byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private Byte[] m_signaturealgoparams; // 0x78
	private Byte[] certhash; // 0x80
	private RSA _rsa; // 0x88
	private DSA _dsa; // 0x90
	private int version; // 0x98
	private Byte[] serialnumber; // 0xA0
	private Byte[] issuerUniqueID; // 0xA8
	private Byte[] subjectUniqueID; // 0xB0
	private X509ExtensionCollection extensions; // 0xB8
	private static string encoding_error; // 0x0

	// Methods

	// RVA: 0xA06208
	void Parse(Byte[] data) { }

	// RVA: 0x9F4E7C
	void .ctor(Byte[] data) { }

	// RVA: 0xA07098
	Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	// RVA: 0x9F98C4
	DSA get_DSA() { }

	// RVA: 0xA0714C
	void set_DSA(DSA value) { }

	// RVA: 0xA07190
	X509ExtensionCollection get_Extensions() { }

	// RVA: 0xA07198
	Byte[] get_Hash() { }

	// RVA: 0xA07408
	string get_IssuerName() { }

	// RVA: 0xA07410
	string get_KeyAlgorithm() { }

	// RVA: 0xA07418
	Byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0xA07490
	void set_KeyAlgorithmParameters(Byte[] value) { }

	// RVA: 0xA07498
	Byte[] get_PublicKey() { }

	// RVA: 0xA07510
	RSA get_RSA() { }

	// RVA: 0xA076D4
	void set_RSA(RSA value) { }

	// RVA: 0xA07714
	Byte[] get_RawData() { }

	// RVA: 0xA0778C
	Byte[] get_SerialNumber() { }

	// RVA: 0xA07804
	Byte[] get_Signature() { }

	// RVA: 0xA07C74
	string get_SubjectName() { }

	// RVA: 0xA07C7C
	DateTime get_ValidFrom() { }

	// RVA: 0xA07C84
	DateTime get_ValidUntil() { }

	// RVA: 0xA07C8C
	int get_Version() { }

	// RVA: 0xA07C94
	bool get_IsCurrent() { }

	// RVA: 0xA07D00
	bool WasCurrent(DateTime instant) { }

	// RVA: 0xA07DE4
	bool VerifySignature(DSA dsa) { }

	// RVA: 0xA07EB0
	bool VerifySignature(RSA rsa) { }

	// RVA: 0xA07FDC
	bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0xA0816C
	bool get_IsSelfSigned() { }

	// RVA: 0xA08288
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xA06F54
	Byte[] PEM(string type, Byte[] data) { }

	// RVA: 0xA082F0
	void .cctor() { }

}

// Namespace: 
public class X509CertificateEnumerator 
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0xA08794
	void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x9F97C0
	X509Certificate get_Current() { }

	// RVA: 0xA08910
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xA089C8
	bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xA08A7C
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x9F9C98
	bool MoveNext() { }

}

// Namespace: Mono.Security.X509
public class X509CertificateCollection 
{
	// Methods

	// RVA: 0x9F4E74
	void .ctor() { }

	// RVA: 0xA08364
	X509Certificate get_Item(int index) { }

	// RVA: 0x9F501C
	int Add(X509Certificate value) { }

	// RVA: 0xA08408
	void AddRange(X509CertificateCollection value) { }

	// RVA: 0xA0855C
	bool Contains(X509Certificate value) { }

	// RVA: 0x9F975C
	X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0xA0885C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xA08884
	int GetHashCode() { }

	// RVA: 0xA08578
	int IndexOf(X509Certificate value) { }

	// RVA: 0xA088A8
	bool Compare(Byte[] array1, Byte[] array2) { }

}

// Namespace: Mono.Security.X509
public class X509Chain 
{
	// Fields
	private X509CertificateCollection roots; // 0x10
	private X509CertificateCollection certs; // 0x18
	private X509Certificate _root; // 0x20
	private X509CertificateCollection _chain; // 0x28
	private X509ChainStatusFlags _status; // 0x30

	// Methods

	// RVA: 0xA08B34
	void .ctor() { }

	// RVA: 0xA08BAC
	X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0xA08D40
	void LoadCertificates(X509CertificateCollection collection) { }

	// RVA: 0xA08D5C
	bool Build(X509Certificate leaf) { }

	// RVA: 0xA09C28
	void Reset() { }

	// RVA: 0xA09AF0
	bool IsValid(X509Certificate cert) { }

	// RVA: 0xA09360
	X509Certificate FindCertificateParent(X509Certificate child) { }

	// RVA: 0xA095F8
	X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	// RVA: 0xA09C88
	bool IsTrusted(X509Certificate potentialTrusted) { }

	// RVA: 0xA098EC
	bool IsParent(X509Certificate child, X509Certificate parent) { }

}

// Namespace: Mono.Security.X509
public enum X509ChainStatusFlags 
{
	// Fields
	public int value__; // 0x10
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags UntrustedRoot = 32;
}

// Namespace: Mono.Security.X509
public class X509Extension 
{
	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Methods

	// RVA: 0xA09D90
	void .ctor(ASN1 asn1) { }

	// RVA: 0xA0A1FC
	void .ctor(X509Extension extension) { }

	// RVA: 0xA0A3A0
	void Decode() { }

	// RVA: 0xA0A3A4
	void Encode() { }

	// RVA: 0xA0A3A8
	string get_Oid() { }

	// RVA: 0xA0A3B0
	bool get_Critical() { }

	// RVA: 0xA0A35C
	ASN1 get_Value() { }

	// RVA: 0xA0A3B8
	bool Equals(object obj) { }

	// RVA: 0xA0A4FC
	int GetHashCode() { }

	// RVA: 0xA0A520
	void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0xA0AD08
	string ToString() { }

}

// Namespace: Mono.Security.X509
public sealed class X509ExtensionCollection 
{
	// Fields
	private bool readOnly; // 0x18

	// Methods

	// RVA: 0xA0AE08
	void .ctor() { }

	// RVA: 0xA05514
	void .ctor(ASN1 asn1) { }

	// RVA: 0xA0AE10
	int IndexOf(string oid) { }

	// RVA: 0xA0AF4C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xA09CC0
	X509Extension get_Item(string oid) { }

}

// Namespace: Mono.Security.X509
public class X509Store 
{
	// Fields
	private string _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private bool _crl; // 0x28
	private bool _newFormat; // 0x29

	// Methods

	// RVA: 0xA0AF74
	void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0xA0AFC4
	X509CertificateCollection get_Certificates() { }

	// RVA: 0xA0B348
	ArrayList get_Crls() { }

	// RVA: 0xA0B6C4
	Byte[] Load(string filename) { }

	// RVA: 0xA0B8A8
	X509Certificate LoadCertificate(string filename) { }

	// RVA: 0xA0B918
	X509Crl LoadCrl(string filename) { }

	// RVA: 0xA0B988
	bool CheckStore(string path, bool throwException) { }

	// RVA: 0xA0B018
	X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0xA0B404
	ArrayList BuildCrlsCollection(string storeName) { }

}

// Namespace: Mono.Security.X509
public sealed class X509StoreManager 
{
	// Fields
	private static string _userPath; // 0x0
	private static string _localMachinePath; // 0x8
	private static string _newUserPath; // 0x10
	private static string _newLocalMachinePath; // 0x18
	private static X509Stores _userStore; // 0x20
	private static X509Stores _machineStore; // 0x28

	// Methods

	// RVA: 0xA0BA70
	string get_CurrentUserPath() { }

	// RVA: 0xA0BBA4
	string get_LocalMachinePath() { }

	// RVA: 0xA0BCC8
	string get_NewCurrentUserPath() { }

	// RVA: 0xA0BDEC
	string get_NewLocalMachinePath() { }

	// RVA: 0xA0BF10
	X509Stores get_CurrentUser() { }

	// RVA: 0xA0C034
	X509Stores get_LocalMachine() { }

	// RVA: 0xA08C48
	X509CertificateCollection get_TrustedRootCertificates() { }

}

// Namespace: Mono.Security.X509
public class X509Stores 
{
	// Fields
	private string _storePath; // 0x10
	private bool _newFormat; // 0x18
	private X509Store _trusted; // 0x20

	// Methods

	// RVA: 0xA0BFEC
	void .ctor(string path, bool newFormat) { }

	// RVA: 0xA0C110
	X509Store get_TrustedRoot() { }

	// RVA: 0xA0C228
	X509Store Open(string storeName, bool create) { }

}

// Namespace: 
public abstract class AttributeTypeAndValue 
{
	// Fields
	private string oid; // 0x10
	private string attrValue; // 0x18
	private int upperBound; // 0x20
	private Byte encoding; // 0x24

	// Methods

	// RVA: 0xA0C368
	void .ctor(string oid, int upperBound) { }

	// RVA: 0xA0C3B8
	void .ctor(string oid, int upperBound, Byte encoding) { }

	// RVA: 0xA044B4
	void set_Value(string value) { }

	// RVA: 0xA0C408
	ASN1 GetASN1(Byte encoding) { }

	// RVA: 0xA04578
	ASN1 GetASN1() { }

	// RVA: 0xA0C6E0
	Byte SelectBestEncoding() { }

}

// Namespace: 
public class CommonName 
{
	// Methods

	// RVA: 0xA03084
	void .ctor() { }

}

// Namespace: 
public class SerialNumber 
{
	// Methods

	// RVA: 0xA035D8
	void .ctor() { }

}

// Namespace: 
public class LocalityName 
{
	// Methods

	// RVA: 0xA03100
	void .ctor() { }

}

// Namespace: 
public class StateOrProvinceName 
{
	// Methods

	// RVA: 0xA0317C
	void .ctor() { }

}

// Namespace: 
public class OrganizationName 
{
	// Methods

	// RVA: 0xA02F8C
	void .ctor() { }

}

// Namespace: 
public class OrganizationalUnitName 
{
	// Methods

	// RVA: 0xA03008
	void .ctor() { }

}

// Namespace: 
public class EmailAddress 
{
	// Methods

	// RVA: 0xA031F8
	void .ctor() { }

}

// Namespace: 
public class DomainComponent 
{
	// Methods

	// RVA: 0xA03274
	void .ctor() { }

}

// Namespace: 
public class UserId 
{
	// Methods

	// RVA: 0xA032F0
	void .ctor() { }

}

// Namespace: 
public class Oid 
{
	// Methods

	// RVA: 0xA03654
	void .ctor(string oid) { }

}

// Namespace: 
public class Title 
{
	// Methods

	// RVA: 0xA033E8
	void .ctor() { }

}

// Namespace: 
public class CountryName 
{
	// Methods

	// RVA: 0xA02F10
	void .ctor() { }

}

// Namespace: 
public class DnQualifier 
{
	// Methods

	// RVA: 0xA0336C
	void .ctor() { }

}

// Namespace: 
public class Surname 
{
	// Methods

	// RVA: 0xA03464
	void .ctor() { }

}

// Namespace: 
public class GivenName 
{
	// Methods

	// RVA: 0xA034E0
	void .ctor() { }

}

// Namespace: 
public class Initial 
{
	// Methods

	// RVA: 0xA0355C
	void .ctor() { }

}

// Namespace: Mono.Security.X509
public class X520 
{}

// Namespace: Mono.Security.X509.Extensions
public class AuthorityKeyIdentifierExtension 
{
	// Fields
	private Byte[] aki; // 0x28

	// Methods

	// RVA: 0xA0C758
	void .ctor(X509Extension extension) { }

	// RVA: 0xA0C75C
	void Decode() { }

	// RVA: 0xA0C974
	void Encode() { }

	// RVA: 0xA0CB9C
	Byte[] get_Identifier() { }

	// RVA: 0xA0CC14
	string ToString() { }

}

// Namespace: Mono.Security.X509.Extensions
public class BasicConstraintsExtension 
{
	// Fields
	private bool cA; // 0x28
	private int pathLenConstraint; // 0x2C

	// Methods

	// RVA: 0xA09D8C
	void .ctor(X509Extension extension) { }

	// RVA: 0xA0CDA0
	void Decode() { }

	// RVA: 0xA0CFC4
	void Encode() { }

	// RVA: 0xA0D264
	bool get_CertificateAuthority() { }

	// RVA: 0xA0D26C
	string ToString() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public class ChallengeResponse 
{
	// Fields
	private static Byte[] magic; // 0x0
	private static Byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private Byte[] _challenge; // 0x18
	private Byte[] _lmpwd; // 0x20
	private Byte[] _ntpwd; // 0x28

	// Methods

	// RVA: 0xA0D418
	void .ctor() { }

	// RVA: 0xA0D4A8
	void .ctor(string password, Byte[] challenge) { }

	// RVA: 0xA0DAD8
	void Finalize() { }

	// RVA: 0xA0D560
	void set_Password(string value) { }

	// RVA: 0xA0D980
	void set_Challenge(Byte[] value) { }

	// RVA: 0xA0DD9C
	Byte[] get_LM() { }

	// RVA: 0xA0E0EC
	Byte[] get_NT() { }

	// RVA: 0xA0DB70
	void Dispose() { }

	// RVA: 0xA0E158
	void Dispose(bool disposing) { }

	// RVA: 0xA0DE08
	Byte[] GetResponse(Byte[] pwd) { }

	// RVA: 0xA0E1DC
	Byte[] PrepareDESKey(Byte[] key56bits, int position) { }

	// RVA: 0xA0DC50
	Byte[] PasswordToKey(string password, int position) { }

	// RVA: 0xA0E3D8
	void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public static class ChallengeResponse2 
{
	// Fields
	private static Byte[] magic; // 0x0
	private static Byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0xA0E4C8
	Byte[] Compute_LM(string password, Byte[] challenge) { }

	// RVA: 0xA0EC78
	Byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0xA0ED88
	Byte[] Compute_NTLM(string password, Byte[] challenge) { }

	// RVA: 0xA0EDF8
	void Compute_NTLMv2_Session(string password, Byte[] challenge, out Byte[] lm, out Byte[] ntlm) { }

	// RVA: 0xA0F030
	Byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0xA0F4AC
	void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out Byte[] lm, out Byte[] ntlm) { }

	// RVA: 0xA0E984
	Byte[] GetResponse(Byte[] challenge, Byte[] pwd) { }

	// RVA: 0xA0F758
	Byte[] PrepareDESKey(Byte[] key56bits, int position) { }

	// RVA: 0xA0E814
	Byte[] PasswordToKey(string password, int position) { }

	// RVA: 0xA0F954
	void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public abstract class MessageBase 
{
	// Fields
	private static Byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Methods

	// RVA: 0xA0FA44
	void .ctor(int messageType) { }

	// RVA: 0xA0FA70
	NtlmFlags get_Flags() { }

	// RVA: 0xA0FA78
	void set_Flags(NtlmFlags value) { }

	// RVA: 0xA0FA80
	int get_Type() { }

	// RVA: 0xA0FA88
	Byte[] PrepareMessage(int messageSize) { }

	// RVA: 0xA0FB90
	void Decode(Byte[] message) { }

	// RVA: 0xA0FD44
	bool CheckHeader(Byte[] message) { }

	// RVA: 0x2FE360C
	Byte[] GetBytes() { }

	// RVA: 0xA0FE8C
	void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public enum NtlmAuthLevel 
{
	// Fields
	public int value__; // 0x10
	public const NtlmAuthLevel LM_and_NTLM = 0;
	public const NtlmAuthLevel LM_and_NTLM_and_try_NTLMv2_Session = 1;
	public const NtlmAuthLevel NTLM_only = 2;
	public const NtlmAuthLevel NTLMv2_only = 3;
}

// Namespace: Mono.Security.Protocol.Ntlm
public enum NtlmFlags 
{
	// Fields
	public int value__; // 0x10
	public const NtlmFlags NegotiateUnicode = 1;
	public const NtlmFlags NegotiateOem = 2;
	public const NtlmFlags RequestTarget = 4;
	public const NtlmFlags NegotiateNtlm = 512;
	public const NtlmFlags NegotiateDomainSupplied = 4096;
	public const NtlmFlags NegotiateWorkstationSupplied = 8192;
	public const NtlmFlags NegotiateAlwaysSign = 32768;
	public const NtlmFlags NegotiateNtlm2Key = 524288;
	public const NtlmFlags Negotiate128 = 536870912;
	public const NtlmFlags Negotiate56 = 2147483648;
}

// Namespace: Mono.Security.Protocol.Ntlm
public static class NtlmSettings 
{
	// Fields
	private static NtlmAuthLevel defaultAuthLevel; // 0x0

	// Methods

	// RVA: 0xA0FF30
	NtlmAuthLevel get_DefaultAuthLevel() { }

	// RVA: 0xA0FFAC
	void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type1Message 
{
	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Methods

	// RVA: 0xA0FFFC
	void .ctor() { }

	// RVA: 0xA100A4
	void set_Domain(string value) { }

	// RVA: 0xA10134
	void set_Host(string value) { }

	// RVA: 0xA101C4
	void Decode(Byte[] message) { }

	// RVA: 0xA102B0
	Byte[] GetBytes() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type2Message 
{
	// Fields
	private Byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private Byte[] _targetInfo; // 0x28

	// Methods

	// RVA: 0xA10510
	void .ctor(Byte[] message) { }

	// RVA: 0xA105C4
	void Finalize() { }

	// RVA: 0xA10668
	Byte[] get_Nonce() { }

	// RVA: 0xA106E4
	string get_TargetName() { }

	// RVA: 0xA106EC
	Byte[] get_TargetInfo() { }

	// RVA: 0xA10768
	void Decode(Byte[] message) { }

	// RVA: 0xA108F4
	Byte[] GetBytes() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type3Message 
{
	// Fields
	private NtlmAuthLevel _level; // 0x18
	private Byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private Byte[] _lm; // 0x50
	private Byte[] _nt; // 0x58

	// Methods

	// RVA: 0xA109B0
	void .ctor(Type2Message type2) { }

	// RVA: 0xA10C84
	void Finalize() { }

	// RVA: 0xA10D70
	void set_Domain(string value) { }

	// RVA: 0xA10E00
	void set_Password(string value) { }

	// RVA: 0xA10E08
	void set_Username(string value) { }

	// RVA: 0xA10E10
	void Decode(Byte[] message) { }

	// RVA: 0xA110E4
	string DecodeString(Byte[] buffer, int offset, int len) { }

	// RVA: 0xA1114C
	Byte[] EncodeString(string text) { }

	// RVA: 0xA111EC
	Byte[] GetBytes() { }

}

// Namespace: Mono.Security.Interface
public enum AlertLevel 
{
	// Fields
	public Byte value__; // 0x10
	public const AlertLevel Warning = 1;
	public const AlertLevel Fatal = 2;
}

// Namespace: Mono.Security.Interface
public enum AlertDescription 
{
	// Fields
	public Byte value__; // 0x10
	public const AlertDescription CloseNotify = 0;
	public const AlertDescription UnexpectedMessage = 10;
	public const AlertDescription BadRecordMAC = 20;
	public const AlertDescription DecryptionFailed_RESERVED = 21;
	public const AlertDescription RecordOverflow = 22;
	public const AlertDescription DecompressionFailure = 30;
	public const AlertDescription HandshakeFailure = 40;
	public const AlertDescription NoCertificate_RESERVED = 41;
	public const AlertDescription BadCertificate = 42;
	public const AlertDescription UnsupportedCertificate = 43;
	public const AlertDescription CertificateRevoked = 44;
	public const AlertDescription CertificateExpired = 45;
	public const AlertDescription CertificateUnknown = 46;
	public const AlertDescription IlegalParameter = 47;
	public const AlertDescription UnknownCA = 48;
	public const AlertDescription AccessDenied = 49;
	public const AlertDescription DecodeError = 50;
	public const AlertDescription DecryptError = 51;
	public const AlertDescription ExportRestriction = 60;
	public const AlertDescription ProtocolVersion = 70;
	public const AlertDescription InsuficientSecurity = 71;
	public const AlertDescription InternalError = 80;
	public const AlertDescription UserCancelled = 90;
	public const AlertDescription NoRenegotiation = 100;
	public const AlertDescription UnsupportedExtension = 110;
}

// Namespace: Mono.Security.Interface
public class Alert 
{
	// Fields
	private AlertLevel level; // 0x10
	private AlertDescription description; // 0x11

	// Methods

	// RVA: 0xA11820
	AlertLevel get_Level() { }

	// RVA: 0xA11828
	AlertDescription get_Description() { }

	// RVA: 0xA11830
	void .ctor(AlertDescription description) { }

	// RVA: 0xA118B0
	void inferAlertLevel() { }

	// RVA: 0xA118FC
	string ToString() { }

}

// Namespace: Mono.Security.Interface
public class ValidationResult 
{
	// Fields
	private bool trusted; // 0x10
	private bool user_denied; // 0x11
	private int error_code; // 0x14
	private System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors; // 0x18

	// Methods

	// RVA: 0xA119C0
	void .ctor(bool trusted, bool user_denied, int error_code, System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0xA11A14
	bool get_Trusted() { }

	// RVA: 0xA11A1C
	bool get_UserDenied() { }

}

// Namespace: Mono.Security.Interface
public interface ICertificateValidator 
{}

// Namespace: Mono.Security.Interface
public enum CipherSuiteCode 
{
	// Fields
	public UInt16 value__; // 0x10
	public const CipherSuiteCode TLS_NULL_WITH_NULL_NULL = 0;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_MD5 = 1;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_SHA = 2;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3;
	public const CipherSuiteCode TLS_RSA_WITH_RC4_128_MD5 = 4;
	public const CipherSuiteCode TLS_RSA_WITH_RC4_128_SHA = 5;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6;
	public const CipherSuiteCode TLS_RSA_WITH_IDEA_CBC_SHA = 7;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8;
	public const CipherSuiteCode TLS_RSA_WITH_DES_CBC_SHA = 9;
	public const CipherSuiteCode TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10;
	public const CipherSuiteCode TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11;
	public const CipherSuiteCode TLS_DH_DSS_WITH_DES_CBC_SHA = 12;
	public const CipherSuiteCode TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13;
	public const CipherSuiteCode TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14;
	public const CipherSuiteCode TLS_DH_RSA_WITH_DES_CBC_SHA = 15;
	public const CipherSuiteCode TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16;
	public const CipherSuiteCode TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_DES_CBC_SHA = 18;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19;
	public const CipherSuiteCode TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_DES_CBC_SHA = 21;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22;
	public const CipherSuiteCode TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23;
	public const CipherSuiteCode TLS_DH_anon_WITH_RC4_128_MD5 = 24;
	public const CipherSuiteCode TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25;
	public const CipherSuiteCode TLS_DH_anon_WITH_DES_CBC_SHA = 26;
	public const CipherSuiteCode TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA = 47;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA = 52;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA = 53;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA = 58;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197;
	public const CipherSuiteCode TLS_RSA_WITH_SEED_CBC_SHA = 150;
	public const CipherSuiteCode TLS_DH_DSS_WITH_SEED_CBC_SHA = 151;
	public const CipherSuiteCode TLS_DH_RSA_WITH_SEED_CBC_SHA = 152;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154;
	public const CipherSuiteCode TLS_DH_anon_WITH_SEED_CBC_SHA = 155;
	public const CipherSuiteCode TLS_PSK_WITH_RC4_128_SHA = 138;
	public const CipherSuiteCode TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA = 140;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA = 141;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_RC4_128_SHA = 142;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_RC4_128_SHA = 146;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_NULL_SHA = 49163;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_NULL_SHA = 49168;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_NULL_SHA = 49173;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_RC4_128_SHA = 49174;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA = 44;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA = 45;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA = 46;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_SHA256 = 59;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA256 = 60;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA256 = 61;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_GCM_SHA256 = 156;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_GCM_SHA384 = 157;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_GCM_SHA256 = 168;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_GCM_SHA384 = 169;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA256 = 174;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA384 = 175;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA256 = 176;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA384 = 177;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA256 = 180;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA384 = 181;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA256 = 184;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA384 = 185;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA = 49209;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211;
	public const CipherSuiteCode TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CCM = 49308;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CCM = 49309;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM = 49310;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM = 49311;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CCM_8 = 49312;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CCM_8 = 49313;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CCM = 49316;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CCM = 49317;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CCM = 49318;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CCM = 49319;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CCM_8 = 49320;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CCM_8 = 49321;
	public const CipherSuiteCode TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322;
	public const CipherSuiteCode TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245;
	public const CipherSuiteCode TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384;
	public const CipherSuiteCode TLS_RSA_WITH_SALSA20_SHA1 = 58385;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389;
	public const CipherSuiteCode TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390;
	public const CipherSuiteCode TLS_PSK_WITH_SALSA20_SHA1 = 58391;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399;
	public const CipherSuiteCode TLS_FALLBACK_SCSV = 22016;
}

// Namespace: Mono.Security.Interface
public class MonoTlsConnectionInfo 
{
	// Fields
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	private string <PeerDomainName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xA11A24
	CipherSuiteCode get_CipherSuiteCode() { }

	// RVA: 0xA11A2C
	void set_CipherSuiteCode(CipherSuiteCode value) { }

	// RVA: 0xA11A34
	TlsProtocols get_ProtocolVersion() { }

	// RVA: 0xA11A3C
	void set_ProtocolVersion(TlsProtocols value) { }

	// RVA: 0xA11A44
	void set_PeerDomainName(string value) { }

	// RVA: 0xA11A4C
	string ToString() { }

	// RVA: 0xA11B10
	void .ctor() { }

}

// Namespace: Mono.Security.Interface
public enum MonoSslPolicyErrors 
{
	// Fields
	public int value__; // 0x10
	public const MonoSslPolicyErrors None = 0;
	public const MonoSslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const MonoSslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const MonoSslPolicyErrors RemoteCertificateChainErrors = 4;
}

// Namespace: Mono.Security.Interface
public sealed class MonoRemoteCertificateValidationCallback 
{
	// Methods

	// RVA: 0xA11B18
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xA11BD4
	internal bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

}

// Namespace: Mono.Security.Interface
public sealed class MonoLocalCertificateSelectionCallback 
{
	// Methods

	// RVA: 0xA11BE8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xA11CA4
	internal X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: Mono.Security.Interface
public abstract class MonoTlsProvider 
{
	// Methods

	// RVA: 0xA11CB8
	void .ctor() { }

	// RVA: -1
	Guid get_ID() { }

	// RVA: 0x2FE360C
	string get_Name() { }

	// RVA: 0x2FE3054
	bool get_SupportsSslStream() { }

	// RVA: 0x2FE3054
	bool get_SupportsConnectionInfo() { }

	// RVA: 0x2FE3054
	bool get_SupportsMonoExtensions() { }

	// RVA: 0x2FE32D4
	SslProtocols get_SupportedProtocols() { }

	// RVA: 0x2FE3054
	bool get_SupportsCleanShutdown() { }

}

// Namespace: Mono.Security.Interface
public static class MonoTlsProviderFactory 
{
	// Methods

	// RVA: 0xA11CC0
	MonoTlsProvider GetProvider() { }

}

// Namespace: Mono.Security.Interface
public sealed class MonoTlsSettings 
{
	// Fields
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	private System.Nullable<System.DateTime> <CertificateValidationTime>k__BackingField; // 0x20
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	private object <UserSettings>k__BackingField; // 0x38
	private string[] <CertificateSearchPaths>k__BackingField; // 0x40
	private bool <SendCloseNotify>k__BackingField; // 0x48
	private string[] <ClientCertificateIssuers>k__BackingField; // 0x50
	private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; // 0x58
	private System.Nullable<Mono.Security.Interface.TlsProtocols> <EnabledProtocols>k__BackingField; // 0x5C
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x68
	private bool cloned; // 0x70
	private bool checkCertName; // 0x71
	private bool checkCertRevocationStatus; // 0x72
	private System.Nullable<System.Boolean> useServicePointManagerCallback; // 0x73
	private bool skipSystemValidators; // 0x75
	private bool callbackNeedsChain; // 0x76
	private ICertificateValidator certificateValidator; // 0x78
	private static MonoTlsSettings defaultSettings; // 0x0

	// Methods

	// RVA: 0xA11D3C
	MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	// RVA: 0xA11D44
	void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	// RVA: 0xA11D4C
	MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	// RVA: 0xA11D54
	void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0xA11D5C
	System.Nullable<System.Boolean> get_UseServicePointManagerCallback() { }

	// RVA: 0xA11D64
	void set_UseServicePointManagerCallback(System.Nullable<System.Boolean> value) { }

	// RVA: 0xA11D6C
	bool get_CallbackNeedsCertificateChain() { }

	// RVA: 0xA11D74
	System.Nullable<System.DateTime> get_CertificateValidationTime() { }

	// RVA: 0xA11D80
	void set_CertificateValidationTime(System.Nullable<System.DateTime> value) { }

	// RVA: 0xA11D88
	X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0xA11D90
	void set_TrustAnchors(X509CertificateCollection value) { }

	// RVA: 0xA11D98
	object get_UserSettings() { }

	// RVA: 0xA11DA0
	void set_UserSettings(object value) { }

	// RVA: 0xA11DA8
	string[] get_CertificateSearchPaths() { }

	// RVA: 0xA11DB0
	void set_CertificateSearchPaths(string[] value) { }

	// RVA: 0xA11DB8
	bool get_SendCloseNotify() { }

	// RVA: 0xA11DC0
	void set_SendCloseNotify(bool value) { }

	// RVA: 0xA11DC8
	string[] get_ClientCertificateIssuers() { }

	// RVA: 0xA11DD0
	void set_ClientCertificateIssuers(string[] value) { }

	// RVA: 0xA11DD8
	bool get_DisallowUnauthenticatedCertificateRequest() { }

	// RVA: 0xA11DE0
	void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	// RVA: 0xA11DE8
	System.Nullable<Mono.Security.Interface.TlsProtocols> get_EnabledProtocols() { }

	// RVA: 0xA11DF0
	void set_EnabledProtocols(System.Nullable<Mono.Security.Interface.TlsProtocols> value) { }

	// RVA: 0xA11DF8
	CipherSuiteCode[] get_EnabledCiphers() { }

	// RVA: 0xA11E00
	void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0xA11E08
	void .ctor() { }

	// RVA: 0xA11E1C
	MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0xA11ECC
	MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0xA12000
	ICertificateValidator get_CertificateValidator() { }

	// RVA: 0xA12008
	MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0xA11F9C
	MonoTlsSettings Clone() { }

	// RVA: 0xA12094
	void .ctor(MonoTlsSettings other) { }

}

// Namespace: Mono.Security.Interface
public sealed class TlsException 
{
	// Fields
	private Alert alert; // 0x90

	// Methods

	// RVA: 0xA1221C
	void .ctor(Alert alert) { }

	// RVA: 0xA12300
	void .ctor(Alert alert, string message) { }

	// RVA: 0xA12388
	void .ctor(AlertDescription description) { }

	// RVA: 0xA12434
	void .ctor(AlertDescription description, string message) { }

}

// Namespace: Mono.Security.Interface
public enum TlsProtocolCode 
{
	// Fields
	public Int16 value__; // 0x10
	public const TlsProtocolCode Tls10 = 769;
	public const TlsProtocolCode Tls11 = 770;
	public const TlsProtocolCode Tls12 = 771;
}

// Namespace: Mono.Security.Interface
public enum TlsProtocols 
{
	// Fields
	public int value__; // 0x10
	public const TlsProtocols Zero = 0;
	public const TlsProtocols Tls10Client = 128;
	public const TlsProtocols Tls10Server = 64;
	public const TlsProtocols Tls10 = 192;
	public const TlsProtocols Tls11Client = 512;
	public const TlsProtocols Tls11Server = 256;
	public const TlsProtocols Tls11 = 768;
	public const TlsProtocols Tls12Client = 2048;
	public const TlsProtocols Tls12Server = 1024;
	public const TlsProtocols Tls12 = 3072;
	public const TlsProtocols ClientMask = 2688;
	public const TlsProtocols ServerMask = 1344;
}

// Namespace: Mono.Security.Cryptography
public sealed class CryptoConvert 
{
	// Methods

	// RVA: 0xA12568
	string ToHex(Byte[] input) { }

	// RVA: 0xA12700
	Byte FromHexChar(Char c) { }

	// RVA: 0xA127B0
	Byte[] FromHex(string hex) { }

}

// Namespace: Mono.Security.Cryptography
public abstract class MD2 
{
	// Methods

	// RVA: 0xA129E0
	void .ctor() { }

	// RVA: 0xA12A0C
	MD2 Create() { }

}

// Namespace: Mono.Security.Cryptography
public class MD2Managed 
{
	// Fields
	private Byte[] state; // 0x28
	private Byte[] checksum; // 0x30
	private Byte[] buffer; // 0x38
	private int count; // 0x40
	private Byte[] x; // 0x48
	private static readonly Byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0xA12B40
	Byte[] Padding(int nLength) { }

	// RVA: 0xA12A60
	void .ctor() { }

	// RVA: 0xA12C40
	void Initialize() { }

	// RVA: 0xA12CAC
	void HashCore(Byte[] array, int ibStart, int cbSize) { }

	// RVA: 0xA13018
	Byte[] HashFinal() { }

	// RVA: 0xA12D90
	void MD2Transform(Byte[] state, Byte[] checksum, Byte[] block, int index) { }

	// RVA: 0xA1316C
	void .cctor() { }

}

// Namespace: Mono.Security.Cryptography
public abstract class MD4 
{
	// Methods

	// RVA: 0xA13210
	void .ctor() { }

	// RVA: 0xA1323C
	MD4 Create() { }

}

// Namespace: Mono.Security.Cryptography
public class MD4Managed 
{
	// Fields
	private UInt32[] state; // 0x28
	private Byte[] buffer; // 0x30
	private UInt32[] count; // 0x38
	private UInt32[] x; // 0x40
	private Byte[] digest; // 0x48

	// Methods

	// RVA: 0xA13290
	void .ctor() { }

	// RVA: 0xA133A0
	void Initialize() { }

	// RVA: 0xA13460
	void HashCore(Byte[] array, int ibStart, int cbSize) { }

	// RVA: 0xA13C00
	Byte[] HashFinal() { }

	// RVA: 0xA13E50
	Byte[] Padding(int nLength) { }

	// RVA: 0xA13ED4
	UInt32 F(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xA13EE4
	UInt32 G(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xA13EF8
	UInt32 H(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xA13F04
	UInt32 ROL(UInt32 x, Byte n) { }

	// RVA: 0xA13F10
	void FF(ref UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xA13F38
	void GG(ref UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xA13F70
	void HH(ref UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xA13D48
	void Encode(Byte[] output, UInt32[] input) { }

	// RVA: 0xA13FA0
	void Decode(UInt32[] output, Byte[] input, int index) { }

	// RVA: 0xA1358C
	void MD4Transform(UInt32[] state, Byte[] block, int index) { }

}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS1 
{
	// Fields
	private static Byte[] emptySHA1; // 0x0
	private static Byte[] emptySHA256; // 0x8
	private static Byte[] emptySHA384; // 0x10
	private static Byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0xA14050
	bool Compare(Byte[] array1, Byte[] array2) { }

	// RVA: 0xA140C4
	Byte[] I2OSP(Byte[] x, int size) { }

	// RVA: 0xA14154
	Byte[] OS2IP(Byte[] x) { }

	// RVA: 0xA14224
	Byte[] RSAVP1(RSA rsa, Byte[] s) { }

	// RVA: 0xA14244
	bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0xA14504
	Byte[] Encode_v15(HashAlgorithm hash, Byte[] hashValue, int emLength) { }

	// RVA: 0xA148B0
	string HashNameFromOid(string oid, bool throwOnError) { }

	// RVA: 0xA14DE4
	HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0xA14E4C
	HashAlgorithm CreateFromName(string name) { }

	// RVA: 0xA1534C
	void .cctor() { }

}

// Namespace: 
public class PrivateKeyInfo 
{
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private Byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Methods

	// RVA: 0xA154CC
	void .ctor() { }

	// RVA: 0xA15548
	void .ctor(Byte[] data) { }

	// RVA: 0xA15840
	string get_Algorithm() { }

	// RVA: 0xA15848
	void set_Algorithm(string value) { }

	// RVA: 0xA15850
	Byte[] get_PrivateKey() { }

	// RVA: 0xA158C8
	void set_PrivateKey(Byte[] value) { }

	// RVA: 0xA155D4
	void Decode(Byte[] data) { }

	// RVA: 0xA159D0
	Byte[] GetBytes() { }

	// RVA: 0xA15E4C
	Byte[] RemoveLeadingZero(Byte[] bigInt) { }

	// RVA: 0xA15EEC
	Byte[] Normalize(Byte[] bigInt, int length) { }

	// RVA: 0xA16010
	RSA DecodeRSA(Byte[] keypair) { }

	// RVA: 0xA16540
	Byte[] Encode(RSA rsa) { }

	// RVA: 0xA1673C
	DSA DecodeDSA(Byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0xA16864
	Byte[] Encode(DSA dsa) { }

	// RVA: 0xA168B4
	Byte[] Encode(AsymmetricAlgorithm aa) { }

}

// Namespace: 
public class EncryptedPrivateKeyInfo 
{
	// Fields
	private string _algorithm; // 0x10
	private Byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private Byte[] _data; // 0x28

	// Methods

	// RVA: 0xA16A18
	void .ctor() { }

	// RVA: 0xA16A20
	void .ctor(Byte[] data) { }

	// RVA: 0xA16D00
	string get_Algorithm() { }

	// RVA: 0xA16D08
	void set_Algorithm(string value) { }

	// RVA: 0xA16D10
	Byte[] get_EncryptedData() { }

	// RVA: 0xA16D88
	void set_EncryptedData(Byte[] value) { }

	// RVA: 0xA16E2C
	Byte[] get_Salt() { }

	// RVA: 0xA16EF4
	int get_IterationCount() { }

	// RVA: 0xA16EFC
	void set_IterationCount(int value) { }

	// RVA: 0xA16A50
	void Decode(Byte[] data) { }

	// RVA: 0xA16F78
	Byte[] GetBytes() { }

}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS8 
{}

// Namespace: 
public sealed class KeyGeneratedEventHandler 
{
	// Methods

	// RVA: 0xA1A308
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xA1A42C
	internal void Invoke(object sender, EventArgs e) { }

}

// Namespace: Mono.Security.Cryptography
public class RSAManaged 
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	private KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Methods

	// RVA: 0xA1714C
	void .ctor() { }

	// RVA: 0xA17154
	void .ctor(int keySize) { }

	// RVA: 0xA17248
	void Finalize() { }

	// RVA: 0xA172E4
	void GenerateKeyPair() { }

	// RVA: 0xA18238
	int get_KeySize() { }

	// RVA: 0xA182E0
	bool get_PublicOnly() { }

	// RVA: 0xA184CC
	Byte[] EncryptValue(Byte[] rgb) { }

	// RVA: 0xA18AB0
	RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0xA19118
	void ImportParameters(RSAParameters parameters) { }

	// RVA: 0xA196EC
	void Dispose(bool disposing) { }

	// RVA: 0xA19C64
	string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0xA1899C
	Byte[] GetPaddedValue(BigInteger value, int length) { }

}

// Namespace: Mono.Security.Authenticode
public class AuthenticodeBase 
{
	// Fields
	private Byte[] fileblock; // 0x10
	private Stream fs; // 0x18
	private int blockNo; // 0x20
	private int blockLength; // 0x24
	private int peOffset; // 0x28
	private int dirSecurityOffset; // 0x2C
	private int dirSecuritySize; // 0x30
	private int coffSymbolTableOffset; // 0x34
	private bool pe64; // 0x38

	// Methods

	// RVA: 0xA1A440
	void .ctor() { }

	// RVA: 0xA1A4B0
	int get_PEOffset() { }

	// RVA: 0xA1A5D0
	void Open(string filename) { }

	// RVA: 0xA1A6D0
	void Open(Byte[] rawdata) { }

	// RVA: 0xA1A684
	void Close() { }

	// RVA: 0xA1A4F4
	void ReadFirstBlock() { }

	// RVA: 0xA1A77C
	int ProcessFirstBlock() { }

	// RVA: 0xA1A9F0
	Byte[] GetSecurityEntry() { }

	// RVA: 0xA1AAE4
	Byte[] GetHash(HashAlgorithm hash) { }

}

// Namespace: Mono.Security.Authenticode
public class AuthenticodeDeformatter 
{
	// Fields
	private string filename; // 0x40
	private Byte[] rawdata; // 0x48
	private Byte[] hash; // 0x50
	private X509CertificateCollection coll; // 0x58
	private ASN1 signedHash; // 0x60
	private DateTime timestamp; // 0x68
	private X509Certificate signingCertificate; // 0x70
	private int reason; // 0x78
	private bool trustedRoot; // 0x7C
	private bool trustedTimestampRoot; // 0x7D
	private Byte[] entry; // 0x80
	private X509Chain signerChain; // 0x88
	private X509Chain timestampChain; // 0x90

	// Methods

	// RVA: 0xA1AFA4
	void .ctor() { }

	// RVA: 0xA1B08C
	void .ctor(Byte[] rawData) { }

	// RVA: 0xA1B0B8
	void set_RawData(Byte[] value) { }

	// RVA: 0xA1B710
	X509Certificate get_SigningCertificate() { }

	// RVA: 0xA1B2B4
	bool CheckSignature() { }

	// RVA: 0xA1C120
	bool CompareIssuerSerial(string issuer, Byte[] serial, X509Certificate x509) { }

	// RVA: 0xA1B718
	bool VerifySignature(SignedData sd, Byte[] calculatedMessageDigest, HashAlgorithm ha) { }

	// RVA: 0xA1C244
	bool VerifyCounterSignature(SignerInfo cs, Byte[] signature) { }

	// RVA: 0xA1B1A4
	void Reset() { }

}

// Namespace: 
public enum Sign 
{
	// Fields
	public int value__; // 0x10
	public const Sign Negative = 4294967295;
	public const Sign Zero = 0;
	public const Sign Positive = 1;
}

// Namespace: 
public sealed class ModulusRing 
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0xA1F288
	void .ctor(BigInteger modulus) { }

	// RVA: 0xA1F6E8
	void BarrettReduction(BigInteger x) { }

	// RVA: 0xA20180
	BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0xA203C4
	BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0xA1F404
	BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0xA205E8
	BigInteger Pow(UInt32 b, BigInteger exp) { }

}

// Namespace: 
private sealed class Kernel 
{
	// Methods

	// RVA: 0xA1D1A4
	BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0xA1FDFC
	void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0xA1FF14
	void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA1D044
	Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA1E974
	UInt32 SingleByteDivideInPlace(BigInteger n, UInt32 d) { }

	// RVA: 0xA1D3FC
	UInt32 DwordMod(BigInteger n, UInt32 d) { }

	// RVA: 0xA206CC
	BigInteger[] DwordDivMod(BigInteger n, UInt32 d) { }

	// RVA: 0xA1D470
	BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA1DBEC
	BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0xA1DE68
	BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0xA1DAE0
	void Multiply(UInt32[] x, UInt32 xOffset, UInt32 xLen, UInt32[] y, UInt32 yOffset, UInt32 yLen, UInt32[] d, UInt32 dOffset) { }

	// RVA: 0xA1FCCC
	void MultiplyMod2p32pmod(UInt32[] x, int xOffset, int xLen, UInt32[] y, int yOffest, int yLen, UInt32[] d, int dOffset, int mod) { }

	// RVA: 0xA20918
	UInt32 modInverse(BigInteger bi, UInt32 modulus) { }

	// RVA: 0xA1EC60
	BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

}

// Namespace: Mono.Math
public class BigInteger 
{
	// Fields
	private UInt32 length; // 0x10
	private UInt32[] data; // 0x18
	internal static readonly UInt32[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Methods

	// RVA: 0xA1CC30
	void .ctor(Sign sign, UInt32 len) { }

	// RVA: 0xA1CCB4
	void .ctor(BigInteger bi) { }

	// RVA: 0xA1CDA8
	void .ctor(BigInteger bi, UInt32 len) { }

	// RVA: 0xA1869C
	void .ctor(Byte[] inData) { }

	// RVA: 0xA1CF20
	void .ctor(UInt32 ui) { }

	// RVA: 0xA17854
	BigInteger op_Implicit(UInt32 value) { }

	// RVA: 0xA17F34
	BigInteger op_Implicit(int value) { }

	// RVA: 0xA1804C
	BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA17998
	UInt32 op_Modulus(BigInteger bi, UInt32 ui) { }

	// RVA: 0xA18208
	BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA1DAB4
	BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA17B14
	BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA1DBE8
	BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0xA1DE64
	BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0xA1E07C
	RandomNumberGenerator get_Rng() { }

	// RVA: 0xA1E15C
	BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0xA1E35C
	BigInteger GenerateRandom(int bits) { }

	// RVA: 0xA17E70
	int BitCount() { }

	// RVA: 0xA1E3C4
	bool TestBit(int bitNum) { }

	// RVA: 0xA1E464
	void SetBit(UInt32 bitNum) { }

	// RVA: 0xA1E4B8
	void SetBit(UInt32 bitNum, bool value) { }

	// RVA: 0xA1E530
	int LowestSetBit() { }

	// RVA: 0xA18E58
	Byte[] GetBytes() { }

	// RVA: 0xA1CFB4
	bool op_Equality(BigInteger bi1, UInt32 ui) { }

	// RVA: 0xA1E5DC
	bool op_Inequality(BigInteger bi1, UInt32 ui) { }

	// RVA: 0xA183C4
	bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA17A0C
	bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA1E66C
	bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA17F1C
	bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA1E688
	bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA1E6A4
	bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA1E6C0
	string ToString(UInt32 radix) { }

	// RVA: 0xA1E71C
	string ToString(UInt32 radix, string characterSet) { }

	// RVA: 0xA1CEC0
	void Normalize() { }

	// RVA: 0xA18A58
	void Clear() { }

	// RVA: 0xA1EA30
	int GetHashCode() { }

	// RVA: 0xA1EA8C
	string ToString() { }

	// RVA: 0xA1EAE4
	bool Equals(object o) { }

	// RVA: 0xA18204
	BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0xA18918
	BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0xA17920
	BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0xA1F5B4
	void Incr2() { }

	// RVA: 0xA1F644
	void .cctor() { }

}

// Namespace: Mono.Math.Prime
public enum ConfidenceFactor 
{
	// Fields
	public int value__; // 0x10
	public const ConfidenceFactor ExtraLow = 0;
	public const ConfidenceFactor Low = 1;
	public const ConfidenceFactor Medium = 2;
	public const ConfidenceFactor High = 3;
	public const ConfidenceFactor ExtraHigh = 4;
	public const ConfidenceFactor Provable = 5;
}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTest 
{
	// Methods

	// RVA: 0xA20A58
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xA20B7C
	internal bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }

}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTests 
{
	// Methods

	// RVA: 0xA20B90
	int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0xA20D5C
	bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }

}

// Namespace: Mono.Math.Prime.Generator
public abstract class PrimeGeneratorBase 
{
	// Methods

	// RVA: 0xA21298
	ConfidenceFactor get_Confidence() { }

	// RVA: 0xA212A0
	PrimalityTest get_PrimalityTest() { }

	// RVA: 0xA21318
	int get_TrialDivisionBounds() { }

	// RVA: -1
	BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0xA21320
	void .ctor() { }

}

// Namespace: Mono.Math.Prime.Generator
public class SequentialSearchPrimeGeneratorBase 
{
	// Methods

	// RVA: 0xA21328
	BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0xA21430
	BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0xA21440
	BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0xA21828
	bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0xA1F5AC
	void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=3 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=9 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=10 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=18 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=20 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=32 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=48 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=64 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=256 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=3132 
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails> 
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=64 001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2; // 0x0
	internal static readonly __StaticArrayInitTypeSize=3132 25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5; // 0x40
	internal static readonly Int64 290C4A052C215D096172EB81AEE671FB3286E5C1DB5E73F96021FC09825DDB88; // 0xC80
	internal static readonly __StaticArrayInitTypeSize=3 32D0830B8EE1D49A66F395C8EA80E02BFC07C2A12A8EA8C8B484AF02108A1950; // 0xC88
	internal static readonly __StaticArrayInitTypeSize=3 35BF50EEF3270FD8CA09E66FC5B0481C5A151B14F6A634854E32F63633D49DCB; // 0xC8B
	internal static readonly __StaticArrayInitTypeSize=3 3C0C410618682C4DF0474E034114CC8E562F05A512B521AC367571017BDFA75D; // 0xC8E
	internal static readonly __StaticArrayInitTypeSize=3 44F5B1A2C48314502ACCBF186D1A2F9F7F176825898F32F1A2047B956194F174; // 0xC91
	internal static readonly __StaticArrayInitTypeSize=48 4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6; // 0xC94
	internal static readonly __StaticArrayInitTypeSize=20 533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA; // 0xCC4
	internal static readonly __StaticArrayInitTypeSize=256 55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329; // 0xCD8
	internal static readonly __StaticArrayInitTypeSize=3 59BE5A634187B8A57216EFF5371A47732C05744B1C1A0A6382A6D5622C9FFDCE; // 0xDD8
	internal static readonly __StaticArrayInitTypeSize=32 5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456; // 0xDDB
	internal static readonly __StaticArrayInitTypeSize=3 5F8C6B3C66B972606D85E7651F67ADBD02E8316876884674E8328FA710747E5B; // 0xDFB
	internal static readonly __StaticArrayInitTypeSize=10 60C6ED13AF98DBFEEDA8F8197FFFCC349BB04395CC81DF0D477CBC57BF5B398B; // 0xDFE
	internal static readonly __StaticArrayInitTypeSize=10 64B3E7D737AFF47D4C3BBD81D2D06D697DDD8EB60F29E13E4425D19D8BBCA1F7; // 0xE08
	internal static readonly Int64 6772A9B8BF207A3CFE6EE68769D6985B69522183F24A2A3D41BC3B4602953426; // 0xE18
	internal static readonly __StaticArrayInitTypeSize=9 684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6; // 0xE20
	internal static readonly __StaticArrayInitTypeSize=64 6AA56C4BCD208911792AD24C7681FEFB93BED51903AFC54860C9BD37E41E5A31; // 0xE29
	internal static readonly __StaticArrayInitTypeSize=3 796E63069E193A008CB4E85573AA1FE53C5F4E58B42A7F61FD0EEE1D89B5120B; // 0xE69
	internal static readonly __StaticArrayInitTypeSize=64 7C8975E1E60A5C8337F28EDF8C33C3B180360B7279644A9BC1AF3C51E6220BF5; // 0xE6C
	internal static readonly __StaticArrayInitTypeSize=3 850D7367E4FB0766E2CBC3ACF5AB42B4E98348E58E5A789845D4FCCDB63D2AEE; // 0xEAC
	internal static readonly Int64 992F16C986809AB68C7466CC3EC6F12B2506A962EA539753E5D84A2FB7FF8A24; // 0xEB0
	internal static readonly __StaticArrayInitTypeSize=3 9A65C09A11757751BFED67A414E00B188DC4C7757FCB6CBD33A916DDE4A3D925; // 0xEB8
	internal static readonly __StaticArrayInitTypeSize=18 9ACEFCC0C950280B64AB9E045E38C34ABF71EC70A0DC61B9C621C6BFB4F78047; // 0xEBB
	internal static readonly __StaticArrayInitTypeSize=3 B1E34F4A11EE411B83415EF0B252A0B2BBCFCAC2E592865E09C12E4252C93A75; // 0xECD
	internal static readonly __StaticArrayInitTypeSize=3 C92FAD7F348A682E7D5B7E74C76B5D019174EE7BC87545B25A1FDD49FBCC2D0B; // 0xED0
	internal static readonly __StaticArrayInitTypeSize=3 E17B8359E685992B0DE6242AAA24FCB7404173CBB7FF8646FF7D658139F41B5F; // 0xED3
	internal static readonly __StaticArrayInitTypeSize=64 F83B332BE4E6A5A4B1C56AAF6DB52657DA495E149870057D8590AB9D7A6167AD; // 0xED6
	internal static readonly __StaticArrayInitTypeSize=3 FB6D7301FFDCB5FBA5807A19B4F0606947897C1105240B6BBA815352DBBE2064; // 0xF16

	// Methods

	// RVA: 0xA14D58
	UInt32 ComputeStringHash(string s) { }

}


