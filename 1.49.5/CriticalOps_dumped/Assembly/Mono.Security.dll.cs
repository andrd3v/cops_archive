// Namespace: 
internal class <Module>
{}

// Namespace: 
internal sealed class Locale
{
	// Methods

	// RVA: 0xA2919C
	public static string GetText(string msg) { }

	// RVA: 0xA291A0
	public static string GetText(string fmt, object[] args) { }

}

// Namespace: Mono.Security
public class ASN1
{
	// Fields
	private Byte m_nTag; // 0x10
	private Byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Methods

	// RVA: 0xA291A8
	public void .ctor(Byte tag) { }

	// RVA: 0xA291E0
	public void .ctor(Byte tag, Byte[] data) { }

	// RVA: 0xA29224
	public void .ctor(Byte[] data) { }

	// RVA: 0xA29548
	public int get_Count() { }

	// RVA: 0xA29564
	public Byte get_Tag() { }

	// RVA: 0xA2956C
	public int get_Length() { }

	// RVA: 0xA29584
	public Byte[] get_Value() { }

	// RVA: 0xA29618
	public void set_Value(Byte[] value) { }

	// RVA: 0xA296E8
	private bool CompareArray(Byte[] array1, Byte[] array2) { }

	// RVA: 0xA2975C
	public bool CompareValue(Byte[] value) { }

	// RVA: 0xA297DC
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0xA29880
	public virtual Byte[] GetBytes() { }

	// RVA: 0xA293A8
	protected void Decode(Byte[] asn1, int anPos, int anLength) { }

	// RVA: 0xA29F60
	protected void DecodeTLV(Byte[] asn1, int pos, Byte tag, int length, Byte[] content) { }

	// RVA: 0xA2A094
	public ASN1 get_Item(int index) { }

	// RVA: 0xA2A1EC
	public ASN1 Element(int index, Byte anTag) { }

	// RVA: 0xA2A374
	public override string ToString() { }

}

// Namespace: Mono.Security
public static class ASN1Convert
{
	// Methods

	// RVA: 0xA2A750
	public static ASN1 FromInt32(int value) { }

	// RVA: 0xA2A8F0
	public static ASN1 FromOid(string oid) { }

	// RVA: 0xA2A9CC
	public static ASN1 FromUnsignedBigInteger(Byte[] big) { }

	// RVA: 0xA2AAEC
	public static int ToInt32(ASN1 asn1) { }

	// RVA: 0xA2ACCC
	public static string ToOid(ASN1 asn1) { }

	// RVA: 0xA2AFC4
	public static DateTime ToDateTime(ASN1 time) { }

}

// Namespace: Mono.Security
internal sealed class BitConverterLE
{
	// Methods

	// RVA: 0xA2B5E4
	private static Byte[] GetUIntBytes(Byte* bytes) { }

	// RVA: 0xA2B688
	private static Byte[] GetULongBytes(Byte* bytes) { }

	// RVA: 0xA2A8CC
	internal static Byte[] GetBytes(int value) { }

	// RVA: 0xA2B76C
	internal static Byte[] GetBytes(Int64 value) { }

	// RVA: 0xA2B790
	private static void UShortFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	// RVA: 0xA2B7E0
	private static void UIntFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	// RVA: 0xA2B868
	internal static int ToInt32(Byte[] value, int startIndex) { }

	// RVA: 0xA2B898
	internal static UInt16 ToUInt16(Byte[] value, int startIndex) { }

	// RVA: 0xA2B8F4
	internal static UInt32 ToUInt32(Byte[] value, int startIndex) { }

}

// Namespace: 
public class ContentInfo
{
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Methods

	// RVA: 0xA2B924
	public void .ctor() { }

	// RVA: 0xA2B9B4
	public void .ctor(string oid) { }

	// RVA: 0xA2BA58
	public void .ctor(Byte[] data) { }

	// RVA: 0xA2BAC4
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xA2BC64
	public ASN1 get_ASN1() { }

	// RVA: 0xA2BE14
	public ASN1 get_Content() { }

	// RVA: 0xA2BE1C
	public void set_Content(ASN1 value) { }

	// RVA: 0xA2BE24
	public string get_ContentType() { }

	// RVA: 0xA2BE2C
	public void set_ContentType(string value) { }

	// RVA: 0xA2BC68
	internal ASN1 GetASN1() { }

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

	// RVA: 0xA2BE34
	public void .ctor() { }

	// RVA: 0xA2BE5C
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xA2C220
	public ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0xA2C228
	public Byte[] get_EncryptedContent() { }

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

	// RVA: 0xA2C2A0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xA2D2C8
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0xA2D2D0
	public ContentInfo get_ContentInfo() { }

	// RVA: 0xA2D288
	public void set_HashName(string value) { }

	// RVA: 0xA2D2D8
	public SignerInfo get_SignerInfo() { }

	// RVA: 0xA2D07C
	internal string OidToName(string oid) { }

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

	// RVA: 0xA2CFD8
	public void .ctor() { }

	// RVA: 0xA2CA64
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xA2D4DC
	public string get_IssuerName() { }

	// RVA: 0xA2D4E4
	public Byte[] get_SerialNumber() { }

	// RVA: 0xA2D55C
	public ArrayList get_AuthenticatedAttributes() { }

	// RVA: 0xA2D564
	public string get_HashName() { }

	// RVA: 0xA2D56C
	public void set_HashName(string value) { }

	// RVA: 0xA2D574
	public Byte[] get_Signature() { }

	// RVA: 0xA2D5EC
	public ArrayList get_UnauthenticatedAttributes() { }

	// RVA: 0xA2D5F4
	public Byte get_Version() { }

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

	// RVA: 0xA2D5FC
	public void .ctor(string bagOID, ASN1 asn1) { }

	// RVA: 0xA2D64C
	public string get_BagOID() { }

	// RVA: 0xA2D654
	public ASN1 get_ASN1() { }

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

	// RVA: 0xA30938
	public void .ctor() { }

	// RVA: 0xA3867C
	public void set_HashName(string value) { }

	// RVA: 0xA38684
	public void set_IterationCount(int value) { }

	// RVA: 0xA30940
	public void set_Password(Byte[] value) { }

	// RVA: 0xA30A28
	public void set_Salt(Byte[] value) { }

	// RVA: 0xA3868C
	private void Adjust(Byte[] a, int aOff, Byte[] b) { }

	// RVA: 0xA38744
	private Byte[] Derive(Byte[] diversifier, int n) { }

	// RVA: 0xA30B04
	public Byte[] DeriveKey(int size) { }

	// RVA: 0xA30B78
	public Byte[] DeriveIV(int size) { }

	// RVA: 0xA33EE8
	public Byte[] DeriveMAC(int size) { }

	// RVA: 0xA38D0C
	private static void .cctor() { }

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

	// RVA: 0xA2D65C
	public void .ctor() { }

	// RVA: 0xA2D764
	public void .ctor(Byte[] data) { }

	// RVA: 0xA2E4B4
	public void .ctor(Byte[] data, string password) { }

	// RVA: 0xA2DA24
	private void Decode(Byte[] data) { }

	// RVA: 0xA2F1F4
	protected override void Finalize() { }

	// RVA: 0xA2D7F0
	public void set_Password(string value) { }

	// RVA: 0xA2F2AC
	public int get_IterationCount() { }

	// RVA: 0xA2F2B4
	public void set_IterationCount(int value) { }

	// RVA: 0xA2F2BC
	public ArrayList get_Keys() { }

	// RVA: 0xA2FCA0
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0xA30240
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0xA2E6B0
	private bool Compare(Byte[] expected, Byte[] actual) { }

	// RVA: 0xA30288
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, Byte[] salt, int iterationCount) { }

	// RVA: 0xA2FAEC
	public Byte[] Decrypt(string algorithmOid, Byte[] salt, int iterationCount, Byte[] encryptedData) { }

	// RVA: 0xA2F07C
	public Byte[] Decrypt(EncryptedData ed) { }

	// RVA: 0xA30BEC
	public Byte[] Encrypt(string algorithmOid, Byte[] salt, int iterationCount, Byte[] data) { }

	// RVA: 0xA30DFC
	private DSAParameters GetExistingParameters(bool found) { }

	// RVA: 0xA31718
	private void AddPrivateKey(PrivateKeyInfo pki) { }

	// RVA: 0xA2E724
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0xA31980
	private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0xA32CC4
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0xA2E4F8
	private Byte[] MAC(Byte[] password, Byte[] salt, int iterations, Byte[] data) { }

	// RVA: 0xA33F5C
	public Byte[] GetBytes() { }

	// RVA: 0xA36D20
	private ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0xA36D18
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0xA37490
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0xA36D10
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0xA37858
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0xA37F6C
	private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2) { }

	// RVA: 0xA38018
	public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0xA3847C
	public object Clone() { }

	// RVA: 0xA385B0
	public static int get_MaximumPasswordLength() { }

	// RVA: 0xA3862C
	private static void .cctor() { }

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

	// RVA: 0xA2D2E0
	public static string ToString(ASN1 seq) { }

	// RVA: 0xA39A90
	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

	// RVA: 0xA38E40
	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	// RVA: 0xA39D54
	private static AttributeTypeAndValue GetAttributeFromOid(string attributeType) { }

	// RVA: 0xA3B068
	private static bool IsOid(string oid) { }

	// RVA: 0xA3B1DC
	private static AttributeTypeAndValue ReadAttribute(string value, int pos) { }

	// RVA: 0xA3B338
	private static bool IsHex(Char c) { }

	// RVA: 0xA3B44C
	private static string ReadHex(string value, int pos) { }

	// RVA: 0xA3B5FC
	private static int ReadEscaped(StringBuilder sb, string value, int pos) { }

	// RVA: 0xA3B7B0
	private static int ReadQuoted(StringBuilder sb, string value, int pos) { }

	// RVA: 0xA3B954
	private static string ReadValue(string value, int pos) { }

	// RVA: 0xA3BBEC
	public static ASN1 FromString(string rdn) { }

	// RVA: 0xA3BF4C
	private static void .cctor() { }

}

// Namespace: 
public class X509CrlEntry
{
	// Fields
	private Byte[] sn; // 0x10
	private DateTime revocationDate; // 0x18
	private X509ExtensionCollection extensions; // 0x20

	// Methods

	// RVA: 0xA3CD70
	internal void .ctor(ASN1 entry) { }

	// RVA: 0xA3D500
	public Byte[] get_SerialNumber() { }

	// RVA: 0xA3DBC4
	public DateTime get_RevocationDate() { }

	// RVA: 0xA3DBCC
	public X509ExtensionCollection get_Extensions() { }

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

	// RVA: 0xA3C404
	public void .ctor(Byte[] crl) { }

	// RVA: 0xA3C524
	private void Parse(Byte[] crl) { }

	// RVA: 0xA3D01C
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0xA3D024
	public Byte[] get_Hash() { }

	// RVA: 0xA3D218
	public string get_IssuerName() { }

	// RVA: 0xA3D220
	public DateTime get_NextUpdate() { }

	// RVA: 0xA3D228
	private bool Compare(Byte[] array1, Byte[] array2) { }

	// RVA: 0xA3D290
	public X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0xA3D318
	public X509CrlEntry GetCrlEntry(Byte[] serialNumber) { }

	// RVA: 0xA3D57C
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0xA3D954
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0xA3DA34
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

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

	// RVA: 0xA3DBD4
	private void Parse(Byte[] data) { }

	// RVA: 0xA2C848
	public void .ctor(Byte[] data) { }

	// RVA: 0xA3EA64
	private Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	// RVA: 0xA31290
	public DSA get_DSA() { }

	// RVA: 0xA3EB18
	public void set_DSA(DSA value) { }

	// RVA: 0xA3EB5C
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0xA3EB64
	public Byte[] get_Hash() { }

	// RVA: 0xA3EDD4
	public virtual string get_IssuerName() { }

	// RVA: 0xA3EDDC
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0xA3EDE4
	public virtual Byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0xA3EE5C
	public virtual void set_KeyAlgorithmParameters(Byte[] value) { }

	// RVA: 0xA3EE64
	public virtual Byte[] get_PublicKey() { }

	// RVA: 0xA3EEDC
	public virtual RSA get_RSA() { }

	// RVA: 0xA3F0A0
	public virtual void set_RSA(RSA value) { }

	// RVA: 0xA3F0E0
	public virtual Byte[] get_RawData() { }

	// RVA: 0xA3F158
	public virtual Byte[] get_SerialNumber() { }

	// RVA: 0xA3F1D0
	public virtual Byte[] get_Signature() { }

	// RVA: 0xA3F640
	public virtual string get_SubjectName() { }

	// RVA: 0xA3F648
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0xA3F650
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0xA3F658
	public int get_Version() { }

	// RVA: 0xA3F660
	public bool get_IsCurrent() { }

	// RVA: 0xA3F6CC
	public bool WasCurrent(DateTime instant) { }

	// RVA: 0xA3F7B0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0xA3F87C
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0xA3F9A8
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0xA3FB38
	public bool get_IsSelfSigned() { }

	// RVA: 0xA3FC54
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xA3E920
	private static Byte[] PEM(string type, Byte[] data) { }

	// RVA: 0xA3FCBC
	private static void .cctor() { }

}

// Namespace: 
public class X509CertificateEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0xA40160
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0xA3118C
	public X509Certificate get_Current() { }

	// RVA: 0xA402DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xA40394
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xA40448
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xA31664
	public bool MoveNext() { }

}

// Namespace: Mono.Security.X509
[Serializable]
public class X509CertificateCollection
{
	// Methods

	// RVA: 0xA2C840
	public void .ctor() { }

	// RVA: 0xA3FD30
	public X509Certificate get_Item(int index) { }

	// RVA: 0xA2C9E8
	public int Add(X509Certificate value) { }

	// RVA: 0xA3FDD4
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0xA3FF28
	public bool Contains(X509Certificate value) { }

	// RVA: 0xA31128
	public X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0xA40228
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xA40250
	public override int GetHashCode() { }

	// RVA: 0xA3FF44
	public int IndexOf(X509Certificate value) { }

	// RVA: 0xA40274
	private bool Compare(Byte[] array1, Byte[] array2) { }

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

	// RVA: 0xA40500
	public void .ctor() { }

	// RVA: 0xA40578
	public X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0xA4070C
	public void LoadCertificates(X509CertificateCollection collection) { }

	// RVA: 0xA40728
	public bool Build(X509Certificate leaf) { }

	// RVA: 0xA415F4
	public void Reset() { }

	// RVA: 0xA414BC
	private bool IsValid(X509Certificate cert) { }

	// RVA: 0xA40D2C
	private X509Certificate FindCertificateParent(X509Certificate child) { }

	// RVA: 0xA40FC4
	private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	// RVA: 0xA41654
	private bool IsTrusted(X509Certificate potentialTrusted) { }

	// RVA: 0xA412B8
	private bool IsParent(X509Certificate child, X509Certificate parent) { }

}

// Namespace: Mono.Security.X509
[Serializable]
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

	// RVA: 0xA4175C
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xA41BC8
	public void .ctor(X509Extension extension) { }

	// RVA: 0xA41D6C
	protected virtual void Decode() { }

	// RVA: 0xA41D70
	protected virtual void Encode() { }

	// RVA: 0xA41D74
	public string get_Oid() { }

	// RVA: 0xA41D7C
	public bool get_Critical() { }

	// RVA: 0xA41D28
	public ASN1 get_Value() { }

	// RVA: 0xA41D84
	public override bool Equals(object obj) { }

	// RVA: 0xA41EC8
	public override int GetHashCode() { }

	// RVA: 0xA41EEC
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0xA426D4
	public override string ToString() { }

}

// Namespace: Mono.Security.X509
public sealed class X509ExtensionCollection
{
	// Fields
	private bool readOnly; // 0x18

	// Methods

	// RVA: 0xA427D4
	public void .ctor() { }

	// RVA: 0xA3CEE0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xA427DC
	public int IndexOf(string oid) { }

	// RVA: 0xA42918
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xA4168C
	public X509Extension get_Item(string oid) { }

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

	// RVA: 0xA42940
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0xA42990
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0xA42D14
	public ArrayList get_Crls() { }

	// RVA: 0xA43090
	private Byte[] Load(string filename) { }

	// RVA: 0xA43274
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0xA432E4
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0xA43354
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0xA429E4
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0xA42DD0
	private ArrayList BuildCrlsCollection(string storeName) { }

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

	// RVA: 0xA4343C
	internal static string get_CurrentUserPath() { }

	// RVA: 0xA43570
	internal static string get_LocalMachinePath() { }

	// RVA: 0xA43694
	internal static string get_NewCurrentUserPath() { }

	// RVA: 0xA437B8
	internal static string get_NewLocalMachinePath() { }

	// RVA: 0xA438DC
	public static X509Stores get_CurrentUser() { }

	// RVA: 0xA43A00
	public static X509Stores get_LocalMachine() { }

	// RVA: 0xA40614
	public static X509CertificateCollection get_TrustedRootCertificates() { }

}

// Namespace: Mono.Security.X509
public class X509Stores
{
	// Fields
	private string _storePath; // 0x10
	private bool _newFormat; // 0x18
	private X509Store _trusted; // 0x20

	// Methods

	// RVA: 0xA439B8
	internal void .ctor(string path, bool newFormat) { }

	// RVA: 0xA43ADC
	public X509Store get_TrustedRoot() { }

	// RVA: 0xA43BF4
	public X509Store Open(string storeName, bool create) { }

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

	// RVA: 0xA43D34
	protected void .ctor(string oid, int upperBound) { }

	// RVA: 0xA43D84
	protected void .ctor(string oid, int upperBound, Byte encoding) { }

	// RVA: 0xA3BE80
	public void set_Value(string value) { }

	// RVA: 0xA43DD4
	internal ASN1 GetASN1(Byte encoding) { }

	// RVA: 0xA3BF44
	internal ASN1 GetASN1() { }

	// RVA: 0xA440AC
	private Byte SelectBestEncoding() { }

}

// Namespace: 
public class CommonName
{
	// Methods

	// RVA: 0xA3AA50
	public void .ctor() { }

}

// Namespace: 
public class SerialNumber
{
	// Methods

	// RVA: 0xA3AFA4
	public void .ctor() { }

}

// Namespace: 
public class LocalityName
{
	// Methods

	// RVA: 0xA3AACC
	public void .ctor() { }

}

// Namespace: 
public class StateOrProvinceName
{
	// Methods

	// RVA: 0xA3AB48
	public void .ctor() { }

}

// Namespace: 
public class OrganizationName
{
	// Methods

	// RVA: 0xA3A958
	public void .ctor() { }

}

// Namespace: 
public class OrganizationalUnitName
{
	// Methods

	// RVA: 0xA3A9D4
	public void .ctor() { }

}

// Namespace: 
public class EmailAddress
{
	// Methods

	// RVA: 0xA3ABC4
	public void .ctor() { }

}

// Namespace: 
public class DomainComponent
{
	// Methods

	// RVA: 0xA3AC40
	public void .ctor() { }

}

// Namespace: 
public class UserId
{
	// Methods

	// RVA: 0xA3ACBC
	public void .ctor() { }

}

// Namespace: 
public class Oid
{
	// Methods

	// RVA: 0xA3B020
	public void .ctor(string oid) { }

}

// Namespace: 
public class Title
{
	// Methods

	// RVA: 0xA3ADB4
	public void .ctor() { }

}

// Namespace: 
public class CountryName
{
	// Methods

	// RVA: 0xA3A8DC
	public void .ctor() { }

}

// Namespace: 
public class DnQualifier
{
	// Methods

	// RVA: 0xA3AD38
	public void .ctor() { }

}

// Namespace: 
public class Surname
{
	// Methods

	// RVA: 0xA3AE30
	public void .ctor() { }

}

// Namespace: 
public class GivenName
{
	// Methods

	// RVA: 0xA3AEAC
	public void .ctor() { }

}

// Namespace: 
public class Initial
{
	// Methods

	// RVA: 0xA3AF28
	public void .ctor() { }

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

	// RVA: 0xA44124
	public void .ctor(X509Extension extension) { }

	// RVA: 0xA44128
	protected override void Decode() { }

	// RVA: 0xA44340
	protected override void Encode() { }

	// RVA: 0xA44568
	public Byte[] get_Identifier() { }

	// RVA: 0xA445E0
	public override string ToString() { }

}

// Namespace: Mono.Security.X509.Extensions
public class BasicConstraintsExtension
{
	// Fields
	private bool cA; // 0x28
	private int pathLenConstraint; // 0x2C

	// Methods

	// RVA: 0xA41758
	public void .ctor(X509Extension extension) { }

	// RVA: 0xA4476C
	protected override void Decode() { }

	// RVA: 0xA44990
	protected override void Encode() { }

	// RVA: 0xA44C30
	public bool get_CertificateAuthority() { }

	// RVA: 0xA44C38
	public override string ToString() { }

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

	// RVA: 0xA44DE4
	public void .ctor() { }

	// RVA: 0xA44E74
	public void .ctor(string password, Byte[] challenge) { }

	// RVA: 0xA454A4
	protected override void Finalize() { }

	// RVA: 0xA44F2C
	public void set_Password(string value) { }

	// RVA: 0xA4534C
	public void set_Challenge(Byte[] value) { }

	// RVA: 0xA45768
	public Byte[] get_LM() { }

	// RVA: 0xA45AB8
	public Byte[] get_NT() { }

	// RVA: 0xA4553C
	public void Dispose() { }

	// RVA: 0xA45B24
	private void Dispose(bool disposing) { }

	// RVA: 0xA457D4
	private Byte[] GetResponse(Byte[] pwd) { }

	// RVA: 0xA45BA8
	private Byte[] PrepareDESKey(Byte[] key56bits, int position) { }

	// RVA: 0xA4561C
	private Byte[] PasswordToKey(string password, int position) { }

	// RVA: 0xA45DA4
	private static void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public static class ChallengeResponse2
{
	// Fields
	private static Byte[] magic; // 0x0
	private static Byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0xA45E94
	private static Byte[] Compute_LM(string password, Byte[] challenge) { }

	// RVA: 0xA46644
	private static Byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0xA46754
	private static Byte[] Compute_NTLM(string password, Byte[] challenge) { }

	// RVA: 0xA467C4
	private static void Compute_NTLMv2_Session(string password, Byte[] challenge, Byte[] lm, Byte[] ntlm) { }

	// RVA: 0xA469FC
	private static Byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0xA46E78
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, Byte[] lm, Byte[] ntlm) { }

	// RVA: 0xA46350
	private static Byte[] GetResponse(Byte[] challenge, Byte[] pwd) { }

	// RVA: 0xA47124
	private static Byte[] PrepareDESKey(Byte[] key56bits, int position) { }

	// RVA: 0xA461E0
	private static Byte[] PasswordToKey(string password, int position) { }

	// RVA: 0xA47320
	private static void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public abstract class MessageBase
{
	// Fields
	private static Byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Methods

	// RVA: 0xA47410
	protected void .ctor(int messageType) { }

	// RVA: 0xA4743C
	public NtlmFlags get_Flags() { }

	// RVA: 0xA47444
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0xA4744C
	public int get_Type() { }

	// RVA: 0xA47454
	protected Byte[] PrepareMessage(int messageSize) { }

	// RVA: 0xA4755C
	protected virtual void Decode(Byte[] message) { }

	// RVA: 0xA47710
	protected bool CheckHeader(Byte[] message) { }

	// RVA: -1
	public abstract Byte[] GetBytes() { }

	// RVA: 0xA47858
	private static void .cctor() { }

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

	// RVA: 0xA478FC
	public static NtlmAuthLevel get_DefaultAuthLevel() { }

	// RVA: 0xA47978
	private static void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type1Message
{
	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Methods

	// RVA: 0xA479C8
	public void .ctor() { }

	// RVA: 0xA47A70
	public void set_Domain(string value) { }

	// RVA: 0xA47B00
	public void set_Host(string value) { }

	// RVA: 0xA47B90
	protected override void Decode(Byte[] message) { }

	// RVA: 0xA47C7C
	public override Byte[] GetBytes() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type2Message
{
	// Fields
	private Byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private Byte[] _targetInfo; // 0x28

	// Methods

	// RVA: 0xA47EDC
	public void .ctor(Byte[] message) { }

	// RVA: 0xA47F90
	protected override void Finalize() { }

	// RVA: 0xA48034
	public Byte[] get_Nonce() { }

	// RVA: 0xA480B0
	public string get_TargetName() { }

	// RVA: 0xA480B8
	public Byte[] get_TargetInfo() { }

	// RVA: 0xA48134
	protected override void Decode(Byte[] message) { }

	// RVA: 0xA482C0
	public override Byte[] GetBytes() { }

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

	// RVA: 0xA4837C
	public void .ctor(Type2Message type2) { }

	// RVA: 0xA48650
	protected override void Finalize() { }

	// RVA: 0xA4873C
	public void set_Domain(string value) { }

	// RVA: 0xA487CC
	public void set_Password(string value) { }

	// RVA: 0xA487D4
	public void set_Username(string value) { }

	// RVA: 0xA487DC
	protected override void Decode(Byte[] message) { }

	// RVA: 0xA48AB0
	private string DecodeString(Byte[] buffer, int offset, int len) { }

	// RVA: 0xA48B18
	private Byte[] EncodeString(string text) { }

	// RVA: 0xA48BB8
	public override Byte[] GetBytes() { }

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

	// RVA: 0xA491EC
	public AlertLevel get_Level() { }

	// RVA: 0xA491F4
	public AlertDescription get_Description() { }

	// RVA: 0xA491FC
	public void .ctor(AlertDescription description) { }

	// RVA: 0xA4927C
	private void inferAlertLevel() { }

	// RVA: 0xA492C8
	public override string ToString() { }

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

	// RVA: 0xA4938C
	public void .ctor(bool trusted, bool user_denied, int error_code, System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0xA493E0
	public bool get_Trusted() { }

	// RVA: 0xA493E8
	public bool get_UserDenied() { }

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

	// RVA: 0xA493F0
	public CipherSuiteCode get_CipherSuiteCode() { }

	// RVA: 0xA493F8
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	// RVA: 0xA49400
	public TlsProtocols get_ProtocolVersion() { }

	// RVA: 0xA49408
	public void set_ProtocolVersion(TlsProtocols value) { }

	// RVA: 0xA49410
	public void set_PeerDomainName(string value) { }

	// RVA: 0xA49418
	public override string ToString() { }

	// RVA: 0xA494DC
	public void .ctor() { }

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

	// RVA: 0xA494E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA495A0
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

}

// Namespace: Mono.Security.Interface
public sealed class MonoLocalCertificateSelectionCallback
{
	// Methods

	// RVA: 0xA495B4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA49670
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: Mono.Security.Interface
public abstract class MonoTlsProvider
{
	// Methods

	// RVA: 0xA49684
	internal void .ctor() { }

	// RVA: -1
	public abstract Guid get_ID() { }

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: -1
	public abstract bool get_SupportsSslStream() { }

	// RVA: -1
	public abstract bool get_SupportsConnectionInfo() { }

	// RVA: -1
	public abstract bool get_SupportsMonoExtensions() { }

	// RVA: -1
	public abstract SslProtocols get_SupportedProtocols() { }

	// RVA: -1
	internal abstract bool get_SupportsCleanShutdown() { }

}

// Namespace: Mono.Security.Interface
public static class MonoTlsProviderFactory
{
	// Methods

	// RVA: 0xA4968C
	public static MonoTlsProvider GetProvider() { }

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

	// RVA: 0xA49708
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	// RVA: 0xA49710
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	// RVA: 0xA49718
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	// RVA: 0xA49720
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0xA49728
	public System.Nullable<System.Boolean> get_UseServicePointManagerCallback() { }

	// RVA: 0xA49730
	public void set_UseServicePointManagerCallback(System.Nullable<System.Boolean> value) { }

	// RVA: 0xA49738
	public bool get_CallbackNeedsCertificateChain() { }

	// RVA: 0xA49740
	public System.Nullable<System.DateTime> get_CertificateValidationTime() { }

	// RVA: 0xA4974C
	public void set_CertificateValidationTime(System.Nullable<System.DateTime> value) { }

	// RVA: 0xA49754
	public X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0xA4975C
	public void set_TrustAnchors(X509CertificateCollection value) { }

	// RVA: 0xA49764
	public object get_UserSettings() { }

	// RVA: 0xA4976C
	public void set_UserSettings(object value) { }

	// RVA: 0xA49774
	internal string[] get_CertificateSearchPaths() { }

	// RVA: 0xA4977C
	internal void set_CertificateSearchPaths(string[] value) { }

	// RVA: 0xA49784
	internal bool get_SendCloseNotify() { }

	// RVA: 0xA4978C
	internal void set_SendCloseNotify(bool value) { }

	// RVA: 0xA49794
	public string[] get_ClientCertificateIssuers() { }

	// RVA: 0xA4979C
	public void set_ClientCertificateIssuers(string[] value) { }

	// RVA: 0xA497A4
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	// RVA: 0xA497AC
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	// RVA: 0xA497B4
	public System.Nullable<Mono.Security.Interface.TlsProtocols> get_EnabledProtocols() { }

	// RVA: 0xA497BC
	public void set_EnabledProtocols(System.Nullable<Mono.Security.Interface.TlsProtocols> value) { }

	// RVA: 0xA497C4
	public CipherSuiteCode[] get_EnabledCiphers() { }

	// RVA: 0xA497CC
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0xA497D4
	public void .ctor() { }

	// RVA: 0xA497E8
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0xA49898
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0xA499CC
	public ICertificateValidator get_CertificateValidator() { }

	// RVA: 0xA499D4
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0xA49968
	public MonoTlsSettings Clone() { }

	// RVA: 0xA49A60
	private void .ctor(MonoTlsSettings other) { }

}

// Namespace: Mono.Security.Interface
public sealed class TlsException
{
	// Fields
	private Alert alert; // 0x90

	// Methods

	// RVA: 0xA49BE8
	public void .ctor(Alert alert) { }

	// RVA: 0xA49CCC
	public void .ctor(Alert alert, string message) { }

	// RVA: 0xA49D54
	public void .ctor(AlertDescription description) { }

	// RVA: 0xA49E00
	public void .ctor(AlertDescription description, string message) { }

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

	// RVA: 0xA49F34
	public static string ToHex(Byte[] input) { }

	// RVA: 0xA4A0CC
	private static Byte FromHexChar(Char c) { }

	// RVA: 0xA4A17C
	public static Byte[] FromHex(string hex) { }

}

// Namespace: Mono.Security.Cryptography
public abstract class MD2
{
	// Methods

	// RVA: 0xA4A3AC
	protected void .ctor() { }

	// RVA: 0xA4A3D8
	public static MD2 Create() { }

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

	// RVA: 0xA4A50C
	private Byte[] Padding(int nLength) { }

	// RVA: 0xA4A42C
	public void .ctor() { }

	// RVA: 0xA4A60C
	public override void Initialize() { }

	// RVA: 0xA4A678
	protected override void HashCore(Byte[] array, int ibStart, int cbSize) { }

	// RVA: 0xA4A9E4
	protected override Byte[] HashFinal() { }

	// RVA: 0xA4A75C
	private void MD2Transform(Byte[] state, Byte[] checksum, Byte[] block, int index) { }

	// RVA: 0xA4AB38
	private static void .cctor() { }

}

// Namespace: Mono.Security.Cryptography
public abstract class MD4
{
	// Methods

	// RVA: 0xA4ABDC
	protected void .ctor() { }

	// RVA: 0xA4AC08
	public static MD4 Create() { }

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

	// RVA: 0xA4AC5C
	public void .ctor() { }

	// RVA: 0xA4AD6C
	public override void Initialize() { }

	// RVA: 0xA4AE2C
	protected override void HashCore(Byte[] array, int ibStart, int cbSize) { }

	// RVA: 0xA4B5CC
	protected override Byte[] HashFinal() { }

	// RVA: 0xA4B81C
	private Byte[] Padding(int nLength) { }

	// RVA: 0xA4B8A0
	private UInt32 F(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xA4B8B0
	private UInt32 G(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xA4B8C4
	private UInt32 H(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xA4B8D0
	private UInt32 ROL(UInt32 x, Byte n) { }

	// RVA: 0xA4B8DC
	private void FF(UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xA4B904
	private void GG(UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xA4B93C
	private void HH(UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xA4B714
	private void Encode(Byte[] output, UInt32[] input) { }

	// RVA: 0xA4B96C
	private void Decode(UInt32[] output, Byte[] input, int index) { }

	// RVA: 0xA4AF58
	private void MD4Transform(UInt32[] state, Byte[] block, int index) { }

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

	// RVA: 0xA4BA1C
	private static bool Compare(Byte[] array1, Byte[] array2) { }

	// RVA: 0xA4BA90
	public static Byte[] I2OSP(Byte[] x, int size) { }

	// RVA: 0xA4BB20
	public static Byte[] OS2IP(Byte[] x) { }

	// RVA: 0xA4BBF0
	public static Byte[] RSAVP1(RSA rsa, Byte[] s) { }

	// RVA: 0xA4BC10
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0xA4BED0
	public static Byte[] Encode_v15(HashAlgorithm hash, Byte[] hashValue, int emLength) { }

	// RVA: 0xA4C27C
	internal static string HashNameFromOid(string oid, bool throwOnError) { }

	// RVA: 0xA4C7B0
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0xA4C818
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0xA4CD18
	private static void .cctor() { }

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

	// RVA: 0xA4CE98
	public void .ctor() { }

	// RVA: 0xA4CF14
	public void .ctor(Byte[] data) { }

	// RVA: 0xA4D20C
	public string get_Algorithm() { }

	// RVA: 0xA4D214
	public void set_Algorithm(string value) { }

	// RVA: 0xA4D21C
	public Byte[] get_PrivateKey() { }

	// RVA: 0xA4D294
	public void set_PrivateKey(Byte[] value) { }

	// RVA: 0xA4CFA0
	private void Decode(Byte[] data) { }

	// RVA: 0xA4D39C
	public Byte[] GetBytes() { }

	// RVA: 0xA4D818
	private static Byte[] RemoveLeadingZero(Byte[] bigInt) { }

	// RVA: 0xA4D8B8
	private static Byte[] Normalize(Byte[] bigInt, int length) { }

	// RVA: 0xA4D9DC
	public static RSA DecodeRSA(Byte[] keypair) { }

	// RVA: 0xA4DF0C
	public static Byte[] Encode(RSA rsa) { }

	// RVA: 0xA4E108
	public static DSA DecodeDSA(Byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0xA4E230
	public static Byte[] Encode(DSA dsa) { }

	// RVA: 0xA4E280
	public static Byte[] Encode(AsymmetricAlgorithm aa) { }

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

	// RVA: 0xA4E3E4
	public void .ctor() { }

	// RVA: 0xA4E3EC
	public void .ctor(Byte[] data) { }

	// RVA: 0xA4E6CC
	public string get_Algorithm() { }

	// RVA: 0xA4E6D4
	public void set_Algorithm(string value) { }

	// RVA: 0xA4E6DC
	public Byte[] get_EncryptedData() { }

	// RVA: 0xA4E754
	public void set_EncryptedData(Byte[] value) { }

	// RVA: 0xA4E7F8
	public Byte[] get_Salt() { }

	// RVA: 0xA4E8C0
	public int get_IterationCount() { }

	// RVA: 0xA4E8C8
	public void set_IterationCount(int value) { }

	// RVA: 0xA4E41C
	private void Decode(Byte[] data) { }

	// RVA: 0xA4E944
	public Byte[] GetBytes() { }

}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS8
{}

// Namespace: 
public sealed class KeyGeneratedEventHandler
{
	// Methods

	// RVA: 0xA51CD4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA51DF8
	public virtual void Invoke(object sender, EventArgs e) { }

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

	// RVA: 0xA4EB18
	public void .ctor() { }

	// RVA: 0xA4EB20
	public void .ctor(int keySize) { }

	// RVA: 0xA4EC14
	protected override void Finalize() { }

	// RVA: 0xA4ECB0
	private void GenerateKeyPair() { }

	// RVA: 0xA4FC04
	public override int get_KeySize() { }

	// RVA: 0xA4FCAC
	public bool get_PublicOnly() { }

	// RVA: 0xA4FE98
	public override Byte[] EncryptValue(Byte[] rgb) { }

	// RVA: 0xA5047C
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0xA50AE4
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0xA510B8
	protected override void Dispose(bool disposing) { }

	// RVA: 0xA51630
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0xA50368
	private Byte[] GetPaddedValue(BigInteger value, int length) { }

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

	// RVA: 0xA51E0C
	public void .ctor() { }

	// RVA: 0xA51E7C
	internal int get_PEOffset() { }

	// RVA: 0xA51F9C
	internal void Open(string filename) { }

	// RVA: 0xA5209C
	internal void Open(Byte[] rawdata) { }

	// RVA: 0xA52050
	internal void Close() { }

	// RVA: 0xA51EC0
	internal void ReadFirstBlock() { }

	// RVA: 0xA52148
	internal int ProcessFirstBlock() { }

	// RVA: 0xA523BC
	internal Byte[] GetSecurityEntry() { }

	// RVA: 0xA524B0
	internal Byte[] GetHash(HashAlgorithm hash) { }

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

	// RVA: 0xA52970
	public void .ctor() { }

	// RVA: 0xA52A58
	public void .ctor(Byte[] rawData) { }

	// RVA: 0xA52A84
	public void set_RawData(Byte[] value) { }

	// RVA: 0xA530DC
	public X509Certificate get_SigningCertificate() { }

	// RVA: 0xA52C80
	private bool CheckSignature() { }

	// RVA: 0xA53AEC
	private bool CompareIssuerSerial(string issuer, Byte[] serial, X509Certificate x509) { }

	// RVA: 0xA530E4
	private bool VerifySignature(SignedData sd, Byte[] calculatedMessageDigest, HashAlgorithm ha) { }

	// RVA: 0xA53C10
	private bool VerifyCounterSignature(SignerInfo cs, Byte[] signature) { }

	// RVA: 0xA52B70
	private void Reset() { }

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

	// RVA: 0xA56C54
	public void .ctor(BigInteger modulus) { }

	// RVA: 0xA570B4
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0xA57B4C
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0xA57D90
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0xA56DD0
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0xA57FB4
	public BigInteger Pow(UInt32 b, BigInteger exp) { }

}

// Namespace: 
private sealed class Kernel
{
	// Methods

	// RVA: 0xA54B70
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0xA577C8
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0xA578E0
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA54A10
	public static Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA56340
	public static UInt32 SingleByteDivideInPlace(BigInteger n, UInt32 d) { }

	// RVA: 0xA54DC8
	public static UInt32 DwordMod(BigInteger n, UInt32 d) { }

	// RVA: 0xA58098
	public static BigInteger[] DwordDivMod(BigInteger n, UInt32 d) { }

	// RVA: 0xA54E3C
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA555B8
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0xA55834
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0xA554AC
	public static void Multiply(UInt32[] x, UInt32 xOffset, UInt32 xLen, UInt32[] y, UInt32 yOffset, UInt32 yLen, UInt32[] d, UInt32 dOffset) { }

	// RVA: 0xA57698
	public static void MultiplyMod2p32pmod(UInt32[] x, int xOffset, int xLen, UInt32[] y, int yOffest, int yLen, UInt32[] d, int dOffset, int mod) { }

	// RVA: 0xA582E4
	public static UInt32 modInverse(BigInteger bi, UInt32 modulus) { }

	// RVA: 0xA5662C
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

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

	// RVA: 0xA545FC
	public void .ctor(Sign sign, UInt32 len) { }

	// RVA: 0xA54680
	public void .ctor(BigInteger bi) { }

	// RVA: 0xA54774
	public void .ctor(BigInteger bi, UInt32 len) { }

	// RVA: 0xA50068
	public void .ctor(Byte[] inData) { }

	// RVA: 0xA548EC
	public void .ctor(UInt32 ui) { }

	// RVA: 0xA4F220
	public static BigInteger op_Implicit(UInt32 value) { }

	// RVA: 0xA4F900
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0xA4FA18
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA4F364
	public static UInt32 op_Modulus(BigInteger bi, UInt32 ui) { }

	// RVA: 0xA4FBD4
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA55480
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA4F4E0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA555B4
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0xA55830
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0xA55A48
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0xA55B28
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0xA55D28
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0xA4F83C
	public int BitCount() { }

	// RVA: 0xA55D90
	public bool TestBit(int bitNum) { }

	// RVA: 0xA55E30
	public void SetBit(UInt32 bitNum) { }

	// RVA: 0xA55E84
	public void SetBit(UInt32 bitNum, bool value) { }

	// RVA: 0xA55EFC
	public int LowestSetBit() { }

	// RVA: 0xA50824
	public Byte[] GetBytes() { }

	// RVA: 0xA54980
	public static bool op_Equality(BigInteger bi1, UInt32 ui) { }

	// RVA: 0xA55FA8
	public static bool op_Inequality(BigInteger bi1, UInt32 ui) { }

	// RVA: 0xA4FD90
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA4F3D8
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA56038
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA4F8E8
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA56054
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA56070
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xA5608C
	public string ToString(UInt32 radix) { }

	// RVA: 0xA560E8
	public string ToString(UInt32 radix, string characterSet) { }

	// RVA: 0xA5488C
	private void Normalize() { }

	// RVA: 0xA50424
	public void Clear() { }

	// RVA: 0xA563FC
	public override int GetHashCode() { }

	// RVA: 0xA56458
	public override string ToString() { }

	// RVA: 0xA564B0
	public override bool Equals(object o) { }

	// RVA: 0xA4FBD0
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0xA502E4
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0xA4F2EC
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0xA56F80
	public void Incr2() { }

	// RVA: 0xA57010
	private static void .cctor() { }

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

	// RVA: 0xA58424
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA58548
	public virtual bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }

}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTests
{
	// Methods

	// RVA: 0xA5855C
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0xA58728
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }

}

// Namespace: Mono.Math.Prime.Generator
public abstract class PrimeGeneratorBase
{
	// Methods

	// RVA: 0xA58C64
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0xA58C6C
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0xA58CE4
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1
	public abstract BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0xA58CEC
	protected void .ctor() { }

}

// Namespace: Mono.Math.Prime.Generator
public class SequentialSearchPrimeGeneratorBase
{
	// Methods

	// RVA: 0xA58CF4
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0xA58DFC
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0xA58E0C
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0xA591F4
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0xA56F78
	public void .ctor() { }

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

	// RVA: 0xA4C724
	internal static UInt32 ComputeStringHash(string s) { }

}


