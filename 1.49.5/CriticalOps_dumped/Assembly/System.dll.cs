// Namespace: 
internal class <Module>
{}

// Namespace: Mono
internal class SystemCertificateProvider
{
	// Fields
	private static MonoTlsProvider provider; // 0x0
	private static int initialized; // 0x8
	private static X509PalImpl x509pal; // 0x10
	private static object syncRoot; // 0x18

	// Methods

	// RVA: 0xECE6EC
	private static X509PalImpl GetX509Pal() { }

	// RVA: 0xECEA98
	private static void EnsureInitialized() { }

	// RVA: 0xECEC20
	public X509PalImpl get_X509Pal() { }

	// RVA: 0xECEC80
	public X509CertificateImpl Import(Byte[] data, CertificateImportFlags importFlags) { }

	// RVA: 0xECEF94
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0xECEF98
	public X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0xECF208
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0xECF20C
	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0xECF3F0
	public void .ctor() { }

	// RVA: 0xECF3F8
	private static void .cctor() { }

}

// Namespace: Mono
internal class SystemDependencyProvider
{
	// Fields
	private static SystemDependencyProvider instance; // 0x0
	private static object syncRoot; // 0x8
	private readonly SystemCertificateProvider <CertificateProvider>k__BackingField; // 0x10

	// Methods

	// RVA: 0xECF478
	public static SystemDependencyProvider get_Instance() { }

	// RVA: 0xECF4D8
	internal static void Initialize() { }

	// RVA: 0xECF700
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

	// RVA: 0xECF708
	public SystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0xECF710
	public X509PalImpl get_X509Pal() { }

	// RVA: 0xECF640
	private void .ctor() { }

	// RVA: 0xECF77C
	private static void .cctor() { }

}

// Namespace: Mono
internal static class X509Pal
{
	// Methods

	// RVA: 0xECF7FC
	public static X509PalImpl get_Instance() { }

}

// Namespace: Mono
internal class X509PalImplMono
{
	// Methods

	// RVA: 0xECF920
	public override X509CertificateImpl Import(Byte[] data) { }

	// RVA: 0xECF924
	public override X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xECF9A4
	public override X509Certificate2Impl Import(X509Certificate cert) { }

	// RVA: 0xECEA10
	public void .ctor() { }

}

// Namespace: Mono
internal abstract class X509PalImpl
{
	// Fields
	private static Byte[] signedData; // 0x0

	// Methods

	// RVA: -1
	public abstract X509CertificateImpl Import(Byte[] data) { }

	// RVA: -1
	public abstract X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: -1
	public abstract X509Certificate2Impl Import(X509Certificate cert) { }

	// RVA: 0xECF9B4
	private static Byte[] PEM(string type, Byte[] data) { }

	// RVA: 0xECFAF8
	protected static Byte[] ConvertData(Byte[] data) { }

	// RVA: 0xECEDE0
	internal X509Certificate2Impl ImportFallback(Byte[] data) { }

	// RVA: 0xECF188
	internal X509Certificate2Impl ImportFallback(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0xECFC18
	public bool get_SupportsLegacyBasicConstraintsExtension() { }

	// RVA: 0xECFC20
	public X509ContentType GetCertContentType(Byte[] rawData) { }

	// RVA: 0xECF9AC
	protected void .ctor() { }

	// RVA: 0xED0078
	private static void .cctor() { }

}

// Namespace: Mono.Util
internal sealed class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0xED011C
	public void .ctor(Type t) { }

}

// Namespace: Mono.Unity
internal static class CertHelper
{
	// Methods

	// RVA: 0xED0124
	public static void AddCertificatesToNativeChain(unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, unitytls_errorstate* errorState) { }

	// RVA: 0xED02E0
	public static void AddCertificateToNativeChain(unitytls_x509list* nativeCertificateChain, X509Certificate certificate, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class Debug
{
	// Methods

	// RVA: 0xED058C
	public static void CheckAndThrow(unitytls_errorstate errorState, string context, AlertDescription defaultAlert) { }

	// RVA: 0xED062C
	public static void CheckAndThrow(unitytls_errorstate errorState, unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert) { }

}

// Namespace: 
public enum unitytls_error_code
{
	// Fields
	public UInt32 value__; // 0x10
	public const unitytls_error_code UNITYTLS_SUCCESS = 0;
	public const unitytls_error_code UNITYTLS_INVALID_ARGUMENT = 1;
	public const unitytls_error_code UNITYTLS_INVALID_FORMAT = 2;
	public const unitytls_error_code UNITYTLS_INVALID_PASSWORD = 3;
	public const unitytls_error_code UNITYTLS_INVALID_STATE = 4;
	public const unitytls_error_code UNITYTLS_BUFFER_OVERFLOW = 5;
	public const unitytls_error_code UNITYTLS_OUT_OF_MEMORY = 6;
	public const unitytls_error_code UNITYTLS_INTERNAL_ERROR = 7;
	public const unitytls_error_code UNITYTLS_NOT_SUPPORTED = 8;
	public const unitytls_error_code UNITYTLS_ENTROPY_SOURCE_FAILED = 9;
	public const unitytls_error_code UNITYTLS_STREAM_CLOSED = 10;
	public const unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_START = 1048576;
	public const unitytls_error_code UNITYTLS_USER_WOULD_BLOCK = 1048577;
	public const unitytls_error_code UNITYTLS_USER_READ_FAILED = 1048578;
	public const unitytls_error_code UNITYTLS_USER_WRITE_FAILED = 1048579;
	public const unitytls_error_code UNITYTLS_USER_UNKNOWN_ERROR = 1048580;
	public const unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_END = 2097152;
}

// Namespace: 
public struct unitytls_errorstate
{
	// Fields
	private UInt32 magic; // 0x10
	public unitytls_error_code code; // 0x14
	private UInt64 reserved; // 0x18
}

// Namespace: 
public struct unitytls_key
{}

// Namespace: 
public struct unitytls_key_ref
{
	// Fields
	public UInt64 handle; // 0x10
}

// Namespace: 
public struct unitytls_x509_ref
{
	// Fields
	public UInt64 handle; // 0x10
}

// Namespace: 
public struct unitytls_x509list
{}

// Namespace: 
public struct unitytls_x509list_ref
{
	// Fields
	public UInt64 handle; // 0x10
}

// Namespace: 
public enum unitytls_x509verify_result
{
	// Fields
	public UInt32 value__; // 0x10
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_SUCCESS = 0;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_NOT_DONE = 2147483648;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_REVOKED = 2;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608;
	public const unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728;
}

// Namespace: 
public sealed class unitytls_x509verify_callback
{
	// Methods

	// RVA: 0xED077C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED0838
	public virtual unitytls_x509verify_result Invoke(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

}

// Namespace: 
public struct unitytls_tlsctx
{}

// Namespace: 
public struct unitytls_x509name
{}

// Namespace: 
public enum unitytls_ciphersuite
{
	// Fields
	public UInt32 value__; // 0x10
	public const unitytls_ciphersuite UNITYTLS_CIPHERSUITE_INVALID = 16777215;
}

// Namespace: 
public enum unitytls_protocol
{
	// Fields
	public UInt32 value__; // 0x10
	public const unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_0 = 0;
	public const unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_1 = 1;
	public const unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_2 = 2;
	public const unitytls_protocol UNITYTLS_PROTOCOL_INVALID = 3;
}

// Namespace: 
public struct unitytls_tlsctx_protocolrange
{
	// Fields
	public unitytls_protocol min; // 0x10
	public unitytls_protocol max; // 0x14
}

// Namespace: 
public sealed class unitytls_tlsctx_write_callback
{
	// Methods

	// RVA: 0xED084C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED0908
	public virtual IntPtr Invoke(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_callback
{
	// Methods

	// RVA: 0xED091C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED09D8
	public virtual IntPtr Invoke(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_trace_callback
{
	// Methods

	// RVA: 0xED09EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED0AA8
	public virtual void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* traceMessage, IntPtr traceMessageLen) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_certificate_callback
{
	// Methods

	// RVA: 0xED0ABC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED0B78
	public virtual void Invoke(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_x509verify_callback
{
	// Methods

	// RVA: 0xED0B98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED0C54
	public virtual unitytls_x509verify_result Invoke(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

}

// Namespace: 
public struct unitytls_tlsctx_callbacks
{
	// Fields
	public unitytls_tlsctx_read_callback read; // 0x10
	public unitytls_tlsctx_write_callback write; // 0x18
	public Void* data; // 0x20
}

// Namespace: 
public sealed class unitytls_errorstate_create_t
{
	// Methods

	// RVA: 0xED0C70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED0D10
	public virtual unitytls_errorstate Invoke() { }

}

// Namespace: 
public sealed class unitytls_errorstate_raise_error_t
{
	// Methods

	// RVA: 0xED0D24
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED0DE0
	public virtual void Invoke(unitytls_errorstate* errorState, unitytls_error_code errorCode) { }

}

// Namespace: 
public sealed class unitytls_key_get_ref_t
{
	// Methods

	// RVA: 0xED0DF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED0EB0
	public virtual unitytls_key_ref Invoke(unitytls_key* key, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_parse_der_t
{
	// Methods

	// RVA: 0xED0EC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED0F80
	public virtual unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_parse_pem_t
{
	// Methods

	// RVA: 0xED0F94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1050
	public virtual unitytls_key* Invoke(Byte* buffer, IntPtr bufferLen, Byte* password, IntPtr passwordLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_key_free_t
{
	// Methods

	// RVA: 0xED1064
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1118
	public virtual void Invoke(unitytls_key* key) { }

}

// Namespace: 
public sealed class unitytls_x509_export_der_t
{
	// Methods

	// RVA: 0xED112C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED11D0
	public virtual IntPtr Invoke(unitytls_x509_ref cert, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_ref_t
{
	// Methods

	// RVA: 0xED11E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED12A0
	public virtual unitytls_x509list_ref Invoke(unitytls_x509list* list, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_get_x509_t
{
	// Methods

	// RVA: 0xED12B4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1358
	public virtual unitytls_x509_ref Invoke(unitytls_x509list_ref list, IntPtr index, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_create_t
{
	// Methods

	// RVA: 0xED136C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1420
	public virtual unitytls_x509list* Invoke(unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_t
{
	// Methods

	// RVA: 0xED1434
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED14F0
	public virtual void Invoke(unitytls_x509list* list, unitytls_x509_ref cert, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_append_der_t
{
	// Methods

	// RVA: 0xED1504
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED15C0
	public virtual void Invoke(unitytls_x509list* list, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509list_free_t
{
	// Methods

	// RVA: 0xED15D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1688
	public virtual void Invoke(unitytls_x509list* list) { }

}

// Namespace: 
public sealed class unitytls_x509verify_default_ca_t
{
	// Methods

	// RVA: 0xED169C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1740
	public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_x509verify_explicit_ca_t
{
	// Methods

	// RVA: 0xED1754
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED17F8
	public virtual unitytls_x509verify_result Invoke(unitytls_x509list_ref chain, unitytls_x509list_ref trustCA, Byte* cn, IntPtr cnLen, unitytls_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_server_t
{
	// Methods

	// RVA: 0xED1810
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED18B4
	public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, UInt64 certChain, UInt64 leafCertificateKey, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_create_client_t
{
	// Methods

	// RVA: 0xED18F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1998
	public virtual unitytls_tlsctx* Invoke(unitytls_tlsctx_protocolrange supportedProtocols, unitytls_tlsctx_callbacks callbacks, Byte* cn, IntPtr cnLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_server_require_client_authentication_t
{
	// Methods

	// RVA: 0xED19D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1A94
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_x509list_ref clientAuthCAList, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_certificate_callback_t
{
	// Methods

	// RVA: 0xED1AA8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1B64
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_certificate_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_trace_callback_t
{
	// Methods

	// RVA: 0xED1B78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1C34
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_trace_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_x509verify_callback_t
{
	// Methods

	// RVA: 0xED1C48
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1D04
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_tlsctx_x509verify_callback cb, Void* userData, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_set_supported_ciphersuites_t
{
	// Methods

	// RVA: 0xED1D18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1DD4
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_ciphersuite_t
{
	// Methods

	// RVA: 0xED1DE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1EA4
	public virtual unitytls_ciphersuite Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_get_protocol_t
{
	// Methods

	// RVA: 0xED1EB8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED1F74
	public virtual unitytls_protocol Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_process_handshake_t
{
	// Methods

	// RVA: 0xED1F88
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED2044
	public virtual unitytls_x509verify_result Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_read_t
{
	// Methods

	// RVA: 0xED2058
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED2114
	public virtual IntPtr Invoke(unitytls_tlsctx* ctx, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_write_t
{
	// Methods

	// RVA: 0xED2128
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED21E4
	public virtual IntPtr Invoke(unitytls_tlsctx* ctx, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_notify_close_t
{
	// Methods

	// RVA: 0xED21F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED22B4
	public virtual void Invoke(unitytls_tlsctx* ctx, unitytls_errorstate* errorState) { }

}

// Namespace: 
public sealed class unitytls_tlsctx_free_t
{
	// Methods

	// RVA: 0xED22C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED237C
	public virtual void Invoke(unitytls_tlsctx* ctx) { }

}

// Namespace: 
public sealed class unitytls_random_generate_bytes_t
{
	// Methods

	// RVA: 0xED2390
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xED244C
	public virtual void Invoke(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

// Namespace: 
public class unitytls_interface_struct
{
	// Fields
	public readonly UInt64 UNITYTLS_INVALID_HANDLE; // 0x10
	public readonly unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT; // 0x18
	public unitytls_errorstate_create_t unitytls_errorstate_create; // 0x20
	public unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error; // 0x28
	public unitytls_key_get_ref_t unitytls_key_get_ref; // 0x30
	public unitytls_key_parse_der_t unitytls_key_parse_der; // 0x38
	public unitytls_key_parse_pem_t unitytls_key_parse_pem; // 0x40
	public unitytls_key_free_t unitytls_key_free; // 0x48
	public unitytls_x509_export_der_t unitytls_x509_export_der; // 0x50
	public unitytls_x509list_get_ref_t unitytls_x509list_get_ref; // 0x58
	public unitytls_x509list_get_x509_t unitytls_x509list_get_x509; // 0x60
	public unitytls_x509list_create_t unitytls_x509list_create; // 0x68
	public unitytls_x509list_append_t unitytls_x509list_append; // 0x70
	public unitytls_x509list_append_der_t unitytls_x509list_append_der; // 0x78
	public unitytls_x509list_append_der_t unitytls_x509list_append_pem; // 0x80
	public unitytls_x509list_free_t unitytls_x509list_free; // 0x88
	public unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca; // 0x90
	public unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca; // 0x98
	public unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server; // 0xA0
	public unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client; // 0xA8
	public unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication; // 0xB0
	public unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback; // 0xB8
	public unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback; // 0xC0
	public unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback; // 0xC8
	public unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites; // 0xD0
	public unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite; // 0xD8
	public unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol; // 0xE0
	public unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake; // 0xE8
	public unitytls_tlsctx_read_t unitytls_tlsctx_read; // 0xF0
	public unitytls_tlsctx_write_t unitytls_tlsctx_write; // 0xF8
	public unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close; // 0x100
	public unitytls_tlsctx_free_t unitytls_tlsctx_free; // 0x108
	public unitytls_random_generate_bytes_t unitytls_random_generate_bytes; // 0x110

	// Methods

	// RVA: 0xED0C68
	public void .ctor() { }

}

// Namespace: Mono.Unity
internal static class UnityTls
{
	// Fields
	private static unitytls_interface_struct marshalledInterface; // 0x0

	// Methods

	// RVA: 0xED075C
	private static IntPtr GetUnityTlsInterface() { }

	// RVA: 0xED0760
	public static bool get_IsSupported() { }

	// RVA: 0xED0494
	public static unitytls_interface_struct get_NativeInterface() { }

}

// Namespace: Mono.Unity
internal class UnityTlsContext
{
	// Fields
	private unitytls_tlsctx* tlsContext; // 0x58
	private unitytls_x509list* requestedClientCertChain; // 0x60
	private unitytls_key* requestedClientKey; // 0x68
	private unitytls_tlsctx_read_callback readCallback; // 0x70
	private unitytls_tlsctx_write_callback writeCallback; // 0x78
	private unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
	private unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
	private X509Certificate localClientCertificate; // 0x90
	private X509Certificate2 remoteCertificate; // 0x98
	private MonoTlsConnectionInfo connectioninfo; // 0xA0
	private bool isAuthenticated; // 0xA8
	private bool hasContext; // 0xA9
	private bool closedGraceful; // 0xAA
	private Byte[] writeBuffer; // 0xB0
	private Byte[] readBuffer; // 0xB8
	private GCHandle handle; // 0xC0
	private Exception lastException; // 0xC8

	// Methods

	// RVA: 0xED2790
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xED32C4
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, unitytls_errorstate* errorState, unitytls_x509list* nativeCertChain, unitytls_key* nativeKey) { }

	// RVA: 0xED363C
	public override bool get_IsAuthenticated() { }

	// RVA: 0xED3644
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xED364C
	public override X509Certificate2 get_RemoteCertificate() { }

	// RVA: 0xED3654
	public override void Flush() { }

	// RVA: 0xED3658
	public override System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xED3840
	public override System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xED3A08
	public override void Renegotiate() { }

	// RVA: 0xED3A48
	public override bool PendingRenegotiation() { }

	// RVA: 0xED3A50
	public override void Shutdown() { }

	// RVA: 0xED3B74
	protected override void Dispose(bool disposing) { }

	// RVA: 0xED3C7C
	public override void StartHandshake() { }

	// RVA: 0xED3E5C
	public override bool ProcessHandshake() { }

	// RVA: 0xED4058
	public override void FinishHandshake() { }

	// RVA: 0xED2460
	private static IntPtr WriteCallback(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xED41B0
	private IntPtr WriteCallback(Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xED2534
	private static IntPtr ReadCallback(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xED4620
	private IntPtr ReadCallback(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	// RVA: 0xED2608
	private static unitytls_x509verify_result VerifyCallback(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xED4A90
	private unitytls_x509verify_result VerifyCallback(unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	// RVA: 0xED26C4
	private static void CertificateCallback(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	// RVA: 0xED4F7C
	private void CertificateCallback(unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

}

// Namespace: Mono.Unity
internal static class UnityTlsConversions
{
	// Methods

	// RVA: 0xED3260
	public static unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0xED3290
	public static unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0xED4190
	public static TlsProtocols ConvertProtocolVersion(unitytls_protocol protocol) { }

	// RVA: 0xED0704
	public static AlertDescription VerifyResultToAlertDescription(unitytls_x509verify_result verifyResult, AlertDescription defaultAlert) { }

	// RVA: 0xED581C
	public static SslPolicyErrors VerifyResultToPolicyErrror(unitytls_x509verify_result verifyResult) { }

	// RVA: 0xED584C
	public static X509ChainStatusFlags VerifyResultToChainStatus(unitytls_x509verify_result verifyResult) { }

}

// Namespace: Mono.Unity
internal class UnityTlsProvider
{
	// Methods

	// RVA: 0xED58EC
	public override string get_Name() { }

	// RVA: 0xED5930
	public override Guid get_ID() { }

	// RVA: 0xED59AC
	public override bool get_SupportsSslStream() { }

	// RVA: 0xED59B4
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0xED59BC
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0xED59C4
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0xED59CC
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0xED59D4
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xED5884
	private static unitytls_x509verify_result x509verify_callback(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

	// RVA: 0xED5B3C
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, SslPolicyErrors errors, int status11) { }

	// RVA: 0xED678C
	public void .ctor() { }

}

// Namespace: Mono.Unity
internal class UnityTlsStream
{
	// Methods

	// RVA: 0xED5AA4
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0xED699C
	protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

// Namespace: Mono.Unity
internal class X509ChainImplUnityTls
{
	// Fields
	private X509ChainElementCollection elements; // 0x10
	private unitytls_x509list* ownedList; // 0x18
	private unitytls_x509list_ref nativeCertificateChain; // 0x20
	private X509ChainPolicy policy; // 0x28
	private System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList; // 0x30
	private bool reverseOrder; // 0x38

	// Methods

	// RVA: 0xED4ED8
	internal void .ctor(unitytls_x509list_ref nativeCertificateChain, bool reverseOrder) { }

	// RVA: 0xED66B0
	internal void .ctor(unitytls_x509list* ownedList, unitytls_errorstate* errorState, bool reverseOrder) { }

	// RVA: 0xED6A08
	public override bool get_IsValid() { }

	// RVA: 0xED6A3C
	internal unitytls_x509list_ref get_NativeCertificateChain() { }

	// RVA: 0xED6A44
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0xED6D54
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0xED6E58
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0xED6E60
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0xED6E68
	public override void Reset() { }

	// RVA: 0xED6EF4
	protected override void Dispose(bool disposing) { }

}

// Namespace: Mono.Net.Security
internal class BufferOffsetSize
{
	// Fields
	public Byte[] Buffer; // 0x10
	public int Offset; // 0x18
	public int Size; // 0x1C
	public int TotalBytes; // 0x20
	public bool Complete; // 0x24

	// Methods

	// RVA: 0xED6F2C
	public int get_EndOffset() { }

	// RVA: 0xED6F38
	public int get_Remaining() { }

	// RVA: 0xED6F64
	public void .ctor(Byte[] buffer, int offset, int size) { }

	// RVA: 0xED7080
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class BufferOffsetSize2
{
	// Fields
	public readonly int InitialSize; // 0x28

	// Methods

	// RVA: 0xED7128
	public void .ctor(int size) { }

	// RVA: 0xED719C
	public void Reset() { }

	// RVA: 0xED7210
	public void MakeRoom(int size) { }

	// RVA: 0xED72E8
	public void AppendData(Byte[] buffer, int offset, int size) { }

}

// Namespace: Mono.Net.Security
internal enum AsyncOperationStatus
{
	// Fields
	public int value__; // 0x10
	public const AsyncOperationStatus Initialize = 0;
	public const AsyncOperationStatus Continue = 1;
	public const AsyncOperationStatus ReadDone = 2;
	public const AsyncOperationStatus Complete = 3;
}

// Namespace: Mono.Net.Security
internal class AsyncProtocolResult
{
	// Fields
	private readonly int <UserResult>k__BackingField; // 0x10
	private readonly ExceptionDispatchInfo <Error>k__BackingField; // 0x18

	// Methods

	// RVA: 0xED734C
	public int get_UserResult() { }

	// RVA: 0xED7354
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0xED735C
	public void .ctor(int result) { }

	// RVA: 0xED7388
	public void .ctor(ExceptionDispatchInfo error) { }

}

// Namespace: 
private struct <StartOperation>d__23
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Mono.Net.Security.AsyncProtocolResult> <>t__builder; // 0x18
	public AsyncProtocolRequest <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0xED7974
	private void MoveNext() { }

	// RVA: 0xED7DA0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <ProcessOperation>d__24
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public AsyncProtocolRequest <>4__this; // 0x38
	private AsyncOperationStatus <status>5__2; // 0x40
	private AsyncOperationStatus <newStatus>5__3; // 0x44
	private ConfiguredTaskAwaiter <>u__1; // 0x48
	private ConfiguredTaskAwaiter <>u__2; // 0x58

	// Methods

	// RVA: 0xED7E20
	private void MoveNext() { }

	// RVA: 0xED8A40
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InnerRead>d__25
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<System.Int32>> <>t__builder; // 0x18
	public AsyncProtocolRequest <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private System.Nullable<System.Int32> <totalRead>5__2; // 0x40
	private int <requestedSize>5__3; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0xED8AAC
	private void MoveNext() { }

	// RVA: 0xED91D8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Mono.Net.Security
internal abstract class AsyncProtocolRequest
{
	// Fields
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Methods

	// RVA: 0xED73BC
	public MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xED73C4
	public bool get_RunSynchronously() { }

	// RVA: 0xED73CC
	public string get_Name() { }

	// RVA: 0xED73F4
	public int get_UserResult() { }

	// RVA: 0xED73FC
	protected void set_UserResult(int value) { }

	// RVA: 0xED7404
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0xED74A4
	internal void RequestRead(int size) { }

	// RVA: 0xED757C
	internal void RequestWrite() { }

	// RVA: 0xED7588
	internal System.Threading.Tasks.Task<Mono.Net.Security.AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	// RVA: 0xED76BC
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	// RVA: 0xED77CC
	private System.Threading.Tasks.Task<System.Nullable<System.Int32>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	// RVA: 0xED7904
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class AsyncHandshakeRequest
{
	// Methods

	// RVA: 0xED9258
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0xED92F8
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal abstract class AsyncReadOrWriteRequest
{
	// Fields
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	private int <CurrentSize>k__BackingField; // 0x40

	// Methods

	// RVA: 0xED9704
	protected BufferOffsetSize get_UserBuffer() { }

	// RVA: 0xED970C
	protected int get_CurrentSize() { }

	// RVA: 0xED9714
	protected void set_CurrentSize(int value) { }

	// RVA: 0xED971C
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xED9828
	public override string ToString() { }

}

// Namespace: Mono.Net.Security
internal class AsyncReadRequest
{
	// Methods

	// RVA: 0xED989C
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xED98A0
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: Mono.Net.Security
internal class AsyncWriteRequest
{
	// Methods

	// RVA: 0xED9A88
	public void .ctor(MobileAuthenticatedStream parent, bool sync, Byte[] buffer, int offset, int size) { }

	// RVA: 0xED9A8C
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public MonoTlsSettings settings; // 0x10

	// Methods

	// RVA: 0xEDA548
	public void .ctor() { }

	// RVA: 0xEDAF48
	internal bool <GetValidationCallback>b__0(object s, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

}

// Namespace: Mono.Net.Security
internal class ChainValidationHelper
{
	// Fields
	private readonly System.WeakReference<System.Net.Security.SslStream> owner; // 0x10
	private readonly MonoTlsSettings settings; // 0x18
	private readonly MobileTlsProvider provider; // 0x20
	private readonly ServerCertValidationCallback certValidationCallback; // 0x28
	private readonly LocalCertSelectionCallback certSelectionCallback; // 0x30
	private readonly MonoTlsStream tlsStream; // 0x38
	private readonly HttpWebRequest request; // 0x40

	// Methods

	// RVA: 0xED9C98
	internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0xEDA188
	internal static ChainValidationHelper Create(MobileTlsProvider provider, MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0xED9D84
	private void .ctor(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	// RVA: 0xEDA34C
	private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	// RVA: 0xEDA550
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0xEDA59C
	public MonoTlsSettings get_Settings() { }

	// RVA: 0xEDA5A4
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, X509Certificate clientCertificate) { }

	// RVA: 0xEDA5FC
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0xEDA7D4
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0xEDA8C0
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0xEDAE68
	private bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors) { }

}

// Namespace: 
private enum Operation
{
	// Fields
	public int value__; // 0x10
	public const Operation None = 0;
	public const Operation Handshake = 1;
	public const Operation Authenticated = 2;
	public const Operation Renegotiate = 3;
	public const Operation Read = 4;
	public const Operation Write = 5;
	public const Operation Close = 6;
}

// Namespace: 
private enum OperationType
{
	// Fields
	public int value__; // 0x10
	public const OperationType Read = 0;
	public const OperationType Write = 1;
	public const OperationType Renegotiate = 2;
	public const OperationType Shutdown = 3;
}

// Namespace: 
private struct <ProcessAuthentication>d__48
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public MonoSslAuthenticationOptions options; // 0x30
	public MobileAuthenticatedStream <>4__this; // 0x38
	public bool runSynchronously; // 0x40
	public CancellationToken cancellationToken; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0xEDCAC0
	private void MoveNext() { }

	// RVA: 0xEDD570
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <StartOperation>d__57
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32> <>t__builder; // 0x18
	public MobileAuthenticatedStream <>4__this; // 0x30
	public OperationType type; // 0x38
	public AsyncProtocolRequest asyncRequest; // 0x40
	public CancellationToken cancellationToken; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0xEDD5DC
	private void MoveNext() { }

	// RVA: 0xEDDE88
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass66_0
{
	// Fields
	public MobileAuthenticatedStream <>4__this; // 0x10
	public int len; // 0x18

	// Methods

	// RVA: 0xEDDF08
	public void .ctor() { }

	// RVA: 0xEDDF10
	internal int <InnerRead>b__0() { }

}

// Namespace: 
private struct <InnerRead>d__66
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32> <>t__builder; // 0x18
	public MobileAuthenticatedStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public int requestedSize; // 0x40
	public bool sync; // 0x44
	private ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0xEDDF5C
	private void MoveNext() { }

	// RVA: 0xEDE458
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InnerWrite>d__67
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public MobileAuthenticatedStream <>4__this; // 0x38
	public bool sync; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0xEDE4D8
	private void MoveNext() { }

	// RVA: 0xEDE814
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Mono.Net.Security
internal abstract class MobileAuthenticatedStream
{
	// Fields
	private MobileTlsContext xobileTlsContext; // 0x38
	private ExceptionDispatchInfo lastException; // 0x40
	private AsyncProtocolRequest asyncHandshakeRequest; // 0x48
	private AsyncProtocolRequest asyncReadRequest; // 0x50
	private AsyncProtocolRequest asyncWriteRequest; // 0x58
	private BufferOffsetSize2 readBuffer; // 0x60
	private BufferOffsetSize2 writeBuffer; // 0x68
	private object ioLock; // 0x70
	private int closeRequested; // 0x78
	private bool shutdown; // 0x7C
	private Operation operation; // 0x80
	private static int uniqueNameInteger; // 0x0
	private readonly SslStream <SslStream>k__BackingField; // 0x88
	private readonly MonoTlsSettings <Settings>k__BackingField; // 0x90
	private readonly MobileTlsProvider <Provider>k__BackingField; // 0x98
	private string <TargetHost>k__BackingField; // 0xA0
	private static int nextId; // 0x4
	internal readonly int ID; // 0xA8

	// Methods

	// RVA: 0xED679C
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0xEDB0AC
	public SslStream get_SslStream() { }

	// RVA: 0xEDB0B4
	public MonoTlsSettings get_Settings() { }

	// RVA: 0xEDB0BC
	public MobileTlsProvider get_Provider() { }

	// RVA: 0xEDB0C4
	internal string get_TargetHost() { }

	// RVA: 0xEDB0CC
	private void set_TargetHost(string value) { }

	// RVA: 0xEDB0D4
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck) { }

	// RVA: 0xED8774
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0xEDB1A0
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0xEDB338
	internal static Exception GetInternalError() { }

	// RVA: 0xEDB38C
	internal static Exception GetInvalidNestedCallException() { }

	// RVA: 0xED7D5C
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0xEDB3E0
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0xEDB8AC
	public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0xEDB77C
	private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

	// RVA: 0xEDBA28
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xEDBC88
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xEDBD60
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0xEDBE00
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0xEDBB28
	private System.Threading.Tasks.Task<System.Int32> StartOperation(OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0xED4974
	internal int InternalRead(Byte[] buffer, int offset, int size, bool outWantMore) { }

	// RVA: 0xEDBEA0
	private System.ValueTuple<System.Int32,System.Boolean> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, Byte[] buffer, int offset, int size) { }

	// RVA: 0xED4440
	internal bool InternalWrite(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEDC020
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, Byte[] buffer, int offset, int size) { }

	// RVA: 0xED9088
	internal System.Threading.Tasks.Task<System.Int32> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	// RVA: 0xED8924
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0xED9318
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) { }

	// RVA: 0xED991C
	internal System.ValueTuple<System.Int32,System.Boolean> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0xED9B28
	internal System.ValueTuple<System.Int32,System.Boolean> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0xEDC1D8
	public override bool get_IsAuthenticated() { }

	// RVA: 0xEDC2DC
	protected override void Dispose(bool disposing) { }

	// RVA: 0xEDC5A8
	public override void Flush() { }

	// RVA: 0xEDC5D0
	public X509Certificate get_LocalCertificate() { }

	// RVA: 0xEDC6B8
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0xEDC7E4
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xEDC824
	public override bool get_CanRead() { }

	// RVA: 0xEDC874
	public override bool get_CanTimeout() { }

	// RVA: 0xEDC898
	public override bool get_CanWrite() { }

	// RVA: 0xEDC908
	public override bool get_CanSeek() { }

	// RVA: 0xEDC910
	public override Int64 get_Length() { }

	// RVA: 0xEDC934
	public override Int64 get_Position() { }

	// RVA: 0xEDC958
	public override void set_Position(Int64 value) { }

	// RVA: 0xEDC998
	public override int get_ReadTimeout() { }

	// RVA: 0xEDC9C0
	public override void set_ReadTimeout(int value) { }

	// RVA: 0xEDC9E8
	public override int get_WriteTimeout() { }

	// RVA: 0xEDCA10
	public override void set_WriteTimeout(int value) { }

	// RVA: 0xEDCA38
	private static void .cctor() { }

	// RVA: 0xEDCA88
	private void <InnerWrite>b__67_0() { }

}

// Namespace: Mono.Net.Security
internal abstract class MobileTlsContext
{
	// Fields
	private ChainValidationHelper certificateValidator; // 0x10
	private readonly MonoSslAuthenticationOptions <Options>k__BackingField; // 0x18
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x20
	private readonly bool <IsServer>k__BackingField; // 0x28
	private readonly string <TargetHost>k__BackingField; // 0x30
	private readonly string <ServerName>k__BackingField; // 0x38
	private readonly bool <AskForClientCertificate>k__BackingField; // 0x40
	private readonly SslProtocols <EnabledProtocols>k__BackingField; // 0x44
	private readonly X509CertificateCollection <ClientCertificates>k__BackingField; // 0x48
	private X509Certificate <LocalServerCertificate>k__BackingField; // 0x50

	// Methods

	// RVA: 0xED30B4
	protected void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xEDE880
	internal MonoSslAuthenticationOptions get_Options() { }

	// RVA: 0xEDE888
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0xED3B54
	public MonoTlsSettings get_Settings() { }

	// RVA: -1
	public abstract bool get_IsAuthenticated() { }

	// RVA: 0xEDE890
	public bool get_IsServer() { }

	// RVA: 0xEDE898
	internal string get_TargetHost() { }

	// RVA: 0xEDE8A0
	protected string get_ServerName() { }

	// RVA: 0xEDE8A8
	protected bool get_AskForClientCertificate() { }

	// RVA: 0xEDE8B0
	protected SslProtocols get_EnabledProtocols() { }

	// RVA: 0xEDE8B8
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xEDE8C0
	protected void GetProtocolVersions(System.Nullable<Mono.Security.Interface.TlsProtocolCode>& min, System.Nullable<Mono.Security.Interface.TlsProtocolCode>& max) { }

	// RVA: -1
	public abstract void StartHandshake() { }

	// RVA: -1
	public abstract bool ProcessHandshake() { }

	// RVA: -1
	public abstract void FinishHandshake() { }

	// RVA: 0xEDEA04
	internal X509Certificate get_LocalServerCertificate() { }

	// RVA: 0xEDEA0C
	private void set_LocalServerCertificate(X509Certificate value) { }

	// RVA: -1
	internal abstract X509Certificate get_LocalClientCertificate() { }

	// RVA: -1
	public abstract X509Certificate2 get_RemoteCertificate() { }

	// RVA: -1
	public abstract void Flush() { }

	// RVA: -1
	public abstract System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int count) { }

	// RVA: -1
	public abstract System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int count) { }

	// RVA: -1
	public abstract void Shutdown() { }

	// RVA: -1
	public abstract bool PendingRenegotiation() { }

	// RVA: 0xED4000
	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	// RVA: 0xEDEA14
	protected X509Certificate SelectServerCertificate(string serverIdentity) { }

	// RVA: 0xED52AC
	protected X509Certificate SelectClientCertificate(string[] acceptableIssuers) { }

	// RVA: -1
	public abstract void Renegotiate() { }

	// RVA: 0xEDC514
	public void Dispose() { }

	// RVA: 0xEDECB4
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xEDECB8
	protected override void Finalize() { }

}

// Namespace: Mono.Net.Security
internal abstract class MobileTlsProvider
{
	// Methods

	// RVA: -1
	internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: -1
	internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, SslPolicyErrors errors, int status11) { }

	// RVA: 0xED6794
	protected void .ctor() { }

}

// Namespace: Mono.Net.Security
internal abstract class MonoSslAuthenticationOptions
{
	// Fields
	private ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField; // 0x10

	// Methods

	// RVA: -1
	public abstract bool get_ServerMode() { }

	// RVA: -1
	public abstract bool get_AllowRenegotiation() { }

	// RVA: -1
	public abstract SslProtocols get_EnabledSslProtocols() { }

	// RVA: -1
	public abstract void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: -1
	public abstract void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: -1
	public abstract void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: -1
	public abstract string get_TargetHost() { }

	// RVA: -1
	public abstract void set_TargetHost(string value) { }

	// RVA: -1
	public abstract X509Certificate get_ServerCertificate() { }

	// RVA: -1
	public abstract X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1
	public abstract void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: -1
	public abstract bool get_ClientCertificateRequired() { }

	// RVA: 0xEDED58
	internal ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	// RVA: 0xEDED60
	protected void .ctor() { }

}

// Namespace: Mono.Net.Security
internal sealed class MonoSslClientAuthenticationOptions
{
	// Fields
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; // 0x18

	// Methods

	// RVA: 0xEDED68
	public SslClientAuthenticationOptions get_Options() { }

	// RVA: 0xEDED70
	public override bool get_ServerMode() { }

	// RVA: 0xEDB704
	public void .ctor() { }

	// RVA: 0xEDED78
	public override bool get_AllowRenegotiation() { }

	// RVA: 0xEDED98
	public override void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0xEDEDB8
	public override void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0xEDEDD8
	public override SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0xEDEDF8
	public override void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0xEDEE18
	public override string get_TargetHost() { }

	// RVA: 0xEDEE38
	public override void set_TargetHost(string value) { }

	// RVA: 0xEDEE58
	public override bool get_ClientCertificateRequired() { }

	// RVA: 0xEDEE98
	public override X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0xEDEEB8
	public override void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0xEDEED8
	public override X509Certificate get_ServerCertificate() { }

}

// Namespace: Mono.Net.Security
internal static class MonoTlsProviderFactory
{
	// Fields
	private static object locker; // 0x0
	private static bool initialized; // 0x8
	private static MobileTlsProvider defaultProvider; // 0x10
	private static System.Collections.Generic.Dictionary<System.String,System.Tuple<System.Guid,System.String>> providerRegistration; // 0x18
	private static System.Collections.Generic.Dictionary<System.Guid,Mono.Net.Security.MobileTlsProvider> providerCache; // 0x20
	internal static readonly Guid UnityTlsId; // 0x28
	internal static readonly Guid AppleTlsId; // 0x38
	internal static readonly Guid BtlsId; // 0x48

	// Methods

	// RVA: 0xEDA228
	internal static MobileTlsProvider GetProviderInternal() { }

	// RVA: 0xEDEF18
	internal static void InitializeInternal() { }

	// RVA: 0xEDF748
	private static MobileTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0xEDF310
	private static void InitializeProviderRegistration() { }

	// RVA: 0xEDFDEC
	private static void PopulateUnityProviders() { }

	// RVA: 0xEDFF3C
	private static void PopulateProviders() { }

	// RVA: 0xEE0190
	internal static bool IsBtlsSupported() { }

	// RVA: 0xEDF530
	private static MobileTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0xEE026C
	internal static MobileTlsProvider GetProvider() { }

	// RVA: 0xEE02D4
	private static void .cctor() { }

}

// Namespace: 
private struct <CreateStream>d__18
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder; // 0x18
	public MonoTlsStream <>4__this; // 0x30
	public WebConnectionTunnel tunnel; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private Socket <socket>5__2; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0xEE0930
	private void MoveNext() { }

	// RVA: 0xEE1148
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: Mono.Net.Security
internal class MonoTlsStream
{
	// Fields
	private readonly MobileTlsProvider provider; // 0x10
	private readonly NetworkStream networkStream; // 0x18
	private readonly HttpWebRequest request; // 0x20
	private readonly MonoTlsSettings settings; // 0x28
	private SslStream sslStream; // 0x30
	private readonly object sslStreamLock; // 0x38
	private WebExceptionStatus status; // 0x40
	private bool <CertificateValidationFailed>k__BackingField; // 0x44

	// Methods

	// RVA: 0xEE0418
	internal HttpWebRequest get_Request() { }

	// RVA: 0xEE0420
	internal WebExceptionStatus get_ExceptionStatus() { }

	// RVA: 0xEE0428
	internal bool get_CertificateValidationFailed() { }

	// RVA: 0xEE0430
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0xEE0438
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	// RVA: 0xEE06F0
	internal System.Threading.Tasks.Task<System.IO.Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	// RVA: 0xEE0848
	public void Dispose() { }

	// RVA: 0xEE084C
	private void CloseSslStream() { }

}

// Namespace: Mono.Net.Security
internal static class NoReflectionHelper
{
	// Methods

	// RVA: 0xEE11C8
	internal static object GetProvider() { }

}

// Namespace: Mono.Net.Security
internal static class SystemCertificateValidator
{
	// Fields
	private static bool is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0xEE1278
	private static void .cctor() { }

	// RVA: 0xEDAF40
	internal static bool NeedsChain(MonoTlsSettings settings) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public RemoteCertificateValidationCallback callback; // 0x10

	// Methods

	// RVA: 0xEE12CC
	public void .ctor() { }

	// RVA: 0xEE12DC
	internal bool <PublicToMono>b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public MonoLocalCertificateSelectionCallback callback; // 0x10

	// Methods

	// RVA: 0xEE12D4
	public void .ctor() { }

	// RVA: 0xEE1304
	internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

}

// Namespace: Mono.Net.Security.Private
internal static class CallbackHelpers
{
	// Methods

	// RVA: 0xEE060C
	internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback) { }

	// RVA: 0xEDA464
	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

}

// Namespace: Mono.Http
internal class NtlmSession
{
	// Fields
	private MessageBase message; // 0x10

	// Methods

	// RVA: 0xEE132C
	public void .ctor() { }

	// RVA: 0xEE1334
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Mono.Http.NtlmClient.<>c <>9; // 0x0
	public static CreateValueCallback <>9__1_0; // 0x8

	// Methods

	// RVA: 0xEE1C68
	private static void .cctor() { }

	// RVA: 0xEE1CD4
	public void .ctor() { }

	// RVA: 0xEE1CDC
	internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }

}

// Namespace: Mono.Http
internal class NtlmClient
{
	// Fields
	private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<System.Net.HttpWebRequest,Mono.Http.NtlmSession> cache; // 0x0

	// Methods

	// RVA: 0xEE17F0
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xEE1B78
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0xEE1B80
	public string get_AuthenticationType() { }

	// RVA: 0xEE1BC4
	public void .ctor() { }

	// RVA: 0xEE1BCC
	private static void .cctor() { }

}

// Namespace: 
protected internal class BoringBioHandle
{
	// Methods

	// RVA: 0xEE1EDC
	public void .ctor(IntPtr handle) { }

	// RVA: 0xEE1EF0
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsBio
{
	// Methods

	// RVA: 0xEE1D34
	internal void .ctor(BoringBioHandle handle) { }

	// RVA: 0xEE1D9C
	protected internal BoringBioHandle get_Handle() { }

	// RVA: 0xEE1E44
	private static extern void mono_btls_bio_free(IntPtr handle) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsBioMemory
{
	// Methods

	// RVA: 0xEE1F98
	private static extern IntPtr mono_btls_bio_mem_new() { }

	// RVA: 0xEE201C
	private static extern int mono_btls_bio_mem_get_data(IntPtr handle, IntPtr data) { }

	// RVA: 0xEE20AC
	public void .ctor() { }

	// RVA: 0xEE218C
	public Byte[] GetData() { }

}

// Namespace: Mono.Btls
internal interface IMonoBtlsBioMono
{
	// Methods

	// RVA: -1
	public abstract int Read(Byte[] buffer, int offset, int size, bool wantMore) { }

	// RVA: -1
	public abstract bool Write(Byte[] buffer, int offset, int size) { }

	// RVA: -1
	public abstract void Flush() { }

	// RVA: -1
	public abstract void Close() { }

}

// Namespace: 
private enum ControlCommand
{
	// Fields
	public int value__; // 0x10
	public const ControlCommand Flush = 1;
}

// Namespace: 
private sealed class BioReadFunc
{
	// Methods

	// RVA: 0xEE2FE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEE3774
	public virtual int Invoke(IntPtr bio, IntPtr data, int dataLength, int wantMore) { }

}

// Namespace: 
private sealed class BioWriteFunc
{
	// Methods

	// RVA: 0xEE308C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEE3788
	public virtual int Invoke(IntPtr bio, IntPtr data, int dataLength) { }

}

// Namespace: 
private sealed class BioControlFunc
{
	// Methods

	// RVA: 0xEE3130
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEE379C
	public virtual Int64 Invoke(IntPtr bio, ControlCommand command, Int64 arg) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsBioMono
{
	// Fields
	private GCHandle handle; // 0x20
	private IntPtr instance; // 0x28
	private BioReadFunc readFunc; // 0x30
	private BioWriteFunc writeFunc; // 0x38
	private BioControlFunc controlFunc; // 0x40
	private IntPtr readFuncPtr; // 0x48
	private IntPtr writeFuncPtr; // 0x50
	private IntPtr controlFuncPtr; // 0x58
	private IMonoBtlsBioMono backend; // 0x60

	// Methods

	// RVA: 0xEE2AC8
	public void .ctor(IMonoBtlsBioMono backend) { }

	// RVA: 0xEE2F64
	private static extern IntPtr mono_btls_bio_mono_new() { }

	// RVA: 0xEE31D4
	private static extern void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc) { }

	// RVA: 0xEE3284
	private Int64 Control(ControlCommand command, Int64 arg) { }

	// RVA: 0xEE337C
	private int OnRead(IntPtr data, int dataLength, int wantMore) { }

	// RVA: 0xEE2640
	private static int OnRead(IntPtr instance, IntPtr data, int dataLength, int wantMore) { }

	// RVA: 0xEE3518
	private int OnWrite(IntPtr data, int dataLength) { }

	// RVA: 0xEE27D4
	private static int OnWrite(IntPtr instance, IntPtr data, int dataLength) { }

	// RVA: 0xEE2950
	private static Int64 Control(IntPtr instance, ControlCommand command, Int64 arg) { }

	// RVA: 0xEE3650
	protected override void Close() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsContext
{
	// Fields
	private X509Certificate2 remoteCertificate; // 0x58
	private X509Certificate clientCertificate; // 0x60
	private X509CertificateImplBtls nativeServerCertificate; // 0x68
	private X509CertificateImplBtls nativeClientCertificate; // 0x70
	private MonoBtlsSslCtx ctx; // 0x78
	private MonoBtlsSsl ssl; // 0x80
	private MonoBtlsBio bio; // 0x88
	private MonoBtlsBio errbio; // 0x90
	private MonoTlsConnectionInfo connectionInfo; // 0x98
	private bool certificateValidated; // 0xA0
	private bool isAuthenticated; // 0xA1
	private bool connected; // 0xA2

	// Methods

	// RVA: 0xEE37B0
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0xEE37FC
	private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate) { }

	// RVA: 0xEE3A40
	private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0xEE3D4C
	private int SelectCallback(string[] acceptableIssuers) { }

	// RVA: 0xEE4270
	private int ServerNameCallback() { }

	// RVA: 0xEE42D8
	public override void StartHandshake() { }

	// RVA: 0xEE3F80
	private void SetPrivateCertificate(X509CertificateImplBtls privateCert) { }

	// RVA: 0xEE4880
	private static Exception GetException(MonoBtlsSslError status) { }

	// RVA: 0xEE5108
	public override bool ProcessHandshake() { }

	// RVA: 0xEE5314
	private MonoBtlsSslError DoProcessHandshake() { }

	// RVA: 0xEE5548
	public override void FinishHandshake() { }

	// RVA: 0xEE4414
	private void InitializeConnection() { }

	// RVA: 0xEE3E24
	private void GetPeerCertificate() { }

	// RVA: 0xEE5570
	private void InitializeSession() { }

	// RVA: 0xEE5E80
	private static TlsProtocols GetProtocol(TlsProtocolCode protocol) { }

	// RVA: 0xEE5EE8
	public override void Flush() { }

	// RVA: 0xEE5F28
	public override System.ValueTuple<System.Int32,System.Boolean> Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEE6224
	public override System.ValueTuple<System.Int32,System.Boolean> Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEE64D8
	public override void Renegotiate() { }

	// RVA: 0xEE6518
	public override void Shutdown() { }

	// RVA: 0xEE656C
	public override bool PendingRenegotiation() { }

	// RVA: 0x30B2CB8
	private void Dispose(T disposable) { }

	// RVA: 0xEE658C
	protected override void Dispose(bool disposing) { }

	// RVA: 0xEE6718
	private int Mono.Btls.IMonoBtlsBioMono.Read(Byte[] buffer, int offset, int size, bool wantMore) { }

	// RVA: 0xEE6734
	private bool Mono.Btls.IMonoBtlsBioMono.Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0xEE6750
	private void Mono.Btls.IMonoBtlsBioMono.Flush() { }

	// RVA: 0xEE6754
	private void Mono.Btls.IMonoBtlsBioMono.Close() { }

	// RVA: 0xEE6758
	public override bool get_IsAuthenticated() { }

	// RVA: 0xEE6760
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0xEE6768
	public override X509Certificate2 get_RemoteCertificate() { }

}

// Namespace: Mono.Btls
internal static class MonoBtlsError
{
	// Methods

	// RVA: 0xEE6770
	private static extern void mono_btls_error_clear_error() { }

	// RVA: 0xEE67F4
	private static extern int mono_btls_error_get_error_line(IntPtr file, int line) { }

	// RVA: 0xEE6884
	private static extern void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len) { }

	// RVA: 0xEE691C
	private static extern int mono_btls_error_get_reason(int error) { }

	// RVA: 0xEE5290
	public static void ClearError() { }

	// RVA: 0xEE4EBC
	public static string GetErrorString(int error) { }

	// RVA: 0xEE4C64
	public static int GetError(string file, int line) { }

	// RVA: 0xEE4E24
	public static int GetErrorReason(int error) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsException
{
	// Methods

	// RVA: 0xEE69B4
	public void .ctor() { }

	// RVA: 0xEE4D70
	public void .ctor(MonoBtlsSslError error) { }

	// RVA: 0xEE509C
	public void .ctor(string message) { }

	// RVA: 0xEE6A3C
	public void .ctor(string format, object[] args) { }

}

// Namespace: 
internal class BoringKeyHandle
{
	// Methods

	// RVA: 0xEE7428
	internal void .ctor(IntPtr handle) { }

	// RVA: 0xEE7668
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsKey
{
	// Methods

	// RVA: 0xEE6AC8
	private static extern IntPtr mono_btls_key_new() { }

	// RVA: 0xEE6B4C
	private static extern void mono_btls_key_free(IntPtr handle) { }

	// RVA: 0xEE6BE4
	private static extern IntPtr mono_btls_key_up_ref(IntPtr handle) { }

	// RVA: 0xEE6C7C
	private static extern int mono_btls_key_get_bytes(IntPtr handle, IntPtr data, int size, int include_private_bits) { }

	// RVA: 0xEE6D24
	private static extern int mono_btls_key_assign_rsa_private_key(IntPtr handle, Byte[] der, int der_length) { }

	// RVA: 0xEE6DC4
	internal BoringKeyHandle get_Handle() { }

	// RVA: 0xEE6E48
	internal void .ctor(BoringKeyHandle handle) { }

	// RVA: 0xEE6E7C
	public Byte[] GetBytes(bool include_private_bits) { }

	// RVA: 0xEE71D0
	public MonoBtlsKey Copy() { }

	// RVA: 0xEE7434
	public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey) { }

}

// Namespace: 
protected internal abstract class MonoBtlsHandle
{
	// Methods

	// RVA: 0xEE1EE8
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0xEE7A88
	public override bool get_IsInvalid() { }

}

// Namespace: Mono.Btls
internal abstract class MonoBtlsObject
{
	// Fields
	private MonoBtlsHandle handle; // 0x10
	private Exception lastError; // 0x18

	// Methods

	// RVA: 0xEE1D68
	internal void .ctor(MonoBtlsHandle handle) { }

	// RVA: 0xEE1E20
	internal MonoBtlsHandle get_Handle() { }

	// RVA: 0xEE76EC
	public bool get_IsValid() { }

	// RVA: 0xEE73A8
	protected void CheckThrow() { }

	// RVA: 0xEE34D4
	protected Exception SetException(Exception ex) { }

	// RVA: 0xEE24C0
	protected void CheckError(bool ok, string callerName) { }

	// RVA: 0xEE712C
	protected void CheckError(int ret, string callerName) { }

	// RVA: 0xEE5368
	protected internal void CheckLastError(string callerName) { }

	// RVA: 0xEE7714
	private static extern void mono_btls_free(IntPtr data) { }

	// RVA: 0xEE7138
	protected void FreeDataPtr(IntPtr data) { }

	// RVA: 0xEE77AC
	protected virtual void Close() { }

	// RVA: 0xEE77B0
	protected void Dispose(bool disposing) { }

	// RVA: 0xEE793C
	public void Dispose() { }

	// RVA: 0xEE79DC
	protected override void Finalize() { }

}

// Namespace: 
internal class BoringPkcs12Handle
{
	// Methods

	// RVA: 0xEE8060
	public void .ctor(IntPtr handle) { }

	// RVA: 0xEE8798
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsPkcs12
{
	// Fields
	private MonoBtlsKey privateKey; // 0x20

	// Methods

	// RVA: 0xEE7A98
	internal BoringPkcs12Handle get_Handle() { }

	// RVA: 0xEE7B1C
	private static extern void mono_btls_pkcs12_free(IntPtr handle) { }

	// RVA: 0xEE7BB4
	private static extern IntPtr mono_btls_pkcs12_new() { }

	// RVA: 0xEE7C38
	private static extern int mono_btls_pkcs12_get_count(IntPtr handle) { }

	// RVA: 0xEE7CD0
	private static extern IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index) { }

	// RVA: 0xEE7D60
	private static extern int mono_btls_pkcs12_import(IntPtr chain, Void* data, int len, SafePasswordHandle password) { }

	// RVA: 0xEE7E50
	private static extern int mono_btls_pkcs12_has_private_key(IntPtr pkcs12) { }

	// RVA: 0xEE7EE8
	private static extern IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12) { }

	// RVA: 0xEE7F80
	internal void .ctor() { }

	// RVA: 0xEE806C
	public int get_Count() { }

	// RVA: 0xEE8174
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0xEE836C
	public void Import(Byte[] buffer, SafePasswordHandle password) { }

	// RVA: 0xEE8484
	public bool get_HasPrivateKey() { }

	// RVA: 0xEE857C
	public MonoBtlsKey GetPrivateKey() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsProvider
{
	// Methods

	// RVA: 0xEE881C
	public override Guid get_ID() { }

	// RVA: 0xEE8898
	public override string get_Name() { }

	// RVA: 0xEE0194
	internal void .ctor() { }

	// RVA: 0xEE88DC
	public override bool get_SupportsSslStream() { }

	// RVA: 0xEE88E4
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0xEE88EC
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0xEE88F4
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0xEE88FC
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0xEE8904
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	// RVA: 0xEE899C
	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, string password, X509KeyStorageFlags flags) { }

	// RVA: 0xEE8BC4
	internal X509Certificate2Impl GetNativeCertificate(X509Certificate certificate) { }

	// RVA: 0xEE8B44
	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags flags) { }

	// RVA: 0xEE5A70
	internal static MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode) { }

	// RVA: 0xEE8CDC
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, SslPolicyErrors errors, int status11) { }

	// RVA: 0xEE98C0
	internal static bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param) { }

	// RVA: 0xEE9350
	private void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, SslPolicyErrors errors, int status11) { }

	// RVA: 0xEE9BA8
	internal static X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code) { }

	// RVA: 0xEE571C
	internal static void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0xEE9E20
	private static void SetupDefaultCertificateStore(MonoBtlsX509Store store) { }

	// RVA: 0xEE9EB0
	private static void AddUserStore(MonoBtlsX509Store store) { }

	// RVA: 0xEE9F0C
	private static void AddMachineStore(MonoBtlsX509Store store) { }

	// RVA: 0xEE9DE4
	private static void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	// RVA: 0xEE5D04
	public static X509Certificate2 CreateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0xEE982C
	public static X509Chain GetManagedChain(MonoBtlsX509Chain chain) { }

	// RVA: 0xEE9F68
	public static MonoBtlsX509 GetBtlsCertificate(X509Certificate certificate) { }

	// RVA: 0xEE943C
	public static MonoBtlsX509Chain GetNativeChain(X509CertificateCollection certificates) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsVerifyCallback
{
	// Methods

	// RVA: 0x126CF5C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x126D07C
	public virtual int Invoke(MonoBtlsX509StoreCtx ctx) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsSelectCallback
{
	// Methods

	// RVA: 0x126D090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x126D144
	public virtual int Invoke(string[] acceptableIssuers) { }

}

// Namespace: Mono.Btls
internal sealed class MonoBtlsServerNameCallback
{
	// Methods

	// RVA: 0x126D158
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x126D1F8
	public virtual int Invoke() { }

}

// Namespace: 
internal class BoringSslHandle
{
	// Methods

	// RVA: 0x126E2FC
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1270624
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class PrintErrorsCallbackFunc
{
	// Methods

	// RVA: 0x126E470
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12706B8
	public virtual int Invoke(IntPtr str, IntPtr len, IntPtr ctx) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsSsl
{
	// Fields
	private MonoBtlsBio bio; // 0x20
	private PrintErrorsCallbackFunc printErrorsFunc; // 0x28
	private IntPtr printErrorsFuncPtr; // 0x30

	// Methods

	// RVA: 0x126D39C
	private static extern void mono_btls_ssl_destroy(IntPtr handle) { }

	// RVA: 0x126D434
	private static extern IntPtr mono_btls_ssl_new(IntPtr handle) { }

	// RVA: 0x126D4CC
	private static extern int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x126D55C
	private static extern int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key) { }

	// RVA: 0x126D5EC
	private static extern int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509) { }

	// RVA: 0x126D67C
	private static extern int mono_btls_ssl_accept(IntPtr handle) { }

	// RVA: 0x126D714
	private static extern int mono_btls_ssl_connect(IntPtr handle) { }

	// RVA: 0x126D7AC
	private static extern int mono_btls_ssl_handshake(IntPtr handle) { }

	// RVA: 0x126D844
	private static extern void mono_btls_ssl_close(IntPtr handle) { }

	// RVA: 0x126D8D8
	private static extern int mono_btls_ssl_shutdown(IntPtr handle) { }

	// RVA: 0x126D970
	private static extern void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode) { }

	// RVA: 0x126DA00
	private static extern void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio) { }

	// RVA: 0x126DA90
	private static extern int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x126DB28
	private static extern int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len) { }

	// RVA: 0x126DBBC
	private static extern int mono_btls_ssl_get_error(IntPtr handle, int ret_code) { }

	// RVA: 0x126DC4C
	private static extern int mono_btls_ssl_get_version(IntPtr handle) { }

	// RVA: 0x126DCE4
	private static extern int mono_btls_ssl_get_cipher(IntPtr handle) { }

	// RVA: 0x126DD7C
	private static extern IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle) { }

	// RVA: 0x126DE14
	private static extern void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx) { }

	// RVA: 0x126DEA4
	private static extern int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name) { }

	// RVA: 0x126DF34
	private static extern IntPtr mono_btls_ssl_get_server_name(IntPtr handle) { }

	// RVA: 0x126DFCC
	private static extern void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode) { }

	// RVA: 0x126E05C
	private static extern int mono_btls_ssl_renegotiate_pending(IntPtr handle) { }

	// RVA: 0x126E0F4
	private static BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) { }

	// RVA: 0x126E308
	public void .ctor(MonoBtlsSslCtx ctx) { }

	// RVA: 0x126E514
	internal BoringSslHandle get_Handle() { }

	// RVA: 0x126E598
	public void SetBio(MonoBtlsBio bio) { }

	// RVA: 0x126E6C8
	private Exception ThrowError(string callerName) { }

	// RVA: 0x126EA50
	private MonoBtlsSslError GetError(int ret_code) { }

	// RVA: 0x126EB98
	public void SetCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x126EDB0
	public void SetPrivateKey(MonoBtlsKey key) { }

	// RVA: 0x126EEF0
	public void AddIntermediateCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x126F084
	public MonoBtlsSslError Accept() { }

	// RVA: 0x126F190
	public MonoBtlsSslError Connect() { }

	// RVA: 0x126F29C
	public MonoBtlsSslError Handshake() { }

	// RVA: 0x126D20C
	private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) { }

	// RVA: 0x126E8B0
	public string GetErrors() { }

	// RVA: 0x126F3A8
	public void PrintErrors() { }

	// RVA: 0x126F528
	public MonoBtlsSslError Read(IntPtr data, int dataSize) { }

	// RVA: 0x126F68C
	public MonoBtlsSslError Write(IntPtr data, int dataSize) { }

	// RVA: 0x126F898
	public int GetVersion() { }

	// RVA: 0x126F9A8
	public int GetCipher() { }

	// RVA: 0x126FB1C
	public MonoBtlsX509 GetPeerCertificate() { }

	// RVA: 0x126FCE8
	public void SetServerName(string name) { }

	// RVA: 0x126FF30
	public string GetServerName() { }

	// RVA: 0x12700B4
	public void Shutdown() { }

	// RVA: 0x12701D0
	public void SetQuietShutdown() { }

	// RVA: 0x12702CC
	protected override void Close() { }

	// RVA: 0x1270424
	public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) { }

	// RVA: 0x127052C
	public bool RenegotiatePending() { }

}

// Namespace: 
internal class BoringSslCtxHandle
{
	// Methods

	// RVA: 0x1271544
	public void .ctor(IntPtr handle) { }

	// RVA: 0x127331C
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class NativeVerifyFunc
{
	// Methods

	// RVA: 0x1271994
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12733A0
	public virtual int Invoke(IntPtr instance, int preverify_ok, IntPtr ctx) { }

}

// Namespace: 
private sealed class NativeSelectFunc
{
	// Methods

	// RVA: 0x1271A38
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12733B4
	public virtual int Invoke(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

}

// Namespace: 
private sealed class NativeServerNameFunc
{
	// Methods

	// RVA: 0x1271ADC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12733C8
	public virtual int Invoke(IntPtr instance) { }

}

// Namespace: Mono.Btls
internal class MonoBtlsSslCtx
{
	// Fields
	private NativeVerifyFunc verifyFunc; // 0x20
	private NativeSelectFunc selectFunc; // 0x28
	private NativeServerNameFunc serverNameFunc; // 0x30
	private IntPtr verifyFuncPtr; // 0x38
	private IntPtr selectFuncPtr; // 0x40
	private IntPtr serverNameFuncPtr; // 0x48
	private MonoBtlsVerifyCallback verifyCallback; // 0x50
	private MonoBtlsSelectCallback selectCallback; // 0x58
	private MonoBtlsServerNameCallback serverNameCallback; // 0x60
	private MonoBtlsX509Store store; // 0x68
	private GCHandle instance; // 0x70
	private IntPtr instancePtr; // 0x78

	// Methods

	// RVA: 0x126E278
	internal BoringSslCtxHandle get_Handle() { }

	// RVA: 0x1270E10
	private static extern IntPtr mono_btls_ssl_ctx_new() { }

	// RVA: 0x1270E94
	private static extern int mono_btls_ssl_ctx_free(IntPtr handle) { }

	// RVA: 0x1270F2C
	private static extern void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance) { }

	// RVA: 0x1270FBC
	private static extern void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required) { }

	// RVA: 0x1271054
	private static extern void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x12710E4
	private static extern void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version) { }

	// RVA: 0x1271174
	private static extern void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version) { }

	// RVA: 0x1271204
	private static extern int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported) { }

	// RVA: 0x12712AC
	private static extern int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x127133C
	private static extern int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x12713E4
	private static extern void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func) { }

	// RVA: 0x1271474
	public void .ctor() { }

	// RVA: 0x1271550
	internal void .ctor(BoringSslCtxHandle handle) { }

	// RVA: 0x1271BB0
	public MonoBtlsX509Store get_CertificateStore() { }

	// RVA: 0x1271BB8
	private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx) { }

	// RVA: 0x12706CC
	private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x1270AD8
	private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	// RVA: 0x1271C7C
	private static string[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr) { }

	// RVA: 0x1272368
	public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required) { }

	// RVA: 0x1272500
	public void SetSelectCallback(MonoBtlsSelectCallback callback) { }

	// RVA: 0x127261C
	public void SetMinVersion(int version) { }

	// RVA: 0x1272724
	public void SetMaxVersion(int version) { }

	// RVA: 0x127282C
	public void SetCiphers(Int16[] ciphers, bool allow_unsupported) { }

	// RVA: 0x1272AA8
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x1272D14
	public void SetClientCertificateIssuers(string[] acceptableIssuers) { }

	// RVA: 0x1273198
	public void SetServerNameCallback(MonoBtlsServerNameCallback callback) { }

	// RVA: 0x1270C9C
	private static int NativeServerNameCallback(IntPtr instance) { }

	// RVA: 0x12732B4
	protected override void Close() { }

}

// Namespace: Mono.Btls
internal enum MonoBtlsSslError
{
	// Fields
	public int value__; // 0x10
	public const MonoBtlsSslError None = 0;
	public const MonoBtlsSslError Ssl = 1;
	public const MonoBtlsSslError WantRead = 2;
	public const MonoBtlsSslError WantWrite = 3;
	public const MonoBtlsSslError WantX509Lookup = 4;
	public const MonoBtlsSslError Syscall = 5;
	public const MonoBtlsSslError ZeroReturn = 6;
	public const MonoBtlsSslError WantConnect = 7;
	public const MonoBtlsSslError WantAccept = 8;
	public const MonoBtlsSslError WantChannelIdLookup = 9;
	public const MonoBtlsSslError PendingSession = 11;
	public const MonoBtlsSslError PendingCertificate = 12;
	public const MonoBtlsSslError WantPrivateKeyOperation = 13;
}

// Namespace: Mono.Btls
internal enum MonoBtlsSslRenegotiateMode
{
	// Fields
	public int value__; // 0x10
	public const MonoBtlsSslRenegotiateMode NEVER = 0;
	public const MonoBtlsSslRenegotiateMode ONCE = 1;
	public const MonoBtlsSslRenegotiateMode FREELY = 2;
	public const MonoBtlsSslRenegotiateMode IGNORE = 3;
}

// Namespace: Mono.Btls
internal class MonoBtlsStream
{
	// Methods

	// RVA: 0x12733DC
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0x1273478
	protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }

}

// Namespace: Mono.Btls
internal static class MonoBtlsUtils
{
	// Fields
	private static Byte[] emailOid; // 0x0

	// Methods

	// RVA: 0x12734E8
	public static bool Compare(Byte[] a, Byte[] b) { }

	// RVA: 0x127355C
	private static bool AppendEntry(StringBuilder sb, MonoBtlsX509Name name, int index, string separator, bool quotes) { }

	// RVA: 0x1272220
	public static string FormatName(MonoBtlsX509Name name, bool reversed, string separator, bool quotes) { }

	// RVA: 0x1274288
	private static void .cctor() { }

}

// Namespace: 
internal class BoringX509Handle
{
	// Methods

	// RVA: 0x126FCD4
	public void .ctor(IntPtr handle) { }

	// RVA: 0x12755C0
	protected override bool ReleaseHandle() { }

	// RVA: 0x1275658
	public IntPtr StealHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509
{
	// Methods

	// RVA: 0x126ED2C
	internal BoringX509Handle get_Handle() { }

	// RVA: 0x126FCE0
	internal void .ctor(BoringX509Handle handle) { }

	// RVA: 0x127432C
	private static extern IntPtr mono_btls_x509_up_ref(IntPtr handle) { }

	// RVA: 0x12743C4
	private static extern IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format) { }

	// RVA: 0x127445C
	private static extern IntPtr mono_btls_x509_get_subject_name(IntPtr handle) { }

	// RVA: 0x12744F4
	private static extern int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format) { }

	// RVA: 0x127458C
	private static extern int mono_btls_x509_cmp(IntPtr a, IntPtr b) { }

	// RVA: 0x127461C
	private static extern void mono_btls_x509_free(IntPtr handle) { }

	// RVA: 0x12746B0
	private static extern int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind) { }

	// RVA: 0x1274740
	internal MonoBtlsX509 Copy() { }

	// RVA: 0x1274900
	public static MonoBtlsX509 LoadFromData(Byte[] buffer, MonoBtlsX509Format format) { }

	// RVA: 0x1274BC8
	public MonoBtlsX509Name GetSubjectName() { }

	// RVA: 0x1274DD0
	public Int64 GetSubjectNameHash() { }

	// RVA: 0x1275028
	public Byte[] GetRawData(MonoBtlsX509Format format) { }

	// RVA: 0x12752E4
	public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b) { }

	// RVA: 0x1275448
	public void AddExplicitTrust(MonoBtlsX509TrustKind kind) { }

}

// Namespace: 
internal class BoringX509ChainHandle
{
	// Methods

	// RVA: 0x1275B2C
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1276174
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Chain
{
	// Methods

	// RVA: 0x1275668
	internal BoringX509ChainHandle get_Handle() { }

	// RVA: 0x12756EC
	private static extern IntPtr mono_btls_x509_chain_new() { }

	// RVA: 0x1275770
	private static extern int mono_btls_x509_chain_get_count(IntPtr handle) { }

	// RVA: 0x1275808
	private static extern IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index) { }

	// RVA: 0x1275898
	private static extern int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509) { }

	// RVA: 0x1275928
	private static extern IntPtr mono_btls_x509_chain_up_ref(IntPtr handle) { }

	// RVA: 0x12759C0
	private static extern void mono_btls_x509_chain_free(IntPtr handle) { }

	// RVA: 0x1275A58
	public void .ctor() { }

	// RVA: 0x1275B38
	internal void .ctor(BoringX509ChainHandle handle) { }

	// RVA: 0x1275B40
	public int get_Count() { }

	// RVA: 0x1275C48
	public MonoBtlsX509 GetCertificate(int index) { }

	// RVA: 0x1275E48
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1275FB4
	internal MonoBtlsX509Chain Copy() { }

}

// Namespace: Mono.Btls
internal enum MonoBtlsX509Error
{
	// Fields
	public int value__; // 0x10
	public const MonoBtlsX509Error OK = 0;
	public const MonoBtlsX509Error UNABLE_TO_GET_ISSUER_CERT = 2;
	public const MonoBtlsX509Error UNABLE_TO_GET_CRL = 3;
	public const MonoBtlsX509Error UNABLE_TO_DECRYPT_CERT_SIGNATURE = 4;
	public const MonoBtlsX509Error UNABLE_TO_DECRYPT_CRL_SIGNATURE = 5;
	public const MonoBtlsX509Error UNABLE_TO_DECODE_ISSUER_PUBLIC_KEY = 6;
	public const MonoBtlsX509Error CERT_SIGNATURE_FAILURE = 7;
	public const MonoBtlsX509Error CRL_SIGNATURE_FAILURE = 8;
	public const MonoBtlsX509Error CERT_NOT_YET_VALID = 9;
	public const MonoBtlsX509Error CERT_HAS_EXPIRED = 10;
	public const MonoBtlsX509Error CRL_NOT_YET_VALID = 11;
	public const MonoBtlsX509Error CRL_HAS_EXPIRED = 12;
	public const MonoBtlsX509Error ERROR_IN_CERT_NOT_BEFORE_FIELD = 13;
	public const MonoBtlsX509Error ERROR_IN_CERT_NOT_AFTER_FIELD = 14;
	public const MonoBtlsX509Error ERROR_IN_CRL_LAST_UPDATE_FIELD = 15;
	public const MonoBtlsX509Error ERROR_IN_CRL_NEXT_UPDATE_FIELD = 16;
	public const MonoBtlsX509Error OUT_OF_MEM = 17;
	public const MonoBtlsX509Error DEPTH_ZERO_SELF_SIGNED_CERT = 18;
	public const MonoBtlsX509Error SELF_SIGNED_CERT_IN_CHAIN = 19;
	public const MonoBtlsX509Error UNABLE_TO_GET_ISSUER_CERT_LOCALLY = 20;
	public const MonoBtlsX509Error UNABLE_TO_VERIFY_LEAF_SIGNATURE = 21;
	public const MonoBtlsX509Error CERT_CHAIN_TOO_LONG = 22;
	public const MonoBtlsX509Error CERT_REVOKED = 23;
	public const MonoBtlsX509Error INVALID_CA = 24;
	public const MonoBtlsX509Error PATH_LENGTH_EXCEEDED = 25;
	public const MonoBtlsX509Error INVALID_PURPOSE = 26;
	public const MonoBtlsX509Error CERT_UNTRUSTED = 27;
	public const MonoBtlsX509Error CERT_REJECTED = 28;
	public const MonoBtlsX509Error SUBJECT_ISSUER_MISMATCH = 29;
	public const MonoBtlsX509Error AKID_SKID_MISMATCH = 30;
	public const MonoBtlsX509Error AKID_ISSUER_SERIAL_MISMATCH = 31;
	public const MonoBtlsX509Error KEYUSAGE_NO_CERTSIGN = 32;
	public const MonoBtlsX509Error UNABLE_TO_GET_CRL_ISSUER = 33;
	public const MonoBtlsX509Error UNHANDLED_CRITICAL_EXTENSION = 34;
	public const MonoBtlsX509Error KEYUSAGE_NO_CRL_SIGN = 35;
	public const MonoBtlsX509Error UNHANDLED_CRITICAL_CRL_EXTENSION = 36;
	public const MonoBtlsX509Error INVALID_NON_CA = 37;
	public const MonoBtlsX509Error PROXY_PATH_LENGTH_EXCEEDED = 38;
	public const MonoBtlsX509Error KEYUSAGE_NO_DIGITAL_SIGNATURE = 39;
	public const MonoBtlsX509Error PROXY_CERTIFICATES_NOT_ALLOWED = 40;
	public const MonoBtlsX509Error INVALID_EXTENSION = 41;
	public const MonoBtlsX509Error INVALID_POLICY_EXTENSION = 42;
	public const MonoBtlsX509Error NO_EXPLICIT_POLICY = 43;
	public const MonoBtlsX509Error DIFFERENT_CRL_SCOPE = 44;
	public const MonoBtlsX509Error UNSUPPORTED_EXTENSION_FEATURE = 45;
	public const MonoBtlsX509Error UNNESTED_RESOURCE = 46;
	public const MonoBtlsX509Error PERMITTED_VIOLATION = 47;
	public const MonoBtlsX509Error EXCLUDED_VIOLATION = 48;
	public const MonoBtlsX509Error SUBTREE_MINMAX = 49;
	public const MonoBtlsX509Error UNSUPPORTED_CONSTRAINT_TYPE = 51;
	public const MonoBtlsX509Error UNSUPPORTED_CONSTRAINT_SYNTAX = 52;
	public const MonoBtlsX509Error UNSUPPORTED_NAME_SYNTAX = 53;
	public const MonoBtlsX509Error CRL_PATH_VALIDATION_ERROR = 54;
	public const MonoBtlsX509Error SUITE_B_INVALID_VERSION = 56;
	public const MonoBtlsX509Error SUITE_B_INVALID_ALGORITHM = 57;
	public const MonoBtlsX509Error SUITE_B_INVALID_CURVE = 58;
	public const MonoBtlsX509Error SUITE_B_INVALID_SIGNATURE_ALGORITHM = 59;
	public const MonoBtlsX509Error SUITE_B_LOS_NOT_ALLOWED = 60;
	public const MonoBtlsX509Error SUITE_B_CANNOT_SIGN_P_384_WITH_P_256 = 61;
	public const MonoBtlsX509Error HOSTNAME_MISMATCH = 62;
	public const MonoBtlsX509Error EMAIL_MISMATCH = 63;
	public const MonoBtlsX509Error IP_ADDRESS_MISMATCH = 64;
	public const MonoBtlsX509Error APPLICATION_VERIFICATION = 50;
}

// Namespace: Mono.Btls
internal enum MonoBtlsX509FileType
{
	// Fields
	public int value__; // 0x10
	public const MonoBtlsX509FileType PEM = 1;
	public const MonoBtlsX509FileType ASN1 = 2;
	public const MonoBtlsX509FileType DEFAULT = 3;
}

// Namespace: Mono.Btls
internal enum MonoBtlsX509Format
{
	// Fields
	public int value__; // 0x10
	public const MonoBtlsX509Format DER = 1;
	public const MonoBtlsX509Format PEM = 2;
}

// Namespace: 
internal class BoringX509LookupHandle
{
	// Methods

	// RVA: 0x127677C
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1277320
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Lookup
{
	// Fields
	private MonoBtlsX509Store store; // 0x20
	private MonoBtlsX509LookupType type; // 0x28
	private System.Collections.Generic.List<Mono.Btls.MonoBtlsX509LookupMono> monoLookups; // 0x30

	// Methods

	// RVA: 0x12761F8
	internal BoringX509LookupHandle get_Handle() { }

	// RVA: 0x127627C
	private static extern IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type) { }

	// RVA: 0x127630C
	private static extern int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type) { }

	// RVA: 0x12763A4
	private static extern int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup) { }

	// RVA: 0x1276434
	private static extern void mono_btls_x509_lookup_free(IntPtr handle) { }

	// RVA: 0x12764CC
	private static extern IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle) { }

	// RVA: 0x1276564
	private static BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x1276788
	internal void .ctor(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	// RVA: 0x12767E4
	internal IntPtr GetNativeLookup() { }

	// RVA: 0x12768EC
	public void AddDirectory(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x1276B34
	internal void AddMono(MonoBtlsX509LookupMono monoLookup) { }

	// RVA: 0x1276EC8
	internal void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: 0x12770B4
	protected override void Close() { }

}

// Namespace: 
internal class BoringX509LookupMonoHandle
{
	// Methods

	// RVA: 0x1277B98
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1277D38
	protected override bool ReleaseHandle() { }

}

// Namespace: 
private sealed class BySubjectFunc
{
	// Methods

	// RVA: 0x1277BA4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1277DBC
	public virtual int Invoke(IntPtr instance, IntPtr name, IntPtr x509_ptr) { }

}

// Namespace: Mono.Btls
internal abstract class MonoBtlsX509LookupMono
{
	// Fields
	private GCHandle gch; // 0x20
	private IntPtr instance; // 0x28
	private BySubjectFunc bySubjectFunc; // 0x30
	private IntPtr bySubjectFuncPtr; // 0x38
	private MonoBtlsX509Lookup lookup; // 0x40

	// Methods

	// RVA: 0x1276DEC
	internal BoringX509LookupMonoHandle get_Handle() { }

	// RVA: 0x127770C
	private static extern IntPtr mono_btls_x509_lookup_mono_new() { }

	// RVA: 0x1277790
	private static extern void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func) { }

	// RVA: 0x1277828
	private static extern int mono_btls_x509_lookup_mono_free(IntPtr handle) { }

	// RVA: 0x12778C0
	internal void .ctor() { }

	// RVA: 0x1276E70
	internal void Install(MonoBtlsX509Lookup lookup) { }

	// RVA: 0x1277C48
	protected void AddCertificate(MonoBtlsX509 certificate) { }

	// RVA: -1
	protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x12773A4
	private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, IntPtr x509_ptr) { }

	// RVA: 0x1277C6C
	protected override void Close() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509LookupMonoCollection
{
	// Fields
	private Int64[] hashes; // 0x48
	private MonoBtlsX509[] certificates; // 0x50
	private X509CertificateCollection collection; // 0x58
	private MonoBtlsX509TrustKind trust; // 0x60

	// Methods

	// RVA: 0x1277DD0
	internal void .ctor(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x1277E14
	private void Initialize() { }

	// RVA: 0x1277FFC
	protected override MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	// RVA: 0x12780B4
	protected override void Close() { }

}

// Namespace: Mono.Btls
internal enum MonoBtlsX509LookupType
{
	// Fields
	public int value__; // 0x10
	public const MonoBtlsX509LookupType UNKNOWN = 0;
	public const MonoBtlsX509LookupType FILE = 1;
	public const MonoBtlsX509LookupType HASH_DIR = 2;
	public const MonoBtlsX509LookupType MONO = 3;
}

// Namespace: 
internal class BoringX509NameHandle
{
	// Fields
	private bool dontFree; // 0x1E

	// Methods

	// RVA: 0x1274D98
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0x1278760
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Name
{
	// Methods

	// RVA: 0x1278204
	private static extern Int64 mono_btls_x509_name_hash(IntPtr handle) { }

	// RVA: 0x127829C
	private static extern int mono_btls_x509_name_get_entry_count(IntPtr handle) { }

	// RVA: 0x1278334
	private static extern MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index) { }

	// RVA: 0x12783C4
	private static extern int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size) { }

	// RVA: 0x127846C
	private static extern int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, IntPtr data) { }

	// RVA: 0x1278504
	private static extern int mono_btls_x509_name_get_entry_value(IntPtr name, int index, int tag, IntPtr str) { }

	// RVA: 0x12785AC
	private static extern IntPtr mono_btls_x509_name_from_data(Void* data, int len, int use_canon_enc) { }

	// RVA: 0x1278644
	private static extern void mono_btls_x509_name_free(IntPtr handle) { }

	// RVA: 0x12786DC
	internal BoringX509NameHandle get_Handle() { }

	// RVA: 0x1274DC8
	internal void .ctor(BoringX509NameHandle handle) { }

	// RVA: 0x1274F20
	public Int64 GetHash() { }

	// RVA: 0x1274180
	public int GetEntryCount() { }

	// RVA: 0x1273920
	public MonoBtlsX509NameEntryType GetEntryType(int index) { }

	// RVA: 0x1273EE4
	public string GetEntryOid(int index) { }

	// RVA: 0x1273A60
	public Byte[] GetEntryOidData(int index) { }

	// RVA: 0x1273C44
	public string GetEntryValue(int index, int tag) { }

	// RVA: 0x127203C
	public static MonoBtlsX509Name CreateFromData(Byte[] data, bool use_canon_enc) { }

}

// Namespace: Mono.Btls
internal enum MonoBtlsX509NameEntryType
{
	// Fields
	public int value__; // 0x10
	public const MonoBtlsX509NameEntryType Unknown = 0;
	public const MonoBtlsX509NameEntryType CountryName = 1;
	public const MonoBtlsX509NameEntryType OrganizationName = 2;
	public const MonoBtlsX509NameEntryType OrganizationalUnitName = 3;
	public const MonoBtlsX509NameEntryType CommonName = 4;
	public const MonoBtlsX509NameEntryType LocalityName = 5;
	public const MonoBtlsX509NameEntryType StateOrProvinceName = 6;
	public const MonoBtlsX509NameEntryType StreetAddress = 7;
	public const MonoBtlsX509NameEntryType SerialNumber = 8;
	public const MonoBtlsX509NameEntryType DomainComponent = 9;
	public const MonoBtlsX509NameEntryType UserId = 10;
	public const MonoBtlsX509NameEntryType Email = 11;
	public const MonoBtlsX509NameEntryType DnQualifier = 12;
	public const MonoBtlsX509NameEntryType Title = 13;
	public const MonoBtlsX509NameEntryType Surname = 14;
	public const MonoBtlsX509NameEntryType GivenName = 15;
	public const MonoBtlsX509NameEntryType Initial = 16;
}

// Namespace: 
internal class BoringX509StoreHandle
{
	// Methods

	// RVA: 0x1278B68
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1279214
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509Store
{
	// Fields
	private System.Collections.Generic.Dictionary<System.IntPtr,Mono.Btls.MonoBtlsX509Lookup> lookupHash; // 0x20

	// Methods

	// RVA: 0x12766F8
	internal BoringX509StoreHandle get_Handle() { }

	// RVA: 0x1278800
	private static extern IntPtr mono_btls_x509_store_new() { }

	// RVA: 0x1278884
	private static extern IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle) { }

	// RVA: 0x127891C
	private static extern int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509) { }

	// RVA: 0x12789AC
	private static extern void mono_btls_x509_store_free(IntPtr handle) { }

	// RVA: 0x1278A44
	private static BoringX509StoreHandle Create_internal() { }

	// RVA: 0x1278B74
	private static BoringX509StoreHandle Create_internal(BoringSslCtxHandle ctx) { }

	// RVA: 0x1278C90
	internal void .ctor() { }

	// RVA: 0x1271B80
	internal void .ctor(BoringSslCtxHandle ctx) { }

	// RVA: 0x1276EE4
	public void AddCertificate(MonoBtlsX509 x509) { }

	// RVA: 0x1278CBC
	public MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type) { }

	// RVA: 0x1278E68
	public void AddDirectoryLookup(string dir, MonoBtlsX509FileType type) { }

	// RVA: 0x1278EA0
	public void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	// RVA: 0x1278F7C
	protected override void Close() { }

}

// Namespace: 
internal class BoringX509StoreCtxHandle
{
	// Fields
	private bool dontFree; // 0x1E

	// Methods

	// RVA: 0x12799C0
	internal void .ctor(IntPtr handle, bool ownsHandle) { }

	// RVA: 0x127A80C
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509StoreCtx
{
	// Fields
	private System.Nullable<System.Int32> verifyResult; // 0x20

	// Methods

	// RVA: 0x1279298
	internal BoringX509StoreCtxHandle get_Handle() { }

	// RVA: 0x127931C
	private static extern IntPtr mono_btls_x509_store_ctx_new() { }

	// RVA: 0x12793A0
	private static extern IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx) { }

	// RVA: 0x1279438
	private static extern MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, IntPtr error_string) { }

	// RVA: 0x12794C8
	private static extern IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle) { }

	// RVA: 0x1279560
	private static extern int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain) { }

	// RVA: 0x12795F8
	private static extern int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param) { }

	// RVA: 0x1279688
	private static extern int mono_btls_x509_store_ctx_verify_cert(IntPtr handle) { }

	// RVA: 0x1279720
	private static extern IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle) { }

	// RVA: 0x12797B8
	private static extern IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle) { }

	// RVA: 0x1279850
	private static extern void mono_btls_x509_store_ctx_free(IntPtr handle) { }

	// RVA: 0x12798E8
	internal void .ctor() { }

	// RVA: 0x12799F0
	private static BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx) { }

	// RVA: 0x1271BE0
	internal void .ctor(int preverify_ok, IntPtr store_ctx) { }

	// RVA: 0x1279B04
	internal void .ctor(BoringX509StoreCtxHandle ptr, System.Nullable<System.Int32> verifyResult) { }

	// RVA: 0x1279B30
	public MonoBtlsX509Error GetError() { }

	// RVA: 0x1279C28
	public MonoBtlsX509Chain GetChain() { }

	// RVA: 0x1279DF0
	public MonoBtlsX509Chain GetUntrusted() { }

	// RVA: 0x1279FB8
	public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain) { }

	// RVA: 0x127A1FC
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	// RVA: 0x127A3CC
	public int get_VerifyResult() { }

	// RVA: 0x127A4B4
	public int Verify() { }

	// RVA: 0x127A640
	public MonoBtlsX509StoreCtx Copy() { }

}

// Namespace: Mono.Btls
internal static class MonoBtlsX509StoreManager
{
	// Fields
	private static bool initialized; // 0x0
	private static string machineTrustedRootPath; // 0x8
	private static string machineIntermediateCAPath; // 0x10
	private static string machineUntrustedPath; // 0x18
	private static string userTrustedRootPath; // 0x20
	private static string userIntermediateCAPath; // 0x28
	private static string userUntrustedPath; // 0x30

	// Methods

	// RVA: 0x127A8AC
	private static void Initialize() { }

	// RVA: 0x127AA8C
	private static void DoInitialize() { }

	// RVA: 0x127AC24
	public static string GetStorePath(MonoBtlsX509StoreType type) { }

}

// Namespace: Mono.Btls
internal enum MonoBtlsX509StoreType
{
	// Fields
	public int value__; // 0x10
	public const MonoBtlsX509StoreType Custom = 0;
	public const MonoBtlsX509StoreType MachineTrustedRoots = 1;
	public const MonoBtlsX509StoreType MachineIntermediateCA = 2;
	public const MonoBtlsX509StoreType MachineUntrusted = 3;
	public const MonoBtlsX509StoreType UserTrustedRoots = 4;
	public const MonoBtlsX509StoreType UserIntermediateCA = 5;
	public const MonoBtlsX509StoreType UserUntrusted = 6;
}

// Namespace: Mono.Btls
internal enum MonoBtlsX509TrustKind
{
	// Fields
	public int value__; // 0x10
	public const MonoBtlsX509TrustKind DEFAULT = 0;
	public const MonoBtlsX509TrustKind TRUST_CLIENT = 1;
	public const MonoBtlsX509TrustKind TRUST_SERVER = 2;
	public const MonoBtlsX509TrustKind TRUST_ALL = 4;
	public const MonoBtlsX509TrustKind REJECT_CLIENT = 32;
	public const MonoBtlsX509TrustKind REJECT_SERVER = 64;
	public const MonoBtlsX509TrustKind REJECT_ALL = 128;
}

// Namespace: 
internal class BoringX509VerifyParamHandle
{
	// Methods

	// RVA: 0x127B2C0
	public void .ctor(IntPtr handle) { }

	// RVA: 0x127BC80
	protected override bool ReleaseHandle() { }

}

// Namespace: Mono.Btls
internal class MonoBtlsX509VerifyParam
{
	// Methods

	// RVA: 0x1272C90
	internal BoringX509VerifyParamHandle get_Handle() { }

	// RVA: 0x127AD70
	private static extern IntPtr mono_btls_x509_verify_param_copy(IntPtr handle) { }

	// RVA: 0x127AE08
	private static extern IntPtr mono_btls_x509_verify_param_lookup(IntPtr name) { }

	// RVA: 0x127AEA0
	private static extern int mono_btls_x509_verify_param_can_modify(IntPtr param) { }

	// RVA: 0x127AF38
	private static extern int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen) { }

	// RVA: 0x127AFD0
	private static extern int mono_btls_x509_verify_param_set_time(IntPtr handle, Int64 time) { }

	// RVA: 0x127B060
	private static extern void mono_btls_x509_verify_param_free(IntPtr handle) { }

	// RVA: 0x127B0F8
	internal void .ctor(BoringX509VerifyParamHandle handle) { }

	// RVA: 0x127B100
	public MonoBtlsX509VerifyParam Copy() { }

	// RVA: 0x127B2CC
	public static MonoBtlsX509VerifyParam GetSslClient() { }

	// RVA: 0x127B5EC
	public static MonoBtlsX509VerifyParam GetSslServer() { }

	// RVA: 0x127B314
	public static MonoBtlsX509VerifyParam Lookup(string name, bool fail) { }

	// RVA: 0x127B634
	public bool get_CanModify() { }

	// RVA: 0x127B72C
	private void WantToModify() { }

	// RVA: 0x127B794
	public void SetHost(string name) { }

	// RVA: 0x127BA3C
	public void SetTime(DateTime time) { }

}

// Namespace: Mono.Btls
internal class X509CertificateImplBtls
{
	// Fields
	private MonoBtlsX509 x509; // 0xB0
	private MonoBtlsKey nativePrivateKey; // 0xB8
	private X509CertificateImplCollection intermediateCerts; // 0xC0

	// Methods

	// RVA: 0x127BD04
	internal void .ctor(MonoBtlsX509 x509) { }

	// RVA: 0x127BD48
	private void .ctor(X509CertificateImplBtls other) { }

	// RVA: 0x127BE00
	internal void .ctor(Byte[] data, MonoBtlsX509Format format) { }

	// RVA: 0x127BE4C
	internal void .ctor(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x127C968
	public override bool get_IsValid() { }

	// RVA: 0x127C97C
	internal MonoBtlsX509 get_X509() { }

	// RVA: 0x127C9A4
	internal MonoBtlsKey get_NativePrivateKey() { }

	// RVA: 0x127C9CC
	public override X509CertificateImpl Clone() { }

	// RVA: 0x127CA3C
	protected override Byte[] GetRawCertData() { }

	// RVA: 0x127CA7C
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x127CA84
	protected override void Dispose(bool disposing) { }

	// RVA: 0x127CAC8
	public override bool get_HasPrivateKey() { }

	// RVA: 0x127CAD8
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x127CB08
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x127CC4C
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x127CC7C
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x127C224
	private void Import(Byte[] data) { }

	// RVA: 0x127C290
	private void ImportPkcs12(Byte[] data, SafePasswordHandle password) { }

	// RVA: 0x127C894
	private void ImportAuthenticode(Byte[] data) { }

	// RVA: 0x127CCBC
	public override bool Verify(X509Certificate2 thisCertificate) { }

}

// Namespace: Mono.Btls
internal class X509ChainImplBtls
{
	// Fields
	private MonoBtlsX509StoreCtx storeCtx; // 0x10
	private MonoBtlsX509Chain chain; // 0x18
	private MonoBtlsX509Chain untrustedChain; // 0x20
	private X509ChainElementCollection elements; // 0x28
	private X509Certificate2Collection untrusted; // 0x30
	private X509Certificate2[] certificates; // 0x38
	private X509ChainPolicy policy; // 0x40
	private System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList; // 0x48

	// Methods

	// RVA: 0x127CF40
	internal void .ctor(MonoBtlsX509Chain chain) { }

	// RVA: 0x127CFDC
	internal void .ctor(MonoBtlsX509StoreCtx storeCtx) { }

	// RVA: 0x127D2F0
	public override bool get_IsValid() { }

	// RVA: 0x127D304
	internal MonoBtlsX509StoreCtx get_StoreCtx() { }

	// RVA: 0x127D32C
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x127D650
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x127D658
	public override void AddStatus(X509ChainStatusFlags errorCode) { }

	// RVA: 0x127D75C
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x127D764
	public override void Reset() { }

	// RVA: 0x127D814
	protected override void Dispose(bool disposing) { }

}

// Namespace: Mono.Btls
internal class X509PalImplBtls
{
	// Fields
	private readonly MonoBtlsProvider <Provider>k__BackingField; // 0x10

	// Methods

	// RVA: 0x127D974
	public void .ctor(MonoTlsProvider provider) { }

	// RVA: 0x127DA90
	private MonoBtlsProvider get_Provider() { }

	// RVA: 0x127DA98
	public override X509CertificateImpl Import(Byte[] data) { }

	// RVA: 0x127DAC0
	public override X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x127DAE0
	public override X509Certificate2Impl Import(X509Certificate cert) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly Internal.Cryptography.OidLookup.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1280230
	private static void .cctor() { }

	// RVA: 0x128029C
	public void .ctor() { }

	// RVA: 0x12802A4
	internal string <.cctor>b__10_0(System.Collections.Generic.KeyValuePair<System.String,System.String> kvp) { }

	// RVA: 0x1280370
	internal string <.cctor>b__10_1(System.Collections.Generic.KeyValuePair<System.String,System.String> kvp) { }

}

// Namespace: Internal.Cryptography
internal static class OidLookup
{
	// Fields
	private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.String,System.String> s_lateBoundOidToFriendlyName; // 0x0
	private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.String,System.String> s_lateBoundFriendlyNameToOid; // 0x8
	private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_friendlyNameToOid; // 0x10
	private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_oidToFriendlyName; // 0x18
	private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_compatOids; // 0x20

	// Methods

	// RVA: 0x127DB00
	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x127E010
	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x127DCE8
	private static bool ShouldUseCache(OidGroup oidGroup) { }

	// RVA: 0x127DCF0
	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x127E1FC
	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x127E524
	private static void .cctor() { }

}

// Namespace: Internal.Cryptography.Pal
internal enum GeneralNameType
{
	// Fields
	public int value__; // 0x10
	public const GeneralNameType OtherName = 0;
	public const GeneralNameType Rfc822Name = 1;
	public const GeneralNameType Email = 1;
	public const GeneralNameType DnsName = 2;
	public const GeneralNameType X400Address = 3;
	public const GeneralNameType DirectoryName = 4;
	public const GeneralNameType EdiPartyName = 5;
	public const GeneralNameType UniformResourceIdentifier = 6;
	public const GeneralNameType IPAddress = 7;
	public const GeneralNameType RegisteredId = 8;
}

// Namespace: 
internal struct AlgorithmIdentifier
{
	// Fields
	internal string AlgorithmId; // 0x10
	internal Byte[] Parameters; // 0x18
}

// Namespace: 
private sealed class <ReadReverseRdns>d__21
{
	// Fields
	private int <>1__state; // 0x10
	private System.Collections.Generic.KeyValuePair<System.String,System.String> <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x28
	private X500DistinguishedName name; // 0x30
	public X500DistinguishedName <>3__name; // 0x38
	private System.Collections.Generic.Stack<System.Security.Cryptography.DerSequenceReader> <rdnReaders>5__2; // 0x40
	private DerSequenceReader <rdnReader>5__3; // 0x48

	// Methods

	// RVA: 0x1281D3C
	public void .ctor(int <>1__state) { }

	// RVA: 0x1281D74
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1281D78
	private bool MoveNext() { }

	// RVA: 0x128204C
	private System.Collections.Generic.KeyValuePair<System.String,System.String> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

	// RVA: 0x1282058
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1282098
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1282100
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	// RVA: 0x12821A8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: Internal.Cryptography.Pal
internal struct CertificateData
{
	// Fields
	internal Byte[] RawData; // 0x10
	internal Byte[] SubjectPublicKeyInfo; // 0x18
	internal int Version; // 0x20
	internal Byte[] SerialNumber; // 0x28
	internal AlgorithmIdentifier TbsSignature; // 0x30
	internal X500DistinguishedName Issuer; // 0x40
	internal DateTime NotBefore; // 0x48
	internal DateTime NotAfter; // 0x50
	internal X500DistinguishedName Subject; // 0x58
	internal AlgorithmIdentifier PublicKeyAlgorithm; // 0x60
	internal Byte[] PublicKey; // 0x70
	internal Byte[] IssuerUniqueId; // 0x78
	internal Byte[] SubjectUniqueId; // 0x80
	internal System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509Extension> Extensions; // 0x88
	internal AlgorithmIdentifier SignatureAlgorithm; // 0x90
	internal Byte[] SignatureValue; // 0xA0

	// Methods

	// RVA: 0x1280438
	internal void .ctor(Byte[] rawData) { }

	// RVA: 0x1280C70
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x1281508
	private static string GetSimpleNameInfo(X500DistinguishedName name) { }

	// RVA: 0x1281A88
	private static string FindAltNameMatch(Byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	// RVA: 0x1281CB4
	private static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>> ReadReverseRdns(X500DistinguishedName name) { }

}

// Namespace: System
internal static class IPv4AddressHelper
{
	// Methods

	// RVA: 0x12821AC
	internal static int ParseHostNumber(System.ReadOnlySpan<System.Char> str, int start, int end) { }

	// RVA: 0x12823B4
	internal static bool IsValid(Char* name, int start, int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x12821E0
	private static bool ParseCanonical(System.ReadOnlySpan<System.Char> name, Byte* numbers, int start, int end) { }

	// RVA: 0x12823E0
	internal static bool IsValidCanonical(Char* name, int start, int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x1282708
	internal static Int64 ParseNonCanonical(Char* name, int start, int end, bool notImplicitFile) { }

	// RVA: 0x1282AD0
	internal static string ParseCanonicalName(string str, int start, int end, bool isLoopback) { }

	// RVA: 0x1282F90
	private static bool Parse(string name, Byte* numbers, int start, int end) { }

}

// Namespace: System
internal static class IPv6AddressHelper
{
	// Methods

	// RVA: 0x1283000
	internal static System.ValueTuple<System.Int32,System.Int32> FindCompressionRange(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x12830F4
	internal static bool ShouldHaveIpv4Embedded(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x12831D8
	internal static bool IsValidStrict(Char* name, int start, int end) { }

	// RVA: 0x1283654
	internal static void Parse(System.ReadOnlySpan<System.Char> address, UInt16* numbers, int start, string scopeId) { }

	// RVA: 0x1283BF0
	internal static string ParseCanonicalName(string str, int start, bool isLoopback, string scopeId) { }

	// RVA: 0x1284504
	private static bool IsLoopback(System.ReadOnlySpan<System.UInt16> numbers) { }

	// RVA: 0x12845F0
	private static bool InternalIsValid(Char* name, int start, int end, bool validateStrictAddress) { }

	// RVA: 0x12849D0
	internal static bool IsValid(Char* name, int start, int end) { }

}

// Namespace: System
internal static class NotImplemented
{
	// Methods

	// RVA: 0x12849D8
	internal static Exception ByDesignWithMessage(string message) { }

}

// Namespace: System
public class UriBuilder
{
	// Fields
	private bool _changed; // 0x10
	private string _fragment; // 0x18
	private string _host; // 0x20
	private string _password; // 0x28
	private string _path; // 0x30
	private int _port; // 0x38
	private string _query; // 0x40
	private string _scheme; // 0x48
	private string _schemeDelimiter; // 0x50
	private Uri _uri; // 0x58
	private string _username; // 0x60

	// Methods

	// RVA: 0x1284A40
	public void .ctor(Uri uri) { }

	// RVA: 0x1284C18
	private void Init(Uri uri) { }

	// RVA: 0x1284FE8
	public void set_Path(string value) { }

	// RVA: 0x12850B0
	public Uri get_Uri() { }

	// RVA: 0x1285158
	public override bool Equals(object rparam) { }

	// RVA: 0x1285244
	public override int GetHashCode() { }

	// RVA: 0x1284DF8
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x12852FC
	public override string ToString() { }

}

// Namespace: System
internal static class SecurityUtils
{
	// Methods

	// RVA: 0x1285960
	private static void DemandReflectionAccess(Type type) { }

	// RVA: 0x1285964
	private static void DemandGrantSet(Assembly assembly) { }

	// RVA: 0x1285968
	private static bool HasReflectionPermission(Type type) { }

	// RVA: 0x1285970
	internal static object SecureCreateInstance(Type type) { }

	// RVA: 0x128597C
	internal static object SecureCreateInstance(Type type, object[] args, bool allowNonPublic) { }

	// RVA: 0x1285A9C
	internal static object SecureCreateInstance(Type type, object[] args) { }

	// RVA: 0x1285AA4
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic) { }

	// RVA: 0x1285AAC
	internal static object SecureConstructorInvoke(Type type, Type[] argTypes, object[] args, bool allowNonPublic, BindingFlags extraFlags) { }

	// RVA: 0x1285C60
	private static bool GenericArgumentsAreVisible(MethodInfo method) { }

	// RVA: 0x1285D08
	internal static object MethodInfoInvoke(MethodInfo method, object target, object[] args) { }

}

// Namespace: System
[Serializable]
internal class InvariantComparer
{
	// Fields
	private CompareInfo m_compareInfo; // 0x10
	internal static readonly InvariantComparer Default; // 0x0

	// Methods

	// RVA: 0x1285EFC
	internal void .ctor() { }

	// RVA: 0x1285FB0
	public int Compare(object a, object b) { }

	// RVA: 0x12860AC
	private static void .cctor() { }

}

// Namespace: System
internal static class IriHelper
{
	// Methods

	// RVA: 0x1286114
	internal static bool CheckIriUnicodeRange(Char unicode, bool isQuery) { }

	// RVA: 0x128616C
	internal static bool CheckIriUnicodeRange(Char highSurr, Char lowSurr, bool surrogatePair, bool isQuery) { }

	// RVA: 0x12867E8
	internal static bool CheckIsReserved(Char ch, UriComponents component) { }

	// RVA: 0x1286958
	internal static string EscapeUnescapeIri(Char* pInput, int start, int end, UriComponents component) { }

}

// Namespace: 
private enum Flags
{
	// Fields
	public UInt64 value__; // 0x10
	public const Flags Zero = 0;
	public const Flags SchemeNotCanonical = 1;
	public const Flags UserNotCanonical = 2;
	public const Flags HostNotCanonical = 4;
	public const Flags PortNotCanonical = 8;
	public const Flags PathNotCanonical = 16;
	public const Flags QueryNotCanonical = 32;
	public const Flags FragmentNotCanonical = 64;
	public const Flags CannotDisplayCanonical = 127;
	public const Flags E_UserNotCanonical = 128;
	public const Flags E_HostNotCanonical = 256;
	public const Flags E_PortNotCanonical = 512;
	public const Flags E_PathNotCanonical = 1024;
	public const Flags E_QueryNotCanonical = 2048;
	public const Flags E_FragmentNotCanonical = 4096;
	public const Flags E_CannotDisplayCanonical = 8064;
	public const Flags ShouldBeCompressed = 8192;
	public const Flags FirstSlashAbsent = 16384;
	public const Flags BackslashInPath = 32768;
	public const Flags IndexMask = 65535;
	public const Flags HostTypeMask = 458752;
	public const Flags HostNotParsed = 0;
	public const Flags IPv6HostType = 65536;
	public const Flags IPv4HostType = 131072;
	public const Flags DnsHostType = 196608;
	public const Flags UncHostType = 262144;
	public const Flags BasicHostType = 327680;
	public const Flags UnusedHostType = 393216;
	public const Flags UnknownHostType = 458752;
	public const Flags UserEscaped = 524288;
	public const Flags AuthorityFound = 1048576;
	public const Flags HasUserInfo = 2097152;
	public const Flags LoopbackHost = 4194304;
	public const Flags NotDefaultPort = 8388608;
	public const Flags UserDrivenParsing = 16777216;
	public const Flags CanonicalDnsHost = 33554432;
	public const Flags ErrorOrParsingRecursion = 67108864;
	public const Flags DosPath = 134217728;
	public const Flags UncPath = 268435456;
	public const Flags ImplicitFile = 536870912;
	public const Flags MinimalUriInfoSet = 1073741824;
	public const Flags AllUriInfoSet = 2147483648;
	public const Flags IdnHost = 4294967296;
	public const Flags HasUnicode = 8589934592;
	public const Flags HostUnicodeNormalized = 17179869184;
	public const Flags RestUnicodeNormalized = 34359738368;
	public const Flags UnicodeHost = 68719476736;
	public const Flags IntranetUri = 137438953472;
	public const Flags UseOrigUncdStrOffset = 274877906944;
	public const Flags UserIriCanonical = 549755813888;
	public const Flags PathIriCanonical = 1099511627776;
	public const Flags QueryIriCanonical = 2199023255552;
	public const Flags FragmentIriCanonical = 4398046511104;
	public const Flags IriCanonical = 8246337208320;
	public const Flags CompressedSlashes = 17592186044416;
}

// Namespace: 
private class UriInfo
{
	// Fields
	public string Host; // 0x10
	public string ScopeId; // 0x18
	public string String; // 0x20
	public Offset Offset; // 0x28
	public string DnsSafeHost; // 0x38
	public MoreInfo MoreInfo; // 0x40

	// Methods

	// RVA: 0x1287DD8
	public void .ctor() { }

}

// Namespace: 
private struct Offset
{
	// Fields
	public UInt16 Scheme; // 0x10
	public UInt16 User; // 0x12
	public UInt16 Host; // 0x14
	public UInt16 PortValue; // 0x16
	public UInt16 Path; // 0x18
	public UInt16 Query; // 0x1A
	public UInt16 Fragment; // 0x1C
	public UInt16 End; // 0x1E
}

// Namespace: 
private class MoreInfo
{
	// Fields
	public string Path; // 0x10
	public string Query; // 0x18
	public string Fragment; // 0x20
	public string AbsoluteUri; // 0x28
	public int Hash; // 0x30
	public string RemoteUrl; // 0x38

	// Methods

	// RVA: 0x1287DE0
	public void .ctor() { }

}

// Namespace: 
private enum Check
{
	// Fields
	public int value__; // 0x10
	public const Check None = 0;
	public const Check EscapedCanonical = 1;
	public const Check DisplayCanonical = 2;
	public const Check DotSlashAttn = 4;
	public const Check DotSlashEscaped = 128;
	public const Check BackslashInPath = 16;
	public const Check ReservedFound = 32;
	public const Check NotIriCanonical = 64;
	public const Check FoundNonAscii = 8;
}

// Namespace: System
[Serializable]
public class Uri
{
	// Fields
	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private const int c_Max16BitUtf8SequenceLength = 12;
	internal const int c_MaxUriBufferSize = 65520;
	private const int c_MaxUriSchemeName = 1024;
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Flags m_Flags; // 0x30
	private UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const Char c_DummyChar = 65535;
	internal const Char c_EOL = 65534;
	internal static readonly Char[] HexLowerChars; // 0x80
	private static readonly Char[] _WSchars; // 0x88

	// Methods

	// RVA: 0x1210570
	private bool get_IsImplicitFile() { }

	// RVA: 0x121057C
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x121058C
	private bool get_IsDosPath() { }

	// RVA: 0x1210598
	private bool get_IsUncPath() { }

	// RVA: 0x12105A4
	private Flags get_HostType() { }

	// RVA: 0x12105B0
	private UriParser get_Syntax() { }

	// RVA: 0x12105B8
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x12105C8
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x1210690
	private bool get_AllowIdn() { }

	// RVA: 0x12107AC
	private bool AllowIdnStatic(UriParser syntax, Flags flags) { }

	// RVA: 0x12108E8
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x12108F0
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x12108FC
	private void SetUserDrivenParsing() { }

	// RVA: 0x1210910
	private UInt16 get_SecuredPathIndex() { }

	// RVA: 0x121079C
	private bool NotAny(Flags flags) { }

	// RVA: 0x1210970
	private bool InFact(Flags flags) { }

	// RVA: 0x12108DC
	private static bool StaticNotAny(Flags allFlags, Flags checkFlags) { }

	// RVA: 0x1210980
	private static bool StaticInFact(Flags allFlags, Flags checkFlags) { }

	// RVA: 0x121098C
	private UriInfo EnsureUriInfo() { }

	// RVA: 0x1210FCC
	private void EnsureParseRemaining() { }

	// RVA: 0x1211E7C
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x1212304
	public void .ctor(string uriString) { }

	// RVA: 0x121255C
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x12125EC
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x12126DC
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x1212FF0
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x121323C
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, string result) { }

	// RVA: 0x12141F8
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x1214394
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12144B4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12144B8
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1214614
	public string get_AbsolutePath() { }

	// RVA: 0x12146D4
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x12147D0
	public string get_AbsoluteUri() { }

	// RVA: 0x121490C
	public string get_LocalPath() { }

	// RVA: 0x121511C
	public string get_Authority() { }

	// RVA: 0x1215194
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x12152E4
	public bool get_IsDefaultPort() { }

	// RVA: 0x12153C0
	public bool get_IsFile() { }

	// RVA: 0x1215484
	public bool get_IsLoopback() { }

	// RVA: 0x1215540
	public string get_PathAndQuery() { }

	// RVA: 0x1215608
	public string[] get_Segments() { }

	// RVA: 0x121585C
	public bool get_IsUnc() { }

	// RVA: 0x12158D4
	public string get_Host() { }

	// RVA: 0x121594C
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x1215968
	private static object get_InitializeLock() { }

	// RVA: 0x1215A6C
	private static void InitializeUriConfig() { }

	// RVA: 0x121497C
	private string GetLocalPath() { }

	// RVA: 0x1216228
	public int get_Port() { }

	// RVA: 0x1216320
	public string get_Query() { }

	// RVA: 0x1216460
	public string get_Fragment() { }

	// RVA: 0x12165A0
	public string get_Scheme() { }

	// RVA: 0x1216614
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x1213608
	public string get_OriginalString() { }

	// RVA: 0x1216670
	public string get_DnsSafeHost() { }

	// RVA: 0x12126CC
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x12168E8
	public bool get_UserEscaped() { }

	// RVA: 0x12168F4
	public string get_UserInfo() { }

	// RVA: 0x121696C
	internal static bool IsGenDelim(Char ch) { }

	// RVA: 0x1216990
	public static bool IsHexDigit(Char character) { }

	// RVA: 0x12169BC
	public static int FromHex(Char digit) { }

	// RVA: 0x1216A50
	public override int GetHashCode() { }

	// RVA: 0x1216CFC
	public override string ToString() { }

	// RVA: 0x1217078
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x1212E34
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x12170AC
	public override bool Equals(object comparand) { }

	// RVA: 0x1217814
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x12178D8
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x12179C8
	private static ParsingError ParseScheme(string uriString, Flags flags, UriParser syntax) { }

	// RVA: 0x12180D0
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x1218164
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x12197D8
	private void PrivateParseMinimalIri(string newHost, UInt16 idx) { }

	// RVA: 0x12109BC
	private void CreateUriInfo(Flags cF) { }

	// RVA: 0x1211EDC
	private void CreateHostString() { }

	// RVA: 0x1219D1C
	private static string CreateHostStringHelper(string str, UInt16 idx, UInt16 end, Flags flags, string scopeId) { }

	// RVA: 0x12198D0
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x1214610
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x121A4E8
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x121613C
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x121AC90
	private string ReCreateParts(UriComponents parts, UInt16 nonCanonical, UriFormat formatAs) { }

	// RVA: 0x121A5D8
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x1210FDC
	private void ParseRemaining() { }

	// RVA: 0x1217AD8
	private static UInt16 ParseSchemeCheckImplicitFile(Char* uriString, UInt16 length, ParsingError err, Flags flags, UriParser syntax) { }

	// RVA: 0x121C23C
	private static bool CheckKnownSchemes(Int64* lptr, UInt16 nChars, UriParser syntax) { }

	// RVA: 0x12134AC
	private static ParsingError CheckSchemeSyntax(Char* ptr, UInt16 length, UriParser syntax) { }

	// RVA: 0x1218858
	private UInt16 CheckAuthorityHelper(Char* pString, UInt16 idx, UInt16 length, ParsingError err, Flags flags, UriParser syntax, string newHost) { }

	// RVA: 0x121C790
	private void CheckAuthorityHelperHandleDnsIri(Char* pString, UInt16 start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, Flags flags, bool justNormalized, string newHost, ParsingError err) { }

	// RVA: 0x121CC04
	private void CheckAuthorityHelperHandleAnyHostIri(Char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, Flags flags, string newHost, ParsingError err) { }

	// RVA: 0x121C0D4
	private void FindEndOfComponent(string input, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x121D10C
	private void FindEndOfComponent(Char* str, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x1219F00
	private Check CheckCanonical(Char* str, UInt16 idx, UInt16 end, Char delim) { }

	// RVA: 0x121B93C
	private Char[] GetCanonicalPath(Char[] dest, int pos, UriFormat formatAs) { }

	// RVA: 0x121D1B8
	private static void UnescapeOnly(Char* pch, int start, int end, Char ch1, Char ch2, Char ch3) { }

	// RVA: 0x1215C40
	private static Char[] Compress(Char[] dest, UInt16 start, int destLength, UriParser syntax) { }

	// RVA: 0x1216C20
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x121366C
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x121D3C0
	internal bool get_HasAuthority() { }

	// RVA: 0x1218828
	private static bool IsLWS(Char ch) { }

	// RVA: 0x1218844
	private static bool IsAsciiLetter(Char character) { }

	// RVA: 0x121D3CC
	internal static bool IsAsciiLetterOrDigit(Char character) { }

	// RVA: 0x121D440
	internal static bool IsBidiControlCharacter(Char ch) { }

	// RVA: 0x121CF1C
	internal static string StripBidiControlCharacter(Char* strToClean, int start, int length) { }

	// RVA: 0x1212388
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x121D464
	private void InitializeUri(ParsingError err, UriKind uriKind, UriFormatException e) { }

	// RVA: 0x121DB54
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x121DC44
	private bool CheckForUnicode(string data) { }

	// RVA: 0x121DD80
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x1217718
	public static bool TryCreate(string uriString, UriKind uriKind, Uri result) { }

	// RVA: 0x121E250
	public static bool TryCreate(Uri baseUri, string relativeUri, Uri result) { }

	// RVA: 0x121E38C
	public static bool TryCreate(Uri baseUri, Uri relativeUri, Uri result) { }

	// RVA: 0x121A30C
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x121E7DC
	public bool IsWellFormedOriginalString() { }

	// RVA: 0x121ECE4
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	// RVA: 0x121E830
	internal bool InternalIsWellFormedOriginalString() { }

	// RVA: 0x121EDE8
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x121EFAC
	public static string EscapeDataString(string stringToEscape) { }

	// RVA: 0x121C1E4
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x121F0E8
	private void .ctor(Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x121DF90
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, UriFormatException e) { }

	// RVA: 0x1212894
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, string newUriString, bool userEscaped, UriFormatException e) { }

	// RVA: 0x121E570
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x1216DFC
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x121F140
	public bool IsBaseOf(Uri uri) { }

	// RVA: 0x121F1F8
	internal bool IsBaseOfHelper(Uri uriLink) { }

	// RVA: 0x1212E7C
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x121F3FC
	private static void .cctor() { }

}

// Namespace: System
[Serializable]
public class UriFormatException
{
	// Methods

	// RVA: 0x1287DE8
	public void .ctor() { }

	// RVA: 0x1285770
	public void .ctor(string textString) { }

	// RVA: 0x1287DF0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1287DF8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Namespace: System
public enum UriKind
{
	// Fields
	public int value__; // 0x10
	public const UriKind RelativeOrAbsolute = 0;
	public const UriKind Absolute = 1;
	public const UriKind Relative = 2;
}

// Namespace: System
public enum UriComponents
{
	// Fields
	public int value__; // 0x10
	public const UriComponents Scheme = 1;
	public const UriComponents UserInfo = 2;
	public const UriComponents Host = 4;
	public const UriComponents Port = 8;
	public const UriComponents Path = 16;
	public const UriComponents Query = 32;
	public const UriComponents Fragment = 64;
	public const UriComponents StrongPort = 128;
	public const UriComponents NormalizedHost = 256;
	public const UriComponents KeepDelimiter = 1073741824;
	public const UriComponents SerializationInfoString = 2147483648;
	public const UriComponents AbsoluteUri = 127;
	public const UriComponents HostAndPort = 132;
	public const UriComponents StrongAuthority = 134;
	public const UriComponents SchemeAndServer = 13;
	public const UriComponents HttpRequestUrl = 61;
	public const UriComponents PathAndQuery = 48;
}

// Namespace: System
public enum UriFormat
{
	// Fields
	public int value__; // 0x10
	public const UriFormat UriEscaped = 1;
	public const UriFormat Unescaped = 2;
	public const UriFormat SafeUnescaped = 3;
}

// Namespace: System
public enum UriIdnScope
{
	// Fields
	public int value__; // 0x10
	public const UriIdnScope None = 0;
	public const UriIdnScope AllExceptIntranet = 1;
	public const UriIdnScope All = 2;
}

// Namespace: System
internal enum ParsingError
{
	// Fields
	public int value__; // 0x10
	public const ParsingError None = 0;
	public const ParsingError BadFormat = 1;
	public const ParsingError BadScheme = 2;
	public const ParsingError BadAuthority = 3;
	public const ParsingError EmptyUriString = 4;
	public const ParsingError LastRelativeUriOkErrIndex = 4;
	public const ParsingError SchemeLimit = 5;
	public const ParsingError SizeLimit = 6;
	public const ParsingError MustRootedPath = 7;
	public const ParsingError BadHostName = 8;
	public const ParsingError NonEmptyHost = 9;
	public const ParsingError BadPort = 10;
	public const ParsingError BadAuthorityTerminator = 11;
	public const ParsingError CannotCreateRelative = 12;
}

// Namespace: System
internal enum UnescapeMode
{
	// Fields
	public int value__; // 0x10
	public const UnescapeMode CopyOnly = 0;
	public const UnescapeMode Escape = 1;
	public const UnescapeMode Unescape = 2;
	public const UnescapeMode EscapeUnescape = 3;
	public const UnescapeMode V1ToStringFlag = 4;
	public const UnescapeMode UnescapeAll = 8;
	public const UnescapeMode UnescapeAllOrThrow = 24;
}

// Namespace: System
internal static class UriHelper
{
	// Fields
	private static readonly Char[] HexUpperChars; // 0x0

	// Methods

	// RVA: 0x1287E00
	internal static bool TestForSubPath(Char* pMe, UInt16 meLength, Char* pShe, UInt16 sheLength, bool ignoreCase) { }

	// RVA: 0x128807C
	internal static Char[] EscapeString(string input, int start, int end, Char[] dest, int destPos, bool isUriString, Char force1, Char force2, Char rsvd) { }

	// RVA: 0x1288790
	private static Char[] EnsureDestinationSize(Char* pStr, Char[] dest, int currentInputPos, Int16 charsToAdd, Int16 minReallocateChars, int destPos, int prevInputPos) { }

	// RVA: 0x1288C5C
	internal static Char[] UnescapeString(string input, int start, int end, Char[] dest, int destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x1288D34
	internal static Char[] UnescapeString(Char* pStr, int start, int end, Char[] dest, int destPosition, Char rsvd1, Char rsvd2, Char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x1287498
	internal static void MatchUTF8Sequence(Char* pDest, Char[] dest, int destOffset, Char[] unescapedChars, int charCount, Byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x1287CC8
	internal static void EscapeAsciiChar(Char ch, Char[] to, int pos) { }

	// RVA: 0x12873BC
	internal static Char EscapedAscii(Char digit, Char next) { }

	// RVA: 0x1287424
	internal static bool IsNotSafeForUnescape(Char ch) { }

	// RVA: 0x1288AC0
	private static bool IsReservedUnreservedOrHash(Char c) { }

	// RVA: 0x1288948
	internal static bool IsUnreserved(Char c) { }

	// RVA: 0x1289888
	internal static bool Is3986Unreserved(Char c) { }

	// RVA: 0x1289958
	private static void .cctor() { }

}

// Namespace: System
public enum UriHostNameType
{
	// Fields
	public int value__; // 0x10
	public const UriHostNameType Unknown = 0;
	public const UriHostNameType Basic = 1;
	public const UriHostNameType Dns = 2;
	public const UriHostNameType IPv4 = 3;
	public const UriHostNameType IPv6 = 4;
}

// Namespace: 
private enum UriQuirksVersion
{
	// Fields
	public int value__; // 0x10
	public const UriQuirksVersion V2 = 2;
	public const UriQuirksVersion V3 = 3;
}

// Namespace: 
private class BuiltInUriParser
{
	// Methods

	// RVA: 0x128A7D0
	internal void .ctor(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags) { }

}

// Namespace: System
public abstract class UriParser
{
	// Fields
	private const UriSyntaxFlags SchemeOnlyFlags = 16;
	private static readonly System.Collections.Generic.Dictionary<System.String,System.UriParser> m_Table; // 0x0
	private static System.Collections.Generic.Dictionary<System.String,System.UriParser> m_TempTable; // 0x8
	private UriSyntaxFlags m_Flags; // 0x10
	private UriSyntaxFlags m_UpdatableFlags; // 0x14
	private bool m_UpdatableFlagsUsed; // 0x18
	private const UriSyntaxFlags c_UpdatableFlags = 33554432;
	private int m_Port; // 0x1C
	private string m_Scheme; // 0x20
	internal const int NoDefaultPort = 4294967295;
	private const int c_InitialTableSize = 25;
	internal static UriParser HttpUri; // 0x10
	internal static UriParser HttpsUri; // 0x18
	internal static UriParser WsUri; // 0x20
	internal static UriParser WssUri; // 0x28
	internal static UriParser FtpUri; // 0x30
	internal static UriParser FileUri; // 0x38
	internal static UriParser GopherUri; // 0x40
	internal static UriParser NntpUri; // 0x48
	internal static UriParser NewsUri; // 0x50
	internal static UriParser MailToUri; // 0x58
	internal static UriParser UuidUri; // 0x60
	internal static UriParser TelnetUri; // 0x68
	internal static UriParser LdapUri; // 0x70
	internal static UriParser NetTcpUri; // 0x78
	internal static UriParser NetPipeUri; // 0x80
	internal static UriParser VsMacrosUri; // 0x88
	private static readonly UriQuirksVersion s_QuirksVersion; // 0x90
	private const int c_MaxCapacity = 512;
	private const UriSyntaxFlags UnknownV1SyntaxFlags = 351342590;
	private static readonly UriSyntaxFlags HttpSyntaxFlags; // 0x94
	private const UriSyntaxFlags FtpSyntaxFlags = 367005533;
	private static readonly UriSyntaxFlags FileSyntaxFlags; // 0x98
	private const UriSyntaxFlags VsmacrosSyntaxFlags = 399519697;
	private const UriSyntaxFlags GopherSyntaxFlags = 337645405;
	private const UriSyntaxFlags NewsSyntaxFlags = 268435536;
	private const UriSyntaxFlags NntpSyntaxFlags = 337645405;
	private const UriSyntaxFlags TelnetSyntaxFlags = 337645405;
	private const UriSyntaxFlags LdapSyntaxFlags = 337645565;
	private const UriSyntaxFlags MailtoSyntaxFlags = 335564796;
	private const UriSyntaxFlags NetPipeSyntaxFlags = 400559729;
	private const UriSyntaxFlags NetTcpSyntaxFlags = 400559737;

	// Methods

	// RVA: 0x12899FC
	internal string get_SchemeName() { }

	// RVA: 0x1289A04
	internal int get_DefaultPort() { }

	// RVA: 0x1289A0C
	protected virtual UriParser OnNewUri() { }

	// RVA: 0x1289A10
	protected virtual void InitializeAndValidate(Uri uri, UriFormatException parsingError) { }

	// RVA: 0x1289A4C
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, UriFormatException parsingError) { }

	// RVA: 0x1289C70
	protected virtual bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x1289C90
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x1289EB4
	protected virtual bool IsWellFormedOriginalString(Uri uri) { }

	// RVA: 0x1289824
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x1289ED0
	private static void .cctor() { }

	// RVA: 0x128A8CC
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0x12858F4
	internal bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x1285888
	internal bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x128A934
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x128A8D4
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x128A9A0
	internal void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x128AA14
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x1285778
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x128AD24
	internal bool get_IsSimple() { }

	// RVA: 0x128AD30
	internal UriParser InternalOnNewUri() { }

	// RVA: 0x128AD9C
	internal void InternalValidate(Uri thisUri, UriFormatException parsingError) { }

	// RVA: 0x128ADA8
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, UriFormatException parsingError) { }

	// RVA: 0x128ADB4
	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	// RVA: 0x128ADC0
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x128ADCC
	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }

}

// Namespace: System
internal class DomainNameHelper
{
	// Methods

	// RVA: 0x128ADD8
	internal static string ParseCanonicalName(string str, int start, int end, bool loopback) { }

	// RVA: 0x128AF78
	internal static bool IsValid(Char* name, UInt16 pos, int returnedEnd, bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x128B1A0
	internal static bool IsValidByIri(Char* name, UInt16 pos, int returnedEnd, bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x128B398
	internal static string IdnEquivalent(Char* hostname, int start, int end, bool allAscii, bool atLeastOneValidIdn) { }

	// RVA: 0x128B710
	internal static string IdnEquivalent(Char* hostname, int start, int end, bool allAscii, string bidiStrippedHost) { }

	// RVA: 0x128B978
	private static bool IsIdnAce(string input, int index) { }

	// RVA: 0x128B92C
	private static bool IsIdnAce(Char* input, int index) { }

	// RVA: 0x128BA0C
	internal static string UnicodeEquivalent(string idnHost, Char* hostname, int start, int end) { }

	// RVA: 0x128BB48
	internal static string UnicodeEquivalent(Char* hostname, int start, int end, bool allAscii, bool atLeastOneValidIdn) { }

	// RVA: 0x128B118
	private static bool IsASCIILetterOrDigit(Char character, bool notCanonical) { }

	// RVA: 0x128B154
	private static bool IsValidDomainLabelCharacter(Char character, bool notCanonical) { }

}

// Namespace: System
internal class UncNameHelper
{
	// Methods

	// RVA: 0x128C0D4
	internal static string ParseCanonicalName(string str, int start, int end, bool loopback) { }

	// RVA: 0x128C0DC
	internal static bool IsValid(Char* name, UInt16 start, int returnedEnd, bool notImplicitFile) { }

}

// Namespace: System
internal enum UriSyntaxFlags
{
	// Fields
	public int value__; // 0x10
	public const UriSyntaxFlags None = 0;
	public const UriSyntaxFlags MustHaveAuthority = 1;
	public const UriSyntaxFlags OptionalAuthority = 2;
	public const UriSyntaxFlags MayHaveUserInfo = 4;
	public const UriSyntaxFlags MayHavePort = 8;
	public const UriSyntaxFlags MayHavePath = 16;
	public const UriSyntaxFlags MayHaveQuery = 32;
	public const UriSyntaxFlags MayHaveFragment = 64;
	public const UriSyntaxFlags AllowEmptyHost = 128;
	public const UriSyntaxFlags AllowUncHost = 256;
	public const UriSyntaxFlags AllowDnsHost = 512;
	public const UriSyntaxFlags AllowIPv4Host = 1024;
	public const UriSyntaxFlags AllowIPv6Host = 2048;
	public const UriSyntaxFlags AllowAnInternetHost = 3584;
	public const UriSyntaxFlags AllowAnyOtherHost = 4096;
	public const UriSyntaxFlags FileLikeUri = 8192;
	public const UriSyntaxFlags MailToLikeUri = 16384;
	public const UriSyntaxFlags V1_UnknownUri = 65536;
	public const UriSyntaxFlags SimpleUserSyntax = 131072;
	public const UriSyntaxFlags BuiltInSyntax = 262144;
	public const UriSyntaxFlags ParserSchemeOnly = 524288;
	public const UriSyntaxFlags AllowDOSPath = 1048576;
	public const UriSyntaxFlags PathIsRooted = 2097152;
	public const UriSyntaxFlags ConvertPathSlashes = 4194304;
	public const UriSyntaxFlags CompressPath = 8388608;
	public const UriSyntaxFlags CanonicalizeAsFilePath = 16777216;
	public const UriSyntaxFlags UnEscapeDotsAndSlashes = 33554432;
	public const UriSyntaxFlags AllowIdn = 67108864;
	public const UriSyntaxFlags AllowIriParsing = 268435456;
}

// Namespace: System
internal static class LocalAppContextSwitches
{
	// Fields
	public static readonly bool MemberDescriptorEqualsReturnsFalseIfEquivalent; // 0x0
}

// Namespace: System
internal enum IOOperation
{
	// Fields
	public int value__; // 0x10
	public const IOOperation Read = 1;
	public const IOOperation Write = 2;
}

// Namespace: System
internal sealed class IOAsyncCallback
{
	// Methods

	// RVA: 0x128C51C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x128C63C
	public virtual void Invoke(IOAsyncResult ioares) { }

}

// Namespace: System
internal abstract class IOAsyncResult
{
	// Fields
	private AsyncCallback async_callback; // 0x10
	private object async_state; // 0x18
	private ManualResetEvent wait_handle; // 0x20
	private bool completed_synchronously; // 0x28
	private bool completed; // 0x29

	// Methods

	// RVA: 0x128C650
	protected void .ctor() { }

	// RVA: 0x128C658
	protected void Init(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x128C6AC
	protected void .ctor(AsyncCallback async_callback, object async_state) { }

	// RVA: 0x128C6FC
	public AsyncCallback get_AsyncCallback() { }

	// RVA: 0x128C704
	public object get_AsyncState() { }

	// RVA: 0x128C70C
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x128C85C
	public bool get_CompletedSynchronously() { }

	// RVA: 0x128C864
	protected void set_CompletedSynchronously(bool value) { }

	// RVA: 0x128C86C
	public bool get_IsCompleted() { }

	// RVA: 0x128C874
	protected void set_IsCompleted(bool value) { }

	// RVA: -1
	internal abstract void CompleteDisposed() { }

}

// Namespace: System
internal class IOSelectorJob
{
	// Fields
	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20

	// Methods

	// RVA: 0x128C950
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x128C9A8
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x128C9D4
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x128C9D8
	public void MarkDisposed() { }

}

// Namespace: System
internal static class IOSelector
{
	// Methods

	// RVA: 0x128C9FC
	public static void Add(IntPtr handle, IOSelectorJob job) { }

}

// Namespace: System
internal class SRDescriptionAttribute
{
	// Fields
	private bool isReplaced; // 0x18

	// Methods

	// RVA: 0x128CA00
	public void .ctor(string description) { }

	// RVA: 0x128CA6C
	public override string get_Description() { }

}

// Namespace: System
public class UriTypeConverter
{
	// Methods

	// RVA: 0x128CACC
	public void .ctor() { }

	// RVA: 0x128CAD4
	private bool CanConvert(Type type) { }

	// RVA: 0x128CBBC
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x128CC98
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x128CD40
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x128CEF8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Web
public sealed class HttpUtility
{
	// Methods

	// RVA: 0x128D0F4
	public static string UrlEncode(string str) { }

	// RVA: 0x128D120
	public static string UrlEncode(string str, Encoding e) { }

	// RVA: 0x128D380
	public static Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Web.Util.HttpEncoder.<>c <>9; // 0x0

	// Methods

	// RVA: 0x128DD3C
	private static void .cctor() { }

	// RVA: 0x128DDA8
	public void .ctor() { }

	// RVA: 0x128DDB0
	internal HttpEncoder <.cctor>b__13_0() { }

}

// Namespace: System.Web.Util
public class HttpEncoder
{
	// Fields
	private static Char[] hexChars; // 0x0
	private static object entitiesLock; // 0x8
	private static System.Lazy<System.Web.Util.HttpEncoder> defaultEncoder; // 0x10
	private static System.Lazy<System.Web.Util.HttpEncoder> currentEncoderLazy; // 0x18
	private static HttpEncoder currentEncoder; // 0x20

	// Methods

	// RVA: 0x128D41C
	public static HttpEncoder get_Current() { }

	// RVA: 0x128D52C
	private static void .cctor() { }

	// RVA: 0x128D724
	public void .ctor() { }

	// RVA: 0x128D72C
	protected internal virtual Byte[] UrlEncode(Byte[] bytes, int offset, int count) { }

	// RVA: 0x128D9B4
	private static HttpEncoder GetCustomEncoderFromConfig() { }

	// RVA: 0x128D7A4
	internal static Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

	// RVA: 0x128D360
	internal static bool NotEncoded(Char c) { }

	// RVA: 0x128DA5C
	internal static void UrlEncodeChar(Char c, Stream result, bool isUnicode) { }

}

// Namespace: System.Text.RegularExpressions
public class Capture
{
	// Fields
	private int <Index>k__BackingField; // 0x10
	private int <Length>k__BackingField; // 0x14
	private string <Text>k__BackingField; // 0x18

	// Methods

	// RVA: 0x128DE08
	internal void .ctor(string text, int index, int length) { }

	// RVA: 0x128DE54
	public int get_Index() { }

	// RVA: 0x128DE5C
	internal void set_Index(int value) { }

	// RVA: 0x128DE64
	public int get_Length() { }

	// RVA: 0x128DE6C
	internal void set_Length(int value) { }

	// RVA: 0x128DE74
	internal string get_Text() { }

	// RVA: 0x128DE7C
	internal void set_Text(string value) { }

	// RVA: 0x128DE84
	public string get_Value() { }

	// RVA: 0x128DEAC
	public override string ToString() { }

	// RVA: 0x128DED4
	internal System.ReadOnlySpan<System.Char> GetLeftSubstring() { }

	// RVA: 0x128DF78
	internal System.ReadOnlySpan<System.Char> GetRightSubstring() { }

}

// Namespace: System.Text.RegularExpressions
public class CaptureCollection
{
	// Fields
	private readonly Group _group; // 0x10
	private readonly int _capcount; // 0x18
	private Capture[] _captures; // 0x20
}

// Namespace: System.Text.RegularExpressions
internal sealed class CollectionDebuggerProxy<T0>
{}

// Namespace: System.Text.RegularExpressions
[Serializable]
public class Group
{
	// Fields
	internal static readonly Group s_emptyGroup; // 0x0
	internal readonly int[] _caps; // 0x20
	internal int _capcount; // 0x28
	internal CaptureCollection _capcoll; // 0x30
	private readonly string <Name>k__BackingField; // 0x38

	// Methods

	// RVA: 0x128E01C
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x128E0E8
	public bool get_Success() { }

	// RVA: 0x128E0F8
	private static void .cctor() { }

	// RVA: 0x128E278
	internal void .ctor() { }

}

// Namespace: 
private sealed class Enumerator
{
	// Fields
	private readonly GroupCollection _collection; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x128E708
	internal void .ctor(GroupCollection collection) { }

	// RVA: 0x128F5CC
	public bool MoveNext() { }

	// RVA: 0x128F624
	public Group get_Current() { }

	// RVA: 0x128F6B4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x128F6B8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x128F6C4
	private void System.IDisposable.Dispose() { }

}

// Namespace: System.Text.RegularExpressions
[Serializable]
public class GroupCollection
{
	// Fields
	private readonly Match _match; // 0x10
	private readonly Hashtable _captureMap; // 0x18
	private Group[] _groups; // 0x20

	// Methods

	// RVA: 0x128E2B4
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x128E304
	public bool get_IsReadOnly() { }

	// RVA: 0x128E30C
	public int get_Count() { }

	// RVA: 0x128E334
	public Group get_Item(int groupnum) { }

	// RVA: 0x128E468
	public Group get_Item(string groupname) { }

	// RVA: 0x128E68C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x128E748
	private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	// RVA: 0x128E338
	private Group GetGroup(int groupnum) { }

	// RVA: 0x128E7C4
	private Group GetGroupImpl(int groupnum) { }

	// RVA: 0x128EB40
	public bool get_IsSynchronized() { }

	// RVA: 0x128EB48
	public object get_SyncRoot() { }

	// RVA: 0x128EB50
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x128EC24
	public void CopyTo(Group[] array, int arrayIndex) { }

	// RVA: 0x128EDEC
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	// RVA: 0x128EED0
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	// RVA: 0x128EF24
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	// RVA: 0x128EF78
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	// RVA: 0x128EF7C
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

	// RVA: 0x128EFD0
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	// RVA: 0x128F024
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	// RVA: 0x128F078
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	// RVA: 0x128F130
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	// RVA: 0x128F184
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x128F1D8
	private void System.Collections.IList.Clear() { }

	// RVA: 0x128F22C
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x128F330
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x128F434
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x128F488
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x128F490
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x128F4E4
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x128F538
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x128F53C
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x128F590
	internal void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
[Serializable]
public class Match
{
	// Fields
	internal GroupCollection _groupcoll; // 0x40
	internal Regex _regex; // 0x48
	internal int _textbeg; // 0x50
	internal int _textpos; // 0x54
	internal int _textend; // 0x58
	internal int _textstart; // 0x5C
	internal Int32[][] _matches; // 0x60
	internal int[] _matchcount; // 0x68
	internal bool _balancing; // 0x70
	private static readonly Match <Empty>k__BackingField; // 0x0

	// Methods

	// RVA: 0x128F6C8
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x128F87C
	public static Match get_Empty() { }

	// RVA: 0x128F8F8
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x128F980
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x128FA3C
	public Match NextMatch() { }

	// RVA: 0x128FD70
	internal virtual System.ReadOnlySpan<System.Char> GroupToStringImpl(int groupnum) { }

	// RVA: 0x128FF28
	internal System.ReadOnlySpan<System.Char> LastGroupToStringImpl() { }

	// RVA: 0x128FF54
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x1290154
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x1290234
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x1290270
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x1290308
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x12903A0
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x1290438
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x12905B4
	private static void .cctor() { }

	// RVA: 0x129065C
	internal void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal class MatchSparse
{
	// Fields
	internal readonly Hashtable _caps; // 0x78

	// Methods

	// RVA: 0x1290698
	internal void .ctor(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x1290754
	public override GroupCollection get_Groups() { }

}

// Namespace: 
[Serializable]
private sealed class Enumerator
{
	// Fields
	private readonly MatchCollection _collection; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x1290C34
	internal void .ctor(MatchCollection collection) { }

	// RVA: 0x12915D8
	public bool MoveNext() { }

	// RVA: 0x1291644
	public Match get_Current() { }

	// RVA: 0x12916B8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12916BC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x12916C8
	private void System.IDisposable.Dispose() { }

}

// Namespace: System.Text.RegularExpressions
[Serializable]
public class MatchCollection
{
	// Fields
	private readonly Regex _regex; // 0x10
	private readonly System.Collections.Generic.List<System.Text.RegularExpressions.Match> _matches; // 0x18
	private bool _done; // 0x20
	private readonly string _input; // 0x28
	private readonly int _beginning; // 0x30
	private readonly int _length; // 0x34
	private int _startat; // 0x38
	private int _prevlen; // 0x3C

	// Methods

	// RVA: 0x1290814
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x129096C
	public bool get_IsReadOnly() { }

	// RVA: 0x1290974
	public int get_Count() { }

	// RVA: 0x12909F8
	public virtual Match get_Item(int i) { }

	// RVA: 0x1290BB8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1290C74
	private System.Collections.Generic.IEnumerator<System.Text.RegularExpressions.Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }

	// RVA: 0x1290A64
	private Match GetMatch(int i) { }

	// RVA: 0x12909E4
	private void EnsureInitialized() { }

	// RVA: 0x1290CF0
	public bool get_IsSynchronized() { }

	// RVA: 0x1290CF8
	public object get_SyncRoot() { }

	// RVA: 0x1290CFC
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1290DDC
	public void CopyTo(Match[] array, int arrayIndex) { }

	// RVA: 0x1290E6C
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item) { }

	// RVA: 0x1290EF4
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item) { }

	// RVA: 0x1290F48
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }

	// RVA: 0x1290F9C
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index) { }

	// RVA: 0x1290FAC
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, Match value) { }

	// RVA: 0x1291000
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item) { }

	// RVA: 0x1291054
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }

	// RVA: 0x12910A8
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item) { }

	// RVA: 0x1291130
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item) { }

	// RVA: 0x1291184
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12911D8
	private void System.Collections.IList.Clear() { }

	// RVA: 0x129122C
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1291330
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1291434
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1291488
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1291490
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12914E4
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1291538
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1291548
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x129159C
	internal void .ctor() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class ExclusiveReference
{
	// Fields
	private RegexRunner _ref; // 0x10
	private RegexRunner _obj; // 0x18
	private int _locked; // 0x20

	// Methods

	// RVA: 0x12916CC
	public RegexRunner Get() { }

	// RVA: 0x129175C
	public void Release(RegexRunner obj) { }

	// RVA: 0x129186C
	public void .ctor() { }

}

// Namespace: 
internal struct CachedCodeEntryKey
{
	// Fields
	private readonly RegexOptions _options; // 0x10
	private readonly string _cultureKey; // 0x18
	private readonly string _pattern; // 0x20

	// Methods

	// RVA: 0x12943B8
	public void .ctor(RegexOptions options, string cultureKey, string pattern) { }

	// RVA: 0x129478C
	public override bool Equals(object obj) { }

	// RVA: 0x129484C
	public bool Equals(CachedCodeEntryKey other) { }

	// RVA: 0x12919C8
	public static bool op_Equality(CachedCodeEntryKey left, CachedCodeEntryKey right) { }

	// RVA: 0x12948B8
	public override int GetHashCode() { }

}

// Namespace: 
internal sealed class CachedCodeEntry
{
	// Fields
	public CachedCodeEntry Next; // 0x10
	public CachedCodeEntry Previous; // 0x18
	public readonly CachedCodeEntryKey Key; // 0x20
	public RegexCode Code; // 0x38
	public readonly Hashtable Caps; // 0x40
	public readonly Hashtable Capnames; // 0x48
	public readonly string[] Capslist; // 0x50
	public readonly int Capsize; // 0x58
	public readonly ExclusiveReference Runnerref; // 0x60
	public readonly System.WeakReference<System.Text.RegularExpressions.RegexReplacement> ReplRef; // 0x68

	// Methods

	// RVA: 0x129221C
	public void .ctor(CachedCodeEntryKey key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replref) { }

}

// Namespace: System.Text.RegularExpressions
public class Regex
{
	// Fields
	private const int CacheDictionarySwitchLimit = 10;
	private static int s_cacheSize; // 0x0
	private static readonly System.Collections.Generic.Dictionary<System.Text.RegularExpressions.Regex.CachedCodeEntryKey,System.Text.RegularExpressions.Regex.CachedCodeEntry> s_cache; // 0x8
	private static int s_cacheCount; // 0x10
	private static CachedCodeEntry s_cacheFirst; // 0x18
	private static CachedCodeEntry s_cacheLast; // 0x20
	private static readonly TimeSpan s_maximumMatchTimeout; // 0x28
	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";
	internal static readonly TimeSpan s_defaultMatchTimeout; // 0x30
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x38
	protected internal TimeSpan internalMatchTimeout; // 0x10
	internal const int MaxOptionShift = 10;
	protected internal string pattern; // 0x18
	protected internal RegexOptions roptions; // 0x20
	protected internal RegexRunnerFactory factory; // 0x28
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference _runnerref; // 0x50
	internal System.WeakReference<System.Text.RegularExpressions.RegexReplacement> _replref; // 0x58
	internal RegexCode _code; // 0x60
	internal bool _refsInitialized; // 0x68

	// Methods

	// RVA: 0x1291874
	private CachedCodeEntry GetCachedCode(CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x1291A3C
	private CachedCodeEntry GetCachedCodeEntryInternal(CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x12922FC
	private void FillCacheDictionary() { }

	// RVA: 0x1292414
	private static bool TryGetCacheValue(CachedCodeEntryKey key, CachedCodeEntry entry) { }

	// RVA: 0x129254C
	private static bool TryGetCacheValueSmall(CachedCodeEntryKey key, CachedCodeEntry entry) { }

	// RVA: 0x1291FA4
	private static CachedCodeEntry LookupCachedAndPromote(CachedCodeEntryKey key) { }

	// RVA: 0x12927AC
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x1292890
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1292C88
	public bool IsMatch(string input) { }

	// RVA: 0x1292D14
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x1292D9C
	public static Match Match(string input, string pattern) { }

	// RVA: 0x1292E80
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1292F10
	public Match Match(string input) { }

	// RVA: 0x1292F90
	public Match Match(string input, int startat) { }

	// RVA: 0x129300C
	public static MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x12930F0
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1293180
	public MatchCollection Matches(string input) { }

	// RVA: 0x1293200
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x12932D4
	public static string Replace(string input, string pattern, string replacement, RegexOptions options) { }

	// RVA: 0x12933CC
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x129346C
	public string Replace(string input, string replacement) { }

	// RVA: 0x12934F4
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x12935D0
	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	// RVA: 0x12936BC
	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x129375C
	public string Replace(string input, MatchEvaluator evaluator) { }

	// RVA: 0x12937E4
	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	// RVA: 0x12938B8
	private static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat) { }

	// RVA: 0x1293D08
	private static void .cctor() { }

	// RVA: 0x12940B8
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x1293E58
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x1294274
	public void .ctor(string pattern) { }

	// RVA: 0x12942F0
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x1294378
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x1292920
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	// RVA: 0x1294664
	public static string Escape(string str) { }

	// RVA: 0x1294720
	public RegexOptions get_Options() { }

	// RVA: 0x1293CFC
	public bool get_RightToLeft() { }

	// RVA: 0x1294728
	public override string ToString() { }

	// RVA: 0x128E9DC
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x128E520
	public int GroupNumberFromName(string name) { }

	// RVA: 0x1294550
	protected void InitializeReferences() { }

	// RVA: 0x128FA6C
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x1292D08
	protected internal bool UseOptionR() { }

	// RVA: 0x1294730
	internal bool UseOptionInvariant() { }

}

// Namespace: System.Text.RegularExpressions
public sealed class MatchEvaluator
{
	// Methods

	// RVA: 0x1294918
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1294A38
	public virtual string Invoke(Match match) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexBoyerMoore
{
	// Fields
	public readonly int[] Positive; // 0x10
	public readonly int[] NegativeASCII; // 0x18
	public readonly Int32[][] NegativeUnicode; // 0x20
	public readonly string Pattern; // 0x28
	public readonly int LowASCII; // 0x30
	public readonly int HighASCII; // 0x34
	public readonly bool RightToLeft; // 0x38
	public readonly bool CaseInsensitive; // 0x39
	private readonly CultureInfo _culture; // 0x40

	// Methods

	// RVA: 0x1294A4C
	public void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x1295058
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x12951D0
	public bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x1295240
	public int Scan(string text, int index, int beglimit, int endlimit) { }

}

// Namespace: 
private struct LowerCaseMapping
{
	// Fields
	public readonly Char ChMin; // 0x10
	public readonly Char ChMax; // 0x12
	public readonly int LcOp; // 0x14
	public readonly int Data; // 0x18

	// Methods

	// RVA: 0x129D2F0
	internal void .ctor(Char chMin, Char chMax, int lcOp, int data) { }

}

// Namespace: 
private sealed class SingleRangeComparer
{
	// Fields
	public static readonly SingleRangeComparer Instance; // 0x0

	// Methods

	// RVA: 0x129D300
	private void .ctor() { }

	// RVA: 0x129D308
	public int Compare(SingleRange x, SingleRange y) { }

	// RVA: 0x129D380
	private static void .cctor() { }

}

// Namespace: 
private struct SingleRange
{
	// Fields
	public readonly Char First; // 0x10
	public readonly Char Last; // 0x12

	// Methods

	// RVA: 0x1295CA4
	internal void .ctor(Char first, Char last) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexCharClass
{
	// Fields
	private static readonly string s_internalRegexIgnoreCase; // 0x0
	private static readonly string s_space; // 0x8
	private static readonly string s_notSpace; // 0x10
	private static readonly string s_word; // 0x18
	private static readonly string s_notWord; // 0x20
	public static readonly string SpaceClass; // 0x28
	public static readonly string NotSpaceClass; // 0x30
	public static readonly string WordClass; // 0x38
	public static readonly string NotWordClass; // 0x40
	public static readonly string DigitClass; // 0x48
	public static readonly string NotDigitClass; // 0x50
	private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_definedCategories; // 0x58
	private static readonly String[][] s_propTable; // 0x60
	private static readonly LowerCaseMapping[] s_lcTable; // 0x68
	private System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> _rangelist; // 0x10
	private StringBuilder _categories; // 0x18
	private bool _canonical; // 0x20
	private bool _negate; // 0x21
	private RegexCharClass _subtractor; // 0x28

	// Methods

	// RVA: 0x129553C
	public void .ctor() { }

	// RVA: 0x1295614
	private void .ctor(bool negate, System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x1295690
	public bool get_CanMerge() { }

	// RVA: 0x12956B0
	public void set_Negate(bool value) { }

	// RVA: 0x12956B8
	public void AddChar(Char c) { }

	// RVA: 0x1295794
	public void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x1295A98
	private void AddSet(string set) { }

	// RVA: 0x1295CB0
	public void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x12956C0
	public void AddRange(Char first, Char last) { }

	// RVA: 0x1295CB8
	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x1296220
	private void AddCategory(string category) { }

	// RVA: 0x1296240
	public void AddLowercase(CultureInfo culture) { }

	// RVA: 0x12963D0
	private void AddLowercaseRange(Char chMin, Char chMax, CultureInfo culture) { }

	// RVA: 0x1296680
	public void AddWord(bool ecma, bool negate) { }

	// RVA: 0x12967A4
	public void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x12968C8
	public void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x129698C
	public static Char SingletonChar(string set) { }

	// RVA: 0x12969A8
	public static bool IsMergeable(string charClass) { }

	// RVA: 0x1296B14
	public static bool IsEmpty(string charClass) { }

	// RVA: 0x1296C1C
	public static bool IsSingleton(string set) { }

	// RVA: 0x1296D5C
	public static bool IsSingletonInverse(string set) { }

	// RVA: 0x1296AB4
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x1296A8C
	private static bool IsNegated(string set) { }

	// RVA: 0x1296EA0
	public static bool IsECMAWordChar(Char ch) { }

	// RVA: 0x1296FF0
	public static bool IsWordChar(Char ch) { }

	// RVA: 0x1296F84
	public static bool CharInClass(Char ch, string set) { }

	// RVA: 0x12970CC
	private static bool CharInClassRecursive(Char ch, string set, int start) { }

	// RVA: 0x1297200
	private static bool CharInClassInternal(Char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x1297328
	private static bool CharInCategory(Char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x1297558
	private static bool CharInCategoryGroup(Char ch, UnicodeCategory chcategory, string category, int i) { }

	// RVA: 0x1295EFC
	private static string NegateCategory(string category) { }

	// RVA: 0x1297624
	public static RegexCharClass Parse(string charClass) { }

	// RVA: 0x12976AC
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x12959D4
	private int RangeCount() { }

	// RVA: 0x1297920
	public string ToStringClass() { }

	// RVA: 0x1295A20
	private SingleRange GetRangeAt(int i) { }

	// RVA: 0x1297AF4
	private void Canonicalize() { }

	// RVA: 0x1295FA8
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	// RVA: 0x1297D70
	private static void .cctor() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexCode
{
	// Fields
	public const int Onerep = 0;
	public const int Notonerep = 1;
	public const int Setrep = 2;
	public const int Oneloop = 3;
	public const int Notoneloop = 4;
	public const int Setloop = 5;
	public const int Onelazy = 6;
	public const int Notonelazy = 7;
	public const int Setlazy = 8;
	public const int One = 9;
	public const int Notone = 10;
	public const int Set = 11;
	public const int Multi = 12;
	public const int Ref = 13;
	public const int Bol = 14;
	public const int Eol = 15;
	public const int Boundary = 16;
	public const int Nonboundary = 17;
	public const int Beginning = 18;
	public const int Start = 19;
	public const int EndZ = 20;
	public const int End = 21;
	public const int Nothing = 22;
	public const int Lazybranch = 23;
	public const int Branchmark = 24;
	public const int Lazybranchmark = 25;
	public const int Nullcount = 26;
	public const int Setcount = 27;
	public const int Branchcount = 28;
	public const int Lazybranchcount = 29;
	public const int Nullmark = 30;
	public const int Setmark = 31;
	public const int Capturemark = 32;
	public const int Getmark = 33;
	public const int Setjump = 34;
	public const int Backjump = 35;
	public const int Forejump = 36;
	public const int Testref = 37;
	public const int Goto = 38;
	public const int Prune = 39;
	public const int Stop = 40;
	public const int ECMABoundary = 41;
	public const int NonECMABoundary = 42;
	public const int Mask = 63;
	public const int Rtl = 64;
	public const int Back = 128;
	public const int Back2 = 256;
	public const int Ci = 512;
	public readonly int[] Codes; // 0x10
	public readonly string[] Strings; // 0x18
	public readonly int TrackCount; // 0x20
	public readonly Hashtable Caps; // 0x28
	public readonly int CapSize; // 0x30
	public readonly System.Nullable<System.Text.RegularExpressions.RegexPrefix> FCPrefix; // 0x38
	public readonly RegexBoyerMoore BMPrefix; // 0x50
	public readonly int Anchors; // 0x58
	public readonly bool RightToLeft; // 0x5C

	// Methods

	// RVA: 0x129D3EC
	public void .ctor(int[] codes, System.Collections.Generic.List<System.String> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, System.Nullable<System.Text.RegularExpressions.RegexPrefix> fcPrefix, int anchors, bool rightToLeft) { }

	// RVA: 0x129D500
	public static bool OpcodeBacktracks(int Op) { }

}

// Namespace: System.Text.RegularExpressions
internal struct RegexFCD
{
	// Fields
	private readonly System.Collections.Generic.List<System.Text.RegularExpressions.RegexFC> _fcStack; // 0x10
	private System.Collections.Generic.ValueListBuilder<System.Int32> _intStack; // 0x18
	private bool _skipAllChildren; // 0x38
	private bool _skipchild; // 0x39
	private bool _failed; // 0x3A

	// Methods

	// RVA: 0x129D524
	private void .ctor(System.Span<System.Int32> intStack) { }

	// RVA: 0x129D604
	public static System.Nullable<System.Text.RegularExpressions.RegexPrefix> FirstChars(RegexTree t) { }

	// RVA: 0x129DBE0
	public static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x129DE54
	public static int Anchors(RegexTree tree) { }

	// RVA: 0x129E020
	private static int AnchorFromType(int type) { }

	// RVA: 0x129E088
	private void PushInt(int i) { }

	// RVA: 0x129E0F4
	private bool IntIsEmpty() { }

	// RVA: 0x129E13C
	private int PopInt() { }

	// RVA: 0x129E264
	private void PushFC(RegexFC fc) { }

	// RVA: 0x129E2C8
	private bool FCIsEmpty() { }

	// RVA: 0x129E31C
	private RegexFC PopFC() { }

	// RVA: 0x129E400
	private RegexFC TopFC() { }

	// RVA: 0x129DB50
	public void Dispose() { }

	// RVA: 0x129D954
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x129EA54
	private void SkipChild() { }

	// RVA: 0x129E47C
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexFC
{
	// Fields
	private RegexCharClass _cc; // 0x10
	public bool _nullable; // 0x18
	private bool <CaseInsensitive>k__BackingField; // 0x19

	// Methods

	// RVA: 0x129EA60
	public void .ctor(bool nullable) { }

	// RVA: 0x129EBA4
	public void .ctor(Char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x129ECA4
	public void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x129EAE0
	public bool AddFC(RegexFC fc, bool concatenate) { }

	// RVA: 0x129EDA8
	public bool get_CaseInsensitive() { }

	// RVA: 0x129EDB0
	private void set_CaseInsensitive(bool value) { }

	// RVA: 0x129DBA4
	public string GetFirstChars(CultureInfo culture) { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexInterpreter
{
	// Fields
	private readonly RegexCode _code; // 0x80
	private readonly CultureInfo _culture; // 0x88
	private int _operator; // 0x90
	private int _codepos; // 0x94
	private bool _rightToLeft; // 0x98
	private bool _caseInsensitive; // 0x99

	// Methods

	// RVA: 0x129473C
	public void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x129EDB8
	protected override void InitTrackCount() { }

	// RVA: 0x129EDDC
	private void Advance(int i) { }

	// RVA: 0x129EE64
	private void Goto(int newpos) { }

	// RVA: 0x129EEE4
	private void Textto(int newpos) { }

	// RVA: 0x129EEEC
	private void Trackto(int newpos) { }

	// RVA: 0x129EF14
	private int Textstart() { }

	// RVA: 0x129EF1C
	private int Textpos() { }

	// RVA: 0x129EF24
	private int Trackpos() { }

	// RVA: 0x129EF4C
	private void TrackPush() { }

	// RVA: 0x129EF90
	private void TrackPush(int I1) { }

	// RVA: 0x129EFF0
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x129F06C
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x129F104
	private void TrackPush2(int I1) { }

	// RVA: 0x129F168
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x129F1E8
	private void Backtrack() { }

	// RVA: 0x129EE44
	private void SetOperator(int op) { }

	// RVA: 0x129F2F0
	private void TrackPop() { }

	// RVA: 0x129F300
	private void TrackPop(int framesize) { }

	// RVA: 0x129F310
	private int TrackPeek() { }

	// RVA: 0x129F34C
	private int TrackPeek(int i) { }

	// RVA: 0x129F38C
	private void StackPush(int I1) { }

	// RVA: 0x129F3CC
	private void StackPush(int I1, int I2) { }

	// RVA: 0x129F428
	private void StackPop() { }

	// RVA: 0x129F438
	private void StackPop(int framesize) { }

	// RVA: 0x129F448
	private int StackPeek() { }

	// RVA: 0x129F484
	private int StackPeek(int i) { }

	// RVA: 0x129F4C4
	private int Operator() { }

	// RVA: 0x129F4CC
	private int Operand(int i) { }

	// RVA: 0x129F514
	private int Leftchars() { }

	// RVA: 0x129F524
	private int Rightchars() { }

	// RVA: 0x129F534
	private int Bump() { }

	// RVA: 0x129F548
	private int Forwardchars() { }

	// RVA: 0x129F574
	private Char Forwardcharnext() { }

	// RVA: 0x129F608
	private bool Stringmatch(string str) { }

	// RVA: 0x129F77C
	private bool Refmatch(int index, int len) { }

	// RVA: 0x129F924
	private void Backwardnext() { }

	// RVA: 0x129F954
	private Char CharAt(int j) { }

	// RVA: 0x129F974
	protected override bool FindFirstChar() { }

	// RVA: 0x129FF18
	protected override void Go() { }

}

// Namespace: System.Text.RegularExpressions
[Serializable]
public class RegexMatchTimeoutException
{
	// Fields
	private readonly string <Input>k__BackingField; // 0x90
	private readonly string <Pattern>k__BackingField; // 0x98
	private readonly TimeSpan <MatchTimeout>k__BackingField; // 0xA0

	// Methods

	// RVA: 0x12A2320
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x12A243C
	public void .ctor() { }

	// RVA: 0x12A24F4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A2678
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12A2780
	public string get_Input() { }

	// RVA: 0x12A2788
	public string get_Pattern() { }

	// RVA: 0x12A2790
	public TimeSpan get_MatchTimeout() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexNode
{
	// Fields
	public int NType; // 0x10
	public System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode> Children; // 0x18
	public string Str; // 0x20
	public Char Ch; // 0x28
	public int M; // 0x2C
	public int N; // 0x30
	public readonly RegexOptions Options; // 0x34
	public RegexNode Next; // 0x38

	// Methods

	// RVA: 0x12A2798
	public void .ctor(int type, RegexOptions options) { }

	// RVA: 0x12A27D4
	public void .ctor(int type, RegexOptions options, Char ch) { }

	// RVA: 0x12A2818
	public void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x12A2864
	public void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x12A28A8
	public void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x12A28F8
	public bool UseOptionR() { }

	// RVA: 0x12A2904
	public RegexNode ReverseLeft() { }

	// RVA: 0x12A2984
	private void MakeRep(int type, int min, int max) { }

	// RVA: 0x12A299C
	private RegexNode Reduce() { }

	// RVA: 0x12A36DC
	private RegexNode StripEnation(int emptyType) { }

	// RVA: 0x12A34A4
	private RegexNode ReduceGroup() { }

	// RVA: 0x12A32D8
	private RegexNode ReduceRep() { }

	// RVA: 0x12A352C
	private RegexNode ReduceSet() { }

	// RVA: 0x12A2A98
	private RegexNode ReduceAlternation() { }

	// RVA: 0x12A2EDC
	private RegexNode ReduceConcatenation() { }

	// RVA: 0x12A38D8
	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x12A3A34
	public void AddChild(RegexNode newChild) { }

	// RVA: 0x12A3860
	public RegexNode Child(int i) { }

	// RVA: 0x12A3808
	public int ChildCount() { }

	// RVA: 0x12A3B2C
	public int Type() { }

}

// Namespace: System.Text.RegularExpressions
public enum RegexOptions
{
	// Fields
	public int value__; // 0x10
	public const RegexOptions None = 0;
	public const RegexOptions IgnoreCase = 1;
	public const RegexOptions Multiline = 2;
	public const RegexOptions ExplicitCapture = 4;
	public const RegexOptions Compiled = 8;
	public const RegexOptions Singleline = 16;
	public const RegexOptions IgnorePatternWhitespace = 32;
	public const RegexOptions RightToLeft = 64;
	public const RegexOptions ECMAScript = 256;
	public const RegexOptions CultureInvariant = 512;
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexParser
{
	// Fields
	private RegexNode _stack; // 0x10
	private RegexNode _group; // 0x18
	private RegexNode _alternation; // 0x20
	private RegexNode _concatenation; // 0x28
	private RegexNode _unit; // 0x30
	private string _pattern; // 0x38
	private int _currentPos; // 0x40
	private CultureInfo _culture; // 0x48
	private int _autocap; // 0x50
	private int _capcount; // 0x54
	private int _captop; // 0x58
	private int _capsize; // 0x5C
	private Hashtable _caps; // 0x60
	private Hashtable _capnames; // 0x68
	private int[] _capnumlist; // 0x70
	private System.Collections.Generic.List<System.String> _capnamelist; // 0x78
	private RegexOptions _options; // 0x80
	private System.Collections.Generic.List<System.Text.RegularExpressions.RegexOptions> _optionsStack; // 0x88
	private bool _ignoreNextParen; // 0x90
	private static readonly Byte[] s_category; // 0x0

	// Methods

	// RVA: 0x12A3B34
	public static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x12A51EC
	public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x12A5958
	public static string Escape(string input) { }

	// RVA: 0x12A3D94
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x12A3E74
	private void SetPattern(string Re) { }

	// RVA: 0x12A42F0
	private void Reset(RegexOptions topopts) { }

	// RVA: 0x12A4390
	private RegexNode ScanRegex() { }

	// RVA: 0x12A53B4
	private RegexNode ScanReplacement() { }

	// RVA: 0x12A6838
	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x12A6F64
	private RegexNode ScanGroupOpen() { }

	// RVA: 0x12A5D80
	private void ScanBlank() { }

	// RVA: 0x12A7FAC
	private RegexNode ScanBackslash(bool scanOnly) { }

	// RVA: 0x12A97FC
	private RegexNode ScanBasicBackslash(bool scanOnly) { }

	// RVA: 0x12A88CC
	private RegexNode ScanDollar() { }

	// RVA: 0x12A92D4
	private string ScanCapname() { }

	// RVA: 0x12A9F2C
	private Char ScanOctal() { }

	// RVA: 0x12A87AC
	private int ScanDecimal() { }

	// RVA: 0x12AA03C
	private Char ScanHex(int c) { }

	// RVA: 0x12AA194
	private static int HexDigit(Char ch) { }

	// RVA: 0x12AA1C4
	private Char ScanControl() { }

	// RVA: 0x12AA278
	private bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x12A9560
	private void ScanOptions() { }

	// RVA: 0x12A8F8C
	private Char ScanCharEscape() { }

	// RVA: 0x12A8DFC
	private string ParseProperty() { }

	// RVA: 0x12A976C
	private int TypeFromCode(Char ch) { }

	// RVA: 0x12AA298
	private static RegexOptions OptionFromCode(Char ch) { }

	// RVA: 0x12A3EE8
	private void CountCaptures() { }

	// RVA: 0x12AA2F8
	private void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x12AA454
	private void NoteCaptureName(string name, int pos) { }

	// RVA: 0x12A5370
	private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x12AA5C8
	private void AssignNameSlots() { }

	// RVA: 0x12A94C8
	private int CaptureSlotFromName(string capname) { }

	// RVA: 0x12A93E8
	private bool IsCaptureSlot(int i) { }

	// RVA: 0x12A94AC
	private bool IsCaptureName(string capname) { }

	// RVA: 0x12A93DC
	private bool UseOptionN() { }

	// RVA: 0x12A682C
	private bool UseOptionI() { }

	// RVA: 0x12A85E0
	private bool UseOptionM() { }

	// RVA: 0x12A8668
	private bool UseOptionS() { }

	// RVA: 0x12A60EC
	private bool UseOptionX() { }

	// RVA: 0x12A8DF0
	private bool UseOptionE() { }

	// RVA: 0x12A63C8
	private static bool IsSpecial(Char ch) { }

	// RVA: 0x12A6158
	private static bool IsStopperX(Char ch) { }

	// RVA: 0x12A6468
	private static bool IsQuantifier(Char ch) { }

	// RVA: 0x12A61F8
	private bool IsTrueQuantifier() { }

	// RVA: 0x12A96CC
	private static bool IsSpace(Char ch) { }

	// RVA: 0x12A5C1C
	private static bool IsMetachar(Char ch) { }

	// RVA: 0x12A6508
	private void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x12A7920
	private void PushGroup() { }

	// RVA: 0x12A7DC4
	private void PopGroup() { }

	// RVA: 0x12A7B14
	private bool EmptyStack() { }

	// RVA: 0x12A5CBC
	private void StartGroup(RegexNode openGroup) { }

	// RVA: 0x12A798C
	private void AddAlternate() { }

	// RVA: 0x12A8740
	private void AddConcatenate() { }

	// RVA: 0x12A8880
	private void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x12AACB4
	private RegexNode Unit() { }

	// RVA: 0x12A6770
	private void AddUnitOne(Char ch) { }

	// RVA: 0x12A8674
	private void AddUnitNotone(Char ch) { }

	// RVA: 0x12A6E68
	private void AddUnitSet(string cc) { }

	// RVA: 0x12AACBC
	private void AddUnitNode(RegexNode node) { }

	// RVA: 0x12A85EC
	private void AddUnitType(int type) { }

	// RVA: 0x12A7BC4
	private void AddGroup() { }

	// RVA: 0x12A6EF8
	private void PushOptions() { }

	// RVA: 0x12A7F00
	private void PopOptions() { }

	// RVA: 0x12AA400
	private bool EmptyOptionsStack() { }

	// RVA: 0x12A78B8
	private void PopKeepOptions() { }

	// RVA: 0x12A7B24
	private ArgumentException MakeException(string message) { }

	// RVA: 0x12AACC4
	private int Textpos() { }

	// RVA: 0x12AACCC
	private void Textto(int pos) { }

	// RVA: 0x12A877C
	private Char RightCharMoveRight() { }

	// RVA: 0x12A60F8
	private void MoveRight() { }

	// RVA: 0x12A93CC
	private void MoveRight(int i) { }

	// RVA: 0x12A8730
	private void MoveLeft() { }

	// RVA: 0x12A6750
	private Char CharAt(int i) { }

	// RVA: 0x12A6130
	internal Char RightChar() { }

	// RVA: 0x12A93A0
	private Char RightChar(int i) { }

	// RVA: 0x12A6108
	private int CharsRight() { }

	// RVA: 0x12AACD4
	private static void .cctor() { }

}

// Namespace: System.Text.RegularExpressions
internal struct RegexPrefix
{
	// Fields
	private readonly bool <CaseInsensitive>k__BackingField; // 0x10
	private static readonly RegexPrefix <Empty>k__BackingField; // 0x0
	private readonly string <Prefix>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12AAD78
	internal void .ctor(string prefix, bool ci) { }

	// RVA: 0x12AADA4
	internal bool get_CaseInsensitive() { }

	// RVA: 0x12AADAC
	internal static RegexPrefix get_Empty() { }

	// RVA: 0x12AAE28
	internal string get_Prefix() { }

	// RVA: 0x12AAE30
	private static void .cctor() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexReplacement
{
	// Fields
	private const int Specials = 4;
	public const int LeftPortion = 4294967295;
	public const int RightPortion = 4294967294;
	public const int LastGroup = 4294967293;
	public const int WholeString = 4294967292;
	private readonly System.Collections.Generic.List<System.String> _strings; // 0x10
	private readonly System.Collections.Generic.List<System.Int32> _rules; // 0x18
	private readonly string <Pattern>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12A5544
	public void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x12AAED8
	public static RegexReplacement GetOrCreate(System.WeakReference<System.Text.RegularExpressions.RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) { }

	// RVA: 0x12AAFF8
	public string get_Pattern() { }

	// RVA: 0x12AB000
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x12AB1BC
	private void ReplacementImplRTL(System.Collections.Generic.List<System.String> al, Match match) { }

	// RVA: 0x12AB3D4
	public string Replace(Regex regex, string input, int count, int startat) { }

}

// Namespace: System.Text.RegularExpressions
public abstract class RegexRunner
{
	// Fields
	protected internal int runtextbeg; // 0x10
	protected internal int runtextend; // 0x14
	protected internal int runtextstart; // 0x18
	protected internal string runtext; // 0x20
	protected internal int runtextpos; // 0x28
	protected internal int[] runtrack; // 0x30
	protected internal int runtrackpos; // 0x38
	protected internal int[] runstack; // 0x40
	protected internal int runstackpos; // 0x48
	protected internal int[] runcrawl; // 0x50
	protected internal int runcrawlpos; // 0x58
	protected internal int runtrackcount; // 0x5C
	protected internal Match runmatch; // 0x60
	protected internal Regex runregex; // 0x68
	private int _timeout; // 0x70
	private bool _ignoreTimeout; // 0x74
	private int _timeoutOccursAt; // 0x78
	private const int TimeoutCheckFrequency = 1000;
	private int _timeoutChecksToSkip; // 0x7C

	// Methods

	// RVA: 0x12AB794
	protected internal void .ctor() { }

	// RVA: 0x12AB79C
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x12ABB94
	private void StartTimeoutWatch() { }

	// RVA: 0x12ABBE0
	protected void CheckTimeout() { }

	// RVA: 0x12ABE98
	private void DoCheckTimeout() { }

	// RVA: -1
	protected abstract void Go() { }

	// RVA: -1
	protected abstract bool FindFirstChar() { }

	// RVA: -1
	protected abstract void InitTrackCount() { }

	// RVA: 0x12ABBF0
	private void InitMatch() { }

	// RVA: 0x12ABE30
	private Match TidyMatch(bool quick) { }

	// RVA: 0x12ABF74
	protected void EnsureStorage() { }

	// RVA: 0x12AC138
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x12AC23C
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x12AC084
	protected void DoubleTrack() { }

	// RVA: 0x12ABFD0
	protected void DoubleStack() { }

	// RVA: 0x12AC340
	protected void DoubleCrawl() { }

	// RVA: 0x12AC3F4
	protected void Crawl(int i) { }

	// RVA: 0x12AC454
	protected int Popcrawl() { }

	// RVA: 0x12AC494
	protected int Crawlpos() { }

	// RVA: 0x12AC4BC
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x12AC550
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x12AC700
	protected void Uncapture() { }

	// RVA: 0x12AC750
	protected bool IsMatched(int cap) { }

	// RVA: 0x12AC6B8
	protected int MatchIndex(int cap) { }

	// RVA: 0x12AC6DC
	protected int MatchLength(int cap) { }

}

// Namespace: System.Text.RegularExpressions
public abstract class RegexRunnerFactory
{
	// Methods

	// RVA: -1
	protected internal abstract RegexRunner CreateInstance() { }

}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexTree
{
	// Fields
	public readonly RegexNode Root; // 0x10
	public readonly Hashtable Caps; // 0x18
	public readonly int[] CapNumList; // 0x20
	public readonly int CapTop; // 0x28
	public readonly Hashtable CapNames; // 0x30
	public readonly string[] CapsList; // 0x38
	public readonly RegexOptions Options; // 0x40

	// Methods

	// RVA: 0x12A513C
	internal void .ctor(RegexNode root, Hashtable caps, int[] capNumList, int capTop, Hashtable capNames, string[] capsList, RegexOptions options) { }

}

// Namespace: System.Text.RegularExpressions
internal struct RegexWriter
{
	// Fields
	private System.Collections.Generic.ValueListBuilder<System.Int32> _emitted; // 0x10
	private System.Collections.Generic.ValueListBuilder<System.Int32> _intStack; // 0x30
	private readonly System.Collections.Generic.Dictionary<System.String,System.Int32> _stringHash; // 0x50
	private readonly System.Collections.Generic.List<System.String> _stringTable; // 0x58
	private Hashtable _caps; // 0x60
	private int _trackCount; // 0x68

	// Methods

	// RVA: 0x12AC774
	private void .ctor(System.Span<System.Int32> emittedSpan, System.Span<System.Int32> intStackSpan) { }

	// RVA: 0x12AC8BC
	public static RegexCode Write(RegexTree tree) { }

	// RVA: 0x12AD17C
	public void Dispose() { }

	// RVA: 0x12ACB70
	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x12ADD7C
	private void PatchJump(int offset, int jumpDest) { }

	// RVA: 0x12ADDEC
	private void Emit(int op) { }

	// RVA: 0x12AD1DC
	private void Emit(int op, int opd1) { }

	// RVA: 0x12ADE74
	private void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x12ADF34
	private int StringCode(string str) { }

	// RVA: 0x12AE060
	private int MapCapnum(int capnum) { }

	// RVA: 0x12AD27C
	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }

}

// Namespace: System.CodeDom.Compiler
public sealed class GeneratedCodeAttribute
{
	// Fields
	private readonly string tool; // 0x10
	private readonly string version; // 0x18

	// Methods

	// RVA: 0x12AE120
	public void .ctor(string tool, string version) { }

}

// Namespace: System.Diagnostics
public class BooleanSwitch
{
	// Methods

	// RVA: 0x12AE170
	public void .ctor(string displayName, string description) { }

}

// Namespace: System.Diagnostics
public abstract class Switch
{
	// Fields
	private readonly string description; // 0x10
	private readonly string displayName; // 0x18
	private string switchValueString; // 0x20
	private string defaultValue; // 0x28
	private static System.Collections.Generic.List<System.WeakReference> switches; // 0x0
	private static int s_LastCollectionCount; // 0x8

	// Methods

	// RVA: 0x12AE238
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x12AE2A4
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x12AE4DC
	private static void _pruneCachedSwitches() { }

	// RVA: 0x12AE9C8
	private static void .cctor() { }

}

// Namespace: System.Diagnostics
public sealed class SwitchLevelAttribute
{
	// Fields
	private Type type; // 0x10

	// Methods

	// RVA: 0x12AEA64
	public void .ctor(Type switchLevelType) { }

	// RVA: 0x12AEA94
	public void set_SwitchLevelType(Type value) { }

}

// Namespace: System.Diagnostics
public enum TraceLevel
{
	// Fields
	public int value__; // 0x10
	public const TraceLevel Off = 0;
	public const TraceLevel Error = 1;
	public const TraceLevel Warning = 2;
	public const TraceLevel Info = 3;
	public const TraceLevel Verbose = 4;
}

// Namespace: System.Diagnostics
public class TraceSwitch
{
	// Methods

	// RVA: 0x12AEB7C
	public void .ctor(string displayName, string description) { }

}

// Namespace: System.Diagnostics
public class Stopwatch
{
	// Fields
	public static readonly Int64 Frequency; // 0x0
	public static readonly bool IsHighResolution; // 0x8
	private Int64 elapsed; // 0x10
	private Int64 started; // 0x18
	private bool is_running; // 0x20

	// Methods

	// RVA: 0x12AEC44
	public static Int64 GetTimestamp() { }

	// RVA: 0x12AEC48
	public static Stopwatch StartNew() { }

	// RVA: 0x12AED14
	public void .ctor() { }

	// RVA: 0x12AED9C
	public TimeSpan get_Elapsed() { }

	// RVA: 0x12AEFC8
	public Int64 get_ElapsedMilliseconds() { }

	// RVA: 0x12AEF4C
	public Int64 get_ElapsedTicks() { }

	// RVA: 0x12AF184
	public bool get_IsRunning() { }

	// RVA: 0x12AF18C
	public void Reset() { }

	// RVA: 0x12AED1C
	public void Start() { }

	// RVA: 0x12AF198
	public void Stop() { }

	// RVA: 0x12AF214
	public void Restart() { }

	// RVA: 0x12AF280
	private static void .cctor() { }

}

// Namespace: System.Diagnostics.CodeAnalysis
public sealed class ExcludeFromCodeCoverageAttribute
{
	// Methods

	// RVA: 0x12AF2DC
	public void .ctor() { }

}

// Namespace: System.Security.Authentication
[Serializable]
public class AuthenticationException
{
	// Methods

	// RVA: 0x12AF2E4
	public void .ctor() { }

	// RVA: 0x12AF348
	public void .ctor(string message) { }

	// RVA: 0x12AF350
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12AF358
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Namespace: System.Security.Authentication
public enum SslProtocols
{
	// Fields
	public int value__; // 0x10
	public const SslProtocols None = 0;
	public const SslProtocols Ssl2 = 12;
	public const SslProtocols Ssl3 = 48;
	public const SslProtocols Tls = 192;
	public const SslProtocols Tls11 = 768;
	public const SslProtocols Tls12 = 3072;
	public const SslProtocols Tls13 = 12288;
	public const SslProtocols Default = 240;
}

// Namespace: 
internal enum DerTag
{
	// Fields
	public Byte value__; // 0x10
	public const DerTag Boolean = 1;
	public const DerTag Integer = 2;
	public const DerTag BitString = 3;
	public const DerTag OctetString = 4;
	public const DerTag Null = 5;
	public const DerTag ObjectIdentifier = 6;
	public const DerTag UTF8String = 12;
	public const DerTag Sequence = 16;
	public const DerTag Set = 17;
	public const DerTag PrintableString = 19;
	public const DerTag T61String = 20;
	public const DerTag IA5String = 22;
	public const DerTag UTCTime = 23;
	public const DerTag GeneralizedTime = 24;
	public const DerTag BMPString = 30;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Security.Cryptography.DerSequenceReader.<>c <>9; // 0x0
	public static System.Func<System.Text.Encoding> <>9__45_0; // 0x8
	public static System.Func<System.Text.Encoding> <>9__45_1; // 0x10
	public static System.Func<System.Globalization.DateTimeFormatInfo> <>9__51_0; // 0x18

	// Methods

	// RVA: 0x12B0E68
	private static void .cctor() { }

	// RVA: 0x12B0ED4
	public void .ctor() { }

	// RVA: 0x12B0EDC
	internal Encoding <ReadT61String>b__45_0() { }

	// RVA: 0x12B0F3C
	internal Encoding <ReadT61String>b__45_1() { }

	// RVA: 0x12B0F84
	internal DateTimeFormatInfo <ReadTime>b__51_0() { }

}

// Namespace: System.Security.Cryptography
internal class DerSequenceReader
{
	// Fields
	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo; // 0x0
	private static Encoding s_utf8EncodingWithExceptionFallback; // 0x8
	private static Encoding s_latin1Encoding; // 0x10
	private readonly Byte[] _data; // 0x10
	private readonly int _end; // 0x18
	private int _position; // 0x1C
	private int <ContentLength>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12AF360
	private void set_ContentLength(int value) { }

	// RVA: 0x12AF368
	internal void .ctor(Byte[] data) { }

	// RVA: 0x12AF390
	internal void .ctor(Byte[] data, int offset, int length) { }

	// RVA: 0x12AF3A4
	private void .ctor(DerTag tagToEat, Byte[] data, int offset, int length) { }

	// RVA: 0x12AF584
	internal bool get_HasData() { }

	// RVA: 0x12AF594
	internal Byte PeekTag() { }

	// RVA: 0x12AF634
	internal void SkipValue() { }

	// RVA: 0x12AF690
	internal Byte[] ReadNextEncodedValue() { }

	// RVA: 0x12AF880
	internal bool ReadBoolean() { }

	// RVA: 0x12AF954
	internal int ReadInteger() { }

	// RVA: 0x12AFA00
	internal Byte[] ReadIntegerBytes() { }

	// RVA: 0x12AFB78
	internal Byte[] ReadBitString() { }

	// RVA: 0x12AFCC0
	internal Byte[] ReadOctetString() { }

	// RVA: 0x12AFD80
	internal string ReadOidAsString() { }

	// RVA: 0x12B0074
	internal string ReadUtf8String() { }

	// RVA: 0x12B0200
	private DerSequenceReader ReadCollectionWithTag(DerTag expected) { }

	// RVA: 0x12B036C
	internal DerSequenceReader ReadSequence() { }

	// RVA: 0x12B0374
	internal DerSequenceReader ReadSet() { }

	// RVA: 0x12B037C
	internal string ReadPrintableString() { }

	// RVA: 0x12B0484
	internal string ReadIA5String() { }

	// RVA: 0x12B058C
	internal string ReadT61String() { }

	// RVA: 0x12B098C
	internal DateTime ReadX509Date() { }

	// RVA: 0x12B0A6C
	internal DateTime ReadUtcTime() { }

	// RVA: 0x12B0AC4
	internal DateTime ReadGeneralizedTime() { }

	// RVA: 0x12B0D60
	internal string ReadBMPString() { }

	// RVA: 0x12B017C
	private static string TrimTrailingNulls(string value) { }

	// RVA: 0x12B0B1C
	private DateTime ReadTime(DerTag timeTag, string formatString) { }

	// RVA: 0x12AFAC0
	private Byte[] ReadContentAsBytes() { }

	// RVA: 0x12AF4B0
	private void EatTag(DerTag expected) { }

	// RVA: 0x12B02CC
	private static void CheckTag(DerTag expected, Byte[] data, int position) { }

	// RVA: 0x12AF53C
	private int EatLength() { }

	// RVA: 0x12AF74C
	private static int ScanContentLength(Byte[] data, int offset, int end, int bytesConsumed) { }

}

// Namespace: System.Security.Cryptography
public sealed class Oid
{
	// Fields
	private string _value; // 0x10
	private string _friendlyName; // 0x18
	private OidGroup _group; // 0x20

	// Methods

	// RVA: 0x12B1070
	public void .ctor() { }

	// RVA: 0x12B1078
	public void .ctor(string oid) { }

	// RVA: 0x12B1110
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x12B1160
	public void .ctor(Oid oid) { }

	// RVA: 0x12B11FC
	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	// RVA: 0x12B13B8
	public string get_Value() { }

	// RVA: 0x12B13C0
	public void set_Value(string value) { }

	// RVA: 0x12B13C8
	public string get_FriendlyName() { }

	// RVA: 0x12B135C
	private void .ctor(string value, string friendlyName, OidGroup group) { }

}

// Namespace: System.Security.Cryptography
public sealed class OidCollection
{
	// Fields
	private readonly System.Collections.Generic.List<System.Security.Cryptography.Oid> _list; // 0x10

	// Methods

	// RVA: 0x12B1494
	public void .ctor() { }

	// RVA: 0x12B1520
	public int Add(Oid oid) { }

	// RVA: 0x12B159C
	public Oid get_Item(int index) { }

	// RVA: 0x12B1614
	public int get_Count() { }

	// RVA: 0x12B1660
	public OidEnumerator GetEnumerator() { }

	// RVA: 0x12B171C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12B1798
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12B19F8
	public bool get_IsSynchronized() { }

	// RVA: 0x12B1A00
	public object get_SyncRoot() { }

}

// Namespace: System.Security.Cryptography
public sealed class OidEnumerator
{
	// Fields
	private readonly OidCollection _oids; // 0x10
	private int _current; // 0x18

	// Methods

	// RVA: 0x12B16DC
	internal void .ctor(OidCollection oids) { }

	// RVA: 0x12B1A04
	public Oid get_Current() { }

	// RVA: 0x12B1A80
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12B1AFC
	public bool MoveNext() { }

	// RVA: 0x12B1B7C
	public void Reset() { }

}

// Namespace: System.Security.Cryptography
public enum OidGroup
{
	// Fields
	public int value__; // 0x10
	public const OidGroup All = 0;
	public const OidGroup HashAlgorithm = 1;
	public const OidGroup EncryptionAlgorithm = 2;
	public const OidGroup PublicKeyAlgorithm = 3;
	public const OidGroup SignatureAlgorithm = 4;
	public const OidGroup Attribute = 5;
	public const OidGroup ExtensionOrAttribute = 6;
	public const OidGroup EnhancedKeyUsage = 7;
	public const OidGroup Policy = 8;
	public const OidGroup Template = 9;
	public const OidGroup KeyDerivationFunction = 10;
}

// Namespace: System.Security.Cryptography
internal enum AsnDecodeStatus
{
	// Fields
	public int value__; // 0x10
	public const AsnDecodeStatus NotDecoded = 4294967295;
	public const AsnDecodeStatus Ok = 0;
	public const AsnDecodeStatus BadAsn = 1;
	public const AsnDecodeStatus BadTag = 2;
	public const AsnDecodeStatus BadLength = 3;
	public const AsnDecodeStatus InformationNotAvailable = 4;
}

// Namespace: System.Security.Cryptography
public class AsnEncodedData
{
	// Fields
	internal Oid _oid; // 0x10
	internal Byte[] _raw; // 0x18

	// Methods

	// RVA: 0x12B1B88
	protected void .ctor() { }

	// RVA: 0x12B1B90
	public void .ctor(string oid, Byte[] rawData) { }

	// RVA: 0x12B1D94
	public void .ctor(Oid oid, Byte[] rawData) { }

	// RVA: 0x12B1EE8
	public void .ctor(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12B203C
	public Oid get_Oid() { }

	// RVA: 0x12B1E58
	public void set_Oid(Oid value) { }

	// RVA: 0x12B2044
	public Byte[] get_RawData() { }

	// RVA: 0x12B1C8C
	public void set_RawData(Byte[] value) { }

	// RVA: 0x12B204C
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12B21B4
	public virtual string Format(bool multiLine) { }

	// RVA: 0x12B2394
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x12B2258
	internal string Default(bool multiLine) { }

	// RVA: 0x12B2568
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x12B268C
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x12B27B4
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x12B28DC
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x12B2A04
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x12B2DF0
	internal string NetscapeCertType(bool multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public enum OpenFlags
{
	// Fields
	public int value__; // 0x10
	public const OpenFlags ReadOnly = 0;
	public const OpenFlags ReadWrite = 1;
	public const OpenFlags MaxAllowed = 2;
	public const OpenFlags OpenExistingOnly = 4;
	public const OpenFlags IncludeArchived = 8;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum StoreLocation
{
	// Fields
	public int value__; // 0x10
	public const StoreLocation CurrentUser = 1;
	public const StoreLocation LocalMachine = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum StoreName
{
	// Fields
	public int value__; // 0x10
	public const StoreName AddressBook = 1;
	public const StoreName AuthRoot = 2;
	public const StoreName CertificateAuthority = 3;
	public const StoreName Disallowed = 4;
	public const StoreName My = 5;
	public const StoreName Root = 6;
	public const StoreName TrustedPeople = 7;
	public const StoreName TrustedPublisher = 8;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X500DistinguishedNameFlags
{
	// Fields
	public int value__; // 0x10
	public const X500DistinguishedNameFlags None = 0;
	public const X500DistinguishedNameFlags Reversed = 1;
	public const X500DistinguishedNameFlags UseSemicolons = 16;
	public const X500DistinguishedNameFlags DoNotUsePlusSign = 32;
	public const X500DistinguishedNameFlags DoNotUseQuotes = 64;
	public const X500DistinguishedNameFlags UseCommas = 128;
	public const X500DistinguishedNameFlags UseNewLines = 256;
	public const X500DistinguishedNameFlags UseUTF8Encoding = 4096;
	public const X500DistinguishedNameFlags UseT61Encoding = 8192;
	public const X500DistinguishedNameFlags ForceUTF8Encoding = 16384;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509ChainStatusFlags
{
	// Fields
	public int value__; // 0x10
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags Revoked = 4;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotValidForUsage = 16;
	public const X509ChainStatusFlags UntrustedRoot = 32;
	public const X509ChainStatusFlags RevocationStatusUnknown = 64;
	public const X509ChainStatusFlags Cyclic = 128;
	public const X509ChainStatusFlags InvalidExtension = 256;
	public const X509ChainStatusFlags InvalidPolicyConstraints = 512;
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags InvalidNameConstraints = 2048;
	public const X509ChainStatusFlags HasNotSupportedNameConstraint = 4096;
	public const X509ChainStatusFlags HasNotDefinedNameConstraint = 8192;
	public const X509ChainStatusFlags HasNotPermittedNameConstraint = 16384;
	public const X509ChainStatusFlags HasExcludedNameConstraint = 32768;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags CtlNotTimeValid = 131072;
	public const X509ChainStatusFlags CtlNotSignatureValid = 262144;
	public const X509ChainStatusFlags CtlNotValidForUsage = 524288;
	public const X509ChainStatusFlags OfflineRevocation = 16777216;
	public const X509ChainStatusFlags NoIssuanceChainPolicy = 33554432;
	public const X509ChainStatusFlags ExplicitDistrust = 67108864;
	public const X509ChainStatusFlags HasNotSupportedCriticalExtension = 134217728;
	public const X509ChainStatusFlags HasWeakSignature = 1048576;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509FindType
{
	// Fields
	public int value__; // 0x10
	public const X509FindType FindByThumbprint = 0;
	public const X509FindType FindBySubjectName = 1;
	public const X509FindType FindBySubjectDistinguishedName = 2;
	public const X509FindType FindByIssuerName = 3;
	public const X509FindType FindByIssuerDistinguishedName = 4;
	public const X509FindType FindBySerialNumber = 5;
	public const X509FindType FindByTimeValid = 6;
	public const X509FindType FindByTimeNotYetValid = 7;
	public const X509FindType FindByTimeExpired = 8;
	public const X509FindType FindByTemplateName = 9;
	public const X509FindType FindByApplicationPolicy = 10;
	public const X509FindType FindByCertificatePolicy = 11;
	public const X509FindType FindByExtension = 12;
	public const X509FindType FindByKeyUsage = 13;
	public const X509FindType FindBySubjectKeyIdentifier = 14;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509KeyUsageFlags
{
	// Fields
	public int value__; // 0x10
	public const X509KeyUsageFlags None = 0;
	public const X509KeyUsageFlags EncipherOnly = 1;
	public const X509KeyUsageFlags CrlSign = 2;
	public const X509KeyUsageFlags KeyCertSign = 4;
	public const X509KeyUsageFlags KeyAgreement = 8;
	public const X509KeyUsageFlags DataEncipherment = 16;
	public const X509KeyUsageFlags KeyEncipherment = 32;
	public const X509KeyUsageFlags NonRepudiation = 64;
	public const X509KeyUsageFlags DigitalSignature = 128;
	public const X509KeyUsageFlags DecipherOnly = 32768;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509NameType
{
	// Fields
	public int value__; // 0x10
	public const X509NameType SimpleName = 0;
	public const X509NameType EmailName = 1;
	public const X509NameType UpnName = 2;
	public const X509NameType DnsName = 3;
	public const X509NameType DnsFromAlternativeName = 4;
	public const X509NameType UrlName = 5;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509RevocationFlag
{
	// Fields
	public int value__; // 0x10
	public const X509RevocationFlag EndCertificateOnly = 0;
	public const X509RevocationFlag EntireChain = 1;
	public const X509RevocationFlag ExcludeRoot = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509RevocationMode
{
	// Fields
	public int value__; // 0x10
	public const X509RevocationMode NoCheck = 0;
	public const X509RevocationMode Online = 1;
	public const X509RevocationMode Offline = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509SubjectKeyIdentifierHashAlgorithm
{
	// Fields
	public int value__; // 0x10
	public const X509SubjectKeyIdentifierHashAlgorithm Sha1 = 0;
	public const X509SubjectKeyIdentifierHashAlgorithm ShortSha1 = 1;
	public const X509SubjectKeyIdentifierHashAlgorithm CapiSha1 = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509VerificationFlags
{
	// Fields
	public int value__; // 0x10
	public const X509VerificationFlags NoFlag = 0;
	public const X509VerificationFlags IgnoreNotTimeValid = 1;
	public const X509VerificationFlags IgnoreCtlNotTimeValid = 2;
	public const X509VerificationFlags IgnoreNotTimeNested = 4;
	public const X509VerificationFlags IgnoreInvalidBasicConstraints = 8;
	public const X509VerificationFlags AllowUnknownCertificateAuthority = 16;
	public const X509VerificationFlags IgnoreWrongUsage = 32;
	public const X509VerificationFlags IgnoreInvalidName = 64;
	public const X509VerificationFlags IgnoreInvalidPolicy = 128;
	public const X509VerificationFlags IgnoreEndRevocationUnknown = 256;
	public const X509VerificationFlags IgnoreCtlSignerRevocationUnknown = 512;
	public const X509VerificationFlags IgnoreCertificateAuthorityRevocationUnknown = 1024;
	public const X509VerificationFlags IgnoreRootRevocationUnknown = 2048;
	public const X509VerificationFlags AllFlags = 4095;
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class PublicKey
{
	// Fields
	private AsnEncodedData _keyValue; // 0x10
	private AsnEncodedData _params; // 0x18
	private Oid _oid; // 0x20
	private static Byte[] Empty; // 0x0

	// Methods

	// RVA: 0x12B32F4
	public void .ctor(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	// RVA: 0x12B3470
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x12B3478
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x12B3480
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x12B415C
	public Oid get_Oid() { }

	// RVA: 0x12B4164
	private static Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	// RVA: 0x12B3A7C
	internal static DSA DecodeDSA(Byte[] rawPublicKey, Byte[] rawParameters) { }

	// RVA: 0x12B364C
	internal static RSA DecodeRSA(Byte[] rawPublicKey) { }

	// RVA: 0x12B4218
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X500DistinguishedName
{
	// Fields
	private string name; // 0x20
	private Byte[] canonEncoding; // 0x28

	// Methods

	// RVA: 0x12B4298
	public void .ctor(Byte[] encodedDistinguishedName) { }

	// RVA: 0x12B4550
	public void .ctor(string distinguishedName) { }

	// RVA: 0x12B4558
	public void .ctor(string distinguishedName, X500DistinguishedNameFlags flag) { }

	// RVA: 0x12B4A50
	public string get_Name() { }

	// RVA: 0x12B48A0
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x12B4AE0
	public override string Format(bool multiLine) { }

	// RVA: 0x12B4A58
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x12B4444
	private void DecodeRawData() { }

	// RVA: 0x12B4B50
	private static string Canonize(string s) { }

	// RVA: 0x12B4DAC
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509BasicConstraintsExtension
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x21
	private bool _hasPathLengthConstraint; // 0x22
	private int _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Methods

	// RVA: 0x12B4FA4
	public void .ctor() { }

	// RVA: 0x12B31E0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x12B52A4
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x12B5554
	public bool get_CertificateAuthority() { }

	// RVA: 0x12B55C8
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x12B563C
	public int get_PathLengthConstraint() { }

	// RVA: 0x12B56B0
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12B5074
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12B53F8
	internal Byte[] Encode() { }

	// RVA: 0x12B58AC
	internal override string ToString(bool multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509Certificate2
{
	// Fields
	private Byte[] lazyRawData; // 0x60
	private Oid lazySignatureAlgorithm; // 0x68
	private int lazyVersion; // 0x70
	private X500DistinguishedName lazySubjectName; // 0x78
	private X500DistinguishedName lazyIssuerName; // 0x80
	private PublicKey lazyPublicKey; // 0x88
	private AsymmetricAlgorithm lazyPrivateKey; // 0x90
	private X509ExtensionCollection lazyExtensions; // 0x98

	// Methods

	// RVA: 0x12B5B44
	public override void Reset() { }

	// RVA: 0x12B5BFC
	public void .ctor() { }

	// RVA: 0x12B5C04
	public void .ctor(Byte[] rawData) { }

	// RVA: 0x12B5D94
	public void .ctor(Byte[] rawData, string password) { }

	// RVA: 0x12B5D9C
	internal void .ctor(X509Certificate2Impl impl) { }

	// RVA: 0x12B5DA4
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x12B5DAC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12B5DF4
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x12B64C4
	public bool get_HasPrivateKey() { }

	// RVA: 0x12B6570
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x12B67A8
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x12B68A0
	public DateTime get_NotAfter() { }

	// RVA: 0x12B68A8
	public DateTime get_NotBefore() { }

	// RVA: 0x12B68B0
	public PublicKey get_PublicKey() { }

	// RVA: 0x12B6A78
	public Byte[] get_RawData() { }

	// RVA: 0x12B6B74
	public string get_SerialNumber() { }

	// RVA: 0x12B6B84
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x12B6C84
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x12B6D7C
	public string get_Thumbprint() { }

	// RVA: 0x12B6D9C
	public int get_Version() { }

	// RVA: 0x12B6E78
	public static X509ContentType GetCertContentType(Byte[] rawData) { }

	// RVA: 0x12B6F14
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x12B6FD0
	public override string ToString() { }

	// RVA: 0x12B6FDC
	public override string ToString(bool verbose) { }

	// RVA: 0x12B8720
	public bool Verify() { }

	// RVA: 0x12B62C0
	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	// RVA: 0x12B6230
	internal X509Certificate2Impl get_Impl() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Certificate2Collection
{
	// Fields
	private static string[] newline_split; // 0x0

	// Methods

	// RVA: 0x12B87C8
	public void .ctor() { }

	// RVA: 0x12B87D8
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x12B8884
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x12B89B4
	public int Add(X509Certificate2 certificate) { }

	// RVA: 0x12B8808
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x12B8A30
	public bool Contains(X509Certificate2 certificate) { }

	// RVA: 0x12B8D68
	private string GetKeyIdentifier(X509Certificate2 x) { }

	// RVA: 0x12B9688
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x12BA810
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x12BA93C
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Certificate2Enumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12BA874
	internal void .ctor(X509Certificate2Collection collection) { }

	// RVA: 0x12BA9E4
	public X509Certificate2 get_Current() { }

	// RVA: 0x12BAAE8
	public bool MoveNext() { }

	// RVA: 0x12BAB9C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12BAC54
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x12BAD08
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2Impl
{
	// Methods

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions() { }

	// RVA: -1
	public abstract X500DistinguishedName get_IssuerName() { }

	// RVA: -1
	public abstract AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: -1
	public abstract void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: -1
	public abstract string get_SignatureAlgorithm() { }

	// RVA: -1
	public abstract X500DistinguishedName get_SubjectName() { }

	// RVA: -1
	public abstract int get_Version() { }

	// RVA: -1
	internal abstract X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: -1
	public abstract string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: -1
	public abstract bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: -1
	public abstract void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x12BADC0
	protected void .ctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509Certificate2ImplMono
{
	// Fields
	private X509CertificateImplCollection intermediateCerts; // 0xB0
	private X509Certificate _cert; // 0xB8
	private static string empty_error; // 0x0
	private static Byte[] signedData; // 0x8

	// Methods

	// RVA: 0x12BADC8
	public override bool get_IsValid() { }

	// RVA: 0x12BADD8
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x12BAE14
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x12BAF20
	public void .ctor(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x12BB150
	public override X509CertificateImpl Clone() { }

	// RVA: 0x12BB1C0
	private X509Certificate get_Cert() { }

	// RVA: 0x12BB1E8
	protected override Byte[] GetRawCertData() { }

	// RVA: 0x12BB22C
	public override bool get_HasPrivateKey() { }

	// RVA: 0x12BB254
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x12BB6A4
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x12BB84C
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x12BB8E4
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x12BB0D8
	private X509Certificate ImportPkcs12(Byte[] rawData, SafePasswordHandle password) { }

	// RVA: 0x12BB97C
	private X509Certificate ImportPkcs12(Byte[] rawData, string password) { }

	// RVA: 0x12BC2A4
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x12BC49C
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x12BC4A4
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x12BC4AC
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2ImplUnix
{
	// Fields
	private bool readCertData; // 0x10
	private CertificateData certData; // 0x18

	// Methods

	// RVA: 0x12BC58C
	private void EnsureCertData() { }

	// RVA: -1
	protected abstract Byte[] GetRawCertData() { }

	// RVA: 0x12BC664
	public sealed override string get_KeyAlgorithm() { }

	// RVA: 0x12BC748
	public sealed override Byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x12BC82C
	public sealed override Byte[] get_PublicKeyValue() { }

	// RVA: 0x12BC910
	public sealed override Byte[] get_SerialNumber() { }

	// RVA: 0x12BC9F4
	public sealed override string get_SignatureAlgorithm() { }

	// RVA: 0x12BCAD8
	public sealed override int get_Version() { }

	// RVA: 0x12BCBC4
	public sealed override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x12BCCA8
	public sealed override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x12BCD8C
	public sealed override string get_Subject() { }

	// RVA: 0x12BCDB8
	public sealed override string get_Issuer() { }

	// RVA: 0x12BCDE4
	public sealed override Byte[] get_RawData() { }

	// RVA: 0x12BCEC8
	public sealed override Byte[] get_Thumbprint() { }

	// RVA: 0x12BD0E0
	public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x12BD1D0
	public sealed override System.Collections.Generic.IEnumerable<System.Security.Cryptography.X509Certificates.X509Extension> get_Extensions() { }

	// RVA: 0x12BD2B4
	public sealed override DateTime get_NotAfter() { }

	// RVA: 0x12BD3E4
	public sealed override DateTime get_NotBefore() { }

	// RVA: 0x12BD514
	public sealed override void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x12BD5B8
	public sealed override Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	// RVA: 0x12BD718
	private Byte[] ExportPkcs12(SafePasswordHandle password) { }

	// RVA: 0x12BD778
	private Byte[] ExportPkcs12(string password) { }

	// RVA: 0x12BAE0C
	protected void .ctor() { }

}

// Namespace: 
public class X509CertificateEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12BDFB0
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x12BE09C
	public X509Certificate get_Current() { }

	// RVA: 0x12BE1A0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12BE258
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x12BE30C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x12BE3C4
	public bool MoveNext() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509CertificateCollection
{
	// Methods

	// RVA: 0x12B87D0
	public void .ctor() { }

	// RVA: 0x12BDCA8
	public void .ctor(X509CertificateCollection value) { }

	// RVA: 0x12BDE2C
	public X509Certificate get_Item(int index) { }

	// RVA: 0x12BDED0
	public int Add(X509Certificate value) { }

	// RVA: 0x12BDCD8
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x12BDF4C
	public X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x12BE078
	public override int GetHashCode() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509CertificateImplCollection
{
	// Fields
	private System.Collections.Generic.List<System.Security.Cryptography.X509Certificates.X509CertificateImpl> list; // 0x10

	// Methods

	// RVA: 0x12BC194
	public void .ctor() { }

	// RVA: 0x12BE478
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x12BDC5C
	public int get_Count() { }

	// RVA: 0x12BDBE4
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x12BC220
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x12BAEBC
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x12BE6E4
	public void Dispose() { }

	// RVA: 0x12BE774
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12BEA7C
	protected override void Finalize() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Chain
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Methods

	// RVA: 0x12BEB18
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x12BEBBC
	public void .ctor() { }

	// RVA: 0x12BEC30
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x12BED0C
	internal void .ctor(X509ChainImpl impl) { }

	// RVA: 0x12BED78
	public void .ctor(IntPtr chainContext) { }

	// RVA: 0x12BEDC0
	public X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x12BEE28
	public X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x12BC42C
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x12BEE90
	public void Reset() { }

	// RVA: 0x12BC380
	public static X509Chain Create() { }

	// RVA: 0x12BEEF8
	public void Dispose() { }

	// RVA: 0x12BEF88
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12BF0B8
	protected override void Finalize() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509ChainElement
{
	// Fields
	private X509Certificate2 certificate; // 0x10
	private X509ChainStatus[] status; // 0x18
	private string info; // 0x20
	private X509ChainStatusFlags compressed_status_flags; // 0x28

	// Methods

	// RVA: 0x12BF154
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x12BF1D4
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x12BF1DC
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x12BF1E4
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x12BF1EC
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x12BF1F4
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x12BF2AC
	private void Set(X509ChainStatus[] status, int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x12BF4D8
	internal void UncompressFlags() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementCollection
{
	// Fields
	private ArrayList _list; // 0x10

	// Methods

	// RVA: 0x12C04A8
	internal void .ctor() { }

	// RVA: 0x12C0520
	public int get_Count() { }

	// RVA: 0x12C0548
	public bool get_IsSynchronized() { }

	// RVA: 0x12C0570
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x12C0614
	public object get_SyncRoot() { }

	// RVA: 0x12C063C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12C0664
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x12C0794
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12C07FC
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0x12C08DC
	internal void Clear() { }

	// RVA: 0x12C0904
	internal bool Contains(X509Certificate2 certificate) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12C06CC
	internal void .ctor(IEnumerable enumerable) { }

	// RVA: 0x12C0A70
	public X509ChainElement get_Current() { }

	// RVA: 0x12C0B74
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12C0C2C
	public bool MoveNext() { }

	// RVA: 0x12C0CE0
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509ChainImpl
{
	// Methods

	// RVA: -1
	public abstract bool get_IsValid() { }

	// RVA: 0x12C0D98
	protected void ThrowIfContextInvalid() { }

	// RVA: -1
	public abstract X509ChainElementCollection get_ChainElements() { }

	// RVA: -1
	public abstract X509ChainPolicy get_ChainPolicy() { }

	// RVA: -1
	public abstract bool Build(X509Certificate2 certificate) { }

	// RVA: -1
	public abstract void AddStatus(X509ChainStatusFlags errorCode) { }

	// RVA: -1
	public abstract void Reset() { }

	// RVA: 0x12BF028
	public void Dispose() { }

	// RVA: 0x12C0E68
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12C0E6C
	protected override void Finalize() { }

	// RVA: 0x12C0F08
	protected void .ctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509ChainImplMono
{
	// Fields
	private StoreLocation location; // 0x10
	private X509ChainElementCollection elements; // 0x18
	private X509ChainPolicy policy; // 0x20
	private X509ChainStatus[] status; // 0x28
	private static X509ChainStatus[] Empty; // 0x0
	private int max_path_length; // 0x30
	private X500DistinguishedName working_issuer_name; // 0x38
	private AsymmetricAlgorithm working_public_key; // 0x40
	private X509ChainElement bce_restriction; // 0x48
	private X509Certificate2Collection roots; // 0x50
	private X509Certificate2Collection cas; // 0x58
	private X509Store root_store; // 0x60
	private X509Store ca_store; // 0x68
	private X509Store user_root_store; // 0x70
	private X509Store user_ca_store; // 0x78
	private X509Certificate2Collection collection; // 0x80

	// Methods

	// RVA: 0x12C0F10
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x12C1060
	public override bool get_IsValid() { }

	// RVA: 0x12C1068
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x12C1070
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x12C1078
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0x12C107C
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x12C1B98
	public override void Reset() { }

	// RVA: 0x12C1DA4
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x12C2338
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x12C1F60
	private X509Store get_LMRootStore() { }

	// RVA: 0x12C20F8
	private X509Store get_UserRootStore() { }

	// RVA: 0x12C24F4
	private X509Store get_LMCAStore() { }

	// RVA: 0x12C2660
	private X509Store get_UserCAStore() { }

	// RVA: 0x12C2D6C
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x12C17A8
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x12C338C
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x12C3164
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x12C3288
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x12C3774
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x12C1948
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x12C37C0
	private void Process(int n) { }

	// RVA: 0x12C3BE0
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x12C41A4
	private void WrapUp() { }

	// RVA: 0x12C4470
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x12C4428
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x12C36BC
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x12C3618
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x12C4A44
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x12C48B0
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x12C3F14
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x12C4AE0
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x12C4CB8
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x12C5728
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x12C4F38
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x12C5400
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x12C5108
	private bool ProcessCrlEntryExtensions(X509CrlEntry entry) { }

	// RVA: 0x12C5A8C
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainPolicy
{
	// Fields
	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	// Methods

	// RVA: 0x12C1038
	public void .ctor() { }

	// RVA: 0x12C2E60
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0x12C5C30
	internal void set_ExtraStore(X509Certificate2Collection value) { }

	// RVA: 0x12C5C38
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x12C5C40
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x12C5C48
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0x12C5CB4
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x12C5CBC
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x12C5D28
	public DateTime get_VerificationTime() { }

	// RVA: 0x12C5B0C
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public struct X509ChainStatus
{
	// Fields
	private X509ChainStatusFlags status; // 0x10
	private string info; // 0x18

	// Methods

	// RVA: 0x12C1B64
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0x12C5D30
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0x12C5D38
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0x12C5D40
	public void set_StatusInformation(string value) { }

	// RVA: 0x12BF338
	internal static string GetInformation(X509ChainStatusFlags flags) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509EnhancedKeyUsageExtension
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x12C5D48
	public void .ctor() { }

	// RVA: 0x12C5E00
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x12C6190
	public void .ctor(OidCollection enhancedKeyUsages, bool critical) { }

	// RVA: 0x12C6444
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12C5EF4
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12C6348
	internal Byte[] Encode() { }

	// RVA: 0x12C6620
	internal override string ToString(bool multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Extension
{
	// Fields
	private bool _critical; // 0x20

	// Methods

	// RVA: 0x12C5DF8
	protected void .ctor() { }

	// RVA: 0x12C6A40
	public void .ctor(string oid, Byte[] rawData, bool critical) { }

	// RVA: 0x12C6A6C
	public bool get_Critical() { }

	// RVA: 0x12C6A74
	public void set_Critical(bool value) { }

	// RVA: 0x12C6A7C
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12C6910
	internal string FormatUnkownData(Byte[] data) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionCollection
{
	// Fields
	private static Byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Methods

	// RVA: 0x12C6BAC
	public void .ctor() { }

	// RVA: 0x12BA774
	public int get_Count() { }

	// RVA: 0x12C6C24
	public bool get_IsSynchronized() { }

	// RVA: 0x12C6C4C
	public object get_SyncRoot() { }

	// RVA: 0x12B8E34
	public X509Extension get_Item(string oid) { }

	// RVA: 0x12C6C50
	public int Add(X509Extension extension) { }

	// RVA: 0x12C6CCC
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12C4664
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x12C6E34
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12C6EC8
	private static void .cctor() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionEnumerator
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Methods

	// RVA: 0x12C6DE4
	internal void .ctor(ArrayList list) { }

	// RVA: 0x12C46F8
	public X509Extension get_Current() { }

	// RVA: 0x12C6F48
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x12C47FC
	public bool MoveNext() { }

	// RVA: 0x12C7000
	public void Reset() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper2
{
	// Methods

	// RVA: 0x12C4340
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x12BECA8
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x12C70B8
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x12BEB70
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x12C0DE0
	internal static Exception GetInvalidChainContextException() { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509KeyUsageExtension
{
	// Fields
	internal const string oid = "2.5.29.15";
	internal const string friendlyName = "Key Usage";
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Methods

	// RVA: 0x12C70CC
	public void .ctor() { }

	// RVA: 0x12C717C
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x12C7498
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x12BA79C
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x12C772C
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12C7584
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x12C7270
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12C7594
	internal Byte[] Encode() { }

	// RVA: 0x12C7908
	internal override string ToString(bool multiLine) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Store
{
	// Fields
	private string _name; // 0x10
	private StoreLocation _location; // 0x18
	private X509Certificate2Collection list; // 0x20
	private OpenFlags _flags; // 0x28
	private X509Store store; // 0x30

	// Methods

	// RVA: 0x12C27CC
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x12C2290
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x12C7EAC
	private X509Stores get_Factory() { }

	// RVA: 0x12C7EC8
	internal X509Store get_Store() { }

	// RVA: 0x12C1D60
	public void Close() { }

	// RVA: 0x12C7ED0
	public void Dispose() { }

	// RVA: 0x12C2908
	public void Open(OpenFlags flags) { }

}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509SubjectKeyIdentifierExtension
{
	// Fields
	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private Byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Methods

	// RVA: 0x12C7F14
	public void .ctor() { }

	// RVA: 0x12C7FC4
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x12C8278
	public void .ctor(Byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x12C854C
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x12C88DC
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x12B91B4
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x12B95F0
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x12C88E8
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x12C8AC4
	internal static Byte FromHexChar(Char c) { }

	// RVA: 0x12C8B04
	internal static Byte FromHexChars(Char c1, Char c2) { }

	// RVA: 0x12C8734
	internal static Byte[] FromHex(string hex) { }

	// RVA: 0x12C80B8
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	// RVA: 0x12C84CC
	internal Byte[] Encode() { }

	// RVA: 0x12C8BA0
	internal override string ToString(bool multiLine) { }

}

// Namespace: System.ComponentModel
public class DefaultValueAttribute
{
	// Fields
	private object _value; // 0x10
	private static object s_convertFromInvariantString; // 0x0

	// Methods

	// RVA: 0x12C8E20
	public void .ctor(Type type, string value) { }

	// RVA: 0x12C9364
	public void .ctor(Char value) { }

	// RVA: 0x12C93E8
	public void .ctor(Byte value) { }

	// RVA: 0x12C946C
	public void .ctor(Int16 value) { }

	// RVA: 0x12C94F0
	public void .ctor(int value) { }

	// RVA: 0x12C9574
	public void .ctor(Int64 value) { }

	// RVA: 0x12C95F8
	public void .ctor(float value) { }

	// RVA: 0x12C9684
	public void .ctor(Double value) { }

	// RVA: 0x12C9710
	public void .ctor(bool value) { }

	// RVA: 0x12C9794
	public void .ctor(string value) { }

	// RVA: 0x12C97C8
	public void .ctor(object value) { }

	// RVA: 0x12C97FC
	public void .ctor(SByte value) { }

	// RVA: 0x12C9880
	public void .ctor(UInt16 value) { }

	// RVA: 0x12C9904
	public void .ctor(UInt32 value) { }

	// RVA: 0x12C9988
	public void .ctor(UInt64 value) { }

	// RVA: 0x12C9A0C
	public virtual object get_Value() { }

	// RVA: 0x12C9A14
	public override bool Equals(object obj) { }

	// RVA: 0x12C9B3C
	public override int GetHashCode() { }

	// RVA: 0x12C9B44
	protected void SetValue(object value) { }

	// RVA: 0x12C913C
	internal static bool <.ctor>g__TryConvertFromInvariantString|2_0(Type typeToConvert, string stringValue, object conversionResult) { }

}

// Namespace: System.ComponentModel
public sealed class EditorBrowsableAttribute
{
	// Fields
	private EditorBrowsableState browsableState; // 0x10

	// Methods

	// RVA: 0x12C9B4C
	public void .ctor(EditorBrowsableState state) { }

	// RVA: 0x12C9B78
	public void .ctor() { }

	// RVA: 0x12C9BA0
	public EditorBrowsableState get_State() { }

	// RVA: 0x12C9BA8
	public override bool Equals(object obj) { }

	// RVA: 0x12C9C4C
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public enum EditorBrowsableState
{
	// Fields
	public int value__; // 0x10
	public const EditorBrowsableState Always = 0;
	public const EditorBrowsableState Never = 1;
	public const EditorBrowsableState Advanced = 2;
}

// Namespace: System.ComponentModel
public sealed class AsyncOperation
{
	// Fields
	private readonly SynchronizationContext _syncContext; // 0x10
	private readonly object _userSuppliedState; // 0x18
	private bool _alreadyCompleted; // 0x20

	// Methods

	// RVA: 0x12C9C54
	private void .ctor(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x12C9CC0
	protected override void Finalize() { }

	// RVA: 0x12C9D68
	public object get_UserSuppliedState() { }

	// RVA: 0x12C9D70
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x12C9D78
	public void Post(SendOrPostCallback d, object arg) { }

	// RVA: 0x12C9E68
	public void PostOperationCompleted(SendOrPostCallback d, object arg) { }

	// RVA: 0x12C9F70
	public void OperationCompleted() { }

	// RVA: 0x12C9D80
	private void PostCore(SendOrPostCallback d, object arg, bool markCompleted) { }

	// RVA: 0x12C9E90
	private void OperationCompletedCore() { }

	// RVA: 0x12C9FE0
	private void VerifyNotCompleted() { }

	// RVA: 0x12CA048
	private void VerifyDelegateNotNull(SendOrPostCallback d) { }

	// RVA: 0x12CA0B8
	internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext) { }

	// RVA: 0x12CA160
	internal void .ctor() { }

}

// Namespace: System.ComponentModel
public static class AsyncOperationManager
{
	// Methods

	// RVA: 0x12CA19C
	public static AsyncOperation CreateOperation(object userSuppliedState) { }

	// RVA: 0x12CA21C
	public static SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x12CA2A8
	public static void set_SynchronizationContext(SynchronizationContext value) { }

}

// Namespace: System.ComponentModel
public class BackgroundWorker
{
	// Fields
	private bool _canCancelWorker; // 0x28
	private bool _workerReportsProgress; // 0x29
	private bool _cancellationPending; // 0x2A
	private bool _isRunning; // 0x2B
	private AsyncOperation _asyncOperation; // 0x30
	private readonly SendOrPostCallback _operationCompleted; // 0x38
	private readonly SendOrPostCallback _progressReporter; // 0x40
	private DoWorkEventHandler DoWork; // 0x48
	private ProgressChangedEventHandler ProgressChanged; // 0x50
	private RunWorkerCompletedEventHandler RunWorkerCompleted; // 0x58

	// Methods

	// RVA: 0x12CA2B0
	public void .ctor() { }

	// RVA: 0x12CA3B0
	private void AsyncOperationCompleted(object arg) { }

	// RVA: 0x12CA450
	public bool get_CancellationPending() { }

	// RVA: 0x12CA458
	public void CancelAsync() { }

	// RVA: 0x12CA4C8
	public void add_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x12CA56C
	public void remove_DoWork(DoWorkEventHandler value) { }

	// RVA: 0x12CA610
	public bool get_IsBusy() { }

	// RVA: 0x12CA618
	protected virtual void OnDoWork(DoWorkEventArgs e) { }

	// RVA: 0x12CA63C
	protected virtual void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e) { }

	// RVA: 0x12CA660
	protected virtual void OnProgressChanged(ProgressChangedEventArgs e) { }

	// RVA: 0x12CA684
	public void add_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x12CA728
	public void remove_ProgressChanged(ProgressChangedEventHandler value) { }

	// RVA: 0x12CA7CC
	private void ProgressReporter(object arg) { }

	// RVA: 0x12CA868
	public void ReportProgress(int percentProgress) { }

	// RVA: 0x12CA870
	public void ReportProgress(int percentProgress, object userState) { }

	// RVA: 0x12CA96C
	public void RunWorkerAsync() { }

	// RVA: 0x12CA974
	public void RunWorkerAsync(object argument) { }

	// RVA: 0x12CABC8
	public void add_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x12CAC6C
	public void remove_RunWorkerCompleted(RunWorkerCompletedEventHandler value) { }

	// RVA: 0x12CAD10
	public bool get_WorkerReportsProgress() { }

	// RVA: 0x12CAD18
	public void set_WorkerReportsProgress(bool value) { }

	// RVA: 0x12CAD20
	public bool get_WorkerSupportsCancellation() { }

	// RVA: 0x12CAD28
	public void set_WorkerSupportsCancellation(bool value) { }

	// RVA: 0x12CAD30
	private void WorkerThreadStart(object argument) { }

	// RVA: 0x12CAEC8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x12CAECC
	private void <RunWorkerAsync>b__27_0(object arg) { }

}

// Namespace: System.ComponentModel
public sealed class BrowsableAttribute
{
	// Fields
	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	private readonly bool <Browsable>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12CAED0
	public void .ctor(bool browsable) { }

	// RVA: 0x12CAEFC
	public bool get_Browsable() { }

	// RVA: 0x12CAF04
	public override bool Equals(object obj) { }

	// RVA: 0x12CB0D0
	public override int GetHashCode() { }

	// RVA: 0x12CB148
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CB1BC
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentCollection
{
	// Methods

	// RVA: 0x12CB270
	public void .ctor(IComponent[] components) { }

	// RVA: 0x12CB2BC
	public virtual IComponent get_Item(string name) { }

	// RVA: 0x12CB824
	public virtual IComponent get_Item(int index) { }

	// RVA: 0x12CB8C0
	public void CopyTo(IComponent[] array, int index) { }

}

// Namespace: System.ComponentModel
public class DescriptionAttribute
{
	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	private string <DescriptionValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12CB904
	public void .ctor() { }

	// RVA: 0x12CB974
	public void .ctor(string description) { }

	// RVA: 0x12CB9A8
	public virtual string get_Description() { }

	// RVA: 0x12CB9B0
	protected string get_DescriptionValue() { }

	// RVA: 0x12CB9B8
	protected void set_DescriptionValue(string value) { }

	// RVA: 0x12CB9C0
	public override bool Equals(object obj) { }

	// RVA: 0x12CBA9C
	public override int GetHashCode() { }

	// RVA: 0x12CBAC8
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CBB3C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DesignOnlyAttribute
{
	// Fields
	private readonly bool <IsDesignOnly>k__BackingField; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	// Methods

	// RVA: 0x12CBBF8
	public void .ctor(bool isDesignOnly) { }

	// RVA: 0x12CBC24
	public bool get_IsDesignOnly() { }

	// RVA: 0x12CBC2C
	public override bool Equals(object obj) { }

	// RVA: 0x12CBDF8
	public override int GetHashCode() { }

	// RVA: 0x12CBE70
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CBF18
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DesignerCategoryAttribute
{
	// Fields
	public static readonly DesignerCategoryAttribute Component; // 0x0
	public static readonly DesignerCategoryAttribute Default; // 0x8
	public static readonly DesignerCategoryAttribute Form; // 0x10
	public static readonly DesignerCategoryAttribute Generic; // 0x18
	private readonly string <Category>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12CBFCC
	public void .ctor() { }

	// RVA: 0x12CC038
	public void .ctor(string category) { }

	// RVA: 0x12CC06C
	public string get_Category() { }

	// RVA: 0x12CC074
	public override bool Equals(object obj) { }

	// RVA: 0x12CC114
	public override int GetHashCode() { }

	// RVA: 0x12CC138
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CC1DC
	public override object get_TypeId() { }

	// RVA: 0x12CC220
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public enum DesignerSerializationVisibility
{
	// Fields
	public int value__; // 0x10
	public const DesignerSerializationVisibility Hidden = 0;
	public const DesignerSerializationVisibility Visible = 1;
	public const DesignerSerializationVisibility Content = 2;
}

// Namespace: System.ComponentModel
public sealed class DesignerSerializationVisibilityAttribute
{
	// Fields
	public static readonly DesignerSerializationVisibilityAttribute Content; // 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; // 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; // 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; // 0x18
	private readonly DesignerSerializationVisibility <Visibility>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12CC3D0
	public void .ctor(DesignerSerializationVisibility visibility) { }

	// RVA: 0x12CC3FC
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x12CC404
	public override bool Equals(object obj) { }

	// RVA: 0x12CC5C0
	public override int GetHashCode() { }

	// RVA: 0x12CC5C8
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CC63C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class DisplayNameAttribute
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private string <DisplayNameValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12CC720
	public void .ctor() { }

	// RVA: 0x12CC790
	public void .ctor(string displayName) { }

	// RVA: 0x12CC7C4
	public virtual string get_DisplayName() { }

	// RVA: 0x12CC7CC
	protected string get_DisplayNameValue() { }

	// RVA: 0x12CC7D4
	protected void set_DisplayNameValue(string value) { }

	// RVA: 0x12CC7DC
	public override bool Equals(object obj) { }

	// RVA: 0x12CC8B8
	public override int GetHashCode() { }

	// RVA: 0x12CC8E4
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CC958
	private static void .cctor() { }

}

// Namespace: 
private sealed class ListEntry
{
	// Fields
	internal ListEntry _next; // 0x10
	internal object _key; // 0x18
	internal Delegate _handler; // 0x20

	// Methods

	// RVA: 0x12CCBCC
	public void .ctor(object key, Delegate handler, ListEntry next) { }

}

// Namespace: System.ComponentModel
public sealed class EventHandlerList
{
	// Fields
	private ListEntry _head; // 0x10
	private Component _parent; // 0x18

	// Methods

	// RVA: 0x12CCA14
	internal void .ctor(Component parent) { }

	// RVA: 0x12CCA48
	public void .ctor() { }

	// RVA: 0x12CCA50
	public Delegate get_Item(object key) { }

	// RVA: 0x12CCAE4
	public void set_Item(object key, Delegate value) { }

	// RVA: 0x12CCC30
	public void AddHandler(object key, Delegate value) { }

	// RVA: 0x12CCD2C
	public void AddHandlers(EventHandlerList listToAddFrom) { }

	// RVA: 0x12CCD6C
	public void Dispose() { }

	// RVA: 0x12CCACC
	private ListEntry Find(object key) { }

	// RVA: 0x12CCD78
	public void RemoveHandler(object key, Delegate value) { }

}

// Namespace: System.ComponentModel
public interface IContainer
{
	// Methods

	// RVA: -1
	public abstract void Add(IComponent component) { }

	// RVA: -1
	public abstract void Add(IComponent component, string name) { }

	// RVA: -1
	public abstract ComponentCollection get_Components() { }

	// RVA: -1
	public abstract void Remove(IComponent component) { }

}

// Namespace: System.ComponentModel
public interface ISite
{
	// Methods

	// RVA: -1
	public abstract IComponent get_Component() { }

	// RVA: -1
	public abstract IContainer get_Container() { }

	// RVA: -1
	public abstract bool get_DesignMode() { }

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: -1
	public abstract void set_Name(string value) { }

}

// Namespace: System.ComponentModel
public interface ISupportInitialize
{
	// Methods

	// RVA: -1
	public abstract void BeginInit() { }

	// RVA: -1
	public abstract void EndInit() { }

}

// Namespace: System.ComponentModel
public interface ISynchronizeInvoke
{
	// Methods

	// RVA: -1
	public abstract bool get_InvokeRequired() { }

	// RVA: -1
	public abstract IAsyncResult BeginInvoke(Delegate method, object[] args) { }

	// RVA: -1
	public abstract object EndInvoke(IAsyncResult result) { }

	// RVA: -1
	public abstract object Invoke(Delegate method, object[] args) { }

}

// Namespace: System.ComponentModel
public sealed class ImmutableObjectAttribute
{
	// Fields
	public static readonly ImmutableObjectAttribute Yes; // 0x0
	public static readonly ImmutableObjectAttribute No; // 0x8
	public static readonly ImmutableObjectAttribute Default; // 0x10
	private readonly bool <Immutable>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12CCDD4
	public void .ctor(bool immutable) { }

	// RVA: 0x12CCE00
	public bool get_Immutable() { }

	// RVA: 0x12CCE08
	public override bool Equals(object obj) { }

	// RVA: 0x12CCFD4
	public override int GetHashCode() { }

	// RVA: 0x12CCFDC
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CD050
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class InitializationEventAttribute
{
	// Fields
	private readonly string <EventName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12CD104
	public void .ctor(string eventName) { }

	// RVA: 0x12CD138
	public string get_EventName() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidEnumArgumentException
{
	// Methods

	// RVA: 0x12CD140
	public void .ctor() { }

	// RVA: 0x12CD14C
	public void .ctor(string message) { }

	// RVA: 0x12CD154
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12CD15C
	public void .ctor(string argumentName, int invalidValue, Type enumClass) { }

	// RVA: 0x12CD248
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: System.ComponentModel
public sealed class LocalizableAttribute
{
	// Fields
	private readonly bool <IsLocalizable>k__BackingField; // 0x10
	public static readonly LocalizableAttribute Yes; // 0x0
	public static readonly LocalizableAttribute No; // 0x8
	public static readonly LocalizableAttribute Default; // 0x10

	// Methods

	// RVA: 0x12CD250
	public void .ctor(bool isLocalizable) { }

	// RVA: 0x12CD27C
	public bool get_IsLocalizable() { }

	// RVA: 0x12CD284
	public override bool Equals(object obj) { }

	// RVA: 0x12CD450
	public override int GetHashCode() { }

	// RVA: 0x12CD458
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CD500
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class MergablePropertyAttribute
{
	// Fields
	public static readonly MergablePropertyAttribute Yes; // 0x0
	public static readonly MergablePropertyAttribute No; // 0x8
	public static readonly MergablePropertyAttribute Default; // 0x10
	private readonly bool <AllowMerge>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12CD5B4
	public void .ctor(bool allowMerge) { }

	// RVA: 0x12CD5E0
	public bool get_AllowMerge() { }

	// RVA: 0x12CD5E8
	public override bool Equals(object obj) { }

	// RVA: 0x12CD7B4
	public override int GetHashCode() { }

	// RVA: 0x12CD7BC
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CD830
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class ReadOnlyAttribute
{
	// Fields
	public static readonly ReadOnlyAttribute Yes; // 0x0
	public static readonly ReadOnlyAttribute No; // 0x8
	public static readonly ReadOnlyAttribute Default; // 0x10
	private readonly bool <IsReadOnly>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12CD8E4
	public void .ctor(bool isReadOnly) { }

	// RVA: 0x12CD910
	public bool get_IsReadOnly() { }

	// RVA: 0x12CD918
	public override bool Equals(object value) { }

	// RVA: 0x12CDAE4
	public override int GetHashCode() { }

	// RVA: 0x12CDAEC
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12CDB94
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class AddingNewEventArgs
{
	// Fields
	private object <NewObject>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12CDC48
	public void .ctor() { }

	// RVA: 0x12CDCD0
	public void .ctor(object newObject) { }

	// RVA: 0x12CDD48
	public object get_NewObject() { }

	// RVA: 0x12CDD50
	public void set_NewObject(object value) { }

}

// Namespace: System.ComponentModel
public sealed class AddingNewEventHandler
{
	// Methods

	// RVA: 0x12CDD58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12CDE7C
	public virtual void Invoke(object sender, AddingNewEventArgs e) { }

	// RVA: 0x12CDE90
	public virtual IAsyncResult BeginInvoke(object sender, AddingNewEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12CDEEC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public sealed class AmbientValueAttribute
{
	// Fields
	private readonly object <Value>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12CDEF8
	public void .ctor(Type type, string value) { }

	// RVA: 0x12CE030
	public void .ctor(Char value) { }

	// RVA: 0x12CE0B4
	public void .ctor(Byte value) { }

	// RVA: 0x12CE138
	public void .ctor(Int16 value) { }

	// RVA: 0x12CE1BC
	public void .ctor(int value) { }

	// RVA: 0x12CE240
	public void .ctor(Int64 value) { }

	// RVA: 0x12CE2C4
	public void .ctor(float value) { }

	// RVA: 0x12CE350
	public void .ctor(Double value) { }

	// RVA: 0x12CE3DC
	public void .ctor(bool value) { }

	// RVA: 0x12CE460
	public void .ctor(string value) { }

	// RVA: 0x12CE494
	public void .ctor(object value) { }

	// RVA: 0x12CE4C8
	public object get_Value() { }

	// RVA: 0x12CE4D0
	public override bool Equals(object obj) { }

	// RVA: 0x12CE590
	public override int GetHashCode() { }

}

// Namespace: 
private class ArrayPropertyDescriptor
{
	// Fields
	private readonly int _index; // 0x98

	// Methods

	// RVA: 0x12CEA88
	public void .ctor(Type arrayType, Type elementType, int index) { }

	// RVA: 0x12CEB58
	public override object GetValue(object instance) { }

	// RVA: 0x12CEC10
	public override void SetValue(object instance, object value) { }

}

// Namespace: System.ComponentModel
public class ArrayConverter
{
	// Methods

	// RVA: 0x12CE598
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12CE78C
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12CEB48
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12CEB50
	public void .ctor() { }

}

// Namespace: 
private struct AttributeEntry
{
	// Fields
	public Type type; // 0x10
	public int index; // 0x18
}

// Namespace: System.ComponentModel
public class AttributeCollection
{
	// Fields
	public static readonly AttributeCollection Empty; // 0x0
	private static Hashtable s_defaultAttributes; // 0x8
	private readonly Attribute[] _attributes; // 0x10
	private static readonly object s_internalSyncObject; // 0x10
	private const int FOUND_TYPES_LIMIT = 5;
	private AttributeEntry[] _foundAttributeTypes; // 0x18
	private int _index; // 0x20

	// Methods

	// RVA: 0x12CED14
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x12CEEA0
	protected void .ctor() { }

	// RVA: 0x12CEEA8
	public static AttributeCollection FromExisting(AttributeCollection existing, Attribute[] newAttributes) { }

	// RVA: 0x12CF360
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x12CF2CC
	public int get_Count() { }

	// RVA: 0x12CF368
	public virtual Attribute get_Item(int index) { }

	// RVA: 0x12CF3B0
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x12D015C
	public bool Contains(Attribute attribute) { }

	// RVA: 0x12D01C0
	public bool Contains(Attribute[] attributes) { }

	// RVA: 0x12CFB50
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x12D0260
	public IEnumerator GetEnumerator() { }

	// RVA: 0x12D0288
	public bool Matches(Attribute attribute) { }

	// RVA: 0x12D0338
	public bool Matches(Attribute[] attributes) { }

	// RVA: 0x12D03B0
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12D03B8
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12D03C0
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12D03E8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12CF2F4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x12D0410
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class AttributeProviderAttribute
{
	// Fields
	private readonly string <TypeName>k__BackingField; // 0x10
	private readonly string <PropertyName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12D04C0
	public void .ctor(string typeName) { }

	// RVA: 0x12D0540
	public void .ctor(string typeName, string propertyName) { }

	// RVA: 0x12D0600
	public void .ctor(Type type) { }

	// RVA: 0x12D071C
	public string get_TypeName() { }

	// RVA: 0x12D0724
	public string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public abstract class ComponentEditor
{
	// Methods

	// RVA: 0x12D072C
	public bool EditComponent(object component) { }

	// RVA: -1
	public abstract bool EditComponent(ITypeDescriptorContext context, object component) { }

	// RVA: 0x12D0740
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class BaseNumberConverter
{
	// Methods

	// RVA: 0x12D0748
	internal void .ctor() { }

	// RVA: 0x12D0750
	internal virtual bool get_AllowHex() { }

	// RVA: -1
	internal abstract Type get_TargetType() { }

	// RVA: -1
	internal abstract object FromString(string value, int radix) { }

	// RVA: -1
	internal abstract object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: -1
	internal abstract string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12D0758
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12D0824
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12D0C40
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12D0F40
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

}

// Namespace: System.ComponentModel
public sealed class BindableAttribute
{
	// Fields
	public static readonly BindableAttribute Yes; // 0x0
	public static readonly BindableAttribute No; // 0x8
	public static readonly BindableAttribute Default; // 0x10
	private bool _isDefault; // 0x10
	private readonly bool <Bindable>k__BackingField; // 0x11
	private readonly BindingDirection <Direction>k__BackingField; // 0x14

	// Methods

	// RVA: 0x12D0F88
	public void .ctor(bool bindable) { }

	// RVA: 0x12D0FB8
	public void .ctor(bool bindable, BindingDirection direction) { }

	// RVA: 0x12D0FF4
	public void .ctor(BindableSupport flags) { }

	// RVA: 0x12D1038
	public void .ctor(BindableSupport flags, BindingDirection direction) { }

	// RVA: 0x12D1088
	public bool get_Bindable() { }

	// RVA: 0x12D1090
	public BindingDirection get_Direction() { }

	// RVA: 0x12D1098
	public override bool Equals(object obj) { }

	// RVA: 0x12D1148
	public override int GetHashCode() { }

	// RVA: 0x12D11C0
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12D125C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public enum BindableSupport
{
	// Fields
	public int value__; // 0x10
	public const BindableSupport No = 0;
	public const BindableSupport Yes = 1;
	public const BindableSupport Default = 2;
}

// Namespace: System.ComponentModel
public enum BindingDirection
{
	// Fields
	public int value__; // 0x10
	public const BindingDirection OneWay = 0;
	public const BindingDirection TwoWay = 1;
}

// Namespace: System.ComponentModel
[Serializable]
public class BindingList<T0>
{
	// Fields
	private int addNewPos; // 0x0
	private bool raiseListChangedEvents; // 0x0
	private bool raiseItemChangedEvents; // 0x0
	private PropertyDescriptorCollection _itemTypeProperties; // 0x0
	private PropertyChangedEventHandler _propertyChangedEventHandler; // 0x0
	private AddingNewEventHandler _onAddingNew; // 0x0
	private ListChangedEventHandler _onListChanged; // 0x0
	private int _lastChangeIndex; // 0x0
	private bool allowNew; // 0x0
	private bool allowEdit; // 0x0
	private bool allowRemove; // 0x0
	private bool userSetAllowNew; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.IList<T> list) { }

	// RVA: 0x30B2870
	private void Initialize() { }

	// RVA: 0x30B171C
	private bool get_ItemTypeHasDefaultConstructor() { }

	// RVA: 0x30B2CB8
	public void add_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x30B2CB8
	public void remove_AddingNew(AddingNewEventHandler value) { }

	// RVA: 0x30B2CB8
	protected virtual void OnAddingNew(AddingNewEventArgs e) { }

	// RVA: 0x30B1CD4
	private object FireAddingNew() { }

	// RVA: 0x30B2CB8
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x30B2CB8
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0x30B2CB8
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x30B171C
	public bool get_RaiseListChangedEvents() { }

	// RVA: 0x30B28FC
	public void set_RaiseListChangedEvents(bool value) { }

	// RVA: 0x30B2870
	public void ResetBindings() { }

	// RVA: 0x30B29E8
	public void ResetItem(int position) { }

	// RVA: 0x30B2A58
	private void FireListChanged(ListChangedType type, int index) { }

	// RVA: 0x30B2870
	protected override void ClearItems() { }

	// RVA: 0x316B894
	protected override void InsertItem(int index, T item) { }

	// RVA: 0x30B29E8
	protected override void RemoveItem(int index) { }

	// RVA: 0x316B894
	protected override void SetItem(int index, T item) { }

	// RVA: 0x30B29E8
	public virtual void CancelNew(int itemIndex) { }

	// RVA: 0x30B29E8
	public virtual void EndNew(int itemIndex) { }

	// RVA: 0x316B894
	public T AddNew() { }

	// RVA: 0x30B1CD4
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0x30B171C
	private bool get_AddingNewHandled() { }

	// RVA: 0x30B1CD4
	protected virtual object AddNewCore() { }

	// RVA: 0x30B171C
	public bool get_AllowNew() { }

	// RVA: 0x30B28FC
	public void set_AllowNew(bool value) { }

	// RVA: 0x30B171C
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0x30B171C
	public bool get_AllowEdit() { }

	// RVA: 0x30B28FC
	public void set_AllowEdit(bool value) { }

	// RVA: 0x30B171C
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0x30B171C
	public bool get_AllowRemove() { }

	// RVA: 0x30B28FC
	public void set_AllowRemove(bool value) { }

	// RVA: 0x30B171C
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0x30B171C
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0x30B171C
	protected virtual bool get_SupportsChangeNotificationCore() { }

	// RVA: 0x30B171C
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0x30B171C
	protected virtual bool get_SupportsSearchingCore() { }

	// RVA: 0x30B171C
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0x30B171C
	protected virtual bool get_SupportsSortingCore() { }

	// RVA: 0x30B171C
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0x30B171C
	protected virtual bool get_IsSortedCore() { }

	// RVA: 0x30B1CD4
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0x30B1CD4
	protected virtual PropertyDescriptor get_SortPropertyCore() { }

	// RVA: 0x30B199C
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0x30B199C
	protected virtual ListSortDirection get_SortDirectionCore() { }

	// RVA: 0x30B2D20
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction) { }

	// RVA: 0x30B2D20
	protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction) { }

	// RVA: 0x30B2870
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0x30B2870
	protected virtual void RemoveSortCore() { }

	// RVA: -1
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor prop, object key) { }

	// RVA: -1
	protected virtual int FindCore(PropertyDescriptor prop, object key) { }

	// RVA: 0x30B2CB8
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor prop) { }

	// RVA: 0x30B2CB8
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor prop) { }

	// RVA: 0x316B894
	private void HookPropertyChanged(T item) { }

	// RVA: 0x316B894
	private void UnhookPropertyChanged(T item) { }

	// RVA: 0x30B2F18
	private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x30B171C
	private bool System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents() { }

}

// Namespace: System.ComponentModel
public class BooleanConverter
{
	// Fields
	private static StandardValuesCollection s_values; // 0x0

	// Methods

	// RVA: 0x12D1318
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12D13E4
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12D15E4
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12D1790
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12D1798
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12D17A0
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class ByteConverter
{
	// Methods

	// RVA: 0x12D17A8
	internal override Type get_TargetType() { }

	// RVA: 0x12D1848
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12D18E4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12D1960
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12D1A18
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class CancelEventHandler
{
	// Methods

	// RVA: 0x12D1A20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12D1B44
	public virtual void Invoke(object sender, CancelEventArgs e) { }

	// RVA: 0x12D1B58
	public virtual IAsyncResult BeginInvoke(object sender, CancelEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12D1BB4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class CharConverter
{
	// Methods

	// RVA: 0x12D1BC0
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12D1C8C
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12D1DC0
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12D1F54
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public enum CollectionChangeAction
{
	// Fields
	public int value__; // 0x10
	public const CollectionChangeAction Add = 1;
	public const CollectionChangeAction Remove = 2;
	public const CollectionChangeAction Refresh = 3;
}

// Namespace: System.ComponentModel
public class CollectionChangeEventArgs
{
	// Fields
	private readonly CollectionChangeAction <Action>k__BackingField; // 0x10
	private readonly object <Element>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12D1F5C
	public void .ctor(CollectionChangeAction action, object element) { }

	// RVA: 0x12D1FE4
	public virtual CollectionChangeAction get_Action() { }

	// RVA: 0x12D1FEC
	public virtual object get_Element() { }

}

// Namespace: System.ComponentModel
public sealed class CollectionChangeEventHandler
{
	// Methods

	// RVA: 0x12D1FF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12D2118
	public virtual void Invoke(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x12D212C
	public virtual IAsyncResult BeginInvoke(object sender, CollectionChangeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12D2188
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public sealed class ComplexBindingPropertiesAttribute
{
	// Fields
	private readonly string <DataSource>k__BackingField; // 0x10
	private readonly string <DataMember>k__BackingField; // 0x18
	public static readonly ComplexBindingPropertiesAttribute Default; // 0x0

	// Methods

	// RVA: 0x12D2194
	public void .ctor() { }

	// RVA: 0x12D219C
	public void .ctor(string dataSource) { }

	// RVA: 0x12D21D0
	public void .ctor(string dataSource, string dataMember) { }

	// RVA: 0x12D2220
	public string get_DataSource() { }

	// RVA: 0x12D2228
	public string get_DataMember() { }

	// RVA: 0x12D2230
	public override bool Equals(object obj) { }

	// RVA: 0x12D22C8
	public override int GetHashCode() { }

	// RVA: 0x12D22D0
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentResourceManager
{
	// Fields
	private Hashtable _resourceSets; // 0x88
	private CultureInfo _neutralResourcesCulture; // 0x90

	// Methods

	// RVA: 0x12D233C
	public void .ctor() { }

	// RVA: 0x12D23C4
	public void .ctor(Type t) { }

	// RVA: 0x12D2430
	private CultureInfo get_NeutralResourcesCulture() { }

	// RVA: 0x12D24D8
	public void ApplyResources(object value, string objectName) { }

	// RVA: 0x12D24E8
	public virtual void ApplyResources(object value, string objectName, CultureInfo culture) { }

	// RVA: 0x12D33A8
	private System.Collections.Generic.SortedList<System.String,System.Object> FillResources(CultureInfo culture, ResourceSet resourceSet) { }

}

// Namespace: System.ComponentModel
public abstract class ContainerFilterService
{
	// Methods

	// RVA: 0x12D3950
	protected void .ctor() { }

	// RVA: 0x12D3958
	public virtual ComponentCollection FilterComponents(ComponentCollection components) { }

}

// Namespace: 
private class CultureComparer
{
	// Fields
	private CultureInfoConverter _converter; // 0x10

	// Methods

	// RVA: 0x12D4CF8
	public void .ctor(CultureInfoConverter cultureConverter) { }

	// RVA: 0x12D4D44
	public int Compare(object item1, object item2) { }

}

// Namespace: 
private static class CultureInfoMapper
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_cultureInfoNameMap; // 0x0

	// Methods

	// RVA: 0x12D4EB8
	private static System.Collections.Generic.Dictionary<System.String,System.String> CreateMap() { }

	// RVA: 0x12D4520
	public static string GetCultureInfoName(string cultureInfoDisplayName) { }

	// RVA: 0x12D8F9C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class CultureInfoConverter
{
	// Fields
	private StandardValuesCollection _values; // 0x10
	private const string DefaultInvariantCultureString = "(Default)";

	// Methods

	// RVA: 0x12D3960
	private string get_DefaultCultureString() { }

	// RVA: 0x12D39A4
	protected virtual string GetCultureName(CultureInfo culture) { }

	// RVA: 0x12D39CC
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12D3A98
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12D3B64
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12D45E8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12D4AA8
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12D4D2C
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12D4D34
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12D4D3C
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor
{
	// Fields
	private readonly ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x12D8FF8
	protected void .ctor() { }

	// RVA: 0x12D9000
	protected void .ctor(ICustomTypeDescriptor parent) { }

	// RVA: 0x12D9034
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x12D9134
	public virtual string GetClassName() { }

	// RVA: 0x12D91F8
	public virtual string GetComponentName() { }

	// RVA: 0x12D92BC
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x12D93A8
	public virtual EventDescriptor GetDefaultEvent() { }

	// RVA: 0x12D946C
	public virtual PropertyDescriptor GetDefaultProperty() { }

	// RVA: 0x12D9530
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x12D95F8
	public virtual EventDescriptorCollection GetEvents() { }

	// RVA: 0x12D96FC
	public virtual EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: 0x12D9808
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x12D990C
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x12D9A18
	public virtual object GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: System.ComponentModel
public sealed class DataObjectAttribute
{
	// Fields
	public static readonly DataObjectAttribute DataObject; // 0x0
	public static readonly DataObjectAttribute NonDataObject; // 0x8
	public static readonly DataObjectAttribute Default; // 0x10
	private readonly bool <IsDataObject>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12D9AE0
	public void .ctor() { }

	// RVA: 0x12D9B0C
	public void .ctor(bool isDataObject) { }

	// RVA: 0x12D9B38
	public bool get_IsDataObject() { }

	// RVA: 0x12D9B40
	public override bool Equals(object obj) { }

	// RVA: 0x12D9BF0
	public override int GetHashCode() { }

	// RVA: 0x12D9C68
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12D9CDC
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DataObjectFieldAttribute
{
	// Fields
	private readonly bool <IsIdentity>k__BackingField; // 0x10
	private readonly bool <IsNullable>k__BackingField; // 0x11
	private readonly int <Length>k__BackingField; // 0x14
	private readonly bool <PrimaryKey>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12D9D90
	public void .ctor(bool primaryKey) { }

	// RVA: 0x12D9E1C
	public void .ctor(bool primaryKey, bool isIdentity) { }

	// RVA: 0x12D9E64
	public void .ctor(bool primaryKey, bool isIdentity, bool isNullable) { }

	// RVA: 0x12D9DC8
	public void .ctor(bool primaryKey, bool isIdentity, bool isNullable, int length) { }

	// RVA: 0x12D9EB0
	public bool get_IsIdentity() { }

	// RVA: 0x12D9EB8
	public bool get_IsNullable() { }

	// RVA: 0x12D9EC0
	public int get_Length() { }

	// RVA: 0x12D9EC8
	public bool get_PrimaryKey() { }

	// RVA: 0x12D9ED0
	public override bool Equals(object obj) { }

	// RVA: 0x12D9FD0
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public sealed class DataObjectMethodAttribute
{
	// Fields
	private readonly bool <IsDefault>k__BackingField; // 0x10
	private readonly DataObjectMethodType <MethodType>k__BackingField; // 0x14

	// Methods

	// RVA: 0x12D9FD8
	public void .ctor(DataObjectMethodType methodType) { }

	// RVA: 0x12DA008
	public void .ctor(DataObjectMethodType methodType, bool isDefault) { }

	// RVA: 0x12DA044
	public bool get_IsDefault() { }

	// RVA: 0x12DA04C
	public DataObjectMethodType get_MethodType() { }

	// RVA: 0x12DA054
	public override bool Equals(object obj) { }

	// RVA: 0x12DA114
	public override int GetHashCode() { }

	// RVA: 0x12DA1A8
	public override bool Match(object obj) { }

}

// Namespace: System.ComponentModel
public enum DataObjectMethodType
{
	// Fields
	public int value__; // 0x10
	public const DataObjectMethodType Fill = 0;
	public const DataObjectMethodType Select = 1;
	public const DataObjectMethodType Update = 2;
	public const DataObjectMethodType Insert = 3;
	public const DataObjectMethodType Delete = 4;
}

// Namespace: System.ComponentModel
public class DateTimeConverter
{
	// Methods

	// RVA: 0x12DA24C
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12DA318
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12DA3E4
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12DA730
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12DAB74
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class DecimalConverter
{
	// Methods

	// RVA: 0x12DAB7C
	internal override bool get_AllowHex() { }

	// RVA: 0x12DAB84
	internal override Type get_TargetType() { }

	// RVA: 0x12DAC24
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12DACF0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12DB054
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12DB148
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12DB200
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12DB2F4
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultBindingPropertyAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultBindingPropertyAttribute Default; // 0x0

	// Methods

	// RVA: 0x12DB2FC
	public void .ctor() { }

	// RVA: 0x12DB304
	public void .ctor(string name) { }

	// RVA: 0x12DB338
	public string get_Name() { }

	// RVA: 0x12DB340
	public override bool Equals(object obj) { }

	// RVA: 0x12DB3C4
	public override int GetHashCode() { }

	// RVA: 0x12DB3CC
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultEventAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultEventAttribute Default; // 0x0

	// Methods

	// RVA: 0x12DB438
	public void .ctor(string name) { }

	// RVA: 0x12DB46C
	public string get_Name() { }

	// RVA: 0x12DB474
	public override bool Equals(object obj) { }

	// RVA: 0x12DB4F8
	public override int GetHashCode() { }

	// RVA: 0x12DB500
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DefaultPropertyAttribute
{
	// Fields
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultPropertyAttribute Default; // 0x0

	// Methods

	// RVA: 0x12DB57C
	public void .ctor(string name) { }

	// RVA: 0x12DB5B0
	public string get_Name() { }

	// RVA: 0x12DB5B8
	public override bool Equals(object obj) { }

	// RVA: 0x12DB63C
	public override int GetHashCode() { }

	// RVA: 0x12DB644
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class DelegatingTypeDescriptionProvider
{
	// Fields
	private readonly Type _type; // 0x20

	// Methods

	// RVA: 0x12DB6C0
	internal void .ctor(Type type) { }

	// RVA: 0x12DB6FC
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x12DB78C
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x12DB858
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x12DB8FC
	public override string GetFullComponentName(object component) { }

	// RVA: 0x12DB9A0
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x12DBA44
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x12DBAE8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x12DBB9C
	public override Type GetRuntimeType(Type objectType) { }

	// RVA: 0x12DBC40
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x12DBCF4
	public override bool IsSupportedType(Type type) { }

}

// Namespace: System.ComponentModel
public sealed class InheritanceAttribute
{
	// Fields
	public static readonly InheritanceAttribute Inherited; // 0x0
	public static readonly InheritanceAttribute InheritedReadOnly; // 0x8
	public static readonly InheritanceAttribute NotInherited; // 0x10
	public static readonly InheritanceAttribute Default; // 0x18
	private readonly InheritanceLevel <InheritanceLevel>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12DBD98
	public void .ctor() { }

	// RVA: 0x12DBE40
	public void .ctor(InheritanceLevel inheritanceLevel) { }

	// RVA: 0x12DBE6C
	public InheritanceLevel get_InheritanceLevel() { }

	// RVA: 0x12DBE74
	public override bool Equals(object value) { }

	// RVA: 0x12DBF18
	public override int GetHashCode() { }

	// RVA: 0x12DBF20
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12DBF94
	public override string ToString() { }

	// RVA: 0x12DC094
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public enum InheritanceLevel
{
	// Fields
	public int value__; // 0x10
	public const InheritanceLevel Inherited = 1;
	public const InheritanceLevel InheritedReadOnly = 2;
	public const InheritanceLevel NotInherited = 3;
}

// Namespace: System.ComponentModel
public class PropertyTabAttribute
{
	// Fields
	private Type[] _tabClasses; // 0x10
	private string[] _tabClassNames; // 0x18
	private PropertyTabScope[] <TabScopes>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12DC17C
	public void .ctor() { }

	// RVA: 0x12DC310
	public void .ctor(Type tabClass) { }

	// RVA: 0x12DC4A8
	public void .ctor(string tabClassName) { }

	// RVA: 0x12DC318
	public void .ctor(Type tabClass, PropertyTabScope tabScope) { }

	// RVA: 0x12DC4B0
	public void .ctor(string tabClassName, PropertyTabScope tabScope) { }

	// RVA: 0x12DC61C
	public Type[] get_TabClasses() { }

	// RVA: 0x12DC97C
	protected string[] get_TabClassNames() { }

	// RVA: 0x12DC9F4
	public PropertyTabScope[] get_TabScopes() { }

	// RVA: 0x12DC9FC
	private void set_TabScopes(PropertyTabScope[] value) { }

	// RVA: 0x12DCA04
	public override bool Equals(object other) { }

	// RVA: 0x12DCAA0
	public bool Equals(PropertyTabAttribute other) { }

	// RVA: 0x12DCC58
	public override int GetHashCode() { }

	// RVA: 0x12DCC60
	protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes) { }

	// RVA: 0x12DCFA8
	protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes) { }

	// RVA: 0x12DCC6C
	private void InitializeArrays(string[] tabClassNames, Type[] tabClasses, PropertyTabScope[] tabScopes) { }

}

// Namespace: System.ComponentModel
public enum PropertyTabScope
{
	// Fields
	public int value__; // 0x10
	public const PropertyTabScope Static = 0;
	public const PropertyTabScope Global = 1;
	public const PropertyTabScope Document = 2;
	public const PropertyTabScope Component = 3;
}

// Namespace: System.ComponentModel
public class ToolboxItemAttribute
{
	// Fields
	private Type _toolboxItemType; // 0x10
	private string _toolboxItemTypeName; // 0x18
	public static readonly ToolboxItemAttribute Default; // 0x0
	public static readonly ToolboxItemAttribute None; // 0x8

	// Methods

	// RVA: 0x12DCFB8
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12DD02C
	public void .ctor(bool defaultType) { }

	// RVA: 0x12DD0A8
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x12DD164
	public void .ctor(Type toolboxItemType) { }

	// RVA: 0x12DD1C4
	public Type get_ToolboxItemType() { }

	// RVA: 0x12DD3A4
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x12DD410
	public override bool Equals(object obj) { }

	// RVA: 0x12DD540
	public override int GetHashCode() { }

	// RVA: 0x12DD564
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class DesignTimeVisibleAttribute
{
	// Fields
	private readonly bool <Visible>k__BackingField; // 0x10
	public static readonly DesignTimeVisibleAttribute Yes; // 0x0
	public static readonly DesignTimeVisibleAttribute No; // 0x8
	public static readonly DesignTimeVisibleAttribute Default; // 0x10

	// Methods

	// RVA: 0x12DD638
	public void .ctor(bool visible) { }

	// RVA: 0x12DD664
	public void .ctor() { }

	// RVA: 0x12DD66C
	public bool get_Visible() { }

	// RVA: 0x12DD674
	public override bool Equals(object obj) { }

	// RVA: 0x12DD724
	public override int GetHashCode() { }

	// RVA: 0x12DD7E4
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12DD88C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class DoubleConverter
{
	// Methods

	// RVA: 0x12DD940
	internal override bool get_AllowHex() { }

	// RVA: 0x12DD948
	internal override Type get_TargetType() { }

	// RVA: 0x12DD9E8
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12DDAB0
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12DDB2C
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12DDBE4
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class EditorAttribute
{
	// Fields
	private string _typeId; // 0x10
	private readonly string <EditorBaseTypeName>k__BackingField; // 0x18
	private readonly string <EditorTypeName>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12DDBEC
	public void .ctor() { }

	// RVA: 0x12DDC70
	public void .ctor(string typeName, string baseTypeName) { }

	// RVA: 0x12DDD48
	public void .ctor(string typeName, Type baseType) { }

	// RVA: 0x12DDE3C
	public void .ctor(Type type, Type baseType) { }

	// RVA: 0x12DDEC0
	public string get_EditorBaseTypeName() { }

	// RVA: 0x12DDEC8
	public string get_EditorTypeName() { }

	// RVA: 0x12DDED0
	public override object get_TypeId() { }

	// RVA: 0x12DDF8C
	public override bool Equals(object obj) { }

	// RVA: 0x12DE054
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public abstract class EventDescriptor
{
	// Methods

	// RVA: 0x12DE05C
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x12DE064
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x12DE06C
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1
	public abstract Type get_ComponentType() { }

	// RVA: -1
	public abstract Type get_EventType() { }

	// RVA: -1
	public abstract bool get_IsMulticast() { }

	// RVA: -1
	public abstract void AddEventHandler(object component, Delegate value) { }

	// RVA: -1
	public abstract void RemoveEventHandler(object component, Delegate value) { }

}

// Namespace: 
private class ArraySubsetEnumerator
{
	// Fields
	private readonly Array _array; // 0x10
	private readonly int _total; // 0x18
	private int _current; // 0x1C

	// Methods

	// RVA: 0x12DEF40
	public void .ctor(Array array, int count) { }

	// RVA: 0x12DF820
	public bool MoveNext() { }

	// RVA: 0x12DF844
	public void Reset() { }

	// RVA: 0x12DF850
	public object get_Current() { }

}

// Namespace: System.ComponentModel
public class EventDescriptorCollection
{
	// Fields
	private EventDescriptor[] _events; // 0x10
	private string[] _namedSort; // 0x18
	private readonly IComparer _comparer; // 0x20
	private bool _eventsOwned; // 0x28
	private bool _needSort; // 0x29
	private readonly bool _readOnly; // 0x2A
	public static readonly EventDescriptorCollection Empty; // 0x0
	private int <Count>k__BackingField; // 0x2C

	// Methods

	// RVA: 0x12DE074
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x12DE1A4
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	// RVA: 0x12DE1CC
	private void .ctor(EventDescriptor[] events, int eventCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x12DE2EC
	public int get_Count() { }

	// RVA: 0x12DE2F4
	private void set_Count(int value) { }

	// RVA: 0x12DE2FC
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x12DE44C
	public virtual EventDescriptor get_Item(string name) { }

	// RVA: 0x12DE460
	public int Add(EventDescriptor value) { }

	// RVA: 0x12DE654
	public void Clear() { }

	// RVA: 0x12DE6AC
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x12DE780
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x12DE384
	private void EnsureEventsOwned() { }

	// RVA: 0x12DE534
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x12DEAE8
	public virtual EventDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x12DE71C
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x12DEC10
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x12DED04
	public void Remove(EventDescriptor value) { }

	// RVA: 0x12DEDC8
	public void RemoveAt(int index) { }

	// RVA: 0x12DEE90
	public IEnumerator GetEnumerator() { }

	// RVA: 0x12DEF8C
	public virtual EventDescriptorCollection Sort() { }

	// RVA: 0x12DF010
	public virtual EventDescriptorCollection Sort(string[] names) { }

	// RVA: 0x12DF098
	public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x12DF120
	public virtual EventDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x12DE7C8
	protected void InternalSort(string[] names) { }

	// RVA: 0x12DF1A4
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x12DF244
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12DF24C
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12DF254
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12DF25C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12DF260
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12DF270
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12DF3F4
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12DF484
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12DF554
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12DF5AC
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12DF670
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12DF708
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12DF798
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12DF79C
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12DF7A4
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12DF7AC
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ExpandableObjectConverter
{
	// Methods

	// RVA: 0x12DF8B8
	public void .ctor() { }

	// RVA: 0x12DF8C0
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12DF92C
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor
{
	// Fields
	private readonly ReflectPropertyDescriptor _extenderInfo; // 0x88
	private readonly IExtenderProvider _provider; // 0x90

	// Methods

	// RVA: 0x12DF934
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x12DFBC4
	public void .ctor(PropertyDescriptor extender, Attribute[] attributes) { }

	// RVA: 0x12DFD0C
	public override bool CanResetValue(object comp) { }

	// RVA: 0x12DFD38
	public override Type get_ComponentType() { }

	// RVA: 0x12DFD60
	public override bool get_IsReadOnly() { }

	// RVA: 0x12DFE54
	public override Type get_PropertyType() { }

	// RVA: 0x12DFE7C
	public override string get_DisplayName() { }

	// RVA: 0x12E0074
	public override object GetValue(object comp) { }

	// RVA: 0x12E00A0
	public override void ResetValue(object comp) { }

	// RVA: 0x12E00CC
	public override void SetValue(object component, object value) { }

	// RVA: 0x12E00FC
	public override bool ShouldSerializeValue(object comp) { }

}

// Namespace: System.ComponentModel
public sealed class ExtenderProvidedPropertyAttribute
{
	// Fields
	private PropertyDescriptor <ExtenderProperty>k__BackingField; // 0x10
	private IExtenderProvider <Provider>k__BackingField; // 0x18
	private Type <ReceiverType>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12DFB18
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x12E0128
	public void .ctor() { }

	// RVA: 0x12E0130
	public PropertyDescriptor get_ExtenderProperty() { }

	// RVA: 0x12E0138
	private void set_ExtenderProperty(PropertyDescriptor value) { }

	// RVA: 0x12E0140
	public IExtenderProvider get_Provider() { }

	// RVA: 0x12E0148
	private void set_Provider(IExtenderProvider value) { }

	// RVA: 0x12E0150
	public Type get_ReceiverType() { }

	// RVA: 0x12E0158
	private void set_ReceiverType(Type value) { }

	// RVA: 0x12E0160
	public override bool Equals(object obj) { }

	// RVA: 0x12E025C
	public override int GetHashCode() { }

	// RVA: 0x12E0264
	public override bool IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class GuidConverter
{
	// Methods

	// RVA: 0x12E02D0
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12E039C
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12E0468
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12E0558
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12E08BC
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class HandledEventArgs
{
	// Fields
	private bool <Handled>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12E08C4
	public void .ctor() { }

	// RVA: 0x12E0930
	public void .ctor(bool defaultHandledValue) { }

	// RVA: 0x12E09A0
	public bool get_Handled() { }

	// RVA: 0x12E09A8
	public void set_Handled(bool value) { }

}

// Namespace: System.ComponentModel
public sealed class HandledEventHandler
{
	// Methods

	// RVA: 0x12E09B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E0AD4
	public virtual void Invoke(object sender, HandledEventArgs e) { }

	// RVA: 0x12E0AE8
	public virtual IAsyncResult BeginInvoke(object sender, HandledEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12E0B44
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public interface IBindingList
{
	// Methods

	// RVA: -1
	public abstract bool get_AllowNew() { }

	// RVA: -1
	public abstract object AddNew() { }

	// RVA: -1
	public abstract bool get_AllowEdit() { }

	// RVA: -1
	public abstract bool get_AllowRemove() { }

	// RVA: -1
	public abstract bool get_SupportsChangeNotification() { }

	// RVA: -1
	public abstract bool get_SupportsSearching() { }

	// RVA: -1
	public abstract bool get_SupportsSorting() { }

	// RVA: -1
	public abstract bool get_IsSorted() { }

	// RVA: -1
	public abstract PropertyDescriptor get_SortProperty() { }

	// RVA: -1
	public abstract ListSortDirection get_SortDirection() { }

	// RVA: -1
	public abstract void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: -1
	public abstract void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: -1
	public abstract void AddIndex(PropertyDescriptor property) { }

	// RVA: -1
	public abstract void ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: -1
	public abstract int Find(PropertyDescriptor property, object key) { }

	// RVA: -1
	public abstract void RemoveIndex(PropertyDescriptor property) { }

	// RVA: -1
	public abstract void RemoveSort() { }

}

// Namespace: System.ComponentModel
public interface IBindingListView
{
	// Methods

	// RVA: -1
	public abstract void ApplySort(ListSortDescriptionCollection sorts) { }

	// RVA: -1
	public abstract string get_Filter() { }

	// RVA: -1
	public abstract void set_Filter(string value) { }

	// RVA: -1
	public abstract ListSortDescriptionCollection get_SortDescriptions() { }

	// RVA: -1
	public abstract void RemoveFilter() { }

	// RVA: -1
	public abstract bool get_SupportsAdvancedSorting() { }

	// RVA: -1
	public abstract bool get_SupportsFiltering() { }

}

// Namespace: System.ComponentModel
public interface ICancelAddNew
{
	// Methods

	// RVA: -1
	public abstract void CancelNew(int itemIndex) { }

	// RVA: -1
	public abstract void EndNew(int itemIndex) { }

}

// Namespace: System.ComponentModel
public interface IComNativeDescriptorHandler
{
	// Methods

	// RVA: -1
	public abstract AttributeCollection GetAttributes(object component) { }

	// RVA: -1
	public abstract string GetClassName(object component) { }

	// RVA: -1
	public abstract TypeConverter GetConverter(object component) { }

	// RVA: -1
	public abstract EventDescriptor GetDefaultEvent(object component) { }

	// RVA: -1
	public abstract PropertyDescriptor GetDefaultProperty(object component) { }

	// RVA: -1
	public abstract object GetEditor(object component, Type baseEditorType) { }

	// RVA: -1
	public abstract string GetName(object component) { }

	// RVA: -1
	public abstract EventDescriptorCollection GetEvents(object component) { }

	// RVA: -1
	public abstract EventDescriptorCollection GetEvents(object component, Attribute[] attributes) { }

	// RVA: -1
	public abstract PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	// RVA: -1
	public abstract object GetPropertyValue(object component, string propertyName, bool success) { }

	// RVA: -1
	public abstract object GetPropertyValue(object component, int dispid, bool success) { }

}

// Namespace: System.ComponentModel
public interface ICustomTypeDescriptor
{
	// Methods

	// RVA: -1
	public abstract AttributeCollection GetAttributes() { }

	// RVA: -1
	public abstract string GetClassName() { }

	// RVA: -1
	public abstract string GetComponentName() { }

	// RVA: -1
	public abstract TypeConverter GetConverter() { }

	// RVA: -1
	public abstract EventDescriptor GetDefaultEvent() { }

	// RVA: -1
	public abstract PropertyDescriptor GetDefaultProperty() { }

	// RVA: -1
	public abstract object GetEditor(Type editorBaseType) { }

	// RVA: -1
	public abstract EventDescriptorCollection GetEvents() { }

	// RVA: -1
	public abstract EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: -1
	public abstract PropertyDescriptorCollection GetProperties() { }

	// RVA: -1
	public abstract PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: -1
	public abstract object GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: System.ComponentModel
public interface IDataErrorInfo
{
	// Methods

	// RVA: -1
	public abstract string get_Item(string columnName) { }

	// RVA: -1
	public abstract string get_Error() { }

}

// Namespace: System.ComponentModel
public interface IExtenderProvider
{
	// Methods

	// RVA: -1
	public abstract bool CanExtend(object extendee) { }

}

// Namespace: System.ComponentModel
public interface IIntellisenseBuilder
{
	// Methods

	// RVA: -1
	public abstract string get_Name() { }

	// RVA: -1
	public abstract bool Show(string language, string value, string newValue) { }

}

// Namespace: System.ComponentModel
public interface IListSource
{
	// Methods

	// RVA: -1
	public abstract bool get_ContainsListCollection() { }

	// RVA: -1
	public abstract IList GetList() { }

}

// Namespace: System.ComponentModel
public interface INestedContainer
{
	// Methods

	// RVA: -1
	public abstract IComponent get_Owner() { }

}

// Namespace: System.ComponentModel
public interface INestedSite
{
	// Methods

	// RVA: -1
	public abstract string get_FullName() { }

}

// Namespace: System.ComponentModel
public interface IRaiseItemChangedEvents
{
	// Methods

	// RVA: -1
	public abstract bool get_RaisesItemChangedEvents() { }

}

// Namespace: System.ComponentModel
public interface ISupportInitializeNotification
{
	// Methods

	// RVA: -1
	public abstract bool get_IsInitialized() { }

	// RVA: -1
	public abstract void add_Initialized(EventHandler value) { }

	// RVA: -1
	public abstract void remove_Initialized(EventHandler value) { }

}

// Namespace: System.ComponentModel
public interface ITypeDescriptorContext
{
	// Methods

	// RVA: -1
	public abstract IContainer get_Container() { }

	// RVA: -1
	public abstract object get_Instance() { }

	// RVA: -1
	public abstract PropertyDescriptor get_PropertyDescriptor() { }

	// RVA: -1
	public abstract bool OnComponentChanging() { }

	// RVA: -1
	public abstract void OnComponentChanged() { }

}

// Namespace: System.ComponentModel
public interface ITypedList
{
	// Methods

	// RVA: -1
	public abstract string GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: -1
	public abstract PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors) { }

}

// Namespace: System.ComponentModel
public class InstallerTypeAttribute
{
	// Fields
	private string _typeName; // 0x10

	// Methods

	// RVA: 0x12E0B50
	public void .ctor(Type installerType) { }

	// RVA: 0x12E0BA0
	public void .ctor(string typeName) { }

	// RVA: 0x12E0BD4
	public virtual Type get_InstallerType() { }

	// RVA: 0x12E0C68
	public override bool Equals(object obj) { }

	// RVA: 0x12E0D24
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public abstract class InstanceCreationEditor
{
	// Methods

	// RVA: 0x12E0D2C
	public virtual string get_Text() { }

	// RVA: -1
	public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType) { }

	// RVA: 0x12E0D70
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int16Converter
{
	// Methods

	// RVA: 0x12E0D78
	internal override Type get_TargetType() { }

	// RVA: 0x12E0E18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12E0EB4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E0F30
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E0FE8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int32Converter
{
	// Methods

	// RVA: 0x12E0FF0
	internal override Type get_TargetType() { }

	// RVA: 0x12E1090
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12E112C
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E11A8
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E1260
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class Int64Converter
{
	// Methods

	// RVA: 0x12E1268
	internal override Type get_TargetType() { }

	// RVA: 0x12E1308
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12E13A4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E1420
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12E14D8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidAsynchronousStateException
{
	// Methods

	// RVA: 0x12E14E0
	public void .ctor() { }

	// RVA: 0x12E14EC
	public void .ctor(string message) { }

	// RVA: 0x12E14F4
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12E14FC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
private class LicFileLicense
{
	// Fields
	private LicFileLicenseProvider _owner; // 0x10
	private readonly string <LicenseKey>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12E1A6C
	public void .ctor(LicFileLicenseProvider owner, string key) { }

	// RVA: 0x12E1AD4
	public override string get_LicenseKey() { }

	// RVA: 0x12E1ADC
	public override void Dispose() { }

}

// Namespace: System.ComponentModel
public class LicFileLicenseProvider
{
	// Methods

	// RVA: 0x12E1504
	protected virtual bool IsKeyValid(string key, Type type) { }

	// RVA: 0x12E154C
	protected virtual string GetKey(Type type) { }

	// RVA: 0x12E160C
	public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) { }

	// RVA: 0x12E1ABC
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class License
{
	// Methods

	// RVA: -1
	public abstract string get_LicenseKey() { }

	// RVA: -1
	public abstract void Dispose() { }

	// RVA: 0x12E1ACC
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public class LicenseContext
{
	// Methods

	// RVA: 0x12E1B64
	public virtual LicenseUsageMode get_UsageMode() { }

	// RVA: 0x12E1B6C
	public virtual string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x12E1B74
	public virtual object GetService(Type type) { }

	// RVA: 0x12E1B7C
	public virtual void SetSavedLicenseKey(Type type, string key) { }

	// RVA: 0x12E1B80
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class LicenseManager
{
	// Fields
	private static readonly object s_selfLock; // 0x0
	private static LicenseContext s_context; // 0x8
	private static object s_contextLockHolder; // 0x10
	private static Hashtable s_providers; // 0x18
	private static Hashtable s_providerInstances; // 0x20
	private static readonly object s_internalSyncObject; // 0x28

	// Methods

	// RVA: 0x12E1B88
	private void .ctor() { }

	// RVA: 0x12E1B90
	public static LicenseContext get_CurrentContext() { }

	// RVA: 0x12E1D80
	public static void set_CurrentContext(LicenseContext value) { }

	// RVA: 0x12E1F20
	public static LicenseUsageMode get_UsageMode() { }

	// RVA: 0x12E1FE4
	private static void CacheProvider(Type type, LicenseProvider provider) { }

	// RVA: 0x12E220C
	public static object CreateWithContext(Type type, LicenseContext creationContext) { }

	// RVA: 0x12E230C
	public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args) { }

	// RVA: 0x12E2778
	private static bool GetCachedNoLicenseProvider(Type type) { }

	// RVA: 0x12E2854
	private static LicenseProvider GetCachedProvider(Type type) { }

	// RVA: 0x12E2954
	private static LicenseProvider GetCachedProviderInstance(Type providerType) { }

	// RVA: 0x12E2A54
	public static bool IsLicensed(Type type) { }

	// RVA: 0x12E2BF0
	public static bool IsValid(Type type) { }

	// RVA: 0x12E2CF4
	public static bool IsValid(Type type, object instance, License license) { }

	// RVA: 0x12E25E8
	public static void LockContext(object contextUser) { }

	// RVA: 0x12E2DE4
	public static void UnlockContext(object contextUser) { }

	// RVA: 0x12E2B58
	private static bool ValidateInternal(Type type, object instance, bool allowExceptions, License license) { }

	// RVA: 0x12E2F78
	private static bool ValidateInternalRecursive(LicenseContext context, Type type, object instance, bool allowExceptions, License license, string licenseKey) { }

	// RVA: 0x12E3464
	public static void Validate(Type type) { }

	// RVA: 0x12E359C
	public static License Validate(Type type, object instance) { }

	// RVA: 0x12E36CC
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public abstract class LicenseProvider
{
	// Methods

	// RVA: -1
	public abstract License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions) { }

	// RVA: 0x12E1AC4
	protected void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class LicenseProviderAttribute
{
	// Fields
	public static readonly LicenseProviderAttribute Default; // 0x0
	private Type _licenseProviderType; // 0x10
	private string _licenseProviderName; // 0x18

	// Methods

	// RVA: 0x12E377C
	public void .ctor() { }

	// RVA: 0x12E37AC
	public void .ctor(string typeName) { }

	// RVA: 0x12E37E0
	public void .ctor(Type type) { }

	// RVA: 0x12E334C
	public Type get_LicenseProvider() { }

	// RVA: 0x12E3814
	public override object get_TypeId() { }

	// RVA: 0x12E38F0
	public override bool Equals(object value) { }

	// RVA: 0x12E3A34
	public override int GetHashCode() { }

	// RVA: 0x12E3A3C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public enum LicenseUsageMode
{
	// Fields
	public int value__; // 0x10
	public const LicenseUsageMode Runtime = 0;
	public const LicenseUsageMode Designtime = 1;
}

// Namespace: System.ComponentModel
public sealed class ListBindableAttribute
{
	// Fields
	public static readonly ListBindableAttribute Yes; // 0x0
	public static readonly ListBindableAttribute No; // 0x8
	public static readonly ListBindableAttribute Default; // 0x10
	private bool _isDefault; // 0x10
	private readonly bool <ListBindable>k__BackingField; // 0x11

	// Methods

	// RVA: 0x12E3AB8
	public void .ctor(bool listBindable) { }

	// RVA: 0x12E3AE4
	public void .ctor(BindableSupport flags) { }

	// RVA: 0x12E3B24
	public bool get_ListBindable() { }

	// RVA: 0x12E3B2C
	public override bool Equals(object obj) { }

	// RVA: 0x12E3BDC
	public override int GetHashCode() { }

	// RVA: 0x12E3BE4
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12E3C80
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ListChangedEventArgs
{
	// Fields
	private readonly ListChangedType <ListChangedType>k__BackingField; // 0x10
	private readonly int <NewIndex>k__BackingField; // 0x14
	private readonly int <OldIndex>k__BackingField; // 0x18
	private readonly PropertyDescriptor <PropertyDescriptor>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12E3D34
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x12E3E3C
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x12E3ED8
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x12E3DB8
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	// RVA: 0x12E3F60
	public ListChangedType get_ListChangedType() { }

	// RVA: 0x12E3F68
	public int get_NewIndex() { }

	// RVA: 0x12E3F70
	public int get_OldIndex() { }

	// RVA: 0x12E3F78
	public PropertyDescriptor get_PropertyDescriptor() { }

}

// Namespace: System.ComponentModel
public sealed class ListChangedEventHandler
{
	// Methods

	// RVA: 0x12E3F80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E40A4
	public virtual void Invoke(object sender, ListChangedEventArgs e) { }

	// RVA: 0x12E40B8
	public virtual IAsyncResult BeginInvoke(object sender, ListChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12E4114
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public enum ListChangedType
{
	// Fields
	public int value__; // 0x10
	public const ListChangedType Reset = 0;
	public const ListChangedType ItemAdded = 1;
	public const ListChangedType ItemDeleted = 2;
	public const ListChangedType ItemMoved = 3;
	public const ListChangedType ItemChanged = 4;
	public const ListChangedType PropertyDescriptorAdded = 5;
	public const ListChangedType PropertyDescriptorDeleted = 6;
	public const ListChangedType PropertyDescriptorChanged = 7;
}

// Namespace: System.ComponentModel
public class ListSortDescription
{
	// Fields
	private PropertyDescriptor <PropertyDescriptor>k__BackingField; // 0x10
	private ListSortDirection <SortDirection>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12E4120
	public void .ctor(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0x12E4168
	public PropertyDescriptor get_PropertyDescriptor() { }

	// RVA: 0x12E4170
	public void set_PropertyDescriptor(PropertyDescriptor value) { }

	// RVA: 0x12E4178
	public ListSortDirection get_SortDirection() { }

	// RVA: 0x12E4180
	public void set_SortDirection(ListSortDirection value) { }

}

// Namespace: System.ComponentModel
public class ListSortDescriptionCollection
{
	// Fields
	private ArrayList _sorts; // 0x10

	// Methods

	// RVA: 0x12E4188
	public void .ctor() { }

	// RVA: 0x12E4200
	public void .ctor(ListSortDescription[] sorts) { }

	// RVA: 0x12E42CC
	public ListSortDescription get_Item(int index) { }

	// RVA: 0x12E4370
	public void set_Item(int index, ListSortDescription value) { }

	// RVA: 0x12E43C4
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12E43CC
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12E43D4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12E4478
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12E44CC
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12E4520
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12E4574
	public bool Contains(object value) { }

	// RVA: 0x12E462C
	public int IndexOf(object value) { }

	// RVA: 0x12E46E4
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12E4738
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12E478C
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12E47E0
	public int get_Count() { }

	// RVA: 0x12E4808
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12E4810
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12E4814
	public void CopyTo(Array array, int index) { }

	// RVA: 0x12E483C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.ComponentModel
public enum ListSortDirection
{
	// Fields
	public int value__; // 0x10
	public const ListSortDirection Ascending = 0;
	public const ListSortDirection Descending = 1;
}

// Namespace: System.ComponentModel
public sealed class LookupBindingPropertiesAttribute
{
	// Fields
	private readonly string <DataSource>k__BackingField; // 0x10
	private readonly string <DisplayMember>k__BackingField; // 0x18
	private readonly string <ValueMember>k__BackingField; // 0x20
	private readonly string <LookupMember>k__BackingField; // 0x28
	public static readonly LookupBindingPropertiesAttribute Default; // 0x0

	// Methods

	// RVA: 0x12E4864
	public void .ctor() { }

	// RVA: 0x12E48C4
	public void .ctor(string dataSource, string displayMember, string valueMember, string lookupMember) { }

	// RVA: 0x12E4944
	public string get_DataSource() { }

	// RVA: 0x12E494C
	public string get_DisplayMember() { }

	// RVA: 0x12E4954
	public string get_ValueMember() { }

	// RVA: 0x12E495C
	public string get_LookupMember() { }

	// RVA: 0x12E4964
	public override bool Equals(object obj) { }

	// RVA: 0x12E4A24
	public override int GetHashCode() { }

	// RVA: 0x12E4A2C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class MarshalByValueComponent
{
	// Fields
	private static readonly object s_eventDisposed; // 0x0
	private ISite _site; // 0x10
	private EventHandlerList _events; // 0x18

	// Methods

	// RVA: 0x12E4AD8
	public void .ctor() { }

	// RVA: 0x12E4AE0
	protected override void Finalize() { }

	// RVA: 0x12E4B7C
	public void add_Disposed(EventHandler value) { }

	// RVA: 0x12E4D08
	public void remove_Disposed(EventHandler value) { }

	// RVA: 0x12E4C7C
	protected EventHandlerList get_Events() { }

	// RVA: 0x12E4E08
	public virtual ISite get_Site() { }

	// RVA: 0x12E4E10
	public virtual void set_Site(ISite value) { }

	// RVA: 0x12E4E18
	public void Dispose() { }

	// RVA: 0x12E4EA8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12E5154
	public virtual IContainer get_Container() { }

	// RVA: 0x12E5218
	public virtual object GetService(Type service) { }

	// RVA: 0x12E52DC
	public virtual bool get_DesignMode() { }

	// RVA: 0x12E53A0
	public override string ToString() { }

	// RVA: 0x12E54E0
	private static void .cctor() { }

}

// Namespace: 
private enum CaseConversion
{
	// Fields
	public int value__; // 0x10
	public const CaseConversion None = 0;
	public const CaseConversion ToLower = 1;
	public const CaseConversion ToUpper = 2;
}

// Namespace: 
private enum CharType
{
	// Fields
	public int value__; // 0x10
	public const CharType EditOptional = 1;
	public const CharType EditRequired = 2;
	public const CharType Separator = 4;
	public const CharType Literal = 8;
	public const CharType Modifier = 16;
}

// Namespace: 
private class CharDescriptor
{
	// Fields
	public int MaskPosition; // 0x10
	public CaseConversion CaseConversion; // 0x14
	public CharType CharType; // 0x18
	public bool IsAssigned; // 0x1C

	// Methods

	// RVA: 0x12E5F84
	public void .ctor(int maskPos, CharType charType) { }

	// RVA: 0x12EBE20
	public override string ToString() { }

}

// Namespace: System.ComponentModel
public class MaskedTextProvider
{
	// Fields
	private const Char SPACE_CHAR = 32;
	private const Char DEFAULT_PROMPT_CHAR = 95;
	private const Char NULL_PASSWORD_CHAR = 0;
	private const bool DEFAULT_ALLOW_PROMPT = 1;
	private const int INVALID_INDEX = 4294967295;
	private const Byte EDIT_ANY = 0;
	private const Byte EDIT_UNASSIGNED = 1;
	private const Byte EDIT_ASSIGNED = 2;
	private const bool FORWARD = 1;
	private const bool BACKWARD = 0;
	private static int s_ASCII_ONLY; // 0x0
	private static int s_ALLOW_PROMPT_AS_INPUT; // 0x4
	private static int s_INCLUDE_PROMPT; // 0x8
	private static int s_INCLUDE_LITERALS; // 0xC
	private static int s_RESET_ON_PROMPT; // 0x10
	private static int s_RESET_ON_LITERALS; // 0x14
	private static int s_SKIP_SPACE; // 0x18
	private static Type s_maskTextProviderType; // 0x20
	private BitVector32 _flagState; // 0x10
	private StringBuilder _testString; // 0x18
	private int _requiredCharCount; // 0x20
	private int _requiredEditChars; // 0x24
	private int _optionalEditChars; // 0x28
	private Char _passwordChar; // 0x2C
	private Char _promptChar; // 0x2E
	private System.Collections.Generic.List<System.ComponentModel.MaskedTextProvider.CharDescriptor> _stringDescriptor; // 0x30
	private int <AssignedEditPositionCount>k__BackingField; // 0x38
	private readonly CultureInfo <Culture>k__BackingField; // 0x40
	private readonly string <Mask>k__BackingField; // 0x48

	// Methods

	// RVA: 0x12E5568
	public void .ctor(string mask) { }

	// RVA: 0x12E59C0
	public void .ctor(string mask, bool restrictToAscii) { }

	// RVA: 0x12E59D8
	public void .ctor(string mask, CultureInfo culture) { }

	// RVA: 0x12E59EC
	public void .ctor(string mask, CultureInfo culture, bool restrictToAscii) { }

	// RVA: 0x12E5A00
	public void .ctor(string mask, Char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x12E5A14
	public void .ctor(string mask, CultureInfo culture, Char passwordChar, bool allowPromptAsInput) { }

	// RVA: 0x12E5580
	public void .ctor(string mask, CultureInfo culture, bool allowPromptAsInput, Char promptChar, Char passwordChar, bool restrictToAscii) { }

	// RVA: 0x12E5B2C
	private void Initialize() { }

	// RVA: 0x12E5FE8
	public bool get_AllowPromptAsInput() { }

	// RVA: 0x12E605C
	public int get_AssignedEditPositionCount() { }

	// RVA: 0x12E6064
	private void set_AssignedEditPositionCount(int value) { }

	// RVA: 0x12E606C
	public int get_AvailableEditPositionCount() { }

	// RVA: 0x12E608C
	public object Clone() { }

	// RVA: 0x12E6F24
	public CultureInfo get_Culture() { }

	// RVA: 0x12E6F2C
	public static Char get_DefaultPasswordChar() { }

	// RVA: 0x12E6080
	public int get_EditPositionCount() { }

	// RVA: 0x12E6F34
	public IEnumerator get_EditPositions() { }

	// RVA: 0x12E6D44
	public bool get_IncludeLiterals() { }

	// RVA: 0x12E6DB8
	public void set_IncludeLiterals(bool value) { }

	// RVA: 0x12E6E34
	public bool get_IncludePrompt() { }

	// RVA: 0x12E6EA8
	public void set_IncludePrompt(bool value) { }

	// RVA: 0x12E69D4
	public bool get_AsciiOnly() { }

	// RVA: 0x12E7238
	public bool get_IsPassword() { }

	// RVA: 0x12E7248
	public void set_IsPassword(bool value) { }

	// RVA: 0x12E7304
	public static int get_InvalidIndex() { }

	// RVA: 0x12E730C
	public int get_LastAssignedPosition() { }

	// RVA: 0x12E7464
	public int get_Length() { }

	// RVA: 0x12E7484
	public string get_Mask() { }

	// RVA: 0x12E748C
	public bool get_MaskCompleted() { }

	// RVA: 0x12E749C
	public bool get_MaskFull() { }

	// RVA: 0x12E74B4
	public Char get_PasswordChar() { }

	// RVA: 0x12E74BC
	public void set_PasswordChar(Char value) { }

	// RVA: 0x12E769C
	public Char get_PromptChar() { }

	// RVA: 0x12E76A4
	public void set_PromptChar(Char value) { }

	// RVA: 0x12E6BE8
	public bool get_ResetOnPrompt() { }

	// RVA: 0x12E6A48
	public void set_ResetOnPrompt(bool value) { }

	// RVA: 0x12E6C5C
	public bool get_ResetOnSpace() { }

	// RVA: 0x12E6AC4
	public void set_ResetOnSpace(bool value) { }

	// RVA: 0x12E6CD0
	public bool get_SkipLiterals() { }

	// RVA: 0x12E6B40
	public void set_SkipLiterals(bool value) { }

	// RVA: 0x12E7940
	public Char get_Item(int index) { }

	// RVA: 0x12E7A00
	public bool Add(Char input) { }

	// RVA: 0x12E7A28
	public bool Add(Char input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12E7CE4
	public bool Add(string input) { }

	// RVA: 0x12E7D10
	public bool Add(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12E7E30
	public void Clear() { }

	// RVA: 0x12E7E8C
	public void Clear(MaskedTextResultHint resultHint) { }

	// RVA: 0x12E73DC
	public int FindAssignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12E7FCC
	public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12E7BC8
	public int FindEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12E8184
	public int FindEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12E7FE4
	private int FindEditPositionInRange(int startPosition, int endPosition, bool direction, Byte assignedStatus) { }

	// RVA: 0x12E82DC
	public int FindNonEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12E8340
	public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12E818C
	private int FindPositionInRange(int startPosition, int endPosition, bool direction, CharType charTypeFlags) { }

	// RVA: 0x12E8348
	public int FindUnassignedEditPositionFrom(int position, bool direction) { }

	// RVA: 0x12E83AC
	public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction) { }

	// RVA: 0x12E8538
	public static bool GetOperationResultFromHint(MaskedTextResultHint hint) { }

	// RVA: 0x12E8544
	public bool InsertAt(Char input, int position) { }

	// RVA: 0x12E863C
	public bool InsertAt(Char input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12E8610
	public bool InsertAt(string input, int position) { }

	// RVA: 0x12E86DC
	public bool InsertAt(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12E87C0
	private bool InsertAtInt(string input, int position, int testPosition, MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x12E9560
	private static bool IsAscii(Char c) { }

	// RVA: 0x12E9570
	private static bool IsAciiAlphanumeric(Char c) { }

	// RVA: 0x12E959C
	private static bool IsAlphanumeric(Char c) { }

	// RVA: 0x12E9668
	private static bool IsAsciiLetter(Char c) { }

	// RVA: 0x12E967C
	public bool IsAvailablePosition(int position) { }

	// RVA: 0x12E785C
	public bool IsEditPosition(int position) { }

	// RVA: 0x12E5FC0
	private static bool IsEditPosition(CharDescriptor charDescriptor) { }

	// RVA: 0x12E976C
	private static bool IsLiteralPosition(CharDescriptor charDescriptor) { }

	// RVA: 0x12E5A28
	private static bool IsPrintableChar(Char c) { }

	// RVA: 0x12E9794
	public static bool IsValidInputChar(Char c) { }

	// RVA: 0x12E9814
	public static bool IsValidMaskChar(Char c) { }

	// RVA: 0x12E7630
	public static bool IsValidPasswordChar(Char c) { }

	// RVA: 0x12E9894
	public bool Remove() { }

	// RVA: 0x12E98CC
	public bool Remove(int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12E9930
	public bool RemoveAt(int position) { }

	// RVA: 0x12E99A0
	public bool RemoveAt(int startPosition, int endPosition) { }

	// RVA: 0x12E9A38
	public bool RemoveAt(int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12E9AE0
	private bool RemoveAtInt(int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint, bool testOnly) { }

	// RVA: 0x12E6BBC
	public bool Replace(Char input, int position) { }

	// RVA: 0x12EA108
	public bool Replace(Char input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12EA344
	public bool Replace(Char input, int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12EA878
	public bool Replace(string input, int position) { }

	// RVA: 0x12EA8A4
	public bool Replace(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12EA4D4
	public bool Replace(string input, int startPosition, int endPosition, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12E7EF8
	private void ResetChar(int testPosition) { }

	// RVA: 0x12E9ED8
	private void ResetString(int startPosition, int endPosition) { }

	// RVA: 0x12EA9EC
	public bool Set(string input) { }

	// RVA: 0x12EAA18
	public bool Set(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12E9384
	private void SetChar(Char input, int position) { }

	// RVA: 0x12EAC10
	private void SetChar(Char input, int position, CharDescriptor charDescriptor) { }

	// RVA: 0x12E9410
	private void SetString(string input, int testPosition) { }

	// RVA: 0x12E8DC0
	private bool TestChar(Char input, int position, MaskedTextResultHint resultHint) { }

	// RVA: 0x12EA2B8
	private bool TestEscapeChar(Char input, int position) { }

	// RVA: 0x12EAE08
	private bool TestEscapeChar(Char input, int position, CharDescriptor charDex) { }

	// RVA: 0x12E7C2C
	private bool TestSetChar(Char input, int position, MaskedTextResultHint resultHint) { }

	// RVA: 0x12E7DE4
	private bool TestSetString(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12E8BE4
	private bool TestString(string input, int position, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12EAFE8
	public string ToDisplayString() { }

	// RVA: 0x12EB220
	public override string ToString() { }

	// RVA: 0x12EB7D8
	public string ToString(bool ignorePasswordChar) { }

	// RVA: 0x12EB8D8
	public string ToString(int startPosition, int length) { }

	// RVA: 0x12EB9CC
	public string ToString(bool ignorePasswordChar, int startPosition, int length) { }

	// RVA: 0x12EBAC4
	public string ToString(bool includePrompt, bool includeLiterals) { }

	// RVA: 0x12EBB1C
	public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x12EB31C
	public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length) { }

	// RVA: 0x12EBB34
	public bool VerifyChar(Char input, int position, MaskedTextResultHint hint) { }

	// RVA: 0x12EBBB8
	public bool VerifyEscapeChar(Char input, int position) { }

	// RVA: 0x12EBC78
	public bool VerifyString(string input) { }

	// RVA: 0x12EBCC4
	public bool VerifyString(string input, int testPosition, MaskedTextResultHint resultHint) { }

	// RVA: 0x12EBCF4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public enum MaskedTextResultHint
{
	// Fields
	public int value__; // 0x10
	public const MaskedTextResultHint Unknown = 0;
	public const MaskedTextResultHint CharacterEscaped = 1;
	public const MaskedTextResultHint NoEffect = 2;
	public const MaskedTextResultHint SideEffect = 3;
	public const MaskedTextResultHint Success = 4;
	public const MaskedTextResultHint AsciiCharacterExpected = 4294967295;
	public const MaskedTextResultHint AlphanumericCharacterExpected = 4294967294;
	public const MaskedTextResultHint DigitExpected = 4294967293;
	public const MaskedTextResultHint LetterExpected = 4294967292;
	public const MaskedTextResultHint SignedDigitExpected = 4294967291;
	public const MaskedTextResultHint InvalidInput = 4294967245;
	public const MaskedTextResultHint PromptCharNotAllowed = 4294967244;
	public const MaskedTextResultHint UnavailableEditPosition = 4294967243;
	public const MaskedTextResultHint NonEditPosition = 4294967242;
	public const MaskedTextResultHint PositionOutOfRange = 4294967241;
}

// Namespace: System.ComponentModel
public class MultilineStringConverter
{
	// Methods

	// RVA: 0x12EC078
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12EC228
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12EC230
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12EC238
	public void .ctor() { }

}

// Namespace: 
private class Site
{
	// Fields
	private string _name; // 0x10
	private readonly IComponent <Component>k__BackingField; // 0x18
	private readonly IContainer <Container>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12EC734
	internal void .ctor(IComponent component, NestedContainer container, string name) { }

	// RVA: 0x12EC974
	public IComponent get_Component() { }

	// RVA: 0x12EC97C
	public IContainer get_Container() { }

	// RVA: 0x12EC984
	public object GetService(Type service) { }

	// RVA: 0x12ECA98
	public bool get_DesignMode() { }

	// RVA: 0x12ECC94
	public string get_FullName() { }

	// RVA: 0x12ECD98
	public string get_Name() { }

	// RVA: 0x12ECDA0
	public void set_Name(string value) { }

}

// Namespace: System.ComponentModel
public class NestedContainer
{
	// Fields
	private readonly IComponent <Owner>k__BackingField; // 0x40

	// Methods

	// RVA: 0x12EC240
	public void .ctor(IComponent owner) { }

	// RVA: 0x12EC3B0
	public IComponent get_Owner() { }

	// RVA: 0x12EC3B8
	protected virtual string get_OwnerName() { }

	// RVA: 0x12EC64C
	protected override ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x12EC798
	protected override void Dispose(bool disposing) { }

	// RVA: 0x12EC8A8
	protected override object GetService(Type service) { }

	// RVA: 0x12EC96C
	private void OnOwnerDisposed(object sender, EventArgs e) { }

}

// Namespace: System.ComponentModel
public class NullableConverter
{
	// Fields
	private readonly Type <NullableType>k__BackingField; // 0x10
	private readonly Type <UnderlyingType>k__BackingField; // 0x18
	private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12ECE78
	public void .ctor(Type type) { }

	// RVA: 0x12ECFC8
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12ED0C4
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12ED238
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12ED334
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12ED570
	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x12ED594
	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12ED5B8
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12ED5DC
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12ED600
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12ED9B8
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12ED9E0
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12EDA08
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x12EDA3C
	public Type get_NullableType() { }

	// RVA: 0x12EDA44
	public Type get_UnderlyingType() { }

	// RVA: 0x12EDA4C
	public TypeConverter get_UnderlyingTypeConverter() { }

}

// Namespace: System.ComponentModel
public sealed class PasswordPropertyTextAttribute
{
	// Fields
	public static readonly PasswordPropertyTextAttribute Yes; // 0x0
	public static readonly PasswordPropertyTextAttribute No; // 0x8
	public static readonly PasswordPropertyTextAttribute Default; // 0x10
	private readonly bool <Password>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12EDA54
	public void .ctor() { }

	// RVA: 0x12EDA7C
	public void .ctor(bool password) { }

	// RVA: 0x12EDAA8
	public bool get_Password() { }

	// RVA: 0x12EDAB0
	public override bool Equals(object o) { }

	// RVA: 0x12EDB44
	public override int GetHashCode() { }

	// RVA: 0x12EDB4C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12EDBC0
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public abstract class PropertyDescriptor
{
	// Fields
	private TypeConverter _converter; // 0x60
	private Hashtable _valueChangedHandlers; // 0x68
	private object[] _editors; // 0x70
	private Type[] _editorTypes; // 0x78
	private int _editorCount; // 0x80

	// Methods

	// RVA: 0x12EDC74
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x12EDC7C
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x12DFB10
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1
	public abstract Type get_ComponentType() { }

	// RVA: 0x12EDC84
	public virtual TypeConverter get_Converter() { }

	// RVA: 0x12EE390
	public virtual bool get_IsLocalizable() { }

	// RVA: -1
	public abstract bool get_IsReadOnly() { }

	// RVA: 0x12EE484
	public DesignerSerializationVisibility get_SerializationVisibility() { }

	// RVA: -1
	public abstract Type get_PropertyType() { }

	// RVA: 0x12EE564
	public virtual void AddValueChanged(object component, EventHandler handler) { }

	// RVA: -1
	public abstract bool CanResetValue(object component) { }

	// RVA: 0x12EE6CC
	public override bool Equals(object obj) { }

	// RVA: 0x12EE148
	protected object CreateInstance(Type type) { }

	// RVA: 0x12EE8E0
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x12EE93C
	public PropertyDescriptorCollection GetChildProperties() { }

	// RVA: 0x12EE954
	public PropertyDescriptorCollection GetChildProperties(Attribute[] filter) { }

	// RVA: 0x12EE96C
	public PropertyDescriptorCollection GetChildProperties(object instance) { }

	// RVA: 0x12EE980
	public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter) { }

	// RVA: 0x12EEA38
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x12EEE50
	public override int GetHashCode() { }

	// RVA: 0x12EEEA8
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x12EDF24
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1
	public abstract object GetValue(object component) { }

	// RVA: 0x12EEFA0
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x12EF054
	public virtual void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x12EF1CC
	protected internal EventHandler GetValueChangedHandler(object component) { }

	// RVA: -1
	public abstract void ResetValue(object component) { }

	// RVA: -1
	public abstract void SetValue(object component, object value) { }

	// RVA: -1
	public abstract bool ShouldSerializeValue(object component) { }

	// RVA: 0x12EF268
	public virtual bool get_SupportsChangeEvents() { }

}

// Namespace: 
private class PropertyDescriptorEnumerator
{
	// Fields
	private PropertyDescriptorCollection _owner; // 0x10
	private int _index; // 0x18

	// Methods

	// RVA: 0x12F0BC0
	public void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x12F1980
	public object get_Current() { }

	// RVA: 0x12F1A2C
	public DictionaryEntry get_Entry() { }

	// RVA: 0x12F1AA0
	public object get_Key() { }

	// RVA: 0x12F1AE0
	public object get_Value() { }

	// RVA: 0x12F1B20
	public bool MoveNext() { }

	// RVA: 0x12F1B60
	public void Reset() { }

}

// Namespace: System.ComponentModel
public class PropertyDescriptorCollection
{
	// Fields
	public static readonly PropertyDescriptorCollection Empty; // 0x0
	private IDictionary _cachedFoundProperties; // 0x10
	private bool _cachedIgnoreCase; // 0x18
	private PropertyDescriptor[] _properties; // 0x20
	private readonly string[] _namedSort; // 0x28
	private readonly IComparer _comparer; // 0x30
	private bool _propsOwned; // 0x38
	private bool _needSort; // 0x39
	private bool _readOnly; // 0x3A
	private readonly object _internalSyncObject; // 0x40
	private int <Count>k__BackingField; // 0x48

	// Methods

	// RVA: 0x12EF270
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x12EF3C4
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x12EF3EC
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	// RVA: 0x12EF544
	public int get_Count() { }

	// RVA: 0x12EF54C
	private void set_Count(int value) { }

	// RVA: 0x12EF554
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x12EF6A4
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x12EF6B8
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x12EF8AC
	public void Clear() { }

	// RVA: 0x12EF90C
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x12EF9E0
	public void CopyTo(Array array, int index) { }

	// RVA: 0x12EF5DC
	private void EnsurePropsOwned() { }

	// RVA: 0x12EF78C
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x12EFD48
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x12EF97C
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x12F031C
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x12F0410
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x12F04D4
	public void RemoveAt(int index) { }

	// RVA: 0x12F059C
	public virtual PropertyDescriptorCollection Sort() { }

	// RVA: 0x12F0620
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x12F06A8
	public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer) { }

	// RVA: 0x12F0730
	public virtual PropertyDescriptorCollection Sort(IComparer comparer) { }

	// RVA: 0x12EFA28
	protected void InternalSort(string[] names) { }

	// RVA: 0x12F07B4
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x12F0854
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x12F08F0
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x12F08F8
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12F0900
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x12F0908
	private void System.Collections.IList.Clear() { }

	// RVA: 0x12F0968
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x12F09C8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x12F09D8
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x12F09DC
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x12F0AAC
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x12F0B44
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x12F0BFC
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x12F0C04
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x12F0C0C
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x12F0C98
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x12F108C
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x12F119C
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x12F12A0
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x12F13A4
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x12F1434
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x12F1504
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x12F15C8
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x12F1660
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x12F1668
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x12F1670
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x12F1700
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x12F1710
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x12F190C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class ProvidePropertyAttribute
{
	// Fields
	private readonly string <PropertyName>k__BackingField; // 0x10
	private readonly string <ReceiverTypeName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12F1B6C
	public void .ctor(string propertyName, Type receiverType) { }

	// RVA: 0x12F1BD8
	public void .ctor(string propertyName, string receiverTypeName) { }

	// RVA: 0x12F1C28
	public string get_PropertyName() { }

	// RVA: 0x12F1C30
	public string get_ReceiverTypeName() { }

	// RVA: 0x12F1C38
	public override bool Equals(object obj) { }

	// RVA: 0x12F1D00
	public override int GetHashCode() { }

	// RVA: 0x12F1D50
	public override object get_TypeId() { }

}

// Namespace: System.ComponentModel
public class RecommendedAsConfigurableAttribute
{
	// Fields
	private readonly bool <RecommendedAsConfigurable>k__BackingField; // 0x10
	public static readonly RecommendedAsConfigurableAttribute No; // 0x0
	public static readonly RecommendedAsConfigurableAttribute Yes; // 0x8
	public static readonly RecommendedAsConfigurableAttribute Default; // 0x10

	// Methods

	// RVA: 0x12F1D94
	public void .ctor(bool recommendedAsConfigurable) { }

	// RVA: 0x12F1DC0
	public bool get_RecommendedAsConfigurable() { }

	// RVA: 0x12F1DC8
	public override bool Equals(object obj) { }

	// RVA: 0x12F1E94
	public override int GetHashCode() { }

	// RVA: 0x12F1E9C
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12F1EAC
	private static void .cctor() { }

}

// Namespace: 
private class ReferenceComparer
{
	// Fields
	private ReferenceConverter _converter; // 0x10

	// Methods

	// RVA: 0x12F3034
	public void .ctor(ReferenceConverter converter) { }

	// RVA: 0x12F30F8
	public int Compare(object item1, object item2) { }

}

// Namespace: System.ComponentModel
public class ReferenceConverter
{
	// Fields
	private static readonly string s_none; // 0x0
	private Type _type; // 0x10

	// Methods

	// RVA: 0x12F1F60
	public void .ctor(Type type) { }

	// RVA: 0x12F1F94
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12F2064
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12F23F8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12F28E8
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12F3068
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12F3070
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12F3078
	protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

	// RVA: 0x12F3080
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class ReflectEventDescriptor
{
	// Fields
	private Type _type; // 0x60
	private readonly Type _componentClass; // 0x68
	private MethodInfo _addMethod; // 0x70
	private MethodInfo _removeMethod; // 0x78
	private EventInfo _realEvent; // 0x80
	private bool _filledMethods; // 0x88

	// Methods

	// RVA: 0x12F31AC
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x12F3360
	public void .ctor(Type componentClass, EventInfo eventInfo) { }

	// RVA: 0x12F3518
	public void .ctor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x12F3614
	public override Type get_ComponentType() { }

	// RVA: 0x12F361C
	public override Type get_EventType() { }

	// RVA: 0x12F3B98
	public override bool get_IsMulticast() { }

	// RVA: 0x12F3C4C
	public override void AddEventHandler(object component, Delegate value) { }

	// RVA: 0x12F43F8
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x12F4478
	private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	// RVA: 0x12F3640
	private void FillMethods() { }

	// RVA: 0x12F47F0
	private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }

	// RVA: 0x12F4BA8
	public override void RemoveEventHandler(object component, Delegate value) { }

}

// Namespace: System.ComponentModel
public class RefreshEventArgs
{
	// Fields
	private readonly object <ComponentChanged>k__BackingField; // 0x10
	private readonly Type <TypeChanged>k__BackingField; // 0x18

	// Methods

	// RVA: 0x12F52A4
	public void .ctor(object componentChanged) { }

	// RVA: 0x12F5340
	public void .ctor(Type typeChanged) { }

	// RVA: 0x12F53B8
	public object get_ComponentChanged() { }

	// RVA: 0x12F53C0
	public Type get_TypeChanged() { }

}

// Namespace: System.ComponentModel
public sealed class RefreshEventHandler
{
	// Methods

	// RVA: 0x12F53C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12F54E8
	public virtual void Invoke(RefreshEventArgs e) { }

	// RVA: 0x12F54FC
	public virtual IAsyncResult BeginInvoke(RefreshEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12F554C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class RunInstallerAttribute
{
	// Fields
	private readonly bool <RunInstaller>k__BackingField; // 0x10
	public static readonly RunInstallerAttribute Yes; // 0x0
	public static readonly RunInstallerAttribute No; // 0x8
	public static readonly RunInstallerAttribute Default; // 0x10

	// Methods

	// RVA: 0x12F5558
	public void .ctor(bool runInstaller) { }

	// RVA: 0x12F5584
	public bool get_RunInstaller() { }

	// RVA: 0x12F558C
	public override bool Equals(object obj) { }

	// RVA: 0x12F5658
	public override int GetHashCode() { }

	// RVA: 0x12F5660
	public override bool IsDefaultAttribute() { }

	// RVA: 0x12F56D4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class SByteConverter
{
	// Methods

	// RVA: 0x12F5788
	internal override Type get_TargetType() { }

	// RVA: 0x12F5828
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12F58C4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F5940
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F59F8
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class SettingsBindableAttribute
{
	// Fields
	public static readonly SettingsBindableAttribute Yes; // 0x0
	public static readonly SettingsBindableAttribute No; // 0x8
	private readonly bool <Bindable>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12F5A00
	public void .ctor(bool bindable) { }

	// RVA: 0x12F5A2C
	public bool get_Bindable() { }

	// RVA: 0x12F5A34
	public override bool Equals(object obj) { }

	// RVA: 0x12F5AE4
	public override int GetHashCode() { }

	// RVA: 0x12F5B5C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class SingleConverter
{
	// Methods

	// RVA: 0x12F5BFC
	internal override bool get_AllowHex() { }

	// RVA: 0x12F5C04
	internal override Type get_TargetType() { }

	// RVA: 0x12F5CA4
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12F5D6C
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F5DE8
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F5EA0
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class StringConverter
{
	// Methods

	// RVA: 0x12F5EA8
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12F5F74
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12F601C
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public static class SyntaxCheck
{
	// Methods

	// RVA: 0x12F6024
	public static bool CheckMachineName(string value) { }

	// RVA: 0x12F60C4
	public static bool CheckPath(string value) { }

	// RVA: 0x12F616C
	public static bool CheckRootedPath(string value) { }

}

// Namespace: System.ComponentModel
public class TimeSpanConverter
{
	// Methods

	// RVA: 0x12F6234
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12F6300
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12F63CC
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12F65D0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12F6910
	public void .ctor() { }

}

// Namespace: System.ComponentModel
[Serializable]
public sealed class ToolboxItemFilterAttribute
{
	// Fields
	private string _typeId; // 0x10
	private readonly string <FilterString>k__BackingField; // 0x18
	private readonly ToolboxItemFilterType <FilterType>k__BackingField; // 0x20

	// Methods

	// RVA: 0x12F6918
	public void .ctor(string filterString) { }

	// RVA: 0x12F69B4
	public void .ctor(string filterString, ToolboxItemFilterType filterType) { }

	// RVA: 0x12F6A54
	public string get_FilterString() { }

	// RVA: 0x12F6A5C
	public ToolboxItemFilterType get_FilterType() { }

	// RVA: 0x12F6A64
	public override object get_TypeId() { }

	// RVA: 0x12F6AEC
	public override bool Equals(object obj) { }

	// RVA: 0x12F6C10
	public override int GetHashCode() { }

	// RVA: 0x12F6C34
	public override bool Match(object obj) { }

	// RVA: 0x12F6CC0
	public override string ToString() { }

}

// Namespace: System.ComponentModel
public enum ToolboxItemFilterType
{
	// Fields
	public int value__; // 0x10
	public const ToolboxItemFilterType Allow = 0;
	public const ToolboxItemFilterType Custom = 1;
	public const ToolboxItemFilterType Prevent = 2;
	public const ToolboxItemFilterType Require = 3;
}

// Namespace: System.ComponentModel
public sealed class TypeConverterAttribute
{
	// Fields
	public static readonly TypeConverterAttribute Default; // 0x0
	private readonly string <ConverterTypeName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12F6DE0
	public void .ctor() { }

	// RVA: 0x12F6E4C
	public void .ctor(Type type) { }

	// RVA: 0x12F6E9C
	public void .ctor(string typeName) { }

	// RVA: 0x12F6ED0
	public string get_ConverterTypeName() { }

	// RVA: 0x12F6ED8
	public override bool Equals(object obj) { }

	// RVA: 0x12F6F5C
	public override int GetHashCode() { }

	// RVA: 0x12F6F80
	private static void .cctor() { }

}

// Namespace: 
private sealed class EmptyCustomTypeDescriptor
{
	// Methods

	// RVA: 0x12F724C
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public abstract class TypeDescriptionProvider
{
	// Fields
	private readonly TypeDescriptionProvider _parent; // 0x10
	private EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x12DB6F4
	protected void .ctor() { }

	// RVA: 0x12F7038
	protected void .ctor(TypeDescriptionProvider parent) { }

	// RVA: 0x12F706C
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x12F717C
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x12F7194
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x12F7254
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x12F73B0
	public virtual string GetFullComponentName(object component) { }

	// RVA: 0x12F7534
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x12F7544
	public Type GetReflectionType(object instance) { }

	// RVA: 0x12F75D0
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x12F75EC
	public virtual Type GetRuntimeType(Type reflectionType) { }

	// RVA: 0x12F7778
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x12F74A8
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x12F7788
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x12F7848
	public virtual bool IsSupportedType(Type type) { }

}

// Namespace: System.ComponentModel
public sealed class TypeDescriptionProviderAttribute
{
	// Fields
	private readonly string <TypeName>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12F794C
	public void .ctor(string typeName) { }

	// RVA: 0x12F79CC
	public void .ctor(Type type) { }

	// RVA: 0x12F7AE8
	public string get_TypeName() { }

}

// Namespace: System.ComponentModel
public abstract class TypeListConverter
{
	// Fields
	private readonly Type[] _types; // 0x10
	private StandardValuesCollection _values; // 0x18

	// Methods

	// RVA: 0x12F7AF0
	protected void .ctor(Type[] types) { }

	// RVA: 0x12F7B24
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12F7BF0
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12F7CBC
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12F7DD0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12F7FB4
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x12F8098
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x12F80A0
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

}

// Namespace: System.ComponentModel
public class UInt16Converter
{
	// Methods

	// RVA: 0x12F80A8
	internal override Type get_TargetType() { }

	// RVA: 0x12F8148
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12F81E4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F8260
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F8318
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt32Converter
{
	// Methods

	// RVA: 0x12F8320
	internal override Type get_TargetType() { }

	// RVA: 0x12F83C0
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12F845C
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F84D8
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F8590
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class UInt64Converter
{
	// Methods

	// RVA: 0x12F8598
	internal override Type get_TargetType() { }

	// RVA: 0x12F8638
	internal override object FromString(string value, int radix) { }

	// RVA: 0x12F86D4
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F8750
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x12F8808
	public void .ctor() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class WarningException
{
	// Fields
	private readonly string <HelpUrl>k__BackingField; // 0x90
	private readonly string <HelpTopic>k__BackingField; // 0x98

	// Methods

	// RVA: 0x12F8810
	public void .ctor() { }

	// RVA: 0x12F88A4
	public void .ctor(string message) { }

	// RVA: 0x12F88E4
	public void .ctor(string message, string helpUrl) { }

	// RVA: 0x12F8928
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x12F8854
	public void .ctor(string message, string helpUrl, string helpTopic) { }

	// RVA: 0x12F8930
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12F8AD8
	public string get_HelpUrl() { }

	// RVA: 0x12F8AE0
	public string get_HelpTopic() { }

	// RVA: 0x12F8AE8
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

// Namespace: System.ComponentModel
public class CancelEventArgs
{
	// Fields
	private bool <Cancel>k__BackingField; // 0x10

	// Methods

	// RVA: 0x12F8BA0
	public bool get_Cancel() { }

	// RVA: 0x12F8BA8
	public void set_Cancel(bool value) { }

	// RVA: 0x12F8BB0
	public void .ctor() { }

	// RVA: 0x12F8C38
	public void .ctor(bool cancel) { }

}

// Namespace: System.ComponentModel
public interface IChangeTracking
{
	// Methods

	// RVA: -1
	public abstract bool get_IsChanged() { }

	// RVA: -1
	public abstract void AcceptChanges() { }

}

// Namespace: System.ComponentModel
public interface IEditableObject
{
	// Methods

	// RVA: -1
	public abstract void BeginEdit() { }

	// RVA: -1
	public abstract void EndEdit() { }

	// RVA: -1
	public abstract void CancelEdit() { }

}

// Namespace: System.ComponentModel
public interface IRevertibleChangeTracking
{
	// Methods

	// RVA: -1
	public abstract void RejectChanges() { }

}

// Namespace: System.ComponentModel
public class DataErrorsChangedEventArgs
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x12F8CA8
	public void .ctor(string propertyName) { }

	// RVA: 0x12F8D20
	public virtual string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public interface INotifyDataErrorInfo
{
	// Methods

	// RVA: -1
	public abstract bool get_HasErrors() { }

	// RVA: -1
	public abstract IEnumerable GetErrors(string propertyName) { }

	// RVA: -1
	public abstract void add_ErrorsChanged(System.EventHandler<System.ComponentModel.DataErrorsChangedEventArgs> value) { }

	// RVA: -1
	public abstract void remove_ErrorsChanged(System.EventHandler<System.ComponentModel.DataErrorsChangedEventArgs> value) { }

}

// Namespace: System.ComponentModel
public interface INotifyPropertyChanged
{
	// Methods

	// RVA: -1
	public abstract void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: -1
	public abstract void remove_PropertyChanged(PropertyChangedEventHandler value) { }

}

// Namespace: System.ComponentModel
public interface INotifyPropertyChanging
{
	// Methods

	// RVA: -1
	public abstract void add_PropertyChanging(PropertyChangingEventHandler value) { }

	// RVA: -1
	public abstract void remove_PropertyChanging(PropertyChangingEventHandler value) { }

}

// Namespace: System.ComponentModel
public class PropertyChangedEventArgs
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x12F8D28
	public void .ctor(string propertyName) { }

	// RVA: 0x12F8DA0
	public virtual string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public sealed class PropertyChangedEventHandler
{
	// Methods

	// RVA: 0x12F8DA8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12F8ECC
	public virtual void Invoke(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x12F8EE0
	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12F8F3C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class PropertyChangingEventArgs
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x12F8F48
	public void .ctor(string propertyName) { }

	// RVA: 0x12F8FC0
	public virtual string get_PropertyName() { }

}

// Namespace: System.ComponentModel
public sealed class PropertyChangingEventHandler
{
	// Methods

	// RVA: 0x12F8FC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12F90EC
	public virtual void Invoke(object sender, PropertyChangingEventArgs e) { }

	// RVA: 0x12F9100
	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangingEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12F915C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
internal class ArraySubsetEnumerator
{
	// Fields
	private Array array; // 0x10
	private int total; // 0x18
	private int current; // 0x1C

	// Methods

	// RVA: 0x12F9168
	public void .ctor(Array array, int count) { }

	// RVA: 0x12F91B4
	public bool MoveNext() { }

	// RVA: 0x12F91D8
	public void Reset() { }

	// RVA: 0x12F91E4
	public object get_Current() { }

}

// Namespace: System.ComponentModel
public class AsyncCompletedEventArgs
{
	// Fields
	private readonly Exception error; // 0x10
	private readonly bool cancelled; // 0x18
	private readonly object userState; // 0x20

	// Methods

	// RVA: 0x12F924C
	public void .ctor() { }

	// RVA: 0x12F92D4
	public void .ctor(Exception error, bool cancelled, object userState) { }

	// RVA: 0x12F9370
	public bool get_Cancelled() { }

	// RVA: 0x12F9378
	public Exception get_Error() { }

	// RVA: 0x12F9380
	public object get_UserState() { }

	// RVA: 0x12F9388
	protected void RaiseExceptionIfNecessary() { }

}

// Namespace: System.ComponentModel
public sealed class AsyncCompletedEventHandler
{
	// Methods

	// RVA: 0x12F9468
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12F958C
	public virtual void Invoke(object sender, AsyncCompletedEventArgs e) { }

	// RVA: 0x12F95A0
	public virtual IAsyncResult BeginInvoke(object sender, AsyncCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12F95FC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class CategoryAttribute
{
	// Fields
	private static CategoryAttribute appearance; // 0x0
	private static CategoryAttribute asynchronous; // 0x8
	private static CategoryAttribute behavior; // 0x10
	private static CategoryAttribute data; // 0x18
	private static CategoryAttribute design; // 0x20
	private static CategoryAttribute action; // 0x28
	private static CategoryAttribute format; // 0x30
	private static CategoryAttribute layout; // 0x38
	private static CategoryAttribute mouse; // 0x40
	private static CategoryAttribute key; // 0x48
	private static CategoryAttribute focus; // 0x50
	private static CategoryAttribute windowStyle; // 0x58
	private static CategoryAttribute dragDrop; // 0x60
	private static CategoryAttribute defAttr; // 0x68
	private bool localized; // 0x10
	private string categoryValue; // 0x18

	// Methods

	// RVA: 0x12F9608
	public static CategoryAttribute get_Action() { }

	// RVA: 0x12F970C
	public static CategoryAttribute get_Appearance() { }

	// RVA: 0x12F97DC
	public static CategoryAttribute get_Asynchronous() { }

	// RVA: 0x12F98A4
	public static CategoryAttribute get_Behavior() { }

	// RVA: 0x12F996C
	public static CategoryAttribute get_Data() { }

	// RVA: 0x12F9A34
	public static CategoryAttribute get_Default() { }

	// RVA: 0x12F9B84
	public static CategoryAttribute get_Design() { }

	// RVA: 0x12F9C4C
	public static CategoryAttribute get_DragDrop() { }

	// RVA: 0x12F9D14
	public static CategoryAttribute get_Focus() { }

	// RVA: 0x12F9DDC
	public static CategoryAttribute get_Format() { }

	// RVA: 0x12F9EA4
	public static CategoryAttribute get_Key() { }

	// RVA: 0x12F9F6C
	public static CategoryAttribute get_Layout() { }

	// RVA: 0x12FA034
	public static CategoryAttribute get_Mouse() { }

	// RVA: 0x12FA0FC
	public static CategoryAttribute get_WindowStyle() { }

	// RVA: 0x12F9B14
	public void .ctor() { }

	// RVA: 0x12F96D0
	public void .ctor(string category) { }

	// RVA: 0x12FA1C4
	public string get_Category() { }

	// RVA: 0x12FA230
	public override bool Equals(object obj) { }

	// RVA: 0x12FA3A0
	public override int GetHashCode() { }

	// RVA: 0x12FA40C
	protected virtual string GetLocalizedString(string value) { }

	// RVA: 0x12FA760
	public override bool IsDefaultAttribute() { }

}

// Namespace: System.ComponentModel
public class CollectionConverter
{
	// Methods

	// RVA: 0x12FA820
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12FAC24
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12FAC2C
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x12FAC34
	public void .ctor() { }

}

// Namespace: System.ComponentModel
internal static class CompModSwitches
{
	// Fields
	private static BooleanSwitch commonDesignerServices; // 0x0
	private static TraceSwitch eventLog; // 0x8

	// Methods

	// RVA: 0x12FAC44
	public static BooleanSwitch get_CommonDesignerServices() { }

	// RVA: 0x12FAD24
	public static TraceSwitch get_EventLog() { }

}

// Namespace: System.ComponentModel
public class Component
{
	// Fields
	private static readonly object EventDisposed; // 0x0
	private ISite site; // 0x18
	private EventHandlerList events; // 0x20

	// Methods

	// RVA: 0x12FADFC
	protected override void Finalize() { }

	// RVA: 0x12FAE9C
	protected virtual bool get_CanRaiseEvents() { }

	// RVA: 0x12FAEA4
	internal bool get_CanRaiseEventsInternal() { }

	// RVA: 0x12FAEB0
	public void add_Disposed(EventHandler value) { }

	// RVA: 0x12FB068
	public void remove_Disposed(EventHandler value) { }

	// RVA: 0x12FAFC8
	protected EventHandlerList get_Events() { }

	// RVA: 0x12FB180
	public virtual ISite get_Site() { }

	// RVA: 0x12FB188
	public virtual void set_Site(ISite value) { }

	// RVA: 0x12FB190
	public void Dispose() { }

	// RVA: 0x12FB224
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12FB550
	public IContainer get_Container() { }

	// RVA: 0x12FB614
	protected virtual object GetService(Type service) { }

	// RVA: 0x12FB6D8
	protected bool get_DesignMode() { }

	// RVA: 0x12FB79C
	public override string ToString() { }

	// RVA: 0x12FB8DC
	public void .ctor() { }

	// RVA: 0x12FB8E4
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class ComponentConverter
{
	// Methods

	// RVA: 0x12FB96C
	public void .ctor(Type type) { }

	// RVA: 0x12FB9D8
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x12FBBB0
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: 
private class Site
{
	// Fields
	private IComponent component; // 0x10
	private Container container; // 0x18
	private string name; // 0x20

	// Methods

	// RVA: 0x12FC1C0
	internal void .ctor(IComponent component, Container container, string name) { }

	// RVA: 0x12FD3FC
	public IComponent get_Component() { }

	// RVA: 0x12FD404
	public IContainer get_Container() { }

	// RVA: 0x12FD40C
	public object GetService(Type service) { }

	// RVA: 0x12FD4E0
	public bool get_DesignMode() { }

	// RVA: 0x12FD4E8
	public string get_Name() { }

	// RVA: 0x12FD4F0
	public void set_Name(string value) { }

}

// Namespace: System.ComponentModel
public class Container
{
	// Fields
	private ISite[] sites; // 0x10
	private int siteCount; // 0x18
	private ComponentCollection components; // 0x20
	private ContainerFilterService filter; // 0x28
	private bool checkedFilter; // 0x30
	private object syncObj; // 0x38

	// Methods

	// RVA: 0x12FBBB8
	protected override void Finalize() { }

	// RVA: 0x12FBC54
	public virtual void Add(IComponent component) { }

	// RVA: 0x12FBC64
	public virtual void Add(IComponent component, string name) { }

	// RVA: 0x12FC11C
	protected virtual ISite CreateSite(IComponent component, string name) { }

	// RVA: 0x12FC224
	public void Dispose() { }

	// RVA: 0x12FC2B4
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x12FC604
	protected virtual object GetService(Type service) { }

	// RVA: 0x12FC6A8
	public virtual ComponentCollection get_Components() { }

	// RVA: 0x12FCB44
	public virtual void Remove(IComponent component) { }

	// RVA: 0x12FCB4C
	private void Remove(IComponent component, bool preserveSite) { }

	// RVA: 0x12FCE64
	protected void RemoveWithoutUnsiting(IComponent component) { }

	// RVA: 0x12FCE6C
	protected virtual void ValidateName(IComponent component, string name) { }

	// RVA: 0x12FD384
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public class DateTimeOffsetConverter
{
	// Methods

	// RVA: 0x12FD568
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12FD6FC
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12FD890
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12FDCEC
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x12FE978
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class DesignerAttribute
{
	// Fields
	private readonly string designerTypeName; // 0x10
	private readonly string designerBaseTypeName; // 0x18
	private string typeId; // 0x20

	// Methods

	// RVA: 0x12FE980
	public void .ctor(string designerTypeName) { }

	// RVA: 0x12FEAAC
	public void .ctor(Type designerType) { }

	// RVA: 0x12FEB88
	public void .ctor(string designerTypeName, string designerBaseTypeName) { }

	// RVA: 0x12FEC60
	public void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x12FED54
	public void .ctor(Type designerType, Type designerBaseType) { }

	// RVA: 0x12FEDD8
	public string get_DesignerBaseTypeName() { }

	// RVA: 0x12FEDE0
	public string get_DesignerTypeName() { }

	// RVA: 0x12FEDE8
	public override object get_TypeId() { }

	// RVA: 0x12FEEA4
	public override bool Equals(object obj) { }

	// RVA: 0x12FEF6C
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
public class DoWorkEventArgs
{
	// Fields
	private object result; // 0x18
	private object argument; // 0x20

	// Methods

	// RVA: 0x12FEFBC
	public void .ctor(object argument) { }

	// RVA: 0x12FEFF0
	public object get_Argument() { }

	// RVA: 0x12FEFF8
	public object get_Result() { }

	// RVA: 0x12FF000
	public void set_Result(object value) { }

}

// Namespace: System.ComponentModel
public sealed class DoWorkEventHandler
{
	// Methods

	// RVA: 0x12FF008
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12FF12C
	public virtual void Invoke(object sender, DoWorkEventArgs e) { }

	// RVA: 0x12FF140
	public virtual IAsyncResult BeginInvoke(object sender, DoWorkEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x12FF19C
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
public class EnumConverter
{
	// Fields
	private StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Methods

	// RVA: 0x12FF1A8
	public void .ctor(Type type) { }

	// RVA: 0x12FF1DC
	protected Type get_EnumType() { }

	// RVA: 0x12FF1E4
	protected StandardValuesCollection get_Values() { }

	// RVA: 0x12FF1EC
	protected void set_Values(StandardValuesCollection value) { }

	// RVA: 0x12FF1F4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x12FF344
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x12FF494
	protected virtual IComparer get_Comparer() { }

	// RVA: 0x12FF510
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x12FFA88
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x130096C
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1300FAC
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1301078
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1301080
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

}

// Namespace: System.ComponentModel
public interface IComponent
{
	// Methods

	// RVA: -1
	public abstract ISite get_Site() { }

	// RVA: -1
	public abstract void set_Site(ISite value) { }

	// RVA: -1
	public abstract void add_Disposed(EventHandler value) { }

	// RVA: -1
	public abstract void remove_Disposed(EventHandler value) { }

}

// Namespace: System.ComponentModel
internal static class IntSecurity
{
	// Methods

	// RVA: 0x13010F0
	public static string UnsafeGetFullPath(string fileName) { }

}

// Namespace: System.ComponentModel
[Serializable]
public class LicenseException
{
	// Fields
	private Type type; // 0x90
	private object instance; // 0x98

	// Methods

	// RVA: 0x1301178
	public void .ctor(Type type) { }

	// RVA: 0x1301308
	public void .ctor(Type type, object instance) { }

	// RVA: 0x13012A4
	public void .ctor(Type type, object instance, string message) { }

	// RVA: 0x1301494
	public void .ctor(Type type, object instance, string message, Exception innerException) { }

	// RVA: 0x13014FC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13016A8
	public Type get_LicensedType() { }

	// RVA: 0x13016B0
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

// Namespace: System.ComponentModel
public abstract class MemberDescriptor
{
	// Fields
	private string name; // 0x10
	private string displayName; // 0x18
	private int nameHash; // 0x20
	private AttributeCollection attributeCollection; // 0x28
	private Attribute[] attributes; // 0x30
	private Attribute[] originalAttributes; // 0x38
	private bool attributesFiltered; // 0x40
	private bool attributesFilled; // 0x41
	private int metadataVersion; // 0x44
	private string category; // 0x48
	private string description; // 0x50
	private object lockCookie; // 0x58

	// Methods

	// RVA: 0x13017AC
	protected void .ctor(string name) { }

	// RVA: 0x13017B4
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x13019A0
	protected void .ctor(MemberDescriptor descr) { }

	// RVA: 0x1301AF8
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x1301F54
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x13027D8
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x13028D8
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x13029EC
	public virtual string get_Category() { }

	// RVA: 0x1302B54
	public virtual string get_Description() { }

	// RVA: 0x1302C84
	public virtual bool get_IsBrowsable() { }

	// RVA: 0x1302D64
	public virtual string get_Name() { }

	// RVA: 0x1302DC0
	protected virtual int get_NameHashCode() { }

	// RVA: 0x1302DC8
	public virtual bool get_DesignTimeOnly() { }

	// RVA: 0x1302EBC
	public virtual string get_DisplayName() { }

	// RVA: 0x1301F80
	private void CheckAttributesValid() { }

	// RVA: 0x1302FE4
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x1303060
	public override bool Equals(object obj) { }

	// RVA: 0x13032E8
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x1302074
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x13033E0
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x130345C
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x1303524
	public override int GetHashCode() { }

	// RVA: 0x130352C
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x1303CC0
	protected static ISite GetSite(object component) { }

	// RVA: 0x1303DE0
	protected static object GetInvokee(Type componentClass, object component) { }

}

// Namespace: System.ComponentModel
public class ProgressChangedEventArgs
{
	// Fields
	private readonly int progressPercentage; // 0x10
	private readonly object userState; // 0x18

	// Methods

	// RVA: 0x1303F24
	public void .ctor(int progressPercentage, object userState) { }

	// RVA: 0x1303FAC
	public int get_ProgressPercentage() { }

	// RVA: 0x1303FB4
	public object get_UserState() { }

}

// Namespace: System.ComponentModel
public sealed class ProgressChangedEventHandler
{
	// Methods

	// RVA: 0x1303FBC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13040E0
	public virtual void Invoke(object sender, ProgressChangedEventArgs e) { }

	// RVA: 0x13040F4
	public virtual IAsyncResult BeginInvoke(object sender, ProgressChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x1304150
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.ComponentModel
internal sealed class ReflectPropertyDescriptor
{
	// Fields
	private static readonly Type[] argsNone; // 0x0
	private static readonly object noValue; // 0x8
	private static TraceSwitch PropDescCreateSwitch; // 0x10
	private static TraceSwitch PropDescUsageSwitch; // 0x18
	private static readonly int BitDefaultValueQueried; // 0x20
	private static readonly int BitGetQueried; // 0x24
	private static readonly int BitSetQueried; // 0x28
	private static readonly int BitShouldSerializeQueried; // 0x2C
	private static readonly int BitResetQueried; // 0x30
	private static readonly int BitChangedQueried; // 0x34
	private static readonly int BitIPropChangedQueried; // 0x38
	private static readonly int BitReadOnlyChecked; // 0x3C
	private static readonly int BitAmbientValueQueried; // 0x40
	private static readonly int BitSetOnDemand; // 0x44
	private BitVector32 state; // 0x84
	private Type componentClass; // 0x88
	private Type type; // 0x90
	private object defaultValue; // 0x98
	private object ambientValue; // 0xA0
	private PropertyInfo propInfo; // 0xA8
	private MethodInfo getMethod; // 0xB0
	private MethodInfo setMethod; // 0xB8
	private MethodInfo shouldSerializeMethod; // 0xC0
	private MethodInfo resetMethod; // 0xC8
	private EventDescriptor realChangedEvent; // 0xD0
	private EventDescriptor realIPropChangedEvent; // 0xD8
	private Type receiverType; // 0xE0

	// Methods

	// RVA: 0x130415C
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x130444C
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x13045A8
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x13046A0
	public void .ctor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x1304B60
	private object get_AmbientValue() { }

	// RVA: 0x1304D1C
	private EventDescriptor get_ChangedEventValue() { }

	// RVA: 0x1305088
	private EventDescriptor get_IPropChangedEventValue() { }

	// RVA: 0x130528C
	private void set_IPropChangedEventValue(EventDescriptor value) { }

	// RVA: 0x1305318
	public override Type get_ComponentType() { }

	// RVA: 0x1305320
	private object get_DefaultValue() { }

	// RVA: 0x1305610
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x1305B18
	private bool get_IsExtender() { }

	// RVA: 0x1305B84
	public override bool get_IsReadOnly() { }

	// RVA: 0x13062B4
	public override Type get_PropertyType() { }

	// RVA: 0x13062BC
	private MethodInfo get_ResetMethodValue() { }

	// RVA: 0x1305C98
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x1306584
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0x130684C
	public override void AddValueChanged(object component, EventHandler handler) { }

	// RVA: 0x1306A04
	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x1306E5C
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x1306E64
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x1306D10
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x1306E74
	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	// RVA: 0x1307394
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x1307848
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x1307D24
	public override bool CanResetValue(object component) { }

	// RVA: 0x1308044
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x13091C8
	public override object GetValue(object component) { }

	// RVA: 0x1309504
	internal void OnINotifyPropertyChanged(object component, PropertyChangedEventArgs e) { }

	// RVA: 0x130960C
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x13096F0
	public override void RemoveValueChanged(object component, EventHandler handler) { }

	// RVA: 0x13098AC
	public override void ResetValue(object component) { }

	// RVA: 0x1309D20
	public override void SetValue(object component, object value) { }

	// RVA: 0x130A330
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x130A6B8
	public override bool get_SupportsChangeEvents() { }

	// RVA: 0x130A6FC
	private static void .cctor() { }

}

// Namespace: 
private class ReflectedTypeData
{
	// Fields
	private Type _type; // 0x10
	private AttributeCollection _attributes; // 0x18
	private EventDescriptorCollection _events; // 0x20
	private PropertyDescriptorCollection _properties; // 0x28
	private TypeConverter _converter; // 0x30
	private object[] _editors; // 0x38
	private Type[] _editorTypes; // 0x40
	private int _editorCount; // 0x48

	// Methods

	// RVA: 0x13119B0
	internal void .ctor(Type type) { }

	// RVA: 0x1311588
	internal bool get_IsPopulated() { }

	// RVA: 0x130BDA8
	internal AttributeCollection GetAttributes() { }

	// RVA: 0x130C6F4
	internal string GetClassName(object instance) { }

	// RVA: 0x130C74C
	internal string GetComponentName(object instance) { }

	// RVA: 0x130C968
	internal TypeConverter GetConverter(object instance) { }

	// RVA: 0x130CEDC
	internal EventDescriptor GetDefaultEvent(object instance) { }

	// RVA: 0x130D188
	internal PropertyDescriptor GetDefaultProperty(object instance) { }

	// RVA: 0x130D48C
	internal object GetEditor(object instance, Type editorBaseType) { }

	// RVA: 0x13140A8
	private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType) { }

	// RVA: 0x130E030
	internal EventDescriptorCollection GetEvents() { }

	// RVA: 0x13115C4
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x1313BCC
	private Type GetTypeFromName(string typeName) { }

	// RVA: 0x1312E1C
	internal void Refresh() { }

}

// Namespace: System.ComponentModel
internal sealed class ReflectTypeDescriptionProvider
{
	// Fields
	private Hashtable _typeData; // 0x20
	private static Type[] _typeConstructor; // 0x0
	private static Hashtable _editorTables; // 0x8
	private static Hashtable _intrinsicTypeConverters; // 0x10
	private static object _intrinsicReferenceKey; // 0x18
	private static object _intrinsicNullableKey; // 0x20
	private static object _dictionaryKey; // 0x28
	private static Hashtable _propertyCache; // 0x30
	private static Hashtable _eventCache; // 0x38
	private static Hashtable _attributeCache; // 0x40
	private static Hashtable _extendedPropertyCache; // 0x48
	private static readonly Guid _extenderProviderKey; // 0x50
	private static readonly Guid _extenderPropertiesKey; // 0x60
	private static readonly Guid _extenderProviderPropertiesKey; // 0x70
	private static readonly Type[] _skipInterfaceAttributeList; // 0x80
	private static object _internalSyncObject; // 0x88

	// Methods

	// RVA: 0x130A960
	internal static Guid get_ExtenderProviderKey() { }

	// RVA: 0x130A9DC
	internal void .ctor() { }

	// RVA: 0x130A9E4
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x130B49C
	internal static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x130B770
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x130B9A8
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x130BAE0
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x130C2F4
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x130C6C0
	internal string GetClassName(Type type) { }

	// RVA: 0x130C71C
	internal string GetComponentName(Type type, object instance) { }

	// RVA: 0x130C938
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x130CEAC
	internal EventDescriptor GetDefaultEvent(Type type, object instance) { }

	// RVA: 0x130D158
	internal PropertyDescriptor GetDefaultProperty(Type type, object instance) { }

	// RVA: 0x130D454
	internal object GetEditor(Type type, object instance, Type editorBaseType) { }

	// RVA: 0x130DB7C
	private static Hashtable GetEditorTable(Type editorBaseType) { }

	// RVA: 0x130E010
	internal EventDescriptorCollection GetEvents(Type type) { }

	// RVA: 0x130E414
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x130E490
	internal string GetExtendedClassName(object instance) { }

	// RVA: 0x130E4E8
	internal string GetExtendedComponentName(object instance) { }

	// RVA: 0x130E534
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x130E580
	internal EventDescriptor GetExtendedDefaultEvent(object instance) { }

	// RVA: 0x130E588
	internal PropertyDescriptor GetExtendedDefaultProperty(object instance) { }

	// RVA: 0x130E590
	internal object GetExtendedEditor(object instance, Type editorBaseType) { }

	// RVA: 0x130E5EC
	internal EventDescriptorCollection GetExtendedEvents(object instance) { }

	// RVA: 0x130E668
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x130FC9C
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x131015C
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x1310D00
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x1310E2C
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1310E34
	public override string GetFullComponentName(object component) { }

	// RVA: 0x13110B0
	internal Type[] GetPopulatedTypes(Module module) { }

	// RVA: 0x13115A4
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x1310DA0
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x13119A8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x130BB00
	private ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x13119E4
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x13119EC
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x1311B08
	internal bool IsPopulated(Type type) { }

	// RVA: 0x1311B3C
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x1308D28
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x1311FDC
	private static EventDescriptor[] ReflectGetEvents(Type type) { }

	// RVA: 0x130ECD0
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x131270C
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x1312D94
	internal void Refresh(Type type) { }

	// RVA: 0x1312E98
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x1313890
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public class RunWorkerCompletedEventArgs
{
	// Fields
	private object result; // 0x28

	// Methods

	// RVA: 0x1314448
	public void .ctor(object result, Exception error, bool cancelled) { }

	// RVA: 0x13144F4
	public object get_Result() { }

	// RVA: 0x1314518
	public object get_UserState() { }

}

// Namespace: System.ComponentModel
public sealed class RunWorkerCompletedEventHandler
{
	// Methods

	// RVA: 0x1314520
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1314644
	public virtual void Invoke(object sender, RunWorkerCompletedEventArgs e) { }

	// RVA: 0x1314658
	public virtual IAsyncResult BeginInvoke(object sender, RunWorkerCompletedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x13146B4
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: 
protected abstract class SimplePropertyDescriptor
{
	// Fields
	private Type componentType; // 0x88
	private Type propertyType; // 0x90

	// Methods

	// RVA: 0x1315394
	protected void .ctor(Type componentType, string name, Type propertyType) { }

	// RVA: 0x1315430
	protected void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	// RVA: 0x1315488
	public override Type get_ComponentType() { }

	// RVA: 0x1315490
	public override bool get_IsReadOnly() { }

	// RVA: 0x131551C
	public override Type get_PropertyType() { }

	// RVA: 0x1315524
	public override bool CanResetValue(object component) { }

	// RVA: 0x1315674
	public override void ResetValue(object component) { }

	// RVA: 0x13157AC
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: 
public class StandardValuesCollection
{
	// Fields
	private ICollection values; // 0x10
	private Array valueArray; // 0x18

	// Methods

	// RVA: 0x1300EDC
	public void .ctor(ICollection values) { }

	// RVA: 0x13157B4
	public int get_Count() { }

	// RVA: 0x1315884
	public object get_Item(int index) { }

	// RVA: 0x1315A90
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1315B4C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1315C00
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1315C04
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1315C0C
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1315C14
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1315CD0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.ComponentModel
public class TypeConverter
{
	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x0

	// Methods

	// RVA: 0x13146C0
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x1314714
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x12FD670
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1314728
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x12FD804
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x131473C
	public object ConvertFrom(object value) { }

	// RVA: 0x12FDC74
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x13148F0
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x131497C
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x1314A08
	public object ConvertFromString(string text) { }

	// RVA: 0x1314A20
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x1314970
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x1314AAC
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x12FA9B8
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1314C44
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x13008E8
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1314DA4
	public string ConvertToString(object value) { }

	// RVA: 0x1314EAC
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1314CBC
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1314FB8
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x1314FCC
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x13147BC
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x1314AC8
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x1314FD4
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x1314FE4
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1314FEC
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x1314FF8
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x13150F4
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x13150FC
	public bool GetPropertiesSupported() { }

	// RVA: 0x131510C
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1315114
	public ICollection GetStandardValues() { }

	// RVA: 0x1315124
	public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x131512C
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x1315140
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1315148
	public bool GetStandardValuesSupported() { }

	// RVA: 0x131515C
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1315164
	public bool IsValid(object value) { }

	// RVA: 0x131517C
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1315350
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

	// RVA: 0x12FAC3C
	public void .ctor() { }

}

// Namespace: 
private class AttributeTypeDescriptor
{
	// Fields
	private Attribute[] _attributeArray; // 0x18

	// Methods

	// RVA: 0x13234D8
	internal void .ctor(Attribute[] attrs, ICustomTypeDescriptor parent) { }

	// RVA: 0x1323510
	public override AttributeCollection GetAttributes() { }

}

// Namespace: 
private sealed class AttributeProvider
{
	// Fields
	private Attribute[] _attrs; // 0x20

	// Methods

	// RVA: 0x1323400
	internal void .ctor(TypeDescriptionProvider existingProvider, Attribute[] attrs) { }

	// RVA: 0x1323434
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

// Namespace: 
private sealed class ComNativeTypeDescriptor
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x10
	private object _instance; // 0x18

	// Methods

	// RVA: 0x13239DC
	internal void .ctor(IComNativeDescriptorHandler handler, object instance) { }

	// RVA: 0x1323A2C
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1323AEC
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x1323BB0
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x1323BB8
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1323C7C
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x1323D40
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x1323E04
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1323EC4
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1323F88
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1324048
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x13240FC
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x13241BC
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private sealed class ComNativeDescriptionProvider
{
	// Fields
	private IComNativeDescriptorHandler _handler; // 0x20

	// Methods

	// RVA: 0x13237D4
	internal void .ctor(IComNativeDescriptorHandler handler) { }

	// RVA: 0x1323808
	internal IComNativeDescriptorHandler get_Handler() { }

	// RVA: 0x1323810
	internal void set_Handler(IComNativeDescriptorHandler value) { }

	// RVA: 0x1323818
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

// Namespace: 
private sealed class AttributeFilterCacheItem
{
	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x13241C4
	internal void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0x1324214
	internal bool IsValid(Attribute[] filter) { }

}

// Namespace: 
private sealed class FilterCacheItem
{
	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x132428C
	internal void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0x13242DC
	internal bool IsValid(ITypeDescriptorFilterService filterService) { }

}

// Namespace: 
private interface IUnimplemented
{}

// Namespace: 
private sealed class MemberDescriptorComparer
{
	// Fields
	public static readonly MemberDescriptorComparer Instance; // 0x0

	// Methods

	// RVA: 0x13242EC
	public int Compare(object left, object right) { }

	// RVA: 0x1324410
	public void .ctor() { }

	// RVA: 0x1324418
	private static void .cctor() { }

}

// Namespace: 
private sealed class MergedTypeDescriptor
{
	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x1324484
	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x13244D4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1324614
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x132475C
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x13248A4
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x13249EC
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x1324B34
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x1324C7C
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1324E60
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1324FA8
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x13250EC
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1325234
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1325378
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private struct DefaultExtendedTypeDescriptor
{
	// Fields
	private TypeDescriptionNode _node; // 0x10
	private object _instance; // 0x18

	// Methods

	// RVA: 0x13257EC
	internal void .ctor(TypeDescriptionNode node, object instance) { }

	// RVA: 0x1325E18
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x132612C
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x1326374
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x1326590
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1326840
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x1326A5C
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x1326C78
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1326F38
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x1327250
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x1327584
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1327834
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1327AFC
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private struct DefaultTypeDescriptor
{
	// Fields
	private TypeDescriptionNode _node; // 0x10
	private Type _objectType; // 0x18
	private object _instance; // 0x20

	// Methods

	// RVA: 0x1325CD4
	internal void .ctor(TypeDescriptionNode node, Type objectType, object instance) { }

	// RVA: 0x1327D48
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1327FF8
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0x1328238
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0x1328454
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1328704
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0x1328920
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0x1328B3C
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0x1328DFC
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0x13290B0
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0x132937C
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1329630
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x13298FC
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: 
private sealed class TypeDescriptionNode
{
	// Fields
	internal TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x13254BC
	internal void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x13254F0
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1325694
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x132570C
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1325820
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1325898
	public override string GetFullComponentName(object component) { }

	// RVA: 0x1325910
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1325A14
	public override Type GetRuntimeType(Type objectType) { }

	// RVA: 0x1325B08
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x1325D24
	public override bool IsSupportedType(Type type) { }

}

// Namespace: 
private sealed class TypeDescriptorComObject
{
	// Methods

	// RVA: 0x1329B48
	public void .ctor() { }

}

// Namespace: 
private sealed class TypeDescriptorInterface
{
	// Methods

	// RVA: 0x1329B50
	public void .ctor() { }

}

// Namespace: System.ComponentModel
public sealed class TypeDescriptor
{
	// Fields
	private static WeakHashtable _providerTable; // 0x0
	private static Hashtable _providerTypeTable; // 0x8
	private static Hashtable _defaultProviders; // 0x10
	private static WeakHashtable _associationTable; // 0x18
	private static int _metadataVersion; // 0x20
	private static int _collisionIndex; // 0x24
	private static BooleanSwitch TraceDescriptor; // 0x28
	private const int PIPELINE_ATTRIBUTES = 0;
	private const int PIPELINE_PROPERTIES = 1;
	private const int PIPELINE_EVENTS = 2;
	private static readonly Guid[] _pipelineInitializeKeys; // 0x30
	private static readonly Guid[] _pipelineMergeKeys; // 0x38
	private static readonly Guid[] _pipelineFilterKeys; // 0x40
	private static readonly Guid[] _pipelineAttributeFilterKeys; // 0x48
	private static object _internalSyncObject; // 0x50
	private static RefreshEventHandler Refreshed; // 0x58

	// Methods

	// RVA: 0x1315D84
	private void .ctor() { }

	// RVA: 0x1315D8C
	public static IComNativeDescriptorHandler get_ComNativeDescriptorHandler() { }

	// RVA: 0x1316010
	public static void set_ComNativeDescriptorHandler(IComNativeDescriptorHandler value) { }

	// RVA: 0x1315EE8
	public static Type get_ComObjectType() { }

	// RVA: 0x13164E4
	public static Type get_InterfaceType() { }

	// RVA: 0x1316584
	internal static int get_MetadataVersion() { }

	// RVA: 0x1316600
	public static void add_Refreshed(RefreshEventHandler value) { }

	// RVA: 0x13166F0
	public static void remove_Refreshed(RefreshEventHandler value) { }

	// RVA: 0x13167E0
	public static TypeDescriptionProvider AddAttributes(Type type, Attribute[] attributes) { }

	// RVA: 0x1316A6C
	public static TypeDescriptionProvider AddAttributes(object instance, Attribute[] attributes) { }

	// RVA: 0x1316EF8
	public static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x1316238
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1316C44
	public static void AddProvider(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x131860C
	public static void AddProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1318730
	public static void AddProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x1318820
	private static void CheckDefaultProvider(Type type) { }

	// RVA: 0x1318E80
	public static void CreateAssociation(object primary, object secondary) { }

	// RVA: 0x1319628
	public static IDesigner CreateDesigner(IComponent component, Type designerBaseType) { }

	// RVA: 0x1319B40
	public static EventDescriptor CreateEvent(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x1319BC8
	public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x1319C48
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1319FA4
	public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x131A028
	public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, Attribute[] attributes) { }

	// RVA: 0x131A204
	private static void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0x131A208
	private static void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes) { }

	// RVA: 0x131A20C
	private static void DebugValidate(AttributeCollection attributes, Type type) { }

	// RVA: 0x131A210
	private static void DebugValidate(AttributeCollection attributes, object instance, bool noCustomTypeDesc) { }

	// RVA: 0x131A214
	private static void DebugValidate(TypeConverter converter, Type type) { }

	// RVA: 0x131A218
	private static void DebugValidate(TypeConverter converter, object instance, bool noCustomTypeDesc) { }

	// RVA: 0x131A21C
	private static void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes) { }

	// RVA: 0x131A220
	private static void DebugValidate(EventDescriptorCollection events, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x131A224
	private static void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes) { }

	// RVA: 0x131A228
	private static void DebugValidate(PropertyDescriptorCollection properties, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x131A22C
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	// RVA: 0x1303670
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x1308B8C
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x12FD2FC
	public static AttributeCollection GetAttributes(object component) { }

	// RVA: 0x131A874
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x130EBF0
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x131E394
	public static string GetClassName(object component) { }

	// RVA: 0x131E41C
	public static string GetClassName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x131E530
	public static string GetClassName(Type componentType) { }

	// RVA: 0x1311028
	public static string GetComponentName(object component) { }

	// RVA: 0x131E65C
	public static string GetComponentName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x131E770
	public static TypeConverter GetConverter(object component) { }

	// RVA: 0x131E7F8
	public static TypeConverter GetConverter(object component, bool noCustomTypeDesc) { }

	// RVA: 0x131E90C
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x131EA38
	private static object ConvertFromInvariantString(Type type, string stringValue) { }

	// RVA: 0x131EB1C
	public static EventDescriptor GetDefaultEvent(Type componentType) { }

	// RVA: 0x131EC90
	public static EventDescriptor GetDefaultEvent(object component) { }

	// RVA: 0x131ED18
	public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc) { }

	// RVA: 0x131EE28
	public static PropertyDescriptor GetDefaultProperty(Type componentType) { }

	// RVA: 0x131EF9C
	public static PropertyDescriptor GetDefaultProperty(object component) { }

	// RVA: 0x131F024
	public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc) { }

	// RVA: 0x131A710
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x131AC8C
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x131AF00
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x131F134
	public static object GetEditor(object component, Type editorBaseType) { }

	// RVA: 0x131F1A0
	public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc) { }

	// RVA: 0x131F334
	public static object GetEditor(Type type, Type editorBaseType) { }

	// RVA: 0x1304EE4
	public static EventDescriptorCollection GetEvents(Type componentType) { }

	// RVA: 0x131F4D0
	public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes) { }

	// RVA: 0x1313DD8
	public static EventDescriptorCollection GetEvents(object component) { }

	// RVA: 0x131FC30
	public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc) { }

	// RVA: 0x131FC9C
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes) { }

	// RVA: 0x131F764
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x13203B4
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x132070C
	public static string GetFullComponentName(object component) { }

	// RVA: 0x13207C8
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x1313F04
	public static PropertyDescriptorCollection GetProperties(Type componentType) { }

	// RVA: 0x13209D0
	public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes) { }

	// RVA: 0x1313E40
	public static PropertyDescriptorCollection GetProperties(object component) { }

	// RVA: 0x1320C64
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x12FBAE8
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	// RVA: 0x1321388
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x1320CD4
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x1316950
	public static TypeDescriptionProvider GetProvider(Type type) { }

	// RVA: 0x1316B88
	public static TypeDescriptionProvider GetProvider(object instance) { }

	// RVA: 0x1321404
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	// RVA: 0x1300D6C
	public static Type GetReflectionType(Type type) { }

	// RVA: 0x132148C
	public static Type GetReflectionType(object instance) { }

	// RVA: 0x1315F88
	private static TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x1316F84
	private static TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x131E30C
	private static TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x1317AFC
	private static TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x13215A8
	private static void NodeRemove(object key, TypeDescriptionProvider provider) { }

	// RVA: 0x131FD08
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x131C288
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x131DB00
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x131B020
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x1321990
	private static void RaiseRefresh(object component) { }

	// RVA: 0x1321A68
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x1321B40
	public static void Refresh(object component) { }

	// RVA: 0x1317D4C
	private static void Refresh(object component, bool refreshReflectionProvider) { }

	// RVA: 0x13174B0
	public static void Refresh(Type type) { }

	// RVA: 0x1321BC8
	public static void Refresh(Module module) { }

	// RVA: 0x132263C
	public static void Refresh(Assembly assembly) { }

	// RVA: 0x1322708
	public static void RemoveAssociation(object primary, object secondary) { }

	// RVA: 0x1322AC8
	public static void RemoveAssociations(object primary) { }

	// RVA: 0x1322BAC
	public static void RemoveProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1322CC0
	public static void RemoveProvider(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x1322DA0
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1322EC4
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x131A67C
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x1322FB4
	public static void SortDescriptorArray(IList infos) { }

	// RVA: 0x1323088
	internal static void Trace(string message, object[] args) { }

	// RVA: 0x132308C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
[Serializable]
public class Win32Exception
{
	// Fields
	private readonly int nativeErrorCode; // 0x8C

	// Methods

	// RVA: 0x1329B58
	public void .ctor() { }

	// RVA: 0x1329BD8
	public void .ctor(int error) { }

	// RVA: 0x132AA08
	public void .ctor(int error, string message) { }

	// RVA: 0x132AA38
	public void .ctor(string message) { }

	// RVA: 0x132AAB8
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x132AB44
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x132ABD8
	public int get_NativeErrorCode() { }

	// RVA: 0x132ABE0
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1329C14
	internal static string GetErrorMessage(int error) { }

}

// Namespace: System.ComponentModel
public sealed class NotifyParentPropertyAttribute
{
	// Fields
	public static readonly NotifyParentPropertyAttribute Yes; // 0x0
	public static readonly NotifyParentPropertyAttribute No; // 0x8
	public static readonly NotifyParentPropertyAttribute Default; // 0x10
	private bool notifyParent; // 0x10

	// Methods

	// RVA: 0x132ACB4
	public void .ctor(bool notifyParent) { }

	// RVA: 0x132ACE0
	public bool get_NotifyParent() { }

	// RVA: 0x132ACE8
	public override bool Equals(object obj) { }

	// RVA: 0x132AD8C
	public override int GetHashCode() { }

	// RVA: 0x132AD94
	public override bool IsDefaultAttribute() { }

	// RVA: 0x132AE08
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public sealed class ParenthesizePropertyNameAttribute
{
	// Fields
	public static readonly ParenthesizePropertyNameAttribute Default; // 0x0
	private bool needParenthesis; // 0x10

	// Methods

	// RVA: 0x132AEBC
	public void .ctor() { }

	// RVA: 0x132AEE4
	public void .ctor(bool needParenthesis) { }

	// RVA: 0x132AF10
	public bool get_NeedParenthesis() { }

	// RVA: 0x132AF18
	public override bool Equals(object o) { }

	// RVA: 0x132AFA0
	public override int GetHashCode() { }

	// RVA: 0x132AFA8
	public override bool IsDefaultAttribute() { }

	// RVA: 0x132B01C
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
public enum RefreshProperties
{
	// Fields
	public int value__; // 0x10
	public const RefreshProperties None = 0;
	public const RefreshProperties All = 1;
	public const RefreshProperties Repaint = 2;
}

// Namespace: System.ComponentModel
public sealed class RefreshPropertiesAttribute
{
	// Fields
	public static readonly RefreshPropertiesAttribute All; // 0x0
	public static readonly RefreshPropertiesAttribute Repaint; // 0x8
	public static readonly RefreshPropertiesAttribute Default; // 0x10
	private RefreshProperties refresh; // 0x10

	// Methods

	// RVA: 0x132B08C
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x132B0B8
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x132B0C0
	public override bool Equals(object value) { }

	// RVA: 0x132B148
	public override int GetHashCode() { }

	// RVA: 0x132B150
	public override bool IsDefaultAttribute() { }

	// RVA: 0x132B1C4
	private static void .cctor() { }

}

// Namespace: 
private class WeakKeyComparer
{
	// Methods

	// RVA: 0x132BB08
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	// RVA: 0x132BC80
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x132BB00
	public void .ctor() { }

}

// Namespace: 
private sealed class EqualityWeakReference
{
	// Fields
	private int _hashCode; // 0x20

	// Methods

	// RVA: 0x132BA34
	internal void .ctor(object o) { }

	// RVA: 0x132BCA8
	public override bool Equals(object o) { }

	// RVA: 0x132BD38
	public override int GetHashCode() { }

}

// Namespace: System.ComponentModel
internal sealed class WeakHashtable
{
	// Fields
	private static IEqualityComparer _comparer; // 0x0
	private Int64 _lastGlobalMem; // 0x50
	private int _lastHashCount; // 0x58

	// Methods

	// RVA: 0x132B294
	internal void .ctor() { }

	// RVA: 0x132B304
	public override void Clear() { }

	// RVA: 0x132B30C
	public override void Remove(object key) { }

	// RVA: 0x132B314
	public void SetWeak(object key, object value) { }

	// RVA: 0x132B3C4
	private void ScavengeKeys() { }

	// RVA: 0x132BA78
	private static void .cctor() { }

}

// Namespace: System.ComponentModel
internal sealed class SRCategoryAttribute
{
	// Methods

	// RVA: 0x132BD40
	public void .ctor(string category) { }

}

// Namespace: System.ComponentModel.Design
[Serializable]
public class CheckoutException
{
	// Fields
	public static readonly CheckoutException Canceled; // 0x0

	// Methods

	// RVA: 0x132BD48
	public void .ctor() { }

	// RVA: 0x132BD50
	public void .ctor(string message, int errorCode) { }

	// RVA: 0x132BD58
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x132BD60
	private static void .cctor() { }

}

// Namespace: System.ComponentModel.Design
internal class RuntimeLicenseContext
{
	// Fields
	private static TraceSwitch s_runtimeLicenseContextSwitch; // 0x0
	internal Hashtable savedLicenseKeys; // 0x10

	// Methods

	// RVA: 0x132BDF4
	private string GetLocalPath(string fileName) { }

	// RVA: 0x132BE88
	public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly) { }

	// RVA: 0x132C3F0
	private Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name) { }

	// RVA: 0x132C80C
	public void .ctor() { }

	// RVA: 0x132C814
	private static void .cctor() { }

}

// Namespace: System.ComponentModel.Design
public class DesigntimeLicenseContextSerializer
{
	// Methods

	// RVA: 0x132C5D4
	internal static void Deserialize(Stream o, string cryptoKey, RuntimeLicenseContext context) { }

}

// Namespace: System.ComponentModel.Design
public interface IComponentChangeService
{
	// Methods

	// RVA: -1
	public abstract void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue) { }

	// RVA: -1
	public abstract void OnComponentChanging(object component, MemberDescriptor member) { }

}

// Namespace: System.ComponentModel.Design
public interface IDesigner
{}

// Namespace: System.ComponentModel.Design
public interface IDesignerHost
{
	// Methods

	// RVA: -1
	public abstract IDesigner GetDesigner(IComponent component) { }

}

// Namespace: System.ComponentModel.Design
public interface IDictionaryService
{
	// Methods

	// RVA: -1
	public abstract object GetValue(object key) { }

	// RVA: -1
	public abstract void SetValue(object key, object value) { }

}

// Namespace: System.ComponentModel.Design
public interface IExtenderListService
{
	// Methods

	// RVA: -1
	public abstract IExtenderProvider[] GetExtenderProviders() { }

}

// Namespace: System.ComponentModel.Design
public interface IReferenceService
{
	// Methods

	// RVA: -1
	public abstract object GetReference(string name) { }

	// RVA: -1
	public abstract string GetName(object reference) { }

	// RVA: -1
	public abstract object[] GetReferences(Type baseType) { }

}

// Namespace: System.ComponentModel.Design
public interface ITypeDescriptorFilterService
{
	// Methods

	// RVA: -1
	public abstract bool FilterAttributes(IComponent component, IDictionary attributes) { }

	// RVA: -1
	public abstract bool FilterEvents(IComponent component, IDictionary events) { }

	// RVA: -1
	public abstract bool FilterProperties(IComponent component, IDictionary properties) { }

}

// Namespace: System.ComponentModel.Design
public interface ITypeResolutionService
{
	// Methods

	// RVA: -1
	public abstract Type GetType(string name) { }

	// RVA: -1
	public abstract string GetPathOfAssembly(AssemblyName name) { }

}

// Namespace: 
private sealed class WrappedPropertyDescriptor
{
	// Fields
	private object target; // 0x88
	private PropertyDescriptor property; // 0x90

	// Methods

	// RVA: 0x132D118
	internal void .ctor(PropertyDescriptor property, object target) { }

	// RVA: 0x132D220
	public override AttributeCollection get_Attributes() { }

	// RVA: 0x132D244
	public override Type get_ComponentType() { }

	// RVA: 0x132D26C
	public override bool get_IsReadOnly() { }

	// RVA: 0x132D294
	public override Type get_PropertyType() { }

	// RVA: 0x132D2BC
	public override bool CanResetValue(object component) { }

	// RVA: 0x132D2EC
	public override object GetValue(object component) { }

	// RVA: 0x132D31C
	public override void ResetValue(object component) { }

	// RVA: 0x132D34C
	public override void SetValue(object component, object value) { }

	// RVA: 0x132D37C
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: 
public sealed class DesignerOptionCollection
{
	// Fields
	private DesignerOptionService _service; // 0x10
	private string _name; // 0x18
	private object _value; // 0x20
	private ArrayList _children; // 0x28
	private PropertyDescriptorCollection _properties; // 0x30

	// Methods

	// RVA: 0x132C8D8
	public int get_Count() { }

	// RVA: 0x132C9B4
	public string get_Name() { }

	// RVA: 0x132C9BC
	public PropertyDescriptorCollection get_Properties() { }

	// RVA: 0x132D18C
	public void CopyTo(Array array, int index) { }

	// RVA: 0x132C910
	private void EnsurePopulated() { }

	// RVA: 0x132D1DC
	public IEnumerator GetEnumerator() { }

	// RVA: 0x132D214
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x132D21C
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
private class OptionPropertyDescriptor
{
	// Fields
	private DesignerOptionCollection _option; // 0x88

	// Methods

	// RVA: 0x132D980
	internal void .ctor(DesignerOptionCollection option) { }

	// RVA: 0x132DACC
	public override Type get_ComponentType() { }

	// RVA: 0x132DAEC
	public override bool get_IsReadOnly() { }

	// RVA: 0x132DAF4
	public override Type get_PropertyType() { }

	// RVA: 0x132DB14
	public override bool CanResetValue(object component) { }

	// RVA: 0x132DB1C
	public override object GetValue(object component) { }

	// RVA: 0x132DB24
	public override void ResetValue(object component) { }

	// RVA: 0x132DB28
	public override void SetValue(object component, object value) { }

	// RVA: 0x132DB2C
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: 
internal sealed class DesignerOptionConverter
{
	// Methods

	// RVA: 0x132D3AC
	public override bool GetPropertiesSupported(ITypeDescriptorContext cxt) { }

	// RVA: 0x132D3B4
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes) { }

	// RVA: 0x132D9C4
	public override object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x132DAC4
	public void .ctor() { }

}

// Namespace: System.ComponentModel.Design
public abstract class DesignerOptionService
{
	// Methods

	// RVA: 0x132C8D4
	protected virtual void PopulateOptionCollection(DesignerOptionCollection options) { }

}

// Namespace: System.ComponentModel.Design.Serialization
public sealed class InstanceDescriptor
{
	// Fields
	private readonly ICollection <Arguments>k__BackingField; // 0x10
	private readonly bool <IsComplete>k__BackingField; // 0x18
	private readonly MemberInfo <MemberInfo>k__BackingField; // 0x20

	// Methods

	// RVA: 0x132DB34
	public void .ctor(MemberInfo member, ICollection arguments) { }

	// RVA: 0x132DB3C
	public void .ctor(MemberInfo member, ICollection arguments, bool isComplete) { }

	// RVA: 0x132E0C8
	public ICollection get_Arguments() { }

	// RVA: 0x132E0D0
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x132E0D8
	public object Invoke() { }

}

// Namespace: System.ComponentModel.Design.Serialization
public sealed class RootDesignerSerializerAttribute
{
	// Fields
	private string _typeId; // 0x10
	private readonly bool <Reloadable>k__BackingField; // 0x18
	private readonly string <SerializerTypeName>k__BackingField; // 0x20
	private readonly string <SerializerBaseTypeName>k__BackingField; // 0x28

	// Methods

	// RVA: 0x132E458
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	// RVA: 0x132E4B4
	public string get_SerializerBaseTypeName() { }

	// RVA: 0x132E4BC
	public override object get_TypeId() { }

}

// Namespace: System.Collections
internal static class HashtableExtensions
{
	// Methods

	// RVA: 0x30B4264
	public static bool TryGetValue(Hashtable table, object key, T value) { }

}

// Namespace: System.Collections.Specialized
public struct BitVector32
{
	// Fields
	private UInt32 _data; // 0x10

	// Methods

	// RVA: 0x132E578
	public void .ctor(int data) { }

	// RVA: 0x132E580
	public bool get_Item(int bit) { }

	// RVA: 0x132E590
	public void set_Item(int bit, bool value) { }

	// RVA: 0x132E5AC
	public int get_Data() { }

	// RVA: 0x132E5B4
	public static int CreateMask() { }

	// RVA: 0x132E5BC
	public static int CreateMask(int previous) { }

	// RVA: 0x132E630
	public override bool Equals(object o) { }

	// RVA: 0x132E6C0
	public override int GetHashCode() { }

	// RVA: 0x132E730
	public static string ToString(BitVector32 value) { }

	// RVA: 0x132EA60
	public override string ToString() { }

}

// Namespace: System.Collections.Specialized
[Serializable]
public class NameValueCollection
{
	// Fields
	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	// Methods

	// RVA: 0x132EA68
	public void .ctor() { }

	// RVA: 0x132EB98
	public void .ctor(int capacity) { }

	// RVA: 0x132ED14
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x132EDC4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x132EE70
	protected void InvalidateCachedArrays() { }

	// RVA: 0x132EEA4
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x132F070
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x132F12C
	public virtual void Add(string name, string value) { }

	// RVA: 0x132F458
	public virtual string Get(string name) { }

	// RVA: 0x132F4F0
	public virtual string[] GetValues(string name) { }

	// RVA: 0x132F654
	public virtual void Set(string name, string value) { }

	// RVA: 0x132F81C
	public virtual void Remove(string name) { }

	// RVA: 0x132FB88
	public string get_Item(string name) { }

	// RVA: 0x132FB98
	public void set_Item(string name, string value) { }

	// RVA: 0x132FBA8
	public virtual string Get(int index) { }

	// RVA: 0x132FD68
	public virtual string GetKey(int index) { }

	// RVA: 0x132FEB8
	internal void .ctor(DBNull dummy) { }

}

// Namespace: 
private class OrderedDictionaryEnumerator
{
	// Fields
	private int _objectReturnType; // 0x10
	private IEnumerator _arrayEnumerator; // 0x18

	// Methods

	// RVA: 0x13312CC
	internal void .ctor(ArrayList array, int objectReturnType) { }

	// RVA: 0x1331BC0
	public object get_Current() { }

	// RVA: 0x1331DBC
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1331F70
	public object get_Key() { }

	// RVA: 0x1332064
	public object get_Value() { }

	// RVA: 0x1332158
	public bool MoveNext() { }

	// RVA: 0x133220C
	public void Reset() { }

}

// Namespace: 
private class OrderedDictionaryKeyValueCollection
{
	// Fields
	private ArrayList _objects; // 0x10
	private bool _isKeys; // 0x18

	// Methods

	// RVA: 0x1330290
	public void .ctor(ArrayList array, bool isKeys) { }

	// RVA: 0x13322C4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x13326A0
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x13326C8
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x13326D0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x13326F8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Collections.Specialized
[Serializable]
public class OrderedDictionary
{
	// Fields
	private ArrayList _objectsArray; // 0x10
	private Hashtable _objectsTable; // 0x18
	private int _initialCapacity; // 0x20
	private IEqualityComparer _comparer; // 0x28
	private bool _readOnly; // 0x30
	private object _syncRoot; // 0x38
	private SerializationInfo _siInfo; // 0x40

	// Methods

	// RVA: 0x132FF48
	public void .ctor() { }

	// RVA: 0x132FF7C
	public void .ctor(int capacity) { }

	// RVA: 0x132FFB4
	public void .ctor(int capacity, IEqualityComparer comparer) { }

	// RVA: 0x132FFF8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x133002C
	public int get_Count() { }

	// RVA: 0x133016C
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x1330174
	public bool get_IsReadOnly() { }

	// RVA: 0x133017C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1330184
	public ICollection get_Keys() { }

	// RVA: 0x13300C8
	private ArrayList get_objectsArray() { }

	// RVA: 0x13302D8
	private Hashtable get_objectsTable() { }

	// RVA: 0x1330390
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x133041C
	public object get_Item(object key) { }

	// RVA: 0x13304D0
	public void set_Item(object key, object value) { }

	// RVA: 0x1330BA0
	public ICollection get_Values() { }

	// RVA: 0x13309AC
	public void Add(object key, object value) { }

	// RVA: 0x1330CA8
	public void Clear() { }

	// RVA: 0x1330E1C
	public bool Contains(object key) { }

	// RVA: 0x1330ED0
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1330780
	private int IndexOfKey(object key) { }

	// RVA: 0x1330F94
	public void Remove(object key) { }

	// RVA: 0x1331190
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1331330
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x133146C
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13316AC
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x13316BC
	protected virtual void OnDeserialization(object sender) { }

}

// Namespace: System.Collections.Specialized
[Serializable]
public class StringCollection
{
	// Fields
	private readonly ArrayList data; // 0x10

	// Methods

	// RVA: 0x13327A0
	public string get_Item(int index) { }

	// RVA: 0x1332828
	public void set_Item(int index, string value) { }

	// RVA: 0x1332850
	public int get_Count() { }

	// RVA: 0x1332878
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1332880
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1332888
	public int Add(string value) { }

	// RVA: 0x13328B0
	public void Clear() { }

	// RVA: 0x13328D8
	public bool Contains(string value) { }

	// RVA: 0x1332900
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x1332928
	public int IndexOf(string value) { }

	// RVA: 0x1332950
	public void Insert(int index, string value) { }

	// RVA: 0x1332978
	public bool get_IsSynchronized() { }

	// RVA: 0x1332980
	public void Remove(string value) { }

	// RVA: 0x13329A8
	public void RemoveAt(int index) { }

	// RVA: 0x13329D0
	public object get_SyncRoot() { }

	// RVA: 0x13329F8
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1332A80
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1332B10
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1332B98
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1332C20
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1332CA8
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1332D38
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1332DC0
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1332DE8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1332E10
	public void .ctor() { }

}

// Namespace: System.Collections.Specialized
[Serializable]
public class StringDictionary
{
	// Fields
	internal Hashtable contents; // 0x10

	// Methods

	// RVA: 0x1332E88
	public void .ctor() { }

	// RVA: 0x1332F00
	public virtual string get_Item(string key) { }

	// RVA: 0x1332FE4
	public virtual IEnumerator GetEnumerator() { }

}

// Namespace: System.Collections.Specialized
public enum NotifyCollectionChangedAction
{
	// Fields
	public int value__; // 0x10
	public const NotifyCollectionChangedAction Add = 0;
	public const NotifyCollectionChangedAction Remove = 1;
	public const NotifyCollectionChangedAction Replace = 2;
	public const NotifyCollectionChangedAction Move = 3;
	public const NotifyCollectionChangedAction Reset = 4;
}

// Namespace: System.Collections.Specialized
public class NotifyCollectionChangedEventArgs
{
	// Fields
	private NotifyCollectionChangedAction _action; // 0x10
	private IList _newItems; // 0x18
	private IList _oldItems; // 0x20
	private int _newStartingIndex; // 0x28
	private int _oldStartingIndex; // 0x2C

	// Methods

	// RVA: 0x133300C
	public void .ctor(NotifyCollectionChangedAction action) { }

	// RVA: 0x1333228
	public void .ctor(NotifyCollectionChangedAction action, object changedItem, int index) { }

	// RVA: 0x1333588
	public void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	// RVA: 0x13338C4
	public void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	// RVA: 0x133345C
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x1333180
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	// RVA: 0x1333A9C
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

	// RVA: 0x13337A0
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }

}

// Namespace: System.Collections.Specialized
public sealed class NotifyCollectionChangedEventHandler
{
	// Methods

	// RVA: 0x1333B78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1333C9C
	public virtual void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }

}

// Namespace: System.Collections.Specialized
internal sealed class ReadOnlyList
{
	// Fields
	private readonly IList _list; // 0x10

	// Methods

	// RVA: 0x1333B44
	internal void .ctor(IList list) { }

	// RVA: 0x1333CB0
	public int get_Count() { }

	// RVA: 0x1333D68
	public bool get_IsReadOnly() { }

	// RVA: 0x1333D70
	public bool get_IsFixedSize() { }

	// RVA: 0x1333D78
	public bool get_IsSynchronized() { }

	// RVA: 0x1333E30
	public object get_Item(int index) { }

	// RVA: 0x1333EE4
	public void set_Item(int index, object value) { }

	// RVA: 0x1333F38
	public object get_SyncRoot() { }

	// RVA: 0x1333FF0
	public int Add(object value) { }

	// RVA: 0x1334044
	public void Clear() { }

	// RVA: 0x1334098
	public bool Contains(object value) { }

	// RVA: 0x1334150
	public void CopyTo(Array array, int index) { }

	// RVA: 0x133420C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x13342C0
	public int IndexOf(object value) { }

	// RVA: 0x1334378
	public void Insert(int index, object value) { }

	// RVA: 0x13343CC
	public void Remove(object value) { }

	// RVA: 0x1334420
	public void RemoveAt(int index) { }

}

// Namespace: 
internal class NameObjectEntry
{
	// Fields
	internal string Key; // 0x10
	internal object Value; // 0x18

	// Methods

	// RVA: 0x13357F4
	internal void .ctor(string name, object value) { }

}

// Namespace: 
[Serializable]
internal class NameObjectKeysEnumerator
{
	// Fields
	private int _pos; // 0x10
	private NameObjectCollectionBase _coll; // 0x18
	private int _version; // 0x20

	// Methods

	// RVA: 0x13358D8
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x1335E10
	public bool MoveNext() { }

	// RVA: 0x1335EF4
	public void Reset() { }

	// RVA: 0x1335F80
	public object get_Current() { }

}

// Namespace: System.Collections.Specialized
[Serializable]
public abstract class NameObjectCollectionBase
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private object _syncRoot; // 0x48
	private static StringComparer defaultComparer; // 0x0

	// Methods

	// RVA: 0x132EB2C
	protected void .ctor() { }

	// RVA: 0x1334474
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x132ED94
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x132EC24
	protected void .ctor(int capacity) { }

	// RVA: 0x132FF40
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x132EE3C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13346EC
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1334F38
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x1334530
	private void Reset() { }

	// RVA: 0x1334604
	private void Reset(int capacity) { }

	// RVA: 0x1335714
	private NameObjectEntry FindEntry(string key) { }

	// RVA: 0x13357EC
	protected bool get_IsReadOnly() { }

	// RVA: 0x132F2D0
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x132F860
	protected void BaseRemove(string name) { }

	// RVA: 0x132F2B4
	protected object BaseGet(string name) { }

	// RVA: 0x132F75C
	protected void BaseSet(string name, object value) { }

	// RVA: 0x132FCC0
	protected object BaseGet(int index) { }

	// RVA: 0x132FE10
	protected string BaseGetKey(int index) { }

	// RVA: 0x1335844
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1335938
	public virtual int get_Count() { }

	// RVA: 0x1335960
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1335C98
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1335D24
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1335D2C
	private static void .cctor() { }

}

// Namespace: System.Collections.Specialized
[Serializable]
internal class CompatibleComparer
{
	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Methods

	// RVA: 0x13356C4
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x13360A8
	public bool Equals(object a, object b) { }

	// RVA: 0x13362C8
	public int GetHashCode(object obj) { }

	// RVA: 0x13363E0
	public IComparer get_Comparer() { }

	// RVA: 0x13363E8
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x1334E4C
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x1334D68
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

}

// Namespace: 
private sealed class WorkStealingQueue
{
	// Fields
	private int _headIndex; // 0x0
	private int _tailIndex; // 0x0
	private T[] _array; // 0x0
	private int _mask; // 0x0
	private int _addTakeCount; // 0x0
	private int _stealCount; // 0x0
	internal int _currentOp; // 0x0
	internal bool _frozen; // 0x0
	internal readonly WorkStealingQueue _nextQueue; // 0x0
	internal readonly int _ownerThreadId; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	internal void .ctor(WorkStealingQueue nextQueue) { }

	// RVA: 0x316B894
	internal void LocalPush(T item, Int64 emptyToNonEmptyListTransitionCount) { }

	// RVA: -1
	internal int DangerousCopyTo(T[] array, int arrayIndex) { }

	// RVA: 0x30B199C
	internal int get_DangerousCount() { }

}

// Namespace: 
[Serializable]
private sealed class Enumerator
{
	// Fields
	private readonly T[] _array; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(T[] array) { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x316B894
	public T get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B2870
	public void Reset() { }

	// RVA: 0x30B2870
	public void Dispose() { }

}

// Namespace: System.Collections.Concurrent
[Serializable]
public class ConcurrentBag<T0>
{
	// Fields
	private readonly System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag.WorkStealingQueue<T>> _locals; // 0x0
	private WorkStealingQueue _workStealingQueues; // 0x0
	private Int64 _emptyToNonEmptyListTransitionCount; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	public void Add(T item) { }

	// RVA: -1
	private WorkStealingQueue GetCurrentThreadWorkStealingQueue(bool forceCreate) { }

	// RVA: 0x30B1CD4
	private WorkStealingQueue CreateWorkStealingQueueForCurrentThread() { }

	// RVA: 0x30B1CD4
	private WorkStealingQueue GetUnownedWorkStealingQueue() { }

	// RVA: 0x30B2D20
	public void CopyTo(T[] array, int index) { }

	// RVA: -1
	private int CopyFromEachQueueToArray(T[] array, int index) { }

	// RVA: 0x30B2D20
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30B1CD4
	public T[] ToArray() { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B199C
	private int get_DangerousCount() { }

	// RVA: 0x30B171C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30B1CD4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30B1CD4
	private object get_GlobalQueuesLock() { }

	// RVA: 0x30B2CB8
	private void FreezeBag(bool lockTaken) { }

	// RVA: 0x30B28FC
	private void UnfreezeBag(bool lockTaken) { }

}

// Namespace: System.Collections.Generic
internal struct ValueListBuilder<T0>
{
	// Fields
	private System.Span<T> _span; // 0x0
	private T[] _arrayFromPool; // 0x0
	private int _pos; // 0x0

	// Methods

	// RVA: 0x316B894
	public void .ctor(System.Span<T> initialSpan) { }

	// RVA: 0x30B199C
	public int get_Length() { }

	// RVA: -1
	public T get_Item(int index) { }

	// RVA: 0x316B894
	public void Append(T item) { }

	// RVA: 0x316B894
	public System.ReadOnlySpan<T> AsSpan() { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B2870
	private void Grow() { }

	// RVA: 0x316B894
	public T Pop() { }

}

// Namespace: System.Collections.Generic
internal sealed class BitHelper
{
	// Fields
	private readonly int _length; // 0x10
	private readonly Int32* _arrayPtr; // 0x18
	private readonly int[] _array; // 0x20
	private readonly bool _useStackAlloc; // 0x28

	// Methods

	// RVA: 0x13363F0
	internal void .ctor(Int32* bitArrayPtr, int length) { }

	// RVA: 0x1336434
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x133647C
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x13364FC
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x1336584
	internal static int ToIntArrayLength(int n) { }

}

// Namespace: System.Collections.Generic
internal sealed class ICollectionDebugView<T0>
{}

// Namespace: System.Collections.Generic
internal sealed class IDictionaryDebugView<T0, T1>
{}

// Namespace: System.Collections.Generic
internal sealed class DictionaryKeyCollectionDebugView<T0, T1>
{}

// Namespace: System.Collections.Generic
internal sealed class DictionaryValueCollectionDebugView<T0, T1>
{}

// Namespace: 
[Serializable]
public struct Enumerator
{
	// Fields
	private System.Collections.Generic.LinkedList<T> _list; // 0x0
	private System.Collections.Generic.LinkedListNode<T> _node; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	internal void .ctor(System.Collections.Generic.LinkedList<T> list) { }

	// RVA: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x316B894
	public T get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30B2CB8
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

}

// Namespace: System.Collections.Generic
[Serializable]
public class LinkedList<T0>
{
	// Fields
	internal System.Collections.Generic.LinkedListNode<T> head; // 0x0
	internal int count; // 0x0
	internal int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo _siInfo; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.LinkedListNode<T> get_First() { }

	// RVA: 0x30B171C
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x316B894
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }

	// RVA: 0x316B894
	public System.Collections.Generic.LinkedListNode<T> AddFirst(T value) { }

	// RVA: 0x316B894
	public System.Collections.Generic.LinkedListNode<T> AddLast(T value) { }

	// RVA: 0x30B2CB8
	public void AddLast(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x316B894
	public bool Contains(T value) { }

	// RVA: 0x30B2D20
	public void CopyTo(T[] array, int index) { }

	// RVA: 0x316B894
	public System.Collections.Generic.LinkedListNode<T> Find(T value) { }

	// RVA: 0x316B894
	public Enumerator GetEnumerator() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x316B894
	public bool Remove(T value) { }

	// RVA: 0x30B2CB8
	public void Remove(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30B2870
	public void RemoveFirst() { }

	// RVA: -1
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30B2CB8
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x30B2F18
	private void InternalInsertNodeBefore(System.Collections.Generic.LinkedListNode<T> node, System.Collections.Generic.LinkedListNode<T> newNode) { }

	// RVA: 0x30B2CB8
	private void InternalInsertNodeToEmptyList(System.Collections.Generic.LinkedListNode<T> newNode) { }

	// RVA: 0x30B2CB8
	internal void InternalRemoveNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30B2CB8
	internal void ValidateNewNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30B2CB8
	internal void ValidateNode(System.Collections.Generic.LinkedListNode<T> node) { }

	// RVA: 0x30B171C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30B1CD4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30B2D20
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Collections.Generic
public sealed class LinkedListNode<T0>
{
	// Fields
	internal System.Collections.Generic.LinkedList<T> list; // 0x0
	internal System.Collections.Generic.LinkedListNode<T> next; // 0x0
	internal System.Collections.Generic.LinkedListNode<T> prev; // 0x0
	internal T item; // 0x0

	// Methods

	// RVA: 0x316B894
	internal void .ctor(System.Collections.Generic.LinkedList<T> list, T value) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.LinkedListNode<T> get_Next() { }

	// RVA: 0x316B894
	public T get_Value() { }

	// RVA: 0x30B2870
	internal void Invalidate() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _treeEnum; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Methods

	// RVA: 0x30B2D20
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary, int getEnumeratorRetType) { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x316B894
	public System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }

	// RVA: 0x30B171C
	internal bool get_NotStartedOrEnded() { }

	// RVA: 0x30B2870
	internal void Reset() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: -1
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _dictEnum; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x316B894
	public TKey get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public TKey[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B183C
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B183C
	internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
[Serializable]
public sealed class KeyCollection
{
	// Fields
	private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30B2D20
	public void CopyTo(TKey[] array, int index) { }

	// RVA: 0x30B2D20
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B171C
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

	// RVA: 0x316B894
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

	// RVA: 0x30B2870
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

	// RVA: 0x30B171C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30B1CD4
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _dictEnum; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	internal void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x316B894
	public TValue get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public TValue[] array; // 0x0
	public int index; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B183C
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B183C
	internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: 
[Serializable]
public sealed class ValueCollection
{
	// Fields
	private System.Collections.Generic.SortedDictionary<TKey,TValue> _dictionary; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.SortedDictionary<TKey,TValue> dictionary) { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30B2D20
	public void CopyTo(TValue[] array, int index) { }

	// RVA: 0x30B2D20
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B171C
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

	// RVA: 0x316B894
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

	// RVA: 0x30B2870
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

	// RVA: 0x30B171C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30B1CD4
	private object System.Collections.ICollection.get_SyncRoot() { }

}

// Namespace: 
[Serializable]
internal sealed class KeyValuePairComparer
{
	// Fields
	internal System.Collections.Generic.IComparer<TKey> keyComparer; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.IComparer<TKey> keyComparer) { }

	// RVA: 0x316B894
	public override int Compare(System.Collections.Generic.KeyValuePair<TKey,TValue> x, System.Collections.Generic.KeyValuePair<TKey,TValue> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_0
{
	// Fields
	public bool found; // 0x0
	public TValue value; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B183C
	internal bool <ContainsValue>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass34_1
{
	// Fields
	public System.Collections.Generic.EqualityComparer<TValue> valueComparer; // 0x0
	public System.Collections.Generic.SortedDictionary.<>c__DisplayClass34_0<TKey,TValue> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B183C
	internal bool <ContainsValue>b__1(Node node) { }

}

// Namespace: System.Collections.Generic
[Serializable]
public class SortedDictionary<T0, T1>
{
	// Fields
	private KeyCollection _keys; // 0x0
	private ValueCollection _values; // 0x0
	private System.Collections.Generic.TreeSet<System.Collections.Generic.KeyValuePair<TKey,TValue>> _set; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }

	// RVA: 0x316B894
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x30B171C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x316B894
	public TValue get_Item(TKey key) { }

	// RVA: 0x316B894
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B1CD4
	public KeyCollection get_Keys() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30B1CD4
	public ValueCollection get_Values() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x316B894
	public void Add(TKey key, TValue value) { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x316B894
	public bool ContainsKey(TKey key) { }

	// RVA: 0x316B894
	public bool ContainsValue(TValue value) { }

	// RVA: 0x30B2D20
	public void CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int index) { }

	// RVA: 0x316B894
	public Enumerator GetEnumerator() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x316B894
	public bool Remove(TKey key) { }

	// RVA: 0x316B894
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x30B2D20
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30B171C
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x30B171C
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x30B1CD4
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x30B1CD4
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x30B1D84
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x30B2F18
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x30B2F18
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x30B183C
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x30B3E68
	private static bool IsCompatibleKey(object key) { }

	// RVA: 0x30B1CD4
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x30B2CB8
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x30B171C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30B1CD4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Collections.Generic
[Serializable]
internal sealed class TreeSet<T0>
{
	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: -1
	public void .ctor(SerializationInfo siInfo, StreamingContext context) { }

	// RVA: 0x316B894
	internal override bool AddIfNotPresent(T item) { }

}

// Namespace: 
[Serializable]
private struct Enumerator
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _sortedList; // 0x0
	private TKey _key; // 0x0
	private TValue _value; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Methods

	// RVA: 0x30B2D20
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList, int getEnumeratorRetType) { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: -1
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: 0x316B894
	public System.Collections.Generic.KeyValuePair<TKey,TValue> get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
private sealed class SortedListKeyEnumerator
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TKey _currentKey; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x316B894
	public TKey get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
private sealed class SortedListValueEnumerator
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _sortedList; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private TValue _currentValue; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> sortedList) { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x316B894
	public TValue get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
private sealed class KeyList
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _dict; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B171C
	public bool get_IsReadOnly() { }

	// RVA: 0x30B171C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30B1CD4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x316B894
	public void Add(TKey key) { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x316B894
	public bool Contains(TKey key) { }

	// RVA: 0x30B2D20
	public void CopyTo(TKey[] array, int arrayIndex) { }

	// RVA: 0x30B2D20
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x316B894
	public void Insert(int index, TKey value) { }

	// RVA: 0x316B894
	public TKey get_Item(int index) { }

	// RVA: 0x316B894
	public void set_Item(int index, TKey value) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<TKey> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x316B894
	public int IndexOf(TKey key) { }

	// RVA: 0x316B894
	public bool Remove(TKey key) { }

	// RVA: 0x30B29E8
	public void RemoveAt(int index) { }

}

// Namespace: 
[Serializable]
private sealed class ValueList
{
	// Fields
	private System.Collections.Generic.SortedList<TKey,TValue> _dict; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	internal void .ctor(System.Collections.Generic.SortedList<TKey,TValue> dictionary) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B171C
	public bool get_IsReadOnly() { }

	// RVA: 0x30B171C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30B1CD4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x316B894
	public void Add(TValue key) { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x316B894
	public bool Contains(TValue value) { }

	// RVA: 0x30B2D20
	public void CopyTo(TValue[] array, int arrayIndex) { }

	// RVA: 0x30B2D20
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x316B894
	public void Insert(int index, TValue value) { }

	// RVA: 0x316B894
	public TValue get_Item(int index) { }

	// RVA: 0x316B894
	public void set_Item(int index, TValue value) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x316B894
	public int IndexOf(TValue value) { }

	// RVA: 0x316B894
	public bool Remove(TValue value) { }

	// RVA: 0x30B29E8
	public void RemoveAt(int index) { }

}

// Namespace: System.Collections.Generic
[Serializable]
public class SortedList<T0, T1>
{
	// Fields
	private TKey[] keys; // 0x0
	private TValue[] values; // 0x0
	private int _size; // 0x0
	private int version; // 0x0
	private System.Collections.Generic.IComparer<TKey> comparer; // 0x0
	private KeyList keyList; // 0x0
	private ValueList valueList; // 0x0
	private object _syncRoot; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.IComparer<TKey> comparer) { }

	// RVA: 0x316B894
	public void Add(TKey key, TValue value) { }

	// RVA: 0x316B894
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> keyValuePair) { }

	// RVA: 0x30B29E8
	public void set_Capacity(int value) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IComparer<TKey> get_Comparer() { }

	// RVA: 0x30B2F18
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30B1CD4
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x30B1CD4
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x30B1CD4
	private KeyList GetKeyListHelper() { }

	// RVA: 0x30B1CD4
	private ValueList GetValueListHelper() { }

	// RVA: 0x30B171C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x30B171C
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x30B171C
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x30B171C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30B1CD4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x30B183C
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x316B894
	public bool ContainsKey(TKey key) { }

	// RVA: 0x316B894
	public bool ContainsValue(TValue value) { }

	// RVA: 0x30B2D20
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x30B2D20
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30B29E8
	private void EnsureCapacity(int min) { }

	// RVA: 0x316B894
	private TValue GetByIndex(int index) { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> GetEnumerator() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x316B894
	private TKey GetKey(int index) { }

	// RVA: 0x316B894
	public TValue get_Item(TKey key) { }

	// RVA: 0x316B894
	public void set_Item(TKey key, TValue value) { }

	// RVA: 0x30B1D84
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x30B2F18
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x316B894
	public int IndexOfKey(TKey key) { }

	// RVA: 0x316B894
	public int IndexOfValue(TValue value) { }

	// RVA: 0x316B894
	private void Insert(int index, TKey key, TValue value) { }

	// RVA: 0x316B894
	public bool TryGetValue(TKey key, TValue value) { }

	// RVA: 0x30B29E8
	public void RemoveAt(int index) { }

	// RVA: 0x316B894
	public bool Remove(TKey key) { }

	// RVA: 0x30B2CB8
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x30B3E68
	private static bool IsCompatibleKey(object key) { }

}

// Namespace: 
[Serializable]
internal sealed class TreeSubSet
{}

// Namespace: 
[Serializable]
internal sealed class Node
{
	// Fields
	private T <Item>k__BackingField; // 0x0
	private Node <Left>k__BackingField; // 0x0
	private Node <Right>k__BackingField; // 0x0
	private NodeColor <Color>k__BackingField; // 0x0

	// Methods

	// RVA: 0x316B894
	public void .ctor(T item, NodeColor color) { }

	// RVA: 0x30B3E68
	public static bool IsNonNullRed(Node node) { }

	// RVA: 0x30B3E68
	public static bool IsNullOrBlack(Node node) { }

	// RVA: 0x316B894
	public T get_Item() { }

	// RVA: 0x316B894
	public void set_Item(T value) { }

	// RVA: 0x30B1CD4
	public Node get_Left() { }

	// RVA: 0x30B2CB8
	public void set_Left(Node value) { }

	// RVA: 0x30B1CD4
	public Node get_Right() { }

	// RVA: 0x30B2CB8
	public void set_Right(Node value) { }

	// RVA: 0x30B171C
	public NodeColor get_Color() { }

	// RVA: 0x30B28FC
	public void set_Color(NodeColor value) { }

	// RVA: 0x30B171C
	public bool get_IsBlack() { }

	// RVA: 0x30B171C
	public bool get_IsRed() { }

	// RVA: 0x30B171C
	public bool get_Is2Node() { }

	// RVA: 0x30B171C
	public bool get_Is4Node() { }

	// RVA: 0x30B2870
	public void ColorBlack() { }

	// RVA: 0x30B2870
	public void ColorRed() { }

	// RVA: -1
	public Node DeepClone(int count) { }

	// RVA: -1
	public TreeRotation GetRotation(Node current, Node sibling) { }

	// RVA: 0x30B1D84
	public Node GetSibling(Node node) { }

	// RVA: 0x30B1CD4
	public Node ShallowClone() { }

	// RVA: 0x30B2870
	public void Split4Node() { }

	// RVA: -1
	public Node Rotate(TreeRotation rotation) { }

	// RVA: 0x30B1CD4
	public Node RotateLeft() { }

	// RVA: 0x30B1CD4
	public Node RotateLeftRight() { }

	// RVA: 0x30B1CD4
	public Node RotateRight() { }

	// RVA: 0x30B1CD4
	public Node RotateRightLeft() { }

	// RVA: 0x30B2870
	public void Merge2Nodes() { }

	// RVA: 0x30B2F18
	public void ReplaceChild(Node child, Node newChild) { }

}

// Namespace: 
[Serializable]
public struct Enumerator
{
	// Fields
	private static readonly Node s_dummyNode; // 0x0
	private System.Collections.Generic.SortedSet<T> _tree; // 0x0
	private int _version; // 0x0
	private System.Collections.Generic.Stack<System.Collections.Generic.SortedSet.Node<T>> _stack; // 0x0
	private Node _current; // 0x0
	private bool _reverse; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	internal void .ctor(System.Collections.Generic.SortedSet<T> set) { }

	// RVA: -1
	internal void .ctor(System.Collections.Generic.SortedSet<T> set, bool reverse) { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30B2CB8
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x30B2870
	private void Initialize() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x316B894
	public T get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B171C
	internal bool get_NotStartedOrEnded() { }

	// RVA: 0x30B2870
	internal void Reset() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30B71FC
	private static void .cctor() { }

}

// Namespace: 
internal struct ElementCount
{
	// Fields
	internal int UniqueCount; // 0x0
	internal int UnfoundCount; // 0x0
}

// Namespace: 
private sealed class <>c__DisplayClass52_0
{
	// Fields
	public int index; // 0x0
	public int count; // 0x0
	public T[] array; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B183C
	internal bool <CopyTo>b__0(Node node) { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public int index; // 0x0
	public object[] objects; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B183C
	internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

}

// Namespace: System.Collections.Generic
[Serializable]
public class SortedSet<T0>
{
	// Fields
	private Node root; // 0x0
	private System.Collections.Generic.IComparer<T> comparer; // 0x0
	private int count; // 0x0
	private int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo siInfo; // 0x0
	private const string ComparerName = "Comparer";
	private const string CountName = "Count";
	private const string ItemsName = "Items";
	private const string VersionName = "Version";
	private const string TreeName = "Tree";
	private const string NodeValueName = "Item";
	private const string EnumStartName = "EnumStarted";
	private const string ReverseName = "Reverse";
	private const string EnumVersionName = "EnumVersion";
	private const string MinName = "Min";
	private const string MaxName = "Max";
	private const string LowerBoundActiveName = "lBoundActive";
	private const string UpperBoundActiveName = "uBoundActive";
	internal const int StackAllocThreshold = 100;

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: 0x30B2F18
	public void .ctor(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IComparer<T> comparer) { }

	// RVA: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30B2CB8
	private void AddAllElements(System.Collections.Generic.IEnumerable<T> collection) { }

	// RVA: 0x30B183C
	internal virtual bool InOrderTreeWalk(System.Collections.Generic.TreeWalkPredicate<T> action) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B1CD4
	public System.Collections.Generic.IComparer<T> get_Comparer() { }

	// RVA: 0x30B171C
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	// RVA: 0x30B171C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30B1CD4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x30B2870
	internal virtual void VersionCheck() { }

	// RVA: 0x316B894
	internal virtual bool IsWithinRange(T item) { }

	// RVA: 0x316B894
	public bool Add(T item) { }

	// RVA: 0x316B894
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }

	// RVA: 0x316B894
	internal virtual bool AddIfNotPresent(T item) { }

	// RVA: 0x316B894
	public bool Remove(T item) { }

	// RVA: 0x316B894
	internal virtual bool DoRemove(T item) { }

	// RVA: 0x30B2870
	public virtual void Clear() { }

	// RVA: 0x316B894
	public virtual bool Contains(T item) { }

	// RVA: 0x30B2D20
	public void CopyTo(T[] array, int index) { }

	// RVA: -1
	public void CopyTo(T[] array, int index, int count) { }

	// RVA: 0x30B2D20
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x316B894
	public Enumerator GetEnumerator() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30B3158
	private void InsertionBalance(Node current, Node parent, Node grandParent, Node greatGrandParent) { }

	// RVA: 0x30B30EC
	private void ReplaceChildOrRoot(Node parent, Node child, Node newChild) { }

	// RVA: 0x30B3158
	private void ReplaceNode(Node match, Node parentOfMatch, Node successor, Node parentOfSuccessor) { }

	// RVA: 0x316B894
	internal virtual Node FindNode(T item) { }

	// RVA: 0x316B894
	internal virtual int InternalIndexOf(T item) { }

	// RVA: 0x30B2870
	internal void UpdateVersion() { }

	// RVA: 0x30B183C
	private bool HasEqualComparer(System.Collections.Generic.SortedSet<T> other) { }

	// RVA: 0x30B2CB8
	public void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x316B894
	private static Node ConstructRootFromSortedArray(T[] arr, int startIndex, int endIndex, Node redNode) { }

	// RVA: 0x30B2CB8
	public virtual void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x30B2CB8
	internal virtual void IntersectWithEnumerable(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x30B183C
	public bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: 0x316B894
	private ElementCount CheckUniqueAndUnfoundElements(System.Collections.Generic.IEnumerable<T> other, bool returnIfUnfound) { }

	// RVA: 0x316B894
	public T get_Min() { }

	// RVA: 0x316B894
	internal virtual T get_MinInternal() { }

	// RVA: 0x316B894
	public T get_Max() { }

	// RVA: 0x316B894
	internal virtual T get_MaxInternal() { }

	// RVA: -1
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: -1
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30B2CB8
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x30B2CB8
	protected virtual void OnDeserialization(object sender) { }

	// RVA: -1
	private static int Log2(int value) { }

}

// Namespace: System.Collections.Generic
internal enum NodeColor
{
	// Fields
	public Byte value__; // 0x10
	public const NodeColor Black = 0;
	public const NodeColor Red = 1;
}

// Namespace: System.Collections.Generic
internal sealed class TreeWalkPredicate<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x30B183C
	public virtual bool Invoke(Node node) { }

}

// Namespace: System.Collections.Generic
internal enum TreeRotation
{
	// Fields
	public Byte value__; // 0x10
	public const TreeRotation Left = 0;
	public const TreeRotation LeftRight = 1;
	public const TreeRotation Right = 2;
	public const TreeRotation RightLeft = 3;
}

// Namespace: System.Collections.Generic
public interface ISet<T0>
{
	// Methods

	// RVA: -1
	public abstract bool Add(T item) { }

	// RVA: -1
	public abstract void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: -1
	public abstract void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }

	// RVA: -1
	public abstract bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { }

}

// Namespace: System.IO
[Serializable]
public class InternalBufferOverflowException
{
	// Methods

	// RVA: 0x1336598
	public void .ctor() { }

	// RVA: 0x13365F0
	public void .ctor(string message) { }

	// RVA: 0x13365F8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: System.IO.Compression
public enum CompressionMode
{
	// Fields
	public int value__; // 0x10
	public const CompressionMode Decompress = 0;
	public const CompressionMode Compress = 1;
}

// Namespace: System.IO.Compression
public class GZipStream
{
	// Fields
	private DeflateStream _deflateStream; // 0x28

	// Methods

	// RVA: 0x1336600
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1336608
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x13366CC
	public override bool get_CanRead() { }

	// RVA: 0x13366E4
	public override bool get_CanWrite() { }

	// RVA: 0x13366FC
	public override bool get_CanSeek() { }

	// RVA: 0x1336714
	public override Int64 get_Length() { }

	// RVA: 0x1336768
	public override Int64 get_Position() { }

	// RVA: 0x13367BC
	public override void set_Position(Int64 value) { }

	// RVA: 0x1336810
	public override void Flush() { }

	// RVA: 0x1336854
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x13368A8
	public override int ReadByte() { }

	// RVA: 0x13368D0
	public override IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1336988
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x13369F0
	public override int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x1336A18
	public override int Read(System.Span<System.Byte> buffer) { }

	// RVA: 0x1336C2C
	public override IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1336CE4
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1336CF0
	public override void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x1336D18
	public override void Write(System.ReadOnlySpan<System.Byte> buffer) { }

	// RVA: 0x1336EFC
	public override void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x1336F24
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1336FE8
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1337010
	public override System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x13370FC
	public override Task WriteAsync(Byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1337124
	public override ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1337210
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1336838
	private void CheckDeflateStream() { }

	// RVA: 0x1337238
	private static void ThrowStreamClosedException() { }

}

// Namespace: 
private sealed class ReadMethod
{
	// Methods

	// RVA: 0x1338544
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1339084
	public virtual int Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x1338600
	public virtual IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x1338D68
	public virtual int EndInvoke(IAsyncResult result) { }

}

// Namespace: 
private sealed class WriteMethod
{
	// Methods

	// RVA: 0x1338A6C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1339098
	public virtual void Invoke(Byte[] array, int offset, int count) { }

	// RVA: 0x1338B28
	public virtual IAsyncResult BeginInvoke(Byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x1338EEC
	public virtual void EndInvoke(IAsyncResult result) { }

}

// Namespace: System.IO.Compression
public class DeflateStream
{
	// Fields
	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private bool leaveOpen; // 0x34
	private bool disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	// Methods

	// RVA: 0x1337290
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x13366C4
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x133729C
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x13376D8
	protected override void Finalize() { }

	// RVA: 0x1337778
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13379A0
	private int ReadInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x13370F4
	internal System.Threading.Tasks.ValueTask<System.Int32> ReadAsyncMemory(System.Memory<System.Byte> destination, CancellationToken cancellationToken) { }

	// RVA: 0x1336B04
	internal int ReadCore(System.Span<System.Byte> destination) { }

	// RVA: 0x1337AC4
	public override int Read(Byte[] array, int offset, int count) { }

	// RVA: 0x1337CE8
	private void WriteInternal(Byte[] array, int offset, int count) { }

	// RVA: 0x1337208
	internal ValueTask WriteAsyncMemory(System.ReadOnlyMemory<System.Byte> source, CancellationToken cancellationToken) { }

	// RVA: 0x1336E6C
	internal void WriteCore(System.ReadOnlySpan<System.Byte> source) { }

	// RVA: 0x1337E04
	public override void Write(Byte[] array, int offset, int count) { }

	// RVA: 0x1338044
	public override void Flush() { }

	// RVA: 0x13381AC
	public override IAsyncResult BeginRead(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x13386D4
	public override IAsyncResult BeginWrite(Byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1338BFC
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1338D94
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1338EF8
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1338F38
	public override bool get_CanRead() { }

	// RVA: 0x1338F78
	public override bool get_CanSeek() { }

	// RVA: 0x1338F80
	public override bool get_CanWrite() { }

	// RVA: 0x1338FC4
	public override Int64 get_Length() { }

	// RVA: 0x1339004
	public override Int64 get_Position() { }

	// RVA: 0x1339044
	public override void set_Position(Int64 value) { }

}

// Namespace: 
private sealed class UnmanagedReadOrWrite
{
	// Methods

	// RVA: 0x133924C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1339A80
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

}

// Namespace: 
private sealed class SafeDeflateStreamHandle
{
	// Methods

	// RVA: 0x1339A94
	public override bool get_IsInvalid() { }

	// RVA: 0x1339A6C
	private void .ctor() { }

	// RVA: 0x1339AA4
	protected override bool ReleaseHandle() { }

}

// Namespace: System.IO.Compression
internal class DeflateStreamNative
{
	// Fields
	private UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x30
	private Byte[] io_buffer; // 0x38
	private Exception last_error; // 0x40

	// Methods

	// RVA: 0x1339244
	private void .ctor() { }

	// RVA: 0x1337468
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x1339394
	protected override void Finalize() { }

	// RVA: 0x1337874
	public void Dispose(bool disposing) { }

	// RVA: 0x13380F8
	public void Flush() { }

	// RVA: 0x13379F4
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x1337D38
	public void WriteZStream(IntPtr buffer, int length) { }

	// RVA: 0x13390AC
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1339688
	private int UnmanagedRead(IntPtr buffer, int length) { }

	// RVA: 0x1339178
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x133986C
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x1339498
	private void CheckResult(int result, string where) { }

	// RVA: 0x13392F0
	private static extern SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x1339A7C
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x1339428
	private static extern int Flush(SafeDeflateStreamHandle stream) { }

	// RVA: 0x1339578
	private static extern int ReadZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x1339600
	private static extern int WriteZStream(SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

}

// Namespace: 
private enum StateFlags
{
	// Fields
	public Byte value__; // 0x10
	public const StateFlags None = 0;
	public const StateFlags CaptureIdentity = 1;
	public const StateFlags CaptureContext = 2;
	public const StateFlags ThreadSafeContextCopy = 4;
	public const StateFlags PostBlockStarted = 8;
	public const StateFlags PostBlockFinished = 16;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Net.ContextAwareResult.<>c <>9; // 0x0
	public static ContextCallback <>9__17_0; // 0x8

	// Methods

	// RVA: 0x133AF98
	private static void .cctor() { }

	// RVA: 0x133B004
	public void .ctor() { }

	// RVA: 0x133B00C
	internal void <Complete>b__17_0(object s) { }

}

// Namespace: System.Net
internal class ContextAwareResult
{
	// Fields
	private ExecutionContext _context; // 0x40
	private object _lock; // 0x48
	private StateFlags _flags; // 0x50

	// Methods

	// RVA: 0x1339B48
	private void SafeCaptureIdentity() { }

	// RVA: 0x1339B4C
	private void CleanupInternal() { }

	// RVA: 0x1339B50
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1339B58
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1339BC8
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1339C50
	internal object StartPostingAsyncOp() { }

	// RVA: 0x1339C58
	internal object StartPostingAsyncOp(bool lockCapture) { }

	// RVA: 0x1339F04
	internal bool FinishPostingAsyncOp() { }

	// RVA: 0x133A5A8
	protected override void Cleanup() { }

	// RVA: 0x1339F54
	private bool CaptureOrComplete(ExecutionContext cachedContext, bool returnContext) { }

	// RVA: 0x133AABC
	protected override void Complete(IntPtr userToken) { }

	// RVA: 0x133AE68
	private void CompleteCallback() { }

}

// Namespace: System.Net
internal static class HttpStatusDescription
{
	// Methods

	// RVA: 0x133B090
	internal static string Get(HttpStatusCode code) { }

	// RVA: 0x133B094
	internal static string Get(int code) { }

}

// Namespace: System.Net
internal static class HttpValidationHelpers
{
	// Fields
	private static readonly Char[] s_httpTrimCharacters; // 0x0

	// Methods

	// RVA: 0x133B984
	public static bool IsInvalidMethodOrHeaderString(string stringValue) { }

	// RVA: 0x133BAA8
	private static void .cctor() { }

}

// Namespace: 
public class Keywords
{
	// Fields
	public const EventKeywords Default = 1;
	public const EventKeywords Debug = 2;
	public const EventKeywords EnterExit = 4;
}

// Namespace: System.Net
internal sealed class NetEventSource
{
	// Fields
	public static readonly NetEventSource Log; // 0x0

	// Methods

	// RVA: 0x133BB4C
	public static void Enter(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x133C24C
	public static void Enter(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x133C7E8
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName) { }

	// RVA: 0x133C1C4
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	// RVA: 0x133C9C4
	public static void Exit(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x133CC18
	public static void Exit(object thisOrContextObject, object arg0, string memberName) { }

	// RVA: 0x133CB90
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	// RVA: 0x133A75C
	public static void Info(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	// RVA: 0x133A928
	public static void Info(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x133CDAC
	private void Info(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x133CE34
	public static void Error(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x133CFC8
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x1339D70
	public static void Fail(object thisOrContextObject, object message, string memberName) { }

	// RVA: 0x133D050
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	// RVA: 0x133D0D8
	public static void Associate(object first, object second, string memberName) { }

	// RVA: 0x133D274
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	// RVA: 0x133A6DC
	public static bool get_IsEnabled() { }

	// RVA: 0x133BD18
	public static string IdOf(object value) { }

	// RVA: 0x133D518
	public static int GetHashCode(object value) { }

	// RVA: 0x133C3F4
	public static object Format(object value) { }

	// RVA: 0x133BE18
	private static string Format(FormattableString s) { }

	// RVA: 0x133D300
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

	// RVA: 0x133D52C
	public void .ctor() { }

	// RVA: 0x133D534
	private static void .cctor() { }

}

// Namespace: System.Net
internal static class TcpValidationHelpers
{
	// Methods

	// RVA: 0x133D5A0
	public static bool ValidatePortNumber(int port) { }

}

// Namespace: System.Net
internal class TlsStream
{
	// Fields
	private SslStream _sslStream; // 0x48
	private string _host; // 0x50
	private X509CertificateCollection _clientCertificates; // 0x58

	// Methods

	// RVA: 0x133D5AC
	public void .ctor(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	// RVA: 0x133D6A4
	public void AuthenticateAsClient() { }

	// RVA: 0x133D7F4
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	// RVA: 0x133D95C
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x133D984
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x133D9AC
	public override void EndWrite(IAsyncResult result) { }

	// RVA: 0x133D9D4
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x133D9FC
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x133DA24
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x133DA4C
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x133DA74
	public override void Close() { }

}

// Namespace: System.Net
public enum HttpStatusCode
{
	// Fields
	public int value__; // 0x10
	public const HttpStatusCode Continue = 100;
	public const HttpStatusCode SwitchingProtocols = 101;
	public const HttpStatusCode Processing = 102;
	public const HttpStatusCode EarlyHints = 103;
	public const HttpStatusCode OK = 200;
	public const HttpStatusCode Created = 201;
	public const HttpStatusCode Accepted = 202;
	public const HttpStatusCode NonAuthoritativeInformation = 203;
	public const HttpStatusCode NoContent = 204;
	public const HttpStatusCode ResetContent = 205;
	public const HttpStatusCode PartialContent = 206;
	public const HttpStatusCode MultiStatus = 207;
	public const HttpStatusCode AlreadyReported = 208;
	public const HttpStatusCode IMUsed = 226;
	public const HttpStatusCode MultipleChoices = 300;
	public const HttpStatusCode Ambiguous = 300;
	public const HttpStatusCode MovedPermanently = 301;
	public const HttpStatusCode Moved = 301;
	public const HttpStatusCode Found = 302;
	public const HttpStatusCode Redirect = 302;
	public const HttpStatusCode SeeOther = 303;
	public const HttpStatusCode RedirectMethod = 303;
	public const HttpStatusCode NotModified = 304;
	public const HttpStatusCode UseProxy = 305;
	public const HttpStatusCode Unused = 306;
	public const HttpStatusCode TemporaryRedirect = 307;
	public const HttpStatusCode RedirectKeepVerb = 307;
	public const HttpStatusCode PermanentRedirect = 308;
	public const HttpStatusCode BadRequest = 400;
	public const HttpStatusCode Unauthorized = 401;
	public const HttpStatusCode PaymentRequired = 402;
	public const HttpStatusCode Forbidden = 403;
	public const HttpStatusCode NotFound = 404;
	public const HttpStatusCode MethodNotAllowed = 405;
	public const HttpStatusCode NotAcceptable = 406;
	public const HttpStatusCode ProxyAuthenticationRequired = 407;
	public const HttpStatusCode RequestTimeout = 408;
	public const HttpStatusCode Conflict = 409;
	public const HttpStatusCode Gone = 410;
	public const HttpStatusCode LengthRequired = 411;
	public const HttpStatusCode PreconditionFailed = 412;
	public const HttpStatusCode RequestEntityTooLarge = 413;
	public const HttpStatusCode RequestUriTooLong = 414;
	public const HttpStatusCode UnsupportedMediaType = 415;
	public const HttpStatusCode RequestedRangeNotSatisfiable = 416;
	public const HttpStatusCode ExpectationFailed = 417;
	public const HttpStatusCode MisdirectedRequest = 421;
	public const HttpStatusCode UnprocessableEntity = 422;
	public const HttpStatusCode Locked = 423;
	public const HttpStatusCode FailedDependency = 424;
	public const HttpStatusCode UpgradeRequired = 426;
	public const HttpStatusCode PreconditionRequired = 428;
	public const HttpStatusCode TooManyRequests = 429;
	public const HttpStatusCode RequestHeaderFieldsTooLarge = 431;
	public const HttpStatusCode UnavailableForLegalReasons = 451;
	public const HttpStatusCode InternalServerError = 500;
	public const HttpStatusCode NotImplemented = 501;
	public const HttpStatusCode BadGateway = 502;
	public const HttpStatusCode ServiceUnavailable = 503;
	public const HttpStatusCode GatewayTimeout = 504;
	public const HttpStatusCode HttpVersionNotSupported = 505;
	public const HttpStatusCode VariantAlsoNegotiates = 506;
	public const HttpStatusCode InsufficientStorage = 507;
	public const HttpStatusCode LoopDetected = 508;
	public const HttpStatusCode NotExtended = 510;
	public const HttpStatusCode NetworkAuthenticationRequired = 511;
}

// Namespace: System.Net
public class HttpVersion
{
	// Fields
	public static readonly Version Unknown; // 0x0
	public static readonly Version Version10; // 0x8
	public static readonly Version Version11; // 0x10
	public static readonly Version Version20; // 0x18

	// Methods

	// RVA: 0x133DAB8
	private static void .cctor() { }

}

// Namespace: 
private sealed class ReadOnlyIPAddress
{
	// Methods

	// RVA: 0x133F920
	public void .ctor(Int64 newAddress) { }

}

// Namespace: System.Net
[Serializable]
public class IPAddress
{
	// Fields
	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const Int64 LoopbackMask = 255;
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private UInt32 _addressOrScopeId; // 0x10
	private readonly UInt16[] _numbers; // 0x18
	private string _toString; // 0x20
	private int _hashCode; // 0x28
	internal const int NumberOfLabels = 8;

	// Methods

	// RVA: 0x133DBD8
	private bool get_IsIPv4() { }

	// RVA: 0x133DBE8
	private bool get_IsIPv6() { }

	// RVA: 0x133DBF8
	private UInt32 get_PrivateAddress() { }

	// RVA: 0x133DC00
	private void set_PrivateAddress(UInt32 value) { }

	// RVA: 0x133DC38
	private UInt32 get_PrivateScopeId() { }

	// RVA: 0x133DC40
	private void set_PrivateScopeId(UInt32 value) { }

	// RVA: 0x133DC78
	public void .ctor(Int64 newAddress) { }

	// RVA: 0x133DD08
	public void .ctor(Byte[] address, Int64 scopeid) { }

	// RVA: 0x133DE28
	public void .ctor(System.ReadOnlySpan<System.Byte> address, Int64 scopeid) { }

	// RVA: 0x133E05C
	internal void .ctor(UInt16* numbers, int numbersLength, UInt32 scopeid) { }

	// RVA: 0x133E124
	private void .ctor(UInt16[] numbers, UInt32 scopeid) { }

	// RVA: 0x133E180
	public static bool TryParse(string ipString, IPAddress address) { }

	// RVA: 0x133E51C
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x133E5B8
	public bool TryWriteBytes(System.Span<System.Byte> destination, int bytesWritten) { }

	// RVA: 0x133E8E8
	private void WriteIPv6Bytes(System.Span<System.Byte> destination) { }

	// RVA: 0x133EB40
	private void WriteIPv4Bytes(System.Span<System.Byte> destination) { }

	// RVA: 0x133EB90
	public Byte[] GetAddressBytes() { }

	// RVA: 0x133EC98
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x133ECB0
	public Int64 get_ScopeId() { }

	// RVA: 0x133ED0C
	public override string ToString() { }

	// RVA: 0x133EE54
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x133EF6C
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x133F168
	public override bool Equals(object comparand) { }

	// RVA: 0x133F170
	public override int GetHashCode() { }

	// RVA: 0x133F558
	public IPAddress MapToIPv6() { }

	// RVA: 0x133DDD4
	private static Byte[] ThrowAddressNullException() { }

	// RVA: 0x133F664
	private static void .cctor() { }

}

// Namespace: System.Net
internal class IPAddressParser
{
	// Methods

	// RVA: 0x133E224
	internal static IPAddress Parse(System.ReadOnlySpan<System.Char> ipSpan, bool tryParse) { }

	// RVA: 0x133EDE4
	internal static string IPv4AddressToString(UInt32 address) { }

	// RVA: 0x133FE78
	internal static void IPv4AddressToString(UInt32 address, StringBuilder destination) { }

	// RVA: 0x133FBD4
	private static int IPv4AddressToStringHelper(UInt32 address, Char* addressString) { }

	// RVA: 0x133EDCC
	internal static string IPv6AddressToString(UInt16[] address, UInt32 scopeId) { }

	// RVA: 0x133FFC4
	internal static StringBuilder IPv6AddressToStringHelper(UInt16[] address, UInt32 scopeId) { }

	// RVA: 0x133FEF8
	private static void FormatIPv4AddressNumber(int number, Char* addressString, int offset) { }

	// RVA: 0x133FB18
	public static bool Ipv4StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, Int64 address) { }

	// RVA: 0x133F9AC
	public static bool Ipv6StringToAddress(System.ReadOnlySpan<System.Char> ipSpan, UInt16* numbers, int numbersLength, UInt32 scope) { }

	// RVA: 0x1340154
	private static void AppendSections(UInt16[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	// RVA: 0x13404EC
	private static void AppendHex(UInt16 value, StringBuilder buffer) { }

	// RVA: 0x13404B4
	private static UInt32 ExtractIPv4Address(UInt16[] address) { }

	// RVA: 0x1340588
	private static UInt16 Reverse(UInt16 number) { }

}

// Namespace: System.Net
[Serializable]
public class IPEndPoint
{
	// Fields
	private IPAddress _address; // 0x10
	private int _port; // 0x18
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Methods

	// RVA: 0x1340590
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x13405C0
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x13406A0
	public IPAddress get_Address() { }

	// RVA: 0x13406A8
	public int get_Port() { }

	// RVA: 0x13406B0
	public override string ToString() { }

	// RVA: 0x1340778
	public override SocketAddress Serialize() { }

	// RVA: 0x13407EC
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x13409FC
	public override bool Equals(object comparand) { }

	// RVA: 0x1340AD4
	public override int GetHashCode() { }

	// RVA: 0x1340B10
	private static void .cctor() { }

}

// Namespace: 
internal enum PipelineInstruction
{
	// Fields
	public int value__; // 0x10
	public const PipelineInstruction Abort = 0;
	public const PipelineInstruction Advance = 1;
	public const PipelineInstruction Pause = 2;
	public const PipelineInstruction Reread = 3;
	public const PipelineInstruction GiveStream = 4;
}

// Namespace: 
internal enum PipelineEntryFlags
{
	// Fields
	public int value__; // 0x10
	public const PipelineEntryFlags UserCommand = 1;
	public const PipelineEntryFlags GiveDataStream = 2;
	public const PipelineEntryFlags CreateDataConnection = 4;
	public const PipelineEntryFlags DontLogParameter = 8;
}

// Namespace: 
internal class PipelineEntry
{
	// Fields
	internal string Command; // 0x10
	internal PipelineEntryFlags Flags; // 0x18

	// Methods

	// RVA: 0x13430C4
	internal void .ctor(string command) { }

	// RVA: 0x13430F8
	internal void .ctor(string command, PipelineEntryFlags flags) { }

	// RVA: 0x1343140
	internal bool HasFlag(PipelineEntryFlags flags) { }

}

// Namespace: System.Net
internal class CommandStream
{
	// Fields
	private static readonly AsyncCallback s_writeCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_readCallbackDelegate; // 0x8
	private bool _recoverableFailure; // 0x38
	protected WebRequest _request; // 0x40
	protected bool _isAsync; // 0x48
	private bool _aborted; // 0x49
	protected PipelineEntry[] _commands; // 0x50
	protected int _index; // 0x58
	private bool _doRead; // 0x5C
	private bool _doSend; // 0x5D
	private ResponseDescription _currentResponseDescription; // 0x60
	protected string _abortReason; // 0x68
	private string _buffer; // 0x70
	private Encoding _encoding; // 0x78
	private Decoder _decoder; // 0x80

	// Methods

	// RVA: 0x1340BF0
	internal void .ctor(TcpClient client) { }

	// RVA: 0x1340CAC
	internal virtual void Abort(Exception e) { }

	// RVA: 0x1340F14
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1341094
	protected void InvokeRequestCallback(object obj) { }

	// RVA: 0x1341118
	internal bool get_RecoverableFailure() { }

	// RVA: 0x1341120
	protected void MarkAsRecoverableFailure() { }

	// RVA: 0x1341138
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	// RVA: 0x1341864
	protected virtual void ClearState() { }

	// RVA: 0x134190C
	protected virtual PipelineEntry[] BuildCommandsList(WebRequest request) { }

	// RVA: 0x1341914
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	// RVA: 0x1341998
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	// RVA: 0x1341240
	protected void InitCommandPipeline(WebRequest request, PipelineEntry[] commands, bool isAsync) { }

	// RVA: 0x1341A54
	internal void CheckContinuePipeline() { }

	// RVA: 0x13412FC
	protected Stream ContinueCommandPipeline() { }

	// RVA: 0x1341B10
	private bool PostSendCommandProcessing(Stream stream) { }

	// RVA: 0x1341FD4
	private bool PostReadCommandProcessing(Stream stream) { }

	// RVA: 0x1342280
	protected virtual PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream) { }

	// RVA: 0x1342288
	private static void ReadCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1342B8C
	private static void WriteCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1342E7C
	protected Encoding get_Encoding() { }

	// RVA: 0x1342E84
	protected void set_Encoding(Encoding value) { }

	// RVA: 0x1342ED8
	protected virtual bool CheckValid(ResponseDescription response, int validThrough, int completeLength) { }

	// RVA: 0x1341C58
	private ResponseDescription ReceiveCommandResponse() { }

	// RVA: 0x1342590
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	// RVA: 0x1342EE0
	private static void .cctor() { }

}

// Namespace: System.Net
internal class ResponseDescription
{
	// Fields
	internal bool Multiline; // 0x10
	internal int Status; // 0x14
	internal string StatusDescription; // 0x18
	internal StringBuilder StatusBuffer; // 0x20
	internal string StatusCodeString; // 0x28

	// Methods

	// RVA: 0x1343150
	internal bool get_PositiveIntermediate() { }

	// RVA: 0x1343164
	internal bool get_PositiveCompletion() { }

	// RVA: 0x1343178
	internal bool get_TransientFailure() { }

	// RVA: 0x134318C
	internal bool get_PermanentFailure() { }

	// RVA: 0x13431A0
	internal bool get_InvalidStatusCode() { }

	// RVA: 0x13431B4
	public void .ctor() { }

}

// Namespace: System.Net
internal class ReceiveState
{
	// Fields
	internal ResponseDescription Resp; // 0x10
	internal int ValidThrough; // 0x18
	internal Byte[] Buffer; // 0x20
	internal CommandStream Connection; // 0x28

	// Methods

	// RVA: 0x1343234
	internal void .ctor(CommandStream connection) { }

}

// Namespace: System.Net
internal enum FtpLoginState
{
	// Fields
	public Byte value__; // 0x10
	public const FtpLoginState NotLoggedIn = 0;
	public const FtpLoginState LoggedIn = 1;
	public const FtpLoginState LoggedInButNeedsRelogin = 2;
	public const FtpLoginState ReloginFailed = 3;
}

// Namespace: 
private enum GetPathOption
{
	// Fields
	public int value__; // 0x10
	public const GetPathOption Normal = 0;
	public const GetPathOption AssumeFilename = 1;
	public const GetPathOption AssumeNoFilename = 2;
}

// Namespace: 
private sealed class <>c__DisplayClass31_0
{
	// Fields
	public FtpControlStream <>4__this; // 0x10
	public TlsStream tlsStream; // 0x18

	// Methods

	// RVA: 0x1345014
	public void .ctor() { }

	// RVA: 0x1348818
	internal void <PipelineCallback>b__0(IAsyncResult ar) { }

}

// Namespace: System.Net
internal class FtpControlStream
{
	// Fields
	private Socket _dataSocket; // 0x88
	private IPEndPoint _passiveEndPoint; // 0x90
	private TlsStream _tlsStream; // 0x98
	private StringBuilder _bannerMessage; // 0xA0
	private StringBuilder _welcomeMessage; // 0xA8
	private StringBuilder _exitMessage; // 0xB0
	private WeakReference _credentials; // 0xB8
	private string _currentTypeSetting; // 0xC0
	private Int64 _contentLength; // 0xC8
	private DateTime _lastModified; // 0xD0
	private bool _dataHandshakeStarted; // 0xD8
	private string _loginDirectory; // 0xE0
	private string _establishedServerDirectory; // 0xE8
	private string _requestedServerDirectory; // 0xF0
	private Uri _responseUri; // 0xF8
	private FtpLoginState _loginState; // 0x100
	internal FtpStatusCode StatusCode; // 0x104
	internal string StatusLine; // 0x108
	private static readonly AsyncCallback s_acceptCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_connectCallbackDelegate; // 0x8
	private static readonly AsyncCallback s_SSLHandshakeCallback; // 0x10

	// Methods

	// RVA: 0x1343358
	internal NetworkCredential get_Credentials() { }

	// RVA: 0x1343410
	internal void set_Credentials(NetworkCredential value) { }

	// RVA: 0x13434A8
	internal void .ctor(TcpClient client) { }

	// RVA: 0x1343554
	internal void AbortConnect() { }

	// RVA: 0x13435F4
	private static void AcceptCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1343B1C
	private static void ConnectCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1343CF4
	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1343ECC
	private PipelineInstruction QueueOrCreateFtpDataStream(Stream stream) { }

	// RVA: 0x1344660
	protected override void ClearState() { }

	// RVA: 0x1344734
	protected override PipelineInstruction PipelineCallback(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream) { }

	// RVA: 0x13461B8
	protected override PipelineEntry[] BuildCommandsList(WebRequest req) { }

	// RVA: 0x134501C
	private PipelineInstruction QueueOrCreateDataConection(PipelineEntry entry, ResponseDescription response, bool timeout, Stream stream, bool isSocketReady) { }

	// RVA: 0x13474EC
	private static void GetPathInfo(GetPathOption pathOption, Uri uri, string path, string directory, string filename) { }

	// RVA: 0x1348040
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1348160
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x134827C
	internal Int64 get_ContentLength() { }

	// RVA: 0x1348284
	internal DateTime get_LastModified() { }

	// RVA: 0x134828C
	internal Uri get_ResponseUri() { }

	// RVA: 0x1348294
	internal string get_BannerMessage() { }

	// RVA: 0x13482AC
	internal string get_WelcomeMessage() { }

	// RVA: 0x13482C4
	internal string get_ExitMessage() { }

	// RVA: 0x1345C40
	private Int64 GetContentLengthFrom213Response(string responseString) { }

	// RVA: 0x1345D74
	private DateTime GetLastModifiedFrom213Response(string str) { }

	// RVA: 0x13458AC
	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

	// RVA: 0x13457AC
	private void TryUpdateContentLength(string str) { }

	// RVA: 0x1346104
	private string GetLoginDirectory(string str) { }

	// RVA: 0x1347B2C
	private int GetPortV4(string responseString) { }

	// RVA: 0x1347D0C
	private int GetPortV6(string responseString) { }

	// RVA: 0x1347704
	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	// RVA: 0x1347900
	private string GetPortCommandLine(FtpWebRequest request) { }

	// RVA: 0x13473BC
	private string FormatFtpCommand(string command, string parameter) { }

	// RVA: 0x1347EB8
	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	// RVA: 0x13482DC
	protected override bool CheckValid(ResponseDescription response, int validThrough, int completeLength) { }

	// RVA: 0x13442B0
	private TriState IsFtpDataStreamWriteable() { }

	// RVA: 0x13486E4
	private static void .cctor() { }

}

// Namespace: System.Net
internal class FtpDataStream
{
	// Fields
	private FtpWebRequest _request; // 0x28
	private NetworkStream _networkStream; // 0x30
	private bool _writeable; // 0x38
	private bool _readable; // 0x39
	private bool _isFullyRead; // 0x3A
	private bool _closing; // 0x3B

	// Methods

	// RVA: 0x1344348
	internal void .ctor(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	// RVA: 0x134892C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1348AB8
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1348F20
	private void CheckError() { }

	// RVA: 0x1348F6C
	public override bool get_CanRead() { }

	// RVA: 0x1348F74
	public override bool get_CanSeek() { }

	// RVA: 0x1348F98
	public override bool get_CanWrite() { }

	// RVA: 0x1348FA0
	public override Int64 get_Length() { }

	// RVA: 0x1348FC4
	public override Int64 get_Position() { }

	// RVA: 0x1348FE8
	public override void set_Position(Int64 value) { }

	// RVA: 0x1349010
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1349108
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1349238
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x134932C
	private void AsyncReadCallback(IAsyncResult ar) { }

	// RVA: 0x13496A0
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x13499B0
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x1349BA4
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1349C9C
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1349D80
	public override void Flush() { }

	// RVA: 0x1349DA8
	public override bool get_CanTimeout() { }

	// RVA: 0x1349DCC
	public override int get_ReadTimeout() { }

	// RVA: 0x1349DF4
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1349E1C
	public override int get_WriteTimeout() { }

	// RVA: 0x1349E44
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1349E6C
	internal void SetSocketTimeoutOption(int timeout) { }

}

// Namespace: System.Net
internal enum FtpOperation
{
	// Fields
	public int value__; // 0x10
	public const FtpOperation DownloadFile = 0;
	public const FtpOperation ListDirectory = 1;
	public const FtpOperation ListDirectoryDetails = 2;
	public const FtpOperation UploadFile = 3;
	public const FtpOperation UploadFileUnique = 4;
	public const FtpOperation AppendFile = 5;
	public const FtpOperation DeleteFile = 6;
	public const FtpOperation GetDateTimestamp = 7;
	public const FtpOperation GetFileSize = 8;
	public const FtpOperation Rename = 9;
	public const FtpOperation MakeDirectory = 10;
	public const FtpOperation RemoveDirectory = 11;
	public const FtpOperation PrintWorkingDirectory = 12;
	public const FtpOperation Other = 13;
}

// Namespace: System.Net
internal enum FtpMethodFlags
{
	// Fields
	public int value__; // 0x10
	public const FtpMethodFlags None = 0;
	public const FtpMethodFlags IsDownload = 1;
	public const FtpMethodFlags IsUpload = 2;
	public const FtpMethodFlags TakesParameter = 4;
	public const FtpMethodFlags MayTakeParameter = 8;
	public const FtpMethodFlags DoesNotTakeParameter = 16;
	public const FtpMethodFlags ParameterIsDirectory = 32;
	public const FtpMethodFlags ShouldParseForResponseUri = 64;
	public const FtpMethodFlags HasHttpCommand = 128;
	public const FtpMethodFlags MustChangeWorkingDirectoryToPath = 256;
}

// Namespace: System.Net
internal class FtpMethodInfo
{
	// Fields
	internal string Method; // 0x10
	internal FtpOperation Operation; // 0x18
	internal FtpMethodFlags Flags; // 0x1C
	internal string HttpCommand; // 0x20
	private static readonly FtpMethodInfo[] s_knownMethodInfo; // 0x0

	// Methods

	// RVA: 0x1349EC0
	internal void .ctor(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	// RVA: 0x13474DC
	internal bool HasFlag(FtpMethodFlags flags) { }

	// RVA: 0x13476F4
	internal bool get_IsCommandOnly() { }

	// RVA: 0x13486CC
	internal bool get_IsUpload() { }

	// RVA: 0x13486D8
	internal bool get_IsDownload() { }

	// RVA: 0x13458A0
	internal bool get_ShouldParseForResponseUri() { }

	// RVA: 0x1349F24
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	// RVA: 0x134A09C
	private static void .cctor() { }

}

// Namespace: 
private enum RequestStage
{
	// Fields
	public int value__; // 0x10
	public const RequestStage CheckForError = 0;
	public const RequestStage RequestStarted = 1;
	public const RequestStage WriteReady = 2;
	public const RequestStage ReadReady = 3;
	public const RequestStage ReleaseConnection = 4;
}

// Namespace: 
private struct <CreateConnectionAsync>d__86
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	public FtpWebRequest <>4__this; // 0x38
	private TcpClient <client>5__2; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x13510E8
	private void MoveNext() { }

	// RVA: 0x1351508
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Net.FtpWebRequest.<>c <>9; // 0x0
	public static System.Func<System.Security.Cryptography.X509Certificates.X509CertificateCollection> <>9__114_0; // 0x8

	// Methods

	// RVA: 0x1351514
	private static void .cctor() { }

	// RVA: 0x1351580
	public void .ctor() { }

	// RVA: 0x1351588
	internal X509CertificateCollection <get_ClientCertificates>b__114_0() { }

}

// Namespace: System.Net
public sealed class FtpWebRequest
{
	// Fields
	private object _syncObject; // 0x38
	private ICredentials _authInfo; // 0x40
	private readonly Uri _uri; // 0x48
	private FtpMethodInfo _methodInfo; // 0x50
	private string _renameTo; // 0x58
	private bool _getRequestStreamStarted; // 0x60
	private bool _getResponseStarted; // 0x61
	private DateTime _startTime; // 0x68
	private int _timeout; // 0x70
	private int _remainingTimeout; // 0x74
	private Int64 _contentLength; // 0x78
	private Int64 _contentOffset; // 0x80
	private X509CertificateCollection _clientCertificates; // 0x88
	private bool _passive; // 0x90
	private bool _binary; // 0x91
	private bool _async; // 0x92
	private bool _aborted; // 0x93
	private bool _timedOut; // 0x94
	private Exception _exception; // 0x98
	private Queue _timerQueue; // 0xA0
	private Callback _timerCallback; // 0xA8
	private bool _enableSsl; // 0xB0
	private FtpControlStream _connection; // 0xB8
	private Stream _stream; // 0xC0
	private RequestStage _requestStage; // 0xC8
	private bool _onceFailed; // 0xCC
	private WebHeaderCollection _ftpRequestHeaders; // 0xD0
	private FtpWebResponse _ftpWebResponse; // 0xD8
	private int _readWriteTimeout; // 0xE0
	private ContextAwareResult _writeAsyncResult; // 0xE8
	private LazyAsyncResult _readAsyncResult; // 0xF0
	private LazyAsyncResult _requestCompleteAsyncResult; // 0xF8
	private static readonly NetworkCredential s_defaultFtpNetworkCredential; // 0x0
	private static readonly Queue s_DefaultTimerQueue; // 0x8

	// Methods

	// RVA: 0x134A844
	internal FtpMethodInfo get_MethodInfo() { }

	// RVA: 0x134A84C
	public override string get_Method() { }

	// RVA: 0x134A86C
	public override void set_Method(string value) { }

	// RVA: 0x134AA5C
	public string get_RenameTo() { }

	// RVA: 0x134AA64
	public override ICredentials get_Credentials() { }

	// RVA: 0x134AA6C
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x134AC10
	public override Uri get_RequestUri() { }

	// RVA: 0x134AC18
	public override int get_Timeout() { }

	// RVA: 0x134AC20
	internal int get_RemainingTimeout() { }

	// RVA: 0x134AC28
	public int get_ReadWriteTimeout() { }

	// RVA: 0x134AC30
	public Int64 get_ContentOffset() { }

	// RVA: 0x134AC38
	public override Int64 get_ContentLength() { }

	// RVA: 0x134AC40
	public override IWebProxy get_Proxy() { }

	// RVA: 0x134AC48
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x134ACB8
	internal bool get_Aborted() { }

	// RVA: 0x134ACC0
	internal void .ctor(Uri uri) { }

	// RVA: 0x134B2E4
	public override WebResponse GetResponse() { }

	// RVA: 0x134D00C
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x134D7C4
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x134C058
	private void SubmitRequest(bool isAsync) { }

	// RVA: 0x134E5E4
	private Exception TranslateConnectException(Exception e) { }

	// RVA: 0x134DC2C
	private void CreateConnectionAsync() { }

	// RVA: 0x134DCE4
	private FtpControlStream CreateConnection() { }

	// RVA: 0x134DF28
	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	// RVA: 0x134E86C
	private void TimerCallback(Timer timer, int timeNoticed, object context) { }

	// RVA: 0x134E7D4
	private Queue get_TimerQueue() { }

	// RVA: 0x134E370
	private bool AttemptedRecovery(Exception e) { }

	// RVA: 0x134CBBC
	private void SetException(Exception exception) { }

	// RVA: 0x134BB3C
	private void CheckError() { }

	// RVA: 0x134F3E0
	internal void RequestCallback(object obj) { }

	// RVA: 0x134FFB4
	private void SyncRequestCallback(object obj) { }

	// RVA: 0x134F3F0
	private void AsyncRequestCallback(object obj) { }

	// RVA: 0x134BBD4
	private RequestStage FinishRequestStage(RequestStage stage) { }

	// RVA: 0x1350434
	public override void Abort() { }

	// RVA: 0x1350910
	public override void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1350980
	public bool get_UseBinary() { }

	// RVA: 0x1350988
	public bool get_UsePassive() { }

	// RVA: 0x1344534
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1350990
	public bool get_EnableSsl() { }

	// RVA: 0x1350998
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1350AE4
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x134AA3C
	private bool get_InUse() { }

	// RVA: 0x134C600
	private void EnsureFtpWebResponse(Exception exception) { }

	// RVA: 0x1350E14
	internal void DataStreamClosed(CloseExState closeState) { }

	// RVA: 0x1350EAC
	private static void .cctor() { }

}

// Namespace: System.Net
internal class FtpWebRequestCreator
{
	// Methods

	// RVA: 0x13515E0
	internal void .ctor() { }

	// RVA: 0x13515E8
	public WebRequest Create(Uri uri) { }

}

// Namespace: 
internal sealed class EmptyStream
{
	// Methods

	// RVA: 0x13516DC
	internal void .ctor() { }

}

// Namespace: System.Net
public class FtpWebResponse
{
	// Fields
	internal Stream _responseStream; // 0x20
	private Int64 _contentLength; // 0x28
	private Uri _responseUri; // 0x30
	private FtpStatusCode _statusCode; // 0x38
	private string _statusLine; // 0x40
	private WebHeaderCollection _ftpRequestHeaders; // 0x48
	private DateTime _lastModified; // 0x50
	private string _bannerMessage; // 0x58
	private string _welcomeMessage; // 0x60
	private string _exitMessage; // 0x68

	// Methods

	// RVA: 0x1350C64
	internal void .ctor(Stream responseStream, Int64 contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	// RVA: 0x134F3A4
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

	// RVA: 0x1351654
	public override Stream GetResponseStream() { }

	// RVA: 0x1350B98
	internal void SetResponseStream(Stream stream) { }

	// RVA: 0x13517C8
	public override void Close() { }

	// RVA: 0x1351904
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1351A90
	public override Uri get_ResponseUri() { }

	// RVA: 0x1351A98
	public FtpStatusCode get_StatusCode() { }

}

// Namespace: System.Net
internal class NetworkStreamWrapper
{
	// Fields
	private TcpClient _client; // 0x28
	private NetworkStream _networkStream; // 0x30

	// Methods

	// RVA: 0x1351AA0
	internal void .ctor(TcpClient client) { }

	// RVA: 0x13444AC
	protected bool get_UsingSecureStream() { }

	// RVA: 0x1343990
	internal IPAddress get_ServerAddress() { }

	// RVA: 0x1345C20
	internal Socket get_Socket() { }

	// RVA: 0x1351B3C
	internal NetworkStream get_NetworkStream() { }

	// RVA: 0x1351B44
	internal void set_NetworkStream(NetworkStream value) { }

	// RVA: 0x1351B4C
	public override bool get_CanRead() { }

	// RVA: 0x1351B70
	public override bool get_CanSeek() { }

	// RVA: 0x1351B94
	public override bool get_CanWrite() { }

	// RVA: 0x1351BB8
	public override bool get_CanTimeout() { }

	// RVA: 0x1351BDC
	public override int get_ReadTimeout() { }

	// RVA: 0x1351C04
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1351C2C
	public override int get_WriteTimeout() { }

	// RVA: 0x1351C54
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1351C7C
	public override Int64 get_Length() { }

	// RVA: 0x1351CA0
	public override Int64 get_Position() { }

	// RVA: 0x1351CC4
	public override void set_Position(Int64 value) { }

	// RVA: 0x1351CEC
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1351D14
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1351D3C
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1351D64
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1343AD8
	internal void CloseSocket() { }

	// RVA: 0x1351E68
	public void Close(int timeout) { }

	// RVA: 0x1351EA4
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1351ECC
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1351EF4
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1351F1C
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1351F44
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1351F6C
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1351F94
	public override void Flush() { }

	// RVA: 0x1351FBC
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x134DED4
	internal void SetSocketTimeoutOption(int timeout) { }

}

// Namespace: System.Net
public enum SecurityProtocolType
{
	// Fields
	public int value__; // 0x10
	public const SecurityProtocolType SystemDefault = 0;
	public const SecurityProtocolType Ssl3 = 48;
	public const SecurityProtocolType Tls = 192;
	public const SecurityProtocolType Tls11 = 768;
	public const SecurityProtocolType Tls12 = 3072;
	public const SecurityProtocolType Tls13 = 12288;
}

// Namespace: System.Net
public class Authorization
{
	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Methods

	// RVA: 0x1351FE4
	public void .ctor(string token) { }

	// RVA: 0x13520AC
	public void .ctor(string token, bool finished) { }

	// RVA: 0x1352168
	public string get_Message() { }

	// RVA: 0x1352170
	public bool get_Complete() { }

}

// Namespace: System.Net
public class CredentialCache
{
	// Methods

	// RVA: 0x1352178
	public static ICredentials get_DefaultCredentials() { }

	// RVA: 0x13521F4
	public static NetworkCredential get_DefaultNetworkCredentials() { }

}

// Namespace: System.Net
internal class SystemNetworkCredential
{
	// Fields
	internal static readonly SystemNetworkCredential defaultCredential; // 0x0

	// Methods

	// RVA: 0x1352270
	private void .ctor() { }

	// RVA: 0x13522D4
	private static void .cctor() { }

}

// Namespace: System.Net
[Serializable]
public abstract class EndPoint
{
	// Methods

	// RVA: 0x1352384
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x1352438
	public virtual SocketAddress Serialize() { }

	// RVA: 0x13524EC
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x1352518
	protected void .ctor() { }

}

// Namespace: System.Net
public enum FtpStatusCode
{
	// Fields
	public int value__; // 0x10
	public const FtpStatusCode Undefined = 0;
	public const FtpStatusCode RestartMarker = 110;
	public const FtpStatusCode ServiceTemporarilyNotAvailable = 120;
	public const FtpStatusCode DataAlreadyOpen = 125;
	public const FtpStatusCode OpeningData = 150;
	public const FtpStatusCode CommandOK = 200;
	public const FtpStatusCode CommandExtraneous = 202;
	public const FtpStatusCode DirectoryStatus = 212;
	public const FtpStatusCode FileStatus = 213;
	public const FtpStatusCode SystemType = 215;
	public const FtpStatusCode SendUserCommand = 220;
	public const FtpStatusCode ClosingControl = 221;
	public const FtpStatusCode ClosingData = 226;
	public const FtpStatusCode EnteringPassive = 227;
	public const FtpStatusCode LoggedInProceed = 230;
	public const FtpStatusCode ServerWantsSecureSession = 234;
	public const FtpStatusCode FileActionOK = 250;
	public const FtpStatusCode PathnameCreated = 257;
	public const FtpStatusCode SendPasswordCommand = 331;
	public const FtpStatusCode NeedLoginAccount = 332;
	public const FtpStatusCode FileCommandPending = 350;
	public const FtpStatusCode ServiceNotAvailable = 421;
	public const FtpStatusCode CantOpenData = 425;
	public const FtpStatusCode ConnectionClosed = 426;
	public const FtpStatusCode ActionNotTakenFileUnavailableOrBusy = 450;
	public const FtpStatusCode ActionAbortedLocalProcessingError = 451;
	public const FtpStatusCode ActionNotTakenInsufficientSpace = 452;
	public const FtpStatusCode CommandSyntaxError = 500;
	public const FtpStatusCode ArgumentSyntaxError = 501;
	public const FtpStatusCode CommandNotImplemented = 502;
	public const FtpStatusCode BadCommandSequence = 503;
	public const FtpStatusCode NotLoggedIn = 530;
	public const FtpStatusCode AccountNeeded = 532;
	public const FtpStatusCode ActionNotTakenFileUnavailable = 550;
	public const FtpStatusCode ActionAbortedUnknownPageType = 551;
	public const FtpStatusCode FileActionAborted = 552;
	public const FtpStatusCode ActionNotTakenFilenameNotAllowed = 553;
}

// Namespace: System.Net
public enum HttpRequestHeader
{
	// Fields
	public int value__; // 0x10
	public const HttpRequestHeader CacheControl = 0;
	public const HttpRequestHeader Connection = 1;
	public const HttpRequestHeader Date = 2;
	public const HttpRequestHeader KeepAlive = 3;
	public const HttpRequestHeader Pragma = 4;
	public const HttpRequestHeader Trailer = 5;
	public const HttpRequestHeader TransferEncoding = 6;
	public const HttpRequestHeader Upgrade = 7;
	public const HttpRequestHeader Via = 8;
	public const HttpRequestHeader Warning = 9;
	public const HttpRequestHeader Allow = 10;
	public const HttpRequestHeader ContentLength = 11;
	public const HttpRequestHeader ContentType = 12;
	public const HttpRequestHeader ContentEncoding = 13;
	public const HttpRequestHeader ContentLanguage = 14;
	public const HttpRequestHeader ContentLocation = 15;
	public const HttpRequestHeader ContentMd5 = 16;
	public const HttpRequestHeader ContentRange = 17;
	public const HttpRequestHeader Expires = 18;
	public const HttpRequestHeader LastModified = 19;
	public const HttpRequestHeader Accept = 20;
	public const HttpRequestHeader AcceptCharset = 21;
	public const HttpRequestHeader AcceptEncoding = 22;
	public const HttpRequestHeader AcceptLanguage = 23;
	public const HttpRequestHeader Authorization = 24;
	public const HttpRequestHeader Cookie = 25;
	public const HttpRequestHeader Expect = 26;
	public const HttpRequestHeader From = 27;
	public const HttpRequestHeader Host = 28;
	public const HttpRequestHeader IfMatch = 29;
	public const HttpRequestHeader IfModifiedSince = 30;
	public const HttpRequestHeader IfNoneMatch = 31;
	public const HttpRequestHeader IfRange = 32;
	public const HttpRequestHeader IfUnmodifiedSince = 33;
	public const HttpRequestHeader MaxForwards = 34;
	public const HttpRequestHeader ProxyAuthorization = 35;
	public const HttpRequestHeader Referer = 36;
	public const HttpRequestHeader Range = 37;
	public const HttpRequestHeader Te = 38;
	public const HttpRequestHeader Translate = 39;
	public const HttpRequestHeader UserAgent = 40;
}

// Namespace: System.Net
public interface IAuthenticationModule
{
	// Methods

	// RVA: -1
	public abstract Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: -1
	public abstract Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: -1
	public abstract string get_AuthenticationType() { }

}

// Namespace: System.Net
public interface ICertificatePolicy
{
	// Methods

	// RVA: -1
	public abstract bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem) { }

}

// Namespace: System.Net
public interface ICredentials
{
	// Methods

	// RVA: -1
	public abstract NetworkCredential GetCredential(Uri uri, string authType) { }

}

// Namespace: System.Net
public class IPHostEntry
{
	// Fields
	private string hostName; // 0x10
	private string[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	// Methods

	// RVA: 0x1352520
	public string get_HostName() { }

	// RVA: 0x1352528
	public void set_HostName(string value) { }

	// RVA: 0x1352530
	public void set_Aliases(string[] value) { }

	// RVA: 0x1352538
	public IPAddress[] get_AddressList() { }

	// RVA: 0x1352540
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x1352548
	public void .ctor() { }

}

// Namespace: System.Net
public interface IWebRequestCreate
{
	// Methods

	// RVA: -1
	public abstract WebRequest Create(Uri uri) { }

}

// Namespace: System.Net
internal class InternalException
{
	// Methods

	// RVA: 0x13442A8
	internal void .ctor() { }

}

// Namespace: System.Net
internal static class NclUtilities
{
	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Methods

	// RVA: 0x1352558
	internal static bool IsFatal(Exception exception) { }

	// RVA: 0x135264C
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x1352D0C
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x13526DC
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x1352D28
	private static object get_LocalAddressesLock() { }

}

// Namespace: System.Net
internal static class ValidationHelper
{
	// Fields
	public static string[] EmptyArray; // 0x0
	internal static readonly Char[] InvalidMethodChars; // 0x8
	internal static readonly Char[] InvalidParamChars; // 0x10

	// Methods

	// RVA: 0x1352098
	public static string MakeStringNull(string stringValue) { }

	// RVA: 0x1352DE4
	public static bool IsBlankString(string stringValue) { }

	// RVA: 0x1352E00
	public static bool ValidateTcpPort(int port) { }

	// RVA: 0x1352E0C
	private static void .cctor() { }

}

// Namespace: System.Net
internal static class ExceptionHelper
{
	// Methods

	// RVA: 0x1352464
	internal static NotImplementedException get_MethodNotImplementedException() { }

	// RVA: 0x13523B0
	internal static NotImplementedException get_PropertyNotImplementedException() { }

	// RVA: 0x134BB50
	internal static WebException get_TimeoutException() { }

	// RVA: 0x1350B10
	internal static NotSupportedException get_PropertyNotSupportedException() { }

	// RVA: 0x1347F38
	internal static WebException get_RequestAbortedException() { }

}

// Namespace: System.Net
internal class WebRequestPrefixElement
{
	// Fields
	public string Prefix; // 0x10
	internal IWebRequestCreate creator; // 0x18
	internal Type creatorType; // 0x20

	// Methods

	// RVA: 0x1352FEC
	public IWebRequestCreate get_Creator() { }

	// RVA: 0x135321C
	public void set_Creator(IWebRequestCreate value) { }

	// RVA: 0x1353224
	public void .ctor(string P, IWebRequestCreate C) { }

}

// Namespace: System.Net
public sealed class HttpContinueDelegate
{
	// Methods

	// RVA: 0x1353274
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1353318
	public virtual void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }

}

// Namespace: System.Net
internal enum TriState
{
	// Fields
	public int value__; // 0x10
	public const TriState Unspecified = 4294967295;
	public const TriState False = 0;
	public const TriState True = 1;
}

// Namespace: System.Net
public class NetworkCredential
{
	// Fields
	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Methods

	// RVA: 0x134B270
	public void .ctor(string userName, string password) { }

	// RVA: 0x1350FD8
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x13474C0
	public string get_UserName() { }

	// RVA: 0x135332C
	public void set_UserName(string value) { }

	// RVA: 0x13474D0
	public string get_Password() { }

	// RVA: 0x13533B0
	public void set_Password(string value) { }

	// RVA: 0x13474C8
	public string get_Domain() { }

	// RVA: 0x13533E4
	public void set_Domain(string value) { }

	// RVA: 0x1353474
	internal string InternalGetUserName() { }

	// RVA: 0x1353468
	internal string InternalGetPassword() { }

	// RVA: 0x135347C
	internal string InternalGetDomain() { }

	// RVA: 0x1353484
	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

// Namespace: System.Net
[Serializable]
public class ProtocolViolationException
{
	// Methods

	// RVA: 0x1353488
	public void .ctor() { }

	// RVA: 0x1353490
	public void .ctor(string message) { }

	// RVA: 0x1353498
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13534A0
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13534A8
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Namespace: System.Net
public class SocketAddress
{
	// Fields
	internal int m_Size; // 0x10
	internal Byte[] m_Buffer; // 0x18
	private bool m_changed; // 0x20
	private int m_hash; // 0x24

	// Methods

	// RVA: 0x13534B0
	public AddressFamily get_Family() { }

	// RVA: 0x13534E4
	public int get_Size() { }

	// RVA: 0x13534EC
	public Byte get_Item(int offset) { }

	// RVA: 0x135356C
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x13536A4
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x1353908
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x1353968
	internal IPAddress GetIPAddress() { }

	// RVA: 0x1353B4C
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x1353BF0
	public override bool Equals(object comparand) { }

	// RVA: 0x1353CFC
	public override int GetHashCode() { }

	// RVA: 0x1354034
	public override string ToString() { }

}

// Namespace: System.Net
[Serializable]
public class WebException
{
	// Fields
	private WebExceptionStatus m_Status; // 0x8C
	private WebResponse m_Response; // 0x90
	private WebExceptionInternalStatus m_InternalStatus; // 0x98

	// Methods

	// RVA: 0x1354310
	public void .ctor() { }

	// RVA: 0x13476E0
	public void .ctor(string message) { }

	// RVA: 0x134F394
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1343A28
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x1354320
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x134F2D4
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x13544B4
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x13543E8
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x13545A8
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x13546A8
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13546B8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13546C4
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13546CC
	public WebExceptionStatus get_Status() { }

	// RVA: 0x13546D4
	public WebResponse get_Response() { }

}

// Namespace: System.Net
internal enum WebExceptionInternalStatus
{
	// Fields
	public int value__; // 0x10
	public const WebExceptionInternalStatus RequestFatal = 0;
	public const WebExceptionInternalStatus ServicePointFatal = 1;
	public const WebExceptionInternalStatus Recoverable = 2;
	public const WebExceptionInternalStatus Isolated = 3;
}

// Namespace: System.Net
public enum WebExceptionStatus
{
	// Fields
	public int value__; // 0x10
	public const WebExceptionStatus Success = 0;
	public const WebExceptionStatus NameResolutionFailure = 1;
	public const WebExceptionStatus ConnectFailure = 2;
	public const WebExceptionStatus ReceiveFailure = 3;
	public const WebExceptionStatus SendFailure = 4;
	public const WebExceptionStatus PipelineFailure = 5;
	public const WebExceptionStatus RequestCanceled = 6;
	public const WebExceptionStatus ProtocolError = 7;
	public const WebExceptionStatus ConnectionClosed = 8;
	public const WebExceptionStatus TrustFailure = 9;
	public const WebExceptionStatus SecureChannelFailure = 10;
	public const WebExceptionStatus ServerProtocolViolation = 11;
	public const WebExceptionStatus KeepAliveFailure = 12;
	public const WebExceptionStatus Pending = 13;
	public const WebExceptionStatus Timeout = 14;
	public const WebExceptionStatus ProxyNameResolutionFailure = 15;
	public const WebExceptionStatus UnknownError = 16;
	public const WebExceptionStatus MessageLengthLimitExceeded = 17;
	public const WebExceptionStatus CacheEntryNotFound = 18;
	public const WebExceptionStatus RequestProhibitedByCachePolicy = 19;
	public const WebExceptionStatus RequestProhibitedByProxy = 20;
}

// Namespace: System.Net
internal static class WebExceptionMapping
{
	// Fields
	private static readonly string[] s_Mapping; // 0x0

	// Methods

	// RVA: 0x13546DC
	internal static string GetWebStatusString(WebExceptionStatus status) { }

	// RVA: 0x13548A8
	private static void .cctor() { }

}

// Namespace: System.Net
internal enum WebHeaderCollectionType
{
	// Fields
	public UInt16 value__; // 0x10
	public const WebHeaderCollectionType Unknown = 0;
	public const WebHeaderCollectionType WebRequest = 1;
	public const WebHeaderCollectionType WebResponse = 2;
	public const WebHeaderCollectionType HttpWebRequest = 3;
	public const WebHeaderCollectionType HttpWebResponse = 4;
	public const WebHeaderCollectionType HttpListenerRequest = 5;
	public const WebHeaderCollectionType HttpListenerResponse = 6;
	public const WebHeaderCollectionType FtpWebRequest = 7;
	public const WebHeaderCollectionType FtpWebResponse = 8;
	public const WebHeaderCollectionType FileWebRequest = 9;
	public const WebHeaderCollectionType FileWebResponse = 10;
}

// Namespace: 
private enum RfcChar
{
	// Fields
	public Byte value__; // 0x10
	public const RfcChar High = 0;
	public const RfcChar Reg = 1;
	public const RfcChar Ctl = 2;
	public const RfcChar CR = 3;
	public const RfcChar LF = 4;
	public const RfcChar WS = 5;
	public const RfcChar Colon = 6;
	public const RfcChar Delim = 7;
}

// Namespace: System.Net
[Serializable]
public class WebHeaderCollection
{
	// Fields
	private static readonly HeaderInfoTable HInfo; // 0x0
	private string[] m_CommonHeaders; // 0x60
	private int m_NumCommonHeaders; // 0x68
	private static readonly string[] s_CommonHeaderNames; // 0x8
	private static readonly SByte[] s_CommonHeaderHints; // 0x10
	private NameValueCollection m_InnerCollection; // 0x70
	private WebHeaderCollectionType m_Type; // 0x78
	private static readonly Char[] HttpTrimCharacters; // 0x18
	private static RfcChar[] RfcCharMap; // 0x20

	// Methods

	// RVA: 0x1354928
	private void NormalizeCommonHeaders() { }

	// RVA: 0x1354A40
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x1354B0C
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x1354D08
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x1354D50
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x1354E64
	internal void AddInternal(string name, string value) { }

	// RVA: 0x1354EC4
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x1354F24
	internal void RemoveInternal(string name) { }

	// RVA: 0x1354F84
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x1355358
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x13553E0
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x1355558
	public override void Add(string name, string value) { }

	// RVA: 0x1355714
	public void Add(string header) { }

	// RVA: 0x1355A00
	public override void Set(string name, string value) { }

	// RVA: 0x1355C48
	internal void SetInternal(string name, string value) { }

	// RVA: 0x1355E84
	public override void Remove(string name) { }

	// RVA: 0x1355FD4
	public override string[] GetValues(string header) { }

	// RVA: 0x135620C
	public override string ToString() { }

	// RVA: 0x1356274
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x1350A74
	public void .ctor() { }

	// RVA: 0x13565B4
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x13566B0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13568B0
	public override void OnDeserialization(object sender) { }

	// RVA: 0x13568B4
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1356A40
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1356A4C
	public override string Get(string name) { }

	// RVA: 0x1356D84
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1356E00
	public override int get_Count() { }

	// RVA: 0x1356E3C
	public override string Get(int index) { }

	// RVA: 0x1356E80
	public override string GetKey(int index) { }

	// RVA: 0x1356EC4
	private static void .cctor() { }

}

// Namespace: System.Net
internal class CaseInsensitiveAscii
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly Byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x1357484
	public int GetHashCode(object myObject) { }

	// RVA: 0x13575A8
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x1357738
	private int FastGetHashCode(string myString) { }

	// RVA: 0x1357838
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x13579F8
	public void .ctor() { }

	// RVA: 0x1357A00
	private static void .cctor() { }

}

// Namespace: 
internal class DesignerWebRequestCreate
{
	// Methods

	// RVA: 0x135924C
	public WebRequest Create(Uri uri) { }

	// RVA: 0x1359150
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass79_0
{
	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x1358B60
	public void .ctor() { }

	// RVA: 0x13592CC
	internal System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__1() { }

}

// Namespace: System.Net
[Serializable]
public abstract class WebRequest
{
	// Fields
	private static ArrayList s_PrefixList; // 0x0
	private static object s_InternalSyncObject; // 0x8
	private static Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private RequestCachePolicy m_CachePolicy; // 0x20
	private RequestCacheProtocol m_CacheProtocol; // 0x28
	private RequestCacheBinding m_CacheBinding; // 0x30
	private static DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static bool s_DefaultWebProxyInitialized; // 0x28

	// Methods

	// RVA: 0x1357ACC
	private static object get_InternalSyncObject() { }

	// RVA: 0x1357BD0
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x1358040
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x1358134
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x1357E6C
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x1358250
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x134B11C
	protected void .ctor() { }

	// RVA: 0x13584EC
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13584F4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1358500
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1358504
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1358508
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x13585D8
	public virtual string get_Method() { }

	// RVA: 0x1358604
	public virtual void set_Method(string value) { }

	// RVA: 0x1358630
	public virtual Uri get_RequestUri() { }

	// RVA: 0x135865C
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x1358688
	public virtual Int64 get_ContentLength() { }

	// RVA: 0x13586B4
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x13586E0
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x135870C
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x1358738
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x1358764
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x1358790
	public virtual int get_Timeout() { }

	// RVA: 0x13587BC
	public virtual WebResponse GetResponse() { }

	// RVA: 0x13587E8
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1358814
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1358840
	public virtual System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync() { }

	// RVA: 0x1358B68
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x1358BD8
	public virtual void Abort() { }

	// RVA: 0x1358C04
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x1358C0C
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x1358C14
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x1358E30
	private static void .cctor() { }

	// RVA: 0x1359158
	private System.Threading.Tasks.Task<System.Net.WebResponse> <GetResponseAsync>b__79_0() { }

}

// Namespace: System.Net
[Serializable]
public abstract class WebResponse
{
	// Fields
	private bool m_IsFromCache; // 0x18

	// Methods

	// RVA: 0x135164C
	protected void .ctor() { }

	// RVA: 0x13595D4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13595DC
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13595E8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13595EC
	public virtual void Close() { }

	// RVA: 0x13595F0
	public void Dispose() { }

	// RVA: 0x1359680
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1359720
	public virtual bool get_IsFromCache() { }

	// RVA: 0x1359728
	public virtual Stream GetResponseStream() { }

	// RVA: 0x1359754
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x1359780
	public virtual WebHeaderCollection get_Headers() { }

}

// Namespace: System.Net
internal class BufferOffsetSize
{
	// Fields
	internal Byte[] Buffer; // 0x10
	internal int Offset; // 0x18
	internal int Size; // 0x1C

	// Methods

	// RVA: 0x13597AC
	internal void .ctor(Byte[] buffer, int offset, int size, bool copyBuffer) { }

	// RVA: 0x1359868
	internal void .ctor(Byte[] buffer, bool copyBuffer) { }

}

// Namespace: System.Net
internal sealed class HeaderParser
{
	// Methods

	// RVA: 0x1359924
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13599D8
	public virtual string[] Invoke(string value) { }

}

// Namespace: System.Net
internal class HeaderInfo
{
	// Fields
	internal readonly bool IsRequestRestricted; // 0x10
	internal readonly bool IsResponseRestricted; // 0x11
	internal readonly HeaderParser Parser; // 0x18
	internal readonly string HeaderName; // 0x20
	internal readonly bool AllowMultiValues; // 0x28

	// Methods

	// RVA: 0x13599EC
	internal void .ctor(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }

}

// Namespace: System.Net
internal class HeaderInfoTable
{
	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Methods

	// RVA: 0x1359A60
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x1359AE4
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x1359E7C
	private static void .cctor() { }

	// RVA: 0x1354BE0
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x135747C
	public void .ctor() { }

}

// Namespace: System.Net
internal enum CloseExState
{
	// Fields
	public int value__; // 0x10
	public const CloseExState Normal = 0;
	public const CloseExState Abort = 1;
	public const CloseExState Silent = 2;
}

// Namespace: System.Net
internal interface ICloseEx
{
	// Methods

	// RVA: -1
	public abstract void CloseEx(CloseExState closeState) { }

}

// Namespace: 
private class ThreadContext
{
	// Fields
	internal int m_NestedIOCount; // 0x10

	// Methods

	// RVA: 0x135C088
	public void .ctor() { }

}

// Namespace: System.Net
internal class LazyAsyncResult
{
	// Fields
	private static ThreadContext t_ThreadContext; // 0xFFFFFFFF
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_IntCompleted; // 0x30
	private bool m_EndCalled; // 0x34
	private bool m_UserEvent; // 0x35
	private object m_Event; // 0x38

	// Methods

	// RVA: 0x135BFD0
	private static ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x13498F0
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x135C090
	internal object get_AsyncObject() { }

	// RVA: 0x135C098
	public object get_AsyncState() { }

	// RVA: 0x135C0A0
	protected AsyncCallback get_AsyncCallback() { }

	// RVA: 0x135C0A8
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x135C168
	private bool LazilyCreateEvent(ManualResetEvent waitHandle) { }

	// RVA: 0x135C34C
	public bool get_CompletedSynchronously() { }

	// RVA: 0x134965C
	public bool get_IsCompleted() { }

	// RVA: 0x134D7A8
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x135C390
	internal bool get_EndCalled() { }

	// RVA: 0x135C398
	internal void set_EndCalled(bool value) { }

	// RVA: 0x135C3A0
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x1349654
	internal void InvokeCallback(object result) { }

	// RVA: 0x134D7B8
	internal void InvokeCallback() { }

	// RVA: 0x135C5D0
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x135C770
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x135C834
	protected virtual void Cleanup() { }

	// RVA: 0x1349B9C
	internal object InternalWaitForCompletion() { }

	// RVA: 0x135C838
	private object WaitForCompletion(bool snap) { }

}

// Namespace: System.Net
internal class NetRes
{
	// Methods

	// RVA: 0x1352F30
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x135CB40
	public static string GetWebStatusString(WebExceptionStatus Status) { }

	// RVA: 0x135CBA8
	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }

}

// Namespace: 
internal abstract class Queue
{
	// Fields
	private readonly int m_DurationMilliseconds; // 0x10

	// Methods

	// RVA: 0x135DE70
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x135DE9C
	internal int get_Duration() { }

	// RVA: -1
	internal abstract Timer CreateTimer(Callback callback, object context) { }

}

// Namespace: 
internal abstract class Timer
{
	// Fields
	private readonly int m_StartTimeMilliseconds; // 0x10
	private readonly int m_DurationMilliseconds; // 0x14

	// Methods

	// RVA: 0x135DEA4
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x135DEDC
	internal int get_StartTime() { }

	// RVA: 0x135DEE4
	internal int get_Expiration() { }

	// RVA: -1
	internal abstract bool Cancel() { }

	// RVA: -1
	internal abstract bool get_HasExpired() { }

	// RVA: 0x135DEF0
	public void Dispose() { }

}

// Namespace: 
internal sealed class Callback
{
	// Methods

	// RVA: 0x134B14C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x135DEFC
	public virtual void Invoke(Timer timer, int timeNoticed, object context) { }

}

// Namespace: 
private class TimerQueue
{
	// Fields
	private IntPtr m_ThisHandle; // 0x18
	private readonly TimerNode m_Timers; // 0x20

	// Methods

	// RVA: 0x135D07C
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x135DF4C
	internal override Timer CreateTimer(Callback callback, object context) { }

	// RVA: 0x135DAC8
	internal bool Fire(int nextExpiration) { }

}

// Namespace: 
private class InfiniteTimerQueue
{
	// Methods

	// RVA: 0x135D050
	internal void .ctor() { }

	// RVA: 0x135E550
	internal override Timer CreateTimer(Callback callback, object context) { }

}

// Namespace: 
private enum TimerState
{
	// Fields
	public int value__; // 0x10
	public const TimerState Ready = 0;
	public const TimerState Fired = 1;
	public const TimerState Cancelled = 2;
	public const TimerState Sentinel = 3;
}

// Namespace: 
private class TimerNode
{
	// Fields
	private TimerState m_TimerState; // 0x18
	private Callback m_Callback; // 0x20
	private object m_Context; // 0x28
	private object m_QueueLock; // 0x30
	private TimerNode next; // 0x38
	private TimerNode prev; // 0x40

	// Methods

	// RVA: 0x135E1C8
	internal void .ctor(Callback callback, object context, int durationMilliseconds, object queueLock) { }

	// RVA: 0x135DF10
	internal void .ctor() { }

	// RVA: 0x135E5F4
	internal override bool get_HasExpired() { }

	// RVA: 0x135E604
	internal TimerNode get_Next() { }

	// RVA: 0x135E60C
	internal void set_Next(TimerNode value) { }

	// RVA: 0x135E614
	internal TimerNode get_Prev() { }

	// RVA: 0x135E61C
	internal void set_Prev(TimerNode value) { }

	// RVA: 0x135E624
	internal override bool Cancel() { }

	// RVA: 0x135E250
	internal bool Fire() { }

}

// Namespace: 
private class InfiniteTimer
{
	// Fields
	private int cancelled; // 0x18

	// Methods

	// RVA: 0x135E5BC
	internal void .ctor() { }

	// RVA: 0x135E7CC
	internal override bool get_HasExpired() { }

	// RVA: 0x135E7D4
	internal override bool Cancel() { }

}

// Namespace: System.Net
internal static class TimerThread
{
	// Fields
	private static System.Collections.Generic.LinkedList<System.WeakReference> s_Queues; // 0x0
	private static System.Collections.Generic.LinkedList<System.WeakReference> s_NewQueues; // 0x8
	private static int s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static int s_CacheScanIteration; // 0x30
	private static Hashtable s_QueuesCache; // 0x38

	// Methods

	// RVA: 0x135CD84
	private static void .cctor() { }

	// RVA: 0x1358EF4
	internal static Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x134E9C4
	internal static Queue GetOrCreateQueue(int durationMilliseconds) { }

	// RVA: 0x135D140
	private static void Prod() { }

	// RVA: 0x135D270
	private static void ThreadProc() { }

	// RVA: 0x135DCC0
	private static void StopTimerThread() { }

	// RVA: 0x135DC9C
	private static bool IsTickBetween(int start, int end, int comparand) { }

	// RVA: 0x135DD40
	private static void OnDomainUnload(object sender, EventArgs e) { }

}

// Namespace: System.Net
internal enum CookieVariant
{
	// Fields
	public int value__; // 0x10
	public const CookieVariant Unknown = 0;
	public const CookieVariant Plain = 1;
	public const CookieVariant Rfc2109 = 2;
	public const CookieVariant Rfc2965 = 3;
	public const CookieVariant Default = 2;
}

// Namespace: System.Net
[Serializable]
public sealed class Cookie
{
	// Fields
	internal static readonly Char[] PortSplitDelimiters; // 0x0
	internal static readonly Char[] Reserved2Name; // 0x8
	internal static readonly Char[] Reserved2Value; // 0x10
	private static Comparer staticComparer; // 0x18
	private string m_comment; // 0x10
	private Uri m_commentUri; // 0x18
	private CookieVariant m_cookieVariant; // 0x20
	private bool m_discard; // 0x24
	private string m_domain; // 0x28
	private bool m_domain_implicit; // 0x30
	private DateTime m_expires; // 0x38
	private string m_name; // 0x40
	private string m_path; // 0x48
	private bool m_path_implicit; // 0x50
	private string m_port; // 0x58
	private bool m_port_implicit; // 0x60
	private int[] m_port_list; // 0x68
	private bool m_secure; // 0x70
	private bool m_httpOnly; // 0x71
	private DateTime m_timeStamp; // 0x78
	private string m_value; // 0x80
	private int m_version; // 0x88
	private string m_domainKey; // 0x90
	internal bool IsQuotedVersion; // 0x98
	internal bool IsQuotedDomain; // 0x99

	// Methods

	// RVA: 0x135E7FC
	public void .ctor() { }

	// RVA: 0x135E958
	public string get_Comment() { }

	// RVA: 0x135E960
	public void set_Comment(string value) { }

	// RVA: 0x135E9CC
	public void set_CommentUri(Uri value) { }

	// RVA: 0x135E9D4
	public void set_HttpOnly(bool value) { }

	// RVA: 0x135E9DC
	public void set_Discard(bool value) { }

	// RVA: 0x135E9E4
	public string get_Domain() { }

	// RVA: 0x135E9EC
	public void set_Domain(string value) { }

	// RVA: 0x135EA8C
	private string get__Domain() { }

	// RVA: 0x135EB80
	public bool get_Expired() { }

	// RVA: 0x135EC68
	public void set_Expires(DateTime value) { }

	// RVA: 0x135EC70
	public string get_Name() { }

	// RVA: 0x135EC78
	internal bool InternalSetName(string value) { }

	// RVA: 0x135EDA8
	public string get_Path() { }

	// RVA: 0x135EDB0
	public void set_Path(string value) { }

	// RVA: 0x135EE34
	private string get__Path() { }

	// RVA: 0x135EB70
	internal bool get_Plain() { }

	// RVA: 0x135EED4
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x135EF38
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x135F9D4
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x135FA6C
	public void set_Port(string value) { }

	// RVA: 0x135FDF8
	internal int[] get_PortList() { }

	// RVA: 0x135FE00
	private string get__Port() { }

	// RVA: 0x135FEDC
	public bool get_Secure() { }

	// RVA: 0x135FEE4
	public void set_Secure(bool value) { }

	// RVA: 0x135FEEC
	public string get_Value() { }

	// RVA: 0x135FEF4
	public void set_Value(string value) { }

	// RVA: 0x135FF70
	internal CookieVariant get_Variant() { }

	// RVA: 0x135FF78
	internal string get_DomainKey() { }

	// RVA: 0x135FF94
	public int get_Version() { }

	// RVA: 0x135FF9C
	public void set_Version(int value) { }

	// RVA: 0x136001C
	private string get__Version() { }

	// RVA: 0x136012C
	internal static IComparer GetComparer() { }

	// RVA: 0x13601A8
	public override bool Equals(object comparand) { }

	// RVA: 0x1360290
	public override int GetHashCode() { }

	// RVA: 0x1360484
	public override string ToString() { }

	// RVA: 0x13607DC
	private static void .cctor() { }

}

// Namespace: System.Net
internal enum CookieToken
{
	// Fields
	public int value__; // 0x10
	public const CookieToken Nothing = 0;
	public const CookieToken NameValuePair = 1;
	public const CookieToken Attribute = 2;
	public const CookieToken EndToken = 3;
	public const CookieToken EndCookie = 4;
	public const CookieToken End = 5;
	public const CookieToken Equals = 6;
	public const CookieToken Comment = 7;
	public const CookieToken CommentUrl = 8;
	public const CookieToken CookieName = 9;
	public const CookieToken Discard = 10;
	public const CookieToken Domain = 11;
	public const CookieToken Expires = 12;
	public const CookieToken MaxAge = 13;
	public const CookieToken Path = 14;
	public const CookieToken Port = 15;
	public const CookieToken Secure = 16;
	public const CookieToken HttpOnly = 17;
	public const CookieToken Unknown = 18;
	public const CookieToken Version = 19;
}

// Namespace: 
private struct RecognizedAttribute
{
	// Fields
	private string m_name; // 0x10
	private CookieToken m_token; // 0x18

	// Methods

	// RVA: 0x1220804
	internal void .ctor(string name, CookieToken token) { }

	// RVA: 0x1220830
	internal CookieToken get_Token() { }

	// RVA: 0x1220220
	internal bool IsEqualTo(string value) { }

}

// Namespace: System.Net
internal class CookieTokenizer
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Methods

	// RVA: 0x121F810
	internal void .ctor(string tokenStream) { }

	// RVA: 0x121F854
	internal bool get_EndOfCookie() { }

	// RVA: 0x121F85C
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x121F864
	internal bool get_Eof() { }

	// RVA: 0x121F874
	internal string get_Name() { }

	// RVA: 0x121F87C
	internal void set_Name(string value) { }

	// RVA: 0x121F884
	internal bool get_Quoted() { }

	// RVA: 0x121F88C
	internal void set_Quoted(bool value) { }

	// RVA: 0x121F894
	internal CookieToken get_Token() { }

	// RVA: 0x121F89C
	internal void set_Token(CookieToken value) { }

	// RVA: 0x121F8A4
	internal string get_Value() { }

	// RVA: 0x121F8AC
	internal void set_Value(string value) { }

	// RVA: 0x121F8B4
	internal string Extract() { }

	// RVA: 0x121F94C
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x121FC94
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x121FFA8
	internal void Reset() { }

	// RVA: 0x1220034
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1220248
	private static void .cctor() { }

}

// Namespace: System.Net
internal class CookieParser
{
	// Fields
	private CookieTokenizer m_tokenizer; // 0x10

	// Methods

	// RVA: 0x1220838
	internal void .ctor(string cookieString) { }

	// RVA: 0x12208D4
	internal Cookie Get() { }

	// RVA: 0x1220E84
	internal static string CheckQuoted(string value) { }

}

// Namespace: System.Net
internal class Comparer
{
	// Methods

	// RVA: 0x1220F44
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x122102C
	public void .ctor() { }

}

// Namespace: 
internal enum Stamp
{
	// Fields
	public int value__; // 0x10
	public const Stamp Check = 0;
	public const Stamp Set = 1;
	public const Stamp SetToUnused = 2;
	public const Stamp SetToMaxUsed = 3;
}

// Namespace: 
private class CookieCollectionEnumerator
{
	// Fields
	private CookieCollection m_cookies; // 0x10
	private int m_count; // 0x18
	private int m_index; // 0x1C
	private int m_version; // 0x20

	// Methods

	// RVA: 0x1222068
	internal void .ctor(CookieCollection cookies) { }

	// RVA: 0x12220D4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x122217C
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x122221C
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: System.Net
[Serializable]
public class CookieCollection
{
	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	private bool m_IsReadOnly; // 0x29

	// Methods

	// RVA: 0x1221034
	public void .ctor() { }

	// RVA: 0x12210EC
	public Cookie get_Item(int index) { }

	// RVA: 0x12211E0
	public void Add(Cookie cookie) { }

	// RVA: 0x122166C
	public void Add(CookieCollection cookies) { }

	// RVA: 0x1221A04
	public int get_Count() { }

	// RVA: 0x1221A2C
	public bool get_IsSynchronized() { }

	// RVA: 0x1221A34
	public object get_SyncRoot() { }

	// RVA: 0x1221A38
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1221A60
	internal DateTime TimeStamp(Stamp how) { }

	// RVA: 0x1221B68
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x1221B70
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x12212A4
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x1222040
	internal void RemoveAt(int idx) { }

	// RVA: 0x122195C
	public IEnumerator GetEnumerator() { }

}

// Namespace: System.Net
internal struct HeaderVariantInfo
{
	// Fields
	private string m_name; // 0x10
	private CookieVariant m_variant; // 0x18

	// Methods

	// RVA: 0x1222228
	internal void .ctor(string name, CookieVariant variant) { }

	// RVA: 0x1222254
	internal string get_Name() { }

	// RVA: 0x122225C
	internal CookieVariant get_Variant() { }

}

// Namespace: System.Net
[Serializable]
public class CookieContainer
{
	// Fields
	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28

	// Methods

	// RVA: 0x1222264
	public void .ctor() { }

	// RVA: 0x1222390
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x12224D0
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x122337C
	private bool AgeCookies(string domain) { }

	// RVA: 0x1224870
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x1224A44
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x1224ED4
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x12255A8
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x12258F0
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, System.Collections.Generic.List<System.String> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x122620C
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x122643C
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x1226538
	internal string GetCookieHeader(Uri uri, string optCookie2) { }

	// RVA: 0x12268D4
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private class PathListComparer
{
	// Fields
	internal static readonly PathListComparer StaticInstance; // 0x0

	// Methods

	// RVA: 0x1226A08
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x1226BA8
	public void .ctor() { }

	// RVA: 0x1226BB0
	private static void .cctor() { }

}

// Namespace: System.Net
[Serializable]
internal class PathList
{
	// Fields
	private SortedList m_list; // 0x10

	// Methods

	// RVA: 0x1222D34
	public void .ctor() { }

	// RVA: 0x1224A1C
	public int get_Count() { }

	// RVA: 0x1222DEC
	public int GetCookiesCount() { }

	// RVA: 0x1224848
	public ICollection get_Values() { }

	// RVA: 0x1223240
	public object get_Item(string s) { }

	// RVA: 0x1223268
	public void set_Item(string s, object value) { }

	// RVA: 0x12261E4
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1223218
	public object get_SyncRoot() { }

}

// Namespace: System.Net
[Serializable]
public class CookieException
{
	// Methods

	// RVA: 0x1226C1C
	public void .ctor() { }

	// RVA: 0x1222D2C
	internal void .ctor(string message) { }

	// RVA: 0x1224840
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x1226C24
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1226C2C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1226C34
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Namespace: System.Net
[Serializable]
public class FileWebRequest
{
	// Fields
	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private string m_connectionGroupName; // 0x38
	private Int64 m_contentLength; // 0x40
	private ICredentials m_credentials; // 0x48
	private FileAccess m_fileAccess; // 0x50
	private WebHeaderCollection m_headers; // 0x58
	private string m_method; // 0x60
	private IWebProxy m_proxy; // 0x68
	private ManualResetEvent m_readerEvent; // 0x70
	private bool m_readPending; // 0x78
	private WebResponse m_response; // 0x80
	private Stream m_stream; // 0x88
	private bool m_syncHint; // 0x90
	private int m_timeout; // 0x94
	private Uri m_uri; // 0x98
	private bool m_writePending; // 0xA0
	private bool m_writing; // 0xA1
	private LazyAsyncResult m_WriteAResult; // 0xA8
	private LazyAsyncResult m_ReadAResult; // 0xB0
	private int m_Aborted; // 0xB8

	// Methods

	// RVA: 0x1226C3C
	internal void .ctor(Uri uri) { }

	// RVA: 0x1226DCC
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1227200
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x122720C
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12274DC
	internal bool get_Aborted() { }

	// RVA: 0x12274EC
	public override Int64 get_ContentLength() { }

	// RVA: 0x12274F4
	public override ICredentials get_Credentials() { }

	// RVA: 0x12274FC
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1227504
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x122750C
	public override string get_Method() { }

	// RVA: 0x1227514
	public override void set_Method(string value) { }

	// RVA: 0x1227610
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1227618
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1227620
	public override int get_Timeout() { }

	// RVA: 0x1227628
	public override Uri get_RequestUri() { }

	// RVA: 0x1227630
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1227960
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1227C44
	public override WebResponse GetResponse() { }

	// RVA: 0x1227FB4
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x12282E0
	private static void GetResponseCallback(object state) { }

	// RVA: 0x1228990
	internal void UnblockReader() { }

	// RVA: 0x1228A80
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1228AB0
	public override void Abort() { }

	// RVA: 0x1228E2C
	private static void .cctor() { }

}

// Namespace: System.Net
internal class FileWebRequestCreator
{
	// Methods

	// RVA: 0x1228F1C
	internal void .ctor() { }

	// RVA: 0x1228F24
	public WebRequest Create(Uri uri) { }

}

// Namespace: System.Net
internal sealed class FileWebStream
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x1228238
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x1228F88
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x1229048
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1229124
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1229164
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x12292FC
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1229410
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1229524
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x12295CC
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x12296E0
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x1229278
	private void CheckError() { }

}

// Namespace: System.Net
[Serializable]
public class FileWebResponse
{
	// Fields
	private bool m_closed; // 0x19
	private Int64 m_contentLength; // 0x20
	private FileAccess m_fileAccess; // 0x28
	private WebHeaderCollection m_headers; // 0x30
	private Stream m_stream; // 0x38
	private Uri m_uri; // 0x40

	// Methods

	// RVA: 0x122861C
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	// RVA: 0x1229788
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1229A10
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1229A1C
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1229C04
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1229CA8
	public override Uri get_ResponseUri() { }

	// RVA: 0x1229C28
	private void CheckDisposed() { }

	// RVA: 0x1229CCC
	public override void Close() { }

	// RVA: 0x1229D70
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1229EF4
	public override Stream GetResponseStream() { }

}

// Namespace: System.Net
public interface IWebProxy
{
	// Methods

	// RVA: -1
	public abstract Uri GetProxy(Uri destination) { }

	// RVA: -1
	public abstract bool IsBypassed(Uri host) { }

	// RVA: -1
	public abstract ICredentials get_Credentials() { }

}

// Namespace: System.Net
[Serializable]
public class WebProxy
{
	// Fields
	private bool _UseRegistry; // 0x10
	private bool _BypassOnLocal; // 0x11
	private bool m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Methods

	// RVA: 0x1229F50
	public void .ctor() { }

	// RVA: 0x1229FC4
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x122A394
	public ICredentials get_Credentials() { }

	// RVA: 0x122A39C
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x122A424
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x122A4B8
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x122A09C
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x122A82C
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x122A9E0
	private bool IsLocal(Uri host) { }

	// RVA: 0x122AB7C
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x122AC84
	public bool IsBypassed(Uri host) { }

	// RVA: 0x122A73C
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x122AE20
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x122B234
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x122B240
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x122B3D4
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x122B3DC
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x122B440
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x122B228
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x122A6B4
	private bool GetProxyAuto(Uri destination, Uri proxyUri) { }

	// RVA: 0x122ADAC
	private bool IsBypassedAuto(Uri destination, bool isBypassed) { }

	// RVA: 0x122B498
	private static bool AreAllBypassed(System.Collections.Generic.IEnumerable<System.String> proxies, bool checkFirstOnly) { }

	// RVA: 0x122B774
	private static Uri ProxyUri(string proxyName) { }

}

// Namespace: System.Net
internal class AutoWebProxyScriptEngine
{
	// Methods

	// RVA: 0x122B474
	public bool GetProxies(Uri destination, System.Collections.Generic.IList<System.String>& proxyList) { }

	// RVA: 0x122B81C
	public bool GetProxies(Uri destination, System.Collections.Generic.IList<System.String>& proxyList, int syncStatus) { }

}

// Namespace: 
internal static class HTTP_REQUEST_HEADER_ID
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x122BED4
	internal static string ToString(int position) { }

	// RVA: 0x122BF74
	private static void .cctor() { }

}

// Namespace: 
internal static class HttpApi
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x122B840
	private static void .cctor() { }

}

// Namespace: 
internal static class SecureStringHelper
{
	// Methods

	// RVA: 0x122C818
	internal static string CreateString(SecureString secureString) { }

	// RVA: 0x122C99C
	internal static SecureString CreateSecureString(string plainString) { }

}

// Namespace: System.Net
internal static class UnsafeNclNativeMethods
{}

// Namespace: System.Net
internal static class Logging
{
	// Methods

	// RVA: 0x1227958
	internal static bool get_On() { }

}

// Namespace: 
private class CallbackContext
{
	// Fields
	internal readonly object request; // 0x10
	internal readonly X509Certificate certificate; // 0x18
	internal readonly X509Chain chain; // 0x20
	internal readonly SslPolicyErrors sslPolicyErrors; // 0x28
	internal bool result; // 0x2C

	// Methods

	// RVA: 0x122CD2C
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Namespace: System.Net
internal class ServerCertValidationCallback
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Methods

	// RVA: 0x122CA4C
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x122CADC
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	// RVA: 0x122CAE4
	internal void Callback(object state) { }

	// RVA: 0x122CB98
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Namespace: System.Net
public class AuthenticationManager
{
	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x122CDA4
	private static void EnsureModules() { }

	// RVA: 0x122D060
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x122D164
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x122D634
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x122DB50
	private static void .cctor() { }

}

// Namespace: System.Net
internal class BasicClient
{
	// Methods

	// RVA: 0x122DBE4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x122E008
	private static Byte[] GetBytes(string str) { }

	// RVA: 0x122DC94
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x122E0C8
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x122E0D4
	public string get_AuthenticationType() { }

	// RVA: 0x122D058
	public void .ctor() { }

}

// Namespace: System.Net
public sealed class BindIPEndPoint
{
	// Methods

	// RVA: 0x122E118
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x122E23C
	public virtual IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }

}

// Namespace: 
private struct <ProcessReadAsync>d__2
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32> <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public BufferedReadStream <>4__this; // 0x38
	public int size; // 0x40
	public Byte[] buffer; // 0x48
	public int offset; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0x122E498
	private void MoveNext() { }

	// RVA: 0x122E808
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class BufferedReadStream
{
	// Fields
	private readonly BufferOffsetSize readBuffer; // 0x40

	// Methods

	// RVA: 0x122E250
	public void .ctor(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	// RVA: 0x122E284
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x122E3F0
	internal bool TryReadFromBuffer(Byte[] buffer, int offset, int size, int result) { }

}

// Namespace: 
internal enum Mode
{
	// Fields
	public int value__; // 0x10
	public const Mode GZip = 0;
	public const Mode Deflate = 1;
}

// Namespace: System.Net
internal class ContentDecodeStream
{
	// Fields
	private readonly Stream <OriginalInnerStream>k__BackingField; // 0x40

	// Methods

	// RVA: 0x122E888
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode) { }

	// RVA: 0x122E9A8
	private Stream get_OriginalInnerStream() { }

	// RVA: 0x122E974
	private void .ctor(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	// RVA: 0x122E9B0
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x122E9D8
	internal override Task FinishReading(CancellationToken cancellationToken) { }

}

// Namespace: System.Net
public enum DecompressionMethods
{
	// Fields
	public int value__; // 0x10
	public const DecompressionMethods None = 0;
	public const DecompressionMethods GZip = 1;
	public const DecompressionMethods Deflate = 2;
}

// Namespace: System.Net
internal class DefaultCertificatePolicy
{}

// Namespace: System.Net
internal class DigestHeaderParser
{
	// Fields
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	// Methods

	// RVA: 0x122EB08
	public void .ctor(string header) { }

	// RVA: 0x122EBF0
	public string get_Realm() { }

	// RVA: 0x122EC1C
	public string get_Opaque() { }

	// RVA: 0x122EC4C
	public string get_Nonce() { }

	// RVA: 0x122EC7C
	public string get_Algorithm() { }

	// RVA: 0x122ECAC
	public string get_QOP() { }

	// RVA: 0x122ECDC
	public bool Parse() { }

	// RVA: 0x122F188
	private void SkipWhitespace() { }

	// RVA: 0x122F214
	private string GetKey() { }

	// RVA: 0x122EF18
	private bool GetKeywordAndValue(string key, string value) { }

	// RVA: 0x122F308
	private static void .cctor() { }

}

// Namespace: System.Net
internal class DigestSession
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	// Methods

	// RVA: 0x122F48C
	private static void .cctor() { }

	// RVA: 0x122F4EC
	public void .ctor() { }

	// RVA: 0x122F568
	public string get_Algorithm() { }

	// RVA: 0x122F5A0
	public string get_Realm() { }

	// RVA: 0x122F5D4
	public string get_Nonce() { }

	// RVA: 0x122F60C
	public string get_Opaque() { }

	// RVA: 0x122F644
	public string get_QOP() { }

	// RVA: 0x122F67C
	public string get_CNonce() { }

	// RVA: 0x122F794
	public bool Parse(string challenge) { }

	// RVA: 0x122F898
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x122FA04
	private string HA1(string username, string password) { }

	// RVA: 0x122FB40
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x122FC2C
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x122FDAC
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1230408
	public DateTime get_LastUse() { }

}

// Namespace: System.Net
internal class DigestClient
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Methods

	// RVA: 0x1230410
	private static Hashtable get_Cache() { }

	// RVA: 0x12305B4
	private static void CheckExpired(int count) { }

	// RVA: 0x1230DE0
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x12310F0
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x12312A0
	public string get_AuthenticationType() { }

	// RVA: 0x122D050
	public void .ctor() { }

	// RVA: 0x12312E4
	private static void .cctor() { }

}

// Namespace: 
private sealed class GetHostAddressesCallback
{
	// Methods

	// RVA: 0x12315C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12324A8
	public virtual IPAddress[] Invoke(string hostName) { }

	// RVA: 0x123167C
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x12317D8
	public virtual IPAddress[] EndInvoke(IAsyncResult result) { }

}

// Namespace: System.Net
public static class Dns
{
	// Methods

	// RVA: 0x1231378
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	// RVA: 0x12316CC
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x12317E4
	private static bool GetHostByName_icall(string host, string h_name, string[] h_aliases, string[] h_addr_list, int hint) { }

	// RVA: 0x12317E8
	private static bool GetHostByAddr_icall(string addr, string h_name, string[] h_aliases, string[] h_addr_list, int hint) { }

	// RVA: 0x12317EC
	private static bool GetHostName_icall(string h_name) { }

	// RVA: 0x12317F0
	private static void Error_11001(string hostName) { }

	// RVA: 0x1231858
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x1231BEC
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x1231D6C
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x1231F18
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0x12320C8
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	// RVA: 0x1231F8C
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x12322EC
	public static string GetHostName() { }

	// RVA: 0x1232384
	public static System.Threading.Tasks.Task<System.Net.IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { }

}

// Namespace: 
private struct <ProcessReadAsync>d__5
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32> <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public FixedSizeReadStream <>4__this; // 0x38
	public int size; // 0x40
	public Byte[] buffer; // 0x48
	public int offset; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0x123265C
	private void MoveNext() { }

	// RVA: 0x12329D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class FixedSizeReadStream
{
	// Fields
	private readonly Int64 <ContentLength>k__BackingField; // 0x40
	private Int64 position; // 0x48

	// Methods

	// RVA: 0x12324BC
	public Int64 get_ContentLength() { }

	// RVA: 0x12324C4
	public void .ctor(WebOperation operation, Stream innerStream, Int64 contentLength) { }

	// RVA: 0x12324F0
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

}

// Namespace: System.Net
internal class HttpRequestCreator
{
	// Methods

	// RVA: 0x1232A50
	internal void .ctor() { }

	// RVA: 0x1232A58
	public WebRequest Create(Uri uri) { }

}

// Namespace: 
private enum NtlmAuthState
{
	// Fields
	public int value__; // 0x10
	public const NtlmAuthState None = 0;
	public const NtlmAuthState Challenge = 1;
	public const NtlmAuthState Response = 2;
}

// Namespace: 
private struct AuthorizationState
{
	// Fields
	private readonly HttpWebRequest request; // 0x10
	private readonly bool isProxy; // 0x18
	private bool isCompleted; // 0x19
	private NtlmAuthState ntlm_auth_state; // 0x1C

	// Methods

	// RVA: 0x1236BB4
	public bool get_IsCompleted() { }

	// RVA: 0x1236BBC
	public NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x1236BC4
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x1232FAC
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x1235EEC
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x12369D8
	public void Reset() { }

	// RVA: 0x1236BE4
	public override string ToString() { }

}

// Namespace: 
[Serializable]
private sealed class <>c__241<T0>
{
	// Fields
	public static readonly System.Net.HttpWebRequest.<>c__241<T> <>9; // 0x0
	public static System.Func<System.Threading.Tasks.Task<T>,System.Nullable<System.Int32>> <>9__241_0; // 0x0

	// Methods

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal System.Nullable<System.Int32> <RunWithTimeoutWorker>b__241_0(System.Threading.Tasks.Task<T> t) { }

}

// Namespace: 
private struct <RunWithTimeoutWorker>d__241<T0>
{
	// Fields
	public int <>1__state; // 0x0
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	public System.Threading.Tasks.Task<T> workerTask; // 0x0
	public int timeout; // 0x0
	public CancellationTokenSource cts; // 0x0
	public Action abort; // 0x0
	public System.Func<System.Boolean> aborted; // 0x0
	private ConfiguredTaskAwaiter <>u__1; // 0x0

	// Methods

	// RVA: 0x30B2870
	private void MoveNext() { }

	// RVA: 0x30B2CB8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <MyGetResponseAsync>d__243
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.HttpWebResponse> <>t__builder; // 0x18
	public HttpWebRequest <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private WebCompletionSource <completion>5__2; // 0x40
	private WebOperation <operation>5__3; // 0x48
	private WebException <throwMe>5__4; // 0x50
	private HttpWebResponse <response>5__5; // 0x58
	private WebResponseStream <stream>5__6; // 0x60
	private bool <redirect>5__7; // 0x68
	private bool <mustReadAll>5__8; // 0x69
	private WebOperation <ntlm>5__9; // 0x70
	private BufferOffsetSize <writeBuffer>5__10; // 0x78
	private ConfiguredTaskAwaiter <>u__1; // 0x80
	private ConfiguredTaskAwaiter <>u__2; // 0x90
	private System.Runtime.CompilerServices.TaskAwaiter<System.Net.WebResponseStream> <>u__3; // 0xA0
	private ConfiguredTaskAwaiter <>u__4; // 0xA8

	// Methods

	// RVA: 0x1236CF0
	private void MoveNext() { }

	// RVA: 0x1238098
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <GetResponseFromData>d__244
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Net.HttpWebResponse,System.Boolean,System.Boolean,System.Net.BufferOffsetSize,System.Net.WebOperation>> <>t__builder; // 0x18
	public HttpWebRequest <>4__this; // 0x30
	public WebResponseStream stream; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private HttpWebResponse <response>5__2; // 0x48
	private WebException <throwMe>5__3; // 0x50
	private bool <redirect>5__4; // 0x58
	private bool <mustReadAll>5__5; // 0x59
	private ConfiguredTaskAwaiter <>u__1; // 0x60
	private ConfiguredTaskAwaiter <>u__2; // 0x70

	// Methods

	// RVA: 0x1238118
	private void MoveNext() { }

	// RVA: 0x1238D60
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <<GetRewriteHandler>b__271_0>d
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.BufferOffsetSize> <>t__builder; // 0x18
	public HttpWebRequest <>4__this; // 0x30
	private MemoryStream <ms>5__2; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x1238DE0
	private void MoveNext() { }

	// RVA: 0x1239288
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
[Serializable]
public class HttpWebRequest
{
	// Fields
	private Uri requestUri; // 0x38
	private Uri actualUri; // 0x40
	private bool hostChanged; // 0x48
	private bool allowAutoRedirect; // 0x49
	private bool allowBuffering; // 0x4A
	private X509CertificateCollection certificates; // 0x50
	private string connectionGroup; // 0x58
	private bool haveContentLength; // 0x60
	private Int64 contentLength; // 0x68
	private HttpContinueDelegate continueDelegate; // 0x70
	private CookieContainer cookieContainer; // 0x78
	private ICredentials credentials; // 0x80
	private bool haveResponse; // 0x88
	private bool requestSent; // 0x89
	private WebHeaderCollection webHeaders; // 0x90
	private bool keepAlive; // 0x98
	private int maxAutoRedirect; // 0x9C
	private string mediaType; // 0xA0
	private string method; // 0xA8
	private string initialMethod; // 0xB0
	private bool pipelined; // 0xB8
	private bool preAuthenticate; // 0xB9
	private bool usedPreAuth; // 0xBA
	private Version version; // 0xC0
	private bool force_version; // 0xC8
	private Version actualVersion; // 0xD0
	private IWebProxy proxy; // 0xD8
	private bool sendChunked; // 0xE0
	private ServicePoint servicePoint; // 0xE8
	private int timeout; // 0xF0
	private int continueTimeout; // 0xF4
	private WebRequestStream writeStream; // 0xF8
	private HttpWebResponse webResponse; // 0x100
	private WebCompletionSource responseTask; // 0x108
	private WebOperation currentOperation; // 0x110
	private int aborted; // 0x118
	private bool gotRequestStream; // 0x11C
	private int redirects; // 0x120
	private bool expectContinue; // 0x124
	private bool getResponseCalled; // 0x125
	private object locker; // 0x128
	private bool finished_reading; // 0x130
	private DecompressionMethods auto_decomp; // 0x134
	private static int defaultMaxResponseHeadersLength; // 0x0
	private static int defaultMaximumErrorResponseLength; // 0x4
	private static RequestCachePolicy defaultCachePolicy; // 0x8
	private int readWriteTimeout; // 0x138
	private MobileTlsProvider tlsProvider; // 0x140
	private MonoTlsSettings tlsSettings; // 0x148
	private ServerCertValidationCallback certValidationCallback; // 0x150
	private bool hostHasPort; // 0x158
	private Uri hostUri; // 0x160
	private AuthorizationState auth_state; // 0x168
	private AuthorizationState proxy_auth_state; // 0x178
	internal System.Func<System.IO.Stream,System.Threading.Tasks.Task> ResendContentFactory; // 0x188
	private bool <ThrowOnError>k__BackingField; // 0x190
	private bool unsafe_auth_blah; // 0x191

	// Methods

	// RVA: 0x1232D2C
	private static void .cctor() { }

	// RVA: 0x1232ABC
	public void .ctor(Uri uri) { }

	// RVA: 0x1232E40
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1232DC0
	private void ResetAuthorization() { }

	// RVA: 0x1232FE0
	public Uri get_Address() { }

	// RVA: 0x1232FE8
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x1232FF0
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x1232FF8
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x123300C
	private bool get_MethodWithBuffer() { }

	// RVA: 0x1233118
	internal MobileTlsProvider get_TlsProvider() { }

	// RVA: 0x1233120
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x1233128
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x12331B0
	public override Int64 get_ContentLength() { }

	// RVA: 0x12331B8
	internal void set_InternalContentLength(Int64 value) { }

	// RVA: 0x12331C0
	internal bool get_ThrowOnError() { }

	// RVA: 0x12331C8
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x12331D0
	public override ICredentials get_Credentials() { }

	// RVA: 0x12331D8
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x12331E0
	public static int get_DefaultMaximumErrorResponseLength() { }

	// RVA: 0x123325C
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1233264
	public string get_Host() { }

	// RVA: 0x12333BC
	public bool get_KeepAlive() { }

	// RVA: 0x12333C4
	public int get_ReadWriteTimeout() { }

	// RVA: 0x12333CC
	public override string get_Method() { }

	// RVA: 0x12333D4
	public override void set_Method(string value) { }

	// RVA: 0x1233630
	public Version get_ProtocolVersion() { }

	// RVA: 0x1233638
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1233640
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x123388C
	public override Uri get_RequestUri() { }

	// RVA: 0x1233894
	public bool get_SendChunked() { }

	// RVA: 0x123389C
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x12338A0
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x12338A8
	public override int get_Timeout() { }

	// RVA: 0x12338B0
	public string get_TransferEncoding() { }

	// RVA: 0x1233908
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x123399C
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x12339A4
	internal bool get_ExpectContinue() { }

	// RVA: 0x12339AC
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x12339B4
	internal Uri get_AuthUri() { }

	// RVA: 0x12339BC
	internal bool get_ProxyQuery() { }

	// RVA: 0x12339F8
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x1233A00
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x1233730
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x1233A18
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x316B894
	internal static System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func, int timeout, Action abort, System.Func<System.Boolean> aborted, CancellationToken cancellationToken) { }

	// RVA: -1
	private static System.Threading.Tasks.Task<T> RunWithTimeoutWorker(System.Threading.Tasks.Task<T> workerTask, int timeout, Action abort, System.Func<System.Boolean> aborted, CancellationTokenSource cts) { }

	// RVA: 0x30B1D84
	private System.Threading.Tasks.Task<T> RunWithTimeout(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> func) { }

	// RVA: 0x1233C6C
	private System.Threading.Tasks.Task<System.Net.HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1233DB8
	private System.Threading.Tasks.Task<System.ValueTuple<System.Net.HttpWebResponse,System.Boolean,System.Boolean,System.Net.BufferOffsetSize,System.Net.WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1233F14
	internal static Exception FlattenException(Exception e) { }

	// RVA: 0x1233FE4
	private WebException GetWebException(Exception e) { }

	// RVA: 0x1234094
	private static WebException GetWebException(Exception e, bool aborted) { }

	// RVA: 0x123426C
	internal static WebException CreateRequestAbortedException() { }

	// RVA: 0x123432C
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x12344F4
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1234648
	public override WebResponse GetResponse() { }

	// RVA: 0x1234764
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x1234068
	internal bool get_Aborted() { }

	// RVA: 0x123476C
	public override void Abort() { }

	// RVA: 0x1234890
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12348D0
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x12336C8
	private void CheckRequestStarted() { }

	// RVA: 0x1234910
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x123492C
	private void RewriteRedirectToGet() { }

	// RVA: 0x12349BC
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x1234F78
	private string GetHeaders() { }

	// RVA: 0x1235670
	private void DoPreAuthenticate() { }

	// RVA: 0x12358B4
	internal Byte[] GetRequestHeaders() { }

	// RVA: 0x1235C10
	private System.ValueTuple<System.Net.WebOperation,System.Boolean> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x1235ED4
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x123623C
	private System.ValueTuple<System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x1236448
	private System.ValueTuple<System.Boolean,System.Boolean,System.Threading.Tasks.Task<System.Net.BufferOffsetSize>,System.Net.WebException> CheckFinalStatus(HttpWebResponse response) { }

	// RVA: 0x30B171C
	private bool <RunWithTimeout>b__242_0() { }

	// RVA: 0x1236A60
	private System.Threading.Tasks.Task<System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	// RVA: 0x1236B78
	public void .ctor() { }

}

// Namespace: System.Net
[Serializable]
public class HttpWebResponse
{
	// Fields
	private Uri uri; // 0x20
	private WebHeaderCollection webHeaders; // 0x28
	private CookieCollection cookieCollection; // 0x30
	private string method; // 0x38
	private Version version; // 0x40
	private HttpStatusCode statusCode; // 0x48
	private string statusDescription; // 0x50
	private Int64 contentLength; // 0x58
	private string contentType; // 0x60
	private CookieContainer cookie_container; // 0x68
	private bool disposed; // 0x70
	private Stream stream; // 0x78

	// Methods

	// RVA: 0x1239308
	public void .ctor() { }

	// RVA: 0x1239310
	internal void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x12389F8
	internal void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	// RVA: 0x123965C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1239A64
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1239A6C
	public override Uri get_ResponseUri() { }

	// RVA: 0x1239B10
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x1239B18
	public virtual string get_StatusDescription() { }

	// RVA: 0x1239B3C
	public override Stream GetResponseStream() { }

	// RVA: 0x1239BE4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1239BF0
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1239DBC
	public override void Close() { }

	// RVA: 0x1239DF0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1239E00
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1239A90
	private void CheckDisposed() { }

	// RVA: 0x1239408
	private void FillCookies() { }

}

// Namespace: System.Net
public interface ICredentialPolicy
{}

// Namespace: 
private enum State
{
	// Fields
	public int value__; // 0x10
	public const State None = 0;
	public const State PartialSize = 1;
	public const State Body = 2;
	public const State BodyFinished = 3;
	public const State Trailer = 4;
}

// Namespace: 
private class Chunk
{
	// Fields
	public Byte[] Bytes; // 0x10
	public int Offset; // 0x18

	// Methods

	// RVA: 0x123B0B4
	public void .ctor(Byte[] chunk) { }

	// RVA: 0x123B0E8
	public int Read(Byte[] buffer, int offset, int size) { }

}

// Namespace: System.Net
internal class MonoChunkParser
{
	// Fields
	private WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Methods

	// RVA: 0x1239E14
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x1239EF0
	public int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1239EF4
	private int ReadFromChunks(Byte[] buffer, int offset, int size) { }

	// RVA: 0x123A2EC
	public void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x123A318
	private void InternalWrite(Byte[] buffer, int offset, int size) { }

	// RVA: 0x123AEC4
	public bool get_WantMore() { }

	// RVA: 0x123AEE8
	public bool get_DataAvailable() { }

	// RVA: 0x123AFFC
	public int get_ChunkLeft() { }

	// RVA: 0x123A84C
	private State ReadBody(Byte[] buffer, int offset, int size) { }

	// RVA: 0x123A458
	private State GetChunkSize(Byte[] buffer, int offset, int size) { }

	// RVA: 0x123B05C
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x123A994
	private State ReadCRLF(Byte[] buffer, int offset, int size) { }

	// RVA: 0x123AAF8
	private State ReadTrailer(Byte[] buffer, int offset, int size) { }

	// RVA: 0x123B008
	private static void ThrowProtocolViolation(string message) { }

}

// Namespace: 
private struct <ProcessReadAsync>d__7
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32> <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public MonoChunkStream <>4__this; // 0x38
	public Byte[] buffer; // 0x40
	public int offset; // 0x48
	public int size; // 0x4C
	private Byte[] <moreBytes>5__2; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0x123B72C
	private void MoveNext() { }

	// RVA: 0x123BBE0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <FinishReading>d__8
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public MonoChunkStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40
	private Byte[] <buffer>5__2; // 0x50
	private ConfiguredTaskAwaiter <>u__2; // 0x58

	// Methods

	// RVA: 0x123BC60
	private void MoveNext() { }

	// RVA: 0x123C23C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class MonoChunkStream
{
	// Fields
	private readonly WebHeaderCollection <Headers>k__BackingField; // 0x40
	private readonly MonoChunkParser <Decoder>k__BackingField; // 0x48

	// Methods

	// RVA: 0x123B14C
	protected MonoChunkParser get_Decoder() { }

	// RVA: 0x123B154
	public void .ctor(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	// RVA: 0x123B30C
	protected override System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x123B478
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x123B584
	private static void ThrowExpectingChunkTrailer() { }

	// RVA: 0x123B5E4
	private Task <>n__0(CancellationToken cancellationToken) { }

}

// Namespace: System.Net
internal class NtlmClient
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Methods

	// RVA: 0x123C2A8
	public void .ctor() { }

	// RVA: 0x123C320
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x123C400
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x123C408
	public string get_AuthenticationType() { }

}

// Namespace: System.Net
public class ServicePoint
{
	// Fields
	private readonly Uri uri; // 0x10
	private DateTime lastDnsResolve; // 0x18
	private Version protocolVersion; // 0x20
	private IPHostEntry host; // 0x28
	private bool usesProxy; // 0x30
	private bool sendContinue; // 0x31
	private bool useConnect; // 0x32
	private object hostE; // 0x38
	private bool useNagle; // 0x40
	private BindIPEndPoint endPointCallback; // 0x48
	private bool tcp_keepalive; // 0x50
	private int tcp_keepalive_time; // 0x54
	private int tcp_keepalive_interval; // 0x58
	private bool disposed; // 0x5C
	private int connectionLeaseTimeout; // 0x60
	private int receiveBufferSize; // 0x64
	private readonly SPKey <Key>k__BackingField; // 0x68
	private ServicePointScheduler <Scheduler>k__BackingField; // 0x70
	private int connectionLimit; // 0x78
	private int maxIdleTime; // 0x7C
	private object m_ServerCertificateOrBytes; // 0x80
	private object m_ClientCertificateOrBytes; // 0x88

	// Methods

	// RVA: 0x123C44C
	internal void .ctor(SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x123C7D8
	internal SPKey get_Key() { }

	// RVA: 0x123C7E0
	private ServicePointScheduler get_Scheduler() { }

	// RVA: 0x123C7E8
	private void set_Scheduler(ServicePointScheduler value) { }

	// RVA: 0x123C7F0
	public Uri get_Address() { }

	// RVA: 0x123C7F8
	public int get_ConnectionLimit() { }

	// RVA: 0x123C800
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x123C808
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x123C810
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x123C818
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x123C820
	internal bool get_SendContinue() { }

	// RVA: 0x123C8C8
	internal void set_SendContinue(bool value) { }

	// RVA: 0x123C8D0
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x123C980
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x123CAF4
	private static void PutBytes(Byte[] bytes, UInt32 v, int offset) { }

	// RVA: 0x123CB78
	internal bool get_UsesProxy() { }

	// RVA: 0x123CB80
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x123CB88
	internal bool get_UseConnect() { }

	// RVA: 0x123CB90
	internal void set_UseConnect(bool value) { }

	// RVA: 0x123CB98
	private bool get_HasTimedOut() { }

	// RVA: 0x123CD04
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x123D100
	internal void SetVersion(Version version) { }

	// RVA: 0x123D108
	internal void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x123D3D4
	internal void FreeServicePoint() { }

	// RVA: 0x123D3E8
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x123D440
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x123D498
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

}

// Namespace: 
internal class SPKey
{
	// Fields
	private Uri uri; // 0x10
	private Uri proxy; // 0x18
	private bool use_connect; // 0x20

	// Methods

	// RVA: 0x123E1CC
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0x123E2E4
	public bool get_UsesProxy() { }

	// RVA: 0x123E350
	public override int GetHashCode() { }

	// RVA: 0x123E430
	public override bool Equals(object obj) { }

}

// Namespace: System.Net
public class ServicePointManager
{
	// Fields
	private static System.Collections.Concurrent.ConcurrentDictionary<System.Net.ServicePointManager.SPKey,System.Net.ServicePoint> servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static int defaultConnectionLimit; // 0x10
	private static int maxServicePointIdleTime; // 0x14
	private static int maxServicePoints; // 0x18
	private static int dnsRefreshTimeout; // 0x1C
	private static bool _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static bool expectContinue; // 0x28
	private static bool useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static bool tcp_keepalive; // 0x38
	private static int tcp_keepalive_time; // 0x3C
	private static int tcp_keepalive_interval; // 0x40

	// Methods

	// RVA: 0x123D6E4
	private static void .cctor() { }

	// RVA: 0x123D7A8
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x123D824
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x123D8A0
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x123D91C
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x123D998
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x123DA14
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x123DAC0
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0x123E228
	internal static void RemoveServicePoint(ServicePoint sp) { }

}

// Namespace: 
private class ConnectionGroup
{
	// Fields
	private readonly ServicePointScheduler <Scheduler>k__BackingField; // 0x10
	private readonly string <Name>k__BackingField; // 0x18
	private static int nextId; // 0x0
	public readonly int ID; // 0x20
	private System.Collections.Generic.LinkedList<System.Net.WebConnection> connections; // 0x28
	private System.Collections.Generic.LinkedList<System.Net.WebOperation> queue; // 0x30

	// Methods

	// RVA: 0x1240610
	public ServicePointScheduler get_Scheduler() { }

	// RVA: 0x123E738
	public void .ctor(ServicePointScheduler scheduler, string name) { }

	// RVA: 0x123EF68
	public bool IsEmpty() { }

	// RVA: 0x123F9C0
	public void RemoveConnection(WebConnection connection) { }

	// RVA: 0x123FB90
	public void Cleanup() { }

	// RVA: 0x1240448
	public void EnqueueOperation(WebOperation operation) { }

	// RVA: 0x123FED4
	public WebOperation GetNextOperation() { }

	// RVA: 0x12406F4
	public WebConnection FindIdleConnection(WebOperation operation) { }

	// RVA: 0x123FCD0
	public System.ValueTuple<System.Net.WebConnection,System.Boolean> CreateOrReuseConnection(WebOperation operation, bool force) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Net.ServicePointScheduler.AsyncManualResetEvent.<>c <>9; // 0x0
	public static System.Func<System.Object,System.Boolean> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x1241374
	private static void .cctor() { }

	// RVA: 0x12413E0
	public void .ctor() { }

	// RVA: 0x12413E8
	internal bool <Set>b__4_0(object s) { }

}

// Namespace: 
private class AsyncManualResetEvent
{
	// Fields
	private System.Threading.Tasks.TaskCompletionSource<System.Boolean> m_tcs; // 0x10

	// Methods

	// RVA: 0x1241314
	public System.Threading.Tasks.Task<System.Boolean> WaitAsync(int millisecondTimeout) { }

	// RVA: 0x123E97C
	public void Set() { }

	// RVA: 0x123F364
	public void Reset() { }

	// RVA: 0x123E67C
	public void .ctor(bool state) { }

}

// Namespace: 
private struct <RunScheduler>d__32
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public ServicePointScheduler <>4__this; // 0x30
	private System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup,System.Net.WebOperation>[] <operationArray>5__2; // 0x38
	private System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup,System.Net.WebConnection,System.Threading.Tasks.Task>[] <idleArray>5__3; // 0x40
	private System.Collections.Generic.List<System.Threading.Tasks.Task> <taskList>5__4; // 0x48
	private System.Threading.Tasks.Task<System.Boolean> <schedulerTask>5__5; // 0x50
	private bool <finalCleanup>5__6; // 0x58
	private ConfiguredTaskAwaiter <>u__1; // 0x60

	// Methods

	// RVA: 0x124149C
	private void MoveNext() { }

	// RVA: 0x1242214
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <WaitAsync>d__46
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder; // 0x18
	public int millisecondTimeout; // 0x30
	public Task workerTask; // 0x38
	private CancellationTokenSource <cts>5__2; // 0x40
	private Task <timeoutTask>5__3; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0x1242280
	private void MoveNext() { }

	// RVA: 0x1242808
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class ServicePointScheduler
{
	// Fields
	private ServicePoint <ServicePoint>k__BackingField; // 0x10
	private int running; // 0x18
	private int maxIdleTime; // 0x1C
	private AsyncManualResetEvent schedulerEvent; // 0x20
	private ConnectionGroup defaultGroup; // 0x28
	private System.Collections.Generic.Dictionary<System.String,System.Net.ServicePointScheduler.ConnectionGroup> groups; // 0x30
	private System.Collections.Generic.LinkedList<System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup,System.Net.WebOperation>> operations; // 0x38
	private System.Collections.Generic.LinkedList<System.ValueTuple<System.Net.ServicePointScheduler.ConnectionGroup,System.Net.WebConnection,System.Threading.Tasks.Task>> idleConnections; // 0x40
	private int currentConnections; // 0x48
	private int connectionLimit; // 0x4C
	private DateTime idleSince; // 0x50
	private static int nextId; // 0x0
	public readonly int ID; // 0x58

	// Methods

	// RVA: 0x123E664
	private ServicePoint get_ServicePoint() { }

	// RVA: 0x123E66C
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x123E674
	public int get_MaxIdleTime() { }

	// RVA: 0x123C558
	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x123E87C
	public void Run() { }

	// RVA: 0x123EC54
	private Task RunScheduler() { }

	// RVA: 0x123ED40
	private void Cleanup() { }

	// RVA: 0x123EFE8
	private void RunSchedulerIteration() { }

	// RVA: 0x123F524
	private bool OperationCompleted(ConnectionGroup group, WebOperation operation) { }

	// RVA: 0x123FE98
	private void CloseIdleConnection(ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x123F430
	private bool SchedulerIteration(ConnectionGroup group) { }

	// RVA: 0x1240030
	private void RemoveOperation(WebOperation operation) { }

	// RVA: 0x123FA6C
	private void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x1240154
	private void FinalCleanup() { }

	// RVA: 0x123D29C
	public void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x1240228
	private ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x12404AC
	private void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x12404B8
	private void OnConnectionClosed(WebConnection connection) { }

	// RVA: 0x12404E0
	public static System.Threading.Tasks.Task<System.Boolean> WaitAsync(Task workerTask, int millisecondTimeout) { }

	// RVA: 0x124060C
	private Task <Run>b__31_0() { }

}

// Namespace: 
internal enum Status
{
	// Fields
	public int value__; // 0x0
	public const Status Running = 0;
	public const Status Completed = 1;
	public const Status Canceled = 2;
	public const Status Faulted = 3;
}

// Namespace: 
internal class Result
{
	// Fields
	private readonly Status <Status>k__BackingField; // 0x0
	private readonly ExceptionDispatchInfo <Error>k__BackingField; // 0x0
	private readonly T <Argument>k__BackingField; // 0x0

	// Methods

	// RVA: 0x316B894
	public Status get_Status() { }

	// RVA: 0x30B171C
	public bool get_Success() { }

	// RVA: 0x30B1CD4
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0x316B894
	public T get_Argument() { }

	// RVA: 0x316B894
	public void .ctor(T argument) { }

	// RVA: 0x316B894
	public void .ctor(Status state, ExceptionDispatchInfo error) { }

}

// Namespace: 
private struct <WaitForCompletion>d__15
{
	// Fields
	public int <>1__state; // 0x0
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	public System.Net.WebCompletionSource<T> <>4__this; // 0x0
	private ConfiguredTaskAwaiter <>u__1; // 0x0

	// Methods

	// RVA: 0x30B2870
	private void MoveNext() { }

	// RVA: 0x30B2CB8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class WebCompletionSource<T0>
{
	// Fields
	private System.Threading.Tasks.TaskCompletionSource<System.Net.WebCompletionSource.Result<T>> completion; // 0x0
	private Result currentResult; // 0x0

	// Methods

	// RVA: 0x30B28FC
	public void .ctor(bool runAsync) { }

	// RVA: 0x30B1CD4
	internal Result get_CurrentResult() { }

	// RVA: 0x30B1CD4
	internal Task get_Task() { }

	// RVA: 0x316B894
	public bool TrySetCompleted(T argument) { }

	// RVA: 0x30B171C
	public bool TrySetCompleted() { }

	// RVA: 0x30B171C
	public bool TrySetCanceled() { }

	// RVA: 0x30B183C
	public bool TrySetCanceled(OperationCanceledException error) { }

	// RVA: 0x30B183C
	public bool TrySetException(Exception error) { }

	// RVA: 0x30B2870
	public void ThrowOnError() { }

	// RVA: 0x30B1CD4
	public System.Threading.Tasks.Task<T> WaitForCompletion() { }

}

// Namespace: System.Net
internal class WebCompletionSource
{
	// Methods

	// RVA: 0x1242888
	public void .ctor() { }

}

// Namespace: System.Net
internal enum ReadState
{
	// Fields
	public int value__; // 0x10
	public const ReadState None = 0;
	public const ReadState Status = 1;
	public const ReadState Headers = 2;
	public const ReadState Content = 3;
	public const ReadState Aborted = 4;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Net.WebConnection.<>c <>9; // 0x0
	public static System.Func<System.Net.IPEndPoint,System.AsyncCallback,System.Object,System.IAsyncResult> <>9__16_0; // 0x8
	public static System.Action<System.IAsyncResult> <>9__16_1; // 0x10

	// Methods

	// RVA: 0x1243D84
	private static void .cctor() { }

	// RVA: 0x1243DF0
	public void .ctor() { }

	// RVA: 0x1243DF8
	internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state) { }

	// RVA: 0x1243E9C
	internal void <Connect>b__16_1(IAsyncResult asyncResult) { }

}

// Namespace: 
private struct <Connect>d__16
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebConnection <>4__this; // 0x30
	public WebOperation operation; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private Exception <connectException>5__2; // 0x48
	private IPAddress[] <>7__wrap2; // 0x50
	private int <>7__wrap3; // 0x58
	private ConfiguredTaskAwaiter <>u__1; // 0x60

	// Methods

	// RVA: 0x1243FA0
	private void MoveNext() { }

	// RVA: 0x1244DE4
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <CreateStream>d__18
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder; // 0x18
	public WebConnection <>4__this; // 0x30
	public WebOperation operation; // 0x38
	public bool reused; // 0x40
	public CancellationToken cancellationToken; // 0x48
	private NetworkStream <stream>5__2; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58
	private ConfiguredTaskAwaiter <>u__2; // 0x68

	// Methods

	// RVA: 0x1244E50
	private void MoveNext() { }

	// RVA: 0x12458B0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InitConnection>d__19
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Net.WebRequestStream> <>t__builder; // 0x18
	public WebOperation operation; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public WebConnection <>4__this; // 0x40
	private bool <reused>5__2; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x1245930
	private void MoveNext() { }

	// RVA: 0x124626C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class WebConnection
{
	// Fields
	private NetworkCredential ntlm_credentials; // 0x10
	private bool ntlm_authenticated; // 0x18
	private bool unsafe_sharing; // 0x19
	private Stream networkStream; // 0x20
	private Socket socket; // 0x28
	private MonoTlsStream monoTlsStream; // 0x30
	private WebConnectionTunnel tunnel; // 0x38
	private int disposed; // 0x40
	private readonly ServicePoint <ServicePoint>k__BackingField; // 0x48
	private DateTime idleSince; // 0x50
	private WebOperation currentOperation; // 0x58

	// Methods

	// RVA: 0x12428E0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x12412E0
	public void .ctor(ServicePoint sPoint) { }

	// RVA: 0x12428E8
	private bool CanReuse() { }

	// RVA: 0x1242918
	private bool CheckReusable() { }

	// RVA: 0x12429E8
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x1242B10
	private System.Threading.Tasks.Task<System.Boolean> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	// RVA: 0x1242C70
	internal System.Threading.Tasks.Task<System.Net.WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x1242DC8
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x1242F40
	internal static bool ReadLine(Byte[] buffer, int start, int max, string output) { }

	// RVA: 0x1240BE0
	internal bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x124316C
	private bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x12434D4
	private void Reset() { }

	// RVA: 0x12435EC
	private void Close(bool reset) { }

	// RVA: 0x12436C4
	private void CloseSocket() { }

	// RVA: 0x1240660
	public bool get_Closed() { }

	// RVA: 0x12439B8
	public DateTime get_IdleSince() { }

	// RVA: 0x124102C
	public bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x123F7A0
	public bool Continue(WebOperation next) { }

	// RVA: 0x1243D0C
	private void Dispose(bool disposing) { }

	// RVA: 0x1240618
	public void Dispose() { }

	// RVA: 0x12435B8
	private void ResetNtlm() { }

	// RVA: 0x1243D54
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x1243D5C
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x1243D64
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x1243D6C
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x1243D74
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x1243D7C
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }

}

// Namespace: System.Net
internal abstract class WebConnectionStream
{
	// Fields
	protected bool closed; // 0x28
	private bool disposed; // 0x29
	private object locker; // 0x30
	private int read_timeout; // 0x38
	private int write_timeout; // 0x3C
	private readonly HttpWebRequest <Request>k__BackingField; // 0x40
	private readonly WebConnection <Connection>k__BackingField; // 0x48
	private readonly WebOperation <Operation>k__BackingField; // 0x50

	// Methods

	// RVA: 0x12462EC
	protected void .ctor(WebConnection cnc, WebOperation operation) { }

	// RVA: 0x12463E8
	internal HttpWebRequest get_Request() { }

	// RVA: 0x12463F0
	internal WebConnection get_Connection() { }

	// RVA: 0x12463F8
	internal WebOperation get_Operation() { }

	// RVA: 0x1246400
	internal ServicePoint get_ServicePoint() { }

	// RVA: 0x1246420
	public override bool get_CanTimeout() { }

	// RVA: 0x1246428
	public override int get_ReadTimeout() { }

	// RVA: 0x1246430
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x124649C
	public override int get_WriteTimeout() { }

	// RVA: 0x12464A4
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1246510
	protected Exception GetException(Exception e) { }

	// RVA: -1
	protected abstract bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x12466DC
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1246A88
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x1246CE8
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1246E3C
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x1247078
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x1247188
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1247410
	public override void Flush() { }

	// RVA: 0x1247414
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1247564
	internal void InternalClose() { }

	// RVA: -1
	protected abstract void Close_internal(bool disposed) { }

	// RVA: 0x1247570
	public override void Close() { }

	// RVA: 0x1247584
	public override Int64 Seek(Int64 a, SeekOrigin b) { }

	// RVA: 0x12475D8
	public override bool get_CanSeek() { }

	// RVA: 0x12475E0
	public override Int64 get_Length() { }

	// RVA: 0x1247634
	public override Int64 get_Position() { }

	// RVA: 0x1247688
	public override void set_Position(Int64 value) { }

}

// Namespace: 
private enum NtlmAuthState
{
	// Fields
	public int value__; // 0x10
	public const NtlmAuthState None = 0;
	public const NtlmAuthState Challenge = 1;
	public const NtlmAuthState Response = 2;
}

// Namespace: 
private struct <Initialize>d__42
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebConnectionTunnel <>4__this; // 0x30
	public Stream stream; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private bool <have_auth>5__2; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x1247970
	private void MoveNext() { }

	// RVA: 0x1248740
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <ReadHeaders>d__43
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Net.WebHeaderCollection,System.Byte[],System.Int32>> <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public Stream stream; // 0x38
	public WebConnectionTunnel <>4__this; // 0x40
	private Byte[] <retBuffer>5__2; // 0x48
	private int <status>5__3; // 0x50
	private Byte[] <buffer>5__4; // 0x58
	private MemoryStream <ms>5__5; // 0x60
	private ConfiguredTaskAwaiter <>u__1; // 0x68

	// Methods

	// RVA: 0x12487AC
	private void MoveNext() { }

	// RVA: 0x124925C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class WebConnectionTunnel
{
	// Fields
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	private readonly Uri <ConnectUri>k__BackingField; // 0x18
	private HttpWebRequest connectRequest; // 0x20
	private NtlmAuthState ntlmAuthState; // 0x28
	private bool <Success>k__BackingField; // 0x2C
	private bool <CloseConnection>k__BackingField; // 0x2D
	private int <StatusCode>k__BackingField; // 0x30
	private string <StatusDescription>k__BackingField; // 0x38
	private string[] <Challenge>k__BackingField; // 0x40
	private WebHeaderCollection <Headers>k__BackingField; // 0x48
	private Version <ProxyVersion>k__BackingField; // 0x50
	private Byte[] <Data>k__BackingField; // 0x58

	// Methods

	// RVA: 0x12476DC
	public HttpWebRequest get_Request() { }

	// RVA: 0x12476E4
	public Uri get_ConnectUri() { }

	// RVA: 0x1245738
	public void .ctor(HttpWebRequest request, Uri connectUri) { }

	// RVA: 0x12476EC
	public bool get_Success() { }

	// RVA: 0x12476F4
	private void set_Success(bool value) { }

	// RVA: 0x12476FC
	public bool get_CloseConnection() { }

	// RVA: 0x1247704
	private void set_CloseConnection(bool value) { }

	// RVA: 0x124770C
	public int get_StatusCode() { }

	// RVA: 0x1247714
	private void set_StatusCode(int value) { }

	// RVA: 0x124771C
	private void set_StatusDescription(string value) { }

	// RVA: 0x1247724
	public string[] get_Challenge() { }

	// RVA: 0x124772C
	private void set_Challenge(string[] value) { }

	// RVA: 0x1247734
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x124773C
	private void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x1247744
	public Version get_ProxyVersion() { }

	// RVA: 0x124774C
	private void set_ProxyVersion(Version value) { }

	// RVA: 0x1247754
	public Byte[] get_Data() { }

	// RVA: 0x124775C
	private void set_Data(Byte[] value) { }

	// RVA: 0x1245788
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1247764
	private System.Threading.Tasks.Task<System.ValueTuple<System.Net.WebHeaderCollection,System.Byte[],System.Int32>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x12478C0
	private void FlushContents(Stream stream, int contentLength) { }

}

// Namespace: 
private struct <Run>d__58
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	public WebOperation <>4__this; // 0x38
	private WebRequestStream <requestStream>5__2; // 0x40
	private WebResponseStream <stream>5__3; // 0x48
	private ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x124A1C4
	private void MoveNext() { }

	// RVA: 0x124ABCC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class WebOperation
{
	// Fields
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	private WebConnection <Connection>k__BackingField; // 0x18
	private ServicePoint <ServicePoint>k__BackingField; // 0x20
	private readonly BufferOffsetSize <WriteBuffer>k__BackingField; // 0x28
	private readonly bool <IsNtlmChallenge>k__BackingField; // 0x30
	private CancellationTokenSource cts; // 0x38
	private System.Net.WebCompletionSource<System.Net.WebRequestStream> requestTask; // 0x40
	private System.Net.WebCompletionSource<System.Net.WebRequestStream> requestWrittenTask; // 0x48
	private System.Net.WebCompletionSource<System.Net.WebResponseStream> responseTask; // 0x50
	private System.Net.WebCompletionSource<System.ValueTuple<System.Boolean,System.Net.WebOperation>> finishedTask; // 0x58
	private WebRequestStream writeStream; // 0x60
	private WebResponseStream responseStream; // 0x68
	private ExceptionDispatchInfo disposedInfo; // 0x70
	private ExceptionDispatchInfo closedInfo; // 0x78
	private WebOperation priorityRequest; // 0x80
	private int requestSent; // 0x88
	private int finished; // 0x8C

	// Methods

	// RVA: 0x12492DC
	public HttpWebRequest get_Request() { }

	// RVA: 0x12492E4
	public WebConnection get_Connection() { }

	// RVA: 0x12492EC
	private void set_Connection(WebConnection value) { }

	// RVA: 0x12492F4
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x12492FC
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x1249304
	public BufferOffsetSize get_WriteBuffer() { }

	// RVA: 0x124930C
	public bool get_IsNtlmChallenge() { }

	// RVA: 0x1249314
	public void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x1240670
	public bool get_Aborted() { }

	// RVA: 0x12494FC
	public bool get_Closed() { }

	// RVA: 0x1249588
	public void Abort() { }

	// RVA: 0x12497A4
	public void Close() { }

	// RVA: 0x12496D0
	private void SetCanceled() { }

	// RVA: 0x1249C08
	private void SetError(Exception error) { }

	// RVA: 0x12495D8
	private System.ValueTuple<System.Runtime.ExceptionServices.ExceptionDispatchInfo,System.Boolean> SetDisposed(ExceptionDispatchInfo field) { }

	// RVA: 0x1249CB8
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1249DF4
	internal void ThrowIfDisposed() { }

	// RVA: 0x1244CEC
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1246A1C
	internal void ThrowIfClosedOrDisposed() { }

	// RVA: 0x1245FF4
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1249D90
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ExceptionDispatchInfo field) { }

	// RVA: 0x12439C0
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x1249E60
	public void SetPriorityRequest(WebOperation operation) { }

	// RVA: 0x1249FF4
	internal System.Threading.Tasks.Task<System.Net.WebRequestStream> GetRequestStreamInternal() { }

	// RVA: 0x124A048
	public WebRequestStream get_WriteStream() { }

	// RVA: 0x124A0BC
	public System.Threading.Tasks.Task<System.Net.WebResponseStream> GetResponseStream() { }

	// RVA: 0x124A110
	internal System.Net.WebCompletionSource<System.ValueTuple<System.Boolean,System.Net.WebOperation>> get_Finished() { }

	// RVA: 0x1243C54
	internal void Run() { }

	// RVA: 0x124A118
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x124994C
	internal void Finish(bool ok, Exception error) { }

	// RVA: 0x124A19C
	private void <RegisterRequest>b__48_0() { }

}

// Namespace: 
private struct <ReadAsync>d__28
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32> <>t__builder; // 0x18
	public WebReadStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public Byte[] buffer; // 0x40
	public int offset; // 0x48
	public int size; // 0x4C
	private ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x124B7F0
	private void MoveNext() { }

	// RVA: 0x124BE04
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal abstract class WebReadStream
{
	// Fields
	private readonly WebOperation <Operation>k__BackingField; // 0x28
	private readonly Stream <InnerStream>k__BackingField; // 0x30
	private bool disposed; // 0x38

	// Methods

	// RVA: 0x124ABD8
	public WebOperation get_Operation() { }

	// RVA: 0x124ABE0
	protected Stream get_InnerStream() { }

	// RVA: 0x123B278
	public void .ctor(WebOperation operation, Stream innerStream) { }

	// RVA: 0x124ABE8
	public override Int64 get_Length() { }

	// RVA: 0x124AC28
	public override Int64 get_Position() { }

	// RVA: 0x124AC68
	public override void set_Position(Int64 value) { }

	// RVA: 0x124ACA8
	public override bool get_CanSeek() { }

	// RVA: 0x124ACB0
	public override bool get_CanRead() { }

	// RVA: 0x124ACB8
	public override bool get_CanWrite() { }

	// RVA: 0x124ACC0
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x124AD00
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x124AD40
	public override void Flush() { }

	// RVA: 0x124AD80
	protected Exception GetException(Exception e) { }

	// RVA: 0x124AF4C
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x124B270
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x124B4D0
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x124B624
	public sealed override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: -1
	protected abstract System.Threading.Tasks.Task<System.Int32> ProcessReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x123B5E8
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x124B788
	protected override void Dispose(bool disposing) { }

}

// Namespace: 
private struct <FinishWriting>d__31
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x124CEB8
	private void MoveNext() { }

	// RVA: 0x124D29C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <WriteAsyncInner>d__33
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public Byte[] buffer; // 0x38
	public int offset; // 0x40
	public int size; // 0x44
	public CancellationToken cancellationToken; // 0x48
	public WebCompletionSource completion; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58
	private TaskAwaiter <>u__2; // 0x68

	// Methods

	// RVA: 0x124D308
	private void MoveNext() { }

	// RVA: 0x124D8DC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <ProcessWrite>d__34
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public int size; // 0x40
	public Byte[] buffer; // 0x48
	public int offset; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0x124D948
	private void MoveNext() { }

	// RVA: 0x124DF70
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <Initialize>d__36
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40
	private TaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0x124DFDC
	private void MoveNext() { }

	// RVA: 0x124E3AC
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <SetHeadersAsync>d__37
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public bool setInternalLength; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x124E418
	private void MoveNext() { }

	// RVA: 0x124EBD8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <WriteRequestAsync>d__38
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private BufferOffsetSize <buffer>5__2; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48
	private TaskAwaiter <>u__2; // 0x58

	// Methods

	// RVA: 0x124EC44
	private void MoveNext() { }

	// RVA: 0x124F230
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <WriteChunkTrailer_inner>d__39
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x124F29C
	private void MoveNext() { }

	// RVA: 0x124F570
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <WriteChunkTrailer>d__40
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebRequestStream <>4__this; // 0x30
	private CancellationTokenSource <cts>5__2; // 0x38
	private Task <timeoutTask>5__3; // 0x40
	private ConfiguredTaskAwaiter <>u__1; // 0x48
	private ConfiguredTaskAwaiter <>u__2; // 0x58

	// Methods

	// RVA: 0x124F5DC
	private void MoveNext() { }

	// RVA: 0x124FF8C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class WebRequestStream
{
	// Fields
	private static Byte[] crlf; // 0x0
	private MemoryStream writeBuffer; // 0x58
	private bool requestWritten; // 0x60
	private bool allowBuffering; // 0x61
	private bool sendChunked; // 0x62
	private WebCompletionSource pendingWrite; // 0x68
	private Int64 totalWritten; // 0x70
	private Byte[] headers; // 0x78
	private bool headersSent; // 0x80
	private int completeRequestWritten; // 0x84
	private int chunkTrailerWritten; // 0x88
	private readonly Stream <InnerStream>k__BackingField; // 0x90
	private readonly bool <KeepAlive>k__BackingField; // 0x98

	// Methods

	// RVA: 0x12460D0
	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	// RVA: 0x124BE84
	internal Stream get_InnerStream() { }

	// RVA: 0x124BE8C
	public bool get_KeepAlive() { }

	// RVA: 0x124BE94
	public override bool get_CanRead() { }

	// RVA: 0x124BE9C
	public override bool get_CanWrite() { }

	// RVA: 0x124BEA4
	internal bool get_HasWriteBuffer() { }

	// RVA: 0x124BEE0
	internal int get_WriteBufferLength() { }

	// RVA: 0x124BF30
	internal BufferOffsetSize GetWriteBuffer() { }

	// RVA: 0x124C030
	private Task FinishWriting(CancellationToken cancellationToken) { }

	// RVA: 0x124C134
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x124C410
	private Task WriteAsyncInner(Byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	// RVA: 0x124C560
	private Task ProcessWrite(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x124C698
	private void CheckWriteOverflow(Int64 contentLength, Int64 totalWritten, Int64 size) { }

	// RVA: 0x124A928
	internal Task Initialize(CancellationToken cancellationToken) { }

	// RVA: 0x124C740
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	// RVA: 0x124C850
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

	// RVA: 0x124C958
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	// RVA: 0x124CA5C
	private Task WriteChunkTrailer() { }

	// RVA: 0x124C734
	internal void KillBuffer() { }

	// RVA: 0x124CB4C
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x124CC18
	protected override bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x124CC58
	protected override void Close_internal(bool disposed) { }

	// RVA: 0x124CE14
	private static void .cctor() { }

}

// Namespace: 
private struct <ReadAsync>d__40
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32> <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public Byte[] buffer; // 0x38
	public int offset; // 0x40
	public int count; // 0x44
	public WebResponseStream <>4__this; // 0x48
	private WebCompletionSource <completion>5__2; // 0x50
	private int <nbytes>5__3; // 0x58
	private Exception <throwMe>5__4; // 0x60
	private ConfiguredTaskAwaiter <>u__1; // 0x68
	private ConfiguredTaskAwaiter <>u__2; // 0x78

	// Methods

	// RVA: 0x1251B64
	private void MoveNext() { }

	// RVA: 0x1252638
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass41_0
{
	// Fields
	public WebResponseStream <>4__this; // 0x10
	public Byte[] buffer; // 0x18
	public int offset; // 0x20
	public int size; // 0x24

	// Methods

	// RVA: 0x12504A0
	public void .ctor() { }

	// RVA: 0x12526B8
	internal System.Threading.Tasks.Task<System.Int32> <ProcessRead>b__0(CancellationToken ct) { }

	// RVA: 0x12526F8
	internal void <ProcessRead>b__1() { }

	// RVA: 0x1252768
	internal bool <ProcessRead>b__2() { }

}

// Namespace: 
private struct <ReadAllAsyncInner>d__47
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Byte[]> <>t__builder; // 0x18
	public CancellationToken cancellationToken; // 0x30
	public WebResponseStream <>4__this; // 0x38
	private Int64 <maximumSize>5__2; // 0x40
	private MemoryStream <ms>5__3; // 0x48
	private Byte[] <buffer>5__4; // 0x50
	private ConfiguredTaskAwaiter <>u__1; // 0x58

	// Methods

	// RVA: 0x12527F8
	private void MoveNext() { }

	// RVA: 0x1252E4C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <ReadAllAsync>d__48
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebResponseStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	public bool resending; // 0x40
	private WebCompletionSource <completion>5__2; // 0x48
	private CancellationTokenSource <timeoutCts>5__3; // 0x50
	private Task <timeoutTask>5__4; // 0x58
	private ConfiguredTaskAwaiter <>u__1; // 0x60
	private ConfiguredTaskAwaiter <>u__2; // 0x70

	// Methods

	// RVA: 0x1252ECC
	private void MoveNext() { }

	// RVA: 0x1253AC8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <InitReadAsync>d__52
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public WebResponseStream <>4__this; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private BufferOffsetSize <buffer>5__2; // 0x40
	private ReadState <state>5__3; // 0x48
	private int <position>5__4; // 0x4C
	private ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0x1253B34
	private void MoveNext() { }

	// RVA: 0x125449C
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: System.Net
internal class WebResponseStream
{
	// Fields
	private WebReadStream innerStream; // 0x58
	private bool nextReadCalled; // 0x60
	private bool bufferedEntireContent; // 0x61
	private WebCompletionSource pendingRead; // 0x68
	private object locker; // 0x70
	private int nestedRead; // 0x78
	private bool read_eof; // 0x7C
	private readonly WebRequestStream <RequestStream>k__BackingField; // 0x80
	private WebHeaderCollection <Headers>k__BackingField; // 0x88
	private HttpStatusCode <StatusCode>k__BackingField; // 0x90
	private string <StatusDescription>k__BackingField; // 0x98
	private Version <Version>k__BackingField; // 0xA0
	private bool <KeepAlive>k__BackingField; // 0xA8
	private bool <ChunkedRead>k__BackingField; // 0xA9

	// Methods

	// RVA: 0x124FFF8
	public WebRequestStream get_RequestStream() { }

	// RVA: 0x1250000
	public WebHeaderCollection get_Headers() { }

	// RVA: 0x1250008
	private void set_Headers(WebHeaderCollection value) { }

	// RVA: 0x1250010
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x1250018
	private void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x1250020
	public string get_StatusDescription() { }

	// RVA: 0x1250028
	private void set_StatusDescription(string value) { }

	// RVA: 0x1250030
	public Version get_Version() { }

	// RVA: 0x1250038
	private void set_Version(Version value) { }

	// RVA: 0x1250040
	public bool get_KeepAlive() { }

	// RVA: 0x1250048
	private void set_KeepAlive(bool value) { }

	// RVA: 0x124AA30
	public void .ctor(WebRequestStream request) { }

	// RVA: 0x1250050
	public override bool get_CanRead() { }

	// RVA: 0x1250058
	public override bool get_CanWrite() { }

	// RVA: 0x1250060
	private bool get_ChunkedRead() { }

	// RVA: 0x1250068
	private void set_ChunkedRead(bool value) { }

	// RVA: 0x1250070
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x12501DC
	private System.Threading.Tasks.Task<System.Int32> ProcessRead(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x12504A8
	protected override bool TryReadFromBufferedContent(Byte[] buffer, int offset, int count, int result) { }

	// RVA: 0x1250578
	private bool get_ExpectContent() { }

	// RVA: 0x1250610
	private void Initialize(BufferOffsetSize buffer) { }

	// RVA: 0x1250CB8
	private System.Threading.Tasks.Task<System.Byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	// RVA: 0x1250DF8
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x1250F0C
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1250FC4
	protected override void Close_internal(bool disposed) { }

	// RVA: 0x1251074
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	// RVA: 0x124AAC4
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1251320
	private bool GetResponse(BufferOffsetSize buffer, int pos, ReadState state) { }

}

// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties
{
	// Methods

	// RVA: 0x1254508
	public static IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0x12545B8
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: -1
	public abstract string get_DomainName() { }

	// RVA: 0x1254610
	protected void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
[Serializable]
public class NetworkInformationException
{
	// Methods

	// RVA: 0x1254618
	public void .ctor() { }

	// RVA: 0x1254688
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

// Namespace: System.Net.NetworkInformation
public enum NetworkInterfaceComponent
{
	// Fields
	public int value__; // 0x10
	public const NetworkInterfaceComponent IPv4 = 0;
	public const NetworkInterfaceComponent IPv6 = 1;
}

// Namespace: System.Net.NetworkInformation
internal static class IPGlobalPropertiesFactoryPal
{
	// Methods

	// RVA: 0x1254560
	public static IPGlobalProperties Create() { }

}

// Namespace: System.Net.NetworkInformation
internal abstract class CommonUnixIPGlobalProperties
{
	// Methods

	// RVA: 0x1254690
	private static extern int getdomainname(Byte[] name, int len) { }

	// RVA: 0x1254728
	public override string get_DomainName() { }

	// RVA: 0x1254934
	protected void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal class UnixIPGlobalProperties
{
	// Methods

	// RVA: 0x125493C
	public void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal sealed class UnixNoLibCIPGlobalProperties
{
	// Methods

	// RVA: 0x1254944
	public override string get_DomainName() { }

	// RVA: 0x1254990
	public void .ctor() { }

}

// Namespace: System.Net.NetworkInformation
internal class MibIPGlobalProperties
{
	// Fields
	public readonly string StatisticsFile; // 0x10
	public readonly string StatisticsFileIPv6; // 0x18
	public readonly string TcpFile; // 0x20
	public readonly string Tcp6File; // 0x28
	public readonly string UdpFile; // 0x30
	public readonly string Udp6File; // 0x38
	private static readonly Char[] wsChars; // 0x0

	// Methods

	// RVA: 0x1254998
	public void .ctor(string procDir) { }

	// RVA: 0x1254B50
	private static void .cctor() { }

}

// Namespace: System.Net.NetworkInformation
internal static class UnixIPGlobalPropertiesFactoryPal
{
	// Fields
	private static readonly bool <PlatformNeedsLibCWorkaround>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1254BF4
	private static bool get_PlatformNeedsLibCWorkaround() { }

	// RVA: 0x1254C40
	public static IPGlobalProperties Create() { }

}

// Namespace: System.Net.Configuration
internal sealed class DefaultProxySectionInternal
{
	// Fields
	private IWebProxy webProxy; // 0x10
	private static object classSyncObject; // 0x0

	// Methods

	// RVA: 0x1254D7C
	private static IWebProxy GetDefaultProxy_UsingOldMonoCode() { }

	// RVA: 0x1254D84
	private static IWebProxy GetSystemWebProxy() { }

	// RVA: 0x1254D8C
	internal static object get_ClassSyncObject() { }

	// RVA: 0x1254E44
	internal static DefaultProxySectionInternal GetSection() { }

	// RVA: 0x1255018
	internal IWebProxy get_WebProxy() { }

	// RVA: 0x1255010
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
internal sealed class SettingsSectionInternal
{
	// Fields
	private static readonly SettingsSectionInternal instance; // 0x0
	internal readonly bool HttpListenerUnescapeRequestUrl; // 0x10
	internal readonly IPProtectionLevel IPProtectionLevel; // 0x14

	// Methods

	// RVA: 0x1255020
	internal static SettingsSectionInternal get_Section() { }

	// RVA: 0x125509C
	internal bool get_Ipv6Enabled() { }

	// RVA: 0x12550A4
	public void .ctor() { }

	// RVA: 0x12550BC
	private static void .cctor() { }

}

// Namespace: System.Net.Cache
internal abstract class RequestCache
{
	// Fields
	internal static readonly Char[] LineSplits; // 0x0

	// Methods

	// RVA: 0x1255138
	private static void .cctor() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheValidator
{
	// Methods

	// RVA: 0x12551DC
	public object CreateValidator() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheBinding
{
	// Fields
	private RequestCache m_RequestCache; // 0x10
	private RequestCacheValidator m_CacheValidator; // 0x18

	// Methods

	// RVA: 0x125521C
	internal RequestCache get_Cache() { }

	// RVA: 0x1255224
	internal RequestCacheValidator get_Validator() { }

}

// Namespace: System.Net.Cache
public enum RequestCacheLevel
{
	// Fields
	public int value__; // 0x10
	public const RequestCacheLevel Default = 0;
	public const RequestCacheLevel BypassCache = 1;
	public const RequestCacheLevel CacheOnly = 2;
	public const RequestCacheLevel CacheIfAvailable = 3;
	public const RequestCacheLevel Revalidate = 4;
	public const RequestCacheLevel Reload = 5;
	public const RequestCacheLevel NoCacheNoStore = 6;
}

// Namespace: System.Net.Cache
public class RequestCachePolicy
{
	// Fields
	private RequestCacheLevel m_Level; // 0x10

	// Methods

	// RVA: 0x125522C
	public void .ctor(RequestCacheLevel level) { }

	// RVA: 0x12552A8
	public RequestCacheLevel get_Level() { }

	// RVA: 0x12552B0
	public override string ToString() { }

}

// Namespace: System.Net.Cache
internal class RequestCacheProtocol
{
	// Methods

	// RVA: 0x1255348
	public void .ctor(object arg1, object arg2) { }

}

// Namespace: System.Net.Sockets
public class NetworkStream
{
	// Fields
	private readonly Socket _streamSocket; // 0x28
	private readonly bool _ownsSocket; // 0x30
	private bool _readable; // 0x31
	private bool _writeable; // 0x32
	private int _closeTimeout; // 0x34
	private bool _cleanedUp; // 0x38
	private int _currentReadTimeout; // 0x3C
	private int _currentWriteTimeout; // 0x40

	// Methods

	// RVA: 0x1255390
	public void .ctor(Socket socket) { }

	// RVA: 0x1255580
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x125539C
	public void .ctor(Socket socket, FileAccess access, bool ownsSocket) { }

	// RVA: 0x125558C
	public override bool get_CanRead() { }

	// RVA: 0x1255594
	public override bool get_CanSeek() { }

	// RVA: 0x125559C
	public override bool get_CanWrite() { }

	// RVA: 0x12555A4
	public override bool get_CanTimeout() { }

	// RVA: 0x12555AC
	public override int get_ReadTimeout() { }

	// RVA: 0x1255808
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1255A78
	public override int get_WriteTimeout() { }

	// RVA: 0x1255B04
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1255B8C
	public override Int64 get_Length() { }

	// RVA: 0x1255BE0
	public override Int64 get_Position() { }

	// RVA: 0x1255C34
	public override void set_Position(Int64 value) { }

	// RVA: 0x1255C88
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x1255CDC
	public override int Read(Byte[] buffer, int offset, int size) { }

	// RVA: 0x12560C4
	public override int Read(System.Span<System.Byte> destination) { }

	// RVA: 0x1256444
	public override int ReadByte() { }

	// RVA: 0x125658C
	public override void Write(Byte[] buffer, int offset, int size) { }

	// RVA: 0x1256974
	public override void Write(System.ReadOnlySpan<System.Byte> source) { }

	// RVA: 0x1256CBC
	public override void WriteByte(Byte value) { }

	// RVA: 0x1256DF4
	public void Close(int timeout) { }

	// RVA: 0x1256E64
	protected override void Dispose(bool disposing) { }

	// RVA: 0x12570D8
	protected override void Finalize() { }

	// RVA: 0x1257178
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1257590
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1257878
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1257C90
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1257F78
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1258724
	public override System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1258980
	public override Task WriteAsync(Byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x12591A0
	public override ValueTask WriteAsync(System.ReadOnlyMemory<System.Byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x12593F8
	public override void Flush() { }

	// RVA: 0x12593FC
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1255890
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	// RVA: 0x125961C
	internal Socket get_InternalSocket() { }

}

// Namespace: 
private sealed class CachedEventArgs
{
	// Fields
	public System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> TaskAccept; // 0x10
	public Int32TaskSocketAsyncEventArgs TaskReceive; // 0x18
	public Int32TaskSocketAsyncEventArgs TaskSend; // 0x20
	public AwaitableSocketAsyncEventArgs ValueTaskReceive; // 0x28
	public AwaitableSocketAsyncEventArgs ValueTaskSend; // 0x30

	// Methods

	// RVA: 0x1263924
	public void .ctor() { }

}

// Namespace: 
private class TaskSocketAsyncEventArgs<T0>
{
	// Fields
	internal System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _builder; // 0x0
	internal bool _accessed; // 0x0

	// Methods

	// RVA: 0x30B2870
	internal void .ctor() { }

	// RVA: 0x316B894
	internal System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(bool responsibleForReturningToPool) { }

}

// Namespace: 
private sealed class Int32TaskSocketAsyncEventArgs
{
	// Fields
	internal bool _wrapExceptionsInIOExceptions; // 0x99

	// Methods

	// RVA: 0x12638D0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs.<>c <>9; // 0x0
	public static ContextCallback <>9__14_0; // 0x8
	public static SendOrPostCallback <>9__20_0; // 0x10

	// Methods

	// RVA: 0x1264A5C
	private static void .cctor() { }

	// RVA: 0x1264AC8
	public void .ctor() { }

	// RVA: 0x1264AD0
	internal void <OnCompleted>b__14_0(object runState) { }

	// RVA: 0x1264C58
	internal void <InvokeContinuation>b__20_0(object s) { }

	// RVA: 0x1264D90
	internal void <.cctor>b__27_0(object state) { }

	// RVA: 0x1264DE4
	internal void <.cctor>b__27_1(object state) { }

}

// Namespace: 
internal sealed class AwaitableSocketAsyncEventArgs
{
	// Fields
	internal static readonly AwaitableSocketAsyncEventArgs Reserved; // 0x0
	private static readonly System.Action<System.Object> s_completedSentinel; // 0x8
	private static readonly System.Action<System.Object> s_availableSentinel; // 0x10
	private System.Action<System.Object> _continuation; // 0x80
	private ExecutionContext _executionContext; // 0x88
	private object _scheduler; // 0x90
	private Int16 _token; // 0x98
	private bool <WrapExceptionsInIOExceptions>k__BackingField; // 0x9A

	// Methods

	// RVA: 0x126392C
	public void .ctor() { }

	// RVA: 0x1263A5C
	public bool get_WrapExceptionsInIOExceptions() { }

	// RVA: 0x1263A64
	public void set_WrapExceptionsInIOExceptions(bool value) { }

	// RVA: 0x12596C0
	public bool Reserve() { }

	// RVA: 0x1263A6C
	private void Release() { }

	// RVA: 0x1263AF0
	protected override void OnCompleted(SocketAsyncEventArgs _) { }

	// RVA: 0x1259850
	public System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(Socket socket) { }

	// RVA: 0x1259DF4
	public ValueTask SendAsyncForNetworkStream(Socket socket) { }

	// RVA: 0x126414C
	public ValueTaskSourceStatus GetStatus(Int16 token) { }

	// RVA: 0x12642A0
	public void OnCompleted(System.Action<System.Object> continuation, object state, Int16 token, ValueTaskSourceOnCompletedFlags flags) { }

	// RVA: 0x1263D30
	private void InvokeContinuation(System.Action<System.Object> continuation, object state, bool forceAsync) { }

	// RVA: 0x126461C
	public int GetResult(Int16 token) { }

	// RVA: 0x1264764
	private void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(Int16 token) { }

	// RVA: 0x126424C
	private void ThrowIncorrectTokenException() { }

	// RVA: 0x12645C8
	private void ThrowMultipleContinuationsException() { }

	// RVA: 0x1264738
	private void ThrowException(SocketError error) { }

	// RVA: 0x1264064
	private Exception CreateException(SocketError error) { }

	// RVA: 0x1264870
	private static void .cctor() { }

}

// Namespace: 
private struct WSABUF
{
	// Fields
	public int len; // 0x10
	public IntPtr buf; // 0x18
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Net.Sockets.Socket.<>c <>9; // 0x0
	public static System.Func<System.Net.Sockets.Socket.CachedEventArgs> <>9__14_0; // 0x8
	public static System.Func<System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs> <>9__14_1; // 0x10
	public static AsyncCallback <>9__15_0; // 0x18
	public static AsyncCallback <>9__15_1; // 0x20
	public static System.Func<System.Net.Sockets.Socket.CachedEventArgs> <>9__22_0; // 0x28
	public static System.Func<System.Net.Sockets.Socket.AwaitableSocketAsyncEventArgs> <>9__22_1; // 0x30
	public static AsyncCallback <>9__23_0; // 0x38
	public static AsyncCallback <>9__23_1; // 0x40
	public static IOAsyncCallback <>9__295_0; // 0x48
	public static IOAsyncCallback <>9__297_0; // 0x50

	// Methods

	// RVA: 0x1264E38
	private static void .cctor() { }

	// RVA: 0x1264EA4
	public void .ctor() { }

	// RVA: 0x1264EAC
	internal CachedEventArgs <ReceiveAsync>b__14_0() { }

	// RVA: 0x1264F04
	internal AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1() { }

	// RVA: 0x1264FD8
	internal void <ReceiveAsyncApm>b__15_0(IAsyncResult iar) { }

	// RVA: 0x12652A0
	internal void <ReceiveAsyncApm>b__15_1(IAsyncResult iar) { }

	// RVA: 0x1265888
	internal CachedEventArgs <SendAsyncForNetworkStream>b__22_0() { }

	// RVA: 0x12658E0
	internal AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1() { }

	// RVA: 0x12659B4
	internal void <SendAsyncApm>b__23_0(IAsyncResult iar) { }

	// RVA: 0x1265C7C
	internal void <SendAsyncApm>b__23_1(IAsyncResult iar) { }

	// RVA: 0x12660B8
	internal void <SendAsync>b__295_0(IOAsyncResult s) { }

	// RVA: 0x1266160
	internal void <BeginSend>b__297_0(IOAsyncResult s) { }

	// RVA: 0x1266208
	internal void <.cctor>b__367_0(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x126630C
	internal void <.cctor>b__367_1(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x12663F8
	internal void <.cctor>b__367_2(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x12664E4
	internal void <.cctor>b__367_3(IAsyncResult ares) { }

	// RVA: 0x12667B0
	internal void <.cctor>b__367_4(IOAsyncResult ares) { }

	// RVA: 0x1266934
	internal void <.cctor>b__367_5(IOAsyncResult ares) { }

	// RVA: 0x1266BFC
	internal void <.cctor>b__367_6(IAsyncResult ares) { }

	// RVA: 0x1266EBC
	internal void <.cctor>b__367_7(IOAsyncResult ares) { }

	// RVA: 0x12673AC
	internal void <.cctor>b__367_8(IAsyncResult ares) { }

	// RVA: 0x126766C
	internal void <.cctor>b__367_9(IOAsyncResult ares) { }

	// RVA: 0x1267790
	internal void <.cctor>b__367_10(IAsyncResult ares) { }

	// RVA: 0x1267AAC
	internal void <.cctor>b__367_11(IOAsyncResult ares) { }

	// RVA: 0x1267D7C
	internal void <.cctor>b__367_12(IOAsyncResult ares) { }

	// RVA: 0x1267F10
	internal void <.cctor>b__367_13(IAsyncResult ares) { }

	// RVA: 0x1268200
	internal void <.cctor>b__367_14(IOAsyncResult ares) { }

	// RVA: 0x12683BC
	internal void <.cctor>b__367_15(IAsyncResult ares) { }

	// RVA: 0x12686D8
	internal void <.cctor>b__367_16(IOAsyncResult ares) { }

	// RVA: 0x126886C
	internal void <.cctor>b__367_17(IAsyncResult ares) { }

}

// Namespace: 
private sealed class <>c__DisplayClass240_0
{
	// Fields
	public SocketAsyncResult sockares; // 0x10

	// Methods

	// RVA: 0x125FCC4
	public void .ctor() { }

	// RVA: 0x1268B3C
	internal void <BeginConnect>b__0(System.Threading.Tasks.Task<System.Net.IPAddress[]> t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass298_0
{
	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x12624F8
	public void .ctor() { }

	// RVA: 0x1268CA8
	internal void <BeginSendCallback>b__0(IOAsyncResult s) { }

}

// Namespace: 
private sealed class <>c__DisplayClass355_0
{
	// Fields
	public Socket <>4__this; // 0x10
	public IOSelectorJob job; // 0x18
	public IntPtr handle; // 0x20

	// Methods

	// RVA: 0x1262D20
	public void .ctor() { }

	// RVA: 0x1268D5C
	internal void <QueueIOSelectorJob>b__0(Task t) { }

}

// Namespace: System.Net.Sockets
public class Socket
{
	// Fields
	private static readonly System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> AcceptCompletedHandler; // 0x0
	private static readonly System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> ReceiveCompletedHandler; // 0x8
	private static readonly System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> SendCompletedHandler; // 0x10
	private static readonly System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> s_rentedSocketSentinel; // 0x18
	private static readonly Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel; // 0x20
	private static readonly System.Threading.Tasks.Task<System.Int32> s_zeroTask; // 0x28
	private CachedEventArgs _cachedTaskEventArgs; // 0x10
	private static object s_InternalSyncObject; // 0x30
	internal static bool s_SupportsIPv4; // 0x38
	internal static bool s_SupportsIPv6; // 0x39
	internal static bool s_OSSupportsIPv6; // 0x3A
	internal static bool s_Initialized; // 0x3B
	private static bool s_LoggingEnabled; // 0x3C
	private bool is_closed; // 0x18
	private bool is_listening; // 0x19
	private int linger_timeout; // 0x1C
	private AddressFamily addressFamily; // 0x20
	private SocketType socketType; // 0x24
	private ProtocolType protocolType; // 0x28
	internal SafeSocketHandle m_Handle; // 0x30
	internal EndPoint seed_endpoint; // 0x38
	internal SemaphoreSlim ReadSem; // 0x40
	internal SemaphoreSlim WriteSem; // 0x48
	internal bool is_blocking; // 0x50
	internal bool is_bound; // 0x51
	internal bool is_connected; // 0x52
	private int m_IntCleanedUp; // 0x54
	internal bool connect_in_progress; // 0x58
	private static AsyncCallback AcceptAsyncCallback; // 0x40
	private static IOAsyncCallback BeginAcceptCallback; // 0x48
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x50
	private static AsyncCallback ConnectAsyncCallback; // 0x58
	private static IOAsyncCallback BeginConnectCallback; // 0x60
	private static AsyncCallback DisconnectAsyncCallback; // 0x68
	private static IOAsyncCallback BeginDisconnectCallback; // 0x70
	private static AsyncCallback ReceiveAsyncCallback; // 0x78
	private static IOAsyncCallback BeginReceiveCallback; // 0x80
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x88
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x90
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x98
	private static AsyncCallback SendAsyncCallback; // 0xA0
	private static IOAsyncCallback BeginSendGenericCallback; // 0xA8
	private static AsyncCallback SendToAsyncCallback; // 0xB0

	// Methods

	// RVA: 0x125835C
	internal System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(System.Memory<System.Byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	// RVA: 0x1259908
	private System.Threading.Tasks.Task<System.Int32> ReceiveAsyncApm(System.Memory<System.Byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x1258D80
	internal ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<System.Byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x1259E7C
	private System.Threading.Tasks.Task<System.Int32> SendAsyncApm(System.ReadOnlyMemory<System.Byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x125A3B8
	private static void CompleteAccept(Socket s, System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }

	// RVA: 0x125A708
	private static void CompleteSendReceive(Socket s, Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x125A624
	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions) { }

	// RVA: 0x125A8BC
	private void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x125A5BC
	private void ReturnSocketAsyncEventArgs(System.Net.Sockets.Socket.TaskSocketAsyncEventArgs<System.Net.Sockets.Socket> saea) { }

	// RVA: 0x125A918
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x125B1B8
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x125B220
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x125B288
	public IntPtr get_Handle() { }

	// RVA: 0x125B2A8
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x125B2B0
	public SocketType get_SocketType() { }

	// RVA: 0x125B2B8
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x125B2C0
	public void set_DontFragment(bool value) { }

	// RVA: 0x125B464
	public bool get_DualMode() { }

	// RVA: 0x125B548
	public void set_DualMode(bool value) { }

	// RVA: 0x125B5C8
	private bool get_IsDualMode() { }

	// RVA: 0x125B5E0
	internal bool CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0x125B618
	public int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x125690C
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x125BDFC
	public int SendTo(Byte[] buffer, EndPoint remoteEP) { }

	// RVA: 0x125605C
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x125C190
	public int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x125C784
	public int IOControl(IOControlCode ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x125AFC8
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x1257C18
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1257F10
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x1257518
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1257810
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x125D0C8
	private static object get_InternalSyncObject() { }

	// RVA: 0x125D1CC
	internal bool get_CleanedUp() { }

	// RVA: 0x125ABAC
	internal static void InitializeSockets() { }

	// RVA: 0x125D25C
	public void Dispose() { }

	// RVA: 0x125D2EC
	protected override void Finalize() { }

	// RVA: 0x1256FB0
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x12594C0
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x125D648
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x125B0D0
	private void SocketDefaults() { }

	// RVA: 0x125AEA0
	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, int error) { }

	// RVA: 0x125D7DC
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x125D964
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, int error) { }

	// RVA: 0x125DABC
	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, int error) { }

	// RVA: 0x125DAC0
	public bool get_Blocking() { }

	// RVA: 0x125DAC8
	public void set_Blocking(bool value) { }

	// RVA: 0x125DB94
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, int error) { }

	// RVA: 0x125DCDC
	internal static void Blocking_icall(IntPtr socket, bool block, int error) { }

	// RVA: 0x125DCE0
	public bool get_Connected() { }

	// RVA: 0x125D768
	public void set_NoDelay(bool value) { }

	// RVA: 0x125DD40
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x125DE48
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, int error) { }

	// RVA: 0x125DFA0
	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, int error) { }

	// RVA: 0x125DFA4
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x125E154
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, int error) { }

	// RVA: 0x125E2BC
	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, int error) { }

	// RVA: 0x125E2C0
	public Socket Accept() { }

	// RVA: 0x125E560
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x125E698
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x125E9F8
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x125EA24
	public Socket EndAccept(Byte[] buffer, int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x125E400
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, int error, bool blocking) { }

	// RVA: 0x125EE78
	private static IntPtr Accept_icall(IntPtr sock, int error, bool blocking) { }

	// RVA: 0x125EE7C
	public void Bind(EndPoint localEP) { }

	// RVA: 0x125F0D8
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, int error) { }

	// RVA: 0x125F220
	private static void Bind_icall(IntPtr sock, SocketAddress sa, int error) { }

	// RVA: 0x125F224
	public void Listen(int backlog) { }

	// RVA: 0x125F314
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, int error) { }

	// RVA: 0x125F45C
	private static void Listen_icall(IntPtr sock, int backlog, int error) { }

	// RVA: 0x125F460
	public void Connect(IPAddress address, int port) { }

	// RVA: 0x125F4E0
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x125F988
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	// RVA: 0x125FCCC
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1260320
	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x125FE30
	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x126058C
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x125F858
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x1260658
	private static void Connect_icall(IntPtr sock, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x126065C
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x12608A8
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x1260760
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, int error) { }

	// RVA: 0x1260974
	private static void Disconnect_icall(IntPtr sock, bool reuse, int error) { }

	// RVA: 0x125C034
	public int Receive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x1260C54
	private int Receive(System.Memory<System.Byte> buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x125C1F8
	public int Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x1256330
	public int Receive(System.Span<System.Byte> buffer, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x1256C24
	public int Send(System.ReadOnlySpan<System.Byte> buffer, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x1260FBC
	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x125CD40
	public IAsyncResult BeginReceive(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x125CF40
	public int EndReceive(IAsyncResult asyncResult, SocketError errorCode) { }

	// RVA: 0x1260E64
	private static int Receive_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1261318
	private static int Receive_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1260AFC
	private static int Receive_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x126131C
	private static int Receive_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1261320
	private int ReceiveFrom(System.Memory<System.Byte> buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, SocketError errorCode) { }

	// RVA: 0x126172C
	public IAsyncResult BeginReceiveFrom(Byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1261988
	public int EndReceiveFrom(IAsyncResult asyncResult, EndPoint endPoint) { }

	// RVA: 0x1261AA0
	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	// RVA: 0x12615CC
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, SocketAddress sockaddr, int error, bool blocking) { }

	// RVA: 0x1261B74
	private static int ReceiveFrom_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, SocketAddress sockaddr, int error, bool blocking) { }

	// RVA: 0x125BC74
	public int Send(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x125B680
	public int Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>> buffers, SocketFlags socketFlags, SocketError errorCode) { }

	// RVA: 0x1261E28
	public bool SendAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x125C918
	public IAsyncResult BeginSend(Byte[] buffer, int offset, int size, SocketFlags socketFlags, SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x126214C
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x125CBB8
	public int EndSend(IAsyncResult asyncResult, SocketError errorCode) { }

	// RVA: 0x1261CD0
	private static int Send_internal(SafeSocketHandle safeHandle, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1262530
	private static int Send_array_icall(IntPtr sock, WSABUF* bufarray, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1261B78
	private static int Send_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x1262534
	private static int Send_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, int error, bool blocking) { }

	// RVA: 0x125BE30
	public int SendTo(Byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x1262698
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x1262538
	private static int SendTo_internal(SafeSocketHandle safeHandle, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x1262754
	private static int SendTo_icall(IntPtr sock, Byte* buffer, int count, SocketFlags flags, SocketAddress sa, int error, bool blocking) { }

	// RVA: 0x1255638
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x1262758
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, int error) { }

	// RVA: 0x12628B8
	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, int error) { }

	// RVA: 0x125B340
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x125D4D0
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, int error) { }

	// RVA: 0x12628BC
	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, Byte[] byte_val, int int_val, int error) { }

	// RVA: 0x125C788
	public int IOControl(int ioControlCode, Byte[] optionInValue, Byte[] optionOutValue) { }

	// RVA: 0x12628C0
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, Byte[] input, Byte[] output, int error) { }

	// RVA: 0x1262A30
	private static int IOControl_icall(IntPtr sock, int ioctl_code, Byte[] input, Byte[] output, int error) { }

	// RVA: 0x1262A34
	public void Close() { }

	// RVA: 0x1257044
	public void Close(int timeout) { }

	// RVA: 0x1262AC8
	internal static void Close_icall(IntPtr socket, int error) { }

	// RVA: 0x125D388
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, int error) { }

	// RVA: 0x1262ACC
	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, int error) { }

	// RVA: 0x1262AD0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1262B40
	private void Linger(IntPtr handle) { }

	// RVA: 0x125D8DC
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x1260978
	private void ThrowIfBufferNull(Byte[] buffer) { }

	// RVA: 0x12609D4
	private void ThrowIfBufferOutOfRange(Byte[] buffer, int offset, int size) { }

	// RVA: 0x125DCE8
	private void ThrowIfUdp() { }

	// RVA: 0x125EB28
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x125E898
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x1261200
	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1262E64
	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	// RVA: 0x125F018
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x1262FFC
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x1263000
	internal static int get_FamilyHint() { }

	// RVA: 0x1263148
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x125D1DC
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x126314C
	private static void .cctor() { }

}

// Namespace: System.Net.Sockets
[Serializable]
public class SocketException
{
	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Methods

	// RVA: 0x1268DA4
	private static int WSAGetLastError_icall() { }

	// RVA: 0x125AF9C
	public void .ctor() { }

	// RVA: 0x1268DA8
	internal void .ctor(int error, string message) { }

	// RVA: 0x125643C
	public void .ctor(int errorCode) { }

	// RVA: 0x125BC6C
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x1268DB0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1268DB8
	public override string get_Message() { }

	// RVA: 0x12667A8
	public SocketError get_SocketErrorCode() { }

}

// Namespace: System.Net.Sockets
public enum AddressFamily
{
	// Fields
	public int value__; // 0x10
	public const AddressFamily Unknown = 4294967295;
	public const AddressFamily Unspecified = 0;
	public const AddressFamily Unix = 1;
	public const AddressFamily InterNetwork = 2;
	public const AddressFamily ImpLink = 3;
	public const AddressFamily Pup = 4;
	public const AddressFamily Chaos = 5;
	public const AddressFamily NS = 6;
	public const AddressFamily Ipx = 6;
	public const AddressFamily Iso = 7;
	public const AddressFamily Osi = 7;
	public const AddressFamily Ecma = 8;
	public const AddressFamily DataKit = 9;
	public const AddressFamily Ccitt = 10;
	public const AddressFamily Sna = 11;
	public const AddressFamily DecNet = 12;
	public const AddressFamily DataLink = 13;
	public const AddressFamily Lat = 14;
	public const AddressFamily HyperChannel = 15;
	public const AddressFamily AppleTalk = 16;
	public const AddressFamily NetBios = 17;
	public const AddressFamily VoiceView = 18;
	public const AddressFamily FireFox = 19;
	public const AddressFamily Banyan = 21;
	public const AddressFamily Atm = 22;
	public const AddressFamily InterNetworkV6 = 23;
	public const AddressFamily Cluster = 24;
	public const AddressFamily Ieee12844 = 25;
	public const AddressFamily Irda = 26;
	public const AddressFamily NetworkDesigners = 28;
	public const AddressFamily Max = 29;
}

// Namespace: System.Net.Sockets
public enum IOControlCode
{
	// Fields
	public Int64 value__; // 0x10
	public const IOControlCode AsyncIO = 2147772029;
	public const IOControlCode NonBlockingIO = 2147772030;
	public const IOControlCode DataToRead = 1074030207;
	public const IOControlCode OobDataRead = 1074033415;
	public const IOControlCode AssociateHandle = 2281701377;
	public const IOControlCode EnableCircularQueuing = 671088642;
	public const IOControlCode Flush = 671088644;
	public const IOControlCode GetBroadcastAddress = 1207959557;
	public const IOControlCode GetExtensionFunctionPointer = 3355443206;
	public const IOControlCode GetQos = 3355443207;
	public const IOControlCode GetGroupQos = 3355443208;
	public const IOControlCode MultipointLoopback = 2281701385;
	public const IOControlCode MulticastScope = 2281701386;
	public const IOControlCode SetQos = 2281701387;
	public const IOControlCode SetGroupQos = 2281701388;
	public const IOControlCode TranslateHandle = 3355443213;
	public const IOControlCode RoutingInterfaceQuery = 3355443220;
	public const IOControlCode RoutingInterfaceChange = 2281701397;
	public const IOControlCode AddressListQuery = 1207959574;
	public const IOControlCode AddressListChange = 671088663;
	public const IOControlCode QueryTargetPnpHandle = 1207959576;
	public const IOControlCode NamespaceChange = 2281701401;
	public const IOControlCode AddressListSort = 3355443225;
	public const IOControlCode ReceiveAll = 2550136833;
	public const IOControlCode ReceiveAllMulticast = 2550136834;
	public const IOControlCode ReceiveAllIgmpMulticast = 2550136835;
	public const IOControlCode KeepAliveValues = 2550136836;
	public const IOControlCode AbsorbRouterAlert = 2550136837;
	public const IOControlCode UnicastInterface = 2550136838;
	public const IOControlCode LimitBroadcasts = 2550136839;
	public const IOControlCode BindToInterface = 2550136840;
	public const IOControlCode MulticastInterface = 2550136841;
	public const IOControlCode AddMulticastGroupOnInterface = 2550136842;
	public const IOControlCode DeleteMulticastGroupFromInterface = 2550136843;
}

// Namespace: System.Net.Sockets
public enum IPProtectionLevel
{
	// Fields
	public int value__; // 0x10
	public const IPProtectionLevel Unspecified = 4294967295;
	public const IPProtectionLevel Unrestricted = 10;
	public const IPProtectionLevel EdgeRestricted = 20;
	public const IPProtectionLevel Restricted = 30;
}

// Namespace: System.Net.Sockets
public class LingerOption
{
	// Fields
	private bool enabled; // 0x10
	private int lingerTime; // 0x14

	// Methods

	// RVA: 0x1262CE4
	public void .ctor(bool enable, int seconds) { }

	// RVA: 0x1268E58
	public void set_Enabled(bool value) { }

	// RVA: 0x1268E60
	public void set_LingerTime(int value) { }

}

// Namespace: System.Net.Sockets
public class MulticastOption
{}

// Namespace: System.Net.Sockets
public enum ProtocolType
{
	// Fields
	public int value__; // 0x10
	public const ProtocolType IP = 0;
	public const ProtocolType IPv6HopByHopOptions = 0;
	public const ProtocolType Icmp = 1;
	public const ProtocolType Igmp = 2;
	public const ProtocolType Ggp = 3;
	public const ProtocolType IPv4 = 4;
	public const ProtocolType Tcp = 6;
	public const ProtocolType Pup = 12;
	public const ProtocolType Udp = 17;
	public const ProtocolType Idp = 22;
	public const ProtocolType IPv6 = 41;
	public const ProtocolType IPv6RoutingHeader = 43;
	public const ProtocolType IPv6FragmentHeader = 44;
	public const ProtocolType IPSecEncapsulatingSecurityPayload = 50;
	public const ProtocolType IPSecAuthenticationHeader = 51;
	public const ProtocolType IcmpV6 = 58;
	public const ProtocolType IPv6NoNextHeader = 59;
	public const ProtocolType IPv6DestinationOptions = 60;
	public const ProtocolType ND = 77;
	public const ProtocolType Raw = 255;
	public const ProtocolType Unspecified = 0;
	public const ProtocolType Ipx = 1000;
	public const ProtocolType Spx = 1256;
	public const ProtocolType SpxII = 1257;
	public const ProtocolType Unknown = 4294967295;
}

// Namespace: System.Net.Sockets
public enum SelectMode
{
	// Fields
	public int value__; // 0x10
	public const SelectMode SelectRead = 0;
	public const SelectMode SelectWrite = 1;
	public const SelectMode SelectError = 2;
}

// Namespace: System.Net.Sockets
public enum SocketAsyncOperation
{
	// Fields
	public int value__; // 0x10
	public const SocketAsyncOperation None = 0;
	public const SocketAsyncOperation Accept = 1;
	public const SocketAsyncOperation Connect = 2;
	public const SocketAsyncOperation Disconnect = 3;
	public const SocketAsyncOperation Receive = 4;
	public const SocketAsyncOperation ReceiveFrom = 5;
	public const SocketAsyncOperation ReceiveMessageFrom = 6;
	public const SocketAsyncOperation Send = 7;
	public const SocketAsyncOperation SendPackets = 8;
	public const SocketAsyncOperation SendTo = 9;
}

// Namespace: System.Net.Sockets
public enum SocketError
{
	// Fields
	public int value__; // 0x10
	public const SocketError Success = 0;
	public const SocketError SocketError = 4294967295;
	public const SocketError Interrupted = 10004;
	public const SocketError AccessDenied = 10013;
	public const SocketError Fault = 10014;
	public const SocketError InvalidArgument = 10022;
	public const SocketError TooManyOpenSockets = 10024;
	public const SocketError WouldBlock = 10035;
	public const SocketError InProgress = 10036;
	public const SocketError AlreadyInProgress = 10037;
	public const SocketError NotSocket = 10038;
	public const SocketError DestinationAddressRequired = 10039;
	public const SocketError MessageSize = 10040;
	public const SocketError ProtocolType = 10041;
	public const SocketError ProtocolOption = 10042;
	public const SocketError ProtocolNotSupported = 10043;
	public const SocketError SocketNotSupported = 10044;
	public const SocketError OperationNotSupported = 10045;
	public const SocketError ProtocolFamilyNotSupported = 10046;
	public const SocketError AddressFamilyNotSupported = 10047;
	public const SocketError AddressAlreadyInUse = 10048;
	public const SocketError AddressNotAvailable = 10049;
	public const SocketError NetworkDown = 10050;
	public const SocketError NetworkUnreachable = 10051;
	public const SocketError NetworkReset = 10052;
	public const SocketError ConnectionAborted = 10053;
	public const SocketError ConnectionReset = 10054;
	public const SocketError NoBufferSpaceAvailable = 10055;
	public const SocketError IsConnected = 10056;
	public const SocketError NotConnected = 10057;
	public const SocketError Shutdown = 10058;
	public const SocketError TimedOut = 10060;
	public const SocketError ConnectionRefused = 10061;
	public const SocketError HostDown = 10064;
	public const SocketError HostUnreachable = 10065;
	public const SocketError ProcessLimit = 10067;
	public const SocketError SystemNotReady = 10091;
	public const SocketError VersionNotSupported = 10092;
	public const SocketError NotInitialized = 10093;
	public const SocketError Disconnecting = 10101;
	public const SocketError TypeNotFound = 10109;
	public const SocketError HostNotFound = 11001;
	public const SocketError TryAgain = 11002;
	public const SocketError NoRecovery = 11003;
	public const SocketError NoData = 11004;
	public const SocketError IOPending = 997;
	public const SocketError OperationAborted = 995;
}

// Namespace: System.Net.Sockets
public enum SocketFlags
{
	// Fields
	public int value__; // 0x10
	public const SocketFlags None = 0;
	public const SocketFlags OutOfBand = 1;
	public const SocketFlags Peek = 2;
	public const SocketFlags DontRoute = 4;
	public const SocketFlags MaxIOVectorLength = 16;
	public const SocketFlags Truncated = 256;
	public const SocketFlags ControlDataTruncated = 512;
	public const SocketFlags Broadcast = 1024;
	public const SocketFlags Multicast = 2048;
	public const SocketFlags Partial = 32768;
}

// Namespace: System.Net.Sockets
public enum SocketOptionLevel
{
	// Fields
	public int value__; // 0x10
	public const SocketOptionLevel Socket = 65535;
	public const SocketOptionLevel IP = 0;
	public const SocketOptionLevel IPv6 = 41;
	public const SocketOptionLevel Tcp = 6;
	public const SocketOptionLevel Udp = 17;
}

// Namespace: System.Net.Sockets
public enum SocketOptionName
{
	// Fields
	public int value__; // 0x10
	public const SocketOptionName Debug = 1;
	public const SocketOptionName AcceptConnection = 2;
	public const SocketOptionName ReuseAddress = 4;
	public const SocketOptionName KeepAlive = 8;
	public const SocketOptionName DontRoute = 16;
	public const SocketOptionName Broadcast = 32;
	public const SocketOptionName UseLoopback = 64;
	public const SocketOptionName Linger = 128;
	public const SocketOptionName OutOfBandInline = 256;
	public const SocketOptionName DontLinger = 4294967167;
	public const SocketOptionName ExclusiveAddressUse = 4294967291;
	public const SocketOptionName SendBuffer = 4097;
	public const SocketOptionName ReceiveBuffer = 4098;
	public const SocketOptionName SendLowWater = 4099;
	public const SocketOptionName ReceiveLowWater = 4100;
	public const SocketOptionName SendTimeout = 4101;
	public const SocketOptionName ReceiveTimeout = 4102;
	public const SocketOptionName Error = 4103;
	public const SocketOptionName Type = 4104;
	public const SocketOptionName ReuseUnicastPort = 12295;
	public const SocketOptionName MaxConnections = 2147483647;
	public const SocketOptionName IPOptions = 1;
	public const SocketOptionName HeaderIncluded = 2;
	public const SocketOptionName TypeOfService = 3;
	public const SocketOptionName IpTimeToLive = 4;
	public const SocketOptionName MulticastInterface = 9;
	public const SocketOptionName MulticastTimeToLive = 10;
	public const SocketOptionName MulticastLoopback = 11;
	public const SocketOptionName AddMembership = 12;
	public const SocketOptionName DropMembership = 13;
	public const SocketOptionName DontFragment = 14;
	public const SocketOptionName AddSourceMembership = 15;
	public const SocketOptionName DropSourceMembership = 16;
	public const SocketOptionName BlockSource = 17;
	public const SocketOptionName UnblockSource = 18;
	public const SocketOptionName PacketInformation = 19;
	public const SocketOptionName HopLimit = 21;
	public const SocketOptionName IPProtectionLevel = 23;
	public const SocketOptionName IPv6Only = 27;
	public const SocketOptionName NoDelay = 1;
	public const SocketOptionName BsdUrgent = 2;
	public const SocketOptionName Expedited = 2;
	public const SocketOptionName NoChecksum = 1;
	public const SocketOptionName ChecksumCoverage = 20;
	public const SocketOptionName UpdateAcceptContext = 28683;
	public const SocketOptionName UpdateConnectContext = 28688;
}

// Namespace: System.Net.Sockets
public enum SocketShutdown
{
	// Fields
	public int value__; // 0x10
	public const SocketShutdown Receive = 0;
	public const SocketShutdown Send = 1;
	public const SocketShutdown Both = 2;
}

// Namespace: System.Net.Sockets
public enum SocketType
{
	// Fields
	public int value__; // 0x10
	public const SocketType Stream = 1;
	public const SocketType Dgram = 2;
	public const SocketType Raw = 3;
	public const SocketType Rdm = 4;
	public const SocketType Seqpacket = 5;
	public const SocketType Unknown = 4294967295;
}

// Namespace: System.Net.Sockets
public class TcpClient
{
	// Fields
	private Socket m_ClientSocket; // 0x10
	private bool m_Active; // 0x18
	private NetworkStream m_DataStream; // 0x20
	private AddressFamily m_Family; // 0x28
	private bool m_CleanedUp; // 0x2C

	// Methods

	// RVA: 0x1268E68
	public void .ctor() { }

	// RVA: 0x1268E8C
	public void .ctor(AddressFamily family) { }

	// RVA: 0x1269078
	public Socket get_Client() { }

	// RVA: 0x1269080
	public void set_Client(Socket value) { }

	// RVA: 0x1269088
	public void Connect(string hostname, int port) { }

	// RVA: 0x1269908
	public void Connect(IPEndPoint remoteEP) { }

	// RVA: 0x1269A08
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x1269A7C
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1269AC4
	public Task ConnectAsync(string host, int port) { }

	// RVA: 0x1269C60
	public NetworkStream GetStream() { }

	// RVA: 0x1269DC4
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x126A060
	public void Dispose() { }

	// RVA: 0x126A070
	protected override void Finalize() { }

	// RVA: 0x1268FF8
	private void initialize() { }

}

// Namespace: System.Net.Sockets
internal sealed class SafeSocketHandle
{
	// Fields
	private System.Collections.Generic.List<System.Threading.Thread> blocking_threads; // 0x20
	private System.Collections.Generic.Dictionary<System.Threading.Thread,System.Diagnostics.StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0x125AEA4
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x126A10C
	protected override bool ReleaseHandle() { }

	// RVA: 0x125ED30
	public void RegisterForBlockingSyscall() { }

	// RVA: 0x126A81C
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0x126AA38
	private static void .cctor() { }

}

// Namespace: System.Net.Sockets
public class SocketAsyncEventArgs
{
	// Fields
	private bool disposed; // 0x10
	internal int in_progress; // 0x14
	private EndPoint remote_ep; // 0x18
	private Socket current_socket; // 0x20
	internal SocketAsyncResult socket_async_result; // 0x28
	private Socket <AcceptSocket>k__BackingField; // 0x30
	private int <BytesTransferred>k__BackingField; // 0x38
	private SocketAsyncOperation <LastOperation>k__BackingField; // 0x3C
	private SocketError <SocketError>k__BackingField; // 0x40
	private SocketFlags <SocketFlags>k__BackingField; // 0x44
	private object <UserToken>k__BackingField; // 0x48
	private System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> Completed; // 0x50
	private System.Memory<System.Byte> _buffer; // 0x58
	private int _offset; // 0x68
	private int _count; // 0x6C
	private bool _bufferIsExplicitArray; // 0x70
	private System.Collections.Generic.IList<System.ArraySegment<System.Byte>> _bufferList; // 0x78

	// Methods

	// RVA: 0x126AACC
	public Socket get_AcceptSocket() { }

	// RVA: 0x126AAD4
	public void set_AcceptSocket(Socket value) { }

	// RVA: 0x126AADC
	public int get_BytesTransferred() { }

	// RVA: 0x126AAE4
	private void set_BytesTransferred(int value) { }

	// RVA: 0x126AAEC
	private void set_LastOperation(SocketAsyncOperation value) { }

	// RVA: 0x126AAF4
	public void set_RemoteEndPoint(EndPoint value) { }

	// RVA: 0x126AAFC
	public SocketError get_SocketError() { }

	// RVA: 0x126AB04
	public void set_SocketError(SocketError value) { }

	// RVA: 0x126AB0C
	public void set_SocketFlags(SocketFlags value) { }

	// RVA: 0x126AB14
	public object get_UserToken() { }

	// RVA: 0x126AB1C
	public void set_UserToken(object value) { }

	// RVA: 0x12639A8
	internal void .ctor(bool flowExecutionContext) { }

	// RVA: 0x126AB2C
	protected override void Finalize() { }

	// RVA: 0x126AB3C
	private void Dispose(bool disposing) { }

	// RVA: 0x126AB50
	public void Dispose() { }

	// RVA: 0x1262FF4
	internal void SetBytesTransferred(int value) { }

	// RVA: 0x126ABF0
	internal Socket get_CurrentSocket() { }

	// RVA: 0x126ABF8
	internal void SetCurrentSocket(Socket socket) { }

	// RVA: 0x1262F14
	internal void SetLastOperation(SocketAsyncOperation op) { }

	// RVA: 0x126AC00
	internal void Complete_internal() { }

	// RVA: 0x126AC34
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

	// RVA: 0x126AC5C
	public System.Memory<System.Byte> get_MemoryBuffer() { }

	// RVA: 0x126AC68
	public int get_Offset() { }

	// RVA: 0x126AC70
	public int get_Count() { }

	// RVA: 0x126AC78
	public System.Collections.Generic.IList<System.ArraySegment<System.Byte>> get_BufferList() { }

	// RVA: 0x125974C
	public void SetBuffer(System.Memory<System.Byte> buffer) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Net.Sockets.SocketAsyncResult.<>c <>9; // 0x0
	public static WaitCallback <>9__27_0; // 0x8

	// Methods

	// RVA: 0x126AC84
	private static void .cctor() { }

	// RVA: 0x126ACF0
	public void .ctor() { }

	// RVA: 0x126ACF8
	internal void <Complete>b__27_0(object state) { }

}

// Namespace: System.Net.Sockets
internal sealed class SocketAsyncResult
{
	// Fields
	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public System.Memory<System.Byte> Buffer; // 0x50
	public int Offset; // 0x60
	public int Size; // 0x64
	public SocketFlags SockFlags; // 0x68
	public Socket AcceptSocket; // 0x70
	public IPAddress[] Addresses; // 0x78
	public int Port; // 0x80
	public System.Collections.Generic.IList<System.ArraySegment<System.Byte>> Buffers; // 0x88
	public bool ReuseSocket; // 0x90
	public int CurrentAddress; // 0x94
	public Socket AcceptedSocket; // 0x98
	public int Total; // 0xA0
	internal int error; // 0xA4
	public int EndCalled; // 0xA8

	// Methods

	// RVA: 0x125E864
	public IntPtr get_Handle() { }

	// RVA: 0x126AB24
	public void .ctor() { }

	// RVA: 0x1262D28
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x125E814
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1261288
	public SocketError get_ErrorCode() { }

	// RVA: 0x125EC8C
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x126AC80
	internal override void CompleteDisposed() { }

	// RVA: 0x12671A8
	public void Complete() { }

	// RVA: 0x1260584
	public void Complete(bool synch) { }

	// RVA: 0x1262528
	public void Complete(int total) { }

	// RVA: 0x1260554
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x1262500
	public void Complete(Exception e) { }

	// RVA: 0x126690C
	public void Complete(Socket s) { }

	// RVA: 0x1266BCC
	public void Complete(Socket s, int total) { }

}

// Namespace: System.Net.Sockets
internal enum SocketOperation
{
	// Fields
	public int value__; // 0x10
	public const SocketOperation Accept = 0;
	public const SocketOperation Connect = 1;
	public const SocketOperation Receive = 2;
	public const SocketOperation ReceiveFrom = 3;
	public const SocketOperation Send = 4;
	public const SocketOperation SendTo = 5;
	public const SocketOperation RecvJustCallback = 6;
	public const SocketOperation SendJustCallback = 7;
	public const SocketOperation Disconnect = 8;
	public const SocketOperation AcceptReceive = 9;
	public const SocketOperation ReceiveGeneric = 10;
	public const SocketOperation SendGeneric = 11;
}

// Namespace: System.Net.Security
public class SslClientAuthenticationOptions
{
	// Fields
	private EncryptionPolicy _encryptionPolicy; // 0x10
	private X509RevocationMode _checkCertificateRevocation; // 0x14
	private SslProtocols _enabledSslProtocols; // 0x18
	private bool _allowRenegotiation; // 0x1C
	private string <TargetHost>k__BackingField; // 0x20
	private X509CertificateCollection <ClientCertificates>k__BackingField; // 0x28

	// Methods

	// RVA: 0x126AD74
	public bool get_AllowRenegotiation() { }

	// RVA: 0x126AD7C
	public string get_TargetHost() { }

	// RVA: 0x126AD84
	public void set_TargetHost(string value) { }

	// RVA: 0x126AD8C
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x126AD94
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x126AD9C
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x126AE3C
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x126AEDC
	public SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x126AEE4
	public void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x126AEEC
	public void .ctor() { }

}

// Namespace: System.Net.Security
public abstract class AuthenticatedStream
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Methods

	// RVA: 0x126AEFC
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x126B0C0
	protected Stream get_InnerStream() { }

	// RVA: 0x126B0C8
	protected override void Dispose(bool disposing) { }

	// RVA: -1
	public abstract bool get_IsAuthenticated() { }

}

// Namespace: System.Net.Security
public enum AuthenticationLevel
{
	// Fields
	public int value__; // 0x10
	public const AuthenticationLevel None = 0;
	public const AuthenticationLevel MutualAuthRequested = 1;
	public const AuthenticationLevel MutualAuthRequired = 2;
}

// Namespace: System.Net.Security
public enum EncryptionPolicy
{
	// Fields
	public int value__; // 0x10
	public const EncryptionPolicy RequireEncryption = 0;
	public const EncryptionPolicy AllowNoEncryption = 1;
	public const EncryptionPolicy NoEncryption = 2;
}

// Namespace: System.Net.Security
public sealed class LocalCertificateSelectionCallback
{
	// Methods

	// RVA: 0x126B1E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x126B308
	public virtual X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback
{
	// Methods

	// RVA: 0x126B31C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x126B440
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

// Namespace: System.Net.Security
public enum SslPolicyErrors
{
	// Fields
	public int value__; // 0x10
	public const SslPolicyErrors None = 0;
	public const SslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const SslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const SslPolicyErrors RemoteCertificateChainErrors = 4;
}

// Namespace: System.Net.Security
internal sealed class LocalCertSelectionCallback
{
	// Methods

	// RVA: 0x126B454
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x126B510
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

}

// Namespace: System.Net.Security
internal sealed class ServerCertSelectionCallback
{
	// Methods

	// RVA: 0x126B524
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x126B5D8
	public virtual X509Certificate Invoke(string hostName) { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0
{
	// Fields
	public LocalCertificateSelectionCallback callback; // 0x10
	public SslStream <>4__this; // 0x18

	// Methods

	// RVA: 0x126BCF0
	public void .ctor() { }

	// RVA: 0x126C788
	internal X509Certificate <SetAndVerifySelectionCallback>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

}

// Namespace: System.Net.Security
public class SslStream
{
	// Fields
	private MobileTlsProvider provider; // 0x38
	private MonoTlsSettings settings; // 0x40
	private RemoteCertificateValidationCallback validationCallback; // 0x48
	private LocalCertificateSelectionCallback selectionCallback; // 0x50
	private MobileAuthenticatedStream impl; // 0x58
	private bool explicitSettings; // 0x60

	// Methods

	// RVA: 0x126B5EC
	internal MobileAuthenticatedStream get_Impl() { }

	// RVA: 0x126B6BC
	internal string get_InternalTargetHost() { }

	// RVA: 0x126B728
	private static MobileTlsProvider GetProvider() { }

	// RVA: 0x126B7A4
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	// RVA: 0x126B7AC
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	// RVA: 0x126BB9C
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x126B8D0
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	// RVA: 0x126B9D0
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	// RVA: 0x126BCF8
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x126BD64
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x126BDE8
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x126BDF4
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x126BE60
	public override bool get_IsAuthenticated() { }

	// RVA: 0x126BED4
	public virtual X509Certificate get_LocalCertificate() { }

	// RVA: 0x126BF40
	public override bool get_CanSeek() { }

	// RVA: 0x126BF48
	public override bool get_CanRead() { }

	// RVA: 0x126BF60
	public override bool get_CanTimeout() { }

	// RVA: 0x126BF84
	public override bool get_CanWrite() { }

	// RVA: 0x126BF9C
	public override int get_ReadTimeout() { }

	// RVA: 0x126C010
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x126C084
	public override int get_WriteTimeout() { }

	// RVA: 0x126C0F8
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x126C16C
	public override Int64 get_Length() { }

	// RVA: 0x126C1DC
	public override Int64 get_Position() { }

	// RVA: 0x126C24C
	public override void set_Position(Int64 value) { }

	// RVA: 0x126C2A8
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x126C304
	public override Task FlushAsync(CancellationToken cancellationToken) { }

	// RVA: 0x126C32C
	public override void Flush() { }

	// RVA: 0x126B654
	private void CheckDisposed() { }

	// RVA: 0x126C354
	protected override void Dispose(bool disposing) { }

	// RVA: 0x126C43C
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x126C4B0
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x126C524
	public override System.Threading.Tasks.Task<System.Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x126C598
	public override Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x126C60C
	public override IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x126C690
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x126C6F8
	public override IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x126C77C
	public override void EndWrite(IAsyncResult asyncResult) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=6
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=9
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=10
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=12
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=14
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=32
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=44
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=128
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=256
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=256 00C700F38385659BA060672F86D4A9A5376EADF9ED1CABB1C63290A0FDEFE36A; // 0x0
	internal static readonly __StaticArrayInitTypeSize=32 04D9D643E5A26924DC98C9906714082D395DCB17CEE9674D5EBFEC15D098C2B5; // 0x100
	internal static readonly __StaticArrayInitTypeSize=32 063691760A57230E8119DF650327304D68AE1C009E476E48BE8C73DCA199D374; // 0x120
	internal static readonly __StaticArrayInitTypeSize=14 07FEA8B695D401E2B3BBDA6126C123DAA87153BB12384B21272ACC90823AC9A3; // 0x140
	internal static readonly Int64 1417FCAA8455DC8E3C88BF916DD5C75746A2597CC052F212A8E4394C890E012B; // 0x150
	internal static readonly __StaticArrayInitTypeSize=9 27625E383C3A91E8B65BC745FF5D4048C82B883CCD293B07DED697BF82733811; // 0x158
	internal static readonly __StaticArrayInitTypeSize=32 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70; // 0x161
	internal static readonly Int64 3505B8A2248AC03FE41ACADF8F29294572BBADEE1DD2E1A45D025766681C012C; // 0x188
	internal static readonly __StaticArrayInitTypeSize=12 356A582FCE68ACAE8FC944F7B4F0C0DA2BFF4A90D3767C75905F3EDE2E4E66CF; // 0x190
	internal static readonly __StaticArrayInitTypeSize=9 684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6; // 0x19C
	internal static readonly Int64 6C8F647E1FCD63826D12272FF0930E9C16F1FFEF719948703A4C0F3B90052885; // 0x1A8
	internal static readonly __StaticArrayInitTypeSize=128 8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3; // 0x1B0
	internal static readonly __StaticArrayInitTypeSize=44 9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8; // 0x230
	internal static readonly __StaticArrayInitTypeSize=6 9F58F1261D211553DE8FBC1AFA477C84EA3974B9BFF38223D771D0CDA787E15A; // 0x25C
	internal static readonly __StaticArrayInitTypeSize=128 B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C; // 0x262
	internal static readonly Int64 BB6BB42AC5453BD8AA992CCB8929F1CB7D4E112E3FC56E57D711E106D1F72859; // 0x2E8
	internal static readonly __StaticArrayInitTypeSize=14 DFA7289CF8D8029ACEE90F30530C6926950E8DD20285772458F271AFD015BAD5; // 0x2F0
	internal static readonly __StaticArrayInitTypeSize=10 E478CC6C0579E2198C99BFDE0ABAADC66644AF69312CB9D6E94E2D4E3559482A; // 0x2FE

	// Methods

	// RVA: 0x126C7C4
	internal static UInt32 ComputeStringHash(string s) { }

}

// Namespace: System.Configuration
public interface IConfigurationSectionHandler
{}

// Namespace: System.Net.Configuration
public sealed class BypassElement
{}

// Namespace: System.Net.Configuration
public sealed class BypassElementCollection
{
	// Methods

	// RVA: 0x126C850
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElement
{}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementElementCollection
{
	// Methods

	// RVA: 0x126C88C
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class ConnectionManagementSection
{
	// Methods

	// RVA: 0x126C8C8
	public void .ctor() { }

	// RVA: 0x126C904
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class DefaultProxySection
{
	// Methods

	// RVA: 0x126C940
	public void .ctor() { }

	// RVA: 0x126C97C
	protected override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x126C9B8
	protected override void Reset(ConfigurationElement parentElement) { }

}

// Namespace: System.Net.Configuration
public sealed class ProxyElement
{
	// Methods

	// RVA: 0x126C9F4
	public void .ctor() { }

	// RVA: 0x126CA30
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class HttpWebRequestElement
{
	// Methods

	// RVA: 0x126CA6C
	public void .ctor() { }

	// RVA: 0x126CAA8
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class Ipv6Element
{
	// Methods

	// RVA: 0x126CAE4
	public void .ctor() { }

	// RVA: 0x126CB20
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class NetSectionGroup
{
	// Methods

	// RVA: 0x126CB5C
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class SettingsSection
{
	// Methods

	// RVA: 0x126CB98
	public void .ctor() { }

	// RVA: 0x126CBD4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class PerformanceCountersElement
{
	// Methods

	// RVA: 0x126CC10
	public void .ctor() { }

	// RVA: 0x126CC4C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class ServicePointManagerElement
{
	// Methods

	// RVA: 0x126CC88
	public void .ctor() { }

	// RVA: 0x126CCC4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class SocketElement
{
	// Methods

	// RVA: 0x126CD00
	public void .ctor() { }

	// RVA: 0x126CD3C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebProxyScriptElement
{
	// Methods

	// RVA: 0x126CD78
	public void .ctor() { }

	// RVA: 0x126CDB4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModulesSection
{
	// Methods

	// RVA: 0x126CDF0
	public void .ctor() { }

	// RVA: 0x126CE2C
	protected override ConfigurationPropertyCollection get_Properties() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElementCollection
{
	// Methods

	// RVA: 0x126CE68
	public void .ctor() { }

}

// Namespace: System.Net.Configuration
public sealed class WebRequestModuleElement
{}

// Namespace: System.Diagnostics
public class DiagnosticsConfigurationHandler
{
	// Methods

	// RVA: 0x126CEA4
	public void .ctor() { }

	// RVA: 0x126CEE0
	public virtual object Create(object parent, object configContext, XmlNode section) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0x126CF1C
	public static void ThrowNotSupportedException() { }

}


