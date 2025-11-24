// Namespace: 
internal class <Module>
{}

// Namespace: 
internal sealed class Locale
{
	// Methods

	// RVA: 0xA8AEB4
	public static string GetText(string msg) { }

	// RVA: 0xA8AEB8
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

	// RVA: 0xA8AEC0
	public void .ctor(Byte tag) { }

	// RVA: 0xA8AEF8
	public void .ctor(Byte tag, Byte[] data) { }

	// RVA: 0xA8AF3C
	public void .ctor(Byte[] data) { }

	// RVA: 0xA8B260
	public int get_Count() { }

	// RVA: 0xA8B27C
	public Byte get_Tag() { }

	// RVA: 0xA8B284
	public int get_Length() { }

	// RVA: 0xA8B29C
	public Byte[] get_Value() { }

	// RVA: 0xA8B330
	public void set_Value(Byte[] value) { }

	// RVA: 0xA8B400
	private bool CompareArray(Byte[] array1, Byte[] array2) { }

	// RVA: 0xA8B474
	public bool CompareValue(Byte[] value) { }

	// RVA: 0xA8B4F4
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0xA8B598
	public virtual Byte[] GetBytes() { }

	// RVA: 0xA8B0C0
	protected void Decode(Byte[] asn1, int anPos, int anLength) { }

	// RVA: 0xA8BC78
	protected void DecodeTLV(Byte[] asn1, int pos, Byte tag, int length, Byte[] content) { }

	// RVA: 0xA8BDAC
	public ASN1 get_Item(int index) { }

	// RVA: 0xA8BF04
	public ASN1 Element(int index, Byte anTag) { }

	// RVA: 0xA8C08C
	public override string ToString() { }

}

// Namespace: Mono.Security
public static class ASN1Convert
{
	// Methods

	// RVA: 0xA8C478
	public static ASN1 FromInt32(int value) { }

	// RVA: 0xA8C618
	public static ASN1 FromOid(string oid) { }

	// RVA: 0xA8C6F4
	public static ASN1 FromUnsignedBigInteger(Byte[] big) { }

	// RVA: 0xA8C814
	public static int ToInt32(ASN1 asn1) { }

	// RVA: 0xA8C9F4
	public static string ToOid(ASN1 asn1) { }

	// RVA: 0xA8CCEC
	public static DateTime ToDateTime(ASN1 time) { }

}

// Namespace: Mono.Security
internal sealed class BitConverterLE
{
	// Methods

	// RVA: 0xA8D300
	private static Byte[] GetUIntBytes(Byte* bytes) { }

	// RVA: 0xA8D3A4
	private static Byte[] GetULongBytes(Byte* bytes) { }

	// RVA: 0xA8C5F4
	internal static Byte[] GetBytes(int value) { }

	// RVA: 0xA8D488
	internal static Byte[] GetBytes(Int64 value) { }

	// RVA: 0xA8D4AC
	private static void UShortFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	// RVA: 0xA8D4FC
	private static void UIntFromBytes(Byte* dst, Byte[] src, int startIndex) { }

	// RVA: 0xA8D584
	internal static int ToInt32(Byte[] value, int startIndex) { }

	// RVA: 0xA8D5B4
	internal static UInt16 ToUInt16(Byte[] value, int startIndex) { }

	// RVA: 0xA8D610
	internal static UInt32 ToUInt32(Byte[] value, int startIndex) { }

}

// Namespace: 
public class ContentInfo
{
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Methods

	// RVA: 0xA8D640
	public void .ctor() { }

	// RVA: 0xA8D6D0
	public void .ctor(string oid) { }

	// RVA: 0xA8D774
	public void .ctor(Byte[] data) { }

	// RVA: 0xA8D7E0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xA8D980
	public ASN1 get_ASN1() { }

	// RVA: 0xA8DB30
	public ASN1 get_Content() { }

	// RVA: 0xA8DB38
	public void set_Content(ASN1 value) { }

	// RVA: 0xA8DB40
	public string get_ContentType() { }

	// RVA: 0xA8DB48
	public void set_ContentType(string value) { }

	// RVA: 0xA8D984
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

	// RVA: 0xA8DB50
	public void .ctor() { }

	// RVA: 0xA8DB78
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xA8DF3C
	public ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0xA8DF44
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

	// RVA: 0xA8DFBC
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xA8EFE4
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0xA8EFEC
	public ContentInfo get_ContentInfo() { }

	// RVA: 0xA8EFA4
	public void set_HashName(string value) { }

	// RVA: 0xA8EFF4
	public SignerInfo get_SignerInfo() { }

	// RVA: 0xA8ED98
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

	// RVA: 0xA8ECF4
	public void .ctor() { }

	// RVA: 0xA8E780
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xA8F1F8
	public string get_IssuerName() { }

	// RVA: 0xA8F200
	public Byte[] get_SerialNumber() { }

	// RVA: 0xA8F278
	public ArrayList get_AuthenticatedAttributes() { }

	// RVA: 0xA8F280
	public string get_HashName() { }

	// RVA: 0xA8F288
	public void set_HashName(string value) { }

	// RVA: 0xA8F290
	public Byte[] get_Signature() { }

	// RVA: 0xA8F308
	public ArrayList get_UnauthenticatedAttributes() { }

	// RVA: 0xA8F310
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

	// RVA: 0xA8F318
	public void .ctor(string bagOID, ASN1 asn1) { }

	// RVA: 0xA8F368
	public string get_BagOID() { }

	// RVA: 0xA8F370
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

	// RVA: 0xA92654
	public void .ctor() { }

	// RVA: 0xA9A380
	public void set_HashName(string value) { }

	// RVA: 0xA9A388
	public void set_IterationCount(int value) { }

	// RVA: 0xA9265C
	public void set_Password(Byte[] value) { }

	// RVA: 0xA92744
	public void set_Salt(Byte[] value) { }

	// RVA: 0xA9A390
	private void Adjust(Byte[] a, int aOff, Byte[] b) { }

	// RVA: 0xA9A448
	private Byte[] Derive(Byte[] diversifier, int n) { }

	// RVA: 0xA92820
	public Byte[] DeriveKey(int size) { }

	// RVA: 0xA92894
	public Byte[] DeriveIV(int size) { }

	// RVA: 0xA95BEC
	public Byte[] DeriveMAC(int size) { }

	// RVA: 0xA9AA10
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

	// RVA: 0xA8F378
	public void .ctor() { }

	// RVA: 0xA8F480
	public void .ctor(Byte[] data) { }

	// RVA: 0xA901D0
	public void .ctor(Byte[] data, string password) { }

	// RVA: 0xA8F740
	private void Decode(Byte[] data) { }

	// RVA: 0xA90F10
	protected override void Finalize() { }

	// RVA: 0xA8F50C
	public void set_Password(string value) { }

	// RVA: 0xA90FC8
	public int get_IterationCount() { }

	// RVA: 0xA90FD0
	public void set_IterationCount(int value) { }

	// RVA: 0xA90FD8
	public ArrayList get_Keys() { }

	// RVA: 0xA919BC
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0xA91F5C
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0xA903CC
	private bool Compare(Byte[] expected, Byte[] actual) { }

	// RVA: 0xA91FA4
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, Byte[] salt, int iterationCount) { }

	// RVA: 0xA91808
	public Byte[] Decrypt(string algorithmOid, Byte[] salt, int iterationCount, Byte[] encryptedData) { }

	// RVA: 0xA90D98
	public Byte[] Decrypt(EncryptedData ed) { }

	// RVA: 0xA92908
	public Byte[] Encrypt(string algorithmOid, Byte[] salt, int iterationCount, Byte[] data) { }

	// RVA: 0xA92B18
	private DSAParameters GetExistingParameters(bool found) { }

	// RVA: 0xA93434
	private void AddPrivateKey(PrivateKeyInfo pki) { }

	// RVA: 0xA90440
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0xA9369C
	private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0xA949D4
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0xA90214
	private Byte[] MAC(Byte[] password, Byte[] salt, int iterations, Byte[] data) { }

	// RVA: 0xA95C60
	public Byte[] GetBytes() { }

	// RVA: 0xA98A24
	private ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0xA98A1C
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0xA99194
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0xA98A14
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0xA9955C
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0xA99C70
	private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2) { }

	// RVA: 0xA99D1C
	public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes) { }

	// RVA: 0xA9A180
	public object Clone() { }

	// RVA: 0xA9A2B4
	public static int get_MaximumPasswordLength() { }

	// RVA: 0xA9A330
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

	// RVA: 0xA8EFFC
	public static string ToString(ASN1 seq) { }

	// RVA: 0xA9B794
	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

	// RVA: 0xA9AB44
	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	// RVA: 0xA9BA58
	private static AttributeTypeAndValue GetAttributeFromOid(string attributeType) { }

	// RVA: 0xA9CD6C
	private static bool IsOid(string oid) { }

	// RVA: 0xA9CEE0
	private static AttributeTypeAndValue ReadAttribute(string value, int pos) { }

	// RVA: 0xA9D03C
	private static bool IsHex(Char c) { }

	// RVA: 0xA9D14C
	private static string ReadHex(string value, int pos) { }

	// RVA: 0xA9D2FC
	private static int ReadEscaped(StringBuilder sb, string value, int pos) { }

	// RVA: 0xA9D4B0
	private static int ReadQuoted(StringBuilder sb, string value, int pos) { }

	// RVA: 0xA9D654
	private static string ReadValue(string value, int pos) { }

	// RVA: 0xA9D8EC
	public static ASN1 FromString(string rdn) { }

	// RVA: 0xA9DC4C
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

	// RVA: 0xA9EA70
	internal void .ctor(ASN1 entry) { }

	// RVA: 0xA9F200
	public Byte[] get_SerialNumber() { }

	// RVA: 0xA9F8C4
	public DateTime get_RevocationDate() { }

	// RVA: 0xA9F8CC
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

	// RVA: 0xA9E104
	public void .ctor(Byte[] crl) { }

	// RVA: 0xA9E224
	private void Parse(Byte[] crl) { }

	// RVA: 0xA9ED1C
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0xA9ED24
	public Byte[] get_Hash() { }

	// RVA: 0xA9EF18
	public string get_IssuerName() { }

	// RVA: 0xA9EF20
	public DateTime get_NextUpdate() { }

	// RVA: 0xA9EF28
	private bool Compare(Byte[] array1, Byte[] array2) { }

	// RVA: 0xA9EF90
	public X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0xA9F018
	public X509CrlEntry GetCrlEntry(Byte[] serialNumber) { }

	// RVA: 0xA9F27C
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0xA9F654
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0xA9F734
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

	// RVA: 0xA9F8D4
	private void Parse(Byte[] data) { }

	// RVA: 0xA8E564
	public void .ctor(Byte[] data) { }

	// RVA: 0xAA0764
	private Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	// RVA: 0xA92FAC
	public DSA get_DSA() { }

	// RVA: 0xAA0818
	public void set_DSA(DSA value) { }

	// RVA: 0xAA085C
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0xAA0864
	public Byte[] get_Hash() { }

	// RVA: 0xAA0AD4
	public virtual string get_IssuerName() { }

	// RVA: 0xAA0ADC
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0xAA0AE4
	public virtual Byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0xAA0B5C
	public virtual void set_KeyAlgorithmParameters(Byte[] value) { }

	// RVA: 0xAA0B64
	public virtual Byte[] get_PublicKey() { }

	// RVA: 0xAA0BDC
	public virtual RSA get_RSA() { }

	// RVA: 0xAA0DA0
	public virtual void set_RSA(RSA value) { }

	// RVA: 0xAA0DE0
	public virtual Byte[] get_RawData() { }

	// RVA: 0xAA0E58
	public virtual Byte[] get_SerialNumber() { }

	// RVA: 0xAA0ED0
	public virtual Byte[] get_Signature() { }

	// RVA: 0xAA1340
	public virtual string get_SubjectName() { }

	// RVA: 0xAA1348
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0xAA1350
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0xAA1358
	public int get_Version() { }

	// RVA: 0xAA1360
	public bool get_IsCurrent() { }

	// RVA: 0xAA13CC
	public bool WasCurrent(DateTime instant) { }

	// RVA: 0xAA14B0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0xAA157C
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0xAA16A8
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0xAA1838
	public bool get_IsSelfSigned() { }

	// RVA: 0xAA1954
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAA0620
	private static Byte[] PEM(string type, Byte[] data) { }

	// RVA: 0xAA19BC
	private static void .cctor() { }

}

// Namespace: 
public class X509CertificateEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0xAA1E60
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0xA92EA8
	public X509Certificate get_Current() { }

	// RVA: 0xAA1FDC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xAA2094
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0xAA2148
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xA93380
	public bool MoveNext() { }

}

// Namespace: Mono.Security.X509
[Serializable]
public class X509CertificateCollection
{
	// Methods

	// RVA: 0xA8E55C
	public void .ctor() { }

	// RVA: 0xAA1A30
	public X509Certificate get_Item(int index) { }

	// RVA: 0xA8E704
	public int Add(X509Certificate value) { }

	// RVA: 0xAA1AD4
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0xAA1C28
	public bool Contains(X509Certificate value) { }

	// RVA: 0xA92E44
	public X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0xAA1F28
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xAA1F50
	public override int GetHashCode() { }

	// RVA: 0xAA1C44
	public int IndexOf(X509Certificate value) { }

	// RVA: 0xAA1F74
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

	// RVA: 0xAA2200
	public void .ctor() { }

	// RVA: 0xAA2278
	public X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0xAA240C
	public void LoadCertificates(X509CertificateCollection collection) { }

	// RVA: 0xAA2428
	public bool Build(X509Certificate leaf) { }

	// RVA: 0xAA32F4
	public void Reset() { }

	// RVA: 0xAA31BC
	private bool IsValid(X509Certificate cert) { }

	// RVA: 0xAA2A2C
	private X509Certificate FindCertificateParent(X509Certificate child) { }

	// RVA: 0xAA2CC4
	private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	// RVA: 0xAA3354
	private bool IsTrusted(X509Certificate potentialTrusted) { }

	// RVA: 0xAA2FB8
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

	// RVA: 0xAA345C
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xAA38C8
	public void .ctor(X509Extension extension) { }

	// RVA: 0xAA3A6C
	protected virtual void Decode() { }

	// RVA: 0xAA3A70
	protected virtual void Encode() { }

	// RVA: 0xAA3A74
	public string get_Oid() { }

	// RVA: 0xAA3A7C
	public bool get_Critical() { }

	// RVA: 0xAA3A28
	public ASN1 get_Value() { }

	// RVA: 0xAA3A84
	public override bool Equals(object obj) { }

	// RVA: 0xAA3BC8
	public override int GetHashCode() { }

	// RVA: 0xAA3BEC
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0xAA43D4
	public override string ToString() { }

}

// Namespace: Mono.Security.X509
public sealed class X509ExtensionCollection
{
	// Fields
	private bool readOnly; // 0x18

	// Methods

	// RVA: 0xAA44D4
	public void .ctor() { }

	// RVA: 0xA9EBE0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0xAA44DC
	public int IndexOf(string oid) { }

	// RVA: 0xAA4618
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xAA338C
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

	// RVA: 0xAA4640
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0xAA4690
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0xAA4A14
	public ArrayList get_Crls() { }

	// RVA: 0xAA4D84
	private Byte[] Load(string filename) { }

	// RVA: 0xAA4F68
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0xAA4FD8
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0xAA5048
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0xAA46E4
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0xAA4AD0
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

	// RVA: 0xAA5130
	internal static string get_CurrentUserPath() { }

	// RVA: 0xAA5264
	internal static string get_LocalMachinePath() { }

	// RVA: 0xAA5388
	internal static string get_NewCurrentUserPath() { }

	// RVA: 0xAA54AC
	internal static string get_NewLocalMachinePath() { }

	// RVA: 0xAA55D0
	public static X509Stores get_CurrentUser() { }

	// RVA: 0xAA56F4
	public static X509Stores get_LocalMachine() { }

	// RVA: 0xAA2314
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

	// RVA: 0xAA56AC
	internal void .ctor(string path, bool newFormat) { }

	// RVA: 0xAA57D0
	public X509Store get_TrustedRoot() { }

	// RVA: 0xAA58E8
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

	// RVA: 0xAA5A28
	protected void .ctor(string oid, int upperBound) { }

	// RVA: 0xAA5A78
	protected void .ctor(string oid, int upperBound, Byte encoding) { }

	// RVA: 0xA9DB80
	public void set_Value(string value) { }

	// RVA: 0xAA5AC8
	internal ASN1 GetASN1(Byte encoding) { }

	// RVA: 0xA9DC44
	internal ASN1 GetASN1() { }

	// RVA: 0xAA5DA0
	private Byte SelectBestEncoding() { }

}

// Namespace: 
public class CommonName
{
	// Methods

	// RVA: 0xA9C754
	public void .ctor() { }

}

// Namespace: 
public class SerialNumber
{
	// Methods

	// RVA: 0xA9CCA8
	public void .ctor() { }

}

// Namespace: 
public class LocalityName
{
	// Methods

	// RVA: 0xA9C7D0
	public void .ctor() { }

}

// Namespace: 
public class StateOrProvinceName
{
	// Methods

	// RVA: 0xA9C84C
	public void .ctor() { }

}

// Namespace: 
public class OrganizationName
{
	// Methods

	// RVA: 0xA9C65C
	public void .ctor() { }

}

// Namespace: 
public class OrganizationalUnitName
{
	// Methods

	// RVA: 0xA9C6D8
	public void .ctor() { }

}

// Namespace: 
public class EmailAddress
{
	// Methods

	// RVA: 0xA9C8C8
	public void .ctor() { }

}

// Namespace: 
public class DomainComponent
{
	// Methods

	// RVA: 0xA9C944
	public void .ctor() { }

}

// Namespace: 
public class UserId
{
	// Methods

	// RVA: 0xA9C9C0
	public void .ctor() { }

}

// Namespace: 
public class Oid
{
	// Methods

	// RVA: 0xA9CD24
	public void .ctor(string oid) { }

}

// Namespace: 
public class Title
{
	// Methods

	// RVA: 0xA9CAB8
	public void .ctor() { }

}

// Namespace: 
public class CountryName
{
	// Methods

	// RVA: 0xA9C5E0
	public void .ctor() { }

}

// Namespace: 
public class DnQualifier
{
	// Methods

	// RVA: 0xA9CA3C
	public void .ctor() { }

}

// Namespace: 
public class Surname
{
	// Methods

	// RVA: 0xA9CB34
	public void .ctor() { }

}

// Namespace: 
public class GivenName
{
	// Methods

	// RVA: 0xA9CBB0
	public void .ctor() { }

}

// Namespace: 
public class Initial
{
	// Methods

	// RVA: 0xA9CC2C
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

	// RVA: 0xAA5E18
	public void .ctor(X509Extension extension) { }

	// RVA: 0xAA5E1C
	protected override void Decode() { }

	// RVA: 0xAA6034
	protected override void Encode() { }

	// RVA: 0xAA625C
	public Byte[] get_Identifier() { }

	// RVA: 0xAA62D4
	public override string ToString() { }

}

// Namespace: Mono.Security.X509.Extensions
public class BasicConstraintsExtension
{
	// Fields
	private bool cA; // 0x28
	private int pathLenConstraint; // 0x2C

	// Methods

	// RVA: 0xAA3458
	public void .ctor(X509Extension extension) { }

	// RVA: 0xAA6460
	protected override void Decode() { }

	// RVA: 0xAA6684
	protected override void Encode() { }

	// RVA: 0xAA6924
	public bool get_CertificateAuthority() { }

	// RVA: 0xAA692C
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

	// RVA: 0xAA6AD8
	public void .ctor() { }

	// RVA: 0xAA6B68
	public void .ctor(string password, Byte[] challenge) { }

	// RVA: 0xAA7198
	protected override void Finalize() { }

	// RVA: 0xAA6C20
	public void set_Password(string value) { }

	// RVA: 0xAA7040
	public void set_Challenge(Byte[] value) { }

	// RVA: 0xAA745C
	public Byte[] get_LM() { }

	// RVA: 0xAA77AC
	public Byte[] get_NT() { }

	// RVA: 0xAA7230
	public void Dispose() { }

	// RVA: 0xAA7818
	private void Dispose(bool disposing) { }

	// RVA: 0xAA74C8
	private Byte[] GetResponse(Byte[] pwd) { }

	// RVA: 0xAA789C
	private Byte[] PrepareDESKey(Byte[] key56bits, int position) { }

	// RVA: 0xAA7310
	private Byte[] PasswordToKey(string password, int position) { }

	// RVA: 0xAA7A98
	private static void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public static class ChallengeResponse2
{
	// Fields
	private static Byte[] magic; // 0x0
	private static Byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0xAA7B88
	private static Byte[] Compute_LM(string password, Byte[] challenge) { }

	// RVA: 0xAA8338
	private static Byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0xAA8448
	private static Byte[] Compute_NTLM(string password, Byte[] challenge) { }

	// RVA: 0xAA84B8
	private static void Compute_NTLMv2_Session(string password, Byte[] challenge, Byte[] lm, Byte[] ntlm) { }

	// RVA: 0xAA86F0
	private static Byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0xAA8B6C
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, Byte[] lm, Byte[] ntlm) { }

	// RVA: 0xAA8044
	private static Byte[] GetResponse(Byte[] challenge, Byte[] pwd) { }

	// RVA: 0xAA8E18
	private static Byte[] PrepareDESKey(Byte[] key56bits, int position) { }

	// RVA: 0xAA7ED4
	private static Byte[] PasswordToKey(string password, int position) { }

	// RVA: 0xAA9014
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

	// RVA: 0xAA9104
	protected void .ctor(int messageType) { }

	// RVA: 0xAA9130
	public NtlmFlags get_Flags() { }

	// RVA: 0xAA9138
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0xAA9140
	public int get_Type() { }

	// RVA: 0xAA9148
	protected Byte[] PrepareMessage(int messageSize) { }

	// RVA: 0xAA9250
	protected virtual void Decode(Byte[] message) { }

	// RVA: 0xAA9404
	protected bool CheckHeader(Byte[] message) { }

	// RVA: -1
	public abstract Byte[] GetBytes() { }

	// RVA: 0xAA9550
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

	// RVA: 0xAA95F4
	public static NtlmAuthLevel get_DefaultAuthLevel() { }

	// RVA: 0xAA9670
	private static void .cctor() { }

}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type1Message
{
	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Methods

	// RVA: 0xAA96C0
	public void .ctor() { }

	// RVA: 0xAA9768
	public void set_Domain(string value) { }

	// RVA: 0xAA97F8
	public void set_Host(string value) { }

	// RVA: 0xAA9888
	protected override void Decode(Byte[] message) { }

	// RVA: 0xAA9974
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

	// RVA: 0xAA9BD4
	public void .ctor(Byte[] message) { }

	// RVA: 0xAA9C88
	protected override void Finalize() { }

	// RVA: 0xAA9D2C
	public Byte[] get_Nonce() { }

	// RVA: 0xAA9DA8
	public string get_TargetName() { }

	// RVA: 0xAA9DB0
	public Byte[] get_TargetInfo() { }

	// RVA: 0xAA9E2C
	protected override void Decode(Byte[] message) { }

	// RVA: 0xAA9FB8
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

	// RVA: 0xAAA074
	public void .ctor(Type2Message type2) { }

	// RVA: 0xAAA348
	protected override void Finalize() { }

	// RVA: 0xAAA434
	public void set_Domain(string value) { }

	// RVA: 0xAAA4C4
	public void set_Password(string value) { }

	// RVA: 0xAAA4CC
	public void set_Username(string value) { }

	// RVA: 0xAAA4D4
	protected override void Decode(Byte[] message) { }

	// RVA: 0xAAA7A8
	private string DecodeString(Byte[] buffer, int offset, int len) { }

	// RVA: 0xAAA810
	private Byte[] EncodeString(string text) { }

	// RVA: 0xAAA8B0
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

	// RVA: 0xAAAEE4
	public AlertLevel get_Level() { }

	// RVA: 0xAAAEEC
	public AlertDescription get_Description() { }

	// RVA: 0xAAAEF4
	public void .ctor(AlertDescription description) { }

	// RVA: 0xAAAF74
	private void inferAlertLevel() { }

	// RVA: 0xAAAFC0
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

	// RVA: 0xAAB084
	public void .ctor(bool trusted, bool user_denied, int error_code, System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0xAAB0D8
	public bool get_Trusted() { }

	// RVA: 0xAAB0E0
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

	// RVA: 0xAAB0E8
	public CipherSuiteCode get_CipherSuiteCode() { }

	// RVA: 0xAAB0F0
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	// RVA: 0xAAB0F8
	public TlsProtocols get_ProtocolVersion() { }

	// RVA: 0xAAB100
	public void set_ProtocolVersion(TlsProtocols value) { }

	// RVA: 0xAAB108
	public void set_PeerDomainName(string value) { }

	// RVA: 0xAAB110
	public override string ToString() { }

	// RVA: 0xAAB1D4
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

	// RVA: 0xAAB1DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAAB298
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

}

// Namespace: Mono.Security.Interface
public sealed class MonoLocalCertificateSelectionCallback
{
	// Methods

	// RVA: 0xAAB2AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAAB368
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: Mono.Security.Interface
public abstract class MonoTlsProvider
{
	// Methods

	// RVA: 0xAAB37C
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

	// RVA: 0xAAB384
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

	// RVA: 0xAAB400
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	// RVA: 0xAAB408
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	// RVA: 0xAAB410
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	// RVA: 0xAAB418
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0xAAB420
	public System.Nullable<System.Boolean> get_UseServicePointManagerCallback() { }

	// RVA: 0xAAB428
	public void set_UseServicePointManagerCallback(System.Nullable<System.Boolean> value) { }

	// RVA: 0xAAB430
	public bool get_CallbackNeedsCertificateChain() { }

	// RVA: 0xAAB438
	public System.Nullable<System.DateTime> get_CertificateValidationTime() { }

	// RVA: 0xAAB444
	public void set_CertificateValidationTime(System.Nullable<System.DateTime> value) { }

	// RVA: 0xAAB44C
	public X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0xAAB454
	public void set_TrustAnchors(X509CertificateCollection value) { }

	// RVA: 0xAAB45C
	public object get_UserSettings() { }

	// RVA: 0xAAB464
	public void set_UserSettings(object value) { }

	// RVA: 0xAAB46C
	internal string[] get_CertificateSearchPaths() { }

	// RVA: 0xAAB474
	internal void set_CertificateSearchPaths(string[] value) { }

	// RVA: 0xAAB47C
	internal bool get_SendCloseNotify() { }

	// RVA: 0xAAB484
	internal void set_SendCloseNotify(bool value) { }

	// RVA: 0xAAB48C
	public string[] get_ClientCertificateIssuers() { }

	// RVA: 0xAAB494
	public void set_ClientCertificateIssuers(string[] value) { }

	// RVA: 0xAAB49C
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	// RVA: 0xAAB4A4
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	// RVA: 0xAAB4AC
	public System.Nullable<Mono.Security.Interface.TlsProtocols> get_EnabledProtocols() { }

	// RVA: 0xAAB4B4
	public void set_EnabledProtocols(System.Nullable<Mono.Security.Interface.TlsProtocols> value) { }

	// RVA: 0xAAB4BC
	public CipherSuiteCode[] get_EnabledCiphers() { }

	// RVA: 0xAAB4C4
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0xAAB4CC
	public void .ctor() { }

	// RVA: 0xAAB4E0
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0xAAB590
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0xAAB6C4
	public ICertificateValidator get_CertificateValidator() { }

	// RVA: 0xAAB6CC
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0xAAB660
	public MonoTlsSettings Clone() { }

	// RVA: 0xAAB758
	private void .ctor(MonoTlsSettings other) { }

}

// Namespace: Mono.Security.Interface
public sealed class TlsException
{
	// Fields
	private Alert alert; // 0x90

	// Methods

	// RVA: 0xAAB8E0
	public void .ctor(Alert alert) { }

	// RVA: 0xAAB9C4
	public void .ctor(Alert alert, string message) { }

	// RVA: 0xAABA4C
	public void .ctor(AlertDescription description) { }

	// RVA: 0xAABAF8
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

	// RVA: 0xAABC2C
	public static string ToHex(Byte[] input) { }

	// RVA: 0xAABDC4
	private static Byte FromHexChar(Char c) { }

	// RVA: 0xAABE74
	public static Byte[] FromHex(string hex) { }

}

// Namespace: Mono.Security.Cryptography
public abstract class MD2
{
	// Methods

	// RVA: 0xAAC098
	protected void .ctor() { }

	// RVA: 0xAAC0C4
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

	// RVA: 0xAAC1F8
	private Byte[] Padding(int nLength) { }

	// RVA: 0xAAC118
	public void .ctor() { }

	// RVA: 0xAAC2F8
	public override void Initialize() { }

	// RVA: 0xAAC364
	protected override void HashCore(Byte[] array, int ibStart, int cbSize) { }

	// RVA: 0xAAC6D0
	protected override Byte[] HashFinal() { }

	// RVA: 0xAAC448
	private void MD2Transform(Byte[] state, Byte[] checksum, Byte[] block, int index) { }

	// RVA: 0xAAC824
	private static void .cctor() { }

}

// Namespace: Mono.Security.Cryptography
public abstract class MD4
{
	// Methods

	// RVA: 0xAAC8C8
	protected void .ctor() { }

	// RVA: 0xAAC8F4
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

	// RVA: 0xAAC948
	public void .ctor() { }

	// RVA: 0xAACA58
	public override void Initialize() { }

	// RVA: 0xAACB18
	protected override void HashCore(Byte[] array, int ibStart, int cbSize) { }

	// RVA: 0xAAD2B8
	protected override Byte[] HashFinal() { }

	// RVA: 0xAAD508
	private Byte[] Padding(int nLength) { }

	// RVA: 0xAAD58C
	private UInt32 F(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xAAD59C
	private UInt32 G(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xAAD5B0
	private UInt32 H(UInt32 x, UInt32 y, UInt32 z) { }

	// RVA: 0xAAD5BC
	private UInt32 ROL(UInt32 x, Byte n) { }

	// RVA: 0xAAD5C8
	private void FF(UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xAAD5F0
	private void GG(UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xAAD628
	private void HH(UInt32 a, UInt32 b, UInt32 c, UInt32 d, UInt32 x, Byte s) { }

	// RVA: 0xAAD400
	private void Encode(Byte[] output, UInt32[] input) { }

	// RVA: 0xAAD658
	private void Decode(UInt32[] output, Byte[] input, int index) { }

	// RVA: 0xAACC44
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

	// RVA: 0xAAD708
	private static bool Compare(Byte[] array1, Byte[] array2) { }

	// RVA: 0xAAD77C
	public static Byte[] I2OSP(Byte[] x, int size) { }

	// RVA: 0xAAD80C
	public static Byte[] OS2IP(Byte[] x) { }

	// RVA: 0xAAD8DC
	public static Byte[] RSAVP1(RSA rsa, Byte[] s) { }

	// RVA: 0xAAD8FC
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0xAADBC4
	public static Byte[] Encode_v15(HashAlgorithm hash, Byte[] hashValue, int emLength) { }

	// RVA: 0xAADF70
	internal static string HashNameFromOid(string oid, bool throwOnError) { }

	// RVA: 0xAAE4A4
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0xAAE50C
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0xAAE9F8
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

	// RVA: 0xAAEB78
	public void .ctor() { }

	// RVA: 0xAAEBF4
	public void .ctor(Byte[] data) { }

	// RVA: 0xAAEEEC
	public string get_Algorithm() { }

	// RVA: 0xAAEEF4
	public void set_Algorithm(string value) { }

	// RVA: 0xAAEEFC
	public Byte[] get_PrivateKey() { }

	// RVA: 0xAAEF74
	public void set_PrivateKey(Byte[] value) { }

	// RVA: 0xAAEC80
	private void Decode(Byte[] data) { }

	// RVA: 0xAAF07C
	public Byte[] GetBytes() { }

	// RVA: 0xAAF4F8
	private static Byte[] RemoveLeadingZero(Byte[] bigInt) { }

	// RVA: 0xAAF598
	private static Byte[] Normalize(Byte[] bigInt, int length) { }

	// RVA: 0xAAF6BC
	public static RSA DecodeRSA(Byte[] keypair) { }

	// RVA: 0xAAFBEC
	public static Byte[] Encode(RSA rsa) { }

	// RVA: 0xAAFDE8
	public static DSA DecodeDSA(Byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0xAAFF10
	public static Byte[] Encode(DSA dsa) { }

	// RVA: 0xAAFF60
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

	// RVA: 0xAB00C4
	public void .ctor() { }

	// RVA: 0xAB00CC
	public void .ctor(Byte[] data) { }

	// RVA: 0xAB03AC
	public string get_Algorithm() { }

	// RVA: 0xAB03B4
	public void set_Algorithm(string value) { }

	// RVA: 0xAB03BC
	public Byte[] get_EncryptedData() { }

	// RVA: 0xAB0434
	public void set_EncryptedData(Byte[] value) { }

	// RVA: 0xAB04D8
	public Byte[] get_Salt() { }

	// RVA: 0xAB05A0
	public int get_IterationCount() { }

	// RVA: 0xAB05A8
	public void set_IterationCount(int value) { }

	// RVA: 0xAB00FC
	private void Decode(Byte[] data) { }

	// RVA: 0xAB0624
	public Byte[] GetBytes() { }

}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS8
{}

// Namespace: 
public sealed class KeyGeneratedEventHandler
{
	// Methods

	// RVA: 0xAB39B4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAB3AD8
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

	// RVA: 0xAB07F8
	public void .ctor() { }

	// RVA: 0xAB0800
	public void .ctor(int keySize) { }

	// RVA: 0xAB08F4
	protected override void Finalize() { }

	// RVA: 0xAB0990
	private void GenerateKeyPair() { }

	// RVA: 0xAB18E4
	public override int get_KeySize() { }

	// RVA: 0xAB198C
	public bool get_PublicOnly() { }

	// RVA: 0xAB1B78
	public override Byte[] EncryptValue(Byte[] rgb) { }

	// RVA: 0xAB215C
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0xAB27C4
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0xAB2D98
	protected override void Dispose(bool disposing) { }

	// RVA: 0xAB3310
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0xAB2048
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

	// RVA: 0xAB3AEC
	public void .ctor() { }

	// RVA: 0xAB3B5C
	internal int get_PEOffset() { }

	// RVA: 0xAB3C7C
	internal void Open(string filename) { }

	// RVA: 0xAB3D7C
	internal void Open(Byte[] rawdata) { }

	// RVA: 0xAB3D30
	internal void Close() { }

	// RVA: 0xAB3BA0
	internal void ReadFirstBlock() { }

	// RVA: 0xAB3E28
	internal int ProcessFirstBlock() { }

	// RVA: 0xAB409C
	internal Byte[] GetSecurityEntry() { }

	// RVA: 0xAB4190
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

	// RVA: 0xAB4650
	public void .ctor() { }

	// RVA: 0xAB4738
	public void .ctor(Byte[] rawData) { }

	// RVA: 0xAB4764
	public void set_RawData(Byte[] value) { }

	// RVA: 0xAB4DBC
	public X509Certificate get_SigningCertificate() { }

	// RVA: 0xAB4960
	private bool CheckSignature() { }

	// RVA: 0xAB57CC
	private bool CompareIssuerSerial(string issuer, Byte[] serial, X509Certificate x509) { }

	// RVA: 0xAB4DC4
	private bool VerifySignature(SignedData sd, Byte[] calculatedMessageDigest, HashAlgorithm ha) { }

	// RVA: 0xAB58F0
	private bool VerifyCounterSignature(SignerInfo cs, Byte[] signature) { }

	// RVA: 0xAB4850
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

	// RVA: 0xAB8908
	public void .ctor(BigInteger modulus) { }

	// RVA: 0xAB8D68
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0xAB9800
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0xAB9A44
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0xAB8A84
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0xAB9C68
	public BigInteger Pow(UInt32 b, BigInteger exp) { }

}

// Namespace: 
private sealed class Kernel
{
	// Methods

	// RVA: 0xAB6850
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0xAB947C
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0xAB9594
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB66F0
	public static Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB8014
	public static UInt32 SingleByteDivideInPlace(BigInteger n, UInt32 d) { }

	// RVA: 0xAB6AA8
	public static UInt32 DwordMod(BigInteger n, UInt32 d) { }

	// RVA: 0xAB9D4C
	public static BigInteger[] DwordDivMod(BigInteger n, UInt32 d) { }

	// RVA: 0xAB6B1C
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB7298
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0xAB7514
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0xAB718C
	public static void Multiply(UInt32[] x, UInt32 xOffset, UInt32 xLen, UInt32[] y, UInt32 yOffset, UInt32 yLen, UInt32[] d, UInt32 dOffset) { }

	// RVA: 0xAB934C
	public static void MultiplyMod2p32pmod(UInt32[] x, int xOffset, int xLen, UInt32[] y, int yOffest, int yLen, UInt32[] d, int dOffset, int mod) { }

	// RVA: 0xAB9F98
	public static UInt32 modInverse(BigInteger bi, UInt32 modulus) { }

	// RVA: 0xAB82E0
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

	// RVA: 0xAB62DC
	public void .ctor(Sign sign, UInt32 len) { }

	// RVA: 0xAB6360
	public void .ctor(BigInteger bi) { }

	// RVA: 0xAB6454
	public void .ctor(BigInteger bi, UInt32 len) { }

	// RVA: 0xAB1D48
	public void .ctor(Byte[] inData) { }

	// RVA: 0xAB65CC
	public void .ctor(UInt32 ui) { }

	// RVA: 0xAB0F00
	public static BigInteger op_Implicit(UInt32 value) { }

	// RVA: 0xAB15E0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0xAB16F8
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB1044
	public static UInt32 op_Modulus(BigInteger bi, UInt32 ui) { }

	// RVA: 0xAB18B4
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB7160
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB11C0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB7294
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0xAB7510
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0xAB7728
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0xAB7808
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0xAB7A08
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0xAB151C
	public int BitCount() { }

	// RVA: 0xAB7A70
	public bool TestBit(int bitNum) { }

	// RVA: 0xAB7B10
	public void SetBit(UInt32 bitNum) { }

	// RVA: 0xAB7B64
	public void SetBit(UInt32 bitNum, bool value) { }

	// RVA: 0xAB7BDC
	public int LowestSetBit() { }

	// RVA: 0xAB2504
	public Byte[] GetBytes() { }

	// RVA: 0xAB6660
	public static bool op_Equality(BigInteger bi1, UInt32 ui) { }

	// RVA: 0xAB7C88
	public static bool op_Inequality(BigInteger bi1, UInt32 ui) { }

	// RVA: 0xAB1A70
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB10B8
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB7D18
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB15C8
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB7D34
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB7D50
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0xAB7D6C
	public string ToString(UInt32 radix) { }

	// RVA: 0xAB7DC8
	public string ToString(UInt32 radix, string characterSet) { }

	// RVA: 0xAB656C
	private void Normalize() { }

	// RVA: 0xAB2104
	public void Clear() { }

	// RVA: 0xAB80D0
	public override int GetHashCode() { }

	// RVA: 0xAB812C
	public override string ToString() { }

	// RVA: 0xAB8184
	public override bool Equals(object o) { }

	// RVA: 0xAB18B0
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0xAB1FC4
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0xAB0FCC
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0xAB8C34
	public void Incr2() { }

	// RVA: 0xAB8CC4
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

	// RVA: 0xABA0D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xABA1FC
	public virtual bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }

}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTests
{
	// Methods

	// RVA: 0xABA210
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0xABA3DC
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }

}

// Namespace: Mono.Math.Prime.Generator
public abstract class PrimeGeneratorBase
{
	// Methods

	// RVA: 0xABA918
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0xABA920
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0xABA998
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1
	public abstract BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0xABA9A0
	protected void .ctor() { }

}

// Namespace: Mono.Math.Prime.Generator
public class SequentialSearchPrimeGeneratorBase
{
	// Methods

	// RVA: 0xABA9A8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0xABAAB0
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0xABAAC0
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0xABAEA8
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0xAB8C2C
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

	// RVA: 0xAAE418
	internal static UInt32 ComputeStringHash(string s) { }

}


